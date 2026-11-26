using System;
using System.Collections.Generic;

// Token: 0x020005B7 RID: 1463
public sealed class 2349 : 2364
{
	// Token: 0x06002D85 RID: 11653 RVA: 0x0010118B File Offset: 0x000FF38B
	internal 2349()
	{
	}

	// Token: 0x06002D86 RID: 11654 RVA: 0x00101194 File Offset: 0x000FF394
	protected override void _0006_2000_2007_200B_2007_2009_200A_2004_2003_2006_200B_2009_200B_2006()
	{
		if (2263.4.6.13.Count > 0)
		{
			this.1.Add(new 2278((2341)1, 1568.1(2679.AITimingMania_NoManiaBreaktime)));
		}
		if (1272.5().13() == 2327.Easy)
		{
			List<1259> list = 1226.81().FindAll((1259 1) => 1.1 < 0.0 && 1.1 != -100.0);
			if (list.Count > 0 && 1272.5().87 / list.Count > 15000)
			{
				this.1.Add(new 2278((2341)1, 1568.1(2679.AITimingMania_TooManySpeedChanges)));
			}
		}
		base._0006_2000_2007_200B_2007_2009_200A_2004_2003_2006_200B_2009_200B_2006();
	}

	// Token: 0x020005B8 RID: 1464
	[Serializable]
	public sealed class 2350
	{
		// Token: 0x04002166 RID: 8550
		public static readonly 2349.2350 Instance = new 2349.2350();

		// Token: 0x04002167 RID: 8551
		public static Predicate<1259> predicate;
	}
}
