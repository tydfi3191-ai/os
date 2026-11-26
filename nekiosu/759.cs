using System;
using System.Runtime.InteropServices;

// Token: 0x0200031C RID: 796
[ComVisible(false)]
public class 759 : EventArgs
{
	// Token: 0x06001800 RID: 6144 RVA: 0x00054356 File Offset: 0x00052556
	public 759(string 1)
	{
		this.text2 = 1;
	}

	// Token: 0x06001801 RID: 6145 RVA: 0x0005436C File Offset: 0x0005256C
	public string GetText9562_12245()
	{
		return this.text2;
	}

	// Token: 0x06001802 RID: 6146 RVA: 0x00054374 File Offset: 0x00052574
	public bool GetFlag9563_12246()
	{
		return this.flag3;
	}

	// Token: 0x06001803 RID: 6147 RVA: 0x0005437C File Offset: 0x0005257C
	public void SetFlag9563_12247(bool 1)
	{
		this.flag3 = 1;
	}

	// Token: 0x04000B34 RID: 2868
	private string text2;

	// Token: 0x04000B35 RID: 2869
	private bool flag3 = true;
}
