using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

// Token: 0x02000599 RID: 1433
public sealed class 2298 : 2336
{
	// Token: 0x06002BFF RID: 11263 RVA: 0x000F12B0 File Offset: 0x000EF4B0
	private void 2()
	{
		int num = 80;
		int num2 = 0;
		1452 <<EMPTY_NAME>> = new 1452(1568.1(2679.EditorModeDesign_LayerToggles), 10f, new 208((float)num2, (float)num), 1f, true, 198.White);
		<<EMPTY_NAME>>.54(true);
		<<EMPTY_NAME>>.63(true);
		this.5.12(<<EMPTY_NAME>>);
		num += 15;
		this.15 = new 1364(1568.1(2679.General_Background), 0.7f, new 208((float)(num2 + 2), (float)num), 1f, true, 0f);
		this.5.14<1433>(this.15.2);
		this.15.9(new 1183(this.9));
		num += 15;
		this.16 = new 1364(1568.1(2679.Editor_Design_Failing), 0.7f, new 208((float)(num2 + 2), (float)num), 1f, true, 0f);
		this.5.14<1433>(this.16.2);
		this.16.9(new 1183(this.10));
		num += 15;
		this.19 = new 1364(1568.1(2679.Editor_Design_Passing), 0.7f, new 208((float)(num2 + 2), (float)num), 1f, true, 0f);
		this.5.14<1433>(this.19.2);
		this.19.9(new 1183(this.11));
		num += 15;
		this.17 = new 1364(1568.1(2679.General_Foreground), 0.7f, new 208((float)(num2 + 2), (float)num), 1f, true, 0f);
		this.5.14<1433>(this.17.2);
		this.17.9(new 1183(this.12));
		num += 15;
		this.18 = new 1364("Overlay", 0.7f, new 208((float)(num2 + 2), (float)num), 1f, true, 0f);
		this.5.14<1433>(this.18.2);
		this.18.9(new 1183(this.13));
		num += 15;
		this.14 = new 1364(1568.1(2679.Editor_Design_HitObjects), 0.7f, new 208((float)(num2 + 2), (float)num), 1f, false, 0f);
		this.5.14<1433>(this.14.2);
		this.14.9(new 1183(this.14));
		num += 30;
		<<EMPTY_NAME>> = new 1452(1568.1(2679.Editor_Design_Transformation), 10f, new 208((float)num2, (float)num), 1f, true, 198.White);
		<<EMPTY_NAME>>.54(true);
		<<EMPTY_NAME>>.63(true);
		this.5.12(<<EMPTY_NAME>>);
		this.37 = 1456.Movement;
		num += 15;
		this.25 = new 1364(1568.1(2679.General_Move), 0.7f, new 208((float)(num2 + 2), (float)num), 1f, true, 0f);
		this.5.14<1433>(this.25.2);
		this.25.9(new 1183(this.49));
		num += 15;
		this.27 = new 1364(1568.1(2679.General_Scale), 0.7f, new 208((float)(num2 + 2), (float)num), 1f, false, 0f);
		this.5.14<1433>(this.27.2);
		this.27.9(new 1183(this.50));
		num += 15;
		this.22 = new 1364(1568.1(2679.General_Fade), 0.7f, new 208((float)(num2 + 2), (float)num), 1f, false, 0f);
		this.5.14<1433>(this.22.2);
		this.22.9(delegate(object 1, bool 2)
		{
			this.45(1456.Fade);
		});
		num += 15;
		this.26 = new 1364(1568.1(2679.General_Rotate), 0.7f, new 208((float)(num2 + 2), (float)num), 1f, false, 0f);
		this.5.14<1433>(this.26.2);
		this.26.9(new 1183(this.51));
		num += 15;
		this.29 = new 1364(1568.1(2679.General_Colour), 0.7f, new 208((float)(num2 + 2), (float)num), 1f, false, 0f);
		this.5.14<1433>(this.29.2);
		this.29.9(new 1183(this.52));
		num += 15;
		<<EMPTY_NAME>> = new 1452(1568.1(2679.Editor_Design_Tweening), 10f, new 208((float)num2, (float)num), 1f, true, 198.White);
		<<EMPTY_NAME>>.54(true);
		<<EMPTY_NAME>>.63(true);
		this.5.12(<<EMPTY_NAME>>);
		num += 15;
		this.32 = new 1364(1568.1(2679.General_Enabled), 0.7f, new 208((float)(num2 + 2), (float)num), 1f, false, 0f);
		this.5.14<1433>(this.32.2);
		this.32.9(delegate(object 1, bool 2)
		{
			this.36(2);
		});
		num += 15;
		<<EMPTY_NAME>> = new 1452(1568.1(2679.Editor_Design_Easing), 10f, new 208((float)num2, (float)num), 1f, true, 198.White);
		<<EMPTY_NAME>>.54(true);
		<<EMPTY_NAME>>.63(true);
		this.5.12(<<EMPTY_NAME>>);
		num += 15;
		this.30 = new 1364(1568.1(2679.General_In), 0.7f, new 208((float)(num2 + 2), (float)num), 1f, false, 0f);
		this.5.14<1433>(this.30.2);
		this.30.9(new 1183(this.41));
		num += 15;
		this.31 = new 1364(1568.1(2679.General_Out), 0.7f, new 208((float)(num2 + 2), (float)num), 1f, false, 0f);
		this.5.14<1433>(this.31.2);
		this.31.9(new 1183(this.42));
		num += 30;
		<<EMPTY_NAME>> = new 1452(1568.1(2679.General_Origin), 10f, new 208((float)num2, (float)num), 1f, true, 198.White);
		<<EMPTY_NAME>>.54(true);
		<<EMPTY_NAME>>.63(true);
		this.5.12(<<EMPTY_NAME>>);
		num += 15;
		this.21 = new 1364(1568.1(2679.General_TopLeft), 0.7f, new 208((float)(num2 + 2), (float)num), 1f, true, 0f);
		this.21.9(new 1183(this.15));
		this.5.14<1433>(this.21.2);
		num += 15;
		this.20 = new 1364(1568.1(2679.General_Centre), 0.7f, new 208((float)(num2 + 2), (float)num), 1f, false, 0f);
		this.20.9(delegate(object 1, bool 2)
		{
			this.5(1065.Centre);
		});
		this.5.14<1433>(this.20.2);
		num += 30;
		<<EMPTY_NAME>> = new 1452(1568.1(2679.General_Advanced), 10f, new 208((float)num2, (float)num), 1f, true, 198.White);
		<<EMPTY_NAME>>.54(true);
		<<EMPTY_NAME>>.63(true);
		this.5.12(<<EMPTY_NAME>>);
		num += 15;
		this.13 = new 1364(1568.1(2679.Editor_Design_DiffSpecific), 0.7f, new 208((float)(num2 + 2), (float)num), 1f, false, 0f);
		this.5.14<1433>(this.13.2);
		this.13.9(new 1183(this.16));
	}

	// Token: 0x06002C00 RID: 11264 RVA: 0x000F1AF4 File Offset: 0x000EFCF4
	private new void 3()
	{
		int num = 80;
		int num2 = 70;
		1433 <<EMPTY_NAME>> = new 1433(1662.34, new 208(0f, 66f), 0f, true, new 198(0, 0, 0, 130));
		<<EMPTY_NAME>>.15 = 1.6f;
		<<EMPTY_NAME>>.20 = new 208(160f, 396f);
		this.12.12(<<EMPTY_NAME>>);
		num += 15;
		num += 15;
		num += 15;
		num += 15;
		num += 15;
		num += 30;
		num += 15;
		num += 15;
		this.28 = new 1364(1568.1(2679.Editor_Design_VectorScale), 0.7f, new 208((float)(num2 + 2), (float)num), 1f, false, 0f);
		this.12.14<1433>(this.28.2);
		this.28.9(delegate(object 1, bool 2)
		{
			this.45(1456.VectorScale);
		});
		num += 15;
		this.23 = new 1364(1568.1(2679.Editor_Design_HorizontalFlip), 0.7f, new 208((float)(num2 + 2), (float)num), 1f, false, 0f);
		this.12.14<1433>(this.23.2);
		this.23.9(new 1183(this.53));
		num += 15;
		this.24 = new 1364(1568.1(2679.Editor_Design_VerticalFlip), 0.7f, new 208((float)(num2 + 2), (float)num), 1f, false, 0f);
		this.12.14<1433>(this.24.2);
		this.24.9(new 1183(this.54));
		num += 30;
		num += 15;
		num += 15;
		num += 15;
		num += 15;
		num += 30;
		num += 15;
		num += 15;
		num += 30;
		num += 15;
	}

	// Token: 0x06002C01 RID: 11265 RVA: 0x000F1CDB File Offset: 0x000EFEDB
	private new void 4(bool 1)
	{
		if (this.33 != 1)
		{
			this.13.7(1);
			this.33 = 1;
			if (this.48 != null)
			{
				this.48.11 = 1;
			}
		}
	}

	// Token: 0x06002C02 RID: 11266 RVA: 0x000F1D10 File Offset: 0x000EFF10
	private new void 5(1065 1)
	{
		if (this.36 != 1)
		{
			this.36 = 1;
			this.21.7(1 == 1065.TopLeft);
			this.20.7(1 == 1065.Centre);
			if (this.48 != null)
			{
				this.6.18((2452)2, (2451)35, this.48);
				this.48.7.49 = 1;
				this.48.7.UpdateOriginOffset();
				this.6.20(false, false);
			}
		}
	}

	// Token: 0x06002C03 RID: 11267 RVA: 0x000F1D98 File Offset: 0x000EFF98
	internal new void 6(2645 1)
	{
		this.43.25(1);
		this.15.7(this.43.28[0]);
		this.17.7(this.43.28[3]);
		this.18.7(this.43.28[4]);
		this.16.7(this.43.28[1]);
		this.19.7(this.43.28[2]);
		this.8.44 = true;
	}

