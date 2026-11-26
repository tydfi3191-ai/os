using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Threading;

// Token: 0x0200046F RID: 1135
public static class 2630
{
	// Token: 0x060022A4 RID: 8868 RVA: 0x0009618B File Offset: 0x0009438B
	internal static string 1()
	{
		return Path.Combine(1345.4(), "Skins");
	}

	// Token: 0x060022A5 RID: 8869 RVA: 0x0009619C File Offset: 0x0009439C
	internal static void 2(1189 1)
	{
		1189 2 = 2630.1;
		1189 3;
		do
		{
			3 = 2;
			1189 value = (1189)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1189>(ref 2630.1, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x060022A6 RID: 8870 RVA: 0x000961D0 File Offset: 0x000943D0
	internal static void 3(1189 1)
	{
		1189 2 = 2630.1;
		1189 3;
		do
		{
			3 = 2;
			1189 value = (1189)Delegate.Remove(3, 1);
			2 = Interlocked.CompareExchange<1189>(ref 2630.1, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x060022A7 RID: 8871 RVA: 0x00096204 File Offset: 0x00094404
	internal static void 4(1189 1)
	{
		1189 2 = 2630.2;
		1189 3;
		do
		{
			3 = 2;
			1189 value = (1189)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1189>(ref 2630.2, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x060022A8 RID: 8872 RVA: 0x00096237 File Offset: 0x00094437
	internal static 2137 5()
	{
		if (!1304.128)
		{
			return 2630.5;
		}
		return 2630.6;
	}

	// Token: 0x060022A9 RID: 8873 RVA: 0x00096250 File Offset: 0x00094450
	internal static 1881 6()
	{
		return 2630.5.1();
	}

	// Token: 0x060022AA RID: 8874 RVA: 0x0009625C File Offset: 0x0009445C
	internal static void 7()
	{
		1804.1();
		2630.8 = new List<string>();
		foreach (string text in Directory.GetDirectories(2630.1()))
		{
			2630.8.Add(text.Replace(2630.1() + Path.DirectorySeparatorChar.ToString(), string.Empty));
		}
		2630.8.Sort();
		2630.8.Insert(0, "Default");
		1189 <<EMPTY_NAME>> = 2630.2;
		if (<<EMPTY_NAME>> == null)
		{
			return;
		}
		<<EMPTY_NAME>>();
	}

	// Token: 0x060022AB RID: 8875 RVA: 0x000962EB File Offset: 0x000944EB
	internal static void 8()
	{
		if (!Directory.Exists(2630.1()))
		{
			Directory.CreateDirectory(2630.1());
		}
		2630.10(null, false);
	}

	// Token: 0x17000239 RID: 569
	// (get) Token: 0x060022AC RID: 8876 RVA: 0x0009630C File Offset: 0x0009450C
	internal static 2137 HudSkin
	{
		get
		{
			if (!2630.17)
			{
				return 2630.5;
			}
			2137 result;
			if ((result = 2630.18) == null)
			{
				2137 <<EMPTY_NAME>> = new 2137();
				<<EMPTY_NAME>>.RawName = "Default";
				result = <<EMPTY_NAME>>;
				2630.18 = <<EMPTY_NAME>>;
			}
			return result;
		}
	}

	// Token: 0x060022AD RID: 8877 RVA: 0x0009633C File Offset: 0x0009453C
	internal static bool 9(string 1)
	{
		return 1.StartsWith("score-", StringComparison.OrdinalIgnoreCase) || 1.StartsWith("scorebar-", StringComparison.OrdinalIgnoreCase) || 1.StartsWith("scoreentry-", StringComparison.OrdinalIgnoreCase) || 1.StartsWith("inputoverlay-", StringComparison.OrdinalIgnoreCase) || 1.StartsWith("selection-mod-", StringComparison.OrdinalIgnoreCase) || 1.StartsWith("ranking-", StringComparison.OrdinalIgnoreCase);
	}

	// Token: 0x060022AE RID: 8878 RVA: 0x000963A0 File Offset: 0x000945A0
	internal static bool 10(string 1, bool 2)
	{
		2630.2632 3 = new 2630.2632();
		3.1 = 1;
		2630.22();
		bool result = true;
		if (3.1 == null || 2630.8.Find(new Predicate<string>(3.1)) == null)
		{
			result = (3.1 == null);
			3.1 = 1304.187;
		}
		bool flag = false;
		if ((1662.78 == 1677.Edit || 1662.84) && 1304.81)
		{
			3.1 = "Default";
			flag = true;
		}
		if (!Directory.Exists(Path.Combine(2630.1(), 3.1)))
		{
			flag = (3.1 == 1304.187);
			3.1 = "Default";
		}
		bool flag2 = false;
		if (2 || 2630.5 == null || !3.1.Equals(2630.5.RawName, StringComparison.CurrentCultureIgnoreCase))
		{
			1455.12(true);
			2137 4 = 2630.15(3.1);
			if (4 != null)
			{
				flag2 = true;
				2630.5 = 4;
				if (3.1 == 1304.187)
				{
					2630.6 = 2630.5;
				}
				1226.58();
				if (1662.78 == 1677.Play)
				{
					1226.53();
				}
				else
				{
					1226.54();
				}
			}
		}
		2630.3.Clear();
		2630.18();
		if (1304.128 && 2630.5 != 2630.6 && !flag)
		{
			2137 5 = 2630.5;
			2630.5 = 2630.6;
			2630.13(true);
			2630.5 = 5;
		}
		else
		{
			2630.13(true);
		}
		if (flag2)
		{
			1189 6 = 2630.1;
			if (6 != null)
			{
				6();
			}
		}
		return result;
	}

	// Token: 0x060022AF RID: 8879 RVA: 0x0009653B File Offset: 0x0009473B
	internal static void 11()
	{
		if (2630.5 != null)
		{
			if (2630.20())
			{
				1763.4(1568.1(2679.OptionsSkin_CannotExportDefault));
				return;
			}
			1662.66(2630.5.15(), 2630.5.14());
		}
	}

	// Token: 0x060022B0 RID: 8880 RVA: 0x00096574 File Offset: 0x00094774
	internal static void 12(2039 1)
	{
		2630.2633 2 = new 2630.2633();
		if (1 != null)
		{
			2630.11 = 1;
		}
		if (2630.5 != null && 2630.11 != null)
		{
			2.1 = new List<198>();
			if ((float)2630.19("SliderTrackOverride", true).A > 0f)
			{
				2.1.Add(2630.19("SliderTrackOverride", true));
			}
			else if (1272.5() != null && 1272.5().3() != 2147.Taiko)
			{
				2.1.AddRange(2630.11.27);
			}
			else
			{
				2.1.Add(new 198(252, 184, 6));
			}
			1662.89.Schedule(new 1189(2.Apply), false);
		}
	}

	// Token: 0x060022B1 RID: 8881 RVA: 0x00096640 File Offset: 0x00094840
	internal static void 13(bool 1)
	{
		if ((!1 && 1535.51 != null && 1535.51.GetTexture() != null && !1535.51.GetTexture().5()) || 2630.5 == null)
		{
			return;
		}
		1381 2 = 1455.2("cursor", 1304.128 ? ((1416)3) : ((1416)7), null);
		2630.12 = 1455.2("cursortrail", 1304.128 ? ((1416)3) : ((1416)7), null);
		if (2 == null || 2630.12 == null)
		{
			return;
		}
		1535.67 = 2630.5.CursorExpand;
		1433 3 = 1535.51;
		1433 4 = 1535.64;
		if (3 == null)
		{
			1433 5 = new 1433(null, (1376)16, 1065.TopLeft, (1044)0, 208.Zero, 0.999f, true, 198.White, null);
			5.16 = 0f;
			1535.51 = 5;
			3 = 5;
			1662.26.12(3);
			1433 6 = new 1433(null, (1376)16, 1065.TopLeft, (1044)0, 208.Zero, 1f, true, 198.White, null);
			6.16 = 0f;
			1535.64 = 6;
			4 = 6;
			1662.26.12(4);
		}
		bool flag = false;
		for (int i = 0; i < 3.3.Count; i++)
		{
			if (3.3[i].14 == 1456.Rotation)
			{
				flag = true;
				break;
			}
		}
		if (!2630.5.CursorRotate)
		{
			3.3.Clear();
			3.14 = 0f;
			3.6 = 198.White;
		}
		else if (!flag)
		{
			3.3.Add(new 1445(1456.Rotation, 0f, 6.2831855f, 0, 10000, (1046)0)
			{
				17 = true
			});
		}
		3.49 = (4.49 = (2630.5.CursorCentre ? 1065.Centre : 1065.TopLeft));
		3.15 = 1f;
		3.SetTexture(2);
		4.SetTexture(1455.2("cursormiddle", 2.6, null));
		1535.29();
	}

	// Token: 0x060022B2 RID: 8882 RVA: 0x00096830 File Offset: 0x00094A30
	internal static Font 14(float 1, FontStyle 2)
	{
		string text = Path.Combine(2630.5.14(), "taiko.ttf");
		if (2630.20() || !File.Exists(text))
		{
			return null;
		}
		Font result;
		using (PrivateFontCollection privateFontCollection = new PrivateFontCollection())
		{
			privateFontCollection.AddFontFile(text);
			result = new Font(privateFontCollection.Families[0], 19f, 2);
		}
		return result;
	}

	// Token: 0x060022B3 RID: 8883 RVA: 0x000968A4 File Offset: 0x00094AA4
	internal static 2137 15(string 1)
	{
		2137 2 = new 2137();
		2.RawName = 1;
		string path = Path.Combine(2.14(), "skin.ini");
		bool flag = File.Exists(path);
		bool flag2 = 1 == "Default";
		if (flag2 || 1 == "User" || !flag)
		{
			2.Version = 2.7;
		}
		try
		{
			if (flag2)
			{
				2.SkinName = " osu!";
				2.SkinAuthor = "peppy";
			}
			else if (flag)
			{
				2.3(path);
			}
		}
		catch (Exception ex)
		{
			1763.2(1568.1(2679.SkinManager_ErrorLoadingConfig), 5000, (1389)0);
			if (!flag2)
			{
				try
				{
					File.WriteAllText(Path.Combine(2630.1(), 1, "error.txt"), ex.ToString());
				}
				catch
				{
				}
				return 2630.15("Default");
			}
		}
		return 2;
	}

	// Token: 0x060022B4 RID: 8884 RVA: 0x00096998 File Offset: 0x00094B98
	internal static void 16()
	{
		if (2630.20())
		{
			2630.25();
		}
		FileStream fileStream = new FileStream(Path.Combine(2630.5.14(), "skin.ini"), FileMode.Create);
		try
		{
			StreamWriter streamWriter = new StreamWriter(fileStream);
			try
			{
				2630.5.4(streamWriter);
			}
			finally
			{
				((IDisposable)streamWriter).Dispose();
			}
		}
		finally
		{
			((IDisposable)fileStream).Dispose();
		}
	}

	// Token: 0x060022B5 RID: 8885 RVA: 0x00096A0C File Offset: 0x00094C0C
	internal static 1992 17(int 1, 2023 2)
	{
		2630.2631 3 = new 2630.2631();
		3.1 = 1;
		1992 4 = 2630.5.ManiaSkins.Find(new Predicate<1992>(3.1));
		if (4 == null)
		{
			4 = new 1992(3.1);
			2630.5.ManiaSkins.Add(4);
		}
		if (3.1 <= 1)
		{
			4.15(false);
			4.SplitStagesFromSkin = null;
		}
		else
		{
			4.15(3.1 >= 10 || (2 & 2023.KeyCoop) > 2023.None);
		}
		return 4;
	}

	// Token: 0x060022B6 RID: 8886 RVA: 0x00096AA0 File Offset: 0x00094CA0
	internal static void 18()
	{
		2630.4.Clear();
		foreach (KeyValuePair<string, 198> keyValuePair in 2630.5.Colours)
		{
			2630.4[keyValuePair.Key] = keyValuePair.Value;
		}
	}

	// Token: 0x060022B7 RID: 8887 RVA: 0x00096B14 File Offset: 0x00094D14
	internal static 198 19(string 1, bool 2)
	{
		198 3;
		if (2 && 2630.3.TryGetValue(1, out 3))
		{
			if (3.A > 0)
			{
				return 3;
			}
			return 198.TransparentWhite;
		}
		else
		{
			if (2630.4.TryGetValue(1, out 3) && 3.A > 0)
			{
				return 3;
			}
			return 198.TransparentWhite;
		}
	}

	// Token: 0x060022B8 RID: 8888 RVA: 0x00096B63 File Offset: 0x00094D63
	internal static bool 20()
	{
		return 2630.5 != null && 2630.5.RawName == "Default";
	}

	// Token: 0x060022B9 RID: 8889 RVA: 0x00096B84 File Offset: 0x00094D84
	internal static bool 21()
	{
		return 1662.112 && (2630.17 || 2630.20() || 2630.5 == null || 2630.5.RawName == "User" || 2630.5.Version > 1.0);
	}

	// Token: 0x060022BA RID: 8890 RVA: 0x00096BDC File Offset: 0x00094DDC
	internal static void 22()
	{
		if (2630.8 == null)
		{
			2630.7();
		}
	}

	// Token: 0x060022BB RID: 8891 RVA: 0x00096BEA File Offset: 0x00094DEA
	internal static void 23()
	{
		1414.3();
	}

	// Token: 0x060022BC RID: 8892 RVA: 0x00096BF1 File Offset: 0x00094DF1
	public static void 24(1381 1)
	{
		2630.9.Add(1);
	}

	// Token: 0x060022BD RID: 8893 RVA: 0x00096C00 File Offset: 0x00094E00
	internal static void 25()
	{
		if (!2630.20())
		{
			return;
		}
		string path = Path.Combine(2630.1(), "User");
		if (!Directory.Exists(path))
		{
			Directory.CreateDirectory(path);
		}
		1304.187.SetValue("User");
		if (2630.5.RawName != "User")
		{
			2630.10(1304.187, true);
			if (1662.93())
			{
				1662.SetMode(1662.78, true);
			}
		}
	}

	// Token: 0x060022BE RID: 8894 RVA: 0x00096C7C File Offset: 0x00094E7C
	internal static 198 26()
	{
		return 2630.7[1196.2(0, 4)];
	}

	// Token: 0x04001804 RID: 6148
	private static 1189 1;

	// Token: 0x04001805 RID: 6149
	private static 1189 2;

	// Token: 0x04001806 RID: 6150
	internal static Dictionary<string, 198> 3 = new Dictionary<string, 198>();

	// Token: 0x04001807 RID: 6151
	internal static Dictionary<string, 198> 4 = new Dictionary<string, 198>();

	// Token: 0x04001808 RID: 6152
	internal static 2137 5;

	// Token: 0x04001809 RID: 6153
	internal static 2137 6;

	// Token: 0x0400180A RID: 6154
	internal static 198[] 7 = new 198[]
	{
		new 198(byte.MaxValue, 192, 0),
		new 198(0, 202, 0),
		new 198(18, 124, byte.MaxValue),
		new 198(242, 24, 57),
		new 198(0, 0, 0, 0),
		new 198(0, 0, 0, 0),
		new 198(0, 0, 0, 0),
		new 198(0, 0, 0, 0)
	};

	// Token: 0x0400180B RID: 6155
	internal static List<string> 8;

	// Token: 0x0400180C RID: 6156
	private static List<1381> 9 = new List<1381>();

	// Token: 0x0400180D RID: 6157
	internal static 2049 10;

	// Token: 0x0400180E RID: 6158
	private static 2039 11;

	// Token: 0x0400180F RID: 6159
	internal static 1381 12;

	// Token: 0x04001810 RID: 6160
	public static bool 13;

	// Token: 0x04001811 RID: 6161
	public static 198 14 = new 198(236, 117, 140);

	// Token: 0x04001812 RID: 6162
	public static 198 15 = new 198(187, 17, 119);

	// Token: 0x04001813 RID: 6163
	public static 198 16 = new 198(34, 153, 187);

	// Token: 0x04001814 RID: 6164
	internal static bool 17;

	// Token: 0x04001815 RID: 6165
	private static 2137 18;

	// Token: 0x02000470 RID: 1136
	public sealed class 2631
	{
		// Token: 0x060022C0 RID: 8896 RVA: 0x00096D99 File Offset: 0x00094F99
		internal bool 1(1992 1)
		{
			return 1.Columns == this.1;
		}

		// Token: 0x04001816 RID: 6166
		public int 1;
	}

	// Token: 0x02000471 RID: 1137
	public sealed class 2633
	{
		// Token: 0x060022C2 RID: 8898 RVA: 0x00096DAC File Offset: 0x00094FAC
		internal void Apply()
		{
			if (2630.10 == null)
			{
				2630.10 = new 2031();
			}
			2630.10.SetColours(this.1, 2630.10.GetFallbackColour(), 2630.10.GetDefaultColour(), 2630.19("SliderBorder", true), 2630.11.1 * 1662.69.9());
		}

		// Token: 0x04001817 RID: 6167
		public List<198> 1;
	}

	// Token: 0x02000472 RID: 1138
	public sealed class 2632
	{
		// Token: 0x060022C4 RID: 8900 RVA: 0x00096E0E File Offset: 0x0009500E
		internal bool 1(string 1)
		{
			return 1.Equals(this.1, StringComparison.CurrentCultureIgnoreCase);
		}

		// Token: 0x04001818 RID: 6168
		public string 1;
	}
}
