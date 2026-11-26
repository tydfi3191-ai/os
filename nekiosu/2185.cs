using System;

// Token: 0x020006E3 RID: 1763
public sealed class 2185 : 2129
{
	// Token: 0x06003463 RID: 13411 RVA: 0x00141F9C File Offset: 0x0014019C
	public 2185(2039 1, int 2, int 3, 1245 4) : base(1, 2, 3, 4)
	{
		this.49 = (int)Math.Max(1f, (float)this.49 * 1.65f);
		2023 5 = this.28.22;
		2023 6 = 2023.DoubleTime;
		if ((5 & 6) > 2023.None)
		{
			this.49 = Math.Max(1, (int)((float)this.49 * (float)(1.0 - 0.5 * (1939.17(this.28.22, this.28.46) - 1.0))));
		}
		2023 7 = this.28.22;
		6 = 2023.HalfTime;
		if ((7 & 6) > 2023.None)
		{
			this.49 = Math.Max(1, (int)((float)this.49 * (float)(1.0 + 2.0 * (1.0 - 1939.17(this.28.22, this.28.46)))));
		}
		this.77 = this.49;
		if (this.28.39 != null)
		{
			this.53.3.AddRange(this.52.3);
			this.53.SetText((this.49 + 1).ToString());
			this.76 = new 1433(1455.2("spinner-warning", (1416)7, null), (1376)2, 1065.Centre, (1044)1, this.8, 1436.32((float)(this.1 + 1)), false, 198.White, null);
			this.30.Add(this.76);
			this.76.9 = -5;
			this.29.Add(this.76);
			this.76.3.Add(new 1445(1456.Fade, 0f, 1f, 2 - this.28.2, 2 - (int)((double)this.28.2 * 0.6), (1046)0));
		}
		this.15 = false;
	}

	// Token: 0x06003464 RID: 13412 RVA: 0x001421B1 File Offset: 0x001403B1
	protected override 1445 CreateFadeIn()
	{
		return new 1445(1456.Fade, 0f, 1f, this.1 - 1, this.1 + 200, (1046)0);
	}

	// Token: 0x06003465 RID: 13413 RVA: 0x001421D8 File Offset: 0x001403D8
	internal override void CreateSprites()
	{
		if (1662.69.6)
		{
			this.67 -= 16;
		}
		this.70 = new 208((float)1662.70.1() / Math.Max(1f, 1662.70.6()) / 2f, (float)(this.67 + 219));
		2023 2;
		198 3;
		if (1662.78 == 1677.Play)
		{
			2023 <<EMPTY_NAME>> = this.28.22;
			2 = 2023.SpunOut;
			if ((<<EMPTY_NAME>> & 2) > 2023.None || 2486.22)
			{
				3 = 198.Gray;
				goto IL_91;
			}
		}
		3 = 198.White;
		IL_91:
		198 4 = 3;
		this.52 = new 1433(1455.2("spinner-circle", (1416)3, null), (1376)6, 1065.Centre, (1044)1, this.70, 1436.32((float)this.2), false, 4, null);
		this.30.Add(this.52);
		2023 5 = this.28.22;
		2 = 2023.Hidden;
		if ((5 & 2) <= 2023.None)
		{
			this.43 = new 1433(1455.2("spinner-approachcircle", (1416)3, null), (1376)6, 1065.Centre, (1044)1, this.70, 1436.32((float)(this.2 - 2)), false, 4, null);
			this.30.Add(this.43);
		}
		this.53 = new 1353(string.Empty, 2630.5.FontScore, (float)2630.5.FontScoreOverlap, (1376)6, 1065.Centre, (1044)1, new 208(this.70.X, this.70.Y + 80f), 1436.32((float)(this.2 - 3)), false, 4, true, (1416)7);
		this.30.Add(this.53);
		this.52.15 *= 0.8f;
	}

