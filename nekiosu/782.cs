using System;
using System.Runtime.InteropServices;

// Token: 0x02000323 RID: 803
[ComVisible(false)]
public sealed class 782 : EventArgs
{
	// Token: 0x06001836 RID: 6198 RVA: 0x0005569D File Offset: 0x0005389D
	public 782(string 1, Exception 2)
	{
		this.text2 = 1;
		this.exception2 = 2;
		this.flag2 = true;
	}

	// Token: 0x06001837 RID: 6199 RVA: 0x000556BA File Offset: 0x000538BA
	public string GetText9990_12765()
	{
		return this.text2;
	}

	// Token: 0x06001838 RID: 6200 RVA: 0x000556C2 File Offset: 0x000538C2
	public Exception GetException9991_12766()
	{
		return this.exception2;
	}

	// Token: 0x06001839 RID: 6201 RVA: 0x000556CA File Offset: 0x000538CA
	public bool GetFlag9992_12767()
	{
		return this.flag2;
	}

	// Token: 0x0600183A RID: 6202 RVA: 0x000556D2 File Offset: 0x000538D2
	public void SetFlag9992_12768(bool 1)
	{
		this.flag2 = 1;
	}

	// Token: 0x04000B57 RID: 2903
	private string text2;

	// Token: 0x04000B58 RID: 2904
	private Exception exception2;

	// Token: 0x04000B59 RID: 2905
	private bool flag2;
}
