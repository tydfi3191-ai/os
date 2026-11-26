using System;
using System.Collections.Generic;

// Token: 0x020008E3 RID: 2275
public sealed class 1746 : 1689
{
	// Token: 0x060040F2 RID: 16626 RVA: 0x0019308C File Offset: 0x0019128C
	public 1746() : base("Extra Mods", true)
	{
		this.3 = Math.Max(this.3, 1754.13());
		1452 <<EMPTY_NAME>> = new 1452("Click a mod to turn it on or change its settings.", 14f, new 208(0f, this.3 - 20f), 208.Zero, 0.94f, true, 198.LightGray, true)
		{
			41 = (1376)7,
			49 = 1065.Centre
		};
		this.7.12(<<EMPTY_NAME>>);
		this.3 += new 1452(string.Empty, 30f, 208.Zero, 208.Zero, 0.94f, true, 198.White, true).GetTextSize().Y + 35f;
		float 12 = this.3 + 180f;
		this.7.12(new 1452("Conversion", 24f, new 208(20f, this.3 - 13f), 208.Zero, 0.94f, true, new 198(178, 132, byte.MaxValue), true));
		208 3 = new 208(240f, this.3);
		this.18 = new 1433(1455.2("selection-mod-difficultyadjust", (1416)7, null), (1376)6, 1065.Centre, (1044)0, 3, 0.94f, true, 198.White, null);
		this.18.52 = "Difficulty Adjust: override a beatmap's difficulty settings.";
		this.18.10 = true;
		this.18.35(delegate(object 1, EventArgs 2)
		{
			1226.20(null, "click-short", 1f, false);
		});
		this.18.3(new EventHandler(this.12));
		this.7.12(this.18);
		this.19 = new 1433(1455.2("lighting", (1416)1, null), 1065.Centre, 3, 0.99f, true, 198.SkyBlue);
		this.19.16 = 0f;
		this.19.28 = true;
		this.7.12(this.19);
		this.20 = new 1452(string.Empty, 14f, new 208(219f, this.3 + 38f), 0.94f, true, 198.White);
		this.20.49 = 1065.CentreLeft;
		this.7.12(this.20);
		if (1931.2(1925.SelectedPlayMode))
		{
			208 4 = new 208(306f, this.3);
			this.21 = new 1433(1455.2("selection-mod-nonotelock", (1416)7, null), (1376)6, 1065.Centre, (1044)0, 4, 0.94f, true, 198.White, null);
			this.21.52 = "No Notelock: osu!lazer's lenient note lock.";
			this.21.10 = true;
			this.21.35(delegate(object 1, EventArgs 2)
			{
				1226.20(null, "click-short", 1f, false);
			});
			this.21.3(delegate(object 1, EventArgs 2)
			{
				1931.1(!1931.Enabled);
				this.Refresh(true, 1931.Enabled);
			});
			this.7.12(this.21);
			this.22 = new 1433(1455.2("lighting", (1416)1, null), 1065.Centre, 4, 0.99f, true, 198.SkyBlue);
			this.22.16 = 0f;
			this.22.28 = true;
			this.7.12(this.22);
		}
		2147 selectedPlayMode = 1925.SelectedPlayMode;
		this.31 = (selectedPlayMode == 2147.Taiko);
		if (1925.7(selectedPlayMode))
		{
			List<1746.1747> list = new List<1746.1747>();
			if (1925.8(selectedPlayMode))
			{
				list.Add(1746.1747.Mirror);
			}
			if (1925.9(selectedPlayMode))
			{
				list.Add(1746.1747.Random);
			}
			if (1925.10(selectedPlayMode))
			{
				list.Add(1746.1747.Alternate);
				list.Add(1746.1747.SingleTap);
			}
			this.28 = list.ToArray();
			this.29 = new 1433[this.28.Length];
			this.30 = new 1433[this.28.Length];
			int num = (this.21 != null) ? 2 : 1;
			for (int i = 0; i < this.28.Length; i++)
			{
				string 5;
				string 6;
				EventHandler 7;
				switch (this.28[i])
				{
				case 1746.1747.Mirror:
					5 = "selection-mod-mirror";
					6 = ((selectedPlayMode == 2147.Taiko) ? "Mirror: dons become kats, kats become dons. Cannot be combined with Random." : ((selectedPlayMode == 2147.CatchTheBeat) ? "Mirror: fruits are flipped horizontally." : "Mirror: flip objects on the chosen axes. Cannot be combined with Hard Rock."));
					7 = new EventHandler(this.13);
					break;
				case 1746.1747.Random:
					5 = "selection-mod-random";
					6 = ((selectedPlayMode == 2147.Taiko) ? "Random: shuffle around the colours! Cannot be combined with Mirror." : ((selectedPlayMode == 2147.CatchTheBeat) ? "Random: every jump keeps its size but may switch direction." : "Random: it never gets boring! Every object is moved to a new place.\nCannot be combined with Target Practice."));
					7 = new EventHandler(this.14);
					break;
				case 1746.1747.Alternate:
					5 = "selection-mod-alternate";
					6 = "Alternate: don't use the same button twice in a row!\nCannot be combined with Single Tap, Auto, Relax or Cinema.";
					7 = new EventHandler(this.21);
					break;
				default:
					5 = "selection-mod-singletap";
					6 = "Single Tap: you must only use one button!\nCannot be combined with Alternate, Auto, Relax or Cinema.";
					7 = new EventHandler(this.22);
					break;
				}
				208 8 = new 208(240f + 66f * (float)(i + num), this.3);
				this.29[i] = new 1433(1455.2(5, (1416)7, null), (1376)6, 1065.Centre, (1044)0, 8, 0.94f, true, 198.White, null);
				this.29[i].52 = 6;
				this.29[i].10 = true;
				this.29[i].35(delegate(object 1, EventArgs 2)
				{
					1226.20(null, "click-short", 1f, false);
				});
				this.29[i].3(7);
				this.7.12(this.29[i]);
				this.30[i] = new 1433(1455.2("lighting", (1416)1, null), 1065.Centre, 8, 0.99f, true, 198.SkyBlue);
				this.30[i].16 = 0f;
				this.30[i].28 = true;
				this.7.12(this.30[i]);
			}
		}
		float num2 = this.3 + 120f;
		this.7.12(new 1452("Other", 24f, new 208(20f, num2 - 13f), 208.Zero, 0.94f, true, new 198(byte.MaxValue, 102, 170), true));
		208 9 = new 208(240f, num2);
		this.23 = new 1433(1455.2("selection-mod-practice", (1416)7, null), (1376)6, 1065.Centre, (1044)0, 9, 0.94f, true, 198.White, null);
		this.23.52 = "Practice: jump anywhere in the beatmap.";
		this.23.10 = true;
		this.23.35(delegate(object 1, EventArgs 2)
		{
			1226.20(null, "click-short", 1f, false);
		});
		this.23.3(delegate(object 1, EventArgs 2)
		{
			this.20(1555.4() == 199.Pressed);
		});
		this.7.12(this.23);
		this.24 = new 1433(1455.2("lighting", (1416)1, null), 1065.Centre, 9, 0.99f, true, 198.SkyBlue);
		this.24.16 = 0f;
		this.24.28 = true;
		this.7.12(this.24);
		208 10 = new 208(306f, num2);
		this.25 = new 1433(1455.2("selection-mod-pitch", (1416)7, null), (1376)6, 1065.Centre, (1044)0, 10, 0.94f, true, 198.White, null);
		this.25.52 = "Pitch: change the music's pitch.";
		this.25.10 = true;
		this.25.35(delegate(object 1, EventArgs 2)
		{
			1226.20(null, "click-short", 1f, false);
		});
		this.25.3(delegate(object 1, EventArgs 2)
		{
			this.19(1555.4() == 199.Pressed);
		});
		this.7.12(this.25);
		this.26 = new 1433(1455.2("lighting", (1416)1, null), 1065.Centre, 10, 0.99f, true, 198.SkyBlue);
		this.26.16 = 0f;
		this.26.28 = true;
		this.7.12(this.26);
		if (this.31 && 1925.MirrorEnabled && 1925.RandomEnabled)
		{
			1925.12(false, 1925.SelectedMirrorAxes);
		}
		this.3 = 12;
		base.7("Reset all extra mods", 198.OrangeRed, delegate(object 1, EventArgs 2)
		{
			1931.1(false);
			1925.Reset();
			1926.6(false);
			1936.1(false);
			1933.1(false);
			this.Refresh(true, false);
		}, false, false, true);
		1361 11 = base.7("Previous", 198.YellowGreen, delegate(object 1, EventArgs 2)
		{
			this.Close(false);
			2601.81();
		}, false, true, true);
		base.6(11);
		this.3 -= 50f;
		base.7("Close", 198.Gray, null, true, true, false);
	}

