using System;
using System.Threading;

// Token: 0x02000BF5 RID: 3061
public abstract class 1131
{
	// Token: 0x06005389 RID: 21385 RVA: 0x0020B2AB File Offset: 0x002094AB
	internal 1131()
	{
	}

	// Token: 0x0600538A RID: 21386
	public abstract 207 GetClientBounds();

	// Token: 0x0600538B RID: 21387
	public abstract IntPtr GetWindowHandle();

	// Token: 0x0600538C RID: 21388
	public abstract bool HasEmptyClientArea();

	// Token: 0x0600538D RID: 21389 RVA: 0x0020B2C0 File Offset: 0x002094C0
	public void 1(string 1)
	{
		if (1 != null && !(this.1 == 1))
		{
			this.1 = 1;
			this.ApplyTitle(1);
		}
	}

	// Token: 0x0600538E RID: 21390 RVA: 0x0020B2F0 File Offset: 0x002094F0
	internal void 2(EventHandler 1)
	{
		EventHandler eventHandler = this.2;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, 1);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.2, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600538F RID: 21391 RVA: 0x0020B328 File Offset: 0x00209528
	internal void 3(EventHandler 1)
	{
		EventHandler eventHandler = this.4;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, 1);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.4, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06005390 RID: 21392 RVA: 0x0020B360 File Offset: 0x00209560
	public void 4(EventHandler 1)
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

	// Token: 0x06005391 RID: 21393 RVA: 0x0020B395 File Offset: 0x00209595
	protected void 5()
	{
		EventHandler eventHandler = this.2;
		if (eventHandler == null)
		{
			return;
		}
		eventHandler(this, EventArgs.Empty);
	}

	// Token: 0x06005392 RID: 21394 RVA: 0x0020B3AD File Offset: 0x002095AD
	protected void 6()
	{
		EventHandler eventHandler = this.3;
		if (eventHandler == null)
		{
			return;
		}
		eventHandler(this, EventArgs.Empty);
	}

	// Token: 0x06005393 RID: 21395 RVA: 0x0020B3C5 File Offset: 0x002095C5
	protected void 7()
	{
		EventHandler eventHandler = this.4;
		if (eventHandler == null)
		{
			return;
		}
		eventHandler(this, EventArgs.Empty);
	}

	// Token: 0x06005394 RID: 21396 RVA: 0x0020B3DD File Offset: 0x002095DD
	protected void 8()
	{
		EventHandler eventHandler = this.5;
		if (eventHandler == null)
		{
			return;
		}
		eventHandler(this, EventArgs.Empty);
	}

	// Token: 0x06005395 RID: 21397 RVA: 0x0020B3F5 File Offset: 0x002095F5
	protected void 9()
	{
		EventHandler eventHandler = this.6;
		if (eventHandler == null)
		{
			return;
		}
		eventHandler(this, EventArgs.Empty);
	}

	// Token: 0x06005396 RID: 21398
	protected abstract void ApplyTitle(string 1);

	// Token: 0x04003F70 RID: 16240
	private string 1 = string.Empty;

	// Token: 0x04003F71 RID: 16241
	private EventHandler 2;

	// Token: 0x04003F72 RID: 16242
	private EventHandler 3;

	// Token: 0x04003F73 RID: 16243
	private EventHandler 4;

	// Token: 0x04003F74 RID: 16244
	private EventHandler 5;

	// Token: 0x04003F75 RID: 16245
	private EventHandler 6;
}
