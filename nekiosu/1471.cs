using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

// Token: 0x02000AF6 RID: 2806
public sealed class 1471 : Panel
{
	// Token: 0x06004E1A RID: 19994 RVA: 0x001EE6F5 File Offset: 0x001EC8F5
	public 1471()
	{
		this.BackColor = Color.FromArgb(128, 255, 255, 255);
		this.1 = 277.GetGlassCornerImage();
	}

	// Token: 0x06004E1B RID: 19995 RVA: 0x001EE728 File Offset: 0x001EC928
	protected override void OnPaintBackground(PaintEventArgs 1)
	{
		Graphics graphics = 1.Graphics;
		graphics.CompositingMode = CompositingMode.SourceCopy;
		graphics.Clear(Color.FromArgb(191, 255, 255, 255));
		int width = base.Width;
		int height = base.Height;
		if (width >= 8 && height >= 8)
		{
			Pen pen = new Pen(Color.FromArgb(223, 255, 255, 255));
			Pen pen2 = new Pen(Color.FromArgb(191, 0, 0, 0));
			Pen pen3 = new Pen(Color.FromArgb(128, 255, 255, 255));
			graphics.DrawRectangle(pen3, 0, 0, width - 1, height - 1);
			graphics.DrawRectangle(pen2, 1, 1, width - 3, height - 3);
			graphics.DrawRectangle(pen, 2, 2, width - 5, height - 5);
			graphics.DrawImage(this.1, new Rectangle(0, 0, 4, 4), new Rectangle(0, 0, 4, 4), GraphicsUnit.Pixel);
			graphics.DrawImage(this.1, new Rectangle(base.Width - 4, 0, 4, 4), new Rectangle(4, 0, 4, 4), GraphicsUnit.Pixel);
			graphics.DrawImage(this.1, new Rectangle(0, base.Height - 4, 4, 4), new Rectangle(0, 4, 4, 4), GraphicsUnit.Pixel);
			graphics.DrawImage(this.1, new Rectangle(base.Width - 4, base.Height - 4, 4, 4), new Rectangle(4, 4, 4, 4), GraphicsUnit.Pixel);
		}
	}

	// Token: 0x04003A41 RID: 14913
	private Bitmap 1;
}
