using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x02000B45 RID: 2885
public static class 1304
{
	// Token: 0x06004F8A RID: 20362 RVA: 0x001F6438 File Offset: 0x001F4638
	static 1304()
	{
		1304.3();
	}

	// Token: 0x06004F8B RID: 20363 RVA: 0x001F6453 File Offset: 0x001F4653
	internal static string 1()
	{
		return 268.9("osu!." + 2672.3(Environment.UserName) + ".cfg");
	}

	// Token: 0x06004F8C RID: 20364 RVA: 0x001F6473 File Offset: 0x001F4673
	private static void 2()
	{
		new 1304.1305();
	}

	// Token: 0x06004F8D RID: 20365 RVA: 0x001F647C File Offset: 0x001F467C
	public static void 3()
	{
		if (1304.1.Count > 0)
		{
			return;
		}
		1304.5(268.1("osu!.cfg"));
		1304.5(268.2(1304.1()));
		1304.2();
		1304.212 = 1304.12("BeatmapDirectory", "Songs");
		1304.212.SetValue(2672.17(1304.212.GetValue()));
		if (!1304.212.1() && !Directory.Exists(1304.212.GetValue()))
		{
			1304.212.SetValue(1304.212.2);
			1763.4(1568.1(2679.ConfigManager_SongFolderNotFound));
		}
		1272.1 = (1304.212.1() ? Path.Combine(1345.4(), 1304.212.GetValue()) : 1304.212.GetValue());
		1226.39 = 1304.17("VolumeUniversal", 100, 0, 100);
		1226.36 = 1304.17("VolumeEffect", 80, 0, 100);
		1226.38 = 1304.17("VolumeMusic", 80, 0, 100);
		bool flag = 1304.1.ContainsKey("VolumeHitSound");
		1226.37 = 1304.17("VolumeHitSound", 80, 0, 100);
		if (!flag)
		{
			1226.37.7(1226.36.6());
		}
		1304.5 = 1304.14("AllowPublicInvites", true);
		1304.6 = 1304.14("AutoChatHide", true);
		1304.7 = 1304.14("AutomaticDownload", true);
		1304.8 = 1304.14("AutomaticDownloadNoVideo", false);
		1304.9 = 1304.12("BeatmapMirror", 1632.DefaultName);
		1304.10 = 1304.14("SongSelectRateMusic", true);
		1304.11 = 1304.14("CheckBeatmapUpdates", true);
		1304.12 = 1304.14("ProfileCountOsuScores", false);
		1304.13 = 1304.14("ProfileCountExtraMods", true);
		1304.14 = 1304.14("ProfileCountRandom", true);
		1304.15 = 1304.14("ProfileCountMirror", true);
		1304.16 = 1304.14("ProfileCountDifficultyAdjust", true);
		1304.17 = 1304.14("ProfileCountNoNotelock", true);
		1304.18 = 1304.14("ProfileCountAlternate", true);
		1304.19 = 1304.14("ProfileCountSingleTap", true);
		1304.20 = 1304.14("ProfileCountCustomRate", true);
		1304.21 = 1304.14("ProfileCountPractice", false);
		1304.22 = 1304.14("ProfileExtraModsMigrated", false);
		1304.23 = 1304.14("ProfileAllowExtraMods", true);
		1304.24 = 1304.14("ProfileCountRelax", false);
		1304.25 = 1304.17("RelaxPpSystem", 2, 0, 2);
		1304.26 = 1304.17("PracticeRetryDelay", 1500, 0, 5000);
		1304.27 = 1304.14("PracticeLoopSegments", false);
		1304.28 = 1304.14("RelaxNormalScoreMultiplier", false);
		1304.29 = 1304.14("RelaxShowMisses", false);
		1304.30 = 1304.14("RelaxComboBreakSound", false);
		1304.31 = 1304.14("RelaxSaveScores", false);
		1304.32 = 1304.14("RelaxAllowFail", false);
		1304.33 = 1304.14("RelaxNoOffset", false);
		1304.34 = 1304.17("FlashlightStartCombo", 0, 0, 200);
		1304.35 = 1304.14("FlashlightKeepSize", false);
		1304.36 = 1304.14("ProfileStatusRanked", true);
		1304.37 = 1304.14("ProfileStatusLoved", true);
		1304.38 = 1304.14("ProfileStatusQualified", false);
		1304.39 = 1304.14("ProfileStatusPending", false);
		1304.40 = 1304.14("ProfileStatusUnknown", false);
		1304.41 = 1304.14("ShowRanks", true);
		1304.42 = 1304.14("ShowCountryRank", false);
		1304.43 = 1304.14("RateMenuOpenedHalfTime", false);
		1304.44 = 1304.14("RateMenuOpenedDoubleTime", false);
		1304.45 = 1304.17("ProfileTopPlaysShown", 200, 100, 1000);
		1304.46 = 1304.19("GameplayGamma", 1.0, 0.1, 3.0);
		1304.47 = 1304.12("GameplayGammaByAR", string.Empty);
		1304.48 = 1304.12("OsuApiClientId", string.Empty);
		1304.49 = 1304.12("OsuApiClientSecret", string.Empty);
		1304.50 = 1304.14("OsuApiEnabled", true);
		1304.51 = 1304.14("DiscordBotEnabled", true);
		1304.52 = 1304.12("DiscordBotToken", string.Empty);
		1304.53 = 1304.14("InstantFade", false);
		1304.54 = 1304.14("DisableKiaiEffects", false);
		1304.55 = 1304.14("IgnoreCountdown", false);
		1304.56 = 1304.14("SkippableBreaks", false);
		1304.57 = 1304.14("AdjustDuringPlay", false);
		1304.58 = 1304.14("CursorTrail", true);
		1304.59 = 1304.14("ReplayTapMarkers", false);
		1304.60 = 1304.12("ReplayControlsPosition", string.Empty);
		1304.61 = 1304.12("DifficultyAdjust", string.Empty);
		1304.62 = 1304.14("RateNoLimits", false);
		1304.63 = 1304.14("HiddenOnlyApproachCircles", false);
		1304.64 = 1304.14("HideApproachCircles", false);
		1304.2 = 1304.14("BlockNonFriendPM", false);
		1304.65 = 1304.16("Bloom", "Shaders", false);
		1304.66 = 1304.14("BloomSoftening", false);
		1304.67 = 1304.14("BossKeyFirstActivation", true);
		1304.68 = 1304.14("ChatAudibleHighlight", true);
		1304.176 = 1304.12("ChatChannels", string.Empty);
		1304.70 = 1304.14("ChatFilter", false);
		1304.71 = 1304.14("ChatHighlightName", true);
		1304.72 = 1304.14("ChatMessageNotification", true);
		1304.177 = 1304.12("ChatLastChannel", string.Empty);
		1304.73 = 1304.14("ChatRemoveForeign", false);
		1304.74 = 1304.14("ComboBurst", false);
		1304.75 = 1304.14("ComboFire", false);
		1304.137 = 1304.17("ComboFireHeight", 3, int.MinValue, int.MaxValue);
		1304.76 = 1304.14("ConfirmExit", false);
		1304.131 = 1304.14("AutoSendNowPlaying", true);
		1304.132 = 1304.19("CursorSize", 1.0, 0.10000000149011612, 2.0);
		1304.133 = 1304.14("AutomaticCursorSizing", false);
		1304.141 = 1304.17("DimLevel", 80, 0, 1662.47 ? 90 : 100);
		1304.142 = 1304.14("IHateHavingFun", false);
		1304.160 = 1304.17("Display", 1, int.MinValue, int.MaxValue);
		1304.77 = 1304.14("DisplayCityLocation", false);
		1304.78 = 1304.14("DistanceSpacingEnabled", true);
		1304.147 = 1304.17("EditorTip", 0, int.MinValue, int.MaxValue);
		1304.79 = 1304.14("EditorVideo", true);
		1304.80 = 1304.14("EditorDim", false);
		1304.143 = 1304.14("EditorGrid", false);
		1304.81 = 1304.14("EditorDefaultSkin", false);
		1304.82 = 1304.14("EditorSnakingSliders", true);
		1304.82.SubscribeChanged(new EventHandler(1304.1306.Instance.1));
		1304.83 = 1304.14("EditorHitAnimations", false);
		1304.84 = 1304.14("EditorFollowPoints", true);
		1304.85 = 1304.14("EditorStacking", true);
		1304.88 = 1304.14("ForceSliderRendering", false);
		1304.89 = 1304.14("FpsCounter", false);
		1304.173 = false;
		1304.178 = 1304.12("GuideTips", string.Empty);
		1304.86 = 1304.14("CursorRipple", false);
		1304.182 = 1304.12("HighlightWords", string.Empty);
		1304.90 = 1304.14("HighResolution", false);
		1304.91 = 1304.14("HitLighting", true);
		1304.92 = 1304.14("IgnoreBarline", false);
		1304.93 = 1304.14("IgnoreBeatmapSamples", false);
		1304.94 = 1304.14("IgnoreBeatmapSkins", false);
		1304.183 = 1304.12("IgnoreList", string.Empty);
		1304.95 = 1304.14("KeyOverlay", false);
		1304.4 = 1304.12("Language", "unknown");
		2601.73 = 1304.11<2147>("LastPlayMode", 2147.Osu, false);
		1304.211 = 1304.14("AllowNowPlayingHighlights", false);
		1304.184 = 1304.12("LastVersion", string.Empty);
		1304.185 = 1304.12("LastVersionPermissionsFailed", string.Empty);
		1304.96 = 1304.14("LoadSubmittedThread", true);
		1304.161 = 1304.17("LobbyPlayMode", -1, int.MinValue, int.MaxValue);
		1304.168 = 1304.14("ShowInterface", true);
		1304.169 = 1304.14("ShowInterfaceDuringRelax", false);
		1304.97 = 1304.14("LobbyShowExistingOnly", false);
		1304.98 = 1304.14("LobbyShowFriendsOnly", false);
		1304.99 = 1304.14("LobbyShowFull", false);
		1304.100 = 1304.14("LobbyShowInProgress", true);
		1304.101 = 1304.14("LobbyShowPassworded", true);
		1304.102 = 1304.14("LogPrivateMessages", false);
		1304.103 = 1304.14("LowResolution", false);
		1304.150 = 1304.17("ManiaSpeed", 12, 1, 40);
		if (1304.150.6() == 1)
		{
			1304.150.7(12);
		}
		1304.151 = 1304.14("UsePerBeatmapManiaSpeed", false);
		1304.152 = 1304.14("ManiaSpeedBPMScale", false);
		1304.153 = 1304.17("MenuTip", 0, int.MinValue, int.MaxValue);
		1304.104 = 1304.14("MouseDisableButtons", false);
		1304.105 = 1304.14("MouseDisableWheel", false);
		1304.139 = 1304.19("MouseSpeed", 1.0, 0.1, 6.0);
		1304.154 = 1304.17("Offset", 0, -300, 300);
		1304.195 = 1304.19("ScoreMeterScale", 1.0, 0.5, (double)(1662.47 ? 10 : 5));
		1304.138 = 1304.19("DistanceSpacing", 0.8, 0.1, 6.0);
		1304.144 = 1304.17("EditorBeatDivisor", 1, 1, 16);
		1304.145 = 1304.17("EditorGridSize", 32, 4, 32);
		1304.146 = 1304.17("EditorGridSizeDesign", 32, 4, 32);
		1304.148 = 1304.17("Height", 9999, (!1662.47) ? 480 : 0, 9999);
		1304.157 = 1304.17("Width", 9999, (!1662.47) ? 640 : 0, 9999);
		1304.149 = 1304.17("HeightFullscreen", 9999, 480, 9999);
		1304.158 = 1304.17("WidthFullscreen", 9999, 640, 9999);
		1304.140 = (1662.47 ? new 1318(60) : 1304.17("CustomFrameLimit", 240, 60, 999));
		1304.106 = 1304.14("MsnIntegration", false);
		1304.107 = 1304.14("MyPcSucks", false);
		1304.108 = 1304.14("NotifyFriends", true);
		1304.109 = 1304.14("NotifySubmittedThread", true);
		1304.111 = 1304.14("PopupDuringGameplay", true);
		1304.3 = 1304.11<1409>("ProgressBarType", 1409.Pie, false);
		1304.164 = 1304.11<1289>("RankType", 1289.Top, false);
		1304.155 = 1304.17("RefreshRate", 60, int.MinValue, int.MaxValue);
		1304.156 = 1304.14("OverrideRefreshRate", 1304.155.6() != 60);
		1304.165 = 1304.11<1311>("ScaleMode", 1311.WidescreenConservative, false);
		1304.114 = 1304.14("ScoreboardVisible", true);
		1304.166 = 1304.11<2151>("ScoreMeter", 1662.47 ? 2151.Colour : 2151.Error, false);
		1304.162 = 1304.17("ScreenshotId", 0, int.MinValue, int.MaxValue);
		1304.170 = 1304.14("MenuSnow", false);
		1304.171 = 1304.14("MenuTriangles", true);
		1304.172 = 1304.14("SongSelectThumbnails", true);
		1304.159 = 1304.11<1207>("ScreenshotFormat", 1207.Jpg, false);
		1304.115 = 1304.14("ShowReplayComments", false);
		1304.116 = 1304.14("ShowSpectators", true);
		1304.117 = 1304.14("ShowStoryboard", true);
		1304.187 = 1304.12("Skin", "Default");
		1304.120 = 1304.14("SkinSamples", true);
		1304.121 = 1304.14("SkipTablet", false);
		1304.122 = 1304.14("SnakingSliders", true);
		1304.123 = 1304.14("SnakingOutSliders", false);
		1304.124 = 1304.14("HighQualitySliders", false);
		1304.125 = 1304.14("Tablet", false);
		1304.127 = 1304.14("UpdatePending", false);
		1304.128 = 1304.14("UseSkinCursor", false);
		1304.129 = 1304.11<1312>("SeasonalBackgrounds", 1312.Sometimes, false);
		1304.130 = 1304.14("UseTaikoSkin", false);
		1304.134 = 1304.14("Video", true);
		1304.135 = 1304.14("Wiimote", false);
		1304.136 = 1304.14("YahooIntegration", false);
		1304.175 = 1304.14("ForceFrameFlush", false);
		1304.174 = 1304.14("DetectPerformanceIssues", true);
		1304.174.SubscribeChanged(delegate(object 1, EventArgs 2)
		{
			1662.11.15.1 = 1304.174;
		});
		1304.167 = (1662.47 ? new 1313(false) : 1304.14("Fullscreen", true));
		1304.199 = 1304.14("MenuMusic", true);
		1304.200 = 1304.14("MenuVoice", true);
		1304.118 = 1304.14("MenuParallax", true);
		1304.191 = 1304.14("RawInput", false);
		1304.205 = 1304.14("AbsoluteToOsuWindow", 1304.191.1());
		1304.192 = 1304.11<1302>("ConfineMouse", 1304.15("ConfineMouseToFullscreen", true) ? 1302.Fullscreen : 1302.Never, false);
		1304.196 = 1304.14("ShowMenuTips", true);
		1304.202 = 1304.14("HiddenShowFirstApproach", true);
		1304.69 = 1304.14("ComboColourSliderBall", true);
		1304.197 = 1304.14("AlternativeChatFont", false);
		1304.197.SubscribeChanged(new EventHandler(1304.1306.Instance.3));
		1304.186 = null;
		1304.1["Password"] = string.Empty;
		1304.190 = 1304.12("CredentialEndpoint", string.Empty);
		1304.189 = 1304.12("Username", string.Empty);
		1304.207 = 1304.19("DisplayStarsMaximum", 10.0, 0.0, 10.0);
		1304.207.SubscribeChanged(delegate(object 1, EventArgs 2)
		{
			if (1304.207.GetValue() < 1304.206.GetValue())
			{
				1304.206.SetValue(1304.207.GetValue());
			}
		});
		1304.206 = 1304.19("DisplayStarsMinimum", 0.0, 0.0, 10.0);
		1304.206.SubscribeChanged(new EventHandler(1304.1306.Instance.3));
		1304.179 = 1304.12("AudioDevice", string.Empty);
		1304.179.SubscribeChanged(new EventHandler(1304.1306.Instance.4));
		1304.181 = 1304.14("LowLatencyAudio", false);
		1304.181.SubscribeChanged(delegate(object 1, EventArgs 2)
		{
			1226.16(1304.179.GetValue(), true);
			if (1219.NeedsRestart)
			{
				1763.5("Restart nekiosu to switch the audio engine.", global::198.Orange, 5000, null);
			}
		});
		1304.180 = 1304.14("AudioCompatibility", false);
		1304.180.SubscribeChanged(delegate(object 1, EventArgs 2)
		{
			if (!1226.16(1304.179.GetValue(), true))
			{
				1304.180.2(!1304.180.1());
			}
		});
		1304.198 = 1304.11<2667>("_ReleaseStream", 2667.Stable40, true);
		1304.201 = 1304.17("_UpdateFailCount", 0, int.MinValue, int.MaxValue);
		1304.198.SubscribeChanged(new EventHandler(1304.1306.Instance.5));
		1304.131.SubscribeChanged(delegate(object 1, EventArgs 2)
		{
			if (1304.131.1())
			{
				1304.116.2(true);
			}
		});
		1304.116.SubscribeChanged(new EventHandler(1304.1306.Instance.6));
		1304.132.SubscribeChanged(new EventHandler(1304.1306.Instance.7));
		1304.112 = 1304.14("SavePassword", 1304.186 != null);
		1304.113 = 1304.14("SaveUsername", true);
		1304.113.SubscribeChanged(delegate(object 1, EventArgs 2)
		{
			1304.1["Username"] = 1304.189;
		});
		1304.152.SubscribeChanged(new EventHandler(1304.1306.Instance.8));
		1304.151.SubscribeChanged(delegate(object 1, EventArgs 2)
		{
			if (!1304.151.1())
			{
				1272.3.ForEach(new Action<1262>(1304.1306.Instance.10));
			}
		});
		if (!1304.112)
		{
			1304.1["Password"] = string.Empty;
		}
		if (1304.190.GetValue() != 1345.11)
		{
			1304.1["Password"] = string.Empty;
			1304.186 = null;
			1304.229 = true;
		}
		1304.193 = 1304.11<2591>("TreeSortMode", 2591.Search, false);
		1304.194 = 1304.11<2620>("TreeSortMode2", 2620.Title, false);
		1304.182.SubscribeChanged(new EventHandler(1304.1306.Instance.11));
		1535.34();
		1304.2.SubscribeChanged(new EventHandler(1304.1306.Instance.12));
		1304.4.SubscribeChanged(new EventHandler(1304.1306.Instance.13));
		1304.191.SubscribeChanged(new EventHandler(1304.1306.Instance.15));
		1304.125.SubscribeChanged(delegate(object 1, EventArgs 2)
		{
			1562 4 = 1535.27(typeof(1562)) as 1562;
			if (1304.125.1() && 4 == null)
			{
				4 = new 1562();
				if (!1535.28(4))
				{
					1304.125.2(false);
					4 = null;
				}
			}
			if (4 != null)
			{
				4.1(1304.125.1());
			}
		});
		1304.139.SubscribeChanged(new EventHandler(1304.1306.Instance.16));
		1304.167.SubscribeChanged(new EventHandler(1304.1306.Instance.17));
		1304.208 = (1662.47 ? new 1313(false) : 1304.14("Letterboxing", 1304.167.1()));
		1304.208.SubscribeChanged(new EventHandler(1304.1306.Instance.18));
		1304.209 = 1304.17("LetterboxPositionX", 0, -100, 100);
		1319 <<EMPTY_NAME>> = 1304.209;
		EventHandler eventHandler;
		if ((eventHandler = 1304.<>O.<0>__RefreshClientBounds) == null)
		{
			eventHandler = (1304.<>O.<0>__RefreshClientBounds = new EventHandler(1662.39));
		}
		<<EMPTY_NAME>>.SubscribeChanged(eventHandler);
		1304.210 = 1304.17("LetterboxPositionY", 0, -100, 100);
		1319 3 = 1304.210;
		EventHandler eventHandler2;
		if ((eventHandler2 = 1304.<>O.<0>__RefreshClientBounds) == null)
		{
			eventHandler2 = (1304.<>O.<0>__RefreshClientBounds = new EventHandler(1662.39));
		}
		3.SubscribeChanged(eventHandler2);
		1304.203 = (1662.47 ? new 1320<1303>(1303.Custom) : 1304.11<1303>("FrameSync", 1303.Limit120, false));
		1304.203.SubscribeChanged(new EventHandler(1304.1306.Instance.19));
		1304.204 = 1304.11<1309>("MenuFrameRate", 1309.Double, false);
		1304.65.SubscribeChanged(new EventHandler(1304.1306.Instance.20));
		1304.66.SubscribeChanged(new EventHandler(1304.1306.Instance.21));
		bool flag2 = false;
		string a = 1304.4;
		if (a == "zh" || a == "ja" || a == "ko")
		{
			flag2 = true;
		}
		1304.119 = 1304.14("ShowUnicode", flag2);
		1304.110 = 1304.14("PermanentSongInfo", false);
		1304.126 = 1304.14("Ticker", false);
		1304.126.SubscribeChanged(new EventHandler(1304.1306.Instance.22));
		1304.6.SubscribeChanged(new EventHandler(1304.1306.Instance.23));
		1304.213 = 1304.14("CompatibilityContext", false);
		1304.214 = 1304.14("CanForceOptimusCompatibility", true);
		1304.215 = 1304.14("MinimiseOnAltTabFullscreen", true);
		1304.216 = 1304.14("DrawReplayPointer", false);
		1304.4();
		1548.14(false);
		if (1304.229)
		{
			1304.6();
			1304.229 = false;
		}
	}

