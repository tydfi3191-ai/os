using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x02000795 RID: 1941
internal static class 1941
{
	// Token: 0x060038F5 RID: 14581 RVA: 0x001662D8 File Offset: 0x001644D8
	internal static 1941.1953 1(byte[] 1, 2023 2)
	{
		if (1 == null)
		{
			return null;
		}
		1941.1942 3 = 1941.2(1);
		if (3 == null || 3.1 != 0)
		{
			return null;
		}
		return new 1941.1944(3, 2).3();
	}

	// Token: 0x060038F6 RID: 14582 RVA: 0x0016630C File Offset: 0x0016450C
	private static 1941.1942 2(byte[] 1)
	{
		1941.1942 5 = new 1941.1942();
		int num = 14;
		bool flag = false;
		string a = null;
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		List<string> list3 = new List<string>();
		using (StringReader stringReader = new StringReader(Encoding.UTF8.GetString(4)))
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
					int num2 = text.IndexOf("osu file format v", StringComparison.Ordinal);
					int num3;
					if (num2 >= 0 && int.TryParse(text.Substring(num2 + 17).Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out num3))
					{
						num = num3;
					}
				}
				string text2 = text.Trim();
				if (text2.Length != 0 && !text2.StartsWith("//", StringComparison.Ordinal))
				{
					if (text2.StartsWith("[", StringComparison.Ordinal) && text2.EndsWith("]", StringComparison.Ordinal))
					{
						a = text2.Substring(1, text2.Length - 2);
					}
					else
					{
						if (!(a == "General") && !(a == "Difficulty"))
						{
							if (!(a == "Events"))
							{
								if (a == "TimingPoints")
								{
									list.Add(text2);
									continue;
								}
								if (!(a == "HitObjects"))
								{
									continue;
								}
								list2.Add(text2);
								continue;
							}
						}
						else
						{
							int num4 = text2.IndexOf(':');
							if (num4 < 0)
							{
								continue;
							}
							string a2 = text2.Substring(0, num4).Trim();
							string s = text2.Substring(num4 + 1).Trim();
							try
							{
								if (!(a2 == "Mode"))
								{
									if (!(a2 == "HPDrainRate"))
									{
										if (!(a2 == "CircleSize"))
										{
											if (!(a2 == "OverallDifficulty"))
											{
												if (!(a2 == "ApproachRate"))
												{
													if (a2 == "SliderMultiplier")
													{
														5.6 = 1941.6(s);
													}
												}
												else
												{
													5.5 = 1941.7(s);
													flag = true;
												}
											}
											else
											{
												5.4 = 1941.7(s);
												if (!flag)
												{
													5.5 = 5.4;
												}
											}
										}
										else
										{
											5.3 = 1941.7(s);
										}
									}
									else
									{
										5.2 = 1941.7(s);
									}
								}
								else
								{
									5.1 = int.Parse(s, NumberStyles.Integer, CultureInfo.InvariantCulture);
								}
								continue;
							}
							catch (Exception)
							{
								continue;
							}
						}
						if (!text.StartsWith(" ", StringComparison.Ordinal) && !text.StartsWith("_", StringComparison.Ordinal))
						{
							list3.Add(text2);
						}
					}
				}
			}
		}
		double num5 = (double)((num < 5) ? 24 : 0);
		5.2 = Math.Max(0f, Math.Min(10f, 5.2));
		5.3 = Math.Max(0f, Math.Min(10f, 5.3));
		5.4 = Math.Max(0f, Math.Min(10f, 5.4));
		5.5 = Math.Max(0f, Math.Min(10f, 5.5));
		5.6 = Math.Max(0.4, Math.Min(3.6, 5.6));
		foreach (string text3 in list3)
		{
			try
			{
				string[] array = text3.Split(new char[]
				{
					','
				});
				if (array.Length >= 3 && (array[0].Trim() == "2" || array[0].Trim() == "Break"))
				{
					double num6 = 1941.6(array[1]) + num5;
					double num7 = Math.Max(num6, 1941.6(array[2]) + num5);
					5.7 += num7 - num6;
				}
			}
			catch (Exception)
			{
			}
		}
		1941.3(5, list, num5);
		foreach (string text4 in list2)
		{
			try
			{
				1941.1954 3 = 1941.5(text4, num5, num);
				if (3 != null)
				{
					3.10 = 1941.4(5.9, 3.2, 1.0);
					5.11.Add(3);
				}
			}
			catch (Exception)
			{
			}
		}
		5.11 = (from 1 in 5.11.Select((1941.1954 1, int 2) => new
		{
			1,
			2
		})
		orderby 1.hitObject.2, 1.order
		select 1.hitObject).ToList<1941.1954>();
		return 5;
	}

	// Token: 0x060038F7 RID: 14583 RVA: 0x001668C8 File Offset: 0x00164AC8
	private static void 3(1941.1942 1, List<string> 2, double 3)
	{
		1941.<>c__DisplayClass16_0 CS$<>8__locals1;
		CS$<>8__locals1.timing = new Dictionary<double, double>();
		CS$<>8__locals1.velocity = new Dictionary<double, double>();
		CS$<>8__locals1.kiai = new Dictionary<double, double>();
		CS$<>8__locals1.pending = new List<KeyValuePair<int, double>>();
		CS$<>8__locals1.pendingTime = 0.0;
		foreach (string text in 2)
		{
			try
			{
				string[] array = text.Split(new char[]
				{
					','
				});
				double num = 1941.6(array[0].Trim()) + 3;
				double num2 = 1941.6(array[1].Trim());
				double val = (num2 < 0.0) ? (100.0 / -num2) : 1.0;
				bool flag = true;
				if (array.Length >= 7)
				{
					flag = (array[6][0] == '1');
				}
				bool flag2 = false;
				if (array.Length >= 8)
				{
					flag2 = ((int.Parse(array[7].Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture) & 1) != 0);
				}
				if (flag)
				{
					if (double.IsNaN(num2))
					{
						continue;
					}
					1941.<ReadControlPoints>g__Add|16_1(num, 0, Math.Max(6.0, Math.Min(60000.0, num2)), true, ref CS$<>8__locals1);
				}
				1941.<ReadControlPoints>g__Add|16_1(num, 1, Math.Max(0.1, Math.Min(10.0, val)), flag, ref CS$<>8__locals1);
				1941.<ReadControlPoints>g__Add|16_1(num, 2, flag2 > false, flag, ref CS$<>8__locals1);
			}
			catch (Exception)
			{
			}
		}
		1941.<ReadControlPoints>g__Flush|16_0(ref CS$<>8__locals1);
		4.8.AddRange(from 1 in CS$<>8__locals1.timing
		orderby 1.Key
		select new 1941.1943
		{
			1 = 1.Key,
			2 = 1.Value
		});
		4.9.AddRange(from 1 in CS$<>8__locals1.velocity
		orderby 1.Key
		select new 1941.1943
		{
			1 = 1.Key,
			2 = 1.Value
		});
		4.10.AddRange(from 1 in CS$<>8__locals1.kiai
		orderby 1.Key
		select new 1941.1943
		{
			1 = 1.Key,
			2 = 1.Value
		});
	}

	// Token: 0x060038F8 RID: 14584 RVA: 0x00166B98 File Offset: 0x00164D98
	private static double 4(List<1941.1943> 1, double 2, double 3)
	{
		double result = 3;
		foreach (1941.1943 4 in 1)
		{
			if (4.1 > 2)
			{
				break;
			}
			result = 4.2;
		}
		return result;
	}

	// Token: 0x060038F9 RID: 14585 RVA: 0x00166BF4 File Offset: 0x00164DF4
	private static 1941.1954 5(string 1, double 2, int 3)
	{
		string[] array = 1.Split(new char[]
		{
			','
		});
		float num = Math.Max(0f, Math.Min(512f, 1941.7(array[0])));
		float num2 = Math.Max(0f, Math.Min(512f, 1941.7(array[1])));
		if (3 < 128)
		{
			num = (float)((int)num);
			num2 = (float)((int)num2);
		}
		double num3 = 1941.6(array[2]) + 2;
		int num4 = int.Parse(array[3].Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture);
		int element = int.Parse(array[4].Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture);
		1941.1954 4 = new 1941.1954
		{
			2 = num3,
			3 = num,
			4 = num2,
			5 = element,
			9 = num3
		};
		if ((num4 & 1) != 0)
		{
			4.1 = 1941.1950.Circle;
		}
		else if ((num4 & 2) != 0)
		{
			int num5 = int.Parse(array[6].Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture);
			if (num5 > 9000)
			{
				throw new FormatException("Repeat count is way too high");
			}
			num5 = Math.Max(0, num5 - 1);
			4.1 = 1941.1950.Slider;
			4.8 = num5;
			4.7 = ((array.Length > 7) ? Math.Max(0.0, 1941.6(array[7])) : 0.0);
			int num6 = num5 + 2;
			4.6 = Enumerable.Repeat<int>(element, num6).ToList<int>();
			if (array.Length > 8 && array[8].Length > 0)
			{
				string[] array2 = array[8].Split(new char[]
				{
					'|'
				});
				for (int i = 0; i < num6; i++)
				{
					if (i >= array2.Length)
					{
						break;
					}
					int value;
					int.TryParse(array2[i], out value);
					4.6[i] = value;
				}
			}
		}
		else if ((num4 & 8) != 0)
		{
			4.1 = 1941.1950.Spinner;
			4.3 = 256f;
			4.4 = 192f;
			4.9 = num3 + Math.Max(0.0, 1941.6(array[5]) + 2 - num3);
		}
		else
		{
			if ((num4 & 128) == 0)
			{
				return null;
			}
			double num7 = Math.Max(num3, 1941.6(array[2]));
			if (array.Length > 5 && !string.IsNullOrEmpty(array[5]))
			{
				num7 = Math.Max(num3, 1941.6(array[5].Split(new char[]
				{
					':'
				})[0]));
			}
			4.1 = 1941.1950.Hold;
			4.9 = num3 + (num7 + 2 - num3);
		}
		return 4;
	}

	// Token: 0x060038FA RID: 14586 RVA: 0x00166E86 File Offset: 0x00165086
	private static double 6(string 1)
	{
		return double.Parse(1.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture);
	}

	// Token: 0x060038FB RID: 14587 RVA: 0x00147F4C File Offset: 0x0014614C
	private static float 7(string 1)
	{
		return float.Parse(1.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture);
	}

	// Token: 0x060038FC RID: 14588 RVA: 0x00166EA0 File Offset: 0x001650A0
	[CompilerGenerated]
	internal static void <ReadControlPoints>g__Flush|16_0(ref 1941.<>c__DisplayClass16_0 1)
	{
		HashSet<int> hashSet = new HashSet<int>();
		for (int i = 1.pending.Count - 1; i >= 0; i--)
		{
			if (hashSet.Add(1.pending[i].Key))
			{
				((1.pending[i].Key == 0) ? 1.timing : ((1.pending[i].Key == 1) ? 1.velocity : 1.kiai))[1.pendingTime] = 1.pending[i].Value;
			}
		}
		1.pending.Clear();
	}

	// Token: 0x060038FD RID: 14589 RVA: 0x00166F5C File Offset: 0x0016515C
	[CompilerGenerated]
	internal static void <ReadControlPoints>g__Add|16_1(double 1, int 2, double 3, bool 4, ref 1941.<>c__DisplayClass16_0 5)
	{
		if (1 != 5.pendingTime)
		{
			1941.<ReadControlPoints>g__Flush|16_0(ref 5);
		}
		if (4)
		{
			5.pending.Insert(0, new KeyValuePair<int, double>(2, 3));
		}
		else
		{
			5.pending.Add(new KeyValuePair<int, double>(2, 3));
		}
		5.pendingTime = 1;
	}

	// Token: 0x04002A0D RID: 10765
	private const int 1 = 24;

	// Token: 0x04002A0E RID: 10766
	private const int 2 = 7;

	// Token: 0x04002A0F RID: 10767
	private const int 3 = 2;

	// Token: 0x04002A10 RID: 10768
	private const int 4 = 4;

	// Token: 0x04002A11 RID: 10769
	private const int 5 = 8;

	// Token: 0x02000796 RID: 1942
	internal struct 1949
	{
		// Token: 0x04002A12 RID: 10770
		public int 1;

		// Token: 0x04002A13 RID: 10771
		public double 2;

		// Token: 0x04002A14 RID: 10772
		public double 3;
	}

	// Token: 0x02000797 RID: 1943
	internal sealed class 1953
	{
		// Token: 0x04002A15 RID: 10773
		public List<1941.1949> 1;

		// Token: 0x04002A16 RID: 10774
		public int 2;
	}

	// Token: 0x02000798 RID: 1944
	private enum 1950
	{
		// Token: 0x04002A18 RID: 10776
		Circle,
		// Token: 0x04002A19 RID: 10777
		Slider,
		// Token: 0x04002A1A RID: 10778
		Spinner,
		// Token: 0x04002A1B RID: 10779
		Hold
	}

	// Token: 0x02000799 RID: 1945
	[Flags]
	private enum 1952
	{
		// Token: 0x04002A1D RID: 10781
		None = 0,
		// Token: 0x04002A1E RID: 10782
		ForceStack = 1,
		// Token: 0x04002A1F RID: 10783
		ForceNotStack = 2,
		// Token: 0x04002A20 RID: 10784
		KeepSingle = 4,
		// Token: 0x04002A21 RID: 10785
		LowProbability = 8,
		// Token: 0x04002A22 RID: 10786
		Alternate = 16,
		// Token: 0x04002A23 RID: 10787
		ForceSigSlider = 32,
		// Token: 0x04002A24 RID: 10788
		ForceNotSlider = 64,
		// Token: 0x04002A25 RID: 10789
		Gathered = 128,
		// Token: 0x04002A26 RID: 10790
		Mirror = 256,
		// Token: 0x04002A27 RID: 10791
		Reverse = 512,
		// Token: 0x04002A28 RID: 10792
		Cycle = 1024,
		// Token: 0x04002A29 RID: 10793
		Stair = 2048,
		// Token: 0x04002A2A RID: 10794
		ReverseStair = 4096
	}

	// Token: 0x0200079A RID: 1946
	private sealed class 1954
	{
		// Token: 0x04002A2B RID: 10795
		public 1941.1950 1;

		// Token: 0x04002A2C RID: 10796
		public double 2;

		// Token: 0x04002A2D RID: 10797
		public float 3;

		// Token: 0x04002A2E RID: 10798
		public float 4;

		// Token: 0x04002A2F RID: 10799
		public int 5;

		// Token: 0x04002A30 RID: 10800
		public List<int> 6;

		// Token: 0x04002A31 RID: 10801
		public double 7;

		// Token: 0x04002A32 RID: 10802
		public int 8;

		// Token: 0x04002A33 RID: 10803
		public double 9;

		// Token: 0x04002A34 RID: 10804
		public double 10 = 1.0;
	}

	// Token: 0x0200079B RID: 1947
	private struct 1943
	{
		// Token: 0x04002A35 RID: 10805
		public double 1;

		// Token: 0x04002A36 RID: 10806
		public double 2;
	}

	// Token: 0x0200079C RID: 1948
	private sealed class 1951
	{
		// Token: 0x06003900 RID: 14592 RVA: 0x00166FC5 File Offset: 0x001651C5
		public bool 1(int 1)
		{
			return this.2.Contains(1);
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06003901 RID: 14593 RVA: 0x00166FD3 File Offset: 0x001651D3
		public int ColumnWithObjects
		{
			get
			{
				return this.2.Count;
			}
		}

		// Token: 0x06003902 RID: 14594 RVA: 0x00166FE0 File Offset: 0x001651E0
		public void 2(1941.1949 1)
		{
			this.1.Add(1);
			this.2.Add(1.1);
		}

		// Token: 0x06003903 RID: 14595 RVA: 0x00167000 File Offset: 0x00165200
		public void 3(1941.1951 1)
		{
			foreach (1941.1949 2 in 1.1)
			{
				this.2(2);
			}
		}

		// Token: 0x06003904 RID: 14596 RVA: 0x00167054 File Offset: 0x00165254
		public void 4()
		{
			this.1.Clear();
			this.2.Clear();
		}

		// Token: 0x04002A37 RID: 10807
		public readonly List<1941.1949> 1 = new List<1941.1949>();

		// Token: 0x04002A38 RID: 10808
		private readonly HashSet<int> 2 = new HashSet<int>();
	}

	// Token: 0x0200079D RID: 1949
	private sealed class 1948 : Exception
	{
	}

	// Token: 0x0200079E RID: 1950
	private sealed class 1942
	{
		// Token: 0x04002A39 RID: 10809
		public int 1;

		// Token: 0x04002A3A RID: 10810
		public float 2 = 5f;

		// Token: 0x04002A3B RID: 10811
		public float 3 = 5f;

		// Token: 0x04002A3C RID: 10812
		public float 4 = 5f;

		// Token: 0x04002A3D RID: 10813
		public float 5 = 5f;

		// Token: 0x04002A3E RID: 10814
		public double 6 = 1.4;

		// Token: 0x04002A3F RID: 10815
		public double 7;

		// Token: 0x04002A40 RID: 10816
		public readonly List<1941.1943> 8 = new List<1941.1943>();

		// Token: 0x04002A41 RID: 10817
		public readonly List<1941.1943> 9 = new List<1941.1943>();

		// Token: 0x04002A42 RID: 10818
		public readonly List<1941.1943> 10 = new List<1941.1943>();

		// Token: 0x04002A43 RID: 10819
		public List<1941.1954> 11 = new List<1941.1954>();
	}

	// Token: 0x0200079F RID: 1951
	private sealed class 1944
	{
		// Token: 0x06003908 RID: 14600 RVA: 0x00167108 File Offset: 0x00165308
		public 1944(1941.1942 1, 2023 2)
		{
			this.1 = 1;
			this.2 = new 1941.1947((int)Math.Round((double)(this.1.2 + this.1.3)) * 20 + (int)((double)this.1.4 * 41.2) + (int)Math.Round((double)this.1.5));
			int num = 1941.1944.1(2) ?? this.2();
			this.3 = num * (((2 & 2023.KeyCoop) != 2023.None) ? 2 : 1);
			this.4 = ((this.3 == 8) ? 1 : 0);
			1941.1954 3 = this.1.11.LastOrDefault<1941.1954>();
			1941.1954 4 = this.1.11.FirstOrDefault<1941.1954>();
			int num2 = (int)((((3 != null) ? 3.2 : 0.0) - ((4 != null) ? 4.2 : 0.0) - this.1.7) / 1000.0);
			if (num2 == 0)
			{
				num2 = 10000;
			}
			double val = ((double)(this.1.2 + Math.Max(4f, Math.Min(7f, this.1.5))) / 1.5 + (double)this.1.11.Count / (double)num2 * 9.0) / 38.0 * 5.0 / 1.15;
			this.5 = Math.Min(val, 12.0);
		}

		// Token: 0x06003909 RID: 14601 RVA: 0x001672E4 File Offset: 0x001654E4
		private static int? 1(2023 1)
		{
			if ((1 & 2023.Key1) != 2023.None)
			{
				return new int?(1);
			}
			if ((1 & 2023.Key2) != 2023.None)
			{
				return new int?(2);
			}
			if ((1 & 2023.Key3) != 2023.None)
			{
				return new int?(3);
			}
			if ((1 & 2023.Key4) != 2023.None)
			{
				return new int?(4);
			}
			if ((1 & 2023.Key5) != 2023.None)
			{
				return new int?(5);
			}
			if ((1 & 2023.Key6) != 2023.None)
			{
				return new int?(6);
			}
			if ((1 & 2023.Key7) != 2023.None)
			{
				return new int?(7);
			}
			if ((1 & 2023.Key8) != 2023.None)
			{
				return new int?(8);
			}
			if ((1 & 2023.Key9) != 2023.None)
			{
				return new int?(9);
			}
			return null;
		}

		// Token: 0x0600390A RID: 14602 RVA: 0x0016738C File Offset: 0x0016558C
		private int 2()
		{
			double num = Math.Round((double)this.1.3);
			double num2 = Math.Round((double)this.1.4);
			int count = this.1.11.Count;
			if (count > 0)
			{
				double num3 = (double)this.1.11.Count((1941.1954 1) => 1.1 > 1941.1950.Circle) / (double)count;
				if (num3 < 0.2)
				{
					return 7;
				}
				if (num3 < 0.3 || num >= 5.0)
				{
					if (num2 <= 5.0)
					{
						return 6;
					}
					return 7;
				}
				else if (num3 > 0.6)
				{
					if (num2 <= 4.0)
					{
						return 4;
					}
					return 5;
				}
			}
			return Math.Max(4, Math.Min((int)num2 + 1, 7));
		}

		// Token: 0x0600390B RID: 14603 RVA: 0x0016746C File Offset: 0x0016566C
		public 1941.1953 3()
		{
			List<1941.1949> list = new List<1941.1949>();
			foreach (1941.1954 <<EMPTY_NAME>> in this.1.11)
			{
				switch (<<EMPTY_NAME>>.1)
				{
				case 1941.1950.Circle:
				{
					this.4(<<EMPTY_NAME>>.2);
					1941.1944.1945 2 = new 1941.1944.1945(this, <<EMPTY_NAME>>, this.9, this.10, this.11, this.8, this.12);
					this.5(<<EMPTY_NAME>>.2, <<EMPTY_NAME>>.3, <<EMPTY_NAME>>.4);
					1941.1951 3 = 2.2();
					this.12 = 2.5;
					this.6 = 3;
					list.AddRange(3.1);
					continue;
				}
				case 1941.1950.Slider:
				{
					1941.1944.1946 4 = new 1941.1944.1946(this, <<EMPTY_NAME>>);
					for (int i = 0; i <= 4.8; i++)
					{
						double num = <<EMPTY_NAME>>.2 + (double)(4.7 * i);
						this.5(num, <<EMPTY_NAME>>.3, <<EMPTY_NAME>>.4);
						this.4(num);
					}
					using (IEnumerator<1941.1951> enumerator2 = 4.2().GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							1941.1951 5 = enumerator2.Current;
							this.6 = 5;
							list.AddRange(5.1);
						}
						continue;
					}
					break;
				}
				case 1941.1950.Spinner:
					break;
				case 1941.1950.Hold:
					list.Add(new 1941.1949
					{
						1 = this.6(<<EMPTY_NAME>>.3, false),
						2 = <<EMPTY_NAME>>.2,
						3 = <<EMPTY_NAME>>.9
					});
					this.5(<<EMPTY_NAME>>.9, <<EMPTY_NAME>>.3, <<EMPTY_NAME>>.4);
					this.4(<<EMPTY_NAME>>.9);
					continue;
				default:
					continue;
				}
				1941.1951 6 = this.12(<<EMPTY_NAME>>);
				this.5(<<EMPTY_NAME>>.9, 256f, 192f);
				this.4(<<EMPTY_NAME>>.9);
				list.AddRange(6.1);
			}
			return new 1941.1953
			{
				1 = list,
				2 = this.3
			};
		}

		// Token: 0x0600390C RID: 14604 RVA: 0x001676D8 File Offset: 0x001658D8
		private void 4(double 1)
		{
			this.7.Enqueue(1);
			if (this.7.Count > 7)
			{
				this.7.Dequeue();
			}
			if (this.7.Count >= 2)
			{
				this.8 = (this.7.Last<double>() - this.7.Peek()) / (double)this.7.Count;
			}
		}

		// Token: 0x0600390D RID: 14605 RVA: 0x00167743 File Offset: 0x00165943
		private void 5(double 1, float 2, float 3)
		{
			this.9 = 1;
			this.10 = 2;
			this.11 = 3;
		}

		// Token: 0x0600390E RID: 14606 RVA: 0x0016775C File Offset: 0x0016595C
		private int 6(float 1, bool 2 = false)
		{
			if (2 && this.3 == 8)
			{
				return Math.Max(0, Math.Min(6, (int)Math.Floor((double)(1 / 73.14286f)))) + 1;
			}
			float num = 512f / (float)this.3;
			return Math.Max(0, Math.Min(this.3 - 1, (int)Math.Floor((double)(1 / num))));
		}

		// Token: 0x0600390F RID: 14607 RVA: 0x001677C0 File Offset: 0x001659C0
		private int 7(double 1, double 2, double 3 = 0.0, double 4 = 0.0, double 5 = 0.0)
		{
			foreach (double num in new double[]
			{
				1,
				2,
				3,
				4,
				5
			})
			{
				if (num < 0.0 || num > 1.0)
				{
					throw new ArgumentOutOfRangeException();
				}
			}
			double num2 = this.2.2();
			if (num2 >= 1.0 - 5)
			{
				return 6;
			}
			if (num2 >= 1.0 - 4)
			{
				return 5;
			}
			if (num2 >= 1.0 - 3)
			{
				return 4;
			}
			if (num2 >= 1.0 - 2)
			{
				return 3;
			}
			if (num2 < 1.0 - 1)
			{
				return 1;
			}
			return 2;
		}

		// Token: 0x06003910 RID: 14608 RVA: 0x0016787C File Offset: 0x00165A7C
		private int 8(int 1, int? 2 = null, int? 3 = null, Func<int, int> 4 = null, Func<int, bool> 5 = null, params 1941.1951[] 6)
		{
			1941.1944.<>c__DisplayClass20_0 CS$<>8__locals1 = new 1941.1944.<>c__DisplayClass20_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.validation = 5;
			CS$<>8__locals1.patterns = 6;
			CS$<>8__locals1.lower = (2 ?? this.4);
			CS$<>8__locals1.upper = (3 ?? this.3);
			if (4 == null)
			{
				4 = ((int 1) => CS$<>8__locals1.<>4__this.10(new int?(CS$<>8__locals1.lower), new int?(CS$<>8__locals1.upper)));
			}
			if (CS$<>8__locals1.<FindAvailableColumn>g__IsValid|1(7))
			{
				return 7;
			}
			bool flag = false;
			for (int i = CS$<>8__locals1.lower; i < CS$<>8__locals1.upper; i++)
			{
				flag = CS$<>8__locals1.<FindAvailableColumn>g__IsValid|1(i);
				if (flag)
				{
					break;
				}
			}
			if (!flag)
			{
				throw new 1941.1948();
			}
			do
			{
				7 = 4(7);
			}
			while (!CS$<>8__locals1.<FindAvailableColumn>g__IsValid|1(7));
			return 7;
		}

		// Token: 0x06003911 RID: 14609 RVA: 0x00167944 File Offset: 0x00165B44
		private int 9(int 1, params 1941.1951[] 2)
		{
			return this.8(1, null, null, null, null, 2);
		}

		// Token: 0x06003912 RID: 14610 RVA: 0x00167970 File Offset: 0x00165B70
		private int 10(int? 1 = null, int? 2 = null)
		{
			return this.2.Next(1 ?? this.4, 2 ?? this.3);
		}

		// Token: 0x06003913 RID: 14611 RVA: 0x001679BC File Offset: 0x00165BBC
		private static bool 11(int 1, int 2)
		{
			return (1 & 2) != 0;
		}

		// Token: 0x06003914 RID: 14612 RVA: 0x001679C4 File Offset: 0x00165BC4
		private 1941.1951 12(1941.1954 1)
		{
			1941.1944.<>c__DisplayClass26_0 CS$<>8__locals1;
			CS$<>8__locals1.<>4__this = this;
			int num = (int)1.9;
			CS$<>8__locals1.forceNotStack = (this.6.ColumnWithObjects != this.3);
			bool flag = (double)num - 1.2 >= 100.0;
			int num2;
			if (this.3 == 8 && 1941.1944.11(1.5, 4) && (double)num - 1.2 < 1000.0)
			{
				num2 = 0;
			}
			else if (this.3 == 8)
			{
				num2 = this.<GenerateSpinner>g__RandomColumn|26_0(null, ref CS$<>8__locals1);
			}
			else
			{
				num2 = this.<GenerateSpinner>g__RandomColumn|26_0(new int?(0), ref CS$<>8__locals1);
			}
			1941.1951 2 = new 1941.1951();
			2.2(new 1941.1949
			{
				1 = num2,
				2 = 1.2,
				3 = (flag ? (1.2 + ((double)num - 1.2)) : 1.2)
			});
			return 2;
		}

		// Token: 0x06003915 RID: 14613 RVA: 0x00167AC0 File Offset: 0x00165CC0
		[CompilerGenerated]
		private int <GenerateSpinner>g__RandomColumn|26_0(int? 1, ref 1941.1944.<>c__DisplayClass26_0 2)
		{
			if (!2.forceNotStack)
			{
				return this.8(this.10(1, null), 1, null, null, null, Array.Empty<1941.1951>());
			}
			return this.8(this.10(1, null), 1, null, null, null, new 1941.1951[]
			{
				this.6
			});
		}

		// Token: 0x04002A44 RID: 10820
		private readonly 1941.1942 1;

		// Token: 0x04002A45 RID: 10821
		private readonly 1941.1947 2;

		// Token: 0x04002A46 RID: 10822
		private readonly int 3;

		// Token: 0x04002A47 RID: 10823
		private readonly int 4;

		// Token: 0x04002A48 RID: 10824
		private readonly double 5;

		// Token: 0x04002A49 RID: 10825
		private 1941.1951 6 = new 1941.1951();

		// Token: 0x04002A4A RID: 10826
		private readonly Queue<double> 7 = new Queue<double>();

		// Token: 0x04002A4B RID: 10827
		private double 8 = 2147483647.0;

		// Token: 0x04002A4C RID: 10828
		private double 9;

		// Token: 0x04002A4D RID: 10829
		private float 10;

		// Token: 0x04002A4E RID: 10830
		private float 11;

		// Token: 0x04002A4F RID: 10831
		private 1941.1952 12 = 1941.1952.Stair;

		// Token: 0x020007A0 RID: 1952
		private sealed class 1945
		{
			// Token: 0x06003916 RID: 14614 RVA: 0x00167B30 File Offset: 0x00165D30
			public 1945(1941.1944 1, 1941.1954 2, double 3, float 4, float 5, double 6, 1941.1952 7)
			{
				this.1 = 1;
				this.2 = 2;
				this.4 = 1.6;
				this.5 = 7;
				double num = 1941.4(this.1.1.8, this.2.2, (this.1.1.8.Count > 0) ? this.1.1.8[0].2 : 1000.0);
				bool flag = 1941.4(this.1.1.10, this.2.2, 0.0) != 0.0;
				float num2 = this.2.3 - 4;
				float num3 = this.2.4 - 5;
				float num4 = (float)Math.Sqrt((double)(num2 * num2 + num3 * num3));
				double num5 = this.2.2 - 3;
				if (num5 <= 80.0)
				{
					this.3 |= (1941.1952.ForceNotStack | 1941.1952.KeepSingle);
				}
				else if (num5 <= 95.0)
				{
					this.3 |= (1941.1952.ForceNotStack | 1941.1952.KeepSingle | 7);
				}
				else if (num5 <= 105.0)
				{
					this.3 |= (1941.1952.ForceNotStack | 1941.1952.LowProbability);
				}
				else if (num5 <= 125.0)
				{
					this.3 |= 1941.1952.ForceNotStack;
				}
				else if (num5 <= 135.0 && num4 < 20f)
				{
					this.3 |= (1941.1952.KeepSingle | 1941.1952.Cycle);
				}
				else if (num5 <= 150.0 && num4 < 20f)
				{
					this.3 |= (1941.1952.ForceStack | 1941.1952.LowProbability);
				}
				else if (num4 < 20f && 6 >= num / 2.5)
				{
					this.3 |= (1941.1952.LowProbability | 1941.1952.Reverse);
				}
				else if (6 >= num / 2.5 && !flag)
				{
					this.3 |= 1941.1952.LowProbability;
				}
				if ((this.3 & 1941.1952.KeepSingle) == 1941.1952.None)
				{
					if (1941.1944.11(this.2.5, 4) && this.1.3 != 8)
					{
						this.3 |= 1941.1952.Mirror;
						return;
					}
					if (1941.1944.11(this.2.5, 8))
					{
						this.3 |= 1941.1952.Gathered;
					}
				}
			}

			// Token: 0x06003917 RID: 14615 RVA: 0x00167DBD File Offset: 0x00165FBD
			private bool 1(1941.1952 1)
			{
				return (this.3 & 1) > 1941.1952.None;
			}

			// Token: 0x06003918 RID: 14616 RVA: 0x00167DCC File Offset: 0x00165FCC
			public 1941.1951 2()
			{
				1941.1951 <<EMPTY_NAME>> = this.3();
				foreach (1941.1949 2 in <<EMPTY_NAME>>.1)
				{
					if (this.1(1941.1952.Stair) && 2.1 == this.1.3 - 1)
					{
						this.5 = 1941.1952.ReverseStair;
					}
					if (this.1(1941.1952.ReverseStair) && 2.1 == this.1.4)
					{
						this.5 = 1941.1952.Stair;
					}
				}
				return <<EMPTY_NAME>>;
			}

			// Token: 0x06003919 RID: 14617 RVA: 0x00167E78 File Offset: 0x00166078
			private 1941.1951 3()
			{
				1941.1951 result = new 1941.1951();
				if (this.1.3 == 1)
				{
					this.10(result, 0);
					return result;
				}
				int num = (this.4.1.Count > 0) ? this.4.1[0].1 : 0;
				if (this.1(1941.1952.Reverse) && this.4.1.Count > 0)
				{
					for (int i = this.1.4; i < this.1.3; i++)
					{
						if (this.4.1(i))
						{
							this.10(result, this.1.4 + this.1.3 - i - 1);
						}
					}
					return result;
				}
				if (this.1(1941.1952.Cycle) && this.4.1.Count == 1 && (this.1.3 != 8 || num != 0) && (this.1.3 % 2 == 0 || num != this.1.3 / 2))
				{
					this.10(result, this.1.4 + this.1.3 - num - 1);
					return result;
				}
				if (this.1(1941.1952.ForceStack) && this.4.1.Count > 0)
				{
					for (int j = this.1.4; j < this.1.3; j++)
					{
						if (this.4.1(j))
						{
							this.10(result, j);
						}
					}
					return result;
				}
				if (this.4.1.Count == 1)
				{
					if (this.1(1941.1952.Stair))
					{
						int num2 = num + 1;
						if (num2 == this.1.3)
						{
							num2 = this.1.4;
						}
						this.10(result, num2);
						return result;
					}
					if (this.1(1941.1952.ReverseStair))
					{
						int num3 = num - 1;
						if (num3 == this.1.4 - 1)
						{
							num3 = this.1.3 - 1;
						}
						this.10(result, num3);
						return result;
					}
				}
				if (this.1(1941.1952.KeepSingle))
				{
					return this.4(1);
				}
				if (this.1(1941.1952.Mirror))
				{
					if (this.1.5 > 6.5)
					{
						return this.7(0.12, 0.38, 0.12);
					}
					if (this.1.5 > 4.0)
					{
						return this.7(0.12, 0.17, 0.0);
					}
					return this.7(0.12, 0.0, 0.0);
				}
				else if (this.1.5 > 6.5)
				{
					if (!this.1(1941.1952.LowProbability))
					{
						return this.6(1.0, 0.62, 0.0, 0.0);
					}
					return this.6(0.78, 0.42, 0.0, 0.0);
				}
				else if (this.1.5 > 4.0)
				{
					if (!this.1(1941.1952.LowProbability))
					{
						return this.6(0.52, 0.15, 0.0, 0.0);
					}
					return this.6(0.35, 0.08, 0.0, 0.0);
				}
				else
				{
					if (this.1.5 <= 2.0)
					{
						return this.6(0.0, 0.0, 0.0, 0.0);
					}
					if (!this.1(1941.1952.LowProbability))
					{
						return this.6(0.45, 0.0, 0.0, 0.0);
					}
					return this.6(0.18, 0.0, 0.0, 0.0);
				}
			}

			// Token: 0x0600391A RID: 14618 RVA: 0x001682D0 File Offset: 0x001664D0
			private 1941.1951 4(int 1)
			{
				1941.1951 2 = new 1941.1951();
				bool flag = !this.1(1941.1952.ForceNotStack);
				if (!flag)
				{
					1 = Math.Min(1, this.1.3 - this.1.4 - this.4.ColumnWithObjects);
				}
				int num = this.1.6(this.2.3, true);
				for (int i = 0; i < 1; i++)
				{
					num = (flag ? this.1.8(num, null, null, new Func<int, int>(this.5), null, new 1941.1951[]
					{
						2
					}) : this.1.8(num, null, null, new Func<int, int>(this.5), null, new 1941.1951[]
					{
						2,
						this.4
					}));
					this.10(2, num);
				}
				return 2;
			}

			// Token: 0x0600391B RID: 14619 RVA: 0x001683CC File Offset: 0x001665CC
			private int 5(int 1)
			{
				if (this.1(1941.1952.Gathered))
				{
					1++;
					if (1 == this.1.3)
					{
						1 = this.1.4;
					}
				}
				else
				{
					1 = this.1.10(null, null);
				}
				return 1;
			}

			// Token: 0x1700029B RID: 667
			// (get) Token: 0x0600391C RID: 14620 RVA: 0x00168428 File Offset: 0x00166628
			private bool HasSpecialColumn
			{
				get
				{
					return 1941.1944.11(this.2.5, 8) && 1941.1944.11(this.2.5, 4);
				}
			}

			// Token: 0x0600391D RID: 14621 RVA: 0x00168450 File Offset: 0x00166650
			private 1941.1951 6(double 1, double 2, double 3, double 4)
			{
				1941.1951 5 = new 1941.1951();
				5.3(this.4(this.8(1, 2, 3, 4)));
				if (this.1.4 > 0 && this.HasSpecialColumn)
				{
					this.10(5, 0);
				}
				return 5;
			}

			// Token: 0x0600391E RID: 14622 RVA: 0x0016849C File Offset: 0x0016669C
			private 1941.1951 7(double 1, double 2, double 3)
			{
				if (this.1(1941.1952.ForceNotStack))
				{
					return this.6(0.5 + 2 / 2.0, 2, (2 + 3) / 2.0, 3);
				}
				1941.1951 4 = new 1941.1951();
				bool flag;
				int num = this.9(1, 2, 3, out flag);
				int value = ((this.1.3 % 2 == 0) ? this.1.3 : (this.1.3 - 1)) / 2;
				int num2 = this.1.10(null, new int?(value));
				for (int i = 0; i < num; i++)
				{
					num2 = this.1.8(num2, null, new int?(value), null, null, new 1941.1951[]
					{
						4
					});
					this.10(4, num2);
					this.10(4, this.1.4 + this.1.3 - num2 - 1);
				}
				if (flag)
				{
					this.10(4, this.1.3 / 2);
				}
				if (this.1.4 > 0 && this.HasSpecialColumn)
				{
					this.10(4, 0);
				}
				return 4;
			}

			// Token: 0x0600391F RID: 14623 RVA: 0x001685D8 File Offset: 0x001667D8
			private int 8(double 1, double 2, double 3, double 4)
			{
				switch (this.1.3)
				{
				case 2:
					1 = 0.0;
					2 = 0.0;
					3 = 0.0;
					4 = 0.0;
					break;
				case 3:
					1 = Math.Min(1, 0.1);
					2 = 0.0;
					3 = 0.0;
					4 = 0.0;
					break;
				case 4:
					1 = Math.Min(1, 0.23);
					2 = Math.Min(2, 0.04);
					3 = 0.0;
					4 = 0.0;
					break;
				case 5:
					2 = Math.Min(2, 0.15);
					3 = Math.Min(3, 0.03);
					4 = 0.0;
					break;
				}
				if (1941.1944.11(this.2.5, 8))
				{
					1 = 1.0;
				}
				return this.1.7(1, 2, 3, 4, 0.0);
			}

			// Token: 0x06003920 RID: 14624 RVA: 0x00168714 File Offset: 0x00166914
			private int 9(double 1, double 2, double 3, out bool 4)
			{
				switch (this.1.3)
				{
				case 2:
					1 = 0.0;
					2 = 0.0;
					3 = 0.0;
					break;
				case 3:
					1 = Math.Min(1, 0.03);
					2 = 0.0;
					3 = 0.0;
					break;
				case 4:
					1 = 0.0;
					2 = 1.0 - Math.Max((1.0 - 2) * 2.0, 0.8);
					3 = 0.0;
					break;
				case 5:
					1 = Math.Min(1, 0.03);
					3 = 0.0;
					break;
				case 6:
					1 = 0.0;
					2 = 1.0 - Math.Max((1.0 - 2) * 2.0, 0.5);
					3 = 1.0 - Math.Max((1.0 - 3) * 2.0, 0.85);
					break;
				}
				2 = Math.Max(0.0, Math.Min(1.0, 2));
				3 = Math.Max(0.0, Math.Min(1.0, 3));
				double num = this.1.2.2();
				int num2 = this.1.7(2, 3, 0.0, 0.0, 0.0);
				4 = (this.1.3 % 2 != 0 && num2 != 3 && num > 1.0 - 1);
				return num2;
			}

			// Token: 0x06003921 RID: 14625 RVA: 0x00168914 File Offset: 0x00166B14
			private void 10(1941.1951 1, int 2)
			{
				1.2(new 1941.1949
				{
					1 = 2,
					2 = this.2.2,
					3 = this.2.2
				});
			}

			// Token: 0x04002A50 RID: 10832
			private readonly 1941.1944 1;

			// Token: 0x04002A51 RID: 10833
			private readonly 1941.1954 2;

			// Token: 0x04002A52 RID: 10834
			private readonly 1941.1952 3;

			// Token: 0x04002A53 RID: 10835
			private readonly 1941.1951 4;

			// Token: 0x04002A54 RID: 10836
			public 1941.1952 5;
		}

		// Token: 0x020007A1 RID: 1953
		private sealed class 1946
		{
			// Token: 0x06003922 RID: 14626 RVA: 0x0016895C File Offset: 0x00166B5C
			public 1946(1941.1944 1, 1941.1954 2)
			{
				this.1 = 1;
				this.2 = 2;
				this.3 = 1.6;
				this.4 = 1941.1952.None;
				if (1941.4(this.1.1.10, this.2.2, 0.0) == 0.0)
				{
					this.4 = 1941.1952.LowProbability;
				}
				double num = 1941.4(this.1.1.8, this.2.2, (this.1.1.8.Count > 0) ? this.1.1.8[0].2 : 1000.0);
				double num2 = -100.0 / this.2.10;
				double num3 = (num2 < 0.0) ? ((double)Math.Max(10f, Math.Min(10000f, (float)(-(float)num2))) / 100.0) : 1.0;
				double num4 = num * num3;
				this.8 = this.2.8 + 1;
				this.5 = (int)Math.Round(this.2.2);
				double num5 = this.2.7;
				this.6 = (int)Math.Floor((double)this.5 + num5 * num4 * (double)this.8 * 0.01 / this.1.1.6);
				this.7 = (this.6 - this.5) / this.8;
			}

			// Token: 0x06003923 RID: 14627 RVA: 0x00168B06 File Offset: 0x00166D06
			private bool 1(1941.1952 1)
			{
				return (this.4 & 1) > 1941.1952.None;
			}

			// Token: 0x06003924 RID: 14628 RVA: 0x00168B14 File Offset: 0x00166D14
			public IEnumerable<1941.1951> 2()
			{
				1941.1951 <<EMPTY_NAME>> = this.3();
				if (<<EMPTY_NAME>>.1.Count == 1)
				{
					return new 1941.1951[]
					{
						<<EMPTY_NAME>>
					};
				}
				1941.1951 2 = new 1941.1951();
				1941.1951 3 = new 1941.1951();
				foreach (1941.1949 4 in <<EMPTY_NAME>>.1)
				{
					if (this.6 != (int)Math.Round(4.3))
					{
						2.2(4);
					}
					else
					{
						3.2(4);
					}
				}
				return new 1941.1951[]
				{
					2,
					3
				};
			}

			// Token: 0x06003925 RID: 14629 RVA: 0x00168BC4 File Offset: 0x00166DC4
			private 1941.1951 3()
			{
				if (this.1.3 == 1)
				{
					1941.1951 result = new 1941.1951();
					this.13(result, 0, this.5, this.6);
					return result;
				}
				if (this.8 > 1)
				{
					if (this.7 <= 90)
					{
						return this.4(this.5, 1);
					}
					if (this.7 <= 120)
					{
						this.4 |= 1941.1952.ForceNotStack;
						return this.5(this.5, this.8 + 1);
					}
					if (this.7 <= 160)
					{
						return this.6(this.5);
					}
					if (this.7 <= 200 && this.1.5 > 3.0)
					{
						return this.7(this.5);
					}
					if ((double)(this.6 - this.5) >= 4000.0)
					{
						return this.8(this.5, 0.23, 0.0, 0.0);
					}
					if (this.7 > 400 && this.8 < this.1.3 - 1 - this.1.4)
					{
						return this.10(this.5);
					}
					return this.11(this.5);
				}
				else
				{
					if (this.7 <= 110)
					{
						if (this.3.ColumnWithObjects < this.1.3)
						{
							this.4 |= 1941.1952.ForceNotStack;
						}
						else
						{
							this.4 &= ~1941.1952.ForceNotStack;
						}
						return this.5(this.5, (this.7 < 80) ? 1 : 2);
					}
					if (this.1.5 > 6.5)
					{
						if (!this.1(1941.1952.LowProbability))
						{
							return this.8(this.5, 0.85, 0.36, 0.03);
						}
						return this.8(this.5, 0.78, 0.3, 0.0);
					}
					else if (this.1.5 > 4.0)
					{
						if (!this.1(1941.1952.LowProbability))
						{
							return this.8(this.5, 0.56, 0.18, 0.0);
						}
						return this.8(this.5, 0.43, 0.08, 0.0);
					}
					else if (this.1.5 > 2.5)
					{
						if (!this.1(1941.1952.LowProbability))
						{
							return this.8(this.5, 0.37, 0.08, 0.0);
						}
						return this.8(this.5, 0.3, 0.0, 0.0);
					}
					else
					{
						if (!this.1(1941.1952.LowProbability))
						{
							return this.8(this.5, 0.27, 0.0, 0.0);
						}
						return this.8(this.5, 0.17, 0.0, 0.0);
					}
				}
			}

			// Token: 0x06003926 RID: 14630 RVA: 0x00168F20 File Offset: 0x00167120
			private 1941.1951 4(int 1, int 2)
			{
				1941.1951 3 = new 1941.1951();
				int num = this.1.3 - this.1.4 - this.3.ColumnWithObjects;
				int num2 = this.1.10(null, null);
				for (int i = 0; i < Math.Min(num, 2); i++)
				{
					num2 = this.1.9(num2, new 1941.1951[]
					{
						3,
						this.3
					});
					this.13(3, num2, 1, this.6);
				}
				for (int j = 0; j < 2 - num; j++)
				{
					num2 = this.1.9(num2, new 1941.1951[]
					{
						3
					});
					this.13(3, num2, 1, this.6);
				}
				return 3;
			}

			// Token: 0x06003927 RID: 14631 RVA: 0x00168FF4 File Offset: 0x001671F4
			private 1941.1951 5(int 1, int 2)
			{
				1941.1951 result = new 1941.1951();
				int num = this.1.6(this.2.3, true);
				if (this.1(1941.1952.ForceNotStack) && this.3.ColumnWithObjects < this.1.3)
				{
					num = this.1.9(num, new 1941.1951[]
					{
						this.3
					});
				}
				int previous2 = num;
				for (int i = 0; i < 2; i++)
				{
					this.13(result, num, 3, 3);
					int previous = previous2;
					num = this.1.8(num, null, null, null, (int 1) => 1 != previous, Array.Empty<1941.1951>());
					previous2 = num;
					3 += this.7;
				}
				return result;
			}

			// Token: 0x06003928 RID: 14632 RVA: 0x001690C4 File Offset: 0x001672C4
			private 1941.1951 6(int 1)
			{
				1941.1951 result = new 1941.1951();
				int num = this.1.6(this.2.3, true);
				bool flag = this.1.2.2() > 0.5;
				for (int i = 0; i <= this.8; i++)
				{
					this.13(result, num, 1, 1);
					1 += this.7;
					if (flag)
					{
						if (num >= this.1.3 - 1)
						{
							flag = false;
							num--;
						}
						else
						{
							num++;
						}
					}
					else if (num <= this.1.4)
					{
						flag = true;
						num++;
					}
					else
					{
						num--;
					}
				}
				return result;
			}

			// Token: 0x06003929 RID: 14633 RVA: 0x0016916C File Offset: 0x0016736C
			private 1941.1951 7(int 1)
			{
				1941.1951 result = new 1941.1951();
				bool flag = this.1.3 >= 4 && this.1.3 <= 8;
				int num = this.1.2.Next(1, this.1.3 - ((flag > false) ? 1 : 0));
				int num2 = this.1.6(this.2.3, true);
				for (int i = 0; i <= this.8; i++)
				{
					this.13(result, num2, 1, 1);
					num2 += num;
					if (num2 >= this.1.3 - this.1.4)
					{
						num2 = num2 - this.1.3 - this.1.4 + ((flag > false) ? 1 : 0);
					}
					num2 += this.1.4;
					if (this.1.3 > 2)
					{
						this.13(result, num2, 1, 1);
					}
					num2 = this.1.10(null, null);
					1 += this.7;
				}
				return result;
			}

			// Token: 0x0600392A RID: 14634 RVA: 0x00169290 File Offset: 0x00167490
			private 1941.1951 8(int 1, double 2, double 3, double 4)
			{
				switch (this.1.3)
				{
				case 2:
					2 = 0.0;
					3 = 0.0;
					4 = 0.0;
					break;
				case 3:
					2 = Math.Min(2, 0.1);
					3 = 0.0;
					4 = 0.0;
					break;
				case 4:
					2 = Math.Min(2, 0.3);
					3 = Math.Min(3, 0.04);
					4 = 0.0;
					break;
				case 5:
					2 = Math.Min(2, 0.34);
					3 = Math.Min(3, 0.1);
					4 = Math.Min(4, 0.03);
					break;
				}
				if (!this.1(1941.1952.LowProbability) & (1941.1944.1946.9(this.2.5) || 1941.1944.1946.9(this.12(this.5))))
				{
					2 = 1.0;
				}
				return this.4(1, this.1.7(2, 3, 4, 0.0, 0.0));
			}

			// Token: 0x0600392B RID: 14635 RVA: 0x001693DE File Offset: 0x001675DE
			private static bool 9(int 1)
			{
				return 1941.1944.11(1, 8) || 1941.1944.11(1, 4);
			}

			// Token: 0x0600392C RID: 14636 RVA: 0x001693F4 File Offset: 0x001675F4
			private 1941.1951 10(int 1)
			{
				1941.1951 2 = new 1941.1951();
				int num = Math.Min(this.8, this.1.3);
				int num2 = 1 + this.7 * this.8;
				int num3 = this.1.6(this.2.3, true);
				if (this.1(1941.1952.ForceNotStack) && this.3.ColumnWithObjects < this.1.3)
				{
					num3 = this.1.9(num3, new 1941.1951[]
					{
						this.3
					});
				}
				for (int i = 0; i < num; i++)
				{
					num3 = this.1.9(num3, new 1941.1951[]
					{
						2
					});
					this.13(2, num3, 1, num2);
					1 += this.7;
				}
				return 2;
			}

			// Token: 0x0600392D RID: 14637 RVA: 0x001694C0 File Offset: 0x001676C0
			private 1941.1951 11(int 1)
			{
				1941.1951 2 = new 1941.1951();
				int holdColumn = this.1.6(this.2.3, true);
				if (this.1(1941.1952.ForceNotStack) && this.3.ColumnWithObjects < this.1.3)
				{
					holdColumn = this.1.9(holdColumn, new 1941.1951[]
					{
						this.3
					});
				}
				this.13(2, holdColumn, 5, this.6);
				int num = this.1.10(null, null);
				int num2;
				if (this.1.5 > 6.5)
				{
					num2 = this.1.7(0.63, 0.0, 0.0, 0.0, 0.0);
				}
				else if (this.1.5 > 4.0)
				{
					num2 = this.1.7((this.1.3 < 6) ? 0.12 : 0.45, 0.0, 0.0, 0.0, 0.0);
				}
				else if (this.1.5 > 2.5)
				{
					num2 = this.1.7((this.1.3 < 6) ? 0.0 : 0.24, 0.0, 0.0, 0.0, 0.0);
				}
				else
				{
					num2 = 0;
				}
				num2 = Math.Min(this.1.3 - 1, num2);
				int num3 = this.12(5);
				bool flag = !1941.1944.11(num3, 2) && !1941.1944.11(num3, 4) && !1941.1944.11(num3, 8);
				1941.1951 3 = new 1941.1951();
				Func<int, bool> <>9__0;
				for (int i = 0; i <= this.8; i++)
				{
					if (!flag || 5 != this.5)
					{
						for (int j = 0; j < num2; j++)
						{
							1941.1944 4 = this.1;
							int num4 = num;
							int? num5 = null;
							int? num6 = null;
							Func<int, int> func = null;
							Func<int, bool> func2;
							if ((func2 = <>9__0) == null)
							{
								func2 = (<>9__0 = ((int 1) => 1 != holdColumn));
							}
							num = 4.8(num4, num5, num6, func, func2, new 1941.1951[]
							{
								3
							});
							this.13(3, num, 5, 5);
						}
					}
					2.3(3);
					3.4();
					5 += this.7;
				}
				return 2;
			}

			// Token: 0x0600392E RID: 14638 RVA: 0x00169790 File Offset: 0x00167990
			private int 12(int 1)
			{
				int num = (this.7 == 0) ? 0 : ((1 - this.5) / this.7);
				List<int> list = this.2.6;
				if (list == null)
				{
					return this.2.5;
				}
				if (num < 0 || num >= list.Count)
				{
					throw new InvalidOperationException();
				}
				return list[num];
			}

			// Token: 0x0600392F RID: 14639 RVA: 0x001697F0 File Offset: 0x001679F0
			private void 13(1941.1951 1, int 2, int 3, int 4)
			{
				1.2(new 1941.1949
				{
					1 = 2,
					2 = (double)3,
					3 = (double)4
				});
			}

			// Token: 0x04002A55 RID: 10837
			private readonly 1941.1944 1;

			// Token: 0x04002A56 RID: 10838
			private readonly 1941.1954 2;

			// Token: 0x04002A57 RID: 10839
			private readonly 1941.1951 3;

			// Token: 0x04002A58 RID: 10840
			private 1941.1952 4;

			// Token: 0x04002A59 RID: 10841
			public readonly int 5;

			// Token: 0x04002A5A RID: 10842
			public readonly int 6;

			// Token: 0x04002A5B RID: 10843
			public readonly int 7;

			// Token: 0x04002A5C RID: 10844
			public readonly int 8;
		}
	}

	// Token: 0x020007A7 RID: 1959
	private sealed class 1947
	{
		// Token: 0x0600393A RID: 14650 RVA: 0x001698C8 File Offset: 0x00167AC8
		public 1947(int 1)
		{
			this.3 = (uint)1;
		}

		// Token: 0x0600393B RID: 14651 RVA: 0x001698F8 File Offset: 0x00167AF8
		private uint 1()
		{
			uint num = this.3 ^ this.3 << 11;
			this.3 = this.4;
			this.4 = this.5;
			this.5 = this.6;
			return this.6 = (this.6 ^ this.6 >> 19 ^ num ^ num >> 8);
		}

		// Token: 0x0600393C RID: 14652 RVA: 0x00169959 File Offset: 0x00167B59
		private int Next()
		{
			return (int)(2147483647U & this.1());
		}

		// Token: 0x0600393D RID: 14653 RVA: 0x00169967 File Offset: 0x00167B67
		public int Next(int 1, int 2)
		{
			return (int)((double)1 + this.2() * (double)(2 - 1));
		}

		// Token: 0x0600393E RID: 14654 RVA: 0x00169978 File Offset: 0x00167B78
		public double 2()
		{
			return 4.656612873077393E-10 * (double)this.Next();
		}

		// Token: 0x04002A69 RID: 10857
		private const double 1 = 4.656612873077393E-10;

		// Token: 0x04002A6A RID: 10858
		private const uint 2 = 2147483647U;

		// Token: 0x04002A6B RID: 10859
		private uint 3;

		// Token: 0x04002A6C RID: 10860
		private uint 4 = 842502087U;

		// Token: 0x04002A6D RID: 10861
		private uint 5 = 3579807591U;

		// Token: 0x04002A6E RID: 10862
		private uint 6 = 273326509U;
	}
}
