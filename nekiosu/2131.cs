using System;

// Token: 0x0200071E RID: 1822
[276]
public sealed class 2131 : 2033
{
	// Token: 0x060035EA RID: 13802 RVA: 0x00150C5B File Offset: 0x0014EE5B
	internal 2131(2039 1, 208 2, int 3, bool 4, 1245 5, int 6) : base(1, 2, 3, 4, 5, 6)
	{
		this.48.9(true);
	}

	// Token: 0x060035EB RID: 13803 RVA: 0x00150C78 File Offset: 0x0014EE78
	internal override string GetCircleTextureName()
	{
		return "target";
	}

	// Token: 0x060035EC RID: 13804 RVA: 0x0000FF75 File Offset: 0x0000E175
	protected override bool ShouldShowApproachCircle()
	{
		return false;
	}

	// Token: 0x060035ED RID: 13805 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void Shake()
	{
	}

	// Token: 0x060035EE RID: 13806 RVA: 0x00150C80 File Offset: 0x0014EE80
	internal override 2149 GetOrCalculateJudgement()
	{
		208 <<EMPTY_NAME>> = 1535.1() ? 1535.34 : 1662.69.14(1535.6);
		this.51 = <<EMPTY_NAME>> - this.8;
		this.52 = 1f - 208.Distance(<<EMPTY_NAME>>, this.8) / this.28.1;
		return base.GetOrCalculateJudgement();
	}

	// Token: 0x060035EF RID: 13807 RVA: 0x00150CE7 File Offset: 0x0014EEE7
	internal override void ApplyJudgementAnimation(bool 1)
	{
		if (!1)
		{
			base.ApplyJudgementAnimation(1);
			return;
		}
		this.30.ForEach(new Action<1433>(2131.2132.instance.1));
	}

	// Token: 0x060035F0 RID: 13808 RVA: 0x00150D10 File Offset: 0x0014EF10
	internal override void ApplyComboColourFade()
	{
		198 <<EMPTY_NAME>> = new 198((byte)Math.Max(0f, (float)this.7.R * 0.45f), (byte)Math.Max(0f, (float)this.7.G * 0.45f), (byte)Math.Max(0f, (float)this.7.B * 0.45f), byte.MaxValue);
		198 2 = new 198(195, 195, 195, byte.MaxValue);
		198 white = 198.White;
		foreach (1433 3 in this.29)
		{
			int num = (int)this.28.21.90((double)this.1, false);
			3.3.RemoveAll(new Predicate<1445>(2131.2132.instance.3));
			1445 4 = new 1445((3.9 == 0) ? 2 : <<EMPTY_NAME>>, (3.9 == 0) ? white : this.7, this.1 - num - 96, this.1 - num);
			if (4 != null)
			{
				4.16 = 147;
			}
			3.3.Add(4);
		}
	}

	// Token: 0x04002806 RID: 10246
	internal 208 51;

	// Token: 0x04002807 RID: 10247
	internal float 52;

	// Token: 0x0200071F RID: 1823
	[276]
	[Serializable]
	public sealed class 2132
	{
		// Token: 0x060035F1 RID: 13809 RVA: 0x00150E78 File Offset: 0x0014F078
		internal void 1(1433 1)
		{
			1.3.RemoveAll(new Predicate<1445>(2131.2132.instance.2));
		}

		// Token: 0x060035F2 RID: 13810 RVA: 0x00085465 File Offset: 0x00083665
		internal bool 2(1445 1)
		{
			return 1.16 == 148;
		}

		// Token: 0x060035F3 RID: 13811 RVA: 0x00150E96 File Offset: 0x0014F096
		internal bool 3(1445 1)
		{
			return 1.14 == 1456.Colour && 1.16 == 147;
		}

		// Token: 0x04002808 RID: 10248
		public static readonly 2131.2132 instance = new 2131.2132();

		// Token: 0x04002809 RID: 10249
		public static Predicate<1445> predicate;

		// Token: 0x0400280A RID: 10250
		public static Action<1433> action;

		// Token: 0x0400280B RID: 10251
		public static Predicate<1445> predicate2;
	}
}
