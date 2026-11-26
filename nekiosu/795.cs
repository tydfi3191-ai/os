using System;
using System.Runtime.InteropServices;

// Token: 0x02000327 RID: 807
[ComVisible(false)]
public sealed class 795 : 664
{
	// Token: 0x0600187A RID: 6266 RVA: 0x000562AC File Offset: 0x000544AC
	public 795(760 1)
	{
		this._recoveredType222010276 = 1;
		this._recoveredType231610277 = new 772(1);
		this._recoveredType162210278 = new 629();
		this.byteArray2 = new byte[65536];
		this.int16Array = new short[32768];
		this.int16Array2 = new short[32768];
		this.number7 = (this.number8 = 1);
	}

	// Token: 0x0600187B RID: 6267 RVA: 0x00056320 File Offset: 0x00054520
	public bool Method13203(bool 1, bool 2)
	{
		for (;;)
		{
			this.Method13214();
			bool 3 = 1 && this.number16 == this.number17;
			bool flag;
			switch (this.number14)
			{
			case 0:
				flag = this.Method13219(3, 2);
				goto IL_62;
			case 1:
				flag = this.Method13220(3, 2);
				goto IL_62;
			case 2:
				flag = this.Method13221(3, 2);
				goto IL_62;
			}
			break;
			IL_62:
			bool flag2 = flag;
			if (!this._recoveredType222010276.Method10324() || !flag2)
			{
				return flag2;
			}
		}
		throw new InvalidOperationException("unknown compressionFunction");
	}

