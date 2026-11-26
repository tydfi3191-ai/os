using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x020006F2 RID: 1778
public sealed class 2171 : 1920
{
	// Token: 0x060034A5 RID: 13477 RVA: 0x00143B44 File Offset: 0x00141D44
	public 2171(1262 1) : base(1)
	{
	}

	// Token: 0x060034A6 RID: 13478 RVA: 0x0001702D File Offset: 0x0001522D
	protected override 2147 GetPlayMode()
	{
		return 2147.Taiko;
	}

	// Token: 0x060034A7 RID: 13479 RVA: 0x00143B4D File Offset: 0x00141D4D
	public override 1898[] GetModOptions()
	{
		return new 1898[]
		{
			new 1913(2023.DoubleTime),
			new 1913(2023.HalfTime),
			new 1913(2023.HardRock),
			new 1913(2023.Easy)
		};
	}

	// Token: 0x060034A8 RID: 13480 RVA: 0x00143B7F File Offset: 0x00141D7F
	public static 2023 17()
	{
		return 2023.Easy | 2023.HardRock | 2023.DoubleTime | 2023.HalfTime;
	}

	// Token: 0x060034A9 RID: 13481 RVA: 0x00143B86 File Offset: 0x00141D86
	internal override 2039 CreateHitObjectManager()
	{
		return new 2184(false);
	}

	// Token: 0x060034AA RID: 13482 RVA: 0x00143B90 File Offset: 0x00141D90
	protected override double Calculate(Dictionary<string, string> 1)
	{
		2170 2 = (2170)base.16();
		if (1 != null)
		{
			1.Add("Strain", 2.3.ToString("0.00", 1662.18));
			1.Add("Hit window 300", ((double)this.2.5 / this.4).ToString("0.00", 1662.18));
		}
		return 2.3;
	}

	// Token: 0x060034AB RID: 13483 RVA: 0x00143C04 File Offset: 0x00141E04
	protected override 1914[] CreateSkills(2023 1)
	{
		this.16 = (this.1.3() == 2147.Osu);
		this.15 = ((1 & 2023.Relax) > 2023.None);
		double num = Math.Floor(this.2.GetDifficultyRange((double)this.2.16(1928.OverallDifficulty, this.1.4), 50.0, 35.0, 20.0)) - 0.5;
		this.17 = num / this.4;
		return new 1914[]
		{
			new 2166(1, 2.0 * num / this.4),
			new 2168(1),
			new 2165(1),
			new 2167(1, false, this.16),
			new 2167(1, true, this.16)
		};
	}

	// Token: 0x060034AC RID: 13484 RVA: 0x00143CE4 File Offset: 0x00141EE4
	protected override IEnumerable<1896> CreateDifficultyHitObjects()
	{
		List<1896> list = new List<1896>();
		List<1919> <<EMPTY_NAME>> = new List<1919>();
		List<1919> 2 = new List<1919>();
		List<1919> list2 = new List<1919>();
		double num = this.2.21.5 / 1.399999976158142;
		if ((this.2.22 & 2023.Easy) > 2023.None)
		{
			num *= 0.8;
		}
		else if ((this.2.22 & 2023.HardRock) > 2023.None)
		{
			num *= 1.8666666666666665;
		}
		Func<double, double> 3 = (this.2.21.3() == 2147.Osu) ? new Func<double, double>(new 2156(this.2.21).1) : null;
		List<2034> list3 = (from 1 in this.3
		orderby 1.DifficultyStartTime
		select 1).ToList<2034>();
		double 4 = (double)((this.2.21.32 < 5) ? 24 : 0);
		for (int i = 2; i < list3.Count; i++)
		{
			list.Add(new 1919(list3[i], list3[i - 1], this.4, list, <<EMPTY_NAME>>, 2, list2, list.Count, this.2, num, 3, 4));
		}
		2157.1(list);
		2160.1(list2);
		this.20 = list.Count;
		return list;
	}

	// Token: 0x060034AD RID: 13485 RVA: 0x00143E58 File Offset: 0x00142058
	protected override 1890 CreateDifficultyAttributes(1914[] 1)
	{
		return this.18 = this.18(1);
	}

	// Token: 0x060034AE RID: 13486 RVA: 0x00143E78 File Offset: 0x00142078
	protected override void OnObjectProcessed(1896 1, 1914[] 2)
	{
		if (this.19 == null)
		{
			return;
		}
		int num = Math.Max(1, this.20 / 400);
		if (1.8 % num != 0 && 1.8 != this.20 - 1)
		{
			return;
		}
		base.11();
		2170 3 = this.18(2);
		3.2 = null;
		this.19.Add(new KeyValuePair<double, 2170>((double)1.2.2, 3));
	}

