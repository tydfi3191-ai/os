using System;
using System.Collections.Generic;

// Token: 0x020006D3 RID: 1747
public sealed class 2187 : 2504
{
	// Token: 0x060033C8 RID: 13256 RVA: 0x0013D007 File Offset: 0x0013B207
	public 2187(2486 1) : base(1)
	{
	}

	// Token: 0x060033C9 RID: 13257 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal override bool ShouldShowBeatmapMessages()
	{
		return false;
	}

	// Token: 0x060033CA RID: 13258 RVA: 0x0013D026 File Offset: 0x0013B226
	internal override 208 GetReplayCursorPosition()
	{
		return new 208((float)((!1535.15 && !1535.44) ? ((1535.17 || 1535.46) ? 640 : 320) : 0), 9999f);
	}

	// Token: 0x060033CB RID: 13259 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool ShouldShowScoreboard()
	{
		return true;
	}

	// Token: 0x060033CC RID: 13260 RVA: 0x0013D05E File Offset: 0x0013B25E
	internal override 208 GetScoreboardPosition()
	{
		return new 208(0f, 264f);
	}

	// Token: 0x060033CD RID: 13261 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool AllowsScoreSubmission()
	{
		return true;
	}

	// Token: 0x060033CE RID: 13262 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool CanResumeWithoutCursorClick()
	{
		return true;
	}

	// Token: 0x060033CF RID: 13263 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal override bool ShouldShowLowHealthEffect()
	{
		return false;
	}

	// Token: 0x060033D0 RID: 13264 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal override bool ShouldPlayCountdown()
	{
		return false;
	}

	// Token: 0x060033D1 RID: 13265 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal override bool ShouldShowBreakSections()
	{
		return false;
	}

	// Token: 0x060033D2 RID: 13266 RVA: 0x0013D070 File Offset: 0x0013B270
	internal override bool AreAllObjectsJudged()
	{
		2241 <<EMPTY_NAME>> = this.4;
		if (((<<EMPTY_NAME>> != null) ? <<EMPTY_NAME>>.39 : null) != null)
		{
			return this.4.GetJudgementCount() == this.17;
		}
		return this.5.34.FindAll(new Predicate<2034>(2187.2188.instance.1)).Count == this.4.GetJudgementCount();
	}

	// Token: 0x060033D3 RID: 13267 RVA: 0x0013D0D7 File Offset: 0x0013B2D7
	internal override bool ShouldHideCursor()
	{
		return 2486.14 || base.ShouldHideCursor() || 1535.1();
	}

	// Token: 0x060033D4 RID: 13268 RVA: 0x0013D0F1 File Offset: 0x0013B2F1
	protected override void CreateScoreDisplay()
	{
		this.10 = new 2190(this.2);
	}

	// Token: 0x060033D5 RID: 13269 RVA: 0x0013D104 File Offset: 0x0013B304
	internal override void ApplyGameplayMods()
	{
		base.ApplyGameplayMods();
		2023 <<EMPTY_NAME>> = 2486.88.8;
		2023 2 = 2023.Flashlight;
		if ((<<EMPTY_NAME>> & 2) > 2023.None)
		{
			1433 3 = new 1433(1662.34, (1376)3, 1065.TopLeft, (1044)0, new 208(640f, 0f), 0f, true, 198.Black, null);
			3.15 = 1.6f;
			3.20 = new 208((float)(1662.70.1() - 640), (float)1662.70.2());
			this.16.12(3);
		}
	}

	// Token: 0x060033D6 RID: 13270 RVA: 0x0013D198 File Offset: 0x0013B398
	internal new static bool 13(int 1)
	{
		double num = 1226.76();
		return 1226.64() % (num * 2.0 / (double)1) >= num / (double)1;
	}

	// Token: 0x060033D7 RID: 13271 RVA: 0x0013D1C8 File Offset: 0x0013B3C8
	public override void Dispose()
	{
		if (this.7)
		{
			this.39.Dispose();
		}
		base.Dispose();
	}

	// Token: 0x060033D8 RID: 13272 RVA: 0x0013D1E3 File Offset: 0x0013B3E3
	internal override void AfterObjectUpdate()
	{
		if (this.7)
		{
			base.AfterObjectUpdate();
			this.39.1.5 = this.1.5;
			this.39.Draw();
			this.14();
		}
	}

