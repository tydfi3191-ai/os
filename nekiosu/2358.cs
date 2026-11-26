using System;
using System.Collections.Generic;

// Token: 0x020005C1 RID: 1473
public sealed class 2358 : 1417
{
	// Token: 0x06002D9D RID: 11677 RVA: 0x00101A90 File Offset: 0x000FFC90
	internal 2358() : base(new 207(1662.70.1() - 66, 80, 66, 290), 208.Zero, true, 0f, 1545.Default)
	{
		this.10 = false;
	}

	// Token: 0x06002D9E RID: 11678 RVA: 0x00101AE3 File Offset: 0x000FFCE3
	private 2263 34()
	{
		return 2263.4;
	}

	// Token: 0x06002D9F RID: 11679 RVA: 0x00101AEA File Offset: 0x000FFCEA
	private new 2298 35()
	{
		return this.34().75;
	}

	// Token: 0x06002DA0 RID: 11680 RVA: 0x00101AF7 File Offset: 0x000FFCF7
	private 1436 36()
	{
		return this.22;
	}

	// Token: 0x06002DA1 RID: 11681 RVA: 0x00101AFF File Offset: 0x000FFCFF
	private 2648 37()
	{
		return this.34().6;
	}

	// Token: 0x06002DA2 RID: 11682 RVA: 0x00101B0C File Offset: 0x000FFD0C
	private new void 38(1452 1)
	{
		if (this.41 != null)
		{
			this.41.54(this.41.90 = false);
		}
		if (1 != null)
		{
			1.54(1.90 = true);
		}
		this.41 = 1;
	}

	// Token: 0x06002DA3 RID: 11683 RVA: 0x00101B58 File Offset: 0x000FFD58
	private bool 39()
	{
		1433 <<EMPTY_NAME>> = this.36().23;
		return <<EMPTY_NAME>> != null && <<EMPTY_NAME>>.9 == 2;
	}

	// Token: 0x06002DA4 RID: 11684 RVA: 0x00101B80 File Offset: 0x000FFD80
	protected override bool OnPointerPressed(object 1, EventArgs 2)
	{
		int num;
		if (!base.OnPointerPressed(1, 2))
		{
			1433 3 = this.36().23;
			num = ((3 != null && 3.9 > 0) ? 1 : 0);
		}
		else
		{
			num = 1;
		}
		bool result = (byte)num > 0;
		this.45 = ((byte)num > 0);
		return result;
	}

	// Token: 0x06002DA5 RID: 11685 RVA: 0x00101BC8 File Offset: 0x000FFDC8
	protected override bool OnPointerReleased(object 1, EventArgs 2)
	{
		return base.OnPointerReleased(1, 2) || this.45;
	}

	// Token: 0x06002DA6 RID: 11686 RVA: 0x00101BDC File Offset: 0x000FFDDC
	protected override bool OnDrag(object 1, EventArgs 2)
	{
		if (this.40 != null)
		{
			return true;
		}
		if (!this.11 && !this.33 && this.26 && this.39())
		{
			this.40 = this.36().23;
			this.40.2 = 1f;
			this.36().13();
			this.43 = 1555.21();
			return true;
		}
		return base.OnDrag(1, 2);
	}

	// Token: 0x06002DA7 RID: 11687 RVA: 0x00101C54 File Offset: 0x000FFE54
	protected override bool OnDragEnd(object 1, EventArgs 2)
	{
		bool result = base.OnDragEnd(1, 2);
		if (this.40 == null)
		{
			return result;
		}
		this.40.48 = 208.Zero;
		int num = 0;
		int num2 = 0;
		foreach (1371 3 in this.36().28.FindAll(new Predicate<1371>(2358.2361.numericTagPredicates.1)))
		{
			if (3.3.Count > 0)
			{
				3.17 = 3.3[0].6;
				3.3.Clear();
			}
			if (3.7 == 3.17)
			{
				if (3.9 == 1)
				{
					num++;
					num2 = 0;
				}
				else
				{
					num2++;
				}
			}
		}
		2647 4 = (2647)this.40.8;
		this.35().23(4, (2645)(num - 1), num2);
		this.40 = null;
		this.44 = true;
		return result;
	}

