using System;
using System.Runtime.InteropServices;
using System.Security;

// Token: 0x02000016 RID: 22
[SuppressUnmanagedCodeSecurity]
[ComVisible(false)]
public sealed class 598 : IDisposable
{
	// Token: 0x06000055 RID: 85 RVA: 0x00003154 File Offset: 0x00001354
	public 598()
	{
		this.number5 = 352800;
		this.number4 = 2;
		this.number9 = 44100;
		this.number7 = 2;
		this.number8 = 1;
		this.numberArray = new int[1];
		this.Method8146();
	}

	// Token: 0x06000056 RID: 86 RVA: 0x000031A4 File Offset: 0x000013A4
	public 598(float 1, int 2, int 3, int 4)
	{
		this.number5 = 352800;
		this.number4 = 2;
		this.number9 = 44100;
		this.number7 = 2;
		this.number8 = 1;
		this.numberArray = new int[1];
		if (1 <= 0f)
		{
			1 = 2f;
		}
		this.number9 = 2;
		if (this.number9 <= 0)
		{
			this.number9 = 44100;
		}
		this.number7 = 3;
		if (this.number7 <= 0)
		{
			this.number7 = 2;
		}
		this.number4 = 4;
		if (this.number4 > 4)
		{
			int num = this.number4;
			if (num != 8)
			{
				if (num != 32)
				{
					this.number4 = 2;
				}
				else
				{
					this.number4 = 4;
				}
			}
			else
			{
				this.number4 = 1;
			}
		}
		if (this.number4 <= 0 || this.number4 == 3)
		{
			this.number4 = 2;
		}
		this.number5 = (int)Math.Ceiling((double)(1 * (float)this.number9 * (float)this.number7 * (float)this.number4));
		if (this.number5 % this.number4 > 0)
		{
			this.number5 -= this.number5 % this.number4;
		}
		this.Method8146();
	}

	// Token: 0x06000057 RID: 87 RVA: 0x000032D8 File Offset: 0x000014D8
	public void Method8143()
	{
		byte[] obj = this.byteArray2;
		lock (obj)
		{
			Array.Clear(this.byteArray2, 0, this.number5);
			this.number6 = 0;
			for (int i = 0; i < this.number8; i++)
			{
				this.numberArray[i] = 0;
			}
		}
	}

	// Token: 0x06000058 RID: 88 RVA: 0x00003348 File Offset: 0x00001548
	public int Method8144(int 1)
	{
		int num = -1;
		byte[] obj = this.byteArray2;
		lock (obj)
		{
			if (1 < 0 || 1 >= this.number8)
			{
				for (int i = 0; i < this.number8; i++)
				{
					int num2 = this.number6 - this.numberArray[i];
					if (num2 < 0)
					{
						num2 += this.number5;
					}
					if (num2 > num)
					{
						num = num2;
					}
				}
				return num;
			}
			num = this.number6 - this.numberArray[1];
			if (num < 0)
			{
				num += this.number5;
			}
		}
		return num;
	}

	// Token: 0x06000059 RID: 89 RVA: 0x000033F4 File Offset: 0x000015F4
	public void Dispose()
	{
		this.SetFlag6366_8145(true);
		GC.SuppressFinalize(this);
	}

	// Token: 0x0600005A RID: 90 RVA: 0x00003403 File Offset: 0x00001603
	private void SetFlag6366_8145(bool 1)
	{
		this.flag2 = true;
	}

	// Token: 0x0600005B RID: 91 RVA: 0x0000340C File Offset: 0x0000160C
	~598()
	{
		this.SetFlag6366_8145(false);
	}

	// Token: 0x0600005C RID: 92 RVA: 0x0000343C File Offset: 0x0000163C
	private void Method8146()
	{
		this.byteArray2 = new byte[this.number5];
		this.Method8143();
	}

	// Token: 0x0600005D RID: 93 RVA: 0x00003458 File Offset: 0x00001658
	public int Method8147(byte[] 1, int 2, int 3)
	{
		byte[] obj = this.byteArray2;
		int result;
		lock (obj)
		{
			int num = 0;
			if (3 < 0 || 3 >= this.number8)
			{
				3 = 0;
			}
			int num2 = this.number6 - this.numberArray[3];
			if (num2 < 0)
			{
				num2 += this.number5;
			}
			if (2 > num2)
			{
				2 = num2;
			}
			num2 = this.number5 - this.numberArray[3];
			if (2 >= num2)
			{
				Array.Copy(this.byteArray2, num, 1, this.numberArray[3], num2);
				num += num2;
				2 -= num2;
				this.numberArray[3] = 0;
			}
			Array.Copy(this.byteArray2, num, 1, this.numberArray[3], 2);
			this.numberArray[3] += 2;
			result = num + 2;
		}
		return result;
	}

	// Token: 0x0600005E RID: 94 RVA: 0x00003534 File Offset: 0x00001734
	public int Method8147(IntPtr 1, int 2, int 3)
	{
		byte[] obj = this.byteArray2;
		int result;
		lock (obj)
		{
			int num = 0;
			if (3 < 0 || 3 >= this.number8)
			{
				3 = 0;
			}
			int num2 = this.number6 - this.numberArray[3];
			if (num2 < 0)
			{
				num2 += this.number5;
			}
			if (2 > num2)
			{
				2 = num2;
			}
			num2 = this.number5 - this.numberArray[3];
			if (2 >= num2)
			{
				Marshal.Copy(this.byteArray2, this.numberArray[3], 1, num2);
				num += num2;
				1 = new IntPtr(1.ToInt64() + (long)num2);
				2 -= num2;
				this.numberArray[3] = 0;
			}
			Marshal.Copy(this.byteArray2, this.numberArray[3], 1, 2);
			this.numberArray[3] += 2;
			result = num + 2;
		}
		return result;
	}

