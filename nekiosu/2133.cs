using System;
using System.Collections.Generic;

// Token: 0x02000720 RID: 1824
[276]
public sealed class 2133 : 2122
{
	// Token: 0x060035F6 RID: 13814 RVA: 0x00150EC0 File Offset: 0x0014F0C0
	protected override void OnBeatmapChanged()
	{
		if (1535.1())
		{
			2023 <<EMPTY_NAME>> = 1535.39.8;
			2023 2 = 2023.Target;
			if ((<<EMPTY_NAME>> & 2) > 2023.None)
			{
				this.64 = new Random(1535.39.38);
				return;
			}
		}
		this.64 = new Random(2486.20);
	}

	// Token: 0x060035F7 RID: 13815 RVA: 0x00150F14 File Offset: 0x0014F114
	internal override void AddHitObject(2034 1, bool 2 = false, bool 3 = true)
	{
		if (!this.58)
		{
			if (this.59 < 0)
			{
				this.59 = 1.1;
			}
			this.60 = 1.2;
			if (1.IsNewCombo())
			{
				this.62.Add(1.1);
			}
			this.63.Add(1);
			return;
		}
		base.AddHitObject(1, 2, 3);
	}

	// Token: 0x060035F8 RID: 13816 RVA: 0x00150F79 File Offset: 0x0014F179
	internal override void RecalculateDifficulty(bool 1, bool 2, bool 3 = false)
	{
		base.RecalculateDifficulty(1, 2, true);
		if (this.21 != null)
		{
			this.2 = 1500;
		}
	}

	// Token: 0x060035F9 RID: 13817 RVA: 0x00150F98 File Offset: 0x0014F198
	internal override 2149 JudgeHitObject(2034 1)
	{
		if (1.11)
		{
			return (2149)0;
		}
		2149 2 = base.JudgeHitObject(1);
		if (2 > (2149)0)
		{
			float num = (float)(this.64.NextDouble() * 3.141592653589793 * 2.0);
			for (int i = 0; i < 5; i++)
			{
				double num2 = this.65[i] + (double)num;
				double num3 = 300.0 + this.64.NextDouble() * 100.0;
				2149 3 = 2 & (2149)520095488;
				if (3 != (2149)256)
				{
					if (3 == (2149)512)
					{
						num3 *= 0.4;
					}
				}
				else
				{
					num3 *= 0.01;
				}
				num3 *= Math.Pow((double)((2131)1).52, 4.0);
				208 value = new 208((float)(num3 * Math.Cos(num2)), (float)(num3 * Math.Sin(num2)));
				1433 4 = new 1433(1455.2("target-pt-" + (i + 1).ToString(), (1416)7, null), (1376)1, 1065.Centre, (1044)2, 1.GetEndPosition(), 0.99f, false, 1.7, null);
				4.14 = num;
				4.25(4.15 * 0.8f, 600, (1046)0);
				4.17(600);
				this.39.12(4);
				this.67.2(4, new 208?(value), false).3 = 100f;
				4 = new 1433(1455.2("targetoverlay-pt-" + (i + 1).ToString(), (1416)7, null), (1376)1, 1065.Centre, (1044)2, 1.GetEndPosition(), 1f, false, 198.White, null);
				4.14 = num;
				4.25(4.15 * 0.8f, 600, (1046)0);
				4.17(600);
				this.39.12(4);
				this.67.2(4, new 208?(value), false).3 = 100f;
			}
		}
		return 2;
	}

