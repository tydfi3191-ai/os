using System;
using System.Xml.Linq;

// Token: 0x02000096 RID: 150
[242(2)]
[241(0)]
public sealed class 765 : 984
{
	// Token: 0x1700001C RID: 28
	// (get) Token: 0x06000332 RID: 818 RVA: 0x00009C21 File Offset: 0x00007E21
	[241(1)]
	private XComment XComment9652
	{
		[242(1)]
		get
		{
			return (XComment)base.GetXmlNode5349_6752();
		}
	}

	// Token: 0x06000333 RID: 819 RVA: 0x000099E5 File Offset: 0x00007BE5
	[242(1)]
	public 765(XComment 1) : base(1)
	{
	}

	// Token: 0x06000334 RID: 820 RVA: 0x00009C2E File Offset: 0x00007E2E
	public override string Method13406()
	{
		return this.XComment9652.Value;
	}

	// Token: 0x06000335 RID: 821 RVA: 0x00009C3B File Offset: 0x00007E3B
	public override void Method13407(string 1)
	{
		this.XComment9652.Value = (1 ?? string.Empty);
	}

	// Token: 0x06000336 RID: 822 RVA: 0x00009C52 File Offset: 0x00007E52
	public override 670 Method13410()
	{
		if (this.XComment9652.Parent == null)
		{
			return null;
		}
		return 549.Method6996(this.XComment9652.Parent);
	}
}
