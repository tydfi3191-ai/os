using System;

// Token: 0x02000948 RID: 2376
internal sealed class 1710 : 1689
{
	// Token: 0x06004346 RID: 17222 RVA: 0x001A449C File Offset: 0x001A269C
	internal 1710() : base("Profile settings", true)
	{
		1710.<>c__DisplayClass9_0 CS$<>8__locals1 = new 1710.<>c__DisplayClass9_0();
		CS$<>8__locals1.<>4__this = this;
		float num = (float)1662.70.1() / 2f - 230f;
		float num2 = num + 210f;
		float num3 = this.3 - 20f;
		bool flag = !261.FullyOffline;
		CS$<>8__locals1.name = (1304.189.GetValue() ?? string.Empty);
		this.15("Plays that count", num, ref num3);
		this.14("Count my existing osu! scores", "Also count the scores taken over from osu!'s own score list.", 1304.12, num, num3);
		num3 += 22f;
		1364 <<EMPTY_NAME>> = this.14("Allow extra mods", "Count plays with nekiosu's extra mods.", 1304.23, num, num3);
		CS$<>8__locals1.extraMods = this.16("Choose mods (" + 1710.12().ToString() + " of 7)", num2, num3, delegate(object 1, EventArgs 2)
		{
			this.Close(false);
			1662.25(new 1708());
		}, 12f);
		CS$<>8__locals1.<.ctor>g__ShowExtraMods|1(1304.23.1());
		<<EMPTY_NAME>>.9(delegate(object 1, bool 2)
		{
			base.<.ctor>g__ShowExtraMods|1(2);
		});
		num3 += 22f;
		this.14("Count Relax plays", "Count plays with Relax.", 1304.24, num, num3).9(delegate(object 1, bool 2)
		{
			if (2 && !1304.31.1())
			{
				1304.31.2(true);
			}
		});
		this.17(num2, num3);
		num3 += 36f;
		this.15("Beatmaps that give pp", num, ref num3);
		this.14("Ranked", "Ranked and approved beatmaps.", 1304.36, num, num3);
		this.14("Loved", "Loved beatmaps.", 1304.37, num + 160f, num3);
		this.14("Qualified", "Beatmaps about to be ranked.", 1304.38, num + 320f, num3);
		num3 += 22f;
		this.14("Pending, WIP and graveyard", "Submitted beatmaps that are not ranked.", 1304.39, num, num3);
		this.14("Unknown", "Beatmaps that were never submitted, or whose status was never looked up.", 1304.40, num + 320f, num3);
		num3 += 22f;
		if (!flag)
		{
			this.18("Fully offline: the statuses are the last ones known until the game is online again.", 10f, num + 16f, num3, 1710.18);
			num3 += 20f;
		}
		num3 += 14f;
		if (flag)
		{
			this.15("Ranks", num, ref num3);
			this.14("Show my approximate osu!bancho rank", "In the user panel, the results screen and the top plays.", 1304.41, num, num3);
			num3 += 22f;
			this.14("Show my approximate country rank", "Next to the rank in the Discord bot's answers. Needs a country (below) and the osu! API set up; looked up in your country's ranking on the osu! API.", 1304.42, num, num3);
			num3 += 36f;
		}
		this.15("Profile", num, ref num3);
		this.18("Top plays shown", 12f, num + 16f, num3, 198.White);
		CS$<>8__locals1.shown = this.18(string.Empty, 12f, num2, num3, 198.White);
		CS$<>8__locals1.<.ctor>g__ShowCount|4();
		this.16("-", num2 + 40f, num3, delegate(object 1, EventArgs 2)
		{
			1710.13(-100);
			base.<.ctor>g__ShowCount|4();
		}, 16f);
		this.16("+", num2 + 60f, num3, delegate(object 1, EventArgs 2)
		{
			1710.13(100);
			base.<.ctor>g__ShowCount|4();
		}, 16f);
		num3 += 22f;
		bool flag2 = 2226.2(CS$<>8__locals1.name);
		this.18("Profile picture", 12f, num + 16f, num3, 198.White);
		string text = flag2 ? "chosen" : "none";
		float num4 = num2 + 1710.Width(this.18(text, 12f, num2, num3, 198.White), text) + 14f;
		string text2 = flag2 ? "change" : "add";
		1452 3 = this.16(text2, num4, num3, delegate(object 1, EventArgs 2)
		{
			2226.3(CS$<>8__locals1.name);
			CS$<>8__locals1.<>4__this.Close(false);
			1662.25(new 1710());
		}, 12f);
		if (flag2)
		{
			this.16("remove", num4 + 1710.Width(3, text2) + 14f, num3, delegate(object 1, EventArgs 2)
			{
				2226.Remove(CS$<>8__locals1.name);
				CS$<>8__locals1.<>4__this.Close(false);
				1662.25(new 1710());
			}, 12f).6 = new 198(byte.MaxValue, 140, 140);
		}
		num3 += 22f;
		this.18("Country", 12f, num + 16f, num3, 198.White);
		this.26 = new 1448(2210.11(CS$<>8__locals1.name) ?? string.Empty, 12f, new 208(num2, num3 + 8f - 8f), 40f, 0.95f, false);
		this.26.4 = 2;
		this.7.14<1433>(this.26.2);
		this.18("Two letters, e.g. US (its flag in the Discord bot).", 10f, num2 + 50f, num3, 1710.18);
		base.3(delegate(object 1, EventArgs 2)
		{
			string text3 = (CS$<>8__locals1.<>4__this.26.GetText() ?? string.Empty).Trim().ToUpperInvariant();
			if (text3 == (2210.11(CS$<>8__locals1.name) ?? string.Empty))
			{
				return;
			}
			if (text3.Length == 0 || 2204.1(text3))
			{
				2210.12(CS$<>8__locals1.name, text3);
				return;
			}
			1763.5("\"" + text3 + "\" is not a country code.", 198.Orange, 5000, null);
		});
		num3 += 22f;
		this.18("McOsu scores", 12f, num + 16f, num3, 198.White);
		this.16("import", num2, num3, delegate(object 1, EventArgs 2)
		{
			2220.Start();
		}, 12f);
		this.3 = num3 + 8f + 26f;
		base.7("Back", 198.Gray, delegate(object 1, EventArgs 2)
		{
			1662.25(new 1707(false));
		}, true, false, true);
	}

