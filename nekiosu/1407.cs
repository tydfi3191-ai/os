using System;
using OpenTK.Graphics.ES20;

// Token: 0x02000AA9 RID: 2729
public sealed class 1407<TItem> : 1508<TItem> where TItem : struct, IEquatable<!0>
{
	// Token: 0x06004BCA RID: 19402 RVA: 0x001DFA65 File Offset: 0x001DDC65
	public 1407(int 1, int 2, BeginMode 3) : base(1, 2)
	{
		this.9 = 3;
	}

	// Token: 0x06004BCB RID: 19403 RVA: 0x001DFA76 File Offset: 0x001DDC76
	protected override 1509<TItem> CreateBuffer()
	{
		return new 1392<TItem>(base.1(), this.9, 35048);
	}

	// Token: 0x04003868 RID: 14440
	private BeginMode 9;
}