	// Token: 0x060033D9 RID: 13273 RVA: 0x0013D220 File Offset: 0x0013B420
	internal override void UpdateModeState()
	{
		this.39.Update();
		if (this.42.Count > 1)
		{
			this.42.RemoveAll(new Predicate<1433>(2187.2188.instance.2));
		}
		if (1662.23)
		{
			foreach (1433 <<EMPTY_NAME>> in this.34)
			{
				1433 2 = <<EMPTY_NAME>>;
				2.17.X = 2.17.X + (<<EMPTY_NAME>>.7.X - <<EMPTY_NAME>>.17.X + 2f) * 0.065f;
				<<EMPTY_NAME>>.15 *= 0.965f;
				1433 3 = <<EMPTY_NAME>>;
				3.17.Y = 3.17.Y - (float)<<EMPTY_NAME>>.9 / 11.5f;
				<<EMPTY_NAME>>.9 -= 7;
				if (<<EMPTY_NAME>>.9 < 70 && <<EMPTY_NAME>>.3.Count < 1)
				{
					<<EMPTY_NAME>>.16(300, (1046)0, 0);
				}
				if (<<EMPTY_NAME>>.9 < -32)
				{
					<<EMPTY_NAME>>.5 = false;
				}
			}
			this.34.RemoveAll(new Predicate<1433>(2187.2188.instance.3));
		}
		if (this.3.GetCombo() >= 50)
		{
			this.41 = ((!((this.3.GetCombo() >= 150) ? 2187.13(2) : 2187.13(1))) ? 1 : 0);
			this.5.36.ForEach(delegate(2034 1)
			{
				2178 4 = 1 as 2178;
				if (4 != null)
				{
					4.58.47.50(this.41);
					return;
				}
				2181 5 = 1 as 2181;
				if (5 != null)
				{
					5.47.50(this.41);
				}
			});
		}
		base.UpdateModeState();
	}

	// Token: 0x060033DA RID: 13274 RVA: 0x0013D3CC File Offset: 0x0013B5CC
	private void 14()
	{
		if (this.47 != null && this.47.35 >= 50)
		{
			float num;
			while ((num = (this.47.17.X + (float)this.47.35 * this.47.15 * 0.625f) * 1662.70.3()) <= (float)1662.70.1)
			{
				1433 <<EMPTY_NAME>> = this.47;
				this.47 = this.47.Clone();
				this.42.Add(this.47);
				float num2 = num / 1662.70.3();
				float x = <<EMPTY_NAME>>.3[0].6.X;
				this.47.17.X = num2;
				this.47.3[0].2.X = num2;
				this.47.3[0].6.X = x;
				this.47.3[0].9 = 1226.16;
				this.47.3[0].10 = (int)((float)1226.16 + (x - num2) / (<<EMPTY_NAME>>.3[0].6.X - <<EMPTY_NAME>>.3[0].2.X) * (float)<<EMPTY_NAME>>.3[0].1());
				this.8.73.12(this.47);
			}
		}
	}

	// Token: 0x060033DB RID: 13275 RVA: 0x0001905A File Offset: 0x0001725A
	internal override 2032 GetHitAttemptDisposition(2034 1)
	{
		return (2032)2;
	}

	// Token: 0x060033DC RID: 13276 RVA: 0x0013D576 File Offset: 0x0013B776
	internal override void OnJudgementApplied(2149 1, double 2, bool 3, 2034 4)
	{
		if (1 == (2149)2097152)
		{
			this.39.3((2196)4, true);
		}
		base.OnJudgementApplied(1, 2, 3, 4);
	}

	// Token: 0x060033DD RID: 13277 RVA: 0x0013D598 File Offset: 0x0013B798
	internal override void OnHitObjectChanged(2034 1)
	{
		2181 2 = 1 as 2181;
		2178 3 = 1 as 2178;
		if (!2486.189)
		{
			if (2 != null && 2.41 > 0)
			{
				2241 4 = 2486.88;
				if (((4 != null) ? 4.39 : null) == null || 1.14 > (2149)0)
				{
					goto IL_51;
				}
			}
			if (3 == null || !3.104)
			{
				goto IL_242;
			}
			IL_51:
			1381 texture;
			1381 texture2;
			if (2 != null)
			{
				texture = 2.46.GetTexture();
				texture2 = 2.47.GetTexture();
			}
			else
			{
				texture = 3.58.46.GetTexture();
				texture2 = 3.58.47.GetTexture();
			}
			float num = 1f - 0.03f * 1436.32((1 != null) ? ((float)1.1) : 0.1f) / 0.8f;
			1433 5 = new 1433(texture, (1376)2, 1065.Centre, (1044)1, 2184.61, num, true, (1 != null) ? 1.7 : new 198(252, 184, 6), null);
			5.15 = ((1 != null) ? 1.30[0].15 : 0.7f);
			this.2.12(5);
			5.7.X = 1662.69.13(this.6.9());
			5.9 = 169;
			this.34.Add(5);
			5 = new 1433(texture2, (1376)2, 1065.Centre, (1044)1, 2184.61, num + 0.0006f, true, 198.White, null);
			5.15 = ((1 != null) ? 1.30[0].15 : 0.7f);
			5.7.X = 1662.69.13(this.6.9());
			5.9 = 169;
			this.2.12(5);
			this.34.Add(5);
			if (2486.103 && !1304.54.1())
			{
				this.43.3.RemoveAll(new Predicate<1445>(2187.2188.instance.4));
				this.43.3.Add(new 1445(1456.Scale, 0.85f, 0.7f, 1662.33, 1662.33 + 80, (1046)1));
			}
		}
		IL_242:
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		bool flag4 = false;
		if (2486.21 && 2 != null)
		{
			flag = 1535.16;
			flag2 = 1535.18;
			flag3 = 1535.45;
			flag4 = 1535.47;
			1535.16 = (2.10() && (flag3 || flag));
			1535.18 = (2.10() && (flag4 || flag2));
			1535.45 = (!2.10() && (flag3 || flag));
			1535.47 = (!2.10() && (flag4 || flag2));
		}
		if (1535.16 || 1535.18)
		{
			1259 6 = this.5.21.92((double)(1226.16 + 2));
			1226.30(new 1244(1245.Normal, 1226.25, 1226.61(), 6.6, 1226.25), 1535.16 ? -0.2f : 0.2f, true);
			if (1535.16)
			{
				this.35.3.Clear();
				this.35.3.Add(new 1445(1456.Fade, this.35.16, 1f, 1662.33, 1662.33 + (int)((1f - this.35.16) * 80f), (1046)1));
				this.35.3.Add(new 1445(1456.Fade, 1f, 0f, 1662.33 + 100, 1662.33 + 150, (1046)0));
			}
			if (1535.18)
			{
				this.36.3.Clear();
				this.36.3.Add(new 1445(1456.Fade, this.36.16, 1f, 1662.33, 1662.33 + (int)((1f - this.36.16) * 80f), (1046)1));
				this.36.3.Add(new 1445(1456.Fade, 1f, 0f, 1662.33 + 100, 1662.33 + 150, (1046)0));
			}
		}
		if (1535.45 || 1535.47)
		{
			1259 7 = this.5.21.92((double)(1226.16 + 2));
			1226.30(new 1244(1245.Clap, 1226.25, 1226.61(), 7.6, 1226.25), 1535.45 ? -0.2f : 0.2f, true);
			if (1535.45)
			{
				this.37.3.Clear();
				this.37.3.Add(new 1445(1456.Fade, this.37.16, 1f, 1662.33, 1662.33 + (int)((1f - this.37.16) * 80f), (1046)1));
				this.37.3.Add(new 1445(1456.Fade, 1f, 0f, 1662.33 + 100, 1662.33 + 150, (1046)0));
			}
			if (1535.47)
			{
				this.38.3.Clear();
				this.38.3.Add(new 1445(1456.Fade, this.38.16, 1f, 1662.33, 1662.33 + (int)((1f - this.38.16) * 80f), (1046)1));
				this.38.3.Add(new 1445(1456.Fade, 1f, 0f, 1662.33 + 100, 1662.33 + 150, (1046)0));
			}
		}
		if (2486.21 && 2 != null)
		{
			1535.16 = flag;
			1535.18 = flag2;
			1535.45 = flag3;
			1535.47 = flag4;
		}
	}

