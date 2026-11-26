using System;
using System.Globalization;
using System.Runtime.InteropServices;

// Token: 0x020006CA RID: 1738
[ComVisible(false)]
public static class 2148
{
	// Token: 0x060033A6 RID: 13222 RVA: 0x0013C908 File Offset: 0x0013AB08
	public static string 1(2147 1)
	{
		string result;
		switch (1)
		{
		case 2147.Taiko:
			result = "osu!taiko";
			break;
		case 2147.CatchTheBeat:
			result = "osu!catch";
			break;
		case 2147.OsuMania:
			result = "osu!mania";
			break;
		default:
			result = "osu!";
			break;
		}
		return result;
	}

	// Token: 0x04002692 RID: 9874
	public static NumberFormatInfo 1 = new CultureInfo("en-US", false).NumberFormat;

	// Token: 0x04002693 RID: 9875
	public static int 2 = 0;

	// Token: 0x04002694 RID: 9876
	public static bool 3 = false;
}
