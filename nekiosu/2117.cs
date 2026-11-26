using System;
using System.Collections.Generic;

// Token: 0x0200070F RID: 1807
[276]
public sealed class 2117
{
	// Token: 0x0600353E RID: 13630 RVA: 0x0014914E File Offset: 0x0014734E
	private 2117(2117.2118[] 1, int 2, float 3, float 4)
	{
		this.11 = 1;
		this.12 = new Random(2);
		this.13 = 3;
		this.14 = 4;
	}

	// Token: 0x0600353F RID: 13631 RVA: 0x00149178 File Offset: 0x00147378
	public static 2117 1(2039 1, int 2, float 3)
	{
		List<2034> 4 = 1.34;
		int num = 0;
		foreach (2034 5 in 4)
		{
			num = Math.Max(num, 5.19 + 1);
		}
		float num2 = (float)1.GetNormalizedDifficulty((double)1.16(1928.CircleSize, 1.21.2));
		float num3 = (1f - 0.7f * num2) / 2f * 1.00041f;
		float num4 = (float)(64.0 * (double)num3);
		bool flag = 1.47 != null && 1.47.FlipsHorizontally;
		bool flag2 = (1.22 & 2023.HardRock) > 2023.None || (1.47 != null && 1.47.FlipsVertically);
		2117.2118[] array = new 2117.2118[num];
		2117 6 = new 2117(array, 2, Math.Max(1f, Math.Min(10f, 3)), num4);
		List<2117.2120> list = new List<2117.2120>(4.Count);
		2117.2120 7 = null;
		foreach (2034 8 in 4)
		{
			2117.2120 9 = new 2117.2120
			{
				2 = 8.1,
				5 = new 2117.2118
				{
					3 = 8.9
				}
			};
			array[8.19] = 9.5;
			2123 10 = 8 as 2123;
			if (10 != null && 10.21 != null)
			{
				9.1 = 2117.2119.Slider;
				9.6 = 10.18;
				9.7 = 2114.1(10.21, 10.22, 10.23, 10.24, flag, flag2);
				9.8 = ((Math.Abs(9.7.Distance) <= 1E-07) ? 1 : Math.Max(1, 10.5));
			}
			else if (8.HasObjectType(2047.Spinner))
			{
				9.1 = 2117.2119.Spinner;
				9.6 = 2117.10;
				9.5.4 = true;
			}
			else
			{
				9.1 = 2117.2119.Circle;
				9.6 = 8.18;
			}
			bool 11 = 8.20;
			9.3 = ((9.1 == 2117.2119.Spinner) ? 11 : (11 || 7 == null || 7.1 == 2117.2119.Spinner));
			bool flag3 = 9.1 != 2117.2119.Spinner && 9.3;
			9.4 = ((flag3 || 7 == null) ? 0 : (7.4 + 1));
			9.5.1 = 9.6;
			list.Add(9);
			7 = 9;
		}
		6.3(list, 1.21);
		6.11(list);
		foreach (2117.2120 12 in list)
		{
			12.5.1 = 12.6;
		}
		return 6;
	}

	// Token: 0x06003540 RID: 13632 RVA: 0x001494F8 File Offset: 0x001476F8
	private static 208 2(2117.2120 1)
	{
		double distance = 1.7.Distance;
		if (distance <= 50.0)
		{
			return 1.7.10(1.0) / 2f;
		}
		int num = 0;
		208 2 = 208.Zero;
		for (double num2 = 0.0; num2 < distance; num2 += 50.0)
		{
			2 += 1.7.10(num2 / distance);
			num++;
		}
		return 2 / (float)num;
	}

	// Token: 0x06003541 RID: 13633 RVA: 0x00149584 File Offset: 0x00147784
	private void 3(List<2117.2120> 1, 1262 2)
	{
		2117.10(1);
		float num = 2117.27(new 208(512f, 384f));
		float num2 = 0f;
		bool flag = false;
		for (int i = 0; i < 1.Count; i++)
		{
			2117.2120 3 = 1[i];
			if (this.7(2, 1, i))
			{
				num2 = this.4(0.0008f);
				flag = !flag;
			}
			if (3.1 == 2117.2119.Slider && this.12.NextDouble() < 0.5)
			{
				3.7.6();
				3.5.2.Add(float.NaN);
			}
			if (i == 0)
			{
				3.10 = (float)(this.12.NextDouble() * 384.0 / 2.0);
				3.9 = (float)(this.12.NextDouble() * 2.0 * 3.141592653589793 - 3.141592653589793);
			}
			else
			{
				float num3 = 0f;
				float num4 = this.4(0.002f);
				if (this.8(1, i))
				{
					num3 = this.4(0.002f);
					flag = !flag;
				}
				float num5 = (num2 + num4) * 3.10 + num3 * (num - 3.10);
				3.9 = this.6(3.10, num5, flag);
			}
		}
	}

