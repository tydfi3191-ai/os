using System;
using System.Runtime.InteropServices;

// Token: 0x0200043B RID: 1083
[ComVisible(false)]
public sealed class 2680
{
	// Token: 0x060021B4 RID: 8628 RVA: 0x00091442 File Offset: 0x0008F642
	public void 1(uint[] 1, 594 2)
	{
		if (2 == (594)3)
		{
			throw new ArgumentException("Encryption method can't be none");
		}
		if (1.Length != 4)
		{
			throw new ArgumentException("Encryption key has to be 4 words long");
		}
		this.1 = 1;
		this.2 = 2;
	}

	// Token: 0x060021B5 RID: 8629 RVA: 0x00091472 File Offset: 0x0008F672
	private void 2()
	{
		if (this.2 == (594)3)
		{
			new ArgumentException("Encryption method has to be set first");
		}
	}

	// Token: 0x060021B6 RID: 8630 RVA: 0x00091488 File Offset: 0x0008F688
	private unsafe void 3(byte* 1, int 2, bool 3)
	{
		uint num = (uint)(2 / 64);
		uint num2 = (uint)(2 & 63);
		uint* ptr = (uint*)1;
		uint num3 = 16U;
		this.3 = 16U;
		uint num4 = 6U + 52U / this.3;
		if (3)
		{
			for (uint num5 = 0U; num5 < num; num5 += 1U)
			{
				this.13(ptr);
				ptr += (ulong)16 * 4UL / 4UL;
			}
		}
		else
		{
			for (uint num6 = 0U; num6 < num; num6 += 1U)
			{
				uint num7 = num4 * 2654435769U;
				uint num8 = *ptr;
				do
				{
					uint num9 = num7 >> 2 & 3U;
					uint num10;
					uint num11;
					for (num10 = num3 - 1U; num10 != 0U; num10 -= 1U)
					{
						num11 = ptr[(ulong)(num10 - 1U) * 4UL / 4UL];
						num8 = (ptr[(ulong)num10 * 4UL / 4UL] -= ((num11 >> 5 ^ num8 << 2) + (num8 >> 3 ^ num11 << 4) ^ (num7 ^ num8) + (this.1[(int)((num10 & 3U) ^ num9)] ^ num11)));
					}
					num11 = ptr[(ulong)(num3 - 1U) * 4UL / 4UL];
					num8 = (*ptr -= ((num11 >> 5 ^ num8 << 2) + (num8 >> 3 ^ num11 << 4) ^ (num7 ^ num8) + (this.1[(int)((num10 & 3U) ^ num9)] ^ num11)));
				}
				while ((num7 -= 2654435769U) != 0U);
				ptr += (ulong)16 * 4UL / 4UL;
			}
		}
		if (num2 == 0U)
		{
			return;
		}
		this.3 = num2 / 4U;
		if (this.3 > 1U)
		{
			if (3)
			{
				this.13(ptr);
			}
			else
			{
				this.14(ptr);
			}
			num2 -= this.3 * 4U;
			if (num2 == 0U)
			{
				return;
			}
		}
		byte* ptr2 = 1 + ((long)2 - (long)((ulong)num2));
		if (3)
		{
			this.15(ptr2, (int)num2);
			return;
		}
		this.16(ptr2, (int)num2);
	}

	// Token: 0x060021B7 RID: 8631 RVA: 0x00091628 File Offset: 0x0008F828
	private unsafe void 4(byte* 1, byte* 2, int 3, bool 4)
	{
		uint num = (uint)(3 / 8);
		uint num2 = (uint)(3 % 8);
		uint* ptr = (uint*)(1 - (IntPtr)2 * 4);
		uint* ptr2 = (uint*)(2 - (IntPtr)2 * 4);
		if (4)
		{
			int num3 = 0;
			while ((long)num3 < (long)((ulong)num))
			{
				this.11(ptr += 2, ptr2 += 2);
				num3++;
			}
		}
		else
		{
			int num4 = 0;
			while ((long)num4 < (long)((ulong)num))
			{
				this.12(ptr += 2, ptr2 += 2);
				num4++;
			}
		}
		if (num2 != 0U)
		{
			byte* ptr3 = 1 + 3;
			byte* ptr4 = ptr3 - num2;
			byte* ptr5 = 2 + 3 - num2;
			do
			{
				ptr5 = ptr4++ + 1;
			}
			while (ptr4 != ptr3);
			if (4)
			{
				this.15(ptr5 - num2, (int)num2);
				return;
			}
			this.16(ptr5 - num2, (int)num2);
		}
	}

