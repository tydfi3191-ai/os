using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

// Token: 0x020008B9 RID: 2233
public sealed class 1784 : 1474
{
	// Token: 0x06003FF4 RID: 16372 RVA: 0x0018BA24 File Offset: 0x00189C24
	private void 1()
	{
		1784.1785 state = new 1784.1785();
		state.1 = this;
		this.32.SetText(1568.1(2679.Options_Options));
		this.33.SetText(1568.1(2679.Options_HeaderBlurb));
		this.30.26(1568.1(2679.SongSelection_TypeToBegin));
		1782 <<EMPTY_NAME>>;
		if (this.20)
		{
			<<EMPTY_NAME>> = new 1782(2679.Options_General, 1048.gear);
			<<EMPTY_NAME>>.SetChildren(new 1781[]
			{
				this.50()
			});
			this.21(<<EMPTY_NAME>>);
			this.30.SetEnabled(false);
			if (this.35 != null)
			{
				this.35.20();
			}
			return;
		}
		this.30.SetEnabled(true);
		<<EMPTY_NAME>> = new 1782(2679.Options_General, 1048.gear);
		1782 39 = <<EMPTY_NAME>>;
		1779[] array = new 1779[2];
		array[0] = this.50();
		1779[] array2 = array;
		1781 3 = new 1781(2679.Options_Graphics_Language, null);
		3.9(true);
		3.SetChildren(new 1779[]
		{
			new 1773<string>(2679.Options_Graphics_SelectLanguage, new 1772[]
			{
				new 1772("English", "en"),
				new 1772("中文(简体)", "zh-CHS"),
				new 1772("中文(繁體)", "zh-CHT"),
				new 1772("日本語", "ja"),
				new 1772("한국어", "ko"),
				new 1772("Česky", "cs"),
				new 1772("Dansk", "da"),
				new 1772("Deutsch", "de"),
				new 1772("Esperanto", "eo"),
				new 1772("Español", "es"),
				new 1772("Français", "fr"),
				new 1772("Български", "bg"),
				new 1772("Ελληνικά", "el"),
				new 1772("Suomi", "fi"),
				new 1772("עברית", "he"),
				new 1772("Hrvatski", "hr"),
				new 1772("Bahasa Indonesia", "id"),
				new 1772("Italiano", "it"),
				new 1772("Magyar", "hu"),
				new 1772("Mongɣol kele", "mn"),
				new 1772("Bahasa Malaysia", "ms-MY"),
				new 1772("Nederlands", "nl"),
				new 1772("Norsk", "no"),
				new 1772("latviešu valoda", "lv"),
				new 1772("Polski", "pl"),
				new 1772("Português (Brasil)", "br"),
				new 1772("Português (Portugal)", "pt"),
				new 1772("Română (Romanian)", "ro"),
				new 1772("Русский", "ru"),
				new 1772("Slovenčina", "sk"),
				new 1772("Slovenščina", "sl"),
				new 1772("Svenska", "sv"),
				new 1772("ภาษาไทย", "th"),
				new 1772("Türkçe", "tr"),
				new 1772("Tiếng Việt", "vi-VN"),
				new 1772("Українська", "uk-UA")
			}, 1304.4, null)
			{
				15 = true
			},
			new 1771(2679.Option_Graphics_ShowUnicode, 1304.119, null),
			new 1771(2679.Options_Language_Font_Override, 1304.197, null)
		});
		array2[1] = 3;
		39.SetChildren(array2);
		this.21(<<EMPTY_NAME>>);
		1793 4 = new 1793(2679.Options_Graphics_LetterboxPositionX, 1304.209, "%", false, 0f)
		{
			12 = !1304.208.1()
		};
		1793 5 = new 1793(2679.Options_Graphics_LetterboxPositionY, 1304.210, "%", false, 0f)
		{
			12 = !1304.208.1()
		};
		string[] collection = new string[]
		{
			"letterboxing",
			"offset"
		};
		4.7.AddRange(collection);
		5.7.AddRange(collection);
		state.2 = new 1779[]
		{
			4,
			5
		};
		2679 6 = 2679.Options_CompatibilityModeWarning;
		if (1377.3())
		{
			6 = ((!1377.7()) ? 2679.Options_CompatibilityModeForcedWarning : 2679.Options_CompatibilityModeForcedOptimusWarning);
		}
		<<EMPTY_NAME>> = new 1782(2679.Options_TabGraphics, 1048.desktop);
		1782 7 = <<EMPTY_NAME>>;
		1781[] array3 = new 1781[5];
		3 = new 1781(2679.Options_Graphics_Renderer, null);
		1779 8 = 3;
		1779[] array4 = new 1779[8];
		1773<1303> 9 = new 1773<1303>(2679.Options_Graphics_FrameLimiter, 1784.13(), 1304.203, null);
		9.9(true);
		array4[0] = 9;
		1774 10 = new 1774("Using unlimited frame limiter can lead to stutters. \"Optimal\" is recommended.", null);
		10.18(new 198(byte.MaxValue, 198, 23));
		10.12 = !this.14();
		1774 11 = 10;
		this.42 = 10;
		array4[1] = 11;
		1773<1309> 12 = new 1773<1309>("Frame rate outside gameplay", 1784.12(), 1304.204, null);
		12.9(true);
		array4[2] = 12;
		array4[3] = new 1771(2679.Options_Graphics_FpsCounter, 1304.89, null);
		1771 13 = new 1771(2679.Options_CompatibilityMode, 1304.213, new EventHandler(1784.1788.instance.3));
		13.21(!1377.3() || (1377.3() && 1377.7()));
		1771 14 = 13;
		this.43 = 13;
		array4[4] = 14;
		1774 15 = new 1774(1568.1(6), null);
		15.18(new 198(byte.MaxValue, 198, 23));
		15.12 = !1377.5();
		array4[5] = 15;
		array4[6] = new 1771(2679.Options_ReduceDroppedFrames, 1304.175, null);
		array4[7] = new 1771(2679.Options_DetectPerformanceIssues, 1304.174, null);
		8.SetChildren(array4);
		array3[0] = 3;
		3 = new 1781(2679.Options_Graphics_ScreenResolution, null);
		3.9(true);
		1781 16 = 3;
		1779[] array5 = new 1779[8];
		array5[0] = (this.28 = new 1773<string>(2679.Options_Graphics_SelectResolution, null, null, delegate(object 1, EventArgs 2)
		{
			string text = 1 as string;
			if (text == null || text == 1568.1(2679.Options_Graphics_CustomResolution))
			{
				1784.35(this.28.13);
				return;
			}
			string[] array22 = text.Split(new char[]
			{
				'x'
			});
			int value = int.Parse(array22[0]);
			int value2 = int.Parse(array22[1]);
			1662.37(new int?(value), new int?(value2), true, false);
		}));
		array5[1] = (this.29 = new 1771(2679.Options_Graphics_Fullscreen, 1304.167, null));
		1779[] array6 = array5;
		1774 17 = new 1774(1568.1(2679.Options_FullscreenLatencyWarning), null);
		17.18(new 198(byte.MaxValue, 198, 23));
		17.12 = !this.28();
		11 = 17;
		this.41 = 17;
		array6[2] = 11;
		array6[3] = new 1771("Minimise on alt-tab during fullscreen", string.Empty, 1304.215, null);
		array6[4] = new 1771("Draw the mouse cursor in fullscreen replays", "For when Windows shows no cursor over fullscreen osu!.", 1304.216, null);
		array6[5] = new 1771("Render at native resolution", 1568.1(2679.Options_Graphics_Letterboxing_Tooltip), 1304.208, delegate(object 1, EventArgs 2)
		{
			state.1.18(state.2, !1304.208.1());
		});
		array6[6] = 4;
		array6[7] = 5;
		16.SetChildren(array6);
		array3[1] = 3;
		3 = new 1781(2679.Options_Graphics_Detail, null);
		1781 18 = 3;
		1779[] array7 = new 1779[10];
		array7[0] = new 1771(2679.Options_Graphics_Snaking, 1304.122, null);
		array7[1] = new 1771("Snaking out sliders", "Slider bodies shrink behind the ball.", 1304.123, null);
		array7[2] = new 1771("High quality sliders", "Snaking sliders grow smoothly at any frame rate instead of 60 times a second. Uses more of the graphics card.", 1304.124, null);
		array7[3] = new 1771(2679.Options_Graphics_Video, 1304.134, null);
		array7[4] = new 1771(2679.Options_Graphics_Storyboards, 1304.117, null);
		array7[5] = new 1771(2679.Options_Graphics_Combo, 1304.74, null);
		array7[6] = new 1771(2679.Options_Graphics_HitLighting, 1304.91, null);
		1779[] array8 = array7;
		1771 19 = new 1771(2679.Options_Graphics_Shader, 1304.65, null);
		19.21(1425.1());
		array8[7] = 19;
		1771 20 = new 1771(2679.Options_Graphics_Softening, 1304.66, null);
		20.21(1425.1());
		array8[8] = 20;
		array8[9] = new 1773<1207>(2679.Options_Graphics_Screenshot, new 1772[]
		{
			new 1772(1568.1(2679.Options_Graphics_Screenshot1), 1207.Png),
			new 1772(1568.1(2679.Options_Graphics_Screenshot2), 1207.Jpg)
		}, 1304.159, null);
		18.SetChildren(array8);
		array3[2] = 3;
		3 = new 1781(2679.Options_Graphics_Menu, null);
		1779 21 = 3;
		1779[] array9 = new 1779[6];
		array9[0] = new 1771(2679.Options_Menu_Snow, 1304.170, null);
		array9[1] = new 1771(2679.Options_Menu_Parallax, 1304.118, null);
		array9[2] = new 1771(2679.Options_Menu_ShowTips, 1304.196, null);
		array9[3] = new 1771(2679.Options_Menu_Voice, 1304.200, null);
		array9[4] = new 1771(2679.Options_Menu_Music, 1304.199, null);
		array9[5] = new 1773<1312>(2679.Options_SeasonalMenuBackgrounds, new 1772[]
		{
			new 1772(1568.1(2679.Options_Seasonal1), 1312.Sometimes),
			new 1772(1568.1(2679.Options_Seasonal2), 1312.Never),
			new 1772(1568.1(2679.Options_Seasonal3), 1312.Always)
		}, 1304.129, delegate(object 1, EventArgs 2)
		{
			1662.55.5();
		});
		21.SetChildren(array9);
		array3[3] = 3;
		3 = new 1781(2679.Options_SongSelect, null);
		3.SetChildren(new 1779[]
		{
			new 1771(2679.Options_SongSelect_Thumbnails, 1304.172, null)
		});
		array3[4] = 3;
		7.SetChildren(array3);
		this.21(<<EMPTY_NAME>>);
		if (1377.5())
		{
			this.43.15.7(true);
		}
		1784.35(this.28.13);
		<<EMPTY_NAME>> = new 1782(2679.Options_TabGameplay, 1048.circle_o);
		1782 22 = <<EMPTY_NAME>>;
		1781[] array10 = new 1781[2];
		3 = new 1781(2679.Options_General, null);
		3.SetChildren(new 1779[]
		{
			new 1793(2679.FunSpoiler_BackgroundDim, 1304.141, "%", true, 0f),
			new 1771(2679.Options_HateFun, 1304.142, null),
			new 1771("Show leaderboard during gameplay", "Affects both solo and multiplayer.", 1304.114, null),
			new 1773<1409>(2679.Options_Graphics_Progress, new 1772[]
			{
				new 1772(1568.1(2679.Options_Graphics_Progress1), 1409.Pie),
				new 1772(1568.1(2679.Options_Graphics_Progress2), 1409.TopRight),
				new 1772(1568.1(2679.Options_Graphics_Progress3), 1409.BottomRight),
				new 1772(1568.1(2679.Options_Graphics_Progress4), 1409.Bottom)
			}, 1304.3, null),
			new 1773<2151>(2679.Options_TabSkin_ScoreMeter, new 1772[]
			{
				new 1772(1568.1(2679.Options_Graphics_Meter0), 2151.None),
				new 1772(1568.1(2679.General_Colour), 2151.Colour),
				new 1772(1568.1(2679.Options_Graphics_Meter2), 2151.Error)
			}, 1304.166, null),
			new 1793(2679.Options_ScoreMeterScale, 1304.195, "x", true, 0f),
			new 1771(2679.Options_KeyOverlay, 1304.95, null),
			new 1771(2679.Options_Gameplay_Hidden_Approach, 1304.202, null),
			new 1771("Hide approach circles", "Circles and spinners show no approach circle.", 1304.64, null),
			new 1771(2679.Options_ScaleManiaSpeedWithBPM, 1304.152, null),
			new 1771(2679.Options_UsePerBeatmapManiaSpeed, 1304.151, null),
			new 1771("Disable kiai effects", "No star fountain, flashes or circles pulsing on the beat during kiai time.", 1304.54, null),
			new 1771("Ignore beatmap countdown", "Leave out the \"3, 2, 1, Go!\" before the first note.", 1304.55, null),
			new 1771("Skippable breaks", "Show the skip button in breaks. The Skip key skips them too.", 1304.56, null),
			new 1771("Change offset and scroll speed any time", "The local offset keys (+/-) and mania's scroll speed keys work during the whole play, not only near its start and in breaks.", 1304.57, null)
		});
		array10[0] = 3;
		3 = new 1781(2679.Options_SongSelect, new string[]
		{
			"difficulty"
		});
		3.SetChildren(new 1779[]
		{
			new 1793(2679.Options_Gameplay_MinimumStars, 1304.206, " " + 1568.1(2679.Options_Gameplay_Stars), false, 0f),
			state.3 = new 1793(2679.Options_Gameplay_MaximumStars, 1304.207, null, false, 0f),
			new 1771("Music follows speed mods", "In song select, play the music at the speed (and pitch) of Double Time, Nightcore, Half Time or a custom rate.", 1304.10, null)
		});
		array10[1] = (this.45 = 3);
		22.SetChildren(array10);
		this.21(<<EMPTY_NAME>>);
		if (state.3 != null)
		{
			1429 23 = state.3.13;
			23.18 = (1429.1432)Delegate.Combine(23.18, new 1429.1432(state.1));
			state.3.13.18(false);
		}
		<<EMPTY_NAME>> = new 1782(2679.Options_TabAudio, 1048.volume_off);
		1782 24 = <<EMPTY_NAME>>;
		1781[] array11 = new 1781[3];
		3 = new 1781(2679.Options_Audio_Device, null);
		3.SetChildren(new 1779[]
		{
			this.39 = new 1773<string>(2679.Options_Audio_AudioDevice, null, 1304.179, null),
			new 1771("Low latency audio", "Plays sound with less delay (WASAPI), with osu!lazer's audio engine. Applies after a restart. Your offset may need adjusting. Not used in compatibility mode.", 1304.181, null),
			new 1771("Audio compatibility mode", "Use legacy audio engine (higher latency but more compatible)", 1304.180, null)
		});
		array11[0] = 3;
		3 = new 1781(2679.Options_Audio_Volume, null);
		string[] array12 = new string[]
		{
			1568.1(2679.Options_Audio_Master),
			1568.1(2679.Options_Audio_Music),
			1568.1(2679.Options_Audio_Effect),
			"Hitsound:"
		};
		float num = 1793.18(array12);
		3.SetChildren(new 1779[]
		{
			new 1793(2679.Options_Audio_Master, 1226.39, "%", true, num),
			new 1793(2679.Options_Audio_Music, 1226.38, "%", true, num),
			new 1793(2679.Options_Audio_Effect, 1226.36, "%", true, num),
			new 1793(array12[3], 1226.37, "%", true, num),
			new 1771(2679.FunSpoiler_Hitsounds, 1304.93, null)
		});
		array11[1] = 3;
		3 = new 1781(2679.Options_Audio_Offset, null);
		3.9(true);
		1779 25 = 3;
		1779[] array13 = new 1779[2];
		array13[0] = new 1793(2679.OptionsOffsetWizard_UniversalOffset, 1304.154, "ms", true, 0f);
		array13[1] = (this.44 = new 1770(2679.Options_Audio_OffsetWizard, 2630.16, delegate(object 1, EventArgs 2)
		{
			if (1272.5() == null || 1272.5().94 == null || 1272.5().94.Count == 0)
			{
				1763.2(1568.1(2679.Options_OffsetWizard_NotTimed), 3000, (1389)0);
				return;
			}
			1662.SetMode(1677.OptionsOffsetWizard, false);
		}));
		25.SetChildren(array13);
		array11[2] = 3;
		24.SetChildren(array11);
		this.21(<<EMPTY_NAME>>);
		this.3();
		if (!this.17)
		{
			1226.15(delegate
			{
				this.39.13.13();
				this.39.13.10(1568.1(2679.General_Default), string.Empty);
				foreach (1000 40 in 1226.61)
				{
					if (40.2() && 40.2 != null)
					{
						this.39.13.10(40.4, 40.4);
					}
				}
				if (!this.39.13.18(1304.179.GetValue(), true))
				{
					this.39.13.18(string.Empty, true);
				}
			});
		}
		<<EMPTY_NAME>> = new 1782(2679.Options_TabSkin, 1048.fa_paint_brush);
		1782 26 = <<EMPTY_NAME>>;
		1781[] array14 = new 1781[1];
		3 = new 1781(2679.Options_Skin, null);
		1781 27 = 3;
		1779[] array15 = new 1779[15];
		array15[0] = new 1791();
		array15[1] = (this.40 = new 1773<string>(2679.Options_SkinSelect, null, 1304.187, new EventHandler(1784.1788.instance.4)));
		1779[] array16 = array15;
		1770 28 = new 1770(2679.Options_SkinPreview, 2630.14, new EventHandler(1784.1788.instance.6));
		28.9(true);
		array16[2] = 28;
		1770 29 = new 1770(2679.Options_OpenSkinFolder, 2630.16, new EventHandler(1784.1788.instance.8));
		29.9(true);
		array16[3] = 29;
		1770 30 = new 1770(2679.OptionsSkin_ExportAsOsk, 2630.16, new EventHandler(1784.1788.instance.9));
		30.9(true);
		array16[4] = 30;
		1770 31 = new 1770("Edit HUD layout", 2630.14, delegate(object 1, EventArgs 2)
		{
			if (!2601.77())
			{
				1763.2("Pick a beatmap in song select (Solo), then open the HUD layout editor from there.", 4000, (1389)0);
				return;
			}
			1784 40 = 1662.104;
			if (40 == null)
			{
				return;
			}
			40.16(false);
		});
		31.9(true);
		array16[5] = 31;
		array16[6] = new 1771(2679.Options_TabSkin_IgnoreBeatmapSkins, 1304.94, null);
		array16[7] = new 1771(2679.Options_UseSkinSamples, 1304.120, null);
		array16[8] = new 1771(2679.Options_UseTaikoSkin, 1304.130, null);
		array16[9] = new 1771(2679.Options_UseSkinCursor, 1304.128, null);
		array16[10] = new 1793(2679.Options_CursorSize, 1304.132, "x", true, 0f);
		array16[11] = new 1771(2679.Options_AutomaticCursorSizing, 1304.133, null);
		array16[12] = new 1771(2679.Options_ComboColourSliderBall, 1304.69, null);
		array16[13] = new 1771("Instant fade", "Hit circles disappear the moment they are hit, instead of expanding and fading out.", 1304.53, null);
		array16[14] = new 1771("Cursor trail", "The cursor leaves a trail behind it.", 1304.58, null);
		27.SetChildren(array16);
		array14[0] = (this.46 = 3);
		26.SetChildren(array14);
		this.21(<<EMPTY_NAME>>);
		this.2();
		if (!this.17)
		{
			2630.4(delegate
			{
				if (this.40 != null)
				{
					List<1772> list2 = new List<1772>();
					foreach (string text in 2630.8)
					{
						list2.Add(new 1772(text, text));
					}
					this.40.13.13();
					foreach (1772 40 in list2)
					{
						this.40.13.9(40);
					}
					if (!this.40.13.18(1304.187.GetValue(), true))
					{
						this.40.13.18("Default", true);
					}
				}
			});
		}
		<<EMPTY_NAME>> = new 1782(2679.Options_TabInput, 1048.gamepad);
		1782 32 = <<EMPTY_NAME>>;
		1781[] array17 = new 1781[3];
		3 = new 1781(2679.Options_Input_Mouse, null);
		3.SetChildren(new 1779[]
		{
			new 1793(2679.Options_Input_MouseSensitivity, 1304.139, "x", false, 0f),
			this.34 = new 1771(2679.Options_Input_RawInput, 1304.191, null),
			new 1771(2679.Options_Input_AbsoluteToOsuWindow, 1304.205, null),
			new 1773<1302>(2679.Options_Input_ConfineMouse, new 1772[]
			{
				new 1772(1568.1(2679.General_Never), 1302.Never),
				new 1772(1568.1(2679.Options_Input_ConfineMouse_Fullscreen), 1302.Fullscreen),
				new 1772(1568.1(2679.General_Always), 1302.Always)
			}, 1304.192, null),
			new 1771(2679.Options_Input_DisableWheel, 1304.105, null),
			new 1771(2679.Options_Input_DisableButtons, 1304.104, null),
			new 1771(2679.Options_Input_CursorRipples, 1304.86, null)
		});
		array17[0] = 3;
		3 = new 1781(2679.Options_Input_Keyboard, null);
		3.SetChildren(new 1779[]
		{
			new 1770(2679.Options_Input_KeyBindings, 2630.16, delegate(object 1, EventArgs 2)
			{
				1701 40 = new 1701();
				40.3(new EventHandler(state.2));
				state.1.30.SetEnabled(false);
				1662.25(40);
			}),
			new 1770(2679.Options_OsuManiaLayout, 2630.16, new EventHandler(state.3))
		});
		array17[1] = 3;
		3 = new 1781(2679.Options_Input_Other, null);
		3.SetChildren(new 1779[]
		{
			new 1771(2679.Options_Input_Tablet, 1304.125, null),
			new 1771(2679.Options_Input_Wii, 1304.135, null)
		});
		array17[2] = 3;
		32.SetChildren(array17);
		this.21(<<EMPTY_NAME>>);
		<<EMPTY_NAME>> = new 1782(2679.Options_Editor, 1048.pencil);
		1782 33 = <<EMPTY_NAME>>;
		1781[] array18 = new 1781[1];
		3 = new 1781(2679.Options_General, null);
		3.SetChildren(new 1779[]
		{
			new 1771(2679.Options_Editor_Video, 1304.79, null),
			new 1771(2679.Options_Editor_DefaultSkin, 1304.81, null),
			new 1771(2679.Options_Editor_Snaking_Sliders, 1304.82, null),
			new 1771(2679.Options_Editor_Hit_Animations, 1304.83, null),
			new 1771(2679.Options_Editor_Follow_Points, 1304.84, null),
			new 1771(2679.Options_Editor_Stacking, 1304.85, null)
		});
		array18[0] = 3;
		33.SetChildren(array18);
		this.21(<<EMPTY_NAME>>);
		<<EMPTY_NAME>> = new 1782(2679.Options_TabOnline, 1048.globe);
		1782 34 = <<EMPTY_NAME>>;
		1781[] array19 = new 1781[3];
		3 = new 1781(2679.Options_Online_Integration, null);
		1772[] 35 = (from 1 in 1632.All
		select new 1772(1.Name, 1.Name)).ToArray<1772>();
		if (261.FullyOffline)
		{
			3.SetChildren(new 1779[]
			{
				new 1774("Internet is turned off in the launcher: no osu!direct, beatmap mirror, beatmap updates, online rankings or ranks.", null)
			});
			34.SetChildren(new 1781[]
			{
				3
			});
			this.21(<<EMPTY_NAME>>);
		}
		else
		{
			3.SetChildren(new 1779[]
			{
				new 1773<string>("Beatmap mirror", 35, 1304.9, null),
				new 1771("Check for beatmap updates", "In song select, ask the beatmap mirror whether the selected difficulty has a newer version. Only the beatmap's id is sent.", 1304.11, null),
				new 1771(2679.Options_Online_AutomaticDownload, 1304.7, null),
				new 1771(2679.Options_Online_AutomaticDownloadNoVideo, 1304.8, null)
			});
			array19[0] = 3;
			array19[1] = this.5();
			array19[2] = this.6();
			34.SetChildren(array19);
			this.21(<<EMPTY_NAME>>);
		}
		List<1779> list = new List<1779>();
		foreach (object obj in 1304.228)
		{
			1313 36 = obj as 1313;
			if (36 != null)
			{
				list.Add(new 1771(36.GetConfigurationKey(), string.Empty, 36, null));
			}
		}
		<<EMPTY_NAME>> = new 1782(2679.Options_TabMaintenance, 1048.wrench);
		<<EMPTY_NAME>>.9(true);
		1782 37 = <<EMPTY_NAME>>;
		1781[] array20 = new 1781[1];
		3 = new 1781(2679.Options_General, null);
		1779 38 = 3;
		1779[] array21 = new 1779[4];
		array21[0] = new 1770(2679.Options_OpenOsuFolder, 2630.16, new EventHandler(this.OpenGameFolder));
		array21[1] = new 1770(2679.Options_DeleteAllUnrankedMaps, 2630.16, delegate(object 1, EventArgs 2)
		{
			1784.1790 40 = new 1784.1790();
			40.1 = 1272.3.FindAll(new Predicate<1262>(1784.1788.instance.10));
			1662.25(new 1688(string.Format(1568.1(2679.Options_DeleteWarning), 40.1.Count), new EventHandler(40.1), null, true));
		});
		array21[2] = new 1770(2679.Options_ForceFolderPermissions, 2630.16, new EventHandler(this.9));
		array21[3] = new 1770(2679.Options_MarkMapsPlayed, 2630.16, new EventHandler(this.8));
		38.SetChildren(array21);
		array20[0] = 3;
		37.SetChildren(array20);
		this.21(<<EMPTY_NAME>>);
		this.21(new 1796(1296.1()));
		this.4();
		if (!this.17)
		{
			1662.72(delegate
			{
				this.44.19(1662.78 == 1677.Menu);
				if (1662.78 - 1677.MatchSetup <= 1)
				{
					this.43.21(false);
				}
				else
				{
					this.43.21(!1377.3() || (1377.3() && 1377.7()));
				}
				this.19();
			});
		}
		for (int i = this.3.24.Count - 1; i >= 0; i--)
		{
			this.3.24[i].8();
		}
		this.3.22.8();
		this.4.22.8();
	}

