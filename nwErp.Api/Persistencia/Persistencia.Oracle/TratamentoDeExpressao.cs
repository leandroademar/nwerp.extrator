using System.Collections;
using System.Globalization;
using System.Linq.Expressions;
using System.Text;

namespace nwErp.Api.Persistencia.Oracle
{
    public static class TratamentoDeExpressao
    {
        private static readonly Dictionary<string, string> dicionario = new Dictionary<string, string>
    {
        { "ToUpper", "UPPER({0})" },
        { "ToLower", "LOWER({0})" },
        { "ToString", "TO_CHAR({0})" },
        { "Trim", "TRIM({0})" },
        { "GetValueOrDefault", "NVL({0}, :ARGUMENTO)" },
        { "Int32", "TO_NUMBER({0})" },
        { "String", "TO_CHAR({0})" },
        { "DateTimeParse", "TO_DATE({0})" },
        { "Int32Parse", "TO_NUMBER({0})" },
        { "Contains", "{0} IN (:LISTA)" },
        { "AddDays", "{0} + (:ARGUMENTO)" },
        { "StringEquals", "{0} LIKE :ARGUMENTO" },
        { "Replace", "Replace({0}, :ARGUMENTO)" },
        { "Decimal", "({0})" },
        { "Double", "({0})" }
    };

        private const char PIPE = '|';

        private const string VIRGULA = ",";

        private const string SQL_NULL = " NULL ";

        private const string SQL_IS = " IS ";

        private const string SQL_IS_NOT = " IS NOT ";

        private const string SQL_OR = " OR ";

        private const string SQL_AND = " AND ";

        private const string SQL_NOT = " NOT ";

        private const string SQL_MULTIPLICACAO = " * ";

        private const string SQL_SUBTRACAO = " - ";

        private const string SQL_SOMA = " + ";

        private const string SQL_DIVISAO = " / ";

        private const string SQL_DIFERENTE = " <> ";

        private const string SQL_IGUAL = " = ";

        private const string SQL_MAIOR = " > ";

        private const string SQL_MAIOR_OU_IGUAL = " >= ";

        private const string SQL_MENOR = " < ";

        private const string SQL_MENOR_OU_IGUAL = " <= ";

        internal static void TratarExpressao(Expression expressao, StringBuilder filtro)
        {
            if (expressao is BinaryExpression)
            {
                BuscarExpressao((BinaryExpression)expressao, filtro);
            }
            else if (expressao is ConstantExpression)
            {
                BuscarExpressao((ConstantExpression)expressao, filtro);
            }
            else if (expressao is MemberExpression)
            {
                BuscarExpressao((MemberExpression)expressao, filtro);
            }
            else if (expressao is NewExpression)
            {
                BuscarExpressao((NewExpression)expressao, filtro);
            }
            else if (expressao is UnaryExpression)
            {
                BuscarExpressao((UnaryExpression)expressao, filtro);
            }
            else if (expressao is LambdaExpression)
            {
                BuscarExpressao((LambdaExpression)expressao, filtro);
            }
            else if (expressao is MethodCallExpression)
            {
                BuscarExpressao((MethodCallExpression)expressao, filtro);
            }
            else if (expressao is TypeBinaryExpression)
            {
                BuscarExpressao((TypeBinaryExpression)expressao, filtro);
            }
            else if (expressao is ParameterExpression)
            {
                BuscarExpressao((ParameterExpression)expressao, filtro);
            }
            else if (expressao is NewArrayExpression)
            {
                BuscarExpressao((NewArrayExpression)expressao, filtro);
            }
            else if (expressao is InvocationExpression)
            {
                BuscarExpressao((InvocationExpression)expressao, filtro);
            }
            else
            {
                filtro.Append((expressao == null) ? "EXPRESSAO NULA" : expressao.GetType().Name);
            }
        }

        private static void BuscarExpressao(InvocationExpression invocationExpression, StringBuilder filtro)
        {
            foreach (Expression argument in invocationExpression.Arguments)
            {
                TratarExpressao(argument, filtro);
            }
            TratarExpressao(invocationExpression.Expression, filtro);
        }

