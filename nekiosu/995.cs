using System;
using System.Runtime.InteropServices;
using System.Security;

// Token: 0x02000C78 RID: 3192
[SuppressUnmanagedCodeSecurity]
[ComVisible(false)]
public abstract class 995 : IDisposable
{
	// Token: 0x0600552A RID: 21802 RVA: 0x00212848 File Offset: 0x00210A48
	public 995()
	{
		this.1 = 16;
		this.9 = 44100;
		this.8 = 2;
		this.4 = new 996();
		this.10 = IntPtr.Zero;
		this.7 = new 1004(this.ProcessAudio);
		if (1025.BASS_GetConfig((998)9) == 1)
		{
			this.1 = 32;
		}
	}

	// Token: 0x0600552B RID: 21803 RVA: 0x002128B0 File Offset: 0x00210AB0
	public 995(int 1, int 2, IntPtr 3) : this()
	{
		this.3 = 1;
		this.6 = 2;
		this.10 = 3;
		this.2(1);
		this.3();
	}

	// Token: 0x0600552C RID: 21804 RVA: 0x002128DB File Offset: 0x00210ADB
	public void Dispose()
	{
		this.1(true);
		GC.SuppressFinalize(this);
	}

	// Token: 0x0600552D RID: 21805 RVA: 0x002128EC File Offset: 0x00210AEC
	private void 1(bool 1)
	{
		if (!this.11)
		{
			try
			{
				this.4();
			}
			catch
			{
			}
		}
		this.11 = true;
	}

	// Token: 0x0600552E RID: 21806
	public abstract void ProcessAudio(int 1, int 2, IntPtr 3, int 4, IntPtr 5);

	// Token: 0x0600552F RID: 21807 RVA: 0x00212924 File Offset: 0x00210B24
	~995()
	{
		this.1(false);
	}

	// Token: 0x06005530 RID: 21808 RVA: 0x00212954 File Offset: 0x00210B54
	private void 2(int 1)
	{
		if (1 != 0)
		{
			if (!1025.2(1, this.4))
			{
				throw new ArgumentException("Invalid channel: " + Enum.GetName(typeof(936), 1025.BASS_ErrorGetCode()));
			}
			this.9 = this.4.6;
			this.8 = this.4.2;
			if ((this.4.5 & (1012)2) != (1012)0)
			{
				this.8 = 1;
			}
			this.1 = 16;
			bool flag = 1025.BASS_GetConfig((998)9) == 1;
			if ((this.4.5 & (1012)256) > (1012)0 || flag)
			{
				this.1 = 32;
				return;
			}
			if ((this.4.5 & (1012)1) != (1012)0)
			{
				this.1 = 8;
			}
		}
	}

	// Token: 0x06005531 RID: 21809 RVA: 0x00005ADD File Offset: 0x00003CDD
	public virtual void OnStateChanged()
	{
	}

	// Token: 0x06005532 RID: 21810 RVA: 0x00005ADD File Offset: 0x00003CDD
	public virtual void OnChannelChanged()
	{
	}

	// Token: 0x06005533 RID: 21811 RVA: 0x00005ADD File Offset: 0x00003CDD
	public virtual void OnAttached()
	{
	}

	// Token: 0x06005534 RID: 21812 RVA: 0x00005ADD File Offset: 0x00003CDD
	public virtual void OnDetached()
	{
	}

	// Token: 0x06005535 RID: 21813 RVA: 0x00212A20 File Offset: 0x00210C20
	public bool 3()
	{
		if (this.10())
		{
			return true;
		}
		this.5 = 1025.BASS_ChannelSetDSP(this.3, this.7, this.10, this.6);
		this.OnAttached();
		return this.5 != 0;
	}

	// Token: 0x06005536 RID: 21814 RVA: 0x00212A5E File Offset: 0x00210C5E
	public bool 4()
	{
		bool result = 1025.BASS_ChannelRemoveDSP(this.3, this.5);
		this.5 = 0;
		this.OnDetached();
		return result;
	}

	// Token: 0x06005537 RID: 21815
	public abstract override string ToString();

	// Token: 0x06005538 RID: 21816 RVA: 0x00212A7E File Offset: 0x00210C7E
	public int 5()
	{
		return this.1;
	}

	// Token: 0x06005539 RID: 21817 RVA: 0x00212A86 File Offset: 0x00210C86
	public int 6()
	{
		return this.3;
	}

	// Token: 0x0600553A RID: 21818 RVA: 0x00212A8E File Offset: 0x00210C8E
	public 996 7()
	{
		return this.4;
	}

	// Token: 0x0600553B RID: 21819 RVA: 0x00212A96 File Offset: 0x00210C96
	public int 8()
	{
		return this.8;
	}

	// Token: 0x0600553C RID: 21820 RVA: 0x00212A9E File Offset: 0x00210C9E
	public int 9()
	{
		return this.9;
	}

	// Token: 0x0600553D RID: 21821 RVA: 0x00212AA6 File Offset: 0x00210CA6
	public bool 10()
	{
		if (this.5 == 0 || this.3 == 0)
		{
			return false;
		}
		if (1025.BASS_ChannelFlags(this.3, (1012)0, (1012)0) == (1012)(-1))
		{
			this.5 = 0;
			this.3 = 0;
			return false;
		}
		return true;
	}

	// Token: 0x0600553E RID: 21822 RVA: 0x00212ADB File Offset: 0x00210CDB
	public bool 11()
	{
		return this.2;
	}

	// Token: 0x0400433F RID: 17215
	private int 1;

	// Token: 0x04004340 RID: 17216
	private bool 2;

	// Token: 0x04004341 RID: 17217
	private int 3;

	// Token: 0x04004342 RID: 17218
	private 996 4;

	// Token: 0x04004343 RID: 17219
	private int 5;

	// Token: 0x04004344 RID: 17220
	private int 6;

	// Token: 0x04004345 RID: 17221
	private 1004 7;

	// Token: 0x04004346 RID: 17222
	private int 8;

	// Token: 0x04004347 RID: 17223
	private int 9;

	// Token: 0x04004348 RID: 17224
	private IntPtr 10;

	// Token: 0x04004349 RID: 17225
	private bool 11;
}
