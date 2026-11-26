using System;
using System.Collections.Generic;
using osu_gameplay;

// Token: 0x02000514 RID: 1300
[276]
public abstract class 2504 : IDisposable
{
	// Token: 0x060027B0 RID: 10160 RVA: 0x000C7458 File Offset: 0x000C5658
	internal 2504(2486 1)
	{
		2504.28 = this;
		2522.1();
		this.8 = 1;
		this.1 = 1.76;
		this.2 = 1.77;
		this.15 = 1.72;
		this.5 = this.CreateHitObjectManager();
		1.46(new 2038(this.OnHitObjectChanged));
	}

	// Token: 0x060027B1 RID: 10161 RVA: 0x000C74F9 File Offset: 0x000C56F9
	internal virtual 208 GetScoreboardPosition()
	{
		return new 208(0f, 205f);
	}

	// Token: 0x060027B2 RID: 10162 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal virtual bool IsScoreboardMirrored()
	{
		return false;
	}

	// Token: 0x060027B3 RID: 10163 RVA: 0x000C750A File Offset: 0x000C570A
	internal virtual bool IsSectionPassing()
	{
		return this.6 == null || this.6.3() >= 100.0;
	}

	// Token: 0x060027B4 RID: 10164 RVA: 0x0001702D File Offset: 0x0001522D
	internal virtual bool ShouldShowBeatmapMessages()
	{
		return true;
	}

	// Token: 0x060027B5 RID: 10165 RVA: 0x0001702D File Offset: 0x0001522D
	internal virtual bool ShouldShowScoreboard()
	{
		return true;
	}

	// Token: 0x060027B6 RID: 10166 RVA: 0x000C752F File Offset: 0x000C572F
	internal virtual 208 GetReplayCursorPosition()
	{
		return 1662.69.14(1535.6);
	}

	// Token: 0x060027B7 RID: 10167 RVA: 0x0001702D File Offset: 0x0001522D
	internal virtual bool AllowsScoreSubmission()
	{
		return true;
	}

	// Token: 0x060027B8 RID: 10168 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal virtual bool CanResumeWithoutCursorClick()
	{
		return false;
	}

	// Token: 0x060027B9 RID: 10169 RVA: 0x000C7540 File Offset: 0x000C5740
	internal virtual bool AreAllObjectsJudged()
	{
		return (int)(this.4.2 + this.4.1 + this.4.3 + this.4.6) == this.5.35;
	}

	// Token: 0x060027BA RID: 10170 RVA: 0x0001702D File Offset: 0x0001522D
	internal virtual bool ShouldPlayCountdown()
	{
		return true;
	}

	// Token: 0x060027BB RID: 10171 RVA: 0x0001702D File Offset: 0x0001522D
	internal virtual bool ShouldShowBreakSections()
	{
		return true;
	}

	// Token: 0x060027BC RID: 10172 RVA: 0x0001702D File Offset: 0x0001522D
	internal virtual bool Method5894()
	{
		return true;
	}

	// Token: 0x060027BD RID: 10173 RVA: 0x000C7580 File Offset: 0x000C5780
	internal virtual bool ShouldHideCursor()
	{
		if (2486.14)
		{
			return false;
		}
		if (208.Distance(1555.21(), this.30) < 10f)
		{
			this.29 += 1662.82;
		}
		else
		{
			this.29 = 0.0;
		}
		this.30 = 1555.21();
		return this.29 > 1000.0;
	}

	// Token: 0x060027BE RID: 10174 RVA: 0x0001702D File Offset: 0x0001522D
	internal virtual bool ShouldShowLowHealthEffect()
	{
		return true;
	}

	// Token: 0x060027BF RID: 10175 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal virtual bool UsesModeButtonInput()
	{
		return false;
	}

	// Token: 0x060027C0 RID: 10176 RVA: 0x000C75EC File Offset: 0x000C57EC
	internal virtual bool IsComboBurstThreshold()
	{
		return this.3.GetCombo() == 30 || this.3.GetCombo() == 60 || (this.3.GetCombo() > 99 && this.3.GetCombo() % 50 == 0);
	}

	// Token: 0x060027C1 RID: 10177 RVA: 0x000C763C File Offset: 0x000C583C
	public virtual void Dispose()
	{
		2504.28 = null;
		if (this.23 != null)
		{
			this.23.12(true);
		}
		this.8.47(new 2038(this.OnHitObjectChanged));
		2511 <<EMPTY_NAME>> = this.13;
		if (<<EMPTY_NAME>> != null)
		{
			<<EMPTY_NAME>>.Dispose();
		}
		this.13 = null;
		if (this.11 != null)
		{
			this.11.1();
		}
		if (this.20 != null)
		{
			this.20.27 = true;
		}
		if (this.16 != null)
		{
			this.16.Dispose();
		}
	}

	// Token: 0x060027C2 RID: 10178 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal virtual void OnHitObjectChanged(2034 1)
	{
	}

	// Token: 0x060027C3 RID: 10179 RVA: 0x000C76D0 File Offset: 0x000C58D0
	internal virtual void Initialize()
	{
		2039 <<EMPTY_NAME>> = this.5;
		1436 2 = (<<EMPTY_NAME>> != null) ? <<EMPTY_NAME>>.39 : null;
		HashSet<1371> hashSet = (2 != null && 2486.14() != 2147.Osu) ? new HashSet<1371>(2.17()) : null;
		this.ApplyGameplayMods();
		this.CreateModSprites();
		this.14 = 2522.6("health", "Health bar", 2509.TopLeft, new Action(this.CreateHealthBar), null);
		2522.6("combo", "Combo", 2509.BottomLeft, new Action(this.CreateComboCounter), null);
		this.CreateScoreDisplay();
		if (this.10 != null)
		{
			2522.13("score", "Score", 2509.TopRight, this.10.ScoreSprite, true);
			2528 3 = 2522.13("accuracy", "Accuracy", 2509.TopRight, this.10.AccuracySprite, true);
			if (3 != null && 2486.14() == 2147.Osu)
			{
				3.8(2530.3("mode", "Accuracy display mode", "Which accuracy mode should be displayed.", "standard", new string[]
				{
					"standard",
					"max",
					"min"
				}, new string[]
				{
					"Standard",
					"Maximum achievable",
					"Minimum achievable"
				}));
			}
		}
		this.CreatePerformanceCounter();
		this.CreateScoreMeter();
		this.1();
		2522.11();
		this.13 = new 2511(this.8, this.2, this.10, this.12);
		2522.15();
		this.InitializeHealthDrain();
		this.SynchronizeSpriteManagerScale();
		if (hashSet != null)
		{
			HashSet<1371> hashSet2 = new HashSet<1371>(2.17());
			hashSet2.ExceptWith(hashSet);
			foreach (2034 4 in this.5.34)
			{
				hashSet2.ExceptWith(4.30);
			}
			this.5.57 = hashSet2;
		}
		this.7 = true;
		1535.24 = this.UsesModeButtonInput();
	}

	// Token: 0x060027C4 RID: 10180 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal virtual void OnReplayObjectsRebuilt()
	{
	}

	// Token: 0x060027C5 RID: 10181 RVA: 0x000C78F0 File Offset: 0x000C5AF0
	internal virtual void SynchronizeSpriteManagerScale()
	{
		float num = this.5.39.14;
		if (this.1 != null)
		{
			this.1.14 = num;
		}
		if (this.15 != null)
		{
			this.15.14 = num;
		}
		if (this.16 != null)
		{
			this.16.14 = num;
		}
		if (this.2 != null)
		{
			this.2.14 = num;
		}
	}

