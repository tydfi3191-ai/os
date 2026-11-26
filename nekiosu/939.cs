using System;
using System.Globalization;
using System.Runtime.InteropServices;

// Token: 0x020000CF RID: 207
[ComVisible(false)]
[241(0)]
[242(1)]
public sealed class 939 : 214
{
	// Token: 0x06000558 RID: 1368 RVA: 0x00010934 File Offset: 0x0000EB34
	public override void WriteJson(173 1, [241(2)] object 2, 158 3)
	{
		if (2 == null)
		{
			1.WriteNull();
			return;
		}
		if (2 is Version)
		{
			1.WriteValue(2.ToString());
			return;
		}
		throw new 364("Expected Version object value");
	}

	// Token: 0x06000559 RID: 1369 RVA: 0x00010960 File Offset: 0x0000EB60
	[return: 241(2)]
	public override object ReadJson(139 1, Type 2, [241(2)] object 3, 158 4)
	{
		if (1.GetTokenType() == 216.Null)
		{
			return null;
		}
		if (1.GetTokenType() == 216.String)
		{
			try
			{
				return new Version((string)1.GetValue());
			}
			catch (Exception 5)
			{
				throw 364.Method1687(1, "Error parsing version string: {0}".Method6825(CultureInfo.InvariantCulture, 1.GetValue()), 5);
			}
		}
		throw 364.Method1687(1, "Unexpected token or value when parsing version. Token: {0}, Value: {1}".Method6825(CultureInfo.InvariantCulture, 1.GetTokenType(), 1.GetValue()));
	}

	// Token: 0x0600055A RID: 1370 RVA: 0x000109EC File Offset: 0x0000EBEC
	public override bool CanConvert(Type 1)
	{
		return 1 == typeof(Version);
	}
}
