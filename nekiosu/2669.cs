using System;
using System.IO;
using System.Runtime.InteropServices;

// Token: 0x02000430 RID: 1072
[ComVisible(false)]
public sealed class 2669 : Stream
{
	// Token: 0x17000230 RID: 560
	// (get) Token: 0x0600215C RID: 8540 RVA: 0x0008FE81 File Offset: 0x0008E081
	public override bool CanRead
	{
		get
		{
			return this.2().CanRead;
		}
	}

	// Token: 0x17000231 RID: 561
	// (get) Token: 0x0600215D RID: 8541 RVA: 0x0008FE8E File Offset: 0x0008E08E
	public override bool CanSeek
	{
		get
		{
			return this.2().CanSeek;
		}
	}

	// Token: 0x17000232 RID: 562
	// (get) Token: 0x0600215E RID: 8542 RVA: 0x0008FE9B File Offset: 0x0008E09B
	public override bool CanWrite
	{
		get
		{
			return this.2().CanWrite;
		}
	}

	// Token: 0x17000233 RID: 563
	// (get) Token: 0x0600215F RID: 8543 RVA: 0x0008FEA8 File Offset: 0x0008E0A8
	public override long Length
	{
		get
		{
			return this.2().Length;
		}
	}

	// Token: 0x17000234 RID: 564
	// (get) Token: 0x06002160 RID: 8544 RVA: 0x0008FEB5 File Offset: 0x0008E0B5
	// (set) Token: 0x06002161 RID: 8545 RVA: 0x0008FEC2 File Offset: 0x0008E0C2
	public override long Position
	{
		get
		{
			return this.2().Position;
		}
		set
		{
			this.2().Position = value;
		}
	}

	// Token: 0x06002162 RID: 8546 RVA: 0x0008FED0 File Offset: 0x0008E0D0
	public 2669(Stream 1, 594 2, uint[] 3)
	{
		this.3(1);
		this.4.1(3, 2);
	}

	// Token: 0x06002163 RID: 8547 RVA: 0x0008FEF8 File Offset: 0x0008E0F8
	public unsafe 2669(Stream 1, 594 2, byte[] 3)
	{
		uint[] array = new uint[4];
		fixed (byte[] array2 = 3)
		{
			byte* ptr;
			if (3 == null || array2.Length == 0)
			{
				ptr = null;
			}
			else
			{
				ptr = &array2[0];
			}
			uint[] array3;
			uint* ptr2;
			if ((array3 = array) == null || array3.Length == 0)
			{
				ptr2 = null;
			}
			else
			{
				ptr2 = &array3[0];
			}
			uint* ptr3 = (uint*)ptr;
			*ptr2 = *ptr3;
			ptr2[1] = ptr3[1];
			ptr2[2] = ptr3[2];
			ptr2[3] = ptr3[3];
			array3 = null;
		}
		this.3(1);
		this.4.1(array, 2);
	}

	// Token: 0x06002164 RID: 8548 RVA: 0x0008FF98 File Offset: 0x0008E198
	private static void 1(bool 1)
	{
		2669.1 = 1;
	}

	// Token: 0x06002165 RID: 8549 RVA: 0x0008FFA0 File Offset: 0x0008E1A0
	public Stream 2()
	{
		return this.2;
	}

	// Token: 0x06002166 RID: 8550 RVA: 0x0008FFA8 File Offset: 0x0008E1A8
	private void 3(Stream 1)
	{
		this.2 = 1;
	}

	// Token: 0x06002167 RID: 8551 RVA: 0x0008FFB1 File Offset: 0x0008E1B1
	public bool 4()
	{
		return this.3;
	}

	// Token: 0x06002168 RID: 8552 RVA: 0x0008FFB9 File Offset: 0x0008E1B9
	private void 5(bool 1)
	{
		this.3 = 1;
	}

	// Token: 0x06002169 RID: 8553 RVA: 0x0008FFC4 File Offset: 0x0008E1C4
	~2669()
	{
		this.Close();
	}

	// Token: 0x0600216A RID: 8554 RVA: 0x0008FFF0 File Offset: 0x0008E1F0
	public override void Flush()
	{
		this.2().Flush();
	}

	// Token: 0x0600216B RID: 8555 RVA: 0x0008FFFD File Offset: 0x0008E1FD
	public override long Seek(long 1, SeekOrigin 2)
	{
		return this.2().Seek(1, 2);
	}

	// Token: 0x0600216C RID: 8556 RVA: 0x0009000C File Offset: 0x0008E20C
	public override void SetLength(long 1)
	{
		this.2().SetLength(1);
	}

	// Token: 0x0600216D RID: 8557 RVA: 0x0009001A File Offset: 0x0008E21A
	public override int Read(byte[] 1, int 2, int 3)
	{
		int result = this.2().Read(1, 2, 3);
		this.4.9(1, 2, 3);
		return result;
	}

	// Token: 0x0600216E RID: 8558 RVA: 0x00090038 File Offset: 0x0008E238
	public override void Write(byte[] 1, int 2, int 3)
	{
		byte[] array = new byte[1.Length];
		1.CopyTo(array, 0);
		this.4.10(array, 2, 3);
		this.2().Write(array, 2, 3);
	}

	// Token: 0x0600216F RID: 8559 RVA: 0x00090072 File Offset: 0x0008E272
	public override void Close()
	{
		if (!this.4())
		{
			2669.1(false);
			this.5(true);
		}
	}

	// Token: 0x0400120F RID: 4623
	private static bool 1;

	// Token: 0x04001210 RID: 4624
	private Stream 2;

	// Token: 0x04001211 RID: 4625
	private bool 3;

	// Token: 0x04001212 RID: 4626
	private 2680 4 = new 2680();
}
