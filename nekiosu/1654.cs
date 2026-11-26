using System;
using System.Collections.Generic;
using System.IO;

// Token: 0x0200097D RID: 2429
public sealed class 1654 : IDisposable, IComparable<1654>, ICloneable
{
	// Token: 0x0600442B RID: 17451 RVA: 0x001AD8D4 File Offset: 0x001ABAD4
	internal 1654()
	{
	}

	// Token: 0x0600442C RID: 17452 RVA: 0x001AD94C File Offset: 0x001ABB4C
	internal 1654(int 1, string 2 = null)
	{
		this.16 = false;
		this.12 = 1;
		this.3(2 ?? 1654.47);
	}

	// Token: 0x0600442D RID: 17453 RVA: 0x001AD9E1 File Offset: 0x001ABBE1
	internal 1654(string 1) : this(-1, 1)
	{
	}

	// Token: 0x0600442E RID: 17454 RVA: 0x001AD9EB File Offset: 0x001ABBEB
	internal 1654(1658 1) : this(1, null)
	{
	}

	// Token: 0x0600442F RID: 17455 RVA: 0x001AD9F8 File Offset: 0x001ABBF8
	internal 1654(1658 1, 1659 2)
	{
		this.16 = 1.10;
		this.10 = true;
		this.12(1);
		if (2 != null)
		{
			this.13(2);
		}
	}

	// Token: 0x06004430 RID: 17456 RVA: 0x001ADA93 File Offset: 0x001ABC93
	internal static string 1()
	{
		return Path.Combine(1345.4(), "Data", "a");
	}

	// Token: 0x06004431 RID: 17457 RVA: 0x001ADAA9 File Offset: 0x001ABCA9
	public string 2()
	{
		return this.21;
	}

	// Token: 0x06004432 RID: 17458 RVA: 0x001ADAB1 File Offset: 0x001ABCB1
	public void 3(string 1)
	{
		this.21 = 1;
		this.14 = 1.Replace(' ', '_');
	}

	// Token: 0x06004433 RID: 17459 RVA: 0x001ADACA File Offset: 0x001ABCCA
	internal double 4()
	{
		if (this.38 && this.27 > 0)
		{
			return Math.Pow((double)this.27, 0.4) * 0.195;
		}
		return 0.0;
	}

	// Token: 0x06004434 RID: 17460 RVA: 0x001ADB08 File Offset: 0x001ABD08
	private void 5()
	{
		208 <<EMPTY_NAME>> = this.52;
		208 2 = new 208(23f, 23f);
		float num = (this.30 != null) ? (this.30.2 + 1E-06f) : 0f;
		if (this.29 != null)
		{
			this.29.7 = <<EMPTY_NAME>> + 2;
			if (this.29.GetTexture() == null)
			{
				this.29.56(new 1189(this.27));
			}
			this.29.15 = 74f / (float)Math.Max(this.29.39, this.29.38);
		}
		else
		{
			this.29 = this.6(<<EMPTY_NAME>> + 2, num, 74f);
			if (this.36 != null)
			{
				this.36.Add(this.29);
			}
		}
		this.29.17 = this.52 + 2;
		this.29.49 = 1065.Centre;
	}

	// Token: 0x06004435 RID: 17461 RVA: 0x001ADC10 File Offset: 0x001ABE10
	internal 1505 6(208 1, float 2, float 3)
	{
		1654.1655 createAvatarClosure = new 1654.1655();
		createAvatarClosure.2 = 3;
		bool flag = this.12 == 1662.100.12;
		string text = this.8();
		createAvatarClosure.1 = ((text != null) ? new 1505("nekiosu-profile-picture", text, 0, 1, 2) : new 1505((this.12 < 0) ? null : string.Format((this.12 == 1662.100.12) ? 1661.18() : 1661.17(), this.12), Path.Combine(1654.1(), this.12.ToString()), (!flag) ? 500 : 0, 1, 2));
		createAvatarClosure.1.56(delegate
		{
			createAvatarClosure.1.15 = createAvatarClosure.2 / (float)Math.Max(createAvatarClosure.1.39, createAvatarClosure.1.38);
		});
		return createAvatarClosure.1;
	}

	// Token: 0x06004436 RID: 17462 RVA: 0x001ADCFC File Offset: 0x001ABEFC
	public bool 7(1505 1, float 2)
	{
		1.49 = 1065.Centre;
		string text = this.8();
		if (text != null)
		{
			1.55(text);
			1.53("nekiosu-profile-picture");
		}
		else
		{
			1.53((this.12 <= 0) ? null : string.Format((this.12 == 1662.100.12) ? 1661.18() : 1661.17(), this.12));
			1.55(Path.Combine(1654.1(), this.12.ToString()));
		}
		1.77 = 2;
		return 1.71 == (1484)0;
	}

	// Token: 0x06004437 RID: 17463 RVA: 0x001ADD9C File Offset: 0x001ABF9C
	private string 8()
	{
		if (this != 1662.100)
		{
			return null;
		}
		string value = 1304.189.GetValue();
		if (!2226.2(value))
		{
			return null;
		}
		return 2226.1(value);
	}

