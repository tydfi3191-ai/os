using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

// Token: 0x02000B07 RID: 2823
public partial class 1488 : 1475
{
	// Token: 0x17000314 RID: 788
	// (get) Token: 0x06004E7E RID: 20094 RVA: 0x001F0A58 File Offset: 0x001EEC58
	// (set) Token: 0x06004E7F RID: 20095 RVA: 0x001F0B14 File Offset: 0x001EED14
	public override Font Font
	{
		get
		{
			try
			{
				if (this.3 != null)
				{
					return this.3;
				}
				if (Environment.OSVersion.Version.Major < 6)
				{
					Font dialogFont = SystemFonts.DialogFont;
					this.3 = new Font(dialogFont.Name, 8f, dialogFont.Style, GraphicsUnit.Point);
				}
				else
				{
					Font messageBoxFont = SystemFonts.MessageBoxFont;
					this.3 = new Font(messageBoxFont.Name, 9f, messageBoxFont.Style, GraphicsUnit.Point);
				}
			}
			catch
			{
				Font font = base.Font;
				this.3 = new Font(font.Name, 8f, font.Style, GraphicsUnit.Point);
			}
			return this.3;
		}
		set
		{
			base.Font = value;
		}
	}

	// Token: 0x06004E80 RID: 20096 RVA: 0x001F0B1D File Offset: 0x001EED1D
	protected override void OnLoad(EventArgs 1)
	{
		this.2();
		if (1181.1())
		{
			base.Opacity = 1.0;
		}
		base.OnLoad(1);
	}

	// Token: 0x06004E81 RID: 20097 RVA: 0x001F0B44 File Offset: 0x001EED44
	private void 2()
	{
		Font font = this.Font;
		new Font(font.Name, 5f, font.Style, GraphicsUnit.Point);
		this.4(font, this);
	}

	// Token: 0x06004E82 RID: 20098 RVA: 0x001F0B78 File Offset: 0x001EED78
	protected override void OnShown(EventArgs 1)
	{
		base.OnShown(1);
		if (base.Parent != null || base.Owner != null)
		{
			base.CenterToParent();
		}
	}

	// Token: 0x06004E83 RID: 20099 RVA: 0x001F0B97 File Offset: 0x001EED97
	protected void 3()
	{
		if (1181.1())
		{
			return;
		}
		this.5(delegate
		{
			if (base.WindowState == FormWindowState.Minimized)
			{
				base.WindowState = FormWindowState.Normal;
			}
			base.Activate();
		});
	}

	// Token: 0x06004E84 RID: 20100 RVA: 0x001F0BB4 File Offset: 0x001EEDB4
	private void 4(Font 1, Control 2)
	{
		Font font = new Font(1.Name, 5f, 1.Style, GraphicsUnit.Point);
		foreach (object obj in 2.Controls)
		{
			Control control = (Control)obj;
			Font font2 = control.Font;
			string familyName = this.6(font2.Name) ? 1.Name : font2.Name;
			control.Font = font;
			control.Font = new Font(familyName, font2.Size, font2.Style, font2.Unit);
			this.4(1, control);
		}
	}

	// Token: 0x06004E85 RID: 20101 RVA: 0x001F0C74 File Offset: 0x001EEE74
	public void 5(MethodInvoker 1)
	{
		if (base.IsDisposed)
		{
			return;
		}
		if (!base.InvokeRequired)
		{
			1();
			return;
		}
		int num = 50;
		while (!base.IsHandleCreated && num-- > 0)
		{
			Thread.Sleep(100);
		}
		if (base.IsDisposed)
		{
			return;
		}
		try
		{
			base.Invoke(1);
		}
		catch
		{
		}
	}

	// Token: 0x06004E86 RID: 20102 RVA: 0x001F0CDC File Offset: 0x001EEEDC
	private bool 6(string 1)
	{
		1 = 1.ToLowerInvariant();
		return 1 == "system" || 1 == "ms sans serif" || 1 == "microsoft sans serif" || 1 == "tahoma" || 1 == "segoe ui";
	}

