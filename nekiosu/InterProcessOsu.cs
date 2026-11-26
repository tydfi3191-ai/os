using System;
using System.Windows.Forms;

// Token: 0x02000A31 RID: 2609
public class InterProcessOsu : MarshalByRefObject
{
	// Token: 0x06004842 RID: 18498 RVA: 0x001CB180 File Offset: 0x001C9380
	public void HandleArguments(string 1)
	{
		InterProcessOsu.1525 handleArgumentsClosure = new InterProcessOsu.1525();
		handleArgumentsClosure.1 = 1;
		1662.89.Schedule(delegate()
		{
			1677 2 = 1662.65(new string[]
			{
				handleArgumentsClosure.1
			});
			if (2 != 1677.Unknown)
			{
				if (1662.12 && 1662.13().Visible)
				{
					1662.13().WindowState = FormWindowState.Normal;
					1662.102();
				}
				1662.SetMode(2, true);
			}
		}, false);
	}

	// Token: 0x06004843 RID: 18499 RVA: 0x001CB1C2 File Offset: 0x001C93C2
	public bool WakeUp()
	{
		1662.108(false);
		return true;
	}

	// Token: 0x06004844 RID: 18500 RVA: 0x001CB1CB File Offset: 0x001C93CB
	public void Quit()
	{
		1522.3();
		1662.89.Schedule(delegate()
		{
			1662.SetMode(1677.Exit, false);
		}, true);
	}

	// Token: 0x06004845 RID: 18501 RVA: 0x001CB200 File Offset: 0x001C9400
	public InterProcessOsu.1524 GetBulkClientData()
	{
		return new InterProcessOsu.1524
		{
			Buffering = 1662.52,
			AudioTime = this.GetCurrentTime(),
			ReplayTime = this.GetAvailableTime(),
			SpectatingID = this.GetSpectatingId(),
			Score = (this.lastScore = this.GetCurrentScore()),
			Mode = this.GetCurrentMode(),
			SkipCalculations = 1662.53,
			BeatmapChecksum = ((1272.5() == null) ? string.Empty : 1272.5().23),
			BeatmapId = ((1272.5() == null) ? -1 : 1272.5().25),
			DimLevel = 2648.35,
			MenuTime = 1226.16,
			AudioPlaying = !1226.10(),
			LLastAction = 1571.Standard,
			LNextScoreSync = 0,
			LPlayerLoaded = (2486.7 != null),
			LReplayMode = 1535.1(),
			LReplayStreaming = 1535.40,
			LReplayFrame = 1535.33,
			LReplayToEnd = 1535.42
		};
	}

	// Token: 0x06004846 RID: 18502 RVA: 0x001CB311 File Offset: 0x001C9511
	public int GetCurrentTime()
	{
		return int.MaxValue;
	}

	// Token: 0x06004847 RID: 18503 RVA: 0x001CB311 File Offset: 0x001C9511
	public int GetAvailableTime()
	{
		return int.MaxValue;
	}

	// Token: 0x06004848 RID: 18504 RVA: 0x001CB318 File Offset: 0x001C9518
	public void ToggleClientBuffer()
	{
		if (1662.47)
		{
			1662.89.Schedule(new 1189(InterProcessOsu.1526.instance.1), false);
		}
	}

	// Token: 0x06004849 RID: 18505 RVA: 0x001CB33D File Offset: 0x001C953D
	public void ToggleSkipCalculations()
	{
		if (1662.47)
		{
			1662.89.Schedule(new 1189(InterProcessOsu.1526.instance.2), false);
		}
	}

	// Token: 0x0600484A RID: 18506 RVA: 0x001CB364 File Offset: 0x001C9564
	public void SetMenuTime(int 1)
	{
		InterProcessOsu.1528 2 = new InterProcessOsu.1528();
		2.2 = 1;
		if (1662.47 && 1662.76 == (932)2)
		{
			2.1 = 1662.32.ElapsedMilliseconds;
			1662.89.Schedule(new 1189(2.1), false);
		}
	}

