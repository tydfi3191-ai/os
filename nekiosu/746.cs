using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x0200034A RID: 842
[ComVisible(false)]
public sealed class 746 : Stream
{
	// Token: 0x17000131 RID: 305
	// (get) Token: 0x06001A16 RID: 6678 RVA: 0x00060C3C File Offset: 0x0005EE3C
	public override bool CanRead
	{
		get
		{
			if (this.flag2)
			{
				throw new ObjectDisposedException("ZlibStream");
			}
			return this.zlibBaseStream.innerStream.CanRead;
		}
	}

	// Token: 0x17000132 RID: 306
	// (get) Token: 0x06001A17 RID: 6679 RVA: 0x0000FF75 File Offset: 0x0000E175
	public override bool CanSeek
	{
		get
		{
			return false;
		}
	}

	// Token: 0x17000133 RID: 307
	// (get) Token: 0x06001A18 RID: 6680 RVA: 0x00060C61 File Offset: 0x0005EE61
	public override bool CanWrite
	{
		get
		{
			if (this.flag2)
			{
				throw new ObjectDisposedException("ZlibStream");
			}
			return this.zlibBaseStream.innerStream.CanWrite;
		}
	}

	// Token: 0x17000134 RID: 308
	// (get) Token: 0x06001A19 RID: 6681 RVA: 0x00053ADC File Offset: 0x00051CDC
	public override long Length
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	// Token: 0x17000135 RID: 309
	// (get) Token: 0x06001A1A RID: 6682 RVA: 0x00060C88 File Offset: 0x0005EE88
	// (set) Token: 0x06001A1B RID: 6683 RVA: 0x00053ADC File Offset: 0x00051CDC
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

	// Token: 0x06001A1C RID: 6684 RVA: 0x00060CD4 File Offset: 0x0005EED4
	public 746(Stream 1, 777 2) : this(1, 2, (724)6, false)
	{
	}

	// Token: 0x06001A1D RID: 6685 RVA: 0x00060CE0 File Offset: 0x0005EEE0
	public 746(Stream 1, 777 2, 724 3) : this(1, 2, 3, false)
	{
	}

	// Token: 0x06001A1E RID: 6686 RVA: 0x00060CEC File Offset: 0x0005EEEC
	public 746(Stream 1, 777 2, bool 3) : this(1, 2, (724)6, 3)
	{
	}

	// Token: 0x06001A1F RID: 6687 RVA: 0x00060CF8 File Offset: 0x0005EEF8
	public 746(Stream 1, 777 2, 724 3, bool 4)
	{
		this.zlibBaseStream = new 988(1, 2, 3, (438)1950, 4);
	}

