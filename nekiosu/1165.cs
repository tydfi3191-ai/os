using System;

// Token: 0x02000C1D RID: 3101
public class 1165
{
	// Token: 0x0600542A RID: 21546 RVA: 0x0020BB6F File Offset: 0x00209D6F
	public 1165(string 1)
	{
		this.1 = 1;
	}

	// Token: 0x0600542B RID: 21547 RVA: 0x0020BB7E File Offset: 0x00209D7E
	public static implicit operator 1165(string 1)
	{
		return new 1165(1);
	}

	// Token: 0x0600542C RID: 21548 RVA: 0x0020BB86 File Offset: 0x00209D86
	public override string ToString()
	{
		return this.1;
	}

	// Token: 0x04004043 RID: 16451
	private readonly string 1;
}
