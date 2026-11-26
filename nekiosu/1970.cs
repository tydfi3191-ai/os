using System;
using System.Collections.Generic;

// Token: 0x02000783 RID: 1923
public sealed class 1970 : 2070
{
	// Token: 0x06003872 RID: 14450 RVA: 0x001621F0 File Offset: 0x001603F0
	internal 1970(2039 1, int 2, int 3, 1245 4, 1965 5, bool[] 6) : base(1, 2, 3, 4)
	{
		this.44 = 6;
		for (int i = 0; i < 6.Length; i++)
		{
			if (6[i])
			{
				this.45++;
			}
		}
		this.46 = 5;
		if (this.45 == this.28.41.19.Count)
		{
			this.46 &= (1965)(-3);
		}
		this.43 = new List<1979>();
	}

	// Token: 0x06003873 RID: 14451 RVA: 0x00162274 File Offset: 0x00160474
	internal new void 9()
	{
		if ((this.46 & (1965)8192) > (1965)0)
		{
			this.10(0, this.1, this.2);
			return;
		}
		if (this.2 - this.1 < 100)
		{
			if (this.28.41.19.Count != 8)
			{
				this.10(this.11(0), this.1, this.1);
				return;
			}
			if (this.4.2(1245.Finish) && this.2 - this.1 < 1000)
			{
				this.10(0, this.1, this.1);
				return;
			}
			this.10(this.11(this.28.41.43()), this.1, this.1);
			return;
		}
		else
		{
			if (this.28.41.19.Count != 8)
			{
				this.10(this.11(0), this.1, this.2);
				return;
			}
			if (this.4.2(1245.Finish) && this.2 - this.1 < 1000)
			{
				this.10(0, this.1, this.2);
				return;
			}
			this.10(this.11(this.28.41.43()), this.1, this.2);
			return;
		}
	}

	// Token: 0x06003874 RID: 14452 RVA: 0x001623DC File Offset: 0x001605DC
	private new void 10(int 1, int 2, int 3)
	{
		if (2 == 3)
		{
			1979 item = new 1979(this.28, 1, 2, this.4)
			{
				35 = this.35,
				36 = this.36,
				37 = this.37,
				34 = this.34,
				50 = 1
			};
			this.43.Add(item);
			return;
		}
		1978 item2 = new 1978(this.28, 1, 2, 3, 1245.Normal)
		{
			57 = 1245.Normal,
			56 = this.4,
			35 = this.35,
			36 = this.36,
			58 = this.35,
			59 = this.36,
			37 = this.37,
			34 = this.34,
			50 = 1
		};
		this.43.Add(item2);
	}

	// Token: 0x06003875 RID: 14453 RVA: 0x001624C4 File Offset: 0x001606C4
	private new int 11(int 1)
	{
		1971 2 = this.28.33 as 1971;
		int num = 2.2.Next(1, this.28.41.19.Count);
		if ((this.46 & (1965)2) > (1965)0)
		{
			while (this.44[num])
			{
				num = 2.2.Next(1, this.28.41.19.Count);
			}
		}
		return num;
	}

	// Token: 0x06003876 RID: 14454 RVA: 0x00053ADC File Offset: 0x00051CDC
	public override int GetComboNumber()
	{
		throw new NotImplementedException();
	}

	// Token: 0x06003877 RID: 14455 RVA: 0x00053ADC File Offset: 0x00051CDC
	public override void SetComboNumber(int 1)
	{
		throw new NotImplementedException();
	}

	// Token: 0x06003878 RID: 14456 RVA: 0x00053ADC File Offset: 0x00051CDC
	public override 208 GetEndPosition()
	{
		throw new NotImplementedException();
	}

	// Token: 0x06003879 RID: 14457 RVA: 0x00053ADC File Offset: 0x00051CDC
	public override void SetEndPosition(208 1)
	{
		throw new NotImplementedException();
	}

	// Token: 0x0600387A RID: 14458 RVA: 0x00053ADC File Offset: 0x00051CDC
	internal override bool IsActive()
	{
		throw new NotImplementedException();
	}

	// Token: 0x0600387B RID: 14459 RVA: 0x00053ADC File Offset: 0x00051CDC
	internal override void SetComboColour(198 1)
	{
		throw new NotImplementedException();
	}

	// Token: 0x0600387C RID: 14460 RVA: 0x00053ADC File Offset: 0x00051CDC
	internal override 2149 GetOrCalculateJudgement()
	{
		throw new NotImplementedException();
	}

	// Token: 0x0600387D RID: 14461 RVA: 0x00053ADC File Offset: 0x00051CDC
	internal override 2034 Clone()
	{
		throw new NotImplementedException();
	}

	// Token: 0x0600387E RID: 14462 RVA: 0x00053ADC File Offset: 0x00051CDC
	internal override void OnSelected()
	{
		throw new NotImplementedException();
	}

	// Token: 0x0600387F RID: 14463 RVA: 0x00053ADC File Offset: 0x00051CDC
	internal override void OnDeselected()
	{
		throw new NotImplementedException();
	}

	// Token: 0x06003880 RID: 14464 RVA: 0x00053ADC File Offset: 0x00051CDC
	internal override void SetStartTime(int 1)
	{
		throw new NotImplementedException();
	}

	// Token: 0x06003881 RID: 14465 RVA: 0x00053ADC File Offset: 0x00051CDC
	internal override void SetPosition(208 1, bool 2 = false)
	{
		throw new NotImplementedException();
	}

	// Token: 0x06003882 RID: 14466 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal override 2149 JudgeAtPosition(208 1)
	{
		return (2149)0;
	}

	// Token: 0x06003883 RID: 14467 RVA: 0x00053ADC File Offset: 0x00051CDC
	internal override void SetEndTime(int 1)
	{
		throw new NotImplementedException();
	}

	// Token: 0x040029B9 RID: 10681
	internal List<1979> 43;

	// Token: 0x040029BA RID: 10682
	private bool[] 44;

	// Token: 0x040029BB RID: 10683
	private int 45;

	// Token: 0x040029BC RID: 10684
	private 1965 46;
}
