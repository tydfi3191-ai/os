using System;
using System.Runtime.InteropServices;

// Token: 0x020002D7 RID: 727
[ComVisible(false)]
public sealed class 105
{
	// Token: 0x060015BA RID: 5562 RVA: 0x0004AD84 File Offset: 0x00048F84
	public 105() : this(false)
	{
	}

	// Token: 0x060015BB RID: 5563 RVA: 0x0004AD8D File Offset: 0x00048F8D
	public 105(bool 1)
	{
		this.nowrap = 1;
		this.adler = new 629();
		this.input = new 769();
		this.outputWindow = new 701();
		this.mode = (1 ? 2 : 0);
	}

	// Token: 0x060015BC RID: 5564 RVA: 0x0004ADCC File Offset: 0x00048FCC
	public void Reset()
	{
		this.mode = (this.nowrap ? 2 : 0);
		this.totalIn = 0L;
		this.totalOut = 0L;
		this.input.Method12426();
		this.outputWindow.SetNumber8410_10829();
		this.dynHeader = null;
		this.litlenTree = null;
		this.distTree = null;
		this.isLastBlock = false;
		this.adler.SetNumber7041_9090();
	}

	// Token: 0x060015BD RID: 5565 RVA: 0x0004AE38 File Offset: 0x00049038
	private bool DecodeHeader()
	{
		int num = this.input.Method12418(16);
		if (num < 0)
		{
			return false;
		}
		this.input.Method12419(16);
		num = ((num << 8 | num >> 8) & 65535);
		if (num % 31 != 0)
		{
			throw new 657("Header checksum illegal");
		}
		if ((num & 3840) != 2048)
		{
			throw new 657("Compression Method unknown");
		}
		if ((num & 32) == 0)
		{
			this.mode = 2;
		}
		else
		{
			this.mode = 1;
			this.neededBits = 32;
		}
		return true;
	}

	// Token: 0x060015BE RID: 5566 RVA: 0x0004AEC0 File Offset: 0x000490C0
	private bool DecodeDict()
	{
		while (this.neededBits > 0)
		{
			int num = this.input.Method12418(8);
			if (num < 0)
			{
				return false;
			}
			this.input.Method12419(8);
			this.readAdler = (this.readAdler << 8 | num);
			this.neededBits -= 8;
		}
		return false;
	}

	// Token: 0x060015BF RID: 5567 RVA: 0x0004AF18 File Offset: 0x00049118
	private bool DecodeHuffman()
	{
		int i = this.outputWindow.Method10826();
		while (i >= 258)
		{
			switch (this.mode)
			{
			case 7:
			{
				int num;
				while (((num = this.litlenTree.Method9754(this.input)) & -256) == 0)
				{
					this.outputWindow.Method10821(num);
					if (--i < 258)
					{
						return true;
					}
				}
				if (num >= 257)
				{
					try
					{
						this.repLength = 105.lengthBase[num - 257];
						this.neededBits = 105.lengthExtraBits[num - 257];
					}
					catch (Exception)
					{
						throw new 657("Illegal rep length code");
					}
					goto IL_C4;
				}
				if (num < 0)
				{
					return false;
				}
				this.distTree = null;
				this.litlenTree = null;
				this.mode = 2;
				return true;
			}
			case 8:
				goto IL_C4;
			case 9:
				goto IL_113;
			case 10:
				break;
			default:
				throw new 657("Inflater unknown mode");
			}
			IL_158:
			if (this.neededBits > 0)
			{
				this.mode = 10;
				int num2 = this.input.Method12418(this.neededBits);
				if (num2 < 0)
				{
					return false;
				}
				this.input.Method12419(this.neededBits);
				this.repDist += num2;
			}
			this.outputWindow.Method10823(this.repLength, this.repDist);
			i -= this.repLength;
			this.mode = 7;
			continue;
			IL_113:
			int num3 = this.distTree.Method9754(this.input);
			if (num3 < 0)
			{
				return false;
			}
			try
			{
				this.repDist = 105.distanceBase[num3];
				this.neededBits = 105.distanceExtraBits[num3];
			}
			catch (Exception)
			{
				throw new 657("Illegal rep dist code");
			}
			goto IL_158;
			IL_C4:
			if (this.neededBits > 0)
			{
				this.mode = 8;
				int num4 = this.input.Method12418(this.neededBits);
				if (num4 < 0)
				{
					return false;
				}
				this.input.Method12419(this.neededBits);
				this.repLength += num4;
			}
			this.mode = 9;
			goto IL_113;
		}
		return true;
	}

	// Token: 0x060015C0 RID: 5568 RVA: 0x0004B124 File Offset: 0x00049324
	private bool DecodeChksum()
	{
		while (this.neededBits > 0)
		{
			int num = this.input.Method12418(8);
			if (num < 0)
			{
				return false;
			}
			this.input.Method12419(8);
			this.readAdler = (this.readAdler << 8 | num);
			this.neededBits -= 8;
		}
		if ((int)this.adler.GetNumber7041_9089() != this.readAdler)
		{
			throw new 657("Adler chksum doesn't match: " + ((int)this.adler.GetNumber7041_9089()).ToString() + " vs. " + this.readAdler.ToString());
		}
		this.mode = 12;
		return false;
	}

