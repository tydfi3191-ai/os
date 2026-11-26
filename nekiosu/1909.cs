using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x0200086F RID: 2159
public sealed class 1909
{
	// Token: 0x06003E56 RID: 15958 RVA: 0x001860E0 File Offset: 0x001842E0
	public 1909(1909 1, List<1907> 2)
	{
		this.2 = 1;
		this.1 = 2;
	}

	// Token: 0x06003E57 RID: 15959 RVA: 0x001860F6 File Offset: 0x001842F6
	public IList<1907> 1()
	{
		return this.1;
	}

	// Token: 0x06003E58 RID: 15960 RVA: 0x001860FE File Offset: 0x001842FE
	public 1909 2()
	{
		return this.2;
	}

	// Token: 0x06003E59 RID: 15961 RVA: 0x00186106 File Offset: 0x00184306
	public double 3()
	{
		if (this.1().Count <= 1)
		{
			return this.1()[0].GetStartGap();
		}
		return this.1()[1].GetStartGap();
	}

	// Token: 0x06003E5A RID: 15962 RVA: 0x0018613C File Offset: 0x0018433C
	public double 4()
	{
		double num = this.3();
		1909 <<EMPTY_NAME>> = this.2();
		return (num / ((<<EMPTY_NAME>> != null) ? new double?(<<EMPTY_NAME>>.3()) : null)).GetValueOrDefault(1.0);
	}

	// Token: 0x06003E5B RID: 15963 RVA: 0x001861A3 File Offset: 0x001843A3
	public 1919 5()
	{
		return this.1()[0].1();
	}

	// Token: 0x06003E5C RID: 15964 RVA: 0x001861B6 File Offset: 0x001843B6
	public IEnumerable<1919> 6()
	{
		return this.1().SelectMany(new Func<1907, IEnumerable<1919>>(1909.1910.instance.1));
	}

	// Token: 0x04002DA7 RID: 11687
	private readonly IList<1907> 1;

	// Token: 0x04002DA8 RID: 11688
	private readonly 1909 2;

	// Token: 0x02000870 RID: 2160
	[Serializable]
	public sealed class 1910
	{
		// Token: 0x06003E5D RID: 15965 RVA: 0x001861D3 File Offset: 0x001843D3
		internal IEnumerable<1919> 1(1907 1)
		{
			return 1.1;
		}

		// Token: 0x04002DA9 RID: 11689
		public static readonly 1909.1910 instance = new 1909.1910();

		// Token: 0x04002DAA RID: 11690
		public static Func<1907, IEnumerable<1919>> func;
	}
}
