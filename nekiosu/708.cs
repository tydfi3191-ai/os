using System;
using System.Security.Cryptography;

// Token: 0x02000312 RID: 786
public sealed class 708 : 279, ICryptoTransform, IDisposable
{
	// Token: 0x1700010C RID: 268
	// (get) Token: 0x06001793 RID: 6035 RVA: 0x0001702D File Offset: 0x0001522D
	public bool CanReuseTransform
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700010D RID: 269
	// (get) Token: 0x06001794 RID: 6036 RVA: 0x0001702D File Offset: 0x0001522D
	public int InputBlockSize
	{
		get
		{
			return 1;
		}
	}

	// Token: 0x1700010E RID: 270
	// (get) Token: 0x06001795 RID: 6037 RVA: 0x0001702D File Offset: 0x0001522D
	public int OutputBlockSize
	{
		get
		{
			return 1;
		}
	}

	// Token: 0x1700010F RID: 271
	// (get) Token: 0x06001796 RID: 6038 RVA: 0x0001702D File Offset: 0x0001522D
	public bool CanTransformMultipleBlocks
	{
		get
		{
			return true;
		}
	}

	// Token: 0x06001797 RID: 6039 RVA: 0x000501BE File Offset: 0x0004E3BE
	internal 708(byte[] 1)
	{
		base.SetKey(1);
	}

	// Token: 0x06001798 RID: 6040 RVA: 0x00051538 File Offset: 0x0004F738
	public byte[] TransformFinalBlock(byte[] 1, int 2, int 3)
	{
		byte[] array = new byte[3];
		this.TransformBlock(1, 2, 3, array, 0);
		return array;
	}

	// Token: 0x06001799 RID: 6041 RVA: 0x0005155C File Offset: 0x0004F75C
	public int TransformBlock(byte[] 1, int 2, int 3, byte[] 4, int 5)
	{
		for (int i = 2; i < 2 + 3; i++)
		{
			byte b = 1[i] ^ base.DecryptByte();
			4[5++] = b;
			base.UpdateKeys(b);
		}
		return 3;
	}

	// Token: 0x0600179A RID: 6042 RVA: 0x00050230 File Offset: 0x0004E430
	public void Dispose()
	{
		base.ClearKeys();
	}
}
