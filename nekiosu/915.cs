using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Threading;

// Token: 0x0200027C RID: 636
public sealed class 915 : 970, IDisposable
{
	// Token: 0x0600135B RID: 4955 RVA: 0x00043D68 File Offset: 0x00041F68
	public 915()
	{
		this.startInfo = new 897();
		this.InitializeFromStartInfo();
	}

	// Token: 0x0600135C RID: 4956 RVA: 0x00043DE8 File Offset: 0x00041FE8
	public 915(int 1)
	{
		897 2 = new 897();
		2.SetIdleTimeout(1);
		this.startInfo = 2;
		this.InitializeFromStartInfo();
	}

	// Token: 0x0600135D RID: 4957 RVA: 0x00043E70 File Offset: 0x00042070
	public 915(bool 1)
	{
		897 2 = new 897();
		2.Method7499(1);
		this.startInfo = 2;
		this.InitializeFromStartInfo();
	}

	// Token: 0x0600135E RID: 4958 RVA: 0x00043EF8 File Offset: 0x000420F8
	public 915(int 1, int 2)
	{
		897 3 = new 897();
		3.SetIdleTimeout(1);
		3.SetMaxWorkerThreads(2);
		this.startInfo = 3;
		this.InitializeFromStartInfo();
	}

	// Token: 0x0600135F RID: 4959 RVA: 0x00043F88 File Offset: 0x00042188
	public 915(int 1, int 2, int 3)
	{
		897 4 = new 897();
		4.SetIdleTimeout(1);
		4.SetMaxWorkerThreads(2);
		4.SetMinWorkerThreads(3);
		this.startInfo = 4;
		this.InitializeFromStartInfo();
	}

	// Token: 0x06001360 RID: 4960 RVA: 0x00044020 File Offset: 0x00042220
	public 915(897 1)
	{
		this.startInfo = new 897(1);
		this.InitializeFromStartInfo();
	}

