using System;

// Token: 0x020006DF RID: 1759
public sealed class 2181 : 2033
{
	// Token: 0x06003439 RID: 13369 RVA: 0x00140A44 File Offset: 0x0013EC44
	public 2181(2039 1, 208 2, int 3, bool 4, 1245 5, bool 6) : base(1, 2, 3, 4, 5, 0)
	{
		this.9(false);
		this.11((this.4 & ~1245.Finish & ~1245.Normal) == 1245.None);
		float circleScale = this.GetCircleScale();
		foreach (1433 7 in this.30)
		{
			7.15 *= circleScale;
		}
		if (this.10())
		{
			this.SetComboColour(new 198(235, 69, 44));
		}
		else
		{
			this.SetComboColour(new 198(67, 142, 172));
		}
		if (this.47 != null)
		{
			this.47.72 = false;
		}
		this.30.ForEach(new Action<1433>(2181.2182.instance.1));
		if (this.46 != null)
		{
			this.46.39 = Math.Min(256, this.46.39);
			this.46.38 = Math.Min(256, this.46.38);
			this.46.UpdateOriginOffset();
		}
		if (this.47 != null)
		{
			this.47.39 = Math.Min(256, this.47.39);
			this.47.38 = Math.Min(256, this.47.38);
			this.47.UpdateOriginOffset();
		}
		this.15 = 6;
	}

	// Token: 0x0600343A RID: 13370 RVA: 0x00140BE0 File Offset: 0x0013EDE0
	private new void 9(bool 1)
	{
		this.53 = 1;
	}

	// Token: 0x0600343B RID: 13371 RVA: 0x00140BE9 File Offset: 0x0013EDE9
	internal new bool 10()
	{
		return this.54;
	}

	// Token: 0x0600343C RID: 13372 RVA: 0x00140BF1 File Offset: 0x0013EDF1
	private new void 11(bool 1)
	{
		this.54 = 1;
	}

	// Token: 0x0600343D RID: 13373 RVA: 0x0000FF75 File Offset: 0x0000E175
	protected override bool ShouldShowApproachCircle()
	{
		return false;
	}

	// Token: 0x0600343E RID: 13374 RVA: 0x0000FF75 File Offset: 0x0000E175
	protected override bool ShouldShowComboNumber()
	{
		return false;
	}

	// Token: 0x0600343F RID: 13375 RVA: 0x0013FA9F File Offset: 0x0013DC9F
	public override int GetComboNumber()
	{
		return -1;
	}

	// Token: 0x06003440 RID: 13376 RVA: 0x00140BFA File Offset: 0x0013EDFA
	public override void SetComboNumber(int 1)
	{
		base.SetComboNumber(-1);
	}

	// Token: 0x06003441 RID: 13377 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void ApplyComboColourFade()
	{
	}

	// Token: 0x06003442 RID: 13378 RVA: 0x00100553 File Offset: 0x000FE753
	protected override float GetSamplePan()
	{
		return 0f;
	}

	// Token: 0x06003443 RID: 13379 RVA: 0x00140C04 File Offset: 0x0013EE04
	internal override void PlayHitSound()
	{
		1259 <<EMPTY_NAME>> = this.28.21.92((double)(this.1 + 5));
		int 2 = (this.34 != 0) ? this.34 : <<EMPTY_NAME>>.6;
		2039.33(new 1244(this.4, <<EMPTY_NAME>>.4, <<EMPTY_NAME>>.2, 2, 1254.None));
		if (this.4.2(1245.Finish))
		{
			1226.30(new 1244(this.10() ? 1245.Finish : 1245.Whistle, <<EMPTY_NAME>>.4, <<EMPTY_NAME>>.2, 2, 1254.None), this.GetSamplePan(), true);
		}
	}

	// Token: 0x06003444 RID: 13380 RVA: 0x00140C9C File Offset: 0x0013EE9C
	internal override bool HitTest(208 1, bool 2, float 3)
	{
		this.56 = this.55;
		this.55 = false;
		this.57 = false;
		this.59 = false;
		bool flag = false;
		if (1535.16 || 1535.18 || 2486.21)
		{
			if (this.10() || 2486.21)
			{
				flag = true;
				this.55 = 1535.16;
				this.57 = (1535.16 && 1535.18);
			}
			else
			{
				this.59 = true;
			}
		}
		if (1535.45 || 1535.47)
		{
			if (!this.10() || 2486.21)
			{
				flag = true;
				this.55 = 1535.45;
				this.57 = (1535.45 && 1535.47);
			}
			else
			{
				this.59 = true;
			}
		}
		if (this.59 && !this.51)
		{
			return Math.Abs(this.1 - 1226.16) <= this.28.3 && !this.11;
		}
		this.58 = (this.51 && this.12());
		bool flag2 = 1535.16 || 1535.18;
		if (this.58)
		{
			if (flag2)
			{
				if (!1535.15 || !1535.17)
				{
					this.58 = false;
				}
			}
			else if (!1535.44 || !1535.46)
			{
				this.58 = false;
			}
			this.58 &= (1226.16 - this.52 < 30);
		}
		return ((Math.Abs(this.1 - 1226.16) <= this.28.3 && !this.51) || this.58) && flag && !this.11;
	}

	// Token: 0x06003445 RID: 13381 RVA: 0x0013FA89 File Offset: 0x0013DC89
	private bool 12()
	{
		return this.4.2(1245.Finish);
	}

	// Token: 0x06003446 RID: 13382 RVA: 0x00140E56 File Offset: 0x0013F056
	internal override string GetCircleTextureName()
	{
		if (!this.12())
		{
			return "taikohitcircle";
		}
		return "taikobigcircle";
	}

