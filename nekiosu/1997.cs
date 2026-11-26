using System;
using System.Collections.Generic;

// Token: 0x02000759 RID: 1881
public sealed class 1997 : 2499
{
	// Token: 0x06003740 RID: 14144 RVA: 0x0015A8A8 File Offset: 0x00158AA8
	public 1997(1436 1, 2011 2, bool 3 = true) : base(1)
	{
		this.14 = 2;
		this.2.17 = new 208(2.28() + 2.20 / 2f, 2.47((float)2.4.ComboPosition));
		this.2.48 = 208.Zero;
		this.2.49 = 1065.Centre;
		if (2630.5.Version >= 2.4 || 2.37() < 1f)
		{
			this.2.15 = 2.39();
		}
		this.2.96 = true;
		this.9 = 2.4.18("Hold");
		this.10 = 2.4.18("Break");
		if (!3 || 2.4() == null)
		{
			return;
		}
		foreach (2011 4 in 2.4())
		{
			this.13.Add(new 1997(1, 4, false));
		}
	}

	// Token: 0x06003741 RID: 14145 RVA: 0x0015A9EC File Offset: 0x00158BEC
	internal override int GetCombo()
	{
		return base.GetCombo();
	}

	// Token: 0x06003742 RID: 14146 RVA: 0x0015A9F4 File Offset: 0x00158BF4
	internal override void SetCombo(int 1)
	{
		base.SetCombo(1);
		this.13.ForEach(new Action<1997>(this.4));
	}

	// Token: 0x06003743 RID: 14147 RVA: 0x0013CA3D File Offset: 0x0013AC3D
	protected override string FormatCombo()
	{
		return this.4.ToString();
	}

	// Token: 0x06003744 RID: 14148 RVA: 0x0015AA14 File Offset: 0x00158C14
	internal override void Hide()
	{
		this.2.16(500, (1046)0, 0);
		this.13.ForEach(new Action<1997>(1997.1998.instance.1));
	}

	// Token: 0x06003745 RID: 14149 RVA: 0x0015AA43 File Offset: 0x00158C43
	internal override void UpdateVisibility()
	{
		base.UpdateVisibility();
		this.13.ForEach(new Action<1997>(1997.1998.instance.2));
	}

	// Token: 0x06003746 RID: 14150 RVA: 0x0015AA66 File Offset: 0x00158C66
	internal override void Show()
	{
		this.2.FadeIn(500, (1046)0, 0);
		this.13.ForEach(new Action<1997>(1997.1998.instance.3));
	}

	// Token: 0x06003747 RID: 14151 RVA: 0x0015AA98 File Offset: 0x00158C98
	internal override void UpdateDisplay()
	{
		base.UpdateDisplay();
		if (2486.8 && !this.11)
		{
			this.11 = true;
			this.2.3.Add(new 1445(198.White, this.9, 1662.33, 1662.33 + 300));
		}
		else if (!2486.8 && this.11)
		{
			this.11 = false;
			this.2.3.Add(new 1445(this.9, 198.White, 1662.33, 1662.33 + 300));
		}
		this.13.ForEach(new Action<1997>(1997.1998.instance.4));
	}

	// Token: 0x06003748 RID: 14152 RVA: 0x0015AB54 File Offset: 0x00158D54
	protected override void AnimateComboIncrement(bool 1)
	{
		this.12 = true;
		this.2.3.RemoveAll((1445 1) => 1.16 == 1);
		1445 item = new 1445(1456.VectorScale, new 208(1f, 1.4f), new 208(1f, 1f), 1662.33, 1662.33 + 300, (1046)0)
		{
			15 = (1046)1,
			16 = 1
		};
		this.2.3.Add(item);
	}

	// Token: 0x06003749 RID: 14153 RVA: 0x0015ABF4 File Offset: 0x00158DF4
	protected override void OnDisplayedComboDecreased()
	{
		if (this.GetCombo() == 0 && this.12)
		{
			this.12 = false;
			1353 <<EMPTY_NAME>> = new 1353(this.2.GetText(), 2630.5.FontCombo, (float)2630.5.FontScoreOverlap, (1376)6, 1065.Centre, (1044)0, 208.Zero, 0.915f, true, this.10, true, (1416)7);
			<<EMPTY_NAME>>.17 = this.2.17;
			<<EMPTY_NAME>>.48 = 208.Zero;
			<<EMPTY_NAME>>.3.Add(new 1445(1456.Fade, 0.8f, 0f, 1662.33, 1662.33 + 200, (1046)0));
			<<EMPTY_NAME>>.3.Add(new 1445(1456.Scale, 1f, 4f, 1662.33, 1662.33 + 200, (1046)0));
			this.1.12(<<EMPTY_NAME>>);
		}
	}

	// Token: 0x0600374A RID: 14154 RVA: 0x0015ACDA File Offset: 0x00158EDA
	private new void 4(1997 1)
	{
		1.SetCombo(this.GetCombo());
	}

	// Token: 0x04002916 RID: 10518
	private 198 9;

	// Token: 0x04002917 RID: 10519
	private 198 10;

	// Token: 0x04002918 RID: 10520
	private bool 11;

	// Token: 0x04002919 RID: 10521
	private bool 12 = true;

	// Token: 0x0400291A RID: 10522
	private List<1997> 13 = new List<1997>();

	// Token: 0x0400291B RID: 10523
	private 2011 14;

	// Token: 0x0200075A RID: 1882
	[Serializable]
	public sealed class 1998
	{
		// Token: 0x0600374B RID: 14155 RVA: 0x0015ACE8 File Offset: 0x00158EE8
		internal void 1(1997 1)
		{
			1.Hide();
		}

		// Token: 0x0600374C RID: 14156 RVA: 0x0015ACF0 File Offset: 0x00158EF0
		internal void 2(1997 1)
		{
			1.UpdateVisibility();
		}

		// Token: 0x0600374D RID: 14157 RVA: 0x0015ACF8 File Offset: 0x00158EF8
		internal void 3(1997 1)
		{
			1.Show();
		}

		// Token: 0x0600374E RID: 14158 RVA: 0x0015AD00 File Offset: 0x00158F00
		internal void 4(1997 1)
		{
			1.UpdateDisplay();
		}

		// Token: 0x0400291C RID: 10524
		public static readonly 1997.1998 instance = new 1997.1998();

		// Token: 0x0400291D RID: 10525
		public static Action<1997> action;

		// Token: 0x0400291E RID: 10526
		public static Action<1997> action2;

		// Token: 0x0400291F RID: 10527
		public static Action<1997> action3;

		// Token: 0x04002920 RID: 10528
		public static Action<1997> action4;

		// Token: 0x04002921 RID: 10529
		public static Predicate<1445> isTaggedPredicate;
	}
}
