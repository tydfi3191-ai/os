using System;
using System.Collections.Generic;
using System.Globalization;

// Token: 0x020001CB RID: 459
[241(0)]
[242(1)]
public sealed class 805<TItem, TItem2>
{
	// Token: 0x06000E94 RID: 3732 RVA: 0x00031207 File Offset: 0x0002F407
	public 805() : this(EqualityComparer<TItem>.Default, EqualityComparer<TItem2>.Default)
	{
	}

	// Token: 0x06000E95 RID: 3733 RVA: 0x00031219 File Offset: 0x0002F419
	public 805(IEqualityComparer<TItem> 1, IEqualityComparer<TItem2> 2) : this(1, 2, "Duplicate item already exists for '{0}'.", "Duplicate item already exists for '{0}'.")
	{
	}

	// Token: 0x06000E96 RID: 3734 RVA: 0x0003122D File Offset: 0x0002F42D
	public 805(IEqualityComparer<TItem> 1, IEqualityComparer<TItem2> 2, string 3, string 4)
	{
		this._iDictionary10428 = new Dictionary<TItem, TItem2>(1);
		this._iDictionary10429 = new Dictionary<TItem2, TItem>(2);
		this._text10430 = 3;
		this._text10431 = 4;
	}

	// Token: 0x06000E97 RID: 3735 RVA: 0x0003125C File Offset: 0x0002F45C
	public void Method13499(TItem 1, TItem2 2)
	{
		TItem2 titem;
		if (this._iDictionary10428.TryGetValue(1, out titem))
		{
			object obj = 2;
			if (!titem.Equals(obj))
			{
				throw new ArgumentException(this._text10430.Method6825(CultureInfo.InvariantCulture, 1));
			}
		}
		TItem titem2;
		if (this._iDictionary10429.TryGetValue(2, out titem2))
		{
			object obj2 = 1;
			if (!titem2.Equals(obj2))
			{
				throw new ArgumentException(this._text10431.Method6825(CultureInfo.InvariantCulture, 2));
			}
		}
		this._iDictionary10428.Add(1, 2);
		this._iDictionary10429.Add(2, 1);
	}

	// Token: 0x06000E98 RID: 3736 RVA: 0x00031309 File Offset: 0x0002F509
	public bool Method13500(TItem 1, [241(2)] [239(true)] out TItem2 2)
	{
		return this._iDictionary10428.TryGetValue(1, out 2);
	}

	// Token: 0x06000E99 RID: 3737 RVA: 0x00031318 File Offset: 0x0002F518
	public bool Method13501(TItem2 1, [241(2)] [239(true)] out TItem 2)
	{
		return this._iDictionary10429.TryGetValue(1, out 2);
	}

	// Token: 0x0400071D RID: 1821
	private readonly IDictionary<TItem, TItem2> _iDictionary10428;

	// Token: 0x0400071E RID: 1822
	private readonly IDictionary<TItem2, TItem> _iDictionary10429;

	// Token: 0x0400071F RID: 1823
	private readonly string _text10430;

	// Token: 0x04000720 RID: 1824
	private readonly string _text10431;
}