	// Token: 0x06004347 RID: 17223 RVA: 0x001A49FF File Offset: 0x001A2BFF
	protected override void Dispose(bool 1)
	{
		this.26.Dispose();
		base.Dispose(1);
	}

	// Token: 0x06004348 RID: 17224 RVA: 0x001A4A14 File Offset: 0x001A2C14
	private static int 12()
	{
		int num = 0;
		1313[] array = new 1313[]
		{
			1304.14,
			1304.15,
			1304.16,
			1304.17,
			1304.18,
			1304.19,
			1304.20
		};
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i].1())
			{
				num++;
			}
		}
		return num;
	}

	// Token: 0x06004349 RID: 17225 RVA: 0x001A4A7F File Offset: 0x001A2C7F
	private static void 13(int 1)
	{
		1304.45.7(Math.Max(100, Math.Min(1000, 1304.45.6() + 1)));
	}

	// Token: 0x0600434A RID: 17226 RVA: 0x001A4AA8 File Offset: 0x001A2CA8
	private new 1364 14(string 1, string 2, 1313 3, float 4, float 5)
	{
		1364 6 = new 1364(7, 0.8f, new 208(4, 5), 0.94f, 3.1(), 0f);
		6.6(8);
		6.9(delegate(object 1, bool 2)
		{
			3.2(2);
		});
		this.7.14<1433>(6.2);
		return 6;
	}

	// Token: 0x0600434B RID: 17227 RVA: 0x001A4B17 File Offset: 0x001A2D17
	private new void 15(string 1, float 2, ref float 3)
	{
		this.18(1, 12f, 2, 3, 1710.18);
		3 += 20f;
	}

	// Token: 0x0600434C RID: 17228 RVA: 0x001A4B38 File Offset: 0x001A2D38
	private new 1452 16(string 1, float 2, float 3, EventHandler 4, float 5 = 12f)
	{
		1452 6 = this.18(1, 5, 2, 3, 1710.19);
		6.10 = true;
		6.42 = new 1445(1456.Fade, 0.7f, 1f, 0, 100, (1046)0);
		6.3(4);
		return 6;
	}

	// Token: 0x0600434D RID: 17229 RVA: 0x001A4B74 File Offset: 0x001A2D74
	private new void 17(float 1, float 2)
	{
		1710.<>c__DisplayClass16_0 CS$<>8__locals1 = new 1710.<>c__DisplayClass16_0();
		string[] array = new string[]
		{
			"lazer",
			"no relax nerfs",
			"Akatsuki"
		};
		string[] array2 = new string[]
		{
			"osu!lazer's relax pp.",
			"osu!lazer's pp without Relax.",
			"Akatsuki's relax pp."
		};
		4 += 1710.Width(this.18("Relax pp:", 12f, 4, 5, 1710.18), "Relax pp:") + 14f;
		CS$<>8__locals1.choices = new 1452[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			int value = i;
			1452 3 = this.16(array[i], 4, 5, delegate(object 1, EventArgs 2)
			{
				1304.25.7(value);
				CS$<>8__locals1.<AddRelaxSystemChoices>g__ShowChoices|0();
			}, 12f);
			3.52 = array2[i];
			CS$<>8__locals1.choices[i] = 3;
			4 += 1710.Width(3, array[i]) + 14f;
		}
		CS$<>8__locals1.<AddRelaxSystemChoices>g__ShowChoices|0();
	}

	// Token: 0x0600434E RID: 17230 RVA: 0x001A4C78 File Offset: 0x001A2E78
	private static float Width(1452 1, string 2)
	{
		float x = 1.GetTextSize().X;
		if (x <= 0f)
		{
			return (float)2.Length * 5.5f;
		}
		return x;
	}

	// Token: 0x0600434F RID: 17231 RVA: 0x001A4CA8 File Offset: 0x001A2EA8
	private 1452 18(string 1, float 2, float 3, float 4, 198 5)
	{
		1452 6 = new 1452(1, 2, new 208(3, 4 + 8f), 0.94f, true, 5);
		6.49 = 1065.CentreLeft;
		this.7.12(6);
		return 6;
	}

	// Token: 0x04003143 RID: 12611
	private static readonly 198 18 = new 198(170, 176, 192);

	// Token: 0x04003144 RID: 12612
	private static readonly 198 19 = new 198(79, 179, 246);

	// Token: 0x04003145 RID: 12613
	private const float 20 = 8f;

	// Token: 0x04003146 RID: 12614
	private const float 21 = 16f;

	// Token: 0x04003147 RID: 12615
	private const float 22 = 22f;

	// Token: 0x04003148 RID: 12616
	private const float 23 = 14f;

	// Token: 0x04003149 RID: 12617
	private const float 24 = 20f;

	// Token: 0x0400314A RID: 12618
	private const float 25 = 14f;

	// Token: 0x0400314B RID: 12619
	private readonly 1448 26;
}
