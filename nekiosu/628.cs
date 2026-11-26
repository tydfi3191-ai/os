using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

// Token: 0x02000303 RID: 771
[ComVisible(false)]
public class 628 : Stream
{
	// Token: 0x17000103 RID: 259
	// (get) Token: 0x06001715 RID: 5909 RVA: 0x0000FF75 File Offset: 0x0000E175
	public override bool CanRead
	{
		get
		{
			return false;
		}
	}

	// Token: 0x17000104 RID: 260
	// (get) Token: 0x06001716 RID: 5910 RVA: 0x0000FF75 File Offset: 0x0000E175
	public override bool CanSeek
	{
		get
		{
			return false;
		}
	}

	// Token: 0x17000105 RID: 261
	// (get) Token: 0x06001717 RID: 5911 RVA: 0x0004FC30 File Offset: 0x0004DE30
	public override bool CanWrite
	{
		get
		{
			return this.stream2.CanWrite;
		}
	}

	// Token: 0x17000106 RID: 262
	// (get) Token: 0x06001718 RID: 5912 RVA: 0x0004FC3D File Offset: 0x0004DE3D
	public override long Length
	{
		get
		{
			return this.stream2.Length;
		}
	}

	// Token: 0x17000107 RID: 263
	// (get) Token: 0x06001719 RID: 5913 RVA: 0x0004FC4A File Offset: 0x0004DE4A
	// (set) Token: 0x0600171A RID: 5914 RVA: 0x0004FC57 File Offset: 0x0004DE57
	public override long Position
	{
		get
		{
			return this.stream2.Position;
		}
		set
		{
			throw new NotSupportedException("Position property not supported");
		}
	}

	// Token: 0x0600171B RID: 5915 RVA: 0x0004FC63 File Offset: 0x0004DE63
	public 628(Stream 1) : this(1, new 51(), 512)
	{
	}

	// Token: 0x0600171C RID: 5916 RVA: 0x0004FC76 File Offset: 0x0004DE76
	public 628(Stream 1, 51 2) : this(1, 2, 512)
	{
	}

