using System;
using System.Windows.Forms;

// Token: 0x02000AF8 RID: 2808
public sealed class 1473 : ListView
{
	// Token: 0x06004E26 RID: 20006 RVA: 0x001EECB0 File Offset: 0x001ECEB0
	public 1473()
	{
		base.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		this.1();
	}

	// Token: 0x06004E27 RID: 20007 RVA: 0x001EECCC File Offset: 0x001ECECC
	private void 1()
	{
		if (this.1 || base.Columns.Count == 0 || !this.2)
		{
			return;
		}
		float num = 2328.1(this, false) / 96f;
		foreach (object obj in base.Columns)
		{
			ColumnHeader columnHeader = (ColumnHeader)obj;
			columnHeader.Width = (int)((float)columnHeader.Width * num);
		}
		this.1 = true;
	}

	// Token: 0x06004E28 RID: 20008 RVA: 0x001EED60 File Offset: 0x001ECF60
	protected override void OnLayout(LayoutEventArgs 1)
	{
		base.OnLayout(1);
		this.1();
	}

	// Token: 0x06004E29 RID: 20009 RVA: 0x001EED6F File Offset: 0x001ECF6F
	protected override void OnColumnWidthChanged(ColumnWidthChangedEventArgs 1)
	{
		base.OnColumnWidthChanged(1);
		this.2 = true;
	}

	// Token: 0x04003A4B RID: 14923
	private bool 1;

	// Token: 0x04003A4C RID: 14924
	private bool 2;
}