	// Token: 0x060021B8 RID: 8632 RVA: 0x000916EA File Offset: 0x0008F8EA
	private unsafe void 5(byte* 1, int 2, bool 3)
	{
		if (3)
		{
			this.15(1, 2);
			return;
		}
		this.16(1, 2);
	}

	// Token: 0x060021B9 RID: 8633 RVA: 0x00091700 File Offset: 0x0008F900
	private unsafe void 6(byte* 1, int 2, bool 3)
	{
		switch (this.2)
		{
		case (594)0:
			this.7(1, 1, 2, 3);
			return;
		case (594)1:
			this.3(1, 2, 3);
			return;
		case (594)2:
			this.5(1, 2, 3);
			return;
		case (594)3:
			this.2();
			return;
		default:
			return;
		}
	}

	// Token: 0x060021BA RID: 8634 RVA: 0x00091750 File Offset: 0x0008F950
	private unsafe void 7(byte* 1, byte* 2, int 3, bool 4)
	{
		switch (this.2)
		{
		case (594)0:
			this.4(1, 2, 3, 4);
			return;
		case (594)1:
		case (594)2:
			throw new NotSupportedException();
		case (594)3:
			this.2();
			return;
		default:
			return;
		}
	}

	// Token: 0x060021BB RID: 8635 RVA: 0x00091794 File Offset: 0x0008F994
	public unsafe void 8(byte[] 1, byte[] 2, int 3, int 4, int 5, bool 6)
	{
		fixed (byte[] array = 1)
		{
			byte* ptr;
			if (1 == null || array.Length == 0)
			{
				ptr = null;
			}
			else
			{
				ptr = &array[0];
			}
			fixed (byte[] array2 = 2)
			{
				byte* ptr2;
				if (2 == null || array2.Length == 0)
				{
					ptr2 = null;
				}
				else
				{
					ptr2 = &array2[0];
				}
				if (ptr2 == null)
				{
					this.6(ptr + 3, 5, 6);
				}
				else
				{
					this.7(ptr + 3, ptr2 + 4, 5, 6);
				}
			}
		}
	}

	// Token: 0x060021BC RID: 8636 RVA: 0x000917FA File Offset: 0x0008F9FA
	public void 9(byte[] 1, int 2, int 3)
	{
		this.8(1, null, 2, 0, 3, false);
	}

	// Token: 0x060021BD RID: 8637 RVA: 0x00091808 File Offset: 0x0008FA08
	public void 10(byte[] 1, int 2, int 3)
	{
		this.8(1, null, 2, 0, 3, true);
	}

	// Token: 0x060021BE RID: 8638 RVA: 0x00091818 File Offset: 0x0008FA18
	private unsafe void 11(uint* 1, uint* 2)
	{
		uint num = *1;
		uint num2 = 1[1];
		uint num3 = 0U;
		for (uint num4 = 0U; num4 < 32U; num4 += 1U)
		{
			num += ((num2 << 4 ^ num2 >> 5) + num2 ^ num3 + this.1[(int)(num3 & 3U)]);
			num3 += 2654435769U;
			num2 += ((num << 4 ^ num >> 5) + num ^ num3 + this.1[(int)(num3 >> 11 & 3U)]);
		}
		*2 = num;
		2[1] = num2;
	}

	// Token: 0x060021BF RID: 8639 RVA: 0x00091884 File Offset: 0x0008FA84
	private unsafe void 12(uint* 1, uint* 2)
	{
		uint num = *1;
		uint num2 = 1[1];
		uint num3 = 3337565984U;
		for (uint num4 = 0U; num4 < 32U; num4 += 1U)
		{
			num2 -= ((num << 4 ^ num >> 5) + num ^ num3 + this.1[(int)(num3 >> 11 & 3U)]);
			num3 -= 2654435769U;
			num -= ((num2 << 4 ^ num2 >> 5) + num2 ^ num3 + this.1[(int)(num3 & 3U)]);
		}
		*2 = num;
		2[1] = num2;
	}

