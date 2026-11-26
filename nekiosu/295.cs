using System;
using System.IO;
using System.Text;

// Token: 0x02000035 RID: 53
public sealed class 295 : IDisposable
{
	// Token: 0x06000151 RID: 337 RVA: 0x0000780B File Offset: 0x00005A0B
	public 295(331 1) : this(1, new UTF8Encoding())
	{
	}

	// Token: 0x06000152 RID: 338 RVA: 0x0000781C File Offset: 0x00005A1C
	private 295(331 1, Encoding 2)
	{
		if (1 == null)
		{
			throw new ArgumentNullException();
		}
		if (2 == null)
		{
			throw new ArgumentNullException();
		}
		if (!1.GetFlag0541_880())
		{
			throw new ArgumentException();
		}
		this._recoveredType01500075 = 1;
		this.decoder = 2.GetDecoder();
		this.number5 = 2.GetMaxCharCount(128);
		int num = 2.GetMaxByteCount(1);
		if (num < 16)
		{
			num = 16;
		}
		this.byteArray2 = new byte[num];
		this.charArray3 = null;
		this.byteArray3 = null;
		this.flag2 = (2 is UnicodeEncoding);
		this.flag3 = (this._recoveredType01500075 is 333);
	}

	// Token: 0x06000153 RID: 339 RVA: 0x000078C0 File Offset: 0x00005AC0
	public 331 GetRecoveredType01500075_201()
	{
		return this._recoveredType01500075;
	}

	// Token: 0x06000154 RID: 340 RVA: 0x000078C8 File Offset: 0x00005AC8
	public void Method0202()
	{
		this.Method0203(true);
	}

	// Token: 0x06000155 RID: 341 RVA: 0x000078D4 File Offset: 0x00005AD4
	private void Method0203(bool 1)
	{
		if (1)
		{
			331 recoveredType = this._recoveredType01500075;
			this._recoveredType01500075 = null;
			if (recoveredType != null)
			{
				recoveredType.Method0855();
			}
		}
		this._recoveredType01500075 = null;
		this.byteArray2 = null;
		this.decoder = null;
		this.byteArray3 = null;
		this.charArray2 = null;
		this.charArray3 = null;
	}

	// Token: 0x06000156 RID: 342 RVA: 0x000078C8 File Offset: 0x00005AC8
	private void Method0204()
	{
		this.Method0203(true);
	}

	// Token: 0x06000157 RID: 343 RVA: 0x00007926 File Offset: 0x00005B26
	void IDisposable.Dispose()
	{
		this.Method0204();
	}

	// Token: 0x06000158 RID: 344 RVA: 0x00007930 File Offset: 0x00005B30
	public int Method0205()
	{
		this.Method0219();
		if (!this._recoveredType01500075.GetFlag0541_881())
		{
			return -1;
		}
		long <<EMPTY_NAME>> = this._recoveredType01500075.Method0893();
		int result = this.Method0206();
		this._recoveredType01500075.Method0894(<<EMPTY_NAME>>);
		return result;
	}

	// Token: 0x06000159 RID: 345 RVA: 0x00007970 File Offset: 0x00005B70
	public int Method0206()
	{
		this.Method0219();
		return this.Method0216();
	}

	// Token: 0x0600015A RID: 346 RVA: 0x0000797E File Offset: 0x00005B7E
	public bool Method0207()
	{
		this.Method0221(1);
		return this.byteArray2[0] > 0;
	}

	// Token: 0x0600015B RID: 347 RVA: 0x00007992 File Offset: 0x00005B92
	public byte Method0208()
	{
		this.Method0219();
		int num = this._recoveredType01500075.Method0896();
		if (num == -1)
		{
			throw new Exception();
		}
		return (byte)num;
	}

	// Token: 0x0600015C RID: 348 RVA: 0x000079B0 File Offset: 0x00005BB0
	public sbyte Method0209()
	{
		this.Method0221(1);
		return (sbyte)this.byteArray2[0];
	}

	// Token: 0x0600015D RID: 349 RVA: 0x000079C2 File Offset: 0x00005BC2
	public char Method0210()
	{
		int num = this.Method0206();
		if (num == -1)
		{
			throw new Exception();
		}
		return (char)num;
	}

	// Token: 0x0600015E RID: 350 RVA: 0x000079D8 File Offset: 0x00005BD8
	private static decimal Method0211(int 1, int 2, int 3, int 4)
	{
		bool isNegative = (4 & int.MinValue) != 0;
		byte scale = (byte)(4 >> 16);
		return new decimal(1, 2, 3, isNegative, scale);
	}

