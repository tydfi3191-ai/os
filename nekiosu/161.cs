using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Runtime.Serialization;

// Token: 0x02000105 RID: 261
[242(1)]
[241(0)]
public sealed class 161 : 159
{
	// Token: 0x06000904 RID: 2308 RVA: 0x0001E95D File Offset: 0x0001CB5D
	public 161(158 1) : base(1)
	{
	}

	// Token: 0x06000905 RID: 2309 RVA: 0x0001E968 File Offset: 0x0001CB68
	public void Method11644(139 1, object 2)
	{
		756.Method12216(2, "target");
		Type type = 2.GetType();
		902 3 = this.jsonSerializer2._recoveredType21142968.ResolveContract(type);
		if (!1.Method2847())
		{
			throw 364.Method1687(1, "No JSON content found.");
		}
		if (1.GetTokenType() == 216.StartArray)
		{
			if (3._recoveredType17440783 == (659)2)
			{
				126 4 = (126)3;
				object obj;
				if (!4.GetFlag4646_5831())
				{
					obj = (IList)2;
				}
				else
				{
					obj = 4.CreateWrapper(2);
				}
				this.Method11675((IList)obj, 1, 4, null, null);
				return;
			}
			throw 364.Method1687(1, "Cannot populate JSON array onto type '{0}'.".Method6825(CultureInfo.InvariantCulture, type));
		}
		else
		{
			if (1.GetTokenType() != 216.StartObject)
			{
				throw 364.Method1687(1, "Unexpected initial token '{0}' when populating object. Expected JSON object or array.".Method6825(CultureInfo.InvariantCulture, 1.GetTokenType()));
			}
			1.Method2843();
			string 5 = null;
			if (this.jsonSerializer2.Method1773() != (504)2 && 1.GetTokenType() == 216.PropertyName && string.Equals(1.GetValue().ToString(), "$id", StringComparison.Ordinal))
			{
				1.Method2843();
				object value = 1.GetValue();
				5 = ((value != null) ? value.ToString() : null);
				1.Method2843();
			}
			if (3._recoveredType17440783 == (659)5)
			{
				493 6 = (493)3;
				object obj2;
				if (!6.GetFlag4184_5369())
				{
					obj2 = (IDictionary)2;
				}
				else
				{
					obj2 = 6.Method5373(2);
				}
				this.Method11672((IDictionary)obj2, 1, 6, null, 5);
				return;
			}
			if (3._recoveredType17440783 != (659)1)
			{
				throw 364.Method1687(1, "Cannot populate JSON object onto type '{0}'.".Method6825(CultureInfo.InvariantCulture, type));
			}
			this.Method11683(2, 1, (612)3, null, 5);
			return;
		}
	}

	// Token: 0x06000906 RID: 2310 RVA: 0x0001EB02 File Offset: 0x0001CD02
	[242(2)]
	private 902 Method11645(Type 1)
	{
		if (1 == null)
		{
			return null;
		}
		return this.Method11646(1);
	}

	// Token: 0x06000907 RID: 2311 RVA: 0x0001EB16 File Offset: 0x0001CD16
	private 902 Method11646(Type 1)
	{
		return this.jsonSerializer2._recoveredType21142968.ResolveContract(1);
	}

