using System;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x02000B58 RID: 2904
public class 1319 : 1317
{
	// Token: 0x06004FFC RID: 20476 RVA: 0x001F8E96 File Offset: 0x001F7096
	public 1319(double 1 = 0.0)
	{
		this.1 = 1;
	}

	// Token: 0x06004FFD RID: 20477 RVA: 0x001F8ED2 File Offset: 0x001F70D2
	[CompilerGenerated]
	public string GetConfigurationKey()
	{
		return this.5;
	}

	// Token: 0x06004FFE RID: 20478 RVA: 0x001F8EDA File Offset: 0x001F70DA
	[CompilerGenerated]
	public void SetConfigurationKey(string 1)
	{
		this.5 = 1;
	}

	// Token: 0x06004FFF RID: 20479 RVA: 0x001F8EE3 File Offset: 0x001F70E3
	internal double 1()
	{
		return this.2;
	}

	// Token: 0x06005000 RID: 20480 RVA: 0x001F8EEB File Offset: 0x001F70EB
	internal void 2(double 1)
	{
		this.2 = 1;
		if (this.2 > this.1)
		{
			this.1 = this.2;
		}
	}

	// Token: 0x06005001 RID: 20481 RVA: 0x001F8F0E File Offset: 0x001F710E
	internal double 3()
	{
		return this.3;
	}

	// Token: 0x06005002 RID: 20482 RVA: 0x001F8F16 File Offset: 0x001F7116
	internal void 4(double 1)
	{
		this.3 = 1;
		if (this.1 > this.3)
		{
			this.1 = this.3;
		}
	}

	// Token: 0x06005003 RID: 20483 RVA: 0x001F8F39 File Offset: 0x001F7139
	public virtual double GetValue()
	{
		return this.1;
	}

	// Token: 0x06005004 RID: 20484 RVA: 0x001F8F44 File Offset: 0x001F7144
	public virtual void SetValue(double 1)
	{
		double num = 1;
		if (num > this.3())
		{
			num = this.3();
		}
		else if (num < this.1())
		{
			num = this.1();
		}
		if (this.6 > 5E-324)
		{
			num = Math.Round(num / this.6) * this.6;
		}
		if (num != this.1)
		{
			this.1 = num;
			if (this.7 != null)
			{
				this.7(this, null);
			}
		}
	}

	// Token: 0x06005005 RID: 20485 RVA: 0x001F8FC0 File Offset: 0x001F71C0
	public static implicit operator double(1319 1)
	{
		if (1 == null)
		{
			return 0.0;
		}
		return 1.GetValue();
	}

	// Token: 0x06005006 RID: 20486 RVA: 0x001F8FD5 File Offset: 0x001F71D5
	public static implicit operator 1319(double 1)
	{
		return new 1319(1);
	}

	// Token: 0x06005007 RID: 20487 RVA: 0x001F8FDD File Offset: 0x001F71DD
	public override string ToString()
	{
		return this.1.ToString("0.##", 1662.18);
	}

	// Token: 0x06005008 RID: 20488 RVA: 0x001F8FF4 File Offset: 0x001F71F4
	public void ClearChangedHandlers()
	{
		this.7 = null;
	}

	// Token: 0x06005009 RID: 20489 RVA: 0x001F8FFD File Offset: 0x001F71FD
	public bool 5()
	{
		return Math.Abs(this.1 - this.4) < this.6;
	}

	// Token: 0x0600500A RID: 20490 RVA: 0x001F901C File Offset: 0x001F721C
	[CompilerGenerated]
	public void SubscribeChanged(EventHandler 1)
	{
		EventHandler eventHandler = this.7;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, 1);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.7, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x0600500B RID: 20491 RVA: 0x001F9054 File Offset: 0x001F7254
	[CompilerGenerated]
	public void UnsubscribeChanged(EventHandler 1)
	{
		EventHandler eventHandler = this.7;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, 1);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.7, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x04003C9D RID: 15517
	private double 1;

	// Token: 0x04003C9E RID: 15518
	private double 2 = double.MinValue;

	// Token: 0x04003C9F RID: 15519
	private double 3 = double.MaxValue;

	// Token: 0x04003CA0 RID: 15520
	public double 4;

	// Token: 0x04003CA1 RID: 15521
	private string 5;

	// Token: 0x04003CA2 RID: 15522
	public double 6 = 0.01;

	// Token: 0x04003CA3 RID: 15523
	private EventHandler 7;
}
