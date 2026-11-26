using System;
using System.Xml;

// Token: 0x02000127 RID: 295
[241(0)]
[242(1)]
public sealed class 423 : 535, 613, 670
{
	// Token: 0x06000A94 RID: 2708 RVA: 0x00028889 File Offset: 0x00026A89
	public 423(XmlElement 1) : base(1)
	{
		this.xmlElement2 = 1;
	}

	// Token: 0x06000A95 RID: 2709 RVA: 0x0002889C File Offset: 0x00026A9C
	public void Method7757(670 1)
	{
		535 2 = (535)1;
		this.xmlElement2.SetAttributeNode((XmlAttribute)2.GetXmlNode5349_6752());
	}

	// Token: 0x06000A96 RID: 2710 RVA: 0x000288C7 File Offset: 0x00026AC7
	[return: 241(2)]
	public string Method7761(string 1)
	{
		return this.xmlElement2.GetPrefixOfNamespace(1);
	}

	// Token: 0x06000A97 RID: 2711 RVA: 0x000288D5 File Offset: 0x00026AD5
	public bool Method7762()
	{
		return this.xmlElement2.IsEmpty;
	}

	// Token: 0x0400053D RID: 1341
	private readonly XmlElement xmlElement2;
}
