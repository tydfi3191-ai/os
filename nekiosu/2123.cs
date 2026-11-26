using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using OpenTK.Graphics.ES20;

// Token: 0x02000715 RID: 1813
[276]
public class 2123 : 2063
{
	// Token: 0x0600356A RID: 13674 RVA: 0x0014A558 File Offset: 0x00148758
	internal 2123(2039 1, 208 2, int 3, bool 4, 1245 5, 2064 6, int 7, double 8, List<208> 9, List<1245> 10, int 11 = 0) : base(1)
	{
		this.51 = 6;
		this.63 = 6;
		this.16 = 11;
		this.50 = this.28.39;
		this.1 = 3;
		this.2 = 3;
		this.8 = 2;
		this.18 = 2;
		this.SetEndPosition(2);
		this.4 = 5;
		this.22(7);
		if (9 == null)
		{
			this.54 = new List<208>();
			this.54.Add(this.8);
		}
		else
		{
			this.54 = 9;
			if (this.54.Count > 0)
			{
				if (this.54[0] != this.8)
				{
					this.54.Insert(0, this.8);
				}
			}
			else
			{
				this.54.Add(this.8);
			}
		}
		this.5 = Math.Max(1, 7);
		this.73 = (10 == null || 10.Count == 0);
		if (!this.73)
		{
			this.84 = 10;
			this.85 = new List<1254>(7 + 1);
			this.86 = new List<1254>(7 + 1);
		}
		this.6 = 8;
		this.38 = true;
		this.48 = new List<2066>();
		this.3 = 2047.Slider;
		if (4)
		{
			this.3 |= 2047.NewCombo;
		}
		if (this.50 != null)
		{
			this.CreateHeadCircle();
			this.49 = new 1351(1455.5("sliderfollowcircle", (1416)7, true), (1376)1, 1065.Centre, (1044)1, this.8, 0.99f, false, 198.TransparentWhite, this);
			this.49.61();
			1381[] array = 1455.5("sliderb", (1416)7, false);
			bool flag = array[0].6 == (1416)1;
			this.45 = new 1351(array, (1376)1, 1065.Centre, (1044)1, this.8, 0.99f, false, flag ? 2630.19("SliderBall", true) : 198.White, this);
			this.45.53 = true;
			if (flag)
			{
				this.46 = new 1433(1455.2("sliderb-spec", (1416)7, null), (1376)1, 1065.Centre, (1044)1, this.8, 1f, false, 198.White, null)
				{
					28 = true
				};
				this.47 = new 1433(1455.2("sliderb-nd", (1416)7, null), (1376)1, 1065.Centre, (1044)1, this.8, 0.98f, false, new 198(5, 5, 5), null);
			}
			this.53 = new 1433(null, (1376)5, 1065.TopLeft, (1044)1, this.8, 1436.32((float)(this.2 + 10)), false, 198.White, null)
			{
				27 = false
			};
		}
	}

	// Token: 0x0600356B RID: 13675 RVA: 0x0014A864 File Offset: 0x00148A64
	static 2123()
	{
		for (int i = 0; i < 8; i++)
		{
			2123.32();
		}
		1662.76(new 1189(2123.2127.Instance.4));
	}

	// Token: 0x0600356C RID: 13676 RVA: 0x0014A8A1 File Offset: 0x00148AA1
	internal override void SetEndTime(int 1)
	{
		this.2 = 1;
	}

	// Token: 0x0600356D RID: 13677 RVA: 0x0014A8AC File Offset: 0x00148AAC
	internal override List<1433> CreateLightingSprites()
	{
		List<1433> <<EMPTY_NAME>> = this.42;
		if (<<EMPTY_NAME>> != null)
		{
			<<EMPTY_NAME>>.ForEach(new Action<1433>(2123.2127.Instance.1));
		}
		List<1433> list = new List<1433>();
		list.Add(this.53.Clone());
		List<1433> result = list;
		this.42 = list;
		return result;
	}

	// Token: 0x0600356E RID: 13678 RVA: 0x0014A8F9 File Offset: 0x00148AF9
	internal override void ResetJudgementState()
	{
		base.ResetJudgementState();
		this.StopHitSounds();
		this.58.ResetJudgementState();
		this.79 = 0;
	}

	// Token: 0x0600356F RID: 13679 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void Shake()
	{
	}

	// Token: 0x06003570 RID: 13680 RVA: 0x0014A91C File Offset: 0x00148B1C
	protected virtual void CreateHeadCircle()
	{
		this.58 = new 2061(this.28, new 208((float)((int)this.8.X), (float)((int)this.8.Y)), this.1, this.IsNewCombo(), this.73 ? this.4 : this.84[0], this.16);
	}

	// Token: 0x06003571 RID: 13681 RVA: 0x0014A988 File Offset: 0x00148B88
	internal override 2034 Clone()
	{
		List<1245> list = null;
		if (this.84 != null)
		{
			list = new List<1245>();
			list.AddRange(this.84);
		}
		List<208> list2 = new List<208>();
		list2.AddRange(this.54);
		2123 <<EMPTY_NAME>> = new 2123(this.28, this.8, this.1, this.3.1(2047.NewCombo), this.4, this.51, this.5, this.6, list2, list, this.16);
		<<EMPTY_NAME>>.18 = this.18;
		<<EMPTY_NAME>>.SetComboNumber(this.GetComboNumber());
		<<EMPTY_NAME>>.82 = new List<int>(this.82);
		<<EMPTY_NAME>>.2 = this.2;
		<<EMPTY_NAME>>.SetEndPosition(this.GetEndPosition());
		<<EMPTY_NAME>>.4(base.3());
		<<EMPTY_NAME>>.12(this.11());
		<<EMPTY_NAME>>.17 = this.17;
		<<EMPTY_NAME>>.63 = this.63;
		<<EMPTY_NAME>>.35 = this.35;
		<<EMPTY_NAME>>.36 = this.36;
		<<EMPTY_NAME>>.34 = this.34;
		<<EMPTY_NAME>>.32 = this.32;
		<<EMPTY_NAME>>.33 = this.33;
		<<EMPTY_NAME>>.SetCurrentPosition(this.GetCurrentPosition());
		<<EMPTY_NAME>>.SetComboColour(this.7);
		if (this.85 != null)
		{
			<<EMPTY_NAME>>.85 = new List<1254>(this.85);
		}
		if (this.86 != null)
		{
			<<EMPTY_NAME>>.86 = new List<1254>(this.86);
		}
		return <<EMPTY_NAME>>;
	}

	// Token: 0x06003572 RID: 13682 RVA: 0x0014AAFF File Offset: 0x00148CFF
	protected override void Dispose(bool 1)
	{
		if (1)
		{
			this.36();
			this.35();
			if (this.53 != null)
			{
				this.53.27 = true;
				this.53.Dispose();
			}
		}
		base.Dispose(1);
	}

	// Token: 0x06003573 RID: 13683 RVA: 0x0014AB38 File Offset: 0x00148D38
	internal new List<2033> 9()
	{
		List<2033> list = new List<2033>();
		list.Add(this.58);
		this.48.ForEach(new Action<2066>(list.Add));
		return list;
	}

	// Token: 0x06003574 RID: 13684 RVA: 0x0014AB70 File Offset: 0x00148D70
	[CompilerGenerated]
	public override 208 GetEndPosition()
	{
		return this.59;
	}

	// Token: 0x06003575 RID: 13685 RVA: 0x0014AB78 File Offset: 0x00148D78
	[CompilerGenerated]
	public override void SetEndPosition(208 1)
	{
		this.59 = 1;
	}

	// Token: 0x06003576 RID: 13686 RVA: 0x0014AB81 File Offset: 0x00148D81
	public override int GetComboNumber()
	{
		return this.58.GetComboNumber();
	}

	// Token: 0x06003577 RID: 13687 RVA: 0x0014AB8E File Offset: 0x00148D8E
	public override void SetComboNumber(int 1)
	{
		this.58.SetComboNumber(1);
	}

	// Token: 0x06003578 RID: 13688 RVA: 0x0014AB9C File Offset: 0x00148D9C
	internal override bool IsActive()
	{
		return 1226.16 >= this.1 - this.28.2 && 1226.16 <= this.2 + 2039.14;
	}

	// Token: 0x06003579 RID: 13689 RVA: 0x0014ABD0 File Offset: 0x00148DD0
	internal override void Update()
	{
		base.Update();
		if (1662.78 == 1677.Edit || this.68)
		{
			this.RebuildPathAndTiming(false);
		}
		if (this.83.Count > 0)
		{
			int num = this.83.Count / this.5;
			this.45.SetIsReversed(((this.79 + num + 1) / num & 1) == 0);
			this.45.45((this.79 + num + 1) / num % 2 == 0 && 2630.5.SliderBallFlip);
			this.45.53(Math.Max(150.0 / this.87 * 16.666666666666668, 16.666666666666668));
		}
		int num2 = -1;
		int num3 = 0;
		while (num3 < this.83.Count - 1 && this.83[num3] <= 1226.16)
		{
			num2 = num3;
			num3++;
		}
		if (1226.16 < this.1 || 1226.16 > this.2 || 1226.32 != (1042)1)
		{
			this.79 = -1;
			return;
		}
		if (!this.78)
		{
			this.StopHitSounds();
			this.79 = num2;
			return;
		}
		this.44();
		if (num2 <= this.79)
		{
			return;
		}
		this.79 = num2;
		if ((this.79 + 1) % (this.83.Count / this.5) > 0)
		{
			this.42(true, this.79);
		}
		else
		{
			this.42(false, (this.79 + 1) / (this.83.Count / this.5));
		}
		1433 <<EMPTY_NAME>> = this.30.Find((1433 1) => 1.9 == this.83[this.79]);
		if (<<EMPTY_NAME>> != null && <<EMPTY_NAME>>.3.Count > 1)
		{
			1445 2 = <<EMPTY_NAME>>.3.Find(new Predicate<1445>(2123.2127.Instance.3));
			if (2 != null)
			{
				2.9 = this.83[this.79];
				2.10 = this.83[this.79];
			}
		}
		this.79 = num2;
	}