	// Token: 0x060021C0 RID: 8640 RVA: 0x000918F4 File Offset: 0x0008FAF4
	private unsafe void 13(uint* 1)
	{
		uint num = 6U + 52U / this.3;
		uint num2 = 0U;
		uint num3 = 1[(ulong)(this.3 - 1U) * 4UL / 4UL];
		do
		{
			num2 += 2654435769U;
			uint num4 = num2 >> 2 & 3U;
			uint num5;
			uint num6;
			for (num5 = 0U; num5 < this.3 - 1U; num5 += 1U)
			{
				num6 = 1[(ulong)(num5 + 1U) * 4UL / 4UL];
				num3 = (1[(ulong)num5 * 4UL / 4UL] += ((num3 >> 5 ^ num6 << 2) + (num6 >> 3 ^ num3 << 4) ^ (num2 ^ num6) + (this.1[(int)((num5 & 3U) ^ num4)] ^ num3)));
			}
			num6 = *1;
			num3 = (1[(ulong)(this.3 - 1U) * 4UL / 4UL] += ((num3 >> 5 ^ num6 << 2) + (num6 >> 3 ^ num3 << 4) ^ (num2 ^ num6) + (this.1[(int)((num5 & 3U) ^ num4)] ^ num3)));
		}
		while ((num -= 1U) != 0U);
	}

	// Token: 0x060021C1 RID: 8641 RVA: 0x000919DC File Offset: 0x0008FBDC
	private unsafe void 14(uint* 1)
	{
		uint num = (6U + 52U / this.3) * 2654435769U;
		uint num2 = *1;
		do
		{
			uint num3 = num >> 2 & 3U;
			uint num4;
			uint num5;
			for (num4 = this.3 - 1U; num4 != 0U; num4 -= 1U)
			{
				num5 = 1[(ulong)(num4 - 1U) * 4UL / 4UL];
				num2 = (1[(ulong)num4 * 4UL / 4UL] -= ((num5 >> 5 ^ num2 << 2) + (num2 >> 3 ^ num5 << 4) ^ (num ^ num2) + (this.1[(int)((num4 & 3U) ^ num3)] ^ num5)));
			}
			num5 = 1[(ulong)(this.3 - 1U) * 4UL / 4UL];
			num2 = (*1 -= ((num5 >> 5 ^ num2 << 2) + (num2 >> 3 ^ num5 << 4) ^ (num ^ num2) + (this.1[(int)((num4 & 3U) ^ num3)] ^ num5)));
		}
		while ((num -= 2654435769U) != 0U);
	}

	// Token: 0x060021C2 RID: 8642 RVA: 0x00091AAC File Offset: 0x0008FCAC
	private unsafe void 15(byte* 1, int 2)
	{
		uint[] array;
		uint* ptr;
		if ((array = this.1) == null || array.Length == 0)
		{
			ptr = null;
		}
		else
		{
			ptr = &array[0];
		}
		byte* ptr2 = (byte*)ptr;
		byte b = 0;
		for (int i = 0; i < 2; i++)
		{
			1[i] = (byte)(((int)1[i] + (ptr2[i % 16] >> 2)) % 256);
			byte* ptr3 = 1 + i;
			*ptr3 ^= 2680.17(ptr2[15 - i % 16], (byte)(((int)b + 2 - i) % 7));
			1[i] = 2680.18(1[i], ~b % 7);
			b = 1[i];
		}
		array = null;
	}

	// Token: 0x060021C3 RID: 8643 RVA: 0x00091B44 File Offset: 0x0008FD44
	private unsafe void 16(byte* 1, int 2)
	{
		uint[] array;
		uint* ptr;
		if ((array = this.1) == null || array.Length == 0)
		{
			ptr = null;
		}
		else
		{
			ptr = &array[0];
		}
		byte* ptr2 = (byte*)ptr;
		byte b = 0;
		for (int i = 0; i < 2; i++)
		{
			byte b2 = 1[i];
			1[i] = 2680.17(1[i], ~b % 7);
			byte* ptr3 = 1 + i;
			*ptr3 ^= 2680.17(ptr2[15 - i % 16], (byte)(((int)b + 2 - i) % 7));
			1[i] = (byte)(((int)1[i] - (ptr2[i % 16] >> 2)) % 256);
			b = b2;
		}
		array = null;
	}

	// Token: 0x060021C4 RID: 8644 RVA: 0x00091BDC File Offset: 0x0008FDDC
	private static byte 17(byte 1, byte 2)
	{
		return (byte)((int)1 << (int)2 | 1 >> (int)(8 - 2));
	}

	// Token: 0x060021C5 RID: 8645 RVA: 0x00091BEE File Offset: 0x0008FDEE
	private static byte 18(byte 1, byte 2)
	{
		return (byte)(1 >> (int)2 | (int)1 << (int)(8 - 2));
	}

	// Token: 0x04001726 RID: 5926
	private uint[] 1;

	// Token: 0x04001727 RID: 5927
	public 594 2 = (594)3;

	// Token: 0x04001728 RID: 5928
	private uint 3;
}
