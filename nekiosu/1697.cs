using System;
using System.Collections.Generic;

// Token: 0x0200091E RID: 2334
public sealed class 1697 : 1689
{
	// Token: 0x0600426A RID: 17002 RVA: 0x0019E154 File Offset: 0x0019C354
	public 1697() : base(1568.1(2679.JumpToDialog_Title), true)
	{
		this.7.12(new 1360(new 208(10f, 79f), new 208((float)(1662.70.1() - 20), 1f), 1f, 198.White));
		this.7.12(new 1360(new 208(10f, 440f), new 208((float)(1662.70.1() - 20), 1f), 1f, 198.White));
		207 <<EMPTY_NAME>> = new 207(10, 80, (int)(640f * 1662.70.6()) - 20, 360);
		this.22 = new 1417(<<EMPTY_NAME>>, 208.Zero, true, 0f, 1545.Dialog);
		this.24 = new 1436(true);
		this.25 = new 1436(true);
		this.24.6(1662.70.7(), null);
		this.21 = new 1452(1568.1(2679.SongSelection_Collections) + ":", 20f, new 208(10f, 30f), 2f, true, new 198(254, 220, 97));
		this.20 = new 1373(this.25, "All", new 208(10f, 55f), 140f, 3f);
		this.23 = new 1422(20, new 208(10f, 50f), 20, (1066)3);
		this.26 = -1;
		this.7.14<1433>(this.23.2);
		this.7.12(this.21);
		this.22.32(this.24);
		this.23.4(new 1448.1449(this.22));
		base.3(new EventHandler(1697.1699.instance.1));
		this.20.10("All", "All");
		this.20.18("All", true);
		foreach (string text in 1297.1().Keys)
		{
			this.20.10(text, text);
		}
		this.20.1(new EventHandler(this.17));
		this.28 = 1272.5();
		this.12();
	}

	// Token: 0x0600426B RID: 17003 RVA: 0x0019E424 File Offset: 0x0019C624
	internal override void DrawDialog()
	{
		base.DrawDialog();
		this.22.21();
		this.25.22();
		1247.4();
	}

	// Token: 0x0600426C RID: 17004 RVA: 0x0019E448 File Offset: 0x0019C648
	public override void Update()
	{
		this.19(false, false);
		base.Update();
		this.22.Update();
		1247.6.5 = 1f;
		if (!this.23.1() || !this.23.15.3())
		{
			this.23.17(true);
		}
		if (this.26 > 0 && this.26 < 1662.33)
		{
			this.26 = -1;
			this.12();
		}
	}

	// Token: 0x0600426D RID: 17005 RVA: 0x0019E4CC File Offset: 0x0019C6CC
	protected override void Dispose(bool 1)
	{
		base.Dispose(1);
		this.24.Dispose();
		this.23.Dispose();
		this.22.Dispose();
		this.25.Dispose();
		1373 2 = this.20;
		if (2 == null)
		{
			return;
		}
		2.17();
	}

	// Token: 0x0600426E RID: 17006 RVA: 0x0019E51C File Offset: 0x0019C71C
	private void 12()
	{
		this.15();
		int num = 0;
		foreach (1262 <<EMPTY_NAME>> in this.18)
		{
			if (this.19.Count == 250)
			{
				break;
			}
			this.13(<<EMPTY_NAME>>, num);
			num++;
		}
		int num2 = Math.Min(num, 250);
		this.22.17(new 208(640f * 1662.70.6(), (float)(num2 * 30)));
		this.19(false, true);
	}

	// Token: 0x0600426F RID: 17007 RVA: 0x0019E5CC File Offset: 0x0019C7CC
	private void 13(1262 1, int 2)
	{
		1700 3 = new 1700(this, 1, 2);
		3.2.3(new EventHandler(this.18));
		this.14(3);
	}

	// Token: 0x06004270 RID: 17008 RVA: 0x0019E600 File Offset: 0x0019C800
	private new void 14(1700 1)
	{
		this.19.Add(1);
		this.24.12(1.1);
		this.24.12(1.2);
		1247.19(1.3);
	}

	// Token: 0x06004271 RID: 17009 RVA: 0x0019E63B File Offset: 0x0019C83B
	private new void 15()
	{
		1247.20();
		this.16();
		this.24.15(true);
		this.19.Clear();
	}

	// Token: 0x06004272 RID: 17010 RVA: 0x0019E660 File Offset: 0x0019C860
	private new void 16()
	{
		1697.1698 filterBeatmapsClosure = new 1697.1698();
		filterBeatmapsClosure.1 = this;
		this.18.Clear();
		filterBeatmapsClosure.2 = this.23.GetText();
		List<1262> list = (this.20.18 == "All") ? new List<1262>(1272.3) : 1272.3.FindAll(new Predicate<1262>(filterBeatmapsClosure.1));
		if (!string.IsNullOrEmpty(filterBeatmapsClosure.2))
		{
			list = list.FindAll((1262 1) => 1.81.IndexOf(filterBeatmapsClosure.2, StringComparison.CurrentCultureIgnoreCase) >= 0);
		}
		if (list.Count == 0)
		{
			return;
		}
		list.Sort();
		this.18.Add(list[0]);
		for (int i = 1; i < list.Count; i++)
		{
			if (list[i].37 != list[i - 1].37)
			{
				this.18.Add(list[i]);
			}
		}
		this.18.Sort(new Comparison<1262>(1697.1699.instance.2));
	}

	// Token: 0x06004273 RID: 17011 RVA: 0x0019E78C File Offset: 0x0019C98C
	private new void 17(object 1, EventArgs 2)
	{
		this.12();
	}

