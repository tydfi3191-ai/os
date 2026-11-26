using System;
using System.Runtime.InteropServices;

// Token: 0x020002BE RID: 702
public static class 614
{
	// Token: 0x06001520 RID: 5408
	[DllImport("/System/Library/Frameworks/AGL.framework/Versions/Current/AGL")]
	internal static extern IntPtr aglChoosePixelFormat(ref IntPtr 1, int 2, int[] 3);

	// Token: 0x06001521 RID: 5409
	[DllImport("/System/Library/Frameworks/AGL.framework/Versions/Current/AGL")]
	internal static extern IntPtr aglChoosePixelFormat(IntPtr 1, int 2, int[] 3);

	// Token: 0x06001522 RID: 5410
	[DllImport("/System/Library/Frameworks/AGL.framework/Versions/Current/AGL")]
	internal static extern void aglDestroyPixelFormat(IntPtr 1);

	// Token: 0x06001523 RID: 5411
	[DllImport("/System/Library/Frameworks/AGL.framework/Versions/Current/AGL")]
	internal static extern IntPtr aglNextPixelFormat(IntPtr 1);

	// Token: 0x06001524 RID: 5412
	[DllImport("/System/Library/Frameworks/AGL.framework/Versions/Current/AGL")]
	internal static extern bool aglDescribePixelFormat(IntPtr 1, 614.619 2, out int 3);

	// Token: 0x06001525 RID: 5413
	[DllImport("/System/Library/Frameworks/AGL.framework/Versions/Current/AGL", EntryPoint = "aglDevicesOfPixelFormat")]
	private unsafe static extern IntPtr* Method9029(IntPtr 1, int* 2);

	// Token: 0x06001526 RID: 5414
	[DllImport("/System/Library/Frameworks/AGL.framework/Versions/Current/AGL")]
	private static extern IntPtr aglQueryRendererInfo(IntPtr[] 1, int 2);

	// Token: 0x06001527 RID: 5415
	[DllImport("/System/Library/Frameworks/AGL.framework/Versions/Current/AGL")]
	private static extern void aglDestroyRendererInfo(IntPtr 1);

	// Token: 0x06001528 RID: 5416
	[DllImport("/System/Library/Frameworks/AGL.framework/Versions/Current/AGL")]
	private static extern IntPtr aglNextRendererInfo(IntPtr 1);

	// Token: 0x06001529 RID: 5417
	[DllImport("/System/Library/Frameworks/AGL.framework/Versions/Current/AGL")]
	private static extern byte aglDescribeRenderer(IntPtr 1, int 2, out int 3);

	// Token: 0x0600152A RID: 5418
	[DllImport("/System/Library/Frameworks/AGL.framework/Versions/Current/AGL")]
	internal static extern IntPtr aglCreateContext(IntPtr 1, IntPtr 2);

	// Token: 0x0600152B RID: 5419
	[DllImport("/System/Library/Frameworks/AGL.framework/Versions/Current/AGL")]
	private static extern byte aglDestroyContext(IntPtr 1);

	// Token: 0x0600152C RID: 5420 RVA: 0x0004938F File Offset: 0x0004758F
	internal static bool Method9030(IntPtr 1)
	{
		return 614.aglDestroyContext(1) != 0;
	}

	// Token: 0x0600152D RID: 5421
	[DllImport("/System/Library/Frameworks/AGL.framework/Versions/Current/AGL")]
	private static extern byte aglCopyContext(IntPtr 1, IntPtr 2, uint 3);

	// Token: 0x0600152E RID: 5422
	[DllImport("/System/Library/Frameworks/AGL.framework/Versions/Current/AGL")]
	internal static extern byte aglUpdateContext(IntPtr 1);

	// Token: 0x0600152F RID: 5423
	[DllImport("/System/Library/Frameworks/AGL.framework/Versions/Current/AGL")]
	private static extern byte aglSetCurrentContext(IntPtr 1);

	// Token: 0x06001530 RID: 5424 RVA: 0x0004939C File Offset: 0x0004759C
	internal static bool Method9031(IntPtr 1)
	{
		return 614.aglSetCurrentContext(1) != 0;
	}

	// Token: 0x06001531 RID: 5425
	[DllImport("/System/Library/Frameworks/AGL.framework/Versions/Current/AGL")]
	internal static extern IntPtr aglGetCurrentContext();

	// Token: 0x06001532 RID: 5426
	[DllImport("/System/Library/Frameworks/AGL.framework/Versions/Current/AGL")]
	private static extern byte aglSetDrawable(IntPtr 1, IntPtr 2);

