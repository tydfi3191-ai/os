using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x02000728 RID: 1832
[276]
public static class 2078
{
	// Token: 0x06003623 RID: 13859 RVA: 0x00152B5C File Offset: 0x00150D5C
	private static int 1<T>(List<T> 1, double 2, Func<T, double> 3, out bool 4)
	{
		int i = 0;
		int num = 1.Count;
		while (i < num)
		{
			int num2 = (i + num) / 2;
			int num3 = 3(1[num2]).CompareTo(2);
			if (num3 == 0)
			{
				4 = true;
				return num2;
			}
			if (num3 < 0)
			{
				i = num2 + 1;
			}
			else
			{
				num = num2;
			}
		}
		4 = false;
		return i;
	}

	// Token: 0x06003624 RID: 13860 RVA: 0x00152BB0 File Offset: 0x00150DB0
	private static 2078.2088 2(List<2078.2088> 1, double 2)
	{
		bool flag;
		int num = 2078.1<2078.2088>(3, 2, (2078.2088 1) => 1.1, out flag);
		if (!flag)
		{
			num = Math.Max(0, num - 1);
		}
		if (num >= 3.Count)
		{
			return null;
		}
		return 3[num];
	}

	// Token: 0x06003625 RID: 13861 RVA: 0x00152C08 File Offset: 0x00150E08
	private static 2078.2081 3(List<2078.2081> 1, double 2)
	{
		bool flag;
		int num = 2078.1<2078.2081>(3, 2, (2078.2081 1) => 1.1, out flag);
		if (flag)
		{
			return 3[num];
		}
		if (num <= 0)
		{
			return null;
		}
		return 3[num - 1];
	}

	// Token: 0x06003626 RID: 13862 RVA: 0x00152C58 File Offset: 0x00150E58
	private static double 4(string 1, double 2)
	{
		double num = double.Parse(1.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture);
		if (num < -2 || num > 2)
		{
			throw new FormatException("number out of range");
		}
		return num;
	}

	// Token: 0x06003627 RID: 13863 RVA: 0x00152C90 File Offset: 0x00150E90
	private static int 5(double 1)
	{
		if (double.IsNaN(1))
		{
			return 0;
		}
		if (1 >= 2147483647.0)
		{
			return int.MaxValue;
		}
		if (1 > -2147483648.0)
		{
			return (int)1;
		}
		return int.MinValue;
	}

	// Token: 0x06003628 RID: 13864 RVA: 0x00152CC4 File Offset: 0x00150EC4
	private static string 6(string 1)
	{
		int num = 1.IndexOf("//", StringComparison.Ordinal);
		return ((num >= 0) ? 1.Substring(0, num) : 1).TrimEnd(Array.Empty<char>());
	}

	// Token: 0x06003629 RID: 13865 RVA: 0x00152CF8 File Offset: 0x00150EF8
	private static 2078.2082 7(byte[] 1)
	{
		2078.2082 result;
		try
		{
			string @string = Encoding.UTF8.GetString(1);
			2078.2082 2 = new 2078.2082();
			2078.2079 3 = new 2078.2079
			{
				1 = 2
			};
			string a = null;
			int num = 0;
			using (StringReader stringReader = new StringReader(@string))
			{
				bool flag = true;
				string text;
				while ((text = stringReader.ReadLine()) != null)
				{
					string text2 = text.Trim().TrimStart(new char[]
					{
						'﻿'
					});
					if (flag)
					{
						flag = false;
						if (text2.StartsWith("osu file format v", StringComparison.Ordinal))
						{
							string s = 2078.6(text2.Substring("osu file format v".Length)).Trim();
							2.1 = int.Parse(s, NumberStyles.Integer, CultureInfo.InvariantCulture);
							continue;
						}
					}
					if (text2.Length != 0)
					{
						string a2;
						string s2;
						if (text2.StartsWith("[", StringComparison.Ordinal) && text2.EndsWith("]", StringComparison.Ordinal))
						{
							a = text2.Substring(1, text2.Length - 2);
						}
						else if (!(a == "General"))
						{
							if (!(a == "Difficulty"))
							{
								if (!(a == "TimingPoints"))
								{
									if (a == "HitObjects")
									{
										2078.11(2, text2, num++);
									}
								}
								else
								{
									2078.10(3, text2);
								}
							}
							else
							{
								2078.9(2, text2);
							}
						}
						else if (2078.8(text2, out a2, out s2) && a2 == "Mode")
						{
							2.11 = int.Parse(s2, NumberStyles.Integer, CultureInfo.InvariantCulture);
						}
					}
				}
			}
			3.2();
			List<2078.2084> collection = new List<2078.2084>(2.10);
			2078.12(collection);
			2.10.Clear();
			2.10.AddRange(collection);
			result = 2;
		}
		catch (Exception)
		{
			result = null;
		}
		return result;
	}

	// Token: 0x0600362A RID: 13866 RVA: 0x00152EF8 File Offset: 0x001510F8
	private static bool 8(string 1, out string 2, out string 3)
	{
		string text = 2078.6(1);
		int num = text.IndexOf(':');
		if (num < 0)
		{
			2 = null;
			3 = null;
			return false;
		}
		2 = text.Substring(0, num).Trim();
		3 = text.Substring(num + 1).Trim();
		return true;
	}

	// Token: 0x0600362B RID: 13867 RVA: 0x00152F44 File Offset: 0x00151144
	private static void 9(2078.2082 1, string 2)
	{
		string a;
		string text;
		if (!2078.8(2, out a, out text))
		{
			return;
		}
		if (!(a == "CircleSize"))
		{
			if (!(a == "OverallDifficulty"))
			{
				if (a == "ApproachRate")
				{
					1.4 = (float)2078.4(text, 2147483647.0);
					1.5 = true;
					return;
				}
				if (a == "SliderMultiplier")
				{
					1.6 = 2078.4(text, 2147483647.0);
					return;
				}
				if (!(a == "SliderTickRate"))
				{
					return;
				}
				1.7 = 2078.4(text, 2147483647.0);
			}
			else
			{
				1.3 = (float)2078.4(text, 2147483647.0);
				if (!1.5)
				{
					1.4 = 1.3;
					return;
				}
			}
			return;
		}
		1.2 = (float)2078.4(text, 2147483647.0);
	}

