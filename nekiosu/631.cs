using System;
using System.Security.Cryptography;

// Token: 0x02000305 RID: 773
public sealed class 631 : 279, ICryptoTransform, IDisposable
{
	// Token: 0x17000108 RID: 264
	// (get) Token: 0x06001739 RID: 5945 RVA: 0x0001702D File Offset: 0x0001522D
	public bool CanReuseTransform
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17000109 RID: 265
	// (get) Token: 0x0600173A RID: 5946 RVA: 0x0001702D File Offset: 0x0001522D
	public int InputBlockSize
	{
		get
		{
			return 1;
		}
	}

	// Token: 0x1700010A RID: 266
	// (get) Token: 0x0600173B RID: 5947 RVA: 0x0001702D File Offset: 0x0001522D
	public int OutputBlockSize
	{
		get
		{
			return 1;
		}
	}

	// Token: 0x1700010B RID: 267
	// (get) Token: 0x0600173C RID: 5948 RVA: 0x0001702D File Offset: 0x0001522D
	public bool CanTransformMultipleBlocks
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0600173D RID: 5949 RVA: 0x000501BE File Offset: 0x0004E3BE
	internal 631(byte[] 1)
	{
		base.SetKey(1);
	}

	// Token: 0x0600173E RID: 5950 RVA: 0x000501D0 File Offset: 0x0004E3D0
	public byte[] TransformFinalBlock(byte[] 1, int 2, int 3)
	{
		byte[] array = new byte[3];
		this.TransformBlock(1, 2, 3, array, 0);
		return array;
	}

	// Token: 0x0600173F RID: 5951 RVA: 0x000501F4 File Offset: 0x0004E3F4
	public int TransformBlock(byte[] 1, int 2, int 3, byte[] 4, int 5)
	{
		for (int i = 2; i < 2 + 3; i++)
		{
			byte 6 = 1[i];
			4[5++] = (1[i] ^ base.DecryptByte());
			base.UpdateKeys(6);
		}
		return 3;
	}

	// Token: 0x06001740 RID: 5952 RVA: 0x00050230 File Offset: 0x0004E430
	public void Dispose()
	{
		base.ClearKeys();
	}
}
