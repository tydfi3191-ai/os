using System;

// Token: 0x020008F8 RID: 2296
public sealed class 1757 : 1689
{
	// Token: 0x06004177 RID: 16759 RVA: 0x00196990 File Offset: 0x00194B90
	public 1757(string 1, string 2, Action<string> 3, Action 4) : base("Rename", true)
	{
		1757 <>4__this = this;
		this.20 = 3;
		float num = (float)1662.70.1() / 2f;
		this.7.12(new 1452(5 + ": type a name and press Enter (Esc: back)", 14f, new 208(0f, this.3 - 30f), 208.Zero, 0.94f, true, 198.LightGray, true)
		{
			41 = (1376)7,
			49 = 1065.Centre
		});
		this.19 = new 1448(6 ?? string.Empty, 16f, new 208(num - 150f, this.3 - 8f), 300f, 0.94f, false);
		this.19.4 = 40;
		this.19.25 = false;
		this.19.3(delegate(1448 1, bool 2)
		{
			if (2)
			{
				<>4__this.Finish(<>4__this.19.GetText());
				return;
			}
			<>4__this.Close(true);
		});
		this.7.14<1433>(this.19.2);
		this.3 += 35f;
		base.7("Save", 198.YellowGreen, delegate(object 1, EventArgs 2)
		{
			<>4__this.Finish(<>4__this.19.GetText());
		}, false, false, true);
		base.7("Reset", 198.DodgerBlue, delegate(object 1, EventArgs 2)
		{
			<>4__this.Finish(string.Empty);
		}, false, false, true);
		base.7("Back", 198.Gray, null, true, false, true);
		base.3(delegate(object 1, EventArgs 2)
		{
			Action closed = 4;
			if (closed == null)
			{
				return;
			}
			closed();
		});
	}

	// Token: 0x06004178 RID: 16760 RVA: 0x00196B28 File Offset: 0x00194D28
	private void Finish(string 1)
	{
		if (this.21)
		{
			return;
		}
		this.21 = true;
		this.20((1 ?? string.Empty).Trim());
		this.Close(false);
	}

	// Token: 0x06004179 RID: 16761 RVA: 0x00196B5B File Offset: 0x00194D5B
	internal override void OnShown()
	{
		base.OnShown();
		1662.89.Schedule(delegate()
		{
			this.19.16();
		}, true);
	}

	// Token: 0x0600417A RID: 16762 RVA: 0x00196B7B File Offset: 0x00194D7B
	internal override bool OnKeyDown(200 1)
	{
		return !this.19.1() && base.OnKeyDown(1);
	}

	// Token: 0x0600417B RID: 16763 RVA: 0x00196B93 File Offset: 0x00194D93
	protected override void Dispose(bool 1)
	{
		this.19.Dispose();
		base.Dispose(1);
	}

	// Token: 0x04002FCB RID: 12235
	private const int 18 = 40;

	// Token: 0x04002FCC RID: 12236
	private readonly 1448 19;

	// Token: 0x04002FCD RID: 12237
	private readonly Action<string> 20;

	// Token: 0x04002FCE RID: 12238
	private bool 21;
}
