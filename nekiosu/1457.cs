using System;
using System.Collections.Generic;

// Token: 0x02000AE0 RID: 2784
public class 1457
{
	// Token: 0x06004DA1 RID: 19873 RVA: 0x001EC25C File Offset: 0x001EA45C
	internal 1457(int 1, int 2)
	{
		this.1 = 2;
		this.2 = 1;
	}

	// Token: 0x06004DA2 RID: 19874 RVA: 0x001EC284 File Offset: 0x001EA484
	internal 1457 Clone()
	{
		1457 <<EMPTY_NAME>> = new 1457(this.2, this.1);
		foreach (1445 2 in this.3)
		{
			<<EMPTY_NAME>>.3.Add(2.Clone());
		}
		return <<EMPTY_NAME>>;
	}

	// Token: 0x06004DA3 RID: 19875 RVA: 0x001EC2F4 File Offset: 0x001EA4F4
	internal virtual List<1445> GenerateTransformations()
	{
		if (this.3.Count == 0)
		{
			return null;
		}
		List<1445> list = new List<1445>();
		int num = -1;
		int num2 = -1;
		for (int i = 0; i < this.3.Count; i++)
		{
			if (this.3[i].9 < num2 || num2 == -1)
			{
				num2 = this.3[i].9;
			}
			if (this.3[i].10 > num || num == -1)
			{
				num = this.3[i].10;
			}
		}
		int num3 = num - num2;
		for (int j = 0; j < this.3.Count; j++)
		{
			1445 <<EMPTY_NAME>> = this.3[j].Clone();
			<<EMPTY_NAME>>.18 = true;
			if (this.1 > 1)
			{
				<<EMPTY_NAME>>.17 = true;
				<<EMPTY_NAME>>.11 = num3 - (<<EMPTY_NAME>>.10 - <<EMPTY_NAME>>.9);
				<<EMPTY_NAME>>.12 = this.1;
			}
			<<EMPTY_NAME>>.9 += this.2;
			<<EMPTY_NAME>>.10 += this.2;
			list.Add(<<EMPTY_NAME>>);
		}
		return list;
	}

	// Token: 0x040039E3 RID: 14819
	internal int 1 = 1;

	// Token: 0x040039E4 RID: 14820
	internal int 2;

	// Token: 0x040039E5 RID: 14821
	internal List<1445> 3 = new List<1445>();
}
