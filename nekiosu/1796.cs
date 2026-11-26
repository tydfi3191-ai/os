using System;

// Token: 0x020008D0 RID: 2256
public sealed class 1796 : 1779
{
	// Token: 0x060040AB RID: 16555 RVA: 0x00191950 File Offset: 0x0018FB50
	public 1796(string 1)
	{
		int num = 20;
		this.13 = new 1452("nekiosu " + 1, 12f, new 208(0f, (float)(num / 2)), new 208(244f, 0f), 1f, true, 198.White, true);
		this.13.75 = (1066)2;
		this.1.12(this.13);
		base.3(base.2() + new 208(0f, (float)num));
		base.10("version");
	}

	// Token: 0x060040AC RID: 16556 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool IsHeader()
	{
		return true;
	}

	// Token: 0x04002F45 RID: 12101
	private new 1452 13;

	// Token: 0x020008D1 RID: 2257
	[Serializable]
	public sealed class 1797
	{
		// Token: 0x060040AD RID: 16557 RVA: 0x00005ADD File Offset: 0x00003CDD
		internal void 1(object 1, EventArgs 2)
		{
		}

		// Token: 0x04002F46 RID: 12102
		public static readonly 1796.1797 versionLabelCallbacks = new 1796.1797();

		// Token: 0x04002F47 RID: 12103
		public static EventHandler eventHandler;
	}
}
