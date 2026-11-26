using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x020003AE RID: 942
[ComVisible(false)]
[242(1)]
[241(0)]
public class 236
{
	// Token: 0x170001E4 RID: 484
	// (get) Token: 0x06001CDA RID: 7386 RVA: 0x00073201 File Offset: 0x00071401
	public Exception Error
	{
		[CompilerGenerated]
		get
		{
			return this.exception2;
		}
	}

	// Token: 0x170001E5 RID: 485
	// (get) Token: 0x06001CDB RID: 7387 RVA: 0x00073209 File Offset: 0x00071409
	[241(2)]
	public object OriginalObject
	{
		[CompilerGenerated]
		[242(2)]
		get
		{
			return this.value3;
		}
	}

	// Token: 0x170001E6 RID: 486
	// (get) Token: 0x06001CDC RID: 7388 RVA: 0x00073211 File Offset: 0x00071411
	[241(2)]
	public object Member
	{
		[CompilerGenerated]
		[242(2)]
		get
		{
			return this.value4;
		}
	}

	// Token: 0x170001E7 RID: 487
	// (get) Token: 0x06001CDD RID: 7389 RVA: 0x00073219 File Offset: 0x00071419
	public string Path
	{
		[CompilerGenerated]
		get
		{
			return this.text2;
		}
	}

	// Token: 0x170001E8 RID: 488
	// (get) Token: 0x06001CDE RID: 7390 RVA: 0x00073221 File Offset: 0x00071421
	// (set) Token: 0x06001CDF RID: 7391 RVA: 0x00073229 File Offset: 0x00071429
	public bool Handled
	{
		[CompilerGenerated]
		get
		{
			return this.flag3;
		}
		[CompilerGenerated]
		set
		{
			this.flag3 = value;
		}
	}

	// Token: 0x06001CE0 RID: 7392 RVA: 0x00073232 File Offset: 0x00071432
	internal 236([241(2)] object 1, [241(2)] object 2, string 3, Exception 4)
	{
		this.value3 = 1;
		this.value4 = 2;
		this.exception2 = 4;
		this.text2 = 3;
	}

	// Token: 0x06001CE1 RID: 7393 RVA: 0x00073257 File Offset: 0x00071457
	internal bool GetFlag10909_14383()
	{
		return this.flag2;
	}

	// Token: 0x06001CE2 RID: 7394 RVA: 0x0007325F File Offset: 0x0007145F
	internal void SetFlag10909_14384(bool 1)
	{
		this.flag2 = 1;
	}

	// Token: 0x04000E88 RID: 3720
	private bool flag2;

	// Token: 0x04000E89 RID: 3721
	private readonly Exception exception2;

	// Token: 0x04000E8A RID: 3722
	[241(2)]
	private readonly object value3;

	// Token: 0x04000E8B RID: 3723
	[241(2)]
	private readonly object value4;

	// Token: 0x04000E8C RID: 3724
	private readonly string text2;

	// Token: 0x04000E8D RID: 3725
	private bool flag3;
}
