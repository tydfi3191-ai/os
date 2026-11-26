using System;
using System.Collections.Generic;

// Token: 0x0200093F RID: 2367
internal sealed class 1709 : 1689
{
	// Token: 0x0600430C RID: 17164 RVA: 0x001A3060 File Offset: 0x001A1260
	internal 1709(string 1 = null) : base((3 == null) ? ("Profile Manager" + ((2210.Mode == 2147.Osu) ? string.Empty : (" (" + 2148.1(2210.Mode) + ")"))) : ("Merge " + 3 + " into..."), true)
	{
		this.31 = 3;
		this.24 = new 1417(new 207(0, 88, 640, 290), 208.Zero, false, 0f, 1545.Dialog);
		this.3 = 392f;
		if (3 != null)
		{
			base.7("Cancel", 198.Gray, delegate(object 1, EventArgs 2)
			{
				1662.25(new 1709(null));
			}, true, false, true);
			this.16();
			return;
		}
		base.7("Import profile", 2630.16, delegate(object 1, EventArgs 2)
		{
			if (2227.Import() != null)
			{
				this.22();
			}
		}, false, true, true);
		this.3 -= 50f;
		base.7("Close", 198.Gray, null, true, true, false);
		this.16();
	}

	// Token: 0x0600430D RID: 17165 RVA: 0x001A319C File Offset: 0x001A139C
	internal override void Show()
	{
		if (this.31 != null)
		{
			this.30 = new 1452("Choose the profile that " + this.31 + "'s plays go into.", 11f, new 208(90f + 1662.70.5(), 58f), 0.95f, true, 1709.23);
			this.7.12(this.30);
			base.Show();
			return;
		}
		this.26 = new 1448("Type a name for a new profile and press Enter", 13f, new 208(90f + 1662.70.5(), 58f), 460f, 0.94f, false);
		this.26.4 = 20;
		this.26.25 = false;
		this.26.3(new 1448.1449(this.14));
		this.26.5(delegate(1448 1, bool 2)
		{
			if (this.26.GetText() == "Type a name for a new profile and press Enter")
			{
				this.26.SetText(string.Empty);
			}
		});
		this.7.14<1433>(this.26.2);
		this.30 = new 1452(string.Empty, 10f, new 208(90f + 1662.70.5(), 44f), 0.95f, true, new 198(byte.MaxValue, 204, 34));
		this.7.12(this.30);
		base.Show();
	}

	// Token: 0x0600430E RID: 17166 RVA: 0x001A3308 File Offset: 0x001A1508
	private void 12(string 1, string 2)
	{
		if (this.26 != null && this.26.1())
		{
			this.26.18(false);
		}
		this.28 = 1;
		this.29 = 2;
		1452 3 = this.30;
		if (3 != null)
		{
			3.SetText((1 != null) ? ("Rename " + 1 + ": type the new name and press Enter (Esc: cancel)") : ("Clone " + 2 + ": type a name for the new profile and press Enter (Esc: cancel)"));
		}
		if (this.26 != null)
		{
			this.26.SetText(string.Empty);
			1662.89.Schedule(delegate()
			{
				if (!this.27 && (this.28 != null || this.29 != null))
				{
					1448 4 = this.26;
					if (4 == null)
					{
						return;
					}
					4.16();
				}
			}, true);
		}
	}

	// Token: 0x0600430F RID: 17167 RVA: 0x001A33AA File Offset: 0x001A15AA
	private void 13()
	{
		this.28 = null;
		this.29 = null;
		1452 <<EMPTY_NAME>> = this.30;
		if (<<EMPTY_NAME>> != null)
		{
			<<EMPTY_NAME>>.SetText(string.Empty);
		}
		1448 2 = this.26;
		if (2 == null)
		{
			return;
		}
		2.SetText("Type a name for a new profile and press Enter");
	}

	// Token: 0x06004310 RID: 17168 RVA: 0x001A33E5 File Offset: 0x001A15E5
	internal override bool OnKeyDown(200 1)
	{
		return (this.26 == null || !this.26.1()) && base.OnKeyDown(1);
	}

	// Token: 0x06004311 RID: 17169 RVA: 0x001A3408 File Offset: 0x001A1608
	private new void 14(1448 1, bool 2)
	{
		string name = (this.26.GetText() ?? string.Empty).Trim();
		string text = this.28;
		string text2 = this.29;
		if (!2 || name.Length == 0 || name == "Type a name for a new profile and press Enter")
		{
			if (text != null || text2 != null)
			{
				this.13();
			}
			return;
		}
		if (text != null)
		{
			this.Rename(text, name);
			return;
		}
		if (text2 != null)
		{
			this.Clone(text2, name);
			return;
		}
		this.15(name, !2210.55().Exists((string 1) => string.Equals(1, name, StringComparison.OrdinalIgnoreCase)));
	}

