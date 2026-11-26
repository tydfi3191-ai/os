using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

// Token: 0x02000AFA RID: 2810
[ComVisible(false)]
public partial class 1475 : Form
{
	// Token: 0x06004E2C RID: 20012 RVA: 0x001EED88 File Offset: 0x001ECF88
	public 1475()
	{
		base.Opacity = 0.0;
		this.1 = new Timer();
		this.1.Interval = 10;
		this.1.Tick += this.1;
		this.1.Start();
	}

	// Token: 0x06004E2D RID: 20013 RVA: 0x001EEDE4 File Offset: 0x001ECFE4
	private void 1(object 1, EventArgs 2)
	{
		if (base.IsDisposed || base.Opacity == 1.0)
		{
			this.1.Stop();
			this.2 = true;
			return;
		}
		try
		{
			base.Opacity = Math.Min(1.0, base.Opacity + Math.Max(0.009999999776482582, (1.0 - base.Opacity) * 0.1));
		}
		catch
		{
		}
	}

	// Token: 0x04003A4D RID: 14925
	private Timer 1;

	// Token: 0x04003A4E RID: 14926
	private bool 2;
}
