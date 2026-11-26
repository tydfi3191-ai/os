using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000864 RID: 2148
public abstract class 1916 : 1914
{
	// Token: 0x06003E32 RID: 15922 RVA: 0x00185A81 File Offset: 0x00183C81
	protected 1916(2023 1) : base(1)
	{
	}

	// Token: 0x06003E33 RID: 15923 RVA: 0x001553CA File Offset: 0x001535CA
	protected virtual double GetDecayWeight()
	{
		return 0.9;
	}

	// Token: 0x06003E34 RID: 15924 RVA: 0x001853F6 File Offset: 0x001835F6
	protected virtual int GetSectionLength()
	{
		return 400;
	}

	// Token: 0x06003E35 RID: 15925
	protected abstract double StrainValueOf(1896 1);

	// Token: 0x06003E36 RID: 15926 RVA: 0x00185A98 File Offset: 0x00183C98
	protected sealed override double StrainValueAt(1896 1)
	{
		if (1.8 == 0)
		{
			this.4 = Math.Ceiling(1.5 / (double)this.GetSectionLength()) * (double)this.GetSectionLength();
		}
		while (1.5 > this.4)
		{
			this.4();
			this.5(this.4, 1);
			this.4 += (double)this.GetSectionLength();
		}
		double num = this.StrainValueOf(1);
		this.3 = Math.Max(num, this.3);
		return num;
	}

	// Token: 0x06003E37 RID: 15927 RVA: 0x00185B20 File Offset: 0x00183D20
	public double 3(double 1)
	{
		1916.1917 2 = new 1916.1917();
		if (this.2.Count == 0)
		{
			return 0.0;
		}
		2.1 = 1 * (1.0 - this.GetDecayWeight());
		if (2.1 == 0.0)
		{
			return (double)this.2.Count;
		}
		return this.2.Sum(new Func<double, double>(2.1));
	}

	// Token: 0x06003E38 RID: 15928 RVA: 0x00185B97 File Offset: 0x00183D97
	private void 4()
	{
		this.5.Add(this.3);
	}

	// Token: 0x06003E39 RID: 15929 RVA: 0x00185BAA File Offset: 0x00183DAA
	private void 5(double 1, 1896 2)
	{
		this.3 = this.CalculateInitialStrain(1, 2);
	}

	// Token: 0x06003E3A RID: 15930
	protected abstract double CalculateInitialStrain(double 1, 1896 2);

	// Token: 0x06003E3B RID: 15931 RVA: 0x00185BBA File Offset: 0x00183DBA
	public IEnumerable<double> 6()
	{
		List<double> list = this.5.ToList<double>();
		list.Add(this.3);
		return list;
	}

	// Token: 0x06003E3C RID: 15932 RVA: 0x00185BD4 File Offset: 0x00183DD4
	public override double DifficultyValue()
	{
		double num = 0.0;
		double num2 = 1.0;
		foreach (double num3 in this.6().Where(new Func<double, bool>(1916.1918.instance.1)).OrderByDescending(new Func<double, double>(1916.1918.instance.2)))
		{
			num += num3 * num2;
			num2 *= this.GetDecayWeight();
		}
		return num;
	}

	// Token: 0x04002D91 RID: 11665
	private double 3;

	// Token: 0x04002D92 RID: 11666
	private double 4;

	// Token: 0x04002D93 RID: 11667
	private readonly List<double> 5 = new List<double>();

	// Token: 0x02000865 RID: 2149
	[Serializable]
	public sealed class 1918
	{
		// Token: 0x06003E3D RID: 15933 RVA: 0x00155603 File Offset: 0x00153803
		internal bool 1(double 1)
		{
			return 1 > 0.0;
		}

		// Token: 0x06003E3E RID: 15934 RVA: 0x00022391 File Offset: 0x00020591
		internal double 2(double 1)
		{
			return 1;
		}

		// Token: 0x04002D94 RID: 11668
		public static readonly 1916.1918 instance = new 1916.1918();

		// Token: 0x04002D95 RID: 11669
		public static Func<double, bool> func;

		// Token: 0x04002D96 RID: 11670
		public static Func<double, double> func2;
	}

	// Token: 0x02000866 RID: 2150
	public sealed class 1917
	{
		// Token: 0x06003E41 RID: 15937 RVA: 0x00185C74 File Offset: 0x00183E74
		internal double 1(double 1)
		{
			return 1.1 / (1.0 + Math.Exp(-10.0 * (1 / this.1 - 0.88)));
		}

		// Token: 0x04002D97 RID: 11671
		public double 1;
	}
}
