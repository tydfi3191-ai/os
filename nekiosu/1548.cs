using System;
using System.Collections.Generic;

// Token: 0x02000A5A RID: 2650
public static class 1548
{
	// Token: 0x0600492E RID: 18734 RVA: 0x001D1527 File Offset: 0x001CF727
	public static void 1(1532 1, 200 2)
	{
		1548.4(1, 2);
		1548.12();
	}

	// Token: 0x0600492F RID: 18735 RVA: 0x001D1538 File Offset: 0x001CF738
	private static 1531 2(1532 1)
	{
		int num = (int)1;
		while (num-- > 1)
		{
			1532 2 = (1532)num;
			string text = 2.ToString();
			if (text[0] == '_')
			{
				if (2 == 1532._ExtraModsSettings)
				{
					return 1531.Universal;
				}
				for (int i = 4; i > 0; i--)
				{
					string a = text.Substring(1);
					1531 3 = (1531)i;
					if (a == 3.ToString())
					{
						return (1531)i;
					}
				}
			}
		}
		return 1531.Universal;
	}

	// Token: 0x06004930 RID: 18736 RVA: 0x001D15A0 File Offset: 0x001CF7A0
	private static Dictionary<200, 1532> 3(1531 1)
	{
		return 1548.2[1];
	}

