using System;
using System.Runtime.InteropServices;
using System.Security;

// Token: 0x02000C25 RID: 3109
public static class 1173
{
	// Token: 0x06005437 RID: 21559
	[SuppressUnmanagedCodeSecurity]
	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	internal static extern IntPtr SendMessage(IntPtr 1, uint 2, IntPtr 3, IntPtr 4);

	// Token: 0x06005438 RID: 21560
	[SuppressUnmanagedCodeSecurity]
	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	internal static extern bool PostMessage(IntPtr 1, uint 2, long 3, long 4);

	// Token: 0x06005439 RID: 21561
	[SuppressUnmanagedCodeSecurity]
	[DllImport("user32.dll")]
	private static extern IntPtr FindWindowExA(IntPtr 1, IntPtr 2, string 3, string 4);

	// Token: 0x0600543A RID: 21562 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal static void 1(bool 1, string 2, string 3, string 4, string 5)
	{
	}

	// Token: 0x0600543B RID: 21563 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal static void 2(bool 1, string 2, string 3, string 4, string 5)
	{
	}

	// Token: 0x0600543C RID: 21564 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal static void 3(bool 1, string 2, string 3, string 4, string 5)
	{
	}

	// Token: 0x02000C26 RID: 3110
	public struct 1174
	{
		// Token: 0x04004050 RID: 16464
		public IntPtr 1;

		// Token: 0x04004051 RID: 16465
		public int 2;

		// Token: 0x04004052 RID: 16466
		public IntPtr 3;
	}
}
