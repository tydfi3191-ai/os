using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Security;

// Token: 0x0200010B RID: 267
[241(0)]
[242(1)]
public sealed class 166 : 159
{
	// Token: 0x06000940 RID: 2368 RVA: 0x000223CE File Offset: 0x000205CE
	public 166(158 1) : base(1)
	{
	}

	// Token: 0x06000941 RID: 2369 RVA: 0x000223E4 File Offset: 0x000205E4
	[242(2)]
	public void Method12834([241(1)] 173 1, object 2, Type 3)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("jsonWriter");
		}
		this.type3 = 3;
		this.number2 = this.list.Count + 1;
		902 4 = this.Method12836(2);
		try
		{
			if (this.Method12841(2, null, 4, null, null))
			{
				this.Method12844(1, 2);
			}
			else
			{
				this.Method12839(1, 2, 4, null, null, null);
			}
		}
		catch (Exception 5)
		{
			if (!base.Method4120(null, 4, null, null, 1.GetPath(), 5))
			{
				base.Method4119();
				throw;
			}
			this.Method12870(1, 0);
		}
		finally
		{
			this.type3 = null;
		}
	}

	// Token: 0x06000942 RID: 2370 RVA: 0x00022490 File Offset: 0x00020690
	private 366 Method12835()
	{
		if (this._recoveredType03193201 == null)
		{
			this._recoveredType03193201 = new 366(this);
		}
		return this._recoveredType03193201;
	}

	// Token: 0x06000943 RID: 2371 RVA: 0x000224AC File Offset: 0x000206AC
	[242(2)]
	private 902 Method12836(object 1)
	{
		if (1 == null)
		{
			return null;
		}
		return this.Method12837(1);
	}

	// Token: 0x06000944 RID: 2372 RVA: 0x000224BA File Offset: 0x000206BA
	private 902 Method12837(object 1)
	{
		return this.jsonSerializer2._recoveredType21142968.ResolveContract(1.GetType());
	}

	// Token: 0x06000945 RID: 2373 RVA: 0x000224D4 File Offset: 0x000206D4
	private void Method12838(173 1, object 2, 806 3, [241(2)] 666 4, [241(2)] 130 5, [241(2)] 666 6)
	{
		if (3.GetRecoveredType206110432_13502() == 723.Bytes && this.Method12867((933)1, 3, 4, 5, 6))
		{
			1.WriteStartObject();
			this.Method12855(1, 3.GetCreatedType());
			1.WritePropertyName("$value", false);
			173.WriteValue(1, 3.GetRecoveredType206110432_13502(), 2);
			1.WriteEndObject();
			return;
		}
		173.WriteValue(1, 3.GetRecoveredType206110432_13502(), 2);
	}

	// Token: 0x06000946 RID: 2374 RVA: 0x0002253C File Offset: 0x0002073C
	[242(2)]
	private void Method12839([241(1)] 173 1, object 2, 902 3, 666 4, 130 5, 666 6)
	{
		if (2 == null)
		{
			1.WriteNull();
			return;
		}
		214 7;
		if ((7 = ((4 != null) ? 4.GetJsonConverter7769_9893() : null)) == null && (7 = ((6 != null) ? 6.GetJsonConverter7784_9923() : null)) == null && (7 = ((5 != null) ? 5.GetItemConverter() : null)) == null && (7 = 3.Converter) == null)
		{
			7 = (this.jsonSerializer2.Method3855(3.GetUnderlyingType()) ?? 3.InternalConverter);
		}
		214 8 = 7;
		if (8 != null && 8.CanWrite)
		{
			this.Method12859(1, 8, 2, 3, 5, 6);
			return;
		}
		switch (3._recoveredType17440783)
		{
		case (659)1:
			this.Method12850(1, 2, (612)3, 4, 5, 6);
			return;
		case (659)2:
		{
			126 9 = (126)3;
			if (!9.GetIsMultidimensionalArray())
			{
				this.Method12860(1, (IEnumerable)2, 9, 4, 5, 6);
				return;
			}
			this.Method12861(1, (Array)2, 9, 4, 5, 6);
			return;
		}
		case (659)3:
			this.Method12838(1, 2, (806)3, 4, 5, 6);
			return;
		case (659)4:
			this.Method12847(1, 2, (809)3);
			return;
		case (659)5:
		{
			493 10 = (493)3;
			IDictionary dictionary = 2 as IDictionary;
			IDictionary 11;
			if (dictionary == null)
			{
				11 = 10.Method5373(2);
			}
			else
			{
				11 = dictionary;
			}
			this.Method12868(1, 11, 10, 4, 5, 6);
			return;
		}
		case (659)6:
			this.Method12865(1, (IDynamicMetaObjectProvider)2, (390)3, 4, 5, 6);
			return;
		case (659)7:
			this.Method12864(1, (ISerializable)2, (515)3, 4, 5, 6);
			return;
		case (659)8:
			((226)2).WriteTo(1, this.jsonSerializer2.Method1756().ToArray<214>());
			return;
		default:
			return;
		}
	}

	// Token: 0x06000947 RID: 2375 RVA: 0x000226F0 File Offset: 0x000208F0
	[242(2)]
	private bool? Method12840([241(1)] 902 1, 666 2, 130 3, 666 4)
	{
		bool? result = null;
		if (2 != null)
		{
			result = 2.GetNullable7774_9911();
		}
		if (result == null && 4 != null)
		{
			result = 4.GetNullable7785_9925();
		}
		if (result == null && 3 != null)
		{
			result = 3.GetItemIsReference();
		}
		if (result == null)
		{
			result = 1.GetIsReference();
		}
		return result;
	}

	// Token: 0x06000948 RID: 2376 RVA: 0x00022748 File Offset: 0x00020948
	[242(2)]
	private bool Method12841(object 1, 666 2, 902 3, 130 4, 666 5)
	{
		if (1 == null)
		{
			return false;
		}
		if (3._recoveredType17440783 == (659)3 || 3._recoveredType17440783 == (659)4)
		{
			return false;
		}
		bool? flag = this.Method12840(3, 2, 4, 5);
		if (flag == null)
		{
			flag = ((3._recoveredType17440783 != (659)2) ? new bool?(this.Method12856(this.jsonSerializer2._recoveredType13962959, (586)1)) : new bool?(this.Method12856(this.jsonSerializer2._recoveredType13962959, (586)2)));
		}
		return flag.GetValueOrDefault() && this.jsonSerializer2.Method3854().Method11695(this, 1);
	}

	// Token: 0x06000949 RID: 2377 RVA: 0x000227DC File Offset: 0x000209DC
	[242(2)]
	private bool Method12842(object 1, 612 2, [241(1)] 666 3)
	{
		return (1 != null || base.Method4117(2, 3) != (240)1) && (!this.Method12856(3.GetNullable7776_9915().GetValueOrDefault(this.jsonSerializer2.defaultValueHandling2), (50)1) || !736.Method11628(1, 3.Method9907()));
	}

	// Token: 0x0600094A RID: 2378 RVA: 0x0002282C File Offset: 0x00020A2C
	[242(2)]
	private bool Method12843([241(1)] 173 1, object 2, 666 3, 902 4, 130 5, 666 6)
	{
		if (2 == null)
		{
			return true;
		}
		if (4._recoveredType17440783 == (659)3 || 4._recoveredType17440783 == (659)4)
		{
			return true;
		}
		894? 7 = null;
		if (3 != null)
		{
			7 = 3.GetNullable7777_9917();
		}
		if (7 == null && 6 != null)
		{
			7 = 6.GetNullable7787_9929();
		}
		if (7 == null && 5 != null)
		{
			7 = 5.GetItemReferenceLoopHandling();
		}
		if ((this.jsonSerializer2.iEqualityComparer != null) ? this.list.Method3175(2, this.jsonSerializer2.iEqualityComparer) : this.list.Contains(2))
		{
			string text = "Self referencing loop detected";
			if (3 != null)
			{
				text += " for property '{0}'".Method6825(CultureInfo.InvariantCulture, 3.GetText7760_9879());
			}
			text += " with type '{0}'.".Method6825(CultureInfo.InvariantCulture, 2.GetType());
			switch (7.GetValueOrDefault(this.jsonSerializer2.referenceLoopHandling2))
			{
			case (894)0:
				throw 364.Method1687(null, 1.GetContainerPath(), text, null);
			case (894)1:
				if (this._recoveredType17753200 != null && this._recoveredType17753200.GetLevelFilter() >= TraceLevel.Verbose)
				{
					this._recoveredType17753200.WriteTrace(TraceLevel.Verbose, 137.Method3522(null, 1.GetPath(), text + ". Skipping serializing self referenced value."), null);
				}
				return false;
			case (894)2:
				if (this._recoveredType17753200 != null && this._recoveredType17753200.GetLevelFilter() >= TraceLevel.Verbose)
				{
					this._recoveredType17753200.WriteTrace(TraceLevel.Verbose, 137.Method3522(null, 1.GetPath(), text + ". Serializing self referenced value."), null);
				}
				return true;
			}
		}
		return true;
	}

	// Token: 0x0600094B RID: 2379 RVA: 0x000229BC File Offset: 0x00020BBC
	private void Method12844(173 1, object 2)
	{
		string text = this.Method12845(1, 2);
		if (this._recoveredType17753200 != null && this._recoveredType17753200.GetLevelFilter() >= TraceLevel.Info)
		{
			this._recoveredType17753200.WriteTrace(TraceLevel.Info, 137.Method3522(null, 1.GetPath(), "Writing object reference to Id '{0}' for {1}.".Method6825(CultureInfo.InvariantCulture, text, 2.GetType())), null);
		}
		1.WriteStartObject();
		1.WritePropertyName("$ref", false);
		1.WriteValue(text);
		1.WriteEndObject();
	}

	// Token: 0x0600094C RID: 2380 RVA: 0x00022A38 File Offset: 0x00020C38
	private string Method12845(173 1, object 2)
	{
		string result;
		try
		{
			result = this.jsonSerializer2.Method3854().Method11693(this, 2);
		}
		catch (Exception 3)
		{
			throw 364.Method1687(null, 1.GetContainerPath(), "Error writing object reference for '{0}'.".Method6825(CultureInfo.InvariantCulture, 2.GetType()), 3);
		}
		return result;
	}

	// Token: 0x0600094D RID: 2381 RVA: 0x00022A90 File Offset: 0x00020C90
	internal static bool Method12846(object 1, Type 2, [241(2)] [239(true)] out string 3)
	{
		TypeConverter typeConverter;
		if (170.CanTypeDescriptorConvertString(2, out typeConverter))
		{
			3 = typeConverter.ConvertToInvariantString(1);
			return true;
		}
		Type type = 1 as Type;
		if (type != null)
		{
			3 = type.AssemblyQualifiedName;
			return true;
		}
		3 = null;
		return false;
	}

	// Token: 0x0600094E RID: 2382 RVA: 0x00022ACC File Offset: 0x00020CCC
	private void Method12847(173 1, object 2, 809 3)
	{
		this.Method12848(1, 3, 2);
		string 4;
		166.Method12846(2, 3.GetUnderlyingType(), out 4);
		1.WriteValue(4);
		this.Method12849(1, 3, 2);
	}

	// Token: 0x0600094F RID: 2383 RVA: 0x00022B04 File Offset: 0x00020D04
	private void Method12848(173 1, 902 2, object 3)
	{
		if (this._recoveredType17753200 != null && this._recoveredType17753200.GetLevelFilter() >= TraceLevel.Info)
		{
			this._recoveredType17753200.WriteTrace(TraceLevel.Info, 137.Method3522(null, 1.GetPath(), "Started serializing {0}".Method6825(CultureInfo.InvariantCulture, 2.GetUnderlyingType())), null);
		}
		2.Method1380(3, this.jsonSerializer2.streamingContext2);
	}

	// Token: 0x06000950 RID: 2384 RVA: 0x00022B68 File Offset: 0x00020D68
	private void Method12849(173 1, 902 2, object 3)
	{
		if (this._recoveredType17753200 != null && this._recoveredType17753200.GetLevelFilter() >= TraceLevel.Info)
		{
			this._recoveredType17753200.WriteTrace(TraceLevel.Info, 137.Method3522(null, 1.GetPath(), "Finished serializing {0}".Method6825(CultureInfo.InvariantCulture, 2.GetUnderlyingType())), null);
		}
		2.Method1381(3, this.jsonSerializer2.streamingContext2);
	}

	// Token: 0x06000951 RID: 2385 RVA: 0x00022BCC File Offset: 0x00020DCC
	private void Method12850(173 1, object 2, 612 3, [241(2)] 666 4, [241(2)] 130 5, [241(2)] 666 6)
	{
		this.Method12848(1, 3, 2);
		this.list.Add(2);
		this.Method12852(1, 2, 3, 4, 5, 6);
		int top = 1.GetTop();
		for (int i = 0; i < 3.RecoveredType17666960.Count; i++)
		{
			666 7 = 3.RecoveredType17666960[i];
			try
			{
				902 8;
				object 9;
				if (this.Method12851(1, 2, 3, 4, 7, out 8, out 9))
				{
					7.Method9931(1);
					this.Method12839(1, 9, 8, 7, 3, 4);
				}
			}
			catch (Exception 10)
			{
				if (!base.Method4120(2, 3, 7.GetText7760_9879(), null, 1.GetContainerPath(), 10))
				{
					throw;
				}
				this.Method12870(1, top);
			}
		}
		531 recoveredType11756952_ = 3.GetRecoveredType11756952_8957();
		IEnumerable<KeyValuePair<object, object>> enumerable = (recoveredType11756952_ != null) ? recoveredType11756952_(2) : null;
		if (enumerable != null)
		{
			foreach (KeyValuePair<object, object> keyValuePair in enumerable)
			{
				902 11 = this.Method12837(keyValuePair.Key);
				902 12 = this.Method12836(keyValuePair.Value);
				bool flag;
				string text = this.Method12869(1, keyValuePair.Key, 11, out flag);
				text = ((3.Func6964 != null) ? 3.Func6964(text) : text);
				if (this.Method12841(keyValuePair.Value, null, 12, 3, 4))
				{
					1.WritePropertyName(text);
					this.Method12844(1, keyValuePair.Value);
				}
				else if (this.Method12843(1, keyValuePair.Value, null, 12, 3, 4))
				{
					1.WritePropertyName(text);
					this.Method12839(1, keyValuePair.Value, 12, null, 3, 4);
				}
			}
		}
		1.WriteEndObject();
		this.list.RemoveAt(this.list.Count - 1);
		this.Method12849(1, 3, 2);
	}

	// Token: 0x06000952 RID: 2386 RVA: 0x00022DB4 File Offset: 0x00020FB4
	private bool Method12851(173 1, object 2, 130 3, [241(2)] 666 4, 666 5, [241(2)] [239(true)] out 902 6, [241(2)] out object 7)
	{
		if (!5.GetFlag7770_9897() && 5.GetFlag7771_9899() && this.Method12871(1, 5, 2) && this.Method12872(1, 5, 2))
		{
			if (5.GetRecoveredType02517763_9877() == null)
			{
				5.SetRecoveredType02517763_9878(this.jsonSerializer2._recoveredType21142968.ResolveContract(5.GetType7762_9891()));
			}
			7 = 5.GetRecoveredType13467767_9887().Method8005(2);
			6 = (5.GetRecoveredType02517763_9877().flag6 ? 5.GetRecoveredType02517763_9877() : this.Method12836(7));
			if (this.Method12842(7, 3 as 612, 5))
			{
				if (this.Method12841(7, 5, 6, 3, 4))
				{
					5.Method9931(1);
					this.Method12844(1, 7);
					return false;
				}
				if (!this.Method12843(1, 7, 5, 6, 3, 4))
				{
					return false;
				}
				if (7 == null)
				{
					612 8 = 3 as 612;
					896 9 = 5.nullable2 ?? ((8 != null) ? 8.GetNullable6948_8951() : null).GetValueOrDefault();
					if (9 == (896)2)
					{
						throw 364.Method1687(null, 1.GetContainerPath(), "Cannot write a null value for property '{0}'. Property requires a value.".Method6825(CultureInfo.InvariantCulture, 5.GetText7760_9879()), null);
					}
					if (9 == (896)3)
					{
						throw 364.Method1687(null, 1.GetContainerPath(), "Cannot write a null value for property '{0}'. Property requires a non-null value.".Method6825(CultureInfo.InvariantCulture, 5.GetText7760_9879()), null);
					}
				}
				return true;
			}
		}
		6 = null;
		7 = null;
		return false;
	}

	// Token: 0x06000953 RID: 2387 RVA: 0x00022F48 File Offset: 0x00021148
	private void Method12852(173 1, object 2, 902 3, [241(2)] 666 4, [241(2)] 130 5, [241(2)] 666 6)
	{
		1.WriteStartObject();
		if ((this.Method12840(3, 4, 5, 6) ?? this.Method12856(this.jsonSerializer2._recoveredType13962959, (586)1)) && (4 == null || 4.GetFlag7772_9901() || this.Method12853(5, 4)))
		{
			this.Method12854(1, 3.GetUnderlyingType(), 2);
		}
		if (this.Method12867((933)1, 3, 4, 5, 6))
		{
			this.Method12855(1, 3.GetUnderlyingType());
		}
	}

	// Token: 0x06000954 RID: 2388 RVA: 0x00022FD4 File Offset: 0x000211D4
	private bool Method12853([241(2)] 130 1, 666 2)
	{
		612 3 = 1 as 612;
		return 3 != null && 3.RecoveredType17666961.Contains(2.GetText7760_9879());
	}

	// Token: 0x06000955 RID: 2389 RVA: 0x00023000 File Offset: 0x00021200
	private void Method12854(173 1, Type 2, object 3)
	{
		string text = this.Method12845(1, 3);
		if (this._recoveredType17753200 != null && this._recoveredType17753200.GetLevelFilter() >= TraceLevel.Verbose)
		{
			this._recoveredType17753200.WriteTrace(TraceLevel.Verbose, 137.Method3522(null, 1.GetPath(), "Writing object reference Id '{0}' for {1}.".Method6825(CultureInfo.InvariantCulture, text, 2)), null);
		}
		1.WritePropertyName("$id", false);
		1.WriteValue(text);
	}

	// Token: 0x06000956 RID: 2390 RVA: 0x0002306C File Offset: 0x0002126C
	private void Method12855(173 1, Type 2)
	{
		string typeName = 143.GetTypeName(2, this.jsonSerializer2._recoveredType19652958, this.jsonSerializer2._recoveredType20112971);
		if (this._recoveredType17753200 != null && this._recoveredType17753200.GetLevelFilter() >= TraceLevel.Verbose)
		{
			this._recoveredType17753200.WriteTrace(TraceLevel.Verbose, 137.Method3522(null, 1.GetPath(), "Writing type name '{0}' for {1}.".Method6825(CultureInfo.InvariantCulture, typeName, 2)), null);
		}
		1.WritePropertyName("$type", false);
		1.WriteValue(typeName);
	}

	// Token: 0x06000957 RID: 2391 RVA: 0x00010382 File Offset: 0x0000E582
	private bool Method12856(50 1, 50 2)
	{
		return (1 & 2) == 2;
	}

	// Token: 0x06000958 RID: 2392 RVA: 0x00010382 File Offset: 0x0000E582
	private bool Method12856(586 1, 586 2)
	{
		return (1 & 2) == 2;
	}

	// Token: 0x06000959 RID: 2393 RVA: 0x00010382 File Offset: 0x0000E582
	private bool Method12856(933 1, 933 2)
	{
		return (1 & 2) == 2;
	}

	// Token: 0x0600095A RID: 2394 RVA: 0x000230EC File Offset: 0x000212EC
	private void Method12859(173 1, 214 2, object 3, 902 4, [241(2)] 130 5, [241(2)] 666 6)
	{
		if (this.Method12841(3, null, 4, 5, 6))
		{
			this.Method12844(1, 3);
			return;
		}
		if (this.Method12843(1, 3, null, 4, 5, 6))
		{
			this.list.Add(3);
			if (this._recoveredType17753200 != null && this._recoveredType17753200.GetLevelFilter() >= TraceLevel.Info)
			{
				this._recoveredType17753200.WriteTrace(TraceLevel.Info, 137.Method3522(null, 1.GetPath(), "Started serializing {0} with converter {1}.".Method6825(CultureInfo.InvariantCulture, 3.GetType(), 2.GetType())), null);
			}
			2.WriteJson(1, 3, this.Method12835());
			if (this._recoveredType17753200 != null && this._recoveredType17753200.GetLevelFilter() >= TraceLevel.Info)
			{
				this._recoveredType17753200.WriteTrace(TraceLevel.Info, 137.Method3522(null, 1.GetPath(), "Finished serializing {0} with converter {1}.".Method6825(CultureInfo.InvariantCulture, 3.GetType(), 2.GetType())), null);
			}
			this.list.RemoveAt(this.list.Count - 1);
		}
	}

	// Token: 0x0600095B RID: 2395 RVA: 0x000231EC File Offset: 0x000213EC
	private void Method12860(173 1, IEnumerable 2, 126 3, [241(2)] 666 4, [241(2)] 130 5, [241(2)] 666 6)
	{
		450 7 = 2 as 450;
		object obj = (7 != null) ? 7.Value8359 : 2;
		this.Method12848(1, 3, obj);
		this.list.Add(obj);
		bool flag = this.Method12863(1, obj, 3, 4, 5, 6);
		1.WriteStartArray();
		int top = 1.GetTop();
		int num = 0;
		foreach (object obj2 in 2)
		{
			try
			{
				902 8 = 3.GetFinalItemContract() ?? this.Method12836(obj2);
				if (this.Method12841(obj2, null, 8, 3, 4))
				{
					this.Method12844(1, obj2);
				}
				else if (this.Method12843(1, obj2, null, 8, 3, 4))
				{
					this.Method12839(1, obj2, 8, null, 3, 4);
				}
			}
			catch (Exception 9)
			{
				if (!base.Method4120(obj, 3, num, null, 1.GetContainerPath(), 9))
				{
					throw;
				}
				this.Method12870(1, top);
			}
			finally
			{
				num++;
			}
		}
		1.WriteEndArray();
		if (flag)
		{
			1.WriteEndObject();
		}
		this.list.RemoveAt(this.list.Count - 1);
		this.Method12849(1, 3, obj);
	}

	// Token: 0x0600095C RID: 2396 RVA: 0x00023354 File Offset: 0x00021554
	private void Method12861(173 1, Array 2, 126 3, [241(2)] 666 4, [241(2)] 130 5, [241(2)] 666 6)
	{
		this.Method12848(1, 3, 2);
		this.list.Add(2);
		bool flag = this.Method12863(1, 2, 3, 4, 5, 6);
		this.Method12861(1, 2, 3, 4, 1.GetTop(), 418.GetItemArray2540_3182<int>());
		if (flag)
		{
			1.WriteEndObject();
		}
		this.list.RemoveAt(this.list.Count - 1);
		this.Method12849(1, 3, 2);
	}

	// Token: 0x0600095D RID: 2397 RVA: 0x000233C4 File Offset: 0x000215C4
	private void Method12861(173 1, Array 2, 126 3, [241(2)] 666 4, int 5, int[] 6)
	{
		int num = 6.Length;
		int[] array = new int[num + 1];
		for (int i = 0; i < num; i++)
		{
			array[i] = 6[i];
		}
		1.WriteStartArray();
		int j = 2.GetLowerBound(num);
		while (j <= 2.GetUpperBound(num))
		{
			array[num] = j;
			if (array.Length == 2.Rank)
			{
				object value = 2.GetValue(array);
				try
				{
					902 7 = 3.GetFinalItemContract() ?? this.Method12836(value);
					if (this.Method12841(value, null, 7, 3, 4))
					{
						this.Method12844(1, value);
					}
					else if (this.Method12843(1, value, null, 7, 3, 4))
					{
						this.Method12839(1, value, 7, null, 3, 4);
					}
					goto IL_DA;
				}
				catch (Exception 8)
				{
					if (base.Method4120(2, 3, j, null, 1.GetContainerPath(), 8))
					{
						this.Method12870(1, 5 + 1);
						goto IL_DA;
					}
					throw;
				}
				goto IL_CA;
			}
			goto IL_CA;
			IL_DA:
			j++;
			continue;
			IL_CA:
			this.Method12861(1, 2, 3, 4, 5 + 1, array);
			goto IL_DA;
		}
		1.WriteEndArray();
	}

	// Token: 0x0600095E RID: 2398 RVA: 0x000234D4 File Offset: 0x000216D4
	private bool Method12863(173 1, object 2, 126 3, [241(2)] 666 4, [241(2)] 130 5, [241(2)] 666 6)
	{
		bool flag = (this.Method12840(3, 4, 5, 6) ?? this.Method12856(this.jsonSerializer2._recoveredType13962959, (586)2)) && (4 == null || 4.GetFlag7772_9901() || this.Method12853(5, 4));
		bool flag2 = this.Method12867((933)2, 3, 4, 5, 6);
		bool flag3 = flag || flag2;
		if (flag3)
		{
			1.WriteStartObject();
			if (flag)
			{
				this.Method12854(1, 3.GetUnderlyingType(), 2);
			}
			if (flag2)
			{
				this.Method12855(1, 2.GetType());
			}
			1.WritePropertyName("$values", false);
		}
		if (3.GetItemContract() == null)
		{
			3.SetItemContract(this.jsonSerializer2._recoveredType21142968.ResolveContract(3.GetCollectionItemType() ?? typeof(object)));
		}
		return flag3;
	}

	// Token: 0x0600095F RID: 2399 RVA: 0x000235B0 File Offset: 0x000217B0
	[SecuritySafeCritical]
	private void Method12864(173 1, ISerializable 2, 515 3, [241(2)] 666 4, [241(2)] 130 5, [241(2)] 666 6)
	{
		if (!170.IsFullyTrusted())
		{
			string text = "Type '{0}' implements ISerializable but cannot be serialized using the ISerializable interface because the current application is not fully trusted and ISerializable can expose secure data." + Environment.NewLine + "To fix this error either change the environment to be fully trusted, change the application to not deserialize the type, add JsonObjectAttribute to the type or change the JsonSerializer setting ContractResolver to use a new DefaultContractResolver with IgnoreSerializableInterface set to true." + Environment.NewLine;
			text = text.Method6825(CultureInfo.InvariantCulture, 2.GetType());
			throw 364.Method1687(null, 1.GetContainerPath(), text, null);
		}
		this.Method12848(1, 3, 2);
		this.list.Add(2);
		this.Method12852(1, 2, 3, 4, 5, 6);
		SerializationInfo serializationInfo = new SerializationInfo(3.GetUnderlyingType(), new FormatterConverter());
		2.GetObjectData(serializationInfo, this.jsonSerializer2.streamingContext2);
		foreach (SerializationEntry serializationEntry in serializationInfo)
		{
			902 7 = this.Method12836(serializationEntry.Value);
			if (this.Method12841(serializationEntry.Value, null, 7, 3, 4))
			{
				1.WritePropertyName(serializationEntry.Name);
				this.Method12844(1, serializationEntry.Value);
			}
			else if (this.Method12843(1, serializationEntry.Value, null, 7, 3, 4))
			{
				1.WritePropertyName(serializationEntry.Name);
				this.Method12839(1, serializationEntry.Value, 7, null, 3, 4);
			}
		}
		1.WriteEndObject();
		this.list.RemoveAt(this.list.Count - 1);
		this.Method12849(1, 3, 2);
	}

	// Token: 0x06000960 RID: 2400 RVA: 0x00023700 File Offset: 0x00021900
	private void Method12865(173 1, IDynamicMetaObjectProvider 2, 390 3, [241(2)] 666 4, [241(2)] 130 5, [241(2)] 666 6)
	{
		this.Method12848(1, 3, 2);
		this.list.Add(2);
		this.Method12852(1, 2, 3, 4, 5, 6);
		int top = 1.GetTop();
		for (int i = 0; i < 3.GetRecoveredType17661570_2298().Count; i++)
		{
			666 7 = 3.GetRecoveredType17661570_2298()[i];
			if (7.GetFlag7773_9903())
			{
				try
				{
					902 8;
					object 9;
					if (this.Method12851(1, 2, 3, 4, 7, out 8, out 9))
					{
						7.Method9931(1);
						this.Method12839(1, 9, 8, 7, 3, 4);
					}
				}
				catch (Exception 10)
				{
					if (!base.Method4120(2, 3, 7.GetText7760_9879(), null, 1.GetContainerPath(), 10))
					{
						throw;
					}
					this.Method12870(1, top);
				}
			}
		}
		foreach (string text in 2.GetDynamicMemberNames())
		{
			object obj;
			if (3.Method2301(2, text, out obj))
			{
				try
				{
					902 11 = this.Method12836(obj);
					if (this.Method12866(obj) && this.Method12843(1, obj, null, 11, 3, 4))
					{
						string 12 = (3.Func1574 != null) ? 3.Func1574(text) : text;
						1.WritePropertyName(12);
						this.Method12839(1, obj, 11, null, 3, 4);
					}
				}
				catch (Exception 13)
				{
					if (!base.Method4120(2, 3, text, null, 1.GetContainerPath(), 13))
					{
						throw;
					}
					this.Method12870(1, top);
				}
			}
		}
		1.WriteEndObject();
		this.list.RemoveAt(this.list.Count - 1);
		this.Method12849(1, 3, 2);
	}

	// Token: 0x06000961 RID: 2401 RVA: 0x000238C4 File Offset: 0x00021AC4
	[242(2)]
	private bool Method12866(object 1)
	{
		return (this.jsonSerializer2.nullValueHandling2 != (240)1 || 1 != null) && (!this.Method12856(this.jsonSerializer2.defaultValueHandling2, (50)1) || (1 != null && !736.Method11628(1, 143.GetDefaultValue(1.GetType()))));
	}

	// Token: 0x06000962 RID: 2402 RVA: 0x00023914 File Offset: 0x00021B14
	[242(2)]
	private bool Method12867(933 1, [241(1)] 902 2, 666 3, 130 4, 666 5)
	{
		933 6 = ((3 != null) ? 3.GetNullable7779_9921() : null) ?? (((5 != null) ? 5.GetNullable7786_9927() : null) ?? (((4 != null) ? 4.GetItemTypeNameHandling() : null) ?? this.jsonSerializer2.typeNameHandling2));
		if (this.Method12856(6, 1))
		{
			return true;
		}
		if (this.Method12856(6, (933)4))
		{
			if (3 != null)
			{
				if (2.nonNullableUnderlyingType != 3.GetRecoveredType02517763_9877().GetCreatedType())
				{
					return true;
				}
			}
			else if (4 != null)
			{
				if (4.GetItemContract() == null || 2.nonNullableUnderlyingType != 4.GetItemContract().GetCreatedType())
				{
					return true;
				}
			}
			else if (this.type3 != null && this.list.Count == this.number2)
			{
				902 7 = this.jsonSerializer2._recoveredType21142968.ResolveContract(this.type3);
				if (2.nonNullableUnderlyingType != 7.GetCreatedType())
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06000963 RID: 2403 RVA: 0x00023A58 File Offset: 0x00021C58
	private void Method12868(173 1, IDictionary 2, 493 3, [241(2)] 666 4, [241(2)] 130 5, [241(2)] 666 6)
	{
		424 7 = 2 as 424;
		object obj = (7 != null) ? 7.Value7881 : 2;
		this.Method12848(1, 3, obj);
		this.list.Add(obj);
		this.Method12852(1, obj, 3, 4, 5, 6);
		if (3.GetItemContract() == null)
		{
			3.SetItemContract(this.jsonSerializer2._recoveredType21142968.ResolveContract(3.GetType4178_5366() ?? typeof(object)));
		}
		if (3.GetRecoveredType02514179_5367() == null)
		{
			3.SetRecoveredType02514179_5368(this.jsonSerializer2._recoveredType21142968.ResolveContract(3.GetType4177_5365() ?? typeof(object)));
		}
		int top = 1.GetTop();
		foreach (object obj2 in 2)
		{
			DictionaryEntry dictionaryEntry = (DictionaryEntry)obj2;
			bool 8;
			string text = this.Method12869(1, dictionaryEntry.Key, 3.GetRecoveredType02514179_5367(), out 8);
			text = ((3.Func4189 != null) ? 3.Func4189(text) : text);
			try
			{
				object value = dictionaryEntry.Value;
				902 9 = 3.GetFinalItemContract() ?? this.Method12836(value);
				if (this.Method12841(value, null, 9, 3, 4))
				{
					1.WritePropertyName(text, 8);
					this.Method12844(1, value);
				}
				else if (this.Method12843(1, value, null, 9, 3, 4))
				{
					1.WritePropertyName(text, 8);
					this.Method12839(1, value, 9, null, 3, 4);
				}
			}
			catch (Exception 10)
			{
				if (!base.Method4120(obj, 3, text, null, 1.GetContainerPath(), 10))
				{
					throw;
				}
				this.Method12870(1, top);
			}
		}
		1.WriteEndObject();
		this.list.RemoveAt(this.list.Count - 1);
		this.Method12849(1, 3, obj);
	}

	// Token: 0x06000964 RID: 2404 RVA: 0x00023C4C File Offset: 0x00021E4C
	private string Method12869(173 1, object 2, 902 3, out bool 4)
	{
		if (3._recoveredType17440783 == (659)3)
		{
			806 5 = (806)3;
			switch (5.GetRecoveredType206110432_13502())
			{
			case 723.Single:
			case 723.SingleNullable:
			{
				float num = (float)2;
				4 = false;
				return num.ToString("R", CultureInfo.InvariantCulture);
			}
			case 723.Double:
			case 723.DoubleNullable:
			{
				double num2 = (double)2;
				4 = false;
				return num2.ToString("R", CultureInfo.InvariantCulture);
			}
			case 723.DateTime:
			case 723.DateTimeNullable:
			{
				DateTime 6 = 382.Method2108((DateTime)2, 1.GetDateTimeZoneHandling());
				4 = false;
				StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture);
				382.Method2131(stringWriter, 6, 1.GetDateFormatHandling(), 1.DateFormatString, 1.GetCulture());
				return stringWriter.ToString();
			}
			case 723.DateTimeOffset:
			case 723.DateTimeOffsetNullable:
			{
				4 = false;
				StringWriter stringWriter2 = new StringWriter(CultureInfo.InvariantCulture);
				382.Method2136(stringWriter2, (DateTimeOffset)2, 1.GetDateFormatHandling(), 1.DateFormatString, 1.GetCulture());
				return stringWriter2.ToString();
			}
			default:
			{
				4 = true;
				string result;
				if (5.flag4 && 83.Method5804(5.nonNullableUnderlyingType, 2, null, out result))
				{
					return result;
				}
				return Convert.ToString(2, CultureInfo.InvariantCulture);
			}
			}
		}
		else
		{
			string result2;
			if (166.Method12846(2, 2.GetType(), out result2))
			{
				4 = true;
				return result2;
			}
			4 = true;
			return 2.ToString();
		}
	}

	// Token: 0x06000965 RID: 2405 RVA: 0x00023D9A File Offset: 0x00021F9A
	private void Method12870(173 1, int 2)
	{
		base.Method4119();
		if (1.GetWriteState() == (983)5)
		{
			1.WriteNull();
		}
		while (1.GetTop() > 2)
		{
			1.WriteEnd();
		}
	}

	// Token: 0x06000966 RID: 2406 RVA: 0x00023DC4 File Offset: 0x00021FC4
	private bool Method12871(173 1, 666 2, object 3)
	{
		if (2.Predicate7788 == null)
		{
			return true;
		}
		bool flag = 2.Predicate7788(3);
		if (this._recoveredType17753200 != null && this._recoveredType17753200.GetLevelFilter() >= TraceLevel.Verbose)
		{
			this._recoveredType17753200.WriteTrace(TraceLevel.Verbose, 137.Method3522(null, 1.GetPath(), "ShouldSerialize result for property '{0}' on {1}: {2}".Method6825(CultureInfo.InvariantCulture, 2.GetText7760_9879(), 2.GetType7764_9881(), flag)), null);
		}
		return flag;
	}

	// Token: 0x06000967 RID: 2407 RVA: 0x00023E3C File Offset: 0x0002203C
	private bool Method12872(173 1, 666 2, object 3)
	{
		if (2.Predicate7790 == null)
		{
			return true;
		}
		bool flag = 2.Predicate7790(3);
		if (this._recoveredType17753200 != null && this._recoveredType17753200.GetLevelFilter() >= TraceLevel.Verbose)
		{
			this._recoveredType17753200.WriteTrace(TraceLevel.Verbose, 137.Method3522(null, 1.GetPath(), "IsSpecified result for property '{0}' on {1}: {2}".Method6825(CultureInfo.InvariantCulture, 2.GetText7760_9879(), 2.GetType7764_9881(), flag)), null);
		}
		return flag;
	}

	// Token: 0x040004FC RID: 1276
	[241(2)]
	private Type type3;

	// Token: 0x040004FD RID: 1277
	private int number2;

	// Token: 0x040004FE RID: 1278
	private readonly List<object> list = new List<object>();
}
