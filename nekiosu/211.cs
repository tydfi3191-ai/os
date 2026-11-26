using System;
using System.IO;
using System.Runtime.InteropServices;

// Token: 0x020002D9 RID: 729
[ComVisible(false)]
public sealed class 211 : 374
{
	// Token: 0x060015E2 RID: 5602 RVA: 0x0004BA62 File Offset: 0x00049C62
	public 211(string 1, long 2, long 3) : base(1)
	{
		this.SetMinSize(2);
		this.SetMaxSize(3);
	}

	// Token: 0x060015E3 RID: 5603 RVA: 0x0004BA88 File Offset: 0x00049C88
	public override bool Method11363(string 1)
	{
		bool flag = base.Method11363(1);
		if (flag)
		{
			long length = new FileInfo(1).Length;
			flag = (this.GetMinSize() <= length && this.GetMaxSize() >= length);
		}
		return flag;
	}

	// Token: 0x060015E4 RID: 5604 RVA: 0x0004BAC6 File Offset: 0x00049CC6
	public long GetMinSize()
	{
		return this.minSize;
	}

	// Token: 0x060015E5 RID: 5605 RVA: 0x0004BACE File Offset: 0x00049CCE
	public void SetMinSize(long 1)
	{
		if (1 < 0L || this.maxSize < 1)
		{
			throw new ArgumentOutOfRangeException("#=zUkSU2UA=");
		}
		this.minSize = 1;
	}

	// Token: 0x060015E6 RID: 5606 RVA: 0x0004BAF0 File Offset: 0x00049CF0
	public long GetMaxSize()
	{
		return this.maxSize;
	}

	// Token: 0x060015E7 RID: 5607 RVA: 0x0004BAF8 File Offset: 0x00049CF8
	public void SetMaxSize(long 1)
	{
		if (1 < 0L || this.minSize > 1)
		{
			throw new ArgumentOutOfRangeException("#=zUkSU2UA=");
		}
		this.maxSize = 1;
	}

	// Token: 0x04000A5D RID: 2653
	private long minSize;

	// Token: 0x04000A5E RID: 2654
	private long maxSize = long.MaxValue;
}
