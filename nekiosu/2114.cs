using System;
using System.Collections.Generic;
using System.Globalization;

// Token: 0x0200070C RID: 1804
[276]
internal sealed class 2114
{
	// Token: 0x06003522 RID: 13602 RVA: 0x00147CDC File Offset: 0x00145EDC
	private 2114(2114.2115[] 1, double? 2)
	{
		this.6 = 1;
		this.7 = 2;
	}

	// Token: 0x06003523 RID: 13603 RVA: 0x00147CF4 File Offset: 0x00145EF4
	public static 2114 1(string 1, int 2, int 3, double 4, bool 5, bool 6)
	{
		208 7 = new 208((float)2, (float)3);
		string[] array = 1.Split(new char[]
		{
			'|'
		});
		List<208> list = new List<208>(array.Length);
		List<KeyValuePair<2114.2116, int>> list2 = new List<KeyValuePair<2114.2116, int>>();
		List<int> list3 = new List<int>();
		foreach (string text in array)
		{
			if (text.Length != 0)
			{
				if (char.IsLetter(text[0]))
				{
					int item;
					list2.Add(new KeyValuePair<2114.2116, int>(2114.3(text, out item), list.Count));
					list3.Add(item);
					if (list.Count == 0)
					{
						list.Add(208.Zero);
					}
				}
				else
				{
					string[] array3 = text.Split(new char[]
					{
						':'
					});
					208 8 = new 208((float)((int)2114.2(array3[0])), (float)((int)2114.2(array3[1])));
					list.Add(8 - 7);
				}
			}
		}
		List<2114.2115> list4 = new List<2114.2115>();
		for (int j = 0; j < list2.Count; j++)
		{
			int value = list2[j].Value;
			int num = (j < list2.Count - 1) ? list2[j + 1].Value : list.Count;
			208? 9 = (j < list2.Count - 1 && num < list.Count) ? new 208?(list[num]) : null;
			2114.4(list2[j].Key, list3[j], list.GetRange(value, num - value), 9, list4);
		}
		2114.2115[] array4 = list4.ToArray();
		for (int k = 0; k < array4.Length; k++)
		{
			if (5)
			{
				array4[k].1.X = -array4[k].1.X;
			}
			if (6)
			{
				array4[k].1.Y = -array4[k].1.Y;
			}
		}
		double? num2 = (4 > 0.0) ? new double?(Math.Max(0.0, 4)) : null;
		return new 2114(array4, num2);
	}

	// Token: 0x06003524 RID: 13604 RVA: 0x00147F4C File Offset: 0x0014614C
	private static float 2(string 1)
	{
		return float.Parse(1.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture);
	}

	// Token: 0x06003525 RID: 13605 RVA: 0x00147F64 File Offset: 0x00146164
	private static 2114.2116 3(string 1, out int 2)
	{
		2 = 0;
		char c = 1[0];
		if (c == 'B')
		{
			int num;
			if (1.Length > 1 && int.TryParse(1.Substring(1), out num) && num > 0)
			{
				2 = num;
			}
			return 2114.2116.BSpline;
		}
		if (c == 'L')
		{
			return 2114.2116.Linear;
		}
		if (c != 'P')
		{
			return 2114.2116.Catmull;
		}
		return 2114.2116.PerfectCurve;
	}

	// Token: 0x06003526 RID: 13606 RVA: 0x00147FB4 File Offset: 0x001461B4
	private static void 4(2114.2116 1, int 2, List<208> 3, 208? 4, List<2114.2115> 5)
	{
		if (3.Count == 0)
		{
			return;
		}
		2114.2115[] array = new 2114.2115[3.Count];
		for (int i = 0; i < 3.Count; i++)
		{
			array[i].1 = 3[i];
		}
		if (1 == 2114.2116.PerfectCurve)
		{
			int num = ((4 != null) > false) ? 1 : 0;
			if (array.Length + num != 3)
			{
				1 = 2114.2116.BSpline;
				2 = 0;
			}
			else if (2114.5(3[0], 3[1], 4 ?? 3[2]))
			{
				1 = 2114.2116.Linear;
			}
		}
		array[0].2 = 1;
		array[0].3 = 2;
		int num2 = 0;
		int num3 = 0;
		while (++num3 < array.Length)
		{
			if (!(array[num3].1 != array[num3 - 1].1) && (1 != 2114.2116.Catmull || num3 <= 1) && num3 != array.Length - 1)
			{
				array[num3 - 1].2 = 1;
				array[num3 - 1].3 = 2;
				for (int j = num2; j < num3; j++)
				{
					5.Add(array[j]);
				}
				num2 = num3 + 1;
			}
		}
		for (int k = num2; k < num3; k++)
		{
			5.Add(array[k]);
		}
	}

