using System;

// Token: 0x0200060B RID: 1547
public sealed class 2403 : 2421
{
	// Token: 0x06002F4E RID: 12110 RVA: 0x0010BBB0 File Offset: 0x00109DB0
	internal 2403(2445 1, 2450 2) : base(1, 2)
	{
		base.2((2451)34);
	}

	// Token: 0x06002F4F RID: 12111 RVA: 0x0010BBC2 File Offset: 0x00109DC2
	internal override bool CaptureBackup()
	{
		2647 <<EMPTY_NAME>> = (2647)this.8[0];
		this.13.ForEach(new Action<1445>(this.20));
		return true;
	}

	// Token: 0x06002F50 RID: 12112 RVA: 0x0010BBEE File Offset: 0x00109DEE
	internal override bool HasChanged()
	{
		return this.13.Count > 0;
	}

	// Token: 0x06002F51 RID: 12113 RVA: 0x0010BC00 File Offset: 0x00109E00
	internal override void Apply(2457 1)
	{
		2647 2 = (2647)this.8[0];
		1445 3 = this.13[0];
		1046 4 = 3.15;
		3.15 = this.18;
		this.18 = 4;
		base.18(2);
	}

	// Token: 0x06002F52 RID: 12114 RVA: 0x0010BC4B File Offset: 0x00109E4B
	private void 20(1445 1)
	{
		this.18 = 1.15;
	}

	// Token: 0x0400223C RID: 8764
	private new 1046 18;
}
