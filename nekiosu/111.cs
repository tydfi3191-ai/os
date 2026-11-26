using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;

// Token: 0x020000EA RID: 234
[ComVisible(false)]
[241(0)]
[242(1)]
public abstract class 111 : 226, IList<226>, ICollection<226>, IEnumerable<226>, IEnumerable, ITypedList, IBindingList, IList, ICollection, INotifyCollectionChanged
{
	// Token: 0x1700005C RID: 92
	// (get) Token: 0x06000762 RID: 1890
	protected abstract IList<226> ChildrenTokens { get; }

	// Token: 0x1700005D RID: 93
	// (get) Token: 0x06000763 RID: 1891 RVA: 0x0001966F File Offset: 0x0001786F
	public override bool HasValues
	{
		get
		{
			return this.ChildrenTokens.Count > 0;
		}
	}

	// Token: 0x1700005E RID: 94
	// (get) Token: 0x06000764 RID: 1892 RVA: 0x00019680 File Offset: 0x00017880
	[241(2)]
	public override 226 First
	{
		[242(2)]
		get
		{
			IList<226> childrenTokens = this.ChildrenTokens;
			if (childrenTokens.Count <= 0)
			{
				return null;
			}
			return childrenTokens[0];
		}
	}

	// Token: 0x1700005F RID: 95
	// (get) Token: 0x06000765 RID: 1893 RVA: 0x000196A8 File Offset: 0x000178A8
	[241(2)]
	public override 226 Last
	{
		[242(2)]
		get
		{
			IList<226> childrenTokens = this.ChildrenTokens;
			int count = childrenTokens.Count;
			if (count <= 0)
			{
				return null;
			}
			return childrenTokens[count - 1];
		}
	}

	// Token: 0x06000766 RID: 1894 RVA: 0x000190D6 File Offset: 0x000172D6
	private object Method7229(int 1)
	{
		return this.Method14287(1);
	}

	// Token: 0x06000767 RID: 1895 RVA: 0x000196D2 File Offset: 0x000178D2
	private void Method7230(int 1, object 2)
	{
		this.Method14288(1, this.Method7286(2));
	}

	// Token: 0x17000060 RID: 96
	object IList.this[int 1]
	{
		get
		{
			return this.Method7229(1);
		}
		set
		{
			this.Method7230(1, value);
		}
	}

	// Token: 0x17000061 RID: 97
	// (get) Token: 0x0600076A RID: 1898 RVA: 0x000196F5 File Offset: 0x000178F5
	public int Count
	{
		get
		{
			return this.ChildrenTokens.Count;
		}
	}

	// Token: 0x17000062 RID: 98
	// (get) Token: 0x0600076B RID: 1899 RVA: 0x00009D1A File Offset: 0x00007F1A
	[241(2)]
	private PropertyDescriptor PropertyDescriptor5700
	{
		[242(2)]
		get
		{
			return null;
		}
	}

	// Token: 0x14000001 RID: 1
	// (add) Token: 0x0600076C RID: 1900 RVA: 0x00019702 File Offset: 0x00017902
	// (remove) Token: 0x0600076D RID: 1901 RVA: 0x0001971B File Offset: 0x0001791B
	public event ListChangedEventHandler ListChanged
	{
		add
		{
			this.listChangedEventHandler2 = (ListChangedEventHandler)Delegate.Combine(this.listChangedEventHandler2, value);
		}
		remove
		{
			this.listChangedEventHandler2 = (ListChangedEventHandler)Delegate.Remove(this.listChangedEventHandler2, value);
		}
	}

	// Token: 0x14000002 RID: 2
	// (add) Token: 0x0600076E RID: 1902 RVA: 0x00019734 File Offset: 0x00017934
	// (remove) Token: 0x0600076F RID: 1903 RVA: 0x0001974D File Offset: 0x0001794D
	[241(2)]
	public event NotifyCollectionChangedEventHandler CollectionChanged
	{
		[242(2)]
		add
		{
			this.notifyCollectionChangedEventHandler2 = (NotifyCollectionChangedEventHandler)Delegate.Combine(this.notifyCollectionChangedEventHandler2, value);
		}
		[242(2)]
		remove
		{
			this.notifyCollectionChangedEventHandler2 = (NotifyCollectionChangedEventHandler)Delegate.Remove(this.notifyCollectionChangedEventHandler2, value);
		}
	}

	// Token: 0x06000770 RID: 1904 RVA: 0x00019766 File Offset: 0x00017966
	internal 111()
	{
	}

	// Token: 0x06000771 RID: 1905 RVA: 0x00019770 File Offset: 0x00017970
	internal 111(111 1, [241(2)] 479 2) : this()
	{
		756.Method12216(1, "other");
		bool flag = 2 == null || 2.GetFlag3606_4588();
		if (flag)
		{
			base.Method14353(this, 1);
		}
		int num = 0;
		foreach (226 3 in ((IEnumerable<226>)1))
		{
			this.Method7260(num, 3, false, flag);
			num++;
		}
	}

	// Token: 0x06000772 RID: 1906 RVA: 0x000197EC File Offset: 0x000179EC
	public void SetAddingNewEventHandler5696_7231(AddingNewEventHandler 1)
	{
		this.addingNewEventHandler2 = (AddingNewEventHandler)Delegate.Combine(this.addingNewEventHandler2, 1);
	}

	// Token: 0x06000773 RID: 1907 RVA: 0x00019805 File Offset: 0x00017A05
	public void SetAddingNewEventHandler5696_7232(AddingNewEventHandler 1)
	{
		this.addingNewEventHandler2 = (AddingNewEventHandler)Delegate.Remove(this.addingNewEventHandler2, 1);
	}

	// Token: 0x06000774 RID: 1908 RVA: 0x0001981E File Offset: 0x00017A1E
	internal void Method7233()
	{
		if (this.flag3)
		{
			throw new InvalidOperationException("Cannot change {0} during a collection change event.".Method6825(CultureInfo.InvariantCulture, base.GetType()));
		}
	}

	// Token: 0x06000775 RID: 1909 RVA: 0x00019843 File Offset: 0x00017A43
	internal virtual IList<226> Method7234()
	{
		return new List<226>();
	}

	// Token: 0x06000776 RID: 1910 RVA: 0x0001984A File Offset: 0x00017A4A
	protected virtual void Method7235(AddingNewEventArgs 1)
	{
		AddingNewEventHandler addingNewEventHandler = this.addingNewEventHandler2;
		if (addingNewEventHandler == null)
		{
			return;
		}
		addingNewEventHandler(this, 1);
	}

