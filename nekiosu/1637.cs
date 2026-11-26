using System;

// Token: 0x020009A1 RID: 2465
public interface 1637
{
	// Token: 0x170002E7 RID: 743
	// (get) Token: 0x06004513 RID: 17683
	string Name { get; }

	// Token: 0x170002E8 RID: 744
	// (get) Token: 0x06004514 RID: 17684
	string[] Hosts { get; }

	// Token: 0x06004515 RID: 17685
	string GetSearchUrl(int 1, string 2, int 3, int 4);

	// Token: 0x06004516 RID: 17686
	string GetLookupUrl(char 1, string 2);

	// Token: 0x06004517 RID: 17687
	bool SupportsLookup(char 1);

	// Token: 0x06004518 RID: 17688
	string GetDownloadUrl(int 1, bool 2);

	// Token: 0x06004519 RID: 17689
	string GetThumbnailUrl(int 1);

	// Token: 0x0600451A RID: 17690
	string GetCoverUrl(int 1);

	// Token: 0x0600451B RID: 17691
	string GetPreviewUrl(int 1);

	// Token: 0x0600451C RID: 17692
	string GetBeatmapInfoUrl(int 1);

	// Token: 0x0600451D RID: 17693
	string GetBeatmapInfoByHashUrl(string 1);

	// Token: 0x0600451E RID: 17694
	string GetBeatmapSetInfoUrl(int 1);

	// Token: 0x0600451F RID: 17695
	string GetReplayUrl(string 1, long 2);

	// Token: 0x06004520 RID: 17696
	string GetOsuFileUrl(int 1);

	// Token: 0x06004521 RID: 17697
	string ToDirectSearch(string 1);

	// Token: 0x06004522 RID: 17698
	string ToDirectSet(string 1);

	// Token: 0x06004523 RID: 17699
	string ToBeatmapRows(string 1, int 2, string 3);
}
