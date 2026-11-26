using System;
using System.Collections.Generic;

// Token: 0x02000A70 RID: 2672
public sealed class 1352
{
	// Token: 0x06004A1D RID: 18973 RVA: 0x001D5A6C File Offset: 0x001D3C6C
	internal 1352(string 1, int 2, 1058 3)
	{
		this.2 = 2;
		this.3 = 1;
		this.1 = new List<1433>(4);
		if (3.Width != 0f && 3.Height != 0f)
		{
			1433 item = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, new 208(0f, 0f), 0.9f, false, 198.Black, null)
			{
				16 = 0.94f,
				20 = new 208(3.X, 480f) * 1.6f
			};
			this.1.Add(item);
			item = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, new 208(3.X + 3.Width, 0f), 0.9f, false, 198.Black, null)
			{
				16 = 0.94f,
				20 = new 208((float)1662.70.1() - 3.X - 3.Width, 480f) * 1.6f
			};
			this.1.Add(item);
			item = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, new 208(3.X, 0f), 0.9f, false, 198.Black, null)
			{
				16 = 0.94f,
				20 = new 208(3.Width, 3.Y) * 1.6f
			};
			this.1.Add(item);
			item = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, new 208(3.X, 3.Y + 3.Height), 0.9f, false, 198.Black, null)
			{
				16 = 0.94f,
				20 = new 208(3.Width, 480f - 3.Y - 3.Height) * 1.6f
			};
			this.1.Add(item);
		}
	}

	// Token: 0x06004A1E RID: 18974 RVA: 0x001D5C70 File Offset: 0x001D3E70
	internal void 1()
	{
		foreach (1433 <<EMPTY_NAME>> in this.1)
		{
			<<EMPTY_NAME>>.3.Add(new 1445(1456.Fade, 0f, 0.8f, 1662.33, 1662.33 + 100, (1046)0));
			<<EMPTY_NAME>>.3.Add(new 1445(1456.Fade, 0.8f, 0f, 1662.33 + this.2, 1662.33 + this.2 + 150, (1046)0));
		}
	}

	// Token: 0x0400372E RID: 14126
	internal List<1433> 1;

	// Token: 0x0400372F RID: 14127
	internal int 2;

	// Token: 0x04003730 RID: 14128
	internal string 3;

	// Token: 0x04003731 RID: 14129
	internal int 4;
}
