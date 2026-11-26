using System;
using System.Runtime.InteropServices;

// Token: 0x020000AD RID: 173
[ComVisible(false)]
public sealed class 128 : 136
{
	// Token: 0x06000456 RID: 1110 RVA: 0x0000D7A1 File Offset: 0x0000B9A1
	public 128(bool 1, bool 2)
	{
		base.SetProcessDictionaryKeys(1);
		base.SetOverrideSpecifiedNames(2);
	}

	// Token: 0x06000457 RID: 1111 RVA: 0x0000D7B7 File Offset: 0x0000B9B7
	public 128(bool 1, bool 2, bool 3) : this(1, 2)
	{
		base.SetProcessExtensionDataNames(3);
	}

	// Token: 0x06000458 RID: 1112 RVA: 0x0000D7C8 File Offset: 0x0000B9C8
	public 128()
	{
	}

	// Token: 0x06000459 RID: 1113 RVA: 0x0000D7D0 File Offset: 0x0000B9D0
	[242(1)]
	protected override string Method12215(string 1)
	{
		return 538.Method6837(1);
	}
}
