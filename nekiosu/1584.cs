using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x020009BC RID: 2492
internal static class 1584
{
	// Token: 0x170002F5 RID: 757
	// (get) Token: 0x060045CE RID: 17870 RVA: 0x001B67F9 File Offset: 0x001B49F9
	// (set) Token: 0x060045CF RID: 17871 RVA: 0x001B6800 File Offset: 0x001B4A00
	internal static string ApplicationId { get; private set; }

	// Token: 0x170002F6 RID: 758
	// (get) Token: 0x060045D0 RID: 17872 RVA: 0x001B6808 File Offset: 0x001B4A08
	// (set) Token: 0x060045D1 RID: 17873 RVA: 0x001B680F File Offset: 0x001B4A0F
	internal static string ApplicationName { get; private set; }

	// Token: 0x170002F7 RID: 759
	// (get) Token: 0x060045D2 RID: 17874 RVA: 0x001B6817 File Offset: 0x001B4A17
	// (set) Token: 0x060045D3 RID: 17875 RVA: 0x001B681E File Offset: 0x001B4A1E
	internal static string OwnerId { get; private set; }

	// Token: 0x170002F8 RID: 760
	// (get) Token: 0x060045D4 RID: 17876 RVA: 0x001B6826 File Offset: 0x001B4A26
	internal static string Status
	{
		get
		{
			return 1584.11;
		}
	}

