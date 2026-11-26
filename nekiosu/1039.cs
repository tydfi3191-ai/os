using System;
using System.Runtime.InteropServices;
using System.Security;

// Token: 0x02000CA4 RID: 3236
[SuppressUnmanagedCodeSecurity]
[ComVisible(false)]
public sealed class 1039 : 995
{
	// Token: 0x06005656 RID: 22102 RVA: 0x0021470F File Offset: 0x0021290F
	public 1039()
	{
		this.14 = 1.0;
		this.13 = 0.7;
	}

	// Token: 0x06005657 RID: 22103 RVA: 0x00214735 File Offset: 0x00212935
	public 1039(int 1, int 2) : base(1, 2, IntPtr.Zero)
	{
		this.14 = 1.0;
		this.13 = 0.7;
	}

	// Token: 0x06005658 RID: 22104 RVA: 0x00214764 File Offset: 0x00212964
	public unsafe override void ProcessAudio(int 1, int 2, IntPtr 3, int 4, IntPtr 5)
	{
		if (base.11() || this.14 == 1.0)
		{
			return;
		}
		if (base.5() == 32)
		{
			float* ptr = (float*)((void*)3);
			for (int i = 0; i < 4 / 4; i++)
			{
				ptr[i * 4] = (float)((double)ptr[i * 4] * this.14);
			}
			return;
		}
		if (base.5() == 16)
		{
			short* ptr2 = (short*)((void*)3);
			for (int j = 0; j < 4 / 2; j++)
			{
				if (this.15)
				{
					this.12 = 1019.10((double)ptr2[j] * this.14, this.13, 32768.0);
				}
				else
				{
					this.12 = Math.Round((double)ptr2[j] * this.14);
				}
				if (this.12 > 32767.0)
				{
					ptr2[j] = short.MaxValue;
				}
				else if (this.12 < -32768.0)
				{
					ptr2[j] = short.MinValue;
				}
				else
				{
					ptr2[j] = (short)this.12;
				}
			}
			return;
		}
		byte* ptr3 = (byte*)((void*)3);
		for (int k = 0; k < 4; k++)
		{
			if (this.15)
			{
				this.12 = 1019.10((double)(ptr3[k] - 128) * this.14, this.13, 128.0);
			}
			else
			{
				this.12 = Math.Round((double)(ptr3[k] - 128) * this.14);
			}
			if (this.12 > 127.0)
			{
				ptr3[k] = byte.MaxValue;
			}
			else if (this.12 < -128.0)
			{
				ptr3[k] = 0;
			}
			else
			{
				ptr3[k] = (byte)((double)((int)this.12) + 128.0);
			}
		}
	}

	// Token: 0x06005659 RID: 22105 RVA: 0x00214954 File Offset: 0x00212B54
	public override string ToString()
	{
		return "Gain DSP";
	}

	// Token: 0x040043AD RID: 17325
	private double 12;

	// Token: 0x040043AE RID: 17326
	private double 13;

	// Token: 0x040043AF RID: 17327
	private double 14;

	// Token: 0x040043B0 RID: 17328
	private bool 15;
}
