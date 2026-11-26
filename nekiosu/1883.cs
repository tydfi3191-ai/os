using System;
using System.Collections.Generic;

// Token: 0x020007B5 RID: 1973
public sealed class 1883 : 2504
{
	// Token: 0x0600398A RID: 14730 RVA: 0x0016ADBC File Offset: 0x00168FBC
	internal 1883(2486 1) : base(1)
	{
	}

	// Token: 0x0600398B RID: 14731 RVA: 0x0016ADE6 File Offset: 0x00168FE6
	internal override 208 GetScoreboardPosition()
	{
		return new 208(0f, 100f);
	}

	// Token: 0x0600398C RID: 14732 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool ShouldShowBeatmapMessages()
	{
		return true;
	}

	// Token: 0x0600398D RID: 14733 RVA: 0x0016ADF7 File Offset: 0x00168FF7
	internal override 208 GetReplayCursorPosition()
	{
		if (this.36 != null)
		{
			return new 208(this.36.17.X, 9999f);
		}
		return base.GetReplayCursorPosition();
	}

	// Token: 0x0600398E RID: 14734 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool ShouldShowScoreboard()
	{
		return true;
	}

	// Token: 0x0600398F RID: 14735 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool AllowsScoreSubmission()
	{
		return true;
	}

	// Token: 0x06003990 RID: 14736 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool CanResumeWithoutCursorClick()
	{
		return true;
	}

	// Token: 0x06003991 RID: 14737 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal override bool Method5894()
	{
		return false;
	}

	// Token: 0x06003992 RID: 14738 RVA: 0x0013D0D7 File Offset: 0x0013B2D7
	internal override bool ShouldHideCursor()
	{
		return 2486.14 || base.ShouldHideCursor() || 1535.1();
	}

	// Token: 0x06003993 RID: 14739 RVA: 0x0016AE24 File Offset: 0x00169024
	internal override bool AreAllObjectsJudged()
	{
		return this.4.GetJudgementCount() == this.5.34.FindAll((2034 1) => !(1 is 1860)).Count;
	}

	// Token: 0x06003994 RID: 14740 RVA: 0x0016AE72 File Offset: 0x00169072
	internal override bool CapturesCursor()
	{
		return 2486.21 || base.CapturesCursor();
	}

	// Token: 0x06003995 RID: 14741 RVA: 0x0016AE84 File Offset: 0x00169084
	internal override void InitializeHealthDrain()
	{
		this.17 = this.5.35;
		2023 <<EMPTY_NAME>> = this.4.8;
		2023 2 = 2023.HalfTime;
		float num;
		if ((<<EMPTY_NAME>> & 2) <= 2023.None)
		{
			2023 3 = this.4.8;
			2 = 2023.DoubleTime;
			num = (((3 & 2) > 2023.None) ? ((float)1939.19(2023.DoubleTime)) : 1f);
		}
		else
		{
			num = (float)1939.19(2023.HalfTime);
		}
		this.44 = num;
		this.6.12 = this.21();
		2023 4 = 2486.88.8;
		2 = 2023.HalfTime;
		if ((4 & 2) > 2023.None)
		{
			this.6.12 *= 1939.19(2023.HalfTime);
		}
		this.13();
		base.InitializeHealthDrain();
	}

	// Token: 0x06003996 RID: 14742 RVA: 0x0016AF4D File Offset: 0x0016914D
	protected override void CreateScoreMeter()
	{
		if (1304.166 != 2151.None)
		{
			this.11 = new 2546(1662.11, this.5);
		}
	}

	// Token: 0x06003997 RID: 14743 RVA: 0x0016AF71 File Offset: 0x00169171
	private new void 13()
	{
		(this.5 as 1875).81(this.37);
	}

	// Token: 0x06003998 RID: 14744 RVA: 0x0016AF89 File Offset: 0x00169189
	internal override void OnReplayObjectsRebuilt()
	{
		this.13();
		this.15();
		this.49 = null;
		this.34.Clear();
	}