	// Token: 0x06004274 RID: 17012 RVA: 0x0019E794 File Offset: 0x0019C994
	private void 18(object 1, EventArgs 2)
	{
		if (this.27)
		{
			this.Close(false);
		}
	}

	// Token: 0x06004275 RID: 17013 RVA: 0x0019E7A8 File Offset: 0x0019C9A8
	internal void 19(bool 1, bool 2)
	{
		if (1272.5() != this.28 || 1 || 2)
		{
			if ((!1 && 1272.5() != null) || (1 && this.28 == null))
			{
				this.28 = 1272.5();
			}
			else
			{
				1272.SetCurrentBeatmap(this.28);
			}
			foreach (1700 3 in this.19)
			{
				1262 4 = this.28;
				if (((4 != null) ? 4.37 : null) == 3.3.37)
				{
					3.2.24(0.6f, 100, (1046)0);
					3.2.39(198.CornflowerBlue, 100, false, (1046)0);
					if (!1)
					{
						if (this.19.Count <= 12)
						{
							this.22.17(new 208(0f, 0f));
						}
						else
						{
							int num = this.19.IndexOf(3) * 30;
							this.22.20(new 208(0f, Math.Min(this.22.17.Y - 360f, (float)num)), 0f);
						}
					}
				}
				else if (3.2.16 > 0.001f)
				{
					3.2.24(0.001f, 20, (1046)0);
					3.2.39(198.White, 20, false, (1046)0);
				}
			}
		}
		if (1 && !this.27)
		{
			1247.16(false, false);
			1247.18(1272.5());
		}
	}

	// Token: 0x06004276 RID: 17014 RVA: 0x0019E970 File Offset: 0x0019CB70
	private void 20(bool 1)
	{
		foreach (1700 2 in this.19)
		{
			if (this.28 == null || this.28.37 == 2.3.37)
			{
				int num = this.19.IndexOf(2);
				int num2 = num + (1 ? 1 : -1);
				if (!this.21(1, num2))
				{
					break;
				}
				int num3 = (!1) ? 1 : 10;
				this.28 = this.18[num2];
				this.19(true, false);
				int num4 = num * 30;
				float y = this.22.20.Y;
				if (1 ? (y + 300f <= (float)num4) : (y >= (float)num4))
				{
					this.22.20(new 208(0f, (float)(30 * (num - num3))), 0f);
					break;
				}
				break;
			}
		}
	}

	// Token: 0x06004277 RID: 17015 RVA: 0x0019EA90 File Offset: 0x0019CC90
	private bool 21(bool 1, int 2)
	{
		if (!1)
		{
			return 2 >= 0;
		}
		return 2 < this.19.Count;
	}

	// Token: 0x06004278 RID: 17016 RVA: 0x0019EAAB File Offset: 0x0019CCAB
	internal override bool OnKeyDown(200 1)
	{
		if (1662.103.5(null, 1))
		{
			return true;
		}
		if (1 == 200.Up)
		{
			this.20(false);
			return true;
		}
		if (1 == 200.Down)
		{
			this.20(true);
			return true;
		}
		return base.OnKeyDown(1);
	}

	// Token: 0x06004279 RID: 17017 RVA: 0x0019EAE0 File Offset: 0x0019CCE0
	private void 22(1448 1, bool 2)
	{
		if (2)
		{
			if (this.23.28() && this.23.6.Length == 1)
			{
				this.26 = 1662.33;
				return;
			}
			if (!this.23.28())
			{
				this.26 = 1662.33 + 300;
			}
		}
	}

	// Token: 0x04003094 RID: 12436
	private List<1262> 18 = new List<1262>();

	// Token: 0x04003095 RID: 12437
	private List<1700> 19 = new List<1700>();

	// Token: 0x04003096 RID: 12438
	private 1373 20;

	// Token: 0x04003097 RID: 12439
	private 1452 21;

	// Token: 0x04003098 RID: 12440
	private readonly 1417 22;

	// Token: 0x04003099 RID: 12441
	private 1422 23;

	// Token: 0x0400309A RID: 12442
	private 1436 24;

	// Token: 0x0400309B RID: 12443
	private 1436 25;

	// Token: 0x0400309C RID: 12444
	private int 26;

	// Token: 0x0400309D RID: 12445
	public bool 27;

	// Token: 0x0400309E RID: 12446
	public 1262 28;

	// Token: 0x0200091F RID: 2335
	public sealed class 1698
	{
		// Token: 0x0600427A RID: 17018 RVA: 0x0019EB3A File Offset: 0x0019CD3A
		internal bool 1(1262 1)
		{
			return 1297.1()[this.1.20.19].Contains(1.23);
		}

		// Token: 0x0400309F RID: 12447
		public 1697 1;

		// Token: 0x040030A0 RID: 12448
		public string 2;
	}

	// Token: 0x02000920 RID: 2336
	[Serializable]
	public sealed class 1699
	{
		// Token: 0x0600427C RID: 17020 RVA: 0x0019EB61 File Offset: 0x0019CD61
		internal void 1(object 1, EventArgs 2)
		{
			1247.20();
		}

		// Token: 0x0600427D RID: 17021 RVA: 0x0019EB68 File Offset: 0x0019CD68
		internal int 2(1262 1, 1262 2)
		{
			return 2.46.CompareTo(1.46);
		}

		// Token: 0x040030A1 RID: 12449
		public static readonly 1697.1699 instance = new 1697.1699();

		// Token: 0x040030A2 RID: 12450
		public static EventHandler eventHandler;

		// Token: 0x040030A3 RID: 12451
		public static Comparison<1262> comparison;
	}
}
