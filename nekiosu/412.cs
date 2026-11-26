using System;

// Token: 0x0200033B RID: 827
public sealed class 412
{
	// Token: 0x06001996 RID: 6550 RVA: 0x0005DF88 File Offset: 0x0005C188
	internal static int Method3079(int 1, int 2)
	{
		int num = 0;
		do
		{
			num |= (1 & 1);
			1 = 383.Method2141(1, 1);
			num <<= 1;
		}
		while (--2 > 0);
		return 383.Method2141(num, 1);
	}

	// Token: 0x06001997 RID: 6551 RVA: 0x0005DFBC File Offset: 0x0005C1BC
	internal void Method3080(407 1)
	{
		short[] array = this.int16Array3;
		short[] int16Array = this._recoveredType20282452.int16Array4;
		int num = this._recoveredType20282452.number4;
		int num2 = -1;
		1.number12 = 0;
		1.number13 = 412.number3;
		int num3;
		for (int i = 0; i < num; i++)
		{
			if (array[i * 2] != 0)
			{
				int[] numberArray = 1.numberArray;
				num3 = 1.number12 + 1;
				1.number12 = num3;
				num2 = (numberArray[num3] = i);
				1.sByteArray2[i] = 0;
			}
			else
			{
				array[i * 2 + 1] = 0;
			}
		}
		int num4;
		while (1.number12 < 2)
		{
			int[] numberArray2 = 1.numberArray;
			num3 = 1.number12 + 1;
			1.number12 = num3;
			num4 = (numberArray2[num3] = ((num2 < 2) ? (++num2) : 0));
			array[num4 * 2] = 1;
			1.sByteArray2[num4] = 0;
			1.number28--;
			if (int16Array != null)
			{
				1.number32 -= (int)int16Array[num4 * 2 + 1];
			}
		}
		this.number4 = num2;
		for (int j = 1.number12 / 2; j >= 1; j--)
		{
			1.Method2901(array, j);
		}
		num4 = num;
		do
		{
			int num5 = 1.numberArray[1];
			int[] numberArray3 = 1.numberArray;
			int num6 = 1;
			int[] numberArray4 = 1.numberArray;
			num3 = 1.number12;
			1.number12 = num3 - 1;
			numberArray3[num6] = numberArray4[num3];
			1.Method2901(array, 1);
			int num7 = 1.numberArray[1];
			int[] numberArray5 = 1.numberArray;
			num3 = 1.number13 - 1;
			1.number13 = num3;
			numberArray5[num3] = num5;
			int[] numberArray6 = 1.numberArray;
			num3 = 1.number13 - 1;
			1.number13 = num3;
			numberArray6[num3] = num7;
			array[num4 * 2] = array[num5 * 2] + array[num7 * 2];
			1.sByteArray2[num4] = (sbyte)(Math.Max((byte)1.sByteArray2[num5], (byte)1.sByteArray2[num7]) + 1);
			array[num5 * 2 + 1] = (array[num7 * 2 + 1] = (short)num4);
			1.numberArray[1] = num4++;
			1.Method2901(array, 1);
		}
		while (1.number12 >= 2);
		int[] numberArray7 = 1.numberArray;
		num3 = 1.number13 - 1;
		1.number13 = num3;
		numberArray7[num3] = 1.numberArray[1];
		this.Method3082(1);
		412.Method3083(array, num2, 1.int16Array3);
	}

	// Token: 0x06001998 RID: 6552 RVA: 0x0005E20A File Offset: 0x0005C40A
	internal static int Method3081(int 1)
	{
		if (1 >= 256)
		{
			return (int)412.sByteArray[256 + 383.Method2141(1, 7)];
		}
		return (int)412.sByteArray[1];
	}

