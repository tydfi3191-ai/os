using System;
using System.IO;
using System.Runtime.InteropServices;

// Token: 0x02000213 RID: 531
[ComVisible(false)]
public sealed class 187 : 749, 501, 500
{
	// Token: 0x060010AA RID: 4266 RVA: 0x00039BA4 File Offset: 0x00037DA4
	static 187()
	{
		int num = 2;
		187.byteArray[0] = 0;
		187.byteArray[1] = 1;
		for (byte b = 2; b < 22; b += 1)
		{
			uint num2 = 1U << (b >> 1) - 1;
			uint num3 = 0U;
			while (num3 < num2)
			{
				187.byteArray[num] = b;
				num3 += 1U;
				num++;
			}
		}
	}

	// Token: 0x060010AB RID: 4267 RVA: 0x00039C20 File Offset: 0x00037E20
	public 187()
	{
		int num = 0;
		while ((long)num < 4096L)
		{
			this.lzmaEncoderClosureArray[num] = new 187.188();
			num++;
		}
		int num2 = 0;
		while ((long)num2 < 4L)
		{
			this._recoveredType2321Array3561[num2] = new 774(6);
			num2++;
		}
	}

	// Token: 0x060010AC RID: 4268 RVA: 0x00039DE9 File Offset: 0x00037FE9
	private static uint Method4550(uint 1)
	{
		if (1 < 2048U)
		{
			return (uint)187.byteArray[(int)1];
		}
		if (1 < 2097152U)
		{
			return (uint)(187.byteArray[(int)(1 >> 10)] + 20);
		}
		return (uint)(187.byteArray[(int)(1 >> 20)] + 40);
	}

	// Token: 0x060010AD RID: 4269 RVA: 0x00039E1E File Offset: 0x0003801E
	private static uint Method4551(uint 1)
	{
		if (1 < 131072U)
		{
			return (uint)(187.byteArray[(int)(1 >> 6)] + 12);
		}
		if (1 < 134217728U)
		{
			return (uint)(187.byteArray[(int)(1 >> 16)] + 32);
		}
		return (uint)(187.byteArray[(int)(1 >> 26)] + 52);
	}

	// Token: 0x060010AE RID: 4270 RVA: 0x00039E58 File Offset: 0x00038058
	private void Method4552()
	{
		this._recoveredType14753549.SetNumber6486_8315();
		this.byteValue4 = 0;
		for (uint num = 0U; num < 4U; num += 1U)
		{
			this.numberArray2[(int)num] = 0U;
		}
	}

	// Token: 0x060010AF RID: 4271 RVA: 0x00039E8C File Offset: 0x0003808C
	private void Method4553()
	{
		if (this._recoveredType23863553 == null)
		{
			591 <<EMPTY_NAME>> = new 591();
			int 2 = 4;
			if (this._recoveredType08183590 == (187.193)0)
			{
				2 = 2;
			}
			<<EMPTY_NAME>>.Method7990(2);
			this._recoveredType23863553 = <<EMPTY_NAME>>;
		}
		this._recoveredType08133566.Method4536(this.number20, this.number21);
		if (this.number22 != this.number23 || this.number24 != this.number10)
		{
			this._recoveredType23863553.Method7998(this.number22, 4096U, this.number10, 274U);
			this.number23 = this.number22;
			this.number24 = this.number10;
		}
	}

	// Token: 0x060010B0 RID: 4272 RVA: 0x00039F2D File Offset: 0x0003812D
	private void SetFlag3591_4554(bool 1)
	{
		this.flag4 = 1;
	}

	// Token: 0x060010B1 RID: 4273 RVA: 0x00039F38 File Offset: 0x00038138
	private void Method4555()
	{
		this.Method4552();
		this.lzmaRangeEncoder2.Init();
		for (uint num = 0U; num < 12U; num += 1U)
		{
			for (uint num2 = 0U; num2 <= this.number19; num2 += 1U)
			{
				uint num3 = (num << 4) + num2;
				this.lzmaBitModelArray[(int)num3].Init();
				this.lzmaBitModelArray6[(int)num3].Init();
			}
			this.lzmaBitModelArray2[(int)num].Init();
			this.lzmaBitModelArray3[(int)num].Init();
			this.lzmaBitModelArray4[(int)num].Init();
			this.lzmaBitModelArray5[(int)num].Init();
		}
		this._recoveredType08133566.Method4537();
		for (uint num4 = 0U; num4 < 4U; num4 += 1U)
		{
			this._recoveredType2321Array3561[(int)num4].Method12690();
		}
		for (uint num5 = 0U; num5 < 114U; num5 += 1U)
		{
			this.lzmaBitModelArray7[(int)num5].Init();
		}
		this._recoveredType08173564.Method4542(1U << this.number18);
		this._recoveredType08173565.Method4542(1U << this.number18);
		this._recoveredType23213563.Method12690();
		this.flag2 = false;
		this.number14 = 0U;
		this.number15 = 0U;
		this.number13 = 0U;
	}

	// Token: 0x060010B2 RID: 4274 RVA: 0x0003A084 File Offset: 0x00038284
	private void Method4556(out uint 1, out uint 2)
	{
		1 = 0U;
		2 = this._recoveredType23863553.Method7999(this.numberArray3);
		if (2 != 0U)
		{
			1 = this.numberArray3[(int)(2 - 2U)];
			if (1 == this.number10)
			{
				1 += this._recoveredType23863553.Method7996((int)(1 - 1U), this.numberArray3[(int)(2 - 1U)], 273U - 1);
			}
		}
		this.number13 += 1U;
	}

	// Token: 0x060010B3 RID: 4275 RVA: 0x0003A0F7 File Offset: 0x000382F7
	private void Method4557(uint 1)
	{
		if (1 != 0U)
		{
			this._recoveredType23863553.Method8000(1);
			this.number13 += 1;
		}
	}

	// Token: 0x060010B4 RID: 4276 RVA: 0x0003A116 File Offset: 0x00038316
	private uint Method4558(602.603 1, uint 2)
	{
		return this.lzmaBitModelArray3[(int)1.number].GetPrice0() + this.lzmaBitModelArray6[(int)((1.number << 4) + 2)].GetPrice0();
	}

	// Token: 0x060010B5 RID: 4277 RVA: 0x0003A14C File Offset: 0x0003834C
	private uint Method4559(uint 1, 602.603 2, uint 3)
	{
		uint num;
		if (1 == 0U)
		{
			num = this.lzmaBitModelArray3[(int)2.number].GetPrice0();
			return num + this.lzmaBitModelArray6[(int)((2.number << 4) + 3)].GetPrice1();
		}
		num = this.lzmaBitModelArray3[(int)2.number].GetPrice1();
		if (1 == 1U)
		{
			return num + this.lzmaBitModelArray4[(int)2.number].GetPrice0();
		}
		num += this.lzmaBitModelArray4[(int)2.number].GetPrice1();
		return num + this.lzmaBitModelArray5[(int)2.number].GetPrice(1 - 2U);
	}

	// Token: 0x060010B6 RID: 4278 RVA: 0x0003A1F8 File Offset: 0x000383F8
	private uint Method4560(uint 1, uint 2, 602.603 3, uint 4)
	{
		return this._recoveredType08173565.Method4546(2 - 2U, 4) + this.Method4559(1, 3, 4);
	}

