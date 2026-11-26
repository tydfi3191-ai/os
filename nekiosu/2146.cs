using System;

// Token: 0x02000708 RID: 1800
[276]
public sealed class 2146 : 2141
{
	// Token: 0x0600350E RID: 13582 RVA: 0x00147001 File Offset: 0x00145201
	public 2146(2486 1) : base(1)
	{
	}

	// Token: 0x0600350F RID: 13583 RVA: 0x0014700A File Offset: 0x0014520A
	internal override double CalculateHealthDrain()
	{
		return 0.0;
	}

	// Token: 0x06003510 RID: 13584 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void CreateHealthBar()
	{
	}

	// Token: 0x06003511 RID: 13585 RVA: 0x00147015 File Offset: 0x00145215
	internal override void UpdateModeState()
	{
		if (1226.69 && 1226.16 > this.8.68)
		{
			1226.24("count", 100, (1416)3, false);
		}
		base.UpdateModeState();
	}

	// Token: 0x06003512 RID: 13586 RVA: 0x00147048 File Offset: 0x00145248
	internal override void ApplyJudgement(2149 1, 2034 2)
	{
		2149 3 = 1;
		if (3 > (2149)0)
		{
			3 &= (2149)520095494;
		}
		if (1 >= (2149)0)
		{
			2241 4 = this.4;
			int 5 = this.4.13;
			2499 6 = this.3;
			int num = 6.GetCombo() + 1;
			6.SetCombo(num);
			4.13 = Math.Max(5, num);
			this.4.36 = (ushort)this.3.GetCombo();
			2136 7 = this.4 as 2136;
			float 8 = ((2131)2).52;
			7.68 += 8;
			int num2 = 0;
			if (3 <= (2149)514)
			{
				if (3 != (2149)256)
				{
					if (3 - (2149)512 <= 2)
					{
						num2 = 100;
						2241 9 = this.4;
						9.1 += 1;
					}
				}
				else
				{
					num2 = 50;
					2241 10 = this.4;
					10.3 += 1;
				}
			}
			else if (3 - (2149)1024 <= 2 || 3 == (2149)1028)
			{
				num2 = 300;
				2241 11 = this.4;
				11.2 += 1;
			}
			2.41 = num2;
			2241 12 = this.4;
			12.SetRawScore(12.GetScore() + (int)((double)(8 * (float)num2) * 1226.78() / 120.0));
			return;
		}
		2023 13 = 2023.NoFail;
		2023 14 = 2019.1;
		2023 15 = 13;
		if ((14 & 15) > 2023.None)
		{
			2241 16 = this.4;
			int num;
			this.3.SetCombo(num = 0);
			16.36 = (ushort)num;
			2241 17 = this.4;
			17.6 += 1;
			return;
		}
		this.8.12();
	}
}