	// Token: 0x06003466 RID: 13414 RVA: 0x00142394 File Offset: 0x00140594
	public override 208 GetEndPosition()
	{
		2241 <<EMPTY_NAME>> = 2486.88;
		if (((<<EMPTY_NAME>> != null) ? <<EMPTY_NAME>>.39 : null) != null)
		{
			return new 208(this.70.X, this.8.Y);
		}
		return base.GetEndPosition();
	}

	// Token: 0x06003467 RID: 13415 RVA: 0x001423CB File Offset: 0x001405CB
	public override void SetEndPosition(208 1)
	{
		2241 2 = 2486.88;
		if (((2 != null) ? 2.39 : null) == null)
		{
			base.SetEndPosition(1);
		}
	}

	// Token: 0x06003468 RID: 13416 RVA: 0x00005ADD File Offset: 0x00003CDD
	protected override void CreateFeedbackSprites()
	{
	}

	// Token: 0x06003469 RID: 13417 RVA: 0x001423E8 File Offset: 0x001405E8
	protected override void InitializeTimingAndAnimations()
	{
		base.InitializeTimingAndAnimations();
		if (this.43 != null)
		{
			this.43.15 *= 0.8f;
			this.43.3.ForEach(delegate(1445 1)
			{
				1.1 *= 0.8f;
				1.5 *= 0.8f;
			});
		}
	}

	// Token: 0x0600346A RID: 13418 RVA: 0x00142449 File Offset: 0x00140649
	internal override void SetPosition(208 1, bool 2 = false)
	{
		if (this.76 != null)
		{
			this.76.17 = 1;
		}
		base.SetPosition(1, 2);
	}

	// Token: 0x0600346B RID: 13419 RVA: 0x00142468 File Offset: 0x00140668
	internal override 2149 GetOrCalculateJudgement()
	{
		this.11 = true;
		this.64 = 0.0;
		this.StopHitSounds();
		if (this.49 >= 0)
		{
			2241 <<EMPTY_NAME>> = 2486.88;
			if (((<<EMPTY_NAME>> != null) ? <<EMPTY_NAME>>.39 : null) == null || this.49 >= this.77 / 2)
			{
				2241 2 = 2486.88;
				if (((2 != null) ? 2.39 : null) != null)
				{
					return (2149)(-131072);
				}
				return (2149)(-524288);
			}
		}
		1226.24("spinner-osu", 1226.44(1226.45()), (1416)7, true);
		if (this.43 != null)
		{
			this.43.3.Clear();
		}
		this.52.3.RemoveAll(new Predicate<1445>(2185.2186.instance.1));
		this.52.3.Add(new 1445(1456.Scale, this.52.15, this.52.15 + 0.05f, 1226.16, 1226.16 + 300, (1046)1));
		this.30.ForEach(new Action<1433>(2185.2186.instance.2));
		this.2 = 1226.16;
		2241 3 = 2486.88;
		if (((3 != null) ? 3.39 : null) == null)
		{
			return (2149)2097152;
		}
		if (this.49 < 0)
		{
			return (2149)2098176;
		}
		return (2149)2097664;
	}

	// Token: 0x0600346C RID: 13420 RVA: 0x001425C8 File Offset: 0x001407C8
	internal override bool HitTest(208 1, bool 2, float 3)
	{
		return (!2 && this.IsActive()) || (this.1 - this.28.2 <= 1226.16 && this.1 + this.28.3 >= 1226.16 && !this.11);
	}

	// Token: 0x0600346D RID: 13421 RVA: 0x0014261F File Offset: 0x0014081F
	internal override void PrepareRendering()
	{
		base.PrepareRendering();
	}