	// Token: 0x06004931 RID: 18737 RVA: 0x001D15B0 File Offset: 0x001CF7B0
	private static void 4(1532 1, 200 2)
	{
		Dictionary<200, 1532> dictionary = 1548.3(1548.2(1));
		200 3;
		if (1548.1.TryGetValue(1, out 3) && 2 == 3)
		{
			return;
		}
		if (1548.1.TryGetValue(1, out 3) && 3 != 200.None)
		{
			bool flag = false;
			foreach (KeyValuePair<1532, 200> keyValuePair in 1548.1)
			{
				if (keyValuePair.Key != 1 && keyValuePair.Value == 3)
				{
					dictionary[3] = keyValuePair.Key;
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				dictionary.Remove(3);
			}
		}
		1548.1[1] = 2;
		dictionary[2] = 1;
	}

	// Token: 0x06004932 RID: 18738 RVA: 0x001D1678 File Offset: 0x001CF878
	internal static bool 5(200 1)
	{
		return 1 == 200.LeftControl || 1 == 200.RightControl || 1 == 200.LeftAlt || 1 == 200.RightAlt || 1 == 200.LeftShift || 1 == 200.RightShift;
	}

	// Token: 0x06004933 RID: 18739 RVA: 0x001D16AC File Offset: 0x001CF8AC
	internal static 200 6(200 1)
	{
		if (1548.5(1) || (1 & (200)458752) != 200.None)
		{
			return 1;
		}
		int num = (1549.1 ? 65536 : 0) | (1549.2 ? 131072 : 0) | (1549.3 ? 262144 : 0);
		return 1 | (200)num;
	}

	// Token: 0x06004934 RID: 18740 RVA: 0x001D16FF File Offset: 0x001CF8FF
	internal static bool 7(1532 1)
	{
		return 1 > 1532._ExtraModsSettings && 1 < 1532._Practice;
	}

	// Token: 0x06004935 RID: 18741 RVA: 0x001D170D File Offset: 0x001CF90D
	public static 200 8(1532 1)
	{
		return 1548.1[1];
	}

	// Token: 0x06004936 RID: 18742 RVA: 0x001D171C File Offset: 0x001CF91C
	public static 1532 9(200 1, 1531 2)
	{
		if (1 == 200.None)
		{
			return 1532.None;
		}
		200 3 = 1548.6(1);
		1532 result;
		if (3 != 1 && 1548.2[2].TryGetValue(3, out result))
		{
			return result;
		}
		1532 result2;
		if (!1548.2[2].TryGetValue(1, out result2))
		{
			return 1532.None;
		}
		return result2;
	}

	// Token: 0x06004937 RID: 18743 RVA: 0x001D1768 File Offset: 0x001CF968
	public static string 10(1532 1)
	{
		return 1548.11(1548.1[1]);
	}

	// Token: 0x06004938 RID: 18744 RVA: 0x001D177C File Offset: 0x001CF97C
	public static string 11(200 1)
	{
		int num = (int)(1 & (200)458752);
		if (num != 0)
		{
			return (((num & 65536) != 0) ? "Ctrl+" : string.Empty) + (((num & 131072) != 0) ? "Alt+" : string.Empty) + (((num & 262144) != 0) ? "Shift+" : string.Empty) + 1548.11(1 & (200)(-458753));
		}
		string text = 1.ToString().Replace("Oem", string.Empty);
		if (text.Length == 2 && text[0] == 'D')
		{
			text = text.Substring(1);
		}
		if (1 >= (200)300)
		{
			1085 2 = (1085)1;
			text = 2.ToString();
			if (1 >= (200)340 && 1 < (200)362)
			{
				text = text.Replace("Min", "-").Replace("Max", "+");
			}
			return text;
		}
		if (1 <= 200.RightAlt)
		{
			if (1 != 200.Space)
			{
				switch (1)
				{
				case 200.LeftShift:
					text = "LSft";
					break;
				case 200.RightShift:
					text = "RSft";
					break;
				case 200.LeftControl:
					text = "LCon";
					break;
				case 200.RightControl:
					text = "RCon";
					break;
				case 200.LeftAlt:
					text = "LAlt";
					break;
				case 200.RightAlt:
					text = "RAlt";
					break;
				}
			}
			else
			{
				text = "Spc";
			}
		}
		else
		{
			switch (1)
			{
			case 200.OemSemicolon:
				text = ";";
				break;
			case 200.OemPlus:
			case 200.OemMinus:
				break;
			case 200.OemComma:
				text = ",";
				break;
			case 200.OemPeriod:
				text = ".";
				break;
			case 200.OemQuestion:
				text = "/";
				break;
			default:
				switch (1)
				{
				case 200.OemOpenBrackets:
					text = "[";
					break;
				case 200.OemPipe:
					text = "\\";
					break;
				case 200.OemCloseBrackets:
					text = "]";
					break;
				case 200.OemQuotes:
					text = "'";
					break;
				}
				break;
			}
		}
		return text;
	}

	// Token: 0x06004939 RID: 18745 RVA: 0x001D1958 File Offset: 0x001CFB58
	public static void 12()
	{
		List<200> list = new List<200>();
		list.Add(1548.8(1532.TaikoInnerLeft));
		if (list.Contains(1548.8(1532.TaikoInnerRight)))
		{
			1548.4(1532.TaikoInnerRight, 200.None);
		}
		else
		{
			list.Add(1548.8(1532.TaikoInnerRight));
		}
		if (list.Contains(1548.8(1532.TaikoOuterLeft)))
		{
			1548.4(1532.TaikoOuterLeft, 200.None);
		}
		else
		{
			list.Add(1548.8(1532.TaikoOuterLeft));
		}
		if (list.Contains(1548.8(1532.TaikoOuterRight)))
		{
			1548.4(1532.TaikoOuterRight, 200.None);
		}
		else
		{
			list.Add(1548.8(1532.TaikoOuterRight));
		}
		if (1548.1[1532.OsuLeft] == 1548.1[1532.OsuRight])
		{
			1548.4(1532.OsuRight, 200.None);
		}
	}

	// Token: 0x0600493A RID: 18746 RVA: 0x001D1A04 File Offset: 0x001CFC04
	public static 200 13(1533 1)
	{
		2147 2 = 2486.14();
		if (2 != 2147.Osu)
		{
			if (2 == 2147.Taiko)
			{
				switch (1)
				{
				case (1533)0:
					return 1548.1[1532.TaikoInnerLeft];
				case (1533)1:
					return 1548.1[1532.TaikoInnerRight];
				case (1533)2:
					return 1548.1[1532.TaikoOuterLeft];
				case (1533)3:
					return 1548.1[1532.TaikoOuterRight];
				}
			}
			return 200.None;
		}
		if (1 == (1533)0 || 1 == (1533)1)
		{
			return 1548.1[1532.OsuLeft];
		}
		return 1548.1[1532.OsuRight];
	}

	// Token: 0x0600493B RID: 18747 RVA: 0x001D1A8C File Offset: 0x001CFC8C
	public static void 14(bool 1)
	{
		1548.1 = new Dictionary<1532, 200>();
		1548.2 = new Dictionary<1531, Dictionary<200, 1532>>();
		foreach (object obj in Enum.GetValues(typeof(1531)))
		{
			1531 key = (1531)obj;
			1548.2[key] = new Dictionary<200, 1532>();
		}
		1548.4(1532.OsuLeft, 200.Z);
		1548.4(1532.OsuRight, 200.X);
		1548.4(1532.OsuSmoke, 200.C);
		1548.4(1532.FruitsDash, 200.LeftShift);
		1548.4(1532.FruitsLeft, 200.Left);
		1548.4(1532.FruitsRight, 200.Right);
		1548.4(1532.TaikoInnerLeft, 200.X);
		1548.4(1532.TaikoInnerRight, 200.C);
		1548.4(1532.TaikoOuterLeft, 200.Z);
		1548.4(1532.TaikoOuterRight, 200.V);
		1548.4(1532.Pause, 200.Escape);
		1548.4(1532.Skip, 200.Space);
		1548.4(1532.ToggleScoreboard, 200.Tab);
		1548.4(1532.ShowPlays, 200.F8);
		1548.4(1532.ShowProfileSettings, 200.F9);
		1548.4(1532.Screenshot, 200.F12);
		1548.4(1532.IncreaseAudioOffset, 200.OemPlus);
		1548.4(1532.DecreaseAudioOffset, 200.OemMinus);
		1548.4(1532.QuickRetry, 200.OemTilde);
		1548.4(1532.IncreaseSpeed, 200.F4);
		1548.4(1532.DecreaseSpeed, 200.F3);
		1548.4(1532.ToggleFrameLimiter, 200.F7);
		1548.4(1532.VolumeIncrease, 200.Up);
		1548.4(1532.VolumeDecrease, 200.Down);
		1548.4(1532.DisableMouseButtons, 200.F10);
		1548.4(1532.BossKey, 200.Insert);
		1548.4(1532.NewRandomSeed, (200)131154);
		1548.4(1532.SpeedUp, (200)65574);
		1548.4(1532.SpeedDown, (200)65576);
		1548.4(1532.SelectTool, 200.D1);
		1548.4(1532.NormalTool, 200.D2);
		1548.4(1532.SliderTool, 200.D3);
		1548.4(1532.SpinnerTool, 200.D4);
		1548.4(1532.NewComboToggle, 200.Q);
		1548.4(1532.WhistleToggle, 200.W);
		1548.4(1532.FinishToggle, 200.E);
		1548.4(1532.ClapToggle, 200.R);
		1548.4(1532.GridSnapToggle, 200.T);
		1548.4(1532.DistSnapToggle, 200.Y);
		1548.4(1532.NoteLockToggle, 200.L);
		1548.4(1532.NudgeLeft, 200.J);
		1548.4(1532.NudgeRight, 200.K);
		1548.4(1532.HelpToggle, 200.H);
		1548.4(1532.JumpToBegin, 200.Z);
		1548.4(1532.PlayFromBegin, 200.X);
		1548.4(1532.AudioPause, 200.C);
		1548.4(1532.JumpToEnd, 200.V);
		1548.4(1532.GridChange, 200.G);
		1548.4(1532.TimingSection, 200.None);
		1548.4(1532.InheritingSection, 200.None);
		1548.4(1532.RemoveSection, 200.None);
		1548.4(1532.Easy, 200.Q);
		1548.4(1532.NoFail, 200.W);
		1548.4(1532.HalfTime, 200.E);
		1548.4(1532.HardRock, 200.A);
		1548.4(1532.SuddenDeath, 200.S);
		1548.4(1532.DoubleTime, 200.D);
		1548.4(1532.Hidden, 200.F);
		1548.4(1532.Flashlight, 200.G);
		1548.4(1532.Relax, 200.Z);
		1548.4(1532.Autopilot, 200.X);
		1548.4(1532.SpunOut, 200.C);
		1548.4(1532.Auto, 200.V);
		1548.4(1532.ScoreV2, 200.B);
		1548.4(1532.ExtraDifficultyAdjust, 200.Q);
		1548.4(1532.ExtraNoNotelock, 200.W);
		1548.4(1532.ExtraMirror, 200.E);
		1548.4(1532.ExtraRandom, 200.R);
		1548.4(1532.ExtraAlternate, 200.T);
		1548.4(1532.ExtraSingleTap, 200.Y);
		1548.4(1532.ExtraPractice, 200.Z);
		1548.4(1532.ExtraPitch, 200.X);
		1548.4(1532.PracticeHold, 200.RightShift);
		1548.4(1532.PracticePreviousCheckpoint, 200.Left);
		1548.4(1532.PracticeNextCheckpoint, 200.Right);
		1548.4(1532.PracticeLeaveSegment, 200.Back);
		1548.4(1532.PracticeRename, 200.F2);
		if (1)
		{
			return;
		}
		1304.1.Remove("keyToggleChat");
		1304.1.Remove("keyToggleExtendedChat");
		1304.1.Remove("keyPracticeRetryCheckpoint");
		string[] names = Enum.GetNames(typeof(1532));
		for (int i = 1; i < names.Length; i++)
		{
			string text = names[i];
			if (text[0] != '_')
			{
				try
				{
					object obj2;
					if (1304.1.TryGetValue("key" + text, out obj2))
					{
						1548.1((1532)i, (200)Enum.Parse(typeof(200), obj2.ToString(), true));
					}
				}
				catch
				{
				}
			}
		}
		foreach (1532 2 in new 1532[]
		{
			1532.ShowPlays,
			1532.ShowProfileSettings
		})
		{
			200 3 = 1548.1[2];
			if (3 != 200.None && 1548.9(3, 1531.Universal) != 2)
			{
				1548.1[2] = 200.None;
			}
		}
		1548.12();
		2006.1();
	}

	// Token: 0x0600493C RID: 18748 RVA: 0x001D1EE8 File Offset: 0x001D00E8
	public static void 15()
	{
		foreach (KeyValuePair<1532, 200> keyValuePair in 1548.1)
		{
			1304.1["key" + keyValuePair.Key.ToString()] = keyValuePair.Value.ToString();
		}
		2006.2();
	}

	// Token: 0x0600493D RID: 18749 RVA: 0x001D1F78 File Offset: 0x001D0178
	public static 1532 16(200 1)
	{
		return 1548.9(1, 1531.Universal);
	}

	// Token: 0x0600493E RID: 18750 RVA: 0x001D1F81 File Offset: 0x001D0181
	public static bool 17(200 1, 1532 2)
	{
		return 1548.8(2) == 1;
	}

	// Token: 0x0600493F RID: 18751 RVA: 0x001D1F8C File Offset: 0x001D018C
	internal static bool 18(200 1, 2147 2)
	{
		switch (2)
		{
		case 2147.Osu:
			if (1 == 1548.8(1532.OsuLeft))
			{
				return true;
			}
			if (1 == 1548.8(1532.OsuRight))
			{
				return true;
			}
			break;
		case 2147.Taiko:
			if (1 == 1548.8(1532.TaikoInnerLeft))
			{
				return true;
			}
			if (1 == 1548.8(1532.TaikoInnerRight))
			{
				return true;
			}
			if (1 == 1548.8(1532.TaikoOuterLeft))
			{
				return true;
			}
			if (1 == 1548.8(1532.TaikoOuterRight))
			{
				return true;
			}
			break;
		case 2147.CatchTheBeat:
			if (1 == 1548.8(1532.FruitsLeft))
			{
				return true;
			}
			if (1 == 1548.8(1532.FruitsRight))
			{
				return true;
			}
			if (1 == 1548.8(1532.FruitsDash))
			{
				return true;
			}
			break;
		}
		return false;
	}

	// Token: 0x040036A5 RID: 13989
	private static Dictionary<1532, 200> 1 = new Dictionary<1532, 200>();

	// Token: 0x040036A6 RID: 13990
	private static Dictionary<1531, Dictionary<200, 1532>> 2 = new Dictionary<1531, Dictionary<200, 1532>>();

	// Token: 0x040036A7 RID: 13991
	public static string[] 3 = new string[]
	{
		"None",
		"_osu!",
		"Left Click",
		"Right Click",
		"Smoke",
		"_osu!taiko",
		"Drum Centre (Left)",
		"Drum Centre (Right)",
		"Drum Rim (Left)",
		"Drum Rim (Right)",
		"_osu!catch",
		"Move Left",
		"Move Right",
		"Dash! (2x movement speed)",
		"_osu!mania",
		"Increase Speed",
		"Decrease Speed",
		"_In-Game",
		"Game Pause",
		"Skip Cutscene",
		"Toggle Scoreboard",
		"Increase Local Song Offset",
		"Decrease Local Song Offset",
		"Quick Retry (hold briefly)",
		"_Universal",
		"Toggle Framerate Limit",
		"Show Plays List",
		"Profile Settings",
		"Save Screenshot",
		"Increase Volume",
		"Decrease Volume",
		"Disable mouse buttons",
		"Boss key",
		"_Editor",
		"Select Tool",
		"Normal Tool",
		"Slider Tool",
		"Spinner Tool",
		"New Combo Toggle",
		"Whistle Toggle",
		"Finish Toggle",
		"Clap Toggle",
		"Grid Snap Toggle",
		"Distance Snap Toggle",
		"Note Lock Toggle",
		"Nudge Left",
		"Nudge Right",
		"Help Toggle",
		"Jump To First Note",
		"Play From Beginning",
		"Audio Pause",
		"Jump To End",
		"Grid Size Change",
		"Add Timing Section",
		"Add Inheriting Section",
		"Remove Section",
		"_Mod Select",
		"Easy",
		"No Fail",
		"Half Time",
		"Hard Rock",
		"Sudden Death",
		"Double Time",
		"Hidden",
		"Flashlight",
		"Relax",
		"Autopilot",
		"Spun Out",
		"Auto",
		"Score v2",
		"_Extra Mods",
		"Difficulty Adjust",
		"No Notelock",
		"Mirror",
		"Random",
		"Alternate",
		"Single Tap",
		"Practice",
		"Pitch",
		"_Extra Mods - Extra Settings",
		"New random seed",
		"Speed up",
		"Speed down",
		"_Practice",
		"Seek bar",
		"Previous checkpoint or segment",
		"Next checkpoint or segment",
		"Leave the segment",
		"Rename"
	};

	// Token: 0x040036A8 RID: 13992
	public static readonly int[] 4 = new int[]
	{
		4,
		13
	};

	// Token: 0x040036A9 RID: 13993
	public static readonly 200[] 5 = new 200[]
	{
		200.A,
		200.S,
		200.D,
		200.F,
		200.Space,
		200.J,
		200.K,
		200.L,
		200.OemSemicolon,
		200.Q,
		200.W,
		200.E,
		200.R,
		200.RightAlt,
		200.U,
		200.I,
		200.O,
		200.P
	};

	// Token: 0x040036AA RID: 13994
	public static readonly 200[] 6 = new 200[]
	{
		200.LeftShift,
		200.RightShift
	};

	// Token: 0x040036AB RID: 13995
	public static readonly 200[] 7 = new 200[]
	{
		200.LeftControl,
		200.RightControl
	};

	// Token: 0x040036AC RID: 13996
	public const int 8 = 65536;

	// Token: 0x040036AD RID: 13997
	public const int 9 = 131072;

	// Token: 0x040036AE RID: 13998
	public const int 10 = 262144;

	// Token: 0x040036AF RID: 13999
	private const int 11 = 458752;
}
