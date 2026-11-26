using System;

// Token: 0x02000338 RID: 824
public sealed class 407
{
	// Token: 0x06001964 RID: 6500 RVA: 0x0005BD60 File Offset: 0x00059F60
	internal 407()
	{
	}

	// Token: 0x06001965 RID: 6501 RVA: 0x0005BDF4 File Offset: 0x00059FF4
	private void Method2877()
	{
		do
		{
			int num = this.number38 - this.number21 - this.number34;
			if (num == 0 && this.number34 == 0 && this.number21 == 0)
			{
				num = this.number37;
			}
			else if (num == -1)
			{
				num--;
			}
			else if (this.number34 >= this.number37 + this.number37 - 407.number26)
			{
				Array.Copy(this.byteArray3, this.number37, this.byteArray3, 0, this.number37);
				this.number24 -= this.number37;
				this.number34 -= this.number37;
				this.number6 -= this.number37;
				int num2 = this.number11;
				int num3 = num2;
				do
				{
					int num4 = (int)this.int16Array7[--num3] & 65535;
					this.int16Array7[num3] = ((num4 >= this.number37) ? ((short)(num4 - this.number37)) : 0);
				}
				while (--num2 != 0);
				num2 = this.number37;
				num3 = num2;
				do
				{
					int num5 = (int)this.int16Array8[--num3] & 65535;
					this.int16Array8[num3] = ((num5 >= this.number37) ? ((short)(num5 - this.number37)) : 0);
				}
				while (--num2 != 0);
				num += this.number37;
			}
			if (this._recoveredType12492267.number4 == 0)
			{
				break;
			}
			int num6 = this._recoveredType12492267.Method7096(this.byteArray3, this.number34 + this.number21, num);
			this.number21 += num6;
			if (this.number21 >= 3)
			{
				this.number15 = (int)(this.byteArray3[this.number34] & byte.MaxValue);
				this.number15 = ((this.number15 << this.number10 ^ (int)(this.byteArray3[this.number34 + 1] & byte.MaxValue)) & this.number9);
			}
		}
		while (this.number21 < 407.number26 && this._recoveredType12492267.number4 != 0);
	}

	// Token: 0x06001966 RID: 6502 RVA: 0x0005BFF8 File Offset: 0x0005A1F8
	internal void Method2878()
	{
		for (int i = 0; i < 286; i++)
		{
			this.int16Array6[i * 2] = 0;
		}
		for (int j = 0; j < 30; j++)
		{
			this.int16Array5[j * 2] = 0;
		}
		for (int k = 0; k < 19; k++)
		{
			this.int16Array4[k * 2] = 0;
		}
		this.int16Array6[512] = 1;
		this.number28 = (this.number32 = 0);
		this.number19 = (this.number25 = 0);
	}

	// Token: 0x06001967 RID: 6503 RVA: 0x0005C080 File Offset: 0x0005A280
	private void Method2879()
	{
		this.number38 = 2 * this.number37;
		for (int i = 0; i < this.number11; i++)
		{
			this.int16Array7[i] = 0;
		}
		this._recoveredType04982277 = 407.408.Method2876(this._recoveredType20632275);
		switch (this._recoveredType04982277._recoveredType11842261)
		{
		case (534)0:
			this._recoveredType04992281 = new 407.409(this.Method2892);
			break;
		case (534)1:
			this._recoveredType04992281 = new 407.409(this.Method2891);
			break;
		case (534)2:
			this._recoveredType04992281 = new 407.409(this.Method2893);
			break;
		}
		this.number34 = 0;
		this.number6 = 0;
		this.number21 = 0;
		this.number23 = (this.number30 = 2);
		this.number22 = 0;
		this.number15 = 0;
	}

	// Token: 0x06001968 RID: 6504 RVA: 0x0005C154 File Offset: 0x0005A354
	private void Method2880()
	{
		this._recoveredType05222296.int16Array3 = this.int16Array6;
		this._recoveredType05222296._recoveredType20282452 = 721._recoveredType20288814;
		this._recoveredType05222279.int16Array3 = this.int16Array5;
		this._recoveredType05222279._recoveredType20282452 = 721._recoveredType20288812;
		this._recoveredType05222272.int16Array3 = this.int16Array4;
		this._recoveredType05222272._recoveredType20282452 = 721._recoveredType20288811;
		this.intValue = 0;
		this.number5 = 0;
		this.number17 = 8;
		this.Method2878();
	}

	// Token: 0x06001969 RID: 6505 RVA: 0x0005C1E0 File Offset: 0x0005A3E0
	internal static bool Method2881(short[] 1, int 2, int 3, sbyte[] 4)
	{
		short num = 1[2 * 2];
		short num2 = 1[3 * 2];
		return num < num2 || (num == num2 && 4[2] <= 4[3]);
	}

	// Token: 0x0600196A RID: 6506 RVA: 0x0005C210 File Offset: 0x0005A410
	internal void Method2882()
	{
		this.Method2909(2, 3);
		this.Method2910(256, 721.int16Array3);
		this.Method2886();
		if (1 + this.number17 + 10 - this.number5 < 9)
		{
			this.Method2909(2, 3);
			this.Method2910(256, 721.int16Array3);
			this.Method2886();
		}
		this.number17 = 7;
	}

