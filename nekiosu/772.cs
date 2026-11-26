using System;
using System.Runtime.InteropServices;

// Token: 0x02000321 RID: 801
[ComVisible(false)]
public sealed class 772
{
	// Token: 0x0600181E RID: 6174 RVA: 0x00054778 File Offset: 0x00052978
	static 772()
	{
		int i = 0;
		while (i < 144)
		{
			772.int16Array2[i] = 772.Method12677(48 + i << 8);
			772.byteArray3[i++] = 8;
		}
		while (i < 256)
		{
			772.int16Array2[i] = 772.Method12677(256 + i << 7);
			772.byteArray3[i++] = 9;
		}
		while (i < 280)
		{
			772.int16Array2[i] = 772.Method12677(-256 + i << 9);
			772.byteArray3[i++] = 7;
		}
		while (i < 286)
		{
			772.int16Array2[i] = 772.Method12677(-88 + i << 8);
			772.byteArray3[i++] = 8;
		}
		772.int16Array3 = new short[30];
		772.byteArray4 = new byte[30];
		for (i = 0; i < 30; i++)
		{
			772.int16Array3[i] = 772.Method12677(i << 11);
			772.byteArray4[i] = 5;
		}
	}

	// Token: 0x0600181F RID: 6175 RVA: 0x000548B8 File Offset: 0x00052AB8
	public 772(760 1)
	{
		this._recoveredType22209910 = 1;
		this._recoveredType23179911 = new 772.773(this, 286, 257, 15);
		this._recoveredType23179912 = new 772.773(this, 30, 1, 15);
		this._recoveredType23179913 = new 772.773(this, 19, 4, 7);
		this.int16Array4 = new short[16384];
		this.byteArray5 = new byte[16384];
	}

	// Token: 0x06001820 RID: 6176 RVA: 0x0005492B File Offset: 0x00052B2B
	public void Method12669()
	{
		this.number4 = 0;
		this.number5 = 0;
		this._recoveredType23179911.Method12659();
		this._recoveredType23179912.Method12659();
		this._recoveredType23179913.Method12659();
	}

	// Token: 0x06001821 RID: 6177 RVA: 0x0005495C File Offset: 0x00052B5C
	public void Method12670(int 1)
	{
		this._recoveredType23179913.Method12663();
		this._recoveredType23179911.Method12663();
		this._recoveredType23179912.Method12663();
		this._recoveredType22209910.Method10322(this._recoveredType23179911.number5 - 257, 5);
		this._recoveredType22209910.Method10322(this._recoveredType23179912.number5 - 1, 5);
		this._recoveredType22209910.Method10322(1 - 4, 4);
		for (int i = 0; i < 1; i++)
		{
			this._recoveredType22209910.Method10322((int)this._recoveredType23179913.byteArray2[772.numberArray2[i]], 3);
		}
		this._recoveredType23179911.Method12667(this._recoveredType23179913);
		this._recoveredType23179912.Method12667(this._recoveredType23179913);
	}

	// Token: 0x06001822 RID: 6178 RVA: 0x00054A1C File Offset: 0x00052C1C
	public void Method12671()
	{
		for (int i = 0; i < this.number4; i++)
		{
			int num = (int)(this.byteArray5[i] & byte.MaxValue);
			int num2 = (int)this.int16Array4[i];
			if (num2-- != 0)
			{
				int num3 = 772.Method12678(num);
				this._recoveredType23179911.Method12660(num3);
				int num4 = (num3 - 261) / 4;
				if (num4 > 0 && num4 <= 5)
				{
					this._recoveredType22209910.Method10322(num & (1 << num4) - 1, num4);
				}
				int num5 = 772.Method12679(num2);
				this._recoveredType23179912.Method12660(num5);
				num4 = num5 / 2 - 1;
				if (num4 > 0)
				{
					this._recoveredType22209910.Method10322(num2 & (1 << num4) - 1, num4);
				}
			}
			else
			{
				this._recoveredType23179911.Method12660(num);
			}
		}
		this._recoveredType23179911.Method12660(256);
	}

	// Token: 0x06001823 RID: 6179 RVA: 0x00054AF8 File Offset: 0x00052CF8
	public void Method12672(byte[] 1, int 2, int 3, bool 4)
	{
		this._recoveredType22209910.Method10322((4 > false) ? 1 : 0, 3);
		this._recoveredType22209910.Method10321();
		this._recoveredType22209910.Method10317(3);
		this._recoveredType22209910.Method10317(~3);
		this._recoveredType22209910.Method10319(1, 2, 3);
		this.Method12669();
	}

