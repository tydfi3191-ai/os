using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

// Token: 0x0200096C RID: 2412
public class 1729 : UserControl
{
	// Token: 0x170002DB RID: 731
	// (get) Token: 0x060043F1 RID: 17393 RVA: 0x001AC2ED File Offset: 0x001AA4ED
	// (set) Token: 0x060043F2 RID: 17394 RVA: 0x001AC2FA File Offset: 0x001AA4FA
	public override string Text
	{
		get
		{
			return this.11.Text;
		}
		set
		{
			this.11.Text = value;
			if (this.11.Text.Length >= 1)
			{
				this.11.SelectionStart = this.11.Text.Length;
			}
		}
	}

	// Token: 0x170002DC RID: 732
	// (get) Token: 0x060043F3 RID: 17395 RVA: 0x001AC336 File Offset: 0x001AA536
	public override bool Focused
	{
		get
		{
			return base.Focused || this.11.Focused;
		}
	}

	// Token: 0x060043F4 RID: 17396 RVA: 0x001AC350 File Offset: 0x001AA550
	internal 1729(1448 1)
	{
		this.17();
		this.8 = 2;
		this.11.Font = new Font(1450.13((1068)0), 2.1.65() * 1.14f);
		this.2();
		this.11.ReadOnly = true;
		this.11.KeyDown += this.5;
		this.11.KeyUp += this.6;
		this.11.2(delegate(string 1)
		{
			if (this.2 != null)
			{
				this.2(1);
			}
		});
		this.11.3(new 1184(this.2));
	}

	// Token: 0x060043F5 RID: 17397 RVA: 0x001AC405 File Offset: 0x001AA605
	private void 1(bool 1)
	{
		if (1)
		{
			if (this.4 != null)
			{
				this.4();
				return;
			}
		}
		else if (this.3 != null)
		{
			this.3();
		}
	}

	// Token: 0x060043F6 RID: 17398 RVA: 0x001AC434 File Offset: 0x001AA634
	internal void 2()
	{
		float num = this.8.1.77.X * 1662.70.3();
		base.Size = new Size((int)num, 0);
		base.Location = new Point((int)(this.8.1.27().X * 1662.70.3()), (int)(this.8.1.27().Y * 1662.70.3()) + 5000);
	}

	// Token: 0x060043F7 RID: 17399 RVA: 0x001AC4C3 File Offset: 0x001AA6C3
	internal bool 3()
	{
		return !this.11.ReadOnly;
	}

	// Token: 0x060043F8 RID: 17400 RVA: 0x001AC4D3 File Offset: 0x001AA6D3
	internal void 4(bool 1)
	{
		if (!this.11.IsDisposed)
		{
			this.11.ReadOnly = !1;
			if (1)
			{
				1535.30(this);
				return;
			}
			1535.31(this);
		}
	}

