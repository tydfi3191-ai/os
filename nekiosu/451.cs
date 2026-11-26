using System;
using System.IO;
using System.Runtime.InteropServices;

// Token: 0x020002EE RID: 750
[ComVisible(false)]
public sealed class 451 : 494
{
	// Token: 0x170000F4 RID: 244
	// (get) Token: 0x06001676 RID: 5750 RVA: 0x0004D548 File Offset: 0x0004B748
	public override long Length
	{
		get
		{
			if (this._recoveredType23393137 == null)
			{
				throw new InvalidOperationException("No current entry");
			}
			if (this._recoveredType23393137.Method12803() >= 0L)
			{
				return this._recoveredType23393137.Method12803();
			}
			throw new 415("Length not available for the current entry");
		}
	}

	// Token: 0x06001677 RID: 5751 RVA: 0x0004D582 File Offset: 0x0004B782
	public 451(Stream 1) : base(1, new 105(true))
	{
		this._recoveredType07113135 = new 451.452(this.Method4037);
	}

	// Token: 0x06001678 RID: 5752 RVA: 0x0004D5AE File Offset: 0x0004B7AE
	public 451(Stream 1, int 2) : base(1, new 105(true), 2)
	{
		this._recoveredType07113135 = new 451.452(this.Method4037);
	}

	// Token: 0x06001679 RID: 5753 RVA: 0x0004D5DB File Offset: 0x0004B7DB
	public string _0005_2006_2003_200B_2001_2006_2009_200B_200A_2003_200B_2007_2006_2003_200A_2002_2000_2008_2006_2008_200B_2004()
	{
		return this.text2;
	}

	// Token: 0x0600167A RID: 5754 RVA: 0x0004D5E3 File Offset: 0x0004B7E3
	public void _0006_2009_2008_200B_200A_2007_2005_2001_2009_2007_2002_2009(string 1)
	{
		this.text2 = 1;
	}

	// Token: 0x0600167B RID: 5755 RVA: 0x0004D5EC File Offset: 0x0004B7EC
	public bool _000F_2005_200A_200A_2000_200A_2005_2008_200A_2003_200A_2005_2006_2007_2000_2008_2005_200B_2009_2001_2002_200B_2006_2006_2005_2006_2007()
	{
		return this._recoveredType23393137 != null && this._recoveredType23393137.Method12793();
	}

