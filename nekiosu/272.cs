using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

// Token: 0x020003E7 RID: 999
internal static class 272
{
	// Token: 0x06001F80 RID: 8064 RVA: 0x0007D354 File Offset: 0x0007B554
	internal static bool 1(string 1, int 2)
	{
		bool result;
		try
		{
			272.5 = 1;
			bool flag;
			272.3 = new Mutex(true, 272.7(1), ref flag);
			if (flag || 272.2(2) || (272.4(1) && 272.2(60000)))
			{
				result = true;
			}
			else
			{
				272.3.Dispose();
				272.3 = null;
				result = false;
			}
		}
		catch (Exception)
		{
			result = true;
		}
		return result;
	}

	// Token: 0x06001F81 RID: 8065 RVA: 0x0007D3C8 File Offset: 0x0007B5C8
	private static bool 2(int 1)
	{
		bool result;
		try
		{
			result = 272.3.WaitOne(1);
		}
		catch (AbandonedMutexException)
		{
			result = true;
		}
		return result;
	}

	// Token: 0x06001F82 RID: 8066 RVA: 0x0007D3FC File Offset: 0x0007B5FC
	internal static void 3()
	{
		try
		{
			if (272.4 == null && 272.5 != null)
			{
				272.4 = new EventWaitHandle(true, EventResetMode.ManualReset, 272.7(272.5) + "-closing");
				272.4.Set();
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06001F83 RID: 8067 RVA: 0x0007D458 File Offset: 0x0007B658
	private static bool 4(string 1)
	{
		try
		{
			EventWaitHandle eventWaitHandle;
			if (EventWaitHandle.TryOpenExisting(272.7(1) + "-closing", out eventWaitHandle))
			{
				using (eventWaitHandle)
				{
					return eventWaitHandle.WaitOne(0);
				}
			}
		}
		catch (Exception)
		{
		}
		return false;
	}

	// Token: 0x06001F84 RID: 8068 RVA: 0x0007D4B8 File Offset: 0x0007B6B8
	internal static void 5()
	{
		try
		{
			Mutex mutex = 272.3;
			if (mutex != null)
			{
				mutex.ReleaseMutex();
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06001F85 RID: 8069 RVA: 0x0007D4EC File Offset: 0x0007B6EC
	internal static void 6()
	{
		try
		{
			using (Process currentProcess = Process.GetCurrentProcess())
			{
				string fileName = currentProcess.MainModule.FileName;
				foreach (Process process in Process.GetProcessesByName(currentProcess.ProcessName))
				{
					using (process)
					{
						try
						{
							if (process.Id != currentProcess.Id && string.Equals(process.MainModule.FileName, fileName, StringComparison.OrdinalIgnoreCase))
							{
								IntPtr mainWindowHandle = process.MainWindowHandle;
								if (!(mainWindowHandle == IntPtr.Zero))
								{
									if (272.IsIconic(mainWindowHandle))
									{
										272.ShowWindow(mainWindowHandle, 9);
									}
									272.SetForegroundWindow(mainWindowHandle);
									break;
								}
							}
						}
						catch (Exception)
						{
						}
					}
				}
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06001F86 RID: 8070 RVA: 0x0007D5E0 File Offset: 0x0007B7E0
	private static string 7(string 1)
	{
		string result;
		using (SHA1 sha = SHA1.Create())
		{
			byte[] value = sha.ComputeHash(Encoding.UTF8.GetBytes((1 ?? string.Empty).TrimEnd(new char[]
			{
				'\\',
				'/'
			}).ToLowerInvariant()));
			result = "Local\\nekiosu-" + BitConverter.ToString(value, 0, 8).Replace("-", string.Empty);
		}
		return result;
	}

	// Token: 0x06001F87 RID: 8071
	[DllImport("user32.dll")]
	private static extern bool SetForegroundWindow(IntPtr 1);

	// Token: 0x06001F88 RID: 8072
	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr 1, int 2);

	// Token: 0x06001F89 RID: 8073
	[DllImport("user32.dll")]
	private static extern bool IsIconic(IntPtr 1);

	// Token: 0x0400104B RID: 4171
	internal const int 1 = 1000;

	// Token: 0x0400104C RID: 4172
	private const int 2 = 60000;

	// Token: 0x0400104D RID: 4173
	private static Mutex 3;

	// Token: 0x0400104E RID: 4174
	private static EventWaitHandle 4;

	// Token: 0x0400104F RID: 4175
	private static string 5;
}
