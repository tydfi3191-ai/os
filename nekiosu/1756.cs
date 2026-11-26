using System;
using System.Windows.Forms;

// Token: 0x020008F5 RID: 2293
public sealed class 1756 : 1689
{
	// Token: 0x0600415B RID: 16731 RVA: 0x00196048 File Offset: 0x00194248
	public 1756() : base("Practice", true)
	{
		float num = (float)1662.70.1() / 2f;
		this.3 += 16f;
		this.14("Open timeline with " + 1756.12() + ", Tap Rclick to add a checkpoint, drag Rclick to create a segment.", this.3 - 54f);
		200 <<EMPTY_NAME>> = 1548.8(1532.Skip);
		this.14(string.Concat(new string[]
		{
			"Click to jump on timeline, ",
			(<<EMPTY_NAME>> == 200.Space) ? "Space" : 1548.11(<<EMPTY_NAME>>),
			" to play, ",
			1756.13(),
			" to go between them,"
		}), this.3 - 38f);
		this.14(1548.10(1532.PracticeRename) + " to rename, CTRL+click to autostart at the checkpoint.", this.3 - 22f);
		1452 4 = new 1452("Checkpoint delay", 16f, new 208(num - 230f, this.3), 0.94f, true, 198.White);
		4.49 = 1065.CentreLeft;
		this.7.12(4);
		this.20 = new 1373(this.7, string.Empty, new 208(num - 100f, this.3 - 9f), 200f, 0.96f);
		foreach (int num2 in 1756.18)
		{
			this.20.10((num2 == 0) ? "None" : (((double)num2 / 1000.0).ToString("0.0", 1662.18) + " s"), num2);
		}
		this.20.18(1756.16(1304.26.6()), true);
		this.20.1(delegate(object 1, EventArgs 2)
		{
			object obj = this.20.18;
			if (obj is int)
			{
				int 5 = (int)obj;
				1304.26.7(5);
			}
		});
		this.3 += 35f;
		1364 3 = new 1364("Loop segments (start one again at its end)", 0.8f, new 208(num - 230f, this.3 - 8f), 0.94f, 1304.27.1(), 0f);
		3.9(delegate(object 1, bool 2)
		{
			1304.27.2(2);
		});
		this.7.14<1433>(3.2);
		this.3 += 35f;
		this.21 = new 1452(string.Empty, 14f, new 208(0f, this.3), 208.Zero, 0.94f, true, 198.White, true)
		{
			41 = (1376)7,
			49 = 1065.Centre
		};
		this.7.12(this.21);
		this.3 += 30f;
		this.19 = base.7(1756.18(), 1756.19(), delegate(object 1, EventArgs 2)
		{
			1936.1(!1936.Enabled);
			this.Refresh();
		}, false, false, true);
		base.7("Copy", 198.DodgerBlue, delegate(object 1, EventArgs 2)
		{
			1756.Copy();
		}, false, true, true).6("Copies its checkpoints so you can share them on Discord.");
		this.3 -= 50f;
		base.7("Paste", 198.DodgerBlue, delegate(object 1, EventArgs 2)
		{
			this.Paste();
		}, false, true, false).6("Adds checkpoints from your clipboard.");
		base.7("Clear checkpoints and segments", 198.OrangeRed, delegate(object 1, EventArgs 2)
		{
			this.15();
		}, false, false, true);
		base.7("Back", 198.Gray, null, true, false, true);
		base.3(delegate(object 1, EventArgs 2)
		{
			if (!this.22 && 1662.78 == 1677.SelectPlay)
			{
				1662.25(new 1746());
			}
		});
	}

	// Token: 0x0600415C RID: 16732 RVA: 0x00196424 File Offset: 0x00194624
	private static string 12()
	{
		200 <<EMPTY_NAME>> = 1548.8(1532.PracticeHold);
		if (<<EMPTY_NAME>> == 200.RightShift)
		{
			return "Right Shift";
		}
		if (<<EMPTY_NAME>> != 200.LeftShift)
		{
			return 1548.11(<<EMPTY_NAME>>);
		}
		return "Left Shift";
	}

	// Token: 0x0600415D RID: 16733 RVA: 0x0019645C File Offset: 0x0019465C
	private static string 13()
	{
		200 <<EMPTY_NAME>> = 1548.8(1532.PracticePreviousCheckpoint);
		200 2 = 1548.8(1532.PracticeNextCheckpoint);
		if (<<EMPTY_NAME>> != 200.Left || 2 != 200.Right)
		{
			return 1548.11(<<EMPTY_NAME>>) + "/" + 1548.11(2);
		}
		return "Left/Right arrow";
	}

	// Token: 0x0600415E RID: 16734 RVA: 0x001964A0 File Offset: 0x001946A0
	private new void 14(string 1, float 2)
	{
		this.7.12(new 1452(1, 14f, new 208(0f, 2), 208.Zero, 0.94f, true, 198.LightGray, true)
		{
			41 = (1376)7,
			49 = 1065.Centre
		});
	}

	// Token: 0x170002D7 RID: 727
	// (get) Token: 0x0600415F RID: 16735 RVA: 0x001964ED File Offset: 0x001946ED
	private static string BeatmapHash
	{
		get
		{
			1262 <<EMPTY_NAME>> = 1272.5();
			if (<<EMPTY_NAME>> == null)
			{
				return null;
			}
			return <<EMPTY_NAME>>.23;
		}
	}

