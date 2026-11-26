using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

// Token: 0x02000A40 RID: 2624
[ComVisible(false)]
public sealed class 1517 : Stream
{
	// Token: 0x17000306 RID: 774
	// (get) Token: 0x060048A5 RID: 18597 RVA: 0x001CD801 File Offset: 0x001CBA01
	public override bool CanRead
	{
		get
		{
			return !this.1();
		}
	}

	// Token: 0x17000307 RID: 775
	// (get) Token: 0x060048A6 RID: 18598 RVA: 0x0000FF75 File Offset: 0x0000E175
	public override bool CanSeek
	{
		get
		{
			return false;
		}
	}

	// Token: 0x17000308 RID: 776
	// (get) Token: 0x060048A7 RID: 18599 RVA: 0x0000FF75 File Offset: 0x0000E175
	public override bool CanWrite
	{
		get
		{
			return false;
		}
	}

	// Token: 0x17000309 RID: 777
	// (get) Token: 0x060048A8 RID: 18600 RVA: 0x001CD80C File Offset: 0x001CBA0C
	public override long Length
	{
		get
		{
			return (long)this.1;
		}
	}

	// Token: 0x1700030A RID: 778
	// (get) Token: 0x060048A9 RID: 18601 RVA: 0x001CD815 File Offset: 0x001CBA15
	// (set) Token: 0x060048AA RID: 18602 RVA: 0x001CD825 File Offset: 0x001CBA25
	public override long Position
	{
		get
		{
			return this.6 - (long)this.5;
		}
		set
		{
			this.2.Seek(value, SeekOrigin.Begin);
		}
	}

	// Token: 0x060048AB RID: 18603 RVA: 0x001CD835 File Offset: 0x001CBA35
	public 1517(string 1, int 2, int 3, byte[] 4, byte[] 5) : this(File.Open(1, FileMode.Open, FileAccess.Read, FileShare.Read), 2, 3, 4, 5)
	{
		this.7 = true;
	}

	// Token: 0x060048AC RID: 18604 RVA: 0x001CD854 File Offset: 0x001CBA54
	public unsafe 1517(Stream 1, int 2, int 3, byte[] 4, byte[] 5)
	{
		byte[] array = new byte[4];
		1.Seek((long)2, SeekOrigin.Begin);
		1.Read(array, 0, 4);
		this.2 = 1;
		this.2.Position = (long)(this.5 = 2 + 4);
		uint[] array2 = new uint[4];
		fixed (byte[] array3 = 5)
		{
			byte* ptr;
			if (5 == null || array3.Length == 0)
			{
				ptr = null;
			}
			else
			{
				ptr = &array3[0];
			}
			uint[] array4;
			uint* ptr2;
			if ((array4 = array2) == null || array4.Length == 0)
			{
				ptr2 = null;
			}
			else
			{
				ptr2 = &array4[0];
			}
			uint* ptr3 = (uint*)ptr;
			*ptr2 = *ptr3;
			ptr2[1] = ptr3[1];
			ptr2[2] = ptr3[2];
			ptr2[3] = ptr3[3];
			array4 = null;
		}
		this.4.1(array2, (594)1);
		byte[] array5 = new byte[]
		{
			array[0],
			array[1],
			array[2],
			array[3]
		};
		this.4.9(array5, 0, 4);
		this.1 = ((int)array5[0] | (int)array5[1] << 8 | (int)array5[2] << 16 | (int)array5[3] << 24);
		this.6 = (long)this.5;
	}

	// Token: 0x060048AD RID: 18605 RVA: 0x001CD99C File Offset: 0x001CBB9C
	~1517()
	{
		this.Dispose(false);
	}

	// Token: 0x060048AE RID: 18606 RVA: 0x001CD9CC File Offset: 0x001CBBCC
	public bool 1()
	{
		return this.8;
	}

	// Token: 0x060048AF RID: 18607 RVA: 0x001CD9D4 File Offset: 0x001CBBD4
	protected void 2(bool 1)
	{
		this.8 = 1;
	}

