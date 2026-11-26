using System;
using System.Runtime.InteropServices;

// Token: 0x02000891 RID: 2193
public static class 1830
{
	// Token: 0x06003F00 RID: 16128 RVA: 0x00187510 File Offset: 0x00185710
	private static string 1()
	{
		return "\"" + 1345.1() + "\",1";
	}

	// Token: 0x06003F01 RID: 16129 RVA: 0x0001702D File Offset: 0x0001522D
	public static bool 2()
	{
		return true;
	}

	// Token: 0x06003F02 RID: 16130 RVA: 0x0001702D File Offset: 0x0001522D
	public static bool 3()
	{
		return true;
	}

	// Token: 0x06003F03 RID: 16131 RVA: 0x00005ADD File Offset: 0x00003CDD
	public static void 4()
	{
	}

	// Token: 0x06003F04 RID: 16132 RVA: 0x00005ADD File Offset: 0x00003CDD
	public static void 5()
	{
	}

	// Token: 0x06003F05 RID: 16133 RVA: 0x00005ADD File Offset: 0x00003CDD
	private static void 6()
	{
	}

	// Token: 0x06003F06 RID: 16134
	[DllImport("Shell32.dll")]
	private static extern void SHChangeNotify(1830.1833 1, 1830.1834 2, IntPtr 3, IntPtr 4);

	// Token: 0x04002E0F RID: 11791
	private static readonly string 1 = 1345.1().Replace('/', '\\');

	// Token: 0x04002E10 RID: 11792
	private static readonly 1830.1831 2 = new 1830.1831("osustable", "Software\\ppy\\osustable\\Capabilities", "osu!");

	// Token: 0x04002E11 RID: 11793
	private static readonly 1830.1832[] 3 = new 1830.1832[]
	{
		new 1830.1832(".osz", 1141.1(), 1830.1()),
		new 1830.1832(".osz2", 1141.1(), 1830.1()),
		new 1830.1832(".osr", 1141.2(), 1830.1()),
		new 1830.1832(".osk", 1141.3(), 1830.1())
	};

	// Token: 0x04002E12 RID: 11794
	private static readonly 1830.1835[] 4 = new 1830.1835[]
	{
		new 1830.1835("osu", 1141.4(), 1830.1())
	};

	// Token: 0x02000892 RID: 2194
	public enum 1834 : uint
	{

	}

	// Token: 0x02000893 RID: 2195
	public sealed class 1835
	{
		// Token: 0x06003F08 RID: 16136 RVA: 0x001875EF File Offset: 0x001857EF
		public 1835(string 1, 1165 2, string 3)
		{
			this.1 = 1;
			this.2 = 2;
			this.3 = 3;
		}

		// Token: 0x06003F09 RID: 16137 RVA: 0x00005ADD File Offset: 0x00003CDD
		public void 1()
		{
		}

		// Token: 0x06003F0A RID: 16138 RVA: 0x00005ADD File Offset: 0x00003CDD
		public void 2()
		{
		}

		// Token: 0x04002E14 RID: 11796
		private readonly string 1;

		// Token: 0x04002E15 RID: 11797
		private readonly 1165 2;

		// Token: 0x04002E16 RID: 11798
		private readonly string 3;
	}

	// Token: 0x02000894 RID: 2196
	public sealed class 1831
	{
		// Token: 0x06003F0B RID: 16139 RVA: 0x0018760C File Offset: 0x0018580C
		public 1831(string 1, string 2, 1165 3)
		{
			this.1 = 1;
			this.2 = 2;
			this.3 = 3;
		}

		// Token: 0x06003F0C RID: 16140 RVA: 0x00005ADD File Offset: 0x00003CDD
		public void 1()
		{
		}

		// Token: 0x06003F0D RID: 16141 RVA: 0x00005ADD File Offset: 0x00003CDD
		public void 2(1830.1832[] 1)
		{
		}

		// Token: 0x06003F0E RID: 16142 RVA: 0x00005ADD File Offset: 0x00003CDD
		public void 3(1830.1835[] 1)
		{
		}

		// Token: 0x06003F0F RID: 16143 RVA: 0x00005ADD File Offset: 0x00003CDD
		public void 4()
		{
		}

		// Token: 0x04002E17 RID: 11799
		private readonly string 1;

		// Token: 0x04002E18 RID: 11800
		private readonly string 2;

		// Token: 0x04002E19 RID: 11801
		private readonly 1165 3;
	}

	// Token: 0x02000895 RID: 2197
	public sealed class 1832
	{
		// Token: 0x06003F10 RID: 16144 RVA: 0x00187629 File Offset: 0x00185829
		public 1832(string 1, 1165 2, string 3)
		{
			this.1 = 1;
			this.2 = 2;
			this.3 = 3;
		}

		// Token: 0x06003F11 RID: 16145 RVA: 0x00005ADD File Offset: 0x00003CDD
		public void 1()
		{
		}

		// Token: 0x06003F12 RID: 16146 RVA: 0x00005ADD File Offset: 0x00003CDD
		public void 2()
		{
		}

		// Token: 0x04002E1A RID: 11802
		private readonly string 1;

		// Token: 0x04002E1B RID: 11803
		private readonly 1165 2;

		// Token: 0x04002E1C RID: 11804
		private readonly string 3;
	}

	// Token: 0x02000896 RID: 2198
	public enum 1833
	{

	}
}
