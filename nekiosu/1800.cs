using System;
using System.Collections.Generic;

// Token: 0x020008AA RID: 2218
public sealed class 1800 : 1474
{
	// Token: 0x06003F79 RID: 16249 RVA: 0x00189AB8 File Offset: 0x00187CB8
	public 1800() : base(1662.11)
	{
		float num = 1662.48 ? 0.7f : 1f;
		208 <<EMPTY_NAME>> = new 208(57f, 57f) * num;
		208 10 = new 208(5f, 20f) * num;
		208 3 = new 208(115f, 75f) * num;
		208 4 = new 208(87.5f, 110f) * num;
		this.7.Add(this.4 = new 1798(1226.36, "effect", 3, 208.Zero, 0.5f * num, false, new EventHandler(this.1), new EventHandler(this.2)));
		this.7.Add(this.3 = new 1798(1226.39, "master", <<EMPTY_NAME>>, 10, num, true, new EventHandler(this.1), new EventHandler(this.2)));
		this.7.Add(this.6 = new 1798(1226.38, "music", 4, 208.Zero, 0.5f * num, false, new EventHandler(this.1), new EventHandler(this.2)));
		208 5 = new 208(43.3f, 116.4f) * num;
		208 6 = new 208(22f, -25f) * num;
		this.7.Add(this.5 = new 1798(1226.37, "hitsound", 5, 6, 0.5f * num, false, new EventHandler(this.1), new EventHandler(this.2)));
		1436 7 = this.9;
		1433 8 = new 1433(1455.2("volume-background-gradient", (1416)1, null), (1376)14, 1065.BottomRight, (1044)0, 208.Zero, 0f, true, 198.TransparentWhite, null);
		8.15 = num;
		1433 9 = 8;
		this.11 = 8;
		7.12(9);
		this.8 = this.3;
		1535.40((1082)1, new 1081(this.5), 1545.Volume, (1559)1);
		1535.40((1082)0, (object 1, EventArgs 2) => this.11(-5), 1545.Volume, (1559)1);
		1535.40((1082)1, new 1081(this.7), 1545.AltOverrides, (1559)1);
		1535.40((1082)0, new 1081(this.8), 1545.AltOverrides, (1559)1);
		1535.40((1082)1, new 1081(this.9), 1545.Highest, (1559)1);
		1535.40((1082)0, new 1081(this.10), 1545.Highest, (1559)1);
	}

	// Token: 0x06003F7A RID: 16250 RVA: 0x00189D6B File Offset: 0x00187F6B
	private void 1(object 1, EventArgs 2)
	{
		this.4(1 as 1798);
	}

	// Token: 0x06003F7B RID: 16251 RVA: 0x00189D79 File Offset: 0x00187F79
	private void 2(object 1, EventArgs 2)
	{
		this.3();
	}

	// Token: 0x06003F7C RID: 16252 RVA: 0x00189D82 File Offset: 0x00187F82
	public override void Draw()
	{
		this.9.22();
		this.3.Draw();
		this.4.Draw();
		this.5.Draw();
		this.6.Draw();
		base.Draw();
	}

	// Token: 0x06003F7D RID: 16253 RVA: 0x00189DC4 File Offset: 0x00187FC4
	public override void Update()
	{
		this.11.16 = this.3.10();
		this.3.Update();
		this.4.Update();
		this.5.Update();
		this.6.Update();
		base.Update();
	}

	// Token: 0x06003F7E RID: 16254 RVA: 0x00189E19 File Offset: 0x00188019
	protected override void Dispose(bool 1)
	{
		base.Dispose(1);
		this.9.Dispose();
		this.3.11();
		this.4.11();
		this.5.11();
		this.6.11();
	}

	// Token: 0x06003F7F RID: 16255 RVA: 0x00189E5C File Offset: 0x0018805C
	private bool 3()
	{
		bool flag = this.3.8();
		if (!flag)
		{
			this.4(this.3);
		}
		this.3.9(true);
		this.4.9(true);
		this.5.9(true);
		this.6.9(true);
		return flag;
	}

	// Token: 0x06003F80 RID: 16256 RVA: 0x00189EB3 File Offset: 0x001880B3
	private void 4(1798 1)
	{
		if (this.8 != 1)
		{
			this.8.1(false);
			this.8 = 1;
			this.8.1(true);
			this.3();
		}
	}

	// Token: 0x06003F81 RID: 16257 RVA: 0x00189EE4 File Offset: 0x001880E4
	private bool 5(object 1, EventArgs 2)
	{
		return this.11(5);
	}

	// Token: 0x06003F82 RID: 16258 RVA: 0x00189EED File Offset: 0x001880ED
	private bool 6(object 1, EventArgs 2)
	{
		return this.11(-5);
	}

