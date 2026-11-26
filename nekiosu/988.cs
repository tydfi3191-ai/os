using System;
using System.Collections.Generic;
using System.IO;

// Token: 0x0200034F RID: 847
public sealed class 988 : Stream
{
	// Token: 0x17000136 RID: 310
	// (get) Token: 0x06001A44 RID: 6724 RVA: 0x0006297A File Offset: 0x00060B7A
	public override bool CanRead
	{
		get
		{
			return this.innerStream.CanRead;
		}
	}

	// Token: 0x17000137 RID: 311
	// (get) Token: 0x06001A45 RID: 6725 RVA: 0x00062987 File Offset: 0x00060B87
	public override bool CanSeek
	{
		get
		{
			return this.innerStream.CanSeek;
		}
	}

	// Token: 0x17000138 RID: 312
	// (get) Token: 0x06001A46 RID: 6726 RVA: 0x00062994 File Offset: 0x00060B94
	public override bool CanWrite
	{
		get
		{
			return this.innerStream.CanWrite;
		}
	}

	// Token: 0x17000139 RID: 313
	// (get) Token: 0x06001A47 RID: 6727 RVA: 0x000629A1 File Offset: 0x00060BA1
	public override long Length
	{
		get
		{
			return this.innerStream.Length;
		}
	}

