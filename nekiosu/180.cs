using System;

// Token: 0x0200020C RID: 524
public struct 180
{
	// Token: 0x06001082 RID: 4226 RVA: 0x00038B10 File Offset: 0x00036D10
	static 180()
	{
		for (int i = 8; i >= 0; i--)
		{
			uint num = 1U << 9 - i - 1;
			uint num2 = 1U << 9 - i;
			for (uint num3 = num; num3 < num2; num3 += 1U)
			{
				180.probPrices[(int)num3] = (uint)((i << 6) + (int)(num2 - num3 << 6 >> 9 - i - 1));
			}
		}
	}

	// Token: 0x06001083 RID: 4227 RVA: 0x00038B72 File Offset: 0x00036D72
	public void Init()
	{
		this.probability = 1024U;
	}

	// Token: 0x06001084 RID: 4228 RVA: 0x00038B7F File Offset: 0x00036D7F
	public void UpdateModel(uint 1)
	{
		if (1 == 0U)
		{
			this.probability += 2048U - this.probability >> 5;
			return;
		}
		this.probability -= this.probability >> 5;
	}

	// Token: 0x06001085 RID: 4229 RVA: 0x00038BB8 File Offset: 0x00036DB8
	public void Encode(194 1, uint 2)
	{
		uint num = (1.range >> 11) * this.probability;
		if (2 == 0U)
		{
			1.range = num;
			this.probability += 2048U - this.probability >> 5;
		}
		else
		{
			1.low += (ulong)num;
			1.range -= num;
			this.probability -= this.probability >> 5;
		}
		if (1.range < 16777216U)
		{
			1.range <<= 8;
			1.ShiftLow();
		}
	}

	// Token: 0x06001086 RID: 4230 RVA: 0x00038C50 File Offset: 0x00036E50
	public uint GetPrice(uint 1)
	{
		return 180.probPrices[(int)(checked((IntPtr)((unchecked((ulong)(this.probability - 1) ^ (ulong)((long)(0U - 1))) & 2047UL) >> 2)))];
	}

	// Token: 0x06001087 RID: 4231 RVA: 0x00038C70 File Offset: 0x00036E70
	public uint GetPrice0()
	{
		return 180.probPrices[(int)(this.probability >> 2)];
	}

	// Token: 0x06001088 RID: 4232 RVA: 0x00038C80 File Offset: 0x00036E80
	public uint GetPrice1()
	{
		return 180.probPrices[(int)(2048U - this.probability >> 2)];
	}

	// Token: 0x04000804 RID: 2052
	private uint probability;

	// Token: 0x04000805 RID: 2053
	private static uint[] probPrices = new uint[512];
}