	// Token: 0x060027C6 RID: 10182 RVA: 0x000C7960 File Offset: 0x000C5B60
	protected virtual void CreateScoreMeter()
	{
		if (1304.166 == 2151.Colour)
		{
			this.11 = new 2546(1662.11, this.5);
			return;
		}
		if (1304.166 != 2151.Error)
		{
			2023 <<EMPTY_NAME>> = 2023.Target;
			2023 2 = 2019.1;
			2023 3 = <<EMPTY_NAME>>;
			if ((2 & 3) <= 2023.None)
			{
				return;
			}
		}
		if (2486.16())
		{
			this.11 = new 2144(1662.11, this.5);
			return;
		}
		this.11 = new 2508(1662.11, this.5);
	}

	// Token: 0x060027C7 RID: 10183 RVA: 0x000C79E8 File Offset: 0x000C5BE8
	private void 1()
	{
		2542 <<EMPTY_NAME>> = this.11;
		if (((<<EMPTY_NAME>> != null) ? <<EMPTY_NAME>>.Layer : null) == null)
		{
			if (this.11 == null)
			{
				2522.2("hiterror", "Hit error meter", "Hit timings on a bar, or in colours", new Func<2528>(this.3));
			}
			return;
		}
		2528 2 = 2522.14("hiterror", "Hit error meter", 2509.BottomCentre, this.11.Layer, this.2());
		this.4(2);
		this.11.5 = 2;
		this.11.2();
	}

	// Token: 0x060027C8 RID: 10184 RVA: 0x000C7A74 File Offset: 0x000C5C74
	private 208 2()
	{
		foreach (1371 <<EMPTY_NAME>> in this.11.Layer.28)
		{
			1433 2 = <<EMPTY_NAME>> as 1433;
			if (2 != null && 2528.25(2.41))
			{
				return 2528.6(2);
			}
		}
		return new 208(2528.WindowWidth / 2f, 480f);
	}

	// Token: 0x060027C9 RID: 10185 RVA: 0x000C7B00 File Offset: 0x000C5D00
	private 2528 3()
	{
		1304.166.SetValue(2151.Error);
		this.CreateScoreMeter();
		this.1();
		return 2522.5("hiterror");
	}

	// Token: 0x060027CA RID: 10186 RVA: 0x000C7B24 File Offset: 0x000C5D24
	private void 4(2528 1)
	{
		Func<bool> func = () => this.11 is 2546;
		Func<bool> func2 = () => !(this.11 is 2546);
		2530 2 = 4.8(2530.3("style", "Style", "Hit timings on a bar, or the colours of the last judgements (the option of the same name).", "bar", new string[]
		{
			"bar",
			"colour"
		}, new string[]
		{
			"Bar",
			"Colour"
		}));
		2.17 = delegate()
		{
			if (1304.166 != 2151.Colour)
			{
				return "bar";
			}
			return "colour";
		};
		2.18 = delegate(string 1)
		{
			1304.166.SetValue((1 == "colour") ? 2151.Colour : 2151.Error);
		};
		4.8(2530.2("line_thickness", "Judgement line thickness", "How thick the individual lines should be.", 3f, 1f, 8f, 0.1f, "0.0")).16 = func2;
		4.8(2530.1("colour_bars", "Show colour bars", "The hit windows in their colours.", true)).16 = func2;
		4.8(2530.1("average_arrow", "Show moving average arrow", "Whether an arrow should move along the bar showing the average error.", true)).16 = func2;
		4.8(2530.3("centre_marker", "Centre marker style", "How to signify the centre of the display.", "none", new string[]
		{
			"none",
			"circle",
			"line"
		}, new string[]
		{
			"None",
			"Circle",
			"Line"
		})).16 = func2;
		4.8(2530.3("labels", "Label style", "How to show early/late extremities.", "none", new string[]
		{
			"none",
			"text"
		}, new string[]
		{
			"None",
			"Text"
		})).16 = func2;
		2530 3 = 4.8(2530.2("count", "Judgement count", "The number of displayed judgements.", 0f, 0f, 50f, 1f, "0.##"));
		3.11 = "Auto";
		3.16 = func;
		4.8(2530.2("spacing", "Judgement spacing", "The space between each displayed judgement (with a set count).", 2f, 0f, 10f, 0.5f, "0.0")).16 = func;
		4.8(2530.3("shape", "Judgement shape", "The shape of each displayed judgement.", "square", new string[]
		{
			"square",
			"circle"
		}, new string[]
		{
			"Square",
			"Circle"
		})).16 = func;
		4.27 = delegate(string 1)
		{
			if (1 == "style")
			{
				this.5(4);
				return;
			}
			2542 5 = this.11;
			if (5 == null)
			{
				return;
			}
			5.2();
		};
	}

	// Token: 0x060027CB RID: 10187 RVA: 0x000C7E34 File Offset: 0x000C6034
	private void 5(2528 1)
	{
		2542 2 = this.11;
		if (2 != null)
		{
			2.1();
		}
		this.11 = null;
		this.CreateScoreMeter();
		2542 3 = this.11;
		if (((3 != null) ? 3.Layer : null) == null)
		{
			return;
		}
		208 4 = this.2() - 2528.26(1.6, 2528.WindowWidth, 480f);
		bool flag = 1.8 == 1.6 && 1.9 == 1.7;
		1.29 = this.11.Layer;
		this.11.Layer.26 = 1;
		1.7 = 4;
		if (flag)
		{
			1.9 = 4;
		}
		this.11.5 = 1;
		this.11.2();
		1.32();
	}

	// Token: 0x060027CC RID: 10188 RVA: 0x000C7F06 File Offset: 0x000C6106
	protected virtual void CreateScoreDisplay()
	{
		this.10 = new 2541(this.2);
	}

	// Token: 0x060027CD RID: 10189 RVA: 0x000C7F19 File Offset: 0x000C6119
	protected virtual void CreatePerformanceCounter()
	{
		this.12 = new 2538(this.8);
	}

	// Token: 0x060027CE RID: 10190 RVA: 0x000C7F2C File Offset: 0x000C612C
	internal virtual void PreloadJudgementTextures()
	{
		this.5.GetJudgementTextures("hit0");
		this.5.GetJudgementTextures("hit50");
		this.5.GetJudgementTextures("hit100");
		this.5.GetJudgementTextures("hit100k");
		this.5.GetJudgementTextures("hit300");
		this.5.GetJudgementTextures("hit300g");
		this.5.GetJudgementTextures("hit300k");
	}

	// Token: 0x060027CF RID: 10191 RVA: 0x000C7FB0 File Offset: 0x000C61B0
	internal virtual void CreateHealthBar()
	{
		this.6 = new 2506(this.2);
	}

	// Token: 0x060027D0 RID: 10192 RVA: 0x000C7FC3 File Offset: 0x000C61C3
	internal virtual void SetPlayfieldOpacity(float 1)
	{
		this.15.5 = 1;
		this.5.39.5 = 1;
	}

	// Token: 0x060027D1 RID: 10193 RVA: 0x000C7FE4 File Offset: 0x000C61E4
	internal virtual void InitializeHealthDrain()
	{
		if (1272.5().19 > 0)
		{
			this.6.10 = -1272.5().19;
		}
		if ((double)this.5.34[0].1 * this.6.11 < 200.0)
		{
			this.6.11 = 200.0 / (double)(this.5.34[0].1 + 1272.5().19);
		}
		else if (this.5.34[0].1 > 10000)
		{
			this.6.10 = this.5.34[0].1 - 10000;
		}
		2023 <<EMPTY_NAME>> = 2486.88.8;
		2023 2 = 2023.DoubleTime;
		if ((<<EMPTY_NAME>> & 2) > 2023.None)
		{
			this.6.11 *= 1939.19(2023.DoubleTime);
		}
	}

