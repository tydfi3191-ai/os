using System;
using System.Collections.Generic;
using System.Globalization;

// Token: 0x020008DE RID: 2270
public sealed class 1744 : 1689
{
	// Token: 0x060040D4 RID: 16596 RVA: 0x001924FC File Offset: 0x001906FC
	public 1744() : base("Difficulty Adjust", true)
	{
		float num = (float)1662.70.1() / 2f;
		this.29 = 1743.Create(this.7);
		if (this.29 != null)
		{
			this.3 += 30f;
		}
		this.22 = new 1452(1744.13(), 14f, new 208(0f, this.3 - 30f), 208.Zero, 0.94f, true, 198.LightGray, true)
		{
			41 = (1376)7,
			49 = 1065.Centre
		};
		this.7.12(this.22);
		1928[] array = 1926.14(1925.SelectedPlayMode);
		for (int i = 0; i < array.Length; i++)
		{
			1928 <<EMPTY_NAME>> = array[i];
			1744.1745 row = new 1744.1745
			{
				1 = <<EMPTY_NAME>>
			};
			1452 3 = new 1452(1926.15(<<EMPTY_NAME>>), 16f, new 208(num - 230f, this.3), 0.94f, true, 198.White);
			3.49 = 1065.CentreLeft;
			this.7.12(3);
			row.2 = new 1429(this.7, (double)1926.17(<<EMPTY_NAME>>), (double)1926.18(<<EMPTY_NAME>>), (double)1744.18(<<EMPTY_NAME>>), new 208(num - 100f, this.3), 200);
			row.2.21 = 0.10000000149011612;
			this.17.Add(row.2);
			row.2.18 = delegate(bool 1)
			{
				if (!this.24 && 1926.Enabled)
				{
					1926.12(row.1, new float?((float)row.2.7));
					this.20();
				}
			};
			row.3 = new 1452(string.Empty, 16f, new 208(num + 115f, this.3), 0.94f, true, 198.White);
			row.3.49 = 1065.CentreLeft;
			row.3.52 = "Click to type the value";
			row.3.3(delegate(object 1, EventArgs 2)
			{
				this.16(row);
			});
			this.7.12(row.3);
			row.4 = new 1452("reset", 14f, new 208(num + 155f, this.3), 0.94f, true, 198.Gray);
			row.4.49 = 1065.CentreLeft;
			row.4.42 = new 1445(198.Gray, 198.White, 0, 100);
			row.4.3(delegate(object 1, EventArgs 2)
			{
				1926.12(row.1, null);
				this.20();
			});
			this.7.12(row.4);
			this.19.Add(row);
			this.3 += 35f;
		}
		this.20 = new 1364("Extended Limits (beyond normal 0-10 ranges)", 0.8f, new 208(num - 230f, this.3 - 8f), 0.94f, 1926.ExtendedLimits, 0f);
		this.20.9(delegate(object 1, bool 2)
		{
			1926.7(2);
			this.20();
		});
		this.7.14<1433>(this.20.2);
		this.3 += 35f;
		this.21 = new 1364("No Limits (beyond Extended Limits)", 0.8f, new 208(num - 230f, this.3 - 8f), 0.94f, 1926.NoLimits, 0f);
		this.21.9(delegate(object 1, bool 2)
		{
			1926.8(2);
			this.20();
		});
		this.7.14<1433>(this.21.2);
		this.3 += 45f;
		this.23 = base.7(1744.14(), 1744.15(), delegate(object 1, EventArgs 2)
		{
			1926.6(!1926.Enabled);
			this.20();
		}, false, false, true);
		base.7("Back", 198.Gray, null, true, false, true);
		base.3(delegate(object 1, EventArgs 2)
		{
			if (1662.78 == 1677.SelectPlay)
			{
				1662.25(new 1746());
			}
		});
	}

	// Token: 0x060040D5 RID: 16597 RVA: 0x00192983 File Offset: 0x00190B83
	private static bool 12()
	{
		return 1926.10(1925.SelectedPlayMode);
	}

