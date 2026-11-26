using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

// Token: 0x02000196 RID: 406
[242(1)]
[241(0)]
public sealed class 672<[241(2)] TItem, [241(2)] TItem2> : IDictionary<!0, !1>, ICollection<KeyValuePair<!0, !1>>, IEnumerable<KeyValuePair<!0, !1>>, IEnumerable, 424, IDictionary, ICollection
{
	// Token: 0x170000A7 RID: 167
	// (get) Token: 0x06000D3F RID: 3391 RVA: 0x0002E735 File Offset: 0x0002C935
	public ICollection<TItem> Keys
	{
		get
		{
			if (this._iDictionary7878 != null)
			{
				return this._iDictionary7878.Keys.Cast<TItem>().ToList<TItem>();
			}
			return this.GetIDictionary7879_10037().Keys;
		}
	}

	// Token: 0x170000A8 RID: 168
	// (get) Token: 0x06000D40 RID: 3392 RVA: 0x0002E760 File Offset: 0x0002C960
	public ICollection<TItem2> Values
	{
		get
		{
			if (this._iDictionary7878 != null)
			{
				return this._iDictionary7878.Values.Cast<TItem2>().ToList<TItem2>();
			}
			return this.GetIDictionary7879_10037().Values;
		}
	}

	// Token: 0x170000A9 RID: 169
	public TItem2 this[TItem 1]
	{
		get
		{
			if (this._iDictionary7878 != null)
			{
				return (TItem2)((object)this._iDictionary7878[1]);
			}
			return this.GetIDictionary7879_10037()[1];
		}
		set
		{
			if (this._iDictionary7878 != null)
			{
				this._iDictionary7878[1] = value;
				return;
			}
			this.GetIDictionary7879_10037()[1] = value;
		}
	}

	// Token: 0x170000AA RID: 170
	// (get) Token: 0x06000D43 RID: 3395 RVA: 0x0002E7E7 File Offset: 0x0002C9E7
	public int Count
	{
		get
		{
			if (this._iDictionary7878 != null)
			{
				return this._iDictionary7878.Count;
			}
			return this.GetIDictionary7879_10037().Count;
		}
	}

	// Token: 0x170000AB RID: 171
	// (get) Token: 0x06000D44 RID: 3396 RVA: 0x0002E808 File Offset: 0x0002CA08
	public bool IsReadOnly
	{
		get
		{
			if (this._iDictionary7878 != null)
			{
				return this._iDictionary7878.IsReadOnly;
			}
			return this.GetIDictionary7879_10037().IsReadOnly;
		}
	}

	// Token: 0x06000D45 RID: 3397 RVA: 0x0002E829 File Offset: 0x0002CA29
	private object Method10035(object 1)
	{
		if (this._iDictionary7878 != null)
		{
			return this._iDictionary7878[1];
		}
		return this.GetIDictionary7879_10037()[(TItem)((object)1)];
	}

	// Token: 0x06000D46 RID: 3398 RVA: 0x0002E856 File Offset: 0x0002CA56
	private void Method10036(object 1, object 2)
	{
		if (this._iDictionary7878 != null)
		{
			this._iDictionary7878[1] = 2;
			return;
		}
		this.GetIDictionary7879_10037()[(TItem)((object)1)] = (TItem2)((object)2);
	}

	// Token: 0x170000AC RID: 172
	object IDictionary.this[object 1]
	{
		get
		{
			return this.Method10035(1);
		}
		set
		{
			this.Method10036(1, value);
		}
	}

	// Token: 0x06000D49 RID: 3401 RVA: 0x0002E898 File Offset: 0x0002CA98
	public 672(IDictionary 1)
	{
		756.Method12216(1, "dictionary");
		this._iDictionary7878 = 1;
	}

	// Token: 0x06000D4A RID: 3402 RVA: 0x0002E8B2 File Offset: 0x0002CAB2
	public 672(IDictionary<TItem, TItem2> 1)
	{
		756.Method12216(1, "dictionary");
		this._iDictionary7879 = 1;
	}

	// Token: 0x06000D4B RID: 3403 RVA: 0x0002E8CC File Offset: 0x0002CACC
	internal IDictionary<TItem, TItem2> GetIDictionary7879_10037()
	{
		return this._iDictionary7879;
	}

	// Token: 0x06000D4C RID: 3404 RVA: 0x0002E8D4 File Offset: 0x0002CAD4
	public void Add(TItem 1, TItem2 2)
	{
		if (this._iDictionary7878 != null)
		{
			this._iDictionary7878.Add(1, 2);
			return;
		}
		if (this._iDictionary7879 != null)
		{
			this._iDictionary7879.Add(1, 2);
			return;
		}
		throw new NotSupportedException();
	}

