using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x020004C7 RID: 1223
[276]
public class 2486 : 2462
{
	// Token: 0x06002515 RID: 9493 RVA: 0x000ABF2C File Offset: 0x000AA12C
	protected virtual void PrepareBreakIndicators()
	{
		this.61 = new Queue<int>();
		if (this.58.ShouldShowBreakSections() && this.34.13.Count > 0)
		{
			this.60 = new 1433(1455.2("section-pass", (1416)7, null), (1376)10, 1065.Centre, (1044)1, global::208.Zero, 1f, true, global::198.TransparentWhite, null);
			this.59 = new 1433(1455.2("section-fail", (1416)7, null), (1376)10, 1065.Centre, (1044)1, global::208.Zero, 1f, true, global::198.TransparentWhite, null);
			this.71.12(this.60);
			this.71.12(this.59);
		}
		foreach (2275 <<EMPTY_NAME>> in this.34.13)
		{
			if (this.58.ShouldShowBreakSections())
			{
				int num = Math.Min(2, this.39.2 / 200);
				int num2 = Math.Min(5, (<<EMPTY_NAME>>.GetDuration() + 200) / 200) + num;
				int 2 = <<EMPTY_NAME>>.1 - 200 * (num2 - num);
				this.57(num2, 2);
			}
			if (<<EMPTY_NAME>>.1 > 1226.16 && <<EMPTY_NAME>>.8 > this.39.34[0].1)
			{
				this.61.Enqueue(this.39.34[this.39.73(<<EMPTY_NAME>>)].2);
			}
		}
		this.71.14<1433>(this.25);
	}

	// Token: 0x06002516 RID: 9494 RVA: 0x000AC0F0 File Offset: 0x000AA2F0
	internal void 1(bool 1)
	{
		if (this.104 != 1)
		{
			this.104 = 1;
			this.39.39.7 = (1 ? 0.5f : 0f);
			this.39.39.8 = (1 ? 0.65f : 0f);
			this.39.LoadComboColours(1);
			2630.12(this.39);
			2039.36();
			2050 2 = this.39.56;
			if (2 == null)
			{
				return;
			}
			2.Refresh();
		}
	}

	// Token: 0x06002517 RID: 9495 RVA: 0x000AC17C File Offset: 0x000AA37C
	public void 2()
	{
		if (this.58.6 != null && this.58.6.3() <= 0.0)
		{
			2023 <<EMPTY_NAME>> = 2486.88.8;
			2023 2 = 2023.NoFail;
			if ((<<EMPTY_NAME>> & 2) <= 2023.None && !2486.88.47 && (!2486.21 || 1304.32.1()) && !2486.22 && (!1535.1() || 1535.42) && !1662.84 && (2486.14() != 2147.Taiko || 1226.16 > this.39.34[0].2))
			{
				this.HandleFailure();
			}
		}
	}

	// Token: 0x06002518 RID: 9496 RVA: 0x000AC230 File Offset: 0x000AA430
	private new bool 3()
	{
		return this.61.Count == 0 || 1226.16 <= this.61.Peek() || this.139.32 < 8;
	}

	// Token: 0x06002519 RID: 9497 RVA: 0x000AC264 File Offset: 0x000AA464
	private void 4()
	{
		if (2648.6)
		{
			this.56 = 1226.16;
			if (1662.23)
			{
				int num = this.31;
				this.31 = num + 1;
				if (num > 1)
				{
					this.31 = 0;
					this.45(null);
				}
			}
			if (this.61.Count > 0)
			{
				while (this.61.Peek() < 1226.16)
				{
					this.61.Dequeue();
					if (this.61.Count == 0)
					{
						break;
					}
				}
			}
		}
		if (this.56 >= 0 && this.39.36.FindIndex((2034 1) => 1.1 <= 1226.16 && 1.1 >= this.56) >= 0)
		{
			this.56 = -1;
		}
	}

	// Token: 0x0600251A RID: 9498 RVA: 0x000AC320 File Offset: 0x000AA520
	private void 5()
	{
		if (1226.30 <= 101f)
		{
			if (1662.76 == (932)2)
			{
				this.EnterFailurePause();
			}
			return;
		}
		if (!1662.23)
		{
			return;
		}
		1025.BASS_ChannelSetAttribute(1226.31.2(), (994)1, 1226.30 * 1226.31.GetPitchFactor());
		if (this.39.39.5 > 0f)
		{
			this.39.39.5 = Math.Max(0f, this.39.39.5 - 0.007f);
		}
		this.58.SetPlayfieldOpacity(this.39.39.5);
		foreach (2034 <<EMPTY_NAME>> in this.39.36)
		{
			foreach (1433 2 in <<EMPTY_NAME>>.30)
			{
				2.3.RemoveAll((1445 1) => 1.14 == 1456.Movement);
				2.5 = true;
				2.17 = new 208(2.17.X, (2.17.Y < 0f) ? (2.17.Y * 0.6f) : (2.17.Y * 1.01f));
				if (2.14 == 0f)
				{
					2.14 += 1196.7(-0.02f, 0.02f);
				}
				else if (2.14 > 0f)
				{
					2.14 += 0.01f;
				}
				else
				{
					2.14 -= 0.01f;
				}
			}
		}
		1226.30 -= 300f;
	}

	// Token: 0x0600251B RID: 9499 RVA: 0x000AC564 File Offset: 0x000AA764
	protected internal void 6()
	{
		if (!this.46 && !this.89 && !2486.16 && !this.IsPracticeLooping && ((1226.16 > 0 && 1226.32 == (1042)0 && !this.191 && !this.156) || 1226.16 > (this.PracticeObjectsEnd ?? this.84) + 200))
		{
			2486.88.29.Add(this.58.IsSectionPassing());
			this.11(2486.88.29.FindAll(new Predicate<bool>(2486.2489.Instance.14)).Count > 2486.88.29.FindAll((bool 1) => !1).Count);
			if (1535.1() || 1662.84 || 2486.88.47 || !this.ValidateCompletionObjectCounts() || this.58.AreAllObjectsJudged())
			{
				this.CompleteGameplay();
				return;
			}
			2486.88.18();
			1763.4(1568.1(2679.Player_ErrorDuringScoreCalculation));
			this.CompleteGameplay();
		}
	}

	// Token: 0x0600251C RID: 9500 RVA: 0x000AC6B8 File Offset: 0x000AA8B8
	protected virtual void CompleteGameplay()
	{
		this.71.20<1433>(this.25);
		this.58.FinalizeScore();
	}

	// Token: 0x0600251D RID: 9501 RVA: 0x0001702D File Offset: 0x0001522D
	protected virtual bool ValidateCompletionObjectCounts()
	{
		return true;
	}

	// Token: 0x0600251E RID: 9502 RVA: 0x000AC6D8 File Offset: 0x000AA8D8
	private void 7()
	{
		if (!this.17 && this.58.ShouldShowBreakSections())
		{
			2486.88.29.Add(2486.12);
			int duration = 2648.5.GetDuration();
			int num = (duration / 2 > 2880) ? (2648.5.8 + duration / 2) : (2648.5.1 - 2880);
			if (2486.12)
			{
				1226.15.2(new 1255(num + 20, 1226.48("sectionpass", false, true, (1416)7), 100, false));
				this.60.3.Add(new 1445(1456.Fade, 0f, 1f, num + 20, num + 20, (1046)0));
				this.60.3.Add(new 1445(1456.Fade, 1f, 0f, num + 100, num + 100, (1046)0));
				this.60.3.Add(new 1445(1456.Fade, 0f, 1f, num + 160, num + 160, (1046)0));
				this.60.3.Add(new 1445(1456.Fade, 1f, 0f, num + 230, num + 230, (1046)0));
				this.60.3.Add(new 1445(1456.Fade, 0f, 1f, num + 280, num + 280, (1046)0));
				this.60.3.Add(new 1445(1456.Fade, 1f, 0f, num + 1280, num + 1480, (1046)0));
				return;
			}
			1226.15.2(new 1255(num + 130, 1226.48("sectionfail", false, true, (1416)7), 100, false));
			this.59.3.Add(new 1445(1456.Fade, 0f, 1f, num + 130, num + 130, (1046)0));
			this.59.3.Add(new 1445(1456.Fade, 1f, 0f, num + 230, num + 230, (1046)0));
			this.59.3.Add(new 1445(1456.Fade, 0f, 1f, num + 280, num + 280, (1046)0));
			this.59.3.Add(new 1445(1456.Fade, 1f, 0f, num + 1280, num + 1480, (1046)0));
		}
	}

	// Token: 0x0600251F RID: 9503 RVA: 0x000AC968 File Offset: 0x000AAB68
	private void 8()
	{
		if (this.17)
		{
			return;
		}
		2023 <<EMPTY_NAME>> = 2023.Cinema;
		2023 2 = 2019.1;
		2023 3 = <<EMPTY_NAME>>;
		if ((2 & 3) > 2023.None)
		{
			return;
		}
		this.GetCurrentScore().18 = true;
		2236 4 = this.GetCurrentScore().CalculateGrade();
		this.GetCurrentScore().18 = false;
		if (4 < 2236.F)
		{
			208 5 = (1304.3 != 1409.Pie) ? this.58.10.8 : (this.54.9 + new 208(28f, 0f));
			1433 6 = new 1433(1455.2("ranking-" + 4.ToString() + "-small", (1416)7, null), (1376)8, 1065.Centre, (1044)1, 5, 0.9f, false, global::198.TransparentWhite, null);
			if (this.87.1())
			{
				6.8 = "rankletter";
				6.15 = 0.5f;
				6.28 = true;
				6.3.Add(new 1445(1456.Fade, 1f, 0f, 1226.16 + 400, 1226.16 + 1600, (1046)1));
				6.3.Add(new 1445(1456.Scale, 0.8f, 1.3f, 1226.16 + 400, 1226.16 + 1600, (1046)1));
				this.72.12(6);
				6 = new 1433(1455.2("ranking-" + 4.ToString() + "-small", (1416)7, null), (1376)8, 1065.Centre, (1044)1, 5, 0.9f, false, global::198.TransparentWhite, null);
				6.8 = "rankletter";
				6.15 = 0.8f;
			}
			6.3.Add(new 1445(1456.Fade, 0f, 1f, 1226.16 + 400, 1226.16 + 700, (1046)1));
			6.3.Add(new 1445(1456.Fade, 1f, 0f, 2648.5.1 - 1000, 2648.5.1 - 700, (1046)2));
			this.77.12(6);
		}
	}

	// Token: 0x06002520 RID: 9504 RVA: 0x000ACBA7 File Offset: 0x000AADA7
	internal virtual void HandleFailure()
	{
		this.58.HandleFailure(false);
	}

	// Token: 0x06002521 RID: 9505 RVA: 0x000ACBB6 File Offset: 0x000AADB6
	protected virtual void EnterFailurePause()
	{
		this.RequestPauseToggle();
	}

	// Token: 0x06002522 RID: 9506 RVA: 0x000ACBBE File Offset: 0x000AADBE
	internal void 9(2149 1)
	{
		this.11((1 & (2149)4) > (2149)0);
	}

	// Token: 0x06002523 RID: 9507 RVA: 0x000ACBCC File Offset: 0x000AADCC
	internal void 10()
	{
		this.11(this.58.IsSectionPassing());
	}

	// Token: 0x06002524 RID: 9508 RVA: 0x000ACBE0 File Offset: 0x000AADE0
	internal void 11(bool 1)
	{
		if (!this.17 && 1 != 2486.12)
		{
			this.58.OnSectionPassStateChanged(1);
			2486.12 = 1;
			if (2486.11 != 2147.Taiko && this.34.38 && !this.139.109)
			{
				this.34.19(0.2f);
			}
		}
	}

	// Token: 0x06002525 RID: 9509 RVA: 0x000ACC44 File Offset: 0x000AAE44
	internal void 12()
	{
		if (1662.84)
		{
			1535.2(false);
			1662.SetMode(1677.Edit, false);
			return;
		}
		if (2486.88.CalculateGrade() == 2236.F)
		{
			1763.4(1568.1(2679.Player_ErrorDuringScoreCalculation));
			1662.SetMode(1677.SelectPlay, false);
			return;
		}
		this.ShowResultsScreen(false);
	}

	// Token: 0x06002526 RID: 9510 RVA: 0x000ACC91 File Offset: 0x000AAE91
	internal virtual void ShowResultsScreen(bool 1)
	{
		1662.SetMode(1677.Rank, false);
	}

	// Token: 0x06002527 RID: 9511 RVA: 0x000ACC9C File Offset: 0x000AAE9C
	private int 13()
	{
		return (int)(2486.88.2 + 2486.88.1 + 2486.88.3 + 2486.88.4 + 2486.88.5 + 2486.88.6);
	}

	// Token: 0x06002528 RID: 9512 RVA: 0x000ACCEC File Offset: 0x000AAEEC
	internal 2486() : base(1662.11)
	{
		2486.7 = this;
	}

	// Token: 0x06002529 RID: 9513 RVA: 0x000ACD9C File Offset: 0x000AAF9C
	internal static 2147 14()
	{
		return 2486.11;
	}

	// Token: 0x0600252A RID: 9514 RVA: 0x000ACDA4 File Offset: 0x000AAFA4
	internal static void 15(2147 1)
	{
		if (2 == 2486.11)
		{
			return;
		}
		2486.11 = 2;
		if (1272.3 != null)
		{
			1272.3.ForEach(delegate(1262 1)
			{
				1.70.Clear();
				1.68 = null;
			});
		}
	}

	// Token: 0x0600252B RID: 9515 RVA: 0x000ACDF0 File Offset: 0x000AAFF0
	internal static bool 16()
	{
		2023 <<EMPTY_NAME>> = 2023.Target;
		2023 2 = 2019.1;
		2023 3 = <<EMPTY_NAME>>;
		if ((2 & 3) > 2023.None && !1535.1())
		{
			return true;
		}
		if (1535.39 != null)
		{
			2023 4 = 1535.39.8;
			3 = 2023.Target;
			return (4 & 3) > 2023.None;
		}
		return false;
	}

	// Token: 0x0600252C RID: 9516 RVA: 0x000ACE3C File Offset: 0x000AB03C
	internal static void 17(bool 1)
	{
		2486.2487 2 = new 2486.2487();
		2.2 = 1;
		if ((1662.78 != 1677.Play || 1535.1()) && 1662.76 == (932)2)
		{
			2.1 = null;
			int num = (1272.3.Count > 0) ? 100 : 0;
			while (--num > 0 && (2.1 == null || 2.1.38() != 2486.14() || !2.1.28 || 2.1.87 <= 0))
			{
				2.1 = 1272.3[1196.2(0, 1272.3.Count)];
			}
			if (2.1 == null)
			{
				1662.SetMode(1677.Menu, false);
				1763.4("Failed to find a map to preview with! Please download more beatmaps!");
				return;
			}
			1662.71(new 1189(2.1));
			1662.SetMode(1677.Play, true);
		}
	}

	// Token: 0x0600252D RID: 9517 RVA: 0x000ACF20 File Offset: 0x000AB120
	public override void Initialize()
	{
		this.139 = 1272.5();
		1662.11.5(new EventHandler(this.70));
		1662.11.7(new EventHandler(this.70));
		this.97 = !1535.1();
		if (1535.1())
		{
			2486.15((1535.39 != null) ? 1535.39.9 : 2147.Osu);
		}
		2023 <<EMPTY_NAME>>;
		2023 3;
		if (!1535.1())
		{
			<<EMPTY_NAME>> = 2023.Autoplay;
			2023 2 = 2019.1;
			3 = <<EMPTY_NAME>>;
			if ((2 & 3) <= 2023.None)
			{
				2486.20 = 1662.33;
			}
		}
		this.92 = 2486.14();
		if (this.139.3() != 2147.Osu)
		{
			2486.15(this.139.3());
			1662.69.12(1f, true);
		}
		<<EMPTY_NAME>> = 2023.Cinema;
		2023 4 = 2019.1;
		3 = <<EMPTY_NAME>>;
		if ((4 & 3) > 2023.None)
		{
			if (1535.1())
			{
				2019.1 &= ~(2023.Autoplay | 2023.Cinema);
			}
			else
			{
				if (this.139.3() == 2147.Osu)
				{
					2486.15(2147.Osu);
				}
				2648.35 = 0;
				2648.2(true);
				2648.4(true);
				2630.13 = false;
				1226.2 = false;
			}
		}
		else if (2513.IsPending)
		{
			1262 5 = 1272.5();
			object obj = 5 != null && 5.111;
			2648.35 = 70;
			2648.2(false);
			2648.4(false);
			object obj2 = obj;
			2630.13 = ((obj2 != null) ? 5.108 : 1304.94);
			1226.2 = ((obj2 != null) ? 5.107 : 1304.93);
		}
		else if (!1662.84)
		{
			this.30 = new 2563(1662.11);
		}
		this.59(null);
		if (!2486.95 && 1304.104)
		{
			2486.95 = true;
			1763.5(string.Format(1568.1(2679.InputManager_MouseButtonsDisabledWarning), 1548.8(1532.DisableMouseButtons)), global::198.Beige, 10000, null);
		}
		if (1226.38 == 0 || 1226.39 == 0)
		{
			1763.5(1568.1(2679.Player_MusicVolumeWarning), global::198.Red, 5000, new 1189(2486.2489.Instance.1));
		}
		2019.7(2023.None);
		<<EMPTY_NAME>> = 2023.Flashlight;
		2023 6 = 2019.1;
		3 = <<EMPTY_NAME>>;
		if ((6 & 3) > 2023.None && 1304.222 != null)
		{
			1304.222.2(false);
		}
		this.133 = false;
		<<EMPTY_NAME>> = 2023.Relax;
		2023 7 = 2019.1;
		3 = <<EMPTY_NAME>>;
		2486.21 = ((7 & 3) > 2023.None && !1535.1());
		<<EMPTY_NAME>> = 2023.Relax2;
		2023 8 = 2019.1;
		3 = <<EMPTY_NAME>>;
		2486.22 = ((8 & 3) > 2023.None && !1535.1());
		this.87 = ((2486.21 || 2486.22) ? 1304.169 : 1304.168);
		if (!2486.96 && !this.87 && !2486.21 && !2486.22)
		{
			2486.96 = true;
			1763.5(string.Format(1568.1(2679.Player_InterfaceDisabledWarning), "Shift + " + 1548.8(1532.ToggleScoreboard).ToString()), global::198.Beige, 10000, null);
		}
		if (!1535.40)
		{
			int num;
			if (!1662.84)
			{
				<<EMPTY_NAME>> = 2023.Autoplay;
				2023 9 = 2019.1;
				3 = <<EMPTY_NAME>>;
				if ((9 & 3) > 2023.None && 1662.81 == 1677.Play)
				{
					num = ((!2486.57) ? 1 : 0);
					goto IL_35E;
				}
			}
			num = 0;
			IL_35E:
			bool flag = (byte)num > 0;
			if (!flag)
			{
				if (1535.1())
				{
					goto IL_440;
				}
				if (!1662.84)
				{
					<<EMPTY_NAME>> = 2023.Autoplay;
					2023 10 = 2019.1;
					3 = <<EMPTY_NAME>>;
					if ((10 & 3) <= 2023.None && !2486.22)
					{
						goto IL_440;
					}
				}
			}
			this.133 = true;
			if (!1662.84 && !2486.22)
			{
				1535.2(true);
			}
			if (flag)
			{
				1535.41 = 1226.16;
			}
			1535.39 = 2246.Create(2486.11, "osu!", this.139, false);
			1535.39.8 = 2019.1;
			1535.39.43 = 1926.3(2486.11);
			1535.39.44 = 1939.16(2019.1);
			1535.39.45 = 1931.3(2486.11);
			1535.39.52 = 1925.15(2486.11, 2019.1);
		}
		IL_440:
		this.71 = new 1436(true)
		{
			16 = true
		};
		this.73 = new 1436(true)
		{
			16 = true,
			5 = 0f
		};
		this.76 = new 1436
		{
			16 = true,
			5 = 0f,
			27 = true
		};
		this.77 = new 1436(true)
		{
			16 = true,
			5 = 0f,
			27 = true
		};
		2528.23 = 0f;
		2528.24 = 0f;
		this.74 = new 1436(true)
		{
			5 = 0f
		};
		this.75 = new 1436(true);
		this.78 = new 1436(true)
		{
			16 = true,
			10 = false
		};
		this.79 = new 1436(true)
		{
			16 = true
		};
		this.72 = new 1436(true)
		{
			16 = true
		};
		2486.13 = false;
		2486.4 = false;
		2486.16 = false;
		2486.8 = false;
		2486.9 = false;
		2486.6 = false;
		2486.41 = true;
		2486.83 = false;
		2486.126 = false;
		2486.45 = false;
		2486.103 = false;
		2486.109 = false;
		this.93 = false;
		if (2486.136 && this.30 != null)
		{
			this.30.20 = true;
		}
		2486.136 = false;
		this.17 = (this.139.10 == "osu! tutorial");
		2486.5 = 0;
		if (1662.81 != 1677.Play)
		{
			2486.15 = 0;
		}
		if (2486.70 == null)
		{
			2486.70 = new 1436(true);
		}
		this.138 = 2468.1(2630.26());
		this.138.16 = 0f;
		1445 item = new 1445(1456.Fade, 0f, 1f, 1662.43(this.138.1) - (int)1662.82 + 1000, 1662.43(this.138.1) + 1400, (1046)0);
		this.138.3.Add(item);
		2486.70.12(this.138);
		this.98 = (!2486.57 && !1535.1() && !1662.84);
		if (!2486.57)
		{
			2486.99();
		}
		this.134 = (1662.81 == 1677.Play);
		if (this.98 && this.30 != null && this.30.3())
		{
			this.30.22(!1535.1(), this.134);
		}
		this.94 = new 1260(delegate()
		{
			int num2 = 1662.33;
			switch (2486.14())
			{
			case 2147.Osu:
				if (2486.16())
				{
					this.58 = new 2146(this);
				}
				else
				{
					this.58 = new 2141(this);
				}
				break;
			case 2147.Taiko:
				this.58 = new 2187(this);
				break;
			case 2147.CatchTheBeat:
				this.58 = new 1883(this);
				break;
			case 2147.OsuMania:
				this.58 = new 1999(this);
				break;
			}
			2147 11 = this.139.3();
			bool flag2 = this.139.59;
			this.139.65();
			bool flag3 = flag2 && 11 != this.139.3();
			2147 12 = 2486.14();
			if ((12 == 2147.Osu || 12 == 2147.CatchTheBeat) && 1272.5().65 >= 7000)
			{
				2023 13 = 2023.ScoreV2;
				2023 14 = 2019.1;
				2023 15 = 13;
				if ((14 & 15) <= 2023.None)
				{
					2019.1 |= 2023.ScoreV2;
				}
			}
			this.151(this.139, true);
			this.39 = this.58.5;
			this.60();
			if (!1535.1())
			{
				this.139.46 = DateTime.UtcNow;
				if (1662.54 != null)
				{
					1662.54.4();
				}
			}
			else
			{
				this.93 = true;
			}
			this.58.ApplyBeatmapSkinPreference();
			bool flag4 = false;
			try
			{
				this.62();
			}
			catch (1043)
			{
				flag4 = true;
			}
			this.39.45 = 2486.88.43;
			this.39.46 = 2486.88.44;
			this.39.47 = 2486.88.52;
			this.39.6(this.139, 2486.88.8);
			this.39.46(false, false);
			if (this.39.35 == 0 || (1226.81() != null && 1226.81().Count == 0))
			{
				base.Initialize();
				this.ReturnToSongSelect();
				1763.4(1568.1(2679.Player_CantLoadBeatmap));
				return;
			}
			foreach (2034 16 in this.39.34)
			{
				if (16.2 > this.84)
				{
					this.84 = 16.2;
				}
				if (16.1 < this.85)
				{
					this.85 = 16.1;
				}
			}
			this.34 = this.39.32;
			this.65();
			if (1535.1())
			{
				this.PrepareReplayPlayback();
			}
			this.58.Initialize();
			if (!1535.1())
			{
				this.PrepareReplayPlayback();
			}
			if (1662.54 != null)
			{
				this.58.3.3(new 1189(this.156));
			}
			this.58.SetPlayfieldOpacity(0f);
			this.151(this.139, false);
			this.39.37(true);
			250.5(this.39);
			2206.3(2486.88, 1272.5());
			if (1226.31 == null || 1226.31.IsDirectStream() || flag4)
			{
				this.ReturnToSongSelect();
				1763.4(1568.1(2679.Player_CantLoadAudio));
				return;
			}
			this.PrepareGameplayEffects();
			if (!this.133 && 1535.1() && !1535.40 && 1535.39.26.Count == 0)
			{
				1662.SetMode(1677.SelectPlay, false);
				1535.2(false);
				1763.4(1568.1(2679.Player_CantLoadReplay));
				return;
			}
			if (this.133)
			{
				this.58.GenerateAutoplayReplay();
				if (2486.22 && !1535.1())
				{
					2486.88.26 = new List<1840>();
					2486.88.23 = 1304.189;
				}
				else
				{
					1535.39 = 2486.88;
				}
			}
			1662.89.Schedule(new 1189(this.24), false);
			this.56();
			this.58();
			this.71();
			this.CreateSpectatorList();
			this.90 = this.154();
			this.LoadScoreboard();
			this.PrepareBreakIndicators();
			if (1304.95 || 1535.1())
			{
				12 = 2486.14();
				if (12 == 2147.Osu || 12 == 2147.CatchTheBeat)
				{
					this.86 = new 2547();
					2522.14("keys", "Key overlay", 2509.CentreRight, this.86.Layer, new 208(2528.WindowWidth, 200f));
				}
			}
			this.63();
			this.37();
			if (this.30 != null)
			{
				this.30.5();
			}
			if (this.98 && !this.134 && Thread.CurrentThread != 1662.106)
			{
				int 17 = ((this.139.85 == (1281)6) ? 5000 : 1000) - (1662.33 - num2);
				this.61(17);
			}
			2486.57 = false;
			if (flag3)
			{
				2241 18 = 2486.88;
				if (18 == null)
				{
					return;
				}
				18.18();
			}
		}, new 1300(this.HandleBeatmapLoadCompleted));
		1662.55.5 = false;
		base.Initialize();
	}

	// Token: 0x0600252E RID: 9518 RVA: 0x000AD63C File Offset: 0x000AB83C
	protected override void Dispose(bool 1)
	{
		1260 2 = this.94;
		if (2 != null)
		{
			2.Dispose();
		}
		this.96();
		1240 3 = 1226.31;
		if (3 != null)
		{
			3.SetPitchShift(0f);
		}
		2019.3 = null;
		2486.189 = false;
		2486.190 = false;
		if (this.133 && 1662.77 != 1677.Play)
		{
			2019.1 &= ~(2023.Autoplay | 2023.Cinema);
		}
		if (this.100 != null && this.100 != 1226.31 && this.100.IsDirectStream())
		{
			this.100.Dispose();
		}
		2486.22(false);
		1226.25(this.106);
		1256 4 = this.106;
		if (4 != null)
		{
			4.Dispose();
		}
		1662.11.6(new EventHandler(this.70));
		1662.11.8(new EventHandler(this.70));
		this.80 = (707)6;
		2486.21 = false;
		2486.22 = false;
		2486.83 = false;
		2486.13 = false;
		2486.88 = this.GetCurrentScore();
		2486.7 = null;
		2486.23 = null;
		this.152();
		1226.98();
		1226.8();
		this.39();
		if (!1226.40)
		{
			1226.39(100.0);
			1025.BASS_ChannelSetAttribute(1226.31.2(), (994)1, 1226.30);
		}
		if (this.39 != null)
		{
			this.39.Dispose();
		}
		if (this.71 != null)
		{
			this.71.Dispose();
		}
		if (this.73 != null)
		{
			this.73.Dispose();
		}
		if (this.72 != null)
		{
			this.72.Dispose();
		}
		if (this.76 != null)
		{
			this.76.Dispose();
		}
		if (this.77 != null)
		{
			this.77.Dispose();
		}
		if (this.74 != null)
		{
			this.74.Dispose();
		}
		if (this.75 != null)
		{
			this.75.Dispose();
		}
		if (this.78 != null)
		{
			this.78.Dispose();
		}
		if (this.79 != null)
		{
			this.79.Dispose();
		}
		if (2486.70 != null)
		{
			2486.70.28.ForEach(delegate(1371 1)
			{
				1433 6 = 1 as 1433;
				if (6 != null && 6.GetTexture() != null)
				{
					6.GetTexture().11 = true;
				}
			});
			2486.70.Dispose();
			2486.70 = null;
		}
		if (this.54 != null)
		{
			this.54.Dispose();
		}
		if (this.30 != null)
		{
			this.30.Dispose();
		}
		if (this.86 != null)
		{
			this.86.Dispose();
		}
		if (2486.24 != null)
		{
			2486.24.Dispose();
			2486.24 = null;
		}
		if (this.97)
		{
			2486.19++;
			if (2486.57)
			{
				2486.18++;
			}
			else
			{
				2486.18 = 0;
			}
		}
		if (this.58 != null)
		{
			this.58.Dispose();
		}
		1535.33 = 0;
		2486.15(this.92);
		base.Dispose(5);
		if (1662.47)
		{
			1662.51.16 = 1f;
		}
	}

