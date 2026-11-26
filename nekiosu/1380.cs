using System;
using System.Collections.Generic;

// Token: 0x02000A8F RID: 2703
public class 1380 : IDisposable
{
	// Token: 0x06004AE8 RID: 19176 RVA: 0x001DAF9C File Offset: 0x001D919C
	internal 1380(1436 1, 1409 2, float 3 = 34f)
	{
		this.10 = 1;
		this.8 = 2;
		1376 4;
		switch (2)
		{
		case 1409.Pie:
			return;
		case 1409.BottomRight:
			this.9 = new 208(118f, 460f);
			this.4 = 118f;
			4 = (1376)8;
			goto IL_C0;
		case 1409.Bottom:
			this.9 = new 208(0f, 477f);
			this.4 = (float)1662.70.1 / 1662.70.3();
			4 = (1376)6;
			goto IL_C0;
		}
		this.9 = new 208(178f, 3 - 2f);
		this.4 = 170f;
		4 = (1376)8;
		IL_C0:
		this.7 = 4;
		this.5 = new 1433(1662.34, 4, 1065.TopLeft, (1044)0, this.9, 0.938f, true, new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 20), null);
		this.5.15 = 1.6f;
		this.5.20 = new 208(this.4, 3f);
		this.5.28 = true;
		this.1(this.5);
		this.6 = new 1433(1662.34, 4, 1065.TopLeft, (1044)0, this.9, 0.94f, true, new 198(byte.MaxValue, byte.MaxValue, 128, 128), null);
		this.6.15 = 1.6f;
		this.6.20 = new 208(0f, 3f);
		this.6.28 = true;
		this.1(this.6);
	}

	// Token: 0x06004AE9 RID: 19177 RVA: 0x001DB164 File Offset: 0x001D9364
	protected void 1(1371 1)
	{
		this.10.12(1);
		this.11.Add(1);
	}

	// Token: 0x06004AEA RID: 19178 RVA: 0x001DB180 File Offset: 0x001D9380
	private 208 2()
	{
		float num = (float)1662.70.1 / 1662.70.3();
		if (this.7 != (1376)8)
		{
			return this.9;
		}
		return new 208(num - this.9.X, this.9.Y);
	}

	// Token: 0x1700030D RID: 781
	// (get) Token: 0x06004AEB RID: 19179 RVA: 0x001DB1D1 File Offset: 0x001D93D1
	private bool DecorationsBelow
	{
		get
		{
			return this.8 == 1409.TopRight;
		}
	}

	// Token: 0x06004AEC RID: 19180 RVA: 0x001DB1DC File Offset: 0x001D93DC
	internal void 3(bool 1, bool 2, IList<2034> 3, int 4, int 5)
	{
		if (this.5 == null)
		{
			return;
		}
		208 6 = this.2();
		float num = this.DecorationsBelow ? (6.Y + 4f) : (6.Y - 1f);
		if (1 && 3 != null && 3.Count > 0 && 5 > 4)
		{
			int num2 = Math.Max(1, (int)(this.4 / 3f));
			int[] array = new int[num2];
			foreach (2034 7 in 3)
			{
				int num3 = (int)1052.19((float)(7.1 - 4) / (float)(5 - 4) * (float)num2, 0f, (float)(num2 - 1));
				int num4 = (int)1052.19((float)(7.2 - 4) / (float)(5 - 4) * (float)num2, 0f, (float)(num2 - 1));
				for (int i = num3; i <= num4; i++)
				{
					array[i]++;
				}
			}
			int num5 = 1;
			foreach (int val in array)
			{
				num5 = Math.Max(num5, val);
			}
			this.12 = new 1433[num2];
			for (int k = 0; k < num2; k++)
			{
				float num6 = Math.Max(1f, 12f * (float)array[k] / (float)num5);
				1433 8 = new 1433(1662.34, (1376)6, this.DecorationsBelow ? 1065.TopLeft : 1065.BottomLeft, (1044)0, new 208(6.X + (float)k * 3f, num), 0.937f, true, 198.White, null);
				8.15 = 1.6f;
				8.20 = new 208(2f, num6);
				8.16 = 0.15f;
				this.1(8);
				this.12[k] = 8;
			}
			num += (this.DecorationsBelow ? 13f : -13f);
		}
		if (2)
		{
			1065 9 = this.DecorationsBelow ? 1065.TopLeft : 1065.BottomLeft;
			this.14 = new 1452("0:00", 7f, new 208(6.X, num), 0.94f, true, 198.White)
			{
				49 = 9
			};
			this.15 = new 1452("0:00", 7f, new 208(6.X + this.4, num), 0.94f, true, 198.White)
			{
				49 = (this.DecorationsBelow ? 1065.TopRight : 1065.BottomRight)
			};
			this.16 = new 1452("0%", 7f, new 208(6.X + this.4 / 2f, num), 0.94f, true, 198.White)
			{
				49 = (this.DecorationsBelow ? 1065.TopCentre : 1065.BottomCentre)
			};
			this.1(this.14);
			this.1(this.15);
			this.1(this.16);
		}
	}

	// Token: 0x06004AED RID: 19181 RVA: 0x001DB4F0 File Offset: 0x001D96F0
	internal virtual void SetProgress(float 1)
	{
		this.6.20 = new 208(1052.19(1, 0f, 1f) * this.4, 3f);
		if (this.12 != null)
		{
			int num = (int)(1052.19(1, 0f, 1f) * (float)this.12.Length);
			if (num != this.13)
			{
				this.13 = num;
				for (int i = 0; i < this.12.Length; i++)
				{
					this.12[i].16 = ((i < num) ? 0.45f : 0.15f);
				}
			}
		}
	}

	// Token: 0x06004AEE RID: 19182 RVA: 0x001DB590 File Offset: 0x001D9790
	internal void 4(double 1, double 2, int 3)
	{
		if (this.14 == null)
		{
			return;
		}
		this.14.SetText(1380.5(1));
		this.15.SetText("-" + 1380.5(2));
		this.16.SetText(3.ToString(1662.18) + "%");
	}

	// Token: 0x06004AEF RID: 19183 RVA: 0x001DB5F4 File Offset: 0x001D97F4
	private static string 5(double 1)
	{
		int num = (int)Math.Floor(Math.Max(0.0, 1) / 1000.0);
		return (num / 60).ToString(1662.18) + ":" + (num % 60).ToString("00", 1662.18);
	}

	// Token: 0x06004AF0 RID: 19184 RVA: 0x001DB654 File Offset: 0x001D9854
	internal void 6()
	{
		foreach (1371 <<EMPTY_NAME>> in this.11)
		{
			this.10.Remove(<<EMPTY_NAME>>);
		}
		this.11.Clear();
	}

	// Token: 0x06004AF1 RID: 19185 RVA: 0x00005ADD File Offset: 0x00003CDD
	public virtual void Dispose()
	{
	}

	// Token: 0x06004AF2 RID: 19186 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal virtual void Draw()
	{
	}

	// Token: 0x040037E0 RID: 14304
	private const float 1 = 12f;

	// Token: 0x040037E1 RID: 14305
	private const float 2 = 2f;

	// Token: 0x040037E2 RID: 14306
	private const float 3 = 7f;

	// Token: 0x040037E3 RID: 14307
	private readonly float 4;

	// Token: 0x040037E4 RID: 14308
	private readonly 1433 5;

	// Token: 0x040037E5 RID: 14309
	private readonly 1433 6;

	// Token: 0x040037E6 RID: 14310
	private readonly 1376 7;

	// Token: 0x040037E7 RID: 14311
	private readonly 1409 8;

	// Token: 0x040037E8 RID: 14312
	internal 208 9;

	// Token: 0x040037E9 RID: 14313
	protected readonly 1436 10;

	// Token: 0x040037EA RID: 14314
	protected readonly List<1371> 11 = new List<1371>();

	// Token: 0x040037EB RID: 14315
	private 1433[] 12;

	// Token: 0x040037EC RID: 14316
	private int 13 = -1;

	// Token: 0x040037ED RID: 14317
	private 1452 14;

	// Token: 0x040037EE RID: 14318
	private 1452 15;

	// Token: 0x040037EF RID: 14319
	private 1452 16;
}
