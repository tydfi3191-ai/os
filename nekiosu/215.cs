using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x020003AC RID: 940
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
[ComVisible(false)]
public class 215 : Attribute
{
	// Token: 0x170001E2 RID: 482
	// (get) Token: 0x06001CD5 RID: 7381 RVA: 0x000731C9 File Offset: 0x000713C9
	// (set) Token: 0x06001CD6 RID: 7382 RVA: 0x000731D1 File Offset: 0x000713D1
	public bool WriteData
	{
		[CompilerGenerated]
		get
		{
			return this.flag;
		}
		[CompilerGenerated]
		set
		{
			this.flag = value;
		}
	}

	// Token: 0x170001E3 RID: 483
	// (get) Token: 0x06001CD7 RID: 7383 RVA: 0x000731DA File Offset: 0x000713DA
	// (set) Token: 0x06001CD8 RID: 7384 RVA: 0x000731E2 File Offset: 0x000713E2
	public bool ReadData
	{
		[CompilerGenerated]
		get
		{
			return this.flag2;
		}
		[CompilerGenerated]
		set
		{
			this.flag2 = value;
		}
	}

	// Token: 0x06001CD9 RID: 7385 RVA: 0x000731EB File Offset: 0x000713EB
	public 215()
	{
		this.WriteData = true;
		this.ReadData = true;
	}

	// Token: 0x04000E73 RID: 3699
	private bool flag;

	// Token: 0x04000E74 RID: 3700
	private bool flag2;
}