	// Token: 0x06004312 RID: 17170 RVA: 0x001A34C0 File Offset: 0x001A16C0
	private void Rename(string 1, string 2)
	{
		if (4 == 3)
		{
			this.13();
			return;
		}
		if (!string.Equals(4, 3, StringComparison.OrdinalIgnoreCase) && 2210.59(4))
		{
			1763.5("The name " + 4 + " is taken by another profile or by scores on this computer.", 198.Orange, 5000, null);
			this.12(3, null);
			return;
		}
		int num = string.Equals(4, 3, StringComparison.OrdinalIgnoreCase) ? 0 : 2210.60(3);
		this.Close(false);
		1662.25(new 1688(string.Concat(new string[]
		{
			"Rename the profile ",
			3,
			" to ",
			4,
			"?",
			(num > 0) ? string.Concat(new string[]
			{
				"\n",
				num.ToString(),
				" score(s) from osu!'s own scores.db keep the name ",
				3,
				" and no longer count toward this profile."
			}) : string.Empty
		}), delegate(object 1, EventArgs 2)
		{
			if (2210.61(3, 4) < 0)
			{
				1763.5("The profile could not be renamed now (osu!'s or nekiosu's score files could not be read). Try again in a moment.", 198.OrangeRed, 5000, null);
			}
			else
			{
				1763.5("Profile renamed to " + 4 + ".", 198.YellowGreen, 4000, null);
			}
			1662.25(new 1709(null));
		}, delegate(object 1, EventArgs 2)
		{
			1662.25(new 1709(null));
		}, true));
	}

	// Token: 0x06004313 RID: 17171 RVA: 0x001A3628 File Offset: 0x001A1828
	private void Clone(string 1, string 2)
	{
		if (2210.59(2))
		{
			1763.5("The name " + 2 + " is taken by another profile or by scores on this computer.", 198.Orange, 5000, null);
			this.12(null, 1);
			return;
		}
		if (2210.62(1, 2) < 0)
		{
			1763.5("The profile could not be cloned now (the profile file could not be read).", 198.OrangeRed, 5000, null);
		}
		else
		{
			1763.5(string.Concat(new string[]
			{
				"New profile ",
				2,
				", cloned from ",
				1,
				"."
			}), 198.YellowGreen, 4000, null);
		}
		this.13();
		this.22();
	}

	// Token: 0x06004314 RID: 17172 RVA: 0x001A36CE File Offset: 0x001A18CE
	private new void 15(string 1, bool 2)
	{
		2210.56(1);
		1763.5((2 ? "New profile: " : "Profile: ") + 1, 198.YellowGreen, 3000, null);
		this.Close(false);
		1662.25(new 1707(false));
	}

	// Token: 0x06004315 RID: 17173 RVA: 0x001A3710 File Offset: 0x001A1910
	private new void 16()
	{
		foreach (1433 <<EMPTY_NAME>> in this.25)
		{
			this.24.22.Remove(<<EMPTY_NAME>>);
			<<EMPTY_NAME>>.Dispose();
		}
		this.25.Clear();
		string b = 1304.189.GetValue() ?? string.Empty;
		int num = 0;
		foreach (string text in 2210.55())
		{
			if (this.31 == null || !string.Equals(text, this.31, StringComparison.OrdinalIgnoreCase))
			{
				this.17(text, string.Equals(text, b, StringComparison.OrdinalIgnoreCase), (float)(num * 32));
				num++;
			}
		}
		this.24.17(new 208(460f, (float)(num * 32)));
	}

