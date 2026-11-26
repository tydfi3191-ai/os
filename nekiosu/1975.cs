using System;
using System.Collections.Generic;

// Token: 0x02000789 RID: 1929
public sealed class 1975 : 2039
{
	// Token: 0x06003896 RID: 14486 RVA: 0x00162E2C File Offset: 0x0016102C
	internal 1975(bool 1 = true) : base(1)
	{
		this.77 = 1;
		this.74 = 0;
		this.75 = 0;
	}

	// Token: 0x06003897 RID: 14487 RVA: 0x0001702D File Offset: 0x0001522D
	protected override bool UsesFullWindowCoordinates()
	{
		return true;
	}

	// Token: 0x06003898 RID: 14488 RVA: 0x00162E91 File Offset: 0x00161091
	internal override 2034 GetLastGameplayHitObject()
	{
		return this.76;
	}

	// Token: 0x06003899 RID: 14489 RVA: 0x00162E9C File Offset: 0x0016109C
	protected override void OnBeatmapChanged()
	{
		if (this.39 != null)
		{
			this.41 = new 2011(2630.17(2011.53(this.21, this.22), this.22), false, 0f, 480f, float.NaN, 1f, 0, 0);
		}
		else
		{
			this.41 = new 2011(this);
		}
		this.71 = new 1979[this.41.19.Count];
		this.73 = new int[this.41.19.Count];
		this.72 = new int[this.41.19.Count];
		Dictionary<int, bool> dictionary = new Dictionary<int, bool>(this.41.19.Count);
		Random random = new Random(2486.20);
		for (int i = 0; i < this.41.19.Count; i++)
		{
			if (this.41.41() && i == 0)
			{
				if (this.41.42())
				{
					this.72[0] = this.41.19.Count - 1;
					dictionary[this.41.19.Count - 1] = true;
				}
				else
				{
					this.72[0] = 0;
					dictionary[0] = true;
				}
			}
			else
			{
				int num = random.Next(0, this.41.19.Count);
				while (dictionary.ContainsKey(num))
				{
					num = random.Next(0, this.41.19.Count);
				}
				this.72[i] = num;
				dictionary[num] = true;
			}
		}
		dictionary.Clear();
	}

	// Token: 0x0600389A RID: 14490 RVA: 0x00163051 File Offset: 0x00161251
	public override void Dispose()
	{
		if (this.41 != null)
		{
			this.41.Dispose();
		}
		base.Dispose();
	}

	// Token: 0x0600389B RID: 14491 RVA: 0x0016306C File Offset: 0x0016126C
	protected override void OnHitObjectsReloading()
	{
		this.61 = int.MaxValue;
		this.62 = int.MinValue;
		this.63 = int.MinValue;
		this.64 = 0;
		this.65 = 0;
		this.76 = null;
		Array.Clear(this.71, 0, this.71.Length);
		Array.Clear(this.73, 0, this.73.Length);
		if (this.77)
		{
			foreach (1995 <<EMPTY_NAME>> in this.41.19)
			{
				<<EMPTY_NAME>>.22(false);
			}
		}
	}

	// Token: 0x0600389C RID: 14492 RVA: 0x0000FF75 File Offset: 0x0000E175
	protected override bool UsesComboEndJudgements()
	{
		return false;
	}

	// Token: 0x0600389D RID: 14493 RVA: 0x0000FF75 File Offset: 0x0000E175
	protected override bool UsesComboColours()
	{
		return false;
	}

	// Token: 0x0600389E RID: 14494 RVA: 0x0000FF75 File Offset: 0x0000E175
	protected override bool UsesHitLighting()
	{
		return false;
	}

	// Token: 0x0600389F RID: 14495 RVA: 0x00163128 File Offset: 0x00161328
	internal override 2037 CreateHitObjectFactory()
	{
		return new 1971(this);
	}

	// Token: 0x060038A0 RID: 14496 RVA: 0x00163130 File Offset: 0x00161330
	private int 75(double 1)
	{
		2023 2 = this.22;
		2023 3 = 2023.HardRock;
		if ((2 & 3) > 2023.None)
		{
			1 /= 1.4;
		}
		else
		{
			2023 4 = this.22;
			3 = 2023.Easy;
			if ((4 & 3) > 2023.None)
			{
				1 *= 1.4;
			}
		}
		2023 5 = this.22;
		3 = 2023.DoubleTime;
		if ((5 & 3) > 2023.None)
		{
			1 *= 1939.17(this.22, this.46);
		}
		else
		{
			2023 6 = this.22;
			3 = 2023.HalfTime;
			if ((6 & 3) > 2023.None)
			{
				1 *= 1939.17(this.22, this.46);
			}
		}
		return (int)1;
	}