	// Token: 0x06002DA8 RID: 11688 RVA: 0x00101D74 File Offset: 0x000FFF74
	internal void 40(2647 1)
	{
		if (1 == null)
		{
			this.38(null);
			return;
		}
		1452 2;
		this.39.TryGetValue(1, out 2);
		this.38(2);
	}

	// Token: 0x06002DA9 RID: 11689 RVA: 0x00101DA2 File Offset: 0x000FFFA2
	internal void 41()
	{
		base.Update();
		this.42();
		this.43();
	}

	// Token: 0x06002DAA RID: 11690 RVA: 0x00101DB8 File Offset: 0x000FFFB8
	private void 42()
	{
		if (this.40 == null)
		{
			return;
		}
		this.40.17 = this.40.7 + (1555.21() - this.43) / 1662.70.3();
		foreach (1371 <<EMPTY_NAME>> in this.36().28.FindAll((1371 1) => 1.9 > 0))
		{
			1452 2 = <<EMPTY_NAME>> as 1452;
			if (this.40 != <<EMPTY_NAME>> && !(((2 != null) ? 2.GetText() : null) == "Background"))
			{
				if (<<EMPTY_NAME>>.7.Y > this.40.17.Y - this.42 / 2f)
				{
					if (<<EMPTY_NAME>>.17 == <<EMPTY_NAME>>.7)
					{
						<<EMPTY_NAME>>.18(<<EMPTY_NAME>>.7 + new 208(0f, this.42), 80);
					}
				}
				else if (<<EMPTY_NAME>>.7.Y < this.40.17.Y && <<EMPTY_NAME>>.17 != <<EMPTY_NAME>>.7)
				{
					<<EMPTY_NAME>>.18(<<EMPTY_NAME>>.7, 80);
				}
			}
		}
	}

	// Token: 0x06002DAB RID: 11691 RVA: 0x00101F44 File Offset: 0x00100144
	private void 43()
	{
		if (!this.44)
		{
			return;
		}
		base.31(true, true);
		this.39.Clear();
		float num = 0f;
		float num2 = 0.5f;
		List<2647>[] <<EMPTY_NAME>> = this.37().26;
		bool[] 2 = this.37().28;
		float num3 = 2328.1(1662.13(), false) / 96f;
		for (int i = 0; i < <<EMPTY_NAME>>.Length; i++)
		{
			List<2647> list = <<EMPTY_NAME>>[i];
			bool flag = 2[i];
			1452 3 = this.44((2645)i, num3, num2, num, flag);
			if (this.42 == 0f)
			{
				this.42 = (3.GetTextSize().Y + 4f * num3) / 1662.70.3();
			}
			num += this.42;
			num2 += 0.0001f;
			this.36().12(3);
			if (flag)
			{
				foreach (2647 4 in list)
				{
					if (4.7 != null)
					{
						1452 5 = this.45(4, num3, num2, num);
						if (4 == this.35().48)
						{
							this.38(5);
						}
						num += (5.GetTextSize().Y + 4f * num3) / 1662.70.3();
						num2 += 0.0001f;
						this.36().12(5);
						this.39.Add(4, 5);
					}
				}
			}
		}
		base.17(new 208(66f, num));
		this.44 = false;
	}

	// Token: 0x06002DAC RID: 11692 RVA: 0x00102100 File Offset: 0x00100300
	private 1452 44(2645 1, float 2, float 3, float 4, bool 5)
	{
		2358.2360 6 = new 2358.2360();
		6.1 = this;
		6.3 = 1;
		1452 7 = new 1452(6.3.ToString(), 8f * 2, new 208(0f, 4), 3, true, 5 ? 198.Orange : 198.LightGray);
		7.85 = false;
		7.74 = false;
		7.63(true);
		7.9 = 1;
		7.10 = true;
		6.2 = 7;
		6.2.35(new EventHandler(6.1));
		6.2.37(new EventHandler(6.2));
		6.2.3(new EventHandler(6.3));
		return 6.2;
	}

