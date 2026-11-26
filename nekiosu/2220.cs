using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Win32;

// Token: 0x02000685 RID: 1669
[276]
internal static class 2220
{
	// Token: 0x06003267 RID: 12903 RVA: 0x00131DD0 File Offset: 0x0012FFD0
	internal static void Start()
	{
		string fileName;
		using (OpenFileDialog openFileDialog = new OpenFileDialog())
		{
			openFileDialog.Title = "Import scores from McOsu: choose McOsu's scores.db";
			openFileDialog.Filter = "McOsu scores (scores.db)|scores.db|All files|*.*";
			openFileDialog.RestoreDirectory = true;
			string text = 2220.8();
			if (text != null)
			{
				openFileDialog.InitialDirectory = text;
				openFileDialog.FileName = "scores.db";
			}
			if (1662.52(openFileDialog) != DialogResult.OK)
			{
				return;
			}
			fileName = openFileDialog.FileName;
		}
		2220.Import(fileName);
	}

	// Token: 0x06003268 RID: 12904 RVA: 0x00131E50 File Offset: 0x00130050
	private static void Import(string 1)
	{
		2220.2221 2;
		try
		{
			2 = 2220.3(4);
		}
		catch (Exception ex)
		{
			1338.4(ex, "reading McOsu's scores from " + 4, 1341.Runtime);
			1763.5("This file could not be read as McOsu's scores.db.", 198.OrangeRed, 5000, null);
			return;
		}
		foreach (KeyValuePair<2241, double> keyValuePair in 2.2)
		{
			2210.42(keyValuePair.Key, keyValuePair.Value, !2.3.Contains(keyValuePair.Key));
		}
		foreach (KeyValuePair<2241, float[]> keyValuePair2 in 2.4)
		{
			2210.48(keyValuePair2.Key, keyValuePair2.Value[0], keyValuePair2.Value[1], keyValuePair2.Value[2], keyValuePair2.Value[3]);
		}
		Dictionary<string, List<2241>> here = new Dictionary<string, List<2241>>(StringComparer.OrdinalIgnoreCase);
		foreach (KeyValuePair<string, List<2241>> keyValuePair3 in 2230.6(true))
		{
			here[keyValuePair3.Key] = keyValuePair3.Value;
		}
		List<2241> list = 2.1.FindAll(delegate(2241 1)
		{
			List<2241> list2;
			return !here.TryGetValue(1.10, out list2) || !list2.Exists((2241 1) => 2220.1(1, 1));
		});
		2210.Save();
		int num = (list.Count > 0) ? 2230.27(list) : 0;
		int num2 = 2.1.Count - num;
		HashSet<string> hashSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
		foreach (2241 3 in 2.1)
		{
			hashSet.Add(3.23 ?? string.Empty);
		}
		string item = 1304.189.GetValue() ?? string.Empty;
		hashSet.Remove(item);
		string str = "McOsu: " + num.ToString() + " score(s) imported";
		if (num2 > 0)
		{
			str = str + ", " + num2.ToString() + " were already here";
		}
		if (2.5 > 0)
		{
			str = str + ", " + 2.5.ToString() + " with mods nekiosu does not have left out";
		}
		str += ".";
		if (num > 0 && hashSet.Count > 0)
		{
			str = str + " Some are under another name (" + string.Join(", ", hashSet) + "): see Profile Manager in the top plays.";
		}
		1338.5(str + " (" + 4 + ")", 1341.Runtime, (1114)2);
		1763.5(str, (num > 0) ? 198.YellowGreen : 198.Orange, 8000, null);
		2220.2(list.FindAll((2241 1) => 1272.8(1.10) == null));
	}

	// Token: 0x06003269 RID: 12905 RVA: 0x00132198 File Offset: 0x00130398
	private static bool 1(2241 1, 2241 2)
	{
		return 1 != null && 1.9 == 2147.Osu && string.Equals(1.23 ?? string.Empty, 2.23 ?? string.Empty, StringComparison.OrdinalIgnoreCase) && 1.GetScore() == 2.GetScore() && 1.13 == 2.13 && 1.2 == 2.2 && 1.1 == 2.1 && 1.3 == 2.3 && 1.6 == 2.6 && (1.8 & ~(2023.Nightcore | 2023.Perfect)) == (2.8 & ~(2023.Nightcore | 2023.Perfect));
	}

