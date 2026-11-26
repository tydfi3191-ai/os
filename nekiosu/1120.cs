using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.Win32;

// Token: 0x02000BEA RID: 3050
[ComVisible(false)]
public static class 1120
{
	// Token: 0x0600535C RID: 21340 RVA: 0x0020AA84 File Offset: 0x00208C84
	public static List<1121> 1(bool 1)
	{
		if (1120.1 == null || !1)
		{
			List<1121> list = new List<1121>();
			using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\"))
			{
				foreach (string text in registryKey.GetSubKeyNames())
				{
					if (text.StartsWith("v"))
					{
						RegistryKey registryKey2 = registryKey.OpenSubKey(text);
						string text2 = (string)registryKey2.GetValue("Version", string.Empty);
						string a = registryKey2.GetValue("SP", string.Empty).ToString();
						string a2 = registryKey2.GetValue("Install", string.Empty).ToString();
						if (a2 != string.Empty)
						{
							if (a != string.Empty && a2 == "1")
							{
								if (text.StartsWith("v3.0"))
								{
									list.Add(1121.dotnet30);
								}
								else if (text.StartsWith("v3.5"))
								{
									list.Add(1121.dotnet35);
								}
							}
						}
						else
						{
							foreach (string name in registryKey2.GetSubKeyNames())
							{
								RegistryKey registryKey3 = registryKey2.OpenSubKey(name);
								text2 = (string)registryKey3.GetValue("Version", string.Empty);
								a2 = registryKey3.GetValue("Install", string.Empty).ToString();
								if (a2 == "1")
								{
									if (text2.StartsWith("4.5") || text2.StartsWith("4.6"))
									{
										list.Add(1121.dotnet45);
									}
									else if (text2.StartsWith("4"))
									{
										list.Add(1121.dotnet4);
									}
								}
							}
						}
					}
				}
			}
			1120.1 = list;
		}
		return 1120.1;
	}

	// Token: 0x0600535D RID: 21341 RVA: 0x0020AC78 File Offset: 0x00208E78
	public static bool 2(1121 1, bool 2)
	{
		return 1120.1(2).Contains(1);
	}

	// Token: 0x04003F56 RID: 16214
	private static List<1121> 1;
}
