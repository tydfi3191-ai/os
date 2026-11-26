using System;
using System.Xml;

// Token: 0x0200012F RID: 303
[241(0)]
[242(2)]
public sealed class 447 : 535, 489, 670
{
	// Token: 0x17000088 RID: 136
	// (get) Token: 0x06000AB8 RID: 2744 RVA: 0x00028CD0 File Offset: 0x00026ED0
	[241(1)]
	public string Text3100
	{
		[242(1)]
		get
		{
			return this.xmlDocumentType2.Name;
		}
	}

	// Token: 0x06000AB9 RID: 2745 RVA: 0x00028CDD File Offset: 0x00026EDD
	[242(1)]
	public 447(XmlDocumentType 1) : base(1)
	{
		this.xmlDocumentType2 = 1;
	}

	// Token: 0x06000ABA RID: 2746 RVA: 0x00028CED File Offset: 0x00026EED
	public string Method4004()
	{
		return this.xmlDocumentType2.SystemId;
	}

	// Token: 0x06000ABB RID: 2747 RVA: 0x00028CFA File Offset: 0x00026EFA
	public string Method4005()
	{
		return this.xmlDocumentType2.PublicId;
	}

	// Token: 0x06000ABC RID: 2748 RVA: 0x00028D07 File Offset: 0x00026F07
	public string Method4006()
	{
		return this.xmlDocumentType2.InternalSubset;
	}

	// Token: 0x06000ABD RID: 2749 RVA: 0x000099D1 File Offset: 0x00007BD1
	public override string Method13408()
	{
		return "DOCTYPE";
	}

	// Token: 0x0400054D RID: 1357
	[241(1)]
	private readonly XmlDocumentType xmlDocumentType2;
}
