using System;
using Microsoft.Win32;

// Token: 0x02000C1C RID: 3100
public static class 1164
{
	// Token: 0x06005428 RID: 21544 RVA: 0x0020BA40 File Offset: 0x00209C40
	public static void 1()
	{
		if (!1164.1)
		{
			bool? flag = 1164.5;
			bool flag2 = false;
			if (!(flag.GetValueOrDefault() == flag2 & flag != null))
			{
				1164.5 = new bool?(false);
				if (1164.3 == null)
				{
					try
					{
						1164.3 = Registry.CurrentUser.OpenSubKey("ControlPanel\\Desktop", true);
						if (1164.3 != null)
						{
							1164.4 = (1164.3.GetValue("ScreenSaveActive").ToString() == "1");
						}
						else
						{
							1164.1 = true;
						}
					}
					catch
					{
						1164.1 = true;
					}
				}
				if (1164.4 && 1164.2)
				{
					if (1164.3 != null)
					{
						1164.3.SetValue("ScreenSaveActive", "0");
					}
					1164.2 = false;
				}
				return;
			}
		}
	}

	// Token: 0x06005429 RID: 21545 RVA: 0x0020BB14 File Offset: 0x00209D14
	public static void 2()
	{
		if (1164.1 || 1164.5.GetValueOrDefault())
		{
			return;
		}
		1164.5 = new bool?(true);
		if (1164.4 && !1164.2)
		{
			if (1164.3 != null)
			{
				1164.3.SetValue("ScreenSaveActive", "1");
			}
			1164.2 = true;
		}
	}

	// Token: 0x0400403E RID: 16446
	private static bool 1;

	// Token: 0x0400403F RID: 16447
	private static bool 2;

	// Token: 0x04004040 RID: 16448
	private static RegistryKey 3;

	// Token: 0x04004041 RID: 16449
	private static bool 4;

	// Token: 0x04004042 RID: 16450
	private static bool? 5;
}
