using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

// Token: 0x02000547 RID: 1351
[276]
internal static class 2532
{
	// Token: 0x06002990 RID: 10640 RVA: 0x000D8144 File Offset: 0x000D6344
	internal static 1381 Circle(int 1)
	{
		return 2532.4("circle" + 1.ToString(), () => 2532.5(1, 1, delegate(Graphics 1)
		{
			1.FillEllipse(Brushes.White, 0.5f, 0.5f, (float)1 - 1f, (float)1 - 1f);
		}));
	}

	// Token: 0x06002991 RID: 10641 RVA: 0x000D8184 File Offset: 0x000D6384
	internal static 1381 1(int 1, float 2)
	{
		return 2532.4("ring" + 1.ToString() + "/" + 2.ToString(), () => 2532.5(1, 1, delegate(Graphics 1)
		{
			using (Pen pen = new Pen(Color.White, 2))
			{
				float num = 2 / 2f + 0.5f;
				1.DrawEllipse(pen, num, num, (float)1 - num * 2f, (float)1 - num * 2f);
			}
		}));
	}

	// Token: 0x06002992 RID: 10642 RVA: 0x000D81DC File Offset: 0x000D63DC
	internal static 1381 2(int 1, int 2, float 3)
	{
		4 = Math.Max(1, 4);
		2 = Math.Max(1, 2);
		float cornerSize = Math.Max(0f, Math.Min(0.5f, 3)) * (float)Math.Min(4, 2) * 2f;
		return 2532.5(4, 2, delegate(Graphics 1)
		{
			if (cornerSize < 1f)
			{
				1.FillRectangle(Brushes.White, 0, 0, 4, 2);
				return;
			}
			using (GraphicsPath graphicsPath = new GraphicsPath())
			{
				RectangleF rectangleF = new RectangleF(0f, 0f, (float)4, (float)2);
				graphicsPath.AddArc(rectangleF.X, rectangleF.Y, cornerSize, cornerSize, 180f, 90f);
				graphicsPath.AddArc(rectangleF.Right - cornerSize, rectangleF.Y, cornerSize, cornerSize, 270f, 90f);
				graphicsPath.AddArc(rectangleF.Right - cornerSize, rectangleF.Bottom - cornerSize, cornerSize, cornerSize, 0f, 90f);
				graphicsPath.AddArc(rectangleF.X, rectangleF.Bottom - cornerSize, cornerSize, cornerSize, 90f, 90f);
				graphicsPath.CloseFigure();
				1.FillPath(Brushes.White, graphicsPath);
			}
		});
	}

	// Token: 0x06002993 RID: 10643 RVA: 0x000D8274 File Offset: 0x000D6474
	internal static 1381 3(string 1)
	{
		1381 result;
		try
		{
			using (FileStream fileStream = new FileStream(1, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
			{
				using (Image image = Image.FromStream(fileStream, false, false))
				{
					using (Bitmap bitmap = new Bitmap(image))
					{
						result = 1381.15(bitmap, null);
					}
				}
			}
		}
		catch (Exception ex)
		{
			1338.4(ex, "loading a HUD image", 1341.Runtime);
			result = null;
		}
		return result;
	}

	// Token: 0x06002994 RID: 10644 RVA: 0x000D8308 File Offset: 0x000D6508
	private static 1381 4(string 1, Func<1381> 2)
	{
		1381 3;
		if (2532.1.TryGetValue(1, out 3) && 3 != null && !3.5())
		{
			return 3;
		}
		3 = 2();
		2532.1[1] = 3;
		return 3;
	}

	// Token: 0x06002995 RID: 10645 RVA: 0x000D8348 File Offset: 0x000D6548
	internal static 1381 5(int 1, int 2, Action<Graphics> 3)
	{
		1 = Math.Min(Math.Max(1, 1), 2048);
		2 = Math.Min(Math.Max(1, 2), 2048);
		1381 result;
		using (Bitmap bitmap = new Bitmap(1, 2, PixelFormat.Format32bppArgb))
		{
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.SmoothingMode = SmoothingMode.AntiAlias;
				graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
				graphics.Clear(Color.Transparent);
				3(graphics);
			}
			result = 1381.15(bitmap, null);
		}
		return result;
	}

	// Token: 0x04001E36 RID: 7734
	private static readonly Dictionary<string, 1381> 1 = new Dictionary<string, 1381>();
}
