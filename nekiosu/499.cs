using System;
using System.Runtime.InteropServices;

// Token: 0x020001F1 RID: 497
[ComVisible(false)]
public sealed class 499 : 136
{
	// Token: 0x06000FC6 RID: 4038 RVA: 0x0000D7A1 File Offset: 0x0000B9A1
	public 499(bool 1, bool 2)
	{
		base.SetProcessDictionaryKeys(1);
		base.SetOverrideSpecifiedNames(2);
	}

	// Token: 0x06000FC7 RID: 4039 RVA: 0x00036032 File Offset: 0x00034232
	public 499(bool 1, bool 2, bool 3) : this(1, 2)
	{
		base.SetProcessExtensionDataNames(3);
	}

	// Token: 0x06000FC8 RID: 4040 RVA: 0x0000D7C8 File Offset: 0x0000B9C8
	public 499()
	{
	}

	// Token: 0x06000FC9 RID: 4041 RVA: 0x00036043 File Offset: 0x00034243
	[242(1)]
	protected override string Method12215(string 1)
	{
		return 538.Method6836(1);
	}
}
