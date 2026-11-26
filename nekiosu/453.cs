using System;

// Token: 0x02000131 RID: 305
[242(2)]
[241(0)]
public struct 453
{
	// Token: 0x06000ABF RID: 2751 RVA: 0x00028D14 File Offset: 0x00026F14
	public 453(690<char> 1, int 2)
	{
		this = new 453(669.Method9987(1, 2));
	}

	// Token: 0x06000AC0 RID: 2752 RVA: 0x00028D23 File Offset: 0x00026F23
	[242(1)]
	private 453(char[] 1)
	{
		this.charArray2 = 1;
		this.number3 = 0;
	}

	// Token: 0x06000AC1 RID: 2753 RVA: 0x00028D33 File Offset: 0x00026F33
	public int GetNumber3143_4041()
	{
		return this.number3;
	}

	// Token: 0x06000AC2 RID: 2754 RVA: 0x00028D3B File Offset: 0x00026F3B
	public void SetNumber3143_4042(int 1)
	{
		this.number3 = 1;
	}

	// Token: 0x06000AC3 RID: 2755 RVA: 0x00028D44 File Offset: 0x00026F44
	public bool Method4043()
	{
		return this.charArray2 == null;
	}

	// Token: 0x06000AC4 RID: 2756 RVA: 0x00028D50 File Offset: 0x00026F50
	public void Method4044(690<char> 1, char 2)
	{
		if (this.number3 == this.charArray2.Length)
		{
			this.Method4047(1, 1);
		}
		char[] array = this.charArray2;
		int num = this.number3;
		this.number3 = num + 1;
		array[num] = 2;
	}

	// Token: 0x06000AC5 RID: 2757 RVA: 0x00028D90 File Offset: 0x00026F90
	[242(1)]
	public void Method4044([241(2)] 690<char> 1, char[] 2, int 3, int 4)
	{
		if (this.number3 + 4 >= this.charArray2.Length)
		{
			this.Method4047(1, 4);
		}
		Array.Copy(2, 3, this.charArray2, this.number3, 4);
		this.number3 += 4;
	}

	// Token: 0x06000AC6 RID: 2758 RVA: 0x00028DDD File Offset: 0x00026FDD
	public void Method4046(690<char> 1)
	{
		if (this.charArray2 != null)
		{
			669.Method9988(1, this.charArray2);
			this.charArray2 = null;
		}
		this.number3 = 0;
	}

	// Token: 0x06000AC7 RID: 2759 RVA: 0x00028E04 File Offset: 0x00027004
	private void Method4047(690<char> 1, int 2)
	{
		char[] destinationArray = 669.Method9987(1, (this.number3 + 2) * 2);
		if (this.charArray2 != null)
		{
			Array.Copy(this.charArray2, destinationArray, this.number3);
			669.Method9988(1, this.charArray2);
		}
		this.charArray2 = destinationArray;
	}

	// Token: 0x06000AC8 RID: 2760 RVA: 0x00028E4F File Offset: 0x0002704F
	[242(1)]
	public override string ToString()
	{
		return this.Method4048(0, this.number3);
	}

	// Token: 0x06000AC9 RID: 2761 RVA: 0x00028E5E File Offset: 0x0002705E
	[242(1)]
	public string Method4048(int 1, int 2)
	{
		return new string(this.charArray2, 1, 2);
	}

	// Token: 0x06000ACA RID: 2762 RVA: 0x00028E6D File Offset: 0x0002706D
	public char[] GetCharArray3142_4049()
	{
		return this.charArray2;
	}

	// Token: 0x0400054E RID: 1358
	private char[] charArray2;

	// Token: 0x0400054F RID: 1359
	private int number3;
}
