using System;

// Token: 0x020005D1 RID: 1489
public sealed class 2439 : 2453
{
	// Token: 0x06002E06 RID: 11782 RVA: 0x00105D31 File Offset: 0x00103F31
	public 2439(2458 1)
	{
		base.7((2452)3, 1);
	}

	// Token: 0x06002E07 RID: 11783 RVA: 0x00105D44 File Offset: 0x00103F44
	internal override 2448 CreateAction(2451 1, 2450 2)
	{
		2448 result;
		if (1 != (2451)0)
		{
			if (1 != (2451)8)
			{
				if (1 != (2451)9)
				{
					throw new NotImplementedException();
				}
				result = new 2372(this, 2);
			}
			else
			{
				result = new 2370(this, 2);
			}
		}
		else
		{
			result = new 2371(this, 2);
		}
		return result;
	}
}
