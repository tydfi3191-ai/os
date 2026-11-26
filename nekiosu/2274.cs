using System;
using System.Collections.Generic;

// Token: 0x02000584 RID: 1412
public sealed class 2274 : IComparer<2274>, IComparable<2274>
{
	// Token: 0x06002BB4 RID: 11188 RVA: 0x000EF714 File Offset: 0x000ED914
	internal 2274()
	{
	}

	// Token: 0x06002BB5 RID: 11189 RVA: 0x000EF741 File Offset: 0x000ED941
	public int Compare(2274 1, 2274 2)
	{
		return 2.CompareTo(1);
	}

	// Token: 0x06002BB6 RID: 11190 RVA: 0x000EF74C File Offset: 0x000ED94C
	public int CompareTo(2274 1)
	{
		if (1.1 < this.1)
		{
			return 1;
		}
		if (1.1 > this.1)
		{
			return -1;
		}
		if (1.2 < this.2)
		{
			return 1;
		}
		if (1.2 > this.2)
		{
			return -1;
		}
		return 0;
	}

	// Token: 0x06002BB7 RID: 11191 RVA: 0x000EF79C File Offset: 0x000ED99C
	public 2274 Clone()
	{
		return new 2274
		{
			6 = this.6,
			4 = this.4,
			5 = this.5,
			2 = this.2,
			1 = this.1,
			3 = this.3
		};
	}

	// Token: 0x04001FFF RID: 8191
	internal int 1;

	// Token: 0x04002000 RID: 8192
	internal double 2;

	// Token: 0x04002001 RID: 8193
	internal double 3;

	// Token: 0x04002002 RID: 8194
	internal double 4 = -1.0;

	// Token: 0x04002003 RID: 8195
	internal bool 5 = true;

	// Token: 0x04002004 RID: 8196
	internal double 6 = 1.0;
}
