using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

// Token: 0x0200092B RID: 2347
internal sealed class 1707 : 1689
{
	// Token: 0x170002DA RID: 730
	// (get) Token: 0x060042A7 RID: 17063 RVA: 0x0019F851 File Offset: 0x0019DA51
	private static int MaxRows
	{
		get
		{
			return Math.Max(100, Math.Min(1000, 1304.45.6()));
		}
	}

	// Token: 0x060042A8 RID: 17064 RVA: 0x0019F870 File Offset: 0x0019DA70
	internal 1707(bool 1 = false) : base(1707.20(), true)
	{
		this.45 = 3;
		this.40 = new 1417(new 207(0, 100, 640, 278), 208.Zero, false, 0f, 1545.Dialog);
		float num = 70f + 1662.70.5();
		this.43 = new 1452(string.Empty, 12f, new 208(num, 56f), 0.95f, true, 198.White);
		this.AddSprite(this.43);
		this.44 = new 1452(string.Empty, 11f, new 208(num + 500f, 57f), 0.95f, true, new 198(79, 179, 246));
		this.44.49 = 1065.TopRight;
		this.44.10 = true;
		this.44.42 = new 1445(1456.Fade, 0.7f, 1f, 0, 100, (1046)0);
		this.44.3(delegate(object 1, EventArgs 2)
		{
			this.45 = !this.45;
			this.40.20(208.Zero, 0f);
			this.21();
		});
		this.AddSprite(this.44);
		1452 4 = new 1452("Profile settings", 11f, new 208(num + 500f, 38f), 0.95f, true, new 198(79, 179, 246));
		4.49 = 1065.TopRight;
		4.10 = true;
		4.52 = "Which plays count, your approximate rank, your picture and importing McOsu scores";
		4.42 = new 1445(1456.Fade, 0.7f, 1f, 0, 100, (1046)0);
		4.3(delegate(object 1, EventArgs 2)
		{
			this.Close(false);
			1662.25(new 1710());
		});
		this.AddSprite(4);
		this.47 = new 1452("Most played", 11f, new 208(num + 500f - 110f, 38f), 0.95f, true, new 198(79, 179, 246));
		this.47.49 = 1065.TopRight;
		this.47.10 = true;
		this.47.52 = "The beatmaps this profile played most";
		this.47.42 = new 1445(1456.Fade, 0.7f, 1f, 0, 100, (1046)0);
		this.47.3(delegate(object 1, EventArgs 2)
		{
			this.46 = !this.46;
			this.45 = false;
			1448 5 = this.67;
			if (5 != null)
			{
				5.SetText(this.13());
			}
			this.12();
			this.40.20(208.Zero, 0f);
			this.21();
		});
		this.AddSprite(this.47);
		this.52 = new 1452(string.Empty, 11f, new 208(num, 38f), 0.95f, true, new 198(79, 179, 246));
		this.52.10 = true;
		this.52.52 = "Click for the next order";
		this.52.42 = new 1445(1456.Fade, 0.7f, 1f, 0, 100, (1046)0);
		this.52.3(delegate(object 1, EventArgs 2)
		{
			if (this.46)
			{
				1707.51 = (1707.51 + 1) % 1707.49.Length;
			}
			else
			{
				1707.50 = (1707.50 + 1) % 1707.48.Length;
			}
			this.40.20(208.Zero, 0f);
			this.21();
		});
		this.AddSprite(this.52);
		this.55 = new 1452(string.Empty, 11f, new 208(num + 110f, 38f), 0.95f, true, new 198(79, 179, 246));
		this.55.10 = true;
		this.55.52 = "All plays, only the ones set offline, or only the ones set on Bancho";
		this.55.42 = new 1445(1456.Fade, 0.7f, 1f, 0, 100, (1046)0);
		this.55.3(delegate(object 1, EventArgs 2)
		{
			1707.54 = (1707.54 + 1) % 1707.53.Length;
			this.40.20(208.Zero, 0f);
			this.21();
		});
		this.AddSprite(this.55);
		bool isConfigured = 1631.IsConfigured;
		this.56 = new 1452("Import Bancho data", 11f, new 208(num + 215f, 38f), 0.95f, true, isConfigured ? new 198(136, 221, 119) : new 198(byte.MaxValue, 120, 120));
		this.56.10 = true;
		this.56.52 = (isConfigured ? "Add the best plays of the osu! account with this profile's name, and its bonus pp" : "Needs the osu! API: set it up in Options (Online rankings)");
		this.56.42 = new 1445(1456.Fade, 0.7f, 1f, 0, 100, (1046)0);
		this.56.3(delegate(object 1, EventArgs 2)
		{
			if (261.FullyOffline)
			{
				1763.5("Internet is turned off in the launcher.", 198.Orange, 4000, null);
				return;
			}
			if (!1631.IsConfigured)
			{
				1763.5("Set up the osu! API first: Options, Online rankings.", 198.Orange, 5000, null);
				return;
			}
			this.Close(false);
			2202.Start();
		});
		this.AddSprite(this.56);
		this.3 = 392f;
		base.7("Profile Manager", new 198(79, 139, 246), delegate(object 1, EventArgs 2)
		{
			1662.25(new 1709(null));
		}, true, true, true);
		this.3 -= 50f;
		base.7("Close", 198.Gray, null, true, true, false);
		1707.60 = this;
		this.21();
	}

