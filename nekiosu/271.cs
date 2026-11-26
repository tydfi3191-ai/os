using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x020003E5 RID: 997
internal static class 271
{
	// Token: 0x17000223 RID: 547
	// (get) Token: 0x06001F74 RID: 8052 RVA: 0x0007CFE6 File Offset: 0x0007B1E6
	// (set) Token: 0x06001F75 RID: 8053 RVA: 0x0007CFEF File Offset: 0x0007B1EF
	internal static string Stage
	{
		get
		{
			return 271.6;
		}
		set
		{
			271.6 = (value ?? string.Empty);
		}
	}

	// Token: 0x17000224 RID: 548
	// (get) Token: 0x06001F76 RID: 8054 RVA: 0x0007D002 File Offset: 0x0007B202
	// (set) Token: 0x06001F77 RID: 8055 RVA: 0x0007D00B File Offset: 0x0007B20B
	internal static string BackgroundStage
	{
		get
		{
			return 271.7;
		}
		set
		{
			271.7 = (value ?? string.Empty);
		}
	}

	// Token: 0x06001F78 RID: 8056 RVA: 0x0007D020 File Offset: 0x0007B220
	internal static void Start()
	{
		if (271.8)
		{
			return;
		}
		271.8 = true;
		271.5 = Thread.CurrentThread;
		271.1();
		ThreadStart start;
		if ((start = 271.<>O.<0>__Watch) == null)
		{
			start = (271.<>O.<0>__Watch = new ThreadStart(271.5));
		}
		new Thread(start)
		{
			IsBackground = true,
			Name = "nekiosu watchdog",
			Priority = ThreadPriority.BelowNormal
		}.Start();
	}

	// Token: 0x06001F79 RID: 8057 RVA: 0x0007D088 File Offset: 0x0007B288
	internal static void 1()
	{
		Interlocked.Exchange(ref 271.4, 271.3.ElapsedMilliseconds);
	}

	// Token: 0x06001F7A RID: 8058 RVA: 0x0007D09F File Offset: 0x0007B29F
	internal static void 2(string 1)
	{
		if (Thread.CurrentThread == 271.5)
		{
			271.Stage = 1;
			return;
		}
		271.BackgroundStage = 1;
	}

	// Token: 0x06001F7B RID: 8059 RVA: 0x0007D0BA File Offset: 0x0007B2BA
	internal static void 3(string 1)
	{
		if (Thread.CurrentThread == 271.5)
		{
			271.Stage = 1;
			return;
		}
		271.BackgroundStage = "idle";
	}

	// Token: 0x06001F7C RID: 8060 RVA: 0x0007D0D9 File Offset: 0x0007B2D9
	internal static void 4(string 1)
	{
		1338.5("Runtime: " + 1, 1341.Runtime, (1114)2);
	}

	// Token: 0x06001F7D RID: 8061 RVA: 0x0007D0F0 File Offset: 0x0007B2F0
	private static void 5()
	{
		bool flag = false;
		bool flag2 = false;
		long num = 0L;
		for (;;)
		{
			Thread.Sleep(1000);
			long elapsedMilliseconds = 271.3.ElapsedMilliseconds;
			long num2 = elapsedMilliseconds - Interlocked.Read(ref 271.4);
			if (num2 < 5000L)
			{
				if (flag)
				{
					271.4(string.Concat(new string[]
					{
						"the game responds again after a ",
						((double)(elapsedMilliseconds - num) / 1000.0).ToString("0.0"),
						" s stall (step: ",
						271.6,
						")."
					}));
				}
				flag = false;
				flag2 = false;
			}
			else
			{
				if (!flag)
				{
					flag = true;
					num = elapsedMilliseconds - num2;
					271.4(string.Concat(new string[]
					{
						"no frame for ",
						(num2 / 1000L).ToString(),
						" s. Screen: ",
						1662.78.ToString(),
						". Step: ",
						271.6,
						". Background: ",
						271.7,
						"."
					}));
				}
				else if (num2 / 1000L % 15L == 0L)
				{
					271.4(string.Concat(new string[]
					{
						"still no frame after ",
						(num2 / 1000L).ToString(),
						" s. Step: ",
						271.6,
						". Background: ",
						271.7,
						"."
					}));
				}
				if (!flag2 && num2 >= 10000L)
				{
					flag2 = true;
					271.4("main thread stack while stuck:\n" + 271.6());
				}
			}
		}
	}

	// Token: 0x06001F7E RID: 8062 RVA: 0x0007D2A4 File Offset: 0x0007B4A4
	private static string 6()
	{
		Thread thread = 271.5;
		if (thread == null)
		{
			return "(unknown)";
		}
		StackTrace stackTrace = null;
		bool flag = false;
		try
		{
			thread.Suspend();
			flag = true;
			stackTrace = new StackTrace(thread, false);
		}
		catch (Exception ex)
		{
			return "(could not be read: " + ex.Message + ")";
		}
		finally
		{
			if (flag)
			{
				try
				{
					thread.Resume();
				}
				catch (Exception)
				{
				}
			}
		}
		return stackTrace.ToString();
	}

	// Token: 0x04001042 RID: 4162
	private const int 1 = 5000;

	// Token: 0x04001043 RID: 4163
	private const int 2 = 10000;

	// Token: 0x04001044 RID: 4164
	private static readonly Stopwatch 3 = Stopwatch.StartNew();

	// Token: 0x04001045 RID: 4165
	private static long 4;

	// Token: 0x04001046 RID: 4166
	private static Thread 5;

	// Token: 0x04001047 RID: 4167
	private static volatile string 6 = "starting";

	// Token: 0x04001048 RID: 4168
	private static volatile string 7 = "idle";

	// Token: 0x04001049 RID: 4169
	private static bool 8;

	// Token: 0x020003E6 RID: 998
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0400104A RID: 4170
		public static ThreadStart <0>__Watch;
	}
}
