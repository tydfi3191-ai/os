using System;

// Token: 0x020007FC RID: 2044
[276]
public class 2033 : 2072
{
	// Token: 0x06003B13 RID: 15123 RVA: 0x0017454C File Offset: 0x0017274C
	internal 2033(2039 1 = null) : this(1, 208.Zero, 0, false, false, false, false, 0)
	{
	}

	// Token: 0x06003B14 RID: 15124 RVA: 0x0017456C File Offset: 0x0017276C
	internal 2033(2039 1, 208 2, int 3, bool 4, 1245 5, int 6 = 0) : this(1, 2, 3, 4, 5.2(1245.Whistle), 5.2(1245.Finish), 5.2(1245.Clap), 6)
	{
	}

	// Token: 0x06003B15 RID: 15125 RVA: 0x001745A0 File Offset: 0x001727A0
	internal 2033(2039 1, 208 2, int 3 = 0, bool 4 = false, bool 5 = false, bool 6 = false, bool 7 = false, int 8 = 0) : base(1)
	{
		this.8 = 2;
		this.18 = 2;
		this.1 = 3;
		this.2 = 3;
		this.3 = 2047.Normal;
		this.4 = 1245.None;
		this.35 = 1254.None;
		this.36 = 1254.None;
		if (4)
		{
			this.3 |= 2047.NewCombo;
			this.16 = 8;
		}
		if (5)
		{
			this.4 |= 1245.Whistle;
		}
		if (6)
		{
			this.4 |= 1245.Finish;
		}
		if (7)
		{
			this.4 |= 1245.Clap;
		}
		if (((1 != null) ? 1.39 : null) == null)
		{
			return;
		}
		int preemptTime = this.GetPreemptTime();
		2023 9 = this.28.22;
		2023 10 = 2023.Hidden;
		bool flag = (9 & 10) > 2023.None;
		bool flag2 = this.ShouldShowApproachCircle() && !1.15() && (!flag || (1.34.Count == 0 && 1304.202));
		198 white = 198.White;
		1381 11 = 1455.2("approachcircle", (1416)7, null);
		1381 12 = 1455.1(new string[]
		{
			this.GetCircleTextureName(),
			"hitcircle"
		}, (1416)7);
		1381[] array;
		if (this is 2181)
		{
			array = 1455.5(((12 != null) ? 12.2 : "hitcircle") + "overlay", (1416)7, true);
		}
		else
		{
			(array = new 1381[1])[0] = 1455.2(((12 != null) ? 12.2 : "hitcircle") + "overlay", (1416)7, null);
		}
		1381[] 13 = array;
		this.45 = new 1433(11, (1376)1, 1065.Centre, (1044)1, this.8, 1436.31((float)(2000 + this.1 - preemptTime)), false, white, null);
		if (flag2)
		{
			this.30.Add(this.45);
		}
		this.45.3.Add(new 1445(1456.Fade, 0f, 0.9f, 3 - preemptTime, Math.Min(3, 3 - preemptTime + 2039.13 * 2), (1046)0));
		this.45.3.Add(new 1445(1456.Scale, 4f, 1f, 3 - preemptTime, 3, (1046)0));
		this.46 = new 1433(12, (1376)1, 1065.Centre, (1044)1, this.8, 1436.32((float)this.1), false, white, null)
		{
			9 = 1
		};
		this.30.Add(this.46);
		this.29.Add(this.46);
		this.47 = new 1351(13, (1376)1, 1065.Centre, (1044)1, this.8, 1436.32((float)(this.1 - ((!this.28.43()) ? 1 : 2))), false, 198.White);
		this.47.53(500.0);
		this.30.Add(this.47);
		this.29.Add(this.47);
		this.48 = new 1353(null, 2630.5.FontHitCircle, (float)2630.5.FontHitCircleOverlap, (1376)1, 1065.Centre, (1044)1, this.8, 1436.32((float)(this.1 - (this.28.43() ? 1 : 2))), false, 198.White, true, (1416)7);
		this.48.15 = 0.8f;
		if (this.ShouldShowComboNumber())
		{
			this.30.Add(this.48);
		}
		1445 14 = (!flag || 1.IsInfiniteApproach) ? new 1445(1456.Fade, 0f, 1f, 3 - preemptTime, 3 - preemptTime + 2039.13, (1046)0) : new 1445(1456.Fade, 0f, 1f, 3 - preemptTime, 3 - (int)((double)preemptTime * 0.6), (1046)0);
		this.46.3.Add(14.Clone());
		this.47.3.Add(14.Clone());
		this.48.3.Add(14.Clone());
		if (1662.78 == 1677.Edit)
		{
			this.49 = new 1433(1455.2("hitcircleselect", (1416)7, null), (1376)1, 1065.Centre, (1044)0, this.8, 1436.32((float)(this.1 - 3)), true, 198.TransparentWhite, null);
			this.30.Add(this.49);
			if (1304.83)
			{
				this.ApplyJudgementAnimation(true);
			}
			else
			{
				14 = new 1445(1456.Fade, 1f, 0f, 3, 3 + this.28.34(), (1046)0);
				this.46.3.Add(14.Clone());
				this.47.3.Add(14.Clone());
				this.48.3.Add(14.Clone());
				this.45.3.Add(14.Clone());
			}
			this.45.3.Add(new 1445(1456.Scale, 1f, 1.1f, 3, 3 + 100, (1046)0));
			return;
		}
		this.ResetJudgementState();
	}

