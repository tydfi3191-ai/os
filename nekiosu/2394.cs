using System;
using System.Collections.Generic;

// Token: 0x02000602 RID: 1538
public sealed class 2394 : 2387
{
	// Token: 0x06002F1E RID: 12062 RVA: 0x0010AE41 File Offset: 0x00109041
	internal 2394(2440 1, 2450 2 = (2450)0) : base(1, 2)
	{
		base.2((2451)12);
	}

	// Token: 0x06002F1F RID: 12063 RVA: 0x0000FF75 File Offset: 0x0000E175
	protected override bool UsesObjectLists()
	{
		return false;
	}

	// Token: 0x06002F20 RID: 12064 RVA: 0x0010AE70 File Offset: 0x00109070
	protected override void AddObject(object 1)
	{
		2440.2443 2 = 1 as 2440.2443;
		if (2 != null && 2.7(false) && !this.15.Contains(2))
		{
			this.15.Add(2);
			this.16.Add(2.1().63);
		}
	}

	// Token: 0x06002F21 RID: 12065 RVA: 0x0010AEC0 File Offset: 0x001090C0
	protected override void ReplaceTargetObjects(object 1)
	{
		2440.2443 2 = 1 as 2440.2443;
		if (2 != null && 2.7(false))
		{
			this.15.Clear();
			this.15.Add(2);
			if (this.14)
			{
				this.16.Clear();
				this.16.Add(2.1().63);
				this.14 = false;
			}
		}
	}

	// Token: 0x06002F22 RID: 12066 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool CaptureBackup()
	{
		return true;
	}

	// Token: 0x06002F23 RID: 12067 RVA: 0x0010AF27 File Offset: 0x00109127
	internal override void Release()
	{
		this.11.Add(this.15);
		this.11.Add(this.16);
		base.Release();
	}

	// Token: 0x06002F24 RID: 12068 RVA: 0x0010AF54 File Offset: 0x00109154
	internal override bool HasChanged()
	{
		int num = 0;
		foreach (2440.2443 <<EMPTY_NAME>> in this.15)
		{
			if (<<EMPTY_NAME>>.7(false) && (<<EMPTY_NAME>>.4 != <<EMPTY_NAME>>.1().54[<<EMPTY_NAME>>.3()] || <<EMPTY_NAME>>.1().51 != this.16[num]))
			{
				return true;
			}
			num++;
		}
		return false;
	}

	// Token: 0x06002F25 RID: 12069 RVA: 0x0010AFF4 File Offset: 0x001091F4
	internal override void Apply(2457 1)
	{
		int num = 0;
		foreach (2440.2443 2 in this.15)
		{
			2123 3 = 2.1();
			List<208> 4 = 3.54;
			int num2 = 2.3();
			208 5 = 4[num2];
			float 6 = 5.X - 2.4.X;
			float 7 = 5.Y - 2.4.Y;
			208 8 = new 208(6, 7);
			208 value = 4[num2] = 5 - 8;
			if (2.5())
			{
				if (num2 >= 1 && 4[num2 - 1] == 2.4)
				{
					4[num2 - 1] = value;
				}
				else
				{
					4[num2 + 1] = value;
				}
			}
			2.4 = 5;
			if (num2 == 0)
			{
				3.8 = (3.18 -= 8);
				3.58.SetPosition(3.8, false);
			}
			2064 9 = 3.51;
			3.51 = (3.63 = this.16[num]);
			this.16[num] = 9;
			3.6 = 0.0;
			3.RebuildPathAndTiming(true);
			num++;
		}
	}

	// Token: 0x0400222B RID: 8747
	private bool 14 = true;

	// Token: 0x0400222C RID: 8748
	private new List<2440.2443> 15 = new List<2440.2443>();

	// Token: 0x0400222D RID: 8749
	private new List<2064> 16 = new List<2064>();
}
