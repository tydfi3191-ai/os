using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

// Token: 0x02000C07 RID: 3079
public sealed class 1143
{
	// Token: 0x060053D4 RID: 21460 RVA: 0x0020B808 File Offset: 0x00209A08
	internal static bool 1()
	{
		try
		{
			if (Environment.OSVersion.Version.Major < 6)
			{
				return false;
			}
			return 1143.1144.IsCompositionEnabled();
		}
		catch
		{
		}
		return false;
	}

	// Token: 0x060053D5 RID: 21461 RVA: 0x0020B84C File Offset: 0x00209A4C
	internal static bool 2()
	{
		return Environment.OSVersion.Version.Major >= 6 && Application.RenderWithVisualStyles;
	}

	// Token: 0x060053D6 RID: 21462 RVA: 0x0020B868 File Offset: 0x00209A68
	internal static void 3(Control 1)
	{
		if (1143.1())
		{
			int num = 2;
			1143.1144.SetWindowAttribute(1.Handle, 2, ref num, 4);
		}
	}

	// Token: 0x060053D7 RID: 21463 RVA: 0x0020B890 File Offset: 0x00209A90
	internal static void 4(Control 1)
	{
		if (1143.1())
		{
			int num = 0;
			1143.1144.SetWindowAttribute(1.Handle, 2, ref num, 4);
		}
	}

	// Token: 0x060053D8 RID: 21464 RVA: 0x0020B8B8 File Offset: 0x00209AB8
	internal static void 5(Control 1, string 2, string 3)
	{
		int num;
		if (!Application.RenderWithVisualStyles || (num = 1143.1149.SetWindowTheme(1.Handle, 2, 3)) >= 0)
		{
			return;
		}
		throw new InvalidOperationException("SetWindowTheme failed with error " + num.ToString());
	}

	// Token: 0x060053D9 RID: 21465 RVA: 0x0020B8F5 File Offset: 0x00209AF5
	internal static void 6(Control 1, string 2)
	{
		1143.5(1, 2, null);
	}

	// Token: 0x060053DA RID: 21466 RVA: 0x0020B8FF File Offset: 0x00209AFF
	internal static void 7(Control 1)
	{
		1143.5(1, null, null);
	}

	// Token: 0x02000C08 RID: 3080
	public sealed class 1144
	{
		// Token: 0x060053DC RID: 21468
		[DllImport("dwmapi.dll", EntryPoint = "DwmEnableBlurBehindWindow", PreserveSig = false)]
		public static extern void EnableBlurBehindWindow(IntPtr 1, 1143.1144.1145 2);

		// Token: 0x060053DD RID: 21469
		[DllImport("dwmapi.dll", EntryPoint = "DwmExtendFrameIntoClientArea", PreserveSig = false)]
		public static extern void ExtendFrameIntoClientArea(IntPtr 1, 1143.1144.1146 2);

		// Token: 0x060053DE RID: 21470
		[DllImport("dwmapi.dll", EntryPoint = "DwmIsCompositionEnabled", PreserveSig = false)]
		public static extern bool IsCompositionEnabled();

		// Token: 0x060053DF RID: 21471
		[DllImport("dwmapi.dll", EntryPoint = "DwmEnableComposition", PreserveSig = false)]
		public static extern void EnableComposition(bool 1);

		// Token: 0x060053E0 RID: 21472
		[DllImport("dwmapi.dll", EntryPoint = "DwmGetColorizationColor", PreserveSig = false)]
		public static extern void GetColorizationColor(out int 1, [MarshalAs(UnmanagedType.Bool)] out bool 2);

		// Token: 0x060053E1 RID: 21473
		[DllImport("dwmapi.dll", EntryPoint = "DwmRegisterThumbnail", PreserveSig = false)]
		public static extern IntPtr RegisterThumbnail(IntPtr 1, IntPtr 2);

		// Token: 0x060053E2 RID: 21474
		[DllImport("dwmapi.dll", EntryPoint = "DwmUnregisterThumbnail", PreserveSig = false)]
		public static extern void UnregisterThumbnail(IntPtr 1);

