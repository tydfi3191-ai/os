using System;
using System.Collections.Generic;

// Token: 0x02000700 RID: 1792
[276]
public static class 2139
{
	// Token: 0x17000286 RID: 646
	// (get) Token: 0x060034E6 RID: 13542 RVA: 0x00145474 File Offset: 0x00143674
	private static 1930 Rule
	{
		get
		{
			2486 <<EMPTY_NAME>> = 2486.7;
			if (1662.78 == 1677.Play && <<EMPTY_NAME>> != null && <<EMPTY_NAME>>.39 != null)
			{
				2241 2 = 2486.88;
				if (((2 != null) ? 2.52 : null) != null && 2486.109 && !2486.13 && !2486.4)
				{
					return 2486.88.52.6;
				}
			}
			return 1930.None;
		}
	}

	// Token: 0x17000287 RID: 647
	// (get) Token: 0x060034E7 RID: 13543 RVA: 0x001454D3 File Offset: 0x001436D3
	public static bool IsActive
	{
		get
		{
			return 2139.Rule > 1930.None;
		}
	}

	// Token: 0x060034E8 RID: 13544 RVA: 0x001454DD File Offset: 0x001436DD
	public static void Reset()
	{
		2139.1 = 2139.2140.None;
		2139.2 = null;
		2139.3 = null;
	}

	// Token: 0x060034E9 RID: 13545 RVA: 0x001454F1 File Offset: 0x001436F1
	public static void 1()
	{
		if (2139.1 != 2139.2140.None && 2139.Rule != 1930.None && 2139.3())
		{
			2139.1 = 2139.2140.None;
		}
	}

	// Token: 0x060034EA RID: 13546 RVA: 0x00145510 File Offset: 0x00143710
	public static bool 2(bool 1)
	{
		1930 rule = 2139.Rule;
		if (rule == 1930.None || 2139.3())
		{
			return true;
		}
		2139.2140 2 = 1 ? 2139.2140.Left : 2139.2140.Right;
		if ((rule == 1930.Alternate) ? (2139.1 != 2) : (2139.1 == 2139.2140.None || 2139.1 == 2))
		{
			2139.1 = 2;
			return true;
		}
		1433 3 = 1535.51;
		if (3 != null)
		{
			3.40(198.Red, 1000);
		}
		return false;
	}

	// Token: 0x060034EB RID: 13547 RVA: 0x00145580 File Offset: 0x00143780
	private static bool 3()
	{
		2486 <<EMPTY_NAME>> = 2486.7;
		2039 2 = <<EMPTY_NAME>>.39;
		if (2139.2 == null || 2139.3 != 2 || 2139.4 != 2.34.Count)
		{
			2139.4(<<EMPTY_NAME>>, 2);
		}
		int 3 = 1226.16;
		foreach (int[] array in 2139.2)
		{
			if (3 >= array[0] && 3 <= array[1])
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060034EC RID: 13548 RVA: 0x00145620 File Offset: 0x00143820
	private static void 4(2486 1, 2039 2)
	{
		2139.2 = new List<int[]>();
		2139.3 = 2;
		2139.4 = 2.34.Count;
		if (2.34.Count == 0)
		{
			return;
		}
		2139.2.Add(new int[]
		{
			int.MinValue,
			2.34[0].1 - 2.3 - 1
		});
		2648 3 = 5.34;
		List<2275> list = (3 != null) ? 3.13 : null;
		if (list == null)
		{
			return;
		}
		using (List<2275>.Enumerator enumerator = list.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				2275 breakPeriod = enumerator.Current;
				2034 4 = 2.34.Find((2034 1) => 1.1 >= breakPeriod.1);
				if (4 != null)
				{
					2139.2.Add(new int[]
					{
						breakPeriod.8,
						4.1 - 2.3 - 1
					});
				}
			}
		}
	}

	// Token: 0x0400273C RID: 10044
	private static 2139.2140 1;

	// Token: 0x0400273D RID: 10045
	private static List<int[]> 2;

	// Token: 0x0400273E RID: 10046
	private static 2039 3;

	// Token: 0x0400273F RID: 10047
	private static int 4;

	// Token: 0x02000701 RID: 1793
	[276]
	private enum 2140
	{
		// Token: 0x04002741 RID: 10049
		None,
		// Token: 0x04002742 RID: 10050
		Left,
		// Token: 0x04002743 RID: 10051
		Right
	}
}
