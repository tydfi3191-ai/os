using System;
using System.Collections.Generic;

// Token: 0x020004F6 RID: 1270
[276]
public sealed class 2561 : 2486
{
	// Token: 0x060026C8 RID: 9928 RVA: 0x000BFE74 File Offset: 0x000BE074
	protected override bool IsScoreV2()
	{
		2023 <<EMPTY_NAME>> = 1535.39.8;
		2023 2 = 2023.ScoreV2;
		return (<<EMPTY_NAME>> & 2) > 2023.None || 1535.39.39 != null;
	}

	// Token: 0x060026C9 RID: 9929 RVA: 0x000BFEAA File Offset: 0x000BE0AA
	protected override void Dispose(bool 1)
	{
		if (this.210 != null)
		{
			this.210.Dispose();
		}
		2513 2 = this.212;
		if (2 != null)
		{
			2.Dispose();
		}
		this.212 = null;
		base.Dispose(1);
	}

	// Token: 0x060026CA RID: 9930 RVA: 0x000BFEE0 File Offset: 0x000BE0E0
	protected override void PrepareReplayPlayback()
	{
		this.210 = new 2555(this);
		this.210.Initialize();
		if (2513.2())
		{
			if ((2019.1 & 2023.Autoplay) != 2023.None && this.212 == null)
			{
				this.212 = new 2513(this, delegate()
				{
					this.ReturnToSongSelect();
				});
				this.211 = true;
			}
			else
			{
				2513.3();
			}
		}
		1662.84 = false;
		1535.36 = (2560)0;
		1535.33 = 0;
		1535.21();
		if (1535.41 > 0)
		{
			2486.88 = 1535.39;
			2486.88.11 = new List<208>();
			2486.88.27 = new List<int>(1272.5().65);
			base.151(this.39.21, true);
		}
		if (1535.39.26.Count >= 2 && 1535.39.26[1].10 < 1535.39.26[0].10)
		{
			1535.39.26[1].10 = 1535.39.26[0].10;
			1535.39.26[0].10 = 0;
		}
		if (1535.39.26.Count >= 3 && 1535.39.26[0].10 > 1535.39.26[2].10)
		{
			1535.39.26[0].10 = (1535.39.26[1].10 = 1535.39.26[2].10);
		}
	}

	// Token: 0x060026CB RID: 9931 RVA: 0x000C00A8 File Offset: 0x000BE2A8
	protected override bool HandleGameplayKeyDown(object 1, 200 2)
	{
		if (this.212 != null && 1662.76 == (932)2 && this.212.7(2))
		{
			return true;
		}
		if (2 <= 200.Right)
		{
			if (2 != 200.Space)
			{
				if (2 == 200.Left)
				{
					base.136(-5.0 * base.ReplayUserRate);
					return true;
				}
				if (2 == 200.Right)
				{
					base.136(5.0 * base.ReplayUserRate);
					return true;
				}
			}
			else
			{
				if (!base.CanControlReplay || 1226.16 < this.67)
				{
					return base.HandleGameplayKeyDown(1, 2);
				}
				base.132();
				return true;
			}
		}
		else
		{
			if (2 == 200.H)
			{
				this.211 = !this.211;
				return true;
			}
			if (2 == 200.OemComma)
			{
				base.138(-1);
				return true;
			}
			if (2 == 200.OemPeriod)
			{
				base.138(1);
				return true;
			}
		}
		return base.HandleGameplayKeyDown(1, 2);
	}

	// Token: 0x060026CC RID: 9932 RVA: 0x000C0188 File Offset: 0x000BE388
	protected override bool HandleBeatmapLoadCompleted(bool 1)
	{
		2241 2 = 1535.39;
		bool flag = 2.43 != null || 2.45 || 2.47 || (2.52 != null && !2.52.IsEmpty);
		if (2.8 > 2023.None || flag)
		{
			this.210.19(44);
		}
		2023 3 = 2023.Cinema;
		2023 4 = 2019.1;
		2023 5 = 3;
		if ((4 & 5) > 2023.None)
		{
			if (this.58.11 != null)
			{
				this.58.11.1();
				this.58.11 = null;
			}
			if (this.86 != null)
			{
				this.86.Dispose();
				this.86 = null;
			}
		}
		return base.HandleBeatmapLoadCompleted(1);
	}

	// Token: 0x060026CD RID: 9933 RVA: 0x000ABB9B File Offset: 0x000A9D9B
	public override void Initialize()
	{
		base.Initialize();
	}

