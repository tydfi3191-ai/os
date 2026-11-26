using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Security;

// Token: 0x02000C96 RID: 3222
[SuppressUnmanagedCodeSecurity]
[ComVisible(false)]
public sealed class 1025
{
	// Token: 0x06005594 RID: 21908
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern void BASS_Apply3D();

	// Token: 0x06005595 RID: 21909
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern double BASS_ChannelBytes2Seconds(int 1, long 2);

	// Token: 0x06005596 RID: 21910
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern 1012 BASS_ChannelFlags(int 1, 1012 2, 1012 3);

	// Token: 0x06005597 RID: 21911
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_ChannelGet3DAttributes(int 1, [MarshalAs(UnmanagedType.AsAny)] [In] [Out] object 2, [MarshalAs(UnmanagedType.AsAny)] [In] [Out] object 3, [MarshalAs(UnmanagedType.AsAny)] [In] [Out] object 4, [MarshalAs(UnmanagedType.AsAny)] [In] [Out] object 5, [MarshalAs(UnmanagedType.AsAny)] [In] [Out] object 6, [MarshalAs(UnmanagedType.AsAny)] [In] [Out] object 7);

	// Token: 0x06005598 RID: 21912
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_ChannelGet3DAttributes(int 1, ref 991 2, ref float 3, ref float 4, ref int 5, ref int 6, ref int 7);

	// Token: 0x06005599 RID: 21913
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_ChannelGet3DPosition(int 1, [In] [Out] 992 2, [In] [Out] 992 3, [In] [Out] 992 4);

	// Token: 0x0600559A RID: 21914
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_ChannelGetAttribute(int 1, 994 2, ref float 3);

	// Token: 0x0600559B RID: 21915
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern int BASS_ChannelGetData(int 1, [In] [Out] byte[] 2, int 3);

	// Token: 0x0600559C RID: 21916
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern int BASS_ChannelGetData(int 1, IntPtr 2, int 3);

	// Token: 0x0600559D RID: 21917
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern int BASS_ChannelGetData(int 1, [In] [Out] short[] 2, int 3);

	// Token: 0x0600559E RID: 21918
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern int BASS_ChannelGetData(int 1, [In] [Out] int[] 2, int 3);

	// Token: 0x0600559F RID: 21919
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern int BASS_ChannelGetData(int 1, [In] [Out] float[] 2, int 3);

	// Token: 0x060055A0 RID: 21920
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern int BASS_ChannelGetDevice(int 1);

