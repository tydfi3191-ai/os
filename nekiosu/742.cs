using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

// Token: 0x020001B2 RID: 434
[241(new byte[]
{
	0,
	1
})]
[242(1)]
public sealed class 742 : Collection<226>
{
	// Token: 0x170000C3 RID: 195
	public 226 this[string 1]
	{
		get
		{
			if (1 == null)
			{
				throw new ArgumentNullException("#=zGDlk81Y=");
			}
			if (this.dictionary3 != null)
			{
				return this.dictionary3[1];
			}
			throw new KeyNotFoundException();
		}
	}

	// Token: 0x06000DEC RID: 3564 RVA: 0x0002FAB4 File Offset: 0x0002DCB4
	public 742() : base(new List<226>())
	{
	}

	// Token: 0x06000DED RID: 3565 RVA: 0x0002FAC1 File Offset: 0x0002DCC1
	private void Method11913(string 1, 226 2)
	{
		this.Method11917();
		this.dictionary3[1] = 2;
	}

	// Token: 0x06000DEE RID: 3566 RVA: 0x0002FAD8 File Offset: 0x0002DCD8
	protected void Method11914(226 1, string 2)
	{
		if (!this.Method11916(1))
		{
			throw new ArgumentException("The specified item does not exist in this KeyedCollection.");
		}
		string text = this.Method11918(1);
		if (!742.iEqualityComparer.Equals(text, 2))
		{
			if (2 != null)
			{
				this.Method11913(2, 1);
			}
			if (text != null)
			{
				this.Method11920(text);
			}
		}
	}

	// Token: 0x06000DEF RID: 3567 RVA: 0x0002FB24 File Offset: 0x0002DD24
	protected override void ClearItems()
	{
		base.ClearItems();
		Dictionary<string, 226> dictionary = this.dictionary3;
		if (dictionary == null)
		{
			return;
		}
		dictionary.Clear();
	}

	// Token: 0x06000DF0 RID: 3568 RVA: 0x0002FB3C File Offset: 0x0002DD3C
	public bool Method11915(string 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=zGDlk81Y=");
		}
		return this.dictionary3 != null && this.dictionary3.ContainsKey(1);
	}

	// Token: 0x06000DF1 RID: 3569 RVA: 0x0002FB64 File Offset: 0x0002DD64
	private bool Method11916(226 1)
	{
		if (this.dictionary3 == null)
		{
			return false;
		}
		string key = this.Method11918(1);
		226 2;
		return this.dictionary3.TryGetValue(key, out 2);
	}

	// Token: 0x06000DF2 RID: 3570 RVA: 0x0002FB91 File Offset: 0x0002DD91
	private void Method11917()
	{
		if (this.dictionary3 == null)
		{
			this.dictionary3 = new Dictionary<string, 226>(742.iEqualityComparer);
		}
	}

	// Token: 0x06000DF3 RID: 3571 RVA: 0x0002FBAB File Offset: 0x0002DDAB
	private string Method11918(226 1)
	{
		return ((222)1).Name;
	}

	// Token: 0x06000DF4 RID: 3572 RVA: 0x0002FBB8 File Offset: 0x0002DDB8
	protected override void InsertItem(int 1, 226 2)
	{
		this.Method11913(this.Method11918(2), 2);
		base.InsertItem(1, 2);
	}

	// Token: 0x06000DF5 RID: 3573 RVA: 0x0002FBD0 File Offset: 0x0002DDD0
	public bool Method11919(string 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=zGDlk81Y=");
		}
		226 item;
		return this.dictionary3 != null && this.dictionary3.TryGetValue(1, out item) && base.Remove(item);
	}

	// Token: 0x06000DF6 RID: 3574 RVA: 0x0002FC10 File Offset: 0x0002DE10
	protected override void RemoveItem(int 1)
	{
		string 2 = this.Method11918(base.Items[1]);
		this.Method11920(2);
		base.RemoveItem(1);
	}

	// Token: 0x06000DF7 RID: 3575 RVA: 0x0002FC3E File Offset: 0x0002DE3E
	private void Method11920(string 1)
	{
		Dictionary<string, 226> dictionary = this.dictionary3;
		if (dictionary == null)
		{
			return;
		}
		dictionary.Remove(1);
	}

	// Token: 0x06000DF8 RID: 3576 RVA: 0x0002FC54 File Offset: 0x0002DE54
	protected override void SetItem(int 1, 226 2)
	{
		string text = this.Method11918(2);
		string text2 = this.Method11918(base.Items[1]);
		if (742.iEqualityComparer.Equals(text2, text))
		{
			if (this.dictionary3 != null)
			{
				this.dictionary3[text] = 2;
			}
		}
		else
		{
			this.Method11913(text, 2);
			if (text2 != null)
			{
				this.Method11920(text2);
			}
		}
		base.SetItem(1, 2);
	}

	// Token: 0x06000DF9 RID: 3577 RVA: 0x0002FCBB File Offset: 0x0002DEBB
	public bool Method11921(string 1, [239(true)] [241(2)] out 226 2)
	{
		if (this.dictionary3 == null)
		{
			2 = null;
			return false;
		}
		return this.dictionary3.TryGetValue(1, out 2);
	}

	// Token: 0x06000DFA RID: 3578 RVA: 0x0002FCD7 File Offset: 0x0002DED7
	public ICollection<string> Method11922()
	{
		this.Method11917();
		return this.dictionary3.Keys;
	}

	// Token: 0x06000DFB RID: 3579 RVA: 0x0002FCEA File Offset: 0x0002DEEA
	public ICollection<226> Method11923()
	{
		this.Method11917();
		return this.dictionary3.Values;
	}

	// Token: 0x06000DFC RID: 3580 RVA: 0x0002FCFD File Offset: 0x0002DEFD
	public int Method11924(226 1)
	{
		return ((List<226>)base.Items).Method3176(1);
	}

	// Token: 0x06000DFD RID: 3581 RVA: 0x0002FD10 File Offset: 0x0002DF10
	public bool Method11925(742 1)
	{
		if (this == 1)
		{
			return true;
		}
		Dictionary<string, 226> dictionary = this.dictionary3;
		Dictionary<string, 226> dictionary2 = 1.dictionary3;
		if (dictionary == null && dictionary2 == null)
		{
			return true;
		}
		if (dictionary == null)
		{
			return dictionary2.Count == 0;
		}
		if (dictionary2 == null)
		{
			return dictionary.Count == 0;
		}
		if (dictionary.Count != dictionary2.Count)
		{
			return false;
		}
		foreach (KeyValuePair<string, 226> keyValuePair in dictionary)
		{
			226 2;
			if (!dictionary2.TryGetValue(keyValuePair.Key, out 2))
			{
				return false;
			}
			222 3 = (222)keyValuePair.Value;
			222 4 = (222)2;
			if (3.Value == null)
			{
				return 4.Value == null;
			}
			if (!3.Value.Method14356(4.Value))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x040006D5 RID: 1749
	private static readonly IEqualityComparer<string> iEqualityComparer = StringComparer.Ordinal;

	// Token: 0x040006D6 RID: 1750
	[241(new byte[]
	{
		2,
		1,
		1
	})]
	private Dictionary<string, 226> dictionary3;
}