	// Token: 0x06004F8E RID: 20366 RVA: 0x001F7A04 File Offset: 0x001F5C04
	private static void 4()
	{
		if (1304.107)
		{
			1304.75 = false;
			1304.65 = false;
			1304.66 = false;
			1304.91 = false;
			1304.74 = false;
			1304.122 = false;
		}
	}

	// Token: 0x06004F8F RID: 20367 RVA: 0x001F7A60 File Offset: 0x001F5C60
	private static void 5(string 1)
	{
		if (!File.Exists(1))
		{
			return;
		}
		List<string> list = new List<string>();
		int num = 1;
		for (;;)
		{
			try
			{
				list.Clear();
				using (StreamReader streamReader = File.OpenText(1))
				{
					while (!streamReader.EndOfStream)
					{
						list.Add(streamReader.ReadLine());
					}
				}
				break;
			}
			catch (IOException obj) when (num < 5)
			{
				Thread.Sleep(50);
			}
			num++;
		}
		foreach (string text in list)
		{
			int num2 = text.IndexOf('=');
			if (text.Length != 0 && text[0] != '#' && num2 >= 0)
			{
				string key = text.Substring(0, num2).Trim();
				string value = text.Remove(0, num2 + 1).Trim();
				1304.1[key] = value;
			}
		}
	}

