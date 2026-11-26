using System;
using System.Runtime.InteropServices;

// Token: 0x02000C16 RID: 3094
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
public struct 1158
{
	// Token: 0x0600540E RID: 21518 RVA: 0x0020BA1E File Offset: 0x00209C1E
	public static uint 1()
	{
		return (uint)(Marshal.SizeOf(typeof(1158)) | 65536);
	}

	// Token: 0x04003FBC RID: 16316
	public uint 1;

	// Token: 0x04003FBD RID: 16317
	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2048)]
	public string 2;

	// Token: 0x04003FBE RID: 16318
	public 676 3;

	// Token: 0x04003FBF RID: 16319
	public uint 4;

	// Token: 0x04003FC0 RID: 16320
	public uint 5;

	// Token: 0x04003FC1 RID: 16321
	public uint 6;

	// Token: 0x04003FC2 RID: 16322
	public uint 7;

	// Token: 0x04003FC3 RID: 16323
	public uint 8;

	// Token: 0x04003FC4 RID: 16324
	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2048)]
	public string 9;

	// Token: 0x04003FC5 RID: 16325
	public uint 10;

	// Token: 0x04003FC6 RID: 16326
	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2048)]
	public string 11;
}
