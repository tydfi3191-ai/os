using System;
using System.IO;

// Token: 0x02000B3A RID: 2874
public static class 1322
{
	// Token: 0x06004F62 RID: 20322 RVA: 0x001F5998 File Offset: 0x001F3B98
	internal static bool 1(string 1, 1322.1323 2, 1189 3, 1189 4 = null)
	{
		string text = 2672.31(1);
		if (!File.Exists(1) && !File.Exists(text))
		{
			return false;
		}
		1322.3();
		if (File.Exists(1))
		{
			if (1322.2(1, 2))
			{
				return true;
			}
			try
			{
				2672.32(1);
			}
			catch
			{
			}
		}
		if (File.Exists(text))
		{
			if (4 != null)
			{
				4();
			}
			if (1322.2(text, 2))
			{
				1338.5("The database " + Path.GetFileName(1) + " was damaged; its last good copy was read instead.", 1341.Runtime, (1114)2);
				return true;
			}
		}
		if (4 != null)
		{
			4();
		}
		if (3 != null)
		{
			3();
		}
		return false;
	}

	// Token: 0x06004F63 RID: 20323 RVA: 0x001F5A40 File Offset: 0x001F3C40
	internal static bool 2(string 1, 1322.1323 2)
	{
		bool result;
		try
		{
			using (Stream stream = File.Open(1, FileMode.Open, FileAccess.Read, FileShare.Read))
			{
				1647 3 = new 1647(stream);
				try
				{
					2(3);
					result = true;
				}
				finally
				{
					((IDisposable)3).Dispose();
				}
			}
		}
		catch (Exception 4)
		{
			1338.4(4, "database file read failure (" + 1 + ")", 1341.Runtime);
			result = false;
		}
		return result;
	}

	// Token: 0x06004F64 RID: 20324 RVA: 0x001F5AC0 File Offset: 0x001F3CC0
	private static bool 3()
	{
		ulong num;
		ulong num2;
		ulong num3;
		1136.GetDiskFreeSpaceEx(Environment.CurrentDirectory, out num, out num2, out num3);
		if (num < 134217728UL)
		{
			1763.5(1568.1(2679.DatabaseHelper_LowDiskSpace), 198.Red, 60000, null);
			return false;
		}
		return true;
	}

	// Token: 0x06004F65 RID: 20325 RVA: 0x001F5B04 File Offset: 0x001F3D04
	internal static bool 4(string 1, 1322.1324 2)
	{
		bool result;
		try
		{
			1322.3();
			2681 3 = new 2681(1);
			try
			{
				1648 4 = new 1648(3);
				try
				{
					2(4);
				}
				catch
				{
					3.2();
					throw;
				}
				finally
				{
					((IDisposable)4).Dispose();
				}
			}
			finally
			{
				((IDisposable)3).Dispose();
			}
			result = 3.Committed;
		}
		catch (Exception 5)
		{
			1338.4(5, "database file write failure (" + 1 + ")", 1341.Runtime);
			result = false;
		}
		return result;
	}

	// Token: 0x02000B3B RID: 2875
	// (Invoke) Token: 0x06004F67 RID: 20327
	public delegate void 1323(1647 1);

	// Token: 0x02000B3C RID: 2876
	// (Invoke) Token: 0x06004F6B RID: 20331
	public delegate void 1324(1648 1);
}
