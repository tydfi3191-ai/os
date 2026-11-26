using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

// Token: 0x02000A74 RID: 2676
internal static class 1355
{
	// Token: 0x06004A36 RID: 18998 RVA: 0x001D6D60 File Offset: 0x001D4F60
	internal static double? Get(1262 1)
	{
		if (1 == null || 1.23 == null)
		{
			return null;
		}
		1355.1();
		double value;
		if (!1355.2.TryGetValue(1355.Key(1), out value))
		{
			return null;
		}
		return new double?(value);
	}

	// Token: 0x06004A37 RID: 18999 RVA: 0x001D6DAC File Offset: 0x001D4FAC
	private static string Key(1262 1)
	{
		double? num = 1383.3();
		if (num == null)
		{
			return 1.23;
		}
		return 1.23 + "@" + num.Value.ToString("0.00", CultureInfo.InvariantCulture);
	}

	// Token: 0x06004A38 RID: 19000 RVA: 0x001D6DF8 File Offset: 0x001D4FF8
	internal static void Set(1262 1, double? 2)
	{
		if (1 == null || 1.23 == null)
		{
			return;
		}
		1355.1();
		if (2 != null && !double.IsNaN(2.Value) && !double.IsInfinity(2.Value))
		{
			1355.2[1355.Key(1)] = Math.Max(0.1, Math.Min(3.0, 2.Value));
			return;
		}
		1355.2.Remove(1355.Key(1));
	}

	// Token: 0x1700030C RID: 780
	// (get) Token: 0x06004A39 RID: 19001 RVA: 0x001D6E80 File Offset: 0x001D5080
	private static string FilePath
	{
		get
		{
			return 268.2("nekiosu.gamma.json");
		}
	}

	// Token: 0x06004A3A RID: 19002 RVA: 0x001D6E8C File Offset: 0x001D508C
	private static void 1()
	{
		if (1355.2 != null)
		{
			return;
		}
		1355.2 = new Dictionary<string, double>(StringComparer.Ordinal);
		try
		{
			if (File.Exists(1355.FilePath))
			{
				foreach (222 <<EMPTY_NAME>> in 217.Parse(File.ReadAllText(1355.FilePath, Encoding.UTF8)).Properties())
				{
					double? num = (double?)<<EMPTY_NAME>>.Value;
					if (num != null && !double.IsNaN(num.Value) && !double.IsInfinity(num.Value))
					{
						1355.2[<<EMPTY_NAME>>.Name] = Math.Max(0.1, Math.Min(3.0, num.Value));
					}
				}
			}
		}
		catch (Exception ex)
		{
			1338.4(ex, "reading nekiosu.gamma.json", 1341.Runtime);
		}
	}

	// Token: 0x06004A3B RID: 19003 RVA: 0x001D6F8C File Offset: 0x001D518C
	internal static void Save()
	{
		if (1355.2 == null)
		{
			return;
		}
		try
		{
			217 <<EMPTY_NAME>> = new 217();
			foreach (KeyValuePair<string, double> keyValuePair in 1355.2)
			{
				<<EMPTY_NAME>>[keyValuePair.Key] = keyValuePair.Value;
			}
			byte[] bytes = Encoding.UTF8.GetBytes(<<EMPTY_NAME>>.ToString((95)0, Array.Empty<214>()));
			using (2681 2 = new 2681(1355.FilePath))
			{
				2.Write(bytes, 0, bytes.Length);
			}
		}
		catch (Exception ex)
		{
			1338.4(ex, "saving nekiosu.gamma.json", 1341.Runtime);
		}
	}

	// Token: 0x0400374C RID: 14156
	private const string 1 = "nekiosu.gamma.json";

	// Token: 0x0400374D RID: 14157
	private static Dictionary<string, double> 2;
}
