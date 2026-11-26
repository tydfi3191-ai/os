using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

// Token: 0x020003FC RID: 1020
public static class 267
{
	// Token: 0x17000228 RID: 552
	// (get) Token: 0x06002013 RID: 8211 RVA: 0x000868C0 File Offset: 0x00084AC0
	public static bool IsConfigured
	{
		get
		{
			if (261.FullyOffline)
			{
				return false;
			}
			object obj = 267.9;
			bool result;
			lock (obj)
			{
				result = (267.10.Length > 0 && 267.11.Length > 0);
			}
			return result;
		}
	}

	// Token: 0x06002014 RID: 8212 RVA: 0x00086924 File Offset: 0x00084B24
	public static void 1(string 1, string 2)
	{
		1 = (1 ?? "").Trim();
		2 = (2 ?? "").Trim();
		foreach (char c in 1)
		{
			if (c < '0' || c > '9')
			{
				throw new ArgumentException("The client ID is a number.");
			}
		}
		object obj = 267.9;
		lock (obj)
		{
			if (!(1 == 267.10) || !(2 == 267.11))
			{
				267.10 = 1;
				267.11 = 2;
				267.12 = null;
			}
		}
	}

	// Token: 0x06002015 RID: 8213 RVA: 0x000869E0 File Offset: 0x00084BE0
	public static void 2()
	{
		object obj = 267.9;
		string text;
		string text2;
		lock (obj)
		{
			text = 267.10;
			text2 = 267.11;
		}
		if (text.Length == 0 || text2.Length == 0)
		{
			throw new InvalidOperationException("Enter a client ID and a client secret first.");
		}
		byte[] bytes = Encoding.UTF8.GetBytes(string.Concat(new string[]
		{
			"client_id=",
			text,
			"&client_secret=",
			Uri.EscapeDataString(text2),
			"&grant_type=client_credentials&scope=public"
		}));
		HttpWebRequest httpWebRequest = 267.Create("https://osu.ppy.sh/oauth/token", "POST");
		httpWebRequest.ContentType = "application/x-www-form-urlencoded";
		httpWebRequest.ContentLength = (long)bytes.Length;
		string input;
		try
		{
			using (Stream requestStream = httpWebRequest.GetRequestStream())
			{
				requestStream.Write(bytes, 0, bytes.Length);
			}
			input = 267.11(httpWebRequest);
		}
		catch (WebException ex)
		{
			HttpWebResponse httpWebResponse = ex.Response as HttpWebResponse;
			if (httpWebResponse == null)
			{
				throw new InvalidOperationException("The osu! API could not be reached.");
			}
			int statusCode = (int)httpWebResponse.StatusCode;
			httpWebResponse.Close();
			if (statusCode == 400 || statusCode == 401)
			{
				throw new InvalidOperationException("The client ID or client secret was not accepted.");
			}
			throw new InvalidOperationException("The osu! API answered with an error (" + statusCode.ToString() + ").");
		}
		Match match = Regex.Match(input, "\"access_token\"\\s*:\\s*\"([^\"]+)\"");
		Match match2 = Regex.Match(input, "\"expires_in\"\\s*:\\s*(\\d+)");
		if (!match.Success)
		{
			throw new InvalidOperationException("The osu! API did not return a token.");
		}
		int num = match2.Success ? int.Parse(match2.Groups[1].Value, CultureInfo.InvariantCulture) : 3600;
		obj = 267.9;
		lock (obj)
		{
			if (text == 267.10 && text2 == 267.11)
			{
				267.12 = match.Groups[1].Value;
				267.13 = DateTime.UtcNow.AddSeconds((double)Math.Max(60, num - 120));
			}
		}
	}

	// Token: 0x06002016 RID: 8214 RVA: 0x00086C2C File Offset: 0x00084E2C
	public static string 3(int 1, string 2, string[] 3, bool 4, int 5)
	{
		if (1 <= 0)
		{
			throw new ArgumentException("beatmapId");
		}
		if (2 != "osu" && 2 != "taiko" && 2 != "fruits" && 2 != "mania")
		{
			throw new ArgumentException("mode");
		}
		StringBuilder stringBuilder = new StringBuilder(string.Format(CultureInfo.InvariantCulture, "https://osu.ppy.sh/api/v2/beatmaps/{0}/scores", 1));
		stringBuilder.Append("?mode=").Append(2).Append("&limit=").Append(Math.Max(1, Math.Min(100, 5)));
		if (4)
		{
			stringBuilder.Append("&legacy_only=1");
		}
		if (3 != null)
		{
			foreach (string text in 3)
			{
				if (text == null || text.Length != 2 || !267.8(text[0]) || !267.8(text[1]))
				{
					throw new ArgumentException("mods");
				}
				stringBuilder.Append("&mods[]=").Append(text);
			}
		}
		return 267.Get(stringBuilder.ToString(), "{\"scores\":[]}");
	}

