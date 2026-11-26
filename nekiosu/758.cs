using System;
using System.IO;
using System.Runtime.InteropServices;

// Token: 0x0200031B RID: 795
[ComVisible(false)]
public sealed class 758 : IDisposable
{
	// Token: 0x060017E1 RID: 6113 RVA: 0x00053D12 File Offset: 0x00051F12
	public 758()
	{
		this.Method12218();
	}

	// Token: 0x060017E2 RID: 6114 RVA: 0x00053D20 File Offset: 0x00051F20
	public 758(byte[] 1)
	{
		if (1 == null)
		{
			this.byteArray2 = new byte[0];
			return;
		}
		this.byteArray2 = 1;
	}

	// Token: 0x060017E3 RID: 6115 RVA: 0x00053D3F File Offset: 0x00051F3F
	public byte[] Method12217()
	{
		if (this.Method12219() > 65535)
		{
			throw new 415("Data exceeds maximum length");
		}
		return (byte[])this.byteArray2.Clone();
	}

	// Token: 0x060017E4 RID: 6116 RVA: 0x00053D69 File Offset: 0x00051F69
	public void Method12218()
	{
		if (this.byteArray2 == null || this.byteArray2.Length != 0)
		{
			this.byteArray2 = new byte[0];
		}
	}

	// Token: 0x060017E5 RID: 6117 RVA: 0x00053D88 File Offset: 0x00051F88
	public int Method12219()
	{
		return this.byteArray2.Length;
	}

	// Token: 0x060017E6 RID: 6118 RVA: 0x00053D94 File Offset: 0x00051F94
	public Stream Method12220(int 1)
	{
		Stream result = null;
		if (this.Method12226(1))
		{
			result = new MemoryStream(this.byteArray2, this.number3, this.number5, false);
		}
		return result;
	}

	// Token: 0x060017E7 RID: 6119 RVA: 0x00053DC8 File Offset: 0x00051FC8
	private 712 Method12221(short 1)
	{
		712 result = null;
		if (this.Method12226((int)1))
		{
			result = 758.Method12222(1, this.byteArray2, this.number4, this.number5);
		}
		return result;
	}

	// Token: 0x060017E8 RID: 6120 RVA: 0x00053DFC File Offset: 0x00051FFC
	private static 712 Method12222(short 1, byte[] 2, int 3, int 4)
	{
		712 5;
		if (1 != 10)
		{
			if (1 != 21589)
			{
				5 = new 771(1);
			}
			else
			{
				5 = new 684();
			}
		}
		else
		{
			5 = new 693();
		}
		712 6 = 5;
		6.Method12599(2, 3, 4);
		return 6;
	}

	// Token: 0x060017E9 RID: 6121 RVA: 0x00053E39 File Offset: 0x00052039
	public int GetNumber9559_12223()
	{
		return this.number5;
	}

	// Token: 0x060017EA RID: 6122 RVA: 0x00053E41 File Offset: 0x00052041
	public int GetNumber9557_12224()
	{
		return this.number3;
	}

	// Token: 0x060017EB RID: 6123 RVA: 0x00053E49 File Offset: 0x00052049
	public int Method12225()
	{
		if (this.number4 > this.byteArray2.Length || this.number4 < 4)
		{
			throw new 415("Find must be called before calling a Read method");
		}
		return this.number4 + this.number5 - this.number3;
	}

	// Token: 0x060017EC RID: 6124 RVA: 0x00053E84 File Offset: 0x00052084
	public bool Method12226(int 1)
	{
		this.number4 = this.byteArray2.Length;
		this.number5 = 0;
		this.number3 = 0;
		int num = this.number4;
		int num2 = 1 - 1;
		while (num2 != 1 && this.number3 < this.byteArray2.Length - 3)
		{
			num2 = this.Method12243();
			num = this.Method12243();
			if (num2 != 1)
			{
				this.number3 += num;
			}
		}
		int num3;
		if (num2 == 1)
		{
			num3 = ((this.number3 + num <= this.byteArray2.Length) ? 1 : 0);
			if (num3 != 0)
			{
				this.number4 = this.number3;
				this.number5 = num;
			}
		}
		else
		{
			num3 = 0;
		}
		return (byte)num3 > 0;
	}

