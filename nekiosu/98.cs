using System;
using System.Runtime.InteropServices;

// Token: 0x0200008A RID: 138
[ComVisible(false)]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("0000000C-0000-0000-C000-000000000046")]
[ComImport]
public interface 98
{
	// Token: 0x060002E0 RID: 736
	int Read([In] IntPtr 1, [In] int 2);

	// Token: 0x060002E1 RID: 737
	int Write([In] IntPtr 1, [In] int 2);

	// Token: 0x060002E2 RID: 738
	[return: MarshalAs(UnmanagedType.I8)]
	long Seek([MarshalAs(UnmanagedType.I8)] [In] long 1, [In] int 2);

	// Token: 0x060002E3 RID: 739
	void SetSize([MarshalAs(UnmanagedType.I8)] [In] long 1);

	// Token: 0x060002E4 RID: 740
	[return: MarshalAs(UnmanagedType.I8)]
	long CopyTo([MarshalAs(UnmanagedType.Interface)] [In] 98 1, [MarshalAs(UnmanagedType.I8)] [In] long 2, [MarshalAs(UnmanagedType.LPArray)] [Out] long[] 3);

	// Token: 0x060002E5 RID: 741
	void Commit([In] int 1);

	// Token: 0x060002E6 RID: 742
	void Revert();

	// Token: 0x060002E7 RID: 743
	void LockRegion([MarshalAs(UnmanagedType.I8)] [In] long 1, [MarshalAs(UnmanagedType.I8)] [In] long 2, [In] int 3);

	// Token: 0x060002E8 RID: 744
	void UnlockRegion([MarshalAs(UnmanagedType.I8)] [In] long 1, [MarshalAs(UnmanagedType.I8)] [In] long 2, [In] int 3);

	// Token: 0x060002E9 RID: 745
	void Stat([In] IntPtr 1, [In] int 2);

	// Token: 0x060002EA RID: 746
	[return: MarshalAs(UnmanagedType.Interface)]
	98 Clone();
}