	// Token: 0x06001824 RID: 6180 RVA: 0x00054B50 File Offset: 0x00052D50
	public void Method12673(byte[] 1, int 2, int 3, bool 4)
	{
		short[] array = this._recoveredType23179911.int16Array2;
		int num = 256;
		array[num] += 1;
		this._recoveredType23179911.Method12664();
		this._recoveredType23179912.Method12664();
		this._recoveredType23179911.Method12666(this._recoveredType23179913);
		this._recoveredType23179912.Method12666(this._recoveredType23179913);
		this._recoveredType23179913.Method12664();
		int num2 = 4;
		for (int i = 18; i > num2; i--)
		{
			if (this._recoveredType23179913.byteArray2[772.numberArray2[i]] > 0)
			{
				num2 = i + 1;
			}
		}
		int num3 = 14 + num2 * 3 + this._recoveredType23179913.Method12665() + this._recoveredType23179911.Method12665() + this._recoveredType23179912.Method12665() + this.number5;
		int num4 = this.number5;
		for (int j = 0; j < 286; j++)
		{
			num4 += (int)(this._recoveredType23179911.int16Array2[j] * (short)772.byteArray3[j]);
		}
		for (int k = 0; k < 30; k++)
		{
			num4 += (int)(this._recoveredType23179912.int16Array2[k] * (short)772.byteArray4[k]);
		}
		if (num3 >= num4)
		{
			num3 = num4;
		}
		if (2 >= 0 && 3 + 4 < num3 >> 3)
		{
			this.Method12672(1, 2, 3, 4);
			return;
		}
		if (num3 == num4)
		{
			this._recoveredType22209910.Method10322(2 + ((4 > false) ? 1 : 0), 3);
			this._recoveredType23179911.Method12662(772.int16Array2, 772.byteArray3);
			this._recoveredType23179912.Method12662(772.int16Array3, 772.byteArray4);
			this.Method12671();
			this.Method12669();
			return;
		}
		this._recoveredType22209910.Method10322(4 + ((4 > false) ? 1 : 0), 3);
		this.Method12670(num2);
		this.Method12671();
		this.Method12669();
	}

	// Token: 0x06001825 RID: 6181 RVA: 0x00054D08 File Offset: 0x00052F08
	public bool Method12674()
	{
		return this.number4 >= 16384;
	}

	// Token: 0x06001826 RID: 6182 RVA: 0x00054D1C File Offset: 0x00052F1C
	public bool Method12675(int 1)
	{
		this.int16Array4[this.number4] = 0;
		byte[] array = this.byteArray5;
		int num = this.number4;
		this.number4 = num + 1;
		array[num] = (byte)1;
		short[] array2 = this._recoveredType23179911.int16Array2;
		array2[1] += 1;
		return this.Method12674();
	}

	// Token: 0x06001827 RID: 6183 RVA: 0x00054D70 File Offset: 0x00052F70
	public bool Method12676(int 1, int 2)
	{
		this.int16Array4[this.number4] = (short)1;
		byte[] array = this.byteArray5;
		int num = this.number4;
		this.number4 = num + 1;
		array[num] = (byte)(2 - 3);
		int num2 = 772.Method12678(2 - 3);
		short[] array2 = this._recoveredType23179911.int16Array2;
		int num3 = num2;
		array2[num3] += 1;
		if (num2 >= 265 && num2 < 285)
		{
			this.number5 += (num2 - 261) / 4;
		}
		int num4 = 772.Method12679(1 - 1);
		short[] array3 = this._recoveredType23179912.int16Array2;
		int num5 = num4;
		array3[num5] += 1;
		if (num4 >= 4)
		{
			this.number5 += num4 / 2 - 1;
		}
		return this.Method12674();
	}

	// Token: 0x06001828 RID: 6184 RVA: 0x00054E2A File Offset: 0x0005302A
	public static short Method12677(int 1)
	{
		return (short)((int)772.byteArray2[1 & 15] << 12 | (int)772.byteArray2[1 >> 4 & 15] << 8 | (int)772.byteArray2[1 >> 8 & 15] << 4 | (int)772.byteArray2[1 >> 12]);
	}

