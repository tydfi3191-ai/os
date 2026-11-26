using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x020009C5 RID: 2501
internal static class 1585
{
	// Token: 0x060045FE RID: 17918 RVA: 0x001B791C File Offset: 0x001B5B1C
	internal static 109 1()
	{
		return new 109
		{
			1585.2("ping", "Check whether nekiosu is running"),
			1598.1(null),
			1598.1(new 2147?(2147.Taiko)),
			1598.1(new 2147?(2147.OsuMania)),
			1598.1(new 2147?(2147.CatchTheBeat)),
			1608.1(false),
			1608.1(true),
			1595.1(),
			1594.1(),
			1594.2(),
			1592.1(),
			1591.1(),
			1591.2(),
			1601.1()
		};
	}

	// Token: 0x060045FF RID: 17919 RVA: 0x001B79F0 File Offset: 0x001B5BF0
	internal static 217 2(string 1, string 2)
	{
		217 3 = new 217();
		3["name"] = 1;
		3["description"] = 2;
		3["type"] = 1;
		3["integration_types"] = new 109(new object[]
		{
			0,
			1
		});
		3["contexts"] = new 109(new object[]
		{
			0,
			1,
			2
		});
		return 3;
	}

	// Token: 0x06004600 RID: 17920 RVA: 0x001B7A90 File Offset: 0x001B5C90
	internal static 217 3(int 1, string 2, string 3)
	{
		217 4 = new 217();
		4["type"] = 1;
		4["name"] = 2;
		4["description"] = 3;
		return 4;
	}

	// Token: 0x06004601 RID: 17921 RVA: 0x001B7ACC File Offset: 0x001B5CCC
	internal static 217 4(bool 1 = true)
	{
		217 2 = 1585.3(3, "mode", "Specify a gamemode");
		109 3 = new 109();
		string[] array2;
		if (!1)
		{
			string[] array = new string[3];
			array[0] = "osu";
			array[1] = "taiko";
			array2 = array;
			array[2] = "ctb";
		}
		else
		{
			string[] array3 = new string[4];
			array3[0] = "osu";
			array3[1] = "taiko";
			array3[2] = "ctb";
			array2 = array3;
			array3[3] = "mania";
		}
		foreach (string text in array2)
		{
			109 4 = 3;
			217 5 = new 217();
			5["name"] = text;
			5["value"] = text;
			4.Add(5);
		}
		2["choices"] = 3;
		return 2;
	}

	// Token: 0x06004602 RID: 17922 RVA: 0x001B7B89 File Offset: 0x001B5D89
	internal static 2147 Mode(Dictionary<string, 226> 1)
	{
		return 1586.40(1585.Text(1, "mode"), 2147.Osu);
	}

	// Token: 0x06004603 RID: 17923 RVA: 0x001B7B9C File Offset: 0x001B5D9C
	internal static 217 5()
	{
		217 <<EMPTY_NAME>> = 1585.3(3, "grade", "Consider only scores with this grade");
		<<EMPTY_NAME>>["choices"] = new 109(new string[]
		{
			"SS",
			"S",
			"A",
			"B",
			"C",
			"D",
			"F"
		}.Select(delegate(string 1)
		{
			217 2 = new 217();
			2["name"] = 1;
			2["value"] = 1.ToLowerInvariant();
			return 2;
		}));
		return <<EMPTY_NAME>>;
	}

	// Token: 0x06004604 RID: 17924 RVA: 0x001B7C30 File Offset: 0x001B5E30
	internal static Dictionary<string, 226> Options(217 1)
	{
		Dictionary<string, 226> dictionary = new Dictionary<string, 226>(StringComparer.Ordinal);
		foreach (226 2 in ((1.SelectToken("data.options") as 109) ?? new 109()))
		{
			dictionary[(string)2["name"]] = 2["value"];
		}
		return dictionary;
	}

	// Token: 0x06004605 RID: 17925 RVA: 0x001B7CB8 File Offset: 0x001B5EB8
	internal static string Text(Dictionary<string, 226> 1, string 2)
	{
		226 3;
		if (!1.TryGetValue(2, out 3))
		{
			return null;
		}
		return (string)3;
	}

	// Token: 0x06004606 RID: 17926 RVA: 0x001B7CD8 File Offset: 0x001B5ED8
	internal static bool? 6(Dictionary<string, 226> 1, string 2)
	{
		226 3;
		if (!1.TryGetValue(2, out 3))
		{
			return null;
		}
		return (bool?)3;
	}

