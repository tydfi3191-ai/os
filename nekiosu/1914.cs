using System;
using System.Collections.Generic;

// Token: 0x0200085A RID: 2138
public abstract class 1914
{
	// Token: 0x06003DFF RID: 15871 RVA: 0x001850C7 File Offset: 0x001832C7
	protected 1914(2023 1)
	{
		this.1 = 1;
	}

	// Token: 0x06003E00 RID: 15872 RVA: 0x001850E4 File Offset: 0x001832E4
	public void 1(1896 1)
	{
		double item = this.StrainValueAt(1);
		this.2.Add(item);
	}

	// Token: 0x06003E01 RID: 15873 RVA: 0x00185105 File Offset: 0x00183305
	public IReadOnlyList<double> 2()
	{
		return this.2;
	}

	// Token: 0x06003E02 RID: 15874
	protected abstract double StrainValueAt(1896 1);

	// Token: 0x06003E03 RID: 15875
	public abstract double DifficultyValue();

	// Token: 0x04002D72 RID: 11634
	protected readonly 2023 1;

	// Token: 0x04002D73 RID: 11635
	protected readonly List<double> 2 = new List<double>();
}
