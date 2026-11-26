using System;
using System.Linq;

// Token: 0x020007BC RID: 1980
public sealed class 1878 : 2153
{
	// Token: 0x060039C9 RID: 14793 RVA: 0x0013F7E0 File Offset: 0x0013D9E0
	public 1878(2241 1) : base(1)
	{
	}

	// Token: 0x060039CA RID: 14794 RVA: 0x0016CFD4 File Offset: 0x0016B1D4
	internal override int GetScore()
	{
		if (this.BaselineJudgementCount == 0)
		{
			return 0;
		}
		double num = (this.6 == 0) ? 0.0 : ((double)this.7 / (double)this.6);
		return (int)Math.Round(((600000.0 + 400000.0 * (1.0 - this.5)) * this.2 / this.BaselineComboScore + 400000.0 * this.5 * num + this.3) * 2019.9(this.1, true));
	}

	// Token: 0x060039CB RID: 14795 RVA: 0x0016D070 File Offset: 0x0016B270
	internal override void Reset(bool 1 = false)
	{
		int num = this.4.Count(new Func<2155, bool>(1878.1879.Instance.1));
		bool flag = this.4.Count > 0;
		base.Reset(1);
		if (flag && 1)
		{
			this.6 = this.7;
			if (num + this.BaselineJudgementCount == 0)
			{
				this.5 = 0.0;
			}
			else
			{
				this.5 = (double)num / (double)(num + this.BaselineJudgementCount);
			}
		}
		this.7 = 0;
	}

	// Token: 0x060039CC RID: 14796 RVA: 0x0016D0F2 File Offset: 0x0016B2F2
	protected override void OnEventsTrimmed()
	{
		this.7 = this.4.Count(new Func<2155, bool>(1878.1879.Instance.1));
	}

	// Token: 0x060039CD RID: 14797 RVA: 0x0016D118 File Offset: 0x0016B318
	protected override void AccumulateEvent(2155 1)
	{
		if ((1.4 & (2149)16) > (2149)0)
		{
			this.7++;
			return;
		}
		if ((1.4 & (2149)24576) > (2149)0)
		{
			this.3 += (double)1.GetBaseScore();
			return;
		}
		this.2 += (double)1.GetBaseScore() * Math.Min(Math.Max(0.5, Math.Log((double)1.3, 4.0)), Math.Log(200.0, 4.0));
	}

	// Token: 0x04002AC0 RID: 10944
	private double 5;

	// Token: 0x04002AC1 RID: 10945
	private int 6;

	// Token: 0x04002AC2 RID: 10946
	private int 7;

	// Token: 0x020007BD RID: 1981
	[Serializable]
	public sealed class 1879
	{
		// Token: 0x060039CE RID: 14798 RVA: 0x0016D1B8 File Offset: 0x0016B3B8
		internal bool 1(2155 1)
		{
			return (1.4 & (2149)16) > (2149)0;
		}

		// Token: 0x04002AC3 RID: 10947
		public static readonly 1878.1879 Instance = new 1878.1879();

		// Token: 0x04002AC4 RID: 10948
		public static Func<2155, bool> func;
	}
}
