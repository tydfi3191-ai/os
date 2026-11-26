using System;

// Token: 0x02000923 RID: 2339
public sealed class 1701 : 1689
{
	// Token: 0x170002D8 RID: 728
	// (get) Token: 0x06004286 RID: 17030 RVA: 0x0019ED3A File Offset: 0x0019CF3A
	internal static bool IsCapturingKey
	{
		get
		{
			return 1701.21 != null && 1701.21.4 && 1701.21.20 > 1532.None;
		}
	}

	// Token: 0x06004287 RID: 17031 RVA: 0x0019ED60 File Offset: 0x0019CF60
	public 1701() : base(1568.1(2679.Options_Input_KeyBindings), false)
	{
		this.18 = new 1417(new 207(110, 30, 420, 420), 208.Zero, false, 0f, 1545.Dialog);
	}

	// Token: 0x06004288 RID: 17032 RVA: 0x0019EDB4 File Offset: 0x0019CFB4
	internal override void Show()
	{
		this.7.47 = true;
		this.18.9(true);
		1354 <<EMPTY_NAME>> = new 1354(new EventHandler(this.15), false, true);
		this.7.14<1433>(<<EMPTY_NAME>>.1);
		this.24 = new 1452(string.Empty, 40f, new 208((float)(1662.70.1() / 2), 120f), 1f, true, 198.Orange);
		this.24.63(true);
		this.24.54(true);
		this.24.77 = new 208(1024f, 0f);
		this.24.75 = (1066)2;
		this.24.49 = 1065.Centre;
		this.19.12(this.24);
		this.22 = new 1452(1568.1(2679.OptionsBindKey_ChangeBinding), 40f, new 208((float)(1662.70.1() / 2), 240f), 1f, true, 198.White);
		this.22.63(true);
		this.22.77 = new 208(1024f, 0f);
		this.22.75 = (1066)2;
		this.22.49 = 1065.Centre;
		this.19.12(this.22);
		this.23 = new 1452(1568.1(2679.OptionsBindKey_ConflictsWarning), 30f, new 208((float)(1662.70.1() / 2), 360f), 1f, true, 198.LightYellow);
		this.23.63(true);
		this.23.77 = new 208(1024f, 0f);
		this.23.75 = (1066)2;
		this.23.49 = 1065.Centre;
		this.19.12(this.23);
		1433 2 = new 1433(1662.34, (1376)5, 1065.TopLeft, (1044)0, 208.Zero, 0.91f, true, new 198(0, 0, 0, 220), null);
		2.20 = new 208((float)1662.70.1, (float)1662.70.2);
		this.19.12(2);
		this.12();
		base.Show();
	}

	// Token: 0x06004289 RID: 17033 RVA: 0x0019F008 File Offset: 0x0019D208
	internal void 12()
	{
		1701.1702 rebuildListClosure = new 1701.1702();
		rebuildListClosure.1 = this;
		this.18.31(false, true);
		int num = 0;
		for (int i = 1; i < 1548.3.Length; i++)
		{
			1701.1703 <<EMPTY_NAME>> = new 1701.1703();
			<<EMPTY_NAME>>.2 = rebuildListClosure;
			string text = 1548.3[i];
			if (!text.StartsWith("__"))
			{
				bool flag = text[0] == '_';
				if (flag)
				{
					text = text.Substring(1);
				}
				<<EMPTY_NAME>>.1 = new 1452(text, (float)(flag ? 16 : 14), new 208(0f, (float)num), new 208(402f, 17f), flag ? 0.97f : 0.98f, true, 198.White, false);
				this.18.22.12(<<EMPTY_NAME>>.1);
				<<EMPTY_NAME>>.1.58(198.Black);
				if (flag)
				{
					<<EMPTY_NAME>>.1.62(198.YellowGreen);
					<<EMPTY_NAME>>.1.75 = (1066)2;
				}
				else
				{
					1701.1704 bindingRow = new 1701.1704();
					bindingRow.3 = <<EMPTY_NAME>>;
					bindingRow.3.1.72 = 2;
					bindingRow.3.1.60(198.LightGray);
					bindingRow.3.1.10 = true;
					bindingRow.3.1.35(delegate(object 1, EventArgs 2)
					{
						bindingRow.3.1.58(198.Gray);
						bindingRow.3.1.62(198.Black);
						bindingRow.3.1.88 = true;
					});
					bindingRow.3.1.37(new EventHandler(bindingRow.3.1));
					bindingRow.2 = text;
					bindingRow.1 = (1532)i;
					bindingRow.3.1.3(new EventHandler(bindingRow.1));
					bindingRow.3.1.11 = true;
					bindingRow.3.1.75 = (1066)1;
					1452 3 = new 1452(1548.10((1532)i), 12f, new 208(300f, (float)(num + 1)), new 208(100f, 15f), 1f, true, 198.Gold, false);
					3.58(new 198(0, 0, 0, 160));
					3.72 = 2;
					3.60(198.LightGray);
					3.75 = (1066)2;
					this.18.22.12(3);
				}
				num += 17;
			}
		}
		rebuildListClosure.2 = new 1452(1568.1(2679.Options_ResetAllBindings), 14f, new 208(0f, (float)num), new 208(402f, 17f), 0.98f, true, 198.White, false);
		rebuildListClosure.2.60(198.LightGray);
		rebuildListClosure.2.58(198.Black);
		rebuildListClosure.2.62(198.White);
		rebuildListClosure.2.10 = true;
		rebuildListClosure.2.35(delegate(object 1, EventArgs 2)
		{
			rebuildListClosure.2.58(198.Red);
			rebuildListClosure.2.88 = true;
		});
		rebuildListClosure.2.37(new EventHandler(rebuildListClosure.1));
		rebuildListClosure.2.3(delegate(object 1, EventArgs 2)
		{
			1548.14(true);
			rebuildListClosure.1.12();
			rebuildListClosure.1.18.25(0f, -0.99f);
		});
		rebuildListClosure.2.75 = (1066)2;
		num += 17;
		this.18.22.12(rebuildListClosure.2);
		this.18.17(new 208(510f, (float)num));
	}