	// Token: 0x060033DE RID: 13278 RVA: 0x0013DBA9 File Offset: 0x0013BDA9
	internal override 2039 CreateHitObjectManager()
	{
		return new 2184(true);
	}

	// Token: 0x060033DF RID: 13279 RVA: 0x0013DBB1 File Offset: 0x0013BDB1
	internal override void InitializeHealthDrain()
	{
		this.16();
		base.InitializeHealthDrain();
	}

	// Token: 0x060033E0 RID: 13280 RVA: 0x0013DBC0 File Offset: 0x0013BDC0
	internal override void CreateComboCounter()
	{
		this.3 = new 2197(this.2);
	}

	// Token: 0x060033E1 RID: 13281 RVA: 0x0013DBD3 File Offset: 0x0013BDD3
	internal override void CreateHealthBar()
	{
		this.6 = new 2199(this.2);
	}

	// Token: 0x060033E2 RID: 13282 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool UsesModeButtonInput()
	{
		return true;
	}

	// Token: 0x060033E3 RID: 13283 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal override bool ShouldProcessHitInput()
	{
		return false;
	}

	// Token: 0x060033E4 RID: 13284 RVA: 0x0013DBE8 File Offset: 0x0013BDE8
	internal override void FinalizeScore()
	{
		this.4.18 = (this.6.3() > 100.0);
		if (!this.4.18)
		{
			2023 <<EMPTY_NAME>> = this.4.8;
			2023 2 = 2023.NoFail | 2023.Relax;
			if ((<<EMPTY_NAME>> & 2) <= 2023.None && !1662.84 && !this.4.47)
			{
				this.6.SetHealth(0.0);
				return;
			}
		}
		this.39.3((2196)4, true);
		base.FinalizeScore();
	}

	// Token: 0x060033E5 RID: 13285 RVA: 0x0013DC7C File Offset: 0x0013BE7C
	internal override bool HandleFailure(bool 1)
	{
		2034 2 = this.40;
		if (2 == null || 2.11)
		{
			if (!this.5.59().11)
			{
				2023 3 = this.4.8;
				2023 4 = 2023.SuddenDeath;
				if ((3 & 4) <= 2023.None)
				{
					return false;
				}
			}
			int num = (this.4.GetJudgementCount() > 0 && this.4.GetSuccessfulJudgementCount() == 0) ? 1 : 0;
			int num2;
			if (this.4.35 < 100.0)
			{
				2023 5 = this.4.8;
				2023 6 = 2023.NoFail;
				num2 = (((5 & 6) <= 2023.None) ? 1 : 0);
			}
			else
			{
				num2 = 0;
			}
			return (((num != 0) ? 1 : 0) | num2) != 0 && base.HandleFailure(1);
		}
		return false;
	}

