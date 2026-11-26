using System;
using System.Collections.Generic;

// Token: 0x020005F1 RID: 1521
public sealed class 2377 : 2385
{
	// Token: 0x06002EC5 RID: 11973 RVA: 0x00108733 File Offset: 0x00106933
	internal 2377(2440 1, 2450 2 = (2450)0) : base(1, 2)
	{
		base.2((2451)4);
	}

	// Token: 0x06002EC6 RID: 11974 RVA: 0x00108744 File Offset: 0x00106944
	internal override bool CaptureBackup()
	{
		if (!base.9())
		{
			throw new 2448.2449("Not enough objects to initiate backup data");
		}
		if (base.7())
		{
			this.20 = new List<int>();
		}
		if (base.13((2450)16384))
		{
			if (base.7())
			{
				this.21 = new List<string>();
				this.22 = new List<int>();
				this.23 = new List<1253>();
			}
			base.15(new 2387.2388(this.20));
		}
		else if (base.13((2450)4096))
		{
			if (base.7())
			{
				this.21 = new List<string>();
				this.22 = new List<int>();
			}
			base.15(new 2387.2388(this.21));
		}
		else
		{
			if (base.7())
			{
				this.23 = new List<1253>();
			}
			base.15(new 2387.2388(this.22));
		}
		return true;
	}

	// Token: 0x06002EC7 RID: 11975 RVA: 0x00108828 File Offset: 0x00106A28
	internal override bool HasChanged()
	{
		int num = 0;
		if (base.13((2450)16384))
		{
			foreach (object obj in this.8)
			{
				2034 <<EMPTY_NAME>> = (2034)obj;
				if (<<EMPTY_NAME>>.33 != this.21[num] || <<EMPTY_NAME>>.32 != this.22[num] || <<EMPTY_NAME>>.34 != this.20[num] || <<EMPTY_NAME>>.37 != this.23[num])
				{
					return true;
				}
				num++;
			}
			return false;
		}
		if (base.13((2450)4096))
		{
			foreach (object obj2 in this.8)
			{
				2034 2 = (2034)obj2;
				if (2.33 != this.21[num] || 2.32 != this.22[num] || 2.34 != this.20[num])
				{
					return true;
				}
				num++;
			}
			return false;
		}
		foreach (object obj3 in this.8)
		{
			2034 3 = (2034)obj3;
			if (3.37 != this.23[num] || 3.34 != this.20[num])
			{
				return true;
			}
			num++;
		}
		return false;
	}

	// Token: 0x06002EC8 RID: 11976 RVA: 0x00108A08 File Offset: 0x00106C08
	internal override void Apply(2457 1)
	{
		int num = 0;
		if (base.13((2450)16384))
		{
			foreach (object obj in this.8)
			{
				2034 2 = (2034)obj;
				177.Method12592<int>(this.20, num, ref 2.34);
				177.Method12592<string>(this.21, num, ref 2.33);
				177.Method12592<int>(this.22, num, ref 2.32);
				177.Method12592<1253>(this.23, num, ref 2.37);
				num++;
			}
			return;
		}
		if (base.13((2450)4096))
		{
			foreach (object obj2 in this.8)
			{
				2034 3 = (2034)obj2;
				177.Method12592<int>(this.20, num, ref 3.34);
				177.Method12592<string>(this.21, num, ref 3.33);
				177.Method12592<int>(this.22, num, ref 3.32);
				num++;
			}
			return;
		}
		foreach (object obj3 in this.8)
		{
			2034 4 = (2034)obj3;
			177.Method12592<int>(this.20, num, ref 4.34);
			177.Method12592<1253>(this.23, num, ref 4.37);
			num++;
		}
	}

	// Token: 0x06002EC9 RID: 11977 RVA: 0x00108BAC File Offset: 0x00106DAC
	private void 20(2034 1)
	{
		this.21.Add(1.33);
		this.22.Add(1.32);
		this.20.Add(1.34);
		this.23.Add(1.37);
	}

	// Token: 0x06002ECA RID: 11978 RVA: 0x00108BFD File Offset: 0x00106DFD
	private void 21(2034 1)
	{
		this.21.Add(1.33);
		this.22.Add(1.32);
		this.20.Add(1.34);
	}

	// Token: 0x06002ECB RID: 11979 RVA: 0x00108C32 File Offset: 0x00106E32
	private void 22(2034 1)
	{
		this.20.Add(1.34);
		this.23.Add(1.37);
	}

	// Token: 0x0400220F RID: 8719
	private List<int> 20;

	// Token: 0x04002210 RID: 8720
	private List<string> 21;

	// Token: 0x04002211 RID: 8721
	private List<int> 22;

	// Token: 0x04002212 RID: 8722
	private List<1253> 23;
}
