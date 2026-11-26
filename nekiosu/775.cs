using System;
using System.Runtime.InteropServices;

// Token: 0x0200034C RID: 844
[ComVisible(false)]
public sealed class 775
{
	// Token: 0x06001A35 RID: 6709 RVA: 0x00062178 File Offset: 0x00060378
	static 775()
	{
		for (uint num = 0U; num < 256U; num += 1U)
		{
			uint num2 = num;
			for (int i = 0; i < 8; i++)
			{
				num2 = (((num2 & 1U) == 0U) ? (num2 >> 1) : (num2 >> 1 ^ 3988292384U));
			}
			775.numberArray[(int)num] = num2;
		}
	}

	// Token: 0x06001A36 RID: 6710 RVA: 0x000621CE File Offset: 0x000603CE
	public void SetNumber9948_12714()
	{
		this.number4 = uint.MaxValue;
	}

	// Token: 0x06001A37 RID: 6711 RVA: 0x000621D7 File Offset: 0x000603D7
	public void SetNumber9948_12715(byte 1)
	{
		this.number4 = (775.numberArray[(int)((byte)this.number4 ^ 1)] ^ this.number4 >> 8);
	}

	// Token: 0x06001A38 RID: 6712 RVA: 0x000621F8 File Offset: 0x000603F8
	public void Method12716(byte[] 1, uint 2, uint 3)
	{
		for (uint num = 0U; num < 3; num += 1U)
		{
			this.number4 = (775.numberArray[(int)((byte)this.number4 ^ 1[(int)(2 + num)])] ^ this.number4 >> 8);
		}
	}

	// Token: 0x06001A39 RID: 6713 RVA: 0x00062233 File Offset: 0x00060433
	public uint Method12717()
	{
		return this.number4 ^ uint.MaxValue;
	}

	// Token: 0x06001A3A RID: 6714 RVA: 0x0006223D File Offset: 0x0006043D
	private static uint Method12718(byte[] 1, uint 2, uint 3)
	{
		775 4 = new 775();
		4.Method12716(1, 2, 3);
		return 4.Method12717();
	}

	// Token: 0x06001A3B RID: 6715 RVA: 0x00062252 File Offset: 0x00060452
	private static bool Method12719(uint 1, byte[] 2, uint 3, uint 4)
	{
		return 775.Method12718(2, 3, 4) == 1;
	}

	// Token: 0x04000C71 RID: 3185
	public static readonly uint[] numberArray = new uint[256];

	// Token: 0x04000C72 RID: 3186
	private uint number4 = uint.MaxValue;
}