	// Token: 0x060010B7 RID: 4279 RVA: 0x0003A218 File Offset: 0x00038418
	private uint Method4561(uint 1, uint 2, uint 3)
	{
		uint num = 602.Method8321(2);
		return ((1 >= 128U) ? (this.numberArray4[(int)((num << 6) + 187.Method4551(1))] + this.numberArray6[(int)(1 & 15U)]) : this.numberArray5[(int)(num * 128U + 1)]) + this._recoveredType08173564.Method4546(2 - 2U, 3);
	}

	// Token: 0x060010B8 RID: 4280 RVA: 0x0003A274 File Offset: 0x00038474
	private uint Method4562(out uint 1, uint 2)
	{
		this.number14 = 2;
		uint number = this.lzmaEncoderClosureArray[(int)2].number4;
		uint number2 = this.lzmaEncoderClosureArray[(int)2].number5;
		do
		{
			if (this.lzmaEncoderClosureArray[(int)2].flag)
			{
				this.lzmaEncoderClosureArray[(int)number].Method4539();
				this.lzmaEncoderClosureArray[(int)number].number4 = number - 1U;
				if (this.lzmaEncoderClosureArray[(int)2].flag2)
				{
					this.lzmaEncoderClosureArray[(int)(number - 1U)].flag = false;
					this.lzmaEncoderClosureArray[(int)(number - 1U)].number4 = this.lzmaEncoderClosureArray[(int)2].number;
					this.lzmaEncoderClosureArray[(int)(number - 1U)].number5 = this.lzmaEncoderClosureArray[(int)2].number2;
				}
			}
			uint num = number;
			uint number3 = number2;
			number2 = this.lzmaEncoderClosureArray[(int)num].number5;
			number = this.lzmaEncoderClosureArray[(int)num].number4;
			this.lzmaEncoderClosureArray[(int)num].number5 = number3;
			this.lzmaEncoderClosureArray[(int)num].number4 = 2;
			2 = num;
		}
		while (2 != 0U);
		1 = this.lzmaEncoderClosureArray[0].number5;
		this.number15 = this.lzmaEncoderClosureArray[0].number4;
		return this.number15;
	}

