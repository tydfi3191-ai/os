using System;

// Token: 0x02000706 RID: 1798
[276]
public sealed class 2144 : 2508
{
	// Token: 0x06003508 RID: 13576 RVA: 0x00146E6A File Offset: 0x0014506A
	public 2144(1803 1, 2039 2) : base(1, 2)
	{
	}

	// Token: 0x06003509 RID: 13577 RVA: 0x00146E74 File Offset: 0x00145074
	internal override void BuildLayout()
	{
		base.BuildLayout();
		this.GetBarCenter();
		float num = this.GetScaledHitWindow() / 2f;
		float scaledHitWindow = this.GetScaledHitWindow();
		1433 <<EMPTY_NAME>> = new 1433(1662.34, (1376)6, 1065.Centre, (1044)1, this.GetBarCenter(), 0.79f, true, 198.Black, null);
		<<EMPTY_NAME>>.16 = 0.4f;
		<<EMPTY_NAME>>.20 = new 208(scaledHitWindow, base.7() * 24f) * 1.6f;
		this.4.12(<<EMPTY_NAME>>);
		2131 2 = new 2131(this.3, new 208(256f, 365f), 0, false, 1245.None, 0);
		2.SetComboColour(198.Red);
		2.30.ForEach(new Action<1433>(2144.2145.resetSpriteCallbacks.1));
		this.4.14<1433>(2.30);
	}

	// Token: 0x0600350A RID: 13578 RVA: 0x00146F54 File Offset: 0x00145154
	internal override void OnHitOffset(2034 1, int? 2)
	{
		2131 3 = 1 as 2131;
		string str = "particle";
		int 4 = 1.41;
		1433 5 = new 1433(1455.2(str + 4.ToString(), (1416)7, null), (1376)1, 1065.Centre, (1044)2, new 208(256f, 365f) + 3.51, 1f, false, 198.Black, null);
		5.17(60000);
		this.4.12(5);
		base.OnHitOffset(1, 2);
	}

	// Token: 0x02000707 RID: 1799
	[276]
	[Serializable]
	public sealed class 2145
	{
		// Token: 0x0600350B RID: 13579 RVA: 0x00146FD6 File Offset: 0x001451D6
		internal void 1(1433 1)
		{
			1.5 = true;
			1.3.Clear();
			1.16 = 1f;
		}

		// Token: 0x0400274C RID: 10060
		public static readonly 2144.2145 resetSpriteCallbacks = new 2144.2145();

		// Token: 0x0400274D RID: 10061
		public static Action<1433> action;
	}
}
