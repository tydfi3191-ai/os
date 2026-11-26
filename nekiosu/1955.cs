using System;
using System.Collections.Generic;

// Token: 0x020007AA RID: 1962
internal static class 1955<T>
{
	// Token: 0x0600394B RID: 14667 RVA: 0x00169A62 File Offset: 0x00167C62
	public static void 1(T[] 1, IComparer<T> 2)
	{
		if (1.Length == 0)
		{
			return;
		}
		1955<T>.2(1, 0, 1.Length - 1, 2, 32);
	}

	// Token: 0x0600394C RID: 14668 RVA: 0x00169A78 File Offset: 0x00167C78
	private static void 2(T[] 1, int 2, int 3, IComparer<T> 4, int 5)
	{
		while (5 != 0)
		{
			int num = 2;
			int num2 = 3;
			int num3 = num + (num2 - num >> 1);
			1955<T>.6(1, 4, num, num3);
			1955<T>.6(1, 4, num, num2);
			1955<T>.6(1, 4, num3, num2);
			T t = 1[num3];
			for (;;)
			{
				if (4.Compare(1[num], t) >= 0)
				{
					while (4.Compare(t, 1[num2]) < 0)
					{
						num2--;
					}
					if (num > num2)
					{
						break;
					}
					if (num < num2)
					{
						T t2 = 1[num];
						1[num] = 1[num2];
						1[num2] = t2;
					}
					num++;
					num2--;
					if (num > num2)
					{
						break;
					}
				}
				else
				{
					num++;
				}
			}
			5--;
			if (num2 - 2 <= 3 - num)
			{
				if (2 < num2)
				{
					1955<T>.2(1, 2, num2, 4, 5);
				}
				2 = num;
			}
			else
			{
				if (num < 3)
				{
					1955<T>.2(1, num, 3, 4, 5);
				}
				3 = num2;
			}
			if (2 >= 3)
			{
				return;
			}
		}
		1955<T>.3(1, 2, 3, 4);
	}

	// Token: 0x0600394D RID: 14669 RVA: 0x00169B60 File Offset: 0x00167D60
	private static void 3(T[] 1, int 2, int 3, IComparer<T> 4)
	{
		int num = 3 - 2 + 1;
		for (int i = num / 2; i >= 1; i--)
		{
			1955<T>.4(1, i, num, 2, 4);
		}
		for (int j = num; j > 1; j--)
		{
			1955<T>.5(1, 2, 2 + j - 1);
			1955<T>.4(1, 1, j - 1, 2, 4);
		}
	}

	// Token: 0x0600394E RID: 14670 RVA: 0x00169BB0 File Offset: 0x00167DB0
	private static void 4(T[] 1, int 2, int 3, int 4, IComparer<T> 5)
	{
		T t = 1[4 + 2 - 1];
		while (2 <= 3 / 2)
		{
			int num = 2 * 2;
			if (num < 3 && 5.Compare(1[4 + num - 1], 1[4 + num]) < 0)
			{
				num++;
			}
			if (5.Compare(t, 1[4 + num - 1]) >= 0)
			{
				break;
			}
			1[4 + 2 - 1] = 1[4 + num - 1];
			2 = num;
		}
		1[4 + 2 - 1] = t;
	}

	// Token: 0x0600394F RID: 14671 RVA: 0x00169C38 File Offset: 0x00167E38
	private static void 5(T[] 1, int 2, int 3)
	{
		if (2 != 3)
		{
			T t = 1[2];
			1[2] = 1[3];
			1[3] = t;
		}
	}

	// Token: 0x06003950 RID: 14672 RVA: 0x00169C68 File Offset: 0x00167E68
	private static void 6(T[] 1, IComparer<T> 2, int 3, int 4)
	{
		if (3 != 4 && 2.Compare(1[3], 1[4]) > 0)
		{
			T t = 1[3];
			1[3] = 1[4];
			1[4] = t;
		}
	}

	// Token: 0x04002A7F RID: 10879
	private const int 1 = 32;
}
