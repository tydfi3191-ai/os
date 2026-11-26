using System;

// Token: 0x020004C1 RID: 1217
public sealed class 2566
{
	// Token: 0x060024F3 RID: 9459 RVA: 0x000AA8EC File Offset: 0x000A8AEC
	public 2566(string 1, 208 2, string 3 = null, bool 4 = false, int 5 = 0, 1065 6 = 1065.Centre)
	{
		int num = 2630.21() ? -16 : -25;
		1433 7 = new 1433(1455.7(1, (1416)7, true), (1376)6, 6, (1044)0, 2, 4 ? 0.91f : 0.9f, true, 198.TransparentWhite, null)
		{
			16 = 0f
		};
		1445 item = new 1445(1456.Scale, 1f, 0.5f, this.4 + 5, this.4 + 5 + 300, (1046)0)
		{
			15 = (1046)2
		};
		7.3.Add(item);
		item = new 1445(1456.Fade, 0f, 1f, this.4 + 5, this.4 + 5 + 300, (1046)0)
		{
			15 = (1046)2
		};
		7.3.Add(item);
		this.1 = 7;
		this.3 = 4;
		if (3 != null)
		{
			this.1(3, new 208(2.X + 40f, 2.Y + (float)num));
		}
	}

	// Token: 0x060024F4 RID: 9460 RVA: 0x000AAA00 File Offset: 0x000A8C00
	internal void 1(string 1, 208 2)
	{
		208 3 = new 208(40f, 0f);
		1433 4 = new 1353(1, 2630.5.FontScore, (float)2630.5.FontScoreOverlap, (1376)6, 1065.TopLeft, (1044)0, 2, 0.8f, true, 198.TransparentWhite, true, (1416)7);
		4.15 = 1.12f;
		1445 5 = new 1445(4.17 - 3, 4.17, this.4 + 200, this.4 + 200 + 300, (1046)0);
		5.15 = (1046)1;
		4.3.Add(5);
		5 = new 1445(1456.Fade, 0f, 1f, this.4 + 200, this.4 + 200 + 300, (1046)0);
		5.15 = (1046)1;
		4.3.Add(5);
		this.2 = 4;
	}

	// Token: 0x060024F5 RID: 9461 RVA: 0x000AAAEA File Offset: 0x000A8CEA
	internal void 2(float 1)
	{
		if (this.1 != null)
		{
			this.1.14 = 1;
		}
	}

	// Token: 0x060024F6 RID: 9462 RVA: 0x000AAB00 File Offset: 0x000A8D00
	internal void 3(float 1, float 2)
	{
		if (this.1 != null)
		{
			1445 3 = this.1.3.Find(new Predicate<1445>(2566.2567.instance.1));
			if (3 != null)
			{
				3.1 = 1;
				3.5 = 2;
			}
		}
	}

	// Token: 0x040019EF RID: 6639
	internal 1433 1;

	// Token: 0x040019F0 RID: 6640
	internal 1433 2;

	// Token: 0x040019F1 RID: 6641
	internal bool 3;

	// Token: 0x040019F2 RID: 6642
	internal int 4 = 1662.33 + 300;

	// Token: 0x020004C2 RID: 1218
	[Serializable]
	public sealed class 2567
	{
		// Token: 0x060024F7 RID: 9463 RVA: 0x000AAB47 File Offset: 0x000A8D47
		internal bool 1(1445 1)
		{
			return 1.14 == 1456.Scale;
		}

		// Token: 0x040019F3 RID: 6643
		public static readonly 2566.2567 instance = new 2566.2567();

		// Token: 0x040019F4 RID: 6644
		public static Predicate<1445> predicate;
	}
}
