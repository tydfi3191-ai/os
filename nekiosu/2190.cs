using System;

// Token: 0x020006D7 RID: 1751
public sealed class 2190 : 2541
{
	// Token: 0x06003408 RID: 13320 RVA: 0x0013F5D0 File Offset: 0x0013D7D0
	internal 2190(1436 1) : base(1)
	{
		1353 2 = this.3;
		2.17.Y = 2.17.Y + this.9.Y * 0.8f;
	}

	// Token: 0x06003409 RID: 13321 RVA: 0x0013F600 File Offset: 0x0013D800
	internal override void SetScore(int 1)
	{
		int num = 1 - this.6;
		if (num > 0)
		{
			208 2 = new 208(10f, this.2.17.Y + this.9.Y);
			1353 3 = new 1353(num.ToString(), 2630.5.FontScore, (float)2630.5.FontScoreOverlap, this.3.41, 1065.TopRight, (1044)0, 2, 0.95f, false, 198.Red, true, (1416)7);
			3.15 = this.10 * 0.8f;
			this.1.12(3);
			3.15(60);
			3.3.Add(new 1445(2 + new 208((float)(1196.8(0.5) ? 10 : -10), 0f), 2, 1662.33, 1662.33 + 100, (1046)1));
			3.3.Add(new 1445(2, 2 + new 208(0f, -30f), 1662.33 + 300, 1662.33 + 420, (1046)2));
			3.3.Add(new 1445(1456.Fade, 1f, 0f, 1662.33 + 300, 1662.33 + 420, (1046)2));
		}
		base.SetScore(1);
	}
}
