using System;
using System.Diagnostics;

// Token: 0x02000255 RID: 597
public class 278 : IDisposable
{
	// Token: 0x0600123C RID: 4668 RVA: 0x00041E2E File Offset: 0x0004002E
	protected 278()
	{
		this.disposed = false;
	}

	// Token: 0x0600123D RID: 4669 RVA: 0x00041E40 File Offset: 0x00040040
	public 278(string 1, 389 2) : this()
	{
		367 recoveredType03201209_ = 367.GetRecoveredType03201209_1814();
		this.performanceCounter = new PerformanceCounter("SmartThreadPool", recoveredType03201209_._recoveredType0674Array1208[(int)2].GetText2953_3765(), 1, false);
		this.performanceCounter.RawValue = this.performanceCounter.RawValue;
	}

	// Token: 0x0600123E RID: 4670 RVA: 0x00041E8E File Offset: 0x0004008E
	public void Close()
	{
		if (this.performanceCounter != null)
		{
			this.performanceCounter.RemoveInstance();
			this.performanceCounter.Close();
			this.performanceCounter = null;
		}
	}

	// Token: 0x0600123F RID: 4671 RVA: 0x00041EB5 File Offset: 0x000400B5
	public void Dispose()
	{
		this.Method10635(true);
	}

	// Token: 0x06001240 RID: 4672 RVA: 0x00041EBE File Offset: 0x000400BE
	public virtual void Method10635(bool 1)
	{
		if (!this.disposed && 1)
		{
			this.Close();
		}
		this.disposed = true;
	}

	// Token: 0x06001241 RID: 4673 RVA: 0x00041EDA File Offset: 0x000400DA
	public virtual void Increment()
	{
		this.performanceCounter.Increment();
	}

	// Token: 0x06001242 RID: 4674 RVA: 0x00041EE8 File Offset: 0x000400E8
	public virtual void IncrementBy(long 1)
	{
		this.performanceCounter.IncrementBy(1);
	}

	// Token: 0x06001243 RID: 4675 RVA: 0x00041EF7 File Offset: 0x000400F7
	public virtual void Set(long 1)
	{
		this.performanceCounter.RawValue = 1;
	}

	// Token: 0x040008E0 RID: 2272
	private bool disposed;

	// Token: 0x040008E1 RID: 2273
	private PerformanceCounter performanceCounter;
}
