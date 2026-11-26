using System;

// Token: 0x020005A5 RID: 1445
public sealed class 2332
{
	// Token: 0x06002CEC RID: 11500 RVA: 0x000FAEE9 File Offset: 0x000F90E9
	internal 2332(2263 1, 1318 2 = null) : this(1, (2337)((2 != null) ? 2.6() : 1304.145.6()))
	{
		this.5 = 2;
	}

	// Token: 0x06002CED RID: 11501 RVA: 0x000FAF10 File Offset: 0x000F9110
	internal 2332(2263 1, 2337 2)
	{
		this.3 = 1;
		this.3(2, false);
	}

	// Token: 0x06002CEE RID: 11502 RVA: 0x000FAF71 File Offset: 0x000F9171
	public 2337 1()
	{
		return this.4;
	}

	// Token: 0x06002CEF RID: 11503 RVA: 0x000FAF79 File Offset: 0x000F9179
	protected void 2(2337 1)
	{
		this.4 = 1;
	}

	// Token: 0x06002CF0 RID: 11504 RVA: 0x000FAF84 File Offset: 0x000F9184
	internal void 3(2337 1, bool 2)
	{
		1 = 2332.6(1);
		if (this.1() != 1)
		{
			this.2(1);
			if (this.5 != null)
			{
				this.5.7((int)this.1());
			}
			if (2)
			{
				1763.2("Grid Size: " + 1.ToString(), 1000, (1389)0);
			}
			1662.8.19(1);
		}
	}

	// Token: 0x06002CF1 RID: 11505 RVA: 0x000FAFF2 File Offset: 0x000F91F2
	internal int 4(float 1)
	{
		return (int)((2337)Math.Round((double)(1 / (float)this.1())) * this.1());
	}

	// Token: 0x06002CF2 RID: 11506 RVA: 0x000FB00C File Offset: 0x000F920C
	internal void 5()
	{
		if (this.1() < (2337)1 || !this.6)
		{
			return;
		}
		float num = 1662.69.9() * (float)this.1();
		208 <<EMPTY_NAME>> = 1662.69.5();
		1662.20.2();
		bool flag = false;
		for (float num2 = 0f; num2 <= 1662.69.1() + 1f; num2 += num)
		{
			if (!flag && num2 >= 1662.69.1() / 2f - 1f)
			{
				flag = true;
				1662.20.3(new 208(num2, 0f) + <<EMPTY_NAME>>, this.2);
				1662.20.3(new 208(num2, 1662.69.3()) + <<EMPTY_NAME>>, this.2);
			}
			else
			{
				1662.20.3(new 208(num2, 0f) + <<EMPTY_NAME>>, this.1);
				1662.20.3(new 208(num2, 1662.69.3()) + <<EMPTY_NAME>>, this.1);
			}
		}
		flag = false;
		for (float num3 = 0f; num3 <= 1662.69.3() + 1f; num3 += num)
		{
			if (!flag && num3 >= 1662.69.3() / 2f - 1f)
			{
				flag = true;
				1662.20.3(new 208(0f, num3) + <<EMPTY_NAME>>, this.2);
				1662.20.3(new 208(1662.69.1(), num3) + <<EMPTY_NAME>>, this.2);
			}
			else
			{
				1662.20.3(new 208(0f, num3) + <<EMPTY_NAME>>, this.1);
				1662.20.3(new 208(1662.69.1(), num3) + <<EMPTY_NAME>>, this.1);
			}
		}
		if (this.3.26 == 2335.Design)
		{
			float num4 = (float)((int)((float)1662.70.1 * 1662.69.10()));
			float num5 = (float)((int)((float)1662.70.2 * 1662.69.10()));
			float num6 = ((float)1662.70.1 - num4) / 2f + (float)1662.70.4();
			float num7 = ((float)1662.70.2 - num5) / 4f * 3f;
			num4 = 640f * 1662.69.9();
			num5 = 480f * 1662.69.9();
			1662.20.3(new 208(num6, num7), this.1);
			1662.20.3(new 208(num6 + num4, num7), this.1);
			1662.20.3(new 208(num6 + num4, num7), this.1);
			1662.20.3(new 208(num6 + num4, num7 + num5), this.1);
			1662.20.3(new 208(num6 + num4, num7 + num5), this.1);
			1662.20.3(new 208(num6, num7 + num5), this.1);
			1662.20.3(new 208(num6, num7 + num5), this.1);
			1662.20.3(new 208(num6, num7), this.1);
		}
		1662.20.4();
	}

	// Token: 0x06002CF3 RID: 11507 RVA: 0x000FB397 File Offset: 0x000F9597
	internal static 2337 6(2337 1)
	{
		return (2337)1052.18((int)1, 4, 32);
	}

	// Token: 0x06002CF4 RID: 11508 RVA: 0x000FB3A4 File Offset: 0x000F95A4
	internal static 2337 7(2337 1)
	{
		2337 2 = 1 * (2337)2;
		if (2 > 2337.Large)
		{
			return 2337.Tiny;
		}
		return 2;
	}

	// Token: 0x0400210F RID: 8463
	protected 198 1 = new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 25);

	// Token: 0x04002110 RID: 8464
	protected 198 2 = new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 75);

	// Token: 0x04002111 RID: 8465
	private 2263 3;

	// Token: 0x04002112 RID: 8466
	private 2337 4;

	// Token: 0x04002113 RID: 8467
	protected 1318 5;

	// Token: 0x04002114 RID: 8468
	internal bool 6 = true;
}
