using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

// Token: 0x02000172 RID: 370
[241(0)]
[242(1)]
[ComVisible(false)]
public sealed class 610 : PropertyDescriptor
{
	// Token: 0x1700009D RID: 157
	// (get) Token: 0x06000C58 RID: 3160 RVA: 0x0002C9B0 File Offset: 0x0002ABB0
	public override Type ComponentType
	{
		get
		{
			return typeof(217);
		}
	}

	// Token: 0x1700009E RID: 158
	// (get) Token: 0x06000C59 RID: 3161 RVA: 0x0000FF75 File Offset: 0x0000E175
	public override bool IsReadOnly
	{
		get
		{
			return false;
		}
	}

	// Token: 0x1700009F RID: 159
	// (get) Token: 0x06000C5A RID: 3162 RVA: 0x0002C9BC File Offset: 0x0002ABBC
	public override Type PropertyType
	{
		get
		{
			return typeof(object);
		}
	}

	// Token: 0x170000A0 RID: 160
	// (get) Token: 0x06000C5B RID: 3163 RVA: 0x0002C9C8 File Offset: 0x0002ABC8
	protected override int NameHashCode
	{
		get
		{
			return base.NameHashCode;
		}
	}

	// Token: 0x06000C5C RID: 3164 RVA: 0x0002C9D0 File Offset: 0x0002ABD0
	public 610(string 1) : base(1, null)
	{
	}

	// Token: 0x06000C5D RID: 3165 RVA: 0x0002C9DA File Offset: 0x0002ABDA
	private static 217 Method8900(object 1)
	{
		return (217)1;
	}

	// Token: 0x06000C5E RID: 3166 RVA: 0x0000FF75 File Offset: 0x0000E175
	public override bool CanResetValue(object 1)
	{
		return false;
	}

	// Token: 0x06000C5F RID: 3167 RVA: 0x0002C9E2 File Offset: 0x0002ABE2
	[242(2)]
	public override object GetValue(object 1)
	{
		217 2 = 1 as 217;
		if (2 == null)
		{
			return null;
		}
		return 2[this.Name];
	}

	// Token: 0x06000C60 RID: 3168 RVA: 0x00005ADD File Offset: 0x00003CDD
	public override void ResetValue(object 1)
	{
	}

	// Token: 0x06000C61 RID: 3169 RVA: 0x0002C9FC File Offset: 0x0002ABFC
	[242(2)]
	public override void SetValue(object 1, object 2)
	{
		217 3 = 1 as 217;
		if (3 != null)
		{
			226 4 = (2 as 226) ?? new 233(2);
			3[this.Name] = 4;
		}
	}

	// Token: 0x06000C62 RID: 3170 RVA: 0x0000FF75 File Offset: 0x0000E175
	public override bool ShouldSerializeValue(object 1)
	{
		return false;
	}
}
