using System;

// Token: 0x0200078C RID: 1932
public class 1978 : 1979
{
	// Token: 0x060038C5 RID: 14533 RVA: 0x00165324 File Offset: 0x00163524
	public 1978(2039 1, int 2, int 3, int 4, 1245 5) : base(1, 2, 3, 5)
	{
		2 = this.44;
		this.4 = 5;
		this.57 = 5;
		this.56 = 5;
		this.46 = (1983)1;
		this.2 = 4;
		this.51 = (float)(this.2 - this.1);
		this.62 = true;
		if (!1.41.11())
		{
			this.52.55(base.9(string.Format("NoteImage{0}H", 2), this.44.12() + "H"));
			this.52.43(1.41.4.22(2, "H", this.52.42()));
			base.10(this.52);
			1351 6 = new 1351(base.9(string.Format("NoteImage{0}T", 2), this.44.12() + "T") ?? this.52.54(), (1376)6, this.52.49, (1044)1, this.8, 0.7975f, false, 198.White);
			6.16 = this.52.16;
			6.43(!1.41.4.22(2, "T", true));
			this.64 = 6;
			base.10(this.64);
			this.30.Add(this.64);
			1351 7 = new 1351(base.9(string.Format("NoteImage{0}L", 2), this.44.12() + "L"), (1376)6, this.52.49, (1044)1, this.8, 0.795f, false, 198.White);
			7.16 = this.52.16;
			7.53(30.0);
			7.72 = false;
			7.43(1.41.4.22(2, "L", true));
			this.63 = 7;
			base.10(this.63);
			this.30.Add(this.63);
		}
	}

	// Token: 0x060038C6 RID: 14534 RVA: 0x0016557C File Offset: 0x0016377C
	internal override void OnHoldStarted()
	{
		1254 <<EMPTY_NAME>> = 1254.None;
		1254 2 = 1254.None;
		if (this.28.21.32 >= 14)
		{
			<<EMPTY_NAME>> = this.60;
			2 = this.61;
		}
		1226.31(this.4, <<EMPTY_NAME>>, 2, false, null);
		this.11(true);
	}

	// Token: 0x060038C7 RID: 14535 RVA: 0x0014E68B File Offset: 0x0014C88B
	internal override void StopHitSounds()
	{
		1226.34();
	}

	// Token: 0x060038C8 RID: 14536 RVA: 0x001655CD File Offset: 0x001637CD
	internal override void PlayHitSound()
	{
		if (this.62)
		{
			this.11(false);
		}
	}

	// Token: 0x060038C9 RID: 14537 RVA: 0x001655E0 File Offset: 0x001637E0
	internal new void 11(bool 1)
	{
		1259 2 = this.28.21.94((double)((1 ? this.1 : this.2) + 2));
		if (2 != null)
		{
			if (1)
			{
				base.7(2, this.57, this.35, this.36);
				return;
			}
			base.7(2, this.56, this.58, this.59);
		}
	}

	// Token: 0x060038CA RID: 14538 RVA: 0x0016564C File Offset: 0x0016384C
	internal 2149 12()
	{
		2149 result = (2149)0;
		if (this.65 != -1 && 1226.16 <= this.2 && 1226.16 >= this.1 && 1226.16 - this.65 >= 2150.3)
		{
			this.65 += 2150.3;
			result = (2149)7;
		}
		return result;
	}

	// Token: 0x060038CB RID: 14539 RVA: 0x001656A8 File Offset: 0x001638A8
	internal new 2149 13()
	{
		if (this.49)
		{
			this.63.72 = true;
			this.65 = 1226.16;
			this.OnHoldStarted();
			if (!this.72)
			{
				((1975)this.28).87(this);
			}
		}
		2241 <<EMPTY_NAME>> = 2486.88;
		if (((<<EMPTY_NAME>> != null) ? <<EMPTY_NAME>>.39 : null) != null && !this.72 && !this.71)
		{
			this.14 = (2149)(-65536);
			if (this.49)
			{
				int num = Math.Abs(this.47 - this.1);
				1975 2 = this.28 as 1975;
				if (num <= 2.59)
				{
					this.14 = (2149)268435456;
				}
				else if (num <= 2.5)
				{
					this.14 = (2149)134217728;
				}
				else if (num <= 2.60)
				{
					this.14 = (2149)67108864;
				}
				else if (num <= 2.4)
				{
					this.14 = (2149)33554432;
				}
				else if (num <= 2.3)
				{
					this.14 = (2149)16777216;
				}
				this.PlayHitSound();
			}
		}
		else
		{
			this.14 = (2149)0;
		}
		this.71 = true;
		return this.14;
	}

	// Token: 0x060038CC RID: 14540 RVA: 0x001657DC File Offset: 0x001639DC
	internal new void 14()
	{
		bool grayedOut = this.14 == (2149)(-65536) || (!this.49 && 1226.16 > this.1 + this.28.3 && !this.11);
		this.SetGrayedOut(grayedOut);
	}

