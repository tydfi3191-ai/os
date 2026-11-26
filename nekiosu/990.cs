using System;

// Token: 0x02000351 RID: 849
public sealed class 990
{
	// Token: 0x06001A5A RID: 6746 RVA: 0x000633F5 File Offset: 0x000615F5
	public 990()
	{
		this.was = new long[1];
		this.wrap = true;
	}

	// Token: 0x06001A5B RID: 6747 RVA: 0x00063410 File Offset: 0x00061610
	public 990(bool 1)
	{
		this.was = new long[1];
		this.wrap = true;
		this.wrap = 1;
	}

	// Token: 0x06001A5C RID: 6748 RVA: 0x00063432 File Offset: 0x00061632
	internal int End()
	{
		if (this.blocks != null)
		{
			this.blocks.Method7508();
		}
		this.blocks = null;
		return 0;
	}

	// Token: 0x06001A5D RID: 6749 RVA: 0x00063450 File Offset: 0x00061650
	internal int Inflate(528 1)
	{
		if (this.zStream.byteArray2 == null)
		{
			throw new 522("InputBuffer is null. ");
		}
		int num = (1 == (528)4) ? -5 : 0;
		int num2 = -5;
		int number;
		for (;;)
		{
			switch (this.mode)
			{
			case 0:
			{
				if (this.zStream.number4 == 0)
				{
					return num2;
				}
				num2 = num;
				this.zStream.number4--;
				this.zStream.number8 += 1L;
				byte[] byteArray = this.zStream.byteArray2;
				552 2 = this.zStream;
				number = 2.number6;
				2.number6 = number + 1;
				if (((this.method = byteArray[number]) & 15) != 8)
				{
					this.mode = 13;
					this.zStream.text = string.Format("unknown compression method (0x{0:X2})", this.method);
					this.marker = 5;
					continue;
				}
				if ((this.method >> 4) + 8 > this.wbits)
				{
					this.mode = 13;
					this.zStream.text = string.Format("invalid window size ({0})", (this.method >> 4) + 8);
					this.marker = 5;
					continue;
				}
				this.mode = 1;
				goto IL_71;
			}
			case 1:
				goto IL_71;
			case 2:
				goto IL_121;
			case 3:
				goto IL_19B;
			case 4:
				goto IL_21D;
			case 5:
				goto IL_29E;
			case 6:
				goto IL_657;
			case 7:
				num2 = this.blocks.Method7509(num2);
				if (num2 == -3)
				{
					this.mode = 13;
					this.marker = 0;
					continue;
				}
				if (num2 == 0)
				{
					num2 = num;
				}
				if (num2 != 1)
				{
					return num2;
				}
				num2 = num;
				this.blocks.Method7510(this.was);
				if (!this.GetWrap())
				{
					this.mode = 12;
					continue;
				}
				this.mode = 8;
				goto IL_32A;
			case 8:
				goto IL_32A;
			case 9:
				goto IL_3A5;
			case 10:
				goto IL_428;
			case 11:
				goto IL_4AA;
			case 12:
				return 1;
			case 13:
				goto IL_6DE;
			}
			break;
			IL_71:
			if (this.zStream.number4 == 0)
			{
				return num2;
			}
			num2 = num;
			this.zStream.number4--;
			this.zStream.number8 += 1L;
			byte[] byteArray2 = this.zStream.byteArray2;
			552 3 = this.zStream;
			number = 3.number6;
			3.number6 = number + 1;
			int num3 = byteArray2[number] & 255;
			if (((this.method << 8) + num3) % 31 != 0)
			{
				this.mode = 13;
				this.zStream.text = "incorrect header check";
				this.marker = 5;
				continue;
			}
			if ((num3 & 32) == 0)
			{
				this.mode = 7;
				continue;
			}
			goto IL_11A;
			IL_4AA:
			if (this.zStream.number4 == 0)
			{
				return num2;
			}
			num2 = num;
			this.zStream.number4--;
			this.zStream.number8 += 1L;
			long num4 = this.need;
			byte[] byteArray3 = this.zStream.byteArray2;
			552 4 = this.zStream;
			number = 4.number6;
			4.number6 = number + 1;
			this.need = num4 + (long)(byteArray3[number] & 255UL);
			if ((int)this.was[0] != (int)this.need)
			{
				this.mode = 13;
				this.zStream.text = "incorrect data check";
				this.marker = 5;
				continue;
			}
			goto IL_552;
			IL_428:
			if (this.zStream.number4 == 0)
			{
				return num2;
			}
			num2 = num;
			this.zStream.number4--;
			this.zStream.number8 += 1L;
			long num5 = this.need;
			byte[] byteArray4 = this.zStream.byteArray2;
			552 5 = this.zStream;
			number = 5.number6;
			5.number6 = number + 1;
			this.need = num5 + ((byteArray4[number] & 255L) << 8 & 65280L);
			this.mode = 11;
			goto IL_4AA;
			IL_3A5:
			if (this.zStream.number4 == 0)
			{
				return num2;
			}
			num2 = num;
			this.zStream.number4--;
			this.zStream.number8 += 1L;
			long num6 = this.need;
			byte[] byteArray5 = this.zStream.byteArray2;
			552 6 = this.zStream;
			number = 6.number6;
			6.number6 = number + 1;
			this.need = num6 + ((byteArray5[number] & 255L) << 16 & 16711680L);
			this.mode = 10;
			goto IL_428;
			IL_32A:
			if (this.zStream.number4 == 0)
			{
				return num2;
			}
			num2 = num;
			this.zStream.number4--;
			this.zStream.number8 += 1L;
			byte[] byteArray6 = this.zStream.byteArray2;
			552 7 = this.zStream;
			number = 7.number6;
			7.number6 = number + 1;
			this.need = (long)((byteArray6[number] & 255) << 24 & -16777216);
			this.mode = 9;
			goto IL_3A5;
		}
		throw new 522("Stream error.");
		IL_11A:
		this.mode = 2;
		IL_121:
		if (this.zStream.number4 == 0)
		{
			return num2;
		}
		num2 = num;
		this.zStream.number4--;
		this.zStream.number8 += 1L;
		byte[] byteArray7 = this.zStream.byteArray2;
		552 8 = this.zStream;
		number = 8.number6;
		8.number6 = number + 1;
		this.need = (long)((byteArray7[number] & 255) << 24 & -16777216);
		this.mode = 3;
		IL_19B:
		if (this.zStream.number4 == 0)
		{
			return num2;
		}
		num2 = num;
		this.zStream.number4--;
		this.zStream.number8 += 1L;
		long num7 = this.need;
		byte[] byteArray8 = this.zStream.byteArray2;
		552 9 = this.zStream;
		number = 9.number6;
		9.number6 = number + 1;
		this.need = num7 + ((byteArray8[number] & 255L) << 16 & 16711680L);
		this.mode = 4;
		IL_21D:
		if (this.zStream.number4 == 0)
		{
			return num2;
		}
		num2 = num;
		this.zStream.number4--;
		this.zStream.number8 += 1L;
		long num8 = this.need;
		byte[] byteArray9 = this.zStream.byteArray2;
		552 10 = this.zStream;
		number = 10.number6;
		10.number6 = number + 1;
		this.need = num8 + ((byteArray9[number] & 255L) << 8 & 65280L);
		this.mode = 5;
		IL_29E:
		if (this.zStream.number4 == 0)
		{
			return num2;
		}
		this.zStream.number4--;
		this.zStream.number8 += 1L;
		long num9 = this.need;
		byte[] byteArray10 = this.zStream.byteArray2;
		552 11 = this.zStream;
		number = 11.number6;
		11.number6 = number + 1;
		this.need = num9 + (long)(byteArray10[number] & 255UL);
		this.zStream.number3 = this.need;
		this.mode = 6;
		return 2;
		IL_552:
		this.mode = 12;
		return 1;
		IL_657:
		this.mode = 13;
		this.zStream.text = "need dictionary";
		this.marker = 0;
		return -2;
		IL_6DE:
		throw new 522(string.Format("Bad state ({0})", this.zStream.text));
	}

