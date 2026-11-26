using System;
using System.Collections.Generic;

// Token: 0x02000AC1 RID: 2753
public sealed class 1429 : IDisposable
{
	// Token: 0x06004C5F RID: 19551 RVA: 0x001E2910 File Offset: 0x001E0B10
	internal 1429(1436 1, double 2, double 3, double 4, 208 5, int 6)
	{
		1429.1430 sliderControlClosure = new 1429.1430
		{
			2 = 6
		};
		sliderControlClosure.1 = this;
		this.9 = 8;
		this.8 = 3;
		this.7 = (this.6 = 1052.20(4, this.9, this.8));
		this.3 = sliderControlClosure.2;
		this.15 = 2630.14;
		this.16 = new 1429.1431(1662.34, 5, 0.992f, this.15, (float)sliderControlClosure.2);
		this.16.10 = true;
		this.16.40 = new bool?(true);
		this.16.20 = new 208((float)sliderControlClosure.2 * 1.6f, 1.5f);
		this.17 = new 1433(1662.34, 5, 0.991f, true, this.15);
		this.17.40 = new bool?(true);
		this.17.10 = true;
		this.17.16 = 0.5f;
		this.17.20 = new 208((float)sliderControlClosure.2 * 1.6f, 1.5f);
		this.14 = new 1433(1455.2("circle-empty", (1416)1, null), (1376)6, 1065.Centre, (1044)0, this.11(), 0.99f, true, this.15, null);
		this.14.10 = true;
		this.14.29(delegate
		{
			float num = sliderControlClosure.1.14.50.X - sliderControlClosure.1.16.50.X;
			float num2 = (float)sliderControlClosure.1.14.35 / 1.6f / 2f;
			sliderControlClosure.1.16.20.X = Math.Max(0f, num / 1662.70.9());
			sliderControlClosure.1.17.20.X = Math.Max(0f, (float)sliderControlClosure.2 * 1.6f - (num + (float)sliderControlClosure.1.14.35) / 1662.70.9());
			sliderControlClosure.1.17.17.X = sliderControlClosure.1.14.17.X + num2;
		});
		this.13.Add(this.14);
		this.13.Add(this.16);
		this.13.Add(this.17);
		this.16.35(delegate(object 1, EventArgs 2)
		{
			if (this.3() && !this.1() && this.6())
			{
				this.15(true);
				this.13(true);
			}
		});
		this.16.37(new EventHandler(this.16));
		if (7 != null)
		{
			7.12(this.14);
			7.12(this.16);
			7.12(this.17);
		}
		this.28();
	}

	// Token: 0x06004C60 RID: 19552 RVA: 0x001E2B79 File Offset: 0x001E0D79
	public bool 1()
	{
		return this.1;
	}

	// Token: 0x06004C61 RID: 19553 RVA: 0x001E2B81 File Offset: 0x001E0D81
	public void 2(bool 1)
	{
		this.1 = 1;
	}

	// Token: 0x06004C62 RID: 19554 RVA: 0x001E2B8A File Offset: 0x001E0D8A
	internal bool 3()
	{
		return this.2;
	}

	// Token: 0x06004C63 RID: 19555 RVA: 0x001E2B92 File Offset: 0x001E0D92
	internal 208 4()
	{
		return this.16.17;
	}

	// Token: 0x06004C64 RID: 19556 RVA: 0x001E2B9F File Offset: 0x001E0D9F
	internal bool 5()
	{
		return this.4;
	}

	// Token: 0x06004C65 RID: 19557 RVA: 0x001E2BA7 File Offset: 0x001E0DA7
	internal bool 6()
	{
		return this.12 && this.14.19;
	}

	// Token: 0x06004C66 RID: 19558 RVA: 0x001E2BC0 File Offset: 0x001E0DC0
	internal void 7(bool 1)
	{
		if (this.12 != 1)
		{
			this.12 = 1;
			if (this.12)
			{
				this.14.FadeIn(100, (1046)0, 0);
				this.16.FadeIn(100, (1046)0, 0);
				this.17.FadeIn(100, (1046)0, 0);
				return;
			}
			this.14.16(100, (1046)0, 0);
			this.16.16(100, (1046)0, 0);
			this.17.16(100, (1046)0, 0);
			this.21();
		}
	}

	// Token: 0x06004C67 RID: 19559 RVA: 0x001E2C48 File Offset: 0x001E0E48
	internal void 8(string 1)
	{
		1433 2 = this.16;
		1433 3 = this.17;
		this.14.52 = 1;
		3.52 = 1;
		2.52 = 1;
	}

	// Token: 0x06004C68 RID: 19560 RVA: 0x001E2C80 File Offset: 0x001E0E80
	private 1058 9()
	{
		return new 1058(this.16.50.X, this.16.50.Y - this.14.50.Height / 2f, (float)this.3 * 1662.70.3(), this.14.50.Height);
	}

