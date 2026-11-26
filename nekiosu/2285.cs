using System;
using System.Collections.Generic;

// Token: 0x02000651 RID: 1617
public sealed class 2285 : 2364
{
	// Token: 0x06003162 RID: 12642 RVA: 0x0012767C File Offset: 0x0012587C
	protected override void _0006_2000_2007_200B_2007_2009_200A_2004_2003_2006_200B_2009_200B_2006()
	{
		2648 <<EMPTY_NAME>> = 2263.4.6;
		List<1259> list = 1226.81().FindAll((1259 1) => 1.3());
		for (int i = 0; i < list.Count; i++)
		{
			if (i < list.Count - 1 && list[i + 1].3 - list[i].3 < 1226.88(list[i].3, false) * 4.0)
			{
				this.1.Add(new 2278((2341)2, 1568.1(2679.AITimingTaiko_KiaiToggledTooOften)));
			}
		}
		base._0006_2000_2007_200B_2007_2009_200A_2004_2003_2006_200B_2009_200B_2006();
	}

	// Token: 0x02000652 RID: 1618
	[Serializable]
	public sealed class 2286
	{
		// Token: 0x04002463 RID: 9315
		public static readonly 2285.2286 instance = new 2285.2286();

		// Token: 0x04002464 RID: 9316
		public static Predicate<1259> predicate;
	}
}
