using System;

// Token: 0x02000209 RID: 521
[241(0)]
[242(1)]
public struct 361
{
	// Token: 0x06001072 RID: 4210 RVA: 0x0003859F File Offset: 0x0003679F
	public bool Method1646(char[] 1, int 2, int 3)
	{
		this.charArray2 = 1;
		this.number12 = 2 + 3;
		return this.Method1647(2) && this.Method1653(361.number17 + 2, 'T') && this.Method1648(361.number18 + 2);
	}

	// Token: 0x06001073 RID: 4211 RVA: 0x000385E0 File Offset: 0x000367E0
	private bool Method1647(int 1)
	{
		return this.Method1651(1, out this.number3) && 1 <= this.number3 && this.Method1653(1 + 361.number13, '-') && this.Method1652(1 + 361.number14, out this.number4) && 1 <= this.number4 && this.number4 <= 12 && this.Method1653(1 + 361.number15, '-') && this.Method1652(1 + 361.number16, out this.number5) && 1 <= this.number5 && this.number5 <= DateTime.DaysInMonth(this.number3, this.number4);
	}

	// Token: 0x06001074 RID: 4212 RVA: 0x00038691 File Offset: 0x00036891
	private bool Method1648(int 1)
	{
		return this.Method1649(ref 1) && this.Method1650(1);
	}

	// Token: 0x06001075 RID: 4213 RVA: 0x000386A8 File Offset: 0x000368A8
	private bool Method1649(ref int 1)
	{
		if (!this.Method1652(1, out this.number6) || this.number6 > 24 || !this.Method1653(1 + 361.number19, ':') || !this.Method1652(1 + 361.number20, out this.number7) || this.number7 >= 60 || !this.Method1653(1 + 361.number21, ':') || !this.Method1652(1 + 361.number22, out this.number8) || this.number8 >= 60 || (this.number6 == 24 && (this.number7 != 0 || this.number8 != 0)))
		{
			return false;
		}
		1 += 361.number23;
		if (this.Method1653(1, '.'))
		{
			this.number9 = 0;
			int num = 0;
			for (;;)
			{
				int num2 = 1 + 1;
				1 = num2;
				if (num2 >= this.number12 || num >= 7)
				{
					break;
				}
				int num3 = (int)(this.charArray2[1] - '0');
				if (num3 < 0 || num3 > 9)
				{
					break;
				}
				this.number9 = this.number9 * 10 + num3;
				num++;
			}
			if (num < 7)
			{
				if (num == 0)
				{
					return false;
				}
				this.number9 *= 361.numberArray[7 - num];
			}
			if (this.number6 == 24 && this.number9 != 0)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06001076 RID: 4214 RVA: 0x000387E8 File Offset: 0x000369E8
	private bool Method1650(int 1)
	{
		if (1 < this.number12)
		{
			char c = this.charArray2[1];
			if (c == 'Z' || c == 'z')
			{
				this._recoveredType18661110 = (692)1;
				1++;
			}
			else
			{
				if (1 + 2 < this.number12 && this.Method1652(1 + 361.number24, out this.number10) && this.number10 <= 99)
				{
					if (c != '+')
					{
						if (c == '-')
						{
							this._recoveredType18661110 = (692)2;
							1 += 361.number25;
						}
					}
					else
					{
						this._recoveredType18661110 = (692)3;
						1 += 361.number25;
					}
				}
				if (1 < this.number12)
				{
					if (this.Method1653(1, ':'))
					{
						1++;
						if (1 + 1 < this.number12 && this.Method1652(1, out this.number11) && this.number11 <= 99)
						{
							1 += 2;
						}
					}
					else if (1 + 1 < this.number12 && this.Method1652(1, out this.number11) && this.number11 <= 99)
					{
						1 += 2;
					}
				}
			}
		}
		return 1 == this.number12;
	}

	// Token: 0x06001077 RID: 4215 RVA: 0x000388F4 File Offset: 0x00036AF4
	private bool Method1651(int 1, out int 2)
	{
		if (1 + 3 < this.number12)
		{
			int num = (int)(this.charArray2[1] - '0');
			int num2 = (int)(this.charArray2[1 + 1] - '0');
			int num3 = (int)(this.charArray2[1 + 2] - '0');
			int num4 = (int)(this.charArray2[1 + 3] - '0');
			if (0 <= num && num < 10 && 0 <= num2 && num2 < 10 && 0 <= num3 && num3 < 10 && 0 <= num4 && num4 < 10)
			{
				2 = ((num * 10 + num2) * 10 + num3) * 10 + num4;
				return true;
			}
		}
		2 = 0;
		return false;
	}

	// Token: 0x06001078 RID: 4216 RVA: 0x00038980 File Offset: 0x00036B80
	private bool Method1652(int 1, out int 2)
	{
		if (1 + 1 < this.number12)
		{
			int num = (int)(this.charArray2[1] - '0');
			int num2 = (int)(this.charArray2[1 + 1] - '0');
			if (0 <= num && num < 10 && 0 <= num2 && num2 < 10)
			{
				2 = num * 10 + num2;
				return true;
			}
		}
		2 = 0;
		return false;
	}

	// Token: 0x06001079 RID: 4217 RVA: 0x000389D2 File Offset: 0x00036BD2
	private bool Method1653(int 1, char 2)
	{
		return 1 < this.number12 && this.charArray2[1] == 2;
	}

	// Token: 0x040007EA RID: 2026
	public int number3;

	// Token: 0x040007EB RID: 2027
	public int number4;

	// Token: 0x040007EC RID: 2028
	public int number5;

	// Token: 0x040007ED RID: 2029
	public int number6;

	// Token: 0x040007EE RID: 2030
	public int number7;

	// Token: 0x040007EF RID: 2031
	public int number8;

	// Token: 0x040007F0 RID: 2032
	public int number9;

	// Token: 0x040007F1 RID: 2033
	public int number10;

	// Token: 0x040007F2 RID: 2034
	public int number11;

	// Token: 0x040007F3 RID: 2035
	public 692 _recoveredType18661110;

	// Token: 0x040007F4 RID: 2036
	private char[] charArray2;

	// Token: 0x040007F5 RID: 2037
	private int number12;

	// Token: 0x040007F6 RID: 2038
	private static readonly int[] numberArray = new int[]
	{
		-1,
		10,
		100,
		1000,
		10000,
		100000,
		1000000
	};

	// Token: 0x040007F7 RID: 2039
	private static readonly int number13 = 4;

	// Token: 0x040007F8 RID: 2040
	private static readonly int number14 = 5;

	// Token: 0x040007F9 RID: 2041
	private static readonly int number15 = 7;

	// Token: 0x040007FA RID: 2042
	private static readonly int number16 = 8;

	// Token: 0x040007FB RID: 2043
	private static readonly int number17 = 10;

	// Token: 0x040007FC RID: 2044
	private static readonly int number18 = 11;

	// Token: 0x040007FD RID: 2045
	private static readonly int number19 = 2;

	// Token: 0x040007FE RID: 2046
	private static readonly int number20 = 3;

	// Token: 0x040007FF RID: 2047
	private static readonly int number21 = 5;

	// Token: 0x04000800 RID: 2048
	private static readonly int number22 = 6;

	// Token: 0x04000801 RID: 2049
	private static readonly int number23 = 8;

	// Token: 0x04000802 RID: 2050
	private static readonly int number24 = 1;

	// Token: 0x04000803 RID: 2051
	private static readonly int number25 = 3;
}
