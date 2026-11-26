using System;

// Token: 0x02000AA6 RID: 2726
public class 1404 : 1448
{
	// Token: 0x06004B9C RID: 19356 RVA: 0x001DF2CC File Offset: 0x001DD4CC
	public 1404(int 1, 208 2, float 3, bool 4 = true, float 5 = 0.98f) : base(string.Empty, (float)1, 2, 3, 5, false)
	{
		if (4)
		{
			this.1.72 = 0;
			base.15(198.TransparentWhite);
			base.14(198.TransparentWhite);
			this.1.54(true);
		}
	}

	// Token: 0x06004B9D RID: 19357 RVA: 0x001DF31D File Offset: 0x001DD51D
	internal new bool 21()
	{
		return !this.15.9;
	}

	// Token: 0x06004B9E RID: 19358 RVA: 0x001DF32D File Offset: 0x001DD52D
	internal new void 22(bool 1)
	{
		this.15.9 = !1;
	}

	// Token: 0x06004B9F RID: 19359 RVA: 0x001DF33E File Offset: 0x001DD53E
	internal bool 23()
	{
		return this.27 && this.IsEnabled();
	}

	// Token: 0x06004BA0 RID: 19360 RVA: 0x001DF350 File Offset: 0x001DD550
	internal void 24(bool 1)
	{
		if (this.27 != 1)
		{
			this.27 = 1;
			if (1)
			{
				base.17(true);
				return;
			}
			this.Unfocus(false);
		}
	}

	// Token: 0x06004BA1 RID: 19361 RVA: 0x001DF374 File Offset: 0x001DD574
	public override bool IsEnabled()
	{
		return base.IsEnabled();
	}

	// Token: 0x06004BA2 RID: 19362 RVA: 0x001DF37C File Offset: 0x001DD57C
	public override void SetEnabled(bool 1)
	{
		if (this.IsEnabled() != 1)
		{
			base.SetEnabled(1);
			if (1)
			{
				base.17(true);
			}
		}
	}

	// Token: 0x06004BA3 RID: 19363 RVA: 0x001DF3A8 File Offset: 0x001DD5A8
	internal override bool HandleKey(object 1, 200 2, bool 3)
	{
		if (this.15.11.1 || (this.15.11.2 > 0 && 1662.33 - this.15.11.2 < 80))
		{
			return true;
		}
		if (!base.1())
		{
			return false;
		}
		if (1549.1)
		{
			if (2 > 200.A)
			{
				if (2 != 200.C)
				{
					if (2 == 200.V)
					{
						return true;
					}
					if (2 != 200.X)
					{
						return false;
					}
				}
				return this.15.11.SelectionLength > 0;
			}
			if (2 == 200.Left || 2 == 200.Right)
			{
				return this.21();
			}
			if (2 == 200.A)
			{
				return this.GetText().Length > 0 && this == 1535.53;
			}
		}
		return false;
	}

	// Token: 0x06004BA4 RID: 19364 RVA: 0x001DF463 File Offset: 0x001DD663
	protected override void Unfocus(bool 1)
	{
		if (!this.23())
		{
			base.Unfocus(1);
			return;
		}
		base.6(1);
	}

	// Token: 0x06004BA5 RID: 19365 RVA: 0x001DF47C File Offset: 0x001DD67C
	internal override void UpdateCaret()
	{
		int length = this.15.11.Text.Length;
		if (!this.21() && this.15.11.SelectionStart != length)
		{
			this.15.11.SelectionStart = this.15.11.Text.Length;
		}
		base.UpdateCaret();
		1433 <<EMPTY_NAME>> = this.7;
		<<EMPTY_NAME>>.9(<<EMPTY_NAME>>.8() | !this.21());
	}

	// Token: 0x06004BA6 RID: 19366 RVA: 0x001DF500 File Offset: 0x001DD700
	protected override void OnTextChanged(object 1, EventArgs 2)
	{
		if (this.9)
		{
			if (!this.8)
			{
				if (this.15.Text.Length == 0)
				{
					this.8 = true;
					this.15.Text = this.28;
				}
			}
			else if (this.15.Text.Length < this.28.Length)
			{
				this.8 = true;
				this.15.Text = this.28;
			}
			else
			{
				string text = this.15.Text.Replace(this.28, string.Empty);
				if (text.Length > 0 && text != this.15.Text)
				{
					this.8 = false;
					this.15.Text = text;
				}
			}
		}
		base.OnTextChanged(1, 2);
	}

	// Token: 0x06004BA7 RID: 19367 RVA: 0x001DF5DC File Offset: 0x001DD7DC
	public new string 25()
	{
		return this.28;
	}

	// Token: 0x06004BA8 RID: 19368 RVA: 0x001DF5E4 File Offset: 0x001DD7E4
	public void 26(string 1)
	{
		this.9 = (1.Length > 0);
		this.8 = true;
		this.28 = 1;
		this.SetText(this.28);
		this.UpdateCaret();
	}

	// Token: 0x06004BA9 RID: 19369 RVA: 0x001DF615 File Offset: 0x001DD815
	internal void 27()
	{
		this.SetText(this.25() ?? string.Empty);
		if (this.9)
		{
			this.8 = true;
		}
		this.UpdateCaret();
	}

	// Token: 0x06004BAA RID: 19370 RVA: 0x001DF641 File Offset: 0x001DD841
	internal override string GetText()
	{
		if (this.8)
		{
			return string.Empty;
		}
		return base.GetText();
	}

	// Token: 0x06004BAB RID: 19371 RVA: 0x001DF657 File Offset: 0x001DD857
	internal override void SetText(string 1)
	{
		this.8 = (1 == this.28);
		base.SetText(1);
		this.UpdateCaret();
	}

	// Token: 0x0400385B RID: 14427
	private bool 27;

	// Token: 0x0400385C RID: 14428
	private string 28;
}
