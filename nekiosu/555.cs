using System;

// Token: 0x02000269 RID: 617
public class 555
{
	// Token: 0x060012B5 RID: 4789 RVA: 0x00042908 File Offset: 0x00040B08
	public 555()
	{
		this.flag6 = false;
		this._recoveredType16945793 = (639)2;
		this.flag5 = false;
		this._recoveredType18075791 = 915._recoveredType18073841;
		this._recoveredType13395790 = (567)3;
		this.flag4 = false;
		this.flag3 = false;
		this.flag2 = false;
	}

	// Token: 0x060012B6 RID: 4790 RVA: 0x00042958 File Offset: 0x00040B58
	public 555(555 1)
	{
		this.flag2 = 1.GetFlag5787_7488();
		this.flag3 = 1.GetFlag5788_7490();
		this.flag4 = 1.GetFlag5789_7492();
		this._recoveredType13395790 = 1.GetRecoveredType13395790_7494();
		this._recoveredType18075791 = 1.GetRecoveredType18075791_7496();
		this._recoveredType16945793 = 1.GetRecoveredType16945793_7500();
		this.flag5 = 1.GetFlag5792_7498();
		this.flag6 = 1.GetFlag5794_7502();
	}

	// Token: 0x060012B7 RID: 4791 RVA: 0x000429CB File Offset: 0x00040BCB
	protected void Method7487()
	{
		if (this.flag7)
		{
			throw new NotSupportedException("This is a readonly instance and set is not supported");
		}
	}

	// Token: 0x060012B8 RID: 4792 RVA: 0x000429E0 File Offset: 0x00040BE0
	public virtual bool GetFlag5787_7488()
	{
		return this.flag2;
	}

	// Token: 0x060012B9 RID: 4793 RVA: 0x000429E8 File Offset: 0x00040BE8
	public virtual void Method7489(bool 1)
	{
		this.Method7487();
		this.flag2 = 1;
	}

	// Token: 0x060012BA RID: 4794 RVA: 0x000429F7 File Offset: 0x00040BF7
	public virtual bool GetFlag5788_7490()
	{
		return this.flag3;
	}

	// Token: 0x060012BB RID: 4795 RVA: 0x000429FF File Offset: 0x00040BFF
	public virtual void Method7491(bool 1)
	{
		this.Method7487();
		this.flag3 = 1;
	}

	// Token: 0x060012BC RID: 4796 RVA: 0x00042A0E File Offset: 0x00040C0E
	public virtual bool GetFlag5789_7492()
	{
		return this.flag4;
	}

	// Token: 0x060012BD RID: 4797 RVA: 0x00042A16 File Offset: 0x00040C16
	public virtual void Method7493(bool 1)
	{
		this.Method7487();
		this.flag4 = 1;
	}

	// Token: 0x060012BE RID: 4798 RVA: 0x00042A25 File Offset: 0x00040C25
	public virtual 567 GetRecoveredType13395790_7494()
	{
		return this._recoveredType13395790;
	}

	// Token: 0x060012BF RID: 4799 RVA: 0x00042A2D File Offset: 0x00040C2D
	public virtual void Method7495(567 1)
	{
		this.Method7487();
		this._recoveredType13395790 = 1;
	}

	// Token: 0x060012C0 RID: 4800 RVA: 0x00042A3C File Offset: 0x00040C3C
	public virtual 675 GetRecoveredType18075791_7496()
	{
		return this._recoveredType18075791;
	}

	// Token: 0x060012C1 RID: 4801 RVA: 0x00042A44 File Offset: 0x00040C44
	public virtual void Method7497(675 1)
	{
		this.Method7487();
		this._recoveredType18075791 = 1;
	}

	// Token: 0x060012C2 RID: 4802 RVA: 0x00042A53 File Offset: 0x00040C53
	public virtual bool GetFlag5792_7498()
	{
		return this.flag5;
	}

	// Token: 0x060012C3 RID: 4803 RVA: 0x00042A5B File Offset: 0x00040C5B
	public virtual void Method7499(bool 1)
	{
		this.Method7487();
		this.flag5 = 1;
	}

	// Token: 0x060012C4 RID: 4804 RVA: 0x00042A6A File Offset: 0x00040C6A
	public virtual 639 GetRecoveredType16945793_7500()
	{
		return this._recoveredType16945793;
	}

	// Token: 0x060012C5 RID: 4805 RVA: 0x00042A72 File Offset: 0x00040C72
	public virtual void SetRecoveredType16945793_7501(639 1)
	{
		this._recoveredType16945793 = 1;
	}

	// Token: 0x060012C6 RID: 4806 RVA: 0x00042A7B File Offset: 0x00040C7B
	public virtual bool GetFlag5794_7502()
	{
		return this.flag6;
	}

	// Token: 0x060012C7 RID: 4807 RVA: 0x00042A83 File Offset: 0x00040C83
	public virtual void Method7503(bool 1)
	{
		this.Method7487();
		this.flag6 = 1;
	}

	// Token: 0x060012C8 RID: 4808 RVA: 0x00042A92 File Offset: 0x00040C92
	public 555 Method7504()
	{
		return new 555(this)
		{
			flag7 = true
		};
	}

	// Token: 0x040008F9 RID: 2297
	private bool flag2;

	// Token: 0x040008FA RID: 2298
	private bool flag3;

	// Token: 0x040008FB RID: 2299
	private bool flag4;

	// Token: 0x040008FC RID: 2300
	private 567 _recoveredType13395790;

	// Token: 0x040008FD RID: 2301
	private 675 _recoveredType18075791;

	// Token: 0x040008FE RID: 2302
	private bool flag5;

	// Token: 0x040008FF RID: 2303
	private 639 _recoveredType16945793;

	// Token: 0x04000900 RID: 2304
	private bool flag6;

	// Token: 0x04000901 RID: 2305
	protected bool flag7;
}
