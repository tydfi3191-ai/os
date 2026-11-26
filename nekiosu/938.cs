using System;
using System.Runtime.InteropServices;

// Token: 0x020003C7 RID: 967
[ComVisible(false)]
public sealed class 938
{
	// Token: 0x06001ED0 RID: 7888 RVA: 0x000055AC File Offset: 0x000037AC
	private 938()
	{
	}

	// Token: 0x06001ED1 RID: 7889 RVA: 0x00078378 File Offset: 0x00076578
	public 938(IntPtr 1)
	{
		if (1 != IntPtr.Zero)
		{
			938 2 = (938)Marshal.PtrToStructure(1, typeof(938));
			this.version = 2.version;
			this.formatc = 2.formatc;
			this.formats = new 937[this.formatc];
			this.Method14385(this.formatc, 1);
		}
	}

	// Token: 0x06001ED2 RID: 7890 RVA: 0x000783E4 File Offset: 0x000765E4
	internal 938(int 1, 937[] 2)
	{
		this.version = 1;
		this.formatc = 2.Length;
		this.formats = 2;
	}

	// Token: 0x06001ED3 RID: 7891 RVA: 0x00078403 File Offset: 0x00076603
	internal 938(int 1, int 2, IntPtr 3)
	{
		this.version = 1;
		this.formatc = 2;
		if (3 != IntPtr.Zero)
		{
			this.formats = new 937[2];
			this.Method14385(this.formatc, 3);
		}
	}

	// Token: 0x06001ED4 RID: 7892 RVA: 0x00078440 File Offset: 0x00076640
	private void Method14385(int 1, IntPtr 2)
	{
		for (int i = 0; i < 1; i++)
		{
			this.formats[i] = (937)Marshal.PtrToStructure(2, typeof(937));
			2 = new IntPtr(2.ToInt64() + (long)Marshal.SizeOf(this.formats[i]));
		}
	}

	// Token: 0x06001ED5 RID: 7893 RVA: 0x00078493 File Offset: 0x00076693
	public override string ToString()
	{
		return string.Format("{0}, {1}", this.version, this.formatc);
	}

	// Token: 0x04000F3A RID: 3898
	public int formatc;

	// Token: 0x04000F3B RID: 3899
	public 937[] formats;

	// Token: 0x04000F3C RID: 3900
	public int version;
}
