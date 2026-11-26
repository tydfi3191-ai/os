using System;
using System.Collections.Generic;

// Token: 0x020004FE RID: 1278
[276]
internal sealed class 2495 : 2510
{
	// Token: 0x06002720 RID: 10016 RVA: 0x000C274C File Offset: 0x000C094C
	internal 2495(2511 1, 2528 2) : base(1, 2)
	{
		string[] array = new string[]
		{
			"x",
			"plus"
		};
		string[] array2 = new string[]
		{
			"x",
			"+"
		};
		2.8(2530.2("marker_size", "Hit marker size", "Controls the size of the markers displayed after every hit.", 7f, 0f, 12f, 1f, "0.##"));
		2.8(2530.3("marker_style", "Hit marker style", "The visual style of the hit markers.", "x", array, array2));
		2.8(2530.2("average_size", "Average position marker size", "Controls the size of the marker showing average hit position.", 12f, 7f, 25f, 1f, "0.##"));
		2.8(2530.3("average_style", "Average position marker style", "The visual style of the average position marker.", "plus", array, array2));
		2.8(2530.3("positions", "Position display style", "Absolute: as seen on screen. Normalised: relative to the direction of movement from the previous object.", "absolute", new string[]
		{
			"absolute",
			"normalised"
		}, new string[]
		{
			"Absolute",
			"Normalised"
		}));
	}

	// Token: 0x17000254 RID: 596
	// (get) Token: 0x06002721 RID: 10017 RVA: 0x000C2892 File Offset: 0x000C0A92
	private bool Normalised
	{
		get
		{
			return this.2.10("positions") == "normalised";
		}
	}

	// Token: 0x06002722 RID: 10018 RVA: 0x000C28B0 File Offset: 0x000C0AB0
	internal override void Build()
	{
		208 pivot = base.Pivot;
		float num = 53.125f;
		1433 <<EMPTY_NAME>> = base.1<1433>(new 1433(2532.Circle(256), (1376)6, 1065.Centre, (1044)0, pivot, 0.93f, true, new 198(128, 128, 128), null), true);
		<<EMPTY_NAME>>.15 = 1.6f * num / 256f;
		<<EMPTY_NAME>>.16 = 0.3f;
		base.1<1433>(new 1433(2532.1(256, 1.25f / num * 256f), (1376)6, 1065.Centre, (1044)0, pivot, 0.931f, true, 198.White, null), true).15 = 1.6f * num / 256f;
		this.6(pivot, num * 0.9f, 1.25f, 0f, 0.5f);
		this.6(pivot, num * 0.9f, 1.25f, 90f, 0.5f);
		this.6(pivot, num * 0.9f, 0.625f, 45f, 0.2f);
		this.6(pivot, num * 0.9f, 0.625f, 135f, 0.2f);
		if (this.Normalised)
		{
			float num2 = 65.62501f;
			this.6(pivot, num2, 0.625f, 45f, 1f);
			208 2 = pivot + 2495.8(new 208(0f, -num2 / 2f), 45f);
			base.1<1433>(2510.5(2, new 208(0.625f, 3.125f), 1065.TopCentre, 198.White, 0.935f), true).14 = 0f;
			base.1<1433>(2510.5(2, new 208(0.625f, 3.125f), 1065.TopCentre, 198.White, 0.935f), true).14 = 1.5707964f;
		}
		this.17.Clear();
		for (int i = 0; i < 30; i++)
		{
			this.17.Add(this.7(pivot, 0.94f));
		}
		this.18 = this.7(pivot, 0.95f);
		this.18.5 = 198.White;
		this.22 = 0;
	}

	// Token: 0x06002723 RID: 10019 RVA: 0x000C2AE0 File Offset: 0x000C0CE0
	private void 6(208 1, float 2, float 3, float 4, float 5)
	{
		1433 6 = base.1<1433>(2510.5(1, new 208(3, 2), 1065.Centre, 198.White, 0.932f), true);
		6.14 = (float)((double)4 * 3.141592653589793 / 180.0);
		6.16 = 5;
	}