	// Token: 0x06003B16 RID: 15126 RVA: 0x00174AA5 File Offset: 0x00172CA5
	internal virtual string GetCircleTextureName()
	{
		return "hitcircle";
	}

	// Token: 0x06003B17 RID: 15127 RVA: 0x0001702D File Offset: 0x0001522D
	protected virtual bool ShouldShowComboNumber()
	{
		return true;
	}

	// Token: 0x06003B18 RID: 15128 RVA: 0x0001702D File Offset: 0x0001522D
	protected virtual bool ShouldShowApproachCircle()
	{
		return true;
	}

	// Token: 0x06003B19 RID: 15129 RVA: 0x00174AAC File Offset: 0x00172CAC
	internal override void SetEndTime(int 1)
	{
		throw new Exception();
	}

	// Token: 0x06003B1A RID: 15130 RVA: 0x00174AB4 File Offset: 0x00172CB4
	internal override 2034 Clone()
	{
		2033 <<EMPTY_NAME>> = new 2033(this.28, this.8, this.1, this.3.1(2047.NewCombo), this.4, this.16);
		<<EMPTY_NAME>>.18 = this.18;
		<<EMPTY_NAME>>.SetComboColour(this.7);
		<<EMPTY_NAME>>.SetComboNumber(this.GetComboNumber());
		<<EMPTY_NAME>>.4(base.3());
		<<EMPTY_NAME>>.35 = this.35;
		<<EMPTY_NAME>>.36 = this.36;
		<<EMPTY_NAME>>.37 = this.37;
		<<EMPTY_NAME>>.34 = this.34;
		<<EMPTY_NAME>>.32 = this.32;
		<<EMPTY_NAME>>.33 = this.33;
		return <<EMPTY_NAME>>;
	}

	// Token: 0x06003B1B RID: 15131 RVA: 0x00174B68 File Offset: 0x00172D68
	internal override void SetPosition(208 1, bool 2 = false)
	{
		base.SetPosition(1, 2);
		foreach (1433 3 in this.30)
		{
			3.17 = 1;
		}
	}

	// Token: 0x06003B1C RID: 15132 RVA: 0x00174BC4 File Offset: 0x00172DC4
	internal override void SetStartTime(int 1)
	{
		int 2 = 1 - this.1;
		this.1 = 1;
		this.2 = this.1;
		this.45.23(2);
		this.46.23(2);
		this.47.23(2);
		this.48.23(2);
		this.49.23(2);
	}

	// Token: 0x06003B1D RID: 15133 RVA: 0x00174C29 File Offset: 0x00172E29
	internal override void OnSelected()
	{
		this.49.FadeIn(50, (1046)0, 0);
	}

	// Token: 0x06003B1E RID: 15134 RVA: 0x00174C3A File Offset: 0x00172E3A
	internal override void OnDeselected()
	{
		this.49.16(50, (1046)0, 0);
	}

	// Token: 0x06003B1F RID: 15135 RVA: 0x00174C4C File Offset: 0x00172E4C
	internal override void ResetJudgementState()
	{
		base.ResetJudgementState();
		2023 <<EMPTY_NAME>> = this.28.22;
		2023 2 = 2023.Hidden;
		bool flag = (<<EMPTY_NAME>> & 2) > 2023.None;
		bool flag2 = this.ShouldShowApproachCircle() && !this.28.15() && (!flag || this.28.34.Count == 0);
		bool flag3 = 1929.3(<<EMPTY_NAME>>);
		int num = this.28.IsInfiniteApproach ? this.28.HiddenPreemptTime : this.GetPreemptTime();
		1445 3;
		if (!flag3)
		{
			(3 = new 1445(1456.Fade, 1f, 0f, this.1 + this.28.4, this.1 + this.28.3, (1046)0)).16 = 148;
		}
		else
		{
			(3 = new 1445(1456.Fade, 1f, 0f, this.1 - (int)((double)num * 0.6), this.1 - (int)((double)num * 0.3), (1046)0)).16 = 148;
		}
		1445 4 = 3;
		this.46.3.Add(4.Clone());
		this.47.3.Add(4.Clone());
		this.48.3.Add(4.Clone());
		if (flag2 && flag)
		{
			this.45.3.Add(4.Clone());
		}
		this.46.15 = 1f;
		this.47.15 = 1f;
		this.48.15 = 0.8f;
	}

