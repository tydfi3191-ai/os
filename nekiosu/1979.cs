using System;
using System.Runtime.CompilerServices;

// Token: 0x0200078D RID: 1933
public class 1979 : 2072
{
	// Token: 0x060038CF RID: 14543 RVA: 0x00165C38 File Offset: 0x00163E38
	public 1979(2039 1, int 2, int 3, 1245 4) : base(1)
	{
		this.45 = 2;
		2 = ((1975)1).76(2);
		this.44 = 1.41.19[2];
		this.8 = new 208(this.44.3() - this.44.1().28() + this.44.5() / 2f, -100f);
		this.18 = this.8;
		this.1 = 3;
		this.2 = 3;
		this.4 = 4;
		if (!1.41.11())
		{
			this.52 = new 1351(this.9("NoteImage" + 2.ToString(), this.44.12()), (1376)6, 1.41.57(1065.BottomCentre), (1044)1, this.8, 0.8f, false, 198.White);
			this.52.16 = 1f;
			this.52.43(1.41.4.22(2, string.Empty, true));
			this.10(this.52);
			this.30.Add(this.52);
		}
	}

	// Token: 0x060038D0 RID: 14544 RVA: 0x00165D8A File Offset: 0x00163F8A
	protected new 1381[] 9(string 1, string 2)
	{
		return this.28.41.4.20(1, 2, this.28.41.8());
	}

	// Token: 0x060038D1 RID: 14545 RVA: 0x00165DB4 File Offset: 0x00163FB4
	protected new void 10(1433 1)
	{
		float 2 = this.44.5() / (float)1.35 * 1.6f;
		float 3 = ((this.44.1().4.WidthForNoteHeightScale > 0f) ? this.44.1().4.WidthForNoteHeightScale : this.44.1().40()) / (float)1.35 * 1.6f * (1.42() ? -1f : 1f);
		1.20 = new 208(2, 3);
	}

	// Token: 0x060038D2 RID: 14546 RVA: 0x00165E4F File Offset: 0x0016404F
	protected override float GetSamplePan()
	{
		return (((float)this.44 + 1f) / (float)this.28.41.19.Count - 0.5f) * 0.8f;
	}

	// Token: 0x060038D3 RID: 14547 RVA: 0x00165E88 File Offset: 0x00164088
	internal override void PlayHitSound()
	{
		1259 <<EMPTY_NAME>> = this.28.21.94((double)(this.1 + 2));
		if (<<EMPTY_NAME>> != null)
		{
			base.7(<<EMPTY_NAME>>, this.4, this.35, this.36);
		}
	}

	// Token: 0x060038D4 RID: 14548 RVA: 0x00165ECC File Offset: 0x001640CC
	internal override 2149 GetOrCalculateJudgement()
	{
		if (this.11)
		{
			return this.14;
		}
		this.11 = true;
		this.14 = (2149)(-65536);
		if (this.49)
		{
			int num = Math.Abs(this.47 - this.1);
			1975 <<EMPTY_NAME>> = this.28 as 1975;
			if (num <= <<EMPTY_NAME>>.59)
			{
				this.14 = (2149)268435456;
			}
			else if (num <= <<EMPTY_NAME>>.5)
			{
				this.14 = (2149)134217728;
			}
			else if (num <= <<EMPTY_NAME>>.60)
			{
				this.14 = (2149)67108864;
			}
			else if (num <= <<EMPTY_NAME>>.4)
			{
				this.14 = (2149)33554432;
			}
			else if (num <= <<EMPTY_NAME>>.3)
			{
				this.14 = (2149)16777216;
			}
			this.PlayHitSound();
		}
		if (this.14 > (2149)16777216)
		{
			this.HideSprites();
		}
		else
		{
			this.SetGrayedOut(true);
		}
		return this.14;
	}

	// Token: 0x060038D5 RID: 14549 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal virtual void OnHoldStarted()
	{
	}

	// Token: 0x060038D6 RID: 14550 RVA: 0x0000FF75 File Offset: 0x0000E175
	public override int GetComboNumber()
	{
		return 0;
	}

	// Token: 0x060038D7 RID: 14551 RVA: 0x00005ADD File Offset: 0x00003CDD
	public override void SetComboNumber(int 1)
	{
	}

	// Token: 0x060038D8 RID: 14552 RVA: 0x00165FB8 File Offset: 0x001641B8
	[CompilerGenerated]
	public override bool IsNewCombo()
	{
		return this.55;
	}

	// Token: 0x060038D9 RID: 14553 RVA: 0x00165FC0 File Offset: 0x001641C0
	[CompilerGenerated]
	public override void SetNewCombo(bool 1)
	{
		this.55 = 1;
	}

	// Token: 0x060038DA RID: 14554 RVA: 0x0013FA97 File Offset: 0x0013DC97
	public override 208 GetEndPosition()
	{
		return this.8;
	}

