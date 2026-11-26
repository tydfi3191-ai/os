using System;
using System.Threading;

// Token: 0x0200029C RID: 668
public sealed class 981 : IDisposable
{
	// Token: 0x06001446 RID: 5190 RVA: 0x00046742 File Offset: 0x00044942
	private static 981.982 GetThreadWaiterEntry()
	{
		return 981.threadWaiterEntry;
	}

	// Token: 0x06001447 RID: 5191 RVA: 0x00046749 File Offset: 0x00044949
	private static void SetThreadWaiterEntry(981.982 1)
	{
		981.threadWaiterEntry = 1;
	}

	// Token: 0x06001448 RID: 5192 RVA: 0x00046751 File Offset: 0x00044951
	public int GetWorkItemsCount()
	{
		return this.workItems.GetNumber4843_6109();
	}

	// Token: 0x06001449 RID: 5193 RVA: 0x0004675E File Offset: 0x0004495E
	public int GetWaitersCount()
	{
		return this.waitersCount;
	}

	// Token: 0x0600144A RID: 5194 RVA: 0x00046768 File Offset: 0x00044968
	public bool EnqueueWorkItem(802 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("workItem", "workItem cannot be null");
		}
		bool flag = true;
		lock (this)
		{
			this.ThrowIfDisposed();
			if (!this.isActive)
			{
				return false;
			}
			while (this.waitersCount > 0)
			{
				if (this.DequeueWaiter().Signal(1))
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				this.workItems.Method6106(1);
			}
		}
		return true;
	}

	// Token: 0x0600144B RID: 5195 RVA: 0x000467F4 File Offset: 0x000449F4
	public 802 DequeueWorkItem(int 1, WaitHandle 2)
	{
		802 3 = null;
		981 obj = this;
		981.982 waiterEntry;
		lock (obj)
		{
			this.ThrowIfDisposed();
			if (this.workItems.GetNumber4843_6109() > 0)
			{
				3 = (this.workItems.Method6107() as 802);
				return 3;
			}
			waiterEntry = 981.GetWaiterEntry();
			this.EnqueueWaiter(waiterEntry);
		}
		int num = 922.Method5095(new WaitHandle[]
		{
			waiterEntry.GetWaitHandle(),
			2
		}, 1, true);
		obj = this;
		lock (obj)
		{
			bool flag2 = num == 0;
			if (!flag2)
			{
				bool flag3 = waiterEntry.TryTimeout();
				if (flag3)
				{
					this.RemoveWaiter(waiterEntry, false);
				}
				flag2 = !flag3;
			}
			if (flag2)
			{
				3 = waiterEntry.GetWorkItem();
				if (3 == null)
				{
					3 = (this.workItems.Method6107() as 802);
				}
			}
		}
		return 3;
	}

	// Token: 0x0600144C RID: 5196 RVA: 0x000468EC File Offset: 0x00044AEC
	private void Cleanup()
	{
		lock (this)
		{
			if (this.isActive)
			{
				this.isActive = false;
				foreach (object obj in this.workItems)
				{
					((802)obj).Method13489();
				}
				this.workItems.Method6110();
				while (this.waitersCount > 0)
				{
					this.DequeueWaiter().TryTimeout();
				}
			}
		}
	}

	// Token: 0x0600144D RID: 5197 RVA: 0x0004699C File Offset: 0x00044B9C
	public object[] Method8371()
	{
		object[] result;
		lock (this)
		{
			object[] array = new object[this.workItems.GetNumber4843_6109()];
			int num = 0;
			foreach (object obj in this.workItems)
			{
				802 <<EMPTY_NAME>> = (802)obj;
				array[num] = <<EMPTY_NAME>>.GetRecoveredType244710407_13468().GetValue10400_13437();
				num++;
			}
			result = array;
		}
		return result;
	}

	// Token: 0x0600144E RID: 5198 RVA: 0x00046A48 File Offset: 0x00044C48
	private static 981.982 GetWaiterEntry()
	{
		if (981.GetThreadWaiterEntry() == null)
		{
			981.SetThreadWaiterEntry(new 981.982());
		}
		981.GetThreadWaiterEntry().Reset();
		return 981.GetThreadWaiterEntry();
	}

	// Token: 0x0600144F RID: 5199 RVA: 0x00046A6C File Offset: 0x00044C6C
	public void EnqueueWaiter(981.982 1)
	{
		this.RemoveWaiter(1, false);
		if (this.waitersHead.nextWaiter == null)
		{
			this.waitersHead.nextWaiter = 1;
			1.previousWaiter = this.waitersHead;
		}
		else
		{
			981.982 nextWaiter = this.waitersHead.nextWaiter;
			this.waitersHead.nextWaiter = 1;
			1.nextWaiter = nextWaiter;
			1.previousWaiter = this.waitersHead;
			nextWaiter.previousWaiter = 1;
		}
		this.waitersCount++;
	}

	// Token: 0x06001450 RID: 5200 RVA: 0x00046AE8 File Offset: 0x00044CE8
	private 981.982 DequeueWaiter()
	{
		981.982 nextWaiter = this.waitersHead.nextWaiter;
		981.982 nextWaiter2 = nextWaiter.nextWaiter;
		this.RemoveWaiter(nextWaiter, true);
		this.waitersHead.nextWaiter = nextWaiter2;
		if (nextWaiter2 != null)
		{
			nextWaiter2.previousWaiter = this.waitersHead;
		}
		return nextWaiter;
	}

	// Token: 0x06001451 RID: 5201 RVA: 0x00046B2C File Offset: 0x00044D2C
	private void RemoveWaiter(981.982 1, bool 2)
	{
		981.982 previousWaiter = 1.previousWaiter;
		981.982 nextWaiter = 1.nextWaiter;
		bool flag = 2;
		1.previousWaiter = null;
		1.nextWaiter = null;
		if (previousWaiter != null)
		{
			previousWaiter.nextWaiter = nextWaiter;
			flag = true;
		}
		if (nextWaiter != null)
		{
			nextWaiter.previousWaiter = previousWaiter;
			flag = true;
		}
		if (flag)
		{
			this.waitersCount--;
		}
	}

	// Token: 0x06001452 RID: 5202 RVA: 0x00046B80 File Offset: 0x00044D80
	public void Dispose()
	{
		if (!this.isDisposed)
		{
			this.Cleanup();
		}
		this.isDisposed = true;
	}

	// Token: 0x06001453 RID: 5203 RVA: 0x00046B97 File Offset: 0x00044D97
	private void ThrowIfDisposed()
	{
		if (this.isDisposed)
		{
			throw new ObjectDisposedException(base.GetType().ToString(), "The SmartThreadPool has been shutdown");
		}
	}

	// Token: 0x04000988 RID: 2440
	private readonly 981.982 waitersHead = new 981.982();

	// Token: 0x04000989 RID: 2441
	private int waitersCount;

	// Token: 0x0400098A RID: 2442
	private readonly 526 workItems = new 526();

	// Token: 0x0400098B RID: 2443
	private bool isActive = true;

	// Token: 0x0400098C RID: 2444
	[ThreadStatic]
	private static 981.982 threadWaiterEntry;

	// Token: 0x0400098D RID: 2445
	private bool isDisposed;

	// Token: 0x0200029D RID: 669
	public sealed class 982 : IDisposable
	{
		// Token: 0x06001455 RID: 5205 RVA: 0x00046BDC File Offset: 0x00044DDC
		public 982()
		{
			this.Reset();
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x00046BF5 File Offset: 0x00044DF5
		public WaitHandle GetWaitHandle()
		{
			return this.autoResetEvent;
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x00046BFD File Offset: 0x00044DFD
		public 802 GetWorkItem()
		{
			return this.workItem;
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x00046C08 File Offset: 0x00044E08
		public bool Signal(802 1)
		{
			lock (this)
			{
				if (!this.isTimedOut)
				{
					this.workItem = 1;
					this.hasWorkItem = true;
					this.autoResetEvent.Set();
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x00046C68 File Offset: 0x00044E68
		public bool TryTimeout()
		{
			lock (this)
			{
				if (!this.hasWorkItem)
				{
					this.isTimedOut = true;
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x00046CB4 File Offset: 0x00044EB4
		public void Reset()
		{
			this.workItem = null;
			this.isTimedOut = false;
			this.hasWorkItem = false;
			this.autoResetEvent.Reset();
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x00046CD7 File Offset: 0x00044ED7
		public void Close()
		{
			if (this.autoResetEvent != null)
			{
				this.autoResetEvent.Close();
				this.autoResetEvent = null;
			}
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x00046CF4 File Offset: 0x00044EF4
		public void Dispose()
		{
			lock (this)
			{
				if (!this.isDisposed)
				{
					this.Close();
				}
				this.isDisposed = true;
			}
		}

		// Token: 0x0400098E RID: 2446
		private AutoResetEvent autoResetEvent = 595.Method8116();

		// Token: 0x0400098F RID: 2447
		private bool isTimedOut;

		// Token: 0x04000990 RID: 2448
		private bool hasWorkItem;

		// Token: 0x04000991 RID: 2449
		private 802 workItem;

		// Token: 0x04000992 RID: 2450
		private bool isDisposed;

		// Token: 0x04000993 RID: 2451
		internal 981.982 nextWaiter;

		// Token: 0x04000994 RID: 2452
		internal 981.982 previousWaiter;
	}
}
