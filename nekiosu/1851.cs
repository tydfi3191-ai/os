using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x020007DF RID: 2015
internal static class 1851
{
	// Token: 0x06003A97 RID: 14999 RVA: 0x001711B0 File Offset: 0x0016F3B0
	internal static 1841 1(byte[] 1, 2023 2, 1927 3, double 4, bool 5, List<KeyValuePair<double, 1841>> 6, List<string> 7 = null, List<KeyValuePair<double, double>> 8 = null)
	{
		if (14 == null)
		{
			return null;
		}
		float num = 5f;
		float num2 = 5f;
		float num3 = 5f;
		bool flag = false;
		double val = 1.4;
		double val2 = 1.0;
		int num4 = 14;
		List<string[]> list = new List<string[]>();
		List<string[]> list2 = new List<string[]>();
		string a = null;
		using (StringReader stringReader = new StringReader(Encoding.UTF8.GetString(14)))
		{
			bool flag2 = true;
			string text;
			while ((text = stringReader.ReadLine()) != null)
			{
				if (flag2)
				{
					flag2 = false;
					text = text.TrimStart(new char[]
					{
						'﻿'
					});
					int num5 = text.IndexOf("osu file format v", StringComparison.Ordinal);
					int num6;
					if (num5 >= 0 && int.TryParse(text.Substring(num5 + 17).Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out num6))
					{
						num4 = num6;
					}
				}
				string text2 = text.Trim();
				if (text2.Length != 0 && !text2.StartsWith("//", StringComparison.Ordinal))
				{
					if (text2.StartsWith("[", StringComparison.Ordinal) && text2.EndsWith("]", StringComparison.Ordinal))
					{
						a = text2.Substring(1, text2.Length - 2);
					}
					else if (!(a == "Difficulty"))
					{
						if (!(a == "TimingPoints"))
						{
							if (a == "HitObjects")
							{
								list2.Add(text2.Split(new char[]
								{
									','
								}));
							}
						}
						else
						{
							list.Add(text2.Split(new char[]
							{
								','
							}));
						}
					}
					else
					{
						int num7 = text2.IndexOf(':');
						if (num7 >= 0)
						{
							string a2 = text2.Substring(0, num7).Trim();
							string text3 = text2.Substring(num7 + 1).Trim();
							if (!(a2 == "CircleSize"))
							{
								if (!(a2 == "OverallDifficulty"))
								{
									if (!(a2 == "ApproachRate"))
									{
										if (!(a2 == "SliderMultiplier"))
										{
											if (a2 == "SliderTickRate")
											{
												val2 = 1851.15(text3);
											}
										}
										else
										{
											val = 1851.15(text3);
										}
									}
									else
									{
										num3 = 1851.16(text3);
										flag = true;
									}
								}
								else
								{
									num2 = 1851.16(text3);
									if (!flag)
									{
										num3 = num2;
									}
								}
							}
							else
							{
								num = 1851.16(text3);
							}
						}
					}
				}
			}
		}
		num = Math.Max(0f, Math.Min(10f, num));
		num2 = Math.Max(0f, Math.Min(10f, num2));
		num3 = Math.Max(0f, Math.Min(10f, num3));
		val = Math.Max(0.4, Math.Min(3.6, val));
		val2 = Math.Max(0.5, Math.Min(8.0, val2));
		double offset = (double)((num4 < 5) ? 24 : 0);
		List<1851.1857> list3 = new List<1851.1857>();
		List<1851.1859> list4 = new List<1851.1859>();
		IEnumerable<string[]> source = from 1 in list
		where 1.Length >= 2
		select 1;
		Func<string[], double> <>9__11;
		Func<string[], double> keySelector;
		if ((keySelector = <>9__11) == null)
		{
			keySelector = (<>9__11 = ((string[] 1) => 1851.15(1[0].Trim()) + offset));
		}
		foreach (IGrouping<double, string[]> grouping in from 1 in source.GroupBy(keySelector)
		orderby 1.Key
		select 1)
		{
			string[] array = null;
			string[] array2 = null;
			foreach (string[] array3 in grouping)
			{
				if (array3.Length < 7 || array3[6].Length == 0 || array3[6][0] == '1')
				{
					if (array == null)
					{
						array = array3;
					}
				}
				else
				{
					array2 = array3;
				}
			}
			if (array != null)
			{
				double num8 = 1851.15(1851.2(array));
				if (!double.IsNaN(num8))
				{
					list3.Add(new 1851.1857
					{
						1 = grouping.Key,
						2 = Math.Max(6.0, Math.Min(60000.0, num8))
					});
				}
			}
			double num9 = 1851.15(1851.2(array2 ?? array));
			double val3 = (num9 < 0.0) ? (100.0 / -num9) : 1.0;
			list4.Add(new 1851.1859
			{
				1 = grouping.Key,
				2 = Math.Max(0.1, Math.Min(10.0, val3))
			});
		}
		List<1851.1858> list5 = new List<1851.1858>();
		foreach (string[] array4 in list2)
		{
			if (array4.Length >= 4)
			{
				float num10 = Math.Max(0f, Math.Min(512f, 1851.16(array4[0])));
				float num11 = Math.Max(0f, Math.Min(512f, 1851.16(array4[1])));
				double num12 = 1851.15(array4[2]) + offset;
				int num13 = int.Parse(array4[3].Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture);
				1851.1858 9 = new 1851.1858
				{
					1 = num12,
					2 = num10
				};
				if ((num13 & 2) != 0 && array4.Length > 5)
				{
					int num14 = (array4.Length > 6) ? int.Parse(array4[6].Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture) : 1;
					double num15 = (array4.Length > 7) ? Math.Max(0.0, 1851.15(array4[7])) : 0.0;
					9.3 = true;
					9.6 = Math.Max(0, num14 - 1);
					9.5 = 1847.2(array4[5], new 208(num10, num11), num15, false, false);
					double num16 = 1851.18(list4, num12);
					9.7 = num16;
					9.8 = ((num4 < 8) ? (1.0 / num16) : 1.0);
				}
				else if ((num13 & 8) != 0)
				{
					double num17 = (array4.Length > 5) ? Math.Max(num12, 1851.15(array4[5]) + offset) : num12;
					9.4 = true;
					9.9 = num17 - num12;
				}
				list5.Add(9);
			}
		}
		list5 = (from 1 in list5.Select((1851.1858 1, int 2) => new
		{
			1,
			2
		})
		orderby 1.top.1, 1.order
		select 1.top).ToList<1851.1858>();
		num = ((3 != null) ? 3.Apply(1928.CircleSize, num) : num);
		num3 = ((3 != null) ? 3.Apply(1928.ApproachRate, num3) : num3);
		if ((15 & 2023.Easy) != 2023.None)
		{
			num *= 0.5f;
			num3 *= 0.5f;
		}
		bool flag3 = (15 & 2023.HardRock) > 2023.None;
		if (flag3)
		{
			num = Math.Min(num * 1.3f, 10f);
			num3 = Math.Min(num3 * 1.4f, 10f);
		}
		foreach (1851.1858 10 in list5)
		{
			if (10.3)
			{
				1851.3(10, list3, val, val2);
			}
			else if (10.4)
			{
				1851.5(10);
			}
			else
			{
				10.10 = new 1851.1852
				{
					1 = 1851.1854.Fruit,
					2 = 10.1,
					3 = 10.2
				};
			}
		}
		1851.6(list5, flag3);
		List<1851.1852> source2 = 1851.10(list5);
		1851.11((from 1 in source2
		where 1.1 == 1851.1854.Fruit || 1.1 == 1851.1854.Droplet
		select 1).ToList<1851.1852>(), num);
		if (5)
		{
			foreach (1851.1858 11 in list5)
			{
				1851.1852[] array5;
				if (11.10 == null)
				{
					array5 = 11.11.ToArray();
				}
				else
				{
					(array5 = new 1851.1852[1])[0] = 11.10;
				}
				foreach (1851.1852 12 in array5)
				{
					if (12.1 == 1851.1854.Banana)
					{
						12.4 = 512f - 12.4;
					}
					else
					{
						12.3 = 512f - 12.3;
						12.4 = -12.4;
					}
				}
			}
		}
		List<1851.1852> source3 = (from 1 in source2
		where 1.1 == 1851.1854.Fruit || 1.1 == 1851.1854.Droplet
		select 1).ToList<1851.1852>();
		if (7 != null)
		{
			7.AddRange(from 1 in source3
			select string.Concat(new string[]
			{
				1.1.ToString(),
				" ",
				1.2.ToString("R", CultureInfo.InvariantCulture),
				" ",
				1.EffectiveX.ToString("R", CultureInfo.InvariantCulture),
				" ",
				((1.5 > false) ? 1 : 0).ToString(),
				" ",
				1.6.ToString("R", CultureInfo.InvariantCulture)
			}));
		}
		float num18 = 1851.12(num) * 0.5f;
		num18 *= 1f - Math.Max(0f, num - 5.5f) * 0.0625f;
		1841 13 = 1851.13(source3, 4, num18, num3, 6, 8);
		13.7 = source2.Count((1851.1852 1) => 1.1 == 1851.1854.Fruit);
		13.8 = source2.Count((1851.1852 1) => 1.1 == 1851.1854.Droplet);
		13.9 = source2.Count((1851.1852 1) => 1.1 == 1851.1854.TinyDroplet);
		if (6 != null)
		{
			List<1851.1852> list6 = (from 1 in source2
			orderby 1.2
			select 1).ToList<1851.1852>();
			int num19 = 0;
			int num20 = 0;
			int num21 = 0;
			int num22 = 0;
			foreach (KeyValuePair<double, 1841> keyValuePair in from 1 in 6
			orderby 1.Key
			select 1)
			{
				while (num19 < list6.Count && list6[num19].2 <= keyValuePair.Key)
				{
					switch (list6[num19].1)
					{
					case 1851.1854.Fruit:
						num20++;
						break;
					case 1851.1854.Droplet:
						num21++;
						break;
					case 1851.1854.TinyDroplet:
						num22++;
						break;
					}
					num19++;
				}
				keyValuePair.Value.7 = num20;
				keyValuePair.Value.8 = num21;
				keyValuePair.Value.9 = num22;
			}
		}
		return 13;
	}