	// Token: 0x06001999 RID: 6553 RVA: 0x0005E230 File Offset: 0x0005C430
	internal void Method3082(407 1)
	{
		short[] array = this.int16Array3;
		short[] int16Array = this._recoveredType20282452.int16Array4;
		int[] array2 = this._recoveredType20282452.numberArray2;
		int number = this._recoveredType20282452.number5;
		int number2 = this._recoveredType20282452.number7;
		int num = 0;
		for (int i = 0; i <= 15; i++)
		{
			1.int16Array3[i] = 0;
		}
		array[1.numberArray[1.number13] * 2 + 1] = 0;
		int j;
		for (j = 1.number13 + 1; j < 412.number3; j++)
		{
			int num2 = 1.numberArray[j];
			int num3 = (int)(array[(int)(array[num2 * 2 + 1] * 2 + 1)] + 1);
			if (num3 > number2)
			{
				num3 = number2;
				num++;
			}
			array[num2 * 2 + 1] = (short)num3;
			if (num2 <= this.number4)
			{
				1.int16Array3[num3] = 1.int16Array3[num3] + 1;
				int num4 = 0;
				if (num2 >= number)
				{
					num4 = array2[num2 - number];
				}
				short num5 = array[num2 * 2];
				1.number28 += (int)num5 * (num3 + num4);
				if (int16Array != null)
				{
					1.number32 += (int)num5 * ((int)int16Array[num2 * 2 + 1] + num4);
				}
			}
		}
		if (num == 0)
		{
			return;
		}
		do
		{
			int num6 = number2 - 1;
			while (1.int16Array3[num6] == 0)
			{
				num6--;
			}
			1.int16Array3[num6] = 1.int16Array3[num6] - 1;
			1.int16Array3[num6 + 1] = 1.int16Array3[num6 + 1] + 2;
			1.int16Array3[number2] = 1.int16Array3[number2] - 1;
			num -= 2;
		}
		while (num > 0);
		for (int num7 = number2; num7 != 0; num7--)
		{
			int num8 = (int)1.int16Array3[num7];
			while (num8 != 0)
			{
				int num9 = 1.numberArray[--j];
				if (num9 <= this.number4)
				{
					if ((int)array[num9 * 2 + 1] != num7)
					{
						1.number28 += (num7 - (int)array[num9 * 2 + 1]) * (int)array[num9 * 2];
						array[num9 * 2 + 1] = (short)num7;
					}
					num8--;
				}
			}
		}
	}

	// Token: 0x0600199A RID: 6554 RVA: 0x0005E450 File Offset: 0x0005C650
	internal static void Method3083(short[] 1, int 2, short[] 3)
	{
		short[] array = new short[16];
		short num = 0;
		for (int i = 1; i <= 15; i++)
		{
			num = (array[i] = (short)(num + 3[i - 1] << 1));
		}
		for (int j = 0; j <= 2; j++)
		{
			int num2 = (int)1[j * 2 + 1];
			if (num2 != 0)
			{
				int num3 = j * 2;
				short[] array2 = array;
				int num4 = num2;
				short num5 = array2[num4];
				array2[num4] = num5 + 1;
				1[num3] = (short)412.Method3079((int)num5, num2);
			}
		}
	}

	// Token: 0x04000C06 RID: 3078
	internal static readonly sbyte[] sByteArray = new sbyte[]
	{
		0,
		1,
		2,
		3,
		4,
		4,
		5,
		5,
		6,
		6,
		6,
		6,
		7,
		7,
		7,
		7,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		8,
		9,
		9,
		9,
		9,
		9,
		9,
		9,
		9,
		10,
		10,
		10,
		10,
		10,
		10,
		10,
		10,
		10,
		10,
		10,
		10,
		10,
		10,
		10,
		10,
		11,
		11,
		11,
		11,
		11,
		11,
		11,
		11,
		11,
		11,
		11,
		11,
		11,
		11,
		11,
		11,
		12,
		12,
		12,
		12,
		12,
		12,
		12,
		12,
		12,
		12,
		12,
		12,
		12,
		12,
		12,
		12,
		12,
		12,
		12,
		12,
		12,
		12,
		12,
		12,
		12,
		12,
		12,
		12,
		12,
		12,
		12,
		12,
		13,
		13,
		13,
		13,
		13,
		13,
		13,
		13,
		13,
		13,
		13,
		13,
		13,
		13,
		13,
		13,
		13,
		13,
		13,
		13,
		13,
		13,
		13,
		13,
		13,
		13,
		13,
		13,
		13,
		13,
		13,
		13,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		14,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		15,
		0,
		0,
		16,
		17,
		18,
		18,
		19,
		19,
		20,
		20,
		20,
		20,
		21,
		21,
		21,
		21,
		22,
		22,
		22,
		22,
		22,
		22,
		22,
		22,
		23,
		23,
		23,
		23,
		23,
		23,
		23,
		23,
		24,
		24,
		24,
		24,
		24,
		24,
		24,
		24,
		24,
		24,
		24,
		24,
		24,
		24,
		24,
		24,
		25,
		25,
		25,
		25,
		25,
		25,
		25,
		25,
		25,
		25,
		25,
		25,
		25,
		25,
		25,
		25,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		28,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29,
		29
	};

