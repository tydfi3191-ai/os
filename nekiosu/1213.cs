using System;
using System.Runtime.InteropServices;

// Token: 0x02000BD9 RID: 3033
public struct 1213 : IDisposable
{
	// Token: 0x06005304 RID: 21252 RVA: 0x00209EF0 File Offset: 0x002080F0
	public 1213(1176 1)
	{
		this.1 = (uint)Marshal.SizeOf(typeof(1213));
		this.7 = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(1176)));
		Marshal.StructureToPtr(1, this.7, false);
		this.6 = (1217)1;
		this.2 = IntPtr.Zero;
		this.3 = IntPtr.Zero;
		this.4 = (1215)2;
		this.5 = (365)0;
		this.8 = (370)0;
		this.9 = IntPtr.Zero;
		this.10 = IntPtr.Zero;
		this.11 = (1214)256;
		this.12 = (1216)0;
	}

	// Token: 0x06005305 RID: 21253 RVA: 0x00209F98 File Offset: 0x00208198
	public void Dispose()
	{
		this.1(true);
	}

	// Token: 0x06005306 RID: 21254 RVA: 0x00209FA4 File Offset: 0x002081A4
	private void 1(bool 1)
	{
		if (this.6 == (1217)1)
		{
			1176 2 = default(1176);
			Marshal.PtrToStructure(this.7, 2);
			2.Dispose();
			Marshal.DestroyStructure(this.7, typeof(1176));
		}
		Marshal.FreeHGlobal(this.7);
	}

	// Token: 0x04003F26 RID: 16166
	public uint 1;

	// Token: 0x04003F27 RID: 16167
	public IntPtr 2;

	// Token: 0x04003F28 RID: 16168
	public IntPtr 3;

	// Token: 0x04003F29 RID: 16169
	public 1215 4;

	// Token: 0x04003F2A RID: 16170
	public 365 5;

	// Token: 0x04003F2B RID: 16171
	public 1217 6;

	// Token: 0x04003F2C RID: 16172
	public IntPtr 7;

	// Token: 0x04003F2D RID: 16173
	public 370 8;

	// Token: 0x04003F2E RID: 16174
	public IntPtr 9;

	// Token: 0x04003F2F RID: 16175
	private IntPtr 10;

	// Token: 0x04003F30 RID: 16176
	public 1214 11;

	// Token: 0x04003F31 RID: 16177
	public 1216 12;
}
