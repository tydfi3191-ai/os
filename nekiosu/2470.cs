using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using osu_ui;

// Token: 0x02000553 RID: 1363
public sealed class 2470 : 2462
{
	// Token: 0x060029DB RID: 10715 RVA: 0x000D9B38 File Offset: 0x000D7D38
	private void 1()
	{
		2470.2476 <<EMPTY_NAME>> = new 2470.2476();
		<<EMPTY_NAME>>.1 = this;
		if (1662.115 < 5L)
		{
			1662.89.2(new 1189(this.1), 50, false);
			return;
		}
		if (1304.199)
		{
			1662.89.2(delegate
			{
				1226.Pause();
			}, 0, false);
		}
		1662.89.2(new 1189(2470.2473.instance.1), 100, false);
		2470.4 = false;
		this.48.15 = 0.9f;
		this.48.20 = new 208(1f, 0f);
		this.48.15(1800);
		this.48.3.Add(new 1445(1456.VectorScale, new 208(1f, 0f), new 208(1f, 1f), 1662.33 + 200, 1662.33 + 600, (1046)1));
		1247.3(false);
		<<EMPTY_NAME>>.2 = 120;
		1662.89.2(new 1189(<<EMPTY_NAME>>.1), 2470.53 - <<EMPTY_NAME>>.2, false);
	}

	// Token: 0x060029DC RID: 10716 RVA: 0x000D9C8E File Offset: 0x000D7E8E
	private bool 2(bool 1)
	{
		this.37 = 1662.33;
		if (2470.36)
		{
			if (!1)
			{
				1226.27(new string[]
				{
					"menu-osu",
					"menuhit"
				});
			}
			return true;
		}
		return false;
	}

	// Token: 0x060029DD RID: 10717 RVA: 0x000D9CC4 File Offset: 0x000D7EC4
	private new void 3(object 1, EventArgs 2)
	{
		1662.79(new EventHandler(this.3));
	}

	// Token: 0x060029DE RID: 10718 RVA: 0x000D9CD8 File Offset: 0x000D7ED8
	private void 4()
	{
		if (!1535.32)
		{
			return;
		}
		bool flag = (double)208.Distance(1535.6, 1535.74) > 5.0 * 1662.10;
		if (!2470.36 && flag && 1662.11.2())
		{
			this.37 = 1662.33;
		}
		if (this.37 > 0 && 1662.33 - this.37 > 6000 != 2470.36)
		{
			this.5(!2470.36, false);
		}
		if (!1662.47)
		{
			if (flag || 1662.33 - this.37 < 6000)
			{
				1247.6.5 = (this.19.5 = (float)Math.Min(1.0, (double)1247.6.5 + 0.07999999821186066 * 1662.10));
				return;
			}
			1247.6.5 = (this.19.5 = (float)Math.Max(0.009999999776482582, (double)1247.6.5 - 0.0010000000474974513 * 1662.10));
		}
	}

	// Token: 0x060029DF RID: 10719 RVA: 0x000D9E0C File Offset: 0x000D800C
	private void 5(bool 1, bool 2)
	{
		2470.2472 idleTransition = new 2470.2472();
		idleTransition.1 = 2;
		idleTransition.2 = this;
		2470.36 = 3;
		1662.55.8 = (2470.36 ? 1f : 0.4f);
		if (2470.36)
		{
			this.5[this.6].ForEach(new Action<1433>(idleTransition.1));
			this.29.ForEach(delegate(1433 1)
			{
				1.16((!idleTransition.1) ? 500 : 0, (1046)0, 0);
			});
			this.14.19(new 208(0f, this.15.17.Y), (!idleTransition.1) ? 2000 : 0, (1046)1);
			this.15.19(new 208(0f, this.15.17.Y), (!idleTransition.1) ? 2000 : 0, (1046)1);
			return;
		}
		this.29.ForEach(new Action<1433>(idleTransition.2));
		this.5[this.6].ForEach(delegate(1433 1)
		{
			if (1.9 == (int)idleTransition.2.6)
			{
				1.FadeIn(350, (1046)0, 0);
				1.17 = 1.7 - new 208(100f, 0f);
				1.19(1.7, 400, (1046)1);
			}
			if (1.9 != -1)
			{
				1.10 = true;
			}
		});
		this.14.19(this.14.7, 400, (1046)1);
		this.15.19(this.14.7, 400, (1046)1);
	}

	// Token: 0x060029E0 RID: 10720 RVA: 0x000D9FA0 File Offset: 0x000D81A0
	private void 6(string[] 1, int? 2)
	{
		try
		{
			foreach (string text in 1.OrderBy(new Func<string, double>(new 2470.2471
			{
				1 = new 1193(DateTime.UtcNow.Year * 1000 + DateTime.UtcNow.DayOfYear / 7)
			}.1)).Take(2.GetValueOrDefault(int.MaxValue)))
			{
				1731.11(new 1576(int.Parse(text.Split(new char[]
				{
					' '
				})[0]), text, text.Replace(".osz", string.Empty).Substring(text.IndexOf("-")).Trim(), false, 0));
			}
		}
		catch
		{
		}
	}

	// Token: 0x060029E1 RID: 10721 RVA: 0x000DA094 File Offset: 0x000D8294
	private static void 7()
	{
		2470.28 = new 1627();
		2470.64 = null;
	}

	// Token: 0x060029E2 RID: 10722 RVA: 0x000DA0A8 File Offset: 0x000D82A8
	internal 2470(1803 1) : base(1)
	{
	}

