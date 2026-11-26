using System;

// Token: 0x02000794 RID: 1940
public sealed class 1964 : 2271
{
	// Token: 0x060038F2 RID: 14578 RVA: 0x0012766B File Offset: 0x0012586B
	public 1964()
	{
		this.3 = false;
	}

	// Token: 0x060038F3 RID: 14579 RVA: 0x0016610C File Offset: 0x0016430C
	protected override void _000F_2001_2009_2003_2003_2003_2001_2005_2001_2008_2009_2000_2005_2004_200B()
	{
		if (base.1().62)
		{
			this.1.Add(new 2278((2341)1, 1568.1(2679.AIMetaMania_NoManiaLetterbox)));
		}
		if (base.1().38 != (1284)0)
		{
			this.1.Add(new 2278((2341)1, 1568.1(2679.AIMetaMania_NoManiaCountdown)));
		}
		base._000F_2001_2009_2003_2003_2003_2001_2005_2001_2008_2009_2000_2005_2004_200B();
	}

	// Token: 0x060038F4 RID: 14580 RVA: 0x00166170 File Offset: 0x00164370
	protected override void _0005_2009_2003_2006_2006_200A_2002_2004_2007_2007_2000_2003_2000_2006_2004_2004_2005_2007_2007_2002_2006_2009_2000_2007_2007_2002()
	{
		if (Math.Round((double)base.1().3) < 4.0 && this.2 < 2327.Hard)
		{
			this.1.Add(new 2278((2341)0, 1568.1(2679.AIMetaMania_EasyHpBelow4)));
		}
		else if (Math.Round((double)base.1().3) < 7.0 && this.2 >= 2327.Hard)
		{
			this.1.Add(new 2278((2341)0, 1568.1(2679.AIMetaMania_HardHpBelow7)));
		}
		double num = (double)base.1().41 / (double)base.1().65;
		if (num < 0.05 && Math.Round((double)base.1().4) < 8.0)
		{
			this.1.Add(new 2278((2341)0, 1568.1(2679.AIMetaMania_VeryLowSliderOdBelow8)));
			return;
		}
		if (num < 0.25 && Math.Round((double)base.1().4) < 7.0)
		{
			this.1.Add(new 2278((2341)0, 1568.1(2679.AIMetaMania_LowSliderOdBelow7)));
			return;
		}
		if (Math.Round((double)base.1().4) < 5.0)
		{
			this.1.Add(new 2278((2341)0, 1568.1(2679.AIMetaMania_OdBelow5)));
		}
	}
}
