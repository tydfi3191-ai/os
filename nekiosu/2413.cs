using System;

// Token: 0x02000615 RID: 1557
public sealed class 2413 : 2421
{
	// Token: 0x06002F75 RID: 12149 RVA: 0x0010CB0E File Offset: 0x0010AD0E
	internal 2413(2445 1, 2450 2) : base(1, 2)
	{
		base.2((2451)35);
	}

	// Token: 0x06002F76 RID: 12150 RVA: 0x0010CB20 File Offset: 0x0010AD20
	internal override bool CaptureBackup()
	{
		2647 <<EMPTY_NAME>> = (2647)this.8[0];
		this.18 = <<EMPTY_NAME>>.7.49;
		return true;
	}

	// Token: 0x06002F77 RID: 12151 RVA: 0x0010CB51 File Offset: 0x0010AD51
	internal override bool HasChanged()
	{
		return ((2647)this.8[0]).7.49 != this.18;
	}

	// Token: 0x06002F78 RID: 12152 RVA: 0x0010CB7C File Offset: 0x0010AD7C
	internal override void Apply(2457 1)
	{
		2647 2 = (2647)this.8[0];
		1065 3 = 2.7.49;
		2.7.49 = this.18;
		this.18 = 3;
		2.7.UpdateOriginOffset();
		base.18(2);
	}

	// Token: 0x04002249 RID: 8777
	private new 1065 18;
}
