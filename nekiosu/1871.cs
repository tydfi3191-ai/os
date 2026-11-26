using System;
using System.Collections.Generic;

// Token: 0x020007CD RID: 1997
public sealed class 1871 : 2123
{
	// Token: 0x06003A1C RID: 14876 RVA: 0x0016E074 File Offset: 0x0016C274
	internal 1871(2039 1, 208 2, int 3, bool 4, 1245 5, 2064 6, int 7, double 8, List<208> 9, List<1245> 10, string 11) : base(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 0)
	{
		this.93 = 11;
		this.50 = null;
	}

	// Token: 0x06003A1D RID: 14877 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void GenerateSliderEvents()
	{
	}

	// Token: 0x06003A1E RID: 14878 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool IsHeadJudged()
	{
		return true;
	}

	// Token: 0x06003A1F RID: 14879 RVA: 0x0013FA9F File Offset: 0x0013DC9F
	public override int GetComboNumber()
	{
		return -1;
	}

	// Token: 0x06003A20 RID: 14880 RVA: 0x0013FAA2 File Offset: 0x0013DCA2
	public override void SetComboNumber(int 1)
	{
		base.SetComboNumber(-1);
	}

	// Token: 0x06003A21 RID: 14881 RVA: 0x0016E0B3 File Offset: 0x0016C2B3
	internal override bool HitTest(208 1, bool 2, float 3)
	{
		return this.1 <= 1226.16 && this.2 >= 1226.16 && !this.11;
	}

	// Token: 0x06003A22 RID: 14882 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal override 2149 JudgeHead()
	{
		return (2149)0;
	}

	// Token: 0x06003A23 RID: 14883 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void SetComboColour(198 1)
	{
	}

	// Token: 0x06003A24 RID: 14884 RVA: 0x0016E0DA File Offset: 0x0016C2DA
	internal override 2149 GetOrCalculateJudgement()
	{
		this.11 = true;
		return (2149)0;
	}

	// Token: 0x06003A25 RID: 14885 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void PrepareRendering()
	{
	}

	// Token: 0x06003A26 RID: 14886 RVA: 0x0016E0E4 File Offset: 0x0016C2E4
	internal override void Update()
	{
		this.RebuildPathAndTiming(false);
		base.Update();
		this.45.45(false);
		this.45.43(false);
	}

	// Token: 0x06003A27 RID: 14887 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void Shake()
	{
	}

	// Token: 0x06003A28 RID: 14888 RVA: 0x0016E10C File Offset: 0x0016C30C
	internal override void RebuildPathAndTiming(bool 1 = true)
	{
		base.RebuildPathAndTiming(1);
		if (base.GetDuration() > 60000)
		{
			throw new ArgumentOutOfRangeException("Slider is too long. (Over 1 minute!)");
		}
		bool flag = this.28.21.3() != 2147.CatchTheBeat || this.28.21.32 >= 14;
		this.94.Clear();
		1875 2 = this.28 as 1875;
		if (2 != null)
		{
			2.76(this);
		}
		1866 3 = new 1866(this.28, this.8, this.1, this.IsNewCombo(), this.73 ? this.4 : this.84[0], this.93);
		if (flag)
		{
			this.50(3, 0);
		}
		else
		{
			3.36 = ((this.86.Count > 0 && this.86[0] != 1254.None) ? this.86[0] : this.36);
		}
		3.3 |= 2047.NewCombo;
		this.94.Add(3);
		int num = this.1;
		1870 4 = this.28.33 as 1870;
		int num2 = 1;
		for (int i = 0; i < this.83.Count; i++)
		{
			int num3 = this.83[i];
			if (num3 - this.1 > 60000)
			{
				break;
			}
			if (num3 - num > 80)
			{
				float num4;
				for (num4 = (float)(num3 - num); num4 > 100f; num4 /= 2f)
				{
				}
				for (float num5 = (float)num + num4; num5 < (float)num3; num5 += num4)
				{
					1872 item = new 1872(this.28, this.GetPositionAtTime((int)num5) + new 208((float)4.7.Next(-20, 20), 0f), (int)num5, false, this.4, this.93);
					this.94.Add(item);
				}
			}
			num = num3;
			if (i < this.83.Count - 1)
			{
				int num6 = this.82.BinarySearch(num3);
				if (num6 >= 0)
				{
					1866 5 = new 1866(this.28, (num6 % 2 == 1) ? this.8 : this.GetCurrentPosition(), num3, false, this.73 ? this.4 : this.84[num6 + 1], this.93);
					if (flag)
					{
						this.50(5, num2);
					}
					this.94.Add(5);
					num2++;
				}
				else
				{
					1863 item2 = new 1863(this.28, this.GetPositionAtTime(num3), num3, false, this.4, this.93);
					this.94.Add(item2);
				}
			}
		}
		1866 6 = new 1866(this.28, this.GetEndPosition(), this.2, false, this.73 ? this.4 : this.84[this.84.Count - 1], this.93);
		if (flag)
		{
			this.50(6, this.86.Count - 1);
		}
		else
		{
			6.36 = ((this.86.Count > 0 && this.86[1] != 1254.None) ? this.86[1] : this.36);
		}
		this.94.Add(6);
		if (2 != null)
		{
			2.77();
		}
	}

	// Token: 0x06003A29 RID: 14889 RVA: 0x0016E48C File Offset: 0x0016C68C
	internal new void 50(1866 1, int 2)
	{
		1244 3 = base.43(2);
		1.35 = 3.2;
		1.36 = 3.3;
	}

	// Token: 0x06003A2A RID: 14890 RVA: 0x0016E4B9 File Offset: 0x0016C6B9
	internal override 2149 JudgeAtPosition(208 1)
	{
		if (this.11)
		{
			return (2149)0;
		}
		bool 2 = 1555.14;
		int 3 = 1226.16;
		return (2149)0;
	}

	// Token: 0x04002AE4 RID: 10980
	private readonly string 93;

	// Token: 0x04002AE5 RID: 10981
	internal List<1866> 94 = new List<1866>();

	// Token: 0x04002AE6 RID: 10982
	internal 1875.1876 95;
}
