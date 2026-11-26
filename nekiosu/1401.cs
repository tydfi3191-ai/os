using System;

// Token: 0x02000AA2 RID: 2722
public sealed class 1401 : 1380
{
	// Token: 0x06004B84 RID: 19332 RVA: 0x001DE6EC File Offset: 0x001DC8EC
	internal 1401(1436 1, 208 2) : base(1, 1409.Pie, 34f)
	{
		this.9 = 2;
		this.17 = new 1433(1455.2("circularmetre", (1416)1, null), (1376)8, 1065.Centre, (1044)0, 2, 0.95f, true, 198.White, null);
		base.1(this.17);
		this.18.3 = new 208((float)1662.70.1 / 1662.70.3() - 2.X, 2.Y);
		this.18.6 = 10f;
	}

	// Token: 0x06004B85 RID: 19333 RVA: 0x001DE790 File Offset: 0x001DC990
	internal override void Draw()
	{
		2528 <<EMPTY_NAME>> = this.17.18;
		float windowWidth = 2528.WindowWidth;
		208 2 = new 208(windowWidth - this.9.X, this.9.Y);
		if (<<EMPTY_NAME>> != null && !<<EMPTY_NAME>>.11 && !2528.2)
		{
			return;
		}
		this.18.3 = ((<<EMPTY_NAME>> == null) ? 2 : <<EMPTY_NAME>>.38(2, windowWidth, 480f));
		float num = (<<EMPTY_NAME>> != null) ? <<EMPTY_NAME>>.1(this.10) : this.10.5;
		this.18.6 = 10f * ((<<EMPTY_NAME>> != null) ? <<EMPTY_NAME>>.10 : 1f);
		this.18.5 = ((this.18.8 < 0f) ? new 198(199, byte.MaxValue, 47, (byte)((double)(num * (float)this.17.30.A) * 0.6)) : new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, (byte)((double)(num * (float)this.17.30.A) * 0.6)));
		if (<<EMPTY_NAME>> != null && <<EMPTY_NAME>>.19 != 198.White)
		{
			this.18.5 = new 198(this.18.5.R * <<EMPTY_NAME>>.19.R / byte.MaxValue, this.18.5.G * <<EMPTY_NAME>>.19.G / byte.MaxValue, this.18.5.B * <<EMPTY_NAME>>.19.B / byte.MaxValue, this.18.5.A);
		}
		this.18.Update();
		this.18.Draw();
	}

	// Token: 0x06004B86 RID: 19334 RVA: 0x001DE979 File Offset: 0x001DCB79
	internal override void SetProgress(float 1)
	{
		this.18.8 = 1;
	}

	// Token: 0x04003849 RID: 14409
	private 1433 17;

	// Token: 0x0400384A RID: 14410
	private 1408 18 = new 1408();
}
