using System;
using System.Xml.Linq;

// Token: 0x0200020B RID: 523
[241(0)]
[242(2)]
public sealed class 985 : 984
{
	// Token: 0x170000DB RID: 219
	// (get) Token: 0x0600107D RID: 4221 RVA: 0x00038ACF File Offset: 0x00036CCF
	[241(1)]
	private XProcessingInstruction ProcessingInstruction
	{
		[242(1)]
		get
		{
			return (XProcessingInstruction)base.GetXmlNode5349_6752();
		}
	}

	// Token: 0x0600107E RID: 4222 RVA: 0x000099E5 File Offset: 0x00007BE5
	[242(1)]
	public 985(XProcessingInstruction 1) : base(1)
	{
	}

	// Token: 0x0600107F RID: 4223 RVA: 0x00038ADC File Offset: 0x00036CDC
	public override string Method13408()
	{
		return this.ProcessingInstruction.Target;
	}

	// Token: 0x06001080 RID: 4224 RVA: 0x00038AE9 File Offset: 0x00036CE9
	public override string Method13406()
	{
		return this.ProcessingInstruction.Data;
	}

	// Token: 0x06001081 RID: 4225 RVA: 0x00038AF6 File Offset: 0x00036CF6
	public override void Method13407(string 1)
	{
		this.ProcessingInstruction.Data = (1 ?? string.Empty);
	}
}