	// Token: 0x0600005F RID: 95 RVA: 0x00003620 File Offset: 0x00001820
	public void Method8149(float 1)
	{
		if (1 <= 1f)
		{
			return;
		}
		byte[] obj = this.byteArray2;
		lock (obj)
		{
			this.number5 = (int)Math.Ceiling((double)(1 * (float)this.number5));
			if (this.number5 % this.number4 > 0)
			{
				this.number5 -= this.number5 % this.number4;
			}
			byte[] array = new byte[this.number5];
			Array.Clear(array, 0, this.number5);
			Array.Copy(this.byteArray2, array, this.byteArray2.Length);
			this.byteArray2 = array;
		}
	}

	// Token: 0x06000060 RID: 96 RVA: 0x000036D8 File Offset: 0x000018D8
	public int Method8150(int 1)
	{
		int num = this.number5;
		byte[] obj = this.byteArray2;
		lock (obj)
		{
			if (1 < 0 || 1 >= this.number8)
			{
				for (int i = 0; i < this.number8; i++)
				{
					int num2 = this.number5 - (this.number6 - this.numberArray[1]);
					if (num2 > this.number5)
					{
						num2 -= this.number5;
					}
					if (num2 < num)
					{
						num = num2;
					}
				}
				return num;
			}
			num = this.number5 - (this.number6 - this.numberArray[1]);
			if (num > this.number5)
			{
				num -= this.number5;
			}
		}
		return num;
	}

	// Token: 0x06000061 RID: 97 RVA: 0x000037A0 File Offset: 0x000019A0
	public int Method8151(IntPtr 1, int 2)
	{
		byte[] obj = this.byteArray2;
		int result;
		lock (obj)
		{
			if (2 > this.number5)
			{
				2 = this.number5;
			}
			int num = 0;
			int num2 = this.number5 - this.number6;
			if (2 >= num2)
			{
				Marshal.Copy(1, this.byteArray2, this.number6, num2);
				num += num2;
				1 = new IntPtr(1.ToInt64() + (long)num2);
				2 -= num2;
				this.number6 = 0;
			}
			Marshal.Copy(1, this.byteArray2, this.number6, 2);
			num += 2;
			this.number6 += 2;
			result = num;
		}
		return result;
	}

	// Token: 0x06000062 RID: 98 RVA: 0x00003860 File Offset: 0x00001A60
	public int Method8151(byte[] 1, int 2)
	{
		byte[] obj = this.byteArray2;
		int result;
		lock (obj)
		{
			if (2 > this.number5)
			{
				2 = this.number5;
			}
			int num = 0;
			int num2 = this.number5 - this.number6;
			if (2 >= num2)
			{
				Array.Copy(1, num, this.byteArray2, this.number6, num2);
				num += num2;
				2 -= num2;
				this.number6 = 0;
			}
			Array.Copy(1, num, this.byteArray2, this.number6, 2);
			num += 2;
			this.number6 += 2;
			result = num;
		}
		return result;
	}

	// Token: 0x06000063 RID: 99 RVA: 0x00003910 File Offset: 0x00001B10
	public int GetNumber6358_8153()
	{
		return this.number4;
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00003918 File Offset: 0x00001B18
	public int GetNumber6360_8154()
	{
		return this.number5;
	}

	// Token: 0x06000065 RID: 101 RVA: 0x00003920 File Offset: 0x00001B20
	public int GetNumber6363_8155()
	{
		return this.number7;
	}

	// Token: 0x06000066 RID: 102 RVA: 0x00003928 File Offset: 0x00001B28
	public int GetNumber6364_8156()
	{
		return this.number8;
	}

	// Token: 0x06000067 RID: 103 RVA: 0x00003930 File Offset: 0x00001B30
	public void Method8157(int 1)
	{
		if (1 <= 0 || 1 == this.number8)
		{
			return;
		}
		byte[] obj = this.byteArray2;
		lock (obj)
		{
			int[] array = new int[1];
			for (int i = 0; i < this.number8; i++)
			{
				try
				{
					array[i] = this.numberArray[i];
				}
				catch
				{
				}
			}
			this.numberArray = array;
			this.number8 = 1;
		}
	}

	// Token: 0x06000068 RID: 104 RVA: 0x000039BC File Offset: 0x00001BBC
	public int GetNumber6365_8158()
	{
		return this.number9;
	}

	// Token: 0x0400003B RID: 59
	private int number4;

	// Token: 0x0400003C RID: 60
	private byte[] byteArray2;

	// Token: 0x0400003D RID: 61
	private int number5;

	// Token: 0x0400003E RID: 62
	private int[] numberArray;

	// Token: 0x0400003F RID: 63
	private int number6;

	// Token: 0x04000040 RID: 64
	private int number7;

	// Token: 0x04000041 RID: 65
	private int number8;

	// Token: 0x04000042 RID: 66
	private int number9;

	// Token: 0x04000043 RID: 67
	private bool flag2;
}
