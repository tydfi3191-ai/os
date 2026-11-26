using System;
using System.Collections.Generic;

// Token: 0x020006DC RID: 1756
public sealed class 2178 : 2123
{
	// Token: 0x0600341A RID: 13338 RVA: 0x0013FA34 File Offset: 0x0013DC34
	internal 2178(2039 1, 208 2, int 3, bool 4, 1245 5, 2064 6, int 7, double 8, List<208> 9, List<1245> 10, bool 11) : base(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 0)
	{
		base.SetComboColour(new 198(252, 184, 6));
		this.15 = 11;
	}

	// Token: 0x0600341B RID: 13339 RVA: 0x0013FA89 File Offset: 0x0013DC89
	private new bool 50()
	{
		return this.4.2(1245.Finish);
	}

	// Token: 0x0600341C RID: 13340 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool IsHeadJudged()
	{
		return true;
	}

	// Token: 0x0600341D RID: 13341 RVA: 0x0013FA97 File Offset: 0x0013DC97
	public override 208 GetEndPosition()
	{
		return this.8;
	}

	// Token: 0x0600341E RID: 13342 RVA: 0x00005ADD File Offset: 0x00003CDD
	public override void SetEndPosition(208 1)
	{
	}

	// Token: 0x0600341F RID: 13343 RVA: 0x0013FA9F File Offset: 0x0013DC9F
	public override int GetComboNumber()
	{
		return -1;
	}

	// Token: 0x06003420 RID: 13344 RVA: 0x0013FAA2 File Offset: 0x0013DCA2
	public override void SetComboNumber(int 1)
	{
		base.SetComboNumber(-1);
	}

	// Token: 0x06003421 RID: 13345 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void GenerateSliderEvents()
	{
	}

	// Token: 0x06003422 RID: 13346 RVA: 0x0013FAAC File Offset: 0x0013DCAC
	internal override List<1433> CreateLightingSprites()
	{
		List<1433> <<EMPTY_NAME>> = this.42;
		if (<<EMPTY_NAME>> != null)
		{
			<<EMPTY_NAME>>.ForEach(new Action<1433>(2178.2180.instance.1));
		}
		List<1433> list = new List<1433>();
		list.Add(this.58.30[0].Clone());
		list.Add(this.99.Clone());
		list.Add(this.98.Clone());
		List<1433> result = list;
		this.42 = list;
		return result;
	}

	// Token: 0x06003423 RID: 13347 RVA: 0x0013FB28 File Offset: 0x0013DD28
	public new double 51()
	{
		if (this.101 == 0.0)
		{
			2241 <<EMPTY_NAME>> = 2486.88;
			if (((<<EMPTY_NAME>> != null) ? <<EMPTY_NAME>>.39 : null) == null)
			{
				double num;
				for (num = ((this.28.21.32 < 8) ? (1226.88((double)this.1, true) / 8.0) : ((this.28.21.6 != 3.0 && this.28.21.6 != 6.0 && this.28.21.6 != 1.5) ? (1226.88((double)this.1, false) / 8.0) : (1226.88((double)this.1, false) / 6.0))); num < 60.0; num *= 2.0)
				{
				}
				while (num > 120.0)
				{
					num /= 2.0;
				}
				this.101 = num;
			}
			else if (this.28.21.6 == 3.0)
			{
				this.101 = 1226.88((double)this.1, false) / 3.0;
			}
			else
			{
				this.101 = 1226.88((double)this.1, false) / 4.0;
			}
		}
		return this.101;
	}

	// Token: 0x06003424 RID: 13348 RVA: 0x0013FCAA File Offset: 0x0013DEAA
	internal override bool HitTest(208 1, bool 2, float 3)
	{
		return this._000F_2007_2000_2004_200A_2000_2007_200B_2005_2005_2003_200A_200B_2008_2002_200B_2007_2009_2009_2000() <= 1226.16 && this._0003_2002_200A_2007_2007_2004_200A_2006_200A_2005_2005_2007_2009_2008_2002_2001_2005_2003_2001_200B() >= 1226.16 && !this.11;
	}

	// Token: 0x06003425 RID: 13349 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal override 2149 JudgeHead()
	{
		return (2149)0;
	}

	// Token: 0x06003426 RID: 13350 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void SetComboColour(198 1)
	{
	}

