using System;

// Token: 0x0200071C RID: 1820
[276]
public class 2129 : 2070
{
	// Token: 0x060035CD RID: 13773 RVA: 0x0014F1F8 File Offset: 0x0014D3F8
	internal 2129(2039 1, int 2, int 3, 1245 4) : base(1, 2, 3, 4)
	{
		if (1.39 != null)
		{
			this.CreateSprites();
		}
		this.InitializeTimingAndAnimations();
		if (1.39 != null)
		{
			this.CreateFeedbackSprites();
		}
	}

	// Token: 0x060035CE RID: 13774 RVA: 0x0014F249 File Offset: 0x0014D449
	internal new int 9()
	{
		return (int)this.69;
	}

	// Token: 0x060035CF RID: 13775 RVA: 0x0001702D File Offset: 0x0001522D
	public override int GetComboNumber()
	{
		return 1;
	}

	// Token: 0x060035D0 RID: 13776 RVA: 0x00005ADD File Offset: 0x00003CDD
	public override void SetComboNumber(int 1)
	{
	}

	// Token: 0x060035D1 RID: 13777 RVA: 0x0013FA97 File Offset: 0x0013DC97
	public override 208 GetEndPosition()
	{
		return this.8;
	}

	// Token: 0x060035D2 RID: 13778 RVA: 0x0014F252 File Offset: 0x0014D452
	public override void SetEndPosition(208 1)
	{
		this.8 = 1;
	}

	// Token: 0x060035D3 RID: 13779 RVA: 0x0014F25B File Offset: 0x0014D45B
	internal override bool IsActive()
	{
		return 1226.16 >= this.1 - 2039.13 && 1226.16 <= this.2;
	}

	// Token: 0x060035D4 RID: 13780 RVA: 0x0014F282 File Offset: 0x0014D482
	protected virtual 1445 CreateFadeIn()
	{
		return new 1445(1456.Fade, 0f, 1f, this.1 - 2039.13, this.1, (1046)0);
	}

	// Token: 0x060035D5 RID: 13781 RVA: 0x0014F2A8 File Offset: 0x0014D4A8
	protected virtual void CreateFeedbackSprites()
	{
		if (1662.78 == 1677.Play)
		{
			this.61 = new 1433(1455.2("spinner-spin", (1416)7, null), (1376)6, 1065.Centre, (1044)1, new 208(this.70.X, (float)(this.67 + 335)), 1436.30((float)(this.1 + 6)), false, 198.White, null);
			this.61.3.Add(new 1445(1456.Fade, 0f, 1f, this.1 - 2039.13 / 2, this.1, (1046)0));
			this.61.3.Add(new 1445(1456.Fade, 1f, 0f, this.2 - Math.Min(400, this.2 - this.1), this.2, (1046)0));
			this.30.Add(this.61);
			this.59 = new 1433(1455.2("spinner-clear", (1416)7, null), (1376)6, 1065.Centre, (1044)1, new 208(this.70.X, (float)(this.67 + 115)), 1436.30((float)(this.1 + 7)), false, 198.White, null);
			this.59.3.Add(new 1445(1456.Fade, 0f, 0f, this.1, this.2, (1046)0));
			this.30.Add(this.59);
		}
		if (this.44)
		{
			this.57 = new 1433(1455.2("spinner-glow", (1416)7, null), (1376)6, 1065.Centre, (1044)1, new 208(this.70.X, (float)(this.67 + 219)), 1436.30((float)(this.1 - 1)), false, 198.TransparentWhite, null);
			this.57.28 = true;
			this.57.3.Add(new 1445(1456.Fade, 0f, 0f, this.1, this.2, (1046)0));
			this.30.Add(this.57);
			this.55.15 = (this.56.15 = (this.52.15 = (this.54.15 = (this.57.15 = 0.8f))));
		}
	}