	// Token: 0x060010B9 RID: 4281 RVA: 0x0003A394 File Offset: 0x00038594
	private uint Method4563(uint 1, out uint 2)
	{
		if (this.number14 != this.number15)
		{
			uint result = this.lzmaEncoderClosureArray[(int)this.number15].number4 - this.number15;
			2 = this.lzmaEncoderClosureArray[(int)this.number15].number5;
			this.number15 = this.lzmaEncoderClosureArray[(int)this.number15].number4;
			return result;
		}
		this.number15 = (this.number14 = 0U);
		uint num;
		uint num2;
		if (!this.flag2)
		{
			this.Method4556(out num, out num2);
		}
		else
		{
			num = this.number11;
			num2 = this.number12;
			this.flag2 = false;
		}
		uint num3 = this._recoveredType23863553.Method7997() + 1U;
		if (num3 < 2U)
		{
			2 = uint.MaxValue;
			return 1U;
		}
		if (num3 > 273U)
		{
		}
		uint num4 = 0U;
		for (uint num5 = 0U; num5 < 4U; num5 += 1U)
		{
			this.numberArray7[(int)num5] = this.numberArray2[(int)num5];
			this.numberArray8[(int)num5] = this._recoveredType23863553.Method7996(-1, this.numberArray7[(int)num5], 273U);
			if (this.numberArray8[(int)num5] > this.numberArray8[(int)num4])
			{
				num4 = num5;
			}
		}
		if (this.numberArray8[(int)num4] >= this.number10)
		{
			2 = num4;
			uint num6 = this.numberArray8[(int)num4];
			this.Method4557(num6 - 1U);
			return num6;
		}
		if (num >= this.number10)
		{
			2 = this.numberArray3[(int)(num2 - 1U)] + 4U;
			this.Method4557(num - 1U);
			return num;
		}
		byte b = this._recoveredType23863553.Method7995(-1);
		byte b2 = this._recoveredType23863553.Method7995((int)(0U - this.numberArray2[0] - 1U - 1U));
		if (num < 2U && b != b2 && this.numberArray8[(int)num4] < 2U)
		{
			2 = uint.MaxValue;
			return 1U;
		}
		this.lzmaEncoderClosureArray[0]._recoveredType14753528 = this._recoveredType14753549;
		uint num7 = 1 & this.number19;
		this.lzmaEncoderClosureArray[1].number3 = this.lzmaBitModelArray[(int)((this._recoveredType14753549.number << 4) + num7)].GetPrice0() + this._recoveredType08133566.Method4538(1, this.byteValue4).Method4535(!this._recoveredType14753549.Method8320(), b2, b);
		this.lzmaEncoderClosureArray[1].Method4539();
		uint num8 = this.lzmaBitModelArray[(int)((this._recoveredType14753549.number << 4) + num7)].GetPrice1();
		uint num9 = num8 + this.lzmaBitModelArray2[(int)this._recoveredType14753549.number].GetPrice1();
		if (b2 == b)
		{
			uint num10 = num9 + this.Method4558(this._recoveredType14753549, num7);
			if (num10 < this.lzmaEncoderClosureArray[1].number3)
			{
				this.lzmaEncoderClosureArray[1].number3 = num10;
				this.lzmaEncoderClosureArray[1].Method4540();
			}
		}
		uint num11 = (num >= this.numberArray8[(int)num4]) ? num : this.numberArray8[(int)num4];
		if (num11 < 2U)
		{
			2 = this.lzmaEncoderClosureArray[1].number5;
			return 1U;
		}
		this.lzmaEncoderClosureArray[1].number4 = 0U;
		this.lzmaEncoderClosureArray[0].number6 = this.numberArray7[0];
		this.lzmaEncoderClosureArray[0].number7 = this.numberArray7[1];
		this.lzmaEncoderClosureArray[0].number8 = this.numberArray7[2];
		this.lzmaEncoderClosureArray[0].number9 = this.numberArray7[3];
		uint num12 = num11;
		do
		{
			this.lzmaEncoderClosureArray[(int)num12--].number3 = 268435455U;
		}
		while (num12 >= 2U);
		for (uint num13 = 0U; num13 < 4U; num13 += 1U)
		{
			uint num14 = this.numberArray8[(int)num13];
			if (num14 >= 2U)
			{
				uint num15 = num9 + this.Method4559(num13, this._recoveredType14753549, num7);
				do
				{
					uint num16 = num15 + this._recoveredType08173565.Method4546(num14 - 2U, num7);
					187.188 3 = this.lzmaEncoderClosureArray[(int)num14];
					if (num16 < 3.number3)
					{
						3.number3 = num16;
						3.number4 = 0U;
						3.number5 = num13;
						3.flag = false;
					}
				}
				while ((num14 -= 1U) >= 2U);
			}
		}
		uint num17 = num8 + this.lzmaBitModelArray2[(int)this._recoveredType14753549.number].GetPrice0();
		num12 = ((this.numberArray8[0] >= 2U) ? (this.numberArray8[0] + 1U) : 2U);
		if (num12 <= num)
		{
			uint num18 = 0U;
			while (num12 > this.numberArray3[(int)num18])
			{
				num18 += 2U;
			}
			for (;;)
			{
				uint num19 = this.numberArray3[(int)(num18 + 1U)];
				uint num20 = num17 + this.Method4561(num19, num12, num7);
				187.188 4 = this.lzmaEncoderClosureArray[(int)num12];
				if (num20 < 4.number3)
				{
					4.number3 = num20;
					4.number4 = 0U;
					4.number5 = num19 + 4U;
					4.flag = false;
				}
				if (num12 == this.numberArray3[(int)num18])
				{
					num18 += 2U;
					if (num18 == num2)
					{
						break;
					}
				}
				num12 += 1U;
			}
		}
		uint num21 = 0U;
		uint num22;
		for (;;)
		{
			num21 += 1U;
			if (num21 == num11)
			{
				break;
			}
			this.Method4556(out num22, out num2);
			if (num22 >= this.number10)
			{
				goto IL_FD3;
			}
			1 += 1U;
			uint num23 = this.lzmaEncoderClosureArray[(int)num21].number4;
			602.603 recoveredType;
			if (this.lzmaEncoderClosureArray[(int)num21].flag)
			{
				num23 -= 1U;
				if (this.lzmaEncoderClosureArray[(int)num21].flag2)
				{
					recoveredType = this.lzmaEncoderClosureArray[(int)this.lzmaEncoderClosureArray[(int)num21].number]._recoveredType14753528;
					if (this.lzmaEncoderClosureArray[(int)num21].number2 < 4U)
					{
						recoveredType.SetNumber6486_8318();
					}
					else
					{
						recoveredType.SetNumber6486_8317();
					}
				}
				else
				{
					recoveredType = this.lzmaEncoderClosureArray[(int)num23]._recoveredType14753528;
				}
				recoveredType.Method8316();
			}
			else
			{
				recoveredType = this.lzmaEncoderClosureArray[(int)num23]._recoveredType14753528;
			}
			if (num23 == num21 - 1U)
			{
				if (this.lzmaEncoderClosureArray[(int)num21].Method4541())
				{
					recoveredType.SetNumber6486_8319();
				}
				else
				{
					recoveredType.Method8316();
				}
			}
			else
			{
				uint num24;
				if (this.lzmaEncoderClosureArray[(int)num21].flag && this.lzmaEncoderClosureArray[(int)num21].flag2)
				{
					num23 = this.lzmaEncoderClosureArray[(int)num21].number;
					num24 = this.lzmaEncoderClosureArray[(int)num21].number2;
					recoveredType.SetNumber6486_8318();
				}
				else
				{
					num24 = this.lzmaEncoderClosureArray[(int)num21].number5;
					if (num24 < 4U)
					{
						recoveredType.SetNumber6486_8318();
					}
					else
					{
						recoveredType.SetNumber6486_8317();
					}
				}
				187.188 5 = this.lzmaEncoderClosureArray[(int)num23];
				switch (num24)
				{
				case 0U:
					this.numberArray7[0] = 5.number6;
					this.numberArray7[1] = 5.number7;
					this.numberArray7[2] = 5.number8;
					this.numberArray7[3] = 5.number9;
					break;
				case 1U:
					this.numberArray7[0] = 5.number7;
					this.numberArray7[1] = 5.number6;
					this.numberArray7[2] = 5.number8;
					this.numberArray7[3] = 5.number9;
					break;
				case 2U:
					this.numberArray7[0] = 5.number8;
					this.numberArray7[1] = 5.number6;
					this.numberArray7[2] = 5.number7;
					this.numberArray7[3] = 5.number9;
					break;
				case 3U:
					this.numberArray7[0] = 5.number9;
					this.numberArray7[1] = 5.number6;
					this.numberArray7[2] = 5.number7;
					this.numberArray7[3] = 5.number8;
					break;
				default:
					this.numberArray7[0] = num24 - 4U;
					this.numberArray7[1] = 5.number6;
					this.numberArray7[2] = 5.number7;
					this.numberArray7[3] = 5.number8;
					break;
				}
			}
			this.lzmaEncoderClosureArray[(int)num21]._recoveredType14753528 = recoveredType;
			this.lzmaEncoderClosureArray[(int)num21].number6 = this.numberArray7[0];
			this.lzmaEncoderClosureArray[(int)num21].number7 = this.numberArray7[1];
			this.lzmaEncoderClosureArray[(int)num21].number8 = this.numberArray7[2];
			this.lzmaEncoderClosureArray[(int)num21].number9 = this.numberArray7[3];
			uint number = this.lzmaEncoderClosureArray[(int)num21].number3;
			b = this._recoveredType23863553.Method7995(-1);
			b2 = this._recoveredType23863553.Method7995((int)(0U - this.numberArray7[0] - 1U - 1U));
			num7 = (1 & this.number19);
			uint num25 = number + this.lzmaBitModelArray[(int)((recoveredType.number << 4) + num7)].GetPrice0() + this._recoveredType08133566.Method4538(1, this._recoveredType23863553.Method7995(-2)).Method4535(!recoveredType.Method8320(), b2, b);
			187.188 6 = this.lzmaEncoderClosureArray[(int)(num21 + 1U)];
			bool flag = false;
			if (num25 < 6.number3)
			{
				6.number3 = num25;
				6.number4 = num21;
				6.Method4539();
				flag = true;
			}
			num8 = number + this.lzmaBitModelArray[(int)((recoveredType.number << 4) + num7)].GetPrice1();
			num9 = num8 + this.lzmaBitModelArray2[(int)recoveredType.number].GetPrice1();
			if (b2 == b && (6.number4 >= num21 || 6.number5 != 0U))
			{
				uint num26 = num9 + this.Method4558(recoveredType, num7);
				if (num26 <= 6.number3)
				{
					6.number3 = num26;
					6.number4 = num21;
					6.Method4540();
					flag = true;
				}
			}
			uint num27 = this._recoveredType23863553.Method7997() + 1U;
			num27 = Math.Min(4095U - num21, num27);
			num3 = num27;
			if (num3 >= 2U)
			{
				if (num3 > this.number10)
				{
					num3 = this.number10;
				}
				if (!flag && b2 != b)
				{
					uint 7 = Math.Min(num27 - 1U, this.number10);
					uint num28 = this._recoveredType23863553.Method7996(0, this.numberArray7[0], 7);
					if (num28 >= 2U)
					{
						602.603 8 = recoveredType;
						8.Method8316();
						uint num29 = 1 + 1U & this.number19;
						uint num30 = num25 + this.lzmaBitModelArray[(int)((8.number << 4) + num29)].GetPrice1() + this.lzmaBitModelArray2[(int)8.number].GetPrice1();
						uint num31 = num21 + 1U + num28;
						while (num11 < num31)
						{
							this.lzmaEncoderClosureArray[(int)(num11 += 1U)].number3 = 268435455U;
						}
						uint num32 = num30 + this.Method4560(0U, num28, 8, num29);
						187.188 9 = this.lzmaEncoderClosureArray[(int)num31];
						if (num32 < 9.number3)
						{
							9.number3 = num32;
							9.number4 = num21 + 1U;
							9.number5 = 0U;
							9.flag = true;
							9.flag2 = false;
						}
					}
				}
				uint num33 = 2U;
				for (uint num34 = 0U; num34 < 4U; num34 += 1U)
				{
					uint num35 = this._recoveredType23863553.Method7996(-1, this.numberArray7[(int)num34], num3);
					if (num35 >= 2U)
					{
						uint num36 = num35;
						for (;;)
						{
							if (num11 < num21 + num35)
							{
								this.lzmaEncoderClosureArray[(int)(num11 += 1U)].number3 = 268435455U;
							}
							else
							{
								uint num37 = num9 + this.Method4560(num34, num35, recoveredType, num7);
								187.188 10 = this.lzmaEncoderClosureArray[(int)(num21 + num35)];
								if (num37 < 10.number3)
								{
									10.number3 = num37;
									10.number4 = num21;
									10.number5 = num34;
									10.flag = false;
								}
								if ((num35 -= 1U) < 2U)
								{
									break;
								}
							}
						}
						num35 = num36;
						if (num34 == 0U)
						{
							num33 = num35 + 1U;
						}
						if (num35 < num27)
						{
							uint 11 = Math.Min(num27 - 1U - num35, this.number10);
							uint num38 = this._recoveredType23863553.Method7996((int)num35, this.numberArray7[(int)num34], 11);
							if (num38 >= 2U)
							{
								602.603 12 = recoveredType;
								12.SetNumber6486_8318();
								uint num39 = 1 + num35 & this.number19;
								uint num40 = num9 + this.Method4560(num34, num35, recoveredType, num7) + this.lzmaBitModelArray[(int)((12.number << 4) + num39)].GetPrice0() + this._recoveredType08133566.Method4538(1 + num35, this._recoveredType23863553.Method7995((int)(num35 - 1U - 1U))).Method4535(true, this._recoveredType23863553.Method7995((int)(num35 - 1U - (this.numberArray7[(int)num34] + 1U))), this._recoveredType23863553.Method7995((int)(num35 - 1U)));
								12.Method8316();
								num39 = (1 + num35 + 1U & this.number19);
								uint num41 = num40 + this.lzmaBitModelArray[(int)((12.number << 4) + num39)].GetPrice1() + this.lzmaBitModelArray2[(int)12.number].GetPrice1();
								uint num42 = num35 + 1U + num38;
								while (num11 < num21 + num42)
								{
									this.lzmaEncoderClosureArray[(int)(num11 += 1U)].number3 = 268435455U;
								}
								uint num43 = num41 + this.Method4560(0U, num38, 12, num39);
								187.188 13 = this.lzmaEncoderClosureArray[(int)(num21 + num42)];
								if (num43 < 13.number3)
								{
									13.number3 = num43;
									13.number4 = num21 + num35 + 1U;
									13.number5 = 0U;
									13.flag = true;
									13.flag2 = true;
									13.number = num21;
									13.number2 = num34;
								}
							}
						}
					}
				}
				if (num22 > num3)
				{
					num22 = num3;
					num2 = 0U;
					while (num22 > this.numberArray3[(int)num2])
					{
						num2 += 2U;
					}
					this.numberArray3[(int)num2] = num22;
					num2 += 2U;
				}
				if (num22 >= num33)
				{
					num17 = num8 + this.lzmaBitModelArray2[(int)recoveredType.number].GetPrice0();
					while (num11 < num21 + num22)
					{
						this.lzmaEncoderClosureArray[(int)(num11 += 1U)].number3 = 268435455U;
					}
					uint num44 = 0U;
					while (num33 > this.numberArray3[(int)num44])
					{
						num44 += 2U;
					}
					uint num45 = num33;
					for (;;)
					{
						uint num46 = this.numberArray3[(int)(num44 + 1U)];
						uint num47 = num17 + this.Method4561(num46, num45, num7);
						187.188 14 = this.lzmaEncoderClosureArray[(int)(num21 + num45)];
						if (num47 < 14.number3)
						{
							14.number3 = num47;
							14.number4 = num21;
							14.number5 = num46 + 4U;
							14.flag = false;
						}
						if (num45 == this.numberArray3[(int)num44])
						{
							if (num45 < num27)
							{
								uint 15 = Math.Min(num27 - 1U - num45, this.number10);
								uint num48 = this._recoveredType23863553.Method7996((int)num45, num46, 15);
								if (num48 >= 2U)
								{
									602.603 16 = recoveredType;
									16.SetNumber6486_8317();
									uint num49 = 1 + num45 & this.number19;
									uint num50 = num47 + this.lzmaBitModelArray[(int)((16.number << 4) + num49)].GetPrice0() + this._recoveredType08133566.Method4538(1 + num45, this._recoveredType23863553.Method7995((int)(num45 - 1U - 1U))).Method4535(true, this._recoveredType23863553.Method7995((int)(num45 - (num46 + 1U) - 1U)), this._recoveredType23863553.Method7995((int)(num45 - 1U)));
									16.Method8316();
									num49 = (1 + num45 + 1U & this.number19);
									uint num51 = num50 + this.lzmaBitModelArray[(int)((16.number << 4) + num49)].GetPrice1() + this.lzmaBitModelArray2[(int)16.number].GetPrice1();
									uint num52 = num45 + 1U + num48;
									while (num11 < num21 + num52)
									{
										this.lzmaEncoderClosureArray[(int)(num11 += 1U)].number3 = 268435455U;
									}
									num47 = num51 + this.Method4560(0U, num48, 16, num49);
									14 = this.lzmaEncoderClosureArray[(int)(num21 + num52)];
									if (num47 < 14.number3)
									{
										14.number3 = num47;
										14.number4 = num21 + num45 + 1U;
										14.number5 = 0U;
										14.flag = true;
										14.flag2 = true;
										14.number = num21;
										14.number2 = num46 + 4U;
									}
								}
							}
							num44 += 2U;
							if (num44 == num2)
							{
								break;
							}
						}
						num45 += 1U;
					}
				}
			}
		}
		return this.Method4562(out 2, num21);
		IL_FD3:
		this.number12 = num2;
		this.number11 = num22;
		this.flag2 = true;
		return this.Method4562(out 2, num21);
	}