	// Token: 0x06003427 RID: 13351 RVA: 0x0013FCD4 File Offset: 0x0013DED4
	internal override 2149 GetOrCalculateJudgement()
	{
		this.11 = true;
		2241 <<EMPTY_NAME>> = 2486.88;
		if (((<<EMPTY_NAME>> != null) ? <<EMPTY_NAME>>.39 : null) == null)
		{
			return (2149)0;
		}
		if (this.102 == null)
		{
			this.102 = new double?(Math.Min(0.3, 0.1 + 0.03333333333333333 * (double)this.28.16(1928.OverallDifficulty, this.28.21.4)));
		}
		double num = (double)this.94;
		double? num2 = (double)this.105.Count * this.102;
		if (num >= num2.GetValueOrDefault() & num2 != null)
		{
			2149 2 = (2149)1024;
			if (base.HasFinish())
			{
				2 |= (2149)65536;
			}
			return 2;
		}
		if (this.94 >= 1)
		{
			2149 3 = (2149)512;
			if (base.HasFinish())
			{
				3 |= (2149)65536;
			}
			return 3;
		}
		return (2149)(-131072);
	}

	// Token: 0x06003428 RID: 13352 RVA: 0x0013FDF1 File Offset: 0x0013DFF1
	internal override int _0003_2002_200A_2007_2007_2004_200A_2006_200A_2005_2005_2007_2009_2008_2002_2001_2005_2003_2001_200B()
	{
		if (!this.100)
		{
			return base._0003_2002_200A_2007_2007_2004_200A_2006_200A_2005_2005_2007_2009_2008_2002_2001_2005_2003_2001_200B();
		}
		return base._0003_2002_200A_2007_2007_2004_200A_2006_200A_2005_2005_2007_2009_2008_2002_2001_2005_2003_2001_200B() + (int)this.51();
	}

	// Token: 0x06003429 RID: 13353 RVA: 0x0013FE10 File Offset: 0x0013E010
	internal override int _000F_2007_2000_2004_200A_2000_2007_200B_2005_2005_2003_200A_200B_2008_2002_200B_2007_2009_2009_2000()
	{
		return base._000F_2007_2000_2004_200A_2000_2007_200B_2005_2005_2003_200A_200B_2008_2002_200B_2007_2009_2009_2000() - (int)this.51();
	}

	// Token: 0x0600342A RID: 13354 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void PrepareRendering()
	{
	}

	// Token: 0x0600342B RID: 13355 RVA: 0x0013FE20 File Offset: 0x0013E020
	internal override void Update()
	{
		if (1662.23)
		{
			if (this.97 < this.96)
			{
				this.97 += 0.4f;
			}
			else
			{
				this.97 = this.96;
			}
			this.95 = Math.Max(0f, 1f - this.97 / 10f);
			198 <<EMPTY_NAME>> = new 198(252, (byte)(184f * this.95), (byte)(6f * this.95));
			if (this.7 != <<EMPTY_NAME>>)
			{
				this.58.SetComboColour(this.7);
				this.7 = <<EMPTY_NAME>>;
				this.99.6 = <<EMPTY_NAME>>;
				this.98.6 = <<EMPTY_NAME>>;
			}
			this.96 = Math.Max(0f, this.96 - 0.2f);
		}
		base.Update();
		this.45.45(false);
	}

	// Token: 0x0600342C RID: 13356 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void Shake()
	{
	}

	// Token: 0x0600342D RID: 13357 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void RebuildPathAndTiming(bool 1 = true)
	{
	}

	// Token: 0x0600342E RID: 13358 RVA: 0x0013FF1C File Offset: 0x0013E11C
	protected override void CreateHeadCircle()
	{
		this.58 = (2033)this.28.33.CreateCircle(this.8, this.1, false, this.4, 0, 1254.None, 1254.None, 1253.Default, 0, string.Empty);
		this.58.SetComboColour(this.7);
	}

