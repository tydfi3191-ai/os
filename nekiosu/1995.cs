using System;

// Token: 0x02000757 RID: 1879
public sealed class 1995
{
	// Token: 0x06003724 RID: 14116 RVA: 0x001599CC File Offset: 0x00157BCC
	internal 1995(2011 1, int 2, float 3)
	{
		this.2(1);
		this.10 = 2;
		this.13 = 3;
		float num = (2 > 0) ? (1.4.ColumnSpacing[2 - 1] * 3) : 0f;
		this.4(1.28() + 1.20 + num);
		this.6(1.4.ColumnWidth[2] * 3);
		1.20 += this.5() + num;
		if (!1.11())
		{
			float num2 = this.1().24() - Math.Abs(this.1().33() - this.1().36());
			if (1.4.ColumnLineWidth[2] > 0f)
			{
				this.13(new 1433(1662.34, (1376)6, 1.57(1065.BottomLeft), (1044)1, new 208(0f, 1.36()), 0.61f, true, 1.4.18("ColumnLine"), null)
				{
					20 = new 208(0.74f * 1.4.ColumnLineWidth[2], num2 * 1.6f)
				}, 1.5);
			}
			this.13(new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)1, new 208(0f, 1.26()), 0.6f, true, 1.4.18(string.Format("{0}", 2 + 1)), null)
			{
				20 = new 208(this.5(), 1.24()),
				15 = 1.6f
			}, 1.5);
			if ((1.4.ColumnLineWidth[2 + 1] > 0f && 2630.5.Version >= 2.4) || 2 == 1.4.Columns - 1)
			{
				this.13(new 1433(1662.34, (1376)6, 1.57(1065.BottomLeft), (1044)1, new 208(this.5() - ((2 == 1.4.Columns - 1) ? 0.1f : 0f), 1.36()), 0.61f, true, 1.4.18("ColumnLine"), null)
				{
					20 = new 208(0.74f * 1.4.ColumnLineWidth[2 + 1], num2 * 1.6f)
				}, 1.5);
			}
			1436 4 = 1.4.KeysUnderNotes ? 1.5 : 1.7;
			1381 5 = 1.4.19(string.Format("KeyImage{0}", 2), this.11(), 1.8());
			1433 6 = new 1433(5, (1376)6, 1.57(1065.BottomCentre), (1044)1, new 208(this.5() / 2f, 1.33()), 0.92f, true, 198.White, null);
			6.20 = new 208(this.5() * 1.6f / (float)5.3(), 1.37());
			6.43(1.4.21("Key", 2, string.Empty, true));
			this.4 = 6;
			this.13(this.4, 4);
			5 = 1.4.19(string.Format("KeyImage{0}D", 2), this.11() + "D", 1.8());
			1433 7 = new 1433(5, (1376)6, 1.57(1065.BottomCentre), (1044)1, new 208(this.5() / 2f, 1.33()), 0.925f, true, 198.White, null);
			7.20 = new 208(this.5() * 1.6f / (float)5.3(), 1.37());
			7.43(this.4.42());
			7.16 = 0f;
			this.5 = 7;
			this.13(this.5, 4);
			this.7 = new 1351(1.4.20("StageLight", "mania-stage-light", 1.8()), (1376)6, 1.57(1065.BottomLeft), (1044)1, new 208(0f, 1.47((float)this.1().4.LightPosition)), 0.72f, true, 1.4.18(string.Format("Light{0}", 2 + 1)));
			this.7.16 = 0f;
			this.7.53((double)(1000f / (float)1.4.LightFramePerSecond));
			this.7.72 = false;
			this.7.71 = 1446.LoopForever;
			this.7.20 = new 208(this.5() * 1.6f / (float)this.7.39, 1.37());
			this.13(this.7, 1.5);
			1452 8 = new 1452(string.Empty, this.5() / 2f, new 208(this.5() / 2f, 1.47(480f - (float)this.4.34 / 1.6f / 2f)), 0.93f, true, 1.4.18("KeyWarning"));
			8.54(true);
			8.49 = 1065.Centre;
			8.15 = 1.37();
			this.6 = 8;
			this.13(this.6, 1.7);
			this.8 = 1.4.20("LightingN", "lightingN", 1.8());
			1381[] array = 1.4.20("LightingL", "lightingL", 1.8());
			if (array == null || array.Length == 0)
			{
				array = new 1381[this.8.Length];
				this.8.CopyTo(array, 0);
			}
			this.9 = new 1351(array, (1376)6, 1065.Centre, (1044)1, new 208(this.5() / 2f, 1.36()), 0.98f, true, 198.White);
			this.9.15 = this.1().4.25(2) * 3;
			this.9.16 = 0f;
			this.9.28 = true;
			if (array != null)
			{
				this.9.53(Math.Max((double)(170f / (float)array.Length), 16.666666666666668));
			}
			this.13(this.9, 1.7);
		}
	}

	// Token: 0x06003725 RID: 14117 RVA: 0x0015A082 File Offset: 0x00158282
	internal 2011 1()
	{
		return this.3;
	}

	// Token: 0x06003726 RID: 14118 RVA: 0x0015A08A File Offset: 0x0015828A
	private void 2(2011 1)
	{
		this.3 = 1;
	}

	// Token: 0x06003727 RID: 14119 RVA: 0x0015A093 File Offset: 0x00158293
	internal float 3()
	{
		return this.11;
	}

	// Token: 0x06003728 RID: 14120 RVA: 0x0015A09B File Offset: 0x0015829B
	private void 4(float 1)
	{
		this.11 = 1;
	}

	// Token: 0x06003729 RID: 14121 RVA: 0x0015A0A4 File Offset: 0x001582A4
	internal float 5()
	{
		return this.12;
	}

	// Token: 0x0600372A RID: 14122 RVA: 0x0015A0AC File Offset: 0x001582AC
	private void 6(float 1)
	{
		this.12 = 1;
	}

	// Token: 0x0600372B RID: 14123 RVA: 0x0015A0B8 File Offset: 0x001582B8
	internal int 7()
	{
		return (int)(((this.10 >= this.1().4.Columns) ? ((float)this.10 - 0.5f) : (0.5f + (float)this.10)) * (512f / (float)this.1().4.Columns));
	}

	// Token: 0x0600372C RID: 14124 RVA: 0x0015A114 File Offset: 0x00158314
	internal 1996 8()
	{
		int num = this.10 - this.1().1();
		bool flag = this.1().9() != 1991.None && this.1().41();
		1991 <<EMPTY_NAME>> = this.1().9();
		int num2 = this.1().44();
		if (flag && <<EMPTY_NAME>> == 1991.Right)
		{
			num2 = this.1().45() - 1;
		}
		else if (flag)
		{
			num2 = 0;
		}
		if (num == num2)
		{
			return (1996)2;
		}
		if (flag)
		{
			if ((num % 2 == 1 && <<EMPTY_NAME>> == 1991.Right) || (num % 2 == 0 && <<EMPTY_NAME>> == 1991.Left))
			{
				return (1996)1;
			}
		}
		else
		{
			int num3 = (int)Math.Floor((double)((float)this.1().45() / 2f));
			if ((this.1().45() % 2 == 1 && (num < num3 || num > num3) && num % 2 == 1) || (this.1().45() % 2 == 0 && ((num < num3 && num % 2 == 1) || (num >= num3 && num % 2 == 0))))
			{
				return (1996)1;
			}
		}
		return (1996)0;
	}

	// Token: 0x0600372D RID: 14125 RVA: 0x0015A204 File Offset: 0x00158404
	internal 198 9()
	{
		1996 <<EMPTY_NAME>> = this.8();
		198 white;
		if (<<EMPTY_NAME>> != (1996)1)
		{
			if (<<EMPTY_NAME>> != (1996)2)
			{
				white = 198.White;
			}
			else
			{
				white = 1995.2;
			}
		}
		else
		{
			white = 1995.1;
		}
		return white;
	}

	// Token: 0x0600372E RID: 14126 RVA: 0x0015A23C File Offset: 0x0015843C
	internal string 10()
	{
		1996 <<EMPTY_NAME>> = this.8();
		string result;
		if (<<EMPTY_NAME>> != (1996)1)
		{
			if (<<EMPTY_NAME>> != (1996)2)
			{
				result = "1";
			}
			else
			{
				result = "S";
			}
		}
		else
		{
			result = "2";
		}
		return result;
	}

	// Token: 0x0600372F RID: 14127 RVA: 0x0015A271 File Offset: 0x00158471
	internal string 11()
	{
		return "mania-key" + this.10();
	}

	// Token: 0x06003730 RID: 14128 RVA: 0x0015A283 File Offset: 0x00158483
	internal string 12()
	{
		return "mania-note" + this.10();
	}

	// Token: 0x06003731 RID: 14129 RVA: 0x0015A295 File Offset: 0x00158495
	public static implicit operator int(1995 1)
	{
		return 1.10;
	}

	// Token: 0x06003732 RID: 14130 RVA: 0x0015A29D File Offset: 0x0015849D
	private void 13(1433 1, 1436 2)
	{
		2.12(1);
		1.17.X = this.3() + 1.17.X;
	}

	// Token: 0x06003733 RID: 14131 RVA: 0x0015A2C4 File Offset: 0x001584C4
	internal void 14()
	{
		if (!this.1().11())
		{
			this.6.SetText(1548.11(this.16()) + ((this.18() != 200.None) ? ("\n" + 1548.11(this.18())) : string.Empty));
			this.6.3.Clear();
			this.6.16 = 1f;
			if (!this.1().7())
			{
				this.6.3.Add(new 1445(1456.Fade, 1f, 0f, 1662.33 + 500, 1662.33 + 3500, (1046)0));
			}
		}
	}

	// Token: 0x06003734 RID: 14132 RVA: 0x0015A384 File Offset: 0x00158584
	internal void 15()
	{
		1351 <<EMPTY_NAME>> = new 1351(this.8, (1376)6, 1065.Centre, (1044)2, new 208(this.5() / 2f, this.1().36()), 0.98f, false, 198.White);
		<<EMPTY_NAME>>.15 = this.1().4.24(this.10) * this.13;
		<<EMPTY_NAME>>.28 = true;
		<<EMPTY_NAME>>.71 = 1446.LoopOnce;
		if (this.8 != null)
		{
			<<EMPTY_NAME>>.53(Math.Max((double)(170f / (float)this.8.Length), 16.666666666666668));
		}
		<<EMPTY_NAME>>.15(80);
		<<EMPTY_NAME>>.3.Add(new 1445(1456.Fade, 1f, 0f, 1226.16 + 80, 1226.16 + 200, (1046)0));
		this.13(<<EMPTY_NAME>>, this.1().7);
	}

	// Token: 0x06003735 RID: 14133 RVA: 0x0015A46E File Offset: 0x0015866E
	internal 200 16()
	{
		return this.14;
	}

	// Token: 0x06003736 RID: 14134 RVA: 0x0015A476 File Offset: 0x00158676
	internal void 17(200 1)
	{
		this.14 = 1;
		this.14();
	}

	// Token: 0x06003737 RID: 14135 RVA: 0x0015A485 File Offset: 0x00158685
	internal 200 18()
	{
		return this.15;
	}

	// Token: 0x06003738 RID: 14136 RVA: 0x0015A48D File Offset: 0x0015868D
	internal void 19(200 1)
	{
		this.15 = 1;
		this.14();
	}

	// Token: 0x06003739 RID: 14137 RVA: 0x0015A49C File Offset: 0x0015869C
	internal int 20()
	{
		return (int)Math.Pow(2.0, (double)this.10);
	}

	// Token: 0x0600373A RID: 14138 RVA: 0x0015A4B4 File Offset: 0x001586B4
	internal bool 21()
	{
		return this.16;
	}

	// Token: 0x0600373B RID: 14139 RVA: 0x0015A4BC File Offset: 0x001586BC
	internal void 22(bool 1)
	{
		if (this.16 != 1)
		{
			this.16 = 1;
			if (this.21())
			{
				this.9.59();
				this.9.FadeIn(80, (1046)0, 0);
				return;
			}
			this.9.16(120, (1046)0, 0);
		}
	}

	// Token: 0x0600373C RID: 14140 RVA: 0x0015A50B File Offset: 0x0015870B
	internal bool 23()
	{
		return this.19;
	}

	// Token: 0x0600373D RID: 14141 RVA: 0x0015A514 File Offset: 0x00158714
	internal void 24(bool 1)
	{
		this.18 = this.19;
		if (this.19 == 1)
		{
			return;
		}
		this.19 = 1;
		if (!this.1().11())
		{
			if (this.19)
			{
				this.5.FadeIn(0, (1046)0, 0);
				this.4.16(0, (1046)0, 0);
				this.7.59();
				this.7.72 = true;
				this.7.SetTexture(this.7.54()[0]);
				this.7.3.Clear();
				this.7.16 = 1f;
				this.7.20.Y = (this.1().32() ? (0f - this.1().37()) : this.1().37());
				return;
			}
			this.5.3.Clear();
			this.5.3.Add(new 1445(1456.Fade, 1f, 0f, 1226.16 + 80, 1226.16 + 80, (1046)0));
			this.4.3.Clear();
			this.4.3.Add(new 1445(1456.Fade, 0f, 1f, 1226.16 + 80, 1226.16 + 80, (1046)0));
			int num = (int)(400.0 * (100.0 / 1226.78()));
			this.7.3.Add(new 1445(1456.Fade, 1f, 0f, 1226.16, 1226.16 + num, (1046)0));
			this.7.3.Add(new 1445(1456.VectorScale, new 208(this.7.20.X, this.1().32() ? (0f - this.1().37()) : this.1().37()), new 208(this.7.20.X, 0f), 1226.16, 1226.16 + num, (1046)0));
		}
	}

	// Token: 0x0600373E RID: 14142 RVA: 0x0015A74C File Offset: 0x0015894C
	internal void 25()
	{
		bool flag = false;
		if (!this.17)
		{
			flag = ((this.16() <= (200)300) ? 1549.10(this.16()) : 1546.3.Contains(this.16()));
			if (this.1().44() == this)
			{
				flag = ((this.18() <= (200)300) ? (flag | 1549.10(this.18())) : (flag | 1546.3.Contains(this.18())));
			}
		}
		if (1535.6() && 1535.7().Count > 0)
		{
			for (int i = 0; i < 1535.7().Count; i++)
			{
				208 <<EMPTY_NAME>> = 1535.7()[i];
				if (<<EMPTY_NAME>>.X > this.3() && <<EMPTY_NAME>>.X < this.3() + this.5() && <<EMPTY_NAME>>.Y > this.1().26() && <<EMPTY_NAME>>.Y < this.1().31())
				{
					flag = (this.17 = true);
				}
				else
				{
					this.17 = false;
				}
			}
		}
		else
		{
			this.17 = false;
		}
		this.24(flag);
	}

	// Token: 0x04002902 RID: 10498
	private static readonly 198 1 = new 198(250, 170, 212);

	// Token: 0x04002903 RID: 10499
	private static readonly 198 2 = new 198(247, 236, 0);

	// Token: 0x04002904 RID: 10500
	private 2011 3;

	// Token: 0x04002905 RID: 10501
	private 1433 4;

	// Token: 0x04002906 RID: 10502
	private 1433 5;

	// Token: 0x04002907 RID: 10503
	private 1452 6;

	// Token: 0x04002908 RID: 10504
	private 1351 7;

	// Token: 0x04002909 RID: 10505
	private 1381[] 8;

	// Token: 0x0400290A RID: 10506
	private 1351 9;

	// Token: 0x0400290B RID: 10507
	private int 10;

	// Token: 0x0400290C RID: 10508
	private float 11;

	// Token: 0x0400290D RID: 10509
	private float 12;

	// Token: 0x0400290E RID: 10510
	private float 13;

	// Token: 0x0400290F RID: 10511
	private 200 14;

	// Token: 0x04002910 RID: 10512
	private 200 15;

	// Token: 0x04002911 RID: 10513
	private bool 16;

	// Token: 0x04002912 RID: 10514
	private bool 17;

	// Token: 0x04002913 RID: 10515
	internal bool 18;

	// Token: 0x04002914 RID: 10516
	private bool 19;
}