	// Token: 0x060042A9 RID: 17065 RVA: 0x0019FD70 File Offset: 0x0019DF70
	internal override void Show()
	{
		this.67 = new 1448(this.13(), 11f, new 208(70f + 1662.70.5(), 78f), 500f, 0.94f, false);
		this.67.4 = 120;
		this.67.5(delegate(1448 1, bool 2)
		{
			if (this.67.GetText() == "Filter, e.g. name  pp>300  acc>=98  mods=hddt  +hr  -ez  grade>=s  combo>500  miss=0  age<30" || this.67.GetText() == "Filter, e.g. name  plays>=20")
			{
				this.67.SetText(string.Empty);
			}
		});
		this.67.4(delegate(1448 1, bool 2)
		{
			this.12();
			string text = this.67.GetText() ?? string.Empty;
			text = ((text == "Filter, e.g. name  pp>300  acc>=98  mods=hddt  +hr  -ez  grade>=s  combo>500  miss=0  age<30" || text == "Filter, e.g. name  plays>=20") ? string.Empty : text.Trim());
			if (text != (this.46 ? 1707.65 : 1707.63))
			{
				if (this.46)
				{
					1707.65 = text;
				}
				else
				{
					1707.63 = text;
				}
				this.40.20(208.Zero, 0f);
				this.21();
			}
		});
		this.7.14<1433>(this.67.2);
		this.12();
		base.Show();
	}

	// Token: 0x060042AA RID: 17066 RVA: 0x0019FE18 File Offset: 0x0019E018
	private void 12()
	{
		if (this.67 == null)
		{
			return;
		}
		string text = this.67.GetText();
		bool flag = text == "Filter, e.g. name  pp>300  acc>=98  mods=hddt  +hr  -ez  grade>=s  combo>500  miss=0  age<30" || text == "Filter, e.g. name  plays>=20";
		this.67.1.62(flag ? new 198(140, 140, 140) : 198.White);
		this.67.1.54(!flag);
	}

	// Token: 0x060042AB RID: 17067 RVA: 0x0019FE98 File Offset: 0x0019E098
	internal override bool OnKeyDown(200 1)
	{
		return (this.67 == null || !this.67.1()) && base.OnKeyDown(1);
	}

	// Token: 0x060042AC RID: 17068 RVA: 0x0019FEB8 File Offset: 0x0019E0B8
	private string 13()
	{
		string text = this.46 ? 1707.65 : 1707.63;
		if (text.Length > 0)
		{
			return text;
		}
		if (!this.46)
		{
			return "Filter, e.g. name  pp>300  acc>=98  mods=hddt  +hr  -ez  grade>=s  combo>500  miss=0  age<30";
		}
		return "Filter, e.g. name  plays>=20";
	}

	// Token: 0x060042AD RID: 17069 RVA: 0x0019FEF8 File Offset: 0x0019E0F8
	private new static void 14(1262 1, string 2, out string 3, out string 4)
	{
		if (1 != null)
		{
			3 = 1.81;
			4 = (string.IsNullOrEmpty(1.89) ? null : 1.89);
			return;
		}
		3 = 2;
		4 = null;
		if (2 != null && 2.EndsWith("]", StringComparison.Ordinal))
		{
			int num = 2.LastIndexOf(" [", StringComparison.Ordinal);
			if (num > 0)
			{
				3 = 2.Substring(0, num);
				4 = 2.Substring(num + 2, 2.Length - num - 3);
			}
		}
	}

	// Token: 0x060042AE RID: 17070 RVA: 0x0019FF70 File Offset: 0x0019E170
	private new float 15(string 1, float 2, float 3, 198 4, float 5 = 3.4028235E+38f)
	{
		if (1 == null)
		{
			return 2;
		}
		string 6 = "[" + 1 + "]";
		if (1707.16(6) > 5)
		{
			int val = Math.Max(4, (int)(5 / 3.9f) - 5);
			6 = "[" + 1.Substring(0, Math.Min(val, 1.Length)).TrimEnd(Array.Empty<char>()) + "...]";
		}
		this.32(new 1452(6, 9f, new 208(2, 3), 0.95f, true, 4));
		return 2 + 1707.16(6) + 8f;
	}

	// Token: 0x060042AF RID: 17071 RVA: 0x001A000A File Offset: 0x0019E20A
	private new static float 16(string 1)
	{
		return (float)1.Length * 3.9f;
	}

	// Token: 0x060042B0 RID: 17072 RVA: 0x001A001C File Offset: 0x0019E21C
	private new float 17(string 1, float 2, float 3, float 4, 198 5)
	{
		1452 6 = new 1452(1, 9f, new 208(2, 3), 0.95f, true, 5);
		this.32(6);
		this.32.Add(6);
		if (4 <= 0f)
		{
			return 2;
		}
		return 2 + Math.Max(4, (1.Length == 0) ? 0f : (1707.16(1) + 8f));
	}

	// Token: 0x060042B1 RID: 17073 RVA: 0x001A0088 File Offset: 0x0019E288
	private void 18(2210.2214 1, 1452 2)
	{
		1707.<>c__DisplayClass63_0 CS$<>8__locals1 = new 1707.<>c__DisplayClass63_0();
		CS$<>8__locals1.play = 5;
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.targets = new List<1433>(this.32)
		{
			6
		};
		this.32.Clear();
		CS$<>8__locals1.score = CS$<>8__locals1.play.1;
		CS$<>8__locals1.us = 1662.18;
		CS$<>8__locals1.ifFullCombo = ((CS$<>8__locals1.play.3 == null) ? "If FC: needs the beatmap" : (2237.2(CS$<>8__locals1.score, CS$<>8__locals1.play.3) ? "If FC: working it out..." : null));
		CS$<>8__locals1.asked = false;
		CS$<>8__locals1.rowGeneration = this.57;
		foreach (1433 3 in CS$<>8__locals1.targets)
		{
			3.10 = true;
			EventHandler 4;
			if ((4 = CS$<>8__locals1.<>9__2) == null)
			{
				4 = (CS$<>8__locals1.<>9__2 = delegate(object 1, EventArgs 2)
				{
					if (!CS$<>8__locals1.asked)
					{
						base.<AddPlayDetails>g__AskIfFullCombo|1();
					}
				});
			}
			3.35(4);
		}
		CS$<>8__locals1.<AddPlayDetails>g__Refresh|0();
	}

