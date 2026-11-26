using System;

// Token: 0x020006DB RID: 1755
public sealed class 2194 : 2155
{
	// Token: 0x06003418 RID: 13336 RVA: 0x0013F9EA File Offset: 0x0013DBEA
	public 2194(2149 1, bool 2, bool 3) : base(1, 2, 3)
	{
	}

	// Token: 0x06003419 RID: 13337 RVA: 0x0013F9F8 File Offset: 0x0013DBF8
	public override int GetBaseScore()
	{
		2149 <<EMPTY_NAME>> = this.4 & (2149)(-8);
		int result = 0;
		if ((<<EMPTY_NAME>> & (2149)1536) > (2149)0)
		{
			result = 300;
		}
		else if ((<<EMPTY_NAME>> & (2149)32768) > (2149)0)
		{
			result = 200;
		}
		return result;
	}
}
