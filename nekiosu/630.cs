using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02000176 RID: 374
[ComVisible(false)]
public sealed class 630 : 665
{
	// Token: 0x06000C74 RID: 3188 RVA: 0x0002CA45 File Offset: 0x0002AC45
	[CompilerGenerated]
	public TraceLevel GetLevelFilter()
	{
		return this.traceLevel2;
	}

	// Token: 0x06000C75 RID: 3189 RVA: 0x0002CA4D File Offset: 0x0002AC4D
	public void SetTraceLevel7238_9271(TraceLevel 1)
	{
		this.traceLevel2 = 1;
	}

	// Token: 0x06000C76 RID: 3190 RVA: 0x0002CA58 File Offset: 0x0002AC58
	private TraceEventType Method9272(TraceLevel 1)
	{
		TraceEventType result;
		switch (1)
		{
		case TraceLevel.Error:
			result = TraceEventType.Error;
			break;
		case TraceLevel.Warning:
			result = TraceEventType.Warning;
			break;
		case TraceLevel.Info:
			result = TraceEventType.Information;
			break;
		case TraceLevel.Verbose:
			result = TraceEventType.Verbose;
			break;
		default:
			throw new ArgumentOutOfRangeException("#=zsQQ_ZcE=");
		}
		return result;
	}

	// Token: 0x06000C77 RID: 3191 RVA: 0x0002CA9C File Offset: 0x0002AC9C
	[242(1)]
	public void WriteTrace(TraceLevel 1, string 2, [241(2)] Exception 3)
	{
		if (1 == TraceLevel.Off)
		{
			return;
		}
		TraceEventCache eventCache = new TraceEventCache();
		TraceEventType eventType = this.Method9272(1);
		foreach (object obj in Trace.Listeners)
		{
			TraceListener traceListener = (TraceListener)obj;
			if (!traceListener.IsThreadSafe)
			{
				TraceListener obj2 = traceListener;
				lock (obj2)
				{
					traceListener.TraceEvent(eventCache, "Newtonsoft.Json", eventType, 0, 2);
					goto IL_6E;
				}
				goto IL_5F;
			}
			goto IL_5F;
			IL_6E:
			if (Trace.AutoFlush)
			{
				traceListener.Flush();
				continue;
			}
			continue;
			IL_5F:
			traceListener.TraceEvent(eventCache, "Newtonsoft.Json", eventType, 0, 2);
			goto IL_6E;
		}
	}

	// Token: 0x04000614 RID: 1556
	private TraceLevel traceLevel2;
}
