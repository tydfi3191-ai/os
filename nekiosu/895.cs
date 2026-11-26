using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

// Token: 0x020000CD RID: 205
[242(1)]
[ComVisible(false)]
[241(0)]
public sealed class 895 : 214
{
	// Token: 0x0600053F RID: 1343 RVA: 0x00010348 File Offset: 0x0000E548
	public override void WriteJson(173 1, [241(2)] object 2, 158 3)
	{
		if (2 == null)
		{
			1.WriteNull();
			return;
		}
		Regex 4 = (Regex)2;
		42 5 = 1 as 42;
		if (5 != null)
		{
			this.Method12721(5, 4);
			return;
		}
		this.Method12722(1, 4, 3);
	}

	// Token: 0x06000540 RID: 1344 RVA: 0x00010382 File Offset: 0x0000E582
	private bool Method12720(RegexOptions 1, RegexOptions 2)
	{
		return (1 & 2) == 2;
	}

	// Token: 0x06000541 RID: 1345 RVA: 0x0001038C File Offset: 0x0000E58C
	private void Method12721(42 1, Regex 2)
	{
		string text = null;
		if (this.Method12720(2.Options, RegexOptions.IgnoreCase))
		{
			text += "i";
		}
		if (this.Method12720(2.Options, RegexOptions.Multiline))
		{
			text += "m";
		}
		if (this.Method12720(2.Options, RegexOptions.Singleline))
		{
			text += "s";
		}
		text += "u";
		if (this.Method12720(2.Options, RegexOptions.ExplicitCapture))
		{
			text += "x";
		}
		1.Method12992(2.ToString(), text);
	}

	// Token: 0x06000542 RID: 1346 RVA: 0x00010424 File Offset: 0x0000E624
	private void Method12722(173 1, Regex 2, 158 3)
	{
		65 4 = 3.Method1759() as 65;
		1.WriteStartObject();
		1.WritePropertyName((4 != null) ? 4.GetResolvedPropertyName("Pattern") : "Pattern");
		1.WriteValue(2.ToString());
		1.WritePropertyName((4 != null) ? 4.GetResolvedPropertyName("Options") : "Options");
		3.Method3848(1, 2.Options);
		1.WriteEndObject();
	}

	// Token: 0x06000543 RID: 1347 RVA: 0x000104A0 File Offset: 0x0000E6A0
	[return: 241(2)]
	public override object ReadJson(139 1, Type 2, [241(2)] object 3, 158 4)
	{
		216 tokenType = 1.GetTokenType();
		object result;
		if (tokenType != 216.StartObject)
		{
			if (tokenType != 216.String)
			{
				if (tokenType != 216.Null)
				{
					throw 364.Method1687(1, "Unexpected token when reading Regex.");
				}
				result = null;
			}
			else
			{
				result = this.Method12723(1);
			}
		}
		else
		{
			result = this.Method12724(1, 4);
		}
		return result;
	}

	// Token: 0x06000544 RID: 1348 RVA: 0x000104EC File Offset: 0x0000E6EC
	private object Method12723(139 1)
	{
		string text = (string)1.GetValue();
		if (text.Length > 0 && text[0] == '/')
		{
			int num = text.LastIndexOf('/');
			if (num > 0)
			{
				string pattern = text.Substring(1, num - 1);
				RegexOptions options = 736.Method11635(text.Substring(num + 1));
				return new Regex(pattern, options);
			}
		}
		throw 364.Method1687(1, "Regex pattern must be enclosed by slashes.");
	}

	// Token: 0x06000545 RID: 1349 RVA: 0x00010554 File Offset: 0x0000E754
	private Regex Method12724(139 1, 158 2)
	{
		string text = null;
		RegexOptions? regexOptions = null;
		while (1.Read())
		{
			216 tokenType = 1.GetTokenType();
			if (tokenType != 216.PropertyName)
			{
				if (tokenType == 216.EndObject)
				{
					if (text == null)
					{
						throw 364.Method1687(1, "Error deserializing Regex. No pattern found.");
					}
					return new Regex(text, regexOptions.GetValueOrDefault());
				}
			}
			else
			{
				string a = 1.GetValue().ToString();
				if (!1.Read())
				{
					throw 364.Method1687(1, "Unexpected end when reading Regex.");
				}
				if (string.Equals(a, "Pattern", StringComparison.OrdinalIgnoreCase))
				{
					text = (string)1.GetValue();
				}
				else if (string.Equals(a, "Options", StringComparison.OrdinalIgnoreCase))
				{
					regexOptions = new RegexOptions?(2.Method3841<RegexOptions>(1));
				}
				else
				{
					1.Skip();
				}
			}
		}
		throw 364.Method1687(1, "Unexpected end when reading Regex.");
	}

	// Token: 0x06000546 RID: 1350 RVA: 0x00010617 File Offset: 0x0000E817
	public override bool CanConvert(Type 1)
	{
		return 1.Name == "Regex" && this.Method12725(1);
	}

	// Token: 0x06000547 RID: 1351 RVA: 0x00010634 File Offset: 0x0000E834
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool Method12725(Type 1)
	{
		return 1 == typeof(Regex);
	}
}
