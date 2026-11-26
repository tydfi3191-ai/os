using System;
using System.Collections.Generic;

// Token: 0x02000713 RID: 1811
[276]
public sealed class 2121 : 2037
{
	// Token: 0x06003561 RID: 13665 RVA: 0x001411FE File Offset: 0x0013F3FE
	public 2121(2039 1) : base(1)
	{
	}

	// Token: 0x06003562 RID: 13666 RVA: 0x0014A3C7 File Offset: 0x001485C7
	internal override 2072 CreateCircle(208 1, int 2, bool 3, 1245 4, int 5, 1254 6, 1254 7, 1253 8, int 9, string 10)
	{
		2033 11 = new 2033(this.1, 1, 2, 3, 4, 5);
		11.35 = 6;
		11.36 = 7;
		11.37 = 8;
		11.34 = 9;
		11.6(10);
		return 11;
	}

	// Token: 0x06003563 RID: 13667 RVA: 0x0014A404 File Offset: 0x00148604
	internal override 2063 CreateSlider(208 1, int 2, bool 3, 1245 4, 2064 5, int 6, double 7, List<208> 8, List<1245> 9, int 10, 1254 11, 1254 12, List<1254> 13, List<1254> 14, 1253 15, int 16, string 17)
	{
		2123 18 = new 2123(this.1, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10)
		{
			35 = 11,
			36 = 12,
			85 = 13,
			86 = 14,
			37 = 15,
			34 = 16
		};
		18.6(17);
		if (18.58 != null)
		{
			1244 19 = 18.43(0);
			18.58.35 = 19.2;
			18.58.36 = 19.3;
		}
		return 18;
	}

	// Token: 0x06003564 RID: 13668 RVA: 0x0014A499 File Offset: 0x00148699
	internal override 2070 CreateSpinner(int 1, int 2, 1245 3, 1254 4, 1254 5, 1253 6, int 7, string 8)
	{
		2129 9 = new 2129(this.1, 1, 2, 3);
		9.35 = 4;
		9.36 = 5;
		9.37 = 6;
		9.34 = 7;
		9.6(8);
		return 9;
	}

	// Token: 0x06003565 RID: 13669 RVA: 0x0014A4D4 File Offset: 0x001486D4
	internal override 2072 CreateHold(208 1, int 2, int 3, bool 4, 1245 5, int 6, 1254 7, 1254 8, 1253 9, int 10, string 11)
	{
		2048 12 = new 2048(this.1, 1, 2, 4, 5, 0);
		12.35 = 7;
		12.36 = 8;
		12.37 = 9;
		12.2 = 3;
		12.34 = 10;
		12.6(11);
		return 12;
	}
}
