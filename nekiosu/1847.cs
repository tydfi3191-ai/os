using System;
using System.Collections.Generic;
using System.Globalization;

// Token: 0x020007DA RID: 2010
internal sealed class 1847
{
	// Token: 0x06003A5C RID: 14940 RVA: 0x0016F68E File Offset: 0x0016D88E
	private 1847(1847.1848[] 1, double? 2)
	{
		this.6 = 1;
		this.7 = 2;
	}

	// Token: 0x06003A5D RID: 14941 RVA: 0x0016F6A4 File Offset: 0x0016D8A4
	public static 1847 1(string 1, int 2, int 3, double 4, bool 5, bool 6)
	{
		return 1847.2(1, new 208((float)2, (float)3), 4, 5, 6);
	}

	// Token: 0x06003A5E RID: 14942 RVA: 0x0016F6BC File Offset: 0x0016D8BC
	public static 1847 2(string 1, 208 2, double 3, bool 4, bool 5)
	{
		string[] array = 1.Split(new char[]
		{
			'|'
		});
		List<208> list = new List<208>(array.Length);
		List<KeyValuePair<1847.1849, int>> list2 = new List<KeyValuePair<1847.1849, int>>();
		List<int> list3 = new List<int>();
		foreach (string text in array)
		{
			if (text.Length != 0)
			{
				if (char.IsLetter(text[0]))
				{
					int item;
					list2.Add(new KeyValuePair<1847.1849, int>(1847.4(text, out item), list.Count));
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
					208 6 = new 208((float)((int)1847.3(array3[0])), (float)((int)1847.3(array3[1])));
					list.Add(1847.8(6, 2));
				}
			}
		}
		List<1847.1848> list4 = new List<1847.1848>();
		for (int j = 0; j < list2.Count; j++)
		{
			int value = list2[j].Value;
			int num = (j < list2.Count - 1) ? list2[j + 1].Value : list.Count;
			208? 7 = (j < list2.Count - 1 && num < list.Count) ? new 208?(list[num]) : null;
			1847.5(list2[j].Key, list3[j], list.GetRange(value, num - value), 7, list4);
		}
		1847.1848[] array4 = list4.ToArray();
		for (int k = 0; k < array4.Length; k++)
		{
			if (4)
			{
				array4[k].1.X = -array4[k].1.X;
			}
			if (5)
			{
				array4[k].1.Y = -array4[k].1.Y;
			}
		}
		double? num2 = (3 > 0.0) ? new double?(Math.Max(0.0, 3)) : null;
		return new 1847(array4, num2);
	}

	// Token: 0x06003A5F RID: 14943 RVA: 0x00147F4C File Offset: 0x0014614C
	private static float 3(string 1)
	{
		return float.Parse(1.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture);
	}