	// Token: 0x060010BA RID: 4282 RVA: 0x0003B393 File Offset: 0x00039593
	private bool Method4564(uint 1, uint 2)
	{
		return 1 < 33554432U && 2 >= 1 << 7;
	}

	// Token: 0x060010BB RID: 4283 RVA: 0x0003B3A8 File Offset: 0x000395A8
	private void Method4565(uint 1)
	{
		if (this.flag4)
		{
			this.lzmaBitModelArray[(int)((this._recoveredType14753549.number << 4) + 1)].Encode(this.lzmaRangeEncoder2, 1U);
			this.lzmaBitModelArray2[(int)this._recoveredType14753549.number].Encode(this.lzmaRangeEncoder2, 0U);
			this._recoveredType14753549.SetNumber6486_8317();
			uint num = 2U;
			this._recoveredType08173564.Method4549(this.lzmaRangeEncoder2, num - 2U, 1);
			uint num2 = 602.Method8321(num);
			this._recoveredType2321Array3561[(int)num2].Method12691(this.lzmaRangeEncoder2, 63U);
			int num3 = 30;
			uint num4 = (1U << num3) - 1U;
			this.lzmaRangeEncoder2.EncodeDirectBits(num4 >> 4, num3 - 4);
			this._recoveredType23213563.Method12692(this.lzmaRangeEncoder2, num4 & 15U);
		}
	}

	// Token: 0x060010BC RID: 4284 RVA: 0x0003B47C File Offset: 0x0003967C
	private void Method4566(uint 1)
	{
		this.Method4568();
		this.Method4565(1 & this.number19);
		this.lzmaRangeEncoder2.FlushData();
		this.lzmaRangeEncoder2.FlushStream();
	}

