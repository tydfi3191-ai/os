using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x020009FD RID: 2557
internal static class 1601
{
	// Token: 0x06004748 RID: 18248 RVA: 0x001C278C File Offset: 0x001C098C
	internal static 217 1()
	{
		217 <<EMPTY_NAME>> = 1585.2("builder", "Build your own score embed format");
		217 2 = <<EMPTY_NAME>>;
		string text = "options";
		object[] array = new object[2];
		int num = 0;
		217 3 = new 217();
		3["type"] = 1;
		3["name"] = "edit";
		3["description"] = "Edit your score embed format";
		array[num] = 3;
		int num2 = 1;
		217 4 = new 217();
		4["type"] = 1;
		4["name"] = "default";
		4["description"] = "Reset your score embed format to the default";
		array[num2] = 4;
		2[text] = new 109(array);
		return <<EMPTY_NAME>>;
	}

	// Token: 0x06004749 RID: 18249 RVA: 0x001C2848 File Offset: 0x001C0A48
	internal static void 2(217 1)
	{
		1601.<>c__DisplayClass9_0 CS$<>8__locals1 = new 1601.<>c__DisplayClass9_0();
		string a = (string)1.SelectToken("data.options[0].name");
		2228.2229 2 = 2228.Get(1586.ProfileName).FirstOrDefault<2228.2229>();
		if (2 == null)
		{
			1584.11(1, 1585.10("Play a map first: the preview shows your latest play."));
			return;
		}
		1604 3 = 1604.Current.Clone();
		if (a == "default")
		{
			3 = 1604.Default();
			1604.Save(3);
		}
		217 4 = new 217();
		4["type"] = 5;
		string text = "data";
		217 5 = new 217();
		5["flags"] = 64;
		4[text] = 5;
		1584.11(1, 4);
		1601.<>c__DisplayClass9_0 CS$<>8__locals2 = CS$<>8__locals1;
		1601.1603 6 = new 1601.1603();
		int num = ++1601.6;
		6.1 = num.ToString(CultureInfo.InvariantCulture);
		6.2 = 1;
		6.3 = new 1599.1600
		{
			1 = 2,
			2 = 1272.8(2.3)
		};
		6.4 = 3;
		6.9 = DateTime.UtcNow + 1601.4;
		CS$<>8__locals2.session = 6;
		1601.5[CS$<>8__locals1.session.1] = CS$<>8__locals1.session;
		1599.1(CS$<>8__locals1.session.3, delegate
		{
			1601.Show(CS$<>8__locals1.session);
		});
	}

	// Token: 0x0600474A RID: 18250 RVA: 0x001C299C File Offset: 0x001C0B9C
	internal static void 3()
	{
		if (1601.5.Count == 0)
		{
			return;
		}
		DateTime now = DateTime.UtcNow;
		IEnumerable<1601.1603> values = 1601.5.Values;
		Func<1601.1603, bool> <>9__0;
		Func<1601.1603, bool> predicate;
		if ((predicate = <>9__0) == null)
		{
			predicate = (<>9__0 = ((1601.1603 1) => now >= 1.9));
		}
		foreach (1601.1603 <<EMPTY_NAME>> in values.Where(predicate).ToList<1601.1603>())
		{
			1601.5.Remove(<<EMPTY_NAME>>.1);
			217 2 = <<EMPTY_NAME>>.2;
			217 3 = new 217();
			3["content"] = (<<EMPTY_NAME>>.8 ? "⚠️ Something went wrong while saving settings" : "Settings saved successfully ✅");
			3["components"] = new 109();
			1584.12(2, 3);
		}
	}

	// Token: 0x0600474B RID: 18251 RVA: 0x001C2A88 File Offset: 0x001C0C88
	private static void Show(1601.1603 1)
	{
		1604.1606? 2 = 1.6;
		int num;
		if (2 != null)
		{
			1604.1606 valueOrDefault = 2.GetValueOrDefault();
			num = 1601.4(1.4, valueOrDefault);
		}
		else
		{
			num = -1;
		}
		int num2 = num;
		217 3 = new 217();
		3["content"] = (1.8 ? "⚠️ Something went wrong while saving settings" : "Embed preview:");
		3["embeds"] = new 109(1599.3(1.3, 1.4, (num2 >= 0) ? num2 : -2));
		3["components"] = 1601.9(1);
		217 4 = 3;
		1584.12(1.2, 4);
	}

