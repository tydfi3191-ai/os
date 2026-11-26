using System;

// Token: 0x02000344 RID: 836
public sealed class 557
{
	// Token: 0x060019EF RID: 6639 RVA: 0x0005F43C File Offset: 0x0005D63C
	internal 557(552 1, object 2, int 3)
	{
		this._recoveredType12495799 = 1;
		this.numberArray5 = new int[4320];
		this.byteArray2 = new byte[3];
		this.number6 = 3;
		this.value2 = 2;
		this.number10 = 0;
		this.Method7510(null);
	}

	// Token: 0x060019F0 RID: 6640 RVA: 0x0005F4BC File Offset: 0x0005D6BC
	internal int Method7507(int 1)
	{
		int num = this._recoveredType12495799.number7;
		int num2 = this.number11;
		int num3 = ((num2 <= this.number13) ? this.number13 : this.number6) - num2;
		if (num3 > this._recoveredType12495799.number5)
		{
			num3 = this._recoveredType12495799.number5;
		}
		if (num3 != 0 && 1 == -5)
		{
			1 = 0;
		}
		this._recoveredType12495799.number5 -= num3;
		this._recoveredType12495799.number9 += (long)num3;
		if (this.value2 != null)
		{
			this._recoveredType12495799.number3 = (this.number5 = 727.Method11313(this.number5, this.byteArray2, num2, num3));
		}
		Array.Copy(this.byteArray2, num2, this._recoveredType12495799.byteArray3, num, num3);
		num += num3;
		num2 += num3;
		if (num2 == this.number6)
		{
			num2 = 0;
			if (this.number13 == this.number6)
			{
				this.number13 = 0;
			}
			num3 = this.number13 - num2;
			if (num3 > this._recoveredType12495799.number5)
			{
				num3 = this._recoveredType12495799.number5;
			}
			if (num3 != 0 && 1 == -5)
			{
				1 = 0;
			}
			this._recoveredType12495799.number5 -= num3;
			this._recoveredType12495799.number9 += (long)num3;
			if (this.value2 != null)
			{
				this._recoveredType12495799.number3 = (this.number5 = 727.Method11313(this.number5, this.byteArray2, num2, num3));
			}
			Array.Copy(this.byteArray2, num2, this._recoveredType12495799.byteArray3, num, num3);
			num += num3;
			num2 += num3;
		}
		this._recoveredType12495799.number7 = num;
		this.number11 = num2;
		return 1;
	}

	// Token: 0x060019F1 RID: 6641 RVA: 0x0005F66E File Offset: 0x0005D86E
	internal void Method7508()
	{
		this.Method7510(null);
		this.byteArray2 = null;
		this.numberArray5 = null;
	}

