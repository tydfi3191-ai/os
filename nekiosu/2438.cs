using System;
using System.Collections.Generic;

// Token: 0x0200062E RID: 1582
public class 2438 : 2387
{
	// Token: 0x06002FE7 RID: 12263 RVA: 0x0010E2DF File Offset: 0x0010C4DF
	public 2438(2440 1, 2450 2 = (2450)0) : base(1, 2)
	{
		base.2((2451)28);
	}

	// Token: 0x06002FE8 RID: 12264 RVA: 0x0010E314 File Offset: 0x0010C514
	internal override bool CaptureBackup()
	{
		if (!base.9())
		{
			throw new 2448.2449("Not enough objects to initiate backup data");
		}
		if (base.7())
		{
			this.14 = new List<208>();
			this.15 = new List<208>();
			this.16 = new List<double>();
		}
		base.15(new 2387.2388(this.19));
		return true;
	}

	// Token: 0x06002FE9 RID: 12265 RVA: 0x0010E370 File Offset: 0x0010C570
	internal override void Release()
	{
		this.11.Add(this.14);
		this.11.Add(this.15);
		this.11.Add(this.16);
		base.Release();
	}

	// Token: 0x06002FEA RID: 12266 RVA: 0x0010E3AC File Offset: 0x0010C5AC
	internal override bool HasChanged()
	{
		int num = 0;
		int num2 = 0;
		foreach (object obj in this.8)
		{
			2034 <<EMPTY_NAME>> = (2034)obj;
			2123 2 = <<EMPTY_NAME>> as 2123;
			if (2 != null)
			{
				if (!2.54.ElementsEqual(this.15))
				{
					return true;
				}
				if (2.6 != this.16[num2])
				{
					return true;
				}
				num2++;
			}
			else if (<<EMPTY_NAME>>.18 != this.14[num])
			{
				return true;
			}
			num++;
		}
		return false;
	}

	// Token: 0x06002FEB RID: 12267 RVA: 0x0010E46C File Offset: 0x0010C66C
	internal override void Apply(2457 1)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		foreach (object obj in this.8)
		{
			2034 2 = (2034)obj;
			2123 3 = 2 as 2123;
			208 value;
			if (3 != null)
			{
				for (int i = 0; i < 3.54.Count; i++)
				{
					value = 3.54[i];
					3.54[i] = this.15[num3];
					this.15[num3] = value;
					num3++;
				}
				value = 3.18;
				3.58.SetPosition(this.14[num], false);
				3.8 = (3.18 = this.14[num]);
				177.Method12592<double>(this.16, num2, ref 3.6);
				3.RebuildPathAndTiming(true);
				num2++;
			}
			else
			{
				value = 2.18;
				2.SetPosition(this.14[num], false);
			}
			this.14[num] = value;
			num++;
		}
		this.4.6.74();
	}

	// Token: 0x06002FEC RID: 12268 RVA: 0x0010E5E0 File Offset: 0x0010C7E0
	private void 19(2034 1)
	{
		this.14.Add(1.18);
		2123 2 = 1 as 2123;
		if (2 != null)
		{
			this.16.Add(2.6);
			this.15.AddRange(2.54);
		}
	}

	// Token: 0x04002268 RID: 8808
	private List<208> 14 = new List<208>();

	// Token: 0x04002269 RID: 8809
	private new List<208> 15 = new List<208>();

	// Token: 0x0400226A RID: 8810
	private new List<double> 16 = new List<double>();
}