	// Token: 0x0600346E RID: 13422 RVA: 0x00142628 File Offset: 0x00140828
	internal override 2149 JudgeAtPosition(208 1)
	{
		if (1226.16 < this.1 || this.72)
		{
			return (2149)0;
		}
		if (1226.16 < this.75)
		{
			return (2149)0;
		}
		if (1226.16 < this.74)
		{
			return (2149)0;
		}
		bool flag = false;
		bool flag2 = 1535.16 || 1535.18;
		bool flag3 = 1535.45 || 1535.47;
		if (2486.21 && (flag2 || flag3))
		{
			flag = true;
		}
		if (1226.16 - this.75 < 30)
		{
			2241 2 = 2486.88;
			if (((2 != null) ? 2.39 : null) == null)
			{
				goto IL_FB;
			}
		}
		if (!2486.21)
		{
			if (flag2)
			{
				if (this.73 == 1)
				{
					2241 3 = 2486.88;
					if (((3 != null) ? 3.39 : null) == null)
					{
						this.75 = 1226.16;
					}
					return (2149)0;
				}
				flag = true;
				this.73 = 1;
			}
			else if (flag3)
			{
				if (this.73 == 2)
				{
					2241 4 = 2486.88;
					if (((4 != null) ? 4.39 : null) == null)
					{
						this.75 = 1226.16;
					}
					return (2149)0;
				}
				flag = true;
				this.73 = 2;
			}
		}
		IL_FB:
		if (flag)
		{
			this.74 = 1226.16;
			this.65 += 0.03;
			this.49--;
			this.53.SetText((this.49 + 1).ToString());
			this.52.3.RemoveAll(new Predicate<1445>(2185.2186.instance.3));
			this.52.3.Add(new 1445(1456.Scale, Math.Min(0.94f, this.52.15 + 0.02f), 0.8f, 1226.16, 1226.16 + 400, (1046)1));
			this.53.3.RemoveAll(new Predicate<1445>(2185.2186.instance.4));
			this.53.3.Add(new 1445(1456.Scale, this.53.15, 1.6f - 0.6f * (float)this.49 / (float)this.77, 1226.16, 1226.16 + 60, (1046)1));
		}
		if (this.49 < 0 && !this.72)
		{
			this.2 = 1226.16;
			this.72 = true;
		}
		this.65 *= Math.Pow(0.88, 1662.10);
		if (!flag)
		{
			return (2149)0;
		}
		return (2149)1048576;
	}

	// Token: 0x0600346F RID: 13423 RVA: 0x00140995 File Offset: 0x0013EB95
	protected override int GetPreemptTime()
	{
		return (int)(600.0 / this.28.GetSliderVelocityAt(this.1) / 0.6000000238418579 * 1000.0);
	}

	// Token: 0x040026F0 RID: 9968
	private bool 72;

	// Token: 0x040026F1 RID: 9969
	private byte 73;

	// Token: 0x040026F2 RID: 9970
	private int 74;

	// Token: 0x040026F3 RID: 9971
	private int 75;

	// Token: 0x040026F4 RID: 9972
	internal 1433 76;

	// Token: 0x040026F5 RID: 9973
	internal int 77;

	// Token: 0x020006E4 RID: 1764
	[Serializable]
	public sealed class 2186
	{
		// Token: 0x06003470 RID: 13424 RVA: 0x000AAB47 File Offset: 0x000A8D47
		internal bool 1(1445 1)
		{
			return 1.14 == 1456.Scale;
		}

		// Token: 0x06003471 RID: 13425 RVA: 0x00128347 File Offset: 0x00126547
		internal void 2(1433 1)
		{
			1.16(300, (1046)0, 0);
		}

		// Token: 0x06003472 RID: 13426 RVA: 0x000AAB47 File Offset: 0x000A8D47
		internal bool 3(1445 1)
		{
			return 1.14 == 1456.Scale;
		}

		// Token: 0x06003473 RID: 13427 RVA: 0x000AAB47 File Offset: 0x000A8D47
		internal bool 4(1445 1)
		{
			return 1.14 == 1456.Scale;
		}

		// Token: 0x040026F6 RID: 9974
		public static readonly 2185.2186 instance = new 2185.2186();

		// Token: 0x040026F7 RID: 9975
		public static Action<1445> action;

		// Token: 0x040026F8 RID: 9976
		public static Predicate<1445> predicate;

		// Token: 0x040026F9 RID: 9977
		public static Action<1433> action2;

		// Token: 0x040026FA RID: 9978
		public static Predicate<1445> predicate2;

		// Token: 0x040026FB RID: 9979
		public static Predicate<1445> predicate3;
	}
}
