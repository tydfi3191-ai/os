using System;
using System.Collections.Generic;

// Token: 0x02000777 RID: 1911
[Serializable]
public sealed class 1992 : 2627
{
	// Token: 0x0600381A RID: 14362 RVA: 0x0015F378 File Offset: 0x0015D578
	public 1992(int 1)
	{
		this.Columns = 1;
		1992.16<float>(out this.ColumnLineWidth, this.Columns + 1, 2f);
		1992.16<float>(out this.ColumnSpacing, this.Columns - 1, 0f);
		1992.16<float>(out this.ColumnWidth, this.Columns, 30f);
		1992.16<float>(out this.LightingNWidth, this.Columns, 0f);
		1992.16<float>(out this.LightingLWidth, this.Columns, 0f);
		1992.17<string>(out this.imageMap, new Action<Dictionary<string, string>>(this.27));
		1992.17<198>(out this.colours, new Action<Dictionary<string, 198>>(this.28));
		1992.17<bool?>(out this.flip, new Action<Dictionary<string, bool?>>(this.29));
		1992.17<1990?>(out this.noteBodyStyle, new Action<Dictionary<string, 1990?>>(this.30));
	}

	// Token: 0x0600381B RID: 14363 RVA: 0x0015F4D2 File Offset: 0x0015D6D2
	public 1992(1992 1) : this(1.Columns)
	{
	}

	// Token: 0x0600381C RID: 14364 RVA: 0x0015F4E0 File Offset: 0x0015D6E0
	internal bool 14()
	{
		bool? splitStagesFromSkin = this.SplitStagesFromSkin;
		if (splitStagesFromSkin == null)
		{
			return this.splitStages;
		}
		return splitStagesFromSkin.GetValueOrDefault();
	}

	// Token: 0x0600381D RID: 14365 RVA: 0x0015F50B File Offset: 0x0015D70B
	internal void 15(bool 1)
	{
		this.splitStages = 1;
	}

	// Token: 0x0600381E RID: 14366 RVA: 0x0015F514 File Offset: 0x0015D714
	private static void 16<T>(out List<T> 1, int 2, T 3)
	{
		1 = new List<T>(Math.Max(2, 0));
		for (int i = 0; i < 2; i++)
		{
			1.Add(3);
		}
	}

	// Token: 0x0600381F RID: 14367 RVA: 0x0015F544 File Offset: 0x0015D744
	private static void 17<T>(out Dictionary<string, T> 1, Action<Dictionary<string, T>> 2)
	{
		Dictionary<string, T> obj;
		1 = (obj = new Dictionary<string, T>());
		2(obj);
	}

	// Token: 0x06003820 RID: 14368 RVA: 0x0015F564 File Offset: 0x0015D764
	protected override void ReadSettings()
	{
		base.5("Mania");
		base.8<float>("ColumnLineWidth", this.ColumnLineWidth, delegate(float 1)
		{
			if (1 > 0f && 1 < 2f)
			{
				return 2f;
			}
			return 1;
		});
		base.6<float>("BarlineHeight", ref this.BarlineHeight);
		base.6<1991>("SpecialStyle", ref this.SpecialStyle);
		base.8<float>("ColumnWidth", this.ColumnWidth, new 2626<float>(1992.1993.instance.1));
		base.8<float>("ColumnSpacing", this.ColumnSpacing, null);
		for (int i = 0; i < this.Columns - 1; i++)
		{
			this.ColumnSpacing[i] = 1052.19(this.ColumnSpacing[i], 0f - this.ColumnWidth[i + 1], float.MaxValue);
		}
		base.8<float>("LightingNWidth", this.LightingNWidth, null);
		base.8<float>("LightingLWidth", this.LightingLWidth, null);
		base.7<string>(this.imageMap);
		base.7<198>(this.colours);
		base.7<bool?>(this.flip);
		base.7<1990?>(this.noteBodyStyle);
		base.6<float>("WidthForNoteHeightScale", ref this.WidthForNoteHeightScale);
		base.6<float>("StageSeparation", ref this.StageSeparation);
		this.StageSeparation = Math.Max(this.StageSeparation, 5f);
		base.6<bool>("SeparateScore", ref this.SeparateScore);
		base.6<bool?>("SplitStages", ref this.SplitStagesFromSkin);
		base.6<bool>("KeysUnderNotes", ref this.KeysUnderNotes);
		base.6<float>("ColumnStart", ref this.ColumnStart);
		base.6<float>("ColumnRight", ref this.ColumnRight);
		base.6<bool>("JudgementLine", ref this.JudgementLine);
		base.6<int>("HitPosition", ref this.HitPosition);
		this.HitPosition = Math.Max(240, Math.Min(this.HitPosition, 480));
		base.6<int>("LightPosition", ref this.LightPosition);
		base.6<int>("ComboPosition", ref this.ComboPosition);
		base.6<int>("ScorePosition", ref this.ScorePosition);
		base.6<bool>("UpsideDown", ref this.UpsideDown);
		base.6<int>("LightFramePerSecond", ref this.LightFramePerSecond);
		if (this.LightFramePerSecond <= 0)
		{
			this.LightFramePerSecond = 24;
		}
		base.6<1989>("ComboBurstStyle", ref this.ComboBurstStyle);
	}