	// Token: 0x0600196B RID: 6507 RVA: 0x0005C278 File Offset: 0x0005A478
	internal void Method2883(int 1, int 2, bool 3)
	{
		int num = 0;
		int num2;
		int num3;
		if (this._recoveredType20632275 > (724)0)
		{
			if (this.sByte == 2)
			{
				this.Method2913();
			}
			this._recoveredType05222296.Method3080(this);
			this._recoveredType05222279.Method3080(this);
			num = this.Method2888();
			num2 = 383.Method2141(this.number28 + 3 + 7, 3);
			num3 = 383.Method2141(this.number32 + 3 + 7, 3);
			if (num3 <= num2)
			{
				num2 = num3;
			}
		}
		else
		{
			num3 = (num2 = 2 + 5);
		}
		if (2 + 4 <= num2 && 1 != -1)
		{
			this.Method2884(1, 2, 3);
		}
		else if (num3 == num2)
		{
			this.Method2909(2 + ((3 > false) ? 1 : 0), 3);
			this.Method2911(721.int16Array3, 721.int16Array2);
		}
		else
		{
			this.Method2909(4 + ((3 > false) ? 1 : 0), 3);
			this.Method2908(this._recoveredType05222296.number4 + 1, this._recoveredType05222279.number4 + 1, num + 1);
			this.Method2911(this.int16Array6, this.int16Array5);
		}
		this.Method2878();
		if (3)
		{
			this.Method2887();
		}
	}

	// Token: 0x0600196C RID: 6508 RVA: 0x0005C377 File Offset: 0x0005A577
	internal void Method2884(int 1, int 2, bool 3)
	{
		this.Method2909((3 > false) ? 1 : 0, 3);
		this.Method2889(1, 2, true);
	}

	// Token: 0x0600196D RID: 6509 RVA: 0x0005C390 File Offset: 0x0005A590
	internal bool Method2885(int 1, int 2)
	{
		this.byteArray2[this.number7 + this.number19 * 2] = (byte)383.Method2141(1, 8);
		this.byteArray2[this.number7 + this.number19 * 2 + 1] = (byte)1;
		this.byteArray2[this.number16 + this.number19] = (byte)2;
		this.number19++;
		if (1 == 0)
		{
			this.int16Array6[2 * 2] = this.int16Array6[2 * 2] + 1;
		}
		else
		{
			this.number25++;
			1--;
			this.int16Array6[((int)412.sByteArray2[2] + 256 + 1) * 2] = this.int16Array6[((int)412.sByteArray2[2] + 256 + 1) * 2] + 1;
			this.int16Array5[412.Method3081(1) * 2] = this.int16Array5[412.Method3081(1) * 2] + 1;
		}
		if ((this.number19 & 8191) == 0 && this._recoveredType20632275 > (724)2)
		{
			int num = this.number19 * 8;
			int num2 = this.number34 - this.number6;
			for (int i = 0; i < 30; i++)
			{
				num += (int)((long)this.int16Array5[i * 2] * (5L + (long)412.numberArray5[i]));
			}
			num = 383.Method2141(num, 3);
			if (this.number25 < this.number19 / 2 && num < num2 / 2)
			{
				return true;
			}
		}
		return this.number19 == this.number20 - 1 || this.number19 == this.number20;
	}

	// Token: 0x0600196E RID: 6510 RVA: 0x0005C514 File Offset: 0x0005A714
	internal void Method2886()
	{
		if (this.number5 == 16)
		{
			this.Method2904((int)this.intValue);
			this.intValue = 0;
			this.number5 = 0;
			return;
		}
		if (this.number5 >= 8)
		{
			this.Method2902((byte)this.intValue);
			this.intValue = (short)383.Method2141((int)this.intValue, 8);
			this.number5 -= 8;
		}
	}

	// Token: 0x0600196F RID: 6511 RVA: 0x0005C57D File Offset: 0x0005A77D
	internal void Method2887()
	{
		if (this.number5 > 8)
		{
			this.Method2904((int)this.intValue);
		}
		else if (this.number5 > 0)
		{
			this.Method2902((byte)this.intValue);
		}
		this.intValue = 0;
		this.number5 = 0;
	}

	// Token: 0x06001970 RID: 6512 RVA: 0x0005C5BC File Offset: 0x0005A7BC
	internal int Method2888()
	{
		this.Method2907(this.int16Array6, this._recoveredType05222296.number4);
		this.Method2907(this.int16Array5, this._recoveredType05222279.number4);
		this._recoveredType05222272.Method3080(this);
		int num = 18;
		while (num >= 3 && this.int16Array4[(int)(412.sByteArray3[num] * 2 + 1)] == 0)
		{
			num--;
		}
		this.number28 += 3 * (num + 1) + 5 + 5 + 4;
		return num;
	}

	// Token: 0x06001971 RID: 6513 RVA: 0x0005C63D File Offset: 0x0005A83D
	internal void Method2889(int 1, int 2, bool 3)
	{
		this.Method2887();
		this.number17 = 8;
		if (3)
		{
			this.Method2904((int)((short)2));
			this.Method2904((int)((short)(~(short)2)));
		}
		this.Method2902(this.byteArray3, 1, 2);
	}

