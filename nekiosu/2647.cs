using System;
using System.Collections.Generic;

// Token: 0x02000459 RID: 1113
public abstract class 2647 : IComparable<2647>
{
	// Token: 0x0600221B RID: 8731 RVA: 0x00092F90 File Offset: 0x00091190
	internal virtual int GetDuration()
	{
		return this.1 - this.8;
	}

	// Token: 0x0600221C RID: 8732
	internal abstract void SetStartTime(int 1);

	// Token: 0x0600221D RID: 8733
	internal abstract void SetEndTime(int 1);

	// Token: 0x0600221E RID: 8734
	internal abstract bool LoadTextures();

	// Token: 0x0600221F RID: 8735
	internal abstract 2647 Clone();

	// Token: 0x06002220 RID: 8736 RVA: 0x00092FA0 File Offset: 0x000911A0
	internal void 1(2657 1)
	{
		2656 2 = 1.4;
		List<2657> list;
		if (!this.2.TryGetValue(2.2(), out list))
		{
			list = new List<2657>();
			this.2.Add(2.2(), list);
		}
		list.Add(1);
		this.7.5 = true;
		this.7.16 = 0f;
		2.Attach(this, 1, this.7);
	}

	// Token: 0x06002221 RID: 8737 RVA: 0x00093014 File Offset: 0x00091214
	internal void 2(2659 1)
	{
		List<2657> list;
		if (!this.2.TryGetValue(1, out list))
		{
			return;
		}
		foreach (2657 2 in list)
		{
			this.3(2);
		}
	}

	// Token: 0x06002222 RID: 8738 RVA: 0x00093074 File Offset: 0x00091274
	internal void 3(2657 1)
	{
		List<1445> list = 1.1();
		if (list == null)
		{
			return;
		}
		foreach (1445 item in list)
		{
			this.7.3.Remove(item);
		}
	}

	// Token: 0x06002223 RID: 8739 RVA: 0x000930D8 File Offset: 0x000912D8
	public int CompareTo(2647 1)
	{
		int num = this.8.CompareTo(1.8);
		if (num != 0)
		{
			return num;
		}
		return this.10.CompareTo(1.10);
	}

	// Token: 0x04001786 RID: 6022
	internal int 1;

	// Token: 0x04001787 RID: 6023
	internal Dictionary<2659, List<2657>> 2 = new Dictionary<2659, List<2657>>();

	// Token: 0x04001788 RID: 6024
	internal string 3;

	// Token: 0x04001789 RID: 6025
	internal int 4;

	// Token: 0x0400178A RID: 6026
	internal 2645 5;

	// Token: 0x0400178B RID: 6027
	internal bool 6;

	// Token: 0x0400178C RID: 6028
	internal 1433 7;

	// Token: 0x0400178D RID: 6029
	internal int 8;

	// Token: 0x0400178E RID: 6030
	public bool 9;

	// Token: 0x0400178F RID: 6031
	internal 2635 10;

	// Token: 0x04001790 RID: 6032
	internal bool 11;
}
