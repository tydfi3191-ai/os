using System;
using System.Runtime.InteropServices;

// Token: 0x020001F6 RID: 502
[ComVisible(false)]
public sealed class 755 : 136
{
	// Token: 0x06000FE9 RID: 4073 RVA: 0x0000D7A1 File Offset: 0x0000B9A1
	public 755(bool 1, bool 2)
	{
		base.SetProcessDictionaryKeys(1);
		base.SetOverrideSpecifiedNames(2);
	}

	// Token: 0x06000FEA RID: 4074 RVA: 0x000362AB File Offset: 0x000344AB
	public 755(bool 1, bool 2, bool 3) : this(1, 2)
	{
		base.SetProcessExtensionDataNames(3);
	}

	// Token: 0x06000FEB RID: 4075 RVA: 0x0000D7C8 File Offset: 0x0000B9C8
	public 755()
	{
	}

	// Token: 0x06000FEC RID: 4076 RVA: 0x000362BC File Offset: 0x000344BC
	[242(1)]
	protected override string Method12215(string 1)
	{
		return 538.Method6834(1);
	}
}