	// Token: 0x060026CE RID: 9934 RVA: 0x000C024C File Offset: 0x000BE44C
	protected override void DrawAdditionalOverlay()
	{
		2023 <<EMPTY_NAME>> = 2023.Cinema;
		2023 2 = 2019.1;
		2023 3 = <<EMPTY_NAME>>;
		if ((2 & 3) <= 2023.None && !this.211)
		{
			if (1535.1())
			{
				this.210.Draw();
			}
			base.DrawAdditionalOverlay();
		}
	}

	// Token: 0x060026CF RID: 9935 RVA: 0x000C028C File Offset: 0x000BE48C
	public override void Update()
	{
		if (!this.94.3)
		{
			base.Update();
			return;
		}
		if (1535.40)
		{
			if (1535.4 && !2486.13)
			{
				this.RequestPauseToggle();
			}
			else if (!1535.4 && 2486.13)
			{
				this.RequestPauseToggle();
			}
		}
		this.210.Update();
		base.Update();
		base.162();
		2513 <<EMPTY_NAME>> = this.212;
		if (<<EMPTY_NAME>> == null)
		{
			return;
		}
		<<EMPTY_NAME>>.4();
	}

	// Token: 0x060026D0 RID: 9936 RVA: 0x000C0308 File Offset: 0x000BE508
	public override void Draw()
	{
		if (this.39 != null)
		{
			2023 <<EMPTY_NAME>> = 2023.Cinema;
			2023 2 = 2019.1;
			2023 3 = <<EMPTY_NAME>>;
			if ((2 & 3) > 2023.None)
			{
				this.39.39.5 = 0.01f;
				this.71.5 = 0f;
				this.79.5 = 0f;
				this.77.5 = 0f;
				this.76.5 = 0f;
				this.72.5 = 0f;
				this.73.5 = 0f;
			}
		}
		base.Draw();
		if (this.94.3 && this.210 != null && 1535.1() && !this.211 && !2486.13 && (2019.1 & 2023.Cinema) <= 2023.None)
		{
			this.210.18();
		}
		if (this.94.3)
		{
			2513 4 = this.212;
			if (4 == null)
			{
				return;
			}
			4.5();
		}
	}

	// Token: 0x060026D1 RID: 9937 RVA: 0x000C0410 File Offset: 0x000BE610
	protected override void DrawGameplay()
	{
		2023 <<EMPTY_NAME>> = 2023.Cinema;
		2023 2 = 2019.1;
		2023 3 = <<EMPTY_NAME>>;
		if ((2 & 3) > 2023.None)
		{
			this.39.8();
			return;
		}
		base.DrawGameplay();
	}

	// Token: 0x060026D2 RID: 9938 RVA: 0x000C0444 File Offset: 0x000BE644
	public override bool CanHideGameplayCursor()
	{
		2023 <<EMPTY_NAME>> = 2023.Cinema;
		2023 2 = 2019.1;
		2023 3 = <<EMPTY_NAME>>;
		return (2 & 3) > 2023.None || base.CanHideGameplayCursor();
	}

	// Token: 0x060026D3 RID: 9939 RVA: 0x000C046C File Offset: 0x000BE66C
	protected override void DrawScoreboard()
	{
		2023 <<EMPTY_NAME>> = 2023.Cinema;
		2023 2 = 2019.1;
		2023 3 = <<EMPTY_NAME>>;
		if ((2 & 3) <= 2023.None && !this.211)
		{
			base.DrawScoreboard();
		}
	}

	// Token: 0x060026D4 RID: 9940 RVA: 0x000C049C File Offset: 0x000BE69C
	protected override bool CanFadePlayfieldForSpinner()
	{
		2023 <<EMPTY_NAME>> = 2023.Cinema;
		2023 2 = 2019.1;
		2023 3 = <<EMPTY_NAME>>;
		return (2 & 3) <= 2023.None && base.CanFadePlayfieldForSpinner();
	}

	// Token: 0x060026D5 RID: 9941 RVA: 0x000C04C4 File Offset: 0x000BE6C4
	internal override void ShowResultsScreen(bool 1 = false)
	{
		2023 2 = 2023.Cinema;
		2023 3 = 2019.1;
		2023 4 = 2;
		if ((3 & 4) > 2023.None)
		{
			1662.SetMode(1677.SelectPlay, false);
			return;
		}
		base.ShowResultsScreen(1);
	}

	// Token: 0x04001BD4 RID: 7124
	private 2555 210;

	// Token: 0x04001BD5 RID: 7125
	private bool 211;

	// Token: 0x04001BD6 RID: 7126
	private 2513 212;
}
