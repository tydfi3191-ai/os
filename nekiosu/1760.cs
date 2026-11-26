using System;

// Token: 0x020008FF RID: 2303
public sealed class 1760 : 1689
{
	// Token: 0x060041AE RID: 16814 RVA: 0x00198140 File Offset: 0x00196340
	public 1760(2018 1) : base("Relax", true)
	{
		float 4 = (float)1662.70.1() / 2f - 230f;
		float num = this.3 - 20f;
		this.7.12(new 1452("Client side only: replays and scores stay the same (except the last two)", 14f, new 208(0f, num - 10f), 208.Zero, 0.94f, true, 198.LightGray, true)
		{
			41 = (1376)7,
			49 = 1065.Centre
		});
		num += 20f;
		this.12("Show misses", 1304.29, 4, num);
		num += 24f;
		this.12("Combo break sound", 1304.30, 4, num);
		num += 24f;
		this.12("Save scores to the local rankings", 1304.31, 4, num);
		num += 24f;
		this.12("Allow failing", 1304.32, 4, num);
		num += 24f;
		this.12("Hit on time (no 12 ms early offset)", 1304.33, 4, num);
		num += 24f;
		this.12("Normal score multiplier (not 0x)", 1304.28, 4, num);
		this.3 = num + 40f;
		base.7("Back", 198.Gray, null, true, false, true);
		base.3(delegate(object 1, EventArgs 2)
		{
			if (1662.78 == 1677.SelectPlay)
			{
				1662.25(new 1754(3));
			}
		});
	}

	// Token: 0x060041AF RID: 16815 RVA: 0x001982A8 File Offset: 0x001964A8
	private void 12(string 1, 1313 2, float 3, float 4)
	{
		1364 5 = new 1364(6, 0.8f, new 208(3, 4), 0.94f, 7.1(), 0f);
		5.9(delegate(object 1, bool 2)
		{
			7.2(2);
		});
		this.7.14<1433>(5.2);
	}
}
