using System;
using System.IO;

// Token: 0x02000BAD RID: 2989
public abstract class 1240 : IDisposable
{
	// Token: 0x06005230 RID: 21040 RVA: 0x0020645C File Offset: 0x0020465C
	private static 1246 1(1262 1)
	{
		return new 1246
		{
			4 = (double)((1.87 < 0) ? 600000 : (1.87 + 10000))
		};
	}

	// Token: 0x06005231 RID: 21041 RVA: 0x00206488 File Offset: 0x00204688
	internal static 1240 Create(1262 1, bool 2, bool 3, 1240 4)
	{
		1240 5 = null;
		1241 6 = 4 as 1241;
		Stream stream = (6 == null || 6.1 != 1 || 6.10 == null) ? 1.46() : new 1251(1.46(), 2 ? 4 : -1, 6.10);
		if (stream == null)
		{
			5 = 1240.1(1);
		}
		else
		{
			try
			{
				5 = new 1241(stream, 2, 3);
			}
			catch (1043)
			{
				5 = 1240.1(1);
			}
		}
		if (5 != null)
		{
			5.1 = 1;
		}
		return 5;
	}

	// Token: 0x06005232 RID: 21042 RVA: 0x00206514 File Offset: 0x00204714
	~1240()
	{
		if (!this.2)
		{
			this.ReleaseResources(false);
		}
	}

	// Token: 0x06005233 RID: 21043 RVA: 0x0020654C File Offset: 0x0020474C
	public void Dispose()
	{
		this.2 = true;
		this.ReleaseResources(true);
	}

	// Token: 0x06005234 RID: 21044 RVA: 0x00005ADD File Offset: 0x00003CDD
	protected virtual void ReleaseResources(bool 1)
	{
	}

	// Token: 0x06005235 RID: 21045
	internal abstract float GetVolume();

	// Token: 0x06005236 RID: 21046
	internal abstract void SetVolume(float 1);

	// Token: 0x06005237 RID: 21047 RVA: 0x0020655C File Offset: 0x0020475C
	internal virtual bool IsDirectStream()
	{
		return this.3;
	}

	// Token: 0x06005238 RID: 21048 RVA: 0x00206564 File Offset: 0x00204764
	internal virtual void SetDirectStream(bool 1)
	{
		this.3 = 1;
	}

	// Token: 0x06005239 RID: 21049 RVA: 0x0001702D File Offset: 0x0001522D
	internal virtual bool IsStreamAvailable()
	{
		return true;
	}

	// Token: 0x0600523A RID: 21050 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal virtual void SetPitchShift(float 1)
	{
	}

	// Token: 0x0600523B RID: 21051 RVA: 0x001752CC File Offset: 0x001734CC
	internal virtual float GetPitchFactor()
	{
		return 1f;
	}

	// Token: 0x0600523C RID: 21052 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal virtual void ApplyChannelSettings()
	{
	}

	// Token: 0x0600523D RID: 21053
	internal abstract double GetPosition();

	// Token: 0x0600523E RID: 21054 RVA: 0x0020656D File Offset: 0x0020476D
	internal int 2()
	{
		return this.5;
	}

	// Token: 0x0600523F RID: 21055 RVA: 0x00206575 File Offset: 0x00204775
	internal void 3(int 1)
	{
		this.5 = 1;
	}

	// Token: 0x06005240 RID: 21056
	internal abstract void Seek(double 1);

	// Token: 0x06005241 RID: 21057
	internal abstract void Play(bool 1);

	// Token: 0x06005242 RID: 21058
	internal abstract void Pause();

	// Token: 0x06005243 RID: 21059
	public abstract bool IsPlaying();

	// Token: 0x06005244 RID: 21060
	public abstract void Update();

	// Token: 0x06005245 RID: 21061 RVA: 0x0020657E File Offset: 0x0020477E
	internal void 4()
	{
		this.Pause();
		this.Seek(0.0);
	}

	// Token: 0x06005246 RID: 21062
	public abstract double GetPlaybackRate();

	// Token: 0x06005247 RID: 21063
	public abstract void SetPlaybackRate(double 1);

	// Token: 0x06005248 RID: 21064 RVA: 0x00206595 File Offset: 0x00204795
	public virtual bool GetPreservePitch()
	{
		return this.7;
	}

	// Token: 0x06005249 RID: 21065 RVA: 0x0020659D File Offset: 0x0020479D
	public virtual void SetPreservePitch(bool 1)
	{
		this.7 = 1;
	}

	// Token: 0x0600524A RID: 21066 RVA: 0x002065A6 File Offset: 0x002047A6
	internal virtual bool ShouldScaleEffectsWithRate()
	{
		return this.1 != null && this.1.93;
	}

	// Token: 0x04003EA3 RID: 16035
	internal 1262 1;

	// Token: 0x04003EA4 RID: 16036
	internal bool 2;

	// Token: 0x04003EA5 RID: 16037
	private bool 3;

	// Token: 0x04003EA6 RID: 16038
	internal double 4;

	// Token: 0x04003EA7 RID: 16039
	private int 5;

	// Token: 0x04003EA8 RID: 16040
	internal int 6;

	// Token: 0x04003EA9 RID: 16041
	private bool 7;
}
