using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x0200033E RID: 830
[ComVisible(false)]
public sealed class 481 : Stream
{
	// Token: 0x17000122 RID: 290
	// (get) Token: 0x0600199D RID: 6557 RVA: 0x0005E599 File Offset: 0x0005C799
	public override bool CanRead
	{
		get
		{
			if (this.flag2)
			{
				throw new ObjectDisposedException("GZipStream");
			}
			return this.zlibBaseStream.innerStream.CanRead;
		}
	}

	// Token: 0x17000123 RID: 291
	// (get) Token: 0x0600199E RID: 6558 RVA: 0x0000FF75 File Offset: 0x0000E175
	public override bool CanSeek
	{
		get
		{
			return false;
		}
	}

	// Token: 0x17000124 RID: 292
	// (get) Token: 0x0600199F RID: 6559 RVA: 0x0005E5BE File Offset: 0x0005C7BE
	public override bool CanWrite
	{
		get
		{
			if (this.flag2)
			{
				throw new ObjectDisposedException("GZipStream");
			}
			return this.zlibBaseStream.innerStream.CanWrite;
		}
	}

	// Token: 0x17000125 RID: 293
	// (get) Token: 0x060019A0 RID: 6560 RVA: 0x00053ADC File Offset: 0x00051CDC
	public override long Length
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	// Token: 0x17000126 RID: 294
	// (get) Token: 0x060019A1 RID: 6561 RVA: 0x0005E5E4 File Offset: 0x0005C7E4
	// (set) Token: 0x060019A2 RID: 6562 RVA: 0x00053ADC File Offset: 0x00051CDC
	public override long Position
	{
		get
		{
			if (this.zlibBaseStream.streamMode == (988.989)0)
			{
				return this.zlibBaseStream.zlibCodec.number9 + (long)this.number4;
			}
			if (this.zlibBaseStream.streamMode == (988.989)1)
			{
				return this.zlibBaseStream.zlibCodec.number8 + (long)this.zlibBaseStream.gzipHeaderByteCount;
			}
			return 0L;
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	// Token: 0x060019A3 RID: 6563 RVA: 0x0005E645 File Offset: 0x0005C845
	public 481(Stream 1, 777 2) : this(1, 2, (724)6, false)
	{
	}

	// Token: 0x060019A4 RID: 6564 RVA: 0x0005E651 File Offset: 0x0005C851
	public 481(Stream 1, 777 2, 724 3) : this(1, 2, 3, false)
	{
	}

	// Token: 0x060019A5 RID: 6565 RVA: 0x0005E65D File Offset: 0x0005C85D
	public 481(Stream 1, 777 2, bool 3) : this(1, 2, (724)6, 3)
	{
	}

	// Token: 0x060019A6 RID: 6566 RVA: 0x0005E669 File Offset: 0x0005C869
	public 481(Stream 1, 777 2, 724 3, bool 4)
	{
		this.zlibBaseStream = new 988(1, 2, 3, (438)1952, 4);
	}

	// Token: 0x060019A7 RID: 6567 RVA: 0x0005E688 File Offset: 0x0005C888
	public static byte[] Method4593(byte[] 1)
	{
		MemoryStream memoryStream = new MemoryStream();
		byte[] result;
		try
		{
			Stream stream = new 481(memoryStream, (777)0, (724)9);
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

	// Token: 0x060019A8 RID: 6568 RVA: 0x0005E6E8 File Offset: 0x0005C8E8
	public static byte[] Method4594(string 1)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(1);
		MemoryStream memoryStream = new MemoryStream();
		byte[] result;
		try
		{
			Stream stream = new 481(memoryStream, (777)0, (724)9);
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

	// Token: 0x060019A9 RID: 6569 RVA: 0x0005E754 File Offset: 0x0005C954
	protected override void Dispose(bool 1)
	{
		try
		{
			if (!this.flag2)
			{
				if (1 && this.zlibBaseStream != null)
				{
					this.zlibBaseStream.Close();
					this.number3 = this.zlibBaseStream.GetCrc32();
				}
				this.flag2 = true;
			}
		}
		finally
		{
			base.Dispose(1);
		}
	}

	// Token: 0x060019AA RID: 6570 RVA: 0x0005E7B4 File Offset: 0x0005C9B4
	private int Method4595()
	{
		byte[] array = (this._0003_200B_2007_2002_2002_2004_2005_2007_2006_2004_2006_2005_2001_2008_2005_200B_2006_2005_2002_2001_200B_200B_2002() == null) ? null : 481.encoding.GetBytes(this._0003_200B_2007_2002_2002_2004_2005_2007_2006_2004_2006_2005_2001_2008_2005_200B_2006_2005_2002_2001_200B_200B_2002());
		byte[] array2 = (this._0005_2002_2005_2007_2002_2005_2008_2005_200B_2009_200A_200B_2008_2001_2006_2008_200B() == null) ? null : 481.encoding.GetBytes(this._0005_2002_2005_2007_2002_2005_2008_2005_200B_2009_200A_200B_2008_2001_2006_2008_200B());
		int num = (this._0003_200B_2007_2002_2002_2004_2005_2007_2006_2004_2006_2005_2001_2008_2005_200B_2006_2005_2002_2001_200B_200B_2002() != null) ? (array.Length + 1) : 0;
		int num2 = (this._0005_2002_2005_2007_2002_2005_2008_2005_200B_2009_200A_200B_2008_2001_2006_2008_200B() != null) ? (array2.Length + 1) : 0;
		byte[] array3 = new byte[10 + num + num2];
		int num3 = 0;
		array3[num3++] = 31;
		array3[num3++] = 139;
		array3[num3++] = 8;
		byte b = 0;
		if (this._0003_200B_2007_2002_2002_2004_2005_2007_2006_2004_2006_2005_2001_2008_2005_200B_2006_2005_2002_2001_200B_200B_2002() != null)
		{
			b ^= 16;
		}
		if (this._0005_2002_2005_2007_2002_2005_2008_2005_200B_2009_200A_200B_2008_2001_2006_2008_200B() != null)
		{
			b ^= 8;
		}
		array3[num3++] = b;
		if (this.nullable == null)
		{
			this.nullable = new DateTime?(DateTime.Now);
		}
		Array.Copy(BitConverter.GetBytes((int)(this.nullable.Value - 481.dateTime).TotalSeconds), 0, array3, num3, 4);
		num3 += 4;
		array3[num3++] = 0;
		array3[num3++] = byte.MaxValue;
		if (num2 != 0)
		{
			Array.Copy(array2, 0, array3, num3, num2 - 1);
			num3 += num2 - 1;
			array3[num3++] = 0;
		}
		if (num != 0)
		{
			Array.Copy(array, 0, array3, num3, num - 1);
			num3 += num - 1;
			array3[num3++] = 0;
		}
		this.zlibBaseStream.innerStream.Write(array3, 0, array3.Length);
		return array3.Length;
	}

	// Token: 0x060019AB RID: 6571 RVA: 0x0005E94E File Offset: 0x0005CB4E
	public override void Flush()
	{
		if (this.flag2)
		{
			throw new ObjectDisposedException("GZipStream");
		}
		this.zlibBaseStream.Flush();
	}

	// Token: 0x060019AC RID: 6572 RVA: 0x0005E970 File Offset: 0x0005CB70
	public override int Read(byte[] 1, int 2, int 3)
	{
		if (this.flag2)
		{
			throw new ObjectDisposedException("GZipStream");
		}
		int result = this.zlibBaseStream.Read(1, 2, 3);
		if (!this.flag3)
		{
			this.flag3 = true;
			this._000E_200B_2006_2009_2005_2006_200A_2008_2007_2007_2006_2005_2008_2001_2005_2006_2001_2008_2006_2004(this.zlibBaseStream.gzipFileName);
			this._0002_2001_200B_2003_2005_2001_200B_2007_2004_2009_2005_200A_200A_2004_2007_200B_2002_2009_2004_2005(this.zlibBaseStream.text);
		}
		return result;
	}

	// Token: 0x060019AD RID: 6573 RVA: 0x00053ADC File Offset: 0x00051CDC
	public override long Seek(long 1, SeekOrigin 2)
	{
		throw new NotImplementedException();
	}

	// Token: 0x060019AE RID: 6574 RVA: 0x00053ADC File Offset: 0x00051CDC
	public override void SetLength(long 1)
	{
		throw new NotImplementedException();
	}

	// Token: 0x060019AF RID: 6575 RVA: 0x0005E9D0 File Offset: 0x0005CBD0
	public static byte[] Method4596(byte[] 1)
	{
		byte[] array = new byte[1024];
		MemoryStream memoryStream = new MemoryStream();
		byte[] result;
		try
		{
			MemoryStream memoryStream2 = new MemoryStream(1);
			try
			{
				Stream stream = new 481(memoryStream2, (777)1);
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

	// Token: 0x060019B0 RID: 6576 RVA: 0x0005EA64 File Offset: 0x0005CC64
	public static string Method4597(byte[] 1)
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
				Stream stream = new 481(memoryStream2, (777)1);
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

	// Token: 0x060019B1 RID: 6577 RVA: 0x0005EB14 File Offset: 0x0005CD14
	public override void Write(byte[] 1, int 2, int 3)
	{
		if (this.flag2)
		{
			throw new ObjectDisposedException("GZipStream");
		}
		if (this.zlibBaseStream.streamMode == (988.989)2)
		{
			if (!this.zlibBaseStream.IsCompressing())
			{
				throw new InvalidOperationException();
			}
			this.number4 = this.Method4595();
		}
		this.zlibBaseStream.Write(1, 2, 3);
	}

	// Token: 0x060019B2 RID: 6578 RVA: 0x0005EB6F File Offset: 0x0005CD6F
	public int _0008_2007_2008_2004_2006_2006_200B_2002_2007_200B_200A_2009_2000_2002_2008_200A_2007_2006_2000_2008_2005_2008()
	{
		return this.zlibBaseStream.bufferSize;
	}

	// Token: 0x060019B3 RID: 6579 RVA: 0x0005EB7C File Offset: 0x0005CD7C
	public void _0003_2008_2006_2004_2008_200B_2003_2002_2005_2003_200B_2002_2005_200B_200A_200B_2001_2003_2004_2006_2005_2006_2003_2006_2003_2003_2001_2003_2004_2008(int 1)
	{
		if (this.flag2)
		{
			throw new ObjectDisposedException("GZipStream");
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

	// Token: 0x060019B4 RID: 6580 RVA: 0x0005EBDE File Offset: 0x0005CDDE
	public string _0003_200B_2007_2002_2002_2004_2005_2007_2006_2004_2006_2005_2001_2008_2005_200B_2006_2005_2002_2001_200B_200B_2002()
	{
		return this.text2;
	}

	// Token: 0x060019B5 RID: 6581 RVA: 0x0005EBE6 File Offset: 0x0005CDE6
	public void _0002_2001_200B_2003_2005_2001_200B_2007_2004_2009_2005_200A_200A_2004_2007_200B_2002_2009_2004_2005(string 1)
	{
		if (this.flag2)
		{
			throw new ObjectDisposedException("GZipStream");
		}
		this.text2 = 1;
	}

	// Token: 0x060019B6 RID: 6582 RVA: 0x0005EC02 File Offset: 0x0005CE02
	public int _0006_2003_2006_2008_200A_2002_2002_2002_2003_2004_2003_2001_2000_2002_2007_200A_2000_2004_2004()
	{
		return this.number3;
	}

	// Token: 0x060019B7 RID: 6583 RVA: 0x0005EC0A File Offset: 0x0005CE0A
	public string _0005_2002_2005_2007_2002_2005_2008_2005_200B_2009_200A_200B_2008_2001_2006_2008_200B()
	{
		return this.text3;
	}

	// Token: 0x060019B8 RID: 6584 RVA: 0x0005EC14 File Offset: 0x0005CE14
	public void _000E_200B_2006_2009_2005_2006_200A_2008_2007_2007_2006_2005_2008_2001_2005_2006_2001_2008_2006_2004(string 1)
	{
		if (this.flag2)
		{
			throw new ObjectDisposedException("GZipStream");
		}
		this.text3 = 1;
		if (this.text3 != null)
		{
			if (this.text3.IndexOf("/") != -1)
			{
				this.text3 = this.text3.Replace('/', '\\');
			}
			if (this.text3.EndsWith("\\"))
			{
				throw new Exception("Illegal filename");
			}
			if (this.text3.IndexOf("\\") != -1)
			{
				this.text3 = Path.GetFileName(this.text3);
			}
		}
	}

	// Token: 0x060019B9 RID: 6585 RVA: 0x0005ECAC File Offset: 0x0005CEAC
	public 528 _0003_2008_200B_2009_2003_2000_2001_2003_2007_2006_200A_200B_2004_2002_2000_200B_2005_2006_2009_2002_2008_2000_2000_2008_2001_2008_2008_2007()
	{
		return this.zlibBaseStream.flushMode;
	}

	// Token: 0x060019BA RID: 6586 RVA: 0x0005ECB9 File Offset: 0x0005CEB9
	public void _0006_2004_2005_200A_200B_200A_2004_2001_200B_2007_2001(528 1)
	{
		if (this.flag2)
		{
			throw new ObjectDisposedException("GZipStream");
		}
		this.zlibBaseStream.flushMode = 1;
	}

	// Token: 0x060019BB RID: 6587 RVA: 0x0005ECDA File Offset: 0x0005CEDA
	public long _0006_2005_2004_2002_2004_2002_200A_2006_2004_2005_200B_2001_2004_2006_200A()
	{
		return this.zlibBaseStream.zlibCodec.number8;
	}

	// Token: 0x060019BC RID: 6588 RVA: 0x0005ECEC File Offset: 0x0005CEEC
	public long _000F_2008_2004_2004_200B_200A_2003_2005_2005_2004_2006_2000_2009_2008_2003_2001_2007()
	{
		return this.zlibBaseStream.zlibCodec.number9;
	}

	// Token: 0x04000C14 RID: 3092
	internal 988 zlibBaseStream;

	// Token: 0x04000C15 RID: 3093
	private string text2;

	// Token: 0x04000C16 RID: 3094
	private int number3;

	// Token: 0x04000C17 RID: 3095
	private bool flag2;

	// Token: 0x04000C18 RID: 3096
	private string text3;

	// Token: 0x04000C19 RID: 3097
	private bool flag3;

	// Token: 0x04000C1A RID: 3098
	private int number4;

	// Token: 0x04000C1B RID: 3099
	internal static DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

	// Token: 0x04000C1C RID: 3100
	internal static Encoding encoding = Encoding.GetEncoding("iso-8859-1");

	// Token: 0x04000C1D RID: 3101
	public DateTime? nullable;
}
