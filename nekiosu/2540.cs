using System;

// Token: 0x02000508 RID: 1288
[276]
internal sealed class 2540 : 2510
{
	// Token: 0x0600277A RID: 10106 RVA: 0x000C5249 File Offset: 0x000C3449
	internal 2540(2511 1, 2528 2) : base(1, 2)
	{
	}

	// Token: 0x0600277B RID: 10107 RVA: 0x000C525C File Offset: 0x000C345C
	internal override void Build()
	{
		this.6 = 2540.7();
		this.5 = base.1<1433>(new 1433(2540.6(this.6), (1376)6, 1065.Centre, (1044)0, base.Pivot, 0.95f, true, 198.White, null), true);
	}

	// Token: 0x0600277C RID: 10108 RVA: 0x000C52A6 File Offset: 0x000C34A6
	private static 1381 6(2236 1)
	{
		return 1455.2("ranking-" + 1.ToString() + "-small", (1416)7, null);
	}

	// Token: 0x0600277D RID: 10109 RVA: 0x000C52CC File Offset: 0x000C34CC
	private static 2236 7()
	{
		2241 <<EMPTY_NAME>> = 2486.88;
		if (<<EMPTY_NAME>> == null)
		{
			return 2236.X;
		}
		bool flag = (<<EMPTY_NAME>>.8 & (2023.Hidden | 2023.Flashlight)) > 2023.None;
		int num = (int)(<<EMPTY_NAME>>.2 + <<EMPTY_NAME>>.1 + <<EMPTY_NAME>>.3 + <<EMPTY_NAME>>.6);
		if (num == 0)
		{
			if (!flag)
			{
				return 2236.X;
			}
			return 2236.XH;
		}
		else
		{
			float num2 = (float)<<EMPTY_NAME>>.2 / (float)num;
			float num3 = (float)<<EMPTY_NAME>>.3 / (float)num;
			if (num2 == 1f)
			{
				if (!flag)
				{
					return 2236.X;
				}
				return 2236.XH;
			}
			else if (num2 > 0.9f && num3 <= 0.01f && <<EMPTY_NAME>>.6 == 0)
			{
				if (!flag)
				{
					return 2236.S;
				}
				return 2236.SH;
			}
			else
			{
				if ((num2 > 0.8f && <<EMPTY_NAME>>.6 == 0) || num2 > 0.9f)
				{
					return 2236.A;
				}
				if ((num2 > 0.7f && <<EMPTY_NAME>>.6 == 0) || num2 > 0.8f)
				{
					return 2236.B;
				}
				if (num2 <= 0.6f)
				{
					return 2236.D;
				}
				return 2236.C;
			}
		}
	}

	// Token: 0x0600277E RID: 10110 RVA: 0x000C53A4 File Offset: 0x000C35A4
	internal override void Update()
	{
		2236 <<EMPTY_NAME>> = 2540.7();
		if (<<EMPTY_NAME>> == this.6 || this.5 == null)
		{
			return;
		}
		this.6 = <<EMPTY_NAME>>;
		this.5.SetTexture(2540.6(<<EMPTY_NAME>>));
		this.5.3.Clear();
		this.5.3.Add(new 1445(1456.Scale, 1.4f, 1f, 1662.33, 1662.33 + 300, (1046)0)
		{
			15 = (1046)1
		});
		this.2.32();
	}

	// Token: 0x04001C7F RID: 7295
	private new 1433 5;

	// Token: 0x04001C80 RID: 7296
	private 2236 6 = 2236.N;
}
