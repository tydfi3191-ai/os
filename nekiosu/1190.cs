using System;

// Token: 0x02000BC2 RID: 3010
public static class 1190
{
	// Token: 0x060052D9 RID: 21209 RVA: 0x002092A0 File Offset: 0x002074A0
	public static T[] 1<T>(this T[] 1, int 2)
	{
		if (2 < 0)
		{
			2 = 1.Length + 2;
		}
		int num = 2;
		T[] array = new T[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = 1[i];
		}
		return array;
	}
}