	// Token: 0x0600326A RID: 12906 RVA: 0x00132258 File Offset: 0x00130458
	private static void 2(List<2241> 1)
	{
		2220.<>c__DisplayClass6_0 CS$<>8__locals1 = new 2220.<>c__DisplayClass6_0();
		if (3.Count == 0 || 261.FullyOffline)
		{
			return;
		}
		CS$<>8__locals1.mirror = 1632.1().FirstOrDefault((1637 1) => 1.GetBeatmapInfoByHashUrl("0") != null);
		if (CS$<>8__locals1.mirror == null)
		{
			return;
		}
		CS$<>8__locals1.byHash = new Dictionary<string, List<2241>>(StringComparer.OrdinalIgnoreCase);
		foreach (2241 2 in 3)
		{
			List<2241> list;
			if (!CS$<>8__locals1.byHash.TryGetValue(2.10, out list))
			{
				list = (CS$<>8__locals1.byHash[2.10] = new List<2241>());
			}
			list.Add(2);
		}
		CS$<>8__locals1.hashes = new Queue<string>(CS$<>8__locals1.byHash.Keys);
		CS$<>8__locals1.found = 0;
		1763.5("McOsu: looking up " + CS$<>8__locals1.hashes.Count.ToString() + " beatmap(s) that are not here...", 198.YellowGreen, 4000, null);
		CS$<>8__locals1.<LookUpMissingBeatmaps>g__Next|1();
	}

	// Token: 0x0600326B RID: 12907 RVA: 0x00132388 File Offset: 0x00130588
	private static 2220.2221 3(string 1)
	{
		2220.2221 2 = new 2220.2221();
		2220.2221 result;
		using (Stream stream = File.Open(1, FileMode.Open, FileAccess.Read, FileShare.Read | FileShare.Write | FileShare.Delete))
		{
			1647 3 = new 1647(stream);
			int num = 3.ReadInt32();
			int num2 = 3.ReadInt32();
			if (num < 20170000 || num > 20991231 || num2 < 0)
			{
				throw new InvalidDataException("not a McOsu score database (version " + num.ToString() + ")");
			}
			for (int i = 0; i < num2; i++)
			{
				string text = 3.ReadString();
				int num3 = 3.ReadInt32();
				if (text == null || text.Length > 32 || num3 < 0)
				{
					throw new InvalidDataException("damaged entry " + i.ToString());
				}
				1262 4 = (text.Length == 32) ? 1272.8(text) : null;
				for (int j = 0; j < num3; j++)
				{
					byte b = 3.ReadByte();
					int num4 = 3.ReadInt32();
					if (num == 20210103 && num4 > 20190103)
					{
						3.ReadBoolean();
					}
					else if (num > 20210103)
					{
					}
					long val = 3.ReadInt64();
					string text2 = 3.ReadString();
					short num5 = 3.ReadInt16();
					short num6 = 3.ReadInt16();
					short num7 = 3.ReadInt16();
					short num8 = 3.ReadInt16();
					short num9 = 3.ReadInt16();
					short num10 = 3.ReadInt16();
					long val2 = 3.ReadInt64();
					short num11 = 3.ReadInt16();
					2023 5 = (2023)3.ReadInt32();
					short num12 = 3.ReadInt16();
					float num13 = 3.ReadSingle();
					for (int k = 0; k < 6; k++)
					{
						3.ReadSingle();
					}
					float 6 = 3.ReadSingle();
					float num14 = 3.ReadSingle();
					float num15 = 3.ReadSingle();
					float num16 = 3.ReadSingle();
					float num17 = 3.ReadSingle();
					int num18 = -1;
					if (num4 > 20180722)
					{
						num18 = 3.ReadInt32();
						3.ReadInt32();
						3.ReadInt32();
					}
					string value = 3.ReadString();
					bool flag = b == 0 || (num > 20210103 && num4 > 20190103);
					if (text.Length == 32 && flag)
					{
						2241 7 = 2246.Create(2147.Osu, text2 ?? string.Empty, null, false);
						7.10 = text;
						7.23 = (text2 ?? string.Empty);
						7.18 = true;
						7.7 = DateTimeOffset.FromUnixTimeSeconds(Math.Max(0L, val)).UtcDateTime;
						7.2 = (ushort)num5;
						7.1 = (ushort)num6;
						7.3 = (ushort)num7;
						7.4 = (ushort)num8;
						7.5 = (ushort)num9;
						7.6 = (ushort)num10;
						7.SetRawScore((int)Math.Min(2147483647L, Math.Max(0L, val2)));
						7.13 = (int)((ushort)num11);
						7.22 = (num10 == 0 && num12 == 0 && (num18 <= 0 || (int)num11 >= num18));
						if (!string.IsNullOrWhiteSpace(value) || !2220.4(7, ref 5, 6) || !2220.6(7, 5, 4, num14, num15, num16, num17))
						{
							2.5++;
						}
						else
						{
							7.8 = 5;
							2.1.Add(7);
							if (4 == null)
							{
								2.3.Add(7);
								2.4[7] = new float[]
								{
									num14,
									num15,
									num16,
									num17
								};
							}
							if (num13 > 0f && !float.IsNaN(num13) && !float.IsInfinity(num13))
							{
								2.2.Add(new KeyValuePair<2241, double>(7, (double)num13));
							}
						}
					}
				}
			}
			result = 2;
		}
		return result;
	}