        private static void BuscarExpressao(NewArrayExpression novoArray, StringBuilder filtro)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (Expression expression in novoArray.Expressions)
            {
                if (stringBuilder.Length == 0)
                {
                    TratarExpressao(expression, stringBuilder);
                    continue;
                }
                stringBuilder.Append(",");
                TratarExpressao(expression, stringBuilder);
            }
            filtro.Append(stringBuilder.ToString());
        }

        private static void BuscarExpressao(ParameterExpression expressaoDeParametro, StringBuilder filtro)
        {
            filtro.Append(expressaoDeParametro.Name);
        }

        private static void BuscarExpressao(TypeBinaryExpression expressaoDeTipoBinario, StringBuilder filtro)
        {
            TratarExpressao(expressaoDeTipoBinario.Expression, filtro);
            BuscarExpressaoPeloTipo(expressaoDeTipoBinario.NodeType, filtro);
            filtro.Append(" " + expressaoDeTipoBinario.TypeOperand.Name);
        }

        private static void BuscarExpressao(MethodCallExpression expressaoDeMetodo, StringBuilder filtro)
        {
            string text = null;
            StringBuilder stringBuilder = new StringBuilder();
            string[] array = null;
            foreach (Expression argument in expressaoDeMetodo.Arguments)
            {
                if (argument is NewArrayExpression || (argument is MemberExpression && ((MemberExpression)argument).Type.GetInterface("IList") != null))
                {
                    StringBuilder stringBuilder2 = new StringBuilder();
                    TratarExpressao(argument, stringBuilder2);
                    array = (from valor in stringBuilder2.ToString().Split('|')
                             where !string.IsNullOrEmpty(valor)
                             select valor).ToArray();
                }
                else if (stringBuilder.Length > 0)
                {
                    stringBuilder.Append(",");
                    TratarExpressao(argument, stringBuilder);
                }
                else
                {
                    TratarExpressao(argument, stringBuilder);
                }
            }
            string text2 = expressaoDeMetodo.Method.Name;
            if (text2.Equals("Parse") || text2.Equals("Equals"))
            {
                text2 = expressaoDeMetodo.Method.DeclaringType.Name + text2;
            }
            text = ObterMetodo(text2);
            if (text == text2 + "({0})")
            {
                filtro.Append(ValidarValorPeloTipo(TratarExpressaoComoObjeto(expressaoDeMetodo)));
                return;
            }
            if (string.IsNullOrEmpty(text))
            {
                text = "{0}";
            }
            if (text2 == "Contains" && expressaoDeMetodo.Object != null)
            {
                if (array == null || array.Count() == 0)
                {
                    StringBuilder stringBuilder3 = new StringBuilder();
                    TratarExpressao(expressaoDeMetodo.Object, stringBuilder3);
                    array = stringBuilder3.ToString().Split('|');
                }
                text = string.Format(text, stringBuilder);
            }
            else
            {
                StringBuilder stringBuilder4 = new StringBuilder();
                TratarExpressao(expressaoDeMetodo.Object, stringBuilder4);
                text = string.Format(text, (expressaoDeMetodo.Object == null) ? stringBuilder.ToString() : stringBuilder4.ToString());
            }
            if (array != null && array.Count() > 0)
            {
                string text3 = text;
                StringBuilder stringBuilder5 = new StringBuilder();
                string[] array2 = array;
                foreach (string newValue in array2)
                {
                    if (stringBuilder5.Length == 0)
                    {
                        stringBuilder5.Append(text3.Replace(":LISTA", newValue).Replace(":ARGUMENTO", stringBuilder.ToString()));
                        continue;
                    }
                    stringBuilder5.Append(" OR ");
                    stringBuilder5.Append(text3.Replace(":LISTA", newValue).Replace(":ARGUMENTO", stringBuilder.ToString()));
                }
                filtro.Append(stringBuilder5.ToString());
            }
            else
            {
                filtro.Append(text.Replace(":LISTA", " NULL ").Replace(":ARGUMENTO", stringBuilder.ToString()));
            }
        }

        private static string ObterMetodo(string chave)
        {
            if (dicionario.ContainsKey(chave))
            {
                return dicionario[chave];
            }
            return chave + "({0})";
        }

