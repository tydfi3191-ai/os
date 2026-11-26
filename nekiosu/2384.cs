using System;
using System.Collections.Generic;

// Token: 0x020005F8 RID: 1528
public sealed class 2384 : 2385
{
	// Token: 0x06002EEC RID: 12012 RVA: 0x00109BA0 File Offset: 0x00107DA0
	internal 2384(2440 1, 2450 2 = (2450)0) : base(1, 2)
	{
		base.2((2451)3);
	}

	// Token: 0x06002EED RID: 12013 RVA: 0x00109BB4 File Offset: 0x00107DB4
	internal override bool CaptureBackup()
	{
		if (base.13((2450)0))
		{
			throw new Exception("An action modifier must be specified");
		}
		if (!base.9())
		{
			throw new 2448.2449("Not enough objects to initiate backup data");
		}
		base.16(false);
		if (base.13((2450)16384))
		{
			if (base.7())
			{
				this.14 = new List<2440.2442>();
				this.15 = new List<2440.2442>();
				this.16 = new List<2440.2442>();
				this.17 = new List<2440.2442>();
			}
			base.15(new 2387.2388(this.21));
		}
		else if (base.13((2450)64))
		{
			if (base.7())
			{
				this.14 = new List<2440.2442>();
				this.16 = new List<2440.2442>();
			}
			base.15(new 2387.2388(this.22));
		}
		else if (base.13((2450)128))
		{
			if (base.7())
			{
				this.15 = new List<2440.2442>();
				this.17 = new List<2440.2442>();
			}
			base.15(delegate(2034 1)
			{
				this.15.Add(new 2440.2442(1.36));
				2123 2 = 1 as 2123;
				if (2 != null)
				{
					this.17.Add(new 2440.2442(2.86));
				}
			});
		}
		return true;
	}

	// Token: 0x06002EEE RID: 12014 RVA: 0x00109CC0 File Offset: 0x00107EC0
	internal override void Release()
	{
		if (base.13((2450)16384))
		{
			this.11.Add(this.14);
			this.11.Add(this.15);
			this.11.Add(this.16);
			this.11.Add(this.17);
		}
		else if (base.13((2450)64))
		{
			this.11.Add(this.14);
			this.11.Add(this.16);
		}
		else if (base.13((2450)128))
		{
			this.11.Add(this.15);
			this.11.Add(this.17);
		}
		this.13 = null;
		base.Release();
	}

	// Token: 0x06002EEF RID: 12015 RVA: 0x00109D8C File Offset: 0x00107F8C
	internal override bool HasChanged()
	{
		int num = 0;
		int num2 = 0;
		if (base.13((2450)16384))
		{
			foreach (object obj in this.8)
			{
				2034 <<EMPTY_NAME>> = (2034)obj;
				2440.2442 2 = this.14[num];
				2440.2442 3 = this.15[num];
				if (<<EMPTY_NAME>>.35 != 2.Get(0) || <<EMPTY_NAME>>.36 != 3.Get(0))
				{
					return true;
				}
				2123 4 = <<EMPTY_NAME>> as 2123;
				if (4 != null)
				{
					2 = this.16[num2];
					3 = this.17[num2];
					if (4.85.Count != 2.1.Count || 4.86.Count != 3.1.Count)
					{
						return true;
					}
					if (this.20(4.85, 2) || this.20(4.86, 3))
					{
						return true;
					}
					num2++;
				}
				num++;
			}
			return false;
		}
		if (base.13((2450)64))
		{
			foreach (object obj2 in this.8)
			{
				2034 5 = (2034)obj2;
				2440.2442 6 = this.14[num];
				if (5.35 != 6.Get(0))
				{
					return true;
				}
				2123 7 = 5 as 2123;
				if (7 != null)
				{
					6 = this.16[num2];
					if (7.85.Count != 6.1.Count)
					{
						return true;
					}
					if (this.20(7.85, 6))
					{
						return true;
					}
					num2++;
				}
				num++;
			}
			return false;
		}
		if (base.13((2450)128))
		{
			foreach (object obj3 in this.8)
			{
				2034 8 = (2034)obj3;
				2440.2442 9 = this.15[num];
				if (8.36 != 9.Get(0))
				{
					return true;
				}
				2123 10 = 8 as 2123;
				if (10 != null)
				{
					9 = this.17[num2];
					if (10.86.Count != 9.1.Count)
					{
						return true;
					}
					if (this.20(10.86, 9))
					{
						return true;
					}
					num2++;
				}
				num++;
			}
			return false;
		}
		return true;
	}

	// Token: 0x06002EF0 RID: 12016 RVA: 0x0010A08C File Offset: 0x0010828C
	private bool 20(List<1254> 1, 2440.2442 2)
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

	// Token: 0x06002EF1 RID: 12017 RVA: 0x0010A130 File Offset: 0x00108330
	internal override void Apply(2457 1)
	{
		int num = 0;
		int num2 = 0;
		if (base.13((2450)16384))
		{
			using (List<object>.Enumerator enumerator = this.8.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					2034 2 = (2034)obj;
					177.Method12592<1254>(this.14[num].1, 0, ref 2.35);
					177.Method12592<1254>(this.15[num].1, 0, ref 2.36);
					2123 3 = 2 as 2123;
					if (3 != null)
					{
						177.Method12592<1254>(this.16[num2].1, 3.85);
						177.Method12592<1254>(this.17[num2].1, 3.86);
						3.47();
						num2++;
					}
					num++;
				}
				goto IL_228;
			}
		}
		if (base.13((2450)64))
		{
			using (List<object>.Enumerator enumerator = this.8.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					object obj2 = enumerator.Current;
					2034 4 = (2034)obj2;
					177.Method12592<1254>(this.14[num].1, 0, ref 4.35);
					2123 5 = 4 as 2123;
					if (5 != null)
					{
						177.Method12592<1254>(this.16[num2].1, 5.85);
						base.19<1254>(5, 5.85);
						num2++;
					}
					num++;
				}
				goto IL_228;
			}
		}
		if (base.13((2450)128))
		{
			foreach (object obj3 in this.8)
			{
				2034 6 = (2034)obj3;
				177.Method12592<1254>(this.15[num].1, 0, ref 6.36);
				2123 7 = 6 as 2123;
				if (7 != null)
				{
					177.Method12592<1254>(this.17[num2].1, 7.86);
					base.19<1254>(7, 7.86);
					num2++;
				}
				num++;
			}
		}
		IL_228:
		this.4.1.74.15(this.8);
		if (this.13 != null && this.13.Count > 0)
		{
			this.4.1.74.17((2123)this.8[0], this.13, 0);
		}
		this.4.1.74.53();
	}

	// Token: 0x06002EF2 RID: 12018 RVA: 0x0010A400 File Offset: 0x00108600
	private void 21(2034 1)
	{
		this.14.Add(new 2440.2442(1.35));
		this.15.Add(new 2440.2442(1.36));
		2123 2 = 1 as 2123;
		if (2 != null)
		{
			this.16.Add(new 2440.2442(2.85));
			this.17.Add(new 2440.2442(2.86));
		}
	}

	// Token: 0x06002EF3 RID: 12019 RVA: 0x0010A470 File Offset: 0x00108670
	private void 22(2034 1)
	{
		this.14.Add(new 2440.2442(1.35));
		2123 2 = 1 as 2123;
		if (2 != null)
		{
			this.16.Add(new 2440.2442(2.85));
		}
	}
}