	// Token: 0x1700013A RID: 314
	// (get) Token: 0x06001A48 RID: 6728 RVA: 0x00053ADC File Offset: 0x00051CDC
	// (set) Token: 0x06001A49 RID: 6729 RVA: 0x00053ADC File Offset: 0x00051CDC
	public override long Position
	{
		get
		{
			throw new NotImplementedException();
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	// Token: 0x06001A4A RID: 6730 RVA: 0x000629B0 File Offset: 0x00060BB0
	public 988(Stream 1, 777 2, 724 3, 438 4, bool 5)
	{
		this.innerStream = 1;
		this.leaveOpen = 5;
		this.compressionMode = 2;
		this.flavor = 4;
		this.compressionLevel = 3;
		if (4 == (438)1952)
		{
			this.crc32 = new 369();
		}
	}

	// Token: 0x06001A4B RID: 6731 RVA: 0x00062A1C File Offset: 0x00060C1C
	private int ReadAndValidateGzipHeader()
	{
		int num = 0;
		byte[] array = new byte[10];
		int num2 = this.innerStream.Read(array, 0, array.Length);
		if (num2 == 0)
		{
			return 0;
		}
		if (num2 != 10)
		{
			throw new 522("Not a valid GZIP stream.");
		}
		if (array[0] != 31 || array[1] != 139 || array[2] != 8)
		{
			throw new 522("Bad GZIP header.");
		}
		int num3 = BitConverter.ToInt32(array, 4);
		this.dateTime = 481.dateTime.AddSeconds((double)num3);
		num += num2;
		if ((array[3] & 4) == 4)
		{
			num2 = this.innerStream.Read(array, 0, 2);
			num += num2;
			short num4 = (short)((int)array[0] + (int)array[1] * 256);
			byte[] array2 = new byte[(int)num4];
			num2 = this.innerStream.Read(array2, 0, array2.Length);
			if (num2 != (int)num4)
			{
				throw new 522("Unexpected end-of-file reading GZIP header.");
			}
			num += num2;
		}
		if ((array[3] & 8) == 8)
		{
			this.gzipFileName = this.ReadZeroTerminatedString();
		}
		if ((array[3] & 16) == 16)
		{
			this.text = this.ReadZeroTerminatedString();
		}
		if ((array[3] & 2) == 2)
		{
			this.Read(this.singleByteBuffer, 0, 1);
		}
		return num;
	}

	// Token: 0x06001A4C RID: 6732 RVA: 0x00062B38 File Offset: 0x00060D38
	public override void Close()
	{
		if (this.innerStream == null)
		{
			return;
		}
		try
		{
			this.FinishStream();
		}
		finally
		{
			this.EndCodec();
			if (!this.leaveOpen)
			{
				this.innerStream.Close();
			}
			this.innerStream = null;
		}
	}

	// Token: 0x06001A4D RID: 6733 RVA: 0x00062B88 File Offset: 0x00060D88
	private void EndCodec()
	{
		if (this.EnsureZlibCodec() != null)
		{
			if (this.IsCompressing())
			{
				this.zlibCodec.Method7083();
			}
			else
			{
				this.zlibCodec.Method7084();
			}
			this.zlibCodec = null;
		}
	}

	// Token: 0x06001A4E RID: 6734 RVA: 0x00062BBC File Offset: 0x00060DBC
	private void FinishStream()
	{
		if (this.zlibCodec == null)
		{
			return;
		}
		if (this.streamMode == (988.989)0)
		{
			for (;;)
			{
				this.zlibCodec.byteArray3 = this.GetWorkingBuffer();
				this.zlibCodec.number7 = 0;
				this.zlibCodec.number5 = this.workingBuffer.Length;
				int num = this.IsCompressing() ? this.zlibCodec.Method7082((528)4) : this.zlibCodec.Method7086((528)4);
				if (num != 1 && num != 0)
				{
					break;
				}
				if (this.workingBuffer.Length - this.zlibCodec.number5 > 0)
				{
					this.innerStream.Write(this.workingBuffer, 0, this.workingBuffer.Length - this.zlibCodec.number5);
				}
				bool flag = this.zlibCodec.number4 == 0 && this.zlibCodec.number5 != 0;
				if (this.flavor == (438)1952 && !this.IsCompressing())
				{
					flag = (this.zlibCodec.number4 == 8 && this.zlibCodec.number5 != 0);
				}
				if (flag)
				{
					goto Block_11;
				}
			}
			throw new 522((this.IsCompressing() ? "de" : "in") + "flating: " + this.zlibCodec.text);
			Block_11:
			this.Flush();
			if (this.flavor == (438)1952)
			{
				if (!this.IsCompressing())
				{
					throw new 522("Writing with decompression is not supported.");
				}
				int value = this.crc32.Method1890();
				this.innerStream.Write(BitConverter.GetBytes(value), 0, 4);
				int value2 = (int)(this.crc32.GetNumber1278_1891() & (long)((ulong)-1));
				this.innerStream.Write(BitConverter.GetBytes(value2), 0, 4);
				return;
			}
		}
		else
		{
			if (this.streamMode != (988.989)1 || this.flavor != (438)1952)
			{
				return;
			}
			if (this.IsCompressing())
			{
				throw new 522("Reading with compression is not supported.");
			}
			if (this.zlibCodec.number9 != 0L)
			{
				byte[] array = new byte[8];
				if (this.zlibCodec.number4 != 8)
				{
					throw new 522(string.Format("Protocol error. AvailableBytesIn={0}, expected 8", this.zlibCodec.number4));
				}
				Array.Copy(this.zlibCodec.byteArray2, this.zlibCodec.number6, array, 0, array.Length);
				int num2 = BitConverter.ToInt32(array, 0);
				int num3 = this.crc32.Method1890();
				int num4 = BitConverter.ToInt32(array, 4);
				int num5 = (int)(this.zlibCodec.number9 & (long)((ulong)-1));
				if (num3 != num2)
				{
					throw new 522(string.Format("Bad CRC32 in GZIP stream. (actual({0:X8})!=expected({1:X8}))", num3, num2));
				}
				if (num5 != num4)
				{
					throw new 522(string.Format("Bad size in GZIP stream. (actual({0})!=expected({1}))", num5, num4));
				}
			}
		}
	}

	// Token: 0x06001A4F RID: 6735 RVA: 0x00062E77 File Offset: 0x00061077
	public override void Flush()
	{
		this.innerStream.Flush();
	}

	// Token: 0x06001A50 RID: 6736 RVA: 0x00062E84 File Offset: 0x00061084
	public override int Read(byte[] 1, int 2, int 3)
	{
		if (this.streamMode == (988.989)2)
		{
			if (!this.innerStream.CanRead)
			{
				throw new 522("The stream is not readable.");
			}
			this.streamMode = (988.989)1;
			this.EnsureZlibCodec().number4 = 0;
			if (this.flavor == (438)1952)
			{
				this.gzipHeaderByteCount = this.ReadAndValidateGzipHeader();
				if (this.gzipHeaderByteCount == 0)
				{
					return 0;
				}
			}
		}
		if (this.streamMode != (988.989)1)
		{
			throw new 522("Cannot Read after Writing.");
		}
		if (3 == 0)
		{
			return 0;
		}
		if (this.noMoreInput && this.IsCompressing())
		{
			return 0;
		}
		if (1 == null)
		{
			throw new ArgumentNullException("#=zpMJwVYM=");
		}
		if (3 < 0)
		{
			throw new ArgumentOutOfRangeException("#=zW32YDQ0=");
		}
		if (2 < 1.GetLowerBound(0))
		{
			throw new ArgumentOutOfRangeException("#=zJ_sgkP4=");
		}
		if (2 + 3 > 1.GetLength(0))
		{
			throw new ArgumentOutOfRangeException("#=zW32YDQ0=");
		}
		this.zlibCodec.byteArray3 = 1;
		this.zlibCodec.number7 = 2;
		this.zlibCodec.number5 = 3;
		this.zlibCodec.byteArray2 = this.GetWorkingBuffer();
		int num;
		for (;;)
		{
			if (this.zlibCodec.number4 == 0 && !this.noMoreInput)
			{
				this.zlibCodec.number6 = 0;
				this.zlibCodec.number4 = this.innerStream.Read(this.workingBuffer, 0, this.workingBuffer.Length);
				if (this.zlibCodec.number4 == 0)
				{
					this.noMoreInput = true;
				}
			}
			num = (this.IsCompressing() ? this.zlibCodec.Method7082(this.flushMode) : this.zlibCodec.Method7086(this.flushMode));
			if (this.noMoreInput && num == -5)
			{
				break;
			}
			if (num != 0 && num != 1)
			{
				goto Block_20;
			}
			if (((this.noMoreInput || num == 1) && this.zlibCodec.number5 == 3) || this.zlibCodec.number5 <= 0 || this.noMoreInput || num != 0)
			{
				goto IL_20A;
			}
		}
		return 0;
		Block_20:
		throw new 522(string.Format("{0}flating:  rc={1}  msg={2}", this.IsCompressing() ? "de" : "in", num, this.zlibCodec.text));
		IL_20A:
		if (this.zlibCodec.number5 > 0)
		{
			if (num == 0)
			{
				int number = this.zlibCodec.number4;
			}
			if (this.noMoreInput && this.IsCompressing())
			{
				num = this.zlibCodec.Method7082((528)4);
				if (num != 0 && num != 1)
				{
					throw new 522(string.Format("Deflating:  rc={0}  msg={1}", num, this.zlibCodec.text));
				}
			}
		}
		num = 3 - this.zlibCodec.number5;
		if (this.crc32 != null)
		{
			this.crc32.Method1889(1, 2, num);
		}
		return num;
	}

	// Token: 0x06001A51 RID: 6737 RVA: 0x00063124 File Offset: 0x00061324
	private string ReadZeroTerminatedString()
	{
		List<byte> list = new List<byte>();
		bool flag = false;
		while (this.innerStream.Read(this.singleByteBuffer, 0, 1) == 1)
		{
			if (this.singleByteBuffer[0] == 0)
			{
				flag = true;
			}
			else
			{
				list.Add(this.singleByteBuffer[0]);
			}
			if (flag)
			{
				byte[] array = list.ToArray();
				return 481.encoding.GetString(array, 0, array.Length);
			}
		}
		throw new 522("Unexpected EOF reading GZIP header.");
	}

	// Token: 0x06001A52 RID: 6738 RVA: 0x00053ADC File Offset: 0x00051CDC
	public override long Seek(long 1, SeekOrigin 2)
	{
		throw new NotImplementedException();
	}

	// Token: 0x06001A53 RID: 6739 RVA: 0x0006318F File Offset: 0x0006138F
	public override void SetLength(long 1)
	{
		this.innerStream.SetLength(1);
	}

	// Token: 0x06001A54 RID: 6740 RVA: 0x000631A0 File Offset: 0x000613A0
	public override void Write(byte[] 1, int 2, int 3)
	{
		if (this.crc32 != null)
		{
			this.crc32.Method1889(1, 2, 3);
		}
		if (this.streamMode == (988.989)2)
		{
			this.streamMode = (988.989)0;
		}
		else if (this.streamMode != (988.989)0)
		{
			throw new 522("Cannot Write after Reading.");
		}
		if (3 == 0)
		{
			return;
		}
		this.EnsureZlibCodec().byteArray2 = 1;
		this.zlibCodec.number6 = 2;
		this.zlibCodec.number4 = 3;
		for (;;)
		{
			this.zlibCodec.byteArray3 = this.GetWorkingBuffer();
			this.zlibCodec.number7 = 0;
			this.zlibCodec.number5 = this.workingBuffer.Length;
			int num = this.IsCompressing() ? this.zlibCodec.Method7082(this.flushMode) : this.zlibCodec.Method7086(this.flushMode);
			if (num != 0 && num != 1)
			{
				break;
			}
			this.innerStream.Write(this.workingBuffer, 0, this.workingBuffer.Length - this.zlibCodec.number5);
			bool flag = this.zlibCodec.number4 == 0 && this.zlibCodec.number5 != 0;
			if (this.flavor == (438)1952 && !this.IsCompressing())
			{
				flag = (this.zlibCodec.number4 == 8 && this.zlibCodec.number5 != 0);
			}
			if (flag)
			{
				return;
			}
		}
		throw new 522((this.IsCompressing() ? "de" : "in") + "flating: " + this.zlibCodec.text);
	}

	// Token: 0x06001A55 RID: 6741 RVA: 0x00063325 File Offset: 0x00061525
	protected internal bool IsCompressing()
	{
		return this.compressionMode == (777)0;
	}

	// Token: 0x06001A56 RID: 6742 RVA: 0x00063330 File Offset: 0x00061530
	internal int GetCrc32()
	{
		if (this.crc32 == null)
		{
			return 0;
		}
		return this.crc32.Method1890();
	}

	// Token: 0x06001A57 RID: 6743 RVA: 0x00063347 File Offset: 0x00061547
	private byte[] GetWorkingBuffer()
	{
		if (this.workingBuffer == null)
		{
			this.workingBuffer = new byte[this.bufferSize];
		}
		return this.workingBuffer;
	}

	// Token: 0x06001A58 RID: 6744 RVA: 0x00063368 File Offset: 0x00061568
	private 552 EnsureZlibCodec()
	{
		if (this.zlibCodec == null)
		{
			bool flag = this.flavor == (438)1950;
			this.zlibCodec = new 552();
			if (this.compressionMode == (777)1)
			{
				this.zlibCodec.Method7092(flag);
			}
			else
			{
				this.zlibCodec._recoveredType05485618 = this._recoveredType05489037;
				this.zlibCodec.Method7087(this.compressionLevel, flag);
			}
		}
		return this.zlibCodec;
	}

	// Token: 0x04000C80 RID: 3200
	protected internal byte[] singleByteBuffer = new byte[1];

	// Token: 0x04000C81 RID: 3201
	protected internal int bufferSize = 8192;

	// Token: 0x04000C82 RID: 3202
	protected internal 777 compressionMode;

	// Token: 0x04000C83 RID: 3203
	protected internal 438 flavor;

	// Token: 0x04000C84 RID: 3204
	protected internal 528 flushMode;

	// Token: 0x04000C85 RID: 3205
	protected internal string text;

	// Token: 0x04000C86 RID: 3206
	protected internal string gzipFileName;

	// Token: 0x04000C87 RID: 3207
	protected internal int gzipHeaderByteCount;

	// Token: 0x04000C88 RID: 3208
	protected internal DateTime dateTime;

	// Token: 0x04000C89 RID: 3209
	protected internal bool leaveOpen;

	// Token: 0x04000C8A RID: 3210
	protected internal 724 compressionLevel;

	// Token: 0x04000C8B RID: 3211
	protected internal Stream innerStream;

	// Token: 0x04000C8C RID: 3212
	protected internal 988.989 streamMode = (988.989)2;

	// Token: 0x04000C8D RID: 3213
	protected internal byte[] workingBuffer;

	// Token: 0x04000C8E RID: 3214
	protected internal 552 zlibCodec;

	// Token: 0x04000C8F RID: 3215
	private 369 crc32;

	// Token: 0x04000C90 RID: 3216
	private bool noMoreInput;

	// Token: 0x04000C91 RID: 3217
	protected internal 417 _recoveredType05489037;

	// Token: 0x02000350 RID: 848
	public enum 989
	{

	}
}
