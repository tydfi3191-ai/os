using System;
using System.Collections.Generic;

// Token: 0x020005D2 RID: 1490
public sealed class 2440 : 2453
{
	// Token: 0x06002E08 RID: 11784 RVA: 0x00105D84 File Offset: 0x00103F84
	public 2440(2458 1)
	{
		base.7((2452)0, 1);
	}

	// Token: 0x06002E09 RID: 11785 RVA: 0x00105D94 File Offset: 0x00103F94
	internal override 2448 CreateAction(2451 1, 2450 2)
	{
		switch (1)
		{
		case (2451)0:
			return new 2386(this, 2);
		case (2451)1:
			return new 2381(this, 2);
		case (2451)2:
			return new 2379(this, 2);
		case (2451)3:
			return new 2384(this, 2);
		case (2451)4:
			return new 2377(this, 2);
		case (2451)5:
			return new 2380(this, 2);
		case (2451)6:
			return new 2376(this, 2);
		case (2451)7:
			return new 2378(this, 2);
		case (2451)8:
			return new 2375(this, 2);
		case (2451)9:
			return new 2383(this, 2);
		case (2451)10:
			return new 2393(this, 2);
		case (2451)11:
			return new 2395(this, 2);
		case (2451)12:
			return new 2394(this, 2);
		case (2451)13:
			return new 2398(this, 2);
		case (2451)14:
			return new 2396(this, 2);
		case (2451)24:
			return new 2374(this, 2);
		case (2451)25:
			return new 2392(this, 2);
		case (2451)26:
			return new 2391(this, 2);
		case (2451)28:
			return new 2438(this, 2);
		}
		return null;
	}

	// Token: 0x06002E0A RID: 11786 RVA: 0x00105EF4 File Offset: 0x001040F4
	internal void 23(2440.2443 1, bool 2)
	{
		if (this.currentAction != null)
		{
			if (2)
			{
				this.currentAction.ReplaceObjects(1, (2450)0);
			}
			else
			{
				this.currentAction.RecordObjects(1, (2450)0);
			}
			if (this.currentAction.5())
			{
				this.9.Remove(this.currentAction.1());
			}
		}
	}

	// Token: 0x020005D3 RID: 1491
	public sealed class 2443 : IEquatable<2440.2443>
	{
		// Token: 0x06002E0B RID: 11787 RVA: 0x00105F4C File Offset: 0x0010414C
		internal 2443(2123 1, int 2)
		{
			this.1 = 1;
			this.4(2);
			if (this.7(false))
			{
				List<208> 3 = 1.54;
				this.2(3.Count);
				this.4 = 3[2];
				this.6((2 > 0 && 3[2 - 1] == this.4) || (2 + 1 < 3.Count && 3[2 + 1] == this.4));
			}
		}

		// Token: 0x06002E0C RID: 11788 RVA: 0x00105FDB File Offset: 0x001041DB
		internal 2443(2123 1, int 2, 208 3)
		{
			this.1 = 1;
			this.4(2);
			this.2(1.54.Count);
			this.4 = 3;
		}

		// Token: 0x06002E0D RID: 11789 RVA: 0x00106009 File Offset: 0x00104209
		internal 2123 1()
		{
			return this.1;
		}

		// Token: 0x06002E0E RID: 11790 RVA: 0x00106011 File Offset: 0x00104211
		private void 2(int 1)
		{
			this.2 = 1;
		}

		// Token: 0x06002E0F RID: 11791 RVA: 0x0010601A File Offset: 0x0010421A
		internal int 3()
		{
			return this.3;
		}

		// Token: 0x06002E10 RID: 11792 RVA: 0x00106022 File Offset: 0x00104222
		internal void 4(int 1)
		{
			this.3 = 1;
		}

		// Token: 0x06002E11 RID: 11793 RVA: 0x0010602B File Offset: 0x0010422B
		internal bool 5()
		{
			return this.5;
		}

		// Token: 0x06002E12 RID: 11794 RVA: 0x00106033 File Offset: 0x00104233
		private void 6(bool 1)
		{
			this.5 = 1;
		}

		// Token: 0x06002E13 RID: 11795 RVA: 0x0010603C File Offset: 0x0010423C
		internal bool 7(bool 1)
		{
			if (this.1() == null || this.3() < 0)
			{
				return false;
			}
			if (1)
			{
				return this.3() <= this.1().54.Count;
			}
			return this.3() < this.1().54.Count;
		}

		// Token: 0x06002E14 RID: 11796 RVA: 0x00106093 File Offset: 0x00104293
		public bool Equals(2440.2443 1)
		{
			return 1 != null && this.1() == 1.1() && this.3() == 1.3();
		}

		// Token: 0x040021C6 RID: 8646
		private readonly 2123 1;

		// Token: 0x040021C7 RID: 8647
		private int 2;

		// Token: 0x040021C8 RID: 8648
		private int 3;

		// Token: 0x040021C9 RID: 8649
		internal 208 4;

		// Token: 0x040021CA RID: 8650
		private bool 5;
	}

	// Token: 0x020005D4 RID: 1492
	public sealed class 2442
	{
		// Token: 0x06002E15 RID: 11797 RVA: 0x001060B8 File Offset: 0x001042B8
		internal 2442(1254 1)
		{
			this.1.Add(1);
		}

		// Token: 0x06002E16 RID: 11798 RVA: 0x001060D7 File Offset: 0x001042D7
		internal 2442(List<1254> 1)
		{
			this.1.AddRange(1);
		}

		// Token: 0x06002E17 RID: 11799 RVA: 0x001060F6 File Offset: 0x001042F6
		internal 1254 Get(int 1)
		{
			return this.1[1];
		}

		// Token: 0x06002E18 RID: 11800 RVA: 0x00106104 File Offset: 0x00104304
		internal void Set(1254 1)
		{
			this.1.Clear();
			this.1.Add(1);
		}

		// Token: 0x06002E19 RID: 11801 RVA: 0x0010611D File Offset: 0x0010431D
		internal void Set(List<1254> 1)
		{
			this.1.Clear();
			this.1.AddRange(1);
		}

		// Token: 0x040021CB RID: 8651
		internal List<1254> 1 = new List<1254>();
	}

	// Token: 0x020005D5 RID: 1493
	public sealed class 2441
	{
		// Token: 0x06002E1A RID: 11802 RVA: 0x00106136 File Offset: 0x00104336
		internal 2441(1245 1)
		{
			this.1.Add(1);
		}

		// Token: 0x06002E1B RID: 11803 RVA: 0x00106155 File Offset: 0x00104355
		internal 2441(List<1245> 1)
		{
			this.1.AddRange(1);
		}

		// Token: 0x06002E1C RID: 11804 RVA: 0x00106174 File Offset: 0x00104374
		internal 1245 Get(int 1)
		{
			return this.1[1];
		}

		// Token: 0x06002E1D RID: 11805 RVA: 0x00106182 File Offset: 0x00104382
		internal void Set(1245 1)
		{
			this.1.Clear();
			this.1.Add(1);
		}

		// Token: 0x06002E1E RID: 11806 RVA: 0x0010619B File Offset: 0x0010439B
		internal void Set(List<1245> 1)
		{
			this.1.Clear();
			this.1.AddRange(1);
		}

		// Token: 0x040021CC RID: 8652
		internal List<1245> 1 = new List<1245>();
	}
}
