using System;
using System.Collections.Generic;

// Token: 0x020008B4 RID: 2228
public sealed class 1777 : 2462
{
	// Token: 0x06003FB8 RID: 16312 RVA: 0x0018A94B File Offset: 0x00188B4B
	internal 1777(1803 1) : base(1)
	{
	}

	// Token: 0x06003FB9 RID: 16313 RVA: 0x0018A954 File Offset: 0x00188B54
	public override void Initialize()
	{
		1549.5(new 1549.1551(this.5));
		1535.40((1082)1, new 1081(this.2), 1545.Default, (1559)0);
		1535.40((1082)0, delegate(object 1, EventArgs 2)
		{
			this.3(-1);
			return true;
		}, 1545.Default, (1559)0);
		this.4 = new 1436(true);
		this.21 = new 1354(new EventHandler(1777.1778.instance.1), true, false);
		this.4.14<1433>(this.21.1);
		1452 <<EMPTY_NAME>> = new 1452(1568.1(2679.OptionsOffsetWizard_Instructions), 16f, new 208((float)(1662.70.1() / 2), 400f), new 208(500f, 0f), 0.8f, true, 198.White, false);
		<<EMPTY_NAME>>.75 = (1066)2;
		<<EMPTY_NAME>>.49 = 1065.TopCentre;
		this.4.12(<<EMPTY_NAME>>);
		this.7 = new 1433(1455.2("options-offset-tick", (1416)7, null), (1376)6, 1065.Centre, (1044)0, new 208((float)(1662.70.1() / 2), 240f), 0.8f, true, 198.White, null);
		this.7.20 = new 208(0.1f, 2f);
		this.4.12(this.7);
		this.5 = new 1452(1568.1(2679.OptionsOffsetWizard_UniversalOffset), 30f, new 208(50f, 20f), 0.8f, true, 198.White);
		this.4.12(this.5);
		this.5 = new 1452(1304.154.ToString(), 30f, new 208(50f + this.5.GetTextSize().X, 20f), 0.8f, true, 198.YellowGreen);
		this.5.54(true);
		this.4.12(this.5);
		this.6 = new 1364(1568.1(2679.OptionsOffsetWizard_TickOther), new 208(50f, 80f), 0.8f, false);
		this.4.14<1433>(this.6.2);
		this.6.9(delegate(object 1, bool 2)
		{
			this.11 = true;
			this.13 = false;
			this.12 = true;
		});
		this.18 = new 1364(1568.1(2679.OptionsOffsetWizard_HalfTick), new 208(50f, 60f), 0.8f, false);
		this.4.14<1433>(this.18.2);
		this.18.9(new 1183(this.4));
		this.17 = new 1364(1568.1(2679.OptionsOffsetWizard_DoubleTick), new 208(150f, 60f), 0.8f, false);
		this.4.14<1433>(this.17.2);
		this.17.9(delegate(object 1, bool 2)
		{
			this.18.7(false);
			this.6.Hide();
			this.11 = true;
			this.13 = false;
			this.12 = true;
		});
		this.6.Hide();
		this.8 = new List<1433>();
		1240 3 = 1226.31;
		if (3 != null && 3.IsDirectStream())
		{
			1226.99(1272.5(), false, false, true, false);
			1226.98();
			1226.Pause();
		}
		base.Initialize();
		this.1(false);
	}

	// Token: 0x06003FBA RID: 16314 RVA: 0x0018AC9C File Offset: 0x00188E9C
	private void 1(bool 1)
	{
		if (1272.5() != this.10 || 1)
		{
			this.10 = 1272.5();
			this.15 = 0;
			this.20 = 0.0;
			this.19 = 0;
			this.9 = 0;
			this.16 = 0;
			this.11 = true;
		}
	}

	// Token: 0x06003FBB RID: 16315 RVA: 0x0018ACFA File Offset: 0x00188EFA
	private bool 2(object 1, EventArgs 2)
	{
		this.3(1);
		return true;
	}

	// Token: 0x06003FBC RID: 16316 RVA: 0x0018AD04 File Offset: 0x00188F04
	private new void 3(int 1)
	{
		1318 2 = 1304.154;
		2.7(2.6() + 1);
		this.5.SetText(1304.154.ToString());
		this.5.40(198.White, 200);
	}

	// Token: 0x06003FBD RID: 16317 RVA: 0x0018AD42 File Offset: 0x00188F42
	private void 4(object 1, bool 2)
	{
		if (2)
		{
			this.6.Show();
			this.17.7(false);
		}
		else
		{
			this.6.Hide();
		}
		this.11 = true;
		this.13 = false;
		this.12 = true;
	}

	// Token: 0x06003FBE RID: 16318 RVA: 0x0018AD80 File Offset: 0x00188F80
	private bool 5(object 1, 200 2, bool 3)
	{
		if (2 == 200.Escape)
		{
			this.21.3();
			return true;
		}
		if (2 == 200.Up)
		{
			if (1549.3)
			{
				this.3(5);
			}
			else
			{
				this.3(1);
			}
			return true;
		}
		if (2 != 200.Down)
		{
			return false;
		}
		if (1549.3)
		{
			this.3(-5);
		}
		else
		{
			this.3(-1);
		}
		return true;
	}

