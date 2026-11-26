using System;
using System.Threading;

// Token: 0x020008AE RID: 2222
public sealed class 1771 : 1779
{
	// Token: 0x06003F97 RID: 16279 RVA: 0x0018A223 File Offset: 0x00188423
	internal 1771(2679 1, 1313 2, EventHandler 3 = null) : this(1568.1(1), 1568.1(1 + 1), 2, 3)
	{
		base.10(1.ToString());
	}

	// Token: 0x06003F98 RID: 16280 RVA: 0x0018A24E File Offset: 0x0018844E
	internal 1771(string 1, string 2, 1313 3 = null, EventHandler 4 = null) : this(1, 2, 3 != null && 3.1(), 4)
	{
		this.13 = 3;
		if (3 != null)
		{
			3.SubscribeChanged(new EventHandler(this.19));
		}
	}

	// Token: 0x06003F99 RID: 16281 RVA: 0x0018A284 File Offset: 0x00188484
	internal 1771(string 1, string 2, bool 3 = false, EventHandler 4 = null)
	{
		1364 5 = new 1364(6, 0.8f, 208.Zero, 1f, 3, 244f);
		5.6(7);
		this.15 = 5;
		this.15.9(delegate(object 1, bool 2)
		{
			this.13.2(2);
			if (this.14 != null)
			{
				this.14(this, null);
			}
		});
		if (4 != null)
		{
			this.18(4);
		}
		this.1.14<1433>(this.15.2);
		base.10(6);
		base.10(7);
		this.20(6);
	}

	// Token: 0x06003F9A RID: 16282 RVA: 0x0018A310 File Offset: 0x00188510
	private void 18(EventHandler 1)
	{
		EventHandler eventHandler = this.14;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, 1);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.14, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06003F9B RID: 16283 RVA: 0x0018A345 File Offset: 0x00188545
	internal override bool IsDefaultValue()
	{
		1313 <<EMPTY_NAME>> = this.13;
		return <<EMPTY_NAME>> == null || <<EMPTY_NAME>>.5();
	}

	// Token: 0x06003F9C RID: 16284 RVA: 0x0018A358 File Offset: 0x00188558
	protected override void ResetToDefault()
	{
		this.13.2(this.13.2);
		base.ResetToDefault();
	}

	// Token: 0x06003F9D RID: 16285 RVA: 0x0018A376 File Offset: 0x00188576
	private void 19(object 1, EventArgs 2)
	{
		this.15.7(this.13.1());
		base.1();
	}

	// Token: 0x06003F9E RID: 16286 RVA: 0x0018A394 File Offset: 0x00188594
	internal void 20(string 1)
	{
		this.15.3(1);
		this.15.2.ForEach(new Action<1433>(this.22));
		base.3(new 208(20f, 0f) + this.15.5.GetTextSize());
	}

	// Token: 0x06003F9F RID: 16287 RVA: 0x0018A3F3 File Offset: 0x001885F3
	public override void Dispose()
	{
		base.Dispose();
		if (this.13 != null)
		{
			this.13.UnsubscribeChanged(new EventHandler(this.19));
		}
	}

	// Token: 0x06003FA0 RID: 16288 RVA: 0x0018A41A File Offset: 0x0018861A
	internal void 21(bool 1)
	{
		this.15.2(1);
	}

	// Token: 0x06003FA1 RID: 16289 RVA: 0x0018A428 File Offset: 0x00188628
	private void 22(1433 1)
	{
		1.17 = 1.7 + new 208(0f, -8f + this.15.5.GetTextSize().Y / 2f);
	}

	// Token: 0x04002E85 RID: 11909
	private new 1313 13;

	// Token: 0x04002E86 RID: 11910
	private new EventHandler 14;

	// Token: 0x04002E87 RID: 11911
	internal new 1364 15;
}
