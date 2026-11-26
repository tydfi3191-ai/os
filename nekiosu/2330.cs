using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

// Token: 0x020005A2 RID: 1442
public sealed class 2330 : UserControl
{
	// Token: 0x06002C6E RID: 11374 RVA: 0x000F6298 File Offset: 0x000F4498
	private void 1(object 1, EventArgs 2)
	{
		this.1.27(2335.Design);
	}

	// Token: 0x06002C6F RID: 11375 RVA: 0x000F62A6 File Offset: 0x000F44A6
	private void 2(object 1, EventArgs 2)
	{
		this.1.27(2335.Timing);
	}

	// Token: 0x06002C70 RID: 11376 RVA: 0x000F62B4 File Offset: 0x000F44B4
	private void 3(object 1, EventArgs 2)
	{
		this.1.28(2337.Large, true);
	}

	// Token: 0x06002C71 RID: 11377 RVA: 0x000F62C4 File Offset: 0x000F44C4
	private void 4(object 1, EventArgs 2)
	{
		this.1.28(2337.Medium, true);
	}

	// Token: 0x06002C72 RID: 11378 RVA: 0x000F62D4 File Offset: 0x000F44D4
	private void 5(object 1, EventArgs 2)
	{
		this.1.28(2337.Small, true);
	}

	// Token: 0x06002C73 RID: 11379 RVA: 0x000F62E3 File Offset: 0x000F44E3
	private void 6(object 1, EventArgs 2)
	{
		this.1.74.30(2357.GridSnap);
	}

	// Token: 0x06002C74 RID: 11380 RVA: 0x000F62F6 File Offset: 0x000F44F6
	private void 7(object 1, EventArgs 2)
	{
		this.1.74.24(2);
	}

	// Token: 0x06002C75 RID: 11381 RVA: 0x000F6309 File Offset: 0x000F4509
	private void 8(object 1, EventArgs 2)
	{
		this.1.74.24(3);
	}

	// Token: 0x06002C76 RID: 11382 RVA: 0x000F631C File Offset: 0x000F451C
	internal void 9(int 1)
	{
		this.45.Checked = (1 == 1);
		this.46.Checked = (1 == 2);
		this.47.Checked = (1 == 4);
		this.48.Checked = (1 == 8);
		this.49.Checked = (1 == 3);
		this.62.Checked = (1 == 6);
	}

	// Token: 0x06002C77 RID: 11383 RVA: 0x000F6384 File Offset: 0x000F4584
	private void 10(object 1, EventArgs 2)
	{
		this.1.31 = !this.1.31;
		this.111.Checked = this.1.31;
		1763.2(this.1.31 ? 1568.1(2679.EditorModeCompose_LiveMappingEnabled) : 1568.1(2679.EditorModeCompose_LiveMappingDisabled), 3000, (1389)0);
	}

	// Token: 0x06002C78 RID: 11384 RVA: 0x000F63EE File Offset: 0x000F45EE
	private void 11(object 1, EventArgs 2)
	{
		this.1.40();
	}

	// Token: 0x06002C79 RID: 11385 RVA: 0x000F63FB File Offset: 0x000F45FB
	private void 12(object 1, EventArgs 2)
	{
		this.1.74.57();
	}

	// Token: 0x06002C7A RID: 11386 RVA: 0x000F640D File Offset: 0x000F460D
	internal 2330()
	{
		this.26();
		this.25();
	}

	// Token: 0x06002C7B RID: 11387 RVA: 0x000F6421 File Offset: 0x000F4621
	internal void 13()
	{
		this.23();
		base.Parent = null;
		base.Dispose();
	}

	// Token: 0x06002C7C RID: 11388 RVA: 0x000F6438 File Offset: 0x000F4638
	internal void 14()
	{
		1262 <<EMPTY_NAME>> = this.1.7.21;
		this.84.Enabled = (<<EMPTY_NAME>>.25 != 0);
		this.83.Enabled = (<<EMPTY_NAME>>.25 != 0);
		this.61.Enabled = !<<EMPTY_NAME>>.61;
		this.85.Enabled = (!<<EMPTY_NAME>>.61 || <<EMPTY_NAME>>.53() != null);
		this.73.Enabled = !<<EMPTY_NAME>>.61;
		this.101.Enabled = <<EMPTY_NAME>>.61;
		this.106.Enabled = <<EMPTY_NAME>>.52(<<EMPTY_NAME>>.67());
		this.108.Checked = 1304.80;
		this.107.Checked = 1304.79;
		this.121.Checked = 1304.82;
		this.122.Checked = 1304.83;
		this.123.Checked = 1304.84;
		this.124.Checked = 1304.85;
		if (<<EMPTY_NAME>>.3() == 2147.OsuMania)
		{
			this.118.Visible = true;
			this.112.Enabled = true;
		}
		else
		{
			this.112.Enabled = false;
		}
		this.15();
		if (2255.54 != null)
		{
			this.41.Checked = 2255.54[2357.GridSnap];
		}
	}

	// Token: 0x06002C7D RID: 11389 RVA: 0x00005ADD File Offset: 0x00003CDD
	private void 15()
	{
	}

	// Token: 0x06002C7E RID: 11390 RVA: 0x000F65BD File Offset: 0x000F47BD
	private void 16(object 1, EventArgs 2)
	{
		1662.82(false);
	}

	// Token: 0x06002C7F RID: 11391 RVA: 0x000F65C5 File Offset: 0x000F47C5
	internal void 17(2335 1)
	{
		this.22.Checked = (1 == 2335.Compose);
		this.23.Checked = (1 == 2335.Design);
		this.24.Checked = (1 == 2335.Timing);
	}

	// Token: 0x06002C80 RID: 11392 RVA: 0x000F65F4 File Offset: 0x000F47F4
	internal void 18(double 1)
	{
		this.26.Checked = (1 == 25.0);
		this.27.Checked = (1 == 50.0);
		this.28.Checked = (1 == 75.0);
		this.29.Checked = (1 == 100.0);
	}

	// Token: 0x06002C81 RID: 11393 RVA: 0x000F665D File Offset: 0x000F485D
	internal void 19(2337 1)
	{
		this.36.Checked = (1 == 2337.Large);
		this.37.Checked = (1 == 2337.Medium);
		this.38.Checked = (1 == 2337.Small);
		this.39.Checked = (1 == 2337.Tiny);
	}

	// Token: 0x06002C82 RID: 11394 RVA: 0x000F669D File Offset: 0x000F489D
	internal void 20(bool 1)
	{
		this.41.Checked = 1;
	}

	// Token: 0x06002C83 RID: 11395 RVA: 0x000F669D File Offset: 0x000F489D
	internal void 21(bool 1)
	{
		this.41.Checked = 1;
	}

	// Token: 0x06002C84 RID: 11396 RVA: 0x000F66AB File Offset: 0x000F48AB
	internal void 22(2263 1)
	{
		this.1 = 1;
	}

	// Token: 0x06002C85 RID: 11397 RVA: 0x000F66B4 File Offset: 0x000F48B4
	internal void 23()
	{
		this.1 = null;
	}

