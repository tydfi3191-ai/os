using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x020003C3 RID: 963
[ComVisible(false)]
[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
public class 212
{
	// Token: 0x17000215 RID: 533
	// (get) Token: 0x06001ECB RID: 7883 RVA: 0x000782D3 File Offset: 0x000764D3
	public byte[] Value
	{
		[CompilerGenerated]
		get
		{
			return this.byteArray;
		}
	}

	// Token: 0x06001ECC RID: 7884 RVA: 0x000782DB File Offset: 0x000764DB
	public 212(byte[] 1)
	{
		756.Method12216(1, "value");
		if (1.Length != 12)
		{
			throw new ArgumentException("An ObjectId must be 12 bytes", "value");
		}
		this.byteArray = 1;
	}

	// Token: 0x04000EDB RID: 3803
	private readonly byte[] byteArray;
}
