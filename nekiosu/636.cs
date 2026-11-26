using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using OpenTK.Graphics;
using OpenTK.Platform;

// Token: 0x020002CB RID: 715
public sealed class 636 : 351
{
	// Token: 0x0600155C RID: 5468 RVA: 0x00049679 File Offset: 0x00047879
	public 636(GraphicsMode 1, Control 2)
	{
		this.graphicsMode2 = 1;
		this.iWindowInfo = Utilities.CreateSdl2WindowInfo(2.Handle);
	}

	// Token: 0x0600155D RID: 5469 RVA: 0x00049699 File Offset: 0x00047899
	public IGraphicsContext CreateContext(int 1, int 2, GraphicsContextFlags 3)
	{
		return new GraphicsContext(this.graphicsMode2, this.iWindowInfo, 1, 2, 3);
	}

	// Token: 0x0600155E RID: 5470 RVA: 0x000496AF File Offset: 0x000478AF
	public bool Method9556()
	{
		return 636.637.HasEvents(0, 65535);
	}

	// Token: 0x0600155F RID: 5471 RVA: 0x000496BC File Offset: 0x000478BC
	public IWindowInfo GetWindowInfo()
	{
		return this.iWindowInfo;
	}

	// Token: 0x04000A19 RID: 2585
	private IWindowInfo iWindowInfo;

	// Token: 0x04000A1A RID: 2586
	private GraphicsMode graphicsMode2;

	// Token: 0x020002CC RID: 716
	public static class 637
	{
		// Token: 0x06001560 RID: 5472
		[DllImport("SDL2.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "SDL_HasEvents")]
		public static extern bool HasEvents(int 1, int 2);
	}
}
