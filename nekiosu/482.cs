using System;
using System.Collections.Concurrent;

// Token: 0x02000147 RID: 327
[241(0)]
[242(1)]
public sealed class 482<TItem, [241(2)] TItem2>
{
	// Token: 0x06000B41 RID: 2881 RVA: 0x0002A243 File Offset: 0x00028443
	public 482(Func<TItem, TItem2> 1)
	{
		756.Method12216(1, "creator");
		this._func3694 = 1;
		this._concurrentDictionary3693 = new ConcurrentDictionary<TItem, TItem2>();
	}

	// Token: 0x06000B42 RID: 2882 RVA: 0x0002A268 File Offset: 0x00028468
	public TItem2 Method4701(TItem 1)
	{
		return this._concurrentDictionary3693.GetOrAdd(1, this._func3694);
	}

	// Token: 0x0400058D RID: 1421
	private readonly ConcurrentDictionary<TItem, TItem2> _concurrentDictionary3693;

	// Token: 0x0400058E RID: 1422
	private readonly Func<TItem, TItem2> _func3694;
}
