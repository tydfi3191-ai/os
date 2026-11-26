using System;
using System.Collections.Generic;
using System.Globalization;

// Token: 0x020004DE RID: 1246
[276]
internal sealed class 2493 : 1689
{
	// Token: 0x1700024F RID: 591
	// (get) Token: 0x0600263E RID: 9790 RVA: 0x000BA7CE File Offset: 0x000B89CE
	internal static bool IsOpen
	{
		get
		{
			return 2493.18 > 0;
		}
	}

	// Token: 0x0600263F RID: 9791 RVA: 0x000BA7D8 File Offset: 0x000B89D8
	internal 2493(List<1383.1384> 1 = null) : base("Gamma by AR", true)
	{
		2493.18++;
		this.19.Sort(delegate(1383.1384 1, 1383.1384 2)
		{
			int num2 = Math.Min(1.1, 1.2).CompareTo(Math.Min(2.1, 2.2));
			if (num2 == 0)
			{
				return Math.Max(1.1, 1.2).CompareTo(Math.Max(2.1, 2.2));
			}
			return num2;
		});
		1383.Set(this.19);
		if (3 != null)
		{
			this.19.AddRange(3);
		}
		float num = (float)1662.70.1() / 2f;
		for (int i = 0; i < this.19.Count; i++)
		{
			this.12(i, num);
			this.3 += 30f;
		}
		if (this.19.Count < 6)
		{
			1452 4 = new 1452("add range", 14f, new 208(num - 250f, this.3), 0.94f, true, 198.Gray);
			4.49 = 1065.CentreLeft;
			4.10 = true;
			4.42 = new 1445(198.Gray, 198.White, 0, 100);
			4.3(delegate(object 1, EventArgs 2)
			{
				this.19.Add(new 1383.1384
				{
					1 = double.NaN,
					2 = double.NaN,
					3 = 1.0
				});
				this.13();
			});
			this.7.12(4);
			this.3 += 30f;
		}
		this.21 = new 1452(string.Empty, 14f, new 208(0f, this.3), 208.Zero, 0.94f, true, 198.White, true)
		{
			41 = (1376)7,
			49 = 1065.Centre
		};
		this.7.12(this.21);
		this.3 += 35f;
		base.7("Back", 198.Gray, null, true, false, true);
		base.3(delegate(object 1, EventArgs 2)
		{
			2493.18 = Math.Max(0, 2493.18 - 1);
			if (!this.24)
			{
				1383.Set(this.19);
			}
		});
		this.Refresh();
	}

	// Token: 0x06002640 RID: 9792 RVA: 0x000BA9C4 File Offset: 0x000B8BC4
	private void 12(int 1, float 2)
	{
		1383.1384 3 = this.19[8];
		1452 4 = new 1452("AR", 16f, new 208(9 - 250f, this.3), 0.94f, true, 198.White);
		4.49 = 1065.CentreLeft;
		this.7.12(4);
		2493.2494 row = new 2493.2494();
		row.1 = new 1448(double.IsNaN(3.1) ? string.Empty : 1383.4(3.1), 14f, new 208(9 - 220f, this.3 - 9f), 55f, 0.95f, false);
		row.1.4 = 6;
		this.7.14<1433>(row.1.2);
		1452 5 = new 1452("to", 14f, new 208(9 - 157f, this.3), 0.94f, true, 198.LightGray);
		5.49 = 1065.CentreLeft;
		this.7.12(5);
		row.2 = new 1448(double.IsNaN(3.2) ? string.Empty : 1383.4(3.2), 14f, new 208(9 - 135f, this.3 - 9f), 55f, 0.95f, false);
		row.2.4 = 6;
		this.7.14<1433>(row.2.2);
		row.3 = new 1429(this.7, 0.1, 3.0, 3.3, new 208(9 - 55f, this.3), 160);
		row.3.21 = 0.05;
		this.17.Add(row.3);
		row.3.18 = delegate(bool 1)
		{
			this.19[8].3 = Math.Round(row.3.7 * 20.0) / 20.0;
			1383.Set(this.19);
			this.Refresh();
		};
		row.4 = new 1452(string.Empty, 16f, new 208(9 + 120f, this.3), 0.94f, true, 198.White);
		row.4.49 = 1065.CentreLeft;
		this.7.12(row.4);
		1452 6 = new 1452("remove", 14f, new 208(9 + 175f, this.3), 0.94f, true, 198.Gray);
		6.49 = 1065.CentreLeft;
		6.10 = true;
		6.42 = new 1445(198.Gray, 198.White, 0, 100);
		6.3(delegate(object 1, EventArgs 2)
		{
			this.19.RemoveAt(8);
			1383.Set(this.19);
			this.13();
		});
		this.7.12(6);
		1452 7 = new 1452("reset", 14f, new 208(9 + 232f, this.3), 0.94f, true, 198.Gray);
		7.49 = 1065.CentreLeft;
		7.10 = true;
		7.42 = new 1445(198.Gray, 198.White, 0, 100);
		7.3(delegate(object 1, EventArgs 2)
		{
			this.19[8].3 = 1.0;
			row.3.23(1.0, true, true);
			1383.Set(this.19);
			this.Refresh();
		});
		this.7.12(7);
		this.20.Add(row);
	}

