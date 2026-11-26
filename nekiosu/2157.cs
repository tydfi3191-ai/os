using System;
using System.Collections.Generic;

// Token: 0x020006E9 RID: 1769
public static class 2157
{
	// Token: 0x0600348A RID: 13450 RVA: 0x00142EE0 File Offset: 0x001410E0
	public static void 1(List<1896> 1)
	{
		foreach (1902 2 in 2157.2(1))
		{
			for (int i = 0; i < 2.1.Count; i++)
			{
				1899 3 = 2.1[i];
				3.2 = 2;
				3.3 = i;
				for (int j = 0; j < 3.1.Count; j++)
				{
					1886 4 = 3.1[j];
					4.2 = 3;
					4.3 = j;
					foreach (1919 5 in 4.1())
					{
						5.14.3 = 2;
						5.14.2 = 3;
						5.14.1 = 4;
					}
				}
			}
		}
	}

	// Token: 0x0600348B RID: 13451 RVA: 0x00143008 File Offset: 0x00141208
	private static List<1902> 2(List<1896> 1)
	{
		return 2157.5(2157.4(2157.3(1)));
	}

	// Token: 0x0600348C RID: 13452 RVA: 0x0014301C File Offset: 0x0014121C
	private static List<1886> 3(List<1896> 1)
	{
		List<1886> list = new List<1886>();
		1886 2 = null;
		int i = 0;
		while (i < 1.Count)
		{
			1919 3 = (1919)1[i];
			1919 4 = 3.5(0);
			1887? 5 = null;
			if (3.2.HasObjectType(2047.Normal))
			{
				5 = new 1887?((3.2.HasClap() || 3.2.HasWhistle()) ? ((1887)1) : ((1887)0));
			}
			1887? 6 = null;
			if (4 != null && 4.2.HasObjectType(2047.Normal))
			{
				6 = new 1887?((4.2.HasClap() || 4.2.HasWhistle()) ? ((1887)1) : ((1887)0));
			}
			if (2 == null || 4 == null)
			{
				goto IL_D4;
			}
			1887? 7 = 5;
			1887? 8 = 6;
			if (!(7.GetValueOrDefault() == 8.GetValueOrDefault() & 7 != null == (8 != null)))
			{
				goto IL_D4;
			}
			IL_E1:
			2.1().Add(3);
			i++;
			continue;
			IL_D4:
			2 = new 1886();
			list.Add(2);
			goto IL_E1;
		}
		return list;
	}

	// Token: 0x0600348D RID: 13453 RVA: 0x00143128 File Offset: 0x00141328
	private static List<1899> 4(List<1886> 1)
	{
		List<1899> list = new List<1899>();
		1899 2 = null;
		for (int i = 0; i < 1.Count; i++)
		{
			if (2 == null || 1[i].6() != 1[i - 1].6())
			{
				2 = new 1899();
				list.Add(2);
			}
			2.1.Add(1[i]);
		}
		return list;
	}

	// Token: 0x0600348E RID: 13454 RVA: 0x00143190 File Offset: 0x00141390
	private static List<1902> 5(List<1899> 1)
	{
		List<1902> list = new List<1902>();
		1902 2 = null;
		for (int i = 0; i < 1.Count; i++)
		{
			2 = new 1902(2);
			bool flag = i < 1.Count - 2 && 1[i].2(1[i + 2]);
			if (!flag)
			{
				2.1.Add(1[i]);
			}
			else
			{
				while (flag)
				{
					2.1.Add(1[i]);
					i++;
					flag = (i < 1.Count - 2 && 1[i].2(1[i + 2]));
				}
				2.1.Add(1[i]);
				2.1.Add(1[i + 1]);
				i++;
			}
			list.Add(2);
		}
		for (int j = 0; j < list.Count; j++)
		{
			list[j].5();
		}
		return list;
	}
}