	// Token: 0x06003542 RID: 13634 RVA: 0x001496F4 File Offset: 0x001478F4
	private float 4(float 1)
	{
		float num = (15f - this.13) / 8f;
		return this.5(0f, 1 * num);
	}

	// Token: 0x06003543 RID: 13635 RVA: 0x00149724 File Offset: 0x00147924
	private float 5(float 1, float 2)
	{
		double d = 1.0 - this.12.NextDouble();
		double num = 1.0 - this.12.NextDouble();
		double num2 = Math.Sqrt(-2.0 * Math.Log(d)) * Math.Sin(6.283185307179586 * num);
		return 1 + 2 * (float)num2;
	}

	// Token: 0x06003544 RID: 13636 RVA: 0x0014978C File Offset: 0x0014798C
	private float 6(float 1, float 2, bool 3)
	{
		float num = this.13 / 10f;
		float num2 = 1f - num;
		float num3 = num * 100f - 70f;
		float num4 = num2 * 0.25f - 0.075f;
		1 += num3;
		float num5 = (float)(2.16 / (1.0 + 200.0 * Math.Exp(0.036 * (double)(1 - 310f + num3))) + 0.5);
		num5 += 2 + num4;
		float num6 = 3.1415927f - num5;
		if (!3)
		{
			return num6;
		}
		return -num6;
	}

	// Token: 0x06003545 RID: 13637 RVA: 0x00149828 File Offset: 0x00147A28
	private bool 7(1262 1, List<2117.2120> 2, int 3)
	{
		if (3 == 0)
		{
			return true;
		}
		bool flag = 2[Math.Max(0, 3 - 2)].4 > 1 && 2[3 - 1].3;
		bool flag2 = 2117.9(1, 2[3 - 1], true);
		bool flag3 = 2117.9(1, 2[3 - 1], false);
		return (flag && this.12.NextDouble() < 0.6000000238418579) || flag2 || (flag3 && this.12.NextDouble() < 0.4000000059604645);
	}

	// Token: 0x06003546 RID: 13638 RVA: 0x001498C0 File Offset: 0x00147AC0
	private bool 8(List<2117.2120> 1, int 2)
	{
		return 1[Math.Max(0, 2 - 2)].4 > 1 && 1[2 - 1].3 && this.12.NextDouble() < 0.6000000238418579;
	}

	// Token: 0x06003547 RID: 13639 RVA: 0x00149910 File Offset: 0x00147B10
	private static bool 9(1262 1, 2117.2120 2, bool 3)
	{
		1259 4 = null;
		1259 5 = null;
		if (1.94 != null)
		{
			foreach (1259 6 in 1.94)
			{
				if (6.1())
				{
					if (4 == null || 6.3 < 4.3)
					{
						4 = 6;
					}
					if (6.3 <= (double)2.2 && (5 == null || 6.3 >= 5.3))
					{
						5 = 6;
					}
				}
			}
		}
		1259 7 = 5 ?? 4;
		if (7 == null)
		{
			return false;
		}
		double num = (double)2.2 - 7.3;
		double num2 = Math.Max(6.0, Math.Min(60000.0, 7.1));
		if (3)
		{
			int num3 = (int)7.5;
			num2 *= (double)((num3 > 0) ? num3 : 4);
		}
		return Math.Abs(num + 1.0) % num2 < 2.0;
	}

	// Token: 0x06003548 RID: 13640 RVA: 0x00149A20 File Offset: 0x00147C20
	private static void 10(List<2117.2120> 1)
	{
		208 endPosition = 2117.10;
		float num = 0f;
		foreach (2117.2120 2 in 1)
		{
			208 3 = 2.6 - endPosition;
			float num2 = 2117.24(3.Y, 3.X);
			2.9 = num2 - num;
			2.10 = 3.Length();
			if (2.1 == 2117.2119.Slider)
			{
				float sliderRotation = 2.SliderRotation;
				2.11 = sliderRotation - num2;
				num2 = sliderRotation;
			}
			endPosition = 2.EndPosition;
			num = num2;
		}
	}