	// Token: 0x0600484B RID: 18507 RVA: 0x001CB3B8 File Offset: 0x001C95B8
	public void SetSpectate(int 1)
	{
		InterProcessOsu.1529 2 = new InterProcessOsu.1529();
		2.1 = 1;
		if (1662.47 && 1662.76 == (932)2)
		{
			1662.89.Schedule(new 1189(2.1), false);
		}
	}

	// Token: 0x0600484C RID: 18508 RVA: 0x001CB3FC File Offset: 0x001C95FC
	public void SetBeatmap(string 1)
	{
		InterProcessOsu.1527 2 = new InterProcessOsu.1527();
		2.1 = 1;
		if (1662.47 && 1662.76 == (932)2 && 1662.78 != 1677.Play)
		{
			1662.89.Schedule(new 1189(2.1), false);
		}
	}

	// Token: 0x0600484D RID: 18509 RVA: 0x001CB445 File Offset: 0x001C9645
	public void PlayAudio()
	{
		if (1226.10())
		{
			1662.89.Schedule(new 1189(InterProcessOsu.1526.instance.3), false);
		}
	}

	// Token: 0x0600484E RID: 18510 RVA: 0x001CB46C File Offset: 0x001C966C
	public int GetCurrentScore()
	{
		if (!1662.47)
		{
			return 0;
		}
		2486 <<EMPTY_NAME>> = 2486.7;
		if (<<EMPTY_NAME>> != null && <<EMPTY_NAME>>.80 == (707)0)
		{
			return 0;
		}
		2241 2 = 2486.88;
		if (2 == null)
		{
			return this.lastScore;
		}
		if (!2486.4)
		{
			return 2.GetScore();
		}
		return 0;
	}

	// Token: 0x0600484F RID: 18511 RVA: 0x001CB4B4 File Offset: 0x001C96B4
	public void SetUserDim(int 1)
	{
		InterProcessOsu.1530 2 = new InterProcessOsu.1530();
		2.1 = 1;
		if (1662.47)
		{
			1662.89.Schedule(new 1189(2.1), false);
		}
	}

	// Token: 0x06004850 RID: 18512 RVA: 0x001CB4ED File Offset: 0x001C96ED
	public 1677 GetCurrentMode()
	{
		1522.3 = 1662.33;
		return 1662.78;
	}

	// Token: 0x06004851 RID: 18513 RVA: 0x0013FA9F File Offset: 0x0013DC9F
	public int GetSpectatingId()
	{
		return -1;
	}

	// Token: 0x06004852 RID: 18514 RVA: 0x001CB500 File Offset: 0x001C9700
	public void ChangeMode(1677 1)
	{
		InterProcessOsu.1523 2 = new InterProcessOsu.1523();
		2.1 = 1;
		if (1662.47)
		{
			1662.89.Schedule(new 1189(2.1), false);
		}
	}

	// Token: 0x0400354C RID: 13644
	private int lastScore;

	// Token: 0x02000A32 RID: 2610
	public sealed class 1528
	{
		// Token: 0x06004854 RID: 18516 RVA: 0x001CB53C File Offset: 0x001C973C
		internal void 1()
		{
			long num = 1662.32.ElapsedMilliseconds - this.1;
			if (1662.78 == 1677.Menu)
			{
				1226.4(this.2 + (int)num, false, true);
			}
		}

		// Token: 0x0400354D RID: 13645
		public long 1;

		// Token: 0x0400354E RID: 13646
		public int 2;
	}

	// Token: 0x02000A33 RID: 2611
	[Serializable]
	public sealed class 1526
	{
		// Token: 0x06004856 RID: 18518 RVA: 0x001CB572 File Offset: 0x001C9772
		internal void 1()
		{
			1662.52 = !1662.52;
		}

		// Token: 0x06004857 RID: 18519 RVA: 0x001CB581 File Offset: 0x001C9781
		internal void 2()
		{
			1662.53 = !1662.53;
		}

		// Token: 0x06004858 RID: 18520 RVA: 0x000DD551 File Offset: 0x000DB751
		internal void 3()
		{
			1226.Pause();
		}

