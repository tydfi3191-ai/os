using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using OpenTK.Graphics;

// Token: 0x02000AFE RID: 2814
public sealed partial class 1479 : 1476
{
	// Token: 0x06004E3E RID: 20030 RVA: 0x001EF778 File Offset: 0x001ED978
	public 1479(GraphicsContextFlags 1) : base(3)
	{
		base.SuspendLayout();
		base.CausesValidation = false;
		base.ClientSize = new Size(1, 1);
		this.BackColor = Color.Black;
		base.ResumeLayout(false);
		base.LocationChanged += this.48;
		base.ClientSizeChanged += delegate(object 1, EventArgs 2)
		{
			this.47();
		};
	}

	// Token: 0x06004E3F RID: 20031 RVA: 0x001EF7DC File Offset: 0x001ED9DC
	internal 207 39()
	{
		Point point = base.PointToScreen(Point.Empty);
		return new 207(point.X, point.Y, base.ClientSize.Width, base.ClientSize.Height);
	}

	// Token: 0x06004E40 RID: 20032 RVA: 0x001EF824 File Offset: 0x001EDA24
	public bool 40()
	{
		return base.ClientSize.Width == 0 || base.ClientSize.Height == 0;
	}

	// Token: 0x06004E41 RID: 20033 RVA: 0x001EF854 File Offset: 0x001EDA54
	internal void 41(EventHandler 1)
	{
		EventHandler eventHandler = this.37;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, 1);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.37, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06004E42 RID: 20034 RVA: 0x001EF88C File Offset: 0x001EDA8C
	internal void 42(EventHandler 1)
	{
		EventHandler eventHandler = this.38;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, 1);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.38, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06004E43 RID: 20035 RVA: 0x001EF8C4 File Offset: 0x001EDAC4
	internal void 43(EventHandler 1)
	{
		EventHandler eventHandler = this.39;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, 1);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.39, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06004E44 RID: 20036 RVA: 0x001EF8FC File Offset: 0x001EDAFC
	internal void 44(EventHandler 1)
	{
		EventHandler eventHandler = this.40;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, 1);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.40, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06004E45 RID: 20037 RVA: 0x001EF931 File Offset: 0x001EDB31
	public void 45()
	{
		base.CenterToScreen();
	}

	// Token: 0x06004E46 RID: 20038 RVA: 0x001EF939 File Offset: 0x001EDB39
	private void 46(bool 1)
	{
		if (1)
		{
			EventHandler eventHandler = this.37;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler(this, EventArgs.Empty);
			return;
		}
		else
		{
			EventHandler eventHandler2 = this.38;
			if (eventHandler2 == null)
			{
				return;
			}
			eventHandler2(this, EventArgs.Empty);
			return;
		}
	}

	// Token: 0x06004E47 RID: 20039 RVA: 0x001EF96C File Offset: 0x001EDB6C
	private void 47()
	{
		Screen obj = Screen.FromHandle(base.Handle);
		if (this.36 == null || !this.36.Equals(obj))
		{
			this.36 = obj;
			if (this.36 != null)
			{
				EventHandler eventHandler = this.39;
				if (eventHandler == null)
				{
					return;
				}
				eventHandler(this, EventArgs.Empty);
			}
		}
	}

	// Token: 0x06004E48 RID: 20040 RVA: 0x001EF9C0 File Offset: 0x001EDBC0
	protected override void WndProc(ref Message 1)
	{
		if (1.Msg == 28)
		{
			bool 2 = 1.WParam != IntPtr.Zero;
			this.46(2);
		}
		1172 3 = this.41;
		if (3 != null)
		{
			3(ref 1);
		}
		if (1.Result.ToInt32() < 0)
		{
			1.Result = new IntPtr(-1.Result.ToInt32() - 1);
			return;
		}
		base.WndProc(ref 1);
	}

	// Token: 0x06004E49 RID: 20041 RVA: 0x001EFA36 File Offset: 0x001EDC36
	private void 48(object 1, EventArgs 2)
	{
		this.47();
	}

	// Token: 0x04003A5C RID: 14940
	private new Screen 36;

	// Token: 0x04003A5D RID: 14941
	private new EventHandler 37;

	// Token: 0x04003A5E RID: 14942
	private EventHandler 38;

	// Token: 0x04003A5F RID: 14943
	private EventHandler 39;

	// Token: 0x04003A60 RID: 14944
	private EventHandler 40;

	// Token: 0x04003A61 RID: 14945
	private 1172 41;
}
