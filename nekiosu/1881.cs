using System;

// Token: 0x020007BA RID: 1978
[Serializable]
public sealed class 1881 : 2627
{
	// Token: 0x060039BA RID: 14778 RVA: 0x0016CD73 File Offset: 0x0016AF73
	public 1881()
	{
	}

	// Token: 0x060039BB RID: 14779 RVA: 0x0016CD86 File Offset: 0x0016AF86
	public 1881(1881 1) : this()
	{
	}

	// Token: 0x060039BC RID: 14780 RVA: 0x0016CD90 File Offset: 0x0016AF90
	internal 198 14()
	{
		198? <<EMPTY_NAME>> = this.colourHyperDashAfterImage;
		if (<<EMPTY_NAME>> == null)
		{
			return this.ColourHyperDash;
		}
		return <<EMPTY_NAME>>.GetValueOrDefault();
	}

	// Token: 0x060039BD RID: 14781 RVA: 0x0016CDBC File Offset: 0x0016AFBC
	internal 198 15()
	{
		198? <<EMPTY_NAME>> = this.colourHyperDashFruit;
		if (<<EMPTY_NAME>> == null)
		{
			return this.ColourHyperDash;
		}
		return <<EMPTY_NAME>>.GetValueOrDefault();
	}

	// Token: 0x060039BE RID: 14782 RVA: 0x0016CDE8 File Offset: 0x0016AFE8
	protected override void ReadSettings()
	{
		base.5("CatchTheBeat");
		base.6<198>("HyperDash", ref this.ColourHyperDash);
		base.6<198?>("HyperDashAfterImage", ref this.colourHyperDashAfterImage);
		base.6<198?>("HyperDashFruit", ref this.colourHyperDashFruit);
	}

	// Token: 0x060039BF RID: 14783 RVA: 0x0016CE38 File Offset: 0x0016B038
	protected override void WriteSettings()
	{
		base.5("CatchTheBeat");
		base.11("HyperDash", "ColourHyperDash", false);
		base.10<198>("HyperDashAfterImage", this.14(), this.ColourHyperDash, false);
		base.10<198>("HyperDashFruit", this.15(), this.ColourHyperDash, false);
	}

	// Token: 0x04002ABD RID: 10941
	internal 198 ColourHyperDash = 198.Red;

	// Token: 0x04002ABE RID: 10942
	private 198? colourHyperDashAfterImage;

	// Token: 0x04002ABF RID: 10943
	private 198? colourHyperDashFruit;
}
