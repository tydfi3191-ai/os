using System;
using System.Runtime.InteropServices;

// Token: 0x020001E8 RID: 488
[ComVisible(false)]
[242(1)]
[241(0)]
public abstract class 136
{
	// Token: 0x06000F80 RID: 3968 RVA: 0x00035305 File Offset: 0x00033505
	public bool GetProcessDictionaryKeys()
	{
		return this.processDictionaryKeys;
	}

	// Token: 0x06000F81 RID: 3969 RVA: 0x0003530D File Offset: 0x0003350D
	public void SetProcessDictionaryKeys(bool 1)
	{
		this.processDictionaryKeys = 1;
	}

	// Token: 0x06000F82 RID: 3970 RVA: 0x00035316 File Offset: 0x00033516
	public bool GetProcessExtensionDataNames()
	{
		return this.processExtensionDataNames;
	}

	// Token: 0x06000F83 RID: 3971 RVA: 0x0003531E File Offset: 0x0003351E
	public void SetProcessExtensionDataNames(bool 1)
	{
		this.processExtensionDataNames = 1;
	}

	// Token: 0x06000F84 RID: 3972 RVA: 0x00035327 File Offset: 0x00033527
	public bool GetOverrideSpecifiedNames()
	{
		return this.overrideSpecifiedNames;
	}

	// Token: 0x06000F85 RID: 3973 RVA: 0x0003532F File Offset: 0x0003352F
	public void SetOverrideSpecifiedNames(bool 1)
	{
		this.overrideSpecifiedNames = 1;
	}

	// Token: 0x06000F86 RID: 3974 RVA: 0x00035338 File Offset: 0x00033538
	public virtual string GetPropertyName(string 1, bool 2)
	{
		if (2 && !this.GetOverrideSpecifiedNames())
		{
			return 1;
		}
		return this.Method12215(1);
	}

	// Token: 0x06000F87 RID: 3975 RVA: 0x0003534E File Offset: 0x0003354E
	public virtual string GetExtensionDataName(string 1)
	{
		if (!this.GetProcessExtensionDataNames())
		{
			return 1;
		}
		return this.Method12215(1);
	}

	// Token: 0x06000F88 RID: 3976 RVA: 0x00035361 File Offset: 0x00033561
	public virtual string GetDictionaryKey(string 1)
	{
		if (!this.GetProcessDictionaryKeys())
		{
			return 1;
		}
		return this.Method12215(1);
	}

	// Token: 0x06000F89 RID: 3977
	protected abstract string Method12215(string 1);

	// Token: 0x06000F8A RID: 3978 RVA: 0x00035374 File Offset: 0x00033574
	public override int GetHashCode()
	{
		return ((base.GetType().GetHashCode() * 397 ^ this.GetProcessDictionaryKeys().GetHashCode()) * 397 ^ this.GetProcessExtensionDataNames().GetHashCode()) * 397 ^ this.GetOverrideSpecifiedNames().GetHashCode();
	}

	// Token: 0x06000F8B RID: 3979 RVA: 0x000353CB File Offset: 0x000335CB
	[242(2)]
	public override bool Equals(object 1)
	{
		return this.IsEquivalentTo(1 as 136);
	}

	// Token: 0x06000F8C RID: 3980 RVA: 0x000353DC File Offset: 0x000335DC
	[242(2)]
	protected bool IsEquivalentTo(136 1)
	{
		return 1 != null && (base.GetType() == 1.GetType() && this.GetProcessDictionaryKeys() == 1.GetProcessDictionaryKeys() && this.GetProcessExtensionDataNames() == 1.GetProcessExtensionDataNames()) && this.GetOverrideSpecifiedNames() == 1.GetOverrideSpecifiedNames();
	}

	// Token: 0x04000786 RID: 1926
	private bool processDictionaryKeys;

	// Token: 0x04000787 RID: 1927
	private bool processExtensionDataNames;

	// Token: 0x04000788 RID: 1928
	private bool overrideSpecifiedNames;
}