	// Token: 0x060038A1 RID: 14497 RVA: 0x001631E0 File Offset: 0x001613E0
	public override double GetDifficultyRange(double 1, double 2, double 3, double 4)
	{
		if (1 > 5.0)
		{
			return 3 + (4 - 3) * (1 - 5.0) / 5.0;
		}
		if (1 < 5.0)
		{
			return 3 - (3 - 2) * (5.0 - 1) / 5.0;
		}
		return 3;
	}

	// Token: 0x060038A2 RID: 14498 RVA: 0x00163240 File Offset: 0x00161440
	internal override void RecalculateDifficulty(bool 1, bool 2, bool 3 = false)
	{
		base.RecalculateDifficulty(1, 2, true);
		if (this.21 != null)
		{
			2241 4 = 2486.88;
			if (((4 != null) ? 4.39 : null) != null)
			{
				this.59 = this.75(this.GetDifficultyRange((double)base.16(1928.OverallDifficulty, this.21.4), 22.4, 19.4, 13.9));
				this.5 = this.75(this.GetDifficultyRange((double)base.16(1928.OverallDifficulty, this.21.4), 64.0, 49.0, 34.0));
				this.60 = this.75(this.GetDifficultyRange((double)base.16(1928.OverallDifficulty, this.21.4), 97.0, 82.0, 67.0));
				this.4 = this.75(this.GetDifficultyRange((double)base.16(1928.OverallDifficulty, this.21.4), 127.0, 112.0, 97.0));
				this.3 = this.75(this.GetDifficultyRange((double)base.16(1928.OverallDifficulty, this.21.4), 151.0, 136.0, 121.0));
				this.58 = (int)this.GetDifficultyRange((double)base.16(1928.OverallDifficulty, this.21.4), 188.0, 173.0, 158.0);
				return;
			}
			if (this.21.3() == 2147.OsuMania)
			{
				float num = Math.Min(10f, Math.Max(0f, 10f - base.16(1928.OverallDifficulty, this.21.4)));
				this.59 = this.75(16.0);
				this.5 = this.75((double)(34f + 3f * num));
				this.60 = this.75((double)(67f + 3f * num));
				this.4 = this.75((double)(97f + 3f * num));
				this.3 = this.75((double)(121f + 3f * num));
				this.58 = this.75((double)(158f + 3f * num));
				return;
			}
			if (Math.Round((double)base.16(1928.OverallDifficulty, this.21.4)) > 4.0)
			{
				this.59 = this.75(16.0);
				this.5 = this.75(34.0);
				this.60 = this.75(67.0);
				this.4 = this.75(97.0);
				this.3 = this.75(121.0);
				this.58 = this.75(158.0);
				return;
			}
			this.59 = this.75(16.0);
			this.5 = this.75(47.0);
			this.60 = this.75(77.0);
			this.4 = this.75(97.0);
			this.3 = this.75(121.0);
			this.58 = this.75(158.0);
		}
	}

	// Token: 0x060038A3 RID: 14499 RVA: 0x001635EC File Offset: 0x001617EC
	internal int 76(int 1)
	{
		int num = 1;
		2023 2 = this.22;
		2023 3 = 2023.Random;
		if ((2 & 3) > 2023.None)
		{
			num = this.72[1];
		}
		else if (this.41.42())
		{
			num = ((1 != 0) ? (1 - 1) : (this.41.19.Count - 1));
		}
		2023 4 = this.22;
		3 = 2023.Mirror;
		if ((4 & 3) > 2023.None)
		{
			num = this.41.19.Count - 1 - num;
		}
		return num;
	}

	// Token: 0x060038A4 RID: 14500 RVA: 0x00163670 File Offset: 0x00161870
	private void 77(1979 1)
	{
		1983 2 = 1.46;
		if (2 == (1983)0)
		{
			this.64++;
			return;
		}
		if (2 != (1983)1)
		{
			return;
		}
		this.65++;
	}

	// Token: 0x060038A5 RID: 14501 RVA: 0x001636A9 File Offset: 0x001618A9
	internal override void AddHitObject(2034 1, bool 2 = false, bool 3 = false)
	{
		base.AddHitObject(1, 2, false);
	}

