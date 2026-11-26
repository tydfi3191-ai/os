using System;
using System.Collections.Generic;

// Token: 0x020006E1 RID: 1761
public sealed class 2183 : 2037
{
	// Token: 0x0600344F RID: 13391 RVA: 0x001411FE File Offset: 0x0013F3FE
	public 2183(2039 1) : base(1)
	{
	}

	// Token: 0x06003450 RID: 13392 RVA: 0x00141208 File Offset: 0x0013F408
	internal override 2072 CreateCircle(208 1, int 2, bool 3, 1245 4, int 5, 1254 6, 1254 7, 1253 8, int 9, string 10)
	{
		1259 11 = this.1.21.92((double)(2 + 5));
		bool 12 = 11 != null && 11.3();
		return new 2181(this.1, 1, 2, 3, this.1.9(4), 12);
	}

	// Token: 0x06003451 RID: 13393 RVA: 0x00141254 File Offset: 0x0013F454
	internal override 2063 CreateSlider(208 1, int 2, bool 3, 1245 4, 2064 5, int 6, double 7, List<208> 8, List<1245> 9, int 10, 1254 11, 1254 12, List<1254> 13, List<1254> 14, 1253 15, int 16, string 17)
	{
		1259 18 = this.1.21.92((double)(2 + 5));
		bool 19 = 18 != null && 18.3();
		return new 2178(this.1, 1, 2, 3, 4, 5, 6, 7, 8, 9, 19);
	}

	// Token: 0x06003452 RID: 13394 RVA: 0x0014129D File Offset: 0x0013F49D
	internal override 2070 CreateSpinner(int 1, int 2, 1245 3, 1254 4, 1254 5, 1253 6, int 7, string 8)
	{
		return new 2185(this.1, 1, 2, 3);
	}

	// Token: 0x06003453 RID: 13395 RVA: 0x00009D1A File Offset: 0x00007F1A
	internal override 2072 CreateHold(208 1, int 2, int 3, bool 4, 1245 5, int 6, 1254 7, 1254 8, 1253 9, int 10, string 11)
	{
		return null;
	}
}