	// Token: 0x06003FF5 RID: 16373 RVA: 0x0018D11C File Offset: 0x0018B31C
	private void 2()
	{
		if (this.40 == null)
		{
			return;
		}
		List<1772> list = new List<1772>();
		foreach (string text in 2630.8)
		{
			list.Add(new 1772(text, text));
		}
		this.40.13.13();
		foreach (1772 <<EMPTY_NAME>> in list)
		{
			this.40.13.9(<<EMPTY_NAME>>);
		}
		if (!this.40.13.18(1304.187.GetValue(), true))
		{
			this.40.13.18("Default", true);
		}
	}

	// Token: 0x06003FF6 RID: 16374 RVA: 0x0018D214 File Offset: 0x0018B414
	private void 3()
	{
		this.39.13.13();
		this.39.13.10(1568.1(2679.General_Default), string.Empty);
		foreach (1000 <<EMPTY_NAME>> in 1226.61)
		{
			if (<<EMPTY_NAME>>.2() && <<EMPTY_NAME>>.2 != null)
			{
				this.39.13.10(<<EMPTY_NAME>>.4, <<EMPTY_NAME>>.4);
			}
		}
		if (!this.39.13.18(1304.179.GetValue(), true))
		{
			this.39.13.18(string.Empty, true);
		}
	}

