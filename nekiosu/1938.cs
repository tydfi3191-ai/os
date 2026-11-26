using System;

// Token: 0x0200082E RID: 2094
public sealed class 1938
{
	// Token: 0x06003CBA RID: 15546 RVA: 0x00180B44 File Offset: 0x0017ED44
	public 1938(int 1, float 2, int 3 = 100)
	{
		this.4 = 1;
		this.5 = Math.Max(1f, Math.Min(10f, (float)Math.Round((double)2, 1)));
		this.9 = Math.Max(1, Math.Min(100, 3));
	}

	// Token: 0x170002B2 RID: 690
	// (get) Token: 0x06003CBB RID: 15547 RVA: 0x00180B95 File Offset: 0x0017ED95
	public bool HasDefaultSharpness
	{
		get
		{
			return Math.Abs(this.5 - 7f) < 0.05f;
		}
	}

	// Token: 0x170002B3 RID: 691
	// (get) Token: 0x06003CBC RID: 15548 RVA: 0x00180BAF File Offset: 0x0017EDAF
	public bool HasDefaultStrength
	{
		get
		{
			return this.9 == 100;
		}
	}

	// Token: 0x04002CD8 RID: 11480
	public const float 1 = 7f;

	// Token: 0x04002CD9 RID: 11481
	public const float 2 = 1f;

	// Token: 0x04002CDA RID: 11482
	public const float 3 = 10f;

	// Token: 0x04002CDB RID: 11483
	public readonly int 4;

	// Token: 0x04002CDC RID: 11484
	public readonly float 5;

	// Token: 0x04002CDD RID: 11485
	public const int 6 = 1;

	// Token: 0x04002CDE RID: 11486
	public const int 7 = 100;

	// Token: 0x04002CDF RID: 11487
	public const int 8 = 100;

	// Token: 0x04002CE0 RID: 11488
	public readonly int 9;
}
