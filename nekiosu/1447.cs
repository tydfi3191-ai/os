using System;

// Token: 0x02000B1E RID: 2846
public sealed class 1447 : 1433
{
	// Token: 0x06004EF2 RID: 20210 RVA: 0x001F31D0 File Offset: 0x001F13D0
	internal 1447(string 1, 1416 2, 1044 3, int 4 = 0) : base(null, (1376)4, 1065.Centre, 3, 208.Zero, 0.1f, true, 198.White, null)
	{
		this.73 = new 1511(1, 2, 3);
		this.50(((3 == (1044)0) ? 1662.33 : 0) + 4);
		this.70 = this.49() + this.73.2;
		this.39 = (this.35 = this.73.6());
		this.38 = (this.34 = this.73.7());
		this.48 = new 208((float)(this.73.6() / 2), (float)(this.73.7() / 2));
	}

	// Token: 0x06004EF3 RID: 20211 RVA: 0x001F328D File Offset: 0x001F148D
	internal 1447(string 1, int 2) : this(1, (1416)4, (1044)1, 2)
	{
	}

	// Token: 0x06004EF4 RID: 20212 RVA: 0x001F3299 File Offset: 0x001F1499
	internal new int 49()
	{
		return this.74;
	}

	// Token: 0x06004EF5 RID: 20213 RVA: 0x001F32A1 File Offset: 0x001F14A1
	internal new void 50(int 1)
	{
		this.74 = 1;
		this.73.12 = 1;
	}

	// Token: 0x06004EF6 RID: 20214 RVA: 0x001F32B6 File Offset: 0x001F14B6
	private int 51()
	{
		return ((this.1 == (1044)0) ? 1662.33 : 1226.17) - this.49();
	}

	// Token: 0x06004EF7 RID: 20215 RVA: 0x001F32D3 File Offset: 0x001F14D3
	internal new 1070 52()
	{
		if (this.73 == null)
		{
			return (1070)2;
		}
		if (this.51() - this.71 > 1000)
		{
			return (1070)0;
		}
		return this.73.1();
	}

	// Token: 0x06004EF8 RID: 20216 RVA: 0x001F3300 File Offset: 0x001F1500
	internal override 1381 GetTexture()
	{
		return this.73.5();
	}

	// Token: 0x06004EF9 RID: 20217 RVA: 0x001F3310 File Offset: 0x001F1510
	private new void 53()
	{
		if (this.72)
		{
			int num = this.49() + this.51();
			if (num >= this.70 && this.52() == (1070)0)
			{
				this.50(num);
				this.70 = this.49() + this.73.2;
				this.56(true);
			}
		}
	}

	// Token: 0x06004EFA RID: 20218 RVA: 0x001F336A File Offset: 0x001F156A
	internal new void 54()
	{
		this.53();
		this.73.9();
		this.71 = this.51();
	}

	// Token: 0x06004EFB RID: 20219 RVA: 0x001F338A File Offset: 0x001F158A
	internal new void 55(bool 1)
	{
		this.53();
		this.56(1);
	}

	// Token: 0x06004EFC RID: 20220 RVA: 0x001F339C File Offset: 0x001F159C
	private void 56(bool 1)
	{
		int num = this.51();
		if (num < 0)
		{
			num = 0;
		}
		this.73.10(num, 1);
	}

	// Token: 0x06004EFD RID: 20221 RVA: 0x001F33C3 File Offset: 0x001F15C3
	internal override void ReleaseResources(bool 1)
	{
		if (this.73 != null)
		{
			this.73.Dispose();
		}
		this.73 = null;
		base.ReleaseResources(1);
	}

	// Token: 0x04003AEA RID: 15082
	internal int 70;

	// Token: 0x04003AEB RID: 15083
	private int 71;

	// Token: 0x04003AEC RID: 15084
	internal bool 72;

	// Token: 0x04003AED RID: 15085
	internal 1511 73;

	// Token: 0x04003AEE RID: 15086
	private int 74;
}