	// Token: 0x06004E87 RID: 20103 RVA: 0x001F0D40 File Offset: 0x001EEF40
	protected override void WndProc(ref Message 1)
	{
		base.WndProc(ref 1);
		int msg = 1.Msg;
		if (msg != 132)
		{
			if (msg != 798)
			{
				return;
			}
			if (this.5 != null)
			{
				this.5(this, EventArgs.Empty);
			}
		}
		else if (this.4 != null)
		{
			int num = (int)1.LParam;
			2354 2 = new 2354((2355)((int)1.Result), new Point(num & 65535, num >> 16));
			this.4(this, 2);
			1.Result = (IntPtr)((int)2.1);
			return;
		}
	}

	// Token: 0x06004E88 RID: 20104 RVA: 0x001F0DDC File Offset: 0x001EEFDC
	internal void 7(EventHandler<2354> 1)
	{
		EventHandler<2354> eventHandler = this.4;
		EventHandler<2354> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<2354> value = (EventHandler<2354>)Delegate.Combine(eventHandler2, 1);
			eventHandler = Interlocked.CompareExchange<EventHandler<2354>>(ref this.4, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x06004E89 RID: 20105 RVA: 0x001F0E11 File Offset: 0x001EF011
	internal void 8(1065 1)
	{
		this.9(1);
		base.Show();
	}

	// Token: 0x06004E8A RID: 20106 RVA: 0x001F0E20 File Offset: 0x001EF020
	private void 9(1065 1)
	{
		Point point = 1488.10();
		switch (1)
		{
		case 1065.TopLeft:
		case 1065.CentreLeft:
		case 1065.BottomLeft:
			base.Left = point.X;
			break;
		case 1065.Centre:
		case 1065.BottomCentre:
		case 1065.TopCentre:
			base.Left = point.X - base.Width / 2;
			break;
		case 1065.TopRight:
		case 1065.CentreRight:
		case 1065.BottomRight:
			base.Left = point.X - base.Width;
			break;
		}
		switch (1)
		{
		case 1065.TopLeft:
		case 1065.TopRight:
		case 1065.TopCentre:
			base.Top = point.Y;
			return;
		case 1065.Centre:
		case 1065.CentreLeft:
		case 1065.CentreRight:
			base.Top = point.Y - base.Height / 2;
			return;
		case 1065.BottomCentre:
		case 1065.BottomLeft:
		case 1065.BottomRight:
			base.Top = point.Y - base.Height;
			break;
		case 1065.Custom:
			break;
		default:
			return;
		}
	}

	// Token: 0x06004E8B RID: 20107
	[DllImport("user32.dll")]
	private static extern bool GetCursorPos(ref Point 1);

	// Token: 0x06004E8C RID: 20108 RVA: 0x001F0F08 File Offset: 0x001EF108
	private static Point 10()
	{
		Point result = default(Point);
		if (!1488.GetCursorPos(ref result))
		{
			throw new InvalidOperationException();
		}
		return result;
	}

	// Token: 0x06004E8D RID: 20109
	[DllImport("user32.dll")]
	private static extern int SendMessage(IntPtr 1, int 2, bool 3, int 4);

	// Token: 0x06004E8E RID: 20110 RVA: 0x001F0F2D File Offset: 0x001EF12D
	internal static void 11(Control 1)
	{
		1488.SendMessage(1.Handle, 11, false, 0);
	}

	// Token: 0x06004E8F RID: 20111 RVA: 0x001F0F3F File Offset: 0x001EF13F
	internal static void 12(Control 1)
	{
		1488.SendMessage(1.Handle, 11, true, 0);
		1.Refresh();
	}

	// Token: 0x04003A8A RID: 14986
	private Font 3;

	// Token: 0x04003A8B RID: 14987
	private EventHandler<2354> 4;

	// Token: 0x04003A8C RID: 14988
	private EventHandler 5;
}
