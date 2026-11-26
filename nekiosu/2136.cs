using System;

// Token: 0x0200070B RID: 1803
[276]
public sealed class 2136 : 2241
{
	// Token: 0x0600351C RID: 13596 RVA: 0x00147AA6 File Offset: 0x00145CA6
	public 2136(1262 1, string 2) : base(1, 2)
	{
	}

	// Token: 0x0600351D RID: 13597 RVA: 0x00147AB0 File Offset: 0x00145CB0
	public 2136(2241 1)
	{
		this.18 = 1.18;
		this.34 = 1.34;
		this.10 = 1.10;
		this.23 = 1.23;
		this.2 = 1.2;
		this.1 = 1.1;
		this.3 = 1.3;
		this.4 = 1.4;
		this.5 = 1.5;
		this.6 = 1.6;
		this.SetRawScore(1.GetScore());
		this.13 = 1.13;
		this.22 = 1.22;
		this.8 = 1.8;
		this.24 = 1.24;
		this.7 = 1.7;
	}

	// Token: 0x0600351E RID: 13598 RVA: 0x00147B83 File Offset: 0x00145D83
	internal override float CalculateAccuracy()
	{
		return this.68 / (float)this.GetJudgementCount();
	}

	// Token: 0x0600351F RID: 13599 RVA: 0x00147B94 File Offset: 0x00145D94
	internal override 2236 CalculateGrade()
	{
		float num = (float)this.3 / (float)this.GetJudgementCount();
		if (this.CalculateAccuracy().CompareTo(1f) == 0 && this.22)
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
		if ((double)this.CalculateAccuracy() > 0.9 && (double)num <= 0.01 && this.22)
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
		if (((double)this.CalculateAccuracy() > 0.8 && this.22) || (double)this.CalculateAccuracy() > 0.9)
		{
			return 2236.A;
		}
		if (((double)this.CalculateAccuracy() > 0.7 && this.22) || (double)this.CalculateAccuracy() > 0.8)
		{
			return 2236.B;
		}
		if ((double)this.CalculateAccuracy() > 0.6)
		{
			return 2236.C;
		}
		return 2236.D;
	}

	// Token: 0x06003520 RID: 13600 RVA: 0x00147CBE File Offset: 0x00145EBE
	protected override void ReadExtraReplayData(1647 1)
	{
		this.68 = (float)1.ReadDouble();
	}

	// Token: 0x06003521 RID: 13601 RVA: 0x00147CCD File Offset: 0x00145ECD
	protected override void WriteExtraReplayData(1648 1)
	{
		1.Write((double)this.68);
	}

	// Token: 0x0400276D RID: 10093
	internal float 68;
}
