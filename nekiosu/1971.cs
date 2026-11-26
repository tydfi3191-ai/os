using System;
using System.Collections.Generic;

// Token: 0x02000784 RID: 1924
public sealed class 1971 : 2037
{
	// Token: 0x06003884 RID: 14468 RVA: 0x00162540 File Offset: 0x00160740
	public 1971(2039 1) : base(1)
	{
		if (this.1.39 != null)
		{
			int num;
			if (1535.1())
			{
				if (1535.39 != null)
				{
					2023 2 = 1535.39.8;
					2023 3 = 2023.Autoplay;
					num = (((2 & 3) > 2023.None) ? 1 : 0);
				}
				else
				{
					num = 0;
				}
			}
			else
			{
				num = 1;
			}
			2009.1((byte)num > 0);
		}
		this.12 = (int)Math.Round((double)(this.1.21.3 + this.1.21.2)) * 20 + (int)((double)this.1.21.4 * 41.2) + (int)Math.Round((double)this.1.21.1);
		this.ResetState();
	}

	// Token: 0x06003885 RID: 14469 RVA: 0x00162654 File Offset: 0x00160854
	internal override void ResetState()
	{
		this.2.1(this.12);
		this.3.1(this.12);
		this.4.1(10086);
		this.10 = 2147483647.0;
		this.11 = (1965)2048;
		this.9 = new List<int>(7);
		this.6 = 0;
		this.3(208.Zero, 0);
		this.8 = new bool[2011.53(this.1.21, this.1.22)];
	}

	// Token: 0x06003886 RID: 14470 RVA: 0x001626F8 File Offset: 0x001608F8
	internal new int 1(float 1, float 2, float 3, float 4, float 5)
	{
		double num = this.2.3();
		if (num >= (double)5)
		{
			return 6;
		}
		if (num >= (double)4)
		{
			return 5;
		}
		if (num >= (double)3)
		{
			return 4;
		}
		if (num >= (double)2)
		{
			return 3;
		}
		if (num >= (double)1)
		{
			return 2;
		}
		return 1;
	}

	// Token: 0x06003887 RID: 14471 RVA: 0x00162738 File Offset: 0x00160938
	private void 2(int 1)
	{
		if (this.9.Count == 7)
		{
			this.9.RemoveAt(0);
		}
		this.9.Add(1);
		if (this.9.Count >= 2)
		{
			this.10 = (double)(this.9[this.9.Count - 1] - this.9[0]) / (double)this.9.Count;
		}
	}

	// Token: 0x06003888 RID: 14472 RVA: 0x001627B2 File Offset: 0x001609B2
	private void 3(208 1, int 2)
	{
		this.7 = 2 - this.6;
		this.6 = 2;
		this.5 = 1;
	}

	// Token: 0x06003889 RID: 14473 RVA: 0x001627D0 File Offset: 0x001609D0
	internal override 2072 CreateCircle(208 1, int 2, bool 3, 1245 4, int 5, 1254 6, 1254 7, 1253 8, int 9, string 10)
	{
		1971.1972 createCircleClosure = new 1971.1972();
		createCircleClosure.1 = 10;
		1966 11;
		if (this.1.21.3() == 2147.OsuMania)
		{
			11 = new 1966(this.1, 15, 2, 4, (1965)8192, this.8)
			{
				35 = 6,
				36 = 7,
				37 = 8,
				34 = 9
			};
			11.9();
			11.44.ForEach(delegate(1979 1)
			{
				1.6(createCircleClosure.1);
			});
			this.3(15, 2);
		}
		else
		{
			this.2(2);
			int num = 2 - this.6;
			double num2 = this.1.21.90((double)2, false);
			1965 12;
			if (num <= 80)
			{
				12 = (1965)6;
			}
			else if (num <= 95)
			{
				12 = ((1965)6 | this.11);
			}
			else if (num <= 105)
			{
				12 = (1965)10;
			}
			else if (num <= 125)
			{
				12 = (1965)2;
			}
			else
			{
				float num3 = (15 - this.5).Length();
				1259 13 = this.1.21.92((double)2);
				12 = ((num <= 135 && num3 < 20f) ? ((1965)1028) : ((num <= 150 && num3 < 20f) ? ((1965)9) : ((num3 < 20f && this.10 >= num2 / 2.5) ? ((1965)520) : ((this.10 >= num2 / 2.5 && (13 == null || !13.3())) ? ((1965)8) : ((1965)0)))));
			}
			11 = new 1966(this.1, 15, 2, 4, 12, this.8)
			{
				35 = 6,
				36 = 7,
				37 = 8,
				34 = 9
			};
			11.9();
			this.8 = new bool[this.1.41.19.Count];
			foreach (1979 14 in 11.44)
			{
				this.8[14.45] = true;
				if ((12 & (1965)2048) > (1965)0 && 14.45 == this.1.41.19.Count - 1)
				{
					this.11 = (1965)4096;
				}
				else if ((12 & (1965)4096) > (1965)0 && 14.45 == this.1.41.43())
				{
					this.11 = (1965)2048;
				}
				14.6(createCircleClosure.1);
			}
			this.3(15, 2);
		}
		return 11;
	}

