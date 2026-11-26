using System;
using System.Runtime.InteropServices;

// Token: 0x02000BF2 RID: 3058
public sealed class 1128
{
	// Token: 0x06005376 RID: 21366
	[DllImport("libdl.dylib")]
	private static extern bool NSIsSymbolNameDefined(string 1);

	// Token: 0x06005377 RID: 21367
	[DllImport("libdl.dylib")]
	private static extern bool NSIsSymbolNameDefined(IntPtr 1);

	// Token: 0x06005378 RID: 21368
	[DllImport("libdl.dylib")]
	private static extern IntPtr NSLookupAndBindSymbol(string 1);

	// Token: 0x06005379 RID: 21369
	[DllImport("libdl.dylib")]
	private static extern IntPtr NSLookupAndBindSymbol(IntPtr 1);

	// Token: 0x0600537A RID: 21370
	[DllImport("libdl.dylib")]
	private static extern IntPtr NSAddressOfSymbol(IntPtr 1);

	// Token: 0x0600537B RID: 21371
	[DllImport("libdl.dylib")]
	private static extern IntPtr dlopen(string 1, int 2);

	// Token: 0x0600537C RID: 21372
	[DllImport("libdl.dylib")]
	private static extern int dlclose(IntPtr 1);

	// Token: 0x0600537D RID: 21373
	[DllImport("libdl.dylib")]
	private static extern IntPtr dlsym(IntPtr 1, string 2);

	// Token: 0x0600537E RID: 21374 RVA: 0x0020B0A4 File Offset: 0x002092A4
	public static IntPtr 1(string 1)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(1.Length + 2);
		IntPtr result;
		try
		{
			Marshal.WriteByte(intPtr, 95);
			for (int i = 0; i < 1.Length; i++)
			{
				Marshal.WriteByte(intPtr, i + 1, (byte)1[i]);
			}
			Marshal.WriteByte(intPtr, 1.Length + 1, 0);
			result = 1128.2(intPtr);
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
		return result;
	}

	// Token: 0x0600537F RID: 21375 RVA: 0x0020B11C File Offset: 0x0020931C
	public static IntPtr 2(IntPtr 1)
	{
		IntPtr intPtr = IntPtr.Zero;
		if (1128.NSIsSymbolNameDefined(1))
		{
			intPtr = 1128.NSLookupAndBindSymbol(1);
			if (intPtr != IntPtr.Zero)
			{
				intPtr = 1128.NSAddressOfSymbol(intPtr);
			}
		}
		return intPtr;
	}
}
