using System;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x02000B52 RID: 2898
public sealed class 1313 : 1317
{
	// Token: 0x06004FD0 RID: 20432 RVA: 0x001F8B86 File Offset: 0x001F6D86
	public 1313(bool 1 = false)
	{
		this.1 = 1;
	}

	// Token: 0x06004FD1 RID: 20433 RVA: 0x001F8B95 File Offset: 0x001F6D95
	[CompilerGenerated]
	public string GetConfigurationKey()
	{
		return this.3;
	}

	// Token: 0x06004FD2 RID: 20434 RVA: 0x001F8B9D File Offset: 0x001F6D9D
	[CompilerGenerated]
	public void SetConfigurationKey(string 1)
	{
		this.3 = 1;
	}

	// Token: 0x06004FD3 RID: 20435 RVA: 0x001F8BA6 File Offset: 0x001F6DA6
	public bool 1()
	{
		return this.1;
	}

	// Token: 0x06004FD4 RID: 20436 RVA: 0x001F8BAE File Offset: 0x001F6DAE
	public void 2(bool 1)
	{
		if (1 != this.1)
		{
			this.1 = 1;
			this.3();
		}
	}

	// Token: 0x06004FD5 RID: 20437 RVA: 0x001F8BC6 File Offset: 0x001F6DC6
	internal void 3()
	{
		if (this.4 != null)
		{
			this.4(this, null);
		}
	}

	// Token: 0x06004FD6 RID: 20438 RVA: 0x001F8BDD File Offset: 0x001F6DDD
	public static implicit operator bool(1313 1)
	{
		return 1 != null && 1.1();
	}

	// Token: 0x06004FD7 RID: 20439 RVA: 0x001F8BEA File Offset: 0x001F6DEA
	public static implicit operator 1313(bool 1)
	{
		return new 1313(1);
	}

	// Token: 0x06004FD8 RID: 20440 RVA: 0x001F8BF2 File Offset: 0x001F6DF2
	public override string ToString()
	{
		if (!this.1)
		{
			return "0";
		}
		return "1";
	}

	// Token: 0x06004FD9 RID: 20441 RVA: 0x001F8C07 File Offset: 0x001F6E07
	public void 4()
	{
		this.2(!this.1());
	}

	// Token: 0x06004FDA RID: 20442 RVA: 0x001F8C18 File Offset: 0x001F6E18
	public void ClearChangedHandlers()
	{
		this.4 = null;
	}

	// Token: 0x06004FDB RID: 20443 RVA: 0x001F8C21 File Offset: 0x001F6E21
	public bool 5()
	{
		return this.1 == this.2;
	}

	// Token: 0x06004FDC RID: 20444 RVA: 0x001F8C34 File Offset: 0x001F6E34
	[CompilerGenerated]
	public void SubscribeChanged(EventHandler 1)
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

	// Token: 0x06004FDD RID: 20445 RVA: 0x001F8C6C File Offset: 0x001F6E6C
	[CompilerGenerated]
	public void UnsubscribeChanged(EventHandler 1)
	{
		EventHandler eventHandler = this.4;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, 1);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.4, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x04003C93 RID: 15507
	private bool 1;

	// Token: 0x04003C94 RID: 15508
	public bool 2;

	// Token: 0x04003C95 RID: 15509
	private string 3;

	// Token: 0x04003C96 RID: 15510
	private EventHandler 4;
}
