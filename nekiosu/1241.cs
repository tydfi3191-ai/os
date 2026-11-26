using System;
using System.IO;
using System.Runtime.InteropServices;

// Token: 0x02000BAE RID: 2990
public sealed class 1241 : 1240
{
	// Token: 0x0600524C RID: 21068 RVA: 0x002065C0 File Offset: 0x002047C0
	internal 1241(Stream 1, bool 2 = false, bool 3 = false)
	{
		this.16 = new 1009(new 1006(this.6), new 1007(this.7), new 1010(this.8), new 1011(this.9));
		this.SetDirectStream(2);
		this.15 = 3;
		1012 4 = (1012)((!this.IsDirectStream()) ? 2228224 : 1219.StreamFlags);
		if (1 == null)
		{
			throw new 1043();
		}
		this.10 = (1 as 1251);
		if (this.10 == null)
		{
			this.10 = new 1251(1, 2 ? 8 : -1, null);
		}
		this.6 = 1025.BASS_StreamCreateFileUser((1032)0, 4, this.16, IntPtr.Zero);
		if (this.6 == 0)
		{
			1251 5 = this.10;
			if (5 != null)
			{
				5.Dispose();
			}
			throw new 1043();
		}
		935 6 = 1025.1(this.6).3;
		if (6 <= 935.BASS_CTYPE_STREAM_MP3)
		{
			if (6 == 935.BASS_CTYPE_STREAM_OGG || 6 - 935.BASS_CTYPE_STREAM_MP2 <= 1)
			{
				goto IL_15E;
			}
		}
		else if (6 == 935.BASS_CTYPE_STREAM_WAV || 6 == 935.BASS_CTYPE_STREAM_WAV_PCM || 6 == 935.BASS_CTYPE_STREAM_WAV_FLOAT)
		{
			goto IL_15E;
		}
		1025.BASS_StreamFree(this.6);
		1251 7 = this.10;
		if (7 != null)
		{
			7.Dispose();
		}
		throw new 1043();
		IL_15E:
		if (this.IsDirectStream())
		{
			base.3(this.8 = this.6);
		}
		else
		{
			base.3(this.8 = 1018.BASS_FX_TempoCreate(this.6, (1012)(1219.StreamFlags | (3 ? 4 : 0))));
			this.9 = 1018.BASS_FX_ReverseCreate(this.6, 5f, (1012)0);
			1025.BASS_ChannelSetAttribute(base.2(), (994)65554, 1f);
			1025.BASS_ChannelSetAttribute(base.2(), (994)65557, 4f);
			1025.BASS_ChannelSetAttribute(base.2(), (994)65555, 30f);
			1219.1(base.2());
		}
		1219.2(base.2());
		this.4 = 1025.BASS_ChannelBytes2Seconds(base.2(), 1025.3(base.2())) * 1000.0;
		1025.BASS_ChannelGetAttribute(base.2(), (994)1, ref this.12);
		this.13 = this.12;
		1226.101(this);
	}

	// Token: 0x0600524D RID: 21069 RVA: 0x00206830 File Offset: 0x00204A30
	internal override void ApplyChannelSettings()
	{
		1025.BASS_ChannelSetAttribute(base.2(), (994)2, 1226.57);
		1025.BASS_ChannelSetAttribute(base.2(), (994)1, this.12);
		1025.BASS_ChannelSetAttribute(base.2(), (994)65536, (float)(1226.38() - 100.0));
		this.13 = this.12;
		this.14 = 0f;
		base.ApplyChannelSettings();
	}

	// Token: 0x0600524E RID: 21070 RVA: 0x002068A0 File Offset: 0x00204AA0
	internal override void SetPitchShift(float 1)
	{
		if (this.IsDirectStream() || base.2() == 0 || 1 == this.14)
		{
			return;
		}
		this.14 = 1;
		this.10();
	}

	// Token: 0x0600524F RID: 21071 RVA: 0x002068C9 File Offset: 0x00204AC9
	internal override float GetPitchFactor()
	{
		if (this.14 != 0f)
		{
			return (float)Math.Pow(2.0, (double)this.14 / 12.0);
		}
		return 1f;
	}