	// Token: 0x06002724 RID: 10020 RVA: 0x000C2B34 File Offset: 0x000C0D34
	private 2495.2496 7(208 1, float 2)
	{
		return new 2495.2496
		{
			1 = base.1<1433>(2510.5(1, 208.Zero, 1065.Centre, 198.White, 2), false),
			2 = base.1<1433>(2510.5(1, 208.Zero, 1065.Centre, 198.White, 2), false),
			1 = 
			{
				16 = 0f
			},
			2 = 
			{
				16 = 0f
			}
		};
	}

	// Token: 0x06002725 RID: 10021 RVA: 0x000C2BA4 File Offset: 0x000C0DA4
	private static 208 8(208 1, float 2)
	{
		double num = (double)2 * 3.141592653589793 / 180.0;
		float num2 = (float)Math.Cos(num);
		float num3 = (float)Math.Sin(num);
		return new 208(1.X * num2 - 1.Y * num3, 1.X * num3 + 1.Y * num2);
	}

	// Token: 0x06002726 RID: 10022 RVA: 0x000C2C00 File Offset: 0x000C0E00
	internal void 9(208 1, 208 2, float 3)
	{
		if (3 <= 0f)
		{
			return;
		}
		208 4;
		if (this.Normalised && this.21 != null)
		{
			4 = 2495.10(this.21.Value, 2, 1, 3, 45f) * 0.425f;
		}
		else
		{
			4 = (1 - 2) / 3 / 2f * 0.85f;
		}
		4 = 208.Clamp(4, new 208(-0.5f), new 208(0.5f));
		2495.2496 5 = this.17[this.22];
		this.22 = (this.22 + 1) % this.17.Count;
		5.3 = 4;
		5.4 = 1662.33;
		5.5 = 2495.11(4);
		this.19 = new 208?(0.1f * 4 + 0.9f * this.19.GetValueOrDefault(4));
		this.21 = new 208?(2);
	}

	// Token: 0x06002727 RID: 10023 RVA: 0x000C2D14 File Offset: 0x000C0F14
	private static 208 10(208 1, 208 2, 208 3, float 4, float 5)
	{
		double num = Math.Atan2((double)(2.Y - 3.Y), (double)(3.X - 2.X));
		double num2 = Math.Atan2((double)(2.Y - 1.Y), (double)(1.X - 2.X)) - num;
		float num3 = 208.Distance(3, 2) / 4;
		double num4 = num2 - (double)5 * 3.141592653589793 / 180.0;
		return -num3 * new 208((float)Math.Cos(num4), (float)Math.Sin(num4));
	}

	// Token: 0x06002728 RID: 10024 RVA: 0x000C2DA4 File Offset: 0x000C0FA4
	private static 198 11(208 1)
	{
		float num = 1.Length();
		if (num >= 0.425f)
		{
			return 2495.16;
		}
		if (num >= 0.2975f)
		{
			return 2495.15;
		}
		if (num < 0.17f)
		{
			return 2495.13;
		}
		return 2495.14;
	}

	// Token: 0x06002729 RID: 10025 RVA: 0x000C2DE8 File Offset: 0x000C0FE8
	internal void 12()
	{
		foreach (2495.2496 <<EMPTY_NAME>> in this.17)
		{
			<<EMPTY_NAME>>.4 = int.MinValue;
		}
		this.19 = null;
		this.21 = null;
	}

