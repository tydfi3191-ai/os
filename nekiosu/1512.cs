using System;

// Token: 0x02000AE7 RID: 2791
public sealed class 1512
{
	// Token: 0x06004DD1 RID: 19921 RVA: 0x001ECEB0 File Offset: 0x001EB0B0
	internal 1512()
	{
		this.1 = 640;
		this.2 = 480;
		this.3 = 768;
	}

	// Token: 0x06004DD2 RID: 19922 RVA: 0x001ECED9 File Offset: 0x001EB0D9
	internal int 1()
	{
		return (int)Math.Ceiling((double)((float)this.1 / this.3()));
	}

	// Token: 0x06004DD3 RID: 19923 RVA: 0x001ECEF0 File Offset: 0x001EB0F0
	internal int 2()
	{
		return (int)Math.Ceiling((double)((float)this.2 / this.3()));
	}

	// Token: 0x06004DD4 RID: 19924 RVA: 0x001ECF07 File Offset: 0x001EB107
	internal float 3()
	{
		return (float)this.2 / 480f;
	}

	// Token: 0x06004DD5 RID: 19925 RVA: 0x001ECF16 File Offset: 0x001EB116
	internal int 4()
	{
		return Math.Max(0, (int)(((float)this.1 - (float)this.2 * 4f / 3f) / 2f));
	}

	// Token: 0x06004DD6 RID: 19926 RVA: 0x001ECF40 File Offset: 0x001EB140
	internal float 5()
	{
		return (float)this.4() / this.3();
	}

	// Token: 0x06004DD7 RID: 19927 RVA: 0x001ECF50 File Offset: 0x001EB150
	internal float 6()
	{
		return (float)this.1() / 640f;
	}

	// Token: 0x06004DD8 RID: 19928 RVA: 0x001ECF5F File Offset: 0x001EB15F
	internal bool 7()
	{
		return this.4() > 0;
	}

	// Token: 0x06004DD9 RID: 19929 RVA: 0x001ECF6A File Offset: 0x001EB16A
	internal float 8()
	{
		return 1f / this.3();
	}

	// Token: 0x06004DDA RID: 19930 RVA: 0x001ECF78 File Offset: 0x001EB178
	internal float 9()
	{
		return (float)this.2 / (float)this.3;
	}

	// Token: 0x06004DDB RID: 19931 RVA: 0x001ECF89 File Offset: 0x001EB189
	internal 208 10(208 1)
	{
		return 1 * this.3() + new 208((float)this.4(), 0f);
	}

	// Token: 0x04003A0D RID: 14861
	internal int 1;

	// Token: 0x04003A0E RID: 14862
	internal int 2;

	// Token: 0x04003A0F RID: 14863
	internal int 3;
}
