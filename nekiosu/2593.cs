using System;
using System.Collections.Generic;
using System.IO;
using OpenTK;

// Token: 0x02000497 RID: 1175
public class 2593
{
	// Token: 0x060023B8 RID: 9144 RVA: 0x0009C810 File Offset: 0x0009AA10
	internal 2593(1262 1 = null, 2593 2 = null, 2147? 3 = null)
	{
		this.22 = 2;
		if (3 != null)
		{
			this.37 = 3;
		}
		this.7(2593.5);
		this.14 = 1;
		if (1 != null)
		{
			if (!1.28)
			{
				this.7(2593.10);
			}
			this.18 = !1.64;
		}
		this.47 = this.6();
	}

	// Token: 0x060023B9 RID: 9145 RVA: 0x0009C8A9 File Offset: 0x0009AAA9
	internal static Vector2d 1()
	{
		return new Vector2d(2573.38() + 500.0, (double)(1662.70.2() / 2));
	}

	// Token: 0x060023BA RID: 9146 RVA: 0x0009C8CC File Offset: 0x0009AACC
	internal bool 2()
	{
		return this.18;
	}

	// Token: 0x060023BB RID: 9147 RVA: 0x0009C8D4 File Offset: 0x0009AAD4
	internal void 3(bool 1)
	{
		if (this.18 != 1)
		{
			this.18 = 1;
			this.33(300);
		}
	}

	// Token: 0x060023BC RID: 9148 RVA: 0x0009C8F1 File Offset: 0x0009AAF1
	private bool 4()
	{
		return (!2593.45 && this.14.29 > 0 && 1304.172.1()) || 1662.49;
	}

	// Token: 0x060023BD RID: 9149 RVA: 0x0009C91B File Offset: 0x0009AB1B
	internal bool 5()
	{
		return this == this.21;
	}

	// Token: 0x060023BE RID: 9150 RVA: 0x0009C926 File Offset: 0x0009AB26
	public 198 6()
	{
		return this.28;
	}

	// Token: 0x060023BF RID: 9151 RVA: 0x0009C92E File Offset: 0x0009AB2E
	protected void 7(198 1)
	{
		this.28 = 1;
	}

	// Token: 0x060023C0 RID: 9152 RVA: 0x0009C938 File Offset: 0x0009AB38
	internal void 8()
	{
		if (!this.16)
		{
			return;
		}
		this.16 = false;
		if (this.29 != null)
		{
			foreach (1371 <<EMPTY_NAME>> in this.29)
			{
				1433 2 = (1433)<<EMPTY_NAME>>;
				1452 3 = 2 as 1452;
				if (3 != null && 2.47 != null)
				{
					3.47.Dispose();
					3.47 = null;
				}
			}
			this.29 = null;
		}
		this.36.Clear();
		this.30 = null;
		this.31 = null;
		this.32 = null;
		this.33 = null;
		this.34 = null;
		this.40 = null;
		this.41 = null;
		this.17 = 0f;
		this.27 = -1.0;
	}

	// Token: 0x060023C1 RID: 9153 RVA: 0x0009CA24 File Offset: 0x0009AC24
	internal void 9()
	{
		this.8();
	}

	// Token: 0x060023C2 RID: 9154 RVA: 0x0009CA2C File Offset: 0x0009AC2C
	internal virtual string GetDisplayTitle()
	{
		return this.14.9();
	}

	// Token: 0x060023C3 RID: 9155 RVA: 0x0009CA39 File Offset: 0x0009AC39
	internal bool 10(206 1)
	{
		return this.30 != null && this.30.50.9(1);
	}

