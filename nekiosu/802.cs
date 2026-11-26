using System;
using System.Threading;

// Token: 0x02000276 RID: 630
public sealed class 802 : 427
{
	// Token: 0x06001308 RID: 4872 RVA: 0x000430A8 File Offset: 0x000412A8
	public 802(103 1, 969 2, 454 3, object 4)
	{
		this.iWorkItemsGroup2 = 1;
		this.workItemInfo2 = 2;
		if (this.workItemInfo2.GetFlag7369_9481() || this.workItemInfo2.GetFlag7370_9483())
		{
			this._recoveredType048510401 = 404.Method2783(this.workItemInfo2.GetFlag7369_9481(), this.workItemInfo2.GetFlag7370_9483());
		}
		this._recoveredType072410399 = 3;
		this.value2 = 4;
		this._recoveredType244710407 = new 802.804(this);
		this.Method13455();
	}

	// Token: 0x06001309 RID: 4873 RVA: 0x0004313C File Offset: 0x0004133C
	private static bool Method13447(802.803 1, 802.803 2)
	{
		bool result = false;
		if (1 != (802.803)0)
		{
			if (1 == (802.803)1)
			{
				result = ((802.803)2 == 2 || (802.803)3 == 2);
			}
		}
		else
		{
			result = ((802.803)1 == 2 || (802.803)3 == 2);
		}
		return result;
	}