	// Token: 0x060029E3 RID: 10723 RVA: 0x000DA7C0 File Offset: 0x000D89C0
	public override void Initialize()
	{
		base.Initialize();
		if (1662.47)
		{
			2486.88 = null;
		}
		1535.2(false);
		1549.1(new 1549.1550(this.21));
		1546.1(new 1546.1547(this.11));
		1662.73(new 1189(this.10));
		this.17 = new 1436(true)
		{
			24 = true
		};
		this.18 = new 1436(true)
		{
			24 = true
		};
		this.19 = new 1436(true);
		if (2470.4)
		{
			try
			{
				if (1272.3.Count == 0 && Directory.GetFiles(1272.1).Length + Directory.GetDirectories(1272.1).Length < 6)
				{
					this.6(new string[]
					{
						"1011011 nekodex - new beginnings.osz",
						"1388906 Raphlesia & BilliumMoto - My Love.osz"
					}, null);
					this.6(this.22, new int?(8));
					this.6(this.23, new int?(3));
					this.6(this.24, new int?(3));
					this.6(this.25, new int?(3));
				}
			}
			catch
			{
			}
			1535.32 = false;
			1226.1 = false;
			if (1304.199)
			{
				try
				{
					1262 <<EMPTY_NAME>> = new 1262();
					<<EMPTY_NAME>>.56(new 1514(ResourcesStore.ResourceManager.GetStream("bgm_welcome_circles"), false));
					<<EMPTY_NAME>>.18 = "circles.ogg";
					<<EMPTY_NAME>>.7 = "nekodex";
					<<EMPTY_NAME>>.10 = "circles!";
					<<EMPTY_NAME>>.58 = "nekodex - circles! (peppy).osu";
					<<EMPTY_NAME>>.81 = "nekodex - circles!";
					this.52 = <<EMPTY_NAME>>;
				}
				catch
				{
					this.52 = null;
				}
				if (this.52 != null)
				{
					1226.99(this.52, false, true, true, false);
					1272.SetCurrentBeatmap(this.52);
				}
			}
			this.16 = new 1436(true);
			this.47 = new 1433(1662.34, (1376)5, 1065.TopLeft, (1044)0, 208.Zero, 0.9999f, true, 198.Black, null);
			this.47.20 = new 208((float)1662.70.1, (float)1662.70.2);
			this.48 = new 1433(1455.2("welcome_text", (!1308.1) ? ((1416)1) : ((1416)7), null), (1376)10, 1065.Centre, (1044)0, new 208(0f, 0f), 1f, true, 198.White, null);
			this.48.20 = 208.Zero;
			this.16.12(this.47);
			this.16.12(this.48);
			1662.89.Schedule(new 1189(this.1), false);
		}
		else
		{
			this.24();
			1662.125 = (1189)Delegate.Combine(1662.125, new 1189(this.24));
			this.23();
			this.8(true);
		}
		2470.7();
		this.14 = new 1367(1455.2("menu-nekiosu", (1416)1, null), new 208(-120f, 0f), 0.98f, true, 198.White, 300);
		this.14.41 = (1376)10;
		this.14.3(new EventHandler(this.14));
		this.14.10 = true;
		this.18.12(this.14);
		this.20.10 = new 208((float)1662.70.1(), (float)1662.70.2()) / 2f + new 208(0f, 0f);
		foreach (object obj in Enum.GetValues(typeof(2470.2475)))
		{
			2470.2475 key = (2470.2475)obj;
			this.5.Add(key, new List<1433>());
		}
		this.57 = this.12("play", new 208(-100f, -125f), delegate(object 1, EventArgs 2)
		{
			if (!1345.1 && 1226.14())
			{
				1662.SetMode(1677.SelectPlay, false);
				this.17(1);
			}
		}, 2470.2475.Main);
		this.58 = this.12("edit", new 208(-100f, -60f), new EventHandler(this.18), 2470.2475.Main);
		this.59 = this.12("options", new 208(-100f, 5f), new EventHandler(this.19), 2470.2475.Main);
		this.60 = this.12("exit", new 208(-100f, 70f), new EventHandler(this.20), 2470.2475.Main);
		this.61 = this.12("freeplay", new 208(-100f, -60f), delegate(object 1, EventArgs 2)
		{
			1662.SetMode(1677.SelectPlay, false);
			this.17(1);
		}, 2470.2475.Play);
		this.62 = this.12("back", new 208(-100f, 5f), new EventHandler(this.15), 2470.2475.Play);
		this.15 = new 1433(1455.2("menu-nekiosu", (1416)1, null), (1376)10, 1065.Centre, (1044)0, new 208(-120f, 0f), 0.981f, true, 198.White, null);
		if (1304.107)
		{
			this.15.9(true);
		}
		this.18.12(this.15);
		1452 3 = new 1452(string.Empty, 14f, new 208(210f, 0f), 208.Zero, 0.95f, true, 198.White, false);
		3.63(true);
		this.7 = 3;
		this.19.12(this.7);
		this.29.Add(this.7);
		this.28();
		string text = 2470.27();
		if (!string.IsNullOrEmpty(text))
		{
			this.56 = new 1452(text, 16f, new 208(0f, 52f), new 208((float)1662.70.1 / 1662.70.3(), 0f), 0.989f, false, 198.White, false);
			this.56.41 = (1376)13;
			this.56.75 = (1066)2;
			this.56.49 = 1065.TopCentre;
			this.56.63(true);
			this.56.3.Add(new 1445(1456.Fade, 0f, 1f, 1662.33 + 2470.53, 1662.33 + 2470.53 + 1000, (1046)0));
			this.56.3.Add(new 1445(1456.Fade, 1f, 0f, 1662.33 + 2470.53 + 12000, 1662.33 + 2470.53 + 12500, (1046)0));
			this.19.12(this.56);
		}
		this.11 = new 1433(1455.2("menu-bat", (1416)1, null), (1376)6, 1065.Centre, (1044)0, new 208((float)1662.70.1 / 1662.70.3() - 50f, (float)1662.70.2 / 1662.70.3() - 30f), 0.96f, true, 198.TransparentWhite, null);
		this.11.52 = 1568.1(2679.Menu_BAT);
		this.11.10 = true;
		this.19.12(this.11);
		this.12 = new 1433(1455.2("menu-subscriber", (1416)1, null), (1376)6, 1065.Centre, (1044)0, new 208((float)1662.70.1 / 1662.70.3() - 20f, (float)1662.70.2 / 1662.70.3() - 30f), 0.96f, true, 198.TransparentWhite, null);
		this.12.52 = 1568.1(2679.Menu_Supporter);
		this.12.10 = true;
		this.19.12(this.12);
		this.10 = new 1433(1455.2("menu-osudirect", (1416)1, null), (1376)11, 1065.CentreRight, (1044)0, new 208(0f, 0f), 0.95f, true, 198.TransparentWhite, null);
		this.19.12(this.10);
		this.9 = new 1433(1455.2("menu-osudirect-over", (1416)1, null), (1376)11, 1065.CentreRight, (1044)0, new 208(0f, 0f), 0.96f, true, 198.White, null);
		this.9.16 = 0.01f;
		this.19.12(this.9);
		this.9.10 = true;
		this.9.35(delegate(object 1, EventArgs 2)
		{
			if (1662.11.2())
			{
				1226.27(new string[]
				{
					"menu-direct-hover",
					"menuclick"
				});
			}
		});
		this.9.3(new EventHandler(this.22));
		this.26 = new 1433(1455.2("menu-flash", (1416)1, null), 1065.CentreLeft, new 208(0f, 240f), 0.05f, true, 198.TransparentWhite);
		this.26.54 = true;
		this.26.28 = true;
		this.26.20 = new 208(-1f, 4f);
		this.17.12(this.26);
		this.27 = new 1433(1455.2("menu-flash", (1416)1, null), 1065.CentreRight, new 208((float)1662.70.1 / 1662.70.3(), 240f), 0.05f, true, 198.TransparentWhite);
		this.27.28 = true;
		this.27.54 = true;
		this.27.20 = new 208(1f, 4f);
		this.17.12(this.27);
		this.54 = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, 208.Zero, 0f, true, 198.Black, null);
		this.54.16 = (2470.4 ? 0f : 0.4f);
		this.54.15 = 1.6f;
		this.54.20 = new 208((float)1662.70.1(), 54f);
		this.19.12(this.54);
		this.55 = new 1433(1662.34, (1376)12, 1065.BottomLeft, (1044)0, 208.Zero, 0f, true, 198.Black, null);
		this.55.16 = (2470.4 ? 0f : 0.4f);
		this.55.15 = 1.6f;
		this.55.20 = new 208((float)1662.70.1(), 54f);
		this.19.12(this.55);
		this.26(true);
		this.40 = 1455.2("star2", (1416)1, null);
		1662.78(new EventHandler(this.3));
		if (2470.4)
		{
			1662.75 = 0.0;
		}
		this.5(true, true);
		this.43 = new 1452(null, 10f, new 208(0f, (float)(1662.70.2() - 34)), 1f, true, 198.White);
		this.43.62(198.White);
		this.43.49 = 1065.TopLeft;
		this.43.75 = (1066)2;
		this.19.12(this.43);
		1662.95(false, false);
		1662.55.8 = 1f;
	}

	// Token: 0x060029E4 RID: 10724 RVA: 0x000DB3C4 File Offset: 0x000D95C4
	private void 8(bool 1)
	{
		this.20.5(2630.4["MenuGlow"], 1);
	}

	// Token: 0x060029E5 RID: 10725 RVA: 0x000DB3E4 File Offset: 0x000D95E4
	protected override void Dispose(bool 1)
	{
		1662.125 = (1189)Delegate.Remove(1662.125, new 1189(this.24));
		1549.2(new 1549.1550(this.21));
		1546.2(new 1546.1547(this.11));
		1662.79(new EventHandler(this.3));
		1662.74(new 1189(this.10));
		if (this.17 != null)
		{
			this.17.Dispose();
		}
		if (this.19 != null)
		{
			this.19.Dispose();
		}
		if (this.16 != null)
		{
			this.16.Dispose();
		}
		if (this.18 != null)
		{
			this.18.Dispose();
		}
		if (this.42 != null)
		{
			this.42.5 = false;
		}
		if (this.20 != null)
		{
			this.20.Dispose();
		}
		if (this.21 != null)
		{
			this.21.Dispose();
		}
		if (this.51 != null)
		{
			this.51.Dispose();
		}
		if (2470.63 != null)
		{
			2470.63.Cancel();
			2470.63 = null;
		}
		if (2470.64 != null)
		{
			2470.64.Cancel();
			2470.64 = null;
		}
		base.Dispose(1);
	}

	// Token: 0x060029E6 RID: 10726 RVA: 0x000DB524 File Offset: 0x000D9724
	public override void Draw()
	{
		this.17.22();
		if (this.44 < 100f)
		{
			this.18.22();
		}
		if (this.16 != null)
		{
			this.16.22();
		}
		this.20.Draw();
		if (this.44 >= 100f)
		{
			this.18.22();
		}
		this.19.22();
		if (this.44 >= 0f)
		{
			this.21.Draw();
		}
		base.Draw();
	}

	// Token: 0x060029E7 RID: 10727 RVA: 0x000DB5B8 File Offset: 0x000D97B8
	private void 9()
	{
		1433 <<EMPTY_NAME>> = new 1433(1455.2("menu-osu-shockwave", (1416)1, null), (1376)10, 1065.Centre, (1044)0, this.14.17, 0.2f, false, 198.White, null);
		<<EMPTY_NAME>>.28 = true;
		<<EMPTY_NAME>>.16 = 0.1f * this.39;
		<<EMPTY_NAME>>.16(1000, (1046)0, 0);
		<<EMPTY_NAME>>.3.Add(new 1445(1456.Scale, this.14.15, this.14.15 * 1.4f, 1662.33, 1662.33 + 1000, (1046)1));
		this.17.12(<<EMPTY_NAME>>);
	}

	// Token: 0x060029E8 RID: 10728 RVA: 0x000DB664 File Offset: 0x000D9864
	public override void Update()
	{
		if (this.44 > 100f && !1662.47)
		{
			this.20.3 = 1.6f;
			this.20.4 = null;
			if (1304.118)
			{
				float <<EMPTY_NAME>> = 1535.6.X - (float)(1662.70.1 / 2);
				float 2 = 1535.6.Y - (float)(1662.70.2 / 2);
				1436 3 = this.18;
				208 4 = this.17.29 = new 208(<<EMPTY_NAME>>, 2) / 1662.70.3() / 60f;
				3.29 = 4;
			}
			else
			{
				1436 5 = this.18;
				208 4 = this.17.29 = 208.Zero;
				5.29 = 4;
			}
		}
		if (this.44 <= 100f && 1662.76 != (932)0)
		{
			if (this.44 >= 0f && 1662.23 && 1662.33 > 1000)
			{
				this.44 += 5f;
			}
			if (this.44 < 0f)
			{
				this.20.3 = 2f;
				this.20.11 = 0.1f;
			}
			else
			{
				this.20.3 = 1.6f;
				this.20.4 = null;
			}
		}
		if (!1662.11.2() && 1226.56 > 40)
		{
			1262 6 = this.52;
			1240 7 = 1226.31;
			if (6 == ((7 != null) ? 7.1 : null))
			{
				1226.46(1226.56 - 5, true);
			}
		}
		if (this.32 != 1226.63())
		{
			this.32 = 1226.63();
			if (this.32 && (this.33 == 0 || 1662.33 - this.33 > 500) && Math.Abs((double)1226.16 - 1226.73().3) < 500.0)
			{
				int num = 1196.2(-1, 2);
				for (int i = 0; i < 100; i++)
				{
					int num2 = 1662.33 + i * 10;
					int num3 = num2 + 1196.2(300, 1300);
					1445 8 = new 1445(1456.Scale, 1f, 1196.7(1f, 1304.107 ? 2.1f : 2.8f), num2, num3, (1046)0);
					1445 9 = new 1445(1456.Fade, 1f, 0f, num2, num3, (1046)0);
					1445 10 = new 1445(1456.Rotation, 1196.7(-2f, 2f), 1196.7(-2f, 2f), num2, num3, (1046)0);
					8.15 = (1046)1;
					9.15 = (1046)1;
					10.15 = (1046)1;
					208 4 = new 208(100f, 490f);
					1433 11 = new 1433(this.40, (1376)6, 1065.Centre, (1044)0, 4, 1f, false, 198.White, null);
					11.28 = true;
					11.3.Add(8);
					11.3.Add(9);
					11.3.Add(10);
					this.17.12(11);
					1662.44.2(11, new 208?(new 208((float)num * ((float)i - 50f) / 50f * 450f + (float)1196.2(-50, 50), (float)1196.2(-800, -700))), true).3 = 80f;
					4 = new 208((float)(1662.70.1() - 100), 490f);
					1433 12 = new 1433(this.40, (1376)6, 1065.Centre, (1044)0, 4, 1f, false, 198.White, null);
					12.28 = true;
					12.3.Add(8);
					12.3.Add(9);
					12.3.Add(10);
					this.17.12(12);
					1662.44.2(12, new 208?(new 208((float)num * ((float)i - 50f) / 50f * -450f + (float)1196.2(-50, 50), (float)1196.2(-800, -700))), true).3 = 80f;
				}
				this.33 = 1662.33;
			}
		}
		if (1662.77 == 1677.Exit)
		{
			this.30 -= (float)(1662.10 * 0.003);
			this.14.14 += (float)(1662.10 * 0.001);
			this.15.14 += (float)(1662.10 * 0.001);
			this.14.16 -= (float)(1662.10 * 0.002);
			this.15.16 -= (float)(1662.10 * 0.002);
		}
		else if (this.14.IsHovered() || this.30 < 0f)
		{
			this.30 = Math.Min(this.30 + (float)(0.012 * 1662.10), 0.1f);
		}
		else
		{
			this.30 = Math.Max(this.30 - (float)(0.012 * 1662.10), 0f);
		}
		int num4 = 32768;
		float num5;
		float num6;
		if (1226.31 == null || 1226.31.IsStreamAvailable())
		{
			num5 = 0.5f;
			num6 = 0.5f;
		}
		else
		{
			int 13 = 0;
			try
			{
				13 = 1219.10(1226.31.2());
			}
			catch
			{
			}
			int num7 = 1019.8(13);
			int num8 = 1019.7(13);
			num4 = num7 + num8;
			num5 = Math.Min(1f, Math.Max(0f, (float)(2 * num7 - 20000) / 45536f) / 2f);
			num6 = Math.Min(1f, Math.Max(0f, (float)(2 * num8 - 20000) / 45536f) / 2f);
		}
		this.4();
		if (1226.10())
		{
			this.26.16(50, (1046)0, 0);
			this.27.16(50, (1046)0, 0);
		}
		else if (1226.69 && (1226.63() || (1226.67 % (int)1226.84() == 0 && 1226.67 > 0)) && 1662.76 == (932)2)
		{
			int num9 = Math.Max(300, (int)1226.76());
			if (!1226.63() || 1226.67 % 2 == 0)
			{
				this.26.3.RemoveAll((1445 1) => 1.14 == 1456.Fade);
				this.26.3.Add(new 1445(1456.Fade, this.26.16, num5, 1662.33, 1662.33 + 64, (1046)0));
				this.26.3.Add(new 1445(1456.Fade, num5, 0f, 1662.33 + 64, 1662.33 + num9, (1046)2));
			}
			if (!1226.63() || 1226.67 % 2 == 1)
			{
				this.27.3.RemoveAll(new Predicate<1445>(2470.2473.instance.3));
				this.27.3.Add(new 1445(1456.Fade, this.27.16, num6, 1662.33, 1662.33 + 64, (1046)0));
				this.27.3.Add(new 1445(1456.Fade, num6, 0f, 1662.33 + 64, 1662.33 + num9, (1046)2));
			}
		}
		if (1662.33 - this.13 >= 1000)
		{
			this.13 += 1000;
			this.28();
		}
		if (1662.23)
		{
			float num10 = 1226.63() ? 1f : (0.6f + Math.Min(1f, Math.Max(0f, (float)(num4 - 30000) / 35536f)) * 0.4f);
			this.49 = (float)num4 / 65536f * (float)1226.56 / 100f;
			this.50 = this.50 * 0.9f + 0.1f * this.49;
			this.39 = this.39 * 0.8f + 0.2f * num10;
			if (num10 > this.38)
			{
				this.38 = Math.Min(1f, this.38 + 0.05f);
			}
			else
			{
				this.38 = Math.Max(0f, this.38 - 0.0007f);
			}
			if (1662.123 == 2665.Updating)
			{
				this.43.SetText(1336.3(true));
			}
			else
			{
				this.43.SetText(null);
			}
		}
		int num11 = this.31;
		float num12 = 0f;
		int num13 = 0;
		this.31 = 0;
		if (this.44 < 0f && this.47 != null)
		{
			this.48.15 += (float)(0.0008 * 1662.10);
		}
		if (1226.10())
		{
			num12 = (float)(1662.33 % 1000);
			num13 = 1000;
			this.31 = 1662.33 / 1000;
		}
		else if (1272.5() != null && !1226.10() && 1226.75() && 1226.64() > 0.0)
		{
			num12 = (float)((int)(((double)1226.16 + 1662.10 * 16.666666666666668 - 1226.79()) % 1226.76()));
			this.31 = (int)(((double)1226.16 + 1662.10 * 16.666666666666668 - 1226.79()) / 1226.76());
			num13 = (int)1226.76();
		}
		if (num11 != this.31)
		{
			if (this.14.IsHovered() && 1662.11.2() && (1226.70 > 0 || this.31 >= 16))
			{
				1226.24("heartbeat", 1226.56, (1416)3, false);
			}
			this.9();
		}
		bool flag = 1226.63() && !1226.10();
		if (1226.69)
		{
			this.35 = this.39;
		}
		float num14 = 1f - (this.49 - this.50) / 0.5f;
		float num15 = (num13 > 0) ? (num12 / (float)num13) : 0.5f;
		num13 = 1;
		float num16 = (float)Math.Pow(0.5, 1662.10);
		num12 = (this.34 = this.34 * num16 + 1052.19(1f - (num15 * 0.5f + num14 * 0.5f), 0f, 1f) * (1f - num16));
		this.14.15 = 1052.8(num12, 1.05f + this.30, 1f + this.30, (float)num13);
		this.15.16 = 1052.8(num12, flag ? 0.1f : 0.4f, 0f, (float)num13) * this.35;
		this.15.15 = 1052.8(num12, 1.05f + this.30, 1.08f + this.30, (float)num13);
		this.15.28 = flag;
		this.20.10 = -this.17.29 + this.14.17 + new 208((float)(1662.70.1() / 2), (float)(1662.70.2() / 2));
		this.20.2(1052.9((float)num13 - num12, 1.05f + this.30, 1.08f + this.30, (float)num13) * 150f + (float)((this.44 < 0f) ? 8 : 0));
		if (this.44 < 100f)
		{
			this.20.11 = 0.2f * ((float)1662.33 / (float)2470.53);
		}
		else
		{
			this.20.11 = (1f - this.14.17.X / -120f * 0.7f) * (flag ? 1f : 0.7f);
		}
		this.20.Update();
		if (this.44 >= 0f)
		{
			this.21.Update();
		}
		base.Update();
	}

	// Token: 0x060029E9 RID: 10729 RVA: 0x000DC358 File Offset: 0x000DA558
	private void 10()
	{
		this.17(null);
	}

	// Token: 0x060029EA RID: 10730 RVA: 0x000DC364 File Offset: 0x000DA564
	private void 11(object 1, List<200> 2)
	{
		200 3 = 2[0];
		if (3 != (200)340)
		{
			if (3 == (200)341)
			{
				this.21(null, 200.P);
				return;
			}
		}
		else
		{
			this.21(null, 200.Escape);
		}
	}

	// Token: 0x060029EB RID: 10731 RVA: 0x000DC3A0 File Offset: 0x000DA5A0
	private 1433 12(string 1, 208 2, EventHandler 3, 2470.2475 4)
	{
		2470.2474 sounds = new 2470.2474();
		sounds.1 = 7;
		1433 5 = new 1433(1455.2("menu-button-" + sounds.1, (1416)1, null), (1376)10, 1065.TopLeft, (1044)0, 8, 0.8f - (float)4 / 10f, true, (4 == this.6) ? 198.White : 198.TransparentWhite, null);
		1433 6 = new 1433(1455.2("menu-button-" + sounds.1 + "-over", (1416)1, null), (1376)10, 1065.TopLeft, (1044)0, 8, 0.81f - (float)4 / 10f, true, 198.TransparentWhite, null);
		5.43 = new List<1445>
		{
			new 1445(5.17, 5.17 + new 208(20f, 0f), 0, 580, (1046)0)
			{
				15 = (1046)25
			}
		};
		5.44 = new List<1445>
		{
			new 1445(208.Zero, 5.17, 0, 400, (1046)1)
			{
				15 = (1046)7
			}
		};
		5.35(delegate(object 1, EventArgs 2)
		{
			1433 9 = 1 as 1433;
			if (this.6 == (2470.2475)9.9 && 9.8 != null)
			{
				1433 10 = (1433)9.8;
				10.3.Clear();
				10.3.AddRange(9.3);
				10.FadeIn(30, (1046)0, 0);
			}
		});
		5.37(new EventHandler(this.13));
		5.8 = 6;
		5.9 = (int)4;
		5.10 = true;
		5.3(3);
		5.3(delegate(object 1, EventArgs 2)
		{
			1433 9 = (1433)1;
			if (!9.GetTexture().2.Contains("-play") && !9.GetTexture().2.Contains("-back"))
			{
				1433 10 = 9.Clone();
				10.5 = false;
				10.28 = true;
				10.2 = this.14.2 - 0.001f;
				10.6 = new 198(0, 78, 165, byte.MaxValue);
				10.16 = 0.6f;
				if (10.3.Find(new Predicate<1445>(2470.2473.instance.2)) == null)
				{
					10.16(500, (1046)0, 0);
				}
				this.17.12(10);
			}
		});
		6.9 = -1;
		this.18.12(5);
		this.18.12(6);
		this.5[4].Add(5);
		this.5[4].Add(6);
		5.35(new EventHandler(sounds.7));
		5.3(delegate(object 1, EventArgs 2)
		{
			1226.27(new string[]
			{
				"menu-" + sounds.1 + "-click",
				sounds.1.Contains("back") ? "menuback" : "menuhit"
			});
		});
		return 5;
	}

	// Token: 0x060029EC RID: 10732 RVA: 0x000DC5A8 File Offset: 0x000DA7A8
	private void 13(object 1, EventArgs 2)
	{
		1433 3 = 1 as 1433;
		if (3.8 != null && 3.9 == (int)this.6)
		{
			1433 4 = (1433)3.8;
			4.3.Clear();
			4.3.AddRange(3.3);
			4.16(500, (1046)0, 0);
		}
	}

	// Token: 0x060029ED RID: 10733 RVA: 0x000DC605 File Offset: 0x000DA805
	private void 14(object 1, EventArgs 2)
	{
		this.30 -= 0.08f;
		if (!this.2(false))
		{
			if (this.6 == 2470.2475.Main)
			{
				this.57.1(true);
				return;
			}
			this.61.1(true);
		}
	}

	// Token: 0x060029EE RID: 10734 RVA: 0x000DC645 File Offset: 0x000DA845
	private void 15(object 1, EventArgs 2)
	{
		this.16(2470.2475.Main);
	}

	// Token: 0x060029EF RID: 10735 RVA: 0x000DC650 File Offset: 0x000DA850
	private void 16(2470.2475 1)
	{
		if (this.6 == 1)
		{
			return;
		}
		bool flag = 1 < this.6;
		this.6 = 1;
		foreach (KeyValuePair<2470.2475, List<1433>> keyValuePair in this.5)
		{
			if (this.6 == keyValuePair.Key)
			{
				using (List<1433>.Enumerator enumerator2 = keyValuePair.Value.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						1433 2 = enumerator2.Current;
						2.3.Clear();
						2.17 = 2.7;
						if (!2.GetTexture().2.Contains("-over"))
						{
							2.10 = true;
						}
						if (2.9 == (int)this.6)
						{
							2.FadeIn(80, (1046)0, 0);
							2.17 = 2.7 + new 208((float)(flag ? 15 : -30), 0f);
							2.19(2.7, 200, (1046)1);
						}
					}
					continue;
				}
			}
			foreach (1433 3 in keyValuePair.Value)
			{
				3.3.RemoveAll(new Predicate<1445>(2470.2473.instance.4));
				3.16(160, (1046)0, 0);
				3.10 = false;
			}
		}
	}

	// Token: 0x060029F0 RID: 10736 RVA: 0x000DC830 File Offset: 0x000DAA30
	private void 17(object 1)
	{
		foreach (KeyValuePair<2470.2475, List<1433>> keyValuePair in this.5)
		{
			foreach (1433 2 in keyValuePair.Value)
			{
				if (1 == null || (2 != 1 && 2 != ((1433)1).8))
				{
					2.3.Clear();
					2.22(new 208(-50f, 0f), 100, (1046)0);
					2.16(100, (1046)0, 0);
				}
			}
		}
	}

	// Token: 0x060029F1 RID: 10737 RVA: 0x000DC900 File Offset: 0x000DAB00
	private void 18(object 1, EventArgs 2)
	{
		if (!1345.1 && 1226.14() && !this.2(false))
		{
			2486.15(2147.Osu);
			1662.SetMode(1677.SelectEdit, false);
			this.17(1);
		}
	}

	// Token: 0x060029F2 RID: 10738 RVA: 0x000DC92D File Offset: 0x000DAB2D
	private void 19(object 1, EventArgs 2)
	{
		if (!this.2(false))
		{
			1662.104.49(false);
			1662.104.16(true);
		}
	}

	// Token: 0x060029F3 RID: 10739 RVA: 0x000DC94E File Offset: 0x000DAB4E
	private void 20(object 1, EventArgs 2)
	{
		if (!this.2(false) && !1662.128)
		{
			1662.27(false);
		}
	}

	// Token: 0x060029F4 RID: 10740 RVA: 0x000DC968 File Offset: 0x000DAB68
	private bool 21(object 1, 200 2)
	{
		if (this.6 == 2470.2475.Main)
		{
			if (2 != 200.Escape)
			{
				switch (2)
				{
				case 200.D:
					this.22(null, null);
					return true;
				case 200.E:
					this.58.1(true);
					return true;
				case 200.F:
					1304.89.4();
					return true;
				default:
					switch (2)
					{
					case 200.O:
						this.59.1(true);
						return true;
					case 200.P:
						this.14.1(true);
						return true;
					case 200.Q:
						break;
					default:
						return false;
					}
					break;
				}
			}
			1662.27(true);
			return true;
		}
		if (this.2(false))
		{
			return false;
		}
		if (2 == 200.Escape || 2 == 200.B)
		{
			this.62.1(true);
			return true;
		}
		if (2 == 200.P)
		{
			this.14.1(true);
			return true;
		}
		return false;
	}

	// Token: 0x060029F5 RID: 10741 RVA: 0x000DCA35 File Offset: 0x000DAC35
	private void 22(object 1, EventArgs 2)
	{
		if (261.FullyOffline)
		{
			return;
		}
		1226.27(new string[]
		{
			"menu-direct-click",
			"menuhit"
		});
		1662.SetMode(1677.OnlineSelection, false);
	}

	// Token: 0x060029F6 RID: 10742 RVA: 0x000DCA64 File Offset: 0x000DAC64
	private void 23()
	{
		1662.100.17(new 208(0f, 0f), false, 0);
		1662.100.36[0].2 = 0.8f;
		if (!1662.47)
		{
			this.19.14<1433>(1662.100.36);
		}
	}

	// Token: 0x060029F7 RID: 10743 RVA: 0x000DCAC3 File Offset: 0x000DACC3
	private void 24()
	{
		if (1662.123 == 2665.NeedsRestart)
		{
			this.31();
			return;
		}
		this.32();
	}

	// Token: 0x060029F8 RID: 10744 RVA: 0x000DCADA File Offset: 0x000DACDA
	private void 25()
	{
		this.26(false);
	}

	// Token: 0x060029F9 RID: 10745 RVA: 0x000DCAE4 File Offset: 0x000DACE4
	private void 26(bool 1)
	{
		if (!1662.47 && this.44 >= 0f)
		{
			int num = 1662.33;
			this.11.16(100, (1046)0, 0);
			this.12.16(100, (1046)0, 0);
			if (261.FullyOffline)
			{
				this.9.10 = false;
				this.9.16(0, (1046)0, 0);
				this.10.16(0, (1046)0, 0);
			}
			else
			{
				this.9.24(0.01f, 200, (1046)0);
				this.9.42 = new 1445(1456.Fade, 0.01f, 1f, 0, 140, (1046)0);
				this.10.FadeIn(200, (1046)0, 0);
			}
			this.8(false);
		}
	}

	// Token: 0x060029FA RID: 10746 RVA: 0x000DCBB4 File Offset: 0x000DADB4
	private static string 27()
	{
		if (1662.47)
		{
			return string.Empty;
		}
		if (!string.IsNullOrEmpty(1296.3))
		{
			return string.Concat(new string[]
			{
				"Welcome to osu!",
				1296.3,
				" (",
				1296.3(),
				")."
			});
		}
		if (!1304.196)
		{
			return string.Empty;
		}
		int num = 30;
		int num2 = 1304.153 % num;
		1304.153.7((num2 + 1) % num);
		return 1568.1(2679.MenuTip_1 + num2);
	}

	// Token: 0x060029FB RID: 10747 RVA: 0x000DCC4C File Offset: 0x000DAE4C
	private void 28()
	{
		string text;
		if (1304.189.GetValue().Length > 0)
		{
			int num = 1662.33;
			int num2 = num / 3600000;
			int num3 = num - num2 * 3600000;
			int num4 = num3 / 60000;
			int num5 = (num3 - num4 * 60000) / 1000;
			object arg = (num2 > 0) ? string.Format("{0:00}:{1:00}:{2:00}", num2, num4, num5) : ((num4 <= 0) ? string.Format(1568.1(2679.Menu_RunningSeconds), num5) : string.Format("{0:00}:{1:00}", num4, num5));
			text = string.Format(1568.1(2679.Menu_GeneralInformation), 1272.3.Count, arg, DateTime.Now.ToShortTimeString());
		}
		else
		{
			text = string.Format(1568.1(2679.Menu_GeneralInformation_Offline), 1272.3.Count);
		}
		this.7.SetText(text);
	}

	// Token: 0x060029FC RID: 10748 RVA: 0x000DCD4C File Offset: 0x000DAF4C
	private void 29()
	{
		this.46.3.RemoveAll(new Predicate<1445>(2470.2473.instance.5));
		this.46.3.Add(new 1445(1456.Rotation, this.46.14, this.46.14 + 3.1415927f, 1662.33, 1662.33 + 1500, (1046)1)
		{
			17 = true,
			11 = 2500
		});
		this.46.3.Add(new 1445(1456.Rotation, this.46.14 + 3.1415927f, this.46.14 + 6.2831855f, 1662.33 + 2500, 1662.33 + 4000, (1046)2)
		{
			17 = true,
			11 = 2500
		});
	}

	// Token: 0x060029FD RID: 10749 RVA: 0x000DCE30 File Offset: 0x000DB030
	private void 30()
	{
		this.46.3.RemoveAll(new Predicate<1445>(2470.2473.instance.6));
		this.46.3.Add(new 1445(1456.Rotation, this.46.14, this.46.14 + 6.2831855f, 1662.33, 1662.33 + 2000, (1046)0)
		{
			17 = true
		});
	}

	// Token: 0x060029FE RID: 10750 RVA: 0x000DCEA8 File Offset: 0x000DB0A8
	private void 31()
	{
		if (this.46 == null)
		{
			if (this.8 != null)
			{
				this.8.16(500, (1046)0, 0);
			}
			if (this.56 != null && this.56.GetText().Length > 60)
			{
				this.56.16(500, (1046)0, 0);
			}
			this.46 = new 1433(1455.2("menu-update", (1416)1, null), (1376)13, 1065.Centre, (1044)0, new 208(0f, 22f), 0.96f, true, 198.TransparentWhite, null);
			this.46.FadeIn(500, (1046)0, 0);
			this.45.Add(this.46);
			this.19.12(this.46);
			this.29();
			1445 <<EMPTY_NAME>> = new 1445(1456.Fade, 1f, 0f, 1662.33 + 1500, 1662.33 + 2000, (1046)0)
			{
				17 = true,
				11 = 4000
			};
			1445 2 = new 1445(1456.Fade, 0f, 1f, 1662.33 + 3500, 1662.33 + 4000, (1046)0)
			{
				17 = true,
				11 = 4000
			};
			1452 3 = new 1452(1568.1(2679.Update_ClickToUpdate1), 14f, new 208((float)(1662.70.1() / 2), (float)1662.70.2() - 22f), 0.97f, true, 198.White);
			this.33(3);
			3.15(500);
			3.3.Add(<<EMPTY_NAME>>.Clone());
			3.3.Add(2.Clone());
			this.19.12(3);
			this.45.Add(3);
			1452 4 = new 1452(1568.1(2679.Update_ClickToUpdate2), 14f, new 208((float)(1662.70.1() / 2), (float)1662.70.2() - 22f), 0.97f, true, 198.TransparentWhite);
			this.33(4);
			4.3.Add(<<EMPTY_NAME>>.2());
			4.3.Add(2.2());
			this.19.12(4);
			this.45.Add(4);
		}
	}

	// Token: 0x060029FF RID: 10751 RVA: 0x000DD100 File Offset: 0x000DB300
	private void 32()
	{
		this.45.ForEach(new Action<1433>(2470.2473.instance.7));
		this.45.Clear();
		if (this.8 != null)
		{
			this.8.FadeIn(500, (1046)0, 0);
		}
		this.46 = null;
	}

	// Token: 0x06002A00 RID: 10752 RVA: 0x000DD154 File Offset: 0x000DB354
	private void 33(1452 1)
	{
		1.35(new EventHandler(this.34));
		1.37(new EventHandler(this.35));
		1.10 = true;
		1.64(true);
		1.54(true);
		1.60(new 198(0, 0, 0, 100));
		1.49 = 1065.Centre;
		1.3(new EventHandler(2470.2473.instance.11));
	}

	// Token: 0x06002A01 RID: 10753 RVA: 0x000DD1C7 File Offset: 0x000DB3C7
	private void 34(object 1, EventArgs 2)
	{
		this.45.ForEach(new Action<1433>(2470.2473.instance.8));
		this.30();
	}

	// Token: 0x06002A02 RID: 10754 RVA: 0x000DD1EA File Offset: 0x000DB3EA
	private void 35(object 1, EventArgs 2)
	{
		if (this.45.Find(new Predicate<1433>(2470.2473.instance.9)) == null)
		{
			this.45.ForEach(new Action<1433>(2470.2473.instance.10));
			this.29();
		}
	}

	// Token: 0x04001E7C RID: 7804
	internal static bool 4 = true;

	// Token: 0x04001E7D RID: 7805
	private readonly Dictionary<2470.2475, List<1433>> 5 = new Dictionary<2470.2475, List<1433>>();

	// Token: 0x04001E7E RID: 7806
	private 2470.2475 6;

	// Token: 0x04001E7F RID: 7807
	private 1452 7;

	// Token: 0x04001E80 RID: 7808
	private 1505 8;

	// Token: 0x04001E81 RID: 7809
	private 1433 9;

	// Token: 0x04001E82 RID: 7810
	private 1433 10;

	// Token: 0x04001E83 RID: 7811
	private 1433 11;

	// Token: 0x04001E84 RID: 7812
	private 1433 12;

	// Token: 0x04001E85 RID: 7813
	private int 13;

	// Token: 0x04001E86 RID: 7814
	private 1433 14;

	// Token: 0x04001E87 RID: 7815
	private 1433 15;

	// Token: 0x04001E88 RID: 7816
	private 1436 16;

	// Token: 0x04001E89 RID: 7817
	private 1436 17;

	// Token: 0x04001E8A RID: 7818
	private 1436 18;

	// Token: 0x04001E8B RID: 7819
	private 1436 19;

	// Token: 0x04001E8C RID: 7820
	private 2479 20 = new 2479();

	// Token: 0x04001E8D RID: 7821
	private 2477 21 = new 2477();

	// Token: 0x04001E8E RID: 7822
	private string[] 22 = new string[]
	{
		"682286 Yuyoyuppe - Emerald Galaxy.osz",
		"682287 baker - For a Dead Girl+.osz",
		"682289 Hige Driver - I Wanna Feel Your Love (feat. shully).osz",
		"682290 Hige Driver - Miracle Sugite Yabai (feat. shully).osz",
		"682416 Hige Driver - Palette.osz",
		"682595 baker - Kimi ga Kimi ga -vocanico remix-.osz",
		"716211 yuki. - Spring Signal.osz",
		"716213 dark cat - BUBBLE TEA (feat. juu & cinders).osz",
		"716215 LukHash - CLONED.osz",
		"716219 IAHN - Snowdrop.osz",
		"716249 *namirin - Senaka Awase no Kuukyo (with Kakichoco).osz",
		"716390 sakuraburst - SHA.osz",
		"716441 Fractal Dreamers - Paradigm Shift.osz",
		"729808 Thaehan - Leprechaun.osz",
		"751771 Cranky - Hanaarashi.osz",
		"751772 Cranky - Ran.osz",
		"751773 Cranky - Feline, the White....osz",
		"751774 Function Phantom - Variable.osz",
		"751779 Rin - Daishibyo set 14 ~ Sado no Futatsuiwa.osz",
		"751782 Fractal Dreamers - Fata Morgana.osz",
		"751785 Cranky - Chandelier - King.osz",
		"751846 Fractal Dreamers - Celestial Horizon.osz",
		"751866 Rin - Moriya set 08 ReEdit ~ Youkai no Yama.osz",
		"751894 Fractal Dreamers - Blue Haven.osz",
		"751896 Cranky - Rave 2 Rave.osz",
		"751932 Cranky - La fuite des jours.osz",
		"751972 Cranky - CHASER.osz",
		"779173 Thaehan - Superpower.osz",
		"780932 VINXIS - A Centralized View.osz",
		"785572 S3RL - I'll See You Again (feat. Chi Chi).osz",
		"785650 yuki. feat. setsunan - Hello! World.osz",
		"785677 Dictate - Militant.osz",
		"785731 S3RL - Catchit (Radio Edit).osz",
		"785774 LukHash - GLITCH.osz",
		"786498 Trial & Error - Tokoyami no keiyaku KEGARETA-SHOUJO feat. GUMI.osz",
		"789374 Pulse - LP.osz",
		"789528 James Portland - Sky.osz",
		"789529 Lexurus - Gravity.osz",
		"789544 Andromedik - Invasion.osz",
		"789905 Gourski x Himmes - Silence.osz",
		"791667 cYsmix - Babaroque (Short Ver.).osz",
		"791798 cYsmix - Behind the Walls.osz",
		"791845 cYsmix - Little Knight.osz",
		"792241 cYsmix - Eden.osz",
		"792396 cYsmix - The Ballad of a Mindless Girl.osz",
		"795432 Phonetic - Journey.osz",
		"831322 DJ'TEKINA//SOMETHING - Hidamari no Uta.osz",
		"847764 Cranky - Crocus.osz",
		"847776 Culprate & Joe Ford - Gaucho.osz",
		"847812 J. Pachelbel - Canon (Cranky Remix).osz",
		"847900 Cranky - Time Alter.osz",
		"847930 LukHash - 8BIT FAIRY TALE.osz",
		"848003 Culprate - Aurora.osz",
		"848068 nanobii - popsicle beach.osz",
		"848090 Trial & Error - DAI*TAN SENSATION feat. Nanahira, Mii, Aitsuki Nakuru (Short Ver.).osz",
		"848259 Culprate & Skorpion - Jester.osz",
		"848976 Dictate - Treason.osz",
		"851543 Culprate - Florn.osz",
		"864748 Thaehan - Angry Birds Epic (Remix).osz",
		"873667 OISHII - ONIGIRI FREEWAY.osz",
		"876227 Culprate, Keota & Sophie Meiers - Mechanic Heartbeat.osz",
		"880487 cYsmix - Peer Gynt.osz",
		"883088 Wisp X - Somewhere I'd Rather Be.osz",
		"891333 HyuN - White Aura.osz",
		"891334 HyuN - Wild Card.osz",
		"891337 HyuN feat. LyuU - Cross Over.osz",
		"891338 HyuN & Ritoru - Apocalypse in Love.osz",
		"891339 HyuN feat. Ato - Asu wa Ame ga Yamukara.osz",
		"891345 HyuN - Infinity Heaven.osz",
		"891348 HyuN - Guitian.osz",
		"891356 HyuN - Legend of Genesis.osz",
		"891366 HyuN - Illusion of Inflict.osz",
		"891417 HyuN feat. Yu-A - My life is for you.osz",
		"891441 HyuN - You'Re aRleAdY dEAd.osz",
		"891632 HyuN feat. YURI - Disorder.osz",
		"891712 HyuN - Tokyo's Starlight.osz",
		"901091 *namirin - Ciel etoile.osz",
		"916990 *namirin - Koishiteiku Planet.osz",
		"929284 tieff - Sense of Nostalgia.osz",
		"933940 Ben Briggs - Yes (Maybe).osz",
		"934415 Ben Briggs - Fearless Living.osz",
		"934627 Ben Briggs - New Game Plus.osz",
		"934666 Ben Briggs - Wave Island.osz",
		"936126 siromaru + cranky - conflict.osz",
		"940377 onumi - ARROGANCE.osz",
		"940597 tieff - Take Your Swimsuit.osz",
		"941085 tieff - Our Story.osz",
		"949297 tieff - Sunflower.osz",
		"952380 Ben Briggs - Why Are We Yelling.osz",
		"954272 *namirin - Kanzen Shouri*Esper Girl.osz",
		"955866 KIRA & Heartbreaker - B.B.F (feat. Hatsune Miku & Kagamine Rin).osz",
		"961320 Kuba Oms - All In All.osz",
		"964553 The Flashbulb - You Take the World's Weight Away.osz",
		"965651 Fractal Dreamers - Ad Astra.osz",
		"966225 The Flashbulb - Passage D.osz",
		"966324 DJ'TEKINA//SOMETHING - Hidamari no Uta.osz",
		"972810 James Landino & Kabuki - Birdsong.osz",
		"972932 James Landino - Hide And Seek.osz",
		"977276 The Flashbulb - Mellann.osz",
		"981616 *namirin - Mizutamari Tobikoete (with Nanahira).osz",
		"985788 Loki - Wizard's Tower.osz",
		"996628 OISHII - ONIGIRI FREEWAY.osz",
		"996898 HyuN - White Aura.osz",
		"1003554 yuki. - Nadeshiko Sensation.osz",
		"1014936 Thaehan - Bwa !.osz",
		"1019827 UNDEAD CORPORATION - Sad Dream.osz",
		"1020213 Creo - Idolize.osz",
		"1021450 Thaehan - Chiptune & Baroque.osz",
		"1388993 Kuba Oms - My Love (Redside Remix) (feat. Hatsune Miku).osz"
	};

	// Token: 0x04001E8F RID: 7823
	private string[] 23 = new string[]
	{
		"707824 Fractal Dreamers - Fortuna Redux.osz",
		"789553 Cranky - Ran.osz",
		"827822 Function Phantom - Neuronecia.osz",
		"847323 Nakanojojo - Bittersweet (feat. Kuishinboakachan a.k.a Kiato).osz",
		"847433 Trial & Error - Tokoyami no keiyaku KEGARETA-SHOUJO feat. GUMI.osz",
		"847576 dark cat - hot chocolate.osz",
		"847957 Wisp X - Final Moments.osz",
		"876282 VINXIS - Greetings.osz",
		"876648 Thaehan - Angry Birds Epic (Remix).osz",
		"877069 IAHN - Transform (Original Mix).osz",
		"877496 Thaehan - Leprechaun.osz",
		"877935 Thaehan - Overpowered.osz",
		"878344 yuki. - Be Your Light.osz",
		"918446 VINXIS - Facade.osz",
		"918903 LukHash - Ghosts.osz",
		"919251 *namirin - Hitokoto no Kyori.osz",
		"919704 S3RL - I Will Pick You Up (feat. Tamika).osz",
		"921535 SOOOO - Raven Haven.osz",
		"927206 *namirin - Kanzen Shouri*Esper Girl.osz",
		"927544 Camellia feat. Nanahira - Kansoku Eisei.osz",
		"930806 Nakanojojo - Pararara (feat. Amekoya).osz",
		"931741 Camellia - Quaoar.osz",
		"935699 Rin - Mythic set ~ Heart-Stirring Urban Legends.osz",
		"935732 Thaehan - Yuujou.osz",
		"941145 Function Phantom - Euclid.osz",
		"942334 Dictate - Cauldron.osz",
		"946540 nanobii - astral blast.osz",
		"948844 Rin - Kishinjou set 01 ~ Mist Lake.osz",
		"949122 Wisp X - Petal.osz",
		"951618 Rin - Kishinjou set 02 ~ Mermaid from the Uncharted Land.osz",
		"957412 Rin - Lunatic set 16 ~ The Space Shrine Maiden Returns Home.osz",
		"961335 Thaehan - Insert Coin.osz",
		"965178 The Flashbulb - DIDJ PVC.osz",
		"966087 The Flashbulb - Creep.osz",
		"966277 The Flashbulb - Amen Iraq.osz",
		"966407 LukHash - ROOM 12.osz",
		"966451 The Flashbulb - Six Acid Strings.osz",
		"972301 BilliumMoto - four veiled stars.osz",
		"973173 nanobii - popsicle beach.osz",
		"973954 BilliumMoto - Rocky Buinne (Short Ver.).osz",
		"975435 BilliumMoto - life flashes before weeb eyes.osz",
		"978759 L. V. Beethoven - Moonlight Sonata (Cranky Remix).osz",
		"982559 BilliumMoto - HDHR.osz",
		"984361 The Flashbulb - Ninedump.osz",
		"1023681 Inferi - The Ruin of Mankind.osz",
		"1034358 ALEPH - The Evil Spirit.osz",
		"1037567 ALEPH - Scintillations.osz"
	};

	// Token: 0x04001E90 RID: 7824
	private string[] 24 = new string[]
	{
		"554256 Helblinde - When Time Sleeps.osz",
		"693123 yuki. - Nadeshiko Sensation.osz",
		"767009 OISHII - PIZZA PLAZA.osz",
		"767346 Thaehan - Bwa !.osz",
		"815162 VINXIS - Greetings.osz",
		"840964 cYsmix - Breeze.osz",
		"932657 Wisp X - Eventide.osz",
		"933700 onumi - CONFUSION PART ONE.osz",
		"933984 onumi - PERSONALITY.osz",
		"934785 onumi - FAKE.osz",
		"936545 onumi - REGRET PART ONE.osz",
		"943803 Fractal Dreamers - Everything for a Dream.osz",
		"943876 S3RL - I Will Pick You Up (feat. Tamika).osz",
		"955808 Trial & Error - Tokoyami no keiyaku KEGARETA-SHOUJO feat. GUMI (Short Ver.).osz",
		"957808 Fractal Dreamers - Module_410.osz",
		"957842 antiPLUR - One Life Left to Live.osz",
		"966240 Creo - Challenger.osz",
		"972302 VINXIS - A Centralized View.osz",
		"972887 HyuN - Illusion of Inflict.osz",
		"1008600 LukHash - WHEN AN ANGEL DIES.osz",
		"1032103 LukHash - H8 U.osz"
	};

	// Token: 0x04001E91 RID: 7825
	private string[] 25 = new string[]
	{
		"943516 antiPLUR - Clockwork Spooks.osz",
		"946394 VINXIS - Three Times The Original Charm.osz",
		"966408 antiPLUR - One Life Left to Live.osz",
		"971561 antiPLUR - Runengon.osz",
		"983864 James Landino - Shiba Island.osz",
		"989512 BilliumMoto - 1xMISS.osz",
		"994104 James Landino - Reaction feat. Slyleaf.osz",
		"1003217 nekodex - circles!.osz",
		"1009907 James Landino & Kabuki - Birdsong.osz",
		"1015169 Thaehan - Insert Coin.osz"
	};

	// Token: 0x04001E92 RID: 7826
	private 1433 26;

	// Token: 0x04001E93 RID: 7827
	private 1433 27;

	// Token: 0x04001E94 RID: 7828
	private static 1627 28;

	// Token: 0x04001E95 RID: 7829
	private List<1433> 29 = new List<1433>();

	// Token: 0x04001E96 RID: 7830
	private float 30;

	// Token: 0x04001E97 RID: 7831
	private int 31;

	// Token: 0x04001E98 RID: 7832
	private bool 32;

	// Token: 0x04001E99 RID: 7833
	private int 33;

	// Token: 0x04001E9A RID: 7834
	private float 34;

	// Token: 0x04001E9B RID: 7835
	private float 35;

	// Token: 0x04001E9C RID: 7836
	internal static bool 36;

	// Token: 0x04001E9D RID: 7837
	private int 37;

	// Token: 0x04001E9E RID: 7838
	private float 38 = 0.5f;

	// Token: 0x04001E9F RID: 7839
	private float 39 = 0.5f;

	// Token: 0x04001EA0 RID: 7840
	private 1381 40;

	// Token: 0x04001EA1 RID: 7841
	private static long 41;

	// Token: 0x04001EA2 RID: 7842
	private 1452 42;

	// Token: 0x04001EA3 RID: 7843
	private 1452 43;

	// Token: 0x04001EA4 RID: 7844
	private float 44 = (float)(2470.4 ? -1 : 101);

	// Token: 0x04001EA5 RID: 7845
	private List<1433> 45 = new List<1433>();

	// Token: 0x04001EA6 RID: 7846
	private 1433 46;

	// Token: 0x04001EA7 RID: 7847
	private 1433 47;

	// Token: 0x04001EA8 RID: 7848
	private 1433 48;

	// Token: 0x04001EA9 RID: 7849
	private float 49;

	// Token: 0x04001EAA RID: 7850
	private float 50;

	// Token: 0x04001EAB RID: 7851
	private 1240 51;

	// Token: 0x04001EAC RID: 7852
	private 1262 52;

	// Token: 0x04001EAD RID: 7853
	public static int 53 = 2558;

	// Token: 0x04001EAE RID: 7854
	private 1433 54;

	// Token: 0x04001EAF RID: 7855
	private 1433 55;

	// Token: 0x04001EB0 RID: 7856
	private 1452 56;

	// Token: 0x04001EB1 RID: 7857
	private 1433 57;

	// Token: 0x04001EB2 RID: 7858
	private 1433 58;

	// Token: 0x04001EB3 RID: 7859
	private 1433 59;

	// Token: 0x04001EB4 RID: 7860
	private 1433 60;

	// Token: 0x04001EB5 RID: 7861
	private 1433 61;

	// Token: 0x04001EB6 RID: 7862
	private 1433 62;

	// Token: 0x04001EB7 RID: 7863
	private static 1187 63;

	// Token: 0x04001EB8 RID: 7864
	private static 1187 64;

	// Token: 0x02000554 RID: 1364
	public sealed class 2476
	{
		// Token: 0x06002A06 RID: 10758 RVA: 0x000DD26C File Offset: 0x000DB46C
		internal void 1()
		{
			this.1.48.16(this.2, (1046)0, 0);
			this.1.47.16(this.2 * 2, (1046)0, 0);
			this.1.44 = 0f;
			1226.1 = true;
			1247.3(true);
			this.1.24();
			1662.125 = (1189)Delegate.Combine(1662.125, new 1189(this.1.24));
			this.1.23();
			1662.100.24();
			this.1.54.24(0.4f, 500, (1046)0);
			this.1.55.24(0.4f, 500, (1046)0);
			this.1.25();
			if (1459.7 != null)
			{
				1459.7.24(1f, 100, (1046)0);
			}
			if (1662.11.2() && 1555.1())
			{
				1535.35(new 208((float)(1662.70.1 / 2), (float)(1662.70.2 / 2 + (int)(60f * 1662.70.3()))));
			}
			1535.32 = true;
			1662.89.2(new 1189(this.2), 800, false);
		}

		// Token: 0x06002A07 RID: 10759 RVA: 0x000DD3D2 File Offset: 0x000DB5D2
		internal void 2()
		{
			if (1662.78 == 1677.Menu)
			{
				this.1.28();
			}
		}

		// Token: 0x04001EB9 RID: 7865
		public 2470 1;

		// Token: 0x04001EBA RID: 7866
		public int 2;
	}

	// Token: 0x02000555 RID: 1365
	public sealed class 2472
	{
		// Token: 0x06002A09 RID: 10761 RVA: 0x000DD3E8 File Offset: 0x000DB5E8
		internal void 1(1433 1)
		{
			1.16((!this.1) ? 500 : 0, (1046)0, 0);
			1.10 = false;
			1.19(1.7 - new 208(100f, 0f), 2000, (1046)1);
		}

		// Token: 0x06002A0A RID: 10762 RVA: 0x000DD43B File Offset: 0x000DB63B
		internal void 2(1433 1)
		{
			1.FadeIn((!this.1) ? 500 : 0, (1046)0, 0);
		}

		// Token: 0x04001EBB RID: 7867
		public bool 1;

		// Token: 0x04001EBC RID: 7868
		public 2470 2;
	}

	// Token: 0x02000556 RID: 1366
	public sealed class 2471
	{
		// Token: 0x06002A0C RID: 10764 RVA: 0x000DD455 File Offset: 0x000DB655
		internal double 1(string 1)
		{
			return this.1.3();
		}

		// Token: 0x04001EBD RID: 7869
		public 1193 1;
	}

	// Token: 0x02000557 RID: 1367
	[Serializable]
	public sealed class 2473
	{
		// Token: 0x06002A0E RID: 10766 RVA: 0x000DD462 File Offset: 0x000DB662
		internal void 1()
		{
			if (1304.200)
			{
				1226.24("welcome", 100, (!1308.1) ? ((1416)1) : ((1416)3), false);
			}
		}

		// Token: 0x06002A0F RID: 10767 RVA: 0x000CAAF9 File Offset: 0x000C8CF9
		internal bool 2(1445 1)
		{
			return 1.14 == 1456.Fade;
		}

		// Token: 0x06002A10 RID: 10768 RVA: 0x000CAAF9 File Offset: 0x000C8CF9
		internal bool 3(1445 1)
		{
			return 1.14 == 1456.Fade;
		}

		// Token: 0x06002A11 RID: 10769 RVA: 0x000BA3D9 File Offset: 0x000B85D9
		internal bool 4(1445 1)
		{
			return 1.14 == 1456.Movement;
		}

		// Token: 0x06002A12 RID: 10770 RVA: 0x000DD489 File Offset: 0x000DB689
		internal bool 5(1445 1)
		{
			return 1.14 == 1456.Rotation;
		}

		// Token: 0x06002A13 RID: 10771 RVA: 0x000DD489 File Offset: 0x000DB689
		internal bool 6(1445 1)
		{
			return 1.14 == 1456.Rotation;
		}

		// Token: 0x06002A14 RID: 10772 RVA: 0x000DD494 File Offset: 0x000DB694
		internal void 7(1433 1)
		{
			1.16(100, (1046)0, 0);
			1.5 = false;
		}

		// Token: 0x06002A15 RID: 10773 RVA: 0x000DD4A7 File Offset: 0x000DB6A7
		internal void 8(1433 1)
		{
			1.39(198.YellowGreen, 100, false, (1046)0);
			1.25(1.1f, 500, (1046)1);
		}

		// Token: 0x06002A16 RID: 10774 RVA: 0x000DD4CB File Offset: 0x000DB6CB
		internal bool 9(1433 1)
		{
			return 1.IsHovered();
		}

		// Token: 0x06002A17 RID: 10775 RVA: 0x000DD4D3 File Offset: 0x000DB6D3
		internal void 10(1433 1)
		{
			1.39(198.White, 100, false, (1046)0);
			1.25(1f, 500, (1046)1);
		}

		// Token: 0x06002A18 RID: 10776 RVA: 0x000DD4F7 File Offset: 0x000DB6F7
		internal void 11(object 1, EventArgs 2)
		{
			1662.97(true);
		}

		// Token: 0x04001EBE RID: 7870
		public static readonly 2470.2473 instance = new 2470.2473();

		// Token: 0x04001EBF RID: 7871
		public static 1189 voidDelegate;

		// Token: 0x04001EC0 RID: 7872
		public static 1189 voidDelegate2;

		// Token: 0x04001EC1 RID: 7873
		public static EventHandler eventHandler;

		// Token: 0x04001EC2 RID: 7874
		public static 1189 voidDelegate3;

		// Token: 0x04001EC3 RID: 7875
		public static Func<1626, bool> cachedIsCurrentMenuImage;

		// Token: 0x04001EC4 RID: 7876
		public static 1189 voidDelegate4;

		// Token: 0x04001EC5 RID: 7877
		public static Predicate<1445> predicate;

		// Token: 0x04001EC6 RID: 7878
		public static Predicate<1445> predicate2;

		// Token: 0x04001EC7 RID: 7879
		public static Predicate<1445> predicate3;

		// Token: 0x04001EC8 RID: 7880
		public static Predicate<1445> predicate4;

		// Token: 0x04001EC9 RID: 7881
		public static Predicate<1445> predicate5;

		// Token: 0x04001ECA RID: 7882
		public static Predicate<1445> predicate6;

		// Token: 0x04001ECB RID: 7883
		public static Action<1433> action;

		// Token: 0x04001ECC RID: 7884
		public static Action<1433> action2;

		// Token: 0x04001ECD RID: 7885
		public static Predicate<1433> predicate7;

		// Token: 0x04001ECE RID: 7886
		public static Action<1433> action3;

		// Token: 0x04001ECF RID: 7887
		public static EventHandler eventHandler2;
	}

	// Token: 0x02000558 RID: 1368
	public enum 2475
	{
		// Token: 0x04001ED1 RID: 7889
		Main,
		// Token: 0x04001ED2 RID: 7890
		Play
	}

	// Token: 0x02000559 RID: 1369
	public sealed class 2474
	{
		// Token: 0x06002A1B RID: 10779 RVA: 0x000DD50B File Offset: 0x000DB70B
		internal void 1(object 1, EventArgs 2)
		{
			if (1662.11.2())
			{
				1226.27(new string[]
				{
					"menu-" + this.1 + "-hover",
					"menuclick"
				});
			}
		}

		// Token: 0x04001ED3 RID: 7891
		public string 1;
	}
}
