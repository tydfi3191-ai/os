using System;
using System.Collections.Generic;

// Token: 0x020005F5 RID: 1525
public sealed class 2381 : 2387
{
	// Token: 0x06002EDF RID: 11999 RVA: 0x0010972B File Offset: 0x0010792B
	internal 2381(2440 1, 2450 2) : base(1, 2)
	{
		base.2((2451)1);
	}

	// Token: 0x06002EE0 RID: 12000 RVA: 0x00109748 File Offset: 0x00107948
	internal override bool CaptureBackup()
	{
		if (!base.9())
		{
			throw new 2448.2449("Not enough objects to initiate backup data");
		}
		if (base.13((2450)256))
		{
			if (base.7())
			{
				this.15.Clear();
			}
			base.15(new 2387.2388(this.19));
			return true;
		}
		2034 <<EMPTY_NAME>> = this.8.Find(new Predicate<object>(2381.2382.instance.1)) as 2034;
		if (<<EMPTY_NAME>> == null)
		{
			return false;
		}
		this.14 = <<EMPTY_NAME>>.18;
		return true;
	}

	// Token: 0x06002EE1 RID: 12001 RVA: 0x001097D0 File Offset: 0x001079D0
	internal override bool HasChanged()
	{
		if (base.13((2450)256))
		{
			int num = 0;
			using (List<object>.Enumerator enumerator = this.8.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					2034 <<EMPTY_NAME>> = (2034)obj;
					if (!(<<EMPTY_NAME>> is 2129))
					{
						if (<<EMPTY_NAME>>.18 != this.15[num])
						{
							return true;
						}
						num++;
					}
				}
				return false;
			}
		}
		foreach (object obj2 in this.8)
		{
			2034 2 = (2034)obj2;
			if (!(2 is 2129) && 2.18 != this.14)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06002EE2 RID: 12002 RVA: 0x001098C0 File Offset: 0x00107AC0
	internal override void Apply(2457 1)
	{
		208 3;
		if (base.13((2450)256))
		{
			int num = 0;
			foreach (object obj in this.8)
			{
				2034 2 = (2034)obj;
				if (!(2 is 2129))
				{
					3 = 2.18;
					2.SetPosition(this.15[num], false);
					this.15[num] = 3;
					num++;
				}
			}
			if (num > 0)
			{
				this.4.6.74();
			}
			return;
		}
		2034 4 = this.8.Find(new Predicate<object>(2381.2382.instance.2)) as 2034;
		if (4 == null)
		{
			throw new Exception();
		}
		3 = 4.18;
		float num2 = 3.X - this.14.X;
		float num3 = 3.Y - this.14.Y;
		this.14 = 3;
		foreach (object obj2 in this.8)
		{
			2034 5 = (2034)obj2;
			5.SetPosition(new 208(5.18.X - num2, 5.18.Y - num3), false);
		}
		this.4.6.74();
	}

	// Token: 0x06002EE3 RID: 12003 RVA: 0x00109A48 File Offset: 0x00107C48
	private void 19(2034 1)
	{
		if (!(1 is 2129))
		{
			this.15.Add(1.18);
		}
	}

	// Token: 0x0400221A RID: 8730
	private 208 14;

	// Token: 0x0400221B RID: 8731
	private new List<208> 15 = new List<208>();

	// Token: 0x020005F6 RID: 1526
	[Serializable]
	public sealed class 2382
	{
		// Token: 0x06002EE4 RID: 12004 RVA: 0x00109A63 File Offset: 0x00107C63
		internal bool 1(object 1)
		{
			return !(1 is 2129);
		}

		// Token: 0x06002EE5 RID: 12005 RVA: 0x00109A63 File Offset: 0x00107C63
		internal bool 2(object 1)
		{
			return !(1 is 2129);
		}

		// Token: 0x0400221C RID: 8732
		public static readonly 2381.2382 instance = new 2381.2382();

		// Token: 0x0400221D RID: 8733
		public static Predicate<object> cachedIsNotSpinner;

		// Token: 0x0400221E RID: 8734
		public static Predicate<object> cachedIsNotSpinnerForApply;
	}
}
