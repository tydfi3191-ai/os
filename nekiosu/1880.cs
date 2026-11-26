using System;

// Token: 0x020007BE RID: 1982
public sealed class 1880 : 2155
{
	// Token: 0x060039D1 RID: 14801 RVA: 0x0013F9EA File Offset: 0x0013DBEA
	public 1880(2149 1, bool 2, bool 3) : base(1, 2, 3)
	{
	}

	// Token: 0x060039D2 RID: 14802 RVA: 0x0016D1D4 File Offset: 0x0016B3D4
	public override int GetBaseScore()
	{
		2149 <<EMPTY_NAME>> = this.4 & (2149)(-8);
		int result;
		if (<<EMPTY_NAME>> != (2149)2048)
		{
			if (<<EMPTY_NAME>> != (2149)16384)
			{
				result = base.GetBaseScore();
			}
			else
			{
				result = 200;
			}
		}
		else
		{
			result = 100;
		}
		return result;
	}
}
