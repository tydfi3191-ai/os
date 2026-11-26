using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

// Token: 0x02000698 RID: 1688
[276]
internal static class 2224
{
	// Token: 0x060032A7 RID: 12967 RVA: 0x00133EE8 File Offset: 0x001320E8
	internal static 2224.2225 Get(string 1)
	{
		2224.1();
		2224.2225 result;
		if (!2224.2.TryGetValue(1 ?? string.Empty, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x060032A8 RID: 12968 RVA: 0x00133F18 File Offset: 0x00132118
	internal static void Note(string 1, int 2, double 3)
	{
		if (string.IsNullOrEmpty(1))
		{
			return;
		}
		2224.1();
		2224.2225 4;
		if (!2224.2.TryGetValue(1, out 4))
		{
			4 = (2224.2[1] = new 2224.2225());
		}
		bool flag = false;
		DateTime utcNow = DateTime.UtcNow;
		if (2 > 0 && (4.1 <= 0 || 2 < 4.1))
		{
			4.1 = 2;
			4.2 = utcNow;
			flag = true;
		}
		if (3 > 4.3 + 1E-09)
		{
			4.3 = 3;
			4.4 = utcNow;
			flag = true;
		}
		if (flag)
		{
			2224.Save();
		}
	}

	// Token: 0x17000280 RID: 640
	// (get) Token: 0x060032A9 RID: 12969 RVA: 0x00133FAD File Offset: 0x001321AD
	private static string FilePath
	{
		get
		{
			return 268.2("nekiosu.peaks.json");
		}
	}

	// Token: 0x060032AA RID: 12970 RVA: 0x00133FBC File Offset: 0x001321BC
	private static void 1()
	{
		if (2224.2 != null)
		{
			return;
		}
		2224.2 = new Dictionary<string, 2224.2225>(StringComparer.Ordinal);
		try
		{
			if (File.Exists(2224.FilePath))
			{
				foreach (222 <<EMPTY_NAME>> in 217.Parse(File.ReadAllText(2224.FilePath, Encoding.UTF8)).Properties())
				{
					217 2 = <<EMPTY_NAME>>.Value as 217;
					if (2 != null)
					{
						2224.2[<<EMPTY_NAME>>.Name] = new 2224.2225
						{
							1 = ((int?)2["rank"]).GetValueOrDefault(),
							2 = 2224.Time(2["rank_time"]),
							3 = ((double?)2["acc"]).GetValueOrDefault(),
							4 = 2224.Time(2["acc_time"])
						};
					}
				}
			}
		}
		catch (Exception ex)
		{
			1338.4(ex, "reading nekiosu.peaks.json", 1341.Runtime);
		}
	}

	// Token: 0x060032AB RID: 12971 RVA: 0x001340EC File Offset: 0x001322EC
	private static DateTime Time(226 1)
	{
		DateTime result;
		if (!DateTime.TryParse((string)1, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal, out result))
		{
			return DateTime.MinValue;
		}
		return result;
	}

	// Token: 0x060032AC RID: 12972 RVA: 0x00134118 File Offset: 0x00132318
	private static void Save()
	{
		try
		{
			217 <<EMPTY_NAME>> = new 217();
			foreach (KeyValuePair<string, 2224.2225> keyValuePair in 2224.2)
			{
				217 2 = <<EMPTY_NAME>>;
				string key = keyValuePair.Key;
				217 3 = new 217();
				3["rank"] = keyValuePair.Value.1;
				3["rank_time"] = keyValuePair.Value.2.ToString("o", CultureInfo.InvariantCulture);
				3["acc"] = keyValuePair.Value.3;
				3["acc_time"] = keyValuePair.Value.4.ToString("o", CultureInfo.InvariantCulture);
				2[key] = 3;
			}
			byte[] bytes = Encoding.UTF8.GetBytes(<<EMPTY_NAME>>.ToString((95)0, Array.Empty<214>()));
			using (2681 4 = new 2681(2224.FilePath))
			{
				4.Write(bytes, 0, bytes.Length);
			}
		}
		catch (Exception ex)
		{
			1338.4(ex, "saving nekiosu.peaks.json", 1341.Runtime);
		}
	}

	// Token: 0x04002575 RID: 9589
	private const string 1 = "nekiosu.peaks.json";

	// Token: 0x04002576 RID: 9590
	private static Dictionary<string, 2224.2225> 2;

	// Token: 0x02000699 RID: 1689
	[276]
	internal sealed class 2225
	{
		// Token: 0x04002577 RID: 9591
		public int 1;

		// Token: 0x04002578 RID: 9592
		public DateTime 2;

		// Token: 0x04002579 RID: 9593
		public double 3;

		// Token: 0x0400257A RID: 9594
		public DateTime 4;
	}
}