	// Token: 0x060038DB RID: 14555 RVA: 0x00053ADC File Offset: 0x00051CDC
	public override void SetEndPosition(208 1)
	{
		throw new NotImplementedException();
	}

	// Token: 0x060038DC RID: 14556 RVA: 0x00165FC9 File Offset: 0x001641C9
	internal override bool IsActive()
	{
		return this.30[0].19;
	}

	// Token: 0x060038DD RID: 14557 RVA: 0x00165FDC File Offset: 0x001641DC
	internal override void SetComboColour(198 1)
	{
		this.30[0].6 = 1;
		this.7 = 1;
	}

	// Token: 0x060038DE RID: 14558 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void ApplyJudgementAnimation(bool 1)
	{
	}

	// Token: 0x060038DF RID: 14559 RVA: 0x00053ADC File Offset: 0x00051CDC
	internal override 2034 Clone()
	{
		throw new NotImplementedException();
	}

	// Token: 0x060038E0 RID: 14560 RVA: 0x00053ADC File Offset: 0x00051CDC
	internal override void OnSelected()
	{
		throw new NotImplementedException();
	}

	// Token: 0x060038E1 RID: 14561 RVA: 0x00053ADC File Offset: 0x00051CDC
	internal override void OnDeselected()
	{
		throw new NotImplementedException();
	}

	// Token: 0x060038E2 RID: 14562 RVA: 0x00053ADC File Offset: 0x00051CDC
	internal override void SetStartTime(int 1)
	{
		throw new NotImplementedException();
	}

	// Token: 0x060038E3 RID: 14563 RVA: 0x00165FF8 File Offset: 0x001641F8
	internal override void SetPosition(208 1, bool 2 = false)
	{
		1979.1982 3 = new 1979.1982();
		3.1 = 1;
		base.SetPosition(3.1, 2);
		this.30.ForEach(new Action<1433>(3.1));
	}

	// Token: 0x060038E4 RID: 14564 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal override 2149 JudgeAtPosition(208 1)
	{
		return (2149)0;
	}

	// Token: 0x060038E5 RID: 14565 RVA: 0x00053ADC File Offset: 0x00051CDC
	internal override void SetEndTime(int 1)
	{
		throw new NotImplementedException();
	}

	// Token: 0x060038E6 RID: 14566 RVA: 0x00166036 File Offset: 0x00164236
	internal virtual void HideSprites()
	{
		this.54 = true;
		this.30.ForEach(new Action<1433>(1979.1980.instance.1));
	}

	// Token: 0x060038E7 RID: 14567 RVA: 0x0016605C File Offset: 0x0016425C
	internal virtual void SetGrayedOut(bool 1)
	{
		1979.1981 2 = new 1979.1981();
		2.1 = 1;
		if (2.1 != this.53)
		{
			this.53 = 2.1;
			this.30.ForEach(new Action<1433>(2.1));
		}
	}

	// Token: 0x040029FB RID: 10747
	internal 1995 44;

	// Token: 0x040029FC RID: 10748
	internal int 45;

	// Token: 0x040029FD RID: 10749
	internal 1983 46;

	// Token: 0x040029FE RID: 10750
	internal int 47;

	// Token: 0x040029FF RID: 10751
	internal int 48;

	// Token: 0x04002A00 RID: 10752
	internal bool 49;

	// Token: 0x04002A01 RID: 10753
	internal int 50 = 1;

	// Token: 0x04002A02 RID: 10754
	internal float 51;

	// Token: 0x04002A03 RID: 10755
	internal 1351 52;

	// Token: 0x04002A04 RID: 10756
	internal bool 53;

	// Token: 0x04002A05 RID: 10757
	internal bool 54;

	// Token: 0x04002A06 RID: 10758
	private bool 55;

	// Token: 0x0200078E RID: 1934
	[Serializable]
	public sealed class 1980
	{
		// Token: 0x060038E8 RID: 14568 RVA: 0x001660A7 File Offset: 0x001642A7
		internal void 1(1433 1)
		{
			1.9(true);
		}

		// Token: 0x04002A07 RID: 10759
		public static readonly 1979.1980 instance = new 1979.1980();

		// Token: 0x04002A08 RID: 10760
		public static Action<1433> action;
	}

	// Token: 0x0200078F RID: 1935
	public sealed class 1981
	{
		// Token: 0x060038EB RID: 14571 RVA: 0x001660BC File Offset: 0x001642BC
		internal void 1(1433 1)
		{
			1.39(this.1 ? 198.Gray : 198.White, 60, false, (1046)0);
		}

		// Token: 0x04002A09 RID: 10761
		public bool 1;
	}

	// Token: 0x02000790 RID: 1936
	public sealed class 1982
	{
		// Token: 0x060038ED RID: 14573 RVA: 0x001660DD File Offset: 0x001642DD
		internal void 1(1433 1)
		{
			1.17 = this.1;
		}

		// Token: 0x04002A0A RID: 10762
		public 208 1;
	}
}