	// Token: 0x060038A6 RID: 14502 RVA: 0x001636B4 File Offset: 0x001618B4
	private void 78(1979 1)
	{
		if (1.1 < this.61)
		{
			this.61 = 1.1;
		}
		if (1.2 > this.62)
		{
			this.62 = 1.2;
			this.76 = 1;
		}
		if (1.2 - 1.1 > this.63)
		{
			this.63 = 1.2 - 1.1;
		}
		this.77(1);
		this.AddHitObject(1, false, false);
	}

	// Token: 0x060038A7 RID: 14503 RVA: 0x00163734 File Offset: 0x00161934
	protected internal override void AddCircle(2072 1)
	{
		1979 2 = 1 as 1979;
		if (2 != null)
		{
			this.78(2);
			return;
		}
		foreach (1979 3 in ((1966)1).44)
		{
			this.78(3);
		}
	}

	// Token: 0x060038A8 RID: 14504 RVA: 0x001637A0 File Offset: 0x001619A0
	protected internal override void AddSlider(2063 1)
	{
		foreach (1979 2 in ((1969)1).93)
		{
			this.78(2);
		}
	}

	// Token: 0x060038A9 RID: 14505 RVA: 0x001637F8 File Offset: 0x001619F8
	protected internal override void AddSpinner(2070 1)
	{
		foreach (1979 2 in ((1970)1).43)
		{
			this.78(2);
		}
	}

	// Token: 0x060038AA RID: 14506 RVA: 0x00163850 File Offset: 0x00161A50
	protected internal override void PrepareHitObjects()
	{
		this.2 = Math.Max((int)2009.7(0, this.41.4.HitPosition), this.63) + 200;
		this.66 = this.64 + this.65;
		this.21.3();
		2241 <<EMPTY_NAME>> = 2486.88;
		if (<<EMPTY_NAME>> != null)
		{
			2023 2 = <<EMPTY_NAME>>.8;
			2023 3 = 2023.Perfect;
			if ((2 & 3) > 2023.None)
			{
				this.70 = true;
			}
		}
		this.79(-1);
	}

