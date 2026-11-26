using System;
using System.Collections.Generic;
using System.Diagnostics;

// Token: 0x02000862 RID: 2146
public sealed class 1924<TItem, TItem2>
{
	// Token: 0x06003E25 RID: 15909 RVA: 0x001858FD File Offset: 0x00183AFD
	[DebuggerHidden]
	public 1924(TItem 1, TItem2 2)
	{
		this.1 = 1;
		this.2 = 2;
	}

	// Token: 0x06003E26 RID: 15910 RVA: 0x00185914 File Offset: 0x00183B14
	[DebuggerHidden]
	public override bool Equals(object 1)
	{
		1924<TItem, TItem2> 2 = 1 as 1924<TItem, TItem2>;
		return this == 2 || (2 != null && EqualityComparer<TItem>.Default.Equals(this.1, 2.1) && EqualityComparer<TItem2>.Default.Equals(this.2, 2.2));
	}

	// Token: 0x06003E27 RID: 15911 RVA: 0x00185961 File Offset: 0x00183B61
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (-84102249 + EqualityComparer<TItem>.Default.GetHashCode(this.1)) * -1521134295 + EqualityComparer<TItem2>.Default.GetHashCode(this.2);
	}

	// Token: 0x06003E28 RID: 15912 RVA: 0x00185990 File Offset: 0x00183B90
	[DebuggerHidden]
	public override string ToString()
	{
		string format = "{{ Type = {0}, Mods = {1} }}";
		object[] array = new object[2];
		TItem titem = this.1;
		array[0] = ((titem != null) ? titem.ToString() : null);
		TItem2 titem2 = this.2;
		array[1] = ((titem2 != null) ? titem2.ToString() : null);
		return string.Format(null, format, array);
	}

	// Token: 0x04002D8E RID: 11662
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly TItem 1;

	// Token: 0x04002D8F RID: 11663
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly TItem2 2;
}