	// Token: 0x0600252F RID: 9519 RVA: 0x000AD964 File Offset: 0x000ABB64
	public override void Update()
	{
		this.29();
		if (this.66())
		{
			return;
		}
		this.76();
		if (this.86 != null)
		{
			this.86.Update();
		}
		float num = this.87.1() > false;
		float num2 = (!this.94.3) ? 0f : ((1226.16 < -1000 && this.67 > 6000) ? 0f : ((!this.46) ? 1f : 0f));
		if (1662.47)
		{
			1662.51.16 = Math.Min(1f, 1f - this.76.7);
		}
		if ((2486.13 || 2486.83) && this.50 != null && 1226.16 < this.67)
		{
			this.66.16 = (1f - this.50[0].16) * 0.6f;
		}
		if (this.73.5 != num2)
		{
			this.73.5 = 1052.19(this.73.5 + ((num2 < this.73.5) ? -0.07f : 0.07f) * (float)1662.10, 0f, 1f);
			if (this.39 != null)
			{
				this.39.39.5 = this.73.5;
			}
			if (this.58 != null)
			{
				this.58.SetPlayfieldOpacity(this.73.5);
			}
		}
		if (this.76.5 != num && !this.46)
		{
			this.77.5 = (this.76.5 = 1052.19(this.76.5 + ((num < this.76.5) ? -0.07f : 0.07f) * (float)1662.10, 0f, 1f));
		}
		else if (this.46)
		{
			this.77.5 = (this.76.5 = this.73.5 * num);
		}
		float num3 = this.46 ? this.73.5 : 1f;
		if (2528.24 != num3)
		{
			2528.24 = (this.46 ? num3 : 1052.19(2528.24 + ((num3 < 2528.24) ? -0.07f : 0.07f) * (float)1662.10, 0f, 1f));
		}
		2528.23 = this.76.5;
		if (this.80 == (707)0 || 1662.76 == (932)0)
		{
			this.82();
			return;
		}
		if (this.80 == (707)1 && 1226.16 >= this.67)
		{
			this.54();
			this.80 = (707)2;
		}
		if (2486.15 > 0 && !2486.13 && !2486.83)
		{
			this.TrySkip();
		}
		this.73();
		if (2486.13)
		{
			float num4 = (1662.11.2() ? 0.05f : -0.05f) * (float)1662.10;
			if (this.106 != null)
			{
				this.106.2(1052.19(this.106.1() + num4, 0f, 1f));
			}
		}
		if (1226.16 >= this.67 && 1226.32 == (1042)1)
		{
			if (!this.46)
			{
				if (this.66.19 && this.66.9 != -1)
				{
					this.66.9 = -1;
					this.HideSkipButton();
				}
			}
			else if (!this.66.19 && this.66.3.Count == 0 && this.34.31 - 1226.16 > 3000)
			{
				2486.126 = true;
				this.66.10 = true;
				this.66.3.Clear();
				this.66.FadeIn(300, (1046)0, 0);
			}
		}
		if (this.30 != null)
		{
			this.30.Update();
			this.78.22 = !this.30.7;
			if (this.66.9 != -1)
			{
				this.66.10 = (!this.30.7 && !2486.13);
			}
		}
		this.34.16();
		if (!1662.11.2() && 2486.14 && !2486.13)
		{
			this.70(this, null);
		}
		2023 <<EMPTY_NAME>> = 2023.Cinema;
		2023 2 = 2019.1;
		2023 3 = <<EMPTY_NAME>>;
		if ((2 & 3) <= 2023.None && 1662.76 == (932)2)
		{
			if ((1549.1 && 1549.10(global::200.R)) || 1549.10(1548.8(1532.QuickRetry)))
			{
				if (1662.75 <= 0.0)
				{
					1662.30.15(true);
					1662.21.9(false);
					1662.30.12(1662.21);
				}
				1662.75 = Math.Min(100.0, 1662.75 + (double)(10f * (float)1662.10));
				if (1662.75 == 100.0)
				{
					2486.83(true);
				}
			}
			else if (1662.75 > 0.0)
			{
				1662.75 = Math.Max(0.0, 1662.75 - (double)(3f * (float)1662.10));
			}
		}
		if (2486.13)
		{
			this.82();
			return;
		}
		if (2486.83)
		{
			if (!this.82 || (this.50 != null && (this.50.Count <= 0 || this.50[0].19)))
			{
				this.82();
				return;
			}
			this.85();
			this.66.10 = true;
			if (1226.10() && !2486.16 && !this.156)
			{
				1226.107();
			}
		}
		if (2486.41 && 1226.22 >= (double)(this.137 + Math.Min(0, 1226.20)) && 1662.76 == (932)2 && this.130)
		{
			2486.41 = false;
			if (1226.4)
			{
				1226.8();
				if (1226.16 > 1000)
				{
					1226.4(1226.16, false, true);
				}
			}
			1226.109();
		}
		this.131();
		this.94();
		1240 4 = 1226.31;
		if (4 != null)
		{
			2241 5 = 2486.88;
			4.SetPitchShift((5 != null) ? 5.50 : 0f);
		}
		if (1226.32 == (1042)0 && !2486.16 && !2486.41 && !2486.45 && !this.191 && !this.156)
		{
			1226.6();
			2486.45 = true;
		}
		this.58.UpdateModeInputEffects();
		this.43();
		this.39.RebuildTimeWindowObjects();
		if (!1535.1() || 1535.56 || this.133)
		{
			if (this.110 != null)
			{
				int? num5 = this.110;
				int num6 = 1226.16;
				if (!(num5.GetValueOrDefault() <= num6 & num5 != null))
				{
					goto IL_75A;
				}
			}
			this.110 = new int?(1226.16);
			this.58.JudgeCurrentObject();
			this.31();
		}
		IL_75A:
		this.39.UpdateTimeWindowObjects();
		this.58.8();
		this.30();
		this.44();
		this.UpdateScoreboard();
		this.33();
		if (this.69 != null)
		{
			float num7 = (2486.24 == null) ? 1f : 2486.24.8.5;
			this.69.16 = (2486.13 ? Math.Max(num7, this.78.5) : num7);
		}
		if (2486.14() == 2147.Taiko)
		{
			this.2();
		}
		bool flag = this.63 != 2486.88.GetScore() || (int)2486.88.6 != this.42 || 2486.4 != this.35;
		2499 6 = this.58.3;
		int num8 = (6 != null) ? 6.GetCombo() : 0;
		int num9 = this.13();
		bool flag2 = 1535.1() && (num8 != this.64 || num9 != this.65);
		if (flag || flag2)
		{
			this.RecordScoreSnapshot();
			this.35 = 2486.4;
			this.63 = 2486.88.GetScore();
			this.42 = (int)2486.88.6;
			this.64 = num8;
			this.65 = num9;
			if (flag)
			{
				this.36 = true;
			}
		}
		if (2486.4)
		{
			this.5();
			this.82();
			return;
		}
		if (2486.16 && this.58.6.1() > this.58.6.3() - 5.0)
		{
			2486.16 = false;
			1226.29(1226.48("gos", false, true, (1416)7), 100, 0f, false, 1f, false);
			1226.109();
		}
		if (2486.21 && 2486.14() != 2147.Taiko)
		{
			int num10 = 1304.33.1() ? 1 : 12;
			foreach (2034 7 in this.39.36)
			{
				if (7.1 - 1226.16 < num10 && ((7.HasObjectType(2047.Normal) && !7.11) || (7.HasObjectType(2047.Slider) && !((2123)7).IsHeadJudged())))
				{
					this.50(this, null);
					if (1662.23)
					{
						1535.51.3.Add(new 1445(global::198.Pink, global::198.White, 1662.33, 1662.33 + 150));
					}
				}
			}
		}
		bool flag3 = 2486.103 && !1304.54.1();
		if ((2486.21 || 2486.22 || (flag3 && (1535.14 == global::199.Pressed || 1535.43 == global::199.Pressed))) && 1662.23 && (2486.8 || 2486.9))
		{
			this.45(null);
		}
		if (flag3)
		{
			this.58.ApplyKiaiHitLighting();
		}
		this.4();
		if (1662.76 == (932)2 && !2486.41)
		{
			this.89 = ((!1662.84 || 1226.18 > 1662.85) && (!1535.1() || 1535.41 < 1226.18) && 1226.16 >= this.39.34[0].1 - this.39.LeadInPreemptTime && 1226.16 <= (this.PracticeObjectsEnd ?? this.39.34[this.39.35 - 1].2) && this.56 < 0 && 1226.32 != (1042)0 && this.3());
			this.6();
			int? practiceObjectsEnd = this.PracticeObjectsEnd;
			if ((practiceObjectsEnd ?? this.84) + 3000 <= 1226.16 && (practiceObjectsEnd != null || this.34.14.Count == 0 || this.34.31 - 500 <= 1226.16) && this.46)
			{
				this.12();
			}
			if (2648.6 && 2648.5 != null && 1226.16 > this.39.34[0].1 && !this.28 && this.39.36.Find(new Predicate<2034>(2486.2489.Instance.11)) == null)
			{
				this.10();
				this.58.6();
				this.28 = true;
				if (2648.5.GetDuration() > 5000 && 2486.88.GetJudgementCount() > 5)
				{
					this.8();
				}
				if (2648.5.GetDuration() > 2880 && !this.46 && !2486.4)
				{
					this.7();
				}
			}
			else if (!2648.6 && !this.46 && !2486.4 && this.28)
			{
				this.28 = false;
				this.58.7();
			}
		}
		this.130();
		this.51();
		if (!2648.6 && !this.46)
		{
			this.58.3.UpdateVisibility();
		}
		base.Update();
		this.102 = false;
		this.82();
	}

	// Token: 0x06002530 RID: 9520 RVA: 0x000AE678 File Offset: 0x000AC878
	public override void Draw()
	{
		if (this.80 != (707)0)
		{
			if (this.58.3.GetCombo() == 0)
			{
				this.33 = 0;
			}
			if (this.58.IsComboBurstThreshold() && this.33 < this.58.3.GetCombo())
			{
				this.32 = true;
			}
			2034 <<EMPTY_NAME>> = this.39.36.Find(new Predicate<2034>(2486.2489.Instance.15));
			bool flag = !(this.58 is 2187) && 2630.5.SpinnerFadePlayfield && <<EMPTY_NAME>> != null && this.CanFadePlayfieldForSpinner();
			if (!flag || <<EMPTY_NAME>>.30[0].16 != 1f)
			{
				if (flag && 1662.70.7())
				{
					this.34.22.7 = Math.Max(this.34.22.7, ((float)2648.35 + <<EMPTY_NAME>>.30[0].16 * (float)(100 - 2648.35)) / 100f);
				}
				if (this.34.22.7 < 0.99f)
				{
					this.34.13();
					if (this.139.84)
					{
						this.34.14();
					}
				}
				this.34();
				if (!this.139.84)
				{
					this.34.14();
				}
			}
			this.75.7 = 2648.1.22.7;
			this.75.22();
			this.74.22();
			this.73.22();
			this.DrawGameplay();
			this.DrawScoreboard();
			2023 2 = 2023.Cinema;
			2023 3 = 2019.1;
			2023 4 = 2;
			if ((3 & 4) <= 2023.None && this.86 != null && 1304.95 && !1535.1())
			{
				this.86.Draw();
			}
			this.71.22();
			this.72.5 = ((!2486.13 || this.50 == null) ? 1f : (1f - this.50[0].16));
			this.72.22();
			this.DrawAdditionalOverlay();
			this.76.22();
			if (this.54 != null)
			{
				this.54.Draw();
			}
			this.77.22();
			this.95();
			if (this.86 != null && 1535.1())
			{
				this.86.Draw();
			}
			if (2486.13 || 2486.83)
			{
				this.78.22();
			}
			this.79.22();
		}
		if (!this.94.3)
		{
			if (2486.70 != null)
			{
				2486.70.22();
			}
			this.75.22();
			this.94.Draw();
		}
		if (this.30 != null)
		{
			this.30.24();
		}
		base.Draw();
	}

	// Token: 0x06002531 RID: 9521 RVA: 0x000AE988 File Offset: 0x000ACB88
	internal string 18()
	{
		string[] array = new string[19];
		array[0] = "play state ";
		int num = 1;
		int num2 = (int)this.80;
		array[num] = num2.ToString();
		array[2] = ", loaded ";
		int num3 = 3;
		1260 <<EMPTY_NAME>> = this.94;
		array[num3] = (<<EMPTY_NAME>> != null && <<EMPTY_NAME>>.3).ToString();
		array[4] = ", started ";
		array[5] = 2486.109.ToString();
		array[6] = ", paused ";
		array[7] = 2486.13.ToString();
		array[8] = ", waiting to resume ";
		array[9] = 2486.83.ToString();
		array[10] = ", completed ";
		array[11] = this.46.ToString();
		array[12] = ", failed ";
		array[13] = 2486.4.ToString();
		array[14] = ", visual settings ";
		array[15] = ((this.30 == null) ? "none" : (this.30.7 ? "open" : "closed"));
		array[16] = ", audio ";
		array[17] = 1226.16.ToString();
		array[18] = " ms";
		return string.Concat(array);
	}

	// Token: 0x06002532 RID: 9522 RVA: 0x000AEAA4 File Offset: 0x000ACCA4
	internal static void 19()
	{
		2486 <<EMPTY_NAME>> = 2486.7;
		if (1662.78 == 1677.Play && <<EMPTY_NAME>> != null)
		{
			if (2486.88 != 2486.141)
			{
				2486.20();
				2486.141 = 2486.88;
				1262 2 = 1272.5();
				2486.142 = ((2 != null) ? 2.23 : null);
				2486.143 = (2486.88 != null && !2486.88.47 && !1535.1() && 2486.14() == 2147.Osu && (2486.88.8 & (2023.Autoplay | 2023.Cinema)) == 2023.None);
				2486.144 = false;
			}
			2486.144 |= 2486.4;
			if (!2486.13 && !2486.83 && !2486.4 && !<<EMPTY_NAME>>.46 && <<EMPTY_NAME>>.80 != (707)0 && 1226.16 >= 0 && !1535.1() && 2486.88 != null && (2486.88.8 & (2023.Autoplay | 2023.Cinema)) == 2023.None && (!2486.88.47 || (1304.21.1() && !<<EMPTY_NAME>>.156)))
			{
				2210.10(1662.10 * 16.666666666666668, 2486.88.9);
				2486.140 = true;
			}
			return;
		}
		2486.20();
		if (2486.140)
		{
			2486.140 = false;
			2210.Save();
		}
	}

	// Token: 0x06002533 RID: 9523 RVA: 0x000AEC08 File Offset: 0x000ACE08
	private static void 20()
	{
		2241 <<EMPTY_NAME>> = 2486.141;
		2486.141 = null;
		if (<<EMPTY_NAME>> == null || !2486.143 || 2486.144 || <<EMPTY_NAME>>.18)
		{
			return;
		}
		if (<<EMPTY_NAME>>.13 >= 30 || <<EMPTY_NAME>>.GetScore() >= 10000)
		{
			2210.14(2486.142);
			2486.140 = true;
		}
	}

	// Token: 0x06002534 RID: 9524 RVA: 0x000AEC64 File Offset: 0x000ACE64
	public static void 21()
	{
		if (1662.78 != 1677.Play || 2486.7 == null)
		{
			2486.14 = false;
			return;
		}
		try
		{
			2486.14 = (!2486.45 && 2486.7.80 == (707)2 && 2486.7.39 != null && 2486.7.39.35 > 0 && 2486.109 && 1226.16 >= 2486.7.39.GetFirstGameplayHitObject()._000F_2007_2000_2004_200A_2000_2007_200B_2005_2005_2003_200A_200B_2008_2002_200B_2007_2009_2009_2000() - 2486.7.39.LeadInPreemptTime && 1226.16 <= 2486.7.39.GetLastGameplayHitObject()._0005_200B_2002_2000_2005_200A_2005_2008_2004_2007_2005_2007_2006_2008_2007_2004_2001_2002_2007_2007_2007_2004_2002_2003_2009_2009_2001() + 2486.7.39.3 && !2486.4 && !2486.13 && !2648.6 && !2486.88.18 && (!1535.1() || 1535.31 || 2486.22) && !2486.7.156);
		}
		catch
		{
			2486.14 = false;
		}
	}

	// Token: 0x06002535 RID: 9525 RVA: 0x000AED8C File Offset: 0x000ACF8C
	private static void 22(bool 1)
	{
		if (!2486.112 || 1304.218)
		{
			return;
		}
		try
		{
			2486.23(1);
		}
		catch
		{
			2486.112 = false;
		}
	}

	// Token: 0x06002536 RID: 9526 RVA: 0x000AEDD0 File Offset: 0x000ACFD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void 23(bool 1)
	{
		GCSettings.LatencyMode = ((!1) ? GCLatencyMode.Interactive : GCLatencyMode.LowLatency);
	}

	// Token: 0x06002537 RID: 9527 RVA: 0x000AEDE0 File Offset: 0x000ACFE0
	private void 24()
	{
		if (1304.3 == 1409.Off)
		{
			2522.2("progress", "Song progress", "How far the song is", delegate
			{
				1304.3.SetValue(1409.Pie);
				this.24();
				return 2522.5("progress");
			});
			return;
		}
		2528 placement = 2522.6("progress", "Song progress", 2486.25(), delegate
		{
			this.26(null);
		}, null);
		if (placement == null)
		{
			return;
		}
		2530 <<EMPTY_NAME>> = placement.8(2530.3("style", "Style", "A pie by the accuracy, or a bar (the option of the same name).", "pie", new string[]
		{
			"pie",
			"topright",
			"bottomright",
			"bottom"
		}, new string[]
		{
			"Pie",
			"Bar at the top right",
			"Bar at the bottom right",
			"Bar along the bottom"
		}));
		<<EMPTY_NAME>>.17 = delegate()
		{
			if (1304.3 != 1409.Off)
			{
				return 1304.3.ToString().ToLowerInvariant();
			}
			return "pie";
		};
		<<EMPTY_NAME>>.18 = delegate(string 1)
		{
			1304.3.SetValue((1 == "topright") ? 1409.TopRight : ((1 == "bottomright") ? 1409.BottomRight : ((1 == "bottom") ? 1409.Bottom : 1409.Pie)));
		};
		Func<bool> func = () => !(this.54 is 1401);
		placement.8(2530.1("show_graph", "Show difficulty graph", "Whether a graph displaying difficulty throughout the beatmap should be shown.", false)).16 = func;
		placement.8(2530.1("show_time", "Show time", "Whether the passed and remaining time should be shown.", false)).16 = func;
		placement.27 = delegate(string 1)
		{
			this.27(placement);
		};
		if (placement.11("show_graph") || placement.11("show_time"))
		{
			this.27(placement);
		}
	}

	// Token: 0x06002538 RID: 9528 RVA: 0x000AEFB8 File Offset: 0x000AD1B8
	private static 2509 25()
	{
		1409 <<EMPTY_NAME>> = 1304.3;
		if (<<EMPTY_NAME>> == 1409.BottomRight)
		{
			return 2509.BottomRight;
		}
		if (<<EMPTY_NAME>> != 1409.Bottom)
		{
			return 2509.TopRight;
		}
		return 2509.BottomLeft;
	}

	// Token: 0x06002539 RID: 9529 RVA: 0x000AEFE0 File Offset: 0x000AD1E0
	private void 26(2528 1)
	{
		1409 2 = 1304.3;
		if (2 == 1409.Pie || 2 == 1409.Off)
		{
			this.54 = new 1401(this.77, this.58.10.8);
			return;
		}
		this.54 = new 1380(this.77, 2, this.58.10.2());
		if (1 != null && this.39.34.Count > 0)
		{
			this.54.3(1.11("show_graph"), 1.11("show_time"), this.39.34, this.39.34[0].1, this.84);
		}
	}

	// Token: 0x0600253A RID: 9530 RVA: 0x000AF0A4 File Offset: 0x000AD2A4
	private void 27(2528 1)
	{
		1380 2 = this.54;
		if (2 != null)
		{
			2.6();
		}
		2522.7(1, 2486.25(), delegate
		{
			this.26(1);
		});
		this.30();
	}

	// Token: 0x0600253B RID: 9531 RVA: 0x000AF0F8 File Offset: 0x000AD2F8
	protected virtual void CreateSpectatorList()
	{
		this.69 = new 1452(string.Empty, 11f, new 208(0f, 80f), 1f, true, global::198.White);
		this.69.63(true);
		if (!1662.47 && ((!1535.1() && 1304.116) || 1535.40))
		{
			this.79.12(this.69);
		}
	}

	// Token: 0x0600253C RID: 9532 RVA: 0x000AF174 File Offset: 0x000AD374
	protected virtual void LoadScoreboard()
	{
		this.135 = 1304.164;
		if (this.139.85 < (1281)4 || this.135 == 1289.Local)
		{
			this.135 = 1289.Local;
			this.28();
			return;
		}
		List<2241> list = this.139.70;
		if (list != null && list.Count > 0)
		{
			this.28();
			return;
		}
		this.139.78(true, false, 1304.164, new 1291(this.35));
	}

	// Token: 0x0600253D RID: 9533 RVA: 0x000AF1F8 File Offset: 0x000AD3F8
	private void 28()
	{
		this.55();
		if (1662.47 || !this.58.ShouldShowScoreboard() || 2486.24 != null)
		{
			return;
		}
		List<2241> list = this.139.70;
		List<2241> list2 = (list != null && list.Count > 0) ? this.139.70 : 2230.3(this.139.23, 2486.14());
		if (list2 == null || list2.Count == 0)
		{
			return;
		}
		list2 = new List<2241>(list2);
		this.62 = new 2481(0, 2486.88.23 ?? "-", 2486.14());
		this.62.17 = true;
		2486.24 = new 2562(6, this.62, this.58.GetScoreboardPosition(), 1535.1() || 1304.114.1());
		if (this.58.IsScoreboardMirrored())
		{
			2486.24.3(true);
		}
		2486.24.13 = true;
		if (1535.1() || 1304.114)
		{
			2486.24.6(string.Format(1568.1(2679.Player_ToggleScoreboard), 1548.8(1532.ToggleScoreboard).ToString()));
		}
		2486.24.5 = true;
		2486.24.8.5 = 0f;
		2481 <<EMPTY_NAME>> = null;
		foreach (2241 2 in list2)
		{
			2486.24.11++;
			bool flag = 2.23 == this.62.4;
			if (this.135 > 1289.Local && flag)
			{
				if ((this.139.68 == null || this.139.68.GetScore() != 2.GetScore() || this.135 != 1289.Top) && (1535.39 == null || !(2.7 == 1535.39.7)))
				{
					<<EMPTY_NAME>> = new 2481(2.17, 2, 2486.14());
				}
			}
			else
			{
				2481 3 = new 2481(2.17, 2, 2486.14());
				2486.24.1(3);
			}
		}
		if (this.139.68 != null && (!1535.1() || 1535.39.23 != 1662.100.2()) && <<EMPTY_NAME>> == null)
		{
			<<EMPTY_NAME>> = new 2481(this.139.68.17, this.139.68, 2486.14());
		}
		if (<<EMPTY_NAME>> != null)
		{
			<<EMPTY_NAME>>.17 = true;
			<<EMPTY_NAME>>.20 = false;
			2486.24.1(<<EMPTY_NAME>>);
			<<EMPTY_NAME>>.7.6 = new 198(byte.MaxValue, 69, 0, 150);
		}
		2486.24.SortAndLayout(false);
		2486.24.4(false);
	}

	// Token: 0x0600253E RID: 9534 RVA: 0x000AF504 File Offset: 0x000AD704
	protected void 29()
	{
		if (this.80 != (707)0 && this.58 != null)
		{
			2023 <<EMPTY_NAME>> = 2486.88.8;
			2023 2 = 2023.Flashlight;
			if ((<<EMPTY_NAME>> & 2) > 2023.None)
			{
				this.58.UpdateFlashlight();
			}
		}
	}

	// Token: 0x0600253F RID: 9535 RVA: 0x000AF548 File Offset: 0x000AD748
	private void 30()
	{
		float <<EMPTY_NAME>> = (1226.16 <= this.39.34[0].1) ? (-1f + ((float)1226.16 + (float)this.137) / (float)(this.137 + this.39.34[0].1)) : (((float)1226.16 - (float)this.39.34[0].1) / (float)(this.84 - this.39.34[0].1));
		if (this.54 != null)
		{
			this.54.SetProgress(1052.19(<<EMPTY_NAME>>, -2f, 1f));
			int 2 = this.39.34[0].1;
			2504 3 = this.58;
			double? num;
			if (3 == null)
			{
				num = null;
			}
			else
			{
				2511 4 = 3.13;
				num = ((4 != null) ? new double?(4.8) : null);
			}
			double? num2 = num;
			double valueOrDefault = num2.GetValueOrDefault(1.0);
			int num3 = 1226.16;
			int 5 = (int)1052.19((float)(num3 - 2) / (float)Math.Max(1, this.84 - 2) * 100f, 0f, 100f);
			this.54.4((double)(num3 - 2) / valueOrDefault, (double)(this.84 - Math.Max(num3, 2)) / valueOrDefault, 5);
		}
	}

	// Token: 0x06002540 RID: 9536 RVA: 0x000AF6C6 File Offset: 0x000AD8C6
	protected void 31()
	{
		this.58.10.SetScore(this.GetCurrentScore().GetScore());
		this.58.10.4(this.32() * 100f);
	}

	// Token: 0x06002541 RID: 9537 RVA: 0x000AF700 File Offset: 0x000AD900
	private float 32()
	{
		2241 currentScore = this.GetCurrentScore();
		2528 <<EMPTY_NAME>> = 2522.5("accuracy");
		string a = (<<EMPTY_NAME>> != null) ? <<EMPTY_NAME>>.10("mode") : null;
		int num = (this.39 != null) ? this.39.35 : 0;
		if ((a != "max" && a != "min") || 2486.14() != 2147.Osu || num <= 0)
		{
			return currentScore.CalculateAccuracy();
		}
		int num2 = (int)(currentScore.2 + currentScore.1 + currentScore.3 + currentScore.6);
		int num3 = Math.Max(0, num - num2);
		int num4 = (int)currentScore.2 + ((a == "max") ? num3 : 0);
		return (float)((int)(currentScore.3 * 50 + currentScore.1 * 100) + num4 * 300) / ((float)Math.Max(num, num2) * 300f);
	}

	// Token: 0x06002542 RID: 9538 RVA: 0x000AF7E4 File Offset: 0x000AD9E4
	protected virtual void UpdateScoreboard()
	{
		if (2486.24 == null || this.62 == null)
		{
			return;
		}
		if (1662.23)
		{
			if (this.46 || 2486.4 || (!2648.6 && !2486.24.4))
			{
				if (2486.24.8.5 > 0f)
				{
					2486.24.8.5 = Math.Max(0f, 2486.24.8.5 - 0.08f);
				}
			}
			else if (2486.24.8.5 < 1f)
			{
				2486.24.8.5 = Math.Min(1f, 2486.24.8.5 + 0.08f);
			}
		}
		if (this.62 != null && this.62.6 != 2486.88.GetScore())
		{
			this.62.SetScore(2486.88, null);
			2486.24.SortAndLayout(false);
		}
	}

	// Token: 0x06002543 RID: 9539 RVA: 0x000AF8FB File Offset: 0x000ADAFB
	protected virtual void DrawGameplay()
	{
		this.58.BeforeObjectUpdate();
		this.39.8();
		this.58.AfterObjectUpdate();
		this.34.15();
		this.58.Draw();
	}

	// Token: 0x06002544 RID: 9540 RVA: 0x00005ADD File Offset: 0x00003CDD
	protected virtual void DrawAdditionalOverlay()
	{
	}

	// Token: 0x06002545 RID: 9541 RVA: 0x000AF934 File Offset: 0x000ADB34
	protected virtual void DrawScoreboard()
	{
		if (2486.24 != null)
		{
			2486.24.5();
		}
	}

	// Token: 0x06002546 RID: 9542 RVA: 0x000AF948 File Offset: 0x000ADB48
	protected virtual bool CanShowLowHealthWarning()
	{
		2023 <<EMPTY_NAME>> = 2023.NoFail;
		2023 2 = 2019.1;
		2023 3 = <<EMPTY_NAME>>;
		return (2 & 3) <= 2023.None && (2486.88 == null || !2486.88.47);
	}

	// Token: 0x06002547 RID: 9543 RVA: 0x000AF97C File Offset: 0x000ADB7C
	private void 33()
	{
		if (!1304.65)
		{
			return;
		}
		if (2486.13)
		{
			1356.4 = false;
			return;
		}
		if (this.58.6 != null && this.58.6.3() < 40.0 && !1662.84 && (!2486.21 || 1304.32.1()) && !2486.22 && this.58.ShouldShowLowHealthEffect() && this.CanShowLowHealthWarning() && 1662.76 == (932)2)
		{
			1356.4 = true;
			if (!2486.4)
			{
				1356.6 = 0.0001f;
				1356.2 = 1f;
				1356.7 = (float)Math.Max(0.0, (40.0 - this.58.6.1()) / 160.0);
				1356.5 = false;
				1356.1 = false;
				return;
			}
			if (1662.23)
			{
				1356.6 = 0.006f * ((1226.29 - 1226.30) / 1226.29);
				1356.7 = (float)Math.Max(0.0, (40.0 - this.58.6.1()) / 160.0);
				1356.5 = false;
				1356.1 = false;
				1356.2 = Math.Min(1f, 1356.2 + 0.01f);
				return;
			}
		}
		else
		{
			if (2486.9 && !1356.4)
			{
				2129 <<EMPTY_NAME>> = (2129)this.26;
				1356.6 = 0.008f;
				1356.7 = 0f;
				1356.4 = true;
				1356.5 = false;
				1356.1 = true;
				1356.2 = Math.Min(0.5f, Math.Max(0f, (float)(Math.Abs(<<EMPTY_NAME>>.9()) - <<EMPTY_NAME>>.49 + 1) / ((float)<<EMPTY_NAME>>.49 * 0.6f)));
				return;
			}
			if (this.27 > 0f)
			{
				1356.6 = 0.0001f;
				1356.7 = 0f;
				1356.4 = true;
				1356.5 = false;
				1356.1 = true;
				1356.2 = this.27 * 0.2f;
				this.27 -= (float)(0.05 * 1662.10);
				return;
			}
			1356.4 = false;
		}
	}

