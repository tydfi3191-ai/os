using System;
using System.Runtime.InteropServices;
using System.Security;

// Token: 0x02000CA5 RID: 3237
[SuppressUnmanagedCodeSecurity]
[ComVisible(false)]
public sealed class 1040 : 995
{
	// Token: 0x0600565A RID: 22106 RVA: 0x0021495B File Offset: 0x00212B5B
	public 1040()
	{
		this.12 = 0.7;
	}

	// Token: 0x0600565B RID: 22107 RVA: 0x00214972 File Offset: 0x00212B72
	public 1040(int 1, int 2) : base(1, 2, IntPtr.Zero)
	{
		this.12 = 0.7;
	}

	// Token: 0x0600565C RID: 22108 RVA: 0x00214990 File Offset: 0x00212B90
	public unsafe override void ProcessAudio(int 1, int 2, IntPtr 3, int 4, IntPtr 5)
	{
		if (base.11())
		{
			return;
		}
		if (base.5() == 32)
		{
			float* ptr = (float*)((void*)3);
			for (int i = 0; i < 4 / 4; i += 2)
			{
				if (this.14 < 0.0)
				{
					ptr[(i + 1) * 4] = (float)((double)ptr[(i + 1) * 4] * (1.0 + this.14));
				}
				else if (this.14 > 0.0)
				{
					ptr[i * 4] = (float)((double)ptr[i * 4] * (1.0 - this.14));
				}
			}
			return;
		}
		if (base.5() == 16)
		{
			short* ptr2 = (short*)((void*)3);
			for (int j = 0; j < 4 / 2; j += 2)
			{
				if (this.16)
				{
					if (this.14 < 0.0)
					{
						this.15 = 1019.10((double)ptr2[j + 1] * (1.0 + this.14), this.12, 32768.0);
					}
					else if (this.14 > 0.0)
					{
						this.13 = 1019.10((double)ptr2[j] * (1.0 - this.14), this.12, 32768.0);
					}
				}
				else if (this.14 < 0.0)
				{
					this.15 = Math.Round((double)ptr2[j + 1] * (1.0 + this.14));
				}
				else if (this.14 > 0.0)
				{
					this.15 = Math.Round((double)ptr2[j] * (1.0 - this.14));
				}
				if (this.13 > 32767.0)
				{
					ptr2[j] = short.MaxValue;
				}
				else if (this.13 < -32768.0)
				{
					ptr2[j] = short.MinValue;
				}
				else
				{
					ptr2[j] = (short)this.13;
				}
				if (this.15 > 32767.0)
				{
					ptr2[j + 1] = short.MaxValue;
				}
				else if (this.15 < -32768.0)
				{
					ptr2[j + 1] = short.MinValue;
				}
				else
				{
					ptr2[j + 1] = (short)this.15;
				}
			}
			return;
		}
		byte* ptr3 = (byte*)((void*)3);
		for (int k = 0; k < 4; k += 2)
		{
			if (this.16)
			{
				if (this.14 < 0.0)
				{
					this.15 = 1019.10((double)(ptr3[k + 1] - 128) * (1.0 + this.14), this.12, 128.0);
				}
				else if (this.14 > 0.0)
				{
					this.13 = 1019.10((double)(ptr3[k] - 128) * (1.0 - this.14), this.12, 128.0);
				}
			}
			else if (this.14 < 0.0)
			{
				this.15 = Math.Round((double)(ptr3[k + 1] - 128) * (1.0 + this.14));
			}
			else if (this.14 > 0.0)
			{
				this.15 = Math.Round((double)(ptr3[k] - 128) * (1.0 - this.14));
			}
			if (this.13 > 127.0)
			{
				ptr3[k] = byte.MaxValue;
			}
			else if (this.13 < -128.0)
			{
				ptr3[k] = 0;
			}
			else
			{
				ptr3[k] = (byte)((int)this.13 + 128);
			}
			if (this.15 > 127.0)
			{
				ptr3[k] = byte.MaxValue;
			}
			else if (this.15 < -128.0)
			{
				ptr3[k] = 0;
			}
			else
			{
				ptr3[k] = (byte)((int)this.15 + 128);
			}
		}
	}

	// Token: 0x0600565D RID: 22109 RVA: 0x00214DEC File Offset: 0x00212FEC
	public override string ToString()
	{
		return "Stereo Panning DSP";
	}

	// Token: 0x040043B1 RID: 17329
	private double 12;

	// Token: 0x040043B2 RID: 17330
	private double 13;

	// Token: 0x040043B3 RID: 17331
	private double 14;

	// Token: 0x040043B4 RID: 17332
	private double 15;

	// Token: 0x040043B5 RID: 17333
	private bool 16;
}
