using System;

// Token: 0x02000A8D RID: 2701
public sealed class 1375<TItem> : 1508<TItem> where TItem : struct, IEquatable<!0>
{
	// Token: 0x06004AE6 RID: 19174 RVA: 0x001DAF80 File Offset: 0x001D9180
	public 1375(int 1, int 2) : base(1, 2)
	{
	}

	// Token: 0x06004AE7 RID: 19175 RVA: 0x001DAF8A File Offset: 0x001D918A
	protected override 1509<TItem> CreateBuffer()
	{
		return new 1411<TItem>(base.1(), 35048);
	}
}
