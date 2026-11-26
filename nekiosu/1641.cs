using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x020009A8 RID: 2472
public sealed class 1641 : 1637
{
	// Token: 0x170002EB RID: 747
	// (get) Token: 0x0600454F RID: 17743 RVA: 0x001B40DB File Offset: 0x001B22DB
	public string Name
	{
		get
		{
			return "sayobot";
		}
	}

	// Token: 0x170002EC RID: 748
	// (get) Token: 0x06004550 RID: 17744 RVA: 0x001B40E2 File Offset: 0x001B22E2
	public string[] Hosts
	{
		get
		{
			return new string[]
			{
				"api.sayobot.cn",
				"dl.sayobot.cn",
				"tc1.sayobot.cn",
				"a.sayobot.cn"
			};
		}
	}

	// Token: 0x06004551 RID: 17745 RVA: 0x001B410C File Offset: 0x001B230C
	public string GetSearchUrl(int 1, string 2, int 3, int 4)
	{
		string str = string.Concat(new string[]
		{
			1.ToString(),
			"|",
			3.ToString(),
			"|",
			2
		});
		int num = 0;
		Dictionary<string, int> obj = this.5;
		lock (obj)
		{
			if (4 > 0 && !this.5.TryGetValue(str + "|" + 4.ToString(), out num))
			{
				num = 4 * 100;
			}
			this.6 = str;
			this.7 = 4;
		}
		string text;
		if (1638.4(2, out text) && text != "Newest")
		{
			return string.Format("{0}/beatmaplist?0={1}&1={2}&2=1", "https://api.sayobot.cn", 100, num);
		}
		string stringToEscape = (text != null) ? string.Empty : (2 ?? string.Empty);
		string text2 = string.Format("{0}/beatmaplist?0={1}&1={2}&2=4&3={3}", new object[]
		{
			"https://api.sayobot.cn",
			100,
			num,
			Uri.EscapeDataString(stringToEscape)
		});
		if (3 >= 0 && 3 < 4)
		{
			text2 = text2 + "&5=" + (1 << 3).ToString();
		}
		int num2 = 0;
		foreach (int num3 in 1638.3(1))
		{
			num2 |= ((num3 == 1 || num3 == 2) ? 1 : ((num3 == 3) ? 2 : ((num3 == 4) ? 4 : ((num3 == 0 || num3 == -1) ? 8 : 16))));
		}
		if (num2 <= 0)
		{
			return text2;
		}
		return text2 + "&6=" + num2.ToString();
	}

	// Token: 0x06004552 RID: 17746 RVA: 0x001B42D0 File Offset: 0x001B24D0
	public bool SupportsLookup(char 1)
	{
		return 1 == 's' || 1 == 'b';
	}

	// Token: 0x06004553 RID: 17747 RVA: 0x001B42E0 File Offset: 0x001B24E0
	public string GetLookupUrl(char 1, string 2)
	{
		string str = Uri.EscapeDataString(2 ?? string.Empty);
		if (1 != 'b')
		{
			return "https://api.sayobot.cn/v2/beatmapinfo?0=" + str;
		}
		return "https://api.sayobot.cn/v2/beatmapinfo?K=" + str + "&T=1";
	}

	// Token: 0x06004554 RID: 17748 RVA: 0x001B431E File Offset: 0x001B251E
	public string GetDownloadUrl(int 1, bool 2)
	{
		return string.Format("https://dl.sayobot.cn/beatmaps/download/{0}/{1}", 2 ? "novideo" : "full", 1);
	}

	// Token: 0x06004555 RID: 17749 RVA: 0x001B433F File Offset: 0x001B253F
	public string GetThumbnailUrl(int 1)
	{
		return string.Format("{0}/beatmaps/{1}/covers/cover.jpg", "https://a.sayobot.cn", 1);
	}

	// Token: 0x06004556 RID: 17750 RVA: 0x001B433F File Offset: 0x001B253F
	public string GetCoverUrl(int 1)
	{
		return string.Format("{0}/beatmaps/{1}/covers/cover.jpg", "https://a.sayobot.cn", 1);
	}

	// Token: 0x06004557 RID: 17751 RVA: 0x001B4356 File Offset: 0x001B2556
	public string GetPreviewUrl(int 1)
	{
		return string.Format("{0}/preview/{1}.mp3", "https://a.sayobot.cn", 1);
	}

	// Token: 0x06004558 RID: 17752 RVA: 0x00009D1A File Offset: 0x00007F1A
	public string GetBeatmapInfoUrl(int 1)
	{
		return null;
	}

	// Token: 0x06004559 RID: 17753 RVA: 0x00009D1A File Offset: 0x00007F1A
	public string GetBeatmapInfoByHashUrl(string 1)
	{
		return null;
	}