	// Token: 0x060027D2 RID: 10194 RVA: 0x000C80F0 File Offset: 0x000C62F0
	internal virtual void ApplyGameplayMods()
	{
		2023 <<EMPTY_NAME>> = 2486.88.8;
		2023 2 = 2023.Relax;
		2486.21 = ((<<EMPTY_NAME>> & 2) > 2023.None);
		2023 3 = 2486.88.8;
		2 = 2023.Relax2;
		2486.22 = ((3 & 2) > 2023.None);
		this.26 = (double)1272.5().15() * 2019.12(this.4.8, 2486.14(), this.5.21);
		2023 4 = 2486.88.8;
		2 = 2023.SuddenDeath;
		if ((4 & 2) <= 2023.None)
		{
			2023 5 = 2486.88.8;
			2 = 2023.Easy;
			if ((5 & 2) > 2023.None)
			{
				this.9 = 2;
			}
		}
		2023 6 = 2486.88.8;
		2 = 2023.Flashlight;
		if ((6 & 2) > 2023.None)
		{
			this.16 = new 1436(true);
			this.20 = new 1433(null, (1376)3, 1065.Centre, (1044)0, 208.Zero, 1f, true, 198.Black, null);
			this.LoadFlashlightTexture();
			this.16.12(this.20);
			this.22 = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, 208.Zero, 0.989f, true, 198.TransparentBlack, null);
			this.22.66 = false;
			this.22.20 = new 208((float)1662.70.1, (float)1662.70.2);
			this.16.12(this.22);
		}
	}

	// Token: 0x060027D3 RID: 10195 RVA: 0x000C8270 File Offset: 0x000C6470
	protected virtual void LoadFlashlightTexture()
	{
		if (this.20 == null)
		{
			return;
		}
		string name = "flashlightv2";
		byte[] array = ResourcesStore.ResourceManager.GetObject(name) as byte[];
		if (array == null)
		{
			throw new Exception("Couldn't load flashlight!");
		}
		this.20.SetTexture(1381.16(array));
	}

	// Token: 0x060027D4 RID: 10196 RVA: 0x000C82BC File Offset: 0x000C64BC
	internal virtual void ApplyBeatmapSkinPreference()
	{
		if (2486.57)
		{
			return;
		}
		if (!string.IsNullOrEmpty(1272.5().80) && 1272.5().1())
		{
			if (!2630.10(1272.5().80, false) && !2486.57)
			{
				1763.5("This beatmap is requesting a skin preference of '" + 1272.5().80 + "'.  Please download this skin for the intended experience", 198.OrangeRed, 6000, null);
				return;
			}
		}
		else
		{
			2630.10(null, false);
		}
	}

	// Token: 0x060027D5 RID: 10197 RVA: 0x000C833C File Offset: 0x000C653C
	internal virtual void CreateModSprites()
	{
		if (this.AllowsScoreSubmission() && !2019.4(2486.88.8))
		{
			1433 <<EMPTY_NAME>> = new 1433(1455.2("play-unranked", (1416)7, null), (1376)7, 1065.Centre, (1044)0, new 208(0f, 45f), 0f, true, 198.White, null);
			<<EMPTY_NAME>>.15(2000);
			this.8.77.12(<<EMPTY_NAME>>);
		}
	}

	// Token: 0x060027D6 RID: 10198
	internal abstract 2039 CreateHitObjectManager();

	// Token: 0x060027D7 RID: 10199 RVA: 0x000C83B4 File Offset: 0x000C65B4
	internal virtual void CreateComboCounter()
	{
		this.3 = new 2499(this.2);
	}

	// Token: 0x060027D8 RID: 10200
	internal abstract void GenerateAutoplayReplay();

	// Token: 0x060027D9 RID: 10201 RVA: 0x000C83C7 File Offset: 0x000C65C7
	internal void 6()
	{
		if (this.6 != null)
		{
			this.6.Hide();
		}
		if (this.3 != null)
		{
			this.3.Hide();
		}
	}

	// Token: 0x060027DA RID: 10202 RVA: 0x000C83EF File Offset: 0x000C65EF
	internal void 7()
	{
		if (this.6 != null)
		{
			this.6.Show();
		}
		if (this.3 != null)
		{
			this.3.Show();
		}
	}

	// Token: 0x060027DB RID: 10203 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal virtual void BeforeObjectUpdate()
	{
	}

	// Token: 0x060027DC RID: 10204 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal virtual void AfterObjectUpdate()
	{
	}

	// Token: 0x060027DD RID: 10205 RVA: 0x000C8418 File Offset: 0x000C6618
	internal virtual void Draw()
	{
		if (this.7)
		{
			if (this.6 != null)
			{
				this.6.Method3946();
			}
			2023 <<EMPTY_NAME>> = 2486.88.8;
			2023 2 = 2023.Flashlight;
			if ((<<EMPTY_NAME>> & 2) > 2023.None)
			{
				this.16.22();
			}
			if (this.11 != null)
			{
				this.11.5();
			}
		}
	}

	// Token: 0x060027DE RID: 10206 RVA: 0x000C847C File Offset: 0x000C667C
	internal virtual void UpdateFlashlight()
	{
		if (this.20.GetTexture() != null && this.16.28.Count != 0 && this.20.GetTexture().gpuTexture.HasContent())
		{
			if (2486.13)
			{
				return;
			}
			if (2486.83 && this.8.47 != null)
			{
				this.20.17 = new 208(Math.Max(0f, Math.Min(640f, this.8.47.17.X / 1662.70.3())), Math.Max(0f, Math.Min(480f, this.8.47.17.Y / 1662.70.3())));
			}
			2123 <<EMPTY_NAME>> = this.8.26 as 2123;
			if (<<EMPTY_NAME>> != null && <<EMPTY_NAME>>.78)
			{
				if (!this.22.19)
				{
					this.22.16 = 0.8f;
				}
			}
			else if (this.22.19)
			{
				this.22.16 = 0f;
			}
			float num = 8f;
			if (!2648.6)
			{
				int num2 = this.3.GetCombo() + 1304.34.6();
				if (1304.35.1())
				{
					this.21 = Math.Max(this.21, num2);
					num2 = this.21;
				}
				num = ((num2 < 100) ? 3.2f : ((num2 >= 200) ? 2f : 2.6f));
			}
			if (this.20.15 > num)
			{
				this.20.15 = (float)Math.Max((double)this.20.15 - 0.1 * 1662.10, (double)num);
				return;
			}
			if (this.20.15 < num)
			{
				this.20.15 = (float)Math.Min((double)this.20.15 + 0.1 * 1662.10, (double)num);
			}
		}
	}

	// Token: 0x060027DF RID: 10207 RVA: 0x000C869C File Offset: 0x000C689C
	internal void 8()
	{
		if (this.7)
		{
			this.UpdateModeState();
			this.UpdateHealthDrain();
			if (this.6 != null)
			{
				using (2528.20(this.14))
				{
					this.6.Update();
				}
			}
			this.UpdateComboDisplay();
			if (this.11 != null)
			{
				this.11.Update();
			}
			this.10.3();
			2538 2 = this.12;
			if (2 != null)
			{
				2.2(2486.88);
			}
			2206.2(2486.88, 2538.4(2486.7));
			2511 3 = this.13;
			if (3 == null)
			{
				return;
			}
			3.9();
		}
	}

	// Token: 0x060027E0 RID: 10208 RVA: 0x000C8760 File Offset: 0x000C6960
	internal virtual void JudgeCurrentObject()
	{
		if (this.8.26 != null)
		{
			bool flag = this.8.26 is 2123 && ((2123)this.8.26).78;
			this.ApplyJudgement(this.8.26.JudgeAtPosition(1535.6), this.8.26);
			bool flag2 = this.8.26 is 2123 && ((2123)this.8.26).78;
			this.8.36 |= (flag != flag2);
		}
	}

	// Token: 0x060027E1 RID: 10209 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal virtual void UpdateModeState()
	{
	}

	// Token: 0x060027E2 RID: 10210 RVA: 0x000C8814 File Offset: 0x000C6A14
	internal virtual void UpdateHealthDrain()
	{
		if (this.6 != null)
		{
			2023 <<EMPTY_NAME>> = this.4.8;
			2023 2 = 2023.SuddenDeath;
			if ((<<EMPTY_NAME>> & 2) > 2023.None && this.4.6 > 0)
			{
				this.6.SetHealth(0.0);
			}
		}
	}

	// Token: 0x060027E3 RID: 10211 RVA: 0x000C8863 File Offset: 0x000C6A63
	internal virtual void UpdateComboDisplay()
	{
		this.3.UpdateDisplay();
	}

	// Token: 0x060027E4 RID: 10212 RVA: 0x000C8870 File Offset: 0x000C6A70
	internal virtual void ResetCombo()
	{
		this.3.Reset();
	}

	// Token: 0x060027E5 RID: 10213 RVA: 0x000C887D File Offset: 0x000C6A7D
	internal virtual void UpdateModeInputEffects()
	{
		if (this.7)
		{
			bool flag = 2486.13;
		}
	}

	// Token: 0x060027E6 RID: 10214 RVA: 0x000C8890 File Offset: 0x000C6A90
	internal virtual bool HandleFailure(bool 1)
	{
		if (!1)
		{
			if (this.9 > 0)
			{
				this.9(false);
				return false;
			}
			if (!2486.4)
			{
				foreach (2034 2 in this.5.36)
				{
					2.StopHitSounds();
				}
				1226.110();
				2486.4 = true;
				2486.5 = 1226.16;
				if (!1535.1() && 2486.14() == 2147.Osu && (this.4.8 & (2023.Autoplay | 2023.Cinema)) == 2023.None)
				{
					1262 3 = 1272.5();
					2210.14((3 != null) ? 3.23 : null);
				}
				if (2486.14() != 2147.OsuMania)
				{
					2486.88.26.Add(new 1840(1226.16 + 5, this.GetReplayCursorPosition().X, this.GetReplayCursorPosition().Y, 1572.None));
				}
				2023 4 = this.4.8;
				2023 5 = 2023.Perfect;
				if ((4 & 5) > 2023.None)
				{
					2486.83(false);
				}
				else
				{
					this.23 = 1226.24("failsound", 100, (1416)7, false);
				}
			}
			return true;
		}
		else
		{
			if (this.9 > 0)
			{
				this.9(true);
				return false;
			}
			if (2486.14() == 2147.OsuMania || 2486.14() == 2147.Taiko)
			{
				return true;
			}
			this.8.1(true);
			return true;
		}
	}

	// Token: 0x060027E7 RID: 10215 RVA: 0x000C89FC File Offset: 0x000C6BFC
	internal void 9(bool 1)
	{
		if (this.6.3() < 160.0)
		{
			this.6.AddHealth(160.0);
			this.6.9 = true;
			this.6.11 = 0.07999999821186066;
			this.6.FadeMarkerColour(198.Red);
			this.6.FadeMarkerColour(198.White);
		}
		if (!1)
		{
			2486.16 = true;
			1226.107();
			1226.24("readys", 100, (1416)7, false);
		}
		this.8.1(false);
		this.9--;
	}

	// Token: 0x060027E8 RID: 10216 RVA: 0x000C8AAC File Offset: 0x000C6CAC
	internal virtual void FinalizeScore()
	{
		this.8.46 = true;
		this.4.18 = !2486.4;
		this.4.22 = (this.17 - this.4.13 <= 0);
		if (this.6 == null || !this.6.7())
		{
			return;
		}
		List<1371> obj = this.1.28;
		lock (obj)
		{
			foreach (1371 <<EMPTY_NAME>> in this.1.28)
			{
				((1433)<<EMPTY_NAME>>).16(700, (1046)0, 0);
			}
		}
		obj = this.15.28;
		lock (obj)
		{
			foreach (1371 2 in this.15.28)
			{
				((1433)2).16(700, (1046)0, 0);
			}
		}
		this.6.8(false);
	}

	// Token: 0x060027E9 RID: 10217 RVA: 0x000C8C1C File Offset: 0x000C6E1C
	internal void 10(bool 1)
	{
		this.4 = 2486.88;
		this.4.ResetJudgements(1);
		if (this.7)
		{
			if (this.3 != null)
			{
				this.3.Reset();
			}
			if (this.6 != null)
			{
				this.6.ResetToFull();
			}
		}
	}

	// Token: 0x060027EA RID: 10218 RVA: 0x000C8C70 File Offset: 0x000C6E70
	private void 11()
	{
		if (2630.5.ComboSoundBursts.Count != 0 && this.33 != this.3.GetCombo())
		{
			int num = 2630.5.ComboSoundBursts.BinarySearch(this.3.GetCombo());
			if (num >= 0)
			{
				1226.24("comboburst-" + num.ToString(), 100, (1416)7, true);
			}
			this.33 = this.3.GetCombo();
		}
	}

	// Token: 0x060027EB RID: 10219 RVA: 0x000C8CEC File Offset: 0x000C6EEC
	internal virtual void OnJudgementApplied(2149 1, double 2, bool 3, 2034 4)
	{
		if (3)
		{
			this.11();
		}
		if (2 > 0.0 && this.6 != null)
		{
			this.6.PulseMarker();
			if (this.6.3() > 180.0)
			{
				using (2528.20(this.14))
				{
					this.6.AddMarkerBurst();
				}
			}
		}
	}

	// Token: 0x060027EC RID: 10220 RVA: 0x000C8D70 File Offset: 0x000C6F70
	internal virtual bool ShouldProcessHitInput()
	{
		return !2648.6 && ((2486.8 && 2486.21) || (1662.23 && (1535.14 == 199.Pressed || 1535.43 == 199.Pressed)) || 1535.14 != 1535.19 || 1535.43 != 1535.48);
	}

	// Token: 0x060027ED RID: 10221 RVA: 0x000C8DC8 File Offset: 0x000C6FC8
	internal virtual void ApplyJudgement(2149 1, 2034 2)
	{
		if (1 == (2149)0)
		{
			return;
		}
		this.8.125 = 2;
		this.8.142(1, 2);
		bool 3 = 2.39;
		bool flag = true;
		int num = 0;
		double num2 = 0.0;
		bool flag2 = false;
		2149 4 = 1;
		if (4 > (2149)0)
		{
			4 &= (2149)(-12648449);
		}
		2241 5 = this.4;
		if (((5 != null) ? 5.39 : null) != null && 4 > (2149)0)
		{
			4 &= (2149)(-14745601);
		}
		double num3;
		if (4 <= (2149)257)
		{
			if (4 <= (2149)7)
			{
				if (4 <= (2149)(-262144))
				{
					if (4 == (2149)(-1048576))
					{
						num3 = 0.0;
						goto IL_CF8;
					}
					if (4 == (2149)(-524288))
					{
						num3 = this.5.GetDifficultyRange((double)1926.5(1928.DrainRate, 1272.5().3), -4.0, -15.0, -28.0);
						flag = false;
						goto IL_CF8;
					}
					if (4 == (2149)(-262144))
					{
						num3 = this.5.GetDifficultyRange((double)1926.5(1928.DrainRate, 1272.5().3), -4.0, -15.0, -28.0);
						goto IL_CF8;
					}
				}
				else if (4 != (2149)(-131072))
				{
					if (4 != (2149)(-65536))
					{
						if (4 == (2149)7)
						{
							num3 = 0.5 - (double)1926.5(1928.DrainRate, 1272.5().3) * 0.05;
							num = 0;
							if (this.4.9 == 2147.OsuMania && this.4.39 != null)
							{
								flag = false;
								goto IL_CF8;
							}
							goto IL_CF8;
						}
					}
					else
					{
						num3 = ((this.4.39 == null || !(2 is 1978)) ? ((double)(0f - (1926.5(1928.DrainRate, 1272.5().3) + 1f)) * 1.5) : ((double)(0f - (1926.5(1928.DrainRate, 1272.5().3) + 1f)) * 0.75));
						if (3)
						{
							2241 6 = this.4;
							6.6 += 1;
							goto IL_CF8;
						}
						goto IL_CF8;
					}
				}
				else
				{
					num3 = this.5.GetDifficultyRange((double)1926.5(1928.DrainRate, 1272.5().3), -6.0, -25.0, -40.0);
					if (3)
					{
						2241 7 = this.4;
						7.6 += 1;
						goto IL_CF8;
					}
					goto IL_CF8;
				}
			}
			else if (4 <= (2149)32)
			{
				if (4 != (2149)8)
				{
					if (4 != (2149)16)
					{
						if (4 == (2149)32)
						{
							if (3)
							{
								2241 8 = this.4;
								8.5 += 1;
							}
							if (this.7)
							{
								this.31++;
							}
							return;
						}
					}
					else
					{
						num = 10;
						flag = false;
						num3 = this.25 * 3.0 * 0.10000000149011612;
						if (3)
						{
							2241 9 = this.4;
							9.3 += 1;
							goto IL_CF8;
						}
						goto IL_CF8;
					}
				}
				else
				{
					num = 10;
					num3 = this.25 * 3.0;
					2123 10 = this.8.26 as 2123;
					if (10 != null && !2630.21())
					{
						1433 11 = new 1433(1455.2("sliderpoint10", (1416)7, null), (1376)1, 1065.Centre, (1044)1, 10.45.17, 1f, false, 198.White, null);
						11.22(new 208(0f, -10f), 300, (1046)1);
						11.3.Add(new 1445(1456.Fade, 1f, 0f, 1226.16 + 300, 1226.16 + 360, (1046)0));
						this.5.39.12(11);
						goto IL_CF8;
					}
					goto IL_CF8;
				}
			}
			else if (4 <= (2149)128)
			{
				if (4 != (2149)64)
				{
					if (4 == (2149)128)
					{
						num = 30;
						num3 = this.25 * 4.0;
						goto IL_CF8;
					}
				}
				else
				{
					num = 30;
					num3 = this.25 * 4.0;
					2123 12 = this.8.26 as 2123;
					if (12 != null && !2630.21())
					{
						1433 13 = new 1433(1455.2("sliderpoint30", (1416)7, null), (1376)1, 1065.Centre, (1044)1, 12.45.17, 1f, false, 198.White, null);
						13.22(new 208(0f, -10f), 300, (1046)1);
						13.3.Add(new 1445(1456.Fade, 1f, 0f, 1226.16 + 300, 1226.16 + 360, (1046)0));
						this.5.39.12(13);
						goto IL_CF8;
					}
					goto IL_CF8;
				}
			}
			else if (4 != (2149)256)
			{
				if (4 == (2149)257)
				{
					num = 50;
					flag = !2.HasObjectType(2047.Slider);
					flag2 = true;
					num3 = this.24 * 6.0 + this.25 * this.5.GetDifficultyRange((double)1926.5(1928.DrainRate, 1272.5().3), 3.2, 0.4, 0.4);
					if (3)
					{
						2241 14 = this.4;
						14.3 += 1;
						goto IL_CF8;
					}
					goto IL_CF8;
				}
			}
			else
			{
				num = 50;
				flag = !2.HasObjectType(2047.Slider);
				flag2 = true;
				num3 = this.25 * this.5.GetDifficultyRange((double)1926.5(1928.DrainRate, 1272.5().3), 3.2, 0.4, 0.4);
				if (3)
				{
					2241 15 = this.4;
					15.3 += 1;
					goto IL_CF8;
				}
				goto IL_CF8;
			}
		}
		else if (4 <= (2149)32768)
		{
			if (4 <= (2149)2048)
			{
				switch (4)
				{
				case (2149)512:
				{
					num = ((this is 2187) ? 150 : 100);
					flag = !2.HasObjectType(2047.Slider);
					2241 16 = this.4;
					if (16 != null && 16.9 == 2147.Taiko)
					{
						2241 17 = this.4;
						if (((17 != null) ? 17.39 : null) != null)
						{
							flag = true;
						}
					}
					flag2 = true;
					num3 = this.25 * this.5.GetDifficultyRange((double)1926.5(1928.DrainRate, 1272.5().3), 17.6, 2.2, 2.2);
					if (3)
					{
						2241 18 = this.4;
						18.1 += 1;
						goto IL_CF8;
					}
					goto IL_CF8;
				}
				case (2149)513:
					num = 100;
					flag = !2.HasObjectType(2047.Slider);
					flag2 = true;
					num3 = this.24 * 6.0 + this.25 * this.5.GetDifficultyRange((double)1926.5(1928.DrainRate, 1272.5().3), 17.6, 2.2, 2.2);
					if (3)
					{
						2241 19 = this.4;
						19.1 += 1;
						goto IL_CF8;
					}
					goto IL_CF8;
				case (2149)514:
					num = 100;
					flag = !2.HasObjectType(2047.Slider);
					flag2 = true;
					num3 = this.24 * 10.0 + this.25 * this.5.GetDifficultyRange((double)1926.5(1928.DrainRate, 1272.5().3), 17.6, 2.2, 2.2);
					if (3)
					{
						2241 20 = this.4;
						20.1 += 1;
						2241 21 = this.4;
						21.5 += 1;
						goto IL_CF8;
					}
					goto IL_CF8;
				default:
					switch (4)
					{
					case (2149)1024:
					{
						num = 300;
						flag = !2.HasObjectType(2047.Slider);
						2241 22 = this.4;
						if (22 != null && 22.9 == 2147.Taiko)
						{
							2241 23 = this.4;
							if (((23 != null) ? 23.39 : null) != null)
							{
								flag = true;
							}
						}
						flag2 = true;
						num3 = this.25 * 6.0;
						if (3)
						{
							2241 24 = this.4;
							24.2 += 1;
							goto IL_CF8;
						}
						goto IL_CF8;
					}
					case (2149)1025:
						num = 300;
						flag = !2.HasObjectType(2047.Slider);
						flag2 = true;
						num3 = this.24 * 6.0 + this.25 * 6.0;
						if (3)
						{
							2241 25 = this.4;
							25.2 += 1;
							goto IL_CF8;
						}
						goto IL_CF8;
					case (2149)1026:
						num = 300;
						flag = !2.HasObjectType(2047.Slider);
						flag2 = true;
						num3 = this.24 * 10.0 + this.25 * 6.0;
						if (3)
						{
							2241 26 = this.4;
							26.2 += 1;
							2241 27 = this.4;
							27.5 += 1;
							goto IL_CF8;
						}
						goto IL_CF8;
					case (2149)1027:
						break;
					case (2149)1028:
						num = 300;
						flag = !2.HasObjectType(2047.Slider);
						flag2 = true;
						num3 = this.24 * 14.0 + this.25 * 6.0;
						if (3)
						{
							2241 28 = this.4;
							28.2 += 1;
							2241 29 = this.4;
							29.4 += 1;
							goto IL_CF8;
						}
						goto IL_CF8;
					default:
						if (4 == (2149)2048)
						{
							num = 100;
							num3 = this.25 * 3.0;
							if (3)
							{
								2241 30 = this.4;
								30.1 += 1;
								goto IL_CF8;
							}
							goto IL_CF8;
						}
						break;
					}
					break;
				}
			}
			else if (4 <= (2149)8192)
			{
				if (4 == (2149)4096)
				{
					num = 0;
					num3 = this.25 * 1.7;
					flag = false;
					goto IL_CF8;
				}
				if (4 == (2149)8192)
				{
					num = 100;
					num3 = this.25 * 1.7;
					flag = false;
					goto IL_CF8;
				}
			}
			else
			{
				if (4 == (2149)16384)
				{
					num = 1100;
					num3 = this.25 * 2.0;
					flag = false;
					goto IL_CF8;
				}
				if (4 == (2149)32768)
				{
					num = 300;
					flag = false;
					num3 = 0.0001;
					if (2.15)
					{
						num = (int)((float)num * 1.2f);
						goto IL_CF8;
					}
					goto IL_CF8;
				}
			}
		}
		else if (4 <= (2149)16777216)
		{
			if (4 == (2149)1048576)
			{
				num = 300;
				num3 = 0.0;
				flag = false;
				goto IL_CF8;
			}
			if (4 != (2149)2097152)
			{
				if (4 == (2149)16777216)
				{
					num = 50;
					flag2 = true;
					num3 = (double)(0f - (1926.5(1928.DrainRate, 1272.5().3) + 1f)) * 0.32;
					if (3)
					{
						2241 31 = this.4;
						31.3 += 1;
						goto IL_CF8;
					}
					goto IL_CF8;
				}
			}
			else
			{
				num = 300;
				flag2 = true;
				num3 = 0.0;
				2241 32 = this.4;
				if (((32 != null) ? 32.39 : null) == null)
				{
					flag = false;
					goto IL_CF8;
				}
				goto IL_CF8;
			}
		}
		else if (4 <= (2149)67108864)
		{
			if (4 != (2149)33554432)
			{
				if (4 == (2149)67108864)
				{
					num = 200;
					flag2 = true;
					num3 = this.25 * (0.8 - (double)1926.5(1928.DrainRate, 1272.5().3) * 0.08);
					if (3)
					{
						2241 33 = this.4;
						33.5 += 1;
						goto IL_CF8;
					}
					goto IL_CF8;
				}
			}
			else
			{
				num = 100;
				flag2 = true;
				num3 = 0.0;
				if (3)
				{
					2241 34 = this.4;
					34.1 += 1;
					goto IL_CF8;
				}
				goto IL_CF8;
			}
		}
		else if (4 != (2149)134217728)
		{
			if (4 == (2149)268435456)
			{
				num = 2150.2;
				flag2 = true;
				num3 = this.25 * (1.1 - (double)1926.5(1928.DrainRate, 1272.5().3) * 0.1);
				if (3)
				{
					2241 35 = this.4;
					35.4 += 1;
					goto IL_CF8;
				}
				goto IL_CF8;
			}
		}
		else
		{
			num = 300;
			flag2 = true;
			num3 = this.25 * (1.0 - (double)1926.5(1928.DrainRate, 1272.5().3) * 0.1);
			if (3)
			{
				2241 36 = this.4;
				36.2 += 1;
				goto IL_CF8;
			}
			goto IL_CF8;
		}
		num3 = 0.0;
		flag = false;
		IL_CF8:
		if (this.4.9 == 2147.OsuMania)
		{
			int num4 = 0;
			double num5 = 2019.12(2486.88.8 & 2023.ScoreIncreaseMods, 2486.14(), this.5.21);
			if (4 <= (2149)33554432)
			{
				if (4 != (2149)(-65536))
				{
					if (4 != (2149)16777216)
					{
						if (4 == (2149)33554432)
						{
							this.27 -= 24.0 / num5;
							num4 = 8;
						}
					}
					else
					{
						this.27 -= 44.0 / num5;
						num4 = 4;
					}
				}
				else
				{
					this.27 = -56.0 / num5;
					num4 = 0;
				}
			}
			else if (4 != (2149)67108864)
			{
				if (4 != (2149)134217728)
				{
					if (4 == (2149)268435456)
					{
						this.27 += 2.0;
						num4 = 32;
					}
				}
				else
				{
					this.27 += 1.0;
					num4 = 32;
				}
			}
			else
			{
				this.27 -= 8.0 / num5;
				num4 = 16;
			}
			if (this.4.36 != 0 && (int)this.4.36 % 2150.5 == 0)
			{
				this.27 = (double)2150.4;
			}
			this.27 = Math.Max(0.0, Math.Min(this.27, (double)2150.4));
			num2 = Math.Sqrt(this.27) * (double)num4 * this.26 / (double)2150.2;
		}
		int num6 = 0;
		if (1 > (2149)0 && (1 & (2149)12648448) > (2149)0)
		{
			if (num > 0)
			{
				if (!flag)
				{
					num += num / 5;
				}
			}
			else
			{
				num = 2.41 / 50 * 50;
			}
			if ((1 & (2149)8388608) > (2149)0)
			{
				num6 = -1;
			}
		}
		2.41 = num;
		if (flag2)
		{
			2147 37 = 2486.14();
			if (37 != 2147.Taiko)
			{
				if (37 != 2147.OsuMania)
				{
					num += (int)((double)Math.Max(0, this.3.GetCombo() - 1) * ((double)(num / 25) * this.26));
				}
				else
				{
					if (this.4.39 == null)
					{
						this.4.SetRawScore((int)this.4.32);
					}
					num2 += (double)num * this.26 / (double)2150.2;
					num = (int)num2;
				}
			}
			else
			{
				num += (int)((double)(num / 35 * 2 * (1272.5().15() + 1)) * 2019.12(this.4.8, 2486.14(), this.5.21)) * (Math.Min(100, this.3.GetCombo() + num6) / 10);
				if ((4 == (2149)2097152 && 2486.103) || 2.15)
				{
					num = (int)((float)num * 1.2f);
				}
			}
		}
		if (1 > (2149)0)
		{
			if ((1 & (2149)12582912) > (2149)0)
			{
				if (num > 0)
				{
					if (!flag)
					{
						num += num / 5;
					}
				}
				else
				{
					num = 2.41 / 50 * 50;
				}
				if ((1 & (2149)8388608) > (2149)0)
				{
					flag = false;
				}
			}
			if ((1 & (2149)2162688) > (2149)0)
			{
				if (flag)
				{
					if (2.41 == 300)
					{
						2241 38 = this.4;
						38.4 += 1;
					}
					else if (2.41 == 150)
					{
						2241 39 = this.4;
						39.5 += 1;
					}
				}
				num *= 2;
			}
		}
		if (flag)
		{
			if (1 > (2149)0)
			{
				2241 40 = this.4;
				int val = this.4.13;
				2499 41 = this.3;
				int num7 = 41.GetCombo() + 1;
				41.SetCombo(num7);
				40.13 = Math.Max(val, num7);
				this.4.36 = (ushort)this.3.GetCombo();
			}
			else
			{
				if (this.3.GetCombo() > 20 && (!2486.21 || 1304.30.1()) && !2486.22 && !2486.190)
				{
					1226.29(1226.48("combobreak", false, true, (1416)7), 100, 0f, false, 1f, true);
					if (1662.47)
					{
						1662.51.40(198.Red, 2000);
						1662.51.15 = 0.8f;
						1662.51.25(1f, 2000, (1046)25);
					}
				}
				2241 42 = this.4;
				int num8;
				this.3.SetCombo(num8 = 0);
				42.36 = (ushort)num8;
				2023 43 = this.4.8;
				2023 44 = 2023.SuddenDeath;
				if ((43 & 44) > 2023.None)
				{
					this.6.SetHealth(0.0);
				}
			}
		}
		if (this.8.80 != (707)0)
		{
			this.OnJudgementApplied(1, num3, flag, 2);
		}
		if (num3 > 0.0)
		{
			this.6.AddHealth(num3);
		}
		else
		{
			this.6.Drain(0.0 - num3);
		}
		if (3 || (1 & (2149)8388608) > (2149)0)
		{
			2153 45 = this.4.39;
			if (45 != null)
			{
				switch (this.4.9)
				{
				case 2147.Taiko:
					45.2(new 2194(1, flag, flag2));
					break;
				case 2147.CatchTheBeat:
					45.2(new 1880(1, flag, flag2));
					break;
				case 2147.OsuMania:
					45.2(new 1988(1, flag, flag2));
					break;
				default:
					45.2(new 2155(1, flag, flag2));
					break;
				}
			}
			else
			{
				2241 46 = this.4;
				46.SetRawScore(46.GetScore() + num);
				this.4.32 += num2;
			}
		}
		if (this.8.80 == (707)2 && this.11 != null)
		{
			this.11.OnJudged(1);
		}
		if (this.7)
		{
			this.31++;
		}
		this.8.2();
	}

	// Token: 0x060027EE RID: 10222 RVA: 0x000CA0BE File Offset: 0x000C82BE
	internal virtual void RecoverHealthForBreak()
	{
		if (this.6 != null)
		{
			this.6.10(190.0);
		}
	}

	// Token: 0x060027EF RID: 10223 RVA: 0x000CA0DC File Offset: 0x000C82DC
	internal virtual void CreateComboParticles()
	{
		double num = 1196.3();
		for (int i = 0; i < Math.Min(16, this.3.GetCombo() / 6); i++)
		{
			int num2 = 1662.33 + 1196.2(300, 1000);
			if (num > 0.5 || this.3.GetCombo() >= 100)
			{
				208 <<EMPTY_NAME>> = new 208(-10f, (float)1196.2(0, 480));
				1433 2 = new 1433(this.8.81, (1376)6, 1065.Centre, (1044)0, <<EMPTY_NAME>>, 0.05f, false, 198.White, null);
				1445 3 = new 1445(1456.Scale, 1f, 1196.7(1f, 3f), 1662.33, num2, (1046)0);
				1445 4 = new 1445(1456.Fade, 1f, 0f, 1662.33, num2, (1046)0);
				1445 5 = new 1445(1456.Rotation, 1196.7(-2f, 2f), 1196.7(-2f, 2f), 1662.33, num2, (1046)0);
				3.15 = (1046)1;
				4.15 = (1046)1;
				5.15 = (1046)1;
				2.3.Add(3);
				2.3.Add(4);
				2.3.Add(5);
				this.15.12(2);
				1662.44.2(2, null, false).2 = new 208((float)1196.2(100, 500), (float)1196.2(-120, 0));
			}
			if (num <= 0.5 || this.3.GetCombo() >= 100)
			{
				208 <<EMPTY_NAME>> = new 208((float)(1662.70.1() + 10), (float)1196.2(0, 480));
				1433 6 = new 1433(this.8.81, (1376)6, 1065.Centre, (1044)0, <<EMPTY_NAME>>, 0.05f, false, 198.White, null);
				1445 7 = new 1445(1456.Scale, 1f, 1196.7(1f, 2.5f), 1662.33, num2, (1046)0);
				1445 8 = new 1445(1456.Fade, 1f, 0f, 1662.33, num2, (1046)0);
				1445 9 = new 1445(1456.Rotation, 1196.7(-2f, 2f), 1196.7(-2f, 2f), 1662.33, num2, (1046)0);
				7.15 = (1046)1;
				8.15 = (1046)1;
				9.15 = (1046)1;
				6.3.Add(7);
				6.3.Add(8);
				6.3.Add(9);
				this.15.12(6);
				1662.44.2(6, null, false).2 = new 208((float)1196.2(-500, -100), (float)1196.2(-120, 0));
			}
		}
	}

	// Token: 0x060027F0 RID: 10224 RVA: 0x000CA3C0 File Offset: 0x000C85C0
	internal virtual void ShowComboBurst()
	{
		double num = 1196.3();
		if (this.19 != null && this.19.Length != 0)
		{
			if (2630.5.ComboBurstRandom)
			{
				this.18 = 1196.2(0, this.19.Length);
			}
			1433 <<EMPTY_NAME>> = new 1433(this.19[this.18], (1376)6, 1065.BottomLeft, (1044)0, 208.Zero, 1f, false, 198.White, null);
			208 2 = (num > 0.5) ? new 208((float)1662.70.1(), 480f) : new 208((float)(-(float)this.19[this.18].3()) * 0.625f, 480f);
			208 3 = (num > 0.5) ? new 208((float)1662.70.1() - (float)this.19[this.18].3() * 0.625f, 480f) : new 208(0f, 480f);
			if (num > 0.5)
			{
				<<EMPTY_NAME>>.45(true);
			}
			1445 item = new 1445(2, 3, 1662.33, 1662.33 + 700, (1046)1);
			<<EMPTY_NAME>>.3.Add(new 1445(1456.Fade, 1f, 0f, 1662.33 + 200, 1662.33 + 1200, (1046)2));
			<<EMPTY_NAME>>.3.Add(item);
			this.8.73.12(<<EMPTY_NAME>>);
			this.18 = (this.18 + 1) % this.19.Length;
		}
		this.CreateComboParticles();
	}

	// Token: 0x060027F1 RID: 10225 RVA: 0x000CA560 File Offset: 0x000C8760
	internal void 12()
	{
		this.8.27 = 1f;
		this.8.34.19(1f);
		for (int i = 0; i < 50; i++)
		{
			int num = 1226.16 + i * 10;
			int num2 = num + 1196.2(300, 1000);
			1445 <<EMPTY_NAME>> = new 1445(1456.Scale, 1f, 1196.7(1f, 1304.107 ? 2.1f : 2.8f), num, num2, (1046)0);
			1445 2 = new 1445(1456.Fade, 1f, 0f, num, num2, (1046)0);
			1445 3 = new 1445(1456.Rotation, 1196.7(-2f, 2f), 1196.7(-2f, 2f), num, num2, (1046)0);
			<<EMPTY_NAME>>.15 = (1046)1;
			2.15 = (1046)1;
			3.15 = (1046)1;
			208 4 = new 208(30f, 490f);
			1433 5 = new 1433(this.8.81, (1376)6, 1065.Centre, (1044)1, 4, 0.05f, false, 198.White, null);
			5.3.Add(<<EMPTY_NAME>>);
			5.3.Add(2);
			5.3.Add(3);
			this.15.12(5);
			1662.44.2(5, new 208?(new 208((float)1196.2(300, 450), (float)1196.2(-800, -700))), false).3 = 60f;
			4 = new 208((float)(1662.70.1() - 30), 490f);
			1433 6 = new 1433(this.8.81, (1376)6, 1065.Centre, (1044)1, 4, 0.05f, false, 198.White, null);
			6.3.Add(<<EMPTY_NAME>>);
			6.3.Add(2);
			6.3.Add(3);
			this.15.12(6);
			1662.44.2(6, new 208?(new 208((float)1196.2(-450, -300), (float)1196.2(-800, -700))), false).3 = 60f;
		}
	}

	// Token: 0x060027F2 RID: 10226 RVA: 0x000CA7A8 File Offset: 0x000C89A8
	internal virtual void ApplyKiaiHitLighting()
	{
		if (!this.8.102)
		{
			return;
		}
		int num = (int)(1226.76() * 0.75 * 100.0 / 1226.38());
		foreach (2034 <<EMPTY_NAME>> in this.8.39.36)
		{
			int num2 = num;
			if (num2 + 1226.16 > <<EMPTY_NAME>>.2)
			{
				num2 = <<EMPTY_NAME>>.2 - 1226.16;
			}
			if (num2 >= 0 && !<<EMPTY_NAME>>.11 && <<EMPTY_NAME>>.IsActive() && <<EMPTY_NAME>>.30.Count != 0)
			{
				float num3 = 0f;
				int num4 = Math.Max(25, 300 - (int)<<EMPTY_NAME>>.7.R - (int)<<EMPTY_NAME>>.7.G - (int)<<EMPTY_NAME>>.7.B);
				198 2 = new 198((byte)Math.Min((int)<<EMPTY_NAME>>.7.R + num4, 255), (byte)Math.Min((int)<<EMPTY_NAME>>.7.G + num4, 255), (byte)Math.Min((int)<<EMPTY_NAME>>.7.B + num4, 255));
				if (1304.91)
				{
					1433 3 = new 1433(1455.2("lighting", (1416)7, null), <<EMPTY_NAME>>.30[0].41, 1065.Centre, (1044)2, <<EMPTY_NAME>>.8, 0f, false, <<EMPTY_NAME>>.7, null);
					3.15 = 1.2f;
					3.3.Add(new 1445(1456.Fade, 0f, 0.5f, 1226.16, 1226.16 + 50, (1046)0));
					3.3.Add(new 1445(1456.Fade, 0.5f, num3, 1226.16 + 50, 1226.16 + num2 * 2, (1046)0));
					3.28 = true;
					this.8.39.39.12(3);
				}
				foreach (1433 4 in <<EMPTY_NAME>>.CreateLightingSprites())
				{
					if (4 != null && 4.19)
					{
						4.1 = (1044)2;
						4.2 += 0.1f;
						4.28 = true;
						4.5 = false;
						4.6 = 2;
						4.3.RemoveAll(new Predicate<1445>(2504.2505.Instance.1));
						4.3.Add(new 1445(1456.Fade, 4.16 * 0.3f, num3 * 4.16, 1226.16, 1226.16 + num2, (1046)0));
						this.8.39.39.12(4);
					}
				}
			}
		}
	}

	// Token: 0x060027F3 RID: 10227 RVA: 0x000CAAE0 File Offset: 0x000C8CE0
	internal virtual void OnKiaiStateChanged(bool 1)
	{
		if (1)
		{
			this.12();
		}
	}

	// Token: 0x060027F4 RID: 10228 RVA: 0x000CAAEB File Offset: 0x000C8CEB
	internal virtual 2032 GetHitAttemptDisposition(2034 1)
	{
		return 2138.1(this.5, 1);
	}

	// Token: 0x060027F5 RID: 10229 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal virtual void OnSectionPassStateChanged(bool 1)
	{
	}

	// Token: 0x060027F6 RID: 10230 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal virtual void OnModDisplayShown()
	{
	}

	// Token: 0x060027F7 RID: 10231 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal virtual void AdjustStoryboardSprite(1433 1)
	{
	}

	// Token: 0x060027F8 RID: 10232 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal virtual bool CapturesCursor()
	{
		return false;
	}

	// Token: 0x04001CA5 RID: 7333
	protected readonly 1436 1;

	// Token: 0x04001CA6 RID: 7334
	protected readonly 1436 2;

	// Token: 0x04001CA7 RID: 7335
	internal 2499 3;

	// Token: 0x04001CA8 RID: 7336
	internal 2241 4;

	// Token: 0x04001CA9 RID: 7337
	internal 2039 5;

	// Token: 0x04001CAA RID: 7338
	internal 2506 6;

	// Token: 0x04001CAB RID: 7339
	internal bool 7;

	// Token: 0x04001CAC RID: 7340
	protected 2486 8;

	// Token: 0x04001CAD RID: 7341
	internal int 9;

	// Token: 0x04001CAE RID: 7342
	protected internal 2541 10;

	// Token: 0x04001CAF RID: 7343
	internal 2542 11;

	// Token: 0x04001CB0 RID: 7344
	internal 2538 12;

	// Token: 0x04001CB1 RID: 7345
	internal 2511 13;

	// Token: 0x04001CB2 RID: 7346
	private 2528 14;

	// Token: 0x04001CB3 RID: 7347
	protected 1436 15;

	// Token: 0x04001CB4 RID: 7348
	protected 1436 16;

	// Token: 0x04001CB5 RID: 7349
	internal int 17;

	// Token: 0x04001CB6 RID: 7350
	protected int 18;

	// Token: 0x04001CB7 RID: 7351
	protected 1381[] 19;

	// Token: 0x04001CB8 RID: 7352
	internal 1433 20;

	// Token: 0x04001CB9 RID: 7353
	private int 21;

	// Token: 0x04001CBA RID: 7354
	internal 1433 22;

	// Token: 0x04001CBB RID: 7355
	private 1256 23;

	// Token: 0x04001CBC RID: 7356
	internal double 24 = 1.0;

	// Token: 0x04001CBD RID: 7357
	internal double 25 = 1.0;

	// Token: 0x04001CBE RID: 7358
	internal double 26 = 1.0;

	// Token: 0x04001CBF RID: 7359
	private double 27 = (double)2150.4;

	// Token: 0x04001CC0 RID: 7360
	public static 2504 28;

	// Token: 0x04001CC1 RID: 7361
	protected double 29;

	// Token: 0x04001CC2 RID: 7362
	protected 208 30;

	// Token: 0x04001CC3 RID: 7363
	internal int 31;

	// Token: 0x04001CC4 RID: 7364
	protected bool 32;

	// Token: 0x04001CC5 RID: 7365
	private int 33;

	// Token: 0x02000515 RID: 1301
	[276]
	[Serializable]
	public sealed class 2505
	{
		// Token: 0x060027F9 RID: 10233 RVA: 0x000CAAF9 File Offset: 0x000C8CF9
		internal bool 1(1445 1)
		{
			return 1.14 == 1456.Fade;
		}

		// Token: 0x04001CC6 RID: 7366
		public static readonly 2504.2505 Instance = new 2504.2505();

		// Token: 0x04001CC7 RID: 7367
		public static 1189 voidDelegate;

		// Token: 0x04001CC8 RID: 7368
		public static Predicate<1445> predicate;
	}
}
