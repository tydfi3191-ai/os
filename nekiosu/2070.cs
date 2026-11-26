using System;

// Token: 0x02000829 RID: 2089
[276]
public abstract class 2070 : 2034
{
	// Token: 0x06003CA7 RID: 15527 RVA: 0x001809A4 File Offset: 0x0017EBA4
	protected 2070(2039 1, int 2, int 3, 1245 4) : base(1)
	{
		this.8 = new 208(256f, 192f);
		this.18 = this.8;
		this.1 = 2;
		this.2 = 3;
		this.3 = 2047.Spinner;
		if (this.28.21.32 <= 8)
		{
			this.3 |= 2047.NewCombo;
		}
		this.4 = 4;
		this.7 = 198.Gray;
	}

	// Token: 0x06003CA8 RID: 15528 RVA: 0x00180A24 File Offset: 0x0017EC24
	internal override void PlayHitSound()
	{
		1259 <<EMPTY_NAME>> = this.28.21.92((double)this.2);
		if (<<EMPTY_NAME>> != null)
		{
			base.7(<<EMPTY_NAME>>, this.4, this.35, this.36);
		}
	}
}