	// Token: 0x06004438 RID: 17464 RVA: 0x001ADDCE File Offset: 0x001ABFCE
	internal void 9()
	{
		if (this.29 != null)
		{
			this.29.53(null);
			this.7(this.29, this.29.77);
		}
	}

	// Token: 0x06004439 RID: 17465 RVA: 0x001ADDFC File Offset: 0x001ABFFC
	public int CompareTo(1654 1)
	{
		int num = this.2().CompareTo(1.2());
		if (num != 0)
		{
			return num;
		}
		return this.12.CompareTo(1.12);
	}

	// Token: 0x0600443A RID: 17466 RVA: 0x001ADE31 File Offset: 0x001AC031
	public void Dispose()
	{
		this.10(false);
		GC.SuppressFinalize(this);
	}

	// Token: 0x0600443B RID: 17467 RVA: 0x001ADE40 File Offset: 0x001AC040
	~1654()
	{
		this.10(true);
	}

	// Token: 0x0600443C RID: 17468 RVA: 0x001ADE70 File Offset: 0x001AC070
	internal void 10(bool 1)
	{
		if (this.34 != null)
		{
			this.34.Dispose();
		}
		if (this.32 != null)
		{
			this.32.Dispose();
		}
		if (this.37 != null)
		{
			this.37.Dispose();
		}
		if (this.35 != null)
		{
			this.35.Dispose();
		}
	}

	// Token: 0x0600443D RID: 17469 RVA: 0x001ADECC File Offset: 0x001AC0CC
	internal bool 11(bool 1)
	{
		if (this.38 && !1)
		{
			return true;
		}
		if (this.39)
		{
			return false;
		}
		string text = 1304.189.GetValue() ?? string.Empty;
		if (this != 1662.100 && this.2().Length != 0 && !(this.2() == "Guest") && !(this.2() == text))
		{
			if (this.2().Length > 0)
			{
				this.39 = true;
				if (this.36 != null)
				{
					this.30.40(198.Crimson, 3000);
					this.34.SetText(this.2());
					if (this.11)
					{
						this.32.SetText(string.Empty);
					}
				}
			}
			else
			{
				this.3("Guest");
				this.17 = 0f;
				this.12 = -1;
				this.22 = (1657)1;
				this.13 = 1568.1(2679.Options_Online_ClickToLogin);
				this.34.SetText(this.2());
				this.32.SetText(this.13);
				this.35.SetText(string.Empty);
				this.46.SetTexture(null);
				this.7(this.29, this.29.77);
				this.15();
			}
			return true;
		}
		this.3((text.Length > 0) ? text : "Guest");
		1659 currentStats = 2210.CurrentStats;
		if (currentStats != null)
		{
			this.12 = -1;
			this.22 = (1657)1;
			if (this.36 != null)
			{
				this.34.SetText(this.2());
			}
			this.13(currentStats);
			return true;
		}
		this.17 = 0f;
		this.12 = -1;
		this.22 = (1657)1;
		this.13 = ((text.Length > 0) ? "Click to change your username" : "Click to set your username");
		if (this.36 != null)
		{
			this.34.SetText(this.2());
			this.32.SetText(this.13);
			this.35.SetText(string.Empty);
			this.46.SetTexture(null);
			this.7(this.29, this.29.77);
			this.15();
		}
		return true;
	}

	// Token: 0x0600443E RID: 17470 RVA: 0x001AE11C File Offset: 0x001AC31C
	internal void 12(1658 1)
	{
		this.12 = 1.5;
		this.3(1.6);
		this.42 = 1.4;
		if (!this.16 || 1.10)
		{
			this.16 = 1.10;
		}
		this.51 = (int)1.1;
		this.20 = 1654.2[(int)1.1];
		this.49 = 1.7;
		this.50 = 1.8;
		this.22 = 1.2;
		this.25 = 1.9;
		if (!this.38)
		{
			this.24 = 1.11;
		}
		if (this.29 != null)
		{
			this.7(this.29, this.29.77);
		}
		this.14();
		this.21();
		if (!this.48)
		{
			this.48 = true;
		}
	}

