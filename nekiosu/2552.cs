using System;
using System.Collections.Generic;
using System.Drawing;

// Token: 0x020004E9 RID: 1257
[276]
internal sealed class 2552 : IDisposable
{
	// Token: 0x0600266B RID: 9835 RVA: 0x000BBD72 File Offset: 0x000B9F72
	internal void 1()
	{
		this.41 = (1555.2() == 199.Pressed);
		this.21 = (1555.4() == 199.Pressed);
	}

	// Token: 0x17000251 RID: 593
	// (get) Token: 0x0600266C RID: 9836 RVA: 0x000BBD90 File Offset: 0x000B9F90
	// (set) Token: 0x0600266D RID: 9837 RVA: 0x000BBD98 File Offset: 0x000B9F98
	internal int? HoveredTime { get; private set; }

	// Token: 0x17000252 RID: 594
	// (get) Token: 0x0600266E RID: 9838 RVA: 0x000BBDA1 File Offset: 0x000B9FA1
	// (set) Token: 0x0600266F RID: 9839 RVA: 0x000BBDA9 File Offset: 0x000B9FA9
	internal 1937? HoveredSegment { get; private set; }

	// Token: 0x17000253 RID: 595
	// (get) Token: 0x06002670 RID: 9840 RVA: 0x000BBDB2 File Offset: 0x000B9FB2
	// (set) Token: 0x06002671 RID: 9841 RVA: 0x000BBDBA File Offset: 0x000B9FBA
	internal int? HoveredCheckpoint { get; private set; }

