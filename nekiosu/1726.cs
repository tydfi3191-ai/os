using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x02000969 RID: 2409
public sealed partial class 1726 : 1488
{
	// Token: 0x060043DD RID: 17373 RVA: 0x001AB8CC File Offset: 0x001A9ACC
	public 1726(Bitmap 1)
	{
		this.16();
		this.8 = 1;
		1726.7 = this;
		if (1143.1())
		{
			base.Opacity = 0.0;
		}
		this.6 = new Timer();
		this.6.Interval = 30;
		this.6.Tick += this.13;
		this.6.Start();
	}

	// Token: 0x060043DE RID: 17374 RVA: 0x001AB94C File Offset: 0x001A9B4C
	private void 13(object 1, EventArgs 2)
	{
		if (base.Opacity < 0.8)
		{
			base.Opacity += (1.0 - base.Opacity) * 0.1;
		}
		if (1662.13() != null && 1662.13().Created)
		{
			this.15();
		}
	}

	// Token: 0x060043DF RID: 17375 RVA: 0x001AB9AA File Offset: 0x001A9BAA
	public static void 14()
	{
		1726 <<EMPTY_NAME>> = 1726.7;
		if (<<EMPTY_NAME>> == null)
		{
			return;
		}
		<<EMPTY_NAME>>.15();
	}

	// Token: 0x060043E0 RID: 17376 RVA: 0x001AB9BB File Offset: 0x001A9BBB
	private void 15()
	{
		base.5(new MethodInvoker(this.17));
	}

	// Token: 0x060043E1 RID: 17377 RVA: 0x00005ADD File Offset: 0x00003CDD
	protected override void OnPaintBackground(PaintEventArgs 1)
	{
	}

	// Token: 0x060043E2 RID: 17378 RVA: 0x001AB9CF File Offset: 0x001A9BCF
	protected override void OnClosing(CancelEventArgs 1)
	{
		if (this.6.Enabled)
		{
			1.Cancel = true;
		}
		if (this.8 != null)
		{
			this.8.Dispose();
		}
		base.OnClosing(1);
	}

	// Token: 0x060043E3 RID: 17379 RVA: 0x001ABA00 File Offset: 0x001A9C00
	protected override void OnPaint(PaintEventArgs 1)
	{
		if (this.9)
		{
			this.9 = false;
			base.Show();
			base.3();
		}
		1.Graphics.DrawImage(this.8, new Rectangle(0, 0, this.8.Width, this.8.Height));
	}

	// Token: 0x060043E5 RID: 17381 RVA: 0x001ABA78 File Offset: 0x001A9C78
	private void 16()
	{
		base.SuspendLayout();
		base.ClientSize = new Size(300, 300);
		base.FormBorderStyle = FormBorderStyle.None;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "SplashScreen";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterScreen;
		this.Text = "osu! (loading)";
		base.ResumeLayout(false);
	}

	// Token: 0x060043E6 RID: 17382 RVA: 0x001ABAE8 File Offset: 0x001A9CE8
	private void 17()
	{
		try
		{
			this.6.Stop();
			base.Close();
			base.Dispose();
			1726.7 = null;
		}
		catch
		{
		}
	}

	// Token: 0x040031C1 RID: 12737
	private Timer 6;

	// Token: 0x040031C2 RID: 12738
	private new static 1726 7;

	// Token: 0x040031C3 RID: 12739
	private new Bitmap 8;

	// Token: 0x040031C4 RID: 12740
	private bool 9 = true;
}