	// Token: 0x060040F3 RID: 16627 RVA: 0x0019396C File Offset: 0x00191B6C
	internal override void OnShown()
	{
		this.Refresh(false, true);
		base.OnShown();
	}

	// Token: 0x060040F4 RID: 16628 RVA: 0x0019397C File Offset: 0x00191B7C
	private void 12(object 1, EventArgs 2)
	{
		this.15(1555.4() == 199.Pressed);
	}

	// Token: 0x060040F5 RID: 16629 RVA: 0x0019398C File Offset: 0x00191B8C
	private void 13(object 1, EventArgs 2)
	{
		this.16(1555.4() == 199.Pressed);
	}

	// Token: 0x060040F6 RID: 16630 RVA: 0x0019399C File Offset: 0x00191B9C
	private new void 14(object 1, EventArgs 2)
	{
		this.17(1555.4() == 199.Pressed);
	}

	// Token: 0x060040F7 RID: 16631 RVA: 0x001939AC File Offset: 0x00191BAC
	private new void 15(bool 1)
	{
		if (1)
		{
			1926.6(!1926.Enabled);
			this.Refresh(true, 1926.Enabled);
			return;
		}
		this.18(new 1744());
	}

	// Token: 0x060040F8 RID: 16632 RVA: 0x001939D6 File Offset: 0x00191BD6
	private new void 16(bool 1)
	{
		if (1 || !1925.11(1925.SelectedPlayMode))
		{
			1925.12(!1925.MirrorEnabled, 1925.SelectedMirrorAxes);
			this.Refresh(true, 1925.MirrorEnabled);
			return;
		}
		this.18(new 1750());
	}