	// Token: 0x0600167C RID: 5756 RVA: 0x0004D604 File Offset: 0x0004B804
	public 783 _0008_200A_2003_200B_2006_2003_2009_2003_2000_200B_2009_200A_200B()
	{
		if (this._recoveredType14333136 == null)
		{
			throw new InvalidOperationException("Closed.");
		}
		if (this._recoveredType23393137 != null)
		{
			this._000E_2002_2007_2000_2002_2007_200B_2002_2000_2001_2000_2003();
		}
		int num = this.inflaterInputBuffer.ReadLeInt();
		if (num <= 101010256)
		{
			if (num != 33639248 && num != 84233040 && num != 101010256)
			{
				goto IL_8F;
			}
		}
		else if (num <= 117853008)
		{
			if (num != 101075792 && num != 117853008)
			{
				goto IL_8F;
			}
		}
		else
		{
			if (num != 134695760 && num != 808471376)
			{
				goto IL_8F;
			}
			num = this.inflaterInputBuffer.ReadLeInt();
			goto IL_8F;
		}
		this.Close();
		return null;
		IL_8F:
		if (num != 67324752)
		{
			throw new 415("Wrong Local header signature: 0x" + string.Format("{0:X}", num));
		}
		short <<EMPTY_NAME>> = (short)this.inflaterInputBuffer.ReadLeShort();
		this.number5 = this.inflaterInputBuffer.ReadLeShort();
		this.number4 = this.inflaterInputBuffer.ReadLeShort();
		uint num2 = (uint)this.inflaterInputBuffer.ReadLeInt();
		int num3 = this.inflaterInputBuffer.ReadLeInt();
		this.number6 = (long)this.inflaterInputBuffer.ReadLeInt();
		this.number3 = (long)this.inflaterInputBuffer.ReadLeInt();
		int num4 = this.inflaterInputBuffer.ReadLeShort();
		int num5 = this.inflaterInputBuffer.ReadLeShort();
		bool flag = (this.number5 & 1) == 1;
		byte[] array = new byte[num4];
		this.inflaterInputBuffer.Method5820(array);
		string 2 = 448.Method4012(this.number5, array);
		this._recoveredType23393137 = new 783(2, (int)<<EMPTY_NAME>>);
		this._recoveredType23393137.SetNumber10005_12780(this.number5);
		this._recoveredType23393137.Method12810((536)this.number4);
		if ((this.number5 & 8) == 0)
		{
			this._recoveredType23393137.Method12808((long)num3 & (long)((ulong)-1));
			this._recoveredType23393137.Method12804(this.number3 & (long)((ulong)-1));
			this._recoveredType23393137.Method12806(this.number6 & (long)((ulong)-1));
			this._recoveredType23393137.SetByte10009_12778((byte)(num3 >> 24));
		}
		else
		{
			if (num3 != 0)
			{
				this._recoveredType23393137.Method12808((long)num3 & (long)((ulong)-1));
			}
			if (this.number3 != 0L)
			{
				this._recoveredType23393137.Method12804(this.number3 & (long)((ulong)-1));
			}
			if (this.number6 != 0L)
			{
				this._recoveredType23393137.Method12806(this.number6 & (long)((ulong)-1));
			}
			this._recoveredType23393137.SetByte10009_12778((byte)(num2 >> 8));
		}
		this._recoveredType23393137.Method12799((long)((ulong)num2));
		if (num5 > 0)
		{
			byte[] 3 = new byte[num5];
			this.inflaterInputBuffer.Method5820(3);
			this._recoveredType23393137.Method12813(3);
		}
		this._recoveredType23393137.Method12819(true);
		if (this._recoveredType23393137.Method12805() >= 0L)
		{
			this.number6 = this._recoveredType23393137.Method12805();
		}
		if (this._recoveredType23393137.Method12803() >= 0L)
		{
			this.number3 = this._recoveredType23393137.Method12803();
		}
		if (this.number4 == 0 && ((!flag && this.number6 != this.number3) || (flag && this.number6 - 12L != this.number3)))
		{
			throw new 415("Stored, but compressed != uncompressed");
		}
		if (this._recoveredType23393137.Method12825())
		{
			this._recoveredType07113135 = new 451.452(this.Method4039);
		}
		else
		{
			this._recoveredType07113135 = new 451.452(this.Method4038);
		}
		return this._recoveredType23393137;
	}

	// Token: 0x0600167D RID: 5757 RVA: 0x0004D950 File Offset: 0x0004BB50
	private void Method4035()
	{
		if (this.inflaterInputBuffer.ReadLeInt() != 134695760)
		{
			throw new 415("Data descriptor signature not found");
		}
		this._recoveredType23393137.Method12808((long)this.inflaterInputBuffer.ReadLeInt() & (long)((ulong)-1));
		if (this._recoveredType23393137.Method12796())
		{
			this.number6 = this.inflaterInputBuffer.ReadLeLong();
			this.number3 = this.inflaterInputBuffer.ReadLeLong();
		}
		else
		{
			this.number6 = (long)this.inflaterInputBuffer.ReadLeInt();
			this.number3 = (long)this.inflaterInputBuffer.ReadLeInt();
		}
		this._recoveredType23393137.Method12806(this.number6);
		this._recoveredType23393137.Method12804(this.number3);
	}

	// Token: 0x0600167E RID: 5758 RVA: 0x0004DA0C File Offset: 0x0004BC0C
	private void Method4036(bool 1)
	{
		base.Method5398();
		if ((this.number5 & 8) != 0)
		{
			this.Method4035();
		}
		this.number3 = 0L;
		if (1 && (this._recoveredType14333136.GetNumber7041_9089() & (long)((ulong)-1)) != this._recoveredType23393137.Method12807() && this._recoveredType23393137.Method12807() != -1L)
		{
			throw new 415("CRC mismatch");
		}
		this._recoveredType14333136.SetNumber7041_9090();
		if (this.number4 == 8)
		{
			this.inflater2.Reset();
		}
		this._recoveredType23393137 = null;
	}

