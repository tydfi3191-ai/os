using System;
using System.Collections.Generic;

// Token: 0x02000603 RID: 1539
public sealed class 2395 : 2387
{
	// Token: 0x06002F26 RID: 12070 RVA: 0x0010B190 File Offset: 0x00109390
	internal 2395(2440 1, 2450 2 = (2450)0) : base(1, 2)
	{
		base.2((2451)11);
	}

	// Token: 0x06002F27 RID: 12071 RVA: 0x0000FF75 File Offset: 0x0000E175
	protected override bool UsesObjectLists()
	{
		return false;
	}

	// Token: 0x06002F28 RID: 12072 RVA: 0x0010B1A4 File Offset: 0x001093A4
	protected override void ReplaceTargetObjects(object 1)
	{
		2440.2443 2 = 1 as 2440.2443;
		if (2 != null)
		{
			this.sliderControlPointRef2 = 2;
			this.14 = new 2064?(2.1().51);
		}
	}

	// Token: 0x06002F29 RID: 12073 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool CaptureBackup()
	{
		return true;
	}

	// Token: 0x06002F2A RID: 12074 RVA: 0x0010B1D8 File Offset: 0x001093D8
	internal override void Release()
	{
		this.sliderControlPointRef2 = null;
		this.14 = null;
		base.Release();
	}

	// Token: 0x06002F2B RID: 12075 RVA: 0x0010B1F3 File Offset: 0x001093F3
	internal override bool HasChanged()
	{
		return this.sliderControlPointRef2 != null && this.sliderControlPointRef2.7(true);
	}

	// Token: 0x06002F2C RID: 12076 RVA: 0x0010B20C File Offset: 0x0010940C
	internal override void Apply(2457 1)
	{
		2123 2 = this.sliderControlPointRef2.1();
		List<208> 3 = 2.54;
		int num = this.sliderControlPointRef2.3();
		if (1 != (2457)1)
		{
			if (1 == (2457)2)
			{
				3.RemoveAt(num);
			}
		}
		else if (3.Count > num)
		{
			3.Insert(num, this.sliderControlPointRef2.4);
		}
		else
		{
			int count;
			this.sliderControlPointRef2.4(count = 3.Count);
			num = count;
			3.Add(this.sliderControlPointRef2.4);
		}
		if (num == 0)
		{
			208 4 = 2.8;
			2.8 = (2.18 = this.sliderControlPointRef2.4);
			2.58.SetPosition(2.8, false);
			this.sliderControlPointRef2.4 = 4;
		}
		if (this.14 != null)
		{
			2064 5 = 2.51;
			2.51 = (2.63 = this.14.Value);
			this.14 = new 2064?(5);
		}
		2.6 = 0.0;
		2.RebuildPathAndTiming(true);
	}

	// Token: 0x0400222E RID: 8750
	private 2440.2443 sliderControlPointRef2;

	// Token: 0x0400222F RID: 8751
	private 2064? 14;
}