	// Token: 0x0600171D RID: 5917 RVA: 0x0004FC88 File Offset: 0x0004DE88
	public 628(Stream 1, 51 2, int 3)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("baseOutputStream");
		}
		if (!1.CanWrite)
		{
			throw new ArgumentException("Must support writing", "baseOutputStream");
		}
		if (2 == null)
		{
			throw new ArgumentNullException("deflater");
		}
		if (3 < 512)
		{
			throw new ArgumentOutOfRangeException("bufferSize");
		}
		this.stream2 = 1;
		this.byteArray5 = new byte[3];
		this.deflater2 = 2;
	}

	// Token: 0x0600171E RID: 5918 RVA: 0x0004FD04 File Offset: 0x0004DF04
	public virtual void _0006_2003_2009_2001_2002_200A_2006_2008_200B_2000_2004_2009_2009_2004_200A_2005_2007_2003_2005_2003_200B_2003_2002()
	{
		this.deflater2.Finish();
		while (!this.deflater2.IsFinished())
		{
			int num = this.deflater2.Method10469(this.byteArray5, 0, this.byteArray5.Length);
			if (num <= 0)
			{
				break;
			}
			if (this.iCryptoTransform != null)
			{
				this.Method9084(this.byteArray5, 0, num);
			}
			this.stream2.Write(this.byteArray5, 0, num);
		}
		if (!this.deflater2.IsFinished())
		{
			throw new 657("Can't deflate all input?");
		}
		this.stream2.Flush();
		if (this.iCryptoTransform != null)
		{
			if (this.iCryptoTransform is 413)
			{
				this.byteArray4 = ((413)this.iCryptoTransform).Method3085();
			}
			this.iCryptoTransform.Dispose();
			this.iCryptoTransform = null;
		}
	}

	// Token: 0x0600171F RID: 5919 RVA: 0x0004FDD3 File Offset: 0x0004DFD3
	public bool _0006_200A_200B_2004_2009_2005_200A_2000_2007_2001_2008_2003_2007_2000_200A_200A_2009_2000_2009_200B_2003_2002_2008_2000()
	{
		return this.flag4;
	}

	// Token: 0x06001720 RID: 5920 RVA: 0x0004FDDB File Offset: 0x0004DFDB
	public void _0005_2000_200A_200A_2009_200A_2006_2009_200A_2003_2003_2006_2006(bool 1)
	{
		this.flag4 = 1;
	}

	// Token: 0x06001721 RID: 5921 RVA: 0x0004FDE4 File Offset: 0x0004DFE4
	public bool _0002_2005_2009_200A_200A_2007_2005_2005_2009_2006_200B_2004_2008_2009_200A_2002_2006()
	{
		return this.stream2.CanSeek;
	}

	// Token: 0x06001722 RID: 5922 RVA: 0x0004FDF1 File Offset: 0x0004DFF1
	public string _0006_2000_2006_2003_2001_200B_2008_2001_2004_2006_2008_2006_2008_2001_2006_2004_200A_2004_2005_2007_2003_2009_2005()
	{
		return this.text2;
	}

	// Token: 0x06001723 RID: 5923 RVA: 0x0004FDF9 File Offset: 0x0004DFF9
	public void _000F_200B_2004_2005_2008_2005_2003_2000_2003_200A_2007_2002_2005_2006_2002_2005_2008_2002_2009_2000_200A_2006_2009_2004(string 1)
	{
		if (1 != null && 1.Length == 0)
		{
			this.text2 = null;
			return;
		}
		this.text2 = 1;
	}

	// Token: 0x06001724 RID: 5924 RVA: 0x0004FE15 File Offset: 0x0004E015
	protected void Method9084(byte[] 1, int 2, int 3)
	{
		this.iCryptoTransform.TransformBlock(1, 0, 3, 1, 0);
	}

	// Token: 0x06001725 RID: 5925 RVA: 0x0004FE28 File Offset: 0x0004E028
	protected void Method9085(string 1)
	{
		627 2 = new 627();
		byte[] rgbKey = 560.Method7523(448.Method4014(1));
		this.iCryptoTransform = 2.CreateEncryptor(rgbKey, null);
	}

	// Token: 0x06001726 RID: 5926 RVA: 0x0004FE58 File Offset: 0x0004E058
	protected void Method9086(783 1, string 2, out byte[] 3, out byte[] 4)
	{
		3 = new byte[1.Method12817()];
		if (628.rNGCryptoServiceProvider == null)
		{
			628.rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		}
		628.rNGCryptoServiceProvider.GetBytes(3);
		int 5 = 1.Method12814() / 8;
		this.iCryptoTransform = new 413(2, 3, 5, true);
		4 = ((413)this.iCryptoTransform).GetByteArray2458_3084();
	}

	// Token: 0x06001727 RID: 5927 RVA: 0x0004FEBC File Offset: 0x0004E0BC
	protected void Method9087()
	{
		while (!this.deflater2.IsNeedingInput())
		{
			int num = this.deflater2.Method10469(this.byteArray5, 0, this.byteArray5.Length);
			if (num <= 0)
			{
				break;
			}
			if (this.iCryptoTransform != null)
			{
				this.Method9084(this.byteArray5, 0, num);
			}
			this.stream2.Write(this.byteArray5, 0, num);
		}
		if (!this.deflater2.IsNeedingInput())
		{
			throw new 657("DeflaterOutputStream can't deflate all input?");
		}
	}

	// Token: 0x06001728 RID: 5928 RVA: 0x0004FF38 File Offset: 0x0004E138
	public override long Seek(long 1, SeekOrigin 2)
	{
		throw new NotSupportedException("DeflaterOutputStream Seek not supported");
	}

	// Token: 0x06001729 RID: 5929 RVA: 0x0004FF44 File Offset: 0x0004E144
	public override void SetLength(long 1)
	{
		throw new NotSupportedException("DeflaterOutputStream SetLength not supported");
	}

	// Token: 0x0600172A RID: 5930 RVA: 0x0004FF50 File Offset: 0x0004E150
	public override int ReadByte()
	{
		throw new NotSupportedException("DeflaterOutputStream ReadByte not supported");
	}

	// Token: 0x0600172B RID: 5931 RVA: 0x0004FF5C File Offset: 0x0004E15C
	public override int Read(byte[] 1, int 2, int 3)
	{
		throw new NotSupportedException("DeflaterOutputStream Read not supported");
	}

	// Token: 0x0600172C RID: 5932 RVA: 0x0004FF68 File Offset: 0x0004E168
	public override IAsyncResult BeginRead(byte[] 1, int 2, int 3, AsyncCallback 4, object 5)
	{
		throw new NotSupportedException("DeflaterOutputStream BeginRead not currently supported");
	}

	// Token: 0x0600172D RID: 5933 RVA: 0x0004FF74 File Offset: 0x0004E174
	public override IAsyncResult BeginWrite(byte[] 1, int 2, int 3, AsyncCallback 4, object 5)
	{
		throw new NotSupportedException("BeginWrite is not supported");
	}

	// Token: 0x0600172E RID: 5934 RVA: 0x0004FF80 File Offset: 0x0004E180
	public override void Flush()
	{
		this.deflater2.Flush();
		this.Method9087();
		this.stream2.Flush();
	}

	// Token: 0x0600172F RID: 5935 RVA: 0x0004FFA0 File Offset: 0x0004E1A0
	public override void Close()
	{
		if (this.flag3)
		{
			return;
		}
		this.flag3 = true;
		try
		{
			this._0006_2003_2009_2001_2002_200A_2006_2008_200B_2000_2004_2009_2009_2004_200A_2005_2007_2003_2005_2003_200B_2003_2002();
			if (this.iCryptoTransform != null)
			{
				this.Method9088();
				this.iCryptoTransform.Dispose();
				this.iCryptoTransform = null;
			}
		}
		finally
		{
			if (this.flag4)
			{
				this.stream2.Close();
			}
		}
	}

	// Token: 0x06001730 RID: 5936 RVA: 0x0005000C File Offset: 0x0004E20C
	private void Method9088()
	{
		if (this.iCryptoTransform is 413)
		{
			this.byteArray4 = ((413)this.iCryptoTransform).Method3085();
		}
	}

	// Token: 0x06001731 RID: 5937 RVA: 0x00050031 File Offset: 0x0004E231
	public override void WriteByte(byte 1)
	{
		this.Write(new byte[]
		{
			1
		}, 0, 1);
	}

	// Token: 0x06001732 RID: 5938 RVA: 0x00050045 File Offset: 0x0004E245
	public override void Write(byte[] 1, int 2, int 3)
	{
		this.deflater2.Method10464(1, 2, 3);
		this.Method9087();
	}

	// Token: 0x04000ADA RID: 2778
	private string text2;

	// Token: 0x04000ADB RID: 2779
	private ICryptoTransform iCryptoTransform;

	// Token: 0x04000ADC RID: 2780
	protected byte[] byteArray4;

	// Token: 0x04000ADD RID: 2781
	private byte[] byteArray5;

	// Token: 0x04000ADE RID: 2782
	protected 51 deflater2;

	// Token: 0x04000ADF RID: 2783
	protected Stream stream2;

	// Token: 0x04000AE0 RID: 2784
	private bool flag3;

	// Token: 0x04000AE1 RID: 2785
	private bool flag4 = true;

	// Token: 0x04000AE2 RID: 2786
	private static RNGCryptoServiceProvider rNGCryptoServiceProvider;
}
