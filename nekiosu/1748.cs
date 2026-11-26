using System;

// Token: 0x020008E6 RID: 2278
public sealed class 1748 : 1689
{
	// Token: 0x06004112 RID: 16658 RVA: 0x00194084 File Offset: 0x00192284
	public 1748(2018 1) : base("Flashlight", true)
	{
		1748 <>4__this = this;
		float num = (float)1662.70.1() / 2f;
		this.7.12(new 1452("This is client side only: replays and scores stay the same", 14f, new 208(0f, this.3 - 30f), 208.Zero, 0.94f, true, 198.LightGray, true)
		{
			41 = (1376)7,
			49 = 1065.Centre
		});
		1452 5 = new 1452("Starting combo", 16f, new 208(num - 230f, this.3), 0.94f, true, 198.White);
		5.49 = 1065.CentreLeft;
		this.7.12(5);
		this.18 = new 1429(this.7, 0.0, 200.0, (double)1304.34.6(), new 208(num - 100f, this.3), 200);
		this.18.21 = 5.0;
		this.17.Add(this.18);
		this.18.18 = delegate(bool 1)
		{
			1304.34.7((int)Math.Round(<>4__this.18.7));
			<>4__this.12();
		};
		this.19 = new 1452(string.Empty, 16f, new 208(num + 115f, this.3), 0.94f, true, 198.White);
		this.19.49 = 1065.CentreLeft;
		this.7.12(this.19);
		this.12();
		this.3 += 35f;
		1364 3 = new 1364("Keep the flashlight size when the combo breaks", 0.8f, new 208(num - 230f, this.3 - 8f), 0.94f, 1304.35.1(), 0f);
		3.9(delegate(object 1, bool 2)
		{
			1304.35.2(2);
		});
		this.7.14<1433>(3.2);
		this.3 += 45f;
		base.7("Back", 198.Gray, null, true, false, true);
		base.3(delegate(object 1, EventArgs 2)
		{
			if (1662.78 == 1677.SelectPlay)
			{
				1662.25(new 1754(4));
			}
		});
	}

	// Token: 0x06004113 RID: 16659 RVA: 0x001942E8 File Offset: 0x001924E8
	private void 12()
	{
		int num = 1304.34.6();
		this.19.SetText((num == 0) ? "0 (default)" : num.ToString());
	}

	// Token: 0x06004114 RID: 16660 RVA: 0x0019431C File Offset: 0x0019251C
	public override void Update()
	{
		base.Update();
		bool flag = 1555.2() == 199.Pressed;
		if (!flag || !this.4)
		{
			this.20 = false;
		}
		else if (!this.21)
		{
			this.20 = this.18.25();
		}
		if (this.20)
		{
			this.18.27();
		}
		this.21 = flag;
	}

	// Token: 0x04002F96 RID: 12182
	private readonly 1429 18;

	// Token: 0x04002F97 RID: 12183
	private readonly 1452 19;

	// Token: 0x04002F98 RID: 12184
	private bool 20;

	// Token: 0x04002F99 RID: 12185
	private bool 21;
}
