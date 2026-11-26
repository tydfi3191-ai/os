using System;

// Token: 0x02000BB1 RID: 2993
public struct 1244
{
	// Token: 0x0600526B RID: 21099 RVA: 0x00206FB9 File Offset: 0x002051B9
	public 1244(1245 1, 1254 2, 1253 3, int 4, 1254 5 = 1254.None)
	{
		this.1 = 1;
		this.2 = 2;
		this.3 = 5;
		this.4 = 3;
		this.5 = 4;
	}

	// Token: 0x0600526C RID: 21100 RVA: 0x00206FE0 File Offset: 0x002051E0
	public static 1244 1(1245 1, 1254 2, 1253 3, int 4, 1254 5)
	{
		if (1 == 1245.None || (2630.5 != null && 2630.5.LayeredHitSounds && 1272.5() != null && 1272.5().3() != 2147.OsuMania))
		{
			1 |= 1245.Normal;
		}
		return new 1244(1, 2, 3, 4, 5);
	}

	// Token: 0x0600526D RID: 21101 RVA: 0x0020701C File Offset: 0x0020521C
	public override string ToString()
	{
		return string.Format("{1} {2} {3} {4}% - {0}", new object[]
		{
			this.1,
			this.2,
			this.3,
			this.4,
			this.5
		});
	}

	// Token: 0x04003EBE RID: 16062
	public 1245 1;

	// Token: 0x04003EBF RID: 16063
	public 1254 2;

	// Token: 0x04003EC0 RID: 16064
	public 1254 3;

	// Token: 0x04003EC1 RID: 16065
	public 1253 4;

	// Token: 0x04003EC2 RID: 16066
	public int 5;
}
