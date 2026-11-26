using System;

// Token: 0x0200034B RID: 843
public sealed class 770
{
	// Token: 0x06001A30 RID: 6704 RVA: 0x000055AC File Offset: 0x000037AC
	internal 770()
	{
	}

	// Token: 0x06001A31 RID: 6705 RVA: 0x0006109C File Offset: 0x0005F29C
	internal int Method12428(int 1, int 2, int[] 3, int 4, int[] 5, int 6, 557 7, 552 8)
	{
		int num = 8.number6;
		int num2 = 8.number4;
		int num3 = 7.number3;
		int i = 7.number4;
		int num4 = 7.number13;
		int num5 = (num4 < 7.number11) ? (7.number11 - num4 - 1) : (7.number6 - num4);
		int num6 = 770.numberArray4[1];
		int num7 = 770.numberArray4[2];
		int num10;
		int num11;
		for (;;)
		{
			if (i < 20)
			{
				num2--;
				num3 |= (int)(8.byteArray2[num++] & byte.MaxValue) << i;
				i += 8;
			}
			else
			{
				int num8 = num3 & num6;
				int num9 = (4 + num8) * 3;
				num10 = 3[num9];
				if (num10 == 0)
				{
					num3 >>= 3[num9 + 1];
					i -= 3[num9 + 1];
					7.byteArray2[num4++] = (byte)3[num9 + 2];
					num5--;
				}
				else
				{
					for (;;)
					{
						num3 >>= 3[num9 + 1];
						i -= 3[num9 + 1];
						if ((num10 & 16) != 0)
						{
							break;
						}
						if ((num10 & 64) != 0)
						{
							goto IL_4AB;
						}
						num8 += 3[num9 + 2];
						num8 += (num3 & 770.numberArray4[num10]);
						num9 = (4 + num8) * 3;
						num10 = 3[num9];
						if (num10 == 0)
						{
							goto Block_20;
						}
					}
					num10 &= 15;
					num11 = 3[num9 + 2] + (num3 & 770.numberArray4[num10]);
					num3 >>= num10;
					for (i -= num10; i < 15; i += 8)
					{
						num2--;
						num3 |= (int)(8.byteArray2[num++] & byte.MaxValue) << i;
					}
					num8 = (num3 & num7);
					num9 = (6 + num8) * 3;
					num10 = 5[num9];
					for (;;)
					{
						num3 >>= 5[num9 + 1];
						i -= 5[num9 + 1];
						if ((num10 & 16) != 0)
						{
							break;
						}
						if ((num10 & 64) != 0)
						{
							goto IL_1CA;
						}
						num8 += 5[num9 + 2];
						num8 += (num3 & 770.numberArray4[num10]);
						num9 = (6 + num8) * 3;
						num10 = 5[num9];
					}
					num10 &= 15;
					while (i < num10)
					{
						num2--;
						num3 |= (int)(8.byteArray2[num++] & byte.MaxValue) << i;
						i += 8;
					}
					int num12 = 5[num9 + 2] + (num3 & 770.numberArray4[num10]);
					num3 >>= num10;
					i -= num10;
					num5 -= num11;
					int num13;
					if (num4 >= num12)
					{
						num13 = num4 - num12;
						if (num4 - num13 > 0 && 2 > num4 - num13)
						{
							7.byteArray2[num4++] = 7.byteArray2[num13++];
							7.byteArray2[num4++] = 7.byteArray2[num13++];
							num11 -= 2;
						}
						else
						{
							Array.Copy(7.byteArray2, num13, 7.byteArray2, num4, 2);
							num4 += 2;
							num13 += 2;
							num11 -= 2;
						}
					}
					else
					{
						num13 = num4 - num12;
						do
						{
							num13 += 7.number6;
						}
						while (num13 < 0);
						num10 = 7.number6 - num13;
						if (num11 > num10)
						{
							num11 -= num10;
							if (num4 - num13 > 0 && num10 > num4 - num13)
							{
								do
								{
									7.byteArray2[num4++] = 7.byteArray2[num13++];
								}
								while (--num10 != 0);
							}
							else
							{
								Array.Copy(7.byteArray2, num13, 7.byteArray2, num4, num10);
								num4 += num10;
								num13 += num10;
							}
							num13 = 0;
						}
					}
					if (num4 - num13 > 0 && num11 > num4 - num13)
					{
						do
						{
							7.byteArray2[num4++] = 7.byteArray2[num13++];
						}
						while (--num11 != 0);
						goto IL_59D;
					}
					Array.Copy(7.byteArray2, num13, 7.byteArray2, num4, num11);
					num4 += num11;
					num13 += num11;
					goto IL_59D;
					Block_20:
					num3 >>= 3[num9 + 1];
					i -= 3[num9 + 1];
					7.byteArray2[num4++] = (byte)3[num9 + 2];
					num5--;
				}
				IL_59D:
				if (num5 < 258 || num2 < 10)
				{
					goto IL_5AE;
				}
			}
		}
		IL_1CA:
		8.text = "invalid distance code";
		num11 = 8.number4 - num2;
		num11 = ((i >> 3 < num11) ? (i >> 3) : num11);
		num2 += num11;
		num -= num11;
		i -= num11 << 3;
		7.number3 = num3;
		7.number4 = i;
		8.number4 = num2;
		8.number8 += (long)(num - 8.number6);
		8.number6 = num;
		7.number13 = num4;
		return -3;
		IL_4AB:
		if ((num10 & 32) != 0)
		{
			num11 = 8.number4 - num2;
			num11 = ((i >> 3 < num11) ? (i >> 3) : num11);
			num2 += num11;
			num -= num11;
			i -= num11 << 3;
			7.number3 = num3;
			7.number4 = i;
			8.number4 = num2;
			8.number8 += (long)(num - 8.number6);
			8.number6 = num;
			7.number13 = num4;
			return 1;
		}
		8.text = "invalid literal/length code";
		num11 = 8.number4 - num2;
		num11 = ((i >> 3 < num11) ? (i >> 3) : num11);
		num2 += num11;
		num -= num11;
		i -= num11 << 3;
		7.number3 = num3;
		7.number4 = i;
		8.number4 = num2;
		8.number8 += (long)(num - 8.number6);
		8.number6 = num;
		7.number13 = num4;
		return -3;
		IL_5AE:
		num11 = 8.number4 - num2;
		num11 = ((i >> 3 < num11) ? (i >> 3) : num11);
		num2 += num11;
		num -= num11;
		i -= num11 << 3;
		7.number3 = num3;
		7.number4 = i;
		8.number4 = num2;
		8.number8 += (long)(num - 8.number6);
		8.number6 = num;
		7.number13 = num4;
		return 0;
	}

