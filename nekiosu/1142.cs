using System;

// Token: 0x02000C06 RID: 3078
public struct 1142
{
	// Token: 0x060053CD RID: 21453 RVA: 0x0020B749 File Offset: 0x00209949
	internal 1142(int 1, int 2, int 3, int 4)
	{
		this = new 1142((short)1, (short)2, (short)3, (short)4);
	}

	// Token: 0x060053CE RID: 21454 RVA: 0x0020B75A File Offset: 0x0020995A
	internal 1142(short 1, short 2, short 3, short 4)
	{
		this.1 = 2;
		this.2 = 1;
		this.3 = 2 + 4;
		this.4 = 1 + 3;
	}

	// Token: 0x060053CF RID: 21455 RVA: 0x0020B77F File Offset: 0x0020997F
	internal short 1()
	{
		return this.2;
	}

	// Token: 0x060053D0 RID: 21456 RVA: 0x0020B787 File Offset: 0x00209987
	internal short 2()
	{
		return this.1;
	}

	// Token: 0x060053D1 RID: 21457 RVA: 0x0020B78F File Offset: 0x0020998F
	internal short 3()
	{
		return this.4 - this.2;
	}

	// Token: 0x060053D2 RID: 21458 RVA: 0x0020B79F File Offset: 0x0020999F
	internal short 4()
	{
		return this.3 - this.1;
	}

	// Token: 0x060053D3 RID: 21459 RVA: 0x0020B7B0 File Offset: 0x002099B0
	public override string ToString()
	{
		return string.Format("Rect: [{0}, {1}, {2}, {3}]", new object[]
		{
			this.1(),
			this.2(),
			this.3(),
			this.4()
		});
	}

	// Token: 0x04003F92 RID: 16274
	private short 1;

	// Token: 0x04003F93 RID: 16275
	private short 2;

	// Token: 0x04003F94 RID: 16276
	private short 3;

	// Token: 0x04003F95 RID: 16277
	private short 4;
}
