using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;

// Token: 0x020000E8 RID: 232
[ComVisible(false)]
[242(1)]
[241(0)]
public sealed class 109 : 111, IList<226>, ICollection<226>, IEnumerable<226>, IEnumerable
{
	// Token: 0x17000053 RID: 83
	// (get) Token: 0x0600072D RID: 1837 RVA: 0x00019052 File Offset: 0x00017252
	protected override IList<226> ChildrenTokens
	{
		get
		{
			return this.list;
		}
	}

	// Token: 0x17000054 RID: 84
	// (get) Token: 0x0600072E RID: 1838 RVA: 0x0001905A File Offset: 0x0001725A
	public override 705 Type
	{
		get
		{
			return 705.Array;
		}
	}

	// Token: 0x17000055 RID: 85
	[241(2)]
	public override 226 this[object 1]
	{
		[return: 241(2)]
		get
		{
			756.Method12216(1, "key");
			if (!(1 is int))
			{
				throw new ArgumentException("Accessed JArray values with invalid key value: {0}. Int32 array index expected.".Method6825(CultureInfo.InvariantCulture, 736.Method11630(1)));
			}
			return this.Method14287((int)1);
		}
		[param: 241(2)]
		set
		{
			756.Method12216(1, "key");
			if (!(1 is int))
			{
				throw new ArgumentException("Set JArray values with invalid key value: {0}. Int32 array index expected.".Method6825(CultureInfo.InvariantCulture, 736.Method11630(1)));
			}
			this.Method14288((int)1, value);
		}
	}

	// Token: 0x17000056 RID: 86
	public 226 this[int 1]
	{
		get
		{
			return this.Method14287(1);
		}
		set
		{
			this.Method14288(1, value);
		}
	}

	// Token: 0x17000057 RID: 87
	// (get) Token: 0x06000733 RID: 1843 RVA: 0x0000FF75 File Offset: 0x0000E175
	public bool IsReadOnly
	{
		get
		{
			return false;
		}
	}

	// Token: 0x06000734 RID: 1844 RVA: 0x000190E9 File Offset: 0x000172E9
	public 109()
	{
	}

	// Token: 0x06000735 RID: 1845 RVA: 0x000190FC File Offset: 0x000172FC
	public 109(109 1) : base(1, null)
	{
	}

	// Token: 0x06000736 RID: 1846 RVA: 0x00019111 File Offset: 0x00017311
	internal 109(109 1, [241(2)] 479 2) : base(1, 2)
	{
	}

	// Token: 0x06000737 RID: 1847 RVA: 0x00019126 File Offset: 0x00017326
	public 109(params object[] 1) : this(1)
	{
	}

	// Token: 0x06000738 RID: 1848 RVA: 0x0001912F File Offset: 0x0001732F
	public 109(object 1)
	{
		this.Method7256(1);
	}

	// Token: 0x06000739 RID: 1849 RVA: 0x0001914C File Offset: 0x0001734C
	internal override bool Method14356(226 1)
	{
		109 2 = 1 as 109;
		return 2 != null && base.Method7238(2);
	}

	// Token: 0x0600073A RID: 1850 RVA: 0x0001916C File Offset: 0x0001736C
	internal override 226 Method14299([241(2)] 479 1 = null)
	{
		return new 109(this, 1);
	}

	// Token: 0x0600073B RID: 1851 RVA: 0x00019175 File Offset: 0x00017375
	public static 109 Method1939(139 1)
	{
		return 109.Method1939(1, null);
	}

	// Token: 0x0600073C RID: 1852 RVA: 0x00019180 File Offset: 0x00017380
	public static 109 Method1939(139 1, [241(2)] 554 2)
	{
		if (1.GetTokenType() == 216.None && !1.Read())
		{
			throw 141.Method12886(1, "Error reading JArray from JsonReader.");
		}
		1.Method2847();
		if (1.GetTokenType() != 216.StartArray)
		{
			throw 141.Method12886(1, "Error reading JArray from JsonReader. Current JsonReader item is not an array: {0}".Method6825(CultureInfo.InvariantCulture, 1.GetTokenType()));
		}
		109 3 = new 109();
		3.Method14343(1 as 99, 2);
		3.Method7269(1, 2);
		return 3;
	}

