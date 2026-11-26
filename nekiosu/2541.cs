using System;

// Token: 0x0200054F RID: 1359
[276]
public class 2541
{
	// Token: 0x060029B4 RID: 10676 RVA: 0x000D8CC1 File Offset: 0x000D6EC1
	internal 2541(1436 1) : this(1, new 208(6f, 0f), true, 0.96f, true, true)
	{
	}

	// Token: 0x060029B5 RID: 10677 RVA: 0x000D8CE4 File Offset: 0x000D6EE4
	internal 2541(1436 1, 208 2, bool 3, float 4, bool 5, bool 6)
	{
		this.1 = 1;
		this.10 = 4;
		if (1662.47)
		{
			4 *= 1.4f;
		}
		float num = 2.Y;
		this.9 = 208.Zero;
		if (5)
		{
			this.2 = new 1353("00000000", 2630.HudSkin.FontScore, (float)2630.HudSkin.FontScoreOverlap, 3 ? ((1376)8) : ((1376)6), 3 ? 1065.TopRight : 1065.TopLeft, (1044)0, new 208(0f, 0f), 0.95f, true, 198.White, true, (1416)7);
			this.2.96 = true;
			this.9 = this.2.GetTextSize() * 0.625f * 4;
			this.2.17 = new 208(2.X, num);
			this.2.15 = 4;
			num += this.9.Y;
		}
		if (2630.21())
		{
			num += 3f;
		}
		if (6)
		{
			this.3 = new 1353("00.00%", 2630.HudSkin.FontScore, (float)2630.HudSkin.FontScoreOverlap, 3 ? ((1376)8) : ((1376)6), 3 ? 1065.TopRight : 1065.TopLeft, (1044)0, new 208(0f, 0f), 0.95f, true, 198.White, true, (1416)7);
			this.3.15 = 4 * (5 ? 0.6f : 1f);
			this.3.96 = true;
			this.3.17 = new 208(2.X, num);
			this.8 = this.3.17 + new 208(this.3.GetTextSize().X * 0.625f * this.3.15 + 24f, this.3.GetTextSize().Y * 0.625f * this.3.15 / 2f);
		}
		1.12(this.2);
		1.12(this.3);
	}

	// Token: 0x060029B6 RID: 10678 RVA: 0x000D8F0C File Offset: 0x000D710C
	internal bool 1(out 208 1, out float 2)
	{
		1 = 208.Zero;
		2 = 1f;
		if (this.3 == null)
		{
			return false;
		}
		2 = this.3.15;
		1 = new 208(this.3.17.X, this.3.17.Y + this.3.GetTextSize().Y * 0.625f * this.3.15 + 2f);
		return true;
	}

	// Token: 0x1700026E RID: 622
	// (get) Token: 0x060029B7 RID: 10679 RVA: 0x000D8F97 File Offset: 0x000D7197
	internal 1433 ScoreSprite
	{
		get
		{
			return this.2;
		}
	}

	// Token: 0x1700026F RID: 623
	// (get) Token: 0x060029B8 RID: 10680 RVA: 0x000D8F9F File Offset: 0x000D719F
	internal 1433 AccuracySprite
	{
		get
		{
			return this.3;
		}
	}

	// Token: 0x060029B9 RID: 10681 RVA: 0x000D8FA7 File Offset: 0x000D71A7
	internal float 2()
	{
		if (this.2 != null)
		{
			return (float)this.2.34 / 1.6f;
		}
		return 0f;
	}

	// Token: 0x060029BA RID: 10682 RVA: 0x000D8FCC File Offset: 0x000D71CC
	internal void 3()
	{
		if (this.3 != null && this.5 != this.7)
		{
			if (Math.Abs(this.5 - this.7) < 0.005)
			{
				this.5 = this.7;
			}
			else if (1662.10 > 0.0)
			{
				this.5 = this.7 + (this.5 - this.7) * Math.Pow(0.5, 1662.10);
			}
			this.3.SetText(string.Format("{0:00.00}%", this.5));
		}
		if (this.2 != null && this.4 != (double)this.6)
		{
			int num = (int)Math.Round(this.4);
			if (Math.Abs(this.4 - (double)this.6) < 0.5)
			{
				this.4 = (double)this.6;
			}
			else if (1662.10 > 0.0)
			{
				this.4 = (double)this.6 + (this.4 - (double)this.6) * Math.Pow(0.75, 1662.10);
			}
			int num2 = (int)Math.Round(this.4);
			if (num != num2)
			{
				this.2.SetText(string.Format("{0:00000000}", num2));
			}
		}
	}

	// Token: 0x060029BB RID: 10683 RVA: 0x000D913F File Offset: 0x000D733F
	internal virtual void SetScore(int 1)
	{
		this.6 = 1;
	}

	// Token: 0x060029BC RID: 10684 RVA: 0x000D9148 File Offset: 0x000D7348
	internal void 4(float 1)
	{
		this.7 = Math.Round((double)1, 2);
	}

	// Token: 0x060029BD RID: 10685 RVA: 0x000D9158 File Offset: 0x000D7358
	internal void Hide()
	{
		if (this.2 != null)
		{
			this.2.16(0, (1046)0, 0);
		}
		if (this.3 != null)
		{
			this.3.16(0, (1046)0, 0);
		}
	}

	// Token: 0x04001E52 RID: 7762
	protected readonly 1436 1;

	// Token: 0x04001E53 RID: 7763
	protected readonly 1353 2;

	// Token: 0x04001E54 RID: 7764
	protected readonly 1353 3;

	// Token: 0x04001E55 RID: 7765
	private double 4;

	// Token: 0x04001E56 RID: 7766
	private double 5;

	// Token: 0x04001E57 RID: 7767
	internal int 6;

	// Token: 0x04001E58 RID: 7768
	internal double 7;

	// Token: 0x04001E59 RID: 7769
	internal 208 8;

	// Token: 0x04001E5A RID: 7770
	protected 208 9;

	// Token: 0x04001E5B RID: 7771
	protected float 10;
}
