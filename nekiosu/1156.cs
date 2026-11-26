using System;
using System.Runtime.InteropServices;

// Token: 0x02000C14 RID: 3092
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 8)]
public struct 1156
{
	// Token: 0x0600540C RID: 21516 RVA: 0x0020B9F0 File Offset: 0x00209BF0
	public static uint 1()
	{
		return (uint)(Marshal.SizeOf(typeof(1156)) | 131072);
	}

	// Token: 0x04003FB0 RID: 16304
	public uint 1;

	// Token: 0x04003FB1 RID: 16305
	public uint 2;

	// Token: 0x04003FB2 RID: 16306
	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2048)]
	public string 3;

	// Token: 0x04003FB3 RID: 16307
	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2048)]
	public string 4;

	// Token: 0x04003FB4 RID: 16308
	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2048)]
	public string 5;

	// Token: 0x04003FB5 RID: 16309
	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2048)]
	public string 6;
}