	// Token: 0x06003FF7 RID: 16375 RVA: 0x0018D2F0 File Offset: 0x0018B4F0
	private void 4()
	{
		this.44.19(1662.78 == 1677.Menu);
		if (1662.78 - 1677.MatchSetup <= 1)
		{
			this.43.21(false);
		}
		else
		{
			this.43.21(!1377.3() || (1377.3() && 1377.7()));
		}
		this.19();
	}

	// Token: 0x06003FF8 RID: 16376 RVA: 0x0018D354 File Offset: 0x0018B554
	private 1781 5()
	{
		1781 <<EMPTY_NAME>> = new 1781("Online rankings (osu! API)", new string[]
		{
			"leaderboard",
			"ranking",
			"scores",
			"oauth",
			"client",
			"api"
		});
		1794 clientIdInput = new 1794("Client ID", false);
		1794 clientSecretInput = new 1794("Client secret", true);
		clientIdInput.13.SetText(1631.ClientId);
		1774 statusLabel = new 1774(1631.HasKey ? "Connected. Leave the secret empty to keep the stored one." : "Not set up.", null);
		1771 6 = new 1771("Use the osu! API", "Online rankings and Import Bancho data. Off keeps the key.", 1304.50, null);
		1770 3 = new 1770("Disconnect", 198.OrangeRed, delegate(object 1, EventArgs 2)
		{
			1631.6(string.Empty, string.Empty, delegate(bool 1, string 2)
			{
				clientIdInput.13.SetText(string.Empty);
				clientSecretInput.13.SetText(string.Empty);
				statusLabel.20("Not set up.");
			});
		});
		1770 4 = new 1770("Save and test", 2630.16, delegate(object 1, EventArgs 2)
		{
			statusLabel.20("Testing...");
			1631.6(clientIdInput.13.GetText(), clientSecretInput.13.GetText(), delegate(bool 1, string 2)
			{
				statusLabel.20(2);
				1763.5(2, 1 ? 198.YellowGreen : 198.OrangeRed, 5000, null);
				if (1)
				{
					clientSecretInput.13.SetText(string.Empty);
				}
			});
		});
		1779 5 = <<EMPTY_NAME>>;
		1779[] array = new 1779[7];
		array[0] = new 1774("Shows global leaderboards (and mod rankings). Input your Client ID and Secret from the osu! website. Click here to see how to set it up.", delegate()
		{
			1784.7("osu-api");
		});
		array[1] = 6;
		array[2] = clientIdInput;
		array[3] = clientSecretInput;
		array[4] = 4;
		array[5] = 3;
		array[6] = statusLabel;
		5.SetChildren(array);
		return <<EMPTY_NAME>>;
	}

