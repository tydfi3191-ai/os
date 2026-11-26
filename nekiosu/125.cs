using System;
using System.Collections;
using System.Collections.Generic;

// Token: 0x020000AB RID: 171
public sealed class 125 : 679, IEnumerable<679>, IEnumerable
{
	// Token: 0x06000443 RID: 1091 RVA: 0x0000D004 File Offset: 0x0000B204
	public void AddToken(679 1)
	{
		this.list.Add(1);
		1.SetRecoveredType18318041_10256(this);
	}

	// Token: 0x06000444 RID: 1092 RVA: 0x0000D019 File Offset: 0x0000B219
	public override 550 GetRegex_12135()
	{
		return 550.Array;
	}

	// Token: 0x06000445 RID: 1093 RVA: 0x0000D01C File Offset: 0x0000B21C
	public IEnumerator<679> GetEnumerator()
	{
		return this.list.GetEnumerator();
	}

	// Token: 0x06000446 RID: 1094 RVA: 0x0000D02E File Offset: 0x0000B22E
	private IEnumerator Method9497()
	{
		return this.GetEnumerator();
	}

	// Token: 0x06000447 RID: 1095 RVA: 0x0000D036 File Offset: 0x0000B236
	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.Method9497();
	}

	// Token: 0x040003B9 RID: 953
	private readonly List<679> list = new List<679>();
}
