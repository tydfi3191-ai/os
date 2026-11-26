using System;
using System.IO;
using System.Runtime.InteropServices;

// Token: 0x020002F3 RID: 755
[ComVisible(false)]
public class 494 : Stream
{
	// Token: 0x170000F5 RID: 245
	// (get) Token: 0x06001695 RID: 5781 RVA: 0x0004E04B File Offset: 0x0004C24B
	public override bool CanRead
	{
		get
		{
			return this.stream2.CanRead;
		}
	}

	// Token: 0x170000F6 RID: 246
	// (get) Token: 0x06001696 RID: 5782 RVA: 0x0000FF75 File Offset: 0x0000E175
	public override bool CanSeek
	{
		get
		{
			return false;
		}
	}

	// Token: 0x170000F7 RID: 247
	// (get) Token: 0x06001697 RID: 5783 RVA: 0x0000FF75 File Offset: 0x0000E175
	public override bool CanWrite
	{
		get
		{
			return false;
		}
	}

	// Token: 0x170000F8 RID: 248
	// (get) Token: 0x06001698 RID: 5784 RVA: 0x0004E058 File Offset: 0x0004C258
	public override long Length
	{
		get
		{
			return (long)this.inflaterInputBuffer.GetRawLength();
		}
	}

	// Token: 0x170000F9 RID: 249
	// (get) Token: 0x06001699 RID: 5785 RVA: 0x0004E066 File Offset: 0x0004C266
	// (set) Token: 0x0600169A RID: 5786 RVA: 0x0004E073 File Offset: 0x0004C273
	public override long Position
	{
		get
		{
			return this.stream2.Position;
		}
		set
		{
			throw new NotSupportedException("InflaterInputStream Position not supported");
		}
	}

	// Token: 0x0600169B RID: 5787 RVA: 0x0004E07F File Offset: 0x0004C27F
	public 494(Stream 1) : this(1, new 105(), 4096)
	{
	}

	// Token: 0x0600169C RID: 5788 RVA: 0x0004E092 File Offset: 0x0004C292
	public 494(Stream 1, 105 2) : this(1, 2, 4096)
	{
	}

