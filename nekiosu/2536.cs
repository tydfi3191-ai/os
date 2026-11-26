using System;
using System.Collections.Generic;

// Token: 0x0200054C RID: 1356
[276]
internal sealed class 2536
{
	// Token: 0x060029A5 RID: 10661 RVA: 0x000D8670 File Offset: 0x000D6870
	internal 2536(2528 1, bool 2)
	{
		this.6 = 3;
		this.7 = 2;
		this.6.8(2530.3("expansion", "Expansion mode", "How the icons are spread out.", "auto", new string[]
		{
			"auto",
			"contracted",
			"expanded"
		}, new string[]
		{
			"As osu! (spread out in replays)",
			"Always contracted",
			"Always expanded"
		}));
		this.6.8(2530.3("direction", "Display direction", "The icons in a row or in a column.", "horizontal", new string[]
		{
			"horizontal",
			"vertical"
		}, new string[]
		{
			"Horizontal",
			"Vertical"
		}));
		this.6.8(2530.1("extended", "Show extended information", "Whether to show extended information for each mod (a custom speed).", true));
		this.6.8(2530.1("fade", "Fade out during play", "osu! hides the icons a few seconds into the play.", true)).16 = (() => !this.7);
		this.6.27 = delegate(string 1)
		{
			this.Apply();
		};
	}

	// Token: 0x060029A6 RID: 10662 RVA: 0x000D87B8 File Offset: 0x000D69B8
	internal void 1(1433 1, 1452 2)
	{
		2536.2537 3 = new 2536.2537
		{
			1 = 1,
			2 = 2
		};
		3.3 = 2536.2(1);
		3.4 = ((2 != null) ? 2536.2(2) : null);
		this.5.Add(3);
	}

	// Token: 0x060029A7 RID: 10663 RVA: 0x000D8804 File Offset: 0x000D6A04
	private static 1445 2(1433 1)
	{
		foreach (1445 2 in 1.3)
		{
			if (2.14 == 1456.Fade && 2.1 == 1f && 2.5 == 0f)
			{
				2.16 = 77;
				return 2;
			}
		}
		return null;
	}

	// Token: 0x060029A8 RID: 10664 RVA: 0x000D8884 File Offset: 0x000D6A84
	internal void Apply()
	{
		string a = this.6.10("expansion");
		float num = (a == "expanded" || (a == "auto" && this.7)) ? 50f : 10f;
		bool flag = this.6.10("direction") == "vertical";
		bool flag2 = this.6.11("extended");
		bool flag3 = this.6.11("fade");
		for (int i = 0; i < this.5.Count; i++)
		{
			2536.2537 <<EMPTY_NAME>> = this.5[i];
			208 2 = flag ? new 208(30f, 94f + (float)i * num) : new 208(30f + (float)i * num, 94f);
			<<EMPTY_NAME>>.1.17 = 2;
			<<EMPTY_NAME>>.1.7 = 2;
			2536.3(<<EMPTY_NAME>>.1, <<EMPTY_NAME>>.3, flag3);
			if (<<EMPTY_NAME>>.2 != null)
			{
				<<EMPTY_NAME>>.2.17 = 2 + new 208(0f, 24f);
				<<EMPTY_NAME>>.2.7 = <<EMPTY_NAME>>.2.17;
				2536.3(<<EMPTY_NAME>>.2, <<EMPTY_NAME>>.4, flag3);
				<<EMPTY_NAME>>.2.9(!flag2);
			}
		}
		this.6.32();
	}

	// Token: 0x060029A9 RID: 10665 RVA: 0x000D8A1C File Offset: 0x000D6C1C
	private static void 3(1433 1, 1445 2, bool 3)
	{
		if (2 == null)
		{
			return;
		}
		bool flag = 1.3.Contains(2);
		if (3 && !flag)
		{
			1.3.Add(2);
			1.3.Sort();
			return;
		}
		if (!3 && flag)
		{
			1.3.Remove(2);
			1.5 = true;
		}
	}

	// Token: 0x04001E3F RID: 7743
	private const float 1 = 30f;

	// Token: 0x04001E40 RID: 7744
	private const float 2 = 94f;

	// Token: 0x04001E41 RID: 7745
	private const float 3 = 24f;

	// Token: 0x04001E42 RID: 7746
	private const byte 4 = 77;

	// Token: 0x04001E43 RID: 7747
	private readonly List<2536.2537> 5 = new List<2536.2537>();

	// Token: 0x04001E44 RID: 7748
	private readonly 2528 6;

	// Token: 0x04001E45 RID: 7749
	private readonly bool 7;

	// Token: 0x0200054D RID: 1357
	[276]
	private sealed class 2537
	{
		// Token: 0x04001E46 RID: 7750
		public 1433 1;

		// Token: 0x04001E47 RID: 7751
		public 1452 2;

		// Token: 0x04001E48 RID: 7752
		public 1445 3;

		// Token: 0x04001E49 RID: 7753
		public 1445 4;
	}
}
