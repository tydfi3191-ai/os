using System;

// Token: 0x02000226 RID: 550
public struct 726
{
	// Token: 0x06001122 RID: 4386 RVA: 0x0003D656 File Offset: 0x0003B856
	public void Method11267(int 1, uint 2)
	{
		if (2 == 0U)
		{
			this.number3 += 2048U - this.number3 >> 1;
			return;
		}
		this.number3 -= this.number3 >> 1;
	}

	// Token: 0x06001123 RID: 4387 RVA: 0x0003D692 File Offset: 0x0003B892
	public void SetNumber8943_11268()
	{
		this.number3 = 1024U;
	}

	// Token: 0x06001124 RID: 4388 RVA: 0x0003D6A0 File Offset: 0x0003B8A0
	public uint Method11269(281 1)
	{
		uint num = (1.range >> 11) * this.number3;
		if (1.code < num)
		{
			1.range = num;
			this.number3 += 2048U - this.number3 >> 5;
			if (1.range < 16777216U)
			{
				1.code = (1.code << 8 | (uint)((byte)1.inputStream.ReadByte()));
				1.range <<= 8;
			}
			return 0U;
		}
		1.range -= num;
		1.code -= num;
		this.number3 -= this.number3 >> 5;
		if (1.range < 16777216U)
		{
			1.code = (1.code << 8 | (uint)((byte)1.inputStream.ReadByte()));
			1.range <<= 8;
		}
		return 1U;
	}

	// Token: 0x04000895 RID: 2197
	private uint number3;
}
