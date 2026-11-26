using System;
using System.Collections.Generic;

// Token: 0x02000AB0 RID: 2736
public static class 1414
{
	// Token: 0x06004BEA RID: 19434 RVA: 0x001E00D8 File Offset: 0x001DE2D8
	internal static bool 1(1413 1)
	{
		return 1414.1.Remove(1) || 1414.2.Remove(1);
	}

	// Token: 0x06004BEB RID: 19435 RVA: 0x001E00F4 File Offset: 0x001DE2F4
	internal static void 2(1413 1, bool 2)
	{
		if (1 != null)
		{
			if (2)
			{
				1414.1.Add(1);
				return;
			}
			1414.2.Add(1);
		}
	}

	// Token: 0x06004BEC RID: 19436 RVA: 0x001E0114 File Offset: 0x001DE314
	internal static void 3()
	{
		try
		{
			for (int i = 0; i < 1414.1.Count; i++)
			{
				if (1414.1[i].50())
				{
					1414.1.RemoveAt(i--);
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x06004BED RID: 19437 RVA: 0x001E016C File Offset: 0x001DE36C
	public static void 4()
	{
		foreach (1413 <<EMPTY_NAME>> in 1414.1)
		{
			<<EMPTY_NAME>>.51();
		}
		foreach (1413 2 in 1414.2)
		{
			2.51();
		}
		1414.1.Clear();
		1414.2.Clear();
	}

	// Token: 0x04003880 RID: 14464
	internal static List<1413> 1 = new List<1413>();

	// Token: 0x04003881 RID: 14465
	internal static List<1413> 2 = new List<1413>();
}