	// Token: 0x0600474C RID: 18252 RVA: 0x001C2B30 File Offset: 0x001C0D30
	private static int 4(1604 1, 1604.1606 2)
	{
		return 3.3.FindIndex((1604.1607 1) => 1.1 == 2);
	}

	// Token: 0x0600474D RID: 18253 RVA: 0x001C2B61 File Offset: 0x001C0D61
	private static string 5(1601.1603 1, string 2)
	{
		return "eb:" + 1.1 + ":" + 2;
	}

	// Token: 0x0600474E RID: 18254 RVA: 0x001C2B7C File Offset: 0x001C0D7C
	private static 217 6(params 217[] 1)
	{
		217 2 = new 217();
		2["type"] = 1;
		2["components"] = new 109(1);
		return 2;
	}

	// Token: 0x0600474F RID: 18255 RVA: 0x001C2BB4 File Offset: 0x001C0DB4
	private static 217 7(1601.1603 1, string 2, string 3, int 4, bool 5, string 6 = null)
	{
		217 7 = new 217();
		7["type"] = 2;
		7["style"] = 4;
		7["custom_id"] = 1601.5(1, 2);
		7["label"] = 3;
		7["disabled"] = 5;
		217 8 = 7;
		if (6 != null)
		{
			217 9 = 8;
			string text = "emoji";
			217 10 = new 217();
			10["name"] = 6;
			9[text] = 10;
		}
		return 8;
	}

	// Token: 0x06004750 RID: 18256 RVA: 0x001C2C4C File Offset: 0x001C0E4C
	private static 217 8(string 1, string 2, bool 3, string 4 = null)
	{
		217 5 = new 217();
		5["label"] = 1;
		5["value"] = 2;
		5["default"] = 3;
		217 6 = 5;
		if (4 != null)
		{
			6["description"] = 4;
		}
		return 6;
	}

	// Token: 0x06004751 RID: 18257 RVA: 0x001C2CA8 File Offset: 0x001C0EA8
	private static 217 Menu(1601.1603 1, string 2, string 3, bool 4, int 5, int 6, params 217[] 7)
	{
		217 8 = new 217();
		8["type"] = 3;
		8["custom_id"] = 1601.5(1, 2);
		8["options"] = new 109(7);
		8["disabled"] = 4;
		8["min_values"] = 5;
		8["max_values"] = 6;
		217 9 = 8;
		if (3 != null)
		{
			9["placeholder"] = 3;
		}
		return 9;
	}

