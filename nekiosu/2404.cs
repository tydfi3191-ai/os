using System;
using System.Collections.Generic;

// Token: 0x0200060C RID: 1548
public sealed class 2404 : 2421
{
	// Token: 0x06002F53 RID: 12115 RVA: 0x0010BC59 File Offset: 0x00109E59
	internal 2404(2445 1, 2450 2) : base(1, 2)
	{
		base.2((2451)8);
	}

	// Token: 0x06002F54 RID: 12116 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool CaptureBackup()
	{
		return true;
	}

	// Token: 0x06002F55 RID: 12117 RVA: 0x00108031 File Offset: 0x00106231
	internal override bool HasChanged()
	{
		return this.9.Count > 0;
	}

	// Token: 0x06002F56 RID: 12118 RVA: 0x0010BC6C File Offset: 0x00109E6C
	internal override void Apply(2457 1)
	{
		if (1 != (2457)1)
		{
			if (1 != (2457)2)
			{
				goto IL_97;
			}
		}
		else
		{
			using (List<object>.Enumerator enumerator = this.9.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					2647 2 = (2647)obj;
					this.4.7.12(2);
				}
				goto IL_97;
			}
		}
		foreach (object obj2 in this.9)
		{
			2647 3 = (2647)obj2;
			this.4.7.9(3);
		}
		IL_97:
		base.19();
	}
}
