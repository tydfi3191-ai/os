using System;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;

// Token: 0x02000333 RID: 819
[ComVisible(false)]
public sealed class 987 : 628
{
	// Token: 0x0600193B RID: 6459 RVA: 0x0005A6E4 File Offset: 0x000588E4
	public 987(Stream 1) : base(1, new 51(-1, true))
	{
	}

	// Token: 0x0600193C RID: 6460 RVA: 0x0005A748 File Offset: 0x00058948
	public 987(Stream 1, int 2) : base(1, new 51(-1, true), 2)
	{
	}

	// Token: 0x0600193D RID: 6461 RVA: 0x0005A7AB File Offset: 0x000589AB
	public bool _0008_200A_2003_200A_2000_2007_2006_2008_2008_2007_200B_2002_2006_2007_2008_2005_2003_200A_200A()
	{
		return this.arrayList == null;
	}

	// Token: 0x0600193E RID: 6462 RVA: 0x0005A7B8 File Offset: 0x000589B8
	public void _0006_2003_2008_2006_2007_2001_2002_2000_2001_2005_2006_2009_2000_2005_2009_2001_2006_2005_2000_2009_2008_2000_2002_2003_200B_2006_2007_2001(string 1)
	{
		byte[] array = 448.Method4014(1);
		if (array.Length > 65535)
		{
			throw new ArgumentOutOfRangeException("#=z7tdLgog=");
		}
		this.commentBytes = array;
	}

	// Token: 0x0600193F RID: 6463 RVA: 0x0005A7E8 File Offset: 0x000589E8
	public void _000F_2003_2007_2009_2002_2004_2008_2008_2007_2006_2009_200B_200B_2007_2004_2005_2004_2008(int 1)
	{
		this.deflater2.SetLevel(1);
		this.defaultCompressionLevel = 1;
	}

	// Token: 0x06001940 RID: 6464 RVA: 0x0005A7FD File Offset: 0x000589FD
	public int _0002_2006_2009_200A_2001_2007_2009_2002_2008_2000_2008_2005_2009_2007_2000_2008_2009_2006_200B_2009_2003_2008_2006_2009_200B_200B_2004_2009_2005()
	{
		return this.deflater2.GetLevel();
	}

	// Token: 0x06001941 RID: 6465 RVA: 0x0005A80A File Offset: 0x00058A0A
	public 609 _000E_200B_2001_2003_2009_2005_2003_2000_200A_2008_2006_2000_2004_200B_2001_2002_2007_2003_2004_200A_200B_2003_2002_2009_2001()
	{
		return this.useZip64;
	}

	// Token: 0x06001942 RID: 6466 RVA: 0x0005A812 File Offset: 0x00058A12
	public void _0002_2003_2006_2000_200B_200B_2000_2006_200B_2000_2006(609 1)
	{
		this.useZip64 = 1;
	}

	// Token: 0x06001943 RID: 6467 RVA: 0x0005A81B File Offset: 0x00058A1B
	private void WriteLeShort(int 1)
	{
		this.stream2.WriteByte((byte)1);
		this.stream2.WriteByte((byte)(1 >> 8));
	}

	// Token: 0x06001944 RID: 6468 RVA: 0x0005A839 File Offset: 0x00058A39
	private void WriteLeInt(int 1)
	{
		this.WriteLeShort(1);
		this.WriteLeShort(1 >> 16);
	}

	// Token: 0x06001945 RID: 6469 RVA: 0x0005A84C File Offset: 0x00058A4C
	private void WriteLeLong(long 1)
	{
		this.WriteLeInt((int)1);
		this.WriteLeInt((int)(1 >> 32));
	}