		// Token: 0x060053E3 RID: 21475
		[DllImport("dwmapi.dll", EntryPoint = "DwmUpdateThumbnailProperties", PreserveSig = false)]
		public static extern void UpdateThumbnailProperties(IntPtr 1, 1143.1144.1148 2);

		// Token: 0x060053E4 RID: 21476
		[DllImport("dwmapi.dll", EntryPoint = "DwmQueryThumbnailSourceSize", PreserveSig = false)]
		public static extern void QueryThumbnailSourceSize(IntPtr 1, out Size 2);

		// Token: 0x060053E5 RID: 21477
		[DllImport("dwmapi.dll", EntryPoint = "DwmGetWindowAttribute", PreserveSig = false)]
		public static extern void GetWindowAttribute(IntPtr 1, int 2, out int 3);

		// Token: 0x060053E6 RID: 21478
		[DllImport("dwmapi.dll", EntryPoint = "DwmSetWindowAttribute", PreserveSig = false)]
		public static extern void SetWindowAttribute(IntPtr 1, int 2, ref int 3, int 4);

		// Token: 0x02000C09 RID: 3081
		public struct 1147
		{
			// Token: 0x060053E8 RID: 21480 RVA: 0x0020B909 File Offset: 0x00209B09
			public 1147(int 1, int 2, int 3, int 4)
			{
				this.1 = 1;
				this.2 = 2;
				this.3 = 3;
				this.4 = 4;
			}

			// Token: 0x04003F96 RID: 16278
			public int 1;

			// Token: 0x04003F97 RID: 16279
			public int 2;

			// Token: 0x04003F98 RID: 16280
			public int 3;

			// Token: 0x04003F99 RID: 16281
			public int 4;
		}

		// Token: 0x02000C0A RID: 3082
		[StructLayout(LayoutKind.Sequential)]
		public sealed class 1146
		{
			// Token: 0x060053E9 RID: 21481 RVA: 0x0020B928 File Offset: 0x00209B28
			public 1146(int 1, int 2, int 3, int 4)
			{
				this.1 = 1;
				this.2 = 2;
				this.3 = 3;
				this.4 = 4;
			}

			// Token: 0x04003F9A RID: 16282
			public int 1;

			// Token: 0x04003F9B RID: 16283
			public int 2;

			// Token: 0x04003F9C RID: 16284
			public int 3;

			// Token: 0x04003F9D RID: 16285
			public int 4;
		}

		// Token: 0x02000C0B RID: 3083
		[StructLayout(LayoutKind.Sequential)]
		public sealed class 1145
		{
			// Token: 0x04003F9E RID: 16286
			public uint 1;

			// Token: 0x04003F9F RID: 16287
			[MarshalAs(UnmanagedType.Bool)]
			public bool 2;

			// Token: 0x04003FA0 RID: 16288
			public IntPtr 3;

			// Token: 0x04003FA1 RID: 16289
			[MarshalAs(UnmanagedType.Bool)]
			public bool 4;
		}

		// Token: 0x02000C0C RID: 3084
		[StructLayout(LayoutKind.Sequential)]
		public sealed class 1148
		{
			// Token: 0x04003FA2 RID: 16290
			public uint 1;

			// Token: 0x04003FA3 RID: 16291
			public 1143.1144.1147 2;

			// Token: 0x04003FA4 RID: 16292
			public 1143.1144.1147 3;

			// Token: 0x04003FA5 RID: 16293
			public byte 4;

			// Token: 0x04003FA6 RID: 16294
			[MarshalAs(UnmanagedType.Bool)]
			public bool 5;

			// Token: 0x04003FA7 RID: 16295
			[MarshalAs(UnmanagedType.Bool)]
			public bool 6;
		}
	}

	// Token: 0x02000C0D RID: 3085
	public sealed class 1149
	{
		// Token: 0x060053EC RID: 21484
		[DllImport("uxtheme.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
		public static extern int SetWindowTheme(IntPtr 1, string 2, string 3);
	}
}
