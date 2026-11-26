using System;

// Token: 0x020006CD RID: 1741
public sealed class 2197 : 2499
{
	// Token: 0x060033A9 RID: 13225 RVA: 0x0013C98C File Offset: 0x0013AB8C
	internal 2197(1436 1) : base(1)
	{
		208 2 = new 208((float)(2630.21() ? 56 : 53), 211f);
		this.2.17 = (this.3.17 = (this.2.7 = 2));
		this.2.48 = (this.3.48 = 208.Zero);
		if (2630.21())
		{
			this.2.96 = true;
		}
		this.2.15 = (this.3.15 = 0.8f);
		this.2.49 = 1065.BottomCentre;
	}

	// Token: 0x060033AA RID: 13226 RVA: 0x0013CA3D File Offset: 0x0013AC3D
	protected override string FormatCombo()
	{
		return this.4.ToString();
	}

	// Token: 0x060033AB RID: 13227 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void Show()
	{
	}

	// Token: 0x060033AC RID: 13228 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void Hide()
	{
	}

	// Token: 0x060033AD RID: 13229 RVA: 0x0013CA4C File Offset: 0x0013AC4C
	protected override void AnimateComboIncrement(bool 1)
	{
		this.2.3.RemoveAll(new Predicate<1445>(2197.2198.instance.1));
		this.2.3.Add(new 1445(1456.VectorScale, new 208(1f, 1.4f), new 208(1f, 1f), 1662.33, 1662.33 + 300, (1046)0)
		{
			15 = (1046)1,
			16 = 1
		});
	}

	// Token: 0x020006CE RID: 1742
	[Serializable]
	public sealed class 2198
	{
		// Token: 0x060033AE RID: 13230 RVA: 0x000C2741 File Offset: 0x000C0941
		internal bool 1(1445 1)
		{
			return 1.16 == 1;
		}

		// Token: 0x04002699 RID: 9881
		public static readonly 2197.2198 instance = new 2197.2198();

		// Token: 0x0400269A RID: 9882
		public static Predicate<1445> predicate;
	}
}
