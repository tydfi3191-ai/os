using System;
using System.IO;
using System.Runtime.InteropServices;

// Token: 0x02000B3D RID: 2877
[ComVisible(false)]
public sealed class 1325 : 790
{
	// Token: 0x06004F6E RID: 20334 RVA: 0x001F5BA4 File Offset: 0x001F3DA4
	public 1325(string 1)
	{
		this.1 = 1;
	}

	// Token: 0x06004F6F RID: 20335 RVA: 0x001F5BB3 File Offset: 0x001F3DB3
	public Stream OpenStream()
	{
		return File.Open(this.1, FileMode.Open, FileAccess.Read, FileShare.Read);
	}

	// Token: 0x04003B6C RID: 15212
	private string 1;
}
