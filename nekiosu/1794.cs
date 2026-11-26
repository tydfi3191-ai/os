using System;

// Token: 0x020008CD RID: 2253
public sealed class 1794 : 1779
{
	// Token: 0x0600409D RID: 16541 RVA: 0x001916DC File Offset: 0x0018F8DC
	public 1794(string 1, bool 2 = false)
	{
		this.15 = new 1452(1, 12f, 208.Zero, 1f, true, 198.White);
		this.1.12(this.15);
		this.13 = new 1448(string.Empty, 12f, new 208(0f, this.15.GetTextSize().Y + 5f), 239f, 1f, 2);
		this.13.4(new 1448.1449(this.22));
		this.13.3(new 1448.1449(this.23));
		this.1.14<1433>(this.13.2);
		base.10(1);
		this.19();
	}

	// Token: 0x0600409E RID: 16542 RVA: 0x001917B4 File Offset: 0x0018F9B4
	public 1794(string 1, 1320<string> 2, bool 3 = false) : this(4, 3)
	{
		1794.1795 textInputOptionClosure = new 1794.1795
		{
			1 = 5
		};
		textInputOptionClosure.2 = this;
		this.14 = textInputOptionClosure.1;
		this.14.SubscribeChanged(new EventHandler(this.18));
		this.13.SetText(this.14.GetValue());
		this.13.3(delegate(1448 1, bool 2)
		{
			textInputOptionClosure.1.SetValue(textInputOptionClosure.2.13.GetText());
		});
	}

	// Token: 0x0600409F RID: 16543 RVA: 0x00191842 File Offset: 0x0018FA42
	public 1794(2679 1, 1320<string> 2, bool 3 = false) : this(1568.1(1), 2, 3)
	{
		base.10(1.ToString());
	}

	// Token: 0x060040A0 RID: 16544 RVA: 0x00191865 File Offset: 0x0018FA65
	public 1794(2679 1, bool 2 = false) : this(1568.1(1), 2)
	{
		base.10(1.ToString());
	}

	// Token: 0x060040A1 RID: 16545 RVA: 0x00191887 File Offset: 0x0018FA87
	private void 18(object 1, EventArgs 2)
	{
		this.13.SetText(this.14.GetValue());
	}

	// Token: 0x060040A2 RID: 16546 RVA: 0x001918A0 File Offset: 0x0018FAA0
	private void 19()
	{
		float <<EMPTY_NAME>> = this.13.1.17.Y + this.13.1.GetTextSize().Y;
		base.3(new 208(base.2().X, <<EMPTY_NAME>>));
	}

	// Token: 0x060040A3 RID: 16547 RVA: 0x001918F0 File Offset: 0x0018FAF0
	internal void 20()
	{
		this.13.17(true);
	}

	// Token: 0x060040A4 RID: 16548 RVA: 0x001918FE File Offset: 0x0018FAFE
	internal void 21()
	{
		this.13.18(true);
	}

	// Token: 0x060040A5 RID: 16549 RVA: 0x0019190C File Offset: 0x0018FB0C
	public override void Dispose()
	{
		base.Dispose();
		this.13.Dispose();
	}

	// Token: 0x060040A6 RID: 16550 RVA: 0x0019191F File Offset: 0x0018FB1F
	private void 22(1448 1, bool 2)
	{
		this.19();
	}

	// Token: 0x060040A7 RID: 16551 RVA: 0x0019191F File Offset: 0x0018FB1F
	private void 23(1448 1, bool 2)
	{
		this.19();
	}

	// Token: 0x04002F3F RID: 12095
	internal new 1448 13;

	// Token: 0x04002F40 RID: 12096
	private new 1320<string> 14;

	// Token: 0x04002F41 RID: 12097
	private new 1452 15;

	// Token: 0x020008CE RID: 2254
	public sealed class 1795
	{
		// Token: 0x04002F42 RID: 12098
		public 1320<string> 1;

		// Token: 0x04002F43 RID: 12099
		public 1794 2;
	}
}
