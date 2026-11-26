using System;
using System.Runtime.InteropServices;

// Token: 0x02000BE8 RID: 3048
public sealed class 1118
{
	// Token: 0x06005346 RID: 21318
	[DllImport("/System/Library/Frameworks/Carbon.framework/Versions/Current/Carbon")]
	internal static extern 1124 DMGetGDeviceByDisplayID(IntPtr 1, out IntPtr 2, bool 3);

	// Token: 0x06005347 RID: 21319
	[DllImport("/System/Library/Frameworks/Carbon.framework/Versions/Current/Carbon")]
	private static extern IntPtr GetControlBounds(IntPtr 1, out 1142 2);

	// Token: 0x06005348 RID: 21320 RVA: 0x0020A72C File Offset: 0x0020892C
	internal static 1142 1(IntPtr 1)
	{
		1142 result;
		1118.GetControlBounds(1, out result);
		return result;
	}

	// Token: 0x06005349 RID: 21321
	[DllImport("/System/Library/Frameworks/Carbon.framework/Versions/Current/Carbon")]
	internal static extern IntPtr GetControlOwner(IntPtr 1);

	// Token: 0x0600534A RID: 21322
	[DllImport("/System/Library/Frameworks/Carbon.framework/Versions/Current/Carbon")]
	internal static extern IntPtr GetWindowPort(IntPtr 1);
}
