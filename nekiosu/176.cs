using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

// Token: 0x020000CC RID: 204
[241(0)]
[242(1)]
[ComVisible(false)]
public sealed class 176 : 214
{
	// Token: 0x06000539 RID: 1337 RVA: 0x000100C8 File Offset: 0x0000E2C8
	private static 580 Method7927(Type 1)
	{
		Type[] genericArguments = 1.GetGenericArguments();
		Type type = ((IList<Type>)genericArguments)[0];
		Type type2 = ((IList<Type>)genericArguments)[1];
		return 580.Method7915(1, 1.GetConstructor(new Type[]
		{
			type,
			type2
		}), new string[]
		{
			"Key",
			"Value"
		});
	}

	// Token: 0x0600053A RID: 1338 RVA: 0x0001011C File Offset: 0x0000E31C
	public override void WriteJson(173 1, [241(2)] object 2, 158 3)
	{
		if (2 == null)
		{
			1.WriteNull();
			return;
		}
		580 4 = 176._recoveredType08386138.Method4701(2.GetType());
		65 5 = 3.Method1759() as 65;
		1.WriteStartObject();
		1.WritePropertyName((5 != null) ? 5.GetResolvedPropertyName("Key") : "Key");
		3.Method3848(1, 4.Method7912(2, "Key"), 4.Method7914("Key"));
		1.WritePropertyName((5 != null) ? 5.GetResolvedPropertyName("Value") : "Value");
		3.Method3848(1, 4.Method7912(2, "Value"), 4.Method7914("Value"));
		1.WriteEndObject();
	}

	// Token: 0x0600053B RID: 1339 RVA: 0x000101D0 File Offset: 0x0000E3D0
	[return: 241(2)]
	public override object ReadJson(139 1, Type 2, [241(2)] object 3, 158 4)
	{
		if (1.GetTokenType() != 216.Null)
		{
			object obj = null;
			object obj2 = null;
			1.Method2843();
			Type 5 = 143.IsNullableType(2) ? Nullable.GetUnderlyingType(2) : 2;
			580 6 = 176._recoveredType08386138.Method4701(5);
			902 7 = 4.Method1759().ResolveContract(6.Method7914("Key"));
			902 8 = 4.Method1759().ResolveContract(6.Method7914("Value"));
			while (1.GetTokenType() == 216.PropertyName)
			{
				string a = 1.GetValue().ToString();
				if (string.Equals(a, "Key", StringComparison.OrdinalIgnoreCase))
				{
					1.Method2844(7, false);
					obj = 4.Method3841(1, 7.GetUnderlyingType());
				}
				else if (string.Equals(a, "Value", StringComparison.OrdinalIgnoreCase))
				{
					1.Method2844(8, false);
					obj2 = 4.Method3841(1, 8.GetUnderlyingType());
				}
				else
				{
					1.Skip();
				}
				1.Method2843();
			}
			return 6.RecoveredType10456129(new object[]
			{
				obj,
				obj2
			});
		}
		if (!143.IsNullableType(2))
		{
			throw 364.Method1687(1, "Cannot convert null value to KeyValuePair.");
		}
		return null;
	}

	// Token: 0x0600053C RID: 1340 RVA: 0x000102E8 File Offset: 0x0000E4E8
	public override bool CanConvert(Type 1)
	{
		Type type = 143.IsNullableType(1) ? Nullable.GetUnderlyingType(1) : 1;
		return type.Method6714() && type.Method6705() && type.GetGenericTypeDefinition() == typeof(KeyValuePair<, >);
	}

	// Token: 0x04000414 RID: 1044
	private static readonly 482<Type, 580> _recoveredType08386138 = new 482<Type, 580>(new Func<Type, 580>(176.Method7927));
}
