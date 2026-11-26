using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

// Token: 0x02000B4E RID: 2894
[ComVisible(false)]
public sealed class 1310
{
	// Token: 0x06004FCB RID: 20427 RVA: 0x001F8A23 File Offset: 0x001F6C23
	private static string 1()
	{
		if (268.DataDirectory == null)
		{
			return Path.Combine(1310.1, 268.9("osu!.cfg"));
		}
		return 268.1("osu!.cfg");
	}

	// Token: 0x06004FCC RID: 20428 RVA: 0x001F8A4C File Offset: 0x001F6C4C
	public static void 2()
	{
		if (1310.2 != null)
		{
			return;
		}
		1310.2 = new Dictionary<string, string>();
		if (!File.Exists(1310.1()))
		{
			return;
		}
		StreamReader streamReader = File.OpenText(1310.1());
		while (!streamReader.EndOfStream)
		{
			string[] array = streamReader.ReadLine().Split(new char[]
			{
				'='
			});
			if (array.Length >= 2)
			{
				1310.2[array[0].Trim()] = array[1].Trim();
			}
		}
		streamReader.Close();
	}

	// Token: 0x06004FCD RID: 20429 RVA: 0x001F8ACC File Offset: 0x001F6CCC
	public static void Save()
	{
		object obj = 1310.3;
		lock (obj)
		{
			1310.2();
			StreamWriter streamWriter = new StreamWriter(1310.1(), false);
			foreach (KeyValuePair<string, string> keyValuePair in 1310.2)
			{
				streamWriter.WriteLine("{0} = {1}", keyValuePair.Key, keyValuePair.Value);
			}
			streamWriter.Close();
		}
	}

	// Token: 0x04003C87 RID: 15495
	public static string 1 = string.Empty;

	// Token: 0x04003C88 RID: 15496
	public static Dictionary<string, string> 2;

	// Token: 0x04003C89 RID: 15497
	public static object 3 = new object();
}
