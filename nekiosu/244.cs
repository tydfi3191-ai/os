using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

// Token: 0x02000400 RID: 1024
public static class 244
{
	// Token: 0x0600202F RID: 8239 RVA: 0x00087D00 File Offset: 0x00085F00
	public static string 1(string 1, string 2, string 3, string 4)
	{
		return 244.2(1, 2, 3, 4, null, null);
	}

	// Token: 0x06002030 RID: 8240 RVA: 0x00087D10 File Offset: 0x00085F10
	public static string 2(string 1, string 2, string 3, string 4, string 5, byte[] 6)
	{
		if (261.FullyOffline)
		{
			261.9("network access while the game is set to fully offline");
		}
		if (string.IsNullOrEmpty(1))
		{
			throw new ArgumentException("token");
		}
		if (2 != "GET" && 2 != "POST" && 2 != "PUT" && 2 != "PATCH" && 2 != "DELETE")
		{
			throw new ArgumentException("method");
		}
		if (string.IsNullOrEmpty(3) || 3.IndexOf("://", StringComparison.Ordinal) >= 0 || 3.StartsWith("/", StringComparison.Ordinal) || 3.IndexOf("..", StringComparison.Ordinal) >= 0)
		{
			throw new ArgumentException("path");
		}
		int num = 0;
		string result;
		for (;;)
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.CreateDefault(new Uri("https://discord.com/api/v10/" + 3));
			261.11(httpWebRequest.RequestUri.Host);
			httpWebRequest.Method = 2;
			httpWebRequest.AllowAutoRedirect = false;
			httpWebRequest.UserAgent = "DiscordBot (https://nekiosu.nekiak.com, 1.0)";
			httpWebRequest.Accept = "application/json";
			httpWebRequest.Timeout = 15000;
			httpWebRequest.ReadWriteTimeout = 15000;
			httpWebRequest.Headers[HttpRequestHeader.Authorization] = "Bot " + 1;
			try
			{
				if (6 != null)
				{
					string text = "nekiosu" + Guid.NewGuid().ToString("N");
					string text2 = Regex.Replace(5 ?? "file", "[^A-Za-z0-9._-]", "_");
					using (MemoryStream memoryStream = new MemoryStream())
					{
						byte[] bytes = Encoding.UTF8.GetBytes(string.Concat(new string[]
						{
							"--",
							text,
							"\r\nContent-Disposition: form-data; name=\"payload_json\"\r\nContent-Type: application/json\r\n\r\n",
							4 ?? "{}",
							"\r\n--",
							text,
							"\r\nContent-Disposition: form-data; name=\"files[0]\"; filename=\"",
							text2,
							"\"\r\nContent-Type: application/octet-stream\r\n\r\n"
						}));
						byte[] bytes2 = Encoding.UTF8.GetBytes("\r\n--" + text + "--\r\n");
						memoryStream.Write(bytes, 0, bytes.Length);
						memoryStream.Write(6, 0, 6.Length);
						memoryStream.Write(bytes2, 0, bytes2.Length);
						byte[] array = memoryStream.ToArray();
						httpWebRequest.ContentType = "multipart/form-data; boundary=" + text;
						httpWebRequest.ContentLength = (long)array.Length;
						using (Stream requestStream = httpWebRequest.GetRequestStream())
						{
							requestStream.Write(array, 0, array.Length);
						}
						goto IL_2D7;
					}
				}
				if (4 != null)
				{
					byte[] bytes3 = Encoding.UTF8.GetBytes(4);
					httpWebRequest.ContentType = "application/json";
					httpWebRequest.ContentLength = (long)bytes3.Length;
					using (Stream requestStream2 = httpWebRequest.GetRequestStream())
					{
						requestStream2.Write(bytes3, 0, bytes3.Length);
						goto IL_2D7;
					}
				}
				if (2 != "GET" && 2 != "DELETE")
				{
					httpWebRequest.ContentLength = 0L;
				}
				IL_2D7:
				using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
				{
					using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.UTF8))
					{
						result = streamReader.ReadToEnd();
						break;
					}
				}
			}
			catch (WebException ex)
			{
				HttpWebResponse httpWebResponse2 = ex.Response as HttpWebResponse;
				if (httpWebResponse2 == null)
				{
					throw new 244.245(0, null, "Discord could not be reached.");
				}
				int statusCode = (int)httpWebResponse2.StatusCode;
				string input;
				using (StreamReader streamReader2 = new StreamReader(httpWebResponse2.GetResponseStream(), Encoding.UTF8))
				{
					input = streamReader2.ReadToEnd();
				}
				httpWebResponse2.Close();
				if (statusCode != 429 || num >= 2)
				{
					throw new 244.245(statusCode, input, (statusCode == 401) ? "The bot token was not accepted." : ("Discord answered with an error (" + statusCode.ToString() + ")."));
				}
				Match match = Regex.Match(input, "\"retry_after\"\\s*:\\s*([0-9.]+)");
				double num2 = match.Success ? double.Parse(match.Groups[1].Value, CultureInfo.InvariantCulture) : 1.0;
				Thread.Sleep((int)Math.Min(30000.0, Math.Max(100.0, num2 * 1000.0)));
			}
			num++;
		}
		return result;
	}

	// Token: 0x06002031 RID: 8241 RVA: 0x000881F8 File Offset: 0x000863F8
	public static string 3(int 1)
	{
		return "https://osu.ppy.sh/b/" + 1.ToString(CultureInfo.InvariantCulture);
	}

	// Token: 0x06002032 RID: 8242 RVA: 0x00088210 File Offset: 0x00086410
	public static string 4(int 1)
	{
		return "https://assets.ppy.sh/beatmaps/" + 1.ToString(CultureInfo.InvariantCulture) + "/covers/list.jpg";
	}

	// Token: 0x06002033 RID: 8243 RVA: 0x0008822D File Offset: 0x0008642D
	public static string 5(int 1)
	{
		return "https://assets.ppy.sh/beatmaps/" + 1.ToString(CultureInfo.InvariantCulture) + "/covers/cover.jpg";
	}

	// Token: 0x06002034 RID: 8244 RVA: 0x0008824A File Offset: 0x0008644A
	public static string 6(long 1)
	{
		return "https://osu.ppy.sh/users/" + 1.ToString(CultureInfo.InvariantCulture) + "/osu";
	}

	// Token: 0x040010E0 RID: 4320
	private const string 1 = "https://discord.com/api/v10/";

	// Token: 0x040010E1 RID: 4321
	private const int 2 = 15000;

	// Token: 0x040010E2 RID: 4322
	private const string 3 = "DiscordBot (https://nekiosu.nekiak.com, 1.0)";

	// Token: 0x02000401 RID: 1025
	public sealed class 245 : Exception
	{
		// Token: 0x06002035 RID: 8245 RVA: 0x00088267 File Offset: 0x00086467
		public 245(int 1, string 2, string 3) : base(3)
		{
			this.1 = 1;
			this.2 = 2;
		}

		// Token: 0x040010E3 RID: 4323
		public readonly int 1;

		// Token: 0x040010E4 RID: 4324
		public readonly string 2;
	}

	// Token: 0x02000402 RID: 1026
	public sealed class 246
	{
		// Token: 0x06002036 RID: 8246 RVA: 0x0008827E File Offset: 0x0008647E
		public 246(string 1, Action<string, string> 2, Action<string, bool> 3)
		{
			this.1 = 1;
			this.2 = 2;
			this.3 = 3;
		}

		// Token: 0x06002037 RID: 8247 RVA: 0x000882B8 File Offset: 0x000864B8
		public void Start()
		{
			if (261.FullyOffline)
			{
				261.9("network access while the game is set to fully offline");
			}
			this.6 = new Thread(new ThreadStart(this.2))
			{
				IsBackground = true,
				Name = "Discord gateway"
			};
			this.6.Start();
		}

		// Token: 0x06002038 RID: 8248 RVA: 0x0008830C File Offset: 0x0008650C
		public void 1()
		{
			this.5 = true;
			try
			{
				244.246.248 <<EMPTY_NAME>> = this.7;
				if (<<EMPTY_NAME>> != null && <<EMPTY_NAME>>.IsOpen)
				{
					<<EMPTY_NAME>>.Close();
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06002039 RID: 8249 RVA: 0x00088350 File Offset: 0x00086550
		private void 2()
		{
			int num = 1000;
			while (!this.5)
			{
				int num2 = 0;
				try
				{
					num2 = this.3();
					num = 1000;
				}
				catch (Exception ex)
				{
					if (this.5)
					{
						break;
					}
					this.3(string.Concat(new string[]
					{
						"Discord connection lost (",
						ex.GetType().Name,
						": ",
						244.246.5(ex),
						"); connecting again."
					}), false);
				}
				if (this.5)
				{
					break;
				}
				if (num2 == 4004 || num2 == 4010 || num2 == 4011 || num2 == 4012 || num2 == 4013 || num2 == 4014)
				{
					this.3((num2 == 4004) ? "The bot token was not accepted." : ("Discord closed the connection (" + num2.ToString() + ")."), true);
					return;
				}
				if (num2 == 4007 || num2 == 4009)
				{
					this.9 = null;
					this.10 = null;
					this.11 = -1L;
				}
				Thread.Sleep(num);
				num = Math.Min(60000, num * 2);
			}
		}

		// Token: 0x0600203A RID: 8250 RVA: 0x00088498 File Offset: 0x00086698
		private int 3()
		{
			Uri uri = new Uri((this.10 ?? "wss://gateway.discord.gg").TrimEnd(new char[]
			{
				'/'
			}) + "/?v=10&encoding=json");
			if (uri.Scheme != "wss" || (!(uri.Host == "gateway.discord.gg") && !uri.Host.EndsWith(".discord.gg", StringComparison.OrdinalIgnoreCase)))
			{
				this.10 = null;
				throw new InvalidOperationException("unexpected gateway address");
			}
			261.11(uri.Host);
			int closeCode;
			using (244.246.248 client = this.4(uri))
			{
				this.7 = client;
				Timer timer = null;
				try
				{
					TimerCallback <>9__0;
					while (!this.5 && client.IsOpen)
					{
						string text = client.Receive();
						if (text == null)
						{
							break;
						}
						int num = 244.246.12(text, "op");
						if (num != 0)
						{
							if (num != 1)
							{
								switch (num)
								{
								case 7:
									return 0;
								case 9:
									if (!(244.246.11(text, "d") == "true"))
									{
										this.9 = null;
										this.10 = null;
										this.11 = -1L;
									}
									Thread.Sleep(1000 + new Random().Next(4000));
									return 0;
								case 10:
								{
									int num2 = 244.246.12(244.246.14(text, "d"), "heartbeat_interval");
									this.12 = true;
									TimerCallback callback;
									if ((callback = <>9__0) == null)
									{
										callback = (<>9__0 = delegate(object 1)
										{
											this.7(client);
										});
									}
									timer = new Timer(callback, null, (int)((double)num2 * new Random().NextDouble()), num2);
									if (this.9 != null && this.11 >= 0L)
									{
										this.9(client, string.Concat(new string[]
										{
											"{\"op\":6,\"d\":{\"token\":",
											244.246.10(this.1),
											",\"session_id\":",
											244.246.10(this.9),
											",\"seq\":",
											this.11.ToString(),
											"}}"
										}));
									}
									else
									{
										this.9(client, "{\"op\":2,\"d\":{\"token\":" + 244.246.10(this.1) + ",\"intents\":0,\"properties\":{\"os\":\"windows\",\"browser\":\"nekiosu\",\"device\":\"nekiosu\"}}}");
									}
									break;
								}
								case 11:
									this.12 = true;
									break;
								}
							}
							else
							{
								this.8(client);
							}
						}
						else
						{
							long num3;
							if (long.TryParse(244.246.11(text, "s"), out num3))
							{
								this.11 = num3;
							}
							string text2 = 244.246.13(text, "t");
							string arg = 244.246.14(text, "d");
							if (text2 == "READY")
							{
								this.9 = 244.246.13(arg, "session_id");
								this.10 = 244.246.13(arg, "resume_gateway_url");
							}
							this.2(text2, arg);
						}
					}
					closeCode = client.CloseCode;
				}
				finally
				{
					if (timer != null)
					{
						timer.Dispose();
					}
					this.7 = null;
				}
			}
			return closeCode;
		}

		// Token: 0x0600203B RID: 8251 RVA: 0x00088814 File Offset: 0x00086A14
		private 244.246.248 4(Uri 1)
		{
			if (!244.246.8)
			{
				244.246.248 2 = null;
				try
				{
					2 = new 244.246.247();
					2.Connect(1);
					return 2;
				}
				catch (Exception ex) when (244.246.6(ex))
				{
					if (2 != null)
					{
						2.Dispose();
					}
					244.246.8 = true;
					this.3("Windows' WebSocket is not available (" + ex.GetType().Name + "); using nekiosu's own.", false);
				}
				catch (Exception)
				{
					if (2 != null)
					{
						2.Dispose();
					}
					throw;
				}
			}
			244.246.248 3 = new 244.246.249();
			244.246.248 result;
			try
			{
				3.Connect(1);
				result = 3;
			}
			catch (Exception)
			{
				3.Dispose();
				throw;
			}
			return result;
		}

		// Token: 0x0600203C RID: 8252 RVA: 0x000888E0 File Offset: 0x00086AE0
		private static string 5(Exception 1)
		{
			Exception ex = 1;
			for (;;)
			{
				AggregateException ex2 = ex as AggregateException;
				Exception ex3 = (ex2 != null && ex2.InnerExceptions.Count > 0) ? ex2.InnerExceptions[0] : ex.InnerException;
				if (ex3 == null)
				{
					break;
				}
				ex = ex3;
			}
			if (ex != 1)
			{
				return ex.GetType().Name + ": " + ex.Message;
			}
			return 1.Message;
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x0008894C File Offset: 0x00086B4C
		private static bool 6(Exception 1)
		{
			for (Exception ex = 1; ex != null; ex = ex.InnerException)
			{
				if (ex is PlatformNotSupportedException || ex is EntryPointNotFoundException || ex is DllNotFoundException)
				{
					return true;
				}
				if (ex is TypeInitializationException)
				{
					return true;
				}
				AggregateException ex2 = ex as AggregateException;
				if (ex2 != null)
				{
					using (IEnumerator<Exception> enumerator = ex2.InnerExceptions.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (244.246.6(enumerator.Current))
							{
								return true;
							}
						}
					}
					return false;
				}
			}
			return false;
		}

		// Token: 0x0600203E RID: 8254 RVA: 0x000889E0 File Offset: 0x00086BE0
		private void 7(244.246.248 1)
		{
			try
			{
				if (!this.12)
				{
					1.Abort();
				}
				else
				{
					this.12 = false;
					this.8(1);
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600203F RID: 8255 RVA: 0x00088A24 File Offset: 0x00086C24
		private void 8(244.246.248 1)
		{
			this.9(1, "{\"op\":1,\"d\":" + ((this.11 >= 0L) ? this.11.ToString(CultureInfo.InvariantCulture) : "null") + "}");
		}

		// Token: 0x06002040 RID: 8256 RVA: 0x00088A60 File Offset: 0x00086C60
		private void 9(244.246.248 1, string 2)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(2);
			object obj = this.4;
			lock (obj)
			{
				1.SendText(bytes);
			}
		}

		// Token: 0x06002041 RID: 8257 RVA: 0x00088AB0 File Offset: 0x00086CB0
		private static string 10(string 1)
		{
			StringBuilder stringBuilder = new StringBuilder("\"");
			foreach (char c in 1)
			{
				if (c == '"' || c == '\\')
				{
					stringBuilder.Append('\\').Append(c);
				}
				else if (c < ' ')
				{
					StringBuilder stringBuilder2 = stringBuilder.Append("\\u");
					int num = (int)c;
					stringBuilder2.Append(num.ToString("x4"));
				}
				else
				{
					stringBuilder.Append(c);
				}
			}
			return stringBuilder.Append('"').ToString();
		}

		// Token: 0x06002042 RID: 8258 RVA: 0x00088B3A File Offset: 0x00086D3A
		private static string 11(string 1, string 2)
		{
			if (1 != null)
			{
				return 244.246.14(1, 2);
			}
			return null;
		}

		// Token: 0x06002043 RID: 8259 RVA: 0x00088B48 File Offset: 0x00086D48
		private static int 12(string 1, string 2)
		{
			int result;
			if (!int.TryParse(244.246.11(1, 2), out result))
			{
				return -1;
			}
			return result;
		}

		// Token: 0x06002044 RID: 8260 RVA: 0x00088B68 File Offset: 0x00086D68
		private static string 13(string 1, string 2)
		{
			string text = 244.246.11(1, 2);
			if (text == null || text.Length < 2 || text[0] != '"')
			{
				return null;
			}
			return Regex.Unescape(text.Substring(1, text.Length - 2));
		}

		// Token: 0x06002045 RID: 8261 RVA: 0x00088BAC File Offset: 0x00086DAC
		private static string 14(string 1, string 2)
		{
			int num = 0;
			bool flag = false;
			for (int i = 0; i < 1.Length; i++)
			{
				char c = 1[i];
				if (flag)
				{
					if (c == '\\')
					{
						i++;
					}
					else if (c == '"')
					{
						flag = false;
					}
				}
				else if (c == '"')
				{
					if (num == 1 && string.CompareOrdinal(1, i, "\"" + 2 + "\"", 0, 2.Length + 2) == 0)
					{
						int num2 = 1.IndexOf(':', i + 2.Length + 2) + 1;
						while (num2 < 1.Length && char.IsWhiteSpace(1[num2]))
						{
							num2++;
						}
						return 244.246.15(1, num2);
					}
					flag = true;
				}
				else if (c == '{' || c == '[')
				{
					num++;
				}
				else if (c == '}' || c == ']')
				{
					num--;
				}
			}
			return null;
		}

		// Token: 0x06002046 RID: 8262 RVA: 0x00088C8C File Offset: 0x00086E8C
		private static string 15(string 1, int 2)
		{
			if (2 >= 1.Length)
			{
				return null;
			}
			char c = 1[2];
			if (c == '{' || c == '[')
			{
				int num = 0;
				bool flag = false;
				for (int i = 2; i < 1.Length; i++)
				{
					char c2 = 1[i];
					if (flag)
					{
						if (c2 == '\\')
						{
							i++;
						}
						else if (c2 == '"')
						{
							flag = false;
						}
					}
					else if (c2 == '"')
					{
						flag = true;
					}
					else if (c2 == '{' || c2 == '[')
					{
						num++;
					}
					else if (c2 == '}' || c2 == ']')
					{
						num--;
						if (num == 0)
						{
							return 1.Substring(2, i - 2 + 1);
						}
					}
				}
				return null;
			}
			int j = 2;
			if (c == '"')
			{
				for (j = 2 + 1; j < 1.Length; j++)
				{
					if (1[j] == '\\')
					{
						j++;
					}
					else if (1[j] == '"')
					{
						break;
					}
				}
				return 1.Substring(2, j - 2 + 1);
			}
			while (j < 1.Length && 1[j] != ',' && 1[j] != '}' && 1[j] != ']')
			{
				j++;
			}
			return 1.Substring(2, j - 2).Trim();
		}

		// Token: 0x040010E5 RID: 4325
		private readonly string 1;

		// Token: 0x040010E6 RID: 4326
		private readonly Action<string, string> 2;

		// Token: 0x040010E7 RID: 4327
		private readonly Action<string, bool> 3;

		// Token: 0x040010E8 RID: 4328
		private readonly object 4 = new object();

		// Token: 0x040010E9 RID: 4329
		private volatile bool 5;

		// Token: 0x040010EA RID: 4330
		private Thread 6;

		// Token: 0x040010EB RID: 4331
		private 244.246.248 7;

		// Token: 0x040010EC RID: 4332
		private static volatile bool 8;

		// Token: 0x040010ED RID: 4333
		private string 9;

		// Token: 0x040010EE RID: 4334
		private string 10;

		// Token: 0x040010EF RID: 4335
		private long 11 = -1L;

		// Token: 0x040010F0 RID: 4336
		private volatile bool 12 = true;

		// Token: 0x040010F1 RID: 4337
		private const int 13 = 8388608;

		// Token: 0x02000403 RID: 1027
		private abstract class 248 : IDisposable
		{
			// Token: 0x17000229 RID: 553
			// (get) Token: 0x06002047 RID: 8263
			public abstract bool IsOpen { get; }

			// Token: 0x1700022A RID: 554
			// (get) Token: 0x06002048 RID: 8264
			public abstract int CloseCode { get; }

			// Token: 0x06002049 RID: 8265
			public abstract void Connect(Uri 1);

			// Token: 0x0600204A RID: 8266
			public abstract void SendText(byte[] 1);

			// Token: 0x0600204B RID: 8267
			public abstract string Receive();

			// Token: 0x0600204C RID: 8268
			public abstract void Close();

			// Token: 0x0600204D RID: 8269
			public abstract void Abort();

			// Token: 0x0600204E RID: 8270
			public abstract void Dispose();
		}

		// Token: 0x02000404 RID: 1028
		private sealed class 247 : 244.246.248
		{
			// Token: 0x1700022B RID: 555
			// (get) Token: 0x06002050 RID: 8272 RVA: 0x00088DB9 File Offset: 0x00086FB9
			public override bool IsOpen
			{
				get
				{
					return this.1.State == WebSocketState.Open;
				}
			}

			// Token: 0x1700022C RID: 556
			// (get) Token: 0x06002051 RID: 8273 RVA: 0x00088DCC File Offset: 0x00086FCC
			public override int CloseCode
			{
				get
				{
					WebSocketCloseStatus? closeStatus = this.1.CloseStatus;
					if (closeStatus == null)
					{
						return 0;
					}
					return (int)closeStatus.Value;
				}
			}

			// Token: 0x06002052 RID: 8274 RVA: 0x00088DF7 File Offset: 0x00086FF7
			public override void Connect(Uri 1)
			{
				this.1.ConnectAsync(1, CancellationToken.None).Wait(15000);
				if (!this.IsOpen)
				{
					throw new IOException("the gateway did not answer");
				}
			}

			// Token: 0x06002053 RID: 8275 RVA: 0x00088E28 File Offset: 0x00087028
			public override void SendText(byte[] 1)
			{
				this.1.SendAsync(new ArraySegment<byte>(1), WebSocketMessageType.Text, true, CancellationToken.None).Wait(15000);
			}

			// Token: 0x06002054 RID: 8276 RVA: 0x00088E50 File Offset: 0x00087050
			public override string Receive()
			{
				byte[] array = new byte[16384];
				string @string;
				using (MemoryStream memoryStream = new MemoryStream())
				{
					for (;;)
					{
						WebSocketReceiveResult result = this.1.ReceiveAsync(new ArraySegment<byte>(array), CancellationToken.None).Result;
						if (result.MessageType == WebSocketMessageType.Close)
						{
							break;
						}
						memoryStream.Write(array, 0, result.Count);
						if (memoryStream.Length > 8388608L)
						{
							goto Block_3;
						}
						if (result.EndOfMessage)
						{
							goto Block_4;
						}
					}
					return null;
					Block_3:
					throw new IOException("gateway message too large");
					Block_4:
					@string = Encoding.UTF8.GetString(memoryStream.ToArray());
				}
				return @string;
			}

			// Token: 0x06002055 RID: 8277 RVA: 0x00088EF4 File Offset: 0x000870F4
			public override void Close()
			{
				this.1.CloseAsync(WebSocketCloseStatus.NormalClosure, "closing", CancellationToken.None).Wait(2000);
			}

			// Token: 0x06002056 RID: 8278 RVA: 0x00088F1B File Offset: 0x0008711B
			public override void Abort()
			{
				this.1.Abort();
			}

			// Token: 0x06002057 RID: 8279 RVA: 0x00088F28 File Offset: 0x00087128
			public override void Dispose()
			{
				this.1.Dispose();
			}

			// Token: 0x040010F2 RID: 4338
			private readonly ClientWebSocket 1 = new ClientWebSocket();
		}

		// Token: 0x02000405 RID: 1029
		private sealed class 249 : 244.246.248
		{
			// Token: 0x1700022D RID: 557
			// (get) Token: 0x06002059 RID: 8281 RVA: 0x00088F48 File Offset: 0x00087148
			public override bool IsOpen
			{
				get
				{
					return this.6;
				}
			}

			// Token: 0x1700022E RID: 558
			// (get) Token: 0x0600205A RID: 8282 RVA: 0x00088F52 File Offset: 0x00087152
			public override int CloseCode
			{
				get
				{
					return this.7;
				}
			}

			// Token: 0x0600205B RID: 8283 RVA: 0x00088F5C File Offset: 0x0008715C
			public override void Connect(Uri 1)
			{
				this.4 = new TcpClient();
				IAsyncResult asyncResult = this.4.BeginConnect(1.Host, 1.Port, null, null);
				if (!asyncResult.AsyncWaitHandle.WaitOne(15000))
				{
					throw new IOException("the gateway did not answer");
				}
				this.4.EndConnect(asyncResult);
				this.4.SendTimeout = 15000;
				Stream stream = this.4.GetStream();
				bool leaveInnerStreamOpen = false;
				RemoteCertificateValidationCallback userCertificateValidationCallback;
				if ((userCertificateValidationCallback = 244.246.249.<>O.<0>__AcceptCertificate) == null)
				{
					userCertificateValidationCallback = (244.246.249.<>O.<0>__AcceptCertificate = new RemoteCertificateValidationCallback(244.246.249.1));
				}
				this.5 = new SslStream(stream, leaveInnerStreamOpen, userCertificateValidationCallback);
				this.5.ReadTimeout = 15000;
				this.5.AuthenticateAsClient(1.Host, null, SslProtocols.Tls12, true);
				byte[] array = new byte[16];
				this.3.GetBytes(array);
				string text = Convert.ToBase64String(array);
				byte[] bytes = Encoding.ASCII.GetBytes(string.Concat(new string[]
				{
					"GET ",
					1.PathAndQuery,
					" HTTP/1.1\r\nHost: ",
					1.Host,
					"\r\nUpgrade: websocket\r\nConnection: Upgrade\r\nSec-WebSocket-Key: ",
					text,
					"\r\nSec-WebSocket-Version: 13\r\nUser-Agent: DiscordBot (https://nekiosu.nekiak.com, 1.0)\r\n\r\n"
				}));
				this.5.Write(bytes, 0, bytes.Length);
				this.5.Flush();
				StringBuilder stringBuilder = new StringBuilder();
				while (!stringBuilder.ToString().EndsWith("\r\n\r\n", StringComparison.Ordinal))
				{
					int num = this.5.ReadByte();
					if (num < 0)
					{
						throw new IOException("the gateway closed the connection");
					}
					if (stringBuilder.Length > 16384)
					{
						throw new IOException("gateway answer too large");
					}
					stringBuilder.Append((char)num);
				}
				string[] array2 = stringBuilder.ToString().Split(new string[]
				{
					"\r\n"
				}, StringSplitOptions.RemoveEmptyEntries);
				if (array2.Length == 0 || !array2[0].StartsWith("HTTP/1.1 101", StringComparison.Ordinal))
				{
					throw new IOException("the gateway refused the connection (" + ((array2.Length != 0) ? array2[0] : "") + ")");
				}
				string b;
				using (SHA1 sha = SHA1.Create())
				{
					b = Convert.ToBase64String(sha.ComputeHash(Encoding.ASCII.GetBytes(text + "258EAFA5-E914-47DA-95CA-C5AB0DC85B11")));
				}
				bool flag = false;
				foreach (string text2 in array2)
				{
					int num2 = text2.IndexOf(':');
					if (num2 > 0 && string.Equals(text2.Substring(0, num2).Trim(), "Sec-WebSocket-Accept", StringComparison.OrdinalIgnoreCase) && text2.Substring(num2 + 1).Trim() == b)
					{
						flag = true;
					}
				}
				if (!flag)
				{
					throw new IOException("the gateway's answer was not a WebSocket");
				}
				this.5.ReadTimeout = -1;
				this.6 = true;
			}

			// Token: 0x0600205C RID: 8284 RVA: 0x00089230 File Offset: 0x00087430
			private static bool 1(object 1, X509Certificate 2, X509Chain 3, SslPolicyErrors 4)
			{
				if (4 == SslPolicyErrors.None)
				{
					return true;
				}
				if (4 != SslPolicyErrors.RemoteCertificateChainErrors || 3 == null)
				{
					return false;
				}
				foreach (X509ChainStatus x509ChainStatus in 3.ChainStatus)
				{
					if (x509ChainStatus.Status != X509ChainStatusFlags.RevocationStatusUnknown && x509ChainStatus.Status != X509ChainStatusFlags.OfflineRevocation)
					{
						return false;
					}
				}
				return true;
			}

			// Token: 0x0600205D RID: 8285 RVA: 0x00089284 File Offset: 0x00087484
			public override void SendText(byte[] 1)
			{
				this.3(1, 1);
			}

			// Token: 0x0600205E RID: 8286 RVA: 0x00089290 File Offset: 0x00087490
			public override string Receive()
			{
				string @string;
				using (MemoryStream memoryStream = new MemoryStream())
				{
					bool flag = false;
					byte[] array4;
					for (;;)
					{
						byte[] array = this.2(2);
						bool flag2 = (array[0] & 128) > 0;
						int num = (int)(array[0] & 15);
						if ((array[1] & 128) != 0)
						{
							break;
						}
						long num2 = (long)(array[1] & 127);
						if (num2 == 126L)
						{
							byte[] array2 = this.2(2);
							num2 = (long)((int)array2[0] << 8 | (int)array2[1]);
						}
						else if (num2 == 127L)
						{
							byte[] array3 = this.2(8);
							num2 = 0L;
							for (int i = 0; i < 8; i++)
							{
								num2 = (num2 << 8 | (long)((ulong)array3[i]));
							}
						}
						if (num2 < 0L || num2 > 8388608L)
						{
							goto IL_A2;
						}
						array4 = this.2((int)num2);
						switch (num)
						{
						case 0:
							if (!flag)
							{
								goto Block_11;
							}
							goto IL_18E;
						case 1:
						case 2:
							if (flag)
							{
								goto Block_10;
							}
							flag = true;
							goto IL_18E;
						case 8:
							goto IL_EF;
						case 9:
							this.3(10, array4);
							continue;
						case 10:
							continue;
						}
						goto Block_7;
						IL_18E:
						memoryStream.Write(array4, 0, array4.Length);
						if (memoryStream.Length > 8388608L)
						{
							goto Block_12;
						}
						if (flag2)
						{
							goto Block_13;
						}
					}
					throw new IOException("masked frame from the gateway");
					IL_A2:
					throw new IOException("gateway message too large");
					Block_7:
					goto IL_183;
					IL_EF:
					this.7 = ((array4.Length >= 2) ? ((int)array4[0] << 8 | (int)array4[1]) : 0);
					if (this.6)
					{
						try
						{
							int num3 = 8;
							byte[] array5;
							if (array4.Length < 2)
							{
								array5 = new byte[0];
							}
							else
							{
								byte[] array6 = new byte[2];
								array6[0] = array4[0];
								array5 = array6;
								array6[1] = array4[1];
							}
							this.3(num3, array5);
						}
						catch (Exception)
						{
						}
					}
					this.6 = false;
					return null;
					Block_10:
					throw new IOException("unexpected gateway frame");
					Block_11:
					throw new IOException("unexpected gateway frame");
					IL_183:
					throw new IOException("unexpected gateway frame");
					Block_12:
					throw new IOException("gateway message too large");
					Block_13:
					@string = Encoding.UTF8.GetString(memoryStream.ToArray());
				}
				return @string;
			}

			// Token: 0x0600205F RID: 8287 RVA: 0x000894AC File Offset: 0x000876AC
			private byte[] 2(int 1)
			{
				byte[] array = new byte[1];
				int num;
				for (int i = 0; i < 1; i += num)
				{
					num = this.5.Read(array, i, 1 - i);
					if (num <= 0)
					{
						this.6 = false;
						throw new IOException("the gateway closed the connection");
					}
				}
				return array;
			}

			// Token: 0x06002060 RID: 8288 RVA: 0x000894F8 File Offset: 0x000876F8
			private void 3(int 1, byte[] 2)
			{
				using (MemoryStream memoryStream = new MemoryStream(2.Length + 14))
				{
					memoryStream.WriteByte((byte)(128 | 1));
					if (2.Length < 126)
					{
						memoryStream.WriteByte((byte)(128 | 2.Length));
					}
					else if (2.Length <= 65535)
					{
						memoryStream.WriteByte(254);
						memoryStream.WriteByte((byte)(2.Length >> 8));
						memoryStream.WriteByte((byte)2.Length);
					}
					else
					{
						memoryStream.WriteByte(byte.MaxValue);
						for (int i = 56; i >= 0; i -= 8)
						{
							memoryStream.WriteByte((byte)((long)2.Length >> i));
						}
					}
					byte[] array = new byte[4];
					this.3.GetBytes(array);
					memoryStream.Write(array, 0, 4);
					for (int j = 0; j < 2.Length; j++)
					{
						memoryStream.WriteByte(2[j] ^ array[j & 3]);
					}
					byte[] array2 = memoryStream.ToArray();
					object obj = this.2;
					lock (obj)
					{
						this.5.Write(array2, 0, array2.Length);
						this.5.Flush();
					}
				}
			}

			// Token: 0x06002061 RID: 8289 RVA: 0x00089650 File Offset: 0x00087850
			public override void Close()
			{
				if (!this.6)
				{
					return;
				}
				try
				{
					this.3(8, new byte[]
					{
						3,
						232
					});
				}
				catch (Exception)
				{
				}
				this.Abort();
			}

			// Token: 0x06002062 RID: 8290 RVA: 0x000896A0 File Offset: 0x000878A0
			public override void Abort()
			{
				this.6 = false;
				try
				{
					if (this.5 != null)
					{
						this.5.Dispose();
					}
				}
				catch (Exception)
				{
				}
				try
				{
					if (this.4 != null)
					{
						this.4.Close();
					}
				}
				catch (Exception)
				{
				}
			}

			// Token: 0x06002063 RID: 8291 RVA: 0x00089704 File Offset: 0x00087904
			public override void Dispose()
			{
				this.Abort();
				this.3.Dispose();
			}

			// Token: 0x040010F3 RID: 4339
			private const string 1 = "258EAFA5-E914-47DA-95CA-C5AB0DC85B11";

			// Token: 0x040010F4 RID: 4340
			private readonly object 2 = new object();

			// Token: 0x040010F5 RID: 4341
			private readonly RandomNumberGenerator 3 = RandomNumberGenerator.Create();

			// Token: 0x040010F6 RID: 4342
			private TcpClient 4;

			// Token: 0x040010F7 RID: 4343
			private SslStream 5;

			// Token: 0x040010F8 RID: 4344
			private volatile bool 6;

			// Token: 0x040010F9 RID: 4345
			private int 7;

			// Token: 0x02000406 RID: 1030
			[CompilerGenerated]
			private static class <>O
			{
				// Token: 0x040010FA RID: 4346
				public static RemoteCertificateValidationCallback <0>__AcceptCertificate;
			}
		}
	}
}