	// Token: 0x0600167F RID: 5759 RVA: 0x0004DA98 File Offset: 0x0004BC98
	public void _000E_2002_2007_2000_2002_2007_200B_2002_2000_2001_2000_2003()
	{
		if (this._recoveredType14333136 == null)
		{
			throw new InvalidOperationException("Closed");
		}
		if (this._recoveredType23393137 == null)
		{
			return;
		}
		if (this.number4 == 8)
		{
			if ((this.number5 & 8) != 0)
			{
				byte[] array = new byte[4096];
				while (this.Read(array, 0, array.Length) > 0)
				{
				}
				return;
			}
			this.number6 -= this.inflater2.GetTotalIn();
			106 inflaterInputBuffer = this.inflaterInputBuffer;
			inflaterInputBuffer.SetAvailable(inflaterInputBuffer.GetAvailable() + this.inflater2.GetRemainingInput());
		}
		if ((long)this.inflaterInputBuffer.GetAvailable() > this.number6 && this.number6 >= 0L)
		{
			this.inflaterInputBuffer.SetAvailable((int)((long)this.inflaterInputBuffer.GetAvailable() - this.number6));
		}
		else
		{
			this.number6 -= (long)this.inflaterInputBuffer.GetAvailable();
			this.inflaterInputBuffer.SetAvailable(0);
			while (this.number6 != 0L)
			{
				long num = base._0002_2000_2004_2003_2000_2007_2007_2007_2007_2000_2005_2007(this.number6);
				if (num <= 0L)
				{
					throw new 415("Zip archive ends early.");
				}
				this.number6 -= num;
			}
		}
		this.Method4036(false);
	}

	// Token: 0x06001680 RID: 5760 RVA: 0x0004DBC3 File Offset: 0x0004BDC3
	public override int _0008_2008_2005_2001_2001_2006_2008_2003_2005_2001_2001_200A_2004_2002_2009_2003_2008()
	{
		if (this._recoveredType23393137 == null)
		{
			return 0;
		}
		return 1;
	}

	// Token: 0x06001681 RID: 5761 RVA: 0x0004DBD0 File Offset: 0x0004BDD0
	public override int ReadByte()
	{
		byte[] array = new byte[1];
		if (this.Read(array, 0, 1) <= 0)
		{
			return -1;
		}
		return (int)(array[0] & byte.MaxValue);
	}

	// Token: 0x06001682 RID: 5762 RVA: 0x0004DBFB File Offset: 0x0004BDFB
	private int Method4037(byte[] 1, int 2, int 3)
	{
		throw new InvalidOperationException("Unable to read from this stream");
	}

	// Token: 0x06001683 RID: 5763 RVA: 0x0004DC07 File Offset: 0x0004BE07
	private int Method4038(byte[] 1, int 2, int 3)
	{
		throw new 415("The compression method for this entry is not supported");
	}

	// Token: 0x06001684 RID: 5764 RVA: 0x0004DC14 File Offset: 0x0004BE14
	private int Method4039(byte[] 1, int 2, int 3)
	{
		if (!this._000F_2005_200A_200A_2000_200A_2005_2008_200A_2003_200A_2005_2006_2007_2000_2008_2005_200B_2009_2001_2002_200B_2006_2006_2005_2006_2007())
		{
			throw new 415("Library cannot extract this entry. Version required is (" + this._recoveredType23393137.Method12792().ToString() + ")");
		}
		if (this._recoveredType23393137.Method12773())
		{
			if (this.text2 == null)
			{
				throw new 415("No password set.");
			}
			627 4 = new 627();
			byte[] rgbKey = 560.Method7523(448.Method4014(this.text2));
			this.inflaterInputBuffer.SetCryptoTransform(4.CreateDecryptor(rgbKey, null));
			byte[] array = new byte[12];
			this.inflaterInputBuffer.ReadClearTextBuffer(array, 0, 12);
			if (array[11] != this._recoveredType23393137.GetByte10009_12777())
			{
				throw new 415("Invalid password");
			}
			if (this.number6 >= 12L)
			{
				this.number6 -= 12L;
			}
			else if ((this._recoveredType23393137.GetNumber10005_12779() & 8) == 0)
			{
				throw new 415(string.Format("Entry compressed size {0} too small for encryption", this.number6));
			}
		}
		else
		{
			this.inflaterInputBuffer.SetCryptoTransform(null);
		}
		if (this.number6 > 0L || (this.number5 & 8) != 0)
		{
			if (this.number4 == 8 && this.inflaterInputBuffer.GetAvailable() > 0)
			{
				this.inflaterInputBuffer.SetInflaterInput(this.inflater2);
			}
			this._recoveredType07113135 = new 451.452(this.Method4040);
			return this.Method4040(1, 2, 3);
		}
		this._recoveredType07113135 = new 451.452(this.Method4037);
		return 0;
	}