	// Token: 0x060010BD RID: 4285 RVA: 0x0003B4A8 File Offset: 0x000396A8
	public void Method4567(out long 1, out long 2, out bool 3)
	{
		1 = 0L;
		2 = 0L;
		3 = true;
		if (this.stream3 != null)
		{
			this._recoveredType23863553.Method7991(this.stream3);
			this._recoveredType23863553.Method7993();
			this.flag5 = true;
			this.stream3 = null;
			if (this.number27 != 0U)
			{
				this._recoveredType23863553.Method8000(this.number27);
			}
		}
		if (this.flag3)
		{
			return;
		}
		this.flag3 = true;
		long num = this.number25;
		if (this.number25 == 0L)
		{
			if (this._recoveredType23863553.Method7997() == 0U)
			{
				this.Method4566((uint)this.number25);
				return;
			}
			uint num2;
			uint num3;
			this.Method4556(out num2, out num3);
			uint num4 = (uint)((int)this.number25 & (int)this.number19);
			this.lzmaBitModelArray[(int)((this._recoveredType14753549.number << 4) + num4)].Encode(this.lzmaRangeEncoder2, 0U);
			this._recoveredType14753549.Method8316();
			byte 4 = this._recoveredType23863553.Method7995((int)(0U - this.number13));
			this._recoveredType08133566.Method4538((uint)this.number25, this.byteValue4).Method4533(this.lzmaRangeEncoder2, 4);
			this.byteValue4 = 4;
			this.number13 -= 1U;
			this.number25 += 1L;
		}
		if (this._recoveredType23863553.Method7997() == 0U)
		{
			this.Method4566((uint)this.number25);
			return;
		}
		for (;;)
		{
			uint num6;
			uint num5 = this.Method4563((uint)this.number25, out num6);
			uint num7 = (uint)((int)this.number25 & (int)this.number19);
			uint num8 = (this._recoveredType14753549.number << 4) + num7;
			if (num5 == 1U && num6 == 4294967295U)
			{
				this.lzmaBitModelArray[(int)num8].Encode(this.lzmaRangeEncoder2, 0U);
				byte b = this._recoveredType23863553.Method7995((int)(0U - this.number13));
				187.189.190 5 = this._recoveredType08133566.Method4538((uint)this.number25, this.byteValue4);
				if (!this._recoveredType14753549.Method8320())
				{
					byte 6 = this._recoveredType23863553.Method7995((int)(0U - this.numberArray2[0] - 1U - this.number13));
					5.Method4534(this.lzmaRangeEncoder2, 6, b);
				}
				else
				{
					5.Method4533(this.lzmaRangeEncoder2, b);
				}
				this.byteValue4 = b;
				this._recoveredType14753549.Method8316();
			}
			else
			{
				this.lzmaBitModelArray[(int)num8].Encode(this.lzmaRangeEncoder2, 1U);
				if (num6 < 4U)
				{
					this.lzmaBitModelArray2[(int)this._recoveredType14753549.number].Encode(this.lzmaRangeEncoder2, 1U);
					if (num6 == 0U)
					{
						this.lzmaBitModelArray3[(int)this._recoveredType14753549.number].Encode(this.lzmaRangeEncoder2, 0U);
						if (num5 == 1U)
						{
							this.lzmaBitModelArray6[(int)num8].Encode(this.lzmaRangeEncoder2, 0U);
						}
						else
						{
							this.lzmaBitModelArray6[(int)num8].Encode(this.lzmaRangeEncoder2, 1U);
						}
					}
					else
					{
						this.lzmaBitModelArray3[(int)this._recoveredType14753549.number].Encode(this.lzmaRangeEncoder2, 1U);
						if (num6 == 1U)
						{
							this.lzmaBitModelArray4[(int)this._recoveredType14753549.number].Encode(this.lzmaRangeEncoder2, 0U);
						}
						else
						{
							this.lzmaBitModelArray4[(int)this._recoveredType14753549.number].Encode(this.lzmaRangeEncoder2, 1U);
							this.lzmaBitModelArray5[(int)this._recoveredType14753549.number].Encode(this.lzmaRangeEncoder2, num6 - 2U);
						}
					}
					if (num5 == 1U)
					{
						this._recoveredType14753549.SetNumber6486_8319();
					}
					else
					{
						this._recoveredType08173565.Method4549(this.lzmaRangeEncoder2, num5 - 2U, num7);
						this._recoveredType14753549.SetNumber6486_8318();
					}
					uint num9 = this.numberArray2[(int)num6];
					if (num6 != 0U)
					{
						for (uint num10 = num6; num10 >= 1U; num10 -= 1U)
						{
							this.numberArray2[(int)num10] = this.numberArray2[(int)(num10 - 1U)];
						}
						this.numberArray2[0] = num9;
					}
				}
				else
				{
					this.lzmaBitModelArray2[(int)this._recoveredType14753549.number].Encode(this.lzmaRangeEncoder2, 0U);
					this._recoveredType14753549.SetNumber6486_8317();
					this._recoveredType08173564.Method4549(this.lzmaRangeEncoder2, num5 - 2U, num7);
					num6 -= 4U;
					uint num11 = 187.Method4550(num6);
					uint num12 = 602.Method8321(num5);
					this._recoveredType2321Array3561[(int)num12].Method12691(this.lzmaRangeEncoder2, num11);
					if (num11 >= 4U)
					{
						int num13 = (int)((num11 >> 1) - 1U);
						uint num14 = (2U | (num11 & 1U)) << num13;
						uint num15 = num6 - num14;
						if (num11 < 14U)
						{
							774.Method12692(this.lzmaBitModelArray7, num14 - num11 - 1U, this.lzmaRangeEncoder2, num13, num15);
						}
						else
						{
							this.lzmaRangeEncoder2.EncodeDirectBits(num15 >> 4, num13 - 4);
							this._recoveredType23213563.Method12692(this.lzmaRangeEncoder2, num15 & 15U);
							this.number16 += 1U;
						}
					}
					uint num16 = num6;
					for (uint num17 = 3U; num17 >= 1U; num17 -= 1U)
					{
						this.numberArray2[(int)num17] = this.numberArray2[(int)(num17 - 1U)];
					}
					this.numberArray2[0] = num16;
					this.number26 += 1U;
				}
				this.byteValue4 = this._recoveredType23863553.Method7995((int)(num5 - 1U - this.number13));
			}
			this.number13 -= num5;
			this.number25 += (long)((ulong)num5);
			if (this.number13 == 0U)
			{
				if (this.number26 >= 128U)
				{
					this.Method4575();
				}
				if (this.number16 >= 16U)
				{
					this.Method4576();
				}
				1 = this.number25;
				2 = this.lzmaRangeEncoder2.GetProcessedSizeAdd();
				if (this._recoveredType23863553.Method7997() == 0U)
				{
					break;
				}
				if (this.number25 - num >= 4096L)
				{
					goto Block_24;
				}
			}
		}
		this.Method4566((uint)this.number25);
		return;
		Block_24:
		this.flag3 = false;
		3 = false;
	}

	// Token: 0x060010BE RID: 4286 RVA: 0x0003BA9E File Offset: 0x00039C9E
	private void Method4568()
	{
		if (this._recoveredType23863553 != null && this.flag5)
		{
			this._recoveredType23863553.Method7992();
			this.flag5 = false;
		}
	}

	// Token: 0x060010BF RID: 4287 RVA: 0x0003BAC2 File Offset: 0x00039CC2
	private void Method4569(Stream 1)
	{
		this.lzmaRangeEncoder2.SetStream(1);
	}

	// Token: 0x060010C0 RID: 4288 RVA: 0x0003BAD0 File Offset: 0x00039CD0
	private void Method4570()
	{
		this.lzmaRangeEncoder2.ReleaseStream();
	}

	// Token: 0x060010C1 RID: 4289 RVA: 0x0003BADD File Offset: 0x00039CDD
	private void Method4571()
	{
		this.Method4568();
		this.Method4570();
	}