	// Token: 0x06002C04 RID: 11268 RVA: 0x000F1E38 File Offset: 0x000F0038
	private new void 7()
	{
		if (1662.23 && !this.46)
		{
			if (1555.21().X < 40f * 1662.70.3() && this.IsInputEnabled())
			{
				this.12.5 = Math.Min(1f, this.12.5 + 0.08f);
				return;
			}
			if (1555.21().X > 160f * 1662.70.3() || !this.IsInputEnabled())
			{
				this.12.5 = Math.Max(0f, this.12.5 - 0.08f);
				return;
			}
			if (this.12.5 < 1f && this.12.5 > 0.5f)
			{
				this.12.5 = Math.Min(1f, this.12.5 + 0.08f);
			}
		}
	}

	// Token: 0x06002C05 RID: 11269 RVA: 0x000F1F3A File Offset: 0x000F013A
	public void 8(bool 1)
	{
		this.53 = 1;
		this.4.39.5 = (this.53 ? 1f : 0.05f);
	}

	// Token: 0x06002C06 RID: 11270 RVA: 0x000F1F67 File Offset: 0x000F0167
	private void 9(object 1, bool 2)
	{
		this.6(2645.Background);
	}

	// Token: 0x06002C07 RID: 11271 RVA: 0x000F1F70 File Offset: 0x000F0170
	private void 10(object 1, bool 2)
	{
		this.6(2645.Fail);
	}

	// Token: 0x06002C08 RID: 11272 RVA: 0x000F1F79 File Offset: 0x000F0179
	private void 11(object 1, bool 2)
	{
		this.6(2645.Pass);
	}

	// Token: 0x06002C09 RID: 11273 RVA: 0x000F1F82 File Offset: 0x000F0182
	private void 12(object 1, bool 2)
	{
		this.6(2645.Foreground);
	}

	// Token: 0x06002C0A RID: 11274 RVA: 0x000F1F8B File Offset: 0x000F018B
	private void 13(object 1, bool 2)
	{
		this.6(2645.Overlay);
	}

	// Token: 0x06002C0B RID: 11275 RVA: 0x000F1F94 File Offset: 0x000F0194
	private void 14(object 1, bool 2)
	{
		this.8(2);
	}

	// Token: 0x06002C0C RID: 11276 RVA: 0x000F1F9D File Offset: 0x000F019D
	private void 15(object 1, bool 2)
	{
		this.5(1065.TopLeft);
	}

	// Token: 0x06002C0D RID: 11277 RVA: 0x000F1FA6 File Offset: 0x000F01A6
	private void 16(object 1, bool 2)
	{
		this.4(2);
	}

	// Token: 0x06002C0E RID: 11278 RVA: 0x000F1FAF File Offset: 0x000F01AF
	private void 17(1433 1)
	{
		1.52 = string.Format(1568.1(2679.EditorModeDesign_VideoOffsetTooltip), this.58.8);
	}

	// Token: 0x06002C0F RID: 11279 RVA: 0x000F1FD6 File Offset: 0x000F01D6
	public 2298(2263 1) : base(1)
	{
		this.8 = new 2358();
	}

	// Token: 0x06002C10 RID: 11280 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool HasGrid()
	{
		return true;
	}

	// Token: 0x06002C11 RID: 11281 RVA: 0x000F1FF5 File Offset: 0x000F01F5
	protected override void InitializeState()
	{
		this.OnBeatmapLoaded();
	}

	// Token: 0x06002C12 RID: 11282 RVA: 0x000F1FFD File Offset: 0x000F01FD
	internal override void CreateGrid()
	{
		this.7 = new 2332(this.3, 1304.146);
	}

	// Token: 0x06002C13 RID: 11283 RVA: 0x000F2018 File Offset: 0x000F0218
	protected override void CreateInterface()
	{
		this.12 = new 1436(true);
		this.12.5 = 0f;
		this.9 = new 1452(string.Empty, 10f, new 208((float)(1662.70.1() - 200), 28f), 208.Zero, 1f, true, 198.White, true);
		this.9.85 = false;
		this.9.74 = false;
		this.9.63(true);
		this.10 = new 1452(string.Empty, 10f, new 208((float)(1662.70.1() - 200), 56f), 208.Zero, 1f, true, 198.White, true);
		this.10.85 = false;
		this.10.74 = false;
		this.10.63(true);
		this.5.12(this.9);
		this.5.12(this.10);
		this.2();
		this.3();
		1361 <<EMPTY_NAME>> = new 1361(1568.1(2679.Editor_Design_BackgroundImageVideo), new 208((float)(1662.70.1() - 180), 6f), new 208(170f, 22.5f), 1f, new 198(112, 152, 252), new EventHandler(this.19), true, false, null, true);
		this.5.14<1433>(<<EMPTY_NAME>>.1);
		this.59 = new 1429(this.5, -3000.0, 3000.0, (double)((this.58 != null) ? this.58.8 : 0), new 208((float)(1662.70.1() - 130), 52f), 125);
		this.57 = new 1452(1568.1(2679.EditorModeDesign_VideoOffset), 12f, new 208((float)this.59.3 / 2f + this.59.4().X, 32f), 1f, true, 198.White);
		this.57.8 = 2335.Design;
		this.57.49 = 1065.TopCentre;
		this.5.12(this.57);
		this.59.7(false);
		this.59.10 = true;
		this.57.16 = 0f;
		1452 4 = new 1452(1568.1(2679.EditorModeDesign_KeyframeControl), 10f, new 208(160f, 64f), 1f, true, 198.White);
		4.54(true);
		4.63(true);
		this.5.12(4);
		1433 3 = new 1433(1455.2("editor-timeline-plus", (1416)1, null), (1376)6, 1065.Centre, (1044)0, new 208(250f, 70f), 1f, true, 198.White, null);
		3.15 = 0.8f;
		3.10 = true;
		3.12 = new 1445(1456.Scale, 0.9f, 0.8f, 0, 200, (1046)0);
		3.3(new EventHandler(this.38));
		this.5.12(3);
		3 = new 1433(1455.2("editor-timeline-minus", (1416)1, null), (1376)6, 1065.Centre, (1044)0, new 208(265f, 70f), 1f, true, 198.White, null);
		3.15 = 0.8f;
		3.10 = true;
		3.12 = new 1445(1456.Scale, 0.9f, 0.8f, 0, 200, (1046)0);
		3.3(new EventHandler(this.39));
		this.5.12(3);
		3 = new 1433(1455.2("editor-timeline-left", (1416)1, null), (1376)6, 1065.Centre, (1044)0, new 208(280f, 70f), 1f, true, 198.White, null);
		3.15 = 0.8f;
		3.10 = true;
		3.12 = new 1445(1456.Scale, 0.9f, 0.8f, 0, 200, (1046)0);
		3.3(delegate(object 1, EventArgs 2)
		{
			this.34();
		});
		this.5.12(3);
		3 = new 1433(1455.2("editor-timeline-right", (1416)1, null), (1376)6, 1065.Centre, (1044)0, new 208(295f, 70f), 1f, true, 198.White, null);
		3.15 = 0.8f;
		3.10 = true;
		3.12 = new 1445(1456.Scale, 0.9f, 0.8f, 0, 200, (1046)0);
		3.3(new EventHandler(this.40));
		this.5.12(3);
		<<EMPTY_NAME>> = new 1361("Sprite\nLibrary", new 208((float)(1662.70.1() - 70), 372f), new 208(66f, 40f), 1f, 198.YellowGreen, new EventHandler(this.21), true, false, null, true);
		this.5.14<1433>(<<EMPTY_NAME>>.1);
		this.11 = new 1452(string.Empty, 8f, new 208(-1f, -1f), 208.Zero, 1f, true, 198.White, true);
		this.11.85 = false;
		this.11.74 = false;
		this.11.41 = (1376)5;
		this.5.12(this.11);
		this.56 = new 1452("Movement\nScale\nFade\nRotation", 8.4f, new 208((float)this.3.56, (float)this.3.57), 1f, true, 198.White);
		this.56.54(true);
		this.56.63(true);
		this.5.12(this.56);
		3 = new 1433(1455.2("editor-button-play", (1416)1, null), (1376)6, 1065.Centre, (1044)0, new 208((float)(this.3.56 + 5), 70f), 1f, true, 198.White, null);
		3.14 = 1.5707964f;
		3.15 = 0.7f;
		3.10 = true;
		3.12 = new 1445(1456.Scale, 0.8f, 0.7f, 0, 200, (1046)0);
		3.3(delegate(object 1, EventArgs 2)
		{
			this.43(false);
		});
		this.5.12(3);
		3 = new 1433(1455.2("editor-button-play", (1416)1, null), (1376)6, 1065.Centre, (1044)0, new 208((float)(this.3.56 + 20), 70f), 1f, true, 198.White, null);
		3.14 = -1.5707964f;
		3.15 = 0.7f;
		3.10 = true;
		3.12 = new 1445(1456.Scale, 0.8f, 0.7f, 0, 200, (1046)0);
		3.3(new EventHandler(this.48));
		this.5.12(3);
		base.CreateInterface();
	}

