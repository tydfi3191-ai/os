using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Permissions;

// Token: 0x02000033 RID: 51
[ComVisible(false)]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public sealed class 735 : 425
{
	// Token: 0x17000012 RID: 18
	// (get) Token: 0x0600013A RID: 314 RVA: 0x000074C8 File Offset: 0x000056C8
	// (set) Token: 0x0600013B RID: 315 RVA: 0x000074D5 File Offset: 0x000056D5
	public override int FeedbackSize
	{
		get
		{
			return this.rijndaelManaged.FeedbackSize;
		}
		set
		{
			this.rijndaelManaged.FeedbackSize = value;
		}
	}

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x0600013C RID: 316 RVA: 0x000074E3 File Offset: 0x000056E3
	// (set) Token: 0x0600013D RID: 317 RVA: 0x000074F0 File Offset: 0x000056F0
	public override byte[] IV
	{
		get
		{
			return this.rijndaelManaged.IV;
		}
		set
		{
			this.rijndaelManaged.IV = value;
		}
	}

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x0600013E RID: 318 RVA: 0x000074FE File Offset: 0x000056FE
	// (set) Token: 0x0600013F RID: 319 RVA: 0x0000750B File Offset: 0x0000570B
	public override byte[] Key
	{
		get
		{
			return this.rijndaelManaged.Key;
		}
		set
		{
			this.rijndaelManaged.Key = value;
		}
	}

	// Token: 0x17000015 RID: 21
	// (get) Token: 0x06000140 RID: 320 RVA: 0x00007519 File Offset: 0x00005719
	// (set) Token: 0x06000141 RID: 321 RVA: 0x00007526 File Offset: 0x00005726
	public override int KeySize
	{
		get
		{
			return this.rijndaelManaged.KeySize;
		}
		set
		{
			this.rijndaelManaged.KeySize = value;
		}
	}

	// Token: 0x17000016 RID: 22
	// (get) Token: 0x06000142 RID: 322 RVA: 0x00007534 File Offset: 0x00005734
	// (set) Token: 0x06000143 RID: 323 RVA: 0x00007541 File Offset: 0x00005741
	public override CipherMode Mode
	{
		get
		{
			return this.rijndaelManaged.Mode;
		}
		set
		{
			if (value == CipherMode.CFB || value == CipherMode.OFB)
			{
				throw new CryptographicException("Invalid cipher mode");
			}
			this.rijndaelManaged.Mode = value;
		}
	}

	// Token: 0x17000017 RID: 23
	// (get) Token: 0x06000144 RID: 324 RVA: 0x00007562 File Offset: 0x00005762
	// (set) Token: 0x06000145 RID: 325 RVA: 0x0000756F File Offset: 0x0000576F
	public override PaddingMode Padding
	{
		get
		{
			return this.rijndaelManaged.Padding;
		}
		set
		{
			this.rijndaelManaged.Padding = value;
		}
	}

	// Token: 0x06000146 RID: 326 RVA: 0x0000757D File Offset: 0x0000577D
	public 735()
	{
		this.rijndaelManaged = new RijndaelManaged();
		this.rijndaelManaged.BlockSize = this.BlockSize;
		this.rijndaelManaged.KeySize = this.KeySize;
	}

	// Token: 0x06000147 RID: 327 RVA: 0x000075B2 File Offset: 0x000057B2
	public override ICryptoTransform CreateDecryptor()
	{
		return this.rijndaelManaged.CreateDecryptor();
	}

	// Token: 0x06000148 RID: 328 RVA: 0x000075C0 File Offset: 0x000057C0
	public override ICryptoTransform CreateDecryptor(byte[] 1, byte[] 2)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=zGDlk81Y=");
		}
		if (!base.ValidKeySize(1.Length * 8))
		{
			throw new ArgumentException("Invalid key size", "#=zGDlk81Y=");
		}
		if (2 != null && 2.Length * 8 != this.BlockSizeValue)
		{
			throw new ArgumentException("Invalid IV size", "#=zq0Xh6lQ=");
		}
		return this.rijndaelManaged.CreateDecryptor(1, 2);
	}

	// Token: 0x06000149 RID: 329 RVA: 0x00007625 File Offset: 0x00005825
	public override ICryptoTransform CreateEncryptor()
	{
		return this.rijndaelManaged.CreateEncryptor();
	}

	// Token: 0x0600014A RID: 330 RVA: 0x00007634 File Offset: 0x00005834
	public override ICryptoTransform CreateEncryptor(byte[] 1, byte[] 2)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=zGDlk81Y=");
		}
		if (!base.ValidKeySize(1.Length * 8))
		{
			throw new ArgumentException("Invalid key size", "#=zGDlk81Y=");
		}
		if (2 != null && 2.Length * 8 != this.BlockSizeValue)
		{
			throw new ArgumentException("Invalid IV size", "#=zq0Xh6lQ=");
		}
		return this.rijndaelManaged.CreateEncryptor(1, 2);
	}

	// Token: 0x0600014B RID: 331 RVA: 0x00007699 File Offset: 0x00005899
	protected override void Dispose(bool 1)
	{
		base.Dispose(1);
		if (1)
		{
			((IDisposable)this.rijndaelManaged).Dispose();
		}
	}

	// Token: 0x0600014C RID: 332 RVA: 0x000076B0 File Offset: 0x000058B0
	public override void GenerateIV()
	{
		this.rijndaelManaged.GenerateIV();
	}

	// Token: 0x0600014D RID: 333 RVA: 0x000076BD File Offset: 0x000058BD
	public override void GenerateKey()
	{
		this.rijndaelManaged.GenerateKey();
	}

	// Token: 0x0400007F RID: 127
	private RijndaelManaged rijndaelManaged;
}
