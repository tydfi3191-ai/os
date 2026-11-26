using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.Win32;

// Token: 0x020003FD RID: 1021
public static class 273
{
	// Token: 0x06002022 RID: 8226 RVA: 0x00087400 File Offset: 0x00085600
	public static 273.275 1(string 1)
	{
		string text = "?v=" + Uri.EscapeDataString("1.1.8");
		if (1 != null && Regex.IsMatch(1, "^[0-9a-f]{32}$"))
		{
			text = text + "&id=" + 1;
		}
		string @string = Encoding.UTF8.GetString(273.Get("https://nekiosu.nekiak.com/version.json" + text, 65536L, null, 6000));
		273.274 2 = new 273.274
		{
			1 = 273.9(@string, "version"),
			2 = 273.9(@string, "url"),
			3 = (273.9(@string, "sha256") ?? "").ToLowerInvariant()
		};
		if (2.1 == null)
		{
			throw new InvalidOperationException("The version file is not as expected.");
		}
		string text2 = 273.9(@string, "minimum");
		273.275 3 = new 273.275
		{
			2 = Regex.IsMatch(@string, "\"enabled\"\\s*:\\s*false"),
			3 = (text2 != null && 273.8("1.1.8", text2) < 0),
			4 = 273.9(@string, "message"),
			5 = (261.23(273.9(@string, "discord")) ? 273.9(@string, "discord") : null)
		};
		if (273.8(2.1, "1.1.8") > 0)
		{
			if (2.2 == null || 2.3.Length != 64)
			{
				throw new InvalidOperationException("The version file is not as expected.");
			}
			3.1 = 2;
		}
		return 3;
	}

	// Token: 0x06002023 RID: 8227 RVA: 0x00087574 File Offset: 0x00085774
	public static bool 2()
	{
		bool result;
		try
		{
			result = NetworkInterface.GetIsNetworkAvailable();
		}
		catch (Exception)
		{
			result = true;
		}
		return result;
	}

	// Token: 0x06002024 RID: 8228 RVA: 0x000875A0 File Offset: 0x000857A0
	public static string 3()
	{
		return Encoding.UTF8.GetString(273.Get("https://nekiosu.nekiak.com/changelog?since=" + Uri.EscapeDataString("1.1.8"), 262144L, null, 6000)).Trim();
	}

	// Token: 0x06002025 RID: 8229 RVA: 0x000875D8 File Offset: 0x000857D8
	public static byte[] Download(273.274 1, Action<double> 2)
	{
		byte[] array = 273.Get(1.2, 268435456L, 2, 15000);
		string a;
		using (SHA256 sha = SHA256.Create())
		{
			a = BitConverter.ToString(sha.ComputeHash(array)).Replace("-", "").ToLowerInvariant();
		}
		if (a != 1.3)
		{
			throw new InvalidOperationException("The download does not match the version file (SHA-256).");
		}
		return array;
	}

	// Token: 0x06002026 RID: 8230 RVA: 0x0008765C File Offset: 0x0008585C
	public static void 4(byte[] 1, string 2)
	{
		string fileName = Process.GetCurrentProcess().MainModule.FileName;
		string text = fileName + ".old";
		if (File.Exists(text))
		{
			File.Delete(text);
		}
		File.Move(fileName, text);
		try
		{
			File.WriteAllBytes(fileName, 1);
		}
		catch
		{
			File.Move(text, fileName);
			throw;
		}
		273.5(2);
		272.3();
		272.5();
		Process.Start(new ProcessStartInfo(fileName)
		{
			UseShellExecute = false,
			WorkingDirectory = Path.GetDirectoryName(fileName)
		});
		Environment.Exit(0);
	}