	// Token: 0x06004C69 RID: 19561 RVA: 0x001E2CEB File Offset: 0x001E0EEB
	private float 10()
	{
		return (float)((this.7 - this.9) / (this.8 - this.9));
	}

	// Token: 0x06004C6A RID: 19562 RVA: 0x001E2D09 File Offset: 0x001E0F09
	private 208 11()
	{
		return this.4() + new 208((float)this.3, 0f) * this.10();
	}

	// Token: 0x06004C6B RID: 19563 RVA: 0x001E2D34 File Offset: 0x001E0F34
	private double 12()
	{
		1058 <<EMPTY_NAME>> = this.9();
		return (double)(1555.21().X - <<EMPTY_NAME>>.X) / (double)<<EMPTY_NAME>>.Width * (this.8 - this.9);
	}

	// Token: 0x06004C6C RID: 19564 RVA: 0x001E2D70 File Offset: 0x001E0F70
	private void 13(bool 1)
	{
		if (1 == this.19)
		{
			return;
		}
		this.19 = 1;
		if (this.19)
		{
			1535.40((1082)8, new 1081(this.17), 1545.Highest, (1559)2);
			1535.40((1082)6, new 1081(this.19), 1545.Highest, (1559)2);
			1535.40((1082)3, new 1081(this.18), 1545.Highest, (1559)2);
			1549.5(new 1549.1551(this.20));
			return;
		}
		this.19(null, null);
		1535.41((1082)8, new 1081(this.17), 1545.Highest);
		1535.41((1082)6, new 1081(this.19), 1545.Highest);
		1535.41((1082)3, new 1081(this.18), 1545.Highest);
		1549.6(new 1549.1551(this.20));
	}

	// Token: 0x06004C6D RID: 19565 RVA: 0x001E2E37 File Offset: 0x001E1037
	internal bool 14()
	{
		return this.20;
	}

	// Token: 0x06004C6E RID: 19566 RVA: 0x001E2E3F File Offset: 0x001E103F
	private void 15(bool 1)
	{
		this.20 = 1;
	}

	// Token: 0x06004C6F RID: 19567 RVA: 0x001E2E48 File Offset: 0x001E1048
	private void 16(object 1, EventArgs 2)
	{
		this.15(false);
		if (!this.4)
		{
			this.13(false);
		}
	}

	// Token: 0x06004C70 RID: 19568 RVA: 0x001E2E60 File Offset: 0x001E1060
	private bool 17(object 1, EventArgs 2)
	{
		this.5 = 1555.21();
		return false;
	}

	// Token: 0x06004C71 RID: 19569 RVA: 0x001E2E70 File Offset: 0x001E1070
	private bool 18(object 1, EventArgs 2)
	{
		if (!this.4)
		{
			208 3 = (1555.21() - this.5) * 1662.70.8();
			if (Math.Abs(3.Y) >= 5f)
			{
				this.5.Y = float.NegativeInfinity;
				return false;
			}
			if ((double)Math.Abs(3.X) <= 2.5 || Math.Abs(3.Y) >= 5f)
			{
				return false;
			}
			this.4 = true;
		}
		this.24();
		return true;
	}

	// Token: 0x06004C72 RID: 19570 RVA: 0x001E2F04 File Offset: 0x001E1104
	private bool 19(object 1, EventArgs 2)
	{
		208 3 = (1555.21() - this.5) * 1662.70.8();
		if (this.4 || Math.Abs(3.Y) < 5f)
		{
			this.4 = false;
			this.5.Y = float.NegativeInfinity;
			this.24();
			if (this.18 != null)
			{
				this.18(true);
			}
		}
		if (!this.16.IsHovered())
		{
			this.13(false);
		}
		return false;
	}

	// Token: 0x06004C73 RID: 19571 RVA: 0x001E2F94 File Offset: 0x001E1194
	private bool 20(object 1, 200 2, bool 3)
	{
		if (!this.10)
		{
			return false;
		}
		if (this.5())
		{
			return true;
		}
		if (2 == 200.Left)
		{
			this.23(this.7 - this.11, false, true);
			return true;
		}
		if (2 != 200.Right)
		{
			return false;
		}
		this.23(this.7 + this.11, false, true);
		return true;
	}

	// Token: 0x06004C74 RID: 19572 RVA: 0x001E2FF0 File Offset: 0x001E11F0
	public void Dispose()
	{
		this.21();
	}

	// Token: 0x06004C75 RID: 19573 RVA: 0x001E2FF8 File Offset: 0x001E11F8
	internal void 21()
	{
		this.4 = false;
		this.13(false);
	}

	// Token: 0x06004C76 RID: 19574 RVA: 0x001E3008 File Offset: 0x001E1208
	internal void 22(double 1, double 2, double 3)
	{
		this.9 = 1;
		this.8 = 2;
		this.23(3, true, false);
	}