	// Token: 0x06003549 RID: 13641 RVA: 0x00149AD8 File Offset: 0x00147CD8
	private void 11(List<2117.2120> 1)
	{
		foreach (2117.2120 2 in 1)
		{
			2.12 = ((2.1 == 2117.2119.Slider) ? 2.SliderRotation : 0f);
			2.13 = 2.6;
			2.14 = 2.EndPosition;
		}
		2117.2120 3 = null;
		for (int i = 0; i < 1.Count; i++)
		{
			2117.2120 4 = 1[i];
			if (4.1 == 2117.2119.Spinner)
			{
				3 = 4;
			}
			else
			{
				2117.12(4, 3, (i > 1) ? 1[i - 2] : null);
				208 5 = (4.1 == 2117.2119.Slider) ? this.14(4) : this.13(4);
				if (5 != 208.Zero)
				{
					List<2117.2120> list = new List<2117.2120>();
					int num = i - 1;
					while (num >= i - 10 && num >= 0 && 1[num].1 == 2117.2119.Circle)
					{
						list.Add(1[num]);
						num--;
					}
					if (list.Count > 0)
					{
						this.15(list, 5);
					}
				}
				3 = 4;
			}
		}
	}

	// Token: 0x0600354A RID: 13642 RVA: 0x00149C24 File Offset: 0x00147E24
	private static void 12(2117.2120 1, 2117.2120 2, 2117.2120 3)
	{
		float num = 0f;
		if (2 != null)
		{
			if (2.1 == 2117.2119.Slider)
			{
				num = 2.SliderRotation;
			}
			else
			{
				208 4 = (3 != null) ? 3.EndPosition : 2117.10;
				208 5 = 2.6 - 4;
				num = 2117.24(5.Y, 5.X);
			}
		}
		float num2 = num + 1.9;
		208 6 = new 208(1.10 * 2117.25(num2), 1.10 * 2117.26(num2));
		208 7 = (2 != null) ? 2.14 : 2117.10;
		6 = 2117.18(7, 6, 0.5f);
		1.13 = 7 + 6;
		if (1.1 != 2117.2119.Slider)
		{
			return;
		}
		num2 = 2117.24(6.Y, 6.X);
		208 8 = 2117.2(1);
		208 9 = 2117.21(8, 1.11 + num2 - 1.SliderRotation);
		9 = 2117.18(1.13, 9, 0.5f);
		float value = 2117.24(9.Y, 9.X) - 2117.24(8.Y, 8.X);
		if (Math.Abs(value) > 0.001f)
		{
			2117.20(1, value);
		}
	}

	// Token: 0x0600354B RID: 13643 RVA: 0x00149D68 File Offset: 0x00147F68
	private 208 13(2117.2120 1)
	{
		208 2 = 1.13;
		1.14 = (1.13 = 2117.17(1.13, this.14));
		1.6 = 1.13;
		return 1.13 - 2;
	}

	// Token: 0x0600354C RID: 13644 RVA: 0x00149DB4 File Offset: 0x00147FB4
	private 208 14(2117.2120 1)
	{
		float num;
		float num2;
		float num3;
		float num4;
		this.16(1, out num, out num2, out num3, out num4);
		if (num3 < 0f || num4 < 0f)
		{
			float sliderRotation = 1.SliderRotation;
			float num5 = 2117.22(1.12, sliderRotation);
			float num6 = 2117.22(1.12 + 3.1415927f, sliderRotation);
			if (num5 < num6)
			{
				2117.20(1, 1.12 - 1.SliderRotation);
			}
			else
			{
				2117.20(1, 1.12 + 3.1415927f - 1.SliderRotation);
			}
			this.16(1, out num, out num2, out num3, out num4);
		}
		208 2 = 1.13;
		float num7 = (num3 < 0f) ? 2117.23(num, 0f, 512f) : 2117.23(2.X, num, num + num3);
		float num8 = (num4 < 0f) ? 2117.23(num2, 0f, 384f) : 2117.23(2.Y, num2, num2 + num4);
		1.6 = (1.13 = new 208(num7, num8));
		1.14 = 1.EndPosition;
		return 1.13 - 2;
	}

	// Token: 0x0600354D RID: 13645 RVA: 0x00149EE0 File Offset: 0x001480E0
	private void 15(List<2117.2120> 1, 208 2)
	{
		for (int i = 0; i < 1.Count; i++)
		{
			2117.2120 3 = 1[i];
			208 4 = 3.6 + 2 * ((float)(1.Count - i) / (float)(1.Count + 1));
			3.6 = 2117.17(4, this.14);
		}
	}

