using System;
using System.IO;

// Token: 0x0200021B RID: 539
public sealed class 281
{
	// Token: 0x060010ED RID: 4333 RVA: 0x0003C820 File Offset: 0x0003AA20
	public void Init(Stream 1)
	{
		this.inputStream = 1;
		this.code = 0U;
		this.range = uint.MaxValue;
		for (int i = 0; i < 5; i++)
		{
			this.code = (this.code << 8 | (uint)((byte)this.inputStream.ReadByte()));
		}
	}

	// Token: 0x060010EE RID: 4334 RVA: 0x0003C869 File Offset: 0x0003AA69
	public void ReleaseStream()
	{
		this.inputStream = null;
	}

	// Token: 0x060010EF RID: 4335 RVA: 0x0003C872 File Offset: 0x0003AA72
	public void CloseStream()
	{
		this.inputStream.Close();
	}

	// Token: 0x060010F0 RID: 4336 RVA: 0x0003C87F File Offset: 0x0003AA7F
	public void Normalize()
	{
		while (this.range < 16777216U)
		{
			this.code = (this.code << 8 | (uint)((byte)this.inputStream.ReadByte()));
			this.range <<= 8;
		}
	}

	// Token: 0x060010F1 RID: 4337 RVA: 0x0003C8B9 File Offset: 0x0003AAB9
	public void Method3715()
	{
		if (this.range < 16777216U)
		{
			this.code = (this.code << 8 | (uint)((byte)this.inputStream.ReadByte()));
			this.range <<= 8;
		}
	}

	// Token: 0x060010F2 RID: 4338 RVA: 0x0003C8F4 File Offset: 0x0003AAF4
	public uint GetThreshold(uint 1)
	{
		return this.code / (this.range /= 1);
	}

	// Token: 0x060010F3 RID: 4339 RVA: 0x0003C919 File Offset: 0x0003AB19
	public void Decode(uint 1, uint 2, uint 3)
	{
		this.code -= 1 * this.range;
		this.range *= 2;
		this.Normalize();
	}

	// Token: 0x060010F4 RID: 4340 RVA: 0x0003C944 File Offset: 0x0003AB44
	public uint DecodeDirectBits(int 1)
	{
		uint num = this.range;
		uint num2 = this.code;
		uint num3 = 0U;
		for (int i = 1; i > 0; i--)
		{
			num >>= 1;
			uint num4 = num2 - num >> 31;
			num2 -= (num & num4 - 1U);
			num3 = (num3 << 1 | 1U - num4);
			if (num < 16777216U)
			{
				num2 = (num2 << 8 | (uint)((byte)this.inputStream.ReadByte()));
				num <<= 8;
			}
		}
		this.range = num;
		this.code = num2;
		return num3;
	}

	// Token: 0x060010F5 RID: 4341 RVA: 0x0003C9B8 File Offset: 0x0003ABB8
	public uint DecodeBit(uint 1, int 2)
	{
		uint num = (this.range >> 2) * 1;
		uint result;
		if (this.code < num)
		{
			result = 0U;
			this.range = num;
		}
		else
		{
			result = 1U;
			this.code -= num;
			this.range -= num;
		}
		this.Normalize();
		return result;
	}

	// Token: 0x0400087F RID: 2175
	public uint range;

	// Token: 0x04000880 RID: 2176
	public uint code;

	// Token: 0x04000881 RID: 2177
	public Stream inputStream;
}
