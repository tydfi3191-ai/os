using System;
using System.Collections;
using System.Collections.Generic;

// Token: 0x02000119 RID: 281
public sealed class 388 : 679, IEnumerable<375>, IEnumerable
{
	// Token: 0x06000A3E RID: 2622 RVA: 0x000271F0 File Offset: 0x000253F0
	public void Method2239(string 1, 679 2)
	{
		List<375> list = this.list2;
		375 3 = new 375();
		3.SetRecoveredType21551339_1961(new 741(1, false));
		3.SetRecoveredType18311340_1963(2);
		list.Add(3);
		2.SetRecoveredType18318041_10256(this);
	}

	// Token: 0x06000A3F RID: 2623 RVA: 0x000193B1 File Offset: 0x000175B1
	public override 550 GetRegex_12135()
	{
		return 550.Object;
	}

	// Token: 0x06000A40 RID: 2624 RVA: 0x0002722A File Offset: 0x0002542A
	public IEnumerator<375> GetEnumerator()
	{
		return this.list2.GetEnumerator();
	}

	// Token: 0x06000A41 RID: 2625 RVA: 0x0002723C File Offset: 0x0002543C
	private IEnumerator Method2241()
	{
		return this.GetEnumerator();
	}

	// Token: 0x06000A42 RID: 2626 RVA: 0x00027244 File Offset: 0x00025444
	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.Method2241();
	}

	// Token: 0x04000516 RID: 1302
	private readonly List<375> list2 = new List<375>();
}