	// Token: 0x060015C1 RID: 5569 RVA: 0x0004B1CC File Offset: 0x000493CC
	private bool Decode()
	{
		switch (this.mode)
		{
		case 0:
			return this.DecodeHeader();
		case 1:
			return this.DecodeDict();
		case 2:
			if (this.isLastBlock)
			{
				if (this.nowrap)
				{
					this.mode = 12;
					return false;
				}
				this.input.Method12423();
				this.neededBits = 32;
				this.mode = 11;
				return true;
			}
			else
			{
				int num = this.input.Method12418(3);
				if (num < 0)
				{
					return false;
				}
				this.input.Method12419(3);
				if ((num & 1) != 0)
				{
					this.isLastBlock = true;
				}
				switch (num >> 1)
				{
				case 0:
					this.input.Method12423();
					this.mode = 3;
					break;
				case 1:
					this.litlenTree = 661._recoveredType17547637;
					this.distTree = 661._recoveredType17547638;
					this.mode = 7;
					break;
				case 2:
					this.dynHeader = new 449();
					this.mode = 6;
					break;
				default:
					throw new 657("Unknown block type " + num.ToString());
				}
				return true;
			}
			break;
		case 3:
			if ((this.uncomprLen = this.input.Method12418(16)) < 0)
			{
				return false;
			}
			this.input.Method12419(16);
			this.mode = 4;
			break;
		case 4:
			break;
		case 5:
			goto IL_1A6;
		case 6:
			if (!this.dynHeader.Method4016(this.input))
			{
				return false;
			}
			this.litlenTree = this.dynHeader.Method4017();
			this.distTree = this.dynHeader.Method4018();
			this.mode = 7;
			goto IL_22C;
		case 7:
		case 8:
		case 9:
		case 10:
			goto IL_22C;
		case 11:
			return this.DecodeChksum();
		case 12:
			return false;
		default:
			throw new 657("Inflater.Decode unknown mode");
		}
		int num2 = this.input.Method12418(16);
		if (num2 < 0)
		{
			return false;
		}
		this.input.Method12419(16);
		if (num2 != (this.uncomprLen ^ 65535))
		{
			throw new 657("broken uncompressed block");
		}
		this.mode = 5;
		IL_1A6:
		int num3 = this.outputWindow.Method10824(this.input, this.uncomprLen);
		this.uncomprLen -= num3;
		if (this.uncomprLen == 0)
		{
			this.mode = 2;
			return true;
		}
		return !this.input.Method12424();
		IL_22C:
		return this.DecodeHuffman();
	}

	// Token: 0x060015C2 RID: 5570 RVA: 0x0004B418 File Offset: 0x00049618
	public void Method10660(byte[] 1)
	{
		this.Method10660(1, 0, 1.Length);
	}

