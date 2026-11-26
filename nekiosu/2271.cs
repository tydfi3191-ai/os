using System;

// Token: 0x02000580 RID: 1408
public class 2271 : 2254
{
	// Token: 0x06002B9E RID: 11166 RVA: 0x000EE3A8 File Offset: 0x000EC5A8
	public 2271()
	{
		this.3 = true;
	}

	// Token: 0x06002B9F RID: 11167 RVA: 0x0000D019 File Offset: 0x0000B219
	public override 2277 _0005_2005_2000_200A_2003_2005_2004_2004_2005_2003_2000()
	{
		return 2277.Meta;
	}

	// Token: 0x06002BA0 RID: 11168 RVA: 0x000EE3B7 File Offset: 0x000EC5B7
	protected new 1262 1()
	{
		return 1272.5();
	}

	// Token: 0x06002BA1 RID: 11169 RVA: 0x000EE3C0 File Offset: 0x000EC5C0
	protected override void _000E_2000_2004_2001_2006_2006_2000_2005_2007_2009_2007_2000_2005_200B_200A_2004_2007_2002_2003_2001_2003_2005_200A_2007_200B(2046 1)
	{
		if (this.1().35(this.1().3()))
		{
			this.1().24(1 as 2039);
		}
		this.2 = this.1().13();
		this._000F_2001_2009_2003_2003_2003_2001_2005_2001_2008_2009_2000_2005_2004_200B();
		this._0005_2009_2003_2006_2006_200A_2002_2004_2007_2007_2000_2003_2000_2006_2004_2004_2005_2007_2007_2002_2006_2009_2000_2007_2007_2002();
	}

	// Token: 0x06002BA2 RID: 11170 RVA: 0x000EE414 File Offset: 0x000EC614
	private bool 2(string 1)
	{
		for (int i = 0; i < 1.Length; i++)
		{
			if (1[i] > 'Ā')
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06002BA3 RID: 11171 RVA: 0x000EE444 File Offset: 0x000EC644
	protected virtual void _000F_2001_2009_2003_2003_2003_2001_2005_2001_2008_2009_2000_2005_2004_200B()
	{
		if (!this.2(this.1().7))
		{
			this.1.Add(new 2278((2341)2, 1568.1(2679.AIMeta_RomanizedArtistUnicode)));
		}
		if (!this.2(this.1().10))
		{
			this.1.Add(new 2278((2341)2, 1568.1(2679.AIMeta_RomanizedTitleUnicode)));
		}
		if (!this.2(this.1().89))
		{
			this.1.Add(new 2278((2341)1, "Difficulty name contains unicode characters."));
		}
		if (this.3 && (this.1().83 < 0.3f || this.1().83 > 0.9f))
		{
			this.1.Add(new 2278((2341)1, 1568.1(2679.AIMeta_IncorrectStackLeniency)));
		}
		if (this.1().52 <= 30)
		{
			this.1.Add(new 2278((2341)2, "Drain time should be over 30 seconds."));
		}
	}

	// Token: 0x06002BA4 RID: 11172 RVA: 0x00005ADD File Offset: 0x00003CDD
	protected virtual void _0005_2009_2003_2006_2006_200A_2002_2004_2007_2007_2000_2003_2000_2006_2004_2004_2005_2007_2007_2002_2006_2009_2000_2007_2007_2002()
	{
	}

	// Token: 0x04001FE9 RID: 8169
	public 2327 2;

	// Token: 0x04001FEA RID: 8170
	protected bool 3;
}
