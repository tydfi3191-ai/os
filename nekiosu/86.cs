using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Runtime.InteropServices;

// Token: 0x020000CB RID: 203
[242(1)]
[ComVisible(false)]
[241(0)]
public sealed class 86 : 214
{
	// Token: 0x1700002D RID: 45
	// (get) Token: 0x06000531 RID: 1329 RVA: 0x0000FF75 File Offset: 0x0000E175
	public override bool CanWrite
	{
		get
		{
			return false;
		}
	}

	// Token: 0x06000532 RID: 1330 RVA: 0x00005ADD File Offset: 0x00003CDD
	public override void WriteJson(173 1, [241(2)] object 2, 158 3)
	{
	}

	// Token: 0x06000533 RID: 1331 RVA: 0x0000FF78 File Offset: 0x0000E178
	[return: 241(2)]
	public override object ReadJson(139 1, Type 2, [241(2)] object 3, 158 4)
	{
		return this.Method10631(1);
	}

	// Token: 0x06000534 RID: 1332 RVA: 0x0000FF84 File Offset: 0x0000E184
	[return: 241(2)]
	private object Method10631(139 1)
	{
		if (!1.Method2847())
		{
			throw 364.Method1687(1, "Unexpected end when reading ExpandoObject.");
		}
		216 tokenType = 1.GetTokenType();
		if (tokenType == 216.StartObject)
		{
			return this.Method10633(1);
		}
		if (tokenType == 216.StartArray)
		{
			return this.Method10632(1);
		}
		if (169.IsPrimitiveToken(1.GetTokenType()))
		{
			return 1.GetValue();
		}
		throw 364.Method1687(1, "Unexpected token when converting ExpandoObject: {0}".Method6825(CultureInfo.InvariantCulture, 1.GetTokenType()));
	}

	// Token: 0x06000535 RID: 1333 RVA: 0x0000FFFC File Offset: 0x0000E1FC
	private object Method10632(139 1)
	{
		IList<object> list = new List<object>();
		while (1.Read())
		{
			216 tokenType = 1.GetTokenType();
			if (tokenType != 216.Comment)
			{
				if (tokenType == 216.EndArray)
				{
					return list;
				}
				object item = this.Method10631(1);
				list.Add(item);
			}
		}
		throw 364.Method1687(1, "Unexpected end when reading ExpandoObject.");
	}

	// Token: 0x06000536 RID: 1334 RVA: 0x00010048 File Offset: 0x0000E248
	private object Method10633(139 1)
	{
		IDictionary<string, object> dictionary = new ExpandoObject();
		while (1.Read())
		{
			216 tokenType = 1.GetTokenType();
			if (tokenType != 216.PropertyName)
			{
				if (tokenType == 216.EndObject)
				{
					return dictionary;
				}
			}
			else
			{
				string key = 1.GetValue().ToString();
				if (!1.Read())
				{
					throw 364.Method1687(1, "Unexpected end when reading ExpandoObject.");
				}
				object value = this.Method10631(1);
				dictionary[key] = value;
			}
		}
		throw 364.Method1687(1, "Unexpected end when reading ExpandoObject.");
	}

	// Token: 0x06000537 RID: 1335 RVA: 0x000100B6 File Offset: 0x0000E2B6
	public override bool CanConvert(Type 1)
	{
		return 1 == typeof(ExpandoObject);
	}
}
