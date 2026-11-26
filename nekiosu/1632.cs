using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

// Token: 0x0200098C RID: 2444
public static class 1632
{
	// Token: 0x060044A0 RID: 17568 RVA: 0x001B1290 File Offset: 0x001AF490
	static 1632()
	{
		foreach (1637 <<EMPTY_NAME>> in 1632.1)
		{
			string[] hosts = <<EMPTY_NAME>>.Hosts;
			for (int i = 0; i < hosts.Length; i++)
			{
				259.1(hosts[i]);
			}
		}
	}

	// Token: 0x170002DD RID: 733
	// (get) Token: 0x060044A1 RID: 17569 RVA: 0x001B132C File Offset: 0x001AF52C
	public static IReadOnlyList<1637> All
	{
		get
		{
			return 1632.1;
		}
	}

	// Token: 0x170002DE RID: 734
	// (get) Token: 0x060044A2 RID: 17570 RVA: 0x001B1333 File Offset: 0x001AF533
	public static string DefaultName
	{
		get
		{
			return 1632.1[0].Name;
		}
	}

	// Token: 0x170002DF RID: 735
	// (get) Token: 0x060044A3 RID: 17571 RVA: 0x001B1348 File Offset: 0x001AF548
	public static 1637 Current
	{
		get
		{
			1632.<>c__DisplayClass7_0 CS$<>8__locals1 = new 1632.<>c__DisplayClass7_0();
			1632.<>c__DisplayClass7_0 CS$<>8__locals2 = CS$<>8__locals1;
			1320<string> <<EMPTY_NAME>> = 1304.9;
			CS$<>8__locals2.name = ((<<EMPTY_NAME>> != null) ? <<EMPTY_NAME>>.GetValue() : null);
			return 1632.1.FirstOrDefault((1637 1) => 1.Name == CS$<>8__locals1.name) ?? 1632.1[0];
		}
	}

	// Token: 0x060044A4 RID: 17572 RVA: 0x001B1397 File Offset: 0x001AF597
	public static IEnumerable<1637> 1()
	{
		1637 current = 1632.Current;
		yield return current;
		foreach (1637 <<EMPTY_NAME>> in 1632.1)
		{
			if (<<EMPTY_NAME>> != current)
			{
				yield return <<EMPTY_NAME>>;
			}
		}
		List<1637>.Enumerator enumerator = default(List<1637>.Enumerator);
		yield break;
		yield break;
	}

	// Token: 0x060044A5 RID: 17573 RVA: 0x001B13A0 File Offset: 0x001AF5A0
	public static string 2(1637 1, Func<1637, string> 2)
	{
		string result;
		if ((result = ((3 != null) ? 2(3) : null)) == null)
		{
			result = 1632.1().Select(2).FirstOrDefault((string 1) => 1 != null);
		}
		return result;
	}

	// Token: 0x060044A6 RID: 17574 RVA: 0x001B13F0 File Offset: 0x001AF5F0
	public static bool 3(Exception 1)
	{
		WebException ex = 1 as WebException;
		if (ex == null)
		{
			return false;
		}
		bool result;
		try
		{
			HttpWebResponse httpWebResponse = ex.Response as HttpWebResponse;
			result = (httpWebResponse != null && httpWebResponse.StatusCode == HttpStatusCode.NotFound);
		}
		catch (ObjectDisposedException)
		{
			result = ex.Message.Contains("(404)");
		}
		return result;
	}

	// Token: 0x060044A7 RID: 17575 RVA: 0x001B1450 File Offset: 0x001AF650
	public static bool 4(char 1)
	{
		return !261.FullyOffline && 1632.1.Any((1637 1) => 1.SupportsLookup(2));
	}

	// Token: 0x060044A8 RID: 17576 RVA: 0x001B148C File Offset: 0x001AF68C
	public static 1637 Next(1637 1, Func<1637, bool> 2 = null)
	{
		1637 3 = 1632.1().SkipWhile((1637 1) => 1 != 4).Skip(1).FirstOrDefault((1637 1) => 2 == null || 2(1));
		if (3 != null)
		{
			string str = "Beatmap mirror ";
			1637 failed = 4;
			1338.5(str + ((failed != null) ? failed.Name : null) + " failed, trying " + 3.Name, 1341.Runtime, (1114)2);
		}
		return 3;
	}

	// Token: 0x0400327C RID: 12924
	private static readonly List<1637> 1 = new List<1637>
	{
		new 1636(),
		new 1635(),
		new 1640(),
		new 1641()
	};
}
