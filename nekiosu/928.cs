using System;
using System.Runtime.InteropServices;
using OpenTK;

// Token: 0x020002A0 RID: 672
public sealed class 928 : IDisposable
{
	// Token: 0x06001470 RID: 5232 RVA: 0x00046E94 File Offset: 0x00045094
	internal 928(int 1)
	{
		this.requestedPeriod = 1;
		try
		{
			this.periodApplied = (928.timerCaps.maximumPeriod > 0 || 928.timeGetDevCaps(ref 928.timerCaps, Marshal.SizeOf(typeof(928.929))) == 0);
			this.periodApplied &= (928.timeBeginPeriod(MathHelper.Clamp(1, 928.timerCaps.minimumPeriod, 928.timerCaps.maximumPeriod)) == 0);
		}
		catch
		{
		}
	}

	// Token: 0x06001471 RID: 5233
	[DllImport("winmm.dll", ExactSpelling = true)]
	private static extern int timeGetDevCaps(ref 928.929 1, int 2);

	// Token: 0x06001472 RID: 5234
	[DllImport("winmm.dll", ExactSpelling = true)]
	private static extern int timeBeginPeriod(int 1);

	// Token: 0x06001473 RID: 5235
	[DllImport("winmm.dll", ExactSpelling = true)]
	private static extern int timeEndPeriod(int 1);

	// Token: 0x06001474 RID: 5236 RVA: 0x00046F24 File Offset: 0x00045124
	internal static int GetMinimumPeriod()
	{
		return 928.timerCaps.minimumPeriod;
	}

	// Token: 0x06001475 RID: 5237 RVA: 0x00046F30 File Offset: 0x00045130
	internal static int GetMaximumPeriod()
	{
		return 928.timerCaps.maximumPeriod;
	}

	// Token: 0x06001476 RID: 5238 RVA: 0x00046F3C File Offset: 0x0004513C
	public void Dispose()
	{
		if (!this.periodApplied)
		{
			return;
		}
		try
		{
			928.timeEndPeriod(this.requestedPeriod);
		}
		catch
		{
		}
	}

	// Token: 0x0400099B RID: 2459
	private static 928.929 timerCaps;

	// Token: 0x0400099C RID: 2460
	private readonly int requestedPeriod;

	// Token: 0x0400099D RID: 2461
	private bool periodApplied;

	// Token: 0x020002A1 RID: 673
	public struct 929
	{
		// Token: 0x0400099E RID: 2462
		internal int minimumPeriod;

		// Token: 0x0400099F RID: 2463
		internal int maximumPeriod;
	}
}
