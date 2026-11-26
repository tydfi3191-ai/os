using System;

// Token: 0x02000021 RID: 33
public struct 297
{
	// Token: 0x060000B4 RID: 180 RVA: 0x000058FA File Offset: 0x00003AFA
	public 297(int 1, byte 2)
	{
		this.number2 = 0;
		this.byteValue2 = 0;
		this.SetNumber0091_245(1);
		this.byteValue2 = 2;
	}

	// Token: 0x060000B5 RID: 181 RVA: 0x00005918 File Offset: 0x00003B18
	public int GetNumber0091_244()
	{
		return this.number2;
	}

	// Token: 0x060000B6 RID: 182 RVA: 0x00005920 File Offset: 0x00003B20
	public void SetNumber0091_245(int 1)
	{
		this.number2 = 1;
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x00005929 File Offset: 0x00003B29
	public byte GetByte0092_246()
	{
		return this.byteValue2;
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x00005934 File Offset: 0x00003B34
	public override bool Equals(object 1)
	{
		if (1 is 297)
		{
			297 2 = (297)1;
			return this.Method0247(2);
		}
		return false;
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x00005959 File Offset: 0x00003B59
	public bool Method0247(297 1)
	{
		return 1.GetNumber0091_244() == this.GetNumber0091_244();
	}

	// Token: 0x060000BA RID: 186 RVA: 0x0000596A File Offset: 0x00003B6A
	public static bool operator ==(297 1, 297 2)
	{
		return 1.Method0247(2);
	}

	// Token: 0x060000BB RID: 187 RVA: 0x00005974 File Offset: 0x00003B74
	public static bool operator !=(297 1, 297 2)
	{
		return !(1 == 2);
	}

	// Token: 0x060000BC RID: 188 RVA: 0x00005980 File Offset: 0x00003B80
	public override int GetHashCode()
	{
		return this.GetNumber0091_244().GetHashCode();
	}

	// Token: 0x060000BD RID: 189 RVA: 0x0000599C File Offset: 0x00003B9C
	public override string ToString()
	{
		return this.GetNumber0091_244().ToString();
	}

	// Token: 0x04000055 RID: 85
	private int number2;

	// Token: 0x04000056 RID: 86
	private readonly byte byteValue2;
}
