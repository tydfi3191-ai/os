using System;

// Token: 0x020008E9 RID: 2281
public sealed class 1749 : 1689
{
	// Token: 0x0600411B RID: 16667 RVA: 0x001943E0 File Offset: 0x001925E0
	public 1749(2018 1) : base("Hidden", true)
	{
		float num = (float)1662.70.1() / 2f;
		this.7.12(new 1452("Play with no approach circles and fading circles/sliders.", 14f, new 208(0f, this.3 - 30f), 208.Zero, 0.94f, true, 198.LightGray, true)
		{
			41 = (1376)7,
			49 = 1065.Centre
		});
		1364 4 = new 1364("Only fade approach circles", 0.8f, new 208(num - 230f, this.3 - 8f), 0.94f, 1304.63.1(), 0f);
		4.9(delegate(object 1, bool 2)
		{
			1304.63.2(2);
			2019.3();
		});
		this.7.14<1433>(4.2);
		this.3 += 45f;
		base.7("Back", 198.Gray, null, true, false, true);
		base.3(delegate(object 1, EventArgs 2)
		{
			if (1662.78 == 1677.SelectPlay)
			{
				1662.25(new 1754(3));
			}
		});
	}
}
