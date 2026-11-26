using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

// Token: 0x020001A2 RID: 418
[242(1)]
[241(0)]
public sealed class 699<[241(2)] TItem> : ICollection<!0>, IEnumerable<!0>, IEnumerable, 450, IList, ICollection
{
	// Token: 0x170000B9 RID: 185
	// (get) Token: 0x06000D91 RID: 3473 RVA: 0x0002EF79 File Offset: 0x0002D179
	public int Count
	{
		get
		{
			if (this._iCollection8357 != null)
			{
				return this._iCollection8357.Count;
			}
			return this._iList8356.Count;
		}
	}

	// Token: 0x170000BA RID: 186
	// (get) Token: 0x06000D92 RID: 3474 RVA: 0x0002EF9A File Offset: 0x0002D19A
	public bool IsReadOnly
	{
		get
		{
			if (this._iCollection8357 != null)
			{
				return this._iCollection8357.IsReadOnly;
			}
			return this._iList8356.IsReadOnly;
		}
	}

	// Token: 0x06000D93 RID: 3475 RVA: 0x0002EFBB File Offset: 0x0002D1BB
	private object Method10734(int 1)
	{
		if (this._iCollection8357 != null)
		{
			throw new InvalidOperationException("Wrapped ICollection<T> does not support indexer.");
		}
		return this._iList8356[1];
	}

	// Token: 0x06000D94 RID: 3476 RVA: 0x0002EFDC File Offset: 0x0002D1DC
	private void Method10735(int 1, object 2)
	{
		if (this._iCollection8357 != null)
		{
			throw new InvalidOperationException("Wrapped ICollection<T> does not support indexer.");
		}
		699<TItem>.Method10747(2);
		this._iList8356[1] = (TItem)((object)2);
	}

	// Token: 0x170000BB RID: 187
	object IList.this[int 1]
	{
		get
		{
			return this.Method10734(1);
		}
		set
		{
			this.Method10735(1, value);
		}
	}

	// Token: 0x06000D97 RID: 3479 RVA: 0x0002F024 File Offset: 0x0002D224
	public 699(IList 1)
	{
		756.Method12216(1, "list");
		ICollection<TItem> collection = 1 as ICollection<TItem>;
		if (collection != null)
		{
			this._iCollection8357 = collection;
			return;
		}
		this._iList8356 = 1;
	}

	// Token: 0x06000D98 RID: 3480 RVA: 0x0002F05B File Offset: 0x0002D25B
	public 699(ICollection<TItem> 1)
	{
		756.Method12216(1, "list");
		this._iCollection8357 = 1;
	}

	// Token: 0x06000D99 RID: 3481 RVA: 0x0002F075 File Offset: 0x0002D275
	public void Add(TItem 1)
	{
		if (this._iCollection8357 != null)
		{
			this._iCollection8357.Add(1);
			return;
		}
		this._iList8356.Add(1);
	}

	// Token: 0x06000D9A RID: 3482 RVA: 0x0002F09E File Offset: 0x0002D29E
	public void Clear()
	{
		if (this._iCollection8357 != null)
		{
			this._iCollection8357.Clear();
			return;
		}
		this._iList8356.Clear();
	}

	// Token: 0x06000D9B RID: 3483 RVA: 0x0002F0BF File Offset: 0x0002D2BF
	public bool Contains(TItem 1)
	{
		if (this._iCollection8357 != null)
		{
			return this._iCollection8357.Contains(1);
		}
		return this._iList8356.Contains(1);
	}

	// Token: 0x06000D9C RID: 3484 RVA: 0x0002F0E7 File Offset: 0x0002D2E7
	public void CopyTo(TItem[] 1, int 2)
	{
		if (this._iCollection8357 != null)
		{
			this._iCollection8357.CopyTo(1, 2);
			return;
		}
		this._iList8356.CopyTo(1, 2);
	}

