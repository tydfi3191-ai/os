using System;
using System.Security.Cryptography;

// Token: 0x0200002B RID: 43
public interface 282
{
	// Token: 0x060000F7 RID: 247
	int GetInputBlockSize();

	// Token: 0x060000F8 RID: 248
	int GetOutputBlockSize();

	// Token: 0x060000F9 RID: 249
	int TransformBlock(byte[] 1, int 2, int 3, byte[] 4, int 5, RandomNumberGenerator 6);
}
