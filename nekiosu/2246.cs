using System;

// Token: 0x020006C0 RID: 1728
[276]
public static class 2246
{
	// Token: 0x06003381 RID: 13185 RVA: 0x0013B358 File Offset: 0x00139558
	internal static 2241 Create(2147 1, string 2, 1262 3, bool 4)
	{
		2241 5;
		switch (1)
		{
		case 2147.Taiko:
			5 = new 2191(3, 2);
			break;
		case 2147.CatchTheBeat:
			5 = new 1877(3, 2);
			break;
		case 2147.OsuMania:
			5 = new 1986(3, 2);
			break;
		default:
			5 = ((!2486.16()) ? new 2241(3, 2) : new 2136(3, 2));
			break;
		}
		2241 6 = 5;
		if (4)
		{
			2246.2(6);
		}
		return 6;
	}

	// Token: 0x06003382 RID: 13186 RVA: 0x0013B3C0 File Offset: 0x001395C0
	public static 2241 Create(2147 1, 2247 2, string 3)
	{
		2241 4;
		switch (1)
		{
		case 2147.Taiko:
			4 = new 2191(2, 3);
			break;
		case 2147.CatchTheBeat:
			4 = new 1877(2, 3);
			break;
		case 2147.OsuMania:
			4 = new 1986(2, 3);
			break;
		default:
			4 = new 2241(2, 3);
			break;
		}
		2241 5 = 4;
		if (2.16)
		{
			2246.2(5);
		}
		return 5;
	}

	// Token: 0x06003383 RID: 13187 RVA: 0x0013B41C File Offset: 0x0013961C
	public static 2241 1(2147 1, string 2, 1262 3)
	{
		2241 result;
		switch (1)
		{
		case 2147.Taiko:
			result = new 2191(2, 3);
			break;
		case 2147.CatchTheBeat:
			result = new 1877(2, 3);
			break;
		case 2147.OsuMania:
			result = new 1986(2, 3);
			break;
		default:
			result = new 2241(2, 3);
			break;
		}
		return result;
	}

	// Token: 0x06003384 RID: 13188 RVA: 0x0013B468 File Offset: 0x00139668
	private static void 2(2241 1)
	{
		switch (1.9)
		{
		case 2147.Osu:
			1.39 = new 2135(1);
			return;
		case 2147.Taiko:
			1.39 = new 2192(1);
			return;
		case 2147.CatchTheBeat:
			1.39 = new 1878(1);
			return;
		case 2147.OsuMania:
			1.39 = new 1987(1);
			return;
		default:
			return;
		}
	}
}
