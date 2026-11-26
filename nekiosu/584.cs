using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;

// Token: 0x0200029E RID: 670
[ComVisible(false)]
[SuppressUnmanagedCodeSecurity]
public sealed class 584
{
	// Token: 0x0600145D RID: 5213 RVA: 0x00046D40 File Offset: 0x00044F40
	public 584()
	{
		if (!584.QueryPerformanceFrequency(out this.number2))
		{
			throw new Win32Exception();
		}
	}

	// Token: 0x0600145E RID: 5214
	[DllImport("kernel32.dll")]
	private static extern bool QueryPerformanceCounter(out long 1);

	// Token: 0x0600145F RID: 5215
	[DllImport("kernel32.dll")]
	private static extern bool QueryPerformanceFrequency(out long 1);

	// Token: 0x06001460 RID: 5216 RVA: 0x00046D5B File Offset: 0x00044F5B
	public void Method7949()
	{
		Thread.Sleep(0);
		584.QueryPerformanceCounter(out this.number3);
	}

	// Token: 0x06001461 RID: 5217 RVA: 0x00046D6F File Offset: 0x00044F6F
	public void Method7950()
	{
		584.QueryPerformanceCounter(out this.number4);
	}

	// Token: 0x06001462 RID: 5218 RVA: 0x00046D7D File Offset: 0x00044F7D
	public double Method7951()
	{
		return (double)(this.number4 - this.number3) / (double)this.number2;
	}

	// Token: 0x04000995 RID: 2453
	private long number2;

	// Token: 0x04000996 RID: 2454
	private long number3;

	// Token: 0x04000997 RID: 2455
	private long number4;
}
