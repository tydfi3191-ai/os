using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

// Token: 0x02000666 RID: 1638
[276]
public static class 2205
{
	// Token: 0x060031A7 RID: 12711 RVA: 0x0012A0C8 File Offset: 0x001282C8
	public static byte[] 1(2241 1)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("{\"online_id\":-1,\"mods\":[");
		stringBuilder.Append(string.Join(",", 2205.6(1)));
		stringBuilder.Append("],\"statistics\":{");
		stringBuilder.Append(string.Join(",", 2205.7(1)));
		stringBuilder.Append("},\"maximum_statistics\":{");
		stringBuilder.Append(string.Join(",", 2205.8(1)));
		stringBuilder.Append("},\"client_version\":\"nekiosu\"");
		string text = 2205.9(1);
		if (text != null)
		{
			stringBuilder.Append(",\"rank\":\"").Append(text).Append('"');
		}
		if (1.47)
		{
			stringBuilder.Append(",\"nekiosu_practice_start\":").Append(1.48.GetValueOrDefault(-1).ToString(CultureInfo.InvariantCulture));
			if (1.49 != null)
			{
				stringBuilder.Append(",\"nekiosu_practice_end\":").Append(1.49.Value.ToString(CultureInfo.InvariantCulture));
			}
		}
		if (1.50 != 0f)
		{
			stringBuilder.Append(",\"nekiosu_pitch\":").Append(1.50.ToString(CultureInfo.InvariantCulture));
		}
		stringBuilder.Append(",\"user_id\":1,\"pauses\":[]}");
		return 182.Compress(new ASCIIEncoding().GetBytes(stringBuilder.ToString()));
	}

	// Token: 0x060031A8 RID: 12712 RVA: 0x0012A22C File Offset: 0x0012842C
	public static void 2(byte[] 1, 2241 2)
	{
		if (1 == null || 1.Length == 0)
		{
			return;
		}
		try
		{
			217 3 = 217.Parse(new ASCIIEncoding().GetString(182.Decompress(1)));
			233 4 = 3["nekiosu_pitch"] as 233;
			if (4 != null && 4.Value != null)
			{
				2.50 = Convert.ToSingle(4.Value, CultureInfo.InvariantCulture);
			}
			233 5 = 3["nekiosu_practice_start"] as 233;
			if (5 != null && 5.Value != null)
			{
				int num = Convert.ToInt32(5.Value, CultureInfo.InvariantCulture);
				2.47 = true;
				2.48 = ((num >= 0) ? new int?(num) : null);
				233 6 = 3["nekiosu_practice_end"] as 233;
				if (6 != null && 6.Value != null)
				{
					2.49 = new int?(Convert.ToInt32(6.Value, CultureInfo.InvariantCulture));
				}
			}
			109 7 = 3["mods"] as 109;
			if (7 != null)
			{
				bool flag = false;
				foreach (226 8 in 7)
				{
					if ((string)8["acronym"] == "CL")
					{
						217 9 = 8["settings"] as 217;
						if (9 == null)
						{
							goto IL_17D;
						}
						233 10 = 9["classic_note_lock"] as 233;
						if (10 == null)
						{
							goto IL_17D;
						}
						object value = 10.Value;
						bool flag2;
						int num2;
						if (value is bool)
						{
							flag2 = (bool)value;
							num2 = 1;
						}
						else
						{
							num2 = 0;
						}
						bool flag3 = num2 == 0;
						IL_17E:
						flag = (flag3 || flag2);
						continue;
						IL_17D:
						flag3 = true;
						goto IL_17E;
					}
				}
				2.45 = (2.9 == 2147.Osu && !flag);
				foreach (226 11 in 7)
				{
					if ((string)11["acronym"] == "HD")
					{
						217 12 = 11["settings"] as 217;
						if (12 != null)
						{
							233 13 = 12["only_fade_approach_circles"] as 233;
							if (13 != null)
							{
								object value = 13.Value;
								if (value is bool)
								{
									bool flag4 = (bool)value;
									2.46 = (2.9 == 2147.Osu && flag4);
								}
							}
						}
					}
				}
				2205.3(7, 2);
				foreach (226 14 in 7)
				{
					string a = (string)14["acronym"];
					if (a == "DT" || a == "NC" || a == "HT" || a == "DC")
					{
						2205.5(14["settings"], a, 2);
					}
					else if (!(a != "DA"))
					{
						Dictionary<1928, float> dictionary = new Dictionary<1928, float>();
						226 15 = 14["settings"];
						bool flag5 = false;
						if (15 is 217)
						{
							foreach (KeyValuePair<1928, string> keyValuePair in 2205.3)
							{
								233 16 = 15[keyValuePair.Value] as 233;
								if (16 != null && 16.Value != null)
								{
									dictionary[keyValuePair.Key] = Convert.ToSingle(16.Value, CultureInfo.InvariantCulture);
								}
							}
							233 17 = 15["extended_limits"] as 233;
							bool flag6;
							bool flag7;
							if (17 != null)
							{
								object value = 17.Value;
								if (value is bool)
								{
									flag6 = (bool)value;
									flag7 = true;
								}
								else
								{
									flag7 = false;
								}
							}
							else
							{
								flag7 = false;
							}
							flag5 = (flag7 && flag6);
						}
						2.43 = new 1927(dictionary, flag5);
					}
				}
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x060031A9 RID: 12713 RVA: 0x0012A680 File Offset: 0x00128880
	private static void 3(109 1, 2241 2)
	{
		if (2.9 == 2147.Taiko || 2.9 == 2147.CatchTheBeat)
		{
			2205.4(1, 2);
			return;
		}
		if (2.9 != 2147.Osu)
		{
			return;
		}
		1932? 3 = null;
		1930 4 = 1930.None;
		1938 5 = null;
		foreach (226 6 in 1)
		{
			string a = (string)6["acronym"];
			if (!(a == "MR"))
			{
				if (!(a == "RD"))
				{
					if (!(a == "AL"))
					{
						if (a == "SG")
						{
							4 = 1930.SingleTap;
						}
					}
					else
					{
						4 = 1930.Alternate;
					}
				}
				else
				{
					217 7 = 6["settings"] as 217;
					if (7 != null)
					{
						233 8 = 7["seed"] as 233;
						if (8 != null && 8.Value != null)
						{
							float num = 7f;
							233 9 = 7["angle_sharpness"] as 233;
							if (9 != null && 9.Value != null)
							{
								num = Convert.ToSingle(9.Value, CultureInfo.InvariantCulture);
							}
							5 = new 1938(Convert.ToInt32(8.Value, CultureInfo.InvariantCulture), num, 100);
						}
					}
				}
			}
			else
			{
				3 = new 1932?(1932.Horizontal);
				217 10 = 6["settings"] as 217;
				if (10 != null)
				{
					233 11 = 10["reflection"] as 233;
					if (11 != null && 11.Value != null)
					{
						string a2 = Convert.ToString(11.Value, CultureInfo.InvariantCulture);
						if (a2 == "1" || string.Equals(a2, "Vertical", StringComparison.OrdinalIgnoreCase))
						{
							3 = new 1932?(1932.Vertical);
						}
						else if (a2 == "2" || string.Equals(a2, "Both", StringComparison.OrdinalIgnoreCase))
						{
							3 = new 1932?(1932.Both);
						}
					}
				}
			}
		}
		1925 12 = new 1925(3, 4, 5);
		2.52 = (12.IsEmpty ? null : 12);
	}

	// Token: 0x060031AA RID: 12714 RVA: 0x0012A8C0 File Offset: 0x00128AC0
	private static void 4(109 1, 2241 2)
	{
		bool flag = 2.9 == 2147.Taiko;
		1932? 3 = null;
		1938 4 = null;
		foreach (226 5 in 1)
		{
			string a = (string)5["acronym"];
			if (!(a == "SW"))
			{
				if (!(a == "MR"))
				{
					if (a == "RD" || a == "NRD")
					{
						if ((string)5["acronym"] == "RD" == flag)
						{
							217 6 = 5["settings"] as 217;
							if (6 != null)
							{
								233 7 = 6["seed"] as 233;
								if (7 != null && 7.Value != null)
								{
									int num = 100;
									233 8 = 6["nekiosu_randomness"] as 233;
									if (8 != null && 8.Value != null)
									{
										num = Convert.ToInt32(8.Value, CultureInfo.InvariantCulture);
									}
									4 = new 1938(Convert.ToInt32(7.Value, CultureInfo.InvariantCulture), 7f, num);
								}
							}
						}
					}
				}
				else if (!flag)
				{
					3 = new 1932?(1932.Horizontal);
				}
			}
			else if (flag)
			{
				3 = new 1932?(1932.Horizontal);
			}
		}
		1925 9 = new 1925(3, 1930.None, 4);
		2.52 = (9.IsEmpty ? null : 9);
	}

	// Token: 0x060031AB RID: 12715 RVA: 0x0012AA6C File Offset: 0x00128C6C
	private static void 5(226 1, string 2, 2241 3)
	{
		double num = (2 == "DT" || 2 == "NC") ? 1.5 : 0.75;
		double num2 = num;
		bool flag = 2 == "DC";
		if (1 is 217)
		{
			233 4 = 1["speed_change"] as 233;
			if (4 != null && 4.Value != null)
			{
				num2 = Convert.ToDouble(4.Value, CultureInfo.InvariantCulture);
			}
			233 5 = 1["adjust_pitch"] as 233;
			if (5 != null)
			{
				object value = 5.Value;
				if (value is bool)
				{
					bool flag2 = (bool)value;
					flag = flag2;
				}
			}
		}
		if (Math.Abs(num2 - num) > 0.005 || (flag && 2 != "NC"))
		{
			3.44 = new 1940(num2, flag && 2 != "NC");
		}
	}

	// Token: 0x060031AC RID: 12716 RVA: 0x0012AB64 File Offset: 0x00128D64
	private static List<string> 6(2241 1)
	{
		2023 2 = 1.8;
		if ((2 & 2023.Nightcore) != 2023.None)
		{
			2 &= ~2023.DoubleTime;
		}
		if ((2 & 2023.Perfect) != 2023.None)
		{
			2 &= ~2023.SuddenDeath;
		}
		if ((2 & 2023.Cinema) != 2023.None)
		{
			2 &= ~2023.Autoplay;
		}
		List<string> list = new List<string>();
		foreach (KeyValuePair<2023, string> keyValuePair in 2205.2)
		{
			if ((2 & keyValuePair.Key) != 2023.None)
			{
				if ((keyValuePair.Key & (2023.DoubleTime | 2023.HalfTime | 2023.Nightcore)) > 2023.None && 1.44 != null)
				{
					string text = "\"speed_change\":" + 1.44.Rate.ToString("0.0#", CultureInfo.InvariantCulture);
					if (1.44.AdjustPitch && keyValuePair.Key != 2023.Nightcore)
					{
						text += ",\"adjust_pitch\":true";
					}
					list.Add(string.Concat(new string[]
					{
						"{\"acronym\":\"",
						keyValuePair.Value,
						"\",\"settings\":{",
						text,
						"}}"
					}));
				}
				else if (keyValuePair.Key == 2023.Hidden && 1.46)
				{
					list.Add("{\"acronym\":\"HD\",\"settings\":{\"only_fade_approach_circles\":true}}");
				}
				else
				{
					list.Add("{\"acronym\":\"" + keyValuePair.Value + "\"}");
				}
			}
		}
		if (1.43 != null)
		{
			List<string> list2 = new List<string>();
			foreach (KeyValuePair<1928, string> keyValuePair2 in 2205.3)
			{
				float? num = 1.43.Get(keyValuePair2.Key);
				if (num != null)
				{
					list2.Add("\"" + keyValuePair2.Value + "\":" + num.Value.ToString("0.0#", CultureInfo.InvariantCulture));
				}
			}
			if (1.43.ExtendedLimits)
			{
				list2.Add("\"extended_limits\":true");
			}
			list.Add("{\"acronym\":\"DA\",\"settings\":{" + string.Join(",", list2) + "}}");
		}
		if (1.52 != null && 1.9 == 2147.Osu)
		{
			if (1.52.5 != null)
			{
				list.Add((1.52.5.Value == 1932.Horizontal) ? "{\"acronym\":\"MR\"}" : ("{\"acronym\":\"MR\",\"settings\":{\"reflection\":" + ((int)1.52.5.Value).ToString(CultureInfo.InvariantCulture) + "}}"));
			}
			if (1.52.7 != null)
			{
				string text2 = "\"seed\":" + 1.52.7.4.ToString(CultureInfo.InvariantCulture);
				if (!1.52.7.HasDefaultSharpness)
				{
					text2 = text2 + ",\"angle_sharpness\":" + 1.52.7.5.ToString("0.0", CultureInfo.InvariantCulture);
				}
				list.Add("{\"acronym\":\"RD\",\"settings\":{" + text2 + "}}");
			}
			if (1.52.6 == 1930.Alternate)
			{
				list.Add("{\"acronym\":\"AL\"}");
			}
			else if (1.52.6 == 1930.SingleTap)
			{
				list.Add("{\"acronym\":\"SG\"}");
			}
		}
		else if (1.52 != null && 1.9 == 2147.Taiko)
		{
			if (1.52.5 != null)
			{
				list.Add("{\"acronym\":\"SW\"}");
			}
			if (1.52.7 != null)
			{
				string text3 = "\"seed\":" + 1.52.7.4.ToString(CultureInfo.InvariantCulture);
				if (!1.52.7.HasDefaultStrength)
				{
					text3 = text3 + ",\"nekiosu_randomness\":" + 1.52.7.9.ToString(CultureInfo.InvariantCulture);
				}
				list.Add("{\"acronym\":\"RD\",\"settings\":{" + text3 + "}}");
			}
		}
		else if (1.52 != null && 1.9 == 2147.CatchTheBeat)
		{
			if (1.52.5 != null)
			{
				list.Add("{\"acronym\":\"MR\"}");
			}
			if (1.52.7 != null)
			{
				string text4 = "\"seed\":" + 1.52.7.4.ToString(CultureInfo.InvariantCulture);
				if (!1.52.7.HasDefaultStrength)
				{
					text4 = text4 + ",\"nekiosu_randomness\":" + 1.52.7.9.ToString(CultureInfo.InvariantCulture);
				}
				list.Add("{\"acronym\":\"NRD\",\"settings\":{" + text4 + "}}");
			}
		}
		list.Add(1.45 ? "{\"acronym\":\"CL\",\"settings\":{\"classic_note_lock\":false}}" : "{\"acronym\":\"CL\"}");
		return list;
	}

	// Token: 0x060031AD RID: 12717 RVA: 0x0012B070 File Offset: 0x00129270
	private static List<string> 7(2241 1)
	{
		List<string> statistics = new List<string>();
		Action<string, int> action = delegate(string 1, int 2)
		{
			if (2 != 0)
			{
				statistics.Add("\"" + 1 + "\":" + 2.ToString(CultureInfo.InvariantCulture));
			}
		};
		switch (3.9)
		{
		case 2147.Taiko:
			action("great", (int)3.2);
			action("ok", (int)3.1);
			break;
		case 2147.CatchTheBeat:
			action("great", (int)3.2);
			action("large_tick_hit", (int)3.1);
			action("small_tick_hit", (int)3.3);
			action("small_tick_miss", (int)3.5);
			break;
		case 2147.OsuMania:
			action("perfect", (int)3.4);
			action("great", (int)3.2);
			action("good", (int)3.5);
			action("ok", (int)3.1);
			action("meh", (int)3.3);
			break;
		default:
			action("great", (int)3.2);
			action("ok", (int)3.1);
			action("meh", (int)3.3);
			break;
		}
		action("miss", (int)3.6);
		return statistics;
	}

	// Token: 0x060031AE RID: 12718 RVA: 0x0012B1CC File Offset: 0x001293CC
	private static List<string> 8(2241 1)
	{
		List<string> list = new List<string>();
		if (1.9 != 2147.Osu || 1.14 <= 0 || 1.15 <= 0)
		{
			return list;
		}
		int 2 = 1.15;
		list.Add("\"great\":" + 2.ToString(CultureInfo.InvariantCulture));
		if (1.14 > 2)
		{
			list.Add("\"legacy_combo_increase\":" + (1.14 - 2).ToString(CultureInfo.InvariantCulture));
		}
		return list;
	}

	// Token: 0x060031AF RID: 12719 RVA: 0x0012B250 File Offset: 0x00129450
	private static string 9(2241 1)
	{
		if (!1.18)
		{
			return "F";
		}
		string result;
		try
		{
			2236 2 = 1.CalculateGrade();
			result = ((2 == 2236.N) ? null : 2.ToString());
		}
		catch (Exception)
		{
			result = null;
		}
		return result;
	}

	// Token: 0x0400249F RID: 9375
	public const int 1 = 30000001;

	// Token: 0x040024A0 RID: 9376
	private static readonly KeyValuePair<2023, string>[] 2 = new KeyValuePair<2023, string>[]
	{
		new KeyValuePair<2023, string>(2023.NoFail, "NF"),
		new KeyValuePair<2023, string>(2023.Easy, "EZ"),
		new KeyValuePair<2023, string>(2023.TouchDevice, "TD"),
		new KeyValuePair<2023, string>(2023.Hidden, "HD"),
		new KeyValuePair<2023, string>(2023.HardRock, "HR"),
		new KeyValuePair<2023, string>(2023.SuddenDeath, "SD"),
		new KeyValuePair<2023, string>(2023.DoubleTime, "DT"),
		new KeyValuePair<2023, string>(2023.Relax, "RX"),
		new KeyValuePair<2023, string>(2023.HalfTime, "HT"),
		new KeyValuePair<2023, string>(2023.Nightcore, "NC"),
		new KeyValuePair<2023, string>(2023.Flashlight, "FL"),
		new KeyValuePair<2023, string>(2023.Autoplay, "AT"),
		new KeyValuePair<2023, string>(2023.SpunOut, "SO"),
		new KeyValuePair<2023, string>(2023.Relax2, "AP"),
		new KeyValuePair<2023, string>(2023.Perfect, "PF"),
		new KeyValuePair<2023, string>(2023.Key1, "1K"),
		new KeyValuePair<2023, string>(2023.Key2, "2K"),
		new KeyValuePair<2023, string>(2023.Key3, "3K"),
		new KeyValuePair<2023, string>(2023.Key4, "4K"),
		new KeyValuePair<2023, string>(2023.Key5, "5K"),
		new KeyValuePair<2023, string>(2023.Key6, "6K"),
		new KeyValuePair<2023, string>(2023.Key7, "7K"),
		new KeyValuePair<2023, string>(2023.Key8, "8K"),
		new KeyValuePair<2023, string>(2023.Key9, "9K"),
		new KeyValuePair<2023, string>(2023.KeyCoop, "DS"),
		new KeyValuePair<2023, string>(2023.FadeIn, "FI"),
		new KeyValuePair<2023, string>(2023.Random, "RD"),
		new KeyValuePair<2023, string>(2023.Cinema, "CN"),
		new KeyValuePair<2023, string>(2023.Target, "TP"),
		new KeyValuePair<2023, string>(2023.ScoreV2, "SV2"),
		new KeyValuePair<2023, string>(2023.Mirror, "MR")
	};

	// Token: 0x040024A1 RID: 9377
	private static readonly KeyValuePair<1928, string>[] 3 = new KeyValuePair<1928, string>[]
	{
		new KeyValuePair<1928, string>(1928.CircleSize, "circle_size"),
		new KeyValuePair<1928, string>(1928.DrainRate, "drain_rate"),
		new KeyValuePair<1928, string>(1928.OverallDifficulty, "overall_difficulty"),
		new KeyValuePair<1928, string>(1928.ApproachRate, "approach_rate")
	};

	// Token: 0x040024A2 RID: 9378
	private const string 4 = "nekiosu_randomness";

	// Token: 0x040024A3 RID: 9379
	private const string 5 = "NRD";
}
