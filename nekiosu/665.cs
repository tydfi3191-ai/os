using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

// Token: 0x0200018F RID: 399
[ComVisible(false)]
[242(1)]
public interface 665
{
	// Token: 0x06000CC9 RID: 3273
	TraceLevel GetLevelFilter();

	// Token: 0x06000CCA RID: 3274
	void WriteTrace(TraceLevel 1, string 2, [241(2)] Exception 3);
}
