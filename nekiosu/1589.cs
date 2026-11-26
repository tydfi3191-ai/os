using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x020009D1 RID: 2513
internal static class 1589
{
	// Token: 0x0600466A RID: 18026 RVA: 0x001BA714 File Offset: 0x001B8914
	internal static 1589.1590 Start(217 1, int 2, int 3, int 4, Action<1589.1590, 217> 5, Action<1589.1590, string> 6 = null, bool 7 = false)
	{
		1589.1590 8 = new 1589.1590();
		int num = ++1589.6;
		8.1 = num.ToString(CultureInfo.InvariantCulture);
		8.2 = 1;
		8.4 = 2;
		8.5 = Math.Max(1, 3);
		8.6 = 5;
		8.7 = 6;
		8.8 = DateTime.UtcNow + 1589.4;
		1589.1590 9 = 8;
		9.3 = Math.Min(9.LastIndex, Math.Max(0, 4 / 9.5 * 9.5));
		1589.5[9.1] = 9;
		if (!7)
		{
			217 10 = new 217();
			10["type"] = 5;
			1584.11(1, 10);
		}
		5(9, 1);
		return 9;
	}

	// Token: 0x0600466B RID: 18027 RVA: 0x001BA7E8 File Offset: 0x001B89E8
	internal static void Edit(1589.1590 1, 217 2, 217 3, string 4 = null, byte[] 5 = null)
	{
		109 6 = 3["components"] as 109;
		1.9 = (6 != null && 6.Count > 0);
		if (!1.9)
		{
			1589.5.Remove(1.1);
		}
		1584.13(2, 3, 4, 5);
	}

	// Token: 0x0600466C RID: 18028 RVA: 0x001BA840 File Offset: 0x001B8A40
	internal static 109 Buttons(1589.1590 1)
	{
		109 2 = new 109();
		if (1.4 <= 1.5)
		{
			return 2;
		}
		bool flag = 1.3 == 0;
		bool flag2 = 1.3 >= 1.LastIndex;
		109 3 = 2;
		217 4 = new 217();
		4["type"] = 1;
		4["components"] = new 109(new object[]
		{
			1589.1(1, "start", "start", flag),
			1589.1(1, "back", "single_step_back", flag),
			1589.1(1, "custom", "my_position", false),
			1589.1(1, "step", "single_step", flag2),
			1589.1(1, "end", "end", flag2)
		});
		3.Add(4);
		return 2;
	}

	// Token: 0x0600466D RID: 18029 RVA: 0x001BA918 File Offset: 0x001B8B18
	internal static 217 Menu(1589.1590 1, [TupleElementNames(new string[]
	{
		"Value",
		"Label",
		"Description"
	})] IEnumerable<ValueTuple<string, string, string>> 2, string 3)
	{
		217 4 = new 217();
		4["type"] = 1;
		string text = "components";
		217 5 = new 217();
		5["type"] = 3;
		5["custom_id"] = "pg:" + 6.1 + ":menu";
		5["options"] = new 109(2.Select(delegate([TupleElementNames(new string[]
		{
			"Value",
			"Label",
			"Description"
		})] ValueTuple<string, string, string> 1)
		{
			217 7 = new 217();
			7["label"] = 1.Item2;
			7["value"] = 1.Item1;
			7["description"] = 1.Item3;
			7["default"] = (1.Item1 == 3);
			return 7;
		}));
		4[text] = new 109(5);
		return 4;
	}

	// Token: 0x0600466E RID: 18030 RVA: 0x001BA9B8 File Offset: 0x001B8BB8
	private static 217 1(1589.1590 1, string 2, string 3, bool 4)
	{
		217 5 = new 217();
		5["type"] = 2;
		5["style"] = 2;
		5["custom_id"] = "pg:" + 1.1 + ":" + 2;
		5["disabled"] = 4;
		217 6 = 5;
		string text = 1586.10(3);
		if (text != null)
		{
			217 7 = 6;
			string text2 = "emoji";
			217 8 = new 217();
			8["id"] = text;
			8["name"] = 3;
			7[text2] = 8;
		}
		else
		{
			6["label"] = 2;
		}
		return 6;
	}

	// Token: 0x0600466F RID: 18031 RVA: 0x001BAA74 File Offset: 0x001B8C74
	internal static void 2()
	{
		if (1589.5.Count == 0)
		{
			return;
		}
		DateTime now = DateTime.UtcNow;
		IEnumerable<1589.1590> values = 1589.5.Values;
		Func<1589.1590, bool> <>9__0;
		Func<1589.1590, bool> predicate;
		if ((predicate = <>9__0) == null)
		{
			predicate = (<>9__0 = ((1589.1590 1) => now >= 1.8));
		}
		foreach (1589.1590 <<EMPTY_NAME>> in values.Where(predicate).ToList<1589.1590>())
		{
			1589.5.Remove(<<EMPTY_NAME>>.1);
			if (<<EMPTY_NAME>>.9)
			{
				217 2 = <<EMPTY_NAME>>.2;
				217 3 = new 217();
				3["components"] = new 109();
				1584.12(2, 3);
			}
		}
	}

	// Token: 0x06004670 RID: 18032 RVA: 0x001BAB44 File Offset: 0x001B8D44
	internal static void 3(217 1)
	{
		217 2 = new 217();
		2["type"] = 5;
		1584.11(1, 2);
	}

