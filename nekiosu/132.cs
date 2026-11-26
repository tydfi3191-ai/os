using System;
using System.Runtime.InteropServices;

// Token: 0x020000DB RID: 219
[ComVisible(false)]
[242(1)]
[241(0)]
[AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
public sealed class 132 : Attribute
{
	// Token: 0x1700003B RID: 59
	// (get) Token: 0x060005A1 RID: 1441 RVA: 0x000126E0 File Offset: 0x000108E0
	[241(new byte[]
	{
		2,
		1
	})]
	public object[] ConverterParameters
	{
		[return: 241(new byte[]
		{
			2,
			1
		})]
		get
		{
			return this.converterParameters;
		}
	}

	// Token: 0x060005A2 RID: 1442 RVA: 0x000126E8 File Offset: 0x000108E8
	public 132(Type 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=zko$2e0E=");
		}
		this.converterType = 1;
	}

	// Token: 0x060005A3 RID: 1443 RVA: 0x0001270B File Offset: 0x0001090B
	public 132(Type 1, params object[] 2) : this(1)
	{
		this.converterParameters = 2;
	}

	// Token: 0x060005A4 RID: 1444 RVA: 0x0001271B File Offset: 0x0001091B
	public Type GetConverterType()
	{
		return this.converterType;
	}

	// Token: 0x04000434 RID: 1076
	private readonly Type converterType;

	// Token: 0x04000435 RID: 1077
	[241(new byte[]
	{
		2,
		1
	})]
	private readonly object[] converterParameters;
}