	// Token: 0x14000008 RID: 8
	// (add) Token: 0x060045D5 RID: 17877 RVA: 0x001B6830 File Offset: 0x001B4A30
	// (remove) Token: 0x060045D6 RID: 17878 RVA: 0x001B6864 File Offset: 0x001B4A64
	internal static event Action StatusChanged
	{
		[CompilerGenerated]
		add
		{
			Action action = 1584.13;
			Action action2;
			do
			{
				action2 = action;
				Action value2 = (Action)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange<Action>(ref 1584.13, value2, action2);
			}
			while (action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action action = 1584.13;
			Action action2;
			do
			{
				action2 = action;
				Action value2 = (Action)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange<Action>(ref 1584.13, value2, action2);
			}
			while (action != action2);
		}
	}

	// Token: 0x170002F9 RID: 761
	// (get) Token: 0x060045D7 RID: 17879 RVA: 0x001B6897 File Offset: 0x001B4A97
	internal static bool HasToken
	{
		get
		{
			return !string.IsNullOrEmpty(1584.StoredToken);
		}
	}

	// Token: 0x170002FA RID: 762
	// (get) Token: 0x060045D8 RID: 17880 RVA: 0x001B68A8 File Offset: 0x001B4AA8
	private static string StoredToken
	{
		get
		{
			string text = 1304.52.GetValue() ?? string.Empty;
			Tuple<string, string> tuple = 1584.14;
			if (tuple == null || !string.Equals(tuple.Item1, text, StringComparison.Ordinal))
			{
				tuple = Tuple.Create<string, string>(text, 1631.17(text));
				1584.14 = tuple;
			}
			return tuple.Item2;
		}
	}

	// Token: 0x060045D9 RID: 17881 RVA: 0x001B68FC File Offset: 0x001B4AFC
	internal static string Emote(string 1)
	{
		Dictionary<string, string> obj = 1584.5;
		string result;
		lock (obj)
		{
			string text;
			result = (1584.5.TryGetValue(1, out text) ? text : string.Empty);
		}
		return result;
	}

	// Token: 0x060045DA RID: 17882 RVA: 0x001B6950 File Offset: 0x001B4B50
	internal static void 1()
	{
		bool flag = 1304.51.1() && 1584.HasToken && !261.FullyOffline;
		if (flag && 1584.10 && !1584.9 && 1584.6 == null && DateTime.UtcNow >= 1584.12)
		{
			1584.10 = false;
		}
		if (flag && !1584.10 && !1584.9)
		{
			1584.12 = DateTime.MaxValue;
			1584.Start();
		}
		else if (!flag && (1584.10 || 1584.9))
		{
			1584.5();
			1584.9(1584.HasToken ? "Off." : "Not set up.");
		}
		1589.2();
		1601.3();
		217 <<EMPTY_NAME>>;
		while (1584.2.TryDequeue(out <<EMPTY_NAME>>))
		{
			try
			{
				1584.10(<<EMPTY_NAME>>);
				continue;
			}
			catch (Exception ex)
			{
				1338.4(ex, "answering a Discord command", 1341.Runtime);
				continue;
			}
			break;
		}
	}

	// Token: 0x060045DB RID: 17883 RVA: 0x001B6A38 File Offset: 0x001B4C38
	internal static void 2(string 1, Action<bool, string> 2)
	{
		1 = (1 ?? string.Empty).Trim();
		1584.5();
		if (1.Length == 0)
		{
			1304.52.SetValue(string.Empty);
			1584.9("Not set up.");
			2(false, "The Discord bot is removed.");
			return;
		}
		1338.2(1);
		1662.17(delegate
		{
			string failure = null;
			try
			{
				217 3 = 217.Parse(244.1(1, "GET", "applications/@me", null));
				failure = 1584.3(3);
			}
			catch (Exception ex)
			{
				failure = ((ex is 244.245) ? ex.Message : "Discord could not be reached.");
			}
			1662.89.Schedule(delegate()
			{
				if (failure != null)
				{
					2(false, failure);
					return;
				}
				1304.52.SetValue(1631.16(1));
				2(true, "Saved. The bot starts in a moment.");
			}, false);
		});
	}

	// Token: 0x060045DC RID: 17884 RVA: 0x001B6ACD File Offset: 0x001B4CCD
	private static string 3(217 1)
	{
		if (!string.IsNullOrEmpty((string)1["interactions_endpoint_url"]))
		{
			return "Remove the Interactions Endpoint URL in the app's settings on Discord: commands then come to the game.";
		}
		return null;
	}

	// Token: 0x060045DD RID: 17885 RVA: 0x001B6AF0 File Offset: 0x001B4CF0
	private static void Start()
	{
		1584.9 = true;
		1584.8 = 1584.StoredToken;
		1338.2(1584.8);
		1584.9("Connecting...");
		string startToken = 1584.8;
		1662.17(delegate
		{
			bool flag = false;
			try
			{
				string startToken;
				217 <<EMPTY_NAME>> = 217.Parse(244.1(startToken, "GET", "applications/@me", null));
				string text = 1584.3(<<EMPTY_NAME>>);
				if (text != null)
				{
					1584.4(text, false);
				}
				else
				{
					string text2 = (string)<<EMPTY_NAME>>["id"];
					217 2 = <<EMPTY_NAME>>["team"] as 217;
					string text3 = (2 != null) ? ((string)2["owner_user_id"]) : null;
					if (text3 == null)
					{
						217 3 = <<EMPTY_NAME>>["owner"] as 217;
						text3 = ((3 != null) ? ((string)3["id"]) : null);
					}
					Semaphore semaphore = new Semaphore(1, 1, "Local\\nekiosu-discord-bot-" + text2);
					if (!semaphore.WaitOne(0))
					{
						semaphore.Dispose();
						1584.4("Another nekiosu is running this bot.", false);
					}
					else
					{
						1584.7 = semaphore;
						1584.ApplicationId = text2;
						1584.ApplicationName = (string)<<EMPTY_NAME>>["name"];
						1584.OwnerId = text3;
						244.1(startToken, "PUT", "applications/" + text2 + "/commands", 1585.1().ToString((95)0, Array.Empty<214>()));
						1584.15(startToken, text2);
						startToken = startToken;
						Action<string, string> action;
						if ((action = 1584.<>O.<0>__OnDispatch) == null)
						{
							action = (1584.<>O.<0>__OnDispatch = new Action<string, string>(1584.7));
						}
						Action<string, bool> action2;
						if ((action2 = 1584.<>O.<1>__OnGatewayStatus) == null)
						{
							action2 = (1584.<>O.<1>__OnGatewayStatus = new Action<string, bool>(1584.8));
						}
						(1584.6 = new 244.246(startToken, action, action2)).Start();
						flag = true;
						1338.5(string.Concat(new string[]
						{
							"Discord bot ",
							1584.ApplicationName,
							" (",
							text2,
							") connecting."
						}), 1341.Runtime, (1114)2);
						1662.89.Schedule(delegate()
						{
							1584.10 = true;
							1584.9 = false;
						}, false);
					}
				}
			}
			catch (Exception ex)
			{
				if (!flag)
				{
					1584.6();
				}
				244.245 4 = ex as 244.245;
				bool flag2 = 4 != null && (4.1 == 0 || 4.1 >= 500);
				1584.4(flag2 ? "Discord could not be reached; trying again in a minute." : ((4 != null) ? ex.Message : ("The bot could not start: " + ex.Message)), flag2);
				1338.5("Discord bot could not start: " + ex.Message, 1341.Runtime, (1114)2);
			}
		});
	}

	// Token: 0x060045DE RID: 17886 RVA: 0x001B6B44 File Offset: 0x001B4D44
	private static void 4(string 1, bool 2 = false)
	{
		1662.89.Schedule(delegate()
		{
			1584.9 = false;
			1584.10 = true;
			1584.12 = (2 ? DateTime.UtcNow.AddMinutes(1.0) : DateTime.MaxValue);
			1584.9(1);
		}, false);
	}

	// Token: 0x060045DF RID: 17887 RVA: 0x001B6B80 File Offset: 0x001B4D80
	internal static void 5()
	{
		try
		{
			244.246 <<EMPTY_NAME>> = 1584.6;
			if (<<EMPTY_NAME>> != null)
			{
				<<EMPTY_NAME>>.1();
			}
		}
		catch (Exception)
		{
		}
		1584.6 = null;
		1584.10 = false;
		1584.9 = false;
		1584.6();
	}

	// Token: 0x060045E0 RID: 17888 RVA: 0x001B6BCC File Offset: 0x001B4DCC
	private static void 6()
	{
		Semaphore semaphore = Interlocked.Exchange<Semaphore>(ref 1584.7, null);
		if (semaphore == null)
		{
			return;
		}
		try
		{
			semaphore.Release();
		}
		catch (Exception)
		{
		}
		semaphore.Dispose();
	}

	// Token: 0x060045E1 RID: 17889 RVA: 0x001B6C0C File Offset: 0x001B4E0C
	private static void 7(string 1, string 2)
	{
		if (1 == "READY")
		{
			1662.89.Schedule(delegate()
			{
				1584.9("Online as " + 1584.ApplicationName + ".");
			}, false);
			return;
		}
		if (1 == "INTERACTION_CREATE" && 2 != null)
		{
			try
			{
				1584.2.Enqueue(217.Parse(2));
			}
			catch (Exception ex)
			{
				1338.4(ex, "reading a Discord command", 1341.Runtime);
			}
		}
	}

	// Token: 0x060045E2 RID: 17890 RVA: 0x001B6C94 File Offset: 0x001B4E94
	private static void 8(string 1, bool 2)
	{
		1338.5("Discord bot: " + 1, 1341.Runtime, (1114)2);
		1662.89.Schedule(delegate()
		{
			1584.9(2 ? 1 : "Reconnecting...");
		}, false);
	}

	// Token: 0x060045E3 RID: 17891 RVA: 0x001B6CE4 File Offset: 0x001B4EE4
	private static void 9(string 1)
	{
		if (1584.11 == 1)
		{
			return;
		}
		1584.11 = 1;
		Action action = 1584.13;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x060045E4 RID: 17892 RVA: 0x001B6D0C File Offset: 0x001B4F0C
	private static void 10(217 1)
	{
		string a = ((string)1.SelectToken("member.user.id")) ?? ((string)1.SelectToken("user.id"));
		if (1584.OwnerId != null && a != 1584.OwnerId)
		{
			1584.11(1, 1585.10("This bot answers only its owner."));
			return;
		}
		1585.8(1);
	}

	// Token: 0x060045E5 RID: 17893 RVA: 0x001B6D6C File Offset: 0x001B4F6C
	internal static void 11(217 1, 217 2)
	{
		string text = string.Concat(new string[]
		{
			"interactions/",
			(string)1["id"],
			"/",
			(string)1["token"],
			"/callback"
		});
		1584.14("POST", text, 2, null, null);
	}

	// Token: 0x060045E6 RID: 17894 RVA: 0x001B6DD1 File Offset: 0x001B4FD1
	internal static void 12(217 1, 217 2)
	{
		1584.13(1, 2, null, null);
	}

	// Token: 0x060045E7 RID: 17895 RVA: 0x001B6DDC File Offset: 0x001B4FDC
	internal static void 13(217 1, 217 2, string 3, byte[] 4)
	{
		if (4 != null)
		{
			string text = "attachments";
			217 5 = new 217();
			5["id"] = 0;
			5["filename"] = 3;
			2[text] = new 109(5);
		}
		1584.14("PATCH", string.Concat(new string[]
		{
			"webhooks/",
			1584.ApplicationId,
			"/",
			(string)1["token"],
			"/messages/@original"
		}), 2, 3, 4);
	}

	// Token: 0x060045E8 RID: 17896 RVA: 0x001B6E70 File Offset: 0x001B5070
	private static void 14(string 1, string 2, 217 3, string 4 = null, byte[] 5 = null)
	{
		string sendToken = 1584.8;
		string json = 3.ToString((95)0, Array.Empty<214>());
		Queue<Action> obj = 1584.3;
		lock (obj)
		{
			1584.3.Enqueue(delegate
			{
				try
				{
					244.2(sendToken, 1, 2, json, 4, 5);
				}
				catch (Exception ex)
				{
					244.245 6 = ex as 244.245;
					string str = (6 != null) ? (6.Message + " " + 6.2) : ex.Message;
					1338.5("Discord answer failed: " + str, 1341.Runtime, (1114)2);
				}
			});
			if (1584.4)
			{
				return;
			}
			1584.4 = true;
		}
		1662.17(delegate
		{
			for (;;)
			{
				Queue<Action> obj2 = 1584.3;
				Action action;
				lock (obj2)
				{
					if (1584.3.Count == 0)
					{
						1584.4 = false;
						break;
					}
					action = 1584.3.Dequeue();
				}
				action();
			}
		});
	}

	// Token: 0x060045E9 RID: 17897 RVA: 0x001B6F34 File Offset: 0x001B5134
	private static void 15(string 1, string 2)
	{
		217 3 = 217.Parse(244.1(7, "GET", "applications/" + 2 + "/emojis", null));
		Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.Ordinal);
		foreach (226 4 in ((3["items"] as 109) ?? new 109()))
		{
			dictionary[(string)4["name"]] = (string)4["id"];
		}
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		foreach (string text in from 1 in executingAssembly.GetManifestResourceNames()
		where 1.StartsWith("nekiosu.discord.emote.", StringComparison.Ordinal)
		select 1)
		{
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text.Substring("nekiosu.discord.emote.".Length));
			string text2;
			if (!dictionary.TryGetValue(fileNameWithoutExtension, out text2))
			{
				byte[] array;
				using (Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(text))
				{
					using (MemoryStream memoryStream = new MemoryStream())
					{
						manifestResourceStream.CopyTo(memoryStream);
						array = memoryStream.ToArray();
					}
				}
				217 5 = new 217();
				5["name"] = fileNameWithoutExtension;
				5["image"] = 1584.16(array);
				217 6 = 5;
				text2 = (string)217.Parse(244.1(7, "POST", "applications/" + 2 + "/emojis", 6.ToString((95)0, Array.Empty<214>())))["id"];
				1338.5("Discord bot: emote " + fileNameWithoutExtension + " uploaded.", 1341.Runtime, (1114)2);
			}
			Dictionary<string, string> obj = 1584.5;
			lock (obj)
			{
				1584.5[fileNameWithoutExtension] = string.Concat(new string[]
				{
					"<:",
					fileNameWithoutExtension,
					":",
					text2,
					">"
				});
			}
		}
	}