	// Token: 0x0600073D RID: 1853 RVA: 0x000191F4 File Offset: 0x000173F4
	public static 109 Method1941(string 1)
	{
		return 109.Method1941(1, null);
	}

	// Token: 0x0600073E RID: 1854 RVA: 0x00019200 File Offset: 0x00017400
	public static 109 Method1941(string 1, [241(2)] 554 2)
	{
		139 3 = new 167(new StringReader(1));
		109 result;
		try
		{
			109 4 = 109.Method1939(3, 2);
			while (3.Read())
			{
			}
			result = 4;
		}
		finally
		{
			((IDisposable)3).Dispose();
		}
		return result;
	}

	// Token: 0x0600073F RID: 1855 RVA: 0x00019248 File Offset: 0x00017448
	public static 109 Method1943(object 1)
	{
		return 109.Method1943(1, 158.Method3835());
	}

	// Token: 0x06000740 RID: 1856 RVA: 0x00019258 File Offset: 0x00017458
	public static 109 Method1943(object 1, 158 2)
	{
		226 3 = 226.Method14342(1, 2);
		if (3.Type != 705.Array)
		{
			throw new ArgumentException("Object serialized to {0}. JArray instance expected.".Method6825(CultureInfo.InvariantCulture, 3.Type));
		}
		return (109)3;
	}

	// Token: 0x06000741 RID: 1857 RVA: 0x0001929C File Offset: 0x0001749C
	public override void WriteTo(173 1, params 214[] 2)
	{
		1.WriteStartArray();
		for (int i = 0; i < this.list.Count; i++)
		{
			this.list[i].WriteTo(1, 2);
		}
		1.WriteEndArray();
	}

	// Token: 0x06000742 RID: 1858 RVA: 0x000192DE File Offset: 0x000174DE
	[242(2)]
	internal override int Method14291(226 1)
	{
		if (1 == null)
		{
			return -1;
		}
		return this.list.Method3176(1);
	}

	// Token: 0x06000743 RID: 1859 RVA: 0x000192F4 File Offset: 0x000174F4
	internal override void Method14294(object 1, [241(2)] 793 2)
	{
		IEnumerable enumerable = (base.Method7242(1) || 1 is 109) ? ((IEnumerable)1) : null;
		if (enumerable != null)
		{
			111.Method7313(this, enumerable, 2);
		}
	}

	// Token: 0x06000744 RID: 1860 RVA: 0x00019327 File Offset: 0x00017527
	public int IndexOf(226 1)
	{
		return this.Method14291(1);
	}

	// Token: 0x06000745 RID: 1861 RVA: 0x00019330 File Offset: 0x00017530
	public void Insert(int 1, 226 2)
	{
		this.Method14292(1, 2, false, true);
	}

	// Token: 0x06000746 RID: 1862 RVA: 0x0001933D File Offset: 0x0001753D
	public void RemoveAt(int 1)
	{
		this.Method14290(1);
	}

	// Token: 0x06000747 RID: 1863 RVA: 0x00019348 File Offset: 0x00017548
	public IEnumerator<226> GetEnumerator()
	{
		return this.Children().GetEnumerator();
	}

	// Token: 0x06000748 RID: 1864 RVA: 0x00019363 File Offset: 0x00017563
	public void Add(226 1)
	{
		this.Method7256(1);
	}

	// Token: 0x06000749 RID: 1865 RVA: 0x0001936C File Offset: 0x0001756C
	public void Clear()
	{
		this.Method14295();
	}

	// Token: 0x0600074A RID: 1866 RVA: 0x00019374 File Offset: 0x00017574
	public bool Contains(226 1)
	{
		return this.Method14293(1);
	}

	// Token: 0x0600074B RID: 1867 RVA: 0x0001937D File Offset: 0x0001757D
	public void CopyTo(226[] 1, int 2)
	{
		this.Method7253(1, 2);
	}

	// Token: 0x0600074C RID: 1868 RVA: 0x00019387 File Offset: 0x00017587
	public bool Remove(226 1)
	{
		return this.Method14289(1);
	}

	// Token: 0x0600074D RID: 1869 RVA: 0x00019390 File Offset: 0x00017590
	internal override int Method14364()
	{
		return base.Method7272();
	}

	// Token: 0x04000499 RID: 1177
	private readonly List<226> list = new List<226>();
}
