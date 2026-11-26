using System;

// Token: 0x02000348 RID: 840
public sealed class 727
{
	// Token: 0x060019FB RID: 6651 RVA: 0x00060868 File Offset: 0x0005EA68
	internal static long Method11313(long 1, byte[] 2, int 3, int 4)
	{
		if (2 == null)
		{
			return 1L;
		}
		long num = 1 & 65535L;
		long num2 = 1 >> 16 & 65535L;
		while (4 > 0)
		{
			int i = (4 < 727.number5) ? 4 : 727.number5;
			4 -= i;
			while (i >= 16)
			{
				num += (long)(2[3++] & byte.MaxValue);
				num2 += num;
				num += (long)(2[3++] & byte.MaxValue);
				num2 += num;
				num += (long)(2[3++] & byte.MaxValue);
				num2 += num;
				num += (long)(2[3++] & byte.MaxValue);
				num2 += num;
				num += (long)(2[3++] & byte.MaxValue);
				num2 += num;
				num += (long)(2[3++] & byte.MaxValue);
				num2 += num;
				num += (long)(2[3++] & byte.MaxValue);
				num2 += num;
				num += (long)(2[3++] & byte.MaxValue);
				num2 += num;
				num += (long)(2[3++] & byte.MaxValue);
				num2 += num;
				num += (long)(2[3++] & byte.MaxValue);
				num2 += num;
				num += (long)(2[3++] & byte.MaxValue);
				num2 += num;
				num += (long)(2[3++] & byte.MaxValue);
				num2 += num;
				num += (long)(2[3++] & byte.MaxValue);
				num2 += num;
				num += (long)(2[3++] & byte.MaxValue);
				num2 += num;
				num += (long)(2[3++] & byte.MaxValue);
				num2 += num;
				num += (long)(2[3++] & byte.MaxValue);
				num2 += num;
				i -= 16;
			}
			if (i != 0)
			{
				do
				{
					num += (long)(2[3++] & byte.MaxValue);
					num2 += num;
				}
				while (--i != 0);
			}
			num %= (long)727.number4;
			num2 %= (long)727.number4;
		}
		return num2 << 16 | num;
	}

	// Token: 0x04000C59 RID: 3161
	private static int number4 = 65521;

	// Token: 0x04000C5A RID: 3162
	private static int number5 = 5552;
}