	// Token: 0x06000777 RID: 1911 RVA: 0x00019860 File Offset: 0x00017A60
	protected virtual void Method7236(ListChangedEventArgs 1)
	{
		ListChangedEventHandler listChangedEventHandler = this.listChangedEventHandler2;
		if (listChangedEventHandler != null)
		{
			this.flag3 = true;
			try
			{
				listChangedEventHandler(this, 1);
			}
			finally
			{
				this.flag3 = false;
			}
		}
	}

	// Token: 0x06000778 RID: 1912 RVA: 0x000198A0 File Offset: 0x00017AA0
	protected virtual void Method7237(NotifyCollectionChangedEventArgs 1)
	{
		NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler = this.notifyCollectionChangedEventHandler2;
		if (notifyCollectionChangedEventHandler != null)
		{
			this.flag3 = true;
			try
			{
				notifyCollectionChangedEventHandler(this, 1);
			}
			finally
			{
				this.flag3 = false;
			}
		}
	}

	// Token: 0x06000779 RID: 1913 RVA: 0x000198E0 File Offset: 0x00017AE0
	internal bool Method7238(111 1)
	{
		if (1 == this)
		{
			return true;
		}
		IList<226> childrenTokens = this.ChildrenTokens;
		IList<226> childrenTokens2 = 1.ChildrenTokens;
		if (childrenTokens.Count != childrenTokens2.Count)
		{
			return false;
		}
		for (int i = 0; i < childrenTokens.Count; i++)
		{
			if (!childrenTokens[i].Method14356(childrenTokens2[i]))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600077A RID: 1914 RVA: 0x0001993A File Offset: 0x00017B3A
	[return: 241(new byte[]
	{
		0,
		1
	})]
	public override 787<226> Children()
	{
		return new 787<226>(this.ChildrenTokens);
	}

	// Token: 0x0600077B RID: 1915 RVA: 0x00019947 File Offset: 0x00017B47
	[242(2)]
	[return: 241(new byte[]
	{
		1,
		2
	})]
	public override IEnumerable<T> Values<T>()
	{
		return this.ChildrenTokens.Method5762<226, T>();
	}

	// Token: 0x0600077C RID: 1916 RVA: 0x00019954 File Offset: 0x00017B54
	public IEnumerable<226> Method7239()
	{
		return this.Method7241(false);
	}

	// Token: 0x0600077D RID: 1917 RVA: 0x0001995D File Offset: 0x00017B5D
	public IEnumerable<226> Method7240()
	{
		return this.Method7241(true);
	}

	// Token: 0x0600077E RID: 1918 RVA: 0x00019966 File Offset: 0x00017B66
	internal IEnumerable<226> Method7241(bool 1)
	{
		return new 111.112(-2)
		{
			jContainer3 = this,
			flag2 = 1
		};
	}

	// Token: 0x0600077F RID: 1919 RVA: 0x0001997D File Offset: 0x00017B7D
	[242(2)]
	internal bool Method7242([239(true)] object 1)
	{
		return 1 is IEnumerable && !(1 is string) && !(1 is 226) && !(1 is byte[]);
	}

	// Token: 0x06000780 RID: 1920 RVA: 0x000199A8 File Offset: 0x00017BA8
	internal 226 Method7243([241(2)] 226 1, bool 2, bool 3)
	{
		if (1 == null)
		{
			return 233.CreateNull();
		}
		if (2)
		{
			return 1;
		}
		if (1.Parent != null || 1 == this || (1.HasValues && base.Root == 1))
		{
			479 4 = 3 ? null : 479._recoveredType08253605;
			1 = 1.Method14299(4);
		}
		return 1;
	}

	// Token: 0x06000781 RID: 1921
	[242(2)]
	internal abstract int Method14291(226 1);

	// Token: 0x06000782 RID: 1922 RVA: 0x000199F8 File Offset: 0x00017BF8
	[242(2)]
	internal virtual bool Method14292(int 1, 226 2, bool 3, bool 4)
	{
		IList<226> childrenTokens = this.ChildrenTokens;
		if (1 > childrenTokens.Count)
		{
			throw new ArgumentOutOfRangeException("#=zEcSd6Vg=", "Index must be within the bounds of the List.");
		}
		this.Method7233();
		2 = this.Method7243(2, 3, 4);
		226 5 = (1 == 0) ? null : childrenTokens[1 - 1];
		226 6 = (1 == childrenTokens.Count) ? null : childrenTokens[1];
		this.Method14256(2, null);
		2.Parent = this;
		2.Previous = 5;
		if (5 != null)
		{
			5.Next = 2;
		}
		2.Next = 6;
		if (6 != null)
		{
			6.Previous = 2;
		}
		childrenTokens.Insert(1, 2);
		if (this.listChangedEventHandler2 != null)
		{
			this.Method7236(new ListChangedEventArgs(ListChangedType.ItemAdded, 1));
		}
		if (this.notifyCollectionChangedEventHandler2 != null)
		{
			this.Method7237(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, 2, 1));
		}
		return true;
	}

	// Token: 0x06000783 RID: 1923 RVA: 0x00019AC0 File Offset: 0x00017CC0
	internal virtual void Method14290(int 1)
	{
		IList<226> childrenTokens = this.ChildrenTokens;
		if (1 < 0)
		{
			throw new ArgumentOutOfRangeException("#=zEcSd6Vg=", "Index is less than 0.");
		}
		if (1 >= childrenTokens.Count)
		{
			throw new ArgumentOutOfRangeException("#=zEcSd6Vg=", "Index is equal to or greater than Count.");
		}
		this.Method7233();
		226 2 = childrenTokens[1];
		226 3 = (1 == 0) ? null : childrenTokens[1 - 1];
		226 4 = (1 == childrenTokens.Count - 1) ? null : childrenTokens[1 + 1];
		if (3 != null)
		{
			3.Next = 4;
		}
		if (4 != null)
		{
			4.Previous = 3;
		}
		2.Parent = null;
		2.Previous = null;
		2.Next = null;
		childrenTokens.RemoveAt(1);
		if (this.listChangedEventHandler2 != null)
		{
			this.Method7236(new ListChangedEventArgs(ListChangedType.ItemDeleted, 1));
		}
		if (this.notifyCollectionChangedEventHandler2 != null)
		{
			this.Method7237(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, 2, 1));
		}
	}