	// Token: 0x06004752 RID: 18258 RVA: 0x001C2D44 File Offset: 0x001C0F44
	private static 109 9(1601.1603 1)
	{
		1604 2 = 10.4;
		109 3 = new 109
		{
			1601.6(new 217[]
			{
				1601.Menu(10, "section", "Choose an embed section", false, 1, 1, new 217[]
				{
					1601.8("Score data", "score_data", 10.5 == 1601.1602.ScoreData, null),
					1601.8("Image", "image", 10.5 == 1601.1602.Image, null),
					1601.8("Buttons", "buttons", 10.5 == 1601.1602.Buttons, null)
				})
			})
		};
		switch (10.5)
		{
		case 1601.1602.ScoreData:
			3.Add(1601.6(new 217[]
			{
				1601.Menu(10, "value", "Select a value to display", false, 1, 1, 1601.7.Select(delegate([TupleElementNames(new string[]
				{
					"Kind",
					"Label",
					"Value",
					"Description"
				})] ValueTuple<1604.1606?, string, string, string> 1)
				{
					string item = 1.Item2;
					string item2 = 1.Item3;
					bool flag;
					if (1.Item1 != null)
					{
						1604.1606? 11 = 10.6;
						1604.1606? item3 = 1.Item1;
						flag = (11.GetValueOrDefault() == item3.GetValueOrDefault() & 11 != null == (item3 != null));
					}
					else
					{
						flag = 10.7;
					}
					return 1601.8(item, item2, flag, 1.Item4);
				}).ToArray<217>())
			}));
			if (10.7)
			{
				3.Add(1601.6(new 217[]
				{
					1601.7(10, "show_artist", "Show", 1, 2.4, null),
					1601.7(10, "hide_artist", "Hide", 1, !2.4, null),
					1601.7(10, "reset", "Reset all", 4, false, null)
				}));
			}
			else
			{
				1604.1606? 4 = 10.6;
				if (4 != null)
				{
					1604.1606 valueOrDefault = 4.GetValueOrDefault();
					int num = 1601.4(2, valueOrDefault);
					1604.1607 5 = (num >= 0) ? 2.3[num] : null;
					if (valueOrDefault == 1604.1606.Stars)
					{
						3.Add(1601.6(new 217[]
						{
							1601.7(10, "show_sr_title", "Show in title", 2, 2.5, null),
							1601.7(10, "hide_sr_title", "Hide in title", 2, !2.5, null),
							1601.7(10, "show", "Show as value", 1, num >= 0, null),
							1601.7(10, "hide", "Hide value", 1, num < 0 || 1601.14(2, num), null),
							1601.7(10, "reset", "Reset all", 4, false, null)
						}));
					}
					else
					{
						3.Add(1601.6(new 217[]
						{
							1601.7(10, "show", "Show", 1, num >= 0, null),
							1601.7(10, "hide", "Hide", 1, num < 0 || 1601.14(2, num), null),
							1601.7(10, "reset", "Reset all", 4, false, null)
						}));
					}
					switch (valueOrDefault)
					{
					case 1604.1606.Pp:
					{
						1604.1607 6 = 5 ?? new 1604.1607();
						3.Add(1601.6(new 217[]
						{
							1601.Menu(10, "pp", "Only show score pp", 5 == null, 1, 1, new 217[]
							{
								1601.8("Only show score pp", "score", !6.3 && !6.4, null),
								1601.8("Show score pp & max pp", "max", 6.3 && !6.4, null),
								1601.8("Show score pp & if-FC pp", "if_fc", 6.4 && !6.3 && !6.5, "Only shows score pp on FC"),
								1601.8("Show score pp & max pp OR if-FC pp", "either", 6.4 && 6.5 && !6.3, "Shows max pp on FC, otherwise if-FC pp"),
								1601.8("Show score pp, max pp & if-FC pp", "all", 6.3 && 6.4, null)
							})
						}));
						break;
					}
					case 1604.1606.Combo:
						3.Add(1601.6(new 217[]
						{
							1601.Menu(10, "combo", "Only show score combo", 5 == null, 0, 1, new 217[]
							{
								1601.8("Show max combo", "max", (5 ?? new 1604.1607()).6, null)
							})
						}));
						break;
					case 1604.1606.Hitresults:
						3.Add(1601.6(new 217[]
						{
							1601.7(10, "hitresults_full", "Full", 1, 5 == null || 5.7, null),
							1601.7(10, "hitresults_misses", "Only misses", 1, 5 == null || !5.7, null)
						}));
						break;
					default:
						if (valueOrDefault - 1604.1606.Bpm > 3)
						{
							if (valueOrDefault == 1604.1606.Mapper)
							{
								3.Add(1601.6(new 217[]
								{
									1601.Menu(10, "mapper", "Hide mapset status", 5 == null, 0, 1, new 217[]
									{
										1601.8("Include mapset status", "status", (5 ?? new 1604.1607()).9, "Note: Won't show on ranked maps if `Map ranked date` enabled")
									})
								}));
							}
						}
						else
						{
							217 7 = 1601.7(10, "emote", "Emote", 1, 5 == null || !5.8, null);
							string text = (valueOrDefault == 1604.1606.CountSliders) ? "count_sliders" : ((valueOrDefault == 1604.1606.CountObjects) ? "count_objects" : ((valueOrDefault == 1604.1606.CountSpinners) ? "count_spinners" : "bpm"));
							string text2 = 1586.10(text);
							if (text2 != null)
							{
								217 8 = 7;
								string text3 = "emoji";
								217 9 = new 217();
								9["id"] = text2;
								9["name"] = text;
								8[text3] = 9;
							}
							3.Add(1601.6(new 217[]
							{
								7,
								1601.7(10, "text", "Text", 1, 5 == null || 5.8, null)
							}));
						}
						break;
					}
					3.Add(1601.10(10, num));
				}
			}
			break;
		case 1601.1602.Image:
			3.Add(1601.6(new 217[]
			{
				1601.Menu(10, "image", null, false, 1, 1, new 217[]
				{
					1601.8("Thumbnail", "thumbnail", 2.6 == 1604.1605.Thumbnail, null),
					1601.8("Image", "image", 2.6 == 1604.1605.Image, null),
					1601.8("Hide", "hide", 2.6 == 1604.1605.Hide, null)
				})
			}));
			break;
		case 1601.1602.Buttons:
			3.Add(1601.6(new 217[]
			{
				1601.Menu(10, "buttons", "Hide buttons", false, 0, 1, new 217[]
				{
					1601.8("Pagination", "pagination", 2.7, null)
				})
			}));
			break;
		}
		return 3;
	}

