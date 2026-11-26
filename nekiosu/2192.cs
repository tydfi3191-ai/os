using System;
using System.Linq;

// Token: 0x020006D9 RID: 1753
public sealed class 2192 : 2153
{
	// Token: 0x0600340F RID: 13327 RVA: 0x0013F7E0 File Offset: 0x0013D9E0
	public 2192(2241 1) : base(1)
	{
	}

	// Token: 0x06003410 RID: 13328 RVA: 0x0013F7E9 File Offset: 0x0013D9E9
	internal new double 3()
	{
		return 250000.0 * this.2 / this.BaselineComboScore;
	}

	// Token: 0x06003411 RID: 13329 RVA: 0x0013F802 File Offset: 0x0013DA02
	internal new double 4()
	{
		return 750000.0 * Math.Pow((double)this.1.CalculateAccuracy(), 3.6) * ((double)this.1.GetJudgementCount() / (double)this.BaselineJudgementCount);
	}

	// Token: 0x06003412 RID: 13330 RVA: 0x0013F83D File Offset: 0x0013DA3D
	internal override int GetScore()
	{
		if (this.BaselineJudgementCount == 0)
		{
			return 0;
		}
		return (int)Math.Round((this.3() + this.4() + this.3) * 2019.9(this.1, true));
	}

	// Token: 0x06003413 RID: 13331 RVA: 0x0013F870 File Offset: 0x0013DA70
	internal override void Reset(bool 1 = false)
	{
		if (this.4.Count > 0 && 1)
		{
			this.BaselineCombo = this.4.Last<2155>().3;
			this.BaselineJudgementCount = this.4.Count(new Func<2155, bool>(2192.2193.Instance.1));
			this.BaselineComboScore = this.2;
		}
		this.2 = 0.0;
		this.3 = 0.0;
		this.4.Clear();
	}

	// Token: 0x06003414 RID: 13332 RVA: 0x0013F8FC File Offset: 0x0013DAFC
	protected override void AccumulateEvent(2155 1)
	{
		double num = (double)1.GetBaseScore();
		double num2 = (double)(((1.4 & (2149)32768) > (2149)0) ? 3 : 7);
		if ((1.4 & (2149)8388608) > (2149)0)
		{
			num *= num2;
		}
		else if ((1.4 & (2149)65536) > (2149)0)
		{
			num += num * num2;
		}
		if ((1.4 & (2149)32768) > (2149)0)
		{
			this.3 += num;
			return;
		}
		this.2 += num * Math.Min(Math.Max(0.5, Math.Log((double)1.3, 4.0)), Math.Log(400.0, 4.0));
	}

	// Token: 0x020006DA RID: 1754
	[Serializable]
	public sealed class 2193
	{
		// Token: 0x06003415 RID: 13333 RVA: 0x0013F9BC File Offset: 0x0013DBBC
		internal bool 1(2155 1)
		{
			return (1.4 & (2149)520095488) > (2149)0 && (1.4 & (2149)8388608) == (2149)0;
		}

		// Token: 0x040026CA RID: 9930
		public static readonly 2192.2193 Instance = new 2192.2193();

		// Token: 0x040026CB RID: 9931
		public static Func<2155, bool> func;
	}
}
