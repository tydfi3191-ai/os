using System;
using System.Collections.Generic;

// Token: 0x020005F4 RID: 1524
public sealed class 2380 : 2387
{
	// Token: 0x06002ED9 RID: 11993 RVA: 0x0010958F File Offset: 0x0010778F
	internal 2380(2440 1, 2450 2 = (2450)0) : base(1, 2)
	{
		base.2((2451)5);
	}

	// Token: 0x06002EDA RID: 11994 RVA: 0x001095AB File Offset: 0x001077AB
	internal override bool CaptureBackup()
	{
		if (!base.9())
		{
			throw new 2448.2449("Not enough objects to initiate backup data");
		}
		if (base.7())
		{
			this.14 = new List<bool>();
		}
		base.15(new 2387.2388(this.19));
		return true;
	}

	// Token: 0x06002EDB RID: 11995 RVA: 0x001095E6 File Offset: 0x001077E6
	internal override void Release()
	{
		this.11.Add(this.14);
		base.Release();
	}

	// Token: 0x06002EDC RID: 11996 RVA: 0x00109600 File Offset: 0x00107800
	internal override bool HasChanged()
	{
		int num = 0;
		using (List<object>.Enumerator enumerator = this.8.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (((2034)enumerator.Current).IsNewCombo() != this.14[num])
				{
					return true;
				}
				num++;
			}
		}
		return false;
	}

	// Token: 0x06002EDD RID: 11997 RVA: 0x00109670 File Offset: 0x00107870
	internal override void Apply(2457 1)
	{
		int num = 0;
		foreach (object obj in this.8)
		{
			2034 2 = (2034)obj;
			bool value = 2.IsNewCombo();
			2.SetNewCombo(this.14[num]);
			this.14[num] = value;
			num++;
		}
		this.4.6.2(false);
		this.4.1.74.15(this.8);
	}

	// Token: 0x06002EDE RID: 11998 RVA: 0x00109718 File Offset: 0x00107918
	private void 19(2034 1)
	{
		this.14.Add(1.IsNewCombo());
	}

	// Token: 0x04002219 RID: 8729
	private List<bool> 14 = new List<bool>();
}