        private static void BuscarExpressao(LambdaExpression expressaoLambda, StringBuilder filtro)
        {
            if (expressaoLambda.Parameters.Count <= 0 || expressaoLambda.Body != expressaoLambda.Parameters[0] || !(expressaoLambda.Body.GetType() == typeof(ParameterExpression)))
            {
                TratarExpressao(expressaoLambda.Body, filtro);
            }
        }

        private static void BuscarExpressao(BinaryExpression expressaoBinaria, StringBuilder filtro)
        {
            string format = "{0} {1} {2}";
            new StringBuilder();
            StringBuilder stringBuilder = new StringBuilder();
            StringBuilder stringBuilder2 = new StringBuilder();
            StringBuilder stringBuilder3 = new StringBuilder();
            TratarExpressao(expressaoBinaria.Left, stringBuilder);
            BuscarExpressaoPeloTipo(expressaoBinaria.NodeType, stringBuilder2);
            TratarExpressao(expressaoBinaria.Right, stringBuilder3);
            if (stringBuilder3.ToString() == " NULL ")
            {
                if (stringBuilder2.ToString() == " = ")
                {
                    stringBuilder2 = new StringBuilder(" IS ");
                }
                else if (stringBuilder2.ToString() == " <> ")
                {
                    stringBuilder2 = new StringBuilder(" IS NOT ");
                }
            }
            if (expressaoBinaria.NodeType == ExpressionType.Coalesce)
            {
                format = "NVL({0}{1}{2})";
            }
            else if (expressaoBinaria.NodeType == ExpressionType.AndAlso || expressaoBinaria.NodeType == ExpressionType.OrElse)
            {
                format = "({0}) {1} ({2})";
            }
            filtro.Append(string.Format(format, stringBuilder.ToString(), stringBuilder2.ToString(), stringBuilder3.ToString()));
        }

        private static void BuscarExpressao(ConstantExpression expressaoConstante, StringBuilder filtro)
        {
            filtro.Append(ValidarValorPeloTipo(expressaoConstante.Value));
        }

        private static string ValidarValorPeloTipo(object valor)
        {
            if (valor == null)
            {
                return " NULL ";
            }
            if (valor is string)
            {
                return $"'{valor}'";
            }
            if (valor is DateTime dateTime)
            {
                if (dateTime.Hour + dateTime.Minute + dateTime.Second == 0)
                {
                    return string.Format("TO_DATE('{0}','DD/MM/YYYY')", ((DateTime)valor).ToString("dd/MM/yyyy"));
                }
                return string.Format("TO_DATE('{0}','DD/MM/YYYY HH24:MI:SS')", ((DateTime)valor).ToString("dd/MM/yyyy HH:mm:ss"));
            }
            if (valor is double)
            {
                string text = valor.ToString();
                if ((double)valor < 0.0)
                {
                    text = $"({text})";
                }
                return text;
            }
            if (valor is int)
            {
                string text2 = valor.ToString();
                if ((int)valor < 0)
                {
                    text2 = $"({text2})";
                }
                return text2;
            }
            if (valor is decimal)
            {
                NumberFormatInfo numberFormatInfo = new NumberFormatInfo();
                numberFormatInfo.NumberDecimalSeparator = ".";
                numberFormatInfo.NumberGroupSeparator = string.Empty;
                string text3 = ((decimal)valor).ToString(numberFormatInfo);
                if ((decimal)valor < 0m)
                {
                    text3 = $"({text3})";
                }
                return text3;
            }
            if (valor is bool)
            {
                if (!(bool)valor)
                {
                    return " 1 = 2";
                }
                return " 1 = 1 ";
            }
            if (valor.GetType().GetInterface("IList") != null)
            {
                StringBuilder stringBuilder = new StringBuilder();
                int num = 0;
                foreach (object item in (IList)valor)
                {
                    if (stringBuilder.Length == 0)
                    {
                        stringBuilder.Append(ValidarValorPeloTipo(item));
                    }
                    else if (stringBuilder[stringBuilder.Length - 1] == '|')
                    {
                        stringBuilder.Append(ValidarValorPeloTipo(item));
                    }
                    else
                    {
                        stringBuilder.Append(",");
                        stringBuilder.Append(ValidarValorPeloTipo(item));
                    }
                    num++;
                    if (num % 1000 == 0)
                    {
                        stringBuilder.Append('|');
                    }
                }
                return stringBuilder.ToString();
            }
            return valor.ToString();
        }

