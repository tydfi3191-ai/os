using System;

// Token: 0x020007D6 RID: 2006
public sealed class 1843 : 1915
{
	// Token: 0x06003A53 RID: 14931 RVA: 0x00144AF4 File Offset: 0x00142CF4
	public 1843(2023 1) : base(1)
	{
	}

	// Token: 0x06003A54 RID: 14932 RVA: 0x00144B2B File Offset: 0x00142D2B
	protected override double GetStrainWeight()
	{
		return 1.0;
	}

	// Token: 0x06003A55 RID: 14933 RVA: 0x0016EEF9 File Offset: 0x0016D0F9
	protected override double GetDecayBase()
	{
		return 0.2;
	}

	// Token: 0x06003A56 RID: 14934 RVA: 0x0016EF04 File Offset: 0x0016D104
	protected override double GetDecayWeight()
	{
		return 0.94;
	}

	// Token: 0x06003A57 RID: 14935 RVA: 0x0016EF0F File Offset: 0x0016D10F
	protected override int GetSectionLength()
	{
		return 750;
	}

	// Token: 0x06003A58 RID: 14936 RVA: 0x0016EF16 File Offset: 0x0016D116
	protected override double CalculateObjectStrain(1896 1)
	{
		return 1844.1(1);
	}
}
