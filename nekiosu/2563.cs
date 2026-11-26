using System;

// Token: 0x020004F8 RID: 1272
[276]
public sealed class 2563 : 1350
{
	// Token: 0x060026E3 RID: 9955 RVA: 0x000C0C44 File Offset: 0x000BEE44
	public 2563(1803 1) : base(1)
	{
		this.Initialize();
		this.4();
	}

	// Token: 0x060026E4 RID: 9956 RVA: 0x000C0C95 File Offset: 0x000BEE95
	internal int 1()
	{
		return 1662.70.1();
	}

	// Token: 0x060026E5 RID: 9957 RVA: 0x000C0CA1 File Offset: 0x000BEEA1
	private int 2()
	{
		return 1662.70.2() - (this.7 ? this.3 : 45);
	}

	// Token: 0x060026E6 RID: 9958 RVA: 0x0001702D File Offset: 0x0001522D
	public bool 3()
	{
		return true;
	}

	// Token: 0x060026E7 RID: 9959 RVA: 0x000C0CC0 File Offset: 0x000BEEC0
	private void 4()
	{
		bool flag = this.3();
		if (1272.5().111)
		{
			this.8.23((double)(2648.35 = (1272.5().112 ?? 1304.141.6())), true, false);
			1364 <<EMPTY_NAME>> = this.12;
			bool flag2 = (!flag && !1272.5().106) || !1272.5().109;
			2648.2(flag2);
			<<EMPTY_NAME>>.7(!flag2);
			1364 2 = this.13;
			bool flag3 = 1304.134 && !1272.5().110;
			2648.4(flag3);
			2.7(!flag3);
			this.14.7(2630.13 = (flag && 1272.5().108));
			this.15.7(1226.2 = (flag && 1272.5().107));
		}
		else
		{
			this.8.23((double)(2648.35 = 1304.141.6()), true, false);
			1364 3 = this.12;
			bool flag4 = 1304.117;
			2648.2(flag4);
			3.7(!flag4);
			1364 4 = this.13;
			bool flag5 = 1304.134;
			2648.4(flag5);
			4.7(!flag5);
			this.14.7(2630.13 = 1304.94);
			this.15.7(1226.2 = 1304.93);
		}
		this.19();
	}

	// Token: 0x060026E8 RID: 9960 RVA: 0x000C0E6C File Offset: 0x000BF06C
	internal void 5()
	{
		if (2486.7 != null)
		{
			2648 <<EMPTY_NAME>> = 2486.7.34;
			if (<<EMPTY_NAME>> != null)
			{
				1364 2 = this.12;
				2.2(2.1() & (this.12.4() || <<EMPTY_NAME>>.37));
				this.13.2(1304.134 && (this.13.4() || <<EMPTY_NAME>>.30.Count > 0));
			}
		}
	}

	// Token: 0x060026E9 RID: 9961 RVA: 0x000C0EF0 File Offset: 0x000BF0F0
	protected override void Dispose(bool 1)
	{
		if (this.18)
		{
			1272.3.FindAll(new Predicate<1262>(2563.2564.visualSettingsPanelCallbacks.1)).ForEach(new Action<1262>(this.25));
		}
		1535.41((1082)1, new 1081(this.6), 1545.Highest);
		1535.41((1082)0, new 1081(this.7), 1545.Highest);
		this.4.Dispose();
		this.8.Dispose();
		this.9.Dispose();
		this.10.Dispose();
		if (this.11)
		{
			1242.Save();
		}
		base.Dispose(1);
		2483.Reset();
		if (this.16)
		{
			1455.8(true);
			2486.57 = false;
		}
		if (this.17)
		{
			1226.57();
		}
		2648.2(true);
		2648.4(1304.134);
		2630.13 = false;
		1226.2 = false;
		2648.35 = 30;
	}