	// Token: 0x0600443F RID: 17471 RVA: 0x001AE208 File Offset: 0x001AC408
	internal void 13(1659 1)
	{
		this.38 = true;
		long num = this.26;
		double num2 = this.3;
		int num3 = this.25;
		long num4 = 1.7;
		float num5 = 0f;
		while (num4 > 0L)
		{
			long num6 = 1654.1[Math.Min(1654.1.Length - 1, (int)Math.Round((double)num5))];
			num5 += Math.Min(1f, (float)num4 / (float)num6);
			num4 -= num6;
		}
		this.17 = num5 + 1f;
		this.26 = 1.5;
		this.3 = Math.Round((double)(1.1 * 100f), 2);
		this.23 = 1.3;
		this.27 = (int)1.9;
		if (this.27 < 0)
		{
			this.27 = (int)((ushort)1.9);
		}
		this.25 = 1.4;
		bool flag = this.24 != 1.6.4;
		this.24 = 1.6.4;
		if (this.36 != null && !this.11 && (!this.10 || this.30.19) && !flag)
		{
			if (this.26 != num)
			{
				1452 2 = new 1452(((num < this.26) ? "+" : string.Empty) + (this.26 - num).ToString("0,0", 1662.18), 10f, this.32.17 + new 208(this.32.GetTextSize().X, 0f) / 2f, 208.Zero, 0.98f, false, 198.YellowGreen, true);
				2.68(true);
				2.8 = this;
				2.19(this.32.17 + new 208(this.32.GetTextSize().X + 2f, 0f), 1000, (1046)1);
				2.16(6000, (1046)0, 0);
				this.33.12(2);
				this.45 = 2;
			}
			if (this.3 != num2)
			{
				bool flag2 = num2 < this.3;
				1452 3 = new 1452("\n" + (flag2 ? "+" : string.Empty) + string.Format("{0:n}%", Math.Round(this.3 - num2, 2)), 10f, this.32.17 + new 208(this.32.GetTextSize().X, 0f) / 2f, 208.Zero, 0.98f, false, flag2 ? 198.YellowGreen : 198.OrangeRed, true);
				3.68(true);
				3.19(this.32.17 + new 208(this.32.GetTextSize().X + 2f, 0f), 1000, (1046)1);
				3.8 = this;
				3.16(6000, (1046)0, 0);
				this.33.12(3);
				this.45 = 3;
			}
			if (this.25 != num3 && this.25 > 0 && num3 > 0)
			{
				1452 4 = new 1452(((num3 > this.25) ? "+" : string.Empty) + (-this.25 + num3).ToString(), 30f, this.35.17, 208.Zero, 0.976f, true, 198.White, false);
				4.68(true);
				4.49 = 1065.TopRight;
				4.22(new 208(0f, -19f), 1000, (1046)1);
				4.8 = this;
				4.16(4000, (1046)0, 0);
				this.33.12(4);
				this.45 = 4;
			}
		}
		this.6 = 1.6.6;
		this.5 = 1.6.2;
		this.8 = 1.6.1;
		this.9 = 1.6.3;
		this.40 = 1.6.5;
		if (this.46 != null && (this.46.GetTexture() == null || flag))
		{
			this.46.SetTexture(this.18());
		}
		switch (1.6.5)
		{
		case 1653.Afk:
			this.4 = new 198(10, 10, 10);
			goto IL_5DA;
		case 1653.Playing:
		case 1653.Paused:
			this.4 = new 198(140, 160, 160);
			goto IL_5DA;
		case 1653.Editing:
			this.4 = new 198(160, 60, 60);
			goto IL_5DA;
		case 1653.Modding:
			this.4 = new 198(60, 160, 60);
			goto IL_5DA;
		case 1653.Multiplayer:
		case 1653.Lobby:
			this.4 = new 198(164, 108, 28);
			goto IL_5DA;
		case 1653.Watching:
			this.4 = new 198(60, 60, 160);
			goto IL_5DA;
		case 1653.Testing:
			this.4 = new 198(160, 60, 160);
			goto IL_5DA;
		case 1653.Submitting:
			this.4 = new 198(139, 238, 180);
			goto IL_5DA;
		case 1653.Multiplaying:
			this.4 = new 198(221, 190, 0);
			goto IL_5DA;
		}
		this.4 = new 198(10, 29, 75);
		IL_5DA:
		if (!this.10)
		{
			this.4 = new 198(1, 1, 1);
		}
		string a = string.Format("{1:HH:mm} @ {3}\n{0} {4}", new object[]
		{
			this.40,
			DateTime.UtcNow.AddHours((double)this.42),
			((this.42 >= 0) ? "+" : string.Empty) + this.42.ToString(),
			this.20,
			this.6
		});
		bool flag3 = a != this.41;
		this.41 = a;
		if (flag3)
		{
			this.16();
		}
		this.11 = false;
		this.21();
		this.14();
		this.39 = false;
	}

	// Token: 0x06004440 RID: 17472 RVA: 0x001AE8B4 File Offset: 0x001ACAB4
	private void 14()
	{
		if (!this.38)
		{
			this.13 = string.Empty;
		}
		else
		{
			if (this.27 > 0)
			{
				this.13 = string.Format(1662.18, "Performance:{0}pp\nAccuracy:{1:0.00}%\n" + (this.10 ? "Play Count: {2} (Lv{3:0})" : "Lv{3}"), new object[]
				{
					this.27.ToString("#,0", 1662.18),
					this.3,
					this.23,
					(int)this.17,
					this.27
				});
			}
			else if (this.26 > 0L)
			{
				float num = (float)this.26;
				string str = string.Empty;
				if (num > 1E+09f)
				{
					str = "b";
					num /= 1E+09f;
				}
				else if (num > 1000000f)
				{
					str = "m";
					num /= 1000000f;
				}
				else if (num > 0f)
				{
					str = "k";
					num /= 1000f;
				}
				string text = ((num % 1f != 0f) ? num.ToString("#,0.0", 1662.18) : num.ToString("#,0", 1662.18)) + str;
				this.13 = string.Format(1662.18, "Score:{0}\nAccuracy:{1:0.00}%\n" + (this.10 ? "Play Count: {2} (Lv{3:0})" : "Lv{3}"), new object[]
				{
					text,
					this.3,
					this.23,
					(int)this.17
				});
			}
			else
			{
				this.13 = 1568.1(2679.User_Neverplayed);
			}
			this.28 = ((this.25 == 0) ? string.Empty : ("#" + this.25.ToString()));
		}
		if (this.36 != null)
		{
			this.32.SetText(this.13);
			this.34.SetText(this.2());
			if (this.37 != null)
			{
				this.37.SetText(this.41);
			}
			this.15();
			this.35.SetText(this.28);
		}
	}