	// Token: 0x060035D6 RID: 13782 RVA: 0x0014F508 File Offset: 0x0014D708
	internal virtual void CreateSprites()
	{
		this.44 = (2630.21() && (2630.13 || 1455.2("spinner-circle", (1416)4, null) == null) && 1455.2("spinner-background", (1416)2, null) == null);
		if (1662.69.6)
		{
			this.67 -= 16;
		}
		this.70 = new 208((float)1662.70.1() / Math.Max(1f, 1662.70.6()) / 2f, (float)(this.67 + 219));
		198 3;
		if (1662.78 == 1677.Play && 2486.88 != null)
		{
			2023 <<EMPTY_NAME>> = this.28.22;
			2023 2 = 2023.SpunOut;
			if ((<<EMPTY_NAME>> & 2) > 2023.None || 2486.22)
			{
				3 = 198.Gray;
				goto IL_CC;
			}
		}
		3 = 198.White;
		IL_CC:
		198 4 = 3;
		if (1662.78 == 1677.Play && 2630.5.SpinnerFadePlayfield)
		{
			this.30.Add(new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)1, new 208(0f, 0f), 1436.30((float)(this.1 - 1)), false, 198.Black, null)
			{
				15 = 1.6f,
				20 = new 208(640f, (float)this.67)
			});
			if (1662.69.6)
			{
				this.30.Add(new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)1, new 208(0f, 461f), 1436.30((float)(this.1 - 1)), false, 198.Black, null)
				{
					15 = 1.6f,
					20 = new 208(640f, 19f)
				});
			}
		}
		if (this.44)
		{
			this.52 = new 1433(1455.2("spinner-top", (1416)7, null), (1376)6, 1065.Centre, (1044)1, this.70, 1436.30((float)(this.1 + 1)), false, 4, null);
			this.30.Add(this.52);
			this.54 = new 1433(1455.2("spinner-bottom", (1416)7, null), (1376)6, 1065.Centre, (1044)1, this.70, 1436.30((float)this.1), false, 4, null);
			this.30.Add(this.54);
			this.55 = new 1433(1455.2("spinner-middle", (1416)7, null), (1376)6, 1065.Centre, (1044)1, this.70, 1436.30((float)(this.1 + 3)), false, 198.TransparentWhite, null);
			this.30.Add(this.55);
			this.56 = new 1433(1455.2("spinner-middle2", (1416)7, null), (1376)6, 1065.Centre, (1044)1, this.70, 1436.30((float)(this.1 + 2)), false, 198.TransparentWhite, null);
			this.30.Add(this.56);
		}
		else
		{
			1381 5 = null;
			if (!2630.13)
			{
				5 = 1455.2("spinner-background.jpg", (1416)4, null);
			}
			if (5 == null)
			{
				5 = 1455.2("spinner-background", (1416)6, null);
			}
			198 6 = 2630.4.ContainsKey("SpinnerBackground") ? 2630.4["SpinnerBackground"] : new 198(100, 100, 100, byte.MaxValue);
			this.58 = new 1433(5, (1376)6, 1065.Centre, (1044)1, this.70, 1436.30((float)(this.1 - 1)), false, 6, null);
			this.30.Add(this.58);
			this.52 = new 1433(1455.2("spinner-circle", (1416)7, null), (1376)6, 1065.Centre, (1044)1, this.70, 1436.30((float)this.1), false, 4, null);
			this.30.Add(this.52);
			this.62 = new 1433(1455.2("spinner-metre", (1416)7, null), (1376)6, 1065.TopLeft, (1044)1, new 208(this.70.X - 320f, (float)this.67), 1436.30((float)(this.1 + 1)), false, 4, null);
			this.62.34 = 0;
			this.30.Add(this.62);
		}
		if (1662.78 == 1677.Play)
		{
			this.60 = new 1433(1455.2("spinner-rpm", (1416)7, null), (1376)6, 1065.TopLeft, (1044)1, new 208(this.70.X - 87f, 445f), 1436.30((float)(this.1 + 3)), false, 4, null);
			this.63 = new 1353(string.Empty, 2630.5.FontScore, (float)2630.5.FontScoreOverlap, (1376)6, 1065.TopRight, (1044)1, new 208(this.70.X + 80f, 448f), 1436.30((float)(this.1 + 4)), false, 4, true, (1416)7)
			{
				15 = 0.9f
			};
			this.30.Add(this.63);
			this.30.Add(this.60);
		}
		if (this.52.GetTexture().6 != (1416)1)
		{
			2023 7 = this.28.22;
			2023 8 = 2023.Hidden;
			if ((7 & 8) <= 2023.None && !this.28.15())
			{
				this.43 = new 1433(1455.2("spinner-approachcircle", (1416)7, null), (1376)6, 1065.Centre, (1044)1, this.70, 1436.30((float)(this.1 + 2)), false, 4, null);
				this.30.Add(this.43);
			}
		}
		this.53 = new 1353(string.Empty, 2630.5.FontScore, (float)2630.5.FontScoreOverlap, (1376)6, 1065.Centre, (1044)1, new 208(this.70.X, (float)(this.67 + 299)), 1436.30((float)(this.1 + 3)), false, 4, true, (1416)7);
		this.30.Add(this.53);
	}

	// Token: 0x060035D7 RID: 13783 RVA: 0x0014FAD0 File Offset: 0x0014DCD0
	protected virtual void InitializeTimingAndAnimations()
	{
		foreach (1433 <<EMPTY_NAME>> in this.30)
		{
			if (<<EMPTY_NAME>>.9 != -5)
			{
				<<EMPTY_NAME>>.3.Clear();
				<<EMPTY_NAME>>.3.Add(this.CreateFadeIn());
				<<EMPTY_NAME>>.3.Add(new 1445(1456.Fade, 1f, 0f, this.2, this.2 + 2039.14, (1046)0));
			}
		}
		1433 2 = this.43;
		if (2 != null)
		{
			2.3.Add(new 1445(1456.Scale, 1.86f, 0.1f, this.1, this.2, (1046)0));
		}
		if (1662.78 == 1677.Edit)
		{
			this.45 = new 1445(1456.Rotation, 0f, 0f, this.1, this.2, (1046)0);
			1433 3 = this.52;
			if (3 != null)
			{
				3.3.Add(this.45);
			}
		}
		1353 4 = this.63;
		if (4 != null)
		{
			4.3.Add(new 1445(this.63.17 + new 208(0f, 50f), this.63.17, this.1 - 2039.13, this.1, (1046)1));
		}
		1433 5 = this.60;
		if (5 != null)
		{
			5.3.Add(new 1445(this.60.17 + new 208(0f, 50f), this.60.17, this.1 - 2039.13, this.1, (1046)1));
		}
		this.69 = 0f;
		this.49 = (int)((double)((float)base.GetDuration() / 1000f) * this.28.7);
		this.48 = 8E-05 + Math.Max(0.0, (5000.0 - (double)base.GetDuration()) / 1000.0 / 2000.0);
	}

	// Token: 0x060035D8 RID: 13784 RVA: 0x0014FD0C File Offset: 0x0014DF0C
	internal override void Update()
	{
		if (this.11 || 1226.16 < this.1)
		{
			return;
		}
		double num = Math.Pow(0.9, (double)1535.60 / 16.666666666666668);
		this.50 = this.50 * num + (1.0 - num) * (Math.Abs(this.64) * 1000.0) / 6.283185307179586 * 60.0;
		if (this.63 != null)
		{
			this.63.SetText(string.Format("{0:#,0}", this.50));
		}
		2486 <<EMPTY_NAME>> = 2486.7;
		if (<<EMPTY_NAME>> != null)
		{
			<<EMPTY_NAME>>.49(this.50);
		}
		if (this.55 != null)
		{
			this.55.6 = 1045.4(198.White, 198.Red, (float)(1226.16 - this.1) / (float)base.GetDuration());
		}
		if (1662.78 == 1677.Edit)
		{
			this.45.5 = (float)((double)this.49 * 3.141592653589793);
			this.69 = (float)((double)((1226.16 - this.1) / 1000) * this.28.7);
		}
		else if (1226.16 < this.2 && 1226.16 > this.1 && !2486.16 && 1535.60 > 0)
		{
			double num2 = 2039.20(this.48 * (double)1535.60, this.28.22);
			if (1662.78 == 1677.Play)
			{
				2023 2 = this.28.22;
				2023 3 = 2023.SpunOut;
				if ((2 & 3) > 2023.None)
				{
					goto IL_43B;
				}
			}
			if (!2486.22)
			{
				if (this.65 > this.64)
				{
					this.64 += Math.Min(this.65 - this.64, (this.64 < 0.0 && 2486.21) ? (num2 / 4.0) : num2);
					goto IL_44A;
				}
				this.64 += Math.Max(this.65 - this.64, (this.64 > 0.0 && 2486.21) ? ((0.0 - num2) / 4.0) : (0.0 - num2));
				goto IL_44A;
			}
			IL_43B:
			this.64 = 0.03;
			IL_44A:
			this.64 = Math.Max(-0.05, Math.Min(this.64, 0.05));
			float num3 = (float)(this.64 * (double)1535.60);
			float num4 = (this.56 != null && this.56.GetTexture() != null) ? 0.5f : 1f;
			this.52.14 += (float)2039.20((double)(num3 * num4), this.28.22);
			if (this.56 != null)
			{
				this.56.14 += (float)2039.20((double)num3, this.28.22);
				this.54.14 = this.52.14 / 3f;
			}
			if (this.64 != 0.0)
			{
				this.12();
			}
			else
			{
				this.StopHitSounds();
			}
			this.69 += Math.Min(1f, Math.Abs((float)((double)num3 / 3.141592653589793)));
		}
		this.13(Math.Abs(this.69) / (float)this.49 * 100f);
		2129.2130 4 = this.68;
		if (4 != (2129.2130)0)
		{
			if (4 != (2129.2130)1)
			{
				return;
			}
			if (this.51 >= this.11())
			{
				if (this.57 != null)
				{
					this.57.6 = new 198(3, 151, byte.MaxValue);
				}
				if (this.61 != null)
				{
					this.61.16(100, (1046)0, 0);
					this.59.3.Clear();
					this.59.3.Add(new 1445(1456.Fade, 0f, 1f, 1226.16, Math.Min(this.2, 1226.16 + 400), (1046)1));
					this.59.3.Add(new 1445(1456.Scale, 2f, 0.8f, 1226.16, Math.Min(this.2, 1226.16 + 240), (1046)1));
					this.59.3.Add(new 1445(1456.Scale, 0.8f, 1f, Math.Min(this.2, 1226.16 + 240), Math.Min(this.2, 1226.16 + 400), (1046)0));
					this.59.3.Add(new 1445(1456.Fade, 1f, 0f, this.2 - 50, this.2, (1046)0));
				}
				this.68 = (2129.2130)2;
			}
		}
		else if (this.51 >= this.GetMinimumHalfTurns())
		{
			1433 5 = this.61;
			if (5 != null)
			{
				5.16(300, (1046)0, 0);
			}
			this.68 = (2129.2130)1;
			return;
		}
	}

	// Token: 0x060035D9 RID: 13785 RVA: 0x00150284 File Offset: 0x0014E484
	internal override 2149 JudgeAtPosition(208 1)
	{
		2149 result = (2149)0;
		if (!1535.56)
		{
			return (2149)0;
		}
		double num = (1535.61 > 0) ? ((double)(1226.16 - 1535.61)) : 16.666666666666668;
		if (num < 0.0)
		{
			return result;
		}
		208 2 = 1 - this.52.31;
		double num2 = Math.Atan2((double)2.Y, (double)2.X);
		if (this.46 == null)
		{
			if (this.10())
			{
				this.46 = new double?(0.0);
			}
			else
			{
				this.46 = new double?(num2);
			}
		}
		double num3 = num2 - this.46.Value;
		double? num4 = num2 - this.46;
		double num5 = -3.141592653589793;
		if (num4.GetValueOrDefault() < num5 & num4 != null)
		{
			num3 = 6.283185307179586 + num2 - this.46.Value;
		}
		else
		{
			num4 = this.46 - num2;
			num5 = -3.141592653589793;
			if (num4.GetValueOrDefault() < num5 & num4 != null)
			{
				num3 = -6.283185307179586 - this.46.Value + num2;
			}
		}
		double num6 = Math.Pow(0.999, num);
		this.71 = num6 * this.71 + (1.0 - num6) * num;
		if (num3 == 0.0)
		{
			int num7 = this.66;
			this.66 = num7 + 1;
			this.65 = ((num7 < 1) ? (this.65 / 3.0) : 0.0);
		}
		else
		{
			this.66 = 0;
			if (!2486.21 && ((1535.14 == 199.Released && 1535.43 == 199.Released) || 1226.16 < this.1 || 1226.16 > this.2))
			{
				num3 = 0.0;
			}
			if (Math.Abs(num3) < 3.141592653589793)
			{
				if (2039.20(this.71, this.28.22) > 17.333332697550457)
				{
					double num8 = 2039.20(num, this.28.22);
					this.65 = ((num8 > 0.0) ? (num3 / num8) : 0.0);
				}
				else
				{
					this.65 = num3 / 16.666666666666668;
				}
			}
			else
			{
				this.65 = 0.0;
			}
		}
		this.46 = new double?(num2);
		if (this.9() == this.47)
		{
			return (2149)0;
		}
		this.51++;
		if (2630.5.SpinnerFrequencyModulate)
		{
			1226.23((float)this.51 / (float)this.49);
		}
		if (this.51 > this.49 + 3 && (this.51 - (this.49 + 3)) % 2 == 0)
		{
			if (this.57 != null)
			{
				this.57.40(198.White, 200);
			}
			result = (2149)16384;
			2023 3 = 2023.Cinema;
			2023 4 = 2019.1;
			2023 5 = 3;
			if ((4 & 5) <= 2023.None)
			{
				1226.24("spinnerbonus", 1226.44(1226.45()), (1416)7, true);
			}
			this.53.SetText((1000 * (this.51 - (this.49 + 3)) / 2).ToString());
			this.53.3.Clear();
			this.53.3.Add(new 1445(1456.Fade, 1f, 0f, 1226.16, 1226.16 + 800, (1046)0));
			this.53.3.Add(new 1445(1456.Scale, 2f, 1.28f, 1226.16, 1226.16 + 800, (1046)0));
			this.53.3[0].15 = (1046)1;
			this.53.3[1].15 = (1046)1;
			this.53.3.Add(new 1445(1456.Fade, 0f, 0f, this.2 + 800, this.2 + 800, (1046)0));
		}
		else if (this.51 > 1 && this.51 % 2 == 0)
		{
			result = (2149)8192;
		}
		else if (this.51 > 1)
		{
			result = (2149)4096;
		}
		this.47 = this.9();
		return result;
	}

	// Token: 0x060035DA RID: 13786 RVA: 0x00150760 File Offset: 0x0014E960
	private new bool 10()
	{
		2241 <<EMPTY_NAME>> = 1535.39;
		DateTime? dateTime = (<<EMPTY_NAME>> != null) ? new DateTime?(<<EMPTY_NAME>>.7) : null;
		DateTime t = new DateTime(2019, 5, 10);
		if (!(dateTime < t))
		{
			2241 2 = 1535.39;
			return 2 != null && 2.34 < 20190510;
		}
		return true;
	}

	// Token: 0x060035DB RID: 13787 RVA: 0x001507D0 File Offset: 0x0014E9D0
	private int GetMinimumHalfTurns()
	{
		if (!this.10())
		{
			return Math.Max(0, this.49 / 4);
		}
		return this.49;
	}

	// Token: 0x060035DC RID: 13788 RVA: 0x001507EF File Offset: 0x0014E9EF
	private new int 11()
	{
		if (!this.10())
		{
			return this.49;
		}
		return this.49 + 1;
	}

	// Token: 0x060035DD RID: 13789 RVA: 0x00150808 File Offset: 0x0014EA08
	internal override 2149 GetOrCalculateJudgement()
	{
		this.StopHitSounds();
		1433 <<EMPTY_NAME>> = this.57;
		if (<<EMPTY_NAME>> != null)
		{
			<<EMPTY_NAME>>.16(300, (1046)0, 0);
		}
		this.11 = true;
		if (this.10())
		{
			if (this.51 < this.GetMinimumHalfTurns())
			{
				return (2149)(-131072);
			}
			this.PlayHitSound();
			if (this.51 > this.11())
			{
				return (2149)1024;
			}
			if (this.51 > this.11() - 1)
			{
				return (2149)512;
			}
			return (2149)256;
		}
		else
		{
			if (this.49 == 0)
			{
				this.PlayHitSound();
				return (2149)1024;
			}
			if (this.51 < this.GetMinimumHalfTurns())
			{
				return (2149)(-131072);
			}
			this.PlayHitSound();
			if (this.51 > this.11())
			{
				return (2149)1024;
			}
			if (this.51 > this.11() - 2)
			{
				return (2149)512;
			}
			return (2149)256;
		}
	}

	// Token: 0x060035DE RID: 13790 RVA: 0x001508EC File Offset: 0x0014EAEC
	private void 12()
	{
		1226.32(2630.5.SpinnerFrequencyModulate ? new float?((float)this.51 / (float)this.49) : null);
	}

	// Token: 0x060035DF RID: 13791 RVA: 0x00150929 File Offset: 0x0014EB29
	internal override void StopHitSounds()
	{
		1226.35();
	}

	// Token: 0x060035E0 RID: 13792 RVA: 0x00150930 File Offset: 0x0014EB30
	private new void 13(float 1)
	{
		if (this.57 != null)
		{
			if (this.68 < (2129.2130)2)
			{
				this.57.6 = new 198(3, 151, byte.MaxValue);
				1445 2 = (this.57.3.Count > 0) ? this.57.3[0] : null;
				if (2 != null)
				{
					2.1 = (2.5 = Math.Min(1f, 1 / 100f));
				}
				this.55.15 = (this.56.15 = (this.52.15 = (this.54.15 = (this.57.15 = 0.8f + 1052.8(1 / 100f, 0f, 0.2f, 1f)))));
			}
			return;
		}
		1 = Math.Min(99f, 1);
		int num = (int)1 / 10;
		if (2630.5.SpinnerNoBlink || 1196.8((double)((float)((int)1 % 10) / 10f)))
		{
			num++;
		}
		if (this.62 != null)
		{
			this.62.37 = (int)(69.2 * (double)(10 - num));
			this.62.34 = (int)(69.2 * (double)num);
			this.62.17.Y = (float)((double)this.67 + 43.25 * (double)(10 - num));
		}
	}

	// Token: 0x060035E1 RID: 13793 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void SetComboColour(198 1)
	{
	}

	// Token: 0x060035E2 RID: 13794 RVA: 0x00150ABC File Offset: 0x0014ECBC
	internal override 2034 Clone()
	{
		2129 <<EMPTY_NAME>> = new 2129(this.28, this.1, this.2, this.4);
		<<EMPTY_NAME>>.4(base.3());
		<<EMPTY_NAME>>.SetNewCombo(this.IsNewCombo());
		<<EMPTY_NAME>>.35 = this.35;
		<<EMPTY_NAME>>.36 = this.36;
		<<EMPTY_NAME>>.34 = this.34;
		<<EMPTY_NAME>>.32 = this.32;
		<<EMPTY_NAME>>.33 = this.33;
		return <<EMPTY_NAME>>;
	}

	// Token: 0x060035E3 RID: 13795 RVA: 0x00150B3A File Offset: 0x0014ED3A
	internal override void OnSelected()
	{
		this.52.6 = 198.BlueViolet;
	}

	// Token: 0x060035E4 RID: 13796 RVA: 0x00150B4C File Offset: 0x0014ED4C
	internal override void OnDeselected()
	{
		this.52.6 = 198.White;
	}

	// Token: 0x060035E5 RID: 13797 RVA: 0x00150B60 File Offset: 0x0014ED60
	internal override void SetStartTime(int 1)
	{
		int num = 1 - this.1;
		this.1 += num;
		this.SetEndTime(this.2 + num);
	}

	// Token: 0x060035E6 RID: 13798 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void SetPosition(208 1, bool 2 = false)
	{
	}

	// Token: 0x060035E7 RID: 13799 RVA: 0x00150B94 File Offset: 0x0014ED94
	internal override void SetEndTime(int 1)
	{
		int num = -1;
		if (base.GetDuration() >= this.28.9)
		{
			num = base.GetDuration();
		}
		this.2 = Math.Max(this.1, 1);
		this.InitializeTimingAndAnimations();
		if (!this.28.34.Contains(this))
		{
			return;
		}
		if (num < 0)
		{
			this.28.27(this, true);
			return;
		}
		if (base.GetDuration() < this.28.9)
		{
			this.28.10--;
			if (this.28.10 == 0)
			{
				this.28.26();
				return;
			}
		}
		else if (base.GetDuration() > num)
		{
			this.28.27(this, true);
		}
	}

	// Token: 0x060035E8 RID: 13800 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void Shake()
	{
	}

	// Token: 0x060035E9 RID: 13801 RVA: 0x00150C53 File Offset: 0x0014EE53
	internal override void ResetJudgementState()
	{
		base.ResetJudgementState();
	}

	// Token: 0x040027E8 RID: 10216
	protected 1433 43;

	// Token: 0x040027E9 RID: 10217
	private bool 44;

	// Token: 0x040027EA RID: 10218
	protected 1445 45;

	// Token: 0x040027EB RID: 10219
	private double? 46;

	// Token: 0x040027EC RID: 10220
	private int 47;

	// Token: 0x040027ED RID: 10221
	private double 48;

	// Token: 0x040027EE RID: 10222
	internal int 49;

	// Token: 0x040027EF RID: 10223
	private double 50;

	// Token: 0x040027F0 RID: 10224
	private int 51;

	// Token: 0x040027F1 RID: 10225
	protected 1433 52;

	// Token: 0x040027F2 RID: 10226
	protected 1353 53;

	// Token: 0x040027F3 RID: 10227
	private 1433 54;

	// Token: 0x040027F4 RID: 10228
	private 1433 55;

	// Token: 0x040027F5 RID: 10229
	private 1433 56;

	// Token: 0x040027F6 RID: 10230
	private 1433 57;

	// Token: 0x040027F7 RID: 10231
	private 1433 58;

	// Token: 0x040027F8 RID: 10232
	private 1433 59;

	// Token: 0x040027F9 RID: 10233
	private 1433 60;

	// Token: 0x040027FA RID: 10234
	private 1433 61;

	// Token: 0x040027FB RID: 10235
	private 1433 62;

	// Token: 0x040027FC RID: 10236
	private 1353 63;

	// Token: 0x040027FD RID: 10237
	internal double 64;

	// Token: 0x040027FE RID: 10238
	protected double 65;

	// Token: 0x040027FF RID: 10239
	private int 66;

	// Token: 0x04002800 RID: 10240
	protected int 67 = 45;

	// Token: 0x04002801 RID: 10241
	private 2129.2130 68;

	// Token: 0x04002802 RID: 10242
	private float 69;

	// Token: 0x04002803 RID: 10243
	protected 208 70;

	// Token: 0x04002804 RID: 10244
	private double 71 = 16.666666666666668;

	// Token: 0x0200071D RID: 1821
	[276]
	public enum 2130
	{

	}
}
