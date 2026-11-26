using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

// Token: 0x020000C2 RID: 194
[ComVisible(false)]
[242(1)]
[241(0)]
public sealed class 52 : 214
{
	// Token: 0x06000517 RID: 1303 RVA: 0x0000F628 File Offset: 0x0000D828
	private static Type Method9875(Type 1)
	{
		431<object, object> recoveredType = 469.GetRecoveredType07893454_4445().RecoveredType06223468;
		object 2 = null;
		object[] array = new object[2];
		array[0] = 1;
		object arg = ((object[])recoveredType(2, array)).First<object>();
		return (Type)469.GetRecoveredType07893454_4445().GetFunc3463_4448()(arg);
	}

	// Token: 0x06000518 RID: 1304 RVA: 0x0000F670 File Offset: 0x0000D870
	private static 52.55 Method9876(Type 1)
	{
		431<object, object> recoveredType = 469.GetRecoveredType07893454_4445().RecoveredType06223469;
		object 2 = null;
		object[] array = new object[2];
		array[0] = 1;
		52.55 3 = new 52.55((566)recoveredType(2, array), new List<52.54>());
		431<object, object> recoveredType2 = 469.GetRecoveredType07893454_4445().RecoveredType06223468;
		object 4 = null;
		object[] array2 = new object[2];
		array2[0] = 1;
		foreach (object obj in (object[])recoveredType2(4, array2))
		{
			int 5 = (int)469.GetRecoveredType07893454_4445().GetFunc3465_4452()(obj);
			string 6 = (string)469.GetRecoveredType07893454_4445().GetFunc3464_4450()(obj);
			PropertyInfo[] 7 = (PropertyInfo[])469.GetRecoveredType07893454_4445().RecoveredType06223472(obj, Array.Empty<object>());
			431<object, object> recoveredType3 = 469.GetRecoveredType07893454_4445().RecoveredType06223470;
			object 8 = null;
			object[] array4 = new object[2];
			array4[0] = obj;
			566 9 = (566)recoveredType3(8, array4);
			431<object, object> recoveredType4 = 469.GetRecoveredType07893454_4445().RecoveredType06223471;
			object 10 = null;
			object[] array5 = new object[2];
			array5[0] = obj;
			52.54 item = new 52.54(5, 6, 7, 9, (566)recoveredType4(10, array5));
			3.list2.Add(item);
		}
		return 3;
	}

	// Token: 0x06000519 RID: 1305 RVA: 0x0000F778 File Offset: 0x0000D978
	public override void WriteJson(173 1, [241(2)] object 2, 158 3)
	{
		52.56 writeJsonClosure = new 52.56();
		if (2 == null)
		{
			9.WriteNull();
			return;
		}
		65 4 = 3.Method1759() as 65;
		Type 5 = 52._recoveredType08387755.Method4701(2.GetType());
		52.55 6 = 52._recoveredType08387754.Method4701(5);
		writeJsonClosure.number = (int)6._recoveredType13377752.Method7766(new object[]
		{
			2
		});
		52.54 7 = 6.list2.Single((52.54 1) => 1.number2 == writeJsonClosure.number);
		9.WriteStartObject();
		9.WritePropertyName((4 != null) ? 4.GetResolvedPropertyName("Case") : "Case");
		9.WriteValue(7.text2);
		if (7.propertyInfoArray2 != null && 7.propertyInfoArray2.Length != 0)
		{
			object[] array = (object[])7._recoveredType13377750.Method7766(new object[]
			{
				2
			});
			9.WritePropertyName((4 != null) ? 4.GetResolvedPropertyName("Fields") : "Fields");
			9.WriteStartArray();
			foreach (object 8 in array)
			{
				3.Method3848(9, 8);
			}
			9.WriteEndArray();
		}
		9.WriteEndObject();
	}

