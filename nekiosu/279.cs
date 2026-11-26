using System;

// Token: 0x020002DA RID: 730
public class 279
{
	// Token: 0x060015E8 RID: 5608 RVA: 0x0004BB1A File Offset: 0x00049D1A
	protected byte DecryptByte()
	{
		uint num = (this.keys[2] & 65535U) | 2U;
		return (byte)(num * (num ^ 1U) >> 8);
	}

	// Token: 0x060015E9 RID: 5609 RVA: 0x0004BB34 File Offset: 0x00049D34
	protected void SetKey(byte[] 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=z0FMnxgg=");
		}
		if (1.Length != 12)
		{
			throw new InvalidOperationException("Key length is not valid");
		}
		this.keys = new uint[3];
		this.keys[0] = (uint)((int)1[3] << 24 | (int)1[2] << 16 | (int)1[1] << 8 | (int)1[0]);
		this.keys[1] = (uint)((int)1[7] << 24 | (int)1[6] << 16 | (int)1[5] << 8 | (int)1[4]);
		this.keys[2] = (uint)((int)1[11] << 24 | (int)1[10] << 16 | (int)1[9] << 8 | (int)1[8]);
	}

	// Token: 0x060015EA RID: 5610 RVA: 0x0004BBD0 File Offset: 0x00049DD0
	protected void UpdateKeys(byte 1)
	{
		this.keys[0] = 597.Method8131(this.keys[0], 1);
		this.keys[1] = this.keys[1] + (uint)((byte)this.keys[0]);
		this.keys[1] = this.keys[1] * 134775813U + 1U;
		this.keys[2] = 597.Method8131(this.keys[2], (byte)(this.keys[1] >> 24));
	}

	// Token: 0x060015EB RID: 5611 RVA: 0x0004BC46 File Offset: 0x00049E46
	protected void ClearKeys()
	{
		this.keys[0] = 0U;
		this.keys[1] = 0U;
		this.keys[2] = 0U;
	}

	// Token: 0x04000A5F RID: 2655
	private uint[] keys;
}
