using System;
using System.Runtime.InteropServices;

// Token: 0x02000C10 RID: 3088
public sealed class 1152
{
	// Token: 0x06005403 RID: 21507
	[DllImport("user32.dll", CharSet = CharSet.Ansi)]
	private static extern int SetWindowsHookExA(int 1, 1152.1154 2, IntPtr 3, int 4);

	// Token: 0x06005404 RID: 21508
	[DllImport("user32.dll")]
	private static extern int UnhookWindowsHookEx(int 1);

	// Token: 0x06005405 RID: 21509
	[DllImport("user32.dll", CharSet = CharSet.Ansi)]
	private static extern int CallNextHookEx(int 1, int 2, int 3, ref 1152.1153 4);

	// Token: 0x04003FA9 RID: 16297
	internal static bool 1;

	// Token: 0x04003FAA RID: 16298
	private static int 2;

	// Token: 0x02000C11 RID: 3089
	// (Invoke) Token: 0x06005408 RID: 21512
	public delegate int 1154(int 1, int 2, ref 1152.1153 3);

	// Token: 0x02000C12 RID: 3090
	public struct 1153
	{
		// Token: 0x04003FAB RID: 16299
		public int 1;

		// Token: 0x04003FAC RID: 16300
		private int 2;

		// Token: 0x04003FAD RID: 16301
		public int 3;

		// Token: 0x04003FAE RID: 16302
		private int 4;

		// Token: 0x04003FAF RID: 16303
		private int 5;
	}
}
