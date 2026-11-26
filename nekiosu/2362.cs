using System;
using System.Collections.Generic;

// Token: 0x020005C7 RID: 1479
public sealed class 2362 : 2255
{
	// Token: 0x06002DBD RID: 11709 RVA: 0x000EFC3F File Offset: 0x000EDE3F
	public 2362(2263 1) : base(1)
	{
	}

	// Token: 0x06002DBE RID: 11710 RVA: 0x001024D4 File Offset: 0x001006D4
	internal override void Update()
	{
		2362.2363 <<EMPTY_NAME>> = new 2362.2363();
		base.Update();
		<<EMPTY_NAME>>.1 = new List<2072>();
		<<EMPTY_NAME>>.2 = new List<2063>();
		this.3.65.28.ForEach(new Action<1371>(<<EMPTY_NAME>>.1));
		foreach (2072 2 in <<EMPTY_NAME>>.1)
		{
			if (2.HasWhistle() || 2.HasClap())
			{
				2.SetComboColour(new 198(67, 142, 172));
			}
			else
			{
				2.SetComboColour(new 198(235, 69, 44));
			}
		}
		foreach (2063 3 in <<EMPTY_NAME>>.2)
		{
			3.SetComboColour(new 198(252, 184, 6));
		}
	}

	// Token: 0x06002DBF RID: 11711 RVA: 0x00100553 File Offset: 0x000FE753
	protected override float MeasureDistance(208 1, 208 2)
	{
		return 0f;
	}

	// Token: 0x020005C8 RID: 1480
	public sealed class 2363
	{
		// Token: 0x06002DC0 RID: 11712 RVA: 0x001025F0 File Offset: 0x001007F0
		internal void 1(1371 1)
		{
			2072 2 = 1.8 as 2072;
			if (2 != null)
			{
				this.1.Add(2);
				return;
			}
			2063 3 = 1.8 as 2063;
			if (3 != null)
			{
				this.2.Add(3);
			}
		}

		// Token: 0x04002194 RID: 8596
		public List<2072> 1;

		// Token: 0x04002195 RID: 8597
		public List<2063> 2;
	}
}
