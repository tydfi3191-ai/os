using System;

// Token: 0x020001B3 RID: 435
[241(0)]
[107]
[242(1)]
public struct 743
{
	// Token: 0x170000C4 RID: 196
	public char this[int 1]
	{
		get
		{
			return this.charArray2[1];
		}
	}

	// Token: 0x06000E00 RID: 3584 RVA: 0x0002FE16 File Offset: 0x0002E016
	public 743(char[] 1, int 2, int 3)
	{
		this.charArray2 = 1;
		this.number3 = 2;
		this.number4 = 3;
	}

	// Token: 0x06000E01 RID: 3585 RVA: 0x0002FE2D File Offset: 0x0002E02D
	public char[] GetCharArray9358_11931()
	{
		return this.charArray2;
	}

	// Token: 0x06000E02 RID: 3586 RVA: 0x0002FE35 File Offset: 0x0002E035
	public int GetNumber9359_11932()
	{
		return this.number3;
	}

	// Token: 0x06000E03 RID: 3587 RVA: 0x0002FE3D File Offset: 0x0002E03D
	public int GetNumber9360_11933()
	{
		return this.number4;
	}

	// Token: 0x06000E04 RID: 3588 RVA: 0x0002FE45 File Offset: 0x0002E045
	public override string ToString()
	{
		return new string(this.charArray2, this.number3, this.number4);
	}

	// Token: 0x040006D7 RID: 1751
	private readonly char[] charArray2;

	// Token: 0x040006D8 RID: 1752
	private readonly int number3;

	// Token: 0x040006D9 RID: 1753
	private readonly int number4;
}