	// Token: 0x060010C2 RID: 4290 RVA: 0x0003BAEC File Offset: 0x00039CEC
	private void Method4572(Stream 1, Stream 2, long 3, long 4)
	{
		this.stream3 = 1;
		this.flag3 = false;
		this.Method4553();
		this.Method4569(2);
		this.Method4555();
		this.Method4575();
		this.Method4576();
		this._recoveredType08173564.SetNumber3546_4545(this.number10 + 1U - 2U);
		this._recoveredType08173564.Method4548(1U << this.number18);
		this._recoveredType08173565.SetNumber3546_4545(this.number10 + 1U - 2U);
		this._recoveredType08173565.Method4548(1U << this.number18);
		this.number25 = 0L;
	}

	// Token: 0x060010C3 RID: 4291 RVA: 0x0003BB84 File Offset: 0x00039D84
	public void Method6888(Stream 1, Stream 2, long 3, long 4, 393 5)
	{
		this.flag5 = false;
		try
		{
			this.Method4572(1, 2, 3, 4);
			for (;;)
			{
				long 6;
				long 7;
				bool flag;
				this.Method4567(out 6, out 7, out flag);
				if (flag)
				{
					break;
				}
				if (5 != null)
				{
					5.Method2428(6, 7);
				}
			}
		}
		finally
		{
			this.Method4571();
		}
	}

	// Token: 0x060010C4 RID: 4292 RVA: 0x0003BBDC File Offset: 0x00039DDC
	public void Method4574(Stream 1)
	{
		this.byteArray2[0] = (byte)((this.number18 * 5 + this.number20) * 9 + this.number21);
		for (int i = 0; i < 4; i++)
		{
			this.byteArray2[1 + i] = (byte)(this.number22 >> 8 * i);
		}
		1.Write(this.byteArray2, 0, 5);
	}

	// Token: 0x060010C5 RID: 4293 RVA: 0x0003BC40 File Offset: 0x00039E40
	private void Method4575()
	{
		for (uint num = 4U; num < 128U; num += 1U)
		{
			uint num2 = 187.Method4550(num);
			int num3 = (int)((num2 >> 1) - 1U);
			uint num4 = (2U | (num2 & 1U)) << num3;
			this.numberArray9[(int)num] = 774.Method12694(this.lzmaBitModelArray7, num4 - num2 - 1U, num3, num - num4);
		}
		for (uint num5 = 0U; num5 < 4U; num5 += 1U)
		{
			774 <<EMPTY_NAME>> = this._recoveredType2321Array3561[(int)num5];
			uint num6 = num5 << 6;
			for (uint num7 = 0U; num7 < this.number17; num7 += 1U)
			{
				this.numberArray4[(int)(num6 + num7)] = <<EMPTY_NAME>>.Method12693(num7);
			}
			for (uint num8 = 14U; num8 < this.number17; num8 += 1U)
			{
				this.numberArray4[(int)(num6 + num8)] += (num8 >> 1) - 1U - 4U << 6;
			}
			uint num9 = num5 * 128U;
			uint num10;
			for (num10 = 0U; num10 < 4U; num10 += 1U)
			{
				this.numberArray5[(int)(num9 + num10)] = this.numberArray4[(int)(num6 + num10)];
			}
			while (num10 < 128U)
			{
				this.numberArray5[(int)(num9 + num10)] = this.numberArray4[(int)(num6 + 187.Method4550(num10))] + this.numberArray9[(int)num10];
				num10 += 1U;
			}
		}
		this.number26 = 0U;
	}

	// Token: 0x060010C6 RID: 4294 RVA: 0x0003BD8C File Offset: 0x00039F8C
	private void Method4576()
	{
		for (uint num = 0U; num < 16U; num += 1U)
		{
			this.numberArray6[(int)num] = this._recoveredType23213563.Method12694(num);
		}
		this.number16 = 0U;
	}

