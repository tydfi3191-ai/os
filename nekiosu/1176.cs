using System;
using System.Runtime.InteropServices;

// Token: 0x02000C28 RID: 3112
public struct 1176 : IDisposable
{
	// Token: 0x06005441 RID: 21569 RVA: 0x0020BC38 File Offset: 0x00209E38
	public 1176(string 1, Guid 2)
	{
		this.1 = (uint)Marshal.SizeOf(typeof(1176));
		this.2 = 1;
		if (2 != Guid.Empty)
		{
			this.4 = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(Guid)));
			Marshal.StructureToPtr(2, this.4, true);
		}
		else
		{
			this.4 = IntPtr.Zero;
		}
		this.3 = IntPtr.Zero;
	}

	// Token: 0x06005442 RID: 21570 RVA: 0x0020BCB2 File Offset: 0x00209EB2
	public void Dispose()
	{
		this.1(true);
	}

	// Token: 0x06005443 RID: 21571 RVA: 0x0020BCBB File Offset: 0x00209EBB
	private void 1(bool 1)
	{
		if (this.4 != IntPtr.Zero)
		{
			Marshal.DestroyStructure(this.4, typeof(Guid));
			Marshal.FreeHGlobal(this.4);
		}
	}

	// Token: 0x04004055 RID: 16469
	public uint 1;

	// Token: 0x04004056 RID: 16470
	[MarshalAs(UnmanagedType.LPTStr)]
	public string 2;

	// Token: 0x04004057 RID: 16471
	public IntPtr 3;

	// Token: 0x04004058 RID: 16472
	public IntPtr 4;
}
