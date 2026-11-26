using System;
using System.IO;
using System.Runtime.InteropServices;

// Token: 0x02000223 RID: 547
[ComVisible(false)]
public sealed class 591 : 796, 794, 572
{
	// Token: 0x0600110B RID: 4363 RVA: 0x0003CC80 File Offset: 0x0003AE80
	public void Method7990(int 1)
	{
		this.flag = (1 > 2);
		if (this.flag)
		{
			this.number12 = 0U;
			this.number13 = 4U;
			this.number14 = 66560U;
			return;
		}
		this.number12 = 2U;
		this.number13 = 3U;
		this.number14 = 0U;
	}

	// Token: 0x0600110C RID: 4364 RVA: 0x0003CCCE File Offset: 0x0003AECE
	public void Method7991(Stream 1)
	{
		base.SetStream10318_13246(1);
	}

	// Token: 0x0600110D RID: 4365 RVA: 0x0003CCD7 File Offset: 0x0003AED7
	public void Method7992()
	{
		base.SetStream10318_13247();
	}

	// Token: 0x0600110E RID: 4366 RVA: 0x0003CCE0 File Offset: 0x0003AEE0
	public void Method7993()
	{
		base.Method13248();
		for (uint num = 0U; num < this.number11; num += 1U)
		{
			this.numberArray3[(int)num] = 0U;
		}
		this.number6 = 0U;
		base.Method13253(-1);
	}

	// Token: 0x0600110F RID: 4367 RVA: 0x0003CD1C File Offset: 0x0003AF1C
	public void Method7994()
	{
		uint num = this.number6 + 1U;
		this.number6 = num;
		if (num >= this.number7)
		{
			this.number6 = 0U;
		}
		base.Method13249();
		if (this.number19 == 2147483647U)
		{
			this.Method8002();
		}
	}

	// Token: 0x06001110 RID: 4368 RVA: 0x0003CD62 File Offset: 0x0003AF62
	public byte Method7995(int 1)
	{
		return base.Method13250(1);
	}

	// Token: 0x06001111 RID: 4369 RVA: 0x0003CD6B File Offset: 0x0003AF6B
	public uint Method7996(int 1, uint 2, uint 3)
	{
		return base.Method13251(1, 2, 3);
	}

	// Token: 0x06001112 RID: 4370 RVA: 0x0003CD76 File Offset: 0x0003AF76
	public uint Method7997()
	{
		return base.Method13252();
	}

	// Token: 0x06001113 RID: 4371 RVA: 0x0003CD80 File Offset: 0x0003AF80
	public void Method7998(uint 1, uint 2, uint 3, uint 4)
	{
		if (1 > 2147483391U)
		{
			throw new Exception();
		}
		this.number9 = 16U + (3 >> 1);
		uint 5 = (1 + 2 + 3 + 4) / 2U + 256U;
		base.Method13245(1 + 2, 3 + 4, 5);
		this.number8 = 3;
		uint num = 1 + 1U;
		if (this.number7 != num)
		{
			this.numberArray2 = new uint[(this.number7 = num) * 2U];
		}
		uint num2 = 65536U;
		if (this.flag)
		{
			num2 = 1 - 1U;
			num2 |= num2 >> 1;
			num2 |= num2 >> 2;
			num2 |= num2 >> 4;
			num2 |= num2 >> 8;
			num2 >>= 1;
			num2 |= 65535U;
			if (num2 > 16777216U)
			{
				num2 >>= 1;
			}
			this.number10 = num2;
			num2 += 1U;
			num2 += this.number14;
		}
		if (num2 != this.number11)
		{
			this.numberArray3 = new uint[this.number11 = num2];
		}
	}