	// Token: 0x04000C07 RID: 3079
	internal static readonly sbyte[] sByteArray2 = new sbyte[]
	{
		0,
		1,
		2,
		3,
		4,
		5,
		6,
		7,
		8,
		8,
		9,
		9,
		10,
		10,
		11,
		11,
		12,
		12,
		12,
		12,
		13,
		13,
		13,
		13,
		14,
		14,
		14,
		14,
		15,
		15,
		15,
		15,
		16,
		16,
		16,
		16,
		16,
		16,
		16,
		16,
		17,
		17,
		17,
		17,
		17,
		17,
		17,
		17,
		18,
		18,
		18,
		18,
		18,
		18,
		18,
		18,
		19,
		19,
		19,
		19,
		19,
		19,
		19,
		19,
		20,
		20,
		20,
		20,
		20,
		20,
		20,
		20,
		20,
		20,
		20,
		20,
		20,
		20,
		20,
		20,
		21,
		21,
		21,
		21,
		21,
		21,
		21,
		21,
		21,
		21,
		21,
		21,
		21,
		21,
		21,
		21,
		22,
		22,
		22,
		22,
		22,
		22,
		22,
		22,
		22,
		22,
		22,
		22,
		22,
		22,
		22,
		22,
		23,
		23,
		23,
		23,
		23,
		23,
		23,
		23,
		23,
		23,
		23,
		23,
		23,
		23,
		23,
		23,
		24,
		24,
		24,
		24,
		24,
		24,
		24,
		24,
		24,
		24,
		24,
		24,
		24,
		24,
		24,
		24,
		24,
		24,
		24,
		24,
		24,
		24,
		24,
		24,
		24,
		24,
		24,
		24,
		24,
		24,
		24,
		24,
		25,
		25,
		25,
		25,
		25,
		25,
		25,
		25,
		25,
		25,
		25,
		25,
		25,
		25,
		25,
		25,
		25,
		25,
		25,
		25,
		25,
		25,
		25,
		25,
		25,
		25,
		25,
		25,
		25,
		25,
		25,
		25,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		26,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		27,
		28
	};

	// Token: 0x04000C08 RID: 3080
	internal static readonly int[] numberArray2 = new int[]
	{
		0,
		1,
		2,
		3,
		4,
		6,
		8,
		12,
		16,
		24,
		32,
		48,
		64,
		96,
		128,
		192,
		256,
		384,
		512,
		768,
		1024,
		1536,
		2048,
		3072,
		4096,
		6144,
		8192,
		12288,
		16384,
		24576
	};

	// Token: 0x04000C09 RID: 3081
	internal static readonly int[] numberArray3 = new int[]
	{
		0,
		1,
		2,
		3,
		4,
		5,
		6,
		7,
		8,
		10,
		12,
		14,
		16,
		20,
		24,
		28,
		32,
		40,
		48,
		56,
		64,
		80,
		96,
		112,
		128,
		160,
		192,
		224,
		0
	};

	// Token: 0x04000C0A RID: 3082
	internal static readonly sbyte[] sByteArray3 = new sbyte[]
	{
		16,
		17,
		18,
		0,
		8,
		7,
		9,
		6,
		10,
		5,
		11,
		4,
		12,
		3,
		13,
		2,
		14,
		1,
		15
	};

	// Token: 0x04000C0B RID: 3083
	internal short[] int16Array3;

	// Token: 0x04000C0C RID: 3084
	internal static readonly int[] numberArray4 = new int[]
	{
		0,
		0,
		0,
		0,
		0,
		0,
		0,
		0,
		0,
		0,
		0,
		0,
		0,
		0,
		0,
		0,
		2,
		3,
		7
	};

	// Token: 0x04000C0D RID: 3085
	internal static readonly int[] numberArray5 = new int[]
	{
		0,
		0,
		0,
		0,
		1,
		1,
		2,
		2,
		3,
		3,
		4,
		4,
		5,
		5,
		6,
		6,
		7,
		7,
		8,
		8,
		9,
		9,
		10,
		10,
		11,
		11,
		12,
		12,
		13,
		13
	};

	// Token: 0x04000C0E RID: 3086
	internal static readonly int[] numberArray6 = new int[]
	{
		0,
		0,
		0,
		0,
		0,
		0,
		0,
		0,
		1,
		1,
		1,
		1,
		2,
		2,
		2,
		2,
		3,
		3,
		3,
		3,
		4,
		4,
		4,
		4,
		5,
		5,
		5,
		5,
		0
	};

	// Token: 0x04000C0F RID: 3087
	private static readonly int number3 = 573;

	// Token: 0x04000C10 RID: 3088
	internal int number4;

	// Token: 0x04000C11 RID: 3089
	internal 721 _recoveredType20282452;
}
