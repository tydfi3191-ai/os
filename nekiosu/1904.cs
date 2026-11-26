using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x02000868 RID: 2152
public static class 1904
{
	// Token: 0x06003E44 RID: 15940 RVA: 0x00185CAC File Offset: 0x00183EAC
	public static Dictionary<1919, double> 1(List<1919> 1, double 2)
	{
		1904.1906 3 = new 1904.1906();
		List<double> list = (from 1 in (from 1 in 4
		select 1.4).Distinct<double>()
		orderby 1
		select 1).ToList<double>();
		List<List<double>> list2 = new List<List<double>>();
		List<double> list3 = null;
		foreach (double num in list)
		{
			if (list3 != null && Math.Abs(num - list3[0]) <= 2)
			{
				list3.Add(num);
			}
			else
			{
				list3 = new List<double>
				{
					num
				};
				list2.Add(list3);
			}
		}
		3.1 = new Dictionary<double, double>();
		foreach (List<double> list4 in list2)
		{
			list4.Sort();
			int num2 = list4.Count / 2;
			double value = (list4.Count % 2 == 1) ? list4[num2] : ((list4[num2 - 1] + list4[num2]) / 2.0);
			foreach (double key in list4)
			{
				3.1[key] = value;
			}
		}
		return 4.ToDictionary(new Func<1919, 1919>(1904.1905.instance.4), new Func<1919, double>(3.4));
	}

	// Token: 0x02000869 RID: 2153
	[Serializable]
	public sealed class 1905
	{
		// Token: 0x06003E45 RID: 15941 RVA: 0x00022391 File Offset: 0x00020591
		internal 1919 1(1919 1)
		{
			return 1;
		}

		// Token: 0x04002D98 RID: 11672
		public static readonly 1904.1905 instance = new 1904.1905();

		// Token: 0x04002D99 RID: 11673
		public static Func<1919, double> func;

		// Token: 0x04002D9A RID: 11674
		public static Func<double, double> func2;

		// Token: 0x04002D9B RID: 11675
		public static Func<1919, 1919> func3;
	}

	// Token: 0x0200086A RID: 2154
	public sealed class 1906
	{
		// Token: 0x06003E48 RID: 15944 RVA: 0x00185E90 File Offset: 0x00184090
		internal double 1(1919 1)
		{
			double result;
			if (!this.1.TryGetValue(1.4, out result))
			{
				return 1.4;
			}
			return result;
		}

		// Token: 0x04002D9C RID: 11676
		public Dictionary<double, double> 1;
	}
}