	// Token: 0x06004F90 RID: 20368 RVA: 0x001F7B80 File Offset: 0x001F5D80
	internal static void 6()
	{
		object obj = 1310.3;
		lock (obj)
		{
			1304.190.SetValue(1345.11 ?? string.Empty);
			if (1304.112 && 1304.186 != null)
			{
				try
				{
					1304.1["Password"] = 1304.186.1(1643.Encrypted);
					goto IL_8C;
				}
				catch (Exception ex)
				{
					1338.4(ex, "unable to save password", 1341.Runtime);
					1304.1["Password"] = string.Empty;
					goto IL_8C;
				}
			}
			1304.1["Password"] = string.Empty;
			IL_8C:
			1548.15();
			if (!1662.47 || 1662.48)
			{
				if (!Directory.Exists(1345.4()))
				{
					Directory.CreateDirectory(1345.4());
				}
				if (1310.2 != null)
				{
					try
					{
						foreach (KeyValuePair<string, string> keyValuePair in 1310.2.ToArray<KeyValuePair<string, string>>())
						{
							if (keyValuePair.Key.StartsWith("h_", StringComparison.Ordinal))
							{
								1304.1[keyValuePair.Key] = keyValuePair.Value;
							}
						}
					}
					catch
					{
					}
				}
				1304.8(268.2(1304.1()), false);
				1304.8(268.1("osu!.cfg"), true);
			}
		}
	}

