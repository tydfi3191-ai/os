using System;

// Token: 0x02000922 RID: 2338
public sealed class 1700
{
	// Token: 0x06004282 RID: 17026 RVA: 0x0019EBA8 File Offset: 0x0019CDA8
	internal 1700(1697 1, 1262 2, int 3)
	{
		this.4 = 1;
		this.3 = 2;
		this.1 = new 1452(2.11(), 20f, new 208(0f, (float)(3 * 30 + 5)), 2f, true, 198.White);
		this.2 = new 1360(new 208(0f, (float)(3 * 30)), new 208(640f * 1662.70.6() - 30f, 30f), 1f, new 198(50, 50, 50))
		{
			16 = 0.01f,
			28 = true,
			10 = true,
			11 = true
		};
		this.2.35(new EventHandler(this.1));
		this.2.37(new EventHandler(this.2));
		this.2.3(new EventHandler(this.OnClick));
	}

	// Token: 0x06004283 RID: 17027 RVA: 0x0019ECAA File Offset: 0x0019CEAA
	private void 1(object 1, EventArgs 2)
	{
		this.2.24(0.6f, 100, (1046)0);
	}

	// Token: 0x06004284 RID: 17028 RVA: 0x0019ECBF File Offset: 0x0019CEBF
	private void 2(object 1, EventArgs 2)
	{
		this.2.24(0.001f, 20, (1046)0);
	}

	// Token: 0x06004285 RID: 17029 RVA: 0x0019ECD4 File Offset: 0x0019CED4
	private void OnClick(object 1, EventArgs 2)
	{
		if (this.4.28 != null && this.4.28.37 == this.3.37)
		{
			this.4.27 = true;
		}
		this.4.28 = this.3;
		this.4.19(true, false);
	}

	// Token: 0x040030A5 RID: 12453
	internal 1452 1;

	// Token: 0x040030A6 RID: 12454
	internal 1360 2;

	// Token: 0x040030A7 RID: 12455
	internal 1262 3;

	// Token: 0x040030A8 RID: 12456
	private 1697 4;
}