	// Token: 0x060055A1 RID: 21921 RVA: 0x00213128 File Offset: 0x00211328
	public static 996 1(int 1)
	{
		996 result = new 996();
		if (1025.2(1, result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x060055A2 RID: 21922 RVA: 0x00213148 File Offset: 0x00211348
	public static bool 2(int 1, 996 2)
	{
		bool flag = 1025.BASS_ChannelGetInfo(1, ref 2.1);
		if (flag)
		{
			2.2 = 2.1.2;
			2.3 = 2.1.4;
			2.5 = 2.1.3;
			2.6 = 2.1.1;
			2.7 = 2.1.5;
			2.8 = 2.1.6;
			2.9 = 2.1.7;
			if ((2.5 & (1012)(-2147483648)) != (1012)0)
			{
				2.4 = Marshal.PtrToStringUni(2.1.8);
				return flag;
			}
			2.4 = Marshal.PtrToStringAnsi(2.1.8);
		}
		return flag;
	}

	// Token: 0x060055A3 RID: 21923
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool BASS_ChannelGetInfo(int 1, [In] [Out] ref 997 2);

	// Token: 0x060055A4 RID: 21924 RVA: 0x0021321C File Offset: 0x0021141C
	public static long 3(int 1)
	{
		return 1025.BASS_ChannelGetLength(1, (1024)0);
	}

	// Token: 0x060055A5 RID: 21925
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern long BASS_ChannelGetLength(int 1, 1024 2);

	// Token: 0x060055A6 RID: 21926
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern int BASS_ChannelGetLevel(int 1);

	// Token: 0x060055A7 RID: 21927 RVA: 0x00213228 File Offset: 0x00211428
	public static bool 4(int 1, float[] 2)
	{
		if (2.Length == 0)
		{
			return false;
		}
		Array.Clear(2, 0, 2.Length);
		int num = (int)1025.BASS_ChannelSeconds2Bytes(1, 0.02);
		if (num <= 0)
		{
			return false;
		}
		float[] array = new float[num / 4];
		num = 1025.BASS_ChannelGetData(1, array, num | 1073741824) / 4;
		int num2 = 0;
		for (int i = 0; i < num; i++)
		{
			float num3 = Math.Abs(array[i]);
			if (num3 > 2[num2])
			{
				2[num2] = num3;
			}
			num2++;
			if (num2 >= 2.Length)
			{
				num2 = 0;
			}
		}
		return true;
	}

	// Token: 0x060055A8 RID: 21928 RVA: 0x002132A8 File Offset: 0x002114A8
	public static string 5(int 1)
	{
		IntPtr intPtr = 1025.BASS_ChannelGetTags(1, (1035)65537);
		if (intPtr != IntPtr.Zero)
		{
			return Marshal.PtrToStringAnsi(intPtr);
		}
		return null;
	}

	// Token: 0x060055A9 RID: 21929 RVA: 0x002132D8 File Offset: 0x002114D8
	public static string 6(int 1)
	{
		IntPtr intPtr = 1025.BASS_ChannelGetTags(1, (1035)65536);
		if (intPtr != IntPtr.Zero)
		{
			return Marshal.PtrToStringAnsi(intPtr);
		}
		return null;
	}

	// Token: 0x060055AA RID: 21930 RVA: 0x00213306 File Offset: 0x00211506
	public static long 7(int 1)
	{
		return 1025.BASS_ChannelGetPosition(1, (1024)0);
	}

	// Token: 0x060055AB RID: 21931
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern long BASS_ChannelGetPosition(int 1, 1024 2);

	// Token: 0x060055AC RID: 21932
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr BASS_ChannelGetTags(int 1, 1035 2);

	// Token: 0x060055AD RID: 21933
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern 993 BASS_ChannelIsActive(int 1);

	// Token: 0x060055AE RID: 21934
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_ChannelIsSliding(int 1, 994 2);

	// Token: 0x060055AF RID: 21935
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_Channellock(int 1, [MarshalAs(UnmanagedType.Bool)] bool 2);

	// Token: 0x060055B0 RID: 21936
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_ChannelPause(int 1);

	// Token: 0x060055B1 RID: 21937
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_ChannelPlay(int 1, [MarshalAs(UnmanagedType.Bool)] bool 2);

	// Token: 0x060055B2 RID: 21938
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_ChannelRemoveDSP(int 1, int 2);

	// Token: 0x060055B3 RID: 21939
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_ChannelRemoveFX(int 1, int 2);

	// Token: 0x060055B4 RID: 21940
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_ChannelRemoveLink(int 1, int 2);

	// Token: 0x060055B5 RID: 21941
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_ChannelRemoveSync(int 1, int 2);

	// Token: 0x060055B6 RID: 21942
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern long BASS_ChannelSeconds2Bytes(int 1, double 2);

	// Token: 0x060055B7 RID: 21943
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_ChannelSet3DAttributes(int 1, 991 2, float 3, float 4, int 5, int 6, int 7);

	// Token: 0x060055B8 RID: 21944
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_ChannelSet3DPosition(int 1, [In] 992 2, [In] 992 3, [In] 992 4);

	// Token: 0x060055B9 RID: 21945
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_ChannelSetAttribute(int 1, 994 2, float 3);

	// Token: 0x060055BA RID: 21946
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_ChannelSetDevice(int 1, int 2);

	// Token: 0x060055BB RID: 21947
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern int BASS_ChannelSetDSP(int 1, 1004 2, IntPtr 3, int 4);

	// Token: 0x060055BC RID: 21948
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern int BASS_ChannelSetFX(int 1, 1005 2, int 3);

	// Token: 0x060055BD RID: 21949
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_ChannelSetLink(int 1, int 2);

	// Token: 0x060055BE RID: 21950 RVA: 0x0021330F File Offset: 0x0021150F
	public static bool 8(int 1, double 2)
	{
		return 1025.BASS_ChannelSetPosition(1, 1025.BASS_ChannelSeconds2Bytes(1, 2), (1024)0);
	}

	// Token: 0x060055BF RID: 21951 RVA: 0x0021331F File Offset: 0x0021151F
	public static bool 9(int 1, long 2)
	{
		return 1025.BASS_ChannelSetPosition(1, 2, (1024)0);
	}

	// Token: 0x060055C0 RID: 21952 RVA: 0x00213329 File Offset: 0x00211529
	public static bool 10(int 1, int 2, int 3)
	{
		return 1025.BASS_ChannelSetPosition(1, (long)1019.9(2, 3), (1024)1);
	}

	// Token: 0x060055C1 RID: 21953
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_ChannelSetPosition(int 1, long 2, 1024 3);

	// Token: 0x060055C2 RID: 21954
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern int BASS_ChannelSetSync(int 1, 1034 2, long 3, 1033 4, IntPtr 5);

	// Token: 0x060055C3 RID: 21955
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_ChannelSlideAttribute(int 1, 994 2, float 3, int 4);

	// Token: 0x060055C4 RID: 21956
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_ChannelStop(int 1);

	// Token: 0x060055C5 RID: 21957
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_ChannelUpdate(int 1, int 2);

	// Token: 0x060055C6 RID: 21958
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern 936 BASS_ErrorGetCode();

	// Token: 0x060055C7 RID: 21959
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_Free();

	// Token: 0x060055C8 RID: 21960
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool BASS_FXGetParameters(int 1, [MarshalAs(UnmanagedType.AsAny)] [In] [Out] object 2);

	// Token: 0x060055C9 RID: 21961
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_FXReset(int 1);

	// Token: 0x060055CA RID: 21962
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool BASS_FXSetParameters(int 1, [MarshalAs(UnmanagedType.AsAny)] [In] object 2);

	// Token: 0x060055CB RID: 21963
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_Get3DFactors(ref float 1, ref float 2, ref float 3);

	// Token: 0x060055CC RID: 21964
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_Get3DFactors([MarshalAs(UnmanagedType.AsAny)] [In] [Out] object 1, [MarshalAs(UnmanagedType.AsAny)] [In] [Out] object 2, [MarshalAs(UnmanagedType.AsAny)] [In] [Out] object 3);

	// Token: 0x060055CD RID: 21965
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_Get3DPosition([In] [Out] 992 1, [In] [Out] 992 2, [In] [Out] 992 3, [In] [Out] 992 4);

	// Token: 0x060055CE RID: 21966
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern int BASS_GetConfig(998 1);

	// Token: 0x060055CF RID: 21967
	[DllImport("bass.dll", CharSet = CharSet.Auto, EntryPoint = "BASS_GetConfig")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_GetConfig2(998 1);

	// Token: 0x060055D0 RID: 21968
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr BASS_GetConfigPtr(998 1);

	// Token: 0x060055D1 RID: 21969
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern float BASS_GetCPU();

	// Token: 0x060055D2 RID: 21970
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern int BASS_GetDevice();

	// Token: 0x060055D3 RID: 21971 RVA: 0x0021333C File Offset: 0x0021153C
	public static 1000 11(int 1)
	{
		1000 result = new 1000();
		if (1025.12(1, result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x060055D4 RID: 21972 RVA: 0x0021335C File Offset: 0x0021155C
	public static bool 12(int 1, 1000 2)
	{
		bool flag = 1025.BASS_GetDeviceInfo(1, ref 2.1);
		if (flag)
		{
			2.4 = Marshal.PtrToStringAnsi(2.1.1);
			2.2 = Marshal.PtrToStringAnsi(2.1.2);
			2.3 = 2.1.3;
		}
		return flag;
	}

	// Token: 0x060055D5 RID: 21973
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool BASS_GetDeviceInfo([In] int 1, [In] [Out] ref 1001 2);

	// Token: 0x060055D6 RID: 21974 RVA: 0x002133B8 File Offset: 0x002115B8
	public static 1000[] 13()
	{
		ArrayList arrayList = new ArrayList();
		int num = 0;
		1000 value;
		while ((value = 1025.11(num)) != null)
		{
			arrayList.Add(value);
			num++;
		}
		return (1000[])arrayList.ToArray(typeof(1000));
	}

	// Token: 0x060055D7 RID: 21975
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr BASS_GetDSoundObject(int 1);

	// Token: 0x060055D8 RID: 21976
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr BASS_GetDSoundObject(1002 1);

	// Token: 0x060055D9 RID: 21977
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_GetEAXParameters([MarshalAs(UnmanagedType.AsAny)] [In] [Out] object 1, [MarshalAs(UnmanagedType.AsAny)] [In] [Out] object 2, [MarshalAs(UnmanagedType.AsAny)] [In] [Out] object 3, [MarshalAs(UnmanagedType.AsAny)] [In] [Out] object 4);

	// Token: 0x060055DA RID: 21978 RVA: 0x002133FC File Offset: 0x002115FC
	[return: MarshalAs(UnmanagedType.Bool)]
	public static 1020 14()
	{
		1020 result = new 1020();
		if (1025.BASS_GetInfo(result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x060055DB RID: 21979
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_GetInfo([In] [Out] 1020 1);

	// Token: 0x060055DC RID: 21980
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern int BASS_GetVersion();

	// Token: 0x060055DD RID: 21981 RVA: 0x0021341C File Offset: 0x0021161C
	public static Version 15(int 1)
	{
		if (1 < 1)
		{
			1 = 1;
		}
		if (1 > 4)
		{
			1 = 4;
		}
		int num = 1025.BASS_GetVersion();
		Version version = new Version(2, 3);
		Version result;
		switch (1)
		{
		case 1:
			result = new Version(num >> 24 & 255, 0);
			break;
		case 2:
			result = new Version(num >> 24 & 255, num >> 16 & 255);
			break;
		case 3:
			result = new Version(num >> 24 & 255, num >> 16 & 255, num >> 8 & 255);
			break;
		case 4:
			result = new Version(num >> 24 & 255, num >> 16 & 255, num >> 8 & 255, num & 255);
			break;
		default:
			result = version;
			break;
		}
		return result;
	}

	// Token: 0x060055DE RID: 21982
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern float BASS_GetVolume();

	// Token: 0x060055DF RID: 21983
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_Init(int 1, int 2, 1021 3, IntPtr 4, Guid 5);

	// Token: 0x060055E0 RID: 21984
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_Init(int 1, int 2, 1021 3, IntPtr 4, [MarshalAs(UnmanagedType.AsAny)] [In] object 5);

	// Token: 0x060055E1 RID: 21985
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_MusicFree(int 1);

	// Token: 0x060055E2 RID: 21986 RVA: 0x002134E5 File Offset: 0x002116E5
	public static int 16(IntPtr 1, long 2, int 3, 1012 4, int 5)
	{
		return 1025.BASS_MusicLoad(true, 1, 2, 3, 4, 5);
	}

	// Token: 0x060055E3 RID: 21987 RVA: 0x002134F3 File Offset: 0x002116F3
	public static int 17(string 1, long 2, int 3, 1012 4, int 5)
	{
		4 |= (1012)(-2147483648);
		return 1025.BASS_MusicLoad2(false, 1, 2, 3, 4, 5);
	}

	// Token: 0x060055E4 RID: 21988 RVA: 0x0021350A File Offset: 0x0021170A
	public static int 18(byte[] 1, long 2, int 3, 1012 4, int 5)
	{
		return 1025.BASS_MusicLoad(true, 1, 2, 3, 4, 5);
	}

	// Token: 0x060055E5 RID: 21989
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	private static extern int BASS_MusicLoad([MarshalAs(UnmanagedType.Bool)] bool 1, IntPtr 2, long 3, int 4, 1012 5, int 6);

	// Token: 0x060055E6 RID: 21990
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	private static extern int BASS_MusicLoad([MarshalAs(UnmanagedType.Bool)] bool 1, byte[] 2, long 3, int 4, 1012 5, int 6);

	// Token: 0x060055E7 RID: 21991
	[DllImport("bass.dll", CharSet = CharSet.Auto, EntryPoint = "BASS_MusicLoad")]
	private static extern int BASS_MusicLoad2([MarshalAs(UnmanagedType.Bool)] bool 1, [MarshalAs(UnmanagedType.LPWStr)] [In] string 2, long 3, int 4, 1012 5, int 6);

	// Token: 0x060055E8 RID: 21992
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_Pause();

	// Token: 0x060055E9 RID: 21993
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_PluginFree(int 1);

	// Token: 0x060055EA RID: 21994
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr BASS_PluginGetInfo(int 1);

	// Token: 0x060055EB RID: 21995 RVA: 0x00213518 File Offset: 0x00211718
	public static int 19(string 1)
	{
		return 1025.BASS_PluginLoad(1, (1012)(-2147483648));
	}

	// Token: 0x060055EC RID: 21996
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	private static extern int BASS_PluginLoad([MarshalAs(UnmanagedType.LPWStr)] [In] string 1, 1012 2);

	// Token: 0x060055ED RID: 21997
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_RecordFree();

	// Token: 0x060055EE RID: 21998
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern int BASS_RecordGetDevice();

	// Token: 0x060055EF RID: 21999 RVA: 0x00213528 File Offset: 0x00211728
	public static 1000 20(int 1)
	{
		1000 result = new 1000();
		if (1025.21(1, result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x060055F0 RID: 22000 RVA: 0x00213548 File Offset: 0x00211748
	public static bool 21(int 1, 1000 2)
	{
		bool flag = 1025.BASS_RecordGetDeviceInfo(1, ref 2.1);
		if (flag)
		{
			2.4 = Marshal.PtrToStringAnsi(2.1.1);
			2.2 = Marshal.PtrToStringAnsi(2.1.2);
			2.3 = 2.1.3;
		}
		return flag;
	}

	// Token: 0x060055F1 RID: 22001
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool BASS_RecordGetDeviceInfo([In] int 1, [In] [Out] ref 1001 2);

	// Token: 0x060055F2 RID: 22002 RVA: 0x002135A4 File Offset: 0x002117A4
	public static 1028 22()
	{
		1028 result = new 1028();
		if (1025.BASS_RecordGetInfo(result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x060055F3 RID: 22003
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_RecordGetInfo([In] [Out] 1028 1);

	// Token: 0x060055F4 RID: 22004 RVA: 0x002135C4 File Offset: 0x002117C4
	public static 1022 23(int 1)
	{
		int num = 1025.BASS_RecordGetInput2(1, IntPtr.Zero);
		if (num != -1)
		{
			return (1022)(num & 16711680);
		}
		return (1022)0;
	}

	// Token: 0x060055F5 RID: 22005
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern int BASS_RecordGetInput(int 1, ref float 2);

	// Token: 0x060055F6 RID: 22006
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr BASS_RecordGetInputName(int 1);

	// Token: 0x060055F7 RID: 22007
	[DllImport("bass.dll", CharSet = CharSet.Auto, EntryPoint = "BASS_RecordGetInput")]
	private static extern int BASS_RecordGetInput2(int 1, IntPtr 2);

	// Token: 0x060055F8 RID: 22008
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_RecordInit(int 1);

	// Token: 0x060055F9 RID: 22009
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_RecordSetDevice(int 1);

	// Token: 0x060055FA RID: 22010
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_RecordSetInput(int 1, 1022 2, float 3);

	// Token: 0x060055FB RID: 22011
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern int BASS_RecordStart(int 1, int 2, 1012 3, 1029 4, IntPtr 5);

	// Token: 0x060055FC RID: 22012 RVA: 0x002135EA File Offset: 0x002117EA
	public static int 24(int 1, int 2, 1012 3, int 4, 1029 5, IntPtr 6)
	{
		return 1025.BASS_RecordStart(1, 2, (1012)1019.9((int)3, 4), 5, 6);
	}

	// Token: 0x060055FD RID: 22013
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern int BASS_SampleCreate(int 1, int 2, int 3, int 4, 1012 5);

	// Token: 0x060055FE RID: 22014
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_SampleFree(int 1);

	// Token: 0x060055FF RID: 22015
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern int BASS_SampleGetChannel(int 1, [MarshalAs(UnmanagedType.Bool)] bool 2);

	// Token: 0x06005600 RID: 22016 RVA: 0x00213600 File Offset: 0x00211800
	public static int[] 25(int 1)
	{
		int[] sourceArray = new int[1025.26(1).6];
		int num = 1025.BASS_SampleGetChannels(1, sourceArray);
		if (num >= 0)
		{
			int[] array = new int[num];
			Array.Copy(sourceArray, array, num);
			return array;
		}
		return null;
	}

	// Token: 0x06005601 RID: 22017
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern int BASS_SampleGetChannels(int 1, int[] 2);

	// Token: 0x06005602 RID: 22018
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_SampleGetData(int 1, byte[] 2);

	// Token: 0x06005603 RID: 22019
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_SampleGetData(int 1, short[] 2);

	// Token: 0x06005604 RID: 22020
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_SampleGetData(int 1, int[] 2);

	// Token: 0x06005605 RID: 22021
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_SampleGetData(int 1, float[] 2);

	// Token: 0x06005606 RID: 22022
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_SampleGetData(int 1, IntPtr 2);

	// Token: 0x06005607 RID: 22023 RVA: 0x0021363C File Offset: 0x0021183C
	public static 1030 26(int 1)
	{
		1030 result = new 1030();
		if (1025.BASS_SampleGetInfo(1, result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x06005608 RID: 22024
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_SampleGetInfo(int 1, [In] [Out] 1030 2);

	// Token: 0x06005609 RID: 22025 RVA: 0x0021365B File Offset: 0x0021185B
	public static int 27(byte[] 1, long 2, int 3, int 4, 1012 5)
	{
		return 1025.BASS_SampleLoad(true, 1, 2, 3, 4, 5);
	}

	// Token: 0x0600560A RID: 22026 RVA: 0x00213669 File Offset: 0x00211869
	public static int 28(IntPtr 1, long 2, int 3, int 4, 1012 5)
	{
		return 1025.BASS_SampleLoad(true, 1, 2, 3, 4, 5);
	}

	// Token: 0x0600560B RID: 22027 RVA: 0x00213677 File Offset: 0x00211877
	public static int 29(string 1, long 2, int 3, int 4, 1012 5)
	{
		5 |= (1012)(-2147483648);
		return 1025.BASS_SampleLoad2(false, 1, 2, 3, 4, 5);
	}

	// Token: 0x0600560C RID: 22028
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	private static extern int BASS_SampleLoad([MarshalAs(UnmanagedType.Bool)] bool 1, byte[] 2, long 3, int 4, int 5, 1012 6);

	// Token: 0x0600560D RID: 22029
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	private static extern int BASS_SampleLoad([MarshalAs(UnmanagedType.Bool)] bool 1, IntPtr 2, long 3, int 4, int 5, 1012 6);

	// Token: 0x0600560E RID: 22030
	[DllImport("bass.dll", CharSet = CharSet.Auto, EntryPoint = "BASS_SampleLoad")]
	private static extern int BASS_SampleLoad2([MarshalAs(UnmanagedType.Bool)] bool 1, [MarshalAs(UnmanagedType.LPWStr)] [In] string 2, long 3, int 4, int 5, 1012 6);

	// Token: 0x0600560F RID: 22031
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_SampleSetData(int 1, byte[] 2);

	// Token: 0x06005610 RID: 22032
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_SampleSetData(int 1, short[] 2);

	// Token: 0x06005611 RID: 22033
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_SampleSetData(int 1, int[] 2);

	// Token: 0x06005612 RID: 22034
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_SampleSetData(int 1, float[] 2);

	// Token: 0x06005613 RID: 22035
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_SampleSetData(int 1, IntPtr 2);

	// Token: 0x06005614 RID: 22036
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_SampleSetInfo(int 1, [In] 1030 2);

	// Token: 0x06005615 RID: 22037
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_SampleStop(int 1);

	// Token: 0x06005616 RID: 22038
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_Set3DFactors(float 1, float 2, float 3);

	// Token: 0x06005617 RID: 22039
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_Set3DPosition([In] 992 1, [In] 992 2, [In] 992 3, [In] 992 4);

	// Token: 0x06005618 RID: 22040
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_SetConfig(998 1, [MarshalAs(UnmanagedType.Bool)] [In] bool 2);

	// Token: 0x06005619 RID: 22041
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_SetConfig(998 1, int 2);

	// Token: 0x0600561A RID: 22042
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_SetConfigPtr(998 1, IntPtr 2);

	// Token: 0x0600561B RID: 22043
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_SetDevice(int 1);

	// Token: 0x0600561C RID: 22044
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_SetVolume(float 1);

	// Token: 0x0600561D RID: 22045
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_Start();

	// Token: 0x0600561E RID: 22046
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_Stop();

	// Token: 0x0600561F RID: 22047
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern int BASS_StreamCreate(int 1, int 2, 1012 3, 1031 4, IntPtr 5);

	// Token: 0x06005620 RID: 22048 RVA: 0x0021368F File Offset: 0x0021188F
	public static int 30(IntPtr 1, long 2, long 3, 1012 4)
	{
		return 1025.BASS_StreamCreateFile(true, 1, 2, 3, 4);
	}

	// Token: 0x06005621 RID: 22049 RVA: 0x0021369B File Offset: 0x0021189B
	public static int 31(string 1, long 2, long 3, 1012 4)
	{
		4 |= (1012)(-2147483648);
		return 1025.BASS_StreamCreateFile2(false, 1, 2, 3, 4);
	}

	// Token: 0x06005622 RID: 22050
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	private static extern int BASS_StreamCreateFile([MarshalAs(UnmanagedType.Bool)] bool 1, IntPtr 2, long 3, long 4, 1012 5);

	// Token: 0x06005623 RID: 22051
	[DllImport("bass.dll", CharSet = CharSet.Auto, EntryPoint = "BASS_StreamCreateFile")]
	private static extern int BASS_StreamCreateFile2([MarshalAs(UnmanagedType.Bool)] bool 1, [MarshalAs(UnmanagedType.LPWStr)] [In] string 2, long 3, long 4, 1012 5);

	// Token: 0x06005624 RID: 22052
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern int BASS_StreamCreateFileUser(1032 1, 1012 2, 1009 3, IntPtr 4);

	// Token: 0x06005625 RID: 22053
	[DllImport("bass.dll", CharSet = CharSet.Auto, EntryPoint = "BASS_StreamCreate")]
	private static extern int BASS_StreamCreate2(int 1, int 2, 1012 3, IntPtr 4, IntPtr 5);

	// Token: 0x06005626 RID: 22054
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_StreamFree(int 1);

	// Token: 0x06005627 RID: 22055
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern long BASS_StreamGetFilePosition(int 1, 1008 2);

	// Token: 0x06005628 RID: 22056
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern int BASS_StreamPutData(int 1, byte[] 2, int 3);

	// Token: 0x06005629 RID: 22057
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern int BASS_StreamPutData(int 1, short[] 2, int 3);

	// Token: 0x0600562A RID: 22058
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern int BASS_StreamPutData(int 1, float[] 2, int 3);

	// Token: 0x0600562B RID: 22059
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern int BASS_StreamPutData(int 1, IntPtr 2, int 3);

	// Token: 0x0600562C RID: 22060
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern int BASS_StreamPutData(int 1, int[] 2, int 3);

	// Token: 0x0600562D RID: 22061
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern int BASS_StreamPutFileData(int 1, byte[] 2, int 3);

	// Token: 0x0600562E RID: 22062
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern int BASS_StreamPutFileData(int 1, short[] 2, int 3);

	// Token: 0x0600562F RID: 22063
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern int BASS_StreamPutFileData(int 1, IntPtr 2, int 3);

	// Token: 0x06005630 RID: 22064
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern int BASS_StreamPutFileData(int 1, int[] 2, int 3);

	// Token: 0x06005631 RID: 22065
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	public static extern int BASS_StreamPutFileData(int 1, float[] 2, int 3);

	// Token: 0x06005632 RID: 22066
	[DllImport("bass.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_Update(int 1);

	// Token: 0x04004383 RID: 17283
	private static int 1 = 0;

	// Token: 0x04004384 RID: 17284
	private static string 2 = "bass.dll";

	// Token: 0x04004385 RID: 17285
	public static string 3 = "*.mod;*.mo3;*.s3m;*.xm;*.it;*.mtm;*.umx;*.mdz;*.s3z;*.itz;*.xmz";

	// Token: 0x04004386 RID: 17286
	public static string 4 = "*.mp3;*.ogg;*.wav;*.mp2;*.mp1;*.aiff;*.m2a;*.mpa;*.m1a;*.mpg;*.mpeg;*.aif;*.mp3pro;*.bwf";

	// Token: 0x04004387 RID: 17287
	public static string 5 = "WAV/AIFF/MP3/MP2/MP1/OGG";
}
