using System;

// Token: 0x0200083B RID: 2107
internal struct 1934
{
	// Token: 0x06003D2D RID: 15661 RVA: 0x00181FB6 File Offset: 0x001801B6
	public 1934(int 1)
	{
		this.1 = 1;
		this.2 = null;
	}

	// Token: 0x06003D2E RID: 15662 RVA: 0x00181FCB File Offset: 0x001801CB
	public 1934(1937 1)
	{
		this.1 = 1.1;
		this.2 = new 1937?(1);
	}

	// Token: 0x06003D2F RID: 15663 RVA: 0x00181FE5 File Offset: 0x001801E5
	public bool 1(int 1)
	{
		return this.2 == null && this.1 == 1;
	}

	// Token: 0x06003D30 RID: 15664 RVA: 0x00182000 File Offset: 0x00180200
	public bool 2(1937 1)
	{
		return this.2 != null && this.2.Value.Equals(1);
	}

	// Token: 0x04002D14 RID: 11540
	public readonly int 1;

	// Token: 0x04002D15 RID: 11541
	public readonly 1937? 2;
}