	// Token: 0x06002027 RID: 8231 RVA: 0x000876F4 File Offset: 0x000858F4
	private static void 5(string 1)
	{
		try
		{
			using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\{7E2B5C1A-4F3D-4B8E-9A61-2C5D8F0E3B47}_is1", true))
			{
				if (registryKey != null && !string.IsNullOrEmpty(1))
				{
					registryKey.SetValue("DisplayVersion", 1);
					registryKey.SetValue("DisplayName", "nekiosu");
				}
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06002028 RID: 8232 RVA: 0x00087768 File Offset: 0x00085968
	public static void 6()
	{
		try
		{
			string fileName = Process.GetCurrentProcess().MainModule.FileName;
			string text = "\"" + fileName + "\" \"%1\"";
			using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Classes\\nekiosu\\shell\\open\\command"))
			{
				if (registryKey != null && string.Equals(registryKey.GetValue("") as string, text, StringComparison.OrdinalIgnoreCase))
				{
					return;
				}
			}
			using (RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("Software\\Classes\\nekiosu"))
			{
				registryKey2.SetValue("", "URL:nekiosu");
				registryKey2.SetValue("URL Protocol", "");
				using (RegistryKey registryKey3 = registryKey2.CreateSubKey("DefaultIcon"))
				{
					registryKey3.SetValue("", "\"" + fileName + "\",0");
				}
				using (RegistryKey registryKey4 = registryKey2.CreateSubKey("shell\\open\\command"))
				{
					registryKey4.SetValue("", text);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06002029 RID: 8233 RVA: 0x000878B4 File Offset: 0x00085AB4
	public static void 7()
	{
		try
		{
			string path = Process.GetCurrentProcess().MainModule.FileName + ".old";
			if (File.Exists(path))
			{
				File.Delete(path);
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x0600202A RID: 8234 RVA: 0x00087900 File Offset: 0x00085B00
	public static int 8(string 1, string 2)
	{
		string[] array = (1 ?? "0").Split(new char[]
		{
			'.'
		});
		string[] array2 = (2 ?? "0").Split(new char[]
		{
			'.'
		});
		int i = 0;
		while (i < Math.Max(array.Length, array2.Length))
		{
			int num2;
			int num = (i < array.Length && int.TryParse(array[i], out num2)) ? num2 : 0;
			int num4;
			int num3 = (i < array2.Length && int.TryParse(array2[i], out num4)) ? num4 : 0;
			if (num != num3)
			{
				if (num >= num3)
				{
					return 1;
				}
				return -1;
			}
			else
			{
				i++;
			}
		}
		return 0;
	}

	// Token: 0x0600202B RID: 8235 RVA: 0x0008799C File Offset: 0x00085B9C
	private static string 9(string 1, string 2)
	{
		Match match = Regex.Match(1, "\"" + 2 + "\"\\s*:\\s*\"((?:[^\"\\\\]|\\\\.)*)\"");
		if (!match.Success)
		{
			return null;
		}
		string value = match.Groups[1].Value;
		StringBuilder stringBuilder = new StringBuilder(value.Length);
		for (int i = 0; i < value.Length; i++)
		{
			char c = value[i];
			if (c != '\\' || i + 1 >= value.Length)
			{
				stringBuilder.Append(c);
			}
			else
			{
				char c2 = value[++i];
				if (c2 <= 'f')
				{
					if (c2 == 'b')
					{
						stringBuilder.Append('\b');
						goto IL_12B;
					}
					if (c2 == 'f')
					{
						stringBuilder.Append('\f');
						goto IL_12B;
					}
				}
				else
				{
					if (c2 == 'n')
					{
						stringBuilder.Append('\n');
						goto IL_12B;
					}
					switch (c2)
					{
					case 'r':
						stringBuilder.Append('\r');
						goto IL_12B;
					case 't':
						stringBuilder.Append('\t');
						goto IL_12B;
					case 'u':
					{
						int num;
						if (i + 4 < value.Length && int.TryParse(value.Substring(i + 1, 4), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out num))
						{
							stringBuilder.Append((char)num);
							i += 4;
							goto IL_12B;
						}
						goto IL_12B;
					}
					}
				}
				stringBuilder.Append(c2);
			}
			IL_12B:;
		}
		return stringBuilder.ToString();
	}

	// Token: 0x0600202C RID: 8236 RVA: 0x00087AEC File Offset: 0x00085CEC
	private static byte[] Get(string 1, long 2, Action<double> 3, int 4)
	{
		Uri uri = new Uri(1);
		bool isLoopback = uri.IsLoopback;
		if (uri.Scheme != Uri.UriSchemeHttps && (!isLoopback || !(uri.Scheme == Uri.UriSchemeHttp)))
		{
			throw new InvalidOperationException("Updates are only fetched over HTTPS.");
		}
		if (!isLoopback && !string.Equals(uri.Host, "nekiosu.nekiak.com", StringComparison.OrdinalIgnoreCase))
		{
			throw new InvalidOperationException("Updates only come from nekiosu.nekiak.com.");
		}
		261.11(uri.Host);
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.CreateDefault(uri);
		httpWebRequest.Method = "GET";
		httpWebRequest.AllowAutoRedirect = false;
		httpWebRequest.UserAgent = 259.4;
		httpWebRequest.Timeout = 4;
		httpWebRequest.ReadWriteTimeout = 4;
		byte[] result;
		try
		{
			using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
			{
				if (httpWebResponse.StatusCode != HttpStatusCode.OK)
				{
					throw new InvalidOperationException("The update server answered " + ((int)httpWebResponse.StatusCode).ToString() + ".");
				}
				long contentLength = httpWebResponse.ContentLength;
				if (contentLength > 2)
				{
					throw new InvalidOperationException("The download is too large.");
				}
				using (Stream responseStream = httpWebResponse.GetResponseStream())
				{
					using (MemoryStream memoryStream = new MemoryStream())
					{
						byte[] array = new byte[65536];
						int count;
						while ((count = responseStream.Read(array, 0, array.Length)) > 0)
						{
							memoryStream.Write(array, 0, count);
							if (memoryStream.Length > 2)
							{
								throw new InvalidOperationException("The download is too large.");
							}
							if (3 != null && contentLength > 0L)
							{
								3((double)memoryStream.Length / (double)contentLength);
							}
						}
						result = memoryStream.ToArray();
					}
				}
			}
		}
		catch (WebException ex)
		{
			HttpWebResponse httpWebResponse2 = ex.Response as HttpWebResponse;
			throw new InvalidOperationException((httpWebResponse2 != null) ? ("The update server answered " + ((int)httpWebResponse2.StatusCode).ToString() + ".") : "The update server could not be reached.");
		}
		return result;
	}

	// Token: 0x040010D1 RID: 4305
	public const string 1 = "1.1.8";

	// Token: 0x040010D2 RID: 4306
	private const string 2 = "https://nekiosu.nekiak.com";

	// Token: 0x040010D3 RID: 4307
	private const string 3 = "nekiosu.nekiak.com";

	// Token: 0x040010D4 RID: 4308
	private const int 4 = 6000;

	// Token: 0x040010D5 RID: 4309
	private const int 5 = 15000;

	// Token: 0x040010D6 RID: 4310
	private const long 6 = 268435456L;

	// Token: 0x040010D7 RID: 4311
	private const string 7 = "Software\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\{7E2B5C1A-4F3D-4B8E-9A61-2C5D8F0E3B47}_is1";

	// Token: 0x020003FE RID: 1022
	public sealed class 274
	{
		// Token: 0x040010D8 RID: 4312
		public string 1;

		// Token: 0x040010D9 RID: 4313
		public string 2;

		// Token: 0x040010DA RID: 4314
		public string 3;
	}

	// Token: 0x020003FF RID: 1023
	public sealed class 275
	{
		// Token: 0x040010DB RID: 4315
		public 273.274 1;

		// Token: 0x040010DC RID: 4316
		public bool 2;

		// Token: 0x040010DD RID: 4317
		public bool 3;

		// Token: 0x040010DE RID: 4318
		public string 4;

		// Token: 0x040010DF RID: 4319
		public string 5;
	}
}