	// Token: 0x060040F9 RID: 16633 RVA: 0x00193A11 File Offset: 0x00191C11
	private new void 17(bool 1)
	{
		if (1)
		{
			1925.4(!1925.RandomEnabled, 1925.SelectedRandomSeed, 1925.SelectedAngleSharpness);
			this.Refresh(true, 1925.RandomEnabled);
			return;
		}
		this.18(new 1758());
	}

	// Token: 0x060040FA RID: 16634 RVA: 0x00193A48 File Offset: 0x00191C48
	private void 18(1689 1)
	{
		1226.20(null, "click-short-confirm", 1f, false);
		this.27 = true;
		this.Close(false);
		1662.25(1);
	}

	// Token: 0x060040FB RID: 16635 RVA: 0x00193A82 File Offset: 0x00191C82
	private void 19(bool 1)
	{
		if (1)
		{
			1933.1(!1933.Enabled);
			this.Refresh(true, 1933.Enabled);
			return;
		}
		this.18(new 1755());
	}

	// Token: 0x060040FC RID: 16636 RVA: 0x00193AAC File Offset: 0x00191CAC
	private void 20(bool 1)
	{
		if (1)
		{
			1936.1(!1936.Enabled);
			this.Refresh(true, 1936.Enabled);
			return;
		}
		this.18(new 1756());
	}

	// Token: 0x060040FD RID: 16637 RVA: 0x00193AD6 File Offset: 0x00191CD6
	private void 21(object 1, EventArgs 2)
	{
		this.23(1930.Alternate);
	}

	// Token: 0x060040FE RID: 16638 RVA: 0x00193ADF File Offset: 0x00191CDF
	private void 22(object 1, EventArgs 2)
	{
		this.23(1930.SingleTap);
	}

	// Token: 0x060040FF RID: 16639 RVA: 0x00193AE8 File Offset: 0x00191CE8
	private void 23(1930 1)
	{
		bool flag = 1925.SelectedInput != 1;
		1925.13(flag ? 1 : 1930.None);
		this.Refresh(true, flag);
	}

	// Token: 0x06004100 RID: 16640 RVA: 0x00193B15 File Offset: 0x00191D15
	private static bool 24(1746.1747 1)
	{
		switch (1)
		{
		case 1746.1747.Mirror:
			return 1925.MirrorEnabled;
		case 1746.1747.Random:
			return 1925.RandomEnabled;
		case 1746.1747.Alternate:
			return 1925.SelectedInput == 1930.Alternate;
		default:
			return 1925.SelectedInput == 1930.SingleTap;
		}
	}

	// Token: 0x06004101 RID: 16641 RVA: 0x00193B48 File Offset: 0x00191D48
	private bool 25(1746.1747 1)
	{
		return this.28 != null && Array.IndexOf<1746.1747>(this.28, 1) >= 0;
	}