	// Token: 0x0600342F RID: 13359 RVA: 0x0013FF74 File Offset: 0x0013E174
	internal void 52(bool 1, double 2)
	{
		if (!1 && this.99 != null)
		{
			return;
		}
		List<2034> 3 = this.28.34;
		int num = 3.IndexOf(this);
		if (num < 3.Count - 1 && 3[num + 1]._000F_2007_2000_2004_200A_2000_2007_200B_2005_2005_2003_200A_200B_2008_2002_200B_2007_2009_2009_2000() - (this.2 + (int)this.51()) <= (int)this.51())
		{
			this.100 = false;
		}
		float num2 = (!this.4.2(1245.Finish)) ? 0.65f : 1f;
		this.6 *= (double)this.5;
		double num3 = this.28.6 * this.28.21.6;
		double num4 = this.28.21.90((double)this.1, true);
		this.2 = this.1 + (int)(this.6 / num3 * num4);
		this.6 *= 2;
		this.99 = new 1433(1455.2("taiko-roll-middle", (1416)7, null), (1376)2, 1065.TopLeft, (1044)1, new 208(this.8.X, this.8.Y - this.28.1 * num2), 1436.32((float)(this.2 + 10)), false, new 198(252, 184, 6), null);
		this.99.20 = new 208((float)this.6 * 1662.70.3() / this.28.23 * (1f / num2), 1f);
		this.99.3.Add(new 1445(1456.Fade, 0f, 1f, this.1 - this.28.2, this.1, (1046)0));
		this.99.3.Add(new 1445(1456.Fade, 1f, 0f, this.2, this.2 + this.28.28, (1046)0));
		this.50.12(this.99);
		this.30.Add(this.99);
		this.29.Add(this.99);
		this.98 = new 1433(1455.2("taiko-roll-end", (1416)7, null), (1376)2, 1065.TopLeft, (1044)1, new 208(this.8.X, this.8.Y - this.28.1 * num2), 1436.32((float)(this.2 + 8)), false, new 198(252, 184, 6), null);
		this.98.48 = new 208((float)(0.0 - this.6) * 1662.70.3() / this.28.23 * (1f / num2), 0f);
		this.98.3.Add(new 1445(1456.Fade, 0f, 1f, this.1 - this.28.2, this.1, (1046)0));
		this.98.3.Add(new 1445(1456.Fade, 1f, 0f, this.2, this.2 + this.28.28, (1046)0));
		this.50.12(this.98);
		this.30.Add(this.98);
		this.29.Add(this.98);
		this.45.3.Add(new 1445(this.58.8, this.58.8, this.1 - 500, this.2, (1046)0));
		this.49.3.Add(new 1445(this.58.8, this.58.8, this.1, this.2, (1046)0));
		this.93 = new 1353(string.Empty, 2630.5.FontScore, (float)2630.5.FontScoreOverlap, (1376)2, 1065.Centre, (1044)1, 2184.61, 0.9f, false, 198.White, true, (1416)7);
		this.93.15 = 0.8f;
		this.93.3.Add(new 1445(1456.Fade, 0f, 1f, this.1, this.1, (1046)0));
		this.93.3.Add(new 1445(1456.Fade, 0.6f, 0f, this.2, this.2 + 300, (1046)0));
		this.50.12(this.93);
		int num5 = 0;
		for (double num6 = (double)this.1; num6 < (double)this._0003_2002_200A_2007_2007_2004_200A_2006_200A_2005_2005_2007_2009_2008_2002_2001_2005_2003_2001_200B(); num6 += this.51())
		{
			if (num6 == (double)this.1)
			{
				this.105.Add(new 2178.2179((int)num6, null));
				num5++;
			}
			else
			{
				bool flag = (this.28.21.6 == 3.0 || this.28.21.6 == 6.0 || this.28.21.6 == 1.5) ? (num5 % 3 == 0) : ((num5 & 3) == 0);
				1433 4 = new 1433(1455.2("sliderscorepoint", (1416)7, null), (1376)2, 1065.Centre, (1044)1, new 208(this.8.X, this.8.Y), 1436.32((float)(this.1 + 1)), false, flag ? 198.Yellow : 198.White, this);
				if (!flag)
				{
					4.15 *= 0.8f;
				}
				1433 5 = 4;
				5.48.X = 5.48.X - (float)(this.6 * (double)((float)(num6 - (double)this.1)) / (double)base.GetDuration()) * 1662.70.3() / this.28.23 / 4.15 * (1f / num2);
				4.3.Add(new 1445(1456.Fade, 0f, 1f, this.1 - this.28.2, this.1, (1046)0));
				4.3.Add(new 1445(1456.Fade, 1f, 0f, this.2, this.2 + this.28.28, (1046)0));
				this.105.Add(new 2178.2179((int)num6, 4));
				this.50.12(4);
				this.30.Add(4);
				this.29.Add(4);
				num5++;
			}
		}
		if (num2 != 1f)
		{
			foreach (1433 6 in this.30)
			{
				6.15 *= num2;
			}
		}
		for (int i = 0; i < this.58.30.Count; i++)
		{
			1433 7 = this.58.30[i];
			foreach (1445 8 in 7.3)
			{
				if (8.14 == 1456.Fade && 8.1 == 1f)
				{
					8.9 = this.2;
					8.10 = this.2;
				}
			}
			this.30.Add(7);
			this.29.Add(7);
			this.50.12(7);
		}
	}