	// Token: 0x06004753 RID: 18259 RVA: 0x001C34BC File Offset: 0x001C16BC
	private static 217 10(1601.1603 1, int 2)
	{
		List<1604.1607> list = 1.4.3;
		bool flag = true;
		bool flag2 = true;
		bool flag3 = true;
		bool flag4 = true;
		if (2 >= 0)
		{
			byte b = list[2].2;
			flag = (1601.11(list, 2) == 0);
			flag2 = (b == 0 || (2 == 1 && 1601.13(list, 0) >= 10));
			flag3 = (list.Count == 1 || b == byte.MaxValue);
			flag4 = (1601.12(list, 2) == 0);
		}
		return 1601.6(new 217[]
		{
			1601.7(1, "left", "Left", 3, flag, "◀️"),
			1601.7(1, "up", "Up", 3, flag2, "\ud83d\udd3c"),
			1601.7(1, "down", "Down", 3, flag3, "\ud83d\udd3d"),
			1601.7(1, "right", "Right", 3, flag4, "▶️")
		});
	}

	// Token: 0x06004754 RID: 18260 RVA: 0x001C35B0 File Offset: 0x001C17B0
	private static int 11(List<1604.1607> 1, int 2)
	{
		int num = 0;
		int num2 = 2 - 1;
		while (num2 >= 0 && 1[num2].2 == 1[2].2)
		{
			num++;
			num2--;
		}
		return num;
	}

	// Token: 0x06004755 RID: 18261 RVA: 0x001C35EC File Offset: 0x001C17EC
	private static int 12(List<1604.1607> 1, int 2)
	{
		int num = 0;
		int num2 = 2 + 1;
		while (num2 < 1.Count && 1[num2].2 == 1[2].2)
		{
			num++;
			num2++;
		}
		return num;
	}

	// Token: 0x06004756 RID: 18262 RVA: 0x001C3630 File Offset: 0x001C1830
	private static int 13(List<1604.1607> 1, int 2)
	{
		return 3.Count((1604.1607 1) => (int)1.2 == 2);
	}

	// Token: 0x06004757 RID: 18263 RVA: 0x001C365C File Offset: 0x001C185C
	private static bool 14(1604 1, int 2)
	{
		return 2 < 0 || 2 >= 1.3.Count || (1.3[2].2 == 0 && (1.3.Count < 2 || 1.3[1].2 > 0));
	}

