using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x02000C27 RID: 3111
public static class 1175
{
	// Token: 0x0600543D RID: 21565 RVA: 0x0020BB90 File Offset: 0x00209D90
	static 1175()
	{
		OperatingSystem osversion = Environment.OSVersion;
		1175.1 = (osversion.Platform == PlatformID.Win32NT && osversion.Version >= new Version(6, 0));
		if (1175.1())
		{
			try
			{
				1175.2 = 1175.3(osversion);
			}
			catch
			{
				1175.2 = false;
			}
		}
	}

	// Token: 0x0600543E RID: 21566 RVA: 0x0020BBF4 File Offset: 0x00209DF4
	public static bool 1()
	{
		return 1175.1;
	}

	// Token: 0x0600543F RID: 21567 RVA: 0x0020BBFB File Offset: 0x00209DFB
	public static bool 2()
	{
		return 1175.2;
	}

	// Token: 0x06005440 RID: 21568 RVA: 0x0020BC02 File Offset: 0x00209E02
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool 3(OperatingSystem 1)
	{
		return 1.Platform != PlatformID.Win32NT || !(1.Version < new Version(6, 2, 9200)) || Process.GetCurrentProcess().SessionId != 0;
	}

	// Token: 0x04004053 RID: 16467
	private static readonly bool 1;

	// Token: 0x04004054 RID: 16468
	private static readonly bool 2;
}
