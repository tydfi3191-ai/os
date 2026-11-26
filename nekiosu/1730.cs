using System;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x0200096E RID: 2414
public partial class 1730 : 1488
{
	// Token: 0x0600440C RID: 17420 RVA: 0x001ACBFA File Offset: 0x001AADFA
	protected override void OnLoad(EventArgs 1)
	{
		this.13(this);
		base.OnLoad(1);
	}

	// Token: 0x0600440D RID: 17421 RVA: 0x001ACC0C File Offset: 0x001AAE0C
	private void 13(Control 1)
	{
		this.BackColor = Color.White;
		foreach (object obj in 1.Controls)
		{
			Control 2 = (Control)obj;
			this.13(2);
		}
	}
}