	// Token: 0x0600130A RID: 4874 RVA: 0x00043170 File Offset: 0x00041370
	private void Method13448(762 1)
	{
		762 2 = this._recoveredType225510409;
		762 3;
		do
		{
			3 = 2;
			762 value = (762)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<762>(ref this._recoveredType225510409, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x0600130B RID: 4875 RVA: 0x000431A8 File Offset: 0x000413A8
	private void Method13449(762 1)
	{
		762 2 = this._recoveredType225510409;
		762 3;
		do
		{
			3 = 2;
			762 value = (762)Delegate.Remove(3, 1);
			2 = Interlocked.CompareExchange<762>(ref this._recoveredType225510409, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x0600130C RID: 4876 RVA: 0x000431E0 File Offset: 0x000413E0
	private void Method13450(762 1)
	{
		762 2 = this._recoveredType225510410;
		762 3;
		do
		{
			3 = 2;
			762 value = (762)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<762>(ref this._recoveredType225510410, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x0600130D RID: 4877 RVA: 0x00043218 File Offset: 0x00041418
	private void Method13451(762 1)
	{
		762 2 = this._recoveredType225510410;
		762 3;
		do
		{
			3 = 2;
			762 value = (762)Delegate.Remove(3, 1);
			2 = Interlocked.CompareExchange<762>(ref this._recoveredType225510410, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x0600130E RID: 4878 RVA: 0x0004324D File Offset: 0x0004144D
	public TimeSpan Method13452()
	{
		return this._recoveredType244310416.Method13418();
	}

	// Token: 0x0600130F RID: 4879 RVA: 0x0004325A File Offset: 0x0004145A
	public TimeSpan Method13453()
	{
		return this._recoveredType244310417.Method13418();
	}

	// Token: 0x06001310 RID: 4880 RVA: 0x00043267 File Offset: 0x00041467
	internal 969 GetRecoveredType167410408_13454()
	{
		return this.workItemInfo2;
	}

	// Token: 0x06001311 RID: 4881 RVA: 0x00043270 File Offset: 0x00041470
	internal void Method13455()
	{
		this._recoveredType244610404 = (802.803)0;
		this.manualResetEvent = null;
		this.number2 = 0;
		this._recoveredType244310416 = new 801();
		this._recoveredType244310417 = new 801();
		this.number3 = ((this.workItemInfo2.GetNumber7375_9493() > 0L) ? (DateTime.UtcNow.Ticks + this.workItemInfo2.GetNumber7375_9493() * 10000L) : long.MaxValue);
	}

	// Token: 0x06001312 RID: 4882 RVA: 0x000432E8 File Offset: 0x000414E8
	internal bool Method13456(103 1)
	{
		return 1 == this.iWorkItemsGroup2;
	}

	// Token: 0x06001313 RID: 4883 RVA: 0x000432F3 File Offset: 0x000414F3
	internal 43 GetRecoveredType089410411_13457()
	{
		return this.canceledSmartThreadPool2;
	}

	// Token: 0x06001314 RID: 4884 RVA: 0x000432FB File Offset: 0x000414FB
	internal void SetRecoveredType089410411_13458(43 1)
	{
		this.canceledSmartThreadPool2 = 1;
	}

	// Token: 0x06001315 RID: 4885 RVA: 0x00043304 File Offset: 0x00041504
	internal 43 GetRecoveredType089410412_13459()
	{
		return this.canceledSmartThreadPool3;
	}

	// Token: 0x06001316 RID: 4886 RVA: 0x0004330C File Offset: 0x0004150C
	internal void SetRecoveredType089410412_13460(43 1)
	{
		this.canceledSmartThreadPool3 = 1;
	}

	// Token: 0x06001317 RID: 4887 RVA: 0x00043318 File Offset: 0x00041518
	public bool Method13461()
	{
		this._recoveredType244310416.Method13417();
		this._recoveredType244310417.Method13415();
		lock (this)
		{
			if (this.Method13483())
			{
				bool result = false;
				if (this.workItemInfo2.GetPostExecuteWorkItemCallback() != null && (this.workItemInfo2.GetCallToPostExecute() & (567)1) == (567)1)
				{
					result = true;
				}
				return result;
			}
			this.thread2 = Thread.CurrentThread;
			this.Method13474((802.803)1);
		}
		return true;
	}

	// Token: 0x06001318 RID: 4888 RVA: 0x000433A8 File Offset: 0x000415A8
	public void Method13462()
	{
		567 <<EMPTY_NAME>> = (567)0;
		802.803 2 = this.Method13473();
		if (2 != (802.803)1)
		{
			if (2 != (802.803)3)
			{
				throw new NotSupportedException();
			}
			<<EMPTY_NAME>> |= (567)1;
		}
		else
		{
			<<EMPTY_NAME>> |= (567)2;
			this.Method13465();
		}
		if ((<<EMPTY_NAME>> & this.workItemInfo2.GetCallToPostExecute()) != (567)0)
		{
			this.Method13466();
		}
		this._recoveredType244310417.Method13417();
	}

	// Token: 0x06001319 RID: 4889 RVA: 0x00043400 File Offset: 0x00041600
	internal void Method13463()
	{
		try
		{
			if (this._recoveredType225510410 != null)
			{
				this._recoveredType225510410(this);
			}
		}
		catch
		{
		}
	}

	// Token: 0x0600131A RID: 4890 RVA: 0x00043438 File Offset: 0x00041638
	internal void Method13464()
	{
		try
		{
			if (this._recoveredType225510409 != null)
			{
				this._recoveredType225510409(this);
			}
		}
		catch
		{
		}
	}

	// Token: 0x0600131B RID: 4891 RVA: 0x00043470 File Offset: 0x00041670
	private void Method13465()
	{
		404 <<EMPTY_NAME>> = null;
		if (this._recoveredType048510401 != null)
		{
			<<EMPTY_NAME>> = 404.Method2783(this._recoveredType048510401.Method2781(), this._recoveredType048510401.Method2782());
			404.Method2784(this._recoveredType048510401);
		}
		Exception 2 = null;
		object 3 = null;
		try
		{
			try
			{
				3 = this._recoveredType072410399(this.value2);
			}
			catch (Exception 2)
			{
			}
			if (Interlocked.CompareExchange<Thread>(ref this.thread2, null, this.thread2) == null)
			{
				Thread.Sleep(60000);
			}
		}
		catch (ThreadAbortException ex)
		{
			ex.GetHashCode();
			if (!915.GetCurrentWorkerThreadInfo().GetPool().GetIsShuttingDown())
			{
				Thread.ResetAbort();
			}
		}
		if (this._recoveredType048510401 != null)
		{
			404.Method2784(<<EMPTY_NAME>>);
		}
		if (!915.IsCurrentWorkItemCanceled())
		{
			this.Method13467(3, 2);
		}
	}

	// Token: 0x0600131C RID: 4892 RVA: 0x00043540 File Offset: 0x00041740
	private void Method13466()
	{
		if (this.workItemInfo2.GetPostExecuteWorkItemCallback() != null)
		{
			try
			{
				this.workItemInfo2.GetPostExecuteWorkItemCallback()(this._recoveredType244710407);
			}
			catch (Exception)
			{
			}
		}
	}

	// Token: 0x0600131D RID: 4893 RVA: 0x00043588 File Offset: 0x00041788
	internal void Method13467(object 1, Exception 2)
	{
		this.value3 = 1;
		this.exception2 = 2;
		this.Method13475(false);
	}

	// Token: 0x0600131E RID: 4894 RVA: 0x0004359F File Offset: 0x0004179F
	internal 373 GetRecoveredType244710407_13468()
	{
		return this._recoveredType244710407;
	}

	// Token: 0x0600131F RID: 4895 RVA: 0x000435A8 File Offset: 0x000417A8
	internal static bool Method13469(688[] 1, int 2, bool 3, WaitHandle 4)
	{
		if (1.Length == 0)
		{
			return true;
		}
		WaitHandle[] array = new WaitHandle[1.Length];
		802.Method13471(1, array);
		bool result;
		if (4 == null && array.Length <= 64)
		{
			result = 922.WaitAll(array, 2, 3);
		}
		else
		{
			result = true;
			int num = 2;
			801 5 = 801.Method13416();
			WaitHandle[] array2;
			if (4 != null)
			{
				(array2 = new WaitHandle[2])[1] = 4;
			}
			else
			{
				array2 = new WaitHandle[1];
			}
			WaitHandle[] array3 = array2;
			bool flag = -1 == 2;
			for (int i = 0; i < 1.Length; i++)
			{
				if (!flag && num < 0)
				{
					result = false;
					break;
				}
				array3[0] = array[i];
				int num2 = 922.Method5095(array3, num, 3);
				if (num2 > 0 || -1 == num2)
				{
					result = false;
					break;
				}
				if (!flag)
				{
					num = 2 - (int)5.Method13419();
				}
			}
		}
		802.Method13472(1);
		return result;
	}

	// Token: 0x06001320 RID: 4896 RVA: 0x0004365C File Offset: 0x0004185C
	internal static int Method13470(688[] 1, int 2, bool 3, WaitHandle 4)
	{
		WaitHandle[] array;
		if (4 != null)
		{
			array = new WaitHandle[1.Length + 1];
			802.Method13471(1, array);
			array[1.Length] = 4;
		}
		else
		{
			array = new WaitHandle[1.Length];
			802.Method13471(1, array);
		}
		int num = 922.Method5095(array, 2, 3);
		if (4 != null && num == 1.Length)
		{
			num = -1;
		}
		802.Method13472(1);
		return num;
	}

	// Token: 0x06001321 RID: 4897 RVA: 0x000436B4 File Offset: 0x000418B4
	private static void Method13471(688[] 1, WaitHandle[] 2)
	{
		for (int i = 0; i < 1.Length; i++)
		{
			802.804 3 = 1[i].Method13445() as 802.804;
			2[i] = 3.GetRecoveredType244510398_13422().Method13480();
		}
	}

	// Token: 0x06001322 RID: 4898 RVA: 0x000436EC File Offset: 0x000418EC
	private static void Method13472(688[] 1)
	{
		for (int i = 0; i < 1.Length; i++)
		{
			((802.804)1[i].Method13445()).GetRecoveredType244510398_13422().Method13481();
		}
	}

	// Token: 0x06001323 RID: 4899 RVA: 0x00043720 File Offset: 0x00041920
	private 802.803 Method13473()
	{
		802.803 result;
		lock (this)
		{
			if ((802.803)2 == this._recoveredType244610404)
			{
				result = this._recoveredType244610404;
			}
			else
			{
				long ticks = DateTime.UtcNow.Ticks;
				if ((802.803)3 != this._recoveredType244610404 && ticks > this.number3)
				{
					this._recoveredType244610404 = (802.803)3;
				}
				if ((802.803)1 == this._recoveredType244610404)
				{
					result = this._recoveredType244610404;
				}
				else if (this.GetRecoveredType089410412_13459().GetIsCanceled() || this.GetRecoveredType089410411_13457().GetIsCanceled())
				{
					result = (802.803)3;
				}
				else
				{
					result = this._recoveredType244610404;
				}
			}
		}
		return result;
	}

	// Token: 0x06001324 RID: 4900 RVA: 0x000437C8 File Offset: 0x000419C8
	private void Method13474(802.803 1)
	{
		lock (this)
		{
			if (802.Method13447(this._recoveredType244610404, 1))
			{
				this._recoveredType244610404 = 1;
			}
		}
	}

	// Token: 0x06001325 RID: 4901 RVA: 0x00043814 File Offset: 0x00041A14
	private void Method13475(bool 1)
	{
		this.Method13474(1 ? ((802.803)3) : ((802.803)2));
		lock (this)
		{
			if (this.manualResetEvent != null)
			{
				this.manualResetEvent.Set();
			}
		}
	}

	// Token: 0x06001326 RID: 4902 RVA: 0x0004386C File Offset: 0x00041A6C
	internal void Method13476()
	{
		this._recoveredType244310416.Method13415();
	}

	// Token: 0x06001327 RID: 4903 RVA: 0x0004387C File Offset: 0x00041A7C
	private bool Method13477(bool 1)
	{
		bool result = false;
		bool flag = false;
		lock (this)
		{
			switch (this.Method13473())
			{
			case (802.803)0:
				flag = true;
				result = true;
				break;
			case (802.803)1:
				if (1)
				{
					Thread thread = Interlocked.CompareExchange<Thread>(ref this.thread2, null, this.thread2);
					if (thread != null)
					{
						thread.Abort();
						result = true;
						flag = true;
					}
				}
				else
				{
					result = true;
					flag = true;
				}
				break;
			case (802.803)3:
				if (1)
				{
					Thread thread2 = Interlocked.CompareExchange<Thread>(ref this.thread2, null, this.thread2);
					if (thread2 != null)
					{
						thread2.Abort();
					}
				}
				result = true;
				break;
			}
			if (flag)
			{
				this.Method13475(true);
			}
		}
		return result;
	}

	// Token: 0x06001328 RID: 4904 RVA: 0x00043938 File Offset: 0x00041B38
	private object Method13478(int 1, bool 2, WaitHandle 3)
	{
		Exception ex;
		object result = this.Method13478(1, 2, 3, out ex);
		if (ex != null)
		{
			throw new 439("The work item caused an excpetion, see the inner exception for details", ex);
		}
		return result;
	}

	// Token: 0x06001329 RID: 4905 RVA: 0x00043960 File Offset: 0x00041B60
	private object Method13478(int 1, bool 2, WaitHandle 3, out Exception 4)
	{
		4 = null;
		if ((802.803)3 == this.Method13473())
		{
			throw new 391("Work item canceled");
		}
		if (this.Method13482())
		{
			4 = this.exception2;
			return this.value3;
		}
		if (3 == null)
		{
			bool flag = !922.WaitOne(this.Method13480(), 1, 2);
			this.Method13481();
			if (flag)
			{
				throw new 474("Work item timeout");
			}
		}
		else
		{
			WaitHandle waitHandle = this.Method13480();
			int num = 922.Method5095(new WaitHandle[]
			{
				waitHandle,
				3
			});
			this.Method13481();
			if (num == -1 || num == 1)
			{
				throw new 474("Work item timeout");
			}
		}
		if ((802.803)3 == this.Method13473())
		{
			throw new 391("Work item canceled");
		}
		4 = this.exception2;
		return this.value3;
	}

	// Token: 0x0600132A RID: 4906 RVA: 0x00043A1C File Offset: 0x00041C1C
	private WaitHandle Method13480()
	{
		lock (this)
		{
			if (this.manualResetEvent == null)
			{
				this.manualResetEvent = 595.Method8117(this.Method13482());
			}
			this.number2++;
		}
		return this.manualResetEvent;
	}

	// Token: 0x0600132B RID: 4907 RVA: 0x00043A80 File Offset: 0x00041C80
	private void Method13481()
	{
		lock (this)
		{
			if (this.manualResetEvent != null)
			{
				this.number2--;
				if (this.number2 == 0)
				{
					this.manualResetEvent.Close();
					this.manualResetEvent = null;
				}
			}
		}
	}

	// Token: 0x0600132C RID: 4908 RVA: 0x00043AE8 File Offset: 0x00041CE8
	private bool Method13482()
	{
		bool result;
		lock (this)
		{
			802.803 <<EMPTY_NAME>> = this.Method13473();
			result = (<<EMPTY_NAME>> == (802.803)2 || <<EMPTY_NAME>> == (802.803)3);
		}
		return result;
	}

	// Token: 0x0600132D RID: 4909 RVA: 0x00043B34 File Offset: 0x00041D34
	public bool Method13483()
	{
		bool result;
		lock (this)
		{
			result = (this.Method13473() == (802.803)3);
		}
		return result;
	}

	// Token: 0x0600132E RID: 4910 RVA: 0x00043B74 File Offset: 0x00041D74
	public 639 Method13484()
	{
		return this.workItemInfo2.GetWorkItemPriority();
	}

	// Token: 0x0600132F RID: 4911 RVA: 0x00043B81 File Offset: 0x00041D81
	internal void Method13485(762 1)
	{
		this.Method13448(1);
	}

	// Token: 0x06001330 RID: 4912 RVA: 0x00043B8A File Offset: 0x00041D8A
	internal void Method13486(762 1)
	{
		this.Method13449(1);
	}

	// Token: 0x06001331 RID: 4913 RVA: 0x00043B93 File Offset: 0x00041D93
	internal void Method13487(762 1)
	{
		this.Method13450(1);
	}

	// Token: 0x06001332 RID: 4914 RVA: 0x00043B9C File Offset: 0x00041D9C
	internal void Method13488(762 1)
	{
		this.Method13451(1);
	}

	// Token: 0x06001333 RID: 4915 RVA: 0x00043BA8 File Offset: 0x00041DA8
	public void Method13489()
	{
		if (this.workItemInfo2.GetFlag7371_9485())
		{
			IDisposable disposable = this.value2 as IDisposable;
			if (disposable != null)
			{
				disposable.Dispose();
				this.value2 = null;
			}
		}
	}

	// Token: 0x04000913 RID: 2323
	private readonly 454 _recoveredType072410399;

	// Token: 0x04000914 RID: 2324
	private object value2;

	// Token: 0x04000915 RID: 2325
	private readonly 404 _recoveredType048510401;

	// Token: 0x04000916 RID: 2326
	private object value3;

	// Token: 0x04000917 RID: 2327
	private Exception exception2;

	// Token: 0x04000918 RID: 2328
	private 802.803 _recoveredType244610404;

	// Token: 0x04000919 RID: 2329
	private ManualResetEvent manualResetEvent;

	// Token: 0x0400091A RID: 2330
	private int number2;

	// Token: 0x0400091B RID: 2331
	private readonly 802.804 _recoveredType244710407;

	// Token: 0x0400091C RID: 2332
	private readonly 969 workItemInfo2;

	// Token: 0x0400091D RID: 2333
	private 762 _recoveredType225510409;

	// Token: 0x0400091E RID: 2334
	private 762 _recoveredType225510410;

	// Token: 0x0400091F RID: 2335
	private 43 canceledSmartThreadPool2 = 43.canceledSmartThreadPool;

	// Token: 0x04000920 RID: 2336
	private 43 canceledSmartThreadPool3 = 43.canceledSmartThreadPool;

	// Token: 0x04000921 RID: 2337
	private readonly 103 iWorkItemsGroup2;

	// Token: 0x04000922 RID: 2338
	private Thread thread2;

	// Token: 0x04000923 RID: 2339
	private long number3;

	// Token: 0x04000924 RID: 2340
	private 801 _recoveredType244310416;

	// Token: 0x04000925 RID: 2341
	private 801 _recoveredType244310417;

	// Token: 0x02000277 RID: 631
	public enum 803
	{

	}

	// Token: 0x02000278 RID: 632
	public sealed class 804 : 373, 486<object>, 688, 792, 488
	{
		// Token: 0x06001334 RID: 4916 RVA: 0x00043BDE File Offset: 0x00041DDE
		public 804(802 1)
		{
			this._recoveredType244510398 = 1;
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x00043BED File Offset: 0x00041DED
		internal 802 GetRecoveredType244510398_13422()
		{
			return this._recoveredType244510398;
		}

		// Token: 0x06001336 RID: 4918 RVA: 0x00043BF5 File Offset: 0x00041DF5
		public bool Method13423()
		{
			return this._recoveredType244510398.Method13482();
		}

		// Token: 0x06001337 RID: 4919 RVA: 0x00043C02 File Offset: 0x00041E02
		public bool Method13424()
		{
			return this._recoveredType244510398.Method13483();
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x00043C0F File Offset: 0x00041E0F
		public object Method134252()
		{
			return this._recoveredType244510398.Method13478(-1, true, null);
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x00043C1F File Offset: 0x00041E1F
		public object Method134252(int 1, bool 2)
		{
			return this._recoveredType244510398.Method13478(1, 2, null);
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x00043C2F File Offset: 0x00041E2F
		public object Method134252(TimeSpan 1, bool 2)
		{
			return this._recoveredType244510398.Method13478((int)1.TotalMilliseconds, 2, null);
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x00043C46 File Offset: 0x00041E46
		public object Method134252(int 1, bool 2, WaitHandle 3)
		{
			return this._recoveredType244510398.Method13478(1, 2, 3);
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x00043C56 File Offset: 0x00041E56
		public object Method134252(TimeSpan 1, bool 2, WaitHandle 3)
		{
			return this._recoveredType244510398.Method13478((int)1.TotalMilliseconds, 2, 3);
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x00043C6D File Offset: 0x00041E6D
		public object Method134252(out Exception 1)
		{
			return this._recoveredType244510398.Method13478(-1, true, null, out 1);
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x00043C7E File Offset: 0x00041E7E
		public object Method134252(int 1, bool 2, out Exception 3)
		{
			return this._recoveredType244510398.Method13478(1, 2, null, out 3);
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x00043C8F File Offset: 0x00041E8F
		public object Method134252(TimeSpan 1, bool 2, out Exception 3)
		{
			return this._recoveredType244510398.Method13478((int)1.TotalMilliseconds, 2, null, out 3);
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x00043CA7 File Offset: 0x00041EA7
		public object Method134252(int 1, bool 2, WaitHandle 3, out Exception 4)
		{
			return this._recoveredType244510398.Method13478(1, 2, 3, out 4);
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x00043CB9 File Offset: 0x00041EB9
		public object Method134252(TimeSpan 1, bool 2, WaitHandle 3, out Exception 4)
		{
			return this._recoveredType244510398.Method13478((int)1.TotalMilliseconds, 2, 3, out 4);
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x00043CD2 File Offset: 0x00041ED2
		public bool Method134352()
		{
			return this.Method134352(false);
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x00043CDB File Offset: 0x00041EDB
		public bool Method134352(bool 1)
		{
			return this._recoveredType244510398.Method13477(1);
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x00043CE9 File Offset: 0x00041EE9
		public object GetValue10400_13437()
		{
			return this._recoveredType244510398.value2;
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x00043CF6 File Offset: 0x00041EF6
		public 639 Method13438()
		{
			return this._recoveredType244510398.workItemInfo2.GetWorkItemPriority();
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x00043D08 File Offset: 0x00041F08
		public object Method13439()
		{
			return this.Method134252();
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x00043D10 File Offset: 0x00041F10
		public object GetException10403_13440()
		{
			return this._recoveredType244510398.exception2;
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x00043D1D File Offset: 0x00041F1D
		public void Method13441(762 1)
		{
			this._recoveredType244510398.Method13485(1);
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x00043D2B File Offset: 0x00041F2B
		public void Method13442(762 1)
		{
			this._recoveredType244510398.Method13486(1);
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x00043D39 File Offset: 0x00041F39
		public void Method13443(762 1)
		{
			this._recoveredType244510398.Method13487(1);
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x00043D47 File Offset: 0x00041F47
		public void Method13444(762 1)
		{
			this._recoveredType244510398.Method13488(1);
		}

		// Token: 0x0600134C RID: 4940 RVA: 0x00043D55 File Offset: 0x00041F55
		public 373 Method13445()
		{
			return this;
		}

		// Token: 0x0600134D RID: 4941 RVA: 0x00043D58 File Offset: 0x00041F58
		public 486<TResult> Method13446<TResult>()
		{
			return new 384<TResult>(this);
		}

		// Token: 0x04000927 RID: 2343
		private readonly 802 _recoveredType244510398;
	}
}
