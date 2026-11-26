using System;

// Token: 0x0200054E RID: 1358
[276]
internal sealed class 2538
{
	// Token: 0x1700026D RID: 621
	// (get) Token: 0x060029AD RID: 10669 RVA: 0x000D8A87 File Offset: 0x000D6C87
	// (set) Token: 0x060029AE RID: 10670 RVA: 0x000D8A8F File Offset: 0x000D6C8F
	internal string Text { get; private set; } = "0";

	// Token: 0x060029AF RID: 10671 RVA: 0x000D8A98 File Offset: 0x000D6C98
	internal 2538(2486 1)
	{
		this.2 = 1;
	}

	// Token: 0x060029B0 RID: 10672 RVA: 0x000D8AC8 File Offset: 0x000D6CC8
	internal static 1353 1(string 1, 1376 2, 1065 3, 208 4)
	{
		return new 1353(1, "score", 0f, 2, 3, (1044)0, 4, 0.95f, true, 198.White, true, (1416)1);
	}

	// Token: 0x060029B1 RID: 10673 RVA: 0x000D8AF8 File Offset: 0x000D6CF8
	internal void 2(2241 1)
	{
		if (1 == null || !2206.IsSupported)
		{
			return;
		}
		bool isReady = 2206.IsReady;
		long num = (long)(((((((ulong)1.2 * 31UL + (ulong)1.1) * 31UL + (ulong)1.3) * 31UL + (ulong)1.6) * 31UL + (ulong)1.4) * 31UL + (ulong)1.5) * 1000003UL + (ulong)((long)1.13 * 7919L) + (ulong)((long)1.GetScore()));
		if (num != this.5 || isReady != this.6)
		{
			this.5 = num;
			this.6 = isReady;
			double? num2 = 2206.5(1, this.3());
			if (num2 != null)
			{
				this.4 = num2.Value;
			}
		}
		if (Math.Abs(this.3 - this.4) < 0.5)
		{
			this.3 = this.4;
		}
		else if (1662.10 > 0.0)
		{
			this.3 = this.4 + (this.3 - this.4) * Math.Pow(0.85, 1662.10);
		}
		int num3 = (int)Math.Round(this.3, MidpointRounding.AwayFromZero);
		if (num3 != this.7)
		{
			this.7 = num3;
			this.Text = num3.ToString(1662.18) + "";
		}
	}

	// Token: 0x060029B2 RID: 10674 RVA: 0x000D8C5E File Offset: 0x000D6E5E
	private double 3()
	{
		return 2538.4(this.2);
	}

	// Token: 0x060029B3 RID: 10675 RVA: 0x000D8C6C File Offset: 0x000D6E6C
	internal static double 4(2486 1)
	{
		2034 2 = (1 != null) ? 1.125 : null;
		if (2 == null)
		{
			return double.MinValue;
		}
		if (2 is 2123 && 1226.16 < 2.2)
		{
			return (double)Math.Max(2.1, 1226.16);
		}
		return (double)2.2;
	}

	// Token: 0x04001E4A RID: 7754
	internal const char 1 = '';

	// Token: 0x04001E4B RID: 7755
	private readonly 2486 2;

	// Token: 0x04001E4C RID: 7756
	private double 3;

	// Token: 0x04001E4D RID: 7757
	private double 4;

	// Token: 0x04001E4E RID: 7758
	private long 5 = long.MinValue;

	// Token: 0x04001E4F RID: 7759
	private bool 6;

	// Token: 0x04001E50 RID: 7760
	private int 7 = -1;
}
