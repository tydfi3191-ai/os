using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

// Token: 0x020009A6 RID: 2470
public static class 1639
{
	// Token: 0x0600453A RID: 17722 RVA: 0x001B3CE0 File Offset: 0x001B1EE0
	public static byte[] 1(byte[] 1, int 2, int 3)
	{
		if (1 == null || 1.Length == 0)
		{
			return 1;
		}
		byte[] result;
		try
		{
			using (MemoryStream memoryStream = new MemoryStream(1))
			{
				using (Image image = Image.FromStream(memoryStream))
				{
					if (image.Width == 2 && image.Height == 3)
					{
						result = 1;
					}
					else
					{
						using (Bitmap bitmap = 1639.3(image, 2, 3))
						{
							using (MemoryStream memoryStream2 = new MemoryStream())
							{
								bitmap.Save(memoryStream2, ImageFormat.Jpeg);
								result = memoryStream2.ToArray();
							}
						}
					}
				}
			}
		}
		catch (Exception)
		{
			result = 1;
		}
		return result;
	}

	// Token: 0x0600453B RID: 17723 RVA: 0x001B3DB4 File Offset: 0x001B1FB4
	public static void 2(string 1, int 2, int 3)
	{
		if (string.IsNullOrEmpty(1) || !File.Exists(1))
		{
			return;
		}
		byte[] array = File.ReadAllBytes(1);
		byte[] array2 = 1639.1(array, 2, 3);
		if (array2 != array)
		{
			File.WriteAllBytes(1, array2);
		}
	}

	// Token: 0x0600453C RID: 17724 RVA: 0x001B3DF0 File Offset: 0x001B1FF0
	private static Bitmap 3(Image 1, int 2, int 3)
	{
		float num = (float)2 / (float)3;
		RectangleF srcRect = ((float)1.Width / (float)1.Height > num) ? new RectangleF(((float)1.Width - (float)1.Height * num) / 2f, 0f, (float)1.Height * num, (float)1.Height) : new RectangleF(0f, ((float)1.Height - (float)1.Width / num) / 2f, (float)1.Width, (float)1.Width / num);
		Bitmap bitmap = new Bitmap(2, 3, PixelFormat.Format24bppRgb);
		Bitmap result;
		using (Graphics graphics = Graphics.FromImage(bitmap))
		{
			graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
			graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
			graphics.CompositingQuality = CompositingQuality.HighQuality;
			graphics.DrawImage(1, new RectangleF(0f, 0f, (float)2, (float)3), srcRect, GraphicsUnit.Pixel);
			result = bitmap;
		}
		return result;
	}

	// Token: 0x040032C0 RID: 12992
	public const int 1 = 80;

	// Token: 0x040032C1 RID: 12993
	public const int 2 = 60;

	// Token: 0x040032C2 RID: 12994
	public const int 3 = 160;

	// Token: 0x040032C3 RID: 12995
	public const int 4 = 120;
}
