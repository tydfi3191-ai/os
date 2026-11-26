using System;

// Token: 0x02000020 RID: 32
public static class 292
{
	// Token: 0x060000B3 RID: 179 RVA: 0x000058BC File Offset: 0x00003ABC
	public static bool Method0143(int[] 1, int[] 2)
	{
		if (1 == 2)
		{
			return true;
		}
		if (1 == null || 2 == null)
		{
			return false;
		}
		if (1.Length != 2.Length)
		{
			return false;
		}
		for (int i = 0; i < 1.Length; i++)
		{
			if (1[i] != 2[i])
			{
				return false;
			}
		}
		return true;
	}
}
