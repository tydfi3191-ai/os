using System;
using System.Collections.Generic;

// Token: 0x02000802 RID: 2050
[276]
public abstract class 2037
{
	// Token: 0x06003B72 RID: 15218 RVA: 0x00175D29 File Offset: 0x00173F29
	internal 2037(2039 1)
	{
		this.1 = 1;
	}

	// Token: 0x06003B73 RID: 15219 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal virtual void ResetState()
	{
	}

	// Token: 0x06003B74 RID: 15220
	internal abstract 2072 CreateCircle(208 1, int 2, bool 3, 1245 4, int 5, 1254 6, 1254 7, 1253 8, int 9, string 10);

	// Token: 0x06003B75 RID: 15221
	internal abstract 2063 CreateSlider(208 1, int 2, bool 3, 1245 4, 2064 5, int 6, double 7, List<208> 8, List<1245> 9, int 10, 1254 11, 1254 12, List<1254> 13, List<1254> 14, 1253 15, int 16, string 17);

	// Token: 0x06003B76 RID: 15222
	internal abstract 2070 CreateSpinner(int 1, int 2, 1245 3, 1254 4, 1254 5, 1253 6, int 7, string 8);

	// Token: 0x06003B77 RID: 15223
	internal abstract 2072 CreateHold(208 1, int 2, int 3, bool 4, 1245 5, int 6, 1254 7, 1254 8, 1253 9, int 10, string 11);

	// Token: 0x04002BF9 RID: 11257
	protected readonly 2039 1;
}
