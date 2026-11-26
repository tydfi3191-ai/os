using System;
using System.Runtime.InteropServices;

// Token: 0x020000F5 RID: 245
[ComVisible(false)]
public abstract class 601 : 214
{
	// Token: 0x06000874 RID: 2164 RVA: 0x0001CC88 File Offset: 0x0001AE88
	[242(1)]
	public override bool CanConvert(Type 1)
	{
		return 1 == typeof(DateTime) || 1 == typeof(DateTime?) || (1 == typeof(DateTimeOffset) || 1 == typeof(DateTimeOffset?));
	}
}
