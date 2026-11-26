using System;

// Token: 0x020007BB RID: 1979
public sealed class 1877 : 2241
{
	// Token: 0x060039C0 RID: 14784 RVA: 0x0016CE91 File Offset: 0x0016B091
	internal 1877()
	{
		this.9 = 2147.CatchTheBeat;
	}

	// Token: 0x060039C1 RID: 14785 RVA: 0x0016CEA0 File Offset: 0x0016B0A0
	internal 1877(2247 1, string 2) : base(1, 2)
	{
		this.9 = 2147.CatchTheBeat;
	}

	// Token: 0x060039C2 RID: 14786 RVA: 0x0016CEB1 File Offset: 0x0016B0B1
	internal 1877(1262 1, string 2) : base(1, 2)
	{
		this.9 = 2147.CatchTheBeat;
	}

	// Token: 0x060039C3 RID: 14787 RVA: 0x0016CEC2 File Offset: 0x0016B0C2
	internal 1877(string 1, 1262 2) : base(1, 2)
	{
		this.9 = 2147.CatchTheBeat;
	}

	// Token: 0x060039C4 RID: 14788 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal override bool CanSkipUnchangedReplayFrames()
	{
		return false;
	}

	// Token: 0x060039C5 RID: 14789 RVA: 0x0016CED3 File Offset: 0x0016B0D3
	internal override int GetJudgementCount()
	{
		return (int)(this.3 + this.1 + this.2 + this.6 + this.5);
	}

	// Token: 0x060039C6 RID: 14790 RVA: 0x00139F29 File Offset: 0x00138129
	internal override int GetSuccessfulJudgementCount()
	{
		return (int)(this.3 + this.1 + this.2);
	}

	// Token: 0x060039C7 RID: 14791 RVA: 0x0016CEF7 File Offset: 0x0016B0F7
	internal override float CalculateAccuracy()
	{
		if (this.GetJudgementCount() == 0)
		{
			return 1f;
		}
		return (float)this.GetSuccessfulJudgementCount() / (float)this.GetJudgementCount();
	}

	// Token: 0x060039C8 RID: 14792 RVA: 0x0016CF18 File Offset: 0x0016B118
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
			2023 2 = 2023.Hidden;
			if ((<<EMPTY_NAME>> & 2) <= 2023.None)
			{
				2023 3 = this.8;
				2 = 2023.Flashlight;
				if ((3 & 2) <= 2023.None)
				{
					return 2236.X;
				}
			}
			return 2236.XH;
		}
		if ((double)num > 0.98)
		{
			2023 4 = this.8;
			2023 5 = 2023.Hidden;
			if ((4 & 5) <= 2023.None)
			{
				2023 6 = this.8;
				5 = 2023.Flashlight;
				if ((6 & 5) <= 2023.None)
				{
					return 2236.S;
				}
			}
			return 2236.SH;
		}
		if ((double)num > 0.94)
		{
			return 2236.A;
		}
		if ((double)num > 0.9)
		{
			return 2236.B;
		}
		if ((double)num > 0.85)
		{
			return 2236.C;
		}
		return 2236.D;
	}
}