	// Token: 0x06000784 RID: 1924 RVA: 0x00019B94 File Offset: 0x00017D94
	[242(2)]
	internal virtual bool Method14289(226 1)
	{
		if (1 != null)
		{
			int num = this.Method14291(1);
			if (num >= 0)
			{
				this.Method14290(num);
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000785 RID: 1925 RVA: 0x00019BBA File Offset: 0x00017DBA
	internal virtual 226 Method14287(int 1)
	{
		return this.ChildrenTokens[1];
	}

	// Token: 0x06000786 RID: 1926 RVA: 0x00019BC8 File Offset: 0x00017DC8
	[242(2)]
	internal virtual void Method14288(int 1, 226 2)
	{
		IList<226> childrenTokens = this.ChildrenTokens;
		if (1 < 0)
		{
			throw new ArgumentOutOfRangeException("#=zEcSd6Vg=", "Index is less than 0.");
		}
		if (1 >= childrenTokens.Count)
		{
			throw new ArgumentOutOfRangeException("#=zEcSd6Vg=", "Index is equal to or greater than Count.");
		}
		226 3 = childrenTokens[1];
		if (!111.Method7254(3, 2))
		{
			this.Method7233();
			2 = this.Method7243(2, false, true);
			this.Method14256(2, 3);
			226 4 = (1 == 0) ? null : childrenTokens[1 - 1];
			226 5 = (1 == childrenTokens.Count - 1) ? null : childrenTokens[1 + 1];
			2.Parent = this;
			2.Previous = 4;
			if (4 != null)
			{
				4.Next = 2;
			}
			2.Next = 5;
			if (5 != null)
			{
				5.Previous = 2;
			}
			childrenTokens[1] = 2;
			3.Parent = null;
			3.Previous = null;
			3.Next = null;
			if (this.listChangedEventHandler2 != null)
			{
				this.Method7236(new ListChangedEventArgs(ListChangedType.ItemChanged, 1));
			}
			if (this.notifyCollectionChangedEventHandler2 != null)
			{
				this.Method7237(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, 2, 3, 1));
			}
		}
	}

	// Token: 0x06000787 RID: 1927 RVA: 0x00019CD0 File Offset: 0x00017ED0
	internal virtual void Method14295()
	{
		this.Method7233();
		IList<226> childrenTokens = this.ChildrenTokens;
		foreach (226 <<EMPTY_NAME>> in childrenTokens)
		{
			<<EMPTY_NAME>>.Parent = null;
			<<EMPTY_NAME>>.Previous = null;
			<<EMPTY_NAME>>.Next = null;
		}
		childrenTokens.Clear();
		if (this.listChangedEventHandler2 != null)
		{
			this.Method7236(new ListChangedEventArgs(ListChangedType.Reset, -1));
		}
		if (this.notifyCollectionChangedEventHandler2 != null)
		{
			this.Method7237(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
		}
	}

	// Token: 0x06000788 RID: 1928 RVA: 0x00019D60 File Offset: 0x00017F60
	internal virtual void Method7251(226 1, 226 2)
	{
		if (1 != null && 1.Parent == this)
		{
			int 3 = this.Method14291(1);
			this.Method14288(3, 2);
		}
	}

	// Token: 0x06000789 RID: 1929 RVA: 0x00019D89 File Offset: 0x00017F89
	[242(2)]
	internal virtual bool Method14293(226 1)
	{
		return this.Method14291(1) != -1;
	}

	// Token: 0x0600078A RID: 1930 RVA: 0x00019D98 File Offset: 0x00017F98
	internal virtual void Method7253(Array 1, int 2)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=zf5dqUaI=");
		}
		if (2 < 0)
		{
			throw new ArgumentOutOfRangeException("#=z23ac_4Y=", "arrayIndex is less than 0.");
		}
		if (2 >= 1.Length && 2 != 0)
		{
			throw new ArgumentException("arrayIndex is equal to or greater than the length of array.");
		}
		if (this.Count > 1.Length - 2)
		{
			throw new ArgumentException("The number of elements in the source JObject is greater than the available space from arrayIndex to the end of the destination array.");
		}
		int num = 0;
		foreach (226 value in this.ChildrenTokens)
		{
			1.SetValue(value, 2 + num);
			num++;
		}
	}

	// Token: 0x0600078B RID: 1931 RVA: 0x00019E44 File Offset: 0x00018044
	internal static bool Method7254(226 1, [241(2)] 226 2)
	{
		233 3 = 1 as 233;
		if (3 == null)
		{
			return false;
		}
		if (2 == null)
		{
			return 3.Type == 705.Null;
		}
		return 3.Equals(2);
	}

	// Token: 0x0600078C RID: 1932 RVA: 0x00019E72 File Offset: 0x00018072
	internal virtual void Method14256(226 1, [241(2)] 226 2)
	{
		756.Method12216(1, "o");
		if (1.Type == 705.Property)
		{
			throw new ArgumentException("Can not add {0} to {1}.".Method6825(CultureInfo.InvariantCulture, 1.GetType(), base.GetType()));
		}
	}

	// Token: 0x0600078D RID: 1933 RVA: 0x00019EA9 File Offset: 0x000180A9
	[242(2)]
	public virtual void Method7256(object 1)
	{
		this.Method7260(this.ChildrenTokens.Count, 1, false, true);
	}

	// Token: 0x0600078E RID: 1934 RVA: 0x00019EC0 File Offset: 0x000180C0
	[242(2)]
	internal bool Method7257(object 1)
	{
		return this.Method7260(this.ChildrenTokens.Count, 1, false, true);
	}

	// Token: 0x0600078F RID: 1935 RVA: 0x00019ED6 File Offset: 0x000180D6
	internal void Method7258(226 1)
	{
		this.Method7260(this.ChildrenTokens.Count, 1, true, true);
	}

	// Token: 0x06000790 RID: 1936 RVA: 0x00019EED File Offset: 0x000180ED
	[242(2)]
	public void Method7259(object 1)
	{
		this.Method7260(0, 1, false, true);
	}

	// Token: 0x06000791 RID: 1937 RVA: 0x00019EFC File Offset: 0x000180FC
	[242(2)]
	internal bool Method7260(int 1, object 2, bool 3, bool 4)
	{
		if (this.Method7242(2))
		{
			IEnumerable enumerable = (IEnumerable)2;
			int num = 1;
			foreach (object 5 in enumerable)
			{
				this.Method7260(num, 5, 3, 4);
				num++;
			}
			return true;
		}
		226 6 = 111.Method7261(2);
		return this.Method14292(1, 6, 3, 4);
	}

	// Token: 0x06000792 RID: 1938 RVA: 0x00019F7C File Offset: 0x0001817C
	internal static 226 Method7261([241(2)] object 1)
	{
		226 2 = 1 as 226;
		if (2 != null)
		{
			return 2;
		}
		return new 233(1);
	}

	// Token: 0x06000793 RID: 1939 RVA: 0x00019F9B File Offset: 0x0001819B
	public 173 Method7262()
	{
		return new 124(this);
	}

	// Token: 0x06000794 RID: 1940 RVA: 0x00019FA3 File Offset: 0x000181A3
	public void Method7263(object 1)
	{
		this.Method14295();
		this.Method7256(1);
	}

	// Token: 0x06000795 RID: 1941 RVA: 0x0001936C File Offset: 0x0001756C
	public void Method7264()
	{
		this.Method14295();
	}

	// Token: 0x06000796 RID: 1942
	internal abstract void Method14294(object 1, [241(2)] 793 2);

	// Token: 0x06000797 RID: 1943 RVA: 0x00019FB2 File Offset: 0x000181B2
	[242(2)]
	public void Method7266(object 1)
	{
		if (1 != null)
		{
			this.Method7268(1);
			this.Method14294(1, null);
		}
	}

	// Token: 0x06000798 RID: 1944 RVA: 0x00019FC6 File Offset: 0x000181C6
	[242(2)]
	public void Method7266(object 1, 793 2)
	{
		if (1 != null)
		{
			this.Method7268(1);
			this.Method14294(1, 2);
		}
	}

	// Token: 0x06000799 RID: 1945 RVA: 0x00019FDC File Offset: 0x000181DC
	private void Method7268(object 1)
	{
		if (1.GetType().IsSubclassOf(typeof(226)) || this.Method7242(1))
		{
			return;
		}
		throw new ArgumentException("Could not determine JSON object type for type {0}.".Method6825(CultureInfo.InvariantCulture, 1.GetType()), "#=zdS_Q3f4=");
	}

	// Token: 0x0600079A RID: 1946 RVA: 0x0001A02C File Offset: 0x0001822C
	internal void Method7269(139 1, [241(2)] 554 2)
	{
		int depth = 1.GetDepth();
		if (!1.Read())
		{
			throw 141.Method12886(1, "Error reading {0} from JsonReader.".Method6825(CultureInfo.InvariantCulture, base.GetType().Name));
		}
		this.Method7270(1, 2);
		if (1.GetDepth() > depth)
		{
			throw 141.Method12886(1, "Unexpected end of content while loading {0}.".Method6825(CultureInfo.InvariantCulture, base.GetType().Name));
		}
	}

	// Token: 0x0600079B RID: 1947 RVA: 0x0001A09C File Offset: 0x0001829C
	internal void Method7270(139 1, [241(2)] 554 2)
	{
		756.Method12216(1, "r");
		99 3 = 1 as 99;
		111 4 = this;
		for (;;)
		{
			222 5 = 4 as 222;
			if (5 != null && 5.Value != null)
			{
				if (4 == this)
				{
					return;
				}
				4 = 4.Parent;
			}
			switch (1.GetTokenType())
			{
			case 216.None:
				goto IL_1F6;
			case 216.StartObject:
			{
				217 6 = new 217();
				6.Method14343(3, 2);
				4.Method7256(6);
				4 = 6;
				goto IL_1F6;
			}
			case 216.StartArray:
			{
				109 7 = new 109();
				7.Method14343(3, 2);
				4.Method7256(7);
				4 = 7;
				goto IL_1F6;
			}
			case 216.StartConstructor:
			{
				110 8 = new 110(1.GetValue().ToString());
				8.Method14343(3, 2);
				4.Method7256(8);
				4 = 8;
				goto IL_1F6;
			}
			case 216.PropertyName:
			{
				222 9 = 111.Method7271(1, 2, 3, 4);
				if (9 != null)
				{
					4 = 9;
					goto IL_1F6;
				}
				1.Skip();
				goto IL_1F6;
			}
			case 216.Comment:
				if (2 != null && 2.GetRecoveredType15785743_7441() == (611)1)
				{
					233 10 = 233.CreateComment(1.GetValue().ToString());
					10.Method14343(3, 2);
					4.Method7256(10);
					goto IL_1F6;
				}
				goto IL_1F6;
			case 216.Integer:
			case 216.Float:
			case 216.String:
			case 216.Boolean:
			case 216.Date:
			case 216.Bytes:
			{
				233 11 = new 233(1.GetValue());
				11.Method14343(3, 2);
				4.Method7256(11);
				goto IL_1F6;
			}
			case 216.Null:
			{
				233 12 = 233.CreateNull();
				12.Method14343(3, 2);
				4.Method7256(12);
				goto IL_1F6;
			}
			case 216.Undefined:
			{
				233 13 = 233.CreateUndefined();
				13.Method14343(3, 2);
				4.Method7256(13);
				goto IL_1F6;
			}
			case 216.EndObject:
				if (4 == this)
				{
					return;
				}
				4 = 4.Parent;
				goto IL_1F6;
			case 216.EndArray:
				if (4 == this)
				{
					return;
				}
				4 = 4.Parent;
				goto IL_1F6;
			case 216.EndConstructor:
				if (4 == this)
				{
					return;
				}
				4 = 4.Parent;
				goto IL_1F6;
			}
			break;
			IL_1F6:
			if (!1.Read())
			{
				return;
			}
		}
		throw new InvalidOperationException("The JsonReader should not be on a token of type {0}.".Method6825(CultureInfo.InvariantCulture, 1.GetTokenType()));
	}

	// Token: 0x0600079C RID: 1948 RVA: 0x0001A2AC File Offset: 0x000184AC
	[242(2)]
	private static 222 Method7271([241(1)] 139 1, 554 2, 99 3, [241(1)] 111 4)
	{
		704 5 = (2 != null) ? 2.GetRecoveredType19705745_7445() : ((704)0);
		217 6 = (217)4;
		string text = 1.GetValue().ToString();
		222 7 = 6.Property(text, StringComparison.Ordinal);
		if (7 != null)
		{
			if (5 == (704)1)
			{
				return null;
			}
			if (5 == (704)2)
			{
				throw 141.Method12886(1, "Property with the name '{0}' already exists in the current JSON object.".Method6825(CultureInfo.InvariantCulture, text));
			}
		}
		222 8 = new 222(text);
		8.Method14343(3, 2);
		if (7 == null)
		{
			4.Method7256(8);
		}
		else
		{
			7.Replace(8);
		}
		return 8;
	}

	// Token: 0x0600079D RID: 1949 RVA: 0x0001A32C File Offset: 0x0001852C
	internal int Method7272()
	{
		int num = 0;
		foreach (226 <<EMPTY_NAME>> in this.ChildrenTokens)
		{
			num ^= <<EMPTY_NAME>>.Method14364();
		}
		return num;
	}

	// Token: 0x0600079E RID: 1950 RVA: 0x0001A380 File Offset: 0x00018580
	private string GetEmpty_7273(PropertyDescriptor[] 1)
	{
		return string.Empty;
	}

	// Token: 0x0600079F RID: 1951 RVA: 0x0001A387 File Offset: 0x00018587
	string ITypedList.GetListName(PropertyDescriptor[] 1)
	{
		return this.GetEmpty_7273(1);
	}

	// Token: 0x060007A0 RID: 1952 RVA: 0x0001A390 File Offset: 0x00018590
	private PropertyDescriptorCollection Method7274(PropertyDescriptor[] 1)
	{
		ICustomTypeDescriptor customTypeDescriptor = this.First as ICustomTypeDescriptor;
		return ((customTypeDescriptor != null) ? customTypeDescriptor.GetProperties() : null) ?? new PropertyDescriptorCollection(418.GetItemArray2540_3182<PropertyDescriptor>());
	}

	// Token: 0x060007A1 RID: 1953 RVA: 0x0001A3B7 File Offset: 0x000185B7
	PropertyDescriptorCollection ITypedList.GetItemProperties(PropertyDescriptor[] 1)
	{
		return this.Method7274(1);
	}

	// Token: 0x060007A2 RID: 1954 RVA: 0x00019327 File Offset: 0x00017527
	private int Method7275(226 1)
	{
		return this.Method14291(1);
	}

	// Token: 0x060007A3 RID: 1955 RVA: 0x0001A3C0 File Offset: 0x000185C0
	int IList<226>.IndexOf(226 1)
	{
		return this.Method7275(1);
	}

	// Token: 0x060007A4 RID: 1956 RVA: 0x00019330 File Offset: 0x00017530
	private void Method7276(int 1, 226 2)
	{
		this.Method14292(1, 2, false, true);
	}

	// Token: 0x060007A5 RID: 1957 RVA: 0x0001A3C9 File Offset: 0x000185C9
	void IList<226>.Insert(int 1, 226 2)
	{
		this.Method7276(1, 2);
	}

	// Token: 0x060007A6 RID: 1958 RVA: 0x0001933D File Offset: 0x0001753D
	private void Method7277(int 1)
	{
		this.Method14290(1);
	}

	// Token: 0x060007A7 RID: 1959 RVA: 0x0001A3D3 File Offset: 0x000185D3
	void IList<226>.RemoveAt(int 1)
	{
		this.Method7277(1);
	}

	// Token: 0x060007A8 RID: 1960 RVA: 0x000190D6 File Offset: 0x000172D6
	private 226 Method7278(int 1)
	{
		return this.Method14287(1);
	}

	// Token: 0x17000063 RID: 99
	226 IList<226>.this[int 1]
	{
		get
		{
			return this.Method7278(1);
		}
		set
		{
			this.Method7279(1, value);
		}
	}

	// Token: 0x060007AB RID: 1963 RVA: 0x000190DF File Offset: 0x000172DF
	private void Method7279(int 1, 226 2)
	{
		this.Method14288(1, 2);
	}

	// Token: 0x060007AC RID: 1964 RVA: 0x00019363 File Offset: 0x00017563
	private void Method7280(226 1)
	{
		this.Method7256(1);
	}

	// Token: 0x060007AD RID: 1965 RVA: 0x0001A3EF File Offset: 0x000185EF
	void ICollection<226>.Add(226 1)
	{
		this.Method7280(1);
	}

	// Token: 0x060007AE RID: 1966 RVA: 0x0001936C File Offset: 0x0001756C
	private void Method7281()
	{
		this.Method14295();
	}

	// Token: 0x060007AF RID: 1967 RVA: 0x0001A3F8 File Offset: 0x000185F8
	void ICollection<226>.Clear()
	{
		this.Method7281();
	}

	// Token: 0x060007B0 RID: 1968 RVA: 0x00019374 File Offset: 0x00017574
	private bool Method7282(226 1)
	{
		return this.Method14293(1);
	}

	// Token: 0x060007B1 RID: 1969 RVA: 0x0001A400 File Offset: 0x00018600
	bool ICollection<226>.Contains(226 1)
	{
		return this.Method7282(1);
	}

	// Token: 0x060007B2 RID: 1970 RVA: 0x0001937D File Offset: 0x0001757D
	private void Method7283(226[] 1, int 2)
	{
		this.Method7253(1, 2);
	}

	// Token: 0x060007B3 RID: 1971 RVA: 0x0001A409 File Offset: 0x00018609
	void ICollection<226>.CopyTo(226[] 1, int 2)
	{
		this.Method7283(1, 2);
	}

	// Token: 0x060007B4 RID: 1972 RVA: 0x0000FF75 File Offset: 0x0000E175
	private bool Method7284()
	{
		return false;
	}

	// Token: 0x17000064 RID: 100
	// (get) Token: 0x060007B5 RID: 1973 RVA: 0x0001A413 File Offset: 0x00018613
	bool ICollection<226>.IsReadOnly
	{
		get
		{
			return this.Method7284();
		}
	}

	// Token: 0x060007B6 RID: 1974 RVA: 0x00019387 File Offset: 0x00017587
	private bool Method7285(226 1)
	{
		return this.Method14289(1);
	}

	// Token: 0x060007B7 RID: 1975 RVA: 0x0001A41B File Offset: 0x0001861B
	bool ICollection<226>.Remove(226 1)
	{
		return this.Method7285(1);
	}

	// Token: 0x060007B8 RID: 1976 RVA: 0x0001A424 File Offset: 0x00018624
	[242(2)]
	private 226 Method7286(object 1)
	{
		if (1 == null)
		{
			return null;
		}
		226 2 = 1 as 226;
		if (2 != null)
		{
			return 2;
		}
		throw new ArgumentException("Argument is not a JToken.");
	}

	// Token: 0x060007B9 RID: 1977 RVA: 0x0001A44C File Offset: 0x0001864C
	[242(2)]
	private int Method7287(object 1)
	{
		this.Method7256(this.Method7286(1));
		return this.Count - 1;
	}

	// Token: 0x060007BA RID: 1978 RVA: 0x0001A463 File Offset: 0x00018663
	int IList.Add(object 1)
	{
		return this.Method7287(1);
	}

	// Token: 0x060007BB RID: 1979 RVA: 0x0001936C File Offset: 0x0001756C
	private void Method7288()
	{
		this.Method14295();
	}

	// Token: 0x060007BC RID: 1980 RVA: 0x0001A46C File Offset: 0x0001866C
	void IList.Clear()
	{
		this.Method7288();
	}

	// Token: 0x060007BD RID: 1981 RVA: 0x0001A474 File Offset: 0x00018674
	[242(2)]
	private bool Method7289(object 1)
	{
		return this.Method14293(this.Method7286(1));
	}

	// Token: 0x060007BE RID: 1982 RVA: 0x0001A483 File Offset: 0x00018683
	bool IList.Contains(object 1)
	{
		return this.Method7289(1);
	}

	// Token: 0x060007BF RID: 1983 RVA: 0x0001A48C File Offset: 0x0001868C
	[242(2)]
	private int Method7290(object 1)
	{
		return this.Method14291(this.Method7286(1));
	}

	// Token: 0x060007C0 RID: 1984 RVA: 0x0001A49B File Offset: 0x0001869B
	int IList.IndexOf(object 1)
	{
		return this.Method7290(1);
	}

	// Token: 0x060007C1 RID: 1985 RVA: 0x0001A4A4 File Offset: 0x000186A4
	[242(2)]
	private void Method7291(int 1, object 2)
	{
		this.Method14292(1, this.Method7286(2), false, false);
	}

	// Token: 0x060007C2 RID: 1986 RVA: 0x0001A4B7 File Offset: 0x000186B7
	void IList.Insert(int 1, object 2)
	{
		this.Method7291(1, 2);
	}

	// Token: 0x060007C3 RID: 1987 RVA: 0x0000FF75 File Offset: 0x0000E175
	private bool Method7292()
	{
		return false;
	}

	// Token: 0x17000065 RID: 101
	// (get) Token: 0x060007C4 RID: 1988 RVA: 0x0001A4C1 File Offset: 0x000186C1
	bool IList.IsFixedSize
	{
		get
		{
			return this.Method7292();
		}
	}

	// Token: 0x060007C5 RID: 1989 RVA: 0x0000FF75 File Offset: 0x0000E175
	private bool Method7293()
	{
		return false;
	}

	// Token: 0x17000066 RID: 102
	// (get) Token: 0x060007C6 RID: 1990 RVA: 0x0001A4C9 File Offset: 0x000186C9
	bool IList.IsReadOnly
	{
		get
		{
			return this.Method7293();
		}
	}

	// Token: 0x060007C7 RID: 1991 RVA: 0x0001A4D1 File Offset: 0x000186D1
	[242(2)]
	private void Method7294(object 1)
	{
		this.Method14289(this.Method7286(1));
	}

	// Token: 0x060007C8 RID: 1992 RVA: 0x0001A4E1 File Offset: 0x000186E1
	void IList.Remove(object 1)
	{
		this.Method7294(1);
	}

	// Token: 0x060007C9 RID: 1993 RVA: 0x0001933D File Offset: 0x0001753D
	private void Method7295(int 1)
	{
		this.Method14290(1);
	}

	// Token: 0x060007CA RID: 1994 RVA: 0x0001A4EA File Offset: 0x000186EA
	void IList.RemoveAt(int 1)
	{
		this.Method7295(1);
	}

	// Token: 0x060007CB RID: 1995 RVA: 0x0001937D File Offset: 0x0001757D
	private void Method7296(Array 1, int 2)
	{
		this.Method7253(1, 2);
	}

	// Token: 0x060007CC RID: 1996 RVA: 0x0001A4F3 File Offset: 0x000186F3
	void ICollection.CopyTo(Array 1, int 2)
	{
		this.Method7296(1, 2);
	}

	// Token: 0x060007CD RID: 1997 RVA: 0x0000FF75 File Offset: 0x0000E175
	private bool Method7297()
	{
		return false;
	}

	// Token: 0x17000067 RID: 103
	// (get) Token: 0x060007CE RID: 1998 RVA: 0x0001A4FD File Offset: 0x000186FD
	bool ICollection.IsSynchronized
	{
		get
		{
			return this.Method7297();
		}
	}

	// Token: 0x060007CF RID: 1999 RVA: 0x0001A505 File Offset: 0x00018705
	private object Method7298()
	{
		if (this.value3 == null)
		{
			Interlocked.CompareExchange(ref this.value3, new object(), null);
		}
		return this.value3;
	}

	// Token: 0x17000068 RID: 104
	// (get) Token: 0x060007D0 RID: 2000 RVA: 0x0001A527 File Offset: 0x00018727
	object ICollection.SyncRoot
	{
		get
		{
			return this.Method7298();
		}
	}

	// Token: 0x060007D1 RID: 2001 RVA: 0x00005ADD File Offset: 0x00003CDD
	private void Method7299(PropertyDescriptor 1)
	{
	}

	// Token: 0x060007D2 RID: 2002 RVA: 0x0001A52F File Offset: 0x0001872F
	void IBindingList.AddIndex(PropertyDescriptor 1)
	{
		this.Method7299(1);
	}

	// Token: 0x060007D3 RID: 2003 RVA: 0x0001A538 File Offset: 0x00018738
	private object Method7300()
	{
		AddingNewEventArgs addingNewEventArgs = new AddingNewEventArgs();
		this.Method7235(addingNewEventArgs);
		if (addingNewEventArgs.NewObject == null)
		{
			throw new 134("Could not determine new value to add to '{0}'.".Method6825(CultureInfo.InvariantCulture, base.GetType()));
		}
		226 <<EMPTY_NAME>> = addingNewEventArgs.NewObject as 226;
		if (<<EMPTY_NAME>> == null)
		{
			throw new 134("New item to be added to collection must be compatible with {0}.".Method6825(CultureInfo.InvariantCulture, typeof(226)));
		}
		this.Method7256(<<EMPTY_NAME>>);
		return <<EMPTY_NAME>>;
	}

	// Token: 0x060007D4 RID: 2004 RVA: 0x0001A5AB File Offset: 0x000187AB
	object IBindingList.AddNew()
	{
		return this.Method7300();
	}

	// Token: 0x060007D5 RID: 2005 RVA: 0x0001702D File Offset: 0x0001522D
	private bool Method7301()
	{
		return true;
	}

	// Token: 0x17000069 RID: 105
	// (get) Token: 0x060007D6 RID: 2006 RVA: 0x0001A5B3 File Offset: 0x000187B3
	bool IBindingList.AllowEdit
	{
		get
		{
			return this.Method7301();
		}
	}

	// Token: 0x060007D7 RID: 2007 RVA: 0x0001702D File Offset: 0x0001522D
	private bool Method7302()
	{
		return true;
	}

	// Token: 0x1700006A RID: 106
	// (get) Token: 0x060007D8 RID: 2008 RVA: 0x0001A5BB File Offset: 0x000187BB
	bool IBindingList.AllowNew
	{
		get
		{
			return this.Method7302();
		}
	}

	// Token: 0x060007D9 RID: 2009 RVA: 0x0001702D File Offset: 0x0001522D
	private bool Method7303()
	{
		return true;
	}

	// Token: 0x1700006B RID: 107
	// (get) Token: 0x060007DA RID: 2010 RVA: 0x0001A5C3 File Offset: 0x000187C3
	bool IBindingList.AllowRemove
	{
		get
		{
			return this.Method7303();
		}
	}

	// Token: 0x060007DB RID: 2011 RVA: 0x00005BE8 File Offset: 0x00003DE8
	private void Method7304(PropertyDescriptor 1, ListSortDirection 2)
	{
		throw new NotSupportedException();
	}

	// Token: 0x060007DC RID: 2012 RVA: 0x0001A5CB File Offset: 0x000187CB
	void IBindingList.ApplySort(PropertyDescriptor 1, ListSortDirection 2)
	{
		this.Method7304(1, 2);
	}

	// Token: 0x060007DD RID: 2013 RVA: 0x00005BE8 File Offset: 0x00003DE8
	private int Method7305(PropertyDescriptor 1, object 2)
	{
		throw new NotSupportedException();
	}

	// Token: 0x060007DE RID: 2014 RVA: 0x0001A5D5 File Offset: 0x000187D5
	int IBindingList.Find(PropertyDescriptor 1, object 2)
	{
		return this.Method7305(1, 2);
	}

	// Token: 0x060007DF RID: 2015 RVA: 0x0000FF75 File Offset: 0x0000E175
	private bool Method7306()
	{
		return false;
	}

	// Token: 0x1700006C RID: 108
	// (get) Token: 0x060007E0 RID: 2016 RVA: 0x0001A5DF File Offset: 0x000187DF
	bool IBindingList.IsSorted
	{
		get
		{
			return this.Method7306();
		}
	}

	// Token: 0x060007E1 RID: 2017 RVA: 0x00005ADD File Offset: 0x00003CDD
	private void Method7307(PropertyDescriptor 1)
	{
	}

	// Token: 0x060007E2 RID: 2018 RVA: 0x0001A5E7 File Offset: 0x000187E7
	void IBindingList.RemoveIndex(PropertyDescriptor 1)
	{
		this.Method7307(1);
	}

	// Token: 0x060007E3 RID: 2019 RVA: 0x00005BE8 File Offset: 0x00003DE8
	private void Method7308()
	{
		throw new NotSupportedException();
	}

	// Token: 0x060007E4 RID: 2020 RVA: 0x0001A5F0 File Offset: 0x000187F0
	void IBindingList.RemoveSort()
	{
		this.Method7308();
	}

	// Token: 0x060007E5 RID: 2021 RVA: 0x0000FF75 File Offset: 0x0000E175
	private ListSortDirection GetAscending_7309()
	{
		return ListSortDirection.Ascending;
	}

	// Token: 0x1700006D RID: 109
	// (get) Token: 0x060007E6 RID: 2022 RVA: 0x0001A5F8 File Offset: 0x000187F8
	ListSortDirection IBindingList.SortDirection
	{
		get
		{
			return this.GetAscending_7309();
		}
	}

	// Token: 0x060007E7 RID: 2023 RVA: 0x0001702D File Offset: 0x0001522D
	private bool Method7310()
	{
		return true;
	}

	// Token: 0x1700006E RID: 110
	// (get) Token: 0x060007E8 RID: 2024 RVA: 0x0001A600 File Offset: 0x00018800
	bool IBindingList.SupportsChangeNotification
	{
		get
		{
			return this.Method7310();
		}
	}

	// Token: 0x060007E9 RID: 2025 RVA: 0x0000FF75 File Offset: 0x0000E175
	private bool Method7311()
	{
		return false;
	}

	// Token: 0x1700006F RID: 111
	// (get) Token: 0x060007EA RID: 2026 RVA: 0x0001A608 File Offset: 0x00018808
	bool IBindingList.SupportsSearching
	{
		get
		{
			return this.Method7311();
		}
	}

	// Token: 0x060007EB RID: 2027 RVA: 0x0000FF75 File Offset: 0x0000E175
	private bool Method7312()
	{
		return false;
	}

	// Token: 0x17000070 RID: 112
	// (get) Token: 0x060007EC RID: 2028 RVA: 0x0001A610 File Offset: 0x00018810
	bool IBindingList.SupportsSorting
	{
		get
		{
			return this.Method7312();
		}
	}

	// Token: 0x060007ED RID: 2029 RVA: 0x0001A618 File Offset: 0x00018818
	internal static void Method7313(111 1, IEnumerable 2, [241(2)] 793 3)
	{
		switch ((3 != null) ? 3.GetRecoveredType168210100_12946() : ((632)0))
		{
		case (632)0:
			using (IEnumerator enumerator = 2.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					object 4 = enumerator.Current;
					1.Method7256(111.Method7261(4));
				}
				return;
			}
			break;
		case (632)1:
			break;
		case (632)2:
			goto IL_B6;
		case (632)3:
			goto IL_FF;
		default:
			goto IL_198;
		}
		HashSet<226> hashSet = new HashSet<226>(1, 226.EqualityComparer);
		using (IEnumerator enumerator = 2.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				object 5 = enumerator.Current;
				226 6 = 111.Method7261(5);
				if (hashSet.Add(6))
				{
					1.Method7256(6);
				}
			}
			return;
		}
		IL_B6:
		if (1 == 2)
		{
			return;
		}
		1.Method14295();
		using (IEnumerator enumerator = 2.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				object 7 = enumerator.Current;
				1.Method7256(111.Method7261(7));
			}
			return;
		}
		IL_FF:
		int num = 0;
		using (IEnumerator enumerator = 2.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				object obj = enumerator.Current;
				if (num < 1.Count)
				{
					111 8 = 1[num] as 111;
					if (8 != null)
					{
						8.Method7266(obj, 3);
					}
					else if (obj != null)
					{
						226 9 = 111.Method7261(obj);
						if (9.Type != 705.Null)
						{
							1[num] = 9;
						}
					}
				}
				else
				{
					1.Method7256(111.Method7261(obj));
				}
				num++;
			}
			return;
		}
		IL_198:
		throw new ArgumentOutOfRangeException("settings", "Unexpected merge array handling when merging JSON.");
	}

	// Token: 0x17000071 RID: 113
	// (get) Token: 0x060007EE RID: 2030 RVA: 0x0001A804 File Offset: 0x00018A04
	PropertyDescriptor IBindingList.SortProperty
	{
		get
		{
			return this.PropertyDescriptor5700;
		}
	}

	// Token: 0x0400049C RID: 1180
	[241(2)]
	internal ListChangedEventHandler listChangedEventHandler2;

	// Token: 0x0400049D RID: 1181
	[241(2)]
	internal AddingNewEventHandler addingNewEventHandler2;

	// Token: 0x0400049E RID: 1182
	[241(2)]
	internal NotifyCollectionChangedEventHandler notifyCollectionChangedEventHandler2;

	// Token: 0x0400049F RID: 1183
	[241(2)]
	private object value3;

	// Token: 0x040004A0 RID: 1184
	private bool flag3;

	// Token: 0x020000EB RID: 235
	public sealed class 112 : IEnumerable<226>, IEnumerable, IEnumerator<226>, IDisposable, IEnumerator
	{
		// Token: 0x060007EF RID: 2031 RVA: 0x0001A80C File Offset: 0x00018A0C
		[DebuggerHidden]
		public 112(int 1)
		{
			this.number2 = 1;
			this.number3 = Thread.CurrentThread.ManagedThreadId;
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x0001A82C File Offset: 0x00018A2C
		[DebuggerHidden]
		private void Method7221()
		{
			int num = this.number2;
			if (num - -4 > 1 && num - 2 > 1)
			{
				return;
			}
			try
			{
				if (num == -4 || num == 3)
				{
					try
					{
					}
					finally
					{
						this.Method7223();
					}
				}
			}
			finally
			{
				this.Method7222();
			}
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x0001A888 File Offset: 0x00018A88
		void IDisposable.Dispose()
		{
			this.Method7221();
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x0001A890 File Offset: 0x00018A90
		private bool MoveNext()
		{
			bool result;
			try
			{
				int num = this.number2;
				111 <<EMPTY_NAME>> = this.jContainer3;
				switch (num)
				{
				case 0:
					this.number2 = -1;
					if (this.flag)
					{
						this.jToken = <<EMPTY_NAME>>;
						this.number2 = 1;
						return true;
					}
					goto IL_D4;
				case 1:
					this.number2 = -1;
					goto IL_D4;
				case 2:
				{
					this.number2 = -3;
					111 2 = this.jToken2 as 111;
					if (2 == null)
					{
						goto IL_EF;
					}
					this.iEnumerator2 = 2.Method7239().GetEnumerator();
					this.number2 = -4;
					break;
				}
				case 3:
					this.number2 = -4;
					break;
				default:
					return false;
				}
				if (this.iEnumerator2.MoveNext())
				{
					226 3 = this.iEnumerator2.Current;
					this.jToken = 3;
					this.number2 = 3;
					return true;
				}
				this.Method7223();
				this.iEnumerator2 = null;
				goto IL_EF;
				IL_D4:
				this.iEnumerator = <<EMPTY_NAME>>.ChildrenTokens.GetEnumerator();
				this.number2 = -3;
				goto IL_F6;
				IL_EF:
				this.jToken2 = null;
				IL_F6:
				if (this.iEnumerator.MoveNext())
				{
					this.jToken2 = this.iEnumerator.Current;
					this.jToken = this.jToken2;
					this.number2 = 2;
					result = true;
				}
				else
				{
					this.Method7222();
					this.iEnumerator = null;
					result = false;
				}
			}
			catch
			{
				this.Method7221();
				throw;
			}
			return result;
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x0001AA00 File Offset: 0x00018C00
		bool IEnumerator.MoveNext()
		{
			return this.MoveNext();
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x0001AA08 File Offset: 0x00018C08
		private void Method7222()
		{
			this.number2 = -1;
			if (this.iEnumerator != null)
			{
				this.iEnumerator.Dispose();
			}
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x0001AA24 File Offset: 0x00018C24
		private void Method7223()
		{
			this.number2 = -3;
			if (this.iEnumerator2 != null)
			{
				this.iEnumerator2.Dispose();
			}
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x0001AA41 File Offset: 0x00018C41
		[DebuggerHidden]
		private 226 GetJToken5687_7224()
		{
			return this.jToken;
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060007F7 RID: 2039 RVA: 0x0001AA49 File Offset: 0x00018C49
		226 IEnumerator<226>.Current
		{
			get
			{
				return this.GetJToken5687_7224();
			}
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x00005BE8 File Offset: 0x00003DE8
		[DebuggerHidden]
		private void Method7225()
		{
			throw new NotSupportedException();
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x0001AA51 File Offset: 0x00018C51
		void IEnumerator.Reset()
		{
			this.Method7225();
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x0001AA41 File Offset: 0x00018C41
		[DebuggerHidden]
		[return: 241(0)]
		private object GetJToken5687_7226()
		{
			return this.jToken;
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060007FB RID: 2043 RVA: 0x0001AA59 File Offset: 0x00018C59
		object IEnumerator.Current
		{
			get
			{
				return this.GetJToken5687_7226();
			}
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x0001AA64 File Offset: 0x00018C64
		[DebuggerHidden]
		[return: 241(0)]
		private IEnumerator<226> Method7227()
		{
			111.112 <<EMPTY_NAME>>;
			if (this.number2 == -2 && this.number3 == Thread.CurrentThread.ManagedThreadId)
			{
				this.number2 = 0;
				<<EMPTY_NAME>> = this;
			}
			else
			{
				<<EMPTY_NAME>> = new 111.112(0);
				<<EMPTY_NAME>>.jContainer3 = this.jContainer3;
			}
			<<EMPTY_NAME>>.flag = this.flag2;
			return <<EMPTY_NAME>>;
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x0001AAB8 File Offset: 0x00018CB8
		IEnumerator<226> IEnumerable<226>.GetEnumerator()
		{
			return this.Method7227();
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x0001AAB8 File Offset: 0x00018CB8
		[DebuggerHidden]
		[return: 241(0)]
		private IEnumerator Method7228()
		{
			return this.Method7227();
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x0001AAC0 File Offset: 0x00018CC0
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.Method7228();
		}

		// Token: 0x040004A1 RID: 1185
		private int number2;

		// Token: 0x040004A2 RID: 1186
		private 226 jToken;

		// Token: 0x040004A3 RID: 1187
		private int number3;

		// Token: 0x040004A4 RID: 1188
		private bool flag;

		// Token: 0x040004A5 RID: 1189
		public bool flag2;

		// Token: 0x040004A6 RID: 1190
		[241(0)]
		public 111 jContainer3;

		// Token: 0x040004A7 RID: 1191
		[241(new byte[]
		{
			0,
			1
		})]
		private IEnumerator<226> iEnumerator;

		// Token: 0x040004A8 RID: 1192
		[241(0)]
		private 226 jToken2;

		// Token: 0x040004A9 RID: 1193
		[241(new byte[]
		{
			0,
			1
		})]
		private IEnumerator<226> iEnumerator2;
	}
}