	// Token: 0x06001685 RID: 5765 RVA: 0x0004DD90 File Offset: 0x0004BF90
	public override int Read(byte[] 1, int 2, int 3)
	{
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
		return this._recoveredType07113135(1, 2, 3);
	}

	// Token: 0x06001686 RID: 5766 RVA: 0x0004DDF4 File Offset: 0x0004BFF4
	private int Method4040(byte[] 1, int 2, int 3)
	{
		if (this._recoveredType14333136 == null)
		{
			throw new InvalidOperationException("Closed");
		}
		if (this._recoveredType23393137 == null || 3 <= 0)
		{
			return 0;
		}
		if (2 + 3 > 1.Length)
		{
			throw new ArgumentException("Offset + count exceeds buffer size");
		}
		bool flag = false;
		int num = this.number4;
		if (num != 0)
		{
			if (num == 8)
			{
				3 = base.Read(1, 2, 3);
				if (3 <= 0)
				{
					if (!this.inflater2.IsFinished())
					{
						throw new 415("Inflater not finished!");
					}
					this.inflaterInputBuffer.SetAvailable(this.inflater2.GetRemainingInput());
					if ((this.number5 & 8) == 0 && ((this.inflater2.GetTotalIn() != this.number6 && this.number6 != (long)((ulong)-1) && this.number6 != -1L) || this.inflater2.GetTotalOut() != this.number3))
					{
						throw new 415(string.Concat(new string[]
						{
							"Size mismatch: ",
							this.number6.ToString(),
							";",
							this.number3.ToString(),
							" <-> ",
							this.inflater2.GetTotalIn().ToString(),
							";",
							this.inflater2.GetTotalOut().ToString()
						}));
					}
					this.inflater2.Reset();
					flag = true;
				}
			}
		}
		else
		{
			if ((long)3 > this.number6 && this.number6 >= 0L)
			{
				3 = (int)this.number6;
			}
			if (3 > 0)
			{
				3 = this.inflaterInputBuffer.ReadClearTextBuffer(1, 2, 3);
				if (3 > 0)
				{
					this.number6 -= (long)3;
					this.number3 -= (long)3;
				}
			}
			if (this.number6 == 0L)
			{
				flag = true;
			}
			else if (3 < 0)
			{
				throw new 415("EOF in stored block");
			}
		}
		if (3 > 0)
		{
			this._recoveredType14333136.Method90912(1, 2, 3);
		}
		if (flag)
		{
			this.Method4036(true);
		}
		return 3;
	}

	// Token: 0x06001687 RID: 5767 RVA: 0x0004DFE5 File Offset: 0x0004C1E5
	public override void Close()
	{
		this._recoveredType07113135 = new 451.452(this.Method4037);
		this._recoveredType14333136 = null;
		this._recoveredType23393137 = null;
		base.Close();
	}

	// Token: 0x04000A91 RID: 2705
	private 451.452 _recoveredType07113135;

	// Token: 0x04000A92 RID: 2706
	private 597 _recoveredType14333136 = new 597();

	// Token: 0x04000A93 RID: 2707
	private 783 _recoveredType23393137;

	// Token: 0x04000A94 RID: 2708
	private long number3;

	// Token: 0x04000A95 RID: 2709
	private int number4;

	// Token: 0x04000A96 RID: 2710
	private int number5;

	// Token: 0x04000A97 RID: 2711
	private string text2;

	// Token: 0x020002EF RID: 751
	// (Invoke) Token: 0x06001689 RID: 5769
	public delegate int 452(byte[] 1, int 2, int 3);
}