	// Token: 0x060026EA RID: 9962 RVA: 0x000C0FE4 File Offset: 0x000BF1E4
	public override void Initialize()
	{
		int num = this.2() + 45;
		this.19 = 1555.21();
		this.5 = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, new 208(0f, (float)num), 0.68f, true, this.3() ? new 198(0, 78, 155) : 198.DarkGray, null);
		this.5.15 = 1.6f;
		this.5.20 = new 208((float)this.1(), 3f);
		this.4.12(this.5);
		num += 3;
		this.5 = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, new 208(0f, (float)num), 0.68f, true, new 198(0, 0, 0, 180), null);
		this.5.15 = 1.6f;
		this.5.20 = new 208((float)this.1(), (float)this.3);
		this.4.12(this.5);
		1436 <<EMPTY_NAME>> = this.4;
		1452 17 = new 1452("Visual", 24f, new 208((float)2563.21, (float)num), 208.Zero, 0.99f, true, 198.LightBlue, true);
		17.54(true);
		<<EMPTY_NAME>>.12(17);
		num += 15;
		1436 3 = this.4;
		1452 4 = new 1452("Settings", 22f, new 208((float)(2563.22 + 50), (float)num), 208.Zero, 1f, true, 198.White, true);
		4.54(true);
		3.12(4);
		bool flag = this.3();
		if (!this.3())
		{
			1436 5 = this.4;
			1452 6 = new 1452(1568.1(2679.FunSpoiler_PlayFirst), 15f, new 208((float)(1662.70.1() / 2), (float)num), new 208(480f, 0f), 1f, true, 198.OrangeRed, true);
			6.64(true);
			6.49 = 1065.Centre;
			6.54(true);
			6.74 = false;
			5.12(6);
		}
		num += 30;
		1436 7 = this.4;
		1452 8 = new 1452(1568.1(2679.FunSpoiler_BackgroundDim), 10f, new 208((float)(2563.21 + 20), (float)num), new 208((float)this.1(), 20f), 0.99f, true, 198.White, true);
		8.54(true);
		8.74 = false;
		7.12(8);
		1436 9 = this.4;
		1452 10 = new 1452(1568.1(2679.FunSpoiler_Toggles), 10f, new 208((float)(2563.21 + 20 + 240), (float)num), new 208((float)this.1(), 20f), 0.99f, true, flag ? 198.White : 198.DarkGray, true);
		10.54(true);
		10.74 = false;
		9.12(10);
		num += 20;
		this.8 = new 1429(this.4, 0.0, (double)(flag ? 100 : 60), (double)(1272.5().112 ?? 1304.141.6()), new 208((float)(2563.21 + 20), (float)num), 200);
		1429 11 = this.8;
		11.18 = (1429.1432)Delegate.Combine(11.18, new 1429.1432(this.13));
		this.19();
		int num2 = num + 25;
		1452 12 = new 1452("Gamma", 10f, new 208((float)(2563.21 + 20), (float)num2), new 208((float)this.1(), 20f), 0.99f, true, 198.White, true);
		12.54(true);
		12.74 = false;
		this.4.12(12);
		1452 13 = new 1452("edit by AR", 10f, new 208((float)(2563.21 + 20) + 12.GetTextSize().X + 8f, (float)num2), new 208((float)this.1(), 20f), 0.99f, true, 198.Gray, true);
		13.74 = false;
		13.10 = true;
		13.42 = new 1445(198.Gray, 198.White, 0, 100);
		13.3(delegate(object 1, EventArgs 2)
		{
			if (!2493.IsOpen)
			{
				1662.25(new 2493(null));
			}
		});
		this.4.12(13);
		this.9 = new 1429(this.4, 0.1, 3.0, 1383.1(), new 208((float)(2563.21 + 20), (float)(num2 + 20)), 200);
		this.9.18 = (1429.1432)Delegate.Combine(this.9.18, new 1429.1432(this.14));
		1452 14 = new 1452("reset", 10f, new 208((float)(2563.21 + 232), (float)(num2 + 20)), 0.99f, true, 198.Gray);
		14.49 = 1065.CentreLeft;
		14.10 = true;
		14.42 = new 1445(198.Gray, 198.White, 0, 100);
		14.3(delegate(object 1, EventArgs 2)
		{
			1355.Set(1272.5(), (1383.2() != null) ? null : new double?(1.0));
			1355.Save();
			this.15();
		});
		this.4.12(14);
		this.15();
		int num3 = num2 + 45;
		1452 15 = new 1452("Hitsound volume", 10f, new 208((float)(2563.21 + 20), (float)num3), new 208((float)this.1(), 20f), 0.99f, true, 198.White, true);
		15.54(true);
		15.74 = false;
		this.4.12(15);
		this.10 = new 1429(this.4, 0.0, 300.0, (double)1242.Get(1272.5()), new 208((float)(2563.21 + 20), (float)(num3 + 20)), 200);
		this.10.18 = (1429.1432)Delegate.Combine(this.10.18, new 1429.1432(this.16));
		this.17();
		this.12 = new 1364(1568.1(2679.FunSpoiler_Storyboard), 0.8f, new 208((float)(2563.21 + 20 + 240), (float)num), 0.99f, false, 0f);
		this.12.2(flag || 1272.5().106);
		this.12.9(new 1183(this.11));
		this.4.14<1433>(this.12.2);
		this.13 = new 1364(1568.1(2679.FunSpoiler_Video), 0.8f, new 208((float)(2563.21 + 40 + 480), (float)num), 0.99f, false, 0f);
		this.13.2(false);
		this.13.9(new 1183(this.12));
		this.4.14<1433>(this.13.2);
		num += 20;
		this.14 = new 1364(1568.1(2679.FunSpoiler_Skin), 0.8f, new 208((float)(2563.21 + 20 + 240), (float)num), 0.99f, false, 0f);
		this.14.9(new 1183(this.10));
		this.14.2(flag);
		this.4.14<1433>(this.14.2);
		if (1535.1())
		{
			1364 16 = new 1364("Hit markers", 0.8f, new 208((float)(2563.21 + 40 + 480), (float)num), 0.99f, 1304.59.1(), 0f);
			16.6("An X where each key was pressed: green K1, orange K2");
			16.9(delegate(object 1, bool 2)
			{
				1304.59.2(2);
			});
			this.4.14<1433>(16.2);
		}
		num += 20;
		this.15 = new 1364(1568.1(2679.FunSpoiler_Hitsounds), 0.8f, new 208((float)(2563.21 + 20 + 240), (float)num), 0.99f, false, 0f);
		this.15.9(new 1183(this.9));
		this.15.2(flag);
		this.4.14<1433>(this.15.2);
		this.4.10 = false;
		this.8.21 = 5.0;
		this.9.21 = 0.05;
		this.10.21 = 5.0;
		1535.40((1082)1, new 1081(this.6), 1545.Highest, (1559)0);
		1535.40((1082)0, new 1081(this.7), 1545.Highest, (1559)0);
		base.Initialize();
	}

	// Token: 0x060026EB RID: 9963 RVA: 0x000C192F File Offset: 0x000BFB2F
	private bool 6(object 1, EventArgs 2)
	{
		return this.8(1);
	}

	// Token: 0x060026EC RID: 9964 RVA: 0x000C1938 File Offset: 0x000BFB38
	private bool 7(object 1, EventArgs 2)
	{
		return this.8(-1);
	}

	// Token: 0x060026ED RID: 9965 RVA: 0x000C1941 File Offset: 0x000BFB41
	private bool 8(int 1)
	{
		return this.7 && 1662.92 == null && (this.8.26(1) || this.9.26(1) || this.10.26(1));
	}

	// Token: 0x060026EE RID: 9966 RVA: 0x000C197E File Offset: 0x000BFB7E
	private void 9(object 1, bool 2)
	{
		this.20();
		1272.5().107 = 2;
		this.17 = true;
		this.18 = true;
		this.21();
	}

	// Token: 0x060026EF RID: 9967 RVA: 0x000C19A8 File Offset: 0x000BFBA8
	private void 10(object 1, bool 2)
	{
		this.20();
		1272.5().108 = 2;
		this.16 = true;
		this.18 = true;
		if (2486.109 && 2486.7 != null)
		{
			2483.Apply(2486.7, 2);
			return;
		}
		this.21();
	}

	// Token: 0x060026F0 RID: 9968 RVA: 0x000C19F4 File Offset: 0x000BFBF4
	private void 11(object 1, bool 2)
	{
		this.20();
		1272.5().109 = 2;
		2648.2(!2);
		this.18 = true;
	}

	// Token: 0x060026F1 RID: 9969 RVA: 0x000C1A17 File Offset: 0x000BFC17
	private void 12(object 1, bool 2)
	{
		this.20();
		1272.5().110 = 2;
		2648.4(!2);
		this.18 = true;
		this.21();
	}

	// Token: 0x060026F2 RID: 9970 RVA: 0x000C1A40 File Offset: 0x000BFC40
	private void 13(bool 1)
	{
		this.20();
		2648.35 = (int)this.8.7;
		if (2648.35 != 1304.141.6())
		{
			1272.5().112 = new int?(2648.35);
		}
		this.18 = true;
		this.19();
	}

	// Token: 0x060026F3 RID: 9971 RVA: 0x000C1A98 File Offset: 0x000BFC98
	private void 14(bool 1)
	{
		1355.Set(1272.5(), new double?(Math.Round(this.9.7 * 20.0) / 20.0));
		if (1)
		{
			1355.Save();
		}
		this.18();
	}

	// Token: 0x060026F4 RID: 9972 RVA: 0x000C1AE8 File Offset: 0x000BFCE8
	private void 15()
	{
		double num = 1383.1();
		double? num2 = 1383.3();
		if (Math.Abs(num - this.25) <= 0.0001)
		{
			double? num3 = num2;
			double? num4 = this.26;
			if (num3.GetValueOrDefault() == num4.GetValueOrDefault() & num3 != null == (num4 != null))
			{
				return;
			}
		}
		this.9.23(num, true, false);
		this.25 = num;
		this.26 = num2;
		this.18();
	}

	// Token: 0x060026F5 RID: 9973 RVA: 0x000C1B68 File Offset: 0x000BFD68
	private void 16(bool 1)
	{
		1242.Set(1272.5(), (int)(Math.Round(this.10.7 / 5.0) * 5.0));
		this.11 = true;
		if (1)
		{
			1242.Save();
		}
		this.17();
	}

	// Token: 0x060026F6 RID: 9974 RVA: 0x000C1BB9 File Offset: 0x000BFDB9
	private void 17()
	{
		this.10.8(string.Format("Hitsound volume for this beatmap: {0}% of its own", 1242.Get(1272.5())));
	}

	// Token: 0x060026F7 RID: 9975 RVA: 0x000C1BE0 File Offset: 0x000BFDE0
	private void 18()
	{
		double? num = 1383.3();
		this.9.8(string.Format(1662.18, "Gamma: {0:0.00}x", 1383.1()) + ((num != null) ? (" (AR " + 1383.4(num.Value) + ")") : string.Empty));
	}

	// Token: 0x060026F8 RID: 9976 RVA: 0x000C1C47 File Offset: 0x000BFE47
	private void 19()
	{
		this.8.8(string.Format(1568.1(2679.FunSpoiler_Dim_Tooltip), 2648.35, this.8.8));
	}

	// Token: 0x060026F9 RID: 9977 RVA: 0x000C1C80 File Offset: 0x000BFE80
	private void 20()
	{
		if (!1272.5().111)
		{
			1272.5().111 = true;
			1272.5().110 = !1304.134;
			1272.5().109 = !1304.117;
			1272.5().108 = 1304.94;
			1272.5().107 = 1304.93;
		}
	}

	// Token: 0x060026FA RID: 9978 RVA: 0x000C1CFA File Offset: 0x000BFEFA
	private void 21()
	{
		if (!2486.109)
		{
			2486.136 = true;
			return;
		}
		1763.2(1568.1(2679.FunSpoiler_Restart), 1000, (1389)0);
	}

	// Token: 0x060026FB RID: 9979 RVA: 0x000C1D20 File Offset: 0x000BFF20
	internal void 22(bool 1, bool 2)
	{
		if (1662.47)
		{
			return;
		}
		if (this.6 == 0)
		{
			this.4.28.ForEach(delegate(1371 1)
			{
				1452 4 = 1 as 1452;
				if (4 != null && 4.47 == null)
				{
					4.GetTextSize();
				}
			});
		}
		this.23 = 3;
		this.6 = 1662.33;
		if (3)
		{
			this.6 += 500;
		}
		if (!this.7)
		{
			if (2)
			{
				this.4.28.ForEach(new Action<1371>(this.26));
			}
			else
			{
				this.4.28.ForEach(new Action<1371>(this.27));
			}
			this.7 = true;
		}
	}

	// Token: 0x060026FC RID: 9980 RVA: 0x000C1DE0 File Offset: 0x000BFFE0
	internal void 23(bool 1)
	{
		if (1662.33 < this.6 || (1 == this.24 && !this.7))
		{
			return;
		}
		this.24 = 1;
		float num = (float)((!this.24) ? 45 : 0);
		foreach (1371 2 in this.4.28)
		{
			1433 3 = (1433)2;
			float num2 = 3.7.Y - num;
			bool flag = 3.17.Y >= num2;
			3.21(num2, flag ? 400 : 600, flag ? ((1046)2) : ((1046)33));
		}
		this.8.21();
		this.9.21();
		this.10.21();
		this.7 = false;
	}

	// Token: 0x060026FD RID: 9981 RVA: 0x000C1ED0 File Offset: 0x000C00D0
	internal void 24()
	{
		if (this.7 || !this.24 || !(this.5.17 == this.5.7))
		{
			this.4.22();
			int num = 30;
			2486.7.78.5 = 1f - Math.Max(0f, (this.5.7.Y - this.5.17.Y - 45f - (float)num) / (float)(this.3 - 45 - num));
		}
	}

	// Token: 0x060026FE RID: 9982 RVA: 0x000C1F70 File Offset: 0x000C0170
	public override void Update()
	{
		if (!this.20 && 208.Distance(this.19, 1555.21()) > 30f)
		{
			this.20 = true;
		}
		bool flag = 1555.19().Y > (float)this.2() && 1555.19().Y < (float)(1662.70.2() + 20) && 1555.21().X >= 0f && 1555.21().X < (float)1662.70.1 && this.20;
		bool flag2 = (!1535.1() && 2486.109 && !2486.13) || (1535.1() && !flag);
		if (!flag2 && flag && !2486.7.68() && 1662.11.2())
		{
			this.22(false, false);
		}
		else
		{
			this.23(flag2);
		}
		this.15();
		base.Update();
	}

	// Token: 0x060026FF RID: 9983 RVA: 0x000C2068 File Offset: 0x000C0268
	private void 25(1262 1)
	{
		1.107 = this.15.4();
		1.108 = this.14.4();
		1.109 = this.12.4();
		if (1304.134 && 1662.78 != 1677.Edit && !1662.84)
		{
			1.110 = 1272.5().110;
		}
		1.112 = new int?((int)this.8.7);
	}

	// Token: 0x06002700 RID: 9984 RVA: 0x000C20EA File Offset: 0x000C02EA
	private void 26(1371 1)
	{
		1.17.Y = 1.7.Y - (float)this.3;
	}

	// Token: 0x06002701 RID: 9985 RVA: 0x000C210A File Offset: 0x000C030A
	private void 27(1371 1)
	{
		1.21(1.7.Y - (float)this.3, 400, (1046)1);
	}

	// Token: 0x04001BE7 RID: 7143
	private int 3 = 180;

	// Token: 0x04001BE8 RID: 7144
	private readonly 1436 4 = new 1436(true);

	// Token: 0x04001BE9 RID: 7145
	private 1433 5;

	// Token: 0x04001BEA RID: 7146
	private int 6;

	// Token: 0x04001BEB RID: 7147
	internal bool 7;

	// Token: 0x04001BEC RID: 7148
	private 1429 8;

	// Token: 0x04001BED RID: 7149
	private 1429 9;

	// Token: 0x04001BEE RID: 7150
	private 1429 10;

	// Token: 0x04001BEF RID: 7151
	private bool 11;

	// Token: 0x04001BF0 RID: 7152
	private 1364 12;

	// Token: 0x04001BF1 RID: 7153
	private 1364 13;

	// Token: 0x04001BF2 RID: 7154
	private 1364 14;

	// Token: 0x04001BF3 RID: 7155
	private 1364 15;

	// Token: 0x04001BF4 RID: 7156
	private bool 16;

	// Token: 0x04001BF5 RID: 7157
	private bool 17;

	// Token: 0x04001BF6 RID: 7158
	private bool 18;

	// Token: 0x04001BF7 RID: 7159
	private 208 19;

	// Token: 0x04001BF8 RID: 7160
	internal bool 20;

	// Token: 0x04001BF9 RID: 7161
	public static int 21;

	// Token: 0x04001BFA RID: 7162
	public static int 22;

	// Token: 0x04001BFB RID: 7163
	private bool 23;

	// Token: 0x04001BFC RID: 7164
	internal bool 24 = 1535.1();

	// Token: 0x04001BFD RID: 7165
	private double 25 = double.NaN;

	// Token: 0x04001BFE RID: 7166
	private double? 26;

	// Token: 0x020004F9 RID: 1273
	[276]
	[Serializable]
	public sealed class 2564
	{
		// Token: 0x06002703 RID: 9987 RVA: 0x000A7057 File Offset: 0x000A5257
		internal bool 1(1262 1)
		{
			return 1.37 == 1272.5().37;
		}

		// Token: 0x04001BFF RID: 7167
		public static readonly 2563.2564 visualSettingsPanelCallbacks = new 2563.2564();

		// Token: 0x04001C00 RID: 7168
		public static Predicate<1262> predicate;

		// Token: 0x04001C01 RID: 7169
		public static Action<1371> action;
	}
}