	// Token: 0x06003A60 RID: 14944 RVA: 0x0016F908 File Offset: 0x0016DB08
	private static 1847.1849 4(string 1, out int 2)
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
			return 1847.1849.BSpline;
		}
		if (c == 'L')
		{
			return 1847.1849.Linear;
		}
		if (c != 'P')
		{
			return 1847.1849.Catmull;
		}
		return 1847.1849.PerfectCurve;
	}

	// Token: 0x06003A61 RID: 14945 RVA: 0x0016F958 File Offset: 0x0016DB58
	private static void 5(1847.1849 1, int 2, List<208> 3, 208? 4, List<1847.1848> 5)
	{
		if (3.Count == 0)
		{
			return;
		}
		1847.1848[] array = new 1847.1848[3.Count];
		for (int i = 0; i < 3.Count; i++)
		{
			array[i].1 = 3[i];
		}
		if (1 == 1847.1849.PerfectCurve)
		{
			int num = ((4 != null) > false) ? 1 : 0;
			if (array.Length + num != 3)
			{
				1 = 1847.1849.BSpline;
				2 = 0;
			}
			else if (1847.6(3[0], 3[1], 4 ?? 3[2]))
			{
				1 = 1847.1849.Linear;
			}
		}
		array[0].2 = 1;
		array[0].3 = 2;
		int num2 = 0;
		int num3 = 0;
		while (++num3 < array.Length)
		{
			if (!(array[num3].1 != array[num3 - 1].1) && (1 != 1847.1849.Catmull || num3 <= 1) && num3 != array.Length - 1)
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

	// Token: 0x06003A62 RID: 14946 RVA: 0x0016FAAE File Offset: 0x0016DCAE
	private static bool 6(208 1, 208 2, 208 3)
	{
		return Math.Abs(1847.13(1, 2, 3)) <= 0.001f;
	}

	// Token: 0x06003A63 RID: 14947 RVA: 0x0016FAC7 File Offset: 0x0016DCC7
	private static 208 7(208 1, 208 2)
	{
		return new 208(1.X + 2.X, 1.Y + 2.Y);
	}

	// Token: 0x06003A64 RID: 14948 RVA: 0x0016FAEA File Offset: 0x0016DCEA
	private static 208 8(208 1, 208 2)
	{
		return new 208(1.X - 2.X, 1.Y - 2.Y);
	}

	// Token: 0x06003A65 RID: 14949 RVA: 0x0016FB0D File Offset: 0x0016DD0D
	private static 208 9(208 1, float 2)
	{
		return new 208(1.X * 2, 1.Y * 2);
	}

	// Token: 0x06003A66 RID: 14950 RVA: 0x0016FB26 File Offset: 0x0016DD26
	private static 208 10(208 1, float 2)
	{
		return new 208(1.X / 2, 1.Y / 2);
	}

	// Token: 0x06003A67 RID: 14951 RVA: 0x0016FB3F File Offset: 0x0016DD3F
	private static float 11(208 1)
	{
		return 1.X * 1.X + 1.Y * 1.Y;
	}

	// Token: 0x06003A68 RID: 14952 RVA: 0x0016FB5F File Offset: 0x0016DD5F
	private static float Length(208 1)
	{
		return (float)Math.Sqrt((double)1847.11(1));
	}

	// Token: 0x06003A69 RID: 14953 RVA: 0x0016FB6E File Offset: 0x0016DD6E
	private static float 12(208 1, 208 2)
	{
		return 1.X * 2.X + 1.Y * 2.Y;
	}

	// Token: 0x06003A6A RID: 14954 RVA: 0x0016FB8E File Offset: 0x0016DD8E
	private static float 13(208 1, 208 2, 208 3)
	{
		return (2.Y - 1.Y) * (3.X - 1.X) - (2.X - 1.X) * (3.Y - 1.Y);
	}

	// Token: 0x06003A6B RID: 14955 RVA: 0x0016FBD0 File Offset: 0x0016DDD0
	public void 14()
	{
		for (int i = 0; i < this.6.Length; i++)
		{
			this.6[i].1 = new 208(-this.6[i].1.X, this.6[i].1.Y);
		}
		this.17();
	}

	// Token: 0x06003A6C RID: 14956 RVA: 0x0016FC3C File Offset: 0x0016DE3C
	public void 15(float 1)
	{
		for (int i = 0; i < this.6.Length; i++)
		{
			this.6[i].1 = 1847.16(this.6[i].1, 1);
		}
		this.17();
	}

	// Token: 0x06003A6D RID: 14957 RVA: 0x0016FC8C File Offset: 0x0016DE8C
	public static 208 16(208 1, float 2)
	{
		float num = (float)Math.Atan2((double)1.Y, (double)1.X) + 2;
		float num2 = 1847.Length(1);
		return new 208(num2 * (float)Math.Cos((double)num), num2 * (float)Math.Sin((double)num));
	}

	// Token: 0x06003A6E RID: 14958 RVA: 0x0016FCD3 File Offset: 0x0016DED3
	private void 17()
	{
		this.8 = null;
		this.9 = null;
	}

	// Token: 0x170002A1 RID: 673
	// (get) Token: 0x06003A6F RID: 14959 RVA: 0x0016FCE3 File Offset: 0x0016DEE3
	public List<208> CalculatedPath
	{
		get
		{
			this.19();
			return this.8;
		}
	}

	// Token: 0x170002A2 RID: 674
	// (get) Token: 0x06003A70 RID: 14960 RVA: 0x0016FCF1 File Offset: 0x0016DEF1
	public double Distance
	{
		get
		{
			this.19();
			if (this.9.Count != 0)
			{
				return this.9[this.9.Count - 1];
			}
			return 0.0;
		}
	}

	// Token: 0x170002A3 RID: 675
	// (get) Token: 0x06003A71 RID: 14961 RVA: 0x0016FD28 File Offset: 0x0016DF28
	public float LastControlPointX
	{
		get
		{
			if (this.6.Length != 0)
			{
				return this.6[this.6.Length - 1].1.X;
			}
			return 0f;
		}
	}

	// Token: 0x06003A72 RID: 14962 RVA: 0x0016FD58 File Offset: 0x0016DF58
	public 208 18(double 1)
	{
		this.19();
		double num = Math.Max(0.0, Math.Min(1.0, 1)) * this.Distance;
		return this.24(this.23(num), num);
	}

	// Token: 0x06003A73 RID: 14963 RVA: 0x0016FD9E File Offset: 0x0016DF9E
	private void 19()
	{
		if (this.8 != null)
		{
			return;
		}
		this.8 = new List<208>();
		this.9 = new List<double>();
		this.20();
		this.22();
	}

	// Token: 0x06003A74 RID: 14964 RVA: 0x0016FDCC File Offset: 0x0016DFCC
	private void 20()
	{
		if (this.6.Length == 0)
		{
			return;
		}
		int num = 0;
		for (int i = 0; i < this.6.Length; i++)
		{
			if (this.6[i].2 != 1847.1849.None || i >= this.6.Length - 1)
			{
				int num2 = i - num + 1;
				208[] array = new 208[num2];
				for (int j = 0; j < num2; j++)
				{
					array[j] = this.6[num + j].1;
				}
				1847.1849 <<EMPTY_NAME>> = (this.6[num].2 == 1847.1849.None) ? 1847.1849.Linear : this.6[num].2;
				if (array.Length == 1)
				{
					this.8.Add(array[0]);
				}
				else if (array.Length > 1)
				{
					List<208> list = 1847.21(array, <<EMPTY_NAME>>, this.6[num].3);
					for (int k = ((this.8.Count > 0 && list.Count > 0 && this.8[this.8.Count - 1] == list[0]) > false) ? 1 : 0; k < list.Count; k++)
					{
						this.8.Add(list[k]);
					}
				}
				num = i;
			}
		}
	}

	// Token: 0x06003A75 RID: 14965 RVA: 0x0016FF34 File Offset: 0x0016E134
	private static List<208> 21(208[] 1, 1847.1849 2, int 3)
	{
		switch (2)
		{
		case 1847.1849.Linear:
			return new List<208>(1);
		case 1847.1849.PerfectCurve:
		{
			double num;
			double num2;
			double num3;
			float num4;
			208 4;
			if (1.Length == 3 && 1847.34(1, out num, out num2, out num3, out num4, out 4) && ((2f * num4 <= 0.1f) ? 2 : Math.Max(2, (int)Math.Ceiling(num2 / (2.0 * Math.Acos((double)(1f - 0.1f / num4)))))) < 1000)
			{
				List<208> list = 1847.33(1);
				if (list.Count > 0)
				{
					return list;
				}
			}
			break;
		}
		case 1847.1849.Catmull:
			return 1847.30(1);
		}
		return 1847.25(1, (3 > 0) ? 3 : 1.Length);
	}

	// Token: 0x06003A76 RID: 14966 RVA: 0x0016FFEC File Offset: 0x0016E1EC
	private void 22()
	{
		double num = 0.0;
		this.9.Add(0.0);
		for (int i = 0; i < this.8.Count - 1; i++)
		{
			208 <<EMPTY_NAME>> = 1847.8(this.8[i + 1], this.8[i]);
			num += (double)1847.Length(<<EMPTY_NAME>>);
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
			208 2 = 1847.8(this.8[num2], this.8[num2 - 1]);
			2 = 1847.9(2, 1f / 1847.Length(2));
			this.8[num2] = 1847.7(this.8[num2 - 1], 1847.9(2, (float)(value - this.9[this.9.Count - 1])));
			this.9.Add(value);
		}
	}

	// Token: 0x06003A77 RID: 14967 RVA: 0x0017020C File Offset: 0x0016E40C
	private int 23(double 1)
	{
		int num = this.9.BinarySearch(1);
		if (num >= 0)
		{
			return num;
		}
		return ~num;
	}

	// Token: 0x06003A78 RID: 14968 RVA: 0x00170230 File Offset: 0x0016E430
	private 208 24(int 1, double 2)
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
		return 1847.7(result, 1847.9(1847.8(3, result), (float)num3));
	}

	// Token: 0x06003A79 RID: 14969 RVA: 0x001702F4 File Offset: 0x0016E4F4
	private static List<208> 25(208[] 1, int 2)
	{
		if (1.Length >= 2)
		{
			2 = Math.Min(2, 1.Length - 1);
			List<208> list = new List<208>();
			int num = 1.Length - 1;
			Stack<208[]> stack = 1847.26(1, ref 2);
			Stack<208[]> stack2 = new Stack<208[]>();
			208[] array = new 208[2 + 1];
			208[] array2 = new 208[2 * 2 + 1];
			208[] array3 = array2;
			while (stack.Count > 0)
			{
				208[] array4 = stack.Pop();
				if (1847.27(array4))
				{
					1847.29(array4, list, array, array2, 2 + 1);
					stack2.Push(array4);
				}
				else
				{
					208[] item = (stack2.Count > 0) ? stack2.Pop() : new 208[2 + 1];
					1847.28(array4, array3, item, array, 2 + 1);
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

	// Token: 0x06003A7A RID: 14970 RVA: 0x00170410 File Offset: 0x0016E610
	private static Stack<208[]> 26(208[] 1, ref int 2)
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
					array[i + k] = 1847.10(1847.7(1847.9(array[i + k], (float)num2), array[i + k + 1]), (float)(num2 + 1));
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

	// Token: 0x06003A7B RID: 14971 RVA: 0x00170554 File Offset: 0x0016E754
	private static bool 27(208[] 1)
	{
		for (int i = 1; i < 1.Length - 1; i++)
		{
			if (1847.11(1847.7(1847.8(1[i - 1], 1847.9(1[i], 2f)), 1[i + 1])) > 0.25f)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06003A7C RID: 14972 RVA: 0x001705B0 File Offset: 0x0016E7B0
	private static void 28(208[] 1, 208[] 2, 208[] 3, 208[] 4, int 5)
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
				4[k] = 1847.10(1847.7(4[k], 4[k + 1]), 2f);
			}
		}
	}

	// Token: 0x06003A7D RID: 14973 RVA: 0x00170644 File Offset: 0x0016E844
	private static void 29(208[] 1, List<208> 2, 208[] 3, 208[] 4, int 5)
	{
		1847.28(1, 4, 3, 3, 5);
		for (int i = 0; i < 5 - 1; i++)
		{
			4[5 + i] = 3[i + 1];
		}
		2.Add(1[0]);
		for (int j = 1; j < 5 - 1; j++)
		{
			int num = 2 * j;
			208 item = 1847.9(1847.7(1847.7(4[num - 1], 1847.9(4[num], 2f)), 4[num + 1]), 0.25f);
			2.Add(item);
		}
	}

	// Token: 0x06003A7E RID: 14974 RVA: 0x001706E8 File Offset: 0x0016E8E8
	private static List<208> 30(208[] 1)
	{
		List<208> list = new List<208>((1.Length - 1) * 50 * 2);
		for (int i = 0; i < 1.Length - 1; i++)
		{
			208 2 = (i > 0) ? 1[i - 1] : 1[i];
			208 3 = 1[i];
			208 4 = (i < 1.Length - 1) ? 1[i + 1] : 1847.8(1847.7(3, 3), 2);
			208 5 = (i < 1.Length - 2) ? 1[i + 2] : 1847.8(1847.7(4, 4), 3);
			for (int j = 0; j < 50; j++)
			{
				list.Add(1847.31(2, 3, 4, 5, (float)j / 50f));
				list.Add(1847.31(2, 3, 4, 5, (float)(j + 1) / 50f));
			}
		}
		return list;
	}

	// Token: 0x06003A7F RID: 14975 RVA: 0x001707CC File Offset: 0x0016E9CC
	private static 208 31(208 1, 208 2, 208 3, 208 4, float 5)
	{
		float num = 5 * 5;
		float num2 = 5 * num;
		208 result;
		result.X = 1847.32(1.X, 2.X, 3.X, 4.X, 5, num, num2);
		result.Y = 1847.32(1.Y, 2.Y, 3.Y, 4.Y, 5, num, num2);
		return result;
	}

	// Token: 0x06003A80 RID: 14976 RVA: 0x00170838 File Offset: 0x0016EA38
	private static float 32(float 1, float 2, float 3, float 4, float 5, float 6, float 7)
	{
		float num = 2f * 2;
		float num2 = (-1 + 3) * 5;
		float num3 = (2f * 1 - 5f * 2 + 4f * 3 - 4) * 6;
		float num4 = (-1 + 3f * 2 - 3f * 3 + 4) * 7;
		return 0.5f * (num + num2 + num3 + num4);
	}

	// Token: 0x06003A81 RID: 14977 RVA: 0x001708AC File Offset: 0x0016EAAC
	private static List<208> 33(208[] 1)
	{
		double num;
		double num2;
		double num3;
		float num4;
		208 2;
		if (!1847.34(1, out num, out num2, out num3, out num4, out 2))
		{
			return 1847.25(1, Math.Max(1, 1.Length - 1));
		}
		int num5 = (2f * num4 <= 0.1f) ? 2 : Math.Max(2, (int)Math.Ceiling(num2 / (2.0 * Math.Acos((double)(1f - 0.1f / num4)))));
		List<208> list = new List<208>(num5);
		for (int i = 0; i < num5; i++)
		{
			double num6 = (double)i / (double)(num5 - 1);
			double num7 = num + num3 * num6 * num2;
			208 3 = 1847.9(new 208((float)Math.Cos(num7), (float)Math.Sin(num7)), num4);
			list.Add(1847.7(2, 3));
		}
		return list;
	}

	// Token: 0x06003A82 RID: 14978 RVA: 0x0017097C File Offset: 0x0016EB7C
	private static bool 34(208[] 1, out double 2, out double 3, out double 4, out float 5, out 208 6)
	{
		208 7 = 1[0];
		208 8 = 1[1];
		208 9 = 1[2];
		2 = 0.0;
		3 = 0.0;
		4 = 0.0;
		5 = 0f;
		6 = 208.Zero;
		if (Math.Abs(1847.13(7, 8, 9)) <= 0.001f)
		{
			return false;
		}
		float num = 2f * (7.X * 1847.8(8, 9).Y + 8.X * 1847.8(9, 7).Y + 9.X * 1847.8(7, 8).Y);
		float num2 = 1847.11(7);
		float num3 = 1847.11(8);
		float num4 = 1847.11(9);
		float num5 = num2 * 1847.8(8, 9).Y + num3 * 1847.8(9, 7).Y + num4 * 1847.8(7, 8).Y;
		float num6 = num2 * 1847.8(9, 8).X + num3 * 1847.8(7, 9).X + num4 * 1847.8(8, 7).X;
		6 = 1847.10(new 208(num5, num6), num);
		208 10 = 1847.8(7, 6);
		208 11 = 1847.8(9, 6);
		5 = 1847.Length(10);
		2 = Math.Atan2((double)10.Y, (double)10.X);
		double num7;
		for (num7 = Math.Atan2((double)11.Y, (double)11.X); num7 < 2; num7 += 6.283185307179586)
		{
		}
		4 = 1.0;
		3 = num7 - 2;
		208 12 = 1847.8(9, 7);
		12 = new 208(12.Y, -12.X);
		if (1847.12(12, 1847.8(8, 7)) < 0f)
		{
			4 = -4;
			3 = 6.283185307179586 - 3;
		}
		return true;
	}

	// Token: 0x04002B0B RID: 11019
	private const float 1 = 0.25f;

	// Token: 0x04002B0C RID: 11020
	private const int 2 = 50;

	// Token: 0x04002B0D RID: 11021
	private const float 3 = 0.1f;

	// Token: 0x04002B0E RID: 11022
	private const float 4 = 0.001f;

	// Token: 0x04002B0F RID: 11023
	private const double 5 = 1E-07;

	// Token: 0x04002B10 RID: 11024
	private readonly 1847.1848[] 6;

	// Token: 0x04002B11 RID: 11025
	private readonly double? 7;

	// Token: 0x04002B12 RID: 11026
	private List<208> 8;

	// Token: 0x04002B13 RID: 11027
	private List<double> 9;

	// Token: 0x020007DB RID: 2011
	private enum 1849
	{
		// Token: 0x04002B15 RID: 11029
		None,
		// Token: 0x04002B16 RID: 11030
		Linear,
		// Token: 0x04002B17 RID: 11031
		PerfectCurve,
		// Token: 0x04002B18 RID: 11032
		Catmull,
		// Token: 0x04002B19 RID: 11033
		BSpline
	}

	// Token: 0x020007DC RID: 2012
	private struct 1848
	{
		// Token: 0x04002B1A RID: 11034
		public 208 1;

		// Token: 0x04002B1B RID: 11035
		public 1847.1849 2;

		// Token: 0x04002B1C RID: 11036
		public int 3;
	}
}
