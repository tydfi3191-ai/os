using System;
using System.Xml.Linq;

// Token: 0x02000093 RID: 147
[241(0)]
[242(2)]
public sealed class 518 : 984
{
	// Token: 0x1700001A RID: 26
	// (get) Token: 0x0600031E RID: 798 RVA: 0x000099D8 File Offset: 0x00007BD8
	[241(1)]
	private XText XText4723
	{
		[242(1)]
		get
		{
			return (XText)base.GetXmlNode5349_6752();
		}
	}

	// Token: 0x0600031F RID: 799 RVA: 0x000099E5 File Offset: 0x00007BE5
	[242(1)]
	public 518(XText 1) : base(1)
	{
	}

	// Token: 0x06000320 RID: 800 RVA: 0x000099EE File Offset: 0x00007BEE
	public override string Method13406()
	{
		return this.XText4723.Value;
	}

	// Token: 0x06000321 RID: 801 RVA: 0x000099FB File Offset: 0x00007BFB
	public override void Method13407(string 1)
	{
		this.XText4723.Value = (1 ?? string.Empty);
	}

	// Token: 0x06000322 RID: 802 RVA: 0x00009A12 File Offset: 0x00007C12
	public override 670 Method13410()
	{
		if (this.XText4723.Parent == null)
		{
			return null;
		}
		return 549.Method6996(this.XText4723.Parent);
	}
}
