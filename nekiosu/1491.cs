using System;

// Token: 0x02000B0B RID: 2827
public sealed class 1491 : 2535
{
	// Token: 0x06004EA3 RID: 20131 RVA: 0x001F1670 File Offset: 0x001EF870
	public 1491(1784 1) : base(true)
	{
		1491.1492 optionsToggleHandler = new 1491.1492
		{
			1 = 8
		};
		1436 9 = this.1;
		1433 3 = new 1433(1455.2("back-button-layer", (1416)1, null), (1376)9, 1065.CentreLeft, (1044)0, 208.Zero, 0.91f, true, this.5, null)
		{
			36 = 120
		};
		1433 4 = 3;
		this.3 = 3;
		9.12(4);
		1436 5 = this.1;
		1386 6 = new 1386(1048.gear, 18f, new 208(10f, 0f))
		{
			2 = 0.92f,
			41 = (1376)9,
			49 = 1065.Centre
		};
		1386 7 = 6;
		this.4 = 6;
		5.12(7);
		this.3.10 = true;
		this.3.3(delegate(object 1, EventArgs 2)
		{
			optionsToggleHandler.1.25();
		});
		this.1.24 = true;
	}

	// Token: 0x04003A9F RID: 15007
	private 1433 3;

	// Token: 0x04003AA0 RID: 15008
	private 1386 4;

	// Token: 0x04003AA1 RID: 15009
	private 198 5 = new 198(238, 51, 153);

	// Token: 0x02000B0C RID: 2828
	public sealed class 1492
	{
		// Token: 0x06004EA4 RID: 20132 RVA: 0x001F1777 File Offset: 0x001EF977
		internal void 1(object 1, EventArgs 2)
		{
			this.1.25();
		}

		// Token: 0x04003AA2 RID: 15010
		public 1784 1;
	}
}
