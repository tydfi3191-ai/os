using System;
using System.Collections.Generic;

// Token: 0x020005FB RID: 1531
public abstract class 2387 : 2448
{
	// Token: 0x06002F00 RID: 12032 RVA: 0x00108338 File Offset: 0x00106538
	internal 2387(2440 1, 2450 2) : base(1, 2)
	{
	}

	// Token: 0x06002F01 RID: 12033 RVA: 0x0010A954 File Offset: 0x00108B54
	internal void 15(2387.2388 1)
	{
		for (int i = base.8(); i < this.8.Count; i++)
		{
			2034 2 = (2034)this.8[i];
			1(2);
		}
	}

	// Token: 0x06002F02 RID: 12034 RVA: 0x0010A998 File Offset: 0x00108B98
	protected void 16(bool 1)
	{
		this.13 = null;
		bool flag = false;
		if (1)
		{
			this.13 = new List<int>();
			using (List<object>.Enumerator enumerator = this.8.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					2123 2 = ((2034)obj) as 2123;
					if (2 != null)
					{
						if (this.17(2))
						{
							flag = true;
						}
						this.13.Add(-1);
					}
				}
				goto IL_AA;
			}
		}
		if (this.8.Count > 1)
		{
			return;
		}
		try
		{
			2123 3 = this.8[0] as 2123;
			if (3 != null)
			{
				this.13 = new List<int>();
				if (this.17(3))
				{
					flag = true;
				}
			}
		}
		catch (IndexOutOfRangeException)
		{
		}
		IL_AA:
		if (!flag)
		{
			this.13 = null;
		}
	}

	// Token: 0x06002F03 RID: 12035 RVA: 0x0010AA78 File Offset: 0x00108C78
	protected bool 17(2123 1)
	{
		bool result = false;
		int num = 0;
		using (List<2033>.Enumerator enumerator = 1.9().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.3())
				{
					result = true;
					this.13.Add(num);
				}
				num++;
			}
		}
		return result;
	}

	// Token: 0x06002F04 RID: 12036 RVA: 0x0010AAE4 File Offset: 0x00108CE4
	protected void 18(1189 1)
	{
		this.4.1.74.15(this.8);
		1();
	}

	// Token: 0x04002228 RID: 8744
	protected new List<int> 13;

	// Token: 0x020005FC RID: 1532
	// (Invoke) Token: 0x06002F06 RID: 12038
	public delegate void 2388(2034 1);
}
