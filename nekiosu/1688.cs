using System;

// Token: 0x02000913 RID: 2323
public sealed class 1688 : 1689
{
	// Token: 0x06004228 RID: 16936 RVA: 0x0019BDE4 File Offset: 0x00199FE4
	internal 1688(string 1, EventHandler 2, EventHandler 3 = null, bool 4 = true) : base(1, 4)
	{
		this.7.47 = true;
		base.7(1568.1(2679.General_Confirm), 198.YellowGreen, 2, true, false, true);
		base.7(1568.1(2679.General_Cancel), 198.OrangeRed, 3, true, false, true);
	}
}