	// Token: 0x0600428A RID: 17034 RVA: 0x0019F419 File Offset: 0x0019D619
	private void 13(1532 1, string 2)
	{
		this.24.SetText(2);
		this.22.FadeIn(200, (1046)0, 0);
		this.23.FadeIn(200, (1046)0, 0);
		this.20 = 1;
		1701.21 = this;
	}

	// Token: 0x0600428B RID: 17035 RVA: 0x0019F458 File Offset: 0x0019D658
	private new bool 14(200 1)
	{
		if (this.20 == 1532.None)
		{
			return false;
		}
		if (1548.7(this.20))
		{
			if (1548.5(1))
			{
				this.25 = 1;
				return true;
			}
			this.25 = 200.None;
			1 = 1548.6(1);
		}
		if (this.20 == 1532.OsuLeft && 1548.8(1532.OsuRight) == 1)
		{
			return false;
		}
		if (this.20 == 1532.OsuRight && 1548.8(1532.OsuLeft) == 1)
		{
			return false;
		}
		1548.1(this.20, 1);
		this.20 = 1532.None;
		this.12();
		return true;
	}

	// Token: 0x0600428C RID: 17036 RVA: 0x0019F4DE File Offset: 0x0019D6DE
	internal override bool OnKeyDown(200 1)
	{
		if (this.20 != 1532.None && 1 == 200.Escape)
		{
			this.20 = 1532.None;
			return true;
		}
		return base.OnKeyDown(1) || this.14(1);
	}

	// Token: 0x0600428D RID: 17037 RVA: 0x0019F508 File Offset: 0x0019D708
	internal override void DrawDialog()
	{
		base.DrawDialog();
		this.18.21();
		if (this.20 != 1532.None)
		{
			this.19.22();
		}
	}

	// Token: 0x0600428E RID: 17038 RVA: 0x0019F530 File Offset: 0x0019D730
	public override void Update()
	{
		base.Update();
		if (this.25 != 200.None && !1549.10(this.25))
		{
			200 <<EMPTY_NAME>> = this.25;
			this.25 = 200.None;
			if (this.20 != 1532.None)
			{
				1548.1(this.20, <<EMPTY_NAME>>);
				this.20 = 1532.None;
				this.12();
			}
		}
		this.18.Update();
	}

	// Token: 0x0600428F RID: 17039 RVA: 0x0019F592 File Offset: 0x0019D792
	protected override void Dispose(bool 1)
	{
		base.Dispose(1);
		this.19.Dispose();
		this.18.Dispose();
	}

	// Token: 0x06004290 RID: 17040 RVA: 0x0015D36C File Offset: 0x0015B56C
	private new void 15(object 1, EventArgs 2)
	{
		this.Close(false);
	}

	// Token: 0x040030A9 RID: 12457
	private 1417 18;

	// Token: 0x040030AA RID: 12458
	private 1436 19 = new 1436(true);

	// Token: 0x040030AB RID: 12459
	private 1532 20;

	// Token: 0x040030AC RID: 12460
	private static 1701 21;

	// Token: 0x040030AD RID: 12461
	private 1452 22;

	// Token: 0x040030AE RID: 12462
	private 1452 23;

	// Token: 0x040030AF RID: 12463
	private 1452 24;

	// Token: 0x040030B0 RID: 12464
	private 200 25;

	// Token: 0x02000924 RID: 2340
	public sealed class 1702
	{
		// Token: 0x06004291 RID: 17041 RVA: 0x0019F5B1 File Offset: 0x0019D7B1
		internal void 1(object 1, EventArgs 2)
		{
			this.2.58(198.Black);
			this.2.88 = true;
		}

		// Token: 0x040030B1 RID: 12465
		public 1701 1;

		// Token: 0x040030B2 RID: 12466
		public 1452 2;
	}

	// Token: 0x02000925 RID: 2341
	public sealed class 1703
	{
		// Token: 0x06004293 RID: 17043 RVA: 0x0019F5CF File Offset: 0x0019D7CF
		internal void 1(object 1, EventArgs 2)
		{
			this.1.58(198.Black);
			this.1.62(198.White);
			this.1.88 = true;
		}

		// Token: 0x040030B3 RID: 12467
		public 1452 1;

		// Token: 0x040030B4 RID: 12468
		public 1701.1702 2;
	}

	// Token: 0x02000926 RID: 2342
	public sealed class 1704
	{
		// Token: 0x06004295 RID: 17045 RVA: 0x0019F5FD File Offset: 0x0019D7FD
		internal void 1(object 1, EventArgs 2)
		{
			this.3.2.1.13(this.1, this.2);
		}

		// Token: 0x040030B5 RID: 12469
		public 1532 1;

		// Token: 0x040030B6 RID: 12470
		public string 2;

		// Token: 0x040030B7 RID: 12471
		public 1701.1703 3;
	}
}
