using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

// Token: 0x02000BAF RID: 2991
internal static class 1242
{
	// Token: 0x1700031B RID: 795
	// (get) Token: 0x06005264 RID: 21092 RVA: 0x00206D24 File Offset: 0x00204F24
	internal static int Current
	{
		get
		{
			1262 <<EMPTY_NAME>> = 1272.5();
			if (<<EMPTY_NAME>> != 1242.5)
			{
				1242.5 = <<EMPTY_NAME>>;
				1242.6 = 1242.Get(<<EMPTY_NAME>>);
			}
			return 1242.6;
		}
	}

	// Token: 0x06005265 RID: 21093 RVA: 0x00206D58 File Offset: 0x00204F58
	internal static int Get(1262 1)
	{
		if (1 == null || 1.23 == null)
		{
			return 100;
		}
		1242.1();
		int result;
		if (!1242.4.TryGetValue(1.23, out result))
		{
			return 100;
		}
		return result;
	}

	// Token: 0x06005266 RID: 21094 RVA: 0x00206D90 File Offset: 0x00204F90
	internal static void Set(1262 1, int 2)
	{
		if (1 == null || 1.23 == null)
		{
			return;
		}
		1242.1();
		2 = Math.Max(0, Math.Min(300, 2));
		if (2 == 100)
		{
			1242.4.Remove(1.23);
		}
		else
		{
			1242.4[1.23] = 2;
		}
		if (1 == 1242.5)
		{
			1242.6 = 2;
		}
	}

	// Token: 0x1700031C RID: 796
	// (get) Token: 0x06005267 RID: 21095 RVA: 0x00206DF8 File Offset: 0x00204FF8
	private static string FilePath
	{
		get
		{
			return 268.2("nekiosu.hitsounds.json");
		}
	}

	// Token: 0x06005268 RID: 21096 RVA: 0x00206E04 File Offset: 0x00205004
	private static void 1()
	{
		if (1242.4 != null)
		{
			return;
		}
		1242.4 = new Dictionary<string, int>(StringComparer.Ordinal);
		try
		{
			if (File.Exists(1242.FilePath))
			{
				foreach (222 <<EMPTY_NAME>> in 217.Parse(File.ReadAllText(1242.FilePath, Encoding.UTF8)).Properties())
				{
					int? num = (int?)<<EMPTY_NAME>>.Value;
					if (num != null)
					{
						1242.4[<<EMPTY_NAME>>.Name] = Math.Max(0, Math.Min(300, num.Value));
					}
				}
			}
		}
		catch (Exception ex)
		{
			1338.4(ex, "reading nekiosu.hitsounds.json", 1341.Runtime);
		}
	}

	// Token: 0x06005269 RID: 21097 RVA: 0x00206EDC File Offset: 0x002050DC
	internal static void Save()
	{
		if (1242.4 == null)
		{
			return;
		}
		try
		{
			217 <<EMPTY_NAME>> = new 217();
			foreach (KeyValuePair<string, int> keyValuePair in 1242.4)
			{
				<<EMPTY_NAME>>[keyValuePair.Key] = keyValuePair.Value;
			}
			byte[] bytes = Encoding.UTF8.GetBytes(<<EMPTY_NAME>>.ToString((95)0, Array.Empty<214>()));
			using (2681 2 = new 2681(1242.FilePath))
			{
				2.Write(bytes, 0, bytes.Length);
			}
		}
		catch (Exception ex)
		{
			1338.4(ex, "saving nekiosu.hitsounds.json", 1341.Runtime);
		}
	}

	// Token: 0x04003EB7 RID: 16055
	private const string 1 = "nekiosu.hitsounds.json";

	// Token: 0x04003EB8 RID: 16056
	internal const int 2 = 0;

	// Token: 0x04003EB9 RID: 16057
	internal const int 3 = 300;

	// Token: 0x04003EBA RID: 16058
	private static Dictionary<string, int> 4;

	// Token: 0x04003EBB RID: 16059
	private static 1262 5;

	// Token: 0x04003EBC RID: 16060
	private static int 6 = 100;
}