	// Token: 0x06004F91 RID: 20369 RVA: 0x001F7D1C File Offset: 0x001F5F1C
	internal static void 7()
	{
		List<string> list = new List<string>();
		foreach (string text in 1304.1.Keys)
		{
			if (text.StartsWith("h_"))
			{
				list.Add(text);
			}
		}
		foreach (string key in list)
		{
			1304.1.Remove(key);
		}
		1304.6();
	}

	// Token: 0x06004F92 RID: 20370 RVA: 0x001F7DD0 File Offset: 0x001F5FD0
	private static bool 8(string 1, bool 2)
	{
		try
		{
			Stream stream = new 2681(1);
			try
			{
				StreamWriter streamWriter = new StreamWriter(stream);
				try
				{
					if (!2)
					{
						string arg = string.IsNullOrEmpty(1304.189.GetValue()) ? Environment.UserName : 1304.189.GetValue();
						streamWriter.WriteLine("# " + 1568.1(2679.ConfigManager_OsuConfigurationFor0), arg);
						streamWriter.WriteLine("# " + 1568.1(2679.ConfigManager_LastUpdatedOn0), DateTime.Now.ToLongDateString());
						streamWriter.WriteLine();
						streamWriter.WriteLine("# " + 1568.1(2679.ConfigManager_DoNotShare));
						streamWriter.WriteLine("# " + 1568.1(2679.ConfigManager_DoNotShare2));
						streamWriter.WriteLine();
					}
					foreach (KeyValuePair<string, object> keyValuePair in 1304.1)
					{
						if (2 == keyValuePair.Key.Contains("_"))
						{
							streamWriter.WriteLine("{0} = {1}", keyValuePair.Key, keyValuePair.Value.ToString().Replace("\n", string.Empty).Replace("\r", string.Empty));
						}
					}
				}
				finally
				{
					((IDisposable)streamWriter).Dispose();
				}
			}
			finally
			{
				((IDisposable)stream).Dispose();
			}
		}
		catch
		{
			return false;
		}
		return true;
	}

	// Token: 0x06004F93 RID: 20371 RVA: 0x001F7F98 File Offset: 0x001F6198
	internal static bool 9(1321 1)
	{
		return 1304.178.GetValue().Length > (int)1 && 1304.178.GetValue()[(int)1] == '1';
	}

	// Token: 0x06004F94 RID: 20372 RVA: 0x001F7FC4 File Offset: 0x001F61C4
	internal static void 10(1321 1, bool 2)
	{
		while (1304.178.GetValue().Length <= (int)1)
		{
			1320<string> 3 = 1304.178;
			3.SetValue(3.GetValue() + "0");
		}
		1304.178.SetValue(1304.178.GetValue().Remove((int)1, 1).Insert((int)1, 2 ? "1" : "0"));
	}

	// Token: 0x06004F95 RID: 20373 RVA: 0x001F8030 File Offset: 0x001F6230
	private static 1320<T> 11<T>(string 1, T 2, bool 3) where T : IComparable
	{
		T t = 2;
		int num = 0;
		object obj;
		if (1304.1.TryGetValue(1, out obj))
		{
			if (typeof(T).IsEnum)
			{
				if (int.TryParse(obj.ToString(), NumberStyles.Any, 1662.18, out num))
				{
					if (!3)
					{
						t = (T)((object)num);
						goto IL_77;
					}
					goto IL_77;
				}
				else
				{
					try
					{
						t = (T)((object)Enum.Parse(typeof(T), obj.ToString(), true));
						goto IL_77;
					}
					catch
					{
						goto IL_77;
					}
				}
			}
			t = (T)((object)obj);
		}
		IL_77:
		1320<T> 4 = new 1320<T>(t);
		4.SetConfigurationKey(1);
		4.2 = 2;
		1320<T> 5 = 4;
		1304.1[1] = 5;
		return 5;
	}

	// Token: 0x06004F96 RID: 20374 RVA: 0x001F80E8 File Offset: 0x001F62E8
	private static 1320<string> 12(string 1, string 2)
	{
		return 1304.11<string>(1, 2, false);
	}

	// Token: 0x06004F97 RID: 20375 RVA: 0x001F80F4 File Offset: 0x001F62F4
	private static string 13(string 1, string 2)
	{
		string result = 2;
		object obj;
		if (1304.1.TryGetValue(1, out obj))
		{
			result = obj.ToString();
		}
		return result;
	}

	// Token: 0x06004F98 RID: 20376 RVA: 0x001F811C File Offset: 0x001F631C
	private static 1313 14(string 1, bool 2)
	{
		1313 3 = new 1313(1304.15(1, 2));
		3.2 = 2;
		3.SetConfigurationKey(1);
		1313 4 = 3;
		1304.1[1] = 4;
		return 4;
	}

	// Token: 0x06004F99 RID: 20377 RVA: 0x001F8154 File Offset: 0x001F6354
	private static bool 15(string 1, bool 2)
	{
		int num = 0;
		bool result = 2;
		object obj;
		if (1304.1.TryGetValue(1, out obj) && int.TryParse(obj.ToString(), NumberStyles.Any, 1662.18, out num))
		{
			result = (num == 1);
		}
		return result;
	}