	// Token: 0x06003527 RID: 13607 RVA: 0x0014810C File Offset: 0x0014630C
	private static bool 5(208 1, 208 2, 208 3)
	{
		return Math.Abs((2.Y - 1.Y) * (3.X - 1.X) - (2.X - 1.X) * (3.Y - 1.Y)) <= 0.001f;
	}

	// Token: 0x06003528 RID: 13608 RVA: 0x00148160 File Offset: 0x00146360
	public void 6()
	{
		for (int i = 0; i < this.6.Length; i++)
		{
			this.6[i].1 = new 208(-this.6[i].1.X, this.6[i].1.Y);
		}
		this.9();
	}

	// Token: 0x06003529 RID: 13609 RVA: 0x001481CC File Offset: 0x001463CC
	public void 7(float 1)
	{
		for (int i = 0; i < this.6.Length; i++)
		{
			this.6[i].1 = 2114.8(this.6[i].1, 1);
		}
		this.9();
	}

	// Token: 0x0600352A RID: 13610 RVA: 0x0014821C File Offset: 0x0014641C
	public static 208 8(208 1, float 2)
	{
		float num = (float)Math.Atan2((double)1.Y, (double)1.X) + 2;
		float num2 = 1.Length();
		return new 208(num2 * (float)Math.Cos((double)num), num2 * (float)Math.Sin((double)num));
	}

	// Token: 0x0600352B RID: 13611 RVA: 0x00148261 File Offset: 0x00146461
	private void 9()
	{
		this.8 = null;
		this.9 = null;
	}

	// Token: 0x17000288 RID: 648
	// (get) Token: 0x0600352C RID: 13612 RVA: 0x00148271 File Offset: 0x00146471
	public List<208> CalculatedPath
	{
		get
		{
			this.11();
			return this.8;
		}
	}

	// Token: 0x17000289 RID: 649
	// (get) Token: 0x0600352D RID: 13613 RVA: 0x0014827F File Offset: 0x0014647F
	public double Distance
	{
		get
		{
			this.11();
			if (this.9.Count != 0)
			{
				return this.9[this.9.Count - 1];
			}
			return 0.0;
		}
	}

	// Token: 0x0600352E RID: 13614 RVA: 0x001482B8 File Offset: 0x001464B8
	public 208 10(double 1)
	{
		this.11();
		double num = Math.Max(0.0, Math.Min(1.0, 1)) * this.Distance;
		return this.16(this.15(num), num);
	}

	// Token: 0x0600352F RID: 13615 RVA: 0x001482FE File Offset: 0x001464FE
	private void 11()
	{
		if (this.8 != null)
		{
			return;
		}
		this.8 = new List<208>();
		this.9 = new List<double>();
		this.12();
		this.14();
	}

	// Token: 0x06003530 RID: 13616 RVA: 0x0014832C File Offset: 0x0014652C
	private void 12()
	{
		if (this.6.Length == 0)
		{
			return;
		}
		int num = 0;
		for (int i = 0; i < this.6.Length; i++)
		{
			if (this.6[i].2 != 2114.2116.None || i >= this.6.Length - 1)
			{
				int num2 = i - num + 1;
				208[] array = new 208[num2];
				for (int j = 0; j < num2; j++)
				{
					array[j] = this.6[num + j].1;
				}
				2114.2116 <<EMPTY_NAME>> = (this.6[num].2 == 2114.2116.None) ? 2114.2116.Linear : this.6[num].2;
				if (array.Length == 1)
				{
					this.8.Add(array[0]);
				}
				else if (array.Length > 1)
				{
					List<208> list = 2114.13(array, <<EMPTY_NAME>>, this.6[num].3);
					for (int k = ((this.8.Count > 0 && list.Count > 0 && this.8[this.8.Count - 1] == list[0]) > false) ? 1 : 0; k < list.Count; k++)
					{
						this.8.Add(list[k]);
					}
				}
				num = i;
			}
		}
	}

