using System;
using System.IO;
using System.Runtime.InteropServices;

// Token: 0x020002FA RID: 762
[ComVisible(false)]
public sealed class 561 : 608
{
	// Token: 0x060016E2 RID: 5858 RVA: 0x0004F5D6 File Offset: 0x0004D7D6
	public 561() : base((455)1)
	{
	}

	// Token: 0x060016E3 RID: 5859 RVA: 0x0004F5DF File Offset: 0x0004D7DF
	public 561(455 1) : base(1)
	{
	}

	// Token: 0x060016E4 RID: 5860 RVA: 0x0004F5E8 File Offset: 0x0004D7E8
	public MemoryStream GetMemoryStream5856_7556()
	{
		return this.memoryStream2;
	}

	// Token: 0x060016E5 RID: 5861 RVA: 0x0004F5F0 File Offset: 0x0004D7F0
	public override Stream Method7557()
	{
		this.memoryStream = new MemoryStream();
		return this.memoryStream;
	}

	// Token: 0x060016E6 RID: 5862 RVA: 0x0004F603 File Offset: 0x0004D803
	public override Stream Method7558()
	{
		if (this.memoryStream == null)
		{
			throw new 415("No temporary stream has been created");
		}
		this.memoryStream2 = new MemoryStream(this.memoryStream.ToArray());
		return this.memoryStream2;
	}

	// Token: 0x060016E7 RID: 5863 RVA: 0x0004F634 File Offset: 0x0004D834
	public override Stream Method7559(Stream 1)
	{
		this.memoryStream = new MemoryStream();
		1.Position = 0L;
		402.Method2548(1, this.memoryStream, new byte[4096]);
		return this.memoryStream;
	}

	// Token: 0x060016E8 RID: 5864 RVA: 0x0004F668 File Offset: 0x0004D868
	public override Stream Method7560(Stream 1)
	{
		Stream stream;
		if (1 == null || !1.CanWrite)
		{
			stream = new MemoryStream();
			if (1 != null)
			{
				1.Position = 0L;
				402.Method2548(1, stream, new byte[4096]);
				1.Close();
			}
		}
		else
		{
			stream = 1;
		}
		return stream;
	}

	// Token: 0x060016E9 RID: 5865 RVA: 0x0004F6AD File Offset: 0x0004D8AD
	public override void Method7561()
	{
		if (this.memoryStream != null)
		{
			this.memoryStream.Close();
		}
	}

	// Token: 0x04000ACD RID: 2765
	private MemoryStream memoryStream;

	// Token: 0x04000ACE RID: 2766
	private MemoryStream memoryStream2;
}