	// Token: 0x06002548 RID: 9544 RVA: 0x000AFBF4 File Offset: 0x000ADDF4
	internal void 34()
	{
		if (2486.9 || !this.32 || this.58.3.4 < 29)
		{
			return;
		}
		2023 <<EMPTY_NAME>> = 2023.Cinema;
		2023 2 = 2019.1;
		2023 3 = <<EMPTY_NAME>>;
		if ((2 & 3) > 2023.None)
		{
			return;
		}
		if (2630.5.ComboSoundBursts.Count == 0)
		{
			int num = 1226.48("comboburst-" + this.29.ToString(), false, true, (1416)7);
			if (num == -1)
			{
				if (this.29 > 0)
				{
					num = 1226.48("comboburst-0", false, true, (1416)7);
					this.29 = 1;
				}
				else
				{
					num = 1226.48("comboburst", false, true, (1416)7);
				}
			}
			else
			{
				this.29++;
			}
			1226.29(num, 100, 0f, false, 1f, true);
		}
		if (2648.35 != 100)
		{
			this.34.19(1304.74 ? 0.8f : 0.4f);
			this.27 = 1f;
		}
		this.58.ShowComboBurst();
		this.33 = this.58.3.GetCombo();
		this.32 = false;
	}

	// Token: 0x06002549 RID: 9545 RVA: 0x0001702D File Offset: 0x0001522D
	protected virtual bool CanFadePlayfieldForSpinner()
	{
		return true;
	}

	// Token: 0x0600254A RID: 9546 RVA: 0x000AFD1D File Offset: 0x000ADF1D
	private void 35(1262 1)
	{
		this.28();
	}

	// Token: 0x0600254B RID: 9547 RVA: 0x000AFD28 File Offset: 0x000ADF28
	public virtual bool CanHideGameplayCursor()
	{
		if (2513.IsOpen)
		{
			return false;
		}
		if (this.IsPracticeHeld)
		{
			return false;
		}
		2504 <<EMPTY_NAME>> = this.58;
		if (<<EMPTY_NAME>> != null && <<EMPTY_NAME>>.ShouldHideCursor() && !2486.13)
		{
			2563 2 = this.30;
			if (2 == null || 2.24)
			{
				return 1662.92 == null;
			}
		}
		return false;
	}

	// Token: 0x0600254C RID: 9548 RVA: 0x000AFD7D File Offset: 0x000ADF7D
	internal static void 36()
	{
		if (1662.78 != 1677.Play)
		{
			return;
		}
		1535.2(false);
		1662.SetMode(1677.SelectPlay, true);
	}

	// Token: 0x0600254D RID: 9549 RVA: 0x000AFD98 File Offset: 0x000ADF98
	private void 37()
	{
		1535.40((1082)8, new 1081(this.86), 1545.Default, (1559)0);
		1535.40((1082)7, new 1081(this.50), 1545.Default, (1559)0);
		1549.1(new 1549.1550(this.HandleGameplayKeyDown));
		1226.92(new 1226.1236(this.40));
		1226.66(new 1189(this.38));
		this.39.30(new 2039.2041(this.53));
	}

	// Token: 0x0600254E RID: 9550 RVA: 0x000AFE18 File Offset: 0x000AE018
	private void 38()
	{
		this.102 = true;
	}

	// Token: 0x0600254F RID: 9551 RVA: 0x000AFE24 File Offset: 0x000AE024
	private void 39()
	{
		1549.2(new 1549.1550(this.HandleGameplayKeyDown));
		1226.93(new 1226.1236(this.40));
		1226.67(new 1189(this.38));
		if (this.39 != null)
		{
			this.39.31(new 2039.2041(this.53));
		}
	}

	// Token: 0x06002550 RID: 9552 RVA: 0x000AFE84 File Offset: 0x000AE084
	private void 40(1259 1)
	{
		if (2486.103 != 1.3())
		{
			2486.103 = 1.3();
			if (!2486.103 || !1304.54.1())
			{
				this.58.OnKiaiStateChanged(2486.103);
			}
		}
	}

	// Token: 0x06002551 RID: 9553 RVA: 0x000AFEC4 File Offset: 0x000AE0C4
	protected virtual bool HandleGameplayKeyDown(object 1, 200 2)
	{
		if (1662.76 != (932)2)
		{
			return false;
		}
		1532 3 = 1548.16(2);
		if (!this.94.3)
		{
			return (3 == 1532.Pause || 2 == global::200.Escape) && this.ReturnToSongSelect();
		}
		this.91 = true;
		if (this.98(2))
		{
			return true;
		}
		if (3 == 1532.Pause || 2 == global::200.Escape)
		{
			if (this.46)
			{
				this.12();
			}
			else if (1535.1() || 2486.4)
			{
				if (1662.84)
				{
					1535.2(false);
					1662.SetMode(1677.Edit, false);
				}
				else if (1535.1())
				{
					2486.36();
					this.80 = (707)7;
				}
				if (2486.13)
				{
					if (1662.84)
					{
						1662.SetMode(1677.Edit, false);
					}
					else
					{
						1662.SetMode(1677.SelectPlay, false);
					}
				}
				else
				{
					1226.30 = 300f;
				}
			}
			else
			{
				this.RequestPauseToggle();
			}
			return true;
		}
		if (2 == 1548.8(1532.Skip))
		{
			this.78(null, null);
			return true;
		}
		if (2486.11 == 2147.OsuMania)
		{
			if ((1549.1 && 2 == global::200.OemPlus) || 3 == 1532.IncreaseSpeed)
			{
				this.41(1);
				return true;
			}
			if ((1549.1 && 2 == global::200.OemMinus) || 3 == 1532.DecreaseSpeed)
			{
				this.41(-1);
				return true;
			}
		}
		switch (3)
		{
		case 1532.IncreaseSpeed:
			if (2486.14() == 2147.OsuMania)
			{
				this.41(1);
				return true;
			}
			break;
		case 1532.DecreaseSpeed:
			if (2486.11 == 2147.OsuMania)
			{
				this.41(-1);
				return true;
			}
			break;
		case 1532.ToggleScoreboard:
			if (1549.2)
			{
				return false;
			}
			if (1549.3)
			{
				this.87.4();
				1763.2(1568.1(this.87 ? 2679.Player_InterfaceEnabled : 2679.Player_InterfaceDisabled), 1000, (1389)0);
			}
			else
			{
				if (2486.24 == null)
				{
					return false;
				}
				2486.24.4 = !2486.24.4;
				if (2648.6)
				{
					if (!2486.24.4)
					{
						2486.24.6(1568.1(2679.Player_ScoreBoardShowStatus));
					}
					else
					{
						2486.24.6(1568.1(2679.Player_ScoreBoardShowStatus2));
					}
				}
				if (!1535.1())
				{
					1304.114.2(2486.24.4);
				}
			}
			return true;
		case 1532.IncreaseAudioOffset:
			this.42(1549.2 ? 1 : 5);
			return true;
		case 1532.DecreaseAudioOffset:
			this.42(1549.2 ? -1 : -5);
			return true;
		}
		if (2486.13 && !1535.1())
		{
			if (2486.4 && 2486.88 != null)
			{
				if (2 == global::200.F1)
				{
					this.152();
					1535.39 = 2486.88;
					1535.2(true);
					1535.42 = true;
					1662.89(1677.Play, true, 0);
					return true;
				}
				if (2 == global::200.F2)
				{
					2230.20(2486.88, true);
					return true;
				}
			}
			switch (2486.14())
			{
			case 2147.Osu:
				if (3 == 1532.Skip || 2 == global::200.Enter || 2 == global::200.Space)
				{
					return this.81(0);
				}
				if (2 == global::200.Up)
				{
					return this.81(-1);
				}
				if (2 == global::200.Down)
				{
					return this.81(1);
				}
				break;
			case 2147.Taiko:
				if (3 == 1532.Skip || 2 == global::200.Enter || 2 == global::200.Space || 3 == 1532.TaikoInnerLeft || 3 == 1532.TaikoInnerRight)
				{
					return this.81(0);
				}
				if (2 == global::200.Down || 3 == 1532.TaikoOuterRight)
				{
					return this.81(1);
				}
				if (2 == global::200.Up || 3 == 1532.TaikoOuterLeft)
				{
					return this.81(-1);
				}
				break;
			case 2147.CatchTheBeat:
				if (3 == 1532.Skip || 2 == global::200.Enter || 2 == global::200.Space || 3 == 1532.FruitsDash)
				{
					return this.81(0);
				}
				if (2 == global::200.Down || 3 == 1532.FruitsRight)
				{
					return this.81(1);
				}
				if (2 == global::200.Up || 3 == 1532.FruitsLeft)
				{
					return this.81(-1);
				}
				break;
			case 2147.OsuMania:
				if (3 == 1532.Skip || 2 == global::200.Enter || 2 == (200)341)
				{
					return this.81(0);
				}
				if (2 <= global::200.Down)
				{
					if (2 == global::200.Up)
					{
						goto IL_3D4;
					}
					if (2 != global::200.Down)
					{
						break;
					}
				}
				else
				{
					if (2 == (200)342)
					{
						goto IL_3D4;
					}
					if (2 != (200)343)
					{
						break;
					}
				}
				return this.81(1);
				IL_3D4:
				return this.81(-1);
			}
		}
		return false;
	}

	// Token: 0x06002552 RID: 9554 RVA: 0x000B02B0 File Offset: 0x000AE4B0
	private void 41(int 1)
	{
		if (1226.16 <= this.85 + 5000 || 1535.1() || 1662.84 || 1304.57.1())
		{
			2009.3(1);
			((1975)this.39).79(1226.16);
		}
	}

	// Token: 0x06002553 RID: 9555 RVA: 0x000B0308 File Offset: 0x000AE508
	private void 42(int 1)
	{
		if (2486.13 || 2486.83)
		{
			1763.2(1568.1(2679.Player_OffsetChangeUnpause), 1000, (1389)0);
			return;
		}
		if ((1226.16 <= this.85 + 10000 || 1662.84 || 2648.6 || 1304.57.1()) && 1662.33 - this.105 >= 150)
		{
			this.105 = 1662.33;
			this.139.72 = Math.Max(-1000, Math.Min(1000, this.139.72 + 1));
			1763.2(string.Format(1568.1(2679.Player_LocalBeatmapOffsetSet), this.139.72), 1000, (1389)0);
		}
	}

	// Token: 0x06002554 RID: 9556 RVA: 0x000B03DC File Offset: 0x000AE5DC
	internal void 43()
	{
		this.26 = (2486.4 ? null : this.39.36.Find(new Predicate<2034>(2486.2489.Instance.12)));
		2486.8 = (this.26 != null && this.26.HasObjectType(2047.Slider));
		2486.9 = (this.26 != null && this.26.HasObjectType(2047.Spinner));
		this.10 = (!2486.4 && this.39.36.Find(new Predicate<2034>(2486.2489.Instance.13)) != null);
	}

	// Token: 0x06002555 RID: 9557 RVA: 0x000B0484 File Offset: 0x000AE684
	private void 44()
	{
		if (1662.23)
		{
			this.43 = 1535.51.17 / 1662.70.3() - this.44;
			this.44 = 1535.51.17 / 1662.70.3();
		}
	}

	// Token: 0x06002556 RID: 9558 RVA: 0x000B04E4 File Offset: 0x000AE6E4
	private void 45(198? 1)
	{
		if (1226.10() || this.CanHideGameplayCursor() || (2486.14 && !this.58.CapturesCursor()))
		{
			return;
		}
		if (1 == null)
		{
			1 = new 198?(this.127);
		}
		int num = 1662.33 + 1196.2(300, 1000);
		1433 2 = new 1433(this.81, (1376)6, 1065.Centre, (1044)0, new 208(1535.51.17.X, 1535.51.17.Y) / 1662.70.3(), 0.05f, false, 1.Value, null);
		1445 3 = new 1445(1456.Scale, 1f, 1196.6(1304.107 ? 1.1f : 2f), 1662.33, num, (1046)0);
		1445 item = new 1445(1456.Fade, 1535.51.16, 0f, 1662.33, num, (1046)0);
		1445 4 = new 1445(1456.Rotation, (float)(1196.3() * 4.0 - 2.0), 1196.7(-2f, 2f), 1662.33, num, (1046)0);
		208 5 = this.43 * 4f;
		if ((2486.21 || 2486.22 || (2486.103 && !1304.54.1())) && !2648.6)
		{
			if (!2486.8 && !2486.9)
			{
				5 = new 208((float)1196.2(-500, 500), (float)1196.2(-500, 500));
			}
		}
		else if (1535.14 == global::199.Pressed && 1535.43 == global::199.Pressed)
		{
			5 += new 208((float)1196.2(-460, 460), (float)1196.2(-160, 160));
		}
		else if (1535.14 == global::199.Pressed)
		{
			5 += new 208((float)1196.2(-460, 0), (float)1196.2(-40, 40));
		}
		else if (1535.43 == global::199.Pressed)
		{
			5 += new 208((float)1196.2(0, 460), (float)1196.2(-40, 40));
		}
		3.15 = (1046)1;
		4.15 = (1046)1;
		2.3.Add(3);
		2.3.Add(item);
		2.3.Add(4);
		2.28 = true;
		this.72.12(2);
		1662.44.2(2, new 208?(5), false);
	}

