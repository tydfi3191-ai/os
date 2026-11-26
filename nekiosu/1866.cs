using System;
using System.Runtime.CompilerServices;

// Token: 0x020007C7 RID: 1991
public class 1866 : 2072
{
	// Token: 0x060039F6 RID: 14838 RVA: 0x0016D718 File Offset: 0x0016B918
	public 1866(2039 1, 208 2, int 3, bool 4, 1245 5, string 6) : base(11)
	{
		1875 7 = 11 as 1875;
		float num = 1052.19((7 != null) ? 7.78(2.X) : 2.X, 0f, 512f);
		if (11.47 != null && 11.47.5 != null && 11 is 1875)
		{
			num = 512f - num;
		}
		this.8 = new 208(num, 340f);
		this.18 = this.8;
		this.1 = 3;
		this.2 = 3;
		this.4 = 5;
		this.SetNewCombo(4);
		if (11.39 != null)
		{
			1866.1867 catchFruitClosure = new 1866.1867();
			this.44 = new 1433(1455.2("fruit-" + 6, (1416)7, null), (1376)1, 1065.Centre, (1044)1, this.8, 1436.32((float)this.1), false, 198.White, null);
			this.30.Add(this.44);
			this.29.Add(this.44);
			this.44.9 = 1;
			this.45 = new 1433(1455.2("fruit-" + 6 + "-overlay", (1416)7, null), (1376)1, 1065.Centre, (1044)1, this.8, 1436.32((float)(this.1 - 1)), false, 198.White, null);
			this.30.Add(this.45);
			this.29.Add(this.45);
			this.50 = new 1433(1455.2("fruit-" + 6, (1416)7, null), (1376)1, 1065.Centre, (1044)1, this.8, 1436.32((float)(this.1 + 1)), false, 198.TransparentBlack, null);
			this.50.28 = true;
			this.30.Add(this.50);
			this.29.Add(this.50);
			catchFruitClosure.1 = new 1445(new 208(this.8.X, -100f), new 208(this.8.X, 340f), this.1 - this.28.2, this.1, (1046)0);
			1445 8 = catchFruitClosure.1;
			8.6.Y = 8.6.Y + (catchFruitClosure.1.6.Y - catchFruitClosure.1.2.Y) * 0.2f;
			catchFruitClosure.1.10 += (int)((float)catchFruitClosure.1.1() * 0.2f);
			catchFruitClosure.2 = 1196.7(-0.2f, 0.2f);
			this.30.ForEach(delegate(1433 1)
			{
				1.3.Add(catchFruitClosure.1);
				1.14 = catchFruitClosure.2;
			});
			2023 9 = this.28.22;
			2023 10 = 2023.Hidden;
			if ((9 & 10) > 2023.None)
			{
				1866.1868 @object = new 1866.1868
				{
					1 = new 1445(1456.Fade, 1f, 0f, 3 - (int)((double)this.28.2 * 0.6), 3 - (int)((double)this.28.2 * 0.44), (1046)0)
				};
				this.30.ForEach(new Action<1433>(@object.11));
			}
		}
	}

	// Token: 0x060039F7 RID: 14839 RVA: 0x0016DAA2 File Offset: 0x0016BCA2
	public new bool 9()
	{
		return this.48 != null;
	}

	// Token: 0x060039F8 RID: 14840 RVA: 0x0001702D File Offset: 0x0001522D
	internal virtual bool BreaksComboOnMiss()
	{
		return true;
	}

	// Token: 0x060039F9 RID: 14841 RVA: 0x0000FF75 File Offset: 0x0000E175
	public override int GetComboNumber()
	{
		return 0;
	}

	// Token: 0x060039FA RID: 14842 RVA: 0x00005ADD File Offset: 0x00003CDD
	public override void SetComboNumber(int 1)
	{
	}

	// Token: 0x060039FB RID: 14843 RVA: 0x0016DAAD File Offset: 0x0016BCAD
	[CompilerGenerated]
	public override bool IsNewCombo()
	{
		return this.51;
	}

	// Token: 0x060039FC RID: 14844 RVA: 0x0016DAB5 File Offset: 0x0016BCB5
	[CompilerGenerated]
	public override void SetNewCombo(bool 1)
	{
		this.51 = 1;
	}

	// Token: 0x060039FD RID: 14845 RVA: 0x0013FA97 File Offset: 0x0013DC97
	public override 208 GetEndPosition()
	{
		return this.8;
	}

	// Token: 0x060039FE RID: 14846 RVA: 0x00053ADC File Offset: 0x00051CDC
	public override void SetEndPosition(208 1)
	{
		throw new NotImplementedException();
	}

	// Token: 0x060039FF RID: 14847 RVA: 0x0016DABE File Offset: 0x0016BCBE
	internal override bool IsActive()
	{
		return this.44.19;
	}

	// Token: 0x06003A00 RID: 14848 RVA: 0x0016DACB File Offset: 0x0016BCCB
	internal override void SetComboColour(198 1)
	{
		base.SetComboColour(1);
		if (this.44 != null)
		{
			this.44.6 = 1;
		}
		this.7 = 1;
	}

