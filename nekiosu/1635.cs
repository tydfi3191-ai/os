using System;
using System.Linq;

// Token: 0x0200099E RID: 2462
public sealed class 1635 : 1637
{
	// Token: 0x170002E3 RID: 739
	// (get) Token: 0x060044EC RID: 17644 RVA: 0x001B2E05 File Offset: 0x001B1005
	public string Name
	{
		get
		{
			return "catboy.best";
		}
	}

	// Token: 0x170002E4 RID: 740
	// (get) Token: 0x060044ED RID: 17645 RVA: 0x001B2E0C File Offset: 0x001B100C
	public string[] Hosts
	{
		get
		{
			return new string[]
			{
				"catboy.best"
			};
		}
	}

	// Token: 0x060044EE RID: 17646 RVA: 0x001B2E1C File Offset: 0x001B101C
	public string GetSearchUrl(int 1, string 2, int 3, int 4)
	{
		string text;
		string stringToEscape = 1638.4(2, out text) ? string.Empty : (2 ?? string.Empty);
		string str = string.Format("{0}/api/v2/search?query={1}&limit={2}&offset={3}", new object[]
		{
			"https://catboy.best",
			Uri.EscapeDataString(stringToEscape),
			101,
			4 * 100
		});
		if (3 >= 0)
		{
			str = str + "&mode=" + 3.ToString();
		}
		return str + string.Concat(from 1 in 1638.3(5)
		select "&status=" + 1.ToString());
	}

	// Token: 0x060044EF RID: 17647 RVA: 0x001B2ECA File Offset: 0x001B10CA
	public bool SupportsLookup(char 1)
	{
		return 1 == 's' || 1 == 'b' || 1 == 'c';
	}

	// Token: 0x060044F0 RID: 17648 RVA: 0x001B2EE0 File Offset: 0x001B10E0
	public string GetLookupUrl(char 1, string 2)
	{
		string str = Uri.EscapeDataString(2 ?? string.Empty);
		if (1 == 'b')
		{
			return "https://catboy.best/api/v2/b/" + str;
		}
		if (1 != 'c')
		{
			return "https://catboy.best/api/v2/s/" + str;
		}
		return "https://catboy.best/api/v2/md5/" + str;
	}

	// Token: 0x060044F1 RID: 17649 RVA: 0x001B2F2A File Offset: 0x001B112A
	public string GetDownloadUrl(int 1, bool 2)
	{
		return string.Format("{0}/d/{1}{2}", "https://catboy.best", 1, 2 ? "n" : string.Empty);
	}

	// Token: 0x060044F2 RID: 17650 RVA: 0x00009D1A File Offset: 0x00007F1A
	public string GetThumbnailUrl(int 1)
	{
		return null;
	}

	// Token: 0x060044F3 RID: 17651 RVA: 0x00009D1A File Offset: 0x00007F1A
	public string GetCoverUrl(int 1)
	{
		return null;
	}

	// Token: 0x060044F4 RID: 17652 RVA: 0x00009D1A File Offset: 0x00007F1A
	public string GetPreviewUrl(int 1)
	{
		return null;
	}

	// Token: 0x060044F5 RID: 17653 RVA: 0x001B2F50 File Offset: 0x001B1150
	public string GetBeatmapInfoUrl(int 1)
	{
		return string.Format("{0}/api/v2/b/{1}", "https://catboy.best", 1);
	}

	// Token: 0x060044F6 RID: 17654 RVA: 0x001B2F67 File Offset: 0x001B1167
	public string GetBeatmapInfoByHashUrl(string 1)
	{
		return "https://catboy.best/api/v2/md5/" + Uri.EscapeDataString(1 ?? string.Empty);
	}

	// Token: 0x060044F7 RID: 17655 RVA: 0x001B2F82 File Offset: 0x001B1182
	public string GetBeatmapSetInfoUrl(int 1)
	{
		return string.Format("{0}/api/v2/s/{1}", "https://catboy.best", 1);
	}

	// Token: 0x060044F8 RID: 17656 RVA: 0x00009D1A File Offset: 0x00007F1A
	public string GetReplayUrl(string 1, long 2)
	{
		return null;
	}

	// Token: 0x060044F9 RID: 17657 RVA: 0x001B2F99 File Offset: 0x001B1199
	public string GetOsuFileUrl(int 1)
	{
		return string.Format("{0}/osu/{1}", "https://catboy.best", 1);
	}

	// Token: 0x060044FA RID: 17658 RVA: 0x001B2FB0 File Offset: 0x001B11B0
	public string ToDirectSearch(string 1)
	{
		return 1638.8(1, 101);
	}

	// Token: 0x060044FB RID: 17659 RVA: 0x001B2FBA File Offset: 0x001B11BA
	public string ToDirectSet(string 1)
	{
		return 1638.7(1638.9(1638.6(1))) ?? string.Empty;
	}

	// Token: 0x060044FC RID: 17660 RVA: 0x001B2FD8 File Offset: 0x001B11D8
	public string ToBeatmapRows(string 1, int 2, string 3)
	{
		226 4 = 1638.6(1);
		if (4 != null)
		{
			return 1638.10(1638.9(4), 2, 3);
		}
		return null;
	}

	// Token: 0x040032B3 RID: 12979
	private const string 1 = "https://catboy.best";

	// Token: 0x040032B4 RID: 12980
	private const int 2 = 101;
}