	// Token: 0x06003999 RID: 14745 RVA: 0x0016AFA9 File Offset: 0x001691A9
	internal override void UpdateHealthDrain()
	{
		if (this.8.89)
		{
			this.6.Drain(this.6.12 * (double)(1226.16 - 1226.18));
		}
		base.UpdateHealthDrain();
	}

	// Token: 0x0600399A RID: 14746 RVA: 0x0016AFE4 File Offset: 0x001691E4
	internal override void OnJudgementApplied(2149 1, double 2, bool 3, 2034 4)
	{
		if (4 == this.49)
		{
			this.15();
			this.49 = null;
		}
		if (1 != (2149)16 && 2 > 0.0)
		{
			this.15();
			this.14(4 as 1866);
			1567.4(2486.103 ? 64 : 32);
			this.6.PulseMarker();
			if (this.6.3() > 180.0)
			{
				this.6.AddMarkerBurst();
			}
		}
	}

	// Token: 0x0600399B RID: 14747 RVA: 0x0016B06C File Offset: 0x0016926C
	private void 14(1866 1)
	{
		if (1.9())
		{
			2034 2 = 1.48;
			float num = Math.Abs(2.8.X - this.36.17.X);
			float num2 = Math.Max(1f, (float)(2.1 - 1226.16) - 16.666666f);
			this.17();
			this.45 = num / num2;
			this.46 = ((2.8.X > this.36.17.X) ? 1 : -1);
			this.49 = 1.48;
		}
	}

	// Token: 0x0600399C RID: 14748 RVA: 0x0016B10D File Offset: 0x0016930D
	private new void 15()
	{
		this.45 = 1f;
		this.46 = 0;
		this.50 = false;
	}

	// Token: 0x0600399D RID: 14749 RVA: 0x0016B128 File Offset: 0x00169328
	internal override void CreateModSprites()
	{
		if (2630.5.Version < 2.3)
		{
			this.41 = (this.42 = (this.43 = 1455.5("fruit-ryuuta", (1416)7, true)));
		}
		if (this.41 == null)
		{
			this.41 = 1455.5("fruit-catcher-idle", (1416)7, true);
			this.42 = 1455.5("fruit-catcher-fail", (1416)7, true);
			this.43 = 1455.5("fruit-catcher-kiai", (1416)7, true);
		}
		this.36 = new 1351(this.41, (1376)1, 1065.Custom, (1044)0, new 208(256f, 340f), 0.81f, true, 198.White);
		this.36.61();
		this.36.48 = new 208((float)(this.36.35 / 2), 16f);
		this.36.15 = 0.7f;
		this.52 = this.36.17.X;
		this.5.39.12(this.36);
		this.37 = 305f / 1662.69.9() * this.5.23 * 0.7f;
		this.38 = this.37 / 2f;
		this.39 = this.37 * 0.1f;
		if (1304.74)
		{
			if (2630.5.Version >= 2.3)
			{
				this.19 = 1455.5("comboburst-fruits", (1416)7, true);
			}
			if (this.19 == null)
			{
				this.19 = 1455.5("comboburst", (1416)7, true);
			}
		}
		base.CreateModSprites();
	}

