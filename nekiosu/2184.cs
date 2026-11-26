using System;
using System.Collections.Generic;

// Token: 0x020006E2 RID: 1762
public sealed class 2184 : 2039
{
	// Token: 0x06003454 RID: 13396 RVA: 0x001412AD File Offset: 0x0013F4AD
	internal 2184(bool 1 = true) : base(1)
	{
		this.58 = 1;
	}

	// Token: 0x06003455 RID: 13397 RVA: 0x001412BD File Offset: 0x0013F4BD
	public override void Dispose()
	{
		if (this.21 != null)
		{
			this.21.2 = this.59;
			this.21.5 = this.60;
		}
		base.Dispose();
	}

	// Token: 0x06003456 RID: 13398 RVA: 0x001412EF File Offset: 0x0013F4EF
	protected override void OnBeatmapChanged()
	{
		this.59 = this.21.2;
		this.60 = this.21.5;
	}

	// Token: 0x06003457 RID: 13399 RVA: 0x0000FF75 File Offset: 0x0000E175
	protected override bool UsesComboEndJudgements()
	{
		return false;
	}

	// Token: 0x06003458 RID: 13400 RVA: 0x0000FF75 File Offset: 0x0000E175
	protected override bool UsesComboColours()
	{
		return false;
	}

	// Token: 0x06003459 RID: 13401 RVA: 0x0000FF75 File Offset: 0x0000E175
	protected override bool UsesHitLighting()
	{
		return false;
	}

	// Token: 0x0600345A RID: 13402 RVA: 0x00141313 File Offset: 0x0013F513
	internal override 2037 CreateHitObjectFactory()
	{
		return new 2183(this);
	}

	// Token: 0x0600345B RID: 13403 RVA: 0x0014131C File Offset: 0x0013F51C
	internal override void RecalculateDifficulty(bool 1, bool 2, bool 3 = true)
	{
		if (this.21 != null)
		{
			if (3)
			{
				this.21.2 = 2f;
				this.21.5 = this.60 * 1.399999976158142;
			}
			base.RecalculateDifficulty(1, 2, true);
			this.24 = 1662.69.1() / 8f * 1.42f;
			this.1 = this.24 / 2f / 1662.69.9();
			this.23 = this.24 / (float)2039.16;
			if (this.39 != null)
			{
				this.39.14 = this.23;
			}
			this.3 = (int)this.GetDifficultyRange((double)base.16(1928.OverallDifficulty, this.21.4), 135.0, 95.0, 70.0);
			this.4 = (int)this.GetDifficultyRange((double)base.16(1928.OverallDifficulty, this.21.4), 120.0, 80.0, 50.0);
			this.5 = (int)this.GetDifficultyRange((double)base.16(1928.OverallDifficulty, this.21.4), 50.0, 35.0, 20.0);
			double val = 5000.0;
			double num = 600.0;
			1259 4 = 44.ListFirstOrDefault<1259>(this.21.94);
			this.2 = (int)Math.Min(val, num / this.GetSliderVelocityAt((int)((4 != null) ? 4.3 : 0.0)) / 0.6000000238418579 * 1000.0);
		}
	}

	// Token: 0x0600345C RID: 13404 RVA: 0x001414E0 File Offset: 0x0013F6E0
	protected internal override void AddSlider(2063 1)
	{
		2178 2 = (2178)1;
		2.6 *= 1.399999976158142;
		double num = 2.6;
		num *= (double)2.5;
		double num2 = this.6 * this.21.6;
		double num3 = this.21.90((double)2.1, true);
		2.2 = 2.1 + (int)(num / num2 * num3);
		double sliderVelocityAt = this.GetSliderVelocityAt(2.1);
		num3 = this.21.90((double)2.1, this.21.32 < 8);
		double num4 = Math.Min(num3 / this.21.6, (double)(2.2 - 2.1) / (double)2.5);
		if (num4 > 0.0 && this.21.3() != 2147.Taiko && num / sliderVelocityAt * 1000.0 < 2.0 * num3)
		{
			int num5 = 0;
			for (double num6 = (double)2.1; num6 <= (double)2.2 + num4 / 8.0; num6 += num4)
			{
				2072 3;
				if (2.73)
				{
					3 = this.33.CreateCircle(208.Zero, (int)num6, false, 2.4, 0, 1254.None, 1254.None, 1253.Default, 0, string.Empty);
				}
				else
				{
					3 = this.33.CreateCircle(208.Zero, (int)num6, false, 2.84[num5], 0, 1254.None, 1254.None, 1253.Default, 0, string.Empty);
					num5 = (num5 + 1) % 2.84.Count;
				}
				3.25 = new double?(num6);
				this.AddHitObject(3, false, true);
			}
			return;
		}
		base.AddSlider(2);
	}

