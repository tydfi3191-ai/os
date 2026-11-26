using System;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x02000B10 RID: 2832
public sealed class 1504 : 1433
{
	// Token: 0x06004EAC RID: 20140 RVA: 0x001F1874 File Offset: 0x001EFA74
	internal 1504(string 1, 208 2, 208 3, float 4, 198 5) : base(null, (1376)6, 1065.TopLeft, (1044)0, 2, 4, true, 5, null)
	{
		this.66 = false;
		this.70 = new WebBrowser();
		this.70.ScriptErrorsSuppressed = true;
		this.70.ScrollBarsEnabled = false;
		this.70.Width = (int)3.X;
		this.70.Height = (int)3.Y;
		this.39 = (int)3.X;
		this.38 = (int)3.Y;
		this.35 = this.39;
		this.34 = this.38;
		this.40 = new bool?(true);
		this.70.ProgressChanged += this.50;
		this.49(1);
	}

	// Token: 0x06004EAD RID: 20141 RVA: 0x001F193C File Offset: 0x001EFB3C
	internal new void 49(string 1)
	{
		this.74 = false;
		if (1 != null)
		{
			this.70.Navigate(1);
		}
	}

	// Token: 0x06004EAE RID: 20142 RVA: 0x001F1954 File Offset: 0x001EFB54
	private new void 50(object 1, WebBrowserProgressChangedEventArgs 2)
	{
		if (2.CurrentProgress == 2.MaximumProgress && !this.74)
		{
			this.74 = true;
			1662.89.2(new 1189(this.51), 300, false);
		}
	}

	// Token: 0x06004EAF RID: 20143 RVA: 0x001F1990 File Offset: 0x001EFB90
	public override void Dispose()
	{
		if (this.27)
		{
			if (this.70 != null)
			{
				this.70.Dispose();
			}
			if (this.71 != null)
			{
				this.71.Dispose();
			}
			if (this.72 != null)
			{
				this.72.Dispose();
			}
		}
		base.Dispose();
	}

	// Token: 0x06004EB0 RID: 20144 RVA: 0x001F19E4 File Offset: 0x001EFBE4
	internal override 1381 GetTexture()
	{
		return this.71;
	}

	// Token: 0x06004EB1 RID: 20145 RVA: 0x001F19EC File Offset: 0x001EFBEC
	private void 51()
	{
		try
		{
			if (this.72 == null)
			{
				this.72 = new Bitmap(this.39, this.38);
			}
			this.70.DrawToBitmap(this.72, new Rectangle(0, 0, this.39, this.38));
			if (this.71 == null)
			{
				this.71 = 1381.15(this.72, null);
			}
			else
			{
				this.71.10(this.72);
			}
			if (this.73 != null)
			{
				this.73();
			}
		}
		catch
		{
		}
	}

	// Token: 0x04003AA8 RID: 15016
	private WebBrowser 70;

	// Token: 0x04003AA9 RID: 15017
	private 1381 71;

	// Token: 0x04003AAA RID: 15018
	private Bitmap 72;

	// Token: 0x04003AAB RID: 15019
	private 1189 73;

	// Token: 0x04003AAC RID: 15020
	private bool 74;
}