	// Token: 0x06001972 RID: 6514 RVA: 0x0005C670 File Offset: 0x0005A870
	internal int Method2890(528 1)
	{
		if (this._recoveredType12492267.byteArray3 == null || (this._recoveredType12492267.byteArray2 == null && this._recoveredType12492267.number4 != 0) || (this.number33 == 666 && 1 != (528)4))
		{
			this._recoveredType12492267.text = 407.textArray[4];
			throw new 522(string.Format("Something is fishy. [{0}]", this._recoveredType12492267.text));
		}
		if (this._recoveredType12492267.number5 == 0)
		{
			this._recoveredType12492267.text = 407.textArray[7];
			throw new 522("OutputBuffer is full (AvailableBytesOut == 0)");
		}
		int num = this.number18;
		this.number18 = (int)1;
		if (this.number33 == 42)
		{
			int num2 = 8 + (this.number35 - 8 << 4) << 8;
			int num3 = (this._recoveredType20632275 - (724)1 & 255) >> 1;
			if (num3 > 3)
			{
				num3 = 3;
			}
			num2 |= num3 << 6;
			if (this.number34 != 0)
			{
				num2 |= 32;
			}
			num2 += 31 - num2 % 31;
			this.number33 = 113;
			this.Method2905(num2);
			if (this.number34 != 0)
			{
				this.Method2905((int)383.Method2141(this._recoveredType12492267.number3, 16));
				this.Method2905((int)(this._recoveredType12492267.number3 & 65535L));
			}
			this._recoveredType12492267.number3 = 727.Method11313(0L, null, 0, 0);
		}
		if (this.number29 != 0)
		{
			this._recoveredType12492267.Method7085();
			if (this._recoveredType12492267.number5 == 0)
			{
				this.number18 = -1;
				return 0;
			}
		}
		else if (this._recoveredType12492267.number4 == 0 && 1 <= (528)num && 1 != (528)4)
		{
			return 0;
		}
		if (this.number33 == 666 && this._recoveredType12492267.number4 != 0)
		{
			this._recoveredType12492267.text = 407.textArray[7];
			throw new 522("status == FINISH_STATE && _codec.AvailableBytesIn != 0");
		}
		if (this._recoveredType12492267.number4 != 0 || this.number21 != 0 || (1 != (528)0 && this.number33 != 666))
		{
			405 2 = this._recoveredType04992281(1);
			if (2 - (405)2 <= 1)
			{
				this.number33 = 666;
			}
			switch (2)
			{
			case (405)0:
			case (405)2:
				if (this._recoveredType12492267.number5 == 0)
				{
					this.number18 = -1;
				}
				return 0;
			case (405)1:
				if (1 == (528)1)
				{
					this.Method2882();
				}
				else
				{
					this.Method2884(0, 0, false);
					if (1 == (528)3)
					{
						for (int i = 0; i < this.number11; i++)
						{
							this.int16Array7[i] = 0;
						}
					}
				}
				this._recoveredType12492267.Method7085();
				if (this._recoveredType12492267.number5 == 0)
				{
					this.number18 = -1;
					return 0;
				}
				break;
			}
		}
		if (1 != (528)4)
		{
			return 0;
		}
		if (!this.GetFlag2268_2916() || this.flag3)
		{
			return 1;
		}
		this.Method2905((int)383.Method2141(this._recoveredType12492267.number3, 16));
		this.Method2905((int)(this._recoveredType12492267.number3 & 65535L));
		this._recoveredType12492267.Method7085();
		this.flag3 = true;
		if (this.number29 == 0)
		{
			return 1;
		}
		return 0;
	}

	// Token: 0x06001973 RID: 6515 RVA: 0x0005C974 File Offset: 0x0005AB74
	internal 405 Method2891(528 1)
	{
		int num = 0;
		for (;;)
		{
			if (this.number21 < 407.number26)
			{
				this.Method2877();
				if (this.number21 < 407.number26 && 1 == (528)0)
				{
					break;
				}
				if (this.number21 == 0)
				{
					goto Block_4;
				}
			}
			if (this.number21 >= 3)
			{
				this.number15 = ((this.number15 << this.number10 ^ (int)(this.byteArray3[this.number34 + 2] & byte.MaxValue)) & this.number9);
				num = ((int)this.int16Array7[this.number15] & 65535);
				this.int16Array8[this.number34 & this.number36] = this.int16Array7[this.number15];
				this.int16Array7[this.number15] = (short)this.number34;
			}
			if ((long)num != 0L && (this.number34 - num & 65535) <= this.number37 - 407.number26 && this._recoveredType05482276 != (417)2)
			{
				this.number23 = this.Method2900(num);
			}
			bool flag;
			if (this.number23 >= 3)
			{
				flag = this.Method2885(this.number34 - this.number24, this.number23 - 3);
				this.number21 -= this.number23;
				if (this.number23 <= this._recoveredType04982277.number7 && this.number21 >= 3)
				{
					this.number23--;
					int num2;
					do
					{
						this.number34++;
						this.number15 = ((this.number15 << this.number10 ^ (int)(this.byteArray3[this.number34 + 2] & byte.MaxValue)) & this.number9);
						num = ((int)this.int16Array7[this.number15] & 65535);
						this.int16Array8[this.number34 & this.number36] = this.int16Array7[this.number15];
						this.int16Array7[this.number15] = (short)this.number34;
						num2 = this.number23 - 1;
						this.number23 = num2;
					}
					while (num2 != 0);
					this.number34++;
				}
				else
				{
					this.number34 += this.number23;
					this.number23 = 0;
					this.number15 = (int)(this.byteArray3[this.number34] & byte.MaxValue);
					this.number15 = ((this.number15 << this.number10 ^ (int)(this.byteArray3[this.number34 + 1] & byte.MaxValue)) & this.number9);
				}
			}
			else
			{
				flag = this.Method2885(0, (int)(this.byteArray3[this.number34] & byte.MaxValue));
				this.number21--;
				this.number34++;
			}
			if (flag)
			{
				this.Method2895(false);
				if (this._recoveredType12492267.number5 == 0)
				{
					return (405)0;
				}
			}
		}
		return (405)0;
		Block_4:
		this.Method2895(1 == (528)4);
		if (this._recoveredType12492267.number5 == 0)
		{
			if (1 == (528)4)
			{
				return (405)2;
			}
			return (405)0;
		}
		else
		{
			if (1 != (528)4)
			{
				return (405)1;
			}
			return (405)3;
		}
		return (405)0;
	}

