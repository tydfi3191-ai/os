using System;
using System.Threading;

// Token: 0x02000875 RID: 2165
public abstract class 1802
{
	// Token: 0x06003E6C RID: 15980 RVA: 0x0018646F File Offset: 0x0018466F
	internal 1131 1()
	{
		return this.1;
	}

	// Token: 0x06003E6D RID: 15981 RVA: 0x00186477 File Offset: 0x00184677
	internal void 2(1131 1)
	{
		this.1 = 1;
	}

	// Token: 0x06003E6E RID: 15982 RVA: 0x00186480 File Offset: 0x00184680
	internal void 3(EventHandler 1)
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

	// Token: 0x06003E6F RID: 15983 RVA: 0x001864B8 File Offset: 0x001846B8
	internal void 4(EventHandler 1)
	{
		EventHandler eventHandler = this.6;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, 1);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.6, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06003E70 RID: 15984
	internal abstract void SetFlag10615_13769();

	// Token: 0x06003E71 RID: 15985
	public abstract 1379 GetGLWindow();

	// Token: 0x06003E72 RID: 15986 RVA: 0x001864ED File Offset: 0x001846ED
	protected void 5(object 1, EventArgs 2)
	{
		EventHandler eventHandler = this.3;
		if (eventHandler == null)
		{
			return;
		}
		eventHandler(this, EventArgs.Empty);
	}

	// Token: 0x06003E73 RID: 15987 RVA: 0x00186505 File Offset: 0x00184705
	protected void 6(object 1, EventArgs 2)
	{
		EventHandler eventHandler = this.4;
		if (eventHandler == null)
		{
			return;
		}
		eventHandler(this, EventArgs.Empty);
	}

	// Token: 0x06003E74 RID: 15988 RVA: 0x0018651D File Offset: 0x0018471D
	protected void 7(object 1, EventArgs 2)
	{
		EventHandler eventHandler = this.5;
		if (eventHandler == null)
		{
			return;
		}
		eventHandler(this, EventArgs.Empty);
	}

	// Token: 0x06003E75 RID: 15989 RVA: 0x00186535 File Offset: 0x00184735
	protected void 8(object 1, EventArgs 2)
	{
		EventHandler eventHandler = this.6;
		if (eventHandler == null)
		{
			return;
		}
		eventHandler(this, EventArgs.Empty);
	}

	// Token: 0x06003E76 RID: 15990
	internal abstract void RunMessageLoop();

	// Token: 0x04002DBB RID: 11707
	private 1131 1;

	// Token: 0x04002DBC RID: 11708
	public 1314<bool> 2;

	// Token: 0x04002DBD RID: 11709
	private EventHandler 3;

	// Token: 0x04002DBE RID: 11710
	private EventHandler 4;

	// Token: 0x04002DBF RID: 11711
	private EventHandler 5;

	// Token: 0x04002DC0 RID: 11712
	private EventHandler 6;
}
