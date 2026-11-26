using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

// Token: 0x020002CD RID: 717
public sealed class 754 : Label
{
	// Token: 0x06001561 RID: 5473 RVA: 0x000496C4 File Offset: 0x000478C4
	protected override void OnPaint(PaintEventArgs 1)
	{
		if (this.BackColor.A < 255)
		{
			Graphics graphics = 1.Graphics;
			Bitmap bitmap = new Bitmap(base.Size.Width, base.Size.Height, PixelFormat.Format32bppArgb);
			Graphics graphics2 = Graphics.FromImage(bitmap);
			graphics2.Clear(Color.Black);
			graphics2.DrawString(this.Text, this.Font, this.solidBrush, new PointF(0f, 0f), this.stringFormat);
			this.Method12197(bitmap, this.ForeColor);
			graphics.DrawImageUnscaled(bitmap, new Point(0, 0));
			return;
		}
		base.OnPaint(1);
	}

	// Token: 0x06001562 RID: 5474 RVA: 0x00049778 File Offset: 0x00047978
	private unsafe void Method12197(Bitmap 1, Color 2)
	{
		Rectangle rect = new Rectangle(0, 0, 1.Width, 1.Height);
		int num = 1.Width * 4;
		int height = 1.Height;
		BitmapData bitmapData = 1.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
		int stride = bitmapData.Stride;
		byte r = 2.R;
		byte g = 2.G;
		byte b = 2.B;
		byte* ptr = (byte*)((void*)bitmapData.Scan0);
		for (int i = 0; i < height; i++)
		{
			int num2 = i * stride;
			for (int j = 0; j < num; j += 4)
			{
				byte b2 = ptr[num2 + j + 1];
				ptr[num2 + j] = b;
				ptr[num2 + j + 1] = g;
				ptr[num2 + j + 2] = r;
				ptr[num2 + j + 3] = b2;
			}
		}
		1.UnlockBits(bitmapData);
	}

	// Token: 0x04000A1B RID: 2587
	private StringFormat stringFormat = new StringFormat();

	// Token: 0x04000A1C RID: 2588
	private SolidBrush solidBrush = new SolidBrush(Color.White);
}