	// Token: 0x06004671 RID: 18033 RVA: 0x001BAB64 File Offset: 0x001B8D64
	internal static void 4(217 1, string 2)
	{
		string[] array = 2.Split(new char[]
		{
			':'
		});
		1589.1590 3;
		if (array.Length != 3 || !1589.5.TryGetValue(array[1], out 3))
		{
			217 4 = new 217();
			4["type"] = 6;
			1584.11(1, 4);
			return;
		}
		string text = array[2];
		if (text != null)
		{
			switch (text.Length)
			{
			case 3:
				if (!(text == "end"))
				{
					return;
				}
				3.3 = 3.LastIndex;
				break;
			case 4:
			{
				char c = text[0];
				if (c <= 'm')
				{
					if (c != 'b')
					{
						if (c != 'm')
						{
							return;
						}
						if (!(text == "menu"))
						{
							return;
						}
						string text2 = (string)1.SelectToken("data.values[0]");
						if (3.7 == null || text2 == null)
						{
							217 5 = new 217();
							5["type"] = 6;
							1584.11(1, 5);
							return;
						}
						3.7(3, text2);
					}
					else
					{
						if (!(text == "back"))
						{
							return;
						}
						3.3 = Math.Max(0, 3.3 - 3.5);
					}
				}
				else if (c != 'p')
				{
					if (c != 's')
					{
						return;
					}
					if (!(text == "step"))
					{
						return;
					}
					3.3 = Math.Min(3.LastIndex, 3.3 + 3.5);
				}
				else
				{
					if (!(text == "page"))
					{
						return;
					}
					string text3 = (string)1.SelectToken("data.components[0].components[0].value");
					int num;
					if (!int.TryParse((text3 != null) ? text3.Trim() : null, NumberStyles.None, CultureInfo.InvariantCulture, out num) || num < 1 || num > 3.LastPage)
					{
						217 6 = new 217();
						6["type"] = 6;
						1584.11(1, 6);
						return;
					}
					3.3 = (num - 1) * 3.5;
				}
				break;
			}
			case 5:
				if (!(text == "start"))
				{
					return;
				}
				3.3 = 0;
				break;
			case 6:
				if (!(text == "custom"))
				{
					return;
				}
				1584.11(1, 1589.5(3));
				return;
			default:
				return;
			}
			3.8 = DateTime.UtcNow + 1589.4;
			217 7 = new 217();
			7["type"] = 6;
			1584.11(1, 7);
			3.6(3, 1);
			return;
		}
	}

	// Token: 0x06004672 RID: 18034 RVA: 0x001BADD8 File Offset: 0x001B8FD8
	private static 217 5(1589.1590 1)
	{
		217 2 = new 217();
		2["type"] = 9;
		string text = "data";
		217 3 = new 217();
		3["custom_id"] = "pg:" + 1.1 + ":page";
		3["title"] = "Jump to a page";
		string text2 = "components";
		217 4 = new 217();
		4["type"] = 1;
		string text3 = "components";
		217 5 = new 217();
		5["type"] = 4;
		5["custom_id"] = "page_input";
		5["label"] = "Page number";
		5["style"] = 1;
		5["min_length"] = 1;
		5["max_length"] = 5;
		5["placeholder"] = "Number between 1 and " + 1.LastPage.ToString();
		5["required"] = true;
		4[text3] = new 109(5);
		3[text2] = new 109(4);
		2[text] = 3;
		return 2;
	}

	// Token: 0x04003369 RID: 13161
	private const int 1 = 5;

	// Token: 0x0400336A RID: 13162
	private const int 2 = 6;

	// Token: 0x0400336B RID: 13163
	private const int 3 = 9;

	// Token: 0x0400336C RID: 13164
	private static readonly TimeSpan 4 = TimeSpan.FromSeconds(60.0);

	// Token: 0x0400336D RID: 13165
	private static readonly Dictionary<string, 1589.1590> 5 = new Dictionary<string, 1589.1590>(StringComparer.Ordinal);

	// Token: 0x0400336E RID: 13166
	private static int 6;

	// Token: 0x020009D2 RID: 2514
	internal sealed class 1590
	{
		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06004674 RID: 18036 RVA: 0x001BAF4C File Offset: 0x001B914C
		public int Page
		{
			get
			{
				return this.3 / this.5 + 1;
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06004675 RID: 18037 RVA: 0x001BAF5D File Offset: 0x001B915D
		public int LastPage
		{
			get
			{
				return Math.Max(1, (this.4 + this.5 - 1) / this.5);
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06004676 RID: 18038 RVA: 0x001BAF7B File Offset: 0x001B917B
		public int LastIndex
		{
			get
			{
				return (this.LastPage - 1) * this.5;
			}
		}

		// Token: 0x0400336F RID: 13167
		public string 1;

		// Token: 0x04003370 RID: 13168
		public 217 2;

		// Token: 0x04003371 RID: 13169
		public int 3;

		// Token: 0x04003372 RID: 13170
		public int 4;

		// Token: 0x04003373 RID: 13171
		public int 5 = 1;

		// Token: 0x04003374 RID: 13172
		public Action<1589.1590, 217> 6;

		// Token: 0x04003375 RID: 13173
		public Action<1589.1590, string> 7;

		// Token: 0x04003376 RID: 13174
		public DateTime 8;

		// Token: 0x04003377 RID: 13175
		public bool 9;
	}
}
