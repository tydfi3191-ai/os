using System;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Web;

// Token: 0x0200025C RID: 604
public sealed class 404
{
	// Token: 0x0600126E RID: 4718 RVA: 0x000055AC File Offset: 0x000037AC
	private 404()
	{
	}

	// Token: 0x0600126F RID: 4719 RVA: 0x00042270 File Offset: 0x00040470
	private static string Method2780()
	{
		FieldInfo field = typeof(HttpContext).GetField("CallContextSlotName", BindingFlags.Static | BindingFlags.NonPublic);
		if (field != null)
		{
			return (string)field.GetValue(null);
		}
		return "HttpContext";
	}

	// Token: 0x06001270 RID: 4720 RVA: 0x000422AF File Offset: 0x000404AF
	public bool Method2781()
	{
		return this.logicalCallContext != null;
	}

	// Token: 0x06001271 RID: 4721 RVA: 0x000422BA File Offset: 0x000404BA
	public bool Method2782()
	{
		return this.httpContext != null;
	}

	// Token: 0x06001272 RID: 4722 RVA: 0x000422C8 File Offset: 0x000404C8
	public static 404 Method2783(bool 1, bool 2)
	{
		404 3 = new 404();
		if (1 && 404.methodInfo != null)
		{
			3.logicalCallContext = (LogicalCallContext)404.methodInfo.Invoke(Thread.CurrentThread, null);
			if (3.logicalCallContext != null)
			{
				3.logicalCallContext = (LogicalCallContext)3.logicalCallContext.Clone();
			}
		}
		if (2 && HttpContext.Current != null)
		{
			3.httpContext = HttpContext.Current;
		}
		return 3;
	}

	// Token: 0x06001273 RID: 4723 RVA: 0x0004233C File Offset: 0x0004053C
	public static void Method2784(404 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("callerThreadContext");
		}
		if (1.logicalCallContext != null && 404.methodInfo2 != null)
		{
			404.methodInfo2.Invoke(Thread.CurrentThread, new object[]
			{
				1.logicalCallContext
			});
		}
		if (1.httpContext != null)
		{
			HttpContext.Current = 1.httpContext;
		}
	}

	// Token: 0x040008E7 RID: 2279
	private static readonly MethodInfo methodInfo = typeof(Thread).GetMethod("GetLogicalCallContext", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x040008E8 RID: 2280
	private static readonly MethodInfo methodInfo2 = typeof(Thread).GetMethod("SetLogicalCallContext", BindingFlags.Instance | BindingFlags.NonPublic);

	// Token: 0x040008E9 RID: 2281
	private static string text = 404.Method2780();

	// Token: 0x040008EA RID: 2282
	private HttpContext httpContext;

	// Token: 0x040008EB RID: 2283
	private LogicalCallContext logicalCallContext;
}