	// Token: 0x060042B2 RID: 17074 RVA: 0x001A01A4 File Offset: 0x0019E3A4
	private static string 19(string 1, int 2)
	{
		if (1.Length <= 2)
		{
			return 1;
		}
		return 1.Substring(0, 2 - 3) + "...";
	}

	// Token: 0x060042B3 RID: 17075 RVA: 0x001A01C8 File Offset: 0x0019E3C8
	private static string 20()
	{
		string value = 1304.189.GetValue();
		string text = (2210.Mode == 2147.Osu) ? string.Empty : (2148.1(2210.Mode) + " ");
		if (!string.IsNullOrEmpty(value))
		{
			return value + "'s " + text + "top plays";
		}
		if (text.Length <= 0)
		{
			return "Top plays";
		}
		return text + "top plays";
	}

	// Token: 0x060042B4 RID: 17076 RVA: 0x001A0238 File Offset: 0x0019E438
	private void 21()
	{
		this.57++;
		foreach (1433 <<EMPTY_NAME>> in this.41)
		{
			this.40.22.Remove(<<EMPTY_NAME>>);
			<<EMPTY_NAME>>.Dispose();
		}
		this.41.Clear();
		this.61.Clear();
		this.36();
		2210.2216 5 = 2210.37(null, null);
		string text = (5.8 > 0) ? ("   (" + 5.8.ToString() + " play(s) still being worked out)") : string.Empty;
		if (5.10 > 0)
		{
			text = text + "   (" + 5.10.ToString() + " with McOsu's outdated pp)";
		}
		int count = 5.9.FindAll((2210.2214 1) => 1.7).Count;
		if (this.45 && count == 0)
		{
			this.45 = false;
		}
		int? num = (5.5 > 0 && 5.8 == 0) ? 2210.76(5.1, new Action(this.30), null) : null;
		string str = (num != null) ? string.Format(1662.18, "#{0:#,0}   ", num.Value) : string.Empty;
		2223 3 = new 2223(1707.63);
		this.47.SetText(this.46 ? "Top plays" : "Most played");
		this.52.SetText("Sort: " + (this.46 ? 1707.49[1707.51] : 1707.48[1707.50]));
		this.55.SetText(this.46 ? string.Empty : ("Plays: " + 1707.53[1707.54]));
		this.55.10 = !this.46;
		this.56.SetText(this.46 ? string.Empty : "Import Bancho data");
		this.56.10 = !this.46;
		if (this.46)
		{
			this.44.SetText(string.Empty);
			this.44.10 = false;
			this.23();
			return;
		}
		double num2 = 2210.13(1304.189.GetValue(), 2210.Mode);
		string text2 = (num2 >= 1.0) ? ("   " + 1707.22(num2) + " played") : string.Empty;
		this.43.SetText(this.45 ? "Bin: plays that do not count toward your pp" : ((5.5 == 0) ? "No plays count toward this profile yet. Which plays count is set in Profile settings (top right)." : (str + string.Format(1662.18, "{0:#,0}pp   {1:0.00}%   {2:#,0} plays on {3:#,0} beatmaps{4}{5}", new object[]
		{
			5.1,
			5.2 * 100.0,
			5.5,
			5.6,
			text2,
			text
		}))));
		this.44.SetText(this.45 ? "back to top plays" : ((count > 0) ? ("bin (" + count.ToString() + ")") : string.Empty));
		this.44.10 = (this.45 || count > 0);
		List<KeyValuePair<1262, 208>> list = new List<KeyValuePair<1262, 208>>();
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		List<KeyValuePair<2210.2214, int>> list2 = new List<KeyValuePair<2210.2214, int>>();
		foreach (2210.2214 4 in 5.9)
		{
			if (4.7 == this.45)
			{
				num5++;
				list2.Add(new KeyValuePair<2210.2214, int>(4, 4.7 ? 0 : (++num4)));
			}
		}
		string a = 1707.48[1707.50];
		Comparison<2210.2214> order2;
		if (!(a == "date"))
		{
			if (!(a == "accuracy"))
			{
				if (!(a == "combo"))
				{
					if (!(a == "score"))
					{
						if (!(a == "misses"))
						{
							order2 = null;
						}
						else
						{
							order2 = ((2210.2214 1, 2210.2214 2) => 1.1.6.CompareTo(2.1.6));
						}
					}
					else
					{
						order2 = ((2210.2214 1, 2210.2214 2) => 2.1.GetScore().CompareTo(1.1.GetScore()));
					}
				}
				else
				{
					order2 = ((2210.2214 1, 2210.2214 2) => 2.1.13.CompareTo(1.1.13));
				}
			}
			else
			{
				order2 = ((2210.2214 1, 2210.2214 2) => 2.5.CompareTo(1.5));
			}
		}
		else
		{
			order2 = ((2210.2214 1, 2210.2214 2) => 2.1.7.CompareTo(1.1.7));
		}
		Comparison<2210.2214> order = order2;
		if (order != null)
		{
			list2.Sort(delegate(KeyValuePair<2210.2214, int> 1, KeyValuePair<2210.2214, int> 2)
			{
				int num7 = order(1.Key, 2.Key);
				if (num7 == 0)
				{
					return 2.Key.4.CompareTo(1.Key.4);
				}
				return num7;
			});
		}
		this.69 = 42f;
		foreach (KeyValuePair<2210.2214, int> keyValuePair in list2)
		{
			string text3 = keyValuePair.Key.1.1();
			this.69 = Math.Max(this.69, Math.Min(100f, 1707.16(string.IsNullOrEmpty(text3) ? "No mods" : text3) + 8f));
		}
		foreach (KeyValuePair<2210.2214, int> keyValuePair2 in list2)
		{
			2210.2214 key = keyValuePair2.Key;
			if (num3 < 1707.MaxRows && 3.1(key) && (1707.54 <= 0 || 2223.3(key.1) == (1707.54 == 2)))
			{
				float num6 = (float)(num3 * 30);
				this.24(key, keyValuePair2.Value, num6);
				if (key.3 != null)
				{
					list.Add(new KeyValuePair<1262, 208>(key.3, new 208(70f, num6 + 2f)));
				}
				num3++;
			}
		}
		if (!3.IsEmpty || 3.Problem != null || 1707.54 > 0)
		{
			this.43.SetText(string.Concat(new string[]
			{
				this.43.GetText(),
				"   (",
				((3.IsEmpty && 1707.54 == 0) ? num5 : num3).ToString(),
				" of ",
				num5.ToString(),
				" shown",
				(3.Problem != null) ? ("; not understood: " + 3.Problem) : string.Empty,
				")"
			}));
		}
		this.40.17(new 208(500f, (float)(num3 * 30)));
		this.33(list, this.57);
	}