	// Token: 0x060038AB RID: 14507 RVA: 0x001638D8 File Offset: 0x00161AD8
	internal void 79(int 1)
	{
		if (!this.77)
		{
			return;
		}
		bool flag = false;
		bool upsideDown = this.41.4.UpsideDown;
		if (1 > this.62)
		{
			return;
		}
		if (1226.32 == (1042)1)
		{
			1226.107();
			flag = true;
		}
		if (this.67 != null)
		{
			this.67.ForEach(new Action<1433>(1975.1976.instance.1));
			this.67.Clear();
		}
		else
		{
			this.67 = new List<1433>();
		}
		foreach (2034 2 in this.34)
		{
			if (!((1979)2).54)
			{
				2.30.ForEach(new Action<1433>(1975.1976.instance.2));
			}
		}
		foreach (2011 3 in this.41)
		{
			3.8.15(false);
			3.8.2(true);
		}
		List<1259> list = (this.21.3() != 2147.OsuMania) ? this.21.84() : this.21.94;
		if (list.Count == 0 || this.34.Count == 0)
		{
			return;
		}
		this.68 = new List<1259>();
		this.69 = new List<1259>();
		double 4 = list[0].1;
		foreach (1259 5 in list)
		{
			1259 6 = new 1259();
			6.2(false);
			6.1 = ((5.1 < 0.0) ? (4 * (double)5.6()) : 5.1);
			6.5 = 5.5;
			6.3 = 5.3;
			6.8 = 5.8;
			if (this.68.Count > 0 && 6.3 <= this.68[this.68.Count - 1].3)
			{
				this.68.RemoveAt(this.68.Count - 1);
			}
			if (this.68.Count == 0 || 6.1 != this.68[this.68.Count - 1].1)
			{
				this.68.Add(6);
			}
			if (5.1 >= 0.0)
			{
				this.69.Add(6);
				4 = 6.1;
			}
		}
		double num;
		for (num = list[0].3; num >= 0.0; num -= list[0].1 * (double)list[0].5)
		{
		}
		num -= list[0].1 * (double)list[0].5;
		this.68[0].3 = num;
		this.69[0].3 = num;
		this.68.Add(new 1259
		{
			3 = double.PositiveInfinity
		});
		for (int i = 0; i < this.34.Count; i++)
		{
			1979 7 = (1979)this.34[i];
			1978 8 = this.34[i] as 1978;
			if (!7.54)
			{
				float num2 = this.85(7.52);
				this.80(7.52, (double)7.1, (double)num2, 0f, 0.0);
				if (8 != null)
				{
					float num3 = this.85(8.64);
					this.80(8.64, (double)7.2, (double)num3, 0f, 0.0);
					this.80(8.63, (double)7.1, (double)(num2 / 2f), (0f - num2) / 2f, (double)(7.2 - 7.1));
					float num4 = 0f;
					float num5 = 0f;
					if (8.51 > 0f)
					{
						num4 = 8.63.3.Find(new Predicate<1445>(1975.1976.instance.4)).1;
						num5 = 8.63.3.FindLast(new Predicate<1445>(1975.1976.instance.5)).5;
					}
					float num6 = Math.Abs(num5 - num4) * 1.6f;
					8.63.20.Y = (8.63.42() ? -1f : 1f);
					if (8.63.70)
					{
						8.63.29 = false;
						8.63.70 = false;
						8.63.ResetSourceRectangle();
					}
					1990 9 = this.41.4.23(7.44);
					if (9 == 1990.Stretch)
					{
						1351 10 = 8.63;
						10.20.Y = 10.20.Y * (num6 / (float)8.63.34);
					}
					else
					{
						8.63.29 = true;
						1351 11 = 8.63;
						11.20.Y = 11.20.Y * this.41.37();
						float num7 = (float)8.63.34 / this.41.37();
						8.63.34 = (8.63.38 = (int)(num6 / this.41.37()));
						8.63.70 = true;
						if (9 != 1990.RepeatTop)
						{
							if (9 != 1990.RepeatTopAndBottom)
							{
								8.63.37 = 0;
							}
							else
							{
								8.63.37 = (int)((num7 - num6) / 2f);
							}
						}
						else
						{
							8.63.37 = (int)(num7 - num6);
						}
					}
					8.63.UpdateOriginOffset();
					if (8.66 || 8.67)
					{
						this.87(8);
					}
					if (8.67)
					{
						this.88(8);
					}
				}
				7.44.1().8.14<1433>(7.30);
			}
		}
		if (!1304.92)
		{
			198 12 = this.41.4.18("Barline");
			for (int j = 0; j < this.69.Count; j++)
			{
				double num8 = this.69[j].3;
				double num9 = (double)(this.62 + 1);
				if (j + 1 < this.69.Count)
				{
					num9 = this.69[j + 1].3 - 1.0;
				}
				if (num9 >= (double)(1 - 1000))
				{
					while (num8 < num9)
					{
						foreach (2011 13 in this.41)
						{
							if (num8 > this.69[j].3 || (this.69[j].8 & (1258)8) == (1258)0)
							{
								1433 14 = new 1433(1662.34, (1376)6, 1065.CentreLeft, (1044)1, new 208(0f, -100f), 0.62f, false, 12, null);
								14.20 = new 208(13.20 * 1.6f, this.41.4.BarlineHeight);
								this.80(14, num8, (double)this.41.4.BarlineHeight, 0f, 0.0);
								this.67.Add(14);
								13.8.12(14);
							}
						}
						double num10 = this.69[j].1 * (double)this.69[j].5;
						if (num10 < 0.001)
						{
							break;
						}
						num8 += num10;
					}
				}
			}
		}
		int num11 = this.61 - 1000;
		int num12 = 0;
		while ((double)num11 > this.68[0].3 && num12 < 3)
		{
			foreach (2011 15 in this.41)
			{
				1433 16 = new 1433(this.41.4.19("WarningArrow", "mania-warningarrow", this.41.8()), (1376)6, this.41.57(1065.TopCentre), (1044)1, new 208(15.20 / 2f, 0f), 0.63f, false, 198.White, null);
				if (2630.5.Version >= 2.4 || 15.37() < 1f)
				{
					16.15 = 15.39();
				}
				16.43(upsideDown);
				this.80(16, (double)num11, (double)(0f - this.85(16)), 0f, 0.0);
				this.67.Add(16);
				15.8.12(16);
			}
			num11 -= 1000;
			num12++;
		}
		foreach (2011 17 in this.41)
		{
			17.8.2(false);
		}
		if (flag)
		{
			1226.107();
		}
	}

