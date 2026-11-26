using System;

// Token: 0x02000746 RID: 1862
[276]
internal static class 2099
{
	// Token: 0x17000295 RID: 661
	// (get) Token: 0x060036D3 RID: 14035 RVA: 0x00157F7C File Offset: 0x0015617C
	internal static 2100 Current
	{
		get
		{
			1318 <<EMPTY_NAME>> = 1304.25;
			int num = (<<EMPTY_NAME>> != null) ? <<EMPTY_NAME>>.6() : 0;
			if (num == 1)
			{
				return 2100.NoNerfs;
			}
			if (num != 2)
			{
				return 2100.Lazer;
			}
			return 2100.Akatsuki;
		}
	}

	// Token: 0x060036D4 RID: 14036 RVA: 0x00157FA8 File Offset: 0x001561A8
	internal static bool 1(2023 1)
	{
		return (1 & 2023.Relax) > 2023.None;
	}

	// Token: 0x060036D5 RID: 14037 RVA: 0x00157FB4 File Offset: 0x001561B4
	internal static 2023 2(2023 1, 2100 2)
	{
		if (!2099.1(1) || 2 != 2100.NoNerfs)
		{
			return 1;
		}
		return 1 & ~2023.Relax;
	}

	// Token: 0x060036D6 RID: 14038 RVA: 0x00157FCC File Offset: 0x001561CC
	internal static string Tag(2023 1, 2100 2)
	{
		if (!2099.1(1) || 2 == 2100.Lazer)
		{
			return string.Empty;
		}
		string str = "rx";
		int num = (int)2;
		return str + num.ToString();
	}
}