	// Token: 0x0600357A RID: 13690 RVA: 0x0014ADF8 File Offset: 0x00148FF8
	internal virtual void RebuildPathAndTiming(bool 1)
	{
		1 |= (this.6 == 0.0 || this.55 == null || this.68);
		if (!1)
		{
			return;
		}
		int num = -1;
		if (base.GetDuration() >= this.28.9)
		{
			num = base.GetDuration();
		}
		this.36();
		if (!this.62)
		{
			this.87 = this.28.GetSliderVelocityAt(this.1);
		}
		List<1051> list = new List<1051>();
		if (this.68)
		{
			if (this.54.Contains(this.69))
			{
				this.68 = false;
			}
			else
			{
				this.54.Add(this.69);
			}
		}
		switch (this.51)
		{
		case 2064.Catmull:
			for (int i = 0; i < this.54.Count - 1; i++)
			{
				208 2 = (i - 1 >= 0) ? this.54[i - 1] : this.54[i];
				208 3 = this.54[i];
				208 4 = (i + 1 < this.54.Count) ? this.54[i + 1] : (3 + (3 - 2));
				208 5 = (i + 2 < this.54.Count) ? this.54[i + 2] : (4 + (4 - 3));
				for (int j = 0; j < 50; j++)
				{
					list.Add(new 1051(208.CatmullRom(2, 3, 4, 5, (float)j / 50f), 208.CatmullRom(2, 3, 4, 5, (float)(j + 1) / 50f)));
				}
				list[list.Count - 1].3 = true;
			}
			this.63 = 2064.Catmull;
			goto IL_8AA;
		case 2064.Bezier:
			break;
		case 2064.Linear:
			goto IL_7B2;
		case 2064.PerfectCurve:
			if (this.54.Count < 3)
			{
				goto IL_7B2;
			}
			if (this.54.Count <= 3)
			{
				208 6 = this.54[0];
				208 7 = this.54[1];
				208 8 = this.54[2];
				if (!1052.3(6, 7, 8))
				{
					208 9;
					float num2;
					double num3;
					double num4;
					1052.5(6, 7, 8, out 9, out num2, out num3, out num4);
					if (1662.78 == 1677.Edit)
					{
						1057 10 = new 1057(new 208[]
						{
							1052.7(9, num2, num3),
							1052.7(9, num2, num4)
						});
						double num5 = Math.Min(num3, num4);
						double num6 = Math.Max(num3, num4);
						int num7 = (int)(num5 * 2.0 / 3.141592653589793 + 1.0);
						while ((double)((float)num7 * 0.5f) * 3.141592653589793 < num6)
						{
							10.3(1052.7(9, num2, (double)((float)num7 * 0.5f) * 3.141592653589793));
							num7++;
						}
						if ((this.68 && (10.1().Value > 512f || 10.2().Value > 384f)) || 10.1().Value > 640f || 10.2().Value > 640f)
						{
							break;
						}
					}
					this.56 = Math.Abs((num4 - num3) * (double)num2);
					int num8 = (int)(this.56 * 0.125);
					208 11 = 6;
					for (int k = 1; k < num8; k++)
					{
						double num9 = (double)k / (double)num8;
						double 12 = num4 * num9 + num3 * (1.0 - num9);
						208 13 = 1052.7(9, num2, 12);
						list.Add(new 1051(11, 13));
						11 = 13;
					}
					list.Add(new 1051(11, 8));
					this.63 = 2064.PerfectCurve;
					goto IL_8AA;
				}
				this.63 = 2064.PerfectCurve;
				goto IL_7B2;
			}
			break;
		default:
			goto IL_8AA;
		}
		int num10 = 0;
		for (int l = 0; l < this.54.Count; l++)
		{
			if (this.28.21.32 > 8)
			{
				bool flag = l < this.54.Count - 2 && this.54[l] == this.54[l + 1];
				if (flag || l == this.54.Count - 1)
				{
					List<208> range = this.54.GetRange(num10, l - num10 + 1);
					if (range.Count == 2)
					{
						1051 14 = new 1051(range[0], range[1]);
						int num11 = 1;
						for (int m = 0; m < num11; m++)
						{
							list.Add(new 1051(14.1 + (14.2 - 14.1) * ((float)m / (float)num11), 14.1 + (14.2 - 14.1) * ((float)(m + 1) / (float)num11))
							{
								4 = true
							});
						}
					}
					else if (this.28.21.32 < 10)
					{
						List<208> list2 = 1052.2(range);
						for (int n = 1; n < list2.Count; n++)
						{
							list.Add(new 1051(list2[n - 1], list2[n]));
						}
					}
					else
					{
						List<208> list3 = 1052.1(range);
						for (int num12 = 1; num12 < list3.Count; num12++)
						{
							list.Add(new 1051(list3[num12 - 1], list3[num12]));
						}
					}
					list[list.Count - 1].3 = true;
					if (flag)
					{
						l++;
					}
					num10 = l;
				}
			}
			else if (this.28.21.32 > 6)
			{
				bool flag2 = l < this.54.Count - 2 && this.54[l] == this.54[l + 1];
				if (flag2 || l == this.54.Count - 1)
				{
					List<208> list4 = 1052.1(this.54.GetRange(num10, l - num10 + 1));
					for (int num13 = 1; num13 < list4.Count; num13++)
					{
						list.Add(new 1051(list4[num13 - 1], list4[num13]));
					}
					list[list.Count - 1].3 = true;
					if (flag2)
					{
						l++;
					}
					num10 = l;
				}
			}
			else if ((l > 0 && this.54[l] == this.54[l - 1]) || l == this.54.Count - 1)
			{
				List<208> list5 = 1052.1(this.54.GetRange(num10, l - num10 + 1));
				for (int num14 = 1; num14 < list5.Count; num14++)
				{
					list.Add(new 1051(list5[num14 - 1], list5[num14]));
				}
				list[list.Count - 1].3 = true;
				num10 = l;
			}
		}
		this.63 = 2064.Bezier;
		goto IL_8AA;
		IL_7B2:
		for (int num15 = 1; num15 < this.54.Count; num15++)
		{
			1051 15 = new 1051(this.54[num15 - 1], this.54[num15]);
			int num16 = 1;
			for (int num17 = 0; num17 < num16; num17++)
			{
				list.Add(new 1051(15.1 + (15.2 - 15.1) * ((float)num17 / (float)num16), 15.1 + (15.2 - 15.1) * ((float)(num17 + 1) / (float)num16))
				{
					4 = true
				});
			}
			list[list.Count - 1].3 = true;
		}
		if (this.51 == 2064.Linear || this.54.Count < 3)
		{
			this.63 = 2064.Linear;
		}
		IL_8AA:
		double num18 = 0.0;
		int count = list.Count;
		for (int num19 = 0; num19 < count; num19++)
		{
			num18 += (double)list[num19].1();
		}
		this.56 = num18;
		int num20 = 0;
		double num21 = (this.28.21.32 < 8) ? this.28.6 : (this.28.6 / (double)this.28.21.91((double)this.1));
		if (num18 > 0.0)
		{
			if (this.68 || this.6 == 0.0)
			{
				if (2263.4 != null && 2263.23())
				{
					double num22 = num21 * this.28.21.6 / (double)2263.4.96();
					num20 = (int)Math.Max(0.0, (num18 + 1.0) / num22);
					this.6 = (double)num20 * num22;
				}
				else
				{
					num20 = (int)(num18 / num21);
					this.6 = num18;
				}
			}
			if (num21 > this.6)
			{
				num21 = this.6;
			}
			if (this.71)
			{
				this.72 = num20;
				this.71 = false;
			}
			double num23 = num18 - this.6;
			while (list.Count > 0)
			{
				1051 16 = list[list.Count - 1];
				float num24 = 208.Distance(16.1, 16.2);
				if ((double)num24 > num23 + 0.0001)
				{
					if (16.2 != 16.1)
					{
						16.2 = 16.1 + 208.Normalize(16.2 - 16.1) * (16.1() - (float)num23);
						break;
					}
					break;
				}
				else
				{
					list.Remove(16);
					num23 -= (double)num24;
				}
			}
		}
		if (this.68)
		{
			if (num20 == this.72 && num20 != 0)
			{
				this.54.RemoveAt(this.54.Count - 1);
				this.70 = false;
			}
			else
			{
				this.70 = true;
			}
			this.68 = false;
		}
		count = list.Count;
		if (count > 0)
		{
			this.55 = list;
			if (this.57 == null)
			{
				this.57 = new List<double>(count);
			}
			else
			{
				this.57.Clear();
			}
			num18 = 0.0;
			foreach (1051 17 in list)
			{
				num18 += (double)17.1();
				this.57.Add(num18);
			}
		}
		if (this.50 != null)
		{
			if (this.30.Count > 0)
			{
				this.50.20<1433>(this.30);
			}
			this.49.3.Clear();
			this.45.3.Clear();
			if (this.46 != null)
			{
				this.46.3.Clear();
			}
			if (this.47 != null)
			{
				this.47.3.Clear();
			}
			this.83.Clear();
			this.48.Clear();
		}
		if (count < 1)
		{
			return;
		}
		if (this.50 != null)
		{
			this.30.Clear();
			this.29.Clear();
			for (int num25 = 0; num25 < this.58.30.Count; num25++)
			{
				1433 18 = this.58.30[num25];
				18.8 = this;
				this.30.Add(18);
			}
			this.29.AddRange(this.58.29);
			this.30.Add(this.49);
			if (this.46 != null)
			{
				this.30.Add(this.46);
			}
			if (this.47 != null)
			{
				this.30.Add(this.47);
			}
			this.30.Add(this.45);
			if (list.Count > 2)
			{
				float num26 = (float)Math.Atan2((double)(list[0].1.Y - list[0].2.Y), (double)(list[0].1.X - list[0].2.X));
				this.45.43((double)num26 >= -1.5707963267948966 && (double)num26 <= 1.5707963267948966);
			}
		}
		bool flag3 = true;
		double num27 = 0.0;
		double num28 = (double)this.1;
		208 19 = default(208);
		208 20 = default(208);
		double num29 = 0.0;
		this.SetCurrentPosition(list[count - 1].2);
		2023 21 = this.28.22;
		2023 22 = 2023.Hidden;
		bool flag4 = 1929.3(21 & 22);
		for (int num30 = 0; num30 < this.5; num30++)
		{
			double num31 = num18;
			bool flag5 = false;
			int num32 = (int)num28;
			List<1433> list6 = new List<1433>();
			double num33 = 0.01 * this.87;
			bool flag6 = num30 % 2 == 1;
			int num34 = flag6 ? (count - 1) : 0;
			int num35 = flag6 ? -1 : count;
			int num36 = (!flag6) ? 1 : -1;
			for (int num37 = num34; num37 != num35; num37 += num36)
			{
				1051 23 = list[num37];
				float num38 = (float)(this.57[num37] - ((num37 == 0) ? 0.0 : this.57[num37 - 1]));
				if (flag6)
				{
					20 = 23.2;
					19 = 23.1;
				}
				else
				{
					20 = 23.1;
					19 = 23.2;
				}
				double num39 = (double)(1000f * num38) / this.87;
				if (this.50 != null)
				{
					1445 item = new 1445(20, 19, (int)num28, (int)(num28 + num39), (1046)0);
					this.49.3.Add(item);
					this.45.3.Add(item);
					if (this.46 != null)
					{
						this.46.3.Add(item);
					}
					if (this.47 != null)
					{
						this.47.3.Add(item);
					}
				}
				num28 += num39;
				num29 += (double)num38;
				while (num29 >= num21 && !flag5)
				{
					num27 += num21;
					num29 -= num21;
					num31 -= num21;
					flag5 = (num31 <= num33);
					if (flag5)
					{
						break;
					}
					int num40 = this.28((float)num27);
					this.83.Add(num40);
					if (this.50 != null)
					{
						float 24 = 1f - (float)(num29 / (double)208.Distance(20, 19));
						208 25 = 20 + (19 - 20) * 24;
						1433 26 = new 1433(1455.2("sliderscorepoint", (1416)7, null), (1376)1, 1065.Centre, (1044)1, 25, 1436.32((float)(this.1 - 5)), false, 198.White, this);
						if (26.GetTexture().6 == (1416)1)
						{
							26.28 = true;
						}
						if (flag3)
						{
							int num41 = (num40 - this.1) / 2 + this.1 - this.28.28;
							int num42 = num41 + 150;
							26.3.Add(new 1445(1456.Fade, 0f, 1f, num41, num42, (1046)0));
							if (flag4)
							{
								26.3.Add(new 1445(1456.Fade, 1f, 0f, Math.Max(num42, num40 - 1000), num40, (1046)0));
							}
							26.3.Add(new 1445(1456.Scale, 0.5f, 1.2f, num41, num42, (1046)0));
							26.3.Add(new 1445(1456.Scale, 1.2f, 1f, num42, num42 + 150, (1046)1));
						}
						else
						{
							int num43 = num32 + (num40 - num32) / 2;
							26.3.Add(new 1445(1456.Fade, 0f, 1f, num43 - 200, num43, (1046)0));
							if (flag4)
							{
								26.3.Add(new 1445(1456.Fade, 1f, 0f, Math.Max(num43, num40 - 1000), num40, (1046)0));
							}
							26.3.Add(new 1445(1456.Scale, 0.5f, 1.2f, num43 - 200, num43 - 50, (1046)0));
							26.3.Add(new 1445(1456.Scale, 1.2f, 1f, num43 - 50, num43 + 150, (1046)1));
						}
						float num44 = this.28.1 * this.28.1;
						if (1662.78 != 1677.Play || (208.DistanceSquared(25, this.GetCurrentPosition()) >= num44 && 208.DistanceSquared(25, this.8) >= num44))
						{
							this.30.Add(26);
							list6.Add(26);
						}
						26.9 = num40;
					}
				}
			}
			num27 += num29;
			this.83.Add(this.28((float)num27));
			if (flag5)
			{
				num29 = 0.0;
			}
			else
			{
				num27 -= num21 - num29;
				num29 = num21 - num29;
			}
			if (this.50 != null)
			{
				foreach (1433 27 in list6)
				{
					27.3.Add(new 1445(1456.Fade, 0f, 0f, (int)num28, (int)num28, (1046)0));
				}
			}
			float 28 = (float)Math.Atan2((double)(20.Y - 19.Y), (double)(20.X - 19.X));
			int 29 = flag3 ? (this.1 - (2123.39() ? this.28.28 : this.28.2)) : (num32 - (int)(num28 - (double)num32));
			if (this.50 != null)
			{
				2066 30 = new 2066(this.28, 19, (int)num28, 29, flag3, num30 < this.5 - 1, 28, this);
				30.SetComboColour(this.58.46.6);
				this.48.Add(30);
				if (flag3)
				{
					this.29.AddRange(30.29);
				}
				this.30.AddRange(30.30);
			}
			flag3 = false;
		}
		if (base.3() && this.48.Count > 0)
		{
			this.48[0].OnSelected();
		}
		this.SetEndPosition(19);
		this.2 = (int)num28;
		if (this.50 != null)
		{
			this.53.2 = 1436.32((float)(this.2 + 10));
			this.53.3.Clear();
			this.53.3.Add(new 1445(1456.Fade, 0f, 1f, this.1 - this.28.2, this.1 - this.28.2 + 2039.13, (1046)0));
			this.53.3.Add(flag4 ? new 1445(1456.Fade, 1f, 0f, this.1 - this.28.HiddenPreemptTime + 2039.13, this.2, (1046)1) : new 1445(1456.Fade, 1f, 0f, this.2, this.2 + 2039.14, (1046)0));
			this.30.Add(this.53);
			this.29.Add(this.53);
		}
		if (this.83.Count > 0)
		{
			this.83[this.83.Count - 1] = Math.Max(this.1 + base.GetDuration() / 2, this.83[this.83.Count - 1] - 36);
		}
		this.81 = new bool[this.83.Count];
		this.82.Clear();
		int num45 = this.83.Count / this.5;
		if (num45 > 0)
		{
			for (int num46 = 0; num46 < this.83.Count - 1; num46++)
			{
				if ((num46 + 1) % num45 == 0)
				{
					this.82.Add(this.83[num46]);
				}
			}
		}
		if (this.78)
		{
			this.49();
		}
		if (this.50 != null)
		{
			this.50.14<1433>(this.30);
		}
		this.ApplyComboColourFade();
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

	// Token: 0x0600357B RID: 13691 RVA: 0x0014C430 File Offset: 0x0014A630
	internal new bool 10()
	{
		return this.9().Find(new Predicate<2033>(2123.2127.Instance.2)) != null;
	}

	// Token: 0x0600357C RID: 13692 RVA: 0x0014C450 File Offset: 0x0014A650
	internal new bool 11()
	{
		return this.74;
	}

	// Token: 0x0600357D RID: 13693 RVA: 0x0014C458 File Offset: 0x0014A658
	internal void 12(bool 1)
	{
		if (1 != this.74)
		{
			this.74 = 1;
			this.36();
		}
	}

	// Token: 0x0600357E RID: 13694 RVA: 0x0014C470 File Offset: 0x0014A670
	internal override void OnSelected()
	{
		this.36();
		if (!this.58.3())
		{
			this.58.49.6 = 198.White;
			this.58.OnSelected();
		}
		if (this.48.Count > 0 && !this.48[0].3())
		{
			this.48[0].49.6 = 198.White;
			this.48[0].OnSelected();
		}
	}

	// Token: 0x0600357F RID: 13695 RVA: 0x0014C4FD File Offset: 0x0014A6FD
	internal override void OnDeselected()
	{
		this.74 = false;
		this.36();
		this.9().ForEach(new Action<2033>(2123.2127.Instance.5));
	}

	// Token: 0x06003580 RID: 13696 RVA: 0x0014C527 File Offset: 0x0014A727
	internal override void SetStartTime(int 1)
	{
		this.13(1, true);
	}

	// Token: 0x06003581 RID: 13697 RVA: 0x0014C531 File Offset: 0x0014A731
	internal new void 13(int 1, bool 2)
	{
		this.58.SetStartTime(1);
		this.1 = 1;
		if (2)
		{
			this.RebuildPathAndTiming(true);
			return;
		}
		this.2 = 1;
	}

	// Token: 0x06003582 RID: 13698 RVA: 0x0014C558 File Offset: 0x0014A758
	internal override void SetPosition(208 1, bool 2 = false)
	{
		2123.2124 3 = new 2123.2124();
		3.1 = 1 - this.8;
		base.SetPosition(1, 2);
		for (int i = 0; i < this.54.Count; i++)
		{
			List<208> list = this.54;
			int index = i;
			list[index] += 3.1;
		}
		if (this.55 != null)
		{
			for (int j = 0; j < this.55.Count; j++)
			{
				this.55[j].1 += 3.1;
				this.55[j].2 += 3.1;
			}
		}
		foreach (1433 4 in this.30)
		{
			if (4.41 == (1376)1)
			{
				4.7 += 3.1;
				4.17 += 3.1;
			}
			else
			{
				4.7 += 3.1 * 1662.70.3() * 1662.69.10();
				4.17 += 3.1 * 1662.70.3() * 1662.69.10();
			}
		}
		if (this.45 != null)
		{
			foreach (1445 5 in this.45.3)
			{
				if (5.14 == 1456.Movement)
				{
					5.2 += 3.1;
					5.6 += 3.1;
				}
			}
		}
		2033 6 = this.58;
		if (6 != null)
		{
			6.SetPosition(1, false);
		}
		this.48.ForEach(new Action<2066>(3.1));
		this.SetCurrentPosition(this.GetCurrentPosition() + 3.1);
		this.SetEndPosition(this.GetEndPosition() + 3.1);
	}

	// Token: 0x06003583 RID: 13699 RVA: 0x0014C7F0 File Offset: 0x0014A9F0
	internal new void 14(int 1)
	{
		int spanDuration = base.GetSpanDuration();
		if (spanDuration != 0 && 1 > this.1 && this.54.Count >= 2)
		{
			int num = 1;
			int i = this.1 + spanDuration;
			while (i < 1)
			{
				i += spanDuration;
				num++;
			}
			if (this.5 != num)
			{
				this.5 = num;
				this.RebuildPathAndTiming(true);
			}
			this.46();
		}
	}

	// Token: 0x06003584 RID: 13700 RVA: 0x0014C854 File Offset: 0x0014AA54
	internal new void 15(int 1)
	{
		int spanDuration = base.GetSpanDuration();
		if (spanDuration != 0 && 1 > this.1)
		{
			int num = 1;
			int i = this.1 + (int)((double)spanDuration * 1.5);
			while (i < 1)
			{
				i += spanDuration;
				num++;
			}
			if (this.5 != num)
			{
				this.5 = num;
				this.RebuildPathAndTiming(true);
			}
			this.47();
		}
	}

	// Token: 0x06003585 RID: 13701 RVA: 0x0014C8B8 File Offset: 0x0014AAB8
	internal new void 16(bool 1, bool 2)
	{
		2064 3 = this.51;
		this.51 = 2064.PerfectCurve;
		if (this.54.Count > 1)
		{
			if (!this.70 && !1 && 2)
			{
				this.54.RemoveAt(this.54.Count - 1);
			}
			else if (this.70 && this.55 != null)
			{
				this.70 = false;
				this.71 = true;
			}
			else if (!2 && !this.70 && this.54[this.54.Count - 1] != this.54[this.54.Count - 2])
			{
				this.54.Add(this.54[this.54.Count - 1]);
				this.70 = false;
				this.71 = true;
			}
		}
		if (1)
		{
			this.51 = this.63;
		}
		this.67 = !1;
		int 4 = this.54.Count - 1;
		bool flag = this.71;
		this.RebuildPathAndTiming(true);
		if (flag && this.6 > 0.0)
		{
			2263 5 = 2263.4;
			2458 6 = 5.8;
			6.15((2452)0, (2451)10, null);
			6.28(this, 4);
			6.29(3);
			5.2(true);
		}
	}

	// Token: 0x06003586 RID: 13702 RVA: 0x0014CA20 File Offset: 0x0014AC20
	internal new void 17(208 1)
	{
		if (this.67)
		{
			this.51 = 2064.PerfectCurve;
			if (this.70 && this.54[this.54.Count - 1] == this.69)
			{
				this.54.RemoveAt(this.54.Count - 1);
			}
			this.69 = 1;
			this.70 = false;
			this.68 = true;
		}
	}

	// Token: 0x06003587 RID: 13703 RVA: 0x0014CA98 File Offset: 0x0014AC98
	internal new void 18(208 1, int 2)
	{
		208 3 = this.54[2];
		if (2 < this.54.Count - 1 && this.54[2 + 1] == this.54[2])
		{
			this.54[2 + 1] = 1;
		}
		this.54[2] = 1;
		if (2 == 0)
		{
			this.18 = 1;
			this.8 = 1;
			this.58.SetPosition(1, false);
		}
		this.6 = 0.0;
		this.RebuildPathAndTiming(true);
		if (this.6 == 0.0)
		{
			this.54[2] = 3;
			if (2 == 0)
			{
				this.8 = (this.18 = 3);
				this.58.SetPosition(3, false);
			}
			this.6 = 0.0;
			this.RebuildPathAndTiming(true);
		}
		if (2 >= 0 && this.48.Count > 0)
		{
			this.48[0].OnDeselected();
		}
	}

	// Token: 0x06003588 RID: 13704 RVA: 0x0014CBAC File Offset: 0x0014ADAC
	internal new void 19(int 1, 208 2)
	{
		2064 3 = this.51;
		this.51 = 2064.PerfectCurve;
		this.54.Insert(1, 2);
		this.6 = 0.0;
		this.RebuildPathAndTiming(true);
		2263.4.8.15((2452)0, (2451)10, null);
		2263.4.8.28(this, 1);
		2263.4.8.29(3);
		2263.4.2(true);
	}

	// Token: 0x06003589 RID: 13705 RVA: 0x0014CC34 File Offset: 0x0014AE34
	internal new void 20()
	{
		if (this.51 == 2064.PerfectCurve && this.54.Count == 3)
		{
			208 <<EMPTY_NAME>> = this.54[0];
			208 2 = this.54[1];
			208 3 = this.54[2];
			if (!1052.3(<<EMPTY_NAME>>, 2, 3))
			{
				208 4;
				float 5;
				double num;
				double num2;
				1052.5(<<EMPTY_NAME>>, 2, 3, out 4, out 5, out num, out num2);
				bool flag = num > num2;
				for (num2 = 1052.6(this.GetCurrentPosition(), 4); num2 < num; num2 += 6.283185307179586)
				{
				}
				if (flag)
				{
					num2 -= 6.283185307179586;
				}
				208 6 = 1052.7(4, 5, num2);
				this.SetPosition(6, false);
				this.54[0] = 6;
				this.54[1] = 1052.7(4, 5, (num2 + num) * 0.5);
				this.54[2] = 1052.7(4, 5, num);
				goto IL_165;
			}
		}
		List<208> list = new List<208>(this.54);
		list.Reverse();
		if (this.56 + 1.0 <= this.6 || this.56 - 1.0 >= this.6)
		{
			list[0] = this.GetCurrentPosition();
		}
		this.SetPosition(list[0], false);
		this.54 = list;
		IL_165:
		this.RebuildPathAndTiming(true);
	}

	// Token: 0x0600358A RID: 13706 RVA: 0x0014CDAD File Offset: 0x0014AFAD
	public new int 21()
	{
		return this.43;
	}

	// Token: 0x0600358B RID: 13707 RVA: 0x0014CDB5 File Offset: 0x0014AFB5
	public new void 22(int 1)
	{
		this.43 = 1;
	}

	// Token: 0x0600358C RID: 13708 RVA: 0x0014CDBE File Offset: 0x0014AFBE
	public new List<2055> 23()
	{
		return this.44;
	}

	// Token: 0x0600358D RID: 13709 RVA: 0x0014CDC6 File Offset: 0x0014AFC6
	public new void 24(List<2055> 1)
	{
		this.44 = 1;
	}

	// Token: 0x0600358E RID: 13710 RVA: 0x0014CDD0 File Offset: 0x0014AFD0
	internal new int 25()
	{
		return (int)Math.Floor(this.6 * this.28.21.90((double)this.1, true) * (double)this.5 * 0.01 / this.28.21.5 + (double)this.1);
	}

	// Token: 0x0600358F RID: 13711 RVA: 0x0014CE30 File Offset: 0x0014B030
	internal int 26(int 1)
	{
		return (int)Math.Floor(this.6 * this.28.21.90((double)this.1, true) * (double)1 * 0.01 / this.28.21.5 + (double)this.1);
	}

	// Token: 0x06003590 RID: 13712 RVA: 0x0014CE88 File Offset: 0x0014B088
	internal new 208 27(double 1)
	{
		double num = 1052.20(1, 0.0, 1.0) * this.6;
		return this.29((float)num) - this.18;
	}

	// Token: 0x06003591 RID: 13713 RVA: 0x0014CEC8 File Offset: 0x0014B0C8
	internal virtual void GenerateSliderEvents()
	{
		double <<EMPTY_NAME>> = (this.28.21.32 < 8) ? this.28.6 : (this.28.6 / (double)this.28.21.91((double)this.1));
		double num = this.28.GetSliderVelocityAt(this.1) / 1000.0;
		double num2 = ((double)this.1 + (double)this.21() * this.6 / num - (double)this.1) / (double)this.21();
		foreach (2056 2 in 2057.1((double)this.1, num2, num, <<EMPTY_NAME>>, this.6, this.21()))
		{
			208 3 = this.27(2.5);
			switch (2.1)
			{
			case (2060)0:
			{
				List<2055> list = this.23();
				2069 4 = new 2069(this);
				4.1(2.3);
				4.2(2.4);
				4.SetTime(2.2);
				4.SetPosition(this.8 + 3);
				list.Add(4);
				break;
			}
			case (2060)2:
			{
				List<2055> list2 = this.23();
				2062 5 = new 2062(this);
				5.SetTime(2.2);
				5.SetPosition(this.8);
				list2.Add(5);
				break;
			}
			case (2060)3:
			{
				List<2055> list3 = this.23();
				2068 6 = new 2068(this);
				6.1(2.3);
				6.SetTime(2.2);
				6.SetPosition(this.GetEndPosition());
				list3.Add(6);
				break;
			}
			case (2060)4:
			{
				List<2055> list4 = this.23();
				2065 7 = new 2065(this);
				7.1(2.3);
				7.SetTime((double)this.1 + (double)(2.3 + 1) * num2);
				7.SetPosition(this.8 + 3);
				list4.Add(7);
				break;
			}
			}
		}
	}

	// Token: 0x06003592 RID: 13714 RVA: 0x0014D118 File Offset: 0x0014B318
	internal new int 28(float 1)
	{
		return (int)((double)this.1 + (double)1 / this.87 * 1000.0);
	}

	// Token: 0x06003593 RID: 13715 RVA: 0x0014D138 File Offset: 0x0014B338
	public override 208 GetPositionAtTime(int 1)
	{
		if (this.55 == null)
		{
			this.RebuildPathAndTiming(true);
		}
		if (1 < this.1 || 1 > this.2)
		{
			return base.GetPositionAtTime(1);
		}
		float num = (float)(1 - this.1) / ((float)base.GetDuration() / (float)this.5);
		num = ((num % 2f < 1f) ? (num % 1f) : (1f - num % 1f));
		float 2 = (float)(this.6 * (double)num);
		return this.29(2);
	}

	// Token: 0x06003594 RID: 13716 RVA: 0x0014D1C0 File Offset: 0x0014B3C0
	internal new 208 29(float 1)
	{
		if (this.55 == null || this.57 == null)
		{
			this.RebuildPathAndTiming(true);
		}
		if (this.55 == null || this.57 == null || this.55.Count == 0 || this.57.Count == 0)
		{
			return this.8;
		}
		if (1 == 0f)
		{
			return this.55[0].1;
		}
		double num = this.57[this.57.Count - 1];
		if ((double)1 >= num)
		{
			return this.55[this.55.Count - 1].2;
		}
		int num2 = this.57.BinarySearch((double)1);
		if (num2 < 0)
		{
			num2 = Math.Min(~num2, this.57.Count - 1);
		}
		double num3 = this.57[num2];
		double num4 = (num2 == 0) ? 0.0 : this.57[num2 - 1];
		208 2 = this.55[num2].1;
		if (num3 != num4)
		{
			2 += (this.55[num2].2 - this.55[num2].1) * (float)(((double)1 - num4) / (num3 - num4));
		}
		return 2;
	}

	// Token: 0x06003595 RID: 13717 RVA: 0x0014D314 File Offset: 0x0014B514
	internal new bool 30()
	{
		2123.2125 <<EMPTY_NAME>> = new 2123.2125();
		<<EMPTY_NAME>>.1 = this;
		if (this.55 == null || this.57 == null)
		{
			return false;
		}
		float 2 = this.28.1;
		<<EMPTY_NAME>>.2 = this.28.1 * 4f;
		<<EMPTY_NAME>>.3 = 0;
		while (<<EMPTY_NAME>>.3 < this.55.Count)
		{
			208 3 = this.55[<<EMPTY_NAME>>.3].2;
			int num = this.57.FindLastIndex(new Predicate<double>(<<EMPTY_NAME>>.1));
			int num2 = Math.Max(0, num);
			int num3 = <<EMPTY_NAME>>.3;
			while (num3 >= num2 && 208.Distance(3, this.55[num3].1) < 2)
			{
				num3--;
			}
			if (num3 + 1 == num)
			{
				return true;
			}
			<<EMPTY_NAME>>.3++;
		}
		return false;
	}

	// Token: 0x06003596 RID: 13718 RVA: 0x0014D408 File Offset: 0x0014B608
	internal override void PrepareRendering()
	{
		2123.2126 <<EMPTY_NAME>> = new 2123.2126();
		<<EMPTY_NAME>>.2 = this;
		double num;
		double num2;
		bool flag = this.37(out num, out num2);
		if (1662.12 || (this.53 != null && this.53.GetTexture() != null && !1662.23 && !1304.124.1() && !flag))
		{
			return;
		}
		if (!this.IsActive() || this.55 == null)
		{
			this.36();
			this.35();
			return;
		}
		float num3 = (2123.39() && !this.67 && !base.3()) ? Math.Min(1f, (float)(1226.16 - (this.1 - this.28.2)) / ((float)this.28.2 / 3f)) : 1f;
		bool flag2 = flag && num == this.89 && num2 == this.90;
		if (((!flag && this.90 < 0.0) || flag2) && this.64 == num3 && (this.8 == this.60 || !this.61) && this.53 != null && this.53.GetTexture() != null && !this.53.GetTexture().5())
		{
			return;
		}
		if (flag2 && num2 <= num)
		{
			return;
		}
		this.89 = (flag ? num : -1.0);
		this.90 = (flag ? num2 : -1.0);
		this.60 = this.8;
		this.36();
		this.64 = num3;
		List<1051> list = new List<1051>();
		if (flag)
		{
			this.38(num, num2, list);
			this.52 = 0;
			if (list.Count == 0)
			{
				return;
			}
		}
		else
		{
			int num4 = 0;
			bool flag3 = false;
			<<EMPTY_NAME>>.1 = (double)num3 * this.6;
			int num5 = (num3 >= 1f) ? this.55.Count : (this.57.FindIndex(new Predicate<double>(<<EMPTY_NAME>>.1)) + 1);
			if (num5 == 0)
			{
				num5 = this.55.Count;
			}
			float num6 = (num3 >= 1f) ? 0f : ((float)<<EMPTY_NAME>>.1 - ((num5 == 1) ? 0f : ((float)this.57[num5 - 2])));
			1662.69.17(this.8);
			1662.69.17(this.GetCurrentPosition());
			for (int i = this.52; i < num5; i++)
			{
				if (!flag3)
				{
					num4 = i;
				}
				bool flag4 = i == num5 - 1;
				int num7 = this.55[i].4 ? 32 : 6;
				if (208.Distance(this.55[num4].1, this.55[i].2) > (float)num7 || flag4 || this.55[i].3 || i == num5 - 2)
				{
					if (flag4 && num6 > 0f)
					{
						1051 2 = new 1051(this.55[num4].1, this.55[i].2);
						2.2 = 2.1 + 208.Normalize(2.2 - 2.1) * num6;
						1662.69.20(ref 2);
						if (num3 < 1f)
						{
							208 3 = 2.2;
						}
						list.Add(2);
					}
					else if (num4 == i)
					{
						1051 4 = 1662.69.21(this.55[i]);
						208 5 = 4.2;
						list.Add(4);
					}
					else
					{
						1051 6 = 1662.69.21(new 1051(this.55[num4].1, this.55[i].2));
						208 7 = 6.2;
						list.Add(6);
					}
					flag3 = false;
				}
				else
				{
					flag3 = true;
				}
			}
			this.52 = num5;
			if (num5 == 0)
			{
				return;
			}
		}
		int num8 = 0;
		int num9 = 0;
		float num10 = this.28.1 * 1662.69.9();
		int count = list.Count;
		int num11;
		int num12;
		if (count > 0)
		{
			208 8 = list[0].1;
			208 9 = list[0].1;
			for (int j = 0; j < count; j++)
			{
				1051 10 = list[j];
				if (10.2.X < 8.X)
				{
					8.X = 10.2.X;
				}
				else if (10.2.X > 9.X)
				{
					9.X = 10.2.X;
				}
				if (10.2.Y < 8.Y)
				{
					8.Y = 10.2.Y;
				}
				else if (10.2.Y > 9.Y)
				{
					9.Y = 10.2.Y;
				}
			}
			num11 = (int)((double)(9.X - 8.X) + (double)num10 * 2.3);
			num12 = (int)((double)(9.Y - 8.Y) + (double)num10 * 2.3);
			num8 = (int)((double)8.X - (double)num10 * 1.15);
			num9 = (int)((double)8.Y - (double)num10 * 1.15);
		}
		else
		{
			num11 = (int)((double)num10 * 2.2);
			num12 = (int)((double)num10 * 2.2);
		}
		int num13 = num11;
		int num14 = num12;
		int num15 = num8;
		int num16 = num9;
		bool flag5 = 2630.19("SliderTrackOverride", true).A > 0;
		198 11 = (1272.5().3() == 2147.Taiko) ? new 198(252, 184, 6) : ((this.17 >= this.28.27.Count) ? new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue) : this.28.27[this.17]);
		int 12;
		if (flag5)
		{
			12 = 0;
		}
		else if (this.7 == 198.Gray && 11 != 198.Gray)
		{
			11 = 198.Gray;
			12 = -1;
		}
		else
		{
			12 = this.17;
		}
		if (this.58.46.GetTexture() != null)
		{
			1455.2(this.58.46.GetTexture().2 + "overlay", (1416)7, null);
		}
		1381 13 = (this.48.Count > 0) ? this.48[0].46.GetTexture() : null;
		if (13 != null)
		{
			1455.2(13.2 + "overlay", (1416)7, null);
		}
		(float)(2039.16 / 2) * 208.One;
		new 208(this.28.23, this.28.23);
		num13 = 1454.1(num13);
		num14 = 1454.1(num14);
		int num17 = Math.Max(-num16, 0);
		int num18 = Math.Max(-num15, 0);
		this.61 = (num15 < 0 || num16 < 0);
		if (1304.227)
		{
			return;
		}
		bool 14 = 1379.19;
		1379.19 = false;
		if (this.53.GetTexture() == null)
		{
			this.53.SetTexture((this.28.2 >= 86400000 && !2123.91) ? this.34(num13, num14) : 2123.31());
		}
		1415 15 = new 1415((1402)this.53.GetTexture().gpuTexture, new RenderbufferInternalFormat?(33189));
		try
		{
			15.10();
			Rectangle value = new Rectangle(num15 + num18, num16 + num14, num13, -(num14 - num17));
			1379.28(new Rectangle?(new Rectangle(0, 0, value.Width, -value.Height)));
			1379.29(new Rectangle?(value));
			if (base.3())
			{
				2630.10.DrawPath(list, null, this.28.1 * 1662.69.9(), 12, this.74 ? new 198(229, 44, 44) : new 198(49, 151, byte.MaxValue));
			}
			else
			{
				2630.10.DrawPath(list, null, this.28.1 * 1662.69.9(), 12);
			}
			this.53.17 = new 208((float)(num8 + num18), (float)(num9 + num17));
			List<1433> 16 = this.42;
			if (16 != null)
			{
				16.ForEach(new Action<1433>(<<EMPTY_NAME>>.2));
			}
		}
		finally
		{
			((IDisposable)15).Dispose();
		}
		1379.19 = 14;
	}

