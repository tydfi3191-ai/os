using System;

// Token: 0x02000762 RID: 1890
public sealed class 2003 : 2506
{
	// Token: 0x06003782 RID: 14210 RVA: 0x0015C010 File Offset: 0x0015A210
	internal 2003(2011 1) : base(1.6)
	{
		this.3.9(true);
		this.2.14 = -1.5707964f;
		this.1.14 = -1.5707964f;
		this.2.15 = 0.7f;
		this.1.15 = 0.7f;
		this.2.20 = new 208(1f, 1.37());
		this.1.20 = new 208(1f, 1.37());
		this.2.17 = new 208(1.28() + 1.20 + 1f, 1.26() + 1.24());
		if (this.18)
		{
			this.1.17 = new 208(1.28() + 1.20 + 6.6f, 1.26() + 474.8f * 1.37());
		}
		else
		{
			this.1.17 = new 208(1.28() + 1.20 + 8f, 1.26() + 478f * 1.37());
		}
		this.9 = false;
		this.7.14<1433>(this.8);
	}

	// Token: 0x06003783 RID: 14211 RVA: 0x0013CC09 File Offset: 0x0013AE09
	protected override 1381[] GetFrames(string 1)
	{
		return 1455.5(1, (1416)3, true);
	}

	// Token: 0x06003784 RID: 14212 RVA: 0x0013CBFF File Offset: 0x0013ADFF
	protected override 1381 GetTexture(string 1)
	{
		return 1455.2(1, (1416)3, null);
	}

	// Token: 0x06003785 RID: 14213 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void Method3946()
	{
	}

	// Token: 0x06003786 RID: 14214 RVA: 0x0015C16C File Offset: 0x0015A36C
	internal override void SetAlpha(float 1)
	{
		1371 2 = this.2;
		this.1.16 = 1;
		2.16 = 1;
	}

	// Token: 0x06003787 RID: 14215 RVA: 0x00005ADD File Offset: 0x00003CDD
	protected override void UpdateMarkerPosition()
	{
	}

	// Token: 0x06003788 RID: 14216 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void AddMarkerBurst()
	{
	}

	// Token: 0x06003789 RID: 14217 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void PulseMarker()
	{
	}

	// Token: 0x0600378A RID: 14218 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void FadeMarkerColour(198 1)
	{
	}

	// Token: 0x0600378B RID: 14219 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void Show()
	{
	}

	// Token: 0x0600378C RID: 14220 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal override void Hide()
	{
	}

	// Token: 0x0600378D RID: 14221 RVA: 0x0015C193 File Offset: 0x0015A393
	internal override void ResetToFull()
	{
		base.ResetToFull();
		this.SetHealth(200.0);
	}
}
