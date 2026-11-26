using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

// Token: 0x0200069B RID: 1691
[276]
internal static class 2227
{
	// Token: 0x060032B7 RID: 12983 RVA: 0x00134674 File Offset: 0x00132874
	internal static void 1(string 1, bool 2)
	{
		string fileName;
		using (SaveFileDialog saveFileDialog = new SaveFileDialog())
		{
			saveFileDialog.Title = "Export the profile " + 1;
			saveFileDialog.Filter = "nekiosu profile (*.nekiprofile)|*.nekiprofile";
			saveFileDialog.FileName = 2227.5(1) + ".nekiprofile";
			saveFileDialog.RestoreDirectory = true;
			if (1662.52(saveFileDialog) != DialogResult.OK)
			{
				return;
			}
			fileName = saveFileDialog.FileName;
		}
		try
		{
			1763.5(string.Concat(new string[]
			{
				"Profile ",
				1,
				" exported (",
				2227.2(1, fileName, 2).ToString(),
				" play(s))."
			}), 198.YellowGreen, 4000, null);
		}
		catch (Exception ex)
		{
			1338.4(ex, "exporting the profile " + 1 + " to " + fileName, 1341.Runtime);
			1763.5("The profile could not be exported.", 198.OrangeRed, 5000, null);
		}
	}

	// Token: 0x060032B8 RID: 12984 RVA: 0x00134778 File Offset: 0x00132978
	internal static string Import()
	{
		string fileName;
		using (OpenFileDialog openFileDialog = new OpenFileDialog())
		{
			openFileDialog.Title = "Import a profile";
			openFileDialog.Filter = "nekiosu profile (*.nekiprofile)|*.nekiprofile|All files|*.*";
			openFileDialog.RestoreDirectory = true;
			if (1662.52(openFileDialog) != DialogResult.OK)
			{
				return null;
			}
			fileName = openFileDialog.FileName;
		}
		string result;
		try
		{
			int num;
			int num2;
			string text = 2227.3(fileName, out num, out num2);
			1763.5(string.Concat(new string[]
			{
				"Profile ",
				text,
				" imported (",
				num.ToString(),
				" play(s)",
				(num2 > 0) ? (", " + num2.ToString() + " already here") : string.Empty,
				")."
			}), 198.YellowGreen, 4000, null);
			result = text;
		}
		catch (Exception ex)
		{
			1338.4(ex, "importing a profile from " + fileName, 1341.Runtime);
			1763.5("This file could not be read as a nekiosu profile.", 198.OrangeRed, 5000, null);
			result = null;
		}
		return result;
	}

	// Token: 0x060032B9 RID: 12985 RVA: 0x00134890 File Offset: 0x00132A90
	private static int 2(string 1, string 2, bool 3)
	{
		List<2241> list = 2210.17(1);
		string text = 2 + ".tmp";
		using (BinaryWriter binaryWriter = new BinaryWriter(File.Create(text), Encoding.UTF8))
		{
			binaryWriter.Write("nekiosu-profile");
			binaryWriter.Write(3);
			binaryWriter.Write(1);
			double? num = 2210.20(1, 2147.Osu);
			binaryWriter.Write(num != null);
			binaryWriter.Write(num.GetValueOrDefault());
			binaryWriter.Write(2210.13(1, 2147.Osu));
			foreach (2147 4 in 2227.3)
			{
				double? num2 = 2210.20(1, 4);
				binaryWriter.Write(num2 != null);
				binaryWriter.Write(num2.GetValueOrDefault());
				binaryWriter.Write(2210.13(1, 4));
			}
			Dictionary<string, int> dictionary = 2210.22(1);
			binaryWriter.Write(dictionary.Count);
			foreach (KeyValuePair<string, int> keyValuePair in dictionary)
			{
				binaryWriter.Write(keyValuePair.Key);
				binaryWriter.Write(keyValuePair.Value);
			}
			2227.6(binaryWriter, 2226.2(1) ? File.ReadAllBytes(2226.1(1)) : null);
			binaryWriter.Write(list.Count);
			foreach (2241 5 in list)
			{
				2227.6(binaryWriter, 2230.25(5));
				2210.2217 6 = 2210.18(5, 1);
				binaryWriter.Write(6.1 != null);
				binaryWriter.Write(6.1.GetValueOrDefault());
				binaryWriter.Write(6.2 ?? string.Empty);
				binaryWriter.Write(6.3);
				binaryWriter.Write(6.4);
				binaryWriter.Write(6.5 ?? string.Empty);
				binaryWriter.Write(6.6);
				binaryWriter.Write(6.7);
				2227.6(binaryWriter, (3 && 5.8()) ? File.ReadAllBytes(5.7()) : null);
			}
		}
		if (File.Exists(2))
		{
			File.Delete(2);
		}
		File.Move(text, 2);
		return list.Count;
	}

