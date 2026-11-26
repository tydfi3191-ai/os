using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x0200074F RID: 1871
[276]
public sealed class 2106 : 2090
{
	// Token: 0x06003700 RID: 14080 RVA: 0x00159087 File Offset: 0x00157287
	public 2106(2023 1) : base(1)
	{
		this.5 = ((this.1 & 2023.Hidden) > 2023.None);
	}

	// Token: 0x06003701 RID: 14081 RVA: 0x001590AC File Offset: 0x001572AC
	private double 5(double 1)
	{
		return 1897.11(0.8, 1 / 1000.0);
	}

	// Token: 0x06003702 RID: 14082 RVA: 0x001590C8 File Offset: 0x001572C8
	protected override double CalculateObjectStrain(1896 1)
	{
		this.4.Add(1);
		double num = this.5(1.4);
		this.6 *= num;
		this.6 += this.6(1) * (1.0 - num) * 2.5;
		return this.6;
	}

	// Token: 0x06003703 RID: 14083 RVA: 0x0015912C File Offset: 0x0015732C
	private double 6(1896 1)
	{
		double num = 2075.1(1, this.5);
		if ((this.1 & 2023.TouchDevice) > 2023.None)
		{
			num = 1897.11(num, 0.89);
		}
		if ((this.1 & 2023.Relax) > 2023.None)
		{
			num *= 0.4;
		}
		if ((this.1 & 2023.Relax2) > 2023.None)
		{
			num *= 0.1;
		}
		return num * (0.825 + 1897.11(Math.Max(0.0, ((2095)1).34()), 2.2) / 1125.0);
	}

	// Token: 0x06003704 RID: 14084 RVA: 0x001591D4 File Offset: 0x001573D4
	protected override List<double> PreprocessValues(List<double> 1)
	{
		3 = (from 1 in 3
		where 1 > 0.0
		select 1).ToList<double>();
		int num = this.7();
		for (int i = 0; i < Math.Min(3.Count, num); i++)
		{
			double 2 = Math.Log10(1052.17(1.0, 10.0, 1052.20((double)i / (double)num, 0.0, 1.0)));
			List<double> list = 3;
			int index = i;
			list[index] *= 1052.17(0.0, 1.0, 2);
		}
		return 3;
	}

	// Token: 0x06003705 RID: 14085 RVA: 0x00159293 File Offset: 0x00157493
	public override double CountTopWeightedObjectDifficulties(double 1)
	{
		return base.3(this.2, 1, 1.15, 5.0);
	}

	// Token: 0x06003706 RID: 14086 RVA: 0x001592B4 File Offset: 0x001574B4
	private int 7()
	{
		if (this.4.Count == 0)
		{
			return 0;
		}
		double num = this.4.First<1896>().5 + 60000.0;
		int num2 = 0;
		using (List<1896>.Enumerator enumerator = this.4.GetEnumerator())
		{
			while (enumerator.MoveNext() && enumerator.Current.5 <= num)
			{
				num2++;
			}
		}
		return num2;
	}

	// Token: 0x040028EC RID: 10476
	private new readonly List<1896> 4 = new List<1896>();

	// Token: 0x040028ED RID: 10477
	private readonly bool 5;

	// Token: 0x040028EE RID: 10478
	private double 6;

	// Token: 0x02000750 RID: 1872
	[276]
	[Serializable]
	public sealed class 2107
	{
		// Token: 0x040028EF RID: 10479
		public static readonly 2106.2107 instance = new 2106.2107();

		// Token: 0x040028F0 RID: 10480
		public static Func<double, bool> func;
	}
}