	// Token: 0x0600399E RID: 14750 RVA: 0x0016B2E8 File Offset: 0x001694E8
	internal override void UpdateModeInputEffects()
	{
		if (!this.7 || 2486.13)
		{
			return;
		}
		int num = 0;
		if (!1535.1())
		{
			1535.15 |= 1549.10(1548.8(1532.FruitsDash));
			1535.15 |= 1546.3(1548.8(1532.FruitsDash));
			1535.16 |= 1535.15;
			if (1535.16)
			{
				1535.14 = 199.Pressed;
			}
		}
		this.51 = (1535.14 == 199.Pressed);
		if (this.51)
		{
			num += 4;
		}
		float num2 = this.44 * this.45;
		if (!this.51)
		{
			num2 /= 2f;
		}
		if (1535.1() || 2486.21)
		{
			float x = 1535.34.X;
			if (1535.38)
			{
				this.53 = (this.36.17.X > x);
				this.54 = (this.36.17.X < x);
			}
			if (this.36.17.X != x)
			{
				this.36.45(this.36.17.X > x);
				this.36.17.X = x;
			}
		}
		else
		{
			if (1662.82 > 33.0)
			{
				return;
			}
			if (Math.Abs(this.36.17.X - this.52) > 0.01f)
			{
				this.36.17.X = this.52;
				this.4.18();
			}
			if (this.54 = (1549.10(1548.8(1532.FruitsRight)) || 1546.3(1548.8(1532.FruitsRight))))
			{
				num++;
				this.36.17.X = (float)((double)this.36.17.X + (double)num2 * 1662.82);
				this.36.45(false);
			}
			if (this.53 = (1549.10(1548.8(1532.FruitsLeft)) || 1546.3(1548.8(1532.FruitsLeft))))
			{
				num += 2;
				this.36.17.X = (float)((double)this.36.17.X - (double)num2 * 1662.82);
				this.36.45(true);
			}
		}
		this.16();
		this.47 = (num != this.48);
		this.48 = num;
		this.36.17.X = 1052.19(this.36.17.X, 0f, 512f);
		this.52.2(this.36.17.X);
	}

	// Token: 0x0600399F RID: 14751 RVA: 0x0016B5C0 File Offset: 0x001697C0
	private new void 16()
	{
		if (this.55 != (this.45 != 1f))
		{
			2023 <<EMPTY_NAME>> = 2023.Cinema;
			2023 2 = 2019.1;
			2023 3 = <<EMPTY_NAME>>;
			if ((2 & 3) <= 2023.None)
			{
				this.55 = (this.45 != 1f);
				this.36.39(this.55 ? 2630.6().ColourHyperDash : 198.White, 100, false, (1046)0);
				if (this.8.34.4 != null && this.8.34.4.7 != null)
				{
					this.8.34.4.7.39(this.55 ? new 198(100, 100, 100) : 198.White, 100, false, (1046)0);
				}
			}
		}
		if (this.45 != 1f && this.49 != null && ((this.46 > 0 && this.36.17.X >= this.49.8.X) || (this.46 < 0 && this.36.17.X <= this.49.8.X)))
		{
			this.36.17.X = this.49.8.X;
			this.15();
			this.50 = true;
			this.17();
		}
	}

	// Token: 0x060039A0 RID: 14752 RVA: 0x0016B744 File Offset: 0x00169944
	private new void 17()
	{
		1433 <<EMPTY_NAME>> = new 1433(this.36.GetTexture(), (1376)1, 1065.Centre, (1044)0, this.36.17 + new 208(0f, (float)this.36.34 * 0.18f), 0.84f, false, 2630.6().14(), null);
		<<EMPTY_NAME>>.45(this.36.44());
		<<EMPTY_NAME>>.28 = true;
		<<EMPTY_NAME>>.15 = 0.71f;
		<<EMPTY_NAME>>.16(1200, (1046)0, 0);
		<<EMPTY_NAME>>.3.Add(new 1445(1456.Scale, <<EMPTY_NAME>>.15, <<EMPTY_NAME>>.15 * 1.2f, 1662.33, 1662.33 + 1200, (1046)2));
		this.5.39.12(<<EMPTY_NAME>>);
	}

	// Token: 0x060039A1 RID: 14753 RVA: 0x0016B817 File Offset: 0x00169A17
	internal override bool ShouldProcessHitInput()
	{
		return this.47;
	}

