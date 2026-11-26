using System;

// Token: 0x02000825 RID: 2085
[276]
public sealed class 2066 : 2033
{
	// Token: 0x06003C96 RID: 15510 RVA: 0x00180378 File Offset: 0x0017E578
	internal 2066(2039 1, 208 2, int 3, int 4, bool 5, bool 6, float 7, 2123 8) : base(1, 2, 3, false, false, false, false, 0)
	{
		this.30.Remove(this.45);
		this.30.Remove(this.48);
		this.51 = 5;
		if (6)
		{
			int num = 5 ? (8.1 - 1) : (3 - (int)(1000.0 * 8.6 / 8.87) - 1);
			this.48 = new 1433(1455.2("reversearrow", (1416)7, null), (1376)1, 1065.Centre, (1044)1, this.8, 1436.32((float)num), false, 198.White, null);
			this.48.3.Add(new 1445(1456.Fade, 0f, 1f, 4, 4 + 150, (1046)0));
			this.30.Add(this.48);
			this.29.Add(this.48);
		}
		2023 9 = this.28.22;
		bool flag = (9 & 2023.Hidden) > 2023.None;
		int num2 = 8.1 - (int)((double)this.28.HiddenPreemptTime * 0.6);
		int 10 = 8.1 - (int)((double)this.28.HiddenPreemptTime * 0.3);
		bool flag2 = flag && !this.28.IsInfiniteApproach;
		1445 11 = this.46.3.Find(new Predicate<1445>(2066.2067.Instance.1));
		if (11 != null)
		{
			11.9 = 4;
			11.10 = (flag2 ? num2 : Math.Min(3, 4 + 2039.13));
		}
		11 = this.47.3.Find(new Predicate<1445>(2066.2067.Instance.2));
		if (11 != null)
		{
			11.9 = 4;
			11.10 = (flag2 ? num2 : Math.Min(3, 4 + 2039.13));
		}
		if (1929.3(9))
		{
			if (5)
			{
				this.46.3.Add(new 1445(1456.Fade, 1f, 0f, num2, 10, (1046)0));
				this.47.3.Add(new 1445(1456.Fade, 1f, 0f, num2, 10, (1046)0));
			}
			else
			{
				this.30.Remove(this.46);
				this.30.Remove(this.47);
			}
		}
		this.ResetJudgementState();
		if (!6)
		{
			return;
		}
		int num3 = 4;
		if (1.2 >= 86400000 && 3 - 4 > 10000)
		{
			num3 = 4 + (3 - 10000 - 4) / 300 * 300;
		}
		if (2630.21())
		{
			this.48.14 = 7;
			for (int i = num3; i < 3; i += 300)
			{
				int num4 = Math.Min(300, 3 - i);
				this.48.3.Add(new 1445(1456.Scale, 1.3f, 1f, i, i + num4, (1046)1));
			}
			return;
		}
		for (int j = num3; j < 3; j += 300)
		{
			int num5 = Math.Min(300, 3 - j);
			this.48.3.Add(new 1445(1456.Scale, 1.3f, 1f, j, j + num5, (1046)0));
			this.48.3.Add(new 1445(1456.Rotation, 7 + 0.09817477f, 7 - 0.09817477f, j, j + num5, (1046)0));
		}
	}

	// Token: 0x06003C97 RID: 15511 RVA: 0x001806FD File Offset: 0x0017E8FD
	internal override string GetCircleTextureName()
	{
		return "sliderendcircle";
	}

	// Token: 0x06003C98 RID: 15512 RVA: 0x00180704 File Offset: 0x0017E904
	internal override void ApplyComboColourFade()
	{
		if (this.51)
		{
			base.ApplyComboColourFade();
		}
	}

	// Token: 0x06003C99 RID: 15513 RVA: 0x00180714 File Offset: 0x0017E914
	internal override void SetComboColour(198 1)
	{
		if (this.48.GetTexture() != null && this.48.GetTexture().6 == (1416)1 && (int)(1.R + 1.G + 1.B) > 600)
		{
			this.48.6 = 198.Black;
			this.29.Remove(this.48);
		}
		base.SetComboColour(1);
	}

	// Token: 0x06003C9A RID: 15514 RVA: 0x00180788 File Offset: 0x0017E988
	internal override void ResetJudgementState()
	{
		if (1929.3(this.28.22))
		{
			return;
		}
		base.ResetJudgementState();
		for (int i = 0; i < this.30.Count; i++)
		{
			1433 <<EMPTY_NAME>> = this.30[i];
			if (<<EMPTY_NAME>>.1 != (1044)0)
			{
				<<EMPTY_NAME>>.3.RemoveAll(new Predicate<1445>(2066.2067.Instance.3));
				<<EMPTY_NAME>>.3.Add(new 1445(1456.Fade, 1f, 0f, this.1, this.1, (1046)0)
				{
					16 = 148
				});
			}
		}
	}

	// Token: 0x06003C9B RID: 15515 RVA: 0x00180830 File Offset: 0x0017EA30
	internal override void ApplyJudgementAnimation(bool 1)
	{
		bool flag = 1929.3(this.28.22);
		if (!1 || flag || (1662.78 == 1677.Edit && !1304.83))
		{
			return;
		}
		foreach (1433 2 in this.30)
		{
			if (2 != this.49)
			{
				2.3.RemoveAll(new Predicate<1445>(2066.2067.Instance.4));
				2.3.Add(new 1445(1456.Fade, 1f, 0f, this.1, this.1 + 2039.14, (1046)0)
				{
					16 = 148
				});
				2.3.Add(new 1445(1456.Scale, 1f, 1.4f, this.1, this.1 + 2039.14, (1046)1)
				{
					16 = 148
				});
			}
		}
	}

	// Token: 0x04002CC5 RID: 11461
	private bool 51;

	// Token: 0x02000826 RID: 2086
	[276]
	[Serializable]
	public sealed class 2067
	{
		// Token: 0x06003C9C RID: 15516 RVA: 0x00180950 File Offset: 0x0017EB50
		internal bool 1(1445 1)
		{
			return 1.14 == 1456.Fade && 1.1 == 0f;
		}

		// Token: 0x06003C9D RID: 15517 RVA: 0x00180950 File Offset: 0x0017EB50
		internal bool 2(1445 1)
		{
			return 1.14 == 1456.Fade && 1.1 == 0f;
		}

		// Token: 0x06003C9E RID: 15518 RVA: 0x00085465 File Offset: 0x00083665
		internal bool 3(1445 1)
		{
			return 1.16 == 148;
		}

		// Token: 0x06003C9F RID: 15519 RVA: 0x00085465 File Offset: 0x00083665
		internal bool 4(1445 1)
		{
			return 1.16 == 148;
		}

		// Token: 0x04002CC6 RID: 11462
		public static readonly 2066.2067 Instance = new 2066.2067();

		// Token: 0x04002CC7 RID: 11463
		public static Predicate<1445> predicate;

		// Token: 0x04002CC8 RID: 11464
		public static Predicate<1445> predicate2;

		// Token: 0x04002CC9 RID: 11465
		public static Predicate<1445> predicate3;

		// Token: 0x04002CCA RID: 11466
		public static Predicate<1445> predicate4;
	}
}
