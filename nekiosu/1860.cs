using System;

// Token: 0x020007BF RID: 1983
public sealed class 1860 : 1866
{
	// Token: 0x060039D3 RID: 14803 RVA: 0x0016D214 File Offset: 0x0016B414
	public 1860(2039 1, 208 2, int 3, bool 4, 1245 5, string 6, int 7) : base(10, 2, 3, 4, 5, 6)
	{
		1860.1861 catchBananaClosure = new 1860.1861();
		1870 8 = this.28.33 as 1870;
		float 9 = (float)8.7.3() * 1.6f + 0.6f;
		catchBananaClosure.1 = new 1445(1456.Scale, 9, 0.6f, this.1 - this.28.2, this.1, (1046)0);
		this.30.ForEach(delegate(1433 1)
		{
			1.3.Add(catchBananaClosure.1);
		});
		catchBananaClosure.2 = new 1445(1456.Rotation, 1196.7(-1f, 1f), 1196.7(-1f, 1f), this.1 - this.28.2, this.1, (1046)0);
		this.30.ForEach(new Action<1433>(catchBananaClosure.10));
		if (this.28.27.Count > 0)
		{
			base.SetComboColour(this.28.27[8.7.Next(0, this.28.27.Count)]);
		}
		this.3 &= ~2047.NewCombo;
		this.54 = 7;
	}

	// Token: 0x060039D4 RID: 14804 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal override bool BreaksComboOnMiss()
	{
		return false;
	}

	// Token: 0x060039D5 RID: 14805 RVA: 0x0016D372 File Offset: 0x0016B572
	internal override void PlayHitSound()
	{
		1226.24("metronomelow", 1226.44(1226.45()), (1416)3, true).5(0.77f + (float)this.54 * 0.006f);
	}

	// Token: 0x060039D6 RID: 14806 RVA: 0x0016D3A4 File Offset: 0x0016B5A4
	internal override void SetComboColour(198 1)
	{
		int num = 1196.2(0, 3);
		198 comboColour;
		if (num != 1)
		{
			if (num != 2)
			{
				comboColour = new 198(byte.MaxValue, 240, 0);
			}
			else
			{
				comboColour = new 198(214, 221, 28);
			}
		}
		else
		{
			comboColour = new 198(byte.MaxValue, 192, 0);
		}
		base.SetComboColour(comboColour);
	}

	// Token: 0x060039D7 RID: 14807 RVA: 0x0016D402 File Offset: 0x0016B602
	internal override 2149 GetOrCalculateJudgement()
	{
		this.11 = true;
		if (this.46)
		{
			this.14 = (2149)16384;
			this.PlayHitSound();
		}
		else
		{
			this.14 = (2149)0;
		}
		this.ApplyJudgementAnimation(this.14 > (2149)0);
		return this.14;
	}

	// Token: 0x060039D8 RID: 14808 RVA: 0x0016D442 File Offset: 0x0016B642
	public new void 11()
	{
		base.PlayHitSound();
	}

	// Token: 0x04002AC5 RID: 10949
	private int 54;

	// Token: 0x020007C0 RID: 1984
	public sealed class 1861
	{
		// Token: 0x060039D9 RID: 14809 RVA: 0x0016D44A File Offset: 0x0016B64A
		internal void 1(1433 1)
		{
			1.3.Add(this.2);
		}

		// Token: 0x04002AC6 RID: 10950
		public 1445 1;

		// Token: 0x04002AC7 RID: 10951
		public 1445 2;
	}
}
