using System;
using System.Collections.Generic;

// Token: 0x02000AE2 RID: 2786
public abstract class 1508<TItem> where TItem : struct, IEquatable<!0>
{
	// Token: 0x06004DA6 RID: 19878 RVA: 0x001EC4AC File Offset: 0x001EA6AC
	public 1508(int 1, int 2)
	{
		if (1304.226)
		{
			2 = 1;
		}
		this.7 = 1;
		this.8 = 2;
	}

	// Token: 0x06004DA7 RID: 19879 RVA: 0x001EC4EA File Offset: 0x001EA6EA
	public int 1()
	{
		return this.7;
	}

	// Token: 0x06004DA8 RID: 19880 RVA: 0x001EC4F2 File Offset: 0x001EA6F2
	private 1509<TItem> 2()
	{
		return this.1[this.4];
	}

	// Token: 0x06004DA9 RID: 19881 RVA: 0x001EC508 File Offset: 0x001EA708
	~1508()
	{
		this.4(false);
	}

	// Token: 0x06004DAA RID: 19882 RVA: 0x001EC538 File Offset: 0x001EA738
	public void 3()
	{
		GC.SuppressFinalize(this);
		this.4(true);
	}

	// Token: 0x06004DAB RID: 19883 RVA: 0x001EC548 File Offset: 0x001EA748
	protected void 4(bool 1)
	{
		if (!1)
		{
			return;
		}
		foreach (1509<TItem> 2 in this.1)
		{
			2.Dispose();
		}
	}

	// Token: 0x06004DAC RID: 19884 RVA: 0x001EC59C File Offset: 0x001EA79C
	public void Reset()
	{
		this.2 = -1;
		this.4 = 0;
		this.5 = 0;
		this.6 = 0;
	}

	// Token: 0x06004DAD RID: 19885
	protected abstract 1509<TItem> CreateBuffer();

	// Token: 0x06004DAE RID: 19886 RVA: 0x001EC5BC File Offset: 0x001EA7BC
	public void 5(TItem 1)
	{
		while (this.4 >= this.1.Count)
		{
			this.1.Add(this.CreateBuffer());
		}
		1509<TItem> 2 = this.2();
		if (!2.1[this.5].Equals(1))
		{
			if (this.2 == -1)
			{
				this.2 = this.5;
			}
			this.3 = this.5 + 1;
		}
		2.1[this.5] = 1;
		this.5++;
		if (this.5 >= 2.1.Length)
		{
			this.6();
			this.6 = (this.5 = 0);
		}
	}

	// Token: 0x06004DAF RID: 19887 RVA: 0x001EC680 File Offset: 0x001EA880
	public void 6()
	{
		if (this.5 != this.6)
		{
			1509<TItem> <<EMPTY_NAME>> = this.2();
			if (this.2 >= 0)
			{
				<<EMPTY_NAME>>.7(this.2, this.3);
			}
			<<EMPTY_NAME>>.5(this.6, this.5);
			this.4 = (this.4 + 1) % this.8;
			this.5 = 0;
			this.6 = this.5;
			this.2 = -1;
		}
	}

	// Token: 0x040039E8 RID: 14824
	internal List<1509<TItem>> 1 = new List<1509<TItem>>();

	// Token: 0x040039E9 RID: 14825
	private int 2 = -1;

	// Token: 0x040039EA RID: 14826
	private int 3 = -1;

	// Token: 0x040039EB RID: 14827
	private int 4;

	// Token: 0x040039EC RID: 14828
	private int 5;

	// Token: 0x040039ED RID: 14829
	private int 6;

	// Token: 0x040039EE RID: 14830
	private int 7;

	// Token: 0x040039EF RID: 14831
	private int 8;
}