	// Token: 0x0600362C RID: 13868 RVA: 0x0015302C File Offset: 0x0015122C
	private static void 10(2078.2079 1, string 2)
	{
		string[] array = 2078.6(2).Split(new char[]
		{
			','
		});
		if (array.Length < 2)
		{
			throw new FormatException("invalid timing point line");
		}
		double num = 2078.4(array[0], 2147483647.0);
		double num2 = double.Parse(array[1].Trim(), NumberStyles.Float, CultureInfo.InvariantCulture);
		if (num2 < -2147483647.0 || num2 > 2147483647.0)
		{
			throw new FormatException("beat length out of range");
		}
		double val = (num2 < 0.0) ? (100.0 / -num2) : 1.0;
		if (array.Length > 2 && int.Parse(array[2].Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture) < 1)
		{
			throw new FormatException("invalid time signature");
		}
		bool flag = array.Length <= 6 || (array[6].Length > 0 && array[6][0] == '1');
		2078.2088 3 = null;
		if (flag)
		{
			if (double.IsNaN(num2))
			{
				throw new FormatException("timing point beat length is NaN");
			}
			3 = new 2078.2088
			{
				1 = num,
				2 = Math.Max(6.0, Math.Min(60000.0, num2))
			};
		}
		2078.2081 4 = new 2078.2081
		{
			1 = num,
			2 = Math.Max(0.1, Math.Min(10.0, val)),
			3 = !double.IsNaN(num2)
		};
		1.1(num, 3, null, flag);
		1.1(num, null, 4, flag);
	}

	// Token: 0x0600362D RID: 13869 RVA: 0x001531C4 File Offset: 0x001513C4
	private static void 11(2078.2082 1, string 2, int 3)
	{
		string[] array = 2078.6(2).Split(new char[]
		{
			','
		});
		if (array.Length < 5)
		{
			throw new FormatException("invalid hit object line");
		}
		float num = (float)2078.4(array[0], 131072.0);
		double num2 = (double)((float)2078.4(array[1], 131072.0));
		int num3 = 2078.5((double)num);
		int num4 = 2078.5(num2);
		2078.2084 4 = new 2078.2084
		{
			2 = new 208((float)num3, (float)num4),
			6 = num3,
			7 = num4,
			3 = 2078.4(array[2], 2147483647.0),
			4 = 3
		};
		int num5 = int.Parse(array[3].Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture);
		if ((num5 & 1) != 0)
		{
			4.1 = 2078.2085.Circle;
		}
		else if ((num5 & 2) != 0)
		{
			if (array.Length < 7)
			{
				throw new FormatException("invalid hit object line");
			}
			4.1 = 2078.2085.Slider;
			4.5 = array[5];
			int num6 = int.Parse(array[6].Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture);
			if (num6 > 9000)
			{
				throw new FormatException("repeat count too high");
			}
			4.9 = Math.Max(0, num6 - 1);
			if (array.Length > 7)
			{
				double num7 = Math.Max(0.0, 2078.4(array[7], 131072.0));
				4.8 = num7;
			}
		}
		else if ((num5 & 8) != 0)
		{
			if (array.Length < 6)
			{
				throw new FormatException("invalid hit object line");
			}
			4.1 = 2078.2085.Spinner;
		}
		else
		{
			if ((num5 & 128) == 0)
			{
				throw new FormatException("unknown hit object type");
			}
			4.1 = 2078.2085.Hold;
		}
		1.10.Add(4);
	}

	// Token: 0x0600362E RID: 13870 RVA: 0x0015337C File Offset: 0x0015157C
	private static void 12(List<2078.2084> 1)
	{
		if (1.Count < 2)
		{
			return;
		}
		2078.2084[] array = new 2078.2084[1.Count];
		2078.13(1, array, 0, 1.Count);
	}

	// Token: 0x0600362F RID: 13871 RVA: 0x001533B0 File Offset: 0x001515B0
	private static void 13(List<2078.2084> 1, 2078.2084[] 2, int 3, int 4)
	{
		if (4 - 3 < 2)
		{
			return;
		}
		int num = (3 + 4) / 2;
		2078.13(1, 2, 3, num);
		2078.13(1, 2, num, 4);
		int i = 3;
		int j = num;
		int num2 = 3;
		while (i < num)
		{
			if (j >= 4)
			{
				break;
			}
			2[num2++] = ((1[j].3 < 1[i].3) ? 1[j++] : 1[i++]);
		}
		while (i < num)
		{
			2[num2++] = 1[i++];
		}
		while (j < 4)
		{
			2[num2++] = 1[j++];
		}
		for (int k = 3; k < 4; k++)
		{
			1[k] = 2[k];
		}
	}

	// Token: 0x06003630 RID: 13872 RVA: 0x00153471 File Offset: 0x00151671
	private static float 14(float 1)
	{
		return (float)Math.Pow((double)1, 0.9900000095367432);
	}

