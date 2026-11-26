using System;
using System.Linq;

// Token: 0x0200074E RID: 1870
[276]
public sealed class 2105 : 1916
{
	// Token: 0x060036F9 RID: 14073 RVA: 0x00158E86 File Offset: 0x00157086
	public 2105(2023 1, int 2) : base(1)
	{
		this.6 = 2;
		this.7 = ((1 & 2023.Hidden) > 2023.None);
	}

	// Token: 0x060036FA RID: 14074 RVA: 0x00158EA2 File Offset: 0x001570A2
	private double 7(double 1)
	{
		return 1897.11(0.15, 1 / 1000.0);
	}

	// Token: 0x060036FB RID: 14075 RVA: 0x00158EBD File Offset: 0x001570BD
	protected override double CalculateInitialStrain(double 1, 1896 2)
	{
		return this.8 * this.7(1 - 2.1(0).5);
	}

	// Token: 0x060036FC RID: 14076 RVA: 0x00158EDC File Offset: 0x001570DC
	protected override double StrainValueOf(1896 1)
	{
		if ((this.1 & 2023.Flashlight) == 2023.None)
		{
			return 0.0;
		}
		this.8 *= this.7(1.4);
		this.8 += this.8(1) * 0.058;
		return this.8;
	}

	// Token: 0x060036FD RID: 14077 RVA: 0x00158F40 File Offset: 0x00157140
	private double 8(1896 1)
	{
		double num = 2089.1(1, this.7);
		if ((this.1 & 2023.TouchDevice) > 2023.None)
		{
			num = 1897.11(num, 0.9);
		}
		if ((this.1 & 2023.Relax) > 2023.None)
		{
			num *= 0.7;
		}
		if ((this.1 & 2023.Relax2) > 2023.None)
		{
			num *= 0.4;
		}
		return num * (0.985 + 1897.12(Math.Max(0.0, ((2095)1).34()), 2) / 4000.0);
	}

	// Token: 0x060036FE RID: 14078 RVA: 0x00158FE0 File Offset: 0x001571E0
	public override double DifficultyValue()
	{
		return base.6().Sum() * (0.7 + 0.1 * Math.Min(1.0, (double)this.6 / 200.0) + ((this.6 > 200) ? (0.2 * Math.Min(1.0, (double)(this.6 - 200) / 200.0)) : 0.0));
	}

	// Token: 0x060036FF RID: 14079 RVA: 0x00159074 File Offset: 0x00157274
	public static double 9(double 1)
	{
		return 25.0 * 1897.12(1, 2);
	}

	// Token: 0x040028E9 RID: 10473
	private new readonly int 6;

	// Token: 0x040028EA RID: 10474
	private readonly bool 7;

	// Token: 0x040028EB RID: 10475
	private double 8;
}
