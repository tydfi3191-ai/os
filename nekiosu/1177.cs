using System;
using System.Runtime.InteropServices;
using System.Security;
using Microsoft.Win32.SafeHandles;

// Token: 0x02000BFF RID: 3071
public static class 1177
{
	// Token: 0x060053B9 RID: 21433 RVA: 0x0020B628 File Offset: 0x00209828
	public static void 1(uint 1)
	{
		if (1 != 0U)
		{
			uint num = 1;
			throw new InvalidOperationException(num.ToString());
		}
	}

	// Token: 0x060053BA RID: 21434
	[DllImport("ncrypt.dll")]
	public static extern uint NCryptFreeObject(IntPtr 1);

	// Token: 0x060053BB RID: 21435
	[DllImport("ncrypt.dll")]
	public static extern uint NCryptEncrypt(1177.1179 1, [MarshalAs(UnmanagedType.LPArray)] byte[] 2, int 3, IntPtr 4, [MarshalAs(UnmanagedType.LPArray)] byte[] 5, int 6, out int 7, int 8);

	// Token: 0x060053BC RID: 21436
	[DllImport("ncrypt.dll", CharSet = CharSet.Unicode)]
	public static extern uint NCryptImportKey(1177.1180 1, IntPtr 2, string 3, IntPtr 4, out 1177.1179 5, [MarshalAs(UnmanagedType.LPArray)] byte[] 6, int 7, uint 8);

	// Token: 0x060053BD RID: 21437
	[DllImport("ncrypt.dll", CharSet = CharSet.Unicode)]
	public static extern uint NCryptOpenStorageProvider(out 1177.1180 1, string 2, uint 3);

	// Token: 0x02000C00 RID: 3072
	[SecurityCritical]
	public sealed class 1179 : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x1700032B RID: 811
		// (get) Token: 0x060053BE RID: 21438 RVA: 0x0020B647 File Offset: 0x00209847
		public override bool IsInvalid
		{
			get
			{
				return this.handle == IntPtr.Zero;
			}
		}

		// Token: 0x060053BF RID: 21439 RVA: 0x0020B659 File Offset: 0x00209859
		public 1179() : base(true)
		{
		}

		// Token: 0x060053C0 RID: 21440 RVA: 0x0020B662 File Offset: 0x00209862
		protected override bool ReleaseHandle()
		{
			return 1177.NCryptFreeObject(this.handle) == 0U;
		}
	}

	// Token: 0x02000C01 RID: 3073
	public struct 1178
	{
		// Token: 0x04003F80 RID: 16256
		public uint 1;

		// Token: 0x04003F81 RID: 16257
		public int 2;

		// Token: 0x04003F82 RID: 16258
		public int 3;

		// Token: 0x04003F83 RID: 16259
		public int 4;

		// Token: 0x04003F84 RID: 16260
		public int 5;

		// Token: 0x04003F85 RID: 16261
		public int 6;
	}

	// Token: 0x02000C02 RID: 3074
	[SecurityCritical]
	public sealed class 1180 : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x1700032C RID: 812
		// (get) Token: 0x060053C1 RID: 21441 RVA: 0x0020B647 File Offset: 0x00209847
		public override bool IsInvalid
		{
			get
			{
				return this.handle == IntPtr.Zero;
			}
		}

		// Token: 0x060053C2 RID: 21442 RVA: 0x0020B659 File Offset: 0x00209859
		public 1180() : base(true)
		{
		}

		// Token: 0x060053C3 RID: 21443 RVA: 0x0020B662 File Offset: 0x00209862
		protected override bool ReleaseHandle()
		{
			return 1177.NCryptFreeObject(this.handle) == 0U;
		}
	}
}
