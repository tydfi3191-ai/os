using System;
using System.IO;
using System.Runtime.InteropServices;

// Token: 0x0200022B RID: 555
[ComVisible(false)]
public class 796
{
	// Token: 0x06001131 RID: 4401 RVA: 0x0003D970 File Offset: 0x0003BB70
	public void Method13242()
	{
		uint num = this.number17 + this.number19 - this.number20;
		if (num != 0U)
		{
			num -= 1U;
		}
		uint num2 = this.number17 + this.number22 - num;
		for (uint num3 = 0U; num3 < num2; num3 += 1U)
		{
			this.byteArray[(int)num3] = this.byteArray[(int)(num + num3)];
		}
		this.number17 -= num;
	}

	// Token: 0x06001132 RID: 4402 RVA: 0x0003D9D8 File Offset: 0x0003BBD8
	public virtual void Method13243()
	{
		if (this.flag2)
		{
			return;
		}
		for (;;)
		{
			int num = (int)(0U - this.number17 + this.number18 - this.number22);
			if (num == 0)
			{
				break;
			}
			int num2 = this.stream2.Read(this.byteArray, (int)(this.number17 + this.number22), num);
			if (num2 == 0)
			{
				goto IL_7F;
			}
			this.number22 += (uint)num2;
			if (this.number22 >= this.number19 + this.number21)
			{
				this.number15 = this.number22 - this.number21;
			}
		}
		return;
		IL_7F:
		this.number15 = this.number22;
		if (this.number17 + this.number15 > this.number16)
		{
			this.number15 = this.number16 - this.number17;
		}
		this.flag2 = true;
	}

	// Token: 0x06001133 RID: 4403 RVA: 0x0003DA9F File Offset: 0x0003BC9F
	private void SetByteArray10317_13244()
	{
		this.byteArray = null;
	}

	// Token: 0x06001134 RID: 4404 RVA: 0x0003DAA8 File Offset: 0x0003BCA8
	public void Method13245(uint 1, uint 2, uint 3)
	{
		this.number20 = 1;
		this.number21 = 2;
		uint num = 1 + 2 + 3;
		if (this.byteArray == null || this.number18 != num)
		{
			this.SetByteArray10317_13244();
			this.number18 = num;
			this.byteArray = new byte[this.number18];
		}
		this.number16 = this.number18 - 2;
	}

	// Token: 0x06001135 RID: 4405 RVA: 0x0003DB06 File Offset: 0x0003BD06
	public void SetStream10318_13246(Stream 1)
	{
		this.stream2 = 1;
	}

	// Token: 0x06001136 RID: 4406 RVA: 0x0003DB0F File Offset: 0x0003BD0F
	public void SetStream10318_13247()
	{
		this.stream2 = null;
	}

	// Token: 0x06001137 RID: 4407 RVA: 0x0003DB18 File Offset: 0x0003BD18
	public void Method13248()
	{
		this.number17 = 0U;
		this.number19 = 0U;
		this.number22 = 0U;
		this.flag2 = false;
		this.Method13243();
	}

	// Token: 0x06001138 RID: 4408 RVA: 0x0003DB3C File Offset: 0x0003BD3C
	public void Method13249()
	{
		this.number19 += 1U;
		if (this.number19 > this.number15)
		{
			if (this.number17 + this.number19 > this.number16)
			{
				this.Method13242();
			}
			this.Method13243();
		}
	}

	// Token: 0x06001139 RID: 4409 RVA: 0x0003DB7B File Offset: 0x0003BD7B
	public byte Method13250(int 1)
	{
		return this.byteArray[(int)(checked((IntPtr)(unchecked((ulong)(this.number17 + this.number19) + (ulong)((long)1)))))];
	}

	// Token: 0x0600113A RID: 4410 RVA: 0x0003DB98 File Offset: 0x0003BD98
	public uint Method13251(int 1, uint 2, uint 3)
	{
		if (this.flag2 && (ulong)this.number19 + (ulong)((long)1) + (ulong)3 > (ulong)this.number22)
		{
			3 = this.number22 - (uint)((int)((ulong)this.number19 + (ulong)((long)1)));
		}
		2 += 1U;
		uint num = this.number17 + this.number19 + (uint)1;
		uint num2 = 0U;
		while (num2 < 3 && this.byteArray[(int)(num + num2)] == this.byteArray[(int)(num + num2 - 2)])
		{
			num2 += 1U;
		}
		return num2;
	}

	// Token: 0x0600113B RID: 4411 RVA: 0x0003DC11 File Offset: 0x0003BE11
	public uint Method13252()
	{
		return this.number22 - this.number19;
	}

	// Token: 0x0600113C RID: 4412 RVA: 0x0003DC20 File Offset: 0x0003BE20
	public void Method13253(int 1)
	{
		this.number17 += (uint)1;
		this.number15 -= (uint)1;
		this.number19 -= (uint)1;
		this.number22 -= (uint)1;
	}

	// Token: 0x04000899 RID: 2201
	public byte[] byteArray;

	// Token: 0x0400089A RID: 2202
	private Stream stream2;

	// Token: 0x0400089B RID: 2203
	private uint number15;

	// Token: 0x0400089C RID: 2204
	private bool flag2;

	// Token: 0x0400089D RID: 2205
	private uint number16;

	// Token: 0x0400089E RID: 2206
	public uint number17;

	// Token: 0x0400089F RID: 2207
	public uint number18;

	// Token: 0x040008A0 RID: 2208
	public uint number19;

	// Token: 0x040008A1 RID: 2209
	private uint number20;

	// Token: 0x040008A2 RID: 2210
	private uint number21;

	// Token: 0x040008A3 RID: 2211
	public uint number22;
}
