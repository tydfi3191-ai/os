using System;
using System.Collections.Generic;

// Token: 0x020005F0 RID: 1520
public sealed class 2376 : 2387
{
	// Token: 0x06002EBF RID: 11967 RVA: 0x001085C4 File Offset: 0x001067C4
	internal 2376(2440 1, 2450 2 = (2450)0) : base(1, 2)
	{
		base.2((2451)6);
	}

	// Token: 0x06002EC0 RID: 11968 RVA: 0x001085E0 File Offset: 0x001067E0
	internal override bool CaptureBackup()
	{
		if (!base.9())
		{
			throw new 2448.2449("Not enough objects to initiate backup data");
		}
		if (base.7())
		{
			this.14 = new List<int>();
		}
		base.15(new 2387.2388(this.19));
		return true;
	}

	// Token: 0x06002EC1 RID: 11969 RVA: 0x0010861B File Offset: 0x0010681B
	internal override void Release()
	{
		this.11.Add(this.14);
		base.Release();
	}

	// Token: 0x06002EC2 RID: 11970 RVA: 0x00108634 File Offset: 0x00106834
	internal override bool HasChanged()
	{
		int num = 0;
		using (List<object>.Enumerator enumerator = this.8.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (((2034)enumerator.Current).16 != this.14[num])
				{
					return true;
				}
				num++;
			}
		}
		return false;
	}

	// Token: 0x06002EC3 RID: 11971 RVA: 0x001086A4 File Offset: 0x001068A4
	internal override void Apply(2457 1)
	{
		int num = 0;
		foreach (object obj in this.8)
		{
			2034 2 = (2034)obj;
			177.Method12592<int>(this.14, num, ref 2.16);
			num++;
		}
		this.4.6.2(false);
	}

	// Token: 0x06002EC4 RID: 11972 RVA: 0x00108720 File Offset: 0x00106920
	private void 19(2034 1)
	{
		this.14.Add(1.16);
	}

	// Token: 0x0400220E RID: 8718
	private List<int> 14 = new List<int>();
}
