using System;

// Token: 0x020008C7 RID: 2247
public sealed class 1782 : 1779
{
	// Token: 0x0600407E RID: 16510 RVA: 0x00190A28 File Offset: 0x0018EC28
	public 1782(2679 1, 1048 2 = 1048.circle)
	{
		this.13 = 2;
		base.10(2.ToString());
		base.10(1.ToString());
		this.14 = 1568.1(1);
		base.10(this.14);
		1452 3 = new 1452(this.14.ToUpper(), 24f, 208.Zero, 0f, true, 2630.16);
		3.16 = 0.4f;
		3.49 = 1065.TopRight;
		3.41 = (1376)8;
		3.63(false);
		this.16 = 3;
		this.1.12(this.16);
		base.3(new 208(0f, 10f));
		base.10(this.14);
	}

	// Token: 0x0600407F RID: 16511 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool IsHeader()
	{
		return true;
	}

	// Token: 0x06004080 RID: 16512 RVA: 0x00190B00 File Offset: 0x0018ED00
	public void 18(bool 1)
	{
		if (1 != this.15)
		{
			this.15 = 1;
			if (this.15)
			{
				this.16.FadeIn(100, (1046)0, 0);
				this.16.39(1045.2(2630.16, 0.4f), 100, false, (1046)0);
				return;
			}
			this.16.24(0.4f, 100, (1046)0);
			this.16.39(2630.16, 100, false, (1046)0);
		}
	}

	// Token: 0x04002F27 RID: 12071
	internal new 1048 13;

	// Token: 0x04002F28 RID: 12072
	internal new string 14;

	// Token: 0x04002F29 RID: 12073
	private new bool 15;

	// Token: 0x04002F2A RID: 12074
	private 1452 16;
}