	// Token: 0x06001974 RID: 6516 RVA: 0x0005CC70 File Offset: 0x0005AE70
	internal 405 Method2892(528 1)
	{
		int num = 65535;
		if (num > this.byteArray2.Length - 5)
		{
			num = this.byteArray2.Length - 5;
		}
		for (;;)
		{
			if (this.number21 <= 1)
			{
				this.Method2877();
				if (this.number21 == 0 && 1 == (528)0)
				{
					break;
				}
				if (this.number21 == 0)
				{
					goto Block_5;
				}
			}
			this.number34 += this.number21;
			this.number21 = 0;
			int num2 = this.number6 + num;
			if (this.number34 == 0 || this.number34 >= num2)
			{
				this.number21 = this.number34 - num2;
				this.number34 = num2;
				this.Method2895(false);
				if (this._recoveredType12492267.number5 == 0)
				{
					return (405)0;
				}
			}
			if (this.number34 - this.number6 >= this.number37 - 407.number26)
			{
				this.Method2895(false);
				if (this._recoveredType12492267.number5 == 0)
				{
					return (405)0;
				}
			}
		}
		return (405)0;
		Block_5:
		this.Method2895(1 == (528)4);
		if (this._recoveredType12492267.number5 == 0)
		{
			if (1 != (528)4)
			{
				return (405)0;
			}
			return (405)2;
		}
		else
		{
			if (1 != (528)4)
			{
				return (405)1;
			}
			return (405)3;
		}
		return (405)0;
	}

	// Token: 0x06001975 RID: 6517 RVA: 0x0005CD7C File Offset: 0x0005AF7C
	internal 405 Method2893(528 1)
	{
		int num = 0;
		for (;;)
		{
			if (this.number21 < 407.number26)
			{
				this.Method2877();
				if (this.number21 < 407.number26 && 1 == (528)0)
				{
					break;
				}
				if (this.number21 == 0)
				{
					goto Block_4;
				}
			}
			if (this.number21 >= 3)
			{
				this.number15 = ((this.number15 << this.number10 ^ (int)(this.byteArray3[this.number34 + 2] & byte.MaxValue)) & this.number9);
				num = ((int)this.int16Array7[this.number15] & 65535);
				this.int16Array8[this.number34 & this.number36] = this.int16Array7[this.number15];
				this.int16Array7[this.number15] = (short)this.number34;
			}
			this.number30 = this.number23;
			this.number31 = this.number24;
			this.number23 = 2;
			if (num != 0 && this.number30 < this._recoveredType04982277.number7 && (this.number34 - num & 65535) <= this.number37 - 407.number26)
			{
				if (this._recoveredType05482276 != (417)2)
				{
					this.number23 = this.Method2900(num);
				}
				if (this.number23 <= 5 && (this._recoveredType05482276 == (417)1 || (this.number23 == 3 && this.number34 - this.number24 > 4096)))
				{
					this.number23 = 2;
				}
			}
			if (this.number30 >= 3 && this.number23 <= this.number30)
			{
				int num2 = this.number34 + this.number21 - 3;
				bool flag = this.Method2885(this.number34 - 1 - this.number31, this.number30 - 3);
				this.number21 -= this.number30 - 1;
				this.number30 -= 2;
				int num3;
				do
				{
					num3 = this.number34 + 1;
					this.number34 = num3;
					if (num3 <= num2)
					{
						this.number15 = ((this.number15 << this.number10 ^ (int)(this.byteArray3[this.number34 + 2] & byte.MaxValue)) & this.number9);
						num = ((int)this.int16Array7[this.number15] & 65535);
						this.int16Array8[this.number34 & this.number36] = this.int16Array7[this.number15];
						this.int16Array7[this.number15] = (short)this.number34;
					}
					num3 = this.number30 - 1;
					this.number30 = num3;
				}
				while (num3 != 0);
				this.number22 = 0;
				this.number23 = 2;
				this.number34++;
				if (flag)
				{
					this.Method2895(false);
					if (this._recoveredType12492267.number5 == 0)
					{
						return (405)0;
					}
				}
			}
			else if (this.number22 != 0)
			{
				if (this.Method2885(0, (int)(this.byteArray3[this.number34 - 1] & 255)))
				{
					this.Method2895(false);
				}
				this.number34++;
				this.number21--;
				if (this._recoveredType12492267.number5 == 0)
				{
					return (405)0;
				}
			}
			else
			{
				this.number22 = 1;
				this.number34++;
				this.number21--;
			}
		}
		return (405)0;
		Block_4:
		if (this.number22 != 0)
		{
			this.Method2885(0, (int)(this.byteArray3[this.number34 - 1] & byte.MaxValue));
			this.number22 = 0;
		}
		this.Method2895(1 == (528)4);
		if (this._recoveredType12492267.number5 == 0)
		{
			if (1 == (528)4)
			{
				return (405)2;
			}
			return (405)0;
		}
		else
		{
			if (1 != (528)4)
			{
				return (405)1;
			}
			return (405)3;
		}
		return (405)0;
	}

	// Token: 0x06001976 RID: 6518 RVA: 0x0005D100 File Offset: 0x0005B300
	internal int Method2894()
	{
		if (this.number33 != 42 && this.number33 != 113 && this.number33 != 666)
		{
			return -2;
		}
		this.byteArray2 = null;
		this.int16Array7 = null;
		this.int16Array8 = null;
		this.byteArray3 = null;
		if (this.number33 != 113)
		{
			return 0;
		}
		return -3;
	}

	// Token: 0x06001977 RID: 6519 RVA: 0x0005D15B File Offset: 0x0005B35B
	internal void Method2895(bool 1)
	{
		this.Method2883((this.number6 >= 0) ? this.number6 : -1, this.number34 - this.number6, 1);
		this.number6 = this.number34;
		this._recoveredType12492267.Method7085();
	}