	// Token: 0x06000D9D RID: 3485 RVA: 0x0002F10C File Offset: 0x0002D30C
	public bool Remove(TItem 1)
	{
		if (this._iCollection8357 != null)
		{
			return this._iCollection8357.Remove(1);
		}
		bool flag = this._iList8356.Contains(1);
		if (flag)
		{
			this._iList8356.Remove(1);
		}
		return flag;
	}

	// Token: 0x06000D9E RID: 3486 RVA: 0x0002F148 File Offset: 0x0002D348
	public IEnumerator<TItem> GetEnumerator()
	{
		IEnumerable<TItem> iCollection = this._iCollection8357;
		return (iCollection ?? this._iList8356.Cast<TItem>()).GetEnumerator();
	}

	// Token: 0x06000D9F RID: 3487 RVA: 0x0002F174 File Offset: 0x0002D374
	private IEnumerator Method10736()
	{
		IEnumerable iCollection = this._iCollection8357;
		return (iCollection ?? this._iList8356).GetEnumerator();
	}

	// Token: 0x06000DA0 RID: 3488 RVA: 0x0002F198 File Offset: 0x0002D398
	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.Method10736();
	}

	// Token: 0x06000DA1 RID: 3489 RVA: 0x0002F1A0 File Offset: 0x0002D3A0
	[242(2)]
	private int Method10737(object 1)
	{
		699<TItem>.Method10747(1);
		this.Add((TItem)((object)1));
		return this.Count - 1;
	}

	// Token: 0x06000DA2 RID: 3490 RVA: 0x0002F1BC File Offset: 0x0002D3BC
	int IList.Add(object 1)
	{
		return this.Method10737(1);
	}

	// Token: 0x06000DA3 RID: 3491 RVA: 0x0002F1C5 File Offset: 0x0002D3C5
	[242(2)]
	private bool Method10738(object 1)
	{
		return 699<TItem>.Method10748(1) && this.Contains((TItem)((object)1));
	}

	// Token: 0x06000DA4 RID: 3492 RVA: 0x0002F1DD File Offset: 0x0002D3DD
	bool IList.Contains(object 1)
	{
		return this.Method10738(1);
	}

	// Token: 0x06000DA5 RID: 3493 RVA: 0x0002F1E6 File Offset: 0x0002D3E6
	[242(2)]
	private int Method10739(object 1)
	{
		if (this._iCollection8357 != null)
		{
			throw new InvalidOperationException("Wrapped ICollection<T> does not support IndexOf.");
		}
		if (699<TItem>.Method10748(1))
		{
			return this._iList8356.IndexOf((TItem)((object)1));
		}
		return -1;
	}

	// Token: 0x06000DA6 RID: 3494 RVA: 0x0002F21B File Offset: 0x0002D41B
	int IList.IndexOf(object 1)
	{
		return this.Method10739(1);
	}

	// Token: 0x06000DA7 RID: 3495 RVA: 0x0002F224 File Offset: 0x0002D424
	private void Method10740(int 1)
	{
		if (this._iCollection8357 != null)
		{
			throw new InvalidOperationException("Wrapped ICollection<T> does not support RemoveAt.");
		}
		this._iList8356.RemoveAt(1);
	}

	// Token: 0x06000DA8 RID: 3496 RVA: 0x0002F245 File Offset: 0x0002D445
	void IList.RemoveAt(int 1)
	{
		this.Method10740(1);
	}

	// Token: 0x06000DA9 RID: 3497 RVA: 0x0002F24E File Offset: 0x0002D44E
	[242(2)]
	private void Method10741(int 1, object 2)
	{
		if (this._iCollection8357 != null)
		{
			throw new InvalidOperationException("Wrapped ICollection<T> does not support Insert.");
		}
		699<TItem>.Method10747(2);
		this._iList8356.Insert(1, (TItem)((object)2));
	}

	// Token: 0x06000DAA RID: 3498 RVA: 0x0002F280 File Offset: 0x0002D480
	void IList.Insert(int 1, object 2)
	{
		this.Method10741(1, 2);
	}

	// Token: 0x06000DAB RID: 3499 RVA: 0x0002F28A File Offset: 0x0002D48A
	private bool Method10742()
	{
		if (this._iCollection8357 != null)
		{
			return this._iCollection8357.IsReadOnly;
		}
		return this._iList8356.IsFixedSize;
	}

	// Token: 0x170000BC RID: 188
	// (get) Token: 0x06000DAC RID: 3500 RVA: 0x0002F2AB File Offset: 0x0002D4AB
	bool IList.IsFixedSize
	{
		get
		{
			return this.Method10742();
		}
	}

	// Token: 0x06000DAD RID: 3501 RVA: 0x0002F2B3 File Offset: 0x0002D4B3
	[242(2)]
	private void Method10743(object 1)
	{
		if (699<TItem>.Method10748(1))
		{
			this.Remove((TItem)((object)1));
		}
	}

	// Token: 0x06000DAE RID: 3502 RVA: 0x0002F2CA File Offset: 0x0002D4CA
	void IList.Remove(object 1)
	{
		this.Method10743(1);
	}

	// Token: 0x06000DAF RID: 3503 RVA: 0x0002F2D3 File Offset: 0x0002D4D3
	private void Method10744(Array 1, int 2)
	{
		this.CopyTo((TItem[])1, 2);
	}

	// Token: 0x06000DB0 RID: 3504 RVA: 0x0002F2E2 File Offset: 0x0002D4E2
	void ICollection.CopyTo(Array 1, int 2)
	{
		this.Method10744(1, 2);
	}

	// Token: 0x06000DB1 RID: 3505 RVA: 0x0000FF75 File Offset: 0x0000E175
	private bool Method10745()
	{
		return false;
	}

	// Token: 0x170000BD RID: 189
	// (get) Token: 0x06000DB2 RID: 3506 RVA: 0x0002F2EC File Offset: 0x0002D4EC
	bool ICollection.IsSynchronized
	{
		get
		{
			return this.Method10745();
		}
	}

	// Token: 0x06000DB3 RID: 3507 RVA: 0x0002F2F4 File Offset: 0x0002D4F4
	private object Method10746()
	{
		if (this._value8358 == null)
		{
			Interlocked.CompareExchange(ref this._value8358, new object(), null);
		}
		return this._value8358;
	}

	// Token: 0x170000BE RID: 190
	// (get) Token: 0x06000DB4 RID: 3508 RVA: 0x0002F316 File Offset: 0x0002D516
	object ICollection.SyncRoot
	{
		get
		{
			return this.Method10746();
		}
	}

	// Token: 0x06000DB5 RID: 3509 RVA: 0x0002F31E File Offset: 0x0002D51E
	[242(2)]
	private static void Method10747(object 1)
	{
		if (!699<TItem>.Method10748(1))
		{
			throw new ArgumentException("The value '{0}' is not of type '{1}' and cannot be used in this generic collection.".Method6825(CultureInfo.InvariantCulture, 1, typeof(TItem)), "#=zUkSU2UA=");
		}
	}

	// Token: 0x06000DB6 RID: 3510 RVA: 0x0002F34D File Offset: 0x0002D54D
	[242(2)]
	private static bool Method10748(object 1)
	{
		return 1 is TItem || (1 == null && (!typeof(TItem).Method6714() || 143.IsNullableType(typeof(TItem))));
	}

	// Token: 0x06000DB7 RID: 3511 RVA: 0x0002F37F File Offset: 0x0002D57F
	public object Method10749()
	{
		return this._iCollection8357 ?? this._iList8356;
	}

	// Token: 0x170000BF RID: 191
	// (get) Token: 0x06000DB8 RID: 3512 RVA: 0x0002F391 File Offset: 0x0002D591
	object 450.Value8359
	{
		get
		{
			return this.Method10749();
		}
	}

	// Token: 0x0400067C RID: 1660
	[241(2)]
	private readonly IList _iList8356;

	// Token: 0x0400067D RID: 1661
	[241(new byte[]
	{
		2,
		1
	})]
	private readonly ICollection<TItem> _iCollection8357;

	// Token: 0x0400067E RID: 1662
	[241(2)]
	private object _value8358;
}
