using System;
using System.IO;
using System.Runtime.InteropServices;

// Token: 0x020002F8 RID: 760
[ComVisible(false)]
public sealed class 537 : Stream
{
	// Token: 0x170000FA RID: 250
	// (get) Token: 0x060016B5 RID: 5813 RVA: 0x0004E2ED File Offset: 0x0004C4ED
	public override bool CanRead
	{
		get
		{
			return this.stream2.CanRead;
		}
	}

	// Token: 0x170000FB RID: 251
	// (get) Token: 0x060016B6 RID: 5814 RVA: 0x0004E2FA File Offset: 0x0004C4FA
	public override bool CanSeek
	{
		get
		{
			return this.stream2.CanSeek;
		}
	}

	// Token: 0x170000FC RID: 252
	// (get) Token: 0x060016B7 RID: 5815 RVA: 0x0000FF75 File Offset: 0x0000E175
	public override bool CanWrite
	{
		get
		{
			return false;
		}
	}

	// Token: 0x170000FD RID: 253
	// (get) Token: 0x060016B8 RID: 5816 RVA: 0x0004E307 File Offset: 0x0004C507
	public override long Length
	{
		get
		{
			return this.stream2.Length;
		}
	}

	// Token: 0x170000FE RID: 254
	// (get) Token: 0x060016B9 RID: 5817 RVA: 0x0004E314 File Offset: 0x0004C514
	// (set) Token: 0x060016BA RID: 5818 RVA: 0x0004E321 File Offset: 0x0004C521
	public override long Position
	{
		get
		{
			return this.stream2.Position;
		}
		set
		{
			throw new NotSupportedException("BZip2InputStream position cannot be set");
		}
	}

	// Token: 0x060016BB RID: 5819 RVA: 0x0004E330 File Offset: 0x0004C530
	public 537(Stream 1)
	{
		for (int i = 0; i < 6; i++)
		{
			this.numberArrayArray[i] = new int[258];
			this.numberArrayArray2[i] = new int[258];
			this.numberArrayArray3[i] = new int[258];
		}
		this.Method6768(1);
		this.Method6764();
		this.Method6765();
		this.Method6776();
	}

	// Token: 0x060016BC RID: 5820 RVA: 0x0004E44E File Offset: 0x0004C64E
	public bool _0003_2006_2008_2002_2005_200B_2009_2003_2000_2004_2002()
	{
		return this.flag4;
	}

	// Token: 0x060016BD RID: 5821 RVA: 0x0004E456 File Offset: 0x0004C656
	public void _0002_2007_2005_2001_2003_200B_2000_2008_2000_2009_2005_2000_200A_200B(bool 1)
	{
		this.flag4 = 1;
	}

	// Token: 0x060016BE RID: 5822 RVA: 0x0004E45F File Offset: 0x0004C65F
	public override void Flush()
	{
		if (this.stream2 != null)
		{
			this.stream2.Flush();
		}
	}

	// Token: 0x060016BF RID: 5823 RVA: 0x0004E474 File Offset: 0x0004C674
	public override long Seek(long 1, SeekOrigin 2)
	{
		throw new NotSupportedException("BZip2InputStream Seek not supported");
	}

	// Token: 0x060016C0 RID: 5824 RVA: 0x0004E480 File Offset: 0x0004C680
	public override void SetLength(long 1)
	{
		throw new NotSupportedException("BZip2InputStream SetLength not supported");
	}

	// Token: 0x060016C1 RID: 5825 RVA: 0x0004E48C File Offset: 0x0004C68C
	public override void Write(byte[] 1, int 2, int 3)
	{
		throw new NotSupportedException("BZip2InputStream Write not supported");
	}

	// Token: 0x060016C2 RID: 5826 RVA: 0x0004E498 File Offset: 0x0004C698
	public override void WriteByte(byte 1)
	{
		throw new NotSupportedException("BZip2InputStream WriteByte not supported");
	}

