using System;
using System.Collections.Generic;
using System.Xml.Linq;

// Token: 0x02000094 RID: 148
[241(0)]
[242(1)]
public class 549 : 984
{
	// Token: 0x06000323 RID: 803 RVA: 0x00009A33 File Offset: 0x00007C33
	[242(2)]
	[241(2)]
	public override 670 Method13410()
	{
		if (this.Method6993().Parent == null)
		{
			return null;
		}
		return 549.Method6996(this.Method6993().Parent);
	}

	// Token: 0x06000324 RID: 804 RVA: 0x000099E5 File Offset: 0x00007BE5
	public 549(XContainer 1) : base(1)
	{
	}

	// Token: 0x06000325 RID: 805 RVA: 0x00009A54 File Offset: 0x00007C54
	private XContainer Method6993()
	{
		return (XContainer)base.GetXmlNode5349_6752();
	}

	// Token: 0x06000326 RID: 806 RVA: 0x00009A64 File Offset: 0x00007C64
	public virtual List<670> Method11603()
	{
		if (this.list2 == null)
		{
			if (!this.Method11604())
			{
				this.list2 = 986.list4;
			}
			else
			{
				this.list2 = new List<670>();
				foreach (XNode <<EMPTY_NAME>> in this.Method6993().Nodes())
				{
					this.list2.Add(549.Method6996(<<EMPTY_NAME>>));
				}
			}
		}
		return this.list2;
	}

	// Token: 0x06000327 RID: 807 RVA: 0x00009AF0 File Offset: 0x00007CF0
	protected virtual bool Method11604()
	{
		return this.Method6993().LastNode != null;
	}

	// Token: 0x06000328 RID: 808 RVA: 0x00009B00 File Offset: 0x00007D00
	internal static 670 Method6996(XObject 1)
	{
		XDocument xdocument = 1 as XDocument;
		if (xdocument != null)
		{
			return new 81(xdocument);
		}
		XElement xelement = 1 as XElement;
		if (xelement != null)
		{
			return new 563(xelement);
		}
		XContainer xcontainer = 1 as XContainer;
		if (xcontainer != null)
		{
			return new 549(xcontainer);
		}
		XProcessingInstruction xprocessingInstruction = 1 as XProcessingInstruction;
		if (xprocessingInstruction != null)
		{
			return new 985(xprocessingInstruction);
		}
		XText xtext = 1 as XText;
		if (xtext != null)
		{
			return new 518(xtext);
		}
		XComment xcomment = 1 as XComment;
		if (xcomment != null)
		{
			return new 765(xcomment);
		}
		XAttribute xattribute = 1 as XAttribute;
		if (xattribute != null)
		{
			return new 799(xattribute);
		}
		XDocumentType xdocumentType = 1 as XDocumentType;
		if (xdocumentType != null)
		{
			return new 352(xdocumentType);
		}
		return new 984(1);
	}

	// Token: 0x06000329 RID: 809 RVA: 0x00009BA7 File Offset: 0x00007DA7
	public override 670 Method11617(670 1)
	{
		this.Method6993().Add(1.GetXmlNode5349_6752());
		this.list2 = null;
		return 1;
	}

	// Token: 0x04000362 RID: 866
	[241(new byte[]
	{
		2,
		1
	})]
	private List<670> list2;
}
