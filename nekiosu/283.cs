using System;

// Token: 0x0200002C RID: 44
public static class 283
{
	// Token: 0x060000FA RID: 250 RVA: 0x000060A4 File Offset: 0x000042A4
	public static void Method0064(byte[] 1, int 2, int 3)
	{
		for (int i = 0; i < 4; i++)
		{
			int num = 2++;
			1[num] ^= (byte)(3 >> i * 8);
		}
	}

	// Token: 0x060000FB RID: 251 RVA: 0x000060D8 File Offset: 0x000042D8
	public static void Method0065(byte[] 1, int 2, int 3)
	{
		int num = 0;
		while (num < 4 && 2 < 1.Length)
		{
			int num2 = 2++;
			1[num2] ^= (byte)(3 >> num * 8);
			num++;
		}
	}

	// Token: 0x060000FC RID: 252 RVA: 0x00006114 File Offset: 0x00004314
	public static void Method0066(byte[] 1, int 2, long 3)
	{
		for (int i = 0; i < 8; i++)
		{
			int num = 2++;
			1[num] ^= (byte)(3 >> i * 8);
		}
	}
}
