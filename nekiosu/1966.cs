using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200077E RID: 1918
public sealed class 1966 : 2072
{
	// Token: 0x06003846 RID: 14406 RVA: 0x00160380 File Offset: 0x0015E580
	public 1966(2039 1, 208 2, int 3, 1245 4, 1965 5, bool[] 6) : base(1)
	{
		this.44 = new List<1979>();
		this.45 = 5;
		this.46 = 6;
		this.8 = 2;
		this.18 = 2;
		this.1 = 3;
		this.4 = 4;
		for (int i = 0; i < 6.Length; i++)
		{
			if (6[i])
			{
				this.47++;
				this.48 = i;
			}
		}
	}

	// Token: 0x06003847 RID: 14407 RVA: 0x001603F8 File Offset: 0x0015E5F8
	internal new void 9()
	{
		this.49 = (this.28.33 as 1971);
		if ((this.45 & (1965)4) == (1965)0)
		{
			if (this.4.2(1245.Finish) && this.28.41.19.Count != 8)
			{
				this.45 |= (1965)256;
			}
			else if (this.4.2(1245.Clap))
			{
				this.45 |= (1965)128;
			}
		}
		if ((this.45 & (1965)8192) > (1965)0 || this.28.41.19.Count == 1)
		{
			this.14(this.28.41.49(this.8, false));
			this.15();
			return;
		}
		if ((this.45 & (1965)512) > (1965)0 && this.47 > 0)
		{
			for (int i = this.28.41.43(); i < this.46.Length; i++)
			{
				if (this.46[i])
				{
					this.14(this.28.41.19.Count - i - 1 + this.28.41.43());
				}
			}
			this.15();
			return;
		}
		if ((this.45 & (1965)1024) > (1965)0 && this.47 == 1 && (this.28.41.19.Count != 8 || this.48 != 0) && (this.28.41.19.Count % 2 == 0 || this.48 != this.28.41.19.Count / 2))
		{
			this.48 = this.28.41.19.Count - this.48 - 1 + this.28.41.43();
			this.14(this.48);
			this.15();
			return;
		}
		if ((this.45 & (1965)1) > (1965)0 && this.47 > 0)
		{
			for (int j = this.28.41.43(); j < this.46.Length; j++)
			{
				if (this.46[j])
				{
					this.14(j);
				}
			}
			this.15();
			return;
		}
		if ((this.45 & (1965)6144) > (1965)0 && this.47 == 1)
		{
			if ((this.45 & (1965)2048) > (1965)0)
			{
				this.48++;
				if (this.48 == this.28.41.19.Count)
				{
					this.48 = this.28.41.43();
				}
			}
			else
			{
				this.48--;
				if (this.48 == this.28.41.43() - 1)
				{
					this.48 = this.28.41.19.Count - 1;
				}
			}
			this.14(this.48);
			this.15();
			return;
		}
		if ((this.45 & (1965)4) > (1965)0)
		{
			this.12(1);
			this.15();
			return;
		}
		if ((this.45 & (1965)256) > (1965)0)
		{
			if (this.28.21.28() > 6.5)
			{
				this.11(0.88f, 0.88f, 0.62f);
			}
			else if (this.28.21.28() > 4.0)
			{
				this.11(0.88f, 1f, 0.83f);
			}
			else
			{
				this.11(0.88f, 1f, 1f);
			}
		}
		else if (this.28.21.28() > 6.5)
		{
			if ((this.45 & (1965)8) > (1965)0)
			{
				this.10(1f, 1f, 0.58f, 0.22f);
			}
			else
			{
				this.10(1f, 1f, 0.38f, 0f);
			}
		}
		else if (this.28.21.28() > 4.0)
		{
			if ((this.45 & (1965)8) > (1965)0)
			{
				this.10(1f, 1f, 0.92f, 0.65f);
			}
			else
			{
				this.10(1f, 1f, 0.85f, 0.48f);
			}
		}
		else if (this.28.21.28() > 2.0)
		{
			if ((this.45 & (1965)8) > (1965)0)
			{
				this.10(1f, 1f, 1f, 0.82f);
			}
			else
			{
				this.10(1f, 1f, 1f, 0.55f);
			}
		}
		else
		{
			this.10(1f, 1f, 1f, 1f);
		}
		if (this.28.41.43() > 0 && this.4.2(1245.Finish | 1245.Clap))
		{
			this.14(0);
		}
		this.15();
	}

	// Token: 0x06003848 RID: 14408 RVA: 0x00160938 File Offset: 0x0015EB38
	private new void 10(float 1, float 2, float 3, float 4)
	{
		switch (this.28.41.19.Count)
		{
		case 2:
			1 = 1f;
			2 = 1f;
			3 = 1f;
			4 = 1f;
			break;
		case 3:
			1 = 1f;
			2 = 1f;
			3 = 1f;
			4 = Math.Max(4, 0.9f);
			break;
		case 4:
			1 = 1f;
			2 = 1f;
			3 = Math.Max(3, 0.96f);
			4 = Math.Max(4, 0.77f);
			break;
		case 5:
			1 = 1f;
			2 = Math.Max(2, 0.97f);
			3 = Math.Max(3, 0.85f);
			break;
		}
		if (this.4.2(1245.Clap))
		{
			4 = 0f;
		}
		int 5 = this.49.1(4, 3, 2, 1, 1f);
		this.12(5);
	}