	// Token: 0x06004316 RID: 17174 RVA: 0x001A381C File Offset: 0x001A1A1C
	private new void 17(string 1, bool 2, float 3)
	{
		2210.2216 4;
		if (!this.33 || !this.32.TryGetValue(10, out 4))
		{
			4 = 2210.38(null, null, 10);
			if (4.8 == 0)
			{
				this.32[10] = 4;
			}
		}
		this.21(new 1452(10, 13f, new 208(90f, 3), 0.95f, true, 11 ? new 198(79, 179, 246) : 198.White));
		int? num = (4.5 == 0 || 4.8 > 0) ? null : (11 ? 2210.76(4.1, new Action(this.23), null) : 2218.Get(4.1, new Action(this.23), 2210.Mode));
		string 5 = (4.5 == 0) ? "no plays yet" : (((num != null) ? string.Format(1662.18, "#{0:#,0}  ", num.Value) : string.Empty) + string.Format(1662.18, "{0:#,0}pp  {1:0.00}%  {2:#,0} plays", 4.1, 4.2 * 100.0, 4.5));
		this.21(new 1452(5, 10f, new 208(240f, 3 + 3f), 0.95f, true, 1709.23));
		if (this.31 != null)
		{
			string source = this.31;
			this.21(1709.20("merge here", new 198(byte.MaxValue, 204, 34), new 208(550f, 3 + 3f), "Move " + source + "'s plays into " + 10, delegate(object 1, EventArgs 2)
			{
				this.Close(false);
				1709.19(source, 10);
			}));
			return;
		}
		1452 6 = 1709.20("rename", new 198(byte.MaxValue, 204, 34), new 208(240f, 3 + 16f), "Give this profile another name", delegate(object 1, EventArgs 2)
		{
			this.12(10, null);
		});
		6.49 = 1065.TopLeft;
		this.21(6);
		1452 7 = 1709.20("clone", new 198(byte.MaxValue, 204, 34), new 208(290f, 3 + 16f), "Make a new profile that starts with this one's plays", delegate(object 1, EventArgs 2)
		{
			this.12(null, 10);
		});
		7.49 = 1065.TopLeft;
		this.21(7);
		1452 8 = 1709.20("export", new 198(byte.MaxValue, 204, 34), new 208(335f, 3 + 16f), "Save this profile and its plays to a file", delegate(object 1, EventArgs 2)
		{
			this.Close(false);
			1689 12 = new 1689("Export the profile " + 10 + " with its replays?", true);
			12.7("With replays", 2630.16, delegate(object 1, EventArgs 2)
			{
				2227.1(10, true);
				1662.25(new 1709(null));
			}, true, false, true);
			12.7("Without replays (smaller)", 2630.16, delegate(object 1, EventArgs 2)
			{
				2227.1(10, false);
				1662.25(new 1709(null));
			}, true, false, true);
			12.7("Cancel", 198.Gray, delegate(object 1, EventArgs 2)
			{
				1662.25(new 1709(null));
			}, true, false, true);
			1662.25(12);
		});
		8.49 = 1065.TopLeft;
		this.21(8);
		1452 9 = 1709.20("merge", new 198(byte.MaxValue, 204, 34), new 208(385f, 3 + 16f), "Move this profile's plays into another profile", delegate(object 1, EventArgs 2)
		{
			this.18(10);
		});
		9.49 = 1065.TopLeft;
		this.21(9);
		if (11)
		{
			this.21(new 1452("in use", 10f, new 208(550f, 3 + 3f), 0.95f, true, new 198(79, 179, 246))
			{
				49 = 1065.TopRight
			});
			return;
		}
		this.21(1709.20("use", new 198(136, 221, 119), new 208(500f, 3 + 3f), "Switch to this profile", delegate(object 1, EventArgs 2)
		{
			this.15(10, false);
		}));
		this.21(1709.20("delete", new 198(byte.MaxValue, 140, 140), new 208(550f, 3 + 3f), "Delete this profile (its plays can stay)", delegate(object 1, EventArgs 2)
		{
			int plays = 2210.57(10);
			this.Close(false);
			if (plays == 0)
			{
				1662.25(new 1688("Delete the profile " + 10 + "?", delegate(object 1, EventArgs 2)
				{
					base.<AddRow>g__Delete|10(true);
				}, delegate(object 1, EventArgs 2)
				{
					1662.25(new 1709(null));
				}, true));
				return;
			}
			1689 12 = new 1689(string.Concat(new string[]
			{
				"Delete the profile ",
				10,
				"?\nIts ",
				plays.ToString(),
				" play(s) and replays can stay: they come back\nwhen a profile named ",
				10,
				" is made or imported again."
			}), true);
			12.7("Delete, keep the plays", 198.Orange, delegate(object 1, EventArgs 2)
			{
				base.<AddRow>g__Delete|10(false);
			}, true, false, true);
			12.7("Delete with the plays", 198.OrangeRed, delegate(object 1, EventArgs 2)
			{
				1662.25(new 1688(string.Concat(new string[]
				{
					"Delete ",
					10,
					"'s ",
					plays.ToString(),
					" play(s) and their replays?\nThis cannot be undone. Scores that are osu!'s own stay."
				}), delegate(object 1, EventArgs 2)
				{
					base.<AddRow>g__Delete|10(true);
				}, delegate(object 1, EventArgs 2)
				{
					1662.25(new 1709(null));
				}, true));
			}, true, false, true);
			12.7("Cancel", 198.Gray, delegate(object 1, EventArgs 2)
			{
				1662.25(new 1709(null));
			}, true, false, true);
			1662.25(12);
		}));
	}

	// Token: 0x06004317 RID: 17175 RVA: 0x001A3C6C File Offset: 0x001A1E6C
	private void 18(string 1)
	{
		if (!2210.55().Exists((string 1) => !string.Equals(1, 2, StringComparison.OrdinalIgnoreCase)))
		{
			1763.5("There is no other profile to merge " + 2 + " into.", 198.Orange, 4000, null);
			return;
		}
		this.Close(false);
		1662.25(new 1709(2));
	}

