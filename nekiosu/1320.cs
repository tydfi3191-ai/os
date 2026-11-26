using System;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x02000B59 RID: 2905
public class 1320<TItem> : 1316, 1317 where TItem : IComparable
{
	// Token: 0x0600500C RID: 20492 RVA: 0x000055AC File Offset: 0x000037AC
	public 1320()
	{
	}

	// Token: 0x0600500D RID: 20493 RVA: 0x001F9089 File Offset: 0x001F7289
	public 1320(TItem 1)
	{
		this.SetValue(1);
	}

	// Token: 0x0600500E RID: 20494 RVA: 0x001F9098 File Offset: 0x001F7298
	[CompilerGenerated]
	public string GetConfigurationKey()
	{
		return this.3;
	}

	// Token: 0x0600500F RID: 20495 RVA: 0x001F90A0 File Offset: 0x001F72A0
	[CompilerGenerated]
	public void SetConfigurationKey(string 1)
	{
		this.3 = 1;
	}

	// Token: 0x06005010 RID: 20496 RVA: 0x001F90A9 File Offset: 0x001F72A9
	public bool 1()
	{
		return object.Equals(this.1, this.2);
	}

	// Token: 0x06005011 RID: 20497 RVA: 0x001F90C8 File Offset: 0x001F72C8
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

	// Token: 0x06005012 RID: 20498 RVA: 0x001F9100 File Offset: 0x001F7300
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

	// Token: 0x06005013 RID: 20499 RVA: 0x001F9135 File Offset: 0x001F7335
	public virtual TItem GetValue()
	{
		return this.1;
	}

	// Token: 0x06005014 RID: 20500 RVA: 0x001F9140 File Offset: 0x001F7340
	public virtual void SetValue(TItem 1)
	{
		if (default(TItem) != null)
		{
			if (this.1.CompareTo(1) == 0)
			{
				return;
			}
		}
		else
		{
			TItem titem = this.1;
			if (titem != null && titem.CompareTo(1) == 0)
			{
				return;
			}
		}
		this.1 = 1;
		this.2();
	}

	// Token: 0x06005015 RID: 20501 RVA: 0x001F91A9 File Offset: 0x001F73A9
	public static implicit operator TItem(1320<TItem> 1)
	{
		return 1.GetValue();
	}

	// Token: 0x06005016 RID: 20502 RVA: 0x001F91B1 File Offset: 0x001F73B1
	public static implicit operator 1320<TItem>(TItem 1)
	{
		return new 1320<TItem>(1);
	}

	// Token: 0x06005017 RID: 20503 RVA: 0x001F91B9 File Offset: 0x001F73B9
	public object GetBoxedValue()
	{
		return this.GetValue();
	}

	// Token: 0x06005018 RID: 20504 RVA: 0x001F91C8 File Offset: 0x001F73C8
	public void SetBoxedValue(object 1)
	{
		try
		{
			this.SetValue((TItem)((object)1));
		}
		catch
		{
		}
	}

	// Token: 0x06005019 RID: 20505 RVA: 0x001F91F8 File Offset: 0x001F73F8
	internal void 2()
	{
		if (this.4 != null)
		{
			this.4(this, null);
		}
	}

	// Token: 0x0600501A RID: 20506 RVA: 0x001F920F File Offset: 0x001F740F
	public void ClearChangedHandlers()
	{
		this.4 = null;
	}

	// Token: 0x0600501B RID: 20507 RVA: 0x001F9218 File Offset: 0x001F7418
	public override string ToString()
	{
		return this.1.ToString();
	}

	// Token: 0x0600501C RID: 20508 RVA: 0x001F922B File Offset: 0x001F742B
	internal void 3()
	{
		this.SetValue(this.2);
	}

	// Token: 0x04003CA4 RID: 15524
	private TItem 1;

	// Token: 0x04003CA5 RID: 15525
	public TItem 2;

	// Token: 0x04003CA6 RID: 15526
	private string 3;

	// Token: 0x04003CA7 RID: 15527
	private EventHandler 4;
}