	// Token: 0x06001114 RID: 4372 RVA: 0x0003CE68 File Offset: 0x0003B068
	public uint Method7999(uint[] 1)
	{
		uint num;
		if (this.number19 + this.number8 <= this.number22)
		{
			num = this.number8;
		}
		else
		{
			num = this.number22 - this.number19;
			if (num < this.number13)
			{
				this.Method7994();
				return 0U;
			}
		}
		uint num2 = 0U;
		uint num3 = (this.number19 > this.number7) ? (this.number19 - this.number7) : 0U;
		uint num4 = this.number17 + this.number19;
		uint num5 = 1U;
		uint num6 = 0U;
		uint num7 = 0U;
		uint num10;
		if (this.flag)
		{
			uint num8 = 775.numberArray[(int)this.byteArray[(int)num4]] ^ (uint)this.byteArray[(int)(num4 + 1U)];
			num6 = (num8 & 1023U);
			uint num9 = num8 ^ (uint)((uint)this.byteArray[(int)(num4 + 2U)] << 8);
			num7 = (num9 & 65535U);
			num10 = ((num9 ^ 775.numberArray[(int)this.byteArray[(int)(num4 + 3U)]] << 5) & this.number10);
		}
		else
		{
			num10 = (uint)((int)this.byteArray[(int)num4] ^ (int)this.byteArray[(int)(num4 + 1U)] << 8);
		}
		uint num11 = this.numberArray3[(int)(this.number14 + num10)];
		if (this.flag)
		{
			uint num12 = this.numberArray3[(int)num6];
			uint num13 = this.numberArray3[(int)(1024U + num7)];
			this.numberArray3[(int)num6] = this.number19;
			this.numberArray3[(int)(1024U + num7)] = this.number19;
			if (num12 > num3 && this.byteArray[(int)(this.number17 + num12)] == this.byteArray[(int)num4])
			{
				num5 = (1[(int)num2++] = 2U);
				1[(int)num2++] = this.number19 - num12 - 1U;
			}
			if (num13 > num3 && this.byteArray[(int)(this.number17 + num13)] == this.byteArray[(int)num4])
			{
				if (num13 == num12)
				{
					num2 -= 2U;
				}
				num5 = (1[(int)num2++] = 3U);
				1[(int)num2++] = this.number19 - num13 - 1U;
				num12 = num13;
			}
			if (num2 != 0U && num12 == num11)
			{
				num2 -= 2U;
				num5 = 1U;
			}
		}
		this.numberArray3[(int)(this.number14 + num10)] = this.number19;
		uint num14 = (this.number6 << 1) + 1U;
		uint num15 = this.number6 << 1;
		uint val2;
		uint val = val2 = this.number12;
		if (this.number12 != 0U && num11 > num3 && this.byteArray[(int)(this.number17 + num11 + this.number12)] != this.byteArray[(int)(num4 + this.number12)])
		{
			num5 = (1[(int)num2++] = this.number12);
			1[(int)num2++] = this.number19 - num11 - 1U;
		}
		uint num16 = this.number9;
		while (num11 > num3 && num16-- != 0U)
		{
			uint num17 = this.number19 - num11;
			uint num18 = ((num17 <= this.number6) ? (this.number6 - num17) : (this.number6 - num17 + this.number7)) << 1;
			uint num19 = this.number17 + num11;
			uint num20 = Math.Min(val2, val);
			if (this.byteArray[(int)(num19 + num20)] == this.byteArray[(int)(num4 + num20)])
			{
				while ((num20 += 1U) != num && this.byteArray[(int)(num19 + num20)] == this.byteArray[(int)(num4 + num20)])
				{
				}
				if (num5 < num20)
				{
					num5 = (1[(int)num2++] = num20);
					1[(int)num2++] = num17 - 1U;
					if (num20 == num)
					{
						this.numberArray2[(int)num15] = this.numberArray2[(int)num18];
						this.numberArray2[(int)num14] = this.numberArray2[(int)(num18 + 1U)];
						IL_3DF:
						this.Method7994();
						return num2;
					}
				}
			}
			if (this.byteArray[(int)(num19 + num20)] < this.byteArray[(int)(num4 + num20)])
			{
				this.numberArray2[(int)num15] = num11;
				num15 = num18 + 1U;
				num11 = this.numberArray2[(int)num15];
				val = num20;
			}
			else
			{
				this.numberArray2[(int)num14] = num11;
				num14 = num18;
				num11 = this.numberArray2[(int)num14];
				val2 = num20;
			}
		}
		this.numberArray2[(int)num14] = (this.numberArray2[(int)num15] = 0U);
		goto IL_3DF;
	}