	// Token: 0x06002017 RID: 8215 RVA: 0x00086D50 File Offset: 0x00084F50
	private static string 4(string 1)
	{
		if (1 != "osu" && 1 != "taiko" && 1 != "fruits" && 1 != "mania")
		{
			throw new ArgumentException("mode");
		}
		return 1;
	}

	// Token: 0x06002018 RID: 8216 RVA: 0x00086DA0 File Offset: 0x00084FA0
	public static string 5(string 1, string 2)
	{
		1 = (1 ?? "").Trim();
		if (1.Length == 0 || 1.Length > 32)
		{
			throw new ArgumentException("osu! names are 1 to 32 characters long.");
		}
		foreach (char c in 1)
		{
			if (!267.8(char.ToUpperInvariant(c)) && c != ' ' && c != '_' && c != '-' && c != '[' && c != ']')
			{
				throw new ArgumentException("The name has characters osu! names do not have.");
			}
		}
		return 267.Get(string.Format(CultureInfo.InvariantCulture, "https://osu.ppy.sh/api/v2/users/@{0}/{1}", Uri.EscapeDataString(1), 267.4(2)), null);
	}

	// Token: 0x06002019 RID: 8217 RVA: 0x00086E48 File Offset: 0x00085048
	public static string 6(long 1, int 2, int 3, string 4)
	{
		if (1 <= 0L)
		{
			throw new ArgumentException("userId");
		}
		if (2 < 0 || 2 > 199)
		{
			throw new ArgumentException("offset");
		}
		if (3 < 1 || 3 > 100)
		{
			throw new ArgumentException("limit");
		}
		return 267.Get(string.Format(CultureInfo.InvariantCulture, "https://osu.ppy.sh/api/v2/users/{0}/scores/best?mode={3}&legacy_only=1&limit={1}&offset={2}", new object[]
		{
			1,
			3,
			2,
			267.4(4)
		}), "[]");
	}

	// Token: 0x0600201A RID: 8218 RVA: 0x00086ED4 File Offset: 0x000850D4
	public static string 7(string 1, int 2, string 3)
	{
		if (1 == null || 1.Length != 2 || 1[0] < 'A' || 1[0] > 'Z' || 1[1] < 'A' || 1[1] > 'Z')
		{
			throw new ArgumentException("country");
		}
		if (2 < 1 || 2 > 200)
		{
			throw new ArgumentException("page");
		}
		return 267.Get(string.Format(CultureInfo.InvariantCulture, "https://osu.ppy.sh/api/v2/rankings/{2}/performance?country={0}&cursor%5Bpage%5D={1}", 1, 2, 267.4(3)), null);
	}

	// Token: 0x0600201B RID: 8219 RVA: 0x00086F60 File Offset: 0x00085160
	private static string Get(string 1, string 2)
	{
		int num = 0;
		for (;;)
		{
			object obj = 267.9;
			string text;
			lock (obj)
			{
				text = ((267.12 != null && DateTime.UtcNow < 267.13) ? 267.12 : null);
			}
			if (text == null)
			{
				267.2();
				obj = 267.9;
				lock (obj)
				{
					text = 267.12;
				}
			}
			if (text == null)
			{
				break;
			}
			267.9();
			HttpWebRequest httpWebRequest = 267.Create(1, "GET");
			httpWebRequest.Headers[HttpRequestHeader.Authorization] = "Bearer " + text;
			try
			{
				return 267.11(httpWebRequest);
			}
			catch (WebException ex)
			{
				HttpWebResponse httpWebResponse = ex.Response as HttpWebResponse;
				int num2 = (int)((httpWebResponse == null) ? ((HttpStatusCode)0) : httpWebResponse.StatusCode);
				if (httpWebResponse != null)
				{
					httpWebResponse.Close();
				}
				if (num2 == 401 && num == 0)
				{
					obj = 267.9;
					lock (obj)
					{
						267.12 = null;
					}
				}
				else
				{
					if (num2 == 404)
					{
						return 2;
					}
					throw new InvalidOperationException((num2 == 0) ? "The osu! API could not be reached." : ("The osu! API answered with an error (" + num2.ToString() + ")."));
				}
			}
			num++;
		}
		throw new InvalidOperationException("The osu! API is not set up.");
	}

	// Token: 0x0600201C RID: 8220 RVA: 0x000870EC File Offset: 0x000852EC
	private static bool 8(char 1)
	{
		return (1 >= 'A' && 1 <= 'Z') || (1 >= '0' && 1 <= '9');
	}