	// Token: 0x06000D4D RID: 3405 RVA: 0x0002E911 File Offset: 0x0002CB11
	public bool ContainsKey(TItem 1)
	{
		if (this._iDictionary7878 != null)
		{
			return this._iDictionary7878.Contains(1);
		}
		return this.GetIDictionary7879_10037().ContainsKey(1);
	}

	// Token: 0x06000D4E RID: 3406 RVA: 0x0002E939 File Offset: 0x0002CB39
	public bool Remove(TItem 1)
	{
		if (this._iDictionary7878 == null)
		{
			return this.GetIDictionary7879_10037().Remove(1);
		}
		if (this._iDictionary7878.Contains(1))
		{
			this._iDictionary7878.Remove(1);
			return true;
		}
		return false;
	}

	// Token: 0x06000D4F RID: 3407 RVA: 0x0002E978 File Offset: 0x0002CB78
	public bool TryGetValue(TItem 1, [241(2)] out TItem2 2)
	{
		if (this._iDictionary7878 == null)
		{
			return this.GetIDictionary7879_10037().TryGetValue(1, out 2);
		}
		if (!this._iDictionary7878.Contains(1))
		{
			2 = default(TItem2);
			return false;
		}
		2 = (TItem2)((object)this._iDictionary7878[1]);
		return true;
	}

	// Token: 0x06000D50 RID: 3408 RVA: 0x0002E9D4 File Offset: 0x0002CBD4
	public void Add([241(new byte[]
	{
		0,
		1,
		1
	})] KeyValuePair<TItem, TItem2> 1)
	{
		if (this._iDictionary7878 != null)
		{
			((IList)this._iDictionary7878).Add(1);
			return;
		}
		IDictionary<TItem, TItem2> iDictionary = this._iDictionary7879;
		if (iDictionary == null)
		{
			return;
		}
		iDictionary.Add(1);
	}

	// Token: 0x06000D51 RID: 3409 RVA: 0x0002EA07 File Offset: 0x0002CC07
	public void Clear()
	{
		if (this._iDictionary7878 != null)
		{
			this._iDictionary7878.Clear();
			return;
		}
		this.GetIDictionary7879_10037().Clear();
	}

	// Token: 0x06000D52 RID: 3410 RVA: 0x0002EA28 File Offset: 0x0002CC28
	public bool Contains([241(new byte[]
	{
		0,
		1,
		1
	})] KeyValuePair<TItem, TItem2> 1)
	{
		if (this._iDictionary7878 != null)
		{
			return ((IList)this._iDictionary7878).Contains(1);
		}
		return this.GetIDictionary7879_10037().Contains(1);
	}

	// Token: 0x06000D53 RID: 3411 RVA: 0x0002EA58 File Offset: 0x0002CC58
	public void CopyTo([241(new byte[]
	{
		1,
		0,
		1,
		1
	})] KeyValuePair<TItem, TItem2>[] 1, int 2)
	{
		if (this._iDictionary7878 != null)
		{
			foreach (object obj in this._iDictionary7878)
			{
				DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
				1[2++] = new KeyValuePair<TItem, TItem2>((TItem)((object)dictionaryEntry.Key), (TItem2)((object)dictionaryEntry.Value));
			}
			return;
		}
		this.GetIDictionary7879_10037().CopyTo(1, 2);
	}

	// Token: 0x06000D54 RID: 3412 RVA: 0x0002EAEC File Offset: 0x0002CCEC
	public bool Remove([241(new byte[]
	{
		0,
		1,
		1
	})] KeyValuePair<TItem, TItem2> 1)
	{
		if (this._iDictionary7878 == null)
		{
			return this.GetIDictionary7879_10037().Remove(1);
		}
		if (!this._iDictionary7878.Contains(1.Key))
		{
			return true;
		}
		if (object.Equals(this._iDictionary7878[1.Key], 1.Value))
		{
			this._iDictionary7878.Remove(1.Key);
			return true;
		}
		return false;
	}

	// Token: 0x06000D55 RID: 3413 RVA: 0x0002EB6D File Offset: 0x0002CD6D
	[return: 241(new byte[]
	{
		1,
		0,
		1,
		1
	})]
	public IEnumerator<KeyValuePair<TItem, TItem2>> GetEnumerator()
	{
		if (this._iDictionary7878 != null)
		{
			return this._iDictionary7878.Cast<DictionaryEntry>().Select(new Func<DictionaryEntry, KeyValuePair<TItem, TItem2>>(672<TItem, TItem2>.673._recoveredType18037875.Method10034)).GetEnumerator();
		}
		return this.GetIDictionary7879_10037().GetEnumerator();
	}

	// Token: 0x06000D56 RID: 3414 RVA: 0x0002EBA8 File Offset: 0x0002CDA8
	private IEnumerator Method10038()
	{
		return this.GetEnumerator();
	}

