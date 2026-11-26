using System;
using System.Runtime.InteropServices;
using System.Security;

// Token: 0x02000CA3 RID: 3235
[SuppressUnmanagedCodeSecurity]
[ComVisible(false)]
public sealed class 1038 : 995
{
	// Token: 0x0600564A RID: 22090 RVA: 0x002140F8 File Offset: 0x002122F8
	public 1038()
	{
		this.16 = 500;
		this.17 = true;
		this.15 = (1012)2097152;
		this.12(1025.BASS_GetConfig((998)0));
		this.20 = new 1031(this.14);
	}

	// Token: 0x0600564B RID: 22091 RVA: 0x00214148 File Offset: 0x00212348
	public 1038(int 1, int 2) : base(1, 2, IntPtr.Zero)
	{
		this.16 = 500;
		this.17 = true;
		this.15 = (1012)2097152;
		this.12(1025.BASS_GetConfig((998)0));
		this.20 = new 1031(this.14);
	}

	// Token: 0x0600564C RID: 22092 RVA: 0x002141A0 File Offset: 0x002123A0
	public void 12(int 1)
	{
		if (1 > 5000)
		{
			this.16 = 5000;
		}
		else if (1 < 1)
		{
			this.16 = 1;
		}
		else
		{
			this.16 = 1;
		}
		this.OnDetached();
		if ((base.7().5 & (1012)256) != (1012)0)
		{
			this.13 = (int)1025.BASS_ChannelSeconds2Bytes(base.6(), (double)this.16 / 1000.0);
		}
		else if ((base.7().5 & (1012)1) != (1012)0 && base.5() == 32)
		{
			this.13 = (int)1025.BASS_ChannelSeconds2Bytes(base.6(), (double)this.16 / 1000.0) * 4;
		}
		else if (base.5() == 32)
		{
			this.13 = (int)1025.BASS_ChannelSeconds2Bytes(base.6(), (double)this.16 / 1000.0) * 2;
		}
		if (base.10())
		{
			this.OnAttached();
		}
	}

	// Token: 0x0600564D RID: 22093 RVA: 0x00214291 File Offset: 0x00212491
	public int 13()
	{
		return this.19;
	}

	// Token: 0x0600564E RID: 22094 RVA: 0x0021429C File Offset: 0x0021249C
	private int 14(int 1, IntPtr 2, int 3, IntPtr 4)
	{
		if (base.11())
		{
			return 0;
		}
		1038 obj;
		if (this.13() != 0)
		{
			int num = 1025.BASS_ChannelGetData(this.13(), IntPtr.Zero, 0);
			num = (int)1025.BASS_ChannelSeconds2Bytes(1, 1025.BASS_ChannelBytes2Seconds(this.13(), (long)num));
			if (num > this.13)
			{
				num = this.13;
			}
			else if (num < 0)
			{
				num = 0;
			}
			if (3 > num)
			{
				3 = num;
			}
			obj = this;
			lock (obj)
			{
				Marshal.Copy(this.12, this.13 - num, 2, 3);
				return 3;
			}
		}
		if (this.18 + 3 > this.13)
		{
			3 = this.13 - this.18;
		}
		obj = this;
		lock (obj)
		{
			Marshal.Copy(this.12, this.18, 2, 3);
			this.18 += 3;
			if (this.18 > this.13)
			{
				this.18 = this.13;
			}
		}
		return 3;
	}

	// Token: 0x0600564F RID: 22095 RVA: 0x002143D4 File Offset: 0x002125D4
	public void 15()
	{
		if (this.12 != null)
		{
			lock (this)
			{
				Array.Clear(this.12, 0, this.13);
				this.18 = ((!this.17) ? this.13 : 0);
			}
		}
	}

	// Token: 0x06005650 RID: 22096 RVA: 0x0021443C File Offset: 0x0021263C
	public override void ProcessAudio(int 1, int 2, IntPtr 3, int 4, IntPtr 5)
	{
		if (base.11())
		{
			return;
		}
		if (4 > this.13)
		{
			4 = this.13;
		}
		lock (this)
		{
			Array.Copy(this.12, 4, this.12, 0, this.13 - 4);
			Marshal.Copy(3, this.12, this.13 - 4, 4);
			this.18 -= 4;
			if (this.18 < 0)
			{
				this.18 = 0;
			}
		}
	}

	// Token: 0x06005651 RID: 22097 RVA: 0x002144E8 File Offset: 0x002126E8
	public override void OnStateChanged()
	{
		this.15();
	}

	// Token: 0x06005652 RID: 22098 RVA: 0x002144F0 File Offset: 0x002126F0
	public override void OnChannelChanged()
	{
		this.OnDetached();
		if ((base.7().5 & (1012)256) != (1012)0)
		{
			this.13 = (int)1025.BASS_ChannelSeconds2Bytes(base.6(), (double)this.16 / 1000.0);
		}
		else if ((base.7().5 & (1012)1) != (1012)0 && base.5() == 32)
		{
			this.13 = (int)1025.BASS_ChannelSeconds2Bytes(base.6(), (double)this.16 / 1000.0) * 4;
		}
		else if (base.5() == 32)
		{
			this.13 = (int)1025.BASS_ChannelSeconds2Bytes(base.6(), (double)this.16 / 1000.0) * 2;
		}
		this.15 = (base.7().5 | (1012)2097152);
		this.15 &= (1012)(-262145);
		if (base.5() == 32)
		{
			this.15 &= (1012)(-2);
			this.15 |= (1012)256;
		}
		else if (base.5() == 8)
		{
			this.15 &= (1012)(-257);
			this.15 |= (1012)1;
		}
		else
		{
			this.15 &= (1012)(-257);
			this.15 &= (1012)(-2);
		}
		if (base.10())
		{
			this.OnAttached();
		}
	}

	// Token: 0x06005653 RID: 22099 RVA: 0x0021465C File Offset: 0x0021285C
	public override void OnAttached()
	{
		this.12 = new byte[this.13];
		lock (this)
		{
			this.14 = 1025.BASS_StreamCreate(base.9(), base.8(), this.15, this.20, IntPtr.Zero);
			this.18 = ((!this.17) ? this.13 : 0);
		}
	}

	// Token: 0x06005654 RID: 22100 RVA: 0x002146E4 File Offset: 0x002128E4
	public override void OnDetached()
	{
		if (this.14 != 0)
		{
			1025.BASS_StreamFree(this.14);
			this.14 = 0;
		}
		this.12 = null;
	}

	// Token: 0x06005655 RID: 22101 RVA: 0x00214708 File Offset: 0x00212908
	public override string ToString()
	{
		return "Buffer Stream DSP";
	}

	// Token: 0x040043A4 RID: 17316
	private byte[] 12;

	// Token: 0x040043A5 RID: 17317
	private int 13;

	// Token: 0x040043A6 RID: 17318
	private int 14;

	// Token: 0x040043A7 RID: 17319
	private 1012 15;

	// Token: 0x040043A8 RID: 17320
	private int 16;

	// Token: 0x040043A9 RID: 17321
	private bool 17;

	// Token: 0x040043AA RID: 17322
	private volatile int 18;

	// Token: 0x040043AB RID: 17323
	private int 19;

	// Token: 0x040043AC RID: 17324
	private 1031 20;
}