	// Token: 0x06001829 RID: 6185 RVA: 0x00054E64 File Offset: 0x00053064
	private static int Method12678(int 1)
	{
		if (1 == 255)
		{
			return 285;
		}
		int num = 257;
		while (1 >= 8)
		{
			num += 4;
			1 >>= 1;
		}
		return num + 1;
	}

	// Token: 0x0600182A RID: 6186 RVA: 0x00054E98 File Offset: 0x00053098
	private static int Method12679(int 1)
	{
		int num = 0;
		while (1 >= 4)
		{
			num += 2;
			1 >>= 1;
		}
		return num + 1;
	}

	// Token: 0x04000B41 RID: 2881
	private static readonly int[] numberArray2 = new int[]
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

	// Token: 0x04000B42 RID: 2882
	private static readonly byte[] byteArray2 = new byte[]
	{
		0,
		8,
		4,
		12,
		2,
		10,
		6,
		14,
		1,
		9,
		5,
		13,
		3,
		11,
		7,
		15
	};

	// Token: 0x04000B43 RID: 2883
	private static short[] int16Array2 = new short[286];

	// Token: 0x04000B44 RID: 2884
	private static byte[] byteArray3 = new byte[286];

	// Token: 0x04000B45 RID: 2885
	private static short[] int16Array3;

	// Token: 0x04000B46 RID: 2886
	private static byte[] byteArray4;

	// Token: 0x04000B47 RID: 2887
	public 760 _recoveredType22209910;

	// Token: 0x04000B48 RID: 2888
	private 772.773 _recoveredType23179911;

	// Token: 0x04000B49 RID: 2889
	private 772.773 _recoveredType23179912;

	// Token: 0x04000B4A RID: 2890
	private 772.773 _recoveredType23179913;

	// Token: 0x04000B4B RID: 2891
	private short[] int16Array4;

	// Token: 0x04000B4C RID: 2892
	private byte[] byteArray5;

	// Token: 0x04000B4D RID: 2893
	private int number4;

	// Token: 0x04000B4E RID: 2894
	private int number5;

	// Token: 0x02000322 RID: 802
	public sealed class 773
	{
		// Token: 0x0600182B RID: 6187 RVA: 0x00054EB9 File Offset: 0x000530B9
		public 773(772 1, int 2, int 3, int 4)
		{
			this._recoveredType23169903 = 1;
			this.number4 = 3;
			this.number6 = 4;
			this.int16Array2 = new short[2];
			this.numberArray2 = new int[4];
		}

		// Token: 0x0600182C RID: 6188 RVA: 0x00054EF0 File Offset: 0x000530F0
		public void Method12659()
		{
			for (int i = 0; i < this.int16Array2.Length; i++)
			{
				this.int16Array2[i] = 0;
			}
			this.int16Array3 = null;
			this.byteArray2 = null;
		}

		// Token: 0x0600182D RID: 6189 RVA: 0x00054F27 File Offset: 0x00053127
		public void Method12660(int 1)
		{
			this._recoveredType23169903._recoveredType22209910.Method10322((int)this.int16Array3[1] & 65535, (int)this.byteArray2[1]);
		}

		// Token: 0x0600182E RID: 6190 RVA: 0x00054F50 File Offset: 0x00053150
		public void Method12661()
		{
			bool flag = true;
			for (int i = 0; i < this.int16Array2.Length; i++)
			{
				if (this.int16Array2[i] != 0)
				{
					flag = false;
				}
			}
			if (!flag)
			{
				throw new 657("!Empty");
			}
		}

		// Token: 0x0600182F RID: 6191 RVA: 0x00054F8C File Offset: 0x0005318C
		public void Method12662(short[] 1, byte[] 2)
		{
			this.int16Array3 = 1;
			this.byteArray2 = 2;
		}

		// Token: 0x06001830 RID: 6192 RVA: 0x00054F9C File Offset: 0x0005319C
		public void Method12663()
		{
			long num = (long)this.int16Array2.Length;
			int[] array = new int[this.number6];
			int num2 = 0;
			this.int16Array3 = new short[this.int16Array2.Length];
			for (int i = 0; i < this.number6; i++)
			{
				array[i] = num2;
				num2 += this.numberArray2[i] << 15 - i;
			}
			for (int j = 0; j < this.number5; j++)
			{
				int num3 = (int)this.byteArray2[j];
				if (num3 > 0)
				{
					this.int16Array3[j] = 772.Method12677(array[num3 - 1]);
					array[num3 - 1] += 1 << 16 - num3;
				}
			}
		}