	// Token: 0x06003F83 RID: 16259 RVA: 0x00189EF7 File Offset: 0x001880F7
	private bool 7(object 1, EventArgs 2)
	{
		return 1549.2 && this.5(1, 2);
	}

	// Token: 0x06003F84 RID: 16260 RVA: 0x00189F0A File Offset: 0x0018810A
	private bool 8(object 1, EventArgs 2)
	{
		return 1549.2 && this.6(1, 2);
	}

	// Token: 0x06003F85 RID: 16261 RVA: 0x00189F1D File Offset: 0x0018811D
	private bool 9(object 1, EventArgs 2)
	{
		return this.14() && this.5(1, 2);
	}

	// Token: 0x06003F86 RID: 16262 RVA: 0x00189F31 File Offset: 0x00188131
	private bool 10(object 1, EventArgs 2)
	{
		return this.14() && this.6(1, 2);
	}

	// Token: 0x06003F87 RID: 16263 RVA: 0x00189F45 File Offset: 0x00188145
	private bool 11(int 1)
	{
		if (!this.13())
		{
			return false;
		}
		if (this.3())
		{
			this.8.12(1);
		}
		return true;
	}

	// Token: 0x06003F88 RID: 16264 RVA: 0x00189F68 File Offset: 0x00188168
	internal bool 12(object 1, 200 2, bool 3)
	{
		if (!this.13() || (!1549.2 && 1662.78 == 1677.Play && 2486.13))
		{
			return false;
		}
		if (!1549.2 && 2513.IsOpen)
		{
			return false;
		}
		if (3)
		{
			this.10 = 0;
		}
		else
		{
			int num = this.10 + 1;
			this.10 = num;
			if (num < 4)
			{
				return true;
			}
		}
		1532 4 = 1548.16(2);
		if (4 == 1532.VolumeIncrease)
		{
			this.11(5);
			return true;
		}
		if (4 == 1532.VolumeDecrease)
		{
			this.11(-5);
			return true;
		}
		if (2486.14 && (1548.18(200.Left, 2486.14()) || 1548.18(200.Right, 2486.14())))
		{
			return false;
		}
		if (this.3.8())
		{
			if (2 == 200.Left)
			{
				this.4(this.7[(this.7.Count + this.7.FindIndex(new Predicate<1798>(this.15)) - 1) % this.7.Count]);
				return true;
			}
			if (2 == 200.Right)
			{
				this.4(this.7[(this.7.Count + this.7.FindIndex(new Predicate<1798>(this.16)) + 1) % this.7.Count]);
				return true;
			}
		}
		return false;
	}

	// Token: 0x06003F89 RID: 16265 RVA: 0x0018A0BC File Offset: 0x001882BC
	internal bool 13()
	{
		bool flag = 1549.2 || this.14();
		if (!flag && 1662.92 != null)
		{
			return false;
		}
		1677 <<EMPTY_NAME>> = 1662.78;
		if (<<EMPTY_NAME>> != 1677.Menu)
		{
			if (<<EMPTY_NAME>> != 1677.Play)
			{
				if (<<EMPTY_NAME>> == 1677.MatchSetup)
				{
					return true;
				}
			}
			else if (!1304.105)
			{
				return true;
			}
			return flag;
		}
		return true;
	}

	// Token: 0x06003F8A RID: 16266 RVA: 0x0018A10B File Offset: 0x0018830B
	internal bool 14()
	{
		return this.7.Find((1798 1) => 1.7()) != null;
	}

	// Token: 0x06003F8B RID: 16267 RVA: 0x0018A13A File Offset: 0x0018833A
	private bool 15(1798 1)
	{
		return 1 == this.8;
	}

	// Token: 0x06003F8C RID: 16268 RVA: 0x0018A13A File Offset: 0x0018833A
	private bool 16(1798 1)
	{
		return 1 == this.8;
	}

	// Token: 0x04002E77 RID: 11895
	private 1798 3;

	// Token: 0x04002E78 RID: 11896
	private 1798 4;

	// Token: 0x04002E79 RID: 11897
	private 1798 5;

	// Token: 0x04002E7A RID: 11898
	private 1798 6;

	// Token: 0x04002E7B RID: 11899
	private List<1798> 7 = new List<1798>();

	// Token: 0x04002E7C RID: 11900
	private 1798 8;

	// Token: 0x04002E7D RID: 11901
	private 1436 9 = new 1436(true);

	// Token: 0x04002E7E RID: 11902
	private int 10;

	// Token: 0x04002E7F RID: 11903
	private 1433 11;

	// Token: 0x020008AB RID: 2219
	[Serializable]
	public sealed class 1801
	{
		// Token: 0x04002E80 RID: 11904
		public static readonly 1800.1801 volumeOverlayCallbacks = new 1800.1801();

		// Token: 0x04002E81 RID: 11905
		public static Predicate<1798> predicate;
	}
}