	// Token: 0x060019F2 RID: 6642 RVA: 0x0005F688 File Offset: 0x0005D888
	internal int Method7509(int 1)
	{
		int num = this._recoveredType12495799.number6;
		int num2 = this._recoveredType12495799.number4;
		int num3 = this.number3;
		int i = this.number4;
		int num4 = this.number13;
		int num5 = (num4 < this.number11) ? (this.number11 - num4 - 1) : (this.number6 - num4);
		int num10;
		int num11;
		for (;;)
		{
			switch (this.number10)
			{
			case 0:
			{
				while (i < 3)
				{
					if (num2 == 0)
					{
						goto IL_860;
					}
					1 = 0;
					num2--;
					num3 |= (int)(this._recoveredType12495799.byteArray2[num++] & byte.MaxValue) << i;
					i += 8;
				}
				int num6 = num3 & 7;
				this.number8 = (num6 & 1);
				switch (383.Method2141(num6, 1))
				{
				case 0:
					num3 = 383.Method2141(num3, 3);
					i -= 3;
					num6 = (i & 7);
					num3 = 383.Method2141(num3, num6);
					i -= num6;
					this.number10 = 1;
					continue;
				case 1:
				{
					int[] array = new int[1];
					int[] array2 = new int[1];
					int[][] array3 = new int[1][];
					int[][] array4 = new int[1][];
					776.Method12746(array, array2, array3, array4, this._recoveredType12495799);
					this._recoveredType22805807.Method12429(array[0], array2[0], array3[0], 0, array4[0], 0);
					num3 = 383.Method2141(num3, 3);
					i -= 3;
					this.number10 = 6;
					continue;
				}
				case 2:
					num3 = 383.Method2141(num3, 3);
					i -= 3;
					this.number10 = 3;
					continue;
				case 3:
					goto IL_9A2;
				default:
					continue;
				}
				break;
			}
			case 1:
				while (i < 32)
				{
					if (num2 == 0)
					{
						goto IL_A4B;
					}
					1 = 0;
					num2--;
					num3 |= (int)(this._recoveredType12495799.byteArray2[num++] & byte.MaxValue) << i;
					i += 8;
				}
				if ((383.Method2141(~num3, 16) & 65535) != (num3 & 65535))
				{
					goto Block_33;
				}
				this.number9 = (num3 & 65535);
				i = (num3 = 0);
				this.number10 = ((this.number9 != 0) ? 2 : ((this.number8 != 0) ? 7 : 0));
				continue;
			case 2:
			{
				if (num2 == 0)
				{
					goto IL_D02;
				}
				if (num5 == 0)
				{
					if (num4 == this.number6 && this.number11 != 0)
					{
						num4 = 0;
						num5 = ((num4 < this.number11) ? (this.number11 - num4 - 1) : (this.number6 - num4));
					}
					if (num5 == 0)
					{
						this.number13 = num4;
						1 = this.Method7507(1);
						num4 = this.number13;
						num5 = ((num4 < this.number11) ? (this.number11 - num4 - 1) : (this.number6 - num4));
						if (num4 == this.number6 && this.number11 != 0)
						{
							num4 = 0;
							num5 = ((num4 < this.number11) ? (this.number11 - num4 - 1) : (this.number6 - num4));
						}
						if (num5 == 0)
						{
							goto Block_46;
						}
					}
				}
				1 = 0;
				int num7 = this.number9;
				if (num7 > num2)
				{
					num7 = num2;
				}
				if (num7 > num5)
				{
					num7 = num5;
				}
				Array.Copy(this._recoveredType12495799.byteArray2, num, this.byteArray2, num4, num7);
				num += num7;
				num2 -= num7;
				num4 += num7;
				num5 -= num7;
				this.number9 -= num7;
				if (this.number9 == 0)
				{
					this.number10 = ((this.number8 != 0) ? 7 : 0);
					continue;
				}
				continue;
			}
			case 3:
			{
				while (i < 14)
				{
					if (num2 == 0)
					{
						goto IL_D83;
					}
					1 = 0;
					num2--;
					num3 |= (int)(this._recoveredType12495799.byteArray2[num++] & byte.MaxValue) << i;
					i += 8;
				}
				int num8 = this.number12 = (num3 & 16383);
				if ((num8 & 31) > 29 || (num8 >> 5 & 31) > 29)
				{
					goto IL_E0D;
				}
				num8 = 258 + (num8 & 31) + (num8 >> 5 & 31);
				if (this.numberArray3 == null || this.numberArray3.Length < num8)
				{
					this.numberArray3 = new int[num8];
				}
				else
				{
					for (int j = 0; j < num8; j++)
					{
						this.numberArray3[j] = 0;
					}
				}
				num3 = 383.Method2141(num3, 14);
				i -= 14;
				this.number7 = 0;
				this.number10 = 4;
				goto IL_148;
			}
			case 4:
				goto IL_148;
			case 5:
				goto IL_241;
			case 6:
				goto IL_65F;
			case 7:
				goto IL_736;
			case 8:
				goto IL_7DC;
			case 9:
				goto IL_EF3;
			}
			break;
			IL_148:
			while (this.number7 < 4 + 383.Method2141(this.number12, 10))
			{
				while (i < 3)
				{
					if (num2 == 0)
					{
						goto IL_B7;
					}
					1 = 0;
					num2--;
					num3 |= (int)(this._recoveredType12495799.byteArray2[num++] & byte.MaxValue) << i;
					i += 8;
				}
				int[] array5 = this.numberArray3;
				int[] array6 = 557.numberArray4;
				int num9 = this.number7;
				this.number7 = num9 + 1;
				array5[array6[num9]] = (num3 & 7);
				num3 = 383.Method2141(num3, 3);
				i -= 3;
			}
			while (this.number7 < 19)
			{
				int[] array7 = this.numberArray3;
				int[] array8 = 557.numberArray4;
				int num9 = this.number7;
				this.number7 = num9 + 1;
				array7[array8[num9]] = 0;
			}
			this.numberArray2[0] = 7;
			num10 = this._recoveredType23315812.Method12744(this.numberArray3, this.numberArray2, this.numberArray7, this.numberArray5, this._recoveredType12495799);
			if (num10 != 0)
			{
				goto Block_7;
			}
			this.number7 = 0;
			this.number10 = 5;
			for (;;)
			{
				IL_241:
				num11 = this.number12;
				if (this.number7 >= 258 + (num11 & 31) + (num11 >> 5 & 31))
				{
					break;
				}
				num11 = this.numberArray2[0];
				while (i < num11)
				{
					if (num2 == 0)
					{
						goto IL_2A1;
					}
					1 = 0;
					num2--;
					num3 |= (int)(this._recoveredType12495799.byteArray2[num++] & byte.MaxValue) << i;
					i += 8;
				}
				int num12 = this.numberArray7[0];
				num11 = this.numberArray5[(this.numberArray7[0] + (num3 & 557.numberArray6[num11])) * 3 + 1];
				int num13 = this.numberArray5[(this.numberArray7[0] + (num3 & 557.numberArray6[num11])) * 3 + 2];
				if (num13 < 16)
				{
					num3 = 383.Method2141(num3, num11);
					i -= num11;
					int[] array9 = this.numberArray3;
					int num9 = this.number7;
					this.number7 = num9 + 1;
					array9[num9] = num13;
				}
				else
				{
					int num14 = (num13 == 18) ? 7 : (num13 - 14);
					int num15 = (num13 == 18) ? 11 : 3;
					while (i < num11 + num14)
					{
						if (num2 == 0)
						{
							goto IL_3CF;
						}
						1 = 0;
						num2--;
						num3 |= (int)(this._recoveredType12495799.byteArray2[num++] & byte.MaxValue) << i;
						i += 8;
					}
					num3 = 383.Method2141(num3, num11);
					i -= num11;
					num15 += (num3 & 557.numberArray6[num14]);
					num3 = 383.Method2141(num3, num14);
					i -= num14;
					num14 = this.number7;
					num11 = this.number12;
					if (num14 + num15 > 258 + (num11 & 31) + (num11 >> 5 & 31) || (num13 == 16 && num14 < 1))
					{
						goto IL_494;
					}
					num13 = ((num13 == 16) ? this.numberArray3[num14 - 1] : 0);
					do
					{
						this.numberArray3[num14++] = num13;
					}
					while (--num15 != 0);
					this.number7 = num14;
				}
			}
			this.numberArray7[0] = -1;
			int[] array10 = new int[]
			{
				9
			};
			int[] array11 = new int[]
			{
				6
			};
			int[] array12 = new int[1];
			int[] array13 = new int[1];
			num11 = this.number12;
			num11 = this._recoveredType23315812.Method12745(257 + (num11 & 31), 1 + (num11 >> 5 & 31), this.numberArray3, array10, array11, array12, array13, this.numberArray5, this._recoveredType12495799);
			if (num11 != 0)
			{
				goto Block_21;
			}
			this._recoveredType22805807.Method12429(array10[0], array11[0], this.numberArray5, array12[0], this.numberArray5, array13[0]);
			this.number10 = 6;
			IL_65F:
			this.number3 = num3;
			this.number4 = i;
			this._recoveredType12495799.number4 = num2;
			this._recoveredType12495799.number8 += (long)(num - this._recoveredType12495799.number6);
			this._recoveredType12495799.number6 = num;
			this.number13 = num4;
			if ((1 = this._recoveredType22805807.Method12430(this, 1)) != 1)
			{
				goto Block_23;
			}
			1 = 0;
			num = this._recoveredType12495799.number6;
			num2 = this._recoveredType12495799.number4;
			num3 = this.number3;
			i = this.number4;
			num4 = this.number13;
			num5 = ((num4 < this.number11) ? (this.number11 - num4 - 1) : (this.number6 - num4));
			if (this.number8 != 0)
			{
				goto IL_72F;
			}
			this.number10 = 0;
		}
		1 = -2;
		this.number3 = num3;
		this.number4 = i;
		this._recoveredType12495799.number4 = num2;
		this._recoveredType12495799.number8 += (long)(num - this._recoveredType12495799.number6);
		this._recoveredType12495799.number6 = num;
		this.number13 = num4;
		return this.Method7507(1);
		IL_B7:
		this.number3 = num3;
		this.number4 = i;
		this._recoveredType12495799.number4 = num2;
		this._recoveredType12495799.number8 += (long)(num - this._recoveredType12495799.number6);
		this._recoveredType12495799.number6 = num;
		this.number13 = num4;
		return this.Method7507(1);
		Block_7:
		1 = num10;
		if (1 == -3)
		{
			this.numberArray3 = null;
			this.number10 = 9;
		}
		this.number3 = num3;
		this.number4 = i;
		this._recoveredType12495799.number4 = num2;
		this._recoveredType12495799.number8 += (long)(num - this._recoveredType12495799.number6);
		this._recoveredType12495799.number6 = num;
		this.number13 = num4;
		return this.Method7507(1);
		IL_2A1:
		this.number3 = num3;
		this.number4 = i;
		this._recoveredType12495799.number4 = num2;
		this._recoveredType12495799.number8 += (long)(num - this._recoveredType12495799.number6);
		this._recoveredType12495799.number6 = num;
		this.number13 = num4;
		return this.Method7507(1);
		IL_3CF:
		this.number3 = num3;
		this.number4 = i;
		this._recoveredType12495799.number4 = num2;
		this._recoveredType12495799.number8 += (long)(num - this._recoveredType12495799.number6);
		this._recoveredType12495799.number6 = num;
		this.number13 = num4;
		return this.Method7507(1);
		IL_494:
		this.numberArray3 = null;
		this.number10 = 9;
		this._recoveredType12495799.text = "invalid bit length repeat";
		1 = -3;
		this.number3 = num3;
		this.number4 = i;
		this._recoveredType12495799.number4 = num2;
		this._recoveredType12495799.number8 += (long)(num - this._recoveredType12495799.number6);
		this._recoveredType12495799.number6 = num;
		this.number13 = num4;
		return this.Method7507(1);
		Block_21:
		if (num11 == -3)
		{
			this.numberArray3 = null;
			this.number10 = 9;
		}
		1 = num11;
		this.number3 = num3;
		this.number4 = i;
		this._recoveredType12495799.number4 = num2;
		this._recoveredType12495799.number8 += (long)(num - this._recoveredType12495799.number6);
		this._recoveredType12495799.number6 = num;
		this.number13 = num4;
		return this.Method7507(1);
		Block_23:
		return this.Method7507(1);
		IL_72F:
		this.number10 = 7;
		IL_736:
		this.number13 = num4;
		1 = this.Method7507(1);
		num4 = this.number13;
		int num16 = (num4 < this.number11) ? (this.number11 - num4 - 1) : (this.number6 - num4);
		if (this.number11 != this.number13)
		{
			this.number3 = num3;
			this.number4 = i;
			this._recoveredType12495799.number4 = num2;
			this._recoveredType12495799.number8 += (long)(num - this._recoveredType12495799.number6);
			this._recoveredType12495799.number6 = num;
			this.number13 = num4;
			return this.Method7507(1);
		}
		this.number10 = 8;
		IL_7DC:
		1 = 1;
		this.number3 = num3;
		this.number4 = i;
		this._recoveredType12495799.number4 = num2;
		this._recoveredType12495799.number8 += (long)(num - this._recoveredType12495799.number6);
		this._recoveredType12495799.number6 = num;
		this.number13 = num4;
		return this.Method7507(1);
		IL_860:
		this.number3 = num3;
		this.number4 = i;
		this._recoveredType12495799.number4 = num2;
		this._recoveredType12495799.number8 += (long)(num - this._recoveredType12495799.number6);
		this._recoveredType12495799.number6 = num;
		this.number13 = num4;
		return this.Method7507(1);
		IL_9A2:
		num3 = 383.Method2141(num3, 3);
		i -= 3;
		this.number10 = 9;
		this._recoveredType12495799.text = "invalid block type";
		1 = -3;
		this.number3 = num3;
		this.number4 = i;
		this._recoveredType12495799.number4 = num2;
		this._recoveredType12495799.number8 += (long)(num - this._recoveredType12495799.number6);
		this._recoveredType12495799.number6 = num;
		this.number13 = num4;
		return this.Method7507(1);
		IL_A4B:
		this.number3 = num3;
		this.number4 = i;
		this._recoveredType12495799.number4 = num2;
		this._recoveredType12495799.number8 += (long)(num - this._recoveredType12495799.number6);
		this._recoveredType12495799.number6 = num;
		this.number13 = num4;
		return this.Method7507(1);
		Block_33:
		this.number10 = 9;
		this._recoveredType12495799.text = "invalid stored block lengths";
		1 = -3;
		this.number3 = num3;
		this.number4 = i;
		this._recoveredType12495799.number4 = num2;
		this._recoveredType12495799.number8 += (long)(num - this._recoveredType12495799.number6);
		this._recoveredType12495799.number6 = num;
		this.number13 = num4;
		return this.Method7507(1);
		Block_46:
		this.number3 = num3;
		this.number4 = i;
		this._recoveredType12495799.number4 = num2;
		this._recoveredType12495799.number8 += (long)(num - this._recoveredType12495799.number6);
		this._recoveredType12495799.number6 = num;
		this.number13 = num4;
		return this.Method7507(1);
		IL_D02:
		this.number3 = num3;
		this.number4 = i;
		this._recoveredType12495799.number4 = num2;
		this._recoveredType12495799.number8 += (long)(num - this._recoveredType12495799.number6);
		this._recoveredType12495799.number6 = num;
		this.number13 = num4;
		return this.Method7507(1);
		IL_D83:
		this.number3 = num3;
		this.number4 = i;
		this._recoveredType12495799.number4 = num2;
		this._recoveredType12495799.number8 += (long)(num - this._recoveredType12495799.number6);
		this._recoveredType12495799.number6 = num;
		this.number13 = num4;
		return this.Method7507(1);
		IL_E0D:
		this.number10 = 9;
		this._recoveredType12495799.text = "too many length or distance symbols";
		1 = -3;
		this.number3 = num3;
		this.number4 = i;
		this._recoveredType12495799.number4 = num2;
		this._recoveredType12495799.number8 += (long)(num - this._recoveredType12495799.number6);
		this._recoveredType12495799.number6 = num;
		this.number13 = num4;
		return this.Method7507(1);
		IL_EF3:
		1 = -3;
		this.number3 = num3;
		this.number4 = i;
		this._recoveredType12495799.number4 = num2;
		this._recoveredType12495799.number8 += (long)(num - this._recoveredType12495799.number6);
		this._recoveredType12495799.number6 = num;
		this.number13 = num4;
		return this.Method7507(1);
	}