	// Token: 0x060039A2 RID: 14754 RVA: 0x0016B820 File Offset: 0x00169A20
	internal override void JudgeCurrentObject()
	{
		if (2486.4)
		{
			return;
		}
		foreach (2034 <<EMPTY_NAME>> in this.5.36)
		{
			1883.1884 judgeCurrentObjectClosure = new 1883.1884();
			judgeCurrentObjectClosure.1 = (<<EMPTY_NAME>> as 1866);
			if (judgeCurrentObjectClosure.1 != null && 1226.16 >= judgeCurrentObjectClosure.1.1 && !judgeCurrentObjectClosure.1.11)
			{
				if (this.36.17.X - this.38 + this.39 < judgeCurrentObjectClosure.1.8.X && this.36.17.X + this.38 - this.39 > judgeCurrentObjectClosure.1.8.X)
				{
					2486.7.48(judgeCurrentObjectClosure.1, new int?((int)(this.36.17.X - judgeCurrentObjectClosure.1.8.X)));
					judgeCurrentObjectClosure.1.46 = true;
				}
				else
				{
					judgeCurrentObjectClosure.1.46 = false;
				}
				this.5.JudgeHitObject(judgeCurrentObjectClosure.1);
				if (judgeCurrentObjectClosure.1.46)
				{
					this.36.55((judgeCurrentObjectClosure.1 is 1860 || (1226.63() && !1304.54.1())) ? this.43 : this.41);
					this.40.5(judgeCurrentObjectClosure.1.7);
					foreach (1433 2 in judgeCurrentObjectClosure.1.30)
					{
						2.3.RemoveAll(new Predicate<1445>(1883.1885.instance.1));
						2.15 *= 0.5f;
					}
					judgeCurrentObjectClosure.1.47.X = judgeCurrentObjectClosure.1.8.X - this.36.17.X;
					judgeCurrentObjectClosure.1.47.Y = -5f;
					while (this.34.Find((1866 1) => 208.DistanceSquared(1.47, judgeCurrentObjectClosure.1.47) < 100f) != null)
					{
						1866 3 = judgeCurrentObjectClosure.1;
						3.47.X = 3.47.X + (float)1196.2(-5, 5);
						1866 4 = judgeCurrentObjectClosure.1;
						4.47.Y = 4.47.Y - (float)1196.2(0, 5);
					}
					if (judgeCurrentObjectClosure.1 is 1863)
					{
						this.18(judgeCurrentObjectClosure.1);
						this.20(judgeCurrentObjectClosure.1, false);
					}
					else if (judgeCurrentObjectClosure.1 is 1872)
					{
						this.20(judgeCurrentObjectClosure.1, false);
					}
					else
					{
						this.18(judgeCurrentObjectClosure.1);
						this.34.Add(judgeCurrentObjectClosure.1);
						foreach (1433 5 in judgeCurrentObjectClosure.1.30)
						{
							5.5 = true;
						}
					}
					this.19(true);
				}
				else
				{
					if (!(judgeCurrentObjectClosure.1 is 1860))
					{
						this.36.55(this.42);
					}
					foreach (1433 6 in judgeCurrentObjectClosure.1.30)
					{
						6.3.Add(new 1445(1456.Rotation, 0f, 2f, 1226.16, 1226.16 + 500, (1046)0));
					}
					this.19(false);
				}
			}
		}
		base.JudgeCurrentObject();
	}

	// Token: 0x060039A3 RID: 14755 RVA: 0x0016BD08 File Offset: 0x00169F08
	internal override void UpdateModeState()
	{
		this.34.ForEach(new Action<1866>(this.22));
		this.35.ForEach(new Action<1433>(this.23));
		this.35.RemoveAll(new Predicate<1433>(1883.1885.instance.2));
		if (this.51 && 1662.33 - this.57 > 16)
		{
			1433 <<EMPTY_NAME>> = new 1433(this.36.GetTexture(), (1376)1, 1065.TopCentre, (1044)0, this.36.17, 0.84f, false, this.36.6, null);
			<<EMPTY_NAME>>.16 = 0.5f;
			<<EMPTY_NAME>>.45(this.36.44());
			<<EMPTY_NAME>>.28 = true;
			1433 2 = <<EMPTY_NAME>>;
			2.48.Y = 2.48.Y + 16f;
			<<EMPTY_NAME>>.15 = 0.71f;
			<<EMPTY_NAME>>.16((this.36.17.X != this.56.X) ? 250 : 100, (1046)0, 0);
			this.5.39.12(<<EMPTY_NAME>>);
			this.56 = this.36.17;
			this.57 = 1662.33;
		}
		if (this.36.54() != this.42)
		{
			this.36.55((1226.63() && !1304.54.1()) ? this.43 : this.41);
		}
	}

