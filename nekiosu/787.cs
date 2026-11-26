using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

// Token: 0x020001C6 RID: 454
[107]
[241(0)]
[242(1)]
[ComVisible(false)]
public struct 787<[241(0)] TItem> : 411<!0>, IEnumerable<!0>, IEnumerable, IEquatable<787<!0>> where TItem : 226
{
	// Token: 0x170000CB RID: 203
	public 411<226> this[object 1]
	{
		get
		{
			if (this._iEnumerable10042 == null)
			{
				return 787<226>._recoveredType235310041;
			}
			return new 787<226>(this._iEnumerable10042.Method5753(1));
		}
	}

	// Token: 0x06000E77 RID: 3703 RVA: 0x00030DB4 File Offset: 0x0002EFB4
	public 787(IEnumerable<TItem> 1)
	{
		756.Method12216(1, "enumerable");
		this._iEnumerable10042 = 1;
	}

	// Token: 0x06000E78 RID: 3704 RVA: 0x00030DC8 File Offset: 0x0002EFC8
	public IEnumerator<TItem> GetEnumerator()
	{
		return ((IEnumerable<TItem>)(this._iEnumerable10042 ?? 787<TItem>._recoveredType235310041)).GetEnumerator();
	}

	// Token: 0x06000E79 RID: 3705 RVA: 0x00030DE8 File Offset: 0x0002EFE8
	private IEnumerator Method12883()
	{
		return this.GetEnumerator();
	}

	// Token: 0x06000E7A RID: 3706 RVA: 0x00030DF0 File Offset: 0x0002EFF0
	IEnumerator IEnumerable.GetEnumerator()
	{
		return this.Method12883();
	}

	// Token: 0x06000E7B RID: 3707 RVA: 0x00030DF8 File Offset: 0x0002EFF8
	public bool Equals([241(new byte[]
	{
		0,
		1
	})] 787<TItem> 1)
	{
		return object.Equals(this._iEnumerable10042, 1._iEnumerable10042);
	}

	// Token: 0x06000E7C RID: 3708 RVA: 0x00030E0C File Offset: 0x0002F00C
	[242(2)]
	public override bool Equals(object 1)
	{
		if (1 is 787<TItem>)
		{
			787<TItem> 2 = (787<TItem>)1;
			return this.Equals(2);
		}
		return false;
	}

	// Token: 0x06000E7D RID: 3709 RVA: 0x00030E31 File Offset: 0x0002F031
	public override int GetHashCode()
	{
		if (this._iEnumerable10042 == null)
		{
			return 0;
		}
		return this._iEnumerable10042.GetHashCode();
	}

	// Token: 0x04000716 RID: 1814
	[241(new byte[]
	{
		0,
		1
	})]
	public static readonly 787<TItem> _recoveredType235310041 = new 787<TItem>(Enumerable.Empty<TItem>());

	// Token: 0x04000717 RID: 1815
	private readonly IEnumerable<TItem> _iEnumerable10042;
}