	// Token: 0x060032BA RID: 12986 RVA: 0x00134B40 File Offset: 0x00132D40
	private static string 3(string 1, out int 2, out int 3)
	{
		2 = 0;
		3 = 0;
		string result;
		using (BinaryReader binaryReader = new BinaryReader(File.OpenRead(6), Encoding.UTF8))
		{
			int num = (binaryReader.ReadString() == "nekiosu-profile") ? binaryReader.ReadInt32() : int.MaxValue;
			if (num > 3)
			{
				throw new InvalidDataException("not a nekiosu profile file (or one of a newer nekiosu)");
			}
			string text = 2227.4(binaryReader.ReadString());
			bool flag = binaryReader.ReadBoolean();
			double num2 = binaryReader.ReadDouble();
			double num3 = binaryReader.ReadDouble();
			List<KeyValuePair<2147, double?>> list = new List<KeyValuePair<2147, double?>>();
			List<KeyValuePair<2147, double>> list2 = new List<KeyValuePair<2147, double>>();
			if (num >= 2)
			{
				foreach (2147 key in 2227.3)
				{
					bool flag2 = binaryReader.ReadBoolean();
					double value = binaryReader.ReadDouble();
					list.Add(new KeyValuePair<2147, double?>(key, flag2 ? new double?(value) : null));
					list2.Add(new KeyValuePair<2147, double>(key, binaryReader.ReadDouble()));
				}
			}
			Dictionary<string, int> dictionary = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
			int num4 = binaryReader.ReadInt32();
			for (int j = 0; j < num4; j++)
			{
				string key2 = binaryReader.ReadString();
				dictionary[key2] = binaryReader.ReadInt32();
			}
			byte[] array2 = 2227.7(binaryReader);
			int num5 = binaryReader.ReadInt32();
			List<KeyValuePair<2241, 2210.2217>> list3 = new List<KeyValuePair<2241, 2210.2217>>();
			for (int k = 0; k < num5; k++)
			{
				2241 4 = 2230.26(2227.7(binaryReader));
				2210.2217 5 = new 2210.2217();
				bool flag3 = binaryReader.ReadBoolean();
				double value2 = binaryReader.ReadDouble();
				5.1 = (flag3 ? new double?(value2) : null);
				5.2 = binaryReader.ReadString();
				5.3 = binaryReader.ReadInt32();
				5.4 = binaryReader.ReadInt32();
				string text2 = binaryReader.ReadString();
				5.5 = ((text2.Length > 0) ? text2 : null);
				5.6 = binaryReader.ReadBoolean();
				5.7 = (num >= 3 && binaryReader.ReadBoolean());
				byte[] array3 = 2227.7(binaryReader);
				if (4 != null)
				{
					4.23 = text;
					if (array3 != null && !4.8())
					{
						try
						{
							Directory.CreateDirectory(Path.GetDirectoryName(4.7()));
							File.WriteAllBytes(4.7(), array3);
						}
						catch (Exception ex)
						{
							1338.4(ex, "writing an imported replay", 1341.Runtime);
						}
					}
					list3.Add(new KeyValuePair<2241, 2210.2217>(4, 5));
				}
			}
			2210.24(text);
			foreach (KeyValuePair<2241, 2210.2217> keyValuePair in list3)
			{
				2210.19(keyValuePair.Key, keyValuePair.Value);
			}
			if (flag)
			{
				2210.54(text, num2, 2147.Osu);
			}
			2210.21(text, num3, 2147.Osu);
			foreach (KeyValuePair<2147, double?> keyValuePair2 in list)
			{
				if (keyValuePair2.Value != null)
				{
					2210.54(text, keyValuePair2.Value.Value, keyValuePair2.Key);
				}
			}
			foreach (KeyValuePair<2147, double> keyValuePair3 in list2)
			{
				2210.21(text, keyValuePair3.Value, keyValuePair3.Key);
			}
			if (dictionary.Count > 0)
			{
				2210.23(text, dictionary);
			}
			2210.Save();
			List<2241> list4 = list3.ConvertAll<2241>((KeyValuePair<2241, 2210.2217> 1) => 1.Key);
			2 = ((list4.Count > 0) ? 2230.27(list4) : 0);
			3 = list4.Count - 2;
			if (array2 != null)
			{
				2226.4(text, array2);
			}
			2210.7();
			result = text;
		}
		return result;
	}