	// Token: 0x0600187C RID: 6268 RVA: 0x000563A4 File Offset: 0x000545A4
	public void Method13204(byte[] 1, int 2, int 3)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=zpMJwVYM=");
		}
		if (2 < 0)
		{
			throw new ArgumentOutOfRangeException("#=zJ_sgkP4=");
		}
		if (3 < 0)
		{
			throw new ArgumentOutOfRangeException("#=zW32YDQ0=");
		}
		if (this.number16 < this.number17)
		{
			throw new InvalidOperationException("Old input was not completely processed");
		}
		int num = 2 + 3;
		if (2 > num || num > 1.Length)
		{
			throw new ArgumentOutOfRangeException("#=zW32YDQ0=");
		}
		this.byteArray3 = 1;
		this.number16 = 2;
		this.number17 = num;
	}

	// Token: 0x0600187D RID: 6269 RVA: 0x00056424 File Offset: 0x00054624
	public bool Method13205()
	{
		return this.number17 == this.number16;
	}

	// Token: 0x0600187E RID: 6270 RVA: 0x00056434 File Offset: 0x00054634
	public void Method13206(byte[] 1, int 2, int 3)
	{
		this._recoveredType162210278.Method90912(1, 2, 3);
		if (3 >= 3)
		{
			if (3 > 32506)
			{
				2 += 3 - 32506;
				3 = 32506;
			}
			Array.Copy(1, 2, this.byteArray2, this.number8, 3);
			this.SetNumber10256_13215();
			3--;
			while (--3 > 0)
			{
				this.Method13216();
				this.number8++;
			}
			this.number8 += 2;
			this.number7 = this.number8;
		}
	}

	// Token: 0x0600187F RID: 6271 RVA: 0x000564C8 File Offset: 0x000546C8
	public void Method13207()
	{
		this._recoveredType231610277.Method12669();
		this._recoveredType162210278.SetNumber7041_9090();
		this.number7 = (this.number8 = 1);
		this.number9 = 0;
		this.number15 = 0L;
		this.flag5 = false;
		this.number6 = 2;
		for (int i = 0; i < 32768; i++)
		{
			this.int16Array[i] = 0;
		}
		for (int j = 0; j < 32768; j++)
		{
			this.int16Array2[j] = 0;
		}
	}

	// Token: 0x06001880 RID: 6272 RVA: 0x0005654A File Offset: 0x0005474A
	public void Method13208()
	{
		this._recoveredType162210278.SetNumber7041_9090();
	}

	// Token: 0x06001881 RID: 6273 RVA: 0x00056557 File Offset: 0x00054757
	public int Method13209()
	{
		return (int)this._recoveredType162210278.GetNumber7041_9089();
	}

	// Token: 0x06001882 RID: 6274 RVA: 0x00056565 File Offset: 0x00054765
	public long GetNumber10273_13210()
	{
		return this.number15;
	}

	// Token: 0x06001883 RID: 6275 RVA: 0x0005656D File Offset: 0x0005476D
	public 589 GetRecoveredType139910266_13211()
	{
		return this._recoveredType139910266;
	}

	// Token: 0x06001884 RID: 6276 RVA: 0x00056575 File Offset: 0x00054775
	public void SetRecoveredType139910266_13212(589 1)
	{
		this._recoveredType139910266 = 1;
	}

	// Token: 0x06001885 RID: 6277 RVA: 0x00056580 File Offset: 0x00054780
	public void Method13213(int 1)
	{
		if (1 < 0 || 1 > 9)
		{
			throw new ArgumentOutOfRangeException("#=zsQQ_ZcE=");
		}
		this.number13 = 664.numberArray[1];
		this.number11 = 664.numberArray2[1];
		this.number12 = 664.numberArray3[1];
		this.number10 = 664.numberArray4[1];
		if (664.numberArray5[1] == this.number14)
		{
			return;
		}
		switch (this.number14)
		{
		case 0:
			if (this.number8 > this.number7)
			{
				this._recoveredType231610277.Method12672(this.byteArray2, this.number7, this.number8 - this.number7, false);
				this.number7 = this.number8;
			}
			this.SetNumber10256_13215();
			break;
		case 1:
			if (this.number8 > this.number7)
			{
				this._recoveredType231610277.Method12673(this.byteArray2, this.number7, this.number8 - this.number7, false);
				this.number7 = this.number8;
			}
			break;
		case 2:
			if (this.flag5)
			{
				this._recoveredType231610277.Method12675((int)(this.byteArray2[this.number8 - 1] & byte.MaxValue));
			}
			if (this.number8 > this.number7)
			{
				this._recoveredType231610277.Method12673(this.byteArray2, this.number7, this.number8 - this.number7, false);
				this.number7 = this.number8;
			}
			this.flag5 = false;
			this.number6 = 2;
			break;
		}
		this.number14 = 664.numberArray5[1];
	}

	// Token: 0x06001886 RID: 6278 RVA: 0x00056714 File Offset: 0x00054914
	public void Method13214()
	{
		if (this.number8 >= 65274)
		{
			this.Method13217();
		}
		while (this.number9 < 262 && this.number16 < this.number17)
		{
			int num = 65536 - this.number9 - this.number8;
			if (num > this.number17 - this.number16)
			{
				num = this.number17 - this.number16;
			}
			Array.Copy(this.byteArray3, this.number16, this.byteArray2, this.number8 + this.number9, num);
			this._recoveredType162210278.Method90912(this.byteArray3, this.number16, num);
			this.number16 += num;
			this.number15 += (long)num;
			this.number9 += num;
		}
		if (this.number9 >= 3)
		{
			this.SetNumber10256_13215();
		}
	}

	// Token: 0x06001887 RID: 6279 RVA: 0x00056803 File Offset: 0x00054A03
	private void SetNumber10256_13215()
	{
		this.number4 = ((int)this.byteArray2[this.number8] << 5 ^ (int)this.byteArray2[this.number8 + 1]);
	}

	// Token: 0x06001888 RID: 6280 RVA: 0x0005682C File Offset: 0x00054A2C
	private int Method13216()
	{
		int num = (this.number4 << 5 ^ (int)this.byteArray2[this.number8 + 2]) & 32767;
		int num2 = (int)(this.int16Array2[this.number8 & 32767] = this.int16Array[num]);
		this.int16Array[num] = (short)this.number8;
		this.number4 = num;
		return num2 & 65535;
	}

	// Token: 0x06001889 RID: 6281 RVA: 0x00056894 File Offset: 0x00054A94
	private void Method13217()
	{
		Array.Copy(this.byteArray2, 32768, this.byteArray2, 0, 32768);
		this.number5 -= 32768;
		this.number8 -= 32768;
		this.number7 -= 32768;
		for (int i = 0; i < 32768; i++)
		{
			int num = (int)this.int16Array[i] & 65535;
			this.int16Array[i] = (short)((num >= 32768) ? (num - 32768) : 0);
		}
		for (int j = 0; j < 32768; j++)
		{
			int num2 = (int)this.int16Array2[j] & 65535;
			this.int16Array2[j] = (short)((num2 >= 32768) ? (num2 - 32768) : 0);
		}
	}

	// Token: 0x0600188A RID: 6282 RVA: 0x00056968 File Offset: 0x00054B68
	private bool Method13218(int 1)
	{
		int num = this.number10;
		int num2 = this.number12;
		short[] array = this.int16Array2;
		int num3 = this.number8;
		int num4 = this.number8 + this.number6;
		int num5 = Math.Max(this.number6, 2);
		int num6 = Math.Max(this.number8 - 32506, 0);
		int num7 = this.number8 + 258 - 1;
		byte b = this.byteArray2[num4 - 1];
		byte b2 = this.byteArray2[num4];
		if (num5 >= this.number13)
		{
			num >>= 2;
		}
		if (num2 > this.number9)
		{
			num2 = this.number9;
		}
		do
		{
			if (this.byteArray2[1 + num5] == b2 && this.byteArray2[1 + num5 - 1] == b && this.byteArray2[1] == this.byteArray2[num3] && this.byteArray2[1 + 1] == this.byteArray2[num3 + 1])
			{
				int num8 = 1 + 2;
				num3 += 2;
				while (this.byteArray2[++num3] == this.byteArray2[++num8] && this.byteArray2[++num3] == this.byteArray2[++num8] && this.byteArray2[++num3] == this.byteArray2[++num8] && this.byteArray2[++num3] == this.byteArray2[++num8] && this.byteArray2[++num3] == this.byteArray2[++num8] && this.byteArray2[++num3] == this.byteArray2[++num8] && this.byteArray2[++num3] == this.byteArray2[++num8] && this.byteArray2[++num3] == this.byteArray2[++num8] && num3 < num7)
				{
				}
				if (num3 > num4)
				{
					this.number5 = 1;
					num4 = num3;
					num5 = num3 - this.number8;
					if (num5 >= num2)
					{
						break;
					}
					b = this.byteArray2[num4 - 1];
					b2 = this.byteArray2[num4];
				}
				num3 = this.number8;
			}
		}
		while ((1 = ((int)array[1 & 32767] & 65535)) > num6 && --num != 0);
		this.number6 = Math.Min(num5, this.number9);
		return this.number6 >= 3;
	}

	// Token: 0x0600188B RID: 6283 RVA: 0x00056BD4 File Offset: 0x00054DD4
	private bool Method13219(bool 1, bool 2)
	{
		if (!1 && this.number9 == 0)
		{
			return false;
		}
		this.number8 += this.number9;
		this.number9 = 0;
		int num = this.number8 - this.number7;
		if (num >= 664.number3 || (this.number7 < 32768 && num >= 32506) || 1)
		{
			bool flag = 2;
			if (num > 664.number3)
			{
				num = 664.number3;
				flag = false;
			}
			this._recoveredType231610277.Method12672(this.byteArray2, this.number7, num, flag);
			this.number7 += num;
			return !flag;
		}
		return true;
	}

	// Token: 0x0600188C RID: 6284 RVA: 0x00056C80 File Offset: 0x00054E80
	private bool Method13220(bool 1, bool 2)
	{
		if (this.number9 < 262 && !1)
		{
			return false;
		}
		while (this.number9 >= 262 || 1)
		{
			if (this.number9 == 0)
			{
				this._recoveredType231610277.Method12673(this.byteArray2, this.number7, this.number8 - this.number7, 2);
				this.number7 = this.number8;
				return false;
			}
			if (this.number8 > 65274)
			{
				this.Method13217();
			}
			int num;
			if (this.number9 >= 3 && (num = this.Method13216()) != 0 && this._recoveredType139910266 != (589)2 && this.number8 - num <= 32506 && this.Method13218(num))
			{
				bool flag = this._recoveredType231610277.Method12676(this.number8 - this.number5, this.number6);
				this.number9 -= this.number6;
				if (this.number6 <= this.number11 && this.number9 >= 3)
				{
					for (;;)
					{
						int num2 = this.number6 - 1;
						this.number6 = num2;
						if (num2 <= 0)
						{
							break;
						}
						this.number8++;
						this.Method13216();
					}
					this.number8++;
				}
				else
				{
					this.number8 += this.number6;
					if (this.number9 >= 2)
					{
						this.SetNumber10256_13215();
					}
				}
				this.number6 = 2;
				if (!flag)
				{
					continue;
				}
			}
			else
			{
				this._recoveredType231610277.Method12675((int)(this.byteArray2[this.number8] & byte.MaxValue));
				this.number8++;
				this.number9--;
			}
			if (this._recoveredType231610277.Method12674())
			{
				bool flag2 = 2 && this.number9 == 0;
				this._recoveredType231610277.Method12673(this.byteArray2, this.number7, this.number8 - this.number7, flag2);
				this.number7 = this.number8;
				return !flag2;
			}
		}
		return true;
	}

	// Token: 0x0600188D RID: 6285 RVA: 0x00056E94 File Offset: 0x00055094
	private bool Method13221(bool 1, bool 2)
	{
		if (this.number9 < 262 && !1)
		{
			return false;
		}
		while (this.number9 >= 262 || 1)
		{
			if (this.number9 == 0)
			{
				if (this.flag5)
				{
					this._recoveredType231610277.Method12675((int)(this.byteArray2[this.number8 - 1] & byte.MaxValue));
				}
				this.flag5 = false;
				this._recoveredType231610277.Method12673(this.byteArray2, this.number7, this.number8 - this.number7, 2);
				this.number7 = this.number8;
				return false;
			}
			if (this.number8 >= 65274)
			{
				this.Method13217();
			}
			int num = this.number5;
			int num2 = this.number6;
			if (this.number9 >= 3)
			{
				int num3 = this.Method13216();
				if (this._recoveredType139910266 != (589)2 && num3 != 0 && this.number8 - num3 <= 32506 && this.Method13218(num3) && this.number6 <= 5 && (this._recoveredType139910266 == (589)1 || (this.number6 == 3 && this.number8 - this.number5 > 4096)))
				{
					this.number6 = 2;
				}
			}
			if (num2 >= 3 && this.number6 <= num2)
			{
				this._recoveredType231610277.Method12676(this.number8 - 1 - num, num2);
				num2 -= 2;
				do
				{
					this.number8++;
					this.number9--;
					if (this.number9 >= 3)
					{
						this.Method13216();
					}
				}
				while (--num2 > 0);
				this.number8++;
				this.number9--;
				this.flag5 = false;
				this.number6 = 2;
			}
			else
			{
				if (this.flag5)
				{
					this._recoveredType231610277.Method12675((int)(this.byteArray2[this.number8 - 1] & byte.MaxValue));
				}
				this.flag5 = true;
				this.number8++;
				this.number9--;
			}
			if (this._recoveredType231610277.Method12674())
			{
				int num4 = this.number8 - this.number7;
				if (this.flag5)
				{
					num4--;
				}
				bool flag = 2 && this.number9 == 0 && !this.flag5;
				this._recoveredType231610277.Method12673(this.byteArray2, this.number7, num4, flag);
				this.number7 += num4;
				return !flag;
			}
		}
		return true;
	}

	// Token: 0x04000B6E RID: 2926
	private int number4;

	// Token: 0x04000B6F RID: 2927
	private short[] int16Array;

	// Token: 0x04000B70 RID: 2928
	private short[] int16Array2;

	// Token: 0x04000B71 RID: 2929
	private int number5;

	// Token: 0x04000B72 RID: 2930
	private int number6;

	// Token: 0x04000B73 RID: 2931
	private bool flag5;

	// Token: 0x04000B74 RID: 2932
	private int number7;

	// Token: 0x04000B75 RID: 2933
	private int number8;

	// Token: 0x04000B76 RID: 2934
	private int number9;

	// Token: 0x04000B77 RID: 2935
	private byte[] byteArray2;

	// Token: 0x04000B78 RID: 2936
	private 589 _recoveredType139910266;

	// Token: 0x04000B79 RID: 2937
	private int number10;

	// Token: 0x04000B7A RID: 2938
	private int number11;

	// Token: 0x04000B7B RID: 2939
	private int number12;

	// Token: 0x04000B7C RID: 2940
	private int number13;

	// Token: 0x04000B7D RID: 2941
	private int number14;

	// Token: 0x04000B7E RID: 2942
	private byte[] byteArray3;

	// Token: 0x04000B7F RID: 2943
	private long number15;

	// Token: 0x04000B80 RID: 2944
	private int number16;

	// Token: 0x04000B81 RID: 2945
	private int number17;

	// Token: 0x04000B82 RID: 2946
	private 760 _recoveredType222010276;

	// Token: 0x04000B83 RID: 2947
	private 772 _recoveredType231610277;

	// Token: 0x04000B84 RID: 2948
	private 629 _recoveredType162210278;
}
