using System;
using System.Collections.Generic;

// Token: 0x020007AE RID: 1966
public sealed class 1958 : 1896
{
	// Token: 0x1700029D RID: 669
	// (get) Token: 0x0600396D RID: 14701 RVA: 0x0016A4E7 File Offset: 0x001686E7
	// (set) Token: 0x0600396E RID: 14702 RVA: 0x0016A4EF File Offset: 0x001686EF
	public int columnIndex { get; private set; }

	// Token: 0x1700029E RID: 670
	// (get) Token: 0x0600396F RID: 14703 RVA: 0x0016A4F8 File Offset: 0x001686F8
	// (set) Token: 0x06003970 RID: 14704 RVA: 0x0016A500 File Offset: 0x00168700
	public 1958[] latestPerColumn { get; private set; }

	// Token: 0x1700029F RID: 671
	// (get) Token: 0x06003971 RID: 14705 RVA: 0x0016A509 File Offset: 0x00168709
	// (set) Token: 0x06003972 RID: 14706 RVA: 0x0016A511 File Offset: 0x00168711
	public double timeSincePreviousInColumn { get; private set; }

	// Token: 0x06003973 RID: 14707 RVA: 0x0016A51A File Offset: 0x0016871A
	public 1958(2034 1, 2034 2, double 3, List<1896> 4, List<1896>[] 5, int 6, int 7) : base(1, 2, 3, 4, 6, 0.0)
	{
		this.3(4, 5, 6, 7);
	}

	// Token: 0x06003974 RID: 14708 RVA: 0x0016A540 File Offset: 0x00168740
	public 1958(double 1, double 2, double 3, double 4, List<1896> 5, List<1896>[] 6, int 7, int 8) : base(1, 2, 3, 4, 5, 7)
	{
		this.3(5, 6, 7, 8);
	}

	// Token: 0x06003975 RID: 14709 RVA: 0x0016A560 File Offset: 0x00168760
	private new void 3(List<1896> 1, List<1896>[] 2, int 3, int 4)
	{
		int num = 2.Length;
		this.9 = 2;
		this.columnIndex = 4;
		this.10 = 2[this.columnIndex].Count;
		this.latestPerColumn = new 1958[num];
		double 5 = this.5;
		1958 6 = this.4(0);
		this.timeSincePreviousInColumn = ((5 - ((6 != null) ? new double?(6.5) : null)) ?? this.5);
		if (3 > 0)
		{
			1958 7 = (1958)1[3 - 1];
			for (int i = 0; i < 7.latestPerColumn.Length; i++)
			{
				this.latestPerColumn[i] = 7.latestPerColumn[i];
			}
			this.latestPerColumn[7.columnIndex] = 7;
		}
	}

	// Token: 0x06003976 RID: 14710 RVA: 0x0016A65C File Offset: 0x0016885C
	public new 1958 4(int 1)
	{
		int num = this.10 - (1 + 1);
		if (num < 0 || num >= this.9[this.columnIndex].Count)
		{
			return null;
		}
		return (1958)this.9[this.columnIndex][num];
	}

	// Token: 0x04002A8E RID: 10894
	private List<1896>[] 9;

	// Token: 0x04002A8F RID: 10895
	private int 10;
}