	// Token: 0x06003849 RID: 14409 RVA: 0x00160A3C File Offset: 0x0015EC3C
	private new void 11(float 1, float 2, float 3)
	{
		if ((this.45 & (1965)2) > (1965)0)
		{
			this.10(2, (3 + 2) / 2f, 3, 3 / 2f);
			return;
		}
		switch (this.28.41.19.Count)
		{
		case 2:
			3 = 1f;
			2 = 1f;
			1 = 1f;
			break;
		case 3:
			3 = 1f;
			2 = 1f;
			1 = Math.Max(0.97f, 1);
			break;
		case 4:
			3 = Math.Max(0.8f, 3 * 2f);
			2 = 1f;
			1 = 1f;
			break;
		case 5:
			2 = 1f;
			1 = Math.Max(0.97f, 1);
			break;
		case 6:
			3 = Math.Max(0.5f, 3 * 2f);
			2 = Math.Max(0.85f, 2 * 2f);
			1 = 1f;
			break;
		}
		double num = this.49.2.3();
		bool flag = false;
		if (num > (double)1)
		{
			flag = true;
		}
		num = this.49.2.3();
		if (num >= (double)2)
		{
			this.13(3);
			flag = false;
		}
		else if (num >= (double)3)
		{
			this.13(2);
		}
		else
		{
			this.13(1);
		}
		if (flag && this.28.41.19.Count % 2 != 0)
		{
			this.14(this.28.41.19.Count / 2);
		}
	}

	// Token: 0x0600384A RID: 14410 RVA: 0x00160BCC File Offset: 0x0015EDCC
	private void 12(int 1)
	{
		if ((this.45 & (1965)2) > (1965)0)
		{
			int num = this.28.41.19.Count - this.28.41.43();
			for (int i = 0; i < this.28.41.19.Count; i++)
			{
				num -= ((this.46[i] > false) ? 1 : 0);
			}
			if (1 > num)
			{
				1 = num;
			}
		}
		int num2 = this.28.41.49(this.8, true);
		bool[] array = new bool[this.28.41.19.Count];
		while (1 > 0)
		{
			while (array[num2] || (this.46[num2] && (this.45 & (1965)2) > (1965)0))
			{
				if ((this.45 & (1965)128) > (1965)0)
				{
					num2++;
					if (num2 == this.28.41.19.Count)
					{
						num2 = this.28.41.43();
					}
				}
				else
				{
					num2 = this.49.2.Next(this.28.41.43(), this.28.41.19.Count);
				}
			}
			this.14(num2);
			array[num2] = true;
			1--;
		}
	}

	// Token: 0x0600384B RID: 14411 RVA: 0x00160D20 File Offset: 0x0015EF20
	private new void 13(int 1)
	{
		bool[] array = new bool[this.28.41.19.Count];
		int 2 = (this.28.41.19.Count % 2 == 0) ? (this.28.41.19.Count / 2) : ((this.28.41.19.Count - 1) / 2);
		int num = this.49.2.Next(this.28.41.43(), 2);
		for (int i = 0; i < 1; i++)
		{
			while (array[num])
			{
				num = this.49.2.Next(this.28.41.43(), 2);
			}
			array[num] = true;
			array[this.28.41.19.Count - num - 1 + this.28.41.43()] = true;
			this.14(num);
			this.14(this.28.41.19.Count - num - 1 + this.28.41.43());
		}
	}

	// Token: 0x0600384C RID: 14412 RVA: 0x00160E54 File Offset: 0x0015F054
	private new void 14(int 1)
	{
		1979 2 = new 1979(this.28, 1, this.1, this.4);
		2.35 = this.35;
		2.36 = this.36;
		2.37 = this.37;
		this.44.Add(2);
	}

	// Token: 0x0600384D RID: 14413 RVA: 0x00160EAC File Offset: 0x0015F0AC
	private new void 15()
	{
		1966.1967 CS_0024_003C_003E8__locals9 = new 1966.1967();
		CS_0024_003C_003E8__locals9.2 = this.44.Count;
		if (CS_0024_003C_003E8__locals9.2 == 0)
		{
			return;
		}
		CS_0024_003C_003E8__locals9.1 = this.34;
		if ((this.45 & (1965)8192) == (1965)0)
		{
			if (this.34 != 0)
			{
				CS_0024_003C_003E8__locals9.1 = Math.Min(this.34, this.34 * 4 / 3 / CS_0024_003C_003E8__locals9.2);
			}
			else
			{
				1259 <<EMPTY_NAME>> = this.28.21.92((double)this.1);
				if (<<EMPTY_NAME>> != null)
				{
					CS_0024_003C_003E8__locals9.1 = Math.Min(<<EMPTY_NAME>>.6, <<EMPTY_NAME>>.6 * 4 / 3 / CS_0024_003C_003E8__locals9.2);
				}
			}
		}
		this.44.ForEach(delegate(1979 1)
		{
			1.34 = CS_0024_003C_003E8__locals9.1;
			1.50 = CS_0024_003C_003E8__locals9.2;
		});
	}