	// Token: 0x0600354E RID: 13646 RVA: 0x00149F3C File Offset: 0x0014813C
	private void 16(2117.2120 1, out float 2, out float 3, out float 4, out float 5)
	{
		float num = float.PositiveInfinity;
		float num2 = float.NegativeInfinity;
		float num3 = float.PositiveInfinity;
		float num4 = float.NegativeInfinity;
		foreach (208 6 in 1.7.CalculatedPath)
		{
			num = Math.Min(num, 6.X);
			num2 = Math.Max(num2, 6.X);
			num3 = Math.Min(num3, 6.Y);
			num4 = Math.Max(num4, 6.Y);
		}
		num -= this.14;
		num3 -= this.14;
		num2 += this.14;
		num4 += this.14;
		2 = -num;
		float num5 = 512f - num2;
		3 = -num3;
		float num6 = 384f - num4;
		4 = num5 - 2;
		5 = num6 - 3;
	}

	// Token: 0x0600354F RID: 13647 RVA: 0x0014A030 File Offset: 0x00148230
	private static 208 17(208 1, float 2)
	{
		return new 208(2117.23(1.X, 2, 512f - 2), 2117.23(1.Y, 2, 384f - 2));
	}

	// Token: 0x06003550 RID: 13648 RVA: 0x0014A060 File Offset: 0x00148260
	private static 208 18(208 1, 208 2, float 3)
	{
		float num = 0f;
		if (1.X < 2117.10.X)
		{
			num = Math.Max((192f - 1.X) / 192f, num);
		}
		else
		{
			num = Math.Max((1.X - 320f) / 192f, num);
		}
		if (1.Y < 2117.10.Y)
		{
			num = Math.Max((144f - 1.Y) / 144f, num);
		}
		else
		{
			num = Math.Max((1.Y - 240f) / 144f, num);
		}
		return 2117.19(2, 2117.10 - 1, Math.Min(1f, num * 3));
	}

	// Token: 0x06003551 RID: 13649 RVA: 0x0014A120 File Offset: 0x00148320
	private static 208 19(208 1, 208 2, float 3)
	{
		float num = 2117.24(1.Y, 1.X);
		float num2;
		for (num2 = 2117.24(2.Y, 2.X) - num; num2 < -3.1415927f; num2 += 6.2831855f)
		{
		}
		while (num2 > 3.1415927f)
		{
			num2 -= 6.2831855f;
		}
		float num3 = num + 3 * num2;
		float num4 = 1.Length();
		return new 208(num4 * 2117.25(num3), num4 * 2117.26(num3));
	}

	// Token: 0x06003552 RID: 13650 RVA: 0x0014A19A File Offset: 0x0014839A
	private static void 20(2117.2120 1, float 2)
	{
		1.7.7(2);
		1.5.2.Add(2);
	}

	// Token: 0x06003553 RID: 13651 RVA: 0x0014A1BC File Offset: 0x001483BC
	private static 208 21(208 1, float 2)
	{
		float num = 2117.24(1.Y, 1.X) + 2;
		float num2 = 1.Length();
		return new 208(num2 * 2117.25(num), num2 * 2117.26(num));
	}

	// Token: 0x06003554 RID: 13652 RVA: 0x0014A1FC File Offset: 0x001483FC
	private static float 22(float 1, float 2)
	{
		float num = Math.Abs(1 - 2) % 6.2831855f;
		return Math.Min(num, 6.2831855f - num);
	}

	// Token: 0x06003555 RID: 13653 RVA: 0x0014A225 File Offset: 0x00148425
	private static float 23(float 1, float 2, float 3)
	{
		if (1 < 2)
		{
			return 2;
		}
		if (1 <= 3)
		{
			return 1;
		}
		return 3;
	}

	// Token: 0x06003556 RID: 13654 RVA: 0x0014A234 File Offset: 0x00148434
	private static float 24(float 1, float 2)
	{
		return (float)Math.Atan2((double)1, (double)2);
	}

	// Token: 0x06003557 RID: 13655 RVA: 0x0014A240 File Offset: 0x00148440
	private static float 25(float 1)
	{
		return (float)Math.Cos((double)1);
	}

	// Token: 0x06003558 RID: 13656 RVA: 0x0014A24A File Offset: 0x0014844A
	private static float 26(float 1)
	{
		return (float)Math.Sin((double)1);
	}

