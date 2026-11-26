using System;

// Token: 0x0200002D RID: 45
public sealed class 289
{
	// Token: 0x060000FD RID: 253 RVA: 0x00006147 File Offset: 0x00004347
	public 289(bool 1, 330 2, 330 3)
	{
		if (2 == null)
		{
			throw new ArgumentNullException("modulus");
		}
		if (3 == null)
		{
			throw new ArgumentNullException("exponent");
		}
		this.flag2 = 1;
		this._recoveredType01460030 = 2;
		this._recoveredType01460031 = 3;
	}

	// Token: 0x060000FE RID: 254 RVA: 0x00006180 File Offset: 0x00004380
	public bool GetFlag0029_114()
	{
		return this.flag2;
	}

	// Token: 0x060000FF RID: 255 RVA: 0x00006188 File Offset: 0x00004388
	public 330 GetRecoveredType01460030_115()
	{
		return this._recoveredType01460030;
	}

	// Token: 0x06000100 RID: 256 RVA: 0x00006190 File Offset: 0x00004390
	public 330 GetRecoveredType01460031_116()
	{
		return this._recoveredType01460031;
	}

	// Token: 0x0400006A RID: 106
	private readonly bool flag2;

	// Token: 0x0400006B RID: 107
	private readonly 330 _recoveredType01460030;

	// Token: 0x0400006C RID: 108
	private readonly 330 _recoveredType01460031;
}
