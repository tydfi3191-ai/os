using System;

// Token: 0x0200077A RID: 1914
public sealed class 1986 : 2241
{
	// Token: 0x06003836 RID: 14390 RVA: 0x00160022 File Offset: 0x0015E222
	internal 1986()
	{
		this.9 = 2147.OsuMania;
	}

	// Token: 0x06003837 RID: 14391 RVA: 0x00160031 File Offset: 0x0015E231
	internal 1986(2247 1, string 2) : base(1, 2)
	{
		this.9 = 2147.OsuMania;
	}

	// Token: 0x06003838 RID: 14392 RVA: 0x00160042 File Offset: 0x0015E242
	internal 1986(1262 1, string 2) : base(1, 2)
	{
		this.9 = 2147.OsuMania;
	}

	// Token: 0x06003839 RID: 14393 RVA: 0x00160053 File Offset: 0x0015E253
	internal 1986(string 1, 1262 2) : base(1, 2)
	{
		this.9 = 2147.OsuMania;
	}

	// Token: 0x0600383A RID: 14394 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal override bool CanSkipUnchangedReplayFrames()
	{
		return false;
	}

	// Token: 0x0600383B RID: 14395 RVA: 0x00160064 File Offset: 0x0015E264
	internal override float CalculateAccuracy()
	{
		if (this.GetJudgementCount() == 0)
		{
			return 1f;
		}
		if (this.39 == null)
		{
			2023 <<EMPTY_NAME>> = this.8;
			2023 2 = 2023.ScoreV2;
			if ((<<EMPTY_NAME>> & 2) <= 2023.None)
			{
				return (float)(this.3 * 50 + this.1 * 100 + this.5 * 200 + (this.2 + this.4) * 300) / (float)(this.GetJudgementCount() * 300);
			}
		}
		return (float)(this.3 * 50 + this.1 * 100 + this.5 * 200 + this.2 * 300 + this.4 * 305) / (float)(this.GetJudgementCount() * 305);
	}

	// Token: 0x0600383C RID: 14396 RVA: 0x0016012A File Offset: 0x0015E32A
	internal override int GetJudgementCount()
	{
		return (int)(this.3 + this.1 + this.2 + this.6 + this.4 + this.5);
	}

	// Token: 0x0600383D RID: 14397 RVA: 0x00160155 File Offset: 0x0015E355
	internal override int GetSuccessfulJudgementCount()
	{
		return (int)(this.3 + this.1 + this.2 + this.4 + this.5);
	}

	// Token: 0x0600383E RID: 14398 RVA: 0x0016017C File Offset: 0x0015E37C
	internal override 2236 CalculateGrade()
	{
		float num = this.CalculateAccuracy();
		if (!this.18)
		{
			return 2236.F;
		}
		if (num == 1f)
		{
			2023 <<EMPTY_NAME>> = this.8;
			2023 2 = 2023.Hidden | 2023.Flashlight | 2023.FadeIn;
			if ((<<EMPTY_NAME>> & 2) <= 2023.None)
			{
				return 2236.X;
			}
			return 2236.XH;
		}
		else if ((double)num > 0.95)
		{
			2023 3 = this.8;
			2023 4 = 2023.Hidden | 2023.Flashlight | 2023.FadeIn;
			if ((3 & 4) <= 2023.None)
			{
				return 2236.S;
			}
			return 2236.SH;
		}
		else
		{
			if ((double)num > 0.9)
			{
				return 2236.A;
			}
			if ((double)num > 0.8)
			{
				return 2236.B;
			}
			if ((double)num > 0.7)
			{
				return 2236.C;
			}
			return 2236.D;
		}
	}
}
