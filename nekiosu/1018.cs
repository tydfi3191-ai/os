using System;
using System.Runtime.InteropServices;
using System.Security;

// Token: 0x02000C8F RID: 3215
[ComVisible(false)]
[SuppressUnmanagedCodeSecurity]
public sealed class 1018
{
	// Token: 0x0600556B RID: 21867 RVA: 0x000055AC File Offset: 0x000037AC
	private 1018()
	{
	}

	// Token: 0x0600556C RID: 21868
	[DllImport("bass_fx.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_FX_BPM_BeatCallbackReset(int 1);

	// Token: 0x0600556D RID: 21869
	[DllImport("bass_fx.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_FX_BPM_BeatCallbackSet(int 1, 1013 2, IntPtr 3);

	// Token: 0x0600556E RID: 21870
	[DllImport("bass_fx.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_FX_BPM_BeatDecodeGet(int 1, double 2, double 3, 1014 4, 1013 5, IntPtr 6);

	// Token: 0x0600556F RID: 21871
	[DllImport("bass_fx.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_FX_BPM_BeatFree(int 1);

	// Token: 0x06005570 RID: 21872
	[DllImport("bass_fx.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_FX_BPM_BeatGetParameters(int 1, ref float 2, ref float 3, ref float 4);

	// Token: 0x06005571 RID: 21873
	[DllImport("bass_fx.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_FX_BPM_BeatGetParameters(int 1, [MarshalAs(UnmanagedType.AsAny)] [In] [Out] object 2, [MarshalAs(UnmanagedType.AsAny)] [In] [Out] object 3, [MarshalAs(UnmanagedType.AsAny)] [In] [Out] object 4);

	// Token: 0x06005572 RID: 21874
	[DllImport("bass_fx.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_FX_BPM_BeatSetParameters(int 1, float 2, float 3, float 4);

	// Token: 0x06005573 RID: 21875
	[DllImport("bass_fx.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_FX_BPM_CallbackReset(int 1);

	// Token: 0x06005574 RID: 21876
	[DllImport("bass_fx.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_FX_BPM_CallbackSet(int 1, 1015 2, double 3, int 4, 1014 5, IntPtr 6);

	// Token: 0x06005575 RID: 21877
	[DllImport("bass_fx.dll", CharSet = CharSet.Auto)]
	public static extern float BASS_FX_BPM_DecodeGet(int 1, double 2, double 3, int 4, 1014 5, 1016 6);

	// Token: 0x06005576 RID: 21878
	[DllImport("bass_fx.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BASS_FX_BPM_Free(int 1);

	// Token: 0x06005577 RID: 21879
	[DllImport("bass_fx.dll", CharSet = CharSet.Auto)]
	public static extern float BASS_FX_BPM_Translate(int 1, float 2, 1017 3);

	// Token: 0x06005578 RID: 21880
	[DllImport("bass_fx.dll", CharSet = CharSet.Auto)]
	public static extern int BASS_FX_GetVersion();

	// Token: 0x06005579 RID: 21881 RVA: 0x00212BCC File Offset: 0x00210DCC
	public static Version 1(int 1)
	{
		if (1 < 1)
		{
			1 = 1;
		}
		if (1 > 4)
		{
			1 = 4;
		}
		int num = 1018.BASS_FX_GetVersion();
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

	// Token: 0x0600557A RID: 21882
	[DllImport("bass_fx.dll", CharSet = CharSet.Auto)]
	public static extern int BASS_FX_ReverseCreate(int 1, float 2, 1012 3);

	// Token: 0x0600557B RID: 21883
	[DllImport("bass_fx.dll", CharSet = CharSet.Auto)]
	public static extern int BASS_FX_ReverseGetSource(int 1);

	// Token: 0x0600557C RID: 21884
	[DllImport("bass_fx.dll", CharSet = CharSet.Auto)]
	public static extern int BASS_FX_TempoCreate(int 1, 1012 2);

	// Token: 0x0600557D RID: 21885
	[DllImport("bass_fx.dll", CharSet = CharSet.Auto)]
	public static extern float BASS_FX_TempoGetRateRatio(int 1);

	// Token: 0x0600557E RID: 21886
	[DllImport("bass_fx.dll", CharSet = CharSet.Auto)]
	public static extern int BASS_FX_TempoGetSource(int 1);
}