	// Token: 0x06001978 RID: 6520 RVA: 0x0005D19A File Offset: 0x0005B39A
	internal int Method2896(552 1, 724 2)
	{
		return this.Method2896(1, 2, 15);
	}

	// Token: 0x06001979 RID: 6521 RVA: 0x0005D1A6 File Offset: 0x0005B3A6
	internal int Method2896(552 1, 724 2, int 3)
	{
		return this.Method2896(1, 2, 3, 8, (417)0);
	}

	// Token: 0x0600197A RID: 6522 RVA: 0x0005D1B3 File Offset: 0x0005B3B3
	internal int Method2896(552 1, 724 2, int 3, 417 4)
	{
		return this.Method2896(1, 2, 3, 8, 4);
	}

	// Token: 0x0600197B RID: 6523 RVA: 0x0005D1C4 File Offset: 0x0005B3C4
	internal int Method2896(552 1, 724 2, int 3, int 4, 417 5)
	{
		this._recoveredType12492267 = 1;
		this._recoveredType12492267.text = null;
		if (3 < 9 || 3 > 15)
		{
			throw new 522("windowBits must be in the range 9..15.");
		}
		if (4 < 1 || 4 > 9)
		{
			throw new 522(string.Format("memLevel must be in the range 1.. {0}", 9));
		}
		this._recoveredType12492267._recoveredType04975611 = this;
		this.number35 = 3;
		this.number37 = 1 << this.number35;
		this.number36 = this.number37 - 1;
		this.number8 = 4 + 7;
		this.number11 = 1 << this.number8;
		this.number9 = this.number11 - 1;
		this.number10 = (this.number8 + 3 - 1) / 3;
		this.byteArray3 = new byte[this.number37 * 2];
		this.int16Array8 = new short[this.number37];
		this.int16Array7 = new short[this.number11];
		this.number20 = 1 << 4 + 6;
		this.byteArray2 = new byte[this.number20 * 4];
		this.number7 = this.number20 / 2;
		this.number16 = 3 * this.number20;
		this._recoveredType20632275 = 2;
		this._recoveredType05482276 = 5;
		this.sByte2 = 8;
		this.Method2906();
		return 0;
	}

	// Token: 0x0600197C RID: 6524 RVA: 0x0005D318 File Offset: 0x0005B518
	internal int Method2900(int 1)
	{
		int num = this._recoveredType04982277.number6;
		int num2 = this.number34;
		int num3 = this.number30;
		int num4 = (this.number34 > this.number37 - 407.number26) ? (this.number34 - (this.number37 - 407.number26)) : 0;
		int num5 = this._recoveredType04982277.number8;
		int num6 = this.number36;
		int num7 = this.number34 + 258;
		byte b = this.byteArray3[num2 + num3 - 1];
		byte b2 = this.byteArray3[num2 + num3];
		if (this.number30 >= this._recoveredType04982277.number5)
		{
			num >>= 2;
		}
		if (num5 > this.number21)
		{
			num5 = this.number21;
		}
		do
		{
			int num8 = 1;
			if (this.byteArray3[num8 + num3] == b2 && this.byteArray3[num8 + num3 - 1] == b && this.byteArray3[num8] == this.byteArray3[num2] && this.byteArray3[++num8] == this.byteArray3[num2 + 1])
			{
				num2 += 2;
				num8++;
				while (this.byteArray3[++num2] == this.byteArray3[++num8] && this.byteArray3[++num2] == this.byteArray3[++num8] && this.byteArray3[++num2] == this.byteArray3[++num8] && this.byteArray3[++num2] == this.byteArray3[++num8] && this.byteArray3[++num2] == this.byteArray3[++num8] && this.byteArray3[++num2] == this.byteArray3[++num8] && this.byteArray3[++num2] == this.byteArray3[++num8] && this.byteArray3[++num2] == this.byteArray3[++num8] && num2 < num7)
				{
				}
				int num9 = 258 - (num7 - num2);
				num2 = num7 - 258;
				if (num9 > num3)
				{
					this.number24 = 1;
					num3 = num9;
					if (num9 >= num5)
					{
						break;
					}
					b = this.byteArray3[num2 + num3 - 1];
					b2 = this.byteArray3[num2 + num3];
				}
			}
		}
		while ((1 = ((int)this.int16Array8[1 & num6] & 65535)) > num4 && --num != 0);
		if (num3 <= this.number21)
		{
			return num3;
		}
		return this.number21;
	}

	// Token: 0x0600197D RID: 6525 RVA: 0x0005D5A0 File Offset: 0x0005B7A0
	internal void Method2901(short[] 1, int 2)
	{
		int num = this.numberArray[2];
		for (int i = 2 << 1; i <= this.number12; i <<= 1)
		{
			if (i < this.number12 && 407.Method2881(1, this.numberArray[i + 1], this.numberArray[i], this.sByteArray2))
			{
				i++;
			}
			if (407.Method2881(1, num, this.numberArray[i], this.sByteArray2))
			{
				break;
			}
			this.numberArray[2] = this.numberArray[i];
			2 = i;
		}
		this.numberArray[2] = num;
	}

	// Token: 0x0600197E RID: 6526 RVA: 0x0005D62C File Offset: 0x0005B82C
	private void Method2902(byte 1)
	{
		byte[] array = this.byteArray2;
		int num = this.number29;
		this.number29 = num + 1;
		array[num] = 1;
	}

	// Token: 0x0600197F RID: 6527 RVA: 0x0005D652 File Offset: 0x0005B852
	private void Method2902(byte[] 1, int 2, int 3)
	{
		Array.Copy(1, 2, this.byteArray2, this.number29, 3);
		this.number29 += 3;
	}

	// Token: 0x06001980 RID: 6528 RVA: 0x0005D676 File Offset: 0x0005B876
	internal void Method2904(int 1)
	{
		this.Method2902((byte)1);
		this.Method2902((byte)383.Method2141(1, 8));
	}

