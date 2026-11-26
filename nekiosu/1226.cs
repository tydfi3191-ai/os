using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using osu_gameplay;
using osu_ui;

// Token: 0x02000B9A RID: 2970
public static class 1226
{
	// Token: 0x06005186 RID: 20870 RVA: 0x00202D5E File Offset: 0x00200F5E
	internal static bool 1()
	{
		return 1226.53;
	}

	// Token: 0x06005187 RID: 20871 RVA: 0x00202D68 File Offset: 0x00200F68
	internal static void 2(bool 1)
	{
		1226.53 = 1;
		if (!1226.53 && 1226.4)
		{
			if (1226.16 < 0)
			{
				1226.8();
				1226.4(0, false, false);
				return;
			}
			if (1226.16 > 1226.9())
			{
				1226.8();
				1226.4(1226.9(), false, false);
			}
		}
	}

	// Token: 0x06005188 RID: 20872 RVA: 0x00202DBC File Offset: 0x00200FBC
	internal static void 3()
	{
		if (1226.31 == null)
		{
			return;
		}
		1226.31.Update();
		if (1226.1())
		{
			if (1226.16 < -1226.20 || 1226.16 > 1226.9() - 1226.20)
			{
				if (!1226.4 && 1226.32 != (1042)1)
				{
					1226.4 = true;
					1226.31.Pause();
				}
			}
			else if (1226.4)
			{
				1226.4 = false;
				1226.58 = false;
				1226.11 = -1;
				if (1226.32 == (1042)1)
				{
					if (!1226.31.IsPlaying())
					{
						1226.31.Seek((double)(1226.16 + 1226.20));
						1226.31.Play(true);
					}
				}
				else
				{
					1226.31.Seek((double)(1226.16 + 1226.20));
				}
			}
		}
		double position = 1226.31.GetPosition();
		if (!1226.4 && 1226.32 != (1042)0 && (1226.31 == null || position == 1226.31.4))
		{
			1226.32 = (1042)0;
		}
		double num = 1226.38() / 100.0 * (double)(1226.30 / 1226.29);
		double num2 = (1662.115 == 1226.55) ? 0.0 : (1662.82 * num);
		1226.55 = 1662.115;
		if (1226.4)
		{
			if (!1226.5)
			{
				1226.10 = (double)1052.18(1226.16, -1226.20, 1226.9() - 1226.20);
			}
			if (1226.32 == (1042)1 && num2 < 60.0)
			{
				1226.22 += num2;
				1226.10 += num2;
			}
		}
		else if (1226.58)
		{
			1226.10 = (double)1226.11;
			1226.54 = 1662.33;
		}
		else if (1226.31 != null)
		{
			double num3 = position;
			bool flag = 1226.32 != (1042)1 || 1226.10 == 0.0 || num3 == 0.0 || 2486.4;
			if (!flag)
			{
				double num4 = 1226.10 + num2;
				double num5 = num4 - num3;
				num4 -= num5 / 8.0;
				num5 = num4 - num3;
				double num6 = (double)((1662.33 - 1226.54 < 1500 || 1226.38() < 100.0) ? 11 : 33);
				if (Math.Abs(num5) > num6 * 2.0)
				{
					flag = true;
					if (1226.30 == 1226.29 && 1662.50())
					{
					}
				}
				else if (num5 < 0.0 - num6)
				{
					1226.10 += num2 * 2.0;
					1226.54 = 1662.33;
				}
				else if (num5 < num6)
				{
					1226.10 = num4;
				}
				else
				{
					1226.10 += num2 / 2.0;
					1226.54 = 1662.33;
				}
			}
			if (flag)
			{
				1226.10 = num3;
				1226.54 = 1662.33;
			}
		}
		else
		{
			1226.10 = 0.0;
		}
		1226.19 = (int)Math.Round(1226.10);
		double num7 = 0.0;
		double num8 = (double)((1272.5() != null && 1272.5().32 < 5 && 1662.78 != 1677.Edit) ? 24 : 0);
		if (1226.65)
		{
			num7 -= 15.0;
		}
		if (1219.IsLowLatency)
		{
			num7 += 25.0;
		}
		double num9 = num8 + (double)((1662.78 != 1677.Edit && 1272.5() != null) ? (1272.5().72 + 1272.5().67) : 0);
		num7 -= (double)1304.154.6();
		1226.20 = (int)(num9 + num7 * (1226.38() / 100.0));
		if (!1226.58 && (1226.32 != (1042)0 || 1226.16 != 0))
		{
			1226.16 = 1226.19 - 1226.20;
		}
		else
		{
			1226.16 = 1226.19;
		}
		1226.17 = 1226.16;
	}

	// Token: 0x06005189 RID: 20873 RVA: 0x002031C4 File Offset: 0x002013C4
	internal static void 4(int 1, bool 2, bool 3)
	{
		if (1226.19 == 1 && 1226.16 == 1 && !3)
		{
			return;
		}
		if (1662.78 == 1677.Edit)
		{
			1226.110();
		}
		1226.69();
		2648.39 = true;
		if (1 < -1226.20 && !2 && !1226.4)
		{
			1 = -1226.20;
		}
		else if (1 > 1226.9() - 1226.20 && !2)
		{
			1 = 1226.9() - 1226.20;
		}
		if (1226.4)
		{
			if ((double)1 > 1226.10)
			{
				1226.22 += (double)1 - 1226.10;
			}
			1226.10 = (double)(1 + 1226.20);
			1226.16 = (int)Math.Round(1226.10) - 1226.20;
			1226.3();
		}
		if (!1226.4 || 3)
		{
			if (1226.32 != (1042)0)
			{
				if (Math.Abs(1 - 1226.16) > 200 || 3)
				{
					1226.31.Seek((double)(1 + 1226.20));
				}
				1226.32 = (1042)2;
				1226.3();
				1226.18 = 1226.16;
			}
			else
			{
				1226.11 = 1;
				1226.58 = true;
				1226.3();
			}
		}
		1226.70(false);
	}

	// Token: 0x0600518A RID: 20874 RVA: 0x002032ED File Offset: 0x002014ED
	internal static void 5()
	{
		1226.16 = -1226.20;
		1226.17 = 0;
		1226.11 = 0;
		1226.58 = true;
		1240 <<EMPTY_NAME>> = 1226.31;
		if (<<EMPTY_NAME>> != null)
		{
			<<EMPTY_NAME>>.4();
		}
		1226.32 = (1042)0;
	}

	// Token: 0x0600518B RID: 20875 RVA: 0x00203322 File Offset: 0x00201522
	internal static void 6()
	{
		1226.7(1226.19, false);
	}

	// Token: 0x0600518C RID: 20876 RVA: 0x0020332F File Offset: 0x0020152F
	internal static void 7(int 1, bool 2)
	{
		1226.4 = true;
		1226.16 = 1;
		1226.19 = 1;
		1226.17 = 1;
		1226.10 = (double)1;
		1226.58 = false;
		1226.22 = (double)1226.20;
		if (!2)
		{
			1226.32 = (1042)1;
		}
	}

	// Token: 0x0600518D RID: 20877 RVA: 0x0020336A File Offset: 0x0020156A
	internal static void 8()
	{
		1226.4 = false;
	}

	// Token: 0x0600518E RID: 20878 RVA: 0x00203372 File Offset: 0x00201572
	internal static int 9()
	{
		1240 <<EMPTY_NAME>> = 1226.31;
		return (int)((<<EMPTY_NAME>> != null) ? <<EMPTY_NAME>>.4 : 0.0);
	}

	// Token: 0x0600518F RID: 20879 RVA: 0x0020338E File Offset: 0x0020158E
	internal static bool 10()
	{
		return 1226.32 == (1042)0;
	}

	// Token: 0x06005190 RID: 20880 RVA: 0x00203398 File Offset: 0x00201598
	internal static 1262 11()
	{
		1240 <<EMPTY_NAME>> = 1226.31;
		if (<<EMPTY_NAME>> == null)
		{
			return null;
		}
		return <<EMPTY_NAME>>.1;
	}

	// Token: 0x06005191 RID: 20881 RVA: 0x002033AA File Offset: 0x002015AA
	internal static void SetCurrentBeatmap(1262 1)
	{
		1226.31.1 = 1;
	}

	// Token: 0x06005192 RID: 20882 RVA: 0x002033B8 File Offset: 0x002015B8
	internal static void 12()
	{
		if (!1226.52)
		{
			2662 <<EMPTY_NAME>> = 1662.90;
			1189 2;
			if ((2 = 1226.<>O.<0>__CheckDeviceChanges) == null)
			{
				2 = (1226.<>O.<0>__CheckDeviceChanges = new 1189(1226.17));
			}
			<<EMPTY_NAME>>.2(2, 1000, true);
			1189 3;
			if ((3 = 1226.<>O.<0>__CheckDeviceChanges) == null)
			{
				3 = (1226.<>O.<0>__CheckDeviceChanges = new 1189(1226.17));
			}
			1662.72(3);
			1226.52 = true;
		}
		1226.39.ClearChangedHandlers();
		1319 4 = 1226.39;
		EventHandler eventHandler;
		if ((eventHandler = 1226.<>O.<1>__OnVolumeChanged) == null)
		{
			eventHandler = (1226.<>O.<1>__OnVolumeChanged = new EventHandler(1226.37));
		}
		4.SubscribeChanged(eventHandler);
		1319 5 = 1226.39;
		EventHandler eventHandler2;
		if ((eventHandler2 = 1226.<>O.<2>__OnMusicVolumeChanged) == null)
		{
			eventHandler2 = (1226.<>O.<2>__OnMusicVolumeChanged = new EventHandler(1226.36));
		}
		5.SubscribeChanged(eventHandler2);
		1226.36.ClearChangedHandlers();
		1319 6 = 1226.36;
		EventHandler eventHandler3;
		if ((eventHandler3 = 1226.<>O.<1>__OnVolumeChanged) == null)
		{
			eventHandler3 = (1226.<>O.<1>__OnVolumeChanged = new EventHandler(1226.37));
		}
		6.SubscribeChanged(eventHandler3);
		1226.37.ClearChangedHandlers();
		1319 7 = 1226.37;
		EventHandler eventHandler4;
		if ((eventHandler4 = 1226.<>O.<1>__OnVolumeChanged) == null)
		{
			eventHandler4 = (1226.<>O.<1>__OnVolumeChanged = new EventHandler(1226.37));
		}
		7.SubscribeChanged(eventHandler4);
		1226.38.ClearChangedHandlers();
		1319 8 = 1226.38;
		EventHandler eventHandler5;
		if ((eventHandler5 = 1226.<>O.<2>__OnMusicVolumeChanged) == null)
		{
			eventHandler5 = (1226.<>O.<2>__OnMusicVolumeChanged = new EventHandler(1226.36));
		}
		8.SubscribeChanged(eventHandler5);
		1226.54();
		if (1226.3 == null)
		{
			1226.3 = new 915(60000, 1, 1);
		}
	}

