using System;

// Token: 0x02000126 RID: 294
[242(1)]
public interface 422 : 670
{
	// Token: 0x17000084 RID: 132
	// (get) Token: 0x06000A87 RID: 2695
	[241(2)]
	613 RecoveredType15909193 { [242(2)] get; }

	// Token: 0x06000A88 RID: 2696
	670 CreateComment([241(2)] string 1);

	// Token: 0x06000A89 RID: 2697
	670 CreateTextNode([241(2)] string 1);

	// Token: 0x06000A8A RID: 2698
	670 CreateCDataSection([241(2)] string 1);

	// Token: 0x06000A8B RID: 2699
	670 CreateWhitespace([241(2)] string 1);

	// Token: 0x06000A8C RID: 2700
	670 CreateSignificantWhitespace([241(2)] string 1);

	// Token: 0x06000A8D RID: 2701
	670 CreateXmlDeclaration(string 1, [241(2)] string 2, [241(2)] string 3);

	// Token: 0x06000A8E RID: 2702
	[242(2)]
	[return: 241(1)]
	670 CreateXmlDocumentType([241(1)] string 1, string 2, string 3, string 4);

	// Token: 0x06000A8F RID: 2703
	670 CreateProcessingInstruction(string 1, string 2);

	// Token: 0x06000A90 RID: 2704
	613 Method116132(string 1);

	// Token: 0x06000A91 RID: 2705
	613 Method116132(string 1, string 2);

	// Token: 0x06000A92 RID: 2706
	670 Method116152(string 1, string 2);

	// Token: 0x06000A93 RID: 2707
	670 Method116152(string 1, string 2, string 3);
}
