using System;
using System.IO;
using System.Runtime.InteropServices;

// Token: 0x02000314 RID: 788
[ComVisible(false)]
public sealed class 714 : Stream
{
	// Token: 0x17000110 RID: 272
	// (get) Token: 0x0600179E RID: 6046 RVA: 0x0000FF75 File Offset: 0x0000E175
	public override bool CanRead
	{
		get
		{
			return false;
		}
	}

	// Token: 0x17000111 RID: 273
	// (get) Token: 0x0600179F RID: 6047 RVA: 0x0000FF75 File Offset: 0x0000E175
	public override bool CanSeek
	{
		get
		{
			return false;
		}
	}

	// Token: 0x17000112 RID: 274
	// (get) Token: 0x060017A0 RID: 6048 RVA: 0x00051596 File Offset: 0x0004F796
	public override bool CanWrite
	{
		get
		{
			return this.stream2.CanWrite;
		}
	}

	// Token: 0x17000113 RID: 275
	// (get) Token: 0x060017A1 RID: 6049 RVA: 0x000515A3 File Offset: 0x0004F7A3
	public override long Length
	{
		get
		{
			return this.stream2.Length;
		}
	}

	// Token: 0x17000114 RID: 276
	// (get) Token: 0x060017A2 RID: 6050 RVA: 0x000515B0 File Offset: 0x0004F7B0
	// (set) Token: 0x060017A3 RID: 6051 RVA: 0x000515BD File Offset: 0x0004F7BD
	public override long Position
	{
		get
		{
			return this.stream2.Position;
		}
		set
		{
			throw new NotSupportedException("BZip2OutputStream position cannot be set");
		}
	}

	// Token: 0x060017A4 RID: 6052 RVA: 0x000515C9 File Offset: 0x0004F7C9
	public 714(Stream 1) : this(1, 9)
	{
	}

	// Token: 0x060017A5 RID: 6053 RVA: 0x000515D4 File Offset: 0x0004F7D4
	public 714(Stream 1, int 2)
	{
		this.Method11036(1);
		this.number15 = 50;
		if (2 > 9)
		{
			2 = 9;
		}
		if (2 < 1)
		{
			2 = 1;
		}
		this.number9 = 2;
		this.Method11051();
		this.Method11032();
		this.Method11033();
	}

	// Token: 0x060017A6 RID: 6054 RVA: 0x000516B0 File Offset: 0x0004F8B0
	~714()
	{
		this.Dispose(false);
	}

	// Token: 0x060017A7 RID: 6055 RVA: 0x000516E0 File Offset: 0x0004F8E0
	public bool _0002_2007_2005_2009_2005_2004_2001_2009_2007_2008_200A_2005_2009_2002_200B_2008_2004()
	{
		return this.flag2;
	}

	// Token: 0x060017A8 RID: 6056 RVA: 0x000516E8 File Offset: 0x0004F8E8
	public void _0006_2001_2009_200A_200B_2003_2006_2003_2006_2001_2001_2009_200B_2007_2003(bool 1)
	{
		this.flag2 = 1;
	}

	// Token: 0x060017A9 RID: 6057 RVA: 0x000516F1 File Offset: 0x0004F8F1
	public override long Seek(long 1, SeekOrigin 2)
	{
		throw new NotSupportedException("BZip2OutputStream Seek not supported");
	}

	// Token: 0x060017AA RID: 6058 RVA: 0x000516FD File Offset: 0x0004F8FD
	public override void SetLength(long 1)
	{
		throw new NotSupportedException("BZip2OutputStream SetLength not supported");
	}

	// Token: 0x060017AB RID: 6059 RVA: 0x00051709 File Offset: 0x0004F909
	public override int ReadByte()
	{
		throw new NotSupportedException("BZip2OutputStream ReadByte not supported");
	}

	// Token: 0x060017AC RID: 6060 RVA: 0x00051715 File Offset: 0x0004F915
	public override int Read(byte[] 1, int 2, int 3)
	{
		throw new NotSupportedException("BZip2OutputStream Read not supported");
	}