	// Token: 0x06002C14 RID: 11284 RVA: 0x000F274C File Offset: 0x000F094C
	internal override void Update()
	{
		this.4.74();
		this.47 = 1555.21();
		float num = (float)1662.70.1 * 1662.69.10();
		float num2 = (float)1662.70.2 * 1662.69.10();
		208 <<EMPTY_NAME>> = new 208(((float)1662.70.1 - num) / 2f + (float)1662.70.4(), ((float)1662.70.2 - num2) / 4f * 3f);
		this.47 -= <<EMPTY_NAME>>;
		this.47 = this.47 / num2 * 480f;
		this.7();
		if (1662.23)
		{
			float num3 = 1662.69.28(1662.55.1() + this.43.22.43 + this.43.21.43 + this.43.23.43 + this.43.24.43);
			this.10.6 = ((num3 > 5f) ? 198.Red : 198.White);
			this.10.54(num3 > 5f);
			this.9.SetText(string.Format("x:{0:0} y:{1:0}\n{2:#,0}ms", this.47.X, this.47.Y, 1226.16));
			this.10.SetText(string.Format("SB Load:{0:0.00}x", num3));
		}
		if (this.58 != null)
		{
			this.59.7(true);
			this.57.16 = 1f;
			if (this.59.14())
			{
				int startTime = (int)this.59.7;
				this.58.SetStartTime(startTime);
				this.59.13.ForEach(new Action<1433>(this.17));
			}
		}
		else
		{
			this.59.7(false);
			this.57.16 = 0f;
		}
		if (this.48 != null)
		{
			this.50 = this.48.7.3.FindAll(new Predicate<1445>(this.55));
			1445 2 = this.50.Find(new Predicate<1445>(2298.2300.Instance.1));
			this.33 = this.48.11;
			this.13.7(this.33);
			this.36 = this.48.7.49;
			this.21.7(this.36 == 1065.TopLeft);
			this.20.7(this.36 == 1065.Centre);
			this.32.7(2 != null);
			this.35 = ((2 != null) ? 2.15 : ((1046)0));
			this.30.7(this.35 == (1046)2);
			this.31.7(this.35 == (1046)1);
			this.23.7(this.48.7.3.FindAll(new Predicate<1445>(2298.2300.Instance.2)).Count > 0);
			this.24.7(this.48.7.3.FindAll(new Predicate<1445>(2298.2300.Instance.3)).Count > 0);
			this.11.17 = ((this.48.7.14 == 0f) ? new 208(this.48.7.50.2(), this.48.7.50.3()) : new 208(this.48.7.31.X, this.48.7.31.Y));
			this.11.SetText(string.Concat(new string[]
			{
				this.48.3,
				" (",
				this.48.5.ToString(),
				(this.48.4 > 0) ? (" - line " + this.48.4.ToString()) : string.Empty,
				")\n"
			}));
			this.11.16 = 1f;
		}
		else
		{
			this.11.16 = 0f;
			this.32.7(false);
			this.30.7(false);
			this.31.7(false);
		}
		if (this.46)
		{
			if (1549.3)
			{
				if (Math.Abs(this.40.X - this.47.X) > Math.Abs(this.40.Y - this.47.Y))
				{
					this.47.Y = this.40.Y;
				}
				else
				{
					this.47.X = this.40.X;
				}
			}
			1433 3 = this.48.7;
			1445 4 = null;
			if (this.37 != 1456.Colour)
			{
				this.32(1226.16, out 4, true);
			}
		}
		else
		{
			this.44 = null;
			this.45.Clear();
			if (!this.3.71 && this.12.5 < 1f)
			{
				this.54 = this.43.7();
				if (this.54.Count > 0)
				{
					bool 5 = 1549.3;
					int count = this.54.Count;
					int num4 = (this.51 - 1 + count) % count;
					bool flag = true;
					int num5 = num4;
					while (num5 != num4 || flag)
					{
						flag = false;
						2647 6 = this.54[num5];
						if (6.7.19 && 2298.27(6))
						{
							if (this.44 == null)
							{
								this.44 = 6;
								if (!5)
								{
									break;
								}
							}
							else if (5)
							{
								this.45.Add(6);
							}
						}
						num5 = (num5 - 1 + count) % count;
					}
				}
			}
		}
		if (this.34 && this.38 != 1456.None)
		{
			int num6 = this.3.103(1535.5.X);
			if (!1549.3)
			{
				num6 = this.3.76.27((double)(num6 - this.52));
			}
			int num7 = num6 - this.48.7.3.Find(new Predicate<1445>(this.56)).9;
			bool flag2 = true;
			for (int i = 0; i < this.48.7.3.Count; i++)
			{
				1445 7 = this.48.7.3[i];
				if (7.14 == this.38 && (7.9 + num7 < 0 || 7.9 + num7 >= 1226.9()))
				{
					flag2 = false;
					break;
				}
			}
			if (flag2)
			{
				for (int j = 0; j < this.48.7.3.Count; j++)
				{
					1445 8 = this.48.7.3[j];
					if (8.14 == this.38)
					{
						8.9 += num7;
						8.10 += num7;
					}
				}
				this.48.7.3.Sort();
			}
		}
		this.8.41();
	}

	// Token: 0x06002C15 RID: 11285 RVA: 0x000F2F54 File Offset: 0x000F1154
	internal override void Activate()
	{
		this.6.20(false, false);
		this.6.18 = true;
		1662.69.12(0.78125f, true);
		this.3.31();
		this.3.67 = 6;
		1662.69.25(0f, -16f);
		this.3.6.22.29 = new 208(0f, 0f);
		this.3.6.21.29 = new 208(0f, 0f);
		this.3.6.23.29 = new 208(0f, 0f);
		this.3.6.24.29 = new 208(0f, 0f);
		this.8(this.53);
		this.43.22.37 = true;
		this.43.23.37 = true;
		this.43.21.37 = true;
		this.43.24.37 = true;
		this.8.7(1f);
		1226.5 = true;
		base.Activate();
		this.6.18 = false;
	}

	// Token: 0x06002C16 RID: 11286 RVA: 0x000F30C0 File Offset: 0x000F12C0
	internal override void Deactivate()
	{
		this.8.7(0f);
		this.12.5 = 0f;
		this.4.39.5 = 1f;
		1226.5 = false;
		this.43.23.37 = false;
		this.43.22.37 = false;
		this.43.21.37 = false;
		this.43.24.37 = false;
		1535.19();
		base.Deactivate();
	}

	// Token: 0x06002C17 RID: 11287 RVA: 0x000F3158 File Offset: 0x000F1358
	internal override void Draw()
	{
		if (this.44 != null)
		{
			foreach (2647 <<EMPTY_NAME>> in this.45)
			{
				if (<<EMPTY_NAME>> != this.48)
				{
					this.18(<<EMPTY_NAME>>, 198.Silver);
				}
			}
			this.18(this.44, (this.44 == this.48) ? 198.White : 198.Silver);
		}
		this.8.21();
		if (this.48 != null && this.44 != this.48)
		{
			this.18(this.48, 198.White);
		}
		this.12.22();
		base.Draw();
	}

	// Token: 0x06002C18 RID: 11288 RVA: 0x000F322C File Offset: 0x000F142C
	internal override void Dispose()
	{
		if (this.12 != null)
		{
			this.12.Dispose();
		}
		this.8.Dispose();
		base.Dispose();
	}

	// Token: 0x06002C19 RID: 11289 RVA: 0x000F3254 File Offset: 0x000F1454
	internal override void OnBeatmapLoaded()
	{
		if (this.15 != null)
		{
			this.15.7(true);
			this.16.7(true);
			this.19.7(true);
			this.17.7(true);
			this.18.7(true);
			this.28(null, false);
			this.51 = -1;
			this.44 = null;
			this.45.Clear();
			this.8.44 = true;
			this.43 = this.4.32;
			if (this.43 != null)
			{
				this.24();
			}
			if (this.1)
			{
				this.43.23.37 = true;
				this.43.21.37 = true;
				this.43.22.37 = true;
				this.43.24.37 = true;
			}
		}
	}

	// Token: 0x06002C1A RID: 11290 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void UpdateTimelineObjects()
	{
	}

	// Token: 0x06002C1B RID: 11291 RVA: 0x000F3340 File Offset: 0x000F1540
	internal override void DrawTimelineOverlay()
	{
		1662.20.2();
		float num = (float)this.3.66.Height / 4f;
		1662.20.3(new 208((float)this.3.66.GetLeft(), (float)this.3.66.GetTop() + num), 198.Gray);
		1662.20.3(new 208((float)this.3.66.GetRight(), (float)this.3.66.GetTop() + num), 198.Gray);
		1662.20.3(new 208((float)this.3.66.GetLeft(), (float)this.3.66.GetTop() + num * 2f), 198.Gray);
		1662.20.3(new 208((float)this.3.66.GetRight(), (float)this.3.66.GetTop() + num * 2f), 198.Gray);
		1662.20.3(new 208((float)this.3.66.GetLeft(), (float)this.3.66.GetTop() + num * 3f), 198.Gray);
		1662.20.3(new 208((float)this.3.66.GetRight(), (float)this.3.66.GetTop() + num * 3f), 198.Gray);
		if (this.48 != null)
		{
			foreach (1445 <<EMPTY_NAME>> in this.48.7.3)
			{
				if ((this.55 != 0 || <<EMPTY_NAME>>.14 != 1456.Colour) && (this.55 != 1 || <<EMPTY_NAME>>.14 != 1456.Movement))
				{
					bool flag = false;
					bool flag2 = false;
					float 2 = 0f;
					float 3 = 0f;
					float num2 = (float)this.3.66.GetTop() - num * (float)this.55;
					1456 4 = <<EMPTY_NAME>>.14;
					198 5;
					if (4 <= 1456.Rotation)
					{
						if (4 != 1456.Fade)
						{
							if (4 != 1456.Scale)
							{
								if (4 != 1456.Rotation)
								{
									goto IL_253;
								}
								5 = 198.Yellow;
								num2 += num * 3f;
							}
							else
							{
								5 = 198.OrangeRed;
								num2 += num;
							}
						}
						else
						{
							5 = 198.Pink;
							num2 += num * 2f;
						}
					}
					else
					{
						if (4 <= 1456.ParameterFlipHorizontal)
						{
							if (4 == 1456.Colour)
							{
								num2 += num * 4f;
								5 = 198.BlanchedAlmond;
								goto IL_2CC;
							}
							if (4 != 1456.ParameterFlipHorizontal)
							{
								goto IL_253;
							}
						}
						else if (4 != 1456.ParameterFlipVertical)
						{
							if (4 != 1456.VectorScale)
							{
								goto IL_253;
							}
							5 = 198.Yellow;
							num2 += num;
							goto IL_2CC;
						}
						num2 += num * 3f;
						5 = 198.LightBlue;
					}
					IL_2CC:
					if (<<EMPTY_NAME>>.9 >= this.3.62 && <<EMPTY_NAME>>.9 <= this.3.63)
					{
						flag = true;
						2 = this.3.102((double)<<EMPTY_NAME>>.9);
						1662.20.3(new 208(2, num2), 198.Beige);
						1662.20.3(new 208(2, num2 + 0.49f * num), 198.Beige);
					}
					if (<<EMPTY_NAME>>.10 >= this.3.62 && <<EMPTY_NAME>>.10 <= this.3.63)
					{
						flag2 = true;
						3 = this.3.102((double)<<EMPTY_NAME>>.10);
						1662.20.3(new 208(3, num2 + 0.51f * num), 198.Beige);
						1662.20.3(new 208(3, num2 + num), 198.Beige);
					}
					if (!flag && !flag2 && (<<EMPTY_NAME>>.9 >= this.3.62 || <<EMPTY_NAME>>.10 <= this.3.63))
					{
						continue;
					}
					if (flag)
					{
						1662.20.3(new 208(2, num2 + 0.5f * num), 5);
					}
					else
					{
						1662.20.3(new 208((float)this.3.66.GetLeft(), num2 + 0.5f * num), 5);
					}
					if (flag2)
					{
						1662.20.3(new 208(3, num2 + 0.5f * num), 5);
						continue;
					}
					1662.20.3(new 208((float)this.3.66.GetRight(), num2 + 0.5f * num), 5);
					continue;
					IL_253:
					5 = 198.YellowGreen;
					goto IL_2CC;
				}
			}
		}
		1662.20.4();
	}