	// Token: 0x06003FF9 RID: 16377 RVA: 0x0018D4B4 File Offset: 0x0018B6B4
	private 1781 6()
	{
		1781 <<EMPTY_NAME>> = new 1781("Discord bot", new string[]
		{
			"discord",
			"bot",
			"bathbot",
			"rs",
			"recent"
		});
		1794 tokenInput = new 1794("Bot token", true);
		1774 statusLabel = new 1774(1584.Status, null);
		1584.StatusChanged += delegate()
		{
			statusLabel.20(1584.Status);
		};
		1770 6 = new 1770("Save and connect", 2630.16, delegate(object 1, EventArgs 2)
		{
			statusLabel.20("Checking...");
			1584.2(tokenInput.13.GetText(), delegate(bool 1, string 2)
			{
				statusLabel.20(2);
				1763.5(2, 1 ? 198.YellowGreen : 198.OrangeRed, 5000, null);
				if (1)
				{
					tokenInput.13.SetText(string.Empty);
				}
			});
		});
		1770 3 = new 1770("Open the link to add it to your account", 2630.16, delegate(object 1, EventArgs 2)
		{
			string applicationId = 1584.ApplicationId;
			if (applicationId == null)
			{
				1763.5("Connect the bot first.", 198.OrangeRed, 4000, null);
				return;
			}
			if (!261.26(applicationId))
			{
				1763.5("Couldn't open the browser.", 198.OrangeRed, 4000, null);
			}
		});
		1770 4 = new 1770("Remove", 198.OrangeRed, delegate(object 1, EventArgs 2)
		{
			1584.2(string.Empty, delegate(bool 1, string 2)
			{
				statusLabel.20(2);
			});
		});
		1779 5 = <<EMPTY_NAME>>;
		1779[] array = new 1779[7];
		array[0] = new 1774("Your own Discord bot: show off your plays on Discord with commands such as /rs, /top, and more! Click here to see how to set it up.", delegate()
		{
			1784.7("discord-bot");
		});
		array[1] = new 1771("Run the Discord bot", string.Empty, 1304.51, null);
		array[2] = tokenInput;
		array[3] = 6;
		array[4] = 3;
		array[5] = 4;
		array[6] = statusLabel;
		5.SetChildren(array);
		return <<EMPTY_NAME>>;
	}

	// Token: 0x06003FFA RID: 16378 RVA: 0x0018D60B File Offset: 0x0018B80B
	private static void 7(string 1)
	{
		if (!261.25(1))
		{
			1763.5("Couldn't open the browser. The guide is at https://nekiosu.nekiak.com/tutorial", 198.OrangeRed, 6000, null);
		}
	}

	// Token: 0x06003FFB RID: 16379 RVA: 0x0018D62A File Offset: 0x0018B82A
	private void OpenGameFolder(object 1, EventArgs 2)
	{
		1662.68(1345.4());
	}

	// Token: 0x06003FFC RID: 16380 RVA: 0x0018D638 File Offset: 0x0018B838
	private void 8(object 1, EventArgs 2)
	{
		1272.3.ForEach(delegate(1262 1)
		{
			1.64 = false;
		});
		1763.5(1568.1(2679.Options_MarkMapsPlayed_Success), 198.YellowGreen, 4000, null);
		if (1662.78 != 1677.Menu)
		{
			1662.SetMode(1677.Unknown, false);
		}
	}

	// Token: 0x06003FFD RID: 16381 RVA: 0x0018D694 File Offset: 0x0018B894
	private void 9(object 1, EventArgs 2)
	{
		1662.61(false);
		1763.5(1568.1(2679.Options_ForceFolderPermissions_Successful), 198.YellowGreen, 4000, null);
		1662.SetMode(1677.Unknown, false);
	}

	// Token: 0x06003FFE RID: 16382 RVA: 0x0018D6BC File Offset: 0x0018B8BC
	internal void 10(bool 1)
	{
		if (this.17)
		{
			this.5.ForEach(new Action<1779>(1784.1788.instance.13));
			this.5.Clear();
			this.21.Clear();
			this.10.15(true);
			this.1();
			this.19();
		}
	}

	// Token: 0x06003FFF RID: 16383 RVA: 0x0018D71A File Offset: 0x0018B91A
	internal static IEnumerable<1772> 11()
	{
		return new 1772[]
		{
			new 1772(1568.1(2679.Options_ReleaseStrategy_Stable), 2667.Stable40),
			new 1772(1568.1(2679.Options_ReleaseStrategy_CuttingEdge), 2667.CuttingEdge)
		};
	}

	// Token: 0x06004000 RID: 16384 RVA: 0x0018D754 File Offset: 0x0018B954
	public static IEnumerable<1772> 12()
	{
		return new List<1772>
		{
			new 1772("2x refresh rate (default)", 1309.Double),
			new 1772("4x refresh rate", 1309.Quadruple),
			new 1772("8x refresh rate", 1309.Eightfold),
			new 1772("16x refresh rate", 1309.Sixteenfold)
		};
	}

	// Token: 0x06004001 RID: 16385 RVA: 0x0018D7C0 File Offset: 0x0018B9C0
	public static IEnumerable<1772> 13()
	{
		List<1772> list = new List<1772>
		{
			new 1772(1568.1(2679.Options_Graphics_FrameLimiter_VSync), 1303.VSync),
			new 1772("Power Saving", 1303.PowerSaving),
			new 1772("Optimal", 1303.Limit120),
			new 1772(1568.1(2679.Options_Graphics_FrameLimiter_UnlimGreen), 1303.Unlimited)
		};
		if (1304.203.GetValue() == 1303.Custom)
		{
			list.Add(new 1772(string.Format("Custom ({0}fps)", 1304.140.6()), 1303.Custom));
		}
		return list;
	}

	// Token: 0x06004002 RID: 16386 RVA: 0x0018D868 File Offset: 0x0018BA68
	internal 1784(1803 1) : base(1)
	{
		this.9 = new 1436(true);
		this.10 = new 1436(true);
		this.8 = new 1436(true)
		{
			47 = true
		};
		1417 2 = new 1417(new 207(40, 0, 1662.70.1(), 1662.70.2()), 208.Zero, true, 0f, 1545.Options);
		2.5 = false;
		2.9 = false;
		2.9(true);
		this.3 = 2;
		1417 3 = new 1417(new 207(0, 0, 40, 1662.70.2()), 208.Zero, true, 0f, 1545.Options);
		3.6 = true;
		3.9 = false;
		3.9(true);
		this.4 = 3;
		this.7 = this.3.22;
		this.7.10 = false;
		this.10 = this.4.22;
		this.10.10 = false;
		this.9.47 = true;
	}

	// Token: 0x06004003 RID: 16387 RVA: 0x0018D9AB File Offset: 0x0018BBAB
	private bool 14()
	{
		return 1304.203.GetValue() == 1303.Unlimited;
	}

	// Token: 0x06004004 RID: 16388 RVA: 0x0018D9BA File Offset: 0x0018BBBA
	internal bool 15()
	{
		return this.19;
	}

	// Token: 0x06004005 RID: 16389 RVA: 0x0018D9C4 File Offset: 0x0018BBC4
	internal void 16(bool 1)
	{
		if (this.19 == 1)
		{
			return;
		}
		if (!this.17)
		{
			this.Initialize();
		}
		this.19 = 1;
		this.23(1);
		if (!this.19)
		{
			if (!1662.21() && this.18 != null)
			{
				this.18(false);
			}
			this.18 = null;
		}
		if (this.19)
		{
			this.3.14();
			this.4.14();
			1662.95(false, false);
			this.19();
		}
	}

	// Token: 0x06004006 RID: 16390 RVA: 0x0018DA50 File Offset: 0x0018BC50
	public bool 17()
	{
		1677 <<EMPTY_NAME>> = 1662.78;
		switch (<<EMPTY_NAME>>)
		{
		case 1677.Menu:
		case 1677.SelectEdit:
		case 1677.SelectPlay:
			break;
		case 1677.Edit:
		case 1677.Exit:
			return false;
		case 1677.Play:
		{
			2023 2 = 2023.Autoplay;
			2023 3 = 2019.1;
			2023 4 = 2;
			return (3 & 4) > 2023.None;
		}
		default:
			if (<<EMPTY_NAME>> - 1677.Lobby > 2)
			{
				return false;
			}
			break;
		}
		return true;
	}