	// Token: 0x06001A5E RID: 6750 RVA: 0x00063B60 File Offset: 0x00061D60
	internal int Initialize(552 1, int 2)
	{
		this.zStream = 1;
		this.zStream.text = null;
		this.blocks = null;
		if (2 < 8 || 2 > 15)
		{
			this.End();
			throw new 522("Bad window size.");
		}
		this.wbits = 2;
		this.blocks = new 557(1, this.GetWrap() ? this : null, 1 << 2);
		this.Reset();
		return 0;
	}

	// Token: 0x06001A5F RID: 6751 RVA: 0x00063BD0 File Offset: 0x00061DD0
	internal int Reset()
	{
		this.zStream.number8 = (this.zStream.number9 = 0L);
		this.zStream.text = null;
		this.mode = ((!this.GetWrap()) ? 7 : 0);
		this.blocks.Method7510(null);
		return 0;
	}

	// Token: 0x06001A60 RID: 6752 RVA: 0x00063C24 File Offset: 0x00061E24
	internal int SetDictionary(byte[] 1)
	{
		int 2 = 0;
		int num = 1.Length;
		if (this.mode != 6)
		{
			throw new 522("Stream error.");
		}
		if (727.Method11313(1L, 1, 0, 1.Length) != this.zStream.number3)
		{
			return -3;
		}
		this.zStream.number3 = 727.Method11313(0L, null, 0, 0);
		if (num >= 1 << this.wbits)
		{
			num = (1 << this.wbits) - 1;
			2 = 1.Length - num;
		}
		this.blocks.Method7511(1, 2, num);
		this.mode = 7;
		return 0;
	}