	// Token: 0x060017AD RID: 6061 RVA: 0x00051724 File Offset: 0x0004F924
	public override void Write(byte[] 1, int 2, int 3)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=zpMJwVYM=");
		}
		if (2 < 0)
		{
			throw new ArgumentOutOfRangeException("#=zJ_sgkP4=");
		}
		if (3 < 0)
		{
			throw new ArgumentOutOfRangeException("#=zW32YDQ0=");
		}
		if (1.Length - 2 < 3)
		{
			throw new ArgumentException("Offset/count out of range");
		}
		for (int i = 0; i < 3; i++)
		{
			this.WriteByte(1[2 + i]);
		}
	}

	// Token: 0x060017AE RID: 6062 RVA: 0x00051788 File Offset: 0x0004F988
	public override void WriteByte(byte 1)
	{
		int num = (256 + (int)1) % 256;
		if (this.number19 != -1)
		{
			if (this.number19 != num)
			{
				this.Method11031();
				this.number20 = 1;
				this.number19 = num;
				return;
			}
			this.number20++;
			if (this.number20 > 254)
			{
				this.Method11031();
				this.number19 = -1;
				this.number20 = 0;
				return;
			}
		}
		else
		{
			this.number19 = num;
			this.number20++;
		}
	}

	// Token: 0x060017AF RID: 6063 RVA: 0x0005180F File Offset: 0x0004FA0F
	public override void Close()
	{
		this.Dispose(true);
		GC.SuppressFinalize(this);
	}

	// Token: 0x060017B0 RID: 6064 RVA: 0x00051820 File Offset: 0x0004FA20
	private void Method11030()
	{
		this.number13 = 0;
		for (int i = 0; i < 256; i++)
		{
			if (this.flagArray[i])
			{
				this.charArray2[this.number13] = (char)i;
				this.charArray3[i] = (char)this.number13;
				this.number13++;
			}
		}
	}

	// Token: 0x060017B1 RID: 6065 RVA: 0x0005187C File Offset: 0x0004FA7C
	private void Method11031()
	{
		if (this.number7 >= this.number23)
		{
			this.Method11034();
			this.Method11033();
			this.Method11031();
			return;
		}
		this.flagArray[this.number19] = true;
		for (int i = 0; i < this.number20; i++)
		{
			this._recoveredType17158731.Method90912(this.number19);
		}
		switch (this.number20)
		{
		case 1:
			this.number7++;
			this.byteArray2[this.number7 + 1] = (byte)this.number19;
			return;
		case 2:
			this.number7++;
			this.byteArray2[this.number7 + 1] = (byte)this.number19;
			this.number7++;
			this.byteArray2[this.number7 + 1] = (byte)this.number19;
			return;
		case 3:
			this.number7++;
			this.byteArray2[this.number7 + 1] = (byte)this.number19;
			this.number7++;
			this.byteArray2[this.number7 + 1] = (byte)this.number19;
			this.number7++;
			this.byteArray2[this.number7 + 1] = (byte)this.number19;
			return;
		default:
			this.flagArray[this.number20 - 4] = true;
			this.number7++;
			this.byteArray2[this.number7 + 1] = (byte)this.number19;
			this.number7++;
			this.byteArray2[this.number7 + 1] = (byte)this.number19;
			this.number7++;
			this.byteArray2[this.number7 + 1] = (byte)this.number19;
			this.number7++;
			this.byteArray2[this.number7 + 1] = (byte)this.number19;
			this.number7++;
			this.byteArray2[this.number7 + 1] = (byte)(this.number20 - 4);
			return;
		}
	}

	// Token: 0x060017B2 RID: 6066 RVA: 0x00051A9E File Offset: 0x0004FC9E
	public int _0008_2005_2000_2008_2005_2002_2004_2008_2000_2007_2004_2009_2004_2007_200B_2007_2008_2003()
	{
		return this.number10;
	}

	// Token: 0x060017B3 RID: 6067 RVA: 0x00051AA8 File Offset: 0x0004FCA8
	protected override void Dispose(bool 1)
	{
		try
		{
			base.Dispose(1);
			if (!this.flag5)
			{
				this.flag5 = true;
				if (this.number20 > 0)
				{
					this.Method11031();
				}
				this.number19 = -1;
				this.Method11034();
				this.Method11035();
				this.Flush();
			}
		}
		finally
		{
			if (1 && this._0002_2007_2005_2009_2005_2004_2001_2009_2007_2008_200A_2005_2009_2002_200B_2008_2004())
			{
				this.stream2.Close();
			}
		}
	}

	// Token: 0x060017B4 RID: 6068 RVA: 0x00051B1C File Offset: 0x0004FD1C
	public override void Flush()
	{
		this.stream2.Flush();
	}

	// Token: 0x060017B5 RID: 6069 RVA: 0x00051B29 File Offset: 0x0004FD29
	private void Method11032()
	{
		this.number10 = 0;
		this.number18 = 0;
		this.Method11039(66);
		this.Method11039(90);
		this.Method11039(104);
		this.Method11039(48 + this.number9);
		this.number22 = 0U;
	}

	// Token: 0x060017B6 RID: 6070 RVA: 0x00051B68 File Offset: 0x0004FD68
	private void Method11033()
	{
		this._recoveredType17158731.SetNumber7041_9090();
		this.number7 = -1;
		for (int i = 0; i < 256; i++)
		{
			this.flagArray[i] = false;
		}
		this.number23 = 100000 * this.number9 - 20;
	}

	// Token: 0x060017B7 RID: 6071 RVA: 0x00051BB8 File Offset: 0x0004FDB8
	private void Method11034()
	{
		if (this.number7 >= 0)
		{
			this.number21 = (uint)this._recoveredType17158731.GetNumber7041_9089();
			this.number22 = (this.number22 << 1 | this.number22 >> 31);
			this.number22 ^= this.number21;
			this.Method11049();
			this.Method11039(49);
			this.Method11039(65);
			this.Method11039(89);
			this.Method11039(38);
			this.Method11039(83);
			this.Method11039(89);
			this.Method11040((int)this.number21);
			if (this.flag3)
			{
				this.Method11038(1, 1);
				this.number18++;
			}
			else
			{
				this.Method11038(1, 0);
			}
			this.Method11043();
		}
	}

	// Token: 0x060017B8 RID: 6072 RVA: 0x00051C80 File Offset: 0x0004FE80
	private void Method11035()
	{
		this.Method11039(23);
		this.Method11039(114);
		this.Method11039(69);
		this.Method11039(56);
		this.Method11039(80);
		this.Method11039(144);
		this.Method11040((int)this.number22);
		this.Method11037();
	}

	// Token: 0x060017B9 RID: 6073 RVA: 0x00051CD2 File Offset: 0x0004FED2
	private void Method11036(Stream 1)
	{
		this.stream2 = 1;
		this.number12 = 0;
		this.number11 = 0;
		this.number10 = 0;
	}

	// Token: 0x060017BA RID: 6074 RVA: 0x00051CF0 File Offset: 0x0004FEF0
	private void Method11037()
	{
		while (this.number12 > 0)
		{
			int num = this.number11 >> 24;
			this.stream2.WriteByte((byte)num);
			this.number11 <<= 8;
			this.number12 -= 8;
			this.number10++;
		}
	}

	// Token: 0x060017BB RID: 6075 RVA: 0x00051D4C File Offset: 0x0004FF4C
	private void Method11038(int 1, int 2)
	{
		while (this.number12 >= 8)
		{
			int num = this.number11 >> 24;
			this.stream2.WriteByte((byte)num);
			this.number11 <<= 8;
			this.number12 -= 8;
			this.number10++;
		}
		this.number11 |= 2 << 32 - this.number12 - 1;
		this.number12 += 1;
	}

	// Token: 0x060017BC RID: 6076 RVA: 0x00051DD0 File Offset: 0x0004FFD0
	private void Method11039(int 1)
	{
		this.Method11038(8, 1);
	}

	// Token: 0x060017BD RID: 6077 RVA: 0x00051DDC File Offset: 0x0004FFDC
	private void Method11040(int 1)
	{
		this.Method11038(8, 1 >> 24 & 255);
		this.Method11038(8, 1 >> 16 & 255);
		this.Method11038(8, 1 >> 8 & 255);
		this.Method11038(8, 1 & 255);
	}

	// Token: 0x060017BE RID: 6078 RVA: 0x00051E29 File Offset: 0x00050029
	private void Method11041(int 1, int 2)
	{
		this.Method11038(1, 2);
	}

	// Token: 0x060017BF RID: 6079 RVA: 0x00051E34 File Offset: 0x00050034
	private void Method11042()
	{
		char[][] array = new char[6][];
		for (int i = 0; i < 6; i++)
		{
			array[i] = new char[258];
		}
		int num = 0;
		int num2 = this.number13 + 2;
		for (int j = 0; j < 6; j++)
		{
			for (int k = 0; k < num2; k++)
			{
				array[j][k] = '\u000f';
			}
		}
		if (this.number14 <= 0)
		{
			714.Method11053();
		}
		int num3 = (this.number14 < 200) ? 2 : ((this.number14 < 600) ? 3 : ((this.number14 < 1200) ? 4 : ((this.number14 >= 2400) ? 6 : 5)));
		int l = num3;
		int num4 = this.number14;
		int m = 0;
		while (l > 0)
		{
			int num5 = num4 / l;
			int num6 = 0;
			int num7 = m - 1;
			while (num6 < num5 && num7 < num2 - 1)
			{
				num7++;
				num6 += this.numberArray6[num7];
			}
			if (num7 > m && l != num3 && l != 1 && (num3 - l) % 2 == 1)
			{
				num6 -= this.numberArray6[num7];
				num7--;
			}
			for (int n = 0; n < num2; n++)
			{
				if (n >= m && n <= num7)
				{
					array[l - 1][n] = '\0';
				}
				else
				{
					array[l - 1][n] = '\u000f';
				}
			}
			l--;
			m = num7 + 1;
			num4 -= num6;
		}
		int[][] array2 = new int[6][];
		for (int num8 = 0; num8 < 6; num8++)
		{
			array2[num8] = new int[258];
		}
		int[] array3 = new int[6];
		short[] array4 = new short[6];
		for (int num9 = 0; num9 < 4; num9++)
		{
			for (int num10 = 0; num10 < num3; num10++)
			{
				array3[num10] = 0;
			}
			for (int num11 = 0; num11 < num3; num11++)
			{
				for (int num12 = 0; num12 < num2; num12++)
				{
					array2[num11][num12] = 0;
				}
			}
			num = 0;
			int num13 = 0;
			int num14;
			for (m = 0; m < this.number14; m = num14 + 1)
			{
				num14 = m + 50 - 1;
				if (num14 >= this.number14)
				{
					num14 = this.number14 - 1;
				}
				for (int num15 = 0; num15 < num3; num15++)
				{
					array4[num15] = 0;
				}
				if (num3 == 6)
				{
					short num21;
					short num20;
					short num19;
					short num18;
					short num17;
					short num16 = num17 = (num18 = (num19 = (num20 = (num21 = 0))));
					for (int num22 = m; num22 <= num14; num22++)
					{
						short num23 = this.int16Array[num22];
						num17 += (short)array[0][(int)num23];
						num16 += (short)array[1][(int)num23];
						num18 += (short)array[2][(int)num23];
						num19 += (short)array[3][(int)num23];
						num20 += (short)array[4][(int)num23];
						num21 += (short)array[5][(int)num23];
					}
					array4[0] = num17;
					array4[1] = num16;
					array4[2] = num18;
					array4[3] = num19;
					array4[4] = num20;
					array4[5] = num21;
				}
				else
				{
					for (int num24 = m; num24 <= num14; num24++)
					{
						short num25 = this.int16Array[num24];
						for (int num26 = 0; num26 < num3; num26++)
						{
							short[] array5 = array4;
							int num27 = num26;
							array5[num27] += (short)array[num26][(int)num25];
						}
					}
				}
				int num28 = 999999999;
				int num29 = -1;
				for (int num30 = 0; num30 < num3; num30++)
				{
					if ((int)array4[num30] < num28)
					{
						num28 = (int)array4[num30];
						num29 = num30;
					}
				}
				num13 += num28;
				array3[num29]++;
				this.charArray4[num] = (char)num29;
				num++;
				for (int num31 = m; num31 <= num14; num31++)
				{
					array2[num29][(int)this.int16Array[num31]]++;
				}
			}
			for (int num32 = 0; num32 < num3; num32++)
			{
				714.Method11054(array[num32], array2[num32], num2, 20);
			}
		}
		if (num3 >= 8)
		{
			714.Method11053();
		}
		if (num >= 32768 || num > 18002)
		{
			714.Method11053();
		}
		char[] array6 = new char[6];
		for (int num33 = 0; num33 < num3; num33++)
		{
			array6[num33] = (char)num33;
		}
		for (int num34 = 0; num34 < num; num34++)
		{
			char c = this.charArray4[num34];
			int num35 = 0;
			char c2 = array6[num35];
			while (c != c2)
			{
				num35++;
				char c3 = c2;
				c2 = array6[num35];
				array6[num35] = c3;
			}
			array6[0] = c2;
			this.charArray5[num34] = (char)num35;
		}
		int[][] array7 = new int[6][];
		for (int num36 = 0; num36 < 6; num36++)
		{
			array7[num36] = new int[258];
		}
		for (int num37 = 0; num37 < num3; num37++)
		{
			int num38 = 32;
			int num39 = 0;
			for (int num40 = 0; num40 < num2; num40++)
			{
				if ((int)array[num37][num40] > num39)
				{
					num39 = (int)array[num37][num40];
				}
				if ((int)array[num37][num40] < num38)
				{
					num38 = (int)array[num37][num40];
				}
			}
			if (num39 > 20)
			{
				714.Method11053();
			}
			if (num38 < 1)
			{
				714.Method11053();
			}
			714.Method11055(array7[num37], array[num37], num38, num39, num2);
		}
		bool[] array8 = new bool[16];
		for (int num41 = 0; num41 < 16; num41++)
		{
			array8[num41] = false;
			for (int num42 = 0; num42 < 16; num42++)
			{
				if (this.flagArray[num41 * 16 + num42])
				{
					array8[num41] = true;
				}
			}
		}
		for (int num43 = 0; num43 < 16; num43++)
		{
			if (array8[num43])
			{
				this.Method11038(1, 1);
			}
			else
			{
				this.Method11038(1, 0);
			}
		}
		for (int num44 = 0; num44 < 16; num44++)
		{
			if (array8[num44])
			{
				for (int num45 = 0; num45 < 16; num45++)
				{
					if (this.flagArray[num44 * 16 + num45])
					{
						this.Method11038(1, 1);
					}
					else
					{
						this.Method11038(1, 0);
					}
				}
			}
		}
		this.Method11038(3, num3);
		this.Method11038(15, num);
		for (int num46 = 0; num46 < num; num46++)
		{
			for (int num47 = 0; num47 < (int)this.charArray5[num46]; num47++)
			{
				this.Method11038(1, 1);
			}
			this.Method11038(1, 0);
		}
		for (int num48 = 0; num48 < num3; num48++)
		{
			int num49 = (int)array[num48][0];
			this.Method11038(5, num49);
			for (int num50 = 0; num50 < num2; num50++)
			{
				while (num49 < (int)array[num48][num50])
				{
					this.Method11038(2, 2);
					num49++;
				}
				while (num49 > (int)array[num48][num50])
				{
					this.Method11038(2, 3);
					num49--;
				}
				this.Method11038(1, 0);
			}
		}
		int num51 = 0;
		m = 0;
		while (m < this.number14)
		{
			int num52 = m + 50 - 1;
			if (num52 >= this.number14)
			{
				num52 = this.number14 - 1;
			}
			for (int num53 = m; num53 <= num52; num53++)
			{
				this.Method11038((int)array[(int)this.charArray4[num51]][(int)this.int16Array[num53]], array7[(int)this.charArray4[num51]][(int)this.int16Array[num53]]);
			}
			m = num52 + 1;
			num51++;
		}
		if (num51 != num)
		{
			714.Method11053();
		}
	}

	// Token: 0x060017C0 RID: 6080 RVA: 0x0005254C File Offset: 0x0005074C
	private void Method11043()
	{
		this.Method11041(24, this.number8);
		this.Method11052();
		this.Method11042();
	}

	// Token: 0x060017C1 RID: 6081 RVA: 0x00052568 File Offset: 0x00050768
	private void Method11044(int 1, int 2, int 3)
	{
		int num = 2 - 1 + 1;
		if (num < 2)
		{
			return;
		}
		int i = 0;
		while (this.numberArray2[i] < num)
		{
			i++;
		}
		for (i--; i >= 0; i--)
		{
			int num2 = this.numberArray2[i];
			int j = 1 + num2;
			while (j <= 2)
			{
				int num3 = this.numberArray4[j];
				int num4 = j;
				while (this.Method11050(this.numberArray4[num4 - num2] + 3, num3 + 3))
				{
					this.numberArray4[num4] = this.numberArray4[num4 - num2];
					num4 -= num2;
					if (num4 <= 1 + num2 - 1)
					{
						break;
					}
				}
				this.numberArray4[num4] = num3;
				j++;
				if (j > 2)
				{
					break;
				}
				num3 = this.numberArray4[j];
				num4 = j;
				while (this.Method11050(this.numberArray4[num4 - num2] + 3, num3 + 3))
				{
					this.numberArray4[num4] = this.numberArray4[num4 - num2];
					num4 -= num2;
					if (num4 <= 1 + num2 - 1)
					{
						break;
					}
				}
				this.numberArray4[num4] = num3;
				j++;
				if (j > 2)
				{
					break;
				}
				num3 = this.numberArray4[j];
				num4 = j;
				while (this.Method11050(this.numberArray4[num4 - num2] + 3, num3 + 3))
				{
					this.numberArray4[num4] = this.numberArray4[num4 - num2];
					num4 -= num2;
					if (num4 <= 1 + num2 - 1)
					{
						break;
					}
				}
				this.numberArray4[num4] = num3;
				j++;
				if (this.number16 > this.number17 && this.flag4)
				{
					return;
				}
			}
		}
	}

	// Token: 0x060017C2 RID: 6082 RVA: 0x000526F0 File Offset: 0x000508F0
	private void Method11045(int 1, int 2, int 3)
	{
		while (3 > 0)
		{
			int num = this.numberArray4[1];
			this.numberArray4[1] = this.numberArray4[2];
			this.numberArray4[2] = num;
			1++;
			2++;
			3--;
		}
	}

	// Token: 0x060017C3 RID: 6083 RVA: 0x00052738 File Offset: 0x00050938
	private void Method11046(int 1, int 2, int 3)
	{
		714.715[] array = new 714.715[1000];
		int i = 0;
		array[i].number = 1;
		array[i].number2 = 2;
		array[i].number3 = 3;
		i++;
		while (i > 0)
		{
			if (i >= 1000)
			{
				714.Method11053();
			}
			i--;
			int number = array[i].number;
			int number2 = array[i].number2;
			int number3 = array[i].number3;
			if (number2 - number < 20 || number3 > 10)
			{
				this.Method11044(number, number2, number3);
				if (this.number16 > this.number17 && this.flag4)
				{
					return;
				}
			}
			else
			{
				int num = (int)714.Method11056(this.byteArray2[this.numberArray4[number] + number3 + 1], this.byteArray2[this.numberArray4[number2] + number3 + 1], this.byteArray2[this.numberArray4[number + number2 >> 1] + number3 + 1]);
				int j;
				int num2 = j = number;
				int num4;
				int num3 = num4 = number2;
				for (;;)
				{
					if (j <= num4)
					{
						int num5 = (int)this.byteArray2[this.numberArray4[j] + number3 + 1] - num;
						if (num5 == 0)
						{
							int num6 = this.numberArray4[j];
							this.numberArray4[j] = this.numberArray4[num2];
							this.numberArray4[num2] = num6;
							num2++;
							j++;
							continue;
						}
						if (num5 <= 0)
						{
							j++;
							continue;
						}
					}
					while (j <= num4)
					{
						int num5 = (int)this.byteArray2[this.numberArray4[num4] + number3 + 1] - num;
						if (num5 == 0)
						{
							int num7 = this.numberArray4[num4];
							this.numberArray4[num4] = this.numberArray4[num3];
							this.numberArray4[num3] = num7;
							num3--;
							num4--;
						}
						else
						{
							if (num5 < 0)
							{
								break;
							}
							num4--;
						}
					}
					if (j > num4)
					{
						break;
					}
					int num8 = this.numberArray4[j];
					this.numberArray4[j] = this.numberArray4[num4];
					this.numberArray4[num4] = num8;
					j++;
					num4--;
				}
				if (num3 < num2)
				{
					array[i].number = number;
					array[i].number2 = number2;
					array[i].number3 = number3 + 1;
					i++;
				}
				else
				{
					int num5 = (num2 - number < j - num2) ? (num2 - number) : (j - num2);
					this.Method11045(number, j - num5, num5);
					int num9 = (number2 - num3 < num3 - num4) ? (number2 - num3) : (num3 - num4);
					this.Method11045(j, number2 - num9 + 1, num9);
					num5 = number + j - num2 - 1;
					num9 = number2 - (num3 - num4) + 1;
					array[i].number = number;
					array[i].number2 = num5;
					array[i].number3 = number3;
					i++;
					array[i].number = num5 + 1;
					array[i].number2 = num9 - 1;
					array[i].number3 = number3 + 1;
					i++;
					array[i].number = num9;
					array[i].number2 = number2;
					array[i].number3 = number3;
					i++;
				}
			}
		}
	}

	// Token: 0x060017C4 RID: 6084 RVA: 0x00052A84 File Offset: 0x00050C84
	private void Method11047()
	{
		int[] array = new int[256];
		int[] array2 = new int[256];
		bool[] array3 = new bool[256];
		for (int i = 0; i < 20; i++)
		{
			this.byteArray2[this.number7 + i + 2] = this.byteArray2[i % (this.number7 + 1) + 1];
		}
		for (int j = 0; j <= this.number7 + 20; j++)
		{
			this.numberArray3[j] = 0;
		}
		this.byteArray2[0] = this.byteArray2[this.number7 + 1];
		if (this.number7 < 4000)
		{
			for (int k = 0; k <= this.number7; k++)
			{
				this.numberArray4[k] = k;
			}
			this.flag4 = false;
			this.number16 = (this.number17 = 0);
			this.Method11044(0, this.number7, 0);
			return;
		}
		int num = 0;
		for (int l = 0; l <= 255; l++)
		{
			array3[l] = false;
		}
		for (int m = 0; m <= 65536; m++)
		{
			this.numberArray5[m] = 0;
		}
		int num2 = (int)this.byteArray2[0];
		for (int n = 0; n <= this.number7; n++)
		{
			int num3 = (int)this.byteArray2[n + 1];
			this.numberArray5[(num2 << 8) + num3]++;
			num2 = num3;
		}
		for (int num4 = 1; num4 <= 65536; num4++)
		{
			this.numberArray5[num4] += this.numberArray5[num4 - 1];
		}
		num2 = (int)this.byteArray2[1];
		int num7;
		for (int num5 = 0; num5 < this.number7; num5++)
		{
			int num6 = (int)this.byteArray2[num5 + 2];
			num7 = (num2 << 8) + num6;
			num2 = num6;
			this.numberArray5[num7]--;
			this.numberArray4[this.numberArray5[num7]] = num5;
		}
		num7 = ((int)this.byteArray2[this.number7 + 1] << 8) + (int)this.byteArray2[1];
		this.numberArray5[num7]--;
		this.numberArray4[this.numberArray5[num7]] = this.number7;
		for (int num8 = 0; num8 <= 255; num8++)
		{
			array[num8] = num8;
		}
		int num9 = 1;
		do
		{
			num9 = 3 * num9 + 1;
		}
		while (num9 <= 256);
		do
		{
			num9 /= 3;
			for (int num10 = num9; num10 <= 255; num10++)
			{
				int num11 = array[num10];
				num7 = num10;
				while (this.numberArray5[array[num7 - num9] + 1 << 8] - this.numberArray5[array[num7 - num9] << 8] > this.numberArray5[num11 + 1 << 8] - this.numberArray5[num11 << 8])
				{
					array[num7] = array[num7 - num9];
					num7 -= num9;
					if (num7 <= num9 - 1)
					{
						break;
					}
				}
				array[num7] = num11;
			}
		}
		while (num9 != 1);
		for (int num12 = 0; num12 <= 255; num12++)
		{
			int num13 = array[num12];
			for (num7 = 0; num7 <= 255; num7++)
			{
				int num14 = (num13 << 8) + num7;
				if ((this.numberArray5[num14] & 2097152) != 2097152)
				{
					int num15 = this.numberArray5[num14] & -2097153;
					int num16 = (this.numberArray5[num14 + 1] & -2097153) - 1;
					if (num16 > num15)
					{
						this.Method11046(num15, num16, 2);
						num += num16 - num15 + 1;
						if (this.number16 > this.number17 && this.flag4)
						{
							return;
						}
					}
					this.numberArray5[num14] |= 2097152;
				}
			}
			array3[num13] = true;
			if (num12 < 255)
			{
				int num17 = this.numberArray5[num13 << 8] & -2097153;
				int num18 = (this.numberArray5[num13 + 1 << 8] & -2097153) - num17;
				int num19 = 0;
				while (num18 >> num19 > 65534)
				{
					num19++;
				}
				for (num7 = 0; num7 < num18; num7++)
				{
					int num20 = this.numberArray4[num17 + num7];
					int num21 = num7 >> num19;
					this.numberArray3[num20] = num21;
					if (num20 < 20)
					{
						this.numberArray3[num20 + this.number7 + 1] = num21;
					}
				}
				if (num18 - 1 >> num19 > 65535)
				{
					714.Method11053();
				}
			}
			for (num7 = 0; num7 <= 255; num7++)
			{
				array2[num7] = (this.numberArray5[(num7 << 8) + num13] & -2097153);
			}
			for (num7 = (this.numberArray5[num13 << 8] & -2097153); num7 < (this.numberArray5[num13 + 1 << 8] & -2097153); num7++)
			{
				num2 = (int)this.byteArray2[this.numberArray4[num7]];
				if (!array3[num2])
				{
					this.numberArray4[array2[num2]] = ((this.numberArray4[num7] == 0) ? this.number7 : (this.numberArray4[num7] - 1));
					array2[num2]++;
				}
			}
			for (num7 = 0; num7 <= 255; num7++)
			{
				this.numberArray5[(num7 << 8) + num13] |= 2097152;
			}
		}
	}

	// Token: 0x060017C5 RID: 6085 RVA: 0x00052FE0 File Offset: 0x000511E0
	private void Method11048()
	{
		int num = 0;
		int num2 = 0;
		for (int i = 0; i < 256; i++)
		{
			this.flagArray[i] = false;
		}
		for (int j = 0; j <= this.number7; j++)
		{
			if (num == 0)
			{
				num = 757.numberArray[num2];
				num2++;
				if (num2 == 512)
				{
					num2 = 0;
				}
			}
			num--;
			byte[] array = this.byteArray2;
			int num3 = j + 1;
			array[num3] ^= ((num == 1) ? 1 : 0);
			byte[] array2 = this.byteArray2;
			int num4 = j + 1;
			array2[num4] = array2[num4];
			this.flagArray[(int)this.byteArray2[j + 1]] = true;
		}
	}

	// Token: 0x060017C6 RID: 6086 RVA: 0x00053074 File Offset: 0x00051274
	private void Method11049()
	{
		this.number17 = this.number15 * this.number7;
		this.number16 = 0;
		this.flag3 = false;
		this.flag4 = true;
		this.Method11047();
		if (this.number16 > this.number17 && this.flag4)
		{
			this.Method11048();
			this.number17 = (this.number16 = 0);
			this.flag3 = true;
			this.flag4 = false;
			this.Method11047();
		}
		this.number8 = -1;
		for (int i = 0; i <= this.number7; i++)
		{
			if (this.numberArray4[i] == 0)
			{
				this.number8 = i;
				break;
			}
		}
		if (this.number8 == -1)
		{
			714.Method11053();
		}
	}

	// Token: 0x060017C7 RID: 6087 RVA: 0x00053128 File Offset: 0x00051328
	private bool Method11050(int 1, int 2)
	{
		byte b = this.byteArray2[1 + 1];
		byte b2 = this.byteArray2[2 + 1];
		if (b != b2)
		{
			return b > b2;
		}
		1++;
		2++;
		b = this.byteArray2[1 + 1];
		b2 = this.byteArray2[2 + 1];
		if (b != b2)
		{
			return b > b2;
		}
		1++;
		2++;
		b = this.byteArray2[1 + 1];
		b2 = this.byteArray2[2 + 1];
		if (b != b2)
		{
			return b > b2;
		}
		1++;
		2++;
		b = this.byteArray2[1 + 1];
		b2 = this.byteArray2[2 + 1];
		if (b != b2)
		{
			return b > b2;
		}
		1++;
		2++;
		b = this.byteArray2[1 + 1];
		b2 = this.byteArray2[2 + 1];
		if (b != b2)
		{
			return b > b2;
		}
		1++;
		2++;
		b = this.byteArray2[1 + 1];
		b2 = this.byteArray2[2 + 1];
		if (b != b2)
		{
			return b > b2;
		}
		1++;
		2++;
		int num = this.number7 + 1;
		int num2;
		int num3;
		for (;;)
		{
			b = this.byteArray2[1 + 1];
			b2 = this.byteArray2[2 + 1];
			if (b != b2)
			{
				break;
			}
			num2 = this.numberArray3[1];
			num3 = this.numberArray3[2];
			if (num2 != num3)
			{
				goto Block_8;
			}
			1++;
			2++;
			b = this.byteArray2[1 + 1];
			b2 = this.byteArray2[2 + 1];
			if (b != b2)
			{
				goto Block_9;
			}
			num2 = this.numberArray3[1];
			num3 = this.numberArray3[2];
			if (num2 != num3)
			{
				goto Block_10;
			}
			1++;
			2++;
			b = this.byteArray2[1 + 1];
			b2 = this.byteArray2[2 + 1];
			if (b != b2)
			{
				goto Block_11;
			}
			num2 = this.numberArray3[1];
			num3 = this.numberArray3[2];
			if (num2 != num3)
			{
				goto Block_12;
			}
			1++;
			2++;
			b = this.byteArray2[1 + 1];
			b2 = this.byteArray2[2 + 1];
			if (b != b2)
			{
				goto Block_13;
			}
			num2 = this.numberArray3[1];
			num3 = this.numberArray3[2];
			if (num2 != num3)
			{
				goto Block_14;
			}
			1++;
			2++;
			if (1 > this.number7)
			{
				1 -= this.number7;
				1--;
			}
			if (2 > this.number7)
			{
				2 -= this.number7;
				2--;
			}
			num -= 4;
			this.number16++;
			if (num < 0)
			{
				return false;
			}
		}
		return b > b2;
		Block_8:
		return num2 > num3;
		Block_9:
		return b > b2;
		Block_10:
		return num2 > num3;
		Block_11:
		return b > b2;
		Block_12:
		return num2 > num3;
		Block_13:
		return b > b2;
		Block_14:
		return num2 > num3;
	}

	// Token: 0x060017C8 RID: 6088 RVA: 0x0005339C File Offset: 0x0005159C
	private void Method11051()
	{
		int num = 100000 * this.number9;
		this.byteArray2 = new byte[num + 1 + 20];
		this.numberArray3 = new int[num + 20];
		this.numberArray4 = new int[num];
		this.numberArray5 = new int[65537];
		this.int16Array = new short[2 * num];
	}

	// Token: 0x060017C9 RID: 6089 RVA: 0x00053400 File Offset: 0x00051600
	private void Method11052()
	{
		char[] array = new char[256];
		this.Method11030();
		int num = this.number13 + 1;
		for (int i = 0; i <= num; i++)
		{
			this.numberArray6[i] = 0;
		}
		int num2 = 0;
		int num3 = 0;
		for (int j = 0; j < this.number13; j++)
		{
			array[j] = (char)j;
		}
		for (int k = 0; k <= this.number7; k++)
		{
			char c = this.charArray3[(int)this.byteArray2[this.numberArray4[k]]];
			int num4 = 0;
			char c2 = array[num4];
			while (c != c2)
			{
				num4++;
				char c3 = c2;
				c2 = array[num4];
				array[num4] = c3;
			}
			array[0] = c2;
			if (num4 == 0)
			{
				num3++;
			}
			else
			{
				if (num3 > 0)
				{
					num3--;
					for (;;)
					{
						int num5 = num3 % 2;
						if (num5 != 0)
						{
							if (num5 == 1)
							{
								this.int16Array[num2] = 1;
								num2++;
								this.numberArray6[1]++;
							}
						}
						else
						{
							this.int16Array[num2] = 0;
							num2++;
							this.numberArray6[0]++;
						}
						if (num3 < 2)
						{
							break;
						}
						num3 = (num3 - 2) / 2;
					}
					num3 = 0;
				}
				this.int16Array[num2] = (short)(num4 + 1);
				num2++;
				this.numberArray6[num4 + 1]++;
			}
		}
		if (num3 > 0)
		{
			num3--;
			for (;;)
			{
				int num5 = num3 % 2;
				if (num5 != 0)
				{
					if (num5 == 1)
					{
						this.int16Array[num2] = 1;
						num2++;
						this.numberArray6[1]++;
					}
				}
				else
				{
					this.int16Array[num2] = 0;
					num2++;
					this.numberArray6[0]++;
				}
				if (num3 < 2)
				{
					break;
				}
				num3 = (num3 - 2) / 2;
			}
		}
		this.int16Array[num2] = (short)num;
		num2++;
		this.numberArray6[num]++;
		this.number14 = num2;
	}

	// Token: 0x060017CA RID: 6090 RVA: 0x000535DF File Offset: 0x000517DF
	private static void Method11053()
	{
		throw new 677("BZip2 output stream panic");
	}

	// Token: 0x060017CB RID: 6091 RVA: 0x000535EC File Offset: 0x000517EC
	private static void Method11054(char[] 1, int[] 2, int 3, int 4)
	{
		int[] array = new int[260];
		int[] array2 = new int[516];
		int[] array3 = new int[516];
		for (int i = 0; i < 3; i++)
		{
			array2[i + 1] = ((2[i] == 0) ? 1 : 2[i]) << 8;
		}
		for (;;)
		{
			int num = 3;
			int j = 0;
			array[0] = 0;
			array2[0] = 0;
			array3[0] = -2;
			for (int k = 1; k <= 3; k++)
			{
				array3[k] = -1;
				j++;
				array[j] = k;
				int num2 = j;
				int num3 = array[num2];
				while (array2[num3] < array2[array[num2 >> 1]])
				{
					array[num2] = array[num2 >> 1];
					num2 >>= 1;
				}
				array[num2] = num3;
			}
			if (j >= 260)
			{
				714.Method11053();
			}
			while (j > 1)
			{
				int num4 = array[1];
				array[1] = array[j];
				j--;
				int num5 = 1;
				int num6 = array[num5];
				for (;;)
				{
					int num7 = num5 << 1;
					if (num7 > j)
					{
						break;
					}
					if (num7 < j && array2[array[num7 + 1]] < array2[array[num7]])
					{
						num7++;
					}
					if (array2[num6] < array2[array[num7]])
					{
						break;
					}
					array[num5] = array[num7];
					num5 = num7;
				}
				array[num5] = num6;
				int num8 = array[1];
				array[1] = array[j];
				j--;
				num5 = 1;
				num6 = array[num5];
				for (;;)
				{
					int num7 = num5 << 1;
					if (num7 > j)
					{
						break;
					}
					if (num7 < j && array2[array[num7 + 1]] < array2[array[num7]])
					{
						num7++;
					}
					if (array2[num6] < array2[array[num7]])
					{
						break;
					}
					array[num5] = array[num7];
					num5 = num7;
				}
				array[num5] = num6;
				num++;
				array3[num4] = (array3[num8] = num);
				array2[num] = ((int)(((long)array2[num4] & (long)((ulong)-256)) + ((long)array2[num8] & (long)((ulong)-256))) | 1 + (((array2[num4] & 255) > (array2[num8] & 255)) ? (array2[num4] & 255) : (array2[num8] & 255)));
				array3[num] = -1;
				j++;
				array[j] = num;
				num5 = j;
				num6 = array[num5];
				while (array2[num6] < array2[array[num5 >> 1]])
				{
					array[num5] = array[num5 >> 1];
					num5 >>= 1;
				}
				array[num5] = num6;
			}
			if (num >= 516)
			{
				714.Method11053();
			}
			bool flag = false;
			for (int l = 1; l <= 3; l++)
			{
				int num9 = 0;
				int num10 = l;
				while (array3[num10] >= 0)
				{
					num10 = array3[num10];
					num9++;
				}
				1[l - 1] = (char)num9;
				if (num9 > 4)
				{
					flag = true;
				}
			}
			if (!flag)
			{
				break;
			}
			for (int m = 1; m < 3; m++)
			{
				int num11 = array2[m] >> 8;
				num11 = 1 + num11 / 2;
				array2[m] = num11 << 8;
			}
		}
	}

	// Token: 0x060017CC RID: 6092 RVA: 0x000538A8 File Offset: 0x00051AA8
	private static void Method11055(int[] 1, char[] 2, int 3, int 4, int 5)
	{
		int num = 0;
		for (int i = 3; i <= 4; i++)
		{
			for (int j = 0; j < 5; j++)
			{
				if ((int)2[j] == i)
				{
					1[j] = num;
					num++;
				}
			}
			num <<= 1;
		}
	}

	// Token: 0x060017CD RID: 6093 RVA: 0x000538E2 File Offset: 0x00051AE2
	private static byte Method11056(byte 1, byte 2, byte 3)
	{
		if (1 > 2)
		{
			byte b = 1;
			1 = 2;
			2 = b;
		}
		if (2 > 3)
		{
			byte b2 = 2;
			2 = 3;
			3 = b2;
		}
		if (1 > 2)
		{
			2 = 1;
		}
		return 2;
	}

	// Token: 0x04000AFB RID: 2811
	private readonly int[] numberArray2 = new int[]
	{
		1,
		4,
		13,
		40,
		121,
		364,
		1093,
		3280,
		9841,
		29524,
		88573,
		265720,
		797161,
		2391484
	};

	// Token: 0x04000AFC RID: 2812
	private bool flag2 = true;

	// Token: 0x04000AFD RID: 2813
	private int number7;

	// Token: 0x04000AFE RID: 2814
	private int number8;

	// Token: 0x04000AFF RID: 2815
	private int number9;

	// Token: 0x04000B00 RID: 2816
	private bool flag3;

	// Token: 0x04000B01 RID: 2817
	private int number10;

	// Token: 0x04000B02 RID: 2818
	private int number11;

	// Token: 0x04000B03 RID: 2819
	private int number12;

	// Token: 0x04000B04 RID: 2820
	private 656 _recoveredType17158731 = new 923();

	// Token: 0x04000B05 RID: 2821
	private bool[] flagArray = new bool[256];

	// Token: 0x04000B06 RID: 2822
	private int number13;

	// Token: 0x04000B07 RID: 2823
	private char[] charArray2 = new char[256];

	// Token: 0x04000B08 RID: 2824
	private char[] charArray3 = new char[256];

	// Token: 0x04000B09 RID: 2825
	private char[] charArray4 = new char[18002];

	// Token: 0x04000B0A RID: 2826
	private char[] charArray5 = new char[18002];

	// Token: 0x04000B0B RID: 2827
	private byte[] byteArray2;

	// Token: 0x04000B0C RID: 2828
	private int[] numberArray3;

	// Token: 0x04000B0D RID: 2829
	private int[] numberArray4;

	// Token: 0x04000B0E RID: 2830
	private short[] int16Array;

	// Token: 0x04000B0F RID: 2831
	private int[] numberArray5;

	// Token: 0x04000B10 RID: 2832
	private int number14;

	// Token: 0x04000B11 RID: 2833
	private int[] numberArray6 = new int[258];

	// Token: 0x04000B12 RID: 2834
	private int number15;

	// Token: 0x04000B13 RID: 2835
	private int number16;

	// Token: 0x04000B14 RID: 2836
	private int number17;

	// Token: 0x04000B15 RID: 2837
	private bool flag4;

	// Token: 0x04000B16 RID: 2838
	private int number18;

	// Token: 0x04000B17 RID: 2839
	private int number19 = -1;

	// Token: 0x04000B18 RID: 2840
	private int number20;

	// Token: 0x04000B19 RID: 2841
	private uint number21;

	// Token: 0x04000B1A RID: 2842
	private uint number22;

	// Token: 0x04000B1B RID: 2843
	private int number23;

	// Token: 0x04000B1C RID: 2844
	private Stream stream2;

	// Token: 0x04000B1D RID: 2845
	private bool flag5;

	// Token: 0x02000315 RID: 789
	public struct 715
	{
		// Token: 0x04000B1E RID: 2846
		public int number;

		// Token: 0x04000B1F RID: 2847
		public int number2;

		// Token: 0x04000B20 RID: 2848
		public int number3;
	}
}
