using System;

// Token: 0x020004EB RID: 1259
[276]
public sealed class 2553 : IComparable<2553>
{
	// Token: 0x06002688 RID: 9864 RVA: 0x000BD914 File Offset: 0x000BBB14
	internal 2553(int 1, 2484 2, string 3, string 4)
	{
		this.1 = 1;
		this.2 = 2;
		this.3 = 3;
		this.4 = 4;
	}

	// Token: 0x06002689 RID: 9865 RVA: 0x000BD939 File Offset: 0x000BBB39
	internal int 1()
	{
		return 4000 + Math.Min(5000, this.4.Length * 60);
	}

	// Token: 0x0600268A RID: 9866 RVA: 0x000BD959 File Offset: 0x000BBB59
	public int CompareTo(2553 1)
	{
		return this.1.CompareTo(1.1);
	}

	// Token: 0x04001B8C RID: 7052
	internal int 1;

	// Token: 0x04001B8D RID: 7053
	internal 2484 2;

	// Token: 0x04001B8E RID: 7054
	internal string 3;

	// Token: 0x04001B8F RID: 7055
	internal string 4;
}
