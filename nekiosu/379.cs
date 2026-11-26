using System;
using System.IO;
using System.Runtime.InteropServices;

// Token: 0x020002E2 RID: 738
[ComVisible(false)]
public sealed class 379 : 571
{
	// Token: 0x06001615 RID: 5653 RVA: 0x0004C440 File Offset: 0x0004A640
	public Stream Method2040(783 1, string 2)
	{
		Stream result = null;
		if (2 != null)
		{
			result = File.Open(2, FileMode.Open, FileAccess.Read, FileShare.Read);
		}
		return result;
	}
}
