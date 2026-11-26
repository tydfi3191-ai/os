using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x020007F0 RID: 2032
[276]
public abstract class 2153
{
	// Token: 0x06003ADC RID: 15068 RVA: 0x001738A5 File Offset: 0x00171AA5
	public 2153(2241 1)
	{
		this.1 = 1;
	}

	// Token: 0x06003ADD RID: 15069
	internal abstract int GetScore();

	// Token: 0x06003ADE RID: 15070 RVA: 0x001738C0 File Offset: 0x00171AC0
	internal virtual void Reset(bool 1)
	{
		if (this.4.Count > 0 && 1)
		{
			this.BaselineCombo = this.4.Last<2155>().3;
			this.BaselineJudgementCount = this.4.Count(new Func<2155, bool>(2153.2154.Instance.1));
			this.BaselineComboScore = this.2;
		}
		this.2 = 0.0;
		this.3 = 0.0;
		this.4.Clear();
	}

	// Token: 0x170002A7 RID: 679
	// (get) Token: 0x06003ADF RID: 15071 RVA: 0x0017394B File Offset: 0x00171B4B
	internal int EventCount
	{
		get
		{
			return this.4.Count;
		}
	}

	// Token: 0x06003AE0 RID: 15072 RVA: 0x00173958 File Offset: 0x00171B58
	internal void 1(int 1)
	{
		if (1 < this.4.Count)
		{
			this.4.RemoveRange(1, this.4.Count - 1);
		}
		this.OnEventsTrimmed();
	}

	// Token: 0x06003AE1 RID: 15073 RVA: 0x00005ADD File Offset: 0x00003CDD
	protected virtual void OnEventsTrimmed()
	{
	}

	// Token: 0x06003AE2 RID: 15074 RVA: 0x00173988 File Offset: 0x00171B88
	internal void 2(2155 1)
	{
		if (this.4.Count > 0)
		{
			1.3 = this.4.Last<2155>().3;
		}
		if (1.2)
		{
			if (1.4 > (2149)0)
			{
				1.3++;
			}
			else
			{
				1.3 = 0;
			}
		}
		this.4.Add(1);
		this.AccumulateEvent(1);
	}

	// Token: 0x06003AE3 RID: 15075 RVA: 0x001739F4 File Offset: 0x00171BF4
	protected virtual void AccumulateEvent(2155 1)
	{
		if ((1.4 & (2149)24576) > (2149)0)
		{
			this.3 += (double)1.GetBaseScore();
			return;
		}
		this.2 += (double)1.GetBaseScore() * (1.0 + (double)1.3 / 10.0);
	}

	// Token: 0x04002B98 RID: 11160
	protected 2241 1;

	// Token: 0x04002B99 RID: 11161
	protected int BaselineCombo;

	// Token: 0x04002B9A RID: 11162
	protected int BaselineJudgementCount;

	// Token: 0x04002B9B RID: 11163
	protected double BaselineComboScore;

	// Token: 0x04002B9C RID: 11164
	internal double 2;

	// Token: 0x04002B9D RID: 11165
	internal double 3;

	// Token: 0x04002B9E RID: 11166
	protected List<2155> 4 = new List<2155>();

	// Token: 0x020007F1 RID: 2033
	[276]
	[Serializable]
	public sealed class 2154
	{
		// Token: 0x06003AE4 RID: 15076 RVA: 0x00173A55 File Offset: 0x00171C55
		internal bool 1(2155 1)
		{
			return (1.4 & (2149)520095488) > (2149)0;
		}

		// Token: 0x04002B9F RID: 11167
		public static readonly 2153.2154 Instance = new 2153.2154();

		// Token: 0x04002BA0 RID: 11168
		public static Func<2155, bool> func;
	}
}
