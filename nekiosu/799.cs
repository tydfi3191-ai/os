using System;
using System.Xml.Linq;

// Token: 0x02000097 RID: 151
[242(2)]
[241(0)]
public sealed class 799 : 984
{
	// Token: 0x1700001D RID: 29
	// (get) Token: 0x06000337 RID: 823 RVA: 0x00009C73 File Offset: 0x00007E73
	[241(1)]
	private XAttribute XAttribute10394
	{
		[242(1)]
		get
		{
			return (XAttribute)base.GetXmlNode5349_6752();
		}
	}

	// Token: 0x06000338 RID: 824 RVA: 0x000099E5 File Offset: 0x00007BE5
	[242(1)]
	public 799(XAttribute 1) : base(1)
	{
	}

	// Token: 0x06000339 RID: 825 RVA: 0x00009C80 File Offset: 0x00007E80
	public override string Method13406()
	{
		return this.XAttribute10394.Value;
	}

	// Token: 0x0600033A RID: 826 RVA: 0x00009C8D File Offset: 0x00007E8D
	public override void Method13407(string 1)
	{
		this.XAttribute10394.Value = (1 ?? string.Empty);
	}

	// Token: 0x0600033B RID: 827 RVA: 0x00009CA4 File Offset: 0x00007EA4
	public override string Method13408()
	{
		return this.XAttribute10394.Name.LocalName;
	}

	// Token: 0x0600033C RID: 828 RVA: 0x00009CB6 File Offset: 0x00007EB6
	public override string Method13409()
	{
		return this.XAttribute10394.Name.NamespaceName;
	}

	// Token: 0x0600033D RID: 829 RVA: 0x00009CC8 File Offset: 0x00007EC8
	public override 670 Method13410()
	{
		if (this.XAttribute10394.Parent == null)
		{
			return null;
		}
		return 549.Method6996(this.XAttribute10394.Parent);
	}
}
