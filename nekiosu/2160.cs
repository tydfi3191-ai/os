using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x020006FD RID: 1789
public static class 2160
{
	// Token: 0x060034D7 RID: 13527 RVA: 0x00144DB4 File Offset: 0x00142FB4
	public static void 1(List<1919> 1)
	{
		List<1907> list = 2160.2(1);
		foreach (1907 2 in list)
		{
			foreach (1919 3 in 2.1)
			{
				3.13.1 = 2;
			}
		}
		foreach (1909 4 in 2160.3(list))
		{
			foreach (1919 5 in 4.6())
			{
				5.13.2 = 4;
			}
		}
	}

	// Token: 0x060034D8 RID: 13528 RVA: 0x00144ECC File Offset: 0x001430CC
	private static List<1907> 2(List<1919> 1)
	{
		List<1907> list = new List<1907>();
		foreach (List<1919> 2 in 2161.1<1919>(1))
		{
			list.Add(new 1907(list.LastOrDefault<1907>(), 2));
		}
		return list;
	}

	// Token: 0x060034D9 RID: 13529 RVA: 0x00144F34 File Offset: 0x00143134
	private static List<1909> 3(List<1907> 1)
	{
		List<1909> list = new List<1909>();
		foreach (List<1907> 2 in 2161.1<1907>(1))
		{
			list.Add(new 1909(list.LastOrDefault<1909>(), 2));
		}
		return list;
	}
}
