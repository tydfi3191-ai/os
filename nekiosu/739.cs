using System;
using System.IO;
using System.Runtime.InteropServices;

// Token: 0x02000349 RID: 841
[ComVisible(false)]
public sealed class 739 : Stream, IDisposable
{
	// Token: 0x1700012C RID: 300
	// (get) Token: 0x060019FE RID: 6654 RVA: 0x00060A72 File Offset: 0x0005EC72
	public override bool CanRead
	{
		get
		{
			return this.stream2.CanRead;
		}
	}

	// Token: 0x1700012D RID: 301
	// (get) Token: 0x060019FF RID: 6655 RVA: 0x00060A7F File Offset: 0x0005EC7F
	public override bool CanSeek
	{
		get
		{
			return this.stream2.CanSeek;
		}
	}

	// Token: 0x1700012E RID: 302
	// (get) Token: 0x06001A00 RID: 6656 RVA: 0x00060A8C File Offset: 0x0005EC8C
	public override bool CanWrite
	{
		get
		{
			return this.stream2.CanWrite;
		}
	}

	// Token: 0x1700012F RID: 303
	// (get) Token: 0x06001A01 RID: 6657 RVA: 0x00060A99 File Offset: 0x0005EC99
	public override long Length
	{
		get
		{
			if (this.number3 == 739.number4)
			{
				return this.stream2.Length;
			}
			return this.number3;
		}
	}

	// Token: 0x17000130 RID: 304
	// (get) Token: 0x06001A02 RID: 6658 RVA: 0x00060ABA File Offset: 0x0005ECBA
	// (set) Token: 0x06001A03 RID: 6659 RVA: 0x00053ADC File Offset: 0x00051CDC
	public override long Position
	{
		get
		{
			return this._recoveredType03359307.GetNumber1278_1891();
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	// Token: 0x06001A04 RID: 6660 RVA: 0x00060AC7 File Offset: 0x0005ECC7
	public 739(Stream 1) : this(true, 739.number4, 1)
	{
	}

	// Token: 0x06001A05 RID: 6661 RVA: 0x00060AD6 File Offset: 0x0005ECD6
	public 739(Stream 1, bool 2) : this(2, 739.number4, 1)
	{
	}

	// Token: 0x06001A06 RID: 6662 RVA: 0x00060AE5 File Offset: 0x0005ECE5
	public 739(Stream 1, long 2) : this(true, 2, 1)
	{
		if (2 < 0L)
		{
			throw new ArgumentException("length");
		}
	}

	// Token: 0x06001A07 RID: 6663 RVA: 0x00060B00 File Offset: 0x0005ED00
	private 739(bool 1, long 2, Stream 3)
	{
		this.number3 = -99L;
		this.stream2 = 3;
		this._recoveredType03359307 = new 369();
		this.number3 = 2;
		this.flag2 = 1;
	}

	// Token: 0x06001A08 RID: 6664 RVA: 0x00060B31 File Offset: 0x0005ED31
	public 739(Stream 1, long 2, bool 3) : this(3, 2, 1)
	{
		if (2 < 0L)
		{
			throw new ArgumentException("length");
		}
	}

	// Token: 0x06001A09 RID: 6665 RVA: 0x00060B4C File Offset: 0x0005ED4C
	public override void Close()
	{
		base.Close();
		if (!this.flag2)
		{
			this.stream2.Close();
		}
	}

	// Token: 0x06001A0A RID: 6666 RVA: 0x00060B67 File Offset: 0x0005ED67
	public override void Flush()
	{
		this.stream2.Flush();
	}

	// Token: 0x06001A0B RID: 6667 RVA: 0x00060B74 File Offset: 0x0005ED74
	public override int Read(byte[] 1, int 2, int 3)
	{
		int count = 3;
		if (this.number3 != 739.number4)
		{
			if (this._recoveredType03359307.GetNumber1278_1891() >= this.number3)
			{
				return 0;
			}
			long num = this.number3 - this._recoveredType03359307.GetNumber1278_1891();
			if (num < (long)3)
			{
				count = (int)num;
			}
		}
		int num2 = this.stream2.Read(1, 2, count);
		if (num2 > 0)
		{
			this._recoveredType03359307.Method1889(1, 2, num2);
		}
		return num2;
	}

	// Token: 0x06001A0C RID: 6668 RVA: 0x00053ADC File Offset: 0x00051CDC
	public override long Seek(long 1, SeekOrigin 2)
	{
		throw new NotImplementedException();
	}

	// Token: 0x06001A0D RID: 6669 RVA: 0x00053ADC File Offset: 0x00051CDC
	public override void SetLength(long 1)
	{
		throw new NotImplementedException();
	}

	// Token: 0x06001A0E RID: 6670 RVA: 0x00060BE2 File Offset: 0x0005EDE2
	private void Method11822()
	{
		this.Close();
	}

	// Token: 0x06001A0F RID: 6671 RVA: 0x00060BEA File Offset: 0x0005EDEA
	void IDisposable.Dispose()
	{
		this.Method11822();
	}

	// Token: 0x06001A10 RID: 6672 RVA: 0x00060BF2 File Offset: 0x0005EDF2
	public override void Write(byte[] 1, int 2, int 3)
	{
		if (3 > 0)
		{
			this._recoveredType03359307.Method1889(1, 2, 3);
		}
		this.stream2.Write(1, 2, 3);
	}

	// Token: 0x06001A11 RID: 6673 RVA: 0x00060C14 File Offset: 0x0005EE14
	public int _000E_2009_2004_2000_2001_200A_2007_2005_2007_2005_200A_2001_200A_2007_2002_2001_2006_2002_2002_200A_2000_2002_2003_2004_2003_2002()
	{
		return this._recoveredType03359307.Method1890();
	}

	// Token: 0x06001A12 RID: 6674 RVA: 0x00060C21 File Offset: 0x0005EE21
	public bool _0003_2002_200A_2006_2003_2002_200B_2004_200B_2000_200B_2006_200A_200A_2004_200A_2009_2005_200A()
	{
		return this.flag2;
	}

	// Token: 0x06001A13 RID: 6675 RVA: 0x00060C29 File Offset: 0x0005EE29
	public void _0003_2008_2000_2004_2000_2004_2001_2002_2001_2000_2008_2003_2007_2006_2004_2007_200A_2007_2004_200A_2007_2006(bool 1)
	{
		this.flag2 = 1;
	}

	// Token: 0x06001A14 RID: 6676 RVA: 0x00060ABA File Offset: 0x0005ECBA
	public long _000E_2005_200A_2007_2008_2002_2002_2009_2005_2006_2004_2000_2004_2004_2007_2004_2002_2008_2002_2004_2009_2000_2008_2003_2009()
	{
		return this._recoveredType03359307.GetNumber1278_1891();
	}

	// Token: 0x04000C5B RID: 3163
	private 369 _recoveredType03359307;

	// Token: 0x04000C5C RID: 3164
	private Stream stream2;

	// Token: 0x04000C5D RID: 3165
	private bool flag2;

	// Token: 0x04000C5E RID: 3166
	private long number3;

	// Token: 0x04000C5F RID: 3167
	private static readonly long number4 = -99L;
}