	// Token: 0x06001A20 RID: 6688 RVA: 0x00060D18 File Offset: 0x0005EF18
	public static byte[] Method12125(byte[] 1)
	{
		MemoryStream memoryStream = new MemoryStream();
		byte[] result;
		try
		{
			Stream stream = new 746(memoryStream, (777)0, (724)9);
			try
			{
				stream.Write(1, 0, 1.Length);
			}
			finally
			{
				((IDisposable)stream).Dispose();
			}
			result = memoryStream.ToArray();
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
		return result;
	}

	// Token: 0x06001A21 RID: 6689 RVA: 0x00060D78 File Offset: 0x0005EF78
	public static byte[] Method12126(string 1)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(1);
		MemoryStream memoryStream = new MemoryStream();
		byte[] result;
		try
		{
			Stream stream = new 746(memoryStream, (777)0, (724)9);
			try
			{
				stream.Write(bytes, 0, bytes.Length);
			}
			finally
			{
				((IDisposable)stream).Dispose();
			}
			result = memoryStream.ToArray();
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
		return result;
	}

	// Token: 0x06001A22 RID: 6690 RVA: 0x00060DE4 File Offset: 0x0005EFE4
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

	// Token: 0x06001A23 RID: 6691 RVA: 0x00060E30 File Offset: 0x0005F030
	public override void Flush()
	{
		if (this.flag2)
		{
			throw new ObjectDisposedException("ZlibStream");
		}
		this.zlibBaseStream.Flush();
	}

	// Token: 0x06001A24 RID: 6692 RVA: 0x00060E50 File Offset: 0x0005F050
	public override int Read(byte[] 1, int 2, int 3)
	{
		if (this.flag2)
		{
			throw new ObjectDisposedException("ZlibStream");
		}
		return this.zlibBaseStream.Read(1, 2, 3);
	}

	// Token: 0x06001A25 RID: 6693 RVA: 0x00053ADC File Offset: 0x00051CDC
	public override long Seek(long 1, SeekOrigin 2)
	{
		throw new NotImplementedException();
	}

	// Token: 0x06001A26 RID: 6694 RVA: 0x00053ADC File Offset: 0x00051CDC
	public override void SetLength(long 1)
	{
		throw new NotImplementedException();
	}

	// Token: 0x06001A27 RID: 6695 RVA: 0x00060E74 File Offset: 0x0005F074
	public static byte[] Method12127(byte[] 1)
	{
		byte[] array = new byte[1024];
		MemoryStream memoryStream = new MemoryStream();
		byte[] result;
		try
		{
			MemoryStream memoryStream2 = new MemoryStream(1);
			try
			{
				Stream stream = new 746(memoryStream2, (777)1);
				try
				{
					int count;
					while ((count = stream.Read(array, 0, array.Length)) != 0)
					{
						memoryStream.Write(array, 0, count);
					}
				}
				finally
				{
					((IDisposable)stream).Dispose();
				}
				result = memoryStream.ToArray();
			}
			finally
			{
				((IDisposable)memoryStream2).Dispose();
			}
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
		return result;
	}

	// Token: 0x06001A28 RID: 6696 RVA: 0x00060F08 File Offset: 0x0005F108
	public static string Method12128(byte[] 1)
	{
		byte[] array = new byte[1024];
		Encoding utf = Encoding.UTF8;
		MemoryStream memoryStream = new MemoryStream();
		string result;
		try
		{
			MemoryStream memoryStream2 = new MemoryStream(1);
			try
			{
				Stream stream = new 746(memoryStream2, (777)1);
				try
				{
					int count;
					while ((count = stream.Read(array, 0, array.Length)) != 0)
					{
						memoryStream.Write(array, 0, count);
					}
				}
				finally
				{
					((IDisposable)stream).Dispose();
				}
				memoryStream.Seek(0L, SeekOrigin.Begin);
				result = new StreamReader(memoryStream, utf).ReadToEnd();
			}
			finally
			{
				((IDisposable)memoryStream2).Dispose();
			}
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
		return result;
	}

	// Token: 0x06001A29 RID: 6697 RVA: 0x00060FB8 File Offset: 0x0005F1B8
	public override void Write(byte[] 1, int 2, int 3)
	{
		if (this.flag2)
		{
			throw new ObjectDisposedException("ZlibStream");
		}
		this.zlibBaseStream.Write(1, 2, 3);
	}

	// Token: 0x06001A2A RID: 6698 RVA: 0x00060FDB File Offset: 0x0005F1DB
	public int _0006_200A_2006_2004_200B_2001_2007_2002_2000_2001_2004_2009_200B_2009_2009_200A_2005_2007_2004_2005_2004_200B_2003_2002_2008_2009()
	{
		return this.zlibBaseStream.bufferSize;
	}

	// Token: 0x06001A2B RID: 6699 RVA: 0x00060FE8 File Offset: 0x0005F1E8
	public void _0006_2004_2008_2007_2006_2008_2009_2001_2003_2009_2004_2004_2001_2002_2002_2007_2006_200A_2001_2003_2002_2001_200B_2009_2009_2008_2001_2008_2003_2004(int 1)
	{
		if (this.flag2)
		{
			throw new ObjectDisposedException("ZlibStream");
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

	// Token: 0x06001A2C RID: 6700 RVA: 0x0006104A File Offset: 0x0005F24A
	public 528 _0005_2007_2002_2000_2002_2009_2003_200A_2007_2000_200B_200B_2006_2005_200A_200B_2007()
	{
		return this.zlibBaseStream.flushMode;
	}

	// Token: 0x06001A2D RID: 6701 RVA: 0x00061057 File Offset: 0x0005F257
	public void _0003_2006_2008_200B_2000_2007_2003_2005_2009_200A_2006_200B_200A_2009_2007_2005_2001_2004_2007_2000_2009_2007_200A_2009_2009_200A_2006_2003_200A(528 1)
	{
		if (this.flag2)
		{
			throw new ObjectDisposedException("ZlibStream");
		}
		this.zlibBaseStream.flushMode = 1;
	}

	// Token: 0x06001A2E RID: 6702 RVA: 0x00061078 File Offset: 0x0005F278
	public long _0002_2003_2008_2008_2004_200B_2008_2006_2009_2005_2005_2004_2008_2007_2002_200A_2001_2007_2003_200B()
	{
		return this.zlibBaseStream.zlibCodec.number8;
	}

	// Token: 0x06001A2F RID: 6703 RVA: 0x0006108A File Offset: 0x0005F28A
	public long _0005_2005_2002_2005_2008_2009_2000_2004_200B_2004_2000_2008()
	{
		return this.zlibBaseStream.zlibCodec.number9;
	}

	// Token: 0x04000C60 RID: 3168
	internal 988 zlibBaseStream;

	// Token: 0x04000C61 RID: 3169
	private bool flag2;
}
