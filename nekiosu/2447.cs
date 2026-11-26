using System;

// Token: 0x020005D9 RID: 1497
public sealed class 2447 : 2453
{
	// Token: 0x06002E24 RID: 11812 RVA: 0x00106300 File Offset: 0x00104500
	public 2447(2458 1)
	{
		base.7((2452)1, 1);
	}

	// Token: 0x06002E25 RID: 11813 RVA: 0x00106310 File Offset: 0x00104510
	internal override 2448 CreateAction(2451 1, 2450 2)
	{
		if (1 != (2451)0)
		{
			switch (1)
			{
			case (2451)3:
				return new 2433(this, 2);
			case (2451)8:
				return new 2426(this, 2);
			case (2451)9:
				return new 2431(this, 2);
			case (2451)16:
				return new 2397(this, 2);
			case (2451)17:
				return new 2399(this, 2);
			case (2451)18:
				return new 2427(this, 2);
			case (2451)19:
				return new 2437(this, 2);
			case (2451)20:
				return new 2429(this, 2);
			case (2451)21:
				return new 2434(this, 2);
			case (2451)22:
				return new 2432(this, 2);
			case (2451)23:
				return new 2428(this, 2);
			}
			throw new NotImplementedException();
		}
		return new 2430(this, 2);
	}
}