		// Token: 0x0400354F RID: 13647
		public static readonly InterProcessOsu.1526 instance = new InterProcessOsu.1526();

		// Token: 0x04003550 RID: 13648
		public static 1189 voidDelegate;

		// Token: 0x04003551 RID: 13649
		public static 1189 voidDelegate2;

		// Token: 0x04003552 RID: 13650
		public static 1189 voidDelegate3;
	}

	// Token: 0x02000A34 RID: 2612
	public sealed class 1529
	{
		// Token: 0x0600485B RID: 18523 RVA: 0x00005ADD File Offset: 0x00003CDD
		internal void 1()
		{
		}

		// Token: 0x04003553 RID: 13651
		public int 1;
	}

	// Token: 0x02000A35 RID: 2613
	public sealed class 1523
	{
		// Token: 0x0600485D RID: 18525 RVA: 0x001CB59C File Offset: 0x001C979C
		internal void 1()
		{
			1662.SetMode(this.1, false);
		}

		// Token: 0x04003554 RID: 13652
		public 1677 1;
	}

	// Token: 0x02000A36 RID: 2614
	public sealed class 1527
	{
		// Token: 0x0600485F RID: 18527 RVA: 0x001CB5AC File Offset: 0x001C97AC
		internal void 1()
		{
			1262 <<EMPTY_NAME>> = 1272.8(this.1);
			if (<<EMPTY_NAME>> == null)
			{
				1272.28(true);
				<<EMPTY_NAME>> = 1272.8(this.1);
			}
			if (1272.5() != <<EMPTY_NAME>> && <<EMPTY_NAME>> != null)
			{
				1272.SetCurrentBeatmap(<<EMPTY_NAME>>);
				1226.106(1272.5(), true, true, false);
			}
		}

		// Token: 0x04003555 RID: 13653
		public string 1;
	}

	// Token: 0x02000A37 RID: 2615
	public sealed class 1525
	{
		// Token: 0x04003556 RID: 13654
		public string 1;
	}

	// Token: 0x02000A38 RID: 2616
	public sealed class 1530
	{
		// Token: 0x06004862 RID: 18530 RVA: 0x001CB5FA File Offset: 0x001C97FA
		internal void 1()
		{
			2648.35 = this.1;
		}

		// Token: 0x04003557 RID: 13655
		public int 1;
	}

	// Token: 0x02000A39 RID: 2617
	[Serializable]
	public class 1524
	{
		// Token: 0x04003558 RID: 13656
		public bool Buffering;

		// Token: 0x04003559 RID: 13657
		public 1677 Mode;

		// Token: 0x0400355A RID: 13658
		public int SpectatingID;

		// Token: 0x0400355B RID: 13659
		public int Score;

		// Token: 0x0400355C RID: 13660
		public int AudioTime;

		// Token: 0x0400355D RID: 13661
		public int ReplayTime;

		// Token: 0x0400355E RID: 13662
		[NonSerialized]
		public bool pausedByAudioStop;

		// Token: 0x0400355F RID: 13663
		public bool SkipCalculations;

		// Token: 0x04003560 RID: 13664
		public string BeatmapChecksum;

		// Token: 0x04003561 RID: 13665
		public int BeatmapId;

		// Token: 0x04003562 RID: 13666
		public int DimLevel;

		// Token: 0x04003563 RID: 13667
		public int MenuTime;

		// Token: 0x04003564 RID: 13668
		public bool AudioPlaying;

		// Token: 0x04003565 RID: 13669
		public 1571 LLastAction;

		// Token: 0x04003566 RID: 13670
		public int LNextScoreSync;

		// Token: 0x04003567 RID: 13671
		public bool LReplayToEnd;

		// Token: 0x04003568 RID: 13672
		public bool LPlayerLoaded;

		// Token: 0x04003569 RID: 13673
		public bool LReplayMode;

		// Token: 0x0400356A RID: 13674
		public bool LReplayStreaming;

		// Token: 0x0400356B RID: 13675
		public int LReplayFrame;

		// Token: 0x0400356C RID: 13676
		[NonSerialized]
		public double stateTimeAtPoll;
	}
}
