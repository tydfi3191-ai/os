using System;
using System.Collections.Generic;

// Token: 0x020004F7 RID: 1271
[276]
public class 2562 : IDisposable
{
	// Token: 0x060026D8 RID: 9944 RVA: 0x000C0504 File Offset: 0x000BE704
	internal 2562(int 1, 2481 2, 208 3, bool 4)
	{
		1455.2("scoreboard-explosion-1", (1416)1, null);
		1455.2("scoreboard-explosion-2", (1416)1, null);
		this.4 = 4;
		this.1 = 1;
		this.3 = 3;
		if (2 != null)
		{
			this.SetCurrentItem(2);
		}
	}

	// Token: 0x060026D9 RID: 9945 RVA: 0x000C05A4 File Offset: 0x000BE7A4
	internal virtual void SetCurrentItem(2481 1)
	{
		this.10 = 1;
		if (!this.2.Contains(this.10))
		{
			this.1(this.10);
		}
		this.10.7.6 = new 198(250, 250, 250, 100);
	}

	// Token: 0x060026DA RID: 9946 RVA: 0x000C0600 File Offset: 0x000BE800
	internal void 1(2481 1)
	{
		this.2.Add(1);
		if (this.2())
		{
			1.2(this.2());
		}
		1.21 = this;
		if (1.20)
		{
			if (1.5 == 0 && this.13)
			{
				1.7.6 = new 198(97, 190, byte.MaxValue, 150);
			}
			else
			{
				1.7.6 = new 198(31, 115, 153, 150);
			}
		}
		this.8.14<1433>(1.8);
	}

	// Token: 0x060026DB RID: 9947 RVA: 0x000C06A0 File Offset: 0x000BE8A0
	internal virtual bool SortAndLayout(bool 1)
	{
		this.2.Sort();
		bool result = false;
		if (this.10 != null)
		{
			int num = this.2.IndexOf(this.10);
			bool flag = this.10.1() || this.2();
			float num2 = (float)((!flag) ? 1 : -1);
			1065 2 = flag ? 1065.CentreRight : 1065.CentreLeft;
			if (num < this.6)
			{
				this.10.7.40(198.White, 200);
				1433 3 = new 1433(1455.2("scoreboard-explosion-2", (1416)1, null), 2, this.10.7.17 + new 208(0f, 15f), 0.99f, false, 198.White);
				3.41 = this.10.7.41;
				3.28 = true;
				3.16(400, (1046)0, 0);
				3.3.Add(new 1445(1456.VectorScale, new 208(num2, 1f), new 208(num2 * 6f, 1.2f), 1662.33, 1662.33 + 200, (1046)1));
				this.8.12(3);
				1433 4 = new 1433(1455.2("scoreboard-explosion-1", (1416)1, null), 2, this.10.7.17 + new 208(0f, 15f), 1f, false, 198.White);
				4.41 = this.10.7.41;
				4.16(700, (1046)0, 0);
				4.28 = true;
				4.3.Add(new 1445(1456.VectorScale, new 208(num2, 1f), new 208(num2, 1.3f), 1662.33, 1662.33 + 700, (1046)1));
				this.8.12(4);
				if (flag)
				{
					3.45(true);
					4.45(true);
				}
			}
			result = (num != this.6);
			this.6 = num;
			this.4(1);
		}
		return result;
	}

	// Token: 0x060026DC RID: 9948 RVA: 0x000C08D1 File Offset: 0x000BEAD1
	internal bool 2()
	{
		return this.15;
	}

	// Token: 0x060026DD RID: 9949 RVA: 0x000C08D9 File Offset: 0x000BEAD9
	internal void 3(bool 1)
	{
		this.15 = 1;
		this.2.ForEach(new Action<2481>(this.7));
	}