	// Token: 0x06003559 RID: 13657 RVA: 0x0014A254 File Offset: 0x00148454
	private static float 27(208 1)
	{
		float num = 1.X * 1.X + 1.Y * 1.Y;
		float num2 = 0.5f * num;
		int num3 = BitConverter.ToInt32(BitConverter.GetBytes(num), 0);
		num3 = 1597463174 - (num3 >> 1);
		num = BitConverter.ToSingle(BitConverter.GetBytes(num3), 0);
		num *= 1.5f - num2 * num * num;
		return 1f / num;
	}

	// Token: 0x04002780 RID: 10112
	private const float 1 = 512f;

	// Token: 0x04002781 RID: 10113
	private const float 2 = 384f;

	// Token: 0x04002782 RID: 10114
	private const float 3 = 0.375f;

	// Token: 0x04002783 RID: 10115
	private const float 4 = 192f;

	// Token: 0x04002784 RID: 10116
	private const float 5 = 144f;

	// Token: 0x04002785 RID: 10117
	private const int 6 = 10;

	// Token: 0x04002786 RID: 10118
	private const float 7 = 3.1415927f;

	// Token: 0x04002787 RID: 10119
	private const float 8 = 10f;

	// Token: 0x04002788 RID: 10120
	private const float 9 = 7f;

	// Token: 0x04002789 RID: 10121
	private static readonly 208 10 = new 208(256f, 192f);

	// Token: 0x0400278A RID: 10122
	public readonly 2117.2118[] 11;

	// Token: 0x0400278B RID: 10123
	private readonly Random 12;

	// Token: 0x0400278C RID: 10124
	private readonly float 13;

	// Token: 0x0400278D RID: 10125
	private readonly float 14;

	// Token: 0x02000710 RID: 1808
	[276]
	public sealed class 2118
	{
		// Token: 0x0600355B RID: 13659 RVA: 0x0014A2D4 File Offset: 0x001484D4
		public 208 1(208 1)
		{
			foreach (float f in this.2)
			{
				1 = (float.IsNaN(f) ? new 208(-1.X, 1.Y) : 2114.8(1, f));
			}
			return 1;
		}

		// Token: 0x0400278E RID: 10126
		public 208 1;

		// Token: 0x0400278F RID: 10127
		public readonly List<float> 2 = new List<float>();

		// Token: 0x04002790 RID: 10128
		public int 3;

		// Token: 0x04002791 RID: 10129
		public bool 4;
	}

	// Token: 0x02000711 RID: 1809
	[276]
	private enum 2119
	{
		// Token: 0x04002793 RID: 10131
		Circle,
		// Token: 0x04002794 RID: 10132
		Slider,
		// Token: 0x04002795 RID: 10133
		Spinner
	}

	// Token: 0x02000712 RID: 1810
	[276]
	private sealed class 2120
	{
		// Token: 0x1700028A RID: 650
		// (get) Token: 0x0600355D RID: 13661 RVA: 0x0014A35B File Offset: 0x0014855B
		public 208 CurrentEndVector
		{
			get
			{
				return this.7.10(1.0);
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x0600355E RID: 13662 RVA: 0x0014A374 File Offset: 0x00148574
		public float SliderRotation
		{
			get
			{
				208 currentEndVector = this.CurrentEndVector;
				return 2117.24(currentEndVector.Y, currentEndVector.X);
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x0600355F RID: 13663 RVA: 0x0014A399 File Offset: 0x00148599
		public 208 EndPosition
		{
			get
			{
				if (this.1 != 2117.2119.Slider || this.8 % 2 != 1)
				{
					return this.6;
				}
				return this.6 + this.CurrentEndVector;
			}
		}

		// Token: 0x04002796 RID: 10134
		public 2117.2119 1;

		// Token: 0x04002797 RID: 10135
		public int 2;

		// Token: 0x04002798 RID: 10136
		public bool 3;

		// Token: 0x04002799 RID: 10137
		public int 4;

		// Token: 0x0400279A RID: 10138
		public 2117.2118 5;

		// Token: 0x0400279B RID: 10139
		public 208 6;

		// Token: 0x0400279C RID: 10140
		public 2114 7;

		// Token: 0x0400279D RID: 10141
		public int 8;

		// Token: 0x0400279E RID: 10142
		public float 9;

		// Token: 0x0400279F RID: 10143
		public float 10;

		// Token: 0x040027A0 RID: 10144
		public float 11;

		// Token: 0x040027A1 RID: 10145
		public float 12;

		// Token: 0x040027A2 RID: 10146
		public 208 13;

		// Token: 0x040027A3 RID: 10147
		public 208 14;
	}
}