	// Token: 0x060045EA RID: 17898 RVA: 0x001B71F0 File Offset: 0x001B53F0
	private static string 16(byte[] 1)
	{
		bool flag = 1.Length > 8 && 1[0] == 137 && 1[1] == 80 && 1[2] == 78 && 1[3] == 71;
		bool flag2 = 1.Length > 12 && 1[0] == 82 && 1[1] == 73 && 1[8] == 87 && 1[9] == 69;
		if (flag)
		{
			using (MemoryStream memoryStream = new MemoryStream(1))
			{
				using (Bitmap bitmap = new Bitmap(memoryStream))
				{
					if (bitmap.Width > 128 || bitmap.Height > 128)
					{
						float num = 128f / (float)Math.Max(bitmap.Width, bitmap.Height);
						using (Bitmap bitmap2 = new Bitmap(Math.Max(1, (int)Math.Round((double)((float)bitmap.Width * num))), Math.Max(1, (int)Math.Round((double)((float)bitmap.Height * num))), PixelFormat.Format32bppArgb))
						{
							using (Graphics graphics = Graphics.FromImage(bitmap2))
							{
								graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
								graphics.DrawImage(bitmap, 0, 0, bitmap2.Width, bitmap2.Height);
							}
							using (MemoryStream memoryStream2 = new MemoryStream())
							{
								bitmap2.Save(memoryStream2, ImageFormat.Png);
								1 = memoryStream2.ToArray();
							}
						}
					}
				}
			}
		}
		return "data:" + (flag2 ? "image/webp" : "image/png") + ";base64," + Convert.ToBase64String(1);
	}

