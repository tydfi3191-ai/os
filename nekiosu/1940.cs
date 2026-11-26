using System;

// Token: 0x02000843 RID: 2115
public sealed class 1940
{
	// Token: 0x06003D65 RID: 15717 RVA: 0x001836E0 File Offset: 0x001818E0
	public 1940(double 1, bool 2)
	{
		this.Rate = 1;
		this.AdjustPitch = 2;
	}

	// Token: 0x170002CF RID: 719
	// (get) Token: 0x06003D66 RID: 15718 RVA: 0x001836F6 File Offset: 0x001818F6
	public double Rate { get; }

	// Token: 0x170002D0 RID: 720
	// (get) Token: 0x06003D67 RID: 15719 RVA: 0x001836FE File Offset: 0x001818FE
	public bool AdjustPitch { get; }

	// Token: 0x06003D68 RID: 15720 RVA: 0x00183706 File Offset: 0x00181906
	public string 1()
	{
		return 1939.22(this.Rate);
	}
}