	// Token: 0x0600345D RID: 13405 RVA: 0x001416B0 File Offset: 0x0013F8B0
	protected internal override void PrepareHitObjects()
	{
		if (1662.78 == 1677.Edit)
		{
			return;
		}
		this.35 = this.34.Count;
		if (this.35 == 0 || !this.58)
		{
			return;
		}
		208 <<EMPTY_NAME>> = 2184.61;
		int num = 1662.70.1() - 40;
		double num2 = 1.0;
		2241 2 = 2486.88;
		2023 4;
		bool flag;
		if (((2 != null) ? 2.39 : null) != null)
		{
			2023 3 = this.22;
			4 = 2023.Hidden;
			flag = ((3 & 4) > 2023.None);
		}
		else
		{
			2023 5 = this.22;
			4 = 2023.Hidden;
			int num3;
			if ((5 & 4) > 2023.None)
			{
				2023 6 = this.22;
				4 = 2023.HardRock;
				num3 = (((6 & 4) <= 2023.None) ? 1 : 0);
			}
			else
			{
				num3 = 0;
			}
			flag = ((byte)num3 > 0);
		}
		if (flag)
		{
			num = 600;
			this.39.27(new 1058(0f, 0f, 640f, (float)1662.70.2()));
		}
		2023 7 = this.22;
		4 = 2023.HardRock;
		if ((7 & 4) > 2023.None)
		{
			num2 *= 1.399999976158142;
			2241 8 = 2486.88;
			if (((8 != null) ? 8.39 : null) != null)
			{
				2023 9 = this.22;
				4 = 2023.Hidden;
				if ((9 & 4) > 2023.None)
				{
					goto IL_161;
				}
			}
			num2 *= (double)((float)1662.70.1() / 640f);
		}
		else
		{
			2023 10 = this.22;
			4 = 2023.Easy;
			if ((10 & 4) > 2023.None)
			{
				num2 *= 0.800000011920929;
			}
		}
		IL_161:
		for (int i = 0; i < this.35; i++)
		{
			2034 11 = this.34[i];
			11.SetPosition(<<EMPTY_NAME>>, false);
			double num4 = 300.0;
			double num5 = this.GetSliderVelocityAt(11.1) * num2;
			if (11 is 2178)
			{
				2178 12 = (2178)11;
				12.52(true, num2);
				num4 += 12.6;
			}
			int num6 = (int)((double)num / num5 * 1000.0);
			int num7 = (int)(300.0 / num5 * 1000.0);
			2185 13 = 11 as 2185;
			if (13 != null)
			{
				1433 14 = 13.76;
				14.3.Add(new 1445(new 208(14.17.X + (float)num, 14.17.Y), new 208(14.17.X, 14.17.Y), 11.1 - num6, 11.1, (1046)0));
				14.3.Add(new 1445(new 208(14.17.X, 14.17.Y), new 208(256f, 196f), 11.1, 11.1 + 200, (1046)0));
				14.3.Add(new 1445(1456.Scale, 1f, 3f, 11.1, 11.1 + 200, (1046)1));
				14.3.Add(new 1445(1456.Fade, 1f, 0f, 11.1, 11.1 + 200, (1046)0));
			}
			else
			{
				for (int j = 0; j < 11.30.Count; j++)
				{
					1433 15 = 11.30[j];
					15.3.Add(new 1445(new 208(15.17.X + (float)num, 15.17.Y), new 208(15.17.X, 15.17.Y), 11.1 - num6, 11.1, (1046)0));
					15.3.Add(new 1445(new 208(15.17.X, 15.17.Y), new 208(15.17.X - (float)num4, 15.17.Y), 11.1, 11.2 + num7, (1046)0));
				}
			}
		}
		int num8 = this.34[this.35 - 1].2 + 1;
		List<1259> list = this.21.84();
		if (list == null || list.Count == 0)
		{
			return;
		}
		int num9 = 0;
		double num10 = list[0].3;
		double num11 = list[0].1 * (double)list[0].5;
		num10 -= num11 * (double)((int)(num10 / num11));
		if (num10 < 0.0)
		{
			num10 += num11;
		}
		1381 16 = 1455.2("taiko-barline", (1416)3, null);
		while (num10 <= (double)num8)
		{
			1259 17 = list[num9];
			if (num10 > 17.3 || (17.8 & (1258)8) == (1258)0)
			{
				1433 18 = new 1433(16, (1376)2, 1065.Centre, (1044)1, <<EMPTY_NAME>>, 0.0006f, false, 198.White, null);
				18.15 = 0.88f;
				int num12 = (int)num10;
				double num13 = this.GetSliderVelocityAt(num12) * num2;
				int num14 = (int)((double)num / num13 * 1000.0);
				int num15 = (int)(300.0 / num13 * 1000.0);
				this.39.12(18);
				18.3.Add(new 1445(new 208(18.17.X + (float)num, 18.17.Y), new 208(18.17.X, 18.17.Y), num12 - num14, num12, (1046)0));
				18.3.Add(new 1445(new 208(18.17.X, 18.17.Y), new 208(18.17.X - 300f, 18.17.Y), num12, num12 + num15, (1046)0));
			}
			double num16 = 17.1 * (double)17.5;
			if (num16 < 0.001)
			{
				if (num9 + 1 >= list.Count)
				{
					break;
				}
				num9++;
				num10 = list[num9].3;
			}
			num10 += num16;
			if (num9 + 1 < list.Count && num10 >= list[num9 + 1].3)
			{
				num9++;
				num10 = list[num9].3;
			}
		}
	}

