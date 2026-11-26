using System;
using System.Collections.Generic;
using System.Xml;

// Token: 0x02000152 RID: 338
[242(2)]
[241(0)]
public class 535 : 670
{
	// Token: 0x17000097 RID: 151
	// (get) Token: 0x06000BBC RID: 3004 RVA: 0x0002AAD4 File Offset: 0x00028CD4
	[241(1)]
	public List<670> List5352
	{
		[242(1)]
		get
		{
			if (this.list == null)
			{
				if (!this.xmlNode2.HasChildNodes)
				{
					this.list = 986.list4;
				}
				else
				{
					this.list = new List<670>(this.xmlNode2.ChildNodes.Count);
					foreach (object obj in this.xmlNode2.ChildNodes)
					{
						XmlNode <<EMPTY_NAME>> = (XmlNode)obj;
						this.list.Add(535.Method6756(<<EMPTY_NAME>>));
					}
				}
			}
			return this.list;
		}
	}

	// Token: 0x17000098 RID: 152
	// (get) Token: 0x06000BBD RID: 3005 RVA: 0x0002AB84 File Offset: 0x00028D84
	[241(1)]
	public List<670> List5353
	{
		[242(1)]
		get
		{
			if (this.list2 == null)
			{
				if (!this.Method6757())
				{
					this.list2 = 986.list4;
				}
				else
				{
					this.list2 = new List<670>(this.xmlNode2.Attributes.Count);
					foreach (object obj in this.xmlNode2.Attributes)
					{
						XmlAttribute <<EMPTY_NAME>> = (XmlAttribute)obj;
						this.list2.Add(535.Method6756(<<EMPTY_NAME>>));
					}
				}
			}
			return this.list2;
		}
	}

	// Token: 0x06000BBE RID: 3006 RVA: 0x0002AC2C File Offset: 0x00028E2C
	[242(1)]
	public 535(XmlNode 1)
	{
		this.xmlNode2 = 1;
	}

	// Token: 0x06000BBF RID: 3007 RVA: 0x0002AC3B File Offset: 0x00028E3B
	public object GetXmlNode5349_6752()
	{
		return this.xmlNode2;
	}

	// Token: 0x06000BC0 RID: 3008 RVA: 0x0002AC43 File Offset: 0x00028E43
	public XmlNodeType GetXmlDeclaration_11618()
	{
		return this.xmlNode2.NodeType;
	}

	// Token: 0x06000BC1 RID: 3009 RVA: 0x0002AC50 File Offset: 0x00028E50
	public virtual string Method13408()
	{
		return this.xmlNode2.LocalName;
	}

	// Token: 0x06000BC2 RID: 3010 RVA: 0x0002AC5D File Offset: 0x00028E5D
	protected virtual bool Method6755()
	{
		return this.xmlNode2.HasChildNodes;
	}

	// Token: 0x06000BC3 RID: 3011 RVA: 0x0002AC6C File Offset: 0x00028E6C
	[242(1)]
	internal static 670 Method6756(XmlNode 1)
	{
		XmlNodeType nodeType = 1.NodeType;
		535 result;
		if (nodeType != XmlNodeType.Element)
		{
			if (nodeType != XmlNodeType.DocumentType)
			{
				if (nodeType != XmlNodeType.XmlDeclaration)
				{
					result = new 535(1);
				}
				else
				{
					result = new 400((XmlDeclaration)1);
				}
			}
			else
			{
				result = new 447((XmlDocumentType)1);
			}
		}
		else
		{
			result = new 423((XmlElement)1);
		}
		return result;
	}

	// Token: 0x06000BC4 RID: 3012 RVA: 0x0002ACC4 File Offset: 0x00028EC4
	private bool Method6757()
	{
		XmlElement xmlElement = this.xmlNode2 as XmlElement;
		if (xmlElement != null)
		{
			return xmlElement.HasAttributes;
		}
		XmlAttributeCollection attributes = this.xmlNode2.Attributes;
		return attributes != null && attributes.Count > 0;
	}

	// Token: 0x06000BC5 RID: 3013 RVA: 0x0002AD04 File Offset: 0x00028F04
	public 670 Method13410()
	{
		XmlAttribute xmlAttribute = this.xmlNode2 as XmlAttribute;
		XmlNode xmlNode = (xmlAttribute != null) ? xmlAttribute.OwnerElement : this.xmlNode2.ParentNode;
		if (xmlNode == null)
		{
			return null;
		}
		return 535.Method6756(xmlNode);
	}

	// Token: 0x06000BC6 RID: 3014 RVA: 0x0002AD3F File Offset: 0x00028F3F
	public string Method13406()
	{
		return this.xmlNode2.Value;
	}

	// Token: 0x06000BC7 RID: 3015 RVA: 0x0002AD4C File Offset: 0x00028F4C
	public void Method13407(string 1)
	{
		this.xmlNode2.Value = 1;
	}

	// Token: 0x06000BC8 RID: 3016 RVA: 0x0002AD5C File Offset: 0x00028F5C
	[242(1)]
	public 670 Method11617(670 1)
	{
		535 2 = (535)1;
		this.xmlNode2.AppendChild(2.xmlNode2);
		this.list = null;
		this.list2 = null;
		return 1;
	}

	// Token: 0x06000BC9 RID: 3017 RVA: 0x0002AD91 File Offset: 0x00028F91
	public string Method13409()
	{
		return this.xmlNode2.NamespaceURI;
	}

	// Token: 0x040005C6 RID: 1478
	[241(1)]
	private readonly XmlNode xmlNode2;

	// Token: 0x040005C7 RID: 1479
	[241(new byte[]
	{
		2,
		1
	})]
	private List<670> list;

	// Token: 0x040005C8 RID: 1480
	[241(new byte[]
	{
		2,
		1
	})]
	private List<670> list2;
}
