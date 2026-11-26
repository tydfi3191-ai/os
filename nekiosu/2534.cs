using System;
using System.Collections.Generic;

// Token: 0x02000507 RID: 1287
[276]
internal sealed class 2534 : 2510
{
	// Token: 0x06002771 RID: 10097 RVA: 0x000C4B10 File Offset: 0x000C2D10
	internal 2534(2511 1, 2528 2) : base(1, 2)
	{
		for (int i = 0; i < 2534.9.Length; i++)
		{
			2.8(2530.1(2534.9[i], 2534.10[i], "Whether this judgement is counted.", 2534.11[i]));
		}
		2.8(2530.3("direction", "Counter direction", "Counts under each other or side by side.", "vertical", new string[]
		{
			"vertical",
			"horizontal"
		}, new string[]
		{
			"Vertical",
			"Horizontal"
		}));
		2.8(2530.2("row_spacing", "Row spacing", "The space between the counts under each other.", 1f, 0f, 40f, 0.5f, "0.#")).16 = (() => !this.Horizontal);
		2.8(2530.2("column_spacing", "Column spacing", "The space between the counts side by side.", 8f, 0f, 60f, 0.5f, "0.#")).16 = (() => this.Horizontal);
		2.8(2530.1("show_names", "Show judgement names", "The name of each judgement beside its count.", true));
	}

	// Token: 0x1700025A RID: 602
	// (get) Token: 0x06002772 RID: 10098 RVA: 0x000C4C79 File Offset: 0x000C2E79
	private bool Horizontal
	{
		get
		{
			return this.2.10("direction") == "horizontal";
		}
	}

	// Token: 0x06002773 RID: 10099 RVA: 0x000C4C98 File Offset: 0x000C2E98
	internal override void Build()
	{
		this.13.Clear();
		this.14.Clear();
		this.15.Clear();
		this.16.Clear();
		for (int i = 0; i < 2534.9.Length; i++)
		{
			if (this.2.11(2534.9[i]))
			{
				this.13.Add(i);
			}
		}
		bool flag = this.2.11("show_names");
		208 pivot = base.Pivot;
		foreach (int num in this.13)
		{
			if (flag)
			{
				this.14.Add(base.1<1452>(2510.4(2534.8[num], 10f, pivot, 1065.TopLeft, 2534.12[num], true), true));
			}
			string text = this.1.20[num].ToString(1662.18);
			1353 <<EMPTY_NAME>> = 2538.1(text, (1376)6, 1065.TopLeft, pivot);
			<<EMPTY_NAME>>.15 = 0.5f;
			<<EMPTY_NAME>>.6 = (flag ? 198.White : 2534.12[num]);
			this.15.Add(base.1<1353>(<<EMPTY_NAME>>, true));
			this.16.Add(text);
		}
		this.6();
	}

	// Token: 0x06002774 RID: 10100 RVA: 0x000C4E14 File Offset: 0x000C3014
	private void 6()
	{
		bool horizontal = this.Horizontal;
		bool flag = this.14.Count > 0;
		float num = this.2.12("row_spacing");
		float num2 = this.2.12("column_spacing");
		208 pivot = base.Pivot;
		float num3 = 0f;
		if (flag && !horizontal)
		{
			foreach (1452 <<EMPTY_NAME>> in this.14)
			{
				num3 = Math.Max(num3, 2534.7(<<EMPTY_NAME>>));
			}
			num3 += 6f;
		}
		208 2 = pivot;
		for (int i = 0; i < this.15.Count; i++)
		{
			1452 3 = flag ? this.14[i] : null;
			1353 4 = this.15[i];
			if (3 != null)
			{
				3.17 = 2 + new 208(0f, 1f);
			}
			4.17 = ((3 == null) ? 2 : (horizontal ? (2 + new 208(0f, 11f)) : (2 + new 208(num3, 0f))));
			if (horizontal)
			{
				2.X += Math.Max((3 != null) ? 2534.7(3) : 0f, 2534.7(4)) + num2;
			}
			else
			{
				2.Y += 12f + num;
			}
		}
		this.2.32();
	}

	// Token: 0x06002775 RID: 10101 RVA: 0x000C4FBC File Offset: 0x000C31BC
	private static float 7(1433 1)
	{
		1058 2;
		if (!2528.33(1, out 2))
		{
			return 0f;
		}
		return 2.Width;
	}

	// Token: 0x06002776 RID: 10102 RVA: 0x000C4FE0 File Offset: 0x000C31E0
	internal override void Update()
	{
		foreach (1452 <<EMPTY_NAME>> in this.14)
		{
			base.3(<<EMPTY_NAME>>, 10f);
		}
		bool flag = false;
		for (int i = 0; i < this.13.Count; i++)
		{
			string text = this.1.20[this.13[i]].ToString(1662.18);
			if (text != this.16[i])
			{
				this.16[i] = text;
				this.15[i].SetText(text);
				flag = true;
			}
		}
		if (flag && this.Horizontal)
		{
			this.6();
		}
	}

	// Token: 0x04001C73 RID: 7283
	private new const float 5 = 10f;

	// Token: 0x04001C74 RID: 7284
	private const float 6 = 0.5f;

	// Token: 0x04001C75 RID: 7285
	private const float 7 = 12f;

	// Token: 0x04001C76 RID: 7286
	private static readonly string[] 8 = new string[]
	{
		"GEKI",
		"300",
		"KATU",
		"100",
		"50",
		"MISS"
	};

	// Token: 0x04001C77 RID: 7287
	private static readonly string[] 9 = new string[]
	{
		"show_geki",
		"show_300",
		"show_katu",
		"show_100",
		"show_50",
		"show_miss"
	};

	// Token: 0x04001C78 RID: 7288
	private static readonly string[] 10 = new string[]
	{
		"Show gekis",
		"Show 300s",
		"Show katus",
		"Show 100s",
		"Show 50s",
		"Show misses"
	};

	// Token: 0x04001C79 RID: 7289
	private static readonly bool[] 11 = new bool[]
	{
		false,
		true,
		false,
		true,
		true,
		true
	};

	// Token: 0x04001C7A RID: 7290
	private static readonly 198[] 12 = new 198[]
	{
		new 198(160, 230, byte.MaxValue),
		new 198(102, 204, byte.MaxValue),
		new 198(190, 240, 140),
		new 198(136, 221, 85),
		new 198(byte.MaxValue, 204, 85),
		new 198(byte.MaxValue, 85, 85)
	};

	// Token: 0x04001C7B RID: 7291
	private readonly List<int> 13 = new List<int>();

	// Token: 0x04001C7C RID: 7292
	private readonly List<1452> 14 = new List<1452>();

	// Token: 0x04001C7D RID: 7293
	private readonly List<1353> 15 = new List<1353>();

	// Token: 0x04001C7E RID: 7294
	private readonly List<string> 16 = new List<string>();
}
