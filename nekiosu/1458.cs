using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x02000AE8 RID: 2792
public sealed class 1458 : UserControl
{
	// Token: 0x06004DDC RID: 19932 RVA: 0x001ECFB0 File Offset: 0x001EB1B0
	public 1458()
	{
		this.BackColor = Color.FromArgb(85, 85, 85);
		this.9();
		this.1.Interval = 16;
		this.1.Tick += this.2;
		this.1.Start();
		this.DoubleBuffered = true;
	}

	// Token: 0x06004DDD RID: 19933 RVA: 0x001ED03A File Offset: 0x001EB23A
	private float 1()
	{
		return (float)(this.6 - this.4) / (float)(this.5 - this.4);
	}

	// Token: 0x06004DDE RID: 19934 RVA: 0x001ED05C File Offset: 0x001EB25C
	private void 2(object 1, EventArgs 2)
	{
		if (this.1() <= 0f)
		{
			this.3 += 0.05f;
			this.2 = 1f;
			base.Invalidate();
			return;
		}
		if (Math.Abs(this.2 - this.1()) > 0.005f)
		{
			if (this.3 != 0f)
			{
				this.2 = (this.3() > 0.5f);
				this.3 = 0f;
			}
			else
			{
				this.2 = this.2 * 0.9f + this.1() * 0.1f;
			}
			base.Invalidate();
		}
	}

	// Token: 0x06004DDF RID: 19935 RVA: 0x001ED106 File Offset: 0x001EB306
	private float 3()
	{
		return (float)Math.Max(0.0, Math.Sin((double)this.3));
	}

	// Token: 0x06004DE0 RID: 19936 RVA: 0x001ED124 File Offset: 0x001EB324
	protected override void OnPaint(PaintEventArgs 1)
	{
		SolidBrush solidBrush = new SolidBrush(Color.FromArgb((this.1() <= 0f) ? ((int)(255f * this.3())) : 255, this.7));
		try
		{
			RectangleF rect = base.ClientRectangle;
			rect.Width = 1f + rect.Width * this.2;
			1.Graphics.FillRectangle(solidBrush, rect);
		}
		finally
		{
			((IDisposable)solidBrush).Dispose();
		}
	}

	// Token: 0x06004DE1 RID: 19937 RVA: 0x001ED1B0 File Offset: 0x001EB3B0
	public void 4(int 1)
	{
		if (1 < 0)
		{
			this.4 = 0;
		}
		if (1 > this.5)
		{
			this.4 = 1;
			this.4 = 1;
		}
		if (this.6 < this.4)
		{
			this.6 = this.4;
		}
		base.Invalidate();
	}

	// Token: 0x06004DE2 RID: 19938 RVA: 0x001ED1FF File Offset: 0x001EB3FF
	public void 5(int 1)
	{
		if (1 < this.4)
		{
			this.4 = 1;
		}
		this.5 = 1;
		if (this.6 > this.5)
		{
			this.6 = this.5;
		}
		base.Invalidate();
	}

	// Token: 0x06004DE3 RID: 19939 RVA: 0x001ED238 File Offset: 0x001EB438
	public int 6()
	{
		return this.6;
	}

	// Token: 0x06004DE4 RID: 19940 RVA: 0x001ED240 File Offset: 0x001EB440
	public void 7(int 1)
	{
		float num = (float)this.6;
		if (1 < this.4)
		{
			this.6 = this.4;
		}
		else if (1 > this.5)
		{
			this.6 = this.5;
		}
		else
		{
			this.6 = 1;
		}
		Rectangle clientRectangle = base.ClientRectangle;
		Rectangle clientRectangle2 = base.ClientRectangle;
		float num2 = (float)(this.6 - this.4) / (float)(this.5 - this.4);
		clientRectangle.Width = (int)((float)clientRectangle.Width * num2);
		num2 = (num - (float)this.4) / (float)(this.5 - this.4);
		clientRectangle2.Width = (int)((float)clientRectangle2.Width * num2);
		Rectangle rc = default(Rectangle);
		if (clientRectangle.Width > clientRectangle2.Width)
		{
			rc.X = clientRectangle2.Size.Width;
			rc.Width = clientRectangle.Width - clientRectangle2.Width;
		}
		else
		{
			rc.X = clientRectangle.Size.Width;
			rc.Width = clientRectangle2.Width - clientRectangle.Width;
		}
		rc.Height = base.Height;
		base.Invalidate(rc);
	}

	// Token: 0x06004DE5 RID: 19941 RVA: 0x001ED378 File Offset: 0x001EB578
	public void 8(Color 1)
	{
		this.7 = 1;
		base.Invalidate();
	}

	// Token: 0x06004DE6 RID: 19942 RVA: 0x001ED387 File Offset: 0x001EB587
	protected override void Dispose(bool 1)
	{
		if (1 && this.8 != null)
		{
			this.8.Dispose();
		}
		base.Dispose(1);
	}

	// Token: 0x06004DE7 RID: 19943 RVA: 0x001ED3A6 File Offset: 0x001EB5A6
	private void 9()
	{
		this.8 = new Container();
		base.AutoScaleMode = AutoScaleMode.Font;
	}

	// Token: 0x04003A10 RID: 14864
	private Timer 1 = new Timer();

	// Token: 0x04003A11 RID: 14865
	private float 2;

	// Token: 0x04003A12 RID: 14866
	private float 3;

	// Token: 0x04003A13 RID: 14867
	private int 4;

	// Token: 0x04003A14 RID: 14868
	private int 5 = 100;

	// Token: 0x04003A15 RID: 14869
	private int 6;

	// Token: 0x04003A16 RID: 14870
	private Color 7 = Color.FromArgb(255, 102, 170);

	// Token: 0x04003A17 RID: 14871
	private IContainer 8;
}
