using System;
using System.Collections.Generic;

// Token: 0x02000ADC RID: 2780
public sealed class 1453
{
	// Token: 0x06004D75 RID: 19829 RVA: 0x001EB15A File Offset: 0x001E935A
	public 1453(int 1, int 2)
	{
		this.3 = 1;
		this.4 = 2;
	}

	// Token: 0x06004D76 RID: 19830 RVA: 0x001EB17B File Offset: 0x001E937B
	public void Reset()
	{
		this.1.Clear();
		this.5 = 0;
		this.2 = new 1402(this.3, this.4);
	}

	// Token: 0x06004D77 RID: 19831 RVA: 0x001EB1A8 File Offset: 0x001E93A8
	private 206 1(int 1, int 2)
	{
		206 3 = new 206(0, this.5);
		if (this.5 + 2 > this.4)
		{
			this.Reset();
			return new 206(0, 0);
		}
		int num = this.5;
		foreach (207 4 in this.1)
		{
			3.X = Math.Max(3.X, 4.GetRight() + 1);
			num = Math.Max(num, 4.GetBottom());
		}
		if (3.X + 1 > this.3)
		{
			this.5 = num + 1;
			this.1.Clear();
			return this.1(1, 2);
		}
		return 3;
	}

	// Token: 0x06004D78 RID: 19832 RVA: 0x001EB280 File Offset: 0x001E9480
	public 1381 2(int 1, int 2)
	{
		1381 result;
		lock (this)
		{
			if (this.2 == null)
			{
				this.Reset();
			}
			206 3 = this.1(1, 2);
			207 item = new 207(3.X, 3.Y, 1, 2);
			this.1.Add(item);
			result = new 1381(new 1412(item, this.2), this);
		}
		return result;
	}

	// Token: 0x040039B9 RID: 14777
	private List<207> 1 = new List<207>();

	// Token: 0x040039BA RID: 14778
	private 1402 2;

	// Token: 0x040039BB RID: 14779
	private int 3;

	// Token: 0x040039BC RID: 14780
	private int 4;

	// Token: 0x040039BD RID: 14781
	private int 5;
}
