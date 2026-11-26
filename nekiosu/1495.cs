using System;

// Token: 0x02000B15 RID: 2837
public class 1495 : 1498
{
	// Token: 0x06004ECA RID: 20170 RVA: 0x001F2410 File Offset: 0x001F0610
	internal 1495(1436 1, int 2, 208 3, float 4, bool 5, 198 6) : base(7, 8, 3, 4, 5, 6, 0, false)
	{
		1535.40((1082)3, new 1081(this.10), 1545.Default, (1559)1);
		1535.40((1082)6, delegate(object 1, EventArgs 2)
		{
			this.20 = null;
			this.21 = null;
			this.22 = 0f;
			return false;
		}, 1545.Default, (1559)1);
	}

	// Token: 0x06004ECB RID: 20171 RVA: 0x001F2456 File Offset: 0x001F0656
	protected override 1496 CreateTab(string 1, object 2, 208 3, float 4)
	{
		return base.CreateTab(1, 2, 3, 4);
	}

	// Token: 0x06004ECC RID: 20172 RVA: 0x001F2463 File Offset: 0x001F0663
	protected override void OnTabClicked(object 1, EventArgs 2)
	{
		base.OnTabClicked(1, 2);
		this.20 = (1 as 1496);
		this.22 = 1555.21().X;
	}

	// Token: 0x06004ECD RID: 20173 RVA: 0x001F248C File Offset: 0x001F068C
	private new bool 10(object 1, EventArgs 2)
	{
		1496 3 = null;
		foreach (1496 4 in this.16)
		{
			if (4 != this.20 && 4.1.IsHovered())
			{
				3 = 4;
				break;
			}
		}
		if (3 == null || (this.22 != 0f && Math.Abs(1555.21().X - this.22) <= 20f && 1662.33 - this.23 <= 500) || 1662.33 - this.23 <= 100)
		{
			return this.20 != null;
		}
		if (this.21 == 3 && this.24 == ((1555.21().X > this.22) ? 1 : -1) && 1662.33 - this.23 < 500)
		{
			return true;
		}
		this.21 = 3;
		this.23 = 1662.33;
		this.16.IndexOf(this.20);
		int index = this.16.IndexOf(3);
		if (this.20 != null)
		{
			this.16.Remove(this.20);
			this.24 = ((1555.21().X > this.22) ? 1 : -1);
			this.22 = 1555.21().X;
			this.16.Insert(index, this.20);
		}
		this.Layout();
		return true;
	}

	// Token: 0x06004ECE RID: 20174 RVA: 0x001F2624 File Offset: 0x001F0824
	public override void RemoveTab(1496 1)
	{
		base.RemoveTab(1);
		this.11(this, null);
	}

	// Token: 0x06004ECF RID: 20175 RVA: 0x001F2636 File Offset: 0x001F0836
	private new bool 11(object 1, EventArgs 2)
	{
		this.20 = null;
		this.21 = null;
		this.22 = 0f;
		return false;
	}

	// Token: 0x04003ABF RID: 15039
	protected 1496 20;

	// Token: 0x04003AC0 RID: 15040
	private 1496 21;

	// Token: 0x04003AC1 RID: 15041
	private float 22;

	// Token: 0x04003AC2 RID: 15042
	private int 23;

	// Token: 0x04003AC3 RID: 15043
	private int 24;
}
