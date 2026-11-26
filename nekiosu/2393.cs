using System;
using System.Collections.Generic;

// Token: 0x02000601 RID: 1537
public sealed class 2393 : 2387
{
	// Token: 0x06002F16 RID: 12054 RVA: 0x0010ACAE File Offset: 0x00108EAE
	internal 2393(2440 1, 2450 2 = (2450)0) : base(1, 2)
	{
		base.2((2451)10);
	}

	// Token: 0x06002F17 RID: 12055 RVA: 0x0000FF75 File Offset: 0x0000E175
	protected override bool UsesObjectLists()
	{
		return false;
	}

	// Token: 0x06002F18 RID: 12056 RVA: 0x0010ACC0 File Offset: 0x00108EC0
	protected override void AddObject(object 1)
	{
		2064? 2 = 1 as 2064?;
		if (2 != null)
		{
			this.14 = new 2064?(2.Value);
		}
	}

	// Token: 0x06002F19 RID: 12057 RVA: 0x0010ACF4 File Offset: 0x00108EF4
	protected override void ReplaceTargetObjects(object 1)
	{
		2440.2443 2 = 1 as 2440.2443;
		if (2 != null)
		{
			this.sliderControlPointRef2 = 2;
			this.14 = new 2064?(2.1().51);
		}
	}

	// Token: 0x06002F1A RID: 12058 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool CaptureBackup()
	{
		return true;
	}

	// Token: 0x06002F1B RID: 12059 RVA: 0x0010AD28 File Offset: 0x00108F28
	internal override void Release()
	{
		this.sliderControlPointRef2 = null;
		this.14 = null;
		base.Release();
	}

	// Token: 0x06002F1C RID: 12060 RVA: 0x0010AD43 File Offset: 0x00108F43
	internal override bool HasChanged()
	{
		return this.sliderControlPointRef2 != null && this.sliderControlPointRef2.7(false);
	}

	// Token: 0x06002F1D RID: 12061 RVA: 0x0010AD5C File Offset: 0x00108F5C
	internal override void Apply(2457 1)
	{
		2123 2 = this.sliderControlPointRef2.1();
		List<208> 3 = 2.54;
		int num = this.sliderControlPointRef2.3();
		this.4.1.74.16();
		if (1 != (2457)1)
		{
			if (1 == (2457)2)
			{
				if (3.Count > num)
				{
					3.Insert(num, this.sliderControlPointRef2.4);
				}
				else
				{
					this.sliderControlPointRef2.4(3.Count);
					3.Add(this.sliderControlPointRef2.4);
				}
			}
		}
		else
		{
			3.RemoveAt(num);
		}
		if (this.14 != null)
		{
			2064 4 = 2.51;
			2.51 = (2.63 = this.14.Value);
			this.14 = new 2064?(4);
		}
		2.6 = 0.0;
		2.RebuildPathAndTiming(true);
	}

	// Token: 0x04002229 RID: 8745
	private 2440.2443 sliderControlPointRef2;

	// Token: 0x0400222A RID: 8746
	private 2064? 14;
}