	// Token: 0x060048B0 RID: 18608 RVA: 0x001CD9E0 File Offset: 0x001CBBE0
	public void 3(1517.1518 1)
	{
		1517.1518 2 = this.9;
		1517.1518 3;
		do
		{
			3 = 2;
			1517.1518 value = (1517.1518)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1517.1518>(ref this.9, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x060048B1 RID: 18609 RVA: 0x001CDA15 File Offset: 0x001CBC15
	public override void Close()
	{
		if (this.9 != null)
		{
			this.9(this);
		}
		base.Close();
	}

	// Token: 0x060048B2 RID: 18610 RVA: 0x00005BE8 File Offset: 0x00003DE8
	public override void Flush()
	{
		throw new NotSupportedException();
	}

	// Token: 0x060048B3 RID: 18611 RVA: 0x001CDA34 File Offset: 0x001CBC34
	public override long Seek(long 1, SeekOrigin 2)
	{
		switch (2)
		{
		case SeekOrigin.Begin:
			if (1 >= 0L)
			{
				this.6 = Math.Min(1, (long)this.1) + (long)this.5;
			}
			break;
		case SeekOrigin.Current:
			if (this.Position + 1 >= 0L)
			{
				this.6 = Math.Min(this.6 + 1 - (long)this.5, (long)this.1) + (long)this.5;
			}
			break;
		case SeekOrigin.End:
			if ((long)this.1 + 1 >= 0L)
			{
				this.6 = (long)this.1 + 1 + (long)this.5;
			}
			break;
		}
		this.2.Seek(this.6, SeekOrigin.Begin);
		return this.Position;
	}

	// Token: 0x060048B4 RID: 18612 RVA: 0x00005BE8 File Offset: 0x00003DE8
	public override void SetLength(long 1)
	{
		throw new NotSupportedException();
	}

	// Token: 0x060048B5 RID: 18613 RVA: 0x001CDAEC File Offset: 0x001CBCEC
	protected override void Dispose(bool 1)
	{
		this.2(true);
		if (1 && this.7)
		{
			this.2.Dispose();
		}
		base.Dispose(1);
	}

	// Token: 0x060048B6 RID: 18614 RVA: 0x001CDB14 File Offset: 0x001CBD14
	public override int Read(byte[] 1, int 2, int 3)
	{
		if (this.Position + (long)3 > (long)this.1)
		{
			3 = this.1 - (int)this.Position;
		}
		if (3 == 0)
		{
			return 0;
		}
		long num = this.6 - (long)this.5;
		long num2 = num & -64L;
		int num3 = (int)num % 64;
		int num4 = 3;
		int num5 = 3 - (64 - num3);
		int num6 = 0;
		int num7 = 0;
		if (num5 > 0)
		{
			num7 = ((int)num + 3 & -64);
			num6 = ((int)num + 3) % 64;
			num5 = num7 - (64 - num3 + (int)num);
			if (num5 > 0)
			{
				this.2.Position = this.6;
				this.2.Read(1, 2, 3);
				this.4.9(1, 64 - num3 + 2, num5);
			}
		}
		int count = Math.Min(64, this.1 - (int)num2);
		this.2.Position = num2 + (long)this.5;
		this.2.Read(this.3, 0, count);
		this.4.9(this.3, 0, count);
		Array.Copy(this.3, num3, 1, 2, Math.Min(64 - num3, 3));
		if (num6 > 0)
		{
			int count2 = Math.Min(64, this.1 - num7);
			this.2.Position = (long)(num7 + this.5);
			this.2.Read(this.3, 0, count2);
			this.4.9(this.3, 0, count2);
			Array.Copy(this.3, 0, 1, 3 - num6 + 2, num6);
		}
		this.2.Position = this.6;
		this.Seek((long)num4, SeekOrigin.Current);
		return num4;
	}

	// Token: 0x060048B7 RID: 18615 RVA: 0x00005BE8 File Offset: 0x00003DE8
	public override void Write(byte[] 1, int 2, int 3)
	{
		throw new NotSupportedException();
	}

	// Token: 0x040035A8 RID: 13736
	private readonly int 1;

	// Token: 0x040035A9 RID: 13737
	private Stream 2;

	// Token: 0x040035AA RID: 13738
	private byte[] 3 = new byte[64];

	// Token: 0x040035AB RID: 13739
	private 2680 4 = new 2680();

	// Token: 0x040035AC RID: 13740
	private int 5;

	// Token: 0x040035AD RID: 13741
	private long 6;

	// Token: 0x040035AE RID: 13742
	private bool 7;

	// Token: 0x040035AF RID: 13743
	private bool 8;

	// Token: 0x040035B0 RID: 13744
	private 1517.1518 9;

	// Token: 0x02000A41 RID: 2625
	// (Invoke) Token: 0x060048B9 RID: 18617
	public delegate void 1518(1517 1);
}