	// Token: 0x06003531 RID: 13617 RVA: 0x00148494 File Offset: 0x00146694
	private static List<208> 13(208[] 1, 2114.2116 2, int 3)
	{
		switch (2)
		{
		case 2114.2116.Linear:
			return new List<208>(1);
		case 2114.2116.PerfectCurve:
		{
			double num;
			double num2;
			double num3;
			float num4;
			208 4;
			if (1.Length == 3 && 2114.25(1, out num, out num2, out num3, out num4, out 4) && ((2f * num4 <= 0.1f) ? 2 : Math.Max(2, (int)Math.Ceiling(num2 / (2.0 * Math.Acos((double)(1f - 0.1f / num4)))))) < 1000)
			{
				List<208> list = 2114.24(1);
				if (list.Count > 0)
				{
					return list;
				}
			}
			break;
		}
		case 2114.2116.Catmull:
			return 2114.22(1);
		}
		return 2114.17(1, (3 > 0) ? 3 : 1.Length);
	}

	// Token: 0x06003532 RID: 13618 RVA: 0x00148548 File Offset: 0x00146748
	private void 14()
	{
		double num = 0.0;
		this.9.Add(0.0);
		for (int i = 0; i < this.8.Count - 1; i++)
		{
			num += (double)(this.8[i + 1] - this.8[i]).Length();
			this.9.Add(num);
		}
		if (this.7 != null && num != this.7.Value)
		{
			double value = this.7.Value;
			if (this.8.Count >= 2 && this.8[this.8.Count - 1] == this.8[this.8.Count - 2] && value > num)
			{
				this.9.Add(num);
				return;
			}
			this.9.RemoveAt(this.9.Count - 1);
			int num2 = this.8.Count - 1;
			if (num > value)
			{
				while (this.9.Count > 0 && this.9[this.9.Count - 1] >= value)
				{
					this.9.RemoveAt(this.9.Count - 1);
					this.8.RemoveAt(num2--);
				}
			}
			if (num2 <= 0)
			{
				this.9.Add(0.0);
				return;
			}
			208 <<EMPTY_NAME>> = this.8[num2] - this.8[num2 - 1];
			<<EMPTY_NAME>> *= 1f / <<EMPTY_NAME>>.Length();
			this.8[num2] = this.8[num2 - 1] + <<EMPTY_NAME>> * (float)(value - this.9[this.9.Count - 1]);
			this.9.Add(value);
		}
	}

	// Token: 0x06003533 RID: 13619 RVA: 0x00148768 File Offset: 0x00146968
	private int 15(double 1)
	{
		int num = this.9.BinarySearch(1);
		if (num >= 0)
		{
			return num;
		}
		return ~num;
	}

	// Token: 0x06003534 RID: 13620 RVA: 0x0014878C File Offset: 0x0014698C
	private 208 16(int 1, double 2)
	{
		if (this.8.Count == 0)
		{
			return 208.Zero;
		}
		if (1 <= 0)
		{
			return this.8[0];
		}
		if (1 >= this.8.Count)
		{
			return this.8[this.8.Count - 1];
		}
		208 result = this.8[1 - 1];
		208 3 = this.8[1];
		double num = this.9[1 - 1];
		double num2 = this.9[1];
		if (Math.Abs(num - num2) <= 1E-07)
		{
			return result;
		}
		double num3 = (2 - num) / (num2 - num);
		return result + (3 - result) * (float)num3;
	}

	// Token: 0x06003535 RID: 13621 RVA: 0x00148850 File Offset: 0x00146A50
	private static List<208> 17(208[] 1, int 2)
	{
		if (1.Length >= 2)
		{
			2 = Math.Min(2, 1.Length - 1);
			List<208> list = new List<208>();
			int num = 1.Length - 1;
			Stack<208[]> stack = 2114.18(1, ref 2);
			Stack<208[]> stack2 = new Stack<208[]>();
			208[] array = new 208[2 + 1];
			208[] array2 = new 208[2 * 2 + 1];
			208[] array3 = array2;
			while (stack.Count > 0)
			{
				208[] array4 = stack.Pop();
				if (2114.19(array4))
				{
					2114.21(array4, list, array, array2, 2 + 1);
					stack2.Push(array4);
				}
				else
				{
					208[] item = (stack2.Count > 0) ? stack2.Pop() : new 208[2 + 1];
					2114.20(array4, array3, item, array, 2 + 1);
					for (int i = 0; i < 2 + 1; i++)
					{
						array4[i] = array3[i];
					}
					stack.Push(item);
					stack.Push(array4);
				}
			}
			list.Add(1[num]);
			return list;
		}
		if (1.Length != 0)
		{
			return new List<208>
			{
				1[0]
			};
		}
		return new List<208>();
	}