	// Token: 0x060038AC RID: 14508 RVA: 0x00164394 File Offset: 0x00162594
	private void 80(1433 1, double 2, double 3, float 4, double 5)
	{
		int 6 = 1975.83(2, this.68);
		this.81(1, 2, 6, 3, 4);
		this.82(1, 2, 6, 3, 4, 5);
		1.3.Sort();
	}

	// Token: 0x060038AD RID: 14509 RVA: 0x001643D4 File Offset: 0x001625D4
	private void 81(1433 1, double 2, int 3, double 4, float 5)
	{
		double num = (double)this.41.4.HitPosition;
		double num2 = Math.Min(4, 0.0);
		for (int i = 3; i >= 0; i--)
		{
			double num3 = this.68[i].3;
			double num4 = num - 2009.6(this.68[i].1, 2 - num3);
			if (num3 != 2)
			{
				if (num4 < num2)
				{
					num3 = 2 - 2009.8(this.68[i].1, num - num2);
					num4 = num2;
				}
				1.3.Add(new 1445(1456.MovementY, this.84((float)(num4 + (double)5)), this.84((float)(num + (double)5)), (int)num3, (int)2, (1046)0)
				{
					16 = 1
				});
				if (num4 == num2)
				{
					break;
				}
				2 = num3;
				num = num4;
			}
		}
	}

	// Token: 0x060038AE RID: 14510 RVA: 0x001644B4 File Offset: 0x001626B4
	private void 82(1433 1, double 2, int 3, double 4, float 5, double 6)
	{
		double num = (double)this.41.4.HitPosition;
		double num2 = double.PositiveInfinity;
		double num3 = 2 + 6;
		byte 7 = 2;
		int num4 = 3;
		while (num4 + 1 < this.68.Count)
		{
			for (;;)
			{
				double num5 = Math.Min(this.68[num4 + 1].3, num3);
				double num6 = num + 2009.6(this.68[num4].1, num5 - 2);
				if (2 != num5)
				{
					if (num6 > num2)
					{
						num5 = 2 + 2009.8(this.68[num4].1, num2 - num);
						num6 = num2;
					}
					1.3.Add(new 1445(1456.MovementY, this.84((float)num + 5), this.84((float)num6 + 5), (int)2, (int)num5, (1046)0)
					{
						16 = 7
					});
					if (num6 == num2)
					{
						return;
					}
					2 = num5;
					num = num6;
				}
				if (num5 != num3)
				{
					break;
				}
				num2 = num6 - (double)this.41.4.HitPosition + 480.0 + Math.Max(4, 0.0);
				num3 = double.PositiveInfinity;
				7 = 3;
			}
			num4++;
		}
	}

	// Token: 0x060038AF RID: 14511 RVA: 0x001645F8 File Offset: 0x001627F8
	private static int 83(double 1, List<1259> 2)
	{
		1259 3 = new 1259();
		3.3 = 1;
		3.2(true);
		1259 item = 3;
		int num = 2.BinarySearch(item);
		if (num < 0)
		{
			num = ~num;
		}
		if (--num < 0)
		{
			num = 0;
		}
		return num;
	}

	// Token: 0x060038B0 RID: 14512 RVA: 0x00164633 File Offset: 0x00162833
	internal float 84(float 1)
	{
		1 = (this.41.32() ? (480f - 1) : 1);
		return 1 * this.41.37();
	}

	// Token: 0x060038B1 RID: 14513 RVA: 0x0016465B File Offset: 0x0016285B
	internal float 85(1433 1)
	{
		return Math.Abs((float)1.34 / 1.6f * 1.15 * 1.20.Y / this.41.37());
	}

	// Token: 0x060038B2 RID: 14514 RVA: 0x00164690 File Offset: 0x00162890
	internal override void RebuildTimeWindowObjects()
	{
		int num = this.34.BinarySearch(new 2071(this, 1226.16 - this.2 - 200));
		if (num < 0)
		{
			num = ~num;
		}
		int num2 = num;
		while (num2 < this.35 - 1 && this.34[num2].1 <= 1226.16 + 300)
		{
			num2++;
		}
		if (num == this.35)
		{
			this.36.Clear();
			return;
		}
		this.36 = this.34.GetRange(num, 1 + num2 - num);
	}