	// Token: 0x06001361 RID: 4961 RVA: 0x000440A0 File Offset: 0x000422A0
	private void AddThreadInitializationCallback(808 1)
	{
		808 2 = this.threadInitialization;
		808 3;
		do
		{
			3 = 2;
			808 value = (808)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<808>(ref this.threadInitialization, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06001362 RID: 4962 RVA: 0x000440D8 File Offset: 0x000422D8
	private void RemoveThreadInitializationCallback(808 1)
	{
		808 2 = this.threadInitialization;
		808 3;
		do
		{
			3 = 2;
			808 value = (808)Delegate.Remove(3, 1);
			2 = Interlocked.CompareExchange<808>(ref this.threadInitialization, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06001363 RID: 4963 RVA: 0x00044110 File Offset: 0x00042310
	private void AddThreadTerminationCallback(732 1)
	{
		732 2 = this.threadTermination;
		732 3;
		do
		{
			3 = 2;
			732 value = (732)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<732>(ref this.threadTermination, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06001364 RID: 4964 RVA: 0x00044148 File Offset: 0x00042348
	private void RemoveThreadTerminationCallback(732 1)
	{
		732 2 = this.threadTermination;
		732 3;
		do
		{
			3 = 2;
			732 value = (732)Delegate.Remove(3, 1);
			2 = Interlocked.CompareExchange<732>(ref this.threadTermination, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06001365 RID: 4965 RVA: 0x0004417D File Offset: 0x0004237D
	internal static 915.921 GetCurrentWorkerThreadInfo()
	{
		return 915.currentWorkerThreadInfo;
	}

	// Token: 0x06001366 RID: 4966 RVA: 0x00044184 File Offset: 0x00042384
	internal static void SetCurrentWorkerThreadInfo(915.921 1)
	{
		915.currentWorkerThreadInfo = 1;
	}

	// Token: 0x06001367 RID: 4967 RVA: 0x0004418C File Offset: 0x0004238C
	private void InitializeFromStartInfo()
	{
		base.SetName(this.startInfo.GetText7312_9337());
		this.ValidateStartInfo();
		this.isSuspended = this.startInfo.GetFlag5792_7498();
		if (this.startInfo.GetText7309_9339() != null)
		{
			try
			{
				this.performanceCounters = new 428(this.startInfo.GetText7309_9339());
			}
			catch (Exception)
			{
				this.performanceCounters = 394.GetRecoveredType04451947_2474();
			}
		}
		if (this.startInfo.GetFlag7311_9341())
		{
			this.localPerformanceCounters = new 596();
		}
		if (!this.isSuspended)
		{
			this.EnsureMinimumThreads();
		}
	}

	// Token: 0x06001368 RID: 4968 RVA: 0x0004422C File Offset: 0x0004242C
	private void EnsureMinimumThreads()
	{
		int num = Math.Max(this.workItemsQueue.GetWorkItemsCount(), this.startInfo.GetMinWorkerThreads());
		num = Math.Min(num, this.startInfo.GetMaxWorkerThreads());
		num -= this.workerThreads.Method11338();
		if (num > 0)
		{
			this.StartWorkerThreads(num);
		}
	}

	// Token: 0x06001369 RID: 4969 RVA: 0x00044280 File Offset: 0x00042480
	private void ValidateStartInfo()
	{
		if (this.startInfo.GetMinWorkerThreads() < 0)
		{
			throw new ArgumentOutOfRangeException("MinWorkerThreads", "MinWorkerThreads cannot be negative");
		}
		if (this.startInfo.GetMaxWorkerThreads() <= 0)
		{
			throw new ArgumentOutOfRangeException("MaxWorkerThreads", "MaxWorkerThreads must be greater than zero");
		}
		if (this.startInfo.GetMinWorkerThreads() > this.startInfo.GetMaxWorkerThreads())
		{
			throw new ArgumentOutOfRangeException("MinWorkerThreads, maxWorkerThreads", "MaxWorkerThreads must be greater or equal to MinWorkerThreads");
		}
		int? nullable7314_ = this.startInfo.GetNullable7314_9345();
		int num = 0;
		if (nullable7314_.GetValueOrDefault() < num & nullable7314_ != null)
		{
			throw new ArgumentOutOfRangeException("MaxQueueLength", "MaxQueueLength must be >= 0 or null (for unbounded)");
		}
	}

	// Token: 0x0600136A RID: 4970 RVA: 0x00044323 File Offset: 0x00042523
	private static void ThrowIfMulticastDelegate(Delegate 1)
	{
		if (1.GetInvocationList().Length > 1)
		{
			throw new NotSupportedException("SmartThreadPool doesn't support delegates chains");
		}
	}

	// Token: 0x0600136B RID: 4971 RVA: 0x0004433B File Offset: 0x0004253B
	private 802 DequeueWorkItem()
	{
		return this.workItemsQueue.DequeueWorkItem(this.startInfo.GetIdleTimeout(), this.shutdownEvent);
	}

	// Token: 0x0600136C RID: 4972 RVA: 0x0004435C File Offset: 0x0004255C
	internal override void Enqueue(802 1)
	{
		this.OnWorkItemQueued();
		1.SetRecoveredType089410412_13460(this.cancellation);
		this.workItemsQueue.EnqueueWorkItem(1);
		1.Method13476();
		if (this.currentWorkItemsCount > this.workerThreads.Method11338())
		{
			this.StartWorkerThreads(1);
		}
	}

	// Token: 0x0600136D RID: 4973 RVA: 0x000443AC File Offset: 0x000425AC
	private void OnWorkItemQueued()
	{
		this.performanceCounters.Method8127((long)this.workItemsQueue.GetWorkItemsCount(), (long)this.workItemsExecuted);
		this.localPerformanceCounters.Method8127((long)this.workItemsQueue.GetWorkItemsCount(), (long)this.workItemsExecuted);
		if (Interlocked.Increment(ref this.currentWorkItemsCount) == 1)
		{
			base.SetFlag2902_3661(false);
			this.idleEvent.Reset();
		}
	}

	// Token: 0x0600136E RID: 4974 RVA: 0x00044418 File Offset: 0x00042618
	private void OnWorkItemCompleted()
	{
		if (Interlocked.Decrement(ref this.currentWorkItemsCount) == 0)
		{
			base.SetFlag2902_3661(true);
			this.idleEvent.Set();
		}
		Interlocked.Increment(ref this.workItemsExecuted);
		if (!this.isShuttingDown)
		{
			this.performanceCounters.Method8127((long)this.workItemsQueue.GetWorkItemsCount(), (long)this.workItemsExecuted);
			this.localPerformanceCounters.Method8127((long)this.workItemsQueue.GetWorkItemsCount(), (long)this.workItemsExecuted);
		}
	}

	// Token: 0x0600136F RID: 4975 RVA: 0x00044495 File Offset: 0x00042695
	internal void RegisterWorkItemsGroup(103 1)
	{
		this.workItemsGroups[1] = 1;
	}

	// Token: 0x06001370 RID: 4976 RVA: 0x000444A4 File Offset: 0x000426A4
	internal void UnregisterWorkItemsGroup(103 1)
	{
		if (this.workItemsGroups.Method11339(1))
		{
			this.workItemsGroups.Method11340(1);
		}
	}

	// Token: 0x06001371 RID: 4977 RVA: 0x000444C0 File Offset: 0x000426C0
	private void OnWorkerThreadExit()
	{
		if (this.workerThreads.Method11339(Thread.CurrentThread))
		{
			this.workerThreads.Method11340(Thread.CurrentThread);
			this.performanceCounters.Method8126((long)this.workerThreads.Method11338(), (long)this.inUseThreads);
			this.localPerformanceCounters.Method8126((long)this.workerThreads.Method11338(), (long)this.inUseThreads);
		}
	}

	// Token: 0x06001372 RID: 4978 RVA: 0x0004452C File Offset: 0x0004272C
	private void StartWorkerThreads(int 1)
	{
		if (this.isSuspended)
		{
			return;
		}
		object value9006_ = this.workerThreads.GetValue9006_11341();
		lock (value9006_)
		{
			if (!this.isShuttingDown)
			{
				for (int i = 0; i < 1; i++)
				{
					if (this.workerThreads.Method11338() >= this.startInfo.GetMaxWorkerThreads())
					{
						break;
					}
					Thread thread = (this.startInfo.GetNullable7313_9350() != null) ? new Thread(new ThreadStart(this.WorkerThreadMain), this.startInfo.GetNullable7313_9350().Value) : new Thread(new ThreadStart(this.WorkerThreadMain));
					thread.Name = "STP " + base.GetName() + " Thread #" + this.threadCounter.ToString();
					thread.IsBackground = this.startInfo.GetFlag7310_9343();
					if (this.startInfo.GetApartmentState7315_9348() != ApartmentState.Unknown)
					{
						thread.SetApartmentState(this.startInfo.GetApartmentState7315_9348());
					}
					thread.Priority = this.startInfo.GetThreadPriority();
					thread.Start();
					this.threadCounter++;
					this.workerThreads[thread] = new 915.921(this);
					this.performanceCounters.Method8126((long)this.workerThreads.Method11338(), (long)this.inUseThreads);
					this.localPerformanceCounters.Method8126((long)this.workerThreads.Method11338(), (long)this.inUseThreads);
				}
			}
		}
	}

	// Token: 0x06001373 RID: 4979 RVA: 0x000446D4 File Offset: 0x000428D4
	private void WorkerThreadMain()
	{
		915.SetCurrentWorkerThreadInfo(this.workerThreads[Thread.CurrentThread]);
		this.RunThreadInitialization();
		try
		{
			bool flag = false;
			while (!this.isShuttingDown)
			{
				915.GetCurrentWorkerThreadInfo().UpdateLastActiveTime();
				if (this.workerThreads.Method11338() > this.startInfo.GetMaxWorkerThreads())
				{
					object value9006_ = this.workerThreads.GetValue9006_11341();
					lock (value9006_)
					{
						if (this.workerThreads.Method11338() > this.startInfo.GetMaxWorkerThreads())
						{
							this.OnWorkerThreadExit();
							break;
						}
					}
				}
				802 <<EMPTY_NAME>> = this.DequeueWorkItem();
				915.GetCurrentWorkerThreadInfo().UpdateLastActiveTime();
				if (<<EMPTY_NAME>> == null && this.workerThreads.Method11338() > this.startInfo.GetMinWorkerThreads())
				{
					object value9006_ = this.workerThreads.GetValue9006_11341();
					lock (value9006_)
					{
						if (this.workerThreads.Method11338() > this.startInfo.GetMinWorkerThreads())
						{
							this.OnWorkerThreadExit();
							break;
						}
					}
				}
				if (<<EMPTY_NAME>> != null)
				{
					try
					{
						flag = false;
						915.GetCurrentWorkerThreadInfo().SetCurrentWorkItem(<<EMPTY_NAME>>);
						if (<<EMPTY_NAME>>.Method13461())
						{
							int num = Interlocked.Increment(ref this.inUseThreads);
							this.performanceCounters.Method8126((long)this.workerThreads.Method11338(), (long)num);
							this.localPerformanceCounters.Method8126((long)this.workerThreads.Method11338(), (long)num);
							flag = true;
							<<EMPTY_NAME>>.Method13464();
							this.ExecuteWorkItem(<<EMPTY_NAME>>);
						}
					}
					catch (Exception ex)
					{
						ex.GetHashCode();
					}
					finally
					{
						<<EMPTY_NAME>>.Method13489();
						915.GetCurrentWorkerThreadInfo().SetCurrentWorkItem(null);
						if (flag)
						{
							int num2 = Interlocked.Decrement(ref this.inUseThreads);
							this.performanceCounters.Method8126((long)this.workerThreads.Method11338(), (long)num2);
							this.localPerformanceCounters.Method8126((long)this.workerThreads.Method11338(), (long)num2);
						}
						<<EMPTY_NAME>>.Method13463();
						this.OnWorkItemCompleted();
					}
				}
			}
		}
		catch (ThreadAbortException ex2)
		{
			ex2.GetHashCode();
			Thread.ResetAbort();
		}
		catch (Exception)
		{
		}
		finally
		{
			this.OnWorkerThreadExit();
			this.RunThreadTermination();
		}
	}

	// Token: 0x06001374 RID: 4980 RVA: 0x0004498C File Offset: 0x00042B8C
	private void ExecuteWorkItem(802 1)
	{
		this.performanceCounters.Method8128(1.Method13452());
		this.localPerformanceCounters.Method8128(1.Method13452());
		try
		{
			1.Method13462();
		}
		finally
		{
			this.performanceCounters.Method8129(1.Method13453());
			this.localPerformanceCounters.Method8129(1.Method13453());
		}
	}

	// Token: 0x06001375 RID: 4981 RVA: 0x000449F8 File Offset: 0x00042BF8
	private void ThrowIfCalledFromOwnWorkerThread()
	{
		if (915.GetCurrentWorkerThreadInfo() != null && 915.GetCurrentWorkerThreadInfo().GetPool() == this)
		{
			throw new NotSupportedException("WaitForIdle cannot be called from a thread on its SmartThreadPool, it causes a deadlock");
		}
	}

	// Token: 0x06001376 RID: 4982 RVA: 0x00044A1C File Offset: 0x00042C1C
	internal static void CheckWaitForGroupDeadlock(103 1)
	{
		if (915.GetCurrentWorkerThreadInfo() != null)
		{
			802 currentWorkItem = 915.GetCurrentWorkerThreadInfo().GetCurrentWorkItem();
			915.CheckWaitForItemDeadlock(1, currentWorkItem);
			if (1 != null && currentWorkItem != null && 915.GetCurrentWorkerThreadInfo().GetCurrentWorkItem().Method13456(1))
			{
				throw new NotSupportedException("WaitForIdle cannot be called from a thread on its SmartThreadPool, it causes a deadlock");
			}
		}
	}

	// Token: 0x06001377 RID: 4983 RVA: 0x00044A65 File Offset: 0x00042C65
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void CheckWaitForItemDeadlock(103 1, 802 2)
	{
		if (1 != null && 2 != null && 2.Method13456(1))
		{
			throw new NotSupportedException("WaitForIdle cannot be called from a thread on its SmartThreadPool, it causes a deadlock");
		}
	}

	// Token: 0x06001378 RID: 4984 RVA: 0x00044A81 File Offset: 0x00042C81
	public void Method4890()
	{
		this.Method4890(true, 0);
	}

	// Token: 0x06001379 RID: 4985 RVA: 0x00044A8B File Offset: 0x00042C8B
	public void Method4890(bool 1, TimeSpan 2)
	{
		this.Method4890(1, (int)2.TotalMilliseconds);
	}

	// Token: 0x0600137A RID: 4986 RVA: 0x00044A9C File Offset: 0x00042C9C
	public void Method4890(bool 1, int 2)
	{
		this.ThrowIfDisposed();
		812 3 = this.performanceCounters;
		if (394.GetRecoveredType04451947_2474() != this.performanceCounters)
		{
			this.performanceCounters = 394.GetRecoveredType04451947_2474();
			3.Dispose();
		}
		object value9006_ = this.workerThreads.GetValue9006_11341();
		Thread[] array;
		lock (value9006_)
		{
			this.workItemsQueue.Dispose();
			this.isShuttingDown = true;
			this.shutdownEvent.Set();
			array = new Thread[this.workerThreads.Method11338()];
			this.workerThreads.Method11342().CopyTo(array, 0);
		}
		int num = 2;
		Stopwatch stopwatch = Stopwatch.StartNew();
		bool flag2 = -1 == 2;
		bool flag3 = false;
		foreach (Thread thread in array)
		{
			if (!flag2 && num < 0)
			{
				flag3 = true;
				break;
			}
			if (!thread.Join(num))
			{
				flag3 = true;
				break;
			}
			if (!flag2)
			{
				num = 2 - (int)stopwatch.ElapsedMilliseconds;
			}
		}
		if (!flag3 || !1)
		{
			return;
		}
		foreach (Thread thread2 in array)
		{
			if (thread2 != null && thread2.IsAlive)
			{
				try
				{
					thread2.Abort();
				}
				catch (SecurityException ex)
				{
					ex.GetHashCode();
				}
				catch (ThreadStateException ex2)
				{
					ex2.GetHashCode();
				}
			}
		}
	}

	// Token: 0x0600137B RID: 4987 RVA: 0x00044C08 File Offset: 0x00042E08
	public static bool Method4893(688[] 1)
	{
		return 915.Method4893(1, -1, true);
	}

	// Token: 0x0600137C RID: 4988 RVA: 0x00044C12 File Offset: 0x00042E12
	public static bool Method4893(688[] 1, TimeSpan 2, bool 3)
	{
		return 915.Method4893(1, (int)2.TotalMilliseconds, 3);
	}

	// Token: 0x0600137D RID: 4989 RVA: 0x00044C23 File Offset: 0x00042E23
	public static bool Method4893(688[] 1, TimeSpan 2, bool 3, WaitHandle 4)
	{
		return 915.Method4893(1, (int)2.TotalMilliseconds, 3, 4);
	}

	// Token: 0x0600137E RID: 4990 RVA: 0x00044C35 File Offset: 0x00042E35
	public static bool Method4893(688[] 1, int 2, bool 3)
	{
		return 802.Method13469(1, 2, 3, null);
	}

	// Token: 0x0600137F RID: 4991 RVA: 0x00044C40 File Offset: 0x00042E40
	public static bool Method4893(688[] 1, int 2, bool 3, WaitHandle 4)
	{
		return 802.Method13469(1, 2, 3, 4);
	}

	// Token: 0x06001380 RID: 4992 RVA: 0x00044C4B File Offset: 0x00042E4B
	public static int Method4898(688[] 1)
	{
		return 915.Method4898(1, -1, true);
	}

	// Token: 0x06001381 RID: 4993 RVA: 0x00044C55 File Offset: 0x00042E55
	public static int Method4898(688[] 1, TimeSpan 2, bool 3)
	{
		return 915.Method4898(1, (int)2.TotalMilliseconds, 3);
	}

	// Token: 0x06001382 RID: 4994 RVA: 0x00044C66 File Offset: 0x00042E66
	public static int Method4898(688[] 1, TimeSpan 2, bool 3, WaitHandle 4)
	{
		return 915.Method4898(1, (int)2.TotalMilliseconds, 3, 4);
	}

	// Token: 0x06001383 RID: 4995 RVA: 0x00044C78 File Offset: 0x00042E78
	public static int Method4898(688[] 1, int 2, bool 3)
	{
		return 802.Method13470(1, 2, 3, null);
	}

	// Token: 0x06001384 RID: 4996 RVA: 0x00044C83 File Offset: 0x00042E83
	public static int Method4898(688[] 1, int 2, bool 3, WaitHandle 4)
	{
		return 802.Method13470(1, 2, 3, 4);
	}

	// Token: 0x06001385 RID: 4997 RVA: 0x00044C8E File Offset: 0x00042E8E
	public 103 Method4903(int 1)
	{
		return new 606(this, 1, this.startInfo);
	}

	// Token: 0x06001386 RID: 4998 RVA: 0x00044C9D File Offset: 0x00042E9D
	public 103 Method4903(int 1, 555 2)
	{
		return new 606(this, 1, 2);
	}

	// Token: 0x06001387 RID: 4999 RVA: 0x00044CA8 File Offset: 0x00042EA8
	private void RunThreadInitialization()
	{
		if (this.threadInitialization == null)
		{
			return;
		}
		foreach (808 <<EMPTY_NAME>> in this.threadInitialization.GetInvocationList())
		{
			try
			{
				<<EMPTY_NAME>>();
			}
			catch (Exception ex)
			{
				ex.GetHashCode();
				throw;
			}
		}
	}

	// Token: 0x06001388 RID: 5000 RVA: 0x00044D04 File Offset: 0x00042F04
	private void RunThreadTermination()
	{
		if (this.threadTermination == null)
		{
			return;
		}
		foreach (732 <<EMPTY_NAME>> in this.threadTermination.GetInvocationList())
		{
			try
			{
				<<EMPTY_NAME>>();
			}
			catch (Exception ex)
			{
				ex.GetHashCode();
				throw;
			}
		}
	}

	// Token: 0x06001389 RID: 5001 RVA: 0x00044D60 File Offset: 0x00042F60
	public void AddThreadInitializationHandler(808 1)
	{
		this.AddThreadInitializationCallback(1);
	}

	// Token: 0x0600138A RID: 5002 RVA: 0x00044D69 File Offset: 0x00042F69
	public void RemoveThreadInitializationHandler(808 1)
	{
		this.RemoveThreadInitializationCallback(1);
	}

	// Token: 0x0600138B RID: 5003 RVA: 0x00044D72 File Offset: 0x00042F72
	public void AddThreadTerminationHandler(732 1)
	{
		this.AddThreadTerminationCallback(1);
	}

	// Token: 0x0600138C RID: 5004 RVA: 0x00044D7B File Offset: 0x00042F7B
	public void RemoveThreadTerminationHandler(732 1)
	{
		this.RemoveThreadTerminationCallback(1);
	}

	// Token: 0x0600138D RID: 5005 RVA: 0x00044D84 File Offset: 0x00042F84
	internal void CancelRunningWorkItemsOfGroup(606 1)
	{
		foreach (915.921 2 in this.workerThreads.Method11343())
		{
			802 currentWorkItem = 2.GetCurrentWorkItem();
			if (currentWorkItem != null && currentWorkItem.Method13456(1) && !currentWorkItem.Method13483())
			{
				2.GetCurrentWorkItem().GetRecoveredType244710407_13468().Method134352(true);
			}
		}
	}

	// Token: 0x0600138E RID: 5006 RVA: 0x00044E04 File Offset: 0x00043004
	private void ThrowIfQueueFull()
	{
		int? nullable7314_ = this.startInfo.GetNullable7314_9345();
		if (nullable7314_ != null)
		{
			int num = this.currentWorkItemsCount;
			int? num2 = nullable7314_ + this.GetMaxThreads();
			if (num >= num2.GetValueOrDefault() & num2 != null)
			{
				string str = "Queue is at its maximum (";
				num2 = nullable7314_;
				throw new 477(str + num2.ToString() + ")");
			}
		}
	}

	// Token: 0x0600138F RID: 5007 RVA: 0x00044E95 File Offset: 0x00043095
	public int GetMinThreads()
	{
		this.ThrowIfDisposed();
		return this.startInfo.GetMinWorkerThreads();
	}

	// Token: 0x06001390 RID: 5008 RVA: 0x00044EA8 File Offset: 0x000430A8
	public void SetMinThreads(int 1)
	{
		if (this.startInfo.GetMaxWorkerThreads() < 1)
		{
			this.startInfo.SetMaxWorkerThreads(1);
		}
		this.startInfo.SetMinWorkerThreads(1);
		this.EnsureMinimumThreads();
	}

	// Token: 0x06001391 RID: 5009 RVA: 0x00044ED6 File Offset: 0x000430D6
	public int GetMaxThreads()
	{
		this.ThrowIfDisposed();
		return this.startInfo.GetMaxWorkerThreads();
	}

	// Token: 0x06001392 RID: 5010 RVA: 0x00044EE9 File Offset: 0x000430E9
	public void SetMaxThreads(int 1)
	{
		if (this.startInfo.GetMinWorkerThreads() > 1)
		{
			this.startInfo.SetMinWorkerThreads(1);
		}
		this.startInfo.SetMaxWorkerThreads(1);
		this.EnsureMinimumThreads();
	}

	// Token: 0x06001393 RID: 5011 RVA: 0x00044F17 File Offset: 0x00043117
	public int? GetMaxQueueLength()
	{
		this.ThrowIfDisposed();
		return this.startInfo.GetNullable7314_9345();
	}

	// Token: 0x06001394 RID: 5012 RVA: 0x00044F2A File Offset: 0x0004312A
	public void SetMaxQueueLength(int? 1)
	{
		this.startInfo.Method9346(1);
	}

	// Token: 0x06001395 RID: 5013 RVA: 0x00044F38 File Offset: 0x00043138
	public int GetActiveThreads()
	{
		this.ThrowIfDisposed();
		return this.workerThreads.Method11338();
	}

	// Token: 0x06001396 RID: 5014 RVA: 0x00044F4B File Offset: 0x0004314B
	public int GetCurrentWorkItemsCount()
	{
		this.ThrowIfDisposed();
		return this.currentWorkItemsCount;
	}

	// Token: 0x06001397 RID: 5015 RVA: 0x00044F5B File Offset: 0x0004315B
	public static bool IsCurrentWorkItemCanceled()
	{
		return 915.GetCurrentWorkerThreadInfo().GetCurrentWorkItem().Method13483();
	}

	// Token: 0x06001398 RID: 5016 RVA: 0x00044F6C File Offset: 0x0004316C
	public static void AbortIfCurrentWorkItemCanceled()
	{
		if (915.IsCurrentWorkItemCanceled())
		{
			Thread.CurrentThread.Abort();
		}
	}

	// Token: 0x06001399 RID: 5017 RVA: 0x00044F7F File Offset: 0x0004317F
	public 897 GetStartInfo()
	{
		return this.startInfo.Method9347();
	}

	// Token: 0x0600139A RID: 5018 RVA: 0x00044F8C File Offset: 0x0004318C
	public bool GetIsShuttingDown()
	{
		return this.isShuttingDown;
	}

	// Token: 0x0600139B RID: 5019 RVA: 0x00044F94 File Offset: 0x00043194
	public 607 GetLocalPerformanceCounters()
	{
		return (607)this.localPerformanceCounters;
	}

	// Token: 0x0600139C RID: 5020 RVA: 0x00044FA4 File Offset: 0x000431A4
	public void Dispose()
	{
		if (!this.isDisposed)
		{
			if (!this.isShuttingDown)
			{
				this.Method4890();
			}
			if (this.shutdownEvent != null)
			{
				this.shutdownEvent.Close();
				this.shutdownEvent = null;
			}
			this.workerThreads.Method11344();
			if (this.idleEvent != null)
			{
				this.idleEvent.Close();
				this.idleEvent = null;
			}
			this.isDisposed = true;
		}
	}

	// Token: 0x0600139D RID: 5021 RVA: 0x0004500D File Offset: 0x0004320D
	private void ThrowIfDisposed()
	{
		if (this.isDisposed)
		{
			throw new ObjectDisposedException(base.GetType().ToString(), "The SmartThreadPool has been shutdown");
		}
	}

	// Token: 0x0600139E RID: 5022 RVA: 0x0004502D File Offset: 0x0004322D
	public override int GetNumber6509_8337()
	{
		return this.GetMaxThreads();
	}

	// Token: 0x0600139F RID: 5023 RVA: 0x00045035 File Offset: 0x00043235
	public override void Method8338(int 1)
	{
		this.SetMaxThreads(1);
	}

	// Token: 0x060013A0 RID: 5024 RVA: 0x0004503E File Offset: 0x0004323E
	public override int GetNumber6512_8339()
	{
		this.ThrowIfDisposed();
		return this.inUseThreads;
	}

	// Token: 0x060013A1 RID: 5025 RVA: 0x0004504C File Offset: 0x0004324C
	public override int Method8340()
	{
		this.ThrowIfDisposed();
		return this.workItemsQueue.GetWorkItemsCount();
	}

	// Token: 0x060013A2 RID: 5026 RVA: 0x0004505F File Offset: 0x0004325F
	public override object[] Method8341()
	{
		return this.workItemsQueue.Method8371();
	}

	// Token: 0x060013A3 RID: 5027 RVA: 0x00044F7F File Offset: 0x0004317F
	public override 555 GetRecoveredType12856513_8342()
	{
		return this.startInfo.Method9347();
	}

	// Token: 0x060013A4 RID: 5028 RVA: 0x0004506C File Offset: 0x0004326C
	public override void Method8343()
	{
		if (!this.isSuspended)
		{
			return;
		}
		this.isSuspended = false;
		foreach (object obj in ((IEnumerable)this.workItemsGroups.Method11343()))
		{
			((606)obj).Method8349();
		}
		this.EnsureMinimumThreads();
	}

	// Token: 0x060013A5 RID: 5029 RVA: 0x000450E0 File Offset: 0x000432E0
	public override void Method8344(bool 1)
	{
		this.cancellation.SetIsCanceled(true);
		this.cancellation = new 43();
		foreach (object obj in ((IEnumerable)this.workItemsGroups.Method11343()))
		{
			((606)obj).Method8344(1);
		}
		if (!1)
		{
			return;
		}
		foreach (915.921 2 in this.workerThreads.Method11343())
		{
			802 currentWorkItem = 2.GetCurrentWorkItem();
			if (currentWorkItem != null && 2.GetPool() == this && !currentWorkItem.Method13483())
			{
				2.GetCurrentWorkItem().GetRecoveredType244710407_13468().Method134352(true);
			}
		}
	}

	// Token: 0x060013A6 RID: 5030 RVA: 0x000451C8 File Offset: 0x000433C8
	public override bool Method8345(int 1)
	{
		this.ThrowIfCalledFromOwnWorkerThread();
		return 922.WaitOne(this.idleEvent, 1, false);
	}

	// Token: 0x060013A7 RID: 5031 RVA: 0x000451DD File Offset: 0x000433DD
	public override void Method8346(530 1)
	{
		throw new NotImplementedException("This event is not implemented in the SmartThreadPool class. Please create a WorkItemsGroup in order to use this feature.");
	}

	// Token: 0x060013A8 RID: 5032 RVA: 0x000451DD File Offset: 0x000433DD
	public override void Method8347(530 1)
	{
		throw new NotImplementedException("This event is not implemented in the SmartThreadPool class. Please create a WorkItemsGroup in order to use this feature.");
	}

	// Token: 0x060013A9 RID: 5033 RVA: 0x000451E9 File Offset: 0x000433E9
	internal override void OnBeforeEnqueue()
	{
		this.ThrowIfDisposed();
		this.ThrowIfQueueFull();
	}

	// Token: 0x060013AA RID: 5034 RVA: 0x000451F8 File Offset: 0x000433F8
	public void Method4939(IEnumerable<Action> 1)
	{
		555 2 = new 555();
		2.Method7499(true);
		555 3 = 2;
		103 4 = this.Method4903(int.MaxValue, 3);
		foreach (Action 5 in 1)
		{
			4.Method36622(5, (639)2);
		}
		4.Method8343();
		4.Method8345();
	}

	// Token: 0x060013AB RID: 5035 RVA: 0x00045268 File Offset: 0x00043468
	public void Method4939(Action[] 1)
	{
		this.Method4939(1);
	}

	// Token: 0x060013AC RID: 5036 RVA: 0x00045274 File Offset: 0x00043474
	public int Method4941(IEnumerable<Action> 1)
	{
		915.918 2 = new 915.918();
		555 3 = new 555();
		3.Method7499(true);
		555 4 = 3;
		103 5 = this.Method4903(int.MaxValue, 4);
		2.manualResetEvent = new ManualResetEvent(false);
		2.completionIndex = new 915.916();
		int num = 0;
		foreach (Action action in 1)
		{
			5.Method36622(new Action(new 915.917
			{
				invokeState = 2,
				action = action,
				number = num
			}.ExecuteAndSignal), (639)2);
			num++;
		}
		5.Method8343();
		2.manualResetEvent.WaitOne();
		return 2.completionIndex.number;
	}

	// Token: 0x060013AD RID: 5037 RVA: 0x0004534C File Offset: 0x0004354C
	public int Method4941(Action[] 1)
	{
		return this.Method4941(1);
	}

	// Token: 0x060013AE RID: 5038 RVA: 0x00045358 File Offset: 0x00043558
	public void Method4943<T>(T 1, IEnumerable<Action<T>> 2)
	{
		915.919<T> 3 = new 915.919<T>();
		3._item3834 = 1;
		555 4 = new 555();
		4.Method7499(true);
		555 5 = 4;
		103 6 = this.Method4903(1, 5);
		foreach (Action<T> action in 2)
		{
			6.Method36622(new Action(new 915.920<T>
			{
				_recoveredType08743840 = 3,
				_action3839 = action
			}.Method4866), (639)2);
		}
		6.Method8343();
		6.Method8345();
	}

	// Token: 0x060013AF RID: 5039 RVA: 0x000453F8 File Offset: 0x000435F8
	public void Method4943<T>(T 1, Action<T>[] 2)
	{
		this.Method4943<T>(1, 2);
	}

	// Token: 0x04000928 RID: 2344
	public static readonly 675 _recoveredType18073841;

	// Token: 0x04000929 RID: 2345
	public static readonly string text;

	// Token: 0x0400092A RID: 2346
	public static readonly int? nullable2;

	// Token: 0x0400092B RID: 2347
	public static readonly int? nullable3;

	// Token: 0x0400092C RID: 2348
	private readonly 729<Thread, 915.921> workerThreads = new 729<Thread, 915.921>();

	// Token: 0x0400092D RID: 2349
	private readonly 981 workItemsQueue = new 981();

	// Token: 0x0400092E RID: 2350
	private int workItemsExecuted;

	// Token: 0x0400092F RID: 2351
	private int inUseThreads;

	// Token: 0x04000930 RID: 2352
	private 897 startInfo;

	// Token: 0x04000931 RID: 2353
	private volatile int currentWorkItemsCount;

	// Token: 0x04000932 RID: 2354
	private ManualResetEvent idleEvent = 595.Method8117(true);

	// Token: 0x04000933 RID: 2355
	private ManualResetEvent shutdownEvent = 595.Method8117(false);

	// Token: 0x04000934 RID: 2356
	private bool isSuspended;

	// Token: 0x04000935 RID: 2357
	private bool isShuttingDown;

	// Token: 0x04000936 RID: 2358
	private int threadCounter;

	// Token: 0x04000937 RID: 2359
	private bool isDisposed;

	// Token: 0x04000938 RID: 2360
	private readonly 729<103, 103> workItemsGroups = new 729<103, 103>();

	// Token: 0x04000939 RID: 2361
	private 43 cancellation = new 43();

	// Token: 0x0400093A RID: 2362
	private 812 performanceCounters = 394.GetRecoveredType04451947_2474();

	// Token: 0x0400093B RID: 2363
	private 812 localPerformanceCounters = 394.GetRecoveredType04451947_2474();

	// Token: 0x0400093C RID: 2364
	[ThreadStatic]
	private static 915.921 currentWorkerThreadInfo;

	// Token: 0x0400093D RID: 2365
	private 808 threadInitialization;

	// Token: 0x0400093E RID: 2366
	private 732 threadTermination;

	// Token: 0x0200027D RID: 637
	public sealed class 918
	{
		// Token: 0x0400093F RID: 2367
		public 915.916 completionIndex;

		// Token: 0x04000940 RID: 2368
		public ManualResetEvent manualResetEvent;
	}

	// Token: 0x0200027E RID: 638
	public sealed class 917
	{
		// Token: 0x060013B1 RID: 5041 RVA: 0x00045402 File Offset: 0x00043602
		internal void ExecuteAndSignal()
		{
			this.action();
			Interlocked.CompareExchange(ref this.invokeState.completionIndex.number, this.number, -1);
			this.invokeState.manualResetEvent.Set();
		}

		// Token: 0x04000941 RID: 2369
		public Action action;

		// Token: 0x04000942 RID: 2370
		public int number;

		// Token: 0x04000943 RID: 2371
		public 915.918 invokeState;
	}

	// Token: 0x0200027F RID: 639
	public sealed class 916
	{
		// Token: 0x04000944 RID: 2372
		public int number = -1;
	}

	// Token: 0x02000280 RID: 640
	public sealed class 919<TItem>
	{
		// Token: 0x04000945 RID: 2373
		public TItem _item3834;
	}

	// Token: 0x02000281 RID: 641
	public sealed class 921
	{
		// Token: 0x060013B5 RID: 5045 RVA: 0x0004544C File Offset: 0x0004364C
		public 921(915 1)
		{
			this.pool = 1;
			this.creationTime = DateTime.UtcNow;
			this.lastActiveTime = DateTime.MinValue;
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x00045471 File Offset: 0x00043671
		public 802 GetCurrentWorkItem()
		{
			return this.currentWorkItem;
		}

		// Token: 0x060013B7 RID: 5047 RVA: 0x00045479 File Offset: 0x00043679
		public void SetCurrentWorkItem(802 1)
		{
			this.currentWorkItem = 1;
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x00045482 File Offset: 0x00043682
		public 915 GetPool()
		{
			return this.pool;
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x0004548A File Offset: 0x0004368A
		public void UpdateLastActiveTime()
		{
			this.lastActiveTime = DateTime.UtcNow;
		}

		// Token: 0x04000946 RID: 2374
		private readonly DateTime creationTime;

		// Token: 0x04000947 RID: 2375
		private DateTime lastActiveTime;

		// Token: 0x04000948 RID: 2376
		private readonly 915 pool;

		// Token: 0x04000949 RID: 2377
		private 802 currentWorkItem;
	}

	// Token: 0x02000282 RID: 642
	public sealed class 920<TItem>
	{
		// Token: 0x060013BA RID: 5050 RVA: 0x00045497 File Offset: 0x00043697
		internal void Method4866()
		{
			this._action3839(this._recoveredType08743840._item3834);
		}

		// Token: 0x0400094A RID: 2378
		public Action<TItem> _action3839;

		// Token: 0x0400094B RID: 2379
		public 915.919<TItem> _recoveredType08743840;
	}
}
