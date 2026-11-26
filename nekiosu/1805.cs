using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;

// Token: 0x02000878 RID: 2168
public sealed class 1805
{
	// Token: 0x06003E97 RID: 16023
	[DllImport("user32.dll")]
	private static extern bool EnumDisplaySettings(string 1, int 2, ref 1805.1806 3);

	// Token: 0x06003E98 RID: 16024
	[DllImport("user32.dll")]
	public static extern int ChangeDisplaySettingsEx(string 1, ref 1805.1806 2, IntPtr 3, int 4, IntPtr 5);

	// Token: 0x06003E99 RID: 16025
	[DllImport("user32.dll")]
	public static extern int ChangeDisplaySettingsEx(string 1, IntPtr 2, IntPtr 3, int 4, IntPtr 5);

	// Token: 0x06003E9A RID: 16026
	[DllImport("user32.dll")]
	private static extern bool GetMonitorInfo(IntPtr 1, ref 1805.1807 2);

	// Token: 0x06003E9B RID: 16027
	[DllImport("user32.dll")]
	private static extern IntPtr MonitorFromWindow(IntPtr 1, uint 2);

	// Token: 0x06003E9C RID: 16028 RVA: 0x001869C4 File Offset: 0x00184BC4
	public static bool 1(int 1, int 2, int? 3, bool 4)
	{
		1805.1807 5 = new 1805.1807
		{
			1 = 72
		};
		1805.GetMonitorInfo(1805.MonitorFromWindow(1662.11.4().GetWindowHandle(), 2U), ref 5);
		1805.1806 6 = default(1805.1806);
		6.4 = (short)Marshal.SizeOf(6);
		if (!1805.EnumDisplaySettings(5.5, -1, ref 6))
		{
			return false;
		}
		if (6.23 == 1 && 6.24 == 2 && (3 == null || 3.Value == 6.26))
		{
			return true;
		}
		6.23 = 1;
		6.24 = 2;
		6.6 = 1572864;
		if (3 != null)
		{
			6.26 = 3.Value;
			6.6 |= 4194304;
		}
		bool flag = 1805.ChangeDisplaySettingsEx(5.5, ref 6, IntPtr.Zero, 2, IntPtr.Zero) == 0;
		if (4)
		{
			return flag;
		}
		return flag & 1805.ChangeDisplaySettingsEx(5.5, ref 6, IntPtr.Zero, 4, IntPtr.Zero) == 0;
	}

	// Token: 0x06003E9D RID: 16029 RVA: 0x00186AE0 File Offset: 0x00184CE0
	public static bool 2()
	{
		1805.1807 <<EMPTY_NAME>> = new 1805.1807
		{
			1 = 72
		};
		1805.GetMonitorInfo(1805.MonitorFromWindow(1662.11.4().GetWindowHandle(), 2U), ref <<EMPTY_NAME>>);
		1805.1806 2 = default(1805.1806);
		2.4 = (short)Marshal.SizeOf(2);
		1805.1806 3 = default(1805.1806);
		3.4 = (short)Marshal.SizeOf(3);
		return 1805.EnumDisplaySettings(<<EMPTY_NAME>>.5, -1, ref 2) && 1805.EnumDisplaySettings(<<EMPTY_NAME>>.5, -2, ref 3) && ((2.23 == 3.23 && 2.24 == 3.24 && 2.26 == 3.26) || 1805.ChangeDisplaySettingsEx(<<EMPTY_NAME>>.5, IntPtr.Zero, IntPtr.Zero, 0, IntPtr.Zero) == 0);
	}

	// Token: 0x06003E9E RID: 16030 RVA: 0x00186BC0 File Offset: 0x00184DC0
	internal static List<Size> 3()
	{
		1805.1807 <<EMPTY_NAME>> = new 1805.1807
		{
			1 = 72
		};
		1805.GetMonitorInfo(1805.MonitorFromWindow(1662.11.4().GetWindowHandle(), 2U), ref <<EMPTY_NAME>>);
		List<Size> list = new List<Size>();
		1805.1806 2 = default(1805.1806);
		int num = 0;
		while (1805.EnumDisplaySettings(<<EMPTY_NAME>>.5, num++, ref 2))
		{
			list.Add(new Size(2.23, 2.24));
		}
		return list;
	}

	// Token: 0x06003E9F RID: 16031 RVA: 0x00186C3C File Offset: 0x00184E3C
	internal static Size 4()
	{
		List<Size> list = 1805.3();
		Size result = new Size(640, 480);
		foreach (Size size in list)
		{
			if (size.Width > result.Width || (size.Width == result.Width && size.Height > result.Height))
			{
				result = size;
			}
		}
		return result;
	}

	// Token: 0x06003EA0 RID: 16032 RVA: 0x00186CCC File Offset: 0x00184ECC
	private static 1805.1806? 5()
	{
		1805.1807 <<EMPTY_NAME>> = new 1805.1807
		{
			1 = 72
		};
		1805.GetMonitorInfo(1805.MonitorFromWindow(1662.11.4().GetWindowHandle(), 2U), ref <<EMPTY_NAME>>);
		1805.1806 2 = default(1805.1806);
		2.4 = (short)Marshal.SizeOf(2);
		if (!1805.EnumDisplaySettings(<<EMPTY_NAME>>.5, -1, ref 2))
		{
			return null;
		}
		return new 1805.1806?(2);
	}

