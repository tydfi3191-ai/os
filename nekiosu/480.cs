using System;
using System.Runtime.InteropServices;

// Token: 0x020002F1 RID: 753
[ComVisible(false)]
public sealed class 480 : EventArgs
{
	// Token: 0x0600168C RID: 5772 RVA: 0x0004E00D File Offset: 0x0004C20D
	public 480(string 1)
	{
		this.text2 = 1;
	}

	// Token: 0x0600168D RID: 5773 RVA: 0x0004E01C File Offset: 0x0004C21C
	public 480(string 1, byte[] 2)
	{
		this.text2 = 1;
		this.byteArray2 = 2;
	}

	// Token: 0x0600168E RID: 5774 RVA: 0x0004E032 File Offset: 0x0004C232
	public string GetText3607_4590()
	{
		return this.text2;
	}

	// Token: 0x0600168F RID: 5775 RVA: 0x0004E03A File Offset: 0x0004C23A
	public byte[] GetByteArray3608_4591()
	{
		return this.byteArray2;
	}

	// Token: 0x06001690 RID: 5776 RVA: 0x0004E042 File Offset: 0x0004C242
	public void SetByteArray3608_4592(byte[] 1)
	{
		this.byteArray2 = 1;
	}

	// Token: 0x04000A99 RID: 2713
	private string text2;

	// Token: 0x04000A9A RID: 2714
	private byte[] byteArray2;
}