	// Token: 0x060019F3 RID: 6643 RVA: 0x0006063C File Offset: 0x0005E83C
	internal void Method7510(long[] 1)
	{
		if (1 != null)
		{
			1[0] = this.number5;
		}
		this.number10 = 0;
		this.number4 = 0;
		this.number3 = 0;
		this.number11 = (this.number13 = 0);
		if (this.value2 != null)
		{
			this._recoveredType12495799.number3 = (this.number5 = 727.Method11313(0L, null, 0, 0));
		}
	}

	// Token: 0x060019F4 RID: 6644 RVA: 0x000606A0 File Offset: 0x0005E8A0
	internal void Method7511(byte[] 1, int 2, int 3)
	{
		Array.Copy(1, 2, this.byteArray2, 0, 3);
		this.number13 = 3;
		this.number11 = 3;
	}

	// Token: 0x060019F5 RID: 6645 RVA: 0x000606CC File Offset: 0x0005E8CC
	internal int Method7512()
	{
		if (this.number10 != 1)
		{
			return 0;
		}
		return 1;
	}

	// Token: 0x04000C31 RID: 3121
	internal 552 _recoveredType12495799;

	// Token: 0x04000C32 RID: 3122
	internal int[] numberArray2 = new int[1];

	// Token: 0x04000C33 RID: 3123
	internal int number3;

