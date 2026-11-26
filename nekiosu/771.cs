using System;
using System.Runtime.InteropServices;

// Token: 0x02000320 RID: 800
[ComVisible(false)]
public sealed class 771 : 712
{
	// Token: 0x06001817 RID: 6167 RVA: 0x0005471A File Offset: 0x0005291A
	public 771(short 1)
	{
		this.intValue2 = 1;
	}

	// Token: 0x06001818 RID: 6168 RVA: 0x00054729 File Offset: 0x00052929
	public short GetInt169818_12597()
	{
		return this.intValue2;
	}

	// Token: 0x06001819 RID: 6169 RVA: 0x00054731 File Offset: 0x00052931
	public void SetInt169818_12598(short 1)
	{
		this.intValue2 = 1;
	}

	// Token: 0x0600181A RID: 6170 RVA: 0x0005473A File Offset: 0x0005293A
	public void Method12599(byte[] 1, int 2, int 3)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=z6rP0_lg=");
		}
		this.byteArray2 = new byte[3];
		Array.Copy(1, 2, this.byteArray2, 0, 3);
	}

	// Token: 0x0600181B RID: 6171 RVA: 0x00054765 File Offset: 0x00052965
	public byte[] GetByteArray9819_12600()
	{
		return this.byteArray2;
	}

	// Token: 0x0600181C RID: 6172 RVA: 0x00054765 File Offset: 0x00052965
	public byte[] GetByteArray9819_12601()
	{
		return this.byteArray2;
	}

	// Token: 0x0600181D RID: 6173 RVA: 0x0005476D File Offset: 0x0005296D
	public void SetByteArray9819_12602(byte[] 1)
	{
		this.byteArray2 = 1;
	}

	// Token: 0x04000B3F RID: 2879
	private short intValue2;

	// Token: 0x04000B40 RID: 2880
	private byte[] byteArray2;
}
