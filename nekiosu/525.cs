using System;
using System.IO;
using System.Runtime.InteropServices;

// Token: 0x02000340 RID: 832
[ComVisible(false)]
public sealed class 525 : Stream
{
	// Token: 0x17000127 RID: 295
	// (get) Token: 0x060019C0 RID: 6592 RVA: 0x0005ED24 File Offset: 0x0005CF24
	public override bool CanRead
	{
		get
		{
			if (this.flag2)
			{
				throw new ObjectDisposedException("DeflateStream");
			}
			return this.zlibBaseStream.innerStream.CanRead;
		}
	}

	// Token: 0x17000128 RID: 296
	// (get) Token: 0x060019C1 RID: 6593 RVA: 0x0000FF75 File Offset: 0x0000E175
	public override bool CanSeek
	{
		get
		{
			return false;
		}
	}

	// Token: 0x17000129 RID: 297
	// (get) Token: 0x060019C2 RID: 6594 RVA: 0x0005ED49 File Offset: 0x0005CF49
	public override bool CanWrite
	{
		get
		{
			if (this.flag2)
			{
				throw new ObjectDisposedException("DeflateStream");
			}
			return this.zlibBaseStream.innerStream.CanWrite;
		}
	}

	// Token: 0x1700012A RID: 298
	// (get) Token: 0x060019C3 RID: 6595 RVA: 0x00053ADC File Offset: 0x00051CDC
	public override long Length
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	// Token: 0x1700012B RID: 299
	// (get) Token: 0x060019C4 RID: 6596 RVA: 0x0005ED70 File Offset: 0x0005CF70
	// (set) Token: 0x060019C5 RID: 6597 RVA: 0x00053ADC File Offset: 0x00051CDC
	public override long Position
	{
		get
		{
			if (this.zlibBaseStream.streamMode == (988.989)0)
			{
				return this.zlibBaseStream.zlibCodec.number9;
			}
			if (this.zlibBaseStream.streamMode == (988.989)1)
			{
				return this.zlibBaseStream.zlibCodec.number8;
			}
			return 0L;
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	// Token: 0x060019C6 RID: 6598 RVA: 0x0005EDBC File Offset: 0x0005CFBC
	public 525(Stream 1, 777 2) : this(1, 2, (724)6, false)
	{
	}

	// Token: 0x060019C7 RID: 6599 RVA: 0x0005EDC8 File Offset: 0x0005CFC8
	public 525(Stream 1, 777 2, 724 3) : this(1, 2, 3, false)
	{
	}

	// Token: 0x060019C8 RID: 6600 RVA: 0x0005EDD4 File Offset: 0x0005CFD4
	public 525(Stream 1, 777 2, bool 3) : this(1, 2, (724)6, 3)
	{
	}

	// Token: 0x060019C9 RID: 6601 RVA: 0x0005EDE0 File Offset: 0x0005CFE0
	public 525(Stream 1, 777 2, 724 3, bool 4)
	{
		this.zlibBaseStream = new 988(1, 2, 3, (438)1951, 4);
	}

	// Token: 0x060019CA RID: 6602 RVA: 0x0005EE00 File Offset: 0x0005D000
	protected override void Dispose(bool 1)
	{
		try
		{
			if (!this.flag2)
			{
				if (1 && this.zlibBaseStream != null)
				{
					this.zlibBaseStream.Close();
				}
				this.flag2 = true;
			}
		}
		finally
		{
			base.Dispose(1);
		}
	}

	// Token: 0x060019CB RID: 6603 RVA: 0x0005EE4C File Offset: 0x0005D04C
	public override void Flush()
	{
		if (this.flag2)
		{
			throw new ObjectDisposedException("DeflateStream");
		}
		this.zlibBaseStream.Flush();
	}

	// Token: 0x060019CC RID: 6604 RVA: 0x0005EE6C File Offset: 0x0005D06C
	public override int Read(byte[] 1, int 2, int 3)
	{
		if (this.flag2)
		{
			throw new ObjectDisposedException("DeflateStream");
		}
		return this.zlibBaseStream.Read(1, 2, 3);
	}

	// Token: 0x060019CD RID: 6605 RVA: 0x00053ADC File Offset: 0x00051CDC
	public override long Seek(long 1, SeekOrigin 2)
	{
		throw new NotImplementedException();
	}

	// Token: 0x060019CE RID: 6606 RVA: 0x00053ADC File Offset: 0x00051CDC
	public override void SetLength(long 1)
	{
		throw new NotImplementedException();
	}

	// Token: 0x060019CF RID: 6607 RVA: 0x0005EE8F File Offset: 0x0005D08F
	public override void Write(byte[] 1, int 2, int 3)
	{
		if (this.flag2)
		{
			throw new ObjectDisposedException("DeflateStream");
		}
		this.zlibBaseStream.Write(1, 2, 3);
	}

	// Token: 0x060019D0 RID: 6608 RVA: 0x0005EEB2 File Offset: 0x0005D0B2
	public int _000F_2004_2000_2003_2004_200A_2004_200B_2005_2008_2007_2008_2003_2009_2008_2002_2007()
	{
		return this.zlibBaseStream.bufferSize;
	}

	// Token: 0x060019D1 RID: 6609 RVA: 0x0005EEC0 File Offset: 0x0005D0C0
	public void _0003_2006_2006_2000_2007_2008_2006_2007_2009_2001_2006_2002_2005_2000_2009_2002_2006_2008_2000_2000_2002_2006_2003_2008_2004_2002_2008(int 1)
	{
		if (this.flag2)
		{
			throw new ObjectDisposedException("DeflateStream");
		}
		if (this.zlibBaseStream.workingBuffer != null)
		{
			throw new 522("The working buffer is already set.");
		}
		if (1 < 128)
		{
			throw new 522(string.Format("Don't be silly. {0} bytes?? Use a bigger buffer.", 1));
		}
		this.zlibBaseStream.bufferSize = 1;
	}

	// Token: 0x060019D2 RID: 6610 RVA: 0x0005EF22 File Offset: 0x0005D122
	public 528 _0005_2007_2000_2005_2000_200B_2002_2007_2003_2000_2007_2002_2008_2009_200B_2002_200B_2006_2008()
	{
		return this.zlibBaseStream.flushMode;
	}

	// Token: 0x060019D3 RID: 6611 RVA: 0x0005EF2F File Offset: 0x0005D12F
	public void _000F_2001_2004_200B_2007_2001_2006_2004_2006_2009_2002_2004_2007_2006_2004_2006_2004_2003(528 1)
	{
		if (this.flag2)
		{
			throw new ObjectDisposedException("DeflateStream");
		}
		this.zlibBaseStream.flushMode = 1;
	}

	// Token: 0x060019D4 RID: 6612 RVA: 0x0005EF50 File Offset: 0x0005D150
	public 417 _0002_200B_2009_200B_2005_2007_2002_2000_2008_2004_2003_2007_2005_2009_2009_2005()
	{
		return this.zlibBaseStream._recoveredType05489037;
	}

	// Token: 0x060019D5 RID: 6613 RVA: 0x0005EF5D File Offset: 0x0005D15D
	public void _000F_2002_200A_2009_2005_200B_2000_2007_2006_2005_200A_2005_2005_2006_2007_2000_2006_200B_2009_200A_2003_2006_2007_2004_200B_2004_2008_2005_2001_2006(417 1)
	{
		if (this.flag2)
		{
			throw new ObjectDisposedException("DeflateStream");
		}
		this.zlibBaseStream._recoveredType05489037 = 1;
	}

	// Token: 0x060019D6 RID: 6614 RVA: 0x0005EF7E File Offset: 0x0005D17E
	public long _0008_2008_2005_2000_2009_2009_2005_2008_2008_2006_2001_2001()
	{
		return this.zlibBaseStream.zlibCodec.number8;
	}

	// Token: 0x060019D7 RID: 6615 RVA: 0x0005EF90 File Offset: 0x0005D190
	public long _0005_2000_2008_2002_2002_2004_2007_2006_200A_2002_200B_2002_2005_200B_2001()
	{
		return this.zlibBaseStream.zlibCodec.number9;
	}

	// Token: 0x04000C1E RID: 3102
	internal 988 zlibBaseStream;

	// Token: 0x04000C1F RID: 3103
	private bool flag2;
}