	// Token: 0x060026DE RID: 9950 RVA: 0x000C08FC File Offset: 0x000BEAFC
	internal void 4(bool 1)
	{
		int num = this.2.IndexOf(this.10);
		int num2 = (num > this.1 - 1) ? (num - (this.1 - 1)) : 0;
		if (this.13 && num2 > 0)
		{
			num2++;
		}
		int num3 = 0;
		int num4 = 0;
		int num5;
		if (1535.1() && !1535.40)
		{
			2023 2 = 2486.88.8;
			2023 3 = 2023.Autoplay;
			if ((2 & 3) <= 2023.None)
			{
				num5 = this.11 - 1;
				goto IL_84;
			}
		}
		num5 = this.2.Count - 1;
		IL_84:
		int num6 = num5;
		if (!1535.1() && this.2.Count > 0 && this.2[this.2.Count - 1].16 != null && this.2[this.2.Count - 1].16 == 1272.5().68)
		{
			num6--;
		}
		int num7 = 1;
		for (int i = 0; i < this.2.Count; i++)
		{
			2481 4 = this.2[i];
			bool flag = this.2[i].1() || this.2();
			int num8 = flag ? num4 : num3;
			bool flag2 = (i >= num2 && num8 < this.1) || (this.13 && i == 0);
			if (flag2 && this.5 && 4 != this.10 && 4.20)
			{
				4.23 = 0.8f - (float)i / (float)this.11 * 0.3f;
			}
			if (i > 0 && (!this.14 || this.2[i - 1].6 != 4.6))
			{
				num7++;
			}
			if (this.16)
			{
				4.5 = num7;
				if (4.3())
				{
					4.SetBigNumber((1304.164 != 1289.Friends && 1304.164 != 1289.Local && 4.5 > num6) ? -1 : (i + 1));
				}
			}
			4.5(this.3 + this.7 * (float)num8, flag2, 1);
			if (flag2)
			{
				if (flag)
				{
					num4++;
				}
				else
				{
					num3++;
				}
			}
		}
	}

	// Token: 0x060026DF RID: 9951 RVA: 0x000C0B61 File Offset: 0x000BED61
	internal void 5()
	{
		this.8.22();
	}

	// Token: 0x060026E0 RID: 9952 RVA: 0x000C0B70 File Offset: 0x000BED70
	public void 6(string 1)
	{
		if (this.9 != null)
		{
			this.9.16(100, (1046)0, 0);
		}
		this.9 = new 1452(1, 12f, this.3 + (this.2() ? this.12 : 208.Zero) - new 208(0f, 5f), 1f, false, 198.White);
		this.9.49 = 1065.BottomLeft;
		this.9.54(true);
		this.9.16(6000, (1046)0, 0);
		this.8.12(this.9);
	}

	// Token: 0x060026E1 RID: 9953 RVA: 0x000C0C1F File Offset: 0x000BEE1F
	public void Dispose()
	{
		if (this.8 != null)
		{
			this.8.Dispose();
		}
	}

	// Token: 0x060026E2 RID: 9954 RVA: 0x000C0C34 File Offset: 0x000BEE34
	private void 7(2481 1)
	{
		1.2(this.15);
	}

	// Token: 0x04001BD7 RID: 7127
	internal readonly int 1;

	// Token: 0x04001BD8 RID: 7128
	internal readonly List<2481> 2 = new List<2481>();

	// Token: 0x04001BD9 RID: 7129
	internal 208 3;

	// Token: 0x04001BDA RID: 7130
	internal bool 4;

	// Token: 0x04001BDB RID: 7131
	internal bool 5;

	// Token: 0x04001BDC RID: 7132
	private int 6;

	// Token: 0x04001BDD RID: 7133
	internal 208 7 = new 208(0f, 36f);

	// Token: 0x04001BDE RID: 7134
	internal 1436 8 = new 1436(true);

	// Token: 0x04001BDF RID: 7135
	private 1452 9;

	// Token: 0x04001BE0 RID: 7136
	internal 2481 10;

	// Token: 0x04001BE1 RID: 7137
	internal int 11;

	// Token: 0x04001BE2 RID: 7138
	internal 208 12 = new 208((float)(1662.70.1() - 115), 0f);

	// Token: 0x04001BE3 RID: 7139
	public bool 13;

	// Token: 0x04001BE4 RID: 7140
	public bool 14;

	// Token: 0x04001BE5 RID: 7141
	private bool 15;

	// Token: 0x04001BE6 RID: 7142
	internal bool 16 = true;
}
