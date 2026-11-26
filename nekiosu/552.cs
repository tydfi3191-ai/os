using System;
using System.Runtime.InteropServices;

// Token: 0x02000343 RID: 835
[ComVisible(true)]
[Guid("ebc25cf6-9120-4283-b972-0e5520d0000D")]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
public sealed class 552
{
	// Token: 0x060019D8 RID: 6616 RVA: 0x0005EFA2 File Offset: 0x0005D1A2
	public 552()
	{
		this._recoveredType20635610 = (724)6;
		this.number10 = 15;
		this._recoveredType05485618 = (417)0;
	}

	// Token: 0x060019D9 RID: 6617 RVA: 0x0005EFC0 File Offset: 0x0005D1C0
	public 552(777 1)
	{
		this._recoveredType20635610 = (724)6;
		this.number10 = 15;
		this._recoveredType05485618 = (417)0;
		if (1 != (777)0)
		{
			if (1 != (777)1)
			{
				throw new 522("Invalid ZlibStreamFlavor.");
			}
			if (this.Method7092() != 0)
			{
				throw new 522("Cannot initialize for inflate.");
			}
		}
		else if (this.Method7087() != 0)
		{
			throw new 522("Cannot initialize for deflate.");
		}
	}

	// Token: 0x060019DA RID: 6618 RVA: 0x0005F024 File Offset: 0x0005D224
	private int Method7081(bool 1)
	{
		if (this.zlibInflate != null)
		{
			throw new 522("You may not call InitializeDeflate() after calling InitializeInflate().");
		}
		this._recoveredType04975611 = new 407();
		this._recoveredType04975611.SetFlag2268_2917(1);
		return this._recoveredType04975611.Method2896(this, this._recoveredType20635610, this.number10, this._recoveredType05485618);
	}

	// Token: 0x060019DB RID: 6619 RVA: 0x0005F079 File Offset: 0x0005D279
	public int Method7082(528 1)
	{
		if (this._recoveredType04975611 == null)
		{
			throw new 522("No Deflate State!");
		}
		return this._recoveredType04975611.Method2890(1);
	}

	// Token: 0x060019DC RID: 6620 RVA: 0x0005F09A File Offset: 0x0005D29A
	public int Method7083()
	{
		if (this._recoveredType04975611 == null)
		{
			throw new 522("No Deflate State!");
		}
		int result = this._recoveredType04975611.Method2894();
		this._recoveredType04975611 = null;
		return result;
	}

	// Token: 0x060019DD RID: 6621 RVA: 0x0005F0C1 File Offset: 0x0005D2C1
	public int Method7084()
	{
		if (this.zlibInflate == null)
		{
			throw new 522("No Inflate State!");
		}
		int result = this.zlibInflate.End();
		this.zlibInflate = null;
		return result;
	}

	// Token: 0x060019DE RID: 6622 RVA: 0x0005F0E8 File Offset: 0x0005D2E8
	internal void Method7085()
	{
		int number = this._recoveredType04975611.number29;
		if (number > this.number5)
		{
			number = this.number5;
		}
		if (number != 0)
		{
			if (this._recoveredType04975611.byteArray2.Length <= this._recoveredType04975611.number27 || this.byteArray3.Length <= this.number7 || this._recoveredType04975611.byteArray2.Length < this._recoveredType04975611.number27 + number || this.byteArray3.Length < this.number7 + number)
			{
				throw new 522(string.Format("Invalid State. (pending.Length={0}, pendingCount={1})", this._recoveredType04975611.byteArray2.Length, this._recoveredType04975611.number29));
			}
			Array.Copy(this._recoveredType04975611.byteArray2, this._recoveredType04975611.number27, this.byteArray3, this.number7, number);
			this.number7 += number;
			this._recoveredType04975611.number27 += number;
			this.number9 += (long)number;
			this.number5 -= number;
			this._recoveredType04975611.number29 -= number;
			if (this._recoveredType04975611.number29 == 0)
			{
				this._recoveredType04975611.number27 = 0;
			}
		}
	}

	// Token: 0x060019DF RID: 6623 RVA: 0x0005F233 File Offset: 0x0005D433
	public int Method7086(528 1)
	{
		if (this.zlibInflate == null)
		{
			throw new 522("No Inflate State!");
		}
		return this.zlibInflate.Inflate(1);
	}

	// Token: 0x060019E0 RID: 6624 RVA: 0x0005F254 File Offset: 0x0005D454
	public int Method7087()
	{
		return this.Method7081(true);
	}

	// Token: 0x060019E1 RID: 6625 RVA: 0x0005F25D File Offset: 0x0005D45D
	public int Method7087(724 1)
	{
		this._recoveredType20635610 = 1;
		return this.Method7081(true);
	}

	// Token: 0x060019E2 RID: 6626 RVA: 0x0005F26D File Offset: 0x0005D46D
	public int Method7087(724 1, bool 2)
	{
		this._recoveredType20635610 = 1;
		return this.Method7081(2);
	}

