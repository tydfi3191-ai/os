using System;
using System.Runtime.InteropServices;

// Token: 0x020002FB RID: 763
[ComVisible(false)]
public sealed class 565 : 759
{
	// Token: 0x060016EA RID: 5866 RVA: 0x0004F6C2 File Offset: 0x0004D8C2
	public 565(string 1, bool 2) : base(1)
	{
		this.flag2 = 2;
	}

	// Token: 0x060016EB RID: 5867 RVA: 0x0004F6D2 File Offset: 0x0004D8D2
	public bool GetFlag6029_7765()
	{
		return this.flag2;
	}

	// Token: 0x04000ACF RID: 2767
	private bool flag2;
}