	// Token: 0x0600345E RID: 13406 RVA: 0x00141D4C File Offset: 0x0013FF4C
	protected override void AnimateSpinnerJudgement(1433 1)
	{
		1.3.Add(new 1445(new 208(320f, 240f), new 208(320f, 150f), 1226.16, 1226.16 + 2039.18 * 2, (1046)1));
		1.3.Add(new 1445(1456.Scale, 0.4f, 1f, 1226.16, 1226.16 + 2039.18 * 2, (1046)1));
		1.3.Add(new 1445(1456.Fade, 1f, 0f, 1226.16 + 2039.18 * 3, (int)((double)1226.16 + (double)2039.18 * 5.5), (1046)0));
	}

	// Token: 0x0600345F RID: 13407 RVA: 0x00141E0C File Offset: 0x0014000C
	protected override void AnimateHitJudgement(1433 1, bool 2 = true, bool 3 = false)
	{
		if (2)
		{
			1.3.Add(new 1445(1456.Scale, 0.6f, 1.1f, 1226.16, (int)((double)1226.16 + (double)2039.18 * 0.8), (1046)0));
			1.3.Add(new 1445(1456.Scale, 1.1f, 0.9f, 1226.16 + 2039.18, (int)((double)1226.16 + (double)2039.18 * 1.2), (1046)0));
			1.3.Add(new 1445(1456.Scale, 0.9f, 1f, 1226.16 + 2039.18, (int)((double)1226.16 + (double)2039.18 * 1.4), (1046)0));
		}
		1.3.Add(new 1445(1456.Fade, 0f, 1f, 1226.16, 1226.16 + 2039.18, (1046)0));
		1.3.Add(new 1445(1456.Fade, 1f, 0f, 1226.16 + 2039.18, (int)((double)1226.16 + (double)2039.18 * 2.5), (1046)0));
	}

	// Token: 0x06003460 RID: 13408 RVA: 0x00141F41 File Offset: 0x00140141
	protected override void OnJudgementSpriteCreated(1433 1)
	{
		1.41 = (1376)2;
		base.OnJudgementSpriteCreated(1);
	}

	// Token: 0x06003461 RID: 13409 RVA: 0x00141F54 File Offset: 0x00140154
	public override 1381[] GetJudgementTextures(string 1)
	{
		1381[] array = 1455.5("taiko-" + 1, (1416)7, true);
		if (array == null || array.Length == 0)
		{
			array = 1455.5(1, (1416)7, true);
		}
		return array;
	}

	// Token: 0x040026EC RID: 9964
	private readonly bool 58;

	// Token: 0x040026ED RID: 9965
	private new float 59;

	// Token: 0x040026EE RID: 9966
	private new double 60;

	// Token: 0x040026EF RID: 9967
	internal new static readonly 208 61 = new 208(160f, 125f);
}