	// Token: 0x06002672 RID: 9842 RVA: 0x000BBDC4 File Offset: 0x000B9FC4
	internal 2552(2486 1)
	{
		this.9 = 1;
		this.10 = new 1436(true);
		this.10.10 = false;
		this.11 = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, 208.Zero, 0.9f, true, 198.Black, null);
		this.11.15 = 1.6f;
		this.12 = 2552.5(0.91f);
		this.13 = 2552.5(0.911f);
		this.14 = new 1433(1662.34, (1376)6, 1065.TopCentre, (1044)0, 208.Zero, 0.92f, true, 198.White, null);
		this.14.15 = 1.6f;
		this.16 = new 1433(1662.34, (1376)6, 1065.TopCentre, (1044)0, 208.Zero, 0.913f, true, 198.White, null);
		this.16.15 = 1.6f;
		this.18 = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, 208.Zero, 0.912f, true, new 198(100, 200, byte.MaxValue), null);
		this.18.15 = 1.6f;
		this.31 = new 1452("Practice", 11f, 208.Zero, 0.93f, true, 198.White);
		this.31.49 = 1065.CentreLeft;
		this.32 = new 1452(string.Empty, 11f, 208.Zero, 0.93f, true, 198.White);
		this.32.49 = 1065.CentreRight;
		this.33 = new 1452(string.Empty, 11f, 208.Zero, 0.94f, true, 198.White);
		this.33.49 = 1065.BottomCentre;
		this.33.58(new 198(0, 0, 0, 200));
		this.10.14<1433>(new 1433[]
		{
			this.11,
			this.12,
			this.13,
			this.18,
			this.16,
			this.14,
			this.31,
			this.32,
			this.33
		});
		1433[] array = new 1433[]
		{
			this.11,
			this.12,
			this.13,
			this.18,
			this.16,
			this.14,
			this.31,
			this.32,
			this.33
		};
		for (int i = 0; i < array.Length; i++)
		{
			array[i].16 = 0f;
		}
		this.6();
		1535.40((1082)1, new 1081(this.2), 1545.Default, (1559)0);
		1535.40((1082)0, new 1081(this.3), 1545.Default, (1559)0);
	}

	// Token: 0x06002673 RID: 9843 RVA: 0x000BC0FC File Offset: 0x000BA2FC
	private bool 2(object 1, EventArgs 2)
	{
		return this.4(-1);
	}

	// Token: 0x06002674 RID: 9844 RVA: 0x000BC105 File Offset: 0x000BA305
	private bool 3(object 1, EventArgs 2)
	{
		return this.4(1);
	}

	// Token: 0x06002675 RID: 9845 RVA: 0x000BC10E File Offset: 0x000BA30E
	private bool 4(int 1)
	{
		if (!this.9.IsPracticeHeld || !this.9.CanPracticeSeek)
		{
			return false;
		}
		this.9.117(1 * 1000);
		return true;
	}

	// Token: 0x06002676 RID: 9846 RVA: 0x000BC140 File Offset: 0x000BA340
	private static 1433 5(float 1)
	{
		return new 1433(null, (1376)6, 1065.TopLeft, (1044)0, 208.Zero, 1, true, 198.White, null)
		{
			66 = false
		};
	}

	// Token: 0x06002677 RID: 9847 RVA: 0x000BC16C File Offset: 0x000BA36C
	private void 6()
	{
		this.39 = (float)1662.70.1();
		float num = 424f;
		float num2 = num - 16f;
		this.11.17 = new 208(0f, num2);
		this.11.20 = new 208(this.39, 72f);
		this.12.17 = (this.13.17 = new 208(this.38, num));
		this.31.17 = new 208(4f, num2 + 8f);
		this.32.17 = new 208(this.39 - 4f, num2 + 8f);
	}

	// Token: 0x06002678 RID: 9848 RVA: 0x000BC230 File Offset: 0x000BA430
	private void 7()
	{
		1922 strainGraph = 2206.StrainGraph;
		float num = 1662.70.3();
		double num2;
		double num3;
		double num4;
		this.8(strainGraph, out num2, out num3, out num4);
		float num5 = (float)((num3 - num2) / (num4 - num2)) * this.39;
		float num6 = Math.Max(1f, this.39 - num5);
		int pixelsWide = Math.Min(2048, Math.Max(1, (int)Math.Round((double)(num6 * num))));
		int pixelsHigh = Math.Min(2048, Math.Max(1, (int)Math.Round((double)(56f * num))));
		string a = string.Concat(new string[]
		{
			pixelsWide.ToString(),
			"x",
			pixelsHigh.ToString(),
			"@",
			num5.ToString("0.0", 1662.18)
		});
		if (a == this.35 && strainGraph == this.36)
		{
			return;
		}
		this.35 = a;
		this.36 = strainGraph;
		1381 <<EMPTY_NAME>> = this.34;
		if (strainGraph != null)
		{
			this.34 = 2543.7(strainGraph, pixelsWide, pixelsHigh, 300f, 2f * num * 0.625f, 0f);
		}
		else
		{
			float barHeight = Math.Max(2f, 4f * num);
			this.34 = 2532.5(pixelsWide, pixelsHigh, delegate(Graphics 1)
			{
				1.FillRectangle(Brushes.White, 0f, (float)pixelsHigh - barHeight, (float)pixelsWide, barHeight);
			});
		}
		this.37 = pixelsWide;
		this.38 = num5;
		this.12.17.X = (this.13.17.X = this.38);
		208 2 = new 208(num6 * num / (float)pixelsWide, 56f * num / (float)pixelsHigh);
		foreach (1433 3 in new 1433[]
		{
			this.13,
			this.12
		})
		{
			3.SetTexture(this.34);
			3.15 = 1f;
			3.20 = 2;
		}
		if (<<EMPTY_NAME>> != null)
		{
			<<EMPTY_NAME>>.Dispose();
		}
	}

	// Token: 0x06002679 RID: 9849 RVA: 0x000BC478 File Offset: 0x000BA678
	private void 8(1922 1, out double 2, out double 3, out double 4)
	{
		if (1 != null)
		{
			3 = 1.4;
			4 = 1.5;
		}
		else
		{
			3 = (double)this.9.PracticeFirstObjectTime;
			4 = (double)this.9.ReplayEndTime;
		}
		2 = 3;
		4 = Math.Max(3 + 1.0, 4);
	}

	// Token: 0x0600267A RID: 9850 RVA: 0x000BC4D4 File Offset: 0x000BA6D4
	internal void 9()
	{
		if (Math.Abs((float)1662.70.1() - this.39) > 0.01f)
		{
			this.6();
		}
		this.7();
		bool canPracticeSeek = this.9.CanPracticeSeek;
		bool flag = this.9.IsPracticeHeld && !this.9.IsPracticeRenaming;
		208 <<EMPTY_NAME>> = 1555.21();
		bool flag2 = 1555.2() == 199.Pressed;
		bool flag3 = 1555.4() == 199.Pressed;
		float num = Math.Max(0f, Math.Min(1f, <<EMPTY_NAME>>.X / Math.Max(1f, this.39 * 1662.70.3())));
		double num2;
		double num3;
		double num4;
		this.8(this.36, out num2, out num3, out num4);
		if (flag || this.40 > 0f)
		{
			this.10();
		}
		int num5 = flag ? this.16(<<EMPTY_NAME>>, num2, num4) : -1;
		this.29 = ((flag || this.40 > 0f) ? this.9.PracticeCheckpointTimes : new List<int>());
		int num6 = (flag && num5 < 0) ? this.15(<<EMPTY_NAME>>, num2, num4) : -1;
		if (flag2 && !this.41)
		{
			this.26 = (canPracticeSeek && flag && 1549.1);
			this.27 = (this.26 ? ((num5 >= 0 || num6 >= 0) ? num5 : this.14(<<EMPTY_NAME>>, num2, num4)) : -1);
			if (this.26 && num5 < 0 && num6 < 0)
			{
				num5 = this.27;
			}
			this.28 = (this.26 ? num6 : -1);
			this.42 = (canPracticeSeek && flag && !this.26);
			this.24 = (this.42 ? num5 : -1);
			this.43 = ((this.42 && this.24 < 0) ? num6 : -1);
			this.44 = num * this.39;
			this.45 = false;
		}
		if (flag2 && this.42 && flag && this.24 < 0 && this.43 < 0)
		{
			if (!this.45 && Math.Abs(num * this.39 - this.44) >= 4f)
			{
				this.45 = true;
			}
			if (this.45)
			{
				this.9.118((int)Math.Round(num2 + (double)num * (num4 - num2)), true);
			}
		}
		if (!flag2 && this.26)
		{
			this.26 = false;
			if (this.27 >= 0 && num5 < 0 && num6 < 0 && this.14(<<EMPTY_NAME>>, num2, num4) == this.27)
			{
				num5 = this.27;
			}
			if (flag && this.27 >= 0 && this.27 == num5)
			{
				this.9.103(new 1934(this.19[this.27]));
			}
			else if (flag && this.28 >= 0 && this.28 == num6)
			{
				this.9.103(new 1934(this.29[this.28]));
			}
		}
		if (!flag2 && this.42)
		{
			this.42 = false;
			if (flag && this.24 >= 0 && this.24 == num5)
			{
				this.9.105(this.19[this.24]);
			}
			else if (flag && this.43 >= 0 && this.43 == num6)
			{
				this.9.104(this.29[this.43]);
			}
			else if (flag && this.24 < 0 && this.43 < 0)
			{
				this.9.118((int)Math.Round(num2 + (double)num * (num4 - num2)), false);
			}
			this.24 = -1;
			this.43 = -1;
			this.45 = false;
		}
		float num7 = num * this.39;
		if (flag3 && !this.21 && canPracticeSeek && flag)
		{
			this.22 = true;
			this.23 = num7;
			this.24 = num5;
			this.25 = num6;
		}
		if (!flag3 && this.22)
		{
			this.22 = false;
			if (flag && Math.Abs(num7 - this.23) >= 4f)
			{
				int num8 = (int)Math.Round(num2 + (double)(this.23 / this.39) * (num4 - num2));
				int num9 = (int)Math.Round(num2 + (double)num * (num4 - num2));
				this.9.106(new 1937(num8, num9));
			}
			else if (flag && this.24 >= 0 && this.24 == num5)
			{
				this.9.115(this.19[this.24]);
			}
			else if (flag && this.25 >= 0 && this.25 == num6)
			{
				this.9.110(this.29[this.25]);
			}
			else if (flag && this.24 < 0 && this.25 < 0)
			{
				this.9.109((int)Math.Round(num2 + (double)num * (num4 - num2)));
			}
			this.24 = -1;
			this.25 = -1;
		}
		if (!canPracticeSeek)
		{
			this.42 = false;
			this.22 = false;
			this.26 = false;
		}
		this.41 = flag2;
		this.21 = flag3;
		bool flag4 = canPracticeSeek && (this.9.IsPracticeHeld || this.42);
		this.40 = Math.Max(0f, Math.Min(1f, this.40 + (flag4 ? 0.2f : -0.2f) * (float)1662.10));
		double num10 = Math.Max(0.0, Math.Min(1.0, ((double)1226.16 - num3) / (num4 - num3)));
		this.13.ResetSourceRectangle();
		this.13.35 = (int)Math.Round(num10 * (double)this.37);
		this.13.6 = new 198(230, 141, 235);
		this.12.6 = new 198(150, 140, 170);
		this.11.16 = this.40 * 0.45f;
		this.12.16 = this.40 * 0.6f;
		this.13.16 = this.40 * 0.95f;
		this.31.16 = (this.32.16 = this.40);
		this.14.16 = (this.33.16 = this.40);
		int? practiceJumpTime = this.9.PracticeJumpTime;
		this.16.16 = ((practiceJumpTime != null) ? (this.40 * 0.5f) : 0f);
		if (practiceJumpTime != null)
		{
			this.16.17 = new 208((float)Math.Max(0.0, Math.Min(1.0, ((double)practiceJumpTime.Value - num2) / (num4 - num2))) * this.39, 424f);
			this.16.20 = new 208(1.5f, 56f);
		}
		List<int> list = (this.40 > 0f) ? this.29 : new List<int>();
		1934? 2 = (this.40 > 0f) ? this.9.PracticeAutoStartPoint : null;
		while (this.15.Count < list.Count)
		{
			1433 3 = new 1433(1662.34, (1376)6, 1065.TopCentre, (1044)0, 208.Zero, 0.915f, true, new 198(byte.MaxValue, 204, 34), null);
			3.15 = 1.6f;
			3.16 = 0f;
			this.15.Add(3);
			this.10.12(3);
		}
		for (int i = 0; i < this.15.Count; i++)
		{
			1433 4 = this.15[i];
			4.16 = ((i < list.Count) ? this.40 : 0f);
			if (i < list.Count)
			{
				4.17 = new 208((float)Math.Max(0.0, Math.Min(1.0, ((double)list[i] - num2) / (num4 - num2))) * this.39, 424f);
				4.20 = new 208((i == num6) ? 2.5f : 1.5f, 56f);
				1371 5 = 4;
				if (2 == null)
				{
					goto IL_90F;
				}
				1934 value = 2.Value;
				if (!value.1(list[i]))
				{
					goto IL_90F;
				}
				198 6 = 2552.30;
				IL_927:
				5.6 = 6;
				goto IL_92C;
				IL_90F:
				6 = new 198(byte.MaxValue, 204, 34);
				goto IL_927;
			}
			IL_92C:;
		}
		1937? activePracticeSegment = this.9.ActivePracticeSegment;
		while (this.17.Count < this.19.Count)
		{
			1433 7 = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, 208.Zero, 0.917f, true, 198.White, null);
			7.15 = 1.6f;
			7.16 = 0f;
			this.17.Add(7);
			this.10.12(7);
		}
		for (int j = 0; j < this.17.Count; j++)
		{
			1433 8 = this.17[j];
			if (j >= this.19.Count)
			{
				8.16 = 0f;
			}
			else
			{
				float num11 = this.12(this.19[j].1, num2, num4);
				float num12 = this.12(this.19[j].2, num2, num4);
				bool flag5 = activePracticeSegment != null && activePracticeSegment.Value.Equals(this.19[j]);
				bool flag6;
				if (2 != null)
				{
					1934 value = 2.Value;
					flag6 = value.2(this.19[j]);
				}
				else
				{
					flag6 = false;
				}
				bool flag7 = flag6;
				float num13 = flag5 ? 5.5f : 4f;
				8.17 = new 208(num11, 2552.13(this.20[j]) - (num13 - 4f) / 2f);
				8.20 = new 208(Math.Max(1.5f, num12 - num11), num13);
				198 9 = (!this.9.107(this.19[j])) ? new 198(130, 130, 140) : (flag7 ? 2552.30 : new 198(100, 200, byte.MaxValue));
				8.6 = ((flag5 || j == num5) ? 2552.11(9) : 9);
				8.16 = this.40 * ((flag5 || j == num5) ? 1f : 0.8f);
			}
		}
		this.18.16 = ((this.22 && Math.Abs(num7 - this.23) >= 4f) ? (this.40 * 0.3f) : 0f);
		this.18.17 = new 208(Math.Min(this.23, num7), 424f);
		this.18.20 = new 208(Math.Abs(num7 - this.23), 56f);
		string text = "Practice";
		if (2 != null)
		{
			string str = text;
			1934 value = 2.Value;
			string str2;
			if (value.2 == null)
			{
				str2 = ": plays start at " + 2552.18(2.Value.1);
			}
			else
			{
				string str3 = ": plays start at ";
				value = 2.Value;
				string str4 = 2552.18(value.2.Value.1);
				string str5 = " - ";
				value = 2.Value;
				str2 = str3 + str4 + str5 + 2552.18(value.2.Value.2);
			}
			text = str + str2;
		}
		if (text != this.48)
		{
			this.48 = text;
			this.31.SetText(text);
		}
		this.14.17 = new 208(num * this.39, 424f);
		this.14.20 = new 208(1.5f, 56f);
		float num14 = Math.Max(14f, this.33.GetTextSize().X / 2f + 2f);
		this.33.17 = new 208(Math.Max(num14, Math.Min(this.39 - num14, num * this.39)), 423f);
		string text2 = 2552.18(1226.16) + " / " + 2552.18((int)num4);
		if (text2 != this.46)
		{
			this.46 = text2;
			this.32.SetText(text2);
		}
		this.HoveredTime = (flag ? new int?((int)Math.Round(num2 + (double)num * (num4 - num2))) : null);
		this.HoveredSegment = ((num5 >= 0 && num5 < this.19.Count) ? new 1937?(this.19[num5]) : null);
		this.HoveredCheckpoint = ((num6 >= 0 && num6 < this.29.Count) ? new int?(this.29[num6]) : null);
		string text3 = 2552.18((int)Math.Round(num2 + (double)num * (num4 - num2)));
		if (this.22 && Math.Abs(num7 - this.23) >= 4f)
		{
			text3 = 2552.18((int)Math.Round(num2 + (double)(Math.Min(this.23, num7) / this.39) * (num4 - num2))) + " - " + 2552.18((int)Math.Round(num2 + (double)(Math.Max(this.23, num7) / this.39) * (num4 - num2)));
		}
		else if (this.HoveredSegment != null)
		{
			text3 = this.9.111(this.HoveredSegment.Value.1, new 1937?(this.HoveredSegment.Value));
		}
		else if (this.HoveredCheckpoint != null)
		{
			text3 = this.9.111(this.HoveredCheckpoint.Value, null);
		}
		if (text3 != this.47)
		{
			this.47 = text3;
			this.33.SetText(text3);
		}
	}

	// Token: 0x0600267B RID: 9851 RVA: 0x000BD458 File Offset: 0x000BB658
	private void 10()
	{
		this.19 = this.9.PracticeSegmentList;
		this.20.Clear();
		int[] array = new int[6];
		for (int i = 0; i < 6; i++)
		{
			array[i] = int.MinValue;
		}
		foreach (1937 <<EMPTY_NAME>> in this.19)
		{
			int num = 0;
			while (num < 5 && array[num] > <<EMPTY_NAME>>.1)
			{
				num++;
			}
			array[num] = Math.Max(array[num], <<EMPTY_NAME>>.2);
			this.20.Add(num);
		}
	}

	// Token: 0x0600267C RID: 9852 RVA: 0x000BD518 File Offset: 0x000BB718
	private static 198 11(198 1)
	{
		return new 198((byte)((float)1.R + (float)(byte.MaxValue - 1.R) * 0.35f), (byte)((float)1.G + (float)(byte.MaxValue - 1.G) * 0.35f), (byte)((float)1.B + (float)(byte.MaxValue - 1.B) * 0.35f));
	}

	// Token: 0x0600267D RID: 9853 RVA: 0x000BD57E File Offset: 0x000BB77E
	private float 12(int 1, double 2, double 3)
	{
		return (float)Math.Max(0.0, Math.Min(1.0, ((double)1 - 2) / (3 - 2))) * this.39;
	}

	// Token: 0x0600267E RID: 9854 RVA: 0x000BD5AC File Offset: 0x000BB7AC
	private static float 13(int 1)
	{
		return 427f + (float)1 * 6f;
	}

	// Token: 0x0600267F RID: 9855 RVA: 0x000BD5BC File Offset: 0x000BB7BC
	private int 14(208 1, double 2, double 3)
	{
		float num = 1662.70.3();
		float num2 = 1.X / num;
		if (1.Y / num < 424f)
		{
			return -1;
		}
		1934? practiceAutoStartPoint = this.9.PracticeAutoStartPoint;
		1937? activePracticeSegment = this.9.ActivePracticeSegment;
		int num3 = -1;
		for (int i = 0; i < this.19.Count; i++)
		{
			if (num2 >= this.12(this.19[i].1, 2, 3) && num2 <= this.12(this.19[i].2, 2, 3))
			{
				if (practiceAutoStartPoint != null && practiceAutoStartPoint.Value.2(this.19[i]))
				{
					return i;
				}
				if (num3 < 0 || (activePracticeSegment != null && activePracticeSegment.Value.Equals(this.19[i])))
				{
					num3 = i;
				}
			}
		}
		return num3;
	}

	// Token: 0x06002680 RID: 9856 RVA: 0x000BD6C4 File Offset: 0x000BB8C4
	private int 15(208 1, double 2, double 3)
	{
		float num = 1662.70.3();
		float num2 = 1.X / num;
		if (1.Y / num < 424f)
		{
			return -1;
		}
		int result = -1;
		float num3 = 3f;
		for (int i = 0; i < this.29.Count; i++)
		{
			float num4 = Math.Abs(this.12(this.29[i], 2, 3) - num2);
			if (num4 <= num3)
			{
				result = i;
				num3 = num4;
			}
		}
		return result;
	}

	// Token: 0x06002681 RID: 9857 RVA: 0x000BD744 File Offset: 0x000BB944
	private int 16(208 1, double 2, double 3)
	{
		float num = 1662.70.3();
		float num2 = 1.X / num;
		float num3 = 1.Y / num;
		for (int i = this.19.Count - 1; i >= 0; i--)
		{
			float num4 = 2552.13(this.20[i]) - 1f - 1f;
			float num5 = this.12(this.19[i].1, 2, 3);
			float num6 = Math.Max(num5 + 1.5f, this.12(this.19[i].2, 2, 3));
			if (num2 >= num5 - 1f && num2 <= num6 + 1f && num3 >= num4 && num3 <= num4 + 6f + 1f)
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x06002682 RID: 9858 RVA: 0x000BD81D File Offset: 0x000BBA1D
	internal void 17()
	{
		if (this.40 > 0f)
		{
			this.10.22();
		}
	}

	// Token: 0x06002683 RID: 9859 RVA: 0x000BD838 File Offset: 0x000BBA38
	internal static string 18(int 1)
	{
		int num = Math.Max(0, 1) / 1000;
		return (num / 60).ToString() + ":" + (num % 60).ToString("00");
	}

	// Token: 0x06002684 RID: 9860 RVA: 0x000BD87C File Offset: 0x000BBA7C
	public void Dispose()
	{
		1535.41((1082)1, new 1081(this.2), 1545.Default);
		1535.41((1082)0, new 1081(this.3), 1545.Default);
		this.10.Dispose();
		1381 <<EMPTY_NAME>> = this.34;
		if (<<EMPTY_NAME>> != null)
		{
			<<EMPTY_NAME>>.Dispose();
		}
		this.34 = null;
	}

	// Token: 0x04001B56 RID: 6998
	private const float 1 = 56f;

	// Token: 0x04001B57 RID: 6999
	private const float 2 = 16f;

	// Token: 0x04001B58 RID: 7000
	private const float 3 = 0.625f;

	// Token: 0x04001B59 RID: 7001
	private const float 4 = 300f;

	// Token: 0x04001B5A RID: 7002
	private const float 5 = 4f;

	// Token: 0x04001B5B RID: 7003
	private const float 6 = 6f;

	// Token: 0x04001B5C RID: 7004
	private const int 7 = 6;

	// Token: 0x04001B5D RID: 7005
	private const float 8 = 4f;

	// Token: 0x04001B5E RID: 7006
	private readonly 2486 9;

	// Token: 0x04001B5F RID: 7007
	private readonly 1436 10;

	// Token: 0x04001B60 RID: 7008
	private readonly 1433 11;

	// Token: 0x04001B61 RID: 7009
	private readonly 1433 12;

	// Token: 0x04001B62 RID: 7010
	private readonly 1433 13;

	// Token: 0x04001B63 RID: 7011
	private readonly 1433 14;

	// Token: 0x04001B64 RID: 7012
	private readonly List<1433> 15 = new List<1433>();

	// Token: 0x04001B65 RID: 7013
	private readonly 1433 16;

	// Token: 0x04001B66 RID: 7014
	private readonly List<1433> 17 = new List<1433>();

	// Token: 0x04001B67 RID: 7015
	private readonly 1433 18;

	// Token: 0x04001B68 RID: 7016
	private List<1937> 19 = new List<1937>();

	// Token: 0x04001B69 RID: 7017
	private readonly List<int> 20 = new List<int>();

	// Token: 0x04001B6A RID: 7018
	private bool 21;

	// Token: 0x04001B6B RID: 7019
	private bool 22;

	// Token: 0x04001B6C RID: 7020
	private float 23;

	// Token: 0x04001B6D RID: 7021
	private int 24 = -1;

	// Token: 0x04001B6E RID: 7022
	private int 25 = -1;

	// Token: 0x04001B6F RID: 7023
	private bool 26;

	// Token: 0x04001B70 RID: 7024
	private int 27 = -1;

	// Token: 0x04001B71 RID: 7025
	private int 28 = -1;

	// Token: 0x04001B72 RID: 7026
	private List<int> 29 = new List<int>();

	// Token: 0x04001B73 RID: 7027
	private static readonly 198 30 = new 198(110, 230, 120);

	// Token: 0x04001B74 RID: 7028
	private readonly 1452 31;

	// Token: 0x04001B75 RID: 7029
	private readonly 1452 32;

	// Token: 0x04001B76 RID: 7030
	private readonly 1452 33;

	// Token: 0x04001B77 RID: 7031
	private 1381 34;

	// Token: 0x04001B78 RID: 7032
	private string 35;

	// Token: 0x04001B79 RID: 7033
	private 1922 36;

	// Token: 0x04001B7A RID: 7034
	private int 37;

	// Token: 0x04001B7B RID: 7035
	private float 38;

	// Token: 0x04001B7C RID: 7036
	private float 39;

	// Token: 0x04001B7D RID: 7037
	private float 40;

	// Token: 0x04001B7E RID: 7038
	private bool 41;

	// Token: 0x04001B7F RID: 7039
	private bool 42;

	// Token: 0x04001B80 RID: 7040
	private int 43 = -1;

	// Token: 0x04001B81 RID: 7041
	private float 44;

	// Token: 0x04001B82 RID: 7042
	private bool 45;

	// Token: 0x04001B83 RID: 7043
	private string 46;

	// Token: 0x04001B84 RID: 7044
	private string 47;

	// Token: 0x04001B85 RID: 7045
	private string 48;
}
