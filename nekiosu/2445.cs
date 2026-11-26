using System;

// Token: 0x020005D7 RID: 1495
public sealed class 2445 : 2453
{
	// Token: 0x06002E21 RID: 11809 RVA: 0x001061D6 File Offset: 0x001043D6
	public 2445(2458 1)
	{
		base.7((2452)2, 1);
	}

	// Token: 0x06002E22 RID: 11810 RVA: 0x001061E8 File Offset: 0x001043E8
	internal override 2448 CreateAction(2451 1, 2450 2)
	{
		if (1 <= (2451)1)
		{
			if (1 == (2451)0)
			{
				return new 2407(this, 2);
			}
			if (1 == (2451)1)
			{
				if (1 == (2451)1)
				{
					return new 2411(this, 2);
				}
			}
		}
		else
		{
			switch (1)
			{
			case (2451)7:
				return new 2405(this, 2);
			case (2451)8:
				return new 2404(this, 2);
			case (2451)9:
				return new 2406(this, 2);
			default:
				switch (1)
				{
				case (2451)24:
					return new 2410(this, 2);
				case (2451)25:
					return new 2414(this, 2);
				case (2451)27:
					return new 2408(this, 2);
				case (2451)28:
					return new 2416(this, 2);
				case (2451)29:
					return new 2400(this, 2);
				case (2451)30:
					return new 2419(this, 2);
				case (2451)31:
					return new 2420(this, 2);
				case (2451)32:
					return new 2423(this, 2);
				case (2451)33:
					return new 2418(this, 2);
				case (2451)34:
					return new 2403(this, 2);
				case (2451)35:
					return new 2413(this, 2);
				}
				break;
			}
		}
		throw new NotImplementedException();
	}

	// Token: 0x020005D8 RID: 1496
	public sealed class 2446
	{
		// Token: 0x06002E23 RID: 11811 RVA: 0x001062E3 File Offset: 0x001044E3
		internal 2446(2647 1, 1445 2, int 3)
		{
			this.1 = 1;
			this.2 = 2;
			this.3 = 3;
		}

		// Token: 0x040021CD RID: 8653
		internal 2647 1;

		// Token: 0x040021CE RID: 8654
		internal 1445 2;

		// Token: 0x040021CF RID: 8655
		internal int 3;
	}
}