	// Token: 0x06002C1C RID: 11292 RVA: 0x000F3818 File Offset: 0x000F1A18
	private void 18(2647 1, 198 2)
	{
		1.7.32(2, 4);
	}

	// Token: 0x06002C1D RID: 11293 RVA: 0x000F3827 File Offset: 0x000F1A27
	private void 19(object 1, EventArgs 2)
	{
		this.20(null);
	}

	// Token: 0x06002C1E RID: 11294 RVA: 0x000F3830 File Offset: 0x000F1A30
	internal override void Paste()
	{
		if (this.49 != null)
		{
			2647 <<EMPTY_NAME>> = this.49.Clone();
			if (<<EMPTY_NAME>>.7 != null && <<EMPTY_NAME>>.7.3.Count > 0)
			{
				int 2 = 1226.16 - <<EMPTY_NAME>>.7.3[0].9;
				<<EMPTY_NAME>>.7.23(2);
			}
			this.6.16((2452)2, (2451)8, (2450)131072, null);
			this.6.23(<<EMPTY_NAME>>, false);
			this.43.9(<<EMPTY_NAME>>);
			this.6.20(false, false);
		}
	}

	// Token: 0x06002C1F RID: 11295 RVA: 0x000F38DC File Offset: 0x000F1ADC
	internal override void CopySelection()
	{
		if (this.48 != null)
		{
			this.49 = this.48;
		}
		try
		{
			Clipboard.SetText(1226.19.ToString());
		}
		catch (Exception)
		{
			1763.4(1568.1(2679.General_Editor_ClipboardNotAvailable));
		}
	}

