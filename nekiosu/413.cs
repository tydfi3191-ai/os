using System;
using System.Security.Cryptography;

// Token: 0x020002E8 RID: 744
public sealed class 413 : ICryptoTransform, IDisposable
{
	// Token: 0x170000F0 RID: 240
	// (get) Token: 0x0600164A RID: 5706 RVA: 0x0004CD90 File Offset: 0x0004AF90
	public int InputBlockSize
	{
		get
		{
			return this.number4;
		}
	}

	// Token: 0x170000F1 RID: 241
	// (get) Token: 0x0600164B RID: 5707 RVA: 0x0004CD90 File Offset: 0x0004AF90
	public int OutputBlockSize
	{
		get
		{
			return this.number4;
		}
	}

	// Token: 0x170000F2 RID: 242
	// (get) Token: 0x0600164C RID: 5708 RVA: 0x0001702D File Offset: 0x0001522D
	public bool CanTransformMultipleBlocks
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170000F3 RID: 243
	// (get) Token: 0x0600164D RID: 5709 RVA: 0x0001702D File Offset: 0x0001522D
	public bool CanReuseTransform
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0600164E RID: 5710 RVA: 0x0004CD98 File Offset: 0x0004AF98
	public 413(string 1, byte[] 2, int 3, bool 4)
	{
		if (3 != 16 && 3 != 32)
		{
			throw new Exception("Invalid blocksize " + 3.ToString() + ". Must be 16 or 32.");
		}
		if (2.Length != 3 / 2)
		{
			throw new Exception("Invalid salt len. Must be " + (3 / 2).ToString() + " for blocksize " + 3.ToString());
		}
		this.number4 = 3;
		this.byteArray4 = new byte[this.number4];
		this.number5 = 16;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(1, 2, 1000);
		RijndaelManaged rijndaelManaged = new RijndaelManaged
		{
			Mode = CipherMode.ECB
		};
		this.byteArray3 = new byte[this.number4];
		byte[] bytes = rfc2898DeriveBytes.GetBytes(this.number4);
		byte[] bytes2 = rfc2898DeriveBytes.GetBytes(this.number4);
		this.iCryptoTransform = rijndaelManaged.CreateEncryptor(bytes, bytes2);
		this.byteArray5 = rfc2898DeriveBytes.GetBytes(2);
		this.hMACSHA = new HMACSHA1(bytes2);
		this.flag3 = 4;
	}

	// Token: 0x0600164F RID: 5711 RVA: 0x0004CE98 File Offset: 0x0004B098
	public int TransformBlock(byte[] 1, int 2, int 3, byte[] 4, int 5)
	{
		if (!this.flag3)
		{
			this.hMACSHA.TransformBlock(1, 2, 3, 1, 2);
		}
		for (int i = 0; i < 3; i++)
		{
			if (this.number5 == 16)
			{
				int num = 0;
				for (;;)
				{
					byte[] array = this.byteArray3;
					int num2 = num;
					byte b = array[num2] + 1;
					array[num2] = b;
					if (b != 0)
					{
						break;
					}
					num++;
				}
				this.iCryptoTransform.TransformBlock(this.byteArray3, 0, this.number4, this.byteArray4, 0);
				this.number5 = 0;
			}
			int num3 = i + 5;
			byte b2 = 1[i + 2];
			byte[] array2 = this.byteArray4;
			int num4 = this.number5;
			this.number5 = num4 + 1;
			4[num3] = (b2 ^ array2[num4]);
		}
		if (this.flag3)
		{
			this.hMACSHA.TransformBlock(4, 5, 3, 4, 5);
		}
		return 3;
	}

	// Token: 0x06001650 RID: 5712 RVA: 0x0004CF5E File Offset: 0x0004B15E
	public byte[] GetByteArray2458_3084()
	{
		return this.byteArray5;
	}

	// Token: 0x06001651 RID: 5713 RVA: 0x0004CF68 File Offset: 0x0004B168
	public byte[] Method3085()
	{
		if (!this.flag2)
		{
			byte[] inputBuffer = new byte[0];
			this.hMACSHA.TransformFinalBlock(inputBuffer, 0, 0);
			this.flag2 = true;
		}
		return this.hMACSHA.Hash;
	}

	// Token: 0x06001652 RID: 5714 RVA: 0x0004CFA5 File Offset: 0x0004B1A5
	public byte[] TransformFinalBlock(byte[] 1, int 2, int 3)
	{
		throw new NotImplementedException("ZipAESTransform.TransformFinalBlock");
	}

	// Token: 0x06001653 RID: 5715 RVA: 0x0004CFB1 File Offset: 0x0004B1B1
	public void Dispose()
	{
		HMACSHA1 hmacsha = this.hMACSHA;
		if (hmacsha != null)
		{
			hmacsha.Dispose();
		}
		this.iCryptoTransform.Dispose();
	}

	// Token: 0x04000A73 RID: 2675
	private int number4;

	// Token: 0x04000A74 RID: 2676
	private ICryptoTransform iCryptoTransform;

	// Token: 0x04000A75 RID: 2677
	private readonly byte[] byteArray3;

	// Token: 0x04000A76 RID: 2678
	private byte[] byteArray4;

	// Token: 0x04000A77 RID: 2679
	private int number5;

	// Token: 0x04000A78 RID: 2680
	private byte[] byteArray5;

	// Token: 0x04000A79 RID: 2681
	private HMACSHA1 hMACSHA;

	// Token: 0x04000A7A RID: 2682
	private bool flag2;

	// Token: 0x04000A7B RID: 2683
	private bool flag3;
}
