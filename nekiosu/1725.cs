using System;

// Token: 0x02000968 RID: 2408
public sealed class 1725 : 1689
{
	// Token: 0x060043D9 RID: 17369 RVA: 0x001AB78C File Offset: 0x001A998C
	internal 1725(2241 1) : base(1568.1(2679.ScoreDialog_ScoreManagement), false)
	{
		this.18 = 3;
		if (!this.18.12)
		{
			base.7(1568.1(2679.ScoreDialog_DeleteScore), 198.YellowGreen, new EventHandler(this.12), true, false, true);
			base.7(1568.1(2679.ScoreDialog_ExportReplay), 198.LightBlue, delegate(object 1, EventArgs 2)
			{
				this.18.27();
				2230.20(this.18, true);
			}, true, false, true);
		}
		base.7("Use these mods", 198.Orange, delegate(object 1, EventArgs 2)
		{
			2023 4 = 2019.1;
			2019.6(this.18);
			2601 5 = 1662.79 as 2601;
			if (5 == null)
			{
				return;
			}
			5.52(4);
		}, true, false, true);
		base.7(1568.1(2679.General_Close), 198.Gray, null, true, false, true);
	}

	// Token: 0x060043DA RID: 17370 RVA: 0x001AB842 File Offset: 0x001A9A42
	private void 12(object 1, EventArgs 2)
	{
		2230.22(1272.5().23, this.18.4(), false);
		if (1662.79 is 2601)
		{
			((2601)1662.79).54(false);
		}
	}

	// Token: 0x040031C0 RID: 12736
	private 2241 18;
}
