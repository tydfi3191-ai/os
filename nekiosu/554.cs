using System;
using System.Runtime.InteropServices;

// Token: 0x0200015D RID: 349
[ComVisible(false)]
public sealed class 554
{
	// Token: 0x06000BFC RID: 3068 RVA: 0x0002B572 File Offset: 0x00029772
	public 554()
	{
		this._recoveredType20645744 = (725)1;
		this._recoveredType15785743 = (611)0;
		this._recoveredType19705745 = (704)0;
	}

	// Token: 0x06000BFD RID: 3069 RVA: 0x0002B58F File Offset: 0x0002978F
	public 611 GetRecoveredType15785743_7441()
	{
		return this._recoveredType15785743;
	}

	// Token: 0x06000BFE RID: 3070 RVA: 0x0002B597 File Offset: 0x00029797
	public void Method7442(611 1)
	{
		if (1 < (611)0 || 1 > (611)1)
		{
			throw new ArgumentOutOfRangeException("value");
		}
		this._recoveredType15785743 = 1;
	}

	// Token: 0x06000BFF RID: 3071 RVA: 0x0002B5B3 File Offset: 0x000297B3
	public 725 GetRecoveredType20645744_7443()
	{
		return this._recoveredType20645744;
	}

	// Token: 0x06000C00 RID: 3072 RVA: 0x0002B5BB File Offset: 0x000297BB
	public void Method7444(725 1)
	{
		if (1 < (725)0 || 1 > (725)1)
		{
			throw new ArgumentOutOfRangeException("value");
		}
		this._recoveredType20645744 = 1;
	}

	// Token: 0x06000C01 RID: 3073 RVA: 0x0002B5D7 File Offset: 0x000297D7
	public 704 GetRecoveredType19705745_7445()
	{
		return this._recoveredType19705745;
	}

	// Token: 0x06000C02 RID: 3074 RVA: 0x0002B5DF File Offset: 0x000297DF
	public void Method7446(704 1)
	{
		if (1 < (704)0 || 1 > (704)2)
		{
			throw new ArgumentOutOfRangeException("value");
		}
		this._recoveredType19705745 = 1;
	}

	// Token: 0x040005E7 RID: 1511
	private 611 _recoveredType15785743;

	// Token: 0x040005E8 RID: 1512
	private 725 _recoveredType20645744;

	// Token: 0x040005E9 RID: 1513
	private 704 _recoveredType19705745;
}