	// Token: 0x06001981 RID: 6529 RVA: 0x0005D68E File Offset: 0x0005B88E
	internal void Method2905(int 1)
	{
		this.Method2902((byte)(1 >> 8));
		this.Method2902((byte)1);
	}

	// Token: 0x06001982 RID: 6530 RVA: 0x0005D6A4 File Offset: 0x0005B8A4
	internal void Method2906()
	{
		this._recoveredType12492267.number8 = (this._recoveredType12492267.number9 = 0L);
		this._recoveredType12492267.text = null;
		this.number29 = 0;
		this.number27 = 0;
		this.flag3 = false;
		this.number33 = (this.GetFlag2268_2916() ? 42 : 113);
		this._recoveredType12492267.number3 = 727.Method11313(0L, null, 0, 0);
		this.number18 = 0;
		this.Method2880();
		this.Method2879();
	}

	// Token: 0x06001983 RID: 6531 RVA: 0x0005D72C File Offset: 0x0005B92C
	internal void Method2907(short[] 1, int 2)
	{
		int num = -1;
		int num2 = (int)1[1];
		int num3 = 0;
		int num4 = 7;
		int num5 = 4;
		if (num2 == 0)
		{
			num4 = 138;
			num5 = 3;
		}
		1[(2 + 1) * 2 + 1] = short.MaxValue;
		for (int i = 0; i <= 2; i++)
		{
			int num6 = num2;
			num2 = (int)1[(i + 1) * 2 + 1];
			if (++num3 >= num4 || num6 != num2)
			{
				if (num3 < num5)
				{
					this.int16Array4[num6 * 2] = (short)((int)this.int16Array4[num6 * 2] + num3);
				}
				else if (num6 != 0)
				{
					if (num6 != num)
					{
						this.int16Array4[num6 * 2] = this.int16Array4[num6 * 2] + 1;
					}
					this.int16Array4[32] = this.int16Array4[32] + 1;
				}
				else if (num3 <= 10)
				{
					this.int16Array4[34] = this.int16Array4[34] + 1;
				}
				else
				{
					this.int16Array4[36] = this.int16Array4[36] + 1;
				}
				num3 = 0;
				num = num6;
				if (num2 == 0)
				{
					num4 = 138;
					num5 = 3;
				}
				else if (num6 == num2)
				{
					num4 = 6;
					num5 = 3;
				}
				else
				{
					num4 = 7;
					num5 = 4;
				}
			}
		}
	}

	// Token: 0x06001984 RID: 6532 RVA: 0x0005D844 File Offset: 0x0005BA44
	internal void Method2908(int 1, int 2, int 3)
	{
		this.Method2909(1 - 257, 5);
		this.Method2909(2 - 1, 5);
		this.Method2909(3 - 4, 4);
		for (int i = 0; i < 3; i++)
		{
			this.Method2909((int)this.int16Array4[(int)(412.sByteArray3[i] * 2 + 1)], 3);
		}
		this.Method2912(this.int16Array6, 1 - 1);
		this.Method2912(this.int16Array5, 2 - 1);
	}

	// Token: 0x06001985 RID: 6533 RVA: 0x0005D8B8 File Offset: 0x0005BAB8
	internal void Method2909(int 1, int 2)
	{
		if (this.number5 > 16 - 2)
		{
			this.intValue |= (short)(1 << this.number5);
			this.Method2904((int)this.intValue);
			this.intValue = (short)383.Method2141(1, 16 - this.number5);
			this.number5 += 2 - 16;
			return;
		}
		this.intValue |= (short)(1 << this.number5);
		this.number5 += 2;
	}

	// Token: 0x06001986 RID: 6534 RVA: 0x0005D948 File Offset: 0x0005BB48
	internal void Method2910(int 1, short[] 2)
	{
		int num = 1 * 2;
		this.Method2909((int)2[num] & 65535, (int)2[num + 1] & 65535);
	}

	// Token: 0x06001987 RID: 6535 RVA: 0x0005D974 File Offset: 0x0005BB74
	internal void Method2911(short[] 1, short[] 2)
	{
		int num = 0;
		if (this.number19 != 0)
		{
			do
			{
				int num2 = ((int)this.byteArray2[this.number7 + num * 2] << 8 & 65280) | (int)(this.byteArray2[this.number7 + num * 2 + 1] & byte.MaxValue);
				int num3 = (int)(this.byteArray2[this.number16 + num] & byte.MaxValue);
				num++;
				if (num2 == 0)
				{
					this.Method2910(num3, 1);
				}
				else
				{
					int num4 = (int)412.sByteArray2[num3];
					this.Method2910(num4 + 256 + 1, 1);
					int num5 = 412.numberArray6[num4];
					if (num5 != 0)
					{
						num3 -= 412.numberArray3[num4];
						this.Method2909(num3, num5);
					}
					num2--;
					num4 = 412.Method3081(num2);
					this.Method2910(num4, 2);
					num5 = 412.numberArray5[num4];
					if (num5 != 0)
					{
						num2 -= 412.numberArray2[num4];
						this.Method2909(num2, num5);
					}
				}
			}
			while (num < this.number19);
		}
		this.Method2910(256, 1);
		this.number17 = (int)1[513];
	}

