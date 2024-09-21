namespace nwErp.Api.Importadores;

internal static class CorrigirVD
{
	public static string ObterSittribut(string codecf, string sittribut)
	{
		if (!(codecf == "0001"))
		{
			switch (sittribut)
			{
			case "101":
			case "102":
			case "103":
			case "300":
			case "400":
			case "900":
			case "500":
			case "10":
			case "70":
				break;
			default:
			{
				if (codecf == null)
				{
					return null;
				}
				if (decimal.TryParse(codecf, out var _) && sittribut != null && sittribut.Contains("20"))
				{
					return "20";
				}
				return codecf.Substring(0, 1) switch
				{
					"F" => "60", 
					"N" => "41", 
					"I" => "40", 
					_ => "00", 
				};
			}
			}
		}
		return sittribut;
	}

	public static string FormatarCODECF(string codecf)
	{
		if (codecf == "0001")
		{
			return codecf;
		}
		if (codecf.Substring(0, 1).ToUpper() == "F")
		{
			return "FF";
		}
		if (codecf.Substring(0, 1).ToUpper() == "N")
		{
			return "NN";
		}
		if (codecf.Substring(0, 1).ToUpper() == "I")
		{
			return "II";
		}
		if (decimal.TryParse(codecf, out var result))
		{
			if (result < 10m && Math.Round(result, 0) == result)
			{
				return $"0{result}00";
			}
			if (result.ToString().Length == 2 && Math.Round(result, 0) == result)
			{
				return $"{result}00";
			}
			return codecf;
		}
		return codecf;
	}

	public static decimal ObterPercICMS(string codecf)
	{
		if (decimal.TryParse(codecf, out var result))
		{
			return result / 100m;
		}
		return 0m;
	}
}