	// Token: 0x060019E3 RID: 6627 RVA: 0x0005F27D File Offset: 0x0005D47D
	public int Method7087(724 1, int 2)
	{
		this._recoveredType20635610 = 1;
		this.number10 = 2;
		return this.Method7081(true);
	}

	// Token: 0x060019E4 RID: 6628 RVA: 0x0005F294 File Offset: 0x0005D494
	public int Method7087(724 1, int 2, bool 3)
	{
		this._recoveredType20635610 = 1;
		this.number10 = 2;
		return this.Method7081(3);
	}

	// Token: 0x060019E5 RID: 6629 RVA: 0x0005F2AB File Offset: 0x0005D4AB
	public int Method7092()
	{
		return this.Method7092(this.number10);
	}

	// Token: 0x060019E6 RID: 6630 RVA: 0x0005F2B9 File Offset: 0x0005D4B9
	public int Method7092(bool 1)
	{
		return this.Method7092(this.number10, 1);
	}

	// Token: 0x060019E7 RID: 6631 RVA: 0x0005F2C8 File Offset: 0x0005D4C8
	public int Method7092(int 1)
	{
		this.number10 = 1;
		return this.Method7092(1, true);
	}

	// Token: 0x060019E8 RID: 6632 RVA: 0x0005F2D9 File Offset: 0x0005D4D9
	public int Method7092(int 1, bool 2)
	{
		this.number10 = 1;
		if (this._recoveredType04975611 != null)
		{
			throw new 522("You may not call InitializeInflate() after calling InitializeDeflate().");
		}
		this.zlibInflate = new 990(2);
		return this.zlibInflate.Initialize(this, 1);
	}

	// Token: 0x060019E9 RID: 6633 RVA: 0x0005F310 File Offset: 0x0005D510
	internal int Method7096(byte[] 1, int 2, int 3)
	{
		int num = this.number4;
		if (num > 3)
		{
			num = 3;
		}
		if (num == 0)
		{
			return 0;
		}
		this.number4 -= num;
		if (this._recoveredType04975611.GetFlag2268_2916())
		{
			this.number3 = 727.Method11313(this.number3, this.byteArray2, this.number6, num);
		}
		Array.Copy(this.byteArray2, this.number6, 1, 2, num);
		this.number6 += num;
		this.number8 += (long)num;
		return num;
	}

	// Token: 0x060019EA RID: 6634 RVA: 0x0005F39A File Offset: 0x0005D59A
	public void Method7097()
	{
		if (this._recoveredType04975611 == null)
		{
			throw new 522("No Deflate State!");
		}
		this._recoveredType04975611.Method2906();
	}

	// Token: 0x060019EB RID: 6635 RVA: 0x0005F3BA File Offset: 0x0005D5BA
	public int Method7098(724 1, 417 2)
	{
		if (this._recoveredType04975611 == null)
		{
			throw new 522("No Deflate State!");
		}
		return this._recoveredType04975611.Method2915(1, 2);
	}

	// Token: 0x060019EC RID: 6636 RVA: 0x0005F3DC File Offset: 0x0005D5DC
	public int Method7099(byte[] 1)
	{
		if (this.zlibInflate != null)
		{
			return this.zlibInflate.SetDictionary(1);
		}
		if (this._recoveredType04975611 == null)
		{
			throw new 522("No Inflate or Deflate state!");
		}
		return this._recoveredType04975611.Method2914(1);
	}

	// Token: 0x060019ED RID: 6637 RVA: 0x0005F412 File Offset: 0x0005D612
	public int Method7100()
	{
		if (this.zlibInflate == null)
		{
			throw new 522("No Inflate State!");
		}
		return this.zlibInflate.Sync();
	}

	// Token: 0x060019EE RID: 6638 RVA: 0x0005F432 File Offset: 0x0005D632
	public long GetNumber5607_7101()
	{
		return this.number3;
	}

	// Token: 0x04000C22 RID: 3106
	internal long number3;

	// Token: 0x04000C23 RID: 3107
	public int number4;

	// Token: 0x04000C24 RID: 3108
	public int number5;

	// Token: 0x04000C25 RID: 3109
	public 724 _recoveredType20635610;

	// Token: 0x04000C26 RID: 3110
	internal 407 _recoveredType04975611;

	// Token: 0x04000C27 RID: 3111
	public byte[] byteArray2;

	// Token: 0x04000C28 RID: 3112
	internal 990 zlibInflate;

	// Token: 0x04000C29 RID: 3113
	public string text;

	// Token: 0x04000C2A RID: 3114
	public int number6;

	// Token: 0x04000C2B RID: 3115
	public int number7;

	// Token: 0x04000C2C RID: 3116
	public byte[] byteArray3;

	// Token: 0x04000C2D RID: 3117
	public 417 _recoveredType05485618;

	// Token: 0x04000C2E RID: 3118
	public long number8;

	// Token: 0x04000C2F RID: 3119
	public long number9;

	// Token: 0x04000C30 RID: 3120
	public int number10;
}