	// Token: 0x06002557 RID: 9559 RVA: 0x000B0784 File Offset: 0x000AE984
	public void 46(2038 1)
	{
		2038 2 = this.111;
		2038 3;
		do
		{
			3 = 2;
			2038 value = (2038)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<2038>(ref this.111, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06002558 RID: 9560 RVA: 0x000B07BC File Offset: 0x000AE9BC
	public void 47(2038 1)
	{
		2038 2 = this.111;
		2038 3;
		do
		{
			3 = 2;
			2038 value = (2038)Delegate.Remove(3, 1);
			2 = Interlocked.CompareExchange<2038>(ref this.111, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06002559 RID: 9561 RVA: 0x000B07F4 File Offset: 0x000AE9F4
	internal void 48(2034 1, int? 2)
	{
		if (2486.88.27 != null)
		{
			if (2 != null)
			{
				2486.88.27.Add(2.Value);
			}
			else
			{
				2486.88.27.Add(1226.16 - 1.1);
			}
		}
		if (this.58.11 != null)
		{
			this.58.11.OnHitOffset(1, 2);
		}
	}

	// Token: 0x0600255A RID: 9562 RVA: 0x000B0868 File Offset: 0x000AEA68
	internal void 49(double 1)
	{
		if (2486.14() == 2147.Osu && 2486.88.28 != null)
		{
			2486.88.28.Add((int)1);
		}
	}

	// Token: 0x0600255B RID: 9563 RVA: 0x000B0890 File Offset: 0x000AEA90
	private bool 50(object 1, EventArgs 2)
	{
		if (1662.76 == (932)0)
		{
			return false;
		}
		if (2486.4 || (2486.13 && !1535.1()) || 2486.83 || 2486.16 || this.156)
		{
			return false;
		}
		if (!1555.14 && !2486.21 && 2486.14() != 2147.Taiko)
		{
			return false;
		}
		if (2486.21 && 1 == null && 2486.14() != 2147.Taiko)
		{
			return false;
		}
		if (2486.45)
		{
			return false;
		}
		208 3 = 1535.1() ? 1535.34 : 1662.69.14(1535.6);
		2034 4 = 2138.5(this.39, 3, 2486.22 ? 100f : this.39.1);
		2486.2490 5 = (4 == null && 1535.1() && 2486.14() == 2147.Osu) ? this.158() : 2486.2490.Neutral;
		if (4 != null)
		{
			this.91 = true;
			this.115 = 1662.33;
			2032 hitAttemptDisposition = this.58.GetHitAttemptDisposition(4);
			if (hitAttemptDisposition != (2032)1)
			{
				if (hitAttemptDisposition == (2032)2)
				{
					if (4.HasObjectType(2047.Normal))
					{
						2149 6 = this.39.JudgeHitObject(4);
						5 = 2486.160(6);
						this.36 = true;
						if (4.11)
						{
							2138.4(this.39, 4);
						}
						if (6 > (2149)0)
						{
							if (2486.21 || 2486.22)
							{
								for (int i = 0; i < (1304.107 ? 5 : 6); i++)
								{
									this.45(new 198?(4.7));
								}
							}
							this.48(4, null);
							2511 7 = this.58.13;
							if (7 != null)
							{
								7.17(3, 4, this.39.1);
							}
							this.OnObjectHit(4);
						}
					}
					else if (4.HasObjectType(2047.Slider))
					{
						2123 8 = 4 as 2123;
						if (!8.IsHeadJudged())
						{
							if (8.JudgeHead() > (2149)0)
							{
								5 = this.159(4);
								this.26 = 4;
								this.58.ApplyJudgement((2149)64, 4);
								this.36 = true;
								this.48(4, null);
								2511 9 = this.58.13;
								if (9 != null)
								{
									9.17(3, 4, this.39.1);
								}
								if (2486.21 || 2486.22)
								{
									for (int j = 0; j < 6; j++)
									{
										this.45(new 198?(4.7));
									}
								}
							}
							else
							{
								5 = 2486.2490.Miss;
								this.58.ApplyJudgement((2149)(-262144), 4);
							}
							2138.4(this.39, 4);
						}
					}
				}
			}
			else
			{
				4.Shake();
			}
		}
		this.157(3, 5);
		if (this.111 != null)
		{
			this.111(4);
		}
		return true;
	}

	// Token: 0x0600255C RID: 9564 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal virtual void OnObjectHit(2034 1)
	{
	}

	// Token: 0x0600255D RID: 9565 RVA: 0x000B0B54 File Offset: 0x000AED54
	private void 51()
	{
		if (2486.14() == 2147.OsuMania && 1535.6() && 1535.7().Count > 0)
		{
			this.91 = true;
		}
		if (2486.14() != 2147.Osu || (1535.1() && !1535.38))
		{
			return;
		}
		this.122 = this.58.GetReplayCursorPosition();
		if (!(this.122 == this.123))
		{
			this.116 = false;
			if (this.39.64(this.122.X, this.122.Y, true) != null)
			{
				this.117 = this.39.64(this.122.X, this.122.Y, true).GetCurrentPosition();
				this.116 = true;
			}
			this.118 = ((this.123 != null) ? global::208.Distance(this.122, this.123.Value) : 0f);
			this.52();
			this.120 = this.121;
			this.121 = 1662.33;
			this.124 = this.123;
			this.123 = new 208?(this.122);
			this.119 = this.118;
		}
	}

	// Token: 0x0600255E RID: 9566 RVA: 0x000B0CB0 File Offset: 0x000AEEB0
	private void 52()
	{
		if (!2648.6 && !2486.9)
		{
			if (this.114)
			{
				if (this.118 < 10f && 1662.33 - this.115 < 74)
				{
					this.113 += 1.0;
				}
				this.114 = false;
			}
			if (this.118 > 100f && this.116)
			{
				this.114 = true;
				return;
			}
		}
		else
		{
			this.114 = false;
		}
	}

	// Token: 0x0600255F RID: 9567 RVA: 0x000B0D34 File Offset: 0x000AEF34
	private void 53(2149 1, string 2, 2034 3)
	{
		this.125 = 3;
		this.58.ApplyJudgement(1, 3);
		if ((1 & (2149)520095494) > (2149)0 && this.39.38.13 > 0.0)
		{
			2486.88.11.Add(new 208((float)1226.16, (float)Math.Min(1.0, this.58.6.3() / this.39.38.13)));
		}
	}

	// Token: 0x06002560 RID: 9568 RVA: 0x000B0DC4 File Offset: 0x000AEFC4
	private void 54()
	{
		foreach (1433 <<EMPTY_NAME>> in this.99)
		{
			<<EMPTY_NAME>>.16(200, (1046)0, 0);
		}
		this.99.Clear();
	}

	// Token: 0x06002561 RID: 9569 RVA: 0x000B0E28 File Offset: 0x000AF028
	private void 55()
	{
		if (this.17)
		{
			return;
		}
		if (2486.18 > 1)
		{
			1452 <<EMPTY_NAME>> = new 1452(string.Format(1568.1(2679.Player_RetriesCounting), 2486.18), 14f, new 208(0f, 30f), 1f, false, global::198.White);
			<<EMPTY_NAME>>.54(true);
			<<EMPTY_NAME>>.GetTextSize();
			<<EMPTY_NAME>>.3.Add(new 1445(new 208(-20f, 30f), <<EMPTY_NAME>>.7, 1662.33 + 1000, 1662.33 + 1500, (1046)1));
			<<EMPTY_NAME>>.3.Add(new 1445(1456.Fade, 0f, 1f, 1662.33 + 1000, 1662.33 + 1500, (1046)0));
			<<EMPTY_NAME>>.3.Add(new 1445(1456.Fade, 1f, 0f, 1662.33 + 3500, 1662.33 + 4500, (1046)0));
			this.77.12(<<EMPTY_NAME>>);
		}
		if (1662.84 || !this.58.ShouldShowBeatmapMessages() || string.IsNullOrEmpty(this.139.66))
		{
			return;
		}
		string[] array = this.139.66.Split(new char[]
		{
			'\n'
		});
		List<1452> list = new List<1452>();
		208 2 = new 208(0f, -90f);
		int num = 200;
		int num2 = 3800 + array.Length * 800;
		float num3 = 1f;
		foreach (string text in array)
		{
			float num4 = 40f;
			bool 3 = true;
			198 4 = global::198.White;
			int num5 = 500;
			string 5 = text;
			if (text.Length != 0)
			{
				int num6 = 0;
				if (text[0] == '[')
				{
					try
					{
						string[] array3 = text.Substring(1, text.IndexOf(']') - 1).Split(new char[]
						{
							','
						});
						for (int j = 0; j < array3.Length; j++)
						{
							string[] array4 = array3[j].Split(new char[]
							{
								':'
							});
							if (array4.Length == 2)
							{
								string a = array4[0];
								if (!(a == "size"))
								{
									if (!(a == "bold"))
									{
										if (!(a == "colour"))
										{
											if (!(a == "wait"))
											{
												if (!(a == "time"))
												{
													if (a == "hold")
													{
														num2 = num + int.Parse(array4[1]);
														num6++;
													}
												}
												else
												{
													num = int.Parse(array4[1]);
													num2 = num + 4000 + array.Length * 800;
													num6++;
												}
											}
											else
											{
												num5 = int.Parse(array4[1]);
												num6++;
											}
										}
										else
										{
											string[] array5 = array4[1].Split(new char[]
											{
												'.'
											});
											if (array5.Length == 3)
											{
												4 = new 198(byte.Parse(array5[0]), byte.Parse(array5[1]), byte.Parse(array5[2]));
											}
											num6++;
										}
									}
									else
									{
										3 = (array4[1] == "1");
										num6++;
									}
								}
								else
								{
									float.TryParse(array4[1], out num4);
									num6++;
								}
							}
						}
					}
					catch
					{
					}
					if (num6 > 0)
					{
						5 = text.Substring(text.IndexOf(']') + 1);
					}
				}
				num += num5;
				num2 += num5;
				1452 6 = new 1452(5, num4, 2, 0.87f, false, 4);
				6.1 = (1044)1;
				6.63(true);
				6.54(3);
				6.41 = (1376)10;
				6.49 = 1065.Centre;
				6.3.Add(new 1445(1456.Fade, 0f, 1f, (int)((float)num * num3), (int)((float)(num + 500) * num3), (1046)0));
				6.3.Add(new 1445(1456.Fade, 1f, 0f, (int)((float)num2 * num3), (int)((float)(num2 + 500) * num3), (1046)0));
				list.Add(6);
				6 = new 1452(5, num4 * 2f, 2, 0.86f, false, 4);
				6.1 = (1044)1;
				6.28 = true;
				6.63(true);
				6.54(3);
				6.41 = (1376)10;
				6.49 = 1065.Centre;
				6.3.Add(new 1445(1456.Fade, 0f, 0.1f, (int)((float)num * num3), (int)((float)(num + 500) * num3), (1046)0));
				6.3.Add(new 1445(1456.Fade, 0.1f, 0f, (int)((float)num2 * num3), (int)((float)(num2 + 500) * num3), (1046)0));
				list.Add(6);
				num += 200;
				2.Y += 60f * (num4 / 40f);
			}
		}
		for (int k = 0; k < list.Count; k++)
		{
			bool flag = (k / 2 & 1) == 0;
			bool flag2 = k % 2 == 1;
			1452 7 = list[k];
			float num7 = 7.GetTextSize().X * 0.625f / 2f;
			1452 8 = 7;
			8.17.Y = 8.17.Y - (50f + 2.Y / 2f);
			if (flag)
			{
				7.3.Add(new 1445(7.17 - new 208(flag2 ? num7 : 50f, 0f), 7.17 - new 208(flag2 ? (0f - num7) : -50f, 0f), 7.3[0].9, 7.3[1].10, (1046)0));
			}
			else
			{
				7.3.Add(new 1445(7.17 - new 208(flag2 ? (0f - num7) : -50f, 0f), 7.17 - new 208(flag2 ? num7 : 50f, 0f), 7.3[0].9, 7.3[1].10, (1046)0));
			}
			this.75.12(7);
		}
	}

	// Token: 0x06002562 RID: 9570 RVA: 0x000B14F8 File Offset: 0x000AF6F8
	private void 56()
	{
		if (this.58.ShouldShowBreakSections())
		{
			1381 <<EMPTY_NAME>> = 1455.1(new string[]
			{
				"arrow-warning",
				"play-warningarrow"
			}, (1416)3);
			198 2 = (2630.21() && <<EMPTY_NAME>>.2.Contains("play-")) ? global::198.Red : global::198.White;
			208 3 = new 208(80f, 100f);
			this.25.Add(new 1433(<<EMPTY_NAME>>, (1376)6, 1065.Centre, (1044)1, 3, 1f, false, 2, null));
			this.25.Add(new 1433(<<EMPTY_NAME>>, (1376)12, 1065.Centre, (1044)1, 3, 1f, false, 2, null));
			this.25.Add(new 1433(<<EMPTY_NAME>>, (1376)8, 1065.Centre, (1044)1, 3, 1f, false, 2, null));
			this.25.Add(new 1433(<<EMPTY_NAME>>, (1376)14, 1065.Centre, (1044)1, 3, 1f, false, 2, null));
			this.25[2].45(true);
			this.25[3].45(true);
		}
	}

	// Token: 0x06002563 RID: 9571 RVA: 0x000B1604 File Offset: 0x000AF804
	internal void 57(int 1, int 2)
	{
		2486.2492 animations = new 2486.2492();
		animations.1 = new 1445(1456.Fade, 1f, 1f, 2, 2 + 100, (1046)0)
		{
			17 = true,
			11 = 100,
			12 = 3
		};
		animations.2 = new 1445(1456.Fade, 0f, 0f, 2 + 100, 2 + 200, (1046)0)
		{
			17 = true,
			11 = 100,
			12 = 3
		};
		this.25.ForEach(delegate(1433 1)
		{
			1.3.Add(animations.1);
			1.3.Add(animations.2);
		});
	}

	// Token: 0x06002564 RID: 9572 RVA: 0x000B16B0 File Offset: 0x000AF8B0
	private void 58()
	{
		double num = (double)this.39.34[0].1;
		double num2 = 1226.87(num);
		double num3 = 1226.88(num, true);
		if (num3 <= 0.0)
		{
			num3 = 1226.88(0.0, true);
		}
		if (num3 <= 0.0)
		{
			return;
		}
		double num4 = num2 - 5.0;
		double num5 = num3;
		if (num5 <= 333.0)
		{
			num5 *= 2.0;
		}
		if (this.139.38 == (1284)3)
		{
			num5 /= 2.0;
		}
		else if (this.139.38 == (1284)2)
		{
			num5 *= 2.0;
		}
		num -= num5 * (double)this.139.39;
		if (num4 >= num)
		{
			while (num4 > num - num5)
			{
				num4 -= num5;
			}
		}
		int num6 = 1;
		while (num4 < num - num5 / (double)num6)
		{
			num4 += num5;
			double num7 = (double)((float)(num4 - num2)) / num3 % 4.0;
			num6 = ((num7 <= 1.5 || num7 >= 3.5) ? 1 : 2);
		}
		num4 -= num5;
		bool flag = num4 - 4.0 * num5 > 0.0;
		int num8 = (int)num4;
		int num9 = (int)num5;
		2023 <<EMPTY_NAME>> = 2486.88.8;
		2023 2 = 2023.Target;
		bool flag2 = (<<EMPTY_NAME>> & 2) > 2023.None;
		if (flag2 || (flag && this.139.38 != (1284)0 && this.58.ShouldPlayCountdown() && !1304.55.1()))
		{
			this.67 = num8 - 6 * num9;
			this.68 = num8 - 3 * num9;
			1433 3 = new 1433(1455.2("ready", (1416)7, null), (1376)10, 1065.Centre, (1044)1, new 208(0f, 0f), 0.91f, false, global::198.TransparentWhite, null);
			if (!flag2)
			{
				1226.15.2(new 1255((int)((double)num8 - 5.9 * (double)num9), 1226.48("readys", false, true, (1416)7), 100, false));
			}
			3.3.Add(new 1445(1456.Fade, 0f, 1f, num8 - 6 * num9, num8 - 5 * num9, (1046)0));
			if (!2630.21())
			{
				3.3.Add(new 1445(1456.Scale, 3f, 1f, num8 - 6 * num9, num8 - 5 * num9, (1046)0));
				3.3.Add(new 1445(1456.Rotation, -0.4f, 0f, num8 - 6 * num9, num8 - 5 * num9, (1046)0));
			}
			3.3.Add(new 1445(1456.Fade, 1f, 0f, num8 - 4 * num9, num8 - 3 * num9, (1046)0));
			3.3.Add(new 1445(1456.Scale, 1f, 2630.21() ? 1.2f : 1.8f, num8 - 4 * num9, num8 - 3 * num9, (1046)0));
			1433 4 = new 1433(1455.2("count1", (1416)7, null), (1376)10, 1065.Centre, (1044)1, new 208(0f, 0f), 0.88f, false, global::198.TransparentWhite, null);
			1433 5 = new 1433(1455.2("count3", (1416)7, null), (1376)10, 2630.21() ? 1065.Centre : 1065.CentreRight, (1044)1, 2630.21() ? new 208(0f, 0f) : new 208((float)4.39 / -6.8f, 0f), 0.9f, false, global::198.TransparentWhite, null);
			1433 6 = new 1433(1455.2("count2", (1416)7, null), (1376)10, 2630.21() ? 1065.Centre : 1065.CentreLeft, (1044)1, 2630.21() ? new 208(0f, 0f) : new 208((float)4.39 / 6.8f, 0f), 0.89f, false, global::198.TransparentWhite, null);
			1433 7 = new 1433(1455.2("go", (1416)7, null), (1376)10, 1065.Centre, (1044)1, new 208(0f, 0f), 0.91f, false, global::198.TransparentWhite, null);
			if (!flag2)
			{
				if (1226.48("count3s", false, true, (1416)7) != -1)
				{
					1226.15.2(new 1255(num8 - 3 * num9, 1226.48("count3s", false, true, (1416)7), 100, false));
					1226.15.2(new 1255(num8 - 2 * num9, 1226.48("count2s", false, true, (1416)7), 100, false));
					1226.15.2(new 1255(num8 - num9, 1226.48("count1s", false, true, (1416)7), 100, false));
					1226.15.2(new 1255(num8, 1226.48("gos", false, true, (1416)7), 100, false));
				}
				else
				{
					1226.15.2(new 1255(num8 - 3 * num9, 1226.48("count", false, true, (1416)7), 100, false));
					1226.15.2(new 1255(num8 - 2 * num9, 1226.48("count", false, true, (1416)7), 100, false));
					1226.15.2(new 1255(num8 - num9, 1226.48("count", false, true, (1416)7), 100, false));
					1226.15.2(new 1255(num8, 1226.48("count", false, true, (1416)7), 100, false));
				}
			}
			5.3.Add(new 1445(1456.Fade, 0f, 1f, num8 - (int)(3.2 * (double)num9), num8 - 3 * num9, (1046)0));
			6.3.Add(new 1445(1456.Fade, 0f, 1f, num8 - (int)(2.2 * (double)num9), num8 - 2 * num9, (1046)0));
			4.3.Add(new 1445(1456.Fade, 0f, 1f, num8 - (int)(1.2 * (double)num9), num8 - num9, (1046)0));
			if (2630.21())
			{
				5.3.Add(new 1445(1456.Scale, 1.4f, 1f, num8 - (int)(3.2 * (double)num9), num8 - 3 * num9, (1046)0));
				6.3.Add(new 1445(1456.Scale, 1.4f, 1f, num8 - (int)(2.2 * (double)num9), num8 - 2 * num9, (1046)0));
				4.3.Add(new 1445(1456.Scale, 1.4f, 1f, num8 - (int)(1.2 * (double)num9), num8 - num9, (1046)0));
				5.3.Add(new 1445(1456.Fade, 1f, 0f, num8 - (int)(2.2 * (double)num9), num8 - (int)(2.0 * (double)num9), (1046)0));
				6.3.Add(new 1445(1456.Fade, 1f, 0f, num8 - (int)(1.2 * (double)num9), num8 - (int)((double)num9), (1046)0));
				4.3.Add(new 1445(1456.Fade, 1f, 0f, num8 - (int)(0.2 * (double)num9), num8 - (int)(0.0 * (double)num9), (1046)0));
			}
			else
			{
				5.3.Add(new 1445(1456.Fade, 1f, 0f, num8 - (int)(0.2 * (double)num9), num8 + (int)(0.2 * (double)num9), (1046)0));
				6.3.Add(new 1445(1456.Fade, 1f, 0f, num8 - (int)(0.2 * (double)num9), num8 + (int)(0.2 * (double)num9), (1046)0));
				4.3.Add(new 1445(1456.Fade, 1f, 0f, num8 - (int)(0.2 * (double)num9), num8 + (int)(0.2 * (double)num9), (1046)0));
			}
			if (2630.21())
			{
				7.3.Add(new 1445(1456.Scale, 1.4f, 1f, num8 - (int)(0.6 * (double)num9), num8 + (int)(0.2 * (double)num9), (1046)0));
				7.3.Add(new 1445(1456.Fade, 0f, 1f, num8 - (int)(0.2 * (double)num9), num8, (1046)0));
			}
			else
			{
				7.3.Add(new 1445(1456.Fade, 0f, 1f, num8 - (int)(0.6 * (double)num9), num8, (1046)0));
				1445 8 = new 1445(1456.Rotation, -4f, 0f, num8 - (int)(0.6 * (double)num9), num8 + (int)(0.2 * (double)num9), (1046)0);
				8.15 = (1046)1;
				7.3.Add(8);
				8 = new 1445(1456.Scale, 0.2f, 1f, num8 - (int)(0.6 * (double)num9), num8 + (int)(0.2 * (double)num9), (1046)0);
				8.15 = (1046)1;
				7.3.Add(8);
			}
			7.3.Add(new 1445(1456.Fade, 1f, 0f, num8 + (int)(0.3 * (double)num9), num8 + num9, (1046)0));
			3.33 = true;
			5.33 = true;
			6.33 = true;
			4.33 = true;
			7.33 = true;
			this.73.12(3);
			this.73.12(5);
			this.73.12(6);
			this.73.12(4);
			this.73.12(7);
			return;
		}
		if (this.39.34[0].1 > 6000)
		{
			int 9 = this.39.34[0].1 - this.39.LeadInPreemptTime - 900;
			int 10 = 5 + Math.Min(2, this.39.LeadInPreemptTime / 200);
			this.57(10, 9);
		}
	}

	// Token: 0x06002565 RID: 9573 RVA: 0x000B2130 File Offset: 0x000B0330
	private void 59(object 1)
	{
		if (1662.78 != 1677.Play)
		{
			return;
		}
		1281 2 = this.139.85;
		if (2 <= (1281)2)
		{
			if (2 != (1281)0 && 2 != (1281)2)
			{
				return;
			}
			this.139.80(new 1291(this.59));
			if (this.139.33 && !2486.57)
			{
				1763.2(1568.1(2679.Player_LazerOnlyWarning), 5000, (1389)1);
				return;
			}
		}
		else if (2 != (1281)6)
		{
			if (2 != (1281)7)
			{
				return;
			}
			if (!2486.57)
			{
				1763.2(1568.1(2679.Player_LovedWarning), 5000, (1389)1);
			}
		}
		else if (!2486.57)
		{
			1763.2(1568.1(2679.Player_QualifiedWarning), 5000, (1389)1);
			return;
		}
	}

	// Token: 0x06002566 RID: 9574 RVA: 0x000B21E4 File Offset: 0x000B03E4
	private void 60()
	{
		if (this.139.106 && !2486.57 && !1662.84)
		{
			1433 <<EMPTY_NAME>> = new 1433(1455.2("epilepsy", (1416)1, null), (1376)10, 1065.Centre, (1044)0, global::208.Zero, 1f, false, global::198.TransparentWhite, null);
			<<EMPTY_NAME>>.FadeIn(200, (1046)0, 0);
			<<EMPTY_NAME>>.3.Add(new 1445(1456.Fade, 1f, 0f, 1662.33 + 3000, 1662.33 + 3400, (1046)0));
			this.75.12(<<EMPTY_NAME>>);
			this.99.Add(<<EMPTY_NAME>>);
		}
	}

	// Token: 0x06002567 RID: 9575 RVA: 0x000B2290 File Offset: 0x000B0490
	protected virtual void LoadGameplay()
	{
		int num = 1662.33;
		switch (2486.14())
		{
		case 2147.Osu:
			if (2486.16())
			{
				this.58 = new 2146(this);
			}
			else
			{
				this.58 = new 2141(this);
			}
			break;
		case 2147.Taiko:
			this.58 = new 2187(this);
			break;
		case 2147.CatchTheBeat:
			this.58 = new 1883(this);
			break;
		case 2147.OsuMania:
			this.58 = new 1999(this);
			break;
		}
		2147 <<EMPTY_NAME>> = this.139.3();
		bool flag = this.139.59;
		this.139.65();
		bool flag2 = flag && <<EMPTY_NAME>> != this.139.3();
		2147 2 = 2486.14();
		if ((2 == 2147.Osu || 2 == 2147.CatchTheBeat) && 1272.5().65 >= 7000)
		{
			2023 3 = 2023.ScoreV2;
			2023 4 = 2019.1;
			2023 5 = 3;
			if ((4 & 5) <= 2023.None)
			{
				2019.1 |= 2023.ScoreV2;
			}
		}
		this.151(this.139, true);
		this.39 = this.58.5;
		this.60();
		if (!1535.1())
		{
			this.139.46 = DateTime.UtcNow;
			if (1662.54 != null)
			{
				1662.54.4();
			}
		}
		else
		{
			this.93 = true;
		}
		this.58.ApplyBeatmapSkinPreference();
		bool flag3 = false;
		try
		{
			this.62();
		}
		catch (1043)
		{
			flag3 = true;
		}
		this.39.45 = 2486.88.43;
		this.39.46 = 2486.88.44;
		this.39.47 = 2486.88.52;
		this.39.6(this.139, 2486.88.8);
		this.39.46(false, false);
		if (this.39.35 == 0 || (1226.81() != null && 1226.81().Count == 0))
		{
			base.Initialize();
			this.ReturnToSongSelect();
			1763.4(1568.1(2679.Player_CantLoadBeatmap));
			return;
		}
		foreach (2034 6 in this.39.34)
		{
			if (6.2 > this.84)
			{
				this.84 = 6.2;
			}
			if (6.1 < this.85)
			{
				this.85 = 6.1;
			}
		}
		this.34 = this.39.32;
		this.65();
		if (1535.1())
		{
			this.PrepareReplayPlayback();
		}
		this.58.Initialize();
		if (!1535.1())
		{
			this.PrepareReplayPlayback();
		}
		if (1662.54 != null)
		{
			this.58.3.3(new 1189(this.156));
		}
		this.58.SetPlayfieldOpacity(0f);
		this.151(this.139, false);
		this.39.37(true);
		250.5(this.39);
		2206.3(2486.88, 1272.5());
		if (1226.31 == null || 1226.31.IsDirectStream() || flag3)
		{
			this.ReturnToSongSelect();
			1763.4(1568.1(2679.Player_CantLoadAudio));
			return;
		}
		this.PrepareGameplayEffects();
		if (!this.133 && 1535.1() && !1535.40 && 1535.39.26.Count == 0)
		{
			1662.SetMode(1677.SelectPlay, false);
			1535.2(false);
			1763.4(1568.1(2679.Player_CantLoadReplay));
			return;
		}
		if (this.133)
		{
			this.58.GenerateAutoplayReplay();
			if (2486.22 && !1535.1())
			{
				2486.88.26 = new List<1840>();
				2486.88.23 = 1304.189;
			}
			else
			{
				1535.39 = 2486.88;
			}
		}
		1662.89.Schedule(new 1189(this.24), false);
		this.56();
		this.58();
		this.71();
		this.CreateSpectatorList();
		this.90 = this.154();
		this.LoadScoreboard();
		this.PrepareBreakIndicators();
		if (1304.95 || 1535.1())
		{
			2 = 2486.14();
			if (2 == 2147.Osu || 2 == 2147.CatchTheBeat)
			{
				this.86 = new 2547();
				2522.14("keys", "Key overlay", 2509.CentreRight, this.86.Layer, new 208(2528.WindowWidth, 200f));
			}
		}
		this.63();
		this.37();
		if (this.30 != null)
		{
			this.30.5();
		}
		if (this.98 && !this.134 && Thread.CurrentThread != 1662.106)
		{
			int 7 = ((this.139.85 == (1281)6) ? 5000 : 1000) - (1662.33 - num);
			this.61(7);
		}
		2486.57 = false;
		if (flag2)
		{
			2241 8 = 2486.88;
			if (8 == null)
			{
				return;
			}
			8.18();
		}
	}

	// Token: 0x06002568 RID: 9576 RVA: 0x000B27BC File Offset: 0x000B09BC
	private void 61(int 1)
	{
		int num = Environment.TickCount + 1;
		int num2 = 1;
		while (num2 > 0 && (this.94 == null || !this.94.IsDisposed))
		{
			Thread.Sleep(Math.Min(20, num2));
			num2 = num - Environment.TickCount;
		}
	}

	// Token: 0x06002569 RID: 9577 RVA: 0x000B2804 File Offset: 0x000B0A04
	protected virtual bool HandleBeatmapLoadCompleted(bool 1)
	{
		2486.<>c__DisplayClass228_0 CS$<>8__locals1;
		CS$<>8__locals1.<>4__this = this;
		1535.41 = 0;
		if (!1)
		{
			1662.SetMode(1662.90(), true);
			1763.5(1568.1(2679.Player_CantLoadBeatmap), global::198.Red, 5000, null);
			1619.1(new 1618(this.94.7));
			return true;
		}
		1662.105(this.139.49);
		2486.22(true);
		this.131 = true;
		if (2486.70 != null)
		{
			2486.70.28.ForEach(new Action<1371>(2486.2489.Instance.3));
		}
		CS$<>8__locals1.modAnimationDelay = 0;
		CS$<>8__locals1.modDepthOffset = 0f;
		CS$<>8__locals1.modPositionX = 30;
		2528 2 = 2522.3(2528.5("mods", "Mod icons", 2509.TopRight, new 208(2528.WindowWidth - (float)CS$<>8__locals1.modPositionX, 94f), true, null));
		2.32 = true;
		CS$<>8__locals1.modIcons = new 2536(2, 1535.1() && !2513.IsOpen);
		2528.2529 3 = 2528.20(2);
		foreach (object obj in Enum.GetValues(typeof(2023)))
		{
			2023 4 = (2023)obj;
			2023 5 = 2486.88.8;
			2023 6 = 4;
			if ((5 & 6) > 2023.None && (4 & 4 - 1) == 2023.None)
			{
				if (4 == 2023.DoubleTime)
				{
					2023 7 = 2486.88.8;
					6 = 2023.Nightcore;
					if ((7 & 6) > 2023.None)
					{
						continue;
					}
				}
				if (4 == 2023.SuddenDeath)
				{
					2023 8 = 2486.88.8;
					6 = 2023.Perfect;
					if ((8 & 6) > 2023.None)
					{
						continue;
					}
				}
				1445 9 = new 1445(1456.Scale, 2f, 1f, 1662.33 + CS$<>8__locals1.modAnimationDelay, 1662.33 + CS$<>8__locals1.modAnimationDelay + 400, (1046)0);
				9.15 = (1046)1;
				1445 item = new 1445(1456.Fade, 0f, 1f, 1662.33 + CS$<>8__locals1.modAnimationDelay, 1662.33 + CS$<>8__locals1.modAnimationDelay + 400, (1046)0);
				1433 10 = new 1433(1455.2("selection-mod-" + 4.ToString().ToLower(), (1416)7, null), (1376)8, 1065.Centre, (1044)0, new 208((float)CS$<>8__locals1.modPositionX, 94f), 0.9f + CS$<>8__locals1.modDepthOffset, 1535.1(), global::198.TransparentWhite, null);
				if (1535.1())
				{
					10.10 = true;
					10.3(new EventHandler(this.126));
					10.9 = (int)4;
					if (4 == 2023.Hidden && 2486.88.46)
					{
						10.52 = "Hidden: approach circles only";
					}
				}
				else
				{
					10.3.Add(new 1445(1456.Fade, 1f, 0f, 1662.33 + CS$<>8__locals1.modAnimationDelay, 1662.33 + CS$<>8__locals1.modAnimationDelay + 5000, (1046)0));
				}
				10.3.Add(item);
				10.3.Add(9);
				this.77.12(10);
				1452 11 = null;
				if ((4 == 2023.DoubleTime || 4 == 2023.Nightcore || 4 == 2023.HalfTime) && 2486.88.44 != null && Math.Abs(2486.88.44.Rate - 1939.17(4, null)) > 0.005)
				{
					1452 12 = new 1452(2486.88.44.1(), 12f, new 208((float)CS$<>8__locals1.modPositionX, 118f), 0.9f + CS$<>8__locals1.modDepthOffset, 1535.1(), global::198.TransparentWhite);
					12.41 = (1376)8;
					12.49 = 1065.Centre;
					12.63(true);
					if (!1535.1())
					{
						12.3.Add(new 1445(1456.Fade, 1f, 0f, 1662.33 + CS$<>8__locals1.modAnimationDelay, 1662.33 + CS$<>8__locals1.modAnimationDelay + 5000, (1046)0));
					}
					12.3.Add(new 1445(1456.Fade, 0f, 1f, 1662.33 + CS$<>8__locals1.modAnimationDelay, 1662.33 + CS$<>8__locals1.modAnimationDelay + 400, (1046)0));
					this.77.12(12);
					11 = 12;
				}
				CS$<>8__locals1.modIcons.1(10, 11);
				CS$<>8__locals1.modAnimationDelay += 500;
				CS$<>8__locals1.modDepthOffset += 1E-05f;
				CS$<>8__locals1.modPositionX += (1535.1() ? 50 : 10);
			}
		}
		if (2486.88.43 != null)
		{
			this.<HandleBeatmapLoadCompleted>g__AddExtraModIcon|228_0("selection-mod-difficultyadjust", 2486.88.43.IsEmpty ? "Difficulty Adjust" : ("Difficulty Adjust: " + 2486.88.43.1()), ref CS$<>8__locals1);
		}
		if (2486.88.45)
		{
			this.<HandleBeatmapLoadCompleted>g__AddExtraModIcon|228_0("selection-mod-nonotelock", "No Notelock: played with osu!lazer's note lock", ref CS$<>8__locals1);
		}
		if (2486.88.47 || (1535.1() && 1535.39 != null && 1535.39.47))
		{
			this.<HandleBeatmapLoadCompleted>g__AddExtraModIcon|228_0("selection-mod-practice", "Practice", ref CS$<>8__locals1);
		}
		if (2486.88.52 != null)
		{
			2147 13 = 2486.88.9;
			if (2486.88.52.5 != null)
			{
				this.<HandleBeatmapLoadCompleted>g__AddExtraModIcon|228_0("selection-mod-mirror", (13 == 2147.Taiko) ? "Mirror: dons and kats swapped" : ((13 == 2147.CatchTheBeat) ? "Mirror: fruits flipped horizontally" : ("Mirror: objects flipped (" + 1925.3(2486.88.52.5.Value) + ")")), ref CS$<>8__locals1);
			}
			if (2486.88.52.7 != null)
			{
				this.<HandleBeatmapLoadCompleted>g__AddExtraModIcon|228_0("selection-mod-random", (13 == 2147.Taiko || 13 == 2147.CatchTheBeat) ? string.Concat(new string[]
				{
					"Random: seed ",
					2486.88.52.7.4.ToString(),
					", randomness ",
					2486.88.52.7.9.ToString(),
					"%"
				}) : ("Random: seed " + 2486.88.52.7.4.ToString() + ", angle sharpness " + 2486.88.52.7.5.ToString("0.0", 1662.18)), ref CS$<>8__locals1);
			}
			if (2486.88.52.6 == 1930.Alternate)
			{
				this.<HandleBeatmapLoadCompleted>g__AddExtraModIcon|228_0("selection-mod-alternate", "Alternate: the same button cannot be used twice in a row", ref CS$<>8__locals1);
			}
			else if (2486.88.52.6 == 1930.SingleTap)
			{
				this.<HandleBeatmapLoadCompleted>g__AddExtraModIcon|228_0("selection-mod-singletap", "Single Tap: only one button can be used", ref CS$<>8__locals1);
			}
		}
		3.Dispose();
		CS$<>8__locals1.modIcons.Apply();
		this.58.OnModDisplayShown();
		return false;
	}

	// Token: 0x0600256A RID: 9578 RVA: 0x000B2F58 File Offset: 0x000B1158
	private void 62()
	{
		2023 <<EMPTY_NAME>> = 2486.88.8;
		2023 2 = 2023.Nightcore;
		1226.40 = ((<<EMPTY_NAME>> & 2) > 2023.None);
		1226.41 = (2486.88.44 != null && 2486.88.44.AdjustPitch);
		2023 3 = 2486.88.8;
		2 = 2023.DoubleTime;
		if ((3 & 2) > 2023.None)
		{
			1226.39(1939.17(2486.88.8, 2486.88.44) * 100.0);
		}
		else
		{
			2023 4 = 2486.88.8;
			2 = 2023.HalfTime;
			if ((4 & 2) > 2023.None)
			{
				1226.39(1939.17(2486.88.8, 2486.88.44) * 100.0);
			}
		}
		this.100 = 1226.31;
		if (this.100 != null)
		{
			this.101 = this.100.GetVolume();
		}
		if (1226.99(this.139, false, false, 1226.11() != this.139, false))
		{
			1226.Pause();
		}
		1226.5();
	}

	// Token: 0x0600256B RID: 9579 RVA: 0x000B3084 File Offset: 0x000B1284
	private void 63()
	{
		if ((!1662.84 || 1662.85 <= this.39.34[0].1) && 1535.41 <= 0)
		{
			return;
		}
		1226.22 = (double)this.137;
		for (int i = 0; i < this.39.35; i++)
		{
			if (this.39.34[i].2 <= 1226.16)
			{
				this.39.34[i].11 = true;
				this.58.6.SetHealth(this.39.34[i].13);
			}
		}
		2486.103 = 1226.73().3();
	}

	// Token: 0x0600256C RID: 9580 RVA: 0x000B314C File Offset: 0x000B134C
	protected void 64(int 1)
	{
		if (this.80 == (707)6 || this.80 == (707)7)
		{
			return;
		}
		1226.98();
		2023 2 = 2486.88.8;
		2023 3 = 2023.Nightcore;
		1226.40 = ((2 & 3) > 2023.None);
		1226.41 = (2486.88.44 != null && 2486.88.44.AdjustPitch);
		2023 4 = 2486.88.8;
		3 = 2023.DoubleTime;
		if ((4 & 3) > 2023.None)
		{
			1226.39(1939.17(2486.88.8, 2486.88.44) * 100.0);
		}
		else
		{
			2023 5 = 2486.88.8;
			3 = 2023.HalfTime;
			if ((5 & 3) > 2023.None)
			{
				1226.39(1939.17(2486.88.8, 2486.88.44) * 100.0);
			}
		}
		1226.46(100, false);
		if (this.137 > 1)
		{
			1226.7(-this.137, false);
		}
		else
		{
			1226.22 = (double)this.137;
			1226.4(1, false, false);
		}
		this.130 = true;
	}

	// Token: 0x0600256D RID: 9581 RVA: 0x000B327C File Offset: 0x000B147C
	private void 65()
	{
		this.132 = 0;
		if (1662.84)
		{
			this.132 = 1662.85;
		}
		else if (1535.1() && 1535.41 > 0)
		{
			this.132 = 1535.41 + 5;
		}
		this.137 = this.139.19;
		this.137 = Math.Max(-this.34.32, this.137);
		int num = (2486.11 == 2147.OsuMania) ? 1800 : Math.Max(1800, this.39.LeadInPreemptTime);
		int num2 = (this.39.34.Count > 0) ? this.39.34[0].1 : 0;
		this.137 = Math.Max(num - num2, this.137);
		if (this.139.32 > 3 && 1226.70 >= 0)
		{
			1226.59(1226.81()[1226.71].4, false);
		}
		if (this.139.72 != 0)
		{
			1763.2(string.Format(1568.1(2679.Player_LocalBeatmapOffset), this.139.72), 1000, (1389)0);
		}
		1226.70(true);
	}

	// Token: 0x0600256E RID: 9582 RVA: 0x000B33C4 File Offset: 0x000B15C4
	protected virtual void PrepareGameplayEffects()
	{
		1455.5("lighting", (1416)7, true);
		this.81 = 1455.2("star2", (1416)7, null);
		this.127 = 2630.5.Colours["StarBreakAdditive"];
		this.58.PreloadJudgementTextures();
	}

	// Token: 0x0600256F RID: 9583 RVA: 0x000B3415 File Offset: 0x000B1615
	protected virtual bool ReturnToSongSelect()
	{
		1662.SetMode(1677.SelectPlay, false);
		return true;
	}

	// Token: 0x06002570 RID: 9584 RVA: 0x0001702D File Offset: 0x0001522D
	protected virtual bool CanFinishLoadingTransition()
	{
		return true;
	}

	// Token: 0x06002571 RID: 9585 RVA: 0x000B3420 File Offset: 0x000B1620
	internal bool 66()
	{
		if (this.94 == null)
		{
			return false;
		}
		if (this.94.3)
		{
			return false;
		}
		this.94.Update();
		2563 <<EMPTY_NAME>> = this.30;
		if (<<EMPTY_NAME>> != null)
		{
			<<EMPTY_NAME>>.Update();
		}
		if (this.100 != null)
		{
			if (this.101 > (this.131 ? 0f : 0.4f))
			{
				this.101 -= (float)(0.02 * 1662.10);
			}
			this.100.SetVolume(Math.Max(0f, this.101));
		}
		if (this.131 && 2486.136)
		{
			1662.89(1662.78, true, 0);
			this.131 = false;
			return true;
		}
		if (this.131 && this.CanFinishLoadingTransition() && (this.100 == null || this.101 <= 0f) && (2486.70 == null || 2486.70.28.Count == 0 || 2486.70.28.TrueForAll(new Predicate<1371>(2486.2489.Instance.10))) && (this.30 == null || !this.30.7) && !2493.IsOpen)
		{
			this.94.2();
			2486.109 = true;
			1226.5 = true;
			1226.5();
			if (this.137 > this.132)
			{
				1226.7(-this.137, true);
			}
			2648 2 = this.34;
			if (2 != null)
			{
				2.39();
			}
			1662.89.2(new 1189(this.67), (!1662.84 && !1535.1()) ? 1196.2(0, 600) : 0, false);
		}
		else if (1662.84 && this.132 >= this.137)
		{
			1226.16 = this.132;
			1226.17 = this.132;
		}
		else
		{
			1226.16 = -this.137;
			1226.17 = -this.137;
			1380 3 = this.54;
			if (3 != null)
			{
				3.SetProgress((float)((this.137 != 0) ? -1 : 0));
			}
		}
		2648 4 = this.34;
		if (4 != null)
		{
			4.16();
		}
		return true;
	}

	// Token: 0x06002572 RID: 9586 RVA: 0x000B365E File Offset: 0x000B185E
	private void 67()
	{
		if (this.100 != null && 1226.31 != this.100 && this.100.IsDirectStream())
		{
			this.100.Dispose();
		}
		this.64(this.132);
	}

	// Token: 0x06002573 RID: 9587 RVA: 0x000B3699 File Offset: 0x000B1899
	internal bool 68()
	{
		return this.66 != null && this.66.IsHovered();
	}

	// Token: 0x06002574 RID: 9588 RVA: 0x000B36B0 File Offset: 0x000B18B0
	public static bool 69()
	{
		return 2486.7 != null && 2486.7.67 > 0 && 1226.16 < 2486.7.67;
	}

	// Token: 0x06002575 RID: 9589 RVA: 0x000B36DC File Offset: 0x000B18DC
	private void 70(object 1, EventArgs 2)
	{
		if (!2486.13)
		{
			if (!2486.14)
			{
				return;
			}
			this.RequestPauseToggle();
		}
		if (this.50 == null)
		{
			return;
		}
		using (List<1433>.Enumerator enumerator = this.50.FindAll(new Predicate<1433>(2486.2489.Instance.2)).GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				2486.2488 activation = new 2486.2488();
				activation.1 = enumerator.Current;
				if (1662.11.2())
				{
					1662.89.2(delegate
					{
						activation.1.10 = true;
						activation.1.39(global::198.White, 100, false, (1046)0);
					}, 500, false);
				}
				else
				{
					activation.1.10 = false;
					activation.1.39(global::198.DarkGray, 100, false, (1046)0);
				}
			}
		}
	}

	// Token: 0x06002576 RID: 9590 RVA: 0x000B37D0 File Offset: 0x000B19D0
	private void 71()
	{
		this.66 = new 1351(1455.5("play-skip", (1416)7, true), (1376)8, 1065.BottomRight, (1044)0, new 208(0f, 480f), 1662.70.7() > false, true, new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 153));
		this.66.61();
		this.66.3(new EventHandler(this.78));
		this.66.10 = (this.30 == null);
		this.66.42 = new 1445(1456.Fade, 0.6f, 1f, 0, 300, (1046)0);
		this.66.16 = 0f;
		int num = this.67;
		if (this.67 == 0)
		{
			int num2 = this.67 = 1226.16;
			num = ((!1226.75()) ? (this.39.34[0].1 - 2000) : ((int)((double)this.39.34[0].1 - 1226.76() * (double)((1226.76() < 500.0) ? 8 : 4))));
		}
		if (num - Math.Min(this.132, -this.137) > 1200 + this.39.LeadInPreemptTime)
		{
			this.67 = num;
			this.66.FadeIn(400, (1046)0, 0);
			this.79.12(this.66);
			this.80 = (707)1;
		}
		else
		{
			this.80 = (707)2;
			this.67 = 0;
		}
		if (!1535.1() || (1535.40 && 1535.41 == 0))
		{
			2486.88.26.Insert(0, new 1840(0, 256f, -500f, 1572.None));
			2486.88.26.Insert(1, new 1840(this.67 - 1, 256f, -500f, 1572.None));
		}
		else if (2486.15 > 0)
		{
			this.TrySkip();
		}
		this.145 = new 1351(1455.5("play-skip", (1416)7, true), (1376)8, 1065.BottomRight, (1044)0, new 208(0f, 480f), 1662.70.7() > false, true, new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 153));
		this.145.61();
		this.145.3(new EventHandler(this.78));
		this.145.10 = false;
		this.145.42 = new 1445(1456.Fade, 0.6f, 1f, 0, 300, (1046)0);
		this.145.16 = 0f;
		this.79.12(this.145);
	}

	// Token: 0x06002577 RID: 9591 RVA: 0x000B3AAC File Offset: 0x000B1CAC
	private int 72()
	{
		2275 <<EMPTY_NAME>> = 2648.5;
		if (!1304.56.1() || <<EMPTY_NAME>> == null || 1535.1() || this.46 || 2486.13 || 2486.83 || !this.130 || 1662.78 != 1677.Play)
		{
			return -1;
		}
		int num = 1226.16;
		int num2 = <<EMPTY_NAME>>.1 - 1000;
		if (num < <<EMPTY_NAME>>.8 + 500 || num2 - num < 1500)
		{
			return -1;
		}
		return num2;
	}

	// Token: 0x06002578 RID: 9592 RVA: 0x000B3B2C File Offset: 0x000B1D2C
	private void 73()
	{
		if (this.145 == null)
		{
			return;
		}
		bool flag = this.72() >= 0;
		if (flag == this.146)
		{
			return;
		}
		this.146 = flag;
		this.145.3.Clear();
		this.145.10 = flag;
		if (flag)
		{
			this.145.FadeIn(300, (1046)0, 0);
			return;
		}
		this.145.SetHovered(false);
		this.145.16(200, (1046)0, 0);
	}

	// Token: 0x06002579 RID: 9593 RVA: 0x000B3BB0 File Offset: 0x000B1DB0
	private bool 74()
	{
		int num = this.72();
		if (num < 0)
		{
			return false;
		}
		1226.28("menuhit", 1f, (1416)3);
		1226.110();
		1226.4(num, false, false);
		this.73();
		return true;
	}

	// Token: 0x0600257A RID: 9594 RVA: 0x000B3BF0 File Offset: 0x000B1DF0
	internal void 75()
	{
		if (2486.13 || 2486.4 || 1535.1())
		{
			2486.77();
			return;
		}
		if (!this.130 || this.46 || 2486.83)
		{
			return;
		}
		this.148 = true;
		this.RequestPauseToggle();
	}

	// Token: 0x0600257B RID: 9595 RVA: 0x000B3C3D File Offset: 0x000B1E3D
	private void 76()
	{
		if (!this.148)
		{
			return;
		}
		if (2486.13)
		{
			this.148 = false;
			2486.77();
			return;
		}
		if (!this.107)
		{
			this.148 = false;
		}
	}

	// Token: 0x0600257C RID: 9596 RVA: 0x000B3C6B File Offset: 0x000B1E6B
	private static void 77()
	{
		1662.104.49(false);
		1662.104.16(true);
	}

	// Token: 0x0600257D RID: 9597 RVA: 0x000B3C83 File Offset: 0x000B1E83
	private void 78(object 1, EventArgs 2)
	{
		1662.89.2(new 1189(this.87), 1196.2(0, 300), false);
	}

	// Token: 0x0600257E RID: 9598 RVA: 0x000B3CA8 File Offset: 0x000B1EA8
	internal static void 79()
	{
		if (2486.7 != null)
		{
			2486.15 = Math.Max(0, 2486.15) + 1;
		}
	}

	// Token: 0x0600257F RID: 9599 RVA: 0x000B3CC4 File Offset: 0x000B1EC4
	internal virtual bool TrySkip()
	{
		if (1662.78 != 1677.Play || 2486.13 || 2486.83 || !this.130)
		{
			return false;
		}
		if (1226.16 < this.67 && !this.46)
		{
			if (2486.6 || this.80 != (707)1)
			{
				return false;
			}
			1662.75 = 80.0;
			1662.76 = (932)1;
			1226.28("menuhit", 1f, (1416)3);
			this.54();
			bool flag = this.80();
			if (!flag)
			{
				2486.6 = true;
				this.66.10 = false;
				this.80 = (707)2;
			}
			int <<EMPTY_NAME>> = (!flag) ? (this.67 + 1196.2(-80, 90)) : 0;
			1226.110();
			1226.4(<<EMPTY_NAME>>, false, false);
			if (!flag)
			{
				this.58.RecoverHealthForBreak();
			}
			2486.15--;
		}
		else if ((!this.147 || !this.74()) && 2486.126 && !this.38)
		{
			this.38 = true;
			1226.28("menuhit", 1f, (1416)3);
			this.12();
			this.80 = (707)6;
		}
		return true;
	}

	// Token: 0x06002580 RID: 9600 RVA: 0x000B3DF0 File Offset: 0x000B1FF0
	protected bool 80()
	{
		int num = (this.137 < 10000) ? (-this.137) : 0;
		return 1226.16 < num - (1535.1() ? 50 : 0) && this.67 > 6000;
	}

	// Token: 0x06002581 RID: 9601 RVA: 0x000B3E3C File Offset: 0x000B203C
	private bool 81(int 1)
	{
		if (6 != 0)
		{
			if (this.128 < 0)
			{
				this.128 = ((6 == -1) ? 2 : ((2486.4 > false) ? 1 : 0));
				1381 2 = 1455.1(new string[]
				{
					"arrow-pause",
					"play-warningarrow"
				}, (1416)3);
				198 3 = (1662.112 && 2.2.Contains("play-warningarrow")) ? new 198(0, 114, byte.MaxValue) : global::198.White;
				1433 4 = new 1433(2, (1376)10, 1065.Centre, (1044)0, new 208(-170f, this.50[this.128 + 2].17.Y), 1f, true, 3, null);
				4.15 = 0.8f;
				4.15(300);
				4.3.Add(new 1445(1456.MovementX, 4.17.X - 170f, 4.17.X, 1662.33, 1662.33 + 300, (1046)2));
				1445 5 = new 1445(1456.MovementX, 4.17.X, 4.17.X - 45f, 1662.33 + 300, 1662.33 + 600, (1046)1);
				5.17 = true;
				5.11 = 300;
				5.16 = 101;
				4.3.Add(5);
				5 = new 1445(1456.MovementX, 4.17.X - 45f, 4.17.X, 1662.33 + 600, 1662.33 + 900, (1046)2);
				5.17 = true;
				5.11 = 300;
				5.16 = 102;
				4.3.Add(5);
				this.78.12(4);
				this.129.Add(4);
				4 = new 1433(2, (1376)10, 1065.Centre, (1044)0, new 208(170f, this.50[this.128 + 2].17.Y), 1f, true, 3, null);
				4.45(true);
				4.15 = 0.8f;
				4.15(300);
				4.3.Add(new 1445(1456.MovementX, 4.17.X + 170f, 4.17.X, 1662.33, 1662.33 + 300, (1046)2));
				5 = new 1445(1456.MovementX, 4.17.X, 4.17.X + 45f, 1662.33 + 300, 1662.33 + 600, (1046)1);
				5.17 = true;
				5.11 = 300;
				5.16 = 201;
				4.3.Add(5);
				5 = new 1445(1456.MovementX, 4.17.X + 45f, 4.17.X, 1662.33 + 600, 1662.33 + 900, (1046)2);
				5.17 = true;
				5.11 = 300;
				5.16 = 202;
				4.3.Add(5);
				this.78.12(4);
				this.129.Add(4);
			}
			else
			{
				1226.24("pause-hover", 100, (1416)3, false);
				this.128 = (2486.4 ? ((this.128 + 6 + 1) % 2 + 1) : ((this.128 + 6 + 3) % 3));
				this.129.ForEach(delegate(1433 1)
				{
					1.3.RemoveAll(new Predicate<1445>(2486.2489.Instance.4));
					1.3.Add(new 1445(1456.MovementY, 1.17.Y, this.50[this.128 + 2].17.Y, 1662.33, 1662.33 + 100, (1046)1));
				});
			}
			return true;
		}
		switch (this.128)
		{
		case 0:
			this.51.1(true);
			return true;
		case 1:
			this.52.1(true);
			return true;
		case 2:
			this.53.1(true);
			return true;
		default:
			this.RequestPauseToggle();
			return true;
		}
	}

	// Token: 0x06002582 RID: 9602 RVA: 0x000B425F File Offset: 0x000B245F
	internal virtual void RequestPauseToggle()
	{
		if (!this.107)
		{
			this.107 = true;
			this.108 = (long)1226.16;
		}
	}

	// Token: 0x06002583 RID: 9603 RVA: 0x000B427C File Offset: 0x000B247C
	private void 82()
	{
		if ((!2486.13 && this.10 && (long)1226.16 - this.108 < 1000L) || !this.107)
		{
			return;
		}
		this.107 = false;
		if (this.71 == null || (2486.4 && 2486.13) || !this.130)
		{
			return;
		}
		if (!1226.4 && !1662.84 && !2486.4 && !1535.1() && !2486.83 && !2486.13 && !2648.6 && this.40 != 0 && 1226.16 - this.40 < 1000)
		{
			1763.4(1568.1(2679.Player_WaitBeforePausing));
			return;
		}
		if (this.46)
		{
			this.12();
			return;
		}
		2486.13 = !2486.13;
		this.128 = -1;
		2486.22(!2486.13);
		if (!2486.13)
		{
			2486.83 = true;
			1256 <<EMPTY_NAME>> = this.106;
			if (<<EMPTY_NAME>> != null)
			{
				<<EMPTY_NAME>>.Pause();
			}
			this.129.ForEach(new Action<1433>(2486.2489.Instance.9));
			this.129.Clear();
			if (1226.4 || 1535.1() || this is 2485 || this.58.CanResumeWithoutCursorClick() || 2486.22 || 2486.21 || this.174)
			{
				this.82 = true;
			}
			else if (this.47 == null)
			{
				if (!2648.6)
				{
					this.47 = new 1367(1455.2("cursor", (1416)1, null), this.49, 0.99f, true, global::198.Orange, 20);
					this.47.41 = (1376)16;
					this.47.10 = true;
					this.47.52 = 1568.1(2679.Player_ClickToResume);
					this.47.15 = 1.2f;
					this.47.42 = new 1445(global::198.Orange, global::198.White, 0, 200);
					this.47.3(delegate(object 1, EventArgs 2)
					{
						if (!this.50[0].19)
						{
							((1433)1).10 = false;
							this.82 = true;
						}
					});
					this.47.8 = "pausecursor";
					this.71.12(this.47);
					this.47 = new 1433(1455.2("cursor", (1416)1, null), (1376)16, 1065.Centre, (1044)0, this.49, 1f, true, global::198.Orange, null);
					this.47.8 = "pausecursor";
					this.47.28 = true;
					this.71.12(this.47);
					1445 8 = new 1445(1456.Scale, 1.2f, 3f, 1662.33, 1662.33 + 1000, (1046)0);
					8.17 = true;
					this.47.3.Add(8);
					8 = new 1445(1456.Fade, 1f, 0f, 1662.33, 1662.33 + 1000, (1046)1);
					8.17 = true;
					this.47.3.Add(8);
					this.48 = new 1433(1455.2("unpause", (1416)1, null), (1376)10, 1065.Centre, (1044)0, global::208.Zero, 0.9f, true, global::198.White, null);
					this.71.12(this.48);
					this.48.8 = "pausecursor";
				}
				else
				{
					this.82 = true;
				}
			}
			if (this.50 != null)
			{
				this.50[0].16((!1662.47) ? 800 : 0, (1046)0, 0);
				this.50[1].16((!1662.47) ? 800 : 0, (1046)0, 0);
				this.50[2].16((!1662.47) ? 300 : 0, (1046)0, 0);
				this.50[3].16((!1662.47) ? 300 : 0, (1046)0, 0);
				if (this.50.Count > 4)
				{
					this.50[2].10 = false;
					this.50[3].10 = false;
					this.50[4].10 = false;
					this.50[4].16((!1662.47) ? 300 : 0, (1046)0, 0);
				}
			}
			return;
		}
		if (this.106 == null)
		{
			this.106 = 1226.29(1226.48("pause-loop", true, true, (1416)7), 0, 0f, false, 1f, false);
		}
		else
		{
			this.106.Play(true, false);
		}
		if (this.106 != null)
		{
			this.106.2(0f);
		}
		if (this.47 == null)
		{
			this.49 = new 208(1052.19(1535.6.X, 1f, (float)(1662.70.1 - 1)), 1052.19(1535.6.Y, 1f, (float)(1662.70.2 - 1)));
		}
		this.85();
		this.40 = 1226.16;
		foreach (2034 3 in this.39.36)
		{
			3.StopHitSounds();
		}
		this.66.10 = false;
		if (!1226.10())
		{
			1226.107();
		}
		if (this.50 == null)
		{
			this.50 = new List<1433>();
			1433 4 = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, global::208.Zero, 0.98f, true, global::198.TransparentBlack, null);
			4.20 = new 208((float)1662.70.1, (float)1662.70.2);
			4.66 = false;
			this.50.Add(4);
			string text = "pause-overlay";
			1381 5 = null;
			if (!2630.13)
			{
				5 = 1455.2(text + ".jpg", (1416)4, null);
			}
			if (5 == null)
			{
				5 = 1455.2(text, (1416)7, null);
			}
			4 = new 1433(5, (1376)10, 1065.Centre, (1044)0, global::208.Zero, 0.985f, true, global::198.TransparentWhite, null);
			this.50.Add(4);
			if (1535.1())
			{
				4 = new 1433(1455.2("menu-nekiosu", (1416)1, null), (1376)10, 1065.Centre, (1044)0, global::208.Zero, 0.99f, true, new 198(100, 100, 100, 0), null);
				if (1662.47)
				{
					4.9(true);
				}
				4.15 = 0.6f;
				this.50.Add(4);
				2486.23 = new 1452(string.Empty, 20f, new 208((float)(1662.70.1() / 2), 240f), 1f, true, global::198.TransparentWhite);
				if (1662.47)
				{
					2486.23.9(true);
				}
				2486.23.49 = 1065.Centre;
				this.50.Add(2486.23);
			}
			else
			{
				this.51 = new 1433(1455.2("pause-continue", (1416)7, null), (1376)10, 1065.Centre, (1044)0, new 208(0f, -100f), 0.998f, true, global::198.TransparentWhite, null);
				this.51.35(new EventHandler(2486.2489.Instance.5));
				this.51.3(new EventHandler(this.88));
				this.51.3(new EventHandler(this.84));
				this.51.10 = true;
				this.51.42 = new 1445(1456.Scale, 1f, 1.1f, 0, 120, (1046)1);
				this.51.42.15 = (1046)1;
				this.50.Add(this.51);
				this.52 = new 1433(1455.2("pause-retry", (1416)7, null), (1376)10, 1065.Centre, (1044)0, new 208(0f, 10f), 0.998f, true, global::198.TransparentWhite, null);
				this.52.35(delegate(object 1, EventArgs 2)
				{
					if (1662.11.2())
					{
						1226.27(new string[]
						{
							"pause-retry-hover",
							"pause-hover"
						});
					}
				});
				this.52.8 = "retry";
				this.52.3(new EventHandler(2486.2489.Instance.6));
				this.52.3(new EventHandler(this.84));
				this.52.10 = true;
				this.52.42 = new 1445(1456.Scale, 1f, 1.1f, 0, 120, (1046)1);
				this.52.42.15 = (1046)1;
				this.50.Add(this.52);
				this.53 = new 1433(1455.2("pause-back", (1416)7, null), (1376)10, 1065.Centre, (1044)0, new 208(0f, 120f), 0.998f, true, global::198.TransparentWhite, null);
				this.53.35(new EventHandler(2486.2489.Instance.7));
				this.53.8 = "back";
				this.53.3(new EventHandler(2486.2489.Instance.8));
				this.53.3(new EventHandler(this.84));
				this.53.10 = true;
				this.53.42 = new 1445(1456.Scale, 1f, 1.1f, 0, 120, (1046)1);
				this.53.42.15 = (1046)1;
				this.50.Add(this.53);
			}
			this.78.14<1433>(this.50);
		}
		if (1535.1())
		{
			this.50[0].3.Add(new 1445(1456.Fade, 0f, 0.5f, 1662.33, 1662.33 + 500, (1046)0));
			this.50[2].FadeIn(500, (1046)0, 0);
			this.50[3].FadeIn(500, (1046)0, 0);
			return;
		}
		this.50[0].3.Clear();
		if (2630.21())
		{
			this.50[0].3.Add(new 1445(1456.Fade, this.50[0].16, 0.8f, 1662.33, 1662.33 + 300, (1046)0));
		}
		else
		{
			this.50[0].3.Add(new 1445(1456.Fade, this.50[0].16, 0.95f, 1662.33, 1662.33 + 300, (1046)0));
		}
		if (!2486.4)
		{
			this.50[1].FadeIn(300, (1046)0, 0);
			this.50[2].FadeIn(300, (1046)0, 0);
		}
		else
		{
			1433 6 = new 1433(1455.2("fail-background", (1416)7, null), (1376)10, 1065.Centre, (1044)0, global::208.Zero, 0.985f, true, global::198.TransparentWhite, null);
			6.15 = 768f / (float)6.38;
			6.15(600);
			this.78.12(6);
			1452 7 = new 1452(1568.1(2679.Player_PressToViewReplay) + "\nPress F2 to save replay", 16f, new 208(10f, 10f), 0.987f, true, global::198.White);
			7.54(true);
			7.63(true);
			this.78.12(7);
		}
		this.50[3].FadeIn(300, (1046)0, 0);
		this.50[4].FadeIn(300, (1046)0, 0);
		this.50[2].10 = true;
		this.50[3].10 = true;
		this.50[4].10 = true;
	}

	// Token: 0x06002584 RID: 9604 RVA: 0x000B4E9C File Offset: 0x000B309C
	internal static void 83(bool 1)
	{
		1226.24("pause-retry-click", 100, (1416)3, false);
		2486.57 = true;
		2486 2 = 2486.7;
		if (2 != null)
		{
			2.100();
		}
		if (2486.7 != null)
		{
			2486.7.80 = (707)6;
		}
		if (1)
		{
			2486.79();
			1662.SetMode(1677.Play, true);
			1662.75 = 100.0;
			return;
		}
		1662.SetMode(1677.Play, true);
	}

	// Token: 0x06002585 RID: 9605 RVA: 0x000B4F08 File Offset: 0x000B3108
	private void 84(object 1, EventArgs 2)
	{
		1433 3 = 1 as 1433;
		if (3 != null)
		{
			1433 4 = 3.Clone();
			4.2 += 0.001f;
			4.28 = true;
			4.17(400);
			4.5 = false;
			4.25(4.15 * 1.01f, 400, (1046)0);
			this.78.12(4);
		}
	}

	// Token: 0x06002586 RID: 9606 RVA: 0x000B4F77 File Offset: 0x000B3177
	private void HandleResumeCursorClicked(object 1, EventArgs 2)
	{
		if (!this.50[0].19)
		{
			((1433)1).10 = false;
			this.82 = true;
		}
	}

	// Token: 0x06002587 RID: 9607 RVA: 0x000B4F9F File Offset: 0x000B319F
	protected virtual void HideSkipButton()
	{
		this.66.SetHovered(false);
		this.66.10 = false;
		this.66.3.Clear();
		this.66.16(200, (1046)0, 0);
	}

	// Token: 0x06002588 RID: 9608 RVA: 0x000B4FDC File Offset: 0x000B31DC
	private void 85()
	{
		if (this.47 != null)
		{
			foreach (1371 <<EMPTY_NAME>> in this.71.16("pausecursor"))
			{
				1433 2 = (1433)<<EMPTY_NAME>>;
				2.5 = false;
				2.16(40, (1046)0, 0);
			}
			this.47 = null;
			this.48 = null;
		}
		2486.83 = false;
		this.82 = false;
	}

	// Token: 0x06002589 RID: 9609 RVA: 0x000B506C File Offset: 0x000B326C
	private bool 86(object 1, EventArgs 2)
	{
		if (1662.76 == (932)0)
		{
			return false;
		}
		if (1555.6() == global::199.Pressed && 1662.78 == 1677.Play && !1304.105 && !1535.1())
		{
			this.RequestPauseToggle();
			return true;
		}
		return false;
	}

	// Token: 0x0600258A RID: 9610 RVA: 0x000B50A4 File Offset: 0x000B32A4
	private void 87()
	{
		this.147 = true;
		try
		{
			this.TrySkip();
		}
		finally
		{
			this.147 = false;
		}
	}

	// Token: 0x0600258B RID: 9611 RVA: 0x000B50DC File Offset: 0x000B32DC
	private void 88(object 1, EventArgs 2)
	{
		1226.28("pause-continue-click", 1f, (1416)3);
		this.RequestPauseToggle();
	}

	// Token: 0x1700023A RID: 570
	// (get) Token: 0x0600258C RID: 9612 RVA: 0x000B50F8 File Offset: 0x000B32F8
	internal bool CanPracticeSeek
	{
		get
		{
			return 2486.88 != null && 2486.88.47 && !1535.1() && this.39 != null && this.39.34.Count > 0 && 2486.109 && this.130 && !this.46 && !2486.4 && !2486.45 && !2486.13 && !2486.83 && this.80 != (707)6 && this.80 != (707)7;
		}
	}

	// Token: 0x1700023B RID: 571
	// (get) Token: 0x0600258D RID: 9613 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal bool IsPracticeShiftLocked
	{
		get
		{
			return false;
		}
	}

	// Token: 0x0600258E RID: 9614 RVA: 0x000B5184 File Offset: 0x000B3384
	private void 89()
	{
		this.158 = false;
	}

	// Token: 0x1700023C RID: 572
	// (get) Token: 0x0600258F RID: 9615 RVA: 0x000B518D File Offset: 0x000B338D
	internal bool IsPracticeHeld
	{
		get
		{
			return this.156 && this.157 == null;
		}
	}

	// Token: 0x1700023D RID: 573
	// (get) Token: 0x06002590 RID: 9616 RVA: 0x000B51A8 File Offset: 0x000B33A8
	internal int? PracticeJumpTime
	{
		get
		{
			2241 <<EMPTY_NAME>> = 2486.88;
			if (<<EMPTY_NAME>> == null)
			{
				return null;
			}
			return <<EMPTY_NAME>>.48;
		}
	}

	// Token: 0x1700023E RID: 574
	// (get) Token: 0x06002591 RID: 9617 RVA: 0x000B51CD File Offset: 0x000B33CD
	internal List<1937> PracticeSegmentList
	{
		get
		{
			1262 <<EMPTY_NAME>> = 1272.5();
			return 1935.1((<<EMPTY_NAME>> != null) ? <<EMPTY_NAME>>.23 : null);
		}
	}

	// Token: 0x1700023F RID: 575
	// (get) Token: 0x06002592 RID: 9618 RVA: 0x000B51E5 File Offset: 0x000B33E5
	internal 1937? ActivePracticeSegment
	{
		get
		{
			if (this.154 == null)
			{
				return this.169;
			}
			return this.168;
		}
	}

	// Token: 0x17000240 RID: 576
	// (get) Token: 0x06002593 RID: 9619 RVA: 0x000B5204 File Offset: 0x000B3404
	internal int? PracticeObjectsEnd
	{
		get
		{
			if (!1535.1())
			{
				if (2486.88 == null || !2486.88.47)
				{
					return null;
				}
				return this.170;
			}
			else
			{
				2241 <<EMPTY_NAME>> = 1535.39;
				if (<<EMPTY_NAME>> == null || !<<EMPTY_NAME>>.47 || <<EMPTY_NAME>>.49 == null || this.39 == null)
				{
					return null;
				}
				int? num = this.172;
				int? num2 = <<EMPTY_NAME>>.49;
				if (!(num.GetValueOrDefault() == num2.GetValueOrDefault() & num != null == (num2 != null)))
				{
					this.172 = <<EMPTY_NAME>>.49;
					this.173 = this.92(<<EMPTY_NAME>>.48.GetValueOrDefault(int.MinValue), <<EMPTY_NAME>>.49.Value);
				}
				return new int?(this.173);
			}
		}
	}

	// Token: 0x17000241 RID: 577
	// (get) Token: 0x06002594 RID: 9620 RVA: 0x000B52DB File Offset: 0x000B34DB
	private bool IsPracticeLooping
	{
		get
		{
			return !1535.1() && this.169 != null && 1304.27.1();
		}
	}

	// Token: 0x06002595 RID: 9621 RVA: 0x000B5300 File Offset: 0x000B3500
	private static int 90(2034 1)
	{
		1866 2 = 1 as 1866;
		if (2 == null || 2.52 == -2147483648)
		{
			return 1.1;
		}
		return 2.52;
	}

	// Token: 0x06002596 RID: 9622 RVA: 0x000B5334 File Offset: 0x000B3534
	private static int 91(2034 1)
	{
		1866 2 = 1 as 1866;
		if (2 == null || 2.52 == -2147483648)
		{
			return 1.2;
		}
		return 2.53;
	}

	// Token: 0x06002597 RID: 9623 RVA: 0x000B5368 File Offset: 0x000B3568
	private int 92(int 1, int 2)
	{
		int num = int.MinValue;
		foreach (2034 3 in this.39.34)
		{
			if (2486.90(3) >= 1 && 2486.90(3) <= 2)
			{
				num = Math.Max(num, Math.Max(3.2, 2486.91(3)));
			}
		}
		if (num != -2147483648)
		{
			return num;
		}
		return 2;
	}

	// Token: 0x17000242 RID: 578
	// (get) Token: 0x06002598 RID: 9624 RVA: 0x000B53F4 File Offset: 0x000B35F4
	internal List<int> PracticeCheckpointTimes
	{
		get
		{
			1262 <<EMPTY_NAME>> = 1272.5();
			return 1935.Get((<<EMPTY_NAME>> != null) ? <<EMPTY_NAME>>.23 : null);
		}
	}

	// Token: 0x17000243 RID: 579
	// (get) Token: 0x06002599 RID: 9625 RVA: 0x000B540C File Offset: 0x000B360C
	internal int PracticeFirstObjectTime
	{
		get
		{
			return this.39.34[0].1;
		}
	}

	// Token: 0x17000244 RID: 580
	// (get) Token: 0x0600259A RID: 9626 RVA: 0x000B5424 File Offset: 0x000B3624
	internal int PracticeLastObjectTime
	{
		get
		{
			return this.39.34[this.39.34.Count - 1].1;
		}
	}

	// Token: 0x17000245 RID: 581
	// (get) Token: 0x0600259B RID: 9627 RVA: 0x000B5450 File Offset: 0x000B3650
	internal bool IsPracticeHoldDown
	{
		get
		{
			200 <<EMPTY_NAME>> = 1548.8(1532.PracticeHold);
			return <<EMPTY_NAME>> != global::200.None && 1549.10(<<EMPTY_NAME>>) && !this.93(<<EMPTY_NAME>>);
		}
	}

	// Token: 0x0600259C RID: 9628 RVA: 0x000B547C File Offset: 0x000B367C
	private bool 93(200 1)
	{
		switch (2486.14())
		{
		case 2147.Osu:
			return 1 == 1548.8(1532.OsuLeft) || 1 == 1548.8(1532.OsuRight) || 1 == 1548.8(1532.OsuSmoke);
		case 2147.Taiko:
			return 1 == 1548.8(1532.TaikoInnerLeft) || 1 == 1548.8(1532.TaikoInnerRight) || 1 == 1548.8(1532.TaikoOuterLeft) || 1 == 1548.8(1532.TaikoOuterRight);
		case 2147.CatchTheBeat:
			return 1 == 1548.8(1532.FruitsLeft) || 1 == 1548.8(1532.FruitsRight) || 1 == 1548.8(1532.FruitsDash);
		case 2147.OsuMania:
		{
			2039 2 = this.39;
			if (((2 != null) ? 2.41 : null) != null)
			{
				foreach (1995 3 in this.39.41.19)
				{
					if (3.16() == 1 || 3.18() == 1)
					{
						return true;
					}
				}
				return false;
			}
			return false;
		}
		default:
			return false;
		}
	}

	// Token: 0x0600259D RID: 9629 RVA: 0x000B558C File Offset: 0x000B378C
	private void 94()
	{
		if (2486.88 == null || !2486.88.47 || !this.94.3)
		{
			return;
		}
		if (this.153 == null)
		{
			this.153 = new 2552(this);
		}
		if (this.164 != null && this.CanPracticeSeek)
		{
			int value = this.164.Value;
			1937? <<EMPTY_NAME>> = this.165;
			bool flag = this.166;
			this.164 = null;
			this.165 = null;
			this.174 = false;
			this.102(value, <<EMPTY_NAME>>, true, flag);
		}
		if (this.176 != 2486.88 && this.CanPracticeSeek)
		{
			this.176 = 2486.88;
			1934? practiceAutoStartPoint = this.PracticeAutoStartPoint;
			string a = 2486.177;
			1262 2 = 1272.5();
			int? num = (a == ((2 != null) ? 2.23 : null)) ? 2486.178 : null;
			1937? 3 = 2486.179;
			2486.99();
			if (num != null)
			{
				this.102(num.Value, 3, false, 3 == null);
			}
			else if (practiceAutoStartPoint != null)
			{
				this.102(practiceAutoStartPoint.Value.1, practiceAutoStartPoint.Value.2, false, practiceAutoStartPoint.Value.2 == null);
			}
		}
		if (this.185 != null && 1662.33 >= this.185.Value && this.154 == null)
		{
			this.185 = null;
			2206.3(2486.88, 1272.5());
		}
		if (this.IsPracticeLooping && !this.156 && this.154 == null && this.170 != null && 1226.16 > this.170.Value + 200 && this.CanPracticeSeek)
		{
			this.105(this.169.Value);
		}
		bool flag2 = this.IsPracticeHoldDown && !this.171;
		if (flag2 && !this.159 && !this.IsPracticeShiftLocked && this.CanPracticeSeek)
		{
			this.158 = !this.158;
		}
		this.159 = flag2;
		if (this.IsPracticeShiftLocked || !this.CanPracticeSeek)
		{
			this.158 = false;
		}
		if (this.158)
		{
			this.157 = null;
			if (!this.156 || !1226.10())
			{
				if (!1226.10())
				{
					1226.107();
				}
				foreach (2034 4 in this.39.36)
				{
					4.StopHitSounds();
				}
				if (!this.156)
				{
					this.163 = null;
					this.160 = false;
				}
				this.156 = true;
			}
		}
		else if (this.156)
		{
			if (this.161 && this.CanPracticeSeek && this.154 == null)
			{
				this.161 = false;
				this.121(this.181 ?? (this.163 ?? 1226.16), true, null, null, true);
			}
			if (this.157 == null)
			{
				this.157 = new int?(1662.33 + (this.160 ? 0 : 1000));
			}
			bool flag3 = this.154 != null || this.164 != null;
			if ((!this.CanPracticeSeek && !flag3) || (this.CanPracticeSeek && 1662.33 >= this.157.Value && !flag3))
			{
				if (this.160)
				{
					this.89();
				}
				this.156 = false;
				this.157 = null;
				this.163 = null;
				if (this.CanPracticeSeek && 1226.10())
				{
					1226.107();
				}
			}
		}
		this.153.9();
	}

	// Token: 0x0600259E RID: 9630 RVA: 0x000B59E0 File Offset: 0x000B3BE0
	private void 95()
	{
		if (this.153 != null && !2486.13 && !2486.83)
		{
			this.153.17();
		}
	}

	// Token: 0x0600259F RID: 9631 RVA: 0x000B5A04 File Offset: 0x000B3C04
	private void 96()
	{
		2552 <<EMPTY_NAME>> = this.153;
		if (<<EMPTY_NAME>> != null)
		{
			<<EMPTY_NAME>>.Dispose();
		}
		this.153 = null;
		this.154 = null;
		this.155 = null;
		this.164 = null;
		this.165 = null;
		this.168 = null;
		this.174 = false;
		this.156 = false;
		this.157 = null;
		this.158 = false;
	}

	// Token: 0x060025A0 RID: 9632 RVA: 0x000B5A88 File Offset: 0x000B3C88
	private int 97(out bool 1)
	{
		2241 2 = 2486.88;
		int? num = (2 != null) ? 2.48 : null;
		bool flag = num != null && 1226.16 < num.Value;
		1 = (this.154 != null || this.164 != null || this.163 != null || flag);
		int? num2 = this.181;
		if (num2 != null)
		{
			return num2.GetValueOrDefault();
		}
		int? num3 = this.154;
		if (num3 != null)
		{
			return num3.GetValueOrDefault();
		}
		int? num4 = this.164;
		if (num4 != null)
		{
			return num4.GetValueOrDefault();
		}
		int? num5 = this.163;
		if (num5 != null)
		{
			return num5.GetValueOrDefault();
		}
		if (!flag)
		{
			return 1226.16;
		}
		return num.Value;
	}

	// Token: 0x060025A1 RID: 9633 RVA: 0x000B5B68 File Offset: 0x000B3D68
	private bool 98(200 1)
	{
		if (6 == 1548.8(1532.Skip) && this.IsPracticeHeld && !this.171 && this.CanPracticeSeek && !2486.13 && 2486.88 != null && 2486.88.47 && !1535.1() && !this.93(6))
		{
			bool flag;
			this.121(this.97(out flag), true, null, null, true);
			return true;
		}
		1532 2 = 1548.9(6, 1531.Practice);
		if (2 == 1532.None || 2 == 1532.PracticeHold || 2486.88 == null || !2486.88.47 || 1535.1() || 2486.4 || this.46 || this.93(6))
		{
			return false;
		}
		bool flag2 = 2486.13;
		if (!flag2 && !this.CanPracticeSeek)
		{
			return false;
		}
		1262 3 = 1272.5();
		string 4 = (3 != null) ? 3.23 : null;
		bool flag3;
		int point = this.97(out flag3);
		List<int> list = 1935.Get(4);
		List<1937> source = 1935.1(4);
		1937? active = this.ActivePracticeSegment;
		int? num = null;
		1937? 5 = null;
		switch (2)
		{
		case 1532.PracticePreviousCheckpoint:
		case 1532.PracticeNextCheckpoint:
		{
			List<KeyValuePair<int, 1937?>> list2 = (from 1 in (from 1 in list
			select new KeyValuePair<int, 1937?>(1, null)).Concat(from 1 in source.Where(new Func<1937, bool>(this.107))
			select new KeyValuePair<int, 1937?>(1.1, new 1937?(1)))
			orderby 1.Key, ((1.Value != null) > false) ? 1 : 0
			select 1).ThenBy(delegate(KeyValuePair<int, 1937?> 1)
			{
				if (1.Value == null)
				{
					return 0;
				}
				1937? 7;
				return 7.GetValueOrDefault().2;
			}).ToList<KeyValuePair<int, 1937?>>();
			if (list2.Count == 0)
			{
				2486.116("No checkpoints or segments yet (on the seek bar: a right-click adds a checkpoint, a right-drag a segment)");
				return true;
			}
			bool flag4 = 2 == 1532.PracticeNextCheckpoint;
			int? checkpointStop = this.101(point, list);
			int num2 = (active != null) ? list2.FindIndex((KeyValuePair<int, 1937?> 1) => 1.Value != null && 1.Value.Value.Equals(active.Value)) : ((checkpointStop != null) ? list2.FindIndex((KeyValuePair<int, 1937?> 1) => 1.Value == null && 1.Key == checkpointStop.Value) : (flag3 ? list2.FindIndex((KeyValuePair<int, 1937?> 1) => 1.Value == null && 1.Key == point) : -1));
			int num3;
			if (num2 >= 0)
			{
				num3 = num2 + (flag4 ? 1 : -1);
			}
			else if (flag4)
			{
				num3 = list2.FindIndex((KeyValuePair<int, 1937?> 1) => 1.Key > point);
			}
			else
			{
				int before = point - (flag3 ? 1 : 1000);
				num3 = list2.FindLastIndex((KeyValuePair<int, 1937?> 1) => 1.Key <= before);
			}
			if (num3 < 0 || num3 >= list2.Count)
			{
				2486.116(flag4 ? "No later checkpoint or segment" : "No earlier checkpoint or segment");
				return true;
			}
			num = new int?(list2[num3].Key);
			5 = list2[num3].Value;
			break;
		}
		case 1532.PracticeLeaveSegment:
		{
			bool flag5 = 1935.13(4) != null;
			if (flag5)
			{
				1935.14(4, null);
				2486.116("Plays of this beatmap start from the beginning again");
			}
			if (active == null)
			{
				return flag5;
			}
			num = new int?(point);
			break;
		}
		case 1532.PracticeRename:
			if (!this.IsPracticeHeld || this.153 == null || this.171)
			{
				return false;
			}
			if (this.153.HoveredSegment != null)
			{
				this.113(this.153.HoveredSegment.Value);
			}
			else if (this.153.HoveredCheckpoint != null)
			{
				this.112(this.153.HoveredCheckpoint.Value);
			}
			else
			{
				2486.116("Point at a checkpoint or segment on the seek bar to rename it");
			}
			return true;
		default:
			return false;
		}
		if (5 != null && !this.107(5.Value))
		{
			2486.108(5.Value);
			return true;
		}
		if (num != null && 2 != 1532.PracticeLeaveSegment)
		{
			2486.116(this.111(num.Value, 5));
		}
		if (num != null)
		{
			if (flag2)
			{
				this.164 = new int?(num.Value);
				this.165 = 5;
				this.166 = (5 == null && 2 != 1532.PracticeLeaveSegment);
				this.156 = true;
				this.157 = null;
				this.174 = true;
				this.RequestPauseToggle();
			}
			else
			{
				this.102(num.Value, 5, true, 5 == null && 2 != 1532.PracticeLeaveSegment);
			}
		}
		return true;
	}

	// Token: 0x060025A2 RID: 9634 RVA: 0x000B6085 File Offset: 0x000B4285
	internal static void 99()
	{
		2486.177 = null;
		2486.178 = null;
		2486.179 = null;
	}

	// Token: 0x060025A3 RID: 9635 RVA: 0x000B60A4 File Offset: 0x000B42A4
	internal void 100()
	{
		2486.99();
		if (2486.88 == null || !2486.88.47 || 1535.1() || !this.94.3)
		{
			return;
		}
		1262 <<EMPTY_NAME>> = 1272.5();
		string text = (<<EMPTY_NAME>> != null) ? <<EMPTY_NAME>>.23 : null;
		bool flag;
		int point = this.97(out flag);
		List<int> list = 1935.Get(text);
		1937? activePracticeSegment = this.ActivePracticeSegment;
		if (activePracticeSegment != null)
		{
			2486.179 = activePracticeSegment;
			2486.178 = new int?(activePracticeSegment.Value.1);
		}
		else
		{
			int? num = this.101(point, list);
			2486.178 = ((num != null) ? num : (list.Exists((int 1) => 1 <= point) ? new int?(list.FindLast((int 1) => 1 <= point)) : null));
		}
		2486.177 = ((2486.178 != null) ? text : null);
	}

	// Token: 0x060025A4 RID: 9636 RVA: 0x000B61A8 File Offset: 0x000B43A8
	private int? 101(int 1, List<int> 2)
	{
		if (this.167 == null || 1 > this.167.Value + 1000 || !2.Contains(this.167.Value))
		{
			return null;
		}
		return this.167;
	}

	// Token: 0x060025A5 RID: 9637 RVA: 0x000B61FC File Offset: 0x000B43FC
	private void 102(int 1, 1937? 2, bool 3 = true, bool 4 = false)
	{
		if (2 != null && !this.107(2.Value))
		{
			2486.108(2.Value);
			return;
		}
		this.121(1, true, new int?(Math.Max(0, 1304.26.6())), 2, 3);
		this.167 = ((4 && this.154 != null) ? new int?(1) : null);
	}

	// Token: 0x17000246 RID: 582
	// (get) Token: 0x060025A6 RID: 9638 RVA: 0x000B6275 File Offset: 0x000B4475
	internal 1934? PracticeAutoStartPoint
	{
		get
		{
			1262 <<EMPTY_NAME>> = 1272.5();
			return 1935.13((<<EMPTY_NAME>> != null) ? <<EMPTY_NAME>>.23 : null);
		}
	}

	// Token: 0x060025A7 RID: 9639 RVA: 0x000B6290 File Offset: 0x000B4490
	internal void 103(1934 1)
	{
		1262 2 = 1272.5();
		string 3 = (2 != null) ? 2.23 : null;
		1934? 4 = 1935.13(3);
		bool flag = 4 != null && ((1.2 != null) ? 4.Value.2(1.2.Value) : 4.Value.1(1.1));
		if (!flag && 1.2 != null && !this.107(1.2.Value))
		{
			2486.108(1.2.Value);
			return;
		}
		1935.14(3, flag ? null : new 1934?(1));
		2486.116(flag ? "Plays of this beatmap start from the beginning again" : ("Plays of this beatmap start at " + ((1.2 != null) ? ("the segment " + 2552.18(1.2.Value.1) + " - " + 2552.18(1.2.Value.2)) : 2552.18(1.1))));
	}

	// Token: 0x060025A8 RID: 9640 RVA: 0x000B63C4 File Offset: 0x000B45C4
	internal void 104(int 1)
	{
		2486.116(this.111(1, null));
		this.102(1, null, true, true);
	}

	// Token: 0x060025A9 RID: 9641 RVA: 0x000B63F8 File Offset: 0x000B45F8
	internal void 105(1937 1)
	{
		if (this.107(1))
		{
			2486.116(this.111(1.1, new 1937?(1)));
		}
		this.102(1.1, new 1937?(1), true, false);
	}

	// Token: 0x060025AA RID: 9642 RVA: 0x000B6430 File Offset: 0x000B4630
	internal void 106(1937 1)
	{
		2552.18(1.1) + " - " + 2552.18(1.2);
		if (1.2 - 1.1 < 1000)
		{
			2486.116("A segment is at least a second long");
			return;
		}
		if (!this.107(1))
		{
			2486.108(1);
			return;
		}
		1262 2 = 1272.5();
		2486.116(1935.16((2 != null) ? 2.23 : null, 1) ? (this.111(1.1, new 1937?(1)) + " added") : "There is a segment like it already");
	}

	// Token: 0x060025AB RID: 9643 RVA: 0x000B64D0 File Offset: 0x000B46D0
	internal bool 107(1937 1)
	{
		if (this.39 == null)
		{
			return false;
		}
		foreach (2034 2 in this.39.34)
		{
			if (2486.90(2) >= 1.1 && 2486.90(2) <= 1.2)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060025AC RID: 9644 RVA: 0x000B6550 File Offset: 0x000B4750
	private static void 108(1937 1)
	{
		2486.116("There are no notes between " + 2552.18(1.1) + " and " + 2552.18(1.2));
	}

	// Token: 0x060025AD RID: 9645 RVA: 0x000B657C File Offset: 0x000B477C
	internal void 109(int 1)
	{
		1262 2 = 1272.5();
		2486.116(1935.15((2 != null) ? 2.23 : null, 1) ? (this.111(1, null) + " added") : "There is a checkpoint here already");
	}

	// Token: 0x060025AE RID: 9646 RVA: 0x000B65C8 File Offset: 0x000B47C8
	internal void 110(int 1)
	{
		string str = this.111(1, null);
		1262 2 = 1272.5();
		if (1935.18((2 != null) ? 2.23 : null, 1) != null)
		{
			2486.116(str + " removed");
		}
	}

	// Token: 0x17000247 RID: 583
	// (get) Token: 0x060025AF RID: 9647 RVA: 0x000B6617 File Offset: 0x000B4817
	internal bool IsPracticeRenaming
	{
		get
		{
			return this.171;
		}
	}

	// Token: 0x060025B0 RID: 9648 RVA: 0x000B6620 File Offset: 0x000B4820
	internal string 111(int 1, 1937? 2)
	{
		1262 3 = 1272.5();
		string 4 = (3 != null) ? 3.23 : null;
		if (2 == null)
		{
			return 1935.2(4, 1) + ": " + 2552.18(1);
		}
		return string.Concat(new string[]
		{
			1935.3(4, 2.Value),
			": ",
			2552.18(2.Value.1),
			" - ",
			2552.18(2.Value.2)
		});
	}

	// Token: 0x060025B1 RID: 9649 RVA: 0x000B66B4 File Offset: 0x000B48B4
	private void 112(int 1)
	{
		2486.<>c__DisplayClass350_0 CS$<>8__locals1 = new 2486.<>c__DisplayClass350_0();
		CS$<>8__locals1.time = 3;
		CS$<>8__locals1.<>4__this = this;
		2486.<>c__DisplayClass350_0 CS$<>8__locals2 = CS$<>8__locals1;
		1262 2 = 1272.5();
		CS$<>8__locals2.beatmapHash = ((2 != null) ? 2.23 : null);
		this.114(this.111(CS$<>8__locals1.time, null), 1935.4(CS$<>8__locals1.beatmapHash, CS$<>8__locals1.time), delegate(string 1)
		{
			1935.6(CS$<>8__locals1.beatmapHash, CS$<>8__locals1.time, 1);
			2486.116(CS$<>8__locals1.<>4__this.111(CS$<>8__locals1.time, null));
		});
	}

	// Token: 0x060025B2 RID: 9650 RVA: 0x000B6724 File Offset: 0x000B4924
	private void 113(1937 1)
	{
		2486.<>c__DisplayClass351_0 CS$<>8__locals1 = new 2486.<>c__DisplayClass351_0();
		CS$<>8__locals1.segment = 3;
		CS$<>8__locals1.<>4__this = this;
		2486.<>c__DisplayClass351_0 CS$<>8__locals2 = CS$<>8__locals1;
		1262 2 = 1272.5();
		CS$<>8__locals2.beatmapHash = ((2 != null) ? 2.23 : null);
		this.114(this.111(CS$<>8__locals1.segment.1, new 1937?(CS$<>8__locals1.segment)), 1935.5(CS$<>8__locals1.beatmapHash, CS$<>8__locals1.segment), delegate(string 1)
		{
			1935.7(CS$<>8__locals1.beatmapHash, CS$<>8__locals1.segment, 1);
			2486.116(CS$<>8__locals1.<>4__this.111(CS$<>8__locals1.segment.1, new 1937?(CS$<>8__locals1.segment)));
		});
	}

	// Token: 0x060025B3 RID: 9651 RVA: 0x000B679B File Offset: 0x000B499B
	private void 114(string 1, string 2, Action<string> 3)
	{
		this.171 = true;
		1662.25(new 1757(1, 2 ?? string.Empty, 3, delegate()
		{
			this.171 = false;
			this.159 = this.IsPracticeHoldDown;
			2552 4 = this.153;
			if (4 == null)
			{
				return;
			}
			4.1();
		}));
	}

	// Token: 0x060025B4 RID: 9652 RVA: 0x000B67C6 File Offset: 0x000B49C6
	internal void 115(1937 1)
	{
		string str = this.111(1.1, new 1937?(1));
		1262 2 = 1272.5();
		1935.17((2 != null) ? 2.23 : null, 1);
		2486.116(str + " removed");
	}

	// Token: 0x060025B5 RID: 9653 RVA: 0x000B6800 File Offset: 0x000B4A00
	private static void 116(string 1)
	{
		1763.2(1, 1000, (1389)0);
	}

	// Token: 0x060025B6 RID: 9654 RVA: 0x000B6810 File Offset: 0x000B4A10
	internal void 117(int 1)
	{
		this.118((this.181 ?? (this.154 ?? (this.163 ?? 1226.16))) + 1, false);
	}

	// Token: 0x060025B7 RID: 9655 RVA: 0x000B6878 File Offset: 0x000B4A78
	internal void 118(int 1, bool 2)
	{
		if (!this.CanPracticeSeek || !this.IsPracticeHeld)
		{
			return;
		}
		int num = Math.Max(this.PracticeFirstObjectTime, Math.Min(this.PracticeLastObjectTime, 1));
		if (!this.180)
		{
			this.181 = new int?(num);
			if (this.154 == null)
			{
				this.121(this.PracticeFirstObjectTime, false, null, null, true);
				this.184 = true;
			}
			return;
		}
		if (this.154 != null || (2 && Math.Abs(1662.33 - this.183) < 40))
		{
			this.181 = new int?(num);
			return;
		}
		this.181 = null;
		this.183 = 1662.33;
		if (num != 1226.16)
		{
			this.144(num);
		}
		this.39.RebuildTimeWindowObjects();
		foreach (2034 3 in this.182)
		{
			if (!this.39.36.Contains(3))
			{
				2486.120(3, true);
			}
		}
		this.182.Clear();
		foreach (2034 4 in this.39.36)
		{
			2486.120(4, 2486.91(4) < num);
			this.182.Add(4);
		}
		this.163 = new int?(num);
		this.161 = true;
		2486.88.48 = new int?(num);
		2486.88.49 = null;
		this.185 = new int?(1662.33 + 300);
	}

	// Token: 0x060025B8 RID: 9656 RVA: 0x000B6A6C File Offset: 0x000B4C6C
	private void 119()
	{
		this.180 = true;
		this.182.Clear();
		foreach (2034 <<EMPTY_NAME>> in this.39.34)
		{
			2486.120(<<EMPTY_NAME>>, true);
		}
		if (this.181 != null)
		{
			this.118(this.181.Value, false);
		}
	}

	// Token: 0x060025B9 RID: 9657 RVA: 0x000B6AF4 File Offset: 0x000B4CF4
	private static void 120(2034 1, bool 2)
	{
		if (1 is 1979)
		{
			return;
		}
		1.11 = 2;
		foreach (1433 3 in 1.30)
		{
			3.9(2);
		}
		2123 4 = 1 as 2123;
		if (4 != null && 4.58 != null)
		{
			4.58.11 = 2;
			foreach (1433 5 in 4.58.30)
			{
				5.9(2);
			}
		}
	}

	// Token: 0x060025BA RID: 9658 RVA: 0x000B6BB8 File Offset: 0x000B4DB8
	internal void 121(int 1, bool 2 = false, int? 3 = null, 1937? 4 = null, bool 5 = true)
	{
		if (!this.CanPracticeSeek)
		{
			return;
		}
		if (2 && 5)
		{
			this.89();
			this.160 = true;
		}
		this.162 = (!2 && this.IsPracticeHeld);
		this.184 = false;
		if (2)
		{
			this.161 = false;
		}
		this.155 = 3;
		this.168 = 4;
		this.167 = null;
		bool flag = this.154 != null;
		this.154 = new int?(Math.Max(this.PracticeFirstObjectTime, Math.Min(this.PracticeLastObjectTime, 1)));
		if (flag)
		{
			return;
		}
		1662.89.Schedule(delegate()
		{
			int? num = this.154;
			int? num2 = this.155;
			1937? 6 = this.168;
			bool 7 = this.162;
			bool flag2 = this.184;
			this.184 = false;
			this.154 = null;
			this.155 = null;
			this.168 = null;
			if (num != null && this.CanPracticeSeek)
			{
				if (num2 != null)
				{
					if (!1226.10())
					{
						1226.107();
					}
					this.156 = true;
					this.157 = new int?(1662.33 + num2.Value);
				}
				this.123(num.Value, 6, 7, flag2);
			}
		}, true);
	}

	// Token: 0x060025BB RID: 9659 RVA: 0x000B6C68 File Offset: 0x000B4E68
	private void 122(bool 1)
	{
		if (1 && !this.187)
		{
			return;
		}
		this.187 = !1;
		this.39.39.16 = (1 && this.39.2 < 86400000);
		if (!1)
		{
			this.39.39.3();
		}
		if (this.39.41 != null)
		{
			foreach (2011 2 in this.39.41)
			{
				if (2.8 != null)
				{
					2.8.16 = 1;
					if (!1)
					{
						2.8.3();
					}
				}
			}
		}
	}

	// Token: 0x060025BC RID: 9660 RVA: 0x000B6D34 File Offset: 0x000B4F34
	private void 123(int 1, 1937? 2, bool 3 = false, bool 4 = false)
	{
		int num = 1;
		List<2034> list = this.39.34;
		for (int i = 0; i < 16; i++)
		{
			bool flag = false;
			foreach (2034 5 in list)
			{
				int num2 = 2486.90(5);
				int num3 = 2486.91(5);
				if (num2 < num && num3 >= num && num3 > num2)
				{
					num = num2;
					flag = true;
				}
			}
			if (!flag)
			{
				break;
			}
		}
		foreach (2034 6 in this.39.36)
		{
			6.StopHitSounds();
		}
		1226.110();
		this.26 = null;
		this.161(this.39.22, num);
		this.122(true);
		this.39.47(this.39.22);
		this.124(num, (2 != null) ? new int?(2.GetValueOrDefault().2) : null);
		if (4)
		{
			this.122(false);
		}
		this.39.RebuildTimeWindowObjects();
		this.58.OnReplayObjectsRebuilt();
		this.169 = 2;
		this.170 = ((2 != null) ? new int?(this.92(num, 2.Value.2)) : null);
		this.39.29 = 0;
		this.39.30 = 0;
		1535.20();
		2139.Reset();
		this.150(int.MinValue);
		List<int> list2 = 2486.88.27;
		if (list2 != null)
		{
			list2.Clear();
		}
		List<208> list3 = 2486.88.11;
		if (list3 != null)
		{
			list3.Clear();
		}
		this.110 = null;
		this.40 = 0;
		int num4 = Math.Max(0, num - 2000);
		bool flag2 = 2486.41 || 1226.4;
		if (flag2)
		{
			2486.41 = false;
			1226.8();
		}
		List<1840> list4 = 2486.88.26;
		if (list4 != null && list4.Count > 2)
		{
			list4.RemoveRange(2, list4.Count - 2);
		}
		if (list4 != null && list4.Count == 2 && list4[1].10 >= num4)
		{
			list4[1].10 = Math.Max(list4[0].10, num4 - 1);
		}
		2486.88.48 = new int?(num);
		2486.88.49 = ((2 != null) ? new int?(2.GetValueOrDefault().2) : null);
		this.185 = (4 ? null : (3 ? new int?(1662.33 + 300) : null));
		if (!4 && !3)
		{
			2206.3(2486.88, 1272.5());
		}
		this.161 = 3;
		if (this.IsPracticeHeld)
		{
			this.163 = new int?(num);
			this.160 = true;
		}
		this.144(3 ? num : num4);
		if (flag2 && !this.156)
		{
			1226.109();
		}
		this.180 = false;
		this.182.Clear();
		if (4)
		{
			this.119();
			return;
		}
		this.181 = null;
	}

	// Token: 0x060025BD RID: 9661 RVA: 0x000B70C0 File Offset: 0x000B52C0
	private void 124(int 1, int? 2)
	{
		foreach (2034 3 in this.39.34)
		{
			if (2486.90(3) < 1 || (2 != null && 2486.90(3) > 2.Value))
			{
				3.11 = true;
				2123 4 = 3 as 2123;
				if (4 != null && 4.58 != null)
				{
					4.58.11 = true;
				}
				2486.149(3);
			}
		}
	}

	// Token: 0x17000248 RID: 584
	// (get) Token: 0x060025BE RID: 9662 RVA: 0x000B7160 File Offset: 0x000B5360
	private static int? ReplayPracticeStart
	{
		get
		{
			2241 <<EMPTY_NAME>> = 1535.39;
			if (!1535.1() || <<EMPTY_NAME>> == null || !<<EMPTY_NAME>>.47)
			{
				return null;
			}
			return <<EMPTY_NAME>>.48;
		}
	}

	// Token: 0x17000249 RID: 585
	// (get) Token: 0x060025BF RID: 9663 RVA: 0x000B7198 File Offset: 0x000B5398
	private static int ReplaySeekFloor
	{
		get
		{
			int? replayPracticeStart = 2486.ReplayPracticeStart;
			if (replayPracticeStart == null)
			{
				return 0;
			}
			return Math.Max(0, replayPracticeStart.Value - 2000);
		}
	}

	// Token: 0x060025C0 RID: 9664 RVA: 0x000B71CC File Offset: 0x000B53CC
	private void 125()
	{
		if (this.175 || 2486.189 || this.194 != null || !this.CanControlReplay)
		{
			return;
		}
		this.175 = true;
		if (2486.ReplayPracticeStart == null)
		{
			return;
		}
		int replaySeekFloor = 2486.ReplaySeekFloor;
		this.195 = null;
		this.146(replaySeekFloor);
		this.140(replaySeekFloor, true);
	}

	// Token: 0x060025C1 RID: 9665 RVA: 0x000B7238 File Offset: 0x000B5438
	private void 126(object 1, EventArgs 2)
	{
		1433 3 = 1 as 1433;
		if (3 == null)
		{
			return;
		}
		2023 4 = (2023)3.9;
		bool flag = 3.16 == 1f;
		if (this.127(4, flag))
		{
			if (flag)
			{
				3.16 = 0.5f;
				return;
			}
			3.16 = 1f;
		}
	}

	// Token: 0x060025C2 RID: 9666 RVA: 0x000B728C File Offset: 0x000B548C
	private bool 127(2023 1, bool 2)
	{
		2023 mod = 1;
		if (mod > 2023.HardRock)
		{
			if (mod <= 2023.HalfTime)
			{
				if (mod != 2023.DoubleTime)
				{
					if (mod != 2023.HalfTime)
					{
						return false;
					}
					this.134(2 ? (1.0 / 1939.19(2023.HalfTime)) : 1939.19(2023.HalfTime));
					return true;
				}
			}
			else if (mod != 2023.Nightcore)
			{
				if (mod == 2023.Flashlight)
				{
					if (this.58.20 != null)
					{
						if (2)
						{
							this.58.20.16 = 0.4f;
							if (this.58.22 != null)
							{
								this.58.22.6 = new 198(0, 0, 0, 120);
							}
						}
						else
						{
							this.58.20.16 = 1f;
							if (this.58.22 != null)
							{
								this.58.22.6 = new 198(0, 0, 0, byte.MaxValue);
							}
						}
					}
					return true;
				}
				return false;
			}
			this.134(2 ? (1.0 / 1939.19(2023.DoubleTime)) : 1939.19(2023.DoubleTime));
			return true;
		}
		if (mod == 2023.Easy || mod == 2023.Hidden || mod == 2023.HardRock)
		{
			if (2486.14() != 2147.Osu || this.39 == null)
			{
				return false;
			}
			1662.89.Schedule(delegate()
			{
				this.128(1, !2);
			}, true);
			return true;
		}
		return false;
	}

	// Token: 0x060025C3 RID: 9667 RVA: 0x000B7430 File Offset: 0x000B5630
	private void 128(2023 1, bool 2)
	{
		if (this.39 == null || this.80 == (707)6 || this.80 == (707)7)
		{
			return;
		}
		2023 3 = this.39.22;
		3 = (2 ? (3 | 1) : (3 & ~1));
		if (1 == 2023.HardRock)
		{
			2241 4 = 1535.39;
			2486.129((4 != null) ? 4.26 : null);
			if (2486.88 != null)
			{
				List<1840> list = 2486.88.26;
				2241 5 = 1535.39;
				if (list != ((5 != null) ? 5.26 : null))
				{
					2486.129(2486.88.26);
				}
			}
		}
		if (this.CanControlReplay)
		{
			this.139(3, 1 == 2023.Hidden);
			return;
		}
		this.148(3, 1226.16);
	}

	// Token: 0x060025C4 RID: 9668 RVA: 0x000B74E4 File Offset: 0x000B56E4
	private static void 129(List<1840> 1)
	{
		if (1 == null)
		{
			return;
		}
		foreach (1840 2 in 1)
		{
			2.2 = 384f - 2.2;
		}
	}

	// Token: 0x060025C5 RID: 9669 RVA: 0x000B7544 File Offset: 0x000B5744
	protected virtual void PrepareReplayPlayback()
	{
		if (!1662.84 && !2486.22 && !2486.21)
		{
			1535.2(false);
		}
	}

	// Token: 0x060025C6 RID: 9670 RVA: 0x000B7564 File Offset: 0x000B5764
	private void 130()
	{
		if ((1535.1() && (!1535.40 || 1535.41 != 0)) || 1226.32 != (1042)1 || 2486.4 || 2486.13 || this is 2485 || 2486.83)
		{
			return;
		}
		1572 <<EMPTY_NAME>> = 1555.41(1535.15, 1535.17, 1535.44, 1535.46, 1549.10(1548.8(1532.OsuSmoke)));
		208 replayCursorPosition = this.58.GetReplayCursorPosition();
		if (1535.24 && 1535.13 == <<EMPTY_NAME>>)
		{
			1572 2 = <<EMPTY_NAME>>;
			if (1535.16)
			{
				<<EMPTY_NAME>> &= ~1572.Left1;
			}
			if (1535.18)
			{
				<<EMPTY_NAME>> &= ~1572.Left2;
			}
			if (1535.16)
			{
				<<EMPTY_NAME>> &= ~1572.Right1;
			}
			if (1535.47)
			{
				<<EMPTY_NAME>> &= ~1572.Right2;
			}
			if (<<EMPTY_NAME>> != 2)
			{
				1840 item = new 1840(1226.16 - 1, replayCursorPosition.X, replayCursorPosition.Y, <<EMPTY_NAME>>);
				2486.88.26.Add(item);
			}
		}
		1840 item2 = (2486.14() != 2147.OsuMania) ? new 1840(1226.16, replayCursorPosition.X, replayCursorPosition.Y, <<EMPTY_NAME>>) : new 1840(1226.16, (float)1535.22(), (float)2009.3, 1572.None);
		this.37 = ((2486.9 && 1662.23) || this.36 || 1535.13 != <<EMPTY_NAME>>);
		if (this.58.3.GetCombo() != this.58.3.6)
		{
			this.58.3.6 = this.58.3.GetCombo();
			this.37 = true;
		}
		this.37 |= this.58.ShouldProcessHitInput();
		1535.13 = <<EMPTY_NAME>>;
		if (1662.23 || this.37)
		{
			2486.88.26.Add(item2);
			this.36 = false;
		}
	}

	// Token: 0x1700024A RID: 586
	// (get) Token: 0x060025C7 RID: 9671 RVA: 0x000B773E File Offset: 0x000B593E
	internal bool IsReplayViewerPaused
	{
		get
		{
			return this.191;
		}
	}

	// Token: 0x1700024B RID: 587
	// (get) Token: 0x060025C8 RID: 9672 RVA: 0x000B7746 File Offset: 0x000B5946
	internal double ReplayUserRate
	{
		get
		{
			return this.192;
		}
	}

	// Token: 0x1700024C RID: 588
	// (get) Token: 0x060025C9 RID: 9673 RVA: 0x000B774E File Offset: 0x000B594E
	internal int ReplayEndTime
	{
		get
		{
			return this.84;
		}
	}

	// Token: 0x1700024D RID: 589
	// (get) Token: 0x060025CA RID: 9674 RVA: 0x000B7758 File Offset: 0x000B5958
	internal bool CanControlReplay
	{
		get
		{
			return 1535.1() && !1535.40 && 1535.39 != null && 1535.39.26 != null && 1535.39.26.Count > 1 && this.39 != null && 2486.109 && this.130 && !this.46 && !2486.4 && !2486.13 && !1226.4 && this.80 != (707)6 && this.80 != (707)7;
		}
	}

	// Token: 0x060025CB RID: 9675 RVA: 0x000B77E4 File Offset: 0x000B59E4
	private void 131()
	{
		if (!1535.1())
		{
			return;
		}
		if (this.CanControlReplay)
		{
			this.135();
		}
		this.125();
		if (this.191 && !1226.10())
		{
			this.191 = false;
		}
		2241 <<EMPTY_NAME>> = 1535.39;
		List<1840> list = (<<EMPTY_NAME>> != null) ? <<EMPTY_NAME>>.26 : null;
		int num = 1535.33;
		bool flag = list == null || num >= list.Count - 1;
		if (2486.189 && (flag || list[num + 1].10 > this.193))
		{
			2486.189 = false;
			this.143();
			if (!1226.10() && Math.Abs(1226.19 - 1226.20 - this.193) > 40)
			{
				int num2 = 1226.16;
				this.144(this.193);
				1226.16 = num2;
			}
		}
		if (!2486.189 && 2486.190 && (flag || 1226.10() || 1226.19 - 1226.20 - list[num].10 <= 40))
		{
			2486.190 = false;
		}
	}

	// Token: 0x060025CC RID: 9676 RVA: 0x000B78F8 File Offset: 0x000B5AF8
	internal void 132()
	{
		if (!this.CanControlReplay)
		{
			return;
		}
		if (this.191)
		{
			this.191 = false;
			if (1226.10())
			{
				1226.107();
				return;
			}
		}
		else
		{
			if (!1226.10())
			{
				1226.107();
			}
			this.191 = true;
			foreach (2034 <<EMPTY_NAME>> in this.39.36)
			{
				<<EMPTY_NAME>>.StopHitSounds();
			}
		}
	}

	// Token: 0x060025CD RID: 9677 RVA: 0x000B7988 File Offset: 0x000B5B88
	internal void 133(double 1)
	{
		1 = Math.Max(0.1, Math.Min(2.0, Math.Round(1 * 100.0) / 100.0));
		if (Math.Abs(1 - this.192) < 0.001 || !1535.1())
		{
			return;
		}
		this.192 = 1;
		this.135();
	}

	// Token: 0x1700024E RID: 590
	// (get) Token: 0x060025CE RID: 9678 RVA: 0x000B79FC File Offset: 0x000B5BFC
	private double ReplayModRate
	{
		get
		{
			double num = this.200.GetValueOrDefault();
			if (this.200 == null)
			{
				num = 1939.17(2486.88.8, 2486.88.44);
				this.200 = new double?(num);
				return num;
			}
			return num;
		}
	}

	// Token: 0x060025CF RID: 9679 RVA: 0x000B7A50 File Offset: 0x000B5C50
	internal void 134(double 1)
	{
		this.200 = new double?(this.ReplayModRate * 1);
		this.135();
	}

	// Token: 0x060025D0 RID: 9680 RVA: 0x000B7A6C File Offset: 0x000B5C6C
	private void 135()
	{
		double num = 100.0 * this.ReplayModRate * this.192;
		if (Math.Abs(1226.38() - num) > 0.01)
		{
			1226.39(num);
		}
	}

	// Token: 0x060025D1 RID: 9681 RVA: 0x000B7AB0 File Offset: 0x000B5CB0
	internal void 136(double 1)
	{
		int num = this.194 ?? (2486.189 ? this.193 : 1226.16);
		this.137(num + (int)Math.Round(1 * 1000.0));
	}

	// Token: 0x060025D2 RID: 9682 RVA: 0x000B7B04 File Offset: 0x000B5D04
	internal void 137(int 1)
	{
		if (!this.CanControlReplay)
		{
			return;
		}
		this.141(Math.Max(2486.ReplaySeekFloor, Math.Min(1, this.84)));
	}

	// Token: 0x060025D3 RID: 9683 RVA: 0x000B7B2C File Offset: 0x000B5D2C
	internal void 138(int 1)
	{
		if (!this.CanControlReplay || 2486.189 || this.194 != null)
		{
			return;
		}
		if (!this.191)
		{
			this.132();
		}
		List<1840> list = 1535.39.26;
		int num = 1535.33;
		if (1 > 0)
		{
			int num2 = num + 1;
			while (num2 < list.Count - 1 && list[num2].10 <= list[num].10)
			{
				num2++;
			}
			if (num2 >= list.Count || list[num2].10 > this.84)
			{
				return;
			}
			this.141(list[num2].10);
			return;
		}
		else
		{
			int num3 = num - 1;
			while (num3 > 0 && list[num3].10 >= list[num].10)
			{
				num3--;
			}
			if (num3 < 0)
			{
				return;
			}
			this.141(Math.Max(0, list[num3].10));
			return;
		}
	}

	// Token: 0x060025D4 RID: 9684 RVA: 0x000B7C20 File Offset: 0x000B5E20
	private void 139(2023 1, bool 2)
	{
		int 3 = 2486.189 ? this.193 : 1226.16;
		int 4 = this.145(3);
		this.195 = null;
		this.147(4, 1);
		if (!2)
		{
			this.196.RemoveRange(this.197, this.196.Count - this.197);
		}
		this.193 = 3;
		2486.189 = true;
		2486.190 = true;
	}

	// Token: 0x060025D5 RID: 9685 RVA: 0x000B7C97 File Offset: 0x000B5E97
	private void 140(int 1, bool 2)
	{
		this.193 = 1;
		2486.189 = true;
		2486.190 = 2;
		this.144(1);
	}

	// Token: 0x060025D6 RID: 9686 RVA: 0x000B7CB4 File Offset: 0x000B5EB4
	private void 141(int 1)
	{
		if (2486.ReplayPracticeStart != null)
		{
			1 = Math.Max(1, 2486.ReplaySeekFloor);
		}
		bool flag = this.194 != null;
		this.194 = new int?(1);
		if (flag)
		{
			return;
		}
		1662.89.Schedule(delegate()
		{
			int? num = this.194;
			this.194 = null;
			if (num == null || !this.CanControlReplay)
			{
				return;
			}
			int num2 = 1535.39.26[1535.33].10;
			if (num.Value >= num2)
			{
				this.140(num.Value, num.Value - num2 > 150);
				return;
			}
			this.195 = null;
			foreach (2247 2 in 2486.88.30)
			{
				if (2.13 > num.Value)
				{
					break;
				}
				this.195 = new 2247?(2);
			}
			this.146(this.145(num.Value));
			this.140(num.Value, true);
		}, true);
	}

	// Token: 0x060025D7 RID: 9687 RVA: 0x000B7D10 File Offset: 0x000B5F10
	internal void 142(2149 1, 2034 2)
	{
		if (!1535.1() || 1535.40 || this.198)
		{
			return;
		}
		int[] array = new int[]
		{
			1226.16,
			2.1,
			(int)1
		};
		if (this.197 >= this.196.Count)
		{
			this.196.Add(array);
			this.197 = this.196.Count;
			return;
		}
		List<int[]> list = this.196;
		int num = this.197;
		this.197 = num + 1;
		int[] array2 = list[num];
		if (array2[0] == array[0] && array2[1] == array[1] && array2[2] == array[2])
		{
			return;
		}
		this.198 = true;
		2123 3 = 2 as 2123;
		1840 4 = 1535.71;
		string[] array3 = new string[67];
		array3[0] = "Replay rewind diverged: expected [time ";
		array3[1] = array2[0].ToString();
		array3[2] = ", object ";
		array3[3] = array2[1].ToString();
		array3[4] = ", result ";
		array3[5] = array2[2].ToString();
		array3[6] = "] got [time ";
		array3[7] = array[0].ToString();
		array3[8] = ", object ";
		array3[9] = array[1].ToString();
		array3[10] = ", result ";
		array3[11] = array[2].ToString();
		array3[12] = "] | target ";
		array3[13] = this.193.ToString();
		array3[14] = ", clean point ";
		array3[15] = this.199.ToString();
		array3[16] = ", catching up ";
		array3[17] = 2486.189.ToString();
		array3[18] = ", viewer paused ";
		array3[19] = this.191.ToString();
		array3[20] = " | frame ";
		array3[21] = 1535.33.ToString();
		array3[22] = " t=";
		array3[23] = ((4 == null) ? 0 : 4.10).ToString();
		array3[24] = " buttons ";
		array3[25] = ((4 == null) ? "-" : 4.9.ToString());
		array3[26] = " cursor ";
		int num2 = 27;
		208 5 = 1535.34;
		array3[num2] = 5.ToString();
		array3[28] = " | left ";
		array3[29] = 1535.14.ToString();
		array3[30] = "/";
		array3[31] = 1535.21.ToString();
		array3[32] = " right ";
		array3[33] = 1535.43.ToString();
		array3[34] = "/";
		array3[35] = 1535.50.ToString();
		array3[36] = " held ";
		array3[37] = 1555.15.ToString();
		array3[38] = " pressed ";
		array3[39] = 1555.14.ToString();
		array3[40] = " buttons ";
		array3[41] = 1555.21.ToString();
		array3[42] = " last ";
		array3[43] = 1555.16.ToString();
		array3[44] = " previous ";
		array3[45] = 1555.17.ToString();
		array3[46] = " | object type ";
		array3[47] = 2.GetType().Name;
		array3[48] = " ";
		int num3 = 49;
		num = 2.1;
		array3[num3] = num.ToString();
		array3[50] = "-";
		int num4 = 51;
		num = 2.2;
		array3[num4] = num.ToString();
		array3[52] = " at ";
		int num5 = 53;
		5 = 2.8;
		array3[num5] = 5.ToString();
		array3[54] = " judged ";
		int num6 = 55;
		bool flag = 2.11;
		array3[num6] = flag.ToString();
		int num7 = 56;
		string text;
		if (3 != null)
		{
			string[] array4 = new string[8];
			array4[0] = " tracking ";
			int num8 = 1;
			flag = 3.78;
			array4[num8] = flag.ToString();
			array4[2] = " head judged ";
			array4[3] = 3.IsHeadJudged().ToString();
			array4[4] = " collected ";
			int num9 = 5;
			num = 3.76;
			array4[num9] = num.ToString();
			array4[6] = " missed ";
			int num10 = 7;
			num = 3.80;
			array4[num10] = num.ToString();
			text = string.Concat(array4);
		}
		else
		{
			text = string.Empty;
		}
		array3[num7] = text;
		array3[57] = " | window ";
		array3[58] = this.39.36.Count.ToString();
		array3[59] = " objects, hit windows ";
		int num11 = 60;
		num = this.39.5;
		array3[num11] = num.ToString();
		array3[61] = "/";
		int num12 = 62;
		num = this.39.4;
		array3[num12] = num.ToString();
		array3[63] = "/";
		int num13 = 64;
		num = this.39.3;
		array3[num13] = num.ToString();
		array3[65] = ", radius ";
		int num14 = 66;
		float 6 = this.39.1;
		array3[num14] = 6.ToString();
		1338.5(string.Concat(array3), 1341.Runtime, (1114)2);
	}

	// Token: 0x060025D8 RID: 9688 RVA: 0x000B8234 File Offset: 0x000B6434
	private void 143()
	{
		if (this.195 == null)
		{
			return;
		}
		2247 value = this.195.Value;
		this.195 = null;
		if (value.13 >= 1226.16)
		{
			return;
		}
		if (value.2 != 2486.88.2 || value.1 != 2486.88.1 || value.3 != 2486.88.3 || value.6 != 2486.88.6)
		{
			1338.5(string.Concat(new string[]
			{
				"Replay rewind mismatch at ",
				this.193.ToString(),
				" ms (frame ",
				1535.33.ToString(),
				"): expected 300/100/50/miss ",
				value.2.ToString(),
				"/",
				value.1.ToString(),
				"/",
				value.3.ToString(),
				"/",
				value.6.ToString(),
				" (recorded at ",
				value.13.ToString(),
				"), got ",
				2486.88.2.ToString(),
				"/",
				2486.88.1.ToString(),
				"/",
				2486.88.3.ToString(),
				"/",
				2486.88.6.ToString()
			}), 1341.Runtime, (1114)2);
		}
	}

	// Token: 0x060025D9 RID: 9689 RVA: 0x000B83E6 File Offset: 0x000B65E6
	private void 144(int 1)
	{
		bool flag = 1226.10();
		1226.110();
		1226.4(1, false, true);
		if (flag)
		{
			1226.32 = (1042)0;
		}
	}

	// Token: 0x060025DA RID: 9690 RVA: 0x000B8404 File Offset: 0x000B6604
	private int 145(int 1)
	{
		int num = Math.Max(this.39.3, 200) + 30;
		int num2 = 1;
		List<2034> list = this.39.34;
		for (int i = list.Count - 1; i >= 0; i--)
		{
			2034 2 = list[i];
			if (2.1 - 410 <= num2)
			{
				if (this.39.GetReplayOpenUntil(2) + num < num2)
				{
					if (2.1 + this.39.9 + 1000 + num < num2)
					{
						break;
					}
				}
				else
				{
					num2 = 2.1 - 410 - 1;
				}
			}
		}
		return num2;
	}

	// Token: 0x060025DB RID: 9691 RVA: 0x000B84A7 File Offset: 0x000B66A7
	private void 146(int 1)
	{
		this.147(1, this.39.22);
	}

	// Token: 0x060025DC RID: 9692 RVA: 0x000B84C0 File Offset: 0x000B66C0
	private void 147(int 1, 2023 2)
	{
		2486.189 = false;
		2486.190 = false;
		foreach (2034 3 in this.39.36)
		{
			3.StopHitSounds();
		}
		this.148(2, 1);
		this.39.29 = 0;
		this.39.30 = 0;
		List<1840> list = 1535.39.26;
		int num = 0;
		int num2 = 0;
		while (num2 < list.Count && list[num2].10 <= 1)
		{
			num = num2;
			num2++;
		}
		1535.33 = num;
		1535.42 = false;
		1535.20();
		2139.Reset();
		this.150(1);
		this.199 = 1;
		this.198 = false;
		this.197 = this.196.Count;
		for (int i = 0; i < this.196.Count; i++)
		{
			if (this.196[i][0] > 1)
			{
				this.197 = i;
				break;
			}
		}
		this.110 = null;
	}

	// Token: 0x060025DD RID: 9693 RVA: 0x000B85F0 File Offset: 0x000B67F0
	private void 148(2023 1, int 2)
	{
		this.26 = null;
		this.161(1, 2);
		this.39.47(1);
		bool flag = 2486.14() > 2147.Osu;
		foreach (2034 3 in this.39.34)
		{
			if (3.2 < 2)
			{
				3.11 = true;
				2123 4 = 3 as 2123;
				if (4 != null)
				{
					4.58.11 = true;
				}
				if (flag)
				{
					2486.149(3);
				}
			}
		}
		int? replayPracticeStart = 2486.ReplayPracticeStart;
		if (replayPracticeStart != null)
		{
			this.124(replayPracticeStart.Value, 1535.39.49);
		}
		this.39.RebuildTimeWindowObjects();
		this.58.OnReplayObjectsRebuilt();
	}

	// Token: 0x060025DE RID: 9694 RVA: 0x000B86D4 File Offset: 0x000B68D4
	private static void 149(2034 1)
	{
		1979 2 = 1 as 1979;
		if (2 != null)
		{
			2.HideSprites();
			return;
		}
		foreach (1433 3 in 1.30)
		{
			3.9(true);
		}
		2123 4 = 1 as 2123;
		if (4 != null && 4.58 != null)
		{
			foreach (1433 5 in 4.58.30)
			{
				5.9(true);
			}
		}
	}

	// Token: 0x060025DF RID: 9695 RVA: 0x000B8790 File Offset: 0x000B6990
	private void 150(int 1)
	{
		2486.88.30.RemoveAll((2247 1) => 1.13 > 6);
		bool flag = 2486.88.30.Count > 0;
		2247 2 = flag ? 2486.88.30[2486.88.30.Count - 1] : default(2247);
		2486.88.2 = 2.2;
		2486.88.1 = 2.1;
		2486.88.3 = 2.3;
		2486.88.4 = 2.4;
		2486.88.5 = 2.5;
		2486.88.6 = 2.6;
		2486.88.13 = (int)2.10;
		2486.88.22 = 2.12;
		2499 3 = this.58.3;
		if (3 != null)
		{
			3.2((int)2.7);
		}
		if (2486.88.39 == null)
		{
			2486.88.SetRawScore(2.14);
			2486.88.32 = (double)2.14;
		}
		else
		{
			int 4;
			if (!flag)
			{
				2486.88.39.1(0);
			}
			else if (this.201.TryGetValue(2.13, out 4))
			{
				2486.88.39.1(4);
			}
			2486.88.39.2 = 2.17;
			2486.88.39.3 = 2.18;
		}
		if (this.58.6 != null)
		{
			if (flag)
			{
				this.58.6.SetHealth((double)2.8);
			}
			else
			{
				this.58.6.ResetToFull();
			}
		}
		this.63 = 2486.88.GetScore();
		this.42 = (int)2486.88.6;
		2499 5 = this.58.3;
		this.64 = ((5 != null) ? 5.GetCombo() : 0);
		this.65 = this.13();
		this.36 = true;
	}

	// Token: 0x060025E0 RID: 9696 RVA: 0x000B89C4 File Offset: 0x000B6BC4
	protected void 151(1262 1, bool 2)
	{
		object obj = 1535.37;
		lock (obj)
		{
			string 3 = string.Empty;
			2241 4 = 1535.39;
			bool flag2 = 1535.1() && 4 != null;
			3 = ((!flag2) ? 1304.189.GetValue() : 4.23);
			if (2)
			{
				2486.88 = 2246.Create(2486.11, 3, 1, this.IsScoreV2());
			}
			2486.88.8 = (flag2 ? 4.8 : 2019.1);
			2486.88.51 = (flag2 ? (4.51 || 2210.45(4)) : (!1662.84 && 1304.28.1()));
			2019.3 = new bool?(2486.88.51);
			2486.88.43 = (flag2 ? 4.43 : (1662.84 ? null : 1926.3(2486.11)));
			2486.88.45 = (flag2 ? 4.45 : (!1662.84 && 1931.3(2486.11)));
			2486.88.46 = (flag2 ? 4.46 : 1929.1(2486.11, 2486.88.8));
			2486.88.47 = (flag2 ? 4.47 : (!1535.1() && !1662.84 && 1936.Enabled));
			2486.88.48 = (flag2 ? 4.48 : null);
			2486.88.49 = (flag2 ? 4.49 : null);
			2486.88.50 = ((flag2 && (2019.1 & 2023.Autoplay) == 2023.None) ? 4.50 : 1933.Current);
			2486.88.52 = (flag2 ? 4.52 : ((!2 && 2486.88.52 != null) ? 2486.88.52 : (1662.84 ? null : 1925.15(2486.11, 2019.1))));
			2139.Reset();
			2486.88.44 = (flag2 ? 4.44 : (1662.84 ? null : 1939.16(2019.1)));
			if (flag2 && !1535.40)
			{
				2486.88.26 = 1535.39.26;
			}
			if (1535.1() || 1662.84)
			{
				2486.88.18();
			}
			this.58.10(!2);
			if (this.39 != null && 2486.11 == 2147.Osu && this.39.34.Count > 0)
			{
				2486.88.14 = 2093.21(this.39.34);
				2486.88.15 = this.39.34.Count;
			}
			else if (this.39 != null && 2486.11 == 2147.OsuMania)
			{
				1999 5 = this.58 as 1999;
				if (5 != null && 5.17 > 0)
				{
					2486.88.14 = 5.17 + 5.36;
					2486.88.15 = this.39.34.Count;
				}
			}
			if (this.39 != null)
			{
				this.39.29 = 0;
				this.39.30 = 0;
			}
			2486.12 = true;
			2486.88.21 = 1662.33;
		}
	}

	// Token: 0x060025E1 RID: 9697 RVA: 0x000B8D88 File Offset: 0x000B6F88
	internal void 152()
	{
		if (2486.88 == null)
		{
			return;
		}
		2486.88.42 = this.39.11;
		if (!1535.1())
		{
			2486.88.38 = 2486.20;
			2486.88.7 = DateTime.UtcNow;
		}
		if (1304.87)
		{
			return;
		}
		if (this.90 && this.154() && this.155())
		{
			if (!2486.88.18)
			{
				if (!2486.4)
				{
					2486.88.19 = true;
				}
				2486.88.20 = ((2486.5 == 0) ? 1226.16 : 2486.5);
			}
			else if (1662.54 != null)
			{
				1662.54.7();
			}
			if (this.113 > 10.0)
			{
				2685<2023> <<EMPTY_NAME>> = 2486.88.8;
				<<EMPTY_NAME>>.2(<<EMPTY_NAME>>.1() | 2023.TouchDevice);
			}
			if (2486.5 > 0)
			{
				2486.88.18 = false;
			}
			if (2486.88.47 && 2486.88.48 != null && 2486.11 == 2147.Osu && this.39 != null)
			{
				int windowStart = 2486.88.48.Value;
				int windowEnd = 2486.88.49.GetValueOrDefault(int.MaxValue);
				List<2034> list = this.39.34.FindAll((2034 1) => 1.1 >= windowStart && 1.1 <= windowEnd);
				if (list.Count > 0)
				{
					2486.88.14 = 2093.21(list);
					2486.88.15 = list.Count;
				}
			}
			2486.88.20();
			if (this.139.64)
			{
				this.139.64 = false;
				return;
			}
		}
		else
		{
			2486.88.18();
		}
	}

	// Token: 0x060025E2 RID: 9698 RVA: 0x000B8F6D File Offset: 0x000B716D
	internal virtual 2241 GetCurrentScore()
	{
		return 2486.88;
	}

	// Token: 0x060025E3 RID: 9699 RVA: 0x000B8F74 File Offset: 0x000B7174
	protected virtual void RecordScoreSnapshot()
	{
		int count = 2486.88.30.Count;
		if (count == 0 || 1226.16 > 2486.88.30[count - 1].13)
		{
			2486.88.30.Add(2486.153());
		}
		else
		{
			if (!1535.1() || 1226.16 != 2486.88.30[count - 1].13)
			{
				return;
			}
			2486.88.30[count - 1] = 2486.153();
		}
		if (2486.88.39 != null && 1535.1())
		{
			this.201[1226.16] = 2486.88.39.EventCount;
		}
	}

	// Token: 0x060025E4 RID: 9700 RVA: 0x000B903C File Offset: 0x000B723C
	protected virtual bool IsScoreV2()
	{
		2023 2;
		if (1535.1() && 1535.39 != null)
		{
			2023 <<EMPTY_NAME>> = 1535.39.8;
			2 = 2023.ScoreV2;
			return (<<EMPTY_NAME>> & 2) > 2023.None;
		}
		2023 3 = 2023.ScoreV2;
		2023 4 = 2019.1;
		2 = 3;
		return (4 & 2) > 2023.None;
	}

	// Token: 0x060025E5 RID: 9701 RVA: 0x000B9084 File Offset: 0x000B7284
	public static 2247 153()
	{
		2247 2;
		try
		{
			2486 <<EMPTY_NAME>> = 2486.7;
			if (<<EMPTY_NAME>> == null)
			{
				2 = default(2247);
				2 = 2;
			}
			else
			{
				2247 3 = default(2247);
				3.2 = 2486.88.2;
				3.1 = 2486.88.1;
				3.3 = 2486.88.3;
				3.4 = 2486.88.4;
				3.5 = 2486.88.5;
				3.6 = 2486.88.6;
				3.14 = 2486.88.GetScore();
				3.10 = (ushort)2486.88.13;
				3.7 = (ushort)<<EMPTY_NAME>>.58.3.GetCombo();
				3.12 = 2486.88.22;
				3.8 = ((<<EMPTY_NAME>>.58.6 != null) ? ((int)<<EMPTY_NAME>>.58.6.3()) : 0);
				3.13 = 1226.16;
				3.11 = !2486.4;
				3.16 = (2486.88.39 != null);
				2153 4 = 2486.88.39;
				3.17 = ((4 != null) ? 4.2 : 0.0);
				2153 5 = 2486.88.39;
				3.18 = ((5 != null) ? 5.3 : 0.0);
				2 = 3;
			}
		}
		catch
		{
			2247 3 = default(2247);
			2 = 3;
		}
		return 2;
	}

	// Token: 0x060025E6 RID: 9702 RVA: 0x000B9234 File Offset: 0x000B7434
	private bool 154()
	{
		return !1535.1() && !1662.84 && this.58.AllowsScoreSubmission() && 1272.5().85 != (1281)1 && 2019.4(2486.88.8) && 2486.88.41 && (!1272.5().27 || 1272.5().61);
	}

	// Token: 0x060025E7 RID: 9703 RVA: 0x000B92A8 File Offset: 0x000B74A8
	private bool 155()
	{
		return (1226.16 - this.67 > 8000 || 2486.88.18) && (2486.88.GetScore() > 10000 || 2486.88.18) && 2486.88.41 && this.58.31 > 0 && this.91;
	}

	// Token: 0x060025E8 RID: 9704 RVA: 0x000B9313 File Offset: 0x000B7513
	private void 156()
	{
		if (this.90 && this.58.3.GetCombo() > 0 && this.58.3.GetCombo() % 100 == 0)
		{
			1662.54.7();
		}
	}

	// Token: 0x060025E9 RID: 9705 RVA: 0x000B9350 File Offset: 0x000B7550
	private void 157(208 1, 2486.2490 2)
	{
		if (!1535.1() || 2486.14() != 2147.Osu || this.39 == null)
		{
			return;
		}
		int num = 1226.16;
		long item = (long)num << 24 ^ (long)((int)Math.Round((double)1.X)) << 12 ^ (long)((int)Math.Round((double)1.Y));
		if (!this.206.Add(item))
		{
			return;
		}
		this.207 = new 2023?(this.39.22);
		bool flag = 1535.50 && !1535.21;
		2486.2491 item2 = new 2486.2491
		{
			1 = num,
			2 = 1,
			3 = 2,
			4 = flag
		};
		int num2 = this.205.Count;
		while (num2 > 0 && this.205[num2 - 1].1 > num)
		{
			num2--;
		}
		this.205.Insert(num2, item2);
	}

	// Token: 0x060025EA RID: 9706 RVA: 0x000B9448 File Offset: 0x000B7648
	private 2486.2490 158()
	{
		int num = 1226.16;
		int <<EMPTY_NAME>> = this.39.3;
		foreach (2034 2 in this.39.34)
		{
			if (2.1 - <<EMPTY_NAME>> > num)
			{
				break;
			}
			if (Math.Abs(2.1 - num) <= <<EMPTY_NAME>>)
			{
				2123 3 = 2 as 2123;
				if ((3 != null) ? (!3.IsHeadJudged()) : (2.HasObjectType(2047.Normal) && !2.11))
				{
					return 2486.2490.Miss;
				}
			}
		}
		return 2486.2490.Neutral;
	}

	// Token: 0x060025EB RID: 9707 RVA: 0x000B9500 File Offset: 0x000B7700
	private 2486.2490 159(2034 1)
	{
		if (Math.Abs(1226.16 - 1.1) > this.39.5)
		{
			return 2486.2490.Ok;
		}
		return 2486.2490.Great;
	}

	// Token: 0x060025EC RID: 9708 RVA: 0x000B9524 File Offset: 0x000B7724
	private static 2486.2490 160(2149 1)
	{
		if (1 < (2149)0)
		{
			return 2486.2490.Miss;
		}
		if ((1 & (2149)1024) != (2149)0)
		{
			return 2486.2490.Great;
		}
		if ((1 & (2149)768) == (2149)0)
		{
			return 2486.2490.Neutral;
		}
		return 2486.2490.Ok;
	}

	// Token: 0x060025ED RID: 9709 RVA: 0x000B9550 File Offset: 0x000B7750
	private void 161(2023 1, int 2)
	{
		this.208 = null;
		2504 3 = this.58;
		if (3 != null)
		{
			2511 4 = 3.13;
			if (4 != null)
			{
				4.18();
			}
		}
		if (this.207 != null && this.207.Value != 6)
		{
			this.205.Clear();
			this.206.Clear();
			return;
		}
		this.205.RemoveAll((2486.2491 1) => 1.1 >= 2);
		this.206.Clear();
		foreach (2486.2491 5 in this.205)
		{
			this.206.Add((long)5.1 << 24 ^ (long)((int)Math.Round((double)5.2.X)) << 12 ^ (long)((int)Math.Round((double)5.2.Y)));
		}
	}

	// Token: 0x060025EE RID: 9710 RVA: 0x000B9664 File Offset: 0x000B7864
	internal void 162()
	{
		2039 <<EMPTY_NAME>> = this.39;
		1436 2 = (<<EMPTY_NAME>> != null) ? <<EMPTY_NAME>>.39 : null;
		if (2 == null || 2486.14() != 2147.Osu)
		{
			return;
		}
		if (this.208 == null || this.209 != 2)
		{
			this.163(2);
		}
		int num = 1226.16;
		int i = 0;
		if (1304.59.1())
		{
			for (int j = this.205.Count - 1; j >= 0; j--)
			{
				if (i >= 24)
				{
					break;
				}
				2486.2491 3 = this.205[j];
				int num2 = num - 3.1;
				if (num2 >= 0)
				{
					if (num2 >= 900)
					{
						break;
					}
					float num3 = (num2 <= 300) ? 1f : (1f - (float)(num2 - 300) / 600f);
					if (3.3 == 2486.2490.Neutral)
					{
						num3 *= 0.5f;
					}
					198 4 = 3.4 ? new 198(byte.MaxValue, 150, 40) : new 198(70, 220, 90);
					for (int k = 0; k < 2; k++)
					{
						1433 5 = this.208[i * 2 + k];
						5.17 = 3.2;
						5.6 = 4;
						5.16 = num3;
					}
					i++;
				}
			}
		}
		while (i < 24)
		{
			this.208[i * 2].16 = 0f;
			this.208[i * 2 + 1].16 = 0f;
			i++;
		}
	}

	// Token: 0x060025EF RID: 9711 RVA: 0x000B97E8 File Offset: 0x000B79E8
	private void 163(1436 1)
	{
		this.209 = 1;
		this.208 = new 1433[48];
		208 2 = new 208(0.17f, 0.035f) * (float)2039.16;
		for (int i = 0; i < this.208.Length; i++)
		{
			1433 3 = new 1433(1662.34, (1376)1, 1065.Centre, (1044)1, global::208.Zero, 0.99f, true, global::198.White, null);
			3.20 = 2;
			3.14 = ((i % 2 == 0) ? 0.7853982f : -0.7853982f);
			3.16 = 0f;
			this.208[i] = 3;
			1.12(3);
		}
	}

	// Token: 0x060025F3 RID: 9715 RVA: 0x000B9DF8 File Offset: 0x000B7FF8
	[CompilerGenerated]
	private void <HandleBeatmapLoadCompleted>g__AddExtraModIcon|228_0(string 1, string 2, ref 2486.<>c__DisplayClass228_0 3)
	{
		1433 4 = new 1433(1455.2(1, (1416)7, null), (1376)8, 1065.Centre, (1044)0, new 208((float)3.modPositionX, 94f), 0.9f + 3.modDepthOffset, 1535.1(), global::198.TransparentWhite, null);
		if (1535.1())
		{
			4.10 = true;
			4.52 = 2;
		}
		else
		{
			4.3.Add(new 1445(1456.Fade, 1f, 0f, 1662.33 + 3.modAnimationDelay, 1662.33 + 3.modAnimationDelay + 5000, (1046)0));
		}
		4.3.Add(new 1445(1456.Fade, 0f, 1f, 1662.33 + 3.modAnimationDelay, 1662.33 + 3.modAnimationDelay + 400, (1046)0));
		4.3.Add(new 1445(1456.Scale, 2f, 1f, 1662.33 + 3.modAnimationDelay, 1662.33 + 3.modAnimationDelay + 400, (1046)0)
		{
			15 = (1046)1
		});
		this.77.12(4);
		3.modIcons.1(4, null);
		3.modAnimationDelay += 500;
		3.modDepthOffset += 1E-05f;
		3.modPositionX += (1535.1() ? 50 : 10);
	}

	// Token: 0x04001A0B RID: 6667
	internal static bool 4;

	// Token: 0x04001A0C RID: 6668
	internal static int 5;

	// Token: 0x04001A0D RID: 6669
	internal static bool 6;

	// Token: 0x04001A0E RID: 6670
	internal static 2486 7;

	// Token: 0x04001A0F RID: 6671
	internal static bool 8;

	// Token: 0x04001A10 RID: 6672
	internal static bool 9;

	// Token: 0x04001A11 RID: 6673
	internal bool 10;

	// Token: 0x04001A12 RID: 6674
	private static 2147 11;

	// Token: 0x04001A13 RID: 6675
	internal static bool 12 = true;

	// Token: 0x04001A14 RID: 6676
	internal static bool 13;

	// Token: 0x04001A15 RID: 6677
	internal static bool 14;

	// Token: 0x04001A16 RID: 6678
	protected static int 15 = 0;

	// Token: 0x04001A17 RID: 6679
	internal static bool 16;

	// Token: 0x04001A18 RID: 6680
	private bool 17;

	// Token: 0x04001A19 RID: 6681
	internal static int 18;

	// Token: 0x04001A1A RID: 6682
	internal static int 19;

	// Token: 0x04001A1B RID: 6683
	internal static int 20 = 0;

	// Token: 0x04001A1C RID: 6684
	public static bool 21;

	// Token: 0x04001A1D RID: 6685
	public static bool 22;

	// Token: 0x04001A1E RID: 6686
	public static 1452 23;

	// Token: 0x04001A1F RID: 6687
	internal static 2562 24;

	// Token: 0x04001A20 RID: 6688
	internal readonly List<1433> 25 = new List<1433>();

	// Token: 0x04001A21 RID: 6689
	internal 2034 26;

	// Token: 0x04001A22 RID: 6690
	internal float 27;

	// Token: 0x04001A23 RID: 6691
	internal bool 28;

	// Token: 0x04001A24 RID: 6692
	private int 29;

	// Token: 0x04001A25 RID: 6693
	private 2563 30;

	// Token: 0x04001A26 RID: 6694
	private int 31;

	// Token: 0x04001A27 RID: 6695
	private bool 32;

	// Token: 0x04001A28 RID: 6696
	private int 33;

	// Token: 0x04001A29 RID: 6697
	internal 2648 34;

	// Token: 0x04001A2A RID: 6698
	protected bool 35;

	// Token: 0x04001A2B RID: 6699
	internal bool 36;

	// Token: 0x04001A2C RID: 6700
	private bool 37;

	// Token: 0x04001A2D RID: 6701
	private bool 38;

	// Token: 0x04001A2E RID: 6702
	internal 2039 39;

	// Token: 0x04001A2F RID: 6703
	private int 40;

	// Token: 0x04001A30 RID: 6704
	private static bool 41;

	// Token: 0x04001A31 RID: 6705
	protected int 42;

	// Token: 0x04001A32 RID: 6706
	private 208 43;

	// Token: 0x04001A33 RID: 6707
	private 208 44;

	// Token: 0x04001A34 RID: 6708
	internal static bool 45;

	// Token: 0x04001A35 RID: 6709
	internal bool 46;

	// Token: 0x04001A36 RID: 6710
	internal 1433 47;

	// Token: 0x04001A37 RID: 6711
	private 1433 48;

	// Token: 0x04001A38 RID: 6712
	private 208 49;

	// Token: 0x04001A39 RID: 6713
	private List<1433> 50;

	// Token: 0x04001A3A RID: 6714
	private 1433 51;

	// Token: 0x04001A3B RID: 6715
	private 1433 52;

	// Token: 0x04001A3C RID: 6716
	private 1433 53;

	// Token: 0x04001A3D RID: 6717
	private 1380 54;

	// Token: 0x04001A3E RID: 6718
	private int 55 = -1;

	// Token: 0x04001A3F RID: 6719
	private int 56 = -1;

	// Token: 0x04001A40 RID: 6720
	internal static bool 57;

	// Token: 0x04001A41 RID: 6721
	internal 2504 58;

	// Token: 0x04001A42 RID: 6722
	private 1433 59;

	// Token: 0x04001A43 RID: 6723
	private 1433 60;

	// Token: 0x04001A44 RID: 6724
	private Queue<int> 61;

	// Token: 0x04001A45 RID: 6725
	protected internal 2481 62;

	// Token: 0x04001A46 RID: 6726
	protected int 63;

	// Token: 0x04001A47 RID: 6727
	private int 64;

	// Token: 0x04001A48 RID: 6728
	private int 65;

	// Token: 0x04001A49 RID: 6729
	private 1351 66;

	// Token: 0x04001A4A RID: 6730
	internal int 67;

	// Token: 0x04001A4B RID: 6731
	internal int 68;

	// Token: 0x04001A4C RID: 6732
	protected 1452 69;

	// Token: 0x04001A4D RID: 6733
	public static 1436 70;

	// Token: 0x04001A4E RID: 6734
	internal 1436 71;

	// Token: 0x04001A4F RID: 6735
	internal 1436 72;

	// Token: 0x04001A50 RID: 6736
	internal 1436 73;

	// Token: 0x04001A51 RID: 6737
	internal 1436 74;

	// Token: 0x04001A52 RID: 6738
	internal 1436 75;

	// Token: 0x04001A53 RID: 6739
	internal 1436 76;

	// Token: 0x04001A54 RID: 6740
	internal 1436 77;

	// Token: 0x04001A55 RID: 6741
	internal 1436 78;

	// Token: 0x04001A56 RID: 6742
	internal 1436 79;

	// Token: 0x04001A57 RID: 6743
	internal 707 80;

	// Token: 0x04001A58 RID: 6744
	internal 1381 81;

	// Token: 0x04001A59 RID: 6745
	private bool 82;

	// Token: 0x04001A5A RID: 6746
	internal static bool 83;

	// Token: 0x04001A5B RID: 6747
	private int 84 = int.MinValue;

	// Token: 0x04001A5C RID: 6748
	private int 85 = int.MaxValue;

	// Token: 0x04001A5D RID: 6749
	protected 2547 86;

	// Token: 0x04001A5E RID: 6750
	private 1313 87;

	// Token: 0x04001A5F RID: 6751
	internal static 2241 88;

	// Token: 0x04001A60 RID: 6752
	internal bool 89;

	// Token: 0x04001A61 RID: 6753
	private bool 90;

	// Token: 0x04001A62 RID: 6754
	private bool 91;

	// Token: 0x04001A63 RID: 6755
	private 2147 92;

	// Token: 0x04001A64 RID: 6756
	private bool 93;

	// Token: 0x04001A65 RID: 6757
	protected 1260 94;

	// Token: 0x04001A66 RID: 6758
	private static bool 95;

	// Token: 0x04001A67 RID: 6759
	private static bool 96;

	// Token: 0x04001A68 RID: 6760
	private bool 97 = true;

	// Token: 0x04001A69 RID: 6761
	private bool 98;

	// Token: 0x04001A6A RID: 6762
	private List<1433> 99 = new List<1433>();

	// Token: 0x04001A6B RID: 6763
	private 1240 100;

	// Token: 0x04001A6C RID: 6764
	private float 101;

	// Token: 0x04001A6D RID: 6765
	internal bool 102;

	// Token: 0x04001A6E RID: 6766
	internal static bool 103;

	// Token: 0x04001A6F RID: 6767
	private bool 104;

	// Token: 0x04001A70 RID: 6768
	private int 105;

	// Token: 0x04001A71 RID: 6769
	private 1256 106;

	// Token: 0x04001A72 RID: 6770
	private bool 107;

	// Token: 0x04001A73 RID: 6771
	private long 108;

	// Token: 0x04001A74 RID: 6772
	internal static bool 109;

	// Token: 0x04001A75 RID: 6773
	private int? 110;

	// Token: 0x04001A76 RID: 6774
	private 2038 111;

	// Token: 0x04001A77 RID: 6775
	private static bool 112 = true;

	// Token: 0x04001A78 RID: 6776
	private double 113;

	// Token: 0x04001A79 RID: 6777
	private bool 114;

	// Token: 0x04001A7A RID: 6778
	private int 115;

	// Token: 0x04001A7B RID: 6779
	private bool 116;

	// Token: 0x04001A7C RID: 6780
	private 208 117;

	// Token: 0x04001A7D RID: 6781
	private float 118;

	// Token: 0x04001A7E RID: 6782
	private float 119;

	// Token: 0x04001A7F RID: 6783
	private int 120;

	// Token: 0x04001A80 RID: 6784
	private int 121;

	// Token: 0x04001A81 RID: 6785
	private 208 122;

	// Token: 0x04001A82 RID: 6786
	private 208? 123;

	// Token: 0x04001A83 RID: 6787
	private 208? 124;

	// Token: 0x04001A84 RID: 6788
	internal 2034 125;

	// Token: 0x04001A85 RID: 6789
	internal static bool 126;

	// Token: 0x04001A86 RID: 6790
	private 198 127;

	// Token: 0x04001A87 RID: 6791
	private int 128;

	// Token: 0x04001A88 RID: 6792
	private List<1433> 129 = new List<1433>();

	// Token: 0x04001A89 RID: 6793
	private bool 130;

	// Token: 0x04001A8A RID: 6794
	private bool 131;

	// Token: 0x04001A8B RID: 6795
	private int 132;

	// Token: 0x04001A8C RID: 6796
	internal bool 133;

	// Token: 0x04001A8D RID: 6797
	private bool 134;

	// Token: 0x04001A8E RID: 6798
	private 1289 135;

	// Token: 0x04001A8F RID: 6799
	public static bool 136;

	// Token: 0x04001A90 RID: 6800
	internal int 137;

	// Token: 0x04001A91 RID: 6801
	private 1433 138;

	// Token: 0x04001A92 RID: 6802
	private 1262 139;

	// Token: 0x04001A93 RID: 6803
	private static bool 140;

	// Token: 0x04001A94 RID: 6804
	private static 2241 141;

	// Token: 0x04001A95 RID: 6805
	private static string 142;

	// Token: 0x04001A96 RID: 6806
	private static bool 143;

	// Token: 0x04001A97 RID: 6807
	private static bool 144;

	// Token: 0x04001A98 RID: 6808
	private 1351 145;

	// Token: 0x04001A99 RID: 6809
	private bool 146;

	// Token: 0x04001A9A RID: 6810
	private bool 147;

	// Token: 0x04001A9B RID: 6811
	private bool 148;

	// Token: 0x04001A9C RID: 6812
	private const int 149 = 2000;

	// Token: 0x04001A9D RID: 6813
	private const int 150 = 1000;

	// Token: 0x04001A9E RID: 6814
	internal const int 151 = 1000;

	// Token: 0x04001A9F RID: 6815
	private const int 152 = 1000;

	// Token: 0x04001AA0 RID: 6816
	private 2552 153;

	// Token: 0x04001AA1 RID: 6817
	private int? 154;

	// Token: 0x04001AA2 RID: 6818
	private int? 155;

	// Token: 0x04001AA3 RID: 6819
	private bool 156;

	// Token: 0x04001AA4 RID: 6820
	private int? 157;

	// Token: 0x04001AA5 RID: 6821
	private bool 158;

	// Token: 0x04001AA6 RID: 6822
	private bool 159;

	// Token: 0x04001AA7 RID: 6823
	private bool 160;

	// Token: 0x04001AA8 RID: 6824
	private bool 161;

	// Token: 0x04001AA9 RID: 6825
	private bool 162;

	// Token: 0x04001AAA RID: 6826
	private int? 163;

	// Token: 0x04001AAB RID: 6827
	private int? 164;

	// Token: 0x04001AAC RID: 6828
	private 1937? 165;

	// Token: 0x04001AAD RID: 6829
	private bool 166;

	// Token: 0x04001AAE RID: 6830
	private int? 167;

	// Token: 0x04001AAF RID: 6831
	private 1937? 168;

	// Token: 0x04001AB0 RID: 6832
	private 1937? 169;

	// Token: 0x04001AB1 RID: 6833
	private int? 170;

	// Token: 0x04001AB2 RID: 6834
	private bool 171;

	// Token: 0x04001AB3 RID: 6835
	private int? 172;

	// Token: 0x04001AB4 RID: 6836
	private int 173;

	// Token: 0x04001AB5 RID: 6837
	private bool 174;

	// Token: 0x04001AB6 RID: 6838
	private bool 175;

	// Token: 0x04001AB7 RID: 6839
	private 2241 176;

	// Token: 0x04001AB8 RID: 6840
	private static string 177;

	// Token: 0x04001AB9 RID: 6841
	private static int? 178;

	// Token: 0x04001ABA RID: 6842
	private static 1937? 179;

	// Token: 0x04001ABB RID: 6843
	private bool 180;

	// Token: 0x04001ABC RID: 6844
	private int? 181;

	// Token: 0x04001ABD RID: 6845
	private readonly List<2034> 182 = new List<2034>();

	// Token: 0x04001ABE RID: 6846
	private int 183;

	// Token: 0x04001ABF RID: 6847
	private bool 184;

	// Token: 0x04001AC0 RID: 6848
	private int? 185;

	// Token: 0x04001AC1 RID: 6849
	private const int 186 = 300;

	// Token: 0x04001AC2 RID: 6850
	private bool 187;

	// Token: 0x04001AC3 RID: 6851
	internal const int 188 = 1000;

	// Token: 0x04001AC4 RID: 6852
	internal static bool 189;

	// Token: 0x04001AC5 RID: 6853
	internal static bool 190;

	// Token: 0x04001AC6 RID: 6854
	private bool 191;

	// Token: 0x04001AC7 RID: 6855
	private double 192 = 1.0;

	// Token: 0x04001AC8 RID: 6856
	private int 193;

	// Token: 0x04001AC9 RID: 6857
	private int? 194;

	// Token: 0x04001ACA RID: 6858
	private 2247? 195;

	// Token: 0x04001ACB RID: 6859
	private readonly List<int[]> 196 = new List<int[]>();

	// Token: 0x04001ACC RID: 6860
	private int 197;

	// Token: 0x04001ACD RID: 6861
	private bool 198;

	// Token: 0x04001ACE RID: 6862
	private int 199;

	// Token: 0x04001ACF RID: 6863
	private double? 200;

	// Token: 0x04001AD0 RID: 6864
	private readonly Dictionary<int, int> 201 = new Dictionary<int, int>();

	// Token: 0x04001AD1 RID: 6865
	private const int 202 = 24;

	// Token: 0x04001AD2 RID: 6866
	private const int 203 = 300;

	// Token: 0x04001AD3 RID: 6867
	private const int 204 = 600;

	// Token: 0x04001AD4 RID: 6868
	private readonly List<2486.2491> 205 = new List<2486.2491>();

	// Token: 0x04001AD5 RID: 6869
	private readonly HashSet<long> 206 = new HashSet<long>();

	// Token: 0x04001AD6 RID: 6870
	private 2023? 207;

	// Token: 0x04001AD7 RID: 6871
	private 1433[] 208;

	// Token: 0x04001AD8 RID: 6872
	private 1436 209;

	// Token: 0x020004C8 RID: 1224
	[276]
	[Serializable]
	public sealed class 2489
	{
		// Token: 0x060025F9 RID: 9721 RVA: 0x000BA1B8 File Offset: 0x000B83B8
		internal void 1()
		{
			if (1226.38 == 0)
			{
				1226.38.7(1226.38.8());
			}
			if (1226.39 == 0)
			{
				1226.39.7(1226.39.8());
			}
		}

		// Token: 0x060025FA RID: 9722 RVA: 0x000BA205 File Offset: 0x000B8405
		internal bool 2(1433 1)
		{
			return 1.8 == "back" || 1.8 == "retry";
		}

		// Token: 0x060025FB RID: 9723 RVA: 0x000A68E2 File Offset: 0x000A4AE2
		internal void 3(1371 1)
		{
			1.16(500, (1046)0, 0);
		}

		// Token: 0x060025FC RID: 9724 RVA: 0x000BA223 File Offset: 0x000B8423
		internal bool 4(1445 1)
		{
			return 1.14 == 1456.MovementY;
		}

		// Token: 0x060025FD RID: 9725 RVA: 0x000BA232 File Offset: 0x000B8432
		internal void 5(object 1, EventArgs 2)
		{
			if (1662.11.2())
			{
				1226.27(new string[]
				{
					"pause-continue-hover",
					"pause-hover"
				});
			}
		}

		// Token: 0x060025FE RID: 9726 RVA: 0x000BA25C File Offset: 0x000B845C
		internal void 6(object 1, EventArgs 2)
		{
			2486.83(false);
		}

		// Token: 0x060025FF RID: 9727 RVA: 0x000BA264 File Offset: 0x000B8464
		internal void 7(object 1, EventArgs 2)
		{
			if (1662.11.2())
			{
				1226.27(new string[]
				{
					"pause-back-hover",
					"pause-hover"
				});
			}
		}

		// Token: 0x06002600 RID: 9728 RVA: 0x000BA28E File Offset: 0x000B848E
		internal void 8(object 1, EventArgs 2)
		{
			1226.28("pause-back-click", 1f, (1416)3);
			if (1662.84)
			{
				1662.SetMode(1677.Edit, false);
				return;
			}
			1662.SetMode(1677.SelectPlay, false);
		}

		// Token: 0x06002601 RID: 9729 RVA: 0x000BA2B7 File Offset: 0x000B84B7
		internal void 9(1433 1)
		{
			1.16(200, (1046)0, 0);
			1.5 = false;
		}

		// Token: 0x06002602 RID: 9730 RVA: 0x000BA2CD File Offset: 0x000B84CD
		internal bool 10(1371 1)
		{
			return 1.16 == 0f;
		}

		// Token: 0x06002603 RID: 9731 RVA: 0x000BA2DC File Offset: 0x000B84DC
		internal bool 11(2034 1)
		{
			return !1.11 && Math.Abs(1.2 - 1226.16) < 500;
		}

		// Token: 0x06002604 RID: 9732 RVA: 0x000BA300 File Offset: 0x000B8500
		internal bool 12(2034 1)
		{
			return 1.1 != 1.2 && 1._000F_2007_2000_2004_200A_2000_2007_200B_2005_2005_2003_200A_200B_2008_2002_200B_2007_2009_2009_2000() <= 1226.16 && (1._0003_2002_200A_2007_2007_2004_200A_2006_200A_2005_2005_2007_2009_2008_2002_2001_2005_2003_2001_200B() >= 1226.16 || !1.11);
		}

		// Token: 0x06002605 RID: 9733 RVA: 0x000BA337 File Offset: 0x000B8537
		internal bool 13(2034 1)
		{
			return 1.HasObjectType(2047.Spinner) && Math.Abs(1.1 - 1226.16) < 150;
		}

		// Token: 0x06002606 RID: 9734 RVA: 0x00022391 File Offset: 0x00020591
		internal bool 14(bool 1)
		{
			return 1;
		}

		// Token: 0x06002607 RID: 9735 RVA: 0x000BA35C File Offset: 0x000B855C
		internal bool 15(2034 1)
		{
			return 1 is 2129 && !1.11 && 1.30[0].19;
		}

		// Token: 0x04001AD9 RID: 6873
		public static readonly 2486.2489 Instance = new 2486.2489();

		// Token: 0x04001ADA RID: 6874
		public static Action<1262> action;

		// Token: 0x04001ADB RID: 6875
		public static 1189 voidDelegate;

		// Token: 0x04001ADC RID: 6876
		public static Predicate<1433> predicate;

		// Token: 0x04001ADD RID: 6877
		public static Action<1371> action2;

		// Token: 0x04001ADE RID: 6878
		public static Predicate<1445> predicate2;

		// Token: 0x04001ADF RID: 6879
		public static EventHandler eventHandler;

		// Token: 0x04001AE0 RID: 6880
		public static EventHandler eventHandler2;

		// Token: 0x04001AE1 RID: 6881
		public static EventHandler eventHandler3;

		// Token: 0x04001AE2 RID: 6882
		public static EventHandler eventHandler4;

		// Token: 0x04001AE3 RID: 6883
		public static EventHandler eventHandler5;

		// Token: 0x04001AE4 RID: 6884
		public static Action<1433> action3;

		// Token: 0x04001AE5 RID: 6885
		public static Action<1371> action4;

		// Token: 0x04001AE6 RID: 6886
		public static Predicate<1371> predicate3;

		// Token: 0x04001AE7 RID: 6887
		public static Predicate<2034> predicate4;

		// Token: 0x04001AE8 RID: 6888
		public static Predicate<1445> predicate5;

		// Token: 0x04001AE9 RID: 6889
		public static Predicate<2034> predicate6;

		// Token: 0x04001AEA RID: 6890
		public static Predicate<2034> predicate7;

		// Token: 0x04001AEB RID: 6891
		public static Predicate<bool> predicate8;

		// Token: 0x04001AEC RID: 6892
		public static Predicate<bool> predicate9;

		// Token: 0x04001AED RID: 6893
		public static Predicate<2034> predicate10;

		// Token: 0x04001AEE RID: 6894
		public static 1189 voidDelegate2;

		// Token: 0x04001AEF RID: 6895
		public static 1189 voidDelegate3;

		// Token: 0x04001AF0 RID: 6896
		public static 1189 voidDelegate4;

		// Token: 0x04001AF1 RID: 6897
		public static 1189 voidDelegate5;

		// Token: 0x04001AF2 RID: 6898
		public static 1189 voidDelegate6;
	}

	// Token: 0x020004C9 RID: 1225
	[276]
	public sealed class 2487
	{
		// Token: 0x0600260A RID: 9738 RVA: 0x000BA38D File Offset: 0x000B858D
		internal void 1()
		{
			2019.1 = 2023.Autoplay;
			1272.SetCurrentBeatmap(this.1);
			1535.2(false);
			if (this.2)
			{
				1535.41 = this.1.78;
			}
			1662.104.16(true);
		}

		// Token: 0x04001AF3 RID: 6899
		public 1262 1;

		// Token: 0x04001AF4 RID: 6900
		public bool 2;
	}

	// Token: 0x020004CA RID: 1226
	[276]
	public sealed class 2492
	{
		// Token: 0x04001AF5 RID: 6901
		public 1445 1;

		// Token: 0x04001AF6 RID: 6902
		public 1445 2;
	}

	// Token: 0x020004CB RID: 1227
	[276]
	public sealed class 2488
	{
		// Token: 0x04001AF7 RID: 6903
		public 1433 1;
	}

	// Token: 0x020004CC RID: 1228
	[276]
	internal enum 2490
	{
		// Token: 0x04001AF9 RID: 6905
		Neutral,
		// Token: 0x04001AFA RID: 6906
		Great,
		// Token: 0x04001AFB RID: 6907
		Ok,
		// Token: 0x04001AFC RID: 6908
		Miss
	}

	// Token: 0x020004CD RID: 1229
	[276]
	private struct 2491
	{
		// Token: 0x04001AFD RID: 6909
		public int 1;

		// Token: 0x04001AFE RID: 6910
		public 208 2;

		// Token: 0x04001AFF RID: 6911
		public 2486.2490 3;

		// Token: 0x04001B00 RID: 6912
		public bool 4;
	}
}