	// Token: 0x0600015F RID: 351 RVA: 0x00007A00 File Offset: 0x00005C00
	internal static decimal Method0212(byte[] 1)
	{
		int 2 = (int)1[0] | (int)1[1] << 8 | (int)1[2] << 16 | (int)1[3] << 24;
		int 3 = (int)1[4] | (int)1[5] << 8 | (int)1[6] << 16 | (int)1[7] << 24;
		int 4 = (int)1[8] | (int)1[9] << 8 | (int)1[10] << 16 | (int)1[11] << 24;
		int 5 = (int)1[12] | (int)1[13] << 8 | (int)1[14] << 16 | (int)1[15] << 24;
		return 295.Method0211(2, 3, 4, 5);
	}

	// Token: 0x06000160 RID: 352 RVA: 0x00007A7C File Offset: 0x00005C7C
	public string Method0213()
	{
		int num = 0;
		this.Method0219();
		int num2 = this.Method0222();
		if (num2 < 0)
		{
			throw new IOException();
		}
		if (num2 == 0)
		{
			return string.Empty;
		}
		if (this.byteArray3 == null)
		{
			this.byteArray3 = new byte[128];
		}
		if (this.charArray3 == null)
		{
			this.charArray3 = new char[this.number5];
		}
		StringBuilder stringBuilder = null;
		int chars;
		for (;;)
		{
			int <<EMPTY_NAME>> = (num2 - num > 128) ? 128 : (num2 - num);
			int num3 = this._recoveredType01500075.Method0895(this.byteArray3, 0, <<EMPTY_NAME>>);
			if (num3 == 0)
			{
				break;
			}
			chars = this.decoder.GetChars(this.byteArray3, 0, num3, this.charArray3, 0);
			if (num == 0 && num3 == num2)
			{
				goto Block_8;
			}
			if (stringBuilder == null)
			{
				stringBuilder = new StringBuilder(num2);
			}
			stringBuilder.Append(this.charArray3, 0, chars);
			num += num3;
			if (num >= num2)
			{
				goto Block_10;
			}
		}
		throw new Exception();
		Block_8:
		return new string(this.charArray3, 0, chars);
		Block_10:
		return stringBuilder.ToString();
	}