	// Token: 0x06001A32 RID: 6706 RVA: 0x000616C5 File Offset: 0x0005F8C5
	internal void Method12429(int 1, int 2, int[] 3, int 4, int[] 5, int 6)
	{
		this.number12 = 0;
		this.byteValue2 = (byte)1;
		this.byteValue = (byte)2;
		this.numberArray5 = 3;
		this.number11 = 4;
		this.numberArray3 = 5;
		this.number7 = 6;
		this.numberArray6 = null;
	}

	// Token: 0x06001A33 RID: 6707 RVA: 0x00061704 File Offset: 0x0005F904
	internal int Method12430(557 1, int 2)
	{
		552 recoveredType = 1._recoveredType12495799;
		int num = recoveredType.number6;
		int num2 = recoveredType.number4;
		int num3 = 1.number3;
		int i = 1.number4;
		int num4 = 1.number13;
		int num5 = (num4 < 1.number11) ? (1.number11 - num4 - 1) : (1.number6 - num4);
		for (;;)
		{
			switch (this.number12)
			{
			case 0:
				if (num5 >= 258 && num2 >= 10)
				{
					1.number3 = num3;
					1.number4 = i;
					recoveredType.number4 = num2;
					recoveredType.number8 += (long)(num - recoveredType.number6);
					recoveredType.number6 = num;
					1.number13 = num4;
					2 = this.Method12428((int)this.byteValue2, (int)this.byteValue, this.numberArray5, this.number11, this.numberArray3, this.number7, 1, recoveredType);
					num = recoveredType.number6;
					num2 = recoveredType.number4;
					num3 = 1.number3;
					i = 1.number4;
					num4 = 1.number13;
					num5 = ((num4 < 1.number11) ? (1.number11 - num4 - 1) : (1.number6 - num4));
					if (2 != 0)
					{
						this.number12 = ((2 == 1) ? 7 : 9);
						continue;
					}
				}
				this.number13 = (int)this.byteValue2;
				this.numberArray6 = this.numberArray5;
				this.number14 = this.number11;
				this.number12 = 1;
				goto IL_90;
			case 1:
				goto IL_90;
			case 2:
			{
				int num6 = this.number8;
				while (i < num6)
				{
					if (num2 == 0)
					{
						goto IL_6A0;
					}
					2 = 0;
					num2--;
					num3 |= (int)(recoveredType.byteArray2[num++] & byte.MaxValue) << i;
					i += 8;
				}
				this.number9 += (num3 & 770.numberArray4[num6]);
				num3 >>= num6;
				i -= num6;
				this.number13 = (int)this.byteValue;
				this.numberArray6 = this.numberArray3;
				this.number14 = this.number7;
				this.number12 = 3;
				goto IL_236;
			}
			case 3:
				goto IL_236;
			case 4:
			{
				int num7 = this.number8;
				while (i < num7)
				{
					if (num2 == 0)
					{
						goto IL_773;
					}
					2 = 0;
					num2--;
					num3 |= (int)(recoveredType.byteArray2[num++] & byte.MaxValue) << i;
					i += 8;
				}
				this.number6 += (num3 & 770.numberArray4[num7]);
				num3 >>= num7;
				i -= num7;
				this.number12 = 5;
				goto IL_3A7;
			}
			case 5:
				goto IL_3A7;
			case 6:
				if (num5 == 0)
				{
					if (num4 == 1.number6 && 1.number11 != 0)
					{
						num4 = 0;
						num5 = ((num4 < 1.number11) ? (1.number11 - num4 - 1) : (1.number6 - num4));
					}
					if (num5 == 0)
					{
						1.number13 = num4;
						2 = 1.Method7507(2);
						num4 = 1.number13;
						num5 = ((num4 < 1.number11) ? (1.number11 - num4 - 1) : (1.number6 - num4));
						if (num4 == 1.number6 && 1.number11 != 0)
						{
							num4 = 0;
							num5 = ((num4 < 1.number11) ? (1.number11 - num4 - 1) : (1.number6 - num4));
						}
						if (num5 == 0)
						{
							goto Block_44;
						}
					}
				}
				2 = 0;
				1.byteArray2[num4++] = (byte)this.number10;
				num5--;
				this.number12 = 0;
				continue;
			case 7:
				goto IL_917;
			case 8:
				goto IL_51B;
			case 9:
				goto IL_9C1;
			}
			break;
			IL_90:
			int num8 = this.number13;
			while (i < num8)
			{
				if (num2 == 0)
				{
					goto IL_C3;
				}
				2 = 0;
				num2--;
				num3 |= (int)(recoveredType.byteArray2[num++] & byte.MaxValue) << i;
				i += 8;
			}
			int num9 = (this.number14 + (num3 & 770.numberArray4[num8])) * 3;
			num3 = 383.Method2141(num3, this.numberArray6[num9 + 1]);
			i -= this.numberArray6[num9 + 1];
			int num10 = this.numberArray6[num9];
			if (num10 == 0)
			{
				this.number10 = this.numberArray6[num9 + 2];
				this.number12 = 6;
				continue;
			}
			if ((num10 & 16) != 0)
			{
				this.number8 = (num10 & 15);
				this.number9 = this.numberArray6[num9 + 2];
				this.number12 = 2;
				continue;
			}
			if ((num10 & 64) == 0)
			{
				this.number13 = num10;
				this.number14 = num9 / 3 + this.numberArray6[num9 + 2];
				continue;
			}
			if ((num10 & 32) != 0)
			{
				this.number12 = 7;
				continue;
			}
			goto IL_1DC;
			IL_236:
			int num11 = this.number13;
			while (i < num11)
			{
				if (num2 == 0)
				{
					goto IL_269;
				}
				2 = 0;
				num2--;
				num3 |= (int)(recoveredType.byteArray2[num++] & byte.MaxValue) << i;
				i += 8;
			}
			int num12 = (this.number14 + (num3 & 770.numberArray4[num11])) * 3;
			num3 >>= this.numberArray6[num12 + 1];
			i -= this.numberArray6[num12 + 1];
			int num13 = this.numberArray6[num12];
			if ((num13 & 16) != 0)
			{
				this.number8 = (num13 & 15);
				this.number6 = this.numberArray6[num12 + 2];
				this.number12 = 4;
				continue;
			}
			if ((num13 & 64) == 0)
			{
				this.number13 = num13;
				this.number14 = num12 / 3 + this.numberArray6[num12 + 2];
				continue;
			}
			goto IL_34D;
			IL_3A7:
			int j;
			for (j = num4 - this.number6; j < 0; j += 1.number6)
			{
			}
			while (this.number9 != 0)
			{
				if (num5 == 0)
				{
					if (num4 == 1.number6 && 1.number11 != 0)
					{
						num4 = 0;
						num5 = ((num4 < 1.number11) ? (1.number11 - num4 - 1) : (1.number6 - num4));
					}
					if (num5 == 0)
					{
						1.number13 = num4;
						2 = 1.Method7507(2);
						num4 = 1.number13;
						num5 = ((num4 < 1.number11) ? (1.number11 - num4 - 1) : (1.number6 - num4));
						if (num4 == 1.number6 && 1.number11 != 0)
						{
							num4 = 0;
							num5 = ((num4 < 1.number11) ? (1.number11 - num4 - 1) : (1.number6 - num4));
						}
						if (num5 == 0)
						{
							goto Block_23;
						}
					}
				}
				1.byteArray2[num4++] = 1.byteArray2[j++];
				num5--;
				if (j == 1.number6)
				{
					j = 0;
				}
				this.number9--;
			}
			this.number12 = 0;
		}
		2 = -2;
		1.number3 = num3;
		1.number4 = i;
		recoveredType.number4 = num2;
		recoveredType.number8 += (long)(num - recoveredType.number6);
		recoveredType.number6 = num;
		1.number13 = num4;
		return 1.Method7507(2);
		IL_C3:
		1.number3 = num3;
		1.number4 = i;
		recoveredType.number4 = num2;
		recoveredType.number8 += (long)(num - recoveredType.number6);
		recoveredType.number6 = num;
		1.number13 = num4;
		return 1.Method7507(2);
		IL_1DC:
		this.number12 = 9;
		recoveredType.text = "invalid literal/length code";
		2 = -3;
		1.number3 = num3;
		1.number4 = i;
		recoveredType.number4 = num2;
		recoveredType.number8 += (long)(num - recoveredType.number6);
		recoveredType.number6 = num;
		1.number13 = num4;
		return 1.Method7507(2);
		IL_269:
		1.number3 = num3;
		1.number4 = i;
		recoveredType.number4 = num2;
		recoveredType.number8 += (long)(num - recoveredType.number6);
		recoveredType.number6 = num;
		1.number13 = num4;
		return 1.Method7507(2);
		IL_34D:
		this.number12 = 9;
		recoveredType.text = "invalid distance code";
		2 = -3;
		1.number3 = num3;
		1.number4 = i;
		recoveredType.number4 = num2;
		recoveredType.number8 += (long)(num - recoveredType.number6);
		recoveredType.number6 = num;
		1.number13 = num4;
		return 1.Method7507(2);
		Block_23:
		1.number3 = num3;
		1.number4 = i;
		recoveredType.number4 = num2;
		recoveredType.number8 += (long)(num - recoveredType.number6);
		recoveredType.number6 = num;
		1.number13 = num4;
		return 1.Method7507(2);
		IL_51B:
		2 = 1;
		1.number3 = num3;
		1.number4 = i;
		recoveredType.number4 = num2;
		recoveredType.number8 += (long)(num - recoveredType.number6);
		recoveredType.number6 = num;
		1.number13 = num4;
		return 1.Method7507(2);
		IL_6A0:
		1.number3 = num3;
		1.number4 = i;
		recoveredType.number4 = num2;
		recoveredType.number8 += (long)(num - recoveredType.number6);
		recoveredType.number6 = num;
		1.number13 = num4;
		return 1.Method7507(2);
		IL_773:
		1.number3 = num3;
		1.number4 = i;
		recoveredType.number4 = num2;
		recoveredType.number8 += (long)(num - recoveredType.number6);
		recoveredType.number6 = num;
		1.number13 = num4;
		return 1.Method7507(2);
		Block_44:
		1.number3 = num3;
		1.number4 = i;
		recoveredType.number4 = num2;
		recoveredType.number8 += (long)(num - recoveredType.number6);
		recoveredType.number6 = num;
		1.number13 = num4;
		return 1.Method7507(2);
		IL_917:
		if (i > 7)
		{
			i -= 8;
			num2++;
			num--;
		}
		1.number13 = num4;
		2 = 1.Method7507(2);
		num4 = 1.number13;
		int num14 = (num4 < 1.number11) ? (1.number11 - num4 - 1) : (1.number6 - num4);
		if (1.number11 != 1.number13)
		{
			1.number3 = num3;
			1.number4 = i;
			recoveredType.number4 = num2;
			recoveredType.number8 += (long)(num - recoveredType.number6);
			recoveredType.number6 = num;
			1.number13 = num4;
			return 1.Method7507(2);
		}
		this.number12 = 8;
		goto IL_51B;
		IL_9C1:
		2 = -3;
		1.number3 = num3;
		1.number4 = i;
		recoveredType.number4 = num2;
		recoveredType.number8 += (long)(num - recoveredType.number6);
		recoveredType.number6 = num;
		1.number13 = num4;
		return 1.Method7507(2);
	}

