using System;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x02000631 RID: 1585
public sealed class 2305 : Button
{
	// Token: 0x06003002 RID: 12290 RVA: 0x00110230 File Offset: 0x0010E430
	public 2305()
	{
		if (2305.1 == null)
		{
			2305.1 = 277.GetGlassButtonImage();
		}
		base.MouseEnter += delegate(object 1, EventArgs 2)
		{
			this.3 = true;
			base.Invalidate();
		};
		base.MouseLeave += this.3;
	}

	// Token: 0x06003003 RID: 12291 RVA: 0x0011027F File Offset: 0x0010E47F
	public Color 1()
	{
		return this.2;
	}

	// Token: 0x06003004 RID: 12292 RVA: 0x00110287 File Offset: 0x0010E487
	public void 2(Color 1)
	{
		this.2 = 1;
		base.Invalidate();
	}

	// Token: 0x06003005 RID: 12293 RVA: 0x00110296 File Offset: 0x0010E496
	protected override void OnPaintBackground(PaintEventArgs 1)
	{
		base.OnPaintBackground(1);
	}

	// Token: 0x06003006 RID: 12294 RVA: 0x001102A0 File Offset: 0x0010E4A0
	protected override void OnPaint(PaintEventArgs 1)
	{
		this.OnPaintBackground(1);
		Graphics graphics = 1.Graphics;
		int width = base.Width;
		int height = base.Height;
		Brush brush = new SolidBrush(this.2);
		if (width < 22 || height < 22)
		{
			graphics.FillRectangle(brush, 0, 0, width, height);
			return;
		}
		graphics.FillRectangle(brush, 3, 1, width - 6, 1);
		graphics.FillRectangle(brush, 2, 2, width - 4, 1);
		graphics.FillRectangle(brush, 1, 3, width - 2, height - 6);
		graphics.FillRectangle(brush, 2, height - 3, width - 4, 1);
		graphics.FillRectangle(brush, 3, height - 2, width - 6, 1);
		int num = (!this.3) ? 1 : 2;
		for (int i = 0; i < num; i++)
		{
			graphics.DrawImage(2305.1, new Rectangle(0, 0, 11, 11), new Rectangle(0, 0, 11, 11), GraphicsUnit.Pixel);
			graphics.DrawImage(2305.1, new Rectangle(width - 11, 0, 11, 11), new Rectangle(21, 0, 11, 11), GraphicsUnit.Pixel);
			graphics.DrawImage(2305.1, new Rectangle(0, height - 11, 11, 11), new Rectangle(0, 21, 11, 11), GraphicsUnit.Pixel);
			graphics.DrawImage(2305.1, new Rectangle(width - 11, height - 11, 11, 11), new Rectangle(21, 21, 11, 11), GraphicsUnit.Pixel);
			graphics.DrawImage(2305.1, new Rectangle(11, 0, width - 22, 11), new Rectangle(11, 0, 10, 11), GraphicsUnit.Pixel);
			graphics.DrawImage(2305.1, new Rectangle(0, 11, 11, height - 22), new Rectangle(0, 11, 11, 10), GraphicsUnit.Pixel);
			graphics.DrawImage(2305.1, new Rectangle(11, height - 11, width - 22, 11), new Rectangle(11, 21, 10, 11), GraphicsUnit.Pixel);
			graphics.DrawImage(2305.1, new Rectangle(width - 11, 11, 11, height - 22), new Rectangle(21, 11, 11, 10), GraphicsUnit.Pixel);
		}
		Brush brush2 = new SolidBrush(this.ForeColor);
		Brush brush3 = new SolidBrush(Color.FromArgb(191, 0, 0, 0));
		StringFormat stringFormat = new StringFormat();
		stringFormat.Alignment = StringAlignment.Center;
		stringFormat.LineAlignment = StringAlignment.Center;
		Point p = new Point(width / 2, height / 2);
		graphics.DrawString(this.Text, this.Font, brush3, new Point(p.X, p.Y + 1), stringFormat);
		graphics.DrawString(this.Text, this.Font, brush2, p, stringFormat);
	}

	// Token: 0x06003007 RID: 12295 RVA: 0x00110521 File Offset: 0x0010E721
	private void 3(object 1, EventArgs 2)
	{
		this.3 = false;
		base.Invalidate();
	}

	// Token: 0x04002297 RID: 8855
	private static Bitmap 1;

	// Token: 0x04002298 RID: 8856
	private Color 2;

	// Token: 0x04002299 RID: 8857
	private bool 3;

	// Token: 0x0400229A RID: 8858
	public bool 4 = true;
}
