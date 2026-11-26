using System;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x0200026D RID: 621
public sealed class 606 : 970
{
	// Token: 0x060012D6 RID: 4822 RVA: 0x00042AF4 File Offset: 0x00040CF4
	public 606(915 1, int 2, 555 3)
	{
		if (2 <= 0)
		{
			throw new ArgumentOutOfRangeException("concurrency", 2, "concurrency must be greater than zero");
		}
		this.smartThreadPool2 = 1;
		this.number2 = 2;
		this._recoveredType12856513 = new 555(3).Method7504();
		this._recoveredType11016510 = new 526();
		base.SetName("WorkItemsGroup");
		this.number3 = this.number4;
		this.flag2 = this._recoveredType12856513.GetFlag5792_7498();
	}

	// Token: 0x060012D7 RID: 4823 RVA: 0x00042B98 File Offset: 0x00040D98
	private void Method8335(530 1)
	{
		530 2 = this._recoveredType11616507;
		530 3;
		do
		{
			3 = 2;
			530 value = (530)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<530>(ref this._recoveredType11616507, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x060012D8 RID: 4824 RVA: 0x00042BD0 File Offset: 0x00040DD0
	private void Method8336(530 1)
	{
		530 2 = this._recoveredType11616507;
		530 3;
		do
		{
			3 = 2;
			530 value = (530)Delegate.Remove(3, 1);
			2 = Interlocked.CompareExchange<530>(ref this._recoveredType11616507, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x060012D9 RID: 4825 RVA: 0x00042C05 File Offset: 0x00040E05
	public override int GetNumber6509_8337()
	{
		return this.number2;
	}

	// Token: 0x060012DA RID: 4826 RVA: 0x00042C10 File Offset: 0x00040E10
	public override void Method8338(int 1)
	{
		int num = 1 - this.number2;
		this.number2 = 1;
		if (num > 0)
		{
			this.Method8350(num);
		}
	}

	// Token: 0x060012DB RID: 4827 RVA: 0x00042C38 File Offset: 0x00040E38
	public override int GetNumber6512_8339()
	{
		return this.number4;
	}

	// Token: 0x060012DC RID: 4828 RVA: 0x00042C40 File Offset: 0x00040E40
	public override int Method8340()
	{
		return this._recoveredType11016510.GetNumber4843_6109();
	}

	// Token: 0x060012DD RID: 4829 RVA: 0x00042C50 File Offset: 0x00040E50
	public override object[] Method8341()
	{
		object obj = this.value2;
		object[] result;
		lock (obj)
		{
			object[] array = new object[this._recoveredType11016510.GetNumber4843_6109()];
			int num = 0;
			foreach (object obj2 in this._recoveredType11016510)
			{
				802 <<EMPTY_NAME>> = (802)obj2;
				array[num] = <<EMPTY_NAME>>.GetRecoveredType244710407_13468().GetValue10400_13437();
				num++;
			}
			result = array;
		}
		return result;
	}

	// Token: 0x060012DE RID: 4830 RVA: 0x00042D00 File Offset: 0x00040F00
	public override 555 GetRecoveredType12856513_8342()
	{
		return this._recoveredType12856513;
	}

	// Token: 0x060012DF RID: 4831 RVA: 0x00042D08 File Offset: 0x00040F08
	public override void Method8343()
	{
		if (this.flag2)
		{
			this.flag2 = false;
			this.Method8350(Math.Min(this._recoveredType11016510.GetNumber4843_6109(), this.number2));
		}
	}

	// Token: 0x060012E0 RID: 4832 RVA: 0x00042D38 File Offset: 0x00040F38
	public override void Method8344(bool 1)
	{
		object obj = this.value2;
		lock (obj)
		{
			this.canceledSmartThreadPool.SetIsCanceled(true);
			this._recoveredType11016510.Method6110();
			this.number3 = 0;
			this.canceledSmartThreadPool = new 43();
		}
		if (1)
		{
			this.smartThreadPool2.CancelRunningWorkItemsOfGroup(this);
		}
	}

	// Token: 0x060012E1 RID: 4833 RVA: 0x00042DAC File Offset: 0x00040FAC
	public override bool Method8345(int 1)
	{
		915.CheckWaitForGroupDeadlock(this);
		return 922.WaitOne(this.manualResetEvent, 1, false);
	}

	// Token: 0x060012E2 RID: 4834 RVA: 0x00042DC1 File Offset: 0x00040FC1
	public override void Method8346(530 1)
	{
		this.Method8335(1);
	}

	// Token: 0x060012E3 RID: 4835 RVA: 0x00042DCA File Offset: 0x00040FCA
	public override void Method8347(530 1)
	{
		this.Method8336(1);
	}

	// Token: 0x060012E4 RID: 4836 RVA: 0x00042DD3 File Offset: 0x00040FD3
	private void Method8348(373 1)
	{
		792 2 = (792)1;
		2.Method13441(new 762(this.Method8353));
		2.Method13443(new 762(this.Method8354));
	}

	// Token: 0x060012E5 RID: 4837 RVA: 0x00042DFE File Offset: 0x00040FFE
	public void Method8349()
	{
		if (!this.flag2)
		{
			this.Method8350(this.number2);
		}
	}

	// Token: 0x060012E6 RID: 4838 RVA: 0x00042E14 File Offset: 0x00041014
	public void Method8350(int 1)
	{
		for (int i = 0; i < 1; i++)
		{
			this.Method8356(null, false);
		}
	}

	// Token: 0x060012E7 RID: 4839 RVA: 0x00042E35 File Offset: 0x00041035
	private object Method8351(object 1)
	{
		this.Method8352(this._recoveredType11616507);
		return null;
	}

	// Token: 0x060012E8 RID: 4840 RVA: 0x00042E44 File Offset: 0x00041044
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Method8352(530 1)
	{
		if (1 == null)
		{
			return;
		}
		foreach (530 2 in 1.GetInvocationList())
		{
			try
			{
				2(this);
			}
			catch
			{
			}
		}
	}

	// Token: 0x060012E9 RID: 4841 RVA: 0x00042E90 File Offset: 0x00041090
	private void Method8353(802 1)
	{
		object obj = this.value2;
		lock (obj)
		{
			this.number4++;
		}
	}

	// Token: 0x060012EA RID: 4842 RVA: 0x00042ED8 File Offset: 0x000410D8
	private void Method8354(802 1)
	{
		this.Method8356(null, true);
	}

	// Token: 0x060012EB RID: 4843 RVA: 0x00042EE2 File Offset: 0x000410E2
	internal override void Enqueue(802 1)
	{
		this.Method8356(1);
	}

	// Token: 0x060012EC RID: 4844 RVA: 0x00042EEB File Offset: 0x000410EB
	private void Method8356(802 1)
	{
		this.Method8356(1, false);
	}

	// Token: 0x060012ED RID: 4845 RVA: 0x00042EF8 File Offset: 0x000410F8
	private void Method8356(802 1, bool 2)
	{
		object obj = this.value2;
		lock (obj)
		{
			if (2)
			{
				this.number3--;
				if (this.number3 < 0)
				{
					this.number3 = 0;
				}
				this.number4--;
				if (this.number4 < 0)
				{
					this.number4 = 0;
				}
			}
			if (1 != null)
			{
				1.SetRecoveredType089410411_13458(this.canceledSmartThreadPool);
				this.Method8348(1.GetRecoveredType244710407_13468());
				this._recoveredType11016510.Method6106(1);
				if (1 == this._recoveredType11016510.GetNumber4843_6109() && this.number3 == 0)
				{
					this.smartThreadPool2.RegisterWorkItemsGroup(this);
					base.SetFlag2902_3661(false);
					this.manualResetEvent.Reset();
				}
			}
			if (this._recoveredType11016510.GetNumber4843_6109() == 0)
			{
				if (this.number3 == 0)
				{
					this.smartThreadPool2.UnregisterWorkItemsGroup(this);
					base.SetFlag2902_3661(true);
					this.manualResetEvent.Set();
					if (2 && this._recoveredType11616507 != null && this._recoveredType11616507.GetInvocationList().Length != 0)
					{
						this.smartThreadPool2.Method36622(new 454(this.Method8351));
					}
				}
			}
			else if (!this.flag2 && this.number3 < this.number2)
			{
				802 3 = this._recoveredType11016510.Method6107() as 802;
				try
				{
					this.smartThreadPool2.Enqueue(3);
				}
				catch (ObjectDisposedException ex)
				{
					ex.GetHashCode();
				}
				this.number3++;
			}
		}
	}

	// Token: 0x04000907 RID: 2311
	private readonly object value2 = new object();

	// Token: 0x04000908 RID: 2312
	private readonly 915 smartThreadPool2;

	// Token: 0x04000909 RID: 2313
	private 530 _recoveredType11616507;

	// Token: 0x0400090A RID: 2314
	private bool flag2;

	// Token: 0x0400090B RID: 2315
	private int number2;

	// Token: 0x0400090C RID: 2316
	private readonly 526 _recoveredType11016510;

	// Token: 0x0400090D RID: 2317
	private int number3;

	// Token: 0x0400090E RID: 2318
	private int number4;

	// Token: 0x0400090F RID: 2319
	private readonly 555 _recoveredType12856513;

	// Token: 0x04000910 RID: 2320
	private readonly ManualResetEvent manualResetEvent = 595.Method8117(true);

	// Token: 0x04000911 RID: 2321
	private 43 canceledSmartThreadPool = new 43();
}
