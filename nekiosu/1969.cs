using System;
using System.Collections.Generic;

// Token: 0x02000782 RID: 1922
public sealed class 1969 : 2123
{
	// Token: 0x06003864 RID: 14436 RVA: 0x00161034 File Offset: 0x0015F234
	internal 1969(2039 1, 208 2, int 3, 1245 4, int 5, double 6, List<208> 7, List<1245> 8, 1965 9, bool[] 10) : base(1, 2, 3, false, 4, 2064.Bezier, 5, 6, 7, 8, 0)
	{
		this.98 = (this.28.33 as 1971);
		this.93 = new List<1979>();
		this.2 = base.25();
		this.94 = 9;
		this.95 = base.GetDuration() / 5;
		this.28.41.49(2, false);
		this.96 = 10;
		for (int i = 0; i < 10.Length; i++)
		{
			if (10[i])
			{
				this.97++;
			}
		}
	}

	// Token: 0x06003865 RID: 14437 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void GenerateSliderEvents()
	{
	}

	// Token: 0x06003866 RID: 14438 RVA: 0x001610DC File Offset: 0x0015F2DC
	internal new void 50()
	{
		int <<EMPTY_NAME>> = this.28.41.49(this.8, false);
		int 2 = this.5;
		if ((this.94 & (1965)8192) > (1965)0 || this.28.41.19.Count == 1)
		{
			this.55(<<EMPTY_NAME>>, this.1, this.2, 1, 0);
			return;
		}
		if (2 > 1)
		{
			if (this.95 <= 90)
			{
				this.57(1, this.1, this.2 - this.1);
				return;
			}
			if (this.95 <= 120)
			{
				this.94 |= (1965)2;
				this.59(this.1, this.95, 2);
				return;
			}
			if (this.95 <= 160)
			{
				this.58(this.1, this.95, 2);
				return;
			}
			if (this.95 <= 200 && this.28.21.28() > 3.0)
			{
				this.60(this.1, this.95, 2);
				return;
			}
			int num = this.2 - this.1;
			if (num >= 4000)
			{
				this.51(this.1, num, 1f, 1f, 0.77f);
				return;
			}
			if (this.95 > 400 && num < 4000 && 2 < this.28.41.19.Count - 1 - this.28.41.43())
			{
				this.56(2, this.1, this.95);
				return;
			}
			this.61(this.1, this.95, 2);
			return;
		}
		else
		{
			if (this.95 <= 110)
			{
				if (this.97 < this.28.41.19.Count)
				{
					this.94 |= (1965)2;
				}
				else
				{
					this.94 &= (1965)(-3);
				}
				this.59(this.1, this.95, (this.95 >= 80) ? 1 : 0);
				return;
			}
			if (this.28.21.28() > 6.5)
			{
				if ((this.94 & (1965)8) > (1965)0)
				{
					this.51(this.1, this.2 - this.1, 1f, 0.7f, 0.22f);
					return;
				}
				this.51(this.1, this.2 - this.1, 0.97f, 0.64f, 0.15f);
				return;
			}
			else if (this.28.21.28() > 4.0)
			{
				if ((this.94 & (1965)8) > (1965)0)
				{
					this.51(this.1, this.2 - this.1, 1f, 0.92f, 0.57f);
					return;
				}
				this.51(this.1, this.2 - this.1, 1f, 0.82f, 0.44f);
				return;
			}
			else if (this.28.21.28() > 2.5)
			{
				if ((this.94 & (1965)8) > (1965)0)
				{
					this.51(this.1, this.2 - this.1, 1f, 1f, 0.7f);
					return;
				}
				this.51(this.1, this.2 - this.1, 1f, 0.92f, 0.63f);
				return;
			}
			else
			{
				if ((this.94 & (1965)8) > (1965)0)
				{
					this.51(this.1, this.2 - this.1, 1f, 1f, 0.83f);
					return;
				}
				this.51(this.1, this.2 - this.1, 1f, 1f, 0.73f);
				return;
			}
		}
	}

	// Token: 0x06003867 RID: 14439 RVA: 0x001614C0 File Offset: 0x0015F6C0
	private new void 51(int 1, int 2, float 3, float 4, float 5)
	{
		switch (this.28.41.19.Count)
		{
		case 2:
			3 = 1f;
			4 = 1f;
			5 = 1f;
			break;
		case 3:
			3 = 1f;
			4 = 1f;
			5 = Math.Max(5, 0.9f);
			break;
		case 4:
			3 = 1f;
			4 = Math.Max(4, 0.96f);
			5 = Math.Max(5, 0.7f);
			break;
		case 5:
			3 = Math.Max(3, 0.97f);
			4 = Math.Max(4, 0.9f);
			5 = Math.Max(5, 0.66f);
			break;
		}
		if ((this.94 & (1965)8) == (1965)0 && (this.4.2(1245.Finish | 1245.Clap) || this.52(1).2(1245.Finish | 1245.Clap)))
		{
			5 = 0f;
		}
		this.57(this.98.1(5, 4, 3, 1f, 1f), 1, 2);
	}

