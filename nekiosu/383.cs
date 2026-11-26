using System;
using System.IO;
using System.Text;

// Token: 0x02000336 RID: 822
public sealed class 383
{
	// Token: 0x0600195E RID: 6494 RVA: 0x0005BCF4 File Offset: 0x00059EF4
	public static int Method2138(TextReader 1, byte[] 2, int 3, int 4)
	{
		if (2.Length == 0)
		{
			return 0;
		}
		char[] array = new char[2.Length];
		int num = 1.Read(array, 3, 4);
		if (num == 0)
		{
			return -1;
		}
		for (int i = 3; i < 3 + num; i++)
		{
			2[i] = (byte)array[i];
		}
		return num;
	}

	// Token: 0x0600195F RID: 6495 RVA: 0x0005BD35 File Offset: 0x00059F35
	internal static byte[] Method2139(string 1)
	{
		return Encoding.UTF8.GetBytes(1);
	}

	// Token: 0x06001960 RID: 6496 RVA: 0x0005BD42 File Offset: 0x00059F42
	internal static char[] Method2140(byte[] 1)
	{
		return Encoding.UTF8.GetChars(1);
	}

	// Token: 0x06001961 RID: 6497 RVA: 0x0005BD4F File Offset: 0x00059F4F
	public static int Method2141(int 1, int 2)
	{
		return 1 >> 2;
	}

	// Token: 0x06001962 RID: 6498 RVA: 0x0005BD57 File Offset: 0x00059F57
	public static long Method2141(long 1, int 2)
	{
		return 1 >> 2;
	}
}