	// Token: 0x060042B5 RID: 17077 RVA: 0x001A09F8 File Offset: 0x0019EBF8
	private static string 22(double 1)
	{
		TimeSpan timeSpan = TimeSpan.FromSeconds(1);
		if (timeSpan.TotalDays >= 1.0)
		{
			return ((int)timeSpan.TotalDays).ToString() + "d " + timeSpan.Hours.ToString() + "h";
		}
		if (timeSpan.TotalHours >= 1.0)
		{
			return ((int)timeSpan.TotalHours).ToString() + "h " + timeSpan.Minutes.ToString() + "m";
		}
		if (timeSpan.TotalMinutes < 1.0)
		{
			return timeSpan.Seconds.ToString() + "s";
		}
		return timeSpan.Minutes.ToString() + "m " + timeSpan.Seconds.ToString() + "s";
	}

	// Token: 0x060042B6 RID: 17078 RVA: 0x001A0AE8 File Offset: 0x0019ECE8
	private void 23()
	{
		List<2210.2215> list = 2210.15(1304.189.GetValue(), 2210.Mode);
		if (1707.49[1707.51] == "name")
		{
			list.Sort(delegate(2210.2215 1, 2210.2215 2)
			{
				1262 5 = 1.2;
				string strA;
				if ((strA = ((5 != null) ? 5.49 : null)) == null)
				{
					strA = (1.3 ?? "~");
				}
				1262 6 = 2.2;
				string strB;
				if ((strB = ((6 != null) ? 6.49 : null)) == null)
				{
					strB = (2.3 ?? "~");
				}
				return string.Compare(strA, strB, StringComparison.OrdinalIgnoreCase);
			});
		}
		int num = 0;
		foreach (2210.2215 <<EMPTY_NAME>> in list)
		{
			num += <<EMPTY_NAME>>.4;
		}
		double num2 = 2210.13(1304.189.GetValue(), 2210.Mode);
		this.43.SetText((list.Count == 0) ? "No plays yet." : string.Format(1662.18, "Most played: {0:#,0} plays on {1:#,0} beatmaps{2}", num, list.Count, (num2 >= 1.0) ? ("   " + 1707.22(num2) + " played") : string.Empty));
		List<string> list2 = new List<string>();
		List<Func<int, bool>> list3 = new List<Func<int, bool>>();
		foreach (string text in (1707.65 ?? string.Empty).Split(new char[]
		{
			' '
		}, StringSplitOptions.RemoveEmptyEntries))
		{
			Match match = 1707.66.Match(text);
			if (match.Success)
			{
				string op = match.Groups[1].Value;
				int number = int.Parse(match.Groups[2].Value, CultureInfo.InvariantCulture);
				list3.Add(delegate(int 1)
				{
					if (op == "<")
					{
						return 1 < number;
					}
					if (op == ">")
					{
						return 1 > number;
					}
					if (op == "<=")
					{
						return 1 <= number;
					}
					if (op == ">=")
					{
						return 1 >= number;
					}
					if (!(op == "!="))
					{
						return 1 == number;
					}
					return 1 != number;
				});
			}
			else
			{
				list2.Add(text.ToLowerInvariant());
			}
		}
		List<KeyValuePair<1262, 208>> list4 = new List<KeyValuePair<1262, 208>>();
		int num3 = 0;
		int num4 = 0;
		using (List<2210.2215>.Enumerator enumerator = list.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				2210.2215 beatmap = enumerator.Current;
				1707.<>c__DisplayClass68_2 CS$<>8__locals3 = new 1707.<>c__DisplayClass68_2();
				string text2;
				string text3;
				1707.14(beatmap.2, beatmap.3, out text2, out text3);
				text2 = (text2 ?? "(a beatmap that is no longer here)");
				1707.<>c__DisplayClass68_2 CS$<>8__locals4 = CS$<>8__locals3;
				string[] array2 = new string[5];
				array2[0] = text2;
				array2[1] = " ";
				array2[2] = text3;
				array2[3] = " ";
				int num5 = 4;
				1262 4 = beatmap.2;
				array2[num5] = ((4 != null) ? 4.43 : null);
				CS$<>8__locals4.searchable = string.Concat(array2).ToLowerInvariant();
				if (list2.TrueForAll((string 1) => CS$<>8__locals3.searchable.Contains(1)) && list3.TrueForAll((Func<int, bool> 1) => 1(beatmap.4)))
				{
					num4++;
					if (num3 < 1707.MaxRows)
					{
						float num6 = (float)(num3 * 30);
						float num7 = 120f;
						if (text2.Length > 50)
						{
							text2 = text2.Substring(0, 47) + "...";
						}
						this.32(new 1452(text2, 12f, new 208(num7, num6), 0.95f, true, (beatmap.2 != null) ? 198.White : 1707.34));
						1262 3 = beatmap.2;
						string text4 = (3 != null) ? 3.43 : null;
						this.15(text3, num7, num6 + 15f, 1707.38, 104f);
						this.32(new 1452(string.IsNullOrEmpty(text4) ? string.Empty : ("mapped by " + text4), 9f, new 208(num7 + 110f, num6 + 15f), 0.95f, true, 1707.34));
						this.32(new 1452(string.Format(1662.18, "{0:#,0} plays", beatmap.4), 13f, new 208(570f, num6 + 4f), 0.95f, true, 1707.36)
						{
							49 = 1065.TopRight
						});
						if (beatmap.2 != null)
						{
							list4.Add(new KeyValuePair<1262, 208>(beatmap.2, new 208(70f, num6 + 2f)));
						}
						num3++;
					}
				}
			}
		}
		if (list2.Count > 0 || list3.Count > 0)
		{
			this.43.SetText(string.Concat(new string[]
			{
				this.43.GetText(),
				"   (",
				num4.ToString(),
				" of ",
				list.Count.ToString(),
				" shown)"
			}));
		}
		this.40.17(new 208(500f, (float)(num3 * 30)));
		this.33(list4, this.57);
	}

	// Token: 0x060042B7 RID: 17079 RVA: 0x001A101C File Offset: 0x0019F21C
	private void 24(2210.2214 1, int 2, float 3)
	{
		float num = 120f;
		this.32.Clear();
		198 4 = 15.7 ? 1707.35 : ((15.3 == null) ? 1707.34 : 198.White);
		string text;
		string 5;
		1707.14(15.3, 15.8, out text, out 5);
		text = (text ?? "(a beatmap that is no longer here)");
		string text2 = (15.3 == null && 15.8 != null) ? "  (no longer here)" : string.Empty;
		string text3 = 15.7 ? string.Empty : ("#" + 16.ToString() + "  ");
		int num2 = 45 - text3.Length - text2.Length;
		if (text.Length > num2)
		{
			text = text.Substring(0, Math.Max(8, num2 - 3)) + "...";
		}
		text += text2;
		1452 6 = new 1452(text3 + text, 12f, new 208(num, 3), 0.95f, true, 4);
		if (15.3 != null)
		{
			6.10 = true;
			6.52 = "Open the results of this play";
			6.42 = new 1445(1456.Fade, 0.75f, 1f, 0, 100, (1046)0);
			6.3(delegate(object 1, EventArgs 2)
			{
				this.Close(false);
				1272.SetCurrentBeatmap(15.3);
				1535.39 = 15.1;
				1535.2(true);
				1662.SetMode(1677.Rank, false);
			});
		}
		this.32(6);
		string 7;
		if (15.3 == null && 1707.59.TryGetValue(15.2, out 7))
		{
			1452 8 = new 1452(7, 10f, new 208(92f, 3 + 8f), 0.95f, true, new 198(79, 179, 246));
			8.49 = 1065.TopCentre;
			this.61[15.2] = 8;
			this.32(8);
		}
		else if (15.3 == null && !261.FullyOffline)
		{
			1386 9 = new 1386(1048.cloud_download, 16f, new 208(92f, 3 + 13f))
			{
				2 = 0.95f,
				6 = new 198(79, 179, 246)
			};
			9.10 = true;
			9.52 = "Download this beatmap from the beatmap mirror";
			9.42 = new 1445(1456.Fade, 0.7f, 1f, 0, 100, (1046)0);
			9.3(delegate(object 1, EventArgs 2)
			{
				1707.25(15.2, 15.9);
			});
			this.32(9);
		}
		198 10 = 15.7 ? 1707.35 : 1707.34;
		this.15(5, num, 3 + 15f, 15.7 ? 1707.35 : 1707.38, 66f);
		string text4 = 15.1.1();
		float 11 = num + 72f;
		11 = this.17(string.IsNullOrEmpty(text4) ? "No mods" : text4, 11, 3 + 15f, this.69, 10);
		11 = this.17(string.Format(1662.18, "{0:0.00}%", 15.5 * 100.0), 11, 3 + 15f, 34f, 10);
		11 = this.17(string.Format(1662.18, "{0:#,0}x", 15.1.13), 11, 3 + 15f, 30f, 10);
		11 = this.17((15.1.6 > 0) ? (15.1.6.ToString("#,0", 1662.18) + "x") : string.Empty, 11, 3 + 15f, 22f, 15.7 ? 1707.35 : 1707.31);
		this.17(1707.37(15.1.7), 11, 3 + 15f, 0f, 10);
		this.18(15, 6);
		bool flag = 2223.3(15.1);
		this.32(new 1452(flag ? "Bancho" : "offline", 9f, new 208(445f, 3 + 3f), 0.95f, true, 15.7 ? 1707.35 : (flag ? new 198(byte.MaxValue, 102, 170) : new 198(136, 221, 119)))
		{
			49 = 1065.TopRight,
			10 = true,
			52 = (flag ? "Set on Bancho (osu!'s servers)" : "Set offline")
		});
		1452 12 = new 1452(string.Format(1662.18, "{0:#,0}pp", 15.4), 13f, new 208(500f, 3), 0.95f, true, 15.7 ? 1707.35 : (15.10 ? 1707.37 : 1707.36));
		12.49 = 1065.TopRight;
		if (15.10)
		{
			12.10 = true;
			12.52 = "McOsu's pp, from an outdated calculation: worked out again once the beatmap is here";
		}
		this.32(12);
		this.32(new 1452(15.7 ? "not counted" : string.Format(1662.18, "{2}weighted {0:0}% ({1:#,0}pp)", 15.6 * 100.0, 15.4 * 15.6, 15.10 ? "outdated, " : string.Empty), 9f, new 208(500f, 3 + 15f), 0.95f, true, 15.7 ? 1707.35 : 1707.34)
		{
			49 = 1065.TopRight
		});
		1452 13 = new 1452(15.7 ? "restore" : "bin", 10f, new 208(570f, 3 + 7f), 0.95f, true, 15.7 ? new 198(136, 221, 119) : new 198(byte.MaxValue, 140, 140));
		13.49 = 1065.TopRight;
		13.10 = true;
		13.52 = (15.7 ? "Count this play toward your pp again" : "Move this play to the bin: it no longer counts toward your pp");
		13.42 = new 1445(1456.Fade, 0.7f, 1f, 0, 100, (1046)0);
		13.3(delegate(object 1, EventArgs 2)
		{
			2210.36(15.1, !15.7);
			2210.Refresh();
			1662.89.Schedule(new 1189(this.21), true);
		});
		this.32(13);
		if (15.7 && 2210.33(15.1))
		{
			1452 14 = new 1452("delete", 10f, new 208(570f, 3 + 19f), 0.95f, true, new 198(byte.MaxValue, 140, 140));
			14.49 = 1065.TopRight;
			14.10 = true;
			14.52 = "Delete this play for good";
			14.42 = new 1445(1456.Fade, 0.7f, 1f, 0, 100, (1046)0);
			14.3(delegate(object 1, EventArgs 2)
			{
				this.Close(false);
				string str = "Delete this play for good?\n";
				1262 17 = 15.3;
				string str2;
				if ((str2 = ((17 != null) ? 17.49 : null)) == null)
				{
					str2 = (15.8 ?? string.Empty);
				}
				1662.25(new 1688(str + str2, delegate(object 1, EventArgs 2)
				{
					2210.35(15.1);
					2210.Refresh();
					1662.25(new 1707(true));
				}, delegate(object 1, EventArgs 2)
				{
					1662.25(new 1707(true));
				}, true));
			});
			this.32(14);
		}
	}

	// Token: 0x060042B8 RID: 17080 RVA: 0x001A1834 File Offset: 0x0019FA34
	private static void 25(string 1, int 2)
	{
		if (1707.59.ContainsKey(3))
		{
			return;
		}
		1707.27(3, "...");
		1707.28(3, "looking up by checksum (beatmap id " + 2.ToString() + ")");
		1707.26(1579.Checksum, 3, delegate(1573 1)
		{
			1707.28(3, (1 == null) ? "not found by checksum" : ("found set " + 1.5.ToString() + (1.12 ? " (a copy is here)" : string.Empty)));
			if (1 != null)
			{
				1707.Download(3, 1, false);
				return;
			}
			if (2 <= 0)
			{
				1707.29(3, "The beatmap mirror does not have this beatmap (it may have been updated since, or never submitted).");
				return;
			}
			1707.26(1579.Beatmap, 2.ToString(), delegate(1573 1)
			{
				1707.28(3, (1 == null) ? "not found by beatmap id" : ("found set " + 1.5.ToString() + " by beatmap id" + (1.12 ? " (a copy is here)" : string.Empty)));
				if (1 == null)
				{
					1707.29(3, "The beatmap mirror does not have this beatmap.");
					return;
				}
				if (1.12)
				{
					1707.29(3, "This beatmap was updated since your play, and you already have the newest version. Your play keeps its pp until you set a better one on it.");
					return;
				}
				1707.Download(3, 1, true);
			});
		});
	}

	// Token: 0x060042B9 RID: 17081 RVA: 0x001A18B8 File Offset: 0x0019FAB8
	private static void 26(1579 1, string 2, Action<1573> 3)
	{
		if (!1632.4(4.ToString().ToLowerInvariant()[0]))
		{
			3(null);
			return;
		}
		1573.6(4, 5, delegate(object 1, EventArgs 2)
		{
			1662.89.Schedule(delegate()
			{
				3(1 as 1573);
			}, true);
		});
	}

	// Token: 0x060042BA RID: 17082 RVA: 0x001A1914 File Offset: 0x0019FB14
	private static void Download(string 1, 1573 2, bool 3)
	{
		2.32 = delegate(double 1)
		{
			1662.89.Schedule(delegate()
			{
				if (1707.59.ContainsKey(4))
				{
					1707.27(4, ((int)Math.Round(Math.Max(0.0, Math.Min(1.0, 1)) * 100.0)).ToString() + "%");
				}
			}, true);
		};
		2.33 = delegate(bool 1)
		{
			1662.89.Schedule(delegate()
			{
				1707.28(4, "download of set " + 2.5.ToString() + (1 ? " finished" : " failed"));
				if (!1)
				{
					1707.29(4, "The beatmap could not be downloaded.");
					return;
				}
				1707.27(4, "...");
				1662.89.Schedule(delegate()
				{
					bool flag = 2463.5();
					1707.59.Remove(4);
					1707.28(4, (flag ? "imported" : "import put off") + "; the play's version is " + ((1272.8(4) != null) ? "here now" : "still not here"));
					if (!flag)
					{
						1763.5("The beatmap is downloaded; it is added the next time you open song select.", 198.Orange, 5000, null);
					}
					else if (3)
					{
						1763.5("The newest version of this beatmap is here now. Your play was on an older version: it keeps its pp until you set a better one.", 198.Orange, 7000, null);
					}
					2210.Refresh();
					1707.31();
				}, true);
			}, true);
		};
		1707.28(4, "downloading set " + 2.5.ToString() + (3 ? " (newer version)" : string.Empty));
		if (!2.3())
		{
			1707.29(4, "The beatmap could not be downloaded.");
		}
	}

	// Token: 0x060042BB RID: 17083 RVA: 0x001A19C4 File Offset: 0x0019FBC4
	private static void 27(string 1, string 2)
	{
		bool flag = !1707.59.ContainsKey(1);
		1707.59[1] = 2;
		if (1707.60 == null)
		{
			return;
		}
		if (flag)
		{
			1707.31();
			return;
		}
		1452 3;
		if (1707.60.61.TryGetValue(1, out 3))
		{
			3.SetText(2);
		}
	}

	// Token: 0x060042BC RID: 17084 RVA: 0x001A1A18 File Offset: 0x0019FC18
	private static void 28(string 1, string 2)
	{
		1338.5("Top plays: beatmap " + 1 + ": " + 2, 1341.Runtime, (1114)2);
	}

	// Token: 0x060042BD RID: 17085 RVA: 0x001A1A32 File Offset: 0x0019FC32
	private static void 29(string 1, string 2)
	{
		1707.28(1, "stopped: " + 2);
		1707.59.Remove(1);
		1763.5(2, 198.Orange, 7000, null);
		1707.31();
	}

	// Token: 0x060042BE RID: 17086 RVA: 0x001A1A67 File Offset: 0x0019FC67
	private void 30()
	{
		if (!this.58)
		{
			this.21();
		}
	}

	// Token: 0x060042BF RID: 17087 RVA: 0x001A1A78 File Offset: 0x0019FC78
	private static void 31()
	{
		1707 dialog = 1707.60;
		if (dialog != null)
		{
			1662.89.Schedule(delegate()
			{
				if (!dialog.58)
				{
					dialog.21();
				}
			}, true);
		}
	}

	// Token: 0x060042C0 RID: 17088 RVA: 0x001A1AB6 File Offset: 0x0019FCB6
	private void 32(1433 1)
	{
		this.41.Add(1);
		this.40.22.12(1);
	}

	// Token: 0x060042C1 RID: 17089 RVA: 0x001A1AD8 File Offset: 0x0019FCD8
	private void 33(List<KeyValuePair<1262, 208>> 1, int 2)
	{
		if (1.Count == 0)
		{
			return;
		}
		new Thread(delegate()
		{
			foreach (KeyValuePair<1262, 208> keyValuePair in 1)
			{
				if (this.58 || 2 != this.57)
				{
					break;
				}
				byte[] image = 1707.34(keyValuePair.Key);
				if (image != null)
				{
					208 position = keyValuePair.Value;
					1662.89.Schedule(delegate()
					{
						if (this.58 || 2 != this.57)
						{
							return;
						}
						try
						{
							1381 3 = 1381.14(new MemoryStream(image), null);
							if (3 != null)
							{
								this.42.Add(3);
								1433 4 = new 1433(3, position, 0.94f, true, 198.White);
								4.15 = 0.73333335f;
								4.15(200);
								this.32(4);
							}
						}
						catch (Exception)
						{
						}
					}, true);
				}
			}
		})
		{
			IsBackground = true,
			Priority = ThreadPriority.BelowNormal,
			Name = "profile thumbnails"
		}.Start();
	}

	// Token: 0x060042C2 RID: 17090 RVA: 0x001A1B40 File Offset: 0x0019FD40
	private static byte[] 34(1262 1)
	{
		byte[] result;
		try
		{
			string text = 1707.35(1);
			if (text == null)
			{
				result = null;
			}
			else
			{
				Dictionary<string, byte[]> obj = 1707.39;
				lock (obj)
				{
					byte[] result2;
					if (1707.39.TryGetValue(text, out result2))
					{
						return result2;
					}
				}
				byte[] array = File.Exists(text) ? 1639.1(File.ReadAllBytes(text), 96, 54) : null;
				obj = 1707.39;
				lock (obj)
				{
					1707.39[text] = array;
				}
				result = array;
			}
		}
		catch (Exception)
		{
			result = null;
		}
		return result;
	}

	// Token: 0x060042C3 RID: 17091 RVA: 0x001A1C08 File Offset: 0x0019FE08
	private static string 35(1262 1)
	{
		if (1.61)
		{
			return null;
		}
		string path = 1.44();
		if (!string.IsNullOrEmpty(1.22))
		{
			return Path.Combine(path, 1.22);
		}
		string text = 1.68();
		if (string.IsNullOrEmpty(text) || !File.Exists(text))
		{
			return null;
		}
		bool flag = false;
		foreach (string text2 in File.ReadLines(text))
		{
			if (text2.StartsWith("[", StringComparison.Ordinal))
			{
				if (flag)
				{
					break;
				}
				flag = text2.StartsWith("[Events]", StringComparison.OrdinalIgnoreCase);
			}
			else if (flag && (text2.StartsWith("0,0,", StringComparison.Ordinal) || text2.StartsWith("Background,", StringComparison.OrdinalIgnoreCase)))
			{
				string[] array = text2.Split(new char[]
				{
					','
				});
				if (array.Length >= 3)
				{
					return Path.Combine(path, array[2].Trim().Trim(new char[]
					{
						'"'
					}));
				}
			}
		}
		return null;
	}

	// Token: 0x060042C4 RID: 17092 RVA: 0x001A1D28 File Offset: 0x0019FF28
	private void 36()
	{
		foreach (1381 <<EMPTY_NAME>> in this.42)
		{
			try
			{
				<<EMPTY_NAME>>.Dispose();
			}
			catch (Exception)
			{
			}
		}
		this.42.Clear();
	}

	// Token: 0x060042C5 RID: 17093 RVA: 0x001A1D98 File Offset: 0x0019FF98
	private static string 37(DateTime 1)
	{
		TimeSpan timeSpan = DateTime.UtcNow - 1.ToUniversalTime();
		if (timeSpan.TotalDays >= 365.0)
		{
			return 1707.38((int)(timeSpan.TotalDays / 365.0), "year");
		}
		if (timeSpan.TotalDays >= 30.0)
		{
			return 1707.38((int)(timeSpan.TotalDays / 30.0), "month");
		}
		if (timeSpan.TotalDays >= 1.0)
		{
			return 1707.38((int)timeSpan.TotalDays, "day");
		}
		if (timeSpan.TotalHours >= 1.0)
		{
			return 1707.38((int)timeSpan.TotalHours, "hour");
		}
		if (timeSpan.TotalMinutes < 1.0)
		{
			return "just now";
		}
		return 1707.38((int)timeSpan.TotalMinutes, "minute");
	}

	// Token: 0x060042C6 RID: 17094 RVA: 0x001A1E89 File Offset: 0x001A0089
	private static string 38(int 1, string 2)
	{
		return string.Concat(new string[]
		{
			1.ToString(),
			" ",
			2,
			(1 == 1) ? string.Empty : "s",
			" ago"
		});
	}

	// Token: 0x060042C7 RID: 17095 RVA: 0x001A1EC7 File Offset: 0x001A00C7
	public override void Update()
	{
		this.40.Update();
		base.Update();
	}

	// Token: 0x060042C8 RID: 17096 RVA: 0x001A1EDA File Offset: 0x001A00DA
	internal override void DrawDialog()
	{
		base.DrawDialog();
		this.40.21();
	}

	// Token: 0x060042C9 RID: 17097 RVA: 0x001A1EED File Offset: 0x001A00ED
	protected override void Dispose(bool 1)
	{
		this.58 = true;
		1448 2 = this.67;
		if (2 != null)
		{
			2.Dispose();
		}
		if (1707.60 == this)
		{
			1707.60 = null;
		}
		this.40.Dispose();
		this.36();
		base.Dispose(1);
	}

	// Token: 0x040030BB RID: 12475
	private const int 18 = 50;

	// Token: 0x040030BC RID: 12476
	private const int 19 = 30;

	// Token: 0x040030BD RID: 12477
	private const float 20 = 70f;

	// Token: 0x040030BE RID: 12478
	private const float 21 = 500f;

	// Token: 0x040030BF RID: 12479
	private const int 22 = 96;

	// Token: 0x040030C0 RID: 12480
	private const int 23 = 54;

	// Token: 0x040030C1 RID: 12481
	private const float 24 = 44f;

	// Token: 0x040030C2 RID: 12482
	private const float 25 = 72f;

	// Token: 0x040030C3 RID: 12483
	private const float 26 = 42f;

	// Token: 0x040030C4 RID: 12484
	private const float 27 = 100f;

	// Token: 0x040030C5 RID: 12485
	private const float 28 = 34f;

	// Token: 0x040030C6 RID: 12486
	private const float 29 = 30f;

	// Token: 0x040030C7 RID: 12487
	private const float 30 = 22f;

	// Token: 0x040030C8 RID: 12488
	private static readonly 198 31 = new 198(byte.MaxValue, 110, 110);

	// Token: 0x040030C9 RID: 12489
	private readonly List<1433> 32 = new List<1433>();

	// Token: 0x040030CA RID: 12490
	private const float 33 = 110f;

	// Token: 0x040030CB RID: 12491
	private static readonly 198 34 = new 198(170, 176, 192);

	// Token: 0x040030CC RID: 12492
	private static readonly 198 35 = new 198(120, 124, 136);

	// Token: 0x040030CD RID: 12493
	private static readonly 198 36 = new 198(byte.MaxValue, 214, 102);

	// Token: 0x040030CE RID: 12494
	private static readonly 198 37 = new 198(byte.MaxValue, 150, 70);

	// Token: 0x040030CF RID: 12495
	private static readonly 198 38 = new 198(140, 200, byte.MaxValue);

	// Token: 0x040030D0 RID: 12496
	private static readonly Dictionary<string, byte[]> 39 = new Dictionary<string, byte[]>(StringComparer.OrdinalIgnoreCase);

	// Token: 0x040030D1 RID: 12497
	private readonly 1417 40;

	// Token: 0x040030D2 RID: 12498
	private readonly List<1433> 41 = new List<1433>();

	// Token: 0x040030D3 RID: 12499
	private readonly List<1381> 42 = new List<1381>();

	// Token: 0x040030D4 RID: 12500
	private 1452 43;

	// Token: 0x040030D5 RID: 12501
	private 1452 44;

	// Token: 0x040030D6 RID: 12502
	private bool 45;

	// Token: 0x040030D7 RID: 12503
	private bool 46;

	// Token: 0x040030D8 RID: 12504
	private 1452 47;

	// Token: 0x040030D9 RID: 12505
	private static readonly string[] 48 = new string[]
	{
		"pp",
		"date",
		"accuracy",
		"combo",
		"score",
		"misses"
	};

	// Token: 0x040030DA RID: 12506
	private static readonly string[] 49 = new string[]
	{
		"plays",
		"name"
	};

	// Token: 0x040030DB RID: 12507
	private static int 50;

	// Token: 0x040030DC RID: 12508
	private static int 51;

	// Token: 0x040030DD RID: 12509
	private 1452 52;

	// Token: 0x040030DE RID: 12510
	private static readonly string[] 53 = new string[]
	{
		"all",
		"offline",
		"Bancho"
	};

	// Token: 0x040030DF RID: 12511
	private static int 54;

	// Token: 0x040030E0 RID: 12512
	private 1452 55;

	// Token: 0x040030E1 RID: 12513
	private 1452 56;

	// Token: 0x040030E2 RID: 12514
	private int 57;

	// Token: 0x040030E3 RID: 12515
	private bool 58;

	// Token: 0x040030E4 RID: 12516
	private static readonly Dictionary<string, string> 59 = new Dictionary<string, string>(StringComparer.Ordinal);

	// Token: 0x040030E5 RID: 12517
	private static 1707 60;

	// Token: 0x040030E6 RID: 12518
	private readonly Dictionary<string, 1452> 61 = new Dictionary<string, 1452>(StringComparer.Ordinal);

	// Token: 0x040030E7 RID: 12519
	private const string 62 = "Filter, e.g. name  pp>300  acc>=98  mods=hddt  +hr  -ez  grade>=s  combo>500  miss=0  age<30";

	// Token: 0x040030E8 RID: 12520
	private static string 63 = string.Empty;

	// Token: 0x040030E9 RID: 12521
	private const string 64 = "Filter, e.g. name  plays>=20";

	// Token: 0x040030EA RID: 12522
	private static string 65 = string.Empty;

	// Token: 0x040030EB RID: 12523
	private static readonly Regex 66 = new Regex("^plays?([<>]=?|==?|!=)(\\d+)$", RegexOptions.IgnoreCase);

	// Token: 0x040030EC RID: 12524
	private 1448 67;

	// Token: 0x040030ED RID: 12525
	private const float 68 = 3.9f;

	// Token: 0x040030EE RID: 12526
	private float 69 = 42f;
}
