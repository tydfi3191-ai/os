using System;
using System.Globalization;
using System.Runtime.InteropServices;

// Token: 0x020000CA RID: 202
[241(0)]
[ComVisible(false)]
[242(1)]
public sealed class 82 : 214
{
	// Token: 0x0600052B RID: 1323 RVA: 0x0000FD30 File Offset: 0x0000DF30
	public override void WriteJson(173 1, [241(2)] object 2, 158 3)
	{
		if (2 == null)
		{
			1.WriteNull();
			return;
		}
		82.Method9553(2.GetType());
		65 4 = 3.Method1759() as 65;
		string 5 = (string)82._recoveredType13757484.Method7912(2, "Key");
		object obj = 82._recoveredType13757484.Method7912(2, "Value");
		Type type = (obj != null) ? obj.GetType() : null;
		1.WriteStartObject();
		1.WritePropertyName((4 != null) ? 4.GetResolvedPropertyName("Key") : "Key");
		1.WriteValue(5);
		1.WritePropertyName((4 != null) ? 4.GetResolvedPropertyName("Type") : "Type");
		1.WriteValue((type != null) ? type.FullName : null);
		1.WritePropertyName((4 != null) ? 4.GetResolvedPropertyName("Value") : "Value");
		if (type != null)
		{
			string 6;
			if (166.Method12846(obj, type, out 6))
			{
				1.WriteValue(6);
			}
			else
			{
				1.WriteValue(obj);
			}
		}
		else
		{
			1.WriteNull();
		}
		1.WriteEndObject();
	}

	// Token: 0x0600052C RID: 1324 RVA: 0x0000FE38 File Offset: 0x0000E038
	private static void Method9552(139 1, string 2)
	{
		1.Method2843();
		if (1.GetTokenType() == 216.PropertyName)
		{
			object value = 1.GetValue();
			if (string.Equals((value != null) ? value.ToString() : null, 2, StringComparison.OrdinalIgnoreCase))
			{
				return;
			}
		}
		throw new 364("Expected JSON property '{0}'.".Method6825(CultureInfo.InvariantCulture, 2));
	}

	// Token: 0x0600052D RID: 1325 RVA: 0x0000FE88 File Offset: 0x0000E088
	[return: 241(2)]
	public override object ReadJson(139 1, Type 2, [241(2)] object 3, 158 4)
	{
		82.Method9553(2);
		object obj = 82._recoveredType13757484.RecoveredType10456129(Array.Empty<object>());
		82.Method9552(1, "Key");
		1.Method2843();
		580 recoveredType = 82._recoveredType13757484;
		object 5 = obj;
		string 6 = "Key";
		object value = 1.GetValue();
		recoveredType.Method7913(5, 6, (value != null) ? value.ToString() : null);
		82.Method9552(1, "Type");
		1.Method2843();
		object value2 = 1.GetValue();
		Type type = Type.GetType((value2 != null) ? value2.ToString() : null);
		82.Method9552(1, "Value");
		1.Method2843();
		82._recoveredType13757484.Method7913(obj, "Value", 4.Method3841(1, type));
		1.Method2843();
		return obj;
	}

	// Token: 0x0600052E RID: 1326 RVA: 0x0000FF3D File Offset: 0x0000E13D
	private static void Method9553(Type 1)
	{
		if (82._recoveredType13757484 == null)
		{
			82._recoveredType13757484 = 580.Method7915(1, new string[]
			{
				"Key",
				"Value"
			});
		}
	}

	// Token: 0x0600052F RID: 1327 RVA: 0x0000FF67 File Offset: 0x0000E167
	public override bool CanConvert(Type 1)
	{
		return 1.Method6716("System.Data.EntityKeyMember", false);
	}

	// Token: 0x04000413 RID: 1043
	[241(2)]
	private static 580 _recoveredType13757484;
}