	// Token: 0x0600169D RID: 5789 RVA: 0x0004E0A4 File Offset: 0x0004C2A4
	public 494(Stream 1, 105 2, int 3)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("baseInputStream");
		}
		if (2 == null)
		{
			throw new ArgumentNullException("inflater");
		}
		if (3 <= 0)
		{
			throw new ArgumentOutOfRangeException("bufferSize");
		}
		this.stream2 = 1;
		this.inflater2 = 2;
		this.inflaterInputBuffer = new 106(1, 3);
	}

	// Token: 0x0600169E RID: 5790 RVA: 0x0004E104 File Offset: 0x0004C304
	public bool _000F_200B_2001_200A_200A_2002_2006_2008_2000_2001_2000_2006_200B_2006_2004_2001_2007_2007_2007_2009()
	{
		return this.flag3;
	}

	// Token: 0x0600169F RID: 5791 RVA: 0x0004E10C File Offset: 0x0004C30C
	public void _0003_2007_2001_2009_2004_200A_2009_2000_200B_2002_200A_2000_2008_2005_200A_2004_2007_2002_2007_2009(bool 1)
	{
		this.flag3 = 1;
	}

	// Token: 0x060016A0 RID: 5792 RVA: 0x0004E118 File Offset: 0x0004C318
	public long _0002_2000_2004_2003_2000_2007_2007_2007_2007_2000_2005_2007(long 1)
	{
		if (1 <= 0L)
		{
			throw new ArgumentOutOfRangeException("#=zW32YDQ0=");
		}
		if (this.stream2.CanSeek)
		{
			this.stream2.Seek(1, SeekOrigin.Current);
			return 1;
		}
		int num = 2048;
		if (1 < (long)num)
		{
			num = (int)1;
		}
		byte[] buffer = new byte[num];
		int num2 = 1;
		long num3 = 1;
		while (num3 > 0L && num2 > 0)
		{
			if (num3 < (long)num)
			{
				num = (int)num3;
			}
			num2 = this.stream2.Read(buffer, 0, num);
			num3 -= (long)num2;
		}
		return 1 - num3;
	}

	// Token: 0x060016A1 RID: 5793 RVA: 0x0004E195 File Offset: 0x0004C395
	protected void Method5398()
	{
		this.inflaterInputBuffer.SetCryptoTransform(null);
	}

	// Token: 0x060016A2 RID: 5794 RVA: 0x0004E1A3 File Offset: 0x0004C3A3
	public virtual int _0008_2008_2005_2001_2001_2006_2008_2003_2005_2001_2001_200A_2004_2002_2009_2003_2008()
	{
		if (!this.inflater2.IsFinished())
		{
			return 1;
		}
		return 0;
	}

	// Token: 0x060016A3 RID: 5795 RVA: 0x0004E1B8 File Offset: 0x0004C3B8
	protected void Method5399()
	{
		if (this.inflaterInputBuffer.GetAvailable() <= 0)
		{
			this.inflaterInputBuffer.Fill();
			if (this.inflaterInputBuffer.GetAvailable() <= 0)
			{
				throw new 657("Unexpected EOF");
			}
		}
		this.inflaterInputBuffer.SetInflaterInput(this.inflater2);
	}

	// Token: 0x060016A4 RID: 5796 RVA: 0x0004E208 File Offset: 0x0004C408
	public override void Flush()
	{
		this.stream2.Flush();
	}

	// Token: 0x060016A5 RID: 5797 RVA: 0x0004E215 File Offset: 0x0004C415
	public override long Seek(long 1, SeekOrigin 2)
	{
		throw new NotSupportedException("Seek not supported");
	}

	// Token: 0x060016A6 RID: 5798 RVA: 0x0004E221 File Offset: 0x0004C421
	public override void SetLength(long 1)
	{
		throw new NotSupportedException("InflaterInputStream SetLength not supported");
	}

	// Token: 0x060016A7 RID: 5799 RVA: 0x0004E22D File Offset: 0x0004C42D
	public override void Write(byte[] 1, int 2, int 3)
	{
		throw new NotSupportedException("InflaterInputStream Write not supported");
	}

	// Token: 0x060016A8 RID: 5800 RVA: 0x0004E239 File Offset: 0x0004C439
	public override void WriteByte(byte 1)
	{
		throw new NotSupportedException("InflaterInputStream WriteByte not supported");
	}

	// Token: 0x060016A9 RID: 5801 RVA: 0x0004E245 File Offset: 0x0004C445
	public override IAsyncResult BeginWrite(byte[] 1, int 2, int 3, AsyncCallback 4, object 5)
	{
		throw new NotSupportedException("InflaterInputStream BeginWrite not supported");
	}

	// Token: 0x060016AA RID: 5802 RVA: 0x0004E251 File Offset: 0x0004C451
	public override void Close()
	{
		if (!this.flag2)
		{
			this.flag2 = true;
			if (this.flag3)
			{
				this.stream2.Close();
			}
		}
	}

	// Token: 0x060016AB RID: 5803 RVA: 0x0004E278 File Offset: 0x0004C478
	public override int Read(byte[] 1, int 2, int 3)
	{
		if (this.inflater2.IsNeedingDictionary())
		{
			throw new 657("Need a dictionary");
		}
		int num = 3;
		for (;;)
		{
			int num2 = this.inflater2.Method10664(1, 2, num);
			2 += num2;
			num -= num2;
			if (num == 0 || this.inflater2.IsFinished())
			{
				goto IL_65;
			}
			if (this.inflater2.IsNeedingInput())
			{
				this.Method5399();
			}
			else if (num2 == 0)
			{
				break;
			}
		}
		throw new 415("Dont know what to do");
		IL_65:
		return 3 - num;
	}

	// Token: 0x04000A9B RID: 2715
	protected 105 inflater2;

	// Token: 0x04000A9C RID: 2716
	protected 106 inflaterInputBuffer;

	// Token: 0x04000A9D RID: 2717
	private Stream stream2;

	// Token: 0x04000A9E RID: 2718
	protected long number6;

	// Token: 0x04000A9F RID: 2719
	private bool flag2;

	// Token: 0x04000AA0 RID: 2720
	private bool flag3 = true;
}