	// Token: 0x06003821 RID: 14369 RVA: 0x0015F7F8 File Offset: 0x0015D9F8
	protected override void WriteSettings()
	{
		base.5("Mania");
		base.10<int>("Keys", this.Columns, 0, true);
		base.11("ColumnWidth", "ColumnWidth", false);
		base.11("ColumnLineWidth", "ColumnLineWidth", false);
		base.11("ColumnSpacing", "ColumnSpacing", false);
		base.11("LightingNWidth", "LightingNWidth", false);
		base.11("LightingLWidth", "LightingLWidth", false);
		base.11("SpecialStyle", "SpecialStyle", false);
		base.11("ColumnStart", "ColumnStart", false);
		base.11("ColumnRight", "ColumnRight", false);
		base.11("JudgementLine", "JudgementLine", false);
		base.11("BarlineHeight", "BarlineHeight", false);
		base.11("HitPosition", "HitPosition", false);
		base.11("LightPosition", "LightPosition", false);
		base.11("ComboPosition", "ComboPosition", false);
		base.11("ScorePosition", "ScorePosition", false);
		base.11("UpsideDown", "UpsideDown", false);
		base.11("LightFramePerSecond", "LightFramePerSecond", false);
		base.11("SeparateScore", "SeparateScore", false);
		base.11("KeysUnderNotes", "KeysUnderNotes", false);
		base.11("SplitStages", "SplitStagesFromSkin", false);
		base.11("StageSeparation", "StageSeparation", false);
		base.11("WidthForNoteHeightScale", "WidthForNoteHeightScale", false);
		base.11("ComboBurstStyle", "ComboBurstStyle", false);
		base.13<string>("imageMap");
		base.13<198>("colours");
		base.13<bool?>("flip");
		base.13<1990?>("noteBodyStyle");
	}

	// Token: 0x06003822 RID: 14370 RVA: 0x0015F9C5 File Offset: 0x0015DBC5
	internal 198 18(string 1)
	{
		return this.colours["Colour" + 1];
	}

	// Token: 0x06003823 RID: 14371 RVA: 0x0015F9E0 File Offset: 0x0015DBE0
	internal 1381 19(string 1, string 2, 1416 3)
	{
		1381 4 = null;
		if (this.imageMap[1] != null)
		{
			4 = 1455.2(this.imageMap[1], 3, null);
		}
		return 4 ?? 1455.2(2, 3, null);
	}

	// Token: 0x06003824 RID: 14372 RVA: 0x0015FA20 File Offset: 0x0015DC20
	internal 1381[] 20(string 1, string 2, 1416 3)
	{
		1381[] array = null;
		if (this.imageMap[1] != null)
		{
			array = 1455.5(this.imageMap[1], 3, true);
		}
		return array ?? 1455.5(2, 3, true);
	}

	// Token: 0x06003825 RID: 14373 RVA: 0x0015FA60 File Offset: 0x0015DC60
	internal bool 21(string 1, int 2, string 3, bool 4)
	{
		if (!this.UpsideDown)
		{
			return false;
		}
		string key = 1 + "FlipWhenUpsideDown" + 3;
		1 = string.Format("{0}FlipWhenUpsideDown{1}{2}", 1, 2, 3);
		bool? flag = this.flip[1];
		if (flag == null)
		{
			return this.flip[key].GetValueOrDefault(4);
		}
		return flag.GetValueOrDefault();
	}

	// Token: 0x06003826 RID: 14374 RVA: 0x0015FACC File Offset: 0x0015DCCC
	internal bool 22(int 1, string 2, bool 3)
	{
		return 2630.5.Version >= 2.5 && this.21("Note", 1, 2, 3);
	}