	// Token: 0x0600051A RID: 1306 RVA: 0x0000F8B8 File Offset: 0x0000DAB8
	[return: 241(2)]
	public override object ReadJson(139 1, Type 2, [241(2)] object 3, 158 4)
	{
		52.53 readJsonClosure = new 52.53();
		if (10.GetTokenType() == 216.Null)
		{
			return null;
		}
		52.54 5 = null;
		readJsonClosure.text = null;
		109 6 = null;
		10.Method2843();
		Func<52.54, bool> <>9__0;
		while (10.GetTokenType() == 216.PropertyName)
		{
			string text = 10.GetValue().ToString();
			if (string.Equals(text, "Case", StringComparison.OrdinalIgnoreCase))
			{
				10.Method2843();
				52.55 7 = 52._recoveredType08387754.Method4701(2);
				readJsonClosure.text = 10.GetValue().ToString();
				IEnumerable<52.54> list = 7.list2;
				Func<52.54, bool> predicate;
				if ((predicate = <>9__0) == null)
				{
					predicate = (<>9__0 = ((52.54 1) => 1.text2 == readJsonClosure.text));
				}
				5 = list.SingleOrDefault(predicate);
				if (5 == null)
				{
					throw 364.Method1687(10, "No union type found with the name '{0}'.".Method6825(CultureInfo.InvariantCulture, readJsonClosure.text));
				}
			}
			else
			{
				if (!string.Equals(text, "Fields", StringComparison.OrdinalIgnoreCase))
				{
					throw 364.Method1687(10, "Unexpected property '{0}' found when reading union.".Method6825(CultureInfo.InvariantCulture, text));
				}
				10.Method2843();
				if (10.GetTokenType() != 216.StartArray)
				{
					throw 364.Method1687(10, "Union fields must been an array.");
				}
				6 = (109)226.ReadFrom(10);
			}
			10.Method2843();
		}
		if (5 == null)
		{
			throw 364.Method1687(10, "No '{0}' property with union name found.".Method6825(CultureInfo.InvariantCulture, "Case"));
		}
		object[] array = new object[5.propertyInfoArray2.Length];
		if (5.propertyInfoArray2.Length != 0 && 6 == null)
		{
			throw 364.Method1687(10, "No '{0}' property with union fields found.".Method6825(CultureInfo.InvariantCulture, "Fields"));
		}
		if (6 != null)
		{
			if (5.propertyInfoArray2.Length != 6.Count)
			{
				throw 364.Method1687(10, "The number of field values does not match the number of properties defined by union '{0}'.".Method6825(CultureInfo.InvariantCulture, readJsonClosure.text));
			}
			for (int i = 0; i < 6.Count; i++)
			{
				226 8 = 6[i];
				PropertyInfo propertyInfo = 5.propertyInfoArray2[i];
				array[i] = 8.ToObject(propertyInfo.PropertyType, 4);
			}
		}
		object[] 9 = new object[]
		{
			array
		};
		return 5._recoveredType13377751.Method7766(9);
	}

