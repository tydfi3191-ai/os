using System;
using System.IO;
using System.Runtime.InteropServices;

// Token: 0x020009B1 RID: 2481
[ComVisible(false)]
public sealed class 1620 : 1621
{
	// Token: 0x06004589 RID: 17801 RVA: 0x001B5C48 File Offset: 0x001B3E48
	public 1620(string 1, string 2) : base(2, Array.Empty<object>())
	{
		this.idleTimeoutMs *= 2;
		this.filePath = 1;
	}

	// Token: 0x0600458A RID: 17802 RVA: 0x001B5C6C File Offset: 0x001B3E6C
	protected override Stream CreateResponseStream()
	{
		string directoryName = Path.GetDirectoryName(this.filePath);
		if (!string.IsNullOrEmpty(directoryName))
		{
			Directory.CreateDirectory(directoryName);
		}
		return new FileStream(this.filePath, FileMode.Create, FileAccess.Write, FileShare.Write, 32768);
	}

	// Token: 0x0600458B RID: 17803 RVA: 0x001B5CA7 File Offset: 0x001B3EA7
	protected override void Finish(Exception 1 = null)
	{
		Stream responseStream = this.responseStream;
		if (responseStream != null)
		{
			responseStream.Close();
		}
		if (1 != null)
		{
			2672.20(this.filePath);
		}
		base.Finish(1);
	}

	// Token: 0x040032E9 RID: 13033
	public string filePath;
}
