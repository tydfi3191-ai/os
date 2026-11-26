using System;
using System.Collections.Generic;

// Token: 0x020005F3 RID: 1523
public sealed class 2379 : 2385
{
	// Token: 0x06002ED2 RID: 11986 RVA: 0x00109229 File Offset: 0x00107429
	internal 2379(2440 1, 2450 2 = (2450)0) : base(1, 2)
	{
		base.2((2451)2);
	}

	// Token: 0x06002ED3 RID: 11987 RVA: 0x0010923C File Offset: 0x0010743C
	internal override bool CaptureBackup()
	{
		if (!base.9())
		{
			throw new 2448.2449("Not enough objects to initiate backup data");
		}
		if (base.7())
		{
			this.18 = new List<2440.2441>();
			this.19 = new List<2440.2441>();
		}
		base.16(false);
		base.15(new 2387.2388(this.21));
		return true;
	}

	// Token: 0x06002ED4 RID: 11988 RVA: 0x00109294 File Offset: 0x00107494
	internal override void Release()
	{
		this.13 = null;
		this.11.Add(this.18);
		this.11.Add(this.19);
		base.Release();
	}

	// Token: 0x06002ED5 RID: 11989 RVA: 0x001092C8 File Offset: 0x001074C8
	internal override bool HasChanged()
	{
		int num = 0;
		int num2 = 0;
		foreach (object obj in this.8)
		{
			2034 <<EMPTY_NAME>> = (2034)obj;
			2440.2441 2 = this.18[num];
			if (<<EMPTY_NAME>>.4 != 2.Get(0))
			{
				return true;
			}
			2123 3 = <<EMPTY_NAME>> as 2123;
			if (3 != null)
			{
				2 = this.19[num2];
				if (3.85.Count != 2.1.Count)
				{
					return true;
				}
				if (this.20(3.84, 2))
				{
					return true;
				}
				num2++;
			}
			num++;
		}
		return false;
	}

	// Token: 0x06002ED6 RID: 11990 RVA: 0x001093A4 File Offset: 0x001075A4
	private bool 20(List<1245> 1, 2440.2441 2)
	{
		if (this.13 != null && this.13.Count > 0)
		{
			foreach (int num in this.13)
			{
				if (1[num] != 2.Get(num))
				{
					return true;
				}
			}
			return false;
		}
		for (int i = 0; i < 2.1.Count; i++)
		{
			if (1[i] != 2.Get(i))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06002ED7 RID: 11991 RVA: 0x00109448 File Offset: 0x00107648
	internal override void Apply(2457 1)
	{
		int num = 0;
		int num2 = 0;
		foreach (object obj in this.8)
		{
			2034 2 = (2034)obj;
			177.Method12592<1245>(this.18[num].1, 0, ref 2.4);
			2123 3 = 2 as 2123;
			if (3 != null)
			{
				177.Method12592<1245>(this.19[num2].1, 3.84);
				base.19<1245>(3, 3.84);
				num2++;
			}
			num++;
		}
		this.4.1.74.15(this.8);
		if (this.13 != null)
		{
			this.4.1.74.17((2123)this.8[0], this.13, 0);
		}
	}

	// Token: 0x06002ED8 RID: 11992 RVA: 0x0010954C File Offset: 0x0010774C
	private void 21(2034 1)
	{
		this.18.Add(new 2440.2441(1.4));
		2123 2 = 1 as 2123;
		if (2 != null)
		{
			this.19.Add(new 2440.2441(2.84));
		}
	}
}
