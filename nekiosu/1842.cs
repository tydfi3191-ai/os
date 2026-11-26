using System;
using System.Collections.Generic;

// Token: 0x020007D5 RID: 2005
public sealed class 1842 : 1896
{
	// Token: 0x06003A49 RID: 14921 RVA: 0x0016ED98 File Offset: 0x0016CF98
	public 1842(2034 1, 2034 2, double 3, float 4, List<1896> 5, int 6) : base(1, 2, 3, 5, 6, 0.0)
	{
		float num = 41f / 4;
		this.9 = this.2.8.X * num;
		this.10 = this.3.8.X * num;
		this.15 = Math.Max(40.0, this.4);
		this.11();
	}

	// Token: 0x06003A4A RID: 14922 RVA: 0x0016EE14 File Offset: 0x0016D014
	public new float 3()
	{
		return this.11;
	}

	// Token: 0x06003A4B RID: 14923 RVA: 0x0016EE1C File Offset: 0x0016D01C
	private new void 4(float 1)
	{
		this.11 = 1;
	}

	// Token: 0x06003A4C RID: 14924 RVA: 0x0016EE25 File Offset: 0x0016D025
	public new float 5()
	{
		return this.12;
	}

	// Token: 0x06003A4D RID: 14925 RVA: 0x0016EE2D File Offset: 0x0016D02D
	private new void 6(float 1)
	{
		this.12 = 1;
	}

	// Token: 0x06003A4E RID: 14926 RVA: 0x0016EE36 File Offset: 0x0016D036
	public new float 7()
	{
		return this.13;
	}

	// Token: 0x06003A4F RID: 14927 RVA: 0x0016EE3E File Offset: 0x0016D03E
	private new void 8(float 1)
	{
		this.13 = 1;
	}

	// Token: 0x06003A50 RID: 14928 RVA: 0x0016EE47 File Offset: 0x0016D047
	public float 9()
	{
		return this.14;
	}

	// Token: 0x06003A51 RID: 14929 RVA: 0x0016EE4F File Offset: 0x0016D04F
	private void 10(float 1)
	{
		this.14 = 1;
	}

	// Token: 0x06003A52 RID: 14930 RVA: 0x0016EE58 File Offset: 0x0016D058
	private void 11()
	{
		this.6((this.8 == 0) ? this.10 : ((1842)base.1(0)).3());
		this.4(1052.19(this.5(), this.9 - 25f, this.9 + 25f));
		this.8(this.3() - this.5());
		this.10(this.9 - this.5());
		if (((1866)this.3).9())
		{
			this.4(this.9);
		}
	}

	// Token: 0x04002AFD RID: 11005
	public readonly float 9;

	// Token: 0x04002AFE RID: 11006
	public readonly float 10;

	// Token: 0x04002AFF RID: 11007
	private float 11;

	// Token: 0x04002B00 RID: 11008
	private float 12;

	// Token: 0x04002B01 RID: 11009
	private float 13;

	// Token: 0x04002B02 RID: 11010
	private float 14;

	// Token: 0x04002B03 RID: 11011
	public readonly double 15;
}
