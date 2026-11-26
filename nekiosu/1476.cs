using System;
using System.Windows.Forms;
using OpenTK.Graphics;

// Token: 0x02000AFB RID: 2811
public partial class 1476 : 1379
{
	// Token: 0x06004E2E RID: 20014 RVA: 0x001EEE78 File Offset: 0x001ED078
	public 1476(GraphicsContextFlags 1) : base(GraphicsMode.Default, 2, 0, 1)
	{
		base.Opacity = 0.0;
		this.35 = new Timer();
		this.35.Interval = 10;
		this.35.Tick += this.38;
		this.35.Start();
	}

	// Token: 0x06004E2F RID: 20015 RVA: 0x001EEEDC File Offset: 0x001ED0DC
	private void 38(object 1, EventArgs 2)
	{
		if (base.IsDisposed || base.Opacity == 1.0)
		{
			this.35.Stop();
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

	// Token: 0x04003A4F RID: 14927
	private new Timer 35;
}
