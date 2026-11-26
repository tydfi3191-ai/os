using System;
using System.Xml;
using System.Xml.Linq;

// Token: 0x02000095 RID: 149
[241(0)]
[242(2)]
public sealed class 734 : 984, 635, 670
{
	// Token: 0x1700001B RID: 27
	// (get) Token: 0x0600032A RID: 810 RVA: 0x00009BC2 File Offset: 0x00007DC2
	[241(1)]
	internal XDeclaration XDeclaration9195
	{
		[242(1)]
		get
		{
			return this.xDeclaration2;
		}
	}

	// Token: 0x0600032B RID: 811 RVA: 0x00009BCA File Offset: 0x00007DCA
	[242(1)]
	public 734(XDeclaration 1) : base(null)
	{
		this.xDeclaration2 = 1;
	}

	// Token: 0x0600032C RID: 812 RVA: 0x00009BDA File Offset: 0x00007DDA
	public override XmlNodeType GetXmlDeclaration_11618()
	{
		return XmlNodeType.XmlDeclaration;
	}

	// Token: 0x0600032D RID: 813 RVA: 0x00009BDE File Offset: 0x00007DDE
	public string Method11619()
	{
		return this.XDeclaration9195.Version;
	}

	// Token: 0x0600032E RID: 814 RVA: 0x00009BEB File Offset: 0x00007DEB
	public string Method11620()
	{
		return this.XDeclaration9195.Encoding;
	}

	// Token: 0x0600032F RID: 815 RVA: 0x00009BF8 File Offset: 0x00007DF8
	public void Method11621(string 1)
	{
		this.XDeclaration9195.Encoding = 1;
	}

	// Token: 0x06000330 RID: 816 RVA: 0x00009C06 File Offset: 0x00007E06
	public string Method11622()
	{
		return this.XDeclaration9195.Standalone;
	}

	// Token: 0x06000331 RID: 817 RVA: 0x00009C13 File Offset: 0x00007E13
	public void Method11623(string 1)
	{
		this.XDeclaration9195.Standalone = 1;
	}

	// Token: 0x04000363 RID: 867
	[241(1)]
	private readonly XDeclaration xDeclaration2;
}
