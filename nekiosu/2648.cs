using System;
using System.Collections.Generic;

// Token: 0x0200045A RID: 1114
public sealed class 2648 : IDisposable
{
	// Token: 0x06002225 RID: 8741 RVA: 0x0009312C File Offset: 0x0009132C
	internal 2648(2039 1)
	{
		2648.2652 storyboardManagerClosure = new 2648.2652();
		2648.1 = this;
		this.33 = 4;
		2648.2 = new 198(163, 162, byte.MaxValue);
		this.12 = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, new 208(0f, 0f), 0.9f, true, 198.TransparentBlack, null);
		this.12.66 = false;
		this.12.20 = new 208((float)1662.70.1, (float)1662.70.2 * 0.125f);
		this.11 = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, new 208(0f, 420f), 0.9f, true, 198.TransparentBlack, null);
		this.11.66 = false;
		this.11.20 = new 208((float)1662.70.1, (float)1662.70.2 * 0.125f);
		this.25.12(new 1433(1455.2("masking-border", (1416)3, null), (1376)7, 1065.TopRight, (1044)0, new 208(-319.5f, 0f))
		{
			5 = true,
			40 = new bool?(true)
		});
		1436 2 = this.25;
		1433 3 = new 1433(1455.2("masking-border", (1416)3, null), (1376)7, 1065.TopLeft, (1044)0, new 208(319.5f, 0f));
		3.45(true);
		3.5 = true;
		3.40 = new bool?(true);
		2.12(3);
		storyboardManagerClosure.1 = 1f + Math.Max(0f, (float)1662.70.1() * 1.6f / 2f - 172f - 512f) / 170f;
		this.25.28.ForEach(delegate(1371 1)
		{
			1433 5 = 1 as 1433;
			if (5 != null)
			{
				1.20 = new 208((1.20.X < 0f) ? (0f - storyboardManagerClosure.1) : storyboardManagerClosure.1, 768f / (float)5.38);
			}
		});
		this.Reset();
	}

	// Token: 0x06002226 RID: 8742 RVA: 0x0009336E File Offset: 0x0009156E
	internal static bool 1()
	{
		return 2648.7;
	}

	// Token: 0x06002227 RID: 8743 RVA: 0x00093375 File Offset: 0x00091575
	internal static void 2(bool 1)
	{
		if (1 != 2648.7)
		{
			2648.7 = 1;
			if (2648.1 != null)
			{
				2648.1.39();
			}
		}
	}

	// Token: 0x06002228 RID: 8744 RVA: 0x00093396 File Offset: 0x00091596
	internal static bool 3()
	{
		return 2648.8;
	}

	// Token: 0x06002229 RID: 8745 RVA: 0x000933A0 File Offset: 0x000915A0
	internal static void 4(bool 1)
	{
		if (1 == 2648.8)
		{
			return;
		}
		2648.8 = 1;
		if (2648.1 == null)
		{
			return;
		}
		foreach (1447 2 in 2648.1.30)
		{
			2.9(!2648.8);
		}
	}

	// Token: 0x0600222A RID: 8746 RVA: 0x00093414 File Offset: 0x00091614
	internal bool 5()
	{
		return this.23.5();
	}

	// Token: 0x0600222B RID: 8747 RVA: 0x00093424 File Offset: 0x00091624
	internal void 6(bool 1)
	{
		this.24.6(1, new bool?(true));
		this.23.6(1, new bool?(true));
		this.21.6(1, new bool?(true));
		this.24.24 = !1;
		this.23.24 = !1;
		this.21.24 = !1;
	}

	// Token: 0x0600222C RID: 8748 RVA: 0x00093494 File Offset: 0x00091694
	private void Reset()
	{
		2648.9 = 0f;
		this.10 = 0.4f;
		this.40 = 0;
		float num = (this.21 != null) ? this.21.7 : 0f;
		this.22 = new 1436(true);
		this.21 = new 1436
		{
			24 = true,
			5 = 0f
		};
		this.23 = new 1436
		{
			24 = true,
			5 = 0f
		};
		this.24 = new 1436
		{
			24 = true,
			5 = 0f
		};
		this.25.5 = 0f;
		this.21.7 = num;
		this.22.7 = num;
		this.23.7 = num;
		this.24.7 = num;
		2648.36 = (float)((int)(num * 100f));
		if (1662.78 == 1677.Play)
		{
			this.21.16 = true;
			this.22.16 = true;
			this.23.16 = true;
			this.24.16 = true;
		}
		int length = Enum.GetValues(typeof(2645)).Length;
		this.26 = new List<2647>[length];
		this.27 = new List<2647>[length];
		this.28 = new bool[length];
		for (int i = 0; i < this.26.Length; i++)
		{
			this.26[i] = new List<2647>();
			this.27[i] = new List<2647>();
			this.28[i] = true;
		}
		this.30.Clear();
		this.15 = new List<2654>();
		this.13 = new List<2275>();
		if (this.14 != null)
		{
			this.14 = this.14.FindAll(new Predicate<2647>(2648.2651.storyboardManagerCallbacks.1));
			using (List<2647>.Enumerator enumerator = this.14.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					2647 <<EMPTY_NAME>> = enumerator.Current;
					if (<<EMPTY_NAME>>.7 != null)
					{
						this.22.12(<<EMPTY_NAME>>.7);
						2658 2 = <<EMPTY_NAME>> as 2658;
						if (2 != null && 2.12 != null)
						{
							this.30.Add(2.12);
						}
					}
				}
				goto IL_25A;
			}
		}
		this.14 = new List<2647>();
		IL_25A:
		this.22.12(this.12);
		this.22.12(this.11);
		this.6(1272.5().63);
		2648.44.2();
		2648.43.2();
		2648.45.2();
		2648.46.2();
	}

	// Token: 0x0600222D RID: 8749 RVA: 0x00093768 File Offset: 0x00091968
	public List<2647> 7()
	{
		List<2647> list = new List<2647>();
		for (int i = 0; i < this.28.Length; i++)
		{
			if (this.28[i])
			{
				list.AddRange(this.26[i].FindAll(new Predicate<2647>(2648.2651.storyboardManagerCallbacks.2)));
			}
		}
		return list;
	}

	// Token: 0x0600222E RID: 8750 RVA: 0x000937BC File Offset: 0x000919BC
	internal void 8(198 1)
	{
		2648.2 = 1;
	}

	// Token: 0x0600222F RID: 8751 RVA: 0x000937C4 File Offset: 0x000919C4
	internal void 9(2647 1)
	{
		if (1.1 > this.31)
		{
			this.31 = 1.1;
		}
		if (1.8 < this.32)
		{
			this.32 = 1.8;
		}
		this.14.Add(1);
		if (1.7 != null && this.28[(int)1.5])
		{
			this.37 = true;
			2645 2 = 1.5;
			if (2 != 2645.Background)
			{
				if (2 != 2645.Overlay)
				{
					if (!this.23.16)
					{
						this.23.12(1.7);
					}
				}
				else if (!this.24.16)
				{
					this.24.12(1.7);
				}
			}
			else
			{
				if (this.4 != null && 1.3 == this.4.3)
				{
					this.3 = true;
				}
				if (!this.21.16)
				{
					this.21.12(1.7);
				}
			}
		}
		if (1.5 == 2645.Fail || 1.5 == 2645.Pass)
		{
			this.38 = true;
		}
		switch (1.10)
		{
		case 2635.Video:
			this.30.Add((1447)1.7);
			return;
		case 2635.Break:
			this.13.Add((2275)1);
			this.13.Sort();
			return;
		case 2635.Colour:
			break;
		case 2635.Sprite:
		case 2635.Animation:
			this.26[(int)1.5].Add(1);
			break;
		case 2635.Sample:
		{
			this.27[(int)1.5].Add(1);
			2654 3 = (2654)1;
			1226.15.2(3.13);
			int num = this.15.Count;
			while (num > 0 && this.15[num - 1].8 > 3.8)
			{
				num--;
			}
			this.15.Insert(num, 3);
			return;
		}
		default:
			return;
		}
	}

	// Token: 0x06002230 RID: 8752 RVA: 0x000939BC File Offset: 0x00091BBC
	public void 10(2647 1, 2645 2, int 3)
	{
		if (1.1 > this.31)
		{
			this.31 = 1.1;
		}
		if (1.8 < this.32)
		{
			this.32 = 1.8;
		}
		1.5 = 2;
		this.14.Add(1);
		if (3 > this.26[(int)2].Count - 1)
		{
			this.26[(int)2].Add(1);
		}
		else
		{
			this.26[(int)2].Insert(3, 1);
		}
		int count = this.26[(int)2].Count;
		for (int i = 3; i < count - 1; i++)
		{
			this.26[(int)2][i].7.2 = this.26[(int)2][i + 1].7.2;
		}
		this.26[(int)2][count - 1].7.2 = 2648.24(1.5);
		if (1.7 != null)
		{
			2645 4 = 1.5;
			if (4 == 2645.Background)
			{
				this.21.12(1.7);
				this.21.13();
				return;
			}
			if (4 == 2645.Overlay)
			{
				this.24.12(1.7);
				this.24.13();
				return;
			}
			this.23.12(1.7);
			this.23.13();
		}
	}

	// Token: 0x06002231 RID: 8753 RVA: 0x00093B24 File Offset: 0x00091D24
	internal 2647 11(string 1, int 2)
	{
		this.10 += 0.001f;
		try
		{
			1433 3 = null;
			2670 4 = 2672.24(1);
			if (4 == (2670)12)
			{
				1381 5 = 1455.2(1, (1416)4, null);
				1433 6 = null;
				if (5 == null && 1662.78 == 1677.Play && !1662.84)
				{
					1272.5().113 = false;
				}
				else
				{
					6 = new 1433(5, (1376)4, 1065.Centre, (1044)1, 208.Zero);
				}
				2647 7 = new 2655(6, 1, -100000, 1000 * 1226.9());
				if (7.7 == null)
				{
					1763.2("This beatmap is missing some files and may not be displayed correctly", 5000, (1389)0);
				}
				else
				{
					7.7.5 = true;
					7.7.2 = this.10;
				}
				7.10 = 2635.Background;
				7.11 = true;
				this.4 = 7;
				this.14.Add(7);
				7.9 = true;
				if (7.7 != null)
				{
					this.22.11(7.7);
				}
				return 7;
			}
			if (4 != (2670)13)
			{
				throw new Exception("moo");
			}
			if (!1272.5().52(1))
			{
				return null;
			}
			if (2648.3() && ((1662.78 != 1677.Edit && !1662.84) || 1304.79))
			{
				try
				{
					3 = new 1447(1, 2);
					3.15 = 640f / (float)3.35;
					this.30.Add((1447)3);
				}
				catch (Exception)
				{
					1763.4("Video playback failed.  This could be due to missing dll files (try running the updater).");
				}
			}
			2647 8 = new 2658(3 as 1447, 1, 2);
			if (3 != null)
			{
				3.2 = this.10;
				3.3.Add(new 1445(1456.Fade, 0f, 1f, 2, 2 + 1000, (1046)0)
				{
					16 = 149
				});
				3.3.Add(new 1445(1456.Fade, 1f, 0f, ((1447)3).70 - 1000, ((1447)3).70, (1046)0)
				{
					16 = 149
				});
				this.22.11(3);
				8.7.2 = this.10;
			}
			8.11 = true;
			this.14.Add(8);
			return 8;
		}
		catch (Exception)
		{
			1763.4("An error occurred while adding this file.");
		}
		return null;
	}

	// Token: 0x06002232 RID: 8754 RVA: 0x00093DD0 File Offset: 0x00091FD0
	internal void 12(2647 1)
	{
		if (!this.14.Contains(1))
		{
			return;
		}
		this.14.Remove(1);
		switch (1.10)
		{
		case 2635.Background:
		case 2635.Sprite:
		case 2635.Animation:
		{
			2645 2 = 1.5;
			if (2 != 2645.Background)
			{
				if (2 != 2645.Overlay)
				{
					this.23.Remove(1.7);
				}
				else
				{
					this.24.Remove(1.7);
				}
			}
			else
			{
				this.21.Remove(1.7);
				this.22.Remove(1.7);
			}
			this.26[(int)1.5].Remove(1);
			return;
		}
		case 2635.Video:
			this.30.Remove((1447)1.7);
			return;
		case 2635.Break:
			this.13.Remove((2275)1);
			return;
		case 2635.Colour:
			break;
		case 2635.Sample:
		{
			2654 3 = (2654)1;
			1226.15.1(3.13);
			this.15.Remove(3);
			break;
		}
		default:
			return;
		}
	}

	// Token: 0x06002233 RID: 8755 RVA: 0x00093EE0 File Offset: 0x000920E0
	internal void 13()
	{
		this.22.22();
		this.21.22();
	}

	// Token: 0x06002234 RID: 8756 RVA: 0x00093EFA File Offset: 0x000920FA
	internal void 14()
	{
		this.23.22();
		if (this.37 && 2648.7)
		{
			this.25.22();
		}
	}

	// Token: 0x06002235 RID: 8757 RVA: 0x00093F23 File Offset: 0x00092123
	internal void 15()
	{
		this.24.22();
	}

	// Token: 0x06002236 RID: 8758 RVA: 0x00093F34 File Offset: 0x00092134
	public void Dispose()
	{
		foreach (1447 <<EMPTY_NAME>> in this.30)
		{
			<<EMPTY_NAME>>.Dispose();
		}
		this.30.Clear();
		if (this.22 != null)
		{
			this.22.Dispose();
		}
		if (this.21 != null)
		{
			this.21.Dispose();
		}
		if (this.23 != null)
		{
			this.23.Dispose();
		}
		if (this.24 != null)
		{
			this.24.Dispose();
		}
		if (this.25 != null)
		{
			this.25.Dispose();
		}
		2648.44.2();
		2648.43.2();
		2648.45.2();
		2648.46.2();
		2648.1 = null;
	}

	// Token: 0x06002237 RID: 8759 RVA: 0x0009401C File Offset: 0x0009221C
	internal void 16()
	{
		float num = (float)((this.20 && 2648.7) ? 1 : 0);
		float num2 = this.5() ? 0f : num;
		if (1662.78 == 1677.Edit)
		{
			this.23.5 = (this.21.5 = (this.24.5 = num));
			this.25.5 = num2;
		}
		else
		{
			if (this.23.5 != num)
			{
				this.21.5 = (this.23.5 = (this.24.5 = 1052.19(this.23.5 + ((num < this.23.5) ? -0.07f : 0.07f) * (float)1662.10, 0f, 1f)));
			}
			if (this.25.5 != num2)
			{
				this.25.5 = 1052.19(this.25.5 + ((num2 < this.25.5) ? -0.07f : 0.07f) * (float)1662.10, 0f, 1f);
			}
		}
		bool flag = false;
		if (this.33.35 > 0)
		{
			if (this.18 && 1226.16 > this.33.GetFirstGameplayHitObject()._000F_2007_2000_2004_200A_2000_2007_200B_2005_2005_2003_200A_200B_2008_2002_200B_2007_2009_2009_2000() - this.33.2)
			{
				this.18 = false;
			}
			else if (!this.19 && 1226.16 > this.33.GetLastGameplayHitObject()._0005_200B_2002_2000_2005_200A_2005_2008_2004_2007_2005_2007_2006_2008_2007_2004_2001_2002_2007_2007_2007_2004_2002_2003_2009_2009_2001() + this.33.3)
			{
				this.19 = true;
			}
		}
		else
		{
			this.18 = true;
			this.19 = false;
		}
		if (1662.78 == 1677.Play && (this.18 || this.19))
		{
			flag = true;
		}
		for (int i = 0; i < this.13.Count; i++)
		{
			2275 <<EMPTY_NAME>> = this.13[i];
			if (1226.16 >= <<EMPTY_NAME>>.8 && 1226.16 <= <<EMPTY_NAME>>.1)
			{
				flag = true;
				2648.5 = <<EMPTY_NAME>>;
				break;
			}
		}
		if (1662.78 == 1677.Play && 2486.12 != this.17)
		{
			this.17 = 2486.12;
			if (this.17)
			{
				2648.35();
			}
			else
			{
				2648.37();
			}
			for (int j = 0; j < this.26[1].Count; j++)
			{
				this.26[1][j].7.9(this.17);
			}
			for (int k = 0; k < this.27[1].Count; k++)
			{
				2654 2 = (2654)this.27[1][k];
				if (this.17)
				{
					1226.15.1(2.13);
				}
				else
				{
					1226.15.2(2.13);
				}
			}
			if (!this.16)
			{
				for (int l = 0; l < this.26[2].Count; l++)
				{
					this.26[2][l].7.9(!this.17);
				}
				for (int m = 0; m < this.27[2].Count; m++)
				{
					2654 3 = (2654)this.27[2][m];
					if (this.17)
					{
						1226.15.2(3.13);
					}
					else
					{
						1226.15.1(3.13);
					}
				}
			}
			this.16 = false;
		}
		if (1662.78 == 1677.Play && 2486.109 && flag != 2648.6 && !1535.1() && !flag)
		{
			1763.3();
		}
		2648.6 = flag;
		if (!flag)
		{
			2648.5 = null;
		}
		this.17();
		this.22();
		if (1662.23 && 2648.7)
		{
			this.29(false, true);
		}
	}

	// Token: 0x06002238 RID: 8760 RVA: 0x00094420 File Offset: 0x00092620
	private void 17()
	{
		this.29 = false;
		if (2648.8)
		{
			foreach (1447 <<EMPTY_NAME>> in this.30)
			{
				this.34 = 1f - <<EMPTY_NAME>>.16;
				<<EMPTY_NAME>>.54();
				if (<<EMPTY_NAME>>.73 != null && Math.Abs(<<EMPTY_NAME>>.73.4() - (double)(1226.17 - <<EMPTY_NAME>>.49())) > 250.0 * 1226.38() / 100.0)
				{
					<<EMPTY_NAME>>.55(2648.39);
					2648.39 = false;
				}
			}
			return;
		}
		this.34 = 1f;
	}

	// Token: 0x06002239 RID: 8761 RVA: 0x000944F4 File Offset: 0x000926F4
	private static bool 18()
	{
		return !1304.142;
	}

	// Token: 0x0600223A RID: 8762 RVA: 0x00094503 File Offset: 0x00092703
	internal void 19(float 1)
	{
		if (2648.35 != 100)
		{
			2648.36 -= (float)Math.Ceiling((double)((2648.36 - (float)2648.20()) * Math.Min(1f, 1)));
		}
	}

	// Token: 0x0600223B RID: 8763 RVA: 0x00094538 File Offset: 0x00092738
	private static int 20()
	{
		if (!2648.18())
		{
			return Math.Min(100, 2648.35);
		}
		return Math.Max(0, 2648.35 - 30);
	}

	// Token: 0x0600223C RID: 8764 RVA: 0x0009455C File Offset: 0x0009275C
	private static int 21()
	{
		return Math.Max(2648.20(), Math.Min(100, 2648.35));
	}

	// Token: 0x0600223D RID: 8765 RVA: 0x00094574 File Offset: 0x00092774
	private void 22()
	{
		if (!1662.23)
		{
			return;
		}
		if (2648.36 > (float)2648.21() + 1E-45f)
		{
			2648.36 -= (2648.36 - (float)2648.21()) / 15f;
		}
		else if (!2648.6 && 2648.36 < (float)2648.21())
		{
			2648.36 += ((float)2648.21() - 2648.36) / 15f;
			if (1662.78 == 1677.Play && this.12.9 == 1 && 1272.5().62)
			{
				this.12.16(200, (1046)0, 0);
				this.11.16(200, (1046)0, 0);
			}
			this.12.9 = 0;
		}
		else if (2648.6 && (2648.36 != (float)2648.20() || this.12.9 == 0))
		{
			if (2648.36 > (float)2648.20())
			{
				2648.36 -= (2648.36 - (float)2648.20()) / 15f;
			}
			else
			{
				2648.36 += ((float)2648.20() - 2648.36) / 15f;
			}
			if (1662.78 == 1677.Play && this.12.9 == 0 && !this.19 && !this.18 && 1272.5().62)
			{
				this.12.FadeIn(200, (1046)0, 0);
				this.11.FadeIn(200, (1046)0, 0);
			}
			this.12.9 = 1;
		}
		float num = 2648.36 / 100f;
		this.22.7 = num;
		this.21.7 = num;
		this.23.7 = num;
		this.24.7 = num;
		this.25.7 = num;
		1662.55.8 = (1f - num) * this.34;
	}

	// Token: 0x0600223E RID: 8766 RVA: 0x0009477A File Offset: 0x0009297A
	internal void 23()
	{
		if (1662.78 != 1677.Edit)
		{
			this.14.Sort();
		}
		this.13.Sort(new Comparison<2275>(2648.2651.storyboardManagerCallbacks.3));
	}

	// Token: 0x0600223F RID: 8767 RVA: 0x000947AA File Offset: 0x000929AA
	internal static float 24(2645 1)
	{
		2648.9 += 0.0001f;
		return 0.5f + (float)1 * 0.1f + 2648.9;
	}

	// Token: 0x06002240 RID: 8768 RVA: 0x000947D0 File Offset: 0x000929D0
	internal void 25(2645 1)
	{
		if (this.28[(int)4])
		{
			using (List<2647>.Enumerator enumerator = this.26[(int)4].FindAll((2647 1) => 1.7 != null).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					2647 2 = enumerator.Current;
					2.7.9(true);
				}
				goto IL_B9;
			}
		}
		foreach (2647 3 in this.26[(int)4].FindAll(new Predicate<2647>(2648.2651.storyboardManagerCallbacks.4)))
		{
			3.7.9(false);
		}
		IL_B9:
		this.28[(int)4] = !this.28[(int)4];
	}

	// Token: 0x06002241 RID: 8769 RVA: 0x000948C8 File Offset: 0x00092AC8
	private void 26()
	{
		if (this.4 != null && this.4.7 != null)
		{
			this.4.7.9(true);
		}
	}

	// Token: 0x06002242 RID: 8770 RVA: 0x000948F0 File Offset: 0x00092AF0
	internal bool 27()
	{
		return this.42;
	}

	// Token: 0x06002243 RID: 8771 RVA: 0x000948F8 File Offset: 0x00092AF8
	private void 28(bool 1)
	{
		this.42 = 1;
	}

	// Token: 0x06002244 RID: 8772 RVA: 0x00094904 File Offset: 0x00092B04
	public void 29(bool 1, bool 2)
	{
		2648.2650 preloadTexturesClosure = new 2648.2650();
		preloadTexturesClosure.1 = this;
		try
		{
			2275 3 = this.13.Find(new Predicate<2275>(2648.2651.storyboardManagerCallbacks.5));
			int num = (2 && 3 != null) ? 3.1 : int.MaxValue;
			if (1)
			{
				this.23();
				if (2648.7 || !2)
				{
					foreach (2647 4 in this.14)
					{
						if (4.7 != null)
						{
							if (4.7.3.Count != 0 && 4.7.3[0].9 > num)
							{
								break;
							}
							if (!4.7.8() || !2)
							{
								4.LoadTextures();
							}
						}
						this.40++;
					}
				}
				this.28(true);
				if (2)
				{
					this.40 = 0;
				}
				else
				{
					this.41 = this.40;
				}
			}
			else if (this.40 < this.14.Count)
			{
				if (!this.27() || this.41 < this.40)
				{
					return;
				}
				bool flag = 2648.5 != null && 2648.5.8 + 1000 < 1226.16 && 1226.16 < 2648.5.1 - 1000;
				bool flag2 = false;
				preloadTexturesClosure.2 = this.40;
				preloadTexturesClosure.3 = preloadTexturesClosure.2;
				while (preloadTexturesClosure.3 < this.14.Count)
				{
					2647 5 = this.14[preloadTexturesClosure.3];
					if (5.6 || 5.7 == null || 5.7.3.Count == 0)
					{
						if (!flag2)
						{
							preloadTexturesClosure.2++;
						}
					}
					else
					{
						flag2 = true;
						if (5.8 >= 1226.16 + (flag ? 10000 : 2000) && (5.8 > num || preloadTexturesClosure.3 - preloadTexturesClosure.2 >= ((!flag) ? 1 : 4)))
						{
							break;
						}
					}
					preloadTexturesClosure.3++;
				}
				int num2 = preloadTexturesClosure.3 - preloadTexturesClosure.2;
				if (flag2 && num2 > 0)
				{
					1662.17(delegate
					{
						for (int i = preloadTexturesClosure.2; i < preloadTexturesClosure.3; i++)
						{
							2647 6 = preloadTexturesClosure.1.14[i];
							if (!6.6)
							{
								6.LoadTextures();
							}
						}
						preloadTexturesClosure.1.41 = preloadTexturesClosure.3;
					});
				}
				else
				{
					this.41 = preloadTexturesClosure.3;
				}
				this.40 = preloadTexturesClosure.3;
			}
			this.40 = Math.Min(this.40, this.14.Count);
		}
		catch
		{
			this.40++;
		}
	}

	// Token: 0x06002245 RID: 8773 RVA: 0x00094C54 File Offset: 0x00092E54
	internal static void 30(2038 1)
	{
		2648.43.1(1);
	}

	// Token: 0x06002246 RID: 8774 RVA: 0x00094C64 File Offset: 0x00092E64
	internal void 31(2034 1)
	{
		2038[] array = 2648.43.3();
		for (int i = 0; i < array.Length; i++)
		{
			array[i](1);
		}
	}

	// Token: 0x06002247 RID: 8775 RVA: 0x00094C93 File Offset: 0x00092E93
	internal static void 32(2640 1)
	{
		2648.44.1(1);
	}

	// Token: 0x06002248 RID: 8776 RVA: 0x00094CA0 File Offset: 0x00092EA0
	internal void 33(1244 1)
	{
		2640[] array = 2648.44.3();
		for (int i = 0; i < array.Length; i++)
		{
			array[i](1);
		}
	}

	// Token: 0x06002249 RID: 8777 RVA: 0x00094CCF File Offset: 0x00092ECF
	internal static void 34(1189 1)
	{
		2648.45.1(1);
	}

	// Token: 0x0600224A RID: 8778 RVA: 0x00094CDC File Offset: 0x00092EDC
	private static void 35()
	{
		1189[] array = 2648.45.3();
		for (int i = 0; i < array.Length; i++)
		{
			array[i]();
		}
	}

	// Token: 0x0600224B RID: 8779 RVA: 0x00094D0A File Offset: 0x00092F0A
	internal static void 36(1189 1)
	{
		2648.46.1(1);
	}

	// Token: 0x0600224C RID: 8780 RVA: 0x00094D18 File Offset: 0x00092F18
	private static void 37()
	{
		1189[] array = 2648.46.3();
		for (int i = 0; i < array.Length; i++)
		{
			array[i]();
		}
	}

	// Token: 0x0600224D RID: 8781 RVA: 0x00094D46 File Offset: 0x00092F46
	public void 38()
	{
		new List<2275>(this.13).ForEach(new Action<2275>(this.12));
	}

	// Token: 0x0600224E RID: 8782 RVA: 0x00094D64 File Offset: 0x00092F64
	internal void 39()
	{
		2648.2653 <<EMPTY_NAME>> = new 2648.2653();
		<<EMPTY_NAME>>.1 = this;
		if (this.3 && 2648.7)
		{
			1662.55.4(true, true);
			this.20 = true;
			return;
		}
		<<EMPTY_NAME>>.5 = 2504.28;
		<<EMPTY_NAME>>.3 = ((this.4 != null) ? this.4.7 : null);
		bool flag = this.37 && 2648.7;
		<<EMPTY_NAME>>.2 = (<<EMPTY_NAME>>.3 != null && <<EMPTY_NAME>>.3.17 != 208.Zero);
		<<EMPTY_NAME>>.4 = (<<EMPTY_NAME>>.5 != null && !this.37);
		456 2 = (!flag) ? ((456)1) : (this.5() ? ((456)3) : ((456)2));
		if (<<EMPTY_NAME>>.2 && (2 & (456)2) == (456)0)
		{
			2 = (456)3;
		}
		this.20 = false;
		1662.55.6(2, new 1459.1461(<<EMPTY_NAME>>.1));
	}

	// Token: 0x0600224F RID: 8783 RVA: 0x00094E58 File Offset: 0x00093058
	internal void 40()
	{
		this.26();
		foreach (1371 <<EMPTY_NAME>> in this.22.28)
		{
			1433 2 = (1433)<<EMPTY_NAME>>;
			if (2.GetTexture() != 1662.34)
			{
				2.46(!this.37 || this.5() || 1272.5().109, false);
			}
		}
	}

	// Token: 0x04001791 RID: 6033
	internal static 2648 1;

	// Token: 0x04001792 RID: 6034
	internal static 198 2;

	// Token: 0x04001793 RID: 6035
	internal bool 3;

	// Token: 0x04001794 RID: 6036
	internal 2647 4;

	// Token: 0x04001795 RID: 6037
	internal static 2275 5;

	// Token: 0x04001796 RID: 6038
	internal static bool 6;

	// Token: 0x04001797 RID: 6039
	private static bool 7 = true;

	// Token: 0x04001798 RID: 6040
	private static bool 8 = true;

	// Token: 0x04001799 RID: 6041
	private static float 9;

	// Token: 0x0400179A RID: 6042
	private float 10;

	// Token: 0x0400179B RID: 6043
	private readonly 1433 11;

	// Token: 0x0400179C RID: 6044
	private readonly 1433 12;

	// Token: 0x0400179D RID: 6045
	internal List<2275> 13;

	// Token: 0x0400179E RID: 6046
	internal List<2647> 14;

	// Token: 0x0400179F RID: 6047
	internal List<2654> 15;

	// Token: 0x040017A0 RID: 6048
	private bool 16 = true;

	// Token: 0x040017A1 RID: 6049
	private bool 17;

	// Token: 0x040017A2 RID: 6050
	private bool 18 = true;

	// Token: 0x040017A3 RID: 6051
	private bool 19;

	// Token: 0x040017A4 RID: 6052
	private bool 20;

	// Token: 0x040017A5 RID: 6053
	internal 1436 21;

	// Token: 0x040017A6 RID: 6054
	internal 1436 22;

	// Token: 0x040017A7 RID: 6055
	internal 1436 23;

	// Token: 0x040017A8 RID: 6056
	internal 1436 24;

	// Token: 0x040017A9 RID: 6057
	internal 1436 25 = new 1436(true)
	{
		5 = 0f
	};

	// Token: 0x040017AA RID: 6058
	internal List<2647>[] 26;

	// Token: 0x040017AB RID: 6059
	internal List<2647>[] 27;

	// Token: 0x040017AC RID: 6060
	internal bool[] 28;

	// Token: 0x040017AD RID: 6061
	internal bool 29;

	// Token: 0x040017AE RID: 6062
	internal List<1447> 30 = new List<1447>();

	// Token: 0x040017AF RID: 6063
	public int 31;

	// Token: 0x040017B0 RID: 6064
	public int 32;

	// Token: 0x040017B1 RID: 6065
	private readonly 2039 33;

	// Token: 0x040017B2 RID: 6066
	private float 34 = 1f;

	// Token: 0x040017B3 RID: 6067
	internal static int 35 = 1304.141;

	// Token: 0x040017B4 RID: 6068
	private static float 36 = 0f;

	// Token: 0x040017B5 RID: 6069
	public bool 37;

	// Token: 0x040017B6 RID: 6070
	public bool 38;

	// Token: 0x040017B7 RID: 6071
	internal static bool 39;

	// Token: 0x040017B8 RID: 6072
	private int 40;

	// Token: 0x040017B9 RID: 6073
	private int 41;

	// Token: 0x040017BA RID: 6074
	private bool 42;

	// Token: 0x040017BB RID: 6075
	private static readonly 2648.2649<2038> 43 = new 2648.2649<2038>();

	// Token: 0x040017BC RID: 6076
	private static readonly 2648.2649<2640> 44 = new 2648.2649<2640>();

	// Token: 0x040017BD RID: 6077
	private static readonly 2648.2649<1189> 45 = new 2648.2649<1189>();

	// Token: 0x040017BE RID: 6078
	private static readonly 2648.2649<1189> 46 = new 2648.2649<1189>();

	// Token: 0x0200045B RID: 1115
	public sealed class 2652
	{
		// Token: 0x040017BF RID: 6079
		public float 1;
	}

	// Token: 0x0200045C RID: 1116
	[Serializable]
	public sealed class 2651
	{
		// Token: 0x06002252 RID: 8786 RVA: 0x00094F42 File Offset: 0x00093142
		internal bool 1(2647 1)
		{
			return 1.9;
		}

		// Token: 0x06002253 RID: 8787 RVA: 0x00094F4A File Offset: 0x0009314A
		internal bool 2(2647 1)
		{
			return 1.7 != null;
		}

		// Token: 0x06002254 RID: 8788 RVA: 0x00094F55 File Offset: 0x00093155
		internal int 3(2275 1, 2275 2)
		{
			return 1.8.CompareTo(2.8);
		}

		// Token: 0x06002255 RID: 8789 RVA: 0x00094F4A File Offset: 0x0009314A
		internal bool 4(2647 1)
		{
			return 1.7 != null;
		}

		// Token: 0x06002256 RID: 8790 RVA: 0x00094F68 File Offset: 0x00093168
		internal bool 5(2275 1)
		{
			return 1.8 > 1226.16;
		}

		// Token: 0x040017C0 RID: 6080
		public static readonly 2648.2651 storyboardManagerCallbacks = new 2648.2651();

		// Token: 0x040017C1 RID: 6081
		public static Predicate<2647> predicate;

		// Token: 0x040017C2 RID: 6082
		public static Predicate<2647> predicate2;

		// Token: 0x040017C3 RID: 6083
		public static Comparison<2275> comparison;

		// Token: 0x040017C4 RID: 6084
		public static Predicate<2647> predicate3;

		// Token: 0x040017C5 RID: 6085
		public static Predicate<2647> predicate4;

		// Token: 0x040017C6 RID: 6086
		public static Action<1371> action;

		// Token: 0x040017C7 RID: 6087
		public static Action<1371> action2;

		// Token: 0x040017C8 RID: 6088
		public static Action<1371> action3;

		// Token: 0x040017C9 RID: 6089
		public static Predicate<2275> predicate5;
	}

	// Token: 0x0200045D RID: 1117
	public sealed class 2653
	{
		// Token: 0x06002259 RID: 8793 RVA: 0x00094F83 File Offset: 0x00093183
		internal void 1(1433 1)
		{
			if (this.2)
			{
				1.17 = this.3.17;
			}
			if (this.4)
			{
				this.5.AdjustStoryboardSprite(1);
			}
			this.1.20 = true;
		}

		// Token: 0x040017CA RID: 6090
		public 2648 1;

		// Token: 0x040017CB RID: 6091
		public bool 2;

		// Token: 0x040017CC RID: 6092
		public 1433 3;

		// Token: 0x040017CD RID: 6093
		public bool 4;

		// Token: 0x040017CE RID: 6094
		public 2504 5;
	}

	// Token: 0x0200045E RID: 1118
	public sealed class 2650
	{
		// Token: 0x040017CF RID: 6095
		public 2648 1;

		// Token: 0x040017D0 RID: 6096
		public int 2;

		// Token: 0x040017D1 RID: 6097
		public int 3;
	}

	// Token: 0x0200045F RID: 1119
	private sealed class 2649<THandler> where THandler : class
	{
		// Token: 0x0600225C RID: 8796 RVA: 0x00094FC0 File Offset: 0x000931C0
		internal void 1(THandler 1)
		{
			if (1 == null)
			{
				return;
			}
			List<THandler> obj = this.1;
			lock (obj)
			{
				this.1.Add(1);
				this.2 = null;
			}
		}

		// Token: 0x0600225D RID: 8797 RVA: 0x00095018 File Offset: 0x00093218
		internal void 2()
		{
			List<THandler> obj = this.1;
			lock (obj)
			{
				this.1.Clear();
				this.2 = new THandler[0];
			}
		}

		// Token: 0x0600225E RID: 8798 RVA: 0x0009506C File Offset: 0x0009326C
		internal THandler[] 3()
		{
			THandler[] array = this.2;
			if (array != null)
			{
				return array;
			}
			List<THandler> obj = this.1;
			THandler[] array3;
			lock (obj)
			{
				THandler[] array2;
				if ((array2 = this.2) == null)
				{
					array3 = (this.2 = this.1.ToArray());
					array2 = array3;
				}
				array3 = array2;
			}
			return array3;
		}

		// Token: 0x040017D2 RID: 6098
		private readonly List<THandler> 1 = new List<THandler>();

		// Token: 0x040017D3 RID: 6099
		private volatile THandler[] 2 = new THandler[0];
	}
}