	// Token: 0x060023C4 RID: 9156 RVA: 0x0009CA58 File Offset: 0x0009AC58
	internal void 11(bool 1)
	{
		if (!this.16 || this.14 == null || this.46 < (2597)2)
		{
			return;
		}
		double num = Math.Min(this.14.31(), 10.0);
		if (this.27 == num)
		{
			return;
		}
		double num2 = this.27;
		this.27 = num;
		this.13();
		if (num < 0.0)
		{
			num = 0.0;
			int num3 = this.25 + 2593.1;
			for (int i = this.25; i < num3; i++)
			{
				this.29[i].16((!1) ? (2593.45 ? 1000 : 600) : 0, (1046)0, 0);
			}
		}
		else
		{
			int num4 = this.25 + 2593.1;
			for (int j = this.25; j < num4; j++)
			{
				this.29[j].FadeIn((!1) ? (2593.45 ? 1000 : 600) : 0, (1046)0, 0);
			}
		}
		int num5 = this.25 + 2593.1 * 2;
		for (int k = this.25 + 2593.1; k < num5; k++)
		{
			int num6 = k - (this.25 + 2593.1);
			double num7 = num - (double)num6;
			1433 2 = this.29[k] as 1433;
			2.3.Clear();
			if (2593.45)
			{
				int num8 = (int)((double)2.39 * num7);
				2.47(num8, (!1) ? 500 : 0, (1046)7);
			}
			else
			{
				float num9 = (num7 <= 0.0) ? 0f : (0.6f * (float)Math.Max(0.5, Math.Min(1.0, num7) + (double)((float)num6 * 0.04f)));
				int num10 = (int)Math.Floor((double)num6 - Math.Min(num, num2));
				if (1)
				{
					2.25(num9, 0, (1046)0);
				}
				else
				{
					int num11 = (num2 <= num) ? num10 : ((int)Math.Floor(num2 - num) - num10 - 1);
					int num12 = 1662.33 + num11 * 80 + 50;
					2.3.Add(new 1445(1456.Scale, 2.15, num9, num12, num12 + 500, (1046)30));
				}
			}
		}
	}

	// Token: 0x060023C5 RID: 9157 RVA: 0x0009CCC0 File Offset: 0x0009AEC0
	internal void 12(float 1)
	{
		this.43 = 1;
		if (this.29 == null)
		{
			return;
		}
		foreach (1371 2 in this.29)
		{
			((1433)2).2 = 1;
			1 += 1E-06f;
		}
	}

