using System;

// Token: 0x0200060D RID: 1549
public sealed class 2405 : 2421
{
	// Token: 0x06002F57 RID: 12119 RVA: 0x0010BD34 File Offset: 0x00109F34
	internal 2405(2445 1, 2450 2) : base(1, 2)
	{
		base.2((2451)7);
	}

	// Token: 0x06002F58 RID: 12120 RVA: 0x0010BD48 File Offset: 0x00109F48
	internal override bool CaptureBackup()
	{
		2647 <<EMPTY_NAME>> = (2647)this.8[0];
		this.18 = <<EMPTY_NAME>>.1;
		return true;
	}

	// Token: 0x06002F59 RID: 12121 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool HasChanged()
	{
		return true;
	}

	// Token: 0x06002F5A RID: 12122 RVA: 0x0010BD74 File Offset: 0x00109F74
	internal override void Apply(2457 1)
	{
		int 2 = ((2647)this.8[0]).1;
		int num = 2 - this.18;
		this.18 = 2;
		foreach (object obj in this.8)
		{
			2647 3 = (2647)obj;
			3.SetEndTime(3.1 - num);
		}
	}

	// Token: 0x0400223D RID: 8765
	private new int 18;
}
