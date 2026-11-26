using System;

// Token: 0x02000A83 RID: 2691
public sealed class 1367 : 1433
{
	// Token: 0x06004A79 RID: 19065 RVA: 0x001D85B4 File Offset: 0x001D67B4
	public 1367(1381 1, 208 2, float 3, bool 4, 198 5, int 6) : base(1, (1376)6, 1065.Centre, (1044)0, 2, 3, 4, 5, null)
	{
		this.70 = 6;
	}

	// Token: 0x06004A7A RID: 19066 RVA: 0x001D85DC File Offset: 0x001D67DC
	internal override bool ContainsPoint(208 1, int 2 = 0)
	{
		float num = this.15 * (float)this.70 * 1662.70.3() / 2f;
		return 208.DistanceSquared(1, this.31) < num * num;
	}

	// Token: 0x0400377D RID: 14205
	internal int 70;
}