	// Token: 0x06004F9A RID: 20378 RVA: 0x001F8194 File Offset: 0x001F6394
	private static 1313 16(string 1, string 2, bool 3)
	{
		if (1304.1.ContainsKey(1))
		{
			bool flag = 1304.15(1, 3);
			1304.1.Remove(1);
			1304.1.Remove(2);
			return 1304.14(2, flag);
		}
		return 1304.14(2, 3);
	}

	// Token: 0x06004F9B RID: 20379 RVA: 0x001F81E0 File Offset: 0x001F63E0
	private static 1318 17(string 1, int 2, int 3, int 4)
	{
		1318 5 = new 1318(1304.18(1, 2));
		5.2((double)3);
		5.4((double)4);
		5.9(2);
		1318 6 = 5;
		1304.1[1] = 6;
		return 6;
	}

	// Token: 0x06004F9C RID: 20380 RVA: 0x001F8220 File Offset: 0x001F6420
	private static int 18(string 1, int 2)
	{
		int result = 2;
		object obj;
		if (1304.1.TryGetValue(1, out obj) && !int.TryParse(obj.ToString(), NumberStyles.Any, 1662.18, out result))
		{
			result = 2;
		}
		return result;
	}

	// Token: 0x06004F9D RID: 20381 RVA: 0x001F825C File Offset: 0x001F645C
	private static 1319 19(string 1, double 2, double 3, double 4)
	{
		1319 5 = new 1319(1304.20(1, 2));
		5.2(3);
		5.4(4);
		5.4 = 2;
		1319 6 = 5;
		1304.1[1] = 6;
		return 6;
	}

	// Token: 0x06004F9E RID: 20382 RVA: 0x001F8298 File Offset: 0x001F6498
	private static double 20(string 1, double 2)
	{
		double result = 2;
		object obj;
		if (1304.1.TryGetValue(1, out obj) && !double.TryParse(obj.ToString(), NumberStyles.Any, 1662.18, out result))
		{
			result = 2;
		}
		return result;
	}

	// Token: 0x06004F9F RID: 20383 RVA: 0x001F82D2 File Offset: 0x001F64D2
	internal static void 21()
	{
		1304.5(268.1("osu!.cfg"));
	}

	// Token: 0x06004FA0 RID: 20384 RVA: 0x001F82E4 File Offset: 0x001F64E4
	internal static void 22()
	{
		foreach (string text in new List<string>(1304.1.Keys))
		{
			if (text.StartsWith("h_"))
			{
				1304.1.Remove(text);
			}
		}
		1304.6();
	}

	// Token: 0x04003B8E RID: 15246
	internal static readonly Dictionary<string, object> 1 = new Dictionary<string, object>();

	// Token: 0x04003B8F RID: 15247
	internal static 1313 2;

	// Token: 0x04003B90 RID: 15248
	internal static 1320<1409> 3;

	// Token: 0x04003B91 RID: 15249
	internal static 1320<string> 4;

	// Token: 0x04003B92 RID: 15250
	internal static 1313 5;

	// Token: 0x04003B93 RID: 15251
	internal static 1313 6;

	// Token: 0x04003B94 RID: 15252
	internal static 1313 7;

	// Token: 0x04003B95 RID: 15253
	internal static 1313 8;

	// Token: 0x04003B96 RID: 15254
	internal static 1320<string> 9;

	// Token: 0x04003B97 RID: 15255
	internal static 1313 10;

	// Token: 0x04003B98 RID: 15256
	internal static 1313 11;

	// Token: 0x04003B99 RID: 15257
	internal static 1313 12;

	// Token: 0x04003B9A RID: 15258
	internal static 1313 13;

	// Token: 0x04003B9B RID: 15259
	internal static 1313 14;

	// Token: 0x04003B9C RID: 15260
	internal static 1313 15;

	// Token: 0x04003B9D RID: 15261
	internal static 1313 16;

	// Token: 0x04003B9E RID: 15262
	internal static 1313 17;

	// Token: 0x04003B9F RID: 15263
	internal static 1313 18;

	// Token: 0x04003BA0 RID: 15264
	internal static 1313 19;

	// Token: 0x04003BA1 RID: 15265
	internal static 1313 20;

	// Token: 0x04003BA2 RID: 15266
	internal static 1313 21;

	// Token: 0x04003BA3 RID: 15267
	internal static 1313 22;

	// Token: 0x04003BA4 RID: 15268
	internal static 1313 23;

	// Token: 0x04003BA5 RID: 15269
	internal static 1313 24;

	// Token: 0x04003BA6 RID: 15270
	internal static 1318 25;

	// Token: 0x04003BA7 RID: 15271
	internal static 1318 26;

	// Token: 0x04003BA8 RID: 15272
	internal static 1313 27;

	// Token: 0x04003BA9 RID: 15273
	internal static 1313 28;

	// Token: 0x04003BAA RID: 15274
	internal static 1313 29;

	// Token: 0x04003BAB RID: 15275
	internal static 1313 30;

	// Token: 0x04003BAC RID: 15276
	internal static 1313 31;

	// Token: 0x04003BAD RID: 15277
	internal static 1313 32;

	// Token: 0x04003BAE RID: 15278
	internal static 1313 33;

	// Token: 0x04003BAF RID: 15279
	internal static 1318 34;

	// Token: 0x04003BB0 RID: 15280
	internal static 1313 35;

	// Token: 0x04003BB1 RID: 15281
	internal static 1313 36;

	// Token: 0x04003BB2 RID: 15282
	internal static 1313 37;

	// Token: 0x04003BB3 RID: 15283
	internal static 1313 38;

	// Token: 0x04003BB4 RID: 15284
	internal static 1313 39;

	// Token: 0x04003BB5 RID: 15285
	internal static 1313 40;

	// Token: 0x04003BB6 RID: 15286
	internal static 1313 41;

	// Token: 0x04003BB7 RID: 15287
	internal static 1313 42;

	// Token: 0x04003BB8 RID: 15288
	internal static 1313 43;

	// Token: 0x04003BB9 RID: 15289
	internal static 1313 44;

	// Token: 0x04003BBA RID: 15290
	internal static 1318 45;

	// Token: 0x04003BBB RID: 15291
	internal static 1319 46;

	// Token: 0x04003BBC RID: 15292
	internal static 1320<string> 47;

	// Token: 0x04003BBD RID: 15293
	internal static 1320<string> 48;

	// Token: 0x04003BBE RID: 15294
	internal static 1320<string> 49;

	// Token: 0x04003BBF RID: 15295
	internal static 1313 50;

	// Token: 0x04003BC0 RID: 15296
	internal static 1313 51;

	// Token: 0x04003BC1 RID: 15297
	internal static 1320<string> 52;

	// Token: 0x04003BC2 RID: 15298
	internal static 1313 53;

	// Token: 0x04003BC3 RID: 15299
	internal static 1313 54;

	// Token: 0x04003BC4 RID: 15300
	internal static 1313 55;

	// Token: 0x04003BC5 RID: 15301
	internal static 1313 56;

	// Token: 0x04003BC6 RID: 15302
	internal static 1313 57;

	// Token: 0x04003BC7 RID: 15303
	internal static 1313 58;

	// Token: 0x04003BC8 RID: 15304
	internal static 1313 59;

