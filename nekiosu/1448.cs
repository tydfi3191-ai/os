using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

// Token: 0x02000AD7 RID: 2775
public class 1448 : IDisposable
{
	// Token: 0x06004D1A RID: 19738 RVA: 0x001E850C File Offset: 0x001E670C
	public 1448(string 1, float 2, 208 3, float 4, float 5 = 1f, bool 6 = false)
	{
		this.7(2);
		this.20 = 4;
		this.1 = new 1452(string.Empty, 2, 3, new 208(4, 0f), 5, true, 198.White, false);
		this.1.54(true);
		this.1.58(this.24);
		this.1.62(198.White);
		this.1.75 = (1066)1;
		this.1.10 = true;
		this.1.11 = true;
		this.1.60(new 198(180, 180, 180));
		this.1.72 = 2;
		this.7 = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, 3, 5 + 0.001f, true, 198.TransparentWhite, null);
		this.7.20 = new 208(2f, 2 * 1.5f);
		this.7.9(true);
		1433 7 = this.7;
		7.17.Y = 7.17.Y + (float)this.22;
		this.2.Add(this.7);
		if (6)
		{
			this.15 = new 1706(this);
		}
		else
		{
			this.15 = new 1729(this);
		}
		this.15.9(delegate(string 1)
		{
			this.11();
			this.21.40(198.White, 200);
			this.21.SetText(1);
		});
		this.15.11(new 1189(this.8));
		this.15.10(delegate
		{
			this.11();
		});
		this.21 = new 1452(string.Empty, 2, this.7.17, 5 + 0.002f, true, 198.PaleVioletRed);
		this.2.Add(this.21);
		this.26 = true;
		this.15.8 = this;
		this.1.3(new EventHandler(this.OnClick));
		1535.40((1082)8, new 1081(this.13), 1545.Highest, (1559)2);
		this.15.7(new EventHandler(this.OnTextChanged));
		this.15.15(new KeyEventHandler(this.OnKeyDown));
		this.2.Add(this.1);
		this.SetText(8);
	}

	// Token: 0x06004D1B RID: 19739 RVA: 0x001E87B9 File Offset: 0x001E69B9
	internal bool 1()
	{
		return this.10;
	}

	// Token: 0x06004D1C RID: 19740 RVA: 0x001E87C1 File Offset: 0x001E69C1
	private void 2(bool 1)
	{
		this.10 = 1;
	}

	// Token: 0x06004D1D RID: 19741 RVA: 0x001E87CC File Offset: 0x001E69CC
	internal void 3(1448.1449 1)
	{
		1448.1449 2 = this.16;
		1448.1449 3;
		do
		{
			3 = 2;
			1448.1449 value = (1448.1449)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1448.1449>(ref this.16, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06004D1E RID: 19742 RVA: 0x001E8804 File Offset: 0x001E6A04
	public void 4(1448.1449 1)
	{
		1448.1449 2 = this.17;
		1448.1449 3;
		do
		{
			3 = 2;
			1448.1449 value = (1448.1449)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1448.1449>(ref this.17, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06004D1F RID: 19743 RVA: 0x001E883C File Offset: 0x001E6A3C
	public void 5(1448.1449 1)
	{
		1448.1449 2 = this.18;
		1448.1449 3;
		do
		{
			3 = 2;
			1448.1449 value = (1448.1449)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1448.1449>(ref this.18, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06004D20 RID: 19744 RVA: 0x001E8871 File Offset: 0x001E6A71
	protected void 6(bool 1)
	{
		1226.24("key-confirm", 100, (1416)3, false);
		1448.1449 2 = this.16;
		if (2 == null)
		{
			return;
		}
		2(this, 1);
	}

	// Token: 0x06004D21 RID: 19745 RVA: 0x001E8894 File Offset: 0x001E6A94
	private void 7(float 1)
	{
		this.19 = 1;
	}

	// Token: 0x06004D22 RID: 19746 RVA: 0x001E889D File Offset: 0x001E6A9D
	private void 8()
	{
		this.11();
	}

	// Token: 0x06004D23 RID: 19747 RVA: 0x001E88A8 File Offset: 0x001E6AA8
	~1448()
	{
		this.9(true);
	}

	// Token: 0x06004D24 RID: 19748 RVA: 0x001E88D8 File Offset: 0x001E6AD8
	public void Dispose()
	{
		this.17 = null;
		this.18 = null;
		this.16 = null;
		1662.89.Schedule(new 1189(this.20), false);
		GC.SuppressFinalize(this);
		this.9(false);
	}

	// Token: 0x06004D25 RID: 19749 RVA: 0x001E8914 File Offset: 0x001E6B14
	private void 9(bool 1)
	{
		1535.41((1082)8, new 1081(this.13), 1545.Highest);
		this.15.8(new EventHandler(this.OnTextChanged));
		this.15.16(new KeyEventHandler(this.OnKeyDown));
		if (1662.78 != 1677.Exit)
		{
			this.Unfocus(false);
		}
	}

	// Token: 0x06004D26 RID: 19750 RVA: 0x001E8974 File Offset: 0x001E6B74
	protected virtual void OnTextChanged(object 1, EventArgs 2)
	{
		if (!this.11)
		{
			if (!this.15.11.1)
			{
				this.11();
			}
			if (this.4 != 0 && this.15.Text.Length > this.4 && !this.8)
			{
				this.15.Text = this.1.GetText();
				this.1.60(198.Red);
			}
			else
			{
				this.1.62(this.26 ? 198.White : new 198(180, 180, 180));
				this.1.SetText(this.15.Text);
				this.1.60(this.26 ? this.3 : new 198(180, 180, 180));
				1448.1449 3 = this.17;
				if (3 != null)
				{
					3(this, true);
				}
			}
			this.10();
		}
	}

	// Token: 0x06004D27 RID: 19751 RVA: 0x001E8A84 File Offset: 0x001E6C84
	private void 10()
	{
		float y = (this.14 > this.19().Y) ? this.14 : (this.1() ? this.14 : this.19().Y);
		this.1.77.Y = y;
		this.1.88 = true;
		1448.1449 <<EMPTY_NAME>> = this.17;
		if (<<EMPTY_NAME>> == null)
		{
			return;
		}
		<<EMPTY_NAME>>(this, false);
	}

	// Token: 0x06004D28 RID: 19752 RVA: 0x001E8AF7 File Offset: 0x001E6CF7
	private void 11()
	{
		this.21.SetText(string.Empty);
	}

	// Token: 0x06004D29 RID: 19753 RVA: 0x001E8B0C File Offset: 0x001E6D0C
	internal virtual bool HandleKey(object 1, 200 2, bool 3)
	{
		if (this.15.11.1 || (this.15.11.2 > 0 && 1662.33 - this.15.11.2 < 80))
		{
			return true;
		}
		if (this.1() && 3)
		{
			if (2 == 200.Enter)
			{
				this.Unfocus(true);
				return true;
			}
			if (2 == 200.Escape || 2 - 200.F8 <= 1)
			{
				this.Unfocus(false);
				return true;
			}
			if (1549.1)
			{
				if (2 > 200.Right)
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
				if (2 != 200.Left && 2 != 200.Right)
				{
					return false;
				}
				return true;
			}
		}
		return false;
	}

	// Token: 0x06004D2A RID: 19754 RVA: 0x001E8BC5 File Offset: 0x001E6DC5
	protected virtual void OnKeyDown(object 1, KeyEventArgs 2)
	{
		if (!this.1())
		{
			return;
		}
		1662.89.Schedule(delegate()
		{
			this.7.9(!this.1() || (this.9 && this.8) || this.1.GetText().Length == this.4);
			int num = Math.Max(0, this.15.11.SelectionStart);
			if (this.9 && this.8)
			{
				this.15.11.SelectionStart = this.15.11.Text.Length;
			}
			this.12 = this.13;
			this.13 = num;
			if (this.12 != this.13)
			{
				208 3 = this.1.71(0, Math.Min(this.1.GetText().Length, this.13));
				3.X -= 3f;
				3.Y -= 3f;
				int num2 = (int)Math.Max(0.0, Math.Floor((double)(3.X / Math.Max(this.20, 1f))));
				1433 4 = this.7;
				4.9(4.8() || num2 > 0);
				float num3 = (float)num2 * 3.Y;
				float val = 3.X - (float)(num2 * 6);
				this.7.17 = this.1.27();
				1433 5 = this.7;
				5.17.X = 5.17.X + Math.Max(0f, val);
				1433 6 = this.7;
				6.17.Y = 6.17.Y + ((float)this.22 + num3);
				this.21.17 = this.7.17;
				1452 7 = this.21;
				7.17.Y = 7.17.Y - (float)this.22;
			}
		}, true);
	}

	// Token: 0x06004D2B RID: 19755 RVA: 0x001E8BE8 File Offset: 0x001E6DE8
	internal virtual void UpdateCaret()
	{
		this.7.9(!this.1() || (this.9 && this.8) || this.1.GetText().Length == this.4);
		int num = Math.Max(0, this.15.11.SelectionStart);
		if (this.9 && this.8)
		{
			this.15.11.SelectionStart = this.15.11.Text.Length;
		}
		this.12 = this.13;
		this.13 = num;
		if (this.12 != this.13)
		{
			208 <<EMPTY_NAME>> = this.1.71(0, Math.Min(this.1.GetText().Length, this.13));
			<<EMPTY_NAME>>.X -= 3f;
			<<EMPTY_NAME>>.Y -= 3f;
			int num2 = (int)Math.Max(0.0, Math.Floor((double)(<<EMPTY_NAME>>.X / Math.Max(this.20, 1f))));
			1433 2 = this.7;
			2.9(2.8() || num2 > 0);
			float num3 = (float)num2 * <<EMPTY_NAME>>.Y;
			float val = <<EMPTY_NAME>>.X - (float)(num2 * 6);
			this.7.17 = this.1.27();
			1433 3 = this.7;
			3.17.X = 3.17.X + Math.Max(0f, val);
			1433 4 = this.7;
			4.17.Y = 4.17.Y + ((float)this.22 + num3);
			this.21.17 = this.7.17;
			1452 5 = this.21;
			5.17.Y = 5.17.Y - (float)this.22;
		}
	}

	// Token: 0x06004D2C RID: 19756 RVA: 0x001E8DCD File Offset: 0x001E6FCD
	private void OnClick(object 1, EventArgs 2)
	{
		if (!this.11)
		{
			1662.89.Schedule(new 1189(this.12), true);
		}
	}

	// Token: 0x06004D2D RID: 19757 RVA: 0x001E8DF0 File Offset: 0x001E6FF0
	private void 12()
	{
		if (!this.11 && !this.1())
		{
			this.6 = this.1.GetText();
			if (this.5)
			{
				this.1.SetText(string.Empty);
			}
			this.2(true);
			this.1.60(this.3);
			this.1.58(this.23);
			this.15.Text = this.1.GetText();
			this.15.4(true);
			this.7.3.Clear();
			this.7.3.Add(new 1445(1456.Fade, 1f, 0.4f, 1662.33, 1662.33 + 1000, (1046)0)
			{
				15 = (1046)1,
				17 = true
			});
			this.12 = -1;
			1448.1449 <<EMPTY_NAME>> = this.18;
			if (<<EMPTY_NAME>> != null)
			{
				<<EMPTY_NAME>>(this, false);
			}
			this.UpdateCaret();
			this.10();
		}
	}

	// Token: 0x06004D2E RID: 19758 RVA: 0x001E8EFC File Offset: 0x001E70FC
	private bool 13(object 1, EventArgs 2)
	{
		if (!this.1() || this.11 || !1555.31)
		{
			return false;
		}
		if (!this.1.50.9(1555.17()))
		{
			this.Unfocus(this.25);
		}
		return false;
	}

	// Token: 0x06004D2F RID: 19759 RVA: 0x001E8F3B File Offset: 0x001E713B
	internal void 14(198 1)
	{
		this.23 = 1;
		if (this.1())
		{
			this.1.58(1);
		}
	}

	// Token: 0x06004D30 RID: 19760 RVA: 0x001E8F58 File Offset: 0x001E7158
	internal void 15(198 1)
	{
		this.24 = 1;
		if (!this.1())
		{
			this.1.58(1);
		}
	}

	// Token: 0x06004D31 RID: 19761 RVA: 0x001E8F78 File Offset: 0x001E7178
	protected virtual void Unfocus(bool 1)
	{
		if (!this.11 && this.1())
		{
			this.2(false);
			this.1.60(new 198(180, 180, 180));
			this.1.58(this.24);
			this.15.4(false);
			this.7.3.Clear();
			this.7.16(50, (1046)0, 0);
			this.6(1);
			this.10();
		}
	}

	// Token: 0x06004D32 RID: 19762 RVA: 0x001E9004 File Offset: 0x001E7204
	public void 16()
	{
		if (!this.11)
		{
			this.12();
		}
	}

	// Token: 0x06004D33 RID: 19763 RVA: 0x001E9014 File Offset: 0x001E7214
	internal virtual string GetText()
	{
		1706 <<EMPTY_NAME>> = this.15 as 1706;
		if (<<EMPTY_NAME>> == null)
		{
			return this.1.GetText();
		}
		return <<EMPTY_NAME>>.19();
	}

	// Token: 0x06004D34 RID: 19764 RVA: 0x001E9042 File Offset: 0x001E7242
	internal virtual void SetText(string 1)
	{
		if (!(1 == this.1.GetText()))
		{
			this.15.Text = 1;
			this.1.SetText(this.15.Text);
			this.10();
		}
	}

	// Token: 0x06004D35 RID: 19765 RVA: 0x001E907F File Offset: 0x001E727F
	public virtual bool IsEnabled()
	{
		return this.26;
	}

	// Token: 0x06004D36 RID: 19766 RVA: 0x001E9088 File Offset: 0x001E7288
	public virtual void SetEnabled(bool 1)
	{
		if (this.26 != 1)
		{
			this.26 = 1;
			this.1.10 = this.26;
			this.1.62(this.26 ? 198.White : new 198(180, 180, 180));
			if (this.1())
			{
				this.Unfocus(this.25);
			}
		}
	}

	// Token: 0x06004D37 RID: 19767 RVA: 0x001E90F8 File Offset: 0x001E72F8
	internal void 17(bool 1)
	{
		if (1)
		{
			this.2(false);
		}
		this.12();
	}

	// Token: 0x06004D38 RID: 19768 RVA: 0x001E910A File Offset: 0x001E730A
	internal void 18(bool 1)
	{
		if (1)
		{
			this.2(true);
		}
		this.Unfocus(false);
	}

	// Token: 0x06004D39 RID: 19769 RVA: 0x001E911D File Offset: 0x001E731D
	public 208 19()
	{
		return this.1.GetTextSize();
	}

	// Token: 0x06004D3A RID: 19770 RVA: 0x001E912A File Offset: 0x001E732A
	private void 20()
	{
		1662.13().Controls.Remove(this.15);
		this.15.Dispose();
	}

	// Token: 0x04003982 RID: 14722
	internal readonly 1452 1;

	// Token: 0x04003983 RID: 14723
	internal List<1433> 2 = new List<1433>();

	// Token: 0x04003984 RID: 14724
	internal 198 3 = 198.White;

	// Token: 0x04003985 RID: 14725
	internal int 4;

	// Token: 0x04003986 RID: 14726
	internal bool 5;

	// Token: 0x04003987 RID: 14727
	internal string 6;

	// Token: 0x04003988 RID: 14728
	protected 1433 7;

	// Token: 0x04003989 RID: 14729
	protected bool 8;

	// Token: 0x0400398A RID: 14730
	protected bool 9;

	// Token: 0x0400398B RID: 14731
	private bool 10;

	// Token: 0x0400398C RID: 14732
	public bool 11;

	// Token: 0x0400398D RID: 14733
	private int 12;

	// Token: 0x0400398E RID: 14734
	private int 13;

	// Token: 0x0400398F RID: 14735
	internal float 14;

	// Token: 0x04003990 RID: 14736
	internal 1729 15;

	// Token: 0x04003991 RID: 14737
	private 1448.1449 16;

	// Token: 0x04003992 RID: 14738
	private 1448.1449 17;

	// Token: 0x04003993 RID: 14739
	private 1448.1449 18;

	// Token: 0x04003994 RID: 14740
	private float 19;

	// Token: 0x04003995 RID: 14741
	private float 20;

	// Token: 0x04003996 RID: 14742
	internal 1452 21;

	// Token: 0x04003997 RID: 14743
	internal int 22 = 2;

	// Token: 0x04003998 RID: 14744
	private 198 23 = new 198(50, 50, 50, 200);

	// Token: 0x04003999 RID: 14745
	private 198 24 = new 198(50, 50, 50, 80);

	// Token: 0x0400399A RID: 14746
	internal bool 25 = true;

	// Token: 0x0400399B RID: 14747
	private bool 26;

	// Token: 0x02000AD8 RID: 2776
	// (Invoke) Token: 0x06004D3F RID: 19775
	public delegate void 1449(1448 1, bool 2);
}
