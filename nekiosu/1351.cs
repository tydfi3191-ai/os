using System;
using System.Threading;

// Token: 0x02000A6F RID: 2671
public sealed class 1351 : 1433
{
	// Token: 0x06004A0A RID: 18954 RVA: 0x001D5424 File Offset: 0x001D3624
	internal 1351(1381[] 1, 1376 2, 1065 3, 1044 4, 208 5, float 6, bool 7, 198 8) : this(1, 2, 3, 4, 5, 6, 7, 8, null)
	{
	}

	// Token: 0x06004A0B RID: 18955 RVA: 0x001D5448 File Offset: 0x001D3648
	internal 1351(1381[] 1, 1376 2, 1065 3, 1044 4, 208 5, float 6, bool 7, 198 8, object 9) : base((1 == null || 1.Length == 0) ? null : 1[0], 2, 3, 4, 5, 6, 7, 8, 9)
	{
		if (1 != null)
		{
			this.55(1);
		}
	}

	// Token: 0x06004A0C RID: 18956 RVA: 0x001D54A0 File Offset: 0x001D36A0
	internal new void 49(1189 1)
	{
		1189 2 = this.82;
		1189 3;
		do
		{
			3 = 2;
			1189 value = (1189)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1189>(ref this.82, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06004A0D RID: 18957 RVA: 0x001D54D8 File Offset: 0x001D36D8
	internal override void SetIsReversed(bool 1)
	{
		if (base.GetIsReversed() == 1)
		{
			return;
		}
		if (!this.78 && this.76 > 0.0)
		{
			double num = (double)1436.25(this);
			if (this.77 < num)
			{
				int num2 = this.51() + 1;
				double num3 = (num - this.77) / this.76;
				double num4 = Math.Floor(num3 / (double)num2) * (double)num2;
				double num5 = (double)this.51() - (num3 - num4);
				this.77 = num - (num4 + num5) * this.76;
			}
		}
		base.SetIsReversed(1);
	}

	// Token: 0x06004A0E RID: 18958 RVA: 0x001D5568 File Offset: 0x001D3768
	internal new void 50(int 1)
	{
		if (1 < 0)
		{
			1 = 0;
		}
		this.74 = ((this.71 == 1446.LoopOnce) ? Math.Min(1, this.51()) : (1 % (this.51() + 1)));
		double num = (double)1436.25(this);
		int num2 = this.GetIsReversed() ? (1 - this.74 + (this.51() - this.74)) : 1;
		this.77 = num - (double)num2 * this.76;
		this.78 = false;
	}

	// Token: 0x06004A0F RID: 18959 RVA: 0x001D55E5 File Offset: 0x001D37E5
	public int 51()
	{
		if (this.58())
		{
			return this.56().Length - 1;
		}
		return this.73 - 1;
	}

	// Token: 0x06004A10 RID: 18960 RVA: 0x001D5602 File Offset: 0x001D3802
	internal new double 52()
	{
		return this.76;
	}

	// Token: 0x06004A11 RID: 18961 RVA: 0x001D560C File Offset: 0x001D380C
	internal new void 53(double 1)
	{
		if (this.76 == 1)
		{
			return;
		}
		if (!this.78 && this.76 > 0.0)
		{
			double num = (double)1436.25(this);
			if (this.77 < num)
			{
				double num2 = (num - this.77) / this.76;
				this.77 = ((this.71 == 1446.LoopOnce && num2 > (double)this.51()) ? (this.77 + (double)this.51() * this.76 - (double)this.51() * 1) : (num - num2 * 1));
			}
		}
		this.76 = 1;
	}

	// Token: 0x06004A12 RID: 18962 RVA: 0x001D56A3 File Offset: 0x001D38A3
	internal new 1381[] 54()
	{
		return this.80;
	}

	// Token: 0x06004A13 RID: 18963 RVA: 0x001D56AC File Offset: 0x001D38AC
	internal new void 55(1381[] 1)
	{
		if (1 == this.80)
		{
			return;
		}
		this.80 = 1;
		if (this.80 != null)
		{
			this.73 = this.80.Length;
			if (this.73 > 0)
			{
				base.SetTexture(this.80[0]);
			}
			else
			{
				base.SetTexture(null);
			}
		}
		else
		{
			this.73 = 0;
		}
		this.75 = 0;
		this.59();
	}

	// Token: 0x06004A14 RID: 18964 RVA: 0x001D5716 File Offset: 0x001D3916
	internal int[] 56()
	{
		return this.81;
	}

	// Token: 0x06004A15 RID: 18965 RVA: 0x001D571E File Offset: 0x001D391E
	internal void 57(int[] 1)
	{
		if (this.81 != 1)
		{
			this.81 = 1;
			this.59();
		}
	}

	// Token: 0x06004A16 RID: 18966 RVA: 0x001D5736 File Offset: 0x001D3936
	public bool 58()
	{
		return this.56() != null;
	}

	// Token: 0x06004A17 RID: 18967 RVA: 0x001D5741 File Offset: 0x001D3941
	internal override 1381 GetTexture()
	{
		if (this.54() == null || this.73 == 0)
		{
			return null;
		}
		return this.47;
	}

	// Token: 0x06004A18 RID: 18968 RVA: 0x001D575B File Offset: 0x001D395B
	internal new void 59()
	{
		this.78 = true;
		this.79 = false;
		this.74 = (this.GetIsReversed() ? this.51() : 0);
	}

	// Token: 0x06004A19 RID: 18969 RVA: 0x001D5784 File Offset: 0x001D3984
	public override 1069 Update()
	{
		1069 <<EMPTY_NAME>> = base.Update();
		if (<<EMPTY_NAME>> != (1069)0)
		{
			return <<EMPTY_NAME>>;
		}
		this.60();
		return (1069)0;
	}

	// Token: 0x06004A1A RID: 18970 RVA: 0x001D57A4 File Offset: 0x001D39A4
	internal void 60()
	{
		if (this.73 < 2)
		{
			return;
		}
		if (this.72 && this.76 > 0.0)
		{
			double num = (double)1436.25(this);
			if (!this.78 && num < this.77)
			{
				this.59();
			}
			if (this.78)
			{
				this.77 = ((this.3.Count > 0) ? ((double)this.3[0].9) : num);
				this.78 = false;
			}
			int num2 = (int)Math.Floor((num - this.77) / this.76);
			if (num2 < 0)
			{
				num2 = 0;
			}
			bool flag = false;
			if (this.71 == 1446.LoopOnce)
			{
				if (num2 > this.51())
				{
					num2 = this.51();
					if (!this.79)
					{
						flag = (this.79 = true);
					}
				}
				else
				{
					this.79 = false;
				}
			}
			else
			{
				num2 %= this.51() + 1;
				this.79 = false;
			}
			this.74 = (this.GetIsReversed() ? (this.51() - num2) : num2);
			if (flag && this.82 != null)
			{
				this.82();
			}
		}
		else
		{
			this.50(1052.18(this.74, 0, this.51()));
		}
		if (this.75 == this.74)
		{
			return;
		}
		this.47 = (this.58() ? this.54()[Math.Min(this.54().Length - 1, this.56()[this.74])] : this.54()[this.74]);
		if (this.GetTexture() != null)
		{
			if (!this.70)
			{
				this.ResetSourceRectangle();
			}
			if (this.49 != 1065.TopLeft)
			{
				this.UpdateOriginOffset();
			}
		}
		this.75 = this.74;
	}

	// Token: 0x06004A1B RID: 18971 RVA: 0x001D5960 File Offset: 0x001D3B60
	internal new void 61()
	{
		if (2630.5 != null && this.80 != null)
		{
			if (2630.5.AnimationFramerate > 0)
			{
				this.53((double)(1000f / (float)2630.5.AnimationFramerate));
				return;
			}
			this.53((double)(1000f / (float)this.54().Length));
		}
	}

	// Token: 0x06004A1C RID: 18972 RVA: 0x001D59B8 File Offset: 0x001D3BB8
	public override 1433 Clone()
	{
		1351 <<EMPTY_NAME>> = new 1351(this.54(), this.41, this.49, this.1, this.7, this.2, this.5, this.6, this.8);
		<<EMPTY_NAME>>.53(this.52());
		<<EMPTY_NAME>>.71 = this.71;
		foreach (1445 2 in this.3)
		{
			<<EMPTY_NAME>>.3.Add(2.Clone());
		}
		return <<EMPTY_NAME>>;
	}

	// Token: 0x04003721 RID: 14113
	public bool 70;

	// Token: 0x04003722 RID: 14114
	public 1446 71;

	// Token: 0x04003723 RID: 14115
	internal bool 72 = true;

	// Token: 0x04003724 RID: 14116
	internal int 73;

	// Token: 0x04003725 RID: 14117
	private int 74;

	// Token: 0x04003726 RID: 14118
	private int 75;

	// Token: 0x04003727 RID: 14119
	private double 76 = 16.666666666666668;

	// Token: 0x04003728 RID: 14120
	private double 77;

	// Token: 0x04003729 RID: 14121
	private bool 78 = true;

	// Token: 0x0400372A RID: 14122
	private bool 79;

	// Token: 0x0400372B RID: 14123
	private 1381[] 80;

	// Token: 0x0400372C RID: 14124
	private int[] 81;

	// Token: 0x0400372D RID: 14125
	private 1189 82;
}
