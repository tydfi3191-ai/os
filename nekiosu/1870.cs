using System;
using System.Collections.Generic;

// Token: 0x020007CC RID: 1996
public sealed class 1870 : 2037
{
	// Token: 0x06003A12 RID: 14866 RVA: 0x0016DD0E File Offset: 0x0016BF0E
	public 1870(2039 1) : base(1)
	{
		this.7.1(1337);
	}

	// Token: 0x06003A13 RID: 14867 RVA: 0x0016DD37 File Offset: 0x0016BF37
	internal override void ResetState()
	{
		this.2 = 0f;
		this.3 = 0;
		this.4 = 0;
		this.7.1(1337);
	}

	// Token: 0x06003A14 RID: 14868 RVA: 0x0016DD64 File Offset: 0x0016BF64
	internal override 2072 CreateCircle(208 1, int 2, bool 3, 1245 4, int 5, 1254 6, 1254 7, 1253 8, int 9, string 10)
	{
		this.1(ref 1, 2);
		1875 11 = this.1 as 1875;
		if (11 != null)
		{
			11.75(1.X);
		}
		1866 12 = new 1866(this.1, 1, 2, 3, 4, this.2());
		12.35 = 6;
		12.36 = 7;
		12.37 = 8;
		12.34 = 9;
		if (11 != null)
		{
			11.77();
		}
		12.3 |= 2047.NewCombo;
		12.6(10);
		return 12;
	}

	// Token: 0x06003A15 RID: 14869 RVA: 0x0016DDEC File Offset: 0x0016BFEC
	private new void 1(ref 208 1, int 2)
	{
		2023 3 = this.1.22;
		2023 4 = 2023.HardRock;
		if ((3 & 4) <= 2023.None)
		{
			return;
		}
		if (this.2 == 0f)
		{
			this.2 = 1.X;
			this.3 = 2;
			return;
		}
		float num = this.2 - 1.X;
		int num2 = 2 - this.3;
		if (num2 > 1000)
		{
			this.2 = 1.X;
			this.3 = 2;
			return;
		}
		if (num != 0f)
		{
			if (Math.Abs(num) < (float)(num2 / 3))
			{
				if (num > 0f)
				{
					if (1.X - num > 0f)
					{
						1.X -= num;
					}
				}
				else if (1.X - num < 512f)
				{
					1.X -= num;
				}
			}
			this.2 = 1.X;
			this.3 = 2;
			return;
		}
		bool flag = this.7.5();
		float num3 = (float)Math.Min(20, this.7.Next(0, num2 / 4));
		if (flag)
		{
			if (1.X + num3 <= 512f)
			{
				1.X += num3;
				return;
			}
			1.X -= num3;
			return;
		}
		else
		{
			if (1.X - num3 >= 0f)
			{
				1.X -= num3;
				return;
			}
			1.X += num3;
			return;
		}
	}

	// Token: 0x06003A16 RID: 14870 RVA: 0x0016DF3E File Offset: 0x0016C13E
	private string 2()
	{
		string result = 1870.5[this.4];
		this.4 = (this.4 + 1) % 1870.5.Length;
		return result;
	}

	// Token: 0x06003A17 RID: 14871 RVA: 0x0016DF62 File Offset: 0x0016C162
	internal string 3()
	{
		return 1870.6[this.7.Next(0, 1870.6.Length)];
	}

	// Token: 0x06003A18 RID: 14872 RVA: 0x0016DF80 File Offset: 0x0016C180
	internal override 2063 CreateSlider(208 1, int 2, bool 3, 1245 4, 2064 5, int 6, double 7, List<208> 8, List<1245> 9, int 10, 1254 11, 1254 12, List<1254> 13, List<1254> 14, 1253 15, int 16, string 17)
	{
		1871 18 = new 1871(this.1, 1, 2, 3, 4, 5, 6, 7, 8, 9, this.2())
		{
			35 = 11,
			36 = 12,
			85 = 13,
			86 = 14,
			37 = 15,
			34 = 16
		};
		18.6(17);
		this.2 = 8[8.Count - 1].X;
		this.3 = 18.2;
		return 18;
	}

	// Token: 0x06003A19 RID: 14873 RVA: 0x0016E00E File Offset: 0x0016C20E
	internal override 2070 CreateSpinner(int 1, int 2, 1245 3, 1254 4, 1254 5, 1253 6, int 7, string 8)
	{
		1875 9 = this.1 as 1875;
		if (9 != null)
		{
			9.77();
		}
		return new 1862(this.1, 1, 2, 3);
	}

	// Token: 0x06003A1A RID: 14874 RVA: 0x00009D1A File Offset: 0x00007F1A
	internal override 2072 CreateHold(208 1, int 2, int 3, bool 4, 1245 5, int 6, 1254 7, 1254 8, 1253 9, int 10, string 11)
	{
		return null;
	}

	// Token: 0x04002ADE RID: 10974
	private float 2;

	// Token: 0x04002ADF RID: 10975
	private int 3;

	// Token: 0x04002AE0 RID: 10976
	private int 4;

	// Token: 0x04002AE1 RID: 10977
	private static readonly string[] 5 = new string[]
	{
		"pear",
		"grapes",
		"apple",
		"orange"
	};

	// Token: 0x04002AE2 RID: 10978
	private static readonly string[] 6 = new string[]
	{
		"bananas"
	};

	// Token: 0x04002AE3 RID: 10979
	internal 1193 7 = new 1193(1337);
}