	// Token: 0x06004758 RID: 18264 RVA: 0x001C36B8 File Offset: 0x001C18B8
	internal static void 15(217 1, string 2)
	{
		string[] array = 2.Split(new char[]
		{
			':'
		});
		217 3 = new 217();
		3["type"] = 6;
		1584.11(6, 3);
		1601.1603 4;
		if (array.Length != 3 || !1601.5.TryGetValue(array[1], out 4))
		{
			return;
		}
		109 5 = (6.SelectToken("data.values") as 109) ?? new 109();
		string text = (5.Count > 0) ? ((string)5[0]) : null;
		List<1604.1607> list = (from 1 in 4.4.3
		select 1.Clone()).ToList<1604.1607>();
		if (!1601.Apply(4, array[2], text, (from 1 in 5
		select (string)1).ToList<string>()))
		{
			4.4.3 = list;
		}
		else
		{
			bool flag = true;
			int num = 1;
			while (num < 4.4.3.Count && flag)
			{
				flag = (4.4.3[num - 1].2 <= 4.4.3[num].2);
				num++;
			}
			if (!flag)
			{
				4.4.3 = list;
			}
			else
			{
				1604.Save(4.4);
				4.8 = false;
			}
		}
		4.9 = DateTime.UtcNow + 1601.4;
		1601.Show(4);
	}