	// Token: 0x06003631 RID: 13873 RVA: 0x00153484 File Offset: 0x00151684
	private static float 15(ref 2078.2080 1)
	{
		if (1.1.IsSpinner)
		{
			return 0f;
		}
		float num = 0f;
		if (1.2 && 1.7 && 1.8 > 1.0471976f)
		{
			float num2 = (float)Math.Sin((double)(1.8 - 1.0471976f));
			float val = (float)Math.Sqrt((double)(num2 * num2 * Math.Max(1.3 - 90f, 0f) * Math.Max(1.5 - 90f, 0f)));
			num = 1.5f * 2078.14(Math.Max(val, 0f)) / Math.Max(107f, 1.4);
		}
		float num3 = 2078.14(1.5);
		float num4 = 2078.14(1.6);
		float num5 = num3 + num4 + (float)Math.Sqrt((double)(num4 * num3));
		return Math.Max(num + num5 / Math.Max(1.10, 107f), num5 / 1.10);
	}

	// Token: 0x06003632 RID: 13874 RVA: 0x0015358C File Offset: 0x0015178C
	private static float 16(ref 2078.2080 1)
	{
		if (1.1.IsSpinner)
		{
			return 0f;
		}
		float num = Math.Min(125f, 1.6 + 1.5);
		float num2 = Math.Max(45f, 1.9);
		float num3 = 1f;
		if (num2 < 75f)
		{
			float num4 = (75f - num2) / 40f;
			num3 += num4 * num4;
		}
		float num5 = 1f;
		if (1.7 && 1.8 < 2.617994f)
		{
			float num6 = (float)Math.Sin((double)(1.5f * (2.617994f - 1.8)));
			num5 = 1f + num6 * num6 / 3.57f;
			if (1.8 < 1.5707964f)
			{
				num5 = 1.28f;
				if (num < 90f && 1.8 < 0.7853982f)
				{
					num5 += (1f - num5) * Math.Min((90f - num) / 10f, 1f);
				}
				else if (num < 90f)
				{
					num5 += (1f - num5) * Math.Min((90f - num) / 10f, 1f) * (float)Math.Sin((double)((1.5707964f - 1.8) / 0.7853982f));
				}
			}
		}
		return (1f + (num3 - 1f) * 0.75f) * num5 * (0.95f + num3 * (float)Math.Pow((double)(num / 125f), 3.5)) / 1.10;
	}

	// Token: 0x06003633 RID: 13875 RVA: 0x00153718 File Offset: 0x00151918
	private static 2078.2080 17(2078.2086 1, 2078.2086 2, bool 3, float 4, float 5, bool 6, 2078.2086 7, float 8, float 9)
	{
		float val = (1.1 - 2.1) / 8;
		2078.2080 result = new 2078.2080
		{
			1 = 1,
			2 = 3,
			3 = 4,
			4 = 5,
			9 = val,
			10 = Math.Max(val, 50f),
			6 = (2.IsSpinner ? 0f : 2.4),
			5 = (1.IsSpinner ? 0f : ((1.2 - 2.3) * 9).Length())
		};
		if (6)
		{
			208 10 = 7.3 - 2.2;
			208 11 = 1.2 - 2.3;
			float num = 10.X * 11.X + 10.Y * 11.Y;
			float num2 = 10.X * 11.Y - 10.Y * 11.X;
			result.7 = true;
			result.8 = Math.Abs((float)Math.Atan2((double)num2, (double)num));
		}
		return result;
	}

	// Token: 0x06003634 RID: 13876 RVA: 0x00153860 File Offset: 0x00151A60
	private static double 18(double 1, double 2, double 3, double 4)
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

	// Token: 0x06003635 RID: 13877 RVA: 0x001538C0 File Offset: 0x00151AC0
	private static 2078.2083 19(2078.2082 1, 2023 2, 1927 3, double 4)
	{
		bool hardRock = (2 & 2023.HardRock) > 2023.None;
		bool easy = (2 & 2023.Easy) > 2023.None;
		Func<float, float> func = delegate(float 1)
		{
			if (hardRock)
			{
				return Math.Min(1 * 1.4f, 10f);
			}
			if (!easy)
			{
				return 1;
			}
			return 1 * 0.5f;
		};
		float arg = ((3 != null) ? 3.Get(1928.ApproachRate) : null) ?? 5.4;
		float arg2 = ((3 != null) ? 3.Get(1928.OverallDifficulty) : null) ?? 5.3;
		float num = ((3 != null) ? 3.Get(1928.CircleSize) : null) ?? 5.2;
		double num2 = 2078.18((double)func(arg), 1800.0, 1200.0, 450.0) / 4;
		double num3 = 2078.18((double)func(arg2), 80.0, 50.0, 20.0) / 4;
		float num4 = num;
		if (hardRock)
		{
			num4 = Math.Min(num4 * 1.3f, 10f);
		}
		else if (easy)
		{
			num4 *= 0.5f;
		}
		return new 2078.2083
		{
			1 = ((num2 > 1200.0) ? ((1800.0 - num2) / 120.0) : ((1200.0 - num2) / 150.0 + 5.0)),
			2 = (80.0 - num3) / 6.0,
			3 = (double)num4,
			4 = 4
		};
	}