	// Token: 0x06005193 RID: 20883 RVA: 0x0020351C File Offset: 0x0020171C
	internal static void 13()
	{
		if (1662.23 && (1662.76 == (932)1 || 1662.76 == (932)2) && 1226.56 < 100 && (1662.78 != 1677.Rank || 1226.56 < 50))
		{
			1226.46(1226.56 + 2, false);
		}
		1226.18 = 1226.16;
		1226.3();
		if (1662.78 == 1677.Play && 1226.31 != null)
		{
			1219.26(1226.31.GetPosition(), 1226.38() / 100.0, 1226.32 == (1042)1 && !1226.4);
		}
		if (1226.32 == (1042)2)
		{
			1226.70(false);
			1226.32 = (1042)1;
		}
		1226.22();
		if (1662.78 != 1677.BeatmapImport && (1662.78 != 1677.Play || 2486.109))
		{
			1226.43 = (float)((double)1226.43 * 0.9 + (double)(1226.16 - 1226.18) * 0.1);
			1226.65();
			if (1226.31 == null || (!1226.31.IsPlaying() && !1226.4))
			{
				1226.32 = (1042)0;
			}
			1226.104();
			1226.21 = (double)(1226.16 - 1226.18);
			1226.68();
			1250 <<EMPTY_NAME>> = 1226.42;
			if (<<EMPTY_NAME>> == null)
			{
				return;
			}
			<<EMPTY_NAME>>.Update();
		}
	}

	// Token: 0x06005194 RID: 20884 RVA: 0x00203666 File Offset: 0x00201866
	internal static bool 14()
	{
		if (1226.66)
		{
			return true;
		}
		1763.5("No compatible audio device detected. You must plug in a valid audio device in order to play osu!", 198.Red, 4000, null);
		return false;
	}

