using System;
using System.Threading;

// Token: 0x02000284 RID: 644
public sealed class 897 : 555
{
	// Token: 0x060013C0 RID: 5056 RVA: 0x000454D8 File Offset: 0x000436D8
	public 897()
	{
		this.text2 = 915.text;
		this.priority = ThreadPriority.Normal;
		this.maxWorkerThreads = 25;
		this.idleTimeout = 60000;
		this.minWorkerThreads = 0;
	}

	// Token: 0x060013C1 RID: 5057 RVA: 0x0004556C File Offset: 0x0004376C
	public 897(897 1) : base(1)
	{
		this.idleTimeout = 1.GetIdleTimeout();
		this.minWorkerThreads = 1.GetMinWorkerThreads();
		this.maxWorkerThreads = 1.GetMaxWorkerThreads();
		this.priority = 1.GetThreadPriority();
		this.text2 = 1.GetText7309_9339();
		this.flag9 = 1.flag9;
		this.text3 = 1.text3;
		this.flag8 = 1.GetFlag7310_9343();
		this.nullable3 = 1.GetNullable7314_9345();
		this.apartmentState2 = 1.apartmentState2;
		this.nullable2 = 1.nullable2;
	}

	// Token: 0x060013C2 RID: 5058 RVA: 0x00045658 File Offset: 0x00043858
	public int GetIdleTimeout()
	{
		return this.idleTimeout;
	}

	// Token: 0x060013C3 RID: 5059 RVA: 0x00045660 File Offset: 0x00043860
	public void SetIdleTimeout(int 1)
	{
		base.Method7487();
		this.idleTimeout = 1;
	}

	// Token: 0x060013C4 RID: 5060 RVA: 0x0004566F File Offset: 0x0004386F
	public int GetMinWorkerThreads()
	{
		return this.minWorkerThreads;
	}

	// Token: 0x060013C5 RID: 5061 RVA: 0x00045677 File Offset: 0x00043877
	public void SetMinWorkerThreads(int 1)
	{
		base.Method7487();
		this.minWorkerThreads = 1;
	}

	// Token: 0x060013C6 RID: 5062 RVA: 0x00045686 File Offset: 0x00043886
	public int GetMaxWorkerThreads()
	{
		return this.maxWorkerThreads;
	}

	// Token: 0x060013C7 RID: 5063 RVA: 0x0004568E File Offset: 0x0004388E
	public void SetMaxWorkerThreads(int 1)
	{
		base.Method7487();
		this.maxWorkerThreads = 1;
	}

	// Token: 0x060013C8 RID: 5064 RVA: 0x0004569D File Offset: 0x0004389D
	public ThreadPriority GetThreadPriority()
	{
		return this.priority;
	}

	// Token: 0x060013C9 RID: 5065 RVA: 0x000456A5 File Offset: 0x000438A5
	public void SetThreadPriority(ThreadPriority 1)
	{
		base.Method7487();
		this.priority = 1;
	}

	// Token: 0x060013CA RID: 5066 RVA: 0x000456B4 File Offset: 0x000438B4
	public string GetText7312_9337()
	{
		return this.text3;
	}

	// Token: 0x060013CB RID: 5067 RVA: 0x000456BC File Offset: 0x000438BC
	public void Method9338(string 1)
	{
		base.Method7487();
		this.text3 = 1;
	}

	// Token: 0x060013CC RID: 5068 RVA: 0x000456CB File Offset: 0x000438CB
	public string GetText7309_9339()
	{
		return this.text2;
	}

	// Token: 0x060013CD RID: 5069 RVA: 0x000456D3 File Offset: 0x000438D3
	public void Method9340(string 1)
	{
		base.Method7487();
		this.text2 = 1;
	}

	// Token: 0x060013CE RID: 5070 RVA: 0x000456E2 File Offset: 0x000438E2
	public bool GetFlag7311_9341()
	{
		return this.flag9;
	}

	// Token: 0x060013CF RID: 5071 RVA: 0x000456EA File Offset: 0x000438EA
	public void Method9342(bool 1)
	{
		base.Method7487();
		this.flag9 = 1;
	}

	// Token: 0x060013D0 RID: 5072 RVA: 0x000456F9 File Offset: 0x000438F9
	public bool GetFlag7310_9343()
	{
		return this.flag8;
	}

	// Token: 0x060013D1 RID: 5073 RVA: 0x00045701 File Offset: 0x00043901
	public void Method9344(bool 1)
	{
		base.Method7487();
		this.flag8 = 1;
	}

	// Token: 0x060013D2 RID: 5074 RVA: 0x00045710 File Offset: 0x00043910
	public int? GetNullable7314_9345()
	{
		return this.nullable3;
	}

	// Token: 0x060013D3 RID: 5075 RVA: 0x00045718 File Offset: 0x00043918
	public void Method9346(int? 1)
	{
		base.Method7487();
		this.nullable3 = 1;
	}

	// Token: 0x060013D4 RID: 5076 RVA: 0x00045727 File Offset: 0x00043927
	public 897 Method9347()
	{
		return new 897(this)
		{
			flag7 = true
		};
	}

	// Token: 0x060013D5 RID: 5077 RVA: 0x00045736 File Offset: 0x00043936
	public ApartmentState GetApartmentState7315_9348()
	{
		return this.apartmentState2;
	}

	// Token: 0x060013D6 RID: 5078 RVA: 0x0004573E File Offset: 0x0004393E
	public void Method9349(ApartmentState 1)
	{
		base.Method7487();
		this.apartmentState2 = 1;
	}

	// Token: 0x060013D7 RID: 5079 RVA: 0x0004574D File Offset: 0x0004394D
	public int? GetNullable7313_9350()
	{
		return this.nullable2;
	}

	// Token: 0x060013D8 RID: 5080 RVA: 0x00045755 File Offset: 0x00043955
	public void Method9351(int? 1)
	{
		base.Method7487();
		if (1 != null && 1.Value < 0)
		{
			throw new ArgumentOutOfRangeException("#=zUkSU2UA=", "Value must be greater than 0.");
		}
		this.nullable2 = 1;
	}

	// Token: 0x0400094C RID: 2380
	private int idleTimeout = 60000;

	// Token: 0x0400094D RID: 2381
	private int minWorkerThreads;

	// Token: 0x0400094E RID: 2382
	private int maxWorkerThreads = 25;

	// Token: 0x0400094F RID: 2383
	private ThreadPriority priority = ThreadPriority.Normal;

	// Token: 0x04000950 RID: 2384
	private string text2 = 915.text;

	// Token: 0x04000951 RID: 2385
	private bool flag8 = true;

	// Token: 0x04000952 RID: 2386
	private bool flag9;

	// Token: 0x04000953 RID: 2387
	private string text3 = "SmartThreadPool";

	// Token: 0x04000954 RID: 2388
	private int? nullable2 = 915.nullable2;

	// Token: 0x04000955 RID: 2389
	private int? nullable3 = 915.nullable3;

	// Token: 0x04000956 RID: 2390
	private ApartmentState apartmentState2 = ApartmentState.Unknown;
}
