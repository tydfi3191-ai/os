using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;
using OpenTK.Graphics;
using OpenTK.Platform;

// Token: 0x020002B9 RID: 697
public sealed class 434 : 351
{
	// Token: 0x06001500 RID: 5376 RVA: 0x0004918C File Offset: 0x0004738C
	public 434(GraphicsMode 1, Control 2, GraphicsContextFlags 3)
	{
		this.graphicsMode2 = 1;
		this.iWindowInfo = Utilities.CreateWindowsWindowInfo(2.Handle);
		GraphicsContextFlags graphicsContextFlags = 240;
		if ((3 & graphicsContextFlags) > 0)
		{
			this.iWindowInfo = Utilities.CreateAngleWindowInfo(this.iWindowInfo);
		}
	}

	// Token: 0x06001501 RID: 5377
	[SuppressUnmanagedCodeSecurity]
	[DllImport("user32.dll")]
	private static extern bool PeekMessage(ref 434.435 1, IntPtr 2, int 3, int 4, int 5);

	// Token: 0x06001502 RID: 5378 RVA: 0x000491D4 File Offset: 0x000473D4
	public IGraphicsContext CreateContext(int 1, int 2, GraphicsContextFlags 3)
	{
		return new GraphicsContext(this.graphicsMode2, this.iWindowInfo, 1, 2, 3);
	}

	// Token: 0x06001503 RID: 5379 RVA: 0x000491EA File Offset: 0x000473EA
	public bool Method9556()
	{
		return !434.PeekMessage(ref this.msg, IntPtr.Zero, 0, 0, 0);
	}

	// Token: 0x06001504 RID: 5380 RVA: 0x00049202 File Offset: 0x00047402
	public IWindowInfo GetWindowInfo()
	{
		return this.iWindowInfo;
	}

	// Token: 0x040009DD RID: 2525
	private 434.435 msg;

	// Token: 0x040009DE RID: 2526
	private IWindowInfo iWindowInfo;

	// Token: 0x040009DF RID: 2527
	private GraphicsMode graphicsMode2;

	// Token: 0x020002BA RID: 698
	public struct 436
	{
		// Token: 0x06001505 RID: 5381 RVA: 0x0004920A File Offset: 0x0004740A
		public 436(int 1, int 2)
		{
			this.x = 1;
			this.y = 2;
		}

		// Token: 0x06001506 RID: 5382 RVA: 0x0004921A File Offset: 0x0004741A
		public Point ToPoint()
		{
			return new Point(this.x, this.y);
		}

		// Token: 0x06001507 RID: 5383 RVA: 0x00049230 File Offset: 0x00047430
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"Point {",
				this.x.ToString(),
				", ",
				this.y.ToString(),
				")"
			});
		}

		// Token: 0x040009E0 RID: 2528
		public int x;

		// Token: 0x040009E1 RID: 2529
		public int y;
	}

	// Token: 0x020002BB RID: 699
	public struct 435
	{
		// Token: 0x06001508 RID: 5384 RVA: 0x0004927C File Offset: 0x0004747C
		public override string ToString()
		{
			return string.Format("msg=0x{0:x} ({1}) hwnd=0x{2:x} wparam=0x{3:x} lparam=0x{4:x} pt=0x{5:x}", new object[]
			{
				(int)this.message,
				this.message.ToString(),
				this.hwnd.ToInt32(),
				this.wParam.ToInt32(),
				this.lParam.ToInt32(),
				this.point
			});
		}

		// Token: 0x040009E2 RID: 2530
		public IntPtr hwnd;

		// Token: 0x040009E3 RID: 2531
		public uint message;

		// Token: 0x040009E4 RID: 2532
		public IntPtr wParam;

		// Token: 0x040009E5 RID: 2533
		public IntPtr lParam;

		// Token: 0x040009E6 RID: 2534
		public uint time;

		// Token: 0x040009E7 RID: 2535
		public 434.436 point;
	}
}