	// Token: 0x060023C6 RID: 9158 RVA: 0x0009CD30 File Offset: 0x0009AF30
	protected virtual void CreateSprites()
	{
		this.29 = new List<1371>();
		if (this.14 != null)
		{
			2147? <<EMPTY_NAME>> = this.37;
			if (this.14 != null && this.14.3() != 2147.Osu)
			{
				<<EMPTY_NAME>> = new 2147?(this.14.3());
			}
			2593.45 = (2630.5.Version < 2.2 && 1455.2("menu-button-background", (1416)7, null).6 != (1416)1);
			this.14.11();
			if (this.14.43.Length > 0)
			{
				string text = this.14.43;
			}
			this.30 = new 1433(2593.38, (1376)6, 1065.CentreLeft, (1044)0, new 208((float)this.44.X, (float)this.44.Y), this.43, true, this.47, this);
			this.30.10 = true;
			this.29.Add(this.30);
			bool flag = this.4();
			float num = (float)(2593.45 ? 15 : 5);
			float num2 = (float)(flag ? 75 : 5);
			float num3 = (float)(2593.45 ? -3 : 0);
			float num4 = (float)(1662.49 ? 22 : 16);
			this.31 = new 1452(this.GetDisplayTitle(), num4, 208.Zero, 208.Zero, this.43 + 1E-06f, true, 2593.12, false);
			this.31.49 = 1065.CentreLeft;
			this.31.8 = new 208(num2, num3 - (float)((!1662.47) ? 16 : 0));
			this.36.Add(this.31);
			this.29.Add(this.31);
			this.32 = new 1452(this.14.10() + " // " + this.14.43, 12f, 208.Zero, 208.Zero, this.43 + 1E-06f, true, 2593.12, false);
			this.32.49 = 1065.CentreLeft;
			this.32.8 = new 208(num2 + 1f, num3 - 4f);
			this.36.Add(this.32);
			if (!1662.49)
			{
				this.29.Add(this.32);
			}
			if (flag)
			{
				bool flag2 = 1662.70.2 >= 768;
				string[] array = new string[5];
				array[0] = 1296.8;
				array[1] = "/thumb/";
				int num5 = this.14.29;
				array[2] = num5.ToString();
				array[3] = (flag2 ? "l" : string.Empty);
				array[4] = ".jpg";
				string text2 = string.Concat(array);
				string path = 1345.4();
				string path2 = "Data";
				string path3 = "bt";
				num5 = this.14.29;
				this.41 = new 1505(text2, Path.Combine(path, path2, path3, num5.ToString() + (flag2 ? "l" : string.Empty) + ".jpg"), 500, 208.Zero, this.43 + 1E-06f);
				if (1662.49)
				{
					this.41.53(string.Empty);
					this.41.55(Path.Combine(this.14.44(), this.14.22));
					this.41.71 = (1484)3;
					this.41.49(new 1189(this.34));
				}
				this.41.56(delegate
				{
					this.41.15(400);
					if (1662.49)
					{
						this.41.20 = 208.One;
						this.41.15 = Math.Min(114f / (float)this.41.39, 85.5f / (float)this.41.38);
					}
				});
				this.41.6 = new 198(50, 50, 50, byte.MaxValue);
				this.41.28 = true;
				this.41.20 = new 208(1.425f, 1.425f) * (flag2 ? 0.5f : 1f);
				this.41.49 = 1065.CentreLeft;
				this.41.8 = new 208(5.2f, 0.25f);
				this.29.Add(this.41);
			}
			this.42 = this.29.Count;
			this.33 = new 1452(string.Empty, 12f, 208.Zero, 208.Zero, this.43 + 1E-06f, true, 2593.12, false);
			this.33.49 = 1065.CentreLeft;
			this.33.54(true);
			this.33.8 = new 208(num2 + 1f, num3 + 7f);
			this.36.Add(this.33);
			this.29.Add(this.33);
			this.13();
			if (<<EMPTY_NAME>> != null)
			{
				this.19 = true;
				1381 2 = null;
				if (<<EMPTY_NAME>> != null)
				{
					switch (<<EMPTY_NAME>>.GetValueOrDefault())
					{
					case 2147.Osu:
						2 = 1455.2("mode-osu-small", (1416)1, null);
						break;
					case 2147.Taiko:
						2 = 1455.2("mode-taiko-small", (1416)1, null);
						break;
					case 2147.CatchTheBeat:
						2 = 1455.2("mode-fruits-small", (1416)1, null);
						break;
					case 2147.OsuMania:
						2 = 1455.2("mode-mania-small", (1416)1, null);
						break;
					}
				}
				this.40 = new 1433(2, (1376)6, 1065.CentreLeft, (1044)0, 208.Zero, this.43 + 1E-06f, true, 198.White, null);
				this.40.20 = new 208(0.8f, 0.8f);
				this.40.8 = new 208(num + num2 + 1f, num3 - 13f);
				this.36.Add(this.40);
				this.29.Add(this.40);
			}
			this.34 = new 1433(null, 1065.CentreLeft, 208.Zero, this.43 + 1E-06f, true, 198.White);
			this.34.8 = new 208(num + num2 - 1f, num3 + (float)(this.19 ? 14 : 0));
			this.29.Add(this.34);
			this.14();
		}
		for (int i = 0; i < this.29.Count; i++)
		{
			this.29[i].16 = 0f;
		}
	}

	// Token: 0x060023C7 RID: 9159 RVA: 0x0009D3CC File Offset: 0x0009B5CC
	internal void 13()
	{
		if (this.14 != null)
		{
			this.33.SetText(this.14.89);
			if ((2486.14() == 2147.OsuMania && this.14.3() == 2147.Osu) || this.14.3() == 2147.OsuMania)
			{
				1452 <<EMPTY_NAME>> = this.33;
				<<EMPTY_NAME>>.SetText(<<EMPTY_NAME>>.GetText() + string.Format(" ({0}K{1})", 2011.52(this.14), (Math.Round((double)this.14.4) <= 4.0) ? "↓" : string.Empty));
			}
		}
	}

	// Token: 0x060023C8 RID: 9160 RVA: 0x0009D478 File Offset: 0x0009B678
	internal void 14()
	{
		this.34.SetTexture((this.14.72() > 2236.D) ? null : 1455.2("ranking-" + this.14.72().ToString() + "-small", (1416)7, null));
		this.20 = (this.34.GetTexture() != null);
		this.15();
	}

