using System;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

// Token: 0x02000C2B RID: 3115
public sealed class 1071
{
	// Token: 0x06005449 RID: 21577
	[DllImport("hid.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern void HidD_GetHidGuid(out Guid 1);

	// Token: 0x0600544A RID: 21578
	[DllImport("hid.dll")]
	public static extern bool HidD_GetAttributes(IntPtr 1, ref 1071.1075 2);

	// Token: 0x0600544B RID: 21579
	[DllImport("hid.dll")]
	internal static extern bool HidD_SetOutputReport(IntPtr 1, byte[] 2, uint 3);

	// Token: 0x0600544C RID: 21580
	[DllImport("setupapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr SetupDiGetClassDevs(ref Guid 1, [MarshalAs(UnmanagedType.LPTStr)] string 2, IntPtr 3, uint 4);

	// Token: 0x0600544D RID: 21581
	[DllImport("setupapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool SetupDiEnumDeviceInterfaces(IntPtr 1, IntPtr 2, ref Guid 3, int 4, ref 1071.1072 5);

	// Token: 0x0600544E RID: 21582
	[DllImport("setupapi.dll", SetLastError = true)]
	public static extern bool SetupDiGetDeviceInterfaceDetail(IntPtr 1, ref 1071.1072 2, IntPtr 3, uint 4, out uint 5, IntPtr 6);

	// Token: 0x0600544F RID: 21583
	[DllImport("setupapi.dll", SetLastError = true)]
	public static extern bool SetupDiGetDeviceInterfaceDetail(IntPtr 1, ref 1071.1072 2, ref 1071.1073 3, uint 4, out uint 5, IntPtr 6);

	// Token: 0x06005450 RID: 21584
	[DllImport("setupapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern ushort SetupDiDestroyDeviceInfoList(IntPtr 1);

	// Token: 0x06005451 RID: 21585
	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern SafeFileHandle CreateFile(string 1, [MarshalAs(UnmanagedType.U4)] FileAccess 2, [MarshalAs(UnmanagedType.U4)] FileShare 3, IntPtr 4, [MarshalAs(UnmanagedType.U4)] FileMode 5, [MarshalAs(UnmanagedType.U4)] 1071.1074 6, IntPtr 7);

	// Token: 0x06005452 RID: 21586
	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr 1);

	// Token: 0x02000C2C RID: 3116
	public struct 1075
	{
		// Token: 0x0400405D RID: 16477
		public int 1;

		// Token: 0x0400405E RID: 16478
		public short 2;

		// Token: 0x0400405F RID: 16479
		public short 3;

		// Token: 0x04004060 RID: 16480
		public short 4;
	}

	// Token: 0x02000C2D RID: 3117
	public enum 1074 : uint
	{

	}

	// Token: 0x02000C2E RID: 3118
	public struct 1076
	{
		// Token: 0x04004062 RID: 16482
		public uint 1;

		// Token: 0x04004063 RID: 16483
		public Guid 2;

		// Token: 0x04004064 RID: 16484
		public uint 3;

		// Token: 0x04004065 RID: 16485
		public IntPtr 4;
	}

	// Token: 0x02000C2F RID: 3119
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct 1073
	{
		// Token: 0x04004066 RID: 16486
		public uint 1;

		// Token: 0x04004067 RID: 16487
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string 2;
	}

	// Token: 0x02000C30 RID: 3120
	public struct 1072
	{
		// Token: 0x04004068 RID: 16488
		public int 1;

		// Token: 0x04004069 RID: 16489
		public Guid 2;

		// Token: 0x0400406A RID: 16490
		public int 3;

		// Token: 0x0400406B RID: 16491
		public IntPtr 4;
	}
}
