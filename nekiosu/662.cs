using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

// Token: 0x0200018D RID: 397
[ComVisible(false)]
[241(0)]
[242(1)]
public sealed class 662 : 585
{
	// Token: 0x06000CC0 RID: 3264 RVA: 0x0002D74E File Offset: 0x0002B94E
	public 662(object 1)
	{
		756.Method12216(1, "attributeProvider");
		this.value2 = 1;
	}

	// Token: 0x06000CC1 RID: 3265 RVA: 0x0002D768 File Offset: 0x0002B968
	public IList<Attribute> Method98162(bool 1)
	{
		return 143.Method3913(this.value2, null, 1);
	}

	// Token: 0x06000CC2 RID: 3266 RVA: 0x0002D777 File Offset: 0x0002B977
	public IList<Attribute> Method98162(Type 1, bool 2)
	{
		return 143.Method3913(this.value2, 1, 2);
	}

	// Token: 0x0400063F RID: 1599
	private readonly object value2;
}