	// Token: 0x06003A01 RID: 14849 RVA: 0x0016DAF0 File Offset: 0x0016BCF0
	internal override 2149 GetOrCalculateJudgement()
	{
		this.11 = true;
		if (this.46)
		{
			this.14 = (2149)1024;
			this.PlayHitSound();
		}
		else
		{
			this.14 = (this.BreaksComboOnMiss() ? ((2149)(-131072)) : ((2149)(-262144)));
		}
		this.ApplyJudgementAnimation(this.14 > (2149)0);
		return this.14;
	}

	// Token: 0x06003A02 RID: 14850 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void ApplyJudgementAnimation(bool 1)
	{
	}

	// Token: 0x06003A03 RID: 14851 RVA: 0x00053ADC File Offset: 0x00051CDC
	internal override 2034 Clone()
	{
		throw new NotImplementedException();
	}

	// Token: 0x06003A04 RID: 14852 RVA: 0x00053ADC File Offset: 0x00051CDC
	internal override void OnSelected()
	{
		throw new NotImplementedException();
	}

	// Token: 0x06003A05 RID: 14853 RVA: 0x00053ADC File Offset: 0x00051CDC
	internal override void OnDeselected()
	{
		throw new NotImplementedException();
	}

	// Token: 0x06003A06 RID: 14854 RVA: 0x00053ADC File Offset: 0x00051CDC
	internal override void SetStartTime(int 1)
	{
		throw new NotImplementedException();
	}

	// Token: 0x06003A07 RID: 14855 RVA: 0x0016DB50 File Offset: 0x0016BD50
	internal override void SetPosition(208 1, bool 2 = false)
	{
		1866.1869 3 = new 1866.1869();
		3.1 = 1;
		base.SetPosition(3.1, 2);
		this.30.ForEach(new Action<1433>(3.1));
	}

	// Token: 0x06003A08 RID: 14856 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal override 2149 JudgeAtPosition(208 1)
	{
		return (2149)0;
	}

	// Token: 0x06003A09 RID: 14857 RVA: 0x00053ADC File Offset: 0x00051CDC
	internal override void SetEndTime(int 1)
	{
		throw new NotImplementedException();
	}

	// Token: 0x06003A0A RID: 14858 RVA: 0x0016DB90 File Offset: 0x0016BD90
	internal new void 10(2034 1)
	{
		if (this.9())
		{
			return;
		}
		this.49 = 0f;
		this.48 = 1;
		if (this.28.39 != null)
		{
			this.50.6 = 2630.6().15();
			1445 2 = new 1445(1456.Scale, this.44.15 * 1.2f, this.44.15 * 1.3f, this.44.3[0].9, this.44.3[0].9 + 500, (1046)0);
			2.17 = true;
			this.50.3.Add(2);
			2023 3 = this.28.22;
			2023 4 = 2023.Hidden;
			if ((3 & 4) <= 2023.None)
			{
				2 = new 1445(1456.Fade, 1f, 0.5f, this.44.3[0].9, this.44.3[0].9 + 500, (1046)0);
				2.17 = true;
				this.50.3.Add(2);
			}
		}
	}

	// Token: 0x04002ACF RID: 10959
	private 1433 44;

	// Token: 0x04002AD0 RID: 10960
	private 1433 45;

	// Token: 0x04002AD1 RID: 10961
	public bool 46;

	// Token: 0x04002AD2 RID: 10962
	public 208 47;

	// Token: 0x04002AD3 RID: 10963
	public 2034 48;

	// Token: 0x04002AD4 RID: 10964
	internal float 49;

	// Token: 0x04002AD5 RID: 10965
	private 1433 50;

	// Token: 0x04002AD6 RID: 10966
	private bool 51;

	// Token: 0x04002AD7 RID: 10967
	internal int 52 = int.MinValue;

	// Token: 0x04002AD8 RID: 10968
	internal int 53 = int.MinValue;

	// Token: 0x020007C8 RID: 1992
	public sealed class 1867
	{
		// Token: 0x04002AD9 RID: 10969
		public 1445 1;

		// Token: 0x04002ADA RID: 10970
		public float 2;
	}

	// Token: 0x020007C9 RID: 1993
	public sealed class 1869
	{
		// Token: 0x06003A0C RID: 14860 RVA: 0x0016DCC4 File Offset: 0x0016BEC4
		internal void 1(1433 1)
		{
			1.17 = this.1;
		}

		// Token: 0x04002ADB RID: 10971
		public 208 1;
	}

	// Token: 0x020007CA RID: 1994
	public sealed class 1868
	{
		// Token: 0x06003A0E RID: 14862 RVA: 0x0016DCD2 File Offset: 0x0016BED2
		internal void 1(1433 1)
		{
			1.3.Add(this.1);
		}

		// Token: 0x04002ADC RID: 10972
		public 1445 1;
	}
}