	// Token: 0x06003636 RID: 13878 RVA: 0x00153A9C File Offset: 0x00151C9C
	private static 2078.2086 20(2078.2082 1, 2078.2084 2, float 3, float 4, List<double> 5, 2077 6, 2117 7, bool 8, bool 9)
	{
		2078.<>c__DisplayClass46_0 CS$<>8__locals1;
		CS$<>8__locals1.attributes = 6;
		CS$<>8__locals1.attributes.9++;
		2117.2118 10 = (7 != null && 2.4 < 7.11.Length) ? 7.11[2.4] : null;
		CS$<>8__locals1.position = ((10 != null && !10.4 && 2.1 != 2078.2085.Spinner && 2.1 != 2078.2085.Hold) ? 10.1 : 2.2);
		2078.2085 11 = 2.1;
		if (11 == 2078.2085.Circle)
		{
			CS$<>8__locals1.attributes.6++;
			return new 2078.2086
			{
				1 = (float)2.3,
				2 = CS$<>8__locals1.position,
				3 = CS$<>8__locals1.position,
				4 = 0f
			};
		}
		if (11 != 2078.2085.Slider)
		{
			CS$<>8__locals1.attributes.8++;
			return new 2078.2086
			{
				1 = (float)2.3,
				2 = 2.2,
				3 = 2.2,
				4 = float.NaN
			};
		}
		CS$<>8__locals1.attributes.7++;
		2078.2088 12 = 2078.2(1.8, 2.3);
		double num = (12 != null) ? 12.2 : 1000.0;
		2078.2081 13 = 2078.3(1.9, 2.3);
		double num2 = (13 != null) ? 13.2 : 1.0;
		bool flag = 13 == null || 13.3;
		double num3 = 100.0 * 1.6 * num2;
		double num4 = num3 / num;
		2078.<>c__DisplayClass46_1 CS$<>8__locals2;
		CS$<>8__locals2.endPosition = CS$<>8__locals1.position;
		CS$<>8__locals2.travelDistance = 0f;
		CS$<>8__locals2.approxFollowCircleRadius = 3 * 3f;
		double num5 = (1.1 < 8) ? (1.0 / num2) : 1.0;
		double num6 = flag ? (num3 / 1.7 * num5) : double.PositiveInfinity;
		double num7 = (double)(2.9 + 1);
		CS$<>8__locals2.path = 2114.1(2.5, 2.6, 2.7, 2.8, 10 != null && 8, 10 != null && 9);
		if (10 != null)
		{
			foreach (float f in 10.2)
			{
				if (float.IsNaN(f))
				{
					CS$<>8__locals2.path.6();
				}
				else
				{
					CS$<>8__locals2.path.7(f);
				}
			}
		}
		double distance = CS$<>8__locals2.path.Distance;
		double num8 = num7 * distance / num4;
		CS$<>8__locals2.spanDuration = num8 / num7;
		CS$<>8__locals2.startTime = 2.3;
		double num9 = Math.Min(distance, 100000.0);
		num6 = Math.Max(0.0, Math.Min(num9, num6));
		double num10 = num4 * 10.0;
		double num11 = num6;
		if (num6 != 0.0)
		{
			while (num11 < num9 - num10)
			{
				double num12 = num11 / num9;
				double item = CS$<>8__locals2.startTime + num12 * CS$<>8__locals2.spanDuration;
				2078.<CreateObject>g__ComputeVertex|46_0(item, ref CS$<>8__locals1, ref CS$<>8__locals2);
				5.Add(item);
				num11 += num6;
			}
			for (int i = 1; i <= 2.9; i++)
			{
				double num13 = (double)i;
				2078.<CreateObject>g__ComputeVertex|46_0(CS$<>8__locals2.startTime + CS$<>8__locals2.spanDuration * num13, ref CS$<>8__locals1, ref CS$<>8__locals2);
				double num14 = num13 * CS$<>8__locals2.spanDuration;
				if ((i & 1) == 1)
				{
					double num15 = CS$<>8__locals2.startTime + CS$<>8__locals2.startTime + CS$<>8__locals2.spanDuration;
					for (int j = 5.Count - 1; j >= 0; j--)
					{
						2078.<CreateObject>g__ComputeVertex|46_0(num14 + num15 - 5[j], ref CS$<>8__locals1, ref CS$<>8__locals2);
					}
				}
				else
				{
					foreach (double num16 in 5)
					{
						2078.<CreateObject>g__ComputeVertex|46_0(num14 + num16, ref CS$<>8__locals1, ref CS$<>8__locals2);
					}
				}
			}
			5.Clear();
		}
		double num17 = CS$<>8__locals2.startTime + (double)2.9 * CS$<>8__locals2.spanDuration;
		2078.<CreateObject>g__ComputeVertex|46_0(Math.Max(CS$<>8__locals2.startTime + num8 / 2.0, num17 + CS$<>8__locals2.spanDuration - 36.0), ref CS$<>8__locals1, ref CS$<>8__locals2);
		CS$<>8__locals2.travelDistance *= 4;
		return new 2078.2086
		{
			1 = (float)CS$<>8__locals2.startTime,
			2 = CS$<>8__locals1.position,
			3 = CS$<>8__locals2.endPosition,
			4 = CS$<>8__locals2.travelDistance
		};
	}

	// Token: 0x06003637 RID: 13879 RVA: 0x00153FB0 File Offset: 0x001521B0
	private static 208 21(208 1)
	{
		float num = 1.Length();
		return new 208(1.X / num, 1.Y / num);
	}