	// Token: 0x04003BC9 RID: 15305
	internal static 1320<string> 60;

	// Token: 0x04003BCA RID: 15306
	internal static 1320<string> 61;

	// Token: 0x04003BCB RID: 15307
	internal static 1313 62;

	// Token: 0x04003BCC RID: 15308
	internal static 1313 63;

	// Token: 0x04003BCD RID: 15309
	internal static 1313 64;

	// Token: 0x04003BCE RID: 15310
	internal static 1313 65;

	// Token: 0x04003BCF RID: 15311
	internal static 1313 66;

	// Token: 0x04003BD0 RID: 15312
	internal static 1313 67;

	// Token: 0x04003BD1 RID: 15313
	internal static 1313 68;

	// Token: 0x04003BD2 RID: 15314
	internal static 1313 69;

	// Token: 0x04003BD3 RID: 15315
	internal static 1313 70;

	// Token: 0x04003BD4 RID: 15316
	internal static 1313 71;

	// Token: 0x04003BD5 RID: 15317
	internal static 1313 72;

	// Token: 0x04003BD6 RID: 15318
	internal static 1313 73;

	// Token: 0x04003BD7 RID: 15319
	internal static 1313 74;

	// Token: 0x04003BD8 RID: 15320
	internal static 1313 75;

	// Token: 0x04003BD9 RID: 15321
	internal static 1313 76;

	// Token: 0x04003BDA RID: 15322
	internal static 1313 77;

	// Token: 0x04003BDB RID: 15323
	internal static 1313 78;

	// Token: 0x04003BDC RID: 15324
	internal static 1313 79;

	// Token: 0x04003BDD RID: 15325
	internal static 1313 80;

	// Token: 0x04003BDE RID: 15326
	internal static 1313 81;

	// Token: 0x04003BDF RID: 15327
	internal static 1313 82;

	// Token: 0x04003BE0 RID: 15328
	internal static 1313 83;

	// Token: 0x04003BE1 RID: 15329
	internal static 1313 84;

	// Token: 0x04003BE2 RID: 15330
	internal static 1313 85;

	// Token: 0x04003BE3 RID: 15331
	internal static 1313 86;

	// Token: 0x04003BE4 RID: 15332
	internal static 1313 87;

	// Token: 0x04003BE5 RID: 15333
	internal static 1313 88;

	// Token: 0x04003BE6 RID: 15334
	internal static 1313 89;

	// Token: 0x04003BE7 RID: 15335
	internal static 1313 90;

	// Token: 0x04003BE8 RID: 15336
	internal static 1313 91;

	// Token: 0x04003BE9 RID: 15337
	internal static 1313 92;

	// Token: 0x04003BEA RID: 15338
	internal static 1313 93;

	// Token: 0x04003BEB RID: 15339
	internal static 1313 94;

	// Token: 0x04003BEC RID: 15340
	internal static 1313 95;

	// Token: 0x04003BED RID: 15341
	internal static 1313 96;

	// Token: 0x04003BEE RID: 15342
	internal static 1313 97;

	// Token: 0x04003BEF RID: 15343
	internal static 1313 98;

	// Token: 0x04003BF0 RID: 15344
	internal static 1313 99;

	// Token: 0x04003BF1 RID: 15345
	internal static 1313 100;

	// Token: 0x04003BF2 RID: 15346
	internal static 1313 101;

	// Token: 0x04003BF3 RID: 15347
	internal static 1313 102;

	// Token: 0x04003BF4 RID: 15348
	internal static 1313 103;

	// Token: 0x04003BF5 RID: 15349
	internal static 1313 104;

	// Token: 0x04003BF6 RID: 15350
	internal static 1313 105;

	// Token: 0x04003BF7 RID: 15351
	internal static 1313 106;

	// Token: 0x04003BF8 RID: 15352
	internal static 1313 107;

	// Token: 0x04003BF9 RID: 15353
	internal static 1313 108;

	// Token: 0x04003BFA RID: 15354
	internal static 1313 109;

	// Token: 0x04003BFB RID: 15355
	internal static 1313 110;

	// Token: 0x04003BFC RID: 15356
	internal static 1313 111;

	// Token: 0x04003BFD RID: 15357
	internal static 1313 112;

	// Token: 0x04003BFE RID: 15358
	internal static 1313 113;

	// Token: 0x04003BFF RID: 15359
	internal static 1313 114;

	// Token: 0x04003C00 RID: 15360
	internal static 1313 115;

	// Token: 0x04003C01 RID: 15361
	internal static 1313 116;

	// Token: 0x04003C02 RID: 15362
	internal static 1313 117;

	// Token: 0x04003C03 RID: 15363
	internal static 1313 118;

	// Token: 0x04003C04 RID: 15364
	internal static 1313 119;

	// Token: 0x04003C05 RID: 15365
	internal static 1313 120;

	// Token: 0x04003C06 RID: 15366
	internal static 1313 121;

	// Token: 0x04003C07 RID: 15367
	internal static 1313 122;

	// Token: 0x04003C08 RID: 15368
	internal static 1313 123;

	// Token: 0x04003C09 RID: 15369
	internal static 1313 124;

	// Token: 0x04003C0A RID: 15370
	internal static 1313 125;

	// Token: 0x04003C0B RID: 15371
	internal static 1313 126;

	// Token: 0x04003C0C RID: 15372
	internal static 1313 127;

	// Token: 0x04003C0D RID: 15373
	internal static 1313 128;

	// Token: 0x04003C0E RID: 15374
	internal static 1320<1312> 129;

	// Token: 0x04003C0F RID: 15375
	internal static 1313 130;

	// Token: 0x04003C10 RID: 15376
	internal static 1313 131;

	// Token: 0x04003C11 RID: 15377
	internal static 1319 132;

	// Token: 0x04003C12 RID: 15378
	internal static 1313 133;

	// Token: 0x04003C13 RID: 15379
	internal static 1313 134;

	// Token: 0x04003C14 RID: 15380
	internal static 1313 135;

	// Token: 0x04003C15 RID: 15381
	internal static 1313 136;

	// Token: 0x04003C16 RID: 15382
	internal static 1319 137;

	// Token: 0x04003C17 RID: 15383
	internal static 1319 138;

	// Token: 0x04003C18 RID: 15384
	internal static 1319 139;

	// Token: 0x04003C19 RID: 15385
	internal static 1318 140;

	// Token: 0x04003C1A RID: 15386
	internal static 1318 141;

	// Token: 0x04003C1B RID: 15387
	internal static 1313 142;

	// Token: 0x04003C1C RID: 15388
	internal static 1313 143;

	// Token: 0x04003C1D RID: 15389
	internal static 1318 144;

	// Token: 0x04003C1E RID: 15390
	internal static 1318 145;

	// Token: 0x04003C1F RID: 15391
	internal static 1318 146;

	// Token: 0x04003C20 RID: 15392
	internal static 1318 147;

	// Token: 0x04003C21 RID: 15393
	internal static 1318 148;

	// Token: 0x04003C22 RID: 15394
	internal static 1318 149;

	// Token: 0x04003C23 RID: 15395
	internal static 1318 150;

	// Token: 0x04003C24 RID: 15396
	internal static 1313 151;

	// Token: 0x04003C25 RID: 15397
	internal static 1313 152;

	// Token: 0x04003C26 RID: 15398
	internal static 1318 153;

	// Token: 0x04003C27 RID: 15399
	internal static 1318 154;

	// Token: 0x04003C28 RID: 15400
	internal static 1318 155;

