using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x02000833 RID: 2099
public static class 1926
{
	// Token: 0x06003CEA RID: 15594 RVA: 0x00181303 File Offset: 0x0017F503
	public static bool 1(float 1)
	{
		return 1 < -100.05f;
	}

	// Token: 0x06003CEB RID: 15595 RVA: 0x0018130D File Offset: 0x0017F50D
	public static string 2(1928 1, float 2)
	{
		if (1 != 1928.ApproachRate || !1926.1(2))
		{
			return 2.ToString("0.0", CultureInfo.InvariantCulture);
		}
		return "-inf";
	}

	// Token: 0x14000007 RID: 7
	// (add) Token: 0x06003CEC RID: 15596 RVA: 0x00181334 File Offset: 0x0017F534
	// (remove) Token: 0x06003CED RID: 15597 RVA: 0x00181368 File Offset: 0x0017F568
	public static event Action Changed
	{
		[CompilerGenerated]
		add
		{
			Action action = 1926.7;
			Action action2;
			do
			{
				action2 = action;
				Action value2 = (Action)Delegate.Combine(action2, value);
				action = Interlocked.CompareExchange<Action>(ref 1926.7, value2, action2);
			}
			while (action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action action = 1926.7;
			Action action2;
			do
			{
				action2 = action;
				Action value2 = (Action)Delegate.Remove(action2, value);
				action = Interlocked.CompareExchange<Action>(ref 1926.7, value2, action2);
			}
			while (action != action2);
		}
	}

	// Token: 0x06003CEE RID: 15598 RVA: 0x0018139B File Offset: 0x0017F59B
	static 1926()
	{
		1320<string> <<EMPTY_NAME>> = 1304.61;
		1926.25((<<EMPTY_NAME>> != null) ? <<EMPTY_NAME>>.GetValue() : null);
	}

	// Token: 0x170002C3 RID: 707
	// (get) Token: 0x06003CEF RID: 15599 RVA: 0x001813BD File Offset: 0x0017F5BD
	public static bool Enabled
	{
		get
		{
			return 1926.4;
		}
	}

	// Token: 0x170002C4 RID: 708
	// (get) Token: 0x06003CF0 RID: 15600 RVA: 0x001813C4 File Offset: 0x0017F5C4
	public static bool ExtendedLimits
	{
		get
		{
			return 1926.5;
		}
	}

	// Token: 0x170002C5 RID: 709
	// (get) Token: 0x06003CF1 RID: 15601 RVA: 0x001813CB File Offset: 0x0017F5CB
	public static bool NoLimits
	{
		get
		{
			return 1926.6;
		}
	}

	// Token: 0x06003CF2 RID: 15602 RVA: 0x001813D4 File Offset: 0x0017F5D4
	public static 1927 3(2147 1)
	{
		if (!1926.4)
		{
			return null;
		}
		Dictionary<1928, float> dictionary = new Dictionary<1928, float>();
		foreach (1928 key in 1926.14(1))
		{
			float? num = 1926.11(key);
			if (num != null)
			{
				dictionary[key] = 1926.22(key, num.Value, 1);
			}
		}
		return new 1927(dictionary, 1926.5 || 1926.6);
	}

	// Token: 0x06003CF3 RID: 15603 RVA: 0x00181444 File Offset: 0x0017F644
	public static float 4(1928 1, float 2)
	{
		float? num = (1926.4 && Array.IndexOf<1928>(1926.14(1925.SelectedPlayMode), 1) >= 0) ? 1926.11(1) : null;
		if (num == null)
		{
			return 2;
		}
		return 1926.22(1, num.Value, 1925.SelectedPlayMode);
	}

	// Token: 0x06003CF4 RID: 15604 RVA: 0x0018149C File Offset: 0x0017F69C
	public static float 5(1928 1, float 2)
	{
		2241 3 = 2486.88;
		if (3 == null)
		{
			return 1926.4(1, 2);
		}
		1927 4 = 3.43;
		if (4 == null)
		{
			return 2;
		}
		return 4.Apply(1, 2);
	}

	// Token: 0x06003CF5 RID: 15605 RVA: 0x001814CD File Offset: 0x0017F6CD
	public static void 6(bool 1)
	{
		if (1926.4 == 1)
		{
			return;
		}
		1926.4 = 1;
		if (1926.4)
		{
			2019.1 &= ~(2023.Easy | 2023.HardRock);
		}
		else
		{
			1926.3.Clear();
		}
		1926.24();
	}

	// Token: 0x06003CF6 RID: 15606 RVA: 0x00181504 File Offset: 0x0017F704
	public static void 7(bool 1)
	{
		if (1926.5 == 1)
		{
			return;
		}
		1926.5 = 1;
		if (!1)
		{
			foreach (1928 key in 1926.3.Keys.ToList<1928>())
			{
				if (1926.3[key] != null)
				{
					1926.3[key] = new float?(1926.21(key, 1926.3[key].Value));
				}
			}
		}
		1926.24();
	}

	// Token: 0x06003CF7 RID: 15607 RVA: 0x001815B0 File Offset: 0x0017F7B0
	public static void 8(bool 1)
	{
		if (1926.6 == 1)
		{
			return;
		}
		1926.6 = 1;
		if (!1)
		{
			foreach (1928 key in 1926.3.Keys.ToList<1928>())
			{
				if (1926.3[key] != null)
				{
					1926.3[key] = new float?(1926.21(key, 1926.3[key].Value));
				}
			}
		}
		1926.24();
	}

	// Token: 0x06003CF8 RID: 15608 RVA: 0x0018165C File Offset: 0x0017F85C
	public static bool 9(1928 1, float 2)
	{
		return 2 < 1926.19(1, true, false, null) - 0.05f || 2 > 1926.20(1, true, false, null) + 0.05f;
	}

	// Token: 0x06003CF9 RID: 15609 RVA: 0x0018169F File Offset: 0x0017F89F
	public static bool 10(2147 1)
	{
		if (1926.4)
		{
			return 1926.14(2).Any((1928 1) => 1926.11(1) != null && 1926.9(1, 1926.11(1).Value));
		}
		return false;
	}

	// Token: 0x06003CFA RID: 15610 RVA: 0x001816D4 File Offset: 0x0017F8D4
	public static float? 11(1928 1)
	{
		float? result;
		if (!1926.3.TryGetValue(1, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x06003CFB RID: 15611 RVA: 0x001816FC File Offset: 0x0017F8FC
	public static void 12(1928 1, float? 2)
	{
		if (2 != null && (float.IsNaN(2.Value) || float.IsInfinity(2.Value)))
		{
			return;
		}
		if (2 != null)
		{
			float num = (1 == 1928.ApproachRate && 1926.1(2.Value)) ? -101f : ((float)Math.Round((double)(2.Value / 0.1f)) * 0.1f);
			2 = new float?(1926.21(1, num));
		}
		float? num2 = 1926.11(1);
		float? num3 = 2;
		if (num2.GetValueOrDefault() == num3.GetValueOrDefault() & num2 != null == (num3 != null))
		{
			return;
		}
		1926.3[1] = 2;
		1926.24();
	}

	// Token: 0x06003CFC RID: 15612 RVA: 0x001817B8 File Offset: 0x0017F9B8
	public static void 13()
	{
		1926.3.Clear();
		1926.24();
	}

	// Token: 0x06003CFD RID: 15613 RVA: 0x001817C9 File Offset: 0x0017F9C9
	public static 1928[] 14(2147 1)
	{
		if (1 == 2147.Taiko || 1 == 2147.OsuMania)
		{
			return new 1928[]
			{
				1928.DrainRate,
				1928.OverallDifficulty
			};
		}
		return new 1928[]
		{
			1928.CircleSize,
			1928.DrainRate,
			1928.OverallDifficulty,
			1928.ApproachRate
		};
	}

	// Token: 0x06003CFE RID: 15614 RVA: 0x001817F3 File Offset: 0x0017F9F3
	public static string 15(1928 1)
	{
		switch (1)
		{
		case 1928.CircleSize:
			return "Circle Size";
		case 1928.DrainRate:
			return "HP Drain";
		case 1928.OverallDifficulty:
			return "Accuracy";
		default:
			return "Approach Rate";
		}
	}

	// Token: 0x06003CFF RID: 15615 RVA: 0x00181820 File Offset: 0x0017FA20
	public static string 16(1928 1)
	{
		switch (1)
		{
		case 1928.CircleSize:
			return "CS";
		case 1928.DrainRate:
			return "HP";
		case 1928.OverallDifficulty:
			return "OD";
		default:
			return "AR";
		}
	}

	// Token: 0x06003D00 RID: 15616 RVA: 0x00181850 File Offset: 0x0017FA50
	public static float 17(1928 1)
	{
		return 1926.19(1, 1926.5, 1926.6, null);
	}

	// Token: 0x06003D01 RID: 15617 RVA: 0x00181878 File Offset: 0x0017FA78
	public static float 18(1928 1)
	{
		return 1926.20(1, 1926.5, 1926.6, null);
	}

	// Token: 0x06003D02 RID: 15618 RVA: 0x001818A0 File Offset: 0x0017FAA0
	private static float 19(1928 1, bool 2, bool 3, 2147? 4 = null)
	{
		2147 5 = 4 ?? 1925.SelectedPlayMode;
		if (3)
		{
			switch (1)
			{
			case 1928.CircleSize:
				return -30f;
			case 1928.DrainRate:
				return 0f;
			case 1928.ApproachRate:
				if (5 != 2147.Osu)
				{
					return -100f;
				}
				return -101f;
			}
			return -100f;
		}
		if (!2 && !3)
		{
			return 0f;
		}
		if (1 == 1928.ApproachRate && 5 == 2147.Osu)
		{
			return -10f;
		}
		if (1 == 1928.OverallDifficulty && 5 == 2147.OsuMania)
		{
			return -15f;
		}
		return 0f;
	}

	// Token: 0x06003D03 RID: 15619 RVA: 0x00181930 File Offset: 0x0017FB30
	private static float 20(1928 1, bool 2, bool 3, 2147? 4 = null)
	{
		2147 5 = 4 ?? 1925.SelectedPlayMode;
		if (1 == 1928.OverallDifficulty && 5 == 2147.OsuMania && (2 || 3))
		{
			return 15f;
		}
		if (3)
		{
			switch (1)
			{
			case 1928.CircleSize:
			case 1928.ApproachRate:
				return 12f;
			case 1928.OverallDifficulty:
				if (5 != 2147.Taiko)
				{
					return 13f;
				}
				return 15f;
			}
			return 15f;
		}
		if (!2)
		{
			return 10f;
		}
		return 11f;
	}

	// Token: 0x06003D04 RID: 15620 RVA: 0x001819AF File Offset: 0x0017FBAF
	private static float 21(1928 1, float 2)
	{
		return Math.Max(1926.17(1), Math.Min(1926.18(1), 2));
	}

	// Token: 0x06003D05 RID: 15621 RVA: 0x001819C8 File Offset: 0x0017FBC8
	private static float 22(1928 1, float 2, 2147 3)
	{
		return Math.Max(1926.19(1, 1926.5, 1926.6, new 2147?(3)), Math.Min(1926.20(1, 1926.5, 1926.6, new 2147?(3)), 2));
	}

	// Token: 0x06003D06 RID: 15622 RVA: 0x00181A04 File Offset: 0x0017FC04
	public static string 23(2147 1)
	{
		return string.Join(", ", from 1 in 1926.14(2)
		where 1926.11(1) != null
		select 1926.16(1) + " " + 1926.2(1, 1926.11(1).Value));
	}

	// Token: 0x06003D07 RID: 15623 RVA: 0x00181A69 File Offset: 0x0017FC69
	private static void 24()
	{
		1320<string> <<EMPTY_NAME>> = 1304.61;
		if (<<EMPTY_NAME>> != null)
		{
			<<EMPTY_NAME>>.SetValue(1926.Save());
		}
		Action action = 1926.7;
		if (action != null)
		{
			action();
		}
		2019.3();
	}

	// Token: 0x06003D08 RID: 15624 RVA: 0x00181A98 File Offset: 0x0017FC98
	private static string Save()
	{
		IEnumerable<string> first = Enum.GetValues(typeof(1928)).Cast<1928>().Select(delegate(1928 1)
		{
			float? num;
			return 1926.16(1).ToLowerInvariant() + "=" + (((1926.11(1) != null) ? num.GetValueOrDefault().ToString("0.0", CultureInfo.InvariantCulture) : null) ?? string.Empty);
		});
		return string.Join(";", first.Concat(new string[]
		{
			"ext=" + (1926.5 ? "1" : "0"),
			"nl=" + (1926.6 ? "1" : "0")
		}));
	}

	// Token: 0x06003D09 RID: 15625 RVA: 0x00181B34 File Offset: 0x0017FD34
	private static void 25(string 1)
	{
		if (string.IsNullOrEmpty(1))
		{
			return;
		}
		string[] array = 1.Split(new char[]
		{
			';'
		});
		for (int i = 0; i < array.Length; i++)
		{
			string[] array2 = array[i].Split(new char[]
			{
				'='
			});
			if (array2.Length == 2)
			{
				if (array2[0] == "ext")
				{
					1926.5 = (array2[1] == "1");
				}
				else if (array2[0] == "nl")
				{
					1926.6 = (array2[1] == "1");
				}
			}
		}
	}

	// Token: 0x04002CFA RID: 11514
	public const float 1 = 0.1f;

	// Token: 0x04002CFB RID: 11515
	public const float 2 = -101f;

	// Token: 0x04002CFC RID: 11516
	private static readonly Dictionary<1928, float?> 3 = new Dictionary<1928, float?>();

	// Token: 0x04002CFD RID: 11517
	private static bool 4;

	// Token: 0x04002CFE RID: 11518
	private static bool 5;

	// Token: 0x04002CFF RID: 11519
	private static bool 6;

	// Token: 0x04002D00 RID: 11520
	[CompilerGenerated]
	private static Action 7;
}
