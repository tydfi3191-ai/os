using System;
using System.Runtime.InteropServices;

// Token: 0x02000C75 RID: 3189
[ComVisible(false)]
[StructLayout(LayoutKind.Sequential)]
public sealed class 992
{
	// Token: 0x06005527 RID: 21799 RVA: 0x000055AC File Offset: 0x000037AC
	public 992()
	{
	}

	// Token: 0x06005528 RID: 21800 RVA: 0x002127FB File Offset: 0x002109FB
	public 992(float 1, float 2, float 3)
	{
		this.1 = 1;
		this.2 = 2;
		this.3 = 3;
	}

	// Token: 0x06005529 RID: 21801 RVA: 0x00212818 File Offset: 0x00210A18
	public override string ToString()
	{
		return string.Format("X={0}, Y={1}, Z={2}", this.1, this.2, this.3);
	}

	// Token: 0x0400433A RID: 17210
	public float 1;

	// Token: 0x0400433B RID: 17211
	public float 2;

	// Token: 0x0400433C RID: 17212
	public float 3;
}