	// Token: 0x06003A98 RID: 15000 RVA: 0x00171DF4 File Offset: 0x0016FFF4
	private static string 2(string[] 1)
	{
		return 1[1].Trim();
	}

	// Token: 0x06003A99 RID: 15001 RVA: 0x00171E00 File Offset: 0x00170000
	private static void 3(1851.1858 1, List<1851.1857> 2, double 3, double 4)
	{
		1851.1857 5 = 1851.17(2, 1.1);
		double num = -100.0 / 1.7;
		double num2 = (num < 0.0) ? ((double)Math.Max(10f, Math.Min(1000f, (float)(-(float)num))) / 100.0) : 1.0;
		double num3 = 100.0 * 3 / (5.2 * num2);
		double num4 = num3 * 5.2 / 4 * 1.8;
		int num5 = 1.6 + 1;
		double distance = 1.5.Distance;
		double num6 = (double)num5 * distance / num3 / (double)num5;
		float num7 = Math.Max(0f, Math.Min(512f, 1.2));
		1851.1856? 6 = null;
		foreach (1851.1856 7 in 1851.4(1.1, num6, num3, num4, distance, num5))
		{
			if (6 != null)
			{
				double num8 = (double)((int)7.2 - (int)6.Value.2);
				if (num8 > 80.0)
				{
					double num9;
					for (num9 = num8; num9 > 100.0; num9 /= 2.0)
					{
					}
					for (double num10 = num9; num10 < num8; num10 += num9)
					{
						1.11.Add(new 1851.1852
						{
							1 = 1851.1854.TinyDroplet,
							2 = num10 + 6.Value.2,
							3 = num7 + 1.5.18(6.Value.3 + num10 / num8 * (7.3 - 6.Value.3)).X
						});
					}
				}
			}
			6 = new 1851.1856?(7);
			int num11 = 7.1;
			if (num11 != 0)
			{
				if (num11 - 2 <= 2)
				{
					1.11.Add(new 1851.1852
					{
						1 = 1851.1854.Fruit,
						2 = 7.2,
						3 = num7 + 1.5.18(7.3).X
					});
				}
			}
			else
			{
				1.11.Add(new 1851.1852
				{
					1 = 1851.1854.Droplet,
					2 = 7.2,
					3 = num7 + 1.5.18(7.3).X
				});
			}
		}
	}

