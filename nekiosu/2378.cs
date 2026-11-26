using System;
using System.Collections.Generic;

// Token: 0x020005F2 RID: 1522
public sealed class 2378 : 2387
{
	// Token: 0x06002ECC RID: 11980 RVA: 0x00108C56 File Offset: 0x00106E56
	internal 2378(2440 1, 2450 2 = (2450)0) : base(1, 2)
	{
		base.2((2451)7);
	}

	// Token: 0x06002ECD RID: 11981 RVA: 0x00108C88 File Offset: 0x00106E88
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
				this.17 = new List<int>();
				this.18 = new List<double>();
				this.19 = new List<double>();
			}
			base.15(new 2387.2388(this.19));
			return true;
		}
		bool flag = false;
		bool flag2 = false;
		foreach (object obj in this.8)
		{
			2034 <<EMPTY_NAME>> = (2034)obj;
			2123 2 = <<EMPTY_NAME>> as 2123;
			if (2 != null)
			{
				if (!flag)
				{
					this.15 = 2.6;
					this.16 = 2.87;
					flag = true;
				}
			}
			else if ((<<EMPTY_NAME>>.HasObjectType(2047.Spinner) || <<EMPTY_NAME>>.HasObjectType(2047.Hold)) && !flag2)
			{
				this.14 = <<EMPTY_NAME>>.GetDuration();
				flag2 = true;
			}
			if (flag2 && flag)
			{
				break;
			}
		}
		if (!flag2 && !flag)
		{
			throw new InvalidOperationException("Not enough data to perform this action");
		}
		return true;
	}

	// Token: 0x06002ECE RID: 11982 RVA: 0x00108DA8 File Offset: 0x00106FA8
	internal override void Release()
	{
		this.14 = -1;
		this.15 = -1.0;
		this.11.Add(this.19);
		this.11.Add(this.18);
		this.11.Add(this.17);
		base.Release();
	}

	// Token: 0x06002ECF RID: 11983 RVA: 0x00108E04 File Offset: 0x00107004
	internal override bool HasChanged()
	{
		if (base.13((2450)256))
		{
			int num = 0;
			int num2 = 0;
			using (List<object>.Enumerator enumerator = this.8.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					2034 <<EMPTY_NAME>> = (2034)obj;
					2123 2 = <<EMPTY_NAME>> as 2123;
					if (2 != null)
					{
						if (2.6 != this.18[num2] || 2.87 != this.19[num2])
						{
							return true;
						}
						num2++;
					}
					else if (<<EMPTY_NAME>>.HasObjectType(2047.Spinner) || <<EMPTY_NAME>>.HasObjectType(2047.Hold))
					{
						if (<<EMPTY_NAME>>.GetDuration() != this.17[num])
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
			2034 3 = (2034)obj2;
			2123 4 = 3 as 2123;
			if (4 != null)
			{
				if (4.6 != this.15 || 4.87 != this.16)
				{
					return true;
				}
			}
			else if ((3.HasObjectType(2047.Spinner) || 3.HasObjectType(2047.Hold)) && 3.GetDuration() != this.14)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06002ED0 RID: 11984 RVA: 0x00108F90 File Offset: 0x00107190
	internal override void Apply(2457 1)
	{
		int num = 0;
		if (base.13((2450)256))
		{
			int num2 = 0;
			int num3 = 0;
			foreach (object obj in this.8)
			{
				2034 2 = (2034)obj;
				2123 3 = 2 as 2123;
				if (3 != null)
				{
					177.Method12592<double>(this.18, num3, ref 3.6);
					177.Method12592<double>(this.19, num3, ref 3.87);
					3.62 = true;
					3.RebuildPathAndTiming(true);
					3.62 = false;
					num3++;
				}
				else if (2.HasObjectType(2047.Spinner) || 2.HasObjectType(2047.Hold))
				{
					num = 2.GetDuration() - this.17[num2];
					this.17[num2] = 2.GetDuration();
					2.SetEndTime(2.2 - num);
					num2++;
				}
			}
			this.4.6.74();
			return;
		}
		double num4 = -1.0;
		double num5 = -1.0;
		bool flag = false;
		bool flag2 = false;
		foreach (object obj2 in this.8)
		{
			2034 4 = (2034)obj2;
			2123 5 = 4 as 2123;
			if (5 != null)
			{
				if (!flag)
				{
					num4 = 5.6;
					num5 = 5.87;
					flag = true;
				}
				5.6 = this.15;
				5.87 = this.16;
				this.15 = num4;
				this.16 = num5;
			}
			else if (4.HasObjectType(2047.Spinner) || 4.HasObjectType(2047.Hold))
			{
				if (!flag2)
				{
					num = 4.GetDuration() - this.14;
					this.14 = 4.GetDuration();
					flag2 = true;
				}
				4.SetEndTime(4.2 - num);
			}
		}
		this.4.6.74();
	}

	// Token: 0x06002ED1 RID: 11985 RVA: 0x001091C8 File Offset: 0x001073C8
	private void 19(2034 1)
	{
		2123 2 = 1 as 2123;
		if (2 != null)
		{
			this.18.Add(2.6);
			this.19.Add(2.87);
			return;
		}
		if (1.HasObjectType(2047.Spinner) || 1.HasObjectType(2047.Hold))
		{
			this.17.Add(1.GetDuration());
		}
	}

	// Token: 0x04002213 RID: 8723
	private int 14;

	// Token: 0x04002214 RID: 8724
	private new double 15;

	// Token: 0x04002215 RID: 8725
	private new double 16;

	// Token: 0x04002216 RID: 8726
	private new List<int> 17 = new List<int>();

	// Token: 0x04002217 RID: 8727
	private new List<double> 18 = new List<double>();

	// Token: 0x04002218 RID: 8728
	private List<double> 19 = new List<double>();
}