	// Token: 0x0600051B RID: 1307 RVA: 0x0000FAD0 File Offset: 0x0000DCD0
	public override bool CanConvert(Type 1)
	{
		if (typeof(IEnumerable).IsAssignableFrom(1))
		{
			return false;
		}
		object[] customAttributes = 1.GetCustomAttributes(true);
		bool flag = false;
		object[] array = customAttributes;
		for (int i = 0; i < array.Length; i++)
		{
			Type type = array[i].GetType();
			if (type.FullName == "Microsoft.FSharp.Core.CompilationMappingAttribute")
			{
				469.Method4454(type.Method6708());
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			return false;
		}
		431<object, object> recoveredType = 469.GetRecoveredType07893454_4445().RecoveredType06223467;
		object 2 = null;
		object[] array2 = new object[2];
		array2[0] = 1;
		return (bool)recoveredType(2, array2);
	}

	// Token: 0x04000403 RID: 1027
	private static readonly 482<Type, 52.55> _recoveredType08387754 = new 482<Type, 52.55>(delegate(Type 1)
	{
		431<object, object> recoveredType = 469.GetRecoveredType07893454_4445().RecoveredType06223469;
		object 2 = null;
		object[] array = new object[2];
		array[0] = 1;
		52.55 3 = new 52.55((566)recoveredType(2, array), new List<52.54>());
		431<object, object> recoveredType2 = 469.GetRecoveredType07893454_4445().RecoveredType06223468;
		object 4 = null;
		object[] array2 = new object[2];
		array2[0] = 1;
		foreach (object obj in (object[])recoveredType2(4, array2))
		{
			int 5 = (int)469.GetRecoveredType07893454_4445().GetFunc3465_4452()(obj);
			string 6 = (string)469.GetRecoveredType07893454_4445().GetFunc3464_4450()(obj);
			PropertyInfo[] 7 = (PropertyInfo[])469.GetRecoveredType07893454_4445().RecoveredType06223472(obj, Array.Empty<object>());
			431<object, object> recoveredType3 = 469.GetRecoveredType07893454_4445().RecoveredType06223470;
			object 8 = null;
			object[] array4 = new object[2];
			array4[0] = obj;
			566 9 = (566)recoveredType3(8, array4);
			431<object, object> recoveredType4 = 469.GetRecoveredType07893454_4445().RecoveredType06223471;
			object 10 = null;
			object[] array5 = new object[2];
			array5[0] = obj;
			52.54 item = new 52.54(5, 6, 7, 9, (566)recoveredType4(10, array5));
			3.list2.Add(item);
		}
		return 3;
	});

	// Token: 0x04000404 RID: 1028
	private static readonly 482<Type, Type> _recoveredType08387755 = new 482<Type, Type>(new Func<Type, Type>(52.Method9875));

	// Token: 0x020000C3 RID: 195
	public sealed class 56
	{
		// Token: 0x0600051E RID: 1310 RVA: 0x0000FB89 File Offset: 0x0000DD89
		[242(0)]
		internal bool Method9873(52.54 1)
		{
			return 1.number2 == this.number;
		}

		// Token: 0x04000405 RID: 1029
		public int number;
	}

	// Token: 0x020000C4 RID: 196
	public sealed class 53
	{
		// Token: 0x06000520 RID: 1312 RVA: 0x0000FB99 File Offset: 0x0000DD99
		[242(0)]
		internal bool Method9874(52.54 1)
		{
			return 1.text2 == this.text;
		}

		// Token: 0x04000406 RID: 1030
		[241(0)]
		public string text;

		// Token: 0x04000407 RID: 1031
		[241(0)]
		public Func<52.54, bool> func;
	}

	// Token: 0x020000C5 RID: 197
	[241(0)]
	public sealed class 54
	{
		// Token: 0x06000522 RID: 1314 RVA: 0x0000FBAC File Offset: 0x0000DDAC
		public 54(int 1, string 2, PropertyInfo[] 3, 566 4, 566 5)
		{
			this.number2 = 1;
			this.text2 = 2;
			this.propertyInfoArray2 = 3;
			this._recoveredType13377750 = 4;
			this._recoveredType13377751 = 5;
		}

		// Token: 0x04000408 RID: 1032
		public readonly int number2;

		// Token: 0x04000409 RID: 1033
		public readonly string text2;

		// Token: 0x0400040A RID: 1034
		public readonly PropertyInfo[] propertyInfoArray2;

		// Token: 0x0400040B RID: 1035
		public readonly 566 _recoveredType13377750;

		// Token: 0x0400040C RID: 1036
		public readonly 566 _recoveredType13377751;
	}

	// Token: 0x020000C6 RID: 198
	[241(0)]
	public sealed class 55
	{
		// Token: 0x06000523 RID: 1315 RVA: 0x0000FBD9 File Offset: 0x0000DDD9
		public 55(566 1, List<52.54> 2)
		{
			this._recoveredType13377752 = 1;
			this.list2 = 2;
		}

		// Token: 0x0400040D RID: 1037
		public readonly 566 _recoveredType13377752;

		// Token: 0x0400040E RID: 1038
		public readonly List<52.54> list2;
	}
}