	// Token: 0x060032BB RID: 12987 RVA: 0x00134F9C File Offset: 0x0013319C
	private static string 4(string 1)
	{
		2 = (2 ?? string.Empty).Trim();
		if (2.Length == 0)
		{
			2 = "imported";
		}
		if (2.Length > 20)
		{
			2 = 2.Substring(0, 20);
		}
		List<string> list = 2210.55();
		string candidate = 2;
		int num = 2;
		Predicate<string> <>9__0;
		for (;;)
		{
			List<string> list2 = list;
			Predicate<string> match;
			if ((match = <>9__0) == null)
			{
				match = (<>9__0 = ((string 1) => string.Equals(1, candidate, StringComparison.OrdinalIgnoreCase)));
			}
			if (!list2.Exists(match))
			{
				break;
			}
			string text = " (" + num.ToString() + ")";
			candidate = ((2.Length + text.Length > 20) ? 2.Substring(0, 20 - text.Length) : 2) + text;
			num++;
		}
		return candidate;
	}

	// Token: 0x060032BC RID: 12988 RVA: 0x00135070 File Offset: 0x00133270
	private static string 5(string 1)
	{
		foreach (char oldChar in Path.GetInvalidFileNameChars())
		{
			1 = 1.Replace(oldChar, '_');
		}
		return 1;
	}

	// Token: 0x060032BD RID: 12989 RVA: 0x001350A1 File Offset: 0x001332A1
	private static void 6(BinaryWriter 1, byte[] 2)
	{
		1.Write((2 != null) ? 2.Length : -1);
		if (2 != null)
		{
			1.Write(2);
		}
	}

	// Token: 0x060032BE RID: 12990 RVA: 0x001350BC File Offset: 0x001332BC
	private static byte[] 7(BinaryReader 1)
	{
		int num = 1.ReadInt32();
		if (num < 0)
		{
			return null;
		}
		if (num > 67108864)
		{
			throw new InvalidDataException("an entry is too large");
		}
		return 1.ReadBytes(num);
	}

	// Token: 0x0400257C RID: 9596
	private const string 1 = "nekiosu-profile";

	// Token: 0x0400257D RID: 9597
	private const int 2 = 3;

	// Token: 0x0400257E RID: 9598
	private static readonly 2147[] 3 = new 2147[]
	{
		2147.Taiko,
		2147.CatchTheBeat,
		2147.OsuMania
	};

	// Token: 0x0400257F RID: 9599
	private const int 4 = 20;
}
