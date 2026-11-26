using System;

// Token: 0x0200025E RID: 606
public sealed class 428 : 812, IDisposable
{
	// Token: 0x06001277 RID: 4727 RVA: 0x000423FC File Offset: 0x000405FC
	public 428(string 1)
	{
		this.flag2 = false;
		this.performanceCounterInstanceArray = new 278[14];
		367.GetRecoveredType03201209_1814().GetHashCode();
		for (int i = 0; i < this.performanceCounterInstanceArray.Length; i++)
		{
			if (1 != null)
			{
				this.performanceCounterInstanceArray[i] = new 278(1, (389)i);
			}
			else
			{
				this.performanceCounterInstanceArray[i] = 428.performanceCounterInstance;
			}
		}
	}

	// Token: 0x06001278 RID: 4728 RVA: 0x00042464 File Offset: 0x00040664
	public void Method8121()
	{
		if (this.performanceCounterInstanceArray == null)
		{
			return;
		}
		for (int i = 0; i < this.performanceCounterInstanceArray.Length; i++)
		{
			if (this.performanceCounterInstanceArray[i] != null)
			{
				this.performanceCounterInstanceArray[i].Dispose();
			}
		}
		this.performanceCounterInstanceArray = null;
	}

	// Token: 0x06001279 RID: 4729 RVA: 0x000424AB File Offset: 0x000406AB
	public void Dispose()
	{
		this.Method3443(true);
	}

	// Token: 0x0600127A RID: 4730 RVA: 0x000424B4 File Offset: 0x000406B4
	public void Method3443(bool 1)
	{
		if (!this.flag2 && 1)
		{
			this.Method8121();
		}
		this.flag2 = true;
	}

	// Token: 0x0600127B RID: 4731 RVA: 0x000424D0 File Offset: 0x000406D0
	private 278 Method3444(389 1)
	{
		return this.performanceCounterInstanceArray[(int)1];
	}

	// Token: 0x0600127C RID: 4732 RVA: 0x000424DC File Offset: 0x000406DC
	public void Method8126(long 1, long 2)
	{
		this.Method3444((389)0).Set(1);
		this.Method3444((389)1).Set(2);
		this.Method3444((389)2).Set(1 - 2);
		this.Method3444((389)4).Set(1 - 2);
		this.Method3444((389)3).Set(2);
	}

	// Token: 0x0600127D RID: 4733 RVA: 0x00042530 File Offset: 0x00040730
	public void Method8127(long 1, long 2)
	{
		this.Method3444((389)5).Set(1 + 2);
		this.Method3444((389)6).Set(1);
		this.Method3444((389)7).Set(2);
		this.Method3444((389)8).Set(1);
		this.Method3444((389)9).Set(2);
	}

	// Token: 0x0600127E RID: 4734 RVA: 0x00042581 File Offset: 0x00040781
	public void Method8128(TimeSpan 1)
	{
		this.Method3444((389)10).IncrementBy((long)1.TotalMilliseconds);
		this.Method3444((389)11).Increment();
	}

	// Token: 0x0600127F RID: 4735 RVA: 0x000425A5 File Offset: 0x000407A5
	public void Method8129(TimeSpan 1)
	{
		this.Method3444((389)12).IncrementBy((long)1.TotalMilliseconds);
		this.Method3444((389)13).Increment();
	}

	// Token: 0x040008EC RID: 2284
	private bool flag2;

	// Token: 0x040008ED RID: 2285
	private 278[] performanceCounterInstanceArray;

	// Token: 0x040008EE RID: 2286
	private static readonly 278 performanceCounterInstance = new 816();
}