	// Token: 0x06002C20 RID: 11296 RVA: 0x000F3934 File Offset: 0x000F1B34
	internal void 20(string 1)
	{
		if (1 == null)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = Path.GetFullPath(1272.5().44());
			openFileDialog.RestoreDirectory = true;
			if (DialogResult.Cancel != openFileDialog.ShowDialog(1662.13()))
			{
				this.20(openFileDialog.FileName);
			}
			return;
		}
		try
		{
			string path = Path.GetFileName(1).Replace(",", string.Empty);
			string text = Path.Combine(1272.5().44(), path);
			if (1.IndexOf(1272.5().44(), StringComparison.CurrentCultureIgnoreCase) < 0)
			{
				try
				{
					File.Delete(text);
					File.Copy(1, text);
				}
				catch (Exception ex)
				{
					MessageBox.Show(1568.1(2679.EditorModeDesign_ErrorCopyingBackgroundFile) + ex.Message);
				}
			}
			text = 2675.2(text, 2560, 1440);
			2647 2 = this.43.11(Path.GetFileName(text), 0);
			this.6.13 = true;
			for (int i = 0; i < this.43.14.Count; i++)
			{
				if (this.43.14[i] != 2 && this.43.14[i].10 == 2.10)
				{
					this.43.12(this.43.14[i]);
					i--;
				}
			}
			if (2 != null && 2.10 == 2635.Video)
			{
				this.58 = 2;
				this.59.23((double)2.8, false, false);
			}
			else if (2 != null && 2.10 == 2635.Background)
			{
				1272.5().22 = Path.GetFileName(text);
			}
			this.6.13 = true;
			this.43.40();
			this.43.39();
		}
		catch (Exception)
		{
			MessageBox.Show(1568.1(2679.EditorModeDesign_ErrorDuringImportProcess));
		}
	}

	// Token: 0x06002C21 RID: 11297 RVA: 0x000F3B44 File Offset: 0x000F1D44
	private void 21(object 1, EventArgs 2)
	{
		this.22();
	}

	// Token: 0x06002C22 RID: 11298 RVA: 0x000F3B4C File Offset: 0x000F1D4C
	private void 22()
	{
		2298.2301 <<EMPTY_NAME>> = new 2298.2301();
		<<EMPTY_NAME>>.2 = this;
		<<EMPTY_NAME>>.1 = new 1727();
		<<EMPTY_NAME>>.1.3(new EventHandler(<<EMPTY_NAME>>.1));
		1662.25(<<EMPTY_NAME>>.1);
	}

	// Token: 0x06002C23 RID: 11299 RVA: 0x000F3B94 File Offset: 0x000F1D94
	internal void 23(2647 1, 2645 2, int 3)
	{
		this.43.12(1);
		if (3 < 0)
		{
			1.5 = 2;
			this.43.9(1);
		}
		else
		{
			this.43.10(1, 2, 3);
		}
		if (!this.43.28[(int)2])
		{
			this.ClearSelection();
		}
		this.8.44 = true;
	}

	// Token: 0x06002C24 RID: 11300 RVA: 0x000F3BF8 File Offset: 0x000F1DF8
	internal void 24()
	{
		2647 <<EMPTY_NAME>> = this.43.14.Find(new Predicate<2647>(2298.2300.Instance.6));
		if (<<EMPTY_NAME>> != null)
		{
			this.58 = <<EMPTY_NAME>>;
			if (this.59 != null)
			{
				this.59.23((double)<<EMPTY_NAME>>.8, false, false);
			}
		}
	}

	// Token: 0x06002C25 RID: 11301 RVA: 0x000F3C4C File Offset: 0x000F1E4C
	private void 25()
	{
		if (this.48 != null)
		{
			this.6.16((2452)2, (2451)9, (2450)131072, null);
			this.6.23(this.48, false);
			this.43.12(this.48);
			this.6.20(false, false);
			this.48 = null;
			this.51 = -1;
			this.8.44 = true;
		}
	}

	// Token: 0x06002C26 RID: 11302 RVA: 0x000F3CC8 File Offset: 0x000F1EC8
	internal void 26(int 1)
	{
		if (1 == 0)
		{
			return;
		}
		this.6.19((2452)2, null);
		this.6.13((2451)0, (2450)2048);
		foreach (2647 2 in this.43.14)
		{
			if (2 is 2654 || 2 is 2655 || 2 is 2646 || 2 is 2658)
			{
				this.6.23(2, false);
				2.8 += 1;
				2.1 += 1;
				if (2.7 != null)
				{
					foreach (1445 3 in 2.7.3)
					{
						3.9 += 1;
						3.10 += 1;
					}
					if (2.7.4 != null)
					{
						foreach (1457 4 in 2.7.4)
						{
							4.2 += 1;
						}
					}
				}
				foreach (List<2657> list in 2.2.Values)
				{
					foreach (2657 5 in list)
					{
						5.2 += 1;
						5.6 += 1;
						5.5 += 1;
					}
				}
			}
		}
		this.6.20(false, false);
	}

	// Token: 0x06002C27 RID: 11303 RVA: 0x000E26E4 File Offset: 0x000E08E4
	internal override bool IsInputEnabled()
	{
		return base.IsInputEnabled();
	}

	// Token: 0x06002C28 RID: 11304 RVA: 0x000F3F3C File Offset: 0x000F213C
	internal override void SetInputEnabled(bool 1)
	{
		base.SetInputEnabled(1);
		this.12.22 = 1;
	}

	// Token: 0x06002C29 RID: 11305 RVA: 0x000F3F51 File Offset: 0x000F2151
	private static bool 27(2647 1)
	{
		return 1.7.ContainsPoint(1555.21(), 4);
	}

	// Token: 0x06002C2A RID: 11306 RVA: 0x000F3F64 File Offset: 0x000F2164
	internal override bool HandleClick()
	{
		if (!this.IsInputEnabled())
		{
			return false;
		}
		if (this.3.40.23 != null || this.5.23 != null)
		{
			return false;
		}
		if (this.3.70 || this.3.71)
		{
			return false;
		}
		if (!this.60 && this.48 != null && this.48 != this.44 && 2298.27(this.48))
		{
			this.60 = true;
			return false;
		}
		if (this.44 != null)
		{
			this.28(this.44, false);
			return true;
		}
		if (this.3.69)
		{
			this.28(null, false);
			return true;
		}
		return base.HandleClick();
	}

	// Token: 0x06002C2B RID: 11307 RVA: 0x000F4020 File Offset: 0x000F2220
	internal override bool HandleRelease()
	{
		bool flag = false;
		if (!this.46 && this.60)
		{
			flag = this.HandleClick();
		}
		this.60 = false;
		return flag || base.HandleRelease();
	}

	// Token: 0x06002C2C RID: 11308 RVA: 0x000F4058 File Offset: 0x000F2258
	internal override bool HandleDragStart()
	{
		if (this.3.71)
		{
			return false;
		}
		if (this.3.70)
		{
			if (this.48 == null || this.48.7 == null)
			{
				return false;
			}
			float num = (float)this.3.66.Height / 4f;
			for (int i = 0; i < this.48.7.3.Count; i++)
			{
				float num2 = (float)this.3.66.GetTop() - (float)this.55 * num;
				1445 <<EMPTY_NAME>> = this.48.7.3[i];
				1456 2 = <<EMPTY_NAME>>.14;
				if (2 <= 1456.Scale)
				{
					if (2 != 1456.Fade)
					{
						if (2 == 1456.Scale)
						{
							num2 += num;
						}
					}
					else
					{
						num2 += num * 2f;
					}
				}
				else if (2 != 1456.Rotation)
				{
					if (2 == 1456.Colour)
					{
						num2 += num * 4f;
					}
				}
				else
				{
					num2 += num * 3f;
				}
				if (new 1058(this.3.102((double)<<EMPTY_NAME>>.9), num2, this.3.102((double)<<EMPTY_NAME>>.10) - this.3.102((double)<<EMPTY_NAME>>.9), num).9(new 206(1535.5.X, 1535.5.Y)))
				{
					this.38 = <<EMPTY_NAME>>.14;
					this.52 = this.3.103((int)1555.21().X) - <<EMPTY_NAME>>.9;
					break;
				}
			}
			if (this.38 != 1456.None)
			{
				this.40 = new 208((float)1535.5.X, (float)1535.5.Y);
				this.34 = true;
				base.HandleDragStart();
				return true;
			}
			return false;
		}
		else
		{
			if (this.3.59 != (2329)2 && this.3.59 != (2329)0)
			{
				return false;
			}
			if (this.44 == null && (this.48 == null || !2298.27(this.48)))
			{
				return false;
			}
			if (this.3.40.23 != null || this.5.23 != null)
			{
				return false;
			}
			if (this.48 == null)
			{
				return false;
			}
			this.6.19((2452)2, null);
			1456 2 = this.37;
			switch (2)
			{
			case 1456.Movement:
				this.6.13((2451)1, (2450)0);
				this.39 = this.48.7.17 - this.47;
				break;
			case 1456.Fade:
				this.6.13((2451)27, (2450)0);
				this.41 = this.48.7.16;
				break;
			case 1456.Movement | 1456.Fade:
				break;
			case 1456.Scale:
				this.6.13((2451)28, (2450)0);
				this.41 = this.48.7.15;
				break;
			default:
				if (2 != 1456.Rotation)
				{
					if (2 == 1456.VectorScale)
					{
						this.6.13((2451)32, (2450)0);
						this.41 = this.48.7.20.X;
						this.42 = this.48.7.20.Y;
					}
				}
				else
				{
					this.6.13((2451)25, (2450)0);
					this.41 = this.48.7.14;
				}
				break;
			}
			this.6.23(this.48, false);
			this.40 = this.47;
			this.46 = true;
			this.6.13 = true;
			base.HandleDragStart();
			return true;
		}
	}

	// Token: 0x06002C2D RID: 11309 RVA: 0x000F4401 File Offset: 0x000F2601
	internal override void HandleDragEnd()
	{
		this.46 = false;
		this.34 = false;
		this.38 = 1456.None;
		this.6.20(false, false);
		base.HandleDragEnd();
	}

	// Token: 0x06002C2E RID: 11310 RVA: 0x000F442C File Offset: 0x000F262C
	internal override bool HandleKey(200 1, bool 2)
	{
		if (2)
		{
			if (1549.1)
			{
				switch (1)
				{
				case 200.D1:
					this.6(2645.Background);
					return true;
				case 200.D2:
					this.6(2645.Fail);
					return true;
				case 200.D3:
					this.6(2645.Pass);
					return true;
				case 200.D4:
					this.6(2645.Foreground);
					return true;
				default:
					if (1 == 200.V)
					{
						this.Paste();
						return true;
					}
					if (1 == 200.X)
					{
						if (this.48 != null)
						{
							this.49 = this.48.Clone();
							this.25();
							return true;
						}
					}
					break;
				}
			}
			else
			{
				if (1 == 200.I)
				{
					this.22();
					return true;
				}
				if (this.48 != null)
				{
					if (1 <= 200.A)
					{
						if (1 == 200.Delete)
						{
							this.25();
							return true;
						}
						if (1 == 200.A)
						{
							this.47(-1f, 0f);
							return true;
						}
					}
					else
					{
						if (1 == 200.D)
						{
							this.47(1f, 0f);
							return true;
						}
						if (1 == 200.S)
						{
							this.47(0f, 1f);
							return true;
						}
						if (1 == 200.W)
						{
							this.47(0f, -1f);
							return true;
						}
					}
				}
			}
		}
		if (this.59.14())
		{
			if (1549.3)
			{
				this.59.11 = 1.0;
			}
			else
			{
				this.59.11 = 10.0;
			}
			return true;
		}
		return base.HandleKey(1, 2);
	}

	// Token: 0x06002C2F RID: 11311 RVA: 0x000F458D File Offset: 0x000F278D
	internal override void ClearSelection()
	{
		this.28(null, true);
		base.ClearSelection();
	}

	// Token: 0x06002C30 RID: 11312 RVA: 0x000F45A0 File Offset: 0x000F27A0
	internal void 28(2647 1, bool 2)
	{
		this.48 = 1;
		if (2)
		{
			this.Update();
		}
		if (1 != null)
		{
			this.51 = this.54.IndexOf(this.48);
		}
		else
		{
			this.51 = -1;
		}
		this.8.40(this.48);
	}

	// Token: 0x06002C31 RID: 11313 RVA: 0x000F45F4 File Offset: 0x000F27F4
	private void 29(198 1)
	{
		1445 2 = null;
		this.32(1226.16, out 2, true);
		if (2 != null)
		{
			if (2.9 == 1226.16)
			{
				2.3 = 4;
			}
			if (2.10 == 1226.16)
			{
				2.7 = 4;
			}
			1445 3 = this.50.Find((1445 1) => 1.10 == 1226.16);
			if (3 != null && 3 != 2)
			{
				3.7 = 4;
			}
		}
	}

	// Token: 0x06002C32 RID: 11314 RVA: 0x000F4678 File Offset: 0x000F2878
	private void 30(1445 1)
	{
		if (this.46)
		{
			1456 2 = this.37;
			switch (2)
			{
			case 1456.Movement:
				1.6 = this.47 + this.39;
				break;
			case 1456.Fade:
				1.5 = 1052.19((this.41 * 200f + this.40.Y - this.47.Y) / 200f, 0f, 1f);
				break;
			case 1456.Movement | 1456.Fade:
				break;
			case 1456.Scale:
				1.5 = 1052.19((this.41 * 100f + this.40.Y - this.47.Y) / 100f, 0.1f, 5f);
				break;
			default:
				if (2 != 1456.Rotation)
				{
					if (2 == 1456.VectorScale)
					{
						1.6 = new 208(1052.19((this.41 * 100f + this.40.X - this.47.X) / 100f, 0.1f, 5f), 1052.19((this.42 * 100f + this.40.Y - this.47.Y) / 100f, 0.1f, 5f));
					}
				}
				else
				{
					1.5 = 1052.19((this.41 * 50f + this.40.Y - this.47.Y) / 50f, -50f, 50f);
				}
				break;
			}
		}
		else
		{
			1456 2 = this.37;
			switch (2)
			{
			case 1456.Movement:
				1.6 = this.48.7.17;
				break;
			case 1456.Fade:
				1.5 = this.48.7.16;
				break;
			case 1456.Movement | 1456.Fade:
				break;
			case 1456.Scale:
				1.5 = this.48.7.15;
				break;
			default:
				if (2 != 1456.Rotation)
				{
					if (2 == 1456.VectorScale)
					{
						1.6 = this.48.7.20;
					}
				}
				else
				{
					1.5 = this.48.7.14;
				}
				break;
			}
		}
		this.6.13 = true;
	}

	// Token: 0x06002C33 RID: 11315 RVA: 0x000F48DC File Offset: 0x000F2ADC
	private void 31(1445 1)
	{
		if (this.46)
		{
			1456 2 = this.37;
			switch (2)
			{
			case 1456.Movement:
				1.2 = this.47 + this.39;
				break;
			case 1456.Fade:
				1.1 = 1052.19((this.41 * 200f + this.40.Y - this.47.Y) / 200f, 0f, 1f);
				break;
			case 1456.Movement | 1456.Fade:
				break;
			case 1456.Scale:
				1.1 = 1052.19((this.41 * 100f + this.40.Y - this.47.Y) / 100f, 0.1f, 5f);
				break;
			default:
				if (2 != 1456.Rotation)
				{
					if (2 == 1456.VectorScale)
					{
						1.2 = new 208(1052.19((this.41 * 100f + this.40.X - this.47.X) / 100f, 0.1f, 5f), 1052.19((this.42 * 100f + this.40.Y - this.47.Y) / 100f, 0.1f, 5f));
					}
				}
				else
				{
					1.1 = 1052.19((this.41 * 50f + this.40.Y - this.47.Y) / 50f, -50f, 50f);
				}
				break;
			}
		}
		else
		{
			1456 2 = this.37;
			switch (2)
			{
			case 1456.Movement:
				1.2 = this.48.7.17;
				break;
			case 1456.Fade:
				1.1 = this.48.7.16;
				break;
			case 1456.Movement | 1456.Fade:
				break;
			case 1456.Scale:
				1.1 = this.48.7.15;
				break;
			default:
				if (2 != 1456.Rotation)
				{
					if (2 == 1456.VectorScale)
					{
						1.2 = this.48.7.20;
					}
				}
				else
				{
					1.1 = this.48.7.14;
				}
				break;
			}
		}
		this.6.13 = true;
	}

	// Token: 0x06002C34 RID: 11316 RVA: 0x000F4B40 File Offset: 0x000F2D40
	internal int 32(int 1, out 1445 2, bool 3)
	{
		2298.2299 4 = new 2298.2299();
		this.6.13 = true;
		int num = -1;
		4.1 = null;
		2 = null;
		if (this.48 == null)
		{
			return num;
		}
		1433 5 = this.48.7;
		for (int i = this.50.Count - 1; i >= 0; i--)
		{
			1445 6 = this.50[i];
			if (6.10 == 1)
			{
				4.1 = 6;
				num = 5.3.IndexOf(6);
				break;
			}
			if (6.9 == 1)
			{
				4.1 = 6;
				num = 5.3.IndexOf(6);
				break;
			}
			if (6.9 == 6.10)
			{
				if (6.10 > 1)
				{
					6.9 = 1;
				}
				else
				{
					6.10 = 1;
				}
				4.1 = 6;
				num = 5.3.IndexOf(6);
				break;
			}
			if (6.9 > 1 && i == 0)
			{
				4.1 = new 1445
				{
					9 = 1,
					10 = 6.9,
					14 = this.37,
					6 = 6.2,
					5 = 6.1,
					7 = 6.3
				};
				num = 5.3.IndexOf(6);
				this.6.13((2451)30, (2450)0);
				this.6.23(new 2445.2446(this.48, 4.1, num), false);
				5.3.Insert(num, 4.1);
				break;
			}
			if (i == this.50.Count - 1 && 6.10 < 1226.16)
			{
				4.1 = new 1445
				{
					9 = 6.10,
					10 = 1,
					14 = this.37,
					2 = 6.6,
					1 = 6.5,
					3 = 6.7
				};
				num = 5.3.IndexOf(6) + 1;
				this.6.13((2451)30, (2450)0);
				this.6.23(new 2445.2446(this.48, 4.1, num), false);
				5.3.Insert(num, 4.1);
				break;
			}
			if (6.10 > 1)
			{
				if (6.9 < 1)
				{
					4.1 = new 1445
					{
						9 = 1,
						10 = 6.10,
						14 = this.37,
						6 = 6.6,
						5 = 6.5,
						7 = 6.7
					};
					6.10 = 1;
					num = 5.3.IndexOf(6) + 1;
					this.6.13((2451)30, (2450)0);
					this.6.23(new 2445.2446(this.48, 4.1, num), false);
					5.3.Insert(num, 4.1);
					break;
				}
				if (this.50[i - 1].10 < 1)
				{
					num = 5.3.IndexOf(6);
					4.1 = new 1445
					{
						9 = 1,
						10 = 6.9,
						14 = this.37,
						6 = 6.2,
						5 = 6.1,
						7 = 6.3
					};
					this.6.13((2451)30, (2450)0);
					this.6.23(new 2445.2446(this.48, 4.1, num), false);
					5.3.Insert(num, 4.1);
					4.1 = new 1445
					{
						9 = this.50[i - 1].10,
						10 = 1,
						14 = this.37,
						2 = this.50[i - 1].6,
						1 = this.50[i - 1].5,
						3 = this.50[i - 1].7
					};
					this.6.13((2451)30, (2450)0);
					this.6.23(new 2445.2446(this.48, 4.1, num), false);
					5.3.Insert(num, 4.1);
					break;
				}
			}
		}
		if (4.1 == null)
		{
			if (!3)
			{
				return -1;
			}
			4.1 = new 1445
			{
				9 = 1,
				10 = 1,
				14 = this.37
			};
			this.6.13((2451)30, (2450)0);
			this.6.23(new 2445.2446(this.48, 4.1, 0), false);
			5.3.Insert(0, 4.1);
		}
		bool flag = 4.1.9 == 1226.16;
		bool flag2 = 4.1.10 == 1226.16;
		if (flag && flag2)
		{
			this.31(4.1);
			this.30(4.1);
		}
		else if (flag2)
		{
			this.30(4.1);
			1445 7 = this.50.Find(new Predicate<1445>(4.1));
			if (7 != null)
			{
				this.31(7);
			}
		}
		else if (flag)
		{
			this.31(4.1);
			1445 8 = this.50.Find(new Predicate<1445>(4.2));
			if (8 != null)
			{
				this.30(8);
			}
		}
		2 = 4.1;
		return num;
	}

	// Token: 0x06002C35 RID: 11317 RVA: 0x000F5134 File Offset: 0x000F3334
	internal void 33(int 1)
	{
		if (this.48 == null)
		{
			return;
		}
		int num = -1;
		int num2 = -1;
		for (int i = 0; i < this.50.Count; i++)
		{
			1445 2 = this.50[i];
			if (2.9 == 1 && 2.10 == 1)
			{
				this.6.13((2451)31, (2450)0);
				this.6.23(new 2445.2446(this.48, 2, this.48.7.3.IndexOf(2)), false);
				this.48.7.3.Remove(2);
				return;
			}
			if (2.9 == 1)
			{
				num2 = i;
				break;
			}
			if (2.10 == 1)
			{
				num = i;
			}
		}
		if (num >= 0 && num2 >= 0)
		{
			1445 3 = this.50[num2];
			1445 4 = this.50[num];
			this.6.13((2451)31, (2450)0);
			this.6.23(new 2445.2446(this.48, 3, this.48.7.3.IndexOf(3)), false);
			this.6.23(new 2445.2446(this.48, 4, this.48.7.3.IndexOf(4)), false);
			this.48.7.3.Remove(3);
			this.48.7.3.Remove(4);
			1445 5 = new 1445();
			5.14 = 4.14;
			5.6 = 3.6;
			5.5 = 3.5;
			5.7 = 3.7;
			5.2 = 4.2;
			5.1 = 4.1;
			5.3 = 4.3;
			5.9 = 4.9;
			5.10 = 3.10;
			this.6.13((2451)30, (2450)0);
			this.6.23(new 2445.2446(this.48, 5, num), false);
			this.48.7.3.Insert(num, 5);
			return;
		}
		if (num >= 0)
		{
			1445 6 = this.50[num];
			6.10 = 6.9;
			6.6 = 6.2;
			6.5 = 6.1;
			6.7 = 6.3;
		}
		if (num2 >= 0)
		{
			1445 7 = this.50[num2];
			7.9 = 7.10;
			7.2 = 7.6;
			7.1 = 7.5;
			7.3 = 7.7;
		}
	}

	// Token: 0x06002C36 RID: 11318 RVA: 0x000F5404 File Offset: 0x000F3604
	private void 34()
	{
		if (this.48 == null)
		{
			return;
		}
		1445 <<EMPTY_NAME>> = this.50.FindLast(new Predicate<1445>(2298.2300.Instance.7));
		if (<<EMPTY_NAME>> != null)
		{
			if (<<EMPTY_NAME>>.10 < 1226.16)
			{
				1226.4(<<EMPTY_NAME>>.10, false, false);
				return;
			}
			if (<<EMPTY_NAME>>.9 < 1226.16)
			{
				1226.4(<<EMPTY_NAME>>.9, false, false);
			}
		}
	}

	// Token: 0x06002C37 RID: 11319 RVA: 0x000F5470 File Offset: 0x000F3670
	private void 35()
	{
		if (this.48 == null)
		{
			return;
		}
		1445 <<EMPTY_NAME>> = this.50.Find((1445 1) => 1.9 > 1226.16 || 1.10 > 1226.16);
		if (<<EMPTY_NAME>> != null)
		{
			if (<<EMPTY_NAME>>.9 > 1226.16)
			{
				1226.4(<<EMPTY_NAME>>.9, false, false);
				return;
			}
			if (<<EMPTY_NAME>>.10 > 1226.16)
			{
				1226.4(<<EMPTY_NAME>>.10, false, false);
			}
		}
	}

	// Token: 0x06002C38 RID: 11320 RVA: 0x000F54EC File Offset: 0x000F36EC
	private void 36(bool 1)
	{
		if (this.48 == null)
		{
			return;
		}
		if (!1)
		{
			this.30.7(false);
			this.31.7(false);
		}
		this.6.18((2452)2, (2451)33, this.48);
		if (1)
		{
			int num = this.50.FindIndex(new Predicate<1445>(2298.2300.Instance.8));
			if (num >= 0)
			{
				this.6.20(true, false);
				return;
			}
			num = this.50.FindLastIndex(new Predicate<1445>(2298.2300.Instance.9));
			if (num < 0)
			{
				this.6.20(true, false);
				return;
			}
			1445 2 = this.50[num];
			int num2 = -1;
			1445 3;
			if (2.9 == 2.10)
			{
				num2 = this.48.7.3.IndexOf(2);
				3 = 2;
			}
			else
			{
				3 = 2.Clone();
				3.9 = 3.10;
				3.1 = 3.5;
				3.2 = 3.6;
				3.3 = 3.7;
			}
			num = this.50.FindIndex(new Predicate<1445>(2298.2300.Instance.10));
			if (num < 0)
			{
				this.6.20(true, false);
				return;
			}
			if (num2 >= 0)
			{
				this.6.13((2451)31, (2450)0);
				this.6.23(new 2445.2446(this.48, this.48.7.3[num2], num2), false);
				this.48.7.3.RemoveAt(num2);
			}
			2 = this.50[num];
			if (2.9 == 2.10)
			{
				num2 = this.48.7.3.IndexOf(2);
				this.6.13((2451)31, (2450)0);
				this.6.23(new 2445.2446(this.48, this.48.7.3[num2], num2), false);
				this.48.7.3.RemoveAt(num2);
			}
			3.5 = 2.1;
			3.6 = 2.2;
			3.7 = 2.3;
			3.10 = 2.9;
			this.6.13((2451)30, (2450)0);
			if (num2 >= 0)
			{
				this.6.23(new 2445.2446(this.48, 3, num2), false);
				this.48.7.3.Insert(num2, 3);
			}
			else
			{
				this.6.23(new 2445.2446(this.48, 3, num + 1), false);
				this.48.7.3.Insert(num + 1, 3);
			}
		}
		else
		{
			int num3 = this.50.FindIndex(new Predicate<1445>(2298.2300.Instance.11));
			if (num3 < 0)
			{
				this.6.20(true, false);
				return;
			}
			1445 4 = this.50[num3];
			int num4 = this.48.7.3.IndexOf(4);
			this.6.13((2451)31, (2450)0);
			this.6.23(new 2445.2446(this.48, this.48.7.3[num4], num4), false);
			this.48.7.3.RemoveAt(num4);
			if (num3 == this.50.Count - 1 || this.50[num3 + 1].9 != 4.10)
			{
				1445 5 = 4.Clone();
				5.9 = 5.10;
				5.1 = 5.5;
				5.2 = 5.6;
				5.3 = 5.7;
				this.6.13((2451)30, (2450)0);
				this.6.23(new 2445.2446(this.48, 5, num4), false);
				this.48.7.3.Insert(num4, 5);
			}
			if (num3 == 0 || this.50[num3 - 1].10 != 4.9)
			{
				1445 6 = 4.Clone();
				6.10 = 6.9;
				6.5 = 6.1;
				6.6 = 6.2;
				6.7 = 6.3;
				this.6.13((2451)30, (2450)0);
				this.6.23(new 2445.2446(this.48, 6, num4), false);
				this.48.7.3.Insert(num4, 6);
			}
		}
		this.6.20(false, false);
	}

	// Token: 0x06002C39 RID: 11321 RVA: 0x000F59D4 File Offset: 0x000F3BD4
	private void 37(1046 1)
	{
		if (this.48 != null)
		{
			this.35 = 1;
			this.30.7(this.35 == (1046)2);
			this.31.7(this.35 == (1046)1);
			if (!this.32.4() && this.35 != (1046)0)
			{
				this.32.5(true);
			}
			1445 2 = this.50.Find(new Predicate<1445>(2298.2300.Instance.12));
			if (2 != null)
			{
				this.6.18((2452)2, (2451)34, this.48);
				this.6.23(2, false);
				2.15 = this.35;
				this.6.20(false, false);
			}
		}
	}

	// Token: 0x06002C3A RID: 11322 RVA: 0x000F5A98 File Offset: 0x000F3C98
	private void 38(object 1, EventArgs 2)
	{
		if (this.48 == null)
		{
			return;
		}
		this.46();
		if (this.37 != 1456.Colour)
		{
			1445 3;
			this.32(1226.16, out 3, true);
		}
		else
		{
			ColorDialog colorDialog = new ColorDialog();
			if (colorDialog.ShowDialog() == DialogResult.OK)
			{
				this.29(new 198(colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B));
			}
		}
		this.6.20(false, false);
	}

	// Token: 0x06002C3B RID: 11323 RVA: 0x000F5B20 File Offset: 0x000F3D20
	private void 39(object 1, EventArgs 2)
	{
		if (this.48 != null)
		{
			this.46();
			this.33(1226.16);
			this.6.20(false, false);
		}
	}

	// Token: 0x06002C3C RID: 11324 RVA: 0x000F5B48 File Offset: 0x000F3D48
	private void 40(object 1, EventArgs 2)
	{
		this.35();
	}

	// Token: 0x06002C3D RID: 11325 RVA: 0x000F5B50 File Offset: 0x000F3D50
	private void 41(object 1, bool 2)
	{
		this.37(2 ? ((1046)2) : ((1046)0));
	}

	// Token: 0x06002C3E RID: 11326 RVA: 0x000F5B5F File Offset: 0x000F3D5F
	private void 42(object 1, bool 2)
	{
		this.37(2 ? ((1046)1) : ((1046)0));
	}

	// Token: 0x06002C3F RID: 11327 RVA: 0x000F5B70 File Offset: 0x000F3D70
	private void 43(bool 1)
	{
		if (this.55 == 0 && !1)
		{
			this.55 = 1;
			this.56.SetText("Scale\nFade\nRotation\nColour");
			return;
		}
		if (this.55 == 1 && 1)
		{
			this.55 = 0;
			this.56.SetText("Movement\nScale\nFade\nRotation");
		}
	}

	// Token: 0x06002C40 RID: 11328 RVA: 0x000F5BC4 File Offset: 0x000F3DC4
	private void 44(1456 1, bool 2)
	{
		if (this.48 != null)
		{
			1456 3 = this.37;
			this.37 = 5;
			this.46();
			this.50 = this.48.7.3.FindAll((1445 1) => 1.14 == this.37);
			1445 4;
			this.32(1226.16, out 4, true);
			if (!2)
			{
				this.6.13((2451)31, (2450)0);
				this.6.23(4, false);
				this.48.7.3.Remove(4);
			}
			this.6.20(false, false);
			this.37 = 3;
		}
	}

	// Token: 0x06002C41 RID: 11329 RVA: 0x000F5C70 File Offset: 0x000F3E70
	private void 45(1456 1)
	{
		if (this.37 != 1)
		{
			this.22.7(1 == 1456.Fade);
			this.27.7(1 == 1456.Scale);
			this.28.7(1 == 1456.VectorScale);
			this.25.7(1 == 1456.Movement);
			this.26.7(1 == 1456.Rotation);
			this.29.7(1 == 1456.Colour);
			this.37 = 1;
		}
	}

	// Token: 0x06002C42 RID: 11330 RVA: 0x000F5CEC File Offset: 0x000F3EEC
	private void 46()
	{
		if (this.48 != null)
		{
			this.6.19((2452)2, null);
			1456 <<EMPTY_NAME>> = this.37;
			if (<<EMPTY_NAME>> <= 1456.Colour)
			{
				switch (<<EMPTY_NAME>>)
				{
				case 1456.Movement:
					this.6.13((2451)1, (2450)0);
					break;
				case 1456.Fade:
					this.6.13((2451)27, (2450)0);
					break;
				case 1456.Movement | 1456.Fade:
					break;
				case 1456.Scale:
					this.6.13((2451)28, (2450)0);
					break;
				default:
					if (<<EMPTY_NAME>> != 1456.Rotation)
					{
						if (<<EMPTY_NAME>> == 1456.Colour)
						{
							this.6.13((2451)29, (2450)0);
						}
					}
					else
					{
						this.6.13((2451)25, (2450)0);
					}
					break;
				}
			}
			else if (<<EMPTY_NAME>> != 1456.ParameterFlipHorizontal)
			{
				if (<<EMPTY_NAME>> != 1456.ParameterFlipVertical)
				{
					if (<<EMPTY_NAME>> == 1456.VectorScale)
					{
						this.6.13((2451)32, (2450)0);
					}
				}
				else
				{
					this.6.13((2451)24, (2450)2);
				}
			}
			else
			{
				this.6.13((2451)24, (2450)1);
			}
			this.6.23(this.48, false);
		}
	}

	// Token: 0x06002C43 RID: 11331 RVA: 0x000F5DF0 File Offset: 0x000F3FF0
	private void 47(float 1, float 2)
	{
		2298.2302 3 = new 2298.2302();
		if (this.48 == null)
		{
			return;
		}
		3.1 = this.37;
		if (this.37 != 1456.Movement)
		{
			this.37 = 1456.Movement;
			this.50 = this.48.7.3.FindAll(new Predicate<1445>(2298.2300.Instance.4));
		}
		this.6.18((2452)2, (2451)1, this.48);
		1445 4;
		this.32(1226.16, out 4, true);
		if (4 == null)
		{
			this.6.20(false, false);
			return;
		}
		208 5 = new 208(1, 2);
		if (4.9 == 1226.16)
		{
			4.2 += 5;
		}
		if (4.10 == 1226.16)
		{
			4.6 += 5;
		}
		1445 6 = this.50.Find(new Predicate<1445>(2298.2300.Instance.5));
		if (6 != null && 6 != 4)
		{
			6.6 += 5;
		}
		this.6.20(false, false);
		if (3.1 != this.37)
		{
			this.37 = 3.1;
			this.50 = this.48.7.3.FindAll(new Predicate<1445>(3.1));
		}
	}

	// Token: 0x06002C44 RID: 11332 RVA: 0x000F5F50 File Offset: 0x000F4150
	private void 48(object 1, EventArgs 2)
	{
		this.43(true);
	}

	// Token: 0x06002C45 RID: 11333 RVA: 0x000F5F59 File Offset: 0x000F4159
	private void 49(object 1, bool 2)
	{
		this.45(1456.Movement);
	}

	// Token: 0x06002C46 RID: 11334 RVA: 0x000F5F62 File Offset: 0x000F4162
	private void 50(object 1, bool 2)
	{
		this.45(1456.Scale);
	}

	// Token: 0x06002C47 RID: 11335 RVA: 0x000F5F6B File Offset: 0x000F416B
	private void 51(object 1, bool 2)
	{
		this.45(1456.Rotation);
	}

	// Token: 0x06002C48 RID: 11336 RVA: 0x000F5F74 File Offset: 0x000F4174
	private void 52(object 1, bool 2)
	{
		this.45(1456.Colour);
	}

	// Token: 0x06002C49 RID: 11337 RVA: 0x000F5F7E File Offset: 0x000F417E
	private void 53(object 1, bool 2)
	{
		this.44(1456.ParameterFlipHorizontal, 2);
	}

	// Token: 0x06002C4A RID: 11338 RVA: 0x000F5F89 File Offset: 0x000F4189
	private void 54(object 1, bool 2)
	{
		this.44(1456.ParameterFlipVertical, 2);
	}

	// Token: 0x06002C4B RID: 11339 RVA: 0x000F5F94 File Offset: 0x000F4194
	private bool 55(1445 1)
	{
		return 1.14 == this.37;
	}

	// Token: 0x06002C4C RID: 11340 RVA: 0x000F5FA4 File Offset: 0x000F41A4
	private bool 56(1445 1)
	{
		return 1.14 == this.38;
	}

	// Token: 0x04002039 RID: 8249
	internal 2358 8;

	// Token: 0x0400203A RID: 8250
	private 1452 9;

	// Token: 0x0400203B RID: 8251
	private 1452 10;

	// Token: 0x0400203C RID: 8252
	private 1452 11;

	// Token: 0x0400203D RID: 8253
	private 1436 12;

	// Token: 0x0400203E RID: 8254
	private 1364 13;

	// Token: 0x0400203F RID: 8255
	private 1364 14;

	// Token: 0x04002040 RID: 8256
	private 1364 15;

	// Token: 0x04002041 RID: 8257
	private 1364 16;

	// Token: 0x04002042 RID: 8258
	private 1364 17;

	// Token: 0x04002043 RID: 8259
	private 1364 18;

	// Token: 0x04002044 RID: 8260
	private 1364 19;

	// Token: 0x04002045 RID: 8261
	private 1364 20;

	// Token: 0x04002046 RID: 8262
	private 1364 21;

	// Token: 0x04002047 RID: 8263
	private 1364 22;

	// Token: 0x04002048 RID: 8264
	private 1364 23;

	// Token: 0x04002049 RID: 8265
	private 1364 24;

	// Token: 0x0400204A RID: 8266
	private 1364 25;

	// Token: 0x0400204B RID: 8267
	private 1364 26;

	// Token: 0x0400204C RID: 8268
	private 1364 27;

	// Token: 0x0400204D RID: 8269
	private 1364 28;

	// Token: 0x0400204E RID: 8270
	private 1364 29;

	// Token: 0x0400204F RID: 8271
	private 1364 30;

	// Token: 0x04002050 RID: 8272
	private 1364 31;

	// Token: 0x04002051 RID: 8273
	private 1364 32;

	// Token: 0x04002052 RID: 8274
	private bool 33;

	// Token: 0x04002053 RID: 8275
	private bool 34;

	// Token: 0x04002054 RID: 8276
	private 1046 35;

	// Token: 0x04002055 RID: 8277
	private 1065 36;

	// Token: 0x04002056 RID: 8278
	internal 1456 37;

	// Token: 0x04002057 RID: 8279
	private 1456 38;

	// Token: 0x04002058 RID: 8280
	private 208 39;

	// Token: 0x04002059 RID: 8281
	private 208 40;

	// Token: 0x0400205A RID: 8282
	private float 41;

	// Token: 0x0400205B RID: 8283
	private float 42;

	// Token: 0x0400205C RID: 8284
	private 2648 43;

	// Token: 0x0400205D RID: 8285
	private 2647 44;

	// Token: 0x0400205E RID: 8286
	private List<2647> 45 = new List<2647>();

	// Token: 0x0400205F RID: 8287
	private bool 46;

	// Token: 0x04002060 RID: 8288
	private 208 47;

	// Token: 0x04002061 RID: 8289
	internal 2647 48;

	// Token: 0x04002062 RID: 8290
	private 2647 49;

	// Token: 0x04002063 RID: 8291
	private List<1445> 50;

	// Token: 0x04002064 RID: 8292
	internal int 51;

	// Token: 0x04002065 RID: 8293
	private int 52;

	// Token: 0x04002066 RID: 8294
	public bool 53;

	// Token: 0x04002067 RID: 8295
	private List<2647> 54;

	// Token: 0x04002068 RID: 8296
	private int 55;

	// Token: 0x04002069 RID: 8297
	private 1452 56;

	// Token: 0x0400206A RID: 8298
	private 1452 57;

	// Token: 0x0400206B RID: 8299
	private 2647 58;

	// Token: 0x0400206C RID: 8300
	private 1429 59;

	// Token: 0x0400206D RID: 8301
	private bool 60;

	// Token: 0x0200059A RID: 1434
	public sealed class 2301
	{
		// Token: 0x06002C54 RID: 11348 RVA: 0x000F5FF0 File Offset: 0x000F41F0
		internal void 1(object 1, EventArgs 2)
		{
			if (this.1.25 != null)
			{
				2647 3 = (!this.1.26) ? new 2655(this.1.25, new 208(320f, 240f), 1065.Centre, 2645.Foreground, false) : new 2646(this.1.25, new 208(320f, 240f), 1065.Centre, 2645.Foreground, this.1.27, this.1.28, false, 1446.LoopForever);
				this.2.6.16((2452)2, (2451)8, (2450)131072, null);
				this.2.6.23(3, false);
				this.2.43.9(3);
				this.2.28(3, true);
				this.2.46();
				1445 4;
				this.2.32(1226.16, out 4, true);
				this.2.6.20(false, false);
				this.2.8.44 = true;
			}
		}

		// Token: 0x0400206E RID: 8302
		public 1727 1;

		// Token: 0x0400206F RID: 8303
		public 2298 2;
	}

	// Token: 0x0200059B RID: 1435
	[Serializable]
	public sealed class 2300
	{
		// Token: 0x06002C56 RID: 11350 RVA: 0x000F610A File Offset: 0x000F430A
		internal bool 1(1445 1)
		{
			return 1.9 <= 1226.16 && 1.10 >= 1226.16;
		}

		// Token: 0x06002C57 RID: 11351 RVA: 0x000F612B File Offset: 0x000F432B
		internal bool 2(1445 1)
		{
			return 1.9 <= 1226.16 && 1.10 >= 1226.16 && 1.14 == 1456.ParameterFlipHorizontal;
		}

		// Token: 0x06002C58 RID: 11352 RVA: 0x000F6153 File Offset: 0x000F4353
		internal bool 3(1445 1)
		{
			return 1.9 <= 1226.16 && 1.10 >= 1226.16 && 1.14 == 1456.ParameterFlipVertical;
		}

		// Token: 0x06002C59 RID: 11353 RVA: 0x000BA3D9 File Offset: 0x000B85D9
		internal bool 4(1445 1)
		{
			return 1.14 == 1456.Movement;
		}

		// Token: 0x06002C5A RID: 11354 RVA: 0x000F617B File Offset: 0x000F437B
		internal bool 5(1445 1)
		{
			return 1.10 == 1226.16;
		}

		// Token: 0x06002C5B RID: 11355 RVA: 0x000F618A File Offset: 0x000F438A
		internal bool 6(2647 1)
		{
			return 1.10 == 2635.Video;
		}

		// Token: 0x06002C5C RID: 11356 RVA: 0x000F6195 File Offset: 0x000F4395
		internal bool 7(1445 1)
		{
			return 1.9 < 1226.16 || 1.10 < 1226.16;
		}

		// Token: 0x06002C5D RID: 11357 RVA: 0x000F610A File Offset: 0x000F430A
		internal bool 8(1445 1)
		{
			return 1.9 <= 1226.16 && 1.10 >= 1226.16;
		}

		// Token: 0x06002C5E RID: 11358 RVA: 0x000F61B3 File Offset: 0x000F43B3
		internal bool 9(1445 1)
		{
			return 1.10 < 1226.16;
		}

		// Token: 0x06002C5F RID: 11359 RVA: 0x000F61C2 File Offset: 0x000F43C2
		internal bool 10(1445 1)
		{
			return 1.9 > 1226.16;
		}

		// Token: 0x06002C60 RID: 11360 RVA: 0x000F610A File Offset: 0x000F430A
		internal bool 11(1445 1)
		{
			return 1.9 <= 1226.16 && 1.10 >= 1226.16;
		}

		// Token: 0x06002C61 RID: 11361 RVA: 0x000F610A File Offset: 0x000F430A
		internal bool 12(1445 1)
		{
			return 1.9 <= 1226.16 && 1.10 >= 1226.16;
		}

		// Token: 0x04002070 RID: 8304
		public static readonly 2298.2300 Instance = new 2298.2300();

		// Token: 0x04002071 RID: 8305
		public static Predicate<1445> predicate;

		// Token: 0x04002072 RID: 8306
		public static Predicate<1445> predicate2;

		// Token: 0x04002073 RID: 8307
		public static Predicate<1445> predicate3;

		// Token: 0x04002074 RID: 8308
		public static Predicate<1445> predicate4;

		// Token: 0x04002075 RID: 8309
		public static Predicate<1445> predicate5;

		// Token: 0x04002076 RID: 8310
		public static Predicate<1445> predicate6;

		// Token: 0x04002077 RID: 8311
		public static Predicate<2647> predicate7;

		// Token: 0x04002078 RID: 8312
		public static Predicate<1445> predicate8;

		// Token: 0x04002079 RID: 8313
		public static Predicate<1445> predicate9;

		// Token: 0x0400207A RID: 8314
		public static Predicate<1445> predicate10;

		// Token: 0x0400207B RID: 8315
		public static Predicate<1445> predicate11;

		// Token: 0x0400207C RID: 8316
		public static Predicate<1445> predicate12;

		// Token: 0x0400207D RID: 8317
		public static Predicate<1445> predicate13;

		// Token: 0x0400207E RID: 8318
		public static Predicate<1445> predicate14;
	}

	// Token: 0x0200059C RID: 1436
	public sealed class 2299
	{
		// Token: 0x06002C64 RID: 11364 RVA: 0x000F61DD File Offset: 0x000F43DD
		internal bool 1(1445 1)
		{
			return 1.9 == this.1.10;
		}

		// Token: 0x06002C65 RID: 11365 RVA: 0x000F61F2 File Offset: 0x000F43F2
		internal bool 2(1445 1)
		{
			return 1.10 == this.1.9;
		}

		// Token: 0x0400207F RID: 8319
		public 1445 1;
	}

	// Token: 0x0200059D RID: 1437
	public sealed class 2302
	{
		// Token: 0x06002C67 RID: 11367 RVA: 0x000F6207 File Offset: 0x000F4407
		internal bool 1(1445 1)
		{
			return 1.14 == this.1;
		}

		// Token: 0x04002080 RID: 8320
		public 1456 1;
	}
}
