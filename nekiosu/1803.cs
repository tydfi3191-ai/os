using System;
using System.Diagnostics;
using System.Threading;
using OpenTK.Graphics;

// Token: 0x02000876 RID: 2166
public class 1803 : IDisposable
{
	// Token: 0x06003E78 RID: 15992 RVA: 0x00186550 File Offset: 0x00184750
	public 1803(GraphicsContextFlags 1)
	{
		this.2 = new 1836(this, 1);
		this.2.4(new EventHandler(this.10));
		this.2.3(new EventHandler(this.12));
	}

	// Token: 0x06003E79 RID: 15993 RVA: 0x0018659E File Offset: 0x0018479E
	public 1379 1()
	{
		return this.2.GetGLWindow();
	}

	// Token: 0x06003E7A RID: 15994 RVA: 0x001865AB File Offset: 0x001847AB
	public bool 2()
	{
		return this.3;
	}

	// Token: 0x06003E7B RID: 15995 RVA: 0x001865B4 File Offset: 0x001847B4
	public void 3(bool 1)
	{
		if (1 == this.3)
		{
			return;
		}
		this.3 = 1;
		if (this.3)
		{
			EventHandler eventHandler = this.4;
			if (eventHandler != null)
			{
				eventHandler(this, EventArgs.Empty);
			}
		}
		else
		{
			EventHandler eventHandler2 = this.5;
			if (eventHandler2 != null)
			{
				eventHandler2(this, EventArgs.Empty);
			}
		}
		using (Process currentProcess = Process.GetCurrentProcess())
		{
			currentProcess.PriorityBoostEnabled = true;
			currentProcess.PriorityClass = ProcessPriorityClass.High;
		}
	}

	// Token: 0x06003E7C RID: 15996 RVA: 0x00186640 File Offset: 0x00184840
	public 1131 4()
	{
		1802 <<EMPTY_NAME>> = this.2;
		if (<<EMPTY_NAME>> == null)
		{
			return null;
		}
		return <<EMPTY_NAME>>.1();
	}

	// Token: 0x06003E7D RID: 15997 RVA: 0x00186654 File Offset: 0x00184854
	public void 5(EventHandler 1)
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

	// Token: 0x06003E7E RID: 15998 RVA: 0x0018668C File Offset: 0x0018488C
	public void 6(EventHandler 1)
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

	// Token: 0x06003E7F RID: 15999 RVA: 0x001866C4 File Offset: 0x001848C4
	public void 7(EventHandler 1)
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

	// Token: 0x06003E80 RID: 16000 RVA: 0x001866FC File Offset: 0x001848FC
	public void 8(EventHandler 1)
	{
		EventHandler eventHandler = this.5;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, 1);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.5, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06003E81 RID: 16001 RVA: 0x00186731 File Offset: 0x00184931
	public void 9()
	{
		this.1 = true;
		this.2.SetFlag10615_13769();
	}

	// Token: 0x06003E82 RID: 16002 RVA: 0x00186745 File Offset: 0x00184945
	private void 10(object 1, EventArgs 2)
	{
		if (!this.1)
		{
			this.Update();
			this.Draw();
			this.EndFrame();
		}
	}

	// Token: 0x06003E83 RID: 16003 RVA: 0x00005ADD File Offset: 0x00003CDD
	protected virtual void OnLoad()
	{
	}

	// Token: 0x06003E84 RID: 16004 RVA: 0x00186761 File Offset: 0x00184961
	protected virtual void OnActivated(object 1, EventArgs 2)
	{
		EventHandler eventHandler = this.4;
		if (eventHandler == null)
		{
			return;
		}
		eventHandler(1, 2);
	}

	// Token: 0x06003E85 RID: 16005 RVA: 0x00186775 File Offset: 0x00184975
	protected virtual void OnDeactivated(object 1, EventArgs 2)
	{
		EventHandler eventHandler = this.5;
		if (eventHandler == null)
		{
			return;
		}
		eventHandler(1, 2);
	}

	// Token: 0x06003E86 RID: 16006 RVA: 0x00186789 File Offset: 0x00184989
	protected virtual void OnClosed(object 1, EventArgs 2)
	{
		EventHandler eventHandler = this.6;
		if (eventHandler == null)
		{
			return;
		}
		eventHandler(1, 2);
	}

	// Token: 0x06003E87 RID: 16007 RVA: 0x00005ADD File Offset: 0x00003CDD
	protected virtual void EndFrame()
	{
	}

	// Token: 0x06003E88 RID: 16008 RVA: 0x0018679D File Offset: 0x0018499D
	public void 11()
	{
		this.OnLoad();
		this.EndFrame();
		this.2.RunMessageLoop();
	}

	// Token: 0x06003E89 RID: 16009 RVA: 0x00005ADD File Offset: 0x00003CDD
	protected virtual void Draw()
	{
	}

	// Token: 0x06003E8A RID: 16010 RVA: 0x001867B6 File Offset: 0x001849B6
	protected virtual void Update()
	{
		this.3(this.2.2);
	}

	// Token: 0x06003E8B RID: 16011 RVA: 0x001867D0 File Offset: 0x001849D0
	~1803()
	{
		this.Dispose(false);
	}

	// Token: 0x06003E8C RID: 16012 RVA: 0x00005ADD File Offset: 0x00003CDD
	protected virtual void Dispose(bool 1)
	{
	}

	// Token: 0x06003E8D RID: 16013 RVA: 0x00186800 File Offset: 0x00184A00
	public void Dispose()
	{
		this.Dispose(true);
		GC.SuppressFinalize(this);
	}

	// Token: 0x06003E8E RID: 16014 RVA: 0x0018680F File Offset: 0x00184A0F
	private void 12(object 1, EventArgs 2)
	{
		this.OnClosed(this, 2);
	}

	// Token: 0x04002DC1 RID: 11713
	private bool 1;

	// Token: 0x04002DC2 RID: 11714
	private readonly 1802 2;

	// Token: 0x04002DC3 RID: 11715
	private bool 3;

	// Token: 0x04002DC4 RID: 11716
	private EventHandler 4;

	// Token: 0x04002DC5 RID: 11717
	private EventHandler 5;

	// Token: 0x04002DC6 RID: 11718
	private EventHandler 6;
}