	// Token: 0x0600272A RID: 10026 RVA: 0x000C2E58 File Offset: 0x000C1058
	internal override void Update()
	{
		if (this.18 == null)
		{
			return;
		}
		208 pivot = base.Pivot;
		bool <<EMPTY_NAME>> = this.2.10("marker_style") == "plus";
		float num = this.2.12("marker_size") * 0.625f;
		int 2 = 1662.33;
		foreach (2495.2496 3 in this.17)
		{
			int num2 = 2 - 3.4;
			if (3.4 == -2147483648 || num2 > 5100 || num2 < 0)
			{
				3.1.16 = 0f;
				3.2.16 = 0f;
			}
			else
			{
				float num3 = (num2 >= 100) ? 1f : (1f - (float)Math.Pow((double)(1f - (float)num2 / 100f), 5.0));
				float num4 = (num2 < 100) ? num3 : (1f - (float)(num2 - 100) / 5000f);
				2495.13(3, pivot + 3.3 * 62.5f, num * num3, <<EMPTY_NAME>>, num4);
			}
		}
		208 4 = this.19 ?? 208.Zero;
		this.20 = 4 + (this.20 - 4) * (float)Math.Pow(0.9, 1662.10);
		bool 5 = this.2.10("average_style") == "plus";
		2495.13(this.18, pivot + this.20 * 62.5f, this.2.12("average_size") * 0.625f, 5, 1f);
	}

	// Token: 0x0600272B RID: 10027 RVA: 0x000C3064 File Offset: 0x000C1264
	private static void 13(2495.2496 1, 208 2, float 3, bool 4, float 5)
	{
		float num = (float)((4 ? 0.0 : 45.0) * 3.141592653589793 / 180.0);
		1433[] array = new 1433[]
		{
			1.1,
			1.2
		};
		for (int i = 0; i < 2; i++)
		{
			array[i].17 = 2;
			array[i].20 = new 208(3 * 0.25f, 3);
			array[i].14 = num + (float)((double)i * 3.141592653589793 / 2.0);
			array[i].6 = 1.5;
			array[i].16 = Math.Max(0f, Math.Min(1f, 5));
		}
	}

	// Token: 0x04001C13 RID: 7187
	private new const float 5 = 0.625f;

	// Token: 0x04001C14 RID: 7188
	private const float 6 = 62.5f;

	// Token: 0x04001C15 RID: 7189
	private const float 7 = 0.85f;

	// Token: 0x04001C16 RID: 7190
	private const float 8 = 1.25f;

	// Token: 0x04001C17 RID: 7191
	private const int 9 = 30;

	// Token: 0x04001C18 RID: 7192
	private const int 10 = 100;

	// Token: 0x04001C19 RID: 7193
	private const int 11 = 5000;

	// Token: 0x04001C1A RID: 7194
	private const int 12 = 256;

	// Token: 0x04001C1B RID: 7195
	private static readonly 198 13 = new 198(102, 204, byte.MaxValue);

	// Token: 0x04001C1C RID: 7196
	private static readonly 198 14 = new 198(179, 217, 68);

	// Token: 0x04001C1D RID: 7197
	private static readonly 198 15 = new 198(byte.MaxValue, 204, 34);

	// Token: 0x04001C1E RID: 7198
	private static readonly 198 16 = new 198(237, 17, 33);

	// Token: 0x04001C1F RID: 7199
	private readonly List<2495.2496> 17 = new List<2495.2496>();

	// Token: 0x04001C20 RID: 7200
	private 2495.2496 18;

	// Token: 0x04001C21 RID: 7201
	private 208? 19;

	// Token: 0x04001C22 RID: 7202
	private 208 20;

	// Token: 0x04001C23 RID: 7203
	private 208? 21;

	// Token: 0x04001C24 RID: 7204
	private int 22;

	// Token: 0x020004FF RID: 1279
	[276]
	private sealed class 2496
	{
		// Token: 0x04001C25 RID: 7205
		public 1433 1;

		// Token: 0x04001C26 RID: 7206
		public 1433 2;

		// Token: 0x04001C27 RID: 7207
		public 208 3;

		// Token: 0x04001C28 RID: 7208
		public int 4 = int.MinValue;

		// Token: 0x04001C29 RID: 7209
		public 198 5;
	}
}