	// Token: 0x06004441 RID: 17473 RVA: 0x001AEB02 File Offset: 0x001ACD02
	private void 15()
	{
		if (this.19 != null)
		{
			this.19.35 = (int)(198f * (this.17 - (float)((int)this.17)));
		}
	}

	// Token: 0x06004442 RID: 17474 RVA: 0x001AEB30 File Offset: 0x001ACD30
	private void 16()
	{
		if (this.43 && this.37 != null)
		{
			this.32.16(100, (1046)0, 0);
			this.37.FadeIn(100, (1046)0, 0);
			this.37.3.Add(new 1445(1456.Fade, 1f, 0f, 1662.33 + 4000, 1662.33 + 5000, (1046)0));
			this.32.3.Add(new 1445(1456.Fade, 0f, 1f, 1662.33 + 4000, 1662.33 + 5000, (1046)0));
		}
	}

	// Token: 0x06004443 RID: 17475 RVA: 0x001AEBE0 File Offset: 0x001ACDE0
	internal bool 17(208 1, bool 2, int 3)
	{
		this.10 = 9;
		this.52 = 8;
		if (this.36 == null)
		{
			this.36 = new List<1433>();
			float num = 0.92f + (float)3 * 0.0001f;
			208 4 = new 208(-4f, -4f);
			this.30 = new 1433(1455.2("user-bg", (1416)1, null), (1376)6, 1065.TopLeft, (1044)0, 8 + 4, num, true, new 198(this.4.R, this.4.G, this.4.B, this.43 ? 200 : 0), null);
			this.30.3(delegate(object 1, EventArgs 2)
			{
				1226.20(null, "click-short-confirm", 1f, false);
			});
			this.36.Add(this.30);
			this.31 = new 1433(1455.2("user-border", (1416)1, null), (1376)6, 1065.TopLeft, (1044)0, 8 + 4, num + 2E-06f, true, new 198(0, 0, 0, this.43 ? byte.MaxValue : 0), null);
			this.36.Add(this.31);
			this.34 = new 1452(this.2(), 14f, 8 + new 208(48f, -2f), 208.Zero, num + 3E-06f, true, new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, this.43 ? byte.MaxValue : 0), true);
			this.36.Add(this.34);
			this.34.68(true);
			this.32 = new 1452(this.13, 10f, 8 + new 208(48f, 12f), new 208(150f, 33f), num + 3E-06f, true, new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, this.43 ? byte.MaxValue : 0), true);
			this.32.68(true);
			this.32.9 = 2;
			this.36.Add(this.32);
			this.35 = new 1452(this.28, 36f, 8 + new 208(204f, (float)(this.10 ? 14 : 7)), 208.Zero, num + 1E-06f, true, new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, this.43 ? byte.MaxValue : 0), false);
			this.35.49 = 1065.TopRight;
			this.35.68(true);
			this.36.Add(this.35);
			this.46 = new 1433(this.18(), (1376)6, 1065.TopLeft, (1044)0, 8 + new 208(176f, 0f), num + 2E-06f, true, new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, this.43 ? 70 : 0), null)
			{
				9 = 1
			};
			this.36.Add(this.46);
			this.5();
			if (this.10)
			{
				this.37 = new 1452(this.41, 10f, 8 + new 208(48f, 12f), new 208(150f, 32f), num + 4E-06f, true, new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 0), true);
				this.37.68(true);
				this.37.9 = 1;
				this.36.Add(this.37);
			}
			else
			{
				this.18 = new 1433(1455.2("levelbar-bg", (1416)1, null), 8, num + 3E-06f, true, new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, (this.43 && !9) ? byte.MaxValue : 0));
				this.18.48 = new 208(-120f, -62f);
				this.36.Add(this.18);
				this.18.9 = 1;
				this.19 = new 1433(1455.2("levelbar", (1416)1, null), 8, num + 3.5E-06f, true, new 198(252, 184, 6, (this.43 && !9) ? byte.MaxValue : 0));
				this.19.48 = new 208(-120f, -62f);
				this.15();
				this.36.Add(this.19);
				this.19.9 = 1;
				this.18.28 = true;
				this.18.16 = 0.4f;
				this.19.28 = true;
				this.19.16 = 0.7f;
				this.30.28 = true;
				this.4 = (this.30.6 = new 198(1, 1, 1));
				this.31.9(true);
			}
			this.30.35(new EventHandler(this.23));
			this.30.37(new EventHandler(this.22));
			this.21();
			return true;
		}
		208 5 = this.36[0].7;
		bool flag = false;
		foreach (1433 6 in this.36)
		{
			208 7 = 8 + (6.7 - 5);
			if (!(7 == 6.17) || 6.3.Count != 0)
			{
				flag = true;
				if (this.10 && this.43 && this.33.5 > 0f && this.30.19)
				{
					6.19(7, 500, (1046)26);
				}
				else
				{
					6.18(7, 0);
				}
				6.7 = 7;
				if (6.9 == 0)
				{
					6.16 = (this.43 > false);
				}
			}
		}
		this.21();
		if (flag && this.45 != null)
		{
			if (!this.45.19)
			{
				this.45 = null;
			}
			else
			{
				this.45.19(8 + (this.45.17 - 5), 500, (1046)1);
			}
		}
		return false;
	}

	// Token: 0x06004444 RID: 17476 RVA: 0x001AF2B0 File Offset: 0x001AD4B0
	private 1381 18()
	{
		if (this.26 > 0L || this.40 == 1653.Playing || this.40 == 1653.Multiplaying || this.40 == 1653.Testing)
		{
			switch (this.24)
			{
			case 2147.Osu:
				return 1455.2("mode-osu-small", (1416)1, null);
			case 2147.Taiko:
				return 1455.2("mode-taiko-small", (1416)1, null);
			case 2147.CatchTheBeat:
				return 1455.2("mode-fruits-small", (1416)1, null);
			case 2147.OsuMania:
				return 1455.2("mode-mania-small", (1416)1, null);
			}
		}
		return null;
	}

	// Token: 0x06004445 RID: 17477 RVA: 0x001AF337 File Offset: 0x001AD537
	private 198 19()
	{
		if (!this.30.IsHovered())
		{
			return 1045.3(this.4, 0.2f);
		}
		return 198.White;
	}

	// Token: 0x06004446 RID: 17478 RVA: 0x001AF35C File Offset: 0x001AD55C
	private 198 20()
	{
		198 result = new 198((byte)Math.Min(255, (int)(this.4.R + 40)), (byte)Math.Min(255, (int)(this.4.G + 40)), (byte)Math.Min(255, (int)(this.4.B + 40)));
		if (!this.30.IsHovered())
		{
			return this.4;
		}
		return result;
	}

	// Token: 0x06004447 RID: 17479 RVA: 0x001AF3D0 File Offset: 0x001AD5D0
	private void 21()
	{
		if (this.30 != null)
		{
			if (this.43 && this.33.5 > 0f && this.30.19)
			{
				this.30.39(this.20(), 300, true, (1046)0);
				this.31.39(this.19(), 300, true, (1046)0);
			}
			else
			{
				this.30.3.RemoveAll(new Predicate<1445>(1654.1656.instance.1));
				this.30.6 = (this.30.30 = this.20());
				this.31.3.RemoveAll(new Predicate<1445>(1654.1656.instance.2));
				this.31.6 = (this.31.30 = this.19());
			}
			if (this.25 > 200000)
			{
				this.35.62(new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 20));
			}
			if (this.25 > 100000)
			{
				this.35.62(new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 40));
				return;
			}
			if (this.25 > 50000)
			{
				this.35.62(new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 60));
				return;
			}
			if (this.25 > 1000)
			{
				this.35.62(new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 80));
				return;
			}
			if (this.25 > 10)
			{
				this.35.62(new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 100));
				return;
			}
			if (this.25 > 1)
			{
				this.35.62(new 198(244, 218, 73, 120));
				return;
			}
			this.35.62(new 198(88, 171, 248, 120));
		}
	}

	// Token: 0x06004448 RID: 17480 RVA: 0x001AF5F4 File Offset: 0x001AD7F4
	private void 22(object 1, EventArgs 2)
	{
		if (this.37 != null)
		{
			this.32.FadeIn(100, (1046)0, 0);
			this.32.19 = true;
			this.37.16(100, (1046)0, 0);
		}
		this.31.39(this.19(), 200, false, (1046)0);
		this.30.39(this.20(), 200, false, (1046)0);
	}

	// Token: 0x06004449 RID: 17481 RVA: 0x001AF668 File Offset: 0x001AD868
	private void 23(object 1, EventArgs 2)
	{
		if (this.37 != null)
		{
			this.32.16(100, (1046)0, 0);
			this.37.FadeIn(100, (1046)0, 0);
			this.37.19 = true;
		}
		1226.20(null, "click-short", 1f, false);
		this.31.39(this.19(), 200, false, (1046)0);
		this.30.39(this.20(), 200, false, (1046)0);
	}

	// Token: 0x0600444A RID: 17482 RVA: 0x001AF6F2 File Offset: 0x001AD8F2
	internal void 24()
	{
		this.11(true);
	}

	// Token: 0x0600444B RID: 17483 RVA: 0x001AF6FC File Offset: 0x001AD8FC
	internal void Hide()
	{
		this.43 = false;
		if (this.36 != null)
		{
			this.30.9(true);
			this.31.9(true);
			this.32.9(true);
			this.37.9(true);
			this.34.9(true);
			this.29.9(true);
			this.35.9(true);
			this.46.9(true);
		}
	}

	// Token: 0x0600444C RID: 17484 RVA: 0x001AF778 File Offset: 0x001AD978
	internal void Show()
	{
		this.43 = true;
		if (this.36 != null)
		{
			this.30.9(false);
			this.31.9(false);
			this.32.9(false);
			this.34.9(false);
			this.29.9(false);
			this.35.9(false);
			this.46.9(false);
			this.37.9(false);
		}
	}

	// Token: 0x0600444D RID: 17485 RVA: 0x001AF7F4 File Offset: 0x001AD9F4
	public void 25(bool 1)
	{
		this.36[0].10 = 1;
	}

	// Token: 0x0600444E RID: 17486 RVA: 0x001AF808 File Offset: 0x001ADA08
	public object Clone()
	{
		1654 <<EMPTY_NAME>> = base.MemberwiseClone() as 1654;
		<<EMPTY_NAME>>.26();
		return <<EMPTY_NAME>>;
	}

	// Token: 0x0600444F RID: 17487 RVA: 0x001AF81B File Offset: 0x001ADA1B
	private void 26()
	{
		this.36 = null;
		this.29 = null;
	}

	// Token: 0x06004450 RID: 17488 RVA: 0x001AF82B File Offset: 0x001ADA2B
	private void 27()
	{
		this.29.15 = 74f / (float)Math.Max(this.29.39, this.29.38);
	}

	// Token: 0x04003218 RID: 12824
	internal static readonly long[] 1 = new long[]
	{
		30000L,
		100000L,
		210000L,
		360000L,
		550000L,
		780000L,
		1050000L,
		1360000L,
		1710000L,
		2100000L,
		2530000L,
		3000000L,
		3510000L,
		4060000L,
		4650000L,
		5280000L,
		5950000L,
		6660000L,
		7410000L,
		8200000L,
		9030000L,
		9900000L,
		10810000L,
		11760000L,
		12750000L,
		13780000L,
		14850000L,
		15960000L,
		17110000L,
		18300000L,
		19530000L,
		20800000L,
		22110000L,
		23460000L,
		24850000L,
		26280000L,
		27750000L,
		29260000L,
		30810000L,
		32400000L,
		34030000L,
		35700000L,
		37410000L,
		39160000L,
		40950000L,
		42780000L,
		44650000L,
		46560000L,
		48510000L,
		50500000L,
		52530000L,
		54600000L,
		56710000L,
		58860000L,
		61050000L,
		63280000L,
		65550000L,
		67860000L,
		70210001L,
		72600001L,
		75030002L,
		77500003L,
		80010006L,
		82560010L,
		85150019L,
		87780034L,
		90450061L,
		93160110L,
		95910198L,
		98700357L,
		101530643L,
		104401157L,
		107312082L,
		110263748L,
		113256747L,
		116292144L,
		119371859L,
		122499346L,
		125680824L,
		128927482L,
		132259468L,
		135713043L,
		139353477L,
		143298259L,
		147758866L,
		153115959L,
		160054726L,
		169808506L,
		184597311L,
		208417160L,
		248460887L,
		317675597L,
		439366075L,
		655480935L,
		1041527682L,
		1733419828L,
		2975801691L,
		5209033044L,
		9225761479L,
		99999999999L,
		99999999999L,
		99999999999L,
		99999999999L,
		99999999999L,
		99999999999L,
		99999999999L,
		99999999999L,
		99999999999L,
		99999999999L,
		99999999999L,
		99999999999L,
		99999999999L,
		99999999999L,
		99999999999L,
		99999999999L,
		99999999999L,
		99999999999L,
		99999999999L,
		99999999999L,
		99999999999L,
		99999999999L,
		99999999999L,
		99999999999L
	};

	// Token: 0x04003219 RID: 12825
	private static string[] 2 = new string[]
	{
		"Unknown",
		"Oceania",
		"Europe",
		"Andorra",
		"UAE",
		"Afghanistan",
		"Antigua",
		"Anguilla",
		"Albania",
		"Armenia",
		"Netherlands Antilles",
		"Angola",
		"Antarctica",
		"Argentina",
		"American Samoa",
		"Austria",
		"Australia",
		"Aruba",
		"Azerbaijan",
		"Bosnia",
		"Barbados",
		"Bangladesh",
		"Belgium",
		"Burkina Faso",
		"Bulgaria",
		"Bahrain",
		"Burundi",
		"Benin",
		"Bermuda",
		"Brunei Darussalam",
		"Bolivia",
		"Brazil",
		"Bahamas",
		"Bhutan",
		"Bouvet Island",
		"Botswana",
		"Belarus",
		"Belize",
		"Canada",
		"Cocos Islands",
		"Congo",
		"Central African Republic",
		"Congo",
		"Switzerland",
		"Cote D'Ivoire",
		"Cook Islands",
		"Chile",
		"Cameroon",
		"China",
		"Colombia",
		"Costa Rica",
		"Cuba",
		"Cabo Verde",
		"Christmas Island",
		"Cyprus",
		"Czechia",
		"Germany",
		"Djibouti",
		"Denmark",
		"Dominica",
		"Dominican Republic",
		"Algeria",
		"Ecuador",
		"Estonia",
		"Egypt",
		"Western Sahara",
		"Eritrea",
		"Spain",
		"Ethiopia",
		"Finland",
		"Fiji",
		"Falkland Islands",
		"Micronesia, Federated States of",
		"Faroe Islands",
		"France",
		"France, Metropolitan",
		"Gabon",
		"United Kingdom",
		"Grenada",
		"Georgia",
		"French Guiana",
		"Ghana",
		"Gibraltar",
		"Greenland",
		"Gambia",
		"Guinea",
		"Guadeloupe",
		"Equatorial Guinea",
		"Greece",
		"South Georgia",
		"Guatemala",
		"Guam",
		"Guinea-Bissau",
		"Guyana",
		"Hong Kong",
		"Heard Island",
		"Honduras",
		"Croatia",
		"Haiti",
		"Hungary",
		"Indonesia",
		"Ireland",
		"Israel",
		"India",
		"British Indian Ocean Territory",
		"Iraq",
		"Iran, Islamic Republic of",
		"Iceland",
		"Italy",
		"Jamaica",
		"Jordan",
		"Japan",
		"Kenya",
		"Kyrgyzstan",
		"Cambodia",
		"Kiribati",
		"Comoros",
		"St. Kitts and Nevis",
		"Korea, Democratic People's Republic of",
		"Korea",
		"Kuwait",
		"Cayman Islands",
		"Kazakhstan",
		"Lao",
		"Lebanon",
		"St. Lucia",
		"Liechtenstein",
		"Sri Lanka",
		"Liberia",
		"Lesotho",
		"Lithuania",
		"Luxembourg",
		"Latvia",
		"Libyan Arab Jamahiriya",
		"Morocco",
		"Monaco",
		"Moldova, Republic of",
		"Madagascar",
		"Marshall Islands",
		"North Macedonia",
		"Mali",
		"Myanmar",
		"Mongolia",
		"Macau",
		"Northern Mariana Islands",
		"Martinique",
		"Mauritania",
		"Montserrat",
		"Malta",
		"Mauritius",
		"Maldives",
		"Malawi",
		"Mexico",
		"Malaysia",
		"Mozambique",
		"Namibia",
		"New Caledonia",
		"Niger",
		"Norfolk Island",
		"Nigeria",
		"Nicaragua",
		"Netherlands",
		"Norway",
		"Nepal",
		"Nauru",
		"Niue",
		"New Zealand",
		"Oman",
		"Panama",
		"Peru",
		"French Polynesia",
		"Papua New Guinea",
		"Philippines",
		"Pakistan",
		"Poland",
		"St. Pierre",
		"Pitcairn",
		"Puerto Rico",
		"Palestinian Territory",
		"Portugal",
		"Palau",
		"Paraguay",
		"Qatar",
		"Reunion",
		"Romania",
		"Russian Federation",
		"Rwanda",
		"Saudi Arabia",
		"Solomon Islands",
		"Seychelles",
		"Sudan",
		"Sweden",
		"Singapore",
		"St. Helena",
		"Slovenia",
		"Svalbard and Jan Mayen",
		"Slovakia",
		"Sierra Leone",
		"San Marino",
		"Senegal",
		"Somalia",
		"Suriname",
		"Sao Tome and Principe",
		"El Salvador",
		"Syrian Arab Republic",
		"Eswatini",
		"Turks and Caicos Islands",
		"Chad",
		"French Southern Territories",
		"Togo",
		"Thailand",
		"Tajikistan",
		"Tokelau",
		"Turkmenistan",
		"Tunisia",
		"Tonga",
		"Timor-Leste",
		"Turkiye",
		"Trinidad and Tobago",
		"Tuvalu",
		"Taiwan",
		"Tanzania",
		"Ukraine",
		"Uganda",
		"US (Island)",
		"United States",
		"Uruguay",
		"Uzbekistan",
		"Holy See",
		"St. Vincent",
		"Venezuela",
		"Virgin Islands, British",
		"Virgin Islands, U.S.",
		"Vietnam",
		"Vanuatu",
		"Wallis and Futuna",
		"Samoa",
		"Yemen",
		"Mayotte",
		"Serbia",
		"South Africa",
		"Zambia",
		"Montenegro",
		"Zimbabwe",
		"Unknown",
		"Satellite Provider",
		"Other",
		"Aland Islands",
		"Guernsey",
		"Isle of Man",
		"Jersey",
		"St. Barthelemy",
		"Saint Martin"
	};

	// Token: 0x0400321A RID: 12826
	internal double 3;

	// Token: 0x0400321B RID: 12827
	private 198 4 = new 198(10, 29, 75);

	// Token: 0x0400321C RID: 12828
	internal int 5;

	// Token: 0x0400321D RID: 12829
	internal string 6 = string.Empty;

	// Token: 0x0400321E RID: 12830
	internal bool 7;

	// Token: 0x0400321F RID: 12831
	internal string 8 = string.Empty;

	// Token: 0x04003220 RID: 12832
	internal 2023 9;

	// Token: 0x04003221 RID: 12833
	private bool 10;

	// Token: 0x04003222 RID: 12834
	private bool 11 = true;

	// Token: 0x04003223 RID: 12835
	internal int 12;

	// Token: 0x04003224 RID: 12836
	private string 13 = string.Empty;

	// Token: 0x04003225 RID: 12837
	internal string 14;

	// Token: 0x04003226 RID: 12838
	internal bool 15;

	// Token: 0x04003227 RID: 12839
	internal bool 16;

	// Token: 0x04003228 RID: 12840
	internal float 17;

	// Token: 0x04003229 RID: 12841
	private 1433 18;

	// Token: 0x0400322A RID: 12842
	private 1433 19;

	// Token: 0x0400322B RID: 12843
	internal string 20;

	// Token: 0x0400322C RID: 12844
	private string 21;

	// Token: 0x0400322D RID: 12845
	internal 1657 22;

	// Token: 0x0400322E RID: 12846
	internal int 23;

	// Token: 0x0400322F RID: 12847
	internal 2147 24;

	// Token: 0x04003230 RID: 12848
	internal int 25;

	// Token: 0x04003231 RID: 12849
	private long 26;

	// Token: 0x04003232 RID: 12850
	private int 27;

	// Token: 0x04003233 RID: 12851
	private string 28;

	// Token: 0x04003234 RID: 12852
	private 1505 29;

	// Token: 0x04003235 RID: 12853
	internal 1433 30;

	// Token: 0x04003236 RID: 12854
	private 1433 31;

	// Token: 0x04003237 RID: 12855
	internal 1452 32;

	// Token: 0x04003238 RID: 12856
	internal 1436 33 = 1662.28;

	// Token: 0x04003239 RID: 12857
	private 1452 34;

	// Token: 0x0400323A RID: 12858
	private 1452 35;

	// Token: 0x0400323B RID: 12859
	internal List<1433> 36;

	// Token: 0x0400323C RID: 12860
	private 1452 37;

	// Token: 0x0400323D RID: 12861
	internal bool 38;

	// Token: 0x0400323E RID: 12862
	internal bool 39;

	// Token: 0x0400323F RID: 12863
	internal 1653 40;

	// Token: 0x04003240 RID: 12864
	private string 41 = string.Empty;

	// Token: 0x04003241 RID: 12865
	internal int 42;

	// Token: 0x04003242 RID: 12866
	internal bool 43 = true;

	// Token: 0x04003243 RID: 12867
	internal bool 44 = true;

	// Token: 0x04003244 RID: 12868
	private 1452 45;

	// Token: 0x04003245 RID: 12869
	private 1433 46;

	// Token: 0x04003246 RID: 12870
	internal static string 47 = 1568.1(2679.General_Loading);

	// Token: 0x04003247 RID: 12871
	internal bool 48;

	// Token: 0x04003248 RID: 12872
	internal float 49;

	// Token: 0x04003249 RID: 12873
	internal float 50;

	// Token: 0x0400324A RID: 12874
	public int 51;

	// Token: 0x0400324B RID: 12875
	private 208 52;

	// Token: 0x0400324C RID: 12876
	public bool 53 = true;

	// Token: 0x0400324D RID: 12877
	private const string 54 = "nekiosu-profile-picture";

	// Token: 0x0200097E RID: 2430
	[Serializable]
	public sealed class 1656
	{
		// Token: 0x06004452 RID: 17490 RVA: 0x000CB7EB File Offset: 0x000C99EB
		internal bool 1(1445 1)
		{
			return 1.14 == 1456.Colour;
		}

		// Token: 0x06004453 RID: 17491 RVA: 0x000CB7EB File Offset: 0x000C99EB
		internal bool 2(1445 1)
		{
			return 1.14 == 1456.Colour;
		}

		// Token: 0x0400324E RID: 12878
		public static readonly 1654.1656 instance = new 1654.1656();

		// Token: 0x0400324F RID: 12879
		public static EventHandler eventHandler;

		// Token: 0x04003250 RID: 12880
		public static Predicate<1445> predicate;

		// Token: 0x04003251 RID: 12881
		public static Predicate<1445> predicate2;
	}

	// Token: 0x0200097F RID: 2431
	public sealed class 1655
	{
		// Token: 0x04003252 RID: 12882
		public 1505 1;

		// Token: 0x04003253 RID: 12883
		public float 2;
	}
}
