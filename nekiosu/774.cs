using System;

// Token: 0x02000229 RID: 553
public struct 774
{
	// Token: 0x06001126 RID: 4390 RVA: 0x0003D789 File Offset: 0x0003B989
	public 774(int 1)
	{
		this.number4 = 1;
		this.lzmaBitModelArray2 = new 180[1 << 1];
	}

	// Token: 0x06001127 RID: 4391 RVA: 0x0003D7A4 File Offset: 0x0003B9A4
	public void Method12690()
	{
		uint num = 1U;
		while ((ulong)num < (ulong)(1L << (this.number4 & 31)))
		{
			this.lzmaBitModelArray2[(int)num].Init();
			num += 1U;
		}
	}

	// Token: 0x06001128 RID: 4392 RVA: 0x0003D7DC File Offset: 0x0003B9DC
	public void Method12691(194 1, uint 2)
	{
		uint num = 1U;
		int i = this.number4;
		while (i > 0)
		{
			i--;
			uint num2 = 2 >> i & 1U;
			this.lzmaBitModelArray2[(int)num].Encode(1, num2);
			num = (num << 1 | num2);
		}
	}

	// Token: 0x06001129 RID: 4393 RVA: 0x0003D820 File Offset: 0x0003BA20
	public void Method12692(194 1, uint 2)
	{
		uint num = 1U;
		uint num2 = 0U;
		while ((ulong)num2 < (ulong)((long)this.number4))
		{
			uint num3 = 2 & 1U;
			this.lzmaBitModelArray2[(int)num].Encode(1, num3);
			num = (num << 1 | num3);
			2 >>= 1;
			num2 += 1U;
		}
	}

	// Token: 0x0600112A RID: 4394 RVA: 0x0003D864 File Offset: 0x0003BA64
	public uint Method12693(uint 1)
	{
		uint num = 0U;
		uint num2 = 1U;
		int i = this.number4;
		while (i > 0)
		{
			i--;
			uint num3 = 1 >> i & 1U;
			num += this.lzmaBitModelArray2[(int)num2].GetPrice(num3);
			num2 = (num2 << 1) + num3;
		}
		return num;
	}

	// Token: 0x0600112B RID: 4395 RVA: 0x0003D8AC File Offset: 0x0003BAAC
	public uint Method12694(uint 1)
	{
		uint num = 0U;
		uint num2 = 1U;
		for (int i = this.number4; i > 0; i--)
		{
			uint num3 = 1 & 1U;
			1 >>= 1;
			num += this.lzmaBitModelArray2[(int)num2].GetPrice(num3);
			num2 = (num2 << 1 | num3);
		}
		return num;
	}

	// Token: 0x0600112C RID: 4396 RVA: 0x0003D8F4 File Offset: 0x0003BAF4
	public static uint Method12694(180[] 1, uint 2, int 3, uint 4)
	{
		uint num = 0U;
		uint num2 = 1U;
		for (int i = 3; i > 0; i--)
		{
			uint num3 = 4 & 1U;
			4 >>= 1;
			num += 1[(int)(2 + num2)].GetPrice(num3);
			num2 = (num2 << 1 | num3);
		}
		return num;
	}

	// Token: 0x0600112D RID: 4397 RVA: 0x0003D934 File Offset: 0x0003BB34
	public static void Method12692(180[] 1, uint 2, 194 3, int 4, uint 5)
	{
		uint num = 1U;
		for (int i = 0; i < 4; i++)
		{
			uint num2 = 5 & 1U;
			1[(int)(2 + num)].Encode(3, num2);
			num = (num << 1 | num2);
			5 >>= 1;
		}
	}

	// Token: 0x04000897 RID: 2199
	private 180[] lzmaBitModelArray2;

	// Token: 0x04000898 RID: 2200
	private int number4;
}