	// Token: 0x06001988 RID: 6536 RVA: 0x0005DA7C File Offset: 0x0005BC7C
	internal void Method2912(short[] 1, int 2)
	{
		int num = -1;
		int num2 = (int)1[1];
		int num3 = 0;
		int num4 = 7;
		int num5 = 4;
		if (num2 == 0)
		{
			num4 = 138;
			num5 = 3;
		}
		for (int i = 0; i <= 2; i++)
		{
			int num6 = num2;
			num2 = (int)1[(i + 1) * 2 + 1];
			if (++num3 >= num4 || num6 != num2)
			{
				if (num3 < num5)
				{
					do
					{
						this.Method2910(num6, this.int16Array4);
					}
					while (--num3 != 0);
				}
				else if (num6 != 0)
				{
					if (num6 != num)
					{
						this.Method2910(num6, this.int16Array4);
						num3--;
					}
					this.Method2910(16, this.int16Array4);
					this.Method2909(num3 - 3, 2);
				}
				else if (num3 <= 10)
				{
					this.Method2910(17, this.int16Array4);
					this.Method2909(num3 - 3, 3);
				}
				else
				{
					this.Method2910(18, this.int16Array4);
					this.Method2909(num3 - 11, 7);
				}
				num3 = 0;
				num = num6;
				if (num2 == 0)
				{
					num4 = 138;
					num5 = 3;
				}
				else if (num6 == num2)
				{
					num4 = 6;
					num5 = 3;
				}
				else
				{
					num4 = 7;
					num5 = 4;
				}
			}
		}
	}

	// Token: 0x06001989 RID: 6537 RVA: 0x0005DB84 File Offset: 0x0005BD84
	internal void Method2913()
	{
		int i = 0;
		int num = 0;
		int num2 = 0;
		while (i < 7)
		{
			num2 += (int)this.int16Array6[i * 2];
			i++;
		}
		while (i < 128)
		{
			num += (int)this.int16Array6[i * 2];
			i++;
		}
		while (i < 256)
		{
			num2 += (int)this.int16Array6[i * 2];
			i++;
		}
		this.sByte = ((num2 <= 383.Method2141(num, 2)) ? 1 : 0);
	}

	// Token: 0x0600198A RID: 6538 RVA: 0x0005DBF8 File Offset: 0x0005BDF8
	internal int Method2914(byte[] 1)
	{
		int num = 1.Length;
		int sourceIndex = 0;
		if (1 == null || this.number33 != 42)
		{
			throw new 522("Stream error.");
		}
		this._recoveredType12492267.number3 = 727.Method11313(this._recoveredType12492267.number3, 1, 0, 1.Length);
		if (num >= 3)
		{
			if (num > this.number37 - 407.number26)
			{
				num = this.number37 - 407.number26;
				sourceIndex = 1.Length - num;
			}
			Array.Copy(1, sourceIndex, this.byteArray3, 0, num);
			this.number34 = num;
			this.number6 = num;
			this.number15 = (int)(this.byteArray3[0] & byte.MaxValue);
			this.number15 = ((this.number15 << this.number10 ^ (int)(this.byteArray3[1] & byte.MaxValue)) & this.number9);
			for (int i = 0; i <= num - 3; i++)
			{
				this.number15 = ((this.number15 << this.number10 ^ (int)(this.byteArray3[i + 2] & byte.MaxValue)) & this.number9);
				this.int16Array8[i & this.number36] = this.int16Array7[this.number15];
				this.int16Array7[this.number15] = (short)i;
			}
		}
		return 0;
	}

	// Token: 0x0600198B RID: 6539 RVA: 0x0005DD34 File Offset: 0x0005BF34
	internal int Method2915(724 1, 417 2)
	{
		int result = 0;
		if (this._recoveredType20632275 != 1)
		{
			407.408 3 = 407.408.Method2876(1);
			if (3._recoveredType11842261 != this._recoveredType04982277._recoveredType11842261 && this._recoveredType12492267.number8 != 0L)
			{
				result = this._recoveredType12492267.Method7082((528)1);
			}
			this._recoveredType20632275 = 1;
			this._recoveredType04982277 = 3;
			switch (this._recoveredType04982277._recoveredType11842261)
			{
			case (534)0:
				this._recoveredType04992281 = new 407.409(this.Method2892);
				break;
			case (534)1:
				this._recoveredType04992281 = new 407.409(this.Method2891);
				break;
			case (534)2:
				this._recoveredType04992281 = new 407.409(this.Method2893);
				break;
			}
		}
		this._recoveredType05482276 = 2;
		return result;
	}

	// Token: 0x0600198C RID: 6540 RVA: 0x0005DDF3 File Offset: 0x0005BFF3
	internal bool GetFlag2268_2916()
	{
		return this.flag2;
	}

	// Token: 0x0600198D RID: 6541 RVA: 0x0005DDFB File Offset: 0x0005BFFB
	internal void SetFlag2268_2917(bool 1)
	{
		this.flag2 = 1;
	}

	// Token: 0x04000BC6 RID: 3014
	internal 552 _recoveredType12492267;

	// Token: 0x04000BC7 RID: 3015
	private bool flag2 = true;

	// Token: 0x04000BC8 RID: 3016
	internal short intValue;

	// Token: 0x04000BC9 RID: 3017
	internal int number5;

	// Token: 0x04000BCA RID: 3018
	internal short[] int16Array3 = new short[16];

	// Token: 0x04000BCB RID: 3019
	internal 412 _recoveredType05222272 = new 412();

	// Token: 0x04000BCC RID: 3020
	internal short[] int16Array4 = new short[78];

	// Token: 0x04000BCD RID: 3021
	internal int number6;

	// Token: 0x04000BCE RID: 3022
	internal 724 _recoveredType20632275;

	// Token: 0x04000BCF RID: 3023
	internal 417 _recoveredType05482276;

	// Token: 0x04000BD0 RID: 3024
	private 407.408 _recoveredType04982277;

	// Token: 0x04000BD1 RID: 3025
	internal int number7;

	// Token: 0x04000BD2 RID: 3026
	internal 412 _recoveredType05222279 = new 412();

