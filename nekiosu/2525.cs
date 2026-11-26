using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

// Token: 0x0200053C RID: 1340
[276]
internal static class 2525
{
	// Token: 0x17000262 RID: 610
	// (get) Token: 0x06002939 RID: 10553 RVA: 0x000D5C3D File Offset: 0x000D3E3D
	private static 2147 Mode
	{
		get
		{
			return 2486.14();
		}
	}

	// Token: 0x17000263 RID: 611
	// (get) Token: 0x0600293A RID: 10554 RVA: 0x000D5C44 File Offset: 0x000D3E44
	private static string FilePath
	{
		get
		{
			return 268.2(2525.1(2525.Mode));
		}
	}

	// Token: 0x0600293B RID: 10555 RVA: 0x000D5C55 File Offset: 0x000D3E55
	private static string 1(2147 1)
	{
		switch (1)
		{
		case 2147.Taiko:
			return "nekiosu.hud.taiko.ini";
		case 2147.CatchTheBeat:
			return "nekiosu.hud.catch.ini";
		case 2147.OsuMania:
			return "nekiosu.hud.mania.ini";
		default:
			return "nekiosu.hud.ini";
		}
	}

	// Token: 0x17000264 RID: 612
	// (get) Token: 0x0600293C RID: 10556 RVA: 0x000D5C84 File Offset: 0x000D3E84
	private static Dictionary<string, 2525.2526> Entries
	{
		get
		{
			if (2525.2 == null || 2525.3 != 2525.Mode)
			{
				2525.3 = 2525.Mode;
				2525.2 = 2525.6();
			}
			return 2525.2;
		}
	}

	// Token: 0x0600293D RID: 10557 RVA: 0x000D5CB4 File Offset: 0x000D3EB4
	internal static void Apply(2528 1)
	{
		2525.2526 2;
		if (!2525.Entries.TryGetValue(1.3, out 2))
		{
			return;
		}
		1.8 = 2.2;
		1.9 = 2.3;
		1.10 = 2.4;
		1.11 = 2.5;
		1.12 = 2.6;
		1.13 = 2.7;
		1.14 = 2.8;
		1.15 = 2.9;
		1.16 = 2.10;
		1.17 = 2.11;
		1.18 = 2.12;
		1.19 = 2.13;
		1.20 = 2.14;
		1.26.Clear();
		foreach (KeyValuePair<string, string> keyValuePair in 2.15)
		{
			1.26[keyValuePair.Key] = keyValuePair.Value;
		}
	}

	// Token: 0x0600293E RID: 10558 RVA: 0x000D5DD8 File Offset: 0x000D3FD8
	internal static void 2(2528 1)
	{
		if (1.IsDefault && !1.IsExtraInstance)
		{
			2525.Entries.Remove(1.3);
			return;
		}
		2525.2526 2 = new 2525.2526
		{
			1 = 1.4,
			2 = 1.8,
			3 = 1.9,
			4 = 1.10,
			5 = 1.11,
			6 = 1.12,
			7 = 1.13,
			8 = 1.14,
			9 = 1.15,
			10 = 1.16,
			11 = 1.17,
			12 = 1.18,
			13 = 1.19,
			14 = 1.20
		};
		foreach (KeyValuePair<string, string> keyValuePair in 1.26)
		{
			2.15[keyValuePair.Key] = keyValuePair.Value;
		}
		2525.Entries[1.3] = 2;
	}

	// Token: 0x0600293F RID: 10559 RVA: 0x000D5F20 File Offset: 0x000D4120
	internal static void Remove(string 1)
	{
		2525.Entries.Remove(1);
	}

	// Token: 0x06002940 RID: 10560 RVA: 0x000D5F2E File Offset: 0x000D412E
	internal static bool 3(string 1)
	{
		return 2525.Entries.ContainsKey(1);
	}

