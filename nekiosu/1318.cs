using System;

// Token: 0x02000B56 RID: 2902
public sealed class 1318 : 1319
{
	// Token: 0x06004FEE RID: 20462 RVA: 0x001F8E17 File Offset: 0x001F7017
	public 1318(int 1 = 0) : base((double)1)
	{
		this.6 = 1.0;
	}

	// Token: 0x06004FEF RID: 20463 RVA: 0x001F8E30 File Offset: 0x001F7030
	public new int 6()
	{
		return (int)base.GetValue();
	}

	// Token: 0x06004FF0 RID: 20464 RVA: 0x001F8E39 File Offset: 0x001F7039
	public void 7(int 1)
	{
		base.SetValue((double)1);
	}

	// Token: 0x06004FF1 RID: 20465 RVA: 0x001F8E43 File Offset: 0x001F7043
	public int 8()
	{
		return (int)this.4;
	}

	// Token: 0x06004FF2 RID: 20466 RVA: 0x001F8E4C File Offset: 0x001F704C
	public void 9(int 1)
	{
		this.4 = (double)1;
	}

	// Token: 0x06004FF3 RID: 20467 RVA: 0x001F8E56 File Offset: 0x001F7056
	public static implicit operator int(1318 1)
	{
		return 1.6();
	}

	// Token: 0x06004FF4 RID: 20468 RVA: 0x001F8E5E File Offset: 0x001F705E
	public static implicit operator 1318(int 1)
	{
		return new 1318(1);
	}

	// Token: 0x06004FF5 RID: 20469 RVA: 0x001F8E68 File Offset: 0x001F7068
	public override string ToString()
	{
		return this.6().ToString(1662.18);
	}

	// Token: 0x06004FF6 RID: 20470 RVA: 0x001F8E88 File Offset: 0x001F7088
	internal void 10()
	{
		this.7(this.8());
	}
}
