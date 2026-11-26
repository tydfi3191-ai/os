using System;
using System.Collections.Generic;

// Token: 0x0200090F RID: 2319
public sealed class 1684 : 1689
{
	// Token: 0x060041F0 RID: 16880 RVA: 0x00199A04 File Offset: 0x00197C04
	internal 1684(EventHandler 1) : base(1568.1(2679.CollectionDialog_Collection), true)
	{
		this.22 = new 1417(new 207(0, 60, 550, 250), 208.Zero, false, 0f, 1545.Dialog);
		1684.18 = this;
		base.3(1);
		this.23 = 1;
		this.3 = 320f;
		base.7(1568.1(2679.CollectionDialog_DeleteCollection), 198.Red, new EventHandler(this.15), true, false, true);
		base.7(1568.1(2679.General_Close), 198.Gray, null, true, false, true);
		this.21 = new List<1686>();
		foreach (KeyValuePair<string, List<string>> keyValuePair in 1297.1())
		{
			this.21.Add(new 1686(keyValuePair.Key));
		}
		this.12();
	}

	// Token: 0x060041F1 RID: 16881 RVA: 0x00199B10 File Offset: 0x00197D10
	private void 12()
	{
		int num = 0;
		foreach (1686 <<EMPTY_NAME>> in this.21)
		{
			if (<<EMPTY_NAME>>.5(new 208((float)(1684.19 + 30), (float)num)))
			{
				this.22.22.14<1433>(<<EMPTY_NAME>>.13);
			}
			num += 17;
		}
		this.22.17(new 208(160f, (float)num));
	}

	// Token: 0x060041F2 RID: 16882 RVA: 0x00199BA8 File Offset: 0x00197DA8
	internal override void Close(bool 1 = false)
	{
		if (1684.18 == this)
		{
			1684.18 = null;
		}
		base.Close(1);
	}

	// Token: 0x060041F3 RID: 16883 RVA: 0x00199BBF File Offset: 0x00197DBF
	public override void Update()
	{
		this.22.Update();
		base.Update();
	}

	// Token: 0x060041F4 RID: 16884 RVA: 0x00199BD4 File Offset: 0x00197DD4
	internal override void Show()
	{
		string text = 1568.1(2679.Collection_EnterName);
		if (text.Length > 68)
		{
			text = text.Substring(0, 68) + "...";
		}
		this.20 = new 1448(text, 15f, new 208((float)(1684.19 + 30) + 1662.70.5(), 35f), 448f, 0.94f, false);
		this.20.3(new 1448.1449(this.13));
		this.20.4(new 1448.1449(this.14));
		this.20.5(delegate(1448 1, bool 2)
		{
			this.20.SetText(string.Empty);
		});
		this.7.14<1433>(this.20.2);
		base.Show();
	}

	// Token: 0x060041F5 RID: 16885 RVA: 0x00199CA8 File Offset: 0x00197EA8
	private void 13(1448 1, bool 2)
	{
		if (this.20.GetText().Length > 0 && 2)
		{
			string text = this.20.GetText();
			this.20.SetText(1568.1(2679.Collection_EnterName));
			if (1297.8(text))
			{
				this.21.Add(new 1686(text));
				1662.89.Schedule(new 1189(this.12), false);
			}
		}
	}

	// Token: 0x060041F6 RID: 16886 RVA: 0x00199D20 File Offset: 0x00197F20
	private new void 14(1448 1, bool 2)
	{
		if (this.20.GetText().Length > 25 && this.20.GetText() != 1568.1(2679.Collection_EnterName))
		{
			this.20.SetText(this.20.GetText().Substring(0, 25));
		}
	}

	// Token: 0x060041F7 RID: 16887 RVA: 0x00199D7C File Offset: 0x00197F7C
	private new void 15(object 1, EventArgs 2)
	{
		if (1684.24 == null)
		{
			1763.2(1568.1(2679.CollectionDialog_SelectACollectionFirst), 1500, (1389)0);
			1662.25(new 1684(this.23));
			return;
		}
		this.Close(false);
		1662.25(new 1688(string.Format(1568.1(2679.CollectionDialog_ConfirmDeleteCollection), 1684.24.3()), new EventHandler(this.17), new EventHandler(this.18), true));
	}

	// Token: 0x060041F8 RID: 16888 RVA: 0x00199DF9 File Offset: 0x00197FF9
	internal override void DrawDialog()
	{
		base.DrawDialog();
		this.22.21();
	}

	// Token: 0x060041F9 RID: 16889 RVA: 0x00199E0C File Offset: 0x0019800C
	protected override void Dispose(bool 1)
	{
		this.20.Dispose();
		this.22.Dispose();
		foreach (1686 2 in this.21)
		{
			2.9();
		}
		if (1684.18 == this)
		{
			1684.18 = null;
		}
		base.Dispose(1);
	}

	// Token: 0x060041FA RID: 16890 RVA: 0x00199E88 File Offset: 0x00198088
	internal new static void 16(1686 1)
	{
		1684.1685 2 = new 1684.1685();
		2.1 = 1;
		if (1684.18 != null)
		{
			1684.18.21.ForEach(new Action<1686>(2.1));
		}
		1684.24 = 2.1;
	}

	// Token: 0x060041FB RID: 16891 RVA: 0x00199ECF File Offset: 0x001980CF
	private new void 17(object 1, EventArgs 2)
	{
		1297.10(1684.24.3());
		1684.24 = null;
		1662.25(new 1684(this.23));
	}

	// Token: 0x060041FC RID: 16892 RVA: 0x00199EF6 File Offset: 0x001980F6
	private void 18(object 1, EventArgs 2)
	{
		1662.25(new 1684(this.23));
	}

	// Token: 0x04003026 RID: 12326
	private static 1684 18;

	// Token: 0x04003027 RID: 12327
	private static int 19 = 65;

	// Token: 0x04003028 RID: 12328
	private 1448 20;

	// Token: 0x04003029 RID: 12329
	private List<1686> 21;

	// Token: 0x0400302A RID: 12330
	private readonly 1417 22;

	// Token: 0x0400302B RID: 12331
	private EventHandler 23;

	// Token: 0x0400302C RID: 12332
	internal static 1686 24;

	// Token: 0x02000910 RID: 2320
	public sealed class 1685
	{
		// Token: 0x060041FF RID: 16895 RVA: 0x00199F23 File Offset: 0x00198123
		internal void 1(1686 1)
		{
			if (1 != this.1)
			{
				1.14();
			}
		}

		// Token: 0x0400302D RID: 12333
		public 1686 1;
	}
}