	// Token: 0x06004C77 RID: 19575 RVA: 0x001E3024 File Offset: 0x001E1224
	internal void 23(double 1, bool 2, bool 3)
	{
		1 = 1052.20(1, this.9, this.8);
		if (this.7 != 1)
		{
			this.7 = 1;
			if (!2)
			{
				if (this.18 != null)
				{
					this.18(3);
				}
				if (this.5() || 3)
				{
					1226.20(null, "sliderbar", 1f + this.10() * 0.2f, false);
				}
			}
		}
		this.28();
	}

	// Token: 0x06004C78 RID: 19576 RVA: 0x001E30A2 File Offset: 0x001E12A2
	private void 24()
	{
		if (this.6())
		{
			this.23(this.9 + this.12(), false, false);
		}
	}

	// Token: 0x06004C79 RID: 19577 RVA: 0x001E30C4 File Offset: 0x001E12C4
	internal bool 25()
	{
		1058 <<EMPTY_NAME>> = this.9();
		<<EMPTY_NAME>>.Y -= <<EMPTY_NAME>>.Height / 2f;
		<<EMPTY_NAME>>.Height *= 2f;
		return this.6() && <<EMPTY_NAME>>.7(1555.21());
	}

	// Token: 0x06004C7A RID: 19578 RVA: 0x001E3118 File Offset: 0x001E1318
	internal bool 26(int 1)
	{
		if (this.21 <= 0.0 || this.1 || !this.2 || !this.25())
		{
			return false;
		}
		this.23(Math.Round((this.7 + (double)1 * this.21) / this.21) * this.21, false, true);
		return true;
	}

	// Token: 0x06004C7B RID: 19579 RVA: 0x001E317C File Offset: 0x001E137C
	internal void 27()
	{
		this.24();
	}

	// Token: 0x06004C7C RID: 19580 RVA: 0x001E3184 File Offset: 0x001E1384
	private void 28()
	{
		int num = this.14.19 ? 100 : 0;
		this.14.7 = this.11() + (this.16.7 - this.16.17);
		this.14.19(this.11(), num, (1046)1);
	}

	// Token: 0x040038D6 RID: 14550
	private bool 1;

	// Token: 0x040038D7 RID: 14551
	private bool 2 = true;

	// Token: 0x040038D8 RID: 14552
	internal int 3;

	// Token: 0x040038D9 RID: 14553
	private bool 4;

	// Token: 0x040038DA RID: 14554
	private 208 5;

	// Token: 0x040038DB RID: 14555
	internal readonly double 6;

	// Token: 0x040038DC RID: 14556
	internal double 7;

	// Token: 0x040038DD RID: 14557
	internal double 8;

	// Token: 0x040038DE RID: 14558
	internal double 9;

	// Token: 0x040038DF RID: 14559
	internal bool 10;

	// Token: 0x040038E0 RID: 14560
	internal double 11 = 1.0;

	// Token: 0x040038E1 RID: 14561
	private bool 12 = true;

	// Token: 0x040038E2 RID: 14562
	internal List<1433> 13 = new List<1433>();

	// Token: 0x040038E3 RID: 14563
	internal 1433 14;

	// Token: 0x040038E4 RID: 14564
	private 198 15;

	// Token: 0x040038E5 RID: 14565
	private 1433 16;

	// Token: 0x040038E6 RID: 14566
	private 1433 17;

	// Token: 0x040038E7 RID: 14567
	internal 1429.1432 18;

	// Token: 0x040038E8 RID: 14568
	private bool 19;

	// Token: 0x040038E9 RID: 14569
	private bool 20;

	// Token: 0x040038EA RID: 14570
	internal double 21;

	// Token: 0x02000AC2 RID: 2754
	// (Invoke) Token: 0x06004C7F RID: 19583
	public delegate void 1432(bool 1);

	// Token: 0x02000AC3 RID: 2755
	public sealed class 1430
	{
		// Token: 0x040038EB RID: 14571
		public 1429 1;

		// Token: 0x040038EC RID: 14572
		public int 2;
	}

	// Token: 0x02000AC4 RID: 2756
	public sealed class 1431 : 1433
	{
		// Token: 0x06004C83 RID: 19587 RVA: 0x001E3211 File Offset: 0x001E1411
		internal 1431(1381 1, 208 2, float 3, 198 4, float 5) : base(1, 2, 3, true, 4)
		{
			this.70 = 5;
		}

		// Token: 0x06004C84 RID: 19588 RVA: 0x001E3228 File Offset: 0x001E1428
		internal override bool ContainsPoint(208 1, int 2 = 0)
		{
			float height = this.50.Height;
			1058 3 = this.50;
			3.Y -= height * 7f;
			3.Height += height * 14f;
			3.Width = this.70 * 1662.70.3();
			return 3.7(1);
		}

		// Token: 0x040038ED RID: 14573
		private float 70;
	}
}
