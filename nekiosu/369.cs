using System;
using System.IO;
using System.Runtime.InteropServices;

// Token: 0x02000335 RID: 821
[ClassInterface(ClassInterfaceType.AutoDispatch)]
[Guid("ebc25cf6-9120-4283-b972-0e5520d0000C")]
[ComVisible(true)]
public sealed class 369
{
	// Token: 0x06001955 RID: 6485 RVA: 0x0005BB48 File Offset: 0x00059D48
	static 369()
	{
		uint num = 3988292384U;
		369.numberArray = new uint[256];
		for (uint num2 = 0U; num2 < 256U; num2 += 1U)
		{
			uint num3 = num2;
			for (uint num4 = 8U; num4 != 0U; num4 -= 1U)
			{
				num3 = (((num3 & 1U) != 1U) ? (num3 >> 1) : (num3 >> 1 ^ num));
			}
			369.numberArray[(int)num2] = num3;
		}
	}

	// Token: 0x06001956 RID: 6486 RVA: 0x0005BBA0 File Offset: 0x00059DA0
	internal int Method1885(uint 1, byte 2)
	{
		return (int)(369.numberArray[(int)((IntPtr)((long)((ulong)((1 ^ (uint)2) & 255U))))] ^ 1 >> 8);
	}

	// Token: 0x06001957 RID: 6487 RVA: 0x0005BBC0 File Offset: 0x00059DC0
	public int Method1886(int 1, byte 2)
	{
		return this.Method1885((uint)1, 2);
	}

	// Token: 0x06001958 RID: 6488 RVA: 0x0005BBCA File Offset: 0x00059DCA
	public int Method1887(Stream 1)
	{
		return this.Method1888(1, null);
	}

	// Token: 0x06001959 RID: 6489 RVA: 0x0005BBD4 File Offset: 0x00059DD4
	public int Method1888(Stream 1, Stream 2)
	{
		if (1 == null)
		{
			throw new 522("The input stream must not be null.");
		}
		byte[] array = new byte[8192];
		int count = 8192;
		this.number4 = 0L;
		int i = 1.Read(array, 0, count);
		if (2 != null)
		{
			2.Write(array, 0, i);
		}
		this.number4 += (long)i;
		while (i > 0)
		{
			this.Method1889(array, 0, i);
			i = 1.Read(array, 0, count);
			if (2 != null)
			{
				2.Write(array, 0, i);
			}
			this.number4 += (long)i;
		}
		return (int)(~(int)this.number3);
	}

	// Token: 0x0600195A RID: 6490 RVA: 0x0005BC68 File Offset: 0x00059E68
	public void Method1889(byte[] 1, int 2, int 3)
	{
		if (1 == null)
		{
			throw new 522("The data buffer must not be null.");
		}
		for (int i = 0; i < 3; i++)
		{
			int num = 2 + i;
			this.number3 = (this.number3 >> 8 ^ 369.numberArray[(int)((IntPtr)((long)((ulong)((uint)1[num] ^ (this.number3 & 255U)))))]);
		}
		this.number4 += (long)3;
	}

	// Token: 0x0600195B RID: 6491 RVA: 0x0005BCD2 File Offset: 0x00059ED2
	public int Method1890()
	{
		return (int)(~(int)this.number3);
	}

	// Token: 0x0600195C RID: 6492 RVA: 0x0005BCDB File Offset: 0x00059EDB
	public long GetNumber1278_1891()
	{
		return this.number4;
	}

	// Token: 0x04000BC2 RID: 3010
	private uint number3 = uint.MaxValue;

	// Token: 0x04000BC3 RID: 3011
	private long number4;

	// Token: 0x04000BC4 RID: 3012
	private static uint[] numberArray;
}