	// Token: 0x060033E6 RID: 13286 RVA: 0x0013DD30 File Offset: 0x0013BF30
	internal override void UpdateFlashlight()
	{
		2023 <<EMPTY_NAME>> = 2486.88.8;
		2023 2 = 2023.Flashlight;
		if ((<<EMPTY_NAME>> & 2) > 2023.None)
		{
			this.20.17 = new 208(208f, 208f);
		}
		base.UpdateFlashlight();
	}

	// Token: 0x060033E7 RID: 13287 RVA: 0x0013DD77 File Offset: 0x0013BF77
	internal override bool IsSectionPassing()
	{
		return this.4.CalculateAccuracy() > 0.8f;
	}

	// Token: 0x060033E8 RID: 13288 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void RecoverHealthForBreak()
	{
	}

	// Token: 0x060033E9 RID: 13289 RVA: 0x0013DD8B File Offset: 0x0013BF8B
	internal override void Initialize()
	{
		base.Initialize();
		this.40 = this.5.34.Find((2034 1) => 1.HasObjectType(2047.Normal));
	}

	// Token: 0x060033EA RID: 13290 RVA: 0x0013DDC8 File Offset: 0x0013BFC8
	internal override void OnReplayObjectsRebuilt()
	{
		this.40 = this.5.34.Find((2034 1) => 1.HasObjectType(2047.Normal));
		foreach (1433 <<EMPTY_NAME>> in this.34)
		{
			this.2.Remove(<<EMPTY_NAME>>);
		}
		this.34.Clear();
	}

	// Token: 0x060033EB RID: 13291 RVA: 0x0013DE60 File Offset: 0x0013C060
	internal override void ApplyBeatmapSkinPreference()
	{
		if (1304.130)
		{
			2630.10("taiko", false);
			return;
		}
		2630.10(null, false);
	}

	// Token: 0x060033EC RID: 13292 RVA: 0x0013DE84 File Offset: 0x0013C084
	internal override void OnKiaiStateChanged(bool 1)
	{
		if (1)
		{
			this.43.3.Clear();
			this.43.FadeIn(100, (1046)0, 0);
			this.43.3.Add(new 1445(1456.Scale, 0.1f, 0.7f, 1662.33, 1662.33 + 120, (1046)1));
			this.45.FadeIn(150, (1046)0, 0);
			this.39.3((2196)3, false);
		}
		else
		{
			this.43.3.Clear();
			this.43.16(600, (1046)0, 0);
			this.45.16(150, (1046)0, 0);
			this.39.3((2196)1, false);
		}
		base.OnKiaiStateChanged(1);
	}