	// Token: 0x06003536 RID: 13622 RVA: 0x0014896C File Offset: 0x00146B6C
	private static Stack<208[]> 18(208[] 1, ref int 2)
	{
		Stack<208[]> stack = new Stack<208[]>();
		2 = Math.Min(2, 1.Length - 1);
		int num = 1.Length - 1;
		208[] array = (208[])1.Clone();
		if (2 == num)
		{
			stack.Push(array);
			return stack;
		}
		for (int i = 0; i < num - 2; i++)
		{
			208[] array2 = new 208[2 + 1];
			array2[0] = array[i];
			for (int j = 0; j < 2 - 1; j++)
			{
				array2[j + 1] = array[i + 1];
				for (int k = 1; k < 2 - j; k++)
				{
					int num2 = Math.Min(k, num - 2 - i);
					array[i + k] = ((float)num2 * array[i + k] + array[i + k + 1]) / (float)(num2 + 1);
				}
			}
			array2[2] = array[i + 1];
			stack.Push(array2);
		}
		208[] array3 = new 208[array.Length - (num - 2)];
		Array.Copy(array, num - 2, array3, 0, array3.Length);
		stack.Push(array3);
		return new Stack<208[]>(stack);
	}

	// Token: 0x06003537 RID: 13623 RVA: 0x00148AB0 File Offset: 0x00146CB0
	private static bool 19(208[] 1)
	{
		for (int i = 1; i < 1.Length - 1; i++)
		{
			if ((1[i - 1] - 2f * 1[i] + 1[i + 1]).LengthSquared() > 0.25f)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06003538 RID: 13624 RVA: 0x00148B0C File Offset: 0x00146D0C
	private static void 20(208[] 1, 208[] 2, 208[] 3, 208[] 4, int 5)
	{
		for (int i = 0; i < 5; i++)
		{
			4[i] = 1[i];
		}
		for (int j = 0; j < 5; j++)
		{
			2[j] = 4[0];
			3[5 - j - 1] = 4[5 - j - 1];
			for (int k = 0; k < 5 - j - 1; k++)
			{
				4[k] = (4[k] + 4[k + 1]) / 2f;
			}
		}
	}

	// Token: 0x06003539 RID: 13625 RVA: 0x00148BA0 File Offset: 0x00146DA0
	private static void 21(208[] 1, List<208> 2, 208[] 3, 208[] 4, int 5)
	{
		2114.20(1, 4, 3, 3, 5);
		for (int i = 0; i < 5 - 1; i++)
		{
			4[5 + i] = 3[i + 1];
		}
		2.Add(1[0]);
		for (int j = 1; j < 5 - 1; j++)
		{
			int num = 2 * j;
			208 item = 0.25f * (4[num - 1] + 2f * 4[num] + 4[num + 1]);
			2.Add(item);
		}
	}

	// Token: 0x0600353A RID: 13626 RVA: 0x00148C44 File Offset: 0x00146E44
	private static List<208> 22(208[] 1)
	{
		List<208> list = new List<208>((1.Length - 1) * 50 * 2);
		for (int i = 0; i < 1.Length - 1; i++)
		{
			208 2 = (i > 0) ? 1[i - 1] : 1[i];
			208 3 = 1[i];
			208 4 = (i < 1.Length - 1) ? 1[i + 1] : (3 + 3 - 2);
			208 5 = (i < 1.Length - 2) ? 1[i + 2] : (4 + 4 - 3);
			for (int j = 0; j < 50; j++)
			{
				list.Add(2114.23(2, 3, 4, 5, (float)j / 50f));
				list.Add(2114.23(2, 3, 4, 5, (float)(j + 1) / 50f));
			}
		}
		return list;
	}

	// Token: 0x0600353B RID: 13627 RVA: 0x00148D24 File Offset: 0x00146F24
	private static 208 23(208 1, 208 2, 208 3, 208 4, float 5)
	{
		float num = 5 * 5;
		float num2 = 5 * num;
		208 result;
		result.X = 0.5f * (2f * 2.X + (-1.X + 3.X) * 5 + (2f * 1.X - 5f * 2.X + 4f * 3.X - 4.X) * num + (-1.X + 3f * 2.X - 3f * 3.X + 4.X) * num2);
		result.Y = 0.5f * (2f * 2.Y + (-1.Y + 3.Y) * 5 + (2f * 1.Y - 5f * 2.Y + 4f * 3.Y - 4.Y) * num + (-1.Y + 3f * 2.Y - 3f * 3.Y + 4.Y) * num2);
		return result;
	}

	// Token: 0x0600353C RID: 13628 RVA: 0x00148E4C File Offset: 0x0014704C
	private static List<208> 24(208[] 1)
	{
		double num;
		double num2;
		double num3;
		float num4;
		208 2;
		if (!2114.25(1, out num, out num2, out num3, out num4, out 2))
		{
			return 2114.17(1, Math.Max(1, 1.Length - 1));
		}
		int num5 = (2f * num4 <= 0.1f) ? 2 : Math.Max(2, (int)Math.Ceiling(num2 / (2.0 * Math.Acos((double)(1f - 0.1f / num4)))));
		List<208> list = new List<208>(num5);
		for (int i = 0; i < num5; i++)
		{
			double num6 = (double)i / (double)(num5 - 1);
			double num7 = num + num3 * num6 * num2;
			208 3 = new 208((float)Math.Cos(num7), (float)Math.Sin(num7)) * num4;
			list.Add(2 + 3);
		}
		return list;
	}

	// Token: 0x0600353D RID: 13629 RVA: 0x00148F1C File Offset: 0x0014711C
	private static bool 25(208[] 1, out double 2, out double 3, out double 4, out float 5, out 208 6)
	{
		208 7 = 1[0];
		208 8 = 1[1];
		208 9 = 1[2];
		2 = 0.0;
		3 = 0.0;
		4 = 0.0;
		5 = 0f;
		6 = 208.Zero;
		if (Math.Abs((8.Y - 7.Y) * (9.X - 7.X) - (8.X - 7.X) * (9.Y - 7.Y)) <= 0.001f)
		{
			return false;
		}
		float num = 2f * (7.X * (8 - 9).Y + 8.X * (9 - 7).Y + 9.X * (7 - 8).Y);
		float num2 = 7.LengthSquared();
		float num3 = 8.LengthSquared();
		float num4 = 9.LengthSquared();
		6 = new 208(num2 * (8 - 9).Y + num3 * (9 - 7).Y + num4 * (7 - 8).Y, num2 * (9 - 8).X + num3 * (7 - 9).X + num4 * (8 - 7).X) / num;
		208 10 = 7 - 6;
		208 11 = 9 - 6;
		5 = 10.Length();
		2 = Math.Atan2((double)10.Y, (double)10.X);
		double num5;
		for (num5 = Math.Atan2((double)11.Y, (double)11.X); num5 < 2; num5 += 6.283185307179586)
		{
		}
		4 = 1.0;
		3 = num5 - 2;
		208 12 = 9 - 7;
		12 = new 208(12.Y, -12.X);
		if (208.Dot(12, 8 - 7) < 0f)
		{
			4 = -4;
			3 = 6.283185307179586 - 3;
		}
		return true;
	}

	// Token: 0x0400276E RID: 10094
	private const float 1 = 0.25f;

	// Token: 0x0400276F RID: 10095
	private const int 2 = 50;

	// Token: 0x04002770 RID: 10096
	private const float 3 = 0.1f;

	// Token: 0x04002771 RID: 10097
	private const float 4 = 0.001f;

	// Token: 0x04002772 RID: 10098
	private const double 5 = 1E-07;

	// Token: 0x04002773 RID: 10099
	private readonly 2114.2115[] 6;

	// Token: 0x04002774 RID: 10100
	private readonly double? 7;

	// Token: 0x04002775 RID: 10101
	private List<208> 8;

	// Token: 0x04002776 RID: 10102
	private List<double> 9;

	// Token: 0x0200070D RID: 1805
	[276]
	private enum 2116
	{
		// Token: 0x04002778 RID: 10104
		None,
		// Token: 0x04002779 RID: 10105
		Linear,
		// Token: 0x0400277A RID: 10106
		PerfectCurve,
		// Token: 0x0400277B RID: 10107
		Catmull,
		// Token: 0x0400277C RID: 10108
		BSpline
	}

	// Token: 0x0200070E RID: 1806
	[276]
	private struct 2115
	{
		// Token: 0x0400277D RID: 10109
		public 208 1;

		// Token: 0x0400277E RID: 10110
		public 2114.2116 2;

		// Token: 0x0400277F RID: 10111
		public int 3;
	}
}
