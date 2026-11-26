using System;
using System.Collections.Generic;

// Token: 0x02000852 RID: 2130
public class 1896
{
	// Token: 0x06003DD5 RID: 15829 RVA: 0x001848E8 File Offset: 0x00182AE8
	public 1896(2034 1, 2034 2, double 3, List<1896> 4, int 5, double 6 = 0.0)
	{
		this.1 = 4;
		this.2 = 1;
		this.3 = 2;
		this.4 = (1.DifficultyStartTime - 2.DifficultyStartTime) / 3;
		this.5 = (1.DifficultyStartTime + 6) / 3;
		this.6 = (((1.25 != null && 1.2 == 1.1) ? 1.25.Value : ((double)1.2)) + 6) / 3;
		this.8 = 5;
		this.7 = 3;
	}

	// Token: 0x06003DD6 RID: 15830 RVA: 0x00184980 File Offset: 0x00182B80
	public 1896(double 1, double 2, double 3, double 4, List<1896> 5, int 6)
	{
		this.1 = 5;
		this.4 = (1 - 3) / 4;
		this.5 = 1 / 4;
		this.6 = 2 / 4;
		this.8 = 6;
		this.7 = 4;
	}

	// Token: 0x06003DD7 RID: 15831 RVA: 0x001849C0 File Offset: 0x00182BC0
	public 1896 1(int 1)
	{
		int num = this.8 - (1 + 1);
		if (num < 0 || num >= this.1.Count)
		{
			return null;
		}
		return this.1[num];
	}

	// Token: 0x06003DD8 RID: 15832 RVA: 0x001849F8 File Offset: 0x00182BF8
	public 1896 2(int 1)
	{
		int num = this.8 + (1 + 1);
		if (num < 0 || num >= this.1.Count)
		{
			return null;
		}
		return this.1[num];
	}

	// Token: 0x04002D5E RID: 11614
	private readonly List<1896> 1;

	// Token: 0x04002D5F RID: 11615
	public readonly 2034 2;

	// Token: 0x04002D60 RID: 11616
	public readonly 2034 3;

	// Token: 0x04002D61 RID: 11617
	public readonly double 4;

	// Token: 0x04002D62 RID: 11618
	public readonly double 5;

	// Token: 0x04002D63 RID: 11619
	public readonly double 6;

	// Token: 0x04002D64 RID: 11620
	public readonly double 7;

	// Token: 0x04002D65 RID: 11621
	public readonly int 8;
}
