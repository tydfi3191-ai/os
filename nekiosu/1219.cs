using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;

// Token: 0x02000B93 RID: 2963
internal static class 1219
{
	// Token: 0x17000315 RID: 789
	// (get) Token: 0x0600512C RID: 20780 RVA: 0x00201840 File Offset: 0x001FFA40
	internal static bool IsLowLatency
	{
		get
		{
			return 1219.2 != 0;
		}
	}

	// Token: 0x17000316 RID: 790
	// (get) Token: 0x0600512D RID: 20781 RVA: 0x0020184A File Offset: 0x001FFA4A
	internal static int StreamFlags
	{
		get
		{
			if (!1219.IsLowLatency)
			{
				return 0;
			}
			return 2097152;
		}
	}

	// Token: 0x0600512E RID: 20782 RVA: 0x0020185C File Offset: 0x001FFA5C
	internal static void 1(int 1)
	{
		if (!1219.IsLowLatency || 1 == 0)
		{
			return;
		}
		bool flag = 1219.1220.BASS_ChannelSetAttribute(1, 65559, 1f);
		if (!1219.6)
		{
			1219.6 = true;
			1338.5("Low latency audio: tempo old position " + (flag ? "on" : ("not available (error " + 1219.1220.BASS_ErrorGetCode().ToString() + ")")), 1341.Runtime, (1114)2);
		}
	}

	// Token: 0x0600512F RID: 20783 RVA: 0x002018CC File Offset: 0x001FFACC
	internal static void 2(int 1)
	{
		object obj = 1219.1;
		lock (obj)
		{
			if (1219.2 != 0 && 1 != 0)
			{
				if (1219.1220.BASS_Mixer_StreamAddChannel(1219.10, 1, 8527872))
				{
					1219.3[1] = new 1219.1225();
				}
			}
		}
	}

	// Token: 0x06005130 RID: 20784 RVA: 0x00201934 File Offset: 0x001FFB34
	internal static void 3(int 1)
	{
		object obj = 1219.1;
		lock (obj)
		{
			1219.3.Remove(1);
		}
		1219.1220.BASS_StreamFree(1);
	}