	// Token: 0x060015C3 RID: 5571 RVA: 0x0004B428 File Offset: 0x00049628
	public void Method10660(byte[] 1, int 2, int 3)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=zpMJwVYM=");
		}
		if (2 < 0)
		{
			throw new ArgumentOutOfRangeException("#=zEcSd6Vg=");
		}
		if (3 < 0)
		{
			throw new ArgumentOutOfRangeException("#=zW32YDQ0=");
		}
		if (!this.IsNeedingDictionary())
		{
			throw new InvalidOperationException("Dictionary is not needed");
		}
		this.adler.Method90912(1, 2, 3);
		if ((int)this.adler.GetNumber7041_9089() != this.readAdler)
		{
			throw new 657("Wrong adler checksum");
		}
		this.adler.SetNumber7041_9090();
		this.outputWindow.Method10825(1, 2, 3);
		this.mode = 2;
	}

	// Token: 0x060015C4 RID: 5572 RVA: 0x0004B4C1 File Offset: 0x000496C1
	public void Method10662(byte[] 1)
	{
		this.Method10662(1, 0, 1.Length);
	}

	// Token: 0x060015C5 RID: 5573 RVA: 0x0004B4CE File Offset: 0x000496CE
	public void Method10662(byte[] 1, int 2, int 3)
	{
		this.input.Method12427(1, 2, 3);
		this.totalIn += (long)3;
	}

	// Token: 0x060015C6 RID: 5574 RVA: 0x0004B4ED File Offset: 0x000496ED
	public int Method10664(byte[] 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=zpMJwVYM=");
		}
		return this.Method10664(1, 0, 1.Length);
	}

	// Token: 0x060015C7 RID: 5575 RVA: 0x0004B508 File Offset: 0x00049708
	public int Method10664(byte[] 1, int 2, int 3)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=zpMJwVYM=");
		}
		if (3 < 0)
		{
			throw new ArgumentOutOfRangeException("#=zW32YDQ0=", "count cannot be negative");
		}
		if (2 < 0)
		{
			throw new ArgumentOutOfRangeException("#=zJ_sgkP4=", "offset cannot be negative");
		}
		if (2 + 3 > 1.Length)
		{
			throw new ArgumentException("count exceeds buffer bounds");
		}
		if (3 == 0)
		{
			if (!this.IsFinished())
			{
				this.Decode();
			}
			return 0;
		}
		int num = 0;
		for (;;)
		{
			if (this.mode != 11)
			{
				int num2 = this.outputWindow.Method10828(1, 2, 3);
				if (num2 > 0)
				{
					this.adler.Method90912(1, 2, num2);
					2 += num2;
					num += num2;
					this.totalOut += (long)num2;
					3 -= num2;
					if (3 == 0)
					{
						break;
					}
				}
			}
			if (!this.Decode() && (this.outputWindow.GetNumber8410_10827() <= 0 || this.mode == 11))
			{
				return num;
			}
		}
		return num;
	}

	// Token: 0x060015C8 RID: 5576 RVA: 0x0004B5E2 File Offset: 0x000497E2
	public bool IsNeedingInput()
	{
		return this.input.Method12424();
	}

	// Token: 0x060015C9 RID: 5577 RVA: 0x0004B5EF File Offset: 0x000497EF
	public bool IsNeedingDictionary()
	{
		return this.mode == 1 && this.neededBits == 0;
	}

	// Token: 0x060015CA RID: 5578 RVA: 0x0004B605 File Offset: 0x00049805
	public bool IsFinished()
	{
		return this.mode == 12 && this.outputWindow.GetNumber8410_10827() == 0;
	}

	// Token: 0x060015CB RID: 5579 RVA: 0x0004B621 File Offset: 0x00049821
	public int GetAdler()
	{
		if (!this.IsNeedingDictionary())
		{
			return (int)this.adler.GetNumber7041_9089();
		}
		return this.readAdler;
	}

	// Token: 0x060015CC RID: 5580 RVA: 0x0004B63E File Offset: 0x0004983E
	public long GetTotalOut()
	{
		return this.totalOut;
	}

	// Token: 0x060015CD RID: 5581 RVA: 0x0004B646 File Offset: 0x00049846
	public long GetTotalIn()
	{
		return this.totalIn - (long)this.GetRemainingInput();
	}

	// Token: 0x060015CE RID: 5582 RVA: 0x0004B656 File Offset: 0x00049856
	public int GetRemainingInput()
	{
		return this.input.Method12422();
	}

	// Token: 0x04000A41 RID: 2625
	private static readonly int[] lengthBase = new int[]
	{
		3,
		4,
		5,
		6,
		7,
		8,
		9,
		10,
		11,
		13,
		15,
		17,
		19,
		23,
		27,
		31,
		35,
		43,
		51,
		59,
		67,
		83,
		99,
		115,
		131,
		163,
		195,
		227,
		258
	};

	// Token: 0x04000A42 RID: 2626
	private static readonly int[] lengthExtraBits = new int[]
	{
		0,
		0,
		0,
		0,
		0,
		0,
		0,
		0,
		1,
		1,
		1,
		1,
		2,
		2,
		2,
		2,
		3,
		3,
		3,
		3,
		4,
		4,
		4,
		4,
		5,
		5,
		5,
		5,
		0
	};

	// Token: 0x04000A43 RID: 2627
	private static readonly int[] distanceBase = new int[]
	{
		1,
		2,
		3,
		4,
		5,
		7,
		9,
		13,
		17,
		25,
		33,
		49,
		65,
		97,
		129,
		193,
		257,
		385,
		513,
		769,
		1025,
		1537,
		2049,
		3073,
		4097,
		6145,
		8193,
		12289,
		16385,
		24577
	};

	// Token: 0x04000A44 RID: 2628
	private static readonly int[] distanceExtraBits = new int[]
	{
		0,
		0,
		0,
		0,
		1,
		1,
		2,
		2,
		3,
		3,
		4,
		4,
		5,
		5,
		6,
		6,
		7,
		7,
		8,
		8,
		9,
		9,
		10,
		10,
		11,
		11,
		12,
		12,
		13,
		13
	};

	// Token: 0x04000A45 RID: 2629
	private int mode;

	// Token: 0x04000A46 RID: 2630
	private int readAdler;

	// Token: 0x04000A47 RID: 2631
	private int neededBits;

	// Token: 0x04000A48 RID: 2632
	private int repLength;

	// Token: 0x04000A49 RID: 2633
	private int repDist;

	// Token: 0x04000A4A RID: 2634
	private int uncomprLen;

	// Token: 0x04000A4B RID: 2635
	private bool isLastBlock;

	// Token: 0x04000A4C RID: 2636
	private long totalOut;

	// Token: 0x04000A4D RID: 2637
	private long totalIn;

	// Token: 0x04000A4E RID: 2638
	private bool nowrap;

	// Token: 0x04000A4F RID: 2639
	private 769 input;

	// Token: 0x04000A50 RID: 2640
	private 701 outputWindow;

	// Token: 0x04000A51 RID: 2641
	private 449 dynHeader;

	// Token: 0x04000A52 RID: 2642
	private 661 litlenTree;

	// Token: 0x04000A53 RID: 2643
	private 661 distTree;

	// Token: 0x04000A54 RID: 2644
	private 629 adler;
}