	// Token: 0x04003C29 RID: 15401
	internal static 1313 156;

	// Token: 0x04003C2A RID: 15402
	internal static 1318 157;

	// Token: 0x04003C2B RID: 15403
	internal static 1318 158;

	// Token: 0x04003C2C RID: 15404
	internal static 1320<1207> 159;

	// Token: 0x04003C2D RID: 15405
	internal static 1318 160;

	// Token: 0x04003C2E RID: 15406
	internal static 1318 161;

	// Token: 0x04003C2F RID: 15407
	internal static 1318 162;

	// Token: 0x04003C30 RID: 15408
	internal static 1318 163;

	// Token: 0x04003C31 RID: 15409
	internal static 1320<1289> 164;

	// Token: 0x04003C32 RID: 15410
	internal static 1320<1311> 165;

	// Token: 0x04003C33 RID: 15411
	internal static 1320<2151> 166;

	// Token: 0x04003C34 RID: 15412
	internal static 1313 167;

	// Token: 0x04003C35 RID: 15413
	internal static 1313 168;

	// Token: 0x04003C36 RID: 15414
	internal static 1313 169;

	// Token: 0x04003C37 RID: 15415
	internal static 1313 170;

	// Token: 0x04003C38 RID: 15416
	internal static 1313 171;

	// Token: 0x04003C39 RID: 15417
	internal static 1313 172;

	// Token: 0x04003C3A RID: 15418
	internal static 1313 173;

	// Token: 0x04003C3B RID: 15419
	internal static 1313 174;

	// Token: 0x04003C3C RID: 15420
	internal static 1313 175;

	// Token: 0x04003C3D RID: 15421
	internal static 1320<string> 176;

	// Token: 0x04003C3E RID: 15422
	internal static 1320<string> 177;

	// Token: 0x04003C3F RID: 15423
	internal static 1320<string> 178;

	// Token: 0x04003C40 RID: 15424
	internal static 1320<string> 179;

	// Token: 0x04003C41 RID: 15425
	internal static 1313 180;

	// Token: 0x04003C42 RID: 15426
	internal static 1313 181;

	// Token: 0x04003C43 RID: 15427
	internal static 1320<string> 182;

	// Token: 0x04003C44 RID: 15428
	internal static 1320<string> 183;

	// Token: 0x04003C45 RID: 15429
	internal static 1320<string> 184;

	// Token: 0x04003C46 RID: 15430
	internal static 1320<string> 185;

	// Token: 0x04003C47 RID: 15431
	internal static 1644 186;

	// Token: 0x04003C48 RID: 15432
	internal static 1320<string> 187;

	// Token: 0x04003C49 RID: 15433
	internal static string 188;

	// Token: 0x04003C4A RID: 15434
	internal static 1320<string> 189;

	// Token: 0x04003C4B RID: 15435
	internal static 1320<string> 190;

	// Token: 0x04003C4C RID: 15436
	internal static 1313 191;

	// Token: 0x04003C4D RID: 15437
	internal static 1320<1302> 192;

	// Token: 0x04003C4E RID: 15438
	internal static 1320<2591> 193;

	// Token: 0x04003C4F RID: 15439
	internal static 1320<2620> 194;

	// Token: 0x04003C50 RID: 15440
	internal static 1319 195;

	// Token: 0x04003C51 RID: 15441
	internal static 1313 196;

	// Token: 0x04003C52 RID: 15442
	internal static 1313 197;

	// Token: 0x04003C53 RID: 15443
	public static 1320<2667> 198;

	// Token: 0x04003C54 RID: 15444
	public static 1313 199;

	// Token: 0x04003C55 RID: 15445
	public static 1313 200;

	// Token: 0x04003C56 RID: 15446
	internal static 1318 201;

	// Token: 0x04003C57 RID: 15447
	public static 1313 202;

	// Token: 0x04003C58 RID: 15448
	internal static 1320<1303> 203;

	// Token: 0x04003C59 RID: 15449
	internal static 1320<1309> 204;

	// Token: 0x04003C5A RID: 15450
	internal static 1313 205;

	// Token: 0x04003C5B RID: 15451
	internal static 1319 206;

	// Token: 0x04003C5C RID: 15452
	internal static 1319 207;

	// Token: 0x04003C5D RID: 15453
	internal static 1313 208;

	// Token: 0x04003C5E RID: 15454
	internal static 1318 209;

	// Token: 0x04003C5F RID: 15455
	internal static 1318 210;

	// Token: 0x04003C60 RID: 15456
	internal static 1313 211;

	// Token: 0x04003C61 RID: 15457
	internal static 1320<string> 212;

	// Token: 0x04003C62 RID: 15458
	internal static 1313 213;

	// Token: 0x04003C63 RID: 15459
	internal static 1313 214;

	// Token: 0x04003C64 RID: 15460
	internal static 1313 215;

	// Token: 0x04003C65 RID: 15461
	internal static 1313 216;

	// Token: 0x04003C66 RID: 15462
	internal static 1313 217;

	// Token: 0x04003C67 RID: 15463
	internal static 1313 218;

	// Token: 0x04003C68 RID: 15464
	internal static 1313 219;

	// Token: 0x04003C69 RID: 15465
	internal static 1313 220;

	// Token: 0x04003C6A RID: 15466
	internal static 1313 221;

	// Token: 0x04003C6B RID: 15467
	internal static 1313 222;

	// Token: 0x04003C6C RID: 15468
	internal static 1313 223;

	// Token: 0x04003C6D RID: 15469
	internal static 1313 224;

	// Token: 0x04003C6E RID: 15470
	internal static 1313 225;

	// Token: 0x04003C6F RID: 15471
	internal static 1313 226;

	// Token: 0x04003C70 RID: 15472
	internal static 1313 227;

	// Token: 0x04003C71 RID: 15473
	internal static List<object> 228 = new List<object>();

	// Token: 0x04003C72 RID: 15474
	private static bool 229;

	// Token: 0x02000B46 RID: 2886
	[Serializable]
	public sealed class 1306
	{
		// Token: 0x06004FA1 RID: 20385 RVA: 0x001F8358 File Offset: 0x001F6558
		internal void 1(object 1, EventArgs 2)
		{
			foreach (2039 3 in 2039.12)
			{
				3.24(true, false);
			}
		}

		// Token: 0x06004FA2 RID: 20386 RVA: 0x00005ADD File Offset: 0x00003CDD
		internal void 2(object 1, EventArgs 2)
		{
		}

		// Token: 0x06004FA3 RID: 20387 RVA: 0x001F83AC File Offset: 0x001F65AC
		internal void 3(object 1, EventArgs 2)
		{
			if (1304.206.GetValue() > 1304.207.GetValue())
			{
				1304.207.SetValue(1304.206.GetValue());
			}
		}

		// Token: 0x06004FA4 RID: 20388 RVA: 0x001F83D8 File Offset: 0x001F65D8
		internal void 4(object 1, EventArgs 2)
		{
			if (!1226.16(1304.179.GetValue(), false))
			{
				1304.179.SetValue(1226.62);
			}
		}

		// Token: 0x06004FA5 RID: 20389 RVA: 0x001F83FB File Offset: 0x001F65FB
		internal void 5(object 1, EventArgs 2)
		{
			1336.10(true);
			1662.123 = 2665.NoUpdate;
			if (1662.33 > 0)
			{
				1662.95(false, true);
			}
		}

