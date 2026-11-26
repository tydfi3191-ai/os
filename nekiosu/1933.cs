using System;
using System.Globalization;

// Token: 0x02000839 RID: 2105
public static class 1933
{
	// Token: 0x170002CA RID: 714
	// (get) Token: 0x06003D22 RID: 15650 RVA: 0x00181E61 File Offset: 0x00180061
	public static bool Enabled
	{
		get
		{
			return 1933.5;
		}
	}

	// Token: 0x170002CB RID: 715
	// (get) Token: 0x06003D23 RID: 15651 RVA: 0x00181E68 File Offset: 0x00180068
	public static double Semitones
	{
		get
		{
			return 1933.6;
		}
	}

	// Token: 0x06003D24 RID: 15652 RVA: 0x00181E6F File Offset: 0x0018006F
	public static void 1(bool 1)
	{
		if (1933.5 != 1)
		{
			1933.5 = 1;
			2019.3();
		}
	}

	// Token: 0x06003D25 RID: 15653 RVA: 0x00181E84 File Offset: 0x00180084
	public static void 2(double 1)
	{
		double num = Math.Round(Math.Max(-12.0, Math.Min(12.0, 1)) / 0.5) * 0.5;
		if (Math.Abs(num - 1933.6) > 0.001)
		{
			1933.6 = num;
			2019.3();
		}
	}

	// Token: 0x170002CC RID: 716
	// (get) Token: 0x06003D26 RID: 15654 RVA: 0x00181EEA File Offset: 0x001800EA
	public static float Current
	{
		get
		{
			if (!1933.5)
			{
				return 0f;
			}
			return (float)1933.6;
		}
	}

	// Token: 0x06003D27 RID: 15655 RVA: 0x00181EFF File Offset: 0x001800FF
	public static string 3(double 1)
	{
		return ((1 > 0.0) ? "+" : string.Empty) + 1.ToString("0.#", CultureInfo.InvariantCulture);
	}

	// Token: 0x04002D0C RID: 11532
	public const double 1 = -12.0;

	// Token: 0x04002D0D RID: 11533
	public const double 2 = 12.0;

	// Token: 0x04002D0E RID: 11534
	public const double 3 = 0.5;

	// Token: 0x04002D0F RID: 11535
	public const double 4 = 2.0;

	// Token: 0x04002D10 RID: 11536
	private static bool 5;

	// Token: 0x04002D11 RID: 11537
	private static double 6 = 2.0;
}
