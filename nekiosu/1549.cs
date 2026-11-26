using System;
using System.Collections.Generic;
using System.Threading;

// Token: 0x02000A5B RID: 2651
public sealed class 1549 : 1083
{
	// Token: 0x06004941 RID: 18753 RVA: 0x001D23C0 File Offset: 0x001D05C0
	internal static void 1(1549.1550 1)
	{
		1549.1550 2 = 1549.4;
		1549.1550 3;
		do
		{
			3 = 2;
			1549.1550 value = (1549.1550)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1549.1550>(ref 1549.4, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06004942 RID: 18754 RVA: 0x001D23F4 File Offset: 0x001D05F4
	internal static void 2(1549.1550 1)
	{
		1549.1550 2 = 1549.4;
		1549.1550 3;
		do
		{
			3 = 2;
			1549.1550 value = (1549.1550)Delegate.Remove(3, 1);
			2 = Interlocked.CompareExchange<1549.1550>(ref 1549.4, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06004943 RID: 18755 RVA: 0x001D2428 File Offset: 0x001D0628
	internal static void 3(1549.1550 1)
	{
		1549.1550 2 = 1549.5;
		1549.1550 3;
		do
		{
			3 = 2;
			1549.1550 value = (1549.1550)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1549.1550>(ref 1549.5, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06004944 RID: 18756 RVA: 0x001D245C File Offset: 0x001D065C
	internal static void 4(1549.1550 1)
	{
		1549.1550 2 = 1549.5;
		1549.1550 3;
		do
		{
			3 = 2;
			1549.1550 value = (1549.1550)Delegate.Remove(3, 1);
			2 = Interlocked.CompareExchange<1549.1550>(ref 1549.5, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06004945 RID: 18757 RVA: 0x001D2490 File Offset: 0x001D0690
	internal static void 5(1549.1551 1)
	{
		1549.1551 2 = 1549.6;
		1549.1551 3;
		do
		{
			3 = 2;
			1549.1551 value = (1549.1551)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1549.1551>(ref 1549.6, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06004946 RID: 18758 RVA: 0x001D24C4 File Offset: 0x001D06C4
	internal static void 6(1549.1551 1)
	{
		1549.1551 2 = 1549.6;
		1549.1551 3;
		do
		{
			3 = 2;
			1549.1551 value = (1549.1551)Delegate.Remove(3, 1);
			2 = Interlocked.CompareExchange<1549.1551>(ref 1549.6, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06004947 RID: 18759 RVA: 0x001D24F8 File Offset: 0x001D06F8
	internal static bool 7(200 1)
	{
		if (1549.9(1, true))
		{
			return true;
		}
		if (1549.4 != null)
		{
			Delegate[] array = 1549.4.GetInvocationList();
			if (1549.1 && 1549.3)
			{
				List<Delegate> list = new List<Delegate>(array);
				list.Reverse();
				array = list.ToArray();
			}
			if (array.Length == 0)
			{
				return false;
			}
			for (int i = array.Length - 1; i >= 0; i--)
			{
				1549.1550 2 = array[i] as 1549.1550;
				if (2 != null && (bool)2.DynamicInvoke(new object[]
				{
					null,
					1
				}))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06004948 RID: 18760 RVA: 0x001D2584 File Offset: 0x001D0784
	internal static void 8(200 1)
	{
		if (1549.5 == null)
		{
			return;
		}
		Delegate[] array = 1549.5.GetInvocationList();
		if (1549.1 && 1549.3)
		{
			List<Delegate> list = new List<Delegate>(array);
			list.Reverse();
			array = list.ToArray();
		}
		if (array.Length != 0)
		{
			for (int i = array.Length - 1; i >= 0; i--)
			{
				1549.1550 2 = array[i] as 1549.1550;
				if (2 != null && (bool)2.DynamicInvoke(new object[]
				{
					null,
					1
				}))
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004949 RID: 18761 RVA: 0x001D2600 File Offset: 0x001D0800
	internal static bool 9(200 1, bool 2)
	{
		if (1549.6 != null)
		{
			Delegate[] array = 1549.6.GetInvocationList();
			if (1549.1 && 1549.3)
			{
				List<Delegate> list = new List<Delegate>(array);
				list.Reverse();
				array = list.ToArray();
			}
			if (array.Length == 0)
			{
				return false;
			}
			for (int i = array.Length - 1; i >= 0; i--)
			{
				1549.1551 3 = array[i] as 1549.1551;
				if (3 != null && (bool)3.DynamicInvoke(new object[]
				{
					null,
					1,
					2
				}))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600494A RID: 18762 RVA: 0x001D2689 File Offset: 0x001D0889
	internal static bool 10(200 1)
	{
		return 1 != 200.None && 1535.28.Contains(1);
	}

	// Token: 0x0600494B RID: 18763 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool Initialize()
	{
		return true;
	}

	// Token: 0x0600494C RID: 18764 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void Dispose()
	{
	}

	// Token: 0x0600494D RID: 18765 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void Update(bool 1)
	{
	}

	// Token: 0x0600494E RID: 18766 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal override bool IsActive()
	{
		return false;
	}

	// Token: 0x0600494F RID: 18767 RVA: 0x0001905A File Offset: 0x0001725A
	internal override int GetPriority()
	{
		return 2;
	}

	// Token: 0x040036B0 RID: 14000
	public static bool 1;

	// Token: 0x040036B1 RID: 14001
	public static bool 2;

	// Token: 0x040036B2 RID: 14002
	public static bool 3;

	// Token: 0x040036B3 RID: 14003
	private static 1549.1550 4;

	// Token: 0x040036B4 RID: 14004
	private static 1549.1550 5;

	// Token: 0x040036B5 RID: 14005
	private static 1549.1551 6;

	// Token: 0x02000A5C RID: 2652
	// (Invoke) Token: 0x06004952 RID: 18770
	public delegate bool 1550(object 1, 200 2);

	// Token: 0x02000A5D RID: 2653
	// (Invoke) Token: 0x06004956 RID: 18774
	public delegate bool 1551(object 1, 200 2, bool 3);
}
