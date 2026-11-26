using System;

// Token: 0x02000612 RID: 1554
public sealed class 2410 : 2421
{
	// Token: 0x06002F6A RID: 12138 RVA: 0x0010C956 File Offset: 0x0010AB56
	internal 2410(2445 1, 2450 2) : base(1, 2)
	{
		base.2((2451)24);
	}

	// Token: 0x06002F6B RID: 12139 RVA: 0x0010C968 File Offset: 0x0010AB68
	internal override bool CaptureBackup()
	{
		2647 <<EMPTY_NAME>> = (2647)this.8[0];
		if (base.13((2450)1))
		{
			this.18 = <<EMPTY_NAME>>.7.44();
		}
		else
		{
			if (!base.13((2450)2))
			{
				throw new NotImplementedException();
			}
			this.19 = <<EMPTY_NAME>>.7.42();
		}
		return true;
	}

	// Token: 0x06002F6C RID: 12140 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool HasChanged()
	{
		return true;
	}

	// Token: 0x06002F6D RID: 12141 RVA: 0x0010C9C4 File Offset: 0x0010ABC4
	internal override void Apply(2457 1)
	{
		2647 2 = (2647)this.8[0];
		if (base.13((2450)1))
		{
			2.7.45(this.18);
		}
		else if (base.13((2450)2))
		{
			2.7.43(this.19);
		}
		base.18(2);
	}

	// Token: 0x04002245 RID: 8773
	private new bool 18;

	// Token: 0x04002246 RID: 8774
	private new bool 19;
}
