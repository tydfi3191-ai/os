using System;
using System.Runtime.InteropServices;

// Token: 0x02000C9B RID: 3227
[ComVisible(false)]
[StructLayout(LayoutKind.Sequential)]
public sealed class 1030
{
	// Token: 0x0600563A RID: 22074 RVA: 0x002136D2 File Offset: 0x002118D2
	public 1030()
	{
		this.1 = 44100;
		this.2 = 1f;
		this.6 = 1;
		this.8 = 2;
		this.15 = 1f;
		this.16 = (1037)1;
	}

	// Token: 0x0600563B RID: 22075 RVA: 0x00213710 File Offset: 0x00211910
	public 1030(int 1, float 2, float 3, 1012 4, int 5, int 6, int 7, int 8, int 9, 991 10, float 11, float 12, int 13, int 14, float 15, 1037 16, int 17)
	{
		this.1 = 44100;
		this.2 = 1f;
		this.6 = 1;
		this.8 = 2;
		this.15 = 1f;
		this.16 = (1037)1;
		this.1 = 1;
		this.2 = 2;
		this.3 = 3;
		this.4 = 4;
		this.5 = 5;
		this.6 = 6;
		this.7 = 7;
		this.8 = 8;
		this.9 = 9;
		this.10 = 10;
		this.11 = 11;
		this.12 = 12;
		this.13 = 13;
		this.14 = 14;
		this.15 = 15;
		this.16 = 16;
		this.17 = 17;
	}

	// Token: 0x0600563C RID: 22076 RVA: 0x002137DE File Offset: 0x002119DE
	public override string ToString()
	{
		return string.Format("Frequency={0}, Volume={1}, Pan={2}", this.1, this.2, this.3);
	}

	// Token: 0x0400438F RID: 17295
	public int 1;

	// Token: 0x04004390 RID: 17296
	public float 2;

	// Token: 0x04004391 RID: 17297
	public float 3;

	// Token: 0x04004392 RID: 17298
	public 1012 4;

	// Token: 0x04004393 RID: 17299
	public int 5;

	// Token: 0x04004394 RID: 17300
	public int 6;

	// Token: 0x04004395 RID: 17301
	public int 7;

	// Token: 0x04004396 RID: 17302
	public int 8;

	// Token: 0x04004397 RID: 17303
	public int 9;

	// Token: 0x04004398 RID: 17304
	public 991 10;

	// Token: 0x04004399 RID: 17305
	public float 11;

	// Token: 0x0400439A RID: 17306
	public float 12;

	// Token: 0x0400439B RID: 17307
	public int 13;

	// Token: 0x0400439C RID: 17308
	public int 14;

	// Token: 0x0400439D RID: 17309
	public float 15;

	// Token: 0x0400439E RID: 17310
	public 1037 16;

	// Token: 0x0400439F RID: 17311
	public int 17;
}