	// Token: 0x06004318 RID: 17176 RVA: 0x001A3CDC File Offset: 0x001A1EDC
	private static void 19(string 1, string 2)
	{
		int num = 2210.57(3);
		1662.25(new 1688(string.Concat(new string[]
		{
			"Merge ",
			3,
			" into ",
			4,
			"?\n",
			3,
			"'s ",
			num.ToString(),
			" play(s), play time and attempts move to ",
			4,
			", and ",
			3,
			" is removed.\nThis cannot be undone."
		}), delegate(object 1, EventArgs 2)
		{
			2210.2213 5 = 2210.63(3, 4);
			if (5 == null)
			{
				1763.5("The profiles could not be merged now (osu!'s or nekiosu's score files could not be read). Try again in a moment.", 198.OrangeRed, 5000, null);
			}
			else
			{
				string str = string.Concat(new string[]
				{
					"Merged ",
					3,
					" into ",
					4,
					": ",
					5.1.ToString(),
					" play(s) moved"
				});
				if (5.2 > 0)
				{
					str = str + ", " + 5.2.ToString() + " already there";
				}
				if (5.3 > 0)
				{
					str = str + ", " + 5.3.ToString() + " shared";
				}
				1763.5(str + ".", 198.YellowGreen, 5000, null);
			}
			1662.25(new 1709(null));
		}, delegate(object 1, EventArgs 2)
		{
			1662.25(new 1709(null));
		}, true));
	}

	// Token: 0x06004319 RID: 17177 RVA: 0x001A3DC0 File Offset: 0x001A1FC0
	private static 1452 20(string 1, 198 2, 208 3, string 4, EventHandler 5)
	{
		1452 6 = new 1452(1, 10f, 3, 0.95f, true, 2);
		6.49 = 1065.TopRight;
		6.10 = true;
		6.52 = 4;
		6.42 = new 1445(1456.Fade, 0.7f, 1f, 0, 100, (1046)0);
		6.3(5);
		return 6;
	}

	// Token: 0x0600431A RID: 17178 RVA: 0x001A3E17 File Offset: 0x001A2017
	private void 21(1433 1)
	{
		this.25.Add(1);
		this.24.22.12(1);
	}

	// Token: 0x0600431B RID: 17179 RVA: 0x001A3E36 File Offset: 0x001A2036
	public override void Update()
	{
		this.24.Update();
		base.Update();
	}

	// Token: 0x0600431C RID: 17180 RVA: 0x001A3E49 File Offset: 0x001A2049
	internal override void DrawDialog()
	{
		base.DrawDialog();
		this.24.21();
	}

	// Token: 0x0600431D RID: 17181 RVA: 0x001A3E5C File Offset: 0x001A205C
	private void 22()
	{
		if (!this.27)
		{
			this.16();
		}
	}

	// Token: 0x0600431E RID: 17182 RVA: 0x001A3E6C File Offset: 0x001A206C
	private void 23()
	{
		if (this.27)
		{
			return;
		}
		this.33 = true;
		try
		{
			this.16();
		}
		finally
		{
			this.33 = false;
		}
	}

	// Token: 0x0600431F RID: 17183 RVA: 0x001A3EAC File Offset: 0x001A20AC
	protected override void Dispose(bool 1)
	{
		this.27 = true;
		1448 2 = this.26;
		if (2 != null)
		{
			2.Dispose();
		}
		this.24.Dispose();
		base.Dispose(1);
	}

	// Token: 0x0400311F RID: 12575
	private const int 18 = 32;

	// Token: 0x04003120 RID: 12576
	private const float 19 = 90f;

	// Token: 0x04003121 RID: 12577
	private const float 20 = 460f;

	// Token: 0x04003122 RID: 12578
	private const int 21 = 20;

	// Token: 0x04003123 RID: 12579
	private const string 22 = "Type a name for a new profile and press Enter";

	// Token: 0x04003124 RID: 12580
	private static readonly 198 23 = new 198(170, 176, 192);

	// Token: 0x04003125 RID: 12581
	private readonly 1417 24;

	// Token: 0x04003126 RID: 12582
	private readonly List<1433> 25 = new List<1433>();

	// Token: 0x04003127 RID: 12583
	private 1448 26;

	// Token: 0x04003128 RID: 12584
	private bool 27;

	// Token: 0x04003129 RID: 12585
	private string 28;

	// Token: 0x0400312A RID: 12586
	private string 29;

	// Token: 0x0400312B RID: 12587
	private 1452 30;

	// Token: 0x0400312C RID: 12588
	private readonly string 31;

	// Token: 0x0400312D RID: 12589
	private readonly Dictionary<string, 2210.2216> 32 = new Dictionary<string, 2210.2216>(StringComparer.OrdinalIgnoreCase);

	// Token: 0x0400312E RID: 12590
	private bool 33;
}
