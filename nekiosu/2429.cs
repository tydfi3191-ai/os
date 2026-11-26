using System;
using System.Collections.Generic;

// Token: 0x02000625 RID: 1573
public sealed class 2429 : 2435
{
	// Token: 0x06002FB9 RID: 12217 RVA: 0x0010D9A3 File Offset: 0x0010BBA3
	internal 2429(2447 1, 2450 2) : base(1, 2)
	{
		base.2((2451)20);
	}

	// Token: 0x06002FBA RID: 12218 RVA: 0x0010D9B5 File Offset: 0x0010BBB5
	internal override bool CaptureBackup()
	{
		if (!base.9())
		{
			throw new 2448.2449("Not enough objects to initiate backup data");
		}
		if (base.7())
		{
			this.13 = new List<bool>();
		}
		base.15(new 2435.2436(this.16));
		return true;
	}

	// Token: 0x06002FBB RID: 12219 RVA: 0x0010D9F0 File Offset: 0x0010BBF0
	internal override void Release()
	{
		this.11.Add(this.13);
		base.Release();
	}

	// Token: 0x06002FBC RID: 12220 RVA: 0x0010DA0C File Offset: 0x0010BC0C
	internal override bool HasChanged()
	{
		int num = 0;
		using (List<object>.Enumerator enumerator = this.8.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (((1259)enumerator.Current).3() != this.13[num])
				{
					return true;
				}
				num++;
			}
		}
		return false;
	}

	// Token: 0x06002FBD RID: 12221 RVA: 0x0010DA7C File Offset: 0x0010BC7C
	internal override void Apply(2457 1)
	{
		int num = 0;
		foreach (object obj in this.8)
		{
			1259 2 = (1259)obj;
			bool value = 2.3();
			2.4(this.13[num]);
			this.13[num] = value;
			num++;
		}
	}

	// Token: 0x06002FBE RID: 12222 RVA: 0x0010DAF8 File Offset: 0x0010BCF8
	private void 16(1259 1)
	{
		this.13.Add(1.3());
	}

	// Token: 0x04002262 RID: 8802
	private new List<bool> 13;
}