	// Token: 0x06003A9A RID: 15002 RVA: 0x001720BC File Offset: 0x001702BC
	private static IEnumerable<1851.1856> 4(double 1, double 2, double 3, double 4, double 5, int 6)
	{
		double length = Math.Min(100000.0, 5);
		4 = Math.Max(0.0, Math.Min(length, 4));
		double minDistanceFromEnd = 3 * 10.0;
		yield return new 1851.1856
		{
			1 = 2,
			2 = 1,
			3 = 0.0
		};
		int num4;
		for (int span = 0; span < 6; span = num4 + 1)
		{
			double spanStartTime = 1 + (double)span * 2;
			bool flag = span % 2 == 1;
			if (4 != 0.0)
			{
				List<1851.1856> list = new List<1851.1856>();
				double num = 4;
				while (num <= length && num < length - minDistanceFromEnd)
				{
					double num2 = num / length;
					double num3 = flag ? (1.0 - num2) : num2;
					list.Add(new 1851.1856
					{
						1 = 0,
						2 = spanStartTime + num3 * 2,
						3 = num2
					});
					num += 4;
				}
				if (flag)
				{
					list.Reverse();
				}
				foreach (1851.1856 7 in list)
				{
					yield return 7;
				}
				List<1851.1856>.Enumerator enumerator = default(List<1851.1856>.Enumerator);
			}
			if (span < 6 - 1)
			{
				yield return new 1851.1856
				{
					1 = 4,
					2 = spanStartTime + 2,
					3 = (double)((span + 1) % 2)
				};
			}
			num4 = span;
		}
		double totalDuration = (double)6 * 2;
		int num5 = 6 - 1;
		double num6 = 1 + (double)num5 * 2;
		double num7 = Math.Max(1 + totalDuration / 2.0, num6 + 2 + -36.0);
		double num8 = (num7 - num6) / 2;
		if (6 % 2 == 0)
		{
			num8 = 1.0 - num8;
		}
		yield return new 1851.1856
		{
			1 = 1,
			2 = num7,
			3 = num8
		};
		yield return new 1851.1856
		{
			1 = 3,
			2 = 1 + totalDuration,
			3 = (double)(6 % 2)
		};
		yield break;
		yield break;
	}