	// Token: 0x06003FBF RID: 16319 RVA: 0x0018ADE0 File Offset: 0x00188FE0
	private void 6()
	{
		1433 <<EMPTY_NAME>> = new 1433(1455.2("options-offset-tick", (1416)7, null), (1376)6, 1065.Centre, (1044)0, new 208(560f, 240f), 0.8f, true, 198.White, null);
		<<EMPTY_NAME>>.3.Add(new 1445(1456.Fade, 0f, 1f, 1662.33, 1662.33 + 300, (1046)0));
		<<EMPTY_NAME>>.3.Add(new 1445(1456.Fade, 1f, 0f, 1662.33 + this.9 - 300, 1662.33 + this.9, (1046)0));
		<<EMPTY_NAME>>.3.Add(new 1445(1456.Movement, new 208(560f, 240f), new 208((float)(1662.70.1() - 560), 240f), 1662.33, 1662.33 + this.9, (1046)0));
		<<EMPTY_NAME>>.20 = new 208(0.3f, 1f);
		<<EMPTY_NAME>>.3.Add(new 1445(1456.VectorScale, new 208(1f, 1f), new 208(0.3f, 1f), 1662.33 + this.9 / 2, 1662.33 + this.9 / 2 + 100, (1046)0));
		this.4.12(<<EMPTY_NAME>>);
		this.8.Add(<<EMPTY_NAME>>);
		if (!this.13)
		{
			this.13 = true;
			this.14 = (int)1226.64();
		}
	}

	// Token: 0x06003FC0 RID: 16320 RVA: 0x0018AF6B File Offset: 0x0018916B
	protected override void Dispose(bool 1)
	{
		1549.6(new 1549.1551(this.5));
		this.4.Dispose();
		base.Dispose(1);
	}

	// Token: 0x06003FC1 RID: 16321 RVA: 0x0018AF90 File Offset: 0x00189190
	public override void Update()
	{
		this.1(false);
		if (this.9 == 0)
		{
			this.9 = (int)((double)((float)(1120 - 1662.70.1()) / 120f) * 1226.76());
		}
		if (this.19 == 0)
		{
			this.19 = (int)((double)((float)(560 - 1662.70.1() / 2) / 120f) * 1226.76());
		}
		if (this.20 == 0.0)
		{
			this.20 = 1226.76() / 2.0;
		}
		double num = 1226.64();
		int num2 = (int)((num + (double)this.19) / this.20);
		if (num2 > this.16)
		{
			this.16 = num2;
			if (this.7(this.16))
			{
				this.6();
			}
		}
		int num3 = (int)(num / this.20);
		if (num3 < this.15)
		{
			this.1(true);
		}
		else if (num3 > this.15)
		{
			this.15 = num3;
			if (this.13 && !this.12)
			{
				if (this.7(this.15))
				{
					1226.24("metronomelow", 100, (1416)3, false);
					this.7.3.Add(new 1445(198.White, 198.Black, 1662.33, 1662.33 + 80));
				}
			}
			else if (this.13 && num > (double)(this.14 + this.19 / 2))
			{
				this.12 = false;
			}
		}
		for (int i = 0; i < this.8.Count; i++)
		{
			if (this.8[i].17.X <= (float)(1662.70.1() - 560))
			{
				this.4.Remove(this.8[i]);
				this.8.RemoveAt(i);
			}
		}
		if (this.11)
		{
			this.8.ForEach(new Action<1433>(1777.1778.instance.2));
			this.11 = false;
		}
		base.Update();
	}

	// Token: 0x06003FC2 RID: 16322 RVA: 0x0018B1A4 File Offset: 0x001893A4
	private bool 7(int 1)
	{
		int num = 2;
		if (this.17.4())
		{
			num = 1;
		}
		else if (this.18.4())
		{
			num = 4;
		}
		int num2 = 0;
		if (this.18.4() && this.6.4())
		{
			num2 = 2;
		}
		return 1 % num == num2;
	}

	// Token: 0x06003FC3 RID: 16323 RVA: 0x0018B1F7 File Offset: 0x001893F7
	public override void Draw()
	{
		this.4.22();
		base.Draw();
	}

	// Token: 0x04002E92 RID: 11922
	private 1436 4;

	// Token: 0x04002E93 RID: 11923
	private 1452 5;

	// Token: 0x04002E94 RID: 11924
	private 1364 6;

	// Token: 0x04002E95 RID: 11925
	private 1433 7;

	// Token: 0x04002E96 RID: 11926
	private List<1433> 8;

	// Token: 0x04002E97 RID: 11927
	private int 9;

	// Token: 0x04002E98 RID: 11928
	private 1262 10;

	// Token: 0x04002E99 RID: 11929
	private bool 11;

	// Token: 0x04002E9A RID: 11930
	private bool 12;

	// Token: 0x04002E9B RID: 11931
	private bool 13;

	// Token: 0x04002E9C RID: 11932
	private int 14;

	// Token: 0x04002E9D RID: 11933
	private int 15;

	// Token: 0x04002E9E RID: 11934
	private int 16;

	// Token: 0x04002E9F RID: 11935
	private 1364 17;

	// Token: 0x04002EA0 RID: 11936
	private 1364 18;

	// Token: 0x04002EA1 RID: 11937
	private int 19;

	// Token: 0x04002EA2 RID: 11938
	private double 20;

	// Token: 0x04002EA3 RID: 11939
	private 1354 21;

	// Token: 0x020008B5 RID: 2229
	[Serializable]
	public sealed class 1778
	{
		// Token: 0x06003FC7 RID: 16327 RVA: 0x0018B25A File Offset: 0x0018945A
		internal void 1(object 1, EventArgs 2)
		{
			1662.SetMode(1662.90(), false);
		}

		// Token: 0x06003FC8 RID: 16328 RVA: 0x0018B267 File Offset: 0x00189467
		internal void 2(1433 1)
		{
			1.16(300, (1046)0, 0);
			1.5 = false;
		}

		// Token: 0x04002EA4 RID: 11940
		public static readonly 1777.1778 instance = new 1777.1778();

		// Token: 0x04002EA5 RID: 11941
		public static EventHandler eventHandler;

		// Token: 0x04002EA6 RID: 11942
		public static Action<1433> action;
	}
}
