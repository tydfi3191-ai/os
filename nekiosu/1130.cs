using System;
using System.Runtime.InteropServices;

// Token: 0x02000BF4 RID: 3060
[ComVisible(false)]
public sealed class 1130 : Exception
{
	// Token: 0x1700032A RID: 810
	// (get) Token: 0x06005387 RID: 21383 RVA: 0x0020B285 File Offset: 0x00209485
	public override string Message
	{
		get
		{
			return string.Format("Missing .NET Framework version required to continue ({0})", this.1);
		}
	}

	// Token: 0x06005388 RID: 21384 RVA: 0x0020B29C File Offset: 0x0020949C
	public 1130(1121 1)
	{
		this.1 = 1;
	}

	// Token: 0x04003F6F RID: 16239
	public 1121 1;
}
