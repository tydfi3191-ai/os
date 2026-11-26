using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

// Token: 0x02000436 RID: 1078
public static class 2675
{
	// Token: 0x06002196 RID: 8598 RVA: 0x00090EB0 File Offset: 0x0008F0B0
	private static ImageCodecInfo 1(string 1)
	{
		ImageCodecInfo[] imageEncoders = ImageCodecInfo.GetImageEncoders();
		for (int i = 0; i < imageEncoders.Length; i++)
		{
			if (imageEncoders[i].MimeType == 1)
			{
				return imageEncoders[i];
			}
		}
		return null;
	}

	// Token: 0x06002197 RID: 8599 RVA: 0x00090EE8 File Offset: 0x0008F0E8
	internal static string 2(string 1, int 2, int 3)
	{
		if (2672.24(1) != (2670)12)
		{
			return 1;
		}
		ImageCodecInfo encoder = 2675.1("image/jpeg");
		EncoderParameters encoderParameters = new EncoderParameters(1);
		encoderParameters.Param[0] = new EncoderParameter(Encoder.Quality, 90L);
		string result;
		using (Image image = Image.FromFile(1))
		{
			if (image.Width <= 2 && image.Height <= 3)
			{
				result = 1;
			}
			else
			{
				float num = (image.Height > image.Width) ? ((float)2 / (float)image.Width) : ((float)3 / (float)image.Height);
				int width = (int)((float)image.Width * num);
				int height = (int)((float)image.Height * num);
				Bitmap bitmap = new Bitmap(width, height);
				try
				{
					using (Graphics graphics = Graphics.FromImage(bitmap))
					{
						graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
						graphics.SmoothingMode = SmoothingMode.HighQuality;
						graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
						graphics.CompositingQuality = CompositingQuality.HighQuality;
						graphics.DrawImage(image, 0, 0, width, height);
						string text = string.Format("{0}/{1}.jpg", Path.GetDirectoryName(1), Path.GetFileNameWithoutExtension(1));
						image.Dispose();
						File.Delete(1);
						bitmap.Save(text, encoder, encoderParameters);
						result = text;
					}
				}
				finally
				{
					((IDisposable)bitmap).Dispose();
				}
			}
		}
		return result;
	}
}