	// Token: 0x06003597 RID: 13719 RVA: 0x0014DD44 File Offset: 0x0014BF44
	private new static 1381 31()
	{
		2123.66++;
		Stack<1381> obj = 2123.65;
		1381 result;
		lock (obj)
		{
			if (2123.65.Count == 0)
			{
				2123.32();
			}
			result = 2123.65.Pop();
		}
		return result;
	}

	// Token: 0x06003598 RID: 13720 RVA: 0x0014DDA8 File Offset: 0x0014BFA8
	private new static void 32()
	{
		1381 <<EMPTY_NAME>> = new 1381(1454.1(1662.70.1), 1454.1(1662.70.2))
		{
			2 = "sliderbody"
		};
		<<EMPTY_NAME>>.18();
		2123.65.Push(<<EMPTY_NAME>>);
	}

	// Token: 0x06003599 RID: 13721 RVA: 0x0014DDF8 File Offset: 0x0014BFF8
	private new static void 33(1381 1)
	{
		2123.66--;
		if (1 == null)
		{
			return;
		}
		Stack<1381> obj = 2123.65;
		lock (obj)
		{
			2123.65.Push(1);
		}
	}

	// Token: 0x0600359A RID: 13722 RVA: 0x0014DE4C File Offset: 0x0014C04C
	private new 1381 34(int 1, int 2)
	{
		if (this.92 != null && (this.92.5() || this.92.1() != 1 || this.92.2() != 2))
		{
			this.35();
		}
		if (this.92 == null)
		{
			this.92 = new 1381(1, 2)
			{
				2 = "sliderbody"
			};
		}
		return this.92;
	}

