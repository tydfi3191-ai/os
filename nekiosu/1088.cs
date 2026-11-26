using System;
using System.Drawing;
using System.Runtime.InteropServices;

// Token: 0x02000C3C RID: 3132
[ComVisible(false)]
public static class 1088
{
	// Token: 0x06005473 RID: 21619
	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool GetCursorPos(out 1088.1089 1);

	// Token: 0x06005474 RID: 21620
	[DllImport("user32.dll")]
	private static extern short GetAsyncKeyState(int 1);

	// Token: 0x06005475 RID: 21621
	[DllImport("user32.dll")]
	private static extern bool ScreenToClient(IntPtr 1, ref 1088.1089 2);

	// Token: 0x06005476 RID: 21622
	[DllImport("user32.dll")]
	private static extern bool ClientToScreen(IntPtr 1, ref 1088.1089 2);

	// Token: 0x06005477 RID: 21623
	[DllImport("user32.dll")]
	private static extern bool SetCursorPos(int 1, int 2);

	// Token: 0x06005478 RID: 21624 RVA: 0x0020C38F File Offset: 0x0020A58F
	public static void 1(IntPtr 1)
	{
		if (1088.2 != 1)
		{
			1088.2 = 1;
		}
	}

	// Token: 0x040040C8 RID: 16584
	internal static object 1 = new object();

	// Token: 0x040040C9 RID: 16585
	internal static IntPtr 2;

	// Token: 0x02000C3D RID: 3133
	public struct 1089
	{
		// Token: 0x0600547A RID: 21626 RVA: 0x0020C3B0 File Offset: 0x0020A5B0
		public 1089(int 1, int 2)
		{
			this.1 = 1;
			this.2 = 2;
		}

		// Token: 0x0600547B RID: 21627 RVA: 0x0020C3C0 File Offset: 0x0020A5C0
		public 1089(Point 1)
		{
			this = new 1088.1089(1.X, 1.Y);
		}

		// Token: 0x0600547C RID: 21628 RVA: 0x0020C3D6 File Offset: 0x0020A5D6
		public static implicit operator Point(1088.1089 1)
		{
			return new Point(1.1, 1.2);
		}

		// Token: 0x0600547D RID: 21629 RVA: 0x0020C3E9 File Offset: 0x0020A5E9
		public static implicit operator 1088.1089(Point 1)
		{
			return new 1088.1089(1.X, 1.Y);
		}

		// Token: 0x040040CA RID: 16586
		public int 1;

		// Token: 0x040040CB RID: 16587
		public int 2;
	}
}
