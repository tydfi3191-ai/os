using System;
using System.Runtime.InteropServices;

// Token: 0x02000BC5 RID: 3013
[ComVisible(false)]
public class 1193
{
	// Token: 0x060052DC RID: 21212 RVA: 0x002093CC File Offset: 0x002075CC
	public 1193()
	{
		this.1(Environment.TickCount);
	}

	// Token: 0x060052DD RID: 21213 RVA: 0x002093E7 File Offset: 0x002075E7
	public 1193(int 1)
	{
		this.1(1);
	}

	// Token: 0x060052DE RID: 21214 RVA: 0x002093FE File Offset: 0x002075FE
	public void 1(int 1)
	{
		this.2 = (uint)1;
		this.3 = 842502087U;
		this.4 = 3579807591U;
		this.1 = 273326509U;
		this.6 = 32;
	}

	// Token: 0x060052DF RID: 21215 RVA: 0x00209430 File Offset: 0x00207630
	public uint 2()
	{
		uint num = this.2 ^ this.2 << 11;
		this.2 = this.3;
		this.3 = this.4;
		this.4 = this.1;
		return this.1 = (this.1 ^ this.1 >> 19 ^ (num ^ num >> 8));
	}

	// Token: 0x060052E0 RID: 21216 RVA: 0x00209494 File Offset: 0x00207694
	public int Next()
	{
		uint num = this.2 ^ this.2 << 11;
		this.2 = this.3;
		this.3 = this.4;
		this.4 = this.1;
		return (int)(2147483647U & (this.1 = (this.1 ^ this.1 >> 19 ^ (num ^ num >> 8))));
	}

	// Token: 0x060052E1 RID: 21217 RVA: 0x002094FC File Offset: 0x002076FC
	public int Next(int 1)
	{
		if (1 < 0)
		{
			throw new ArgumentOutOfRangeException("upperBound", 1, "upperBound must be >=0");
		}
		uint num = this.2 ^ this.2 << 11;
		this.2 = this.3;
		this.3 = this.4;
		this.4 = this.1;
		return (int)(4.656612873077393E-10 * (double)(2147483647U & (this.1 = (this.1 ^ this.1 >> 19 ^ (num ^ num >> 8)))) * (double)1);
	}

	// Token: 0x060052E2 RID: 21218 RVA: 0x0020958C File Offset: 0x0020778C
	public int Next(int 1, int 2)
	{
		if (1 > 2)
		{
			throw new ArgumentOutOfRangeException("upperBound", 2, "upperBound must be >=lowerBound");
		}
		uint num = this.2 ^ this.2 << 11;
		this.2 = this.3;
		this.3 = this.4;
		this.4 = this.1;
		int num2 = 2 - 1;
		if (num2 < 0)
		{
			return 1 + (int)(2.3283064365386963E-10 * (this.1 = (this.1 ^ this.1 >> 19 ^ (num ^ num >> 8))) * (double)((long)2 - (long)1));
		}
		return 1 + (int)(4.656612873077393E-10 * (double)(2147483647U & (this.1 = (this.1 ^ this.1 >> 19 ^ (num ^ num >> 8)))) * (double)num2);
	}

	// Token: 0x060052E3 RID: 21219 RVA: 0x0020965C File Offset: 0x0020785C
	public double 3()
	{
		uint num = this.2 ^ this.2 << 11;
		this.2 = this.3;
		this.3 = this.4;
		this.4 = this.1;
		return 4.656612873077393E-10 * (double)(2147483647U & (this.1 = (this.1 ^ this.1 >> 19 ^ (num ^ num >> 8))));
	}

	// Token: 0x060052E4 RID: 21220 RVA: 0x002096D0 File Offset: 0x002078D0
	public void 4(byte[] 1)
	{
		uint num = this.2;
		uint num2 = this.3;
		uint num3 = this.4;
		uint num4 = this.1;
		int i = 0;
		while (i < 1.Length - 3)
		{
			uint num5 = num ^ num << 11;
			num = num2;
			num2 = num3;
			num3 = num4;
			num4 = (num4 ^ num4 >> 19 ^ (num5 ^ num5 >> 8));
			1[i++] = (byte)num4;
			1[i++] = (byte)((num4 & 65280U) >> 8);
			1[i++] = (byte)((num4 & 16711680U) >> 16);
			1[i++] = (byte)((num4 & 4278190080U) >> 24);
		}
		if (i < 1.Length)
		{
			uint num6 = num ^ num << 11;
			num = num2;
			num2 = num3;
			num3 = num4;
			num4 = (num4 ^ num4 >> 19 ^ (num6 ^ num6 >> 8));
			1[i++] = (byte)num4;
			if (i < 1.Length)
			{
				1[i++] = (byte)((num4 & 65280U) >> 8);
				if (i < 1.Length)
				{
					1[i++] = (byte)((num4 & 16711680U) >> 16);
					if (i < 1.Length)
					{
						1[i] = (byte)((num4 & 4278190080U) >> 24);
					}
				}
			}
		}
		this.2 = num;
		this.3 = num2;
		this.4 = num3;
		this.1 = num4;
	}

	// Token: 0x060052E5 RID: 21221 RVA: 0x00209800 File Offset: 0x00207A00
	public bool 5()
	{
		if (this.6 == 32)
		{
			uint num = this.2 ^ this.2 << 11;
			this.2 = this.3;
			this.3 = this.4;
			this.4 = this.1;
			this.5 = (this.1 = (this.1 ^ this.1 >> 19 ^ (num ^ num >> 8)));
			this.6 = 1;
			return (this.5 & 1U) == 1U;
		}
		this.6++;
		return ((this.5 >>= 1) & 1U) == 1U;
	}

	// Token: 0x04003F13 RID: 16147
	public uint 1;

	// Token: 0x04003F14 RID: 16148
	public uint 2;

	// Token: 0x04003F15 RID: 16149
	public uint 3;

	// Token: 0x04003F16 RID: 16150
	public uint 4;

	// Token: 0x04003F17 RID: 16151
	private uint 5;

	// Token: 0x04003F18 RID: 16152
	private int 6 = 32;
}
