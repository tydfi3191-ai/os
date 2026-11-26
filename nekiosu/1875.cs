using System;

// Token: 0x020007D2 RID: 2002
public sealed class 1875 : 2039
{
	// Token: 0x06003A36 RID: 14902 RVA: 0x0016E62C File Offset: 0x0016C82C
	internal 1875(bool 1 = true) : base(1)
	{
		if (this.39 != null)
		{
			this.39.6(true, null);
		}
	}

	// Token: 0x06003A37 RID: 14903 RVA: 0x0016E664 File Offset: 0x0016C864
	internal override 2037 CreateHitObjectFactory()
	{
		return new 1870(this);
	}

	// Token: 0x06003A38 RID: 14904 RVA: 0x0016E66C File Offset: 0x0016C86C
	protected internal override void AddSlider(2063 1)
	{
		((1871)1).RebuildPathAndTiming(false);
		foreach (1866 2 in ((1871)1).94)
		{
			2.52 = 1.1;
			2.53 = 1.2;
			this.AddHitObject(2, false, true);
		}
	}

	// Token: 0x06003A39 RID: 14905 RVA: 0x0016E6EC File Offset: 0x0016C8EC
	protected internal override void AddSpinner(2070 1)
	{
		foreach (1860 2 in ((1862)1).43)
		{
			2.52 = 1.1;
			2.53 = 1.2;
			this.AddHitObject(2, false, true);
		}
	}

	// Token: 0x06003A3A RID: 14906 RVA: 0x00005ADD File Offset: 0x00003CDD
	protected internal override void PrepareHitObjects()
	{
	}

	// Token: 0x06003A3B RID: 14907 RVA: 0x0016E760 File Offset: 0x0016C960
	internal override void ResetConversionState()
	{
		base.ResetConversionState();
		this.58 = null;
		this.59 = null;
		this.60 = false;
		this.61 = 0f;
		this.62 = 0f;
		this.63 = 1;
		this.64 = null;
	}

	// Token: 0x170002A0 RID: 672
	// (get) Token: 0x06003A3C RID: 14908 RVA: 0x0016E7AC File Offset: 0x0016C9AC
	private bool IsRandomActive
	{
		get
		{
			return this.47 != null && this.47.7 != null;
		}
	}

	// Token: 0x06003A3D RID: 14909 RVA: 0x0016E7C6 File Offset: 0x0016C9C6
	internal void 75(float 1)
	{
		this.64 = (this.IsRandomActive ? this.79(1, 1, 1, 1) : null);
	}

	// Token: 0x06003A3E RID: 14910 RVA: 0x0016E7E4 File Offset: 0x0016C9E4
	internal void 76(1871 1)
	{
		if (!this.IsRandomActive)
		{
			this.64 = null;
			return;
		}
		if (1.95 == null)
		{
			float x = 1.8.X;
			float x2 = 1.GetEndPosition().X;
			float num = Math.Min(x, x2);
			float num2 = Math.Max(x, x2);
			if (1.55 != null)
			{
				foreach (1051 2 in 1.55)
				{
					num = Math.Min(num, Math.Min(2.1.X, 2.2.X));
					num2 = Math.Max(num2, Math.Max(2.1.X, 2.2.X));
				}
			}
			1.95 = this.79(x, x2, num, num2);
		}
		this.64 = 1.95;
	}

	// Token: 0x06003A3F RID: 14911 RVA: 0x0016E8E4 File Offset: 0x0016CAE4
	internal void 77()
	{
		this.64 = null;
	}

	// Token: 0x06003A40 RID: 14912 RVA: 0x0016E8ED File Offset: 0x0016CAED
	internal float 78(float 1)
	{
		if (this.64 != null)
		{
			return this.64.1(1);
		}
		return 1;
	}

	// Token: 0x06003A41 RID: 14913 RVA: 0x0016E908 File Offset: 0x0016CB08
	private 1875.1876 79(float 1, float 2, float 3, float 4)
	{
		1938 5 = this.47.7;
		if (this.58 == null)
		{
			this.58 = new Random(5.4);
			this.59 = new Random(5.4 * 31 + 17);
		}
		bool flag = this.58.Next(2) != 0;
		bool flag2 = 5.HasDefaultStrength || this.59.Next(100) < 5.9;
		1875.1876 6 = new 1875.1876
		{
			1 = 1,
			2 = 1,
			3 = this.63
		};
		if (this.60)
		{
			int num = (flag && flag2) ? (-this.63) : this.63;
			float num2 = 1 - this.61;
			if (!this.80(6, num, num2, 1, 3, 4) && !this.80(6, -num, num2, 1, 3, 4))
			{
				6.3 = num;
				6.2 = this.62 + (float)num * num2;
				float num3 = Math.Min(6.1(3), 6.1(4));
				float num4 = Math.Max(6.1(3), 6.1(4));
				if (num3 < 0f)
				{
					6.2 -= num3;
				}
				else if (num4 > 512f)
				{
					6.2 -= num4 - 512f;
				}
			}
		}
		this.63 = 6.3;
		this.60 = true;
		this.61 = 2;
		this.62 = 6.1(2);
		return 6;
	}

