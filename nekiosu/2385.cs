using System;
using System.Collections.Generic;

// Token: 0x020005F9 RID: 1529
public class 2385 : 2387
{
	// Token: 0x06002EF5 RID: 12021 RVA: 0x0010A4F7 File Offset: 0x001086F7
	internal 2385(2440 1, 2450 2 = (2450)0) : base(1, 2)
	{
	}

	// Token: 0x06002EF6 RID: 12022 RVA: 0x00053ADC File Offset: 0x00051CDC
	internal override bool CaptureBackup()
	{
		throw new NotImplementedException();
	}

	// Token: 0x06002EF7 RID: 12023 RVA: 0x00053ADC File Offset: 0x00051CDC
	internal override bool HasChanged()
	{
		throw new NotImplementedException();
	}

	// Token: 0x06002EF8 RID: 12024 RVA: 0x00053ADC File Offset: 0x00051CDC
	internal override void Apply(2457 1)
	{
		throw new NotImplementedException();
	}

	// Token: 0x06002EF9 RID: 12025 RVA: 0x0010A504 File Offset: 0x00108704
	protected void 19<T>(2123 1, List<T> 2)
	{
		if (2.Count == 0)
		{
			1.85.Clear();
			1.84.Clear();
			1.86.Clear();
			1.73 = true;
			return;
		}
		if (2.Equals(1.84))
		{
			if (1.85.Count == 0)
			{
				for (int i = 0; i < 1.85.Count; i++)
				{
					1.85.Add(1.35);
					1.86.Add(1.35);
				}
			}
			1.73 = false;
			return;
		}
		List<1254> list = (!2.Equals(1.85)) ? 1.85 : 1.86;
		if (list.Count == 0)
		{
			for (int j = 0; j < 1.85.Count; j++)
			{
				list.Add(1.35);
				1.84.Add(1.4);
			}
			1.73 = false;
		}
	}

	// Token: 0x0400221F RID: 8735
	protected List<2440.2442> 14;

	// Token: 0x04002220 RID: 8736
	protected new List<2440.2442> 15;

	// Token: 0x04002221 RID: 8737
	protected new List<2440.2442> 16;

	// Token: 0x04002222 RID: 8738
	protected new List<2440.2442> 17;

	// Token: 0x04002223 RID: 8739
	protected new List<2440.2441> 18;

	// Token: 0x04002224 RID: 8740
	protected List<2440.2441> 19;
}
