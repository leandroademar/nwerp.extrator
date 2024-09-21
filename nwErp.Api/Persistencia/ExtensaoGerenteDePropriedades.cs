namespace nwErp.Api.Persistencia
{
    public static class ExtensaoGerenteDePropriedades
    {
        public static void Carregar(this GerenteDePropriedades gerente)
        {
            PersistenciaDefinida.Persistencia.CarregarEntidade((IEntidade)gerente);
        }

        public static bool Existe(this GerenteDePropriedades gerente)
        {
            return PersistenciaDefinida.Persistencia.CarregarEntidade((IEntidade)gerente);
        }

        public static bool Persistir(this GerenteDePropriedades gerente, TipoPersistencia tipoPersistencia)
        {
            return PersistenciaDefinida.Persistencia.Persistir(tipoPersistencia, (IEntidade)gerente);
        }

        public static bool Incluir(this GerenteDePropriedades gerente)
        {
            return PersistenciaDefinida.Persistencia.Persistir(TipoPersistencia.INCLUIR, (IEntidade)gerente);
        }

        public static bool Alterar(this GerenteDePropriedades gerente)
        {
            return PersistenciaDefinida.Persistencia.Persistir(TipoPersistencia.ALTERAR, (IEntidade)gerente);
        }

        public static bool Excluir(this GerenteDePropriedades gerente)
        {
            return PersistenciaDefinida.Persistencia.Persistir(TipoPersistencia.DELETAR, (IEntidade)gerente);
        }

        public static void BuscarSimilaridade(this GerenteDePropriedades gerente, GerenteDePropriedades origem)
        {
            PropertyInfo[] properties = origem.GetType().GetProperties();
            foreach (PropertyInfo propertyInfo in properties)
            {
                PropertyInfo property = gerente.GetType().GetProperty(propertyInfo.Name);
                if (property != null && property.IsDefined(typeof(InfoCampoEntidade), inherit: true))
                {
                    try
                    {
                        property.SetValue(gerente, propertyInfo.GetValue(origem, null), null);
                    }
                    catch
                    {
                    }
                }
            }
        }

    }
}