	// Token: 0x06005131 RID: 20785 RVA: 0x00201980 File Offset: 0x001FFB80
	internal static int 4(int 1, bool 2)
	{
		object obj = 1219.1;
		int result;
		lock (obj)
		{
			if (1219.2 == 0)
			{
				result = 1219.1220.BASS_SampleGetChannel(1, 2);
			}
			else
			{
				1219.1224 3 = 1219.14(1);
				if (3 == null)
				{
					result = 0;
				}
				else
				{
					int num = -1;
					for (int i = 0; i < 3.8.Count; i++)
					{
						if (1219.12(3.8[i]) == 0)
						{
							num = i;
							break;
						}
					}
					if (num < 0 && 3.8.Count >= 3.4)
					{
						if (2 || (3.3 & 131072) == 0)
						{
							return 0;
						}
						long num2 = -1L;
						for (int j = 0; j < 3.8.Count; j++)
						{
							long num3 = 1219.1220.BASS_ChannelGetPosition(3.8[j], 0);
							if (num3 > num2)
							{
								num2 = num3;
								num = j;
							}
						}
					}
					int num4 = 1219.1220.BASS_StreamCreateFile(true, 3.1, 0L, (long)3.2, 2097152 | (3.3 & 260));
					if (num4 == 0)
					{
						result = 0;
					}
					else
					{
						1219.1220.BASS_ChannelSetAttribute(num4, 1, (float)3.5);
						1219.1220.BASS_ChannelSetAttribute(num4, 2, 3.6);
						1219.1220.BASS_ChannelSetAttribute(num4, 3, 3.7);
						if (!1219.1220.BASS_Mixer_StreamAddChannel(1219.11, num4, 8527872))
						{
							1219.1220.BASS_StreamFree(num4);
							result = 0;
						}
						else
						{
							if (num >= 0)
							{
								1219.13(3.8[num]);
								3.8[num] = num4;
							}
							else
							{
								3.8.Add(num4);
							}
							1219.3[num4] = new 1219.1225
							{
								1 = 1
							};
							result = num4;
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06005132 RID: 20786 RVA: 0x00201B64 File Offset: 0x001FFD64
	internal static void 5(int 1)
	{
		object obj = 1219.1;
		lock (obj)
		{
			1219.1224 2;
			if (1219.4.TryGetValue(1, out 2))
			{
				foreach (int num in 2.8)
				{
					1219.13(num);
				}
				Marshal.FreeHGlobal(2.1);
				1219.4.Remove(1);
			}
		}
		1219.1220.BASS_SampleFree(1);
	}

	// Token: 0x06005133 RID: 20787 RVA: 0x00201C0C File Offset: 0x001FFE0C
	internal static bool Play(int 1, bool 2)
	{
		object obj = 1219.1;
		bool result;
		lock (obj)
		{
			1219.1225 3;
			if (!1219.3.TryGetValue(1, out 3))
			{
				result = 1219.1220.BASS_ChannelPlay(1, 2);
			}
			else
			{
				if (2 || 3.3 || 1219.1220.BASS_ChannelIsActive(1) == 0)
				{
					1219.1220.BASS_Mixer_ChannelSetPosition(1, 0L, 65536);
				}
				3.2 = true;
				3.3 = false;
				1219.1220.BASS_Mixer_ChannelFlags(1, 0, 131072);
				result = true;
			}
		}
		return result;
	}

	// Token: 0x06005134 RID: 20788 RVA: 0x00201CA0 File Offset: 0x001FFEA0
	internal static bool Pause(int 1)
	{
		object obj = 1219.1;
		bool result;
		lock (obj)
		{
			1219.1225 2;
			if (!1219.3.TryGetValue(1, out 2))
			{
				result = 1219.1220.BASS_ChannelPause(1);
			}
			else if (1219.12(1) == 0)
			{
				result = false;
			}
			else
			{
				1219.1220.BASS_Mixer_ChannelFlags(1, 131072, 131072);
				result = true;
			}
		}
		return result;
	}

	// Token: 0x06005135 RID: 20789 RVA: 0x00201D14 File Offset: 0x001FFF14
	internal static bool 6(int 1)
	{
		object obj = 1219.1;
		bool result;
		lock (obj)
		{
			1219.1225 2;
			if (!1219.3.TryGetValue(1, out 2))
			{
				result = 1219.1220.BASS_ChannelStop(1);
			}
			else
			{
				2.3 = true;
				1219.1220.BASS_Mixer_ChannelFlags(1, 131072, 131072);
				result = true;
			}
		}
		return result;
	}

	// Token: 0x06005136 RID: 20790 RVA: 0x00201D80 File Offset: 0x001FFF80
	internal static int 7(int 1)
	{
		object obj = 1219.1;
		int result;
		lock (obj)
		{
			result = 1219.12(1);
		}
		return result;
	}

	// Token: 0x06005137 RID: 20791 RVA: 0x00201DC4 File Offset: 0x001FFFC4
	internal static long 8(int 1)
	{
		object obj = 1219.1;
		long result;
		lock (obj)
		{
			result = (1219.3.ContainsKey(1) ? 1219.1220.BASS_Mixer_ChannelGetPosition(1, 0) : 1219.1220.BASS_ChannelGetPosition(1, 0));
		}
		return result;
	}

	// Token: 0x06005138 RID: 20792 RVA: 0x00201E1C File Offset: 0x0020001C
	internal static bool 9(int 1, double 2)
	{
		object obj = 1219.1;
		bool result;
		lock (obj)
		{
			long num = 1219.1220.BASS_ChannelSeconds2Bytes(1, 2);
			1219.1225 3;
			if (!1219.3.TryGetValue(1, out 3))
			{
				result = 1219.1220.BASS_ChannelSetPosition(1, num, 0);
			}
			else
			{
				if (1219.1220.BASS_ChannelIsActive(1) == 0)
				{
					1219.1220.BASS_Mixer_ChannelFlags(1, 131072, 131072);
				}
				result = 1219.1220.BASS_Mixer_ChannelSetPosition(1, num, 65536);
			}
		}
		return result;
	}

	// Token: 0x06005139 RID: 20793 RVA: 0x00201EA4 File Offset: 0x002000A4
	internal static int 10(int 1)
	{
		object obj = 1219.1;
		int result;
		lock (obj)
		{
			result = (1219.3.ContainsKey(1) ? 1219.1220.BASS_Mixer_ChannelGetLevel(1) : 1219.1220.BASS_ChannelGetLevel(1));
		}
		return result;
	}

	// Token: 0x0600513A RID: 20794 RVA: 0x00201EFC File Offset: 0x002000FC
	internal static int 11(int 1, float[] 2, int 3)
	{
		object obj = 1219.1;
		int result;
		lock (obj)
		{
			result = (1219.3.ContainsKey(1) ? 1219.1220.BASS_Mixer_ChannelGetData(1, 2, 3) : 1219.1220.BASS_ChannelGetData(1, 2, 3));
		}
		return result;
	}

	// Token: 0x0600513B RID: 20795 RVA: 0x00201F58 File Offset: 0x00200158
	private static int 12(int 1)
	{
		1219.1225 2;
		if (!1219.3.TryGetValue(1, out 2))
		{
			return 1219.1220.BASS_ChannelIsActive(1);
		}
		if (!2.2 || 2.3)
		{
			return 0;
		}
		int num = 1219.1220.BASS_ChannelIsActive(1);
		if (num == 0)
		{
			return num;
		}
		if ((1219.1220.BASS_Mixer_ChannelFlags(1, 0, 0) & 131072) == 0)
		{
			return num;
		}
		return 3;
	}

	// Token: 0x0600513C RID: 20796 RVA: 0x00201FAC File Offset: 0x002001AC
	private static void 13(int 1)
	{
		1219.3.Remove(1);
		1219.1220.BASS_StreamFree(1);
	}

	// Token: 0x0600513D RID: 20797 RVA: 0x00201FC4 File Offset: 0x002001C4
	private static 1219.1224 14(int 1)
	{
		if (1 == 0 || 1 == -1)
		{
			return null;
		}
		1219.1224 2;
		if (1219.4.TryGetValue(1, out 2))
		{
			return 2;
		}
		1219.1220.1221 3 = default(1219.1220.1221);
		if (!1219.1220.BASS_SampleGetInfo(1, ref 3) || 3.5 <= 0 || 3.8 <= 0)
		{
			return null;
		}
		bool flag = (3.4 & 256) != 0;
		int num = flag ? 32 : (((3.4 & 1) != 0) ? 8 : 16);
		int num2 = 3.8 * num / 8;
		IntPtr intPtr = Marshal.AllocHGlobal(44 + 3.5);
		byte[] source = new byte[44];
		1219.15(source, 0, "RIFF");
		1219.16(source, 4, 36 + 3.5);
		1219.15(source, 8, "WAVE");
		1219.15(source, 12, "fmt ");
		1219.16(source, 16, 16);
		1219.17(source, 20, flag ? 3 : 1);
		1219.17(source, 22, 3.8);
		1219.16(source, 24, 3.1);
		1219.16(source, 28, 3.1 * num2);
		1219.17(source, 32, num2);
		1219.17(source, 34, num);
		1219.15(source, 36, "data");
		1219.16(source, 40, 3.5);
		Marshal.Copy(source, 0, intPtr, 44);
		if (!1219.1220.BASS_SampleGetData(1, intPtr + 44))
		{
			Marshal.FreeHGlobal(intPtr);
			return null;
		}
		2 = new 1219.1224
		{
			1 = intPtr,
			2 = 44 + 3.5,
			3 = 3.4,
			4 = Math.Max(1, 3.6),
			5 = 3.1,
			6 = 3.2,
			7 = 3.3
		};
		1219.4[1] = 2;
		return 2;
	}

	// Token: 0x0600513E RID: 20798 RVA: 0x00202194 File Offset: 0x00200394
	private static void 15(byte[] 1, int 2, string 3)
	{
		for (int i = 0; i < 3.Length; i++)
		{
			1[2 + i] = (byte)3[i];
		}
	}

	// Token: 0x0600513F RID: 20799 RVA: 0x002021BF File Offset: 0x002003BF
	private static void 16(byte[] 1, int 2, int 3)
	{
		1[2] = (byte)3;
		1[2 + 1] = (byte)(3 >> 8);
		1[2 + 2] = (byte)(3 >> 16);
		1[2 + 3] = (byte)(3 >> 24);
	}

	// Token: 0x06005140 RID: 20800 RVA: 0x002021E3 File Offset: 0x002003E3
	private static void 17(byte[] 1, int 2, int 3)
	{
		1[2] = (byte)3;
		1[2 + 1] = (byte)(3 >> 8);
	}

	// Token: 0x17000317 RID: 791
	// (get) Token: 0x06005141 RID: 20801 RVA: 0x002021F3 File Offset: 0x002003F3
	// (set) Token: 0x06005142 RID: 20802 RVA: 0x002021FA File Offset: 0x002003FA
	internal static string StartError { get; private set; }

	// Token: 0x17000318 RID: 792
	// (get) Token: 0x06005143 RID: 20803 RVA: 0x00202202 File Offset: 0x00200402
	internal static bool Wanted
	{
		get
		{
			return 1219.8 && 1304.181.1() && !1304.180.1();
		}
	}

	// Token: 0x17000319 RID: 793
	// (get) Token: 0x06005144 RID: 20804 RVA: 0x00202226 File Offset: 0x00200426
	internal static bool NeedsRestart
	{
		get
		{
			return 1304.181.1() != 1219.8;
		}
	}

	// Token: 0x06005145 RID: 20805 RVA: 0x0020223C File Offset: 0x0020043C
	internal static void 18()
	{
		if (1219.Wanted)
		{
			if (1219.13 < 0)
			{
				1219.13 = 1219.1220.BASS_GetConfig(50);
				1219.14 = 1219.1220.BASS_GetConfig(70);
			}
			bool flag = 1219.1220.BASS_SetConfig(50, 1);
			bool flag2 = 1219.1220.BASS_SetConfig(70, 0);
			1338.5(string.Format("Low latency audio: device non-stop {0}, device timeout off {1}", flag ? "on" : "not available", flag2 ? "set" : "not available"), 1341.Runtime, (1114)2);
			return;
		}
		if (1219.13 >= 0)
		{
			1219.1220.BASS_SetConfig(50, 1219.13);
			if (1219.14 >= 0)
			{
				1219.1220.BASS_SetConfig(70, 1219.14);
			}
			1219.13 = -1;
			1219.14 = -1;
		}
	}

	// Token: 0x06005146 RID: 20806 RVA: 0x002022E8 File Offset: 0x002004E8
	internal static bool Start(string 1, bool 2)
	{
		1219.StartError = null;
		if (1304.181.1() && !1219.8 && 1219.21 != null)
		{
			return 1219.22("osu!lazer's audio engine could not be loaded: " + 1219.21);
		}
		if (!1219.Wanted)
		{
			return false;
		}
		bool result;
		try
		{
			int num = 2 ? -1 : 1219.27(1);
			if (!2 && num < 0)
			{
				result = 1219.22("the audio device was not found");
			}
			else
			{
				int num2 = (num >= 0) ? num : 1219.28();
				1219.1220.1222 3;
				if (num2 < 0 || !1219.1220.BASS_WASAPI_GetDeviceInfo(num2, out 3))
				{
					result = 1219.22("no output device");
				}
				else
				{
					IntPtr value = 1219.24();
					if (value == IntPtr.Zero)
					{
						result = 1219.22("no WASAPI callback");
					}
					else
					{
						int num3 = (3.7 > 0) ? 3.7 : 48000;
						int num4 = (3.8 > 0) ? 3.8 : 2;
						int num5 = 0;
						for (int i = 0; i < 2; i++)
						{
							num5 = 1219.1220.BASS_Mixer_StreamCreate(num3, num4, 2228480);
							if (num5 == 0)
							{
								return 1219.22("mixer error " + 1219.1220.BASS_ErrorGetCode().ToString());
							}
							if (!1219.1220.BASS_WASAPI_Init(num, 0, 0, 18, 0f, 1E-45f, value, new IntPtr(num5)))
							{
								int num6 = 1219.1220.BASS_ErrorGetCode();
								1219.1220.BASS_StreamFree(num5);
								return 1219.22(1219.21(num6));
							}
							1219.1220.1223 4;
							1219.1220.BASS_WASAPI_GetInfo(out 4);
							if (4.2 == num3 && 4.3 == num4)
							{
								break;
							}
							1219.1220.BASS_WASAPI_Free();
							1219.1220.BASS_StreamFree(num5);
							num5 = 0;
							num3 = 4.2;
							num4 = 4.3;
						}
						if (num5 == 0)
						{
							result = 1219.22("the device's format changed");
						}
						else
						{
							int num7 = 1219.19(num5);
							int num8 = 1219.19(num5);
							if (num7 == 0 || num8 == 0 || !1219.20(Marshal.PtrToStringAnsi(3.1)))
							{
								int num9 = 1219.1220.BASS_ErrorGetCode();
								1219.1220.BASS_WASAPI_Free();
								1219.1220.BASS_StreamFree(num7);
								1219.1220.BASS_StreamFree(num8);
								1219.1220.BASS_StreamFree(num5);
								result = 1219.22("WASAPI start error " + num9.ToString());
							}
							else
							{
								1219.2 = num5;
								1219.10 = num7;
								1219.11 = num8;
								result = true;
							}
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			result = 1219.22(ex.Message);
		}
		return result;
	}

	// Token: 0x06005147 RID: 20807 RVA: 0x0020256C File Offset: 0x0020076C
	private static int 19(int 1)
	{
		int num = 1219.1220.BASS_Mixer_StreamCreate(44100, 2, 2228224);
		if (num == 0)
		{
			return 0;
		}
		1219.1220.BASS_ChannelSetAttribute(num, 13, 0f);
		if (!1219.1220.BASS_Mixer_StreamAddChannel(1, num, 8396800))
		{
			1219.1220.BASS_StreamFree(num);
			return 0;
		}
		return num;
	}

	// Token: 0x06005148 RID: 20808 RVA: 0x002025B8 File Offset: 0x002007B8
	private static bool 20(string 1)
	{
		1219.9 = 1219.1220.BASS_WASAPI_GetDevice();
		if (!1219.1220.BASS_WASAPI_Start())
		{
			return false;
		}
		1219.1220.1223 2;
		1219.1220.BASS_WASAPI_GetInfo(out 2);
		int num = Math.Max(1, 2.2 * 2.3 * 4);
		1219.16 = Math.Max(0, 2.5);
		1219.17 = num;
		1338.5(string.Format("Low latency audio started: {0}, {1} Hz, {2} channels, buffer {3:0.0} ms, BASS {4:X8}, BASSmix {5:X8}, BASSWASAPI {6:X8}", new object[]
		{
			1,
			2.2,
			2.3,
			(double)2.5 * 1000.0 / (double)num,
			1219.1220.BASS_GetVersion(),
			1219.1220.BASS_Mixer_GetVersion(),
			1219.1220.BASS_WASAPI_GetVersion()
		}), 1341.Runtime, (1114)2);
		return true;
	}

	// Token: 0x06005149 RID: 20809 RVA: 0x00202688 File Offset: 0x00200888
	private static string 21(int 1)
	{
		if (1 <= 37)
		{
			if (1 == 6)
			{
				return "the device does not take its usual format";
			}
			if (1 == 37)
			{
				return "not available on this device";
			}
		}
		else
		{
			if (1 == 46)
			{
				return "the device is in use";
			}
			if (1 == 5003)
			{
				return "access denied";
			}
		}
		return "WASAPI error " + 1.ToString();
	}

	// Token: 0x0600514A RID: 20810 RVA: 0x002026DD File Offset: 0x002008DD
	private static bool 22(string 1)
	{
		1219.StartError = 1;
		1338.5("Low latency audio could not start: " + 1, 1341.Runtime, (1114)2);
		return false;
	}

	// Token: 0x0600514B RID: 20811 RVA: 0x002026F8 File Offset: 0x002008F8
	internal static void 23()
	{
		object obj = 1219.1;
		lock (obj)
		{
			if (1219.2 != 0)
			{
				try
				{
					1219.1220.BASS_WASAPI_Stop(true);
					1219.1220.BASS_WASAPI_Free();
				}
				catch (Exception)
				{
				}
				foreach (int key in 1219.3.Keys)
				{
					if (1219.3[key].1 != 0)
					{
						1219.1220.BASS_StreamFree(key);
					}
				}
				1219.3.Clear();
				foreach (1219.1224 <<EMPTY_NAME>> in 1219.4.Values)
				{
					Marshal.FreeHGlobal(<<EMPTY_NAME>>.1);
				}
				1219.4.Clear();
				1219.1220.BASS_StreamFree(1219.10);
				1219.1220.BASS_StreamFree(1219.11);
				1219.1220.BASS_StreamFree(1219.2);
				1219.10 = 0;
				1219.11 = 0;
				1219.2 = 0;
				1219.9 = -1;
			}
		}
	}

	// Token: 0x0600514C RID: 20812 RVA: 0x0020284C File Offset: 0x00200A4C
	private static IntPtr 24()
	{
		if (1219.15 != IntPtr.Zero)
		{
			return 1219.15;
		}
		IntPtr procAddress = 1219.1220.GetProcAddress(1219.1220.GetModuleHandle("bass.dll"), "BASS_ChannelGetData");
		if (IntPtr.Size != 4 || procAddress == IntPtr.Zero)
		{
			return IntPtr.Zero;
		}
		byte[] array = new byte[]
		{
			139,
			68,
			36,
			8,
			80,
			139,
			68,
			36,
			8,
			80,
			139,
			68,
			36,
			20,
			80,
			184,
			0,
			0,
			0,
			0,
			byte.MaxValue,
			208,
			194,
			12,
			0
		};
		BitConverter.GetBytes(procAddress.ToInt32()).CopyTo(array, 16);
		IntPtr intPtr = 1219.1220.VirtualAlloc(IntPtr.Zero, new UIntPtr((uint)array.Length), 12288U, 4U);
		if (intPtr == IntPtr.Zero)
		{
			return IntPtr.Zero;
		}
		Marshal.Copy(array, 0, intPtr, array.Length);
		uint num;
		if (!1219.1220.VirtualProtect(intPtr, new UIntPtr((uint)array.Length), 32U, out num))
		{
			return IntPtr.Zero;
		}
		1219.1220.FlushInstructionCache(1219.1220.GetCurrentProcess(), intPtr, new UIntPtr((uint)array.Length));
		return 1219.15 = intPtr;
	}

	// Token: 0x0600514D RID: 20813 RVA: 0x00202934 File Offset: 0x00200B34
	private static int 25()
	{
		if (1219.9 < 0 || !1219.1220.BASS_WASAPI_SetDevice(1219.9))
		{
			return 0;
		}
		int num = 1219.1220.BASS_WASAPI_GetData(IntPtr.Zero, 0);
		if (num <= 0)
		{
			return 0;
		}
		return num;
	}

	// Token: 0x0600514E RID: 20814 RVA: 0x0020296C File Offset: 0x00200B6C
	internal static void 26(double 1, double 2, bool 3)
	{
		if (1219.2 == 0 || !3 || 2 <= 0.0)
		{
			1219.19 = -1L;
			return;
		}
		long elapsedMilliseconds = 1219.18.ElapsedMilliseconds;
		if (1219.19 < 0L)
		{
			1219.19 = elapsedMilliseconds;
			1219.20 = 1;
			return;
		}
		long num = elapsedMilliseconds - 1219.19;
		if (num < 5000L)
		{
			return;
		}
		double num2 = (1 - 1219.20) / 2;
		double num3 = (double)1219.25() * 1000.0 / (double)1219.17;
		1338.5(string.Format(1662.18, "Low latency audio timing: driver reports {0:0.0} ms waiting, buffer {1:0.0} ms; the song moved {2:0} ms in {3} ms", new object[]
		{
			num3,
			(double)1219.16 * 1000.0 / (double)1219.17,
			num2,
			num
		}), 1341.Runtime, (1114)2);
		1219.19 = elapsedMilliseconds;
		1219.20 = 1;
	}

	// Token: 0x0600514F RID: 20815 RVA: 0x00202A50 File Offset: 0x00200C50
	private static int 27(string 1)
	{
		if (string.IsNullOrEmpty(1))
		{
			return -1;
		}
		int num = 0;
		1219.1220.1222 2;
		while (num < 4096 && 1219.1220.BASS_WASAPI_GetDeviceInfo(num, out 2))
		{
			if ((2.4 & 24) == 0 && (2.4 & 1) != 0 && Marshal.PtrToStringAnsi(2.2) == 1)
			{
				return num;
			}
			num++;
		}
		return -1;
	}

	// Token: 0x06005150 RID: 20816 RVA: 0x00202AAC File Offset: 0x00200CAC
	private static int 28()
	{
		int num = 0;
		1219.1220.1222 <<EMPTY_NAME>>;
		while (num < 4096 && 1219.1220.BASS_WASAPI_GetDeviceInfo(num, out <<EMPTY_NAME>>))
		{
			if ((<<EMPTY_NAME>>.4 & 24) == 0 && (<<EMPTY_NAME>>.4 & 3) == 3)
			{
				return num;
			}
			num++;
		}
		return -1;
	}

	// Token: 0x1700031A RID: 794
	// (get) Token: 0x06005151 RID: 20817 RVA: 0x00202AEC File Offset: 0x00200CEC
	internal static bool LazerEngineLoaded
	{
		get
		{
			return 1219.8;
		}
	}

	// Token: 0x06005152 RID: 20818 RVA: 0x00202AF4 File Offset: 0x00200CF4
	internal static void 29()
	{
		if (1219.8)
		{
			return;
		}
		try
		{
			if (1219.1220.GetModuleHandle("bass.dll") != IntPtr.Zero)
			{
				1219.21 = "osu!'s BASS was loaded first";
			}
			else
			{
				1219.8 = 1219.30();
			}
		}
		catch (Exception ex)
		{
			1219.21 = ex.Message;
		}
	}

	// Token: 0x06005153 RID: 20819 RVA: 0x00202B54 File Offset: 0x00200D54
	private static bool 30()
	{
		string text = Path.Combine(268.DataDirectory ?? AppDomain.CurrentDomain.BaseDirectory, "native");
		Directory.CreateDirectory(text);
		foreach (string text2 in 1219.7)
		{
			byte[] array2;
			using (Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("nekiosu.native." + text2))
			{
				if (manifestResourceStream == null)
				{
					1219.21 = text2 + " is missing";
					return false;
				}
				array2 = new byte[manifestResourceStream.Length];
				int num;
				for (int j = 0; j < array2.Length; j += num)
				{
					num = manifestResourceStream.Read(array2, j, array2.Length - j);
					if (num <= 0)
					{
						break;
					}
				}
			}
			string path = Path.Combine(text, text2);
			if (!File.Exists(path) || !1219.31(File.ReadAllBytes(path), array2))
			{
				File.WriteAllBytes(path, array2);
			}
			if (1219.1220.LoadLibrary(path) == IntPtr.Zero)
			{
				1219.21 = text2 + " could not be loaded (error " + Marshal.GetLastWin32Error().ToString() + ")";
				return false;
			}
		}
		return true;
	}

	// Token: 0x06005154 RID: 20820 RVA: 0x00202C9C File Offset: 0x00200E9C
	private static bool 31(byte[] 1, byte[] 2)
	{
		if (1.Length != 2.Length)
		{
			return false;
		}
		for (int i = 0; i < 1.Length; i++)
		{
			if (1[i] != 2[i])
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x04003DC8 RID: 15816
	private static readonly object 1 = new object();

	// Token: 0x04003DC9 RID: 15817
	private static int 2;

	// Token: 0x04003DCA RID: 15818
	private static readonly Dictionary<int, 1219.1225> 3 = new Dictionary<int, 1219.1225>();

	// Token: 0x04003DCB RID: 15819
	private static readonly Dictionary<int, 1219.1224> 4 = new Dictionary<int, 1219.1224>();

	// Token: 0x04003DCC RID: 15820
	private const int 5 = 65559;

	// Token: 0x04003DCD RID: 15821
	private static bool 6;

	// Token: 0x04003DCE RID: 15822
	private static readonly string[] 7 = new string[]
	{
		"bass.dll",
		"bass_fx.dll",
		"bassmix.dll",
		"basswasapi.dll"
	};

	// Token: 0x04003DCF RID: 15823
	private static bool 8;

	// Token: 0x04003DD0 RID: 15824
	private static int 9 = -1;

	// Token: 0x04003DD1 RID: 15825
	private static int 10;

	// Token: 0x04003DD2 RID: 15826
	private static int 11;

	// Token: 0x04003DD3 RID: 15827
	private const int 12 = 44100;

	// Token: 0x04003DD5 RID: 15829
	private static int 13 = -1;

	// Token: 0x04003DD6 RID: 15830
	private static int 14 = -1;

	// Token: 0x04003DD7 RID: 15831
	private static IntPtr 15;

	// Token: 0x04003DD8 RID: 15832
	private static int 16;

	// Token: 0x04003DD9 RID: 15833
	private static int 17 = 1;

	// Token: 0x04003DDA RID: 15834
	private static readonly Stopwatch 18 = Stopwatch.StartNew();

	// Token: 0x04003DDB RID: 15835
	private static long 19 = -1L;

	// Token: 0x04003DDC RID: 15836
	private static double 20;

	// Token: 0x04003DDD RID: 15837
	private static string 21;

	// Token: 0x02000B94 RID: 2964
	private sealed class 1225
	{
		// Token: 0x04003DDE RID: 15838
		public int 1;

		// Token: 0x04003DDF RID: 15839
		public bool 2;

		// Token: 0x04003DE0 RID: 15840
		public bool 3;
	}

	// Token: 0x02000B95 RID: 2965
	private sealed class 1224
	{
		// Token: 0x04003DE1 RID: 15841
		public IntPtr 1;

		// Token: 0x04003DE2 RID: 15842
		public int 2;

		// Token: 0x04003DE3 RID: 15843
		public int 3;

		// Token: 0x04003DE4 RID: 15844
		public int 4;

		// Token: 0x04003DE5 RID: 15845
		public int 5;

		// Token: 0x04003DE6 RID: 15846
		public float 6;

		// Token: 0x04003DE7 RID: 15847
		public float 7;

		// Token: 0x04003DE8 RID: 15848
		public readonly List<int> 8 = new List<int>();
	}

	// Token: 0x02000B96 RID: 2966
	[SuppressUnmanagedCodeSecurity]
	private static class 1220
	{
		// Token: 0x06005158 RID: 20824
		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		public static extern IntPtr LoadLibrary(string 1);

		// Token: 0x06005159 RID: 20825
		[DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
		public static extern IntPtr GetModuleHandle(string 1);

		// Token: 0x0600515A RID: 20826
		[DllImport("kernel32.dll", BestFitMapping = false, CharSet = CharSet.Ansi)]
		public static extern IntPtr GetProcAddress(IntPtr 1, string 2);

		// Token: 0x0600515B RID: 20827
		[DllImport("kernel32.dll")]
		public static extern IntPtr VirtualAlloc(IntPtr 1, UIntPtr 2, uint 3, uint 4);

		// Token: 0x0600515C RID: 20828
		[DllImport("kernel32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool VirtualProtect(IntPtr 1, UIntPtr 2, uint 3, out uint 4);

		// Token: 0x0600515D RID: 20829
		[DllImport("kernel32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool FlushInstructionCache(IntPtr 1, IntPtr 2, UIntPtr 3);

		// Token: 0x0600515E RID: 20830
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetCurrentProcess();

		// Token: 0x0600515F RID: 20831
		[DllImport("bass.dll")]
		public static extern int BASS_GetVersion();

		// Token: 0x06005160 RID: 20832
		[DllImport("bass.dll")]
		public static extern int BASS_ErrorGetCode();

		// Token: 0x06005161 RID: 20833
		[DllImport("bass.dll")]
		public static extern int BASS_GetConfig(int 1);

		// Token: 0x06005162 RID: 20834
		[DllImport("bass.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool BASS_SetConfig(int 1, int 2);

		// Token: 0x06005163 RID: 20835
		[DllImport("bass.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool BASS_SampleGetInfo(int 1, ref 1219.1220.1221 2);

		// Token: 0x06005164 RID: 20836
		[DllImport("bass.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool BASS_SampleGetData(int 1, IntPtr 2);

		// Token: 0x06005165 RID: 20837
		[DllImport("bass.dll")]
		public static extern int BASS_SampleGetChannel(int 1, [MarshalAs(UnmanagedType.Bool)] bool 2);

		// Token: 0x06005166 RID: 20838
		[DllImport("bass.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool BASS_SampleFree(int 1);

		// Token: 0x06005167 RID: 20839
		[DllImport("bass.dll")]
		public static extern int BASS_StreamCreateFile([MarshalAs(UnmanagedType.Bool)] bool 1, IntPtr 2, long 3, long 4, int 5);

		// Token: 0x06005168 RID: 20840
		[DllImport("bass.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool BASS_StreamFree(int 1);

		// Token: 0x06005169 RID: 20841
		[DllImport("bass.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool BASS_ChannelPlay(int 1, [MarshalAs(UnmanagedType.Bool)] bool 2);

		// Token: 0x0600516A RID: 20842
		[DllImport("bass.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool BASS_ChannelPause(int 1);

		// Token: 0x0600516B RID: 20843
		[DllImport("bass.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool BASS_ChannelStop(int 1);

		// Token: 0x0600516C RID: 20844
		[DllImport("bass.dll")]
		public static extern int BASS_ChannelIsActive(int 1);

		// Token: 0x0600516D RID: 20845
		[DllImport("bass.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool BASS_ChannelSetAttribute(int 1, int 2, float 3);

		// Token: 0x0600516E RID: 20846
		[DllImport("bass.dll")]
		public static extern long BASS_ChannelGetPosition(int 1, int 2);

		// Token: 0x0600516F RID: 20847
		[DllImport("bass.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool BASS_ChannelSetPosition(int 1, long 2, int 3);

		// Token: 0x06005170 RID: 20848
		[DllImport("bass.dll")]
		public static extern long BASS_ChannelSeconds2Bytes(int 1, double 2);

		// Token: 0x06005171 RID: 20849
		[DllImport("bass.dll")]
		public static extern int BASS_ChannelGetLevel(int 1);

		// Token: 0x06005172 RID: 20850
		[DllImport("bass.dll")]
		public static extern int BASS_ChannelGetData(int 1, [In] [Out] float[] 2, int 3);

		// Token: 0x06005173 RID: 20851
		[DllImport("bassmix.dll")]
		public static extern int BASS_Mixer_GetVersion();

		// Token: 0x06005174 RID: 20852
		[DllImport("bassmix.dll")]
		public static extern int BASS_Mixer_StreamCreate(int 1, int 2, int 3);

		// Token: 0x06005175 RID: 20853
		[DllImport("bassmix.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool BASS_Mixer_StreamAddChannel(int 1, int 2, int 3);

		// Token: 0x06005176 RID: 20854
		[DllImport("bassmix.dll")]
		public static extern int BASS_Mixer_ChannelFlags(int 1, int 2, int 3);

		// Token: 0x06005177 RID: 20855
		[DllImport("bassmix.dll")]
		public static extern long BASS_Mixer_ChannelGetPosition(int 1, int 2);

		// Token: 0x06005178 RID: 20856
		[DllImport("bassmix.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool BASS_Mixer_ChannelSetPosition(int 1, long 2, int 3);

		// Token: 0x06005179 RID: 20857
		[DllImport("bassmix.dll")]
		public static extern int BASS_Mixer_ChannelGetLevel(int 1);

		// Token: 0x0600517A RID: 20858
		[DllImport("bassmix.dll")]
		public static extern int BASS_Mixer_ChannelGetData(int 1, [In] [Out] float[] 2, int 3);

		// Token: 0x0600517B RID: 20859
		[DllImport("basswasapi.dll")]
		public static extern int BASS_WASAPI_GetVersion();

		// Token: 0x0600517C RID: 20860
		[DllImport("basswasapi.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool BASS_WASAPI_GetDeviceInfo(int 1, out 1219.1220.1222 2);

		// Token: 0x0600517D RID: 20861
		[DllImport("basswasapi.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool BASS_WASAPI_Init(int 1, int 2, int 3, int 4, float 5, float 6, IntPtr 7, IntPtr 8);

		// Token: 0x0600517E RID: 20862
		[DllImport("basswasapi.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool BASS_WASAPI_Free();

		// Token: 0x0600517F RID: 20863
		[DllImport("basswasapi.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool BASS_WASAPI_Start();

		// Token: 0x06005180 RID: 20864
		[DllImport("basswasapi.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool BASS_WASAPI_Stop([MarshalAs(UnmanagedType.Bool)] bool 1);

		// Token: 0x06005181 RID: 20865
		[DllImport("basswasapi.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool BASS_WASAPI_IsStarted();

		// Token: 0x06005182 RID: 20866
		[DllImport("basswasapi.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool BASS_WASAPI_GetInfo(out 1219.1220.1223 1);

		// Token: 0x06005183 RID: 20867
		[DllImport("basswasapi.dll")]
		public static extern int BASS_WASAPI_GetDevice();

		// Token: 0x06005184 RID: 20868
		[DllImport("basswasapi.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool BASS_WASAPI_SetDevice(int 1);

		// Token: 0x06005185 RID: 20869
		[DllImport("basswasapi.dll")]
		public static extern int BASS_WASAPI_GetData(IntPtr 1, int 2);

		// Token: 0x04003DE9 RID: 15849
		public const int 1 = 4;

		// Token: 0x04003DEA RID: 15850
		public const int 2 = 1;

		// Token: 0x04003DEB RID: 15851
		public const int 3 = 256;

		// Token: 0x04003DEC RID: 15852
		public const int 4 = 131072;

		// Token: 0x04003DED RID: 15853
		public const int 5 = 2097152;

		// Token: 0x04003DEE RID: 15854
		public const int 6 = 131072;

		// Token: 0x04003DEF RID: 15855
		public const int 7 = 8192;

		// Token: 0x04003DF0 RID: 15856
		public const int 8 = 131072;

		// Token: 0x04003DF1 RID: 15857
		public const int 9 = 8388608;

		// Token: 0x04003DF2 RID: 15858
		public const int 10 = 0;

		// Token: 0x04003DF3 RID: 15859
		public const int 11 = 65536;

		// Token: 0x04003DF4 RID: 15860
		public const int 12 = 0;

		// Token: 0x04003DF5 RID: 15861
		public const int 13 = 3;

		// Token: 0x04003DF6 RID: 15862
		public const int 14 = 0;

		// Token: 0x04003DF7 RID: 15863
		public const int 15 = 2;

		// Token: 0x04003DF8 RID: 15864
		public const int 16 = 3;

		// Token: 0x04003DF9 RID: 15865
		public const int 17 = 1;

		// Token: 0x04003DFA RID: 15866
		public const int 18 = 13;

		// Token: 0x04003DFB RID: 15867
		public const int 19 = 50;

		// Token: 0x04003DFC RID: 15868
		public const int 20 = 70;

		// Token: 0x04003DFD RID: 15869
		public const int 21 = 2;

		// Token: 0x04003DFE RID: 15870
		public const int 22 = 16;

		// Token: 0x04003DFF RID: 15871
		public const int 23 = 1;

		// Token: 0x04003E00 RID: 15872
		public const int 24 = 2;

		// Token: 0x04003E01 RID: 15873
		public const int 25 = 8;

		// Token: 0x04003E02 RID: 15874
		public const int 26 = 16;

		// Token: 0x04003E03 RID: 15875
		public const uint 27 = 12288U;

		// Token: 0x04003E04 RID: 15876
		public const uint 28 = 4U;

		// Token: 0x04003E05 RID: 15877
		public const uint 29 = 32U;

		// Token: 0x02000B97 RID: 2967
		public struct 1221
		{
			// Token: 0x04003E06 RID: 15878
			public int 1;

			// Token: 0x04003E07 RID: 15879
			public float 2;

			// Token: 0x04003E08 RID: 15880
			public float 3;

			// Token: 0x04003E09 RID: 15881
			public int 4;

			// Token: 0x04003E0A RID: 15882
			public int 5;

			// Token: 0x04003E0B RID: 15883
			public int 6;

			// Token: 0x04003E0C RID: 15884
			public int 7;

			// Token: 0x04003E0D RID: 15885
			public int 8;

			// Token: 0x04003E0E RID: 15886
			public int 9;

			// Token: 0x04003E0F RID: 15887
			public int 10;

			// Token: 0x04003E10 RID: 15888
			public float 11;

			// Token: 0x04003E11 RID: 15889
			public float 12;

			// Token: 0x04003E12 RID: 15890
			public int 13;

			// Token: 0x04003E13 RID: 15891
			public int 14;

			// Token: 0x04003E14 RID: 15892
			public float 15;

			// Token: 0x04003E15 RID: 15893
			public int 16;

			// Token: 0x04003E16 RID: 15894
			public int 17;
		}

		// Token: 0x02000B98 RID: 2968
		public struct 1222
		{
			// Token: 0x04003E17 RID: 15895
			public IntPtr 1;

			// Token: 0x04003E18 RID: 15896
			public IntPtr 2;

			// Token: 0x04003E19 RID: 15897
			public int 3;

			// Token: 0x04003E1A RID: 15898
			public int 4;

			// Token: 0x04003E1B RID: 15899
			public float 5;

			// Token: 0x04003E1C RID: 15900
			public float 6;

			// Token: 0x04003E1D RID: 15901
			public int 7;

			// Token: 0x04003E1E RID: 15902
			public int 8;
		}

		// Token: 0x02000B99 RID: 2969
		public struct 1223
		{
			// Token: 0x04003E1F RID: 15903
			public int 1;

			// Token: 0x04003E20 RID: 15904
			public int 2;

			// Token: 0x04003E21 RID: 15905
			public int 3;

			// Token: 0x04003E22 RID: 15906
			public int 4;

			// Token: 0x04003E23 RID: 15907
			public int 5;

			// Token: 0x04003E24 RID: 15908
			public float 6;

			// Token: 0x04003E25 RID: 15909
			public float 7;

			// Token: 0x04003E26 RID: 15910
			public float 8;
		}
	}
}