	// Token: 0x0600326C RID: 12908 RVA: 0x00132774 File Offset: 0x00130974
	private static bool 4(2241 1, ref 2023 2, float 3)
	{
		bool flag = (2 & (2023.DoubleTime | 2023.Nightcore)) > 2023.None;
		bool flag2 = (2 & 2023.HalfTime) > 2023.None;
		double num = flag ? 1.5 : (flag2 ? 0.75 : 1.0);
		if (3 <= 0f || Math.Abs((double)3 - num) <= 0.005)
		{
			return true;
		}
		if ((3 > 1f && flag2) || (3 < 1f && flag))
		{
			return false;
		}
		if (3 > 1f && !flag)
		{
			2 |= 2023.DoubleTime;
		}
		else if (3 < 1f && !flag2)
		{
			2 |= 2023.HalfTime;
		}
		double num2 = Math.Round((double)3, 2);
		if (num2 < 1939.5(2, true) || num2 > 1939.6(2, true))
		{
			return false;
		}
		1.44 = new 1940(num2, (2 & 2023.Nightcore) > 2023.None);
		return true;
	}

	// Token: 0x0600326D RID: 12909 RVA: 0x00132859 File Offset: 0x00130A59
	internal static bool 5(2241 1, 1262 2, float 3, float 4, float 5, float 6)
	{
		return 2220.6(1, 1.8, 2, 3, 4, 5, 6);
	}

	// Token: 0x0600326E RID: 12910 RVA: 0x00132874 File Offset: 0x00130A74
	private static bool 6(2241 1, 2023 2, 1262 3, float 4, float 5, float 6, float 7)
	{
		if (3 == null)
		{
			return true;
		}
		bool flag = (2 & 2023.HardRock) > 2023.None;
		bool flag2 = (2 & 2023.Easy) > 2023.None;
		float num = flag ? 1.4f : (flag2 ? 0.5f : 1f);
		float num2 = flag ? 1.3f : (flag2 ? 0.5f : 1f);
		Dictionary<1928, float> dictionary = new Dictionary<1928, float>();
		2220.7(dictionary, 1928.CircleSize, 4, 3.2 * num2);
		2220.7(dictionary, 1928.ApproachRate, 5, 3.1 * num);
		2220.7(dictionary, 1928.OverallDifficulty, 6, 3.4 * num);
		2220.7(dictionary, 1928.DrainRate, 7, 3.3 * num);
		if (dictionary.Count == 0)
		{
			return true;
		}
		if (flag || flag2)
		{
			return false;
		}
		bool flag3 = false;
		foreach (float num3 in dictionary.Values)
		{
			flag3 |= (num3 < 0f || num3 > 10f);
		}
		1.43 = new 1927(dictionary, flag3);
		return true;
	}

	// Token: 0x0600326F RID: 12911 RVA: 0x0013299C File Offset: 0x00130B9C
	private static void 7(Dictionary<1928, float> 1, 1928 2, float 3, float 4)
	{
		4 = Math.Min(10f, Math.Max(0f, 4));
		if (!float.IsNaN(3) && Math.Abs(3 - 4) > 0.05f)
		{
			1[2] = (float)Math.Round((double)3, 1);
		}
	}

	// Token: 0x06003270 RID: 12912 RVA: 0x001329DC File Offset: 0x00130BDC
	private static string 8()
	{
		try
		{
			string text = Registry.GetValue("HKEY_CURRENT_USER\\Software\\Valve\\Steam", "SteamPath", null) as string;
			if (string.IsNullOrEmpty(text))
			{
				return null;
			}
			List<string> list = new List<string>
			{
				text.Replace('/', '\\')
			};
			string path = Path.Combine(list[0], "steamapps", "libraryfolders.vdf");
			if (File.Exists(path))
			{
				foreach (object obj in Regex.Matches(File.ReadAllText(path), "\"path\"\\s+\"([^\"]+)\""))
				{
					Match match = (Match)obj;
					list.Add(match.Groups[1].Value.Replace("\\\\", "\\"));
				}
			}
			foreach (string path2 in list)
			{
				string text2 = Path.Combine(path2, "steamapps", "common", "McOsu");
				if (File.Exists(Path.Combine(text2, "scores.db")))
				{
					return text2;
				}
			}
		}
		catch (Exception)
		{
		}
		return null;
	}

	// Token: 0x04002547 RID: 9543
	private const byte 1 = 169;

	// Token: 0x04002548 RID: 9544
	private const float 2 = 0.05f;

	// Token: 0x02000686 RID: 1670
	[276]
	private sealed class 2221
	{
		// Token: 0x04002549 RID: 9545
		public readonly List<2241> 1 = new List<2241>();

		// Token: 0x0400254A RID: 9546
		public readonly List<KeyValuePair<2241, double>> 2 = new List<KeyValuePair<2241, double>>();

		// Token: 0x0400254B RID: 9547
		public readonly HashSet<2241> 3 = new HashSet<2241>();

		// Token: 0x0400254C RID: 9548
		public readonly Dictionary<2241, float[]> 4 = new Dictionary<2241, float[]>();

		// Token: 0x0400254D RID: 9549
		public int 5;
	}
}
