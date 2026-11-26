using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

// Token: 0x02000709 RID: 1801
[276]
[Serializable]
public sealed class 2137 : 2627
{
	// Token: 0x06003513 RID: 13587 RVA: 0x001471D4 File Offset: 0x001453D4
	public 2137()
	{
	}

	// Token: 0x06003514 RID: 13588 RVA: 0x001472A9 File Offset: 0x001454A9
	public 2137(2137 1) : this()
	{
	}

	// Token: 0x06003515 RID: 13589 RVA: 0x001472B1 File Offset: 0x001454B1
	internal string 14()
	{
		return Path.Combine(2630.1(), this.RawName);
	}

	// Token: 0x06003516 RID: 13590 RVA: 0x001472C3 File Offset: 0x001454C3
	internal string 15()
	{
		return this.SkinName + ".osk";
	}

	// Token: 0x06003517 RID: 13591 RVA: 0x001472D8 File Offset: 0x001454D8
	protected override void ReadSettings()
	{
		base.5("General");
		base.6<string>("Name", ref this.SkinName);
		base.6<string>("Author", ref this.SkinAuthor);
		base.6<bool>("SliderBallFlip", ref this.SliderBallFlip);
		base.6<bool>("SliderBallDontRotate", ref this.SliderBallFlip);
		base.6<bool>("CursorRotate", ref this.CursorRotate);
		base.6<bool>("CursorExpand", ref this.CursorExpand);
		base.6<bool>("CursorCentre", ref this.CursorCentre);
		base.6<int>("SliderBallFrames", ref this.SliderBallFrames);
		base.6<bool>("HitCircleOverlayAboveNumber", ref this.OverlayAboveNumber);
		base.6<bool>("HitCircleOverlayAboveNumer", ref this.OverlayAboveNumber);
		base.6<bool>("SpinnerFrequencyModulate", ref this.SpinnerFrequencyModulate);
		base.6<bool>("LayeredHitSounds", ref this.LayeredHitSounds);
		base.6<bool>("SpinnerFadePlayfield", ref this.SpinnerFadePlayfield);
		base.6<bool>("SpinnerNoBlink", ref this.SpinnerNoBlink);
		base.6<bool>("AllowSliderBallTint", ref this.AllowSliderBallTint);
		base.6<int>("AnimationFramerate", ref this.AnimationFramerate);
		base.6<bool>("CursorTrailRotate", ref this.CursorTrailRotate);
		base.8<int>("CustomComboBurstSounds", this.ComboSoundBursts, null);
		base.6<bool>("ComboBurstRandom", ref this.ComboBurstRandom);
		base.6<2634>("SliderStyle", ref this.SliderStyle);
		string text = null;
		if (base.6<string>("Version", ref text))
		{
			this.isLatestVersion = (text == "latest");
			this.Version = (this.isLatestVersion ? 2.7 : Convert.ToDouble(text, 1662.18));
		}
		this.AllowTransparentColours = false;
		base.5("Colours");
		this.Colours = base.9<198>();
		bool flag = this.Colours.ContainsKey("Combo1");
		foreach (KeyValuePair<string, 198> keyValuePair in 2137.defaultColours)
		{
			if (!this.Colours.ContainsKey(keyValuePair.Key) && (!flag || !keyValuePair.Key.StartsWith("Combo")))
			{
				this.Colours[keyValuePair.Key] = keyValuePair.Value;
			}
		}
		foreach (KeyValuePair<string, 198> keyValuePair2 in this.Colours)
		{
			if (2137.regex.IsMatch(keyValuePair2.Key))
			{
				this.TriangleColours.Add(keyValuePair2.Value);
			}
		}
		this.AllowTransparentColours = true;
		base.5("Fonts");
		base.6<string>("HitCirclePrefix", ref this.FontHitCircle);
		base.6<int>("HitCircleOverlap", ref this.FontHitCircleOverlap);
		base.6<string>("ScorePrefix", ref this.FontScore);
		base.6<string>("ComboPrefix", ref this.FontCombo);
		base.6<int>("ScoreOverlap", ref this.FontScoreOverlap);
		base.6<int>("ComboOverlap", ref this.FontComboOverlap);
	}

