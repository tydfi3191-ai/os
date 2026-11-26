using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

// Token: 0x02000B06 RID: 2822
public sealed class 1487 : Panel
{
	// Token: 0x06004E7A RID: 20090 RVA: 0x001F09D4 File Offset: 0x001EEBD4
	public void 1(bool 1)
	{
		this.1 = 1;
	}

	// Token: 0x06004E7B RID: 20091 RVA: 0x001F09E0 File Offset: 0x001EEBE0
	protected override void OnPaintBackground(PaintEventArgs 1)
	{
		if (this.BackColor.A < 255)
		{
			Graphics graphics = 1.Graphics;
			graphics.CompositingMode = CompositingMode.SourceCopy;
			graphics.Clear(Color.FromArgb(0, 0, 0, 0));
			return;
		}
		base.OnPaintBackground(1);
	}

	// Token: 0x06004E7C RID: 20092 RVA: 0x001F0A25 File Offset: 0x001EEC25
	protected override void WndProc(ref Message 1)
	{
		base.WndProc(ref 1);
		if (1.Msg == 132 && this.1)
		{
			1.Result = (IntPtr)(-1);
		}
	}

	// Token: 0x04003A89 RID: 14985
	private bool 1;
}
