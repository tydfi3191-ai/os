using System;

// Token: 0x02000B13 RID: 2835
public sealed class 1493 : 1496
{
	// Token: 0x06004EC1 RID: 20161 RVA: 0x001F20A4 File Offset: 0x001F02A4
	internal 1493(208 1, float 2, bool 3, bool 4) : base(null, null, 1, 2, 3, 4, new 1445(198.LightGray, 198.White, 0, 200), 1f)
	{
		this.1.SetTexture(1455.2("selection-tab-add", (1416)1, null));
		this.1.6 = 198.LightGray;
		this.1.48 = new 208(70f, 12f);
		this.1.10 = true;
		this.1.3(new EventHandler(base.2));
	}

	// Token: 0x06004EC2 RID: 20162 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal override bool IsSelectable()
	{
		return false;
	}
}