	// Token: 0x06003638 RID: 13880 RVA: 0x00153FDC File Offset: 0x001521DC
	internal static 2077[] 22(byte[] 1, 2023 2, 1927 3, double 4, 2117 5, bool 6, bool 7, bool 8)
	{
		2078.2082 9 = (1 == null) ? null : 2078.7(1);
		if (9 == null || 9.11 != 0)
		{
			return null;
		}
		2078.2083 10 = 2078.19(9, 2, 3, 4);
		int count = 9.10.Count;
		2077 11 = new 2077
		{
			3 = 10.1,
			4 = 10.2,
			5 = 10.3
		};
		2077[] array = 8 ? new 2077[count + 1] : null;
		if (8)
		{
			array[0] = 2078.Copy(11);
		}
		if (count < 2)
		{
			if (8)
			{
				for (int i = 1; i <= count; i++)
				{
					array[i] = 2078.Copy(11);
				}
			}
			if (!8)
			{
				return new 2077[]
				{
					11
				};
			}
			return array;
		}
		else
		{
			float num = (float)10.4;
			float num2 = 400f * num;
			float num3 = 64f * (1f - 0.7f * ((float)10.3 - 5f) / 5f) / 2f;
			float num4 = 52f / num3;
			if (num3 < 30f)
			{
				float num5 = Math.Min(30f - num3, 5f) / 50f;
				num4 *= 1f + num5;
			}
			List<double> list = new List<double>();
			2078.2087 12 = new 2078.2087(true);
			2078.2087 13 = new 2078.2087(false);
			float num6 = (float)Math.Ceiling((double)((float)9.10[0].3 / num2)) * num2;
			if (8)
			{
				array[1] = 2078.Copy(11);
			}
			2078.2086 14 = 2078.20(9, 9.10[0], num3, num4, list, 11, 5, 6, 7);
			bool flag = false;
			2078.2086 15 = default(2078.2086);
			bool flag2 = false;
			float num7 = 0f;
			float num8 = 0f;
			for (int j = 1; j < count; j++)
			{
				2078.2086 16 = 2078.20(9, 9.10[j], num3, num4, list, 11, 5, 6, 7);
				2078.2080 17 = 2078.17(16, 14, flag2, num7, num8, flag, 15, num, num4);
				if (j == 1)
				{
					while (17.1.1 > num6)
					{
						num6 += num2;
					}
				}
				else
				{
					while (17.1.1 > num6)
					{
						12.1();
						12.2(num6);
						13.1();
						13.2(num6);
						num6 += num2;
					}
				}
				12.3(ref 17);
				13.3(ref 17);
				flag = true;
				15 = 14;
				flag2 = true;
				num7 = 17.5;
				num8 = 17.10;
				14 = 16;
				if (8)
				{
					array[j + 1] = 2078.Finish(2078.Copy(11), 12, 13);
				}
			}
			if (!8)
			{
				return new 2077[]
				{
					2078.Finish(11, 12, 13)
				};
			}
			return array;
		}
	}

	// Token: 0x06003639 RID: 13881 RVA: 0x001542A4 File Offset: 0x001524A4
	private static 2077 Finish(2077 1, 2078.2087 2, 2078.2087 3)
	{
		float num = (float)Math.Sqrt((double)2.5(true)) * 0.0675f;
		float num2 = (float)Math.Sqrt((double)3.5(true)) * 0.0675f;
		float num3 = num + num2 + Math.Abs(num - num2) / 2f;
		1.1 = (double)num;
		1.2 = (double)num2;
		1.10 = (double)num3;
		return 1;
	}

	// Token: 0x0600363A RID: 13882 RVA: 0x00154308 File Offset: 0x00152508
	private static 2077 Copy(2077 1)
	{
		return new 2077
		{
			1 = 1.1,
			2 = 1.2,
			3 = 1.3,
			4 = 1.4,
			5 = 1.5,
			6 = 1.6,
			7 = 1.7,
			8 = 1.8,
			9 = 1.9,
			10 = 1.10
		};
	}

	// Token: 0x0600363B RID: 13883 RVA: 0x00154394 File Offset: 0x00152594
	public static double 23(2077 1, 2023 2, int 3, int 4, int 5, int 6, int 7, bool 8)
	{
		if (1 == null)
		{
			return 0.0;
		}
		uint num = (uint)Math.Max(0, 1.ObjectCount);
		uint num2 = (uint)Math.Max(0, 6);
		long num3 = (long)Math.Max(0, 3) + (long)Math.Max(0, 4) + (long)Math.Max(0, 5) + (long)((ulong)num2);
		float num4 = (num3 == 0L) ? 0f : ((float)(((double)Math.Max(0, 3) * 300.0 + (double)Math.Max(0, 4) * 100.0 + (double)Math.Max(0, 5) * 50.0) / ((double)num3 * 300.0) * 100.0));
		uint num5;
		uint num6;
		uint num7;
		if (!2078.24(num, num2, num4, out num5, out num6, out num7))
		{
			return 0.0;
		}
		float num8 = (6U * num5 + 2U * num6 + num7) / (6U * num);
		float num9 = Math.Min(num5 + num6 + num7 + num2, num);
		float num10 = 1.09f;
		float num11 = 2078.27(1, 8 ? 1.9 : 7, num6, num7, num2);
		if ((2 & 2023.SpunOut) != 2023.None)
		{
			num10 *= 1f - (float)Math.Pow((double)((float)1.8 / num9), 0.8500000238418579);
		}
		float num12 = 2078.28(1, 2, num9, num11, num8);
		float num13 = 2078.29(1, 2, num9, num11, num8, num7);
		float num14 = 2078.30(1, 2, num9, num5, num6, num7);
		float num15 = 1f;
		if (Math.Round(1.1 / 1.2 * 100.0, MidpointRounding.AwayFromZero) / 100.0 < 1.09)
		{
			float num16 = Math.Abs(1f - num8);
			num15 = Math.Max(0.86f - num16, 0.5f);
			if (num15 > 0f)
			{
				num12 *= num15;
			}
		}
		float num17 = (float)Math.Pow((double)((float)Math.Pow((double)num12, 1.184999942779541) + (float)Math.Pow((double)num13, (double)(0.83f * num15)) + (float)Math.Pow((double)num14, 1.1399999856948853)), 0.9090908765792847) * num10;
		if (float.IsNaN(num17) || float.IsInfinity(num17))
		{
			return 0.0;
		}
		return Math.Round((double)((float)(Math.Round((double)(num17 * 100f), MidpointRounding.AwayFromZero) / 100.0)), 2);
	}