	// Token: 0x06001115 RID: 4373 RVA: 0x0003D25C File Offset: 0x0003B45C
	public void Method8000(uint 1)
	{
		for (;;)
		{
			uint num;
			if (this.number19 + this.number8 <= this.number22)
			{
				num = this.number8;
				goto IL_40;
			}
			num = this.number22 - this.number19;
			if (num >= this.number13)
			{
				goto IL_40;
			}
			this.Method7994();
			IL_298:
			if ((1 -= 1U) == 0U)
			{
				break;
			}
			continue;
			IL_40:
			uint num2 = (this.number19 > this.number7) ? (this.number19 - this.number7) : 0U;
			uint num3 = this.number17 + this.number19;
			uint num8;
			if (this.flag)
			{
				uint num4 = 775.numberArray[(int)this.byteArray[(int)num3]] ^ (uint)this.byteArray[(int)(num3 + 1U)];
				uint num5 = num4 & 1023U;
				this.numberArray3[(int)num5] = this.number19;
				uint num6 = num4 ^ (uint)((uint)this.byteArray[(int)(num3 + 2U)] << 8);
				uint num7 = num6 & 65535U;
				this.numberArray3[(int)(1024U + num7)] = this.number19;
				num8 = ((num6 ^ 775.numberArray[(int)this.byteArray[(int)(num3 + 3U)]] << 5) & this.number10);
			}
			else
			{
				num8 = (uint)((int)this.byteArray[(int)num3] ^ (int)this.byteArray[(int)(num3 + 1U)] << 8);
			}
			uint num9 = this.numberArray3[(int)(this.number14 + num8)];
			this.numberArray3[(int)(this.number14 + num8)] = this.number19;
			uint num10 = (this.number6 << 1) + 1U;
			uint num11 = this.number6 << 1;
			uint val2;
			uint val = val2 = this.number12;
			uint num12 = this.number9;
			while (num9 > num2 && num12-- != 0U)
			{
				uint num13 = this.number19 - num9;
				uint num14 = ((num13 <= this.number6) ? (this.number6 - num13) : (this.number6 - num13 + this.number7)) << 1;
				uint num15 = this.number17 + num9;
				uint num16 = Math.Min(val2, val);
				if (this.byteArray[(int)(num15 + num16)] == this.byteArray[(int)(num3 + num16)])
				{
					while ((num16 += 1U) != num && this.byteArray[(int)(num15 + num16)] == this.byteArray[(int)(num3 + num16)])
					{
					}
					if (num16 == num)
					{
						this.numberArray2[(int)num11] = this.numberArray2[(int)num14];
						this.numberArray2[(int)num10] = this.numberArray2[(int)(num14 + 1U)];
						IL_292:
						this.Method7994();
						goto IL_298;
					}
				}
				if (this.byteArray[(int)(num15 + num16)] < this.byteArray[(int)(num3 + num16)])
				{
					this.numberArray2[(int)num11] = num9;
					num11 = num14 + 1U;
					num9 = this.numberArray2[(int)num11];
					val = num16;
				}
				else
				{
					this.numberArray2[(int)num10] = num9;
					num10 = num14;
					num9 = this.numberArray2[(int)num10];
					val2 = num16;
				}
			}
			this.numberArray2[(int)num10] = (this.numberArray2[(int)num11] = 0U);
			goto IL_292;
		}
	}

	// Token: 0x06001116 RID: 4374 RVA: 0x0003D50C File Offset: 0x0003B70C
	private void Method8001(uint[] 1, uint 2, uint 3)
	{
		for (uint num = 0U; num < 2; num += 1U)
		{
			uint num2 = 1[(int)num];
			num2 = ((num2 > 3) ? (num2 - 3) : 0U);
			1[(int)num] = num2;
		}
	}

	// Token: 0x06001117 RID: 4375 RVA: 0x0003D538 File Offset: 0x0003B738
	private void Method8002()
	{
		uint num = this.number19 - this.number7;
		this.Method8001(this.numberArray2, this.number7 * 2U, num);
		this.Method8001(this.numberArray3, this.number11, num);
		base.Method13253((int)num);
	}

	// Token: 0x06001118 RID: 4376 RVA: 0x0003D582 File Offset: 0x0003B782
	public void SetNumber6207_8003(uint 1)
	{
		this.number9 = 1;
	}

	// Token: 0x04000888 RID: 2184
	private uint number6;

	// Token: 0x04000889 RID: 2185
	private uint number7;

	// Token: 0x0400088A RID: 2186
	private uint number8;

	// Token: 0x0400088B RID: 2187
	private uint[] numberArray2;

	// Token: 0x0400088C RID: 2188
	private uint[] numberArray3;

	// Token: 0x0400088D RID: 2189
	private uint number9 = 255U;

	// Token: 0x0400088E RID: 2190
	private uint number10;

	// Token: 0x0400088F RID: 2191
	private uint number11;

	// Token: 0x04000890 RID: 2192
	private bool flag = true;

	// Token: 0x04000891 RID: 2193
	private uint number12;

	// Token: 0x04000892 RID: 2194
	private uint number13 = 4U;

	// Token: 0x04000893 RID: 2195
	private uint number14 = 66560U;
}