	// Token: 0x06003EA1 RID: 16033 RVA: 0x00186D44 File Offset: 0x00184F44
	internal static int 6()
	{
		1805.1806? <<EMPTY_NAME>> = 1805.5();
		if (<<EMPTY_NAME>> == null)
		{
			return 0;
		}
		return <<EMPTY_NAME>>.Value.26;
	}

	// Token: 0x06003EA2 RID: 16034 RVA: 0x00186D70 File Offset: 0x00184F70
	internal static Size 7()
	{
		1805.1807 <<EMPTY_NAME>> = new 1805.1807
		{
			1 = 40
		};
		1805.GetMonitorInfo(1805.MonitorFromWindow(1662.11.4().GetWindowHandle(), 2U), ref <<EMPTY_NAME>>);
		return new Size(<<EMPTY_NAME>>.2.3 - <<EMPTY_NAME>>.2.1, <<EMPTY_NAME>>.2.4 - <<EMPTY_NAME>>.2.2);
	}

	// Token: 0x06003EA3 RID: 16035 RVA: 0x00186DE0 File Offset: 0x00184FE0
	internal static Point 8()
	{
		1805.1807 <<EMPTY_NAME>> = new 1805.1807
		{
			1 = 40
		};
		1805.GetMonitorInfo(1805.MonitorFromWindow(1662.11.4().GetWindowHandle(), 2U), ref <<EMPTY_NAME>>);
		return new Point(<<EMPTY_NAME>>.2.1, <<EMPTY_NAME>>.2.2);
	}

	// Token: 0x02000879 RID: 2169
	public struct 1806
	{
		// Token: 0x04002DC8 RID: 11720
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string 1;

		// Token: 0x04002DC9 RID: 11721
		public short 2;

		// Token: 0x04002DCA RID: 11722
		public short 3;

		// Token: 0x04002DCB RID: 11723
		public short 4;

		// Token: 0x04002DCC RID: 11724
		public short 5;

		// Token: 0x04002DCD RID: 11725
		public int 6;

		// Token: 0x04002DCE RID: 11726
		public short 7;

		// Token: 0x04002DCF RID: 11727
		public short 8;

		// Token: 0x04002DD0 RID: 11728
		public short 9;

		// Token: 0x04002DD1 RID: 11729
		public short 10;

		// Token: 0x04002DD2 RID: 11730
		public short 11;

		// Token: 0x04002DD3 RID: 11731
		public short 12;

		// Token: 0x04002DD4 RID: 11732
		public short 13;

		// Token: 0x04002DD5 RID: 11733
		public short 14;

		// Token: 0x04002DD6 RID: 11734
		public short 15;

		// Token: 0x04002DD7 RID: 11735
		public short 16;

		// Token: 0x04002DD8 RID: 11736
		public short 17;

		// Token: 0x04002DD9 RID: 11737
		public short 18;

		// Token: 0x04002DDA RID: 11738
		public short 19;

		// Token: 0x04002DDB RID: 11739
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string 20;

		// Token: 0x04002DDC RID: 11740
		public short 21;

		// Token: 0x04002DDD RID: 11741
		public short 22;

		// Token: 0x04002DDE RID: 11742
		public int 23;

		// Token: 0x04002DDF RID: 11743
		public int 24;

		// Token: 0x04002DE0 RID: 11744
		public int 25;

		// Token: 0x04002DE1 RID: 11745
		public int 26;

		// Token: 0x04002DE2 RID: 11746
		public int 27;

		// Token: 0x04002DE3 RID: 11747
		public int 28;

		// Token: 0x04002DE4 RID: 11748
		public int 29;

		// Token: 0x04002DE5 RID: 11749
		public int 30;

		// Token: 0x04002DE6 RID: 11750
		public int 31;

		// Token: 0x04002DE7 RID: 11751
		public int 32;

		// Token: 0x04002DE8 RID: 11752
		public int 33;

		// Token: 0x04002DE9 RID: 11753
		public int 34;
	}

	// Token: 0x0200087A RID: 2170
	public struct 1808
	{
		// Token: 0x04002DEA RID: 11754
		public int 1;

		// Token: 0x04002DEB RID: 11755
		public int 2;

		// Token: 0x04002DEC RID: 11756
		public int 3;

		// Token: 0x04002DED RID: 11757
		public int 4;
	}

	// Token: 0x0200087B RID: 2171
	public struct 1807
	{
		// Token: 0x04002DEE RID: 11758
		public int 1;

		// Token: 0x04002DEF RID: 11759
		public 1805.1808 2;

		// Token: 0x04002DF0 RID: 11760
		public 1805.1808 3;

		// Token: 0x04002DF1 RID: 11761
		public uint 4;

		// Token: 0x04002DF2 RID: 11762
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string 5;
	}
}
