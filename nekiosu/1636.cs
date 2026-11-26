using System;

// Token: 0x020009A0 RID: 2464
public sealed class 1636 : 1637
{
	// Token: 0x170002E5 RID: 741
	// (get) Token: 0x06004501 RID: 17665 RVA: 0x001B301D File Offset: 0x001B121D
	public string Name
	{
		get
		{
			return "hinamizawa.ai";
		}
	}

	// Token: 0x170002E6 RID: 742
	// (get) Token: 0x06004502 RID: 17666 RVA: 0x001B3024 File Offset: 0x001B1224
	public string[] Hosts
	{
		get
		{
			return new string[]
			{
				"mirror.hinamizawa.ai"
			};
		}
	}

	// Token: 0x06004503 RID: 17667 RVA: 0x001B3034 File Offset: 0x001B1234
	public string GetSearchUrl(int 1, string 2, int 3, int 4)
	{
		return string.Format("{0}/api/v1/aeris/search?r={1}&q={2}&m={3}&p={4}", new object[]
		{
			"https://mirror.hinamizawa.ai",
			1,
			Uri.EscapeDataString(2 ?? string.Empty),
			3,
			4
		});
	}

	// Token: 0x06004504 RID: 17668 RVA: 0x001B2ECA File Offset: 0x001B10CA
	public bool SupportsLookup(char 1)
	{
		return 1 == 's' || 1 == 'b' || 1 == 'c';
	}

	// Token: 0x06004505 RID: 17669 RVA: 0x001B3087 File Offset: 0x001B1287
	public string GetLookupUrl(char 1, string 2)
	{
		return string.Format("{0}/api/v1/aeris/search-set?{1}={2}", "https://mirror.hinamizawa.ai", 1, Uri.EscapeDataString(2 ?? string.Empty));
	}

	// Token: 0x06004506 RID: 17670 RVA: 0x001B30AD File Offset: 0x001B12AD
	public string GetDownloadUrl(int 1, bool 2)
	{
		return string.Format("{0}/api/v1/hinai/d/{1}{2}", "https://mirror.hinamizawa.ai", 1, 2 ? "n" : string.Empty);
	}

	// Token: 0x06004507 RID: 17671 RVA: 0x001B30D3 File Offset: 0x001B12D3
	public string GetThumbnailUrl(int 1)
	{
		return string.Format("{0}/api/media/cover/set/{1}?type=list", "https://mirror.hinamizawa.ai", 1);
	}

	// Token: 0x06004508 RID: 17672 RVA: 0x001B30EA File Offset: 0x001B12EA
	public string GetCoverUrl(int 1)
	{
		return string.Format("{0}/api/media/cover/set/{1}?type=card", "https://mirror.hinamizawa.ai", 1);
	}

	// Token: 0x06004509 RID: 17673 RVA: 0x001B3101 File Offset: 0x001B1301
	public string GetPreviewUrl(int 1)
	{
		return string.Format("{0}/v3/osu/music/preview/{1}", "https://mirror.hinamizawa.ai", 1);
	}

	// Token: 0x0600450A RID: 17674 RVA: 0x001B3118 File Offset: 0x001B1318
	public string GetBeatmapInfoUrl(int 1)
	{
		return string.Format("{0}/api/get_beatmaps?b={1}", "https://mirror.hinamizawa.ai", 1);
	}

	// Token: 0x0600450B RID: 17675 RVA: 0x001B312F File Offset: 0x001B132F
	public string GetBeatmapInfoByHashUrl(string 1)
	{
		return "https://mirror.hinamizawa.ai/api/get_beatmaps?h=" + Uri.EscapeDataString(1 ?? string.Empty);
	}

	// Token: 0x0600450C RID: 17676 RVA: 0x001B314A File Offset: 0x001B134A
	public string GetBeatmapSetInfoUrl(int 1)
	{
		return string.Format("{0}/api/get_beatmaps?s={1}", "https://mirror.hinamizawa.ai", 1);
	}

	// Token: 0x0600450D RID: 17677 RVA: 0x001B3161 File Offset: 0x001B1361
	public string GetReplayUrl(string 1, long 2)
	{
		return string.Format("{0}/v3/osu/scores/{1}/{2}/download", "https://mirror.hinamizawa.ai", 1, 2);
	}

	// Token: 0x0600450E RID: 17678 RVA: 0x001B3179 File Offset: 0x001B1379
	public string GetOsuFileUrl(int 1)
	{
		return string.Format("{0}/api/osu/{1}", "https://mirror.hinamizawa.ai", 1);
	}

	// Token: 0x0600450F RID: 17679 RVA: 0x001B3190 File Offset: 0x001B1390
	public string ToDirectSearch(string 1)
	{
		string text = 1 ?? string.Empty;
		int num = text.IndexOf('\n');
		int num2;
		if (!int.TryParse((num < 0) ? text.Trim() : text.Substring(0, num).Trim(), out num2))
		{
			return null;
		}
		return text;
	}

	// Token: 0x06004510 RID: 17680 RVA: 0x001B31D6 File Offset: 0x001B13D6
	public string ToDirectSet(string 1)
	{
		return 1 ?? string.Empty;
	}

	// Token: 0x06004511 RID: 17681 RVA: 0x001B31E2 File Offset: 0x001B13E2
	public string ToBeatmapRows(string 1, int 2, string 3)
	{
		return 1638.11(1, 2, 3);
	}

	// Token: 0x040032B7 RID: 12983
	private const string 1 = "https://mirror.hinamizawa.ai";
}
