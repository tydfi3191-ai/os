using System;
using System.Collections.Generic;

// Token: 0x0200060F RID: 1551
public sealed class 2407 : 2421
{
	// Token: 0x06002F5F RID: 12127 RVA: 0x0010BED4 File Offset: 0x0010A0D4
	internal 2407(2445 1, 2450 2) : base(1, 2)
	{
		base.2((2451)0);
	}

	// Token: 0x06002F60 RID: 12128 RVA: 0x0010BEE8 File Offset: 0x0010A0E8
	internal override bool CaptureBackup()
	{
		if (!base.9())
		{
			throw new 2448.2449("Not enough objects to initiate backup data");
		}
		int i = base.8();
		2647 <<EMPTY_NAME>> = (2647)this.8[i];
		bool flag = <<EMPTY_NAME>>.10 == 2635.Break;
		if (base.13((2450)256))
		{
			if (base.13((2450)2048))
			{
				if (base.7())
				{
					base.17();
				}
				if (flag && base.7())
				{
					this.20 = new List<bool>();
					this.21 = new List<bool>();
				}
				while (i < this.8.Count)
				{
					<<EMPTY_NAME>> = (2647)this.8[i];
					this.16.Add(<<EMPTY_NAME>>.8);
					this.17.Add(<<EMPTY_NAME>>.1);
					if (flag)
					{
						2275 2 = (2275)<<EMPTY_NAME>>;
						this.20.Add(2.12);
						this.21.Add(2.13);
					}
					i++;
				}
			}
			else if (base.13((2450)512))
			{
				if (base.7())
				{
					this.16 = new List<int>();
					this.20 = new List<bool>();
				}
				while (i < this.8.Count)
				{
					2275 3 = (2275)this.8[i];
					this.16.Add(3.8);
					this.20.Add(3.12);
					i++;
				}
			}
			else
			{
				if (base.7())
				{
					this.17 = new List<int>();
					this.21 = new List<bool>();
				}
				while (i < this.8.Count)
				{
					2275 4 = (2275)this.8[i];
					this.17.Add(4.1);
					this.21.Add(4.13);
					i++;
				}
			}
		}
		else
		{
			<<EMPTY_NAME>> = (2647)this.8[0];
			this.18 = <<EMPTY_NAME>>.8;
			this.19 = <<EMPTY_NAME>>.1;
		}
		return true;
	}

	// Token: 0x06002F61 RID: 12129 RVA: 0x0010C108 File Offset: 0x0010A308
	internal override bool HasChanged()
	{
		if (base.13((2450)256))
		{
			int num = 0;
			if (base.13((2450)2048))
			{
				foreach (object obj in this.8)
				{
					2647 <<EMPTY_NAME>> = (2647)obj;
					if (this.16[num] != <<EMPTY_NAME>>.8 || this.17[num] != <<EMPTY_NAME>>.1)
					{
						return true;
					}
					num++;
				}
				return false;
			}
			if (base.13((2450)512))
			{
				foreach (object obj2 in this.8)
				{
					2647 2 = (2647)obj2;
					if (this.16[num] != 2.8)
					{
						return true;
					}
					num++;
				}
				return false;
			}
			foreach (object obj3 in this.8)
			{
				2647 3 = (2647)obj3;
				if (this.17[num] != 3.1)
				{
					return true;
				}
				num++;
			}
			return false;
		}
		if (base.13((2450)0) || base.13((2450)512) || base.13((2450)2048))
		{
			return ((2647)this.8[0]).8 != this.18;
		}
		return !base.13((2450)1024) || ((2647)this.8[0]).1 != this.19;
	}

	// Token: 0x06002F62 RID: 12130 RVA: 0x0010C2F8 File Offset: 0x0010A4F8
	internal override void Apply(2457 1)
	{
		if (base.13((2450)256))
		{
			if (base.13((2450)2048))
			{
				bool flag = ((2647)this.8[0]).10 == 2635.Break;
				int num = 0;
				foreach (object obj in this.8)
				{
					2647 2 = (2647)obj;
					177.Method12592<int>(this.16, num, ref 2.8);
					177.Method12592<int>(this.17, num, ref 2.1);
					if (flag)
					{
						2275 3 = (2275)2;
						177.Method12592<bool>(this.20, num, ref 3.12);
						177.Method12592<bool>(this.21, num, ref 3.13);
					}
					num++;
				}
				return;
			}
			if (base.13((2450)512))
			{
				bool flag2 = ((2647)this.8[0]).10 == 2635.Break;
				int num2 = 0;
				foreach (object obj2 in this.8)
				{
					2647 4 = (2647)obj2;
					177.Method12592<int>(this.16, num2, ref 4.8);
					if (flag2)
					{
						2275 5 = (2275)4;
						177.Method12592<bool>(this.20, num2, ref 5.12);
					}
					num2++;
				}
				return;
			}
			bool flag3 = ((2647)this.8[0]).10 == 2635.Break;
			int num3 = 0;
			foreach (object obj3 in this.8)
			{
				2647 6 = (2647)obj3;
				177.Method12592<int>(this.17, num3, ref 6.1);
				if (flag3)
				{
					2275 7 = (2275)6;
					177.Method12592<bool>(this.21, num3, ref 7.13);
				}
				num3++;
			}
			return;
		}
		else
		{
			if (base.13((2450)0) || base.13((2450)512))
			{
				2647 8 = (2647)this.8[0];
				int num4 = 8.8 - this.18;
				this.18 = 8.8;
				foreach (object obj4 in this.8)
				{
					((2647)obj4).8 -= num4;
				}
				return;
			}
			if (!base.13((2450)2048))
			{
				return;
			}
			2647 9 = (2647)this.8[0];
			int num5 = 9.8 - this.18;
			this.18 = 9.8;
			this.19 = 9.1;
			foreach (object obj5 in this.8)
			{
				2647 10 = (2647)obj5;
				if (10 is 2654 || 10 is 2655 || 10 is 2646 || 10 is 2658)
				{
					10.8 -= num5;
					10.1 -= num5;
					if (10.7 != null)
					{
						foreach (1445 11 in 10.7.3)
						{
							11.9 -= num5;
							11.10 -= num5;
						}
						if (10.7.4 != null)
						{
							foreach (1457 12 in 10.7.4)
							{
								12.2 -= num5;
							}
						}
					}
					foreach (List<2657> list in 10.2.Values)
					{
						foreach (2657 13 in list)
						{
							13.2 -= num5;
							13.6 -= num5;
							13.5 -= num5;
						}
					}
				}
			}
			return;
		}
	}

	// Token: 0x0400223E RID: 8766
	private new int 18;

	// Token: 0x0400223F RID: 8767
	private new int 19;

	// Token: 0x04002240 RID: 8768
	private List<bool> 20;

	// Token: 0x04002241 RID: 8769
	private List<bool> 21;
}
