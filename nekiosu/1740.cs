using System;
using System.Collections.Generic;

// Token: 0x020008A4 RID: 2212
public sealed class 1740 : 2535
{
	// Token: 0x06003F49 RID: 16201 RVA: 0x00188744 File Offset: 0x00186944
	internal 1740(1333 1) : base(true)
	{
		this.3();
		this.20 = 1;
		1.1(new 1189(this.8));
		1304.89.SubscribeChanged(new EventHandler(this.9));
		this.4();
	}

	// Token: 0x06003F4A RID: 16202 RVA: 0x00188831 File Offset: 0x00186A31
	private new bool 1()
	{
		return this.12;
	}

	// Token: 0x06003F4B RID: 16203 RVA: 0x0018883C File Offset: 0x00186A3C
	private void 2(bool 1)
	{
		if (1 != this.12)
		{
			this.12 = 1;
			if (this.12)
			{
				this.18.24(0.8f, 10000, (1046)0);
				this.17.16(400, (1046)0, 4000);
				this.3.16(400, (1046)0, 4000);
				this.4.16(400, (1046)0, 4000);
				return;
			}
			this.18.FadeIn(200, (1046)0, 0);
			this.17.FadeIn(1000, (1046)0, 0);
			this.3.FadeIn(1000, (1046)0, 0);
			this.4.FadeIn(1000, (1046)0, 0);
		}
	}

	// Token: 0x06003F4C RID: 16204 RVA: 0x00188908 File Offset: 0x00186B08
	internal void 3()
	{
		1436 <<EMPTY_NAME>> = this.15;
		1353 2 = new 1353(string.Empty, "fps", 1f, (1376)14, 1065.Centre, (1044)0, new 208(35f, 25f), 1f, true, 198.White, true, (1416)1)
		{
			96 = true,
			40 = new bool?(true)
		};
		1452 3 = 2;
		this.3 = 2;
		<<EMPTY_NAME>>.12(3);
		1436 4 = this.15;
		1353 5 = new 1353(string.Empty, "fpss", 1f, (1376)14, 1065.TopLeft, (1044)0, new 208(29f, 25f), 1f, true, 198.White, true, (1416)1)
		{
			96 = true,
			40 = new bool?(true)
		};
		3 = 5;
		this.4 = 5;
		4.12(3);
		this.15.12(this.17 = new 1433(1455.2("fps-box", (1416)1, null), (1376)14, 1065.Centre, (1044)0, new 208(23f, 25f), 0.8f, true, 198.Black, null));
		1436 6 = this.15;
		1353 7 = new 1353(string.Empty, "fps", 1f, (1376)14, 1065.Centre, (1044)0, new 208(23f, 10f), 1f, true, 198.White, true, (1416)1)
		{
			96 = true,
			40 = new bool?(true)
		};
		3 = 7;
		this.5 = 7;
		6.12(3);
		this.15.12(this.18 = new 1433(1455.2("fps-box", (1416)1, null), (1376)14, 1065.Centre, (1044)0, new 208(23f, 10f), 0.8f, true, 198.Black, null));
		for (int i = 0; i < 10; i++)
		{
			this.10.Add(new 1433(1455.2("fps-dropped", (1416)1, null), (1376)14, 1065.Centre, (1044)0, new 208((float)(49 + i * 7), 6f), 0.8f, true, 198.TransparentWhite, null)
			{
				6 = ((i == 0) ? this.8 : ((i < 3) ? this.7 : this.6))
			});
		}
		this.15.14<1433>(this.10);
		this.4();
	}

	// Token: 0x06003F4D RID: 16205 RVA: 0x00188B43 File Offset: 0x00186D43
	private void 4()
	{
		this.3.SetText("0");
		this.16 = 0.0;
	}

	// Token: 0x06003F4E RID: 16206 RVA: 0x00188B64 File Offset: 0x00186D64
	internal override void Draw()
	{
		if (1304.89)
		{
			this.15.22();
			base.Draw();
		}
	}

	// Token: 0x06003F4F RID: 16207 RVA: 0x00188B84 File Offset: 0x00186D84
	internal override void Update()
	{
		if (1304.89 && (1535.32 || this.20.7 != 0.0))
		{
			base.Update();
			double num = Math.Pow(0.05, 1662.82 / 1000.0);
			double num2 = 1662.34();
			char c = '\\';
			if (num2 > 1000.0)
			{
				num2 = (double)1662.72;
				c = '+';
			}
			double num3 = (double)1662.115 % num2;
			if (Math.Abs(this.20.7 - this.16) > 0.5)
			{
				this.16 = this.16 * num + Math.Min(num2, this.20.7) * (1.0 - num);
				this.3.SetText(string.Format("{0:#,#}\\", (int)Math.Round(this.16)));
				this.4.SetText("/" + num2.ToString() + c.ToString());
			}
			this.2(Math.Abs(this.16 - num2) < 0.5);
			if (this.20.8 >= 10.0)
			{
				this.5.SetText(this.20.8.ToString("0") + "=");
			}
			else if (this.20.8 >= 1.0)
			{
				this.5.SetText(this.20.8.ToString("0.0") + "=");
			}
			else
			{
				this.5.SetText(this.20.8.ToString("0.00") + "=");
			}
			if (this.1())
			{
				this.17.6 = this.9;
			}
			else if (this.16 > num2 - 10.0 && this.16 > num2 * 0.949999988079071)
			{
				this.17.6 = this.8;
			}
			else
			{
				this.17.6 = this.7;
			}
			if (this.20.8 < 8.0)
			{
				this.18.6 = this.9;
			}
			else if (this.20.8 < 16.0)
			{
				this.18.6 = this.8;
			}
			else
			{
				this.18.6 = this.7;
			}
			this.5();
		}
	}

