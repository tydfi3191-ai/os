using System;
using System.Collections.Generic;
using System.IO;

// Token: 0x02000B6F RID: 2927
public sealed class 1271
{
	// Token: 0x060050BC RID: 20668 RVA: 0x001FEF3C File Offset: 0x001FD13C
	internal 1271(string 1, 1271 2)
	{
		string[] array = 1.Split(new char[]
		{
			Path.DirectorySeparatorChar
		});
		this.4 = array[array.Length - 1];
		this.5 = 1;
		this.2 = new List<1271>();
		this.1 = new List<1262>();
		this.6 = 2;
		1271 3 = this;
		while (3.6 != null)
		{
			this.3++;
			3 = 3.6;
		}
	}

	// Token: 0x04003D43 RID: 15683
	internal List<1262> 1;

	// Token: 0x04003D44 RID: 15684
	internal List<1271> 2;

	// Token: 0x04003D45 RID: 15685
	internal int 3;

	// Token: 0x04003D46 RID: 15686
	internal string 4;

	// Token: 0x04003D47 RID: 15687
	internal string 5;

	// Token: 0x04003D48 RID: 15688
	internal 1271 6;
}
