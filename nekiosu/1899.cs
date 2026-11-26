using System;
using System.Collections.Generic;

// Token: 0x02000855 RID: 2133
public sealed class 1899
{
	// Token: 0x06003DEA RID: 15850 RVA: 0x00184E76 File Offset: 0x00183076
	public 1919 1()
	{
		return this.1[0].2();
	}

	// Token: 0x06003DEB RID: 15851 RVA: 0x00184E8C File Offset: 0x0018308C
	public bool 2(1899 1)
	{
		if (this.3(1) && 1.1.Count == this.1.Count)
		{
			1887? 2 = 1.1[0].4();
			1887? 3 = this.1[0].4();
			return 2.GetValueOrDefault() == 3.GetValueOrDefault() & 2 != null == (3 != null);
		}
		return false;
	}

	// Token: 0x06003DEC RID: 15852 RVA: 0x00184F01 File Offset: 0x00183101
	public bool 3(1899 1)
	{
		return 1.1[0].6() == this.1[0].6();
	}

	// Token: 0x04002D66 RID: 11622
	public readonly List<1886> 1 = new List<1886>();

	// Token: 0x04002D67 RID: 11623
	public 1902 2;

	// Token: 0x04002D68 RID: 11624
	public int 3;
}
