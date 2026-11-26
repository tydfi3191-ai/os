using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

// Token: 0x0200069A RID: 1690
[276]
internal static class 2226
{
	// Token: 0x060032AE RID: 12974 RVA: 0x00134294 File Offset: 0x00132494
	internal static string 1(string 1)
	{
		byte[] array;
		using (MD5 md = MD5.Create())
		{
			array = md.ComputeHash(Encoding.UTF8.GetBytes((1 ?? string.Empty).Trim().ToLowerInvariant()));
		}
		StringBuilder stringBuilder = new StringBuilder("profile_");
		foreach (byte b in array)
		{
			stringBuilder.Append(b.ToString("x2"));
		}
		string picturesDirectory = 268.PicturesDirectory;
		StringBuilder stringBuilder2 = stringBuilder;
		string text = Path.Combine(picturesDirectory, ((stringBuilder2 != null) ? stringBuilder2.ToString() : null) + ".jpg");
		string path = 1654.1();
		StringBuilder stringBuilder3 = stringBuilder;
		string text2 = Path.Combine(path, ((stringBuilder3 != null) ? stringBuilder3.ToString() : null) + ".jpg");
		try
		{
			if (!File.Exists(text) && File.Exists(text2))
			{
				Directory.CreateDirectory(Path.GetDirectoryName(text));
				File.Move(text2, text);
			}
		}
		catch (Exception)
		{
		}
		return text;
	}

	// Token: 0x060032AF RID: 12975 RVA: 0x001343A0 File Offset: 0x001325A0
	internal static bool 2(string 1)
	{
		return !string.IsNullOrWhiteSpace(1) && File.Exists(2226.1(1));
	}

	// Token: 0x060032B0 RID: 12976 RVA: 0x001343B8 File Offset: 0x001325B8
	internal static void 3(string 1)
	{
		if (string.IsNullOrWhiteSpace(1))
		{
			1763.5("Set a profile name first.", 198.Orange, 4000, null);
			return;
		}
		string fileName;
		using (OpenFileDialog openFileDialog = new OpenFileDialog())
		{
			openFileDialog.Title = "Choose a picture for the profile " + 1;
			openFileDialog.Filter = "Images (*.png;*.jpg;*.jpeg;*.bmp;*.gif)|*.png;*.jpg;*.jpeg;*.bmp;*.gif|All files|*.*";
			openFileDialog.RestoreDirectory = true;
			if (1662.52(openFileDialog) != DialogResult.OK)
			{
				return;
			}
			fileName = openFileDialog.FileName;
		}
		string text = 2226.1(1);
		string text2 = text + ".tmp";
		try
		{
			Directory.CreateDirectory(Path.GetDirectoryName(text));
			File.Copy(fileName, text2, true);
			1639.2(text2, 256, 256);
			if (File.Exists(text))
			{
				File.Delete(text);
			}
			File.Move(text2, text);
		}
		catch (Exception ex)
		{
			1338.4(ex, "setting a profile picture from " + fileName, 1341.Runtime);
			1763.5("This image could not be used as a profile picture.", 198.OrangeRed, 5000, null);
			2226.6(text2);
			return;
		}
		2226.5();
		1763.5("Profile picture set for " + 1 + ".", 198.YellowGreen, 3000, null);
	}

	// Token: 0x060032B1 RID: 12977 RVA: 0x001344EC File Offset: 0x001326EC
	internal static void 4(string 1, byte[] 2)
	{
		string text = 2226.1(1);
		string text2 = text + ".tmp";
		try
		{
			Directory.CreateDirectory(Path.GetDirectoryName(text));
			File.WriteAllBytes(text2, 2);
			1639.2(text2, 256, 256);
			if (File.Exists(text))
			{
				File.Delete(text);
			}
			File.Move(text2, text);
		}
		catch (Exception ex)
		{
			1338.4(ex, "setting a profile picture", 1341.Runtime);
			2226.6(text2);
			return;
		}
		2226.5();
	}

	// Token: 0x060032B2 RID: 12978 RVA: 0x00134570 File Offset: 0x00132770
	internal static void Remove(string 1)
	{
		2226.6(2226.1(1));
		2226.5();
	}

	// Token: 0x060032B3 RID: 12979 RVA: 0x00134584 File Offset: 0x00132784
	internal static void Move(string 1, string 2)
	{
		string text = 2226.1(1);
		string text2 = 2226.1(2);
		if (text == text2 || !File.Exists(text))
		{
			return;
		}
		try
		{
			2226.6(text2);
			File.Move(text, text2);
		}
		catch (Exception ex)
		{
			1338.4(ex, "moving a profile picture", 1341.Runtime);
		}
		2226.5();
	}

	// Token: 0x060032B4 RID: 12980 RVA: 0x001345E4 File Offset: 0x001327E4
	internal static void Copy(string 1, string 2)
	{
		string text = 2226.1(1);
		if (!File.Exists(text))
		{
			return;
		}
		try
		{
			File.Copy(text, 2226.1(2), true);
		}
		catch (Exception ex)
		{
			1338.4(ex, "copying a profile picture", 1341.Runtime);
		}
	}

	// Token: 0x060032B5 RID: 12981 RVA: 0x00134630 File Offset: 0x00132830
	internal static void 5()
	{
		1654 <<EMPTY_NAME>> = 1662.100;
		if (<<EMPTY_NAME>> == null)
		{
			return;
		}
		<<EMPTY_NAME>>.9();
	}

	// Token: 0x060032B6 RID: 12982 RVA: 0x00134644 File Offset: 0x00132844
	private static void 6(string 1)
	{
		try
		{
			if (File.Exists(1))
			{
				File.Delete(1);
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x0400257B RID: 9595
	private const int 1 = 256;
}