	// Token: 0x06003827 RID: 14375 RVA: 0x0015FAF4 File Offset: 0x0015DCF4
	internal 1990 23(int 1)
	{
		if (2630.5.Version < 2.5)
		{
			return 1990.Stretch;
		}
		1990? 2 = this.noteBodyStyle[string.Format("NoteBodyStyle{0}", 1)];
		if (2 == null)
		{
			return this.noteBodyStyle["NoteBodyStyle"].GetValueOrDefault(1990.RepeatBottom);
		}
		return 2.GetValueOrDefault();
	}

	// Token: 0x06003828 RID: 14376 RVA: 0x0015FB5E File Offset: 0x0015DD5E
	internal float 24(int 1)
	{
		return this.26(1, this.LightingNWidth);
	}

	// Token: 0x06003829 RID: 14377 RVA: 0x0015FB6D File Offset: 0x0015DD6D
	internal float 25(int 1)
	{
		return this.26(1, this.LightingLWidth);
	}

	// Token: 0x0600382A RID: 14378 RVA: 0x0015FB7C File Offset: 0x0015DD7C
	private float 26(int 1, List<float> 2)
	{
		if (2630.5.Version < 2.5)
		{
			return 1f;
		}
		return ((2[1] > 0f) ? 2[1] : this.ColumnWidth[1]) / 30f;
	}

	// Token: 0x0600382B RID: 14379 RVA: 0x0015FBD0 File Offset: 0x0015DDD0
	internal 1992 Clone()
	{
		1992 <<EMPTY_NAME>> = (1992)base.MemberwiseClone();
		<<EMPTY_NAME>>.imageMap = new Dictionary<string, string>(this.imageMap);
		<<EMPTY_NAME>>.colours = new Dictionary<string, 198>(this.colours);
		<<EMPTY_NAME>>.flip = new Dictionary<string, bool?>(this.flip);
		<<EMPTY_NAME>>.noteBodyStyle = new Dictionary<string, 1990?>(this.noteBodyStyle);
		<<EMPTY_NAME>>.ColumnLineWidth = new List<float>(this.ColumnLineWidth);
		<<EMPTY_NAME>>.ColumnWidth = new List<float>(this.ColumnWidth);
		<<EMPTY_NAME>>.ColumnSpacing = new List<float>(this.ColumnSpacing);
		<<EMPTY_NAME>>.LightingNWidth = new List<float>(this.LightingNWidth);
		<<EMPTY_NAME>>.LightingLWidth = new List<float>(this.LightingLWidth);
		return <<EMPTY_NAME>>;
	}

	// Token: 0x0600382C RID: 14380 RVA: 0x0015FC84 File Offset: 0x0015DE84
	private void 27(Dictionary<string, string> 1)
	{
		for (int i = 0; i < this.Columns; i++)
		{
			string key = string.Format("KeyImage{0}", i);
			string value = 1[string.Format("KeyImage{0}D", i)] = null;
			1[key] = value;
			string key2 = string.Format("NoteImage{0}", i);
			string key3 = string.Format("NoteImage{0}H", i);
			string key4 = string.Format("NoteImage{0}L", i);
			string value2 = 1[string.Format("NoteImage{0}T", i)] = null;
			string value3 = 1[key4] = value2;
			value = (1[key3] = value3);
			1[key2] = value;
		}
		1["StageLeft"] = null;
		1["StageRight"] = null;
		1["StageBottom"] = null;
		1["StageHint"] = null;
		1["StageLight"] = null;
		1["Hit0"] = null;
		1["Hit50"] = null;
		1["Hit100"] = null;
		1["Hit200"] = null;
		1["Hit300"] = null;
		1["Hit300g"] = null;
		1["LightingN"] = null;
		1["LightingL"] = null;
		1["WarningArrow"] = null;
	}

	// Token: 0x0600382D RID: 14381 RVA: 0x0015FE04 File Offset: 0x0015E004
	private void 28(Dictionary<string, 198> 1)
	{
		for (int i = 1; i <= this.Columns; i++)
		{
			1[string.Format("Colour{0}", i)] = 198.Black;
			1[string.Format("ColourLight{0}", i)] = 198.White;
		}
		1["ColourColumnLine"] = 198.White;
		1["ColourJudgementLine"] = 198.White;
		1["ColourBarline"] = 198.White;
		1["ColourBreak"] = 198.Red;
		1["ColourHold"] = new 198(byte.MaxValue, 199, 51);
		1["ColourKeyWarning"] = 198.Black;
	}