	// Token: 0x06002C86 RID: 11398 RVA: 0x000F66C0 File Offset: 0x000F48C0
	private void 24(1189 1)
	{
		DialogResult dialogResult;
		if (this.1.8.13)
		{
			dialogResult = MessageBox.Show(1568.1(2679.EditorControl_BeatmapMustBeSavedDialog), "osu!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			if (dialogResult == DialogResult.Cancel)
			{
				return;
			}
			if (dialogResult == DialogResult.Yes)
			{
				this.1.66();
			}
		}
		else
		{
			dialogResult = DialogResult.Yes;
		}
		1();
		this.1.34(this.1.7.21, dialogResult == DialogResult.No, true);
	}

	// Token: 0x06002C87 RID: 11399 RVA: 0x000F6738 File Offset: 0x000F4938
	private void 25()
	{
		this.4.Text = 1568.1(2679.General_File);
		this.5.Text = 1568.1(2679.SongSelection_Edit);
		this.6.Text = 1568.1(2679.General_View);
		this.7.Text = 1568.1(2679.Editor_Compose);
		this.97.Text = 1568.1(2679.Editor_Design);
		this.42.Text = 1568.1(2679.Editor_Timing);
		this.82.Text = 1568.1(2679.General_Web);
		this.8.Text = 1568.1(2679.General_Help);
		this.9.Text = 1568.1(2679.EditorMenuItem_File_ClearAllNotes);
		this.59.Text = 1568.1(2679.EditorMenuItem_File_OpenDifficulty);
		this.116.Text = 1568.1(2679.EditorMenuItem_File_ForEditing);
		this.117.Text = 1568.1(2679.EditorMenuItem_File_ForReference);
		this.11.Text = 1568.1(2679.General_Save);
		this.60.Text = 1568.1(2679.EditorMenuItem_File_SaveAsNewDifficulty);
		this.96.Text = 1568.1(2679.EditorMenuItem_File_RevertToSaved);
		this.10.Text = 1568.1(2679.EditorMenuItem_File_RevertToSavedFull);
		this.77.Text = 1568.1(2679.EditorMenuItem_File_TestBeatmap);
		this.94.Text = 1568.1(2679.EditorMenuItem_File_OpenAiMod);
		this.73.Text = 1568.1(2679.EditorMenuItem_File_UploadBeatmap);
		this.61.Text = 1568.1(2679.EditorMenuItem_File_ExportPackage);
		this.101.Text = 1568.1(2679.EditorMenuItem_File_ExtractMapPackage);
		this.114.Text = 1568.1(2679.EditorMenuItem_File_ImportFrom);
		this.115.Text = "bms/bme";
		this.85.Text = 1568.1(2679.EditorMenuItem_File_OpenSongFolder);
		this.87.Text = 1568.1(2679.EditorMenuItem_File_OpenOsuInNotepad);
		this.106.Text = 1568.1(2679.EditorMenuItem_File_OpenOsbInNotepad);
		this.12.Text = 1568.1(2679.EditorMenuItem_File_Exit);
		this.65.Text = 1568.1(2679.EditorMenuItem_Edit_Undo);
		this.66.Text = 1568.1(2679.EditorMenuItem_Edit_Redo);
		this.13.Text = 1568.1(2679.EditorMenuItem_Edit_Cut);
		this.14.Text = 1568.1(2679.EditorMenuItem_Edit_Copy);
		this.15.Text = 1568.1(2679.EditorMenuItem_Edit_Paste);
		this.16.Text = 1568.1(2679.General_Delete);
		this.17.Text = 1568.1(2679.EditorMenuItem_Edit_SelectAll);
		this.19.Text = 1568.1(2679.EditorMenuItem_Edit_Clone);
		this.58.Text = 1568.1(2679.EditorMenuItem_Edit_ReverseSelection);
		this.30.Text = 1568.1(2679.EditorMenuItem_Edit_FlipHorizontally);
		this.31.Text = 1568.1(2679.EditorMenuItem_Edit_FlipVertically);
		this.63.Text = 1568.1(2679.EditorMenuItem_Edit_Rotate90Clockwise);
		this.64.Text = 1568.1(2679.EditorMenuItem_Edit_Rotate90Anticlockwise);
		this.89.Text = 1568.1(2679.EditorMenuItem_Edit_RotateBy);
		this.105.Text = 1568.1(2679.EditorMenuItem_Edit_ScaleBy);
		this.88.Text = 1568.1(2679.EditorMenuItem_Edit_ResetSelectedObjectsSamples);
		this.93.Text = 1568.1(2679.EditorMenuItem_Edit_ResetAllSamples);
		this.103.Text = 1568.1(2679.EditorMenuItem_Edit_ResetComboColours);
		this.104.Text = 1568.1(2679.EditorMenuItem_Edit_ResetBreaks);
		this.33.Text = 1568.1(2679.EditorMenuItem_Edit_NudgeBackward);
		this.34.Text = 1568.1(2679.EditorMenuItem_Edit_NudgeForward);
		this.22.Text = 1568.1(2679.Editor_Compose);
		this.23.Text = 1568.1(2679.Editor_Design);
		this.24.Text = 1568.1(2679.Editor_Timing);
		this.78.Text = 1568.1(2679.EditorMenuItem_View_SongSetup);
		this.91.Text = 1568.1(2679.EditorMenuItem_View_TimingSetup);
		this.120.Text = 1568.1(2679.Options_Audio_Volume);
		this.35.Text = 1568.1(2679.EditorMenuItem_View_GridLevel);
		this.36.Text = 1568.1(2679.EditorMenuItem_View_MostSparse);
		this.37.Text = "2";
		this.38.Text = "3";
		this.39.Text = 1568.1(2679.EditorMenuItem_View_MostPrecise);
		this.107.Text = 1568.1(2679.EditorMenuItem_View_ShowVideo);
		this.119.Text = 1568.1(2679.EditorMenuItem_View_ShowSampleName);
		this.121.Text = 1568.1(2679.Options_Editor_Snaking_Sliders);
		this.122.Text = 1568.1(2679.Options_Editor_Hit_Animations);
		this.123.Text = 1568.1(2679.Options_Editor_Follow_Points);
		this.124.Text = 1568.1(2679.Options_Editor_Stacking);
		this.44.Text = 1568.1(2679.EditorMenuItem_Compose_SnapDivisor);
		this.45.Text = 1568.1(2679.EditorMenuItem_Compose_FullBeats);
		this.46.Text = 1568.1(2679.EditorMenuItem_Compose_HalfBeats);
		this.47.Text = 1568.1(2679.EditorMenuItem_Compose_QuarterBeats);
		this.48.Text = 1568.1(2679.EditorMenuItem_Compose_EighthBeats);
		this.49.Text = 1568.1(2679.EditorMenuItem_Compose_Triplets);
		this.62.Text = 1568.1(2679.EditorMenuItem_Compose_DoubleTriplets);
		this.25.Text = 1568.1(2679.EditorMenuItem_Compose_AudioRate);
		this.26.Text = "25%";
		this.27.Text = "50%";
		this.28.Text = "75%";
		this.29.Text = "100%";
		this.41.Text = 1568.1(2679.EditorMenuItem_Compose_GridSnapping);
		this.109.Text = 1568.1(2679.EditorMenuItem_Compose_CreatePolygonCircles);
		this.110.Text = 1568.1(2679.EditorMenuItem_Compose_ConvertSliderToStream);
		this.111.Text = 1568.1(2679.EditorMenuItem_Compose_EnableLiveMappingMode);
		this.112.Text = 1568.1(2679.EditorMenuItem_Compose_SampleImport);
		this.118.Text = 1568.1(2679.EditorMenuItem_Compose_AutoVolumeBalance);
		this.98.Text = 1568.1(2679.EditorMenuItem_Design_MoveAllElementsInTime);
		this.74.Text = 1568.1(2679.EditorMenuItem_Timing_TimeSignature);
		this.75.Text = 1568.1(2679.EditorMenuItem_Timing_44Time);
		this.76.Text = 1568.1(2679.EditorMenuItem_Timing_34Time);
		this.72.Text = 1568.1(2679.EditorMenuItem_Timing_MetronomeClicks);
		this.90.Text = 1568.1(2679.EditorMenuItem_Timing_AddTimingSection);
		this.51.Text = 1568.1(2679.EditorMenuItem_Timing_AddInheritingSection);
		this.52.Text = 1568.1(2679.EditorMenuItem_Timing_ResetCurrentSection);
		this.53.Text = 1568.1(2679.EditorMenuItem_Timing_DeleteTimingSection);
		this.56.Text = 1568.1(2679.EditorMenuItem_Timing_ResnapCurrentSection);
		this.43.Text = 1568.1(2679.EditorMenuItem_View_TimingSetup);
		this.68.Text = 1568.1(2679.EditorMenuItem_Timing_ResnapAllNotes);
		this.113.Text = 1568.1(2679.EditorMenuItem_Timing_MoveAllNotesInTime);
		this.71.Text = 1568.1(2679.EditorMenuItem_Timing_RecalculateSliderLengths);
		this.55.Text = 1568.1(2679.EditorMenuItem_Timing_DeleteAllTimingSections);
		this.70.Text = 1568.1(2679.EditorMenuItem_Timing_SetCurrentPositionAsPreviewPoint);
		this.84.Text = 1568.1(2679.EditorMenuItem_Web_ThisBeatmapsInformationPage);
		this.83.Text = 1568.1(2679.EditorMenuItem_Web_ThisBeatmapsThread);
		this.21.Text = 1568.1(2679.EditorMenuItem_Help_ShowInGameHelp);
		this.81.Text = 1568.1(2679.EditorMenuItem_Help_ViewFAQ);
	}

	// Token: 0x06002C88 RID: 11400 RVA: 0x000F6F92 File Offset: 0x000F5192
	protected override void Dispose(bool 1)
	{
		this.1 = null;
		1662.8 = null;
		if (1 && this.2 != null)
		{
			this.2.Dispose();
		}
		base.Dispose(1);
	}

	// Token: 0x06002C89 RID: 11401 RVA: 0x000F6FC0 File Offset: 0x000F51C0
	private void 26()
	{
		this.3 = new MenuStrip();
		this.4 = new ToolStripMenuItem();
		this.9 = new ToolStripMenuItem();
		this.59 = new ToolStripMenuItem();
		this.116 = new ToolStripMenuItem();
		this.117 = new ToolStripMenuItem();
		this.11 = new ToolStripMenuItem();
		this.60 = new ToolStripMenuItem();
		this.95 = new ToolStripSeparator();
		this.96 = new ToolStripMenuItem();
		this.10 = new ToolStripMenuItem();
		this.79 = new ToolStripSeparator();
		this.77 = new ToolStripMenuItem();
		this.94 = new ToolStripMenuItem();
		this.102 = new ToolStripSeparator();
		this.73 = new ToolStripMenuItem();
		this.61 = new ToolStripMenuItem();
		this.101 = new ToolStripMenuItem();
		this.114 = new ToolStripMenuItem();
		this.115 = new ToolStripMenuItem();
		this.86 = new ToolStripSeparator();
		this.85 = new ToolStripMenuItem();
		this.87 = new ToolStripMenuItem();
		this.106 = new ToolStripMenuItem();
		this.80 = new ToolStripSeparator();
		this.12 = new ToolStripMenuItem();
		this.5 = new ToolStripMenuItem();
		this.65 = new ToolStripMenuItem();
		this.66 = new ToolStripMenuItem();
		this.67 = new ToolStripSeparator();
		this.13 = new ToolStripMenuItem();
		this.14 = new ToolStripMenuItem();
		this.15 = new ToolStripMenuItem();
		this.16 = new ToolStripMenuItem();
		this.18 = new ToolStripSeparator();
		this.17 = new ToolStripMenuItem();
		this.19 = new ToolStripMenuItem();
		this.32 = new ToolStripSeparator();
		this.58 = new ToolStripMenuItem();
		this.30 = new ToolStripMenuItem();
		this.31 = new ToolStripMenuItem();
		this.63 = new ToolStripMenuItem();
		this.64 = new ToolStripMenuItem();
		this.89 = new ToolStripMenuItem();
		this.105 = new ToolStripMenuItem();
		this.92 = new ToolStripSeparator();
		this.88 = new ToolStripMenuItem();
		this.93 = new ToolStripMenuItem();
		this.103 = new ToolStripMenuItem();
		this.104 = new ToolStripMenuItem();
		this.20 = new ToolStripSeparator();
		this.33 = new ToolStripMenuItem();
		this.34 = new ToolStripMenuItem();
		this.6 = new ToolStripMenuItem();
		this.22 = new ToolStripMenuItem();
		this.23 = new ToolStripMenuItem();
		this.24 = new ToolStripMenuItem();
		this.100 = new ToolStripSeparator();
		this.78 = new ToolStripMenuItem();
		this.91 = new ToolStripMenuItem();
		this.99 = new ToolStripSeparator();
		this.120 = new ToolStripMenuItem();
		this.35 = new ToolStripMenuItem();
		this.36 = new ToolStripMenuItem();
		this.37 = new ToolStripMenuItem();
		this.38 = new ToolStripMenuItem();
		this.39 = new ToolStripMenuItem();
		this.107 = new ToolStripMenuItem();
		this.108 = new ToolStripMenuItem();
		this.119 = new ToolStripMenuItem();
		this.121 = new ToolStripMenuItem();
		this.122 = new ToolStripMenuItem();
		this.123 = new ToolStripMenuItem();
		this.124 = new ToolStripMenuItem();
		this.7 = new ToolStripMenuItem();
		this.44 = new ToolStripMenuItem();
		this.45 = new ToolStripMenuItem();
		this.46 = new ToolStripMenuItem();
		this.47 = new ToolStripMenuItem();
		this.48 = new ToolStripMenuItem();
		this.49 = new ToolStripMenuItem();
		this.62 = new ToolStripMenuItem();
		this.25 = new ToolStripMenuItem();
		this.26 = new ToolStripMenuItem();
		this.27 = new ToolStripMenuItem();
		this.28 = new ToolStripMenuItem();
		this.29 = new ToolStripMenuItem();
		this.41 = new ToolStripMenuItem();
		this.40 = new ToolStripSeparator();
		this.109 = new ToolStripMenuItem();
		this.110 = new ToolStripMenuItem();
		this.111 = new ToolStripMenuItem();
		this.112 = new ToolStripMenuItem();
		this.118 = new ToolStripMenuItem();
		this.97 = new ToolStripMenuItem();
		this.98 = new ToolStripMenuItem();
		this.42 = new ToolStripMenuItem();
		this.74 = new ToolStripMenuItem();
		this.75 = new ToolStripMenuItem();
		this.76 = new ToolStripMenuItem();
		this.72 = new ToolStripMenuItem();
		this.50 = new ToolStripSeparator();
		this.90 = new ToolStripMenuItem();
		this.51 = new ToolStripMenuItem();
		this.52 = new ToolStripMenuItem();
		this.53 = new ToolStripMenuItem();
		this.56 = new ToolStripMenuItem();
		this.57 = new ToolStripSeparator();
		this.43 = new ToolStripMenuItem();
		this.54 = new ToolStripSeparator();
		this.68 = new ToolStripMenuItem();
		this.113 = new ToolStripMenuItem();
		this.71 = new ToolStripMenuItem();
		this.55 = new ToolStripMenuItem();
		this.69 = new ToolStripSeparator();
		this.70 = new ToolStripMenuItem();
		this.82 = new ToolStripMenuItem();
		this.84 = new ToolStripMenuItem();
		this.83 = new ToolStripMenuItem();
		this.8 = new ToolStripMenuItem();
		this.21 = new ToolStripMenuItem();
		this.81 = new ToolStripMenuItem();
		this.3.SuspendLayout();
		base.SuspendLayout();
		this.3.Items.AddRange(new ToolStripItem[]
		{
			this.4,
			this.5,
			this.6,
			this.7,
			this.97,
			this.42,
			this.8
		});
		this.3.Location = new Point(0, 0);
		this.3.Name = "menuStrip1";
		this.3.Size = new Size(800, 24);
		this.3.TabIndex = 0;
		this.3.Text = "menuStrip1";
		this.3.MenuActivate += delegate(object 1, EventArgs 2)
		{
			1662.82(true);
			this.111.Checked = this.1.31;
		};
		this.3.MenuDeactivate += this.16;
		this.4.DropDownItems.AddRange(new ToolStripItem[]
		{
			this.9,
			this.59,
			this.11,
			this.60,
			this.95,
			this.96,
			this.10,
			this.79,
			this.77,
			this.94,
			this.102,
			this.61,
			this.101,
			this.114,
			this.86,
			this.85,
			this.87,
			this.106,
			this.80,
			this.12
		});
		this.4.Name = "fileToolStripMenu";
		this.4.Size = new Size(37, 20);
		this.4.Text = "&File";
		this.4.DropDownOpening += this.52;
		this.9.Name = "newToolStripMenuItem";
		this.9.ShortcutKeyDisplayString = "Ctrl+N";
		this.9.Size = new Size(257, 22);
		this.9.Text = "Clear All &Notes";
		this.9.Click += delegate(object 1, EventArgs 2)
		{
			this.1.25();
		};
		this.59.DropDownItems.AddRange(new ToolStripItem[]
		{
			this.116,
			this.117
		});
		this.59.Name = "openToolStripMenuItem";
		this.59.ShortcutKeyDisplayString = "Ctrl+O";
		this.59.Size = new Size(257, 22);
		this.59.Text = "&Open Difficulty...";
		this.59.Click += this.44;
		this.116.Name = "totalLoadToolStripMenuItem";
		this.116.Size = new Size(146, 22);
		this.116.Text = "For Editing";
		this.116.Click += this.50;
		this.117.Enabled = false;
		this.117.Name = "asReferenceToolStripMenuItem";
		this.117.Size = new Size(146, 22);
		this.117.Text = "For Reference";
		this.117.Click += this.51;
		this.11.Name = "saveToolStripMenuItem";
		this.11.ShortcutKeyDisplayString = "Ctrl+S";
		this.11.Size = new Size(257, 22);
		this.11.Text = "&Save";
		this.11.Click += this.42;
		this.60.Name = "saveAsToolStripMenuItem";
		this.60.Size = new Size(257, 22);
		this.60.Text = "Save &as New Difficulty...";
		this.60.Click += delegate(object 1, EventArgs 2)
		{
			this.1.70();
		};
		this.95.Name = "toolStripSeparator15";
		this.95.Size = new Size(254, 6);
		this.96.Name = "loadSoftToolStripMenuItem";
		this.96.ShortcutKeyDisplayString = "Ctrl+L";
		this.96.Size = new Size(257, 22);
		this.96.Text = "&Revert to Saved";
		this.96.Click += delegate(object 1, EventArgs 2)
		{
			this.1.34(this.1.7.21, true, false);
		};
		this.10.Name = "loadToolStripMenuItem";
		this.10.ShortcutKeyDisplayString = "Ctrl+Shift+L";
		this.10.Size = new Size(257, 22);
		this.10.Text = "Revert to Saved (Full)";
		this.10.Click += this.41;
		this.79.Name = "toolStripSeparator12";
		this.79.Size = new Size(254, 6);
		this.77.Name = "testBeatmapToolStripMenuItem";
		this.77.ShortcutKeyDisplayString = "F5";
		this.77.Size = new Size(257, 22);
		this.77.Text = "&Test Beatmap";
		this.77.Click += delegate(object 1, EventArgs 2)
		{
			this.1.89();
		};
		this.94.Name = "openAiModToolStripMenuItem";
		this.94.ShortcutKeyDisplayString = "Ctrl+Shift+A";
		this.94.Size = new Size(257, 22);
		this.94.Text = "Open Ai&Mod";
		this.94.Click += this.47;
		this.102.Name = "toolStripSeparator17";
		this.102.Size = new Size(254, 6);
		this.73.Name = "submitToolStripMenuItem";
		this.73.ShortcutKeyDisplayString = "Ctrl+Shift+U";
		this.73.Size = new Size(257, 22);
		this.73.Text = "&Upload Beatmap...";
		this.61.Name = "packageForDistributionToolStripMenuItem";
		this.61.Size = new Size(257, 22);
		this.61.Text = "&Export Package...";
		this.61.Click += this.45;
		this.101.Name = "extractMapPackageToolStripMenuItem";
		this.101.Size = new Size(257, 22);
		this.101.Text = "Extract Map Package";
		this.101.Click += delegate(object 1, EventArgs 2)
		{
			1262 3 = this.1.7.21;
			if (!3.61)
			{
				MessageBox.Show(1568.1(2679.EditorControl_BeatmapAlreadyExtracted));
				return;
			}
			if (!3.71())
			{
				MessageBox.Show(1568.1(2679.EditorControl_BeatmapProtectedFromExtraction));
				return;
			}
			if (3.62((1262.1266)0, false))
			{
				try
				{
					1804.4(3.53());
					return;
				}
				catch
				{
					return;
				}
			}
			MessageBox.Show(1568.1(2679.EditorControl_ExtractionFailed));
		};
		this.114.DropDownItems.AddRange(new ToolStripItem[]
		{
			this.115
		});
		this.114.Name = "importBMSToolStripMenuItem";
		this.114.Size = new Size(257, 22);
		this.114.Text = "Import from...";
		this.115.Name = "bmsbmeToolStripMenuItem";
		this.115.Size = new Size(126, 22);
		this.115.Text = "bms/bme";
		this.115.Click += this.49;
		this.86.Name = "toolStripSeparator13";
		this.86.Size = new Size(254, 6);
		this.85.Name = "openSongFolder";
		this.85.Size = new Size(257, 22);
		this.85.Text = "Open Song Fold&er";
		this.85.Click += delegate(object 1, EventArgs 2)
		{
			1262 3 = this.1.7.21;
			1662.68(3.61 ? 3.53() : 3.44());
		};
		this.87.Name = "openOsuInNotepad";
		this.87.Size = new Size(257, 22);
		this.87.Text = "Open .osu in Notepad";
		this.87.Click += this.46;
		this.106.Name = "openosbInNotepadToolStripMenuItem";
		this.106.Size = new Size(257, 22);
		this.106.Text = "Open .osb in Notepad";
		this.106.Click += this.48;
		this.80.Name = "toolStripSeparator11";
		this.80.Size = new Size(254, 6);
		this.12.Name = "exitToolStripMenuItem";
		this.12.ShortcutKeyDisplayString = "Esc";
		this.12.Size = new Size(257, 22);
		this.12.Text = "E&xit...";
		this.12.Click += this.43;
		this.5.DropDownItems.AddRange(new ToolStripItem[]
		{
			this.65,
			this.66,
			this.67,
			this.13,
			this.14,
			this.15,
			this.16,
			this.18,
			this.17,
			this.19,
			this.32,
			this.58,
			this.30,
			this.31,
			this.63,
			this.64,
			this.89,
			this.105,
			this.92,
			this.88,
			this.93,
			this.103,
			this.104,
			this.20,
			this.33,
			this.34
		});
		this.5.Name = "editToolStripMenu";
		this.5.Size = new Size(39, 20);
		this.5.Text = "&Edit";
		this.5.DropDownOpening += delegate(object 1, EventArgs 2)
		{
			bool flag = this.1.74.44.Count != 0 && this.1.26 == 2335.Compose;
			this.58.Enabled = flag;
			this.30.Enabled = flag;
			this.31.Enabled = flag;
			this.63.Enabled = flag;
			this.64.Enabled = flag;
			this.89.Enabled = flag;
			this.105.Enabled = flag;
			if (flag)
			{
				flag = (this.1.26 == 2335.Compose);
			}
			this.19.Enabled = flag;
			this.33.Enabled = flag;
			this.34.Enabled = flag;
		};
		this.65.Enabled = false;
		this.65.Name = "menuItemUndo";
		this.65.ShortcutKeyDisplayString = "Ctrl+Z";
		this.65.Size = new Size(246, 22);
		this.65.Text = "Undo";
		this.65.Click += this.36;
		this.66.Enabled = false;
		this.66.Name = "menuItemRedo";
		this.66.ShortcutKeyDisplayString = "Ctrl+Y";
		this.66.Size = new Size(246, 22);
		this.66.Text = "Redo";
		this.66.Click += delegate(object 1, EventArgs 2)
		{
			this.1.8.Redo();
		};
		this.67.Name = "toolStripSeparator9";
		this.67.Size = new Size(243, 6);
		this.13.Name = "cutToolStripMenuItem";
		this.13.ShortcutKeyDisplayString = "Ctrl+X";
		this.13.Size = new Size(246, 22);
		this.13.Text = "Cu&t";
		this.13.Click += this.27;
		this.14.Name = "copyToolStripMenuItem";
		this.14.ShortcutKeyDisplayString = "Ctrl+C";
		this.14.Size = new Size(246, 22);
		this.14.Text = "&Copy";
		this.14.Click += this.28;
		this.15.Name = "pasteToolStripMenuItem";
		this.15.ShortcutKeyDisplayString = "Ctrl+V";
		this.15.Size = new Size(246, 22);
		this.15.Text = "&Paste";
		this.15.Click += delegate(object 1, EventArgs 2)
		{
			this.1.Paste();
		};
		this.16.Name = "deleteToolStripMenuItem";
		this.16.ShortcutKeyDisplayString = "Del";
		this.16.Size = new Size(246, 22);
		this.16.Text = "&Delete";
		this.16.Click += this.30;
		this.18.Name = "toolStripSeparator1";
		this.18.Size = new Size(243, 6);
		this.17.Name = "selectAllToolStripMenuItem";
		this.17.ShortcutKeyDisplayString = "Ctrl+A";
		this.17.Size = new Size(246, 22);
		this.17.Text = "Select &All";
		this.17.Click += this.31;
		this.19.Name = "cloneToolStripMenuItem";
		this.19.ShortcutKeyDisplayString = "Ctrl+D";
		this.19.Size = new Size(246, 22);
		this.19.Text = "C&lone";
		this.19.Click += this.29;
		this.32.Name = "toolStripSeparator3";
		this.32.Size = new Size(243, 6);
		this.58.Name = "reverseSelectionToolStripMenuItem";
		this.58.ShortcutKeyDisplayString = "Ctrl+G";
		this.58.Size = new Size(246, 22);
		this.58.Text = "&Reverse Selection";
		this.58.Click += delegate(object 1, EventArgs 2)
		{
			this.1.74.75();
		};
		this.30.Name = "flipHorizontallyToolStripMenuItem";
		this.30.ShortcutKeyDisplayString = "Ctrl+H";
		this.30.Size = new Size(246, 22);
		this.30.Text = "Flip &Horizontally";
		this.30.Click += this.32;
		this.31.Name = "flipVerticallyToolStripMenuItem";
		this.31.ShortcutKeyDisplayString = "Ctrl+J";
		this.31.Size = new Size(246, 22);
		this.31.Text = "Flip &Vertically";
		this.31.Click += delegate(object 1, EventArgs 2)
		{
			this.1.74.FlipVertically();
		};
		this.63.Name = "rotateClockwiseToolStripMenuItem";
		this.63.ShortcutKeyDisplayString = "Ctrl+>";
		this.63.Size = new Size(246, 22);
		this.63.Text = "Rotate 90° Cl&ockwise";
		this.63.Click += this.33;
		this.64.Name = "rotateAnticlockwiseToolStripMenuItem";
		this.64.ShortcutKeyDisplayString = "Ctrl+<";
		this.64.Size = new Size(246, 22);
		this.64.Text = "Rotate 90° Antic&lockwise";
		this.64.Click += this.34;
		this.89.Name = "rotationByToolStripMenuItem";
		this.89.ShortcutKeyDisplayString = "Ctrl+Shift+R";
		this.89.Size = new Size(246, 22);
		this.89.Text = "Rotate by...";
		this.89.Click += this.35;
		this.105.Name = "scaleByToolStripMenuItem";
		this.105.ShortcutKeyDisplayString = "Ctrl+Shift+S";
		this.105.Size = new Size(246, 22);
		this.105.Text = "Scale by...";
		this.105.Click += delegate(object 1, EventArgs 2)
		{
			this.1.43();
		};
		this.92.Name = "toolStripSeparator14";
		this.92.Size = new Size(243, 6);
		this.88.Name = "resetSliderStripMenuItem";
		this.88.ShortcutKeyDisplayString = string.Empty;
		this.88.Size = new Size(246, 22);
		this.88.Text = "Reset selected objects' samples";
		this.88.Click += delegate(object 1, EventArgs 2)
		{
			this.1.74.41();
		};
		this.93.ForeColor = Color.Red;
		this.93.Name = "resetAllSamplesToolStripMenuItem";
		this.93.Size = new Size(246, 22);
		this.93.Text = "Reset all samples";
		this.93.Click += this.39;
		this.103.ForeColor = Color.Red;
		this.103.Name = "resetComboColoursToolStripMenuItem";
		this.103.Size = new Size(246, 22);
		this.103.Text = "Reset combo colours";
		this.103.Click += this.40;
		this.104.ForeColor = Color.Red;
		this.104.Name = "resetBreaksToolStripMenuItem";
		this.104.Size = new Size(246, 22);
		this.104.Text = "Reset breaks";
		this.104.Click += delegate(object 1, EventArgs 2)
		{
			List<2275> list = this.1.6.13.FindAll((2275 1) => 1.12 || 1.13);
			if (list.Count > 0)
			{
				this.1.8.19((2452)2, null);
				this.1.8.13((2451)0, (2450)2304);
				this.1.8.24<2275>(list, false);
				foreach (2275 3 in list)
				{
					3.12 = false;
					3.13 = false;
				}
				this.1.2(true);
				this.1.17(true, false, false, true);
			}
		};
		this.20.Name = "toolStripSeparator2";
		this.20.Size = new Size(243, 6);
		this.33.Name = "nudgeBackwardToolStripMenuItem";
		this.33.ShortcutKeyDisplayString = "J";
		this.33.Size = new Size(246, 22);
		this.33.Text = "Nudge &Backward";
		this.33.Click += this.37;
		this.34.Name = "nudgeOneMeasureRightToolStripMenuItem";
		this.34.ShortcutKeyDisplayString = "K";
		this.34.Size = new Size(246, 22);
		this.34.Text = "Nudge &Forward";
		this.34.Click += this.38;
		this.6.DropDownItems.AddRange(new ToolStripItem[]
		{
			this.22,
			this.23,
			this.24,
			this.100,
			this.78,
			this.91,
			this.99,
			this.120,
			this.35,
			this.107,
			this.108,
			this.119,
			this.121,
			this.122,
			this.123,
			this.124
		});
		this.6.Name = "viewToolStripMenu";
		this.6.Size = new Size(44, 20);
		this.6.Text = "&View";
		this.6.DropDownOpening += this.73;
		this.22.Checked = true;
		this.22.CheckState = CheckState.Checked;
		this.22.Name = "composeToolStripMenuItem";
		this.22.ShortcutKeyDisplayString = "F1";
		this.22.Size = new Size(180, 22);
		this.22.Text = "&Compose";
		this.22.Click += delegate(object 1, EventArgs 2)
		{
			this.1.27(2335.Compose);
		};
		this.23.Name = "designToolStripMenuItem";
		this.23.ShortcutKeyDisplayString = "F2";
		this.23.Size = new Size(180, 22);
		this.23.Text = "&Design";
		this.23.Click += this.1;
		this.24.Name = "timingToolStripMenuItem";
		this.24.ShortcutKeyDisplayString = "F3";
		this.24.Size = new Size(180, 22);
		this.24.Text = "&Timing";
		this.24.Click += this.2;
		this.100.Name = "toolStripSeparator4";
		this.100.Size = new Size(177, 6);
		this.78.Name = "songSetupToolStripMenuItem";
		this.78.ShortcutKeyDisplayString = "F4";
		this.78.Size = new Size(180, 22);
		this.78.Text = "Song &Setup...";
		this.78.Click += this.74;
		this.91.Name = "timingSetupToolStripMenuItem";
		this.91.ShortcutKeyDisplayString = "F6";
		this.91.Size = new Size(180, 22);
		this.91.Text = "Timing Setup...";
		this.91.Click += this.70;
		this.99.Name = "toolStripSeparator16";
		this.99.Size = new Size(177, 6);
		this.120.Name = "volumeToolStripMenuItem";
		this.120.Size = new Size(180, 22);
		this.120.Text = "Volume";
		this.120.Click += this.77;
		this.35.DropDownItems.AddRange(new ToolStripItem[]
		{
			this.36,
			this.37,
			this.38,
			this.39
		});
		this.35.Name = "gridLevelToolStripMenuItem";
		this.35.ShortcutKeyDisplayString = "G";
		this.35.Size = new Size(180, 22);
		this.35.Text = "&Grid Level";
		this.36.Name = "mostSparseToolStripMenuItem";
		this.36.Size = new Size(158, 22);
		this.36.Text = "&1 (Most sparse)";
		this.36.Click += this.3;
		this.37.Checked = true;
		this.37.CheckState = CheckState.Checked;
		this.37.Name = "gridSize2ToolStripMenuItem";
		this.37.Size = new Size(158, 22);
		this.37.Text = "&2";
		this.37.Click += this.4;
		this.38.Name = "gridSize3ToolStripMenuItem";
		this.38.Size = new Size(158, 22);
		this.38.Text = "&3";
		this.38.Click += this.5;
		this.39.Name = "mostPreciseToolStripMenuItem";
		this.39.Size = new Size(158, 22);
		this.39.Text = "&4 (Most precise)";
		this.39.Click += delegate(object 1, EventArgs 2)
		{
			this.1.28(2337.Tiny, true);
		};
		this.107.Name = "showVideoToolStripMenuItem";
		this.107.Size = new Size(180, 22);
		this.107.Text = "Show Video/Storyboard";
		this.107.Click += this.75;
		this.108.Name = "togglePlaytestDimMenuItem";
		this.108.Size = new Size(180, 22);
		this.108.Text = "Dim Background";
		this.108.Click += delegate(object 1, EventArgs 2)
		{
			this.108.Checked = !this.108.Checked;
			1304.80.2(this.108.Checked);
		};
		this.119.Name = "showSampleNameToolStripMenuItem";
		this.119.Size = new Size(180, 22);
		this.119.Checked = true;
		this.119.Text = "Show Sample Name";
		this.119.Click += delegate(object 1, EventArgs 2)
		{
			this.119.Checked = !this.119.Checked;
			this.1.32 = this.119.Checked;
		};
		this.121.Name = "snakingSlidersToolStripMenuItem";
		this.121.Size = new Size(180, 22);
		this.121.Text = "Snaking Sliders";
		this.121.Click += this.76;
		this.122.Name = "hitAnimationsToolStripMenuItem";
		this.122.Size = new Size(180, 22);
		this.122.Text = "Hit Animations";
		this.122.Click += delegate(object 1, EventArgs 2)
		{
			this.24(new 1189(this.82));
		};
		this.123.Name = "followPointsToolStripMenuItem";
		this.123.Size = new Size(180, 22);
		this.123.Text = "Follow Points";
		this.123.Click += delegate(object 1, EventArgs 2)
		{
			this.123.Checked = !this.123.Checked;
			1304.84.2(this.123.Checked);
		};
		this.124.Name = "stackingToolStripMenuItem";
		this.124.Size = new Size(180, 22);
		this.124.Text = "Stacking";
		this.124.Click += delegate(object 1, EventArgs 2)
		{
			this.124.Checked = !this.124.Checked;
			1304.85.2(this.124.Checked);
			if (!this.124.Checked)
			{
				this.1.7.41();
			}
		};
		this.7.DropDownItems.AddRange(new ToolStripItem[]
		{
			this.44,
			this.25,
			this.41,
			this.40,
			this.109,
			this.110,
			this.111,
			this.112,
			this.118
		});
		this.7.Name = "composeToolStripMenu";
		this.7.Size = new Size(70, 20);
		this.7.Text = "&Compose";
		this.7.DropDownOpening += delegate(object 1, EventArgs 2)
		{
			if (this.1.26 != 2335.Compose)
			{
				this.109.Enabled = false;
				this.110.Enabled = false;
				return;
			}
			this.109.Enabled = true;
			if (this.1.74.45 != null)
			{
				this.110.Enabled = true;
				return;
			}
			this.110.Enabled = false;
		};
		this.44.DropDownItems.AddRange(new ToolStripItem[]
		{
			this.45,
			this.46,
			this.47,
			this.48,
			this.49,
			this.62
		});
		this.44.Name = "snapDivisorToolStripMenuItem";
		this.44.ShortcutKeyDisplayString = "M";
		this.44.Size = new Size(269, 22);
		this.44.Text = "Snap Di&visor";
		this.45.Name = "fullBeatsToolStripMenuItem";
		this.45.Size = new Size(179, 22);
		this.45.Text = "1/1 Full Beats";
		this.45.Click += delegate(object 1, EventArgs 2)
		{
			this.1.74.24(1);
		};
		this.46.Checked = true;
		this.46.CheckState = CheckState.Checked;
		this.46.Name = "halfBeatsToolStripMenuItem";
		this.46.Size = new Size(179, 22);
		this.46.Text = "1/2 Half Beats";
		this.46.Click += this.7;
		this.47.Name = "quarterBeatsToolStripMenuItem";
		this.47.Size = new Size(179, 22);
		this.47.Text = "1/4 Quarter Beats";
		this.47.Click += delegate(object 1, EventArgs 2)
		{
			this.1.74.24(4);
		};
		this.48.Name = "eighthBeatsToolStripMenuItem";
		this.48.Size = new Size(179, 22);
		this.48.Text = "1/8 Eighth Beats";
		this.48.Click += delegate(object 1, EventArgs 2)
		{
			this.1.74.24(8);
		};
		this.49.Name = "tripletsToolStripMenuItem";
		this.49.Size = new Size(179, 22);
		this.49.Text = "1/3 Triplets*";
		this.49.Click += this.8;
		this.62.Name = "doubleTripletsToolStripMenuItem";
		this.62.Size = new Size(179, 22);
		this.62.Text = "1/6 Double Triplets*";
		this.62.Click += delegate(object 1, EventArgs 2)
		{
			this.1.74.24(6);
		};
		this.25.DropDownItems.AddRange(new ToolStripItem[]
		{
			this.26,
			this.27,
			this.28,
			this.29
		});
		this.25.Name = "audioRateToolStripMenuItem";
		this.25.Size = new Size(269, 22);
		this.25.Text = "Audio &Rate";
		this.26.Name = "audioRate25ToolStripMenuItem";
		this.26.Size = new Size(102, 22);
		this.26.Text = "25%";
		this.26.Click += this.78;
		this.27.Name = "audioRate50ToolStripMenuItem";
		this.27.Size = new Size(102, 22);
		this.27.Text = "50%";
		this.27.Click += this.79;
		this.28.Name = "audioRate75ToolStripMenuItem";
		this.28.Size = new Size(102, 22);
		this.28.Text = "75%";
		this.28.Click += this.80;
		this.29.Checked = true;
		this.29.CheckState = CheckState.Checked;
		this.29.Name = "audioRate100ToolStripMenuItem";
		this.29.Size = new Size(102, 22);
		this.29.Text = "100%";
		this.29.Click += delegate(object 1, EventArgs 2)
		{
			this.1.77(100.0);
		};
		this.41.Name = "beatSnappingToolStripMenuItem";
		this.41.ShortcutKeyDisplayString = "T";
		this.41.Size = new Size(269, 22);
		this.41.Text = "&Grid Snapping";
		this.41.Click += this.6;
		this.40.Name = "toolStripSeparator5";
		this.40.Size = new Size(266, 6);
		this.109.Name = "polygonStripMenuItem";
		this.109.ShortcutKeyDisplayString = "Ctrl+Shift+D";
		this.109.Size = new Size(269, 22);
		this.109.Text = "Create &Polygon Circles";
		this.109.Click += delegate(object 1, EventArgs 2)
		{
			this.1.44();
		};
		this.110.Name = "convertSliderToStreamToolStripMenuItem";
		this.110.ShortcutKeyDisplayString = "Ctrl+Shift+F";
		this.110.Size = new Size(272, 22);
		this.110.Text = "Convert slider to &stream";
		this.110.Click += delegate(object 1, EventArgs 2)
		{
			this.1.45();
		};
		this.111.Name = "enableLiveMappingModeToolStripMenuItem";
		this.111.ShortcutKeyDisplayString = "Ctrl+Tab";
		this.111.Size = new Size(269, 22);
		this.111.Text = "Enable live mapping mode";
		this.111.Click += this.10;
		this.112.Name = "sampleImportToolStripMenuItem";
		this.112.ShortcutKeyDisplayString = "Ctrl+Shift+I";
		this.112.Size = new Size(269, 22);
		this.112.Text = "Sample import";
		this.112.Click += this.11;
		this.118.Name = "autoToolStripMenuItem";
		this.118.Size = new Size(269, 22);
		this.118.Text = "Auto volume balance";
		this.118.Visible = false;
		this.118.Click += this.12;
		this.97.DropDownItems.AddRange(new ToolStripItem[]
		{
			this.98
		});
		this.97.Name = "designToolStripMenu";
		this.97.Size = new Size(55, 20);
		this.97.Text = "&Design";
		this.97.DropDownOpening += delegate(object 1, EventArgs 2)
		{
			if (this.1.26 != 2335.Design)
			{
				this.98.Enabled = false;
				return;
			}
			this.98.Enabled = true;
		};
		this.98.Name = "moveAllElementsInTimeToolStripMenuItem";
		this.98.Size = new Size(219, 22);
		this.98.Text = "Move all elements in time...";
		this.98.Click += this.57;
		this.42.DropDownItems.AddRange(new ToolStripItem[]
		{
			this.74,
			this.72,
			this.50,
			this.90,
			this.51,
			this.52,
			this.53,
			this.56,
			this.57,
			this.43,
			this.54,
			this.68,
			this.113,
			this.71,
			this.55,
			this.69,
			this.70
		});
		this.42.Name = "timingToolStripMenu";
		this.42.Size = new Size(57, 20);
		this.42.Text = "&Timing";
		this.74.DropDownItems.AddRange(new ToolStripItem[]
		{
			this.75,
			this.76
		});
		this.74.Name = "timingSignatureToolStripMenuItem";
		this.74.Size = new Size(268, 22);
		this.74.Text = "Time Signature";
		this.75.Name = "signature44";
		this.75.Size = new Size(183, 22);
		this.75.Text = "4/4 (Common Time)";
		this.75.Click += this.66;
		this.76.Name = "signature34";
		this.76.Size = new Size(183, 22);
		this.76.Text = "3/4 (Waltz/Triple)";
		this.76.Click += this.67;
		this.72.Checked = true;
		this.72.CheckState = CheckState.Checked;
		this.72.Name = "metronomeClicksToolStripMenuItem";
		this.72.Size = new Size(268, 22);
		this.72.Text = "&Metronome Clicks";
		this.72.Click += this.65;
		this.50.Name = "toolStripSeparator6";
		this.50.Size = new Size(265, 6);
		this.90.Name = "addTimingToolStripMenuItem";
		this.90.ShortcutKeyDisplayString = "Ctrl+P";
		this.90.Size = new Size(268, 22);
		this.90.Text = "&Add Timing Section";
		this.90.Click += this.69;
		this.51.Name = "addTimingPointToolStripMenuItem";
		this.51.ShortcutKeyDisplayString = "Ctrl+Shift+P";
		this.51.Size = new Size(268, 22);
		this.51.Text = "Add &Inheriting Section";
		this.51.Click += delegate(object 1, EventArgs 2)
		{
			1662.89.Schedule(new 1189(this.71), false);
		};
		this.52.Name = "retimeCurrentPointToolStripMenuItem";
		this.52.ShortcutKeyDisplayString = string.Empty;
		this.52.Size = new Size(268, 22);
		this.52.Text = "&Reset Current Section";
		this.52.Click += this.59;
		this.53.Name = "deleteTimingPointToolStripMenuItem";
		this.53.ShortcutKeyDisplayString = "Ctrl+I";
		this.53.Size = new Size(268, 22);
		this.53.Text = "&Delete Timing Section";
		this.53.Click += this.60;
		this.56.ForeColor = Color.Black;
		this.56.Name = "snapAllNotesToolStripMenuItem";
		this.56.Size = new Size(268, 22);
		this.56.Text = "Re&snap Current Section";
		this.56.Click += this.61;
		this.57.Name = "toolStripSeparator8";
		this.57.Size = new Size(265, 6);
		this.43.Name = "bPMOffsetToolStripMenuItem";
		this.43.ShortcutKeyDisplayString = "F6";
		this.43.Size = new Size(268, 22);
		this.43.Text = "Timing &Setup...";
		this.43.Click += delegate(object 1, EventArgs 2)
		{
			1662.89.Schedule(new 1189(this.72), false);
		};
		this.54.Name = "toolStripSeparator7";
		this.54.Size = new Size(265, 6);
		this.68.ForeColor = Color.Red;
		this.68.Name = "resnapAllNotesToolStripMenuItem";
		this.68.Size = new Size(268, 22);
		this.68.Text = "Res&nap All Notes";
		this.68.Click += this.62;
		this.113.ForeColor = Color.Red;
		this.113.Name = "moveAllNotesToolStripMenuItem";
		this.113.Size = new Size(268, 22);
		this.113.Text = "Move all notes in time...";
		this.113.Click += delegate(object 1, EventArgs 2)
		{
			1662.82(true);
			new 2311().ShowDialog();
			1662.82(false);
		};
		this.71.ForeColor = Color.Red;
		this.71.Name = "recalculateSlidersToolStripMenuItem";
		this.71.Size = new Size(268, 22);
		this.71.Text = "Re&calculate Slider Lengths";
		this.71.Click += this.64;
		this.55.ForeColor = Color.Red;
		this.55.Name = "resetAllTimingsToolStripMenuItem";
		this.55.Size = new Size(268, 22);
		this.55.Text = "Delete All Timing Sections";
		this.55.Click += this.58;
		this.69.Name = "toolStripSeparator10";
		this.69.Size = new Size(265, 6);
		this.70.Name = "setPreviewPointToCurrentPositionToolStripMenuItem";
		this.70.Size = new Size(268, 22);
		this.70.Text = "Set Current Position as &Preview Point";
		this.70.Click += this.63;
		this.82.DropDownItems.AddRange(new ToolStripItem[]
		{
			this.84,
			this.83
		});
		this.82.Name = "webToolStripMenu";
		this.82.Size = new Size(43, 20);
		this.82.Text = "&Web";
		this.84.Name = "thisBeatmapsInformationPageToolStripMenuItem";
		this.84.Size = new Size(249, 22);
		this.84.Text = "This Beatmap's &Information Page";
		this.84.Click += this.53;
		this.83.Name = "thisBeatmapsThreadToolStripMenuItem";
		this.83.Size = new Size(249, 22);
		this.83.Text = "This Beatmap's &Thread";
		this.83.Click += this.54;
		this.8.DropDownItems.AddRange(new ToolStripItem[]
		{
			this.21
		});
		this.8.Name = "helpToolStripMenu";
		this.8.Size = new Size(44, 20);
		this.8.Text = "&Help";
		this.21.Name = "displayInlineHlpeToolStripMenuItem";
		this.21.Size = new Size(177, 22);
		this.21.Text = "Show &in-game help";
		this.21.Click += this.55;
		this.81.Name = "viewFAQToolStripMenuItem";
		this.81.Size = new Size(177, 22);
		this.81.Text = "View &FAQ...";
		this.81.Click += this.56;
		base.AutoScaleDimensions = new SizeF(96f, 96f);
		base.AutoScaleMode = AutoScaleMode.Dpi;
		base.Controls.Add(this.3);
		base.Name = "EditorControl";
		base.Size = new Size(800, 24);
		this.3.ResumeLayout(false);
		this.3.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x06002C8A RID: 11402 RVA: 0x000FA0F4 File Offset: 0x000F82F4
	private void 27(object 1, EventArgs 2)
	{
		this.1.74.CutSelection();
	}

	// Token: 0x06002C8B RID: 11403 RVA: 0x000FA106 File Offset: 0x000F8306
	private void 28(object 1, EventArgs 2)
	{
		this.1.29();
	}

	// Token: 0x06002C8C RID: 11404 RVA: 0x000FA113 File Offset: 0x000F8313
	private void 29(object 1, EventArgs 2)
	{
		this.1.74.18();
	}

	// Token: 0x06002C8D RID: 11405 RVA: 0x000FA125 File Offset: 0x000F8325
	private void 30(object 1, EventArgs 2)
	{
		this.1.74.DeleteSelection();
	}

	// Token: 0x06002C8E RID: 11406 RVA: 0x000FA137 File Offset: 0x000F8337
	private void 31(object 1, EventArgs 2)
	{
		this.1.30();
	}

	// Token: 0x06002C8F RID: 11407 RVA: 0x000FA144 File Offset: 0x000F8344
	private void 32(object 1, EventArgs 2)
	{
		this.1.74.FlipHorizontally();
	}

	// Token: 0x06002C90 RID: 11408 RVA: 0x000FA156 File Offset: 0x000F8356
	private void 33(object 1, EventArgs 2)
	{
		this.1.74.77();
	}

	// Token: 0x06002C91 RID: 11409 RVA: 0x000FA168 File Offset: 0x000F8368
	private void 34(object 1, EventArgs 2)
	{
		this.1.74.76();
	}

	// Token: 0x06002C92 RID: 11410 RVA: 0x000FA17A File Offset: 0x000F837A
	private void 35(object 1, EventArgs 2)
	{
		this.1.42();
	}

	// Token: 0x06002C93 RID: 11411 RVA: 0x000FA187 File Offset: 0x000F8387
	private void 36(object 1, EventArgs 2)
	{
		this.1.8.Undo();
	}

	// Token: 0x06002C94 RID: 11412 RVA: 0x000FA199 File Offset: 0x000F8399
	private void 37(object 1, EventArgs 2)
	{
		this.1.74.73();
	}

	// Token: 0x06002C95 RID: 11413 RVA: 0x000FA1AB File Offset: 0x000F83AB
	private void 38(object 1, EventArgs 2)
	{
		this.1.74.74();
	}

	// Token: 0x06002C96 RID: 11414 RVA: 0x000FA1BD File Offset: 0x000F83BD
	private void 39(object 1, EventArgs 2)
	{
		if (DialogResult.OK == MessageBox.Show(1568.1(2679.EditorControl_ResetSamplesWarning), "osu!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation))
		{
			this.1.74.46();
		}
	}

	// Token: 0x06002C97 RID: 11415 RVA: 0x000FA1EC File Offset: 0x000F83EC
	private void 40(object 1, EventArgs 2)
	{
		List<2034> list = this.1.7.34.FindAll(new Predicate<2034>(2330.2331.instance.1));
		if (list.Count <= 0)
		{
			return;
		}
		this.1.8.17<2034>((2452)0, (2451)6, list);
		foreach (2034 3 in list)
		{
			3.16 = 0;
		}
		this.1.7.2(false);
		this.1.8.20(false, false);
	}

	// Token: 0x06002C98 RID: 11416 RVA: 0x000FA2A0 File Offset: 0x000F84A0
	private void 41(object 1, EventArgs 2)
	{
		this.1.34(this.1.7.21, true, true);
	}

	// Token: 0x06002C99 RID: 11417 RVA: 0x000FA2C0 File Offset: 0x000F84C0
	private void 42(object 1, EventArgs 2)
	{
		this.1.66();
	}

	// Token: 0x06002C9A RID: 11418 RVA: 0x000FA2CD File Offset: 0x000F84CD
	private void 43(object 1, EventArgs 2)
	{
		this.1.32();
	}

	// Token: 0x06002C9B RID: 11419 RVA: 0x00005ADD File Offset: 0x00003CDD
	private void 44(object 1, EventArgs 2)
	{
	}

	// Token: 0x06002C9C RID: 11420 RVA: 0x000FA2DB File Offset: 0x000F84DB
	private void 45(object 1, EventArgs 2)
	{
		this.1.71();
	}

	// Token: 0x06002C9D RID: 11421 RVA: 0x000FA2E8 File Offset: 0x000F84E8
	private void 46(object 1, EventArgs 2)
	{
		1262 3 = this.1.7.21;
		if (!3.61)
		{
			1662.70("notepad.exe", 3.68());
			return;
		}
		string text = 3.61(3.58, false);
		if (text != null)
		{
			1662.70("notepad.exe", text);
		}
	}

	// Token: 0x06002C9E RID: 11422 RVA: 0x000FA33B File Offset: 0x000F853B
	private void 47(object 1, EventArgs 2)
	{
		this.1.38();
	}

	// Token: 0x06002C9F RID: 11423 RVA: 0x000FA348 File Offset: 0x000F8548
	private void 48(object 1, EventArgs 2)
	{
		1262 3 = this.1.7.21;
		if (!3.52(3.67()))
		{
			return;
		}
		if (!3.61)
		{
			1662.70("notepad.exe", Path.Combine(3.44(), 3.67()));
			return;
		}
		string text = 3.61(3.67(), false);
		if (text != null)
		{
			1662.70("notepad.exe", text);
		}
	}

	// Token: 0x06002CA0 RID: 11424 RVA: 0x000FA3B8 File Offset: 0x000F85B8
	private void 49(object 1, EventArgs 2)
	{
		if (this.1.7.21.3() != 2147.OsuMania)
		{
			1763.2(1568.1(2679.EditorControl_OnlyAvailableForMania), 2000, (1389)0);
			return;
		}
		1662.82(true);
		new 2309().ShowDialog();
		1662.82(false);
	}

	// Token: 0x06002CA1 RID: 11425 RVA: 0x000FA40A File Offset: 0x000F860A
	private void 50(object 1, EventArgs 2)
	{
		this.1.48(false);
	}

	// Token: 0x06002CA2 RID: 11426 RVA: 0x000FA418 File Offset: 0x000F8618
	private void 51(object 1, EventArgs 2)
	{
		this.1.48(true);
	}

	// Token: 0x06002CA3 RID: 11427 RVA: 0x000FA426 File Offset: 0x000F8626
	private void 52(object 1, EventArgs 2)
	{
		this.117.Enabled = (this.1.15 == 2147.OsuMania);
	}

	// Token: 0x06002CA4 RID: 11428 RVA: 0x000FA441 File Offset: 0x000F8641
	private void 53(object 1, EventArgs 2)
	{
		this.1.7.21.6();
	}

	// Token: 0x06002CA5 RID: 11429 RVA: 0x000FA458 File Offset: 0x000F8658
	private void 54(object 1, EventArgs 2)
	{
		this.1.7.21.7();
	}

	// Token: 0x06002CA6 RID: 11430 RVA: 0x000FA46F File Offset: 0x000F866F
	private void 55(object 1, EventArgs 2)
	{
		this.1.26();
	}

	// Token: 0x06002CA7 RID: 11431 RVA: 0x000FA47C File Offset: 0x000F867C
	private void 56(object 1, EventArgs 2)
	{
		1662.69(1661.10());
	}

	// Token: 0x06002CA8 RID: 11432 RVA: 0x000FA488 File Offset: 0x000F8688
	private void 57(object 1, EventArgs 2)
	{
		1662.82(true);
		new 2310().ShowDialog();
		1662.82(false);
	}

	// Token: 0x06002CA9 RID: 11433 RVA: 0x000FA4A1 File Offset: 0x000F86A1
	private void 58(object 1, EventArgs 2)
	{
		if (DialogResult.Yes != MessageBox.Show(1568.1(2679.EditorControl_ResetTimingsWarning), "osu!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
		{
			return;
		}
		1662.89.Schedule(delegate()
		{
			if (1226.81().Count != 0)
			{
				this.1.76.6.17<1259>((2452)1, (2451)9, 1226.81());
				1226.81().Clear();
				this.1.76.6.20(false, false);
			}
		}, false);
	}

	// Token: 0x06002CAA RID: 11434 RVA: 0x000FA4D6 File Offset: 0x000F86D6
	private void 59(object 1, EventArgs 2)
	{
		if (DialogResult.Yes == MessageBox.Show(1568.1(2679.EditorControl_ResetCurrentTimingWarning), "osu!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
		{
			1662.89.Schedule(new 1189(this.1.76.20), false);
		}
	}

	// Token: 0x06002CAB RID: 11435 RVA: 0x000FA514 File Offset: 0x000F8714
	private void 60(object 1, EventArgs 2)
	{
		1662.89.Schedule(new 1189(this.1.76.19), false);
	}

	// Token: 0x06002CAC RID: 11436 RVA: 0x000FA538 File Offset: 0x000F8738
	private void 61(object 1, EventArgs 2)
	{
		if (1226.75())
		{
			if (DialogResult.Yes == MessageBox.Show(1568.1(2679.EditorControl_SnapNotesCurrentTimingWarning), "osu!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
			{
				this.1.76.22(true, null);
				return;
			}
		}
		else
		{
			MessageBox.Show(1568.1(2679.EditorControl_OneSectionRequiredWarning), "osu!", MessageBoxButtons.OK);
		}
	}

	// Token: 0x06002CAD RID: 11437 RVA: 0x000FA598 File Offset: 0x000F8798
	private void 62(object 1, EventArgs 2)
	{
		if (DialogResult.Yes == MessageBox.Show(1568.1(2679.EditorControl_SnapAllNotesWarning), "osu!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
		{
			this.1.76.22(false, null);
		}
	}

	// Token: 0x06002CAE RID: 11438 RVA: 0x000FA5DC File Offset: 0x000F87DC
	private void 63(object 1, EventArgs 2)
	{
		if (1226.16 >= 0 && 1226.16 != this.1.7.21.78)
		{
			this.1.8.18((2452)4, (2451)0, this.1.7.21.78);
			this.1.7.21.78 = 1226.16;
			this.1.8.20(false, false);
		}
	}

	// Token: 0x06002CAF RID: 11439 RVA: 0x000FA665 File Offset: 0x000F8865
	private void 64(object 1, EventArgs 2)
	{
		if (DialogResult.OK == MessageBox.Show(1568.1(2679.EditorControl_RecalculateSlidersMessage), "osu!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation))
		{
			this.1.76.17();
		}
	}

	// Token: 0x06002CB0 RID: 11440 RVA: 0x000FA691 File Offset: 0x000F8891
	private void 65(object 1, EventArgs 2)
	{
		this.72.Checked = !this.72.Checked;
		this.1.76.10.15 = this.72.Checked;
	}

	// Token: 0x06002CB1 RID: 11441 RVA: 0x000FA6CC File Offset: 0x000F88CC
	private void 66(object 1, EventArgs 2)
	{
		this.1.76.16((1257)4);
	}

	// Token: 0x06002CB2 RID: 11442 RVA: 0x000FA6DF File Offset: 0x000F88DF
	private void 67(object 1, EventArgs 2)
	{
		this.1.76.16((1257)3);
	}

	// Token: 0x06002CB3 RID: 11443 RVA: 0x000FA6F2 File Offset: 0x000F88F2
	internal void 68(1257 1)
	{
		this.76.Checked = (1 == (1257)3);
		this.75.Checked = (1 == (1257)4);
	}

	// Token: 0x06002CB4 RID: 11444 RVA: 0x000FA712 File Offset: 0x000F8912
	private void 69(object 1, EventArgs 2)
	{
		this.1.76.18(true, null);
	}

	// Token: 0x06002CB5 RID: 11445 RVA: 0x000FA726 File Offset: 0x000F8926
	private void 70(object 1, EventArgs 2)
	{
		this.1.76.3();
	}

	// Token: 0x06002CB6 RID: 11446 RVA: 0x000FA738 File Offset: 0x000F8938
	private void 71()
	{
		this.1.76.18(false, null);
	}

	// Token: 0x06002CB7 RID: 11447 RVA: 0x000FA74C File Offset: 0x000F894C
	private void 72()
	{
		this.1.76.4((2325)1);
	}

	// Token: 0x06002CB8 RID: 11448 RVA: 0x000FA75F File Offset: 0x000F895F
	private void 73(object 1, EventArgs 2)
	{
		this.35.Enabled = this.1.22();
	}

	// Token: 0x06002CB9 RID: 11449 RVA: 0x000FA777 File Offset: 0x000F8977
	private void 74(object 1, EventArgs 2)
	{
		this.1.46(true);
	}

	// Token: 0x06002CBA RID: 11450 RVA: 0x000FA785 File Offset: 0x000F8985
	private void 75(object 1, EventArgs 2)
	{
		this.24(new 1189(this.81));
	}

	// Token: 0x06002CBB RID: 11451 RVA: 0x000FA799 File Offset: 0x000F8999
	private void 76(object 1, EventArgs 2)
	{
		this.24(delegate
		{
			this.121.Checked = !this.121.Checked;
			1304.82.2(this.121.Checked);
		});
	}

	// Token: 0x06002CBC RID: 11452 RVA: 0x000FA7AD File Offset: 0x000F89AD
	private void 77(object 1, EventArgs 2)
	{
		1662.82(true);
		new 2326().Show(1662.13());
		1662.82(false);
	}

	// Token: 0x06002CBD RID: 11453 RVA: 0x000FA7CA File Offset: 0x000F89CA
	private void 78(object 1, EventArgs 2)
	{
		this.1.77(25.0);
	}

	// Token: 0x06002CBE RID: 11454 RVA: 0x000FA7E0 File Offset: 0x000F89E0
	private void 79(object 1, EventArgs 2)
	{
		this.1.77(50.0);
	}

	// Token: 0x06002CBF RID: 11455 RVA: 0x000FA7F6 File Offset: 0x000F89F6
	private void 80(object 1, EventArgs 2)
	{
		this.1.77(75.0);
	}

	// Token: 0x06002CC0 RID: 11456 RVA: 0x000FA80C File Offset: 0x000F8A0C
	private void 81()
	{
		this.107.Checked = !this.107.Checked;
		1304.79.2(this.107.Checked);
	}

	// Token: 0x06002CC1 RID: 11457 RVA: 0x000FA83C File Offset: 0x000F8A3C
	private void 82()
	{
		this.122.Checked = !this.122.Checked;
		1304.83.2(this.122.Checked);
	}

	// Token: 0x0400208D RID: 8333
	private 2263 1;

	// Token: 0x0400208E RID: 8334
	private IContainer 2;

	// Token: 0x0400208F RID: 8335
	private MenuStrip 3;

	// Token: 0x04002090 RID: 8336
	private ToolStripMenuItem 4;

	// Token: 0x04002091 RID: 8337
	private ToolStripMenuItem 5;

	// Token: 0x04002092 RID: 8338
	private ToolStripMenuItem 6;

	// Token: 0x04002093 RID: 8339
	private ToolStripMenuItem 7;

	// Token: 0x04002094 RID: 8340
	private ToolStripMenuItem 8;

	// Token: 0x04002095 RID: 8341
	private ToolStripMenuItem 9;

	// Token: 0x04002096 RID: 8342
	private ToolStripMenuItem 10;

	// Token: 0x04002097 RID: 8343
	private ToolStripMenuItem 11;

	// Token: 0x04002098 RID: 8344
	private ToolStripMenuItem 12;

	// Token: 0x04002099 RID: 8345
	private ToolStripMenuItem 13;

	// Token: 0x0400209A RID: 8346
	private ToolStripMenuItem 14;

	// Token: 0x0400209B RID: 8347
	private ToolStripMenuItem 15;

	// Token: 0x0400209C RID: 8348
	private ToolStripMenuItem 16;

	// Token: 0x0400209D RID: 8349
	private ToolStripMenuItem 17;

	// Token: 0x0400209E RID: 8350
	private ToolStripSeparator 18;

	// Token: 0x0400209F RID: 8351
	private ToolStripMenuItem 19;

	// Token: 0x040020A0 RID: 8352
	private ToolStripSeparator 20;

	// Token: 0x040020A1 RID: 8353
	private ToolStripMenuItem 21;

	// Token: 0x040020A2 RID: 8354
	private ToolStripMenuItem 22;

	// Token: 0x040020A3 RID: 8355
	private ToolStripMenuItem 23;

	// Token: 0x040020A4 RID: 8356
	private ToolStripMenuItem 24;

	// Token: 0x040020A5 RID: 8357
	private ToolStripMenuItem 25;

	// Token: 0x040020A6 RID: 8358
	private ToolStripMenuItem 26;

	// Token: 0x040020A7 RID: 8359
	private ToolStripMenuItem 27;

	// Token: 0x040020A8 RID: 8360
	private ToolStripMenuItem 28;

	// Token: 0x040020A9 RID: 8361
	private ToolStripMenuItem 29;

	// Token: 0x040020AA RID: 8362
	private ToolStripMenuItem 30;

	// Token: 0x040020AB RID: 8363
	private ToolStripMenuItem 31;

	// Token: 0x040020AC RID: 8364
	private ToolStripSeparator 32;

	// Token: 0x040020AD RID: 8365
	private ToolStripMenuItem 33;

	// Token: 0x040020AE RID: 8366
	private ToolStripMenuItem 34;

	// Token: 0x040020AF RID: 8367
	private ToolStripMenuItem 35;

	// Token: 0x040020B0 RID: 8368
	private ToolStripMenuItem 36;

	// Token: 0x040020B1 RID: 8369
	private ToolStripMenuItem 37;

	// Token: 0x040020B2 RID: 8370
	private ToolStripMenuItem 38;

	// Token: 0x040020B3 RID: 8371
	private ToolStripMenuItem 39;

	// Token: 0x040020B4 RID: 8372
	private ToolStripSeparator 40;

	// Token: 0x040020B5 RID: 8373
	private ToolStripMenuItem 41;

	// Token: 0x040020B6 RID: 8374
	private ToolStripMenuItem 42;

	// Token: 0x040020B7 RID: 8375
	private ToolStripMenuItem 43;

	// Token: 0x040020B8 RID: 8376
	private ToolStripMenuItem 44;

	// Token: 0x040020B9 RID: 8377
	private ToolStripMenuItem 45;

	// Token: 0x040020BA RID: 8378
	private ToolStripMenuItem 46;

	// Token: 0x040020BB RID: 8379
	private ToolStripMenuItem 47;

	// Token: 0x040020BC RID: 8380
	private ToolStripMenuItem 48;

	// Token: 0x040020BD RID: 8381
	private ToolStripMenuItem 49;

	// Token: 0x040020BE RID: 8382
	private ToolStripSeparator 50;

	// Token: 0x040020BF RID: 8383
	private ToolStripMenuItem 51;

	// Token: 0x040020C0 RID: 8384
	private ToolStripMenuItem 52;

	// Token: 0x040020C1 RID: 8385
	private ToolStripMenuItem 53;

	// Token: 0x040020C2 RID: 8386
	private ToolStripSeparator 54;

	// Token: 0x040020C3 RID: 8387
	private ToolStripMenuItem 55;

	// Token: 0x040020C4 RID: 8388
	private ToolStripMenuItem 56;

	// Token: 0x040020C5 RID: 8389
	private ToolStripSeparator 57;

	// Token: 0x040020C6 RID: 8390
	private ToolStripMenuItem 58;

	// Token: 0x040020C7 RID: 8391
	private ToolStripMenuItem 59;

	// Token: 0x040020C8 RID: 8392
	private ToolStripMenuItem 60;

	// Token: 0x040020C9 RID: 8393
	private ToolStripMenuItem 61;

	// Token: 0x040020CA RID: 8394
	private ToolStripMenuItem 62;

	// Token: 0x040020CB RID: 8395
	private ToolStripMenuItem 63;

	// Token: 0x040020CC RID: 8396
	private ToolStripMenuItem 64;

	// Token: 0x040020CD RID: 8397
	internal ToolStripMenuItem 65;

	// Token: 0x040020CE RID: 8398
	internal ToolStripMenuItem 66;

	// Token: 0x040020CF RID: 8399
	private ToolStripSeparator 67;

	// Token: 0x040020D0 RID: 8400
	private ToolStripMenuItem 68;

	// Token: 0x040020D1 RID: 8401
	private ToolStripSeparator 69;

	// Token: 0x040020D2 RID: 8402
	private ToolStripMenuItem 70;

	// Token: 0x040020D3 RID: 8403
	private ToolStripMenuItem 71;

	// Token: 0x040020D4 RID: 8404
	private ToolStripMenuItem 72;

	// Token: 0x040020D5 RID: 8405
	private ToolStripMenuItem 73;

	// Token: 0x040020D6 RID: 8406
	private ToolStripMenuItem 74;

	// Token: 0x040020D7 RID: 8407
	private ToolStripMenuItem 75;

	// Token: 0x040020D8 RID: 8408
	private ToolStripMenuItem 76;

	// Token: 0x040020D9 RID: 8409
	private ToolStripMenuItem 77;

	// Token: 0x040020DA RID: 8410
	private ToolStripMenuItem 78;

	// Token: 0x040020DB RID: 8411
	private ToolStripSeparator 79;

	// Token: 0x040020DC RID: 8412
	private ToolStripSeparator 80;

	// Token: 0x040020DD RID: 8413
	private ToolStripMenuItem 81;

	// Token: 0x040020DE RID: 8414
	private ToolStripMenuItem 82;

	// Token: 0x040020DF RID: 8415
	private ToolStripMenuItem 83;

	// Token: 0x040020E0 RID: 8416
	private ToolStripMenuItem 84;

	// Token: 0x040020E1 RID: 8417
	private ToolStripMenuItem 85;

	// Token: 0x040020E2 RID: 8418
	private ToolStripSeparator 86;

	// Token: 0x040020E3 RID: 8419
	private ToolStripMenuItem 87;

	// Token: 0x040020E4 RID: 8420
	private ToolStripMenuItem 88;

	// Token: 0x040020E5 RID: 8421
	private ToolStripMenuItem 89;

	// Token: 0x040020E6 RID: 8422
	private ToolStripMenuItem 90;

	// Token: 0x040020E7 RID: 8423
	private ToolStripMenuItem 91;

	// Token: 0x040020E8 RID: 8424
	private ToolStripSeparator 92;

	// Token: 0x040020E9 RID: 8425
	private ToolStripMenuItem 93;

	// Token: 0x040020EA RID: 8426
	private ToolStripMenuItem 94;

	// Token: 0x040020EB RID: 8427
	private ToolStripSeparator 95;

	// Token: 0x040020EC RID: 8428
	private ToolStripMenuItem 96;

	// Token: 0x040020ED RID: 8429
	private ToolStripMenuItem 97;

	// Token: 0x040020EE RID: 8430
	private ToolStripMenuItem 98;

	// Token: 0x040020EF RID: 8431
	private ToolStripSeparator 99;

	// Token: 0x040020F0 RID: 8432
	private ToolStripSeparator 100;

	// Token: 0x040020F1 RID: 8433
	private ToolStripMenuItem 101;

	// Token: 0x040020F2 RID: 8434
	private ToolStripSeparator 102;

	// Token: 0x040020F3 RID: 8435
	private ToolStripMenuItem 103;

	// Token: 0x040020F4 RID: 8436
	private ToolStripMenuItem 104;

	// Token: 0x040020F5 RID: 8437
	private ToolStripMenuItem 105;

	// Token: 0x040020F6 RID: 8438
	private ToolStripMenuItem 106;

	// Token: 0x040020F7 RID: 8439
	private ToolStripMenuItem 107;

	// Token: 0x040020F8 RID: 8440
	private ToolStripMenuItem 108;

	// Token: 0x040020F9 RID: 8441
	private ToolStripMenuItem 109;

	// Token: 0x040020FA RID: 8442
	private ToolStripMenuItem 110;

	// Token: 0x040020FB RID: 8443
	private ToolStripMenuItem 111;

	// Token: 0x040020FC RID: 8444
	private ToolStripMenuItem 112;

	// Token: 0x040020FD RID: 8445
	private ToolStripMenuItem 113;

	// Token: 0x040020FE RID: 8446
	private ToolStripMenuItem 114;

	// Token: 0x040020FF RID: 8447
	private ToolStripMenuItem 115;

	// Token: 0x04002100 RID: 8448
	private ToolStripMenuItem 116;

	// Token: 0x04002101 RID: 8449
	private ToolStripMenuItem 117;

	// Token: 0x04002102 RID: 8450
	private ToolStripMenuItem 118;

	// Token: 0x04002103 RID: 8451
	private ToolStripMenuItem 119;

	// Token: 0x04002104 RID: 8452
	private ToolStripMenuItem 120;

	// Token: 0x04002105 RID: 8453
	private ToolStripMenuItem 121;

	// Token: 0x04002106 RID: 8454
	private ToolStripMenuItem 122;

	// Token: 0x04002107 RID: 8455
	private ToolStripMenuItem 123;

	// Token: 0x04002108 RID: 8456
	private ToolStripMenuItem 124;

	// Token: 0x020005A3 RID: 1443
	[Serializable]
	public sealed class 2331
	{
		// Token: 0x06002CE5 RID: 11493 RVA: 0x000FAE9B File Offset: 0x000F909B
		internal bool 1(2034 1)
		{
			return 1.16 > 0;
		}

		// Token: 0x04002109 RID: 8457
		public static readonly 2330.2331 instance = new 2330.2331();

		// Token: 0x0400210A RID: 8458
		public static Predicate<2034> cachedHasComboColourOffset;

		// Token: 0x0400210B RID: 8459
		public static Predicate<2275> cachedHasCustomFlag;
	}
}
