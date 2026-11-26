using System;

// Token: 0x020006FF RID: 1791
[276]
public static class 2138
{
	// Token: 0x17000285 RID: 645
	// (get) Token: 0x060034DC RID: 13532 RVA: 0x00145119 File Offset: 0x00143319
	public static bool UsesLazerNoteLock
	{
		get
		{
			return 2486.88 != null && 2486.88.45;
		}
	}

	// Token: 0x060034DD RID: 13533 RVA: 0x0014512E File Offset: 0x0014332E
	public static 2032 1(2039 1, 2034 2)
	{
		if (!2138.UsesLazerNoteLock)
		{
			return 2138.2(1, 2);
		}
		return 2138.3(1, 2);
	}

	// Token: 0x060034DE RID: 13534 RVA: 0x00145148 File Offset: 0x00143348
	private static 2032 2(2039 1, 2034 2)
	{
		if (2.HasObjectType(2047.Normal))
		{
			int num = 1.36.IndexOf(2);
			if (num > 0)
			{
				2034 3 = 1.36[num - 1];
				if (3.9 > 0 && 3.IsActive() && !3.11)
				{
					return (2032)0;
				}
			}
		}
		foreach (2034 4 in 1.36)
		{
			if (!4.11)
			{
				if (4 == 2)
				{
					break;
				}
				if (4.2 + 3 < 2.1)
				{
					return (2032)1;
				}
			}
		}
		int num2 = 400 - (2486.22 ? 200 : 0);
		if (Math.Abs(2.1 - 1226.16) < num2)
		{
			return (2032)2;
		}
		return (2032)1;
	}

	// Token: 0x060034DF RID: 13535 RVA: 0x00145230 File Offset: 0x00143430
	private static 2032 3(2039 1, 2034 2)
	{
		2034 3 = 2138.6(1, 2);
		if (3 != null && !2138.9(3) && 1226.16 < 3.1)
		{
			return (2032)1;
		}
		if (Math.Abs(2.1 - 1226.16) <= 400)
		{
			return (2032)2;
		}
		return (2032)1;
	}

	// Token: 0x060034E0 RID: 13536 RVA: 0x0014527C File Offset: 0x0014347C
	public static void 4(2039 1, 2034 2)
	{
		if (!2138.UsesLazerNoteLock || !2138.8(2))
		{
			return;
		}
		foreach (2034 3 in 1.36.ToArray())
		{
			if (3.1 < 2.1 && 2138.8(3) && 2138.7(1, 3) && !2138.9(3))
			{
				2123 4 = 3 as 2123;
				2033 5 = (4 != null) ? 4.58 : (3 as 2033);
				if (5 != null)
				{
					5.43 = true;
					1.JudgeHitObject(5);
				}
			}
		}
	}

	// Token: 0x060034E1 RID: 13537 RVA: 0x0014530C File Offset: 0x0014350C
	public static 2034 5(2039 1, 208 2, float 3)
	{
		if (!2138.UsesLazerNoteLock)
		{
			return 1.65(2.X, 2.Y, true, 3);
		}
		bool flag = !1535.1();
		foreach (2034 4 in 1.36)
		{
			if (2138.8(4) && !2138.9(4) && (!flag || 4.39) && 4.HitTest(2, true, 3))
			{
				return 4;
			}
		}
		return null;
	}

	// Token: 0x060034E2 RID: 13538 RVA: 0x001453AC File Offset: 0x001435AC
	private static 2034 6(2039 1, 2034 2)
	{
		2034 result = null;
		foreach (2034 3 in 1.36)
		{
			if (3.1 >= 2.1)
			{
				break;
			}
			if (2138.8(3) && 2138.7(1, 3))
			{
				result = 3;
			}
		}
		return result;
	}

	// Token: 0x060034E3 RID: 13539 RVA: 0x00145420 File Offset: 0x00143620
	private static bool 7(2039 1, 2034 2)
	{
		return 1226.16 >= 2.1 - 1.2;
	}

	// Token: 0x060034E4 RID: 13540 RVA: 0x00145439 File Offset: 0x00143639
	private static bool 8(2034 1)
	{
		return 1.HasObjectType(2047.Normal) || 1.HasObjectType(2047.Slider);
	}

	// Token: 0x060034E5 RID: 13541 RVA: 0x00145450 File Offset: 0x00143650
	private static bool 9(2034 1)
	{
		2123 2 = 1 as 2123;
		if (2 == null)
		{
			return 1.11;
		}
		return 2.IsHeadJudged();
	}

	// Token: 0x04002738 RID: 10040
	private const 2032 1 = (2032)0;

	// Token: 0x04002739 RID: 10041
	private const 2032 2 = (2032)1;

	// Token: 0x0400273A RID: 10042
	private const 2032 3 = (2032)2;

	// Token: 0x0400273B RID: 10043
	private const int 4 = 400;
}