	// Token: 0x0600455A RID: 17754 RVA: 0x00009D1A File Offset: 0x00007F1A
	public string GetBeatmapSetInfoUrl(int 1)
	{
		return null;
	}

	// Token: 0x0600455B RID: 17755 RVA: 0x00009D1A File Offset: 0x00007F1A
	public string GetReplayUrl(string 1, long 2)
	{
		return null;
	}

	// Token: 0x0600455C RID: 17756 RVA: 0x00009D1A File Offset: 0x00007F1A
	public string GetOsuFileUrl(int 1)
	{
		return null;
	}

	// Token: 0x0600455D RID: 17757 RVA: 0x001B4370 File Offset: 0x001B2570
	public string ToDirectSearch(string 1)
	{
		217 2 = 1638.6(6) as 217;
		if (2 == null)
		{
			return null;
		}
		if (2["data"] == null)
		{
			return 1638.2(new List<string>(), false);
		}
		109 3 = (2["data"] as 109) ?? new 109();
		int valueOrDefault = ((int?)2["endid"]).GetValueOrDefault();
		bool flag = valueOrDefault > 0 && 3.Count >= 100;
		Dictionary<string, int> obj = this.5;
		lock (obj)
		{
			if (flag && this.6 != null)
			{
				this.5[this.6 + "|" + (this.7 + 1).ToString()] = valueOrDefault;
			}
		}
		List<string> list = new List<string>();
		foreach (226 4 in 3)
		{
			int valueOrDefault2 = ((int?)4["sid"]).GetValueOrDefault();
			if (valueOrDefault2 > 0)
			{
				int modes = ((int?)4["modes"]).GetValueOrDefault(1);
				IEnumerable<string> 5 = from 1 in Enumerable.Range(0, 4)
				where (modes & 1 << 1) != 0
				select 1641.4[1] + "@" + 1.ToString();
				list.Add(1638.1(valueOrDefault2, (string)4["artist"], (string)4["title"], (string)4["creator"], ((int?)4["approved"]).GetValueOrDefault(), 1638.Date(4["lastupdate"]), false, false, 5));
			}
		}
		return 1638.2(list, flag);
	}

	// Token: 0x0600455E RID: 17758 RVA: 0x001B45BC File Offset: 0x001B27BC
	public string ToDirectSet(string 1)
	{
		217 2 = 1638.6(7) as 217;
		226 3 = (2 != null) ? 2["data"] : null;
		int valueOrDefault = ((int?)((3 != null) ? 3["sid"] : null)).GetValueOrDefault();
		if (valueOrDefault <= 0)
		{
			return string.Empty;
		}
		109 4 = 3["bid_data"] as 109;
		787<226>? 5 = (4 != null) ? new 787<226>?(4.Children()) : null;
		IEnumerable<226> source;
		if (5 == null)
		{
			source = Enumerable.Empty<226>();
		}
		else
		{
			IEnumerable<226> enumerable = 5.GetValueOrDefault();
			source = enumerable;
		}
		IEnumerable<string> 6 = from 1 in source
		orderby ((int?)1["mode"]).GetValueOrDefault(), ((double?)1["star"]).GetValueOrDefault()
		select 1638.Difficulty((string)1["version"], ((double?)1["star"]).GetValueOrDefault(), ((int?)1["mode"]).GetValueOrDefault());
		return 1638.1(valueOrDefault, (string)3["artist"], (string)3["title"], (string)3["creator"], ((int?)3["approved"]).GetValueOrDefault(), 1638.Date(3["last_update"]), ((int?)3["video"]).GetValueOrDefault() != 0, ((int?)3["storyboard"]).GetValueOrDefault() != 0, 6);
	}

	// Token: 0x0600455F RID: 17759 RVA: 0x00009D1A File Offset: 0x00007F1A
	public string ToBeatmapRows(string 1, int 2, string 3)
	{
		return null;
	}

	// Token: 0x040032C6 RID: 12998
	private const string 1 = "https://api.sayobot.cn";

	// Token: 0x040032C7 RID: 12999
	private const string 2 = "https://a.sayobot.cn";

	// Token: 0x040032C8 RID: 13000
	private const int 3 = 100;

	// Token: 0x040032C9 RID: 13001
	private static readonly string[] 4 = new string[]
	{
		"osu!",
		"osu!taiko",
		"osu!catch",
		"osu!mania"
	};

	// Token: 0x040032CA RID: 13002
	private readonly Dictionary<string, int> 5 = new Dictionary<string, int>();

	// Token: 0x040032CB RID: 13003
	private string 6;

	// Token: 0x040032CC RID: 13004
	private int 7;
}
