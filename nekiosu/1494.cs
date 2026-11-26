using System;
using System.Threading;

// Token: 0x02000B14 RID: 2836
public sealed class 1494 : 1496
{
	// Token: 0x06004EC3 RID: 20163 RVA: 0x001F213C File Offset: 0x001F033C
	internal 1494(string 1, object 2, 208 3, float 4, bool 5, bool 6, 1445 7, bool 8) : base(1, 2, 3, 4, 5, 6, 7, 1f)
	{
		this.9 = 8;
		if (8)
		{
			this.7 = new 1433(1455.2("selection-tab-close", (1416)1, null), (1376)6, 1065.TopLeft, (1044)0, 3, 4 + 0.0002f, true, new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 1), null);
			this.7.48 = new 208(-49f, 8f);
			this.7.8 = this;
			this.4.Add(this.7);
			this.8 = new 1433(1455.2("selection-tab-close", (1416)1, null), (1376)6, 1065.TopLeft, (1044)0, 3, 4 + 0.0002f, true, new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 1), null);
			this.8.48 = new 208(-49f, 8f);
			this.8.10 = true;
			this.8.3(new EventHandler(this.6));
			this.8.8 = this;
			this.8.45 = -10f;
			this.8.35(new EventHandler(this.7));
			this.8.37(new EventHandler(this.8));
			this.4.Add(this.8);
			this.1.35(new EventHandler(this.4));
			this.1.37(new EventHandler(this.3));
		}
	}

	// Token: 0x06004EC4 RID: 20164 RVA: 0x001F22DF File Offset: 0x001F04DF
	private new void 3(object 1, EventArgs 2)
	{
		this.7.6 = new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 1);
		this.7.16 = 0.01f;
	}

	// Token: 0x06004EC5 RID: 20165 RVA: 0x001F2311 File Offset: 0x001F0511
	private new void 4(object 1, EventArgs 2)
	{
		this.7.6 = 198.White;
		this.7.16 = 0.4f;
	}

	// Token: 0x06004EC6 RID: 20166 RVA: 0x001F2334 File Offset: 0x001F0534
	internal new void 5(EventHandler 1)
	{
		EventHandler eventHandler = this.10;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, 1);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.10, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06004EC7 RID: 20167 RVA: 0x001F236C File Offset: 0x001F056C
	private void 6(object 1, EventArgs 2)
	{
		1226.20(null, "click-close", 1f, false);
		if (this.10 != null)
		{
			this.10(this, null);
		}
	}

	// Token: 0x06004EC8 RID: 20168 RVA: 0x001F23A7 File Offset: 0x001F05A7
	private void 7(object 1, EventArgs 2)
	{
		this.8.16 = this.1.16;
		this.8.6 = 198.White;
	}

	// Token: 0x06004EC9 RID: 20169 RVA: 0x001F23CF File Offset: 0x001F05CF
	private void 8(object 1, EventArgs 2)
	{
		this.8.16 = this.1.16 * 0.01f;
		this.8.6 = new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 1);
	}

	// Token: 0x04003ABB RID: 15035
	internal 1433 7;

	// Token: 0x04003ABC RID: 15036
	internal 1433 8;

	// Token: 0x04003ABD RID: 15037
	internal bool 9;

	// Token: 0x04003ABE RID: 15038
	private EventHandler 10;
}
