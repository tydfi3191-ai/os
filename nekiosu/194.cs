using System;
using System.IO;

// Token: 0x0200021A RID: 538
public sealed class 194
{
	// Token: 0x060010E1 RID: 4321 RVA: 0x0003C5BC File Offset: 0x0003A7BC
	public void SetStream(Stream 1)
	{
		this.outputStream = 1;
	}

	// Token: 0x060010E2 RID: 4322 RVA: 0x0003C5C5 File Offset: 0x0003A7C5
	public void ReleaseStream()
	{
		this.outputStream = null;
	}

	// Token: 0x060010E3 RID: 4323 RVA: 0x0003C5CE File Offset: 0x0003A7CE
	public void Init()
	{
		this.startPosition = this.outputStream.Position;
		this.low = 0UL;
		this.range = uint.MaxValue;
		this.cacheSize = 1U;
		this.cache = 0;
	}

	// Token: 0x060010E4 RID: 4324 RVA: 0x0003C600 File Offset: 0x0003A800
	public void FlushData()
	{
		for (int i = 0; i < 5; i++)
		{
			this.ShiftLow();
		}
	}

	// Token: 0x060010E5 RID: 4325 RVA: 0x0003C61F File Offset: 0x0003A81F
	public void FlushStream()
	{
		this.outputStream.Flush();
	}

	// Token: 0x060010E6 RID: 4326 RVA: 0x0003C62C File Offset: 0x0003A82C
	public void CloseStream()
	{
		this.outputStream.Close();
	}

	// Token: 0x060010E7 RID: 4327 RVA: 0x0003C63C File Offset: 0x0003A83C
	public void Encode(uint 1, uint 2, uint 3)
	{
		this.low += (ulong)(1 * (this.range /= 3));
		this.range *= 2;
		while (this.range < 16777216U)
		{
			this.range <<= 8;
			this.ShiftLow();
		}
	}

	// Token: 0x060010E8 RID: 4328 RVA: 0x0003C69C File Offset: 0x0003A89C
	public void ShiftLow()
	{
		if ((uint)this.low < 4278190080U || (int)(this.low >> 32) == 1)
		{
			byte maxValue = this.cache;
			uint num;
			do
			{
				this.outputStream.WriteByte((byte)((ulong)maxValue + (this.low >> 32)));
				maxValue = byte.MaxValue;
				num = this.cacheSize - 1U;
				this.cacheSize = num;
			}
			while (num != 0U);
			this.cache = (byte)((uint)this.low >> 24);
		}
		this.cacheSize += 1U;
		this.low = (ulong)((ulong)((int)this.low) << 8);
	}

	// Token: 0x060010E9 RID: 4329 RVA: 0x0003C72C File Offset: 0x0003A92C
	public void EncodeDirectBits(uint 1, int 2)
	{
		for (int i = 2 - 1; i >= 0; i--)
		{
			this.range >>= 1;
			if ((1 >> i & 1U) == 1U)
			{
				this.low += (ulong)this.range;
			}
			if (this.range < 16777216U)
			{
				this.range <<= 8;
				this.ShiftLow();
			}
		}
	}

	// Token: 0x060010EA RID: 4330 RVA: 0x0003C798 File Offset: 0x0003A998
	public void EncodeBit(uint 1, int 2, uint 3)
	{
		uint num = (this.range >> 2) * 1;
		if (3 == 0U)
		{
			this.range = num;
		}
		else
		{
			this.low += (ulong)num;
			this.range -= num;
		}
		while (this.range < 16777216U)
		{
			this.range <<= 8;
			this.ShiftLow();
		}
	}

	// Token: 0x060010EB RID: 4331 RVA: 0x0003C7FF File Offset: 0x0003A9FF
	public long GetProcessedSizeAdd()
	{
		return (long)((ulong)this.cacheSize + (ulong)this.outputStream.Position - (ulong)this.startPosition + 4UL);
	}

	// Token: 0x04000879 RID: 2169
	private Stream outputStream;

	// Token: 0x0400087A RID: 2170
	public ulong low;

	// Token: 0x0400087B RID: 2171
	public uint range;

	// Token: 0x0400087C RID: 2172
	private uint cacheSize;

	// Token: 0x0400087D RID: 2173
	private byte cache;

	// Token: 0x0400087E RID: 2174
	private long startPosition;
}