	// Token: 0x06002941 RID: 10561 RVA: 0x000D5F3C File Offset: 0x000D413C
	internal static List<string> 4(string 1)
	{
		List<string> list = new List<string>();
		foreach (KeyValuePair<string, 2525.2526> keyValuePair in 2525.Entries)
		{
			if (string.Equals(keyValuePair.Value.1 ?? 2528.2(keyValuePair.Key), 1, StringComparison.OrdinalIgnoreCase) && !string.Equals(keyValuePair.Key, 1, StringComparison.OrdinalIgnoreCase))
			{
				list.Add(keyValuePair.Key);
			}
		}
		list.Sort(StringComparer.OrdinalIgnoreCase);
		return list;
	}

	// Token: 0x06002942 RID: 10562 RVA: 0x000D5FDC File Offset: 0x000D41DC
	internal static void Save()
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			Dictionary<string, 2525.2526> entries = 2525.Entries;
			stringBuilder.AppendLine("# nekiosu HUD layout. Offsets are in game units (480 high) from the anchor, x to the right and y down.");
			foreach (KeyValuePair<string, 2525.2526> keyValuePair in entries)
			{
				2525.2526 value = keyValuePair.Value;
				stringBuilder.AppendLine();
				stringBuilder.AppendLine("[" + keyValuePair.Key + "]");
				if (!string.Equals(value.1 ?? 2528.2(keyValuePair.Key), keyValuePair.Key, StringComparison.OrdinalIgnoreCase))
				{
					stringBuilder.AppendLine("Type = " + value.1);
				}
				stringBuilder.AppendLine("Anchor = " + value.2.ToString());
				stringBuilder.AppendLine("X = " + value.3.X.ToString("0.##", CultureInfo.InvariantCulture));
				stringBuilder.AppendLine("Y = " + value.3.Y.ToString("0.##", CultureInfo.InvariantCulture));
				stringBuilder.AppendLine("Scale = " + value.4.ToString("0.###", CultureInfo.InvariantCulture));
				stringBuilder.AppendLine("Visible = " + (value.5 ? "1" : "0"));
				if (value.8 != 2527.Default)
				{
					stringBuilder.AppendLine("Origin = " + value.8.ToString());
				}
				if (value.9 != 0f)
				{
					stringBuilder.AppendLine("Rotation = " + value.9.ToString("0.##", CultureInfo.InvariantCulture));
				}
				if (value.10)
				{
					stringBuilder.AppendLine("FlipX = 1");
				}
				if (value.11)
				{
					stringBuilder.AppendLine("FlipY = 1");
				}
				if (value.12 != 1f)
				{
					stringBuilder.AppendLine("Opacity = " + value.12.ToString("0.###", CultureInfo.InvariantCulture));
				}
				if (value.13 != 198.White)
				{
					stringBuilder.AppendLine("Colour = " + 2530.9(value.13));
				}
				if (value.14 != 0)
				{
					stringBuilder.AppendLine("Order = " + value.14.ToString(CultureInfo.InvariantCulture));
				}
				if (value.7)
				{
					stringBuilder.AppendLine("FixedAnchor = 1");
				}
				if (value.6 != 2524.Follow)
				{
					stringBuilder.AppendLine("WithoutInterface = " + value.6.ToString());
				}
				foreach (KeyValuePair<string, string> keyValuePair2 in value.15)
				{
					stringBuilder.AppendLine("Setting." + keyValuePair2.Key + " = " + (keyValuePair2.Value ?? string.Empty).Replace("\r", " ").Replace("\n", " "));
				}
			}
			File.WriteAllText(2525.FilePath, stringBuilder.ToString(), new UTF8Encoding(false));
		}
		catch (Exception ex)
		{
			1338.4(ex, "saving the HUD layout", 1341.Runtime);
		}
	}

	// Token: 0x06002943 RID: 10563 RVA: 0x000D6394 File Offset: 0x000D4594
	internal static void 5()
	{
		2525.2 = null;
	}

	// Token: 0x06002944 RID: 10564 RVA: 0x000D639C File Offset: 0x000D459C
	private static Dictionary<string, 2525.2526> 6()
	{
		Dictionary<string, 2525.2526> dictionary = new Dictionary<string, 2525.2526>(StringComparer.OrdinalIgnoreCase);
		try
		{
			string path = File.Exists(2525.FilePath) ? 2525.FilePath : 268.2(2525.1(2147.Osu));
			if (!File.Exists(path))
			{
				return dictionary;
			}
			2525.2526 <<EMPTY_NAME>> = null;
			string[] array = File.ReadAllLines(path);
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i].Trim();
				if (text.Length != 0 && !text.StartsWith("#", StringComparison.Ordinal))
				{
					if (text.StartsWith("[", StringComparison.Ordinal) && text.EndsWith("]", StringComparison.Ordinal))
					{
						string key = text.Substring(1, text.Length - 2).Trim();
						<<EMPTY_NAME>> = new 2525.2526
						{
							2 = 2509.TopLeft,
							1 = 2528.2(key)
						};
						dictionary[key] = <<EMPTY_NAME>>;
					}
					else
					{
						int num = text.IndexOf('=');
						if (<<EMPTY_NAME>> != null && num >= 0)
						{
							string text2 = text.Substring(0, num).Trim();
							string text3 = text.Substring(num + 1).Trim();
							if (text2.StartsWith("Setting.", StringComparison.OrdinalIgnoreCase))
							{
								<<EMPTY_NAME>>.15[text2.Substring("Setting.".Length)] = text3;
							}
							else
							{
								float num2;
								float.TryParse(text3, NumberStyles.Float, CultureInfo.InvariantCulture, out num2);
								bool flag = text3 == "1" || text3.Equals("true", StringComparison.OrdinalIgnoreCase);
								string text4 = text2.ToLowerInvariant();
								if (text4 != null)
								{
									int length = text4.Length;
									switch (length)
									{
									case 1:
									{
										char c = text4[0];
										if (c == 'x')
										{
											<<EMPTY_NAME>>.3.X = num2;
											goto IL_543;
										}
										if (c != 'y')
										{
											goto IL_543;
										}
										<<EMPTY_NAME>>.3.Y = num2;
										goto IL_543;
									}
									case 2:
									case 3:
									case 9:
									case 10:
										goto IL_543;
									case 4:
										if (!(text4 == "type"))
										{
											goto IL_543;
										}
										if (text3.Length > 0)
										{
											<<EMPTY_NAME>>.1 = text3;
											goto IL_543;
										}
										goto IL_543;
									case 5:
									{
										char c = text4[0];
										if (c <= 'f')
										{
											if (c != 'c')
											{
												if (c != 'f')
												{
													goto IL_543;
												}
												if (text4 == "flipx")
												{
													<<EMPTY_NAME>>.10 = flag;
													goto IL_543;
												}
												if (!(text4 == "flipy"))
												{
													goto IL_543;
												}
												<<EMPTY_NAME>>.11 = flag;
												goto IL_543;
											}
											else if (!(text4 == "color"))
											{
												goto IL_543;
											}
										}
										else if (c != 'o')
										{
											if (c != 's')
											{
												goto IL_543;
											}
											if (!(text4 == "scale"))
											{
												goto IL_543;
											}
											<<EMPTY_NAME>>.4 = ((num2 > 0.05f) ? Math.Min(num2, 10f) : 1f);
											goto IL_543;
										}
										else
										{
											if (!(text4 == "order"))
											{
												goto IL_543;
											}
											<<EMPTY_NAME>>.14 = (int)num2;
											goto IL_543;
										}
										break;
									}
									case 6:
									{
										char c = text4[0];
										if (c != 'a')
										{
											if (c != 'c')
											{
												if (c != 'o')
												{
													goto IL_543;
												}
												if (!(text4 == "origin"))
												{
													goto IL_543;
												}
												2527 2;
												if (Enum.TryParse<2527>(text3, true, out 2) && Enum.IsDefined(typeof(2527), 2))
												{
													<<EMPTY_NAME>>.8 = 2;
													goto IL_543;
												}
												goto IL_543;
											}
											else if (!(text4 == "colour"))
											{
												goto IL_543;
											}
										}
										else
										{
											if (!(text4 == "anchor"))
											{
												goto IL_543;
											}
											2509 3;
											if (Enum.TryParse<2509>(text3, true, out 3) && Enum.IsDefined(typeof(2509), 3))
											{
												<<EMPTY_NAME>>.2 = 3;
												goto IL_543;
											}
											goto IL_543;
										}
										break;
									}
									case 7:
									{
										char c = text4[0];
										if (c != 'o')
										{
											if (c != 'v')
											{
												goto IL_543;
											}
											if (!(text4 == "visible"))
											{
												goto IL_543;
											}
											<<EMPTY_NAME>>.5 = (text3 != "0" && !text3.Equals("false", StringComparison.OrdinalIgnoreCase));
											goto IL_543;
										}
										else
										{
											if (!(text4 == "opacity"))
											{
												goto IL_543;
											}
											<<EMPTY_NAME>>.12 = Math.Max(0f, Math.Min(1f, num2));
											goto IL_543;
										}
										break;
									}
									case 8:
										if (!(text4 == "rotation"))
										{
											goto IL_543;
										}
										<<EMPTY_NAME>>.9 = 2528.44(num2);
										goto IL_543;
									case 11:
										if (!(text4 == "fixedanchor"))
										{
											goto IL_543;
										}
										<<EMPTY_NAME>>.7 = flag;
										goto IL_543;
									default:
									{
										if (length != 16)
										{
											goto IL_543;
										}
										if (!(text4 == "withoutinterface"))
										{
											goto IL_543;
										}
										2524 4;
										if (Enum.TryParse<2524>(text3, true, out 4) && Enum.IsDefined(typeof(2524), 4))
										{
											<<EMPTY_NAME>>.6 = 4;
											goto IL_543;
										}
										goto IL_543;
									}
									}
									198 5;
									if (2530.10(text3, out 5))
									{
										<<EMPTY_NAME>>.13 = 5;
									}
								}
							}
						}
					}
				}
				IL_543:;
			}
		}
		catch (Exception ex)
		{
			1338.4(ex, "reading the HUD layout", 1341.Runtime);
		}
		return dictionary;
	}

	// Token: 0x04001DCB RID: 7627
	private const string 1 = "Setting.";

	// Token: 0x04001DCC RID: 7628
	private static Dictionary<string, 2525.2526> 2;

	// Token: 0x04001DCD RID: 7629
	private static 2147 3;

	// Token: 0x0200053D RID: 1341
	[276]
	internal sealed class 2526
	{
		// Token: 0x04001DCE RID: 7630
		public string 1;

		// Token: 0x04001DCF RID: 7631
		public 2509 2;

		// Token: 0x04001DD0 RID: 7632
		public 208 3;

		// Token: 0x04001DD1 RID: 7633
		public float 4 = 1f;

		// Token: 0x04001DD2 RID: 7634
		public bool 5 = true;

		// Token: 0x04001DD3 RID: 7635
		public 2524 6;

		// Token: 0x04001DD4 RID: 7636
		public bool 7;

		// Token: 0x04001DD5 RID: 7637
		public 2527 8;

		// Token: 0x04001DD6 RID: 7638
		public float 9;

		// Token: 0x04001DD7 RID: 7639
		public bool 10;

		// Token: 0x04001DD8 RID: 7640
		public bool 11;

		// Token: 0x04001DD9 RID: 7641
		public float 12 = 1f;

		// Token: 0x04001DDA RID: 7642
		public 198 13 = 198.White;

		// Token: 0x04001DDB RID: 7643
		public int 14;

		// Token: 0x04001DDC RID: 7644
		public readonly Dictionary<string, string> 15 = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
	}
}
