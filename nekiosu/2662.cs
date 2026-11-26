using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;

// Token: 0x0200044A RID: 1098
[ComVisible(false)]
public class 2662 : IDisposable
{
	// Token: 0x060021EB RID: 8683 RVA: 0x00092394 File Offset: 0x00090594
	public 2662()
	{
		this.ownerThreadId = Thread.CurrentThread.ManagedThreadId;
		this.clock.Start();
	}

	// Token: 0x060021EC RID: 8684 RVA: 0x000923E3 File Offset: 0x000905E3
	protected virtual bool IsOnOwnerThread()
	{
		return Thread.CurrentThread.ManagedThreadId == this.ownerThreadId;
	}

	// Token: 0x060021ED RID: 8685 RVA: 0x000923F8 File Offset: 0x000905F8
	public bool 1()
	{
		Queue<1189> obj = this.pendingActions;
		1189[] array;
		lock (obj)
		{
			List<1187> obj2 = this.timedTasks;
			lock (obj2)
			{
				long elapsedMilliseconds = this.clock.ElapsedMilliseconds;
				1187 <<EMPTY_NAME>>;
				while (this.timedTasks.Count > 0 && (<<EMPTY_NAME>> = this.timedTasks[0]).dueTime <= elapsedMilliseconds)
				{
					this.timedTasks.RemoveAt(0);
					if (!<<EMPTY_NAME>>.1())
					{
						this.pendingActions.Enqueue(<<EMPTY_NAME>>.action);
						if (<<EMPTY_NAME>>.repeatInterval > 0)
						{
							if (this.timedTasks.Count < 1000)
							{
								<<EMPTY_NAME>>.dueTime += (long)<<EMPTY_NAME>>.repeatInterval;
							}
							else
							{
								<<EMPTY_NAME>>.dueTime = this.clock.ElapsedMilliseconds + (long)<<EMPTY_NAME>>.repeatInterval;
							}
							this.timedTasks.Method11157(<<EMPTY_NAME>>);
						}
					}
				}
			}
			int count = this.pendingActions.Count;
			if (count == 0)
			{
				return false;
			}
			array = new 1189[count];
			this.pendingActions.CopyTo(array, 0);
			this.pendingActions.Clear();
		}
		foreach (1189 2 in array)
		{
			try
			{
				2();
			}
			catch (Exception 3)
			{
				1338.4(3, "scheduled delegate", 1341.Runtime);
			}
		}
		return true;
	}

	// Token: 0x060021EE RID: 8686 RVA: 0x000925BC File Offset: 0x000907BC
	public virtual bool Schedule(1189 1, bool 2)
	{
		if (!2 && this.IsOnOwnerThread())
		{
			1();
			return true;
		}
		Queue<1189> obj = this.pendingActions;
		lock (obj)
		{
			this.pendingActions.Enqueue(1);
		}
		return false;
	}

	// Token: 0x060021EF RID: 8687 RVA: 0x00092618 File Offset: 0x00090818
	public virtual bool Schedule(1187 1)
	{
		List<1187> obj = this.timedTasks;
		lock (obj)
		{
			this.timedTasks.Method11157(1);
		}
		return true;
	}

	// Token: 0x060021F0 RID: 8688 RVA: 0x00092660 File Offset: 0x00090860
	public 1187 2(1189 1, int 2, bool 3)
	{
		1187 4 = new 1187(1, this.clock.ElapsedMilliseconds + (long)2, 3 ? 2 : 0);
		if (!this.Schedule(4))
		{
			return null;
		}
		return 4;
	}

	// Token: 0x060021F1 RID: 8689 RVA: 0x00092698 File Offset: 0x00090898
	public bool 3(1189 1)
	{
		if (this.pendingActions.Contains(1))
		{
			return false;
		}
		Queue<1189> obj = this.pendingActions;
		lock (obj)
		{
			this.pendingActions.Enqueue(1);
		}
		return true;
	}

	// Token: 0x060021F2 RID: 8690 RVA: 0x000926F0 File Offset: 0x000908F0
	protected virtual void Dispose(bool 1)
	{
		if (!this.isDisposed)
		{
			this.isDisposed = true;
		}
	}

	// Token: 0x060021F3 RID: 8691 RVA: 0x00092701 File Offset: 0x00090901
	private void 4()
	{
		this.Dispose(true);
	}

	// Token: 0x060021F4 RID: 8692 RVA: 0x0009270A File Offset: 0x0009090A
	void IDisposable.Dispose()
	{
		this.4();
	}

	// Token: 0x04001753 RID: 5971
	private readonly Queue<1189> pendingActions = new Queue<1189>();

	// Token: 0x04001754 RID: 5972
	private readonly List<1187> timedTasks = new List<1187>();

	// Token: 0x04001755 RID: 5973
	private int ownerThreadId;

	// Token: 0x04001756 RID: 5974
	private Stopwatch clock = new Stopwatch();

	// Token: 0x04001757 RID: 5975
	private bool isDisposed;
}