	// Token: 0x06000908 RID: 2312 RVA: 0x0001EB2C File Offset: 0x0001CD2C
	[242(2)]
	public object Method11647([241(1)] 139 1, Type 2, bool 3)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("reader");
		}
		902 4 = this.Method11645(2);
		object result;
		try
		{
			214 5 = this.Method11654(4, null, null, null);
			if (1.GetTokenType() == 216.None && !1.Method2845(4, 5 != null))
			{
				if (4 != null && !4.isNullable)
				{
					throw 364.Method1687(1, "No JSON content found and type '{0}' is not nullable.".Method6825(CultureInfo.InvariantCulture, 4.GetUnderlyingType()));
				}
				result = null;
			}
			else
			{
				object obj = (5 == null || !5.CanRead) ? this.Method11651(1, 2, 4, null, null, null, null) : this.Method11680(5, 1, 2, null);
				if (3)
				{
					while (1.Read())
					{
						if (1.GetTokenType() != 216.Comment)
						{
							throw 364.Method1687(1, "Additional text found in JSON string after finishing deserializing object.");
						}
					}
				}
				result = obj;
			}
		}
		catch (Exception 6)
		{
			if (!base.Method4120(null, 4, null, 1 as 99, 1.Path, 6))
			{
				base.Method4119();
				throw;
			}
			this.Method11690(1, false, 0);
			result = null;
		}
		return result;
	}

	// Token: 0x06000909 RID: 2313 RVA: 0x0001EC28 File Offset: 0x0001CE28
	private 366 Method11648()
	{
		if (this._recoveredType03193201 == null)
		{
			this._recoveredType03193201 = new 366(this);
		}
		return this._recoveredType03193201;
	}

	// Token: 0x0600090A RID: 2314 RVA: 0x0001EC44 File Offset: 0x0001CE44
	[242(2)]
	private 226 Method11649([241(1)] 139 1, 902 2)
	{
		756.Method12216(1, "reader");
		if (2 != null)
		{
			if (2.GetUnderlyingType() == typeof(225))
			{
				return 225.Create(1);
			}
			if (1.GetTokenType() == 216.Null && !(2.GetUnderlyingType() == typeof(233)) && !(2.GetUnderlyingType() == typeof(226)))
			{
				return null;
			}
		}
		226 4;
		using (124 3 = new 124())
		{
			3.WriteToken(1);
			4 = 3.Method11875();
		}
		if (2 != null && 4 != null && !2.GetUnderlyingType().IsAssignableFrom(4.GetType()))
		{
			throw 364.Method1687(1, "Deserialized JSON type '{0}' is not compatible with expected type '{1}'.".Method6825(CultureInfo.InvariantCulture, 4.GetType().FullName, 2.GetUnderlyingType().FullName));
		}
		return 4;
	}

	// Token: 0x0600090B RID: 2315 RVA: 0x0001ED30 File Offset: 0x0001CF30
	private 226 Method11650(139 1)
	{
		756.Method12216(1, "reader");
		124 2 = new 124();
		try
		{
			2.WriteStartObject();
			for (;;)
			{
				if (1.GetTokenType() == 216.PropertyName)
				{
					string text = (string)1.GetValue();
					if (!1.Method2846())
					{
						goto IL_71;
					}
					if (!this.Method11685(1, text))
					{
						2.WritePropertyName(text);
						2.WriteToken(1, true, true, false);
					}
				}
				else if (1.GetTokenType() != 216.Comment)
				{
					break;
				}
				if (!1.Read())
				{
					goto IL_71;
				}
			}
			2.WriteEndObject();
			return 2.Method11875();
			IL_71:
			throw 364.Method1687(1, "Unexpected end when deserializing object.");
		}
		finally
		{
			((IDisposable)2).Dispose();
		}
		226 result;
		return result;
	}

	// Token: 0x0600090C RID: 2316 RVA: 0x0001EDD4 File Offset: 0x0001CFD4
	[242(2)]
	private object Method11651([241(1)] 139 1, Type 2, 902 3, 666 4, 130 5, 666 6, object 7)
	{
		if (3 != null && 3._recoveredType17440783 == (659)8)
		{
			return this.Method11649(1, 3);
		}
		for (;;)
		{
			switch (1.GetTokenType())
			{
			case 216.StartObject:
				goto IL_6D;
			case 216.StartArray:
				goto IL_7F;
			case 216.StartConstructor:
				goto IL_E4;
			case 216.Comment:
				if (!1.Read())
				{
					goto Block_7;
				}
				continue;
			case 216.Raw:
				goto IL_12D;
			case 216.Integer:
			case 216.Float:
			case 216.Boolean:
			case 216.Date:
			case 216.Bytes:
				goto IL_8E;
			case 216.String:
				goto IL_A3;
			case 216.Null:
			case 216.Undefined:
				goto IL_100;
			}
			break;
		}
		goto IL_13E;
		IL_6D:
		return this.Method11655(1, 2, 3, 4, 5, 6, 7);
		IL_7F:
		return this.Method11660(1, 2, 3, 4, 7, null);
		IL_8E:
		return this.Method11662(1, 1.GetValue(), CultureInfo.InvariantCulture, 3, 2);
		IL_A3:
		string text = (string)1.GetValue();
		if (2 == typeof(byte[]))
		{
			return Convert.FromBase64String(text);
		}
		if (161.Method11652(2, 3, text))
		{
			return null;
		}
		return this.Method11662(1, text, CultureInfo.InvariantCulture, 3, 2);
		IL_E4:
		string 8 = 1.GetValue().ToString();
		return this.Method11662(1, 8, CultureInfo.InvariantCulture, 3, 2);
		IL_100:
		if (2 == typeof(DBNull))
		{
			return DBNull.Value;
		}
		return this.Method11662(1, 1.GetValue(), CultureInfo.InvariantCulture, 3, 2);
		IL_12D:
		return new 225((string)1.GetValue());
		IL_13E:
		throw 364.Method1687(1, "Unexpected token while deserializing object: " + 1.GetTokenType().ToString());
		Block_7:
		throw 364.Method1687(1, "Unexpected end when deserializing object.");
	}

	// Token: 0x0600090D RID: 2317 RVA: 0x0001EF5C File Offset: 0x0001D15C
	[242(2)]
	private static bool Method11652(Type 1, 902 2, [241(1)] string 3)
	{
		return 538.Method6824(3) && 1 != null && 1 != typeof(string) && 1 != typeof(object) && 2 != null && 2.isNullable;
	}

	// Token: 0x0600090E RID: 2318 RVA: 0x0001EFAC File Offset: 0x0001D1AC
	internal string Method11653(902 1)
	{
		switch (1._recoveredType17440783)
		{
		case (659)1:
		case (659)5:
		case (659)6:
		case (659)7:
			return "JSON object (e.g. {\"name\":\"value\"})";
		case (659)2:
			return "JSON array (e.g. [1,2,3])";
		case (659)3:
			return "JSON primitive value (e.g. string, number, boolean, null)";
		case (659)4:
			return "JSON string value";
		default:
			throw new ArgumentOutOfRangeException();
		}
	}

	// Token: 0x0600090F RID: 2319 RVA: 0x0001F004 File Offset: 0x0001D204
	[242(2)]
	private 214 Method11654(902 1, 214 2, 130 3, 666 4)
	{
		214 result = null;
		if (2 != null)
		{
			result = 2;
		}
		else if (((4 != null) ? 4.GetJsonConverter7784_9923() : null) != null)
		{
			result = 4.GetJsonConverter7784_9923();
		}
		else if (((3 != null) ? 3.GetItemConverter() : null) != null)
		{
			result = 3.GetItemConverter();
		}
		else if (1 != null)
		{
			if (1.Converter != null)
			{
				result = 1.Converter;
			}
			else
			{
				214 5 = this.jsonSerializer2.Method3855(1.GetUnderlyingType());
				if (5 != null)
				{
					result = 5;
				}
				else if (1.InternalConverter != null)
				{
					result = 1.InternalConverter;
				}
			}
		}
		return result;
	}

	// Token: 0x06000910 RID: 2320 RVA: 0x0001F088 File Offset: 0x0001D288
	[242(2)]
	private object Method11655([241(1)] 139 1, Type 2, 902 3, 666 4, 130 5, 666 6, object 7)
	{
		Type type = 2;
		string text;
		if (this.jsonSerializer2.Method1773() == (504)2)
		{
			1.Method2843();
			text = null;
		}
		else if (this.jsonSerializer2.Method1773() == (504)1)
		{
			123 8 = 1 as 123;
			if (8 == null)
			{
				8 = (123)226.ReadFrom(1).CreateReader();
				8.Culture = 1.Culture;
				8.SetDateFormatString(1.GetDateFormatString());
				8.SetDateParseHandling(1.GetDateParseHandling());
				8.SetDateTimeZoneHandling(1.GetDateTimeZoneHandling());
				8.SetFloatParseHandling(1.GetFloatParseHandling());
				8.SetSupportMultipleContent(1.GetSupportMultipleContent());
				8.Method2843();
				1 = 8;
			}
			object result;
			if (this.Method11656(8, ref type, ref 3, 4, 5, 6, 7, out result, out text))
			{
				return result;
			}
		}
		else
		{
			1.Method2843();
			object result2;
			if (this.Method11657(1, ref type, ref 3, 4, 5, 6, 7, out result2, out text))
			{
				return result2;
			}
		}
		if (this.Method11661(3))
		{
			return this.Method11650(1);
		}
		switch (3._recoveredType17440783)
		{
		case (659)1:
		{
			bool flag = false;
			612 9 = (612)3;
			object obj = (7 == null || (!(type == 2) && !type.IsAssignableFrom(7.GetType()))) ? this.Method11682(1, 9, 4, 6, text, out flag) : 7;
			if (flag)
			{
				return obj;
			}
			return this.Method11683(obj, 1, 9, 4, text);
		}
		case (659)3:
		{
			806 10 = (806)3;
			if (this.jsonSerializer2.Method1773() != (504)2 && 1.GetTokenType() == 216.PropertyName && string.Equals(1.GetValue().ToString(), "$value", StringComparison.Ordinal))
			{
				1.Method2843();
				if (1.GetTokenType() == 216.StartObject)
				{
					throw 364.Method1687(1, "Unexpected token when deserializing primitive value: " + 1.GetTokenType().ToString());
				}
				object result3 = this.Method11651(1, type, 10, 4, null, null, 7);
				1.Method2843();
				return result3;
			}
			break;
		}
		case (659)5:
		{
			493 11 = (493)3;
			if (7 != null)
			{
				object obj2;
				if (!11.GetFlag4184_5369() && 7 is IDictionary)
				{
					obj2 = (IDictionary)7;
				}
				else
				{
					obj2 = 11.Method5373(7);
				}
				return this.Method11672((IDictionary)obj2, 1, 11, 4, text);
			}
			bool flag2;
			IDictionary dictionary = this.Method11669(1, 11, out flag2);
			if (flag2)
			{
				if (text != null)
				{
					throw 364.Method1687(1, "Cannot preserve reference to readonly dictionary, or dictionary created from a non-default constructor: {0}.".Method6825(CultureInfo.InvariantCulture, 3.GetUnderlyingType()));
				}
				if (3.Method1376().Count > 0)
				{
					throw 364.Method1687(1, "Cannot call OnSerializing on readonly dictionary, or dictionary created from a non-default constructor: {0}.".Method6825(CultureInfo.InvariantCulture, 3.GetUnderlyingType()));
				}
				if (3.GetOnErrorCallbacks().Count > 0)
				{
					throw 364.Method1687(1, "Cannot call OnError on readonly list, or dictionary created from a non-default constructor: {0}.".Method6825(CultureInfo.InvariantCulture, 3.GetUnderlyingType()));
				}
				if (!11.Method5372())
				{
					throw 364.Method1687(1, "Cannot deserialize readonly or fixed size dictionary: {0}.".Method6825(CultureInfo.InvariantCulture, 3.GetUnderlyingType()));
				}
			}
			this.Method11672(dictionary, 1, 11, 4, text);
			if (flag2)
			{
				return (11.RecoveredType10454191 ?? 11.RecoveredType10454190)(new object[]
				{
					dictionary
				});
			}
			424 12 = dictionary as 424;
			if (12 != null)
			{
				return 12.Value7881;
			}
			return dictionary;
		}
		case (659)6:
		{
			390 13 = (390)3;
			return this.Method11678(1, 13, 4, text);
		}
		case (659)7:
		{
			515 14 = (515)3;
			return this.Method11676(1, 14, 4, text);
		}
		}
		string text2 = "Cannot deserialize the current JSON object (e.g. {{\"name\":\"value\"}}) into type '{0}' because the type requires a {1} to deserialize correctly." + Environment.NewLine + "To fix this error either change the JSON to a {1} or change the deserialized type so that it is a normal .NET type (e.g. not a primitive type like integer, not a collection type like an array or List<T>) that can be deserialized from a JSON object. JsonObjectAttribute can also be added to the type to force it to deserialize from a JSON object." + Environment.NewLine;
		text2 = text2.Method6825(CultureInfo.InvariantCulture, type, this.Method11653(3));
		throw 364.Method1687(1, text2);
	}

	// Token: 0x06000911 RID: 2321 RVA: 0x0001F434 File Offset: 0x0001D634
	[242(2)]
	private bool Method11656([241(1)] 123 1, ref Type 2, ref 902 3, 666 4, 130 5, 666 6, object 7, out object 8, out string 9)
	{
		9 = null;
		8 = null;
		if (1.GetTokenType() == 216.StartObject)
		{
			217 10 = (217)1.JToken6023;
			222 11 = 10.Property("$ref", StringComparison.Ordinal);
			if (11 != null)
			{
				226 value = 11.Value;
				if (value.Type != 705.String && value.Type != 705.Null)
				{
					throw 364.Method1687(value, value.Path, "JSON reference {0} property must have a string or null value.".Method6825(CultureInfo.InvariantCulture, "$ref"), null);
				}
				string text = (string)11;
				if (text != null)
				{
					226 12 = 11.Next ?? 11.Previous;
					if (12 != null)
					{
						throw 364.Method1687(12, 12.Path, "Additional content found in JSON reference object. A JSON reference object should only have a {0} property.".Method6825(CultureInfo.InvariantCulture, "$ref"), null);
					}
					8 = this.jsonSerializer2.Method3854().Method11692(this, text);
					if (this._recoveredType17753200 != null && this._recoveredType17753200.GetLevelFilter() >= TraceLevel.Info)
					{
						this._recoveredType17753200.WriteTrace(TraceLevel.Info, 137.Method3522(1, 1.Path, "Resolved object reference '{0}' to {1}.".Method6825(CultureInfo.InvariantCulture, text, 8.GetType())), null);
					}
					1.Skip();
					return true;
				}
			}
			226 13 = 10["$type"];
			if (13 != null)
			{
				string 14 = (string)13;
				139 15 = 13.CreateReader();
				15.Method2843();
				this.Method11658(15, ref 2, ref 3, 4, 5, 6, 14);
				if (10["$value"] != null)
				{
					for (;;)
					{
						1.Method2843();
						if (1.GetTokenType() == 216.PropertyName && (string)1.GetValue() == "$value")
						{
							break;
						}
						1.Method2843();
						1.Skip();
					}
					return false;
				}
			}
			226 16 = 10["$id"];
			if (16 != null)
			{
				9 = (string)16;
			}
			226 17 = 10["$values"];
			if (17 != null)
			{
				139 18 = 17.CreateReader();
				18.Method2843();
				8 = this.Method11660(18, 2, 3, 4, 7, 9);
				1.Skip();
				return true;
			}
		}
		1.Method2843();
		return false;
	}

	// Token: 0x06000912 RID: 2322 RVA: 0x0001F640 File Offset: 0x0001D840
	[242(2)]
	private bool Method11657([241(1)] 139 1, ref Type 2, ref 902 3, 666 4, 130 5, 666 6, object 7, out object 8, out string 9)
	{
		9 = null;
		8 = null;
		if (1.GetTokenType() == 216.PropertyName)
		{
			string text = 1.GetValue().ToString();
			if (text.Length > 0 && text[0] == '$')
			{
				string text2;
				for (;;)
				{
					text = 1.GetValue().ToString();
					bool flag;
					if (string.Equals(text, "$ref", StringComparison.Ordinal))
					{
						1.Method2843();
						if (1.GetTokenType() != 216.String && 1.GetTokenType() != 216.Null)
						{
							break;
						}
						object value = 1.GetValue();
						text2 = ((value != null) ? value.ToString() : null);
						1.Method2843();
						if (text2 != null)
						{
							goto Block_7;
						}
						flag = true;
					}
					else if (string.Equals(text, "$type", StringComparison.Ordinal))
					{
						1.Method2843();
						string 10 = 1.GetValue().ToString();
						this.Method11658(1, ref 2, ref 3, 4, 5, 6, 10);
						1.Method2843();
						flag = true;
					}
					else if (string.Equals(text, "$id", StringComparison.Ordinal))
					{
						1.Method2843();
						object value2 = 1.GetValue();
						9 = ((value2 != null) ? value2.ToString() : null);
						1.Method2843();
						flag = true;
					}
					else
					{
						if (string.Equals(text, "$values", StringComparison.Ordinal))
						{
							goto Block_14;
						}
						flag = false;
					}
					if (!flag || 1.GetTokenType() != 216.PropertyName)
					{
						return false;
					}
				}
				throw 364.Method1687(1, "JSON reference {0} property must have a string or null value.".Method6825(CultureInfo.InvariantCulture, "$ref"));
				Block_7:
				if (1.GetTokenType() == 216.PropertyName)
				{
					throw 364.Method1687(1, "Additional content found in JSON reference object. A JSON reference object should only have a {0} property.".Method6825(CultureInfo.InvariantCulture, "$ref"));
				}
				8 = this.jsonSerializer2.Method3854().Method11692(this, text2);
				if (this._recoveredType17753200 != null && this._recoveredType17753200.GetLevelFilter() >= TraceLevel.Info)
				{
					this._recoveredType17753200.WriteTrace(TraceLevel.Info, 137.Method3522(1 as 99, 1.Path, "Resolved object reference '{0}' to {1}.".Method6825(CultureInfo.InvariantCulture, text2, 8.GetType())), null);
				}
				return true;
				Block_14:
				1.Method2843();
				object obj = this.Method11660(1, 2, 3, 4, 7, 9);
				1.Method2843();
				8 = obj;
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000913 RID: 2323 RVA: 0x0001F83C File Offset: 0x0001DA3C
	[242(2)]
	private void Method11658([241(1)] 139 1, ref Type 2, ref 902 3, 666 4, 130 5, 666 6, [241(1)] string 7)
	{
		if ((((4 != null) ? 4.GetNullable7779_9921() : null) ?? (((5 != null) ? 5.GetItemTypeNameHandling() : null) ?? (((6 != null) ? 6.GetNullable7786_9927() : null) ?? this.jsonSerializer2.typeNameHandling2))) != (933)0)
		{
			558<string, string> 8 = 143.SplitFullyQualifiedTypeName(7);
			Type type;
			try
			{
				type = this.jsonSerializer2._recoveredType20112971.BindToType(8._item5821, 8._item5822);
			}
			catch (Exception 9)
			{
				throw 364.Method1687(1, "Error resolving type specified in JSON '{0}'.".Method6825(CultureInfo.InvariantCulture, 7), 9);
			}
			if (type == null)
			{
				throw 364.Method1687(1, "Type specified in JSON '{0}' was not resolved.".Method6825(CultureInfo.InvariantCulture, 7));
			}
			if (this._recoveredType17753200 != null && this._recoveredType17753200.GetLevelFilter() >= TraceLevel.Verbose)
			{
				this._recoveredType17753200.WriteTrace(TraceLevel.Verbose, 137.Method3522(1 as 99, 1.Path, "Resolved type '{0}' to {1}.".Method6825(CultureInfo.InvariantCulture, 7, type)), null);
			}
			if (2 != null && 2 != typeof(IDynamicMetaObjectProvider) && !2.IsAssignableFrom(type))
			{
				throw 364.Method1687(1, "Type specified in JSON '{0}' is not compatible with '{1}'.".Method6825(CultureInfo.InvariantCulture, type.AssemblyQualifiedName, 2.AssemblyQualifiedName));
			}
			2 = type;
			3 = this.Method11646(type);
		}
	}

	// Token: 0x06000914 RID: 2324 RVA: 0x0001F9F0 File Offset: 0x0001DBF0
	private 126 Method11659(139 1, Type 2, 902 3)
	{
		if (3 == null)
		{
			throw 364.Method1687(1, "Could not resolve type '{0}' to a JsonContract.".Method6825(CultureInfo.InvariantCulture, 2));
		}
		126 4 = 3 as 126;
		if (4 == null)
		{
			string text = "Cannot deserialize the current JSON array (e.g. [1,2,3]) into type '{0}' because the type requires a {1} to deserialize correctly." + Environment.NewLine + "To fix this error either change the JSON to a {1} or change the deserialized type to an array or a type that implements a collection interface (e.g. ICollection, IList) like List<T> that can be deserialized from a JSON array. JsonArrayAttribute can also be added to the type to force it to deserialize from a JSON array." + Environment.NewLine;
			text = text.Method6825(CultureInfo.InvariantCulture, 2, this.Method11653(3));
			throw 364.Method1687(1, text);
		}
		return 4;
	}

	// Token: 0x06000915 RID: 2325 RVA: 0x0001FA58 File Offset: 0x0001DC58
	[242(2)]
	private object Method11660([241(1)] 139 1, Type 2, 902 3, 666 4, object 5, string 6)
	{
		if (this.Method11661(3))
		{
			return this.Method11649(1, 3);
		}
		126 7 = this.Method11659(1, 2, 3);
		if (5 == null)
		{
			bool flag;
			IList list = this.Method11668(1, 7, out flag);
			if (flag)
			{
				if (6 != null)
				{
					throw 364.Method1687(1, "Cannot preserve reference to array or readonly list, or list created from a non-default constructor: {0}.".Method6825(CultureInfo.InvariantCulture, 3.GetUnderlyingType()));
				}
				if (3.Method1376().Count > 0)
				{
					throw 364.Method1687(1, "Cannot call OnSerializing on an array or readonly list, or list created from a non-default constructor: {0}.".Method6825(CultureInfo.InvariantCulture, 3.GetUnderlyingType()));
				}
				if (3.GetOnErrorCallbacks().Count > 0)
				{
					throw 364.Method1687(1, "Cannot call OnError on an array or readonly list, or list created from a non-default constructor: {0}.".Method6825(CultureInfo.InvariantCulture, 3.GetUnderlyingType()));
				}
				if (!7.Method5836() && !7.GetIsArrayLike())
				{
					throw 364.Method1687(1, "Cannot deserialize readonly or fixed size list: {0}.".Method6825(CultureInfo.InvariantCulture, 3.GetUnderlyingType()));
				}
			}
			if (!7.GetIsMultidimensionalArray())
			{
				this.Method11675(list, 1, 7, 4, 6);
			}
			else
			{
				this.Method11673(list, 1, 7, 4, 6);
			}
			if (flag)
			{
				if (7.GetIsMultidimensionalArray())
				{
					list = 418.Method3181(list, 7.GetCollectionItemType(), 3.GetCreatedType().GetArrayRank());
				}
				else
				{
					if (!7.GetIsArrayLike())
					{
						return (7.RecoveredType10454653 ?? 7.RecoveredType10454652)(new object[]
						{
							list
						});
					}
					Array array = Array.CreateInstance(7.GetCollectionItemType(), list.Count);
					list.CopyTo(array, 0);
					list = array;
				}
			}
			else
			{
				450 8 = list as 450;
				if (8 != null)
				{
					return 8.Value8359;
				}
			}
			return list;
		}
		if (!7.GetCanDeserialize())
		{
			throw 364.Method1687(1, "Cannot populate list type {0}.".Method6825(CultureInfo.InvariantCulture, 3.GetCreatedType()));
		}
		IList 9;
		if (!7.GetFlag4646_5831())
		{
			IList list2 = 5 as IList;
			if (list2 != null)
			{
				9 = list2;
				goto IL_1CD;
			}
		}
		9 = 7.CreateWrapper(5);
		IL_1CD:
		return this.Method11675(9, 1, 7, 4, 6);
	}

	// Token: 0x06000916 RID: 2326 RVA: 0x0001FC3F File Offset: 0x0001DE3F
	[242(2)]
	private bool Method11661(902 1)
	{
		return 1 == null || 1.GetUnderlyingType() == typeof(object) || 1._recoveredType17440783 == (659)8 || 1.GetUnderlyingType() == typeof(IDynamicMetaObjectProvider);
	}

	// Token: 0x06000917 RID: 2327 RVA: 0x0001FC7C File Offset: 0x0001DE7C
	[242(2)]
	private object Method11662([241(1)] 139 1, object 2, [241(1)] CultureInfo 3, 902 4, Type 5)
	{
		if (5 == null)
		{
			return 2;
		}
		if (143.GetObjectType(2) != 5)
		{
			if (2 == null && 4.isNullable)
			{
				return null;
			}
			try
			{
				if (!4.flag3)
				{
					return 358.Method1501(2, 3, 4.nonNullableUnderlyingType);
				}
				806 6 = (806)4;
				if (4.flag4)
				{
					string text = 2 as string;
					if (text != null)
					{
						return 83.ParseEnum(4.nonNullableUnderlyingType, null, text, false);
					}
					if (358.Method1504(6.GetRecoveredType206110432_13502()))
					{
						return Enum.ToObject(4.nonNullableUnderlyingType, 2);
					}
				}
				else if (4.nonNullableUnderlyingType == typeof(DateTime))
				{
					string text2 = 2 as string;
					DateTime 7;
					if (text2 != null && 382.Method2121(text2, 1.GetDateTimeZoneHandling(), 1.GetDateFormatString(), 1.Culture, out 7))
					{
						return 382.Method2108(7, 1.GetDateTimeZoneHandling());
					}
				}
				if (2 is BigInteger)
				{
					BigInteger 8 = (BigInteger)2;
					return 358.Method1497(8, 4.nonNullableUnderlyingType);
				}
				return Convert.ChangeType(2, 4.nonNullableUnderlyingType, 3);
			}
			catch (Exception 9)
			{
				throw 364.Method1687(1, "Error converting value {0} to type '{1}'.".Method6825(CultureInfo.InvariantCulture, 736.Method11630(2), 5), 9);
			}
			return 2;
		}
		return 2;
	}

	// Token: 0x06000918 RID: 2328 RVA: 0x0001FDEC File Offset: 0x0001DFEC
	private bool Method11663(666 1, [241(2)] 214 2, [241(2)] 130 3, [241(2)] 666 4, 139 5, object 6)
	{
		bool flag;
		object obj;
		902 7;
		bool flag2;
		bool result;
		if (this.Method11664(1, ref 2, 3, 4, 5, 6, out flag, out obj, out 7, out flag2, out result))
		{
			return result;
		}
		object obj2;
		if (2 != null && 2.CanRead)
		{
			if (!flag2 && 1.GetFlag7771_9899())
			{
				obj = 1.GetRecoveredType13467767_9887().Method8005(6);
			}
			obj2 = this.Method11680(2, 5, 1.GetType7762_9891(), obj);
		}
		else
		{
			obj2 = this.Method11651(5, 1.GetType7762_9891(), 7, 1, 3, 4, flag ? obj : null);
		}
		if ((!flag || obj2 != obj) && this.Method11667(1, 3 as 612, obj2))
		{
			1.GetRecoveredType13467767_9887().Method8004(6, obj2);
			if (1.Action7791 != null)
			{
				if (this._recoveredType17753200 != null && this._recoveredType17753200.GetLevelFilter() >= TraceLevel.Verbose)
				{
					this._recoveredType17753200.WriteTrace(TraceLevel.Verbose, 137.Method3522(5 as 99, 5.Path, "IsSpecified for property '{0}' on {1} set to true.".Method6825(CultureInfo.InvariantCulture, 1.GetText7760_9879(), 1.GetType7764_9881())), null);
				}
				1.Action7791(6, true);
			}
			return true;
		}
		return flag;
	}

	// Token: 0x06000919 RID: 2329 RVA: 0x0001FF0C File Offset: 0x0001E10C
	[242(2)]
	private bool Method11664([241(1)] 666 1, ref 214 2, 130 3, 666 4, [241(1)] 139 5, [241(1)] object 6, out bool 7, out object 8, out 902 9, out bool 10, out bool 11)
	{
		8 = null;
		7 = false;
		9 = null;
		10 = false;
		11 = false;
		if (1.GetFlag7770_9897())
		{
			return true;
		}
		216 tokenType = 5.GetTokenType();
		if (1.GetRecoveredType02517763_9877() == null)
		{
			1.SetRecoveredType02517763_9878(this.Method11645(1.GetType7762_9891()));
		}
		if (1.GetNullable7778_9919().GetValueOrDefault(this.jsonSerializer2.objectCreationHandling2) != (243)2 && (tokenType == 216.StartArray || tokenType == 216.StartObject || 2 != null) && 1.GetFlag7771_9899())
		{
			902 recoveredType02517763_ = 1.GetRecoveredType02517763_9877();
			if (recoveredType02517763_ == null || recoveredType02517763_._recoveredType17440783 != (659)8)
			{
				8 = 1.GetRecoveredType13467767_9887().Method8005(6);
				10 = true;
				if (8 != null)
				{
					9 = this.Method11646(8.GetType());
					7 = (!9.flag5 && !9.GetUnderlyingType().Method6714());
				}
			}
		}
		if (!1.GetFlag7772_9901() && !7)
		{
			if (this._recoveredType17753200 != null && this._recoveredType17753200.GetLevelFilter() >= TraceLevel.Info)
			{
				this._recoveredType17753200.WriteTrace(TraceLevel.Info, 137.Method3522(5 as 99, 5.Path, "Unable to deserialize value to non-writable property '{0}' on {1}.".Method6825(CultureInfo.InvariantCulture, 1.GetText7760_9879(), 1.GetType7764_9881())), null);
			}
			return true;
		}
		if (tokenType == 216.Null && base.Method4117(3 as 612, 1) == (240)1)
		{
			11 = true;
			return true;
		}
		if (this.Method11666(1.GetNullable7776_9915().GetValueOrDefault(this.jsonSerializer2.defaultValueHandling2), (50)1) && !this.Method11666(1.GetNullable7776_9915().GetValueOrDefault(this.jsonSerializer2.defaultValueHandling2), (50)2) && 169.IsPrimitiveToken(tokenType) && 736.Method11628(5.GetValue(), 1.Method9907()))
		{
			11 = true;
			return true;
		}
		if (8 == null)
		{
			9 = 1.GetRecoveredType02517763_9877();
		}
		else
		{
			9 = this.Method11646(8.GetType());
			if (9 != 1.GetRecoveredType02517763_9877())
			{
				2 = this.Method11654(9, 1.GetJsonConverter7769_9893(), 3, 4);
			}
		}
		return false;
	}

	// Token: 0x0600091A RID: 2330 RVA: 0x00020108 File Offset: 0x0001E308
	private void Method11665(139 1, string 2, object 3)
	{
		try
		{
			if (this._recoveredType17753200 != null && this._recoveredType17753200.GetLevelFilter() >= TraceLevel.Verbose)
			{
				this._recoveredType17753200.WriteTrace(TraceLevel.Verbose, 137.Method3522(1 as 99, 1.Path, "Read object reference Id '{0}' for {1}.".Method6825(CultureInfo.InvariantCulture, 2, 3.GetType())), null);
			}
			this.jsonSerializer2.Method3854().Method11694(this, 2, 3);
		}
		catch (Exception 4)
		{
			throw 364.Method1687(1, "Error reading object reference '{0}'.".Method6825(CultureInfo.InvariantCulture, 2), 4);
		}
	}

	// Token: 0x0600091B RID: 2331 RVA: 0x00010382 File Offset: 0x0000E582
	private bool Method11666(50 1, 50 2)
	{
		return (1 & 2) == 2;
	}

	// Token: 0x0600091C RID: 2332 RVA: 0x000201A0 File Offset: 0x0001E3A0
	[242(2)]
	private bool Method11667([241(1)] 666 1, 612 2, object 3)
	{
		return (3 != null || base.Method4117(2, 1) != (240)1) && (!this.Method11666(1.GetNullable7776_9915().GetValueOrDefault(this.jsonSerializer2.defaultValueHandling2), (50)1) || this.Method11666(1.GetNullable7776_9915().GetValueOrDefault(this.jsonSerializer2.defaultValueHandling2), (50)2) || !736.Method11628(3, 1.Method9907())) && 1.GetFlag7772_9901();
	}

	// Token: 0x0600091D RID: 2333 RVA: 0x0002021C File Offset: 0x0001E41C
	private IList Method11668(139 1, 126 2, out bool 3)
	{
		if (!2.GetCanDeserialize())
		{
			throw 364.Method1687(1, "Cannot create and populate list type {0}.".Method6825(CultureInfo.InvariantCulture, 2.GetCreatedType()));
		}
		if (2.RecoveredType10454653 != null)
		{
			if (2.GetFlag4651_5834())
			{
				3 = true;
				return 2.CreateTemporaryCollection();
			}
			object obj = 2.RecoveredType10454653(Array.Empty<object>());
			if (2.GetFlag4646_5831())
			{
				obj = 2.CreateWrapper(obj);
			}
			3 = false;
			return (IList)obj;
		}
		else
		{
			if (2.flag5)
			{
				3 = true;
				IList list = 2.CreateTemporaryCollection();
				if (2.GetFlag4646_5831())
				{
					list = 2.CreateWrapper(list);
				}
				return list;
			}
			if (2.DefaultCreator != null && (!2.GetFlag0798_1378() || this.jsonSerializer2._recoveredType14152965 == (593)1))
			{
				object obj2 = 2.DefaultCreator();
				if (2.GetFlag4646_5831())
				{
					obj2 = 2.CreateWrapper(obj2);
				}
				3 = false;
				return (IList)obj2;
			}
			if (2.Method5836())
			{
				3 = true;
				return 2.CreateTemporaryCollection();
			}
			if (!2.isInstantiable)
			{
				throw 364.Method1687(1, "Could not create an instance of type {0}. Type is an interface or abstract class and cannot be instantiated.".Method6825(CultureInfo.InvariantCulture, 2.GetUnderlyingType()));
			}
			throw 364.Method1687(1, "Unable to find a constructor to use for type {0}.".Method6825(CultureInfo.InvariantCulture, 2.GetUnderlyingType()));
		}
	}

	// Token: 0x0600091E RID: 2334 RVA: 0x0002034C File Offset: 0x0001E54C
	private IDictionary Method11669(139 1, 493 2, out bool 3)
	{
		if (2.RecoveredType10454191 != null)
		{
			if (2.GetFlag4188_5370())
			{
				3 = true;
				return 2.Method5374();
			}
			3 = false;
			return (IDictionary)2.RecoveredType10454191(Array.Empty<object>());
		}
		else
		{
			if (2.flag5)
			{
				3 = true;
				return 2.Method5374();
			}
			if (2.DefaultCreator != null && (!2.GetFlag0798_1378() || this.jsonSerializer2._recoveredType14152965 == (593)1))
			{
				object obj = 2.DefaultCreator();
				if (2.GetFlag4184_5369())
				{
					obj = 2.Method5373(obj);
				}
				3 = false;
				return (IDictionary)obj;
			}
			if (2.Method5372())
			{
				3 = true;
				return 2.Method5374();
			}
			if (!2.isInstantiable)
			{
				throw 364.Method1687(1, "Could not create an instance of type {0}. Type is an interface or abstract class and cannot be instantiated.".Method6825(CultureInfo.InvariantCulture, 2.GetUnderlyingType()));
			}
			throw 364.Method1687(1, "Unable to find a default constructor to use for type {0}.".Method6825(CultureInfo.InvariantCulture, 2.GetUnderlyingType()));
		}
	}

	// Token: 0x0600091F RID: 2335 RVA: 0x00020434 File Offset: 0x0001E634
	private void Method11670(139 1, 902 2, object 3)
	{
		if (this._recoveredType17753200 != null && this._recoveredType17753200.GetLevelFilter() >= TraceLevel.Info)
		{
			this._recoveredType17753200.WriteTrace(TraceLevel.Info, 137.Method3522(1 as 99, 1.Path, "Started deserializing {0}".Method6825(CultureInfo.InvariantCulture, 2.GetUnderlyingType())), null);
		}
		2.Method1382(3, this.jsonSerializer2.streamingContext2);
	}

	// Token: 0x06000920 RID: 2336 RVA: 0x0002049C File Offset: 0x0001E69C
	private void Method11671(139 1, 902 2, object 3)
	{
		if (this._recoveredType17753200 != null && this._recoveredType17753200.GetLevelFilter() >= TraceLevel.Info)
		{
			this._recoveredType17753200.WriteTrace(TraceLevel.Info, 137.Method3522(1 as 99, 1.Path, "Finished deserializing {0}".Method6825(CultureInfo.InvariantCulture, 2.GetUnderlyingType())), null);
		}
		2.Method1383(3, this.jsonSerializer2.streamingContext2);
	}

	// Token: 0x06000921 RID: 2337 RVA: 0x00020504 File Offset: 0x0001E704
	private object Method11672(IDictionary 1, 139 2, 493 3, [241(2)] 666 4, [241(2)] string 5)
	{
		424 6 = 1 as 424;
		object obj = (6 != null) ? 6.Value7881 : 1;
		if (5 != null)
		{
			this.Method11665(2, 5, obj);
		}
		this.Method11670(2, 3, obj);
		int depth = 2.GetDepth();
		if (3.GetRecoveredType02514179_5367() == null)
		{
			3.SetRecoveredType02514179_5368(this.Method11645(3.GetType4177_5365()));
		}
		if (3.GetItemContract() == null)
		{
			3.SetItemContract(this.Method11645(3.GetType4178_5366()));
		}
		214 7 = 3.GetItemConverter() ?? this.Method11654(3.GetItemContract(), null, 3, 4);
		806 8 = 3.GetRecoveredType02514179_5367() as 806;
		723 9 = (8 != null) ? 8.GetRecoveredType206110432_13502() : 723.Empty;
		bool flag = false;
		for (;;)
		{
			216 tokenType = 2.GetTokenType();
			if (tokenType != 216.PropertyName)
			{
				if (tokenType != 216.Comment)
				{
					if (tokenType != 216.EndObject)
					{
						break;
					}
					goto IL_29C;
				}
			}
			else
			{
				object obj2 = 2.GetValue();
				if (!this.Method11685(2, obj2.ToString()))
				{
					try
					{
						try
						{
							if (9 - 723.DateTime > 1)
							{
								if (9 - 723.DateTimeOffset > 1)
								{
									object obj3;
									if (3.GetRecoveredType02514179_5367() == null || !3.GetRecoveredType02514179_5367().flag4)
									{
										obj3 = this.Method11662(2, obj2, CultureInfo.InvariantCulture, 3.GetRecoveredType02514179_5367(), 3.GetType4177_5365());
									}
									else
									{
										Type nonNullableUnderlyingType = 3.GetRecoveredType02514179_5367().nonNullableUnderlyingType;
										65 10 = this.jsonSerializer2._recoveredType21142968 as 65;
										obj3 = 83.ParseEnum(nonNullableUnderlyingType, (10 != null) ? 10.NamingStrategy : null, obj2.ToString(), false);
									}
									obj2 = obj3;
								}
								else
								{
									DateTimeOffset dateTimeOffset;
									obj2 = (382.Method2123(obj2.ToString(), 2.GetDateFormatString(), 2.Culture, out dateTimeOffset) ? dateTimeOffset : this.Method11662(2, obj2, CultureInfo.InvariantCulture, 3.GetRecoveredType02514179_5367(), 3.GetType4177_5365()));
								}
							}
							else
							{
								DateTime dateTime;
								obj2 = (382.Method2121(obj2.ToString(), 2.GetDateTimeZoneHandling(), 2.GetDateFormatString(), 2.Culture, out dateTime) ? dateTime : this.Method11662(2, obj2, CultureInfo.InvariantCulture, 3.GetRecoveredType02514179_5367(), 3.GetType4177_5365()));
							}
						}
						catch (Exception 11)
						{
							throw 364.Method1687(2, "Could not convert string '{0}' to dictionary key type '{1}'. Create a TypeConverter to convert from the string to the key type object.".Method6825(CultureInfo.InvariantCulture, 2.GetValue(), 3.GetType4177_5365()), 11);
						}
						if (!2.Method2845(3.GetItemContract(), 7 != null))
						{
							throw 364.Method1687(2, "Unexpected end when deserializing object.");
						}
						object value = (7 == null || !7.CanRead) ? this.Method11651(2, 3.GetType4178_5366(), 3.GetItemContract(), null, 3, 4, null) : this.Method11680(7, 2, 3.GetType4178_5366(), null);
						1[obj2] = value;
						goto IL_2C7;
					}
					catch (Exception 12)
					{
						if (base.Method4120(obj, 3, obj2, 2 as 99, 2.Path, 12))
						{
							this.Method11690(2, true, depth);
							goto IL_2C7;
						}
						throw;
					}
					goto IL_29C;
				}
			}
			IL_2C7:
			if (flag || !2.Read())
			{
				goto IL_2D6;
			}
			continue;
			IL_29C:
			flag = true;
			goto IL_2C7;
		}
		throw 364.Method1687(2, "Unexpected token when deserializing object: " + 2.GetTokenType().ToString());
		IL_2D6:
		if (!flag)
		{
			this.Method11674(2, 3, obj, "Unexpected end when deserializing object.");
		}
		this.Method11671(2, 3, obj);
		return obj;
	}

	// Token: 0x06000922 RID: 2338 RVA: 0x00020838 File Offset: 0x0001EA38
	private object Method11673(IList 1, 139 2, 126 3, [241(2)] 666 4, [241(2)] string 5)
	{
		int arrayRank = 3.GetUnderlyingType().GetArrayRank();
		if (5 != null)
		{
			this.Method11665(2, 5, 1);
		}
		this.Method11670(2, 3, 1);
		902 6 = this.Method11645(3.GetCollectionItemType());
		214 7 = this.Method11654(6, null, 3, 4);
		int? num = null;
		Stack<IList> stack = new Stack<IList>();
		stack.Push(1);
		IList list = 1;
		bool flag = false;
		for (;;)
		{
			int depth = 2.GetDepth();
			216 tokenType;
			if (stack.Count == arrayRank)
			{
				try
				{
					if (2.Method2845(6, 7 != null))
					{
						tokenType = 2.GetTokenType();
						if (tokenType != 216.Comment)
						{
							if (tokenType == 216.EndArray)
							{
								stack.Pop();
								list = stack.Peek();
								num = null;
							}
							else
							{
								object value = (7 == null || !7.CanRead) ? this.Method11651(2, 3.GetCollectionItemType(), 6, null, 3, 4, null) : this.Method11680(7, 2, 3.GetCollectionItemType(), null);
								list.Add(value);
							}
						}
						goto IL_204;
					}
					goto IL_20B;
				}
				catch (Exception ex)
				{
					137 8 = 2.Method2806(depth);
					if (base.Method4120(1, 3, 8.number, 2 as 99, 2.Path, ex))
					{
						this.Method11690(2, true, depth + 1);
						if (num != null)
						{
							int? num2 = num;
							int number = 8.number;
							if (num2.GetValueOrDefault() == number & num2 != null)
							{
								throw 364.Method1687(2, "Infinite loop detected from error handling.", ex);
							}
						}
						num = new int?(8.number);
						goto IL_204;
					}
					throw;
				}
				goto IL_177;
			}
			goto IL_177;
			IL_204:
			if (flag)
			{
				goto IL_20B;
			}
			continue;
			IL_177:
			if (!2.Read())
			{
				goto IL_20B;
			}
			tokenType = 2.GetTokenType();
			if (tokenType == 216.StartArray)
			{
				IList list2 = new List<object>();
				list.Add(list2);
				stack.Push(list2);
				list = list2;
				goto IL_204;
			}
			if (tokenType == 216.Comment)
			{
				goto IL_204;
			}
			if (tokenType != 216.EndArray)
			{
				break;
			}
			stack.Pop();
			if (stack.Count > 0)
			{
				list = stack.Peek();
				goto IL_204;
			}
			flag = true;
			goto IL_204;
		}
		throw 364.Method1687(2, "Unexpected token when deserializing multidimensional array: " + 2.GetTokenType().ToString());
		IL_20B:
		if (!flag)
		{
			this.Method11674(2, 3, 1, "Unexpected end when deserializing array.");
		}
		this.Method11671(2, 3, 1);
		return 1;
	}

	// Token: 0x06000923 RID: 2339 RVA: 0x00020A7C File Offset: 0x0001EC7C
	private void Method11674(139 1, 902 2, [241(2)] object 3, string 4)
	{
		try
		{
			throw 364.Method1687(1, 4);
		}
		catch (Exception 5)
		{
			if (!base.Method4120(3, 2, null, 1 as 99, 1.Path, 5))
			{
				throw;
			}
			this.Method11690(1, false, 0);
		}
	}

	// Token: 0x06000924 RID: 2340 RVA: 0x00020AC8 File Offset: 0x0001ECC8
	private object Method11675(IList 1, 139 2, 126 3, [241(2)] 666 4, [241(2)] string 5)
	{
		450 6 = 1 as 450;
		object obj = (6 != null) ? 6.Value8359 : 1;
		if (5 != null)
		{
			this.Method11665(2, 5, obj);
		}
		if (1.IsFixedSize)
		{
			2.Skip();
			return obj;
		}
		this.Method11670(2, 3, obj);
		int depth = 2.GetDepth();
		if (3.GetItemContract() == null)
		{
			3.SetItemContract(this.Method11645(3.GetCollectionItemType()));
		}
		214 7 = this.Method11654(3.GetItemContract(), null, 3, 4);
		int? num = null;
		bool flag = false;
		do
		{
			try
			{
				if (!2.Method2845(3.GetItemContract(), 7 != null))
				{
					break;
				}
				216 tokenType = 2.GetTokenType();
				if (tokenType != 216.Comment)
				{
					if (tokenType == 216.EndArray)
					{
						flag = true;
					}
					else
					{
						object value = (7 == null || !7.CanRead) ? this.Method11651(2, 3.GetCollectionItemType(), 3.GetItemContract(), null, 3, 4, null) : this.Method11680(7, 2, 3.GetCollectionItemType(), null);
						1.Add(value);
					}
				}
			}
			catch (Exception ex)
			{
				137 8 = 2.Method2806(depth);
				if (!base.Method4120(obj, 3, 8.number, 2 as 99, 2.Path, ex))
				{
					throw;
				}
				this.Method11690(2, true, depth + 1);
				if (num != null)
				{
					int? num2 = num;
					int number = 8.number;
					if (num2.GetValueOrDefault() == number & num2 != null)
					{
						throw 364.Method1687(2, "Infinite loop detected from error handling.", ex);
					}
				}
				num = new int?(8.number);
			}
		}
		while (!flag);
		if (!flag)
		{
			this.Method11674(2, 3, obj, "Unexpected end when deserializing array.");
		}
		this.Method11671(2, 3, obj);
		return obj;
	}

	// Token: 0x06000925 RID: 2341 RVA: 0x00020C7C File Offset: 0x0001EE7C
	private object Method11676(139 1, 515 2, [241(2)] 666 3, [241(2)] string 4)
	{
		Type underlyingType = 2.GetUnderlyingType();
		if (!170.IsFullyTrusted())
		{
			string text = "Type '{0}' implements ISerializable but cannot be deserialized using the ISerializable interface because the current application is not fully trusted and ISerializable can expose secure data." + Environment.NewLine + "To fix this error either change the environment to be fully trusted, change the application to not deserialize the type, add JsonObjectAttribute to the type or change the JsonSerializer setting ContractResolver to use a new DefaultContractResolver with IgnoreSerializableInterface set to true." + Environment.NewLine;
			text = text.Method6825(CultureInfo.InvariantCulture, underlyingType);
			throw 364.Method1687(1, text);
		}
		if (this._recoveredType17753200 != null && this._recoveredType17753200.GetLevelFilter() >= TraceLevel.Info)
		{
			this._recoveredType17753200.WriteTrace(TraceLevel.Info, 137.Method3522(1 as 99, 1.Path, "Deserializing {0} using ISerializable constructor.".Method6825(CultureInfo.InvariantCulture, 2.GetUnderlyingType())), null);
		}
		SerializationInfo serializationInfo = new SerializationInfo(2.GetUnderlyingType(), new 671(this, 2, 3));
		bool flag = false;
		string text2;
		for (;;)
		{
			216 tokenType = 1.GetTokenType();
			if (tokenType != 216.PropertyName)
			{
				if (tokenType != 216.Comment)
				{
					if (tokenType != 216.EndObject)
					{
						break;
					}
					flag = true;
				}
			}
			else
			{
				text2 = 1.GetValue().ToString();
				if (!1.Read())
				{
					goto Block_7;
				}
				serializationInfo.AddValue(text2, 226.ReadFrom(1));
			}
			if (flag || !1.Read())
			{
				goto IL_12F;
			}
		}
		throw 364.Method1687(1, "Unexpected token when deserializing object: " + 1.GetTokenType().ToString());
		Block_7:
		throw 364.Method1687(1, "Unexpected end when setting {0}'s value.".Method6825(CultureInfo.InvariantCulture, text2));
		IL_12F:
		if (!flag)
		{
			this.Method11674(1, 2, serializationInfo, "Unexpected end when deserializing object.");
		}
		if (!2.isInstantiable)
		{
			throw 364.Method1687(1, "Could not create an instance of type {0}. Type is an interface or abstract class and cannot be instantiated.".Method6825(CultureInfo.InvariantCulture, 2.GetUnderlyingType()));
		}
		if (2.RecoveredType10454622 == null)
		{
			throw 364.Method1687(1, "ISerializable type '{0}' does not have a valid constructor. To correctly implement ISerializable a constructor that takes SerializationInfo and StreamingContext parameters should be present.".Method6825(CultureInfo.InvariantCulture, underlyingType));
		}
		object obj = 2.RecoveredType10454622(new object[]
		{
			serializationInfo,
			this.jsonSerializer2.streamingContext2
		});
		if (4 != null)
		{
			this.Method11665(1, 4, obj);
		}
		this.Method11670(1, 2, obj);
		this.Method11671(1, 2, obj);
		return obj;
	}

	// Token: 0x06000926 RID: 2342 RVA: 0x00020E58 File Offset: 0x0001F058
	[return: 241(2)]
	internal object Method11677(226 1, Type 2, 515 3, [241(2)] 666 4)
	{
		902 5 = this.Method11645(2);
		214 6 = this.Method11654(5, null, 3, 4);
		139 7 = 1.CreateReader();
		7.SetMaxDepth(this.jsonSerializer2.Method1805());
		7.Method2843();
		if (6 != null && 6.CanRead)
		{
			return this.Method11680(6, 7, 2, null);
		}
		return this.Method11651(7, 2, 5, null, 3, 4, null);
	}

	// Token: 0x06000927 RID: 2343 RVA: 0x00020EBC File Offset: 0x0001F0BC
	private object Method11678(139 1, 390 2, [241(2)] 666 3, [241(2)] string 4)
	{
		if (!2.isInstantiable)
		{
			throw 364.Method1687(1, "Could not create an instance of type {0}. Type is an interface or abstract class and cannot be instantiated.".Method6825(CultureInfo.InvariantCulture, 2.GetUnderlyingType()));
		}
		if (2.DefaultCreator != null && (!2.GetFlag0798_1378() || this.jsonSerializer2._recoveredType14152965 == (593)1))
		{
			IDynamicMetaObjectProvider dynamicMetaObjectProvider = (IDynamicMetaObjectProvider)2.DefaultCreator();
			if (4 != null)
			{
				this.Method11665(1, 4, dynamicMetaObjectProvider);
			}
			this.Method11670(1, 2, dynamicMetaObjectProvider);
			int depth = 1.GetDepth();
			bool flag = false;
			for (;;)
			{
				216 tokenType = 1.GetTokenType();
				if (tokenType == 216.PropertyName)
				{
					string text = 1.GetValue().ToString();
					try
					{
						if (!1.Read())
						{
							throw 364.Method1687(1, "Unexpected end when setting {0}'s value.".Method6825(CultureInfo.InvariantCulture, text));
						}
						666 5 = 2.GetRecoveredType17661570_2298().Method9819(text);
						if (5 != null && 5.GetFlag7772_9901() && !5.GetFlag7770_9897())
						{
							if (5.GetRecoveredType02517763_9877() == null)
							{
								5.SetRecoveredType02517763_9878(this.Method11645(5.GetType7762_9891()));
							}
							214 6 = this.Method11654(5.GetRecoveredType02517763_9877(), 5.GetJsonConverter7769_9893(), null, null);
							if (!this.Method11663(5, 6, null, 3, 1, dynamicMetaObjectProvider))
							{
								1.Skip();
							}
						}
						else
						{
							Type type = 169.IsPrimitiveToken(1.GetTokenType()) ? 1.GetValueType() : typeof(IDynamicMetaObjectProvider);
							902 7 = this.Method11645(type);
							214 8 = this.Method11654(7, null, null, 3);
							object 9 = (8 == null || !8.CanRead) ? this.Method11651(1, type, 7, null, null, 3, null) : this.Method11680(8, 1, type, null);
							2.Method2302(dynamicMetaObjectProvider, text, 9);
						}
						goto IL_1F5;
					}
					catch (Exception 10)
					{
						if (base.Method4120(dynamicMetaObjectProvider, 2, text, 1 as 99, 1.Path, 10))
						{
							this.Method11690(1, true, depth);
							goto IL_1F5;
						}
						throw;
					}
					goto IL_1CB;
				}
				if (tokenType != 216.EndObject)
				{
					break;
				}
				goto IL_1CB;
				IL_1F5:
				if (flag || !1.Read())
				{
					goto IL_203;
				}
				continue;
				IL_1CB:
				flag = true;
				goto IL_1F5;
			}
			throw 364.Method1687(1, "Unexpected token when deserializing object: " + 1.GetTokenType().ToString());
			IL_203:
			if (!flag)
			{
				this.Method11674(1, 2, dynamicMetaObjectProvider, "Unexpected end when deserializing object.");
			}
			this.Method11671(1, 2, dynamicMetaObjectProvider);
			return dynamicMetaObjectProvider;
		}
		throw 364.Method1687(1, "Unable to find a default constructor to use for type {0}.".Method6825(CultureInfo.InvariantCulture, 2.GetUnderlyingType()));
	}

	// Token: 0x06000928 RID: 2344 RVA: 0x00021120 File Offset: 0x0001F320
	private object Method11679(139 1, 612 2, [241(2)] 666 3, 516<object> 4, [241(2)] string 5)
	{
		756.Method12216(4, "creator");
		bool flag = 2.Method8961() || this.Method11666(this.jsonSerializer2.defaultValueHandling2, (50)2);
		Type underlyingType = 2.GetUnderlyingType();
		if (this._recoveredType17753200 != null && this._recoveredType17753200.GetLevelFilter() >= TraceLevel.Info)
		{
			string 6 = string.Join(", ", from 1 in 2.RecoveredType17666961
			select 1.GetText7760_9879());
			this._recoveredType17753200.WriteTrace(TraceLevel.Info, 137.Method3522(18 as 99, 18.Path, "Deserializing {0} using creator with parameters: {1}.".Method6825(CultureInfo.InvariantCulture, 2.GetUnderlyingType(), 6)), null);
		}
		List<161.165> list = this.Method11681(2, 3, 18, underlyingType);
		if (flag)
		{
			using (IEnumerator<666> enumerator = 2.RecoveredType17666960.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					161.164 7 = new 161.164();
					7._recoveredType17829207 = enumerator.Current;
					if (!7._recoveredType17829207.GetFlag7770_9897() && list.All(new Func<161.165, bool>(7.Method11643)))
					{
						list.Add(new 161.165(7._recoveredType17829207.GetText7760_9879())
						{
							_recoveredType17829209 = 7._recoveredType17829207,
							nullable = new 161.163?((161.163)0)
						});
					}
				}
			}
		}
		object[] array = new object[2.RecoveredType17666961.Count];
		foreach (161.165 8 in list)
		{
			if (flag && 8._recoveredType17829209 != null && 8.nullable == null)
			{
				object value = 8.value;
				161.163 9;
				if (value != null)
				{
					string text = value as string;
					9 = ((text == null) ? ((161.163)2) : (161.Method11652(8._recoveredType17829209.GetType7762_9891(), 8._recoveredType17829209.GetRecoveredType02517763_9877(), text) ? ((161.163)1) : ((161.163)2)));
				}
				else
				{
					9 = (161.163)1;
				}
				161.163 value2 = 9;
				8.nullable = new 161.163?(value2);
			}
			666 10 = 8._recoveredType17829210;
			if (10 == null && 8._recoveredType17829209 != null)
			{
				10 = 2.RecoveredType17666961.Method6833(new Func<666, string>(161.162.instance.Method11640), 8._recoveredType17829209.GetText7766_9885());
			}
			if (10 != null && !10.GetFlag7770_9897())
			{
				if (flag)
				{
					161.163? nullable = 8.nullable;
					161.163 11 = (161.163)0;
					if ((nullable.GetValueOrDefault() == 11 & nullable != null) || 8.nullable.GetValueOrDefault() == (161.163)1)
					{
						if (10.GetRecoveredType02517763_9877() == null)
						{
							10.SetRecoveredType02517763_9878(this.Method11645(10.GetType7762_9891()));
						}
						if (this.Method11666(10.GetNullable7776_9915().GetValueOrDefault(this.jsonSerializer2.defaultValueHandling2), (50)2))
						{
							8.value = this.Method11662(18, 10.Method9907(), CultureInfo.InvariantCulture, 10.GetRecoveredType02517763_9877(), 10.GetType7762_9891());
						}
					}
				}
				int num = 2.RecoveredType17666961.IndexOf(10);
				array[num] = 8.value;
				8.flag = true;
			}
		}
		object obj = 4(array);
		if (5 != null)
		{
			this.Method11665(18, 5, obj);
		}
		this.Method11670(18, 2, obj);
		foreach (161.165 12 in list)
		{
			if (!12.flag && 12._recoveredType17829209 != null && !12._recoveredType17829209.GetFlag7770_9897())
			{
				161.163? nullable = 12.nullable;
				161.163 11 = (161.163)0;
				if (!(nullable.GetValueOrDefault() == 11 & nullable != null))
				{
					666 recoveredType = 12._recoveredType17829209;
					object value3 = 12.value;
					if (this.Method11667(recoveredType, 2, value3))
					{
						recoveredType.GetRecoveredType13467767_9887().Method8004(obj, value3);
						12.flag = true;
					}
					else if (!recoveredType.GetFlag7772_9901() && value3 != null)
					{
						902 13 = this.jsonSerializer2._recoveredType21142968.ResolveContract(recoveredType.GetType7762_9891());
						if (13._recoveredType17440783 != (659)2)
						{
							goto IL_4F6;
						}
						126 14 = (126)13;
						if (14.GetCanDeserialize() && !14.flag5)
						{
							object obj2 = recoveredType.GetRecoveredType13467767_9887().Method8005(obj);
							if (obj2 != null)
							{
								14 = (126)this.Method11646(obj2.GetType());
								object obj3;
								if (!14.GetFlag4646_5831())
								{
									obj3 = (IList)obj2;
								}
								else
								{
									obj3 = 14.CreateWrapper(obj2);
								}
								IList list2 = (IList)obj3;
								if (!list2.IsFixedSize)
								{
									object obj4;
									if (!14.GetFlag4646_5831())
									{
										obj4 = (IList)value3;
									}
									else
									{
										obj4 = 14.CreateWrapper(value3);
									}
									using (IEnumerator enumerator3 = ((IEnumerable)obj4).GetEnumerator())
									{
										while (enumerator3.MoveNext())
										{
											object value4 = enumerator3.Current;
											list2.Add(value4);
										}
										goto IL_5C9;
									}
									goto IL_4F6;
								}
							}
						}
						IL_5C9:
						12.flag = true;
						continue;
						IL_4F6:
						if (13._recoveredType17440783 != (659)5)
						{
							goto IL_5C9;
						}
						493 15 = (493)13;
						if (15.flag5)
						{
							goto IL_5C9;
						}
						object obj5 = recoveredType.GetRecoveredType13467767_9887().Method8005(obj);
						if (obj5 != null)
						{
							object obj6;
							if (!15.GetFlag4184_5369())
							{
								obj6 = (IDictionary)obj5;
							}
							else
							{
								obj6 = 15.Method5373(obj5);
							}
							IDictionary dictionary = (IDictionary)obj6;
							object obj7;
							if (!15.GetFlag4184_5369())
							{
								obj7 = (IDictionary)value3;
							}
							else
							{
								obj7 = 15.Method5373(value3);
							}
							foreach (object obj8 in ((IDictionary)obj7))
							{
								DictionaryEntry dictionaryEntry = (DictionaryEntry)obj8;
								dictionary[dictionaryEntry.Key] = dictionaryEntry.Value;
							}
							goto IL_5C9;
						}
						goto IL_5C9;
					}
				}
			}
		}
		if (2.GetRecoveredType12256951_8955() != null)
		{
			foreach (161.165 16 in list)
			{
				if (!16.flag)
				{
					161.163? nullable = 16.nullable;
					161.163 11 = (161.163)0;
					if (!(nullable.GetValueOrDefault() == 11 & nullable != null))
					{
						2.GetRecoveredType12256951_8955()(obj, 16.text2, 16.value);
					}
				}
			}
		}
		if (flag)
		{
			foreach (161.165 17 in list)
			{
				if (17._recoveredType17829209 != null)
				{
					this.Method11688(obj, 18, 2, 18.GetDepth(), 17._recoveredType17829209, 17.nullable.GetValueOrDefault(), !17.flag);
				}
			}
		}
		this.Method11671(18, 2, obj);
		return obj;
	}

	// Token: 0x06000929 RID: 2345 RVA: 0x000218B0 File Offset: 0x0001FAB0
	[return: 241(2)]
	private object Method11680(214 1, 139 2, Type 3, [241(2)] object 4)
	{
		if (this._recoveredType17753200 != null && this._recoveredType17753200.GetLevelFilter() >= TraceLevel.Info)
		{
			this._recoveredType17753200.WriteTrace(TraceLevel.Info, 137.Method3522(2 as 99, 2.Path, "Started deserializing {0} with converter {1}.".Method6825(CultureInfo.InvariantCulture, 3, 1.GetType())), null);
		}
		object result = 1.ReadJson(2, 3, 4, this.Method11648());
		if (this._recoveredType17753200 != null && this._recoveredType17753200.GetLevelFilter() >= TraceLevel.Info)
		{
			this._recoveredType17753200.WriteTrace(TraceLevel.Info, 137.Method3522(2 as 99, 2.Path, "Finished deserializing {0} with converter {1}.".Method6825(CultureInfo.InvariantCulture, 3, 1.GetType())), null);
		}
		return result;
	}

	// Token: 0x0600092A RID: 2346 RVA: 0x00021964 File Offset: 0x0001FB64
	private List<161.165> Method11681(612 1, [241(2)] 666 2, 139 3, Type 4)
	{
		List<161.165> list = new List<161.165>();
		bool flag = false;
		string text;
		for (;;)
		{
			216 tokenType = 3.GetTokenType();
			if (tokenType != 216.PropertyName)
			{
				if (tokenType != 216.Comment)
				{
					if (tokenType != 216.EndObject)
					{
						break;
					}
					flag = true;
				}
			}
			else
			{
				text = 3.GetValue().ToString();
				161.165 5 = new 161.165(text)
				{
					_recoveredType17829210 = 1.RecoveredType17666961.Method9819(text),
					_recoveredType17829209 = 1.RecoveredType17666960.Method9819(text)
				};
				list.Add(5);
				666 6 = 5._recoveredType17829210 ?? 5._recoveredType17829209;
				if (6 != null)
				{
					if (!6.GetFlag7770_9897())
					{
						if (6.GetRecoveredType02517763_9877() == null)
						{
							6.SetRecoveredType02517763_9878(this.Method11645(6.GetType7762_9891()));
						}
						214 7 = this.Method11654(6.GetRecoveredType02517763_9877(), 6.GetJsonConverter7769_9893(), 1, 2);
						if (!3.Method2845(6.GetRecoveredType02517763_9877(), 7 != null))
						{
							goto Block_8;
						}
						if (7 != null && 7.CanRead)
						{
							5.value = this.Method11680(7, 3, 6.GetType7762_9891(), null);
							goto IL_25B;
						}
						5.value = this.Method11651(3, 6.GetType7762_9891(), 6.GetRecoveredType02517763_9877(), 6, 1, 2, null);
						goto IL_25B;
					}
					else if (!3.Read())
					{
						goto Block_11;
					}
				}
				else
				{
					if (!3.Read())
					{
						goto Block_12;
					}
					if (this._recoveredType17753200 != null && this._recoveredType17753200.GetLevelFilter() >= TraceLevel.Verbose)
					{
						this._recoveredType17753200.WriteTrace(TraceLevel.Verbose, 137.Method3522(3 as 99, 3.Path, "Could not find member '{0}' on {1}.".Method6825(CultureInfo.InvariantCulture, text, 1.GetUnderlyingType())), null);
					}
					if ((1.GetNullable6947_8949() ?? this.jsonSerializer2._recoveredType09352961) == (492)1)
					{
						goto Block_16;
					}
				}
				if (1.GetRecoveredType12256951_8955() != null)
				{
					5.value = this.Method11687(1, 2, 3);
				}
				else
				{
					3.Skip();
				}
			}
			IL_25B:
			if (flag || !3.Read())
			{
				goto IL_269;
			}
		}
		throw 364.Method1687(3, "Unexpected token when deserializing object: " + 3.GetTokenType().ToString());
		Block_8:
		throw 364.Method1687(3, "Unexpected end when setting {0}'s value.".Method6825(CultureInfo.InvariantCulture, text));
		Block_11:
		throw 364.Method1687(3, "Unexpected end when setting {0}'s value.".Method6825(CultureInfo.InvariantCulture, text));
		Block_12:
		throw 364.Method1687(3, "Unexpected end when setting {0}'s value.".Method6825(CultureInfo.InvariantCulture, text));
		Block_16:
		throw 364.Method1687(3, "Could not find member '{0}' on object of type '{1}'".Method6825(CultureInfo.InvariantCulture, text, 4.Name));
		IL_269:
		if (!flag)
		{
			this.Method11674(3, 1, null, "Unexpected end when deserializing object.");
		}
		return list;
	}

	// Token: 0x0600092B RID: 2347 RVA: 0x00021BEC File Offset: 0x0001FDEC
	public object Method11682(139 1, 612 2, [241(2)] 666 3, [241(2)] 666 4, [241(2)] string 5, out bool 6)
	{
		object obj = null;
		if (2.RecoveredType10456962 != null)
		{
			if (2.RecoveredType17666961.Count > 0)
			{
				6 = true;
				return this.Method11679(1, 2, 3, 2.RecoveredType10456962, 5);
			}
			obj = 2.RecoveredType10456962(418.GetItemArray2540_3182<object>());
		}
		else if (2.DefaultCreator != null && (!2.GetFlag0798_1378() || this.jsonSerializer2._recoveredType14152965 == (593)1 || 2.RecoveredType10456963 == null))
		{
			obj = 2.DefaultCreator();
		}
		else if (2.RecoveredType10456963 != null)
		{
			6 = true;
			return this.Method11679(1, 2, 3, 2.RecoveredType10456963, 5);
		}
		if (obj != null)
		{
			6 = false;
			return obj;
		}
		if (!2.isInstantiable)
		{
			throw 364.Method1687(1, "Could not create an instance of type {0}. Type is an interface or abstract class and cannot be instantiated.".Method6825(CultureInfo.InvariantCulture, 2.GetUnderlyingType()));
		}
		throw 364.Method1687(1, "Unable to find a constructor to use for type {0}. A class should either have a default constructor, one constructor with arguments or a constructor marked with the JsonConstructor attribute.".Method6825(CultureInfo.InvariantCulture, 2.GetUnderlyingType()));
	}

	// Token: 0x0600092C RID: 2348 RVA: 0x00021CD4 File Offset: 0x0001FED4
	private object Method11683(object 1, 139 2, 612 3, [241(2)] 666 4, [241(2)] string 5)
	{
		this.Method11670(2, 3, 1);
		Dictionary<666, 161.163> dictionary = (3.Method8961() || this.Method11666(this.jsonSerializer2.defaultValueHandling2, (50)2)) ? 3.RecoveredType17666960.ToDictionary(new Func<666, 666>(161.162.instance.Method11641), new Func<666, 161.163>(161.162.instance.Method11642)) : null;
		if (5 != null)
		{
			this.Method11665(2, 5, 1);
		}
		int depth = 2.GetDepth();
		bool flag = false;
		for (;;)
		{
			216 tokenType = 2.GetTokenType();
			if (tokenType != 216.PropertyName)
			{
				if (tokenType != 216.Comment)
				{
					if (tokenType != 216.EndObject)
					{
						break;
					}
					goto IL_25A;
				}
			}
			else
			{
				string text = 2.GetValue().ToString();
				if (!this.Method11685(2, text))
				{
					try
					{
						666 6 = 3.RecoveredType17666960.Method9819(text);
						if (6 == null)
						{
							if (this._recoveredType17753200 != null && this._recoveredType17753200.GetLevelFilter() >= TraceLevel.Verbose)
							{
								this._recoveredType17753200.WriteTrace(TraceLevel.Verbose, 137.Method3522(2 as 99, 2.Path, "Could not find member '{0}' on {1}".Method6825(CultureInfo.InvariantCulture, text, 3.GetUnderlyingType())), null);
							}
							if ((3.GetNullable6947_8949() ?? this.jsonSerializer2._recoveredType09352961) == (492)1)
							{
								throw 364.Method1687(2, "Could not find member '{0}' on object of type '{1}'".Method6825(CultureInfo.InvariantCulture, text, 3.GetUnderlyingType().Name));
							}
							if (2.Read())
							{
								this.Method11686(3, 4, 2, text, 1);
							}
							goto IL_284;
						}
						else
						{
							if (6.GetFlag7770_9897() || !this.Method11684(2, 6, 1))
							{
								if (2.Read())
								{
									this.Method11689(2, 6, dictionary);
									this.Method11686(3, 4, 2, text, 1);
								}
								goto IL_284;
							}
							if (6.GetRecoveredType02517763_9877() == null)
							{
								6.SetRecoveredType02517763_9878(this.Method11645(6.GetType7762_9891()));
							}
							214 7 = this.Method11654(6.GetRecoveredType02517763_9877(), 6.GetJsonConverter7769_9893(), 3, 4);
							if (!2.Method2845(6.GetRecoveredType02517763_9877(), 7 != null))
							{
								throw 364.Method1687(2, "Unexpected end when setting {0}'s value.".Method6825(CultureInfo.InvariantCulture, text));
							}
							this.Method11689(2, 6, dictionary);
							if (!this.Method11663(6, 7, 3, 4, 2, 1))
							{
								this.Method11686(3, 4, 2, text, 1);
							}
							goto IL_284;
						}
					}
					catch (Exception 8)
					{
						if (base.Method4120(1, 3, text, 2 as 99, 2.Path, 8))
						{
							this.Method11690(2, true, depth);
							goto IL_284;
						}
						throw;
					}
					goto IL_25A;
				}
			}
			IL_284:
			if (flag || !2.Read())
			{
				goto IL_292;
			}
			continue;
			IL_25A:
			flag = true;
			goto IL_284;
		}
		throw 364.Method1687(2, "Unexpected token when deserializing object: " + 2.GetTokenType().ToString());
		IL_292:
		if (!flag)
		{
			this.Method11674(2, 3, 1, "Unexpected end when deserializing object.");
		}
		if (dictionary != null)
		{
			foreach (KeyValuePair<666, 161.163> keyValuePair in dictionary)
			{
				666 key = keyValuePair.Key;
				161.163 value = keyValuePair.Value;
				this.Method11688(1, 2, 3, depth, key, value, true);
			}
		}
		this.Method11671(2, 3, 1);
		return 1;
	}

	// Token: 0x0600092D RID: 2349 RVA: 0x00022014 File Offset: 0x00020214
	private bool Method11684(139 1, 666 2, object 3)
	{
		if (2.Predicate7789 == null)
		{
			return true;
		}
		bool flag = 2.Predicate7789(3);
		if (this._recoveredType17753200 != null && this._recoveredType17753200.GetLevelFilter() >= TraceLevel.Verbose)
		{
			this._recoveredType17753200.WriteTrace(TraceLevel.Verbose, 137.Method3522(null, 1.Path, "ShouldDeserialize result for property '{0}' on {1}: {2}".Method6825(CultureInfo.InvariantCulture, 2.GetText7760_9879(), 2.GetType7764_9881(), flag)), null);
		}
		return flag;
	}

	// Token: 0x0600092E RID: 2350 RVA: 0x0002208C File Offset: 0x0002028C
	private bool Method11685(139 1, string 2)
	{
		if (this.jsonSerializer2.Method1773() == (504)1 && (2 == "$id" || 2 == "$ref" || 2 == "$type" || 2 == "$values"))
		{
			1.Skip();
			return true;
		}
		return false;
	}

	// Token: 0x0600092F RID: 2351 RVA: 0x000220E4 File Offset: 0x000202E4
	private void Method11686(612 1, [241(2)] 666 2, 139 3, string 4, object 5)
	{
		if (1.GetRecoveredType12256951_8955() != null)
		{
			try
			{
				object 6 = this.Method11687(1, 2, 3);
				1.GetRecoveredType12256951_8955()(5, 4, 6);
				return;
			}
			catch (Exception 7)
			{
				throw 364.Method1687(3, "Error setting value in extension data for type '{0}'.".Method6825(CultureInfo.InvariantCulture, 1.GetUnderlyingType()), 7);
			}
		}
		3.Skip();
	}

	// Token: 0x06000930 RID: 2352 RVA: 0x0002214C File Offset: 0x0002034C
	[return: 241(2)]
	private object Method11687(612 1, [241(2)] 666 2, 139 3)
	{
		if (1.flag)
		{
			return 226.ReadFrom(3);
		}
		return this.Method11651(3, null, null, null, 1, 2, null);
	}

	// Token: 0x06000931 RID: 2353 RVA: 0x0002216C File Offset: 0x0002036C
	private void Method11688(object 1, 139 2, 612 3, int 4, 666 5, 161.163 6, bool 7)
	{
		if (6 != (161.163)0 && 6 != (161.163)1)
		{
			return;
		}
		try
		{
			896 8 = (!5.GetFlag7770_9897()) ? (5.nullable2 ?? 3.GetNullable6948_8951().GetValueOrDefault()) : ((896)0);
			if (6 != (161.163)0)
			{
				if (6 == (161.163)1)
				{
					if (8 == (896)2)
					{
						throw 364.Method1687(2, "Required property '{0}' expects a value but got null.".Method6825(CultureInfo.InvariantCulture, 5.GetText7760_9879()));
					}
					if (8 == (896)3)
					{
						throw 364.Method1687(2, "Required property '{0}' expects a non-null value.".Method6825(CultureInfo.InvariantCulture, 5.GetText7760_9879()));
					}
				}
			}
			else
			{
				if (8 == (896)1 || 8 == (896)2)
				{
					throw 364.Method1687(2, "Required property '{0}' not found in JSON.".Method6825(CultureInfo.InvariantCulture, 5.GetText7760_9879()));
				}
				if (7 && !5.GetFlag7770_9897())
				{
					if (5.GetRecoveredType02517763_9877() == null)
					{
						5.SetRecoveredType02517763_9878(this.Method11645(5.GetType7762_9891()));
					}
					if (this.Method11666(5.GetNullable7776_9915().GetValueOrDefault(this.jsonSerializer2.defaultValueHandling2), (50)2) && 5.GetFlag7772_9901())
					{
						5.GetRecoveredType13467767_9887().Method8004(1, this.Method11662(2, 5.Method9907(), CultureInfo.InvariantCulture, 5.GetRecoveredType02517763_9877(), 5.GetType7762_9891()));
					}
				}
			}
		}
		catch (Exception 9)
		{
			if (!base.Method4120(1, 3, 5.GetText7760_9879(), 2 as 99, 2.Path, 9))
			{
				throw;
			}
			this.Method11690(2, true, 4);
		}
	}

	// Token: 0x06000932 RID: 2354 RVA: 0x0002230C File Offset: 0x0002050C
	private void Method11689(139 1, 666 2, [241(new byte[]
	{
		2,
		1
	})] Dictionary<666, 161.163> 3)
	{
		if (2 != null && 3 != null)
		{
			216 tokenType = 1.GetTokenType();
			161.163 value;
			if (tokenType != 216.String)
			{
				if (tokenType - 216.Null > 1)
				{
					value = (161.163)2;
				}
				else
				{
					value = (161.163)1;
				}
			}
			else
			{
				value = (161.Method11652(2.GetType7762_9891(), 2.GetRecoveredType02517763_9877(), (string)1.GetValue()) ? ((161.163)1) : ((161.163)2));
			}
			3[2] = value;
		}
	}

	// Token: 0x06000933 RID: 2355 RVA: 0x00022367 File Offset: 0x00020567
	private void Method11690(139 1, bool 2, int 3)
	{
		base.Method4119();
		if (2)
		{
			1.Skip();
			while (1.GetDepth() > 3 && 1.Read())
			{
			}
		}
	}

	// Token: 0x02000106 RID: 262
	[Serializable]
	public sealed class 162
	{
		// Token: 0x06000934 RID: 2356 RVA: 0x00022389 File Offset: 0x00020589
		[242(0)]
		internal string Method11639(666 1)
		{
			return 1.GetText7760_9879();
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x00022389 File Offset: 0x00020589
		[242(0)]
		[return: 241(1)]
		internal string Method11640(666 1)
		{
			return 1.GetText7760_9879();
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x00022391 File Offset: 0x00020591
		[242(0)]
		internal 666 Method11641(666 1)
		{
			return 1;
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x0000FF75 File Offset: 0x0000E175
		[242(0)]
		internal 161.163 Method11642(666 1)
		{
			return (161.163)0;
		}

		// Token: 0x040004ED RID: 1261
		[241(0)]
		public static readonly 161.162 instance = new 161.162();

		// Token: 0x040004EE RID: 1262
		[241(0)]
		public static Func<666, string> func;

		// Token: 0x040004EF RID: 1263
		[241(new byte[]
		{
			0,
			0,
			1
		})]
		public static Func<666, string> func2;

		// Token: 0x040004F0 RID: 1264
		[241(0)]
		public static Func<666, 666> func3;

		// Token: 0x040004F1 RID: 1265
		[241(0)]
		public static Func<666, 161.163> func4;
	}

	// Token: 0x02000107 RID: 263
	[242(0)]
	public enum 163
	{

	}

	// Token: 0x02000108 RID: 264
	public sealed class 164
	{
		// Token: 0x0600093A RID: 2362 RVA: 0x000223A0 File Offset: 0x000205A0
		[242(0)]
		internal bool Method11643(161.165 1)
		{
			return 1._recoveredType17829209 != this._recoveredType17829207;
		}

		// Token: 0x040004F3 RID: 1267
		[241(0)]
		public 666 _recoveredType17829207;
	}

	// Token: 0x02000109 RID: 265
	[242(2)]
	[241(0)]
	public sealed class 165
	{
		// Token: 0x0600093C RID: 2364 RVA: 0x000223B3 File Offset: 0x000205B3
		[242(1)]
		public 165(string 1)
		{
			this.text2 = 1;
		}

		// Token: 0x040004F4 RID: 1268
		[241(1)]
		public readonly string text2;

		// Token: 0x040004F5 RID: 1269
		public 666 _recoveredType17829209;

		// Token: 0x040004F6 RID: 1270
		public 666 _recoveredType17829210;

		// Token: 0x040004F7 RID: 1271
		public 161.163? nullable;

		// Token: 0x040004F8 RID: 1272
		public object value;

		// Token: 0x040004F9 RID: 1273
		public bool flag;
	}
}