	// Token: 0x060016C3 RID: 5827 RVA: 0x0004E4A4 File Offset: 0x0004C6A4
	public override int Read(byte[] 1, int 2, int 3)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=zpMJwVYM=");
		}
		for (int i = 0; i < 3; i++)
		{
			int num = this.ReadByte();
			if (num == -1)
			{
				return i;
			}
			1[2 + i] = (byte)num;
		}
		return 3;
	}

	// Token: 0x060016C4 RID: 5828 RVA: 0x0004E4E0 File Offset: 0x0004C6E0
	public override void Close()
	{
		if (this._0003_2006_2008_2002_2005_200B_2009_2003_2000_2004_2002() && this.stream2 != null)
		{
			this.stream2.Close();
		}
	}

	// Token: 0x060016C5 RID: 5829 RVA: 0x0004E500 File Offset: 0x0004C700
	public override int ReadByte()
	{
		if (this.flag3)
		{
			return -1;
		}
		int result = this.number10;
		switch (this.number11)
		{
		case 3:
			this.Method6779();
			break;
		case 4:
			this.Method6780();
			break;
		case 6:
			this.Method6781();
			break;
		case 7:
			this.Method6782();
			break;
		}
		return result;
	}

	// Token: 0x060016C6 RID: 5830 RVA: 0x0004E564 File Offset: 0x0004C764
	private void Method6763()
	{
		this.number9 = 0;
		for (int i = 0; i < 256; i++)
		{
			if (this.flagArray[i])
			{
				this.byteArray2[this.number9] = (byte)i;
				this.byteArray3[i] = (byte)this.number9;
				this.number9++;
			}
		}
	}

	// Token: 0x060016C7 RID: 5831 RVA: 0x0004E5C0 File Offset: 0x0004C7C0
	private void Method6764()
	{
		int num = (int)this.Method6771();
		char c = this.Method6771();
		char c2 = this.Method6771();
		char c3 = this.Method6771();
		if (num != 66 || c != 'Z' || c2 != 'h' || c3 < '1' || c3 > '9')
		{
			this.flag3 = true;
			return;
		}
		this.Method6783((int)(c3 - '0'));
		this.number15 = 0U;
	}

	// Token: 0x060016C8 RID: 5832 RVA: 0x0004E61C File Offset: 0x0004C81C
	private void Method6765()
	{
		char c = this.Method6771();
		char c2 = this.Method6771();
		char c3 = this.Method6771();
		char c4 = this.Method6771();
		char c5 = this.Method6771();
		char c6 = this.Method6771();
		if (c == '\u0017' && c2 == 'r' && c3 == 'E' && c4 == '8' && c5 == 'P' && c6 == '\u0090')
		{
			this.Method6767();
			return;
		}
		if (c != '1' || c2 != 'A' || c3 != 'Y' || c4 != '&' || c5 != 'S' || c6 != 'Y')
		{
			537.Method6786();
			this.flag3 = true;
			return;
		}
		this.number12 = this.Method6773();
		this.flag2 = (this.Method6770(1) == 1);
		this.Method6775();
		this._recoveredType17155360.SetNumber7041_9090();
		this.number11 = 1;
	}

	// Token: 0x060016C9 RID: 5833 RVA: 0x0004E6E0 File Offset: 0x0004C8E0
	private void Method6766()
	{
		this.number14 = (int)this._recoveredType17155360.GetNumber7041_9089();
		if (this.number12 != this.number14)
		{
			537.Method6787();
		}
		this.number15 = ((this.number15 << 1 & uint.MaxValue) | this.number15 >> 31);
		this.number15 ^= (uint)this.number14;
	}

	// Token: 0x060016CA RID: 5834 RVA: 0x0004E73F File Offset: 0x0004C93F
	private void Method6767()
	{
		this.number13 = this.Method6773();
		if (this.number13 != (int)this.number15)
		{
			537.Method6787();
		}
		this.flag3 = true;
	}

	// Token: 0x060016CB RID: 5835 RVA: 0x0004E767 File Offset: 0x0004C967
	private void Method6768(Stream 1)
	{
		this.stream2 = 1;
		this.number8 = 0;
		this.number7 = 0;
	}

	// Token: 0x060016CC RID: 5836 RVA: 0x0004E780 File Offset: 0x0004C980
	private void Method6769()
	{
		int num = 0;
		try
		{
			num = this.stream2.ReadByte();
		}
		catch (Exception)
		{
			537.Method6784();
		}
		if (num == -1)
		{
			537.Method6784();
		}
		this.number7 = (this.number7 << 8 | (num & 255));
		this.number8 += 8;
	}

	// Token: 0x060016CD RID: 5837 RVA: 0x0004E7E4 File Offset: 0x0004C9E4
	private int Method6770(int 1)
	{
		while (this.number8 < 1)
		{
			this.Method6769();
		}
		int result = this.number7 >> this.number8 - 1 & (1 << 1) - 1;
		this.number8 -= 1;
		return result;
	}

	// Token: 0x060016CE RID: 5838 RVA: 0x0004E820 File Offset: 0x0004CA20
	private char Method6771()
	{
		return (char)this.Method6770(8);
	}

	// Token: 0x060016CF RID: 5839 RVA: 0x0004E82A File Offset: 0x0004CA2A
	private int Method6772(int 1)
	{
		return this.Method6770(1);
	}

	// Token: 0x060016D0 RID: 5840 RVA: 0x0004E833 File Offset: 0x0004CA33
	private int Method6773()
	{
		return ((this.Method6770(8) << 8 | this.Method6770(8)) << 8 | this.Method6770(8)) << 8 | this.Method6770(8);
	}

	// Token: 0x060016D1 RID: 5841 RVA: 0x0004E85C File Offset: 0x0004CA5C
	private void Method6774()
	{
		char[][] array = new char[6][];
		for (int i = 0; i < 6; i++)
		{
			array[i] = new char[258];
		}
		bool[] array2 = new bool[16];
		for (int j = 0; j < 16; j++)
		{
			array2[j] = (this.Method6770(1) == 1);
		}
		for (int k = 0; k < 16; k++)
		{
			if (array2[k])
			{
				for (int l = 0; l < 16; l++)
				{
					this.flagArray[k * 16 + l] = (this.Method6770(1) == 1);
				}
			}
			else
			{
				for (int m = 0; m < 16; m++)
				{
					this.flagArray[k * 16 + m] = false;
				}
			}
		}
		this.Method6763();
		int num = this.number9 + 2;
		int num2 = this.Method6770(3);
		int num3 = this.Method6770(15);
		for (int n = 0; n < num3; n++)
		{
			int num4 = 0;
			while (this.Method6770(1) == 1)
			{
				num4++;
			}
			this.byteArray5[n] = (byte)num4;
		}
		byte[] array3 = new byte[6];
		for (int num5 = 0; num5 < num2; num5++)
		{
			array3[num5] = (byte)num5;
		}
		for (int num6 = 0; num6 < num3; num6++)
		{
			int num7 = (int)this.byteArray5[num6];
			byte b = array3[num7];
			while (num7 > 0)
			{
				array3[num7] = array3[num7 - 1];
				num7--;
			}
			array3[0] = b;
			this.byteArray4[num6] = b;
		}
		for (int num8 = 0; num8 < num2; num8++)
		{
			int num9 = this.Method6770(5);
			for (int num10 = 0; num10 < num; num10++)
			{
				while (this.Method6770(1) == 1)
				{
					num9 = ((this.Method6770(1) != 0) ? (num9 - 1) : (num9 + 1));
				}
				array[num8][num10] = (char)num9;
			}
		}
		for (int num11 = 0; num11 < num2; num11++)
		{
			int num12 = 32;
			int num13 = 0;
			for (int num14 = 0; num14 < num; num14++)
			{
				num13 = Math.Max(num13, (int)array[num11][num14]);
				num12 = Math.Min(num12, (int)array[num11][num14]);
			}
			537.Method6788(this.numberArrayArray[num11], this.numberArrayArray2[num11], this.numberArrayArray3[num11], array[num11], num12, num13, num);
			this.numberArray6[num11] = num12;
		}
	}

	// Token: 0x060016D2 RID: 5842 RVA: 0x0004EAA8 File Offset: 0x0004CCA8
	private void Method6775()
	{
		byte[] array = new byte[256];
		int num = 100000 * this.number6;
		this.number5 = this.Method6772(24);
		this.Method6774();
		int num2 = this.number9 + 1;
		int num3 = -1;
		int num4 = 0;
		for (int i = 0; i <= 255; i++)
		{
			this.numberArray5[i] = 0;
		}
		for (int j = 0; j <= 255; j++)
		{
			array[j] = (byte)j;
		}
		this.number4 = -1;
		if (num4 == 0)
		{
			num3++;
			num4 = 50;
		}
		num4--;
		int num5 = (int)this.byteArray4[num3];
		int num6 = this.numberArray6[num5];
		int k;
		int num7;
		for (k = this.Method6770(num6); k > this.numberArrayArray[num5][num6]; k = (k << 1 | num7))
		{
			if (num6 > 20)
			{
				throw new 677("Bzip data error");
			}
			num6++;
			while (this.number8 < 1)
			{
				this.Method6769();
			}
			num7 = (this.number7 >> this.number8 - 1 & 1);
			this.number8--;
		}
		if (k - this.numberArrayArray2[num5][num6] < 0 || k - this.numberArrayArray2[num5][num6] >= 258)
		{
			throw new 677("Bzip data error");
		}
		int num8 = this.numberArrayArray3[num5][k - this.numberArrayArray2[num5][num6]];
		while (num8 != num2)
		{
			if (num8 == 0 || num8 == 1)
			{
				int l = -1;
				int num9 = 1;
				do
				{
					if (num8 != 0)
					{
						if (num8 == 1)
						{
							l += 2 * num9;
						}
					}
					else
					{
						l += num9;
					}
					num9 <<= 1;
					if (num4 == 0)
					{
						num3++;
						num4 = 50;
					}
					num4--;
					num5 = (int)this.byteArray4[num3];
					num6 = this.numberArray6[num5];
					int num10;
					for (k = this.Method6770(num6); k > this.numberArrayArray[num5][num6]; k = (k << 1 | num10))
					{
						num6++;
						while (this.number8 < 1)
						{
							this.Method6769();
						}
						num10 = (this.number7 >> this.number8 - 1 & 1);
						this.number8--;
					}
					num8 = this.numberArrayArray3[num5][k - this.numberArrayArray2[num5][num6]];
				}
				while (num8 == 0 || num8 == 1);
				l++;
				byte b = this.byteArray2[(int)array[0]];
				this.numberArray5[(int)b] += l;
				while (l > 0)
				{
					this.number4++;
					this.byteArray6[this.number4] = b;
					l--;
				}
				if (this.number4 >= num)
				{
					537.Method6785();
				}
			}
			else
			{
				this.number4++;
				if (this.number4 >= num)
				{
					537.Method6785();
				}
				byte b2 = array[num8 - 1];
				this.numberArray5[(int)this.byteArray2[(int)b2]]++;
				this.byteArray6[this.number4] = this.byteArray2[(int)b2];
				for (int m = num8 - 1; m > 0; m--)
				{
					array[m] = array[m - 1];
				}
				array[0] = b2;
				if (num4 == 0)
				{
					num3++;
					num4 = 50;
				}
				num4--;
				num5 = (int)this.byteArray4[num3];
				num6 = this.numberArray6[num5];
				int num11;
				for (k = this.Method6770(num6); k > this.numberArrayArray[num5][num6]; k = (k << 1 | num11))
				{
					num6++;
					while (this.number8 < 1)
					{
						this.Method6769();
					}
					num11 = (this.number7 >> this.number8 - 1 & 1);
					this.number8--;
				}
				num8 = this.numberArrayArray3[num5][k - this.numberArrayArray2[num5][num6]];
			}
		}
	}

	// Token: 0x060016D3 RID: 5843 RVA: 0x0004EE84 File Offset: 0x0004D084
	private void Method6776()
	{
		int[] array = new int[257];
		array[0] = 0;
		Array.Copy(this.numberArray5, 0, array, 1, 256);
		for (int i = 1; i <= 256; i++)
		{
			array[i] += array[i - 1];
		}
		for (int j = 0; j <= this.number4; j++)
		{
			byte b = this.byteArray6[j];
			this.numberArray4[array[(int)b]] = j;
			array[(int)b]++;
		}
		this.number19 = this.numberArray4[this.number5];
		this.number16 = 0;
		this.number22 = 0;
		this.number18 = 256;
		if (this.flag2)
		{
			this.number20 = 0;
			this.number21 = 0;
			this.Method6777();
			return;
		}
		this.Method6778();
	}

	// Token: 0x060016D4 RID: 5844 RVA: 0x0004EF58 File Offset: 0x0004D158
	private void Method6777()
	{
		if (this.number22 <= this.number4)
		{
			this.number17 = this.number18;
			this.number18 = (int)this.byteArray6[this.number19];
			this.number19 = this.numberArray4[this.number19];
			if (this.number20 == 0)
			{
				this.number20 = 757.numberArray[this.number21];
				this.number21++;
				if (this.number21 == 512)
				{
					this.number21 = 0;
				}
			}
			this.number20--;
			this.number18 ^= ((this.number20 == 1) ? 1 : 0);
			this.number22++;
			this.number10 = this.number18;
			this.number11 = 3;
			this._recoveredType17155360.Method90912(this.number18);
			return;
		}
		this.Method6766();
		this.Method6765();
		this.Method6776();
	}

	// Token: 0x060016D5 RID: 5845 RVA: 0x0004F050 File Offset: 0x0004D250
	private void Method6778()
	{
		if (this.number22 <= this.number4)
		{
			this.number17 = this.number18;
			this.number18 = (int)this.byteArray6[this.number19];
			this.number19 = this.numberArray4[this.number19];
			this.number22++;
			this.number10 = this.number18;
			this.number11 = 6;
			this._recoveredType17155360.Method90912(this.number18);
			return;
		}
		this.Method6766();
		this.Method6765();
		this.Method6776();
	}

	// Token: 0x060016D6 RID: 5846 RVA: 0x0004F0E4 File Offset: 0x0004D2E4
	private void Method6779()
	{
		if (this.number18 != this.number17)
		{
			this.number11 = 2;
			this.number16 = 1;
			this.Method6777();
			return;
		}
		this.number16++;
		if (this.number16 >= 4)
		{
			this.byteValue2 = this.byteArray6[this.number19];
			this.number19 = this.numberArray4[this.number19];
			if (this.number20 == 0)
			{
				this.number20 = 757.numberArray[this.number21];
				this.number21++;
				if (this.number21 == 512)
				{
					this.number21 = 0;
				}
			}
			this.number20--;
			this.byteValue2 ^= ((this.number20 == 1) ? 1 : 0);
			this.number23 = 0;
			this.number11 = 4;
			this.Method6780();
			return;
		}
		this.number11 = 2;
		this.Method6777();
	}

	// Token: 0x060016D7 RID: 5847 RVA: 0x0004F1D8 File Offset: 0x0004D3D8
	private void Method6780()
	{
		if (this.number23 < (int)this.byteValue2)
		{
			this.number10 = this.number18;
			this._recoveredType17155360.Method90912(this.number18);
			this.number23++;
			return;
		}
		this.number11 = 2;
		this.number22++;
		this.number16 = 0;
		this.Method6777();
	}

	// Token: 0x060016D8 RID: 5848 RVA: 0x0004F244 File Offset: 0x0004D444
	private void Method6781()
	{
		if (this.number18 != this.number17)
		{
			this.number11 = 5;
			this.number16 = 1;
			this.Method6778();
			return;
		}
		this.number16++;
		if (this.number16 >= 4)
		{
			this.byteValue2 = this.byteArray6[this.number19];
			this.number19 = this.numberArray4[this.number19];
			this.number11 = 7;
			this.number23 = 0;
			this.Method6782();
			return;
		}
		this.number11 = 5;
		this.Method6778();
	}

	// Token: 0x060016D9 RID: 5849 RVA: 0x0004F2D4 File Offset: 0x0004D4D4
	private void Method6782()
	{
		if (this.number23 < (int)this.byteValue2)
		{
			this.number10 = this.number18;
			this._recoveredType17155360.Method90912(this.number18);
			this.number23++;
			return;
		}
		this.number11 = 5;
		this.number22++;
		this.number16 = 0;
		this.Method6778();
	}

	// Token: 0x060016DA RID: 5850 RVA: 0x0004F340 File Offset: 0x0004D540
	private void Method6783(int 1)
	{
		if (0 > 1 || 1 > 9 || 0 > this.number6 || this.number6 > 9)
		{
			throw new 677("Invalid block size");
		}
		this.number6 = 1;
		if (1 != 0)
		{
			int num = 100000 * 1;
			this.byteArray6 = new byte[num];
			this.numberArray4 = new int[num];
		}
	}

	// Token: 0x060016DB RID: 5851 RVA: 0x0004F39E File Offset: 0x0004D59E
	private static void Method6784()
	{
		throw new EndOfStreamException("BZip2 input stream end of compressed stream");
	}

	// Token: 0x060016DC RID: 5852 RVA: 0x0004F3AA File Offset: 0x0004D5AA
	private static void Method6785()
	{
		throw new 677("BZip2 input stream block overrun");
	}

	// Token: 0x060016DD RID: 5853 RVA: 0x0004F3B6 File Offset: 0x0004D5B6
	private static void Method6786()
	{
		throw new 677("BZip2 input stream bad block header");
	}

	// Token: 0x060016DE RID: 5854 RVA: 0x0004F3C2 File Offset: 0x0004D5C2
	private static void Method6787()
	{
		throw new 677("BZip2 input stream crc error");
	}

	// Token: 0x060016DF RID: 5855 RVA: 0x0004F3D0 File Offset: 0x0004D5D0
	private static void Method6788(int[] 1, int[] 2, int[] 3, char[] 4, int 5, int 6, int 7)
	{
		int num = 0;
		for (int i = 5; i <= 6; i++)
		{
			for (int j = 0; j < 7; j++)
			{
				if ((int)4[j] == i)
				{
					3[num] = j;
					num++;
				}
			}
		}
		for (int k = 0; k < 23; k++)
		{
			2[k] = 0;
		}
		for (int l = 0; l < 7; l++)
		{
			2[(int)(4[l] + '\u0001')]++;
		}
		for (int m = 1; m < 23; m++)
		{
			2[m] += 2[m - 1];
		}
		for (int n = 0; n < 23; n++)
		{
			1[n] = 0;
		}
		int num2 = 0;
		for (int num3 = 5; num3 <= 6; num3++)
		{
			num2 += 2[num3 + 1] - 2[num3];
			1[num3] = num2 - 1;
			num2 <<= 1;
		}
		for (int num4 = 5 + 1; num4 <= 6; num4++)
		{
			2[num4] = (1[num4 - 1] + 1 << 1) - 2[num4];
		}
	}

	// Token: 0x04000AA7 RID: 2727
	private int number4;

	// Token: 0x04000AA8 RID: 2728
	private int number5;

	// Token: 0x04000AA9 RID: 2729
	private int number6;

	// Token: 0x04000AAA RID: 2730
	private bool flag2;

	// Token: 0x04000AAB RID: 2731
	private int number7;

	// Token: 0x04000AAC RID: 2732
	private int number8;

	// Token: 0x04000AAD RID: 2733
	private 656 _recoveredType17155360 = new 923();

	// Token: 0x04000AAE RID: 2734
	private bool[] flagArray = new bool[256];

	// Token: 0x04000AAF RID: 2735
	private int number9;

	// Token: 0x04000AB0 RID: 2736
	private byte[] byteArray2 = new byte[256];

	// Token: 0x04000AB1 RID: 2737
	private byte[] byteArray3 = new byte[256];

	// Token: 0x04000AB2 RID: 2738
	private byte[] byteArray4 = new byte[18002];

	// Token: 0x04000AB3 RID: 2739
	private byte[] byteArray5 = new byte[18002];

	// Token: 0x04000AB4 RID: 2740
	private int[] numberArray4;

	// Token: 0x04000AB5 RID: 2741
	private byte[] byteArray6;

	// Token: 0x04000AB6 RID: 2742
	private int[] numberArray5 = new int[256];

	// Token: 0x04000AB7 RID: 2743
	private int[][] numberArrayArray = new int[6][];

	// Token: 0x04000AB8 RID: 2744
	private int[][] numberArrayArray2 = new int[6][];

	// Token: 0x04000AB9 RID: 2745
	private int[][] numberArrayArray3 = new int[6][];

	// Token: 0x04000ABA RID: 2746
	private int[] numberArray6 = new int[6];

	// Token: 0x04000ABB RID: 2747
	private Stream stream2;

	// Token: 0x04000ABC RID: 2748
	private bool flag3;

	// Token: 0x04000ABD RID: 2749
	private int number10 = -1;

	// Token: 0x04000ABE RID: 2750
	private int number11 = 1;

	// Token: 0x04000ABF RID: 2751
	private int number12;

	// Token: 0x04000AC0 RID: 2752
	private int number13;

	// Token: 0x04000AC1 RID: 2753
	private int number14;

	// Token: 0x04000AC2 RID: 2754
	private uint number15;

	// Token: 0x04000AC3 RID: 2755
	private int number16;

	// Token: 0x04000AC4 RID: 2756
	private int number17;

	// Token: 0x04000AC5 RID: 2757
	private int number18;

	// Token: 0x04000AC6 RID: 2758
	private int number19;

	// Token: 0x04000AC7 RID: 2759
	private int number20;

	// Token: 0x04000AC8 RID: 2760
	private int number21;

	// Token: 0x04000AC9 RID: 2761
	private int number22;

	// Token: 0x04000ACA RID: 2762
	private int number23;

	// Token: 0x04000ACB RID: 2763
	private byte byteValue2;

	// Token: 0x04000ACC RID: 2764
	private bool flag4 = true;
}
