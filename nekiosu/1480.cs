using System;
using System.ComponentModel;
using System.Windows.Forms;
using OpenTK.Graphics;

// Token: 0x02000AFF RID: 2815
public sealed class 1480 : 1131
{
	// Token: 0x06004E4B RID: 20043 RVA: 0x001EFA40 File Offset: 0x001EDC40
	public 1480(GraphicsContextFlags 1)
	{
		this.7 = new 1479(3);
		this.10().43(delegate(object 1, EventArgs 2)
		{
			base.9();
		});
		this.10().41(new EventHandler(this.12));
		this.10().42(new EventHandler(this.13));
		this.10().44(new EventHandler(this.14));
		this.10().Closing += delegate(object 1, CancelEventArgs 2)
		{
			base.7();
		};
		this.10().Paint += this.15;
	}

	// Token: 0x06004E4C RID: 20044 RVA: 0x001EFAE9 File Offset: 0x001EDCE9
	public 1479 10()
	{
		return this.7;
	}

	// Token: 0x06004E4D RID: 20045 RVA: 0x001EFAF1 File Offset: 0x001EDCF1
	public override 207 GetClientBounds()
	{
		return this.10().39();
	}

	// Token: 0x06004E4E RID: 20046 RVA: 0x001EFAFE File Offset: 0x001EDCFE
	public override bool HasEmptyClientArea()
	{
		return this.10().40();
	}

	// Token: 0x06004E4F RID: 20047 RVA: 0x001EFB0B File Offset: 0x001EDD0B
	public override IntPtr GetWindowHandle()
	{
		return this.10().Handle;
	}

	// Token: 0x06004E50 RID: 20048 RVA: 0x001EFB18 File Offset: 0x001EDD18
	internal void 11()
	{
		this.10().Close();
	}

	// Token: 0x06004E51 RID: 20049 RVA: 0x001EFB25 File Offset: 0x001EDD25
	protected override void ApplyTitle(string 1)
	{
		this.10().Text = 1;
	}

	// Token: 0x06004E52 RID: 20050 RVA: 0x001EFB33 File Offset: 0x001EDD33
	private void 12(object 1, EventArgs 2)
	{
		base.5();
	}

	// Token: 0x06004E53 RID: 20051 RVA: 0x001EFB3B File Offset: 0x001EDD3B
	private void 13(object 1, EventArgs 2)
	{
		base.7();
	}

	// Token: 0x06004E54 RID: 20052 RVA: 0x001EFB43 File Offset: 0x001EDD43
	private void 14(object 1, EventArgs 2)
	{
		base.6();
	}

	// Token: 0x06004E55 RID: 20053 RVA: 0x001EFB4B File Offset: 0x001EDD4B
	private void 15(object 1, PaintEventArgs 2)
	{
		base.8();
	}

	// Token: 0x04003A62 RID: 14946
	private new readonly 1479 7;
}
