using System;
using System.Collections.Generic;
using osu_gameplay;

// Token: 0x0200075C RID: 1884
public sealed class 1999 : 2504
{
	// Token: 0x06003754 RID: 14164 RVA: 0x0015AD20 File Offset: 0x00158F20
	public 1999(2486 1) : base(1)
	{
	}

	// Token: 0x06003755 RID: 14165 RVA: 0x0015AD29 File Offset: 0x00158F29
	internal override void PreloadJudgementTextures()
	{
		base.PreloadJudgementTextures();
	}

	// Token: 0x06003756 RID: 14166 RVA: 0x0015AD31 File Offset: 0x00158F31
	public override void Dispose()
	{
		base.Dispose();
	}

	// Token: 0x06003757 RID: 14167 RVA: 0x0015AD39 File Offset: 0x00158F39
	internal override bool ShouldHideCursor()
	{
		if (2486.14)
		{
			return !1535.6();
		}
		return base.ShouldHideCursor();
	}

	// Token: 0x06003758 RID: 14168 RVA: 0x0015AD54 File Offset: 0x00158F54
	internal override void CreateModSprites()
	{
		base.CreateModSprites();
		this.6 = this.5.41.9;
		if (!1304.9((1321)0))
		{
			1763.2(string.Format(1568.1(2679.Tips_ManiaSpeedChange), 1548.10(1532.IncreaseSpeed), 1548.10(1532.DecreaseSpeed)), 2500, (1389)0);
			1304.10((1321)0, true);
		}
		if (1304.74)
		{
			this.19 = 1455.5("comboburst-mania", (1416)7, true);
		}
	}

	// Token: 0x06003759 RID: 14169 RVA: 0x000C887D File Offset: 0x000C6A7D
	internal override void UpdateModeState()
	{
		if (this.7)
		{
			bool <<EMPTY_NAME>> = 2486.13;
		}
	}

	// Token: 0x0600375A RID: 14170 RVA: 0x0015ADD2 File Offset: 0x00158FD2
	protected override void CreateScoreMeter()
	{
		if (1304.166 == 2151.Colour)
		{
			this.11 = new 1994(1662.11, this.5);
			return;
		}
		base.CreateScoreMeter();
	}

	// Token: 0x0600375B RID: 14171 RVA: 0x0015AE00 File Offset: 0x00159000
	internal override void InitializeHealthDrain()
	{
		this.5.41.9.12 = this.16();
		2023 <<EMPTY_NAME>> = 2486.88.8;
		2023 2 = 2023.HalfTime;
		if ((<<EMPTY_NAME>> & 2) > 2023.None)
		{
			this.5.41.9.12 *= 1939.19(2023.HalfTime);
		}
		base.InitializeHealthDrain();
	}

	// Token: 0x0600375C RID: 14172 RVA: 0x0015AE70 File Offset: 0x00159070
	internal override void ApplyGameplayMods()
	{
		1975 <<EMPTY_NAME>> = (1975)this.5;
		double num = 2019.12(2486.88.8 & ~(2023.Hidden | 2023.HardRock | 2023.DoubleTime | 2023.Flashlight | 2023.FadeIn), 2486.14(), <<EMPTY_NAME>>.21);
		this.26 = (double)2150.1 / (double)<<EMPTY_NAME>>.66 * num;
		2023 2 = 2486.88.8;
		2023 3 = 2023.SuddenDeath;
		if ((2 & 3) <= 2023.None)
		{
			2023 4 = 2486.88.8;
			3 = 2023.Easy;
			if ((4 & 3) > 2023.None)
			{
				this.9 = 2;
			}
		}
		2023 5 = 2486.88.8;
		3 = 2023.Flashlight;
		if ((5 & 3) > 2023.None)
		{
			this.16 = new 1436(true);
			this.20 = new 1433(null, (1376)3, 1065.CentreLeft, (1044)0, new 208(0f, 220f), 1f, true, 198.White, null);
			this.20.15 = 1.4f;
			this.16.12(this.20);
			this.LoadFlashlightTexture();
		}
	}

	// Token: 0x0600375D RID: 14173 RVA: 0x0015AF70 File Offset: 0x00159170
	protected override void LoadFlashlightTexture()
	{
		if (this.20 == null)
		{
			return;
		}
		this.32 = true;
		byte[] array = ResourcesStore.ResourceManager.GetObject("flashlightv2_mania") as byte[];
		if (array == null)
		{
			this.32 = false;
			array = (ResourcesStore.ResourceManager.GetObject("flashlight2") as byte[]);
		}
		this.20.SetTexture(1381.16(array));
	}

