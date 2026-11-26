using System;
using System.Globalization;
using System.Runtime.InteropServices;

// Token: 0x020000FB RID: 251
[ComVisible(false)]
public sealed class 807 : 214
{
	// Token: 0x0600088F RID: 2191 RVA: 0x0001CEF0 File Offset: 0x0001B0F0
	public override void WriteJson(173 1, object 2, 158 3)
	{
		212 4 = (212)2;
		42 5 = 1 as 42;
		if (5 != null)
		{
			5.Method12991(4.Value);
			return;
		}
		1.WriteValue(4.Value);
	}

	// Token: 0x06000890 RID: 2192 RVA: 0x0001CF27 File Offset: 0x0001B127
	public override object ReadJson(139 1, Type 2, object 3, 158 4)
	{
		if (1.GetTokenType() != 216.Bytes)
		{
			throw new 364("Expected Bytes but got {0}.".Method6825(CultureInfo.InvariantCulture, 1.GetTokenType()));
		}
		return new 212((byte[])1.GetValue());
	}

	// Token: 0x06000891 RID: 2193 RVA: 0x0001CF63 File Offset: 0x0001B163
	public override bool CanConvert(Type 1)
	{
		return 1 == typeof(212);
	}
}