	// Token: 0x0600363C RID: 13884 RVA: 0x001545FC File Offset: 0x001527FC
	private static bool 24(uint 1, uint 2, float 3, out uint 4, out uint 5, out uint 6)
	{
		4 = (5 = (6 = 0U));
		if (1 == 0U)
		{
			return false;
		}
		float num = 3 / 100f;
		uint num2 = Math.Min(2, 1);
		long num3 = (long)((ulong)((uint)Math.Max(0.0, Math.Round((double)(num * 1 * 6f), MidpointRounding.AwayFromZero))) - (ulong)(1 - num2));
		if (num3 < 0L)
		{
			return false;
		}
		4 = (uint)num3 / 5U;
		5 = (uint)num3 % 5U;
		long num4 = (long)((ulong)1 - (ulong)4 - (ulong)5 - (ulong)num2);
		if (num4 < 0L)
		{
			return false;
		}
		6 = (uint)num4;
		uint num5 = Math.Min(4, 6 / 4U);
		4 -= num5;
		5 += 5U * num5;
		6 -= 4U * num5;
		return true;
	}

	// Token: 0x0600363D RID: 13885 RVA: 0x001546B4 File Offset: 0x001528B4
	private static float 25(float 1)
	{
		return 0.88f + 0.4f * Math.Min(1 / 2000f, 1f) + ((1 > 2000f) ? 1f : 0f) * 0.5f * (float)Math.Log10((double)(1 / 2000f));
	}

	// Token: 0x0600363E RID: 13886 RVA: 0x00154708 File Offset: 0x00152908
	private static float 26(float 1, float 2)
	{
		return 0.97f * (float)Math.Pow((double)(1f - (float)Math.Pow((double)(1 / 2), 0.5)), (double)(1f + 1 / 1.5f));
	}

	// Token: 0x0600363F RID: 13887 RVA: 0x00154740 File Offset: 0x00152940
	private static float 27(2077 1, int 2, uint 3, uint 4, uint 5)
	{
		float val = 0f;
		if (1.7 > 0)
		{
			float num = (float)1.9 - 0.1f * (float)1.7;
			if ((float)2 < num)
			{
				val = num / Math.Max((float)2, 1f);
			}
		}
		val = Math.Min(val, 3 + 4 + 5);
		return Math.Max(val, 5);
	}

	// Token: 0x06003640 RID: 13888 RVA: 0x001547A4 File Offset: 0x001529A4
	private static float 28(2077 1, 2023 2, float 3, float 4, float 5)
	{
		float num = ((2 & 2023.TouchDevice) != 2023.None) ? ((float)Math.Pow(1.1, 0.8)) : ((float)1.1);
		float num2 = 2078.31(5f * Math.Max(num / 0.0675f, 1f) - 4f) / 100000f;
		float num3 = 2078.25(3);
		num2 *= num3;
		if (4 > 0f)
		{
			num2 *= 2078.26(4, 3);
		}
		double num4 = (1.3 > 10.33) ? (0.3 * (1.3 - 10.33)) : 0.0;
		if (1.3 < 8.0)
		{
			num4 = 0.025 * (8.0 - 1.3);
		}
		num2 *= 1f + (float)num4 * num3;
		if ((2 & 2023.Hidden) != 2023.None)
		{
			num2 *= 1f + 0.05f * (float)(11.0 - 1.3);
		}
		if ((2 & 2023.Flashlight) != 2023.None)
		{
			num2 *= 1f + 0.3f * Math.Min(3 / 200f, 1f) + ((3 > 200f) ? 1f : 0f) * 0.25f * Math.Min((3 - 200f) / 300f, 1f) + ((3 > 500f) ? 1f : 0f) * (3 - 500f) / 1600f;
		}
		num2 *= 0.3f + 5 / 2f;
		return num2 * (0.98f + (float)1.4 * (float)1.4 / 2500f);
	}

	// Token: 0x06003641 RID: 13889 RVA: 0x00154960 File Offset: 0x00152B60
	private static float 29(2077 1, 2023 2, float 3, float 4, float 5, uint 6)
	{
		float num = 2078.31(5f * Math.Max((float)1.2 / 0.0675f, 1f) - 4f) / 100000f;
		float num2 = 2078.25(3);
		num *= num2;
		if (4 > 0f)
		{
			num *= 2078.26(4, 3);
		}
		if (1.3 > 10.33)
		{
			double num3 = 0.3 * (1.3 - 10.33);
			num *= 1f + (float)num3 * num2;
		}
		if ((2 & 2023.Hidden) != 2023.None)
		{
			num *= 1f + 0.05f * (float)(11.0 - 1.3);
		}
		float num4 = (float)1.4;
		num *= (0.93f + num4 * num4 / 750f) * (float)Math.Pow((double)5, (double)((14.5f - (float)Math.Max(1.4, 8.0)) / 2f));
		return num * (float)Math.Pow(0.9800000190734863, (double)((6 < 3 / 500f) ? 0f : (6 - 3 / 500f)));
	}

	// Token: 0x06003642 RID: 13890 RVA: 0x00154A94 File Offset: 0x00152C94
	private static float 30(2077 1, 2023 2, float 3, uint 4, uint 5, uint 6)
	{
		float num = (float)1.6;
		float num2 = 4;
		float num3 = 5;
		float num4 = 6;
		float num5 = ((num > 0f) ? 1f : 0f) * Math.Max(((num2 - (3 - num)) * 6f + num3 * 2f + num4) / (num * 6f), 0f);
		float num6 = (float)Math.Pow(1.521630048751831, (double)((float)1.4)) * 2078.32(num5, 24) * 2.83f;
		num6 *= Math.Min((float)Math.Pow((double)(num / 1000f), 0.30000001192092896), 1.15f);
		if ((2 & 2023.Hidden) != 2023.None)
		{
			num6 *= 1.08f;
		}
		if ((2 & 2023.Flashlight) != 2023.None)
		{
			num6 *= 1.02f;
		}
		return num6;
	}

	// Token: 0x06003643 RID: 13891 RVA: 0x00154B68 File Offset: 0x00152D68
	private static float 31(float 1)
	{
		return 1 * 1 * 1;
	}

