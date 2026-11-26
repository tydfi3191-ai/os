using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using OpenTK.Graphics.ES20;

// Token: 0x0200043D RID: 1085
public sealed class 2682
{
	// Token: 0x060021CE RID: 8654 RVA: 0x00091DE0 File Offset: 0x0008FFE0
	internal unsafe static void 1(bool 1)
	{
		try
		{
			2682.2683 captureClosure = new 2682.2683();
			1226.24("shutter", 100, (1416)3, false);
			string text = Path.Combine(1345.4(), "Screenshots");
			Directory.CreateDirectory(text);
			captureClosure.1 = string.Empty;
			int num = 1304.162;
			do
			{
				num++;
				captureClosure.1 = Path.Combine(text, string.Format("screenshot{0:000}", num));
			}
			while (File.Exists(captureClosure.1 + ".jpg") || File.Exists(captureClosure.1 + ".png"));
			captureClosure.1 = captureClosure.1 + "." + 1304.159.ToString().ToLower();
			Bitmap bitmap = new Bitmap(1662.70.1, 1662.70.2, PixelFormat.Format32bppArgb);
			try
			{
				int 2 = 1662.70.1;
				int 3 = 1662.70.2;
				BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, bitmap.PixelFormat);
				GL.ReadPixels(1379.28.Left, 1379.28.Top, 2, 3, 6408, 5121, bitmapData.Scan0);
				byte* ptr = (byte*)((void*)bitmapData.Scan0);
				for (int i = 0; i < 3; i++)
				{
					byte* ptr2 = ptr + i * bitmapData.Stride;
					for (int j = 0; j < 2 * 4; j += 4)
					{
						byte* ptr3 = ptr2 + j;
						byte b = *ptr3;
						*ptr3 = ptr3[2];
						ptr3[2] = b;
					}
				}
				bitmap.UnlockBits(bitmapData);
				bitmap.RotateFlip(RotateFlipType.Rotate180FlipX);
				using (Bitmap bitmap2 = bitmap.Clone(new Rectangle(0, 0, bitmap.Width, bitmap.Height), PixelFormat.Format24bppRgb))
				{
					bitmap2.Save(captureClosure.1, (1304.159 == 1207.Jpg) ? ImageFormat.Jpeg : ImageFormat.Png);
				}
			}
			finally
			{
				((IDisposable)bitmap).Dispose();
			}
			1304.162.7(num);
			1804.1();
			1763.5("Saved screenshot to " + captureClosure.1, 198.BlueViolet, 6000, delegate
			{
				1662.67(captureClosure.1);
			});
		}
		catch
		{
			1763.5("Screnshot capture failed!", 198.Red, 3000, null);
		}
	}

	// Token: 0x0200043E RID: 1086
	public sealed class 2683
	{
		// Token: 0x0400172E RID: 5934
		public string 1;
	}
}
