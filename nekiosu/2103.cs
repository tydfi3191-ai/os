using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x0200074B RID: 1867
[276]
public sealed class 2103 : 2108
{
	// Token: 0x060036E8 RID: 14056 RVA: 0x0015884B File Offset: 0x00156A4B
	public 2103(2023 1, bool 2) : base(1, 0.9, 400)
	{
		this.12 = 2;
	}

	// Token: 0x060036E9 RID: 14057 RVA: 0x00158874 File Offset: 0x00156A74
	private double 8(double 1)
	{
		return 1897.11(0.2, 1 / 1000.0);
	}

	// Token: 0x060036EA RID: 14058 RVA: 0x0015888F File Offset: 0x00156A8F
	protected override double CalculateInitialStrain(double 1, 1896 2)
	{
		return this.13 * this.8(1 - 2.1(0).5);
	}

	// Token: 0x060036EB RID: 14059 RVA: 0x001588AC File Offset: 0x00156AAC
	protected override double StrainValueOf(1896 1)
	{
		if ((this.1 & 2023.Relax2) > 2023.None)
		{
			return 0.0;
		}
		double num = this.8(((2095)1).9);
		this.13 *= num;
		this.13 += this.11(1) * (1.0 - num);
		if (1.2 is 2123)
		{
			this.14.Add(this.13);
		}
		return this.13;
	}

	// Token: 0x060036EC RID: 14060 RVA: 0x00158938 File Offset: 0x00156B38
	public double 9()
	{
		if (this.14.Count == 0)
		{
			return 0.0;
		}
		double num = this.14.Max();
		if (num == 0.0)
		{
			return 0.0;
		}
		double num2 = 0.0;
		foreach (double num3 in this.14)
		{
			num2 += 1897.3(num3 / num, 0.5, 12.0, 1.0);
		}
		return num2;
	}

	// Token: 0x060036ED RID: 14061 RVA: 0x001589F0 File Offset: 0x00156BF0
	public double 10(double 1)
	{
		if (this.14.Count == 0)
		{
			return 0.0;
		}
		double num = 1 * (1.0 - this.3);
		if (num == 0.0)
		{
			return 0.0;
		}
		double num2 = 0.0;
		foreach (double num3 in this.14)
		{
			num2 += 1897.3(num3 / num, 0.88, 10.0, 1.1);
		}
		return num2;
	}

	// Token: 0x060036EE RID: 14062 RVA: 0x00158AB0 File Offset: 0x00156CB0
	private double 11(1896 1)
	{
		double 2 = 2073.1(1, this.12) * 70.9;
		double 3 = 2113.1(1) * 2.35;
		double 4 = 2074.1(1, this.12) * 242.0;
		return this.12(2, 3, 4) * (0.985 + 1897.12(Math.Max(0.0, ((2095)1).34()), 2) / 4000.0);
	}

	// Token: 0x060036EF RID: 14063 RVA: 0x00158B3C File Offset: 0x00156D3C
	public override double DifficultyValue()
	{
		double num = 0.0;
		double num2 = 0.0;
		foreach (2108.2110 <<EMPTY_NAME>> in this.14())
		{
			double 2 = num2;
			double num3 = num2 + <<EMPTY_NAME>>.2() / (double)this.4;
			double num4 = 1897.11(this.3, 2) - 1897.11(this.3, num3);
			num += <<EMPTY_NAME>>.1() * num4;
			num2 = num3;
		}
		return num / (1.0 - this.3);
	}

	// Token: 0x060036F0 RID: 14064 RVA: 0x00158BEC File Offset: 0x00156DEC
	private double 12(double 1, double 2, double 3)
	{
		double num = 1897.5(1.2, new double[]
		{
			1,
			2
		});
		double num2 = 2103.13(3 / num);
		double num3 = 1.0 - num2;
		if ((this.1 & 2023.TouchDevice) > 2023.None)
		{
			1 = 1897.11(1, 0.89);
			num = 1897.5(1.2, new double[]
			{
				1,
				2
			});
		}
		if ((this.1 & 2023.Relax) > 2023.None)
		{
			num *= 0.75;
			3 *= 0.6;
		}
		return (num * num2 + 3 * num3) * 1.12;
	}

	// Token: 0x060036F1 RID: 14065 RVA: 0x00158CA0 File Offset: 0x00156EA0
	private static double 13(double 1)
	{
		if (1 == 0.0)
		{
			return 0.0;
		}
		if (double.IsNaN(1))
		{
			return 1.0;
		}
		return 1897.4(-7.27 * Math.Log(1), 1.0);
	}

	// Token: 0x060036F2 RID: 14066 RVA: 0x00158CF4 File Offset: 0x00156EF4
	private IEnumerable<2108.2110> 14()
	{
		List<2108.2110> list = base.7().Where(new Func<2108.2110, bool>(2103.2104.instance.1)).ToList<2108.2110>();
		double num = 0.0;
		int num2 = 0;
		while (list.Count > num2 && num < 4000.0)
		{
			2108.2110 <<EMPTY_NAME>> = list[num2];
			for (double num3 = 0.0; num3 < <<EMPTY_NAME>>.2(); num3 += 20.0)
			{
				double 2 = Math.Log10(1052.17(1.0, 10.0, 1052.20((num + num3) / 4000.0, 0.0, 1.0)));
				list.Add(new 2108.2110(<<EMPTY_NAME>>.1() * 1052.17(0.727, 1.0, 2), Math.Min(20.0, <<EMPTY_NAME>>.2() - num3)));
			}
			num += <<EMPTY_NAME>>.2();
			num2++;
		}
		return list.Skip(num2).OrderByDescending(delegate(2108.2110 1)
		{
			2108.2110 3 = 1;
			return 3.1();
		});
	}

	// Token: 0x040028E1 RID: 10465
	public readonly bool 12;

	// Token: 0x040028E2 RID: 10466
	private double 13;

	// Token: 0x040028E3 RID: 10467
	private readonly List<double> 14 = new List<double>();

	// Token: 0x0200074C RID: 1868
	[276]
	[Serializable]
	public sealed class 2104
	{
		// Token: 0x060036F3 RID: 14067 RVA: 0x00158E42 File Offset: 0x00157042
		internal bool 1(2108.2110 1)
		{
			return 1.1() > 0.0;
		}

		// Token: 0x040028E4 RID: 10468
		public static readonly 2103.2104 instance = new 2103.2104();

		// Token: 0x040028E5 RID: 10469
		public static Func<2108.2110, bool> func;

		// Token: 0x040028E6 RID: 10470
		public static Func<2108.2110, double> func2;
	}
}
