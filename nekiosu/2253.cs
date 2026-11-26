using System;
using System.Reflection;

// Token: 0x02000657 RID: 1623
public class 2253 : MarshalByRefObject
{
	// Token: 0x06003178 RID: 12664 RVA: 0x001279D3 File Offset: 0x00125BD3
	public 2252[] LoadAssemblyAttributes(string 1)
	{
		return Assembly.LoadFrom(1).GetCustomAttributes(typeof(2252), false) as 2252[];
	}
}