	// Token: 0x06003B20 RID: 15136 RVA: 0x00174DEC File Offset: 0x00172FEC
	internal override void ApplyJudgementAnimation(bool 1)
	{
		base.ApplyJudgementAnimation(1);
		int num = (1662.78 != 1677.Edit) ? 1226.16 : this.1;
		if (1 && 1662.78 != 1677.Edit && !(this is 2181) && 1304.53.1())
		{
			foreach (1433 2 in new 1433[]
			{
				this.46,
				this.47,
				this.48,
				this.45
			})
			{
				2.3.Add(new 1445(1456.Fade, 2.16, 0f, num, num, (1046)0)
				{
					16 = 148
				});
			}
			return;
		}
		if (!1)
		{
			2023 3 = this.28.22;
			2023 4 = 2023.Hidden;
			bool flag = 1929.3(3 & 4);
			this.46.3.Add(new 1445(1456.Fade, (!flag) ? this.46.16 : 0f, 0f, num, num + 60, (1046)0)
			{
				16 = 148
			});
			this.47.3.Add(new 1445(1456.Fade, (!flag) ? this.47.16 : 0f, 0f, num, num + 60, (1046)0)
			{
				16 = 148
			});
			this.48.3.Add(new 1445(1456.Fade, (!flag) ? this.48.16 : 0f, 0f, num, num + 60, (1046)0)
			{
				16 = 148
			});
			this.45.3.Add(new 1445(1456.Fade, (!flag) ? this.45.16 : 0f, 0f, num, num + 60, (1046)0)
			{
				16 = 148
			});
			this.46.15 = this.GetCircleScale();
			this.47.15 = this.GetCircleScale();
			this.48.15 = 0.8f;
			return;
		}
		1445 5 = new 1445(1456.Scale, 1f, 1.4f, num, num + 2039.14, (1046)1)
		{
			16 = 148
		};
		this.46.3.Add(5);
		this.46.3.Add(new 1445(1456.Fade, 1f, 0f, num, num + 2039.14, (1046)0)
		{
			16 = 148
		});
		this.47.3.Add(5.Clone());
		this.47.3.Add(new 1445(1456.Fade, 1f, 0f, num, num + 2039.14, (1046)0)
		{
			16 = 148
		});
		this.45.3.Add(new 1445(1456.Fade, this.45.16, 0f, num, num, (1046)0)
		{
			16 = 148
		});
		if (2630.21())
		{
			this.48.3.Add(new 1445(1456.Fade, 1f, 0f, num, num + 60, (1046)0)
			{
				16 = 148
			});
			return;
		}
		this.48.3.Add(new 1445(1456.Scale, 0.8f, 1.12f, num, num + 2039.14, (1046)1)
		{
			16 = 148
		});
		this.48.3.Add(new 1445(1456.Fade, this.48.16, 0f, num, num + 2039.14, (1046)0)
		{
			16 = 148
		});
	}

	// Token: 0x06003B21 RID: 15137 RVA: 0x00175190 File Offset: 0x00173390
	public override int GetComboNumber()
	{
		return this.44;
	}

	// Token: 0x06003B22 RID: 15138 RVA: 0x00175198 File Offset: 0x00173398
	public override void SetComboNumber(int 1)
	{
		1452 2 = this.48 as 1452;
		if (2 != null)
		{
			2.SetText((1 > 0) ? 1.ToString() : string.Empty);
		}
		this.44 = 1;
	}

	// Token: 0x06003B23 RID: 15139 RVA: 0x0013FA97 File Offset: 0x0013DC97
	public override 208 GetEndPosition()
	{
		return this.8;
	}

	// Token: 0x06003B24 RID: 15140 RVA: 0x00005ADD File Offset: 0x00003CDD
	public override void SetEndPosition(208 1)
	{
	}

	// Token: 0x06003B25 RID: 15141 RVA: 0x001751D3 File Offset: 0x001733D3
	internal override bool IsActive()
	{
		return 1226.16 >= this.1 - this.GetPreemptTime() && 1226.16 <= this.2 + 2039.14 + this.28.34();
	}

	// Token: 0x06003B26 RID: 15142 RVA: 0x00175210 File Offset: 0x00173410
	internal override void SetComboColour(198 1)
	{
		if (this.28.39 == null || !(1 != this.7))
		{
			return;
		}
		this.46.6 = 1;
		this.45.6 = 1;
		if (1662.78 == 1677.Edit && !1304.83)
		{
			if (this.50 != null)
			{
				this.46.3.Remove(this.50);
			}
			this.46.3.Add(this.50 = new 1445(1, 198.White, this.1 - 5, this.2 - 5));
		}
		this.7 = 1;
		base.SetComboColour(1);
		this.ApplyComboColourFade();
	}

	// Token: 0x06003B27 RID: 15143 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal override 2149 JudgeAtPosition(208 1)
	{
		return (2149)0;
	}

	// Token: 0x06003B28 RID: 15144 RVA: 0x001752CC File Offset: 0x001734CC
	protected virtual float GetCircleScale()
	{
		return 1f;
	}

	// Token: 0x04002BBD RID: 11197
	private int 44;

	// Token: 0x04002BBE RID: 11198
	internal 1433 45;

	// Token: 0x04002BBF RID: 11199
	internal 1433 46;

	// Token: 0x04002BC0 RID: 11200
	internal 1351 47;

	// Token: 0x04002BC1 RID: 11201
	internal 1433 48;

	// Token: 0x04002BC2 RID: 11202
	internal 1433 49;

	// Token: 0x04002BC3 RID: 11203
	private 1445 50;
}