	// Token: 0x06003447 RID: 13383 RVA: 0x00140E6C File Offset: 0x0013F06C
	internal override 2149 GetOrCalculateJudgement()
	{
		int num = Math.Abs(1226.16 - this.1);
		if (num < this.28.5 && !this.59)
		{
			this.14 = (2149)1024;
		}
		else if (num < this.28.4 && !this.59)
		{
			this.14 = (2149)512;
		}
		else
		{
			this.14 = (2149)(-131072);
		}
		2241 <<EMPTY_NAME>> = 2486.88;
		if (((<<EMPTY_NAME>> != null) ? <<EMPTY_NAME>>.39 : null) == null)
		{
			if (!this.51)
			{
				if (this.12() && this.14 != (2149)(-131072))
				{
					if (this.57)
					{
						this.11 = true;
						this.9(true);
						this.14 |= (2149)65536;
					}
					else
					{
						this.51 = true;
						this.60 = this.14;
						this.52 = 1226.16;
						this.14 |= (2149)4194304;
					}
				}
				else
				{
					this.11 = true;
				}
				if (this.14 > (2149)0)
				{
					this.PlayHitSound();
				}
				this.ApplyJudgementAnimation(this.14 > (2149)0);
				return this.14;
			}
			if (this.12())
			{
				this.11 = true;
				if (this.58)
				{
					this.39 = false;
					if (1226.16 - this.52 < 30 && this.56 != this.55)
					{
						this.9(true);
						return this.60 | (2149)8388608;
					}
				}
			}
			return (2149)0;
		}
		else if (!this.12() || this.14 == (2149)(-131072))
		{
			this.11 = true;
			if (!this.12() || (this.12() && !this.51))
			{
				if (this.14 > (2149)0)
				{
					this.PlayHitSound();
				}
				this.ApplyJudgementAnimation(this.14 > (2149)0);
			}
			if (this.12() && this.51)
			{
				return (2149)0;
			}
			return this.14;
		}
		else
		{
			if (this.57)
			{
				this.11 = true;
				this.9(true);
				this.PlayHitSound();
				this.ApplyJudgementAnimation(true);
				return this.14 | (2149)65536;
			}
			if (!this.51)
			{
				this.51 = true;
				this.60 = this.14;
				this.52 = 1226.16;
				if (this.14 > (2149)0)
				{
					this.PlayHitSound();
				}
				this.ApplyJudgementAnimation(this.14 > (2149)0);
				return this.14 | (2149)4194304;
			}
			if (this.58)
			{
				this.39 = false;
				if (1226.16 - this.52 < 30 && this.56 != this.55)
				{
					this.11 = true;
					this.9(true);
					this.ApplyJudgementAnimation(true);
					return this.60 | (2149)8388608;
				}
			}
			return (2149)0;
		}
	}

	// Token: 0x06003448 RID: 13384 RVA: 0x00141128 File Offset: 0x0013F328
	internal override void ApplyJudgementAnimation(bool 1)
	{
		if (1)
		{
			this.30.ForEach(new Action<1433>(2181.2182.instance.2));
			return;
		}
		base.ApplyJudgementAnimation(false);
	}

	// Token: 0x06003449 RID: 13385 RVA: 0x00141150 File Offset: 0x0013F350
	protected override int GetPreemptTime()
	{
		float num = 1f;
		2241 <<EMPTY_NAME>> = 2486.88;
		if (((<<EMPTY_NAME>> != null) ? <<EMPTY_NAME>>.39 : null) != null)
		{
			2023 2 = this.28.22;
			2023 3 = 2023.HardRock;
			if ((2 & 3) > 2023.None)
			{
				num = 1.4f;
			}
		}
		return (int)(600.0 / this.28.GetSliderVelocityAt(this.1) / 0.6000000238418579 * 1000.0 / (double)num);
	}

	// Token: 0x0600344A RID: 13386 RVA: 0x001411C7 File Offset: 0x0013F3C7
	protected override float GetCircleScale()
	{
		if (!this.12())
		{
			return 0.65f;
		}
		return 1f;
	}

	// Token: 0x040026DF RID: 9951
	private bool 51;

	// Token: 0x040026E0 RID: 9952
	private int 52;

	// Token: 0x040026E1 RID: 9953
	private bool 53;

	// Token: 0x040026E2 RID: 9954
	private bool 54;

	// Token: 0x040026E3 RID: 9955
	private bool 55;

	// Token: 0x040026E4 RID: 9956
	private bool 56;

	// Token: 0x040026E5 RID: 9957
	private bool 57;

	// Token: 0x040026E6 RID: 9958
	private bool 58;

	// Token: 0x040026E7 RID: 9959
	private bool 59;

	// Token: 0x040026E8 RID: 9960
	private 2149 60;

	// Token: 0x020006E0 RID: 1760
	[Serializable]
	public sealed class 2182
	{
		// Token: 0x0600344B RID: 13387 RVA: 0x001411DC File Offset: 0x0013F3DC
		internal void 1(1433 1)
		{
			1.41 = (1376)2;
		}

		// Token: 0x0600344C RID: 13388 RVA: 0x001411E5 File Offset: 0x0013F3E5
		internal void 2(1433 1)
		{
			1.3.Clear();
		}

		// Token: 0x040026E9 RID: 9961
		public static readonly 2181.2182 instance = new 2181.2182();

		// Token: 0x040026EA RID: 9962
		public static Action<1433> action;

		// Token: 0x040026EB RID: 9963
		public static Action<1433> action2;
	}
}
