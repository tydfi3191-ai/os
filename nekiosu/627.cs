using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

// Token: 0x02000302 RID: 770
[ComVisible(false)]
public sealed class 627 : 560
{
	// Token: 0x170000FF RID: 255
	// (get) Token: 0x0600170A RID: 5898 RVA: 0x0004FB52 File Offset: 0x0004DD52
	// (set) Token: 0x0600170B RID: 5899 RVA: 0x0004FB55 File Offset: 0x0004DD55
	public override int BlockSize
	{
		get
		{
			return 8;
		}
		set
		{
			if (value != 8)
			{
				throw new CryptographicException("Block size is invalid");
			}
		}
	}

	// Token: 0x17000100 RID: 256
	// (get) Token: 0x0600170C RID: 5900 RVA: 0x0004FB66 File Offset: 0x0004DD66
	public override KeySizes[] LegalKeySizes
	{
		get
		{
			return new KeySizes[]
			{
				new KeySizes(96, 96, 0)
			};
		}
	}

	// Token: 0x17000101 RID: 257
	// (get) Token: 0x0600170D RID: 5901 RVA: 0x0004FB7B File Offset: 0x0004DD7B
	public override KeySizes[] LegalBlockSizes
	{
		get
		{
			return new KeySizes[]
			{
				new KeySizes(8, 8, 0)
			};
		}
	}

	// Token: 0x17000102 RID: 258
	// (get) Token: 0x0600170E RID: 5902 RVA: 0x0004FB8E File Offset: 0x0004DD8E
	// (set) Token: 0x0600170F RID: 5903 RVA: 0x0004FBAE File Offset: 0x0004DDAE
	public override byte[] Key
	{
		get
		{
			if (this.byteArray3 == null)
			{
				this.GenerateKey();
			}
			return (byte[])this.byteArray3.Clone();
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("#=zUkSU2UA=");
			}
			if (value.Length != 12)
			{
				throw new CryptographicException("Key size is illegal");
			}
			this.byteArray3 = (byte[])value.Clone();
		}
	}

	// Token: 0x06001710 RID: 5904 RVA: 0x00005ADD File Offset: 0x00003CDD
	public override void GenerateIV()
	{
	}

	// Token: 0x06001711 RID: 5905 RVA: 0x0004FBE1 File Offset: 0x0004DDE1
	public override void GenerateKey()
	{
		this.byteArray3 = new byte[12];
		new Random().NextBytes(this.byteArray3);
	}

	// Token: 0x06001712 RID: 5906 RVA: 0x0004FC00 File Offset: 0x0004DE00
	public override ICryptoTransform CreateEncryptor(byte[] 1, byte[] 2)
	{
		this.byteArray3 = 1;
		return new 631(this.Key);
	}

	// Token: 0x06001713 RID: 5907 RVA: 0x0004FC14 File Offset: 0x0004DE14
	public override ICryptoTransform CreateDecryptor(byte[] 1, byte[] 2)
	{
		this.byteArray3 = 1;
		return new 708(this.Key);
	}

	// Token: 0x04000AD9 RID: 2777
	private byte[] byteArray3;
}