	// Token: 0x060033ED RID: 13293 RVA: 0x0013DF4C File Offset: 0x0013C14C
	internal override void CreateModSprites()
	{
		this.5.39.25 = false;
		this.39 = new 2201();
		this.39.Initialize();
		this.39.2(new 208(0f, 160f));
		this.44 = new 1433(1455.2("approachcircle", (1416)3, null), (1376)2, 1065.Centre, (1044)0, 2184.61, 0.021f, true, new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 180), null);
		this.44.15 = 0.73f;
		this.5.39.12(this.44);
		if (this.44 != null)
		{
			this.44.39 = Math.Min(256, this.44.39);
			this.44.UpdateOriginOffset();
		}
		this.44 = new 1433(1455.2("taikobigcircle", (1416)3, null), (1376)2, 1065.Centre, (1044)0, 2184.61, 0.021f, true, new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 120), null);
		this.44.15 = 0.7f;
		this.5.39.12(this.44);
		if (this.44 != null)
		{
			this.44.39 = Math.Min(256, this.44.39);
			this.44.UpdateOriginOffset();
		}
		this.43 = new 1433(1455.2("taiko-glow", (1416)3, null), (1376)2, 1065.Centre, (1044)0, 2184.61, 0.02f, true, new 198(byte.MaxValue, 228, 0, 0), null);
		this.43.15 = 0.7f;
		this.5.39.12(this.43);
		this.46 = new 1433(1455.2("taiko-bar-left", (1416)3, null), (1376)6, 1065.TopLeft, (1044)0, new 208(0f, 135f), 0.95f, true, 198.White, null);
		this.15(this.46);
		this.5.39.12(this.46);
		1433 <<EMPTY_NAME>> = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, new 208(0f, 143f), 0.0003f, true, 198.Black, null)
		{
			15 = 1.6f,
			20 = new 208(1024f, 109f)
		};
		if (2630.5.Version >= 2.1)
		{
			this.44 = new 1433(1455.2("taiko-bar-right", (1416)3, null), (1376)6, 1065.TopLeft, (1044)0, new 208(0f, 135f), 0.0004f, true, 198.White, null);
			this.45 = new 1433(1455.2("taiko-bar-right-glow", (1416)3, null), (1376)6, 1065.TopLeft, (1044)0, new 208(0f, 135f), 0.0005f, true, 198.TransparentWhite, null);
		}
		else
		{
			this.44 = new 1433(1455.2("taiko-bar-right", (1416)3, null), (1376)6, 1065.TopLeft, (1044)0, new 208(113f, 135f), 0.0004f, true, 198.White, null);
			this.45 = new 1433(1455.2("taiko-bar-right-glow", (1416)3, null), (1376)6, 1065.TopLeft, (1044)0, new 208(113f, 135f), 0.0005f, true, 198.TransparentWhite, null);
		}
		if (1662.70.7())
		{
			<<EMPTY_NAME>>.20 *= this.44.20;
			this.45.20 = (this.44.20 = new 208(2f + (float)(2 * 1662.70.4()) / 1662.70.9() / (float)this.44.GetTexture().3(), 1f));
		}
		this.5.39.12(<<EMPTY_NAME>>);
		this.5.39.12(this.44);
		this.5.39.12(this.45);
		2023 2 = 2023.Cinema;
		2023 3 = 2019.1;
		2023 4 = 2;
		if ((3 & 4) <= 2023.None)
		{
			1433 5 = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, new 208(0f, 253f), 0f, true, 198.Black, null);
			5.66 = false;
			5.16 = 0.9f;
			5.20 = new 208((float)1662.70.1, 36f * 1662.70.3());
			this.8.74.12(5);
			1452 6 = new 1452(1272.5().11(), 19f, new 208(-20f, 271f), 8E-05f, true, 198.TransparentWhite);
			6.49 = 1065.CentreRight;
			6.41 = (1376)8;
			6.54(true);
			6.67((1068)12);
			this.50 = 6;
			this.8.74.12(this.50);
		}
		if (1662.70.7())
		{
			2023 7 = 2486.88.8;
			4 = 2023.Hidden;
			if ((7 & 4) > 2023.None)
			{
				1433 8 = new 1433(1455.2("taiko-bar-right", (1416)3, null), (1376)6, 1065.TopLeft, (1044)0, new 208((float)1662.70.1() - (float)(2 * 1662.70.4()) / 1662.70.3(), 135f), 0.1f, true, new 198(0, 0, 0, byte.MaxValue), null);
				8.35 = (int)((float)(2 * 1662.70.4()) / 1662.70.9()) + 1;
				this.8.73.12(8);
			}
		}
		int num = (2630.5.Version >= 2.1) ? 5 : 0;
		1452 9 = new 1452(1548.10(1532.TaikoInnerLeft), 18f, new 208((float)(25 + num), 185f), 208.Zero, 0.98f, false, 198.White, true);
		9.54(true);
		9.16(5000, (1046)0, 0);
		this.5.39.12(9);
		9 = new 1452(1548.10(1532.TaikoInnerRight), 18f, new 208((float)(64 + num), 185f), 208.Zero, 0.98f, false, 198.White, true);
		9.54(true);
		9.16(5000, (1046)0, 0);
		this.5.39.12(9);
		9 = new 1452(1548.10(1532.TaikoOuterLeft), 18f, new 208((float)(8 + num), 158f), 208.Zero, 0.98f, false, 198.White, true);
		9.54(true);
		9.16(5000, (1046)0, 0);
		this.5.39.12(9);
		9 = new 1452(1548.10(1532.TaikoOuterRight), 18f, new 208((float)(75 + num), 158f), 208.Zero, 0.98f, false, 198.White, true);
		9.54(true);
		9.16(5000, (1046)0, 0);
		this.5.39.12(9);
		if (2630.5.Version >= 2.1)
		{
			this.35 = new 1433(1455.2("taiko-drum-inner", (1416)3, null), (1376)6, 1065.TopLeft, (1044)0, new 208(0f, 135f), 0.96f, true, 198.TransparentWhite, null);
			this.15(this.35);
			this.5.39.12(this.35);
			this.36 = new 1433(1455.2("taiko-drum-inner", (1416)3, null), (1376)6, 1065.TopLeft, (1044)0, new 208(56f, 135f), 0.96f, true, 198.TransparentWhite, null);
			this.15(this.36);
			this.36.45(true);
			this.5.39.12(this.36);
			this.37 = new 1433(1455.2("taiko-drum-outer", (1416)3, null), (1376)6, 1065.TopLeft, (1044)0, new 208(0f, 135f), 0.96f, true, 198.TransparentWhite, null);
			this.15(this.37);
			this.37.45(true);
			this.5.39.12(this.37);
			this.38 = new 1433(1455.2("taiko-drum-outer", (1416)3, null), (1376)6, 1065.TopLeft, (1044)0, new 208(56f, 135f), 0.96f, true, 198.TransparentWhite, null);
			this.15(this.38);
			this.5.39.12(this.38);
		}
		else
		{
			this.35 = new 1433(1455.2("taiko-drum-inner", (1416)3, null), (1376)6, 1065.TopLeft, (1044)0, new 208(18f, 166f), 0.96f, true, 198.TransparentWhite, null);
			this.15(this.35);
			this.5.39.12(this.35);
			this.36 = new 1433(1455.2("taiko-drum-inner", (1416)3, null), (1376)6, 1065.TopLeft, (1044)0, new 208(54f, 166f), 0.96f, true, 198.TransparentWhite, null);
			this.15(this.36);
			this.36.45(true);
			this.5.39.12(this.36);
			this.37 = new 1433(1455.2("taiko-drum-outer", (1416)3, null), (1376)6, 1065.TopLeft, (1044)0, new 208(8f, 158f), 0.96f, true, 198.TransparentWhite, null);
			this.15(this.37);
			this.37.45(true);
			this.5.39.12(this.37);
			this.38 = new 1433(1455.2("taiko-drum-outer", (1416)3, null), (1376)6, 1065.TopLeft, (1044)0, new 208(53f, 158f), 0.96f, true, 198.TransparentWhite, null);
			this.15(this.38);
			this.5.39.12(this.38);
		}
		if (!this.8.34.37 || this.8.34.21.4() + this.8.34.23.4() < 10)
		{
			this.47 = new 1433(1455.2("taiko-slider", (1416)3, null), (1376)6, 1065.TopLeft, (1044)1, new 208(0f, 0f), 0f, false, 198.White, null);
			this.8.73.12(this.47);
			this.47.15 = 1.4f;
			this.47.3.Add(new 1445(208.Zero, new 208(-1400f, 0f), -this.8.137, -this.8.137 + 34400, (1046)0));
			this.42.Add(this.47);
		}
		if (1304.74)
		{
			this.19 = 1455.5("taiko-flower-group", (1416)7, true);
		}
		1455.2("taiko-bar-right-glow", (1416)3, null);
		this.48 = 1455.2("taiko-slider", (1416)3, null);
		this.49 = 1455.2("taiko-slider-fail", (1416)3, null);
		base.CreateModSprites();
	}

	// Token: 0x060033EE RID: 13294 RVA: 0x0013EAEC File Offset: 0x0013CCEC
	private new void 15(1433 1)
	{
		1.35 = Math.Min(220, 1.35);
	}

	// Token: 0x060033EF RID: 13295 RVA: 0x0013EB04 File Offset: 0x0013CD04
	internal override void OnModDisplayShown()
	{
		base.OnModDisplayShown();
		if (this.50 != null)
		{
			this.50.15(200);
			this.50.19(this.50.17 + new 208(25f, 0f), 500, (1046)1);
		}
	}

	// Token: 0x060033F0 RID: 13296 RVA: 0x0013EB64 File Offset: 0x0013CD64
	internal override void AdjustStoryboardSprite(1433 1)
	{
		2023 2 = 2023.Cinema;
		2023 3 = 2019.1;
		2023 4 = 2;
		if ((3 & 4) <= 2023.None && this.8.34.4 != null && this.8.34.4.7 != null)
		{
			1433 5 = this.8.34.4.7;
			1.17.Y = 1.17.Y + ((float)1662.70.2() - (float)(1662.70.2() - 289) / 2f - 240f);
			1.48.Y = 5.48.Y + 15f * ((float)1.39 / (float)1.38 / 1.333f);
		}
	}

	// Token: 0x060033F1 RID: 13297 RVA: 0x0013EC35 File Offset: 0x0013CE35
	internal override void ApplyJudgement(2149 1, 2034 2)
	{
		if (1 != (2149)0)
		{
			this.8.11(1 != (2149)(-131072));
		}
		base.ApplyJudgement(1, 2);
	}

	// Token: 0x060033F2 RID: 13298 RVA: 0x0013EC58 File Offset: 0x0013CE58
	internal override bool IsComboBurstThreshold()
	{
		return this.3.GetCombo() == 50 || (this.3.GetCombo() > 99 && this.3.GetCombo() % 100 == 0);
	}

	// Token: 0x060033F3 RID: 13299 RVA: 0x0013EC90 File Offset: 0x0013CE90
	internal override void ShowComboBurst()
	{
		this.39.3((2196)4, true);
		if (this.19 != null && this.19.Length != 0)
		{
			1433 <<EMPTY_NAME>> = new 1433(this.19[this.18], 1065.BottomCentre, new 208(54f, 141f), 0.05f, false, 198.White);
			<<EMPTY_NAME>>.3.Add(new 1445(1456.Fade, 0f, 1f, 1662.33, 1662.33 + 200, (1046)0));
			<<EMPTY_NAME>>.3.Add(new 1445(1456.Scale, 0.6f, 1f, 1662.33, 1662.33 + 800, (1046)1));
			<<EMPTY_NAME>>.3.Add(new 1445(1456.Fade, 1f, 0f, 1662.33 + 1600, 1662.33 + 1900, (1046)2));
			this.8.73.12(<<EMPTY_NAME>>);
			this.18 = (this.18 + 1) % this.19.Length;
		}
		this.CreateComboParticles();
	}

	// Token: 0x060033F4 RID: 13300 RVA: 0x0013EDA8 File Offset: 0x0013CFA8
	internal override void OnSectionPassStateChanged(bool 1)
	{
		2187.2189 2 = new 2187.2189();
		2.1 = 1;
		2.2 = this;
		if (2.1)
		{
			this.39.3((!2486.103 || 1304.54.1()) ? ((2196)1) : ((2196)3), false);
		}
		else
		{
			this.39.3((2196)2, false);
		}
		2.3 = new List<1433>();
		this.42.ForEach(new Action<1433>(2.1));
		this.8.73.14<1433>(2.3);
		this.42 = 2.3;
		if (2.3.Count > 0)
		{
			this.47 = 2.3[2.3.Count - 1];
		}
		base.OnSectionPassStateChanged(2.1);
	}

	// Token: 0x060033F5 RID: 13301 RVA: 0x0013EE80 File Offset: 0x0013D080
	internal override void GenerateAutoplayReplay()
	{
		1535.39.26 = new List<1840>();
		List<1840> <<EMPTY_NAME>> = 1535.39.26;
		bool flag = true;
		<<EMPTY_NAME>>.Add(new 1840(-100000, 320f, 240f, 1572.None));
		<<EMPTY_NAME>>.Add(new 1840(this.5.34[0].1 - 1000, 320f, 240f, 1572.None));
		for (int i = 0; i < this.5.35; i++)
		{
			2034 2 = this.5.34[i];
			if (2.2 < 1535.41)
			{
				2.11 = true;
			}
			else
			{
				2185 3 = 2 as 2185;
				if (3 != null)
				{
					int num = 0;
					int num2 = 0;
					int num3 = 3.49 + 1;
					int num4 = 2.GetDuration() / num3;
					for (int j = 2.1; j < 2.2; j += num4)
					{
						List<1840> list = <<EMPTY_NAME>>;
						int 4 = j;
						float x = 2.8.X;
						float y = 2.8.Y;
						1572 5;
						switch (num)
						{
						case 1:
							5 = 1572.Right1;
							break;
						case 2:
							5 = 1572.Left2;
							break;
						case 3:
							5 = 1572.Right2;
							break;
						default:
							5 = 1572.Left1;
							break;
						}
						list.Add(new 1840(4, x, y, 5));
						num = (num + 1) % 4;
						if (++num2 > num3)
						{
							break;
						}
					}
				}
				else if (2 is 2178)
				{
					2178 6 = 2 as 2178;
					double num5 = 6.51();
					double num6 = (double)6.1;
					for (int k = 0; k < 6.105.Count; k++)
					{
						<<EMPTY_NAME>>.Add(new 1840((int)num6, 2.8.X, 2.8.Y, flag ? 1572.Left1 : 1572.Left2));
						num6 += num5;
						flag = !flag;
					}
				}
				else
				{
					List<1840> list2 = <<EMPTY_NAME>>;
					1572 5 = (2.HasWhistle() || 2.HasClap()) ? ((!2.HasFinish()) ? (flag ? 1572.Right1 : 1572.Right2) : (1572.Right1 | 1572.Right2)) : ((!2.HasFinish()) ? (flag ? 1572.Left1 : 1572.Left2) : (1572.Left1 | 1572.Left2));
					list2.Add(new 1840(2.1, 2.8.X, 2.8.Y, 5));
				}
				<<EMPTY_NAME>>.Add(new 1840(2._0003_2002_200A_2007_2007_2004_200A_2006_200A_2005_2005_2007_2009_2008_2002_2001_2005_2003_2001_200B() + 1, 2.GetEndPosition().X, 2.GetEndPosition().Y, 1572.None));
				if (i < this.5.35 - 1)
				{
					int num7 = this.5.34[i + 1].1 - 1000;
					if (num7 > 2.2)
					{
						<<EMPTY_NAME>>.Add(new 1840(num7, 2.GetEndPosition().X, 2.GetEndPosition().Y, 1572.None));
					}
				}
				2241 7 = this.4;
				if (((7 != null) ? 7.39 : null) != null && i == this.5.35 - 1)
				{
					<<EMPTY_NAME>>.Add(new 1840(this.5.34[i].2 + 1000, 2.GetEndPosition().X, 2.GetEndPosition().Y, 1572.None));
				}
				flag = !flag;
			}
		}
		2486.88.26 = 1535.39.26;
		2486.88.23 = "mekkadosu!";
		1535.39.26.ForEach(new Action<1840>(2187.2188.instance.5));
	}

	// Token: 0x060033F6 RID: 13302 RVA: 0x0013F20C File Offset: 0x0013D40C
	internal new double 16()
	{
		this.25 = 200.0 / (0.36 * (double)this.5.34.FindAll(new Predicate<2034>(2187.2188.instance.6)).Count * this.5.GetDifficultyRange((double)this.5.16(1928.DrainRate, this.5.21.3), 0.5, 0.75, 0.9800000190734863));
		this.24 = 0.0;
		this.5.34.ForEach(delegate(2034 1)
		{
			1.13 = 200.0;
		});
		2241 <<EMPTY_NAME>> = this.4;
		if (((<<EMPTY_NAME>> != null) ? <<EMPTY_NAME>>.39 : null) == null)
		{
			this.17 = this.5.34.FindAll((2034 1) => !(1 is 2178)).Count;
		}
		else
		{
			2486.88.ResetJudgements(false);
			for (int i = 0; i < this.5.35; i++)
			{
				2034 2 = this.5.34[i];
				if (2 is 2181)
				{
					2149 3;
					if (2.HasFinish())
					{
						3 = (2149)1024;
						3 |= (2149)65536;
					}
					else
					{
						3 = (2149)1024;
					}
					this.ApplyJudgement(3, 2);
				}
				else if (2 is 2178)
				{
					2178 4 = (2178)2;
					2149 5 = (2149)32768;
					if (4.HasFinish())
					{
						5 |= (2149)65536;
					}
					for (int j = 0; j < 4.105.Count; j++)
					{
						this.ApplyJudgement(5, 2);
					}
					5 = (2149)1024;
					if (4.HasFinish())
					{
						5 |= (2149)65536;
					}
					this.ApplyJudgement(5, 2);
				}
				else if (2 is 2185)
				{
					2185 6 = (2185)2;
					for (int k = 0; k < 6.49 + 1; k++)
					{
						this.ApplyJudgement((2149)1048576, 2);
					}
					this.ApplyJudgement((2149)2098176, 2);
				}
				this.17++;
			}
		}
		return 0.0;
	}

	// Token: 0x040026A7 RID: 9895
	private readonly List<1433> 34 = new List<1433>();

	// Token: 0x040026A8 RID: 9896
	private 1433 35;

	// Token: 0x040026A9 RID: 9897
	private 1433 36;

	// Token: 0x040026AA RID: 9898
	private 1433 37;

	// Token: 0x040026AB RID: 9899
	private 1433 38;

	// Token: 0x040026AC RID: 9900
	private 2201 39;

	// Token: 0x040026AD RID: 9901
	private 2034 40;

	// Token: 0x040026AE RID: 9902
	private int 41;

	// Token: 0x040026AF RID: 9903
	private List<1433> 42 = new List<1433>();

	// Token: 0x040026B0 RID: 9904
	private 1433 43;

	// Token: 0x040026B1 RID: 9905
	private 1433 44;

	// Token: 0x040026B2 RID: 9906
	private 1433 45;

	// Token: 0x040026B3 RID: 9907
	private 1433 46;

	// Token: 0x040026B4 RID: 9908
	private 1433 47;

	// Token: 0x040026B5 RID: 9909
	private 1381 48;

	// Token: 0x040026B6 RID: 9910
	private 1381 49;

	// Token: 0x040026B7 RID: 9911
	private 1452 50;

	// Token: 0x020006D4 RID: 1748
	public sealed class 2189
	{
		// Token: 0x060033F8 RID: 13304 RVA: 0x0013F4AC File Offset: 0x0013D6AC
		internal void 1(1433 1)
		{
			1433 2 = 1.Clone();
			2.2 += 0.0006f;
			2.15(200);
			1.3.Add(new 1445(1456.Fade, 1f, 0f, 1226.16 + 200, 1226.16 + 200, (1046)0));
			if (this.1)
			{
				2.SetTexture(this.2.48);
			}
			else
			{
				2.SetTexture(this.2.49);
			}
			this.3.Add(2);
		}

		// Token: 0x040026B8 RID: 9912
		public bool 1;

		// Token: 0x040026B9 RID: 9913
		public 2187 2;

		// Token: 0x040026BA RID: 9914
		public List<1433> 3;
	}

	// Token: 0x020006D5 RID: 1749
	[Serializable]
	public sealed class 2188
	{
		// Token: 0x060033FA RID: 13306 RVA: 0x0013F548 File Offset: 0x0013D748
		internal bool 1(2034 1)
		{
			return 1 is 2181;
		}

		// Token: 0x060033FB RID: 13307 RVA: 0x0013F553 File Offset: 0x0013D753
		internal bool 2(1433 1)
		{
			return 1.3[0].10 < 1226.16;
		}

		// Token: 0x060033FC RID: 13308 RVA: 0x0013F56D File Offset: 0x0013D76D
		internal bool 3(1433 1)
		{
			return !1.5;
		}

		// Token: 0x060033FD RID: 13309 RVA: 0x000AAB47 File Offset: 0x000A8D47
		internal bool 4(1445 1)
		{
			return 1.14 == 1456.Scale;
		}

		// Token: 0x060033FE RID: 13310 RVA: 0x0013F578 File Offset: 0x0013D778
		internal void 5(1840 1)
		{
			1.1 = -150f;
			1.2 = -150f;
		}

		// Token: 0x060033FF RID: 13311 RVA: 0x0013F548 File Offset: 0x0013D748
		internal bool 6(2034 1)
		{
			return 1 is 2181;
		}

		// Token: 0x040026BB RID: 9915
		public static readonly 2187.2188 instance = new 2187.2188();

		// Token: 0x040026BC RID: 9916
		public static Predicate<2034> predicate;

		// Token: 0x040026BD RID: 9917
		public static Predicate<1433> predicate2;

		// Token: 0x040026BE RID: 9918
		public static Predicate<1433> predicate3;

		// Token: 0x040026BF RID: 9919
		public static Predicate<1445> predicate4;

		// Token: 0x040026C0 RID: 9920
		public static Predicate<2034> predicate5;

		// Token: 0x040026C1 RID: 9921
		public static Action<1840> action;

		// Token: 0x040026C2 RID: 9922
		public static Predicate<2034> predicate6;

		// Token: 0x040026C3 RID: 9923
		public static Action<2034> action2;

		// Token: 0x040026C4 RID: 9924
		public static Predicate<2034> predicate7;
	}
}
