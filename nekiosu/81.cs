using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;

// Token: 0x02000091 RID: 145
[242(1)]
[241(0)]
public sealed class 81 : 549, 422, 670
{
	// Token: 0x17000018 RID: 24
	// (get) Token: 0x06000306 RID: 774 RVA: 0x0000980B File Offset: 0x00007A0B
	[241(2)]
	public 613 RecoveredType15909193
	{
		[242(2)]
		get
		{
			if (this.GetXDocument().Root == null)
			{
				return null;
			}
			return new 563(this.GetXDocument().Root);
		}
	}

	// Token: 0x06000307 RID: 775 RVA: 0x0000982C File Offset: 0x00007A2C
	public 81(XDocument 1) : base(1)
	{
	}

	// Token: 0x06000308 RID: 776 RVA: 0x00009835 File Offset: 0x00007A35
	private XDocument GetXDocument()
	{
		return (XDocument)base.GetXmlNode5349_6752();
	}

	// Token: 0x06000309 RID: 777 RVA: 0x00009844 File Offset: 0x00007A44
	public override List<670> Method11603()
	{
		List<670> list = base.Method11603();
		if (this.GetXDocument().Declaration != null && (list.Count == 0 || list[0].GetXmlDeclaration_11618() != XmlNodeType.XmlDeclaration))
		{
			list.Insert(0, new 734(this.GetXDocument().Declaration));
		}
		return list;
	}

	// Token: 0x0600030A RID: 778 RVA: 0x00009895 File Offset: 0x00007A95
	protected override bool Method11604()
	{
		return base.Method11604() || this.GetXDocument().Declaration != null;
	}

	// Token: 0x0600030B RID: 779 RVA: 0x000098AF File Offset: 0x00007AAF
	public 670 CreateComment([241(2)] string 1)
	{
		return new 984(new XComment(1));
	}

	// Token: 0x0600030C RID: 780 RVA: 0x000098BC File Offset: 0x00007ABC
	public 670 CreateTextNode([241(2)] string 1)
	{
		return new 984(new XText(1));
	}

	// Token: 0x0600030D RID: 781 RVA: 0x000098C9 File Offset: 0x00007AC9
	public 670 CreateCDataSection([241(2)] string 1)
	{
		return new 984(new XCData(1));
	}

	// Token: 0x0600030E RID: 782 RVA: 0x000098BC File Offset: 0x00007ABC
	public 670 CreateWhitespace([241(2)] string 1)
	{
		return new 984(new XText(1));
	}

	// Token: 0x0600030F RID: 783 RVA: 0x000098BC File Offset: 0x00007ABC
	public 670 CreateSignificantWhitespace([241(2)] string 1)
	{
		return new 984(new XText(1));
	}

	// Token: 0x06000310 RID: 784 RVA: 0x000098D6 File Offset: 0x00007AD6
	public 670 CreateXmlDeclaration(string 1, [241(2)] string 2, [241(2)] string 3)
	{
		return new 734(new XDeclaration(1, 2, 3));
	}

	// Token: 0x06000311 RID: 785 RVA: 0x000098E5 File Offset: 0x00007AE5
	[242(2)]
	[return: 241(1)]
	public 670 CreateXmlDocumentType([241(1)] string 1, string 2, string 3, string 4)
	{
		return new 352(new XDocumentType(1, 2, 3, 4));
	}

	// Token: 0x06000312 RID: 786 RVA: 0x000098F6 File Offset: 0x00007AF6
	public 670 CreateProcessingInstruction(string 1, string 2)
	{
		return new 985(new XProcessingInstruction(1, 2));
	}

	// Token: 0x06000313 RID: 787 RVA: 0x00009904 File Offset: 0x00007B04
	public 613 Method116132(string 1)
	{
		return new 563(new XElement(1));
	}

	// Token: 0x06000314 RID: 788 RVA: 0x00009916 File Offset: 0x00007B16
	public 613 Method116132(string 1, string 2)
	{
		return new 563(new XElement(XName.Get(736.Method11633(1), 2)));
	}

	// Token: 0x06000315 RID: 789 RVA: 0x0000992E File Offset: 0x00007B2E
	public 670 Method116152(string 1, string 2)
	{
		return new 799(new XAttribute(1, 2));
	}

	// Token: 0x06000316 RID: 790 RVA: 0x00009941 File Offset: 0x00007B41
	public 670 Method116152(string 1, string 2, string 3)
	{
		return new 799(new XAttribute(XName.Get(736.Method11633(1), 2), 3));
	}

	// Token: 0x06000317 RID: 791 RVA: 0x0000995C File Offset: 0x00007B5C
	public override 670 Method11617(670 1)
	{
		734 2 = 1 as 734;
		if (2 != null)
		{
			this.GetXDocument().Declaration = 2.XDeclaration9195;
			return 2;
		}
		return base.Method11617(1);
	}
}