	// Token: 0x0600382E RID: 14382 RVA: 0x0015FEC4 File Offset: 0x0015E0C4
	private void 29(Dictionary<string, bool?> 1)
	{
		for (int i = -1; i < this.Columns; i++)
		{
			string str = (i < 0) ? string.Empty : i.ToString();
			1["KeyFlipWhenUpsideDown" + str] = null;
			string key = "NoteFlipWhenUpsideDown" + str;
			string key2 = "NoteFlipWhenUpsideDown" + str + "H";
			string key3 = "NoteFlipWhenUpsideDown" + str + "L";
			string key4 = "NoteFlipWhenUpsideDown" + str + "T";
			bool? flag = null;
			1[key4] = flag;
			bool? value = flag;
			bool? value2 = 1[key3] = value;
			bool? value3 = 1[key2] = value2;
			1[key] = value3;
		}
	}

	// Token: 0x0600382F RID: 14383 RVA: 0x0015FF94 File Offset: 0x0015E194
	private void 30(Dictionary<string, 1990?> 1)
	{
		for (int i = -1; i < this.Columns; i++)
		{
			string str = (i < 0) ? string.Empty : i.ToString();
			1["NoteBodyStyle" + str] = null;
		}
	}

	// Token: 0x04002986 RID: 10630
	internal List<float> ColumnLineWidth;

	// Token: 0x04002987 RID: 10631
	internal List<float> ColumnSpacing;

	// Token: 0x04002988 RID: 10632
	internal List<float> ColumnWidth;

	// Token: 0x04002989 RID: 10633
	internal List<float> LightingNWidth;

	// Token: 0x0400298A RID: 10634
	internal List<float> LightingLWidth;

	// Token: 0x0400298B RID: 10635
	internal 1991 SpecialStyle;

	// Token: 0x0400298C RID: 10636
	internal 1989 ComboBurstStyle = 1989.Right;

	// Token: 0x0400298D RID: 10637
	internal float BarlineHeight = 1.2f;

	// Token: 0x0400298E RID: 10638
	internal bool JudgementLine = true;

	// Token: 0x0400298F RID: 10639
	internal bool UpsideDown;

	// Token: 0x04002990 RID: 10640
	internal bool SeparateScore = true;

	// Token: 0x04002991 RID: 10641
	internal bool KeysUnderNotes;

	// Token: 0x04002992 RID: 10642
	private bool splitStages;

	// Token: 0x04002993 RID: 10643
	internal bool? SplitStagesFromSkin;

	// Token: 0x04002994 RID: 10644
	internal float ColumnStart = 136f;

	// Token: 0x04002995 RID: 10645
	internal float ColumnRight = 19f;

	// Token: 0x04002996 RID: 10646
	internal int HitPosition = 402;

	// Token: 0x04002997 RID: 10647
	internal int LightPosition = 413;

	// Token: 0x04002998 RID: 10648
	internal int ComboPosition = 111;

	// Token: 0x04002999 RID: 10649
	internal int ScorePosition = 325;

	// Token: 0x0400299A RID: 10650
	internal float StageSeparation = 40f;

	// Token: 0x0400299B RID: 10651
	internal float WidthForNoteHeightScale;

	// Token: 0x0400299C RID: 10652
	internal readonly int Columns;

	// Token: 0x0400299D RID: 10653
	internal int LightFramePerSecond = 60;

	// Token: 0x0400299E RID: 10654
	private Dictionary<string, string> imageMap;

	// Token: 0x0400299F RID: 10655
	private Dictionary<string, 198> colours;

	// Token: 0x040029A0 RID: 10656
	private Dictionary<string, bool?> flip;

	// Token: 0x040029A1 RID: 10657
	private Dictionary<string, 1990?> noteBodyStyle;

	// Token: 0x02000778 RID: 1912
	[Serializable]
	public sealed class 1993
	{
		// Token: 0x06003830 RID: 14384 RVA: 0x0015FFDF File Offset: 0x0015E1DF
		internal float 1(float 1)
		{
			return 1052.19(1, 5f, 100f);
		}

		// Token: 0x040029A2 RID: 10658
		public static readonly 1992.1993 instance = new 1992.1993();

		// Token: 0x040029A3 RID: 10659
		public static 2626<float> _recoveredType078611117;

		// Token: 0x040029A4 RID: 10660
		public static 2626<float> _recoveredType078611118;
	}
}
