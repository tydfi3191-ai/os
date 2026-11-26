using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;

// Token: 0x02000408 RID: 1032
public static class 270
{
	// Token: 0x06002067 RID: 8295 RVA: 0x00089748 File Offset: 0x00087948
	public static string 1(double 1, string 2)
	{
		string text = (2 == "osu") ? "" : ((2 == "taiko") ? "/taiko" : ((2 == "fruits") ? "/catch" : ((2 == "mania") ? "/mania" : null)));
		if (text == null)
		{
			throw new ArgumentException("mode");
		}
		if (261.FullyOffline)
		{
			261.9("network access while the game is set to fully offline");
		}
		if (double.IsNaN(1) || double.IsInfinity(1) || 1 <= 0.0 || 1 > 100000.0)
		{
			throw new ArgumentException("pp");
		}
		string uriString = string.Format(CultureInfo.InvariantCulture, "https://scores.nekiak.com{0}/rank?pp={1}", text, 1.ToString("0.##", CultureInfo.InvariantCulture));
		261.11(uriString);
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.CreateDefault(new Uri(uriString));
		httpWebRequest.Method = "GET";
		httpWebRequest.AllowAutoRedirect = false;
		httpWebRequest.UserAgent = 259.4;
		httpWebRequest.Accept = "application/json";
		httpWebRequest.Timeout = 10000;
		httpWebRequest.ReadWriteTimeout = 10000;
		httpWebRequest.AutomaticDecompression = (DecompressionMethods.GZip | DecompressionMethods.Deflate);
		string result;
		using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
		{
			if (httpWebResponse.StatusCode < HttpStatusCode.OK || httpWebResponse.StatusCode >= HttpStatusCode.MultipleChoices)
			{
				throw new WebException("Unexpected status.", null, WebExceptionStatus.ProtocolError, httpWebResponse);
			}
			using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.UTF8))
			{
				result = streamReader.ReadToEnd();
			}
		}
		return result;
	}

	// Token: 0x040010FE RID: 4350
	private const string 1 = "https://scores.nekiak.com{0}/rank?pp={1}";

	// Token: 0x040010FF RID: 4351
	private const int 2 = 10000;
}
