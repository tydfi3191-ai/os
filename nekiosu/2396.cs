using System;
using System.Collections.Generic;

// Token: 0x02000604 RID: 1540
public sealed class 2396 : 2387
{
	// Token: 0x06002F2D RID: 12077 RVA: 0x0010B328 File Offset: 0x00109528
	internal 2396(2440 1, 2450 2 = (2450)0) : base(1, 2)
	{
		base.2((2451)14);
	}

	// Token: 0x06002F2E RID: 12078 RVA: 0x0010B35C File Offset: 0x0010955C
	internal override bool CaptureBackup()
	{
		2123 <<EMPTY_NAME>> = this.8[0] as 2123;
		if (<<EMPTY_NAME>> != null)
		{
			this.14 = <<EMPTY_NAME>>.5;
			this.15.Add(new 2440.2441(<<EMPTY_NAME>>.84));
			this.16.AddRange(<<EMPTY_NAME>>.85);
			this.17.AddRange(<<EMPTY_NAME>>.86);
			return true;
		}
		return false;
	}

	// Token: 0x06002F2F RID: 12079 RVA: 0x0010B3C8 File Offset: 0x001095C8
	internal override void Release()
	{
		this.14 = -1;
		this.11.Add(this.15);
		this.11.Add(this.16);
		this.11.Add(this.17);
		base.Release();
	}

	// Token: 0x06002F30 RID: 12080 RVA: 0x0010B415 File Offset: 0x00109615
	internal override bool HasChanged()
	{
		return this.8.Count > 0 && ((2123)this.8[0]).5 != this.14;
	}

	// Token: 0x06002F31 RID: 12081 RVA: 0x0010B448 File Offset: 0x00109648
	internal override void Apply(2457 1)
	{
		2123 2 = this.8[0] as 2123;
		if (2 != null)
		{
			177.Method12592<1245>(this.15[0].1, 2.84);
			177.Method12592<1254>(this.16, 2.85);
			177.Method12592<1254>(this.17, 2.86);
			int 3 = 2.5;
			2.5 = this.14;
			this.14 = 3;
			2.RebuildPathAndTiming(true);
		}
	}

	// Token: 0x04002230 RID: 8752
	private int 14;

	// Token: 0x04002231 RID: 8753
	private new List<2440.2441> 15 = new List<2440.2441>();

	// Token: 0x04002232 RID: 8754
	private new List<1254> 16 = new List<1254>();

	// Token: 0x04002233 RID: 8755
	private new List<1254> 17 = new List<1254>();
}
