using System;
using System.Collections.Generic;
using System.Threading;

// Token: 0x02000B16 RID: 2838
public class 1496
{
	// Token: 0x06004ED1 RID: 20177 RVA: 0x001F2654 File Offset: 0x001F0854
	internal 1496(string 1, object 2, 208 3, float 4, bool 5, bool 6, 1445 7, float 8 = 1f)
	{
		this.1 = new 1433(6 ? 1455.2("selection-tab", (1416)7, null) : 1455.2("selection-tab", (1416)1, null), (1376)6, 1065.TopLeft, (1044)0, 3, 4, true, 7.3, null);
		if (5)
		{
			this.1.43(true);
		}
		this.1.42 = 7;
		this.1.35(new EventHandler(1496.1497.tabButtonCallbacks.1));
		this.1.48 = new 208(70f, 12f);
		this.1.8 = this;
		this.3 = (2 ?? this);
		int num = (int)(13f / 8);
		if (!string.IsNullOrEmpty(1))
		{
			1 = ((1.Length > num) ? (1.Remove(num) + "..") : 1);
			this.1.10 = true;
			this.1.3(new EventHandler(this.2));
		}
		else
		{
			this.1.6 = new 198(160, 8, 42);
		}
		this.2 = new 1452(1, 12f * 8, 3, new 208(82f, 12f) * 8, 4 + 0.0001f, true, 198.White, false);
		this.2.54(true);
		this.2.63(true);
		this.2.49 = 1065.Centre;
		this.2.75 = (1066)2;
		this.4.Add(this.1);
		this.4.Add(this.2);
	}

	// Token: 0x06004ED2 RID: 20178 RVA: 0x0001702D File Offset: 0x0001522D
	internal virtual bool IsSelectable()
	{
		return true;
	}

	// Token: 0x06004ED3 RID: 20179 RVA: 0x001F2810 File Offset: 0x001F0A10
	internal void 1(EventHandler 1)
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

	// Token: 0x06004ED4 RID: 20180 RVA: 0x001F2845 File Offset: 0x001F0A45
	protected void 2(object 1, EventArgs 2)
	{
		if (this.6 != null)
		{
			this.6(this, null);
		}
	}

	// Token: 0x04003AC4 RID: 15044
	internal 1433 1;

	// Token: 0x04003AC5 RID: 15045
	internal 1452 2;

	// Token: 0x04003AC6 RID: 15046
	internal object 3;

	// Token: 0x04003AC7 RID: 15047
	internal List<1433> 4 = new List<1433>();

	// Token: 0x04003AC8 RID: 15048
	internal bool 5;

	// Token: 0x04003AC9 RID: 15049
	private EventHandler 6;

	// Token: 0x02000B17 RID: 2839
	[Serializable]
	public sealed class 1497
	{
		// Token: 0x06004ED5 RID: 20181 RVA: 0x001F285C File Offset: 0x001F0A5C
		internal void 1(object 1, EventArgs 2)
		{
			1226.20(null, "click-short", 1f, false);
		}

		// Token: 0x04003ACA RID: 15050
		public static readonly 1496.1497 tabButtonCallbacks = new 1496.1497();

		// Token: 0x04003ACB RID: 15051
		public static EventHandler eventHandler;
	}
}
