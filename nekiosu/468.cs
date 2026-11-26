using System;
using System.IO;
using System.Runtime.InteropServices;

// Token: 0x0200021D RID: 541
[ComVisible(false)]
public sealed class 468
{
	// Token: 0x060010F8 RID: 4344 RVA: 0x0003CA0C File Offset: 0x0003AC0C
	public void Method4434(uint 1)
	{
		if (this.number4 != 1)
		{
			this.byteArray = new byte[1];
		}
		this.number4 = 1;
		this.number3 = 0U;
		this.number5 = 0U;
	}

	// Token: 0x060010F9 RID: 4345 RVA: 0x0003CA38 File Offset: 0x0003AC38
	public void Method4435(Stream 1, bool 2)
	{
		this.Method4437();
		this.stream2 = 1;
		if (!2)
		{
			this.number5 = 0U;
			this.number3 = 0U;
			this.number6 = 0U;
		}
	}

	// Token: 0x060010FA RID: 4346 RVA: 0x0003CA60 File Offset: 0x0003AC60
	public bool Method4436(Stream 1)
	{
		long length = 1.Length;
		uint num = this.number6 = (uint)((length < (long)((ulong)this.number4)) ? length : ((long)((ulong)this.number4)));
		1.Position = length - (long)((ulong)num);
		this.number5 = (this.number3 = 0U);
		while (num != 0U)
		{
			uint num2 = this.number4 - this.number3;
			if (num < num2)
			{
				num2 = num;
			}
			int num3 = 1.Read(this.byteArray, (int)this.number3, (int)num2);
			if (num3 == 0)
			{
				return false;
			}
			num -= (uint)num3;
			this.number3 += (uint)num3;
			this.number5 += (uint)num3;
			if (this.number3 == this.number4)
			{
				this.number5 = (this.number3 = 0U);
			}
		}
		return true;
	}

	// Token: 0x060010FB RID: 4347 RVA: 0x0003CB23 File Offset: 0x0003AD23
	public void Method4437()
	{
		this.Method4438();
		this.stream2 = null;
	}

	// Token: 0x060010FC RID: 4348 RVA: 0x0003CB34 File Offset: 0x0003AD34
	public void Method4438()
	{
		uint num = this.number3 - this.number5;
		if (num != 0U)
		{
			this.stream2.Write(this.byteArray, (int)this.number5, (int)num);
			if (this.number3 >= this.number4)
			{
				this.number3 = 0U;
			}
			this.number5 = this.number3;
		}
	}

	// Token: 0x060010FD RID: 4349 RVA: 0x0003CB8C File Offset: 0x0003AD8C
	public void Method4439(uint 1, uint 2)
	{
		uint num = this.number3 - 1 - 1U;
		if (num >= this.number4)
		{
			num += this.number4;
		}
		while (2 != 0U)
		{
			if (num >= this.number4)
			{
				num = 0U;
			}
			byte[] array = this.byteArray;
			uint num2 = this.number3;
			this.number3 = num2 + 1U;
			array[(int)num2] = this.byteArray[(int)num++];
			if (this.number3 >= this.number4)
			{
				this.Method4438();
			}
			2 -= 1U;
		}
	}

	// Token: 0x060010FE RID: 4350 RVA: 0x0003CC04 File Offset: 0x0003AE04
	public void Method4440(byte 1)
	{
		byte[] array = this.byteArray;
		uint num = this.number3;
		this.number3 = num + 1U;
		array[(int)num] = 1;
		if (this.number3 >= this.number4)
		{
			this.Method4438();
		}
	}

	// Token: 0x060010FF RID: 4351 RVA: 0x0003CC40 File Offset: 0x0003AE40
	public byte Method4441(uint 1)
	{
		uint num = this.number3 - 1 - 1U;
		if (num >= this.number4)
		{
			num += this.number4;
		}
		return this.byteArray[(int)num];
	}

	// Token: 0x04000882 RID: 2178
	private byte[] byteArray;

	// Token: 0x04000883 RID: 2179
	private uint number3;

	// Token: 0x04000884 RID: 2180
	private uint number4;

	// Token: 0x04000885 RID: 2181
	private uint number5;

	// Token: 0x04000886 RID: 2182
	private Stream stream2;

	// Token: 0x04000887 RID: 2183
	public uint number6;
}