	// Token: 0x06003644 RID: 13892 RVA: 0x00154B70 File Offset: 0x00152D70
	private static float 32(float 1, int 2)
	{
		float num = 1f;
		float num2 = 1;
		for (int i = 2; i > 0; i >>= 1)
		{
			if ((i & 1) != 0)
			{
				num *= num2;
			}
			num2 *= num2;
		}
		return num;
	}

	// Token: 0x06003645 RID: 13893 RVA: 0x00154BA0 File Offset: 0x00152DA0
	[CompilerGenerated]
	internal static void <CreateObject>g__ComputeVertex|46_0(double 1, ref 2078.<>c__DisplayClass46_0 2, ref 2078.<>c__DisplayClass46_1 3)
	{
		2.attributes.9++;
		double num = (1 - 3.startTime) / 3.spanDuration;
		if (num % 2.0 >= 1.0)
		{
			num = 1.0 - num % 1.0;
		}
		else
		{
			num %= 1.0;
		}
		208 4 = 2.position + 3.path.10(num) - 3.endPosition;
		float num2 = 4.Length();
		if (num2 > 3.approxFollowCircleRadius)
		{
			num2 -= 3.approxFollowCircleRadius;
			3.endPosition += 2078.21(4) * num2;
			3.travelDistance += num2;
		}
	}

	// Token: 0x04002829 RID: 10281
	private const double 1 = 2147483647.0;

	// Token: 0x0400282A RID: 10282
	private const double 2 = 131072.0;

	// Token: 0x0400282B RID: 10283
	private const float 3 = 64f;

	// Token: 0x0400282C RID: 10284
	private const float 4 = 400f;

	// Token: 0x0400282D RID: 10285
	private const float 5 = 0.0675f;

	// Token: 0x0400282E RID: 10286
	private const float 6 = 52f;

	// Token: 0x0400282F RID: 10287
	private const double 7 = 36.0;

	// Token: 0x04002830 RID: 10288
	private const double 8 = 100.0;

	// Token: 0x04002831 RID: 10289
	private const float 9 = 125f;

	// Token: 0x04002832 RID: 10290
	private const float 10 = 2.617994f;

	// Token: 0x04002833 RID: 10291
	private const float 11 = 0.7853982f;

	// Token: 0x04002834 RID: 10292
	private const float 12 = 1.5707964f;

	// Token: 0x04002835 RID: 10293
	private const float 13 = 75f;

	// Token: 0x04002836 RID: 10294
	private const float 14 = 45f;

	// Token: 0x04002837 RID: 10295
	private const float 15 = 40f;

	// Token: 0x04002838 RID: 10296
	private const float 16 = 1.0471976f;

	// Token: 0x04002839 RID: 10297
	private const float 17 = 107f;

	// Token: 0x02000729 RID: 1833
	[276]
	private sealed class 2088
	{
		// Token: 0x0400283A RID: 10298
		public double 1;

		// Token: 0x0400283B RID: 10299
		public double 2;
	}

	// Token: 0x0200072A RID: 1834
	[276]
	private sealed class 2081
	{
		// Token: 0x06003647 RID: 13895 RVA: 0x00154C72 File Offset: 0x00152E72
		public bool 1(2078.2081 1)
		{
			return this.3 == 1.3 && this.2 == 1.2;
		}

		// Token: 0x0400283C RID: 10300
		public double 1;

		// Token: 0x0400283D RID: 10301
		public double 2 = 1.0;

		// Token: 0x0400283E RID: 10302
		public bool 3 = true;
	}

	// Token: 0x0200072B RID: 1835
	[276]
	private enum 2085
	{
		// Token: 0x04002840 RID: 10304
		Circle,
		// Token: 0x04002841 RID: 10305
		Slider,
		// Token: 0x04002842 RID: 10306
		Spinner,
		// Token: 0x04002843 RID: 10307
		Hold
	}

	// Token: 0x0200072C RID: 1836
	[276]
	private sealed class 2084
	{
		// Token: 0x04002844 RID: 10308
		public 2078.2085 1;

		// Token: 0x04002845 RID: 10309
		public 208 2;

		// Token: 0x04002846 RID: 10310
		public double 3;

		// Token: 0x04002847 RID: 10311
		public int 4;

		// Token: 0x04002848 RID: 10312
		public string 5;

		// Token: 0x04002849 RID: 10313
		public int 6;

		// Token: 0x0400284A RID: 10314
		public int 7;

		// Token: 0x0400284B RID: 10315
		public double 8;

		// Token: 0x0400284C RID: 10316
		public int 9;
	}

	// Token: 0x0200072D RID: 1837
	[276]
	private sealed class 2082
	{
		// Token: 0x0400284D RID: 10317
		public int 1 = 14;

		// Token: 0x0400284E RID: 10318
		public float 2 = 5f;

		// Token: 0x0400284F RID: 10319
		public float 3 = 5f;

		// Token: 0x04002850 RID: 10320
		public float 4 = 5f;

		// Token: 0x04002851 RID: 10321
		public bool 5;

		// Token: 0x04002852 RID: 10322
		public double 6 = 1.4;

		// Token: 0x04002853 RID: 10323
		public double 7 = 1.0;

		// Token: 0x04002854 RID: 10324
		public readonly List<2078.2088> 8 = new List<2078.2088>();

		// Token: 0x04002855 RID: 10325
		public readonly List<2078.2081> 9 = new List<2078.2081>();

		// Token: 0x04002856 RID: 10326
		public readonly List<2078.2084> 10 = new List<2078.2084>();

		// Token: 0x04002857 RID: 10327
		public int 11;
	}

	// Token: 0x0200072E RID: 1838
	[276]
	private sealed class 2079
	{
		// Token: 0x0600364B RID: 13899 RVA: 0x00154D2C File Offset: 0x00152F2C
		public void 1(double 1, 2078.2088 2, 2078.2081 3, bool 4)
		{
			if (1 != this.2)
			{
				this.2();
			}
			if (2 != null && (!4 || this.3 == null))
			{
				this.3 = 2;
			}
			if (3 != null && (!4 || this.4 == null))
			{
				this.4 = 3;
			}
			this.2 = 1;
		}

