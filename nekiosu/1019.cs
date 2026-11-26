using System;
using System.Collections;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security;

// Token: 0x02000C90 RID: 3216
[ComVisible(false)]
[SuppressUnmanagedCodeSecurity]
public sealed class 1019
{
	// Token: 0x0600557F RID: 21887 RVA: 0x00212C98 File Offset: 0x00210E98
	static 1019()
	{
		AssemblyName name = new AssemblyName
		{
			Name = "dynamicBASSNET"
		};
		1019.1 = AppDomain.CurrentDomain.DefineDynamicAssembly(name, AssemblyBuilderAccess.Run).DefineDynamicModule("BASSNETdynmod");
		1019.2 = new Hashtable();
	}

	// Token: 0x06005580 RID: 21888 RVA: 0x000055AC File Offset: 0x000037AC
	private 1019()
	{
	}

	// Token: 0x06005581 RID: 21889 RVA: 0x00212CE8 File Offset: 0x00210EE8
	public static string 1(935 1)
	{
		string text = "???";
		if ((1 & 935.BASS_CTYPE_STREAM_WAV) > 935.BASS_CTYPE_UNKNOWN)
		{
			1 = 935.BASS_CTYPE_STREAM_WAV;
		}
		935 2 = 1;
		if (2 <= 935.BASS_CTYPE_STREAM_FLAC)
		{
			if (2 <= 935.BASS_CTYPE_STREAM_CD)
			{
				string result;
				if (2 <= 935.BASS_CTYPE_MUSIC_MO3)
				{
					if (2 != 935.BASS_CTYPE_SAMPLE)
					{
						if (2 != 935.BASS_CTYPE_RECORD)
						{
							if (2 != 935.BASS_CTYPE_MUSIC_MO3)
							{
								result = text;
							}
							else
							{
								result = "MO3";
							}
						}
						else
						{
							result = "recording";
						}
					}
					else
					{
						result = "sample";
					}
					return result;
				}
				switch (2)
				{
				case 935.BASS_CTYPE_STREAM:
					result = "custom stream";
					break;
				case 935.BASS_CTYPE_SAMPLE | 935.BASS_CTYPE_STREAM:
					result = text;
					break;
				case 935.BASS_CTYPE_STREAM_OGG:
					result = "OGG";
					break;
				case 935.BASS_CTYPE_STREAM_MP1:
					result = "MP1";
					break;
				case 935.BASS_CTYPE_STREAM_MP2:
					result = "MP2";
					break;
				case 935.BASS_CTYPE_STREAM_MP3:
					result = "MP3";
					break;
				case 935.BASS_CTYPE_STREAM_AIFF:
					result = "AIFF";
					break;
				default:
					if (2 != 935.BASS_CTYPE_STREAM_CD)
					{
						result = text;
					}
					else
					{
						result = "CDA";
					}
					break;
				}
				return result;
			}
			else
			{
				string result;
				if (2 <= 935.BASS_CTYPE_STREAM_WV_LH)
				{
					if (2 != 935.BASS_CTYPE_STREAM_WMA)
					{
						if (2 != 935.BASS_CTYPE_STREAM_WMA_MP3)
						{
							switch (2)
							{
							case 935.BASS_CTYPE_STREAM_WV:
								result = "Wavpack";
								break;
							case 935.BASS_CTYPE_STREAM_WV_H:
								result = "Wavpack";
								break;
							case 935.BASS_CTYPE_STREAM_WV_L:
								result = "Wavpack";
								break;
							case 935.BASS_CTYPE_STREAM_WV_LH:
								result = "Wavpack";
								break;
							default:
								result = text;
								break;
							}
						}
						else
						{
							result = "MP3";
						}
					}
					else
					{
						result = "WMA";
					}
					return result;
				}
				if (2 != 935.BASS_CTYPE_STREAM_OFR)
				{
					if (2 != 935.BASS_CTYPE_STREAM_APE)
					{
						if (2 != 935.BASS_CTYPE_STREAM_FLAC)
						{
							result = text;
						}
						else
						{
							result = "FLAC";
						}
					}
					else
					{
						result = "APE";
					}
				}
				else
				{
					result = "Optimfrog";
				}
				return result;
			}
		}
		else if (2 <= 935.BASS_CTYPE_STREAM_ALAC)
		{
			string result;
			if (2 <= 935.BASS_CTYPE_STREAM_MP4)
			{
				if (2 != 935.BASS_CTYPE_STREAM_MPC)
				{
					if (2 != 935.BASS_CTYPE_STREAM_AAC)
					{
						if (2 != 935.BASS_CTYPE_STREAM_MP4)
						{
							result = text;
						}
						else
						{
							result = "MP4";
						}
					}
					else
					{
						result = "AAC";
					}
				}
				else
				{
					result = "MPC";
				}
				return result;
			}
			if (2 != 935.BASS_CTYPE_STREAM_SPX)
			{
				if (2 != 935.BASS_CTYPE_STREAM_MIDI)
				{
					if (2 != 935.BASS_CTYPE_STREAM_ALAC)
					{
						result = text;
					}
					else
					{
						result = "ALAC";
					}
				}
				else
				{
					result = "MIDI";
				}
			}
			else
			{
				result = "Speex";
			}
			return result;
		}
		else
		{
			if (2 <= 935.BASS_CTYPE_STREAM_AC3)
			{
				string result;
				if (2 != 935.BASS_CTYPE_STREAM_TTA)
				{
					if (2 != 935.BASS_CTYPE_STREAM_AC3)
					{
						result = text;
					}
					else
					{
						result = "AC3";
					}
				}
				else
				{
					result = "TTA";
				}
				return result;
			}
			switch (2)
			{
			case 935.BASS_CTYPE_MUSIC_MOD:
				return "MOD";
			case 935.BASS_CTYPE_MUSIC_MTM:
				return "MTM";
			case 935.BASS_CTYPE_MUSIC_S3M:
				return "S3M";
			case 935.BASS_CTYPE_MUSIC_XM:
				return "XM";
			case 935.BASS_CTYPE_MUSIC_IT:
				return "IT";
			default:
				if (2 != 935.BASS_CTYPE_STREAM_WAV)
				{
					switch (2)
					{
					case 935.BASS_CTYPE_STREAM_WAV_PCM:
					case 935.BASS_CTYPE_STREAM_WAV_FLOAT:
						break;
					case 935.BASS_CTYPE_RECORD | 935.BASS_CTYPE_STREAM | 935.BASS_CTYPE_STREAM_WAV:
						return text;
					default:
						return text;
					}
				}
				return "WAV";
			}
		}
	}