	// Token: 0x060023C9 RID: 9161 RVA: 0x0009D4EC File Offset: 0x0009B6EC
	private void 15()
	{
		2593.2594 <<EMPTY_NAME>> = new 2593.2594();
		<<EMPTY_NAME>>.1 = this;
		float num = (float)(2593.45 ? 15 : 5);
		float num2 = this.17;
		this.17 = (float)((this.46 >= (2597)2 && (this.19 || this.20)) ? 20 : 3) + num;
		if (num2 != this.17 && this.29 != null)
		{
			<<EMPTY_NAME>>.2 = this.17 - num2;
			this.29.ForEach(new Action<1371>(<<EMPTY_NAME>>.1));
		}
	}

	// Token: 0x060023CA RID: 9162 RVA: 0x0009D578 File Offset: 0x0009B778
	internal bool 16()
	{
		return !this.23 && this.46 > (2597)0 && (this.22 == null || (this.22.23() && !this.22.23));
	}

	// Token: 0x060023CB RID: 9163 RVA: 0x0009D5B4 File Offset: 0x0009B7B4
	internal bool 17()
	{
		return this.30 != null && this.30.IsHovered();
	}

	// Token: 0x060023CC RID: 9164 RVA: 0x0009D5CB File Offset: 0x0009B7CB
	internal bool 18()
	{
		return this.46 <= (2597)0;
	}

	// Token: 0x060023CD RID: 9165 RVA: 0x0009D5DC File Offset: 0x0009B7DC
	public static void 19()
	{
		2593.11 = 2630.4["SongSelectActiveText"];
		2593.12 = 2630.4["SongSelectInactiveText"];
		2593.13 = 1045.8(2593.12, 50);
		2593.38 = 1455.2("menu-button-background", (1416)7, null);
		2593.39 = 1455.2("star", (1416)7, null);
	}

	// Token: 0x060023CE RID: 9166 RVA: 0x0009D644 File Offset: 0x0009B844
	internal void 20(1436 1)
	{
		1.26(this.29);
	}

	// Token: 0x060023CF RID: 9167 RVA: 0x0009D652 File Offset: 0x0009B852
	internal void 21(1436 1)
	{
		1.20<1371>(this.29);
	}

	// Token: 0x060023D0 RID: 9168 RVA: 0x0009D660 File Offset: 0x0009B860
	internal void 22(Vector2d 1)
	{
		Vector2d vector2d = this.44 + 1;
		foreach (1371 2 in this.29)
		{
			1433 3 = (1433)2;
			3.17 = new 208((float)vector2d.X, (float)vector2d.Y);
			if (3.8 is 208)
			{
				3.17 += (208)3.8;
			}
		}
	}

	// Token: 0x060023D1 RID: 9169 RVA: 0x0009D700 File Offset: 0x0009B900
	public bool 23()
	{
		return this.46 >= (2597)3;
	}

	// Token: 0x060023D2 RID: 9170 RVA: 0x0009D70E File Offset: 0x0009B90E
	public void 24(bool 1)
	{
		if (this.23() != 1)
		{
			if (this.46 < (2597)3)
			{
				this.28((2597)3);
				return;
			}
			if (this.24)
			{
				this.28((2597)2);
				return;
			}
			this.28((2597)1);
		}
	}

	// Token: 0x060023D3 RID: 9171 RVA: 0x0009D744 File Offset: 0x0009B944
	internal void 25(int 1)
	{
		if (!this.16)
		{
			return;
		}
		foreach (1371 2 in this.29)
		{
			((1433)2).16(1, (1046)0, 0);
		}
	}

	// Token: 0x060023D4 RID: 9172 RVA: 0x0009D7A8 File Offset: 0x0009B9A8
	internal void 26(bool 1)
	{
		if (!this.16)
		{
			this.CreateSprites();
			this.16 = true;
			this.ApplyStateChange((2597)0, 1);
		}
	}