	// Token: 0x04000C34 RID: 3124
	internal int number4;

	// Token: 0x04000C35 RID: 3125
	internal int[] numberArray3;

	// Token: 0x04000C36 RID: 3126
	internal static readonly int[] numberArray4 = new int[]
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

	// Token: 0x04000C37 RID: 3127
	internal long number5;

	// Token: 0x04000C38 RID: 3128
	internal object value2;

	// Token: 0x04000C39 RID: 3129
	internal 770 _recoveredType22805807 = new 770();

	// Token: 0x04000C3A RID: 3130
	internal int number6;

	// Token: 0x04000C3B RID: 3131
	internal int[] numberArray5;

	// Token: 0x04000C3C RID: 3132
	internal int number7;

	// Token: 0x04000C3D RID: 3133
	private static readonly int[] numberArray6 = new int[]
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

	// Token: 0x04000C3E RID: 3134
	internal 776 _recoveredType23315812 = new 776();

	// Token: 0x04000C3F RID: 3135
	internal int number8;

	// Token: 0x04000C40 RID: 3136
	internal int number9;

	// Token: 0x04000C41 RID: 3137
	internal int number10;

	// Token: 0x04000C42 RID: 3138
	internal int number11;

	// Token: 0x04000C43 RID: 3139
	internal int number12;

	// Token: 0x04000C44 RID: 3140
	internal int[] numberArray7 = new int[1];

	// Token: 0x04000C45 RID: 3141
	internal byte[] byteArray2;

	// Token: 0x04000C46 RID: 3142
	internal int number13;
}
