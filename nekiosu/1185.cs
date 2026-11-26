using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

// Token: 0x02000BE0 RID: 3040
[ComVisible(false)]
public sealed class 1185<TItem> : List<TItem>
{
	// Token: 0x0600530F RID: 21263 RVA: 0x00209FFA File Offset: 0x002081FA
	public 1185()
	{
	}

	// Token: 0x06005310 RID: 21264 RVA: 0x0020A00D File Offset: 0x0020820D
	public 1185(List<TItem> 1) : base(1)
	{
	}

	// Token: 0x06005311 RID: 21265 RVA: 0x0020A024 File Offset: 0x00208224
	public bool 1(TItem 1)
	{
		object obj = this.1;
		bool result;
		lock (obj)
		{
			result = base.Remove(1);
		}
		return result;
	}

	// Token: 0x06005312 RID: 21266 RVA: 0x0020A068 File Offset: 0x00208268
	public void 2(TItem 1)
	{
		object obj = this.1;
		lock (obj)
		{
			base.Add(1);
		}
	}

	// Token: 0x06005313 RID: 21267 RVA: 0x0020A0AC File Offset: 0x002082AC
	public void 3(Action<TItem> 1)
	{
		this.5().ForEach(1);
	}

	// Token: 0x06005314 RID: 21268 RVA: 0x0020A0BC File Offset: 0x002082BC
	public void 4()
	{
		object obj = this.1;
		lock (obj)
		{
			base.Clear();
		}
	}

	// Token: 0x06005315 RID: 21269 RVA: 0x0020A0FC File Offset: 0x002082FC
	public List<TItem> 5()
	{
		object obj = this.1;
		List<TItem> result;
		lock (obj)
		{
			result = new List<TItem>(this);
		}
		return result;
	}

	// Token: 0x04003F36 RID: 16182
	public object 1 = new object();
}