	// Token: 0x060040D6 RID: 16598 RVA: 0x0019298F File Offset: 0x00190B8F
	private static string 13()
	{
		if (!1744.12())
		{
			return "Override a beatmap's difficulty settings.";
		}
		return "Past lazer's limits: the replay might not play on lazer.";
	}

	// Token: 0x060040D7 RID: 16599 RVA: 0x001929A3 File Offset: 0x00190BA3
	private new static string 14()
	{
		if (!1926.Enabled)
		{
			return "Enable Difficulty Adjust";
		}
		return "Disable Difficulty Adjust";
	}

	// Token: 0x060040D8 RID: 16600 RVA: 0x001929B7 File Offset: 0x00190BB7
	private new static 198 15()
	{
		if (!1926.Enabled)
		{
			return 198.YellowGreen;
		}
		return 198.OrangeRed;
	}

	// Token: 0x060040D9 RID: 16601 RVA: 0x001929CB File Offset: 0x00190BCB
	internal override void OnShown()
	{
		base.OnShown();
		this.20();
	}

	// Token: 0x060040DA RID: 16602 RVA: 0x001929DC File Offset: 0x00190BDC
	public override void Update()
	{
		base.Update();
		bool flag = 1555.2() == 199.Pressed;
		if (!flag || !this.4 || !1926.Enabled)
		{
			this.25 = null;
		}
		else if (!this.26)
		{
			this.25 = this.19.Find((1744.1745 1) => 1.2.25());
		}
		1744.1745 <<EMPTY_NAME>> = this.25;
		if (<<EMPTY_NAME>> != null)
		{
			<<EMPTY_NAME>>.2.27();
		}
		this.26 = flag;
		1743 2 = this.29;
		if (2 == null)
		{
			return;
		}
		2.1();
	}

	// Token: 0x060040DB RID: 16603 RVA: 0x00192A78 File Offset: 0x00190C78
	internal override bool OnKeyDown(200 1)
	{
		return (this.27 == null || !this.27.1()) && base.OnKeyDown(1);
	}

