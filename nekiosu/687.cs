using System;
using System.Runtime.InteropServices;

// Token: 0x0200030E RID: 782
[ComVisible(false)]
public class 687
{
	// Token: 0x06001770 RID: 6000 RVA: 0x00050BF6 File Offset: 0x0004EDF6
	public 687() : this(4096)
	{
	}

	// Token: 0x06001771 RID: 6001 RVA: 0x00050C03 File Offset: 0x0004EE03
	public 687(int 1)
	{
		this.byteArray2 = new byte[1];
	}

	// Token: 0x06001772 RID: 6002 RVA: 0x00050C18 File Offset: 0x0004EE18
	public void SetNumber8068_10315()
	{
		this.number3 = (this.number4 = (this.number6 = 0));
	}

	// Token: 0x06001773 RID: 6003 RVA: 0x00050C40 File Offset: 0x0004EE40
	public void Method10316(int 1)
	{
		byte[] array = this.byteArray2;
		int num = this.number4;
		this.number4 = num + 1;
		array[num] = (byte)1;
	}

	// Token: 0x06001774 RID: 6004 RVA: 0x00050C68 File Offset: 0x0004EE68
	public void Method10317(int 1)
	{
		byte[] array = this.byteArray2;
		int num = this.number4;
		this.number4 = num + 1;
		array[num] = (byte)1;
		byte[] array2 = this.byteArray2;
		num = this.number4;
		this.number4 = num + 1;
		array2[num] = (byte)(1 >> 8);
	}

	// Token: 0x06001775 RID: 6005 RVA: 0x00050CAC File Offset: 0x0004EEAC
	public void Method10318(int 1)
	{
		byte[] array = this.byteArray2;
		int num = this.number4;
		this.number4 = num + 1;
		array[num] = (byte)1;
		byte[] array2 = this.byteArray2;
		num = this.number4;
		this.number4 = num + 1;
		array2[num] = (byte)(1 >> 8);
		byte[] array3 = this.byteArray2;
		num = this.number4;
		this.number4 = num + 1;
		array3[num] = (byte)(1 >> 16);
		byte[] array4 = this.byteArray2;
		num = this.number4;
		this.number4 = num + 1;
		array4[num] = (byte)(1 >> 24);
	}

	// Token: 0x06001776 RID: 6006 RVA: 0x00050D29 File Offset: 0x0004EF29
	public void Method10319(byte[] 1, int 2, int 3)
	{
		Array.Copy(1, 2, this.byteArray2, this.number4, 3);
		this.number4 += 3;
	}

	// Token: 0x06001777 RID: 6007 RVA: 0x00050D4D File Offset: 0x0004EF4D
	public int GetNumber8071_10320()
	{
		return this.number6;
	}

	// Token: 0x06001778 RID: 6008 RVA: 0x00050D58 File Offset: 0x0004EF58
	public void Method10321()
	{
		if (this.number6 > 0)
		{
			byte[] array = this.byteArray2;
			int num = this.number4;
			this.number4 = num + 1;
			array[num] = (byte)this.number5;
			if (this.number6 > 8)
			{
				byte[] array2 = this.byteArray2;
				num = this.number4;
				this.number4 = num + 1;
				array2[num] = (byte)(this.number5 >> 8);
			}
		}
		this.number5 = 0U;
		this.number6 = 0;
	}

	// Token: 0x06001779 RID: 6009 RVA: 0x00050DC8 File Offset: 0x0004EFC8
	public void Method10322(int 1, int 2)
	{
		this.number5 |= (uint)((uint)1 << this.number6);
		this.number6 += 2;
		if (this.number6 >= 16)
		{
			byte[] array = this.byteArray2;
			int num = this.number4;
			this.number4 = num + 1;
			array[num] = (byte)this.number5;
			byte[] array2 = this.byteArray2;
			num = this.number4;
			this.number4 = num + 1;
			array2[num] = (byte)(this.number5 >> 8);
			this.number5 >>= 16;
			this.number6 -= 16;
		}
	}

	// Token: 0x0600177A RID: 6010 RVA: 0x00050E64 File Offset: 0x0004F064
	public void Method10323(int 1)
	{
		byte[] array = this.byteArray2;
		int num = this.number4;
		this.number4 = num + 1;
		array[num] = (byte)(1 >> 8);
		byte[] array2 = this.byteArray2;
		num = this.number4;
		this.number4 = num + 1;
		array2[num] = (byte)1;
	}

	// Token: 0x0600177B RID: 6011 RVA: 0x00050EA7 File Offset: 0x0004F0A7
	public bool Method10324()
	{
		return this.number4 == 0;
	}

	// Token: 0x0600177C RID: 6012 RVA: 0x00050EB4 File Offset: 0x0004F0B4
	public int Method10325(byte[] 1, int 2, int 3)
	{
		if (this.number6 >= 8)
		{
			byte[] array = this.byteArray2;
			int num = this.number4;
			this.number4 = num + 1;
			array[num] = (byte)this.number5;
			this.number5 >>= 8;
			this.number6 -= 8;
		}
		if (3 > this.number4 - this.number3)
		{
			3 = this.number4 - this.number3;
			Array.Copy(this.byteArray2, this.number3, 1, 2, 3);
			this.number3 = 0;
			this.number4 = 0;
		}
		else
		{
			Array.Copy(this.byteArray2, this.number3, 1, 2, 3);
			this.number3 += 3;
		}
		return 3;
	}

	// Token: 0x0600177D RID: 6013 RVA: 0x00050F6C File Offset: 0x0004F16C
	public byte[] Method10326()
	{
		byte[] array = new byte[this.number4 - this.number3];
		Array.Copy(this.byteArray2, this.number3, array, 0, array.Length);
		this.number3 = 0;
		this.number4 = 0;
		return array;
	}

	// Token: 0x04000AEF RID: 2799
	private byte[] byteArray2;

	// Token: 0x04000AF0 RID: 2800
	private int number3;

	// Token: 0x04000AF1 RID: 2801
	private int number4;

	// Token: 0x04000AF2 RID: 2802
	private uint number5;

	// Token: 0x04000AF3 RID: 2803
	private int number6;
}