	// Token: 0x06003868 RID: 14440 RVA: 0x001615D8 File Offset: 0x0015F7D8
	private 1245 52(int 1)
	{
		if (this.73)
		{
			return this.4;
		}
		int num = (this.95 != 0) ? ((1 - this.1) / this.95) : 0;
		if (num < this.84.Count)
		{
			return this.84[num];
		}
		return this.84[this.84.Count - 1];
	}

	// Token: 0x06003869 RID: 14441 RVA: 0x00161644 File Offset: 0x0015F844
	private new 1254 53(int 1)
	{
		if (this.73 || (this.94 & (1965)8192) > (1965)0)
		{
			return this.35;
		}
		int num = (this.95 != 0) ? ((1 - this.1) / this.95) : 0;
		if (num >= this.85.Count)
		{
			return this.85[this.85.Count - 1];
		}
		return this.85[num];
	}

	// Token: 0x0600386A RID: 14442 RVA: 0x001616C0 File Offset: 0x0015F8C0
	private new 1254 54(int 1)
	{
		if (this.73 || (this.94 & (1965)8192) > (1965)0)
		{
			return this.36;
		}
		int num = (this.95 != 0) ? ((1 - this.1) / this.95) : 0;
		if (num >= this.86.Count)
		{
			return this.86[this.86.Count - 1];
		}
		return this.86[num];
	}

	// Token: 0x0600386B RID: 14443 RVA: 0x0016173C File Offset: 0x0015F93C
	private new void 55(int 1, int 2, int 3, int 4, int 5)
	{
		if (5 == 0)
		{
			5 = 4;
		}
		int 6 = this.34;
		if ((this.94 & (1965)8192) == (1965)0)
		{
			if (this.34 != 0)
			{
				6 = Math.Min(this.34, this.34 * 4 / 3 / 5);
			}
			else
			{
				1259 7 = this.28.21.92((double)this.1);
				if (7 != null)
				{
					6 = Math.Min(7.6, 7.6 * 4 / 3 / 5);
				}
			}
		}
		if (2 == 3)
		{
			1979 8 = new 1979(this.28, 1, 2, this.52(2));
			8.35 = this.53(2);
			8.36 = this.54(2);
			8.37 = this.37;
			8.34 = 6;
			8.50 = 4;
			this.93.Add(8);
			return;
		}
		1978 9 = new 1978(this.28, 1, 2, 3, this.4);
		9.57 = this.52(2);
		9.56 = this.52(3);
		9.35 = this.53(2);
		9.36 = this.54(2);
		9.58 = this.53(3);
		9.59 = this.54(3);
		9.60 = this.35;
		9.61 = this.36;
		9.37 = this.37;
		9.34 = 6;
		9.50 = 4;
		this.93.Add(9);
	}

	// Token: 0x0600386C RID: 14444 RVA: 0x001618BC File Offset: 0x0015FABC
	private new void 56(int 1, int 2, int 3)
	{
		int num = 2;
		int 4 = 2 + 3 * 1;
		int i = Math.Min(1, this.28.41.19.Count);
		bool[] array = new bool[this.28.41.19.Count];
		int num2 = this.28.41.49(this.8, true);
		if ((this.94 & (1965)2) > (1965)0 && this.97 < this.28.41.19.Count)
		{
			while (this.96[num2])
			{
				num2 = this.98.2.Next(this.28.41.43(), this.28.41.19.Count);
			}
		}
		while (i > 0)
		{
			while (array[num2])
			{
				num2 = this.98.2.Next(this.28.41.43(), this.28.41.19.Count);
			}
			this.55(num2, num, 4, 1, 0);
			array[num2] = true;
			num += 3;
			i--;
		}
	}

	// Token: 0x0600386D RID: 14445 RVA: 0x001619F0 File Offset: 0x0015FBF0
	private new void 57(int 1, int 2, int 3)
	{
		int num = this.28.41.19.Count - this.28.41.43() - this.97;
		if (num >= 1)
		{
			bool[] array = new bool[this.28.41.19.Count];
			int num2 = this.98.2.Next(this.28.41.43(), this.28.41.19.Count);
			for (int i = 0; i < 1; i++)
			{
				while (array[num2] || this.96[num2])
				{
					num2 = this.98.2.Next(this.28.41.43(), this.28.41.19.Count);
				}
				this.55(num2, 2, 2 + 3, 1, 0);
				array[num2] = true;
			}
			return;
		}
		int num3 = 1;
		bool[] array2 = new bool[this.28.41.19.Count];
		int num4 = this.98.2.Next(this.28.41.43(), this.28.41.19.Count);
		for (int j = 0; j < num; j++)
		{
			while (array2[num4] || this.96[num4])
			{
				num4 = this.98.2.Next(this.28.41.43(), this.28.41.19.Count);
			}
			this.55(num4, 2, 2 + 3, 1, 0);
			array2[num4] = true;
			num3--;
		}
		for (int k = 0; k < num3; k++)
		{
			while (array2[num4])
			{
				num4 = this.98.2.Next(this.28.41.43(), this.28.41.19.Count);
			}
			this.55(num4, 2, 2 + 3, 1, 0);
			array2[num4] = true;
		}
	}