	// Token: 0x06000D57 RID: 3415 RVA: 0x0002EBB0 File Offset: 0x0002CDB0
	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.Method10038();
	}

	// Token: 0x06000D58 RID: 3416 RVA: 0x0002EBB8 File Offset: 0x0002CDB8
	private void Method10039(object 1, [241(2)] object 2)
	{
		if (this._iDictionary7878 != null)
		{
			this._iDictionary7878.Add(1, 2);
			return;
		}
		this.GetIDictionary7879_10037().Add((TItem)((object)1), (TItem2)((object)2));
	}

	// Token: 0x06000D59 RID: 3417 RVA: 0x0002EBE7 File Offset: 0x0002CDE7
	void IDictionary.Add(object 1, [241(2)] object 2)
	{
		this.Method10039(1, 2);
	}

	// Token: 0x06000D5A RID: 3418 RVA: 0x0002EBF1 File Offset: 0x0002CDF1
	private IDictionaryEnumerator Method10040()
	{
		if (this._iDictionary7878 != null)
		{
			return this._iDictionary7878.GetEnumerator();
		}
		return new 672<TItem, TItem2>.674<TItem, TItem2>(this.GetIDictionary7879_10037().GetEnumerator());
	}

	// Token: 0x06000D5B RID: 3419 RVA: 0x0002EC1C File Offset: 0x0002CE1C
	IDictionaryEnumerator IDictionary.GetEnumerator()
	{
		return this.Method10040();
	}

	// Token: 0x06000D5C RID: 3420 RVA: 0x0002EC24 File Offset: 0x0002CE24
	private bool Method10041(object 1)
	{
		if (this._iDictionary7879 != null)
		{
			return this._iDictionary7879.ContainsKey((TItem)((object)1));
		}
		return this._iDictionary7878.Contains(1);
	}

	// Token: 0x06000D5D RID: 3421 RVA: 0x0002EC4C File Offset: 0x0002CE4C
	bool IDictionary.Contains(object 1)
	{
		return this.Method10041(1);
	}

	// Token: 0x06000D5E RID: 3422 RVA: 0x0002EC55 File Offset: 0x0002CE55
	private bool Method10042()
	{
		return this._iDictionary7879 == null && this._iDictionary7878.IsFixedSize;
	}

	// Token: 0x170000AD RID: 173
	// (get) Token: 0x06000D5F RID: 3423 RVA: 0x0002EC6C File Offset: 0x0002CE6C
	bool IDictionary.IsFixedSize
	{
		get
		{
			return this.Method10042();
		}
	}

	// Token: 0x06000D60 RID: 3424 RVA: 0x0002EC74 File Offset: 0x0002CE74
	private ICollection Method10043()
	{
		if (this._iDictionary7879 != null)
		{
			return this._iDictionary7879.Keys.ToList<TItem>();
		}
		return this._iDictionary7878.Keys;
	}

	// Token: 0x170000AE RID: 174
	// (get) Token: 0x06000D61 RID: 3425 RVA: 0x0002EC9A File Offset: 0x0002CE9A
	ICollection IDictionary.Keys
	{
		get
		{
			return this.Method10043();
		}
	}

	// Token: 0x06000D62 RID: 3426 RVA: 0x0002ECA2 File Offset: 0x0002CEA2
	public void Remove(object 1)
	{
		if (this._iDictionary7878 != null)
		{
			this._iDictionary7878.Remove(1);
			return;
		}
		this.GetIDictionary7879_10037().Remove((TItem)((object)1));
	}

	// Token: 0x06000D63 RID: 3427 RVA: 0x0002ECCB File Offset: 0x0002CECB
	private ICollection Method10044()
	{
		if (this._iDictionary7879 != null)
		{
			return this._iDictionary7879.Values.ToList<TItem2>();
		}
		return this._iDictionary7878.Values;
	}

	// Token: 0x170000AF RID: 175
	// (get) Token: 0x06000D64 RID: 3428 RVA: 0x0002ECF1 File Offset: 0x0002CEF1
	ICollection IDictionary.Values
	{
		get
		{
			return this.Method10044();
		}
	}

	// Token: 0x06000D65 RID: 3429 RVA: 0x0002ECF9 File Offset: 0x0002CEF9
	private void Method10045(Array 1, int 2)
	{
		if (this._iDictionary7878 != null)
		{
			this._iDictionary7878.CopyTo(1, 2);
			return;
		}
		this.GetIDictionary7879_10037().CopyTo((KeyValuePair<TItem, TItem2>[])1, 2);
	}

	// Token: 0x06000D66 RID: 3430 RVA: 0x0002ED23 File Offset: 0x0002CF23
	void ICollection.CopyTo(Array 1, int 2)
	{
		this.Method10045(1, 2);
	}

	// Token: 0x06000D67 RID: 3431 RVA: 0x0002ED2D File Offset: 0x0002CF2D
	private bool Method10046()
	{
		return this._iDictionary7878 != null && this._iDictionary7878.IsSynchronized;
	}

	// Token: 0x170000B0 RID: 176
	// (get) Token: 0x06000D68 RID: 3432 RVA: 0x0002ED44 File Offset: 0x0002CF44
	bool ICollection.IsSynchronized
	{
		get
		{
			return this.Method10046();
		}
	}

	// Token: 0x06000D69 RID: 3433 RVA: 0x0002ED4C File Offset: 0x0002CF4C
	private object Method10047()
	{
		if (this._value7880 == null)
		{
			Interlocked.CompareExchange(ref this._value7880, new object(), null);
		}
		return this._value7880;
	}

	// Token: 0x170000B1 RID: 177
	// (get) Token: 0x06000D6A RID: 3434 RVA: 0x0002ED6E File Offset: 0x0002CF6E
	object ICollection.SyncRoot
	{
		get
		{
			return this.Method10047();
		}
	}

	// Token: 0x06000D6B RID: 3435 RVA: 0x0002ED76 File Offset: 0x0002CF76
	public object Method10048()
	{
		if (this._iDictionary7878 != null)
		{
			return this._iDictionary7878;
		}
		return this.GetIDictionary7879_10037();
	}

	// Token: 0x170000B2 RID: 178
	// (get) Token: 0x06000D6C RID: 3436 RVA: 0x0002ED8D File Offset: 0x0002CF8D
	object 424.Value7881
	{
		get
		{
			return this.Method10048();
		}
	}

	// Token: 0x04000667 RID: 1639
	[241(2)]
	private readonly IDictionary _iDictionary7878;

	// Token: 0x04000668 RID: 1640
	[241(new byte[]
	{
		2,
		1,
		1
	})]
	private readonly IDictionary<TItem, TItem2> _iDictionary7879;

	// Token: 0x04000669 RID: 1641
	[241(2)]
	private object _value7880;

	// Token: 0x02000197 RID: 407
	[Serializable]
	public sealed class 673
	{
		// Token: 0x06000D6D RID: 3437 RVA: 0x0002ED95 File Offset: 0x0002CF95
		[242(0)]
		internal KeyValuePair<TItem, TItem2> Method10034(DictionaryEntry 1)
		{
			return new KeyValuePair<TItem, TItem2>((TItem)((object)1.Key), (TItem2)((object)1.Value));
		}

		// Token: 0x0400066A RID: 1642
		[241(0)]
		public static readonly 672<TItem, TItem2>.673 _recoveredType18037875 = new 672<TItem, TItem2>.673();

		// Token: 0x0400066B RID: 1643
		[241(0)]
		public static Func<DictionaryEntry, KeyValuePair<TItem, TItem2>> _func7876;
	}

	// Token: 0x02000198 RID: 408
	[241(0)]
	[107]
	public struct 674<[241(2)] TItem, [241(2)] TItem2> : IDictionaryEnumerator, IEnumerator
	{
		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000D70 RID: 3440 RVA: 0x0002EDC0 File Offset: 0x0002CFC0
		public DictionaryEntry Entry
		{
			get
			{
				return (DictionaryEntry)this.Current;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000D71 RID: 3441 RVA: 0x0002EDD0 File Offset: 0x0002CFD0
		public object Key
		{
			get
			{
				return this.Entry.Key;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000D72 RID: 3442 RVA: 0x0002EDEC File Offset: 0x0002CFEC
		[241(2)]
		public object Value
		{
			[242(2)]
			get
			{
				return this.Entry.Value;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000D73 RID: 3443 RVA: 0x0002EE08 File Offset: 0x0002D008
		public object Current
		{
			get
			{
				KeyValuePair<TItem, TItem2> keyValuePair = this._iEnumerator7877.Current;
				object key = keyValuePair.Key;
				keyValuePair = this._iEnumerator7877.Current;
				return new DictionaryEntry(key, keyValuePair.Value);
			}
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x0002EE4F File Offset: 0x0002D04F
		public 674([241(new byte[]
		{
			1,
			0,
			1,
			1
		})] IEnumerator<KeyValuePair<TItem, TItem2>> 1)
		{
			756.Method12216(1, "e");
			this._iEnumerator7877 = 1;
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x0002EE63 File Offset: 0x0002D063
		public bool MoveNext()
		{
			return this._iEnumerator7877.MoveNext();
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x0002EE70 File Offset: 0x0002D070
		public void Reset()
		{
			this._iEnumerator7877.Reset();
		}

		// Token: 0x0400066C RID: 1644
		[241(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		private readonly IEnumerator<KeyValuePair<TItem, TItem2>> _iEnumerator7877;
	}
}