	// Token: 0x06005195 RID: 20885 RVA: 0x00203688 File Offset: 0x00201888
	internal static void 15(1189 1)
	{
		1189 2 = 1226.60;
		1189 3;
		do
		{
			3 = 2;
			1189 value = (1189)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1189>(ref 1226.60, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06005196 RID: 20886 RVA: 0x002036BC File Offset: 0x002018BC
	internal static bool 16(string 1, bool 2)
	{
		1226.1228 deviceMatcher = new 1226.1228();
		1226.61 = new List<1000>(1025.13());
		1189 3 = 1226.60;
		if (3 != null)
		{
			3();
		}
		deviceMatcher.1 = 9;
		int num = -1;
		if (!string.IsNullOrEmpty(deviceMatcher.1))
		{
			num = 1226.61.FindIndex((1000 1) => 1.4 == deviceMatcher.1);
		}
		1000 4 = 1025.11(1025.BASS_GetDevice());
		bool flag = 4 != null && 4.2() && 4.3();
		if (num == 1226.63 && !2 && flag)
		{
			return true;
		}
		if (flag && num > -1)
		{
			1000 5 = 1025.11(num);
			if (5 == null || !5.2())
			{
				return true;
			}
		}
		1241 6 = 1226.31 as 1241;
		bool flag2 = 6 != null && 6.11 > (1042)0;
		if (1226.66)
		{
			if (6 != null)
			{
				6.Dispose();
			}
			1226.55();
			1219.23();
			1025.BASS_Free();
		}
		1338.5("Setting bass variables...", 1341.Runtime, (1114)1);
		1025.BASS_SetConfig((998)0, 100);
		1025.BASS_SetConfig((998)1, 5);
		1025.BASS_SetConfig((998)27, 10);
		1025.BASS_SetConfig((998)30, 0);
		1025.BASS_SetConfig((998)68, 1);
		1025.BASS_SetConfig((998)40, 1);
		1025.BASS_SetConfig((998)48, 0);
		1219.18();
		1338.5(string.Format("Attempting to initialise bass ({0})...", num), 1341.Runtime, (1114)1);
		1226.66 = 1025.BASS_Init(num, 44100, 1304.180 ? ((1021)262144) : ((1021)4096), 1662.11.4().GetWindowHandle(), null);
		if (1226.66)
		{
			1000 7 = 1025.11(1025.BASS_GetDevice());
			1226.62 = (deviceMatcher.1 = ((7 != null) ? 7.4 : null));
			1226.63 = num;
			try
			{
				1020 8 = 1025.14();
				1226.65 = ((8.12 & (1021)262144) == (1021)0);
				1338.5(string.Format("BASS Initialised (wasapi: {0} latency: {1} minbuff: {2})", 1226.65, 8.11, 8.9), 1341.Runtime, (1114)1);
			}
			catch
			{
				1226.65 = false;
			}
			1219.Start((7 != null) ? 7.2 : null, num < 0);
			if (1219.StartError != null)
			{
				1763.5("Low latency audio could not start: " + 1219.StartError, 198.Orange, 5000, null);
			}
			if (1226.52)
			{
				1226.12();
				1226.53();
				if (6 != null && 6.1 != null)
				{
					1226.31 = 1240.Create(6.1, 6.IsDirectStream(), 6.15, 6);
					1226.31.SetVolume(6.GetVolume());
					1226.31.SetPlaybackRate(6.GetPlaybackRate());
					1226.31.Seek((double)1226.19);
					if (flag2)
					{
						1226.31.Play(false);
					}
				}
			}
			return true;
		}
		1338.5(string.Format("BASS Initialisation failed: {0}", 1025.BASS_ErrorGetCode()), 1341.Runtime, (1114)1);
		if (9 != null)
		{
			return 1226.16(null, false);
		}
		if (!1304.180)
		{
			1304.180 = true;
			return 1226.16(null, false);
		}
		1226.62 = null;
		1226.63 = -1;
		return false;
	}

	// Token: 0x06005197 RID: 20887 RVA: 0x00203A1C File Offset: 0x00201C1C
	private static void 17()
	{
		if (1662.78 == 1677.Play && !2486.13)
		{
			return;
		}
		bool flag = string.IsNullOrEmpty(1304.179.GetValue());
		if (flag)
		{
			1000 <<EMPTY_NAME>> = 1025.11(1025.BASS_GetDevice());
			if (<<EMPTY_NAME>> != null && <<EMPTY_NAME>>.1() && <<EMPTY_NAME>>.2())
			{
				return;
			}
		}
		int num = 0;
		foreach (1000 2 in 1025.13())
		{
			if (2 != null && 2.2 != null)
			{
				bool flag2 = 2.4 == 1226.62;
				if (2.2())
				{
					if (flag2 && !2.1() && flag)
					{
						1662.89.Schedule(new 1189(1226.1227.Instance.11), false);
					}
					num++;
				}
				else if (flag2)
				{
					1662.89.Schedule(new 1189(1226.1227.Instance.12), false);
				}
			}
		}
		if (1226.64 != num && 1226.64 > 0)
		{
			1662.89.Schedule(delegate()
			{
				1226.16(1304.179, false);
			}, false);
			if (num > 1226.64)
			{
				1763.5(1568.1(2679.AudioEngine_NewDeviceDetected), 198.YellowGreen, 5000, null);
			}
		}
		1226.64 = num;
	}

	// Token: 0x06005198 RID: 20888 RVA: 0x00203B74 File Offset: 0x00201D74
	private static void 18(Action 1)
	{
		1226.3.Method36622(1, (639)2);
	}

	// Token: 0x06005199 RID: 20889 RVA: 0x00203B83 File Offset: 0x00201D83
	internal static bool 19()
	{
		return 1 == 1219.7(1226.13) || 1 == 1219.7(1226.12);
	}

	// Token: 0x0600519A RID: 20890 RVA: 0x00203BA4 File Offset: 0x00201DA4
	internal static void 20(int? 1, string 2, float 3, bool 4)
	{
		if (1662.11.2())
		{
			if (1 == null)
			{
				1 = new int?(100);
			}
			if (1662.33 - 1226.49 > 50 || 4)
			{
				1226.49 = 1662.33;
				1226.28(2, 3, (1416)3);
			}
		}
	}

	// Token: 0x0600519B RID: 20891 RVA: 0x00203BF8 File Offset: 0x00201DF8
	internal static void 21(1254 1, 1254 2, bool 3)
	{
		if (1 == 1254.None)
		{
			1 = 1226.25;
		}
		if (2 == 1254.None)
		{
			2 = 1;
		}
		bool flag = 1226.24 != 1226.26 || 1 != 1226.27;
		bool flag2 = 1226.24 != 1226.26 || 2 != 1226.28;
		if (!3 && ((!flag && !flag2) || (1662.78 != 1677.Play && 1662.78 != 1677.Edit)))
		{
			return;
		}
		1226.26 = 1226.24;
		if (flag)
		{
			if (1226.12 != 0 && 1 == 1219.7(1226.12))
			{
				1219.6(1226.12);
			}
			1226.27 = 1;
			1226.12 = 1219.4(1226.60(1245.Normal, 1226.27, 1226.24, (1243)2), false);
		}
		if (flag2)
		{
			if (1226.13 != 0 && 1 == 1219.7(1226.13))
			{
				1219.6(1226.13);
			}
			1226.28 = 2;
			1226.13 = 1219.4(1226.60(1245.Whistle, 1226.28, 1226.24, (1243)2), false);
		}
		float num = 1226.43() / 100f;
		1025.BASS_ChannelSetAttribute(1226.12, (994)11, 1f);
		1025.BASS_ChannelSetAttribute(1226.12, (994)2, num);
		1025.BASS_ChannelSetAttribute(1226.13, (994)2, num);
		1025.BASS_ChannelSetAttribute(1226.13, (994)11, 1f);
	}

	// Token: 0x0600519C RID: 20892 RVA: 0x00203D44 File Offset: 0x00201F44
	private static void 22()
	{
		List<1256> obj = 1226.9;
		lock (obj)
		{
			foreach (1256 <<EMPTY_NAME>> in 1226.9)
			{
				if (<<EMPTY_NAME>>.15())
				{
					<<EMPTY_NAME>>.Dispose();
				}
			}
			1226.9.RemoveAll(new Predicate<1256>(1226.1227.Instance.2));
		}
	}

	// Token: 0x0600519D RID: 20893 RVA: 0x00203DE0 File Offset: 0x00201FE0
	internal static void 23(float 1)
	{
		if (1025.3(1226.14) > 8192L)
		{
			1025.BASS_ChannelSetAttribute(1226.14, (994)1, (float)Math.Min(100000, 20000 + (int)(40000f * 1)));
		}
	}

	// Token: 0x0600519E RID: 20894 RVA: 0x00203E1C File Offset: 0x0020201C
	internal static 1256 24(string 1, int 2, 1416 3, bool 4 = false)
	{
		1226.1233 5 = new 1226.1233();
		1256 6 = new 1256(1226.48(1, false, true, 3));
		6.10 = 4;
		6.2((float)2 / 100f);
		5.1 = 6;
		List<1256> obj = 1226.9;
		lock (obj)
		{
			1226.9.Add(5.1);
		}
		1226.18(new Action(5.Play));
		return 5.1;
	}

	// Token: 0x0600519F RID: 20895 RVA: 0x00203EB0 File Offset: 0x002020B0
	internal static void 25(1256 1)
	{
		1226.18(new Action(new 1226.1230
		{
			1 = 1
		}.1));
	}

	// Token: 0x060051A0 RID: 20896 RVA: 0x00203ED0 File Offset: 0x002020D0
	internal static 1256 26(string[] 1)
	{
		1226.1231 2 = new 1226.1231();
		int num = -1;
		if (num == -1)
		{
			num = 1226.47(1, false, true, (1416)2);
		}
		if (num == -1)
		{
			num = 1226.47(1, false, true, (1416)3);
		}
		2.1 = new 1256(num);
		List<1256> obj = 1226.9;
		lock (obj)
		{
			1226.9.Add(2.1);
		}
		1226.18(new Action(2.Play));
		return 2.1;
	}

	// Token: 0x060051A1 RID: 20897 RVA: 0x00203F60 File Offset: 0x00202160
	internal static 1256 27(string[] 1)
	{
		1226.1232 2 = new 1226.1232();
		int num = -1;
		if (num == -1)
		{
			num = 1226.47(1, false, true, (1416)2);
		}
		if (num == -1)
		{
			num = 1226.47(1, false, true, (1416)3);
		}
		1256 3 = new 1256(num);
		3.4(0.4f);
		2.1 = 3;
		List<1256> obj = 1226.9;
		lock (obj)
		{
			1226.9.Add(2.1);
		}
		1226.18(new Action(2.Play));
		return 2.1;
	}

	// Token: 0x060051A2 RID: 20898 RVA: 0x00204000 File Offset: 0x00202200
	internal static 1256 28(string 1, float 2, 1416 3)
	{
		1226.1238 4 = new 1226.1238();
		1256 5 = new 1256(1226.48(1, false, true, 3));
		5.4(0.4f);
		5.5(2);
		4.1 = 5;
		List<1256> obj = 1226.9;
		lock (obj)
		{
			1226.9.Add(4.1);
		}
		1226.18(new Action(4.Play));
		return 4.1;
	}

	// Token: 0x060051A3 RID: 20899 RVA: 0x00204090 File Offset: 0x00202290
	internal static 1256 29(int 1, int 2, float 3, bool 4, float 5, bool 6 = false)
	{
		1226.1229 7 = new 1226.1229();
		if (1 == -1)
		{
			return null;
		}
		if (4 && 1226.31.GetPlaybackRate() != 100.0 && 1226.31.ShouldScaleEffectsWithRate())
		{
			5 = 1f + ((float)1226.31.GetPlaybackRate() - 100f) / 100f;
		}
		1256 8 = new 1256(1);
		8.10 = 6;
		8.10(1);
		8.2((float)2 / 100f);
		8.3(3);
		8.5(5);
		7.1 = 8;
		List<1256> obj = 1226.9;
		lock (obj)
		{
			1226.9.Add(7.1);
		}
		1226.18(new Action(7.Play));
		return 7.1;
	}

	// Token: 0x060051A4 RID: 20900 RVA: 0x0020417C File Offset: 0x0020237C
	internal static void 30(1244 1, float 2, bool 3)
	{
		if (2486.190)
		{
			return;
		}
		int num = 1226.44(3 ? Math.Max(8, 1.5) : 1.5);
		1254 4 = (1.3 == 1254.None) ? 1.2 : 1.3;
		if (1.1.2(1245.Normal))
		{
			1226.29(1226.60(1245.Normal, 1.2, 1.4, (1243)0), (int)((double)num * 0.8), 2, true, 1f, true);
		}
		if (1.1.2(1245.Finish))
		{
			1226.29(1226.60(1245.Finish, 4, 1.4, (1243)0), num, 2, true, 1f, true);
		}
		if (1.1.2(1245.Whistle))
		{
			1226.29(1226.60(1245.Whistle, 4, 1.4, (1243)0), (int)((double)num * 0.85), 2, true, 1f, true);
		}
		if (1.1.2(1245.Clap))
		{
			1226.29(1226.60(1245.Clap, 4, 1.4, (1243)0), (int)((double)num * 0.85), 2, true, 1f, true);
		}
	}

	// Token: 0x060051A5 RID: 20901 RVA: 0x0020429C File Offset: 0x0020249C
	internal static void 31(1245 1, 1254 2, 1254 3, bool 4, float? 5)
	{
		1226.1235 6 = new 1226.1235();
		6.1 = 5;
		1226.21(2, 3, false);
		if ((4 || !1.2(1245.Whistle)) && 1 != 1219.7(1226.12))
		{
			1226.18(delegate
			{
				1025.BASS_ChannelSetAttribute(1226.12, (994)2, 1226.43() / 100f);
				1219.Play(1226.12, true);
			});
		}
		if (1.2(1245.Whistle) && 1 != 1219.7(1226.13))
		{
			1226.18(delegate
			{
				1025.BASS_ChannelSetAttribute(1226.13, (994)2, 1226.43() / 100f);
				1219.Play(1226.13, true);
			});
		}
		if (6.1 != null)
		{
			1226.18(new Action(6.Apply));
		}
	}

	// Token: 0x060051A6 RID: 20902 RVA: 0x00204354 File Offset: 0x00202554
	internal static void 32(float? 1)
	{
		if (1 != null)
		{
			1226.23(1.Value);
		}
		1226.18(delegate
		{
			1025.BASS_ChannelSetAttribute(1226.14, (994)2, 1226.43() / 100f);
			1219.Play(1226.14, false);
		});
	}

	// Token: 0x060051A7 RID: 20903 RVA: 0x0020438F File Offset: 0x0020258F
	internal static void 33(1244 1, float 2)
	{
		if (2486.190)
		{
			return;
		}
		1226.29(1226.60(1.1, 1.2, 1.4, (1243)1), 1226.44(1.5), 2, true, 1f, true);
	}

	// Token: 0x060051A8 RID: 20904 RVA: 0x002043CA File Offset: 0x002025CA
	internal static void 34()
	{
		1226.18(new Action(1226.1227.Instance.5));
	}

	// Token: 0x060051A9 RID: 20905 RVA: 0x002043E1 File Offset: 0x002025E1
	internal static void 35()
	{
		1226.18(new Action(1226.1227.Instance.6));
	}

	// Token: 0x060051AA RID: 20906 RVA: 0x002043F8 File Offset: 0x002025F8
	private static void 36(object 1, EventArgs 2)
	{
		1226.46(1226.56, false);
	}

	// Token: 0x060051AB RID: 20907 RVA: 0x00204408 File Offset: 0x00202608
	private static void 37(object 1, EventArgs 2)
	{
		float num = 1226.43() / 100f;
		1025.BASS_ChannelSetAttribute(1226.12, (994)2, num);
		1025.BASS_ChannelSetAttribute(1226.13, (994)2, num);
		1025.BASS_ChannelSetAttribute(1226.14, (994)2, num);
		List<1256> obj = 1226.9;
		lock (obj)
		{
			1226.9.ForEach(new Action<1256>(1226.1227.Instance.1));
		}
	}

	// Token: 0x060051AC RID: 20908 RVA: 0x00204490 File Offset: 0x00202690
	internal static double 38()
	{
		1240 <<EMPTY_NAME>> = 1226.31;
		if (<<EMPTY_NAME>> == null)
		{
			return 100.0;
		}
		return <<EMPTY_NAME>>.GetPlaybackRate();
	}

	// Token: 0x060051AD RID: 20909 RVA: 0x002044AC File Offset: 0x002026AC
	internal static void 39(double 1)
	{
		1240 2 = 1226.31;
		if (2 != null)
		{
			1226.54 = 0;
			2.SetPreservePitch(!1226.40 && !1226.41);
			2.SetPlaybackRate(1);
		}
	}

	// Token: 0x060051AE RID: 20910 RVA: 0x002044E7 File Offset: 0x002026E7
	internal static float 40()
	{
		return (float)(1226.38.6() * 1226.39.6()) / 100f;
	}

	// Token: 0x060051AF RID: 20911 RVA: 0x00204505 File Offset: 0x00202705
	internal static float 41()
	{
		return (float)(1226.36.6() * 1226.39.6()) / 100f;
	}

	// Token: 0x060051B0 RID: 20912 RVA: 0x00204523 File Offset: 0x00202723
	internal static float 42()
	{
		return (float)(1226.37.6() * 1226.39.6()) / 100f;
	}

	// Token: 0x060051B1 RID: 20913 RVA: 0x00204541 File Offset: 0x00202741
	internal static float 43()
	{
		return Math.Min(100f, (float)1226.44(1226.45()) * 1226.42() / 100f);
	}

	// Token: 0x060051B2 RID: 20914 RVA: 0x00204564 File Offset: 0x00202764
	internal static int 44(int 1)
	{
		if (1662.78 != 1677.Edit)
		{
			return 1 * 1242.Current / 100;
		}
		return 1;
	}

	// Token: 0x060051B3 RID: 20915 RVA: 0x0020457C File Offset: 0x0020277C
	internal static int 45()
	{
		if (1226.11() == null)
		{
			return 100;
		}
		1259 <<EMPTY_NAME>> = 1226.72();
		if (<<EMPTY_NAME>> != null)
		{
			return Math.Max(8, <<EMPTY_NAME>>.6);
		}
		return 1226.11().79;
	}

	// Token: 0x060051B4 RID: 20916 RVA: 0x002045B4 File Offset: 0x002027B4
	internal static void 46(int 1, bool 2)
	{
		1226.56 = Math.Max(Math.Min(100, 1), (!2) ? 10 : 0);
		1226.57 = 1226.40() / 100f * (float)1226.56 / 100f;
		1226.59.ForEach(new Action<1240>(1226.1227.Instance.3));
	}

	// Token: 0x060051B5 RID: 20917 RVA: 0x00204614 File Offset: 0x00202814
	internal static int 47(string[] 1, bool 2, bool 3, 1416 4)
	{
		int result = -1;
		int num = 0;
		while (num < 1.Length && (result = 1226.48(1[num], 2, 3, 4)) == -1)
		{
			num++;
		}
		return result;
	}

	// Token: 0x060051B6 RID: 20918 RVA: 0x00204644 File Offset: 0x00202844
	internal static int 48(string 1, bool 2, bool 3, 1416 4)
	{
		if (1662.47 && !1662.48 && 1662.50 != 0)
		{
			return -1;
		}
		if (1.ToLower().Contains("notify1") && 1662.78 != 1677.Edit && 1662.78 != 1677.Unknown && 1662.78 != 1677.PackageUpdater)
		{
			1226.50 = true;
		}
		1012 5 = (1012)131072;
		if (2)
		{
			5 |= (1012)4;
		}
		string text = 1;
		if (!3)
		{
			string text2 = 1226.25.ToString().ToLower() + "-";
			if (1662.78 == 1677.Play && 2486.14() == 2147.Taiko)
			{
				text2 = "taiko-" + text2;
				if (1272.5() != null && 1272.5().3() != 2147.Taiko)
				{
					4 &= (1416)(-5);
				}
			}
			text = text2 + text;
		}
		int num = -1;
		if ((4 & (1416)4) > (1416)0 && !1226.2 && (3 || (!3 && 1226.24 != 1253.Default)) && 1272.5() != null)
		{
			int num2 = (int)1226.24;
			string text3 = text + ((!3 && num2 > 1) ? num2.ToString() : string.Empty);
			if (!1226.6.TryGetValue(text3, out num))
			{
				num = -1;
				for (int i = 0; i < 3; i++)
				{
					string text4;
					if (i != 0)
					{
						if (i != 1)
						{
							text4 = ".ogg";
						}
						else
						{
							text4 = ".mp3";
						}
					}
					else
					{
						text4 = ".wav";
					}
					string str = text4;
					byte[] array = 1272.5().49(text3 + str) ?? ((1272.5().32 < 5) ? 1272.5().49(1 + str) : null);
					if (array != null)
					{
						num = ((array.Length >= 1024) ? 1025.27(array, 0L, array.Length, 8, 5) : 1025.BASS_SampleCreate(0, 44100, 2, 8, 5));
						break;
					}
				}
				1226.6[text3] = num;
			}
		}
		if (num != -1)
		{
			return num;
		}
		if ((4 & (1416)2) > (1416)0 && !2630.20() && 1304.120 && !1226.8.TryGetValue(text, out num))
		{
			num = -1;
			for (int j = 0; j < 3; j++)
			{
				string text4;
				if (j != 0)
				{
					if (j != 1)
					{
						text4 = "ogg";
					}
					else
					{
						text4 = "mp3";
					}
				}
				else
				{
					text4 = "wav";
				}
				string str2 = text4;
				string path = Path.Combine(2630.5.14(), text + "." + str2);
				if (File.Exists(path))
				{
					num = 1025.29(path, 0L, 0, 8, 5);
					break;
				}
			}
			1226.8[text] = num;
		}
		if (num != -1)
		{
			return num;
		}
		if ((4 & (1416)1) == (1416)0)
		{
			return -1;
		}
		if (text.StartsWith("taiko-drum"))
		{
			if (!(text == "taiko-drum-hitnormal"))
			{
				if (!(text == "taiko-drum-hitclap"))
				{
					if (!(text == "taiko-drum-hitfinish"))
					{
						if (text == "taiko-drum-hitwhistle")
						{
							text = "drum-hitwhistle";
						}
					}
					else
					{
						text = "drum-hitnormal";
					}
				}
				else
				{
					text = "drum-hitclap";
				}
			}
			else
			{
				text = "drum-hitfinish";
			}
		}
		if (1226.7.TryGetValue(text, out num))
		{
			return num;
		}
		byte[] array2 = null;
		if (array2 == null)
		{
			array2 = (osu_ui.ResourcesStore.ResourceManager.GetObject(text) as byte[]);
		}
		if (array2 == null)
		{
			array2 = (osu_gameplay.ResourcesStore.ResourceManager.GetObject(text) as byte[]);
		}
		if (array2 == null)
		{
			return 1226.7[text] = -1;
		}
		int num3 = 1025.27(array2, 0L, array2.Length, 5, 5);
		return 1226.7[text] = ((num3 != 0) ? num3 : -1);
	}

	// Token: 0x060051B7 RID: 20919 RVA: 0x002049C8 File Offset: 0x00202BC8
	internal static int 49(string 1, bool 2, bool 3, bool 4)
	{
		1012 5 = (1012)131072;
		if (2)
		{
			5 |= (1012)4;
		}
		int num = -1;
		string text = 1;
		string str = string.Empty;
		bool flag = false;
		if (1.IndexOf('.') > 0)
		{
			text = 1.Substring(0, 1.LastIndexOf('.'));
		}
		else
		{
			flag = true;
		}
		if (3 && text.Contains("slider"))
		{
			5 &= (1012)(-5);
			str = "$slider$";
		}
		if (1226.6.TryGetValue(str + text, out num) && !4)
		{
			return num;
		}
		byte[] array = null;
		if (flag || !1272.5().52(1))
		{
			string str2 = ".wav";
			for (int i = 0; i < 3; i++)
			{
				if (i != 1)
				{
					if (i == 2)
					{
						str2 = ".mp3";
					}
				}
				else
				{
					str2 = ".ogg";
				}
				array = (1272.5().49(text + str2) ?? ((1272.5().32 < 5) ? 1272.5().49(1 + str2) : null));
				if (array != null)
				{
					break;
				}
			}
		}
		else
		{
			array = (1272.5().49(1) ?? ((1272.5().32 < 5) ? 1272.5().49(1) : null));
		}
		if (array != null)
		{
			num = ((array.Length >= 1024) ? 1025.27(array, 0L, array.Length, 8, 5) : 1025.BASS_SampleCreate(0, 44100, 2, 8, 5));
		}
		string key = str + text;
		int num2 = -1;
		if (1226.6.TryGetValue(key, out num2) && num2 != -1)
		{
			1219.5(num2);
		}
		1226.6[key] = num;
		return num;
	}

	// Token: 0x060051B8 RID: 20920 RVA: 0x00204B5C File Offset: 0x00202D5C
	internal static void 50(string 1)
	{
		int num = -1;
		if (1226.6.TryGetValue(1, out num))
		{
			if (num != -1)
			{
				1219.5(num);
			}
			1226.6.Remove(1);
		}
	}

	// Token: 0x060051B9 RID: 20921 RVA: 0x00204B90 File Offset: 0x00202D90
	internal static List<string> 51()
	{
		List<string> list = new List<string>(1226.6.Count);
		foreach (string path in Directory.GetFiles(1272.5().44()))
		{
			string fileName = Path.GetFileName(path);
			if (2672.24(path) - (2670)7 <= 1)
			{
				list.Add(fileName);
			}
		}
		return list;
	}

	// Token: 0x060051BA RID: 20922 RVA: 0x00204BE8 File Offset: 0x00202DE8
	internal static void 52(1253 1)
	{
		1226.24 = 1;
		1254[] array = 1226.51;
		for (int i = 0; i < array.Length; i++)
		{
			1226.25 = array[i];
			1226.48("hitnormal", false, false, (1416)7);
			1226.48("hitfinish", false, false, (1416)7);
			1226.48("hitwhistle", false, false, (1416)7);
			1226.48("hitclap", false, false, (1416)7);
			1226.48("sliderslide", true, false, (1416)7);
			1226.48("sliderwhistle", true, false, (1416)7);
			1226.48("slidertick", false, false, (1416)7);
		}
	}

	// Token: 0x060051BB RID: 20923 RVA: 0x00204C7C File Offset: 0x00202E7C
	internal static void 53()
	{
		1254 <<EMPTY_NAME>> = 1226.25;
		1253[] array = new 1253[]
		{
			1253.Default,
			1253.Custom1,
			1253.Custom2
		};
		for (int i = 0; i < array.Length; i++)
		{
			1253 2 = 1226.24 = array[i];
			int num = 0;
			1254[] array2 = 1226.51;
			for (int j = 0; j < array2.Length; j++)
			{
				1226.25 = array2[j];
				1226.46[0, num, (int)2] = 1226.48("hitnormal", false, false, (1416)7);
				1226.46[2, num, (int)2] = 1226.48("hitfinish", false, false, (1416)7);
				1226.46[1, num, (int)2] = 1226.48("hitwhistle", false, false, (1416)7);
				1226.46[3, num, (int)2] = 1226.48("hitclap", false, false, (1416)7);
				1226.47[0, num, (int)2] = 1226.48("slidertick", false, false, (1416)7);
				1226.48[0, num, (int)2] = 1226.48("sliderslide", true, false, (1416)7);
				1226.48[1, num, (int)2] = 1226.48("sliderwhistle", true, false, (1416)7);
				num++;
			}
		}
		1226.25 = 1254.Soft;
		1226.24 = 1253.Custom1;
		1226.48("failsound", false, true, (1416)7);
		1226.48("spinnerspin", true, true, (1416)7);
		1226.48("spinnerbonus", false, true, (1416)7);
		1226.48("spinner-osu", false, true, (1416)7);
		1226.48("sectionpass", false, true, (1416)7);
		1226.48("sectionfail", false, true, (1416)7);
		1226.48("readys", false, true, (1416)7);
		1226.48("count3s", false, true, (1416)7);
		1226.48("count2s", false, true, (1416)7);
		1226.48("count1s", false, true, (1416)7);
		1226.48("gos", false, true, (1416)7);
		1226.48("combobreak", false, true, (1416)7);
		int num2 = 0;
		while (1226.48("comboburst-" + num2.ToString(), false, true, (1416)7) != -1)
		{
			num2++;
		}
		if (num2 == 0)
		{
			1226.48("comboburst", false, true, (1416)7);
		}
		1226.48("applause", false, true, (1416)7);
		1226.24 = 1253.Default;
		1226.26 = 1226.24;
		1226.27 = 1254.None;
		1226.28 = 1254.None;
		1226.54();
		1226.25 = <<EMPTY_NAME>>;
	}

	// Token: 0x060051BC RID: 20924 RVA: 0x00204ED4 File Offset: 0x002030D4
	internal static void 54()
	{
		1226.48("menuback", false, true, (1416)3);
		1226.48("menuhit", false, true, (1416)3);
		1226.48("menuclick", false, true, (1416)3);
		1226.48("metronomehigh", false, true, (1416)3);
		1226.48("metronomelow", false, true, (1416)3);
	}

	// Token: 0x060051BD RID: 20925 RVA: 0x00204F27 File Offset: 0x00203127
	internal static void 55()
	{
		1226.56(1226.8);
		1226.56(1226.6);
		1226.56(1226.7);
	}

	// Token: 0x060051BE RID: 20926 RVA: 0x00204F48 File Offset: 0x00203148
	private static void 56(Dictionary<string, int> 1)
	{
		foreach (int num in 1.Values)
		{
			1219.5(num);
		}
		1.Clear();
	}

	// Token: 0x060051BF RID: 20927 RVA: 0x00204FA0 File Offset: 0x002031A0
	internal static void 57()
	{
		1226.56(1226.6);
	}

	// Token: 0x060051C0 RID: 20928 RVA: 0x00204FAC File Offset: 0x002031AC
	internal static void 58()
	{
		1226.56(1226.8);
	}

	// Token: 0x060051C1 RID: 20929 RVA: 0x00204FB8 File Offset: 0x002031B8
	internal static void 59(1254 1, bool 2)
	{
		if (2 || ((1 != 1226.25 || 1226.61() != 1226.24) && (1662.78 == 1677.Play || 1662.78 == 1677.Edit)))
		{
			if (1 == 1254.None)
			{
				1 = 1254.Normal;
			}
			1226.25 = 1;
			1226.24 = 1226.61();
			1226.48("hitnormal", false, false, (1416)7);
			1226.48("hitfinish", false, false, (1416)7);
			1226.48("hitwhistle", false, false, (1416)7);
			1226.48("hitclap", false, false, (1416)7);
			1226.48("slidertick", false, false, (1416)7);
			if (1226.14 != 0 && 1 == 1219.7(1226.14))
			{
				1219.6(1226.14);
			}
			1226.14 = 1219.4(1226.48("spinnerspin", true, true, (1416)7), false);
			float num = 1226.43() / 100f;
			1025.BASS_ChannelSetAttribute(1226.14, (994)11, 1f);
			1025.BASS_ChannelSetAttribute(1226.14, (994)2, num);
			if (2 || 1226.27 == 1254.None)
			{
				1226.21(1, 1, 2);
			}
		}
	}

	// Token: 0x060051C2 RID: 20930 RVA: 0x002050C4 File Offset: 0x002032C4
	private static int 60(1245 1, 1254 2, 1253 3, 1243 4)
	{
		int num = 0;
		if (4 != (1243)1)
		{
			switch (1)
			{
			case 1245.Normal:
				num = 0;
				break;
			case 1245.Whistle:
				num = 1;
				break;
			case 1245.Normal | 1245.Whistle:
				break;
			case 1245.Finish:
				num = 2;
				break;
			default:
				if (1 == 1245.Clap)
				{
					num = 3;
				}
				break;
			}
		}
		int num2;
		switch (2)
		{
		case 1254.None:
		case 1254.Soft:
			num2 = 1;
			break;
		default:
			num2 = 0;
			break;
		case 1254.Drum:
			num2 = 2;
			break;
		}
		int num3 = Math.Max((int)3, 0);
		if (num3 <= 2)
		{
			int result;
			switch (4)
			{
			case (1243)0:
				result = 1226.46[num, num2, num3];
				break;
			case (1243)1:
				result = 1226.47[num, num2, num3];
				break;
			case (1243)2:
				result = 1226.48[num, num2, num3];
				break;
			default:
				result = -1;
				break;
			}
			return result;
		}
		string key = string.Empty;
		string text = (1662.78 == 1677.Play && 2486.14() == 2147.Taiko) ? "taiko-" : string.Empty;
		switch (4)
		{
		case (1243)0:
			key = string.Format("{0}{1}-hit{2}{3}", new object[]
			{
				text,
				2.ToString().ToLower(),
				1.ToString().ToLower(),
				num3
			});
			break;
		case (1243)1:
			key = string.Format("{0}{1}-slidertick{2}", text, 2.ToString().ToLower(), num3);
			break;
		case (1243)2:
		{
			string text2 = (1 == 1245.Normal) ? "slide" : 1.ToString().ToLower();
			key = string.Format("{0}{1}-slider{2}{3}", new object[]
			{
				text,
				2.ToString().ToLower(),
				text2,
				num3
			});
			break;
		}
		}
		int num4 = -1;
		if (1226.6.TryGetValue(key, out num4) && num4 != -1)
		{
			return num4;
		}
		if (num <= 3)
		{
			switch (4)
			{
			case (1243)0:
				return 1226.46[num, num2, 0];
			case (1243)1:
				return 1226.47[num, num2, 0];
			case (1243)2:
				return 1226.48[num, num2, 0];
			}
		}
		return -1;
	}

	// Token: 0x060051C3 RID: 20931 RVA: 0x002052E0 File Offset: 0x002034E0
	internal static 1253 61()
	{
		1259 <<EMPTY_NAME>> = 1226.72();
		if (<<EMPTY_NAME>> != null && 1226.11() != null && 1226.11().32 > 3)
		{
			return <<EMPTY_NAME>>.2;
		}
		return 1226.35;
	}

	// Token: 0x060051C4 RID: 20932 RVA: 0x00205316 File Offset: 0x00203516
	internal static void 62(1253 1)
	{
		1226.35 = 1;
	}

	// Token: 0x060051C5 RID: 20933 RVA: 0x0020531E File Offset: 0x0020351E
	internal static bool 63()
	{
		1259 <<EMPTY_NAME>> = 1226.73();
		return <<EMPTY_NAME>> != null && <<EMPTY_NAME>>.3();
	}

	// Token: 0x060051C6 RID: 20934 RVA: 0x00205330 File Offset: 0x00203530
	internal static double 64()
	{
		return (double)1226.16 - 1226.79();
	}

	// Token: 0x060051C7 RID: 20935 RVA: 0x00205340 File Offset: 0x00203540
	internal static void 65()
	{
		1226.70(false);
		1259 <<EMPTY_NAME>> = 1226.72();
		if (<<EMPTY_NAME>> != null && 1272.5() != null && 1272.5().32 > 3)
		{
			1226.59(<<EMPTY_NAME>>.4, false);
		}
	}

	// Token: 0x060051C8 RID: 20936 RVA: 0x0020537C File Offset: 0x0020357C
	internal static void 66(1189 1)
	{
		1189 2 = 1226.72;
		1189 3;
		do
		{
			3 = 2;
			1189 value = (1189)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1189>(ref 1226.72, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x060051C9 RID: 20937 RVA: 0x002053B0 File Offset: 0x002035B0
	internal static void 67(1189 1)
	{
		1189 2 = 1226.72;
		1189 3;
		do
		{
			3 = 2;
			1189 value = (1189)Delegate.Remove(3, 1);
			2 = Interlocked.CompareExchange<1189>(ref 1226.72, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x060051CA RID: 20938 RVA: 0x002053E4 File Offset: 0x002035E4
	private static void 68()
	{
		double num = 1226.76();
		1226.68 = 1226.64() % num / num;
		int num2 = (int)(1226.64() / num) + (((double)1226.16 < 1226.79()) ? -1 : 0);
		if (num2 != 1226.67)
		{
			1226.69 = true;
			1189 <<EMPTY_NAME>> = 1226.72;
			if (<<EMPTY_NAME>> != null)
			{
				<<EMPTY_NAME>>();
			}
			1226.67 = num2;
			return;
		}
		1226.69 = false;
	}

	// Token: 0x060051CB RID: 20939 RVA: 0x0020544B File Offset: 0x0020364B
	internal static void 69()
	{
		1226.70 = -1;
		1226.71 = -1;
	}

	// Token: 0x060051CC RID: 20940 RVA: 0x0020545C File Offset: 0x0020365C
	internal static void 70(bool 1)
	{
		try
		{
			1226.1237 timeFilter = new 1226.1237();
			List<1259> list = 1226.81();
			timeFilter.1 = 1226.16 + 5;
			if (list != null && list.Count > 0)
			{
				if (3)
				{
					list.Sort();
				}
				if (3 || 1226.70 < 0 || 1226.32 != (1042)1)
				{
					int num = 1226.70;
					int num2 = 1226.71;
					1226.70 = Math.Max(0, list.FindLastIndex(new Predicate<1259>(timeFilter.1)));
					1226.71 = Math.Max(0, list.FindLastIndex((1259 1) => 1.3 < (double)timeFilter.1));
					if (num != 1226.70)
					{
						1226.91(1226.71());
					}
					if (num2 != 1226.71)
					{
						1226.94(1226.72());
						1226.67 = -999;
					}
				}
				else
				{
					int count = list.Count;
					for (int i = 1226.71 + 1; i < count; i++)
					{
						1259 2 = list[i];
						if (2.3 > (double)timeFilter.1)
						{
							break;
						}
						1226.71 = i;
						1226.94(2);
						if (2.1())
						{
							1226.70 = i;
							1226.91(2);
						}
					}
				}
			}
			else
			{
				1226.69();
				1226.67 = -999;
			}
		}
		catch
		{
			1226.69();
			1226.67 = -999;
		}
	}

	// Token: 0x060051CD RID: 20941 RVA: 0x002055E0 File Offset: 0x002037E0
	internal static 1259 71()
	{
		return 1226.74(1226.70);
	}

	// Token: 0x060051CE RID: 20942 RVA: 0x002055EC File Offset: 0x002037EC
	internal static 1259 72()
	{
		return 1226.74(1226.71);
	}

	// Token: 0x060051CF RID: 20943 RVA: 0x002055F8 File Offset: 0x002037F8
	internal static 1259 73()
	{
		return 1226.72() ?? 1226.74(0);
	}

	// Token: 0x060051D0 RID: 20944 RVA: 0x00205609 File Offset: 0x00203809
	private static 1259 74(int 1)
	{
		List<1259> list = 1226.81();
		if (list == null)
		{
			return null;
		}
		return list.GetAtIndexOrDefault(1);
	}

	// Token: 0x060051D1 RID: 20945 RVA: 0x0020561C File Offset: 0x0020381C
	internal static bool 75()
	{
		return 1226.76() > 0.0;
	}

	// Token: 0x060051D2 RID: 20946 RVA: 0x0020562E File Offset: 0x0020382E
	internal static double 76()
	{
		1259 <<EMPTY_NAME>> = 1226.71();
		if (<<EMPTY_NAME>> == null)
		{
			return 0.0;
		}
		return <<EMPTY_NAME>>.1;
	}

	// Token: 0x060051D3 RID: 20947 RVA: 0x00205648 File Offset: 0x00203848
	internal static void 77(double 1)
	{
		List<1259> list = 1226.81();
		if (list != null)
		{
			if (list.Count > 0)
			{
				int index = Math.Max(0, 1226.70);
				list[index].1 = 1;
				return;
			}
			list.Add(new 1259(0.0, 1));
		}
	}

	// Token: 0x060051D4 RID: 20948 RVA: 0x00205696 File Offset: 0x00203896
	internal static double 78()
	{
		if (1226.75())
		{
			return 1000.0 / 1226.76() * 60.0;
		}
		return 0.0;
	}

	// Token: 0x060051D5 RID: 20949 RVA: 0x002056C2 File Offset: 0x002038C2
	internal static double 79()
	{
		1259 <<EMPTY_NAME>> = 1226.71();
		if (<<EMPTY_NAME>> == null)
		{
			return 0.0;
		}
		return <<EMPTY_NAME>>.3;
	}

	// Token: 0x060051D6 RID: 20950 RVA: 0x002056DC File Offset: 0x002038DC
	internal static void 80(double 1)
	{
		List<1259> list = 1226.81();
		if (list != null)
		{
			if (list.Count > 0)
			{
				int index = Math.Max(0, 1226.70);
				list[index].3 = 1;
			}
			else
			{
				list.Add(new 1259(1, 0.0));
			}
			list.Sort();
		}
	}

	// Token: 0x060051D7 RID: 20951 RVA: 0x00205731 File Offset: 0x00203931
	internal static List<1259> 81()
	{
		1262 <<EMPTY_NAME>> = 1226.11();
		if (<<EMPTY_NAME>> == null)
		{
			return null;
		}
		return <<EMPTY_NAME>>.94;
	}

	// Token: 0x060051D8 RID: 20952 RVA: 0x00205743 File Offset: 0x00203943
	internal static void 82(List<1259> 1)
	{
		1226.11().94 = 1;
		1226.70 = 0;
		1226.71 = 0;
	}

	// Token: 0x060051D9 RID: 20953 RVA: 0x0020575C File Offset: 0x0020395C
	internal static List<1259> 83()
	{
		1262 <<EMPTY_NAME>> = 1226.11();
		if (<<EMPTY_NAME>> == null)
		{
			return null;
		}
		return <<EMPTY_NAME>>.84();
	}

	// Token: 0x060051DA RID: 20954 RVA: 0x0020576E File Offset: 0x0020396E
	internal static 1257 84()
	{
		1259 <<EMPTY_NAME>> = 1226.71();
		if (<<EMPTY_NAME>> == null)
		{
			return (1257)4;
		}
		return <<EMPTY_NAME>>.5;
	}

	// Token: 0x060051DB RID: 20955 RVA: 0x00205780 File Offset: 0x00203980
	internal static void 85(1257 1)
	{
		1259 2 = 1226.71();
		if (2 != null)
		{
			2.5 = 1;
		}
	}

	// Token: 0x060051DC RID: 20956 RVA: 0x0020579D File Offset: 0x0020399D
	internal static double 86(double 1)
	{
		1262 2 = 1226.11();
		if (2 == null)
		{
			return 0.0;
		}
		return 2.88(1);
	}

	// Token: 0x060051DD RID: 20957 RVA: 0x002057B8 File Offset: 0x002039B8
	internal static double 87(double 1)
	{
		1262 2 = 1226.11();
		if (2 == null)
		{
			return 0.0;
		}
		return 2.89(1);
	}

	// Token: 0x060051DE RID: 20958 RVA: 0x002057D3 File Offset: 0x002039D3
	internal static double 88(double 1, bool 2)
	{
		1262 3 = 1226.11();
		if (3 == null)
		{
			return 0.0;
		}
		return 3.90(1, 2);
	}

	// Token: 0x060051DF RID: 20959 RVA: 0x002057EF File Offset: 0x002039EF
	internal static 1259 89(double 1)
	{
		1262 2 = 1226.11();
		if (2 == null)
		{
			return null;
		}
		return 2.92(1);
	}

	// Token: 0x060051E0 RID: 20960 RVA: 0x00205802 File Offset: 0x00203A02
	internal static 1259 90(double 1, List<1259> 2)
	{
		return 1262.95(1, 2);
	}

	// Token: 0x060051E1 RID: 20961 RVA: 0x0020580B File Offset: 0x00203A0B
	private static void 91(1259 1)
	{
		1226.1236 2 = 1226.73;
		if (2 == null)
		{
			return;
		}
		2(1);
	}

	// Token: 0x060051E2 RID: 20962 RVA: 0x00205820 File Offset: 0x00203A20
	internal static void 92(1226.1236 1)
	{
		1226.1236 2 = 1226.74;
		1226.1236 3;
		do
		{
			3 = 2;
			1226.1236 value = (1226.1236)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1226.1236>(ref 1226.74, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x060051E3 RID: 20963 RVA: 0x00205854 File Offset: 0x00203A54
	internal static void 93(1226.1236 1)
	{
		1226.1236 2 = 1226.74;
		1226.1236 3;
		do
		{
			3 = 2;
			1226.1236 value = (1226.1236)Delegate.Remove(3, 1);
			2 = Interlocked.CompareExchange<1226.1236>(ref 1226.74, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x060051E4 RID: 20964 RVA: 0x00205887 File Offset: 0x00203A87
	private static void 94(1259 1)
	{
		1226.1236 2 = 1226.74;
		if (2 == null)
		{
			return;
		}
		2(1);
	}

	// Token: 0x060051E5 RID: 20965 RVA: 0x0020589C File Offset: 0x00203A9C
	internal static void 95(1189 1)
	{
		1189 2 = 1226.23;
		1189 3;
		do
		{
			3 = 2;
			1189 value = (1189)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1189>(ref 1226.23, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x060051E6 RID: 20966 RVA: 0x002058CF File Offset: 0x00203ACF
	internal static 1240 96(byte[] 1, bool 2)
	{
		if (1 == null)
		{
			return null;
		}
		1241 3 = new 1241(new MemoryStream(1), false, 2);
		3.SetVolume(1226.40() / 100f);
		return 3;
	}

	// Token: 0x060051E7 RID: 20967 RVA: 0x002058F4 File Offset: 0x00203AF4
	internal static int 97()
	{
		1262 <<EMPTY_NAME>> = 1226.11();
		if (<<EMPTY_NAME>> == null)
		{
			return 0;
		}
		return <<EMPTY_NAME>>.78;
	}

	// Token: 0x060051E8 RID: 20968 RVA: 0x00205906 File Offset: 0x00203B06
	internal static void 98()
	{
		1226.40 = false;
		1226.41 = false;
		1226.39(100.0);
		1226.30 = 1226.29;
		1226.69();
		1240 <<EMPTY_NAME>> = 1226.31;
		if (<<EMPTY_NAME>> == null)
		{
			return;
		}
		<<EMPTY_NAME>>.ApplyChannelSettings();
	}

	// Token: 0x060051E9 RID: 20969 RVA: 0x00205940 File Offset: 0x00203B40
	internal static bool 99(1262 1, bool 2, bool 3, bool 4, bool 5)
	{
		if (!1.59)
		{
			1.65();
		}
		if (1226.40)
		{
			if (1226.42 == null)
			{
				1226.42 = new 1250();
			}
			1226.42.Reset();
		}
		else
		{
			1250 6 = 1226.42;
			if (6 != null)
			{
				6.Dispose();
			}
			1226.42 = null;
		}
		if (1226.31 != null && !1226.31.2 && (!1226.31.IsDirectStream() || 3) && 1226.31.1 != null && 1.37 == 1226.31.1.37 && 1.18 == 1226.31.1.18)
		{
			1226.31.1 = 1;
			return false;
		}
		try
		{
			1240 7 = 1240.Create(1, 3, 5, 1226.31);
			if (4)
			{
				1226.103();
			}
			1226.31 = 7;
		}
		catch (NullReferenceException)
		{
			throw new 1043();
		}
		1189 8 = 1226.23;
		if (8 != null)
		{
			8();
		}
		if (2)
		{
			try
			{
				1041 9 = new 1041();
				if (1036.1(1226.31.6, 9))
				{
					1226.34 = 9.5;
					1226.33 = 9.19;
				}
				else
				{
					1226.34 = 1568.1(2679.AudioEngine_Unknown);
					1226.33 = 1568.1(2679.AudioEngine_Unknown);
				}
			}
			catch
			{
				1226.34 = 1568.1(2679.AudioEngine_Unknown);
				1226.33 = 1568.1(2679.AudioEngine_Unknown);
			}
		}
		1025.BASS_ChannelGetAttribute(1226.31.2(), (994)1, ref 1226.30);
		if (1226.30 <= 0f)
		{
			1226.30 = 44100f;
		}
		1226.29 = 1226.30;
		1226.98();
		return true;
	}

	// Token: 0x060051EA RID: 20970 RVA: 0x00205B0C File Offset: 0x00203D0C
	internal static 1041 100()
	{
		if (1226.31.2() != 0)
		{
			try
			{
				1041 result = new 1041();
				if (1036.1(1226.31.2(), result))
				{
					return result;
				}
			}
			catch
			{
				return null;
			}
		}
		return null;
	}

	// Token: 0x060051EB RID: 20971 RVA: 0x00205B5C File Offset: 0x00203D5C
	internal static void 101(1241 1)
	{
		1226.59.Add(1);
	}

	// Token: 0x060051EC RID: 20972 RVA: 0x00205B69 File Offset: 0x00203D69
	internal static void 102(1241 1)
	{
		1226.59.Remove(1);
	}

	// Token: 0x060051ED RID: 20973 RVA: 0x00205B78 File Offset: 0x00203D78
	internal static void 103()
	{
		1240 <<EMPTY_NAME>> = 1226.31;
		if (<<EMPTY_NAME>> != null)
		{
			1226.31 = null;
			1226.58 = false;
			<<EMPTY_NAME>>.Dispose();
		}
	}

	// Token: 0x060051EE RID: 20974 RVA: 0x00205BA0 File Offset: 0x00203DA0
	private static void 104()
	{
		if (1226.32 != (1042)1)
		{
			if (1226.75.Count > 0)
			{
				1226.75.Clear();
			}
			return;
		}
		int num = 1226.16;
		object obj = 1226.15.1;
		lock (obj)
		{
			1226.75.Clear();
			1226.75.AddRange(1226.15);
		}
		for (int i = 0; i < 1226.75.Count; i++)
		{
			1255 <<EMPTY_NAME>> = 1226.75[i];
			if (<<EMPTY_NAME>>.4 <= num && <<EMPTY_NAME>>.4 > num - 400)
			{
				if (!<<EMPTY_NAME>>.1)
				{
					<<EMPTY_NAME>>.5 = 1226.29(<<EMPTY_NAME>>.3, <<EMPTY_NAME>>.6, 0f, true, 1f, false);
					<<EMPTY_NAME>>.1 = true;
				}
			}
			else if (1662.78 == 1677.Edit)
			{
				<<EMPTY_NAME>>.1 = false;
			}
		}
	}

	// Token: 0x060051EF RID: 20975 RVA: 0x00205CA8 File Offset: 0x00203EA8
	private static void 105()
	{
		if (1226.58)
		{
			1226.31.Seek((double)(1226.11 + ((1226.11 != 0) ? 1226.20 : 0)));
			1226.58 = false;
			1226.4 = false;
			1226.3();
			1226.18 = 1226.16;
		}
	}

	// Token: 0x060051F0 RID: 20976 RVA: 0x00205CF8 File Offset: 0x00203EF8
	internal static bool 106(1262 1, bool 2, bool 3, bool 4)
	{
		1226.4 = false;
		1226.69();
		bool flag;
		try
		{
			flag = !1226.99(1, false, 4, true, false);
		}
		catch (UnauthorizedAccessException)
		{
			1763.4(1568.1(2679.AudioEngine_NoPermissions));
			return false;
		}
		if (flag && 2 && 1226.10 / (double)1226.9() < 0.9800000190734863 && (1226.38() == 100.0 || 1662.78 == 1677.SelectPlay))
		{
			1226.46(1226.56 / 3, false);
		}
		else
		{
			if (3)
			{
				1226.31.Seek((double)((1226.97() == -1) ? ((int)((double)1226.9() * 0.4)) : 1226.97()));
			}
			1226.46(0, true);
		}
		1226.31.Play(false);
		1226.32 = (1042)1;
		return flag;
	}

	// Token: 0x060051F1 RID: 20977 RVA: 0x00205DD4 File Offset: 0x00203FD4
	internal static void Pause()
	{
		if (1226.31 != null)
		{
			1226.105();
			1226.31.Play(true);
			1226.32 = (1042)2;
		}
	}

	// Token: 0x060051F2 RID: 20978 RVA: 0x00205DF4 File Offset: 0x00203FF4
	internal static bool 107()
	{
		if (1226.4)
		{
			if (1226.32 != (1042)1)
			{
				1226.32 = (1042)1;
				1226.112();
				return false;
			}
			1226.32 = (1042)0;
			1226.111();
			return true;
		}
		else
		{
			if (1226.31 == null || 1226.31.IsPlaying())
			{
				1226.32 = (1042)0;
				1226.111();
				1240 <<EMPTY_NAME>> = 1226.31;
				if (<<EMPTY_NAME>> != null)
				{
					<<EMPTY_NAME>>.Pause();
				}
				return true;
			}
			1226.105();
			1226.112();
			1226.32 = (1042)2;
			1226.31.Play(false);
			return false;
		}
	}

	// Token: 0x060051F3 RID: 20979 RVA: 0x00205E76 File Offset: 0x00204076
	internal static void 108()
	{
		1226.110();
		1226.18(delegate
		{
			1226.15.3(new Action<1255>(1226.1227.Instance.4));
			1226.15.4();
		});
	}

	// Token: 0x060051F4 RID: 20980 RVA: 0x00205EA1 File Offset: 0x002040A1
	internal static void 109()
	{
		if (1226.4)
		{
			if (1226.32 != (1042)1)
			{
				1226.32 = (1042)1;
				1226.112();
				return;
			}
		}
		else
		{
			1226.105();
			1226.31.Play(false);
			1226.32 = (1042)2;
		}
	}

	// Token: 0x060051F5 RID: 20981 RVA: 0x00205ED4 File Offset: 0x002040D4
	internal static void 110()
	{
		1226.18(new Action(1226.1227.Instance.7));
	}

	// Token: 0x060051F6 RID: 20982 RVA: 0x00205EEB File Offset: 0x002040EB
	internal static void 111()
	{
		1226.18(new Action(1226.1227.Instance.8));
	}

	// Token: 0x060051F7 RID: 20983 RVA: 0x00205F02 File Offset: 0x00204102
	internal static void 112()
	{
		1226.18(delegate
		{
			1226.15.3(new Action<1255>(1226.1227.Instance.10));
		});
	}

	// Token: 0x060051F8 RID: 20984 RVA: 0x00205F28 File Offset: 0x00204128
	internal static bool 113()
	{
		1240 <<EMPTY_NAME>> = 1226.31;
		if (<<EMPTY_NAME>> != null && <<EMPTY_NAME>>.IsPlaying())
		{
			1226.107();
			return true;
		}
		return false;
	}

	// Token: 0x04003E27 RID: 15911
	internal static bool 1 = true;

	// Token: 0x04003E28 RID: 15912
	internal static bool 2;

	// Token: 0x04003E29 RID: 15913
	private static 915 3;

	// Token: 0x04003E2A RID: 15914
	internal static bool 4;

	// Token: 0x04003E2B RID: 15915
	internal static bool 5;

	// Token: 0x04003E2C RID: 15916
	private static readonly Dictionary<string, int> 6 = new Dictionary<string, int>();

	// Token: 0x04003E2D RID: 15917
	private static readonly Dictionary<string, int> 7 = new Dictionary<string, int>();

	// Token: 0x04003E2E RID: 15918
	private static readonly Dictionary<string, int> 8 = new Dictionary<string, int>();

	// Token: 0x04003E2F RID: 15919
	private static List<1256> 9 = new List<1256>();

	// Token: 0x04003E30 RID: 15920
	private static double 10 = 0.0;

	// Token: 0x04003E31 RID: 15921
	internal static int 11;

	// Token: 0x04003E32 RID: 15922
	private static int 12;

	// Token: 0x04003E33 RID: 15923
	private static int 13;

	// Token: 0x04003E34 RID: 15924
	private static int 14;

	// Token: 0x04003E35 RID: 15925
	internal static 1185<1255> 15 = new 1185<1255>();

	// Token: 0x04003E36 RID: 15926
	internal static int 16 = 0;

	// Token: 0x04003E37 RID: 15927
	internal static int 17 = 0;

	// Token: 0x04003E38 RID: 15928
	internal static int 18 = 0;

	// Token: 0x04003E39 RID: 15929
	internal static int 19 = 0;

	// Token: 0x04003E3A RID: 15930
	internal static int 20;

	// Token: 0x04003E3B RID: 15931
	internal static double 21;

	// Token: 0x04003E3C RID: 15932
	internal static double 22;

	// Token: 0x04003E3D RID: 15933
	private static 1189 23;

	// Token: 0x04003E3E RID: 15934
	private static 1253 24;

	// Token: 0x04003E3F RID: 15935
	internal static 1254 25 = 1254.None;

	// Token: 0x04003E40 RID: 15936
	private static 1253 26;

	// Token: 0x04003E41 RID: 15937
	private static 1254 27 = 1254.None;

	// Token: 0x04003E42 RID: 15938
	private static 1254 28 = 1254.None;

	// Token: 0x04003E43 RID: 15939
	internal static float 29;

	// Token: 0x04003E44 RID: 15940
	internal static float 30;

	// Token: 0x04003E45 RID: 15941
	internal static 1240 31;

	// Token: 0x04003E46 RID: 15942
	internal static 1042 32;

	// Token: 0x04003E47 RID: 15943
	internal static string 33;

	// Token: 0x04003E48 RID: 15944
	internal static string 34;

	// Token: 0x04003E49 RID: 15945
	private static 1253 35;

	// Token: 0x04003E4A RID: 15946
	internal static 1318 36;

	// Token: 0x04003E4B RID: 15947
	internal static 1318 37;

	// Token: 0x04003E4C RID: 15948
	internal static 1318 38;

	// Token: 0x04003E4D RID: 15949
	internal static 1318 39;

	// Token: 0x04003E4E RID: 15950
	internal static bool 40;

	// Token: 0x04003E4F RID: 15951
	internal static bool 41;

	// Token: 0x04003E50 RID: 15952
	private static 1250 42;

	// Token: 0x04003E51 RID: 15953
	internal static float 43;

	// Token: 0x04003E52 RID: 15954
	internal static Dictionary<string, string> 44 = new Dictionary<string, string>();

	// Token: 0x04003E53 RID: 15955
	internal static Dictionary<int, long> 45 = new Dictionary<int, long>();

	// Token: 0x04003E54 RID: 15956
	private static int[,,] 46 = new int[4, 3, 3];

	// Token: 0x04003E55 RID: 15957
	private static int[,,] 47 = new int[1, 3, 3];

	// Token: 0x04003E56 RID: 15958
	private static int[,,] 48 = new int[2, 3, 3];

	// Token: 0x04003E57 RID: 15959
	private static int 49;

	// Token: 0x04003E58 RID: 15960
	internal static bool 50;

	// Token: 0x04003E59 RID: 15961
	private static 1254[] 51 = new 1254[]
	{
		1254.Normal,
		1254.Soft,
		1254.Drum
	};

	// Token: 0x04003E5A RID: 15962
	private static bool 52;

	// Token: 0x04003E5B RID: 15963
	private static bool 53;

	// Token: 0x04003E5C RID: 15964
	private static int 54;

	// Token: 0x04003E5D RID: 15965
	private static long 55;

	// Token: 0x04003E5E RID: 15966
	internal static int 56;

	// Token: 0x04003E5F RID: 15967
	internal static float 57;

	// Token: 0x04003E60 RID: 15968
	internal static bool 58;

	// Token: 0x04003E61 RID: 15969
	private static List<1240> 59 = new List<1240>();

	// Token: 0x04003E62 RID: 15970
	private static 1189 60;

	// Token: 0x04003E63 RID: 15971
	internal static List<1000> 61 = new List<1000>();

	// Token: 0x04003E64 RID: 15972
	internal static string 62;

	// Token: 0x04003E65 RID: 15973
	internal static int 63;

	// Token: 0x04003E66 RID: 15974
	private static int 64;

	// Token: 0x04003E67 RID: 15975
	private static bool 65;

	// Token: 0x04003E68 RID: 15976
	private static bool 66;

	// Token: 0x04003E69 RID: 15977
	internal static int 67;

	// Token: 0x04003E6A RID: 15978
	internal static double 68;

	// Token: 0x04003E6B RID: 15979
	internal static bool 69;

	// Token: 0x04003E6C RID: 15980
	internal static int 70 = -1;

	// Token: 0x04003E6D RID: 15981
	internal static int 71 = -1;

	// Token: 0x04003E6E RID: 15982
	private static 1189 72;

	// Token: 0x04003E6F RID: 15983
	private static 1226.1236 73;

	// Token: 0x04003E70 RID: 15984
	private static 1226.1236 74;

	// Token: 0x04003E71 RID: 15985
	private static readonly List<1255> 75 = new List<1255>();

	// Token: 0x02000B9B RID: 2971
	[Serializable]
	public sealed class 1227
	{
		// Token: 0x060051FA RID: 20986 RVA: 0x00206048 File Offset: 0x00204248
		internal void 1(1256 1)
		{
			1.6();
		}

		// Token: 0x060051FB RID: 20987 RVA: 0x00206050 File Offset: 0x00204250
		internal bool 2(1256 1)
		{
			return 1.9;
		}

		// Token: 0x060051FC RID: 20988 RVA: 0x00206058 File Offset: 0x00204258
		internal void 3(1240 1)
		{
			1.SetVolume(1226.57);
		}

		// Token: 0x060051FD RID: 20989 RVA: 0x00206065 File Offset: 0x00204265
		internal void 4(1255 1)
		{
			if (1.7)
			{
				1219.5(1.3);
			}
		}

		// Token: 0x060051FE RID: 20990 RVA: 0x0020607A File Offset: 0x0020427A
		internal void 5()
		{
			1219.Pause(1226.12);
			1219.Pause(1226.13);
		}

		// Token: 0x060051FF RID: 20991 RVA: 0x00206092 File Offset: 0x00204292
		internal void 6()
		{
			1219.Pause(1226.14);
		}

		// Token: 0x06005200 RID: 20992 RVA: 0x0020609F File Offset: 0x0020429F
		internal void 7()
		{
			1226.15.3(delegate(1255 1)
			{
				1256 2 = 1.5;
				if (2 == null)
				{
					return;
				}
				2.12(true);
			});
		}

		// Token: 0x06005201 RID: 20993 RVA: 0x002060CA File Offset: 0x002042CA
		internal void 8()
		{
			1226.15.3(new Action<1255>(1226.1227.Instance.9));
		}

		// Token: 0x06005202 RID: 20994 RVA: 0x002060E6 File Offset: 0x002042E6
		internal void 9(1255 1)
		{
			if (1.5 != null && 1.5.14())
			{
				1.5.Pause();
				1.2 = true;
			}
		}

		// Token: 0x06005203 RID: 20995 RVA: 0x0020610F File Offset: 0x0020430F
		internal void 10(1255 1)
		{
			if (1.2)
			{
				1.5.Play(false, false);
				1.2 = false;
			}
		}

		// Token: 0x06005204 RID: 20996 RVA: 0x0020612D File Offset: 0x0020432D
		internal void 11()
		{
			1226.16(null, true);
		}

		// Token: 0x06005205 RID: 20997 RVA: 0x00206137 File Offset: 0x00204337
		internal void 12()
		{
			1226.16(1304.179, true);
		}

		// Token: 0x04003E72 RID: 15986
		public static readonly 1226.1227 Instance = new 1226.1227();

		// Token: 0x04003E73 RID: 15987
		public static Action<1256> action;

		// Token: 0x04003E74 RID: 15988
		public static Predicate<1256> predicate;

		// Token: 0x04003E75 RID: 15989
		public static Action action2;

		// Token: 0x04003E76 RID: 15990
		public static Action action3;

		// Token: 0x04003E77 RID: 15991
		public static Action action4;

		// Token: 0x04003E78 RID: 15992
		public static 1189 voidDelegate;

		// Token: 0x04003E79 RID: 15993
		public static Action<1240> action5;

		// Token: 0x04003E7A RID: 15994
		public static Action<1255> action6;

		// Token: 0x04003E7B RID: 15995
		public static Action action7;

		// Token: 0x04003E7C RID: 15996
		public static Action action8;

		// Token: 0x04003E7D RID: 15997
		public static Action action9;

		// Token: 0x04003E7E RID: 15998
		public static Action<1255> action10;

		// Token: 0x04003E7F RID: 15999
		public static Action action11;

		// Token: 0x04003E80 RID: 16000
		public static Action<1255> action12;

		// Token: 0x04003E81 RID: 16001
		public static Action action13;

		// Token: 0x04003E82 RID: 16002
		public static Action<1255> action14;

		// Token: 0x04003E83 RID: 16003
		public static Action action15;

		// Token: 0x04003E84 RID: 16004
		public static 1189 voidDelegate2;

		// Token: 0x04003E85 RID: 16005
		public static 1189 voidDelegate3;

		// Token: 0x04003E86 RID: 16006
		public static 1189 voidDelegate4;
	}

	// Token: 0x02000B9D RID: 2973
	public sealed class 1228
	{
		// Token: 0x04003E89 RID: 16009
		public string 1;
	}

	// Token: 0x02000B9E RID: 2974
	public sealed class 1229
	{
		// Token: 0x0600520C RID: 21004 RVA: 0x00206175 File Offset: 0x00204375
		internal void Play()
		{
			this.1.Play(true, false);
		}

		// Token: 0x04003E8A RID: 16010
		public 1256 1;
	}

	// Token: 0x02000B9F RID: 2975
	public sealed class 1238
	{
		// Token: 0x0600520E RID: 21006 RVA: 0x00206184 File Offset: 0x00204384
		internal void Play()
		{
			this.1.Play(true, false);
		}

		// Token: 0x04003E8B RID: 16011
		public 1256 1;
	}

	// Token: 0x02000BA0 RID: 2976
	public sealed class 1231
	{
		// Token: 0x06005210 RID: 21008 RVA: 0x00206193 File Offset: 0x00204393
		internal void Play()
		{
			this.1.Play(true, false);
		}

		// Token: 0x04003E8C RID: 16012
		public 1256 1;
	}

	// Token: 0x02000BA1 RID: 2977
	public sealed class 1230
	{
		// Token: 0x06005212 RID: 21010 RVA: 0x002061A2 File Offset: 0x002043A2
		internal void 1()
		{
			1256 <<EMPTY_NAME>> = this.1;
			if (<<EMPTY_NAME>> == null)
			{
				return;
			}
			<<EMPTY_NAME>>.12(true);
		}

		// Token: 0x04003E8D RID: 16013
		public 1256 1;
	}

	// Token: 0x02000BA2 RID: 2978
	public sealed class 1235
	{
		// Token: 0x06005214 RID: 21012 RVA: 0x002061B5 File Offset: 0x002043B5
		internal void Apply()
		{
			1025.BASS_ChannelSetAttribute(1226.12, (994)3, this.1.Value);
			1025.BASS_ChannelSetAttribute(1226.13, (994)3, this.1.Value);
		}

		// Token: 0x04003E8E RID: 16014
		public float? 1;
	}

	// Token: 0x02000BA3 RID: 2979
	public sealed class 1233
	{
		// Token: 0x06005216 RID: 21014 RVA: 0x002061E5 File Offset: 0x002043E5
		internal void Play()
		{
			this.1.Play(true, false);
		}

		// Token: 0x04003E8F RID: 16015
		public 1256 1;
	}

	// Token: 0x02000BA4 RID: 2980
	public sealed class 1232
	{
		// Token: 0x06005218 RID: 21016 RVA: 0x002061F4 File Offset: 0x002043F4
		internal void Play()
		{
			this.1.Play(true, false);
		}

		// Token: 0x04003E90 RID: 16016
		public 1256 1;
	}

	// Token: 0x02000BA5 RID: 2981
	public sealed class 1237
	{
		// Token: 0x0600521A RID: 21018 RVA: 0x00206203 File Offset: 0x00204403
		internal bool 1(1259 1)
		{
			return 1.1() && 1.3 < (double)this.1;
		}

		// Token: 0x04003E91 RID: 16017
		public int 1;
	}

	// Token: 0x02000BA6 RID: 2982
	// (Invoke) Token: 0x0600521D RID: 21021
	public delegate void 1236(1259 1);

	// Token: 0x02000BA7 RID: 2983
	public sealed class 1234
	{
		// Token: 0x04003E92 RID: 16018
		public int 1;
	}

	// Token: 0x02000BA8 RID: 2984
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04003E93 RID: 16019
		public static 1189 <0>__CheckDeviceChanges;

		// Token: 0x04003E94 RID: 16020
		public static EventHandler <1>__OnVolumeChanged;

		// Token: 0x04003E95 RID: 16021
		public static EventHandler <2>__OnMusicVolumeChanged;
	}
}
