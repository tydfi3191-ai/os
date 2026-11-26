using System;
using System.Collections.Generic;

// Token: 0x0200012A RID: 298
[241(0)]
[242(1)]
public sealed class 433 : 781
{
	// Token: 0x06000A9D RID: 2717 RVA: 0x000288E2 File Offset: 0x00026AE2
	public 433(696 1) : base(1)
	{
		this.SetList2844_3598(new List<781>());
	}

	// Token: 0x06000A9E RID: 2718 RVA: 0x000288F6 File Offset: 0x00026AF6
	public List<781> GetList2844_3597()
	{
		return this.list2;
	}

	// Token: 0x06000A9F RID: 2719 RVA: 0x000288FE File Offset: 0x00026AFE
	public void SetList2844_3598(List<781> 1)
	{
		this.list2 = 1;
	}

	// Token: 0x06000AA0 RID: 2720 RVA: 0x00028908 File Offset: 0x00026B08
	public override bool Method12763(226 1, 226 2, [241(2)] 541 3)
	{
		696 recoveredType = this._recoveredType19089989;
		if (recoveredType == (696)8)
		{
			using (List<781>.Enumerator enumerator = this.GetList2844_3597().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!enumerator.Current.Method12763(1, 2, 3))
					{
						return false;
					}
				}
			}
			return true;
		}
		if (recoveredType != (696)9)
		{
			throw new ArgumentOutOfRangeException();
		}
		using (List<781>.Enumerator enumerator = this.GetList2844_3597().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Method12763(1, 2, 3))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0400053E RID: 1342
	private List<781> list2;
}
