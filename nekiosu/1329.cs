using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

// Token: 0x02000B28 RID: 2856
[ComVisible(false)]
public static class 1329
{
	// Token: 0x06004F1C RID: 20252 RVA: 0x001F3C44 File Offset: 0x001F1E44
	static 1329()
	{
		try
		{
			1329.3 = new StreamWriter(new FileStream("lockLog.txt", FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read));
			1329.3.BaseStream.Position = 1329.3.BaseStream.Length;
			1329.4 = true;
		}
		catch
		{
			1329.4 = false;
		}
	}

	// Token: 0x06004F1D RID: 20253 RVA: 0x001F3CBC File Offset: 0x001F1EBC
	private static void 1(object 1)
	{
		1329.1331 2 = null;
		try
		{
			object obj = 1329.1;
			lock (obj)
			{
				if (!1329.2.TryGetValue(1, out 2) || 2 == null)
				{
					2 = (1329.2[1] = new 1329.1331(1));
					2.2 = Thread.CurrentThread;
				}
				if (2.2 != Thread.CurrentThread)
				{
					2.1.Add(Thread.CurrentThread);
					1329.3(2);
				}
			}
			Monitor.Enter(1);
		}
		finally
		{
			object obj = 1329.1;
			lock (obj)
			{
				if (2 != null)
				{
					2.1.Remove(Thread.CurrentThread);
				}
			}
		}
	}

	// Token: 0x06004F1E RID: 20254 RVA: 0x001F3DA0 File Offset: 0x001F1FA0
	private static void 2(object 1)
	{
		object obj = 1329.1;
		lock (obj)
		{
			1329.1331 2;
			if (!1329.2.TryGetValue(1, out 2))
			{
				return;
			}
			if (2.1.Count == 0)
			{
				1329.2.Remove(1);
			}
		}
		Monitor.Exit(1);
	}

	// Token: 0x06004F1F RID: 20255 RVA: 0x001F3E0C File Offset: 0x001F200C
	private static void 3(1329.1331 1)
	{
		if (1.4)
		{
			return;
		}
		List<Thread> list = new List<Thread>();
		int index = 0;
		int num = 0;
		if (!1329.5(1, list, ref index, ref num))
		{
			return;
		}
		1.4 = true;
		if (1329.4)
		{
			1329.3.WriteLine("Deadlock detected!");
			int num2 = 1;
			while (index++ < num)
			{
				StackTrace stackTrace = 1329.4(list[index]);
				1329.3.WriteLine("\tStackTrace{0}:\n{1}", num2++, (stackTrace == null) ? string.Empty : stackTrace.ToString().Trim(new char[]
				{
					'\r',
					'\n'
				}).Replace("   ", "\t\t"));
			}
			1329.3.WriteLine();
			1329.3.Flush();
		}
	}

	// Token: 0x06004F20 RID: 20256 RVA: 0x001F3ED8 File Offset: 0x001F20D8
	private static StackTrace 4(Thread 1)
	{
		1329.1332 2 = new 1329.1332();
		2.1 = 1;
		2.2 = new ManualResetEvent(false);
		StackTrace result;
		try
		{
			2.3 = new ManualResetEvent(false);
			try
			{
				Thread thread = new Thread(new ThreadStart(2.1));
				try
				{
					thread.Start();
					2.2.WaitOne();
					2.1.Suspend();
					StackTrace stackTrace = null;
					try
					{
						stackTrace = new StackTrace(2.1, true);
					}
					catch (ThreadStateException)
					{
					}
					try
					{
						2.1.Resume();
					}
					catch (ThreadStateException)
					{
					}
					result = stackTrace;
				}
				finally
				{
					2.3.Set();
					thread.Join();
				}
			}
			finally
			{
				if (2.3 != null)
				{
					((IDisposable)2.3).Dispose();
				}
			}
		}
		finally
		{
			if (2.2 != null)
			{
				((IDisposable)2.2).Dispose();
			}
		}
		return result;
	}

	// Token: 0x06004F21 RID: 20257 RVA: 0x001F3FE0 File Offset: 0x001F21E0
	private static bool 5(1329.1331 1, List<Thread> 2, ref int 3, ref int 4)
	{
		2.Add(1.2);
		if (4 + 2 < 2.Count)
		{
			3++;
			4 += 2;
			if (2[3] == 2[4])
			{
				return true;
			}
		}
		for (int i = 0; i < 1.1.Count; i++)
		{
			foreach (KeyValuePair<object, 1329.1331> keyValuePair in 1329.2)
			{
				if (keyValuePair.Value.2 == 1.1[i] && 1329.5(keyValuePair.Value, 2, ref 3, ref 4))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x04003B1E RID: 15134
	private static object 1 = new object();

	// Token: 0x04003B1F RID: 15135
	private static Dictionary<object, 1329.1331> 2 = new Dictionary<object, 1329.1331>();

	// Token: 0x04003B20 RID: 15136
	private static StreamWriter 3;

	// Token: 0x04003B21 RID: 15137
	private static bool 4;

	// Token: 0x02000B29 RID: 2857
	public sealed class 1330 : IDisposable
	{
		// Token: 0x06004F22 RID: 20258 RVA: 0x001F40AC File Offset: 0x001F22AC
		public 1330(object 1)
		{
			this.1 = 1;
			1329.1(1);
		}

		// Token: 0x06004F23 RID: 20259 RVA: 0x001F40C1 File Offset: 0x001F22C1
		public void Dispose()
		{
			if (this.1 != null)
			{
				1329.2(this.1);
				this.1 = null;
			}
		}

		// Token: 0x04003B22 RID: 15138
		private object 1;
	}

	// Token: 0x02000B2A RID: 2858
	public sealed class 1332
	{
		// Token: 0x06004F24 RID: 20260 RVA: 0x001F40E0 File Offset: 0x001F22E0
		internal void 1()
		{
			this.2.Set();
			while (!this.3.WaitOne(200))
			{
				try
				{
					this.1.Resume();
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x04003B23 RID: 15139
		public Thread 1;

		// Token: 0x04003B24 RID: 15140
		public ManualResetEvent 2;

		// Token: 0x04003B25 RID: 15141
		public ManualResetEvent 3;
	}

	// Token: 0x02000B2B RID: 2859
	public sealed class 1331
	{
		// Token: 0x06004F26 RID: 20262 RVA: 0x001F4130 File Offset: 0x001F2330
		public 1331(object 1)
		{
			this.3 = 1;
		}

		// Token: 0x04003B26 RID: 15142
		public List<Thread> 1 = new List<Thread>();

		// Token: 0x04003B27 RID: 15143
		public Thread 2;

		// Token: 0x04003B28 RID: 15144
		public object 3;

		// Token: 0x04003B29 RID: 15145
		public bool 4;
	}
}
