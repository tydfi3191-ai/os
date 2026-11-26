using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Permissions;

// Token: 0x02000031 RID: 49
[ComVisible(false)]
[HostProtection(SecurityAction.LinkDemand, MayLeakOnAbort = true)]
public abstract class 425 : SymmetricAlgorithm
{
	// Token: 0x06000138 RID: 312 RVA: 0x0000743C File Offset: 0x0000563C
	protected 425()
	{
		this.LegalBlockSizesValue = 425.keySizesArray;
		this.LegalKeySizesValue = 425.keySizesArray2;
		this.BlockSizeValue = 128;
		this.FeedbackSizeValue = 8;
		this.KeySizeValue = 256;
		this.ModeValue = CipherMode.CBC;
	}

	// Token: 0x0400007C RID: 124
	private static KeySizes[] keySizesArray = new KeySizes[]
	{
		new KeySizes(128, 128, 0)
	};

	// Token: 0x0400007D RID: 125
	private static KeySizes[] keySizesArray2 = new KeySizes[]
	{
		new KeySizes(128, 256, 64)
	};
}