	// Token: 0x060043F9 RID: 17401 RVA: 0x001AC504 File Offset: 0x001AA704
	private void 5(object 1, KeyEventArgs 2)
	{
		if (2.Alt && !2.Control)
		{
			Keys keyCode = 2.KeyCode;
			if (keyCode <= Keys.O)
			{
				if (keyCode - Keys.D > 2 && keyCode != Keys.H && keyCode != Keys.O)
				{
					goto IL_41;
				}
			}
			else if (keyCode != Keys.T && keyCode - Keys.V > 1 && keyCode != Keys.F4)
			{
				goto IL_41;
			}
			return;
			IL_41:
			2.SuppressKeyPress = true;
			return;
		}
		if (!this.3())
		{
			return;
		}
		if (this.7 != null)
		{
			this.7(1, 2);
		}
		if (2.Control && 2.Alt && 2.KeyValue >= 48 && 2.KeyValue <= 57)
		{
			return;
		}
		if (2.Control && 2.KeyCode == Keys.Back)
		{
			if (this.Text.Length > 0 && this.11.SelectionLength == 0)
			{
				int num = Math.Max(0, this.11.SelectionStart);
				int i;
				for (i = num; i > 0; i--)
				{
					if (!char.IsWhiteSpace(this.Text[i - 1]))
					{
						break;
					}
				}
				while (i > 0 && !char.IsWhiteSpace(this.Text[i - 1]))
				{
					i--;
				}
				this.Text = this.Text.Remove(i, num - i);
				this.11.SelectionStart = i;
				this.8.UpdateCaret();
			}
			2.SuppressKeyPress = true;
			return;
		}
		if (2.Control && !2.Alt && 2.KeyCode == Keys.O)
		{
			2.SuppressKeyPress = true;
			return;
		}
		if (2.Shift && 2.KeyCode == Keys.Delete)
		{
			2.SuppressKeyPress = true;
			return;
		}
		if (2.KeyCode != Keys.Left && 2.KeyCode != Keys.Right)
		{
			Keys keyCode = 2.KeyCode;
			if (keyCode <= Keys.Up)
			{
				if (keyCode != Keys.Return && keyCode != Keys.Escape && keyCode != Keys.Up)
				{
					goto IL_1F7;
				}
			}
			else if (keyCode <= Keys.F5)
			{
				if (keyCode != Keys.Down && keyCode != Keys.F5)
				{
					goto IL_1F7;
				}
			}
			else if (keyCode != Keys.F10 && keyCode != Keys.F12)
			{
				goto IL_1F7;
			}
			2.SuppressKeyPress = true;
			return;
			IL_1F7:
			keyCode = 2.KeyCode;
			if (keyCode != Keys.Back)
			{
				if (keyCode - Keys.ShiftKey <= 1)
				{
					return;
				}
				if (keyCode != Keys.Delete)
				{
					if (this.3())
					{
						if (DateTime.Now.Month == 4 && DateTime.Now.Day == 1)
						{
							1226.24(string.Format("key-smash-{0}", 1196.2(1, 5)), 100, (1416)3, false);
							return;
						}
						1226.26(new string[]
						{
							string.Format("key-press-{0}", 1196.2(1, 5)),
							"key-press"
						});
					}
					return;
				}
			}
			1226.24("key-delete", 100, (1416)3, false);
			return;
		}
		if (this.9)
		{
			2.SuppressKeyPress = true;
			return;
		}
		1226.24("key-movement", 100, (1416)3, false);
	}

	// Token: 0x060043FA RID: 17402 RVA: 0x001AC7A6 File Offset: 0x001AA9A6
	private void 6(object 1, KeyEventArgs 2)
	{
		if (this.5 != null)
		{
			this.5();
		}
	}