	// Token: 0x0600201D RID: 8221 RVA: 0x0008710C File Offset: 0x0008530C
	private static void 9()
	{
		object obj = 267.9;
		int num;
		lock (obj)
		{
			DateTime utcNow = DateTime.UtcNow;
			DateTime d = (267.14.AddMilliseconds(1000.0) > utcNow) ? 267.14.AddMilliseconds(1000.0) : utcNow;
			num = (int)(d - utcNow).TotalMilliseconds;
			267.14 = d;
		}
		if (num > 0)
		{
			Thread.Sleep(num);
		}
	}

	// Token: 0x0600201E RID: 8222 RVA: 0x000871A0 File Offset: 0x000853A0
	public static byte[] 10(long 1)
	{
		if (1 <= 0L)
		{
			throw new ArgumentException("userId");
		}
		HttpWebRequest httpWebRequest = 267.Create(string.Format(CultureInfo.InvariantCulture, "https://a.ppy.sh/{0}", 1), "GET");
		httpWebRequest.Accept = "image/*";
		byte[] result;
		try
		{
			using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
			{
				if (httpWebResponse.StatusCode != HttpStatusCode.OK || httpWebResponse.ContentType == null || !httpWebResponse.ContentType.StartsWith("image/", StringComparison.OrdinalIgnoreCase))
				{
					throw new InvalidOperationException("The avatar could not be read.");
				}
				using (Stream responseStream = httpWebResponse.GetResponseStream())
				{
					using (MemoryStream memoryStream = new MemoryStream())
					{
						byte[] array = new byte[8192];
						int count;
						while ((count = responseStream.Read(array, 0, array.Length)) > 0)
						{
							memoryStream.Write(array, 0, count);
							if (memoryStream.Length > 4194304L)
							{
								throw new InvalidOperationException("The avatar is too large.");
							}
						}
						result = memoryStream.ToArray();
					}
				}
			}
		}
		catch (WebException)
		{
			throw new InvalidOperationException("The avatar could not be downloaded.");
		}
		return result;
	}

	// Token: 0x0600201F RID: 8223 RVA: 0x000872E4 File Offset: 0x000854E4
	private static HttpWebRequest Create(string 1, string 2)
	{
		if (261.FullyOffline)
		{
			261.9("network access while the game is set to fully offline");
		}
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.CreateDefault(new Uri(1));
		httpWebRequest.Method = 2;
		httpWebRequest.AllowAutoRedirect = false;
		httpWebRequest.UserAgent = 259.4;
		httpWebRequest.Accept = "application/json";
		httpWebRequest.Timeout = 15000;
		httpWebRequest.ReadWriteTimeout = 15000;
		httpWebRequest.AutomaticDecompression = (DecompressionMethods.GZip | DecompressionMethods.Deflate);
		return httpWebRequest;
	}

	// Token: 0x06002020 RID: 8224 RVA: 0x00087354 File Offset: 0x00085554
	private static string 11(HttpWebRequest 1)
	{
		string result;
		using (HttpWebResponse httpWebResponse = (HttpWebResponse)1.GetResponse())
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

	// Token: 0x040010C3 RID: 4291
	private const string 1 = "https://osu.ppy.sh/oauth/token";

	// Token: 0x040010C4 RID: 4292
	private const string 2 = "https://osu.ppy.sh/api/v2/beatmaps/{0}/scores";

	// Token: 0x040010C5 RID: 4293
	private const string 3 = "https://osu.ppy.sh/api/v2/users/@{0}/{1}";

	// Token: 0x040010C6 RID: 4294
	private const string 4 = "https://osu.ppy.sh/api/v2/users/{0}/scores/best?mode={3}&legacy_only=1&limit={1}&offset={2}";

	// Token: 0x040010C7 RID: 4295
	private const string 5 = "https://a.ppy.sh/{0}";

	// Token: 0x040010C8 RID: 4296
	private const string 6 = "https://osu.ppy.sh/api/v2/rankings/{2}/performance?country={0}&cursor%5Bpage%5D={1}";

	// Token: 0x040010C9 RID: 4297
	private const int 7 = 4194304;

	// Token: 0x040010CA RID: 4298
	private const int 8 = 15000;

	// Token: 0x040010CB RID: 4299
	private static readonly object 9 = new object();

	// Token: 0x040010CC RID: 4300
	private static string 10 = "";

	// Token: 0x040010CD RID: 4301
	private static string 11 = "";

	// Token: 0x040010CE RID: 4302
	private static string 12;

	// Token: 0x040010CF RID: 4303
	private static DateTime 13;

	// Token: 0x040010D0 RID: 4304
	private static DateTime 14;
}