	// Token: 0x060035FA RID: 13818 RVA: 0x001511C0 File Offset: 0x0014F3C0
	protected internal override void PrepareHitObjects()
	{
		2133.2134 breakFinder = new 2133.2134();
		this.58 = true;
		this.21.83 = 0f;
		breakFinder.1 = (double)this.59;
		int num = 0;
		208 <<EMPTY_NAME>> = new 208(256f, 197f);
		double num2 = 0.0;
		double num3 = this.64.NextDouble() * 3.141592653589793 * 2.0;
		208 2 = default(208);
		Predicate<2275> <>9__0;
		while (breakFinder.1 < (double)this.60)
		{
			double num4 = (breakFinder.1 - (double)this.59) / (double)(this.60 - this.59);
			bool flag = (num & 7) == 0;
			if (this.61 < this.62.Count && breakFinder.1 >= (double)this.62[this.61])
			{
				this.61++;
			}
			if (flag)
			{
				num2 = (double)this.1 + (double)((int)(num4 * 40.0)) / 40.0 * 333.0;
			}
			double num5 = this.21.92(breakFinder.1).3() ? 1.2 : 1.0;
			if (flag)
			{
				num5 *= 1.5;
			}
			num3 += (this.64.NextDouble() - 0.5) * 2.0;
			2.X = <<EMPTY_NAME>>.X + (float)(num2 * num5 * Math.Cos(num3));
			2.Y = <<EMPTY_NAME>>.Y + (float)(num2 * num5 * Math.Sin(num3));
			int num6 = 0;
			while (2.X < 0f || 2.Y < 0f || 2.X > 512f || 2.Y > 384f || (num2 > (double)this.1 && this.75(2, num6)))
			{
				num3 = this.64.NextDouble() * 3.141592653589793 * 2.0;
				2.X = <<EMPTY_NAME>>.X + (float)(num2 * num5 * Math.Cos(num3));
				2.Y = <<EMPTY_NAME>>.Y + (float)(num2 * num5 * Math.Sin(num3));
				if (++num6 > 10)
				{
					num5 *= 0.9;
				}
			}
			<<EMPTY_NAME>> = 2;
			2131 3 = new 2131(this, <<EMPTY_NAME>> + new 208(0f, -10f), (int)breakFinder.1, flag, 1245.Normal, 0);
			List<2275> 4 = this.32.13;
			Predicate<2275> match;
			if ((match = <>9__0) == null)
			{
				match = (<>9__0 = ((2275 1) => (double)1.8 <= breakFinder.1 && (double)1.1 >= breakFinder.1));
			}
			if (4.Find(match) == null)
			{
				int num7 = this.63.BinarySearch(3);
				if (num7 < 0)
				{
					num7 = ~num7 - 1;
				}
				if (num7 >= 0 && num7 > this.66 && num7 < this.63.Count)
				{
					this.66 = num7;
					2034 5 = this.63[num7];
					3.35 = 5.35;
					3.36 = 5.36;
					3.4 = 5.4;
					3.37 = 5.37;
				}
				foreach (1433 6 in 3.30)
				{
					6.3.Add(new 1445(1456.Scale, 6.15 * 0.5f, 6.15, (int)breakFinder.1 - this.2, (int)breakFinder.1, (1046)0));
				}
				this.AddCircle(3);
			}
			num++;
			breakFinder.1 += this.21.90(breakFinder.1, false);
		}
		base.2(false);
		base.PrepareHitObjects();
	}

	// Token: 0x060035FB RID: 13819 RVA: 0x0015162C File Offset: 0x0014F82C
	private bool 75(208 1, int 2)
	{
		int num = 5;
		float num2 = 2.5f * (1f - (float)2 / 10f);
		int num3 = 0;
		while (num3++ < num && this.35 - num3 - 1 >= 0)
		{
			if (208.Distance(1, this.34[this.35 - num3 - 1].8) < this.1 * num2)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060035FC RID: 13820 RVA: 0x00151698 File Offset: 0x0014F898
	internal override void RebuildTimeWindowObjects()
	{
		this.67.3();
		foreach (2034 <<EMPTY_NAME>> in this.36)
		{
			<<EMPTY_NAME>>.8 = <<EMPTY_NAME>>.30[0].17;
		}
		base.RebuildTimeWindowObjects();
	}

	// Token: 0x060035FD RID: 13821 RVA: 0x0015170C File Offset: 0x0014F90C
	public 2133() : base(true)
	{
	}

	// Token: 0x0400280C RID: 10252
	private bool 58;

	// Token: 0x0400280D RID: 10253
	private new int 59 = -1;

	// Token: 0x0400280E RID: 10254
	private new int 60;

	// Token: 0x0400280F RID: 10255
	private new int 61;

	// Token: 0x04002810 RID: 10256
	private new List<int> 62 = new List<int>();

	// Token: 0x04002811 RID: 10257
	private new List<2034> 63 = new List<2034>();

	// Token: 0x04002812 RID: 10258
	private new Random 64;

	// Token: 0x04002813 RID: 10259
	private new double[] 65 = new double[]
	{
		-1.5707963267948966,
		0.0,
		1.0471975511965976,
		1.5707963267948966,
		3.141592653589793
	};

	// Token: 0x04002814 RID: 10260
	private new int 66;

	// Token: 0x04002815 RID: 10261
	private new 1400 67 = new 1400();

	// Token: 0x02000721 RID: 1825
	[276]
	public sealed class 2134
	{
		// Token: 0x04002816 RID: 10262
		public double 1;
	}
}
