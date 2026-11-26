using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using OpenTK.Graphics;
using OpenTK.Platform;

// Token: 0x020002C9 RID: 713
public sealed class 633 : 351
{
	// Token: 0x06001551 RID: 5457 RVA: 0x000493F0 File Offset: 0x000475F0
	internal 633(GraphicsMode 1, Control 2)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=zB5lEg5c=");
		}
		if (2 == null)
		{
			throw new ArgumentNullException("#=zz7wbM4E=");
		}
		this.graphicsMode2 = new GraphicsMode(new ColorFormat(1.ColorFormat.Red, 1.ColorFormat.Green, 1.ColorFormat.Blue, 0), 1.Depth, 1.Stencil, 1.Samples, 1.AccumulatorFormat, 1.Buffers, 1.Stereo);
		if (this.xplatUiX11Type == null)
		{
			throw new PlatformNotSupportedException("System.Windows.Forms.XplatUIX11 missing. Unsupported platform or Mono runtime version, aborting.");
		}
		this.display = (IntPtr)633.GetStaticField(this.xplatUiX11Type, "DisplayHandle");
		this.rootWindow = (IntPtr)633.GetStaticField(this.xplatUiX11Type, "RootWindow");
		int num = (int)633.GetStaticField(this.xplatUiX11Type, "ScreenNo");
		this.iWindowInfo = Utilities.CreateX11WindowInfo(this.display, num, 2.Handle, this.rootWindow, IntPtr.Zero);
	}

	// Token: 0x06001552 RID: 5458
	[DllImport("libX11")]
	private static extern IntPtr XCreateColormap(IntPtr 1, IntPtr 2, IntPtr 3, int 4);

	// Token: 0x06001553 RID: 5459
	[DllImport("libX11")]
	private static extern IntPtr XGetVisualInfo(IntPtr 1, IntPtr 2, ref 633.634 3, out int 4);

	// Token: 0x06001554 RID: 5460 RVA: 0x00049516 File Offset: 0x00047716
	private static IntPtr GetVisualInfo(IntPtr 1, int 2, ref 633.634 3, out int 4)
	{
		return 633.XGetVisualInfo(1, (IntPtr)2, ref 3, out 4);
	}

	// Token: 0x06001555 RID: 5461
	[DllImport("libX11")]
	private static extern int XPending(IntPtr 1);

	// Token: 0x06001556 RID: 5462 RVA: 0x00049528 File Offset: 0x00047728
	public IGraphicsContext CreateContext(int 1, int 2, GraphicsContextFlags 3)
	{
		GraphicsContext graphicsContext = new GraphicsContext(this.graphicsMode2, this.GetWindowInfo(), 1, 2, 3);
		this.graphicsMode2 = graphicsContext.GraphicsMode;
		633.634 4 = new 633.634
		{
			visualId = this.graphicsMode2.Index.Value
		};
		int num;
		4 = (633.634)Marshal.PtrToStructure(633.GetVisualInfo(this.display, 1, ref 4, out num), typeof(633.634));
		633.SetStaticField(this.xplatUiX11Type, "CustomVisual", 4.visual);
		633.SetStaticField(this.xplatUiX11Type, "CustomColormap", 633.XCreateColormap(this.display, this.rootWindow, 4.visual, 0));
		return graphicsContext;
	}

	// Token: 0x06001557 RID: 5463 RVA: 0x000495E8 File Offset: 0x000477E8
	public bool Method9556()
	{
		return 633.XPending(this.display) == 0;
	}

	// Token: 0x06001558 RID: 5464 RVA: 0x000495F8 File Offset: 0x000477F8
	public IWindowInfo GetWindowInfo()
	{
		return this.iWindowInfo;
	}

	// Token: 0x06001559 RID: 5465 RVA: 0x00049600 File Offset: 0x00047800
	private static object GetStaticField(Type 1, string 2)
	{
		return 1.GetField(2, BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);
	}

	// Token: 0x0600155A RID: 5466 RVA: 0x00049611 File Offset: 0x00047811
	private static void SetStaticField(Type 1, string 2, object 3)
	{
		1.GetField(2, BindingFlags.Static | BindingFlags.NonPublic).SetValue(null, 3);
	}

	// Token: 0x04000A0A RID: 2570
	private GraphicsMode graphicsMode2;

	// Token: 0x04000A0B RID: 2571
	private IWindowInfo iWindowInfo;

	// Token: 0x04000A0C RID: 2572
	private IntPtr display;

	// Token: 0x04000A0D RID: 2573
	private IntPtr rootWindow;

	// Token: 0x04000A0E RID: 2574
	private Type xplatUiX11Type = Type.GetType("System.Windows.Forms.XplatUIX11, System.Windows.Forms");

	// Token: 0x020002CA RID: 714
	public struct 634
	{
		// Token: 0x0600155B RID: 5467 RVA: 0x00049624 File Offset: 0x00047824
		public override string ToString()
		{
			return string.Format("id ({0}), screen ({1}), depth ({2}), class ({3})", new object[]
			{
				this.visualId,
				this.screen,
				this.depth,
				this.visualClass
			});
		}

		// Token: 0x04000A0F RID: 2575
		public IntPtr visual;

		// Token: 0x04000A10 RID: 2576
		public IntPtr visualId;

		// Token: 0x04000A11 RID: 2577
		public int screen;

		// Token: 0x04000A12 RID: 2578
		public int depth;

		// Token: 0x04000A13 RID: 2579
		public int visualClass;

		// Token: 0x04000A14 RID: 2580
		public long redMask;

		// Token: 0x04000A15 RID: 2581
		public long greenMask;

		// Token: 0x04000A16 RID: 2582
		public long blueMask;

		// Token: 0x04000A17 RID: 2583
		public int colormapSize;

		// Token: 0x04000A18 RID: 2584
		public int bitsPerRgb;
	}
}
