using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

// Token: 0x020005CB RID: 1483
public sealed class 2366 : 2336
{
	// Token: 0x06002DCC RID: 11724 RVA: 0x00103044 File Offset: 0x00101244
	internal 2366(2263 1) : base(1)
	{
		this.30 = new 1436();
		this.27 = new List<1259>();
	}

	// Token: 0x06002DCD RID: 11725 RVA: 0x000E26E4 File Offset: 0x000E08E4
	internal override bool IsInputEnabled()
	{
		return base.IsInputEnabled();
	}

	// Token: 0x06002DCE RID: 11726 RVA: 0x00103075 File Offset: 0x00101275
	internal override void SetInputEnabled(bool 1)
	{
		base.SetInputEnabled(1);
		this.30.22 = 1;
		if (this.10 != null)
		{
			this.10.1(1);
		}
	}

	// Token: 0x06002DCF RID: 11727 RVA: 0x001030A0 File Offset: 0x001012A0
	internal override void CopySelection()
	{
		this.27.Clear();
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < 1226.81().Count; i++)
		{
			1259 <<EMPTY_NAME>> = 1226.81()[i];
			if (<<EMPTY_NAME>>.1())
			{
				stringBuilder.AppendFormat("{2}. Offset: {0:#,0}ms\tBPM: {1:#.00#}\n", <<EMPTY_NAME>>.3, <<EMPTY_NAME>>.8(), i + 1);
			}
			else
			{
				stringBuilder.AppendFormat("{2}. Offset: {0:#,0}ms\tBPM: Inherited ({1}x)\n", <<EMPTY_NAME>>.3, Math.Round(-100.0 / <<EMPTY_NAME>>.1, 1), i + 1);
			}
		}
		try
		{
			Clipboard.SetText(stringBuilder.ToString());
		}
		catch (Exception)
		{
			1763.4(1568.1(2679.General_Editor_ClipboardNotAvailable));
		}
	}

	// Token: 0x06002DD0 RID: 11728 RVA: 0x00103180 File Offset: 0x00101380
	internal override void Paste()
	{
		if (this.27 == null || this.27.Count == 0)
		{
			return;
		}
		this.6.17 = false;
		double <<EMPTY_NAME>> = this.27[0].3;
		foreach (1259 2 in this.27)
		{
			1259 3 = (1259)2.Clone();
			3.3 = (double)1226.16 + (2.3 - <<EMPTY_NAME>>);
			this.18(2.1(), 3);
		}
		this.6.17 = true;
		this.6.20(false, false);
	}

	// Token: 0x06002DD1 RID: 11729 RVA: 0x00103248 File Offset: 0x00101448
	protected override void CreateInterface()
	{
		this.10 = new 2365(1662.11, this.3);
		this.11 = this.10.8;
		this.30.12(new 1433(1455.2("editor-timing-window-bg", (1416)1, null), (1376)6, 1065.TopLeft, (1044)0, new 208(120f, 85f), 0f, true, 198.White, 2335.Timing));
		int num = 120;
		int num2 = 30;
		this.30.12(new 1433(1455.2("editor-beat-selector-back", (1416)1, null), (1376)6, 1065.TopLeft, (1044)0, new 208(258f, (float)num), 0.2f, true, 198.White, 2335.Timing));
		1433 <<EMPTY_NAME>> = new 1433(1455.2("editor-beat-selector-buttonleft", (1416)1, null), (1376)6, 1065.Centre, (1044)0, new 208(270f, (float)(num + 10)), 0.9f, true, 198.White, 2335.Timing);
		<<EMPTY_NAME>>.10 = true;
		<<EMPTY_NAME>>.42 = new 1445(198.White, 198.Orange, 0, 140);
		<<EMPTY_NAME>>.12 = new 1445(1456.Scale, 1.2f, 1f, 0, 200, (1046)0);
		<<EMPTY_NAME>>.52 = string.Concat(new string[]
		{
			1568.1(2679.Editor_Timing_DecreaseBPM),
			"\n",
			1568.1(2679.EditorModeTiming_HoldShiftForLargerChanges),
			"\n",
			1568.1(2679.EditorModeTiming_HoldCtrlForSmallerChanges)
		});
		<<EMPTY_NAME>>.3(new EventHandler(this.7));
		this.30.12(<<EMPTY_NAME>>);
		<<EMPTY_NAME>> = new 1433(1455.2("editor-beat-selector-buttonright", (1416)1, null), (1376)6, 1065.Centre, (1044)0, new 208(382f, (float)(num + 10)), 0.9f, true, 198.White, 2335.Timing);
		<<EMPTY_NAME>>.10 = true;
		<<EMPTY_NAME>>.12 = new 1445(1456.Scale, 1.2f, 1f, 0, 200, (1046)0);
		<<EMPTY_NAME>>.42 = new 1445(198.White, 198.Orange, 0, 140);
		<<EMPTY_NAME>>.52 = string.Concat(new string[]
		{
			1568.1(2679.Editor_Timing_IncreaseBPM),
			"\n",
			1568.1(2679.EditorModeTiming_HoldShiftForLargerChanges),
			"\n",
			1568.1(2679.EditorModeTiming_HoldCtrlForSmallerChanges)
		});
		<<EMPTY_NAME>>.3(new EventHandler(this.8));
		this.30.12(<<EMPTY_NAME>>);
		this.12 = new 1452(string.Empty, 14f, new 208(324f, (float)(num + 10)), 0.9f, true, 198.White);
		this.12.8 = 2335.Timing;
		this.12.49 = 1065.Centre;
		this.12.10 = true;
		this.12.42 = new 1445(198.White, 198.YellowGreen, 0, 200);
		this.12.3(new EventHandler(this.30));
		this.12.52 = 1568.1(2679.EditorModeTiming_ClickToFineTuneTooltip);
		this.30.12(this.12);
		1452 4 = new 1452("BPM:", 14f, new 208(155f, (float)(num + 3)), 0.9f, true, 198.White);
		4.75 = (1066)3;
		4.77 = new 208(100f, 20f);
		4.8 = 2335.Timing;
		this.30.12(4);
		num += num2;
		this.19 = new 1452(1568.1(2679.EditorModeTiming_TimingMenuNote), 14f, new 208(145f, (float)num), 0.9f, true, 198.White);
		this.19.8 = 2335.Timing;
		this.30.12(this.19);
		num += (int)((double)num2 * 1.2);
		this.30.12(new 1433(1455.2("editor-beat-selector-back", (1416)1, null), (1376)6, 1065.TopLeft, (1044)0, new 208(258f, (float)num), 0.2f, true, 198.White, 2335.Timing));
		<<EMPTY_NAME>> = new 1433(1455.2("editor-beat-selector-buttonleft", (1416)1, null), (1376)6, 1065.Centre, (1044)0, new 208(270f, (float)(num + 10)), 0.9f, true, 198.White, 2335.Timing);
		<<EMPTY_NAME>>.10 = true;
		<<EMPTY_NAME>>.12 = new 1445(1456.Scale, 1.2f, 1f, 0, 200, (1046)0);
		<<EMPTY_NAME>>.3(delegate(object 1, EventArgs 2)
		{
			if (!this.8 && 1226.75())
			{
				this.8 = true;
				this.26 = 1226.81()[1226.70];
				this.6.18((2452)1, (2451)0, this.26);
			}
			this.12();
			this.30.29();
		});
		<<EMPTY_NAME>>.42 = new 1445(198.White, 198.Orange, 0, 140);
		<<EMPTY_NAME>>.52 = string.Concat(new string[]
		{
			1568.1(2679.General_DecreaseOffset),
			"\n",
			1568.1(2679.EditorModeTiming_HoldShiftForLargerChanges),
			"\n",
			1568.1(2679.EditorModeTiming_HoldCtrlForSmallerChanges)
		});
		this.30.12(<<EMPTY_NAME>>);
		<<EMPTY_NAME>> = new 1433(1455.2("editor-beat-selector-buttonright", (1416)1, null), (1376)6, 1065.Centre, (1044)0, new 208(382f, (float)(num + 10)), 0.9f, true, 198.White, 2335.Timing);
		<<EMPTY_NAME>>.10 = true;
		<<EMPTY_NAME>>.12 = new 1445(1456.Scale, 1.2f, 1f, 0, 200, (1046)0);
		<<EMPTY_NAME>>.42 = new 1445(198.White, 198.Orange, 0, 140);
		<<EMPTY_NAME>>.52 = string.Concat(new string[]
		{
			1568.1(2679.General_IncreaseOffset),
			"\n",
			1568.1(2679.EditorModeTiming_HoldShiftForLargerChanges),
			"\n",
			1568.1(2679.EditorModeTiming_HoldCtrlForSmallerChanges)
		});
		<<EMPTY_NAME>>.3(new EventHandler(this.6));
		this.30.12(<<EMPTY_NAME>>);
		this.14 = new 1452(string.Empty, 14f, new 208(324f, (float)(num + 10)), 0.9f, true, 198.White);
		this.14.8 = 2335.Timing;
		this.14.49 = 1065.Centre;
		this.14.10 = true;
		this.14.42 = new 1445(198.White, 198.YellowGreen, 0, 200);
		this.14.3(new EventHandler(this.31));
		this.14.52 = 1568.1(2679.EditorModeTiming_ClickToFineTuneTooltip);
		this.30.12(this.14);
		4 = new 1452(1568.1(2679.General_Offset) + ":", 14f, new 208(155f, (float)(num + 3)), 0.9f, true, 198.White);
		4.75 = (1066)3;
		4.77 = new 208(100f, 20f);
		4.8 = 2335.Timing;
		this.30.12(4);
		<<EMPTY_NAME>> = new 1433(1455.2("editor-timing-manual", (1416)1, null), (1376)6, 1065.Centre, (1044)0, new 208(455f, 146f), 0.9f, true, 198.White, 2335.Timing);
		<<EMPTY_NAME>>.10 = true;
		<<EMPTY_NAME>>.42 = new 1445(1456.Scale, 1f, 1.1f, 0, 200, (1046)0);
		<<EMPTY_NAME>>.3(delegate(object 1, EventArgs 2)
		{
			this.3();
		});
		<<EMPTY_NAME>>.52 = 1568.1(2679.EditorModeTiming_TimingSetupTooltip);
		this.30.12(<<EMPTY_NAME>>);
		num += num2;
		this.15 = new 1364(1568.1(2679.EditorModeTiming_MoveAlreadyPlacedNotes), new 208(145f, (float)num), 0.9f, true);
		this.15.6(1568.1(2679.EditorModeTiming_MoveAlreadyPlacedTooltip));
		foreach (1433 3 in this.15.2)
		{
			3.8 = 2335.Timing;
		}
		this.30.14<1433>(this.15.2);
		num += 60;
		4 = new 1452(1568.1(2679.Editor_Timing_SliderVelocity) + ":", 14f, new 208(155f, (float)(num + 3)), 0.9f, true, 198.White);
		4.75 = (1066)3;
		4.77 = new 208(100f, 20f);
		4.8 = 2335.Timing;
		this.30.12(4);
		this.30.12(new 1433(1455.2("editor-beat-selector-back", (1416)1, null), (1376)6, 1065.TopLeft, (1044)0, new 208(258f, (float)num), 0.2f, true, 198.White, 2335.Timing));
		<<EMPTY_NAME>> = new 1433(1455.2("editor-beat-selector-buttonleft", (1416)1, null), (1376)6, 1065.Centre, (1044)0, new 208(270f, (float)(num + 10)), 0.9f, true, 198.White, 2335.Timing);
		<<EMPTY_NAME>>.10 = true;
		<<EMPTY_NAME>>.42 = new 1445(198.White, 198.Orange, 0, 140);
		<<EMPTY_NAME>>.12 = new 1445(1456.Scale, 1.2f, 1f, 0, 200, (1046)0);
		<<EMPTY_NAME>>.3(new EventHandler(this.15));
		this.30.12(<<EMPTY_NAME>>);
		<<EMPTY_NAME>> = new 1433(1455.2("editor-beat-selector-buttonright", (1416)1, null), (1376)6, 1065.Centre, (1044)0, new 208(382f, (float)(num + 10)), 0.9f, true, 198.White, 2335.Timing);
		<<EMPTY_NAME>>.10 = true;
		<<EMPTY_NAME>>.42 = new 1445(198.White, 198.Orange, 0, 140);
		<<EMPTY_NAME>>.12 = new 1445(1456.Scale, 1.2f, 1f, 0, 200, (1046)0);
		<<EMPTY_NAME>>.3(delegate(object 1, EventArgs 2)
		{
			if (!this.8)
			{
				this.8 = true;
				this.6.15((2452)1, (2451)16, null);
				this.6.27();
			}
			if (1549.1)
			{
				1272.5().5 = Math.Min(3.5999999046325684, 1272.5().5 + 0.01);
			}
			else
			{
				1272.5().5 = Math.Min(3.5999999046325684, 1272.5().5 + 0.1);
			}
			this.24 = true;
			this.30.29();
		});
		this.30.12(<<EMPTY_NAME>>);
		this.18 = new 1452(string.Empty, 14f, new 208(324f, (float)(num + 10)), 0.9f, true, 198.White);
		this.18.8 = 2335.Timing;
		this.18.49 = 1065.Centre;
		this.30.12(this.18);
		num += num2;
		4 = new 1452(1568.1(2679.Editor_Timing_SliderTickRate) + ":", 14f, new 208(155f, (float)(num + 3)), 0.9f, true, 198.White);
		4.75 = (1066)3;
		4.77 = new 208(100f, 20f);
		4.8 = 2335.Timing;
		this.30.12(4);
		this.30.12(new 1433(1455.2("editor-beat-selector-back", (1416)1, null), (1376)6, 1065.TopLeft, (1044)0, new 208(258f, (float)num), 0.2f, true, 198.White, 2335.Timing));
		<<EMPTY_NAME>> = new 1433(1455.2("editor-beat-selector-buttonleft", (1416)1, null), (1376)6, 1065.Centre, (1044)0, new 208(270f, (float)(num + 10)), 0.9f, true, 198.White, 2335.Timing);
		<<EMPTY_NAME>>.42 = new 1445(198.White, 198.Orange, 0, 140);
		<<EMPTY_NAME>>.10 = true;
		<<EMPTY_NAME>>.12 = new 1445(1456.Scale, 1.2f, 1f, 0, 200, (1046)0);
		<<EMPTY_NAME>>.3(new EventHandler(this.14));
		this.30.12(<<EMPTY_NAME>>);
		<<EMPTY_NAME>> = new 1433(1455.2("editor-beat-selector-buttonright", (1416)1, null), (1376)6, 1065.Centre, (1044)0, new 208(382f, (float)(num + 10)), 0.9f, true, 198.White, 2335.Timing);
		<<EMPTY_NAME>>.10 = true;
		<<EMPTY_NAME>>.42 = new 1445(198.White, 198.Orange, 0, 140);
		<<EMPTY_NAME>>.12 = new 1445(1456.Scale, 1.2f, 1f, 0, 200, (1046)0);
		<<EMPTY_NAME>>.3(new EventHandler(this.13));
		this.30.12(<<EMPTY_NAME>>);
		this.16 = new 1452(string.Empty, 14f, new 208(324f, (float)(num + 10)), 0.9f, true, 198.White);
		this.16.8 = 2335.Timing;
		this.16.49 = 1065.Centre;
		this.30.12(this.16);
		this.13 = new 1452(string.Empty, 13f, new 208(200f, 20f), 1f, true, 198.White);
		this.13.41 = (1376)8;
		this.13.49 = 1065.TopRight;
		this.13.8 = 2335.Timing;
		this.5.12(this.13);
	}

	// Token: 0x06002DD2 RID: 11730 RVA: 0x00103F2C File Offset: 0x0010212C
	internal void 2(bool 1)
	{
		if (!7 && 1555.2() != 199.Released)
		{
			return;
		}
		this.8 = false;
		2450 2 = (2450)256;
		if (this.24)
		{
			this.6.13 = true;
			this.4.RecalculateDifficulty(false, true, true);
			if (!this.17)
			{
				this.6.19((2452)0, null);
				this.6.13((2451)7, 2);
				this.4.24(false, true);
				this.3.85 = true;
			}
			this.17 = false;
		}
		if (this.23)
		{
			this.6.13 = true;
			if (this.15.4() || this.25)
			{
				2366.2368 shift = new 2366.2368();
				shift.3 = this;
				1226.70(true);
				List<1259> list = 1226.83();
				1259 3 = (this.26 != null) ? this.26 : 1226.81()[1226.70];
				int num = list.IndexOf(3);
				double 4 = 3.3;
				shift.1 = ((num < list.Count - 1) ? list[num + 1].3 : ((double)1226.9()));
				shift.2 = (int)(4 - this.21);
				List<2034> list2 = this.4.34.FindAll((2034 1) => (double)1.1 < shift.1 && (double)1.1 >= shift.3.21);
				if (list2.Count > 0)
				{
					this.6.19((2452)0, new bool?(true));
					this.6.13((2451)0, 2 | (2450)2048);
					this.6.13((2451)7, 2);
					this.6.24<2034>(list2, false);
					list2.ForEach(new Action<2034>(shift.7));
					this.3.85 = true;
					this.6.4(false);
				}
			}
		}
		if (this.22)
		{
			2366.2367 5 = new 2366.2367();
			5.4 = this;
			this.6.13 = true;
			bool flag = this.15.4();
			List<1259> list3 = 1226.83();
			1259 6 = (this.26 != null) ? this.26 : 1226.81()[1226.70];
			int num2 = list3.IndexOf(6);
			5.2 = 6.3;
			5.1 = ((num2 < list3.Count - 1) ? list3[num2 + 1].3 : ((double)1226.9()));
			5.3 = 6.1 / this.20;
			if (flag)
			{
				List<2034> list4 = this.4.34.FindAll(new Predicate<2034>(5.7));
				if (list4.Count > 0)
				{
					this.6.19((2452)0, new bool?(true));
					this.6.13((2451)0, 2 | (2450)2048);
					this.6.13((2451)7, 2);
					this.6.24<2034>(list4, false);
					list4.ForEach(new Action<2034>(5.2));
					this.3.85 = true;
					this.6.4(false);
				}
			}
		}
		if (this.22 || this.23)
		{
			this.4.2(true);
		}
		this.26 = null;
		this.22 = false;
		this.23 = false;
		this.24 = false;
		this.25 = false;
		this.3.16(true);
		this.6.20(false, false);
	}

	// Token: 0x06002DD3 RID: 11731 RVA: 0x001042C9 File Offset: 0x001024C9
	internal override void Update()
	{
		this.2(false);
		this.10.Update();
		if (1226.70 != this.9)
		{
			this.9 = 1226.70;
			1662.8.68(1226.84());
		}
	}

	// Token: 0x06002DD4 RID: 11732 RVA: 0x00104304 File Offset: 0x00102504
	internal override void UpdateTimelineObjects()
	{
		foreach (1259 <<EMPTY_NAME>> in 1226.81())
		{
			if (<<EMPTY_NAME>>.3 >= (double)this.3.62 && <<EMPTY_NAME>>.3 <= (double)this.3.63)
			{
				float num = this.3.101(<<EMPTY_NAME>>.3) - 4f;
				byte b = (byte)Math.Min(255.0, 255.0 * ((double)Math.Max(0f, Math.Min(num - (float)this.3.56, (float)this.3.68 - (num - (float)this.3.56))) / 40.0));
				198 7 = new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, b);
				string text = (!<<EMPTY_NAME>>.1()) ? string.Format("{0}x", (<<EMPTY_NAME>>.1 < 0.0) ? Math.Round(-100.0 / <<EMPTY_NAME>>.1, 1) : 1.0) : ((<<EMPTY_NAME>>.1 != 0.0) ? string.Format("{0:0}bpm", 1000.0 / <<EMPTY_NAME>>.1 * 60.0) : "-");
				208 3 = new 208(num, (float)(this.3.57 + this.3.55 - 37));
				float num2 = 1436.32((float)((int)<<EMPTY_NAME>>.3));
				198 4 = <<EMPTY_NAME>>.1() ? 7 : new 198(180, 210, 254, b);
				208 5 = new 208(num + 6f, (float)(this.3.57 + this.3.55 - 27));
				float num3 = 1436.32((float)((int)<<EMPTY_NAME>>.3 - 2));
				List<1371> list;
				if (!this.28.TryGetValue(<<EMPTY_NAME>>, out list))
				{
					2366.2369 seek = new 2366.2369();
					list = new List<1371>();
					list.Add(new 1433(1455.2("editor-timeline-timinginfo", (1416)7, null), (1376)6, 1065.TopLeft, (1044)0, 3, num2, true, 4, null)
					{
						10 = true
					});
					List<1371> list2 = list;
					1452 6 = new 1452(text, 14f, 5, num3, true, 198.White);
					6.64(true);
					6.60(198.Black);
					list2.Add(6);
					seek.1 = (int)<<EMPTY_NAME>>.3;
					list[0].3(delegate(object 1, EventArgs 2)
					{
						1226.4(seek.1, false, false);
					});
					this.28.Add(<<EMPTY_NAME>>, list);
				}
				else
				{
					list[0].17 = 3;
					list[0].2 = num2;
					list[0].16 = (float)b / 255f;
					list[0].6 = 4;
					list[1].17 = 5;
					list[1].2 = num3;
					((1452)list[1]).SetText(text);
				}
				this.3.65.12(list[0]);
				this.3.65.12(list[1]);
			}
		}
	}

	// Token: 0x06002DD5 RID: 11733 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void DrawTimelineOverlay()
	{
	}

	// Token: 0x06002DD6 RID: 11734 RVA: 0x001046A8 File Offset: 0x001028A8
	internal override void Activate()
	{
		this.6.20(false, false);
		this.6.18 = true;
		1436 <<EMPTY_NAME>> = this.30;
		float 2;
		this.10.2(2 = 1f);
		<<EMPTY_NAME>>.5 = 2;
		1662.69.12(1f, false);
		this.3.31();
		this.3.67 = 6;
		if (!this.29)
		{
			2263 3 = this.3;
			3.99(3.98() * 0.4f);
		}
		this.29 = true;
		base.Activate();
		this.6.18 = false;
	}

	// Token: 0x06002DD7 RID: 11735 RVA: 0x0010474C File Offset: 0x0010294C
	internal override void Deactivate()
	{
		this.2(false);
		1436 <<EMPTY_NAME>> = this.30;
		float 2;
		this.10.2(2 = 0f);
		<<EMPTY_NAME>>.5 = 2;
		2263 3 = this.3;
		3.99(3.98() / 0.4f);
		this.29 = false;
		this.26 = null;
		1535.19();
		base.Deactivate();
	}

	// Token: 0x06002DD8 RID: 11736 RVA: 0x001047B0 File Offset: 0x001029B0
	internal override void Dispose()
	{
		this.10.3();
		if (this.30 != null)
		{
			this.30.Dispose();
		}
		foreach (KeyValuePair<1259, List<1371>> keyValuePair in this.28)
		{
			for (int i = 0; i < keyValuePair.Value.Count; i++)
			{
				keyValuePair.Value[i].Dispose();
			}
		}
		base.Dispose();
	}

	// Token: 0x06002DD9 RID: 11737 RVA: 0x0010484C File Offset: 0x00102A4C
	internal override void Draw()
	{
		bool flag = this.26 != null;
		if ((!flag && 1226.75()) || (flag && this.26.1 > 0.0))
		{
			this.12.SetText(string.Format("{0:0.###}", 60000.0 / (flag ? this.26.1 : 1226.76())));
			this.14.SetText(string.Format("{0:#,0}", flag ? this.26.3 : 1226.79()));
			this.18.SetText(string.Format("{0:N2}", 1272.5().5));
			this.16.SetText(string.Format("{0}", 1272.5().6));
			this.13.SetText(string.Format("{0}:{1}", this.10.11, this.10.9));
		}
		else
		{
			this.13.SetText(1568.1(2679.EditorModeTiming_TimingSectionNotTimed));
			this.12.SetText("-");
			this.14.SetText("-");
		}
		this.30.22();
		base.Draw();
		this.10.Draw();
	}

	// Token: 0x06002DDA RID: 11738 RVA: 0x001049C5 File Offset: 0x00102BC5
	internal new void 3()
	{
		this.4((2325)0);
	}

	// Token: 0x06002DDB RID: 11739 RVA: 0x001049CE File Offset: 0x00102BCE
	internal new void 4(2325 1)
	{
		this.5(1, true);
	}

	// Token: 0x06002DDC RID: 11740 RVA: 0x001049D8 File Offset: 0x00102BD8
	internal new void 5(2325 1, bool 2)
	{
		if (this.3.26 != 2335.Timing)
		{
			this.3.57();
		}
		else
		{
			this.2(true);
		}
		1662.82(true);
		this.20 = 1226.76();
		this.21 = 1226.79();
		int num = (int)new 2322(this.3, 1, 2, this.3.26 == 2335.Timing).ShowDialog(1662.13());
		1662.82(false);
		1226.70(true);
		this.6.16 = false;
		if (num != 2 && this.3.26 != 2335.Timing)
		{
			this.Update();
		}
	}

	// Token: 0x06002DDD RID: 11741 RVA: 0x00104A78 File Offset: 0x00102C78
	private new void 6(object 1, EventArgs 2)
	{
		if (!this.8 && 1226.75())
		{
			this.8 = true;
			this.26 = 1226.81()[1226.70];
			this.6.18((2452)1, (2451)0, this.26);
		}
		this.11();
		this.30.29();
	}

	// Token: 0x06002DDE RID: 11742 RVA: 0x00104AD4 File Offset: 0x00102CD4
	private new void 7(object 1, EventArgs 2)
	{
		if (!this.8 && 1226.75())
		{
			this.8 = true;
			this.26 = 1226.81()[1226.70];
			this.6.18((2452)1, (2451)18, this.26);
		}
		this.10();
		this.30.29();
	}

	// Token: 0x06002DDF RID: 11743 RVA: 0x00104B34 File Offset: 0x00102D34
	private void 8(object 1, EventArgs 2)
	{
		if (!this.8 && 1226.75())
		{
			this.8 = true;
			this.26 = 1226.81()[1226.70];
			this.6.18((2452)1, (2451)18, this.26);
		}
		this.9();
		this.30.29();
	}

	// Token: 0x06002DE0 RID: 11744 RVA: 0x00104B94 File Offset: 0x00102D94
	private void 9()
	{
		bool flag = this.26 != null;
		if ((!flag && 1226.75()) || (flag && this.26.1 > 0.0))
		{
			if (!this.22)
			{
				this.20 = (flag ? this.26.1 : 1226.76());
				this.22 = true;
			}
			1259 <<EMPTY_NAME>> = (this.26 != null) ? this.26 : 1226.81()[1226.70];
			double num = 1.0;
			if (1549.3)
			{
				num = 5.0;
			}
			else if (1549.1)
			{
				num = 0.25;
			}
			<<EMPTY_NAME>>.1 = 60000.0 / (<<EMPTY_NAME>>.8() + num);
		}
	}

	// Token: 0x06002DE1 RID: 11745 RVA: 0x00104C64 File Offset: 0x00102E64
	private void 10()
	{
		bool flag = this.26 != null;
		if ((!flag && 1226.75()) || (flag && this.26.1 > 0.0))
		{
			if (!this.22)
			{
				this.20 = (flag ? this.26.1 : 1226.76());
				this.22 = true;
			}
			1259 <<EMPTY_NAME>> = (this.26 != null) ? this.26 : 1226.81()[1226.70];
			double num = 1.0;
			if (1549.3)
			{
				num = 5.0;
			}
			else if (1549.1)
			{
				num = 0.25;
			}
			<<EMPTY_NAME>>.1 = 60000.0 / (<<EMPTY_NAME>>.8() - num);
		}
	}

	// Token: 0x06002DE2 RID: 11746 RVA: 0x00104D34 File Offset: 0x00102F34
	private void 11()
	{
		bool flag = this.26 != null;
		if ((flag || !1226.75()) && (!flag || this.26.1 <= 0.0))
		{
			return;
		}
		if (!this.23)
		{
			this.21 = (flag ? this.26.3 : 1226.79());
			this.23 = true;
		}
		if (flag)
		{
			if (1549.3)
			{
				this.26.3 += 10.0;
				return;
			}
			if (1549.1)
			{
				this.26.3 += 1.0;
				return;
			}
			this.26.3 += 2.0;
			return;
		}
		else
		{
			if (1549.3)
			{
				1226.80(1226.79() + 10.0);
				return;
			}
			if (1549.1)
			{
				1226.80(1226.79() + 1.0);
				return;
			}
			1226.80(1226.79() + 2.0);
			return;
		}
	}

	// Token: 0x06002DE3 RID: 11747 RVA: 0x00104E4C File Offset: 0x0010304C
	private void 12()
	{
		bool flag = this.26 != null;
		if ((flag || !1226.75()) && (!flag || this.26.1 <= 0.0))
		{
			return;
		}
		if (!this.23)
		{
			this.21 = (flag ? this.26.3 : 1226.79());
			this.23 = true;
		}
		if (flag)
		{
			if (1549.3)
			{
				this.26.3 -= 10.0;
				return;
			}
			if (1549.1)
			{
				this.26.3 -= 1.0;
				return;
			}
			this.26.3 -= 2.0;
			return;
		}
		else
		{
			if (1549.3)
			{
				1226.80(1226.79() - 10.0);
				return;
			}
			if (1549.1)
			{
				1226.80(1226.79() - 1.0);
				return;
			}
			1226.80(1226.79() - 2.0);
			return;
		}
	}

	// Token: 0x06002DE4 RID: 11748 RVA: 0x00104F64 File Offset: 0x00103164
	private void 13(object 1, EventArgs 2)
	{
		if (1272.5().6 < 4.0)
		{
			if (!this.8)
			{
				this.8 = true;
				this.6.15((2452)1, (2451)17, null);
				this.6.27();
			}
			1272.5().6 = (double)((int)1272.5().6 + 1);
			this.17 = true;
			this.24 = true;
		}
	}

	// Token: 0x06002DE5 RID: 11749 RVA: 0x00104FE0 File Offset: 0x001031E0
	private void 14(object 1, EventArgs 2)
	{
		if (1272.5().6 > 1.0)
		{
			if (!this.8)
			{
				this.8 = true;
				this.6.15((2452)1, (2451)17, null);
				this.6.27();
			}
			1272.5().6 = (double)((int)1272.5().6 - 1);
			this.17 = true;
			this.24 = true;
		}
	}

	// Token: 0x06002DE6 RID: 11750 RVA: 0x0010505C File Offset: 0x0010325C
	private void 15(object 1, EventArgs 2)
	{
		if (!this.8)
		{
			this.8 = true;
			this.6.15((2452)1, (2451)16, null);
			this.6.27();
		}
		if (1549.1)
		{
			1272.5().5 = Math.Max(0.4000000059604645, 1272.5().5 - 0.01);
		}
		else
		{
			1272.5().5 = Math.Max(0.4000000059604645, 1272.5().5 - 0.1);
		}
		this.24 = true;
		this.30.29();
	}

	// Token: 0x06002DE7 RID: 11751 RVA: 0x00105110 File Offset: 0x00103310
	internal override bool HandleKey(200 1, bool 2)
	{
		if (1 == 200.M && 1549.1)
		{
			this.22(false, null);
			return true;
		}
		if (1 == 200.L && !1549.1)
		{
			this.25(0);
			return true;
		}
		if (1 == 200.T && 2)
		{
			this.11.2();
			return true;
		}
		if (1 == 200.R)
		{
			this.20();
			return true;
		}
		return base.HandleKey(1, 2);
	}

	// Token: 0x06002DE8 RID: 11752 RVA: 0x0010517C File Offset: 0x0010337C
	internal void 16(1257 1)
	{
		if (1226.81().Count != 0)
		{
			1662.8.68(1);
			1259 2 = 1226.71();
			if (2 != null)
			{
				this.6.18((2452)1, (2451)21, 2);
				1226.85(1);
				this.3.76.21();
				this.6.20(false, false);
			}
		}
	}

	// Token: 0x06002DE9 RID: 11753 RVA: 0x001051DC File Offset: 0x001033DC
	internal void 17()
	{
		if (this.4.35 == 0)
		{
			return;
		}
		this.6.19((2452)0, null);
		foreach (2034 <<EMPTY_NAME>> in this.4.34)
		{
			2123 2 = <<EMPTY_NAME>> as 2123;
			if (2 != null)
			{
				this.6.14((2452)0, (2451)7, (2450)256);
				this.6.23(2, false);
				2.6 = 0.0;
				2.RebuildPathAndTiming(true);
			}
			this.3.85 = true;
			this.3.16(true);
		}
		this.6.20(false, false);
	}

	// Token: 0x06002DEA RID: 11754 RVA: 0x001052B4 File Offset: 0x001034B4
	internal void 18(bool 1, 1259 2)
	{
		bool flag = 2 == null;
		if (1)
		{
			flag &= (this.3.26 != 2335.Timing);
		}
		if (1226.75())
		{
			if (!1 && (double)1226.16 < 1226.81()[0].3)
			{
				return;
			}
			this.3.57();
			double 3 = 1 ? 1226.76() : 1226.73().1;
			if (2 == null)
			{
				2 = new 1259((double)1226.16, 3);
				2.2(1);
				if (1226.71 >= 0)
				{
					1259 4 = 1226.73();
					2.6 = 4.6;
					2.5 = 4.5;
					2.4(1226.63());
				}
			}
			this.6.18((2452)1, (2451)8, 2);
			1226.81().Add(2);
		}
		1226.70(true);
		if (flag)
		{
			this.4((2325)3);
			this.6.16 = true;
			return;
		}
		if (2 != null)
		{
			this.6.20(false, false);
		}
	}

	// Token: 0x06002DEB RID: 11755 RVA: 0x001053B4 File Offset: 0x001035B4
	internal void 19()
	{
		if (1226.76() > 0.0 && 1226.71 >= 0 && (1226.83().Count != 1 || 1226.71 != 1226.70))
		{
			this.3.74.6(false);
			this.6.18((2452)1, (2451)9, 1226.81()[1226.71]);
			1226.81().RemoveAt(1226.71);
			this.6.20(false, false);
			1226.69();
			1226.70(true);
		}
	}

	// Token: 0x06002DEC RID: 11756 RVA: 0x00105448 File Offset: 0x00103648
	internal void 20()
	{
		if (!this.8)
		{
			if (1226.70 >= 0)
			{
				1259 <<EMPTY_NAME>> = 1226.81()[1226.70];
				this.6.19((2452)1, null);
				this.6.13((2451)0, (2450)0);
				this.6.13((2451)18, (2450)0);
				this.6.22(<<EMPTY_NAME>>);
				<<EMPTY_NAME>>.1 = 0.0;
				<<EMPTY_NAME>>.3 = ((1226.70 == 0) ? 0.0 : (1226.81()[1226.70 - 1].3 + 1000.0));
				<<EMPTY_NAME>>.2(true);
				this.6.20(false, false);
				1226.4((int)<<EMPTY_NAME>>.3, false, false);
			}
			else
			{
				1226.Pause();
			}
			this.11.3();
			1226.70(true);
		}
	}

	// Token: 0x06002DED RID: 11757 RVA: 0x00105538 File Offset: 0x00103738
	internal void 21()
	{
		1226.83().Sort();
		for (int i = 1226.70; i <= 1226.71; i++)
		{
			1259 <<EMPTY_NAME>> = 1226.81()[i];
			this.6.23(<<EMPTY_NAME>>, false);
			<<EMPTY_NAME>>.5 = 1226.84();
		}
	}

	// Token: 0x06002DEE RID: 11758 RVA: 0x0010558C File Offset: 0x0010378C
	internal void 22(bool 1, int? 2)
	{
		if (1226.83().Count == 0 || this.8)
		{
			return;
		}
		if (2 == null)
		{
			2 = new int?(this.3.96());
		}
		List<1259> list = 1226.83();
		int num = 0;
		int num2;
		if (1)
		{
			num = list.IndexOf(1226.81()[num]);
			num2 = num + 1;
		}
		else
		{
			num2 = list.Count;
		}
		double 3 = list[num].3;
		double num3 = (num2 == list.Count) ? ((double)1226.9()) : list[num2].3;
		2450 4 = (2450)256;
		this.6.19((2452)0, new bool?(true));
		this.6.13((2451)0, 4 | (2450)2048);
		this.6.13((2451)7, 4);
		foreach (2034 5 in this.3.7.34)
		{
			if ((double)5.1 >= 3 && (double)5.1 <= num3)
			{
				1259 6 = (!1) ? 1226.90((double)5.1, list) : list[num];
				this.6.23(5, false);
				int startTime = (int)this.23((double)5.1, 6, 2);
				5.SetStartTime(startTime);
				if (5.HasObjectType(2047.Spinner) || 5.HasObjectType(2047.Hold))
				{
					5.SetEndTime((int)this.23((double)5.2, 6, 2));
				}
			}
		}
		this.6.4(false);
		if (!this.3.76.25)
		{
			this.6.13((2451)7, 4);
			this.4.2(true);
			this.4.25(false);
			this.3.2(true);
			this.3.16(true);
		}
	}

	// Token: 0x06002DEF RID: 11759 RVA: 0x0010579C File Offset: 0x0010399C
	private double 23(double 1, 1259 2, int? 3)
	{
		double num = 1 - 2.3;
		if (3 != null)
		{
			double a = num / (2.1 / (double)3.Value);
			return 2.3 + Math.Round(a) * (2.1 / (double)3.Value);
		}
		double num2 = num / (2.1 / 16.0);
		double num3 = num / (2.1 / 12.0);
		double num4 = Math.Abs(Math.Round(num2) - num2);
		double num5 = Math.Abs(Math.Round(num3) - num3);
		if (num4 < num5)
		{
			return 2.3 + Math.Round(num2) * (2.1 / 16.0);
		}
		return 2.3 + Math.Round(num3) * (2.1 / 12.0);
	}

	// Token: 0x06002DF0 RID: 11760 RVA: 0x00105870 File Offset: 0x00103A70
	internal void 24(int 1)
	{
		this.6.15((2452)0, (2451)0, null);
		this.6.13((2451)7, (2450)256);
		this.6.21<2034>(this.3.7.34);
		foreach (2034 2 in this.3.7.34)
		{
			2.SetStartTime(Math.Min(1226.9(), Math.Max(0, 2.1 + 1)));
		}
		this.4.2(true);
		this.4.25(false);
		this.3.2(true);
		this.3.14(true);
	}

	// Token: 0x06002DF1 RID: 11761 RVA: 0x00105958 File Offset: 0x00103B58
	internal void 25(int 1)
	{
		if (this.3.74.44.Count == 0)
		{
			return;
		}
		double num = 1226.88((double)this.3.74.44[0].1, false) / (double)this.3.96();
		this.6.16((2452)0, (2451)0, (2450)256, null);
		this.6.13((2451)7, (2450)256);
		this.6.21<2034>(this.3.74.44);
		foreach (2034 2 in this.3.74.44)
		{
			2.SetStartTime(this.27((double)2.1) + (int)((double)1 * num));
		}
		this.4.2(true);
		this.3.2(true);
		this.3.16(true);
	}

	// Token: 0x06002DF2 RID: 11762 RVA: 0x00105A7C File Offset: 0x00103C7C
	internal int 26(double 1)
	{
		int num = this.29(1, 16, 1);
		int num2 = this.29(1, 12, 1);
		if (Math.Abs((double)num - 1) > Math.Abs((double)num2 - 1))
		{
			return num2;
		}
		return num;
	}

	// Token: 0x06002DF3 RID: 11763 RVA: 0x00105AB6 File Offset: 0x00103CB6
	internal int 27(double 1)
	{
		return this.29(1, this.3.96(), 1);
	}

	// Token: 0x06002DF4 RID: 11764 RVA: 0x00105ACB File Offset: 0x00103CCB
	internal int 28(double 1, double 2)
	{
		return this.29(1, this.3.96(), 2);
	}

	// Token: 0x06002DF5 RID: 11765 RVA: 0x00105AE0 File Offset: 0x00103CE0
	internal int 29(double 1, int 2, double 3)
	{
		if (1226.81().Count == 0)
		{
			return (int)1;
		}
		double num = 1226.86(3);
		double num2 = 1226.88(3, false) / (double)2;
		int num3 = (1 - num >= 0.0) ? ((int)((1 - num) / num2)) : ((int)((1 - num) / num2) - 1);
		int num4 = (int)((double)num3 * num2 + num);
		int num5 = (int)((double)(num3 + 1) * num2 + num);
		if (3 != 1)
		{
			if ((double)num4 == 3)
			{
				return num5;
			}
			if ((double)num5 == 3)
			{
				return num4;
			}
		}
		if (1 - (double)num4 >= (double)num5 - 1)
		{
			return num5;
		}
		return num4;
	}

	// Token: 0x06002DF6 RID: 11766 RVA: 0x00005ADD File Offset: 0x00003CDD
	protected override void InitializeState()
	{
	}

	// Token: 0x06002DF7 RID: 11767 RVA: 0x00105B5C File Offset: 0x00103D5C
	private void 30(object 1, EventArgs 2)
	{
		this.5((2325)1, false);
	}

	// Token: 0x06002DF8 RID: 11768 RVA: 0x00105B66 File Offset: 0x00103D66
	private void 31(object 1, EventArgs 2)
	{
		this.5((2325)2, false);
	}

	// Token: 0x040021A5 RID: 8613
	private bool 8;

	// Token: 0x040021A6 RID: 8614
	private int 9 = -1;

	// Token: 0x040021A7 RID: 8615
	internal 2365 10;

	// Token: 0x040021A8 RID: 8616
	private 2333 11;

	// Token: 0x040021A9 RID: 8617
	internal 1452 12;

	// Token: 0x040021AA RID: 8618
	internal 1452 13;

	// Token: 0x040021AB RID: 8619
	internal 1452 14;

	// Token: 0x040021AC RID: 8620
	private 1364 15;

	// Token: 0x040021AD RID: 8621
	private 1452 16;

	// Token: 0x040021AE RID: 8622
	private bool 17;

	// Token: 0x040021AF RID: 8623
	private 1452 18;

	// Token: 0x040021B0 RID: 8624
	private 1452 19;

	// Token: 0x040021B1 RID: 8625
	private double 20;

	// Token: 0x040021B2 RID: 8626
	private double 21;

	// Token: 0x040021B3 RID: 8627
	internal bool 22;

	// Token: 0x040021B4 RID: 8628
	internal bool 23;

	// Token: 0x040021B5 RID: 8629
	internal bool 24;

	// Token: 0x040021B6 RID: 8630
	internal bool 25;

	// Token: 0x040021B7 RID: 8631
	private 1259 26;

	// Token: 0x040021B8 RID: 8632
	internal List<1259> 27;

	// Token: 0x040021B9 RID: 8633
	private Dictionary<1259, List<1371>> 28 = new Dictionary<1259, List<1371>>();

	// Token: 0x040021BA RID: 8634
	private bool 29;

	// Token: 0x040021BB RID: 8635
	private 1436 30;

	// Token: 0x020005CC RID: 1484
	public sealed class 2368
	{
		// Token: 0x06002DFC RID: 11772 RVA: 0x00105C85 File Offset: 0x00103E85
		internal void 1(2034 1)
		{
			1.SetStartTime(1.1 + this.2);
		}

		// Token: 0x040021BC RID: 8636
		public double 1;

		// Token: 0x040021BD RID: 8637
		public int 2;

		// Token: 0x040021BE RID: 8638
		public 2366 3;
	}

	// Token: 0x020005CD RID: 1485
	public sealed class 2369
	{
		// Token: 0x040021BF RID: 8639
		public int 1;
	}

	// Token: 0x020005CE RID: 1486
	public sealed class 2367
	{
		// Token: 0x06002DFF RID: 11775 RVA: 0x00105C9A File Offset: 0x00103E9A
		internal bool 1(2034 1)
		{
			return (double)1.1 < this.1 && (double)1.1 >= this.4.21;
		}

		// Token: 0x06002E00 RID: 11776 RVA: 0x00105CC4 File Offset: 0x00103EC4
		internal void 2(2034 1)
		{
			1.SetStartTime((int)(((double)1.1 - this.2) * this.3 + this.2));
		}

		// Token: 0x040021C0 RID: 8640
		public double 1;

		// Token: 0x040021C1 RID: 8641
		public double 2;

		// Token: 0x040021C2 RID: 8642
		public double 3;

		// Token: 0x040021C3 RID: 8643
		public 2366 4;
	}
}
