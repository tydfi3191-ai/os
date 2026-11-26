using System;
using System.Runtime.InteropServices;

// Token: 0x02000C03 RID: 3075
[ComVisible(false)]
public static class 1181
{
	// Token: 0x060053C4 RID: 21444 RVA: 0x0020B674 File Offset: 0x00209874
	public static bool 1()
	{
		if (1181.1 == null)
		{
			try
			{
				IntPtr procAddress = 1181.GetProcAddress(1181.GetModuleHandle("ntdll.dll"), "wine_get_version");
				1181.1 = new bool?(procAddress != IntPtr.Zero);
			}
			catch
			{
				1181.1 = new bool?(true);
			}
		}
		return 1181.1.Value;
	}

	// Token: 0x060053C5 RID: 21445
	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetProcAddress(IntPtr 1, string 2);

	// Token: 0x060053C6 RID: 21446
	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr GetModuleHandle(string 1);

	// Token: 0x060053C7 RID: 21447
	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern uint RtlGetVersion(ref 1181.1182 1);

	// Token: 0x04003F86 RID: 16262
	private static bool? 1;

	// Token: 0x02000C04 RID: 3076
	public struct 1182
	{
		// Token: 0x04003F87 RID: 16263
		public uint 1;

		// Token: 0x04003F88 RID: 16264
		public uint 2;

		// Token: 0x04003F89 RID: 16265
		public uint 3;

		// Token: 0x04003F8A RID: 16266
		public uint 4;

		// Token: 0x04003F8B RID: 16267
		public uint 5;

		// Token: 0x04003F8C RID: 16268
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string 6;

		// Token: 0x04003F8D RID: 16269
		public ushort 7;

		// Token: 0x04003F8E RID: 16270
		public ushort 8;

		// Token: 0x04003F8F RID: 16271
		public ushort 9;

		// Token: 0x04003F90 RID: 16272
		public byte 10;

		// Token: 0x04003F91 RID: 16273
		public byte 11;
	}
}
