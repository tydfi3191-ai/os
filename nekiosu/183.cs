using System;
using System.IO;
using System.Runtime.InteropServices;

// Token: 0x0200020F RID: 527
[ComVisible(false)]
public sealed class 183 : 749, 503
{
	// Token: 0x06001094 RID: 4244 RVA: 0x000391CC File Offset: 0x000373CC
	public 183()
	{
		this.number3 = uint.MaxValue;
		int num = 0;
		while ((long)num < 4L)
		{
			this.lzmaBitTreeDecoderArray[num] = new 181(6);
			num++;
		}
	}

	// Token: 0x06001095 RID: 4245 RVA: 0x000392B8 File Offset: 0x000374B8
	private void Method6884(uint 1)
	{
		if (this.number3 != 1)
		{
			this.number3 = 1;
			this.number4 = Math.Max(this.number3, 1U);
			uint 2 = Math.Max(this.number4, 4096U);
			this._recoveredType07885456.Method4434(2);
		}
	}

	// Token: 0x06001096 RID: 4246 RVA: 0x00039304 File Offset: 0x00037504
	private void Method6885(int 1, int 2)
	{
		if (1 > 8)
		{
			throw new 485();
		}
		if (2 > 8)
		{
			throw new 485();
		}
		this._recoveredType12075469.Method6876(1, 2);
	}

	// Token: 0x06001097 RID: 4247 RVA: 0x00039328 File Offset: 0x00037528
	private void Method6886(int 1)
	{
		if (1 > 4)
		{
			throw new 485();
		}
		uint num = 1U << 1;
		this._recoveredType12095467.Method6881(num);
		this._recoveredType12095468.Method6881(num);
		this.number5 = num - 1U;
	}

	// Token: 0x06001098 RID: 4248 RVA: 0x00039368 File Offset: 0x00037568
	private void Method6887(Stream 1, Stream 2)
	{
		this.rangeDecoder2.Init(1);
		this._recoveredType07885456.Method4435(2, this.flag);
		for (uint num = 0U; num < 12U; num += 1U)
		{
			for (uint num2 = 0U; num2 <= this.number5; num2 += 1U)
			{
				uint num3 = (num << 4) + num2;
				this._recoveredType2065Array5458[(int)num3].SetNumber8943_11268();
				this._recoveredType2065Array5463[(int)num3].SetNumber8943_11268();
			}
			this._recoveredType2065Array5459[(int)num].SetNumber8943_11268();
			this._recoveredType2065Array5460[(int)num].SetNumber8943_11268();
			this._recoveredType2065Array5461[(int)num].SetNumber8943_11268();
			this._recoveredType2065Array5462[(int)num].SetNumber8943_11268();
		}
		this._recoveredType12075469.Method6877();
		for (uint num4 = 0U; num4 < 4U; num4 += 1U)
		{
			this.lzmaBitTreeDecoderArray[(int)num4].Init();
		}
		for (uint num5 = 0U; num5 < 114U; num5 += 1U)
		{
			this._recoveredType2065Array5465[(int)num5].SetNumber8943_11268();
		}
		this._recoveredType12095467.Method6882();
		this._recoveredType12095468.Method6882();
		this.lzmaBitTreeDecoder.Init();
	}

