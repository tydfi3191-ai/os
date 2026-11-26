using System;

// Token: 0x020004E2 RID: 1250
[276]
public class 2546 : 2542
{
	// Token: 0x06002654 RID: 9812 RVA: 0x000BB2E3 File Offset: 0x000B94E3
	internal 2546(1803 1, 2039 2) : base(1, 2)
	{
	}

	// Token: 0x06002655 RID: 9813 RVA: 0x000BB2ED File Offset: 0x000B94ED
	protected new float 7()
	{
		return 9f * this.GetMeterScale();
	}

	// Token: 0x06002656 RID: 9814 RVA: 0x000BB2FC File Offset: 0x000B94FC
	internal override void BuildLayout()
	{
		float num = (float)(1662.70.1() / 3) * this.GetMeterScale();
		int num2 = (int)(num / (this.7() + 1f));
		float num3 = (num - (float)num2 * this.7() - (float)(num2 - 1)) * 1f / (float)(num2 - 1);
		if (1662.47)
		{
			num3 *= 3f;
		}
		int num4 = (int)Math.Round((double)base.4("count", 0f));
		if (num4 > 0)
		{
			num2 = num4;
			num3 = base.4("spacing", 2f) * 0.625f * this.GetMeterScale() - 1f;
			num = (float)num2 * this.7() + (float)(num2 - 1) * (1f + num3);
		}
		1433 <<EMPTY_NAME>> = new 1433(1662.34, (1376)6, 1065.BottomLeft, (1044)1, new 208(((float)1662.70.1() - num) / 2f, 480f), 0.8f, true, 198.Black, null);
		<<EMPTY_NAME>>.16 = 0.6f;
		<<EMPTY_NAME>>.20 = new 208(num, this.7() + 1f) * 1.6f;
		this.4.12(<<EMPTY_NAME>>);
		bool flag = base.3("shape", "square") == "circle";
		this.10 = new 1433[num2];
		this.11 = 0;
		float num5 = ((float)1662.70.1() - num) / 2f;
		for (int i = 0; i < num2; i++)
		{
			1433 2 = new 1433(flag ? 2532.Circle(64) : 1662.34, (1376)6, 1065.BottomLeft, (1044)1, new 208(num5, 480f), 0.9f, true, 198.Black, null);
			2.20 = new 208(this.7(), this.7()) * 1.6f / (flag ? 64f : 1f);
			this.4.12(2);
			this.10[i] = 2;
			num5 += this.7() + 1f + num3;
		}
	}

	// Token: 0x06002657 RID: 9815 RVA: 0x000BB518 File Offset: 0x000B9718
	internal new void 8()
	{
		1433[] array = this.10;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].16 -= 0.08f;
		}
	}

	// Token: 0x06002658 RID: 9816 RVA: 0x000BB550 File Offset: 0x000B9750
	internal override void OnJudged(2149 1)
	{
		this.6 = 1226.16 + 4000;
		base.6();
		198 2;
		if (1 < (2149)0)
		{
			2 = new 198(byte.MaxValue, 9, 9);
		}
		else
		{
			2149 3 = 1 & (2149)(-12648449);
			if (3 <= (2149)32768)
			{
				if (3 <= (2149)514)
				{
					if (3 == (2149)16 || 3 - (2149)256 <= 1)
					{
						2 = this.9;
						goto IL_15D;
					}
					if (3 - (2149)512 > 2)
					{
						return;
					}
				}
				else if (3 <= (2149)1028)
				{
					if (3 - (2149)1024 > 2 && 3 != (2149)1028)
					{
						return;
					}
					goto IL_E5;
				}
				else if (3 != (2149)2048)
				{
					if (3 != (2149)32768)
					{
						return;
					}
					goto IL_E5;
				}
				2 = this.8;
				goto IL_15D;
			}
			if (3 <= (2149)16777216)
			{
				if (3 != (2149)1048576 && 3 != (2149)2097152)
				{
					if (3 != (2149)16777216)
					{
						return;
					}
					2 = new 198(109, 120, 135);
					goto IL_15D;
				}
			}
			else if (3 <= (2149)67108864)
			{
				if (3 == (2149)33554432)
				{
					2 = new 198(31, 104, 198);
					goto IL_15D;
				}
				if (3 != (2149)67108864)
				{
					return;
				}
				2 = new 198(121, 208, 32);
				goto IL_15D;
			}
			else
			{
				if (3 == (2149)134217728)
				{
					2 = new 198(byte.MaxValue, 209, 55);
					goto IL_15D;
				}
				if (3 != (2149)268435456)
				{
					return;
				}
				2 = new 198(byte.MaxValue, 133, 0);
				goto IL_15D;
			}
			IL_E5:
			2 = this.7;
		}
		IL_15D:
		if (this.11 >= this.10.Length)
		{
			this.11 = 0;
		}
		this.8();
		this.10[this.11].6 = 2;
		this.10[this.11].16 = 1f;
		this.11++;
	}

	// Token: 0x04001B3E RID: 6974
	protected 1433[] 10;

	// Token: 0x04001B3F RID: 6975
	protected int 11;
}