	// Token: 0x0600375E RID: 14174 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void UpdateFlashlight()
	{
	}

	// Token: 0x0600375F RID: 14175 RVA: 0x0015AFD2 File Offset: 0x001591D2
	internal override void UpdateModeInputEffects()
	{
		if (this.7 && !2486.13)
		{
			this.5.41.21();
		}
	}

	// Token: 0x06003760 RID: 14176 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void JudgeCurrentObject()
	{
	}

	// Token: 0x06003761 RID: 14177 RVA: 0x0015AFF3 File Offset: 0x001591F3
	internal override 208 GetScoreboardPosition()
	{
		return new 208(0f, 135f);
	}

	// Token: 0x06003762 RID: 14178 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal override bool IsScoreboardMirrored()
	{
		return false;
	}

	// Token: 0x06003763 RID: 14179 RVA: 0x0015B004 File Offset: 0x00159204
	internal override void FinalizeScore()
	{
		base.FinalizeScore();
		this.4.SetRawScore((int)Math.Round(this.4.32));
		if (this.4.GetScore() == 999999)
		{
			this.4.SetRawScore(1000000);
		}
		if (this.4.6 + this.4.3 + this.4.1 == 0 && (double)((float)this.4.5 / (float)this.4.GetJudgementCount()) < 0.1)
		{
			this.4.22 = true;
		}
		else
		{
			this.4.22 = false;
		}
		this.4.8 = 2011.55(1272.5(), this.4.8);
		this.31++;
	}

	// Token: 0x06003764 RID: 14180 RVA: 0x0015B0F1 File Offset: 0x001592F1
	internal override void BeforeObjectUpdate()
	{
		if (this.7)
		{
			this.5.41.19();
		}
	}

	// Token: 0x06003765 RID: 14181 RVA: 0x0015B10B File Offset: 0x0015930B
	internal override void AfterObjectUpdate()
	{
		if (this.7)
		{
			this.5.41.20();
		}
	}

