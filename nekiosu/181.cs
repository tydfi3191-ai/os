using System;

// Token: 0x0200020D RID: 525
public struct 181
{
	// Token: 0x06001089 RID: 4233 RVA: 0x00038C96 File Offset: 0x00036E96
	public 181(int 1)
	{
		this.numBitLevels = 1;
		this.probs = new 726[1 << 1];
	}

	// Token: 0x0600108A RID: 4234 RVA: 0x00038CB0 File Offset: 0x00036EB0
	public void Init()
	{
		uint num = 1U;
		while ((ulong)num < (ulong)(1L << (this.numBitLevels & 31)))
		{
			this.probs[(int)num].SetNumber8943_11268();
			num += 1U;
		}
	}

	// Token: 0x0600108B RID: 4235 RVA: 0x00038CE8 File Offset: 0x00036EE8
	public uint Decode(281 1)
	{
		uint num = 1U;
		for (int i = this.numBitLevels; i > 0; i--)
		{
			num = (num << 1) + this.probs[(int)num].Method11269(1);
		}
		return num - (1U << this.numBitLevels);
	}

	// Token: 0x0600108C RID: 4236 RVA: 0x00038D2C File Offset: 0x00036F2C
	public uint Method5030(281 1)
	{
		uint num = 1U;
		uint num2 = 0U;
		for (int i = 0; i < this.numBitLevels; i++)
		{
			uint num3 = this.probs[(int)num].Method11269(1);
			num <<= 1;
			num += num3;
			num2 |= num3 << i;
		}
		return num2;
	}

	// Token: 0x0600108D RID: 4237 RVA: 0x00038D74 File Offset: 0x00036F74
	public static uint Method5030(726[] 1, uint 2, 281 3, int 4)
	{
		uint num = 1U;
		uint num2 = 0U;
		for (int i = 0; i < 4; i++)
		{
			uint num3 = 1[(int)(2 + num)].Method11269(3);
			num <<= 1;
			num += num3;
			num2 |= num3 << i;
		}
		return num2;
	}

	// Token: 0x04000806 RID: 2054
	private 726[] probs;

	// Token: 0x04000807 RID: 2055
	private int numBitLevels;
}