	// Token: 0x06004759 RID: 18265 RVA: 0x001C385C File Offset: 0x001C1A5C
	private static bool Apply(1601.1603 1, string 2, string 3, List<string> 4)
	{
		1604 5 = 10.4;
		List<1604.1607> list = 5.3;
		1604.1606? 6 = 10.6;
		int num;
		if (6 != null)
		{
			1604.1606 valueOrDefault = 6.GetValueOrDefault();
			num = 1601.4(5, valueOrDefault);
		}
		else
		{
			num = -1;
		}
		int num2 = num;
		1604.1607 7 = (num2 >= 0) ? list[num2] : null;
		if (2 != null)
		{
			switch (2.Length)
			{
			case 2:
			{
				char c = 2[0];
				if (c != 'p')
				{
					if (c != 'u')
					{
						return false;
					}
					if (!(2 == "up"))
					{
						return false;
					}
					return num2 >= 0 && 1601.17(list, num2);
				}
				else
				{
					if (!(2 == "pp"))
					{
						return false;
					}
					if (7 == null)
					{
						return false;
					}
					7.3 = (3 == "max" || 3 == "all");
					7.4 = (3 == "if_fc" || 3 == "either" || 3 == "all");
					7.5 = (3 == "either");
					return true;
				}
				break;
			}
			case 3:
			case 8:
			case 9:
			case 10:
			case 12:
			case 14:
			case 16:
				return false;
			case 4:
			{
				char c = 2[0];
				if (c <= 'h')
				{
					if (c != 'd')
					{
						if (c != 'h')
						{
							return false;
						}
						if (!(2 == "hide"))
						{
							return false;
						}
						if (num2 < 0 || 1601.14(5, num2))
						{
							return false;
						}
						byte b = list[num2].2;
						if (1601.11(list, num2) == 0 && num2 + 1 < list.Count && list[num2 + 1].2 != b)
						{
							int num3 = num2 + 1;
							while (num3 < list.Count && list[num3].2 != 255)
							{
								1604.1607 8 = list[num3];
								8.2 -= 1;
								num3++;
							}
						}
						list.RemoveAt(num2);
						return true;
					}
					else
					{
						if (!(2 == "down"))
						{
							return false;
						}
						return num2 >= 0 && 1601.18(list, num2);
					}
				}
				else if (c != 'l')
				{
					if (c != 's')
					{
						if (c != 't')
						{
							return false;
						}
						if (!(2 == "text"))
						{
							return false;
						}
						goto IL_669;
					}
					else
					{
						if (!(2 == "show"))
						{
							return false;
						}
						if (num2 < 0)
						{
							6 = 10.6;
							if (6 != null)
							{
								1604.1606 valueOrDefault2 = 6.GetValueOrDefault();
								int num4 = list.FindLastIndex((1604.1607 1) => 1.2 < byte.MaxValue);
								if (num4 < 0)
								{
									return false;
								}
								list.Insert(num4 + 1, new 1604.1607
								{
									1 = valueOrDefault2,
									2 = list[num4].2 + 1
								});
								return true;
							}
						}
						return false;
					}
				}
				else
				{
					if (!(2 == "left"))
					{
						return false;
					}
					if (num2 < 1 || 1601.11(list, num2) == 0)
					{
						return false;
					}
					1601.16(list, num2 - 1, num2);
					return true;
				}
				break;
			}
			case 5:
			{
				char c = 2[2];
				if (c <= 'g')
				{
					if (c != 'a')
					{
						if (c != 'g')
						{
							return false;
						}
						if (!(2 == "right"))
						{
							return false;
						}
						if (num2 < 0 || 1601.12(list, num2) == 0)
						{
							return false;
						}
						1601.16(list, num2, num2 + 1);
						return true;
					}
					else
					{
						if (!(2 == "image"))
						{
							return false;
						}
						5.6 = ((3 == "image") ? 1604.1605.Image : ((3 == "hide") ? 1604.1605.Hide : 1604.1605.Thumbnail));
						return true;
					}
				}
				else
				{
					switch (c)
					{
					case 'l':
						if (!(2 == "value"))
						{
							return false;
						}
						foreach (ValueTuple<1604.1606?, string, string, string> valueTuple in 1601.7)
						{
							if (valueTuple.Item3 == 3)
							{
								10.7 = (valueTuple.Item1 == null);
								10.6 = valueTuple.Item1;
							}
						}
						return true;
					case 'm':
						if (!(2 == "combo"))
						{
							return false;
						}
						if (7 == null)
						{
							return false;
						}
						7.6 = 4.Contains("max");
						return true;
					case 'n':
						return false;
					case 'o':
						if (!(2 == "emote"))
						{
							return false;
						}
						goto IL_669;
					default:
					{
						if (c != 's')
						{
							return false;
						}
						if (!(2 == "reset"))
						{
							return false;
						}
						1604 9 = 1604.Default();
						5.3 = 9.3;
						5.4 = 9.4;
						5.5 = 9.5;
						return true;
					}
					}
				}
				break;
			}
			case 6:
				if (!(2 == "mapper"))
				{
					return false;
				}
				if (7 == null)
				{
					return false;
				}
				7.9 = 4.Contains("status");
				return true;
			case 7:
			{
				char c = 2[0];
				if (c != 'b')
				{
					if (c != 's')
					{
						return false;
					}
					if (!(2 == "section"))
					{
						return false;
					}
					10.5 = ((3 == "score_data") ? 1601.1602.ScoreData : ((3 == "image") ? 1601.1602.Image : ((3 == "buttons") ? 1601.1602.Buttons : 10.5)));
					return true;
				}
				else
				{
					if (!(2 == "buttons"))
					{
						return false;
					}
					5.7 = 4.Contains("pagination");
					return true;
				}
				break;
			}
			case 11:
			{
				char c = 2[0];
				if (c != 'h')
				{
					if (c != 's')
					{
						return false;
					}
					if (!(2 == "show_artist"))
					{
						return false;
					}
					5.4 = true;
					return true;
				}
				else
				{
					if (!(2 == "hide_artist"))
					{
						return false;
					}
					5.4 = false;
					return true;
				}
				break;
			}
			case 13:
			{
				char c = 2[0];
				if (c != 'h')
				{
					if (c != 's')
					{
						return false;
					}
					if (!(2 == "show_sr_title"))
					{
						return false;
					}
					5.5 = true;
					return true;
				}
				else
				{
					if (!(2 == "hide_sr_title"))
					{
						return false;
					}
					5.5 = false;
					return true;
				}
				break;
			}
			case 15:
				if (!(2 == "hitresults_full"))
				{
					return false;
				}
				break;
			case 17:
				if (!(2 == "hitresults_misses"))
				{
					return false;
				}
				break;
			default:
				return false;
			}
			if (7 == null)
			{
				return false;
			}
			7.7 = (2 == "hitresults_full");
			return true;
			IL_669:
			if (7 == null)
			{
				return false;
			}
			7.8 = (2 == "text");
			return true;
		}
		return false;
	}

	// Token: 0x0600475A RID: 18266 RVA: 0x001C3F44 File Offset: 0x001C2144
	private static void 16(List<1604.1607> 1, int 2, int 3)
	{
		1604.1607 value = 1[2];
		1[2] = 1[3];
		1[3] = value;
	}

