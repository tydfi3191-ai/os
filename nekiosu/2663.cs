using System;
using System.Runtime.InteropServices;
using System.Threading;

// Token: 0x0200044B RID: 1099
[ComVisible(false)]
public sealed class 2663 : 2662
{
	// Token: 0x060021F5 RID: 8693 RVA: 0x00092714 File Offset: 0x00090914
	public 2663(int 1 = 50)
	{
		2663.2664 threadedSchedulerClosure = new 2663.2664
		{
			2 = 1
		};
		threadedSchedulerClosure.1 = this;
		this.thread = new Thread(delegate()
		{
			while (!threadedSchedulerClosure.1.stopRequested)
			{
				try
				{
					threadedSchedulerClosure.1.1();
				}
				catch
				{
				}
				Thread.Sleep(threadedSchedulerClosure.2);
			}
		})
		{
			IsBackground = true
		};
		this.thread.Start();
	}

	// Token: 0x060021F6 RID: 8694 RVA: 0x00092774 File Offset: 0x00090974
	protected override void Dispose(bool 1)
	{
		this.stopRequested = true;
		base.Dispose(1);
	}

	// Token: 0x060021F7 RID: 8695 RVA: 0x0000FF75 File Offset: 0x0000E175
	protected override bool IsOnOwnerThread()
	{
		return false;
	}

	// Token: 0x04001758 RID: 5976
	private Thread thread;

	// Token: 0x04001759 RID: 5977
	private bool stopRequested;

	// Token: 0x0200044C RID: 1100
	public sealed class 2664
	{
		// Token: 0x0400175A RID: 5978
		public 2663 1;

		// Token: 0x0400175B RID: 5979
		public int 2;
	}
}
