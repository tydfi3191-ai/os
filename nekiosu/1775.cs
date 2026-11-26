using System;

// Token: 0x020008B2 RID: 2226
public sealed class 1775 : 1779
{
	// Token: 0x06003FB3 RID: 16307 RVA: 0x0018A858 File Offset: 0x00188A58
	public 1775()
	{
		base.3(new 208(244f, 30f));
		this.13 = 2468.1(2630.26());
		this.13.41 = (1376)6;
		this.13.20 = new 208(0.5f, 0.5f);
		this.13.17 = new 208(base.2().X / 2f, base.2().Y / 2f);
		this.13.10 = true;
		this.13.3(new EventHandler(1775.1776.instance.1));
		this.1.12(this.13);
	}

	// Token: 0x06003FB4 RID: 16308 RVA: 0x0018A920 File Offset: 0x00188B20
	public override void Dispose()
	{
		base.Dispose();
		this.13.Dispose();
	}

	// Token: 0x04002E8F RID: 11919
	private new 1433 13;

	// Token: 0x020008B3 RID: 2227
	[Serializable]
	public sealed class 1776
	{
		// Token: 0x06003FB5 RID: 16309 RVA: 0x0018A933 File Offset: 0x00188B33
		internal void 1(object 1, EventArgs 2)
		{
			1662.104.55();
		}

		// Token: 0x04002E90 RID: 11920
		public static readonly 1775.1776 instance = new 1775.1776();

		// Token: 0x04002E91 RID: 11921
		public static EventHandler logoutCallback;
	}
}
