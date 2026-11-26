using System;
using System.Threading;

// Token: 0x02000AAF RID: 2735
public class 1413 : 1433
{
	// Token: 0x06004BE2 RID: 19426 RVA: 0x001DFFC8 File Offset: 0x001DE1C8
	internal 1413(1381 1, 1376 2, 1065 3, 1044 4, 208 5) : base(1, 2, 3, 4, 5)
	{
	}

	// Token: 0x06004BE3 RID: 19427 RVA: 0x001DFFD7 File Offset: 0x001DE1D7
	internal 1413(1381 1, 1065 2, 208 3, float 4, bool 5, 198 6) : base(1, 2, 3, 4, 5, 6)
	{
	}

	// Token: 0x06004BE4 RID: 19428 RVA: 0x001DFFE8 File Offset: 0x001DE1E8
	internal 1413(1381 1, 208 2, float 3, bool 4, 198 5) : base(1, 2, 3, 4, 5)
	{
	}

	// Token: 0x06004BE5 RID: 19429 RVA: 0x001DFFF8 File Offset: 0x001DE1F8
	internal 1413(1381 1, 1376 2, 1065 3, 1044 4, 208 5, float 6, bool 7, 198 8) : base(1, 2, 3, 4, 5, 6, 7, 8, null)
	{
	}

	// Token: 0x06004BE6 RID: 19430 RVA: 0x001E001C File Offset: 0x001DE21C
	internal 1413(1381 1, 1376 2, 1065 3, 1044 4, 208 5, float 6, bool 7, 198 8, object 9) : base(1, 2, 3, 4, 5, 6, 7, 8, 9)
	{
	}

	// Token: 0x06004BE7 RID: 19431 RVA: 0x001E0040 File Offset: 0x001DE240
	internal new void 49(1189 1)
	{
		1189 2 = this.70;
		1189 3;
		do
		{
			3 = 2;
			1189 value = (1189)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1189>(ref this.70, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06004BE8 RID: 19432 RVA: 0x001E0075 File Offset: 0x001DE275
	internal new bool 50()
	{
		return this.47 != null && 1662.33 - this.47.4 > 5000 && this.51();
	}

	// Token: 0x06004BE9 RID: 19433 RVA: 0x001E009F File Offset: 0x001DE29F
	internal bool 51()
	{
		if (this.47 == null)
		{
			return false;
		}
		this.47.Dispose();
		this.47 = null;
		this.71 = (1484)0;
		if (this.70 != null)
		{
			this.70();
		}
		return true;
	}

	// Token: 0x0400387E RID: 14462
	private 1189 70;

	// Token: 0x0400387F RID: 14463
	internal 1484 71;
}