	// Token: 0x060034AF RID: 13487 RVA: 0x00143EF0 File Offset: 0x001420F0
	private 2170 18(1914[] 1)
	{
		if (this.3.Count == 0)
		{
			return new 2170
			{
				1 = this.2.22,
				2 = 11
			};
		}
		2166 2 = 11.OfType<2166>().Single<2166>();
		2168 3 = 11.OfType<2168>().Single<2168>();
		2165 4 = 11.OfType<2165>().Single<2165>();
		2167 5 = 11.OfType<2167>().Single(new Func<2167, bool>(2171.2172.instance.1));
		1914 6 = 11.OfType<2167>().Single((2167 1) => 1.6);
		double num = 5.DifficultyValue();
		double num2 = 2.DifficultyValue() * 0.06496875;
		double num3 = 3.DifficultyValue() * 0.0084375;
		double num4 = 4.DifficultyValue() * 0.031640625000000006;
		double num5 = num * 0.037546875;
		double num6 = 6.DifficultyValue() * 0.037546875;
		double 7 = (num5 == 0.0) ? 1.0 : 1897.12(num6 / num5, 5);
		double 8 = 5.3(num);
		this.14 = 1897.11(num5 * num4, 0.1);
		this.13 = 1.0 + 0.15 * 1897.10(8, 1000.0, 1555.0);
		double 9;
		double num7 = 2171.21(this.19(2, 3, 4, 5, out 9) * 1.4);
		double num8 = num7 / (num2 + num3 + num4 + num5);
		2170 10 = new 2170();
		10.3 = num7;
		10.1 = this.2.22;
		10.4 = num2 * num8;
		10.5 = num3 * num8;
		10.6 = num4 * num8;
		10.7 = num5 * num8;
		10.8 = 7;
		10.9 = 9;
		10.10 = this.17;
		10.12 = this.16;
		10.11 = this.3.Count((2034 1) => 1 is 2181);
		return 10;
	}

	// Token: 0x060034B0 RID: 13488 RVA: 0x00144144 File Offset: 0x00142344
	private double 19(2166 1, 2168 2, 2165 3, 2167 4, out double 5)
	{
		List<double> list = this.20(1.6().ToList<double>(), 2.6().ToList<double>(), 3.6().ToList<double>(), 4.6().ToList<double>());
		if (list.Count == 0)
		{
			5 = 0.0;
			return 0.0;
		}
		double num = 0.0;
		double num2 = 1.0;
		foreach (double num3 in list.OrderByDescending(new Func<double, double>(2171.2172.instance.2)))
		{
			num += num3 * num2;
			num2 *= 0.9;
		}
		List<double> list2 = this.20(1.2(), 2.2(), 3.2(), 4.2());
		if (list2.Count == 0)
		{
			5 = 0.0;
			return 0.0;
		}
		double num4 = list2.OrderByDescending(new Func<double, double>(2171.2172.instance.2)).Take(1 + list2.Count / 20).Average();
		5 = list2.Sum() / (num4 * (double)list2.Count);
		return num;
	}

	// Token: 0x060034B1 RID: 13489 RVA: 0x0014429C File Offset: 0x0014249C
	private List<double> 20(IReadOnlyList<double> 1, IReadOnlyList<double> 2, IReadOnlyList<double> 3, IReadOnlyList<double> 4)
	{
		List<double> list = new List<double>();
		for (int i = 0; i < 3.Count; i++)
		{
			double num = 1[i] * 0.06496875 * this.14;
			double num2 = 2[i] * 0.0084375;
			double num3 = this.15 ? 0.0 : (3[i] * 0.031640625000000006);
			double num4 = 4[i] * 0.037546875 * this.13;
			num4 /= ((this.16 || this.15) ? 1.5 : 1.0);
			double num5 = 1897.5(2.0, new double[]
			{
				1897.5(1.5, new double[]
				{
					num3,
					num4
				}),
				num,
				num2
			});
			if (num5 > 0.0)
			{
				list.Add(num5);
			}
		}
		return list;
	}

	// Token: 0x060034B2 RID: 13490 RVA: 0x001443B0 File Offset: 0x001425B0
	private static double 21(double 1)
	{
		if (1 < 0.0)
		{
			return 1;
		}
		return 10.43 * Math.Log(1 / 8.0 + 1.0);
	}

	// Token: 0x04002719 RID: 10009
	private new double 13;

	// Token: 0x0400271A RID: 10010
	private new double 14;

	// Token: 0x0400271B RID: 10011
	private new bool 15;

	// Token: 0x0400271C RID: 10012
	private new bool 16;

	// Token: 0x0400271D RID: 10013
	private double 17;

	// Token: 0x0400271E RID: 10014
	internal 2170 18;

	// Token: 0x0400271F RID: 10015
	internal List<KeyValuePair<double, 2170>> 19;

	// Token: 0x04002720 RID: 10016
	private int 20;

	// Token: 0x04002721 RID: 10017
	private const double 21 = 0.06496875;

	// Token: 0x04002722 RID: 10018
	private const double 22 = 0.0084375;

	// Token: 0x04002723 RID: 10019
	private const double 23 = 0.031640625000000006;

	// Token: 0x04002724 RID: 10020
	private const double 24 = 0.037546875;

	// Token: 0x020006F3 RID: 1779
	[Serializable]
	public sealed class 2172
	{
		// Token: 0x060034B3 RID: 13491 RVA: 0x001443E4 File Offset: 0x001425E4
		internal bool 1(2167 1)
		{
			return !1.6;
		}

		// Token: 0x060034B4 RID: 13492 RVA: 0x00022391 File Offset: 0x00020591
		internal double 2(double 1)
		{
			return 1;
		}

		// Token: 0x04002725 RID: 10021
		public static readonly 2171.2172 instance = new 2171.2172();

		// Token: 0x04002726 RID: 10022
		public static Func<2167, bool> func;

		// Token: 0x04002727 RID: 10023
		public static Func<double, double> func2;
	}
}