	// Token: 0x06001099 RID: 4249 RVA: 0x00039490 File Offset: 0x00037690
	public void Method6888(Stream 1, Stream 2, long 3, long 4, 393 5)
	{
		this.Method6887(1, 2);
		602.603 6 = default(602.603);
		6.SetNumber6486_8315();
		uint num = 0U;
		uint num2 = 0U;
		uint num3 = 0U;
		uint num4 = 0U;
		ulong num5 = 0UL;
		if (num5 < (ulong)4)
		{
			if (this._recoveredType2065Array5458[(int)((int)6.number << 4)].Method11269(this.rangeDecoder2) != 0U)
			{
				throw new 797();
			}
			6.Method8316();
			byte 7 = this._recoveredType12075469.Method6879(this.rangeDecoder2, 0U, 0);
			this._recoveredType07885456.Method4440(7);
			num5 += 1UL;
		}
		while (num5 < (ulong)4)
		{
			uint num6 = (uint)((int)num5 & (int)this.number5);
			if (this._recoveredType2065Array5458[(int)((6.number << 4) + num6)].Method11269(this.rangeDecoder2) == 0U)
			{
				byte 8 = this._recoveredType07885456.Method4441(0U);
				byte 9 = 6.Method8320() ? this._recoveredType12075469.Method6879(this.rangeDecoder2, (uint)num5, 8) : this._recoveredType12075469.Method6880(this.rangeDecoder2, (uint)num5, 8, this._recoveredType07885456.Method4441(num));
				this._recoveredType07885456.Method4440(9);
				6.Method8316();
				num5 += 1UL;
			}
			else
			{
				uint num8;
				if (this._recoveredType2065Array5459[(int)6.number].Method11269(this.rangeDecoder2) == 1U)
				{
					if (this._recoveredType2065Array5460[(int)6.number].Method11269(this.rangeDecoder2) == 0U)
					{
						if (this._recoveredType2065Array5463[(int)((6.number << 4) + num6)].Method11269(this.rangeDecoder2) == 0U)
						{
							6.SetNumber6486_8319();
							this._recoveredType07885456.Method4440(this._recoveredType07885456.Method4441(num));
							num5 += 1UL;
							continue;
						}
					}
					else
					{
						uint num7;
						if (this._recoveredType2065Array5461[(int)6.number].Method11269(this.rangeDecoder2) == 0U)
						{
							num7 = num2;
						}
						else
						{
							if (this._recoveredType2065Array5462[(int)6.number].Method11269(this.rangeDecoder2) == 0U)
							{
								num7 = num3;
							}
							else
							{
								num7 = num4;
								num4 = num3;
							}
							num3 = num2;
						}
						num2 = num;
						num = num7;
					}
					num8 = this._recoveredType12095468.Method6883(this.rangeDecoder2, num6) + 2U;
					6.SetNumber6486_8318();
				}
				else
				{
					num4 = num3;
					num3 = num2;
					num2 = num;
					num8 = 2U + this._recoveredType12095467.Method6883(this.rangeDecoder2, num6);
					6.SetNumber6486_8317();
					uint num9 = this.lzmaBitTreeDecoderArray[(int)602.Method8321(num8)].Decode(this.rangeDecoder2);
					if (num9 >= 4U)
					{
						int num10 = (int)((num9 >> 1) - 1U);
						num = (2U | (num9 & 1U)) << num10;
						if (num9 < 14U)
						{
							num += 181.Method5030(this._recoveredType2065Array5465, num - num9 - 1U, this.rangeDecoder2, num10);
						}
						else
						{
							num += this.rangeDecoder2.DecodeDirectBits(num10 - 4) << 4;
							num += this.lzmaBitTreeDecoder.Method5030(this.rangeDecoder2);
						}
					}
					else
					{
						num = num9;
					}
				}
				if ((ulong)num >= (ulong)this._recoveredType07885456.number6 + num5 || num >= this.number4)
				{
					if (num != 4294967295U)
					{
						throw new 797();
					}
					break;
				}
				else
				{
					this._recoveredType07885456.Method4439(num, num8);
					num5 += (ulong)num8;
				}
			}
		}
		this._recoveredType07885456.Method4438();
		this._recoveredType07885456.Method4437();
		this.rangeDecoder2.ReleaseStream();
	}

	// Token: 0x0600109A RID: 4250 RVA: 0x000397E0 File Offset: 0x000379E0
	public void Method6889(byte[] 1)
	{
		if (1.Length < 5)
		{
			throw new 485();
		}
		int 2 = (int)(1[0] % 9);
		byte b = 1[0] / 9;
		int 3 = (int)(b % 5);
		int num = (int)(b / 5);
		if (num > 4)
		{
			throw new 485();
		}
		uint num2 = 0U;
		for (int i = 0; i < 4; i++)
		{
			num2 += (uint)((uint)1[1 + i] << i * 8);
		}
		this.Method6884(num2);
		this.Method6885(3, 2);
		this.Method6886(num);
	}