	// Token: 0x06004607 RID: 17927 RVA: 0x001B7D00 File Offset: 0x001B5F00
	internal static double? 7(Dictionary<string, 226> 1, string 2)
	{
		226 3;
		if (!1.TryGetValue(2, out 3))
		{
			return null;
		}
		return (double?)3;
	}

	// Token: 0x06004608 RID: 17928 RVA: 0x001B7D28 File Offset: 0x001B5F28
	internal static void 8(217 1)
	{
		int valueOrDefault = ((int?)1["type"]).GetValueOrDefault();
		if (valueOrDefault == 3 || valueOrDefault == 5)
		{
			string text = (string)1.SelectToken("data.custom_id");
			if (text != null && text.StartsWith("pg:", StringComparison.Ordinal))
			{
				1589.4(1, text);
				return;
			}
			if (text != null && text.StartsWith("eb:", StringComparison.Ordinal))
			{
				1601.15(1, text);
			}
			return;
		}
		else
		{
			if (valueOrDefault != 2)
			{
				return;
			}
			string text2 = (string)1.SelectToken("data.name");
			if (text2 != null)
			{
				switch (text2.Length)
				{
				case 2:
				{
					char c = text2[1];
					if (c != 'b')
					{
						if (c != 'c')
						{
							switch (c)
							{
							case 'l':
								if (!(text2 == "rl"))
								{
									return;
								}
								1591.4(1);
								return;
							case 'm':
								if (!(text2 == "rm"))
								{
									return;
								}
								1598.2(1, new 2147?(2147.OsuMania));
								return;
							case 'n':
							case 'o':
							case 'q':
							case 'r':
								break;
							case 'p':
								if (!(text2 == "pp"))
								{
									return;
								}
								1594.7(1);
								return;
							case 's':
								if (!(text2 == "rs"))
								{
									return;
								}
								1598.2(1, null);
								return;
							case 't':
								if (!(text2 == "rt"))
								{
									return;
								}
								1598.2(1, new 2147?(2147.Taiko));
								return;
							default:
								return;
							}
						}
						else
						{
							if (!(text2 == "rc"))
							{
								return;
							}
							1598.2(1, new 2147?(2147.CatchTheBeat));
							return;
						}
					}
					else
					{
						if (!(text2 == "rb"))
						{
							return;
						}
						1608.2(1, true);
						return;
					}
					break;
				}
				case 3:
					if (!(text2 == "top"))
					{
						return;
					}
					1608.2(1, false);
					return;
				case 4:
					if (!(text2 == "ping"))
					{
						return;
					}
					1584.11(1, 1585.9("nekiosu is running."));
					return;
				case 5:
				case 8:
				case 9:
					break;
				case 6:
					if (!(text2 == "whatif"))
					{
						return;
					}
					1594.9(1);
					return;
				case 7:
				{
					char c = text2[0];
					if (c != 'b')
					{
						if (c != 'n')
						{
							if (c != 'p')
							{
								return;
							}
							if (!(text2 == "profile"))
							{
								return;
							}
							1595.2(1);
							return;
						}
						else
						{
							if (!(text2 == "nochoke"))
							{
								return;
							}
							1592.2(1);
							return;
						}
					}
					else
					{
						if (!(text2 == "builder"))
						{
							return;
						}
						1601.2(1);
					}
					break;
				}
				case 10:
					if (!(text2 == "mostplayed"))
					{
						return;
					}
					1591.3(1);
					return;
				default:
					return;
				}
			}
			return;
		}
	}

	// Token: 0x06004609 RID: 17929 RVA: 0x001B7FCB File Offset: 0x001B61CB
	internal static 217 9(string 1)
	{
		217 2 = new 217();
		2["type"] = 4;
		string text = "data";
		217 3 = new 217();
		3["content"] = 1;
		2[text] = 3;
		return 2;
	}

	// Token: 0x0600460A RID: 17930 RVA: 0x001B8004 File Offset: 0x001B6204
	internal static 217 10(string 1)
	{
		217 2 = new 217();
		2["type"] = 4;
		string text = "data";
		217 3 = new 217();
		3["content"] = 1;
		3["flags"] = 64;
		2[text] = 3;
		return 2;
	}

	// Token: 0x0400333D RID: 13117
	private const int 1 = 2;

	// Token: 0x0400333E RID: 13118
	private const int 2 = 3;

	// Token: 0x0400333F RID: 13119
	private const int 3 = 5;

	// Token: 0x04003340 RID: 13120
	private const int 4 = 4;

	// Token: 0x04003341 RID: 13121
	private const int 5 = 64;
}
