using System;
using System.Xml;

// Token: 0x0200011E RID: 286
[241(0)]
[242(2)]
public sealed class 400 : 535, 635, 670
{
	// Token: 0x06000A56 RID: 2646 RVA: 0x00027A07 File Offset: 0x00025C07
	[242(1)]
	public 400(XmlDeclaration 1) : base(1)
	{
		this.xmlDeclaration2 = 1;
	}

	// Token: 0x06000A57 RID: 2647 RVA: 0x00027A17 File Offset: 0x00025C17
	public string Method11619()
	{
		return this.xmlDeclaration2.Version;
	}

	// Token: 0x06000A58 RID: 2648 RVA: 0x00027A24 File Offset: 0x00025C24
	public string Method11620()
	{
		return this.xmlDeclaration2.Encoding;
	}

	// Token: 0x06000A59 RID: 2649 RVA: 0x00027A31 File Offset: 0x00025C31
	public void Method11621(string 1)
	{
		this.xmlDeclaration2.Encoding = 1;
	}

	// Token: 0x06000A5A RID: 2650 RVA: 0x00027A3F File Offset: 0x00025C3F
	public string Method11622()
	{
		return this.xmlDeclaration2.Standalone;
	}

	// Token: 0x06000A5B RID: 2651 RVA: 0x00027A4C File Offset: 0x00025C4C
	public void Method11623(string 1)
	{
		this.xmlDeclaration2.Standalone = 1;
	}

	// Token: 0x0400051D RID: 1309
	[241(1)]
	private readonly XmlDeclaration xmlDeclaration2;
}
