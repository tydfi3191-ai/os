using System;
using System.Runtime.InteropServices;
using OpenTK.Graphics.ES20;

// Token: 0x0200087C RID: 2172
public sealed class 1809
{
	// Token: 0x06003EA5 RID: 16037 RVA: 0x00186E38 File Offset: 0x00185038
	static 1809()
	{
		if (!GL.GetString(7936).ToUpper().Contains("NVIDIA") || (IntPtr.Size == 4 && 1809.LoadLibrary("nvapi.dll") == IntPtr.Zero) || (IntPtr.Size == 8 && 1809.LoadLibrary("nvapi64.dll") == IntPtr.Zero))
		{
			return;
		}
		try
		{
			1809.1821 <<EMPTY_NAME>>;
			1809.16<1809.1821>(22079528U, out <<EMPTY_NAME>>);
			if (<<EMPTY_NAME>> != null && <<EMPTY_NAME>>() == 1159.OK)
			{
				1809.16<1809.1815>(3853292063U, out 1809.1);
				1809.16<1809.1814>(1219750489U, out 1809.2);
				1809.16<1809.1818>(3131752396U, out 1809.3);
				1809.16<1809.1823>(3275468465U, out 1809.4);
				1809.16<1809.1811>(110417198U, out 1809.5);
				1809.16<1809.1822>(928890219U, out 1809.6);
				1809.16<1809.1816>(4008011442U, out 1809.7);
				1809.16<1809.1817>(1635516319U, out 1809.8);
				1809.16<1809.1825>(1467863554U, out 1809.12);
				1809.16<1809.1819>(1640853462U, out 1809.9);
				1809.16<1809.1820>(1941930808U, out 1809.10);
				1809.16<1809.1812>(3424084072U, out 1809.11);
				1809.16<1809.1813>(2141329210U, out 1809.13);
				1809.16<1809.1810>(1128770014U, out 1809.14);
				1809.16<1809.1824>(4240211476U, out 1809.15);
			}
			if (1809.14())
			{
				1809.4(true);
			}
		}
		catch
		{
		}
	}

	// Token: 0x06003EA6 RID: 16038 RVA: 0x000055AC File Offset: 0x000037AC
	private 1809()
	{
	}

	// Token: 0x06003EA7 RID: 16039 RVA: 0x00186FCC File Offset: 0x001851CC
	public static 1159 1()
	{
		return 1809.16;
	}

	// Token: 0x06003EA8 RID: 16040 RVA: 0x00186FD3 File Offset: 0x001851D3
	private static void 2(1159 1)
	{
		1809.16 = 1;
	}

	// Token: 0x06003EA9 RID: 16041 RVA: 0x00186FDB File Offset: 0x001851DB
	public static bool 3()
	{
		return 1809.17;
	}

	// Token: 0x06003EAA RID: 16042 RVA: 0x00186FE2 File Offset: 0x001851E2
	private static void 4(bool 1)
	{
		1809.17 = 1;
	}

	// Token: 0x06003EAB RID: 16043 RVA: 0x00186FEC File Offset: 0x001851EC
	public static bool 5()
	{
		IntPtr intPtr;
		1156 <<EMPTY_NAME>>;
		bool flag;
		1158 2;
		return 1809.3() && 1809.6() && 1809.10(out intPtr, out <<EMPTY_NAME>>, out flag) && 1809.12((676)284810369U, intPtr, out 2) && (2.10 & 1U) > 0U;
	}