	// Token: 0x06001946 RID: 6470 RVA: 0x0005A864 File Offset: 0x00058A64
	public void _0003_2001_2009_2004_2006_2007_2000_2005_2008_2005_2001_2007_2002_2000_2005_2006_2008_2005_2004_2002_2004_2001_2005_2007_2007(783 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("entry");
		}
		if (this.arrayList == null)
		{
			throw new InvalidOperationException("ZipOutputStream was finished");
		}
		if (this.curEntry != null)
		{
			this._0005_2003_2008_2007_2005_2003_200B_2008_2009_2004_200A_2008_200B_2001_2007_2003_2009_2005_200A_2008();
		}
		if (this.arrayList.Count == 2147483647)
		{
			throw new 415("Too many entries for Zip file");
		}
		536 2 = 1.GetRecoveredType118710002_12809();
		int level = this.defaultCompressionLevel;
		1.SetNumber10005_12780(1.GetNumber10005_12779() & 2048);
		this.patchEntryHeader = false;
		bool flag;
		if (1.Method12803() == 0L)
		{
			1.Method12806(1.Method12803());
			1.Method12808(0L);
			2 = 536.Stored;
			flag = true;
		}
		else
		{
			flag = (1.Method12803() >= 0L && 1.Method12772() && 1.Method12805() >= 0L);
			if (2 == 536.Stored)
			{
				if (!flag)
				{
					if (!base._0002_2005_2009_200A_200A_2007_2005_2005_2009_2006_200B_2004_2008_2009_200A_2002_2006())
					{
						2 = 536.Deflated;
						level = 0;
					}
				}
				else
				{
					1.Method12806(1.Method12803());
					flag = 1.Method12772();
				}
			}
		}
		if (!flag)
		{
			if (!base._0002_2005_2009_200A_200A_2007_2005_2005_2009_2006_200B_2004_2008_2009_200A_2002_2006())
			{
				1.SetNumber10005_12780(1.GetNumber10005_12779() | 8);
			}
			else
			{
				this.patchEntryHeader = true;
			}
		}
		if (base._0006_2000_2006_2003_2001_200B_2008_2001_2004_2006_2008_2006_2008_2001_2006_2004_200A_2004_2005_2007_2003_2009_2005() != null)
		{
			1.Method12774(true);
			if (1.Method12807() < 0L)
			{
				1.SetNumber10005_12780(1.GetNumber10005_12779() | 8);
			}
		}
		1.SetNumber10007_12784(this.offset);
		1.Method12810(2);
		this.curMethod = 2;
		this.sizePatchPos = -1L;
		if (this.useZip64 == (609)1 || (1.Method12803() < 0L && this.useZip64 == (609)2))
		{
			1.SetFlag10008_12794();
		}
		this.WriteLeInt(67324752);
		this.WriteLeShort(1.Method12792());
		this.WriteLeShort(1.GetNumber10005_12779());
		this.WriteLeShort((int)((byte)1.Method12811()));
		this.WriteLeInt((int)1.Method12798());
		if (flag)
		{
			this.WriteLeInt((int)1.Method12807());
			if (1.Method12796())
			{
				this.WriteLeInt(-1);
				this.WriteLeInt(-1);
			}
			else
			{
				this.WriteLeInt((int)(1.Method12773() ? ((long)((int)1.Method12805() + 12)) : 1.Method12805()));
				this.WriteLeInt((int)1.Method12803());
			}
		}
		else
		{
			if (this.patchEntryHeader)
			{
				this.crcPatchPos = this.stream2.Position;
			}
			this.WriteLeInt(0);
			if (this.patchEntryHeader)
			{
				this.sizePatchPos = this.stream2.Position;
			}
			if (1.Method12796() || this.patchEntryHeader)
			{
				this.WriteLeInt(-1);
				this.WriteLeInt(-1);
			}
			else
			{
				this.WriteLeInt(0);
				this.WriteLeInt(0);
			}
		}
		byte[] array = 448.Method4014(1.GetNumber10005_12779(), 1.GetText9996_12802());
		if (array.Length > 65535)
		{
			throw new 415("Entry name too long.");
		}
		758 3 = new 758(1.GetByteArray10003_12812());
		if (1.Method12796())
		{
			3.SetMemoryStream9560_12229();
			if (flag)
			{
				3.Method12235(1.Method12803());
				3.Method12235(1.Method12805());
			}
			else
			{
				3.Method12235(-1L);
				3.Method12235(-1L);
			}
			3.Method12230(1);
			if (!3.Method12226(1))
			{
				throw new 415("Internal error cant find extra data");
			}
			if (this.patchEntryHeader)
			{
				this.sizePatchPos = (long)3.GetNumber9557_12224();
			}
		}
		else
		{
			3.Method12236(1);
		}
		if (1.Method12814() > 0)
		{
			987.AddExtraDataAES(1, 3);
		}
		byte[] array2 = 3.Method12217();
		this.WriteLeShort(array.Length);
		this.WriteLeShort(array2.Length);
		if (array.Length != 0)
		{
			this.stream2.Write(array, 0, array.Length);
		}
		if (1.Method12796() && this.patchEntryHeader)
		{
			this.sizePatchPos += this.stream2.Position;
		}
		if (array2.Length != 0)
		{
			this.stream2.Write(array2, 0, array2.Length);
		}
		this.offset += (long)(30 + array.Length + array2.Length);
		if (1.Method12814() > 0)
		{
			this.offset += (long)1.Method12818();
		}
		this.curEntry = 1;
		this.crc.SetNumber7041_9090();
		if (2 == 536.Deflated)
		{
			this.deflater2.Reset();
			this.deflater2.SetLevel(level);
		}
		this.entrySize = 0L;
		if (1.Method12773())
		{
			if (1.Method12814() > 0)
			{
				this.WriteAesHeader(1);
				return;
			}
			if (1.Method12807() < 0L)
			{
				this.WriteEncryptionHeader(1.Method12798() << 16);
				return;
			}
			this.WriteEncryptionHeader(1.Method12807());
		}
	}

	// Token: 0x06001947 RID: 6471 RVA: 0x0005ACBC File Offset: 0x00058EBC
	public void _0005_2003_2008_2007_2005_2003_200B_2008_2009_2004_200A_2008_200B_2001_2007_2003_2009_2005_200A_2008()
	{
		if (this.curEntry == null)
		{
			throw new InvalidOperationException("No open entry");
		}
		long totalOut = this.entrySize;
		if (this.curMethod == 536.Deflated)
		{
			if (this.entrySize >= 0L)
			{
				base._0006_2003_2009_2001_2002_200A_2006_2008_200B_2000_2004_2009_2009_2004_200A_2005_2007_2003_2005_2003_200B_2003_2002();
				totalOut = this.deflater2.GetTotalOut();
			}
			else
			{
				this.deflater2.Reset();
			}
		}
		if (this.curEntry.Method12814() > 0)
		{
			this.stream2.Write(this.byteArray4, 0, 10);
		}
		if (this.curEntry.Method12803() < 0L)
		{
			this.curEntry.Method12804(this.entrySize);
		}
		else if (this.curEntry.Method12803() != this.entrySize)
		{
			throw new 415("size was " + this.entrySize.ToString() + ", but I expected " + this.curEntry.Method12803().ToString());
		}
		if (this.curEntry.Method12805() < 0L)
		{
			this.curEntry.Method12806(totalOut);
		}
		else if (this.curEntry.Method12805() != totalOut)
		{
			throw new 415("compressed size was " + totalOut.ToString() + ", but I expected " + this.curEntry.Method12805().ToString());
		}
		if (this.curEntry.Method12807() < 0L)
		{
			this.curEntry.Method12808(this.crc.GetNumber7041_9089());
		}
		else if (this.curEntry.Method12807() != this.crc.GetNumber7041_9089())
		{
			throw new 415("crc was " + this.crc.GetNumber7041_9089().ToString() + ", but I expected " + this.curEntry.Method12807().ToString());
		}
		this.offset += totalOut;
		if (this.curEntry.Method12773())
		{
			if (this.curEntry.Method12814() > 0)
			{
				783 <<EMPTY_NAME>> = this.curEntry;
				<<EMPTY_NAME>>.Method12806(<<EMPTY_NAME>>.Method12805() + (long)this.curEntry.Method12818());
			}
			else
			{
				783 2 = this.curEntry;
				2.Method12806(2.Method12805() + 12L);
			}
		}
		if (this.patchEntryHeader)
		{
			this.patchEntryHeader = false;
			long position = this.stream2.Position;
			this.stream2.Seek(this.crcPatchPos, SeekOrigin.Begin);
			this.WriteLeInt((int)this.curEntry.Method12807());
			if (this.curEntry.Method12796())
			{
				if (this.sizePatchPos == -1L)
				{
					throw new 415("Entry requires zip64 but this has been turned off");
				}
				this.stream2.Seek(this.sizePatchPos, SeekOrigin.Begin);
				this.WriteLeLong(this.curEntry.Method12803());
				this.WriteLeLong(this.curEntry.Method12805());
			}
			else
			{
				this.WriteLeInt((int)this.curEntry.Method12805());
				this.WriteLeInt((int)this.curEntry.Method12803());
			}
			this.stream2.Seek(position, SeekOrigin.Begin);
		}
		if ((this.curEntry.GetNumber10005_12779() & 8) != 0)
		{
			this.WriteLeInt(134695760);
			this.WriteLeInt((int)this.curEntry.Method12807());
			if (this.curEntry.Method12796())
			{
				this.WriteLeLong(this.curEntry.Method12805());
				this.WriteLeLong(this.curEntry.Method12803());
				this.offset += 24L;
			}
			else
			{
				this.WriteLeInt((int)this.curEntry.Method12805());
				this.WriteLeInt((int)this.curEntry.Method12803());
				this.offset += 16L;
			}
		}
		this.arrayList.Add(this.curEntry);
		this.curEntry = null;
	}

	// Token: 0x06001948 RID: 6472 RVA: 0x0005B05C File Offset: 0x0005925C
	private void WriteEncryptionHeader(long 1)
	{
		this.offset += 12L;
		base.Method9085(base._0006_2000_2006_2003_2001_200B_2008_2001_2004_2006_2008_2006_2008_2001_2006_2004_200A_2004_2005_2007_2003_2009_2005());
		byte[] array = new byte[12];
		new Random().NextBytes(array);
		array[11] = (byte)(1 >> 24);
		base.Method9084(array, 0, array.Length);
		this.stream2.Write(array, 0, array.Length);
	}

	// Token: 0x06001949 RID: 6473 RVA: 0x0005B0BC File Offset: 0x000592BC
	private static void AddExtraDataAES(783 1, 758 2)
	{
		2.SetMemoryStream9560_12229();
		2.Method12233(2);
		2.Method12233(17729);
		2.Method12231(1.Method12816());
		2.Method12233((int)1.GetRecoveredType118710002_12809());
		2.Method12230(39169);
	}

	// Token: 0x0600194A RID: 6474 RVA: 0x0005B0FC File Offset: 0x000592FC
	private void WriteAesHeader(783 1)
	{
		byte[] array;
		byte[] array2;
		base.Method9086(1, base._0006_2000_2006_2003_2001_200B_2008_2001_2004_2006_2008_2006_2008_2001_2006_2004_200A_2004_2005_2007_2003_2009_2005(), out array, out array2);
		this.stream2.Write(array, 0, array.Length);
		this.stream2.Write(array2, 0, array2.Length);
	}

	// Token: 0x0600194B RID: 6475 RVA: 0x0005B13C File Offset: 0x0005933C
	public override void Write(byte[] 1, int 2, int 3)
	{
		if (this.curEntry == null)
		{
			throw new InvalidOperationException("No open entry.");
		}
		if (1 == null)
		{
			throw new ArgumentNullException("#=zpMJwVYM=");
		}
		if (2 < 0)
		{
			throw new ArgumentOutOfRangeException("#=zJ_sgkP4=", "Cannot be negative");
		}
		if (3 < 0)
		{
			throw new ArgumentOutOfRangeException("#=zW32YDQ0=", "Cannot be negative");
		}
		if (1.Length - 2 < 3)
		{
			throw new ArgumentException("Invalid offset/count combination");
		}
		this.crc.Method90912(1, 2, 3);
		this.entrySize += (long)3;
		536 4 = this.curMethod;
		if (4 != 536.Stored)
		{
			if (4 == 536.Deflated)
			{
				base.Write(1, 2, 3);
				return;
			}
		}
		else
		{
			if (base._0006_2000_2006_2003_2001_200B_2008_2001_2004_2006_2008_2006_2008_2001_2006_2004_200A_2004_2005_2007_2003_2009_2005() != null)
			{
				this.WriteEncryptedData(1, 2, 3);
				return;
			}
			this.stream2.Write(1, 2, 3);
		}
	}

	// Token: 0x0600194C RID: 6476 RVA: 0x0005B1FC File Offset: 0x000593FC
	private void WriteEncryptedData(byte[] 1, int 2, int 3)
	{
		byte[] array = new byte[4096];
		while (3 > 0)
		{
			int num = (3 < 4096) ? 3 : 4096;
			Array.Copy(1, 2, array, 0, num);
			base.Method9084(array, 0, num);
			this.stream2.Write(array, 0, num);
			3 -= num;
			2 += num;
		}
	}

	// Token: 0x0600194D RID: 6477 RVA: 0x0005B258 File Offset: 0x00059458
	public override void _0006_2003_2009_2001_2002_200A_2006_2008_200B_2000_2004_2009_2009_2004_200A_2005_2007_2003_2005_2003_200B_2003_2002()
	{
		if (this.arrayList == null)
		{
			return;
		}
		if (this.curEntry != null)
		{
			this._0005_2003_2008_2007_2005_2003_200B_2008_2009_2004_200A_2008_200B_2001_2007_2003_2009_2005_200A_2008();
		}
		long <<EMPTY_NAME>> = (long)this.arrayList.Count;
		long num = 0L;
		foreach (object obj in this.arrayList)
		{
			783 2 = (783)obj;
			this.WriteLeInt(33639248);
			this.WriteLeShort(51);
			this.WriteLeShort(2.Method12792());
			this.WriteLeShort(2.GetNumber10005_12779());
			this.WriteLeShort((int)((short)2.Method12811()));
			this.WriteLeInt((int)2.Method12798());
			this.WriteLeInt((int)2.Method12807());
			if (2.GetFlag10008_12795() || 2.Method12805() >= (long)((ulong)-1))
			{
				this.WriteLeInt(-1);
			}
			else
			{
				this.WriteLeInt((int)2.Method12805());
			}
			if (2.GetFlag10008_12795() || 2.Method12803() >= (long)((ulong)-1))
			{
				this.WriteLeInt(-1);
			}
			else
			{
				this.WriteLeInt((int)2.Method12803());
			}
			byte[] array = 448.Method4014(2.GetNumber10005_12779(), 2.GetText9996_12802());
			if (array.Length > 65535)
			{
				throw new 415("Name too long.");
			}
			758 3 = new 758(2.GetByteArray10003_12812());
			if (2.Method12797())
			{
				3.SetMemoryStream9560_12229();
				if (2.GetFlag10008_12795() || 2.Method12803() >= (long)((ulong)-1))
				{
					3.Method12235(2.Method12803());
				}
				if (2.GetFlag10008_12795() || 2.Method12805() >= (long)((ulong)-1))
				{
					3.Method12235(2.Method12805());
				}
				if (2.GetNumber10007_12783() >= (long)((ulong)-1))
				{
					3.Method12235(2.GetNumber10007_12783());
				}
				3.Method12230(1);
			}
			else
			{
				3.Method12236(1);
			}
			if (2.Method12814() > 0)
			{
				987.AddExtraDataAES(2, 3);
			}
			byte[] array2 = 3.Method12217();
			byte[] array3 = (2.GetText10004_12821() != null) ? 448.Method4014(2.GetNumber10005_12779(), 2.GetText10004_12821()) : new byte[0];
			if (array3.Length > 65535)
			{
				throw new 415("Comment too long.");
			}
			this.WriteLeShort(array.Length);
			this.WriteLeShort(array2.Length);
			this.WriteLeShort(array3.Length);
			this.WriteLeShort(0);
			this.WriteLeShort(0);
			if (2.Method12785() != -1)
			{
				this.WriteLeInt(2.Method12785());
			}
			else if (2.Method12823())
			{
				this.WriteLeInt(16);
			}
			else
			{
				this.WriteLeInt(0);
			}
			if (2.GetNumber10007_12783() >= (long)((ulong)-1))
			{
				this.WriteLeInt(-1);
			}
			else
			{
				this.WriteLeInt((int)2.GetNumber10007_12783());
			}
			if (array.Length != 0)
			{
				this.stream2.Write(array, 0, array.Length);
			}
			if (array2.Length != 0)
			{
				this.stream2.Write(array2, 0, array2.Length);
			}
			if (array3.Length != 0)
			{
				this.stream2.Write(array3, 0, array3.Length);
			}
			num += (long)(46 + array.Length + array2.Length + array3.Length);
		}
		403 4 = new 403(this.stream2);
		try
		{
			4._0008_2006_2000_200A_2003_200B_2002_2006_2005_200B_2008_2005_2009_2003_2000(<<EMPTY_NAME>>, num, this.offset, this.commentBytes);
		}
		finally
		{
			((IDisposable)4).Dispose();
		}
		this.arrayList = null;
	}

	// Token: 0x04000BB4 RID: 2996
	private ArrayList arrayList = new ArrayList();

	// Token: 0x04000BB5 RID: 2997
	private 597 crc = new 597();

	// Token: 0x04000BB6 RID: 2998
	private 783 curEntry;

	// Token: 0x04000BB7 RID: 2999
	private int defaultCompressionLevel = -1;

	// Token: 0x04000BB8 RID: 3000
	private 536 curMethod = 536.Deflated;

	// Token: 0x04000BB9 RID: 3001
	private long entrySize;

	// Token: 0x04000BBA RID: 3002
	private long offset;

	// Token: 0x04000BBB RID: 3003
	private byte[] commentBytes = new byte[0];

	// Token: 0x04000BBC RID: 3004
	private bool patchEntryHeader;

	// Token: 0x04000BBD RID: 3005
	private long crcPatchPos = -1L;

	// Token: 0x04000BBE RID: 3006
	private long sizePatchPos = -1L;

	// Token: 0x04000BBF RID: 3007
	private 609 useZip64 = (609)2;
}