	// Token: 0x0600475B RID: 18267 RVA: 0x001C3F70 File Offset: 0x001C2170
	private static bool 17(List<1604.1607> 1, int 2)
	{
		if (1[2].2 == 0)
		{
			return false;
		}
		byte b = 1[2].2;
		int num = 1601.11(1, 2);
		int? num2 = null;
		int num3 = 0;
		for (int i = 2 - 1; i >= 0; i--)
		{
			1604.1607 3 = 1[i];
			if (3.2 != b)
			{
				if (b == 255)
				{
					num2 = new int?((int)3.2);
					break;
				}
				if (num2 != null)
				{
					if (num2.Value != (int)3.2)
					{
						break;
					}
					num3++;
				}
				else
				{
					num2 = new int?((int)3.2);
					num3++;
				}
			}
		}
		int num4 = 1601.12(1, 2);
		if (1[2].2 == 255)
		{
			1[2].2 = (byte)(num2.GetValueOrDefault() + 1);
		}
		else
		{
			1604.1607 4 = 1[2];
			4.2 -= 1;
		}
		if (num == 0 && num4 == 0)
		{
			int num5 = 2 + 1;
			while (num5 < 1.Count && 1[num5].2 != 255)
			{
				1604.1607 5 = 1[num5];
				5.2 -= 1;
				num5++;
			}
		}
		int num6 = (num3 <= num) ? num : num3;
		if (2 - num6 < 0)
		{
			return false;
		}
		1604.1607 item = 1[2];
		1.RemoveAt(2);
		1.Insert(2 - num6, item);
		return true;
	}

	// Token: 0x0600475C RID: 18268 RVA: 0x001C40DC File Offset: 0x001C22DC
	private static bool 18(List<1604.1607> 1, int 2)
	{
		byte b = 5[2].2;
		if (b == 255 || 5.Count == 1)
		{
			return false;
		}
		int num = 1601.11(5, 2);
		int num2 = 1601.12(5, 2);
		int num3 = 1601.13(5, (int)(b + 1));
		if (num == 0 && num2 == 0)
		{
			if (b == 0 && num3 == 0)
			{
				for (int i = 2 + 1; i < 5.Count; i++)
				{
					5[i].2 = 0;
				}
			}
			else
			{
				int num4 = 2 + 1;
				while (num4 < 5.Count && 5[num4].2 != 255)
				{
					1604.1607 3 = 5[num4];
					3.2 -= 1;
					num4++;
				}
				if (num3 == 0)
				{
					5[2].2 = byte.MaxValue;
				}
			}
		}
		else
		{
			1604.1607 4 = 5[2];
			4.2 += 1;
		}
		int num5;
		if (num3 <= 0)
		{
			if (num <= 0 && num2 <= 0)
			{
				num5 = 5.AsEnumerable<1604.1607>().Reverse<1604.1607>().TakeWhile((1604.1607 1) => 1.2 == byte.MaxValue).Count<1604.1607>();
			}
			else
			{
				num5 = 0;
			}
		}
		else
		{
			num5 = num3;
		}
		int val = num5;
		int num6 = 1 + num2 + Math.Min(val, num);
		if (2 + num6 > 5.Count)
		{
			return false;
		}
		1604.1607 item = 5[2];
		5.RemoveAt(2);
		5.Insert(2 + num6 - 1, item);
		return true;
	}

	// Token: 0x04003430 RID: 13360
	private const int 1 = 5;

	// Token: 0x04003431 RID: 13361
	private const int 2 = 6;

	// Token: 0x04003432 RID: 13362
	private const int 3 = 64;

	// Token: 0x04003433 RID: 13363
	private static readonly TimeSpan 4 = TimeSpan.FromSeconds(60.0);

	// Token: 0x04003434 RID: 13364
	private static readonly Dictionary<string, 1601.1603> 5 = new Dictionary<string, 1601.1603>(StringComparer.Ordinal);

	// Token: 0x04003435 RID: 13365
	private static int 6;