	// Token: 0x060038CD RID: 14541 RVA: 0x0016582E File Offset: 0x00163A2E
	internal override void SetGrayedOut(bool 1 = true)
	{
		if (1)
		{
			((1975)this.28).88(this);
		}
		base.SetGrayedOut(1);
	}

	// Token: 0x060038CE RID: 14542 RVA: 0x0016584C File Offset: 0x00163A4C
	internal override 2149 GetOrCalculateJudgement()
	{
		this.63.72 = false;
		this.65 = -1;
		this.14();
		if (this.11)
		{
			return this.14;
		}
		if (1226.16 < this.1 + this.28.3 && this.47 == 0)
		{
			return (2149)0;
		}
		if (1226.16 < this.2 - this.28.3)
		{
			if (this.49)
			{
				return (2149)0;
			}
			this.StopHitSounds();
			((1975)this.28).88(this);
			this.72 = true;
			return (2149)(-1048576);
		}
		else
		{
			if (1226.16 < this.2 + this.28.3 && this.49)
			{
				return (2149)0;
			}
			this.StopHitSounds();
			this.11 = true;
			this.14 = (2149)(-65536);
			2241 <<EMPTY_NAME>> = 2486.88;
			if (((<<EMPTY_NAME>> != null) ? <<EMPTY_NAME>>.39 : null) != null)
			{
				float num = (float)Math.Abs(this.48 - this.2) / 1.5f;
				1975 2 = this.28 as 1975;
				if (num <= (float)2.59)
				{
					this.14 = (2149)268435456;
				}
				else if (num <= (float)2.5)
				{
					this.14 = (2149)134217728;
				}
				else if (num <= (float)2.60)
				{
					this.14 = (2149)67108864;
				}
				else if (num <= (float)2.4)
				{
					this.14 = (2149)33554432;
				}
				else if (num <= (float)2.3)
				{
					this.14 = (2149)16777216;
				}
				if (this.14 > (2149)16777216 && (this.72 || !this.71))
				{
					this.14 = (2149)16777216;
				}
			}
			else
			{
				int num2 = (this.47 < this.1 - this.28.3) ? (this.2 - 1) : ((this.47 >= this.1) ? this.47 : (this.1 + (this.1 - this.47)));
				int num3 = this.49 ? 1226.16 : ((this.48 <= this.2) ? this.48 : (this.2 - (this.48 - this.2)));
				Math.Abs(num3 - num2);
				int num4 = Math.Abs(num2 - this.1);
				int num5 = Math.Abs(num3 - this.2);
				int num6 = num4 + num5;
				float num7 = (float)(num3 - num2) / this.51;
				1975 3 = this.28 as 1975;
				if (num3 < this.2 - 3.3)
				{
					this.14 = (2149)(-65536);
				}
				else if ((double)num4 <= (double)3.59 * 1.2 && (double)num6 <= (double)3.59 * 2.4)
				{
					this.14 = (2149)268435456;
				}
				else if ((double)num4 <= (double)3.5 * 1.1 && (double)num6 <= (double)3.5 * 2.2)
				{
					this.14 = (2149)134217728;
				}
				else if (num4 <= 3.60 && num6 <= 3.60 * 2)
				{
					this.14 = (2149)67108864;
				}
				else if (num4 <= 3.4 && num6 <= 3.4 * 2)
				{
					this.14 = (2149)33554432;
				}
				else
				{
					this.14 = (2149)16777216;
				}
				if (this.14 > (2149)67108864 && this.72)
				{
					this.14 = (2149)67108864;
				}
			}
			if (this.14 > (2149)0)
			{
				this.PlayHitSound();
			}
			if (this.14 < (2149)0 || this.72 || 1226.16 < this.2 - this.28.3)
			{
				this.SetGrayedOut(true);
			}
			else
			{
				this.HideSprites();
			}
			return this.14;
		}
	}

	// Token: 0x040029EA RID: 10730
	internal 1245 56;

	// Token: 0x040029EB RID: 10731
	internal 1245 57;

	// Token: 0x040029EC RID: 10732
	internal 1254 58;

	// Token: 0x040029ED RID: 10733
	internal 1254 59;

	// Token: 0x040029EE RID: 10734
	internal 1254 60;

	// Token: 0x040029EF RID: 10735
	internal 1254 61;

	// Token: 0x040029F0 RID: 10736
	internal bool 62;

	// Token: 0x040029F1 RID: 10737
	internal 1351 63;

	// Token: 0x040029F2 RID: 10738
	internal 1351 64;

	// Token: 0x040029F3 RID: 10739
	internal int 65 = -1;

	// Token: 0x040029F4 RID: 10740
	internal bool 66;

	// Token: 0x040029F5 RID: 10741
	internal bool 67;

	// Token: 0x040029F6 RID: 10742
	internal int 68;

	// Token: 0x040029F7 RID: 10743
	internal int 69;

	// Token: 0x040029F8 RID: 10744
	internal int 70;

	// Token: 0x040029F9 RID: 10745
	internal bool 71;

	// Token: 0x040029FA RID: 10746
	private bool 72;
}