	// Token: 0x0600384E RID: 14414 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool IsActive()
	{
		return true;
	}

	// Token: 0x0600384F RID: 14415 RVA: 0x0000FF75 File Offset: 0x0000E175
	public override int GetComboNumber()
	{
		return 0;
	}

	// Token: 0x06003850 RID: 14416 RVA: 0x00005ADD File Offset: 0x00003CDD
	public override void SetComboNumber(int 1)
	{
	}

	// Token: 0x06003851 RID: 14417 RVA: 0x00160FA1 File Offset: 0x0015F1A1
	[CompilerGenerated]
	public override bool IsNewCombo()
	{
		return this.50;
	}

	// Token: 0x06003852 RID: 14418 RVA: 0x00160FA9 File Offset: 0x0015F1A9
	[CompilerGenerated]
	public override void SetNewCombo(bool 1)
	{
		this.50 = 1;
	}

	// Token: 0x06003853 RID: 14419 RVA: 0x0013FA97 File Offset: 0x0013DC97
	public override 208 GetEndPosition()
	{
		return this.8;
	}

	// Token: 0x06003854 RID: 14420 RVA: 0x00053ADC File Offset: 0x00051CDC
	public override void SetEndPosition(208 1)
	{
		throw new NotImplementedException();
	}

	// Token: 0x06003855 RID: 14421 RVA: 0x00160FB2 File Offset: 0x0015F1B2
	internal override void SetComboColour(198 1)
	{
		this.7 = 1;
	}

	// Token: 0x06003856 RID: 14422 RVA: 0x00160FBB File Offset: 0x0015F1BB
	internal override 2149 GetOrCalculateJudgement()
	{
		return this.14;
	}

	// Token: 0x06003857 RID: 14423 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void ApplyJudgementAnimation(bool 1)
	{
	}

	// Token: 0x06003858 RID: 14424 RVA: 0x00053ADC File Offset: 0x00051CDC
	internal override 2034 Clone()
	{
		throw new NotImplementedException();
	}

	// Token: 0x06003859 RID: 14425 RVA: 0x00053ADC File Offset: 0x00051CDC
	internal override void OnSelected()
	{
		throw new NotImplementedException();
	}

	// Token: 0x0600385A RID: 14426 RVA: 0x00053ADC File Offset: 0x00051CDC
	internal override void OnDeselected()
	{
		throw new NotImplementedException();
	}

	// Token: 0x0600385B RID: 14427 RVA: 0x00053ADC File Offset: 0x00051CDC
	internal override void SetStartTime(int 1)
	{
		throw new NotImplementedException();
	}

	// Token: 0x0600385C RID: 14428 RVA: 0x00160FC4 File Offset: 0x0015F1C4
	internal override void SetPosition(208 1, bool 2 = false)
	{
		1966.1968 3 = new 1966.1968();
		3.1 = 1;
		base.SetPosition(3.1, 2);
		this.30.ForEach(new Action<1433>(3.1));
	}

	// Token: 0x0600385D RID: 14429 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal override 2149 JudgeAtPosition(208 1)
	{
		return (2149)0;
	}

	// Token: 0x0600385E RID: 14430 RVA: 0x00053ADC File Offset: 0x00051CDC
	internal override void SetEndTime(int 1)
	{
		throw new NotImplementedException();
	}

	// Token: 0x040029A8 RID: 10664
	internal List<1979> 44;

	// Token: 0x040029A9 RID: 10665
	private 1965 45;

	// Token: 0x040029AA RID: 10666
	private bool[] 46;

	// Token: 0x040029AB RID: 10667
	private int 47;

	// Token: 0x040029AC RID: 10668
	private int 48;

	// Token: 0x040029AD RID: 10669
	private 1971 49;

	// Token: 0x040029AE RID: 10670
	private bool 50;

	// Token: 0x0200077F RID: 1919
	public sealed class 1968
	{
		// Token: 0x0600385F RID: 14431 RVA: 0x00161002 File Offset: 0x0015F202
		internal void 1(1433 1)
		{
			1.17 = this.1;
		}

		// Token: 0x040029AF RID: 10671
		public 208 1;
	}

	// Token: 0x02000780 RID: 1920
	public sealed class 1967
	{
		// Token: 0x040029B0 RID: 10672
		public int 1;

		// Token: 0x040029B1 RID: 10673
		public int 2;
	}
}
