using System;
using System.Runtime.InteropServices;

// Token: 0x020003C6 RID: 966
[ComVisible(false)]
[StructLayout(LayoutKind.Sequential)]
public sealed class 937
{
	// Token: 0x06001ECD RID: 7885 RVA: 0x0007830C File Offset: 0x0007650C
	public 937()
	{
		this.name = string.Empty;
		this.exts = string.Empty;
	}

	// Token: 0x06001ECE RID: 7886 RVA: 0x0007832A File Offset: 0x0007652A
	public 937(string 1, string 2, 935 3)
	{
		this.name = string.Empty;
		this.exts = string.Empty;
		this.ctype = 3;
		this.name = 1;
		this.exts = 2;
	}

	// Token: 0x06001ECF RID: 7887 RVA: 0x0007835D File Offset: 0x0007655D
	public override string ToString()
	{
		return string.Format("{0}|{1}", this.name, this.exts);
	}

	// Token: 0x04000F37 RID: 3895
	public 935 ctype;

	// Token: 0x04000F38 RID: 3896
	[MarshalAs(UnmanagedType.LPStr)]
	public string name;

	// Token: 0x04000F39 RID: 3897
	[MarshalAs(UnmanagedType.LPStr)]
	public string exts;
}
