using System;
using System.IO;

// Token: 0x020002AA RID: 682
public sealed class 333 : 331, IDisposable
{
	// Token: 0x060014A3 RID: 5283 RVA: 0x000478EB File Offset: 0x00045AEB
	public 333() : this(0)
	{
	}

	// Token: 0x060014A4 RID: 5284 RVA: 0x000478F4 File Offset: 0x00045AF4
	public 333(int 1)
	{
		if (1 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		this.byteArray2 = new byte[1];
		this.number6 = 1;
		this.flag2 = true;
		this.flag3 = true;
		this.number3 = 0;
		this.flag4 = true;
	}

	// Token: 0x060014A5 RID: 5285 RVA: 0x00047940 File Offset: 0x00045B40
	public 333(byte[] 1) : this(1, true)
	{
	}

	// Token: 0x060014A6 RID: 5286 RVA: 0x0004794C File Offset: 0x00045B4C
	public 333(byte[] 1, bool 2)
	{
		if (1 == null)
		{
			throw new ArgumentNullException();
		}
		this.byteArray2 = 1;
		this.number5 = (this.number6 = 1.Length);
		this.flag3 = 2;
		this.number3 = 0;
		this.flag4 = true;
	}

	// Token: 0x060014A7 RID: 5287 RVA: 0x00047996 File Offset: 0x00045B96
	public 333(byte[] 1, int 2, int 3) : this(1, 2, 3, true)
	{
	}

	// Token: 0x060014A8 RID: 5288 RVA: 0x000479A4 File Offset: 0x00045BA4
	public 333(byte[] 1, int 2, int 3, bool 4)
	{
		if (1 == null)
		{
			throw new ArgumentNullException();
		}
		if (2 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (3 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (1.Length - 2 < 3)
		{
			throw new ArgumentException();
		}
		this.byteArray2 = 1;
		this.number4 = 2;
		this.number3 = 2;
		this.number5 = (this.number6 = 2 + 3);
		this.flag3 = 4;
		this.flag2 = false;
		this.flag4 = true;
	}

	// Token: 0x060014A9 RID: 5289 RVA: 0x00047A21 File Offset: 0x00045C21
	public override bool GetFlag0541_880()
	{
		return this.flag4;
	}

	// Token: 0x060014AA RID: 5290 RVA: 0x00047A21 File Offset: 0x00045C21
	public override bool GetFlag0541_881()
	{
		return this.flag4;
	}

	// Token: 0x060014AB RID: 5291 RVA: 0x00047A29 File Offset: 0x00045C29
	public override bool GetFlag0540_882()
	{
		return this.flag3;
	}

	// Token: 0x060014AC RID: 5292 RVA: 0x00047A31 File Offset: 0x00045C31
	protected override void Method0883(bool 1)
	{
		if (!this.flag5)
		{
			if (1)
			{
				this.flag4 = false;
				this.flag3 = false;
				this.flag2 = false;
			}
			this.flag5 = true;
		}
	}

	// Token: 0x060014AD RID: 5293 RVA: 0x00047A5C File Offset: 0x00045C5C
	private bool Method0884(int 1)
	{
		if (1 < 0)
		{
			throw new IOException();
		}
		if (1 > this.number6)
		{
			int num = 1;
			if (num < 256)
			{
				num = 256;
			}
			if (num < this.number6 * 2)
			{
				num = this.number6 * 2;
			}
			this.Method0891(num);
			return true;
		}
		return false;
	}

	// Token: 0x060014AE RID: 5294 RVA: 0x00005ADD File Offset: 0x00003CDD
	public override void Method0885()
	{
	}

	// Token: 0x060014AF RID: 5295 RVA: 0x00047AAA File Offset: 0x00045CAA
	internal byte[] GetByteArray0534_886()
	{
		return this.byteArray2;
	}

	// Token: 0x060014B0 RID: 5296 RVA: 0x00047AB2 File Offset: 0x00045CB2
	internal void Method0887(out int 1, out int 2)
	{
		if (!this.flag4)
		{
			throw new Exception();
		}
		1 = this.number3;
		2 = this.number5;
	}

	// Token: 0x060014B1 RID: 5297 RVA: 0x00047AD2 File Offset: 0x00045CD2
	internal int Method0888()
	{
		if (!this.flag4)
		{
			throw new Exception();
		}
		return this.number4;
	}

	// Token: 0x060014B2 RID: 5298 RVA: 0x00047AE8 File Offset: 0x00045CE8
	public int Method0889(int 1)
	{
		if (!this.flag4)
		{
			throw new Exception();
		}
		int num = this.number5 - this.number4;
		if (num > 1)
		{
			num = 1;
		}
		if (num < 0)
		{
			num = 0;
		}
		this.number4 += num;
		return num;
	}

	// Token: 0x060014B3 RID: 5299 RVA: 0x00047B2C File Offset: 0x00045D2C
	public int Method0890()
	{
		if (!this.flag4)
		{
			throw new Exception();
		}
		return this.number6 - this.number3;
	}

	// Token: 0x060014B4 RID: 5300 RVA: 0x00047B4C File Offset: 0x00045D4C
	public void Method0891(int 1)
	{
		if (!this.flag4)
		{
			throw new Exception();
		}
		if (1 == this.number6)
		{
			return;
		}
		if (!this.flag2)
		{
			throw new Exception();
		}
		if (1 < this.number5)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (1 > 0)
		{
			byte[] dst = new byte[1];
			if (this.number5 > 0)
			{
				Buffer.BlockCopy(this.byteArray2, 0, dst, 0, this.number5);
			}
			this.byteArray2 = dst;
		}
		else
		{
			this.byteArray2 = null;
		}
		this.number6 = 1;
	}

	// Token: 0x060014B5 RID: 5301 RVA: 0x00047BCD File Offset: 0x00045DCD
	public override long Method0892()
	{
		if (!this.flag4)
		{
			throw new Exception();
		}
		return (long)(this.number5 - this.number3);
	}

	// Token: 0x060014B6 RID: 5302 RVA: 0x00047BEB File Offset: 0x00045DEB
	public override long Method0893()
	{
		if (!this.flag4)
		{
			throw new Exception();
		}
		return (long)(this.number4 - this.number3);
	}

	// Token: 0x060014B7 RID: 5303 RVA: 0x00047C09 File Offset: 0x00045E09
	public override void Method0894(long 1)
	{
		if (!this.flag4)
		{
			throw new Exception();
		}
		if (1 < 0L)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (1 > 2147483647L)
		{
			throw new ArgumentOutOfRangeException();
		}
		this.number4 = this.number3 + (int)1;
	}

	// Token: 0x060014B8 RID: 5304 RVA: 0x00047C44 File Offset: 0x00045E44
	public override int Method0895(byte[] 1, int 2, int 3)
	{
		if (!this.flag4)
		{
			throw new Exception();
		}
		if (1 == null)
		{
			throw new ArgumentNullException();
		}
		if (2 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (3 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (1.Length - 2 < 3)
		{
			throw new ArgumentException();
		}
		int num = this.number5 - this.number4;
		if (num > 3)
		{
			num = 3;
		}
		if (num <= 0)
		{
			return 0;
		}
		if (num <= 8)
		{
			int num2 = num;
			while (--num2 >= 0)
			{
				1[2 + num2] = this.byteArray2[this.number4 + num2];
			}
		}
		else
		{
			Buffer.BlockCopy(this.byteArray2, this.number4, 1, 2, num);
		}
		this.number4 += num;
		return num;
	}

	// Token: 0x060014B9 RID: 5305 RVA: 0x00047CF0 File Offset: 0x00045EF0
	public override int Method0896()
	{
		if (!this.flag4)
		{
			throw new Exception();
		}
		if (this.number4 >= this.number5)
		{
			return -1;
		}
		byte[] array = this.byteArray2;
		int num = this.number4;
		this.number4 = num + 1;
		return array[num];
	}

	// Token: 0x060014BA RID: 5306 RVA: 0x00047D34 File Offset: 0x00045F34
	public override long Method0897(long 1, int 2)
	{
		if (!this.flag4)
		{
			throw new Exception();
		}
		if (1 > 2147483647L)
		{
			throw new ArgumentOutOfRangeException();
		}
		switch (2)
		{
		case 0:
			if (1 < 0L)
			{
				throw new IOException();
			}
			this.number4 = this.number3 + (int)1;
			break;
		case 1:
			if (1 + (long)this.number4 < (long)this.number3)
			{
				throw new IOException();
			}
			this.number4 += (int)1;
			break;
		case 2:
			if ((long)this.number5 + 1 < (long)this.number3)
			{
				throw new IOException();
			}
			this.number4 = this.number5 + (int)1;
			break;
		default:
			throw new ArgumentException();
		}
		return (long)this.number4;
	}

	// Token: 0x060014BB RID: 5307 RVA: 0x00047DF0 File Offset: 0x00045FF0
	public override void Method0898(long 1)
	{
		if (!this.flag3)
		{
			throw new Exception();
		}
		if (1 > 2147483647L)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (1 < 0L || 1 > (long)(2147483647 - this.number3))
		{
			throw new ArgumentOutOfRangeException();
		}
		int num = this.number3 + (int)1;
		if (!this.Method0884(num) && num > this.number5)
		{
			Array.Clear(this.byteArray2, this.number5, num - this.number5);
		}
		this.number5 = num;
		if (this.number4 > num)
		{
			this.number4 = num;
		}
	}

	// Token: 0x060014BC RID: 5308 RVA: 0x00047E84 File Offset: 0x00046084
	public byte[] Method0899()
	{
		byte[] array = new byte[this.number5 - this.number3];
		Buffer.BlockCopy(this.byteArray2, this.number3, array, 0, this.number5 - this.number3);
		return array;
	}

	// Token: 0x060014BD RID: 5309 RVA: 0x00047EC8 File Offset: 0x000460C8
	public override void Method0900(byte[] 1, int 2, int 3)
	{
		if (!this.flag4)
		{
			throw new Exception();
		}
		if (!this.flag3)
		{
			throw new Exception();
		}
		if (1 == null)
		{
			throw new ArgumentNullException();
		}
		if (2 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (3 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (1.Length - 2 < 3)
		{
			throw new ArgumentException();
		}
		int num = this.number4 + 3;
		if (num < 0)
		{
			throw new IOException();
		}
		if (num > this.number5)
		{
			bool flag = this.number4 > this.number5;
			if (num > this.number6 && this.Method0884(num))
			{
				flag = false;
			}
			if (flag)
			{
				Array.Clear(this.byteArray2, this.number5, num - this.number5);
			}
			this.number5 = num;
		}
		if (3 <= 8)
		{
			int num2 = 3;
			while (--num2 >= 0)
			{
				this.byteArray2[this.number4 + num2] = 1[2 + num2];
			}
		}
		else
		{
			Buffer.BlockCopy(1, 2, this.byteArray2, this.number4, 3);
		}
		this.number4 = num;
	}

	// Token: 0x060014BE RID: 5310 RVA: 0x00047FC0 File Offset: 0x000461C0
	public override void Method0901(byte 1)
	{
		if (!this.flag4)
		{
			throw new Exception();
		}
		if (!this.flag3)
		{
			throw new Exception();
		}
		if (this.number4 >= this.number5)
		{
			int num = this.number4 + 1;
			bool flag = this.number4 > this.number5;
			if (num >= this.number6 && this.Method0884(num))
			{
				flag = false;
			}
			if (flag)
			{
				Array.Clear(this.byteArray2, this.number5, this.number4 - this.number5);
			}
			this.number5 = num;
		}
		byte[] array = this.byteArray2;
		int num2 = this.number4;
		this.number4 = num2 + 1;
		array[num2] = 1;
	}

	// Token: 0x060014BF RID: 5311 RVA: 0x00048064 File Offset: 0x00046264
	public void Method0902(Stream 1)
	{
		if (!this.flag4)
		{
			throw new Exception();
		}
		if (1 == null)
		{
			throw new ArgumentNullException();
		}
		1.Write(this.byteArray2, this.number3, this.number5 - this.number3);
	}

	// Token: 0x060014C0 RID: 5312 RVA: 0x0004809C File Offset: 0x0004629C
	internal int Method0903()
	{
		if (!this.flag4)
		{
			throw new Exception();
		}
		int num = this.number4 += 4;
		if (num > this.number5)
		{
			this.number4 = this.number5;
			throw new Exception();
		}
		return (int)this.byteArray2[num - 4] | (int)this.byteArray2[num - 1] << 16 | (int)this.byteArray2[num - 3] << 24 | (int)this.byteArray2[num - 2] << 8;
	}

	// Token: 0x040009B5 RID: 2485
	private byte[] byteArray2;

	// Token: 0x040009B6 RID: 2486
	private int number3;

	// Token: 0x040009B7 RID: 2487
	private int number4;

	// Token: 0x040009B8 RID: 2488
	private int number5;

	// Token: 0x040009B9 RID: 2489
	private int number6;

	// Token: 0x040009BA RID: 2490
	private bool flag2;

	// Token: 0x040009BB RID: 2491
	private bool flag3;

	// Token: 0x040009BC RID: 2492
	private bool flag4;

	// Token: 0x040009BD RID: 2493
	private bool flag5;
}