	// Token: 0x06003A42 RID: 14914 RVA: 0x0016EA9C File Offset: 0x0016CC9C
	private bool 80(1875.1876 1, int 2, float 3, float 4, float 5, float 6)
	{
		float num = this.62 + (float)2 * 3;
		float val = num + (float)2 * (5 - 4);
		float val2 = num + (float)2 * (6 - 4);
		if (Math.Min(val, val2) < 0f || Math.Max(val, val2) > 512f)
		{
			return false;
		}
		1.2 = num;
		1.3 = 2;
		return true;
	}

	// Token: 0x06003A43 RID: 14915 RVA: 0x0016EAF8 File Offset: 0x0016CCF8
	internal override int GetReplayOpenUntil(2034 1)
	{
		1866 2 = 1 as 1866;
		if (2 != null && 2.9())
		{
			return Math.Max(2.2, 2.48.1);
		}
		return 1.2;
	}

	// Token: 0x06003A44 RID: 14916 RVA: 0x0016EB34 File Offset: 0x0016CD34
	internal void 81(float 1)
	{
		int num = 0;
		float num2 = 1 / 2f;
		float num3 = num2;
		for (int i = 0; i < this.35 - 1; i++)
		{
			1866 2 = this.34[i] as 1866;
			if (!(2 is 1860) && !(2 is 1872))
			{
				2034 3 = this.34[i + 1];
				while ((3 is 1860 || 3 is 1872) && ++i != this.35 - 1)
				{
					3 = this.34[i + 1];
				}
				int num4 = (3.8.X > 2.8.X) ? 1 : -1;
				float num5 = (float)(3.1 - 2.2) - 4.1666665f;
				float num6 = Math.Abs(3.8.X - 2.8.X) - ((num == num4) ? num3 : num2);
				if (num5 < num6)
				{
					2.10(3);
					num3 = num2;
				}
				else
				{
					2.49 = num5 - num6;
					num3 = 1052.19(num5 - num6, 0f, num2);
				}
				num = num4;
			}
		}
	}

	// Token: 0x06003A45 RID: 14917 RVA: 0x0016EC6C File Offset: 0x0016CE6C
	internal override 2149 JudgeHitObject(2034 1)
	{
		if (1.11)
		{
			return (2149)0;
		}
		this.38 = 1;
		2149 2 = 1.GetOrCalculateJudgement();
		if (2486.88 != null)
		{
			2023 3 = this.22;
			2023 4 = 2023.Perfect;
			if ((3 & 4) > 2023.None && (2 & (2149)32) > (2149)0)
			{
				2 = (2149)(-131072);
			}
		}
		if (2 == (2149)(-131072))
		{
			this.29++;
		}
		int num = this.34.BinarySearch(1);
		this.31 = ((num < 0) ? (~num) : num);
		string 5 = string.Empty;
		if (this.31 == this.35 - 1 || this.34[this.31 + 1].IsNewCombo())
		{
			5 = ((this.29 == 0) ? "g" : "b");
			if (2 == (2149)1024 && this.29 == 0)
			{
				2 |= (2149)4;
			}
			this.29 = 0;
		}
		base.32(2, 5, 1);
		return 2;
	}

	// Token: 0x04002AEC RID: 10988
	private Random 58;

	// Token: 0x04002AED RID: 10989
	private new Random 59;

	// Token: 0x04002AEE RID: 10990
	private new bool 60;

	// Token: 0x04002AEF RID: 10991
	private new float 61;

	// Token: 0x04002AF0 RID: 10992
	private new float 62;

	// Token: 0x04002AF1 RID: 10993
	private new int 63 = 1;

	// Token: 0x04002AF2 RID: 10994
	private new 1875.1876 64;

	// Token: 0x020007D3 RID: 2003
	internal sealed class 1876
	{
		// Token: 0x06003A46 RID: 14918 RVA: 0x0016ED57 File Offset: 0x0016CF57
		public float 1(float 1)
		{
			return this.2 + (float)this.3 * (1 - this.1);
		}

		// Token: 0x04002AF3 RID: 10995
		public float 1;

		// Token: 0x04002AF4 RID: 10996
		public float 2;

		// Token: 0x04002AF5 RID: 10997
		public int 3 = 1;
	}
}
