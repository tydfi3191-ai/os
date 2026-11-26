using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using OpenTK;

// Token: 0x0200049F RID: 1183
public sealed class 2601 : 2462
{
	// Token: 0x060023F7 RID: 9207 RVA: 0x0009E4EC File Offset: 0x0009C6EC
	private void 1(object 1, EventArgs 2)
	{
		this.18(this.65, false, null, false);
	}

	// Token: 0x060023F8 RID: 9208 RVA: 0x0009E4EC File Offset: 0x0009C6EC
	private void 2(object 1, EventArgs 2)
	{
		this.18(this.65, false, null, false);
	}

	// Token: 0x060023F9 RID: 9209 RVA: 0x0009E4FD File Offset: 0x0009C6FD
	private new void 3(object 1, EventArgs 2)
	{
		this.42();
		if (1304.164.GetValue() == 1289.LocalPerformance)
		{
			this.54(false);
		}
	}

	// Token: 0x060023FA RID: 9210 RVA: 0x0009E519 File Offset: 0x0009C719
	private void 4(object 1, EventArgs 2)
	{
		this.18(this.65, false, null, false);
		this.42();
	}

	// Token: 0x060023FB RID: 9211 RVA: 0x0009E530 File Offset: 0x0009C730
	internal void 5(1262 1)
	{
		if (1 != null)
		{
			this.78.91(1, true, null, false);
		}
	}

	// Token: 0x060023FC RID: 9212 RVA: 0x0009E544 File Offset: 0x0009C744
	private void 6(object 1, 1262 2)
	{
		this.54 = false;
		1262 3 = 1272.5();
		if (2 != null)
		{
			1272.SetCurrentBeatmap(2);
		}
		bool flag = 3 != 1272.5();
		if ((flag || this.35) && 3 != null)
		{
			3.81();
		}
		if (this.43 != null)
		{
			1433 4 = 1436.1;
			if (4 != null && 4.8 is 2241)
			{
				1436.1 = null;
			}
		}
		if (1272.5() == null)
		{
			return;
		}
		if (flag || this.77)
		{
			this.42();
		}
		bool flag2 = true;
		bool 5 = !flag && (!this.35 || (1226.31 != null && 1226.16 > 10000 && (double)1226.16 < 1226.31.4 - 10000.0));
		this.35 = false;
		if (!this.78.15 && (flag || this.77))
		{
			bool flag3 = 3 != null && 1272.5().37 == 3.37;
			if (flag3 && !this.77)
			{
				5 = true;
				1226.24("select-difficulty", 100, (1416)3, false);
			}
			else
			{
				1226.24("select-expand", 100, (1416)3, false);
			}
			this.44();
			if (!1272.5().59 && 1272.5().28 && !1272.5().65())
			{
				if (!2463.13(true, 1272.5()))
				{
					1763.5("Beatmap\n\n\"" + 1272.5().37 + "\"\n\ncould not be loaded. Files are probably in a bad state, you should delete them.", 198.DarkRed, 10000, delegate
					{
						1662.67(1272.5().44());
					});
				}
				return;
			}
			if (!this.77 && flag3 && 3.22 == 1272.5().22)
			{
				flag2 = false;
			}
			try
			{
				this.45(1272.5(), 5);
			}
			catch
			{
				1763.4(1568.1(2679.SongSelection_AudioError));
				this.54 = true;
			}
			this.77 = false;
			this.9.3.Clear();
			this.9.16 = 0f;
			this.10.3.Clear();
			this.10.16 = 0f;
			this.11.3.Clear();
			this.11.16 = 0f;
			this.12.3.Clear();
			this.12.16 = 0f;
			this.13.3.Clear();
			this.13.16 = 0f;
			this.14.3.Clear();
			this.14.16 = 0f;
			this.9.3.Add(new 1445(1456.Fade, 0f, 1f, 1662.33, 1662.33 + 400, (1046)0));
			this.10.3.Add(new 1445(1456.Fade, 0f, 1f, 1662.33 + 100, 1662.33 + 500, (1046)0));
			this.11.3.Add(new 1445(1456.Fade, 0f, 1f, 1662.33 + 200, 1662.33 + 600, (1046)0));
			this.12.3.Add(new 1445(1456.Fade, 0f, 1f, 1662.33 + 200, 1662.33 + 700, (1046)0));
			this.13.3.Add(new 1445(1456.Fade, 0f, 1f, 1662.33 + 300, 1662.33 + 800, (1046)0));
			this.14.3.Add(new 1445(1456.Fade, 0f, 1f, 1662.33 + 300, 1662.33 + 800, (1046)0));
			if (this.93 != null)
			{
				this.93.3.Clear();
				this.93.16 = 0f;
				this.93.3.Add(new 1445(1456.Fade, 0f, 1f, 1662.33 + 400, 1662.33 + 900, (1046)0));
			}
			this.54(false);
			this.51.3.Clear();
			this.51.3.Add(new 1445(1456.Fade, 0.1f, 0f, 1662.33, 1662.33 + 500, (1046)0));
			this.38(true);
		}
		if (flag2)
		{
			1662.55.6((456)1, null);
		}
	}

	// Token: 0x060023FD RID: 9213 RVA: 0x0009EA20 File Offset: 0x0009CC20
	private void 7(object 1, 2593 2)
	{
		1226.24("select-expand", 100, (1416)3, false);
	}

	// Token: 0x060023FE RID: 9214 RVA: 0x0009EA31 File Offset: 0x0009CC31
	private void 8(object 1, 2593 2)
	{
		if (2 is 2598)
		{
			if (this.78.4.GetValue() == 2591.Collection)
			{
				this.62(2);
				return;
			}
		}
		else
		{
			this.61();
		}
	}

	// Token: 0x060023FF RID: 9215 RVA: 0x0009EA5D File Offset: 0x0009CC5D
	private void 9(object 1, 2593 2)
	{
		this.StartPlay();
	}

	// Token: 0x06002400 RID: 9216 RVA: 0x00005ADD File Offset: 0x00003CDD
	private void 10(object 1, 2593 2)
	{
	}

	// Token: 0x06002401 RID: 9217 RVA: 0x0009EA68 File Offset: 0x0009CC68
	private void 11(2591 1)
	{
		2620 2 = this.78.5.GetValue();
		switch (1)
		{
		case 2591.Artist:
			2 = 2620.Artist;
			break;
		case 2591.BPM:
			break;
		case 2591.Creator:
			2 = 2620.Creator;
			break;
		case 2591.Date:
			2 = 2620.Date;
			break;
		case 2591.Difficulty:
			2 = 2620.Difficulty;
			break;
		case 2591.Length:
			2 = 2620.Length;
			break;
		default:
			if (1 == 2591.Title)
			{
				2 = 2620.Title;
			}
			break;
		}
		if (2 != this.78.5.GetValue())
		{
			this.78.5.SetValue(2);
			this.16.18(2, true);
		}
	}

	// Token: 0x06002402 RID: 9218 RVA: 0x0009EAFC File Offset: 0x0009CCFC
	private void 12(object 1, EventArgs 2)
	{
		if (1 != null)
		{
			2591 3 = (2591)1;
			if (3 != this.65)
			{
				this.11(3);
				this.18(3, false, null, false);
			}
		}
	}

	// Token: 0x06002403 RID: 9219 RVA: 0x0009EB30 File Offset: 0x0009CD30
	private void 13(object 1, List<1262> 2)
	{
		this.26();
		if (!this.58)
		{
			if (this.78.10.Count == 0)
			{
				this.77 = true;
				1247.16(true, true);
				this.18(2591.None, false, null, true);
			}
			else
			{
				this.87(true);
			}
			this.34();
		}
	}

	// Token: 0x06002404 RID: 9220 RVA: 0x0009EB88 File Offset: 0x0009CD88
	private void 14(object 1, EventArgs 2)
	{
		if (1549.3)
		{
			this.78.61();
			this.78.62();
		}
		else if (this.78.15)
		{
			this.78.61();
		}
		else
		{
			this.78.59();
		}
		1226.20(null, "click-short-confirm", 1f, true);
	}

	// Token: 0x06002405 RID: 9221 RVA: 0x0009EBF3 File Offset: 0x0009CDF3
	private void 15()
	{
		this.28.10 = false;
		if (this.56 != null)
		{
			this.56.10 = false;
		}
		1272.SetCurrentBeatmap(null);
		this.54(false);
		1662.55.6((456)1, null);
	}

	// Token: 0x06002406 RID: 9222 RVA: 0x0009EC2E File Offset: 0x0009CE2E
	private void 16()
	{
		this.77 = true;
		this.28.10 = true;
		if (this.56 != null)
		{
			this.56.10 = true;
		}
	}

	// Token: 0x06002407 RID: 9223 RVA: 0x0009EC57 File Offset: 0x0009CE57
	private void 17()
	{
		this.50.4(this.65, true, true);
		this.15.18(this.65, true);
	}

	// Token: 0x06002408 RID: 9224 RVA: 0x0009EC8C File Offset: 0x0009CE8C
	private void 18(2591 1, bool 2, string 3, bool 4)
	{
		2601.2610 5 = new 2601.2610();
		5.1 = this;
		5.2 = 1;
		5.3 = 2;
		5.4 = 3;
		5.5 = 4;
		if (!1272.25 && 5.2 == 2591.Online_Favourites)
		{
			1272.25(new 1189(5.1));
			1272.27();
		}
		if (5.2 == 2591.None)
		{
			5.2 = 2591.Search;
		}
		this.65 = 5.2;
		this.17();
		this.78.20 = false;
		this.78.57(250);
		this.78.30 = 500.0;
		this.78.22(5.2, !this.21 && !this.20, new 1189(5.3));
	}

	// Token: 0x06002409 RID: 9225 RVA: 0x0009ED70 File Offset: 0x0009CF70
	private void 19(object 1, EventArgs 2)
	{
		2620 3 = (2620)1;
		if (3 != this.78.5.GetValue())
		{
			this.78.5.SetValue(3);
			this.78.101();
		}
	}

