using System;

// Token: 0x020006E6 RID: 1766
public sealed class 2177 : 2271
{
	// Token: 0x06003479 RID: 13433 RVA: 0x0012766B File Offset: 0x0012586B
	public 2177()
	{
		this.3 = false;
	}

	// Token: 0x0600347A RID: 13434 RVA: 0x001428E0 File Offset: 0x00140AE0
	protected override void _000F_2001_2009_2003_2003_2003_2001_2005_2001_2008_2009_2000_2005_2004_200B()
	{
		if (base.1().62)
		{
			this.1.Add(new 2278((2341)1, 1568.1(2679.AIMetaTaiko_NoLetterboxTaiko)));
		}
		if (base.1().5 != 1.4 && base.1().5 != 1.6)
		{
			this.1.Add(new 2278((2341)0, 1568.1(2679.AIMetaTaiko_BadSvTaiko)));
		}
		base._000F_2001_2009_2003_2003_2003_2001_2005_2001_2008_2009_2000_2005_2004_200B();
	}
}