	// Token: 0x06005250 RID: 21072 RVA: 0x00206900 File Offset: 0x00204B00
	protected override void ReleaseResources(bool 1)
	{
		if (base.2() != 0)
		{
			1219.6(base.2());
		}
		if (this.8 != 0)
		{
			1219.3(this.8);
		}
		if (this.9 != 0)
		{
			1025.BASS_StreamFree(this.9);
		}
		if (this.6 != 0)
		{
			1025.BASS_StreamFree(this.6);
		}
		base.3(0);
		this.8 = 0;
		this.9 = 0;
		this.6 = 0;
		this.11 = (1042)0;
		if (this.10 != null)
		{
			this.10.Dispose();
		}
		this.10 = null;
		1226.102(this);
		base.ReleaseResources(1);
	}

	// Token: 0x06005251 RID: 21073 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal override bool IsStreamAvailable()
	{
		return false;
	}

	// Token: 0x06005252 RID: 21074 RVA: 0x002069A6 File Offset: 0x00204BA6
	internal override void Pause()
	{
		if (this.IsPlaying())
		{
			this.5();
		}
	}

	// Token: 0x06005253 RID: 21075 RVA: 0x002069B7 File Offset: 0x00204BB7
	internal bool 5()
	{
		if (this.2)
		{
			return false;
		}
		if (this.IsPlaying())
		{
			1219.Pause(base.2());
			this.11 = (1042)0;
			return true;
		}
		1219.Play(base.2(), false);
		this.11 = (1042)1;
		return false;
	}

	// Token: 0x06005254 RID: 21076 RVA: 0x002069F5 File Offset: 0x00204BF5
	internal override void Play(bool 1 = true)
	{
		this.11 = (1042)1;
		1219.Play(base.2(), 1);
	}

	// Token: 0x06005255 RID: 21077 RVA: 0x00206A0B File Offset: 0x00204C0B
	internal override void Seek(double 1)
	{
		1219.9(base.2(), 1 / 1000.0);
	}

	// Token: 0x06005256 RID: 21078 RVA: 0x00005ADD File Offset: 0x00003CDD
	private new void 6(IntPtr 1)
	{
	}

	// Token: 0x06005257 RID: 21079 RVA: 0x00206A24 File Offset: 0x00204C24
	private long 7(IntPtr 1)
	{
		if (this.10 == null)
		{
			return 0L;
		}
		try
		{
			return this.10.Length;
		}
		catch
		{
		}
		return 0L;
	}

	// Token: 0x06005258 RID: 21080 RVA: 0x00206A64 File Offset: 0x00204C64
	private int 8(IntPtr 1, int 2, IntPtr 3)
	{
		if (this.10 == null)
		{
			return 0;
		}
		try
		{
			if (2 > this.17.Length)
			{
				this.17 = new byte[2];
			}
			if (!this.10.CanRead)
			{
				return 0;
			}
			int num = this.10.Read(this.17, 0, 2);
			Marshal.Copy(this.17, 0, 1, num);
			return num;
		}
		catch
		{
		}
		return 0;
	}

	// Token: 0x06005259 RID: 21081 RVA: 0x00206AE0 File Offset: 0x00204CE0
	private bool 9(long 1, IntPtr 2)
	{
		if (this.10 == null)
		{
			return false;
		}
		try
		{
			return this.10.Seek(1, SeekOrigin.Begin) == 1;
		}
		catch
		{
		}
		return false;
	}

	// Token: 0x0600525A RID: 21082 RVA: 0x00206B24 File Offset: 0x00204D24
	internal override double GetPosition()
	{
		long num = 1219.8(base.2());
		if (num >= 0L || !1219.IsLowLatency)
		{
			this.20 = 1025.BASS_ChannelBytes2Seconds(base.2(), num) * 1000.0;
		}
		return this.20;
	}