	// Token: 0x04003436 RID: 13366
	[TupleElementNames(new string[]
	{
		"Kind",
		"Label",
		"Value",
		"Description"
	})]
	private static readonly ValueTuple<1604.1606?, string, string, string>[] 7 = new ValueTuple<1604.1606?, string, string, string>[]
	{
		new ValueTuple<1604.1606?, string, string, string>(null, "Artist", "artist", null),
		new ValueTuple<1604.1606?, string, string, string>(new 1604.1606?(1604.1606.Grade), "Grade", "grade", null),
		new ValueTuple<1604.1606?, string, string, string>(new 1604.1606?(1604.1606.Mods), "Mods", "mods", null),
		new ValueTuple<1604.1606?, string, string, string>(new 1604.1606?(1604.1606.Score), "Score", "score", null),
		new ValueTuple<1604.1606?, string, string, string>(new 1604.1606?(1604.1606.Accuracy), "Accuracy", "acc", null),
		new ValueTuple<1604.1606?, string, string, string>(new 1604.1606?(1604.1606.ScoreDate), "Score date", "score_date", null),
		new ValueTuple<1604.1606?, string, string, string>(new 1604.1606?(1604.1606.Pp), "PP", "pp", null),
		new ValueTuple<1604.1606?, string, string, string>(new 1604.1606?(1604.1606.Combo), "Combo", "combo", null),
		new ValueTuple<1604.1606?, string, string, string>(new 1604.1606?(1604.1606.Hitresults), "Hitresults", "hitresults", null),
		new ValueTuple<1604.1606?, string, string, string>(new 1604.1606?(1604.1606.Ratio), "Ratio", "ratio", "Note: This value only shows for mania scores"),
		new ValueTuple<1604.1606?, string, string, string>(new 1604.1606?(1604.1606.Stars), "Stars", "sr", null),
		new ValueTuple<1604.1606?, string, string, string>(new 1604.1606?(1604.1606.Length), "Length", "len", null),
		new ValueTuple<1604.1606?, string, string, string>(new 1604.1606?(1604.1606.Ar), "AR", "ar", null),
		new ValueTuple<1604.1606?, string, string, string>(new 1604.1606?(1604.1606.Cs), "CS", "cs", null),
		new ValueTuple<1604.1606?, string, string, string>(new 1604.1606?(1604.1606.Hp), "HP", "hp", null),
		new ValueTuple<1604.1606?, string, string, string>(new 1604.1606?(1604.1606.Od), "OD", "od", null),
		new ValueTuple<1604.1606?, string, string, string>(new 1604.1606?(1604.1606.Bpm), "BPM", "bpm", null),
		new ValueTuple<1604.1606?, string, string, string>(new 1604.1606?(1604.1606.CountObjects), "Count objects", "n_objects", null),
		new ValueTuple<1604.1606?, string, string, string>(new 1604.1606?(1604.1606.CountSliders), "Count sliders", "n_sliders", null),
		new ValueTuple<1604.1606?, string, string, string>(new 1604.1606?(1604.1606.CountSpinners), "Count spinners", "n_spinners", null),
		new ValueTuple<1604.1606?, string, string, string>(new 1604.1606?(1604.1606.MapRankedDate), "Map ranked date", "ranked_date", "Note: This value only shows on ranked maps"),
		new ValueTuple<1604.1606?, string, string, string>(new 1604.1606?(1604.1606.Mapper), "Mapper", "mapper", null)
	};

	// Token: 0x020009FE RID: 2558
	private enum 1602
	{
		// Token: 0x04003438 RID: 13368
		None,
		// Token: 0x04003439 RID: 13369
		ScoreData,
		// Token: 0x0400343A RID: 13370
		Image,
		// Token: 0x0400343B RID: 13371
		Buttons
	}

	// Token: 0x020009FF RID: 2559
	private sealed class 1603
	{
		// Token: 0x0400343C RID: 13372
		public string 1;

		// Token: 0x0400343D RID: 13373
		public 217 2;

		// Token: 0x0400343E RID: 13374
		public 1599.1600 3;

		// Token: 0x0400343F RID: 13375
		public 1604 4;

		// Token: 0x04003440 RID: 13376
		public 1601.1602 5;

		// Token: 0x04003441 RID: 13377
		public 1604.1606? 6;

		// Token: 0x04003442 RID: 13378
		public bool 7;

		// Token: 0x04003443 RID: 13379
		public bool 8;

		// Token: 0x04003444 RID: 13380
		public DateTime 9;
	}
}
