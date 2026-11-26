using System;
using System.Text;

// Token: 0x02000500 RID: 1280
[276]
internal sealed class 2501 : 2510
{
	// Token: 0x0600272E RID: 10030 RVA: 0x000C31A8 File Offset: 0x000C13A8
	internal 2501(2511 1, 2528 2, 2501.2502 3) : base(1, 2)
	{
		this.9 = 3;
		bool flag = this.9 == 2501.2502.Performance;
		2.8(2530.1("show_label", "Show label", "The name of the value above it.", !flag));
		2.8(2530.2("wireframe", "Wireframe opacity", "How visible the unlit digits behind the value are.", 0f, 0f, 1f, 0.05f, "0.##")).10 = true;
		2.8(2530.3("align", "Alignment", "How the caption and the value line up.", this.6(), new string[]
		{
			"left",
			"centre",
			"right"
		}, new string[]
		{
			"Left",
			"Centre",
			"Right"
		}));
		if (this.9 == 2501.2502.SongTime)
		{
			2.8(2530.3("show", "Show", "What of the song's time is counted.", "left", new string[]
			{
				"left",
				"passed",
				"progress"
			}, new string[]
			{
				"Time left",
				"Time passed",
				"Progress"
			}));
		}
	}

	// Token: 0x0600272F RID: 10031 RVA: 0x000C32E8 File Offset: 0x000C14E8
	private string 6()
	{
		switch (this.9)
		{
		case 2501.2502.UnstableRate:
		case 2501.2502.SongTime:
			return "centre";
		case 2501.2502.LongestCombo:
			return "left";
		}
		return "right";
	}

	// Token: 0x06002730 RID: 10032 RVA: 0x000C332C File Offset: 0x000C152C
	private string 7()
	{
		switch (this.9)
		{
		case 2501.2502.Performance:
			return "PP";
		case 2501.2502.IfFullCombo:
			return "IF FC";
		case 2501.2502.Stars:
			return "STARS";
		case 2501.2502.UnstableRate:
			return "UNSTABLE RATE";
		case 2501.2502.Bpm:
			return "BPM";
		case 2501.2502.Clicks:
			return "CLICKS/SEC";
		case 2501.2502.LongestCombo:
			return "LONGEST COMBO";
		}
		string a = this.2.10("show");
		if (a == "passed")
		{
			return "TIME";
		}
		if (!(a == "progress"))
		{
			return "TIME LEFT";
		}
		return "PROGRESS";
	}

	// Token: 0x06002731 RID: 10033 RVA: 0x000C33D0 File Offset: 0x000C15D0
	private string 8()
	{
		switch (this.9)
		{
		case 2501.2502.Performance:
			return this.1.Performance;
		case 2501.2502.IfFullCombo:
			return this.1.16;
		case 2501.2502.Stars:
			return this.1.15;
		case 2501.2502.UnstableRate:
			return this.1.9;
		case 2501.2502.Bpm:
			return this.1.10;
		case 2501.2502.Clicks:
			return this.1.11;
		case 2501.2502.LongestCombo:
			return this.1.17;
		}
		string a = this.2.10("show");
		if (a == "passed")
		{
			return this.1.13;
		}
		if (!(a == "progress"))
		{
			return this.1.12;
		}
		return this.1.14;
	}

	// Token: 0x17000255 RID: 597
	// (get) Token: 0x06002732 RID: 10034 RVA: 0x000C34AE File Offset: 0x000C16AE
	private bool NeedsPerformance
	{
		get
		{
			return this.9 == 2501.2502.Performance || this.9 == 2501.2502.IfFullCombo || this.9 == 2501.2502.Stars;
		}
	}

	// Token: 0x06002733 RID: 10035 RVA: 0x000C34CC File Offset: 0x000C16CC
	internal override void Build()
	{
		208 pivot = base.Pivot;
		string a = this.2.10("align");
		1065 <<EMPTY_NAME>> = (a == "left") ? 1065.TopLeft : ((a == "centre") ? 1065.TopCentre : 1065.TopRight);
		bool flag = this.2.11("show_label");
		float 2 = (this.9 == 2501.2502.Performance) ? this.1.7 : 0.5f;
		208 3 = pivot + new 208(0f, flag ? 10f : 0f);
		this.13 = this.8();
		this.10 = (flag ? base.1<1452>(2510.4(this.7(), 8.5f, pivot, <<EMPTY_NAME>>, 2501.8, true), true) : null);
		float num = this.2.12("wireframe");
		if (num > 0f)
		{
			this.12 = 2538.1(2501.9(this.13), (1376)6, <<EMPTY_NAME>>, 3);
			this.12.15 = 2;
			this.12.2 = 0.949f;
			this.12.16 = num;
			base.1<1353>(this.12, true);
		}
		else
		{
			this.12 = null;
		}
		this.11 = base.1<1353>(2538.1(this.13, (1376)6, <<EMPTY_NAME>>, 3), true);
		this.11.15 = 2;
	}

	// Token: 0x06002734 RID: 10036 RVA: 0x000C3638 File Offset: 0x000C1838
	private static string 9(string 1)
	{
		StringBuilder stringBuilder = new StringBuilder(1.Length);
		foreach (char c in 1)
		{
			stringBuilder.Append(char.IsDigit(c) ? '8' : c);
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06002735 RID: 10037 RVA: 0x000C3688 File Offset: 0x000C1888
	internal override void Update()
	{
		if (this.10 != null)
		{
			base.3(this.10, 8.5f);
		}
		bool flag = !this.NeedsPerformance || this.1.18;
		float <<EMPTY_NAME>> = (!flag) ? 0f : ((this.9 == 2501.2502.Performance && !this.1.19) ? 0.3f : 1f);
		this.11.16 = <<EMPTY_NAME>>;
		if (this.10 != null)
		{
			this.10.16 = (flag ? 1f : 0f);
			this.10.SetText(this.7());
		}
		if (this.12 != null)
		{
			this.12.16 = (flag ? this.2.12("wireframe") : 0f);
		}
		string text = this.8();
		if (text != this.13)
		{
			this.13 = text;
			this.11.SetText(text);
			1353 2 = this.12;
			if (2 == null)
			{
				return;
			}
			2.SetText(2501.9(text));
		}
	}

	// Token: 0x04001C2A RID: 7210
	private new const float 5 = 8.5f;

	// Token: 0x04001C2B RID: 7211
	private const float 6 = 10f;

	// Token: 0x04001C2C RID: 7212
	private const float 7 = 0.3f;

	// Token: 0x04001C2D RID: 7213
	private static readonly 198 8 = new 198(200, 200, 215);

	// Token: 0x04001C2E RID: 7214
	private readonly 2501.2502 9;

	// Token: 0x04001C2F RID: 7215
	private 1452 10;

	// Token: 0x04001C30 RID: 7216
	private 1353 11;

	// Token: 0x04001C31 RID: 7217
	private 1353 12;

	// Token: 0x04001C32 RID: 7218
	private string 13;

	// Token: 0x02000501 RID: 1281
	[276]
	internal enum 2502
	{
		// Token: 0x04001C34 RID: 7220
		Performance,
		// Token: 0x04001C35 RID: 7221
		IfFullCombo,
		// Token: 0x04001C36 RID: 7222
		Stars,
		// Token: 0x04001C37 RID: 7223
		UnstableRate,
		// Token: 0x04001C38 RID: 7224
		Bpm,
		// Token: 0x04001C39 RID: 7225
		Clicks,
		// Token: 0x04001C3A RID: 7226
		SongTime,
		// Token: 0x04001C3B RID: 7227
		LongestCombo
	}
}
