using System;

// Token: 0x02000512 RID: 1298
[276]
internal sealed class 2539 : 2503
{
	// Token: 0x060027A8 RID: 10152 RVA: 0x000C6CC5 File Offset: 0x000C4EC5
	internal 2539(2511 1, 2528 2) : base(1, 2)
	{
		base.6();
	}

	// Token: 0x060027A9 RID: 10153 RVA: 0x000C6CD8 File Offset: 0x000C4ED8
	protected override string GetText()
	{
		2241 <<EMPTY_NAME>> = 2486.88;
		string text = (<<EMPTY_NAME>> != null) ? <<EMPTY_NAME>>.23 : null;
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return 1304.189 ?? "Player";
	}
}
