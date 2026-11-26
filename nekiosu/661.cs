using System;
using System.Runtime.InteropServices;

// Token: 0x02000308 RID: 776
[ComVisible(false)]
public sealed class 661
{
	// Token: 0x0600174A RID: 5962 RVA: 0x00050238 File Offset: 0x0004E438
	static 661()
	{
		try
		{
			byte[] array = new byte[288];
			int i = 0;
			while (i < 144)
			{
				array[i++] = 8;
			}
			while (i < 256)
			{
				array[i++] = 9;
			}
			while (i < 280)
			{
				array[i++] = 7;
			}
			while (i < 288)
			{
				array[i++] = 8;
			}
			661._recoveredType17547637 = new 661(array);
			array = new byte[32];
			i = 0;
			while (i < 32)
			{
				array[i++] = 5;
			}
			661._recoveredType17547638 = new 661(array);
		}
		catch (Exception)
		{
			throw new 657("InflaterHuffmanTree: static tree length illegal");
		}
	}

	// Token: 0x0600174B RID: 5963 RVA: 0x000502E8 File Offset: 0x0004E4E8
	public 661(byte[] 1)
	{
		this.Method9753(1);
	}

	// Token: 0x0600174C RID: 5964 RVA: 0x000502F8 File Offset: 0x0004E4F8
	private void Method9753(byte[] 1)
	{
		int[] array = new int[16];
		int[] array2 = new int[16];
		foreach (int num in 1)
		{
			if (num > 0)
			{
				array[num]++;
			}
		}
		int num2 = 0;
		int num3 = 512;
		for (int j = 1; j <= 15; j++)
		{
			array2[j] = num2;
			num2 += array[j] << 16 - j;
			if (j >= 10)
			{
				int num4 = array2[j] & 130944;
				int num5 = num2 & 130944;
				num3 += num5 - num4 >> 16 - j;
			}
		}
		this.int16Array = new short[num3];
		int num6 = 512;
		for (int k = 15; k >= 10; k--)
		{
			int num7 = num2 & 130944;
			num2 -= array[k] << 16 - k;
			for (int l = num2 & 130944; l < num7; l += 128)
			{
				this.int16Array[(int)772.Method12677(l)] = (short)(-num6 << 4 | k);
				num6 += 1 << k - 9;
			}
		}
		for (int m = 0; m < 1.Length; m++)
		{
			int num8 = (int)1[m];
			if (num8 != 0)
			{
				num2 = array2[num8];
				int num9 = (int)772.Method12677(num2);
				if (num8 <= 9)
				{
					do
					{
						this.int16Array[num9] = (short)(m << 4 | num8);
						num9 += 1 << num8;
					}
					while (num9 < 512);
				}
				else
				{
					int num10 = (int)this.int16Array[num9 & 511];
					int num11 = 1 << (num10 & 15);
					num10 = -(num10 >> 4);
					do
					{
						this.int16Array[num10 | num9 >> 9] = (short)(m << 4 | num8);
						num9 += 1 << num8;
					}
					while (num9 < num11);
				}
				array2[num8] = num2 + (1 << 16 - num8);
			}
		}
	}

	// Token: 0x0600174D RID: 5965 RVA: 0x000504DC File Offset: 0x0004E6DC
	public int Method9754(769 1)
	{
		int num;
		if ((num = 1.Method12418(9)) >= 0)
		{
			int num2;
			if ((num2 = (int)this.int16Array[num]) >= 0)
			{
				1.Method12419(num2 & 15);
				return num2 >> 4;
			}
			int num3 = -(num2 >> 4);
			int 2 = num2 & 15;
			if ((num = 1.Method12418(2)) >= 0)
			{
				num2 = (int)this.int16Array[num3 | num >> 9];
				1.Method12419(num2 & 15);
				return num2 >> 4;
			}
			int number9699_ = 1.GetNumber9699_12421();
			num = 1.Method12418(number9699_);
			num2 = (int)this.int16Array[num3 | num >> 9];
			if ((num2 & 15) <= number9699_)
			{
				1.Method12419(num2 & 15);
				return num2 >> 4;
			}
			return -1;
		}
		else
		{
			int number9699_2 = 1.GetNumber9699_12421();
			num = 1.Method12418(number9699_2);
			int num2 = (int)this.int16Array[num];
			if (num2 >= 0 && (num2 & 15) <= number9699_2)
			{
				1.Method12419(num2 & 15);
				return num2 >> 4;
			}
			return -1;
		}
	}

	// Token: 0x04000AE4 RID: 2788
	private short[] int16Array;

	// Token: 0x04000AE5 RID: 2789
	public static 661 _recoveredType17547637;

	// Token: 0x04000AE6 RID: 2790
	public static 661 _recoveredType17547638;
}
