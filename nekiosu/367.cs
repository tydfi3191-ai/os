using System;
using System.Diagnostics;

// Token: 0x02000256 RID: 598
public sealed class 367
{
	// Token: 0x06001245 RID: 4677 RVA: 0x00041F14 File Offset: 0x00040114
	private 367()
	{
		443[] recoveredType0674Array = new 443[]
		{
			new 443("Active threads", "The current number of available in the thread pool.", PerformanceCounterType.NumberOfItems32),
			new 443("In use threads", "The current number of threads that execute a work item.", PerformanceCounterType.NumberOfItems32),
			new 443("Overhead threads", "The current number of threads that are active, but are not in use.", PerformanceCounterType.NumberOfItems32),
			new 443("% overhead threads", "The current number of threads that are active, but are not in use in percents.", PerformanceCounterType.RawFraction),
			new 443("% overhead threads base", "The current number of threads that are active, but are not in use in percents.", PerformanceCounterType.RawBase),
			new 443("Work Items", "The number of work items in the Smart Thread Pool. Both queued and processed.", PerformanceCounterType.NumberOfItems32),
			new 443("Work Items in queue", "The current number of work items in the queue", PerformanceCounterType.NumberOfItems32),
			new 443("Work Items processed", "The number of work items already processed", PerformanceCounterType.NumberOfItems32),
			new 443("Work Items queued/sec", "The number of work items queued per second", PerformanceCounterType.RateOfCountsPerSecond32),
			new 443("Work Items processed/sec", "The number of work items processed per second", PerformanceCounterType.RateOfCountsPerSecond32),
			new 443("Avg. Work Item wait time/sec", "The average time a work item supends in the queue waiting for its turn to execute.", PerformanceCounterType.AverageCount64),
			new 443("Avg. Work Item wait time base", "The average time a work item supends in the queue waiting for its turn to execute.", PerformanceCounterType.AverageBase),
			new 443("Avg. Work Item process time/sec", "The average time it takes to process a work item.", PerformanceCounterType.AverageCount64),
			new 443("Avg. Work Item process time base", "The average time it takes to process a work item.", PerformanceCounterType.AverageBase),
			new 443("Work Items Groups", "The current number of work item groups associated with the Smart Thread Pool.", PerformanceCounterType.NumberOfItems32)
		};
		this._recoveredType0674Array1208 = recoveredType0674Array;
		this.Method1813();
	}

	// Token: 0x06001246 RID: 4678 RVA: 0x0004209C File Offset: 0x0004029C
	private void Method1813()
	{
		if (!PerformanceCounterCategory.Exists("SmartThreadPool"))
		{
			CounterCreationDataCollection counterCreationDataCollection = new CounterCreationDataCollection();
			for (int i = 0; i < this._recoveredType0674Array1208.Length; i++)
			{
				this._recoveredType0674Array1208[i].Method3764(counterCreationDataCollection);
			}
			PerformanceCounterCategory.Create("SmartThreadPool", "SmartThreadPool performance counters", PerformanceCounterCategoryType.MultiInstance, counterCreationDataCollection);
		}
	}

	// Token: 0x06001247 RID: 4679 RVA: 0x000420EE File Offset: 0x000402EE
	public static 367 GetRecoveredType03201209_1814()
	{
		return 367._recoveredType03201209;
	}

	// Token: 0x040008E2 RID: 2274
	internal 443[] _recoveredType0674Array1208;

	// Token: 0x040008E3 RID: 2275
	private static readonly 367 _recoveredType03201209 = new 367();
}