	// Token: 0x060038B3 RID: 14515 RVA: 0x00164728 File Offset: 0x00162928
	internal override void UpdateTimeWindowObjects()
	{
		2486.8 = false;
		bool[] array = new bool[this.41.19.Count];
		1979[] array2 = new 1979[this.41.19.Count];
		2241 <<EMPTY_NAME>> = 2486.88;
		bool flag = ((<<EMPTY_NAME>> != null) ? <<EMPTY_NAME>>.39 : null) != null;
		if (flag)
		{
			bool[] array3 = new bool[this.41.19.Count];
			for (int i = this.36.Count - 1; i >= 0; i--)
			{
				1979 2 = (1979)this.36[i];
				1979 3 = array2[2.44];
				if (!array3[2.44])
				{
					if (2.11)
					{
						array3[2.44] = true;
					}
					else if (array2[2.44] == null || 1226.16 < 2.1)
					{
						array2[2.44] = 2;
					}
					else
					{
						int num = Math.Min(2.1 + this.3, 3.1 - 1);
						num += Math.Max(0, 3.1 - 2.1 - this.3 - this.3);
						if (1226.16 <= num)
						{
							array2[2.44] = 2;
						}
						array3[2.44] = true;
					}
				}
			}
		}
		foreach (2034 4 in this.36)
		{
			1979 5 = (1979)4;
			1978 6 = 5 as 1978;
			5.Update();
			if (5.11)
			{
				if (!flag && 5.1 > 1226.16)
				{
					array[5.44] = true;
				}
			}
			else if (!array[5.44] && 1226.16 >= 5.1 - this.58 && !this.86(4))
			{
				if (5.44.23() && !5.44.18)
				{
					if (!flag || 5 == array2[5.44])
					{
						if (5.46 == (1983)0 || 5.46 == (1983)2)
						{
							5.49 = true;
							5.47 = 1226.16;
							array[5.44] = true;
							this.71[5.44] = null;
							2486.7.48(5, null);
							this.JudgeHitObject(5);
						}
						else if (5.46 == (1983)1 && !5.49)
						{
							2486.8 = true;
							5.47 = 1226.16;
							array[5.44] = true;
							this.71[5.44] = null;
							5.49 = true;
							6.69++;
							if (6.69 <= 1)
							{
								2486.7.48(5, null);
							}
							this.90(6);
							5.44.22(true);
						}
					}
				}
				else if (5.44.23() && 5.44.18)
				{
					if (5.46 == (1983)1 && 5.49)
					{
						array[5.44] = true;
						this.71[5.44] = null;
						this.89(6);
						2486.8 = true;
						5.44.22(true);
					}
				}
				else if (!5.44.23())
				{
					if (5.46 == (1983)1)
					{
						if (5.49)
						{
							5.49 = false;
							5.48 = 1226.16;
							6.70++;
							if (6.70 <= 1)
							{
								2486.7.48(5, new int?(1226.16 - 5.2));
							}
							this.JudgeHitObject(5);
						}
						else if (!6.53)
						{
							this.JudgeHitObject(5);
						}
					}
					5.44.22(false);
				}
			}
		}
		if (2486.7.80 != (707)2)
		{
			return;
		}
		1975.1977 7 = new 1975.1977();
		7.1 = 0;
		while (7.1 < this.41.19.Count)
		{
			1995 8 = this.41.19[7.1];
			if (8.23() && !8.18)
			{
				this.73[7.1] = 1226.16;
			}
			else if (!8.23() && 8.18 && this.73[7.1] != 0)
			{
				int num2 = 1226.16 - this.73[7.1];
				if (num2 < 20)
				{
					this.74 += 2;
				}
				else if (num2 < 38)
				{
					this.74++;
				}
				if (num2 < 100)
				{
					this.75++;
				}
			}
			if (!array[7.1] && 8.23() && !8.18)
			{
				if (this.71[7.1] == null)
				{
					1979 9 = (1979)this.34.Find(new Predicate<2034>(7.1));
					this.71[7.1] = 9;
				}
				if (this.71[7.1] != null)
				{
					this.71[7.1].PlayHitSound();
				}
			}
			7.1++;
		}
	}

