using System;
using System.Runtime.InteropServices;

// Token: 0x02000C15 RID: 3093
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 8)]
public struct 1157
{
	// Token: 0x0600540D RID: 21517 RVA: 0x0020BA07 File Offset: 0x00209C07
	public static uint 1()
	{
		return (uint)(Marshal.SizeOf(typeof(1157)) | 65536);
	}

	// Token: 0x04003FB6 RID: 16310
	public uint 1;

	// Token: 0x04003FB7 RID: 16311
	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2048)]
	public string 2;

	// Token: 0x04003FB8 RID: 16312
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
	public uint[] 3;

	// Token: 0x04003FB9 RID: 16313
	public uint 4;

	// Token: 0x04003FBA RID: 16314
	public uint 5;

	// Token: 0x04003FBB RID: 16315
	public uint 6;
}