	// Token: 0x06003EAC RID: 16044 RVA: 0x00187038 File Offset: 0x00185238
	public static bool 6()
	{
		if (!1809.3())
		{
			return false;
		}
		IntPtr[] array = new IntPtr[64];
		int num;
		if (1809.15(1809.1(array, out num)))
		{
			return false;
		}
		for (int i = 0; i < num; i++)
		{
			1132 <<EMPTY_NAME>>;
			if (1809.15(1809.3(array[i], out <<EMPTY_NAME>>)))
			{
				return false;
			}
			if (<<EMPTY_NAME>> == (1132)1)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06003EAD RID: 16045 RVA: 0x00187098 File Offset: 0x00185298
	public static bool 7()
	{
		IntPtr intPtr;
		1156 <<EMPTY_NAME>>;
		bool flag;
		1158 2;
		return 1809.3() && 1809.10(out intPtr, out <<EMPTY_NAME>>, out flag) && 1809.12((676)549528094U, intPtr, out 2) && 2.10 != 2U;
	}

	// Token: 0x06003EAE RID: 16046 RVA: 0x001870DA File Offset: 0x001852DA
	public static void 8(bool 1)
	{
		if (1809.3())
		{
			1809.13((676)549528094U, 1 ? 1U : 2U);
		}
	}

	// Token: 0x06003EAF RID: 16047 RVA: 0x001870F8 File Offset: 0x001852F8
	private static bool 9(IntPtr 1, 1157 2, out 1156 3)
	{
		3 = default(1156);
		3.1 = 1156.1();
		if (2.5 == 0U)
		{
			return false;
		}
		1156[] array = new 1156[2.5];
		array[0].1 = 1156.1();
		uint num = 2.5;
		if (1809.15(1809.13(1809.18, 1, 0U, ref num, array)))
		{
			return false;
		}
		for (uint num2 = 0U; num2 < num; num2 += 1U)
		{
			if (array[(int)num2].3 == 1345.3())
			{
				3 = array[(int)num2];
				return true;
			}
		}
		return false;
	}

	// Token: 0x06003EB0 RID: 16048 RVA: 0x00187198 File Offset: 0x00185398
	private static bool 10(out IntPtr 1, out 1156 2, out bool 3)
	{
		2 = default(1156);
		2.1 = 1156.1();
		3 = true;
		if (1809.15(1809.7(1809.18, 1345.3(), out 1, ref 2)))
		{
			3 = false;
			if (1809.15(1809.8(1809.18, out 1)))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06003EB1 RID: 16049 RVA: 0x001871F4 File Offset: 0x001853F4
	private static bool 11(out IntPtr 1)
	{
		1157 2 = new 1157
		{
			1 = 1157.1(),
			4 = 0U,
			2 = "osu!",
			3 = new uint[32]
		};
		2.3[0] = 1U;
		return !1809.15(1809.11(1809.18, ref 2, out 1));
	}

	// Token: 0x06003EB2 RID: 16050 RVA: 0x0018725E File Offset: 0x0018545E
	private static bool 12(676 1, IntPtr 2, out 1158 3)
	{
		3 = default(1158);
		3.1 = 1158.1();
		3.3 = 1;
		return !1809.15(1809.10(1809.18, 2, 1, ref 3));
	}

	// Token: 0x06003EB3 RID: 16051 RVA: 0x00187298 File Offset: 0x00185498
	private static bool 13(676 1, uint 2)
	{
		IntPtr intPtr;
		1156 3;
		bool flag;
		if (!1809.10(out intPtr, out 3, out flag))
		{
			return false;
		}
		if (!flag && !1809.11(out intPtr))
		{
			return false;
		}
		1158 4 = new 1158
		{
			1 = 1158.1(),
			3 = 1,
			10 = 2
		};
		if (1809.15(1809.12(1809.18, intPtr, ref 4)))
		{
			return false;
		}
		1157 5 = new 1157
		{
			1 = 1157.1()
		};
		if (1809.15(1809.9(1809.18, intPtr, ref 5)))
		{
			return false;
		}
		if (!1809.9(intPtr, 5, out 3))
		{
			3.2 = 0U;
			3.3 = 1345.3();
			3.4 = "osu!";
			if (1809.15(1809.14(1809.18, intPtr, ref 3)))
			{
				return false;
			}
		}
		return !1809.15(1809.15(1809.18));
	}

	// Token: 0x06003EB4 RID: 16052 RVA: 0x00187395 File Offset: 0x00185595
	private static bool 14()
	{
		return !1809.15(1809.5(out 1809.18)) && !1809.15(1809.6(1809.18));
	}

	// Token: 0x06003EB5 RID: 16053 RVA: 0x001873C8 File Offset: 0x001855C8
	private static bool 15(1159 1)
	{
		1809.2(1);
		return 1 > 1159.OK;
	}

	// Token: 0x06003EB6 RID: 16054 RVA: 0x001873D4 File Offset: 0x001855D4
	private static void 16<T>(uint 1, out T 2) where T : class
	{
		IntPtr intPtr = (IntPtr.Size == 4) ? 1809.nvapi_QueryInterface(1) : 1809.nvapi_QueryInterface2(1);
		2 = ((intPtr == IntPtr.Zero) ? default(T) : (Marshal.GetDelegateForFunctionPointer(intPtr, typeof(T)) as T));
	}

	// Token: 0x06003EB7 RID: 16055
	[DllImport("kernel32.dll")]
	private static extern IntPtr LoadLibrary(string 1);

	// Token: 0x06003EB8 RID: 16056
	[DllImport("nvapi.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr nvapi_QueryInterface(uint 1);

	// Token: 0x06003EB9 RID: 16057
	[DllImport("nvapi64.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "nvapi_QueryInterface")]
	private static extern IntPtr nvapi_QueryInterface2(uint 1);

	// Token: 0x04002DF3 RID: 11763
	public static readonly 1809.1815 1;

	// Token: 0x04002DF4 RID: 11764
	public static readonly 1809.1814 2;

	// Token: 0x04002DF5 RID: 11765
	public static readonly 1809.1818 3;

	// Token: 0x04002DF6 RID: 11766
	public static readonly 1809.1823 4;

	// Token: 0x04002DF7 RID: 11767
	public static 1809.1811 5;

	// Token: 0x04002DF8 RID: 11768
	public static 1809.1822 6;

	// Token: 0x04002DF9 RID: 11769
	public static 1809.1816 7;

	// Token: 0x04002DFA RID: 11770
	public static 1809.1817 8;

	// Token: 0x04002DFB RID: 11771
	public static 1809.1819 9;

	// Token: 0x04002DFC RID: 11772
	public static 1809.1820 10;

	// Token: 0x04002DFD RID: 11773
	private static 1809.1812 11;

	// Token: 0x04002DFE RID: 11774
	private static 1809.1825 12;

	// Token: 0x04002DFF RID: 11775
	private static 1809.1813 13;

	// Token: 0x04002E00 RID: 11776
	private static 1809.1810 14;

	// Token: 0x04002E01 RID: 11777
	private static 1809.1824 15;

	// Token: 0x04002E02 RID: 11778
	private static 1159 16;

	// Token: 0x04002E03 RID: 11779
	private static bool 17;

	// Token: 0x04002E04 RID: 11780
	private static IntPtr 18;

	// Token: 0x0200087D RID: 2173
	// (Invoke) Token: 0x06003EBB RID: 16059
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate 1159 1816(IntPtr 1, [MarshalAs(UnmanagedType.BStr)] string 2, out IntPtr 3, ref 1156 4);

	// Token: 0x0200087E RID: 2174
	// (Invoke) Token: 0x06003EBF RID: 16063
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate 1159 1822(IntPtr 1);

	// Token: 0x0200087F RID: 2175
	// (Invoke) Token: 0x06003EC3 RID: 16067
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate 1159 1818(IntPtr 1, out 1132 2);

	// Token: 0x02000880 RID: 2176
	// (Invoke) Token: 0x06003EC7 RID: 16071
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate 1159 1817(IntPtr 1, out IntPtr 2);

	// Token: 0x02000881 RID: 2177
	// (Invoke) Token: 0x06003ECB RID: 16075
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate 1159 1810(IntPtr 1, IntPtr 2, ref 1156 3);

	// Token: 0x02000882 RID: 2178
	// (Invoke) Token: 0x06003ECF RID: 16079
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate 1159 1815([Out] IntPtr[] 1, out int 2);

	// Token: 0x02000883 RID: 2179
	// (Invoke) Token: 0x06003ED3 RID: 16083
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate 1159 1811(out IntPtr 1);

	// Token: 0x02000884 RID: 2180
	// (Invoke) Token: 0x06003ED7 RID: 16087
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate 1159 1823(IntPtr 1, out 1135 2);

	// Token: 0x02000885 RID: 2181
	// (Invoke) Token: 0x06003EDB RID: 16091
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate 1159 1825(IntPtr 1, IntPtr 2, ref 1158 3);

	// Token: 0x02000886 RID: 2182
	// (Invoke) Token: 0x06003EDF RID: 16095
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate 1159 1812(IntPtr 1, ref 1157 2, out IntPtr 3);

	// Token: 0x02000887 RID: 2183
	// (Invoke) Token: 0x06003EE3 RID: 16099
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate 1159 1814([Out] IntPtr[] 1, out int 2);

	// Token: 0x02000888 RID: 2184
	// (Invoke) Token: 0x06003EE7 RID: 16103
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate 1159 1820(IntPtr 1, IntPtr 2, 676 3, ref 1158 4);

	// Token: 0x02000889 RID: 2185
	// (Invoke) Token: 0x06003EEB RID: 16107
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate 1159 1824(IntPtr 1);

	// Token: 0x0200088A RID: 2186
	// (Invoke) Token: 0x06003EEF RID: 16111
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate 1159 1813(IntPtr 1, IntPtr 2, uint 3, ref uint 4, [MarshalAs(UnmanagedType.LPArray)] [In] [Out] 1156[] 5);

	// Token: 0x0200088B RID: 2187
	// (Invoke) Token: 0x06003EF3 RID: 16115
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate 1159 1819(IntPtr 1, IntPtr 2, ref 1157 3);

	// Token: 0x0200088C RID: 2188
	// (Invoke) Token: 0x06003EF7 RID: 16119
	public delegate 1159 1821();
}
