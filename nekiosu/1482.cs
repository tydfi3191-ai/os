using System;
using System.Collections.Generic;
using System.Threading;

// Token: 0x02000B01 RID: 2817
public sealed class 1482 : IDisposable
{
	// Token: 0x06004E5B RID: 20059 RVA: 0x001EFB98 File Offset: 0x001EDD98
	internal 1482(1483 1, 1436 2, 208 3, 208 4, bool 5)
	{
		this.1 = 3;
		this.2 = 4;
		this.12 = 1;
		this.13 = 2;
		this.3 = 5;
		this.4 = false;
		198 6 = 5 ? this.8 : this.6;
		this.11 = new 1433(1455.2("opaque-white", (1416)1, null), (1376)6, 1065.TopLeft, (1044)0, new 208(4.X, 4.Y), 0.99f, true, 198.TransparentBlack, null);
		this.11.20 = new 208(3.X / 16f, 3.Y / 16f);
		this.11.43 = new List<1445>();
		this.11.43.Add(new 1445(6, this.7, 0, 10));
		this.11.44 = new List<1445>();
		this.11.44.Add(new 1445(this.7, 6, 0, 100));
		this.11.3(new EventHandler(this.2));
		this.13.12(this.11);
	}

	// Token: 0x06004E5C RID: 20060 RVA: 0x001EFD20 File Offset: 0x001EDF20
	internal void Show(int 1)
	{
		if (this.4)
		{
			return;
		}
		198 2 = this.3 ? this.8 : this.6;
		foreach (1433 3 in this.5)
		{
			3.3.Clear();
			3.FadeIn(200, (1046)0, 0);
		}
		this.11.3.Clear();
		this.11.39(2, 0, false, (1046)0);
		this.11.3.Add(new 1445(1456.Fade, 0f, (float)2.A / 255f, 1662.33 + 1, 1662.33 + 1 + 200, (1046)0));
		this.11.19 = true;
		this.11.10 = true;
		this.4 = true;
	}

	// Token: 0x06004E5D RID: 20061 RVA: 0x001EFE20 File Offset: 0x001EE020
	internal void Hide()
	{
		if (!this.4)
		{
			return;
		}
		foreach (1433 <<EMPTY_NAME>> in this.5)
		{
			<<EMPTY_NAME>>.3.Clear();
			<<EMPTY_NAME>>.16(100, (1046)0, 0);
		}
		this.11.10 = false;
		this.11.3.Clear();
		this.11.16(100, (1046)0, 0);
		this.4 = false;
	}

	// Token: 0x06004E5E RID: 20062 RVA: 0x001EFEBC File Offset: 0x001EE0BC
	internal void 1(EventHandler 1)
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

	// Token: 0x06004E5F RID: 20063 RVA: 0x001EFEF1 File Offset: 0x001EE0F1
	private void 2(object 1, EventArgs 2)
	{
		if (this.14 != null)
		{
			this.14(this, EventArgs.Empty);
		}
	}

	// Token: 0x06004E60 RID: 20064 RVA: 0x001EFF0C File Offset: 0x001EE10C
	public void Dispose()
	{
		this.3(true);
		GC.SuppressFinalize(this);
	}

	// Token: 0x06004E61 RID: 20065 RVA: 0x001EFF1C File Offset: 0x001EE11C
	private void 3(bool 1)
	{
		if (!1)
		{
			return;
		}
		foreach (1433 2 in this.5)
		{
			this.13.Remove(2);
			2.Dispose();
		}
		this.13.Remove(this.11);
		this.11.Dispose();
	}

	// Token: 0x06004E62 RID: 20066 RVA: 0x001EFF9C File Offset: 0x001EE19C
	~1482()
	{
		this.3(false);
	}

	// Token: 0x04003A63 RID: 14947
	private 208 1;

	// Token: 0x04003A64 RID: 14948
	private 208 2;

	// Token: 0x04003A65 RID: 14949
	private bool 3;

	// Token: 0x04003A66 RID: 14950
	private bool 4;

	// Token: 0x04003A67 RID: 14951
	internal List<1433> 5 = new List<1433>();

	// Token: 0x04003A68 RID: 14952
	internal 198 6 = new 198(0, 0, 0, 160);

	// Token: 0x04003A69 RID: 14953
	internal 198 7 = new 198(165, 90, 234, 230);

	// Token: 0x04003A6A RID: 14954
	internal 198 8 = new 198(0, 85, 85, 85);

	// Token: 0x04003A6B RID: 14955
	internal string 9;

	// Token: 0x04003A6C RID: 14956
	internal int 10;

	// Token: 0x04003A6D RID: 14957
	internal 1433 11;

	// Token: 0x04003A6E RID: 14958
	private 1483 12;

	// Token: 0x04003A6F RID: 14959
	private 1436 13;

	// Token: 0x04003A70 RID: 14960
	private EventHandler 14;
}