	// Token: 0x0600388A RID: 14474 RVA: 0x00162AB0 File Offset: 0x00160CB0
	internal override 2063 CreateSlider(208 1, int 2, bool 3, 1245 4, 2064 5, int 6, double 7, List<208> 8, List<1245> 9, int 10, 1254 11, 1254 12, List<1254> 13, List<1254> 14, 1253 15, int 16, string 17)
	{
		1971.1973 18 = new 1971.1973();
		18.1 = 17;
		if (this.1.21.3() == 2147.OsuMania)
		{
			18.2 = new 1969(this.1, 1, 2, 4, 6, 7, 8, 9, (1965)8192, this.8)
			{
				35 = 11,
				36 = 12,
				37 = 15,
				34 = 16
			};
			18.2.50();
			18.2.93.ForEach(new Action<1979>(18.1));
			this.3(1, 18.2.2);
		}
		else
		{
			1259 19 = this.1.21.92((double)2);
			1965 20 = (1965)0;
			if (19 != null && !19.3())
			{
				20 = (1965)8;
			}
			18.2 = new 1969(this.1, 1, 2, 4, 6, 7, 8, 9, 20, this.8)
			{
				35 = 11,
				36 = 12,
				85 = 13,
				86 = 14,
				37 = 15,
				34 = 16
			};
			18.2.50();
			this.8 = new bool[this.1.41.19.Count];
			if (18.2.93.Count > 1)
			{
				using (List<1979>.Enumerator enumerator = 18.2.93.FindAll(new Predicate<1979>(18.2)).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						1979 21 = enumerator.Current;
						this.8[21.45] = true;
					}
					goto IL_1D2;
				}
			}
			this.8[18.2.93[0].45] = true;
			IL_1D2:
			18.2.93.ForEach(new Action<1979>(18.3));
			int num = (18.2.2 - 2) / 6;
			while (6-- >= 0)
			{
				this.3(1, 2);
				this.2(2);
				2 += num;
			}
		}
		return 18.2;
	}

	// Token: 0x0600388B RID: 14475 RVA: 0x00162CF4 File Offset: 0x00160EF4
	internal override 2070 CreateSpinner(int 1, int 2, 1245 3, 1254 4, 1254 5, 1253 6, int 7, string 8)
	{
		1971.1974 9 = new 1971.1974();
		9.1 = 8;
		1970 10 = new 1970(this.1, 1, 2, 3, (1965)2, this.8);
		10.35 = 4;
		10.36 = 5;
		10.37 = 6;
		10.34 = 7;
		10.9();
		10.43.ForEach(new Action<1979>(9.1));
		this.3(new 208(256f, 192f), 2);
		this.2(2);
		return 10;
	}

	// Token: 0x0600388C RID: 14476 RVA: 0x00162D80 File Offset: 0x00160F80
	internal override 2072 CreateHold(208 1, int 2, int 3, bool 4, 1245 5, int 6, 1254 7, 1254 8, 1253 9, int 10, string 11)
	{
		1985 12 = new 1985(this.1, this.1.41.49(1, false), 2, 3, 5);
		12.35 = 7;
		12.36 = 8;
		12.37 = 9;
		12.34 = 10;
		12.6(11);
		this.3(1, 3);
		this.2(3);
		return 12;
	}

	// Token: 0x040029BD RID: 10685
	internal 1193 2 = new 1193(1337);

	// Token: 0x040029BE RID: 10686
	internal 1193 3 = new 1193(1337);

	// Token: 0x040029BF RID: 10687
	internal 1193 4 = new 1193(10086);

	// Token: 0x040029C0 RID: 10688
	private 208 5;

	// Token: 0x040029C1 RID: 10689
	private int 6;

	// Token: 0x040029C2 RID: 10690
	private int 7;

	// Token: 0x040029C3 RID: 10691
	private bool[] 8;

	// Token: 0x040029C4 RID: 10692
	private List<int> 9;

	// Token: 0x040029C5 RID: 10693
	private double 10 = 2147483647.0;

	// Token: 0x040029C6 RID: 10694
	private 1965 11 = (1965)2048;

	// Token: 0x040029C7 RID: 10695
	private readonly int 12;

	// Token: 0x02000785 RID: 1925
	public sealed class 1972
	{
		// Token: 0x040029C8 RID: 10696
		public string 1;
	}

	// Token: 0x02000786 RID: 1926
	public sealed class 1974
	{
		// Token: 0x0600388E RID: 14478 RVA: 0x00162DE5 File Offset: 0x00160FE5
		internal void 1(1979 1)
		{
			1.6(this.1);
		}

		// Token: 0x040029C9 RID: 10697
		public string 1;
	}

	// Token: 0x02000787 RID: 1927
	public sealed class 1973
	{
		// Token: 0x06003890 RID: 14480 RVA: 0x00162DF3 File Offset: 0x00160FF3
		internal void 1(1979 1)
		{
			1.6(this.1);
		}

		// Token: 0x06003891 RID: 14481 RVA: 0x00162E01 File Offset: 0x00161001
		internal bool 2(1979 1)
		{
			return 1.2 == this.2.2;
		}

		// Token: 0x06003892 RID: 14482 RVA: 0x00162DF3 File Offset: 0x00160FF3
		internal void 3(1979 1)
		{
			1.6(this.1);
		}

		// Token: 0x040029CA RID: 10698
		public string 1;

		// Token: 0x040029CB RID: 10699
		public 1969 2;
	}
}
