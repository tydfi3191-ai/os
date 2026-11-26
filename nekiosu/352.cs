using System;
using System.Xml.Linq;

// Token: 0x02000092 RID: 146
[241(0)]
[242(2)]
public sealed class 352 : 984, 489, 670
{
	// Token: 0x17000019 RID: 25
	// (get) Token: 0x06000318 RID: 792 RVA: 0x0000998D File Offset: 0x00007B8D
	[241(1)]
	public string Text3100
	{
		[242(1)]
		get
		{
			return this.xDocumentType2.Name;
		}
	}

	// Token: 0x06000319 RID: 793 RVA: 0x0000999A File Offset: 0x00007B9A
	[242(1)]
	public 352(XDocumentType 1) : base(1)
	{
		this.xDocumentType2 = 1;
	}

	// Token: 0x0600031A RID: 794 RVA: 0x000099AA File Offset: 0x00007BAA
	public string Method4004()
	{
		return this.xDocumentType2.SystemId;
	}

	// Token: 0x0600031B RID: 795 RVA: 0x000099B7 File Offset: 0x00007BB7
	public string Method4005()
	{
		return this.xDocumentType2.PublicId;
	}

	// Token: 0x0600031C RID: 796 RVA: 0x000099C4 File Offset: 0x00007BC4
	public string Method4006()
	{
		return this.xDocumentType2.InternalSubset;
	}

	// Token: 0x0600031D RID: 797 RVA: 0x000099D1 File Offset: 0x00007BD1
	public override string Method13408()
	{
		return "DOCTYPE";
	}

	// Token: 0x04000361 RID: 865
	[241(1)]
	private readonly XDocumentType xDocumentType2;
}