	// Token: 0x06004007 RID: 16391 RVA: 0x0018DAA0 File Offset: 0x0018BCA0
	public override void Initialize()
	{
		if (this.17)
		{
			return;
		}
		this.30 = new 1422(18, new 208(0f, 100f), 20, (1066)2);
		this.30.4(new 1448.1449(this.26));
		this.30.24(false);
		this.30.2.ForEach(delegate(1433 1)
		{
			1.54 = true;
			1.55 = 90f;
		});
		this.7.14<1433>(this.30.2);
		this.31 = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, 208.Zero, 0.95f, true, new 198(8, 8, 8), null);
		this.31.16 = 0.7f;
		this.31.15 = 1.6f;
		this.31.20 = new 208(274f, 130f);
		this.31.54 = true;
		this.31.55 = 90f;
		this.7.12(this.31);
		SystemEvents.DisplaySettingsChanged += delegate(object 1, EventArgs 2)
		{
			1662.89.Schedule(new 1189(this.36), false);
		};
		1662.76(new 1189(this.29));
		this.32 = new 1452(string.Empty, 20f, new 208(0f, 40f), 1f, true, new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue));
		this.32.63(true);
		this.32.54 = true;
		this.32.55 = 90f;
		this.32.49 = 1065.TopCentre;
		this.32.41 = (1376)7;
		this.7.12(this.32);
		this.33 = new 1452(string.Empty, 14f, new 208(0f, 60f), 1f, true, 2630.14);
		this.33.54 = true;
		this.33.63(true);
		this.33.55 = 90f;
		this.33.49 = 1065.TopCentre;
		this.33.41 = (1376)7;
		this.7.12(this.33);
		this.1();
		this.11 = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, 208.Zero, 0.95f, true, new 198(8, 8, 8), null);
		this.11.16 = 0.7f;
		this.11.15 = 1.6f;
		this.11.11 = true;
		this.11.20 = new 208(314f, (float)1662.70.2());
		this.11.54 = true;
		this.11.10 = true;
		this.11.3(delegate(object 1, EventArgs 2)
		{
			1779 3 = this.37.8 as 1779;
			if (3 != null)
			{
				1371 4 = 3.13();
				if (4 == null)
				{
					return;
				}
				4.1(true);
			}
		});
		this.9.12(this.11);
		this.12 = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, 208.Zero, 0.951f, true, new 198(8, 8, 8), null);
		this.12.16 = 1f;
		this.12.15 = 1.6f;
		this.12.54 = true;
		this.12.20 = new 208(140f, (float)1662.70.2());
		this.4.23.12(this.12);
		this.37 = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, 208.Zero, 0f, true, new 198(8, 8, 8), null);
		this.37.16 = 0.7f;
		this.37.15 = 1.6f;
		this.37.20 = new 208(274f, 0f);
		this.3.23.12(this.37);
		this.3.Hide();
		this.3.19(1058.rectangleF3);
		this.9.27(1058.rectangleF3);
		this.19();
		this.8.14<1433>(new 1354(new EventHandler(this.27), false, false).1);
		this.3.20(new 208(0f, 200f), 0f);
		this.4.23.5 = (this.8.5 = (this.9.5 = (this.10.5 = (this.7.5 = 0f))));
		base.Initialize();
		this.17 = true;
	}

	// Token: 0x06004008 RID: 16392 RVA: 0x0018DF88 File Offset: 0x0018C188
	private void 18(1779[] 1, bool 2)
	{
		for (int i = 0; i < 1.Length; i++)
		{
			1[i].12 = 2;
		}
		this.19();
	}

	// Token: 0x06004009 RID: 16393 RVA: 0x0018DFB2 File Offset: 0x0018C1B2
	private void 19()
	{
		this.22 = true;
	}

	// Token: 0x0600400A RID: 16394 RVA: 0x0018DFBC File Offset: 0x0018C1BC
	protected override void Dispose(bool 1)
	{
		if (this.13 != null)
		{
			this.13.Dispose();
		}
		this.3.Dispose();
		this.4.Dispose();
		this.9.Dispose();
		this.10.Dispose();
		this.8.Dispose();
		if (this.30 != null)
		{
			this.30.Dispose();
		}
		this.5.ForEach(new Action<1779>(1784.1788.instance.11));
		1662.77(new 1189(this.29));
		base.Dispose(1);
	}

	// Token: 0x0600400B RID: 16395 RVA: 0x0018E05C File Offset: 0x0018C25C
	internal bool 20(object 1, 200 2, bool 3)
	{
		if (3)
		{
			if (2 != 200.Tab)
			{
				if (2 == 200.Escape)
				{
					if (!this.30.28())
					{
						this.30.27();
					}
					else if (this.15())
					{
						this.16(false);
					}
					else if (this.22())
					{
						this.23(false);
					}
					return true;
				}
			}
			else
			{
				if (this.35 == null || this.36 == null)
				{
					return true;
				}
				if (this.35.13.15.Focused)
				{
					this.35.21();
					this.36.20();
				}
				else
				{
					this.36.21();
					this.35.20();
				}
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600400C RID: 16396 RVA: 0x0018E114 File Offset: 0x0018C314
	private void 21(1779 1)
	{
		this.5.Add(1);
		if (1.GetChildren() != null)
		{
			foreach (1779 2 in 1.GetChildren())
			{
				2.6(new EventHandler(this.40));
				this.21(2);
			}
		}
		1782 3 = 1 as 1782;
		if (3 != null)
		{
			1783 4 = new 1783(3, new EventHandler(this.38));
			this.21.Add(4);
			this.10.14<1433>(4.1);
		}
		this.3.32(1.1);
	}

	// Token: 0x0600400D RID: 16397 RVA: 0x0018E1D4 File Offset: 0x0018C3D4
	public bool 22()
	{
		return this.24;
	}

	// Token: 0x0600400E RID: 16398 RVA: 0x0018E1DC File Offset: 0x0018C3DC
	public void 23(bool 1)
	{
		if (1 == this.24)
		{
			return;
		}
		if (!this.17)
		{
			this.Initialize();
		}
		this.24 = 1;
		if (1)
		{
			this.3.Show();
			this.19();
			if (this.23)
			{
				this.3.25(-100f, 0.5f);
			}
			this.23 = false;
		}
		else
		{
			this.16(false);
		}
		this.30.24(1);
	}

	// Token: 0x0600400F RID: 16399 RVA: 0x0018E258 File Offset: 0x0018C458
	public override void Draw()
	{
		if (this.17)
		{
			if (this.22)
			{
				this.37();
			}
			if (this.13 != null)
			{
				this.13.Draw();
			}
			this.9.22();
			this.3.21();
			this.4.21();
			this.8.22();
			base.Draw();
		}
	}

	// Token: 0x06004010 RID: 16400 RVA: 0x0018E2C4 File Offset: 0x0018C4C4
	public override void Update()
	{
		if (!this.17)
		{
			return;
		}
		if (this.13 != null)
		{
			this.13.Update();
		}
		this.31.16 = Math.Min(0.5f, this.3.20.Y / this.31.55);
		float num = (float)(this.22() ? (this.16.Width + 1) : 0);
		if (1662.10 < 4.0 && (this.14 > 0f || this.14 != num))
		{
			float num2 = this.22() > false;
			if (this.14 != num)
			{
				this.14 -= (this.14 - num) * 0.1f * (float)1662.10;
				this.15 -= (this.15 - num2) * 0.1f * (float)1662.10;
				if (this.14 < 1f)
				{
					this.14 = (this.15 = 0f);
				}
				this.3.7(this.15);
				this.8.5 = this.15;
				this.4.7(this.15);
				this.9.5 = Math.Min(1f, this.15 * 4f);
				this.10.5 = Math.Min(1f, this.20 ? 0f : (this.15 * 4f));
			}
			1058 <<EMPTY_NAME>> = new 1058(40f, 0f, (float)((int)this.14), (float)1662.70.2());
			this.3.19(<<EMPTY_NAME>>);
			1058 2 = new 1058(0f, 0f, (float)((int)this.14 + 40), (float)1662.70.2());
			this.9.27(2);
			if (1662.87() > 30000)
			{
				this.23(false);
			}
			if (1662.23)
			{
				if (1304.191)
				{
					this.34.20(string.Format(1568.1(2679.Options_Input_RawInputPoll), (1555.4 > 0.5f) ? Math.Ceiling((double)1555.4) : 0.0, (1555.3 > 0) ? (1555.3.ToString() + "ms") : "-"));
				}
				else
				{
					this.34.20(1568.1(2679.Options_Input_RawInput));
				}
				1774 3 = this.38;
				if (3 != null)
				{
					3.20(1336.3(true));
				}
			}
			bool flag = false;
			foreach (1779 4 in this.5)
			{
				if (!4.1.6 && new 1058(this.25 * 1662.70.3(), (4.1.33.Y - 4.1.30.Y - 5f) * 1662.70.3(), (274f - this.25) * 1662.70.3(), (4.2().Y + 10f) * 1662.70.3()).9(1555.17()))
				{
					if (4 is 1782 || 4 is 1781)
					{
						break;
					}
					flag = true;
					this.11.52 = 4.15();
					if (this.37.8 != 4)
					{
						1226.20(null, "click-short", 1f, false);
						this.37.8 = 4;
						this.37.3.Clear();
						this.37.FadeIn(100, (1046)0, 0);
						this.37.19(new 208(0f, 4.1.33.Y - 5f), 140, (1046)30);
						this.37.3.Add(new 1445(1456.VectorScale, this.37.20, new 208(274f, 4.2().Y + 10f), 1662.33, 1662.33 + 140, (1046)30));
						break;
					}
					break;
				}
			}
			if (!flag)
			{
				this.24();
			}
		}
		this.3.Update();
		this.41();
		bool flag2 = !this.14();
		if (this.41 != null && this.42.12 != flag2)
		{
			this.42.12 = flag2;
			this.19();
		}
		base.Update();
	}

	// Token: 0x06004011 RID: 16401 RVA: 0x0018E7E0 File Offset: 0x0018C9E0
	private void 24()
	{
		if (this.37 != null && this.37.8 != null)
		{
			this.37.16(500, (1046)0, 0);
			this.37.8 = null;
			this.11.52 = null;
		}
	}

	// Token: 0x06004012 RID: 16402 RVA: 0x0018E82C File Offset: 0x0018CA2C
	internal void 25()
	{
		if (this.22())
		{
			this.23(false);
			return;
		}
		if (1662.78 == 1677.Menu)
		{
			this.16(true);
			return;
		}
		this.23(true);
	}

	// Token: 0x06004013 RID: 16403 RVA: 0x0018E854 File Offset: 0x0018CA54
	private void 26(1448 1, bool 2)
	{
		if (2)
		{
			this.19();
			this.3.25(0f, -0.99f);
		}
	}

	// Token: 0x06004014 RID: 16404 RVA: 0x0018E874 File Offset: 0x0018CA74
	private void 27(object 1, EventArgs 2)
	{
		this.16(false);
	}

	// Token: 0x06004015 RID: 16405 RVA: 0x0018E87D File Offset: 0x0018CA7D
	private void Close()
	{
		if (this.15())
		{
			this.16(false);
		}
		if (this.22())
		{
			this.23(false);
		}
	}

	// Token: 0x06004016 RID: 16406 RVA: 0x0018E89D File Offset: 0x0018CA9D
	private bool 28()
	{
		return !1304.167 && 1143.1();
	}

	// Token: 0x06004017 RID: 16407 RVA: 0x0018E8B2 File Offset: 0x0018CAB2
	private void 29()
	{
		this.34();
	}

	// Token: 0x06004018 RID: 16408 RVA: 0x0018E8BC File Offset: 0x0018CABC
	private static void 30(1373 1, Size 2, Size 3)
	{
		if (2.Height <= 3.Height)
		{
			string str = (2 == 3) ? (" " + 1568.1(2679.Options_Graphics_ResolutionNative)) : string.Empty;
			string text = 2.ToDimensionString();
			1.10(text + str, text);
		}
	}

	// Token: 0x06004019 RID: 16409 RVA: 0x0018E914 File Offset: 0x0018CB14
	private static void 31(1373 1, Size 2, Size 3)
	{
		string str = (2 == 3) ? (" " + 1568.1(2679.Options_Graphics_ResolutionBorderless)) : string.Empty;
		if (2.Width <= 3.Width && 2.Height <= 3.Height)
		{
			string text = 2.ToDimensionString();
			1.10(text + str, text);
		}
	}

	// Token: 0x0600401A RID: 16410 RVA: 0x0018E97C File Offset: 0x0018CB7C
	private static void 32(1373 1, List<Size> 2, Size 3)
	{
		foreach (Size 4 in 2)
		{
			if (1304.167)
			{
				1784.30(1, 4, 3);
			}
			else
			{
				1784.31(1, 4, 1662.113);
			}
		}
	}

	// Token: 0x0600401B RID: 16411 RVA: 0x0018E9E8 File Offset: 0x0018CBE8
	private static void 33(List<Size> 1)
	{
		3.Sort(delegate(Size 1, Size 2)
		{
			if (1.Width == 2.Width)
			{
				return 1.Height.CompareTo(2.Height);
			}
			return 1.Width.CompareTo(2.Width);
		});
		int i = 0;
		while (i < 3.Count - 1)
		{
			Size sz = 3[i];
			if (sz.Width < 800 || sz.Height < 600 || sz == 3[i + 1])
			{
				3.RemoveAt(i);
			}
			else
			{
				i++;
			}
		}
	}

	// Token: 0x0600401C RID: 16412 RVA: 0x0018EA6C File Offset: 0x0018CC6C
	internal void 34()
	{
		if (this.28 != null && this.28.13 != null)
		{
			1784.35(this.28.13);
		}
		bool flag = !this.28();
		if (this.41 != null && this.41.12 != flag)
		{
			this.41.12 = flag;
			this.19();
		}
	}

	// Token: 0x0600401D RID: 16413 RVA: 0x0018EAD0 File Offset: 0x0018CCD0
	internal static void 35(1373 1)
	{
		3.13();
		List<Size> list = 1805.3();
		if (list.Count == 0)
		{
			return;
		}
		1784.33(list);
		Size size = list[list.Count - 1];
		if (!1304.167 || 1304.208)
		{
			list.Add(new Size(800, 600));
			list.Add(new Size(1024, 768));
			list.Add(new Size(1280, 960));
			list.Add(new Size(1600, 1200));
			list.Add(new Size(1920, 1440));
			list.Add(new Size(2560, 1920));
			list.Add(new Size(1024, 600));
			list.Add(new Size(1280, 800));
			list.Add(new Size(1366, 768));
			list.Add(new Size(1440, 900));
			list.Add(new Size(1680, 1050));
			list.Add(new Size(1920, 1080));
			list.Add(new Size(1920, 1200));
			list.Add(new Size(2560, 1440));
			list.Add(new Size(2560, 1600));
		}
		1784.33(list);
		List<Size> list2 = list.FindAll(new Predicate<Size>(1784.1788.instance.12));
		if (list2.Count > 0)
		{
			3.11(1568.1(2679.Options_Graphics_ResolutionStandard), null, 2630.16);
			1784.32(3, list2, size);
		}
		List<Size> list3 = list.FindAll((Size 1) => (float)1.Width * 3f / ((float)1.Height * 4f) > 1f);
		if (list3.Count > 0)
		{
			3.11(1568.1(2679.Options_Graphics_ResolutionWidescreen), null, 2630.16);
			1784.32(3, list3, size);
		}
		Size 2 = Size.Empty;
		2 = ((1662.33 != 0) ? new Size(1662.70.1, 1662.70.2) : ((!1304.167) ? new Size(1304.157, 1304.148) : new Size(1304.158, 1304.149)));
		string text = 2.ToDimensionString();
		if (!3.18(text, true))
		{
			if (2.Width == 9999)
			{
				3.18(list[list.Count - 1].ToDimensionString(), true);
				return;
			}
			3.10(text + " (" + 1568.1(2679.Options_Graphics_CustomResolution) + ")", text);
			3.18(text, true);
		}
	}

	// Token: 0x0600401E RID: 16414 RVA: 0x0018EDC0 File Offset: 0x0018CFC0
	private void 36()
	{
		Size sz = 1805.7();
		if (1662.113 != sz && !1304.167 && !1662.118)
		{
			1662.45(false);
			1784.35(this.28.13);
		}
	}

	// Token: 0x0600401F RID: 16415 RVA: 0x0018EE0C File Offset: 0x0018D00C
	private void 37()
	{
		this.22 = false;
		this.24();
		this.16 = new 207(0, 0, 274, 1662.70.2());
		this.6.Clear();
		foreach (1779 <<EMPTY_NAME>> in this.5)
		{
			if (<<EMPTY_NAME>>.11(this.30.GetText()) && !<<EMPTY_NAME>>.12 && !this.6.Contains(<<EMPTY_NAME>>))
			{
				1779 2 = <<EMPTY_NAME>>;
				int num = 0;
				while ((2 = 2.10) != null && !this.6.Contains(2))
				{
					this.6.Insert(this.6.Count - num++, 2);
				}
				this.6.Add(<<EMPTY_NAME>>);
				if (!<<EMPTY_NAME>>.IsHeader())
				{
					continue;
				}
				using (IEnumerator<1779> enumerator2 = <<EMPTY_NAME>>.14().GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						1779 3 = enumerator2.Current;
						if (!3.12)
						{
							this.6.Add(3);
						}
					}
					continue;
				}
			}
			<<EMPTY_NAME>>.Hide();
		}
		if (this.6.Count == 0 && this.30.GetText().Length > 0)
		{
			this.30.30();
			this.30.SetText(this.30.GetText().Remove(this.30.GetText().Length - 1));
			this.19();
			return;
		}
		new 208(0f, 140f);
		int num2 = 0;
		float[] array = new float[1];
		for (int i = 0; i < 1; i++)
		{
			array[i] = 140f;
		}
		bool flag = true;
		float val = 0f;
		for (int j = 0; j < this.6.Count; j++)
		{
			1779 4 = this.6[j];
			4.Show(false);
			bool flag2 = 4.IsHeader();
			if (4.8() && !this.19)
			{
				4.1.22 = false;
				4.1.7 = 0.5f;
			}
			else
			{
				4.1.22 = true;
				4.1.7 = 0f;
			}
			if (!flag)
			{
				if (flag2)
				{
					flag = true;
					num2 = 0;
				}
				else
				{
					num2 = 0;
				}
			}
			if (!flag2)
			{
				flag = false;
			}
			if (4.GetSpacingBefore() > 0)
			{
				array[num2] += (float)4.GetSpacingBefore();
			}
			float num3 = 10f;
			if (!flag2)
			{
				num3 *= 2f;
			}
			4.1.33 = new 208(0f + num3, array[num2]);
			4.2 = array[num2] - 70f;
			if (4.2().Y > 0f)
			{
				array[num2] += 4.2().Y + 10f;
			}
			if (4.4() > 0f)
			{
				val = Math.Max(val, array[num2] + 4.4());
			}
			if (flag2)
			{
				for (int k = 0; k < 1; k++)
				{
					array[k] = array[num2];
				}
			}
		}
		this.6.ForEach(new Action<1779>(1784.1788.instance.1));
		float num4 = (float)(1662.70.2() / 2 - this.21.Count * 40 / 2);
		foreach (1783 5 in this.21)
		{
			if (!this.6.Contains(5.2))
			{
				5.4();
			}
			else
			{
				5.5();
			}
			5.3(new 208(0f, num4));
			num4 += 40f;
		}
		this.3.17(new 208((float)this.16.Width, Math.Max(val, array[num2] + (float)(this.15() ? 100 : 0))));
	}

	// Token: 0x06004020 RID: 16416 RVA: 0x0018F270 File Offset: 0x0018D470
	private void 38(object 1, EventArgs 2)
	{
		1433 3 = 1 as 1433;
		if (3 != null)
		{
			1779 4 = 3.8 as 1779;
			if (4 != null)
			{
				1226.20(null, "select-expand", 1f, false);
				this.39(4);
			}
		}
	}

	// Token: 0x06004021 RID: 16417 RVA: 0x0018F2B8 File Offset: 0x0018D4B8
	public void 39(1779 1)
	{
		1784.1789 2 = new 1784.1789();
		2.1 = this;
		2.2 = 1;
		if (!this.6.Contains(2.2))
		{
			this.30.27();
		}
		1662.89.Schedule(new 1189(2.1), true);
	}

	// Token: 0x06004022 RID: 16418 RVA: 0x0018F30F File Offset: 0x0018D50F
	private void 40(object 1, EventArgs 2)
	{
		this.19();
	}

	// Token: 0x06004023 RID: 16419 RVA: 0x0018F318 File Offset: 0x0018D518
	private void 41()
	{
		float num = this.25;
		float num2 = (float)((1555.19().X < num && this.4.22.23 != null) ? 140 : 40);
		if (this.26 > 0f)
		{
			if (num2 != num && (num2 == 40f || (!this.3.IsScrolling() && 1662.87() > 200)))
			{
				this.26 -= (float)1662.82;
			}
		}
		else
		{
			num = num2;
		}
		if (this.25 != num)
		{
			float num3 = this.25 - num;
			this.25 = num + num3 * (float)Math.Pow(0.8, 1662.10);
			if (this.25 < 40f)
			{
				this.25 = 40f;
			}
			this.4.19(new 1058(0f, 0f, this.25, (float)1662.70.2()));
		}
		if (Math.Abs(this.25 - num2) < 1f)
		{
			this.26 = 300f;
		}
		1782 <<EMPTY_NAME>> = null;
		foreach (1779 2 in this.6)
		{
			1782 3 = 2 as 1782;
			if (3 != null)
			{
				<<EMPTY_NAME>> = 3;
			}
			if (2.2 - (float)(1662.70.2() / 4) > this.3.20.Y)
			{
				break;
			}
		}
		if (<<EMPTY_NAME>> != this.27)
		{
			if (this.27 != null)
			{
				this.27.18(false);
			}
			this.27 = <<EMPTY_NAME>>;
			if (this.27 != null)
			{
				this.27.18(true);
			}
		}
		foreach (1783 4 in this.21)
		{
			4.6(4.2 == <<EMPTY_NAME>>);
		}
		this.4.Update();
	}

	// Token: 0x06004024 RID: 16420 RVA: 0x0018F534 File Offset: 0x0018D734
	private bool 42()
	{
		bool result;
		try
		{
			result = (!Directory.Exists(1784.47) && (this.45() || (Environment.Is64BitOperatingSystem && this.46())));
		}
		catch
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06004025 RID: 16421 RVA: 0x0018F584 File Offset: 0x0018D784
	private void 43(object 1, EventArgs 2)
	{
		if (this.45())
		{
			1662.69("https://osu.offline.invalid/home/download");
			return;
		}
		1689 3 = new 1689("Before you proceed...", false);
		1452 4 = new 1452("osu!(lazer) will be downloaded, installed and opened on your PC.\nBoth osu! clients will be installed, so you have the option to return to osu! stable at any point.\nOnce the new client opens, you can import all data from your existing install.", 16f, new 208(0f, 80f), 208.Zero, 1f, true, 198.White, true);
		3.AddSprite(new 1433(1455.2("lazer-stable-shortcuts", (1416)1, null), (1376)10, 1065.Centre, (1044)0, 208.Zero)
		{
			17 = new 208(0f, 100f),
			5 = true
		});
		4.41 = (1376)7;
		4.49 = 1065.Centre;
		4.75 = (1066)2;
		3.AddSprite(4);
		3.3 = 130f;
		3.7("Sounds good!", 198.Green, new EventHandler(this.47), true, false, true);
		3.5("I've changed my mind", 198.Red, new EventHandler(1784.1788.instance.15));
		1662.25(3);
	}

	// Token: 0x06004026 RID: 16422 RVA: 0x0018F688 File Offset: 0x0018D888
	private void 44()
	{
		1784.1787 download = new 1784.1787();
		download.3 = new 1689("Install progress", false);
		download.1 = new 1620(1784.48, "https://github.com/ppy/osu/releases/latest/download/install.exe");
		download.7 = new 1452("Downloading osu!(lazer)...", 24f, new 208(0f, 0f), 1f, true, 198.White);
		download.7.41 = (1376)10;
		download.7.49 = 1065.Centre;
		download.7.75 = (1066)2;
		download.4 = new 1433(1662.34, (1376)9, 1065.CentreLeft, (1044)0, new 208(336f, 20f), 0.8f, true, new 198(0, 0, 0, 150), null);
		download.4.15 = 1.6f;
		download.4.42 = new 1445(1456.Fade, 0.4f, 0.7f, 0, 600, (1046)0);
		download.4.20 = new 208(185f, 5f);
		download.5 = new 1433(1662.34, (1376)9, 1065.CentreLeft, (1044)0, new 208(336f, 20f), 0.81f, true, new 198(0, 78, 192, byte.MaxValue), null);
		download.5.15 = 1.6f;
		download.5.42 = new 1445(1456.Fade, 0.4f, 0.7f, 0, 600, (1046)0);
		download.5.20 = new 208(0f, 5f);
		download.2 = (1583)1;
		download.6 = new 1452("Initialising download...", 9f, new 208(336f, 15f), 0.82f, true, 198.White);
		download.6.41 = (1376)9;
		download.6.49 = 1065.CentreLeft;
		download.3.AddSprite(download.7);
		download.3.AddSprite(download.4);
		download.3.AddSprite(download.5);
		download.3.AddSprite(download.6);
		1662.25(download.3);
		download.3.3(new EventHandler(download.1));
		download.1.9(new 1621.1622(download.2));
		download.1.8(delegate(1621 1, long 2, long 3)
		{
			if (download.2 != (1583)3)
			{
				if (download.2 == (1583)1)
				{
					download.2 = (1583)2;
				}
				double num = (3 == 0L) ? 0.0 : ((double)2 / (double)3);
				download.6.SetText(string.Format("{0:0.0%}", num));
				download.5.20.X = (float)num * 185f;
				download.6.17 = new 208(download.5.7.X + Math.Min(download.5.20.X, 156f), download.5.17.Y);
				download.6.7 = download.6.17;
			}
		});
		download.1.Start();
	}

	// Token: 0x06004027 RID: 16423 RVA: 0x0018F9C0 File Offset: 0x0018DBC0
	private bool 45()
	{
		if (1181.1())
		{
			return true;
		}
		bool result;
		using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Wine"))
		{
			result = (registryKey != null);
		}
		return result;
	}

	// Token: 0x06004028 RID: 16424 RVA: 0x0018FA08 File Offset: 0x0018DC08
	private bool 46()
	{
		bool result;
		try
		{
			using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion"))
			{
				string text = ((registryKey != null) ? registryKey.GetValue("CurrentBuild") : null) as string;
				if (text != null)
				{
					int num;
					return int.TryParse(text, out num) && num >= 9200;
				}
			}
			result = false;
		}
		catch (Exception)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06004029 RID: 16425 RVA: 0x0018FA8C File Offset: 0x0018DC8C
	private void 47(object 1, EventArgs 2)
	{
		this.44();
	}

	// Token: 0x0600402A RID: 16426 RVA: 0x0018FA94 File Offset: 0x0018DC94
	internal void 48(1184 1)
	{
		1184 2 = this.18;
		1184 3;
		do
		{
			3 = 2;
			1184 value = (1184)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1184>(ref this.18, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x0600402B RID: 16427 RVA: 0x0018FAC9 File Offset: 0x0018DCC9
	internal void 49(bool 1)
	{
		if (this.20 != 1)
		{
			this.20 = 1;
			this.10(true);
			return;
		}
		this.20 = 1;
	}

	// Token: 0x0600402C RID: 16428 RVA: 0x0018FAEC File Offset: 0x0018DCEC
	private 1781 50()
	{
		this.36 = null;
		1781 <<EMPTY_NAME>> = new 1781("Profile", new string[]
		{
			"username",
			"name",
			"player",
			"login",
			"sign in"
		});
		this.35 = new 1794(2679.Options_Username, 1304.189, false);
		<<EMPTY_NAME>>.SetChildren(new 1779[]
		{
			this.35,
			new 1774("Used as your player name on scores and replays. Press Enter to apply.", null)
		});
		this.35.13.3(delegate(1448 1, bool 2)
		{
			1784.51(this.35.13.GetText());
		});
		return <<EMPTY_NAME>>;
	}

	// Token: 0x0600402D RID: 16429 RVA: 0x0018FB90 File Offset: 0x0018DD90
	private static void 51(string 1)
	{
		1 = (1 ?? string.Empty).Trim();
		if (1304.189.GetValue() != 1)
		{
			1304.189.SetValue(1);
		}
		if (1662.100 != null)
		{
			1662.100.3(1);
			1662.100.24();
		}
	}

	// Token: 0x0600402E RID: 16430 RVA: 0x0018FBE7 File Offset: 0x0018DDE7
	private void 52(object 1, KeyEventArgs 2)
	{
		if (2.KeyCode == Keys.Return)
		{
			this.53();
		}
	}

	// Token: 0x0600402F RID: 16431 RVA: 0x0018FBF9 File Offset: 0x0018DDF9
	private void 53()
	{
		1794 <<EMPTY_NAME>> = this.35;
		string 2 = (<<EMPTY_NAME>> != null) ? <<EMPTY_NAME>>.13.GetText() : null;
		1794 3 = this.36;
		this.54(2, (3 != null) ? 3.13.GetText() : null);
	}

	// Token: 0x06004030 RID: 16432 RVA: 0x0018FC30 File Offset: 0x0018DE30
	internal void 54(string 1, string 2)
	{
		if (this.36 != null && !string.IsNullOrEmpty(1) && !string.IsNullOrEmpty(2))
		{
			1320<string> 3 = 1304.189;
			this.35.13.SetText(1);
			3.SetValue(1);
			1304.186 = new 1644(2, false);
			this.36.13.SetText(string.Empty);
			this.10(true);
		}
	}

	// Token: 0x06004031 RID: 16433 RVA: 0x0018FC9B File Offset: 0x0018DE9B
	internal void 55()
	{
		1304.189.SetValue(string.Empty);
		1304.186 = null;
		1662.100.3(string.Empty);
		1662.100.24();
		this.10(true);
	}

	// Token: 0x06004032 RID: 16434 RVA: 0x0018FCD4 File Offset: 0x0018DED4
	private void 56(object 1, EventArgs 2)
	{
		if ((bool)1)
		{
			1662.100.3(1304.189);
			1662.100.24();
			if (1304.164.GetValue() == 1289.Local)
			{
				1304.164.SetValue(1289.Top);
			}
			if (this.18 != null)
			{
				this.18(true);
			}
			if (this.20)
			{
				1662.89.2(delegate
				{
					if (this.15())
					{
						this.16(false);
					}
					if (this.22())
					{
						this.23(false);
					}
				}, 500, false);
			}
		}
		1662.89.Schedule(new 1189(this.57), false);
	}

	// Token: 0x06004033 RID: 16435 RVA: 0x0018FD6F File Offset: 0x0018DF6F
	private void 57()
	{
		this.10(true);
		if (this.36 != null)
		{
			this.36.20();
		}
	}

	// Token: 0x04002EB7 RID: 11959
	private 1417 3;

	// Token: 0x04002EB8 RID: 11960
	private 1417 4;

	// Token: 0x04002EB9 RID: 11961
	private List<1779> 5 = new List<1779>();

	// Token: 0x04002EBA RID: 11962
	private List<1779> 6 = new List<1779>();

	// Token: 0x04002EBB RID: 11963
	private 1436 7;

	// Token: 0x04002EBC RID: 11964
	private 1436 8;

	// Token: 0x04002EBD RID: 11965
	private 1436 9;

	// Token: 0x04002EBE RID: 11966
	private 1436 10;

	// Token: 0x04002EBF RID: 11967
	private 1433 11;

	// Token: 0x04002EC0 RID: 11968
	private 1433 12;

	// Token: 0x04002EC1 RID: 11969
	private 1491 13;

	// Token: 0x04002EC2 RID: 11970
	private float 14;

	// Token: 0x04002EC3 RID: 11971
	private float 15;

	// Token: 0x04002EC4 RID: 11972
	private 207 16;

	// Token: 0x04002EC5 RID: 11973
	private bool 17;

	// Token: 0x04002EC6 RID: 11974
	private 1184 18;

	// Token: 0x04002EC7 RID: 11975
	private bool 19;

	// Token: 0x04002EC8 RID: 11976
	private bool 20;

	// Token: 0x04002EC9 RID: 11977
	private List<1783> 21 = new List<1783>();

	// Token: 0x04002ECA RID: 11978
	private bool 22;

	// Token: 0x04002ECB RID: 11979
	private bool 23 = true;

	// Token: 0x04002ECC RID: 11980
	private bool 24;

	// Token: 0x04002ECD RID: 11981
	private float 25 = 40f;

	// Token: 0x04002ECE RID: 11982
	private float 26;

	// Token: 0x04002ECF RID: 11983
	private 1782 27;

	// Token: 0x04002ED0 RID: 11984
	private 1773<string> 28;

	// Token: 0x04002ED1 RID: 11985
	private 1771 29;

	// Token: 0x04002ED2 RID: 11986
	private 1422 30;

	// Token: 0x04002ED3 RID: 11987
	private 1433 31;

	// Token: 0x04002ED4 RID: 11988
	private 1452 32;

	// Token: 0x04002ED5 RID: 11989
	private 1452 33;

	// Token: 0x04002ED6 RID: 11990
	private 1771 34;

	// Token: 0x04002ED7 RID: 11991
	private 1794 35;

	// Token: 0x04002ED8 RID: 11992
	private 1794 36;

	// Token: 0x04002ED9 RID: 11993
	private 1433 37;

	// Token: 0x04002EDA RID: 11994
	private 1774 38;

	// Token: 0x04002EDB RID: 11995
	private 1773<string> 39;

	// Token: 0x04002EDC RID: 11996
	private 1773<string> 40;

	// Token: 0x04002EDD RID: 11997
	private 1774 41;

	// Token: 0x04002EDE RID: 11998
	private 1774 42;

	// Token: 0x04002EDF RID: 11999
	private 1771 43;

	// Token: 0x04002EE0 RID: 12000
	private 1770 44;

	// Token: 0x04002EE1 RID: 12001
	public 1781 45;

	// Token: 0x04002EE2 RID: 12002
	public 1781 46;

	// Token: 0x04002EE3 RID: 12003
	private static readonly string 47 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "osulazer");

	// Token: 0x04002EE4 RID: 12004
	private static readonly string 48 = Path.Combine(Path.GetTempPath(), "install.exe");

	// Token: 0x020008BA RID: 2234
	public sealed class 1786
	{
		// Token: 0x04002EE5 RID: 12005
		public 1262 1;
	}

	// Token: 0x020008BB RID: 2235
	public sealed class 1790
	{
		// Token: 0x0600403A RID: 16442 RVA: 0x0018FE20 File Offset: 0x0018E020
		internal void 1(object 1, EventArgs 2)
		{
			this.1.ForEach(delegate(1262 1)
			{
				1272.19(1, true);
			});
			2463.2(false);
			1272.SetCurrentBeatmap(null);
			if (1662.78 != 1677.Menu)
			{
				1662.SetMode(1677.Unknown, false);
			}
		}

		// Token: 0x04002EE6 RID: 12006
		public List<1262> 1;
	}

	// Token: 0x020008BD RID: 2237
	public sealed class 1785
	{
		// Token: 0x0600403F RID: 16447 RVA: 0x0018FE87 File Offset: 0x0018E087
		internal void 1(bool 1)
		{
			this.3.20((1304.207.5() ? "+ " : " ") + 1568.1(2679.Options_Gameplay_Stars));
		}

		// Token: 0x06004040 RID: 16448 RVA: 0x0018FEBB File Offset: 0x0018E0BB
		internal void 2(object 1, EventArgs 2)
		{
			this.1.30.SetEnabled(true);
		}

		// Token: 0x06004041 RID: 16449 RVA: 0x0018FECE File Offset: 0x0018E0CE
		internal void 3(object 1, EventArgs 2)
		{
			2010 3 = new 2010();
			3.3(delegate(object 1, EventArgs 2)
			{
				this.1.30.SetEnabled(true);
			});
			this.1.30.SetEnabled(false);
			1662.25(3);
		}

		// Token: 0x04002EE9 RID: 12009
		public 1784 1;

		// Token: 0x04002EEA RID: 12010
		public 1779[] 2;

		// Token: 0x04002EEB RID: 12011
		public 1793 3;
	}

	// Token: 0x020008BE RID: 2238
	[Serializable]
	public sealed class 1788
	{
		// Token: 0x06004044 RID: 16452 RVA: 0x0018FEFD File Offset: 0x0018E0FD
		internal void 1(1779 1)
		{
			1.OnLayoutUpdated();
		}

		// Token: 0x06004045 RID: 16453 RVA: 0x0018FF05 File Offset: 0x0018E105
		internal void 2()
		{
			if (1336.7 != null)
			{
				1662.SetMode(1677.Update, false);
				return;
			}
			1662.95(false, true);
		}

		// Token: 0x06004046 RID: 16454 RVA: 0x0018FF1D File Offset: 0x0018E11D
		internal void 3(object 1, EventArgs 2)
		{
			1304.214.2(false);
			1662.94(null);
		}

		// Token: 0x06004047 RID: 16455 RVA: 0x0018FF30 File Offset: 0x0018E130
		internal void 4(object 1, EventArgs 2)
		{
			1662.71(new 1189(1784.1788.instance.5));
			if (1662.93())
			{
				1662.SetMode(1662.78, true);
			}
		}

		// Token: 0x06004048 RID: 16456 RVA: 0x0018FF59 File Offset: 0x0018E159
		internal void 5()
		{
			2630.10(null, true);
		}

		// Token: 0x06004049 RID: 16457 RVA: 0x0018FF63 File Offset: 0x0018E163
		internal void 6(object 1, EventArgs 2)
		{
			1662.25(new 1688("Preview your current skin in gameplay?", new EventHandler(1784.1788.instance.7), null, true));
		}

		// Token: 0x0600404A RID: 16458 RVA: 0x0018FF86 File Offset: 0x0018E186
		internal void 7(object 1, EventArgs 2)
		{
			2486.17(true);
		}

		// Token: 0x0600404B RID: 16459 RVA: 0x0018FF8E File Offset: 0x0018E18E
		internal void 8(object 1, EventArgs 2)
		{
			2630.25();
			1662.68(2630.5.14());
		}

		// Token: 0x0600404C RID: 16460 RVA: 0x0018FFA4 File Offset: 0x0018E1A4
		internal void 9(object 1, EventArgs 2)
		{
			2630.11();
		}

		// Token: 0x0600404D RID: 16461 RVA: 0x0018FFAC File Offset: 0x0018E1AC
		internal bool 10(1262 1)
		{
			1784.1786 matcher = new 1784.1786();
			matcher.1 = 2;
			return (matcher.1.85 == (1281)2 || matcher.1.85 == (1281)1) && matcher.1.43 != 1304.189 && 1272.3.FindAll((1262 1) => 1.37 == matcher.1.37 && (1.85 == (1281)4 || 1.43 == 1304.189)).Count == 0;
		}

		// Token: 0x0600404E RID: 16462 RVA: 0x0019003D File Offset: 0x0018E23D
		internal void 11(1779 1)
		{
			1.Dispose();
		}

		// Token: 0x0600404F RID: 16463 RVA: 0x00190045 File Offset: 0x0018E245
		internal bool 12(Size 1)
		{
			return (float)1.Width * 3f / ((float)1.Height * 4f) <= 1f;
		}

		// Token: 0x06004050 RID: 16464 RVA: 0x0019003D File Offset: 0x0018E23D
		internal void 13(1779 1)
		{
			1.Dispose();
		}

		// Token: 0x06004051 RID: 16465 RVA: 0x0019006E File Offset: 0x0018E26E
		internal void 14(object 1, EventArgs 2)
		{
			1662.69(string.Format("{0}/home/password-reset", 1296.6));
		}

		// Token: 0x06004052 RID: 16466 RVA: 0x00005ADD File Offset: 0x00003CDD
		internal void 15(object 1, EventArgs 2)
		{
		}

		// Token: 0x04002EEC RID: 12012
		public static readonly 1784.1788 instance = new 1784.1788();

		// Token: 0x04002EED RID: 12013
		public static Action<1433> action;

		// Token: 0x04002EEE RID: 12014
		public static Action<1779> action2;

		// Token: 0x04002EEF RID: 12015
		public static 1189 voidDelegate;

		// Token: 0x04002EF0 RID: 12016
		public static EventHandler eventHandler;

		// Token: 0x04002EF1 RID: 12017
		public static EventHandler eventHandler2;

		// Token: 0x04002EF2 RID: 12018
		public static EventHandler eventHandler3;

		// Token: 0x04002EF3 RID: 12019
		public static 1189 voidDelegate2;

		// Token: 0x04002EF4 RID: 12020
		public static EventHandler eventHandler4;

		// Token: 0x04002EF5 RID: 12021
		public static EventHandler eventHandler5;

		// Token: 0x04002EF6 RID: 12022
		public static EventHandler eventHandler6;

		// Token: 0x04002EF7 RID: 12023
		public static EventHandler eventHandler7;

		// Token: 0x04002EF8 RID: 12024
		public static EventHandler eventHandler8;

		// Token: 0x04002EF9 RID: 12025
		public static Func<2026, bool> cachedIsConverterForCurrentMode;

		// Token: 0x04002EFA RID: 12026
		public static Action<1262> action3;

		// Token: 0x04002EFB RID: 12027
		public static Predicate<1262> cachedIsDeletableUnrankedMap;

		// Token: 0x04002EFC RID: 12028
		public static Action<1262> action4;

		// Token: 0x04002EFD RID: 12029
		public static Action<1779> action5;

		// Token: 0x04002EFE RID: 12030
		public static Comparison<Size> cachedCompareSizes;

		// Token: 0x04002EFF RID: 12031
		public static Predicate<Size> predicate;

		// Token: 0x04002F00 RID: 12032
		public static Predicate<Size> predicate2;

		// Token: 0x04002F01 RID: 12033
		public static Action<1779> action6;

		// Token: 0x04002F02 RID: 12034
		public static 1189 voidDelegate3;

		// Token: 0x04002F03 RID: 12035
		public static EventHandler eventHandler9;

		// Token: 0x04002F04 RID: 12036
		public static EventHandler eventHandler10;

		// Token: 0x04002F05 RID: 12037
		public static EventHandler eventHandler11;

		// Token: 0x04002F06 RID: 12038
		public static EventHandler eventHandler12;

		// Token: 0x04002F07 RID: 12039
		public static EventHandler eventHandler13;
	}

	// Token: 0x020008C0 RID: 2240
	public sealed class 1789
	{
		// Token: 0x06004057 RID: 16471 RVA: 0x001900DC File Offset: 0x0018E2DC
		internal void 1()
		{
			this.1.3.25(1052.19(this.2.2 - (float)(1662.70.2() / 10), 0f, Math.Max(0f, this.1.3.17.Y - this.1.3.4())), -0.99f);
		}

		// Token: 0x04002F09 RID: 12041
		public 1784 1;

		// Token: 0x04002F0A RID: 12042
		public 1779 2;
	}

	// Token: 0x020008C1 RID: 2241
	public sealed class 1787
	{
		// Token: 0x06004059 RID: 16473 RVA: 0x00190152 File Offset: 0x0018E352
		internal void 1(object 1, EventArgs 2)
		{
			if (!this.1.5())
			{
				this.1.18();
			}
		}

		// Token: 0x0600405A RID: 16474 RVA: 0x0019016C File Offset: 0x0018E36C
		internal void 2(1621 1, Exception 2)
		{
			this.2 = (1583)3;
			if (2 != null)
			{
				1763.2("osu!(lazer) failed to download. please try again later.", 5000, (1389)2);
				return;
			}
			this.3.7.Remove(this.4);
			this.3.7.Remove(this.5);
			this.3.7.Remove(this.6);
			this.7.SetText("Installation has started in the background, please wait...");
			Process process = 261.Start(1784.48);
			if (process != null)
			{
				process.WaitForExit();
			}
			this.3.Close(false);
			2672.20(1784.48);
			1662.SetMode(1677.Exit, false);
		}

		// Token: 0x04002F0B RID: 12043
		public 1620 1;

		// Token: 0x04002F0C RID: 12044
		public 1583 2;

		// Token: 0x04002F0D RID: 12045
		public 1689 3;

		// Token: 0x04002F0E RID: 12046
		public 1433 4;

		// Token: 0x04002F0F RID: 12047
		public 1433 5;

		// Token: 0x04002F10 RID: 12048
		public 1452 6;

		// Token: 0x04002F11 RID: 12049
		public 1452 7;
	}
}