	// Token: 0x0600386E RID: 14446 RVA: 0x00161C0C File Offset: 0x0015FE0C
	private new void 58(int 1, int 2, int 3)
	{
		int num = this.28.41.49(this.8, true);
		bool flag = this.98.2.3() > 0.5;
		while (3 >= 0)
		{
			3--;
			this.55(num, 1, 1, 1, 0);
			1 += 2;
			if (flag)
			{
				if (num >= this.28.41.19.Count - 1)
				{
					flag = false;
					num--;
				}
				else
				{
					num++;
				}
			}
			else if (num <= this.28.41.43())
			{
				flag = true;
				num++;
			}
			else
			{
				num--;
			}
		}
	}

	// Token: 0x0600386F RID: 14447 RVA: 0x00161CB4 File Offset: 0x0015FEB4
	private void 59(int 1, int 2, int 3)
	{
		int num = this.28.41.49(this.8, true);
		if ((this.94 & (1965)2) > (1965)0 && this.97 < this.28.41.19.Count)
		{
			while (this.96[num])
			{
				num = this.98.2.Next(this.28.41.43(), this.28.41.19.Count);
			}
		}
		int num2 = num;
		while (3 >= 0)
		{
			this.55(num, 1, 1, 1, 0);
			while (num == num2)
			{
				num = this.98.2.Next(this.28.41.43(), this.28.41.19.Count);
			}
			num2 = num;
			1 += 2;
			3--;
		}
	}

	// Token: 0x06003870 RID: 14448 RVA: 0x00161DA0 File Offset: 0x0015FFA0
	private void 60(int 1, int 2, int 3)
	{
		bool flag = this.28.41.19.Count >= 4 && this.28.41.19.Count <= 8;
		int num = this.98.2.Next(1, this.28.41.19.Count - ((flag > false) ? 1 : 0));
		int num2 = this.28.41.49(this.8, true);
		while (3 >= 0)
		{
			this.55(num2, 1, 1, 2, 0);
			num2 += num;
			if (num2 >= this.28.41.19.Count - this.28.41.43())
			{
				num2 = num2 - this.28.41.19.Count - this.28.41.43() + ((flag > false) ? 1 : 0);
			}
			num2 += this.28.41.43();
			if (this.28.41.19.Count > 2)
			{
				this.55(num2, 1, 1, 2, 0);
			}
			num2 = this.98.2.Next(this.28.41.43(), this.28.41.19.Count);
			1 += 2;
			3--;
		}
	}

	// Token: 0x06003871 RID: 14449 RVA: 0x00161F10 File Offset: 0x00160110
	private void 61(int 1, int 2, int 3)
	{
		int num = this.28.41.49(this.8, true);
		if ((this.94 & (1965)2) > (1965)0 && this.97 < this.28.41.19.Count)
		{
			while (this.96[num])
			{
				num = this.98.2.Next(this.28.41.43(), this.28.41.19.Count);
			}
		}
		this.55(num, 1, this.2, 1, 0);
		bool[] array = new bool[this.28.41.19.Count];
		int num2 = this.98.2.Next(this.28.41.43(), this.28.41.19.Count);
		int num3 = (this.28.21.28() > 6.5) ? this.98.1(0.37f, 1f, 1f, 1f, 1f) : ((this.28.21.28() > 4.0) ? this.98.1((this.28.41.19.Count < 6) ? 0.88f : 0.55f, 1f, 1f, 1f, 1f) : ((this.28.21.28() > 2.5) ? this.98.1((this.28.41.19.Count < 6) ? 1f : 0.76f, 1f, 1f, 1f, 1f) : 0));
		num3 = Math.Min(num3, this.28.41.19.Count - 1);
		bool flag = this.52(1) <= 1245.Normal;
		while (3 >= 0)
		{
			if (!flag || 1 != this.1)
			{
				for (int i = 0; i < num3; i++)
				{
					while (array[num2] || num2 == num)
					{
						num2 = this.98.2.Next(this.28.41.43(), this.28.41.19.Count);
					}
					int 4 = num3 + 1;
					int 5 = num3 + ((3 == this.5 || 3 == 0) ? 1 : 0);
					this.55(num2, 1, 1, 4, 5);
					array[num2] = true;
				}
			}
			1 += 2;
			array = new bool[this.28.41.19.Count];
			3--;
		}
	}

	// Token: 0x040029B3 RID: 10675
	internal List<1979> 93;

	// Token: 0x040029B4 RID: 10676
	private 1965 94;

	// Token: 0x040029B5 RID: 10677
	private int 95;

	// Token: 0x040029B6 RID: 10678
	private bool[] 96;

	// Token: 0x040029B7 RID: 10679
	private int 97;

	// Token: 0x040029B8 RID: 10680
	private 1971 98;
}
