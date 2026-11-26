using System;
using System.Collections.Generic;
using System.Globalization;

// Token: 0x02000116 RID: 278
[242(2)]
[241(0)]
public abstract class 368
{
	// Token: 0x06000A14 RID: 2580
	[242(1)]
	public abstract IEnumerable<226> Method12761(226 1, IEnumerable<226> 2, [241(2)] 541 3);

	// Token: 0x06000A15 RID: 2581 RVA: 0x00026190 File Offset: 0x00024390
	protected static 226 Method1841([241(1)] 226 1, 541 2, int 3)
	{
		109 4 = 1 as 109;
		if (4 != null)
		{
			if (4.Count > 3)
			{
				return 4[3];
			}
			if (2 != null && 2.GetFlag5433_6846())
			{
				throw new 134("Index {0} outside the bounds of JArray.".Method6825(CultureInfo.InvariantCulture, 3));
			}
			return null;
		}
		else
		{
			110 5 = 1 as 110;
			if (5 != null)
			{
				if (5.Count > 3)
				{
					return 5[3];
				}
				if (2 != null && 2.GetFlag5433_6846())
				{
					throw new 134("Index {0} outside the bounds of JConstructor.".Method6825(CultureInfo.InvariantCulture, 3));
				}
				return null;
			}
			else
			{
				if (2 != null && 2.GetFlag5433_6846())
				{
					throw new 134("Index {0} not valid on {1}.".Method6825(CultureInfo.InvariantCulture, 3, 1.GetType().Name));
				}
				return null;
			}
		}
	}

	// Token: 0x06000A16 RID: 2582 RVA: 0x0002625C File Offset: 0x0002445C
	protected static 226 Method1842([241(1)] 226 1, 226 2, 226 3)
	{
		if (2 != null && 2.HasValues)
		{
			3 = 2.First;
		}
		else
		{
			while (3 != null && 3 != 1 && 3 == 3.Parent.Last)
			{
				3 = 3.Parent;
			}
			if (3 == null || 3 == 1)
			{
				return null;
			}
			3 = 3.Next;
		}
		return 3;
	}
}
