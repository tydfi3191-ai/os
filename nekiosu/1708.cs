using System;

// Token: 0x0200093C RID: 2364
internal sealed class 1708 : 1689
{
	// Token: 0x06004305 RID: 17157 RVA: 0x001A2E94 File Offset: 0x001A1094
	internal 1708() : base("Extra mods", true)
	{
		float num = (float)1662.70.1() / 2f - 230f;
		float num2 = this.3 - 20f;
		this.12("Random", 1304.14, num, num2);
		this.12("Mirror", 1304.15, num + 240f, num2);
		num2 += 24f;
		this.12("Difficulty Adjust", 1304.16, num, num2);
		this.12("No Notelock", 1304.17, num + 240f, num2);
		num2 += 24f;
		this.12("Alternate", 1304.18, num, num2);
		this.12("Single Tap", 1304.19, num + 240f, num2);
		num2 += 24f;
		this.12("Custom rate", 1304.20, num, num2);
		this.12("Practice", 1304.21, num + 240f, num2);
		this.3 = num2 + 40f;
		base.7("Back", 198.Gray, delegate(object 1, EventArgs 2)
		{
			1662.25(new 1710());
		}, true, false, true);
	}

	// Token: 0x06004306 RID: 17158 RVA: 0x001A2FD4 File Offset: 0x001A11D4
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
