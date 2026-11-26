using System;
using System.Xml;

// Token: 0x020000B0 RID: 176
[242(1)]
[241(0)]
public sealed class 175 : 535, 422, 670
{
	// Token: 0x17000028 RID: 40
	// (get) Token: 0x06000465 RID: 1125 RVA: 0x0000D85F File Offset: 0x0000BA5F
	[241(2)]
	public 613 RecoveredType15909193
	{
		[242(2)]
		get
		{
			if (this.document.DocumentElement == null)
			{
				return null;
			}
			return new 423(this.document.DocumentElement);
		}
	}

	// Token: 0x06000466 RID: 1126 RVA: 0x0000D880 File Offset: 0x0000BA80
	public 175(XmlDocument 1) : base(1)
	{
		this.document = 1;
	}

	// Token: 0x06000467 RID: 1127 RVA: 0x0000D890 File Offset: 0x0000BA90
	public 670 CreateComment([241(2)] string 1)
	{
		return new 535(this.document.CreateComment(1));
	}

	// Token: 0x06000468 RID: 1128 RVA: 0x0000D8A3 File Offset: 0x0000BAA3
	public 670 CreateTextNode([241(2)] string 1)
	{
		return new 535(this.document.CreateTextNode(1));
	}

	// Token: 0x06000469 RID: 1129 RVA: 0x0000D8B6 File Offset: 0x0000BAB6
	public 670 CreateCDataSection([241(2)] string 1)
	{
		return new 535(this.document.CreateCDataSection(1));
	}

	// Token: 0x0600046A RID: 1130 RVA: 0x0000D8C9 File Offset: 0x0000BAC9
	public 670 CreateWhitespace([241(2)] string 1)
	{
		return new 535(this.document.CreateWhitespace(1));
	}

	// Token: 0x0600046B RID: 1131 RVA: 0x0000D8DC File Offset: 0x0000BADC
	public 670 CreateSignificantWhitespace([241(2)] string 1)
	{
		return new 535(this.document.CreateSignificantWhitespace(1));
	}

	// Token: 0x0600046C RID: 1132 RVA: 0x0000D8EF File Offset: 0x0000BAEF
	public 670 CreateXmlDeclaration(string 1, [241(2)] string 2, [241(2)] string 3)
	{
		return new 400(this.document.CreateXmlDeclaration(1, 2, 3));
	}

	// Token: 0x0600046D RID: 1133 RVA: 0x0000D904 File Offset: 0x0000BB04
	[242(2)]
	[return: 241(1)]
	public 670 CreateXmlDocumentType([241(1)] string 1, string 2, string 3, string 4)
	{
		return new 447(this.document.CreateDocumentType(1, 2, 3, null));
	}

	// Token: 0x0600046E RID: 1134 RVA: 0x0000D91A File Offset: 0x0000BB1A
	public 670 CreateProcessingInstruction(string 1, string 2)
	{
		return new 535(this.document.CreateProcessingInstruction(1, 2));
	}

	// Token: 0x0600046F RID: 1135 RVA: 0x0000D92E File Offset: 0x0000BB2E
	public 613 Method116132(string 1)
	{
		return new 423(this.document.CreateElement(1));
	}

	// Token: 0x06000470 RID: 1136 RVA: 0x0000D941 File Offset: 0x0000BB41
	public 613 Method116132(string 1, string 2)
	{
		return new 423(this.document.CreateElement(1, 2));
	}

	// Token: 0x06000471 RID: 1137 RVA: 0x0000D955 File Offset: 0x0000BB55
	public 670 Method116152(string 1, [241(2)] string 2)
	{
		535 3 = new 535(this.document.CreateAttribute(1));
		3.Method13407(2);
		return 3;
	}

	// Token: 0x06000472 RID: 1138 RVA: 0x0000D96F File Offset: 0x0000BB6F
	public 670 Method116152(string 1, [241(2)] string 2, [241(2)] string 3)
	{
		535 4 = new 535(this.document.CreateAttribute(1, 2));
		4.Method13407(3);
		return 4;
	}

	// Token: 0x040003C1 RID: 961
	private readonly XmlDocument document;
}