	// Token: 0x06002DAD RID: 11693 RVA: 0x001021D4 File Offset: 0x001003D4
	private 1452 45(2647 1, float 2, float 3, float 4)
	{
		2358.2359 eventRowHandlers = new 2358.2359();
		eventRowHandlers.2 = this;
		eventRowHandlers.3 = 6;
		1452 5 = new 1452((eventRowHandlers.3.3.Length >= 4) ? eventRowHandlers.3.3.Remove(eventRowHandlers.3.3.Length - 4) : (eventRowHandlers.3.3 + " "), 8f * 7, new 208(2f, 4), 3, true, 198.White);
		5.85 = false;
		5.74 = false;
		5.63(true);
		5.8 = eventRowHandlers.3;
		5.9 = 2;
		5.10 = true;
		eventRowHandlers.1 = 5;
		eventRowHandlers.1.35(delegate(object 1, EventArgs 2)
		{
			eventRowHandlers.1.58(new 198(92, 92, 92));
			eventRowHandlers.1.88 = true;
		});
		eventRowHandlers.1.37(new EventHandler(eventRowHandlers.6));
		eventRowHandlers.1.3(new EventHandler(eventRowHandlers.7));
		return eventRowHandlers.1;
	}

	// Token: 0x04002181 RID: 8577
	private readonly Dictionary<2647, 1452> 39 = new Dictionary<2647, 1452>();

	// Token: 0x04002182 RID: 8578
	private 1433 40;

	// Token: 0x04002183 RID: 8579
	private 1452 41;

	// Token: 0x04002184 RID: 8580
	private float 42;

	// Token: 0x04002185 RID: 8581
	private 208 43;

	// Token: 0x04002186 RID: 8582
	internal bool 44 = true;

	// Token: 0x04002187 RID: 8583
	private bool 45;

	// Token: 0x020005C2 RID: 1474
	public sealed class 2359
	{
		// Token: 0x06002DAE RID: 11694 RVA: 0x00102333 File Offset: 0x00100533
		internal void 1(object 1, EventArgs 2)
		{
			this.1.58(198.TransparentWhite);
			this.1.88 = true;
		}

		// Token: 0x06002DAF RID: 11695 RVA: 0x00102354 File Offset: 0x00100554
		internal void 2(object 1, EventArgs 2)
		{
			this.2.38(this.1);
			if ((!this.3.7.19 || 1555.13) && this.3.7.3.Count > 0)
			{
				1226.4(this.3.7.3[0].9, false, false);
			}
			this.2.35().28(this.3, false);
		}

		// Token: 0x04002188 RID: 8584
		public 1452 1;

		// Token: 0x04002189 RID: 8585
		public 2358 2;

		// Token: 0x0400218A RID: 8586
		public 2647 3;
	}

	// Token: 0x020005C3 RID: 1475
	public sealed class 2360
	{
		// Token: 0x06002DB1 RID: 11697 RVA: 0x001023DC File Offset: 0x001005DC
		internal void 1(object 1, EventArgs 2)
		{
			if (this.1.35().48 != null)
			{
				this.2.54(true);
				this.2.88 = true;
			}
		}

		// Token: 0x06002DB2 RID: 11698 RVA: 0x00102408 File Offset: 0x00100608
		internal void 2(object 1, EventArgs 2)
		{
			this.2.54(false);
			this.2.88 = true;
		}

		// Token: 0x06002DB3 RID: 11699 RVA: 0x00102424 File Offset: 0x00100624
		internal void 3(object 1, EventArgs 2)
		{
			if (this.1.35().48 != null)
			{
				this.1.35().23(this.1.35().48, this.3, -1);
				return;
			}
			this.1.35().6(this.3);
		}

		// Token: 0x0400218B RID: 8587
		public 2358 1;

		// Token: 0x0400218C RID: 8588
		public 1452 2;

		// Token: 0x0400218D RID: 8589
		public 2645 3;
	}

	// Token: 0x020005C4 RID: 1476
	[Serializable]
	public sealed class 2361
	{
		// Token: 0x06002DB5 RID: 11701 RVA: 0x00102481 File Offset: 0x00100681
		internal bool 1(1371 1)
		{
			return 1.9 > 0;
		}

		// Token: 0x0400218E RID: 8590
		public static readonly 2358.2361 numericTagPredicates = new 2358.2361();

		// Token: 0x0400218F RID: 8591
		public static Predicate<1371> predicate;

		// Token: 0x04002190 RID: 8592
		public static Predicate<1371> predicate2;
	}
}