	// Token: 0x060017ED RID: 6125 RVA: 0x00053F29 File Offset: 0x00052129
	public void Method12227(712 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("taggedData");
		}
		this.Method12227((int)1.GetInt169818_12597(), 1.GetByteArray9819_12600());
	}

	// Token: 0x060017EE RID: 6126 RVA: 0x00053F4C File Offset: 0x0005214C
	public void Method12227(int 1, byte[] 2)
	{
		if (1 > 65535 || 1 < 0)
		{
			throw new ArgumentOutOfRangeException("#=z_jDP7DE=");
		}
		int num = (2 != null) ? 2.Length : 0;
		if (num > 65535)
		{
			throw new ArgumentOutOfRangeException("#=zgN2OZ3w=", "exceeds maximum length");
		}
		int num2 = this.byteArray2.Length + num + 4;
		if (this.Method12226(1))
		{
			num2 -= this.GetNumber9559_12223() + 4;
		}
		if (num2 > 65535)
		{
			throw new 415("Data exceeds maximum length");
		}
		this.Method12236(1);
		byte[] array = new byte[num2];
		this.byteArray2.CopyTo(array, 0);
		int index = this.byteArray2.Length;
		this.byteArray2 = array;
		this.Method12244(ref index, 1);
		this.Method12244(ref index, num);
		if (2 != null)
		{
			2.CopyTo(array, index);
		}
	}

	// Token: 0x060017EF RID: 6127 RVA: 0x0005400F File Offset: 0x0005220F
	public void SetMemoryStream9560_12229()
	{
		this.memoryStream = new MemoryStream();
	}

	// Token: 0x060017F0 RID: 6128 RVA: 0x0005401C File Offset: 0x0005221C
	public void Method12230(int 1)
	{
		byte[] 2 = this.memoryStream.ToArray();
		this.memoryStream = null;
		this.Method12227(1, 2);
	}

	// Token: 0x060017F1 RID: 6129 RVA: 0x00054044 File Offset: 0x00052244
	public void Method12231(byte 1)
	{
		this.memoryStream.WriteByte(1);
	}

	// Token: 0x060017F2 RID: 6130 RVA: 0x00054052 File Offset: 0x00052252
	public void Method12231(byte[] 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=z6rP0_lg=");
		}
		this.memoryStream.Write(1, 0, 1.Length);
	}

	// Token: 0x060017F3 RID: 6131 RVA: 0x00054072 File Offset: 0x00052272
	public void Method12233(int 1)
	{
		this.memoryStream.WriteByte((byte)1);
		this.memoryStream.WriteByte((byte)(1 >> 8));
	}

	// Token: 0x060017F4 RID: 6132 RVA: 0x00054090 File Offset: 0x00052290
	public void Method12234(int 1)
	{
		this.Method12233((int)((short)1));
		this.Method12233((int)((short)(1 >> 16)));
	}

	// Token: 0x060017F5 RID: 6133 RVA: 0x000540A5 File Offset: 0x000522A5
	public void Method12235(long 1)
	{
		this.Method12234((int)(1 & (long)((ulong)-1)));
		this.Method12234((int)(1 >> 32));
	}

	// Token: 0x060017F6 RID: 6134 RVA: 0x000540C0 File Offset: 0x000522C0
	public bool Method12236(int 1)
	{
		bool result = false;
		if (this.Method12226(1))
		{
			result = true;
			int num = this.number4 - 4;
			byte[] destinationArray = new byte[this.byteArray2.Length - (this.GetNumber9559_12223() + 4)];
			Array.Copy(this.byteArray2, 0, destinationArray, 0, num);
			int num2 = num + this.GetNumber9559_12223() + 4;
			Array.Copy(this.byteArray2, num2, destinationArray, num, this.byteArray2.Length - num2);
			this.byteArray2 = destinationArray;
		}
		return result;
	}

	// Token: 0x060017F7 RID: 6135 RVA: 0x00054134 File Offset: 0x00052334
	public long Method12237()
	{
		this.Method12242(8);
		return ((long)this.Method12238() & (long)((ulong)-1)) | (long)this.Method12238() << 32;
	}

	// Token: 0x060017F8 RID: 6136 RVA: 0x00054154 File Offset: 0x00052354
	public int Method12238()
	{
		this.Method12242(4);
		int result = (int)this.byteArray2[this.number3] + ((int)this.byteArray2[this.number3 + 1] << 8) + ((int)this.byteArray2[this.number3 + 2] << 16) + ((int)this.byteArray2[this.number3 + 3] << 24);
		this.number3 += 4;
		return result;
	}

	// Token: 0x060017F9 RID: 6137 RVA: 0x000541BB File Offset: 0x000523BB
	public int Method12239()
	{
		this.Method12242(2);
		int result = (int)this.byteArray2[this.number3] + ((int)this.byteArray2[this.number3 + 1] << 8);
		this.number3 += 2;
		return result;
	}

	// Token: 0x060017FA RID: 6138 RVA: 0x000541F4 File Offset: 0x000523F4
	public int Method12240()
	{
		int result = -1;
		if (this.number3 < this.byteArray2.Length && this.number4 + this.number5 > this.number3)
		{
			result = (int)this.byteArray2[this.number3];
			this.number3++;
		}
		return result;
	}

	// Token: 0x060017FB RID: 6139 RVA: 0x00054245 File Offset: 0x00052445
	public void Method12241(int 1)
	{
		this.Method12242(1);
		this.number3 += 1;
	}

	// Token: 0x060017FC RID: 6140 RVA: 0x0005425C File Offset: 0x0005245C
	private void Method12242(int 1)
	{
		if (this.number4 > this.byteArray2.Length || this.number4 < 4)
		{
			throw new 415("Find must be called before calling a Read method");
		}
		if (this.number3 > this.number4 + this.number5 - 1)
		{
			throw new 415("End of extra data");
		}
		if (this.number3 + 1 < 4)
		{
			throw new 415("Cannot read before start of tag");
		}
	}

	// Token: 0x060017FD RID: 6141 RVA: 0x000542C8 File Offset: 0x000524C8
	private int Method12243()
	{
		if (this.number3 > this.byteArray2.Length - 2)
		{
			throw new 415("End of extra data");
		}
		int result = (int)this.byteArray2[this.number3] + ((int)this.byteArray2[this.number3 + 1] << 8);
		this.number3 += 2;
		return result;
	}

	// Token: 0x060017FE RID: 6142 RVA: 0x0005431F File Offset: 0x0005251F
	private void Method12244(ref int 1, int 2)
	{
		this.byteArray2[1] = (byte)2;
		this.byteArray2[1 + 1] = (byte)(2 >> 8);
		1 += 2;
	}

	// Token: 0x060017FF RID: 6143 RVA: 0x00054341 File Offset: 0x00052541
	public void Dispose()
	{
		if (this.memoryStream != null)
		{
			this.memoryStream.Close();
		}
	}

	// Token: 0x04000B2F RID: 2863
	private int number3;

	// Token: 0x04000B30 RID: 2864
	private int number4;

	// Token: 0x04000B31 RID: 2865
	private int number5;

	// Token: 0x04000B32 RID: 2866
	private MemoryStream memoryStream;

	// Token: 0x04000B33 RID: 2867
	private byte[] byteArray2;
}
