using System;

// Token: 0x0200061A RID: 1562
public sealed class 2418 : 2421
{
	// Token: 0x06002F87 RID: 12167 RVA: 0x0010CDAA File Offset: 0x0010AFAA
	internal 2418(2445 1, 2450 2) : base(1, 2)
	{
		base.2((2451)33);
	}

	// Token: 0x06002F88 RID: 12168 RVA: 0x0010CDBC File Offset: 0x0010AFBC
	internal override bool CaptureBackup()
	{
		2647 <<EMPTY_NAME>> = (2647)this.8[0];
		this.18 = <<EMPTY_NAME>>.7.17;
		this.19 = <<EMPTY_NAME>>.7.15;
		this.20 = <<EMPTY_NAME>>.7.6;
		return true;
	}

	// Token: 0x06002F89 RID: 12169 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool HasChanged()
	{
		return true;
	}

	// Token: 0x06002F8A RID: 12170 RVA: 0x0010CE10 File Offset: 0x0010B010
	internal override void Apply(2457 1)
	{
		2647 2 = (2647)this.8[0];
		2.7.17 = this.18;
		2.7.15 = this.19;
		2.7.6 = this.20;
		base.18(2);
	}

	// Token: 0x04002250 RID: 8784
	private new 208 18;

	// Token: 0x04002251 RID: 8785
	private new float 19;

	// Token: 0x04002252 RID: 8786
	private 198 20;
}
