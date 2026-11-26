using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;

// Token: 0x02000098 RID: 152
[242(2)]
[241(0)]
public class 984 : 670
{
	// Token: 0x1700001E RID: 30
	// (get) Token: 0x0600033E RID: 830 RVA: 0x00009CE9 File Offset: 0x00007EE9
	[241(1)]
	public virtual List<670> List5352
	{
		[242(1)]
		get
		{
			return 986.list4;
		}
	}

	// Token: 0x1700001F RID: 31
	// (get) Token: 0x0600033F RID: 831 RVA: 0x00009CE9 File Offset: 0x00007EE9
	[241(1)]
	public virtual List<670> List5353
	{
		[242(1)]
		get
		{
			return 986.list4;
		}
	}

	// Token: 0x06000340 RID: 832 RVA: 0x00009CF0 File Offset: 0x00007EF0
	public 984(XObject 1)
	{
		this.xmlObject = 1;
	}

	// Token: 0x06000341 RID: 833 RVA: 0x00009CFF File Offset: 0x00007EFF
	public object GetXmlNode5349_6752()
	{
		return this.xmlObject;
	}

	// Token: 0x06000342 RID: 834 RVA: 0x00009D07 File Offset: 0x00007F07
	public virtual XmlNodeType GetXmlDeclaration_11618()
	{
		XObject xobject = this.xmlObject;
		if (xobject == null)
		{
			return XmlNodeType.None;
		}
		return xobject.NodeType;
	}

	// Token: 0x06000343 RID: 835 RVA: 0x00009D1A File Offset: 0x00007F1A
	public virtual string Method13408()
	{
		return null;
	}

	// Token: 0x06000344 RID: 836 RVA: 0x00009D1A File Offset: 0x00007F1A
	public virtual 670 Method13410()
	{
		return null;
	}

	// Token: 0x06000345 RID: 837 RVA: 0x00009D1A File Offset: 0x00007F1A
	public virtual string Method13406()
	{
		return null;
	}

	// Token: 0x06000346 RID: 838 RVA: 0x00009D1D File Offset: 0x00007F1D
	public virtual void Method13407(string 1)
	{
		throw new InvalidOperationException();
	}

	// Token: 0x06000347 RID: 839 RVA: 0x00009D1D File Offset: 0x00007F1D
	[242(1)]
	public virtual 670 Method11617(670 1)
	{
		throw new InvalidOperationException();
	}

	// Token: 0x06000348 RID: 840 RVA: 0x00009D1A File Offset: 0x00007F1A
	public virtual string Method13409()
	{
		return null;
	}

	// Token: 0x04000364 RID: 868
	private readonly XObject xmlObject;
}