	// Token: 0x06003F50 RID: 16208 RVA: 0x00188E40 File Offset: 0x00187040
	private void 5()
	{
		double num = this.11;
		if (this.21)
		{
			num = Math.Min(10.0, Math.Ceiling(num + 1.0));
			this.21 = false;
		}
		else
		{
			num = Math.Max(0.0, num - 1662.82 / 800.0);
		}
		int num2 = (int)Math.Ceiling(this.11);
		int num3 = (int)Math.Ceiling(num);
		if (num3 < num2)
		{
			for (int i = num3; i < 10; i++)
			{
				this.10[num3].16(200, (1046)0, (int)((double)num3 * 320.0));
			}
		}
		else if (num3 > num2)
		{
			this.10[num3 - 1].FadeIn(40, (1046)0, 0);
		}
		this.11 = num;
	}

	// Token: 0x06003F51 RID: 16209 RVA: 0x00188F14 File Offset: 0x00187114
	internal void 6(object 1, int 2)
	{
		1740.1742 3 = new 1740.1742();
		if (2 == 0)
		{
			this.13.Remove(1);
		}
		else
		{
			this.13[1] = (float)2;
		}
		3.1 = 0;
		foreach (float num in this.13.Values)
		{
			int num2 = (int)num;
			if (num2 > 3.1)
			{
				3.1 = num2;
			}
		}
		this.15.28.ForEach(new Action<1371>(3.1));
	}

	// Token: 0x06003F52 RID: 16210 RVA: 0x00188FC0 File Offset: 0x001871C0
	internal void 7(object 1, int 2)
	{
		1740.1741 3 = new 1740.1741();
		if (2 == 0)
		{
			this.14.Remove(1);
		}
		else
		{
			this.14[1] = (float)2;
		}
		3.1 = 0;
		foreach (float num in this.14.Values)
		{
			int num2 = (int)num;
			if (num2 > 3.1)
			{
				3.1 = num2;
			}
		}
		this.15.28.ForEach(new Action<1371>(3.1));
	}

	// Token: 0x06003F53 RID: 16211 RVA: 0x0018906C File Offset: 0x0018726C
	private void 8()
	{
		this.21 = true;
	}

	// Token: 0x06003F54 RID: 16212 RVA: 0x00189075 File Offset: 0x00187275
	private void 9(object 1, EventArgs 2)
	{
		this.4();
	}

	// Token: 0x04002E48 RID: 11848
	private 1452 3;

	// Token: 0x04002E49 RID: 11849
	private 1452 4;

	// Token: 0x04002E4A RID: 11850
	private 1452 5;

	// Token: 0x04002E4B RID: 11851
	private 198 6 = new 198(byte.MaxValue, 36, 0);

	// Token: 0x04002E4C RID: 11852
	private 198 7 = new 198(byte.MaxValue, 149, 24);

	// Token: 0x04002E4D RID: 11853
	private 198 8 = new 198(byte.MaxValue, 204, 34);

	// Token: 0x04002E4E RID: 11854
	private 198 9 = new 198(172, 220, 25);

	// Token: 0x04002E4F RID: 11855
	private List<1433> 10 = new List<1433>();

	// Token: 0x04002E50 RID: 11856
	private double 11;

	// Token: 0x04002E51 RID: 11857
	private bool 12;

	// Token: 0x04002E52 RID: 11858
	private Dictionary<object, float> 13 = new Dictionary<object, float>();

	// Token: 0x04002E53 RID: 11859
	private Dictionary<object, float> 14 = new Dictionary<object, float>();

	// Token: 0x04002E54 RID: 11860
	private 1436 15 = new 1436(true)
	{
		47 = true
	};

	// Token: 0x04002E55 RID: 11861
	private double 16;

	// Token: 0x04002E56 RID: 11862
	private 1433 17;

	// Token: 0x04002E57 RID: 11863
	private 1433 18;

	// Token: 0x04002E58 RID: 11864
	private 1381 19 = 1455.2("fps-drop", (1416)1, null);

	// Token: 0x04002E59 RID: 11865
	private 1333 20;

	// Token: 0x04002E5A RID: 11866
	private bool 21;

	// Token: 0x020008A5 RID: 2213
	public sealed class 1742
	{
		// Token: 0x06003F55 RID: 16213 RVA: 0x0018907D File Offset: 0x0018727D
		internal void 1(1371 1)
		{
			1.21(1.7.Y + (float)this.1, 300, (1046)1);
		}

		// Token: 0x04002E5B RID: 11867
		public int 1;
	}

	// Token: 0x020008A6 RID: 2214
	public sealed class 1741
	{
		// Token: 0x06003F57 RID: 16215 RVA: 0x0018909E File Offset: 0x0018729E
		internal void 1(1371 1)
		{
			1.20(1.7.X + (float)this.1, 300, (1046)1);
		}

		// Token: 0x04002E5C RID: 11868
		public int 1;
	}
}
