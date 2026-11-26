using System;
using System.Collections.Generic;

// Token: 0x02000AA1 RID: 2721
public sealed class 1400
{
	// Token: 0x06004B80 RID: 19328 RVA: 0x001DE4CD File Offset: 0x001DC6CD
	internal 1400()
	{
	}

	// Token: 0x06004B81 RID: 19329 RVA: 0x001DE4E0 File Offset: 0x001DC6E0
	internal 1406 1(1406 1)
	{
		this.1.Add(1);
		return 1;
	}

	// Token: 0x06004B82 RID: 19330 RVA: 0x001DE4F0 File Offset: 0x001DC6F0
	internal 1406 2(1433 1, 208? 2, bool 3)
	{
		1406 result = new 1406(1, (2 != null) ? 2.Value : 208.Zero);
		this.1(result);
		return result;
	}

	// Token: 0x06004B83 RID: 19331 RVA: 0x001DE524 File Offset: 0x001DC724
	internal void 3()
	{
		for (int i = this.1.Count - 1; i >= 0; i--)
		{
			1406 <<EMPTY_NAME>> = this.1[i];
			1433 2 = <<EMPTY_NAME>>.1;
			bool flag = (2.3.Count == 0 || 2.3[2.3.Count - 1].10 < 1436.25(2)) && (!2.19 || 2.17.Y > 550f);
			bool flag2 = 2.3.Count > 0 && 2.3[0].9 > 1436.25(2);
			bool flag3 = 2.1 == (1044)1 && 1226.10();
			if (flag || flag2 || flag3)
			{
				if (flag)
				{
					this.1.RemoveAt(i);
				}
			}
			else
			{
				1406 3 = <<EMPTY_NAME>>;
				3.2.Y = 3.2.Y + 8f * (float)1662.10 * (1f + <<EMPTY_NAME>>.3 / 100f);
				2.17 += <<EMPTY_NAME>>.2 * (float)(1662.82 / 1000.0);
				if (<<EMPTY_NAME>>.4 && 2.41 == (1376)6 && ((2.17.X < 0f && <<EMPTY_NAME>>.2.X < 0f) || (2.17.X > (float)1662.70.1() && <<EMPTY_NAME>>.2.X > 0f)))
				{
					<<EMPTY_NAME>>.2.X = 0f - <<EMPTY_NAME>>.2.X;
				}
			}
		}
	}

	// Token: 0x04003848 RID: 14408
	private List<1406> 1 = new List<1406>();
}