	// Token: 0x060038B4 RID: 14516 RVA: 0x00164D58 File Offset: 0x00162F58
	private bool 86(2034 1)
	{
		1979 2 = (1979)1;
		1978 3 = 2 as 1978;
		float num = (float)this.4;
		2241 4 = 2486.88;
		if (((4 != null) ? 4.39 : null) != null && 3 != null)
		{
			num *= 1.5f;
			if (1226.16 >= 3.1 + this.4 && !3.71)
			{
				this.90(3);
			}
		}
		if ((float)1226.16 >= (float)2.2 + num && !2.11)
		{
			this.JudgeHitObject(2);
			return true;
		}
		return false;
	}

	// Token: 0x060038B5 RID: 14517 RVA: 0x00164DE4 File Offset: 0x00162FE4
	internal void 87(1978 1)
	{
		1.52.3.RemoveAll(new Predicate<1445>(1975.1976.instance.6));
		float num = this.84((float)this.41.4.HitPosition);
		int num2 = 1.2 + this.3;
		1.52.3.Method11157(new 1445(1456.MovementY, num, num, num2, num2, (1046)0)
		{
			16 = 4
		});
		1371 2 = 1.64;
		1371 3 = 1.63;
		1058? 4 = new 1058?(1.44.1().48(0f, (float)this.41.4.HitPosition - this.85(1.52) / 2f));
		3.6(4);
		2.6(4);
		1.66 = true;
	}

	// Token: 0x060038B6 RID: 14518 RVA: 0x00164EC0 File Offset: 0x001630C0
	internal void 88(1978 1)
	{
		if (!1.66)
		{
			return;
		}
		1.52.3.RemoveAll(new Predicate<1445>(1975.1976.instance.7));
		int num = 1.67 ? 1.68 : Math.Max(1.1, 1226.16);
		this.82(1.52, (double)num, 1975.83((double)num, this.68), (double)this.85(1.52), 0f, 0.0);
		1.52.3.Sort();
		1058 2 = 1.63.5().Value;
		foreach (1445 3 in 1.52.3)
		{
			if (3.14 == 1456.MovementY && 3.16 == 3)
			{
				float num2 = 3.5 - 3.1;
				1058 4 = new 1058(2.X, 2.Y + Math.Min(num2, 0f), 2.Width, 2.Height + Math.Abs(num2));
				1445 item = new 1445(2, 4, 3.9, 3.10, (1046)0);
				1.63.3.Add(item);
				1.64.3.Add(item);
				2 = 4;
			}
		}
		1.63.3.Sort();
		1.64.3.Sort();
		1.66 = false;
		1.67 = true;
		1.68 = num;
	}

	// Token: 0x060038B7 RID: 14519 RVA: 0x00165098 File Offset: 0x00163298
	internal 2149 89(1978 1)
	{
		this.38 = 1;
		2149 2 = 1.12();
		if (2 > (2149)0)
		{
			base.32(2, string.Empty, 1);
		}
		return 2;
	}

	// Token: 0x060038B8 RID: 14520 RVA: 0x001650C8 File Offset: 0x001632C8
	internal 2149 90(1978 1)
	{
		this.38 = 1;
		2149 2 = 1.13();
		if (2 == (2149)0)
		{
			return 2;
		}
		if (this.41.4.SeparateScore)
		{
			1.44.1().18(2);
		}
		else
		{
			foreach (2011 3 in this.41)
			{
				3.18(2);
			}
		}
		if (2 > (2149)0)
		{
			2486.7.OnObjectHit(1);
			1.44.15();
		}
		base.32(2, string.Empty, 1);
		return 2;
	}

	// Token: 0x060038B9 RID: 14521 RVA: 0x00165174 File Offset: 0x00163374
	internal override 2149 JudgeHitObject(2034 1)
	{
		if (1.11)
		{
			return (2149)0;
		}
		this.38 = 1;
		2149 2 = 1.GetOrCalculateJudgement();
		int num = this.34.BinarySearch(1);
		this.31 = ((num < 0) ? (~num) : num);
		if (2 == (2149)0)
		{
			return 2;
		}
		if (this.70 && 2 < (2149)134217728)
		{
			2 = (2149)(-65536);
		}
		1979 3 = (1979)1;
		if (this.41.4.SeparateScore)
		{
			3.44.1().18(2);
		}
		else
		{
			foreach (2011 4 in this.41)
			{
				4.18(2);
			}
		}
		if (2 > (2149)0)
		{
			2486.7.OnObjectHit(1);
			3.44.15();
		}
		3.44.22(false);
		base.32(2, string.Empty, 1);
		return 2;
	}