	// Token: 0x06003430 RID: 13360 RVA: 0x0014076C File Offset: 0x0013E96C
	internal override 2149 JudgeAtPosition(208 1)
	{
		if (this.11)
		{
			return (2149)0;
		}
		bool flag = 1555.14;
		if (!flag)
		{
			return (2149)0;
		}
		2241 2 = 2486.88;
		if (((2 != null) ? 2.39 : null) == null)
		{
			double num = this.51();
			if (!2486.21)
			{
				if (this.103 == 0.0)
				{
					this.103 = (double)this.1;
				}
				else if (Math.Abs((double)1226.16 - (this.103 + num)) < num / 2.0)
				{
					this.103 += num;
				}
				else if (Math.Abs((double)1226.16 - (this.103 + num * 2.0)) < num)
				{
					this.103 += num * 2.0;
				}
				else if (Math.Abs((double)1226.16 - (this.103 + num * 4.0)) < num)
				{
					this.103 += num * 4.0;
				}
				else
				{
					flag = false;
				}
			}
			this.104 = flag;
			if (!flag)
			{
				double num2;
				for (num2 = (double)this.1; num2 < (double)1226.16; num2 += num * 2.0)
				{
				}
				this.103 = (double)((int)num2);
				return (2149)0;
			}
		}
		else
		{
			this.104 = flag;
		}
		2178.2179 3 = this.105.Find(new Predicate<2178.2179>(this.53));
		if (3 == null)
		{
			return (2149)0;
		}
		3.Hit();
		this.94++;
		this.93.SetText(this.94.ToString());
		if (1226.16 < this.2)
		{
			this.93.3.RemoveAll(new Predicate<1445>(2178.2180.instance.2));
			1445 4 = new 1445(1456.Fade, 1f, 0.6f, 1226.16, 1226.16 + 300, (1046)0);
			4.16 = 1;
			this.93.3.Add(4);
		}
		this.96 += 2f;
		if (this.50())
		{
			return (2149)98304;
		}
		return (2149)32768;
	}

	// Token: 0x06003431 RID: 13361 RVA: 0x00140995 File Offset: 0x0013EB95
	protected override int GetPreemptTime()
	{
		return (int)(600.0 / this.28.GetSliderVelocityAt(this.1) / 0.6000000238418579 * 1000.0);
	}

	// Token: 0x06003432 RID: 13362 RVA: 0x001409C7 File Offset: 0x0013EBC7
	private new bool 53(2178.2179 1)
	{
		return (double)Math.Abs(1.1 - 1226.16) < this.51() / 2.0 && !1.3;
	}

	// Token: 0x040026CC RID: 9932
	private 1353 93;

	// Token: 0x040026CD RID: 9933
	private int 94;

	// Token: 0x040026CE RID: 9934
	private float 95;

	// Token: 0x040026CF RID: 9935
	private float 96;

	// Token: 0x040026D0 RID: 9936
	private float 97;

	// Token: 0x040026D1 RID: 9937
	private 1433 98;

	// Token: 0x040026D2 RID: 9938
	private 1433 99;

	// Token: 0x040026D3 RID: 9939
	private bool 100 = true;

	// Token: 0x040026D4 RID: 9940
	private double 101;

	// Token: 0x040026D5 RID: 9941
	private double? 102;

	// Token: 0x040026D6 RID: 9942
	private double 103;

	// Token: 0x040026D7 RID: 9943
	internal bool 104;

	// Token: 0x040026D8 RID: 9944
	internal readonly List<2178.2179> 105 = new List<2178.2179>();

	// Token: 0x020006DD RID: 1757
	[Serializable]
	public sealed class 2180
	{
		// Token: 0x06003433 RID: 13363 RVA: 0x001409F8 File Offset: 0x0013EBF8
		internal void 1(1433 1)
		{
			1.13();
		}

		// Token: 0x06003434 RID: 13364 RVA: 0x000C2741 File Offset: 0x000C0941
		internal bool 2(1445 1)
		{
			return 1.16 == 1;
		}

		// Token: 0x040026D9 RID: 9945
		public static readonly 2178.2180 instance = new 2178.2180();

		// Token: 0x040026DA RID: 9946
		public static Action<1433> action;

		// Token: 0x040026DB RID: 9947
		public static Predicate<1445> predicate;
	}

	// Token: 0x020006DE RID: 1758
	public sealed class 2179
	{
		// Token: 0x06003437 RID: 13367 RVA: 0x00140A0C File Offset: 0x0013EC0C
		internal 2179(int 1, 1433 2)
		{
			this.1 = 1;
			this.2 = 2;
		}

		// Token: 0x06003438 RID: 13368 RVA: 0x00140A22 File Offset: 0x0013EC22
		internal void Hit()
		{
			this.3 = true;
			if (this.2 != null)
			{
				this.2.16(40, (1046)0, 0);
			}
		}

		// Token: 0x040026DC RID: 9948
		internal readonly int 1;

		// Token: 0x040026DD RID: 9949
		internal readonly 1433 2;

		// Token: 0x040026DE RID: 9950
		internal bool 3;
	}
}
