using System;
using System.Threading;
using System.Windows.Forms;

// Token: 0x02000A5F RID: 2655
public abstract class 1553 : 1083
{
	// Token: 0x0600495B RID: 18779 RVA: 0x001D26F8 File Offset: 0x001D08F8
	internal override bool Initialize()
	{
		if (1553.4 == IntPtr.Zero)
		{
			1553.4 = 1662.13().Handle;
		}
		Mutex obj = 1553.2;
		lock (obj)
		{
			if (1553.5 == 0)
			{
				1553.3 = new 1136.1137.1138(1553.4);
				1553.3.1(new 1171(this.1));
				1553.1 = 1136.1137.1();
			}
			1553.5++;
		}
		return true;
	}

	// Token: 0x0600495C RID: 18780 RVA: 0x001D2794 File Offset: 0x001D0994
	internal override void Dispose()
	{
		Mutex obj = 1553.2;
		lock (obj)
		{
			1553.5--;
			if (1553.5 == 0)
			{
				1553.3.2();
				1553.4 = IntPtr.Zero;
			}
		}
	}

	// Token: 0x0600495D RID: 18781 RVA: 0x001D27F4 File Offset: 0x001D09F4
	internal override void OnWindowSizeChanged()
	{
		1553.1 = 1136.1137.1();
		base.OnWindowSizeChanged();
	}

	// Token: 0x0600495E RID: 18782 RVA: 0x001D2808 File Offset: 0x001D0A08
	private void 1(ref Message 1)
	{
		int msg = 1.Msg;
		if (msg != 255)
		{
			switch (msg)
			{
			case 581:
			case 582:
			case 583:
			case 585:
			case 586:
			case 588:
			case 590:
			case 591:
			{
				int num = 1.WParam.ToInt32() & 65535;
				1092 2;
				if (!1304.125.1() && 1136.GetPointerInfo(num, out 2) && 2.1 == (1094)2U)
				{
					if (1553.6 != null)
					{
						1553.6(2);
					}
					if (1662.11.2() && !1555.32)
					{
						1.Result = new IntPtr(-1);
					}
				}
				break;
			}
			case 584:
			case 587:
			case 589:
				break;
			default:
				return;
			}
		}
		else
		{
			int num2 = 40;
			1099 3;
			1136.GetRawInputData(1.LParam, (1134)268435459, out 3, ref num2, sizeof(1098));
			switch (3.1.1)
			{
			case (1100)0:
				if (1553.8 != null)
				{
					1553.8(3);
					return;
				}
				break;
			case (1100)1:
				if (1553.7 != null)
				{
					1553.7(3);
					return;
				}
				break;
			case (1100)2:
				if (1553.9 != null)
				{
					1553.9(3);
					return;
				}
				break;
			default:
				return;
			}
		}
	}

	// Token: 0x0600495F RID: 18783 RVA: 0x001D2944 File Offset: 0x001D0B44
	protected static void 2(1093 1)
	{
		1093 2 = 1553.6;
		1093 3;
		do
		{
			3 = 2;
			1093 value = (1093)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1093>(ref 1553.6, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06004960 RID: 18784 RVA: 0x001D2978 File Offset: 0x001D0B78
	protected static void 3(1093 1)
	{
		1093 2 = 1553.6;
		1093 3;
		do
		{
			3 = 2;
			1093 value = (1093)Delegate.Remove(3, 1);
			2 = Interlocked.CompareExchange<1093>(ref 1553.6, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06004961 RID: 18785 RVA: 0x001D29AC File Offset: 0x001D0BAC
	protected static void 4(1097 1)
	{
		1097 2 = 1553.8;
		1097 3;
		do
		{
			3 = 2;
			1097 value = (1097)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1097>(ref 1553.8, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06004962 RID: 18786 RVA: 0x001D29E0 File Offset: 0x001D0BE0
	protected static void 5(1097 1)
	{
		1097 2 = 1553.8;
		1097 3;
		do
		{
			3 = 2;
			1097 value = (1097)Delegate.Remove(3, 1);
			2 = Interlocked.CompareExchange<1097>(ref 1553.8, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x040036B6 RID: 14006
	protected static 207 1;

	// Token: 0x040036B7 RID: 14007
	private static Mutex 2 = new Mutex();

	// Token: 0x040036B8 RID: 14008
	private static 1136.1137.1138 3;

	// Token: 0x040036B9 RID: 14009
	protected static IntPtr 4 = IntPtr.Zero;

	// Token: 0x040036BA RID: 14010
	private static int 5 = 0;

	// Token: 0x040036BB RID: 14011
	private static 1093 6;

	// Token: 0x040036BC RID: 14012
	private static 1097 7;

	// Token: 0x040036BD RID: 14013
	private static 1097 8;

	// Token: 0x040036BE RID: 14014
	private static 1097 9;
}