		// Token: 0x06001831 RID: 6193 RVA: 0x00055048 File Offset: 0x00053248
		public void Method12664()
		{
			int num = this.int16Array2.Length;
			int[] array = new int[num];
			int i = 0;
			int num2 = 0;
			for (int j = 0; j < num; j++)
			{
				int num3 = (int)this.int16Array2[j];
				if (num3 != 0)
				{
					int num4 = i++;
					int num5;
					while (num4 > 0 && (int)this.int16Array2[array[num5 = (num4 - 1) / 2]] > num3)
					{
						array[num4] = array[num5];
						num4 = num5;
					}
					array[num4] = j;
					num2 = j;
				}
			}
			while (i < 2)
			{
				int num6 = (num2 < 2) ? (++num2) : 0;
				array[i++] = num6;
			}
			this.number5 = Math.Max(num2 + 1, this.number4);
			int num7 = i;
			int[] array2 = new int[4 * i - 2];
			int[] array3 = new int[2 * i - 1];
			int num8 = num7;
			for (int k = 0; k < i; k++)
			{
				int num9 = array2[2 * k] = array[k];
				array2[2 * k + 1] = -1;
				array3[k] = (int)this.int16Array2[num9] << 8;
				array[k] = k;
			}
			do
			{
				int num10 = array[0];
				int num11 = array[--i];
				int num12 = 0;
				int l;
				for (l = 1; l < i; l = l * 2 + 1)
				{
					if (l + 1 < i && array3[array[l]] > array3[array[l + 1]])
					{
						l++;
					}
					array[num12] = array[l];
					num12 = l;
				}
				int num13 = array3[num11];
				while ((l = num12) > 0 && array3[array[num12 = (l - 1) / 2]] > num13)
				{
					array[l] = array[num12];
				}
				array[l] = num11;
				int num14 = array[0];
				num11 = num8++;
				array2[2 * num11] = num10;
				array2[2 * num11 + 1] = num14;
				int num15 = Math.Min(array3[num10] & 255, array3[num14] & 255);
				num13 = (array3[num11] = array3[num10] + array3[num14] - num15 + 1);
				num12 = 0;
				for (l = 1; l < i; l = num12 * 2 + 1)
				{
					if (l + 1 < i && array3[array[l]] > array3[array[l + 1]])
					{
						l++;
					}
					array[num12] = array[l];
					num12 = l;
				}
				while ((l = num12) > 0 && array3[array[num12 = (l - 1) / 2]] > num13)
				{
					array[l] = array[num12];
				}
				array[l] = num11;
			}
			while (i > 1);
			if (array[0] != array2.Length / 2 - 1)
			{
				throw new 657("Heap invariant violated");
			}
			this.Method12668(array2);
		}

		// Token: 0x06001832 RID: 6194 RVA: 0x000552BC File Offset: 0x000534BC
		public int Method12665()
		{
			int num = 0;
			for (int i = 0; i < this.int16Array2.Length; i++)
			{
				num += (int)(this.int16Array2[i] * (short)this.byteArray2[i]);
			}
			return num;
		}

		// Token: 0x06001833 RID: 6195 RVA: 0x000552F4 File Offset: 0x000534F4
		public void Method12666(772.773 1)
		{
			int num = -1;
			int i = 0;
			while (i < this.number5)
			{
				int num2 = 1;
				int num3 = (int)this.byteArray2[i];
				int num4;
				int num5;
				if (num3 == 0)
				{
					num4 = 138;
					num5 = 3;
				}
				else
				{
					num4 = 6;
					num5 = 3;
					if (num != num3)
					{
						short[] array = 1.int16Array2;
						int num6 = num3;
						array[num6] += 1;
						num2 = 0;
					}
				}
				num = num3;
				i++;
				while (i < this.number5 && num == (int)this.byteArray2[i])
				{
					i++;
					if (++num2 >= num4)
					{
						break;
					}
				}
				if (num2 < num5)
				{
					short[] array2 = 1.int16Array2;
					int num7 = num;
					array2[num7] += (short)num2;
				}
				else if (num != 0)
				{
					short[] array3 = 1.int16Array2;
					int num8 = 16;
					array3[num8] += 1;
				}
				else if (num2 <= 10)
				{
					short[] array4 = 1.int16Array2;
					int num9 = 17;
					array4[num9] += 1;
				}
				else
				{
					short[] array5 = 1.int16Array2;
					int num10 = 18;
					array5[num10] += 1;
				}
			}
		}

