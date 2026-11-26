using System;
using System.Collections.Generic;

// Token: 0x020007C2 RID: 1986
public sealed class 1862 : 2070
{
	// Token: 0x060039DD RID: 14813 RVA: 0x0016D478 File Offset: 0x0016B678
	internal 1862(2039 1, int 2, int 3, 1245 4) : base(1, 2, 3, 4)
	{
		1870 5 = this.28.33 as 1870;
		bool flag = true;
		float num;
		for (num = (float)(3 - 2); num > 100f; num /= 2f)
		{
		}
		if (num > 0f)
		{
			int num2 = 0;
			for (float num3 = (float)2; num3 <= (float)3; num3 += num)
			{
				1860 item = new 1860(this.28, new 208((float)5.7.Next(0, 512), 0f), (int)num3, flag && this.IsNewCombo(), this.4, 5.3(), num2);
				this.43.Add(item);
				flag = false;
				num2++;
			}
		}
	}

	// Token: 0x060039DE RID: 14814 RVA: 0x00053ADC File Offset: 0x00051CDC
	public override int GetComboNumber()
	{
		throw new NotImplementedException();
	}

	// Token: 0x060039DF RID: 14815 RVA: 0x00053ADC File Offset: 0x00051CDC
	public override void SetComboNumber(int 1)
	{
		throw new NotImplementedException();
	}

	// Token: 0x060039E0 RID: 14816 RVA: 0x00053ADC File Offset: 0x00051CDC
	public override 208 GetEndPosition()
	{
		throw new NotImplementedException();
	}

	// Token: 0x060039E1 RID: 14817 RVA: 0x00053ADC File Offset: 0x00051CDC
	public override void SetEndPosition(208 1)
	{
		throw new NotImplementedException();
	}

	// Token: 0x060039E2 RID: 14818 RVA: 0x00053ADC File Offset: 0x00051CDC
	internal override bool IsActive()
	{
		throw new NotImplementedException();
	}

	// Token: 0x060039E3 RID: 14819 RVA: 0x00053ADC File Offset: 0x00051CDC
	internal override void SetComboColour(198 1)
	{
		throw new NotImplementedException();
	}

	// Token: 0x060039E4 RID: 14820 RVA: 0x00053ADC File Offset: 0x00051CDC
	internal override 2149 GetOrCalculateJudgement()
	{
		throw new NotImplementedException();
	}

	// Token: 0x060039E5 RID: 14821 RVA: 0x00053ADC File Offset: 0x00051CDC
	internal override 2034 Clone()
	{
		throw new NotImplementedException();
	}

	// Token: 0x060039E6 RID: 14822 RVA: 0x00053ADC File Offset: 0x00051CDC
	internal override void OnSelected()
	{
		throw new NotImplementedException();
	}

	// Token: 0x060039E7 RID: 14823 RVA: 0x00053ADC File Offset: 0x00051CDC
	internal override void OnDeselected()
	{
		throw new NotImplementedException();
	}

	// Token: 0x060039E8 RID: 14824 RVA: 0x00053ADC File Offset: 0x00051CDC
	internal override void SetStartTime(int 1)
	{
		throw new NotImplementedException();
	}

	// Token: 0x060039E9 RID: 14825 RVA: 0x00053ADC File Offset: 0x00051CDC
	internal override void SetPosition(208 1, bool 2 = false)
	{
		throw new NotImplementedException();
	}

	// Token: 0x060039EA RID: 14826 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal override 2149 JudgeAtPosition(208 1)
	{
		return (2149)0;
	}

	// Token: 0x060039EB RID: 14827 RVA: 0x00053ADC File Offset: 0x00051CDC
	internal override void SetEndTime(int 1)
	{
		throw new NotImplementedException();
	}

	// Token: 0x04002AC9 RID: 10953
	internal List<1860> 43 = new List<1860>();
}
