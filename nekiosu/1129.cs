using System;
using System.Drawing;
using System.Windows.Forms;
using OpenTK.Graphics;
using OpenTK.Platform;
using OpenTK.Platform.MacOS;

// Token: 0x02000BF3 RID: 3059
public sealed class 1129 : 351
{
	// Token: 0x06005381 RID: 21377 RVA: 0x0020B153 File Offset: 0x00209353
	internal 1129(GraphicsMode 1, Control 2)
	{
		this.1 = 1;
		this.2 = 2;
		this.3 = Utilities.CreateMacOSCarbonWindowInfo(this.2.Handle, false, true);
	}

	// Token: 0x06005382 RID: 21378 RVA: 0x0020B184 File Offset: 0x00209384
	private int 1()
	{
		return this.2.Location.X;
	}

	// Token: 0x06005383 RID: 21379 RVA: 0x0020B1A4 File Offset: 0x002093A4
	private int 2()
	{
		if (this.2.TopLevelControl != null)
		{
			Point point = this.2.PointToScreen(this.2.Location);
			Point point2 = this.2.TopLevelControl.PointToScreen(Point.Empty);
			int num = point.Y - point2.Y;
			return this.2.TopLevelControl.ClientSize.Height - this.2.Bottom - num;
		}
		return this.2.Location.Y;
	}

	// Token: 0x06005384 RID: 21380 RVA: 0x0020B236 File Offset: 0x00209436
	public IGraphicsContext CreateContext(int 1, int 2, GraphicsContextFlags 3)
	{
		return new 1116(this.1, this.GetWindowInfo(), GraphicsContext.CurrentContext, new GetInt(this.1), new GetInt(this.2));
	}

	// Token: 0x06005385 RID: 21381 RVA: 0x0020B266 File Offset: 0x00209466
	public bool Method9556()
	{
		this.4 = !this.4;
		return this.4;
	}

	// Token: 0x06005386 RID: 21382 RVA: 0x0020B27D File Offset: 0x0020947D
	public IWindowInfo GetWindowInfo()
	{
		return this.3;
	}

	// Token: 0x04003F6B RID: 16235
	private GraphicsMode 1;

	// Token: 0x04003F6C RID: 16236
	private Control 2;

	// Token: 0x04003F6D RID: 16237
	private IWindowInfo 3;

	// Token: 0x04003F6E RID: 16238
	private bool 4;
}