	// Token: 0x06002641 RID: 9793 RVA: 0x000BAD78 File Offset: 0x000B8F78
	private void 13()
	{
		this.24 = true;
		1662.25(new 2493(this.19.FindAll((1383.1384 1) => double.IsNaN(1.1) || double.IsNaN(1.2))));
		this.Close(false);
	}

	// Token: 0x06002642 RID: 9794 RVA: 0x000BADC8 File Offset: 0x000B8FC8
	private void Refresh()
	{
		for (int i = 0; i < this.20.Count; i++)
		{
			this.20[i].4.SetText(this.19[i].3.ToString("0.00", CultureInfo.InvariantCulture));
		}
		double? num = 1383.3();
		this.21.SetText((num != null) ? ("This map: AR " + 1383.4(num.Value) + ", gamma " + 1383.1().ToString("0.00", CultureInfo.InvariantCulture)) : "This map has no AR to go by");
	}

	// Token: 0x06002643 RID: 9795 RVA: 0x000BAE74 File Offset: 0x000B9074
	public override void Update()
	{
		base.Update();
		bool flag = 1555.2() == 199.Pressed;
		if (!flag || !this.4)
		{
			this.22 = null;
		}
		else if (!this.23)
		{
			2493.2494 <<EMPTY_NAME>> = this.20.Find((2493.2494 1) => 1.3.25());
			this.22 = ((<<EMPTY_NAME>> != null) ? <<EMPTY_NAME>>.3 : null);
		}
		1429 2 = this.22;
		if (2 != null)
		{
			2.27();
		}
		this.23 = flag;
		bool flag2 = false;
		for (int i = 0; i < this.20.Count; i++)
		{
			flag2 |= 2493.14(this.20[i].1, ref this.19[i].1);
			flag2 |= 2493.14(this.20[i].2, ref this.19[i].2);
		}
		if (flag2)
		{
			1383.Set(this.19);
			this.Refresh();
		}
	}

	// Token: 0x06002644 RID: 9796 RVA: 0x000BAF80 File Offset: 0x000B9180
	private new static bool 14(1448 1, ref double 2)
	{
		double num;
		if (!double.TryParse((1.GetText() ?? string.Empty).Trim().Replace(',', '.'), NumberStyles.Float, CultureInfo.InvariantCulture, out num) || double.IsNaN(num) || double.IsInfinity(num))
		{
			return false;
		}
		num = Math.Max(-100.0, Math.Min(13.0, Math.Round(num, 2)));
		if (Math.Abs(num - 2) < 0.001)
		{
			return false;
		}
		2 = num;
		return true;
	}

	// Token: 0x06002645 RID: 9797 RVA: 0x000BB00D File Offset: 0x000B920D
	internal override bool OnKeyDown(200 1)
	{
		return !this.20.Exists((2493.2494 1) => 1.1.1() || 1.2.1()) && base.OnKeyDown(2);
	}

	// Token: 0x06002646 RID: 9798 RVA: 0x000BB044 File Offset: 0x000B9244
	protected override void Dispose(bool 1)
	{
		foreach (2493.2494 2 in this.20)
		{
			2.1.Dispose();
			2.2.Dispose();
		}
		base.Dispose(1);
	}

	// Token: 0x04001B2B RID: 6955
	private static int 18;

	// Token: 0x04001B2C RID: 6956
	private readonly List<1383.1384> 19 = 1383.Get();

	// Token: 0x04001B2D RID: 6957
	private readonly List<2493.2494> 20 = new List<2493.2494>();

	// Token: 0x04001B2E RID: 6958
	private readonly 1452 21;

	// Token: 0x04001B2F RID: 6959
	private 1429 22;

	// Token: 0x04001B30 RID: 6960
	private bool 23;

	// Token: 0x04001B31 RID: 6961
	private bool 24;

	// Token: 0x020004DF RID: 1247
	[276]
	private sealed class 2494
	{
		// Token: 0x04001B32 RID: 6962
		public 1448 1;

		// Token: 0x04001B33 RID: 6963
		public 1448 2;

		// Token: 0x04001B34 RID: 6964
		public 1429 3;

		// Token: 0x04001B35 RID: 6965
		public 1452 4;
	}
}
