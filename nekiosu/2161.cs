using System;
using System.Collections.Generic;

// Token: 0x020006FE RID: 1790
public static class 2161
{
	// Token: 0x060034DA RID: 13530 RVA: 0x00144F9C File Offset: 0x0014319C
	public static List<List<T>> 1<T>(IList<T> 1) where T : 1903
	{
		List<List<T>> list = new List<List<T>>();
		int i = 0;
		while (i < 1.Count)
		{
			list.Add(2161.2<T>(1, ref i));
		}
		return list;
	}

	// Token: 0x060034DB RID: 13531 RVA: 0x00144FCC File Offset: 0x001431CC
	private static List<T> 2<T>(IList<T> 1, ref int 2) where T : 1903
	{
		List<T> list = new List<T>
		{
			1[2]
		};
		for (2++; 2 < 1.Count - 1; 2++)
		{
			T t = 1[2];
			double startGap = t.GetStartGap();
			t = 1[2 + 1];
			if (!1194.2(startGap, t.GetStartGap(), 5.0))
			{
				t = 1[2 + 1];
				double startGap2 = t.GetStartGap();
				t = 1[2];
				if (startGap2 > t.GetStartGap() + 5.0)
				{
					list.Add(1[2]);
					2++;
				}
				return list;
			}
			list.Add(1[2]);
		}
		if (1.Count > 2 && 2 < 1.Count)
		{
			T t = 1[1.Count - 1];
			double startGap3 = t.GetStartGap();
			t = 1[1.Count - 2];
			if (1194.2(startGap3, t.GetStartGap(), 5.0))
			{
				list.Add(1[2]);
				2++;
			}
		}
		return list;
	}
}
