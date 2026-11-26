using System;
using System.IO;
using System.Security.Cryptography;

// Token: 0x02000316 RID: 790
public sealed class 716 : CryptoStream
{
	// Token: 0x060017CE RID: 6094 RVA: 0x00053900 File Offset: 0x00051B00
	public 716(Stream 1, 413 2, CryptoStreamMode 3) : base(1, 2, 3)
	{
		this.stream2 = 1;
		this._recoveredType05238758 = 2;
		this.byteArray2 = new byte[1024];
		this.number5 = 26;
		if (3 != CryptoStreamMode.Read)
		{
			throw new Exception("ZipAESStream only for read");
		}
	}

	// Token: 0x060017CF RID: 6095 RVA: 0x00053940 File Offset: 0x00051B40
	public override int Read(byte[] 1, int 2, int 3)
	{
		int i = 0;
		while (i < 3)
		{
			int num = this.number4 - this.number3;
			int num2 = this.number5 - num;
			if (this.byteArray2.Length - this.number4 < num2)
			{
				int num3 = 0;
				int j = this.number3;
				while (j < this.number4)
				{
					this.byteArray2[num3] = this.byteArray2[j];
					j++;
					num3++;
				}
				this.number4 -= this.number3;
				this.number3 = 0;
			}
			int num4 = this.stream2.Read(this.byteArray2, this.number4, num2);
			this.number4 += num4;
			num = this.number4 - this.number3;
			if (num < this.number5)
			{
				if (num > 10)
				{
					int num5 = num - 10;
					this._recoveredType05238758.TransformBlock(this.byteArray2, this.number3, num5, 1, 2);
					i += num5;
					this.number3 += num5;
				}
				else if (num < 10)
				{
					throw new Exception("Internal error missed auth code");
				}
				byte[] array = this._recoveredType05238758.Method3085();
				for (int k = 0; k < 10; k++)
				{
					if (array[k] != this.byteArray2[this.number3 + k])
					{
						throw new Exception("AES Authentication Code does not match. This is a super-CRC check on the data in the file after compression and encryption. \r\nThe file may be damaged.");
					}
				}
				break;
			}
			this._recoveredType05238758.TransformBlock(this.byteArray2, this.number3, 16, 1, 2);
			i += 16;
			2 += 16;
			this.number3 += 16;
		}
		return i;
	}

	// Token: 0x060017D0 RID: 6096 RVA: 0x00053ADC File Offset: 0x00051CDC
	public override void Write(byte[] 1, int 2, int 3)
	{
		throw new NotImplementedException();
	}

	// Token: 0x04000B21 RID: 2849
	private Stream stream2;

	// Token: 0x04000B22 RID: 2850
	private 413 _recoveredType05238758;

	// Token: 0x04000B23 RID: 2851
	private byte[] byteArray2;

	// Token: 0x04000B24 RID: 2852
	private int number3;

	// Token: 0x04000B25 RID: 2853
	private int number4;

	// Token: 0x04000B26 RID: 2854
	private int number5;
}
