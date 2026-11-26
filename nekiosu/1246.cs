using System;

// Token: 0x02000BB3 RID: 2995
public sealed class 1246 : 1240
{
	// Token: 0x0600526E RID: 21102 RVA: 0x0020707F File Offset: 0x0020527F
	internal override void Seek(double 1)
	{
		this.9 = 1;
	}

	// Token: 0x0600526F RID: 21103 RVA: 0x00207088 File Offset: 0x00205288
	internal override void Play(bool 1 = true)
	{
		if (1)
		{
			this.9 = 0.0;
		}
		this.8 = true;
	}

	// Token: 0x06005270 RID: 21104 RVA: 0x002070A3 File Offset: 0x002052A3
	internal override void Pause()
	{
		this.8 = false;
	}

	// Token: 0x06005271 RID: 21105 RVA: 0x002070AC File Offset: 0x002052AC
	public override bool IsPlaying()
	{
		return this.8;
	}

	// Token: 0x06005272 RID: 21106 RVA: 0x002070B4 File Offset: 0x002052B4
	internal override double GetPosition()
	{
		return this.9;
	}

	// Token: 0x06005273 RID: 21107 RVA: 0x00100553 File Offset: 0x000FE753
	internal override float GetVolume()
	{
		return 0f;
	}

	// Token: 0x06005274 RID: 21108 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void SetVolume(float 1)
	{
	}

	// Token: 0x06005275 RID: 21109 RVA: 0x002070BC File Offset: 0x002052BC
	public override void Update()
	{
		if (1662.115 != this.10 && this.8)
		{
			this.9 += 1662.82 * this.11 / 100.0;
			this.10 = 1662.115;
		}
	}

	// Token: 0x06005276 RID: 21110 RVA: 0x0020710C File Offset: 0x0020530C
	public override double GetPlaybackRate()
	{
		return this.11;
	}

	// Token: 0x06005277 RID: 21111 RVA: 0x00207114 File Offset: 0x00205314
	public override void SetPlaybackRate(double 1)
	{
		if (1 != this.11)
		{
			this.11 = 1;
		}
	}

	// Token: 0x06005278 RID: 21112 RVA: 0x0001702D File Offset: 0x0001522D
	internal override bool ShouldScaleEffectsWithRate()
	{
		return true;
	}

	// Token: 0x04003EC9 RID: 16073
	private bool 8;

	// Token: 0x04003ECA RID: 16074
	private double 9;

	// Token: 0x04003ECB RID: 16075
	private long 10;

	// Token: 0x04003ECC RID: 16076
	private double 11 = 100.0;
}