	// Token: 0x06001A61 RID: 6753 RVA: 0x00063CB4 File Offset: 0x00061EB4
	internal int Sync()
	{
		if (this.mode != 13)
		{
			this.mode = 13;
			this.marker = 0;
		}
		int num = this.zStream.number4;
		if (num == 0)
		{
			return -5;
		}
		int num2 = this.zStream.number6;
		int num3 = this.marker;
		while (num != 0 && num3 < 4)
		{
			num3 = ((this.zStream.byteArray2[num2] != 990.mark[num3]) ? ((this.zStream.byteArray2[num2] == 0) ? (4 - num3) : 0) : (num3 + 1));
			num2++;
			num--;
		}
		this.zStream.number8 += (long)(num2 - this.zStream.number6);
		this.zStream.number6 = num2;
		this.zStream.number4 = num;
		this.marker = num3;
		if (num3 != 4)
		{
			return -3;
		}
		long number = this.zStream.number8;
		long number2 = this.zStream.number9;
		this.Reset();
		this.zStream.number8 = number;
		this.zStream.number9 = number2;
		this.mode = 7;
		return 0;
	}

	// Token: 0x06001A62 RID: 6754 RVA: 0x00063DC8 File Offset: 0x00061FC8
	internal int SyncPoint(552 1)
	{
		return this.blocks.Method7512();
	}

	// Token: 0x06001A63 RID: 6755 RVA: 0x00063DD5 File Offset: 0x00061FD5
	internal bool GetWrap()
	{
		return this.wrap;
	}

	// Token: 0x06001A64 RID: 6756 RVA: 0x00063DDD File Offset: 0x00061FDD
	internal void SetWrap(bool 1)
	{
		this.wrap = 1;
	}

	// Token: 0x04000C93 RID: 3219
	internal 552 zStream;

	// Token: 0x04000C94 RID: 3220
	private bool wrap;

	// Token: 0x04000C95 RID: 3221
	internal 557 blocks;

	// Token: 0x04000C96 RID: 3222
	private static byte[] mark = new byte[]
	{
		0,
		0,
		byte.MaxValue,
		byte.MaxValue
	};

	// Token: 0x04000C97 RID: 3223
	internal int marker;

	// Token: 0x04000C98 RID: 3224
	internal int method;

	// Token: 0x04000C99 RID: 3225
	internal int mode;

	// Token: 0x04000C9A RID: 3226
	internal long need;

	// Token: 0x04000C9B RID: 3227
	internal long[] was;

	// Token: 0x04000C9C RID: 3228
	internal int wbits;
}
