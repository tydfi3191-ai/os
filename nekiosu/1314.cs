using System;
using System.Threading;

// Token: 0x02000B53 RID: 2899
public sealed class 1314<TItem> : 1320<TItem>, IDisposable where TItem : IComparable
{
	// Token: 0x06004FDE RID: 20446 RVA: 0x001F8CA4 File Offset: 0x001F6EA4
	public 1314(1314<TItem>.1315<TItem> 1, int 2 = 1000, bool 3 = false)
	{
		this.5 = 2;
		this.7 = 1;
		this.5();
		if (3)
		{
			this.9 = 1662.90.2(new 1189(this.5), 2, true);
		}
	}

	// Token: 0x06004FDF RID: 20447 RVA: 0x001F8CFA File Offset: 0x001F6EFA
	internal bool 4()
	{
		return this.9 != null;
	}

	// Token: 0x06004FE0 RID: 20448 RVA: 0x001F8D05 File Offset: 0x001F6F05
	internal void 5()
	{
		base.SetValue(this.7());
		this.8 = 1662.33;
	}

	// Token: 0x06004FE1 RID: 20449 RVA: 0x001F8D23 File Offset: 0x001F6F23
	private bool 6()
	{
		return this.8 < 0 || 1662.33 > this.8 + this.5;
	}

	// Token: 0x06004FE2 RID: 20450 RVA: 0x001F8D44 File Offset: 0x001F6F44
	public override TItem GetValue()
	{
		if (this.6())
		{
			if (!this.4())
			{
				1662.89.Schedule(new 1189(this.5), false);
			}
			if (!this.6)
			{
				while (this.6() && !this.10)
				{
					Thread.Sleep(1);
				}
			}
		}
		return base.GetValue();
	}

	// Token: 0x06004FE3 RID: 20451 RVA: 0x001F8D9F File Offset: 0x001F6F9F
	public override void SetValue(TItem 1)
	{
		throw new Exception("Can't directly set a cached property!");
	}

	// Token: 0x06004FE4 RID: 20452 RVA: 0x001F8DAB File Offset: 0x001F6FAB
	protected void 7(bool 1)
	{
		if (!this.10)
		{
			1187 2 = this.9;
			if (2 != null)
			{
				2.Cancel();
			}
			this.10 = true;
		}
	}

	// Token: 0x06004FE5 RID: 20453 RVA: 0x001F8DD0 File Offset: 0x001F6FD0
	~1314()
	{
		this.7(false);
	}

	// Token: 0x06004FE6 RID: 20454 RVA: 0x001F8E00 File Offset: 0x001F7000
	private void 8()
	{
		this.7(true);
		GC.SuppressFinalize(this);
	}

	// Token: 0x06004FE7 RID: 20455 RVA: 0x001F8E0F File Offset: 0x001F700F
	void IDisposable.Dispose()
	{
		this.8();
	}

	// Token: 0x04003C97 RID: 15511
	internal readonly int 5;

	// Token: 0x04003C98 RID: 15512
	internal bool 6 = true;

	// Token: 0x04003C99 RID: 15513
	private 1314<TItem>.1315<TItem> 7;

	// Token: 0x04003C9A RID: 15514
	private int 8 = -1;

	// Token: 0x04003C9B RID: 15515
	private 1187 9;

	// Token: 0x04003C9C RID: 15516
	private bool 10;

	// Token: 0x02000B54 RID: 2900
	// (Invoke) Token: 0x06004FE9 RID: 20457
	public delegate TItem 1315<TItem>();
}
