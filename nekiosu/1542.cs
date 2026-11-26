using System;
using System.Collections.Generic;

// Token: 0x02000A54 RID: 2644
public sealed class 1542
{
	// Token: 0x06004915 RID: 18709 RVA: 0x001D0E0B File Offset: 0x001CF00B
	internal 1542(1545 1, bool 2 = true)
	{
		this.1 = 1;
		this.2 = 2;
	}

	// Token: 0x06004916 RID: 18710 RVA: 0x001D0E2C File Offset: 0x001CF02C
	internal void 1(1082 1, 1081 2)
	{
		1542.1543 3 = this.4(1);
		if (3 != null)
		{
			3.2.Remove(2);
			3.2.Add(2);
		}
	}

	// Token: 0x06004917 RID: 18711 RVA: 0x001D0E5D File Offset: 0x001CF05D
	internal void 2(1082 1, 1081 2)
	{
		1542.1543 3 = this.4(1);
		if (3 == null)
		{
			return;
		}
		3.2.Remove(2);
	}

	// Token: 0x06004918 RID: 18712 RVA: 0x001D0E78 File Offset: 0x001CF078
	internal bool 3(1082 1)
	{
		if (!this.2)
		{
			return false;
		}
		1542.1543 2 = this.4(1);
		if (2 == null)
		{
			return false;
		}
		for (int i = 2.2.Count - 1; i >= 0; i--)
		{
			if ((bool)2.2[i].DynamicInvoke(new object[2]))
			{
				if (1 == (1082)8 && 1662.78 == 1677.Play && 1535.1())
				{
					1689 3 = 1662.92;
					string str = "click taken at input level ";
					int num = (int)this.1;
					1535.38(str + num.ToString() + ((3 != null) ? (", dialog open: \"" + 3.6 + "\"") : string.Empty));
				}
				return true;
			}
		}
		return false;
	}

	// Token: 0x06004919 RID: 18713 RVA: 0x001D0F2C File Offset: 0x001CF12C
	private 1542.1543 4(1082 1)
	{
		1542.1544 2 = new 1542.1544();
		2.1 = 1;
		1542.1543 3 = this.3.Find(new Predicate<1542.1543>(2.1));
		if (3 == null)
		{
			this.3.Add(3 = new 1542.1543(2.1));
		}
		return 3;
	}

	// Token: 0x04003687 RID: 13959
	internal 1545 1;

	// Token: 0x04003688 RID: 13960
	internal bool 2;

	// Token: 0x04003689 RID: 13961
	internal List<1542.1543> 3 = new List<1542.1543>();

	// Token: 0x02000A55 RID: 2645
	public sealed class 1543
	{
		// Token: 0x0600491A RID: 18714 RVA: 0x001D0F7A File Offset: 0x001CF17A
		public 1543(1082 1)
		{
			this.1 = 1;
		}

		// Token: 0x0400368A RID: 13962
		internal 1082 1;

		// Token: 0x0400368B RID: 13963
		internal List<1081> 2 = new List<1081>();
	}

	// Token: 0x02000A56 RID: 2646
	public sealed class 1544
	{
		// Token: 0x0600491B RID: 18715 RVA: 0x001D0F94 File Offset: 0x001CF194
		internal bool 1(1542.1543 1)
		{
			return 1.1 == this.1;
		}

		// Token: 0x0400368C RID: 13964
		public 1082 1;
	}
}
