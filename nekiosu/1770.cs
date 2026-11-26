using System;

// Token: 0x020008AD RID: 2221
public sealed class 1770 : 1779
{
	// Token: 0x06003F93 RID: 16275 RVA: 0x0018A165 File Offset: 0x00188365
	public 1770(2679 1, 198 2, EventHandler 3 = null) : this(1568.1(1), 2, 3)
	{
		base.10(1.ToString());
	}

	// Token: 0x06003F94 RID: 16276 RVA: 0x0018A188 File Offset: 0x00188388
	public 1770(string 1, 198 2, EventHandler 3 = null)
	{
		base.3(new 208(244f, 20f));
		this.13 = new 1361(1, new 208(0f, 0f), base.2(), 1f, 2, 3, false, false, new float?(12f), true);
		this.1.14<1433>(this.13.1);
		base.10(1);
	}

	// Token: 0x06003F95 RID: 16277 RVA: 0x0018A202 File Offset: 0x00188402
	public void 18(string 1)
	{
		this.13.4.SetText(1);
	}

	// Token: 0x06003F96 RID: 16278 RVA: 0x0018A215 File Offset: 0x00188415
	internal void 19(bool 1)
	{
		this.13.7(1);
	}

	// Token: 0x04002E84 RID: 11908
	private new 1361 13;
}
