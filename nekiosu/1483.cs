using System;
using System.Collections.Generic;
using System.Threading;

// Token: 0x02000B02 RID: 2818
public sealed class 1483 : IDisposable
{
	// Token: 0x06004E63 RID: 20067 RVA: 0x001EFFCC File Offset: 0x001EE1CC
	internal 1483(1436 1) : this(1, new List<1482>())
	{
	}

	// Token: 0x06004E64 RID: 20068 RVA: 0x001EFFDA File Offset: 0x001EE1DA
	internal 1483(1436 1, List<1482> 2)
	{
		this.1 = 2;
		this.2 = 1;
		this.3 = false;
		1535.40((1082)8, new 1081(this.OnClick), 1545.Default, (1559)0);
	}

	// Token: 0x06004E65 RID: 20069 RVA: 0x001F000B File Offset: 0x001EE20B
	internal void 1()
	{
		if (this.2())
		{
			this.Hide();
			return;
		}
		this.Show();
	}

	// Token: 0x06004E66 RID: 20070 RVA: 0x001F0024 File Offset: 0x001EE224
	internal void Show()
	{
		this.3 = true;
		this.4 = true;
		int num = 0;
		foreach (1482 <<EMPTY_NAME>> in this.1)
		{
			<<EMPTY_NAME>>.Show(num);
			num += 20;
		}
	}

	// Token: 0x06004E67 RID: 20071 RVA: 0x001F008C File Offset: 0x001EE28C
	internal void Hide()
	{
		this.3 = false;
		foreach (1482 <<EMPTY_NAME>> in this.1)
		{
			<<EMPTY_NAME>>.Hide();
		}
	}

	// Token: 0x06004E68 RID: 20072 RVA: 0x001F00E4 File Offset: 0x001EE2E4
	internal bool 2()
	{
		return this.3;
	}

	// Token: 0x06004E69 RID: 20073 RVA: 0x001F00EC File Offset: 0x001EE2EC
	internal void 3()
	{
		foreach (1482 <<EMPTY_NAME>> in this.1)
		{
			<<EMPTY_NAME>>.Dispose();
		}
		this.1.Clear();
	}

	// Token: 0x06004E6A RID: 20074 RVA: 0x001F0148 File Offset: 0x001EE348
	internal void 4(EventHandler 1)
	{
		EventHandler eventHandler = this.5;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, 1);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.5, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06004E6B RID: 20075 RVA: 0x001F017D File Offset: 0x001EE37D
	private bool OnClick(object 1, EventArgs 2)
	{
		if (this.2() && !this.4)
		{
			this.Hide();
			if (this.5 != null)
			{
				this.5(this, EventArgs.Empty);
			}
			return true;
		}
		this.4 = false;
		return false;
	}

	// Token: 0x06004E6C RID: 20076 RVA: 0x001F01B8 File Offset: 0x001EE3B8
	public void Dispose()
	{
		this.3();
	}

	// Token: 0x04003A71 RID: 14961
	internal List<1482> 1;

	// Token: 0x04003A72 RID: 14962
	private 1436 2;

	// Token: 0x04003A73 RID: 14963
	private bool 3;

	// Token: 0x04003A74 RID: 14964
	private bool 4;

	// Token: 0x04003A75 RID: 14965
	private EventHandler 5;
}