	// Token: 0x06004102 RID: 16642 RVA: 0x00193B68 File Offset: 0x00191D68
	private void Refresh(bool 1, bool 2 = true)
	{
		if (this.29 != null)
		{
			for (int i = 0; i < this.29.Length; i++)
			{
				bool flag = 1746.24(this.28[i]);
				this.29[i].25(flag ? 1.2f : 1f, 400, (1046)25);
				this.29[i].26(flag ? 0.1f : 0f, 400, (1046)25);
				this.30[i].24(flag ? 0.2f : 0f, 100, (1046)0);
			}
		}
		bool enabled = 1926.Enabled;
		this.18.25(enabled ? 1.2f : 1f, 400, (1046)25);
		this.18.26(enabled ? 0.1f : 0f, 400, (1046)25);
		this.19.24(enabled ? 0.2f : 0f, 100, (1046)0);
		string text = 1926.23(1925.SelectedPlayMode);
		this.20.SetText((enabled && text.Length > 0) ? ("Difficulty Adjust: " + text) : string.Empty);
		if (this.21 != null)
		{
			bool enabled2 = 1931.Enabled;
			this.21.25(enabled2 ? 1.2f : 1f, 400, (1046)25);
			this.21.26(enabled2 ? 0.1f : 0f, 400, (1046)25);
			this.22.24(enabled2 ? 0.2f : 0f, 100, (1046)0);
		}
		bool enabled3 = 1936.Enabled;
		this.23.25(enabled3 ? 1.2f : 1f, 400, (1046)25);
		this.23.26(enabled3 ? 0.1f : 0f, 400, (1046)25);
		this.24.24(enabled3 ? 0.2f : 0f, 100, (1046)0);
		bool enabled4 = 1933.Enabled;
		this.25.25(enabled4 ? 1.2f : 1f, 400, (1046)25);
		this.25.26(enabled4 ? 0.1f : 0f, 400, (1046)25);
		this.26.24(enabled4 ? 0.2f : 0f, 100, (1046)0);
		if (1)
		{
			1226.20(null, 2 ? "check-on" : "check-off", 1f, false);
		}
	}

	// Token: 0x06004103 RID: 16643 RVA: 0x00193E18 File Offset: 0x00192018
	private bool 26(1532 1)
	{
		switch (1)
		{
		case 1532.ExtraDifficultyAdjust:
			this.15(1926.Enabled);
			return true;
		case 1532.ExtraNoNotelock:
			if (this.21 == null)
			{
				return false;
			}
			1931.1(!1931.Enabled);
			this.Refresh(true, 1931.Enabled);
			return true;
		case 1532.ExtraMirror:
			if (!this.25(1746.1747.Mirror))
			{
				return false;
			}
			this.16(1925.MirrorEnabled);
			return true;
		case 1532.ExtraRandom:
			if (!this.25(1746.1747.Random))
			{
				return false;
			}
			this.17(1925.RandomEnabled);
			return true;
		case 1532.ExtraAlternate:
			if (!this.25(1746.1747.Alternate))
			{
				return false;
			}
			this.23(1930.Alternate);
			return true;
		case 1532.ExtraSingleTap:
			if (!this.25(1746.1747.SingleTap))
			{
				return false;
			}
			this.23(1930.SingleTap);
			return true;
		case 1532.ExtraPractice:
			this.20(1936.Enabled);
			return true;
		case 1532.ExtraPitch:
			this.19(1933.Enabled);
			return true;
		default:
			return false;
		}
	}

	// Token: 0x06004104 RID: 16644 RVA: 0x00193EF8 File Offset: 0x001920F8
	internal override bool OnKeyDown(200 1)
	{
		if (1 == 200.F4)
		{
			this.Close(false);
			return true;
		}
		return this.26(1548.9(1, 1531.ExtraMods)) || base.OnKeyDown(1);
	}

	// Token: 0x06004105 RID: 16645 RVA: 0x00193F20 File Offset: 0x00192120
	public override void Update()
	{
		base.Update();
		if (1662.78 == 1677.Play && !this.27)
		{
			this.Close(true);
		}
	}

	// Token: 0x04002F7D RID: 12157
	private readonly 1433 18;

	// Token: 0x04002F7E RID: 12158
	private readonly 1433 19;

	// Token: 0x04002F7F RID: 12159
	private readonly 1452 20;

	// Token: 0x04002F80 RID: 12160
	private readonly 1433 21;

	// Token: 0x04002F81 RID: 12161
	private readonly 1433 22;

	// Token: 0x04002F82 RID: 12162
	private readonly 1433 23;

	// Token: 0x04002F83 RID: 12163
	private readonly 1433 24;

	// Token: 0x04002F84 RID: 12164
	private readonly 1433 25;

	// Token: 0x04002F85 RID: 12165
	private readonly 1433 26;

	// Token: 0x04002F86 RID: 12166
	private bool 27;

	// Token: 0x04002F87 RID: 12167
	private 1746.1747[] 28;

	// Token: 0x04002F88 RID: 12168
	private 1433[] 29;

	// Token: 0x04002F89 RID: 12169
	private 1433[] 30;

	// Token: 0x04002F8A RID: 12170
	private readonly bool 31;

	// Token: 0x020008E4 RID: 2276
	private enum 1747
	{
		// Token: 0x04002F8C RID: 12172
		Mirror,
		// Token: 0x04002F8D RID: 12173
		Random,
		// Token: 0x04002F8E RID: 12174
		Alternate,
		// Token: 0x04002F8F RID: 12175
		SingleTap
	}
}