	// Token: 0x060043FB RID: 17403 RVA: 0x001AC7BC File Offset: 0x001AA9BC
	internal void 7(EventHandler 1)
	{
		EventHandler eventHandler = this.1;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, 1);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.1, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060043FC RID: 17404 RVA: 0x001AC7F4 File Offset: 0x001AA9F4
	internal void 8(EventHandler 1)
	{
		EventHandler eventHandler = this.1;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, 1);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.1, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060043FD RID: 17405 RVA: 0x001AC82C File Offset: 0x001AAA2C
	internal void 9(1188 1)
	{
		1188 2 = this.2;
		1188 3;
		do
		{
			3 = 2;
			1188 value = (1188)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1188>(ref this.2, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x060043FE RID: 17406 RVA: 0x001AC864 File Offset: 0x001AAA64
	internal void 10(1189 1)
	{
		1189 2 = this.3;
		1189 3;
		do
		{
			3 = 2;
			1189 value = (1189)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1189>(ref this.3, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x060043FF RID: 17407 RVA: 0x001AC89C File Offset: 0x001AAA9C
	internal void 11(1189 1)
	{
		1189 2 = this.4;
		1189 3;
		do
		{
			3 = 2;
			1189 value = (1189)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1189>(ref this.4, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06004400 RID: 17408 RVA: 0x001AC8D4 File Offset: 0x001AAAD4
	internal void 12(1189 1)
	{
		1189 2 = this.5;
		1189 3;
		do
		{
			3 = 2;
			1189 value = (1189)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1189>(ref this.5, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06004401 RID: 17409 RVA: 0x001AC909 File Offset: 0x001AAB09
	private void 13(object 1, EventArgs 2)
	{
		1535.32(true);
	}

	// Token: 0x06004402 RID: 17410 RVA: 0x001AC914 File Offset: 0x001AAB14
	protected override void OnGotFocus(EventArgs 1)
	{
		this.11.Focus();
		if (this.11.Text.Length >= 1)
		{
			this.11.SelectionStart = this.11.Text.Length;
		}
		base.OnGotFocus(1);
	}

	// Token: 0x06004403 RID: 17411 RVA: 0x001AC964 File Offset: 0x001AAB64
	private void 14(object 1, EventArgs 2)
	{
		if (this.3() && !(this.11.Text == this.6))
		{
			EventHandler eventHandler = this.1;
			if (eventHandler != null)
			{
				eventHandler(null, null);
			}
			this.6 = this.11.Text;
		}
	}

	// Token: 0x06004404 RID: 17412 RVA: 0x001AC9B8 File Offset: 0x001AABB8
	public void 15(KeyEventHandler 1)
	{
		KeyEventHandler keyEventHandler = this.7;
		KeyEventHandler keyEventHandler2;
		do
		{
			keyEventHandler2 = keyEventHandler;
			KeyEventHandler value = (KeyEventHandler)Delegate.Combine(keyEventHandler2, 1);
			keyEventHandler = Interlocked.CompareExchange<KeyEventHandler>(ref this.7, value, keyEventHandler2);
		}
		while (keyEventHandler != keyEventHandler2);
	}

	// Token: 0x06004405 RID: 17413 RVA: 0x001AC9F0 File Offset: 0x001AABF0
	public void 16(KeyEventHandler 1)
	{
		KeyEventHandler keyEventHandler = this.7;
		KeyEventHandler keyEventHandler2;
		do
		{
			keyEventHandler2 = keyEventHandler;
			KeyEventHandler value = (KeyEventHandler)Delegate.Remove(keyEventHandler2, 1);
			keyEventHandler = Interlocked.CompareExchange<KeyEventHandler>(ref this.7, value, keyEventHandler2);
		}
		while (keyEventHandler != keyEventHandler2);
	}

	// Token: 0x06004406 RID: 17414 RVA: 0x001ACA25 File Offset: 0x001AAC25
	protected override void Dispose(bool 1)
	{
		1535.31(this);
		if (1 && this.10 != null)
		{
			this.10.Dispose();
		}
		base.Dispose(1);
	}

	// Token: 0x06004407 RID: 17415 RVA: 0x001ACA4C File Offset: 0x001AAC4C
	private void 17()
	{
		this.11 = new 1695();
		base.SuspendLayout();
		this.11.BorderStyle = BorderStyle.None;
		this.11.CausesValidation = false;
		this.11.Cursor = Cursors.Arrow;
		this.11.Dock = DockStyle.Fill;
		this.11.HideSelection = false;
		this.11.Location = new Point(0, 0);
		this.11.Name = "TextBox";
		this.11.Size = new Size(227, 20);
		this.11.TabIndex = 0;
		this.11.TabStop = false;
		this.11.WordWrap = false;
		this.11.TextChanged += this.14;
		this.11.Leave += this.13;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.CausesValidation = false;
		base.Controls.Add(this.11);
		base.Location = new Point(0, 0);
		base.Name = "TextInputControl";
		base.Size = new Size(227, 20);
		base.PreviewKeyDown += delegate(object 1, PreviewKeyDownEventArgs 2)
		{
			if (2.KeyData == Keys.Tab)
			{
				2.IsInputKey = false;
			}
		};
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x040031D6 RID: 12758
	private EventHandler 1;

	// Token: 0x040031D7 RID: 12759
	private 1188 2;

	// Token: 0x040031D8 RID: 12760
	private 1189 3;

	// Token: 0x040031D9 RID: 12761
	private 1189 4;

	// Token: 0x040031DA RID: 12762
	private 1189 5;

	// Token: 0x040031DB RID: 12763
	private string 6;

	// Token: 0x040031DC RID: 12764
	private KeyEventHandler 7;

	// Token: 0x040031DD RID: 12765
	internal 1448 8;

	// Token: 0x040031DE RID: 12766
	internal bool 9;

	// Token: 0x040031DF RID: 12767
	private IContainer 10;

	// Token: 0x040031E0 RID: 12768
	internal 1695 11;
}