	// Token: 0x060040DC RID: 16604 RVA: 0x00192A98 File Offset: 0x00190C98
	private new void 16(1744.1745 1)
	{
		if (this.27 != null || !1926.Enabled)
		{
			return;
		}
		this.28 = 3;
		this.27 = new 1448(1926.2(3.1, 1744.18(3.1)), 16f, 3.3.17 - new 208(0f, 9f), 60f, 0.95f, false);
		this.27.4 = 6;
		this.27.3(delegate(1448 1, bool 2)
		{
			string text = (this.27.GetText() ?? string.Empty).Trim().Replace(',', '.');
			float value;
			if (2 && this.28.1 == 1928.ApproachRate && text.StartsWith("-inf", StringComparison.OrdinalIgnoreCase))
			{
				1926.12(this.28.1, new float?(-101f));
			}
			else if (2 && float.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out value))
			{
				1926.12(this.28.1, new float?(value));
			}
			this.17();
		});
		this.7.14<1433>(this.27.2);
		3.3.16 = 0f;
		this.20();
		1662.89.Schedule(delegate()
		{
			1448 4 = this.27;
			if (4 == null)
			{
				return;
			}
			4.16();
		}, true);
	}

	// Token: 0x060040DD RID: 16605 RVA: 0x00192B74 File Offset: 0x00190D74
	private new void 17()
	{
		1448 box = this.27;
		this.27 = null;
		this.28 = null;
		if (box != null)
		{
			1662.89.Schedule(delegate()
			{
				this.7.20<1433>(box.2);
				box.Dispose();
			}, true);
		}
		this.20();
	}

	// Token: 0x060040DE RID: 16606 RVA: 0x00192BCE File Offset: 0x00190DCE
	protected override void Dispose(bool 1)
	{
		1448 2 = this.27;
		if (2 != null)
		{
			2.Dispose();
		}
		base.Dispose(1);
	}

	// Token: 0x060040DF RID: 16607 RVA: 0x00192BE8 File Offset: 0x00190DE8
	private static float 18(1928 1)
	{
		float? num = 1926.11(1);
		if (num == null)
		{
			return 1744.19(1);
		}
		return num.GetValueOrDefault();
	}

	// Token: 0x060040E0 RID: 16608 RVA: 0x00192C14 File Offset: 0x00190E14
	private static float 19(1928 1)
	{
		1262 2 = 1272.5();
		if (2 == null)
		{
			return 5f;
		}
		switch (1)
		{
		case 1928.CircleSize:
			return 2.2;
		case 1928.DrainRate:
			return 2.3;
		case 1928.OverallDifficulty:
			return 2.4;
		default:
			return 2.1;
		}
	}

	// Token: 0x060040E1 RID: 16609 RVA: 0x00192C60 File Offset: 0x00190E60
	private void 20()
	{
		bool enabled = 1926.Enabled;
		this.24 = true;
		foreach (1744.1745 <<EMPTY_NAME>> in this.19)
		{
			float? num = 1926.11(<<EMPTY_NAME>>.1);
			<<EMPTY_NAME>>.2.22((double)1926.17(<<EMPTY_NAME>>.1), (double)1926.18(<<EMPTY_NAME>>.1), (double)1744.18(<<EMPTY_NAME>>.1));
			<<EMPTY_NAME>>.2.2(!enabled);
			for (int i = 0; i < <<EMPTY_NAME>>.2.13.Count; i++)
			{
				float num2 = (i == <<EMPTY_NAME>>.2.13.Count - 1) ? 0.5f : 1f;
				<<EMPTY_NAME>>.2.13[i].24(num2 * (enabled ? 1f : 0.3f), 140, (1046)0);
			}
			string text = 1926.2(<<EMPTY_NAME>>.1, 1744.18(<<EMPTY_NAME>>.1));
			<<EMPTY_NAME>>.3.SetText((num != null) ? text : (text + " (default)"));
			<<EMPTY_NAME>>.3.10 = enabled;
			<<EMPTY_NAME>>.3.24((<<EMPTY_NAME>> == this.28) ? 0f : ((!enabled) ? 0.3f : ((num != null) ? 1f : 0.6f)), 140, (1046)0);
			bool flag = enabled && num != null && <<EMPTY_NAME>> != this.28;
			<<EMPTY_NAME>>.4.10 = flag;
			<<EMPTY_NAME>>.4.24(flag ? 1f : 0f, 140, (1046)0);
		}
		this.24 = false;
		this.22.SetText(1744.13());
		this.22.6 = (1744.12() ? 198.Orange : 198.LightGray);
		this.23.4.SetText(1744.14());
		this.23.4(1744.15());
	}

	// Token: 0x04002F66 RID: 12134
	private const float 18 = 0.3f;

	// Token: 0x04002F67 RID: 12135
	private readonly List<1744.1745> 19 = new List<1744.1745>();

	// Token: 0x04002F68 RID: 12136
	private readonly 1364 20;

	// Token: 0x04002F69 RID: 12137
	private readonly 1364 21;

	// Token: 0x04002F6A RID: 12138
	private readonly 1452 22;

	// Token: 0x04002F6B RID: 12139
	private readonly 1361 23;

	// Token: 0x04002F6C RID: 12140
	private bool 24;

	// Token: 0x04002F6D RID: 12141
	private 1744.1745 25;

	// Token: 0x04002F6E RID: 12142
	private bool 26;

	// Token: 0x04002F6F RID: 12143
	private 1448 27;

	// Token: 0x04002F70 RID: 12144
	private 1744.1745 28;

	// Token: 0x04002F71 RID: 12145
	private readonly 1743 29;

	// Token: 0x020008DF RID: 2271
	private sealed class 1745
	{
		// Token: 0x04002F72 RID: 12146
		public 1928 1;

		// Token: 0x04002F73 RID: 12147
		public 1429 2;

		// Token: 0x04002F74 RID: 12148
		public 1452 3;

		// Token: 0x04002F75 RID: 12149
		public 1452 4;
	}
}
