using System;
using System.Collections.Generic;

// Token: 0x02000752 RID: 1874
[276]
public abstract class 2108 : 1914
{
	// Token: 0x0600370C RID: 14092 RVA: 0x00159350 File Offset: 0x00157550
	protected 2108(2023 1, double 2 = 0.9, int 3 = 400) : base(1)
	{
		this.3 = 2;
		this.4 = 3;
		this.8 = 11.0 / (1.0 - this.3);
	}

	// Token: 0x0600370D RID: 14093
	protected abstract double StrainValueOf(1896 1);

	// Token: 0x0600370E RID: 14094 RVA: 0x001593A8 File Offset: 0x001575A8
	protected sealed override double StrainValueAt(1896 1)
	{
		if (1.8 == 0)
		{
			this.6 = 1.5;
			this.7 = this.6 + (double)this.4;
			this.5 = this.StrainValueOf(1);
			return this.5;
		}
		this.3(1);
		double num = this.StrainValueOf(1);
		if (num > this.5)
		{
			this.11.Clear();
			this.4(1.5 - this.6);
			this.6 = 1.5;
			this.7 = this.6 + (double)this.4;
			this.5 = num;
		}
		else
		{
			while (this.11.Count > 0 && this.11[this.11.Count - 1].1 < num)
			{
				this.11.RemoveAt(this.11.Count - 1);
			}
			this.11.Add(new 2108.2109(num, 1.5));
		}
		return num;
	}

	// Token: 0x0600370F RID: 14095 RVA: 0x001594B0 File Offset: 0x001576B0
	private void 3(1896 1)
	{
		while (1.5 > this.7)
		{
			this.4(this.7 - this.6);
			this.6 = this.7;
			if (this.11.Count > 0)
			{
				2108.2109 2 = this.11[0];
				this.11.RemoveAt(0);
				this.7 = 2.2 + (double)this.4;
				this.5(this.6, 1);
				this.5 = Math.Max(this.5, 2.1);
			}
			else
			{
				this.7 = this.6 + (double)this.4;
				this.5(this.6, 1);
			}
		}
	}

	// Token: 0x06003710 RID: 14096 RVA: 0x00159574 File Offset: 0x00157774
	private void 4(double 1)
	{
		this.9.Method11157(new 2108.2110(this.5, 1));
		this.10 += 1;
		while (this.10 > this.8 * (double)this.4)
		{
			this.10 -= this.9[this.9.Count - 1].2();
			this.9.RemoveAt(this.9.Count - 1);
		}
	}

	// Token: 0x06003711 RID: 14097 RVA: 0x00159604 File Offset: 0x00157804
	private void 5(double 1, 1896 2)
	{
		this.5 = this.CalculateInitialStrain(1, 2);
	}

	// Token: 0x06003712 RID: 14098
	protected abstract double CalculateInitialStrain(double 1, 1896 2);

	// Token: 0x06003713 RID: 14099 RVA: 0x00159614 File Offset: 0x00157814
	public double 6(double 1)
	{
		if (this.2.Count == 0)
		{
			return 0.0;
		}
		double num = 1 * (1.0 - this.3);
		if (num == 0.0)
		{
			return (double)this.2.Count;
		}
		double num2 = 0.0;
		foreach (double num3 in this.2)
		{
			num2 += 1897.3(num3 / num, 0.88, 10.0, 1.1);
		}
		return num2;
	}

	// Token: 0x06003714 RID: 14100 RVA: 0x001596D4 File Offset: 0x001578D4
	public IEnumerable<2108.2110> 7()
	{
		List<2108.2110> collection = new List<2108.2110>(this.9);
		double num = this.10;
		this.4(this.7 - this.6);
		IEnumerable<2108.2110> result = new List<2108.2110>(this.9);
		this.9.Clear();
		this.9.AddRange(collection);
		this.10 = num;
		return result;
	}

	// Token: 0x040028F3 RID: 10483
	protected readonly double 3;

	// Token: 0x040028F4 RID: 10484
	protected readonly int 4;

	// Token: 0x040028F5 RID: 10485
	private double 5;

	// Token: 0x040028F6 RID: 10486
	private double 6;

	// Token: 0x040028F7 RID: 10487
	private double 7;

	// Token: 0x040028F8 RID: 10488
	private readonly double 8;

	// Token: 0x040028F9 RID: 10489
	private readonly List<2108.2110> 9 = new List<2108.2110>();

	// Token: 0x040028FA RID: 10490
	private double 10;

	// Token: 0x040028FB RID: 10491
	private readonly List<2108.2109> 11 = new List<2108.2109>();

	// Token: 0x02000753 RID: 1875
	[107]
	[276]
	public struct 2110 : IComparable<2108.2110>
	{
		// Token: 0x06003715 RID: 14101 RVA: 0x00159730 File Offset: 0x00157930
		public 2110(double 1, double 2)
		{
			this.1 = 1;
			this.2 = Math.Round(2);
		}

		// Token: 0x06003716 RID: 14102 RVA: 0x00159745 File Offset: 0x00157945
		public double 1()
		{
			return this.1;
		}

		// Token: 0x06003717 RID: 14103 RVA: 0x0015974D File Offset: 0x0015794D
		public double 2()
		{
			return this.2;
		}

		// Token: 0x06003718 RID: 14104 RVA: 0x00159758 File Offset: 0x00157958
		public int CompareTo(2108.2110 1)
		{
			return 1.1().CompareTo(this.1());
		}

		// Token: 0x040028FC RID: 10492
		private readonly double 1;

		// Token: 0x040028FD RID: 10493
		private readonly double 2;
	}

	// Token: 0x02000754 RID: 1876
	[107]
	[276]
	public struct 2109
	{
		// Token: 0x06003719 RID: 14105 RVA: 0x0015977A File Offset: 0x0015797A
		public 2109(double 1, double 2)
		{
			this.1 = 1;
			this.2 = 2;
		}

		// Token: 0x040028FE RID: 10494
		public readonly double 1;

		// Token: 0x040028FF RID: 10495
		public readonly double 2;
	}
}