	// Token: 0x0600359B RID: 13723 RVA: 0x0014DEB8 File Offset: 0x0014C0B8
	internal new void 35()
	{
		if (this.92 == null)
		{
			return;
		}
		if (this.53 != null && this.53.GetTexture() == this.92)
		{
			this.53.SetTexture(null);
		}
		this.92.Dispose();
		this.92 = null;
	}

	// Token: 0x0600359C RID: 13724 RVA: 0x0014DF08 File Offset: 0x0014C108
	internal new void 36()
	{
		if (this.53 != null && this.53.GetTexture() != null)
		{
			if (this.53.GetTexture() != this.92)
			{
				2123.33(this.53.GetTexture());
			}
			this.53.SetTexture(null);
		}
		this.52 = 0;
		this.64 = 0f;
	}

	// Token: 0x0600359D RID: 13725 RVA: 0x0014DF6C File Offset: 0x0014C16C
	internal override void SetComboColour(198 1)
	{
		if (this.50 == null || !(1 != this.7))
		{
			return;
		}
		this.58.SetComboColour(1);
		foreach (2066 2 in this.48)
		{
			2.SetComboColour(1);
		}
		this.36();
		this.7 = 1;
		if ((this.45.GetTexture().6 == (1416)1 || 2630.5.AllowSliderBallTint) && 1304.69)
		{
			this.45.6 = 1;
		}
		base.SetComboColour(1);
		this.ApplyComboColourFade();
	}