	// Token: 0x06001533 RID: 5427 RVA: 0x000493A9 File Offset: 0x000475A9
	internal static void Method9032(IntPtr 1, IntPtr 2)
	{
		if (614.aglSetDrawable(1, 2) == 0)
		{
			throw new Exception(614.Method9034(614.aglGetError()));
		}
	}

	// Token: 0x06001534 RID: 5428
	[DllImport("/System/Library/Frameworks/AGL.framework/Versions/Current/AGL")]
	private static extern byte aglSetOffScreen(IntPtr 1, int 2, int 3, int 4, IntPtr 5);

	// Token: 0x06001535 RID: 5429
	[DllImport("/System/Library/Frameworks/AGL.framework/Versions/Current/AGL")]
	private static extern IntPtr aglGetDrawable(IntPtr 1);

	// Token: 0x06001536 RID: 5430
	[DllImport("/System/Library/Frameworks/AGL.framework/Versions/Current/AGL")]
	private static extern byte aglSetFullScreen(IntPtr 1, int 2, int 3, int 4, int 5);

	// Token: 0x06001537 RID: 5431 RVA: 0x000493C4 File Offset: 0x000475C4
	internal static void Method9033(IntPtr 1, int 2, int 3, int 4, int 5)
	{
		if (614.aglSetFullScreen(1, 2, 3, 4, 5) == 0)
		{
			throw new Exception(614.Method9034(614.aglGetError()));
		}
	}

	// Token: 0x06001538 RID: 5432
	[DllImport("/System/Library/Frameworks/AGL.framework/Versions/Current/AGL")]
	private static extern byte aglSetVirtualScreen(IntPtr 1, int 2);

	// Token: 0x06001539 RID: 5433
	[DllImport("/System/Library/Frameworks/AGL.framework/Versions/Current/AGL")]
	private static extern int aglGetVirtualScreen(IntPtr 1);

	// Token: 0x0600153A RID: 5434
	[DllImport("/System/Library/Frameworks/AGL.framework/Versions/Current/AGL")]
	private unsafe static extern void aglGetVersion(int* 1, int* 2);

	// Token: 0x0600153B RID: 5435
	[DllImport("/System/Library/Frameworks/AGL.framework/Versions/Current/AGL")]
	private static extern byte aglConfigure(uint 1, uint 2);

	// Token: 0x0600153C RID: 5436
	[DllImport("/System/Library/Frameworks/AGL.framework/Versions/Current/AGL")]
	internal static extern void aglSwapBuffers(IntPtr 1);

	// Token: 0x0600153D RID: 5437
	[DllImport("/System/Library/Frameworks/AGL.framework/Versions/Current/AGL")]
	internal static extern bool aglEnable(IntPtr 1, 614.618 2);

	// Token: 0x0600153E RID: 5438
	[DllImport("/System/Library/Frameworks/AGL.framework/Versions/Current/AGL")]
	internal static extern bool aglDisable(IntPtr 1, 614.618 2);

	// Token: 0x0600153F RID: 5439
	[DllImport("/System/Library/Frameworks/AGL.framework/Versions/Current/AGL")]
	private static extern bool aglIsEnabled(IntPtr 1, uint 2);

	// Token: 0x06001540 RID: 5440
	[DllImport("/System/Library/Frameworks/AGL.framework/Versions/Current/AGL")]
	internal static extern bool aglSetInteger(IntPtr 1, 614.618 2, ref int 3);

	// Token: 0x06001541 RID: 5441
	[DllImport("/System/Library/Frameworks/AGL.framework/Versions/Current/AGL")]
	internal static extern bool aglSetInteger(IntPtr 1, 614.618 2, int[] 3);

	// Token: 0x06001542 RID: 5442
	[DllImport("/System/Library/Frameworks/AGL.framework/Versions/Current/AGL")]
	internal static extern bool aglGetInteger(IntPtr 1, 614.618 2, out int 3);

	// Token: 0x06001543 RID: 5443
	[DllImport("/System/Library/Frameworks/AGL.framework/Versions/Current/AGL")]
	private static extern byte aglUseFont(IntPtr 1, int 2, int 3, int 4, int 5, int 6, int 7);

	// Token: 0x06001544 RID: 5444
	[DllImport("/System/Library/Frameworks/AGL.framework/Versions/Current/AGL")]
	internal static extern 614.624 aglGetError();

	// Token: 0x06001545 RID: 5445
	[DllImport("/System/Library/Frameworks/AGL.framework/Versions/Current/AGL")]
	private static extern IntPtr aglErrorString(614.624 1);

	// Token: 0x06001546 RID: 5446 RVA: 0x000493E3 File Offset: 0x000475E3
	internal static string Method9034(614.624 1)
	{
		return Marshal.PtrToStringAnsi(614.aglErrorString(1));
	}