	// Token: 0x0600109B RID: 4251 RVA: 0x00039850 File Offset: 0x00037A50
	public bool Method6890(Stream 1)
	{
		this.flag = true;
		return this._recoveredType07885456.Method4436(1);
	}

	// Token: 0x0400080E RID: 2062
	private 468 _recoveredType07885456 = new 468();

	// Token: 0x0400080F RID: 2063
	private 281 rangeDecoder2 = new 281();

	// Token: 0x04000810 RID: 2064
	private 726[] _recoveredType2065Array5458 = new 726[192];

	// Token: 0x04000811 RID: 2065
	private 726[] _recoveredType2065Array5459 = new 726[12];

	// Token: 0x04000812 RID: 2066
	private 726[] _recoveredType2065Array5460 = new 726[12];

	// Token: 0x04000813 RID: 2067
	private 726[] _recoveredType2065Array5461 = new 726[12];

	// Token: 0x04000814 RID: 2068
	private 726[] _recoveredType2065Array5462 = new 726[12];

	// Token: 0x04000815 RID: 2069
	private 726[] _recoveredType2065Array5463 = new 726[192];

	// Token: 0x04000816 RID: 2070
	private 181[] lzmaBitTreeDecoderArray = new 181[4];

	// Token: 0x04000817 RID: 2071
	private 726[] _recoveredType2065Array5465 = new 726[114];

	// Token: 0x04000818 RID: 2072
	private 181 lzmaBitTreeDecoder = new 181(4);

	// Token: 0x04000819 RID: 2073
	private 183.186 _recoveredType12095467 = new 183.186();

	// Token: 0x0400081A RID: 2074
	private 183.186 _recoveredType12095468 = new 183.186();

	// Token: 0x0400081B RID: 2075
	private 183.184 _recoveredType12075469 = new 183.184();

	// Token: 0x0400081C RID: 2076
	private uint number3;

	// Token: 0x0400081D RID: 2077
	private uint number4;

	// Token: 0x0400081E RID: 2078
	private uint number5;

	// Token: 0x0400081F RID: 2079
	private bool flag;

	// Token: 0x02000210 RID: 528
	public sealed class 184
	{
		// Token: 0x0600109C RID: 4252 RVA: 0x00039868 File Offset: 0x00037A68
		public void Method6876(int 1, int 2)
		{
			if (this._recoveredType1208Array5446 == null || this.number3 != 2 || this.number4 != 1)
			{
				this.number4 = 1;
				this.number5 = (1U << 1) - 1U;
				this.number3 = 2;
				uint num = 1U << this.number3 + this.number4;
				this._recoveredType1208Array5446 = new 183.184.185[num];
				for (uint num2 = 0U; num2 < num; num2 += 1U)
				{
					this._recoveredType1208Array5446[(int)num2].SetRecoveredType2065Array5445_6872();
				}
			}
		}

