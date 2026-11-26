using System;

// Token: 0x0200083A RID: 2106
internal struct 1937 : IEquatable<1937>
{
	// Token: 0x06003D29 RID: 15657 RVA: 0x00181F3F File Offset: 0x0018013F
	public 1937(int 1, int 2)
	{
		this.1 = Math.Min(1, 2);
		this.2 = Math.Max(1, 2);
	}

	// Token: 0x06003D2A RID: 15658 RVA: 0x00181F5B File Offset: 0x0018015B
	public bool Equals(1937 1)
	{
		return this.1 == 1.1 && this.2 == 1.2;
	}

	// Token: 0x06003D2B RID: 15659 RVA: 0x00181F7C File Offset: 0x0018017C
	public override bool Equals(object 1)
	{
		if (1 is 1937)
		{
			1937 2 = (1937)1;
			return this.Equals(2);
		}
		return false;
	}

	// Token: 0x06003D2C RID: 15660 RVA: 0x00181FA1 File Offset: 0x001801A1
	public override int GetHashCode()
	{
		return this.1 * 397 ^ this.2;
	}

	// Token: 0x04002D12 RID: 11538
	public readonly int 1;

	// Token: 0x04002D13 RID: 11539
	public readonly int 2;
}