	// Token: 0x0600359E RID: 13726 RVA: 0x0014E034 File Offset: 0x0014C234
	private new bool 37(out double 1, out double 2)
	{
		1 = 0.0;
		2 = this.6;
		if (1304.123.1() && 1662.78 != 1677.Edit && !this.67 && !base.3())
		{
			1262 3 = 1272.5();
			if ((3 == null || 3.3() != 2147.Taiko) && this.5 > 0 && base.GetDuration() > 0)
			{
				int 4 = 1226.16;
				if (4 < this.1)
				{
					return false;
				}
				if (4 >= this.2)
				{
					2 = 0.0;
					return true;
				}
				double num = (double)(4 - this.1) / ((double)base.GetDuration() / (double)this.5);
				int num2 = Math.Min(this.5 - 1, (int)Math.Floor(num));
				if (num2 < this.5 - 1)
				{
					return false;
				}
				double num3 = Math.Max(0.0, Math.Min(1.0, num - (double)num2));
				if (num2 % 2 == 0)
				{
					1 = num3 * this.6;
				}
				else
				{
					2 = (1.0 - num3) * this.6;
				}
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600359F RID: 13727 RVA: 0x0014E14C File Offset: 0x0014C34C
	private new void 38(double 1, double 2, List<1051> 3)
	{
		int num = 0;
		while (num < this.55.Count && num < this.57.Count)
		{
			double num2 = (num == 0) ? 0.0 : this.57[num - 1];
			double num3 = this.57[num];
			if (num3 > 1 && num2 < 2 && num3 > num2)
			{
				208 4 = this.55[num].1;
				208 5 = this.55[num].2 - this.55[num].1;
				double num4 = num3 - num2;
				1051 item = new 1051(4 + 5 * (float)(Math.Max(0.0, 1 - num2) / num4), 4 + 5 * (float)(Math.Min(num4, 2 - num2) / num4));
				1662.69.20(ref item);
				3.Add(item);
			}
			num++;
		}
	}

	// Token: 0x060035A0 RID: 13728 RVA: 0x0014E25A File Offset: 0x0014C45A
	private new static bool 39()
	{
		return 1304.122 && (1662.78 != 1677.Edit || 1304.82);
	}

	// Token: 0x060035A1 RID: 13729 RVA: 0x0014E280 File Offset: 0x0014C480
	internal override void SetHitSound(1245 1, bool 2, bool 3)
	{
		if (3)
		{
			if (this.10())
			{
				this.45();
				this.40(1, 2, true);
			}
			return;
		}
		if (this.11())
		{
			this.45();
		}
		else if (!this.73)
		{
			this.40(1, 2, false);
		}
		base.SetHitSound(1, 2, false);
	}

	// Token: 0x060035A2 RID: 13730 RVA: 0x0014E2D4 File Offset: 0x0014C4D4
	private new void 40(1245 1, bool 2, bool 3)
	{
		for (int i = 0; i < this.9().Count; i++)
		{
			if (this.9()[i].3() || !3)
			{
				this.41(1, 2, i);
			}
		}
	}

	// Token: 0x060035A3 RID: 13731 RVA: 0x0014E316 File Offset: 0x0014C516
	private new void 41(1245 1, bool 2, int 3)
	{
		this.84[3] = (2 ? (this.84[3] | 1) : (this.84[3] ^ 1));
	}

	// Token: 0x060035A4 RID: 13732 RVA: 0x0014E345 File Offset: 0x0014C545
	internal override void PlayHitSound()
	{
		this.42(false, (1226.16 > this.1 + base.GetDuration() / 2) ? (this.84.Count - 1) : 0);
	}

	// Token: 0x060035A5 RID: 13733 RVA: 0x0014E374 File Offset: 0x0014C574
	protected override float GetSamplePan()
	{
		return (this.45.17.X / 512f - 0.5f) * 0.8f;
	}

	// Token: 0x060035A6 RID: 13734 RVA: 0x0014E398 File Offset: 0x0014C598
	internal new void 42(bool 1, int 2)
	{
		if (1226.16 <= this.2)
		{
			this.44();
		}
		if (1)
		{
			1259 3 = this.28.21.92((double)(this.83[2] + 2));
			1254 4 = (this.35 == 1254.None) ? 3.4 : this.35;
			1226.33(new 1244(this.4, 4, 3.2, 3.6, (this.36 == 1254.None) ? 4 : this.36), this.GetSamplePan());
			return;
		}
		1244 5 = this.43(2);
		2039.33(5);
		1226.30(5, this.GetSamplePan(), true);
	}

	// Token: 0x060035A7 RID: 13735 RVA: 0x0014E440 File Offset: 0x0014C640
	internal 1244 43(int 1)
	{
		1259 2;
		1245 3;
		1254 4;
		1254 5;
		if (1 == 0)
		{
			2 = this.28.21.92((double)(this.1 + 5));
			if (!this.73)
			{
				3 = ((this.84.Count != 0) ? this.84[0] : this.4);
				4 = ((this.85.Count != 0 && (this.28.21.32 >= 14 || this.85[0] != 1254.None)) ? this.85[0] : this.35);
				5 = ((this.86.Count != 0) ? this.86[0] : this.36);
			}
			else
			{
				3 = this.4;
				4 = this.35;
				5 = this.36;
			}
		}
		else
		{
			2 = ((1 < this.5 && 1 != -1) ? this.28.21.92((double)(this.82[1 - 1] + 5)) : this.28.21.92((double)(this.2 + 5)));
			if (!this.73)
			{
				3 = ((1 < this.84.Count) ? this.84[1] : this.4);
				4 = ((1 < this.85.Count) ? this.85[1] : this.35);
				5 = ((1 < this.86.Count) ? this.86[1] : this.36);
			}
			else
			{
				3 = this.4;
				4 = this.35;
				5 = this.36;
			}
		}
		1253 6;
		int 7;
		if (2 != null)
		{
			if (4 == 1254.None)
			{
				4 = 2.4;
			}
			6 = 2.2;
			7 = 2.6;
		}
		else
		{
			if (4 == 1254.None)
			{
				4 = 1254.Normal;
			}
			6 = 1253.Default;
			7 = 100;
		}
		if (5 == 1254.None)
		{
			5 = 4;
		}
		return 1244.1(3, 4, 6, 7, 5);
	}

	// Token: 0x060035A8 RID: 13736 RVA: 0x0014E630 File Offset: 0x0014C830
	internal void 44()
	{
		1254 <<EMPTY_NAME>> = 1254.None;
		1254 2 = 1254.None;
		if (this.28.21.32 >= 14)
		{
			<<EMPTY_NAME>> = this.35;
			2 = this.36;
		}
		1226.31(this.4, <<EMPTY_NAME>>, 2, 2630.5.LayeredHitSounds, new float?(this.GetSamplePan() * 0.4f));
	}

	// Token: 0x060035A9 RID: 13737 RVA: 0x0014E68B File Offset: 0x0014C88B
	internal override void StopHitSounds()
	{
		1226.34();
	}

	// Token: 0x060035AA RID: 13738 RVA: 0x0014E694 File Offset: 0x0014C894
	internal void 45()
	{
		if (this.73)
		{
			for (int i = 0; i < this.5 + 1; i++)
			{
				this.84.Add(this.4);
				this.85.Add(this.35);
				this.86.Add(this.36);
			}
			this.73 = false;
		}
	}

	// Token: 0x060035AB RID: 13739 RVA: 0x0014E6F6 File Offset: 0x0014C8F6
	internal void 46()
	{
		this.73 = true;
		this.35 = 1254.None;
		this.36 = 1254.None;
		this.84.Clear();
		this.85.Clear();
		this.86.Clear();
	}

	// Token: 0x060035AC RID: 13740 RVA: 0x0014E730 File Offset: 0x0014C930
	internal void 47()
	{
		if (this.73)
		{
			return;
		}
		int num = this.9().Count - this.85.Count;
		if (num > 0)
		{
			for (int i = 0; i < num; i++)
			{
				this.84.Add(this.4);
				this.85.Add(this.35);
				this.86.Add(this.36);
			}
		}
		else if (num < 0)
		{
			num *= -1;
			for (int j = 0; j < num; j++)
			{
				this.84.RemoveAt(this.84.Count - 1);
				this.85.RemoveAt(this.85.Count - 1);
				this.86.RemoveAt(this.86.Count - 1);
			}
		}
		if (this.35 != 1254.None || this.36 != 1254.None)
		{
			return;
		}
		for (int k = 0; k < this.85.Count; k++)
		{
			if (this.84[k] != this.4 || this.85[k] != this.35 || this.86[k] != this.36)
			{
				return;
			}
		}
		this.46();
	}

	// Token: 0x060035AD RID: 13741 RVA: 0x0014E869 File Offset: 0x0014CA69
	[CompilerGenerated]
	internal override 208 GetCurrentPosition()
	{
		return this.88;
	}

	// Token: 0x060035AE RID: 13742 RVA: 0x0014E871 File Offset: 0x0014CA71
	[CompilerGenerated]
	internal override void SetCurrentPosition(208 1)
	{
		this.88 = 1;
	}

	// Token: 0x060035AF RID: 13743 RVA: 0x0014E87A File Offset: 0x0014CA7A
	internal virtual bool IsHeadJudged()
	{
		return this.58.11;
	}

	// Token: 0x060035B0 RID: 13744 RVA: 0x0014E888 File Offset: 0x0014CA88
	internal virtual 2149 JudgeHead()
	{
		if (1535.21 || 1535.50)
		{
			this.75 = (1535.21 ? MouseButtons.Left : (1535.50 ? MouseButtons.Right : 1555.21));
		}
		return this.58.GetOrCalculateJudgement();
	}

	// Token: 0x060035B1 RID: 13745 RVA: 0x0014E8D8 File Offset: 0x0014CAD8
	internal override 2149 GetOrCalculateJudgement()
	{
		this.11 = true;
		this.StopHitSounds();
		if (this.58.14 > (2149)0)
		{
			this.76++;
		}
		double num = (double)this.76 / (double)(this.83.Count + 1);
		if (num > 0.0)
		{
			this.PlayHitSound();
		}
		2241 <<EMPTY_NAME>> = 2486.88;
		if (((<<EMPTY_NAME>> != null) ? <<EMPTY_NAME>>.39 : null) != null)
		{
			if (num == 1.0 && this.58.14 == (2149)1024)
			{
				return (2149)1024;
			}
			if (num >= 0.5 && this.58.14 >= (2149)512)
			{
				return (2149)512;
			}
			if (num > 0.0)
			{
				return (2149)256;
			}
		}
		else
		{
			if (num == 1.0)
			{
				return (2149)1024;
			}
			if (num >= 0.5)
			{
				return (2149)512;
			}
			if (num > 0.0)
			{
				return (2149)256;
			}
		}
		return (2149)(-131072);
	}

	// Token: 0x060035B2 RID: 13746 RVA: 0x0014E9E0 File Offset: 0x0014CBE0
	internal void 48()
	{
		this.77 = 1226.16;
		this.49.3.RemoveAll(new Predicate<1445>(2123.2127.Instance.6));
		int num = (1662.78 != 1677.Edit) ? Math.Max(1226.16, this.1) : this.1;
		this.49.3.Add(new 1445(1456.Fade, 0f, 1f, num, Math.Min(this.2, num + 60), (1046)0));
		this.49.3.Add(new 1445(1456.Scale, 0.5f, 1f, num, Math.Min(this.2, num + 180), (1046)1));
		this.49.3.Add(new 1445(1456.Fade, 1f, 0f, this.2, this.2 + 200, (1046)2));
		this.49.3.Add(new 1445(1456.Scale, 1f, 0.8f, this.2, this.2 + 200, (1046)1));
		int count = this.83.Count;
		int num2 = 200;
		int num3 = (count > 1) ? Math.Min(num2, this.83[1] - this.83[0]) : num2;
		float <<EMPTY_NAME>> = 1.1f - (float)num3 / (float)num2 * 0.1f;
		if (count > 0)
		{
			foreach (int num4 in this.83.GetRange(0, count - 1))
			{
				this.49.3.Add(new 1445(1456.Scale, 1.1f, <<EMPTY_NAME>>, num4, Math.Min(this.2, num4 + num3), (1046)0));
			}
		}
		this.48.ForEach(new Action<2066>(2123.2127.Instance.7));
		this.78 = true;
	}

	// Token: 0x060035B3 RID: 13747 RVA: 0x0014EBF0 File Offset: 0x0014CDF0
	internal void 49()
	{
		if (!this.78)
		{
			return;
		}
		this.49.3.RemoveAll(new Predicate<1445>(2123.2127.Instance.8));
		int num = this.2;
		foreach (int num2 in this.83)
		{
			if (num2 > 1226.16)
			{
				num = num2;
				break;
			}
		}
		this.49.3.Add(new 1445(1456.Fade, 1f, 0f, num - 100, num, (1046)0));
		this.49.3.Add(new 1445(1456.Scale, 1f, 2f, num - 100, num, (1046)0));
		if (!this.11)
		{
			this.48.ForEach(delegate(2066 1)
			{
				1.ResetJudgementState();
			});
		}
		this.78 = false;
	}

	// Token: 0x060035B4 RID: 13748 RVA: 0x0014ED00 File Offset: 0x0014CF00
	internal override 2149 JudgeAtPosition(208 1)
	{
		if (this.11 || 1226.16 < this.1)
		{
			return (2149)0;
		}
		bool flag = false;
		bool flag2 = false;
		bool flag3 = 1555.15 && (1555.16 != (MouseButtons.Left | MouseButtons.Right) || 1555.17 != 1555.21);
		if (1555.15)
		{
			if (this.75 == MouseButtons.None || (1555.21 != (MouseButtons.Left | MouseButtons.Right) && flag3))
			{
				this.75 = (1535.21 ? MouseButtons.Left : (1535.50 ? MouseButtons.Right : 1555.21));
				flag2 = true;
			}
			else if ((1555.21 & this.75) > MouseButtons.None)
			{
				flag2 = true;
			}
		}
		else
		{
			this.75 = MouseButtons.None;
		}
		if (flag2 | (flag3 | 2486.21))
		{
			2123.2128 2 = new 2123.2128();
			float num = this.78 ? (this.28.1 * 2.4f) : this.28.1;
			2.1 = 1226.16 - ((1535.59 is 1563 && !1535.25()) ? 1304.163 : 0);
			1445 3 = this.45.3.Find(new Predicate<1445>(2.1));
			if (3 == null && 2.1 > this.45.3[this.45.3.Count - 1].10)
			{
				3 = this.45.3[this.45.3.Count - 1];
			}
			if (1535.59 is 1563 && !1535.25() && 3 == null && 2.1 < this.1 && 1226.16 >= this.1)
			{
				3 = this.45.3[0];
			}
			if (3 != null)
			{
				208 4 = (3.10 != 3.9) ? (3.2 + (3.6 - 3.2) * (1f - (float)(3.10 - 2.1) / (float)(3.10 - 3.9))) : 3.6;
				flag = (208.DistanceSquared(1662.69.14(1), 4) < num * num);
			}
		}
		if (flag && !this.78)
		{
			this.48();
		}
		2149 result = (2149)0;
		int num2 = 0;
		while (num2 < this.83.Count && this.83[num2] <= 1226.16)
		{
			num2++;
		}
		if (this.76 + this.80 < num2)
		{
			int num3 = this.76 + this.80;
			if (flag && this.77 <= this.83[num3])
			{
				this.76++;
				this.81[num3] = true;
				result = ((this.83.Count == num2) ? ((2149)128) : ((num2 % (this.83.Count / this.5) != 0) ? ((2149)8) : ((2149)64)));
			}
			else
			{
				this.80++;
				this.81[num3] = false;
				result = ((this.76 + this.80 != this.83.Count) ? ((2149)(-262144)) : ((2149)(-524288)));
			}
		}
		if (!flag && this.78 && this.76 + this.80 < this.83.Count)
		{
			this.49();
		}
		return result;
	}

	// Token: 0x040027A4 RID: 10148
	private int 43;

	// Token: 0x040027A5 RID: 10149
	private List<2055> 44 = new List<2055>();

	// Token: 0x040027A6 RID: 10150
	internal readonly 1351 45;

	// Token: 0x040027A7 RID: 10151
	internal readonly 1433 46;

	// Token: 0x040027A8 RID: 10152
	internal readonly 1433 47;

	// Token: 0x040027A9 RID: 10153
	internal readonly List<2066> 48;

	// Token: 0x040027AA RID: 10154
	internal readonly 1351 49;

	// Token: 0x040027AB RID: 10155
	protected 1436 50;

	// Token: 0x040027AC RID: 10156
	internal 2064 51;

	// Token: 0x040027AD RID: 10157
	private int 52;

	// Token: 0x040027AE RID: 10158
	internal 1433 53;

	// Token: 0x040027AF RID: 10159
	internal List<208> 54;

	// Token: 0x040027B0 RID: 10160
	internal List<1051> 55;

	// Token: 0x040027B1 RID: 10161
	internal double 56;

	// Token: 0x040027B2 RID: 10162
	internal List<double> 57;

	// Token: 0x040027B3 RID: 10163
	internal 2033 58;

	// Token: 0x040027B4 RID: 10164
	private 208 59;

	// Token: 0x040027B5 RID: 10165
	private 208 60;

	// Token: 0x040027B6 RID: 10166
	private bool 61;

	// Token: 0x040027B7 RID: 10167
	internal bool 62;

	// Token: 0x040027B8 RID: 10168
	internal 2064 63;

	// Token: 0x040027B9 RID: 10169
	private float 64;

	// Token: 0x040027BA RID: 10170
	private static Stack<1381> 65 = new Stack<1381>();

	// Token: 0x040027BB RID: 10171
	private static int 66;

	// Token: 0x040027BC RID: 10172
	internal bool 67;

	// Token: 0x040027BD RID: 10173
	private bool 68;

	// Token: 0x040027BE RID: 10174
	private 208 69;

	// Token: 0x040027BF RID: 10175
	internal bool 70;

	// Token: 0x040027C0 RID: 10176
	private bool 71;

	// Token: 0x040027C1 RID: 10177
	private int 72;

	// Token: 0x040027C2 RID: 10178
	internal bool 73 = true;

	// Token: 0x040027C3 RID: 10179
	private bool 74;

	// Token: 0x040027C4 RID: 10180
	private MouseButtons 75;

	// Token: 0x040027C5 RID: 10181
	internal int 76;

	// Token: 0x040027C6 RID: 10182
	private int 77;

	// Token: 0x040027C7 RID: 10183
	internal bool 78;

	// Token: 0x040027C8 RID: 10184
	private int 79;

	// Token: 0x040027C9 RID: 10185
	internal int 80;

	// Token: 0x040027CA RID: 10186
	internal bool[] 81;

	// Token: 0x040027CB RID: 10187
	internal List<int> 82 = new List<int>();

	// Token: 0x040027CC RID: 10188
	internal List<int> 83 = new List<int>();

	// Token: 0x040027CD RID: 10189
	public List<1245> 84 = new List<1245>();

	// Token: 0x040027CE RID: 10190
	public List<1254> 85 = new List<1254>();

	// Token: 0x040027CF RID: 10191
	public List<1254> 86 = new List<1254>();

	// Token: 0x040027D0 RID: 10192
	internal double 87;

	// Token: 0x040027D1 RID: 10193
	private 208 88;

	// Token: 0x040027D2 RID: 10194
	private double 89 = -1.0;

	// Token: 0x040027D3 RID: 10195
	private double 90 = -1.0;

	// Token: 0x040027D4 RID: 10196
	internal static bool 91;

	// Token: 0x040027D5 RID: 10197
	private 1381 92;

	// Token: 0x02000716 RID: 1814
	[276]
	[Serializable]
	public sealed class 2127
	{
		// Token: 0x060035B6 RID: 13750 RVA: 0x001409F8 File Offset: 0x0013EBF8
		internal void 1(1433 1)
		{
			1.13();
		}

		// Token: 0x060035B7 RID: 13751 RVA: 0x000E89E2 File Offset: 0x000E6BE2
		internal bool 2(2033 1)
		{
			return 1.3();
		}

		// Token: 0x060035B8 RID: 13752 RVA: 0x0014F0B5 File Offset: 0x0014D2B5
		internal bool 3(1445 1)
		{
			return 1.14 == 1456.Fade && 1.5 == 0f;
		}

		// Token: 0x060035B9 RID: 13753 RVA: 0x0014F0D0 File Offset: 0x0014D2D0
		internal void 4()
		{
			while (2123.65.Count > 0)
			{
				2123.65.Pop().Dispose();
			}
			2123.65.Clear();
			for (int i = 0; i < 8; i++)
			{
				2123.32();
			}
		}

		// Token: 0x060035BA RID: 13754 RVA: 0x0014F116 File Offset: 0x0014D316
		internal void 5(2033 1)
		{
			1.4(false);
			1.OnDeselected();
		}

		// Token: 0x060035BB RID: 13755 RVA: 0x0014F125 File Offset: 0x0014D325
		internal bool 6(1445 1)
		{
			return 1.14 != 1456.Movement;
		}

		// Token: 0x060035BC RID: 13756 RVA: 0x0014F133 File Offset: 0x0014D333
		internal void 7(2066 1)
		{
			1.ApplyJudgementAnimation(true);
		}

		// Token: 0x060035BD RID: 13757 RVA: 0x0014F125 File Offset: 0x0014D325
		internal bool 8(1445 1)
		{
			return 1.14 != 1456.Movement;
		}

		// Token: 0x060035BE RID: 13758 RVA: 0x0014F13C File Offset: 0x0014D33C
		internal void 9(2066 1)
		{
			1.ResetJudgementState();
		}

		// Token: 0x040027D6 RID: 10198
		public static readonly 2123.2127 Instance = new 2123.2127();

		// Token: 0x040027D7 RID: 10199
		public static Action<1433> action;

		// Token: 0x040027D8 RID: 10200
		public static Predicate<2033> predicate;

		// Token: 0x040027D9 RID: 10201
		public static Predicate<1445> predicate2;

		// Token: 0x040027DA RID: 10202
		public static Action<2033> action2;

		// Token: 0x040027DB RID: 10203
		public static Predicate<1445> predicate3;

		// Token: 0x040027DC RID: 10204
		public static Action<2066> action3;

		// Token: 0x040027DD RID: 10205
		public static Predicate<1445> predicate4;

		// Token: 0x040027DE RID: 10206
		public static Action<2066> action4;
	}

	// Token: 0x02000717 RID: 1815
	[276]
	public sealed class 2124
	{
		// Token: 0x060035C1 RID: 13761 RVA: 0x0014F150 File Offset: 0x0014D350
		internal void 1(2066 1)
		{
			1.SetPosition(1.8 + this.1, false);
		}

		// Token: 0x040027DF RID: 10207
		public 208 1;
	}

	// Token: 0x02000718 RID: 1816
	[276]
	public sealed class 2125
	{
		// Token: 0x060035C3 RID: 13763 RVA: 0x0014F16A File Offset: 0x0014D36A
		internal bool 1(double 1)
		{
			return 1 < this.1.57[this.3] - (double)this.2;
		}

		// Token: 0x040027E0 RID: 10208
		public 2123 1;

		// Token: 0x040027E1 RID: 10209
		public float 2;

		// Token: 0x040027E2 RID: 10210
		public int 3;
	}

	// Token: 0x02000719 RID: 1817
	[276]
	public sealed class 2126
	{
		// Token: 0x060035C5 RID: 13765 RVA: 0x0014F18D File Offset: 0x0014D38D
		internal bool 1(double 1)
		{
			return 1 > this.1;
		}

		// Token: 0x060035C6 RID: 13766 RVA: 0x0014F198 File Offset: 0x0014D398
		internal void 2(1433 1)
		{
			1.17 = this.2.53.17;
			1.SetTexture(this.2.53.GetTexture());
		}

		// Token: 0x040027E3 RID: 10211
		public double 1;

		// Token: 0x040027E4 RID: 10212
		public 2123 2;
	}

	// Token: 0x0200071A RID: 1818
	[276]
	public sealed class 2128
	{
		// Token: 0x060035C8 RID: 13768 RVA: 0x0014F1C6 File Offset: 0x0014D3C6
		internal bool 1(1445 1)
		{
			return 1.9 <= this.1 && 1.10 >= this.1;
		}

		// Token: 0x040027E5 RID: 10213
		public int 1;
	}
}
