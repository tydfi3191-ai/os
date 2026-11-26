using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

// Token: 0x02000BF7 RID: 3063
public sealed class 1133 : 282, IDisposable
{
	// Token: 0x06005397 RID: 21399 RVA: 0x0020B410 File Offset: 0x00209610
	public 1133(1122 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException();
		}
		if (1.1())
		{
			throw new NotSupportedException();
		}
		this.1 = 1;
		this.2 = new byte[1.GetOutputBlockSize()];
		this.3 = this.1();
		this.4 = this.2();
	}

	// Token: 0x06005398 RID: 21400 RVA: 0x0020B46A File Offset: 0x0020966A
	private int 1()
	{
		return this.1.GetInputBlockSize();
	}

	// Token: 0x06005399 RID: 21401 RVA: 0x0020B477 File Offset: 0x00209677
	private int 2()
	{
		return this.1.GetOutputBlockSize() - 10;
	}

	// Token: 0x0600539A RID: 21402 RVA: 0x0020B487 File Offset: 0x00209687
	public int TransformBlock(byte[] 1, int 2, int 3, byte[] 4, int 5, RandomNumberGenerator 6)
	{
		return this.3(1, 2, 3, 4, 5, 6);
	}

	// Token: 0x0600539B RID: 21403 RVA: 0x0020B498 File Offset: 0x00209698
	private int 3(byte[] 1, int 2, int 3, byte[] 4, int 5, RandomNumberGenerator 6)
	{
		int outputBlockSize = this.1.GetOutputBlockSize();
		byte[] array = this.2;
		this.1.TransformBlock(1, 2, 3, array, 0, 6);
		byte b = array[0];
		bool flag = b != 2;
		int num = 1133.4(b, array, 0, outputBlockSize);
		num++;
		if (flag || num < 10)
		{
			throw new InvalidOperationException("Invalid block.");
		}
		int num2 = outputBlockSize - num;
		Buffer.BlockCopy(array, num, 4, 5, num2);
		return num2;
	}

	// Token: 0x0600539C RID: 21404 RVA: 0x0020B50C File Offset: 0x0020970C
	private static int 4(byte 1, byte[] 2, int 3, int 4)
	{
		for (int num = 3 + 1; num != 3 + 4; num++)
		{
			if (2[num] == 0)
			{
				return num;
			}
		}
		return -1;
	}

	// Token: 0x0600539D RID: 21405 RVA: 0x0020B531 File Offset: 0x00209731
	public void Dispose()
	{
		if (this.1 != null)
		{
			this.1.Dispose();
			this.1 = null;
		}
	}

	// Token: 0x0600539E RID: 21406 RVA: 0x0020B54D File Offset: 0x0020974D
	[CompilerGenerated]
	public int GetInputBlockSize()
	{
		return this.3;
	}

	// Token: 0x0600539F RID: 21407 RVA: 0x0020B555 File Offset: 0x00209755
	[CompilerGenerated]
	public int GetOutputBlockSize()
	{
		return this.4;
	}

	// Token: 0x04003F77 RID: 16247
	private 1122 1;

	// Token: 0x04003F78 RID: 16248
	private byte[] 2;

	// Token: 0x04003F79 RID: 16249
	private readonly int 3;

	// Token: 0x04003F7A RID: 16250
	private readonly int 4;
}