	// Token: 0x06003766 RID: 14182 RVA: 0x0015B128 File Offset: 0x00159328
	internal override void Draw()
	{
		if (this.7)
		{
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

	// Token: 0x06003767 RID: 14183 RVA: 0x0015B178 File Offset: 0x00159378
	internal override void CreateComboParticles()
	{
		foreach (2011 <<EMPTY_NAME>> in this.5.41)
		{
			for (int i = 0; i < Math.Min(16, this.3.GetCombo() / 16); i++)
			{
				int 2 = 1662.33 + 1196.2(300, 1000);
				208 3 = new 208(<<EMPTY_NAME>>.28() + 10f, (float)1196.2((int)Math.Ceiling((double)<<EMPTY_NAME>>.26()), (int)Math.Floor((double)<<EMPTY_NAME>>.31())));
				208 4 = new 208(<<EMPTY_NAME>>.30() - 10f, (float)1196.2((int)Math.Ceiling((double)<<EMPTY_NAME>>.26()), (int)Math.Floor((double)<<EMPTY_NAME>>.31())));
				1433 5 = new 1433(this.8.81, (1376)6, 1065.Centre, (1044)0, 3, 0.05f, false, 198.White, null);
				1433 6 = 5.Clone();
				6.17 = (6.7 = 4);
				5.3.Add(new 1445(1456.Scale, 1f, 1196.7(1f, 3f), 1662.33, 2, (1046)0)
				{
					15 = (1046)1
				});
				5.3.Add(new 1445(1456.Fade, 1f, 0f, 1662.33, 2, (1046)0)
				{
					15 = (1046)1
				});
				5.3.Add(new 1445(1456.Rotation, 1196.7(-2f, 2f), 1196.7(-2f, 2f), 1662.33, 2, (1046)0)
				{
					15 = (1046)1
				});
				6.3.Add(new 1445(1456.Scale, 1f, 1196.7(1f, 3f), 1662.33, 2, (1046)0)
				{
					15 = (1046)1
				});
				6.3.Add(new 1445(1456.Fade, 1f, 0f, 1662.33, 2, (1046)0)
				{
					15 = (1046)1
				});
				6.3.Add(new 1445(1456.Rotation, 1196.7(-2f, 2f), 1196.7(-2f, 2f), 1662.33, 2, (1046)0)
				{
					15 = (1046)1
				});
				this.15.12(5);
				this.15.12(6);
				1662.44.2(5, null, false).2 = new 208((float)1196.2(-500, -100), (float)1196.2(-120, 0));
				1662.44.2(6, null, false).2 = new 208((float)1196.2(100, 500), (float)1196.2(-120, 0));
			}
		}
	}

	// Token: 0x06003768 RID: 14184 RVA: 0x0015B478 File Offset: 0x00159678
	internal override void ShowComboBurst()
	{
		switch (this.5.41.4.ComboBurstStyle)
		{
		case 1989.Left:
			break;
		case 1989.Right:
			goto IL_3E;
		case 1989.Both:
			if (1196.3() > 0.5)
			{
				goto IL_3E;
			}
			break;
		default:
			goto IL_77;
		}
		this.13(this.5.41, false);
		goto IL_77;
		IL_3E:
		2011 <<EMPTY_NAME>> = this.5.41;
		while (<<EMPTY_NAME>>.4() != null)
		{
			<<EMPTY_NAME>> = <<EMPTY_NAME>>.4();
		}
		this.13(<<EMPTY_NAME>>, true);
		IL_77:
		this.CreateComboParticles();
		this.34 = this.3.GetCombo() - this.3.GetCombo() % 100;
	}

	// Token: 0x06003769 RID: 14185 RVA: 0x0015B524 File Offset: 0x00159724
	private new void 13(2011 1, bool 2)
	{
		if (this.19 != null && this.19.Length != 0)
		{
			if (2630.5.ComboBurstRandom)
			{
				this.18 = 1196.2(0, this.19.Length);
			}
			1433 3 = new 1433(this.19[this.18], (1376)6, 2 ? 1065.BottomLeft : 1065.BottomRight, (1044)0, 208.Zero, 1f, false, 198.White, null);
			208 4 = new 208(2 ? 1.28() : 1.30(), 1.31());
			208 5 = new 208(2 ? 1.30() : 1.28(), 1.31());
			3.45(2);
			3.3.Add(new 1445(1456.Fade, 0f, 1f, 1662.33, 1662.33 + 250, (1046)2));
			3.3.Add(new 1445(4, 5, 1662.33, 1662.33 + 1400, (1046)22));
			3.3.Add(new 1445(1456.Fade, 1f, 0f, 1662.33 + 400, 1662.33 + 1400, (1046)2));
			this.8.73.12(3);
			this.18 = (this.18 + 1) % this.19.Length;
		}
	}

	// Token: 0x0600376A RID: 14186 RVA: 0x0015B683 File Offset: 0x00159883
	internal override void SetPlayfieldOpacity(float 1)
	{
		this.5.41.35(1);
		base.SetPlayfieldOpacity(1);
	}

	// Token: 0x0600376B RID: 14187 RVA: 0x0015B69D File Offset: 0x0015989D
	internal override bool IsSectionPassing()
	{
		return this.5.41.9.3() >= 160.0;
	}

	// Token: 0x0600376C RID: 14188 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool AllowsScoreSubmission()
	{
		return true;
	}

	// Token: 0x0600376D RID: 14189 RVA: 0x0015B6C2 File Offset: 0x001598C2
	internal override bool AreAllObjectsJudged()
	{
		return this.4.GetJudgementCount() == this.17;
	}

	// Token: 0x0600376E RID: 14190 RVA: 0x0015B6D8 File Offset: 0x001598D8
	internal override bool ShouldProcessHitInput()
	{
		2011 <<EMPTY_NAME>> = this.5.41;
		for (int i = 0; i < <<EMPTY_NAME>>.19.Count; i++)
		{
			if (<<EMPTY_NAME>>.19[i].23() != <<EMPTY_NAME>>.19[i].18)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600376F RID: 14191 RVA: 0x0015B72E File Offset: 0x0015992E
	internal override 2039 CreateHitObjectManager()
	{
		return new 1975(true);
	}

	// Token: 0x06003770 RID: 14192 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool CanResumeWithoutCursorClick()
	{
		return true;
	}

	// Token: 0x06003771 RID: 14193 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void CreateHealthBar()
	{
	}

	// Token: 0x06003772 RID: 14194 RVA: 0x0015B736 File Offset: 0x00159936
	internal override void CreateComboCounter()
	{
		this.3 = new 1997(this.2, this.5.41, true);
	}

	// Token: 0x06003773 RID: 14195 RVA: 0x0015B755 File Offset: 0x00159955
	internal override bool IsComboBurstThreshold()
	{
		return this.3.GetCombo() - this.34 >= 100;
	}

	// Token: 0x06003774 RID: 14196 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal override bool ShouldShowBreakSections()
	{
		return false;
	}

	// Token: 0x06003775 RID: 14197 RVA: 0x0015B770 File Offset: 0x00159970
	internal override void ApplyJudgement(2149 1, 2034 2)
	{
		if ((2.11 && 1 != (2149)0) || 1 == (2149)(-1048576))
		{
			if (1 == (2149)(-65536) || 1 == (2149)(-1048576))
			{
				this.34 = 0;
			}
			this.8.11(1 != (2149)(-65536) && 1 != (2149)(-1048576));
		}
		base.ApplyJudgement(1, 2);
	}

	// Token: 0x06003776 RID: 14198 RVA: 0x0015B7D0 File Offset: 0x001599D0
	internal override void GenerateAutoplayReplay()
	{
		1535.39.26 = new List<1840>();
		List<1840> <<EMPTY_NAME>> = 1535.39.26;
		<<EMPTY_NAME>>.Add(new 1840(0, 0f, this.35, 1572.None));
		for (int i = 0; i < this.5.35; i++)
		{
			1999.2001 generateAutoplayReplayClosure = new 1999.2001();
			generateAutoplayReplayClosure.3 = this;
			generateAutoplayReplayClosure.1 = (1979)this.5.34[i];
			if (generateAutoplayReplayClosure.1.2 < 1535.41)
			{
				generateAutoplayReplayClosure.1.11 = true;
			}
			else
			{
				generateAutoplayReplayClosure.2 = 0;
				if (this.5.41.42())
				{
					generateAutoplayReplayClosure.2 = this.5.41.19[(generateAutoplayReplayClosure.1.44 != this.5.41.19.Count - 1) ? (generateAutoplayReplayClosure.1.44 + 1) : 0].20();
				}
				else
				{
					generateAutoplayReplayClosure.2 = generateAutoplayReplayClosure.1.44.20();
				}
				this.15(<<EMPTY_NAME>>, generateAutoplayReplayClosure.1.1, generateAutoplayReplayClosure.2);
				if (generateAutoplayReplayClosure.1.46 == (1983)1)
				{
					<<EMPTY_NAME>>.ForEach(delegate(1840 1)
					{
						if (1.10 > generateAutoplayReplayClosure.1.1 && 1.10 < generateAutoplayReplayClosure.1.2)
						{
							1.1 = (float)generateAutoplayReplayClosure.3.14((int)1.1, generateAutoplayReplayClosure.2);
						}
					});
					this.15(<<EMPTY_NAME>>, generateAutoplayReplayClosure.1.2 - 1, -generateAutoplayReplayClosure.2);
				}
				else
				{
					this.15(<<EMPTY_NAME>>, generateAutoplayReplayClosure.1.1 + 1, -generateAutoplayReplayClosure.2);
				}
			}
		}
		2486.88.26 = 1535.39.26;
		2486.88.23 = "osu!topus!";
	}

	// Token: 0x06003777 RID: 14199 RVA: 0x0015B9F9 File Offset: 0x00159BF9
	private int 14(int 1, int 2)
	{
		if (2 > 0)
		{
			1 = (((1 & 2) <= 0) ? (1 | 2) : (1 & ~2));
		}
		else if ((1 & -2) > 0)
		{
			1 &= ~(-2);
		}
		return 1;
	}

	// Token: 0x06003778 RID: 14200 RVA: 0x0015BA24 File Offset: 0x00159C24
	private new void 15(List<1840> 1, int 2, int 3)
	{
		1999.2000 addKeyChangeFrameClosure = new 1999.2000();
		addKeyChangeFrameClosure.1 = 2;
		int num = 4.FindLastIndex((1840 1) => 1.10 <= addKeyChangeFrameClosure.1);
		if (num < 0)
		{
			4.Add(new 1840(addKeyChangeFrameClosure.1, (float)this.14(0, 3), this.35, 1572.None));
			return;
		}
		if (addKeyChangeFrameClosure.1 == 0)
		{
			4.Insert(num + 1, new 1840(0, (float)this.14((int)4[num].1, 3), this.35, 1572.None));
			return;
		}
		if (4[num].10 == addKeyChangeFrameClosure.1)
		{
			4[num].1 = (float)this.14((int)4[num].1, 3);
			return;
		}
		4.Insert(num + 1, new 1840(addKeyChangeFrameClosure.1, (float)this.14((int)4[num].1, 3), this.35, 1572.None));
	}

	// Token: 0x06003779 RID: 14201 RVA: 0x0015BB38 File Offset: 0x00159D38
	internal new double 16()
	{
		double num = 0.05;
		double difficultyRange = this.5.GetDifficultyRange((double)1926.5(1928.DrainRate, 1272.5().3), 195.0, 160.0, 60.0);
		this.5.GetDifficultyRange((double)1926.5(1928.DrainRate, 1272.5().3), 198.0, 170.0, 80.0);
		double difficultyRange2 = this.5.GetDifficultyRange((double)1926.5(1928.DrainRate, 1272.5().3), 198.0, 180.0, 80.0);
		double difficultyRange3 = this.5.GetDifficultyRange((double)1926.5(1928.DrainRate, 1272.5().3), 8.0, 4.0, 0.0);
		int num2;
		bool flag;
		do
		{
			this.17 = 0;
			num2 = 0;
			this.6.ResetToFull();
			this.3.SetCombo(0);
			2486.88.ResetJudgements(false);
			double num3 = this.6.3();
			int num4 = this.5.34[0].1 - this.5.2;
			flag = false;
			int count = this.8.34.13.Count;
			int num5 = 0;
			for (int i = 0; i < this.5.35; i++)
			{
				2034 <<EMPTY_NAME>> = this.5.34[i];
				int num6 = num4;
				int num7 = 0;
				if (count > 0 && num5 < count)
				{
					2647 2 = this.8.34.13[num5];
					if (2.8 >= num6 && 2.1 <= <<EMPTY_NAME>>.1)
					{
						num7 = 2.GetDuration();
						num5++;
					}
				}
				this.6.Drain(num * (double)(<<EMPTY_NAME>>.1 - num4 - num7));
				num4 = <<EMPTY_NAME>>.2;
				if (this.6.3() < num3)
				{
					num3 = this.6.3();
				}
				if (this.6.3() <= difficultyRange)
				{
					flag = true;
					num *= 0.96;
					break;
				}
				double num8 = num * (double)(<<EMPTY_NAME>>.2 - <<EMPTY_NAME>>.1);
				double num9 = Math.Max(0.0, num8 - this.6.3());
				this.6.Drain(num8);
				if (<<EMPTY_NAME>> is 1978)
				{
					if (2486.88.39 != null)
					{
						this.ApplyJudgement((2149)268435456, <<EMPTY_NAME>>);
						this.17++;
					}
					else
					{
						num2 += (<<EMPTY_NAME>>.2 - <<EMPTY_NAME>>.1) / 2150.3;
					}
				}
				if (num9 > 0.0 && this.6.3() - num9 <= difficultyRange)
				{
					flag = true;
					num *= 0.96;
					break;
				}
				this.ApplyJudgement((2149)268435456, <<EMPTY_NAME>>);
				<<EMPTY_NAME>>.13 = this.6.3();
				this.17++;
			}
			if (!flag && this.6.3() < difficultyRange2)
			{
				flag = true;
				num *= 0.94;
				this.24 *= 1.01;
				this.25 *= 1.01;
			}
			double num10 = (this.6.5() - 200.0) / (double)this.5.35;
			if (!flag && num10 < difficultyRange3)
			{
				flag = true;
				num *= 0.96;
				this.24 *= 1.02;
				this.25 *= 1.01;
			}
		}
		while (flag);
		this.36 = num2;
		if (1662.84)
		{
			2485 3 = this.8 as 2485;
			if (3 != null)
			{
				3.218 = 2486.88.GetScore();
				3.217 = this.3.GetCombo() + num2;
			}
		}
		return num;
	}

	// Token: 0x04002924 RID: 10532
	private int 34;

	// Token: 0x04002925 RID: 10533
	private float 35;

	// Token: 0x04002926 RID: 10534
	internal int 36;

	// Token: 0x0200075D RID: 1885
	[Serializable]
	public sealed class 2002
	{
		// Token: 0x04002927 RID: 10535
		public static readonly 1999.2002 instance = new 1999.2002();

		// Token: 0x04002928 RID: 10536
		public static 1189 voidDelegate;
	}

	// Token: 0x0200075E RID: 1886
	public sealed class 2001
	{
		// Token: 0x04002929 RID: 10537
		public 1979 1;

		// Token: 0x0400292A RID: 10538
		public int 2;

		// Token: 0x0400292B RID: 10539
		public 1999 3;
	}

	// Token: 0x0200075F RID: 1887
	public sealed class 2000
	{
		// Token: 0x0400292C RID: 10540
		public int 1;
	}
}