		// Token: 0x0600109D RID: 4253 RVA: 0x000398E8 File Offset: 0x00037AE8
		public void Method6877()
		{
			uint num = 1U << this.number3 + this.number4;
			for (uint num2 = 0U; num2 < num; num2 += 1U)
			{
				this._recoveredType1208Array5446[(int)num2].Method6873();
			}
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x00039925 File Offset: 0x00037B25
		private uint Method6878(uint 1, byte 2)
		{
			return ((1 & this.number5) << this.number3) + (uint)(2 >> 8 - this.number3);
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x00039947 File Offset: 0x00037B47
		public byte Method6879(281 1, uint 2, byte 3)
		{
			return this._recoveredType1208Array5446[(int)this.Method6878(2, 3)].Method6874(1);
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x00039962 File Offset: 0x00037B62
		public byte Method6880(281 1, uint 2, byte 3, byte 4)
		{
			return this._recoveredType1208Array5446[(int)this.Method6878(2, 3)].Method6875(1, 4);
		}

		// Token: 0x04000820 RID: 2080
		private 183.184.185[] _recoveredType1208Array5446;

		// Token: 0x04000821 RID: 2081
		private int number3;

		// Token: 0x04000822 RID: 2082
		private int number4;

		// Token: 0x04000823 RID: 2083
		private uint number5;

		// Token: 0x02000211 RID: 529
		public struct 185
		{
			// Token: 0x060010A2 RID: 4258 RVA: 0x0003997F File Offset: 0x00037B7F
			public void SetRecoveredType2065Array5445_6872()
			{
				this._recoveredType2065Array5445 = new 726[768];
			}

			// Token: 0x060010A3 RID: 4259 RVA: 0x00039994 File Offset: 0x00037B94
			public void Method6873()
			{
				for (int i = 0; i < 768; i++)
				{
					this._recoveredType2065Array5445[i].SetNumber8943_11268();
				}
			}

			// Token: 0x060010A4 RID: 4260 RVA: 0x000399C4 File Offset: 0x00037BC4
			public byte Method6874(281 1)
			{
				uint num = 1U;
				do
				{
					num = (num << 1 | this._recoveredType2065Array5445[(int)num].Method11269(1));
				}
				while (num < 256U);
				return (byte)num;
			}

			// Token: 0x060010A5 RID: 4261 RVA: 0x000399F4 File Offset: 0x00037BF4
			public byte Method6875(281 1, byte 2)
			{
				uint num = 1U;
				for (;;)
				{
					uint num2 = (uint)(2 >> 7 & 1);
					2 = (byte)(2 << 1);
					uint num3 = this._recoveredType2065Array5445[(int)((1U + num2 << 8) + num)].Method11269(1);
					num = (num << 1 | num3);
					if (num2 != num3)
					{
						break;
					}
					if (num >= 256U)
					{
						goto IL_5C;
					}
				}
				while (num < 256U)
				{
					num = (num << 1 | this._recoveredType2065Array5445[(int)num].Method11269(1));
				}
				IL_5C:
				return (byte)num;
			}

			// Token: 0x04000824 RID: 2084
			private 726[] _recoveredType2065Array5445;
		}
	}

	// Token: 0x02000212 RID: 530
	public sealed class 186
	{
		// Token: 0x060010A6 RID: 4262 RVA: 0x00039A60 File Offset: 0x00037C60
		public void Method6881(uint 1)
		{
			for (uint num = this.number2; num < 1; num += 1U)
			{
				this.lzmaBitTreeDecoderArray[(int)num] = new 181(3);
				this.lzmaBitTreeDecoderArray2[(int)num] = new 181(3);
			}
			this.number2 = 1;
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x00039AAC File Offset: 0x00037CAC
		public void Method6882()
		{
			this._recoveredType20655450.SetNumber8943_11268();
			for (uint num = 0U; num < this.number2; num += 1U)
			{
				this.lzmaBitTreeDecoderArray[(int)num].Init();
				this.lzmaBitTreeDecoderArray2[(int)num].Init();
			}
			this._recoveredType20655451.SetNumber8943_11268();
			this.lzmaBitTreeDecoder.Init();
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x00039B10 File Offset: 0x00037D10
		public uint Method6883(281 1, uint 2)
		{
			if (this._recoveredType20655450.Method11269(1) == 0U)
			{
				return this.lzmaBitTreeDecoderArray[(int)2].Decode(1);
			}
			uint num = 8U;
			if (this._recoveredType20655451.Method11269(1) == 0U)
			{
				return num + this.lzmaBitTreeDecoderArray2[(int)2].Decode(1);
			}
			num += 8U;
			return num + this.lzmaBitTreeDecoder.Decode(1);
		}

		// Token: 0x04000825 RID: 2085
		private 726 _recoveredType20655450;

		// Token: 0x04000826 RID: 2086
		private 726 _recoveredType20655451;

		// Token: 0x04000827 RID: 2087
		private 181[] lzmaBitTreeDecoderArray = new 181[16];

		// Token: 0x04000828 RID: 2088
		private 181[] lzmaBitTreeDecoderArray2 = new 181[16];

		// Token: 0x04000829 RID: 2089
		private 181 lzmaBitTreeDecoder = new 181(8);

		// Token: 0x0400082A RID: 2090
		private uint number2;
	}
}
