using System;

// Token: 0x0200002E RID: 46
public sealed class 322
{
	// Token: 0x06000101 RID: 257 RVA: 0x00006198 File Offset: 0x00004398
	public void Method0700(bool 1, 289 2)
	{
		this._recoveredType00210213 = 2;
		this.number3 = this._recoveredType00210213.GetRecoveredType01460030_115().Method0812();
		this.SetNumber0215_702(322.Method0705(this.number3, 1));
		this.SetNumber0216_704(322.Method0706(this.number3, 1));
	}

	// Token: 0x06000102 RID: 258 RVA: 0x000061E6 File Offset: 0x000043E6
	public int GetNumber0215_701()
	{
		return this.number4;
	}

	// Token: 0x06000103 RID: 259 RVA: 0x000061EE File Offset: 0x000043EE
	private void SetNumber0215_702(int 1)
	{
		this.number4 = 1;
	}

	// Token: 0x06000104 RID: 260 RVA: 0x000061F7 File Offset: 0x000043F7
	public int GetNumber0216_703()
	{
		return this.number5;
	}

	// Token: 0x06000105 RID: 261 RVA: 0x000061FF File Offset: 0x000043FF
	private void SetNumber0216_704(int 1)
	{
		this.number5 = 1;
	}

	// Token: 0x06000106 RID: 262 RVA: 0x00006208 File Offset: 0x00004408
	private static int Method0705(int 1, bool 2)
	{
		if (!2)
		{
			return (1 + 7) / 8;
		}
		return (1 - 1) / 8;
	}

	// Token: 0x06000107 RID: 263 RVA: 0x00006218 File Offset: 0x00004418
	private static int Method0706(int 1, bool 2)
	{
		if (!2)
		{
			return (1 - 1) / 8;
		}
		return (1 + 7) / 8;
	}

	// Token: 0x06000108 RID: 264 RVA: 0x00006228 File Offset: 0x00004428
	public 330 Method0707(byte[] 1, int 2, int 3)
	{
		return new 330(1, 1, 2, 3);
	}

	// Token: 0x06000109 RID: 265 RVA: 0x00006234 File Offset: 0x00004434
	public int Method0708(330 1, byte[] 2, int 3)
	{
		int num = this.GetNumber0216_703() - 1.Method0835();
		Array.Clear(2, 3, num);
		3 += num;
		1.Method0836(2, 3);
		return this.GetNumber0216_703();
	}

	// Token: 0x0600010A RID: 266 RVA: 0x0000626B File Offset: 0x0000446B
	public 330 Method0709(330 1)
	{
		return 1.Method0819(this._recoveredType00210213.GetRecoveredType01460031_116(), this._recoveredType00210213.GetRecoveredType01460030_115());
	}

	// Token: 0x0400006D RID: 109
	private 289 _recoveredType00210213;

	// Token: 0x0400006E RID: 110
	private int number3;

	// Token: 0x0400006F RID: 111
	private int number4;

	// Token: 0x04000070 RID: 112
	private int number5;
}
