using System;
using System.Globalization;
using System.Runtime.InteropServices;

// Token: 0x020001CA RID: 458
[ComVisible(false)]
[242(1)]
[241(0)]
public sealed class 800 : 601
{
	// Token: 0x06000E91 RID: 3729 RVA: 0x000310BC File Offset: 0x0002F2BC
	public override void WriteJson(173 1, [241(2)] object 2, 158 3)
	{
		long 4;
		if (2 is DateTime)
		{
			4 = 382.Method2113(((DateTime)2).ToUniversalTime());
		}
		else
		{
			if (!(2 is DateTimeOffset))
			{
				throw new 364("Expected date object value.");
			}
			4 = 382.Method2113(((DateTimeOffset)2).ToUniversalTime().UtcDateTime);
		}
		1.WriteStartConstructor("Date");
		1.WriteValue(4);
		1.WriteEndConstructor();
	}

	// Token: 0x06000E92 RID: 3730 RVA: 0x00031130 File Offset: 0x0002F330
	[return: 241(2)]
	public override object ReadJson(139 1, Type 2, [241(2)] object 3, 158 4)
	{
		if (1.GetTokenType() != 216.Null)
		{
			if (1.GetTokenType() == 216.StartConstructor)
			{
				object value = 1.GetValue();
				if (string.Equals((value != null) ? value.ToString() : null, "Date", StringComparison.Ordinal))
				{
					DateTime dateTime;
					string 5;
					if (!473.Method4465(1, out dateTime, out 5))
					{
						throw 364.Method1687(1, 5);
					}
					if ((143.IsNullableType(2) ? Nullable.GetUnderlyingType(2) : 2) == typeof(DateTimeOffset))
					{
						return new DateTimeOffset(dateTime);
					}
					return dateTime;
				}
			}
			throw 364.Method1687(1, "Unexpected token or value when parsing date. Token: {0}, Value: {1}".Method6825(CultureInfo.InvariantCulture, 1.GetTokenType(), 1.GetValue()));
		}
		if (!143.IsNullable(2))
		{
			throw 364.Method1687(1, "Cannot convert null value to {0}.".Method6825(CultureInfo.InvariantCulture, 2));
		}
		return null;
	}
}
