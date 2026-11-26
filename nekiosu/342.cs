using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

// Token: 0x02000030 RID: 48
public sealed class 342 : 282
{
	// Token: 0x06000134 RID: 308 RVA: 0x000073A0 File Offset: 0x000055A0
	public 342(bool 1, 289 2)
	{
		this._recoveredType01190604 = new 322();
		this._recoveredType01190604.Method0700(1, 2);
		this.number4 = this._recoveredType01190604.GetNumber0215_701();
		this.number5 = this._recoveredType01190604.GetNumber0216_703();
	}

	// Token: 0x06000135 RID: 309 RVA: 0x000073F0 File Offset: 0x000055F0
	public int TransformBlock(byte[] 1, int 2, int 3, byte[] 4, int 5, RandomNumberGenerator 6)
	{
		330 7 = this._recoveredType01190604.Method0707(1, 2, 3);
		330 8 = this._recoveredType01190604.Method0709(7);
		return this._recoveredType01190604.Method0708(8, 4, 5);
	}

	// Token: 0x06000136 RID: 310 RVA: 0x00007429 File Offset: 0x00005629
	[CompilerGenerated]
	public int GetInputBlockSize()
	{
		return this.number4;
	}

	// Token: 0x06000137 RID: 311 RVA: 0x00007431 File Offset: 0x00005631
	[CompilerGenerated]
	public int GetOutputBlockSize()
	{
		return this.number5;
	}

	// Token: 0x04000079 RID: 121
	private 322 _recoveredType01190604;

	// Token: 0x0400007A RID: 122
	private readonly int number4;

	// Token: 0x0400007B RID: 123
	private readonly int number5;
}
