using System;
using System.Collections.Generic;

// Token: 0x02000551 RID: 1361
public class 2481 : IComparable<2481>
{
	// Token: 0x060029CB RID: 10699 RVA: 0x000D93A8 File Offset: 0x000D75A8
	internal 2481(int 1, 2241 2, 2147 3) : this(1, 2.23, 3)
	{
		this.17 = true;
		this.SetScore(2, null);
	}

	// Token: 0x060029CC RID: 10700 RVA: 0x000D93DC File Offset: 0x000D75DC
	internal 2481(int 1, string 2, 2147 3)
	{
		this.5 = 1;
		this.12 = 3;
		this.4 = (2 ?? "-");
		this.3 = 2481.2++;
		float num = 0.92f;
		this.7 = new 1433(1455.2("menu-button-background", (1416)7, null), (1376)6, 1065.Custom, (1044)0, 208.Zero, num, true, new 198(0, 0, 0, 150), null)
		{
			16 = 0f,
			15 = 0.62f
		};
		this.1 = new 1452(2, 14f, new 208(0f, -2f), 208.Zero, num + 3E-06f, true, new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 0), true);
		this.9 = new 1353(string.Empty, "scoreentry", 2.5f, (1376)6, 1065.TopLeft, (1044)0, new 208(2f, 18f), num + 3E-06f, true, new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 0), true, (1416)7)
		{
			96 = true
		};
		this.10 = new 1353(string.Empty, "scoreentry", 2.5f, (1376)6, 1065.TopRight, (1044)0, new 208(82f, 18f), num + 3E-06f, true, new 198(153, 251, byte.MaxValue, 0), true, (1416)7)
		{
			96 = true
		};
		this.11 = new 1353((1 > 0) ? 1.ToString() : string.Empty, "scoreentry", 3f, (1376)6, 1065.TopRight, (1044)0, new 208(82f, -2f), num + 2E-06f, true, new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 80), true, (1416)7)
		{
			15 = 2.2f,
			16 = 0f
		};
		this.8 = new List<1433>
		{
			this.7,
			this.1,
			this.9,
			this.10,
			this.11
		};
		this.UpdateLayout();
	}

	// Token: 0x060029CD RID: 10701 RVA: 0x000D9627 File Offset: 0x000D7827
	internal bool 1()
	{
		return this.15.GetValueOrDefault();
	}

	// Token: 0x060029CE RID: 10702 RVA: 0x000D9634 File Offset: 0x000D7834
	internal void 2(bool 1)
	{
		this.15 = new bool?(1);
		this.UpdateLayout();
	}

	// Token: 0x060029CF RID: 10703 RVA: 0x000D9648 File Offset: 0x000D7848
	protected virtual void UpdateLayout()
	{
		this.1.49 = (this.9.49 = (this.1() ? 1065.TopRight : 1065.TopLeft));
		this.11.49 = (this.10.49 = ((!this.1()) ? 1065.TopRight : 1065.TopLeft));
		this.7.48 = (this.1() ? new 208(230f, 20f) : new 208(470f, 20f));
		this.8.ForEach(delegate(1433 1)
		{
			1.41 = (this.1() ? ((1376)8) : ((1376)6));
			1.UpdateOriginOffset();
		});
	}

	// Token: 0x060029D0 RID: 10704 RVA: 0x000D96EC File Offset: 0x000D78EC
	public int CompareTo(2481 1)
	{
		if (1 == this)
		{
			return 0;
		}
		if (this.3() != 1.3())
		{
			if (!this.3())
			{
				return 1;
			}
			return -1;
		}
		else
		{
			int num = 1.6.CompareTo(this.6);
			if (num != 0)
			{
				return num;
			}
			num = this.4.CompareTo(1.4);
			if (num != 0)
			{
				return num;
			}
			if (this.3 <= 1.3)
			{
				return -1;
			}
			return 1;
		}
	}

	// Token: 0x060029D1 RID: 10705 RVA: 0x000D975A File Offset: 0x000D795A
	internal bool 3()
	{
		return this.19;
	}

	// Token: 0x060029D2 RID: 10706 RVA: 0x000D9764 File Offset: 0x000D7964
	internal void 4(bool 1)
	{
		if (1 != this.19)
		{
			this.19 = 1;
			this.1.39(this.19 ? 198.White : new 198(236, 39, 81), 150, false, (1046)0);
		}
	}

	// Token: 0x060029D3 RID: 10707 RVA: 0x000D97B4 File Offset: 0x000D79B4
	internal void 5(208 1, bool 2, bool 3)
	{
		int num = (!3) ? 600 : 0;
		208 4 = 1 - (this.8[0].17 - this.22);
		foreach (1433 5 in this.8)
		{
			if (this.14 != 2)
			{
				if (2)
				{
					5.24(this.23, num, (1046)0);
				}
				else
				{
					5.16(num, (1046)0, 0);
				}
			}
			if (3)
			{
				5.3.RemoveAll(new Predicate<1445>(2481.2482.instance.1));
				5.17 += 4;
			}
			else
			{
				5.19(5.17 + 4, num, (1046)1);
			}
		}
		if (2 && !this.18)
		{
			bool flag = false;
			while (this.1.GetTextSize().X > 90f)
			{
				this.1.SetText(this.1.GetText().Remove(this.1.GetText().Length - 1));
				flag = true;
			}
			if (flag)
			{
				1452 6 = this.1;
				6.SetText(6.GetText() + "...");
			}
			this.18 = true;
		}
		this.14 = 2;
	}

	// Token: 0x060029D4 RID: 10708 RVA: 0x000D9920 File Offset: 0x000D7B20
	internal virtual void SetScore(2241 1, int? 2)
	{
		this.16 = 1;
		this.6 = (2 ?? 1.GetScore());
		int num = this.17 ? 1.13 : ((int)1.36);
		this.9.SetText((this.6 > 0) ? this.6.ToString("#,#", 1662.18) : "-");
		this.10.SetText(num.ToString("#,#", 1662.18) + ((num > 0) ? "x" : string.Empty));
		if (this.17)
		{
			return;
		}
		198 3 = this.7.6;
		if (1.18)
		{
			if (1.35 > 0.0)
			{
				3 = new 198((byte)(200.0 - 1.35), 20, (byte)1.35, this.7.6.A);
			}
		}
		else
		{
			3 = new 198(80, 80, 80, this.7.6.A);
		}
		this.7.39(3, 50, false, (1046)0);
	}

	// Token: 0x060029D5 RID: 10709 RVA: 0x000D9A5B File Offset: 0x000D7C5B
	internal virtual void SetBigNumber(int 1)
	{
		if (this.20)
		{
			this.11.SetText((1 <= 0) ? string.Empty : 1.ToString());
		}
	}

	// Token: 0x060029D6 RID: 10710 RVA: 0x000D9A84 File Offset: 0x000D7C84
	internal void 6()
	{
		foreach (1433 <<EMPTY_NAME>> in this.8)
		{
			<<EMPTY_NAME>>.16(0, (1046)0, 0);
		}
		this.7.16(0, (1046)0, 0);
		this.9.16(0, (1046)0, 0);
		this.1.16(0, (1046)0, 0);
		this.11.16(0, (1046)0, 0);
	}

	// Token: 0x04001E63 RID: 7779
	internal readonly 1452 1;

	// Token: 0x04001E64 RID: 7780
	private static int 2;

	// Token: 0x04001E65 RID: 7781
	private int 3;

	// Token: 0x04001E66 RID: 7782
	internal string 4;

	// Token: 0x04001E67 RID: 7783
	internal int 5;

	// Token: 0x04001E68 RID: 7784
	internal int 6;

	// Token: 0x04001E69 RID: 7785
	internal 1433 7;

	// Token: 0x04001E6A RID: 7786
	internal List<1433> 8;

	// Token: 0x04001E6B RID: 7787
	protected 1353 9;

	// Token: 0x04001E6C RID: 7788
	protected 1353 10;

	// Token: 0x04001E6D RID: 7789
	protected 1353 11;

	// Token: 0x04001E6E RID: 7790
	internal 2147 12;

	// Token: 0x04001E6F RID: 7791
	internal 2023 13;

	// Token: 0x04001E70 RID: 7792
	internal bool 14;

	// Token: 0x04001E71 RID: 7793
	private bool? 15;

	// Token: 0x04001E72 RID: 7794
	internal 2241 16;

	// Token: 0x04001E73 RID: 7795
	internal bool 17;

	// Token: 0x04001E74 RID: 7796
	private bool 18;

	// Token: 0x04001E75 RID: 7797
	private bool 19 = true;

	// Token: 0x04001E76 RID: 7798
	internal bool 20 = true;

	// Token: 0x04001E77 RID: 7799
	internal 2562 21;

	// Token: 0x04001E78 RID: 7800
	protected 208 22;

	// Token: 0x04001E79 RID: 7801
	internal float 23 = 1f;

	// Token: 0x02000552 RID: 1362
	[Serializable]
	public sealed class 2482
	{
		// Token: 0x060029D8 RID: 10712 RVA: 0x000BA3D9 File Offset: 0x000B85D9
		internal bool 1(1445 1)
		{
			return 1.14 == 1456.Movement;
		}

		// Token: 0x04001E7A RID: 7802
		public static readonly 2481.2482 instance = new 2481.2482();

		// Token: 0x04001E7B RID: 7803
		public static Predicate<1445> isMovementPredicate;
	}
}