	// Token: 0x04003316 RID: 13078
	private const string 1 = "nekiosu.discord.emote.";

	// Token: 0x04003317 RID: 13079
	private static readonly ConcurrentQueue<217> 2 = new ConcurrentQueue<217>();

	// Token: 0x04003318 RID: 13080
	private static readonly Queue<Action> 3 = new Queue<Action>();

	// Token: 0x04003319 RID: 13081
	private static bool 4;

	// Token: 0x0400331A RID: 13082
	private static readonly Dictionary<string, string> 5 = new Dictionary<string, string>(StringComparer.Ordinal);

	// Token: 0x0400331B RID: 13083
	private static 244.246 6;

	// Token: 0x0400331C RID: 13084
	private static Semaphore 7;

	// Token: 0x0400331D RID: 13085
	private static string 8;

	// Token: 0x0400331E RID: 13086
	private static bool 9;

	// Token: 0x0400331F RID: 13087
	private static bool 10;

	// Token: 0x04003320 RID: 13088
	private static string 11 = "Not set up.";

	// Token: 0x04003321 RID: 13089
	private static DateTime 12 = DateTime.MaxValue;

	// Token: 0x04003325 RID: 13093
	[CompilerGenerated]
	private static Action 13;

	// Token: 0x04003326 RID: 13094
	private static Tuple<string, string> 14;

	// Token: 0x020009BD RID: 2493
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04003327 RID: 13095
		public static Action<string, string> <0>__OnDispatch;

		// Token: 0x04003328 RID: 13096
		public static Action<string, bool> <1>__OnGatewayStatus;
	}
}