		// Token: 0x06001834 RID: 6196 RVA: 0x000553D8 File Offset: 0x000535D8
		public void Method12667(772.773 1)
		{
			int num = -1;
			int i = 0;
			while (i < this.number5)
			{
				int num2 = 1;
				int num3 = (int)this.byteArray2[i];
				int num4;
				int num5;
				if (num3 == 0)
				{
					num4 = 138;
					num5 = 3;
				}
				else
				{
					num4 = 6;
					num5 = 3;
					if (num != num3)
					{
						1.Method12660(num3);
						num2 = 0;
					}
				}
				num = num3;
				i++;
				while (i < this.number5 && num == (int)this.byteArray2[i])
				{
					i++;
					if (++num2 >= num4)
					{
						break;
					}
				}
				if (num2 < num5)
				{
					while (num2-- > 0)
					{
						1.Method12660(num);
					}
				}
				else if (num != 0)
				{
					1.Method12660(16);
					this._recoveredType23169903._recoveredType22209910.Method10322(num2 - 3, 2);
				}
				else if (num2 <= 10)
				{
					1.Method12660(17);
					this._recoveredType23169903._recoveredType22209910.Method10322(num2 - 3, 3);
				}
				else
				{
					1.Method12660(18);
					this._recoveredType23169903._recoveredType22209910.Method10322(num2 - 11, 7);
				}
			}
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x000554CC File Offset: 0x000536CC
		private void Method12668(int[] 1)
		{
			this.byteArray2 = new byte[this.int16Array2.Length];
			int num = 1.Length / 2;
			int num2 = (num + 1) / 2;
			int num3 = 0;
			for (int i = 0; i < this.number6; i++)
			{
				this.numberArray2[i] = 0;
			}
			int[] array = new int[num];
			array[num - 1] = 0;
			for (int j = num - 1; j >= 0; j--)
			{
				if (1[2 * j + 1] != -1)
				{
					int num4 = array[j] + 1;
					if (num4 > this.number6)
					{
						num4 = this.number6;
						num3++;
					}
					array[1[2 * j]] = (array[1[2 * j + 1]] = num4);
				}
				else
				{
					int num5 = array[j];
					this.numberArray2[num5 - 1]++;
					this.byteArray2[1[2 * j]] = (byte)array[j];
				}
			}
			if (num3 == 0)
			{
				return;
			}
			int num6 = this.number6 - 1;
			for (;;)
			{
				if (this.numberArray2[--num6] != 0)
				{
					do
					{
						this.numberArray2[num6]--;
						this.numberArray2[++num6]++;
						num3 -= 1 << this.number6 - 1 - num6;
					}
					while (num3 > 0 && num6 < this.number6 - 1);
					if (num3 <= 0)
					{
						break;
					}
				}
			}
			this.numberArray2[this.number6 - 1] += num3;
			this.numberArray2[this.number6 - 2] -= num3;
			int num7 = 2 * num2;
			for (int num8 = this.number6; num8 != 0; num8--)
			{
				int k = this.numberArray2[num8 - 1];
				while (k > 0)
				{
					int num9 = 2 * 1[num7++];
					if (1[num9 + 1] == -1)
					{
						this.byteArray2[1[num9]] = (byte)num8;
						k--;
					}
				}
			}
		}

		// Token: 0x04000B4F RID: 2895
		public short[] int16Array2;

		// Token: 0x04000B50 RID: 2896
		public byte[] byteArray2;

		// Token: 0x04000B51 RID: 2897
		public int number4;

		// Token: 0x04000B52 RID: 2898
		public int number5;

		// Token: 0x04000B53 RID: 2899
		private short[] int16Array3;

		// Token: 0x04000B54 RID: 2900
		private int[] numberArray2;

		// Token: 0x04000B55 RID: 2901
		private int number6;

		// Token: 0x04000B56 RID: 2902
		private 772 _recoveredType23169903;
	}
}