	// Token: 0x06000161 RID: 353 RVA: 0x00007B74 File Offset: 0x00005D74
	public int Method0214(char[] 1, int 2, int 3)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=zMcx_QXg=", "ArgumentNull_Buffer");
		}
		if (2 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (3 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (1.Length - 2 < 3)
		{
			throw new ArgumentException();
		}
		this.Method0219();
		return this.Method0215(1, 2, 3);
	}

	// Token: 0x06000162 RID: 354 RVA: 0x00007BC8 File Offset: 0x00005DC8
	private int Method0215(char[] 1, int 2, int 3)
	{
		int i = 3;
		if (this.byteArray3 == null)
		{
			this.byteArray3 = new byte[128];
		}
		while (i > 0)
		{
			int num = i;
			if (this.flag2)
			{
				num <<= 1;
			}
			if (num > 128)
			{
				num = 128;
			}
			int chars;
			if (this.flag3)
			{
				333 4 = (333)this._recoveredType01500075;
				int byteIndex = 4.Method0888();
				num = 4.Method0889(num);
				if (num == 0)
				{
					return 3 - i;
				}
				chars = this.decoder.GetChars(4.GetByteArray0534_886(), byteIndex, num, 1, 2);
			}
			else
			{
				num = this._recoveredType01500075.Method0895(this.byteArray3, 0, num);
				if (num == 0)
				{
					return 3 - i;
				}
				chars = this.decoder.GetChars(this.byteArray3, 0, num, 1, 2);
			}
			i -= chars;
			2 += chars;
		}
		return 3;
	}

	// Token: 0x06000163 RID: 355 RVA: 0x00007CA0 File Offset: 0x00005EA0
	private int Method0216()
	{
		int num = 0;
		long num2 = num2 = 0L;
		if (this._recoveredType01500075.GetFlag0541_881())
		{
			num2 = this._recoveredType01500075.Method0893();
		}
		if (this.byteArray3 == null)
		{
			this.byteArray3 = new byte[128];
		}
		if (this.charArray2 == null)
		{
			this.charArray2 = new char[1];
		}
		while (num == 0)
		{
			int num3 = (!this.flag2) ? 1 : 2;
			int num4 = this._recoveredType01500075.Method0896();
			this.byteArray3[0] = (byte)num4;
			if (num4 == -1)
			{
				num3 = 0;
			}
			if (num3 == 2)
			{
				num4 = this._recoveredType01500075.Method0896();
				this.byteArray3[1] = (byte)num4;
				if (num4 == -1)
				{
					num3 = 1;
				}
			}
			if (num3 == 0)
			{
				return -1;
			}
			try
			{
				num = this.decoder.GetChars(this.byteArray3, 0, num3, this.charArray2, 0);
			}
			catch
			{
				if (this._recoveredType01500075.GetFlag0541_881())
				{
					this._recoveredType01500075.Method0897(num2 - this._recoveredType01500075.Method0893(), 1);
				}
				throw;
			}
		}
		if (num == 0)
		{
			return -1;
		}
		return (int)this.charArray2[0];
	}

	// Token: 0x06000164 RID: 356 RVA: 0x00007DBC File Offset: 0x00005FBC
	public char[] Method0217(int 1)
	{
		this.Method0219();
		if (1 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		char[] array = new char[1];
		int num = this.Method0215(array, 0, 1);
		if (num != 1)
		{
			char[] array2 = new char[num];
			Buffer.BlockCopy(array, 0, array2, 0, 2 * num);
			array = array2;
		}
		return array;
	}

	// Token: 0x06000165 RID: 357 RVA: 0x00007E04 File Offset: 0x00006004
	public int Method0218(byte[] 1, int 2, int 3)
	{
		if (1 == null)
		{
			throw new ArgumentNullException();
		}
		if (2 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (3 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (1.Length - 2 < 3)
		{
			throw new ArgumentException();
		}
		this.Method0219();
		return this._recoveredType01500075.Method0895(1, 2, 3);
	}

	// Token: 0x06000166 RID: 358 RVA: 0x00007E50 File Offset: 0x00006050
	private void Method0219()
	{
		if (this._recoveredType01500075 == null)
		{
			throw new Exception();
		}
	}

	// Token: 0x06000167 RID: 359 RVA: 0x00007E60 File Offset: 0x00006060
	public byte[] Method0220(int 1)
	{
		if (1 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		this.Method0219();
		byte[] array = new byte[1];
		int num = 0;
		do
		{
			int num2 = this._recoveredType01500075.Method0895(array, num, 1);
			if (num2 == 0)
			{
				break;
			}
			num += num2;
			1 -= num2;
		}
		while (1 > 0);
		if (num != array.Length)
		{
			byte[] array2 = new byte[num];
			Buffer.BlockCopy(array, 0, array2, 0, num);
			array = array2;
		}
		return array;
	}

	// Token: 0x06000168 RID: 360 RVA: 0x00007EC0 File Offset: 0x000060C0
	private void Method0221(int 1)
	{
		this.Method0219();
		int num = 0;
		int num2;
		if (1 != 1)
		{
			for (;;)
			{
				num2 = this._recoveredType01500075.Method0895(this.byteArray2, num, 1 - num);
				if (num2 == 0)
				{
					break;
				}
				num += num2;
				if (num >= 1)
				{
					return;
				}
			}
			throw new Exception();
		}
		num2 = this._recoveredType01500075.Method0896();
		if (num2 == -1)
		{
			throw new Exception();
		}
		this.byteArray2[0] = (byte)num2;
	}

	// Token: 0x06000169 RID: 361 RVA: 0x00007F24 File Offset: 0x00006124
	internal int Method0222()
	{
		int num = 0;
		int num2 = 0;
		while (num2 != 35)
		{
			byte b = this.Method0208();
			num |= (int)(b & 127) << num2;
			num2 += 7;
			if ((b & 128) == 0)
			{
				return num;
			}
		}
		throw new FormatException();
	}

	// Token: 0x0600016A RID: 362 RVA: 0x00007F64 File Offset: 0x00006164
	public int Method0223()
	{
		if (this.flag3)
		{
			return ((333)this._recoveredType01500075).Method0903();
		}
		this.Method0221(4);
		return (int)this.byteArray2[1] << 24 | (int)this.byteArray2[0] | (int)this.byteArray2[2] << 8 | (int)this.byteArray2[3] << 16;
	}

	// Token: 0x0600016B RID: 363 RVA: 0x00007FBC File Offset: 0x000061BC
	public uint Method0224()
	{
		this.Method0221(4);
		return (uint)((int)this.byteArray2[3] << 24 | (int)this.byteArray2[1] << 8 | (int)this.byteArray2[2] << 16 | (int)this.byteArray2[0]);
	}

	// Token: 0x0600016C RID: 364 RVA: 0x00007FF0 File Offset: 0x000061F0
	public long Method0225()
	{
		this.Method0221(8);
		byte[] array = this.byteArray2;
		return (long)((ulong)((int)array[7] << 24 | (int)array[3] | (int)array[5] << 16 | (int)array[4] << 8) | (ulong)((ulong)((long)((int)array[0] << 8 | (int)array[6] << 16 | (int)array[2] | (int)array[1] << 24)) << 32));
	}

	// Token: 0x0600016D RID: 365 RVA: 0x00008040 File Offset: 0x00006240
	public ulong Method0226()
	{
		this.Method0221(8);
		byte[] array = this.byteArray2;
		return (ulong)((int)array[5] << 8 | (int)array[0] | (int)array[7] << 24 | (int)array[3] << 16) | (ulong)((ulong)((long)((int)array[2] << 8 | (int)array[6] << 24 | (int)array[1] | (int)array[4] << 16)) << 32);
	}

	// Token: 0x0600016E RID: 366 RVA: 0x00008090 File Offset: 0x00006290
	public short Method0227()
	{
		this.Method0221(2);
		byte[] array = this.byteArray2;
		return (short)((int)array[0] << 8 | (int)array[1]);
	}

	// Token: 0x0600016F RID: 367 RVA: 0x000080B8 File Offset: 0x000062B8
	public ushort Method0228()
	{
		this.Method0221(2);
		byte[] array = this.byteArray2;
		return (ushort)((int)array[0] << 8 | (int)array[1]);
	}

	// Token: 0x06000170 RID: 368 RVA: 0x000080E0 File Offset: 0x000062E0
	private byte[] Method0229()
	{
		byte[] array = this.byteArray4;
		if (array == null)
		{
			array = (this.byteArray4 = new byte[16]);
		}
		return array;
	}

	// Token: 0x06000171 RID: 369 RVA: 0x0000810C File Offset: 0x0000630C
	public float Method0230()
	{
		this.Method0221(4);
		byte[] array = this.byteArray2;
		byte[] array2 = this.Method0229();
		array2[3] = array[3];
		array2[1] = array[1];
		array2[2] = array[2];
		array2[0] = array[0];
		return this.Method0233(array2).ReadSingle();
	}

	// Token: 0x06000172 RID: 370 RVA: 0x00008154 File Offset: 0x00006354
	public double Method0231()
	{
		this.Method0221(8);
		byte[] array = this.byteArray2;
		byte[] array2 = this.Method0229();
		array2[2] = array[0];
		array2[4] = array[2];
		array2[7] = array[4];
		array2[1] = array[7];
		array2[5] = array[1];
		array2[6] = array[6];
		array2[0] = array[5];
		array2[3] = array[3];
		return this.Method0233(array2).ReadDouble();
	}

	// Token: 0x06000173 RID: 371 RVA: 0x000081B4 File Offset: 0x000063B4
	public decimal Method0232()
	{
		this.Method0221(16);
		byte[] array = this.byteArray2;
		byte[] array2 = this.Method0229();
		array2[9] = array[6];
		array2[8] = array[9];
		array2[5] = array[4];
		array2[1] = array[15];
		array2[6] = array[7];
		array2[13] = array[12];
		array2[2] = array[13];
		array2[12] = array[10];
		array2[15] = array[2];
		array2[0] = array[3];
		array2[11] = array[5];
		array2[10] = array[0];
		array2[3] = array[8];
		array2[14] = array[14];
		array2[7] = array[1];
		array2[4] = array[11];
		return 295.Method0212(array2);
	}

	// Token: 0x06000174 RID: 372 RVA: 0x0000824C File Offset: 0x0000644C
	private BinaryReader Method0233(byte[] 1)
	{
		MemoryStream memoryStream = this.memoryStream2;
		BinaryReader binaryReader = this.binaryReader2;
		if (memoryStream == null)
		{
			memoryStream = (this.memoryStream2 = new MemoryStream(8));
			binaryReader = (this.binaryReader2 = new BinaryReader(memoryStream));
		}
		else
		{
			binaryReader.BaseStream.Position = 0L;
		}
		memoryStream.Write(1, 0, 1.Length);
		memoryStream.Position = 0L;
		return binaryReader;
	}

	// Token: 0x04000081 RID: 129
	private 331 _recoveredType01500075;

	// Token: 0x04000082 RID: 130
	private byte[] byteArray2;

	// Token: 0x04000083 RID: 131
	private Decoder decoder;

	// Token: 0x04000084 RID: 132
	private byte[] byteArray3;

	// Token: 0x04000085 RID: 133
	private char[] charArray2;

	// Token: 0x04000086 RID: 134
	private char[] charArray3;

	// Token: 0x04000087 RID: 135
	private int number5;

	// Token: 0x04000088 RID: 136
	private bool flag2;

	// Token: 0x04000089 RID: 137
	private bool flag3;

	// Token: 0x0400008A RID: 138
	private byte[] byteArray4;

	// Token: 0x0400008B RID: 139
	private MemoryStream memoryStream2;

	// Token: 0x0400008C RID: 140
	private BinaryReader binaryReader2;
}