        private static void BuscarExpressao(MemberExpression expressaoDeMembro, StringBuilder filtro)
        {
            object obj = BuscarExpressaoComoObjeto(expressaoDeMembro);
            if (obj == null && expressaoDeMembro.Expression is ParameterExpression)
            {
                filtro.Append(expressaoDeMembro.Member.Name);
            }
            else
            {
                filtro.Append(ValidarValorPeloTipo(obj));
            }
        }

        private static void BuscarExpressao(NewExpression expressaoDeCriacao, StringBuilder filtro)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (Expression argument in expressaoDeCriacao.Arguments)
            {
                if (stringBuilder.Length == 0)
                {
                    TratarExpressao(argument, stringBuilder);
                    continue;
                }
                stringBuilder.Append(",");
                TratarExpressao(argument, stringBuilder);
            }
            filtro.Append(stringBuilder);
        }

        private static void BuscarExpressao(UnaryExpression expressaoUnary, StringBuilder filtro)
        {
            if (expressaoUnary.NodeType == ExpressionType.Convert)
            {
                if (expressaoUnary.Type.Name != "Nullable`1" && expressaoUnary.Type.Name != "Object")
                {
                    StringBuilder stringBuilder = new StringBuilder();
                    TratarExpressao(expressaoUnary.Operand, stringBuilder);
                    filtro.Append(string.Format(ObterMetodo(expressaoUnary.Type.Name), stringBuilder.ToString()));
                }
                else
                {
                    TratarExpressao(expressaoUnary.Operand, filtro);
                }
                return;
            }
            StringBuilder stringBuilder2 = new StringBuilder();
            TratarExpressao(expressaoUnary.Operand, stringBuilder2);
            if (expressaoUnary.Type != typeof(bool))
            {
                filtro.Append(expressaoUnary.NodeType.ToString());
                filtro.Append("(");
                filtro.Append(expressaoUnary.Type.Name);
                filtro.Append(", ");
                filtro.Append(stringBuilder2.ToString());
                filtro.Append(")");
            }
            else
            {
                filtro.Append(expressaoUnary.NodeType.ToString());
                filtro.Append("(");
                filtro.Append(stringBuilder2.ToString());
                filtro.Append(")");
            }
        }

        private static void BuscarExpressaoPeloTipo(ExpressionType tipoDeExpressao, StringBuilder filtro)
        {
            switch (tipoDeExpressao)
            {
                case ExpressionType.Add:
                    filtro.Append(" + ");
                    break;
                case ExpressionType.And:
                case ExpressionType.AndAlso:
                    filtro.Append(" AND ");
                    break;
                case ExpressionType.Coalesce:
                    filtro.Append(",");
                    break;
                case ExpressionType.Convert:
                    filtro.Append(string.Empty);
                    break;
                case ExpressionType.Divide:
                    filtro.Append(" / ");
                    break;
                case ExpressionType.Equal:
                    filtro.Append(" = ");
                    break;
                case ExpressionType.GreaterThan:
                    filtro.Append(" > ");
                    break;
                case ExpressionType.GreaterThanOrEqual:
                    filtro.Append(" >= ");
                    break;
                case ExpressionType.LessThan:
                    filtro.Append(" < ");
                    break;
                case ExpressionType.LessThanOrEqual:
                    filtro.Append(" <= ");
                    break;
                case ExpressionType.Multiply:
                    filtro.Append(" * ");
                    break;
                case ExpressionType.Not:
                    filtro.Append(" NOT ");
                    break;
                case ExpressionType.NotEqual:
                    filtro.Append(" <> ");
                    break;
                case ExpressionType.Or:
                case ExpressionType.OrElse:
                    filtro.Append(" OR ");
                    break;
                case ExpressionType.Subtract:
                    filtro.Append(" - ");
                    break;
                default:
                    filtro.Append(tipoDeExpressao.ToString());
                    break;
                case ExpressionType.AddChecked:
                case ExpressionType.ArrayLength:
                case ExpressionType.ArrayIndex:
                case ExpressionType.Call:
                case ExpressionType.Conditional:
                case ExpressionType.Constant:
                case ExpressionType.ConvertChecked:
                case ExpressionType.ExclusiveOr:
                case ExpressionType.Invoke:
                case ExpressionType.Lambda:
                case ExpressionType.LeftShift:
                case ExpressionType.ListInit:
                case ExpressionType.MemberAccess:
                case ExpressionType.MemberInit:
                case ExpressionType.Modulo:
                case ExpressionType.MultiplyChecked:
                case ExpressionType.Negate:
                case ExpressionType.UnaryPlus:
                case ExpressionType.NegateChecked:
                case ExpressionType.New:
                case ExpressionType.NewArrayInit:
                case ExpressionType.NewArrayBounds:
                case ExpressionType.Parameter:
                case ExpressionType.Power:
                case ExpressionType.Quote:
                case ExpressionType.RightShift:
                case ExpressionType.SubtractChecked:
                case ExpressionType.TypeAs:
                case ExpressionType.TypeIs:
                    break;
            }
        }

        public static object TratarExpressaoComoObjeto(Expression expressao)
        {
            if (expressao is ConstantExpression)
            {
                return BuscarExpressaoComoObjeto((ConstantExpression)expressao);
            }
            if (expressao is MemberExpression)
            {
                return BuscarExpressaoComoObjeto((MemberExpression)expressao);
            }
            if (expressao is MethodCallExpression)
            {
                return BuscarExpressaoComoObjeto((MethodCallExpression)expressao);
            }
            return null;
        }

        private static object BuscarExpressaoComoObjeto(MethodCallExpression expressaoDeMetodo)
        {
            object obj = null;
            if (expressaoDeMetodo.Object != null)
            {
                obj = TratarExpressaoComoObjeto(expressaoDeMetodo.Object);
            }
            List<object> list = new List<object>();
            foreach (Expression argument in expressaoDeMetodo.Arguments)
            {
                list.Add(TratarExpressaoComoObjeto(argument));
            }
            return expressaoDeMetodo.Method.Invoke(obj, list.ToArray());
        }

        private static object BuscarExpressaoComoObjeto(ConstantExpression expressaoConstante)
        {
            return expressaoConstante.Value;
        }

        private static object BuscarExpressaoComoObjeto(MemberExpression expressaoDeMembro)
        {
            object obj = null;
            if (expressaoDeMembro.Expression != null)
            {
                if (!(expressaoDeMembro.Expression is MethodCallExpression))
                {
                    object valor = null;
                    Expression expression = expressaoDeMembro.Expression;
                    Stack<Expression> stack = new Stack<Expression>();
                    stack.Push(expression);
                    while (expression is MemberExpression)
                    {
                        expression = ((MemberExpression)expression).Expression;
                        stack.Push(expression);
                    }
                    while (stack.Count != 0)
                    {
                        expression = stack.Pop();
                        valor = ((!(expression is MemberExpression)) ? TratarExpressaoComoObjeto(expression) : BuscarValorDoCampo((MemberExpression)expression, valor));
                    }
                    try
                    {
                        obj = BuscarValorDoCampo(expressaoDeMembro, valor);
                    }
                    catch
                    {
                        obj = null;
                    }
                }
                else if (expressaoDeMembro.Expression is MethodCallExpression)
                {
                    obj = BuscarValorDoCampo(expressaoDeMembro, TratarExpressaoComoObjeto((MethodCallExpression)expressaoDeMembro.Expression));
                }
            }
            else
            {
                obj = BuscarValorDoCampo(expressaoDeMembro, obj);
            }
            return obj;
        }

        private static object BuscarValorDoCampo(MemberExpression expressaoDeMembro, object valor)
        {
            if (expressaoDeMembro.Member is FieldInfo)
            {
                valor = ((FieldInfo)expressaoDeMembro.Member).GetValue(valor);
            }
            else if (expressaoDeMembro.Member is PropertyInfo)
            {
                valor = ((PropertyInfo)expressaoDeMembro.Member).GetValue(valor, null);
            }
            return valor;
        }
    }

}