	// Token: 0x060039A4 RID: 14756 RVA: 0x0016BE8C File Offset: 0x0016A08C
	private new void 18(2034 1)
	{
		2023 2 = 2023.Cinema;
		2023 3 = 2019.1;
		2023 4 = 2;
		if ((3 & 4) <= 2023.None)
		{
			float 5 = 1052.19(((1866)1).47.X, 0f - this.38 + this.39 * 3f, this.38 - this.39 * 3f);
			if (!(1 is 1863))
			{
				float num = 1052.19((float)this.3.GetCombo() / 200f, 0.35f, 1.125f);
				1433 6 = new 1433(1455.2("scoreboard-explosion-2", (1416)1, null), (1376)1, 1065.CentreLeft, (1044)0, 1.8, 0.99f, false, 1.7, null);
				6.28 = true;
				6.14 = -1.5707964f;
				6.16(300, (1046)0, 0);
				6.3.Add(new 1445(1456.VectorScale, new 208(1f, 0.9f), new 208(16f * num, 1.1f), 1662.33, 1662.33 + 160, (1046)1));
				this.15.12(6);
				6.19 = true;
				6.7 = new 208(5, 0f);
				this.35.Add(6);
			}
			1433 7 = new 1433(1455.2("scoreboard-explosion-1", (1416)1, null), (1376)1, 1065.CentreLeft, (1044)0, 1.8, 1f, false, 1.7, null);
			7.14 = -1.5707964f;
			this.15.12(7);
			7.28 = true;
			7.16(700, (1046)0, 0);
			7.3.Add(new 1445(1456.VectorScale, new 208(0.9f, 1f), new 208(0.9f, 1.3f), 1662.33, 1662.33 + 500, (1046)1));
			7.19 = true;
			7.7 = new 208(5, 0f);
			this.35.Add(7);
		}
	}