	// Token: 0x06003518 RID: 13592 RVA: 0x00147630 File Offset: 0x00145830
	protected override void WriteSettings()
	{
		base.5("General");
		base.11("Name", "SkinName", false);
		base.11("Author", "SkinAuthor", false);
		base.11("SliderBallFlip", "SliderBallFlip", false);
		base.11("CursorRotate", "CursorRotate", false);
		base.11("CursorExpand", "CursorExpand", false);
		base.11("CursorCentre", "CursorCentre", false);
		base.11("SliderBallFrames", "SliderBallFrames", false);
		base.11("HitCircleOverlayAboveNumber", "OverlayAboveNumber", false);
		base.11("SpinnerFrequencyModulate", "SpinnerFrequencyModulate", false);
		base.11("LayeredHitSounds", "LayeredHitSounds", false);
		base.11("SpinnerFadePlayfield", "SpinnerFadePlayfield", false);
		base.11("SpinnerNoBlink", "SpinnerNoBlink", false);
		base.11("AllowSliderBallTint", "AllowSliderBallTint", false);
		base.11("AnimationFramerate", "AnimationFramerate", false);
		base.11("CursorTrailRotate", "CursorTrailRotate", false);
		base.11("CustomComboBurstSounds", "ComboSoundBursts", false);
		base.11("ComboBurstRandom", "ComboBurstRandom", false);
		base.10<int>("SliderStyle", (int)this.SliderStyle, 2, false);
		if (this.isLatestVersion)
		{
			base.10<string>("Version", "latest", "latest", false);
		}
		else
		{
			base.11("Version", "Version", false);
		}
		base.5("Colours");
		this.AllowTransparentColours = false;
		foreach (KeyValuePair<string, 198> keyValuePair in this.Colours)
		{
			198 <<EMPTY_NAME>>;
			if (2137.defaultColours.TryGetValue(keyValuePair.Key, out <<EMPTY_NAME>>))
			{
				base.10<198>(keyValuePair.Key, this.Colours[keyValuePair.Key], <<EMPTY_NAME>>, false);
			}
			else
			{
				base.10<198?>(keyValuePair.Key, new 198?(this.Colours[keyValuePair.Key]), null, false);
			}
		}
		base.5("Fonts");
		base.11("HitCirclePrefix", "FontHitCircle", false);
		base.11("HitCircleOverlap", "FontHitCircleOverlap", false);
		base.11("ScorePrefix", "FontScore", false);
		base.11("ComboPrefix", "FontCombo", false);
		base.11("ScoreOverlap", "FontScoreOverlap", false);
		base.11("ComboOverlap", "FontComboOverlap", false);
	}

	// Token: 0x0400274E RID: 10062
	private static Dictionary<string, 198> defaultColours = new Dictionary<string, 198>
	{
		{
			"Combo1",
			2630.7[0]
		},
		{
			"Combo2",
			2630.7[1]
		},
		{
			"Combo3",
			2630.7[2]
		},
		{
			"Combo4",
			2630.7[3]
		},
		{
			"Combo5",
			2630.7[4]
		},
		{
			"MenuGlow",
			new 198(128, 128, 160)
		},
		{
			"SliderBall",
			new 198(2, 170, byte.MaxValue)
		},
		{
			"SliderBorder",
			new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue)
		},
		{
			"SpinnerApproachCircle",
			new 198(77, 139, 217)
		},
		{
			"SongSelectActiveText",
			198.Black
		},
		{
			"SongSelectInactiveText",
			198.White
		},
		{
			"StarBreakAdditive",
			198.LightPink
		},
		{
			"InputOverlayText",
			198.Black
		}
	};

	// Token: 0x0400274F RID: 10063
	internal Dictionary<string, 198> Colours = new Dictionary<string, 198>(2137.defaultColours);

	// Token: 0x04002750 RID: 10064
	internal List<198> TriangleColours = new List<198>();

	// Token: 0x04002751 RID: 10065
	internal bool CursorCentre = true;

	// Token: 0x04002752 RID: 10066
	internal bool CursorExpand = true;

	// Token: 0x04002753 RID: 10067
	internal bool CursorRotate = true;

	// Token: 0x04002754 RID: 10068
	internal string SkinAuthor = string.Empty;

	// Token: 0x04002755 RID: 10069
	internal string SkinName = "Unknown";

	// Token: 0x04002756 RID: 10070
	internal bool SliderBallFlip;

	// Token: 0x04002757 RID: 10071
	internal int SliderBallFrames = 10;

	// Token: 0x04002758 RID: 10072
	internal string RawName;

	// Token: 0x04002759 RID: 10073
	internal string FontHitCircle = "default";

	// Token: 0x0400275A RID: 10074
	internal string FontScore = "score";

	// Token: 0x0400275B RID: 10075
	internal int FontScoreOverlap;

	// Token: 0x0400275C RID: 10076
	internal string FontCombo = "score";

	// Token: 0x0400275D RID: 10077
	internal int FontComboOverlap;

	// Token: 0x0400275E RID: 10078
	internal int FontHitCircleOverlap = -2;

	// Token: 0x0400275F RID: 10079
	internal bool OverlayAboveNumber = true;

	// Token: 0x04002760 RID: 10080
	internal bool SpinnerFrequencyModulate = true;

	// Token: 0x04002761 RID: 10081
	internal bool LayeredHitSounds = true;

	// Token: 0x04002762 RID: 10082
	internal bool SpinnerFadePlayfield = !2630.21();

	// Token: 0x04002763 RID: 10083
	internal bool SpinnerNoBlink;

	// Token: 0x04002764 RID: 10084
	internal int AnimationFramerate = -1;

	// Token: 0x04002765 RID: 10085
	internal bool CursorTrailRotate;

	// Token: 0x04002766 RID: 10086
	internal List<int> ComboSoundBursts = new List<int>();

	// Token: 0x04002767 RID: 10087
	internal 2634 SliderStyle = 2634.MmSliders;

	// Token: 0x04002768 RID: 10088
	internal bool AllowSliderBallTint;

	// Token: 0x04002769 RID: 10089
	internal bool ComboBurstRandom;

	// Token: 0x0400276A RID: 10090
	private bool isLatestVersion;

	// Token: 0x0400276B RID: 10091
	internal double Version = 1.0;

	// Token: 0x0400276C RID: 10092
	private static readonly Regex regex = new Regex("Triangle\\d+");
}
