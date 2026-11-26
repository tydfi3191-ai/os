using System;
using System.Collections.Generic;
using System.Xml.Linq;

// Token: 0x02000161 RID: 353
[242(1)]
[241(0)]
public sealed class 563 : 549, 613, 670
{
	// Token: 0x06000C15 RID: 3093 RVA: 0x0002BD27 File Offset: 0x00029F27
	[242(2)]
	[241(2)]
	public override string Method13406()
	{
		return this.Method7756().Value;
	}

	// Token: 0x06000C16 RID: 3094 RVA: 0x0002BD34 File Offset: 0x00029F34
	[242(2)]
	[241(2)]
	public override void Method13407(string 1)
	{
		this.Method7756().Value = (1 ?? string.Empty);
	}

	// Token: 0x06000C17 RID: 3095 RVA: 0x0002BD4B File Offset: 0x00029F4B
	[242(2)]
	[241(2)]
	public override string Method13408()
	{
		return this.Method7756().Name.LocalName;
	}

	// Token: 0x06000C18 RID: 3096 RVA: 0x0002BD5D File Offset: 0x00029F5D
	[242(2)]
	[241(2)]
	public override string Method13409()
	{
		return this.Method7756().Name.NamespaceName;
	}

	// Token: 0x06000C19 RID: 3097 RVA: 0x0000982C File Offset: 0x00007A2C
	public 563(XElement 1) : base(1)
	{
	}

	// Token: 0x06000C1A RID: 3098 RVA: 0x0002BD6F File Offset: 0x00029F6F
	private XElement Method7756()
	{
		return (XElement)base.GetXmlNode5349_6752();
	}

	// Token: 0x06000C1B RID: 3099 RVA: 0x0002BD7C File Offset: 0x00029F7C
	public void Method7757(670 1)
	{
		984 2 = (984)1;
		this.Method7756().Add(2.GetXmlNode5349_6752());
		this.list = null;
	}

	// Token: 0x06000C1C RID: 3100 RVA: 0x0002BDA8 File Offset: 0x00029FA8
	public List<670> Method7758()
	{
		if (this.list == null)
		{
			if (!this.Method7756().HasAttributes && !this.Method7759(this.Method13409()))
			{
				this.list = 986.list4;
			}
			else
			{
				this.list = new List<670>();
				foreach (XAttribute <<EMPTY_NAME>> in this.Method7756().Attributes())
				{
					this.list.Add(new 799(<<EMPTY_NAME>>));
				}
				string text = this.Method13409();
				if (this.Method7759(text))
				{
					this.list.Insert(0, new 799(new XAttribute("xmlns", text)));
				}
			}
		}
		return this.list;
	}

	// Token: 0x06000C1D RID: 3101 RVA: 0x0002BE7C File Offset: 0x0002A07C
	private bool Method7759(string 1)
	{
		if (!538.Method6824(1))
		{
			670 2 = this.Method13410();
			if (1 != ((2 != null) ? 2.Method13409() : null) && 538.Method6824(this.Method7761(1)))
			{
				bool flag = false;
				if (this.Method7756().HasAttributes)
				{
					foreach (XAttribute xattribute in this.Method7756().Attributes())
					{
						if (xattribute.Name.LocalName == "xmlns" && 538.Method6824(xattribute.Name.NamespaceName) && xattribute.Value == 1)
						{
							flag = true;
						}
					}
				}
				if (!flag)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06000C1E RID: 3102 RVA: 0x0002BF4C File Offset: 0x0002A14C
	public override 670 Method11617(670 1)
	{
		670 result = base.Method11617(1);
		this.list = null;
		return result;
	}

	// Token: 0x06000C1F RID: 3103 RVA: 0x0002BF5C File Offset: 0x0002A15C
	[return: 241(2)]
	public string Method7761(string 1)
	{
		return this.Method7756().GetPrefixOfNamespace(1);
	}

	// Token: 0x06000C20 RID: 3104 RVA: 0x0002BF6F File Offset: 0x0002A16F
	public bool Method7762()
	{
		return this.Method7756().IsEmpty;
	}

	// Token: 0x040005F0 RID: 1520
	[241(new byte[]
	{
		2,
		1
	})]
	private List<670> list;
}
