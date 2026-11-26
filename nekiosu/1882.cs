using System;

// Token: 0x020007B4 RID: 1972
public sealed class 1882 : 2499
{
	// Token: 0x06003980 RID: 14720 RVA: 0x0016AB81 File Offset: 0x00168D81
	internal 1882(1436 1) : base(1)
	{
	}

	// Token: 0x06003981 RID: 14721 RVA: 0x0013CA3D File Offset: 0x0013AC3D
	protected override string FormatCombo()
	{
		return this.4.ToString();
	}

	// Token: 0x06003982 RID: 14722 RVA: 0x0016AB8C File Offset: 0x00168D8C
	protected override void CreateSprites()
	{
		2137 <<EMPTY_NAME>> = 2630.5;
		208 2 = new 208(2f, 240f);
		this.2 = new 1353(this.FormatCombo(), <<EMPTY_NAME>>.FontCombo, (float)<<EMPTY_NAME>>.FontComboOverlap, (1376)6, 1065.Centre, (1044)0, 2, 0.9f, true, 198.TransparentWhite, true, (1416)7);
		this.3 = new 1353(string.Empty, <<EMPTY_NAME>>.FontCombo, (float)<<EMPTY_NAME>>.FontComboOverlap, (1376)6, 1065.Centre, (1044)0, 2, 0.91f, true, 198.TransparentWhite, true, (1416)7);
		this.3.28 = true;
		this.1.12(this.2);
		this.1.12(this.3);
	}

	// Token: 0x06003983 RID: 14723 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void Show()
	{
	}

	// Token: 0x06003984 RID: 14724 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void Hide()
	{
	}

	// Token: 0x06003985 RID: 14725 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void UpdateVisibility()
	{
	}

	// Token: 0x06003986 RID: 14726 RVA: 0x0016AC3B File Offset: 0x00168E3B
	internal new void 4(float 1)
	{
		base.UpdateDisplay();
		this.2.17.X = 1;
		this.3.17.X = 1;
	}

	// Token: 0x06003987 RID: 14727 RVA: 0x0016AC65 File Offset: 0x00168E65
	protected override void OnDisplayedComboDecreased()
	{
		this.2.16(100, (1046)0, 0);
	}

	// Token: 0x06003988 RID: 14728 RVA: 0x0016AC78 File Offset: 0x00168E78
	protected override void AnimateComboIncrement(bool 1)
	{
		this.2.3.Clear();
		this.3.3.Clear();
		this.2.16 = 1f;
		this.2.3.Add(new 1445(1456.Scale, 2f, 1f, 1662.33, 1662.33 + 300, (1046)0)
		{
			15 = (1046)1,
			16 = 1
		});
		this.2.3.Add(new 1445(1456.Fade, 1f, 0f, 1662.33 + 1000, 1662.33 + 1300, (1046)0)
		{
			16 = 1
		});
		this.3.3.Add(new 1445(1456.Scale, 2f, 2.4f, 1662.33, 1662.33 + 400, (1046)0)
		{
			15 = (1046)1,
			16 = 1
		});
		this.3.3.Add(new 1445(1456.Fade, 0.7f, 0f, 1662.33, 1662.33 + 400, (1046)0)
		{
			16 = 1
		});
	}

	// Token: 0x06003989 RID: 14729 RVA: 0x0016ADA9 File Offset: 0x00168FA9
	internal void 5(198 1)
	{
		this.3.40(1, 300);
	}
}