		// Token: 0x0600364C RID: 13900 RVA: 0x00154D7C File Offset: 0x00152F7C
		public void 2()
		{
			if (this.3 != null)
			{
				bool flag;
				int index = 2078.1<2078.2088>(this.1.8, this.3.1, (2078.2088 1) => 1.1, out flag);
				if (flag)
				{
					this.1.8[index] = this.3;
				}
				else
				{
					this.1.8.Insert(index, this.3);
				}
				this.3 = null;
			}
			if (this.4 != null)
			{
				2078.2081 <<EMPTY_NAME>> = 2078.3(this.1.9, this.4.1) ?? new 2078.2081();
				if (!this.4.1(<<EMPTY_NAME>>))
				{
					bool flag2;
					int index2 = 2078.1<2078.2081>(this.1.9, this.4.1, (2078.2081 1) => 1.1, out flag2);
					if (flag2)
					{
						this.1.9[index2] = this.4;
					}
					else
					{
						this.1.9.Insert(index2, this.4);
					}
				}
				this.4 = null;
			}
		}

		// Token: 0x04002858 RID: 10328
		public 2078.2082 1;

		// Token: 0x04002859 RID: 10329
		public double 2;

		// Token: 0x0400285A RID: 10330
		public 2078.2088 3;

		// Token: 0x0400285B RID: 10331
		public 2078.2081 4;
	}

	// Token: 0x02000730 RID: 1840
	[276]
	private struct 2086
	{
		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06003652 RID: 13906 RVA: 0x00154EDA File Offset: 0x001530DA
		public bool IsSpinner
		{
			get
			{
				return float.IsNaN(this.4);
			}
		}

		// Token: 0x0400285F RID: 10335
		public float 1;

		// Token: 0x04002860 RID: 10336
		public 208 2;

		// Token: 0x04002861 RID: 10337
		public 208 3;

		// Token: 0x04002862 RID: 10338
		public float 4;
	}

	// Token: 0x02000731 RID: 1841
	[276]
	private struct 2080
	{
		// Token: 0x04002863 RID: 10339
		public 2078.2086 1;

		// Token: 0x04002864 RID: 10340
		public bool 2;

		// Token: 0x04002865 RID: 10341
		public float 3;

		// Token: 0x04002866 RID: 10342
		public float 4;

		// Token: 0x04002867 RID: 10343
		public float 5;

		// Token: 0x04002868 RID: 10344
		public float 6;

		// Token: 0x04002869 RID: 10345
		public bool 7;

		// Token: 0x0400286A RID: 10346
		public float 8;

		// Token: 0x0400286B RID: 10347
		public float 9;

		// Token: 0x0400286C RID: 10348
		public float 10;
	}

	// Token: 0x02000732 RID: 1842
	[276]
	private sealed class 2087
	{
		// Token: 0x06003653 RID: 13907 RVA: 0x00154EE7 File Offset: 0x001530E7
		public 2087(bool 1)
		{
			this.1 = 1;
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06003654 RID: 13908 RVA: 0x00154F1C File Offset: 0x0015311C
		public float CurrentSectionPeak
		{
			get
			{
				return this.3;
			}
		}

		// Token: 0x06003655 RID: 13909 RVA: 0x00154F24 File Offset: 0x00153124
		public void 1()
		{
			this.6.Add(this.3);
		}

		// Token: 0x06003656 RID: 13910 RVA: 0x00154F37 File Offset: 0x00153137
		public void 2(float 1)
		{
			this.3 = this.2 * this.4(1 - this.5);
		}

		// Token: 0x06003657 RID: 13911 RVA: 0x00154F54 File Offset: 0x00153154
		public void 3(ref 2078.2080 1)
		{
			this.2 *= this.4(1.9);
			this.2 += (this.1 ? 2078.15(ref 1) : 2078.16(ref 1)) * (this.1 ? 26.25f : 1400f);
			this.3 = Math.Max(this.3, this.2);
			this.5 = 1.1.1;
			this.4 = true;
		}

		// Token: 0x06003658 RID: 13912 RVA: 0x00154FE1 File Offset: 0x001531E1
		private float 4(float 1)
		{
			return (float)Math.Pow((double)(this.1 ? 0.15f : 0.3f), (double)(1 / 1000f));
		}

		// Token: 0x06003659 RID: 13913 RVA: 0x00155008 File Offset: 0x00153208
		public float 5(bool 1)
		{
			List<float> list = new List<float>(this.6);
			if (3)
			{
				list.Add(this.3);
			}
			list.Sort((float 1, float 2) => 2.CompareTo(1));
			float num = 0f;
			float num2 = 1f;
			foreach (float num3 in list)
			{
				num += num3 * num2;
				num2 *= 0.9f;
			}
			return num;
		}

		// Token: 0x0400286D RID: 10349
		private readonly bool 1;

		// Token: 0x0400286E RID: 10350
		private float 2 = 1f;

		// Token: 0x0400286F RID: 10351
		private float 3 = 1f;

		// Token: 0x04002870 RID: 10352
		private bool 4;

		// Token: 0x04002871 RID: 10353
		private float 5;

		// Token: 0x04002872 RID: 10354
		public readonly List<float> 6 = new List<float>(128);
	}

	// Token: 0x02000734 RID: 1844
	[276]
	private struct 2083
	{
		// Token: 0x04002875 RID: 10357
		public double 1;

		// Token: 0x04002876 RID: 10358
		public double 2;

		// Token: 0x04002877 RID: 10359
		public double 3;

		// Token: 0x04002878 RID: 10360
		public double 4;
	}
}