	// Token: 0x06004160 RID: 16736 RVA: 0x00196500 File Offset: 0x00194700
	private static void Copy()
	{
		1262 <<EMPTY_NAME>> = 1272.5();
		string text = (<<EMPTY_NAME>> == null) ? null : 1935.20(<<EMPTY_NAME>>.23, string.Concat(new string[]
		{
			<<EMPTY_NAME>>.7,
			" - ",
			<<EMPTY_NAME>>.10,
			" (",
			<<EMPTY_NAME>>.43,
			") [",
			<<EMPTY_NAME>>.89,
			"]"
		}), <<EMPTY_NAME>>.25);
		if (text == null)
		{
			1756.17("This beatmap has no checkpoints or segments");
			return;
		}
		try
		{
			Clipboard.SetText(text);
			1756.17("This beatmap's checkpoints and segments copied");
		}
		catch (Exception)
		{
			1756.17("The clipboard could not be used");
		}
	}

	// Token: 0x06004161 RID: 16737 RVA: 0x001965B8 File Offset: 0x001947B8
	private void Paste()
	{
		string text;
		try
		{
			text = Clipboard.GetText();
		}
		catch (Exception)
		{
			1756.17("The clipboard could not be used");
			return;
		}
		string text2;
		int? num = 1935.Import(1756.BeatmapHash, text, out text2);
		1756.17((num != null) ? ((num.Value == 1) ? "1 checkpoint or segment added" : (num.Value.ToString() + " checkpoints and segments added")) : text2);
		this.Refresh();
	}

	// Token: 0x06004162 RID: 16738 RVA: 0x0019663C File Offset: 0x0019483C
	private new void 15()
	{
		if (1935.Get(1756.BeatmapHash).Count == 0 && 1935.1(1756.BeatmapHash).Count == 0)
		{
			1756.17("This beatmap has no checkpoints or segments");
			return;
		}
		string beatmapHash = 1756.BeatmapHash;
		this.22 = true;
		this.Close(false);
		1662.25(new 1688("Clear this beatmap's checkpoints and segments (and their names)?", delegate(object 1, EventArgs 2)
		{
			1935.19(beatmapHash);
			1662.25(new 1756());
		}, delegate(object 1, EventArgs 2)
		{
			1662.25(new 1756());
		}, true));
	}

	// Token: 0x06004163 RID: 16739 RVA: 0x001966D0 File Offset: 0x001948D0
	private new static int 16(int 1)
	{
		int num = 1756.18[0];
		foreach (int num2 in 1756.18)
		{
			if (Math.Abs(num2 - 1) < Math.Abs(num - 1))
			{
				num = num2;
			}
		}
		return num;
	}

	// Token: 0x06004164 RID: 16740 RVA: 0x00196712 File Offset: 0x00194912
	private new static void 17(string 1)
	{
		1763.2(1, 1500, (1389)0);
	}

	// Token: 0x06004165 RID: 16741 RVA: 0x00196720 File Offset: 0x00194920
	private static string 18()
	{
		if (!1936.Enabled)
		{
			return "Enable Practice";
		}
		return "Disable Practice";
	}

	// Token: 0x06004166 RID: 16742 RVA: 0x00196734 File Offset: 0x00194934
	private static 198 19()
	{
		if (!1936.Enabled)
		{
			return 198.YellowGreen;
		}
		return 198.OrangeRed;
	}

	// Token: 0x06004167 RID: 16743 RVA: 0x00196748 File Offset: 0x00194948
	internal override void OnShown()
	{
		base.OnShown();
		this.Refresh();
	}

	// Token: 0x06004168 RID: 16744 RVA: 0x00196758 File Offset: 0x00194958
	private void Refresh()
	{
		this.19.4.SetText(1756.18());
		this.19.4(1756.19());
		int count = 1935.Get(1756.BeatmapHash).Count;
		int count2 = 1935.1(1756.BeatmapHash).Count;
		1934? <<EMPTY_NAME>> = 1935.13(1756.BeatmapHash);
		string text;
		if (<<EMPTY_NAME>> != null)
		{
			string str = ", plays start at ";
			1934 value = <<EMPTY_NAME>>.Value;
			string str2;
			if (value.2 == null)
			{
				str2 = 2552.18(<<EMPTY_NAME>>.Value.1);
			}
			else
			{
				value = <<EMPTY_NAME>>.Value;
				string str3 = 2552.18(value.2.Value.1);
				string str4 = " - ";
				value = <<EMPTY_NAME>>.Value;
				str2 = str3 + str4 + 2552.18(value.2.Value.2);
			}
			text = str + str2;
		}
		else
		{
			text = string.Empty;
		}
		string text2 = text;
		this.21.SetText(string.Concat(new string[]
		{
			"This beatmap: ",
			(count == 1) ? "1 checkpoint" : (count.ToString() + " checkpoints"),
			", ",
			(count2 == 1) ? "1 segment" : (count2.ToString() + " segments"),
			text2
		}));
	}

	// Token: 0x06004169 RID: 16745 RVA: 0x001968AA File Offset: 0x00194AAA
	protected override void Dispose(bool 1)
	{
		this.20.17();
		base.Dispose(1);
	}

	// Token: 0x04002FC1 RID: 12225
	private static readonly int[] 18 = new int[]
	{
		0,
		500,
		1000,
		1500,
		2000,
		3000
	};

	// Token: 0x04002FC2 RID: 12226
	private readonly 1361 19;

	// Token: 0x04002FC3 RID: 12227
	private readonly 1373 20;

	// Token: 0x04002FC4 RID: 12228
	private readonly 1452 21;

	// Token: 0x04002FC5 RID: 12229
	private bool 22;
}
