using System;
using System.Collections.Generic;

// Token: 0x020008C8 RID: 2248
public sealed class 1783
{
	// Token: 0x06004081 RID: 16513 RVA: 0x00190B7C File Offset: 0x0018ED7C
	public 1783(1782 1, EventHandler 2)
	{
		this.2 = 1;
		this.3 = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, 208.Zero, 0.1f, true, new 198(8, 8, 8, 191), null);
		this.3.16 = 0.01f;
		this.3.15 = 1.6f;
		this.3.20 = new 208(140f, 40f);
		this.3.10 = true;
		this.3.3(2);
		this.3.11 = true;
		this.3.35(new EventHandler(this.2));
		this.3.37(new EventHandler(this.1));
		this.3.8 = this.2;
		this.1.Add(this.3);
		this.4 = new 1433(1662.34, (1376)8, 1065.TopRight, (1044)0, 208.Zero, 0.11f, true, 2630.14, null);
		this.4.16 = 0f;
		this.4.15 = 1.6f;
		this.4.20 = new 208(4f, 40f);
		this.1.Add(this.4);
		this.5 = new 1386(1.13, 18f, new 208(20f, 20f))
		{
			6 = new 198(153, 153, 153)
		};
		this.1.Add(this.5);
		this.6 = new 1452(1.14, 14f, new 208(45f, 20f), 0.5f, true, 198.White)
		{
			49 = 1065.CentreLeft
		};
		this.1.Add(this.6);
	}

	// Token: 0x06004082 RID: 16514 RVA: 0x00190D82 File Offset: 0x0018EF82
	private void 1(object 1, EventArgs 2)
	{
		if (!this.7)
		{
			this.5.39(new 198(153, 153, 153), 100, false, (1046)0);
		}
	}

	// Token: 0x06004083 RID: 16515 RVA: 0x00190DB0 File Offset: 0x0018EFB0
	private void 2(object 1, EventArgs 2)
	{
		this.5.39(198.White, 100, false, (1046)0);
	}

	// Token: 0x06004084 RID: 16516 RVA: 0x00190DC8 File Offset: 0x0018EFC8
	internal void 3(208 1)
	{
		foreach (1433 2 in this.1)
		{
			2.18(new 208(2.7.X + 1.X, 2.7.Y + 1.Y), 0);
		}
	}

	// Token: 0x06004085 RID: 16517 RVA: 0x00190E44 File Offset: 0x0018F044
	internal void 4()
	{
		this.5.24(0.2f, 100, (1046)0);
		this.6.24(0.2f, 100, (1046)0);
	}

	// Token: 0x06004086 RID: 16518 RVA: 0x00190E6C File Offset: 0x0018F06C
	internal void 5()
	{
		this.5.FadeIn(100, (1046)0, 0);
		this.6.FadeIn(100, (1046)0, 0);
	}

	// Token: 0x06004087 RID: 16519 RVA: 0x00190E8C File Offset: 0x0018F08C
	internal void 6(bool 1)
	{
		if (this.7 != 1)
		{
			this.7 = 1;
			if (this.7)
			{
				this.3.FadeIn(100, (1046)0, 0);
				this.4.FadeIn(300, (1046)7, 0);
				this.2(null, null);
				return;
			}
			this.3.24(0.01f, 300, (1046)0);
			this.4.16(300, (1046)7, 0);
			this.1(null, null);
		}
	}

	// Token: 0x04002F2B RID: 12075
	internal List<1433> 1 = new List<1433>();

	// Token: 0x04002F2C RID: 12076
	internal 1782 2;

	// Token: 0x04002F2D RID: 12077
	private 1433 3;

	// Token: 0x04002F2E RID: 12078
	private 1433 4;

	// Token: 0x04002F2F RID: 12079
	private 1386 5;

	// Token: 0x04002F30 RID: 12080
	private 1452 6;

	// Token: 0x04002F31 RID: 12081
	private bool 7;
}