	// Token: 0x060010C7 RID: 4295 RVA: 0x0003BDC4 File Offset: 0x00039FC4
	private static int Method4577(string 1)
	{
		for (int i = 0; i < 187.textArray.Length; i++)
		{
			if (1 == 187.textArray[i])
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x060010C8 RID: 4296 RVA: 0x0003BDF8 File Offset: 0x00039FF8
	public void Method4578(737[] 1, object[] 2)
	{
		uint num = 0U;
		while ((ulong)num < (ulong)((long)2.Length))
		{
			object obj = 2[(int)num];
			737 3 = 1[(int)num];
			if (3 <= (737)1104)
			{
				if (3 != (737)1024)
				{
					switch (3)
					{
					case (737)1088:
					{
						if (!(obj is int))
						{
							throw new 485();
						}
						int num2 = (int)obj;
						if (num2 < 0 || (long)num2 > 4L)
						{
							throw new 485();
						}
						this.number18 = num2;
						this.number19 = (1U << this.number18) - 1U;
						break;
					}
					case (737)1089:
					{
						if (!(obj is int))
						{
							throw new 485();
						}
						int num3 = (int)obj;
						if (num3 < 0 || (long)num3 > 8L)
						{
							throw new 485();
						}
						this.number21 = num3;
						break;
					}
					case (737)1090:
					{
						if (!(obj is int))
						{
							throw new 485();
						}
						int num4 = (int)obj;
						if (num4 < 0 || (long)num4 > 4L)
						{
							throw new 485();
						}
						this.number20 = num4;
						break;
					}
					default:
					{
						if (3 != (737)1104)
						{
							goto IL_240;
						}
						if (!(obj is int))
						{
							throw new 485();
						}
						int num5 = (int)obj;
						if (num5 < 5 || (long)num5 > 273L)
						{
							throw new 485();
						}
						this.number10 = (uint)num5;
						break;
					}
					}
				}
				else
				{
					if (!(obj is int))
					{
						throw new 485();
					}
					int num6 = (int)obj;
					if ((long)num6 < 1L || (long)num6 > 1073741824L)
					{
						throw new 485();
					}
					this.number22 = (uint)num6;
					int num7 = 0;
					while ((long)num7 < 30L && (long)num6 > (long)(1UL << (num7 & 31)))
					{
						num7++;
					}
					this.number17 = (uint)(num7 * 2);
				}
			}
			else if (3 != (737)1105)
			{
				if (3 != (737)1136)
				{
					if (3 != (737)1168)
					{
						goto IL_240;
					}
					if (!(obj is bool))
					{
						throw new 485();
					}
					this.SetFlag3591_4554((bool)obj);
				}
			}
			else
			{
				if (!(obj is string))
				{
					throw new 485();
				}
				187.193 recoveredType = this._recoveredType08183590;
				int num8 = 187.Method4577(((string)obj).ToUpper());
				if (num8 < 0)
				{
					throw new 485();
				}
				this._recoveredType08183590 = (187.193)num8;
				if (this._recoveredType23863553 != null && recoveredType != this._recoveredType08183590)
				{
					this.number23 = uint.MaxValue;
					this._recoveredType23863553 = null;
				}
			}
			num += 1U;
			continue;
			IL_240:
			throw new 485();
		}
	}

	// Token: 0x060010C9 RID: 4297 RVA: 0x0003C05A File Offset: 0x0003A25A
	public void SetNumber3599_4579(uint 1)
	{
		this.number27 = 1;
	}

	// Token: 0x0400082B RID: 2091
	private static byte[] byteArray = new byte[2048];

	// Token: 0x0400082C RID: 2092
	private 602.603 _recoveredType14753549;

	// Token: 0x0400082D RID: 2093
	private byte byteValue4;

	// Token: 0x0400082E RID: 2094
	private uint[] numberArray2 = new uint[4];

	// Token: 0x0400082F RID: 2095
	private 187.188[] lzmaEncoderClosureArray = new 187.188[4096];

	// Token: 0x04000830 RID: 2096
	private 794 _recoveredType23863553;

	// Token: 0x04000831 RID: 2097
	private 194 lzmaRangeEncoder2 = new 194();

	// Token: 0x04000832 RID: 2098
	private 180[] lzmaBitModelArray = new 180[192];

	// Token: 0x04000833 RID: 2099
	private 180[] lzmaBitModelArray2 = new 180[12];

	// Token: 0x04000834 RID: 2100
	private 180[] lzmaBitModelArray3 = new 180[12];

	// Token: 0x04000835 RID: 2101
	private 180[] lzmaBitModelArray4 = new 180[12];

	// Token: 0x04000836 RID: 2102
	private 180[] lzmaBitModelArray5 = new 180[12];

	// Token: 0x04000837 RID: 2103
	private 180[] lzmaBitModelArray6 = new 180[192];

	// Token: 0x04000838 RID: 2104
	private 774[] _recoveredType2321Array3561 = new 774[4];

	// Token: 0x04000839 RID: 2105
	private 180[] lzmaBitModelArray7 = new 180[114];

	// Token: 0x0400083A RID: 2106
	private 774 _recoveredType23213563 = new 774(4);

	// Token: 0x0400083B RID: 2107
	private 187.192 _recoveredType08173564 = new 187.192();

	// Token: 0x0400083C RID: 2108
	private 187.192 _recoveredType08173565 = new 187.192();

	// Token: 0x0400083D RID: 2109
	private 187.189 _recoveredType08133566 = new 187.189();

	// Token: 0x0400083E RID: 2110
	private uint[] numberArray3 = new uint[548];

	// Token: 0x0400083F RID: 2111
	private uint number10 = 32U;

	// Token: 0x04000840 RID: 2112
	private uint number11;

	// Token: 0x04000841 RID: 2113
	private uint number12;

	// Token: 0x04000842 RID: 2114
	private uint number13;

	// Token: 0x04000843 RID: 2115
	private uint number14;

	// Token: 0x04000844 RID: 2116
	private uint number15;

	// Token: 0x04000845 RID: 2117
	private bool flag2;

	// Token: 0x04000846 RID: 2118
	private uint[] numberArray4 = new uint[256];

	// Token: 0x04000847 RID: 2119
	private uint[] numberArray5 = new uint[512];

	// Token: 0x04000848 RID: 2120
	private uint[] numberArray6 = new uint[16];

	// Token: 0x04000849 RID: 2121
	private uint number16;

	// Token: 0x0400084A RID: 2122
	private uint number17 = 44U;

	// Token: 0x0400084B RID: 2123
	private int number18 = 2;

	// Token: 0x0400084C RID: 2124
	private uint number19 = 3U;

	// Token: 0x0400084D RID: 2125
	private int number20;

	// Token: 0x0400084E RID: 2126
	private int number21 = 3;

	// Token: 0x0400084F RID: 2127
	private uint number22 = 4194304U;

	// Token: 0x04000850 RID: 2128
	private uint number23 = uint.MaxValue;

	// Token: 0x04000851 RID: 2129
	private uint number24 = uint.MaxValue;

	// Token: 0x04000852 RID: 2130
	private long number25;

	// Token: 0x04000853 RID: 2131
	private bool flag3;

	// Token: 0x04000854 RID: 2132
	private Stream stream3;

	// Token: 0x04000855 RID: 2133
	private 187.193 _recoveredType08183590 = (187.193)1;

	// Token: 0x04000856 RID: 2134
	private bool flag4;

	// Token: 0x04000857 RID: 2135
	private bool flag5;

	// Token: 0x04000858 RID: 2136
	private uint[] numberArray7 = new uint[4];

	// Token: 0x04000859 RID: 2137
	private uint[] numberArray8 = new uint[4];

	// Token: 0x0400085A RID: 2138
	private byte[] byteArray2 = new byte[5];

	// Token: 0x0400085B RID: 2139
	private uint[] numberArray9 = new uint[128];

	// Token: 0x0400085C RID: 2140
	private uint number26;

	// Token: 0x0400085D RID: 2141
	private static string[] textArray = new string[]
	{
		"BT2",
		"BT4"
	};

	// Token: 0x0400085E RID: 2142
	private uint number27;

	// Token: 0x02000214 RID: 532
	public sealed class 189
	{
		// Token: 0x060010CA RID: 4298 RVA: 0x0003C064 File Offset: 0x0003A264
		public void Method4536(int 1, int 2)
		{
			if (this._recoveredType0814Array3524 == null || this.number3 != 2 || this.number4 != 1)
			{
				this.number4 = 1;
				this.number5 = (1U << 1) - 1U;
				this.number3 = 2;
				uint num = 1U << this.number3 + this.number4;
				this._recoveredType0814Array3524 = new 187.189.190[num];
				for (uint num2 = 0U; num2 < num; num2 += 1U)
				{
					this._recoveredType0814Array3524[(int)num2].SetRecoveredType1495Array3523_4531();
				}
			}
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x0003C0E4 File Offset: 0x0003A2E4
		public void Method4537()
		{
			uint num = 1U << this.number3 + this.number4;
			for (uint num2 = 0U; num2 < num; num2 += 1U)
			{
				this._recoveredType0814Array3524[(int)num2].Method4532();
			}
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x0003C121 File Offset: 0x0003A321
		public 187.189.190 Method4538(uint 1, byte 2)
		{
			return this._recoveredType0814Array3524[(int)(((1 & this.number5) << this.number3) + (uint)(2 >> 8 - this.number3))];
		}

		// Token: 0x0400085F RID: 2143
		private 187.189.190[] _recoveredType0814Array3524;

		// Token: 0x04000860 RID: 2144
		private int number3;

		// Token: 0x04000861 RID: 2145
		private int number4;

		// Token: 0x04000862 RID: 2146
		private uint number5;

		// Token: 0x02000215 RID: 533
		public struct 190
		{
			// Token: 0x060010CE RID: 4302 RVA: 0x0003C14E File Offset: 0x0003A34E
			public void SetRecoveredType1495Array3523_4531()
			{
				this.lzmaBitModelArray = new 180[768];
			}

			// Token: 0x060010CF RID: 4303 RVA: 0x0003C160 File Offset: 0x0003A360
			public void Method4532()
			{
				for (int i = 0; i < 768; i++)
				{
					this.lzmaBitModelArray[i].Init();
				}
			}

			// Token: 0x060010D0 RID: 4304 RVA: 0x0003C190 File Offset: 0x0003A390
			public void Method4533(194 1, byte 2)
			{
				uint num = 1U;
				for (int i = 7; i >= 0; i--)
				{
					uint num2 = (uint)(2 >> i & 1);
					this.lzmaBitModelArray[(int)num].Encode(1, num2);
					num = (num << 1 | num2);
				}
			}

			// Token: 0x060010D1 RID: 4305 RVA: 0x0003C1D0 File Offset: 0x0003A3D0
			public void Method4534(194 1, byte 2, byte 3)
			{
				uint num = 1U;
				bool flag = true;
				for (int i = 7; i >= 0; i--)
				{
					uint num2 = (uint)(3 >> i & 1);
					uint num3 = num;
					if (flag)
					{
						uint num4 = (uint)(2 >> i & 1);
						num3 += 1U + num4 << 8;
						flag = (num4 == num2);
					}
					this.lzmaBitModelArray[(int)num3].Encode(1, num2);
					num = (num << 1 | num2);
				}
			}

			// Token: 0x060010D2 RID: 4306 RVA: 0x0003C234 File Offset: 0x0003A434
			public uint Method4535(bool 1, byte 2, byte 3)
			{
				uint num = 0U;
				uint num2 = 1U;
				int i = 7;
				if (1)
				{
					while (i >= 0)
					{
						uint num3 = (uint)(2 >> i & 1);
						uint num4 = (uint)(3 >> i & 1);
						num += this.lzmaBitModelArray[(int)((1U + num3 << 8) + num2)].GetPrice(num4);
						num2 = (num2 << 1 | num4);
						if (num3 != num4)
						{
							i--;
							break;
						}
						i--;
					}
				}
				while (i >= 0)
				{
					uint num5 = (uint)(3 >> i & 1);
					num += this.lzmaBitModelArray[(int)num2].GetPrice(num5);
					num2 = (num2 << 1 | num5);
					i--;
				}
				return num;
			}

			// Token: 0x04000863 RID: 2147
			private 180[] lzmaBitModelArray;
		}
	}

	// Token: 0x02000216 RID: 534
	public sealed class 188
	{
		// Token: 0x060010D3 RID: 4307 RVA: 0x0003C2C7 File Offset: 0x0003A4C7
		public void Method4539()
		{
			this.number5 = uint.MaxValue;
			this.flag = false;
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x0003C2D7 File Offset: 0x0003A4D7
		public void Method4540()
		{
			this.number5 = 0U;
			this.flag = false;
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x0003C2E7 File Offset: 0x0003A4E7
		public bool Method4541()
		{
			return this.number5 == 0U;
		}

		// Token: 0x04000864 RID: 2148
		public 602.603 _recoveredType14753528;

		// Token: 0x04000865 RID: 2149
		public bool flag;

		// Token: 0x04000866 RID: 2150
		public bool flag2;

		// Token: 0x04000867 RID: 2151
		public uint number;

		// Token: 0x04000868 RID: 2152
		public uint number2;

		// Token: 0x04000869 RID: 2153
		public uint number3;

		// Token: 0x0400086A RID: 2154
		public uint number4;

		// Token: 0x0400086B RID: 2155
		public uint number5;

		// Token: 0x0400086C RID: 2156
		public uint number6;

		// Token: 0x0400086D RID: 2157
		public uint number7;

		// Token: 0x0400086E RID: 2158
		public uint number8;

		// Token: 0x0400086F RID: 2159
		public uint number9;
	}

	// Token: 0x02000217 RID: 535
	public class 191
	{
		// Token: 0x060010D7 RID: 4311 RVA: 0x0003C2F4 File Offset: 0x0003A4F4
		public 191()
		{
			for (uint num = 0U; num < 16U; num += 1U)
			{
				this._recoveredType2321Array3542[(int)num] = new 774(3);
				this._recoveredType2321Array3543[(int)num] = new 774(3);
			}
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x0003C360 File Offset: 0x0003A560
		public void Method4542(uint 1)
		{
			this.lzmaBitModel.Init();
			this.lzmaBitModel2.Init();
			for (uint num = 0U; num < 1; num += 1U)
			{
				this._recoveredType2321Array3542[(int)num].Method12690();
				this._recoveredType2321Array3543[(int)num].Method12690();
			}
			this._recoveredType23213544.Method12690();
		}

		// Token: 0x060010D9 RID: 4313 RVA: 0x0003C3BC File Offset: 0x0003A5BC
		public void Method4543(194 1, uint 2, uint 3)
		{
			if (2 < 8U)
			{
				this.lzmaBitModel.Encode(1, 0U);
				this._recoveredType2321Array3542[(int)3].Method12691(1, 2);
				return;
			}
			2 -= 8U;
			this.lzmaBitModel.Encode(1, 1U);
			if (2 < 8U)
			{
				this.lzmaBitModel2.Encode(1, 0U);
				this._recoveredType2321Array3543[(int)3].Method12691(1, 2);
				return;
			}
			this.lzmaBitModel2.Encode(1, 1U);
			this._recoveredType23213544.Method12691(1, 2 - 8U);
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x0003C444 File Offset: 0x0003A644
		public void Method4544(uint 1, uint 2, uint[] 3, uint 4)
		{
			uint price = this.lzmaBitModel.GetPrice0();
			uint price2 = this.lzmaBitModel.GetPrice1();
			uint num = price2 + this.lzmaBitModel2.GetPrice0();
			uint num2 = price2 + this.lzmaBitModel2.GetPrice1();
			uint num3;
			for (num3 = 0U; num3 < 8U; num3 += 1U)
			{
				if (num3 >= 2)
				{
					return;
				}
				3[(int)(4 + num3)] = price + this._recoveredType2321Array3542[(int)1].Method12693(num3);
			}
			while (num3 < 16U)
			{
				if (num3 >= 2)
				{
					return;
				}
				3[(int)(4 + num3)] = num + this._recoveredType2321Array3543[(int)1].Method12693(num3 - 8U);
				num3 += 1U;
			}
			while (num3 < 2)
			{
				3[(int)(4 + num3)] = num2 + this._recoveredType23213544.Method12693(num3 - 8U - 8U);
				num3 += 1U;
			}
		}

		// Token: 0x04000870 RID: 2160
		private 180 lzmaBitModel;

		// Token: 0x04000871 RID: 2161
		private 180 lzmaBitModel2;

		// Token: 0x04000872 RID: 2162
		private 774[] _recoveredType2321Array3542 = new 774[16];

		// Token: 0x04000873 RID: 2163
		private 774[] _recoveredType2321Array3543 = new 774[16];

		// Token: 0x04000874 RID: 2164
		private 774 _recoveredType23213544 = new 774(8);
	}

	// Token: 0x02000218 RID: 536
	public sealed class 192 : 187.191
	{
		// Token: 0x060010DB RID: 4315 RVA: 0x0003C4FE File Offset: 0x0003A6FE
		public void SetNumber3546_4545(uint 1)
		{
			this.number3 = 1;
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x0003C507 File Offset: 0x0003A707
		public uint Method4546(uint 1, uint 2)
		{
			return this.numberArray[(int)(2 * 272U + 1)];
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x0003C519 File Offset: 0x0003A719
		private void Method4547(uint 1)
		{
			base.Method4544(1, this.number3, this.numberArray, 1 * 272U);
			this.numberArray2[(int)1] = this.number3;
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x0003C544 File Offset: 0x0003A744
		public void Method4548(uint 1)
		{
			for (uint num = 0U; num < 1; num += 1U)
			{
				this.Method4547(num);
			}
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x0003C564 File Offset: 0x0003A764
		public void Method4549(194 1, uint 2, uint 3)
		{
			base.Method4543(1, 2, 3);
			uint[] array = this.numberArray2;
			uint num = array[(int)3] - 1U;
			array[(int)3] = num;
			if (num == 0U)
			{
				this.Method4547(3);
			}
		}

		// Token: 0x04000875 RID: 2165
		private uint[] numberArray = new uint[4352];

		// Token: 0x04000876 RID: 2166
		private uint number3;

		// Token: 0x04000877 RID: 2167
		private uint[] numberArray2 = new uint[16];
	}

	// Token: 0x02000219 RID: 537
	public enum 193
	{

	}
}
