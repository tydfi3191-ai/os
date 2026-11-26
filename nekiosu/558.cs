using System;

// Token: 0x0200015E RID: 350
[107]
[241(0)]
[242(1)]
public struct 558<[241(2)] TItem, [241(2)] TItem2> : IEquatable<558<!0, !1>>
{
	// Token: 0x06000C03 RID: 3075 RVA: 0x0002B5FB File Offset: 0x000297FB
	public 558(TItem 1, TItem2 2)
	{
		this._item5821 = 1;
		this._item5822 = 2;
	}

	// Token: 0x06000C04 RID: 3076 RVA: 0x0002B60C File Offset: 0x0002980C
	public override int GetHashCode()
	{
		TItem item = this._item5821;
		int num = (item != null) ? item.GetHashCode() : 0;
		TItem2 item2 = this._item5822;
		return num ^ ((item2 != null) ? item2.GetHashCode() : 0);
	}

	// Token: 0x06000C05 RID: 3077 RVA: 0x0002B658 File Offset: 0x00029858
	[242(2)]
	public override bool Equals(object 1)
	{
		if (1 is 558<TItem, TItem2>)
		{
			558<TItem, TItem2> 2 = (558<TItem, TItem2>)1;
			return this.Equals(2);
		}
		return false;
	}

	// Token: 0x06000C06 RID: 3078 RVA: 0x0002B67F File Offset: 0x0002987F
	public bool Equals([241(new byte[]
	{
		0,
		1,
		1
	})] 558<TItem, TItem2> 1)
	{
		return object.Equals(this._item5821, 1._item5821) && object.Equals(this._item5822, 1._item5822);
	}

	// Token: 0x040005EA RID: 1514
	public readonly TItem _item5821;

	// Token: 0x040005EB RID: 1515
	public readonly TItem2 _item5822;
}