	// Token: 0x06003A9B RID: 15003 RVA: 0x001720F4 File Offset: 0x001702F4
	private static void 5(1851.1858 1)
	{
		int num = (int)1.1;
		int num2 = (int)(1.1 + 1.9);
		float num3;
		for (num3 = (float)(1.1 + 1.9 - 1.1); num3 > 100f; num3 /= 2f)
		{
		}
		if (num3 <= 0f)
		{
			return;
		}
		for (float num4 = (float)num; num4 <= (float)num2; num4 += num3)
		{
			1.11.Add(new 1851.1852
			{
				1 = 1851.1854.Banana,
				2 = (double)num4
			});
		}
	}

	// Token: 0x06003A9C RID: 15004 RVA: 0x00172178 File Offset: 0x00170378
	private static void 6(List<1851.1858> 1, bool 2)
	{
		1851.1855 3 = new 1851.1855(1337);
		float? num = null;
		double num2 = 0.0;
		foreach (1851.1858 4 in 1)
		{
			if (4.10 != null)
			{
				4.10.4 = 0f;
				if (2)
				{
					1851.7(4.10, ref num, ref num2, 3);
				}
			}
			else
			{
				if (4.4)
				{
					using (List<1851.1852>.Enumerator enumerator2 = 4.11.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							1851.1852 5 = enumerator2.Current;
							5.4 = (float)(3.2() * 512.0);
							3.Next();
							3.Next();
							3.Next();
						}
						continue;
					}
				}
				if (4.3)
				{
					num = new float?(4.2 + 4.5.LastControlPointX);
					num2 = 4.1;
					foreach (1851.1852 6 in 4.11)
					{
						6.4 = 0f;
						if (6.1 == 1851.1854.TinyDroplet)
						{
							6.4 = Math.Max(-6.3, Math.Min(512f - 6.3, (float)3.Next(-20, 20)));
						}
						else if (6.1 == 1851.1854.Droplet)
						{
							3.Next();
						}
					}
				}
			}
		}
	}

	// Token: 0x06003A9D RID: 15005 RVA: 0x00172378 File Offset: 0x00170578
	private static void 7(1851.1852 1, ref float? 2, ref double 3, 1851.1855 4)
	{
		float num = 1.3;
		double num2 = 1.2;
		if (2 != null)
		{
			float? num3 = 2;
			float num4 = 0f;
			if (!(num3.GetValueOrDefault() == num4 & num3 != null))
			{
				float num5 = num - 2.Value;
				int num6 = (int)(num2 - 3);
				if (num6 > 1000)
				{
					2 = new float?(num);
					3 = num2;
					return;
				}
				if (num5 == 0f)
				{
					1851.8(ref num, (double)num6 / 4.0, 4);
					1.4 = num - 1.3;
					return;
				}
				if (Math.Abs(num5) < (float)(num6 / 3))
				{
					1851.9(ref num, num5);
				}
				1.4 = num - 1.3;
				2 = new float?(num);
				3 = num2;
				return;
			}
		}
		2 = new float?(num);
		3 = num2;
	}

	// Token: 0x06003A9E RID: 15006 RVA: 0x00172458 File Offset: 0x00170658
	private static void 8(ref float 1, double 2, 1851.1855 3)
	{
		bool flag = 3.3();
		float num = Math.Min(20f, (float)3.Next(0.0, Math.Max(0.0, 2)));
		if (flag)
		{
			if (1 + num <= 512f)
			{
				1 += num;
				return;
			}
			1 -= num;
			return;
		}
		else
		{
			if (1 - num >= 0f)
			{
				1 -= num;
				return;
			}
			1 += num;
			return;
		}
	}

	// Token: 0x06003A9F RID: 15007 RVA: 0x001724CE File Offset: 0x001706CE
	private static void 9(ref float 1, float 2)
	{
		if (2 > 0f)
		{
			if (1 + 2 < 512f)
			{
				1 += 2;
				return;
			}
		}
		else if (1 + 2 > 0f)
		{
			1 += 2;
		}
	}

	// Token: 0x06003AA0 RID: 15008 RVA: 0x00172500 File Offset: 0x00170700
	private static List<1851.1852> 10(List<1851.1858> 1)
	{
		List<1851.1852> list = new List<1851.1852>();
		foreach (1851.1858 4 in 3)
		{
			if (4.10 != null)
			{
				list.Add(4.10);
			}
			list.AddRange(4.11);
		}
		return (from 1 in list.Select((1851.1852 1, int 2) => new
		{
			1,
			2
		})
		orderby 1.catchObject.2, 1.order
		select 1.catchObject).ToList<1851.1852>();
	}

	// Token: 0x06003AA1 RID: 15009 RVA: 0x00172604 File Offset: 0x00170804
	private static void 11(List<1851.1852> 1, float 2)
	{
		double num = (double)(1851.12(2) / 2f);
		num /= 0.800000011920929;
		int num2 = 0;
		double num3 = num;
		for (int i = 0; i < 1.Count - 1; i++)
		{
			1851.1852 3 = 1[i];
			1851.1852 4 = 1[i + 1];
			3.5 = false;
			3.6 = 0f;
			int num4 = (4.EffectiveX > 3.EffectiveX) ? 1 : -1;
			double num5 = (double)((float)((int)4.2 - (int)3.2) - 4.1666665f);
			double num6 = (double)Math.Abs(4.EffectiveX - 3.EffectiveX) - ((num2 == num4) ? num3 : num);
			float num7 = (float)(num5 * 1.0 - num6);
			if (num7 < 0f)
			{
				3.5 = true;
				num3 = num;
			}
			else
			{
				3.6 = num7;
				num3 = Math.Max(0.0, Math.Min(num, (double)num7));
			}
			num2 = num4;
		}
	}

	// Token: 0x06003AA2 RID: 15010 RVA: 0x0017270C File Offset: 0x0017090C
	private static float 12(float 1)
	{
		float value = (float)(1.0 - 0.699999988079071 * (((double)1 - 5.0) / 5.0)) / 2f * 2f;
		return 106.75f * Math.Abs(value) * 0.8f;
	}

	// Token: 0x06003AA3 RID: 15011 RVA: 0x00172768 File Offset: 0x00170968
	private static 1841 13(List<1851.1852> 1, double 2, float 3, float 4, List<KeyValuePair<double, 1841>> 5, List<KeyValuePair<double, double>> 6)
	{
		1851.<>c__DisplayClass26_0 CS$<>8__locals1;
		CS$<>8__locals1.approachRate = 4;
		CS$<>8__locals1.clockRate = 2;
		if (1.Count == 0)
		{
			return 1851.<Calculate>g__Attributes|26_0(0.0, 0, ref CS$<>8__locals1);
		}
		List<1851.1853> list = new List<1851.1853>(1.Count);
		float num = 41f / 3;
		for (int i = 1; i < 1.Count; i++)
		{
			1851.1853 7 = new 1851.1853
			{
				1 = 1[i],
				2 = 1[i - 1],
				3 = list.Count,
				4 = CS$<>8__locals1.clockRate,
				5 = 1[i].2 / CS$<>8__locals1.clockRate,
				6 = (1[i].2 - 1[i - 1].2) / CS$<>8__locals1.clockRate
			};
			7.8 = 7.1.EffectiveX * num;
			7.9 = 7.2.EffectiveX * num;
			7.7 = Math.Max(40.0, 7.6);
			7.11 = ((7.3 == 0) ? 7.9 : list[7.3 - 1].10);
			7.10 = Math.Max(7.8 - 25f, Math.Min(7.8 + 25f, 7.11));
			7.12 = 7.10 - 7.11;
			7.13 = 7.8 - 7.11;
			if (7.2.5)
			{
				7.10 = 7.8;
			}
			list.Add(7);
		}
		List<double> list2 = new List<double>();
		double num2 = 0.0;
		double num3 = 0.0;
		double num4 = 0.0;
		int num5 = 1;
		foreach (1851.1853 8 in list)
		{
			if (8.3 == 0)
			{
				num3 = Math.Ceiling(8.5 / 750.0) * 750.0;
			}
			while (8.5 > num3)
			{
				list2.Add(num2);
				num2 = num4 * 1897.11(0.2, (num3 - list[8.3 - 1].5) / 1000.0);
				num3 += 750.0;
			}
			num4 *= 1897.11(0.2, 8.6 / 1000.0);
			num4 += 1851.14(8, list);
			num2 = Math.Max(num4, num2);
			if (6 != null)
			{
				6.Add(new KeyValuePair<double, double>(8.1.2, num4));
			}
			if (5 != null)
			{
				while (num5 < 1.Count && 1[num5].2 <= 8.1.2)
				{
					num5++;
				}
				5.Add(new KeyValuePair<double, 1841>(8.1.2, 1851.<Calculate>g__Attributes|26_0(1851.StarRating(list2, num2), num5, ref CS$<>8__locals1)));
			}
		}
		return 1851.<Calculate>g__Attributes|26_0(1851.StarRating(list2, num2), 1.Count, ref CS$<>8__locals1);
	}

	// Token: 0x06003AA4 RID: 15012 RVA: 0x00172B10 File Offset: 0x00170D10
	private static double StarRating(List<double> 1, double 2)
	{
		double num = 0.0;
		double num2 = 1.0;
		foreach (double num3 in from 1 in 3.Append(2)
		where 1 > 0.0
		orderby 1 descending
		select 1)
		{
			num += num3 * num2;
			num2 *= 0.94;
		}
		return Math.Sqrt(num) * 4.59;
	}

	// Token: 0x06003AA5 RID: 15013 RVA: 0x00172BD8 File Offset: 0x00170DD8
	private static double 14(1851.1853 1, List<1851.1853> 2)
	{
		1851.1853 3 = (1.3 >= 1) ? 2[1.3 - 1] : null;
		1851.1853 4 = (1.3 >= 2) ? 2[1.3 - 2] : null;
		double num = 1.4;
		double num2 = 1.7 + 13.0 + 3.0 / num;
		double num3 = 1897.11((double)Math.Abs(1.12), 1.3) / 510.0;
		double num4 = Math.Sqrt(num2);
		double num5 = 0.0;
		if ((double)Math.Abs(1.12) > 0.1)
		{
			if (1.3 >= 1 && (double)Math.Abs(3.12) > 0.1 && Math.Sign(1.12) != Math.Sign(3.12))
			{
				double num6 = (double)(Math.Min(50f, Math.Abs(1.12)) / 50f);
				double num7 = Math.Max((double)(Math.Min(70f, Math.Abs(3.12)) / 70f), 0.38);
				num3 += 21.0 / Math.Sqrt(3.7 + 16.0) * num6 * num7 * Math.Max(1.0 - 1897.12(num2 / 1000.0, 3), 0.0);
			}
			num3 += 12.5 * (double)Math.Min(Math.Abs(1.12), 82f) / 246.0 / num4;
		}
		int num8 = 0;
		for (int i = 0; i < Math.Min(1.3, 10); i++)
		{
			1851.1853 5 = 2[1.3 - (i + 1)];
			if (Math.Sign(1.12) != Math.Sign(5.12) || 1.12 == 0f || 5.12 == 0f)
			{
				break;
			}
			double num9 = Math.Abs((double)1.12 / 1.7);
			double num10 = Math.Abs((double)5.12 / 5.7);
			if (Math.Abs(num9 / num10 - 1.0) > 0.05)
			{
				break;
			}
			num8++;
		}
		num3 *= 1897.12(0.7, num8);
		if (1.2.6 <= 20f)
		{
			if (!1.2.5)
			{
				num5 += 5.7;
			}
			num3 *= 1.0 + num5 * (double)((20f - 1.2.6) / 20f) * 1897.11(Math.Min(1.7 * num, 265.0) / 265.0, 1.5);
		}
		if (1.3 >= 2 && Math.Abs(1.13) <= 82f && 1.13 == -3.13 && 3.13 == -4.13 && 1.7 == 3.7 && 3.7 == 4.7)
		{
			num3 = 0.0;
		}
		return num3 / num2;
	}

	// Token: 0x06003AA6 RID: 15014 RVA: 0x00166E86 File Offset: 0x00165086
	private static double 15(string 1)
	{
		return double.Parse(1.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture);
	}

	// Token: 0x06003AA7 RID: 15015 RVA: 0x00147F4C File Offset: 0x0014614C
	private static float 16(string 1)
	{
		return float.Parse(1.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture);
	}

	// Token: 0x06003AA8 RID: 15016 RVA: 0x00172F64 File Offset: 0x00171164
	private static 1851.1857 17(List<1851.1857> 1, double 2)
	{
		if (1.Count == 0)
		{
			return new 1851.1857
			{
				1 = 0.0,
				2 = 1000.0
			};
		}
		1851.1857 result = 1[0];
		foreach (1851.1857 3 in 1)
		{
			if (3.1 > 2)
			{
				break;
			}
			result = 3;
		}
		return result;
	}

	// Token: 0x06003AA9 RID: 15017 RVA: 0x00172FF4 File Offset: 0x001711F4
	private static double 18(List<1851.1859> 1, double 2)
	{
		double result = 1.0;
		foreach (1851.1859 3 in 1)
		{
			if (3.1 > 2)
			{
				break;
			}
			result = 3.2;
		}
		return result;
	}

	// Token: 0x06003AAA RID: 15018 RVA: 0x00173058 File Offset: 0x00171258
	[CompilerGenerated]
	internal static 1841 <Calculate>g__Attributes|26_0(double 1, int 2, ref 1851.<>c__DisplayClass26_0 3)
	{
		return new 1841
		{
			3 = 1,
			4 = 2,
			5 = (double)3.approachRate,
			6 = 3.clockRate,
			10 = 2
		};
	}

	// Token: 0x04002B27 RID: 11047
	private const float 1 = 512f;

	// Token: 0x04002B28 RID: 11048
	private const float 2 = 106.75f;

	// Token: 0x04002B29 RID: 11049
	private const float 3 = 0.8f;

	// Token: 0x04002B2A RID: 11050
	private const double 4 = 1.0;

	// Token: 0x04002B2B RID: 11051
	private const float 5 = 41f;

	// Token: 0x04002B2C RID: 11052
	private const float 6 = 16f;

	// Token: 0x04002B2D RID: 11053
	private const int 7 = 1337;

	// Token: 0x020007E0 RID: 2016
	private enum 1854
	{
		// Token: 0x04002B2F RID: 11055
		Fruit,
		// Token: 0x04002B30 RID: 11056
		Droplet,
		// Token: 0x04002B31 RID: 11057
		TinyDroplet,
		// Token: 0x04002B32 RID: 11058
		Banana
	}

	// Token: 0x020007E1 RID: 2017
	private sealed class 1852
	{
		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06003AAB RID: 15019 RVA: 0x0017308D File Offset: 0x0017128D
		public float EffectiveX
		{
			get
			{
				return Math.Max(0f, Math.Min(512f, this.3 + this.4));
			}
		}

		// Token: 0x04002B33 RID: 11059
		public 1851.1854 1;

		// Token: 0x04002B34 RID: 11060
		public double 2;

		// Token: 0x04002B35 RID: 11061
		public float 3;

		// Token: 0x04002B36 RID: 11062
		public float 4;

		// Token: 0x04002B37 RID: 11063
		public bool 5;

		// Token: 0x04002B38 RID: 11064
		public float 6;
	}

	// Token: 0x020007E2 RID: 2018
	private sealed class 1858
	{
		// Token: 0x04002B39 RID: 11065
		public double 1;

		// Token: 0x04002B3A RID: 11066
		public float 2;

		// Token: 0x04002B3B RID: 11067
		public bool 3;

		// Token: 0x04002B3C RID: 11068
		public bool 4;

		// Token: 0x04002B3D RID: 11069
		public 1847 5;

		// Token: 0x04002B3E RID: 11070
		public int 6;

		// Token: 0x04002B3F RID: 11071
		public double 7 = 1.0;

		// Token: 0x04002B40 RID: 11072
		public double 8 = 1.0;

		// Token: 0x04002B41 RID: 11073
		public double 9;

		// Token: 0x04002B42 RID: 11074
		public 1851.1852 10;

		// Token: 0x04002B43 RID: 11075
		public readonly List<1851.1852> 11 = new List<1851.1852>();
	}

	// Token: 0x020007E3 RID: 2019
	private struct 1857
	{
		// Token: 0x04002B44 RID: 11076
		public double 1;

		// Token: 0x04002B45 RID: 11077
		public double 2;
	}

	// Token: 0x020007E4 RID: 2020
	private struct 1859
	{
		// Token: 0x04002B46 RID: 11078
		public double 1;

		// Token: 0x04002B47 RID: 11079
		public double 2;
	}

	// Token: 0x020007E5 RID: 2021
	private struct 1856
	{
		// Token: 0x04002B48 RID: 11080
		public int 1;

		// Token: 0x04002B49 RID: 11081
		public double 2;

		// Token: 0x04002B4A RID: 11082
		public double 3;
	}

	// Token: 0x020007E6 RID: 2022
	private sealed class 1853
	{
		// Token: 0x04002B4B RID: 11083
		public 1851.1852 1;

		// Token: 0x04002B4C RID: 11084
		public 1851.1852 2;

		// Token: 0x04002B4D RID: 11085
		public int 3;

		// Token: 0x04002B4E RID: 11086
		public double 4;

		// Token: 0x04002B4F RID: 11087
		public double 5;

		// Token: 0x04002B50 RID: 11088
		public double 6;

		// Token: 0x04002B51 RID: 11089
		public double 7;

		// Token: 0x04002B52 RID: 11090
		public float 8;

		// Token: 0x04002B53 RID: 11091
		public float 9;

		// Token: 0x04002B54 RID: 11092
		public float 10;

		// Token: 0x04002B55 RID: 11093
		public float 11;

		// Token: 0x04002B56 RID: 11094
		public float 12;

		// Token: 0x04002B57 RID: 11095
		public float 13;
	}

	// Token: 0x020007E7 RID: 2023
	private sealed class 1855
	{
		// Token: 0x06003AAF RID: 15023 RVA: 0x001730E2 File Offset: 0x001712E2
		public 1855(int 1)
		{
			this.3 = (uint)1;
		}

		// Token: 0x06003AB0 RID: 15024 RVA: 0x0017311C File Offset: 0x0017131C
		public uint 1()
		{
			uint num = this.3 ^ this.3 << 11;
			this.3 = this.4;
			this.4 = this.5;
			this.5 = this.6;
			return this.6 = (this.6 ^ this.6 >> 19 ^ num ^ num >> 8);
		}

		// Token: 0x06003AB1 RID: 15025 RVA: 0x0017317D File Offset: 0x0017137D
		public int Next()
		{
			return (int)(2147483647U & this.1());
		}

		// Token: 0x06003AB2 RID: 15026 RVA: 0x0017318B File Offset: 0x0017138B
		public int Next(int 1, int 2)
		{
			return (int)((double)1 + this.2() * (double)(2 - 1));
		}

		// Token: 0x06003AB3 RID: 15027 RVA: 0x0017319C File Offset: 0x0017139C
		public int Next(double 1, double 2)
		{
			return (int)(1 + this.2() * (2 - 1));
		}

		// Token: 0x06003AB4 RID: 15028 RVA: 0x001731AB File Offset: 0x001713AB
		public double 2()
		{
			return 4.656612873077393E-10 * (double)this.Next();
		}

		// Token: 0x06003AB5 RID: 15029 RVA: 0x001731C0 File Offset: 0x001713C0
		public bool 3()
		{
			if (this.8 == 32)
			{
				this.7 = this.1();
				this.8 = 1;
				return (this.7 & 1U) == 1U;
			}
			this.8++;
			return ((this.7 >>= 1) & 1U) == 1U;
		}

		// Token: 0x04002B58 RID: 11096
		private const double 1 = 4.656612873077393E-10;

		// Token: 0x04002B59 RID: 11097
		private const uint 2 = 2147483647U;

		// Token: 0x04002B5A RID: 11098
		private uint 3;

		// Token: 0x04002B5B RID: 11099
		private uint 4 = 842502087U;

		// Token: 0x04002B5C RID: 11100
		private uint 5 = 3579807591U;

		// Token: 0x04002B5D RID: 11101
		private uint 6 = 273326509U;

		// Token: 0x04002B5E RID: 11102
		private uint 7;

		// Token: 0x04002B5F RID: 11103
		private int 8 = 32;
	}
}
