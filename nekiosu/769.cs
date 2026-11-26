using System;
using System.Runtime.InteropServices;

// Token: 0x0200031F RID: 799
[ComVisible(false)]
public sealed class 769
{
	// Token: 0x0600180C RID: 6156 RVA: 0x00054408 File Offset: 0x00052608
	public int Method12418(int 1)
	{
		if (this.number6 < 1)
		{
			if (this.number3 == this.number4)
			{
				return -1;
			}
			uint num = this.number5;
			byte[] array = this.byteArray2;
			int num2 = this.number3;
			this.number3 = num2 + 1;
			uint num3 = array[num2] & 255U;
			byte[] array2 = this.byteArray2;
			num2 = this.number3;
			this.number3 = num2 + 1;
			this.number5 = (num | (num3 | (array2[num2] & 255U) << 8) << this.number6);
			this.number6 += 16;
		}
		return (int)((ulong)this.number5 & (ulong)((long)((1 << 1) - 1)));
	}

	// Token: 0x0600180D RID: 6157 RVA: 0x000544A5 File Offset: 0x000526A5
	public void Method12419(int 1)
	{
		this.number5 >>= 1;
		this.number6 -= 1;
	}

	// Token: 0x0600180E RID: 6158 RVA: 0x000544C6 File Offset: 0x000526C6
	public int Method12420(int 1)
	{
		int num = this.Method12418(1);
		if (num >= 0)
		{
			this.Method12419(1);
		}
		return num;
	}

	// Token: 0x0600180F RID: 6159 RVA: 0x000544DA File Offset: 0x000526DA
	public int GetNumber9699_12421()
	{
		return this.number6;
	}

	// Token: 0x06001810 RID: 6160 RVA: 0x000544E2 File Offset: 0x000526E2
	public int Method12422()
	{
		return this.number4 - this.number3 + (this.number6 >> 3);
	}

	// Token: 0x06001811 RID: 6161 RVA: 0x000544FA File Offset: 0x000526FA
	public void Method12423()
	{
		this.number5 >>= (this.number6 & 7);
		this.number6 &= -8;
	}

	// Token: 0x06001812 RID: 6162 RVA: 0x00054523 File Offset: 0x00052723
	public bool Method12424()
	{
		return this.number3 == this.number4;
	}

	// Token: 0x06001813 RID: 6163 RVA: 0x00054534 File Offset: 0x00052734
	public int Method12425(byte[] 1, int 2, int 3)
	{
		if (3 < 0)
		{
			throw new ArgumentOutOfRangeException("#=zidzotuw=");
		}
		if ((this.number6 & 7) != 0)
		{
			throw new InvalidOperationException("Bit buffer is not byte aligned!");
		}
		int num = 0;
		while (this.number6 > 0 && 3 > 0)
		{
			1[2++] = (byte)this.number5;
			this.number5 >>= 8;
			this.number6 -= 8;
			3--;
			num++;
		}
		if (3 == 0)
		{
			return num;
		}
		int num2 = this.number4 - this.number3;
		if (3 > num2)
		{
			3 = num2;
		}
		Array.Copy(this.byteArray2, this.number3, 1, 2, 3);
		this.number3 += 3;
		if ((this.number3 - this.number4 & 1) != 0)
		{
			byte[] array = this.byteArray2;
			int num3 = this.number3;
			this.number3 = num3 + 1;
			this.number5 = (array[num3] & 255U);
			this.number6 = 8;
		}
		return num + 3;
	}

	// Token: 0x06001814 RID: 6164 RVA: 0x00054628 File Offset: 0x00052828
	public void Method12426()
	{
		this.number5 = 0U;
		this.number3 = (this.number4 = (this.number6 = 0));
	}

	// Token: 0x06001815 RID: 6165 RVA: 0x00054658 File Offset: 0x00052858
	public void Method12427(byte[] 1, int 2, int 3)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=zpMJwVYM=");
		}
		if (2 < 0)
		{
			throw new ArgumentOutOfRangeException("#=zJ_sgkP4=", "Cannot be negative");
		}
		if (3 < 0)
		{
			throw new ArgumentOutOfRangeException("#=zW32YDQ0=", "Cannot be negative");
		}
		if (this.number3 < this.number4)
		{
			throw new InvalidOperationException("Old input was not completely processed");
		}
		int num = 2 + 3;
		if (2 > num || num > 1.Length)
		{
			throw new ArgumentOutOfRangeException("#=zW32YDQ0=");
		}
		if ((3 & 1) != 0)
		{
			this.number5 |= (uint)((uint)(1[2++] & byte.MaxValue) << this.number6);
			this.number6 += 8;
		}
		this.byteArray2 = 1;
		this.number3 = 2;
		this.number4 = num;
	}

	// Token: 0x04000B3A RID: 2874
	private byte[] byteArray2;

	// Token: 0x04000B3B RID: 2875
	private int number3;

	// Token: 0x04000B3C RID: 2876
	private int number4;

	// Token: 0x04000B3D RID: 2877
	private uint number5;

	// Token: 0x04000B3E RID: 2878
	private int number6;
}
