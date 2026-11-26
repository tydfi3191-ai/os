using System;
using System.Collections.Generic;

// Token: 0x020005FA RID: 1530
public sealed class 2386 : 2387
{
	// Token: 0x06002EFA RID: 12026 RVA: 0x0010A5FC File Offset: 0x001087FC
	internal 2386(2440 1, 2450 2 = (2450)0) : base(1, 2)
	{
		base.2((2451)0);
	}

	// Token: 0x06002EFB RID: 12027 RVA: 0x0010A624 File Offset: 0x00108824
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
				this.16.Clear();
			}
			if (base.13((2450)2048))
			{
				base.15(new 2387.2388(this.19));
			}
			else
			{
				base.15(delegate(2034 1)
				{
					this.15.Add(1.1);
				});
			}
		}
		else
		{
			2034 <<EMPTY_NAME>> = (2034)this.8[0];
			this.14 = <<EMPTY_NAME>>.1;
		}
		return true;
	}

	// Token: 0x06002EFC RID: 12028 RVA: 0x0010A6C4 File Offset: 0x001088C4
	internal override bool HasChanged()
	{
		if (base.13((2450)256))
		{
			int num = 0;
			bool flag = base.13((2450)2048);
			foreach (object obj in this.8)
			{
				2034 <<EMPTY_NAME>> = (2034)obj;
				if (<<EMPTY_NAME>>.1 != this.15[num] || (flag && <<EMPTY_NAME>>.2 != this.16[num]))
				{
					return true;
				}
				num++;
			}
			return false;
		}
		return ((2034)this.8[0]).1 != this.14;
	}

	// Token: 0x06002EFD RID: 12029 RVA: 0x0010A78C File Offset: 0x0010898C
	internal override void Apply(2457 1)
	{
		int num = 0;
		if (base.13((2450)256))
		{
			bool flag = base.13((2450)2048);
			using (List<object>.Enumerator enumerator = this.8.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					2034 2 = (2034)obj;
					int 3 = 2.1;
					int 4 = 2.2;
					2.SetStartTime(this.15[num]);
					this.15[num] = 3;
					if (flag && (2.HasObjectType(2047.Spinner) || 2.HasObjectType(2047.Hold)))
					{
						2.SetEndTime(this.16[num]);
						this.16[num] = 4;
					}
					num++;
				}
				goto IL_12E;
			}
		}
		int 5 = ((2034)this.8[0]).1;
		int num2 = 5 - this.14;
		this.14 = 5;
		foreach (object obj2 in this.8)
		{
			2034 6 = (2034)obj2;
			6.SetStartTime(6.1 - num2);
		}
		IL_12E:
		this.4.1.74.16();
		this.4.6.2(true);
		this.4.6.74();
	}

	// Token: 0x06002EFE RID: 12030 RVA: 0x0010A91C File Offset: 0x00108B1C
	private void 19(2034 1)
	{
		this.15.Add(1.1);
		this.16.Add(1.2);
	}

	// Token: 0x04002225 RID: 8741
	private int 14;

	// Token: 0x04002226 RID: 8742
	private new List<int> 15 = new List<int>();

	// Token: 0x04002227 RID: 8743
	private new List<int> 16 = new List<int>();
}