	// Token: 0x060039A5 RID: 14757 RVA: 0x0016C0A0 File Offset: 0x0016A2A0
	private new void 19(bool 1)
	{
		if (!this.5.34[this.5.31].10)
		{
			return;
		}
		if (this.5.38 is 1860)
		{
			foreach (1866 2 in this.34)
			{
				this.20(2, true);
			}
			((1860)this.5.38).11();
			1433 3 = new 1433(1455.2("scoreboard-explosion-1", (1416)1, null), (1376)1, 1065.CentreLeft, (1044)0, 208.Zero, 0.99f, false, 198.White, null);
			3.28 = true;
			3.14 = -1.5707964f;
			3.16(800, (1046)0, 0);
			3.3.Add(new 1445(1456.VectorScale, new 208(0f, 1.8f), new 208(4f, 2.2f), 1662.33, 1662.33 + 500, (1046)1));
			3.19 = true;
			this.35.Add(3);
			this.15.12(3);
		}
		else
		{
			if (1)
			{
				using (List<1866>.Enumerator enumerator = this.34.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						1866 4 = enumerator.Current;
						this.20(4, false);
					}
					goto IL_1FA;
				}
			}
			foreach (1866 5 in this.34)
			{
				foreach (1433 6 in 5.30)
				{
					1662.44.2(6, null, false);
					6.16(1000, (1046)0, 0);
					6.5 = false;
				}
			}
		}
		IL_1FA:
		this.34.Clear();
	}

	// Token: 0x060039A6 RID: 14758 RVA: 0x0016C2E8 File Offset: 0x0016A4E8
	private new void 20(1866 1, bool 2)
	{
		208 value = new 208(1.47.X * 4f, (float)(2 ? -400 : -120));
		foreach (1433 3 in 1.30)
		{
			3.5 = false;
			3.16(2000, (1046)0, 0);
			1662.44.2(3, new 208?(value), false);
		}
	}

	// Token: 0x060039A7 RID: 14759 RVA: 0x0016C380 File Offset: 0x0016A580
	internal override void UpdateComboDisplay()
	{
		this.40.4(1662.69.15(this.36.17.X) / 1662.70.3());
	}

	// Token: 0x060039A8 RID: 14760 RVA: 0x0016C3B2 File Offset: 0x0016A5B2
	internal override 2039 CreateHitObjectManager()
	{
		return new 1875(true);
	}

	// Token: 0x060039A9 RID: 14761 RVA: 0x0016C3BA File Offset: 0x0016A5BA
	internal override void CreateComboCounter()
	{
		this.40 = new 1882(this.2);
		this.3 = this.40;
	}

	// Token: 0x060039AA RID: 14762 RVA: 0x0016C3DC File Offset: 0x0016A5DC
	internal override void UpdateFlashlight()
	{
		if (this.20.GetTexture() == null || this.16.28.Count == 0 || !this.20.GetTexture().gpuTexture.HasContent())
		{
			return;
		}
		this.20.17 = 1662.69.17(this.36.17) / 1662.70.3();
		if (2486.13)
		{
			return;
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
			num = ((this.3.GetCombo() < 100) ? 5.2f : ((this.3.GetCombo() >= 200) ? 4f : 4.6f));
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

	// Token: 0x060039AB RID: 14763 RVA: 0x00145DA8 File Offset: 0x00143FA8
	internal override void ApplyJudgement(2149 1, 2034 2)
	{
		if (2.10 && 2.11 && 1 != (2149)0)
		{
			this.8.9(1);
		}
		base.ApplyJudgement(1, 2);
	}

	// Token: 0x060039AC RID: 14764 RVA: 0x0016C56C File Offset: 0x0016A76C
	internal override void GenerateAutoplayReplay()
	{
		1535.39.26 = new List<1840>();
		List<1840> <<EMPTY_NAME>> = 1535.39.26;
		<<EMPTY_NAME>>.Add(new 1840(-100000, 256f, 490f, 1572.None));
		float num = this.44 * 0.5f;
		float num2 = this.44;
		float num3 = 256f;
		int num4 = 0;
		for (int i = 0; i < this.5.35; i++)
		{
			2034 2 = this.5.34[i];
			if (2.2 < 1535.41)
			{
				2.11 = true;
			}
			else
			{
				float num5 = Math.Abs(num3 - 2.8.X);
				int num6 = 2.1 - num4;
				float num7 = num5 / (float)num6;
				bool flag = num7 > num && 2.1 != 0;
				bool flag2 = num7 > num2 && 2.1 != 0;
				if (num3 - this.38 + this.39 < 2.8.X && num3 + this.38 - this.39 > 2.8.X)
				{
					num4 = 2.2;
					<<EMPTY_NAME>>.Add(new 1840(2.1, num3, 490f, 1572.None));
				}
				else
				{
					if (2 is 1860)
					{
						<<EMPTY_NAME>>.Add(new 1840(2.1, 2.8.X, 490f, 1572.Left1));
					}
					else if (flag2)
					{
						<<EMPTY_NAME>>.Add(new 1840(2.1 - num6 + 1, num3, 490f, 1572.Left1));
						<<EMPTY_NAME>>.Add(new 1840(2.1, 2.8.X, 490f, 1572.None));
					}
					else if (flag)
					{
						int num8 = ((int)(num5 / num) - num6) / 2;
						float 3 = 1052.16(num3, 2.8.X, (float)num8 / (float)num6);
						<<EMPTY_NAME>>.Add(new 1840(2.1 - num6 + 1, num3, 490f, 1572.Left1));
						<<EMPTY_NAME>>.Add(new 1840(2.1 - num6 + num8, 3, 490f, 1572.None));
						<<EMPTY_NAME>>.Add(new 1840(2.1, 2.8.X, 490f, 1572.None));
					}
					else
					{
						int num9 = (int)(num5 / num);
						<<EMPTY_NAME>>.Add(new 1840(2.1 - num9, num3, 490f, 1572.Right1));
						<<EMPTY_NAME>>.Add(new 1840(2.1, 2.8.X, 490f, 1572.None));
					}
					num4 = 2.2;
					num3 = 2.8.X;
				}
			}
		}
		2486.88.26 = 1535.39.26;
		2486.88.23 = "salad!";
	}

	// Token: 0x060039AD RID: 14765 RVA: 0x0016C858 File Offset: 0x0016AA58
	internal double 21()
	{
		double num = 0.05;
		double difficultyRange = this.5.GetDifficultyRange((double)1926.5(1928.DrainRate, 1272.5().3), 195.0, 160.0, 60.0);
		double difficultyRange2 = this.5.GetDifficultyRange((double)1926.5(1928.DrainRate, 1272.5().3), 198.0, 170.0, 80.0);
		double difficultyRange3 = this.5.GetDifficultyRange((double)1926.5(1928.DrainRate, 1272.5().3), 198.0, 180.0, 80.0);
		double difficultyRange4 = this.5.GetDifficultyRange((double)1926.5(1928.DrainRate, 1272.5().3), 8.0, 4.0, 0.0);
		bool flag;
		do
		{
			this.17 = 0;
			this.6.ResetToFull();
			this.3.SetCombo(0);
			2486.88.ResetJudgements(false);
			double num2 = this.6.3();
			int num3 = this.5.34[0].1 - this.5.2;
			flag = false;
			int num4 = 0;
			int count = this.8.34.13.Count;
			int num5 = 0;
			for (int i = 0; i < this.5.35; i++)
			{
				2034 <<EMPTY_NAME>> = this.5.34[i];
				int num6 = num3;
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
				this.6.Drain(num * (double)(<<EMPTY_NAME>>.1 - num3 - num7));
				num3 = <<EMPTY_NAME>>.2;
				if (this.6.3() < num2)
				{
					num2 = this.6.3();
				}
				if (this.6.3() <= difficultyRange)
				{
					flag = true;
					num *= 0.96;
					break;
				}
				if (<<EMPTY_NAME>> is 1863)
				{
					this.ApplyJudgement((2149)2048, <<EMPTY_NAME>>);
				}
				else if (<<EMPTY_NAME>> is 1872)
				{
					this.ApplyJudgement((2149)16, <<EMPTY_NAME>>);
				}
				else if (<<EMPTY_NAME>> is 1860)
				{
					this.6.AddHealth(this.25 / 2.0);
				}
				else if (i == this.5.35 - 1 || this.5.34[i + 1].IsNewCombo())
				{
					this.ApplyJudgement((2149)1028, <<EMPTY_NAME>>);
					if (this.6.3() < difficultyRange2 && ++num4 > 2)
					{
						this.24 *= 1.07;
						this.25 *= 1.03;
						flag = true;
						break;
					}
				}
				else
				{
					this.ApplyJudgement((2149)1024, <<EMPTY_NAME>>);
				}
				if (!(<<EMPTY_NAME>> is 1872) && !(<<EMPTY_NAME>> is 1860))
				{
					this.17++;
				}
				<<EMPTY_NAME>>.13 = this.6.3();
			}
			if (!flag && this.6.3() < difficultyRange3)
			{
				flag = true;
				num *= 0.94;
				this.24 *= 1.01;
				this.25 *= 1.01;
			}
			double num8 = (this.6.5() - 200.0) / (double)this.5.35;
			if (!flag && num8 < difficultyRange4)
			{
				flag = true;
				num *= 0.96;
				this.24 *= 1.02;
				this.25 *= 1.01;
			}
		}
		while (flag);
		if (1662.84)
		{
			2485 3 = this.8 as 2485;
			if (3 != null)
			{
				3.218 = 2486.88.GetScore();
				3.217 = this.3.GetCombo();
			}
		}
		return num;
	}

	// Token: 0x060039AE RID: 14766 RVA: 0x0016CCCB File Offset: 0x0016AECB
	private new void 22(1866 1)
	{
		1.SetPosition(this.36.17 + 1.47, false);
	}

	// Token: 0x060039AF RID: 14767 RVA: 0x0016CCEA File Offset: 0x0016AEEA
	private void 23(1433 1)
	{
		1.17 = this.36.17 + 1.7;
	}

	// Token: 0x04002A9D RID: 10909
	private readonly List<1866> 34 = new List<1866>();

	// Token: 0x04002A9E RID: 10910
	private readonly List<1433> 35 = new List<1433>();

	// Token: 0x04002A9F RID: 10911
	private 1351 36;

	// Token: 0x04002AA0 RID: 10912
	private float 37;

	// Token: 0x04002AA1 RID: 10913
	internal float 38;

	// Token: 0x04002AA2 RID: 10914
	private float 39;

	// Token: 0x04002AA3 RID: 10915
	private 1882 40;

	// Token: 0x04002AA4 RID: 10916
	private 1381[] 41;

	// Token: 0x04002AA5 RID: 10917
	private 1381[] 42;

	// Token: 0x04002AA6 RID: 10918
	private 1381[] 43;

	// Token: 0x04002AA7 RID: 10919
	internal float 44;

	// Token: 0x04002AA8 RID: 10920
	private float 45 = 1f;

	// Token: 0x04002AA9 RID: 10921
	private int 46;

	// Token: 0x04002AAA RID: 10922
	private bool 47;

	// Token: 0x04002AAB RID: 10923
	private int 48;

	// Token: 0x04002AAC RID: 10924
	private 2034 49;

	// Token: 0x04002AAD RID: 10925
	private bool 50;

	// Token: 0x04002AAE RID: 10926
	internal bool 51;

	// Token: 0x04002AAF RID: 10927
	private 2685<float> 52;

	// Token: 0x04002AB0 RID: 10928
	internal bool 53;

	// Token: 0x04002AB1 RID: 10929
	internal bool 54;

	// Token: 0x04002AB2 RID: 10930
	private bool 55;

	// Token: 0x04002AB3 RID: 10931
	private 208 56;

	// Token: 0x04002AB4 RID: 10932
	private int 57;

	// Token: 0x020007B6 RID: 1974
	[Serializable]
	public sealed class 1885
	{
		// Token: 0x060039B0 RID: 14768 RVA: 0x0016CD08 File Offset: 0x0016AF08
		internal bool 1(1445 1)
		{
			return 1.14 == 1456.Movement || 1.14 == 1456.Scale;
		}

		// Token: 0x060039B1 RID: 14769 RVA: 0x0016CD1E File Offset: 0x0016AF1E
		internal bool 2(1433 1)
		{
			return !1.19;
		}

		// Token: 0x04002AB5 RID: 10933
		public static readonly 1883.1885 instance = new 1883.1885();

		// Token: 0x04002AB6 RID: 10934
		public static Predicate<2034> predicate;

		// Token: 0x04002AB7 RID: 10935
		public static Predicate<1445> predicate2;

		// Token: 0x04002AB8 RID: 10936
		public static Predicate<1433> predicate3;
	}

	// Token: 0x020007B7 RID: 1975
	public sealed class 1884
	{
		// Token: 0x04002AB9 RID: 10937
		public 1866 1;
	}
}
