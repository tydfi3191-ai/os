using System;
using System.Runtime.InteropServices;

// Token: 0x02000409 RID: 1033
internal static class 260
{
	// Token: 0x06002068 RID: 8296
	[DllImport("kernel32.dll")]
	internal static extern IntPtr GetCurrentProcess();

	// Token: 0x06002069 RID: 8297
	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern bool CloseHandle(IntPtr 1);

	// Token: 0x0600206A RID: 8298
	[DllImport("advapi32.dll", SetLastError = true)]
	internal static extern bool OpenProcessToken(IntPtr 1, uint 2, out IntPtr 3);

	// Token: 0x0600206B RID: 8299
	[DllImport("advapi32.dll", SetLastError = true)]
	internal static extern bool GetTokenInformation(IntPtr 1, int 2, IntPtr 3, int 4, out int 5);

	// Token: 0x0600206C RID: 8300
	[DllImport("advapi32.dll")]
	internal static extern bool EqualSid(IntPtr 1, IntPtr 2);

	// Token: 0x0600206D RID: 8301
	[DllImport("FirewallAPI.dll")]
	internal static extern uint NetworkIsolationGetAppContainerConfig(out uint 1, out IntPtr 2);

	// Token: 0x0600206E RID: 8302
	[DllImport("kernel32.dll")]
	internal static extern IntPtr GetProcessHeap();

	// Token: 0x0600206F RID: 8303
	[DllImport("kernel32.dll")]
	internal static extern bool HeapFree(IntPtr 1, uint 2, IntPtr 3);
}
