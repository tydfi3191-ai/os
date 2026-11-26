using System;
using System.Diagnostics;

// Token: 0x02000260 RID: 608
public sealed class 443
{
	// Token: 0x06001284 RID: 4740 RVA: 0x000425C9 File Offset: 0x000407C9
	public 443(string 1, string 2, PerformanceCounterType 3)
	{
		this.text4 = 1;
		this.text3 = 2;
		this.performanceCounterType2 = 3;
	}

	// Token: 0x06001285 RID: 4741 RVA: 0x000425E8 File Offset: 0x000407E8
	public void Method3764(CounterCreationDataCollection 1)
	{
		CounterCreationData value = new CounterCreationData(this.text4, this.text3, this.performanceCounterType2);
		1.Add(value);
	}

	// Token: 0x06001286 RID: 4742 RVA: 0x00042615 File Offset: 0x00040815
	public string GetText2953_3765()
	{
		return this.text4;
	}

	// Token: 0x040008EF RID: 2287
	private readonly PerformanceCounterType performanceCounterType2;

	// Token: 0x040008F0 RID: 2288
	protected string text3;

	// Token: 0x040008F1 RID: 2289
	protected string text4;
}
