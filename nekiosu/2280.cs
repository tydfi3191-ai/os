using System;
using System.Collections.Generic;

// Token: 0x0200064B RID: 1611
public sealed class 2280
{
	// Token: 0x0600314D RID: 12621 RVA: 0x001272C4 File Offset: 0x001254C4
	internal 2280()
	{
		this.3();
	}

	// Token: 0x0600314E RID: 12622 RVA: 0x001272F3 File Offset: 0x001254F3
	internal 2327 1()
	{
		return ((2271)this.2.Find(new Predicate<2254>(2280.2281.instance.1))).2;
	}

	// Token: 0x0600314F RID: 12623 RVA: 0x0012731A File Offset: 0x0012551A
	internal void 2(bool 1)
	{
		((2288)this.2.Find((2254 1) => 1._0005_2005_2000_200A_2003_2005_2004_2004_2005_2003_2000() == 2277.Compose)).4 = 2;
	}

	// Token: 0x06003150 RID: 12624 RVA: 0x00127354 File Offset: 0x00125554
	private void 3()
	{
		this.2.Clear();
		this.2.Add(2279.1());
		this.2.Add(2279.4());
		this.2.Add(2279.2());
		this.2.Add(2279.3());
		this.2.Add(2279.5());
		this.2.AddRange(this.3.1);
	}

	// Token: 0x06003151 RID: 12625 RVA: 0x001273D4 File Offset: 0x001255D4
	internal void 4(2039 1)
	{
		if (this.2.Count == 0)
		{
			this.3();
		}
		this.1.Clear();
		1.41();
		List<2278> list = this.1[2277.All] = new List<2278>();
		foreach (2254 2 in this.2)
		{
			List<2278> list2 = 2._000F_2003_2007_2008_2001_2009_2000_2007_2008_200A_2001_2002_2009_200A_2007_2007_2003_2005(1);
			this.5(2._0005_2005_2000_200A_2003_2005_2004_2004_2005_2003_2000(), list2);
		}
		if (list.Count == 0)
		{
			list.Add(new 2278(-1, (2341)0, 1568.1(2679.AIModWindow_NoProblemsFound), 0, null));
		}
	}

	// Token: 0x06003152 RID: 12626 RVA: 0x00127494 File Offset: 0x00125694
	internal void 5(2277 1, List<2278> 2)
	{
		if (2 != null)
		{
			if (!this.1.ContainsKey(1))
			{
				this.1[1] = new List<2278>();
			}
			this.1[1].AddRange(2);
			if (1 != 2277.All)
			{
				this.5(2277.All, 2);
			}
		}
	}

	// Token: 0x06003153 RID: 12627 RVA: 0x001274E0 File Offset: 0x001256E0
	internal List<2278> 6(2277 1, 2341 2)
	{
		2280.2282 3 = new 2280.2282();
		3.1 = 2;
		List<2278> result;
		try
		{
			result = this.1[1].FindAll(new Predicate<2278>(3.1));
		}
		catch
		{
			result = null;
		}
		return result;
	}

	// Token: 0x06003154 RID: 12628 RVA: 0x00127530 File Offset: 0x00125730
	internal static bool 7(int 1, bool 2, double 3)
	{
		int num = 2263.4.76.29((double)1, 8, (double)1);
		int num2 = 2263.4.76.29((double)1, 6, (double)1);
		return !((!2) ? (Math.Abs(num - 1) < 1 || Math.Abs(num2 - 1) < 1) : ((double)Math.Abs(num - 1) <= 3 || (double)Math.Abs(num2 - 1) <= 3));
	}

	// Token: 0x06003155 RID: 12629 RVA: 0x001275A8 File Offset: 0x001257A8
	internal static bool 8(int 1, out int 2, bool 3)
	{
		int[] array = 2280.4;
		for (int i = 0; i < array.Length; i++)
		{
			int num = 2 = array[i];
			if ((double)Math.Abs(2263.4.76.29((double)1, num, (double)1) - 1) < (3 ? 1.01 : 1.0))
			{
				return true;
			}
		}
		2 = -1;
		return false;
	}

	// Token: 0x04002459 RID: 9305
	internal Dictionary<2277, List<2278>> 1 = new Dictionary<2277, List<2278>>();

	// Token: 0x0400245A RID: 9306
	internal List<2254> 2 = new List<2254>();

	// Token: 0x0400245B RID: 9307
	private 2251 3 = new 2251();

	// Token: 0x0400245C RID: 9308
	public static int[] 4 = new int[]
	{
		5,
		7,
		9,
		12,
		16
	};

	// Token: 0x0200064C RID: 1612
	[Serializable]
	public sealed class 2281
	{
		// Token: 0x06003157 RID: 12631 RVA: 0x00127625 File Offset: 0x00125825
		internal bool 1(2254 1)
		{
			return 1._0005_2005_2000_200A_2003_2005_2004_2004_2005_2003_2000() == 2277.Meta;
		}

		// Token: 0x0400245D RID: 9309
		public static readonly 2280.2281 instance = new 2280.2281();

		// Token: 0x0400245E RID: 9310
		public static Predicate<2254> predicate;

		// Token: 0x0400245F RID: 9311
		public static Predicate<2254> predicate2;
	}

	// Token: 0x0200064D RID: 1613
	public sealed class 2282
	{
		// Token: 0x0600315A RID: 12634 RVA: 0x0012763C File Offset: 0x0012583C
		internal bool 1(2278 1)
		{
			return 1.2 == this.1;
		}

		// Token: 0x04002460 RID: 9312
		public 2341 1;
	}
}
