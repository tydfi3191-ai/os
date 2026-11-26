using System;
using System.Runtime.InteropServices;

// Token: 0x02000311 RID: 785
[ComVisible(false)]
public sealed class 701
{
	// Token: 0x06001789 RID: 6025 RVA: 0x000511E4 File Offset: 0x0004F3E4
	public void Method10821(int 1)
	{
		int num = this.number5;
		this.number5 = num + 1;
		if (num == 32768)
		{
			throw new InvalidOperationException("Window full");
		}
		byte[] array = this.byteArray2;
		num = this.number4;
		this.number4 = num + 1;
		array[num] = (byte)1;
		this.number4 &= 32767;
	}

	// Token: 0x0600178A RID: 6026 RVA: 0x00051240 File Offset: 0x0004F440
	private void Method10822(int 1, int 2, int 3)
	{
		while (2-- > 0)
		{
			byte[] array = this.byteArray2;
			int num = this.number4;
			this.number4 = num + 1;
			array[num] = this.byteArray2[1++];
			this.number4 &= 32767;
			1 &= 32767;
		}
	}

	// Token: 0x0600178B RID: 6027 RVA: 0x00051298 File Offset: 0x0004F498
	public void Method10823(int 1, int 2)
	{
		if ((this.number5 += 1) > 32768)
		{
			throw new InvalidOperationException("Window full");
		}
		int num = this.number4 - 2 & 32767;
		int num2 = 32768 - 1;
		if (num > num2 || this.number4 >= num2)
		{
			this.Method10822(num, 1, 2);
			return;
		}
		if (1 <= 2)
		{
			Array.Copy(this.byteArray2, num, this.byteArray2, this.number4, 1);
			this.number4 += 1;
			return;
		}
		while (1-- > 0)
		{
			byte[] array = this.byteArray2;
			int num3 = this.number4;
			this.number4 = num3 + 1;
			array[num3] = this.byteArray2[num++];
		}
	}

	// Token: 0x0600178C RID: 6028 RVA: 0x00051350 File Offset: 0x0004F550
	public int Method10824(769 1, int 2)
	{
		2 = Math.Min(Math.Min(2, 32768 - this.number5), 1.Method12422());
		int num = 32768 - this.number4;
		int num2;
		if (2 > num)
		{
			num2 = 1.Method12425(this.byteArray2, this.number4, num);
			if (num2 == num)
			{
				num2 += 1.Method12425(this.byteArray2, 0, 2 - num);
			}
		}
		else
		{
			num2 = 1.Method12425(this.byteArray2, this.number4, 2);
		}
		this.number4 = (this.number4 + num2 & 32767);
		this.number5 += num2;
		return num2;
	}

	// Token: 0x0600178D RID: 6029 RVA: 0x000513F4 File Offset: 0x0004F5F4
	public void Method10825(byte[] 1, int 2, int 3)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=zipNqWeg=");
		}
		if (this.number5 > 0)
		{
			throw new InvalidOperationException();
		}
		if (3 > 32768)
		{
			2 += 3 - 32768;
			3 = 32768;
		}
		Array.Copy(1, 2, this.byteArray2, 0, 3);
		this.number4 = (3 & 32767);
	}

	// Token: 0x0600178E RID: 6030 RVA: 0x00051454 File Offset: 0x0004F654
	public int Method10826()
	{
		return 32768 - this.number5;
	}

	// Token: 0x0600178F RID: 6031 RVA: 0x00051462 File Offset: 0x0004F662
	public int GetNumber8410_10827()
	{
		return this.number5;
	}

	// Token: 0x06001790 RID: 6032 RVA: 0x0005146C File Offset: 0x0004F66C
	public int Method10828(byte[] 1, int 2, int 3)
	{
		int num = this.number4;
		if (3 > this.number5)
		{
			3 = this.number5;
		}
		else
		{
			num = (this.number4 - this.number5 + 3 & 32767);
		}
		int num2 = 3;
		int num3 = 3 - num;
		if (num3 > 0)
		{
			Array.Copy(this.byteArray2, 32768 - num3, 1, 2, num3);
			2 += num3;
			3 = num;
		}
		Array.Copy(this.byteArray2, num - 3, 1, 2, 3);
		this.number5 -= num2;
		if (this.number5 < 0)
		{
			throw new InvalidOperationException();
		}
		return num2;
	}

	// Token: 0x06001791 RID: 6033 RVA: 0x00051500 File Offset: 0x0004F700
	public void SetNumber8410_10829()
	{
		this.number5 = (this.number4 = 0);
	}

	// Token: 0x04000AF8 RID: 2808
	private byte[] byteArray2 = new byte[32768];

	// Token: 0x04000AF9 RID: 2809
	private int number4;

	// Token: 0x04000AFA RID: 2810
	private int number5;
}
