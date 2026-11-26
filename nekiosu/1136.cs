using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

// Token: 0x02000BFA RID: 3066
public static class 1136
{
	// Token: 0x060053A0 RID: 21408
	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern IntPtr GetProcAddress(IntPtr 1, string 2);

	// Token: 0x060053A1 RID: 21409
	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr GetModuleHandle(string 1);

	// Token: 0x060053A2 RID: 21410
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool AllocConsole();

	// Token: 0x060053A3 RID: 21411
	[DllImport("user32.dll")]
	public static extern bool RegisterTouchWindow(IntPtr 1, int 2);

	// Token: 0x060053A4 RID: 21412
	[DllImport("kernel32.dll")]
	internal static extern ushort GlobalAddAtom(string 1);

	// Token: 0x060053A5 RID: 21413
	[DllImport("kernel32.dll")]
	internal static extern ushort GlobalDeleteAtom(ushort 1);

	// Token: 0x060053A6 RID: 21414
	[DllImport("user32.dll")]
	internal static extern int SetProp(IntPtr 1, string 2, int 3);

	// Token: 0x060053A7 RID: 21415
	[DllImport("user32.dll")]
	internal static extern int RemoveProp(IntPtr 1, string 2);

	// Token: 0x060053A8 RID: 21416
	[DllImport("user32.dll")]
	public static extern int GetSystemMetrics(int 1);

	// Token: 0x060053A9 RID: 21417
	[DllImport("user32.dll")]
	public static extern bool RegisterRawInputDevices([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] 1095[] 1, int 2, int 3);

	// Token: 0x060053AA RID: 21418
	[DllImport("user32.dll")]
	public static extern bool GetTouchInputInfo(IntPtr 1, int 2, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] [Out] 1169[] 3, int 4);

	// Token: 0x060053AB RID: 21419
	[DllImport("user32.dll")]
	public static extern bool CloseTouchInputHandle(IntPtr 1);

	// Token: 0x060053AC RID: 21420
	[DllImport("user32.dll")]
	public static extern int GetRawInputData(IntPtr 1, 1134 2, out 1099 3, ref int 4, int 5);

	// Token: 0x060053AD RID: 21421
	[DllImport("user32.dll")]
	public static extern bool GetPointerInfo(int 1, out 1092 2);

	// Token: 0x060053AE RID: 21422
	[DllImport("user32.dll", SetLastError = true)]
	private static extern int SetWindowLong(IntPtr 1, 1136.1140 2, int 3);

	// Token: 0x060053AF RID: 21423
	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr SetWindowLongPtr(IntPtr 1, 1136.1140 2, IntPtr 3);

	// Token: 0x060053B0 RID: 21424
	[DllImport("user32.dll")]
	public static extern long GetWindowLong(IntPtr 1, 1136.1140 2);

	// Token: 0x060053B1 RID: 21425
	[DllImport("user32.dll")]
	public static extern int SetWindowPos(IntPtr 1, IntPtr 2, int 3, int 4, int 5, int 6, int 7);

	// Token: 0x060053B2 RID: 21426
	[DllImport("kernel32.dll")]
	public static extern uint SetThreadExecutionState(1136.1139 1);

	// Token: 0x060053B3 RID: 21427
	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetDiskFreeSpaceEx(string 1, out ulong 2, out ulong 3, out ulong 4);

	// Token: 0x02000BFB RID: 3067
	public static class 1137
	{
		// Token: 0x060053B4 RID: 21428 RVA: 0x0020B55D File Offset: 0x0020975D
		internal static 207 1()
		{
			return new 207(1136.GetSystemMetrics(76), 1136.GetSystemMetrics(77), 1136.GetSystemMetrics(78), 1136.GetSystemMetrics(79));
		}

		// Token: 0x02000BFC RID: 3068
		public sealed class 1138 : NativeWindow
		{
			// Token: 0x060053B5 RID: 21429 RVA: 0x0020B580 File Offset: 0x00209780
			internal 1138(IntPtr 1)
			{
				base.AssignHandle(1);
			}

			// Token: 0x060053B6 RID: 21430 RVA: 0x0020B590 File Offset: 0x00209790
			internal void 1(1171 1)
			{
				1171 2 = this.1;
				1171 3;
				do
				{
					3 = 2;
					1171 value = (1171)Delegate.Combine(3, 1);
					2 = Interlocked.CompareExchange<1171>(ref this.1, value, 3);
				}
				while (2 != 3);
			}

			// Token: 0x060053B7 RID: 21431 RVA: 0x0020B5C5 File Offset: 0x002097C5
			internal void 2()
			{
				this.ReleaseHandle();
			}

			// Token: 0x060053B8 RID: 21432 RVA: 0x0020B5D0 File Offset: 0x002097D0
			protected override void WndProc(ref Message 1)
			{
				if (this.1 != null)
				{
					this.1(ref 1);
				}
				if (1.Result.ToInt32() < 0)
				{
					1.Result = new IntPtr(-1.Result.ToInt32() - 1);
					return;
				}
				base.WndProc(ref 1);
			}

			// Token: 0x04003F7D RID: 16253
			private 1171 1;
		}
	}

	// Token: 0x02000BFD RID: 3069
	public enum 1140
	{

	}

	// Token: 0x02000BFE RID: 3070
	public enum 1139 : uint
	{

	}
}