	// Token: 0x0600240A RID: 9226 RVA: 0x0009EDB4 File Offset: 0x0009CFB4
	internal 2601(1803 1) : base(14)
	{
		2593.19();
		this.35 = (1662.81 == 1677.Play);
		897 15 = new 897();
		15.SetMaxWorkerThreads(1);
		15.Method9344(true);
		15.SetIdleTimeout(1000);
		15.SetThreadPriority(ThreadPriority.BelowNormal);
		this.66 = new 915(15);
		this.17 = 1272.5();
		this.21 = (1662.78 == 1677.SelectPlay);
		this.20 = (1662.78 == 1677.SelectMulti);
		if (!this.20 && this.21)
		{
			2486.15(2601.73);
		}
		2230.4();
		1297.5();
		if (1272.5() != null)
		{
			1272.5().70.Clear();
		}
		2486.88 = null;
		object obj = 1535.37;
		lock (obj)
		{
			1535.2(false);
			1535.40 = false;
		}
		this.26();
		if ((1272.5() == null || string.IsNullOrEmpty(1272.5().37) || !1272.5().28) && (1662.78 == 1677.SelectPlay || 1662.78 == 1677.SelectMulti || 1662.78 == 1677.SelectEdit))
		{
			if (2230.4.Count == 0)
			{
				1262 3 = 1272.3.FirstOrDefault(new Func<1262, bool>(2601.2616.Instance.1));
				if (3 != null)
				{
					1247.17(3, true, true);
				}
				else
				{
					1247.16(true, true);
				}
			}
			else
			{
				1247.16(true, true);
			}
		}
		1549.5(new 1549.1551(this.49));
		1549.3(new 1549.1550(this.48));
		1546.1(new 1546.1547(this.47));
		2019.1(new 2019.2022(this.80));
		1304.206.SubscribeChanged(new EventHandler(this.1));
		1304.207.SubscribeChanged(new EventHandler(this.1));
		1304.172.SubscribeChanged(new EventHandler(this.2));
		1304.119.SubscribeChanged(new EventHandler(this.4));
		1304.25.SubscribeChanged(new EventHandler(this.3));
		this.78 = new 2573(14);
		this.78.3(new 2573.2575(this.6));
		this.78.5(new 2573.2580(this.7));
		this.78.7(new 2573.2580(this.8));
		this.78.9(new 2573.2580(this.9));
		this.78.11(new 2573.2580(this.35));
		this.78.13(new 2573.2580(this.10));
		this.78.15(new 1189(this.15));
		this.78.17(new 1189(this.16));
		1272.2(new 1272.1273(this.13));
		if (2486.70 != null)
		{
			this.41 = 2486.70;
		}
		else
		{
			this.41 = new 1436(true);
		}
		this.43 = new 1417(new 207(-5, 92, 290, 267), 208.Zero, true, 0f, 1545.Default)
		{
			6 = true,
			29 = true
		};
		this.40 = new 1436(true);
		this.42 = new 1436(true);
		this.39 = new 1436(true);
		this.9 = new 1452(" ", 18f, new 208(21f, -3f), 208.Zero, 0.79f, true, 198.White, false);
		this.9.GetTextSize();
		this.39.12(this.9);
		this.10 = new 1452(string.Empty, 12f, new 208(23f, 12f), 208.Zero, 0.79f, true, 198.White, false);
		this.39.12(this.10);
		this.11 = new 1452(string.Empty, 12f, new 208(1f, 24f), 208.Zero, 0.79f, true, 198.White, false);
		this.39.12(this.11);
		this.12 = new 1452(string.Empty, 12f, new 208(1f, 36f), 208.Zero, 0.79f, true, 198.White, false);
		this.39.12(this.12);
		this.13 = new 1452(string.Empty, 8f, new 208(1f, 48f), 208.Zero, 1f, true, 198.White, false);
		this.39.12(this.13);
		this.14 = new 1452(string.Empty, 8f, new 208(1f, 56f), 208.Zero, 1f, true, 198.White, false);
		this.39.12(this.14);
		this.93 = new 1452(string.Empty, 8f, new 208(1f, 56f), 208.Zero, 1f, true, new 198(byte.MaxValue, 214, 102), false);
		this.93.52 = "pp of a full combo with the selected mods, at these accuracies (100s only)";
		this.93.10 = true;
		this.39.12(this.93);
		this.19 = new 1452(string.Empty, 20f, new 208(5f, -1f), 1f, true, new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 128))
		{
			41 = (1376)8,
			49 = 1065.TopRight,
			8 = 0.0
		};
		this.39.12(this.19);
		this.48 = 1455.2("selection-ranked", (1416)1, null);
		this.49 = 1455.2("selection-question", (1416)1, null);
		this.47 = 1455.2("selection-approved", (1416)1, null);
		this.46 = 1455.2("selection-loved", (1416)1, null);
		this.45 = new 1433(this.48, (1376)6, 1065.Centre, (1044)0, new 208(12f, 12f), 0.78f, true, 198.TransparentWhite, null);
		this.39.12(this.45);
		this.51 = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, 208.Zero, 1f, true, 198.TransparentWhite, null);
		this.51.66 = false;
		this.51.28 = true;
		this.51.20 = new 208((float)1662.70.1, (float)1662.70.2);
		this.39.12(this.51);
		this.29 = new 1433(1662.34, (1376)8, 1065.TopLeft, (1044)0, new 208(3f, 73f), 0.88f, true, new 198(0, 0, 0, 128), null);
		this.29.15 = 1.6f;
		this.29.20 = new 208(3f, 330f);
		this.30 = new 1433(1662.34, (1376)8, 1065.TopLeft, (1044)0, new 208(3f, 73f), 0.89f, true, new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue), null);
		this.30.15 = 1.6f;
		this.30.20 = new 208(3f, 20f);
		this.39.12(this.29);
		this.39.12(this.30);
		if (this.21 || this.20)
		{
			int num;
			int num2;
			if (!2630.21())
			{
				num = ((1455.2("selection-mods", (1416)7, null).6 == (1416)1) ? 1 : 0);
				if (num == 0)
				{
					num2 = 6;
					goto IL_1811;
				}
			}
			else
			{
				num = 1;
			}
			num2 = 12;
			IL_1811:
			1376 4 = (1376)num2;
			1065 5 = (num != 0) ? 1065.BottomLeft : 1065.TopLeft;
			float 6 = (float)((num == 0) ? 426 : 0);
			float num3 = (float)(1662.70.7() ? 140 : 120);
			if (2601.72)
			{
				this.70 = new 1433(1455.2("selection-mode", (1416)7, null), 4, 5, (1044)0, new 208(num3, 6), 0.95f, true, 198.White, null);
				this.39.12(this.70);
				this.70 = new 1433(1455.2("selection-mode-over", (1416)7, null), 4, 5, (1044)0, new 208(num3, 6), 0.96f, true, 198.White, null);
				this.70.16 = 0.01f;
				this.70.42 = new 1445(1456.Fade, 0.01f, 1f, 0, 100, (1046)0);
				this.70.10 = true;
				this.70.35(new EventHandler(2601.2616.Instance.2));
				this.70.3(new EventHandler(this.85));
				this.39.12(this.70);
				this.71 = new 1483(this.39);
				float num4 = 80f;
				208 7 = new 208(num3, 424f - num4);
				for (int i = 0; i < 4; i++)
				{
					2601.2612 modeButton = new 2601.2612();
					modeButton.4 = this;
					modeButton.3 = (2147)i;
					2601.2612 modeButton2 = modeButton;
					1381 8;
					switch (modeButton.3)
					{
					case 2147.Taiko:
						8 = 1455.2("mode-taiko-med", (1416)7, null);
						break;
					case 2147.CatchTheBeat:
						8 = 1455.2("mode-fruits-med", (1416)7, null);
						break;
					case 2147.OsuMania:
						8 = 1455.2("mode-mania-med", (1416)7, null);
						break;
					default:
						8 = 1455.2("mode-osu-med", (1416)7, null);
						break;
					}
					modeButton2.1 = new 1433(8, (1376)6, 1065.Centre, (1044)0, 7 + new 208(num4 / 2f, num4 / 2f), 0.991f, true, 198.TransparentWhite, null);
					this.40.12(modeButton.1);
					1452 9 = new 1452(2148.1(modeButton.3), 24f, 7 + new 208(num4 + 10f, num4 / 2f), 0.992f, true, 198.TransparentWhite);
					9.49 = 1065.CentreLeft;
					9.54(true);
					9.63(true);
					modeButton.2 = 9;
					this.40.12(modeButton.2);
					1482 10 = new 1482(this.71, this.40, new 208(num4 * 3.5f * 1.6f, num4 * 1.6f), 7, false);
					10.5.Add(modeButton.1);
					10.5.Add(modeButton.2);
					10.11.35(delegate(object 1, EventArgs 2)
					{
						1226.20(null, "click-short", 1f, false);
						1381 texture = modeButton.1.GetTexture();
						if (texture != null && texture.6 == (1416)1)
						{
							modeButton.1.25(1.1f, 1000, (1046)25);
						}
						modeButton.2.19(modeButton.2.7 + new 208(10f, 0f), 300, (1046)1);
					});
					10.11.37(delegate(object 1, EventArgs 2)
					{
						1381 texture = modeButton.1.GetTexture();
						if (texture != null && texture.6 == (1416)1)
						{
							modeButton.1.25(1f, 1000, (1046)25);
						}
						modeButton.2.19(modeButton.2.7, 300, (1046)1);
					});
					10.1(new EventHandler(modeButton.OnClick));
					this.71.1.Add(10);
					7.Y -= num4;
				}
				num3 += 57.6f;
			}
			if (!this.20)
			{
				this.6 = new 1433(1455.2("selection-mods", (1416)7, null), 4, 5, (1044)0, new 208(num3, 6), 0.95f, true, 198.White, null);
				this.39.12(this.6);
				this.6 = new 1433(1455.2("selection-mods-over", (1416)7, null), 4, 5, (1044)0, new 208(num3, 6), 0.96f, true, 198.White, null);
				this.6.16 = 0.01f;
				this.6.42 = new 1445(1456.Fade, 0.01f, 1f, 0, 100, (1046)0);
				this.6.35(new EventHandler(2601.2616.Instance.3));
				this.6.10 = true;
				this.6.3(new EventHandler(this.82));
				this.39.12(this.6);
				num3 += 48f;
			}
			if (this.20 || this.21)
			{
				this.8 = new 1433(1455.2("selection-random", (1416)7, null), 4, 5, (1044)0, new 208(num3, 6), 0.95f, true, 198.White, null);
				this.39.12(this.8);
				this.8 = new 1433(1455.2("selection-random-over", (1416)7, null), 4, 5, (1044)0, new 208(num3, 6), 0.96f, true, 198.White, null);
				this.8.16 = 0.01f;
				this.8.42 = new 1445(1456.Fade, 0.01f, 1f, 0, 100, (1046)0);
				this.8.35(delegate(object 1, EventArgs 2)
				{
					1226.20(null, "click-short", 1f, false);
				});
				this.8.10 = true;
				this.8.3(new EventHandler(this.14));
				this.39.12(this.8);
				num3 += 48f;
			}
			this.7 = new 1433(1455.2("selection-options", (1416)7, null), 4, 5, (1044)0, new 208(num3, 6), 0.95f, true, 198.White, null);
			this.39.12(this.7);
			this.7 = new 1433(1455.2("selection-options-over", (1416)7, null), 4, 5, (1044)0, new 208(num3, 6), 0.96f, true, 198.White, null);
			this.7.16 = 0.01f;
			this.7.35(delegate(object 1, EventArgs 2)
			{
				1226.20(null, "click-short", 1f, false);
			});
			this.7.42 = new 1445(1456.Fade, 0.01f, 1f, 0, 100, (1046)0);
			this.7.10 = true;
			this.7.3(new EventHandler(this.27));
			this.39.12(this.7);
			num3 += 48f;
			num3 += 48f;
			1662.100.17(new 208(num3, 429f), false, 0);
			this.39.14<1433>(1662.100.36);
			2210.7();
		}
		else
		{
			2601.2608 dropHintHover = new 2601.2608();
			2019.1 = 2023.None;
			dropHintHover.1 = new 1433(1455.2("selection-drop", (1416)1, null), new 208(117f, 220f), 0.5f, true, 198.White);
			dropHintHover.1.49 = 1065.Centre;
			dropHintHover.1.UpdateOriginOffset();
			dropHintHover.1.15 = 0.85f;
			dropHintHover.1.10 = true;
			dropHintHover.1.35(delegate(object 1, EventArgs 2)
			{
				dropHintHover.1.25(0.75f, 2000, (1046)1);
			});
			dropHintHover.1.37(new EventHandler(dropHintHover.14));
			this.39.12(dropHintHover.1);
			1433 11 = new 1433(1455.2("featured", (1416)1, null), new 208(10f, 280f), 0.5f, true, 198.White)
			{
				15 = 0.85f
			};
			this.39.12(11);
			11 = new 1433(1455.2("featured-hover", (1416)1, null), new 208(10f, 280f), 0.55f, true, 198.White);
			11.16 = 0.01f;
			11.10 = true;
			11.42 = new 1445(1456.Fade, 0.01f, 1f, 0, 150, (1046)0);
			11.3(new EventHandler(2601.2616.Instance.4));
			11.15 = 0.85f;
			this.39.12(11);
		}
		if (this.21 || this.20)
		{
			if (!1308.1)
			{
				new 198(30, 30, 30);
			}
			else
			{
				198 black = 198.Black;
			}
			this.75 = new 1373(this.39, string.Empty, new 208(5f, 73.5f), 190f, 1f);
			this.75.10.60(new 198(31, 184, byte.MaxValue, 180));
			this.75.10.66(14f);
			if (1304.164.GetValue() == 1289.Country || 1304.164.GetValue() == 1289.Friends)
			{
				1304.164.SetValue(1289.Top);
			}
			this.75.10(1568.1(2679.SongSelection_Rank_Local), 1289.Local);
			this.75.10("Local Ranking (pp)", 1289.LocalPerformance);
			if (261.FullyOffline)
			{
				if (1304.164.GetValue() != 1289.Local && 1304.164.GetValue() != 1289.LocalPerformance)
				{
					1304.164.SetValue(1289.Local);
				}
			}
			else
			{
				this.75.10(1568.1(2679.SongSelection_Rank_Top), 1289.Top);
				this.75.10(1568.1(2679.SongSelection_Rank_Mod), 1289.SelectedMod);
			}
			this.75.18(1304.164.GetValue(), true);
			this.75.1(new EventHandler(this.60));
		}
		this.22 = new 1433(1455.2("rank-forum", (1416)7, null), (1376)6, 1065.Centre, (1044)0, new 208(214f, 81f), 0.95f, true, 198.TransparentWhite, null);
		this.22.35 = 25;
		this.22.34 = 25;
		this.22.3(delegate(object 1, EventArgs 2)
		{
			1689 16 = new 1689(1568.1(2679.SongSelection_OpenOptions), true);
			16.7(1568.1(2679.SongSelection_ListingScores), 198.OrangeRed, new EventHandler(2601.2616.Instance.11), true, false, true);
			16.7(1568.1(2679.SongSelection_Topic), 198.YellowGreen, new EventHandler(2601.2616.Instance.12), true, false, true);
			16.7(1568.1(2679.General_Cancel), 198.Gray, null, true, false, true);
			1662.25(16);
		});
		this.22.10 = true;
		this.22.52 = 1568.1(2679.SongSelection_WebAccess);
		this.22.12 = new 1445(1456.Scale, 1.1f, 1f, 0, 50, (1046)0);
		this.39.12(this.22);
		this.26 = new 1433(1455.2("menu-nekiosu", (1416)1, null), (1376)8, 1065.Centre, (1044)0, new 208(40f, 450f), 0.9f, true, 198.White, null);
		this.26.15 = 0.4f;
		this.39.12(this.26);
		this.27 = new 1433(1455.2("menu-nekiosu", (1416)1, null), (1376)8, 1065.Centre, (1044)0, new 208(40f, 450f), 0.91f, true, 198.White, null);
		this.27.15 = 0.4f;
		this.39.12(this.27);
		this.28 = new 1367(1455.2("menu-nekiosu", (1416)1, null), new 208(40f, 450f), 1f, true, 198.White, 250)
		{
			41 = (1376)8,
			49 = 1065.Centre
		};
		this.28.16 = 0.01f;
		this.28.3(new EventHandler(this.84));
		this.28.10 = true;
		this.28.15 = 0.55f;
		this.28.45 = -100f;
		this.28.42 = new 1445(1456.Fade, 0.01f, 1f, 0, 100, (1046)0);
		this.39.12(this.28);
		this.34 = new 1354(new EventHandler(this.28), true, false);
		if (!this.20)
		{
			this.39.14<1433>(this.34.1);
		}
		this.50 = new 1498(this.39, 6, new 208((float)(1662.70.1() - 55), 49f), 0.87f, true, 198.Crimson, 0, true);
		this.50.19 = 0.8f;
		1452 12 = new 1452(1568.1(2679.SongSelection_Sort), 22f, new 208((float)(1662.70.1() - 130), 40f), 0.86f, true, new 198(174, 210, 139))
		{
			49 = 1065.BottomRight
		};
		this.39.12(12);
		float x = 12.GetTextSize().X;
		this.80 = new 1452(" ", 12f, new 208(5f, -1f), 1f, true, 198.White)
		{
			41 = (1376)8,
			49 = 1065.TopRight,
			16 = 0f
		};
		this.39.12(this.80);
		this.16 = new 1373(this.39, "Choice2", new 208((float)(1662.70.1() - 130), 18f));
		this.16.11 = new 198(174, 210, 139);
		this.16.10.60(1045.3(this.16.11, 0.2f));
		this.16.10.72 = 1;
		12 = new 1452(1568.1(2679.SongSelection_Group), 22f, new 208((float)(1662.70.1() - 140 - 118) - x, 40f), 0.86f, true, new 198(146, 195, 230))
		{
			49 = 1065.BottomRight
		};
		this.39.12(12);
		this.15 = new 1373(this.39, "Choice1", new 208((float)(1662.70.1() - 140 - 118) - x, 18f));
		this.15.11 = new 198(146, 195, 230);
		this.15.10.60(1045.3(this.15.11, 0.2f));
		this.15.10.72 = 1;
		this.15.1(delegate(object 1, EventArgs 2)
		{
			this.12(1, null);
		});
		this.16.1(new EventHandler(this.19));
		this.16.10(1568.1(2679.SongSelection_ByArtist), 2620.Artist);
		this.16.10(1568.1(2679.SongSelection_ByBPM), 2620.BPM);
		this.16.10(1568.1(2679.SongSelection_ByCreator), 2620.Creator);
		this.16.10(1568.1(2679.SongSelection_ByDateAdded), 2620.Date);
		this.16.10(1568.1(2679.SongSelection_ByDifficulty), 2620.Difficulty);
		this.16.10(1568.1(2679.SongSelection_ByLength), 2620.Length);
		this.16.10(1568.1(2679.SongSelection_ByRankAchieved), 2620.Rank);
		this.16.10(1568.1(2679.SongSelection_ByTitle), 2620.Title);
		this.16.7.ForEach(new Action<1433>(2601.2616.Instance.5));
		this.16.18(this.78.5.GetValue(), true);
		this.50.AddTab(1568.1(2679.SongSelection_NoGrouping), 2591.Search, false);
		if (this.21 || this.20)
		{
			this.50.AddTab(1568.1(2679.SongSelection_ByDifficulty), 2591.Difficulty, false);
			this.50.AddTab(1568.1(2679.SongSelection_ByArtist), 2591.Artist, false);
		}
		else
		{
			this.50.AddTab(1568.1(2679.SongSelection_MyMaps), 2591.My_Maps, false);
			this.50.AddTab(1568.1(2679.SongSelection_ByCreator), 2591.Creator, false);
		}
		this.50.AddTab(1568.1(2679.SongSelection_RecentlyPlayed), 2591.Last_Played, false);
		if (1662.70.1() > 720)
		{
			this.50.AddTab(1568.1(2679.SongSelection_Collections), 2591.Collection, false);
		}
		this.50.1(new EventHandler(this.12));
		this.38 = new 1452(1568.1(2679.SongSelection_Search), 13f, new 208(220f, 54f), 208.Zero, 0.81f, true, 198.White, false);
		this.38.41 = (1376)8;
		this.38.54(true);
		this.38.62(198.GreenYellow);
		this.39.12(this.38);
		this.33 = new 1404(13, new 208(this.38.27().X + this.38.GetTextSize().X, 54f), 174f, true, 0.98f);
		this.33.22(false);
		this.33.24(!1662.104.15());
		this.33.26(1568.1(2679.SongSelection_TypeToBegin));
		this.33.1.54(true);
		this.33.4(new 1448.1449(this.86));
		this.39.14<1433>(this.33.2);
		this.32 = new 1452(string.Empty, 11f, new 208(220f, 66f), 208.Zero, 0.81f, true, 198.White, false);
		this.32.54(true);
		this.32.41 = (1376)8;
		this.39.12(this.32);
		this.31 = new 1433(1455.2("menu-button-background", (1416)1, null), (1376)8, 1065.Centre, (1044)0, new 208(14f, 46f), 0.69f, true, new 198(0, 0, 0, 102), null);
		this.39.12(this.31);
		this.69 = new 1433(1455.2("songselect-top", (1416)7, null), (1376)6, 1065.TopLeft, (1044)0, new 208(0f, 0f), 0.7f, true, 198.White, null);
		this.39.12(this.69);
		if (1662.70.1 > 1366)
		{
			this.69 = new 1433(1455.2("songselect-top", (1416)7, null), (1376)6, 1065.TopLeft, (1044)0, new 208(1365f / 1662.70.3(), 0f), 0.7f, true, 198.White, null);
			this.69.36 = 1365;
			this.69.35 = 1;
			this.69.20 = new 208((float)(1662.70.1 - 1365), 1f);
			this.39.12(this.69);
		}
		1433 13 = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, new 208(0f, -10f), 0f, true, 198.Black, null)
		{
			20 = new 208((float)(1662.70.1() + 1) * 1.6f, 97f),
			10 = true
		};
		if (this.69.GetTexture().6 != (1416)1)
		{
			13.16 = 0.001f;
		}
		this.39.12(13);
		13 = new 1433(1455.2("songselect-bottom", (1416)7, null), (1376)6, 1065.BottomLeft, (1044)0, new 208(0f, 480f), 0.7f, true, 198.White, null);
		13.20 = new 208((float)1662.70.1 / 1662.70.3() / ((float)13.35 * 0.625f), 1f);
		13.10 = true;
		this.39.12(13);
		this.76 = 2468.1(198.White);
		this.76.41 = (1376)6;
		this.76.17 = new 208(118f, 200f);
		this.76.16(0, (1046)0, 0);
		this.39.12(this.76);
		bool flag2 = 1272.14 != null;
		if (flag2)
		{
			1272.SetCurrentBeatmap(1272.14);
			1272.14 = null;
		}
		this.18(this.78.4.GetValue(), 2601.37 != null || flag2, 2601.37, flag2);
		2601.37 = null;
		if (!string.IsNullOrEmpty(2601.36))
		{
			this.33.SetText(2601.36);
			this.87(true);
			2601.36 = null;
		}
		1662.71(delegate
		{
			if (1662.77 != 1677.Menu)
			{
				2601.36 = (string.IsNullOrEmpty(this.33.GetText()) ? null : this.33.GetText());
			}
		});
		this.18 = new 1452(string.Empty, 30f, new 208(60f, 397f), 0.3f, true, new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 128));
		this.18.64(true);
		this.39.12(this.18);
		this.78();
	}

	// Token: 0x0600240B RID: 9227 RVA: 0x000A0CFC File Offset: 0x0009EEFC
	private bool 20()
	{
		return this.4;
	}

	// Token: 0x0600240C RID: 9228 RVA: 0x000A0D04 File Offset: 0x0009EF04
	private void 21(bool 1)
	{
		this.4 = 1;
		this.78.20 = this.4;
	}

	// Token: 0x0600240D RID: 9229 RVA: 0x000A0D1E File Offset: 0x0009EF1E
	private bool 22()
	{
		return 1304.164 != 1289.Local && 1304.164 != 1289.LocalPerformance;
	}

	// Token: 0x0600240E RID: 9230 RVA: 0x000A0D40 File Offset: 0x0009EF40
	private void 23()
	{
		if (this.90 != 1633.Version)
		{
			this.90 = 1633.Version;
			1262 <<EMPTY_NAME>> = 1272.5();
			if (<<EMPTY_NAME>> != null)
			{
				this.44();
				int num = (int)(<<EMPTY_NAME>>.85 * (1281)2 + ((<<EMPTY_NAME>>.97 > false) ? 1 : 0));
				if (<<EMPTY_NAME>> != this.91 || num != this.92)
				{
					bool flag = <<EMPTY_NAME>> == this.91;
					this.91 = <<EMPTY_NAME>>;
					this.92 = num;
					if (flag)
					{
						this.54(false);
					}
				}
			}
		}
		if (!this.21 || 1662.78 != 1677.SelectPlay)
		{
			return;
		}
		2023 2 = 2019.1;
		1940 3 = 1939.16(2);
		double num2 = 1939.17(2, 3) * 100.0;
		bool flag2 = (2 & 2023.Nightcore) != 2023.None || (3 != null && 3.AdjustPitch);
		if (!1304.10.1())
		{
			num2 = 100.0;
			flag2 = false;
		}
		1240 4 = 1226.31;
		float num3 = 1933.Current;
		if ((Math.Abs(num2 - 100.0) > 0.01 || num3 != 0f) && 4 != null && !4.2 && 4.IsDirectStream() && 4.1 != null && 4 != this.89)
		{
			this.89 = 4;
			try
			{
				int num4 = 1226.16;
				bool flag3 = 1226.32 == (1042)1;
				1226.99(4.1, false, false, true, false);
				1226.31.Seek((double)num4);
				if (flag3)
				{
					1226.31.Play(false);
				}
			}
			catch (Exception)
			{
				return;
			}
		}
		if (1226.41 != flag2 || Math.Abs(1226.38() - num2) > 0.01)
		{
			1226.41 = flag2;
			1226.39(num2);
		}
		1240 5 = 1226.31;
		if (5 == null)
		{
			return;
		}
		5.SetPitchShift(num3);
	}

	// Token: 0x0600240F RID: 9231 RVA: 0x000A0F08 File Offset: 0x0009F108
	private void 24()
	{
		if (this.21 && 1662.78 != 1677.Play && 1662.77 != 1677.Play)
		{
			1226.41 = false;
			1226.39(100.0);
			1240 <<EMPTY_NAME>> = 1226.31;
			if (<<EMPTY_NAME>> == null)
			{
				return;
			}
			<<EMPTY_NAME>>.SetPitchShift(0f);
		}
	}

	// Token: 0x06002410 RID: 9232 RVA: 0x000A0F58 File Offset: 0x0009F158
	protected override void Dispose(bool 1)
	{
		this.24();
		if (this.78.15)
		{
			this.78.61();
			this.46(true);
		}
		bool flag = 1662.78 == 1677.Play;
		this.25(flag);
		this.78.Dispose();
		1373 2 = this.75;
		if (2 != null)
		{
			2.17();
		}
		1373 3 = this.16;
		if (3 != null)
		{
			3.17();
		}
		1373 4 = this.15;
		if (4 != null)
		{
			4.17();
		}
		if (this.71 != null)
		{
			this.71.Dispose();
		}
		if (this.39 != null)
		{
			this.39.Dispose();
		}
		if (this.40 != null)
		{
			this.40.Dispose();
		}
		if (this.42 != null)
		{
			this.42.Dispose();
		}
		if (this.43 != null)
		{
			this.43.Dispose();
		}
		if (!flag)
		{
			this.41.Dispose();
		}
		this.58 = true;
		base.Dispose(1);
	}

	// Token: 0x06002411 RID: 9233 RVA: 0x000A1054 File Offset: 0x0009F254
	private void 25(bool 1)
	{
		if (this.59)
		{
			return;
		}
		if (1)
		{
			this.41.28.ForEach(new Action<1371>(2601.2616.Instance.6));
			2486.70 = this.41;
		}
		try
		{
			915 calculator = this.66;
			new Thread(delegate()
			{
				try
				{
					calculator.Method4890(true, 5000);
					calculator.Dispose();
				}
				catch
				{
				}
			})
			{
				IsBackground = true,
				Name = "Song select difficulty shutdown"
			}.Start();
		}
		catch
		{
		}
		2601.72 = true;
		2601.73.SetValue(2486.14());
		1549.6(new 1549.1551(this.49));
		1549.4(new 1549.1550(this.48));
		1546.2(new 1546.1547(this.47));
		1272.3(new 1272.1273(this.13));
		this.78.4(new 2573.2575(this.6));
		this.78.6(new 2573.2580(this.7));
		this.78.8(new 2573.2580(this.8));
		this.78.10(new 2573.2580(this.9));
		this.78.12(new 2573.2580(this.35));
		this.78.14(new 2573.2580(this.10));
		this.78.16(new 1189(this.15));
		this.78.18(new 1189(this.16));
		2598 2 = this.78.77();
		2601.37 = ((2 == null || !2.23()) ? null : 2.GetDisplayTitle());
		2019.2(new 2019.2022(this.80));
		1304.206.UnsubscribeChanged(new EventHandler(this.1));
		1304.207.UnsubscribeChanged(new EventHandler(this.1));
		1304.172.UnsubscribeChanged(new EventHandler(this.2));
		1304.119.UnsubscribeChanged(new EventHandler(this.4));
		1304.25.UnsubscribeChanged(new EventHandler(this.3));
		if (this.87 != null)
		{
			this.87.Abort();
		}
		this.33.Dispose();
		this.59 = true;
	}

	// Token: 0x06002412 RID: 9234 RVA: 0x000A12C0 File Offset: 0x0009F4C0
	private bool 26()
	{
		if (1272.3.Count == 0 || (this.21 && 1272.3.Count - 1272.16 == 0))
		{
			this.58 = true;
			if (1308.1 && !261.FullyOffline)
			{
				1662.SetMode(1677.OnlineSelection, false);
			}
			else
			{
				int num = 5000;
				1763.2(1568.1(2679.SongSelection_NoBeatmaps), num, (1389)0);
				1662.89.2(new 1189(2601.2616.Instance.14), num / 2, false);
				1662.89.2(delegate
				{
					1662.SetMode(1677.Menu, false);
				}, num, false);
			}
			return false;
		}
		return true;
	}

	// Token: 0x06002413 RID: 9235 RVA: 0x000A1380 File Offset: 0x0009F580
	private void 27(object 1, EventArgs 2)
	{
		1226.20(null, "click-short-confirm", 1f, false);
		this.61();
	}

	// Token: 0x06002414 RID: 9236 RVA: 0x000A13AC File Offset: 0x0009F5AC
	public override void Update()
	{
		this.23();
		if (1662.92 != null)
		{
			this.57 = true;
			this.21(false);
		}
		if (!this.5)
		{
			1534.4(14000);
			this.43.Update();
			if (this.24 != null && 1662.23)
			{
				this.24.16 = (float)((80.0 - 1226.68 * 30.0) / 255.0) * ((this.55 == null) ? 1f : (1f - this.55.16 / 2f));
			}
			if (1662.92 == null && this.57)
			{
				this.57 = false;
				this.21(true);
			}
			this.33.24(this.20() && !1662.104.15());
		}
		if (this.51.16 > 0f && 1662.76 == (932)2)
		{
			1356.6 = 0.004f;
			1356.7 = 0f;
			1356.4 = true;
			1356.5 = false;
			1356.1 = true;
			1356.2 = this.51.16 / 1.18f;
		}
		string text = 2019.14(2019.1, false);
		1940 <<EMPTY_NAME>> = this.21 ? 1939.16(2019.1) : null;
		if (<<EMPTY_NAME>> != null && 1939.11(2019.1))
		{
			text = text + " (" + <<EMPTY_NAME>>.1() + ")";
		}
		if (this.21 && 1926.Enabled)
		{
			text = text + ((text.Length > 0) ? "," : string.Empty) + "DifficultyAdjust";
		}
		if (this.21 && 1931.3(2486.14()))
		{
			text = text + ((text.Length > 0) ? "," : string.Empty) + "NoNotelock";
		}
		if (this.21 && 1936.Enabled)
		{
			text = text + ((text.Length > 0) ? "," : string.Empty) + "Practice";
		}
		if (this.21 && 1933.Enabled)
		{
			text = text + ((text.Length > 0) ? "," : string.Empty) + "Pitch " + 1933.3(1933.Semitones);
		}
		if (this.21)
		{
			1925 2 = 1925.15(2486.14(), 2019.1);
			if (2 != null)
			{
				foreach (string str in 2.2())
				{
					text = text + ((text.Length > 0) ? "," : string.Empty) + str;
				}
			}
		}
		this.18.SetText(text);
		if (!this.58)
		{
			this.87(false);
			this.78.21 = (1436.1 == null);
			this.78.Update();
			if (!this.5 && this.78.20)
			{
				this.78.30 = 0.0;
			}
			this.38(false);
			if (!this.59)
			{
				this.46(false);
				this.36();
			}
			this.50();
			this.30.19(new 208(this.30.17.X, 73f + (float)(310.0 * this.78.64())), 30, (1046)1);
			base.Update();
		}
	}

	// Token: 0x06002415 RID: 9237 RVA: 0x000A1748 File Offset: 0x0009F948
	public override void Draw()
	{
		if (this.58)
		{
			return;
		}
		if (this.78.20 && !this.5 && this.78.82() && this.78.79().16() && !this.78.15 && 1226.16 != 1226.18 && 1226.75() && 1226.76() > 150.0 && Math.Abs((double)(1226.16 + 300) - 1226.79()) % 1226.76() < Math.Min(100.0, 1226.76() / 10.0))
		{
			if (this.44 == null)
			{
				this.44 = 1455.2("star2", (1416)7, null);
			}
			for (int i = 0; i < 5; i++)
			{
				1433 <<EMPTY_NAME>> = new 1433(this.44, (1376)8, 1065.Centre, (1044)0, 208.Zero, 0.111f, false, 198.White, null);
				<<EMPTY_NAME>>.28 = true;
				<<EMPTY_NAME>>.15 = 0.8f;
				1445 2 = new 1445(1456.Scale, 1f, 2f, 1662.33, 1662.33 + 1000, (1046)0);
				2.15 = (1046)1;
				<<EMPTY_NAME>>.3.Add(2);
				2 = new 1445(1456.Fade, 1f, 0f, 1662.33, 1662.33 + 1000, (1046)0);
				2.15 = (1046)1;
				<<EMPTY_NAME>>.3.Add(2);
				2 = new 1445(1456.Rotation, 1196.7(-2f, 2f), 1196.7(-2f, 2f), 1662.33, 1662.33 + 1000, (1046)0);
				2.15 = (1046)1;
				<<EMPTY_NAME>>.3.Add(2);
				208 3 = new 208(-100f, (float)(this.78.79().44.Y + this.78.66()) + (float)1196.2(-20, 20));
				208 4 = 3 + new 208((float)1196.2(140, 900), 0f);
				2 = new 1445(3, 4, 1662.33, 1662.33 + 1000, (1046)0);
				2.15 = (1046)1;
				<<EMPTY_NAME>>.3.Add(2);
				this.41.12(<<EMPTY_NAME>>);
			}
		}
		int num = 1662.33 % 1000;
		int num2 = 1000;
		if (1272.5() != null && !this.78.15 && 1226.75() && 1226.64() > 0.0)
		{
			num = (int)(1226.64() % 1226.76());
			num2 = (int)1226.76();
		}
		this.26.15 = 1052.8((float)num, 0.45f, 0.4f, (float)num2);
		this.27.16 = 1052.8((float)num, 0.7f, 0f, (float)num2);
		this.27.15 = 1052.8((float)num, 0.45f, 0.49f, (float)num2);
		base.Draw();
		this.41.22();
		this.78.Draw();
		this.42.22();
		this.43.21();
		this.40.22();
		this.39.22();
	}

	// Token: 0x06002416 RID: 9238 RVA: 0x000A1AC0 File Offset: 0x0009FCC0
	public override void Initialize()
	{
		if (this.26())
		{
			base.Initialize();
			2019.7(2023.None);
			bool flag = this.78.20;
			this.21(true);
			this.78.20 = flag;
			if (!2601.79 && (this.21 || this.20) && (!1304.206.5() || !1304.207.5()))
			{
				2601.79 = true;
				1763.5(1568.1(2679.SongSelection_DifficultyFilteredWarning), 198.Beige, 10000, new 1189(2601.2616.Instance.18));
			}
		}
	}

	// Token: 0x06002417 RID: 9239 RVA: 0x000A1B64 File Offset: 0x0009FD64
	private void 28(object 1, EventArgs 2)
	{
		this.21(false);
		if (this.20)
		{
			if (this.17 != null)
			{
				1272.SetCurrentBeatmap(this.17);
				try
				{
					1226.99(1272.5(), false, true, true, false);
				}
				catch
				{
				}
			}
			1662.SetMode(1677.MatchSetup, false);
			return;
		}
		1662.SetMode(1677.Menu, false);
	}

	// Token: 0x06002418 RID: 9240 RVA: 0x000A1BC8 File Offset: 0x0009FDC8
	private static List<string> 29(string 1)
	{
		2601.2614 quoteState = new 2601.2614();
		List<string> list = new List<string>();
		StringBuilder stringBuilder = new StringBuilder();
		quoteState.2 = 2.Count((char 1) => 1 == '"');
		if (quoteState.2 % 2 != 0)
		{
			quoteState.2--;
		}
		quoteState.1 = 0;
		quoteState.4 = ' ';
		quoteState.3 = false;
		Func<bool> func = () => quoteState.1 < quoteState.2 && (quoteState.3 || quoteState.4 == '=');
		for (int i = 0; i < 2.Length; i++)
		{
			char c = 2[i];
			if (c != ' ' | quoteState.3)
			{
				if (c == '"' && func())
				{
					quoteState.3 = !quoteState.3;
					quoteState.1++;
				}
				else
				{
					stringBuilder.Append(c);
				}
			}
			else
			{
				string text = stringBuilder.ToString();
				if (text != string.Empty)
				{
					list.Add(text);
				}
				stringBuilder.Clear();
			}
			quoteState.4 = c;
		}
		if (stringBuilder.Length > 0)
		{
			list.Add(stringBuilder.ToString());
		}
		return list;
	}

	// Token: 0x06002419 RID: 9241 RVA: 0x000A1D48 File Offset: 0x0009FF48
	private static 2601.2603 30(string 1)
	{
		2601.2609 textFilter = new 2601.2609();
		textFilter.2 = 4;
		Match match = 2601.82.Match(textFilter.2);
		if (match.Success)
		{
			2601.2606 comparisonFilter = new 2601.2606();
			string text = match.Groups[1].Value.ToLower();
			comparisonFilter.1 = match.Groups[2].Value;
			comparisonFilter.3 = match.Groups[3].Value.ToLower();
			if (comparisonFilter.1 == "=")
			{
				comparisonFilter.1 = "==";
			}
			Match match2 = 2601.83.Match(comparisonFilter.3);
			if (match2.Success)
			{
				comparisonFilter.2 = double.Parse(match2.Groups[0].Value, 1662.18);
				2601.2611 dateFilter = new 2601.2611();
				dateFilter.2 = comparisonFilter;
				uint num = 1197.1(text);
				if (num > 1646985254U)
				{
					if (num <= 2072037248U)
					{
						if (num != 1746258028U)
						{
							if (num != 1798586254U)
							{
								if (num != 2072037248U)
								{
									goto IL_3D8;
								}
								if (text == "speed")
								{
									return new 2601.2603(dateFilter.2.5);
								}
								goto IL_3D8;
							}
							else
							{
								if (text == "od")
								{
									return (1262 1) => 2601.31<double>(Math.Round((double)1.4, 1), dateFilter.2.1, dateFilter.2.2);
								}
								goto IL_3D8;
							}
						}
						else if (!(text == "key"))
						{
							goto IL_3D8;
						}
					}
					else if (num <= 2979745817U)
					{
						if (num != 2211460629U)
						{
							if (num != 2979745817U)
							{
								goto IL_3D8;
							}
							if (text == "drain")
							{
								return new 2601.2603(dateFilter.2.7);
							}
							goto IL_3D8;
						}
						else
						{
							if (text == "length")
							{
								return new 2601.2603(dateFilter.2.6);
							}
							goto IL_3D8;
						}
					}
					else if (num != 3510316913U)
					{
						if (num != 4182378701U || !(text == "keys"))
						{
							goto IL_3D8;
						}
					}
					else
					{
						if (!(text == "star"))
						{
							goto IL_3D8;
						}
						goto IL_671;
					}
					return new 2601.2603(dateFilter.2.4);
				}
				if (num <= 1362809445U)
				{
					if (num != 1117382050U)
					{
						if (num != 1177122803U)
						{
							if (num != 1362809445U)
							{
								goto IL_3D8;
							}
							if (text == "hp")
							{
								return new 2601.2603(dateFilter.2.2);
							}
							goto IL_3D8;
						}
						else
						{
							if (text == "cs")
							{
								return new 2601.2603(dateFilter.2.4);
							}
							goto IL_3D8;
						}
					}
					else
					{
						if (text == "played")
						{
							try
							{
								dateFilter.1 = DateTime.UtcNow.AddDays(0.0 - dateFilter.2.2);
							}
							catch (ArgumentOutOfRangeException)
							{
								dateFilter.1 = ((dateFilter.2.2 > 0.0) ? DateTime.MinValue : DateTime.MaxValue);
							}
							return (1262 1) => 2601.31<DateTime>(dateFilter.1, dateFilter.2.1, 1.46);
						}
						goto IL_3D8;
					}
				}
				else if (num != 1562713850U)
				{
					if (num != 1575106246U)
					{
						if (num != 1646985254U || !(text == "stars"))
						{
							goto IL_3D8;
						}
					}
					else
					{
						if (text == "bpm")
						{
							return (1262 1) => 2601.31<double>(Math.Round((double)1.86().Z), dateFilter.2.1, dateFilter.2.2);
						}
						goto IL_3D8;
					}
				}
				else
				{
					if (text == "ar")
					{
						return new 2601.2603(dateFilter.2.3);
					}
					goto IL_3D8;
				}
				IL_671:
				return (1262 1) => 2601.31<double>(1052.21(1.33(true), 2U), dateFilter.2.1, dateFilter.2.2);
			}
			IL_3D8:
			2601.2617 2 = new 2601.2617();
			uint num2 = 1197.1(text);
			if (num2 <= 668295191U)
			{
				if (num2 != 164617456U)
				{
					if (num2 != 572804318U)
					{
						if (num2 == 668295191U)
						{
							if (text == "creator")
							{
								return new 2601.2603(comparisonFilter.12);
							}
						}
					}
					else if (text == "artist")
					{
						return new 2601.2603(comparisonFilter.13);
					}
				}
				else if (text == "difficulty")
				{
					return new 2601.2603(comparisonFilter.14);
				}
			}
			else if (num2 <= 2556802313U)
			{
				if (num2 != 1726876437U)
				{
					if (num2 == 2556802313U)
					{
						if (text == "title")
						{
							return delegate(1262 1)
							{
								string text2 = 1.10;
								return (text2 != null && text2.ToLower().Contains(comparisonFilter.3)) == (comparisonFilter.1 == "==");
							};
						}
					}
				}
				else if (text == "unplayed")
				{
					2.1 = DateTime.MinValue.AddDays(1.0);
					if (string.IsNullOrEmpty(comparisonFilter.3))
					{
						return new 2601.2603(2.4);
					}
				}
			}
			else if (num2 != 3125508079U)
			{
				if (num2 == 3966689298U)
				{
					if (text == "mode")
					{
						comparisonFilter.2 = 2601.33(comparisonFilter.3, 2601.84);
						return new 2601.2603(comparisonFilter.8);
					}
				}
			}
			else if (text == "status")
			{
				comparisonFilter.2 = 2601.33(comparisonFilter.3, 2601.85);
				if (comparisonFilter.2 == 4.0)
				{
					string 3 = comparisonFilter.1;
					if (!(3 == ">") && !(3 == "<="))
					{
						if (3 == "==")
						{
							return new 2601.2603(comparisonFilter.9);
						}
						if (3 == "!=")
						{
							return new 2601.2603(comparisonFilter.10);
						}
					}
					else
					{
						comparisonFilter.2 = 5.0;
					}
				}
				return new 2601.2603(comparisonFilter.11);
			}
		}
		if (int.TryParse(textFilter.2, out textFilter.1))
		{
			return (1262 1) => 1.25 == textFilter.1 || 1.29 == textFilter.1 || 1.31 == textFilter.1 || 2601.32(1, textFilter.2);
		}
		return new 2601.2603(textFilter.4);
	}

	// Token: 0x0600241A RID: 9242 RVA: 0x000A23FC File Offset: 0x000A05FC
	private static bool 31<T>(T 1, string 2, T 3) where T : IComparable<!!0>
	{
		int num = 1.CompareTo(3);
		if (2 == "<")
		{
			return num < 0;
		}
		if (2 == ">")
		{
			return num > 0;
		}
		if (2 == "==")
		{
			return num == 0;
		}
		if (2 == ">=")
		{
			return num >= 0;
		}
		if (!(2 == "<="))
		{
			return 2 == "!=" && num != 0;
		}
		return num <= 0;
	}

	// Token: 0x0600241B RID: 9243 RVA: 0x000A248C File Offset: 0x000A068C
	private static bool 32(1262 1, string 2)
	{
		return 1.49.IndexOf(2, StringComparison.InvariantCultureIgnoreCase) >= 0 || 1.43.IndexOf(2, StringComparison.InvariantCultureIgnoreCase) >= 0 || 1.9.IndexOf(2, StringComparison.InvariantCultureIgnoreCase) >= 0 || 1.82.IndexOf(2, StringComparison.InvariantCultureIgnoreCase) >= 0 || (1.8 != null && 1.8.IndexOf(2, StringComparison.InvariantCultureIgnoreCase) >= 0) || (1.11 != null && 1.11.IndexOf(2, StringComparison.InvariantCultureIgnoreCase) >= 0);
	}

	// Token: 0x0600241C RID: 9244 RVA: 0x000A2518 File Offset: 0x000A0718
	private static double 33(string 1, KeyValuePair<double, string>[] 2)
	{
		if (1.Length == 0)
		{
			return double.NaN;
		}
		foreach (KeyValuePair<double, string> keyValuePair in 2)
		{
			if (keyValuePair.Value.StartsWith(1))
			{
				return keyValuePair.Key;
			}
		}
		return double.NaN;
	}

	// Token: 0x0600241D RID: 9245 RVA: 0x000A256D File Offset: 0x000A076D
	private void 34()
	{
		this.66.Method8344();
		this.67 = 0;
		this.42();
		this.78.42();
	}

	// Token: 0x0600241E RID: 9246 RVA: 0x000A2594 File Offset: 0x000A0794
	private void 35(object 1, 2593 2)
	{
		if (2.14 != null && 2.14.36())
		{
			1262 3 = this.78.78();
			bool flag = 3 != null && 3.37 == 2.14.37;
			this.37(2.14, (!flag) ? ((639)1) : ((639)2));
		}
	}

	// Token: 0x0600241F RID: 9247 RVA: 0x000A25F4 File Offset: 0x000A07F4
	private void 36()
	{
		while (this.67 < 1272.3.Count)
		{
			1262 <<EMPTY_NAME>> = 1272.3[this.67];
			this.67++;
			if (<<EMPTY_NAME>>.36())
			{
				this.37(<<EMPTY_NAME>>, (639)0);
				if (this.81.Count > 50 && !1272.2)
				{
					1763.4("Beatmap difficulty calculation is running in the background. Performance at song select may be lower than usual.");
					1272.2 = true;
				}
				return;
			}
		}
		if (1272.2 && this.81.Count == 0)
		{
			1763.5("Background difficulty calculation finished.", 198.YellowGreen, 4000, null);
			1272.2 = false;
		}
	}

	// Token: 0x06002420 RID: 9248 RVA: 0x000A269C File Offset: 0x000A089C
	internal void 37(1262 1, 639 2)
	{
		2601.2607 3 = new 2601.2607();
		3.1 = this;
		3.2 = 1;
		HashSet<int> obj = this.81;
		lock (obj)
		{
			this.81.Add(3.2.25);
		}
		if (this.80.16 == 0f)
		{
			this.80.14();
			this.80.SetText("Difficulty calculation in progress...");
		}
		3.2.25(this.66, 2, new 1189(3.1));
	}

	// Token: 0x06002421 RID: 9249 RVA: 0x000A274C File Offset: 0x000A094C
	private void 38(bool 1)
	{
		if (1272.5() != null && 1272.5().38() == 2147.OsuMania)
		{
			if (1)
			{
				2009.1(false);
			}
			this.19.SetText(2009.4());
			return;
		}
		this.19.SetText(string.Empty);
	}

	// Token: 0x06002422 RID: 9250 RVA: 0x000A278C File Offset: 0x000A098C
	internal void 39()
	{
		if (this.81.Count <= 0)
		{
			this.80.SetText(string.Empty);
			this.80.13();
			return;
		}
		this.80.14();
		this.80.SetText(string.Format("Difficulty calculation in progress ({0} beatmaps remaining)", this.81.Count));
	}

	// Token: 0x06002423 RID: 9251 RVA: 0x000A27F4 File Offset: 0x000A09F4
	private static int 40(1262 1)
	{
		2023 2 = 2019.1;
		if ((2 & (2023.HardRock | 2023.DoubleTime | 2023.Nightcore)) != 2023.None)
		{
			return 1;
		}
		if ((2 & (2023.Easy | 2023.HalfTime)) != 2023.None)
		{
			return -1;
		}
		double num = 0.0;
		num += (double)(1926.4(1928.CircleSize, 1.2) - 1.2);
		num += (double)(1926.4(1928.ApproachRate, 1.1) - 1.1);
		num += (double)(1926.4(1928.OverallDifficulty, 1.4) - 1.4);
		num += (double)(1926.4(1928.DrainRate, 1.3) - 1.3);
		if (!double.IsNaN(num))
		{
			return Math.Sign(Math.Round(num, 2));
		}
		return 0;
	}

	// Token: 0x06002424 RID: 9252 RVA: 0x000A2899 File Offset: 0x000A0A99
	internal 1452[] 41()
	{
		return new 1452[]
		{
			this.11,
			this.12,
			this.13,
			this.14,
			this.93
		};
	}

	// Token: 0x06002425 RID: 9253 RVA: 0x000A28D0 File Offset: 0x000A0AD0
	internal void 42()
	{
		if (this.78.15 || 1272.5() == null)
		{
			return;
		}
		1262 <<EMPTY_NAME>> = 1272.5();
		209 2 = <<EMPTY_NAME>>.86();
		double num = 2039.21((double)<<EMPTY_NAME>>.87);
		this.9.SetText(<<EMPTY_NAME>>.12());
		2023 3 = 2023.DoubleTime;
		2023 4 = 2019.1;
		2023 5 = 3;
		if ((4 & 5) > 2023.None)
		{
			this.11.62(new 198(246, 154, 161));
			2 *= (float)1939.19(2019.1);
		}
		else
		{
			3 = 2023.HalfTime;
			2023 6 = 2019.1;
			5 = 3;
			if ((6 & 5) > 2023.None)
			{
				this.11.62(198.LightBlue);
				2 *= (float)1939.19(2019.1);
			}
			else
			{
				this.11.62(198.White);
			}
		}
		int num2 = (int)num / 60000;
		int num3 = (int)(num % 60000.0) / 1000;
		this.11.54(true);
		this.11.SetText(string.Format(1568.1(2679.SongSelection_BeatmapInfo), new object[]
		{
			num2,
			num3,
			1262.87(2),
			<<EMPTY_NAME>>.65
		}));
		this.12.SetText(string.Format(1568.1(2679.SongSelection_BeatmapInfo2), <<EMPTY_NAME>>.40, <<EMPTY_NAME>>.41, <<EMPTY_NAME>>.42));
		if (1272.5().43.Length > 0)
		{
			this.10.SetText(string.Format(1568.1(2679.SongSelection_BeatmapInfoCreator), <<EMPTY_NAME>>.43));
		}
		else
		{
			this.10.SetText(string.Empty);
		}
		int num4 = 2601.40(<<EMPTY_NAME>>);
		this.13.62((num4 > 0) ? new 198(246, 154, 161) : ((num4 < 0) ? 198.LightBlue : 198.White));
		string[] array = <<EMPTY_NAME>>.39().Split(new string[]
		{
			"\r\n",
			"\n"
		}, StringSplitOptions.None);
		this.13.SetText(array[0]);
		this.13.52 = <<EMPTY_NAME>>.41();
		this.13.10 = (this.13.52 != string.Empty);
		if (array.Length == 2)
		{
			this.14.SetText(array[1]);
		}
		else
		{
			this.14.SetText(string.Empty);
		}
		this.43(<<EMPTY_NAME>>, array.Length == 2);
	}

	// Token: 0x06002426 RID: 9254 RVA: 0x000A2B70 File Offset: 0x000A0D70
	private void 43(1262 1, bool 2)
	{
		if (this.93 == null)
		{
			return;
		}
		this.93.17 = new 208(1f, 2 ? 64f : 56f);
		2147 3 = (1 != null) ? 1.38() : 2147.Osu;
		if (!2237.1(1, 3))
		{
			this.93.SetText(string.Empty);
			return;
		}
		this.94 = (this.94 ?? delegate()
		{
			if (1662.79 == this)
			{
				this.42();
			}
		});
		2023 4 = 2019.1;
		1890 5 = 2237.5(1, 3, 1929.2(3, 4), 1926.3(3), 1939.16(4), this.94);
		if (5 == null)
		{
			this.93.SetText("pp: calculating...");
			return;
		}
		double[] array = new double[]
		{
			1.0,
			0.99,
			0.98,
			0.95
		};
		string[] array2 = new string[]
		{
			"SS",
			"99%",
			"98%",
			"95%"
		};
		StringBuilder stringBuilder = new StringBuilder("pp:");
		for (int i = 0; i < array.Length; i++)
		{
			double a = 2237.12(5, 2237.9(5, 4, array[i]));
			stringBuilder.Append((i == 0) ? " " : "  ·  ").Append(array2[i]).Append(' ').Append(Math.Round(a).ToString("0", 1662.18));
		}
		this.93.SetText(stringBuilder.ToString());
	}

	// Token: 0x06002427 RID: 9255 RVA: 0x000A2CF0 File Offset: 0x000A0EF0
	private void 44()
	{
		1381 texture = this.45.GetTexture();
		bool flag = true;
		this.45.3.Clear();
		switch (1272.5().85)
		{
		case (1281)4:
			texture = this.48;
			break;
		case (1281)5:
		case (1281)6:
			texture = this.47;
			break;
		case (1281)7:
			texture = this.46;
			break;
		default:
			texture = this.49;
			break;
		}
		switch (1272.5().85)
		{
		case (1281)1:
		{
			this.45.16(500, (1046)0, 0);
			1445 <<EMPTY_NAME>> = new 1445(1456.Scale, 1f, 0.8f, 1662.33, 1662.33 + 500, (1046)0);
			<<EMPTY_NAME>>.15 = (1046)1;
			this.45.3.Add(<<EMPTY_NAME>>);
			flag = false;
			break;
		}
		case (1281)4:
		case (1281)6:
		case (1281)7:
		{
			1445 2 = new 1445(1456.Scale, 0.92f, 1.4f, 1662.33, 1662.33 + 200, (1046)0);
			2.15 = (1046)2;
			1445 3 = new 1445(1456.Scale, 1.4f, 1f, 1662.33 + 200, 1662.33 + 400, (1046)0);
			3.15 = (1046)2;
			this.45.3.Add(2);
			this.45.3.Add(3);
			break;
		}
		case (1281)5:
		{
			1445 4 = new 1445(1456.Rotation, -0.4f, 0f, 1662.33, 1662.33 + 400, (1046)0);
			4.15 = (1046)1;
			1445 5 = new 1445(1456.Scale, 1.4f, 1f, 1662.33, 1662.33 + 400, (1046)0);
			5.15 = (1046)1;
			this.45.3.Add(4);
			this.45.3.Add(5);
			break;
		}
		}
		if (flag)
		{
			if (texture != this.45.GetTexture())
			{
				this.45.SetTexture(texture);
				this.45.15(400);
				return;
			}
			this.45.FadeIn(400, (1046)0, 0);
		}
	}

	// Token: 0x06002428 RID: 9256 RVA: 0x000A2F24 File Offset: 0x000A1124
	private void 45(1262 1, bool 2)
	{
		if (2)
		{
			if (this.87 == null || this.88 != 1272.5() || this.86 == (932)2)
			{
				1226.106(1272.5(), 2, true, true);
				return;
			}
		}
		else
		{
			this.86 = (932)0;
		}
	}

	// Token: 0x06002429 RID: 9257 RVA: 0x000A2F60 File Offset: 0x000A1160
	private void 46(bool 1)
	{
		if (this.54)
		{
			return;
		}
		if ((1662.23 || 1) && this.86 == (932)0)
		{
			1226.46(1226.56 - 8, false);
			if (1226.56 <= 10)
			{
				try
				{
					if (1272.5() != null)
					{
						1226.106(1272.5(), false, true, true);
						this.86 = (932)2;
					}
				}
				catch (Exception)
				{
					1763.4(1568.1(2679.SongSelection_AudioError));
					this.54 = true;
				}
			}
		}
		try
		{
			if (1226.32 == (1042)0 && 1226.1 && 1272.3.Count > 0 && 1662.76 == (932)2)
			{
				if (1272.5() == null)
				{
					1272.SetCurrentBeatmap(1272.3[0]);
				}
				1226.106(1272.5(), true, true, true);
			}
		}
		catch
		{
			this.54 = true;
		}
	}

	// Token: 0x0600242A RID: 9258 RVA: 0x000A3048 File Offset: 0x000A1248
	private void 47(object 1, List<200> 2)
	{
		200 3 = 2[0];
		if (3 == (200)340)
		{
			this.49(null, 200.Escape, true);
			return;
		}
		if (3 != (200)341)
		{
			return;
		}
		this.49(null, 200.Enter, true);
	}

	// Token: 0x0600242B RID: 9259 RVA: 0x000A3085 File Offset: 0x000A1285
	private bool 48(object 1, 200 2)
	{
		if (2 == 200.F2)
		{
			this.78.61();
			return true;
		}
		return false;
	}

	// Token: 0x0600242C RID: 9260 RVA: 0x000A309C File Offset: 0x000A129C
	private bool 49(object 1, 200 2, bool 3)
	{
		if (!this.20())
		{
			return false;
		}
		if (3)
		{
			if (!this.20 && 1939.21(2))
			{
				return true;
			}
			if (1272.5() != null && 1272.5().38() == 2147.OsuMania)
			{
				if (1549.1 && (2 == 200.OemPlus || 2 == 1548.8(1532.IncreaseSpeed)))
				{
					2009.3(1);
					return true;
				}
				if (1549.1 && (2 == 200.OemMinus || 2 == 1548.8(1532.DecreaseSpeed)))
				{
					2009.3(-1);
					return true;
				}
			}
			if (2 <= 200.Delete)
			{
				if (2 == 200.Escape)
				{
					if (this.78.15)
					{
						this.78.61();
					}
					else if (this.62)
					{
						this.88();
					}
					else
					{
						1354 4 = this.34;
						if (4 != null)
						{
							4.3();
						}
					}
					return true;
				}
				if (2 == 200.Delete)
				{
					if (1549.3)
					{
						this.66(null, null);
						return true;
					}
				}
			}
			else if (2 - 200.D1 > 3)
			{
				if (2 != 200.A)
				{
					switch (2)
					{
					case 200.F1:
						this.82(null, null);
						return true;
					case 200.F2:
						if (3)
						{
							this.14(null, null);
						}
						return true;
					case 200.F3:
						if (!this.78.15)
						{
							this.61();
						}
						return true;
					case 200.F4:
						this.83(null, null);
						return true;
					case 200.F5:
						2463.13(true, null);
						return true;
					}
				}
				else
				{
					if (!this.21)
					{
						return false;
					}
					if (1549.1 && !this.20)
					{
						2019.1 ^= 2023.Autoplay;
						2019.7(2023.None);
						return true;
					}
				}
			}
			else if (1549.1 && 2601.72)
			{
				2147 5 = (2147)(2 - 49);
				this.79(5);
				return true;
			}
		}
		this.87(false);
		return false;
	}

	// Token: 0x0600242D RID: 9261 RVA: 0x000A3254 File Offset: 0x000A1454
	private void 50()
	{
		this.42.15(false);
		if (this.53 != null)
		{
			208 <<EMPTY_NAME>> = 1555.21() / 1662.70.3() - new 208(150f, 0f);
			this.53.44 = new Vector2d((double)<<EMPTY_NAME>>.X, (double)<<EMPTY_NAME>>.Y);
			this.53.22(Vector2d.Zero);
			this.53.20(this.42);
		}
	}

	// Token: 0x0600242E RID: 9262 RVA: 0x000A32DD File Offset: 0x000A14DD
	private void 51()
	{
		1662.89.Schedule(delegate()
		{
			this.53(false);
		}, false);
	}

	// Token: 0x0600242F RID: 9263 RVA: 0x000A32F7 File Offset: 0x000A14F7
	internal void 52(2023 1)
	{
		if (2019.1 != 1 && 1304.164 == 1289.SelectedMod)
		{
			this.53(true);
		}
	}

	// Token: 0x06002430 RID: 9264 RVA: 0x000A3318 File Offset: 0x000A1518
	private void 53(bool 1)
	{
		bool flag = this.21 || this.20;
		if (flag && !1631.2(1272.5(), 1304.164.GetValue()))
		{
			1631.5(1272.5(), 1304.164.GetValue());
			this.54(true);
			return;
		}
		1262 2 = 1272.5();
		if (2 == null || (!3 && 2.74()))
		{
			return;
		}
		if (this.76 != null)
		{
			this.76.FadeIn(200, (1046)0, 0);
		}
		if (flag)
		{
			this.59();
		}
		2.78(flag, 3, (!flag) ? 1289.Top : 1304.164.GetValue(), delegate(1262 1)
		{
			if (1272.5() == 1)
			{
				if (1.67 != 0 || !string.IsNullOrEmpty(1.34))
				{
					this.42();
				}
				this.54(true);
			}
		});
	}

	// Token: 0x06002431 RID: 9265 RVA: 0x000A33C8 File Offset: 0x000A15C8
	internal void 54(bool 1)
	{
		if (this.5)
		{
			return;
		}
		this.73();
		if (this.56 != null)
		{
			this.56.5 = false;
			this.56.10 = false;
			this.56.16(200, (1046)0, 0);
			1433 2 = this.56.8 as 1433;
			if (2 != null)
			{
				2.5 = false;
				2.16(200, (1046)0, 0);
			}
		}
		if (1272.5() != null && 1272.5().25 != 0)
		{
			this.22.10 = true;
			this.22.3.Clear();
			this.22.3.Add(new 1445(1456.Fade, this.22.16, 1f, 1662.33, 1662.33 + 300, (1046)0));
		}
		else
		{
			this.22.10 = false;
			this.22.16(300, (1046)0, 0);
		}
		this.76.16(50, (1046)0, 0);
		if (1272.5() == null)
		{
			this.59();
			return;
		}
		if (!this.21 && !this.20)
		{
			if (1272.5().85 >= (1281)4 || 1272.5().97 || 6)
			{
				this.58();
				return;
			}
			this.53(false);
			return;
		}
		else
		{
			this.59();
			1631.4(1272.5(), 1304.164.GetValue());
			this.74 = new List<2241>();
			bool flag = 1304.164.GetValue() == 1289.LocalPerformance;
			this.95.Clear();
			if (!this.22() && !flag)
			{
				1304.164.SetValue(1289.Local);
			}
			if (1304.164.GetValue() != 1289.Local && !flag && !1631.2(1272.5(), 1304.164.GetValue()))
			{
				1631.5(1272.5(), 1304.164.GetValue());
				1272.5().71 = 1304.164.GetValue();
				this.58();
				return;
			}
			if (1304.164.GetValue() != 1289.Local && !flag)
			{
				if ((1272.5().70.Count == 0 || 1272.5().71 != 1304.164.GetValue()) && !1272.5().74() && !6)
				{
					this.53(false);
					return;
				}
				this.74.AddRange(1272.5().70);
				if (1304.164 == 1289.Friends && 1272.5().68 != null)
				{
					if (this.74.Find((2241 1) => 1.23 == 1272.5().68.23) == null)
					{
						this.74.Method11157((2241)1272.5().68.Clone());
					}
					for (int i = 0; i < this.74.Count; i++)
					{
						this.74[i].17 = i + 1;
					}
				}
			}
			else
			{
				1272.5().71 = 1304.164.GetValue();
				List<2241> list = 2230.3(1272.5().23, 1272.5().38());
				if (flag && list != null)
				{
					list = this.55(list, 1272.5());
				}
				if (list != null && list.Count > 0 && !this.74.Contains(list[0]))
				{
					int num = 1;
					foreach (2241 3 in list)
					{
						3.17 = num++;
						this.74.Add(3);
					}
				}
			}
			1272.5().70 = this.74;
			int num2 = 1;
			int num3 = 4;
			if (this.74 != null && this.74.Count > 0)
			{
				for (int j = 0; j < this.74.Count; j++)
				{
					2241 4 = this.74[j];
					this.57(4, (float)num3, num2++, 4.17, (j < this.74.Count - 1) ? (4.GetScore() - this.74[j + 1].GetScore()) : 0, null);
					num3 += 33;
				}
				if (this.22())
				{
					1452 5 = new 1452(1568.1(2679.SongSelection_OnlineRecord), 14f, new 208(120f, 362f), 208.Zero, 0.05f, true, 198.TransparentWhite, false);
					5.63(true);
					5.49 = 1065.TopCentre;
					5.62(198.White);
					5.54(true);
					this.68.Add(5);
					5.3.Add(new 1445(1456.Fade, 0f, 1f, 1662.33, 1662.33 + 600, (1046)0));
					this.57(1272.5().68, 382f, 9, (1272.5().68 != null) ? 1272.5().68.17 : 0, 0, this.68);
					if (1272.5().68 != null && 1304.164.GetValue() != 1289.SelectedMod && 1272.5().72() != 1272.5().68.CalculateGrade())
					{
						1272.5().73(1272.5().68.CalculateGrade());
						this.78.39();
					}
				}
				this.43.17(new 208(50f, (float)(this.74.Count * 33)));
			}
			else
			{
				this.58();
				this.43.17(208.Zero);
			}
			this.43.25(0f, -0.99f);
			if (1662.100 != null)
			{
				int num4 = this.74.FindIndex(new Predicate<2241>(2601.2616.Instance.16));
				if (num4 >= 8 && this.74.Count > 8)
				{
					this.43.25(Math.Max(0f, this.43.17.Y - this.43.4()) * ((float)(num4 - 7) / (float)(this.74.Count - 8)), -0.99f);
				}
			}
			this.40.14<1433>(this.68);
			this.44();
			return;
		}
	}

	// Token: 0x06002432 RID: 9266 RVA: 0x000A3A54 File Offset: 0x000A1C54
	private List<2241> 55(List<2241> 1, 1262 2)
	{
		foreach (2241 3 in 4)
		{
			double? num = 2237.Get(3, 5, new Action(this.56));
			if (num != null)
			{
				this.95[3] = num.Value;
			}
		}
		List<2241> list = new List<2241>(4);
		list.Sort(delegate(2241 1, 2241 2)
		{
			double num2;
			double value = this.95.TryGetValue(1, out num2) ? num2 : -1.0;
			double num4;
			int num3 = (this.95.TryGetValue(2, out num4) ? num4 : -1.0).CompareTo(value);
			if (num3 == 0)
			{
				return 2.GetScore().CompareTo(1.GetScore());
			}
			return num3;
		});
		return list;
	}

	// Token: 0x06002433 RID: 9267 RVA: 0x000A3AE4 File Offset: 0x000A1CE4
	private void 56()
	{
		if (1662.79 == this && 1304.164.GetValue() == 1289.LocalPerformance && !this.5)
		{
			this.54(false);
		}
	}

	// Token: 0x06002434 RID: 9268 RVA: 0x000A3B0C File Offset: 0x000A1D0C
	private void 57(2241 1, float 2, int 3, int 4, int 5, List<1433> 6)
	{
		2601.2615 hoverState = new 2601.2615();
		208 7 = new 208(200f, 0f);
		float num = (float)((6 != null) ? 3 : 0);
		int num2 = Math.Min((3 - 1) * 50, 2500) + 1662.33;
		1445 item = new 1445(1456.Fade, 0f, 1f, num2, num2 + 200, (1046)0);
		bool flag = 6 != null;
		string 8 = (!flag) ? 17.23 : ((17 == null) ? 1568.1(2679.SongSelection_NoPersonalRecordSet) : ((4 <= 0) ? 17.23 : ((1272.5().30 <= 0 || 1272.5().30 <= 4) ? string.Format("#{0:#,0} {1}", 4, 17.23) : string.Format("#{0:#,0} of {1:#,0}", 4, 1272.5().30))));
		198 transparentWhite = 198.TransparentWhite;
		hoverState.1 = new 1452((4 > 0) ? 4.ToString() : string.Empty, 18f, new 208(18f + num, 18 + 15f), 208.Zero, 0.6f, true, transparentWhite, true);
		hoverState.1.49 = 1065.Centre;
		hoverState.1.64(true);
		hoverState.1.54(true);
		if (6 != null)
		{
			6.Add(hoverState.1);
		}
		else
		{
			this.43.22.12(hoverState.1);
		}
		hoverState.2 = null;
		if (17 != null && 17.33 != null && 17.33.12 > 0)
		{
			hoverState.2 = new 1505(null, null, (17.33.12 != 1662.100.12) ? 500 : 0, new 208(18f + num, 18 + 15.4f), 0.45f);
			17.33.7(hoverState.2, 46f);
			if (6 != null)
			{
				6.Add(hoverState.2);
			}
			else
			{
				this.43.22.12(hoverState.2);
			}
		}
		bool flag2 = false;
		bool flag3;
		if (!flag && 17 != null && 17.33 != null)
		{
			int num3 = 17.33.12;
			1654 9 = 1662.100;
			int? num4 = (9 != null) ? new int?(9.12) : null;
			flag3 = (num3 == num4.GetValueOrDefault() & num4 != null);
		}
		else
		{
			flag3 = false;
		}
		bool flag4 = flag3;
		flag4 |= (!flag && 17 != null && 17.16 == 0L && this.22());
		if (flag2 && 1304.164.GetValue() != 1289.Friends)
		{
			transparentWhite = new 198(byte.MaxValue, 235, 115, 0);
		}
		else if (flag4)
		{
			transparentWhite = new 198(115, 235, byte.MaxValue, 0);
		}
		int num5 = 400;
		1433 10 = new 1452(8, 16f, new 208(58f + num, (17 != null) ? 18 : (18 + 6f)), 208.Zero, 0.4f, true, transparentWhite, true);
		1445 11 = new 1445(10.7 - 7, 10.7, num2, num2 + num5, (1046)0);
		11.15 = (1046)30;
		10.3.Add(11);
		10.3.Add(item);
		if (6 != null)
		{
			6.Add(10);
		}
		else
		{
			this.43.22.12(10);
		}
		if (17 != null)
		{
			10 = new 1452(string.Format(1568.1(2679.SongSelection_ScoreList), 17.GetScore(), 17.13), 12f, new 208(58f + num, 15f + 18), 208.Zero, 0.4f, true, 198.TransparentWhite, true);
			11 = new 1445(10.7 - 7, 10.7, num2, num2 + num5, (1046)0);
			11.15 = (1046)30;
			10.3.Add(11);
			10.3.Add(item);
			if (6 != null)
			{
				6.Add(10);
			}
			else
			{
				this.43.22.12(10);
			}
			double num6;
			1452 12 = new 1452(string.Concat(new string[]
			{
				17.1(),
				"\n",
				string.Format("{0:0.00}%", 17.CalculateAccuracy() * 100f),
				"\n",
				this.95.TryGetValue(17, out num6) ? (num6.ToString("#,0", 1662.18) + "pp") : ((5 > 0) ? ("+" + 5.ToString("#,0")) : "-")
			}), 10f, new 208(236f + num, 18), new 208(100f, 0f), 0.4f, true, 198.TransparentWhite, true);
			12.64(true);
			12.74 = false;
			12.75 = (1066)3;
			12.49 = 1065.TopRight;
			11 = new 1445(12.7 - 7, 12.7, num2, num2 + num5, (1046)0);
			11.15 = (1046)30;
			12.3.Add(11);
			12.3.Add(item);
			if (6 != null)
			{
				6.Add(12);
			}
			else
			{
				this.43.22.12(12);
			}
		}
		DateTime dateTime = DateTime.Now;
		if (17 != null)
		{
			try
			{
				10 = new 1433(1455.2(string.Format("ranking-{0}-small", 17.CalculateGrade()), (1416)7, null), (1376)6, 1065.Centre, (1044)0, new 208(46f + num, 14.6f + 18), 0.4f, true, 198.TransparentWhite, null);
				11 = new 1445(10.7 - 7, 10.7, num2, num2 + num5, (1046)0);
				11.15 = (1046)30;
				10.3.Add(11);
				10.3.Add(item);
				if (6 != null)
				{
					6.Add(10);
				}
				else
				{
					this.43.22.12(10);
				}
			}
			catch (Exception)
			{
			}
			dateTime = 17.7.ToLocalTime();
			double totalHours = (DateTime.Now - dateTime).TotalHours;
			if (totalHours < 96.0)
			{
				1386 13 = new 1386(1048.arrow_circle_o_up, 18f, new 208(248f + num, 15f + 18))
				{
					2 = 0.4f,
					5 = true,
					6 = 198.TransparentWhite,
					16 = 0f
				};
				11 = new 1445(13.7 - 7, 13.7, num2, num2 + num5, (1046)0);
				11.15 = (1046)30;
				13.3.Add(11);
				13.3.Add(item);
				if (6 != null)
				{
					6.Add(13);
				}
				else
				{
					this.43.22.12(13);
				}
				((int)totalHours).ToString() + "h";
				1452 14 = new 1452((totalHours > 47.0) ? (((int)(totalHours / 24.0)).ToString() + "d") : ((totalHours >= 1.0) ? (((int)totalHours).ToString() + "h") : ((totalHours <= 0.016666666666666666) ? (((int)(totalHours * 3600.0)).ToString() + "s") : (((int)(totalHours * 60.0)).ToString() + "m"))), 10f, new 208(258f + num, 15f + 18), new 208(100f, 0f), 0.4f, true, 198.TransparentWhite, true);
				14.64(true);
				14.74 = false;
				14.49 = 1065.CentreLeft;
				11 = new 1445(14.7 - 7, 14.7, num2, num2 + num5, (1046)0);
				11.15 = (1046)30;
				14.3.Add(11);
				14.3.Add(item);
				if (6 != null)
				{
					6.Add(14);
				}
				else
				{
					this.43.22.12(14);
				}
			}
		}
		item = new 1445(1456.Fade, 0f, 0.3f, num2, num2 + 200, (1046)0);
		10 = new 1433(1455.2("menu-button-background", (1416)7, null), (1376)6, 1065.CentreLeft, (1044)0, new 208(num, 15f + 18), 0.12f + (float)3 / 1000f, true, new 198(0, 0, 0, 120), 17);
		if (17 != null)
		{
			if (17.9 == 2147.OsuMania)
			{
				10.52 = string.Format(1568.1(2679.SongSelection_TooltipScoreMania), new object[]
				{
					dateTime,
					17.4,
					17.2,
					17.5,
					(int)(17.1 + 17.3 + 17.6),
					17.CalculateAccuracy() * 100f,
					17.2()
				});
			}
			else
			{
				10.52 = string.Format(1568.1(2679.SongSelection_TooltipScore), new object[]
				{
					dateTime,
					17.2,
					17.1,
					17.3,
					17.6,
					17.CalculateAccuracy() * 100f,
					17.2()
				});
			}
			10.3(delegate(object 1, EventArgs 2)
			{
				if (!this.20)
				{
					bool flag5 = 1555.22 == MouseButtons.Right;
					1226.28("menuhit", 1f, (1416)3);
					2241 19 = (2241)((1433)1).8;
					if (19 != null && flag5)
					{
						1662.25(new 1725(19));
						return;
					}
					1535.39 = 19;
					1535.2(true);
					1662.SetMode(1677.Rank, false);
				}
			});
			10.11 = true;
			10.10 = true;
			10.42 = new 1445(1456.Fade, 0.3f, 0.6f, 0, 200, (1046)0);
			10.35(delegate(object 1, EventArgs 2)
			{
				hoverState.1.FadeIn(100, (1046)0, 0);
				1505 19 = hoverState.2;
				if (19 != null)
				{
					19.39(198.DarkGray, 100, false, (1046)0);
				}
				1226.20(null, "click-short", 1f, false);
			});
			10.37(new EventHandler(hoverState.17));
		}
		11 = new 1445(10.7 - 7, 10.7, num2, num2 + num5, (1046)0);
		11.15 = (1046)30;
		10.16 = 0f;
		10.3.Add(11);
		10.3.Add(item);
		10.15 = 0.55f;
		int num7 = 150;
		int num8 = 900;
		int num9 = num7 + num8;
		int i;
		for (i = 0; i < num9; i += (int)Math.Max(100.0, Math.Min(1226.76() * 2.0, (double)(num9 * 5))))
		{
		}
		i -= num9;
		int num10 = num2 + (int)(1226.76() * (1.0 - 1226.68)) - num7;
		1445 15 = new 1445(new 198(0, 0, 0, byte.MaxValue), new 198(100, 100, 100, byte.MaxValue), num10, num10 + num7);
		15.15 = (1046)2;
		15.11 = num8 + i;
		15.17 = true;
		10.3.Add(15);
		1445 16 = new 1445(new 198(100, 100, 100, byte.MaxValue), new 198(0, 0, 0, byte.MaxValue), num10 + num7, num10 + num7 + num8);
		16.15 = (1046)1;
		16.11 = num7 + i;
		16.17 = true;
		10.3.Add(16);
		if (6 != null)
		{
			6.Add(10);
		}
		else
		{
			this.43.22.12(10);
		}
		this.43.22.28.ForEach(delegate(1371 1)
		{
			1.6(new 1058?(new 1058(0f, 92f, 640f, 267f)));
		});
	}

	// Token: 0x06002435 RID: 9269 RVA: 0x000A47B4 File Offset: 0x000A29B4
	private void 58()
	{
		if (1272.5() == null)
		{
			return;
		}
		if (this.56 != null)
		{
			this.56.5 = false;
			this.56.3.Clear();
			this.56.16 = 0f;
		}
		208 <<EMPTY_NAME>> = this.21 ? new 208(118f, 170f) : new 208(118f, 100f);
		this.56 = new 1433(1455.2("selection-norecords", (1416)1, null), (1376)6, 1065.Centre, (1044)0, <<EMPTY_NAME>>, 0.12f, true, 198.TransparentWhite, null);
		this.56.FadeIn(400, (1046)0, 0);
		this.56.19(this.56.17 + new 208(0f, 30f), 400, (1046)1);
		this.40.12(this.56);
		if (!this.22() && this.21)
		{
			return;
		}
		if (1272.5().97)
		{
			this.56.SetTexture(1455.2("selection-update", (1416)1, null));
			this.56.3(new EventHandler(this.70));
			this.56.42 = new 1445(198.White, 198.LimeGreen, 0, 200);
			this.56.10 = true;
			1433 2 = new 1433(1455.2("selection-update", (1416)1, null), (1376)6, 1065.Centre, (1044)0, <<EMPTY_NAME>> + new 208(0f, 30f), 0.13f, true, 198.TransparentWhite, null);
			2.3.Add(new 1445(1456.Fade, 0f, 0f, 1662.33, 1662.33 + 400, (1046)0));
			1445 3 = new 1445(1456.Scale, 1f, 2f, 1662.33 + 400, 1662.33 + 1400, (1046)0);
			3.17 = true;
			3.15 = (1046)1;
			2.3.Add(3);
			3 = new 1445(1456.Fade, 1f, 0f, 1662.33 + 400, 1662.33 + 1400, (1046)0);
			3.17 = true;
			3.15 = (1046)1;
			2.3.Add(3);
			this.56.8 = 2;
			this.39.12(2);
			return;
		}
		switch (1272.5().85)
		{
		case (1281)0:
			this.56.SetTexture(1455.2("selection-unknown", (1416)1, null));
			break;
		case (1281)1:
			this.56.SetTexture(1455.2("selection-notsubmitted", (1416)1, null));
			break;
		case (1281)2:
			this.56.SetTexture(1455.2("selection-notranked", (1416)1, null));
			break;
		case (1281)4:
		case (1281)5:
		case (1281)6:
		case (1281)7:
			if (!this.21)
			{
				this.56.SetTexture(1455.2("selection-latestranked", (1416)1, null));
			}
			break;
		}
		if (1272.5().33)
		{
			this.56.SetTexture(1455.2("selection-lazeronly", (1416)1, null));
		}
	}

	// Token: 0x06002436 RID: 9270 RVA: 0x000A4ADA File Offset: 0x000A2CDA
	private void 59()
	{
		this.74 = null;
		this.68.ForEach(new Action<1433>(2601.2616.Instance.17));
		this.68.Clear();
		this.43.31(true, true);
	}

	// Token: 0x06002437 RID: 9271 RVA: 0x000A4B18 File Offset: 0x000A2D18
	private void 60(object 1, EventArgs 2)
	{
		1304.164.SetValue((1289)this.75.18);
		switch (1304.164.GetValue())
		{
		case 1289.Top:
			goto IL_77;
		case 1289.SelectedMod:
			if (1631.IsConfigured)
			{
				goto IL_77;
			}
			break;
		case 1289.Friends:
		case 1289.Country:
			break;
		default:
			goto IL_77;
		}
		1763.2("Set up the osu! API in Options (Online) to use this ranking.", 5000, (1389)0);
		1373 3 = this.75;
		1289 4;
		1304.164.SetValue(4 = 1289.Top);
		3.18(4, false);
		return;
		IL_77:
		this.53(true);
	}

	// Token: 0x06002438 RID: 9272 RVA: 0x000A4BA4 File Offset: 0x000A2DA4
	private void 61()
	{
		if (1272.5() != null && !this.5)
		{
			198 yellowGreen = 198.YellowGreen;
			198 <<EMPTY_NAME>> = new 198(208, 125, 216);
			1689 3 = new 1689(string.Format(1568.1(2679.SongSelection_ThisBeatmap), 1272.5().81), true);
			3.7(1568.1(2679.SongSelection_Collection), yellowGreen, new EventHandler(this.75), true, false, true);
			3.7(1568.1(2679.SongSelection_Delete), 198.OrangeRed, new EventHandler(this.66), true, false, true);
			if (this.21)
			{
				3.7(1568.1(2679.SongSelection_RemoveFromUnplayed), <<EMPTY_NAME>>, new EventHandler(this.65), true, false, true);
				3.7(1568.1(2679.SongSelection_ClearLocalScores), <<EMPTY_NAME>>, new EventHandler(this.64), true, false, true);
				3.7(1568.1(2679.SongSelection_Edit), 198.OrangeRed, new EventHandler(this.63), true, false, true);
			}
			if (1272.5().97 && 1633.4(1272.5()))
			{
				3.7("Update to the latest version", 198.YellowGreen, delegate(object 1, EventArgs 2)
				{
					this.70(null, 2);
				}, true, false, true);
			}
			3.7(1568.1(2679.General_Cancel), 198.Gray, null, true, false, true);
			1662.25(3);
		}
	}

	// Token: 0x06002439 RID: 9273 RVA: 0x000A4D08 File Offset: 0x000A2F08
	private void 62(2593 1)
	{
		2601.2605 2 = new 2601.2605();
		2.2 = this;
		if (!this.5)
		{
			2.1 = 1.GetDisplayTitle();
			if (1297.1().ContainsKey(2.1))
			{
				1689 3 = new 1689(string.Format(1568.1(2679.SongSelection_ThisCollection), 2.1), true);
				3.7(1568.1(2679.SongSelection_Delete), 198.OrangeRed, new EventHandler(2.Delete), true, false, true);
				3.7(1568.1(2679.General_Cancel), 198.Gray, null, true, false, true);
				1662.25(3);
			}
		}
	}

	// Token: 0x0600243A RID: 9274 RVA: 0x000A4DA3 File Offset: 0x000A2FA3
	private void 63(object 1, EventArgs 2)
	{
		1662.SetMode(1677.Edit, false);
	}

	// Token: 0x0600243B RID: 9275 RVA: 0x000A4DAC File Offset: 0x000A2FAC
	private void 64(object 1, EventArgs 2)
	{
		1662.25(new 1688("Are you sure you want to delete all local scores on this beatmap?", new EventHandler(this.76), null, true));
	}

	// Token: 0x0600243C RID: 9276 RVA: 0x000A4DCC File Offset: 0x000A2FCC
	private void 65(object 1, EventArgs 2)
	{
		1272.5().64 = false;
		1763.5(string.Format(1568.1(2679.SongSelection_RemovedFromUnplayedSongs), 1272.5().81), 198.SkyBlue, 3000, null);
		this.18(this.78.4.GetValue(), false, null, false);
	}

	// Token: 0x0600243D RID: 9277 RVA: 0x000A4E28 File Offset: 0x000A3028
	private void 66(object 1, EventArgs 2)
	{
		1689 3 = new 1689(string.Format(1568.1(2679.SongSelection_DeleteFromDisk), 1272.5().49), true);
		if (1272.3.FindAll((1262 1) => 1.37 == 1272.5().37).Count > 1 && !1272.5().61)
		{
			3.7(1568.1(2679.SongSelection_DeleteAllDifficulties), 198.OrangeRed, new EventHandler(this.69), true, false, true);
			3.7(1568.1(2679.SongSelection_DeleteOnlyThisDifficulty), 198.OrangeRed, new EventHandler(this.68), true, false, true);
			3.7(1568.1(2679.SongSelection_DeleteAllVisible), 198.Red, delegate(object 1, EventArgs 2)
			{
				2601.2602 6 = new 2601.2602();
				6.1 = new List<1262>();
				foreach (2593 7 in this.78.10)
				{
					if (7.14 != null && !7.23 && (7.22 == null || 7.22.27() == (2597)3))
					{
						6.1.Add(7.14);
					}
				}
				if (6.1.Count == 0)
				{
					1763.4(1568.1(2679.SongSelection_NoMapsVisible));
					return;
				}
				if (6.1.Count == 1272.3.Count)
				{
					1763.4(1568.1(2679.SongSelection_CantDeleteAllMaps));
					return;
				}
				1662.25(new 1688(string.Format(1568.1(2679.SongSelection_ConfirmDeleteManyBeatmaps), 6.1.Count), new EventHandler(6.1), null, true));
			}, true, false, true);
		}
		else
		{
			3.7(1568.1(2679.SongSelection_DeleteThisBeatmap), 198.OrangeRed, new EventHandler(this.69), true, false, true);
		}
		3.7(1568.1(2679.SongSelection_NoCancel), 198.Gray, null, true, false, true);
		1662.25(3);
	}

	// Token: 0x0600243E RID: 9278 RVA: 0x000A4F48 File Offset: 0x000A3148
	private void 67()
	{
		2230.21(1272.5().23);
		1763.5(string.Format(1568.1(2679.SongSelection_ClearedScores), 1272.5().81), 198.LimeGreen, 3000, null);
		this.54(false);
	}

	// Token: 0x0600243F RID: 9279 RVA: 0x000A4F94 File Offset: 0x000A3194
	private void 68(object 1, EventArgs 2)
	{
		1272.19(1272.5(), false);
	}

	// Token: 0x06002440 RID: 9280 RVA: 0x000A4FA1 File Offset: 0x000A31A1
	private void 69(object 1, EventArgs 2)
	{
		1763.5(string.Format(1568.1(2679.SongSelection_DeletedFromDisk), 1272.5().49), 198.Red, 3000, null);
		1272.19(1272.5(), true);
	}

	// Token: 0x06002441 RID: 9281 RVA: 0x000A4FD8 File Offset: 0x000A31D8
	private void 70(object 1, EventArgs 2)
	{
		2601.2618 clickContext = new 2601.2618();
		clickContext.1 = this;
		clickContext.2 = 4;
		clickContext.3 = 5;
		if (1272.5() == null || !1272.5().97)
		{
			1763.4(1568.1(2679.SongSelection_UpdateNotAvailable));
			return;
		}
		1662.82(true);
		if (1272.5().43 == 1304.189)
		{
			1689 3 = new 1689(1568.1(2679.SongSelection_WarningDestroyChanges), false);
			3.7(1568.1(2679.SongSelection_DiscardLocalChanges), 198.OrangeRed, delegate(object 1, EventArgs 2)
			{
				clickContext.1.71(clickContext.2, clickContext.3);
			}, true, false, true);
			3.7(1568.1(2679.SongSelection_KeepLocalChanges), 198.Gray, null, true, false, true);
			1662.25(3);
		}
		else
		{
			this.71(clickContext.2, clickContext.3);
		}
		1662.82(false);
	}

	// Token: 0x06002442 RID: 9282 RVA: 0x000A50D8 File Offset: 0x000A32D8
	private void 71(object 1, EventArgs 2)
	{
		1433 3 = 1 as 1433;
		if (3 != null)
		{
			3.3.Add(new 1445(1456.Fade, 1f, 0.2f, 1662.33, 1662.33 + 400, (1046)0));
			1433 4 = 3.8 as 1433;
			if (4 != null)
			{
				4.3[0] = 4.3[0].2();
				4.3[1] = 4.3[1].2();
			}
			3.10 = false;
		}
		this.72(1272.5());
	}

	// Token: 0x06002443 RID: 9283 RVA: 0x000A5178 File Offset: 0x000A3378
	private void 72(1262 1)
	{
		if (3 == null)
		{
			return;
		}
		1763.4("Updating " + 3.49 + "...");
		1633.20(3, delegate(bool 1, string 2)
		{
			if (1)
			{
				1763.5(3.49 + " was updated to the latest version.", 198.YellowGreen, 4000, null);
			}
			else
			{
				1763.5(2, 198.OrangeRed, 5000, null);
			}
			if (1662.79 == this && 1272.5() == 3)
			{
				if (1)
				{
					this.53(true);
					return;
				}
				this.54(false);
			}
		});
	}

	// Token: 0x06002444 RID: 9284 RVA: 0x000A51D8 File Offset: 0x000A33D8
	private void 73()
	{
		1262 beatmap = 1272.5();
		if (beatmap == null || beatmap == this.96 || (beatmap.29 <= 0 && beatmap.25 > 0))
		{
			return;
		}
		this.96 = beatmap;
		1662.89.2(delegate
		{
			if (1662.79 != this || 1272.5() != beatmap)
			{
				return;
			}
			1633.5(beatmap, delegate
			{
				if (1662.79 != this || 1272.5() != beatmap || this.5)
				{
					return;
				}
				this.54(false);
			});
		}, 700, false);
	}

	// Token: 0x06002445 RID: 9285 RVA: 0x000A525C File Offset: 0x000A345C
	private void 74(bool 1)
	{
		2601.2619 2 = new 2601.2619();
		2.1 = 1;
		2.2 = this;
		1662.89.Schedule(new 1189(2.1), false);
	}

	// Token: 0x06002446 RID: 9286 RVA: 0x000A5298 File Offset: 0x000A3498
	private void 75(object 1, EventArgs 2)
	{
		2598 3 = this.78.77();
		2601.37 = ((3 == null || !3.23()) ? null : 3.GetDisplayTitle());
		1662.25(new 1684(delegate(object 1, EventArgs 2)
		{
			if (this.78.4.GetValue() == 2591.Collection)
			{
				this.18(2591.Collection, 2601.37 != null, 2601.37, false);
			}
		}));
	}

	// Token: 0x06002447 RID: 9287 RVA: 0x000A52E0 File Offset: 0x000A34E0
	private void 76(object 1, EventArgs 2)
	{
		this.67();
	}

	// Token: 0x06002448 RID: 9288 RVA: 0x000A52E8 File Offset: 0x000A34E8
	internal static bool 77()
	{
		2601 <<EMPTY_NAME>> = 1662.79 as 2601;
		if (<<EMPTY_NAME>> == null || 1662.78 != 1677.SelectPlay || 1272.5() == null)
		{
			return false;
		}
		2513.1((2019.1 & 2023.Autoplay) > 2023.None);
		2019.1 |= 2023.Autoplay;
		<<EMPTY_NAME>>.StartPlay();
		return true;
	}

	// Token: 0x06002449 RID: 9289 RVA: 0x000A5340 File Offset: 0x000A3540
	private void StartPlay()
	{
		if (1272.5() == null || this.78.15 || 1662.76 != (932)2)
		{
			return;
		}
		if (!this.5)
		{
			this.76.16(80, (1046)0, 0);
			this.21(false);
			if (DateTime.Now.Month == 4 && DateTime.Now.Day == 1 && new Random().Next(20) == 1)
			{
				1226.28("achoo", 1f, (1416)3);
			}
			else
			{
				1226.28("menuhit", 1f, (1416)3);
			}
		}
		1436.1 = null;
		this.40.22 = false;
		this.39.22 = false;
		1677 <<EMPTY_NAME>> = 1662.78;
		if (<<EMPTY_NAME>> == 1677.SelectEdit)
		{
			1662.SetMode(1677.Edit, false);
			return;
		}
		if (<<EMPTY_NAME>> != 1677.SelectMulti)
		{
			if (1549.1)
			{
				2019.1 |= 2023.Autoplay;
				if (1549.3)
				{
					2019.1 |= 2023.Cinema;
				}
			}
			if (this.75 != null)
			{
				this.75.8();
			}
			this.5 = true;
			this.78.30 = 500.0;
			if (this.55 != null)
			{
				1433 2 = this.55.Clone();
				2.2 += 0.01f;
				2.28 = true;
				2.25(2.15 + 0.04f, 1000, (1046)1);
				2.17(1000);
				this.41.12(2);
			}
			if (this.56 != null)
			{
				this.56.16(80, (1046)0, 0);
				this.56.10 = false;
				1433 3 = this.56.8 as 1433;
				if (3 != null)
				{
					3.16(80, (1046)0, 0);
				}
			}
			this.39.28.ForEach(new Action<1371>(2601.2616.Instance.7));
			this.40.28.ForEach(new Action<1371>(2601.2616.Instance.8));
			this.43.22.28.ForEach(new Action<1371>(2601.2616.Instance.9));
			this.29.16(100, (1046)0, 0);
			this.30.16(100, (1046)0, 0);
			this.24.39(198.SkyBlue, 1000, false, (1046)0);
			this.24.16(1000, (1046)0, 0);
			this.24.3.Add(new 1445(1456.Scale, 1f, 2f, 1662.33, 1662.33 + 4000, (1046)1));
			this.24.3.Add(new 1445(1456.Rotation, 0f, 1f, 1662.33, 1662.33 + 4000, (1046)2));
			this.25(true);
			1662.89(1677.Play, false, 1000);
			return;
		}
		1662.SetMode(1677.MatchSetup, false);
	}

	// Token: 0x0600244A RID: 9290 RVA: 0x000A5638 File Offset: 0x000A3838
	private void 78()
	{
		if (this.25 != null)
		{
			this.39.Remove(this.25);
			this.25 = null;
		}
		if (this.24 != null)
		{
			this.24.5 = false;
			this.24.16(300, (1046)0, 0);
			this.24 = null;
		}
		if (this.21 || this.20)
		{
			switch (2486.14())
			{
			case 2147.Taiko:
				this.24 = new 1433(1455.2("mode-taiko", (1416)7, null), (1376)6, 1065.Centre, (1044)0, new 208((float)(1662.70.1() / 2), 240f), 0.12f, true, new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 70), null);
				break;
			case 2147.CatchTheBeat:
				this.24 = new 1433(1455.2("mode-fruits", (1416)7, null), (1376)6, 1065.Centre, (1044)0, new 208((float)(1662.70.1() / 2), 240f), 0.12f, true, new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 70), null);
				break;
			case 2147.OsuMania:
				this.24 = new 1433(1455.2("mode-mania", (1416)7, null), (1376)6, 1065.Centre, (1044)0, new 208((float)(1662.70.1() / 2), 240f), 0.12f, true, new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 70), null);
				break;
			default:
				this.24 = new 1433(1455.2("mode-osu", (1416)7, null), (1376)6, 1065.Centre, (1044)0, new 208((float)(1662.70.1() / 2), 240f), 0.12f, true, new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 70), null);
				break;
			}
			this.24.28 = true;
			this.41.12(this.24);
			if (2601.72)
			{
				1381 <<EMPTY_NAME>>;
				switch (2486.14())
				{
				case 2147.Taiko:
					<<EMPTY_NAME>> = 1455.2("mode-taiko-small", (1416)7, null);
					break;
				case 2147.CatchTheBeat:
					<<EMPTY_NAME>> = 1455.2("mode-fruits-small", (1416)7, null);
					break;
				case 2147.OsuMania:
					<<EMPTY_NAME>> = 1455.2("mode-mania-small", (1416)7, null);
					break;
				default:
					<<EMPTY_NAME>> = 1455.2("mode-osu-small", (1416)7, null);
					break;
				}
				1381 2 = <<EMPTY_NAME>>;
				float num = (float)(1662.70.7() ? 140 : 120);
				this.25 = new 1433(2, (1376)12, 1065.Centre, (1044)0, new 208(num + 28.8f, 35f), 0.97f, true, 198.White, null);
				this.25.28 = true;
				this.39.12(this.25);
				this.25.15 = 0f;
				this.25.25(1f, 1000, (1046)25);
			}
		}
		this.34();
		this.78.39();
		this.15.13();
		this.15.10(1568.1(2679.SongSelection_NoGrouping), 2591.Search);
		this.15.10(1568.1(2679.SongSelection_ByArtist), 2591.Artist);
		this.15.10(1568.1(2679.SongSelection_ByBPM), 2591.BPM);
		this.15.10(1568.1(2679.SongSelection_ByCreator), 2591.Creator);
		this.15.10(1568.1(2679.SongSelection_ByDateAdded), 2591.Date);
		this.15.10(1568.1(2679.SongSelection_ByDifficulty), 2591.Difficulty);
		if (2486.14() == 2147.OsuMania)
		{
			this.15.10(1568.1(2679.SongSelection_ByKeyCount), 2591.Mania_Keys);
		}
		this.15.10(1568.1(2679.SongSelection_ByLength), 2591.Length);
		this.15.10(1568.1(2679.SongSelection_ByMode), 2591.Mode);
		this.15.10(1568.1(2679.SongSelection_ByRankAchieved), 2591.Rank);
		this.15.10(1568.1(2679.SongSelection_ByTitle), 2591.Title);
		this.15.10(1568.1(2679.SongSelection_Collections), 2591.Collection);
		this.15.10(1568.1(2679.SongSelection_Favourites), 2591.Online_Favourites);
		this.15.10(1568.1(2679.SongSelection_MyMaps), 2591.My_Maps);
		this.15.10(1568.1(2679.SongSelection_RankedStatus), 2591.RankedStatus);
		this.15.10(1568.1(2679.SongSelection_RecentlyPlayed), 2591.Last_Played);
		this.15.7.ForEach(new Action<1433>(2601.2616.Instance.10));
		if (2486.14() != 2147.OsuMania && this.65 == 2591.Mania_Keys)
		{
			this.18(2591.Search, false, null, false);
		}
		else
		{
			this.17();
		}
		2019.7(2023.None);
	}

	// Token: 0x0600244B RID: 9291 RVA: 0x000A5B47 File Offset: 0x000A3D47
	private void 79(2147 1)
	{
		if (2486.14() != 1)
		{
			2486.15(1);
			2210.SetMode(1);
			if (1272.5() != null && 1272.5().3() == 2147.Osu)
			{
				this.53(true);
			}
			this.78();
		}
	}

	// Token: 0x0600244C RID: 9292 RVA: 0x000A5B7D File Offset: 0x000A3D7D
	private void 80(object 1, 2023 2)
	{
		this.34();
	}

	// Token: 0x0600244D RID: 9293 RVA: 0x000A5B88 File Offset: 0x000A3D88
	internal static void 81()
	{
		2601 <<EMPTY_NAME>> = 1662.79 as 2601;
		if (<<EMPTY_NAME>> != null)
		{
			<<EMPTY_NAME>>.82(null, null);
		}
	}

	// Token: 0x0600244E RID: 9294 RVA: 0x000A5BAC File Offset: 0x000A3DAC
	private void 82(object 1, EventArgs 2)
	{
		2601.2613 3 = new 2601.2613();
		3.2 = this;
		if (this.21)
		{
			1226.20(null, "click-short-confirm", 1f, false);
			this.78.61();
			3.1 = 2019.1;
			1754 4 = new 1754((2018)15);
			4.3(new EventHandler(3.1));
			1662.25(4);
		}
	}

	// Token: 0x0600244F RID: 9295 RVA: 0x000A5C1C File Offset: 0x000A3E1C
	private void 83(object 1, EventArgs 2)
	{
		if (this.21)
		{
			1226.20(null, "click-short-confirm", 1f, false);
			this.78.61();
			1662.25(new 1746());
		}
	}

	// Token: 0x06002450 RID: 9296 RVA: 0x000A5C60 File Offset: 0x000A3E60
	private void 84(object 1, EventArgs 2)
	{
		if (1662.76 == (932)2)
		{
			this.28.3.Clear();
			1445 3 = new 1445(1456.Scale, 0.6f, 2f, 1662.33, 1662.33 + 800, (1046)0);
			3.15 = (1046)1;
			this.28.3.Add(3);
			this.28.16 = 1f;
			this.28.24(0.01f, 100, (1046)0);
			this.28.10 = false;
			this.26.17 = new 208(900f, 900f);
			this.27.17 = new 208(900f, 900f);
			this.StartPlay();
		}
	}

	// Token: 0x06002451 RID: 9297 RVA: 0x000A5D2C File Offset: 0x000A3F2C
	private void 85(object 1, EventArgs 2)
	{
		1226.20(null, "select-expand", 1f, false);
		1483 3 = this.71;
		if (3 == null)
		{
			return;
		}
		3.1();
	}

	// Token: 0x06002452 RID: 9298 RVA: 0x000A5D62 File Offset: 0x000A3F62
	private void 86(1448 1, bool 2)
	{
		this.64 = (this.64 || 2);
	}

	// Token: 0x06002453 RID: 9299 RVA: 0x000A5D74 File Offset: 0x000A3F74
	private void 87(bool 1)
	{
		bool flag = 1;
		if (this.64)
		{
			this.64 = false;
			if (this.33.GetText().Length == 0)
			{
				return;
			}
			flag = true;
		}
		bool flag2 = !this.78.15 && ((this.61 >= 0 && this.61 <= 1662.33) || 1);
		if (this.33.GetText().Length <= 0 || (!flag && !flag2))
		{
			if (this.33.GetText().Length == 0)
			{
				this.88();
			}
			return;
		}
		this.61 = 1662.33 + 300;
		this.89();
		if (!flag2)
		{
			this.32.SetText(1568.1(2679.SongSelection_Searching));
			return;
		}
		this.78.52();
		int num = 0;
		int num2 = -1;
		this.61 = -1;
		this.63 = this.33.GetText();
		string 2 = this.33.GetText().ToLower();
		foreach (2593 3 in this.78.10)
		{
			3.23 = (!(3 is 2598) && !3.14.28 && 1662.78 == 1677.SelectPlay);
		}
		foreach (string 4 in 2601.29(2))
		{
			2601.2603 5 = 2601.30(4);
			foreach (2593 6 in this.78.10)
			{
				if (!6.23 && !(6 is 2598) && !5(6.14))
				{
					6.23 = true;
				}
			}
		}
		this.78.41();
		this.78.69(0.0);
		bool flag3 = true;
		for (int i = 0; i < this.78.10.Count; i++)
		{
			2593 7 = this.78.10[i];
			if (!7.23 && !(7 is 2598))
			{
				num++;
				if (flag3)
				{
					if (num2 == -1)
					{
						num2 = i;
					}
					else if (7.5())
					{
						flag3 = false;
					}
				}
			}
		}
		2593 8 = this.78.79();
		if (flag3 && num2 > 0 && (8 == null || 8.23 || 8.15 != this.78.10[num2].15))
		{
			this.78.90(num2, true);
		}
		this.90(num);
	}

	// Token: 0x06002454 RID: 9300 RVA: 0x000A6070 File Offset: 0x000A4270
	private void 88()
	{
		if (!this.62)
		{
			return;
		}
		this.78.52();
		this.63 = string.Empty;
		1535.52.Clear();
		foreach (2593 <<EMPTY_NAME>> in this.78.10)
		{
			<<EMPTY_NAME>>.23 = false;
		}
		this.62 = false;
		this.61 = -1;
		this.78.41();
		this.78.69(0.0);
		this.33.27();
		this.31.3.Add(new 1445(1456.Fade, this.31.16, 0.4f, 1662.33, 1662.33 + 200, (1046)0));
		this.31.3.Add(new 1445(new 208(this.31.17.X, 54f), new 208(this.31.17.X, 46f), 1662.33, 1662.33 + 200, (1046)1));
		this.32.16(200, (1046)0, 0);
	}

	// Token: 0x06002455 RID: 9301 RVA: 0x000A61CC File Offset: 0x000A43CC
	private void 89()
	{
		if (!this.62)
		{
			this.31.3.Add(new 1445(1456.Fade, this.31.16, 0.95f, 1662.33, 1662.33 + 300, (1046)0));
			this.31.3.Add(new 1445(new 208(this.31.17.X, 46f), new 208(this.31.17.X, 54f), 1662.33, 1662.33 + 200, (1046)1));
			this.32.FadeIn(300, (1046)0, 0);
			this.62 = true;
		}
	}

	// Token: 0x06002456 RID: 9302 RVA: 0x000A6290 File Offset: 0x000A4490
	private void 90(int 1)
	{
		if (this.62)
		{
			if (1 > 1)
			{
				this.32.SetText(string.Format(1568.1(2679.SongSelection_MatchesFound), 1));
				return;
			}
			if (1 > 0)
			{
				this.32.SetText(string.Format(1568.1(2679.SongSelection_MatchFound), 1));
				return;
			}
			this.32.SetText(1568.1(2679.SongSelection_Reset));
		}
	}

	// Token: 0x0400190B RID: 6411
	private bool 4;

	// Token: 0x0400190C RID: 6412
	private bool 5;

	// Token: 0x0400190D RID: 6413
	private readonly 1433 6;

	// Token: 0x0400190E RID: 6414
	private readonly 1433 7;

	// Token: 0x0400190F RID: 6415
	private readonly 1433 8;

	// Token: 0x04001910 RID: 6416
	private readonly 1452 9;

	// Token: 0x04001911 RID: 6417
	private readonly 1452 10;

	// Token: 0x04001912 RID: 6418
	private readonly 1452 11;

	// Token: 0x04001913 RID: 6419
	private readonly 1452 12;

	// Token: 0x04001914 RID: 6420
	private readonly 1452 13;

	// Token: 0x04001915 RID: 6421
	private readonly 1452 14;

	// Token: 0x04001916 RID: 6422
	private readonly 1373 15;

	// Token: 0x04001917 RID: 6423
	private readonly 1373 16;

	// Token: 0x04001918 RID: 6424
	private readonly 1262 17;

	// Token: 0x04001919 RID: 6425
	private readonly 1452 18;

	// Token: 0x0400191A RID: 6426
	private readonly 1452 19;

	// Token: 0x0400191B RID: 6427
	private readonly bool 20;

	// Token: 0x0400191C RID: 6428
	private readonly bool 21;

	// Token: 0x0400191D RID: 6429
	private readonly 1433 22;

	// Token: 0x0400191E RID: 6430
	private readonly List<1433> 23 = new List<1433>();

	// Token: 0x0400191F RID: 6431
	private 1433 24;

	// Token: 0x04001920 RID: 6432
	private 1433 25;

	// Token: 0x04001921 RID: 6433
	private readonly 1433 26;

	// Token: 0x04001922 RID: 6434
	private readonly 1433 27;

	// Token: 0x04001923 RID: 6435
	private readonly 1433 28;

	// Token: 0x04001924 RID: 6436
	private readonly 1433 29;

	// Token: 0x04001925 RID: 6437
	private readonly 1433 30;

	// Token: 0x04001926 RID: 6438
	private readonly 1433 31;

	// Token: 0x04001927 RID: 6439
	private readonly 1452 32;

	// Token: 0x04001928 RID: 6440
	private 1404 33;

	// Token: 0x04001929 RID: 6441
	private 1354 34;

	// Token: 0x0400192A RID: 6442
	private bool 35;

	// Token: 0x0400192B RID: 6443
	private static string 36;

	// Token: 0x0400192C RID: 6444
	private static string 37;

	// Token: 0x0400192D RID: 6445
	private readonly 1452 38;

	// Token: 0x0400192E RID: 6446
	private readonly 1436 39;

	// Token: 0x0400192F RID: 6447
	private readonly 1436 40;

	// Token: 0x04001930 RID: 6448
	private readonly 1436 41;

	// Token: 0x04001931 RID: 6449
	private readonly 1436 42;

	// Token: 0x04001932 RID: 6450
	private readonly 1417 43;

	// Token: 0x04001933 RID: 6451
	private 1381 44;

	// Token: 0x04001934 RID: 6452
	private readonly 1433 45;

	// Token: 0x04001935 RID: 6453
	private readonly 1381 46;

	// Token: 0x04001936 RID: 6454
	private readonly 1381 47;

	// Token: 0x04001937 RID: 6455
	private readonly 1381 48;

	// Token: 0x04001938 RID: 6456
	private readonly 1381 49;

	// Token: 0x04001939 RID: 6457
	private readonly 1498 50;

	// Token: 0x0400193A RID: 6458
	private readonly 1433 51;

	// Token: 0x0400193B RID: 6459
	private int 52 = -1;

	// Token: 0x0400193C RID: 6460
	private 2593 53;

	// Token: 0x0400193D RID: 6461
	private bool 54;

	// Token: 0x0400193E RID: 6462
	internal 1433 55;

	// Token: 0x0400193F RID: 6463
	private 1433 56;

	// Token: 0x04001940 RID: 6464
	private bool 57;

	// Token: 0x04001941 RID: 6465
	private bool 58;

	// Token: 0x04001942 RID: 6466
	private bool 59;

	// Token: 0x04001943 RID: 6467
	private string 60;

	// Token: 0x04001944 RID: 6468
	private int 61 = -1;

	// Token: 0x04001945 RID: 6469
	private bool 62;

	// Token: 0x04001946 RID: 6470
	private string 63;

	// Token: 0x04001947 RID: 6471
	private bool 64;

	// Token: 0x04001948 RID: 6472
	private 2591 65;

	// Token: 0x04001949 RID: 6473
	private 915 66;

	// Token: 0x0400194A RID: 6474
	private int 67;

	// Token: 0x0400194B RID: 6475
	private List<1433> 68 = new List<1433>();

	// Token: 0x0400194C RID: 6476
	private 1433 69;

	// Token: 0x0400194D RID: 6477
	private 1433 70;

	// Token: 0x0400194E RID: 6478
	private 1483 71;

	// Token: 0x0400194F RID: 6479
	public static bool 72 = true;

	// Token: 0x04001950 RID: 6480
	internal static 1320<2147> 73;

	// Token: 0x04001951 RID: 6481
	private List<2241> 74;

	// Token: 0x04001952 RID: 6482
	private 1373 75;

	// Token: 0x04001953 RID: 6483
	private 1433 76;

	// Token: 0x04001954 RID: 6484
	private bool 77 = true;

	// Token: 0x04001955 RID: 6485
	private 2573 78;

	// Token: 0x04001956 RID: 6486
	private static bool 79;

	// Token: 0x04001957 RID: 6487
	private 1452 80;

	// Token: 0x04001958 RID: 6488
	private HashSet<int> 81 = new HashSet<int>();

	// Token: 0x04001959 RID: 6489
	private static Regex 82 = new Regex("^(\\w*)([<>=]=?|!=)(.*)$");

	// Token: 0x0400195A RID: 6490
	private static Regex 83 = new Regex("(?x)\r\n            ^\r\n            [+-]?\r\n            (?:\r\n                # start with digit\r\n                (?>\\d+) \\.?\r\n                |\r\n                # start with point\r\n                \\. \\d\r\n            )\r\n            \\d*\r\n            (?: e [+-]? \\d+ )?  # possible exponent\r\n            $\r\n        ");

	// Token: 0x0400195B RID: 6491
	private static KeyValuePair<double, string>[] 84 = new KeyValuePair<double, string>[]
	{
		new KeyValuePair<double, string>(0.0, "osu!"),
		new KeyValuePair<double, string>(1.0, "taiko"),
		new KeyValuePair<double, string>(2.0, "catchthebeat"),
		new KeyValuePair<double, string>(2.0, "ctb"),
		new KeyValuePair<double, string>(3.0, "osu!mania"),
		new KeyValuePair<double, string>(3.0, "osumania"),
		new KeyValuePair<double, string>(3.0, "mania"),
		new KeyValuePair<double, string>(3.0, "o!m")
	};

	// Token: 0x0400195C RID: 6492
	private static KeyValuePair<double, string>[] 85 = new KeyValuePair<double, string>[]
	{
		new KeyValuePair<double, string>(0.0, "unknown"),
		new KeyValuePair<double, string>(1.0, "notsubmitted"),
		new KeyValuePair<double, string>(2.0, "pending"),
		new KeyValuePair<double, string>(4.0, "ranked"),
		new KeyValuePair<double, string>(5.0, "approved"),
		new KeyValuePair<double, string>(6.0, "qualified"),
		new KeyValuePair<double, string>(7.0, "loved")
	};

	// Token: 0x0400195D RID: 6493
	private 932 86 = (932)2;

	// Token: 0x0400195E RID: 6494
	private Thread 87;

	// Token: 0x0400195F RID: 6495
	private 1262 88;

	// Token: 0x04001960 RID: 6496
	private 1240 89;

	// Token: 0x04001961 RID: 6497
	private int 90;

	// Token: 0x04001962 RID: 6498
	private 1262 91;

	// Token: 0x04001963 RID: 6499
	private int 92;

	// Token: 0x04001964 RID: 6500
	private 1452 93;

	// Token: 0x04001965 RID: 6501
	private Action 94;

	// Token: 0x04001966 RID: 6502
	private readonly Dictionary<2241, double> 95 = new Dictionary<2241, double>();

	// Token: 0x04001967 RID: 6503
	private 1262 96;

	// Token: 0x020004A0 RID: 1184
	public sealed class 2610
	{
		// Token: 0x06002461 RID: 9313 RVA: 0x000A6708 File Offset: 0x000A4908
		internal void 1()
		{
			1662.89.Schedule(new 1189(this.2), false);
		}

		// Token: 0x06002462 RID: 9314 RVA: 0x000A6722 File Offset: 0x000A4922
		internal void 2()
		{
			if (1662.79 == this.1)
			{
				this.1.18(this.2, this.3, this.4, this.5);
			}
		}

		// Token: 0x06002463 RID: 9315 RVA: 0x000A6754 File Offset: 0x000A4954
		internal void 3()
		{
			if (1662.79 == this.1 && !this.1.5)
			{
				this.1.78.20 = true;
				this.1.78.23 = true;
				this.1.78.91(1272.5(), this.3, this.4, this.5);
				this.1.87(true);
				this.1.78.69(0.0);
			}
		}

		// Token: 0x04001968 RID: 6504
		public 2601 1;

		// Token: 0x04001969 RID: 6505
		public 2591 2;

		// Token: 0x0400196A RID: 6506
		public bool 3;

		// Token: 0x0400196B RID: 6507
		public string 4;

		// Token: 0x0400196C RID: 6508
		public bool 5;
	}

	// Token: 0x020004A1 RID: 1185
	[Serializable]
	public sealed class 2616
	{
		// Token: 0x06002465 RID: 9317 RVA: 0x000A67E9 File Offset: 0x000A49E9
		internal bool 1(1262 1)
		{
			return 1.29 == 1011011;
		}

		// Token: 0x06002466 RID: 9318 RVA: 0x000A67F8 File Offset: 0x000A49F8
		internal void 2(object 1, EventArgs 2)
		{
			1226.20(null, "click-short", 1f, false);
		}

		// Token: 0x06002467 RID: 9319 RVA: 0x000A6820 File Offset: 0x000A4A20
		internal void 3(object 1, EventArgs 2)
		{
			1226.20(null, "click-short", 1f, false);
		}

		// Token: 0x06002468 RID: 9320 RVA: 0x000A6846 File Offset: 0x000A4A46
		internal void 4(object 1, EventArgs 2)
		{
			1662.69("https://osu.offline.invalid/beatmaps/artists");
		}

		// Token: 0x06002469 RID: 9321 RVA: 0x000A6852 File Offset: 0x000A4A52
		internal void 5(1433 1)
		{
			1.45 = -999f;
		}

		// Token: 0x0600246A RID: 9322 RVA: 0x000A6860 File Offset: 0x000A4A60
		internal void 6(1371 1)
		{
			1433 2 = 1 as 1433;
			if (2 != null && 2.GetTexture() != null)
			{
				2.GetTexture().11 = false;
			}
		}

		// Token: 0x0600246B RID: 9323 RVA: 0x000A688C File Offset: 0x000A4A8C
		internal void 7(1371 1)
		{
			if (1.17.Y > 240f)
			{
				1.22(new 208(0f, 110f), 800, (1046)1);
				return;
			}
			1.22(new 208(0f, -110f), 800, (1046)1);
		}

		// Token: 0x0600246C RID: 9324 RVA: 0x000A68E2 File Offset: 0x000A4AE2
		internal void 8(1371 1)
		{
			1.16(500, (1046)0, 0);
		}

		// Token: 0x0600246D RID: 9325 RVA: 0x000A68F1 File Offset: 0x000A4AF1
		internal void 9(1371 1)
		{
			1.16(500, (1046)0, 0);
			1.10 = false;
		}

		// Token: 0x0600246E RID: 9326 RVA: 0x000A6852 File Offset: 0x000A4A52
		internal void 10(1433 1)
		{
			1.45 = -999f;
		}

		// Token: 0x0600246F RID: 9327 RVA: 0x000A6907 File Offset: 0x000A4B07
		internal void 11(object 1, EventArgs 2)
		{
			2601.2616.13(false);
		}

		// Token: 0x06002470 RID: 9328 RVA: 0x000A690F File Offset: 0x000A4B0F
		internal void 12(object 1, EventArgs 2)
		{
			2601.2616.13(true);
		}

		// Token: 0x06002471 RID: 9329 RVA: 0x000A6918 File Offset: 0x000A4B18
		private static void 13(bool 1)
		{
			1262 2 = 1272.5();
			if (2 == null || !261.22(2.29, 2.25, 1))
			{
				1763.5("This beatmap's page could not be opened.", 198.OrangeRed, 4000, null);
			}
		}

		// Token: 0x06002472 RID: 9330 RVA: 0x000A6957 File Offset: 0x000A4B57
		internal void 14()
		{
			1662.69(1296.6 + "/?p=beatmaplist");
		}

		// Token: 0x06002473 RID: 9331 RVA: 0x000A696D File Offset: 0x000A4B6D
		internal void 15(1262 1)
		{
			1272.19(1, false);
		}

		// Token: 0x06002474 RID: 9332 RVA: 0x000A6976 File Offset: 0x000A4B76
		internal bool 16(2241 1)
		{
			return 1.23 == 1662.100.2();
		}

		// Token: 0x06002475 RID: 9333 RVA: 0x000A698D File Offset: 0x000A4B8D
		internal void 17(1433 1)
		{
			1.10 = false;
			1.42 = null;
			1.2 -= 0.01f;
			1.16(500, (1046)0, 0);
			1.5 = false;
		}

		// Token: 0x06002476 RID: 9334 RVA: 0x000A69C3 File Offset: 0x000A4BC3
		internal void 18()
		{
			if (!1662.104.17())
			{
				2601.79 = false;
				return;
			}
			1662.104.49(false);
			1662.104.16(true);
			1662.104.39(1662.104.45);
		}

		// Token: 0x0400196D RID: 6509
		public static readonly 2601.2616 Instance = new 2601.2616();

		// Token: 0x0400196E RID: 6510
		public static Func<1262, bool> func;

		// Token: 0x0400196F RID: 6511
		public static EventHandler eventHandler;

		// Token: 0x04001970 RID: 6512
		public static EventHandler eventHandler2;

		// Token: 0x04001971 RID: 6513
		public static EventHandler eventHandler3;

		// Token: 0x04001972 RID: 6514
		public static EventHandler eventHandler4;

		// Token: 0x04001973 RID: 6515
		public static EventHandler eventHandler5;

		// Token: 0x04001974 RID: 6516
		public static Action<1433> action;

		// Token: 0x04001975 RID: 6517
		public static Action<1371> action2;

		// Token: 0x04001976 RID: 6518
		public static Action<1371> action3;

		// Token: 0x04001977 RID: 6519
		public static Action<1371> action4;

		// Token: 0x04001978 RID: 6520
		public static Action<1371> action5;

		// Token: 0x04001979 RID: 6521
		public static Action<1433> action6;

		// Token: 0x0400197A RID: 6522
		public static 1189 voidDelegate;

		// Token: 0x0400197B RID: 6523
		public static EventHandler eventHandler6;

		// Token: 0x0400197C RID: 6524
		public static EventHandler eventHandler7;

		// Token: 0x0400197D RID: 6525
		public static 1189 voidDelegate2;

		// Token: 0x0400197E RID: 6526
		public static 1189 voidDelegate3;

		// Token: 0x0400197F RID: 6527
		public static Predicate<1262> predicate;

		// Token: 0x04001980 RID: 6528
		public static Action<1262> action7;

		// Token: 0x04001981 RID: 6529
		public static Func<char, bool> func2;

		// Token: 0x04001982 RID: 6530
		public static Predicate<2241> predicate2;

		// Token: 0x04001983 RID: 6531
		public static Predicate<2241> predicate3;

		// Token: 0x04001984 RID: 6532
		public static Action<1371> action8;

		// Token: 0x04001985 RID: 6533
		public static Action<1433> action9;

		// Token: 0x04001986 RID: 6534
		public static Action<1433> action10;

		// Token: 0x04001987 RID: 6535
		public static 1189 voidDelegate4;
	}

	// Token: 0x020004A2 RID: 1186
	public sealed class 2608
	{
		// Token: 0x06002479 RID: 9337 RVA: 0x000A6A0E File Offset: 0x000A4C0E
		internal void 1(object 1, EventArgs 2)
		{
			this.1.25(0.85f, 2000, (1046)1);
		}

		// Token: 0x04001988 RID: 6536
		public 1433 1;
	}

	// Token: 0x020004A3 RID: 1187
	public sealed class 2612
	{
		// Token: 0x0600247B RID: 9339 RVA: 0x000A6A28 File Offset: 0x000A4C28
		internal void OnClick(object 1, EventArgs 2)
		{
			1226.20(null, "click-short-confirm", 1f, false);
			this.4.79(this.3);
		}

		// Token: 0x04001989 RID: 6537
		public 1433 1;

		// Token: 0x0400198A RID: 6538
		public 1452 2;

		// Token: 0x0400198B RID: 6539
		public 2147 3;

		// Token: 0x0400198C RID: 6540
		public 2601 4;
	}

	// Token: 0x020004A4 RID: 1188
	public sealed class 2609
	{
		// Token: 0x0600247D RID: 9341 RVA: 0x000A6A5F File Offset: 0x000A4C5F
		internal bool 1(1262 1)
		{
			return 2601.32(1, this.2);
		}

		// Token: 0x0400198D RID: 6541
		public int 1;

		// Token: 0x0400198E RID: 6542
		public string 2;
	}

	// Token: 0x020004A5 RID: 1189
	public sealed class 2614
	{
		// Token: 0x0400198F RID: 6543
		public int 1;

		// Token: 0x04001990 RID: 6544
		public int 2;

		// Token: 0x04001991 RID: 6545
		public bool 3;

		// Token: 0x04001992 RID: 6546
		public char 4;
	}

	// Token: 0x020004A6 RID: 1190
	// (Invoke) Token: 0x06002481 RID: 9345
	public delegate bool 2603(1262 1);

	// Token: 0x020004A7 RID: 1191
	public sealed class 2611
	{
		// Token: 0x04001993 RID: 6547
		public DateTime 1;

		// Token: 0x04001994 RID: 6548
		public 2601.2606 2;
	}

	// Token: 0x020004A8 RID: 1192
	public sealed class 2606
	{
		// Token: 0x06002485 RID: 9349 RVA: 0x000A6A6D File Offset: 0x000A4C6D
		internal bool 1(1262 1)
		{
			return 2601.31<double>(Math.Round((double)1.2, 1), this.1, this.2) && 1.3() != 2147.OsuMania && 1.3() != 2147.Taiko;
		}

		// Token: 0x06002486 RID: 9350 RVA: 0x000A6AA6 File Offset: 0x000A4CA6
		internal bool 2(1262 1)
		{
			return 2601.31<double>(Math.Round((double)1.3, 1), this.1, this.2);
		}

		// Token: 0x06002487 RID: 9351 RVA: 0x000A6AC6 File Offset: 0x000A4CC6
		internal bool 3(1262 1)
		{
			return 2601.31<double>(Math.Round((double)1.1, 1), this.1, this.2) && 1.3() != 2147.OsuMania && 1.3() != 2147.Taiko;
		}

		// Token: 0x06002488 RID: 9352 RVA: 0x000A6AFF File Offset: 0x000A4CFF
		internal bool 4(1262 1)
		{
			return 2601.31<double>((double)2011.52(1), this.1, this.2) && (1.3() == 2147.OsuMania || 1.3() == 2147.Osu);
		}

		// Token: 0x06002489 RID: 9353 RVA: 0x000A6B31 File Offset: 0x000A4D31
		internal bool 5(1262 1)
		{
			return 2601.31<double>((double)1.92, this.1, this.2) && (1.3() == 2147.OsuMania || 1.3() == 2147.Osu);
		}

		// Token: 0x0600248A RID: 9354 RVA: 0x000A6B63 File Offset: 0x000A4D63
		internal bool 6(1262 1)
		{
			return 2601.31<double>((double)(1.87 / 1000), this.1, this.2);
		}

		// Token: 0x0600248B RID: 9355 RVA: 0x000A6B83 File Offset: 0x000A4D83
		internal bool 7(1262 1)
		{
			return 2601.31<double>((double)Math.Max(1.53, 1.52), this.1, this.2);
		}

		// Token: 0x0600248C RID: 9356 RVA: 0x000A6BA8 File Offset: 0x000A4DA8
		internal bool 8(1262 1)
		{
			return 2601.31<double>((double)1.3(), this.1, this.2);
		}

		// Token: 0x0600248D RID: 9357 RVA: 0x000A6BC2 File Offset: 0x000A4DC2
		internal bool 9(1262 1)
		{
			return 2601.31<double>((double)1.85, this.1, this.2) || 2601.31<double>((double)1.85, this.1, this.2 + 1.0);
		}

		// Token: 0x0600248E RID: 9358 RVA: 0x000A6C02 File Offset: 0x000A4E02
		internal bool 10(1262 1)
		{
			return 2601.31<double>((double)1.85, this.1, this.2) && 2601.31<double>((double)1.85, this.1, this.2 + 1.0);
		}

		// Token: 0x0600248F RID: 9359 RVA: 0x000A6C42 File Offset: 0x000A4E42
		internal bool 11(1262 1)
		{
			return 2601.31<double>((double)1.85, this.1, this.2);
		}

		// Token: 0x06002490 RID: 9360 RVA: 0x000A6C5C File Offset: 0x000A4E5C
		internal bool 12(1262 1)
		{
			string 2 = 1.43;
			return (2 != null && 2.ToLower().Contains(this.3)) == (this.1 == "==");
		}

		// Token: 0x06002491 RID: 9361 RVA: 0x000A6C90 File Offset: 0x000A4E90
		internal bool 13(1262 1)
		{
			string 2 = 1.7;
			bool flag;
			if (2 == null || !2.ToLower().Contains(this.3))
			{
				string 3 = 1.8;
				flag = (3 != null && 3.ToLower().Contains(this.3));
			}
			else
			{
				flag = true;
			}
			return flag == (this.1 == "==");
		}

		// Token: 0x06002492 RID: 9362 RVA: 0x000A6CEC File Offset: 0x000A4EEC
		internal bool 14(1262 1)
		{
			string 2 = 1.89;
			return (2 != null && 2.ToLower().Contains(this.3)) == (this.1 == "==");
		}

		// Token: 0x04001995 RID: 6549
		public string 1;

		// Token: 0x04001996 RID: 6550
		public double 2;

		// Token: 0x04001997 RID: 6551
		public string 3;
	}

	// Token: 0x020004A9 RID: 1193
	public sealed class 2617
	{
		// Token: 0x06002494 RID: 9364 RVA: 0x000A6D1D File Offset: 0x000A4F1D
		internal bool 1(1262 1)
		{
			return 1.72() == 2236.N && 2601.31<DateTime>(1.46, "<", this.1);
		}

		// Token: 0x04001998 RID: 6552
		public DateTime 1;
	}

	// Token: 0x020004AA RID: 1194
	public sealed class 2607
	{
		// Token: 0x06002496 RID: 9366 RVA: 0x000A6D44 File Offset: 0x000A4F44
		internal void 1()
		{
			HashSet<int> <<EMPTY_NAME>> = this.1.81;
			lock (<<EMPTY_NAME>>)
			{
				this.1.81.Remove(this.2.25);
			}
			if (this.1.59)
			{
				return;
			}
			this.1.39();
			if (this.2 == 1272.5())
			{
				this.1.42();
			}
		}

		// Token: 0x04001999 RID: 6553
		public 2601 1;

		// Token: 0x0400199A RID: 6554
		public 1262 2;
	}

	// Token: 0x020004AB RID: 1195
	public sealed class 2615
	{
		// Token: 0x06002498 RID: 9368 RVA: 0x000A6DD0 File Offset: 0x000A4FD0
		internal void 1(object 1, EventArgs 2)
		{
			this.1.16(100, (1046)0, 0);
			1505 3 = this.2;
			if (3 == null)
			{
				return;
			}
			3.39(198.White, 100, false, (1046)0);
		}

		// Token: 0x0400199B RID: 6555
		public 1452 1;

		// Token: 0x0400199C RID: 6556
		public 1505 2;
	}

	// Token: 0x020004AC RID: 1196
	public sealed class 2618
	{
		// Token: 0x0400199D RID: 6557
		public 2601 1;

		// Token: 0x0400199E RID: 6558
		public object 2;

		// Token: 0x0400199F RID: 6559
		public EventArgs 3;
	}

	// Token: 0x020004AD RID: 1197
	public sealed class 2619
	{
		// Token: 0x0600249B RID: 9371 RVA: 0x000A6DFB File Offset: 0x000A4FFB
		internal void 1()
		{
			if (this.1)
			{
				this.2.53(true);
			}
			else
			{
				this.2.58();
				1763.4(1568.1(2679.SongSelection_UpdateNotAvailable));
			}
			1272.15.EnableRaisingEvents = true;
		}

		// Token: 0x040019A0 RID: 6560
		public bool 1;

		// Token: 0x040019A1 RID: 6561
		public 2601 2;
	}

	// Token: 0x020004AE RID: 1198
	public sealed class 2602
	{
		// Token: 0x0600249D RID: 9373 RVA: 0x000A6E38 File Offset: 0x000A5038
		internal void 1(object 1, EventArgs 2)
		{
			this.1.ForEach(new Action<1262>(2601.2616.Instance.15));
		}

		// Token: 0x040019A2 RID: 6562
		public List<1262> 1;
	}

	// Token: 0x020004AF RID: 1199
	public sealed class 2604
	{
		// Token: 0x0600249F RID: 9375 RVA: 0x000A6E58 File Offset: 0x000A5058
		internal void 1(1621 1, Exception 2)
		{
			if (2 == null)
			{
				1662.89.Schedule(new 1189(this.2), false);
			}
			else
			{
				try
				{
					File.Delete(this.2.60);
				}
				catch
				{
				}
			}
			this.2.74(this.3 == null);
		}

		// Token: 0x060024A0 RID: 9376 RVA: 0x000A6EBC File Offset: 0x000A50BC
		internal void 2()
		{
			this.1.57();
		}

		// Token: 0x040019A3 RID: 6563
		public 1262 1;

		// Token: 0x040019A4 RID: 6564
		public 2601 2;

		// Token: 0x040019A5 RID: 6565
		public EventArgs 3;
	}

	// Token: 0x020004B0 RID: 1200
	public sealed class 2605
	{
		// Token: 0x060024A2 RID: 9378 RVA: 0x000A6EC9 File Offset: 0x000A50C9
		internal void Delete(object 1, EventArgs 2)
		{
			1297.10(this.1);
			this.2.18(this.2.65, false, null, false);
		}

		// Token: 0x040019A6 RID: 6566
		public string 1;

		// Token: 0x040019A7 RID: 6567
		public 2601 2;
	}

	// Token: 0x020004B1 RID: 1201
	public sealed class 2613
	{
		// Token: 0x060024A4 RID: 9380 RVA: 0x000A6EEF File Offset: 0x000A50EF
		internal void 1(object 1, EventArgs 2)
		{
			if (2019.1 != this.1 && 1304.164 == 1289.SelectedMod)
			{
				this.2.53(true);
			}
		}

		// Token: 0x040019A8 RID: 6568
		public 2023 1;

		// Token: 0x040019A9 RID: 6569
		public 2601 2;
	}
}