	// Token: 0x06005582 RID: 21890 RVA: 0x00212F80 File Offset: 0x00211180
	public static string 2(int 1)
	{
		string text = 1.ToString();
		string result;
		switch (1)
		{
		case 1:
			result = "mono";
			break;
		case 2:
			result = "stereo";
			break;
		case 3:
			result = "2.1";
			break;
		case 4:
			result = "2.2";
			break;
		case 5:
			result = "4.1";
			break;
		case 6:
			result = "5.1";
			break;
		case 7:
			result = "5.2";
			break;
		case 8:
			result = "7.1";
			break;
		default:
			result = text;
			break;
		}
		return result;
	}

	// Token: 0x06005583 RID: 21891 RVA: 0x00213002 File Offset: 0x00211202
	public static void 3(IntPtr 1, IntPtr 2, long 3)
	{
		1019.CopyMemory(1, 2, new IntPtr(3));
	}

	// Token: 0x06005584 RID: 21892
	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	private static extern void CopyMemory(IntPtr 1, IntPtr 2, IntPtr 3);

	// Token: 0x06005585 RID: 21893 RVA: 0x00213011 File Offset: 0x00211211
	public static void 4(IntPtr 1, long 2, byte 3)
	{
		1019.FillMemory(1, new IntPtr(2), 3);
	}

	// Token: 0x06005586 RID: 21894
	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	private static extern void FillMemory(IntPtr 1, IntPtr 2, byte 3);

	// Token: 0x06005587 RID: 21895 RVA: 0x00213020 File Offset: 0x00211220
	public static void 5(IntPtr 1, IntPtr 2, long 3)
	{
		1019.MoveMemory(1, 2, new IntPtr(3));
	}

	// Token: 0x06005588 RID: 21896
	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	private static extern void MoveMemory(IntPtr 1, IntPtr 2, IntPtr 3);

	// Token: 0x06005589 RID: 21897 RVA: 0x0021302F File Offset: 0x0021122F
	public static void 6(IntPtr 1, long 2)
	{
		1019.ZeroMemory(1, new IntPtr(2));
	}

	// Token: 0x0600558A RID: 21898
	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	private static extern void ZeroMemory(IntPtr 1, IntPtr 2);

	// Token: 0x0600558B RID: 21899 RVA: 0x0021303D File Offset: 0x0021123D
	public static int 7(int 1)
	{
		return 1 >> 16 & 65535;
	}

	// Token: 0x0600558C RID: 21900
	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool FreeLibrary(int 1);

	// Token: 0x0600558D RID: 21901
	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	public static extern int LoadLibrary([MarshalAs(UnmanagedType.LPTStr)] [In] string 1);

	// Token: 0x0600558E RID: 21902 RVA: 0x00213049 File Offset: 0x00211249
	public static int 8(int 1)
	{
		return 1 & 65535;
	}

	// Token: 0x0600558F RID: 21903 RVA: 0x00213052 File Offset: 0x00211252
	public static int 9(int 1, int 2)
	{
		return 2 << 16 | (1 & 65535);
	}

	// Token: 0x06005590 RID: 21904 RVA: 0x00213060 File Offset: 0x00211260
	public static double 10(double 1, double 2, double 3)
	{
		return 1 += (1019.3.NextDouble() - 1019.3.NextDouble()) * 2 / 3;
	}

	// Token: 0x0400436E RID: 17262
	private static readonly ModuleBuilder 1;

	// Token: 0x0400436F RID: 17263
	private static readonly Hashtable 2;

	// Token: 0x04004370 RID: 17264
	private static Random 3 = new Random();
}