		// Token: 0x06004FA6 RID: 20390 RVA: 0x001F8418 File Offset: 0x001F6618
		internal void 6(object 1, EventArgs 2)
		{
			if (!1304.116.1())
			{
				1304.131.2(false);
			}
		}

		// Token: 0x06004FA7 RID: 20391 RVA: 0x001F8431 File Offset: 0x001F6631
		internal void 7(object 1, EventArgs 2)
		{
			1535.29();
		}

		// Token: 0x06004FA8 RID: 20392 RVA: 0x001F8438 File Offset: 0x001F6638
		internal void 8(object 1, EventArgs 2)
		{
			if (1304.151.1())
			{
				1272.3.ForEach(new Action<1262>(1304.1306.Instance.9));
			}
		}

		// Token: 0x06004FA9 RID: 20393 RVA: 0x001F8460 File Offset: 0x001F6660
		internal void 9(1262 1)
		{
			1.92 = 0;
		}

		// Token: 0x06004FAA RID: 20394 RVA: 0x001F8460 File Offset: 0x001F6660
		internal void 10(1262 1)
		{
			1.92 = 0;
		}

		// Token: 0x06004FAB RID: 20395 RVA: 0x00005ADD File Offset: 0x00003CDD
		internal void 11(object 1, EventArgs 2)
		{
		}

		// Token: 0x06004FAC RID: 20396 RVA: 0x001F8469 File Offset: 0x001F6669
		internal void 12(object 1, EventArgs 2)
		{
			if (1304.2)
			{
				1763.2(1568.1(2679.Options_Online_BlockNonFriendPM_Toggle_On), 5000, (1389)0);
				return;
			}
			1763.2(1568.1(2679.Options_Online_BlockNonFriendPM_Toggle_Off), 5000, (1389)0);
		}

		// Token: 0x06004FAD RID: 20397 RVA: 0x001F849C File Offset: 0x001F669C
		internal void 13(object 1, EventArgs 2)
		{
			1304.1307 3 = new 1304.1307();
			3.1 = (1662.104 != null && 1662.104.15());
			if (1662.104 != null)
			{
				1662.104.16(false);
			}
			1662.71(new 1189(3.1));
			if (1662.33 > 0)
			{
				1568.2(1304.4.GetValue(), 1304.184 != 1296.1(), new 1189(1304.1306.Instance.14), 277.GetEnglishLocalisation());
			}
		}

		// Token: 0x06004FAE RID: 20398 RVA: 0x001F852B File Offset: 0x001F672B
		internal void 14()
		{
			1662.89.Schedule(delegate()
			{
				1662.SetMode(1662.78, true);
				1304.4.SetValue(1568.3);
			}, false);
		}

		// Token: 0x06004FAF RID: 20399 RVA: 0x001F8558 File Offset: 0x001F6758
		internal void 15(object 1, EventArgs 2)
		{
			if (!1304.191)
			{
				if (1662.55())
				{
					1304.139.SetValue(1.0);
					return;
				}
			}
			else if ((1558)1535.27(typeof(1558)) == null)
			{
				1558 3 = new 1558();
				3.SetPosition(1555.21());
				if (!1535.28(3))
				{
					1763.2(1568.1(2679.Options_Input_RawInputFailed), 5000, (1389)0);
					1304.191.2(false);
				}
			}
		}

		// Token: 0x06004FB0 RID: 20400 RVA: 0x001F85D9 File Offset: 0x001F67D9
		internal void 16(object 1, EventArgs 2)
		{
			1535.34();
		}

		// Token: 0x06004FB1 RID: 20401 RVA: 0x001F85E4 File Offset: 0x001F67E4
		internal void 17(object 1, EventArgs 2)
		{
			if ((1377.7() && 1304.214 && 1304.167.1() && !1377.5()) || (!1304.167.1() && 1377.3()))
			{
				1662.94(null);
				return;
			}
			if (1662.33 > 0)
			{
				if (1304.208.1() != 1304.167.1())
				{
					1304.208.2(1304.167.1());
					return;
				}
				1662.37(null, null, true, false);
			}
		}

		// Token: 0x06004FB2 RID: 20402 RVA: 0x001F8680 File Offset: 0x001F6880
		internal void 18(object 1, EventArgs 2)
		{
			if (1304.167.1() && !1304.208.1())
			{
				1304.158.7(1662.113.Width);
				1304.149.7(1662.113.Height);
			}
			1662.37(null, null, true, false);
		}

		// Token: 0x06004FB3 RID: 20403 RVA: 0x001F86E8 File Offset: 0x001F68E8
		internal void 19(object 1, EventArgs 2)
		{
			if (1662.33 > 0)
			{
				1662.35 = true;
				string str = string.Empty;
				switch (1304.203.GetValue())
				{
				case 1303.Limit120:
					str = string.Format("Optimal ({0}fps)", 1662.33());
					break;
				case 1303.VSync:
					str = 1568.1(2679.Options_Graphics_FrameLimiter_VSync);
					break;
				case 1303.Unlimited:
					str = 1568.1(2679.Options_Graphics_FrameLimiter_UnlimGreen);
					break;
				case 1303.PowerSaving:
					str = string.Format("Power Saving ({0}fps)", 1662.33());
					break;
				case 1303.Custom:
				{
					1318 3 = 1304.140;
					str = ((3 != null) ? 3.ToString() : null) + "fps";
					break;
				}
				}
				1763.2(1568.1(2679.Options_Graphics_FrameLimiter) + " " + str, 1000, (1389)0);
			}
			if (1662.11 != null)
			{
				1662.11.1().Flag1276 = (1304.203 == 1303.VSync);
			}
		}

		// Token: 0x06004FB4 RID: 20404 RVA: 0x001F87D8 File Offset: 0x001F69D8
		internal void 20(object 1, EventArgs 2)
		{
			if (!1425.1())
			{
				1763.4("No shader support - disabling shader effects.");
				if (1304.65)
				{
					1304.65.2(false);
				}
			}
			if (!1304.65)
			{
				1304.66.2(false);
			}
		}

		// Token: 0x06004FB5 RID: 20405 RVA: 0x001F8824 File Offset: 0x001F6A24
		internal void 21(object 1, EventArgs 2)
		{
			if (1304.66)
			{
				if (!1304.65)
				{
					1304.65.2(true);
				}
				if (!1304.65)
				{
					1304.66.2(false);
				}
			}
		}

		// Token: 0x06004FB6 RID: 20406 RVA: 0x00005ADD File Offset: 0x00003CDD
		internal void 22(object 1, EventArgs 2)
		{
		}

		// Token: 0x06004FB7 RID: 20407 RVA: 0x00005ADD File Offset: 0x00003CDD
		internal void 23(object 1, EventArgs 2)
		{
		}

		// Token: 0x04003C73 RID: 15475
		public static readonly 1304.1306 Instance = new 1304.1306();
	}

	// Token: 0x02000B48 RID: 2888
	public sealed class 1307
	{
		// Token: 0x06004FBD RID: 20413 RVA: 0x001F8894 File Offset: 0x001F6A94
		internal void 1()
		{
			if (1662.104 != null)
			{
				1662.104.10(true);
				1662.104.16(this.1);
			}
		}

		// Token: 0x04003C76 RID: 15478
		public bool 1;
	}

	// Token: 0x02000B49 RID: 2889
	public sealed class 1305
	{
	}

	// Token: 0x02000B4A RID: 2890
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04003C77 RID: 15479
		public static EventHandler <0>__RefreshClientBounds;
	}
}
