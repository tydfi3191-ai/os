using System;

// Token: 0x02000764 RID: 1892
public static class 2006
{
	// Token: 0x06003794 RID: 14228 RVA: 0x0015C338 File Offset: 0x0015A538
	internal static void 1()
	{
		for (int i = 1; i <= 18; i++)
		{
			for (int j = 0; j < 2; j++)
			{
				2005 <<EMPTY_NAME>> = 2006.1[i, j] = new 2005(i, (2008)j);
				string str = 2006.4((2008)j);
				try
				{
					object obj;
					if (1304.1.TryGetValue("ManiaLayouts" + i.ToString() + "K" + str, out obj))
					{
						<<EMPTY_NAME>>.4(obj.ToString());
					}
				}
				catch
				{
				}
				try
				{
					object obj2;
					if (1304.1.TryGetValue("ManiaLayoutSelected" + i.ToString() + "K" + str, out obj2))
					{
						<<EMPTY_NAME>>.2(int.Parse(obj2.ToString()));
					}
				}
				catch
				{
				}
			}
		}
	}

	// Token: 0x06003795 RID: 14229 RVA: 0x0015C41C File Offset: 0x0015A61C
	internal static void 2()
	{
		for (int i = 1; i <= 18; i++)
		{
			for (int j = 0; j < 2; j++)
			{
				2005 <<EMPTY_NAME>> = 2006.1[i, j];
				string value;
				if (!string.IsNullOrEmpty(value = <<EMPTY_NAME>>.ToString()))
				{
					string str = 2006.4((2008)j);
					1304.1["ManiaLayouts" + i.ToString() + "K" + str] = value;
					1304.1["ManiaLayoutSelected" + i.ToString() + "K" + str] = <<EMPTY_NAME>>.1().ToString();
				}
			}
		}
	}

	// Token: 0x06003796 RID: 14230 RVA: 0x0015C4C0 File Offset: 0x0015A6C0
	internal static 2005 3(int 1, 2008 2)
	{
		return 2006.1[1, (int)2];
	}

	// Token: 0x06003797 RID: 14231 RVA: 0x0015C4CE File Offset: 0x0015A6CE
	private static string 4(2008 1)
	{
		if (1 != 2008.Normal)
		{
			return 1.ToString();
		}
		return string.Empty;
	}

	// Token: 0x04002932 RID: 10546
	private static 2005[,] 1 = new 2005[19, 2];
}