	// Token: 0x06001547 RID: 5447
	[DllImport("/System/Library/Frameworks/AGL.framework/Versions/Current/AGL")]
	private static extern void aglResetLibrary();

	// Token: 0x06001548 RID: 5448
	[DllImport("/System/Library/Frameworks/AGL.framework/Versions/Current/AGL")]
	private static extern void aglSurfaceTexture(IntPtr 1, uint 2, uint 3, IntPtr 4);

	// Token: 0x06001549 RID: 5449
	[DllImport("/System/Library/Frameworks/AGL.framework/Versions/Current/AGL")]
	private unsafe static extern byte aglCreatePBuffer(int 1, int 2, uint 3, uint 4, long 5, IntPtr* 6);

	// Token: 0x0600154A RID: 5450
	[DllImport("/System/Library/Frameworks/AGL.framework/Versions/Current/AGL")]
	private static extern byte aglDestroyPBuffer(IntPtr 1);

	// Token: 0x0600154B RID: 5451
	[DllImport("/System/Library/Frameworks/AGL.framework/Versions/Current/AGL")]
	private unsafe static extern byte aglDescribePBuffer(IntPtr 1, int* 2, int* 3, uint* 4, uint* 5, int* 6);

	// Token: 0x0600154C RID: 5452
	[DllImport("/System/Library/Frameworks/AGL.framework/Versions/Current/AGL")]
	private static extern byte aglTexImagePBuffer(IntPtr 1, IntPtr 2, int 3);

	// Token: 0x0600154D RID: 5453
	[DllImport("/System/Library/Frameworks/AGL.framework/Versions/Current/AGL")]
	private static extern byte aglSetPBuffer(IntPtr 1, IntPtr 2, int 3, int 4, int 5);

	// Token: 0x0600154E RID: 5454
	[DllImport("/System/Library/Frameworks/AGL.framework/Versions/Current/AGL")]
	private unsafe static extern byte aglGetPBuffer(IntPtr 1, IntPtr* 2, int* 3, int* 4, int* 5);

	// Token: 0x0600154F RID: 5455
	[DllImport("/System/Library/Frameworks/AGL.framework/Versions/Current/AGL")]
	private unsafe static extern byte aglGetCGLContext(IntPtr 1, void** 2);

	// Token: 0x06001550 RID: 5456
	[DllImport("/System/Library/Frameworks/AGL.framework/Versions/Current/AGL")]
	private unsafe static extern byte aglGetCGLPixelFormat(IntPtr 1, void** 2);

	// Token: 0x020002BF RID: 703
	public enum 615
	{

	}

	// Token: 0x020002C0 RID: 704
	public enum 616
	{

	}

	// Token: 0x020002C1 RID: 705
	public enum 617
	{

	}

	// Token: 0x020002C2 RID: 706
	public enum 618
	{

	}

	// Token: 0x020002C3 RID: 707
	public enum 619
	{

	}

	// Token: 0x020002C4 RID: 708
	public enum 620
	{

	}

	// Token: 0x020002C5 RID: 709
	public enum 621
	{

	}

	// Token: 0x020002C6 RID: 710
	public enum 622
	{

	}

	// Token: 0x020002C7 RID: 711
	public enum 623
	{

	}

	// Token: 0x020002C8 RID: 712
	public enum 624
	{
		// Token: 0x040009F7 RID: 2551
		NoError,
		// Token: 0x040009F8 RID: 2552
		BadAttribute = 10000,
		// Token: 0x040009F9 RID: 2553
		BadProperty,
		// Token: 0x040009FA RID: 2554
		BadPixelFormat,
		// Token: 0x040009FB RID: 2555
		BadRendererInfo,
		// Token: 0x040009FC RID: 2556
		BadContext,
		// Token: 0x040009FD RID: 2557
		BadDrawable,
		// Token: 0x040009FE RID: 2558
		BadGraphicsDevice,
		// Token: 0x040009FF RID: 2559
		BadState,
		// Token: 0x04000A00 RID: 2560
		BadValue,
		// Token: 0x04000A01 RID: 2561
		BadMatch,
		// Token: 0x04000A02 RID: 2562
		BadEnum,
		// Token: 0x04000A03 RID: 2563
		BadOffscreen,
		// Token: 0x04000A04 RID: 2564
		BadFullscreen,
		// Token: 0x04000A05 RID: 2565
		BadWindow,
		// Token: 0x04000A06 RID: 2566
		BadPointer,
		// Token: 0x04000A07 RID: 2567
		BadModule,
		// Token: 0x04000A08 RID: 2568
		BadAlloc,
		// Token: 0x04000A09 RID: 2569
		BadConnection
	}
}