	// Token: 0x0600525B RID: 21083 RVA: 0x00206B6B File Offset: 0x00204D6B
	public override bool IsPlaying()
	{
		return 1219.7(base.2()) - 1 <= 1;
	}

	// Token: 0x0600525C RID: 21084 RVA: 0x00206B80 File Offset: 0x00204D80
	internal override float GetVolume()
	{
		return this.18;
	}

	// Token: 0x0600525D RID: 21085 RVA: 0x00206B88 File Offset: 0x00204D88
	internal override void SetVolume(float 1)
	{
		if (this.18 != 1)
		{
			this.18 = 1;
			1025.BASS_ChannelSetAttribute(this.8, (994)2, this.18);
			1025.BASS_ChannelSetAttribute(this.9, (994)2, this.18);
		}
	}

	// Token: 0x0600525E RID: 21086 RVA: 0x00005ADD File Offset: 0x00003CDD
	public override void Update()
	{
	}

	// Token: 0x0600525F RID: 21087 RVA: 0x00206BC0 File Offset: 0x00204DC0
	public override bool GetPreservePitch()
	{
		return base.GetPreservePitch();
	}

	// Token: 0x06005260 RID: 21088 RVA: 0x00206BC8 File Offset: 0x00204DC8
	public override void SetPreservePitch(bool 1)
	{
		base.SetPreservePitch(1);
		this.10();
	}

	// Token: 0x06005261 RID: 21089 RVA: 0x00206BD7 File Offset: 0x00204DD7
	public override double GetPlaybackRate()
	{
		return this.19;
	}

	// Token: 0x06005262 RID: 21090 RVA: 0x00206BDF File Offset: 0x00204DDF
	public override void SetPlaybackRate(double 1)
	{
		if (1 != this.19)
		{
			this.19 = 1;
			this.10();
		}
	}

	// Token: 0x06005263 RID: 21091 RVA: 0x00206BF8 File Offset: 0x00204DF8
	private void 10()
	{
		if (this.14 != 0f)
		{
			float pitchFactor = this.GetPitchFactor();
			double num = this.GetPreservePitch() ? (this.19 / 100.0) : 1.0;
			double num2 = this.GetPreservePitch() ? ((double)this.13) : ((double)this.13 * this.19 / 100.0);
			1025.BASS_ChannelSetAttribute(base.2(), (994)1, (float)(num2 * (double)pitchFactor));
			1025.BASS_ChannelSetAttribute(base.2(), (994)65536, (float)((num / (double)pitchFactor - 1.0) * 100.0));
			return;
		}
		if (!this.GetPreservePitch())
		{
			1025.BASS_ChannelSetAttribute(base.2(), (994)1, (float)((double)this.13 * this.19 / 100.0));
			1025.BASS_ChannelSetAttribute(base.2(), (994)65536, 0f);
			return;
		}
		1025.BASS_ChannelSetAttribute(base.2(), (994)1, this.13);
		1025.BASS_ChannelSetAttribute(base.2(), (994)65536, (float)(this.19 - 100.0));
	}

	// Token: 0x04003EAA RID: 16042
	internal int 8;

	// Token: 0x04003EAB RID: 16043
	internal int 9;

	// Token: 0x04003EAC RID: 16044
	internal 1251 10;

	// Token: 0x04003EAD RID: 16045
	internal 1042 11;

	// Token: 0x04003EAE RID: 16046
	private float 12;

	// Token: 0x04003EAF RID: 16047
	private float 13;

	// Token: 0x04003EB0 RID: 16048
	private float 14;

	// Token: 0x04003EB1 RID: 16049
	internal bool 15;

	// Token: 0x04003EB2 RID: 16050
	private 1009 16;

	// Token: 0x04003EB3 RID: 16051
	private byte[] 17 = new byte[32768];

	// Token: 0x04003EB4 RID: 16052
	private float 18 = -1f;

	// Token: 0x04003EB5 RID: 16053
	private double 19 = 100.0;

	// Token: 0x04003EB6 RID: 16054
	private double 20;
}