	// Token: 0x04000BD3 RID: 3027
	internal sbyte sByte;

	// Token: 0x04000BD4 RID: 3028
	private 407.409 _recoveredType04992281;

	// Token: 0x04000BD5 RID: 3029
	internal sbyte[] sByteArray2 = new sbyte[573];

	// Token: 0x04000BD6 RID: 3030
	internal short[] int16Array5 = new short[122];

	// Token: 0x04000BD7 RID: 3031
	internal short[] int16Array6 = new short[407.number14 * 2];

	// Token: 0x04000BD8 RID: 3032
	internal int number8;

	// Token: 0x04000BD9 RID: 3033
	internal int number9;

	// Token: 0x04000BDA RID: 3034
	internal int number10;

	// Token: 0x04000BDB RID: 3035
	internal int number11;

	// Token: 0x04000BDC RID: 3036
	internal short[] int16Array7;

	// Token: 0x04000BDD RID: 3037
	internal int[] numberArray = new int[573];

	// Token: 0x04000BDE RID: 3038
	internal int number12;

	// Token: 0x04000BDF RID: 3039
	internal int number13;

	// Token: 0x04000BE0 RID: 3040
	private static readonly int number14 = 573;

	// Token: 0x04000BE1 RID: 3041
	internal int number15;

	// Token: 0x04000BE2 RID: 3042
	internal int number16;

	// Token: 0x04000BE3 RID: 3043
	internal 412 _recoveredType05222296 = new 412();

	// Token: 0x04000BE4 RID: 3044
	internal int number17;

	// Token: 0x04000BE5 RID: 3045
	internal int number18;

	// Token: 0x04000BE6 RID: 3046
	internal int number19;

	// Token: 0x04000BE7 RID: 3047
	internal int number20;

	// Token: 0x04000BE8 RID: 3048
	internal int number21;

	// Token: 0x04000BE9 RID: 3049
	internal int number22;

	// Token: 0x04000BEA RID: 3050
	internal int number23;

	// Token: 0x04000BEB RID: 3051
	internal int number24;

	// Token: 0x04000BEC RID: 3052
	internal int number25;

	// Token: 0x04000BED RID: 3053
	internal sbyte sByte2;

	// Token: 0x04000BEE RID: 3054
	private static readonly int number26 = 262;

	// Token: 0x04000BEF RID: 3055
	internal int number27;

	// Token: 0x04000BF0 RID: 3056
	internal int number28;

	// Token: 0x04000BF1 RID: 3057
	internal byte[] byteArray2;

	// Token: 0x04000BF2 RID: 3058
	internal int number29;

	// Token: 0x04000BF3 RID: 3059
	internal short[] int16Array8;

	// Token: 0x04000BF4 RID: 3060
	internal int number30;

	// Token: 0x04000BF5 RID: 3061
	internal int number31;

	// Token: 0x04000BF6 RID: 3062
	private bool flag3;

	// Token: 0x04000BF7 RID: 3063
	internal int number32;

	// Token: 0x04000BF8 RID: 3064
	internal int number33;

	// Token: 0x04000BF9 RID: 3065
	internal int number34;

	// Token: 0x04000BFA RID: 3066
	internal int number35;

	// Token: 0x04000BFB RID: 3067
	internal int number36;

	// Token: 0x04000BFC RID: 3068
	internal int number37;

	// Token: 0x04000BFD RID: 3069
	internal byte[] byteArray3;

	// Token: 0x04000BFE RID: 3070
	internal int number38;

	// Token: 0x04000BFF RID: 3071
	private static readonly string[] textArray = new string[]
	{
		"need dictionary",
		"stream end",
		string.Empty,
		"file error",
		"stream error",
		"data error",
		"insufficient memory",
		"buffer error",
		"incompatible version",
		string.Empty
	};

	// Token: 0x02000339 RID: 825
	public sealed class 408
	{
		// Token: 0x0600198F RID: 6543 RVA: 0x0005DE82 File Offset: 0x0005C082
		private 408(int 1, int 2, int 3, int 4, 534 5)
		{
			this.number5 = 1;
			this.number7 = 2;
			this.number8 = 3;
			this.number6 = 4;
			this._recoveredType11842261 = 5;
		}

		// Token: 0x06001990 RID: 6544 RVA: 0x0005DEAF File Offset: 0x0005C0AF
		public static 407.408 Method2876(724 1)
		{
			return 407.408._recoveredType0498Array2266[(int)1];
		}

		// Token: 0x04000C00 RID: 3072
		internal 534 _recoveredType11842261;

		// Token: 0x04000C01 RID: 3073
		internal int number5;

		// Token: 0x04000C02 RID: 3074
		internal int number6;

		// Token: 0x04000C03 RID: 3075
		internal int number7;

		// Token: 0x04000C04 RID: 3076
		internal int number8;

		// Token: 0x04000C05 RID: 3077
		private static 407.408[] _recoveredType0498Array2266 = new 407.408[]
		{
			new 407.408(0, 0, 0, 0, (534)0),
			new 407.408(4, 4, 8, 4, (534)1),
			new 407.408(4, 5, 16, 8, (534)1),
			new 407.408(4, 6, 32, 32, (534)1),
			new 407.408(4, 4, 16, 16, (534)2),
			new 407.408(8, 16, 32, 32, (534)2),
			new 407.408(8, 16, 128, 128, (534)2),
			new 407.408(8, 32, 128, 256, (534)2),
			new 407.408(32, 128, 258, 1024, (534)2),
			new 407.408(32, 258, 258, 4096, (534)2)
		};
	}

	// Token: 0x0200033A RID: 826
	// (Invoke) Token: 0x06001993 RID: 6547
	public delegate 405 409(528 1);
}
