using System;

// Token: 0x020009A7 RID: 2471
public sealed class 1640 : 1637
{
	// Token: 0x170002E9 RID: 745
	// (get) Token: 0x0600453D RID: 17725 RVA: 0x001B3EE0 File Offset: 0x001B20E0
	public string Name
	{
		get
		{
			return "osu.direct";
		}
	}

	// Token: 0x170002EA RID: 746
	// (get) Token: 0x0600453E RID: 17726 RVA: 0x001B3EE7 File Offset: 0x001B20E7
	public string[] Hosts
	{
		get
		{
			return new string[]
			{
				"osu.direct",
				"storage.osu.direct"
			};
		}
	}

	// Token: 0x0600453F RID: 17727 RVA: 0x001B3F00 File Offset: 0x001B2100
	public string GetSearchUrl(int 1, string 2, int 3, int 4)
	{
		string text = null;
		string stringToEscape = 2 ?? string.Empty;
		string a;
		if (1638.4(2, out a))
		{
			stringToEscape = string.Empty;
			text = ((a == "Top Rated") ? "favourite_count:desc" : ((a == "Most Played") ? "play_count:desc" : "last_updated:desc"));
		}
		string text2 = string.Format("{0}/v2/search?q={1}&amount={2}&offset={3}", new object[]
		{
			"https://osu.direct/api",
			Uri.EscapeDataString(stringToEscape),
			100,
			4 * 100
		});
		if (text != null)
		{
			text2 = text2 + "&sort=" + text;
		}
		if (3 >= 0)
		{
			text2 = text2 + "&mode=" + 3.ToString();
		}
		int[] array = 1638.3(1);
		if (array.Length != 0)
		{
			text2 = text2 + "&status=" + string.Join<int>(",", array);
		}
		return text2;
	}

	// Token: 0x06004540 RID: 17728 RVA: 0x001B2ECA File Offset: 0x001B10CA
	public bool SupportsLookup(char 1)
	{
		return 1 == 's' || 1 == 'b' || 1 == 'c';
	}

	// Token: 0x06004541 RID: 17729 RVA: 0x001B3FE0 File Offset: 0x001B21E0
	public string GetLookupUrl(char 1, string 2)
	{
		string str = Uri.EscapeDataString(2 ?? string.Empty);
		if (1 == 'b')
		{
			return "https://osu.direct/api/v2/b/" + str + "/set";
		}
		if (1 != 'c')
		{
			return "https://osu.direct/api/v2/s/" + str;
		}
		return "https://osu.direct/api/v2/md5/" + str + "/set";
	}

	// Token: 0x06004542 RID: 17730 RVA: 0x001B4034 File Offset: 0x001B2234
	public string GetDownloadUrl(int 1, bool 2)
	{
		return string.Format("{0}/d/{1}{2}", "https://osu.direct/api", 1, 2 ? "?noVideo=1" : string.Empty);
	}

	// Token: 0x06004543 RID: 17731 RVA: 0x00009D1A File Offset: 0x00007F1A
	public string GetThumbnailUrl(int 1)
	{
		return null;
	}

	// Token: 0x06004544 RID: 17732 RVA: 0x00009D1A File Offset: 0x00007F1A
	public string GetCoverUrl(int 1)
	{
		return null;
	}

	// Token: 0x06004545 RID: 17733 RVA: 0x001B405A File Offset: 0x001B225A
	public string GetPreviewUrl(int 1)
	{
		return string.Format("{0}/media/preview/set/{1}", "https://osu.direct/api", 1);
	}

	// Token: 0x06004546 RID: 17734 RVA: 0x001B4071 File Offset: 0x001B2271
	public string GetBeatmapInfoUrl(int 1)
	{
		return string.Format("{0}/get_beatmaps?b={1}", "https://osu.direct/api", 1);
	}

	// Token: 0x06004547 RID: 17735 RVA: 0x001B4088 File Offset: 0x001B2288
	public string GetBeatmapInfoByHashUrl(string 1)
	{
		return "https://osu.direct/api/get_beatmaps?h=" + Uri.EscapeDataString(1 ?? string.Empty);
	}

	// Token: 0x06004548 RID: 17736 RVA: 0x001B40A3 File Offset: 0x001B22A3
	public string GetBeatmapSetInfoUrl(int 1)
	{
		return string.Format("{0}/get_beatmaps?s={1}", "https://osu.direct/api", 1);
	}

	// Token: 0x06004549 RID: 17737 RVA: 0x00009D1A File Offset: 0x00007F1A
	public string GetReplayUrl(string 1, long 2)
	{
		return null;
	}

	// Token: 0x0600454A RID: 17738 RVA: 0x001B40BA File Offset: 0x001B22BA
	public string GetOsuFileUrl(int 1)
	{
		return string.Format("{0}/osu/{1}", "https://osu.direct/api", 1);
	}

	// Token: 0x0600454B RID: 17739 RVA: 0x001B40D1 File Offset: 0x001B22D1
	public string ToDirectSearch(string 1)
	{
		return 1638.8(1, 100);
	}

	// Token: 0x0600454C RID: 17740 RVA: 0x001B2FBA File Offset: 0x001B11BA
	public string ToDirectSet(string 1)
	{
		return 1638.7(1638.9(1638.6(1))) ?? string.Empty;
	}

	// Token: 0x0600454D RID: 17741 RVA: 0x001B31E2 File Offset: 0x001B13E2
	public string ToBeatmapRows(string 1, int 2, string 3)
	{
		return 1638.11(1, 2, 3);
	}

	// Token: 0x040032C4 RID: 12996
	private const string 1 = "https://osu.direct/api";

	// Token: 0x040032C5 RID: 12997
	private const int 2 = 100;
}
