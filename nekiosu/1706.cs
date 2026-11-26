using System;
using System.Text;
using System.Windows.Forms;

// Token: 0x0200092A RID: 2346
public sealed class 1706 : 1729
{
	// Token: 0x170002D9 RID: 729
	// (get) Token: 0x0600429F RID: 17055 RVA: 0x0019F77A File Offset: 0x0019D97A
	// (set) Token: 0x060042A0 RID: 17056 RVA: 0x0019F794 File Offset: 0x0019D994
	public override string Text
	{
		get
		{
			return this.21('*', this.11.Text.Length);
		}
		set
		{
			base.Text = value;
			this.20(value);
		}
	}

	// Token: 0x060042A1 RID: 17057 RVA: 0x0019F7A4 File Offset: 0x0019D9A4
	public 1706(1448 1) : base(1)
	{
		this.20(this.11.Text);
		base.12(new 1189(this.18));
		base.15(new KeyEventHandler(this.22));
	}

	// Token: 0x060042A2 RID: 17058 RVA: 0x0019F7E2 File Offset: 0x0019D9E2
	private void 18()
	{
		this.20(this.11.Text);
	}

	// Token: 0x060042A3 RID: 17059 RVA: 0x0019F7F5 File Offset: 0x0019D9F5
	internal string 19()
	{
		return this.12;
	}

	// Token: 0x060042A4 RID: 17060 RVA: 0x0019F7FD File Offset: 0x0019D9FD
	private void 20(string 1)
	{
		this.12 = 1;
	}

	// Token: 0x060042A5 RID: 17061 RVA: 0x0019F808 File Offset: 0x0019DA08
	private string 21(char 1, int 2)
	{
		StringBuilder stringBuilder = new StringBuilder(2);
		for (int i = 0; i < 2; i++)
		{
			stringBuilder.Append(1);
		}
		return stringBuilder.ToString();
	}

	// Token: 0x060042A6 RID: 17062 RVA: 0x0019F836 File Offset: 0x0019DA36
	private void 22(object 1, KeyEventArgs 2)
	{
		if (2.Control && 2.KeyCode == Keys.C)
		{
			2.SuppressKeyPress = true;
		}
	}

	// Token: 0x040030BA RID: 12474
	private new string 12;
}
