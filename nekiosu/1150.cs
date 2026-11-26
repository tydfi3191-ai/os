using System;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x02000C0F RID: 3087
[Guid("000214F9-0000-0000-C000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[ComImport]
public interface 1150
{
	// Token: 0x060053F1 RID: 21489
	void GetPath([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder 1, int 2, out IntPtr 3, int 4);

	// Token: 0x060053F2 RID: 21490
	void GetIdList(out IntPtr 1);

	// Token: 0x060053F3 RID: 21491
	void SetIdList(IntPtr 1);

	// Token: 0x060053F4 RID: 21492
	void GetDescription([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder 1, int 2);

	// Token: 0x060053F5 RID: 21493
	void SetDescription([MarshalAs(UnmanagedType.LPWStr)] string 1);

	// Token: 0x060053F6 RID: 21494
	void GetWorkingDirectory([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder 1, int 2);

	// Token: 0x060053F7 RID: 21495
	void SetWorkingDirectory([MarshalAs(UnmanagedType.LPWStr)] string 1);

	// Token: 0x060053F8 RID: 21496
	void GetArguments([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder 1, int 2);

	// Token: 0x060053F9 RID: 21497
	void SetArguments([MarshalAs(UnmanagedType.LPWStr)] string 1);

	// Token: 0x060053FA RID: 21498
	void GetHotkey(out short 1);

	// Token: 0x060053FB RID: 21499
	void SetHotkey(short 1);

	// Token: 0x060053FC RID: 21500
	void GetShowCmd(out int 1);

	// Token: 0x060053FD RID: 21501
	void SetShowCmd(int 1);

	// Token: 0x060053FE RID: 21502
	void GetIconLocation([MarshalAs(UnmanagedType.LPWStr)] [Out] StringBuilder 1, int 2, out int 3);

	// Token: 0x060053FF RID: 21503
	void SetIconLocation([MarshalAs(UnmanagedType.LPWStr)] string 1, int 2);

	// Token: 0x06005400 RID: 21504
	void SetRelativePath([MarshalAs(UnmanagedType.LPWStr)] string 1, int 2);

	// Token: 0x06005401 RID: 21505
	void Resolve(IntPtr 1, int 2);

	// Token: 0x06005402 RID: 21506
	void SetPath([MarshalAs(UnmanagedType.LPWStr)] string 1);
}
