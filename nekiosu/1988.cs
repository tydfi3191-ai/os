using System;

// Token: 0x0200077C RID: 1916
public sealed class 1988 : 2155
{
	// Token: 0x06003844 RID: 14404 RVA: 0x0013F9EA File Offset: 0x0013DBEA
	public 1988(2149 1, bool 2, bool 3) : base(1, 2, 3)
	{
	}

	// Token: 0x06003845 RID: 14405 RVA: 0x0016031C File Offset: 0x0015E51C
	public override int GetBaseScore()
	{
		2149 <<EMPTY_NAME>> = this.4 & (2149)(-8);
		if (<<EMPTY_NAME>> <= (2149)33554432)
		{
			if (<<EMPTY_NAME>> == (2149)16777216)
			{
				return 50;
			}
			if (<<EMPTY_NAME>> == (2149)33554432)
			{
				return 100;
			}
		}
		else
		{
			if (<<EMPTY_NAME>> == (2149)67108864)
			{
				return 200;
			}
			if (<<EMPTY_NAME>> == (2149)134217728 || <<EMPTY_NAME>> == (2149)268435456)
			{
				return 300;
			}
		}
		return base.GetBaseScore();
	}
}