	// Token: 0x04000C62 RID: 3170
	internal byte byteValue;

	// Token: 0x04000C63 RID: 3171
	internal int number6;

	// Token: 0x04000C64 RID: 3172
	internal int[] numberArray3;

	// Token: 0x04000C65 RID: 3173
	internal int number7;

	// Token: 0x04000C66 RID: 3174
	internal int number8;

	// Token: 0x04000C67 RID: 3175
	private static readonly int[] numberArray4 = new int[]
	{
		0,
		1,
		3,
		7,
		15,
		31,
		63,
		127,
		255,
		511,
		1023,
		2047,
		4095,
		8191,
		16383,
		32767,
		65535
	};

	// Token: 0x04000C68 RID: 3176
	internal byte byteValue2;

	// Token: 0x04000C69 RID: 3177
	internal int number9;

	// Token: 0x04000C6A RID: 3178
	internal int number10;

	// Token: 0x04000C6B RID: 3179
	internal int[] numberArray5;

	// Token: 0x04000C6C RID: 3180
	internal int number11;

	// Token: 0x04000C6D RID: 3181
	internal int number12;

	// Token: 0x04000C6E RID: 3182
	internal int number13;

	// Token: 0x04000C6F RID: 3183
	internal int[] numberArray6;

	// Token: 0x04000C70 RID: 3184
	internal int number14;
}