	// Token: 0x040029CD RID: 10701
	internal int 58 = 178;

	// Token: 0x040029CE RID: 10702
	internal new int 59 = 20;

	// Token: 0x040029CF RID: 10703
	internal new int 60 = 60;

	// Token: 0x040029D0 RID: 10704
	internal new int 61 = int.MaxValue;

	// Token: 0x040029D1 RID: 10705
	internal new int 62 = int.MinValue;

	// Token: 0x040029D2 RID: 10706
	internal new int 63 = int.MinValue;

	// Token: 0x040029D3 RID: 10707
	internal new int 64;

	// Token: 0x040029D4 RID: 10708
	internal new int 65;

	// Token: 0x040029D5 RID: 10709
	internal new int 66;

	// Token: 0x040029D6 RID: 10710
	protected new List<1433> 67;

	// Token: 0x040029D7 RID: 10711
	private new List<1259> 68;

	// Token: 0x040029D8 RID: 10712
	private new List<1259> 69;

	// Token: 0x040029D9 RID: 10713
	private new bool 70;

	// Token: 0x040029DA RID: 10714
	private new 1979[] 71;

	// Token: 0x040029DB RID: 10715
	private new int[] 72;

	// Token: 0x040029DC RID: 10716
	private new int[] 73;

	// Token: 0x040029DD RID: 10717
	internal new int 74;

	// Token: 0x040029DE RID: 10718
	private int 75;

	// Token: 0x040029DF RID: 10719
	private 2034 76;

	// Token: 0x040029E0 RID: 10720
	private readonly bool 77;

	// Token: 0x0200078A RID: 1930
	[Serializable]
	public sealed class 1976
	{
		// Token: 0x060038BA RID: 14522 RVA: 0x001411E5 File Offset: 0x0013F3E5
		internal void 1(1433 1)
		{
			1.3.Clear();
		}

		// Token: 0x060038BB RID: 14523 RVA: 0x00165270 File Offset: 0x00163470
		internal void 2(1433 1)
		{
			1.3.RemoveAll(new Predicate<1445>(1975.1976.instance.3));
		}

		// Token: 0x060038BC RID: 14524 RVA: 0x0016528E File Offset: 0x0016348E
		internal bool 3(1445 1)
		{
			return (1.14 & (1456.MovementY | 1456.ClipRectangle)) > 1456.None;
		}

		// Token: 0x060038BD RID: 14525 RVA: 0x0016529F File Offset: 0x0016349F
		internal bool 4(1445 1)
		{
			return 1.14 == 1456.MovementY && 1.16 == 2;
		}

		// Token: 0x060038BE RID: 14526 RVA: 0x0016529F File Offset: 0x0016349F
		internal bool 5(1445 1)
		{
			return 1.14 == 1456.MovementY && 1.16 == 2;
		}

		// Token: 0x060038BF RID: 14527 RVA: 0x001652B9 File Offset: 0x001634B9
		internal bool 6(1445 1)
		{
			return 1.14 == 1456.MovementY && 1.16 == 3;
		}

		// Token: 0x060038C0 RID: 14528 RVA: 0x001652D3 File Offset: 0x001634D3
		internal bool 7(1445 1)
		{
			return 1.14 == 1456.MovementY && 1.16 == 4;
		}

		// Token: 0x040029E1 RID: 10721
		public static readonly 1975.1976 instance = new 1975.1976();

		// Token: 0x040029E2 RID: 10722
		public static Action<1433> action;

		// Token: 0x040029E3 RID: 10723
		public static Predicate<1445> predicate;

		// Token: 0x040029E4 RID: 10724
		public static Action<1433> action2;

		// Token: 0x040029E5 RID: 10725
		public static Predicate<1445> predicate2;

		// Token: 0x040029E6 RID: 10726
		public static Predicate<1445> predicate3;

		// Token: 0x040029E7 RID: 10727
		public static Predicate<1445> predicate4;

		// Token: 0x040029E8 RID: 10728
		public static Predicate<1445> predicate5;
	}

	// Token: 0x0200078B RID: 1931
	public sealed class 1977
	{
		// Token: 0x060038C3 RID: 14531 RVA: 0x001652F9 File Offset: 0x001634F9
		internal bool 1(2034 1)
		{
			return 1.1 > 1226.16 && ((1979)1).44 == this.1;
		}

		// Token: 0x040029E9 RID: 10729
		public int 1;
	}
}
