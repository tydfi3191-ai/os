using System;
using System.Collections.Generic;
using System.Net;

// Token: 0x020003FB RID: 1019
public static class 259
{
	// Token: 0x0600200F RID: 8207 RVA: 0x0008665C File Offset: 0x0008485C
	public static void 1(string 1)
	{
		if (string.IsNullOrEmpty(1) || 261.10(1))
		{
			throw new ArgumentException("Host cannot be allowed: " + 1);
		}
		if (261.FullyOffline)
		{
			return;
		}
		object obj = 259.2;
		lock (obj)
		{
			259.3.Add(1.Trim().TrimEnd(new char[]
			{
				'.'
			}));
		}
	}

	// Token: 0x06002010 RID: 8208 RVA: 0x000866E0 File Offset: 0x000848E0
	public static bool 2(string 1)
	{
		if (261.FullyOffline)
		{
			return false;
		}
		Uri uri;
		if (!Uri.TryCreate(1, UriKind.Absolute, out uri) || uri.Scheme != Uri.UriSchemeHttps)
		{
			return false;
		}
		if (261.10(uri.Host))
		{
			return false;
		}
		object obj = 259.2;
		bool result;
		lock (obj)
		{
			result = 259.3.Contains(uri.Host.TrimEnd(new char[]
			{
				'.'
			}));
		}
		return result;
	}

	// Token: 0x06002011 RID: 8209 RVA: 0x00086774 File Offset: 0x00084974
	public static HttpWebResponse Get(string 1, int 2, Action<HttpWebRequest> 3)
	{
		int num = 0;
		HttpWebResponse httpWebResponse;
		for (;;)
		{
			if (!259.2(1))
			{
				261.11(1);
				261.9("network access to a host that is not a registered beatmap mirror");
			}
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.CreateDefault(new Uri(1));
			httpWebRequest.Method = "GET";
			httpWebRequest.AllowAutoRedirect = false;
			httpWebRequest.UserAgent = 259.4;
			httpWebRequest.Timeout = 2;
			httpWebRequest.ReadWriteTimeout = 2;
			httpWebRequest.AutomaticDecompression = (DecompressionMethods.GZip | DecompressionMethods.Deflate);
			if (3 != null)
			{
				3(httpWebRequest);
			}
			try
			{
				httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			}
			catch (WebException ex)
			{
				httpWebResponse = (ex.Response as HttpWebResponse);
				if (httpWebResponse == null || httpWebResponse.StatusCode < HttpStatusCode.MultipleChoices || httpWebResponse.StatusCode >= HttpStatusCode.BadRequest)
				{
					throw;
				}
			}
			int statusCode = (int)httpWebResponse.StatusCode;
			if (statusCode < 300 || statusCode >= 400)
			{
				break;
			}
			string text = httpWebResponse.Headers[HttpResponseHeader.Location];
			httpWebResponse.Close();
			if (string.IsNullOrEmpty(text) || num >= 3)
			{
				goto IL_DD;
			}
			1 = new Uri(new Uri(1), text).AbsoluteUri;
			num++;
		}
		return httpWebResponse;
		IL_DD:
		throw new WebException("Beatmap mirror redirect could not be followed.", WebExceptionStatus.ProtocolError);
	}

	// Token: 0x040010BF RID: 4287
	private const int 1 = 3;

	// Token: 0x040010C0 RID: 4288
	private static readonly object 2 = new object();

	// Token: 0x040010C1 RID: 4289
	private static readonly HashSet<string> 3 = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

	// Token: 0x040010C2 RID: 4290
	public static string 4 = "nekiosu/1.0 (offline osu! client; beatmap mirror browser)";
}