	// Token: 0x060023D5 RID: 9173 RVA: 0x0009D7C8 File Offset: 0x0009B9C8
	internal virtual void ApplyStateChange(2597 1, bool 2)
	{
		2593.2595 3 = new 2593.2595();
		3.1 = 2;
		3.2 = this;
		if (this.46 <= (2597)0)
		{
			if (this.29[0].16 != 0f)
			{
				this.29.ForEach(new Action<1371>(3.1));
			}
		}
		else if (1 <= (2597)0)
		{
			int num = (this.46 >= (2597)2) ? this.29.Count : this.42;
			for (int i = 0; i < num; i++)
			{
				this.29[i].15((!3.1) ? 200 : 0);
			}
		}
		this.15();
		if ((this.46 >= (2597)2 && 1 < (2597)2) || (this.46 < (2597)2 && 1 >= (2597)2))
		{
			float num2 = (float)(2593.45 ? -3 : 0);
			float num3 = (float)(this.4() ? 75 : 5);
			if (this.46 >= (2597)2)
			{
				this.25 = this.29.Count;
				this.26 = this.36.Count;
				198 4 = new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 30);
				for (int j = 0; j < 2593.1; j++)
				{
					1433 5 = new 1433(2593.39, (1376)6, 1065.Centre, (1044)0, 208.Zero, this.31.2, true, 4, this.14)
					{
						20 = new 208(0.6f, 0.6f),
						8 = new 208(this.17 + num3 + ((float)j + 0.5f) * ((float)2593.39.3() * 0.625f) * 0.6f, num2 + 18f),
						28 = true,
						16 = 0f
					};
					if (!2593.45)
					{
						5.15 = 0.35f;
					}
					this.29.Add(5);
				}
				for (int k = 0; k < 2593.1; k++)
				{
					1433 6 = new 1433(2593.39, (1376)6, 1065.Centre, (1044)0, 208.Zero, this.31.2 + 1E-06f, true, 198.White, this.14)
					{
						20 = new 208(0.6f, 0.6f),
						8 = new 208(this.17 + num3 + ((float)k + 0.5f) * ((float)2593.39.3() * 0.625f) * 0.6f, num2 + 18f)
					};
					if (2593.45)
					{
						6.35 = -(6.39 * k);
					}
					else
					{
						6.15 = 0f;
					}
					this.29.Add(6);
					this.36.Add(6);
				}
				for (int l = 0; l < this.29.Count; l++)
				{
					1433 7 = this.29[l] as 1433;
					if (l >= this.42 && (l < this.25 || l >= this.25 + 2593.1))
					{
						7.FadeIn((!3.1) ? 300 : 0, (1046)0, 0);
					}
				}
				this.11(3.1);
			}
			else
			{
				for (int m = 0; m < this.29.Count; m++)
				{
					1433 8 = this.29[m] as 1433;
					if (m >= this.42)
					{
						8.16((!3.1) ? 300 : 0, (1046)0, 0);
					}
				}
				int num4 = this.25 + 2593.1 * 2;
				for (int n = this.25; n < num4; n++)
				{
					this.29[n].5 = false;
				}
				this.29.RemoveRange(this.25, 2593.1 * 2);
				this.36.RemoveRange(this.26, 2593.1);
				this.27 = -1.0;
			}
		}
		if ((this.46 >= (2597)3 && 1 < (2597)3) || (this.46 < (2597)3 && 1 >= (2597)3))
		{
			if (this.46 >= (2597)3)
			{
				if (this.41 != null)
				{
					this.41.28 = false;
					this.41.15((!3.1) ? 1000 : 0);
					this.41.72 = 100;
					this.41.39(new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue), (!3.1) ? 300 : 0, false, (1046)0);
				}
			}
			else if (this.41 != null)
			{
				this.41.28 = true;
				this.41.72 = 500;
				this.41.39(new 198(50, 50, 50, byte.MaxValue), (!3.1) ? 300 : 0, false, (1046)0);
			}
			this.15();
		}
		this.33((!3.1) ? 300 : 0);
		if (this.46 == (2597)4)
		{
			this.36.ForEach(new Action<1433>(2593.2596.Instance.1));
			return;
		}
		this.36.ForEach(new Action<1433>(3.2));
	}

	// Token: 0x060023D6 RID: 9174 RVA: 0x0009DD3C File Offset: 0x0009BF3C
	internal virtual void OnStateChanged(2597 1)
	{
		if (!this.16 && this.23())
		{
			this.26(false);
		}
		if (1 <= (2597)0)
		{
			if (!this.5() && this.21 != null)
			{
				this.44 = this.21.44;
				return;
			}
		}
		else if (this.46 <= (2597)0)
		{
			this.8();
		}
	}

	// Token: 0x060023D7 RID: 9175 RVA: 0x0009DD95 File Offset: 0x0009BF95
	internal 2597 27()
	{
		return this.46;
	}

	// Token: 0x060023D8 RID: 9176 RVA: 0x0009DDA0 File Offset: 0x0009BFA0
	internal void 28(2597 1)
	{
		if (this.46 != 1)
		{
			2597 2 = this.46;
			this.46 = 1;
			if (this.16)
			{
				this.ApplyStateChange(2, false);
			}
			this.OnStateChanged(2);
		}
	}

	// Token: 0x060023D9 RID: 9177 RVA: 0x0009DDDB File Offset: 0x0009BFDB
	internal bool 29()
	{
		return this.30 != null && this.30.16 == 1f;
	}

	// Token: 0x060023DA RID: 9178 RVA: 0x0009DDF9 File Offset: 0x0009BFF9
	internal void 30(198 1, int 2)
	{
		if (this.30 != null)
		{
			this.30.40(1, 2);
		}
	}

	// Token: 0x060023DB RID: 9179 RVA: 0x0009DE10 File Offset: 0x0009C010
	internal void 31(198 1, int 2)
	{
		this.47 = 1;
		this.32(2);
	}

	// Token: 0x060023DC RID: 9180 RVA: 0x0009DE20 File Offset: 0x0009C020
	private void 32(int 1)
	{
		if (this.30 != null)
		{
			this.30.39(this.47, 1, false, (1046)0);
		}
	}

	// Token: 0x060023DD RID: 9181 RVA: 0x0009DE40 File Offset: 0x0009C040
	private void 33(int 1)
	{
		2597 2 = this.46;
		if (2 != (2597)3)
		{
			if (2 == (2597)4)
			{
				this.7(2593.9);
			}
			else
			{
				this.7(this.2() ? 2593.5 : 2593.6);
			}
		}
		else
		{
			this.7(2593.7);
		}
		this.31(this.6(), 1);
	}

	// Token: 0x060023DE RID: 9182 RVA: 0x0009DE9D File Offset: 0x0009C09D
	private void 34()
	{
		if (this.41 != null)
		{
			this.41.71 = (1484)3;
		}
	}

	// Token: 0x040018CE RID: 6350
	internal static readonly int 1 = 10;

	// Token: 0x040018CF RID: 6351
	internal static 198 2 = new 198(163, 240, 44, byte.MaxValue);

	// Token: 0x040018D0 RID: 6352
	internal static 198 3 = new 198(35, 50, 143, byte.MaxValue);

	// Token: 0x040018D1 RID: 6353
	internal static 198 4 = new 198(35, 90, 193, byte.MaxValue);

	// Token: 0x040018D2 RID: 6354
	internal static 198 5 = new 198(233, 104, 0, 240);

	// Token: 0x040018D3 RID: 6355
	internal static 198 6 = new 198(235, 73, 153, 240);

	// Token: 0x040018D4 RID: 6356
	internal static 198 7 = new 198(0, 150, 236, 240);

	// Token: 0x040018D5 RID: 6357
	internal static 198 8 = 1045.2(2593.7, 0.3f);

	// Token: 0x040018D6 RID: 6358
	internal static 198 9 = new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 220);

	// Token: 0x040018D7 RID: 6359
	internal static 198 10 = new 198(198.MediumSlateBlue.R, 198.MediumSlateBlue.G, 198.MediumSlateBlue.B, 240);

	// Token: 0x040018D8 RID: 6360
	public static 198 11;

	// Token: 0x040018D9 RID: 6361
	public static 198 12;

	// Token: 0x040018DA RID: 6362
	public static 198 13;

	// Token: 0x040018DB RID: 6363
	internal 1262 14;

	// Token: 0x040018DC RID: 6364
	internal int 15 = -1;

	// Token: 0x040018DD RID: 6365
	internal bool 16;

	// Token: 0x040018DE RID: 6366
	private float 17;

	// Token: 0x040018DF RID: 6367
	private bool 18;

	// Token: 0x040018E0 RID: 6368
	private bool 19;

	// Token: 0x040018E1 RID: 6369
	private bool 20;

	// Token: 0x040018E2 RID: 6370
	internal 2593 21;

	// Token: 0x040018E3 RID: 6371
	internal 2593 22;

	// Token: 0x040018E4 RID: 6372
	public bool 23;

	// Token: 0x040018E5 RID: 6373
	public bool 24;

	// Token: 0x040018E6 RID: 6374
	private int 25;

	// Token: 0x040018E7 RID: 6375
	private int 26;

	// Token: 0x040018E8 RID: 6376
	private double 27 = -1.0;

	// Token: 0x040018E9 RID: 6377
	private 198 28;

	// Token: 0x040018EA RID: 6378
	protected List<1371> 29;

	// Token: 0x040018EB RID: 6379
	internal 1433 30;

	// Token: 0x040018EC RID: 6380
	internal 1452 31;

	// Token: 0x040018ED RID: 6381
	internal 1452 32;

	// Token: 0x040018EE RID: 6382
	private 1452 33;

	// Token: 0x040018EF RID: 6383
	internal 1433 34;

	// Token: 0x040018F0 RID: 6384
	private static 1445 35 = new 1445(1456.Scale, 1f, 1.1f, 0, 300, (1046)1);

	// Token: 0x040018F1 RID: 6385
	internal List<1433> 36 = new List<1433>();

	// Token: 0x040018F2 RID: 6386
	private 2147? 37;

	// Token: 0x040018F3 RID: 6387
	protected static 1381 38;

	// Token: 0x040018F4 RID: 6388
	protected static 1381 39;

	// Token: 0x040018F5 RID: 6389
	internal 1433 40;

	// Token: 0x040018F6 RID: 6390
	private 1505 41;

	// Token: 0x040018F7 RID: 6391
	public int 42;

	// Token: 0x040018F8 RID: 6392
	internal float 43;

	// Token: 0x040018F9 RID: 6393
	internal Vector2d 44 = 2593.1();

	// Token: 0x040018FA RID: 6394
	internal static bool 45;

	// Token: 0x040018FB RID: 6395
	protected 2597 46;

	// Token: 0x040018FC RID: 6396
	internal 198 47;

	// Token: 0x02000498 RID: 1176
	[Serializable]
	public sealed class 2596
	{
		// Token: 0x060023E1 RID: 9185 RVA: 0x0009E045 File Offset: 0x0009C245
		internal void 1(1433 1)
		{
			1.6 = 2593.11;
		}

		// Token: 0x040018FD RID: 6397
		public static readonly 2593.2596 Instance = new 2593.2596();

		// Token: 0x040018FE RID: 6398
		public static Action<1433> action;
	}

	// Token: 0x02000499 RID: 1177
	public sealed class 2595
	{
		// Token: 0x060023E4 RID: 9188 RVA: 0x0009E05E File Offset: 0x0009C25E
		internal void 1(1371 1)
		{
			1.16((!this.1) ? 200 : 0, (1046)0, 0);
		}

		// Token: 0x060023E5 RID: 9189 RVA: 0x0009E078 File Offset: 0x0009C278
		internal void 2(1433 1)
		{
			198 2 = (this.2.46 <= (2597)2) ? 2593.12 : ((1 != this.2.32 && 1 != this.2.31) ? 2593.12 : 2593.13);
			1.6 = 2;
		}

		// Token: 0x040018FF RID: 6399
		public bool 1;

		// Token: 0x04001900 RID: 6400
		public 2593 2;
	}

	// Token: 0x0200049A RID: 1178
	public sealed class 2594
	{
		// Token: 0x060023E7 RID: 9191 RVA: 0x0009E0CC File Offset: 0x0009C2CC
		internal void 1(1371 1)
		{
			if (1.8 is 208 && 1 != this.1.40 && 1 != this.1.34 && 1 != this.1.41)
			{
				208 2 = (208)1.8;
				2.X += this.2;
				1.8 = 2;
			}
		}

		// Token: 0x04001901 RID: 6401
		public 2593 1;

		// Token: 0x04001902 RID: 6402
		public float 2;
	}
}
