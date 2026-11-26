using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;

// Token: 0x02000200 RID: 512
[241(0)]
[242(1)]
public static class 143
{
	// Token: 0x0600102E RID: 4142 RVA: 0x00037234 File Offset: 0x00035434
	public static bool IsVirtualProperty(this PropertyInfo 1)
	{
		756.Method12216(1, "propertyInfo");
		MethodInfo methodInfo = 1.GetGetMethod(true);
		if (methodInfo != null && methodInfo.IsVirtual)
		{
			return true;
		}
		methodInfo = 1.GetSetMethod(true);
		return methodInfo != null && methodInfo.IsVirtual;
	}

	// Token: 0x0600102F RID: 4143 RVA: 0x00037284 File Offset: 0x00035484
	[return: 241(2)]
	public static MethodInfo GetPropertyBaseDefinition(this PropertyInfo 1)
	{
		756.Method12216(1, "propertyInfo");
		MethodInfo getMethod = 1.GetGetMethod(true);
		if (getMethod != null)
		{
			return getMethod.GetBaseDefinition();
		}
		MethodInfo setMethod = 1.GetSetMethod(true);
		if (setMethod == null)
		{
			return null;
		}
		return setMethod.GetBaseDefinition();
	}

	// Token: 0x06001030 RID: 4144 RVA: 0x000372C8 File Offset: 0x000354C8
	public static bool HasPublicAccessor(PropertyInfo 1)
	{
		MethodInfo getMethod = 1.GetGetMethod();
		if (getMethod != null && getMethod.IsPublic)
		{
			return true;
		}
		MethodInfo setMethod = 1.GetSetMethod();
		return setMethod != null && setMethod.IsPublic;
	}

	// Token: 0x06001031 RID: 4145 RVA: 0x0003730A File Offset: 0x0003550A
	[242(2)]
	public static Type GetObjectType(object 1)
	{
		if (1 == null)
		{
			return null;
		}
		return 1.GetType();
	}

	// Token: 0x06001032 RID: 4146 RVA: 0x00037318 File Offset: 0x00035518
	public static string GetTypeName(Type 1, 703 2, [241(2)] 718 3)
	{
		string fullyQualifiedTypeName = 143.GetFullyQualifiedTypeName(1, 3);
		string result;
		if (2 != (703)0)
		{
			if (2 != (703)1)
			{
				throw new ArgumentOutOfRangeException();
			}
			result = fullyQualifiedTypeName;
		}
		else
		{
			result = 143.RemoveAssemblyDetails(fullyQualifiedTypeName);
		}
		return result;
	}

	// Token: 0x06001033 RID: 4147 RVA: 0x0003734C File Offset: 0x0003554C
	private static string GetFullyQualifiedTypeName(Type 1, [241(2)] 718 2)
	{
		if (2 != null)
		{
			string text;
			string str;
			2.BindToName(1, out text, out str);
			return str + ((text == null) ? string.Empty : (", " + text));
		}
		return 1.AssemblyQualifiedName;
	}

	// Token: 0x06001034 RID: 4148 RVA: 0x0003738C File Offset: 0x0003558C
	private static string RemoveAssemblyDetails(string 1)
	{
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = false;
		bool flag2 = false;
		bool flag3 = false;
		foreach (char c in 1)
		{
			if (c != ',')
			{
				if (c != '[')
				{
					if (c != ']')
					{
						flag3 = false;
						if (!flag2)
						{
							stringBuilder.Append(c);
						}
					}
					else
					{
						flag = false;
						flag2 = false;
						flag3 = false;
						stringBuilder.Append(c);
					}
				}
				else
				{
					flag = false;
					flag2 = false;
					flag3 = true;
					stringBuilder.Append(c);
				}
			}
			else if (flag3)
			{
				stringBuilder.Append(c);
			}
			else if (!flag)
			{
				flag = true;
				stringBuilder.Append(c);
			}
			else
			{
				flag2 = true;
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06001035 RID: 4149 RVA: 0x00037438 File Offset: 0x00035638
	public static bool HasDefaultConstructor(Type 1, bool 2)
	{
		756.Method12216(1, "t");
		return 1.Method6714() || 143.Method3888(1, 2) != null;
	}

	// Token: 0x06001036 RID: 4150 RVA: 0x0003745C File Offset: 0x0003565C
	[return: 241(2)]
	public static ConstructorInfo Method3888(Type 1)
	{
		return 143.Method3888(1, false);
	}

	// Token: 0x06001037 RID: 4151 RVA: 0x00037468 File Offset: 0x00035668
	[return: 241(2)]
	public static ConstructorInfo Method3888(Type 1, bool 2)
	{
		BindingFlags bindingFlags = BindingFlags.Instance | BindingFlags.Public;
		if (2)
		{
			bindingFlags |= BindingFlags.NonPublic;
		}
		return 1.GetConstructors(bindingFlags).SingleOrDefault(new Func<ConstructorInfo, bool>(143.145.instance.IsParameterless));
	}

	// Token: 0x06001038 RID: 4152 RVA: 0x0003749C File Offset: 0x0003569C
	public static bool IsNullable(Type 1)
	{
		756.Method12216(1, "t");
		return !1.Method6714() || 143.IsNullableType(1);
	}

	// Token: 0x06001039 RID: 4153 RVA: 0x000374B9 File Offset: 0x000356B9
	public static bool IsNullableType(Type 1)
	{
		756.Method12216(1, "t");
		return 1.Method6705() && 1.GetGenericTypeDefinition() == typeof(Nullable<>);
	}

	// Token: 0x0600103A RID: 4154 RVA: 0x000374E5 File Offset: 0x000356E5
	public static Type GetNonNullableType(Type 1)
	{
		if (!143.IsNullableType(1))
		{
			return 1;
		}
		return Nullable.GetUnderlyingType(1);
	}

	// Token: 0x0600103B RID: 4155 RVA: 0x000374F7 File Offset: 0x000356F7
	public static Type GetNonByRefType(Type 1)
	{
		if (!1.IsByRef || !1.HasElementType)
		{
			return 1;
		}
		return 1.GetElementType();
	}

	// Token: 0x0600103C RID: 4156 RVA: 0x00037511 File Offset: 0x00035711
	public static bool IsGenericTypeOf(Type 1, Type 2)
	{
		return 1.Method6705() && 1.GetGenericTypeDefinition() == 2;
	}

	// Token: 0x0600103D RID: 4157 RVA: 0x0003752C File Offset: 0x0003572C
	public static bool Method3895(Type 1, Type 2)
	{
		Type type;
		return 143.Method3895(1, 2, out type);
	}

	// Token: 0x0600103E RID: 4158 RVA: 0x00037544 File Offset: 0x00035744
	public static bool Method3895(Type 1, Type 2, [241(2)] [239(true)] out Type 3)
	{
		756.Method12216(1, "type");
		756.Method12216(2, "genericInterfaceDefinition");
		if (!2.Method6704() || !2.Method6706())
		{
			throw new ArgumentNullException("'{0}' is not a generic interface definition.".Method6825(CultureInfo.InvariantCulture, 2));
		}
		if (1.Method6704() && 1.Method6705())
		{
			Type genericTypeDefinition = 1.GetGenericTypeDefinition();
			if (2 == genericTypeDefinition)
			{
				3 = 1;
				return true;
			}
		}
		foreach (Type type in 1.GetInterfaces())
		{
			if (type.Method6705())
			{
				Type genericTypeDefinition2 = type.GetGenericTypeDefinition();
				if (2 == genericTypeDefinition2)
				{
					3 = type;
					return true;
				}
			}
		}
		3 = null;
		return false;
	}

	// Token: 0x0600103F RID: 4159 RVA: 0x000375F0 File Offset: 0x000357F0
	public static bool Method3897(Type 1, Type 2)
	{
		Type type;
		return 143.Method3897(1, 2, out type);
	}

	// Token: 0x06001040 RID: 4160 RVA: 0x00037608 File Offset: 0x00035808
	public static bool Method3897(Type 1, Type 2, [241(2)] out Type 3)
	{
		756.Method12216(1, "type");
		756.Method12216(2, "genericClassDefinition");
		if (!2.Method6710() || !2.Method6706())
		{
			throw new ArgumentNullException("'{0}' is not a generic class definition.".Method6825(CultureInfo.InvariantCulture, 2));
		}
		return 143.InheritsGenericDefinitionInternal(1, 2, out 3);
	}

	// Token: 0x06001041 RID: 4161 RVA: 0x0003765C File Offset: 0x0003585C
	private static bool InheritsGenericDefinitionInternal(Type 1, Type 2, [241(2)] out Type 3)
	{
		Type type = 1;
		while (!type.Method6705() || !(2 == type.GetGenericTypeDefinition()))
		{
			type = type.Method6707();
			if (!(type != null))
			{
				3 = null;
				return false;
			}
		}
		3 = type;
		return true;
	}

	// Token: 0x06001042 RID: 4162 RVA: 0x0003769C File Offset: 0x0003589C
	[return: 241(2)]
	public static Type GetCollectionItemType(Type 1)
	{
		756.Method12216(1, "type");
		if (1.IsArray)
		{
			return 1.GetElementType();
		}
		Type type;
		if (143.Method3895(1, typeof(IEnumerable<>), out type))
		{
			if (type.Method6706())
			{
				throw new Exception("Type {0} is not a collection.".Method6825(CultureInfo.InvariantCulture, 1));
			}
			return type.GetGenericArguments()[0];
		}
		else
		{
			if (typeof(IEnumerable).IsAssignableFrom(1))
			{
				return null;
			}
			throw new Exception("Type {0} is not a collection.".Method6825(CultureInfo.InvariantCulture, 1));
		}
	}

	// Token: 0x06001043 RID: 4163 RVA: 0x00037728 File Offset: 0x00035928
	[242(2)]
	public static void GetDictionaryKeyValueTypes([241(1)] Type 1, out Type 2, out Type 3)
	{
		756.Method12216(1, "dictionaryType");
		Type type;
		if (143.Method3895(1, typeof(IDictionary<, >), out type))
		{
			if (type.Method6706())
			{
				throw new Exception("Type {0} is not a dictionary.".Method6825(CultureInfo.InvariantCulture, 1));
			}
			Type[] genericArguments = type.GetGenericArguments();
			2 = genericArguments[0];
			3 = genericArguments[1];
			return;
		}
		else
		{
			if (!typeof(IDictionary).IsAssignableFrom(1))
			{
				throw new Exception("Type {0} is not a dictionary.".Method6825(CultureInfo.InvariantCulture, 1));
			}
			2 = null;
			3 = null;
			return;
		}
	}

	// Token: 0x06001044 RID: 4164 RVA: 0x000377B4 File Offset: 0x000359B4
	public static Type GetMemberUnderlyingType(MemberInfo 1)
	{
		756.Method12216(1, "member");
		MemberTypes memberTypes = 1.Method6702();
		if (memberTypes <= MemberTypes.Field)
		{
			if (memberTypes == MemberTypes.Event)
			{
				return ((EventInfo)1).EventHandlerType;
			}
			if (memberTypes == MemberTypes.Field)
			{
				return ((FieldInfo)1).FieldType;
			}
		}
		else
		{
			if (memberTypes == MemberTypes.Method)
			{
				return ((MethodInfo)1).ReturnType;
			}
			if (memberTypes == MemberTypes.Property)
			{
				return ((PropertyInfo)1).PropertyType;
			}
		}
		throw new ArgumentException("MemberInfo must be of type FieldInfo, PropertyInfo, EventInfo or MethodInfo", "#=zg1aVhiQ=");
	}

	// Token: 0x06001045 RID: 4165 RVA: 0x00037838 File Offset: 0x00035A38
	public static bool IsByRefLikeType(Type 1)
	{
		if (!1.Method6714())
		{
			return false;
		}
		Attribute[] array = 143.Method3913(1, null, false);
		for (int i = 0; i < array.Length; i++)
		{
			if (string.Equals(array[i].GetType().FullName, "System.Runtime.CompilerServices.IsByRefLikeAttribute", StringComparison.Ordinal))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001046 RID: 4166 RVA: 0x00037883 File Offset: 0x00035A83
	public static bool IsIndexedProperty(PropertyInfo 1)
	{
		756.Method12216(1, "property");
		return 1.GetIndexParameters().Length != 0;
	}

	// Token: 0x06001047 RID: 4167 RVA: 0x0003789C File Offset: 0x00035A9C
	[return: 241(2)]
	public static object GetMemberValue(MemberInfo 1, object 2)
	{
		756.Method12216(1, "member");
		756.Method12216(2, "target");
		MemberTypes memberTypes = 1.Method6702();
		if (memberTypes != MemberTypes.Field)
		{
			if (memberTypes == MemberTypes.Property)
			{
				try
				{
					return ((PropertyInfo)1).GetValue(2, null);
				}
				catch (TargetParameterCountException innerException)
				{
					throw new ArgumentException("MemberInfo '{0}' has index parameters".Method6825(CultureInfo.InvariantCulture, 1.Name), innerException);
				}
			}
			throw new ArgumentException("MemberInfo '{0}' is not of type FieldInfo or PropertyInfo".Method6825(CultureInfo.InvariantCulture, 1.Name), "#=zg1aVhiQ=");
		}
		return ((FieldInfo)1).GetValue(2);
	}

	// Token: 0x06001048 RID: 4168 RVA: 0x00037940 File Offset: 0x00035B40
	public static void SetMemberValue(MemberInfo 1, object 2, [241(2)] object 3)
	{
		756.Method12216(1, "member");
		756.Method12216(2, "target");
		MemberTypes memberTypes = 1.Method6702();
		if (memberTypes == MemberTypes.Field)
		{
			((FieldInfo)1).SetValue(2, 3);
			return;
		}
		if (memberTypes != MemberTypes.Property)
		{
			throw new ArgumentException("MemberInfo '{0}' must be of type FieldInfo or PropertyInfo".Method6825(CultureInfo.InvariantCulture, 1.Name), "#=zg1aVhiQ=");
		}
		((PropertyInfo)1).SetValue(2, 3, null);
	}

	// Token: 0x06001049 RID: 4169 RVA: 0x000379B4 File Offset: 0x00035BB4
	public static bool CanReadMemberValue(MemberInfo 1, bool 2)
	{
		MemberTypes memberTypes = 1.Method6702();
		if (memberTypes == MemberTypes.Field)
		{
			FieldInfo fieldInfo = (FieldInfo)1;
			return 2 || fieldInfo.IsPublic;
		}
		if (memberTypes != MemberTypes.Property)
		{
			return false;
		}
		PropertyInfo propertyInfo = (PropertyInfo)1;
		return propertyInfo.CanRead && (2 || propertyInfo.GetGetMethod(2) != null);
	}

	// Token: 0x0600104A RID: 4170 RVA: 0x00037A10 File Offset: 0x00035C10
	public static bool CanSetMemberValue(MemberInfo 1, bool 2, bool 3)
	{
		MemberTypes memberTypes = 1.Method6702();
		if (memberTypes == MemberTypes.Field)
		{
			FieldInfo fieldInfo = (FieldInfo)1;
			return !fieldInfo.IsLiteral && (!fieldInfo.IsInitOnly || 3) && (2 || fieldInfo.IsPublic);
		}
		if (memberTypes != MemberTypes.Property)
		{
			return false;
		}
		PropertyInfo propertyInfo = (PropertyInfo)1;
		return propertyInfo.CanWrite && (2 || propertyInfo.GetSetMethod(2) != null);
	}

	// Token: 0x0600104B RID: 4171 RVA: 0x00037A84 File Offset: 0x00035C84
	public static List<MemberInfo> GetFieldsAndProperties(Type 1, BindingFlags 2)
	{
		List<MemberInfo> list = new List<MemberInfo>();
		list.AddRange(143.GetAllFields(1, 2));
		list.AddRange(143.GetAllProperties(1, 2));
		List<MemberInfo> list2 = new List<MemberInfo>(list.Count);
		foreach (IGrouping<string, MemberInfo> grouping in list.GroupBy(new Func<MemberInfo, string>(143.145.instance.GetMemberName)))
		{
			if (grouping.Count<MemberInfo>() == 1)
			{
				list2.Add(grouping.First<MemberInfo>());
			}
			else
			{
				List<MemberInfo> list3 = new List<MemberInfo>();
				using (IEnumerator<MemberInfo> enumerator2 = grouping.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						143.144 3 = new 143.144();
						3.targetMember = enumerator2.Current;
						if (list3.Count == 0)
						{
							list3.Add(3.targetMember);
						}
						else if ((!143.IsOverriddenGenericMember(3.targetMember, 2) || 3.targetMember.Name == "Item") && !list3.Any(new Func<MemberInfo, bool>(3.MatchesDeclaringType)))
						{
							list3.Add(3.targetMember);
						}
					}
				}
				list2.AddRange(list3);
			}
		}
		return list2;
	}

	// Token: 0x0600104C RID: 4172 RVA: 0x00037BD4 File Offset: 0x00035DD4
	private static bool IsOverriddenGenericMember(MemberInfo 1, BindingFlags 2)
	{
		if (1.Method6702() != MemberTypes.Property)
		{
			return false;
		}
		PropertyInfo propertyInfo = (PropertyInfo)1;
		if (!propertyInfo.IsVirtualProperty())
		{
			return false;
		}
		Type declaringType = propertyInfo.DeclaringType;
		if (!declaringType.Method6705())
		{
			return false;
		}
		Type genericTypeDefinition = declaringType.GetGenericTypeDefinition();
		if (genericTypeDefinition == null)
		{
			return false;
		}
		MemberInfo[] member = genericTypeDefinition.GetMember(propertyInfo.Name, 2);
		return member.Length != 0 && 143.GetMemberUnderlyingType(member[0]).IsGenericParameter;
	}

	// Token: 0x0600104D RID: 4173 RVA: 0x00037C47 File Offset: 0x00035E47
	[return: 241(2)]
	public static T Method3911<[241(0)] T>(object 1) where T : Attribute
	{
		return 143.Method3911<T>(1, true);
	}

	// Token: 0x0600104E RID: 4174 RVA: 0x00037C50 File Offset: 0x00035E50
	[return: 241(2)]
	public static T Method3911<[241(0)] T>(object 1, bool 2) where T : Attribute
	{
		T[] array = 143.Method3913<T>(1, 2);
		if (array == null)
		{
			return default(T);
		}
		return 44.ArrayFirstOrDefault<T>(array);
	}

	// Token: 0x0600104F RID: 4175 RVA: 0x00037C78 File Offset: 0x00035E78
	public static T[] Method3913<[241(0)] T>(object 1, bool 2) where T : Attribute
	{
		Attribute[] array = 143.Method3913(1, typeof(T), 2);
		T[] array2 = array as T[];
		if (array2 != null)
		{
			return array2;
		}
		return array.Cast<T>().ToArray<T>();
	}

	// Token: 0x06001050 RID: 4176 RVA: 0x00037CB0 File Offset: 0x00035EB0
	public static Attribute[] Method3913(object 1, [241(2)] Type 2, bool 3)
	{
		756.Method12216(1, "attributeProvider");
		Type type = 1 as Type;
		if (type != null)
		{
			return ((2 != null) ? type.GetCustomAttributes(2, 3) : type.GetCustomAttributes(3)).Cast<Attribute>().ToArray<Attribute>();
		}
		Assembly assembly = 1 as Assembly;
		if (assembly == null)
		{
			MemberInfo memberInfo = 1 as MemberInfo;
			if (memberInfo == null)
			{
				Module module = 1 as Module;
				if (module == null)
				{
					ParameterInfo parameterInfo = 1 as ParameterInfo;
					if (parameterInfo == null)
					{
						ICustomAttributeProvider customAttributeProvider = (ICustomAttributeProvider)1;
						return (Attribute[])((2 != null) ? customAttributeProvider.GetCustomAttributes(2, 3) : customAttributeProvider.GetCustomAttributes(3));
					}
					if (!(2 != null))
					{
						return Attribute.GetCustomAttributes(parameterInfo, 3);
					}
					return Attribute.GetCustomAttributes(parameterInfo, 2, 3);
				}
				else
				{
					if (!(2 != null))
					{
						return Attribute.GetCustomAttributes(module, 3);
					}
					return Attribute.GetCustomAttributes(module, 2, 3);
				}
			}
			else
			{
				if (!(2 != null))
				{
					return Attribute.GetCustomAttributes(memberInfo, 3);
				}
				return Attribute.GetCustomAttributes(memberInfo, 2, 3);
			}
		}
		else
		{
			if (!(2 != null))
			{
				return Attribute.GetCustomAttributes(assembly);
			}
			return Attribute.GetCustomAttributes(assembly, 2);
		}
	}

	// Token: 0x06001051 RID: 4177 RVA: 0x00037DB8 File Offset: 0x00035FB8
	[return: 241(new byte[]
	{
		0,
		2,
		1
	})]
	public static 558<string, string> SplitFullyQualifiedTypeName(string 1)
	{
		int? assemblyDelimiterIndex = 143.GetAssemblyDelimiterIndex(1);
		string 2;
		string 3;
		if (assemblyDelimiterIndex != null)
		{
			2 = 1.Method6845(0, assemblyDelimiterIndex.GetValueOrDefault());
			3 = 1.Method6845(assemblyDelimiterIndex.GetValueOrDefault() + 1, 1.Length - assemblyDelimiterIndex.GetValueOrDefault() - 1);
		}
		else
		{
			2 = 1;
			3 = null;
		}
		return new 558<string, string>(3, 2);
	}

	// Token: 0x06001052 RID: 4178 RVA: 0x00037E14 File Offset: 0x00036014
	private static int? GetAssemblyDelimiterIndex(string 1)
	{
		int num = 0;
		for (int i = 0; i < 1.Length; i++)
		{
			char c = 1[i];
			if (c != ',')
			{
				if (c != '[')
				{
					if (c == ']')
					{
						num--;
					}
				}
				else
				{
					num++;
				}
			}
			else if (num == 0)
			{
				return new int?(i);
			}
		}
		return null;
	}

	// Token: 0x06001053 RID: 4179 RVA: 0x00037E6C File Offset: 0x0003606C
	[return: 241(2)]
	public static MemberInfo GetMemberInfoFromType(Type 1, MemberInfo 2)
	{
		if (2.Method6702() == MemberTypes.Property)
		{
			PropertyInfo propertyInfo = (PropertyInfo)2;
			Type[] types = (from 1 in propertyInfo.GetIndexParameters()
			select 1.ParameterType).ToArray<Type>();
			return 3.GetProperty(propertyInfo.Name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, propertyInfo.PropertyType, types, null);
		}
		return 3.GetMember(2.Name, 2.Method6702(), BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).SingleOrDefault<MemberInfo>();
	}

	// Token: 0x06001054 RID: 4180 RVA: 0x00037EEB File Offset: 0x000360EB
	public static IEnumerable<FieldInfo> GetAllFields(Type 1, BindingFlags 2)
	{
		756.Method12216(1, "targetType");
		List<MemberInfo> list = new List<MemberInfo>(1.GetFields(2));
		143.AddInheritedPrivateFields(list, 1, 2);
		return list.Cast<FieldInfo>();
	}

	// Token: 0x06001055 RID: 4181 RVA: 0x00037F14 File Offset: 0x00036114
	private static void AddInheritedPrivateFields(IList<MemberInfo> 1, Type 2, BindingFlags 3)
	{
		Type type = 2;
		if ((3 & BindingFlags.NonPublic) != BindingFlags.Default)
		{
			BindingFlags bindingAttr = 3.RemoveFlag(BindingFlags.Public);
			while ((type = type.Method6707()) != null)
			{
				IEnumerable<FieldInfo> 4 = type.GetFields(bindingAttr).Where(new Func<FieldInfo, bool>(143.145.instance.IsPrivateField));
				1.Method3166(4);
			}
		}
	}

	// Token: 0x06001056 RID: 4182 RVA: 0x00037F68 File Offset: 0x00036168
	public static IEnumerable<PropertyInfo> GetAllProperties(Type 1, BindingFlags 2)
	{
		756.Method12216(1, "targetType");
		List<PropertyInfo> list = new List<PropertyInfo>(1.GetProperties(2));
		if (1.Method6704())
		{
			foreach (Type type in 1.GetInterfaces())
			{
				list.AddRange(type.GetProperties(2));
			}
		}
		143.AddInheritedProperties(list, 1, 2);
		for (int j = 0; j < list.Count; j++)
		{
			PropertyInfo propertyInfo = list[j];
			if (propertyInfo.DeclaringType != 1)
			{
				PropertyInfo value = (PropertyInfo)143.GetMemberInfoFromType(propertyInfo.DeclaringType, propertyInfo);
				list[j] = value;
			}
		}
		return list;
	}

	// Token: 0x06001057 RID: 4183 RVA: 0x00038011 File Offset: 0x00036211
	public static BindingFlags RemoveFlag(this BindingFlags 1, BindingFlags 2)
	{
		if ((1 & 2) != 2)
		{
			return 1;
		}
		return 1 ^ 2;
	}

	// Token: 0x06001058 RID: 4184 RVA: 0x00038020 File Offset: 0x00036220
	private static void AddInheritedProperties(IList<PropertyInfo> 1, Type 2, BindingFlags 3)
	{
		Type type = 2;
		while ((type = type.Method6707()) != null)
		{
			PropertyInfo[] properties = type.GetProperties(3);
			for (int i = 0; i < properties.Length; i++)
			{
				PropertyInfo targetProperty = properties[i];
				143.147 propertyNameMatcher = new 143.147();
				propertyNameMatcher.targetProperty = targetProperty;
				if (!propertyNameMatcher.targetProperty.IsVirtualProperty())
				{
					if (!143.HasPublicAccessor(propertyNameMatcher.targetProperty))
					{
						int num = 4.Method3174(new Func<PropertyInfo, bool>(propertyNameMatcher.MatchesName));
						if (num == -1)
						{
							4.Add(propertyNameMatcher.targetProperty);
						}
						else if (!143.HasPublicAccessor(4[num]))
						{
							4[num] = propertyNameMatcher.targetProperty;
						}
					}
					else if (4.Method3174((PropertyInfo 1) => 1.Name == propertyNameMatcher.targetProperty.Name && 1.DeclaringType == propertyNameMatcher.targetProperty.DeclaringType) == -1)
					{
						4.Add(propertyNameMatcher.targetProperty);
					}
				}
				else
				{
					143.148 virtualPropertyMatcher = new 143.148();
					virtualPropertyMatcher.nameMatcher = propertyNameMatcher;
					143.148 virtualPropertyMatcher2 = virtualPropertyMatcher;
					MethodInfo propertyBaseDefinition = virtualPropertyMatcher.nameMatcher.targetProperty.GetPropertyBaseDefinition();
					virtualPropertyMatcher2.type = (((propertyBaseDefinition != null) ? propertyBaseDefinition.DeclaringType : null) ?? virtualPropertyMatcher.nameMatcher.targetProperty.DeclaringType);
					if (4.Method3174(delegate(PropertyInfo 1)
					{
						if (1.Name == virtualPropertyMatcher.nameMatcher.targetProperty.Name && 1.IsVirtualProperty())
						{
							MethodInfo propertyBaseDefinition2 = 1.GetPropertyBaseDefinition();
							return (((propertyBaseDefinition2 != null) ? propertyBaseDefinition2.DeclaringType : null) ?? 1.DeclaringType).IsAssignableFrom(virtualPropertyMatcher.type);
						}
						return false;
					}) == -1)
					{
						4.Add(virtualPropertyMatcher.nameMatcher.targetProperty);
					}
				}
			}
		}
	}

	// Token: 0x06001059 RID: 4185 RVA: 0x000381DC File Offset: 0x000363DC
	public static bool IsMethodOverridden(Type 1, Type 2, string 3)
	{
		143.146 4 = new 143.146();
		4.text = 3;
		4.type = 2;
		return 1.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).Any(new Func<MethodInfo, bool>(4.IsOverrideOfType));
	}

	// Token: 0x0600105A RID: 4186 RVA: 0x00038218 File Offset: 0x00036418
	[return: 241(2)]
	public static object GetDefaultValue(Type 1)
	{
		if (!1.Method6714())
		{
			return null;
		}
		723 2 = 358.Method1490(1);
		switch (2)
		{
		case 723.Char:
		case 723.SByte:
		case 723.Int16:
		case 723.UInt16:
		case 723.Int32:
		case 723.Byte:
		case 723.UInt32:
			return 0;
		case 723.CharNullable:
		case 723.BooleanNullable:
		case 723.SByteNullable:
		case 723.Int16Nullable:
		case 723.UInt16Nullable:
		case 723.Int32Nullable:
		case 723.ByteNullable:
		case 723.UInt32Nullable:
		case 723.Int64Nullable:
		case 723.UInt64Nullable:
		case 723.SingleNullable:
		case 723.DoubleNullable:
		case 723.DateTimeNullable:
		case 723.DateTimeOffsetNullable:
		case 723.DecimalNullable:
			break;
		case 723.Boolean:
			return false;
		case 723.Int64:
		case 723.UInt64:
			return 0L;
		case 723.Single:
			return 0f;
		case 723.Double:
			return 0.0;
		case 723.DateTime:
			return default(DateTime);
		case 723.DateTimeOffset:
			return default(DateTimeOffset);
		case 723.Decimal:
			return 0m;
		case 723.Guid:
			return default(Guid);
		default:
			if (2 == 723.BigInteger)
			{
				return default(BigInteger);
			}
			break;
		}
		if (143.IsNullable(1))
		{
			return null;
		}
		return Activator.CreateInstance(1);
	}

	// Token: 0x040007DA RID: 2010
	public static readonly Type[] typeArray = Type.EmptyTypes;

	// Token: 0x02000201 RID: 513
	[Serializable]
	public sealed class 145
	{
		// Token: 0x0600105B RID: 4187 RVA: 0x00038349 File Offset: 0x00036549
		[242(0)]
		internal bool IsParameterless(ConstructorInfo 1)
		{
			return !44.ArrayHasItems<ParameterInfo>(1.GetParameters());
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x00038359 File Offset: 0x00036559
		[242(0)]
		internal string GetMemberName(MemberInfo 1)
		{
			return 1.Name;
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x00038361 File Offset: 0x00036561
		[242(0)]
		internal Type GetParameterType(ParameterInfo 1)
		{
			return 1.ParameterType;
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x00038369 File Offset: 0x00036569
		[242(0)]
		internal bool IsPrivateField(FieldInfo 1)
		{
			return 1.IsPrivate;
		}

		// Token: 0x040007DB RID: 2011
		[241(0)]
		public static readonly 143.145 instance = new 143.145();

		// Token: 0x040007DC RID: 2012
		[241(0)]
		public static Func<ConstructorInfo, bool> constructorFilter;

		// Token: 0x040007DD RID: 2013
		[241(0)]
		public static Func<MemberInfo, string> memberNameSelector;

		// Token: 0x040007DE RID: 2014
		[241(0)]
		public static Func<ParameterInfo, Type> parameterTypeSelector;

		// Token: 0x040007DF RID: 2015
		[241(0)]
		public static Func<FieldInfo, bool> privateFieldFilter;
	}

	// Token: 0x02000202 RID: 514
	public sealed class 147
	{
		// Token: 0x06001061 RID: 4193 RVA: 0x0003837D File Offset: 0x0003657D
		[242(0)]
		internal bool MatchesName(PropertyInfo 1)
		{
			return 1.Name == this.targetProperty.Name;
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x00038395 File Offset: 0x00036595
		[242(0)]
		internal bool MatchesNameAndDeclaringType(PropertyInfo 1)
		{
			return 1.Name == this.targetProperty.Name && 1.DeclaringType == this.targetProperty.DeclaringType;
		}

		// Token: 0x040007E0 RID: 2016
		[241(0)]
		public PropertyInfo targetProperty;
	}

	// Token: 0x02000203 RID: 515
	public sealed class 148
	{
		// Token: 0x06001064 RID: 4196 RVA: 0x000383C8 File Offset: 0x000365C8
		[242(0)]
		internal bool MatchesVirtualPropertyOnType(PropertyInfo 1)
		{
			if (1.Name == this.nameMatcher.targetProperty.Name && 1.IsVirtualProperty())
			{
				MethodInfo propertyBaseDefinition = 1.GetPropertyBaseDefinition();
				return (((propertyBaseDefinition != null) ? propertyBaseDefinition.DeclaringType : null) ?? 1.DeclaringType).IsAssignableFrom(this.type);
			}
			return false;
		}

		// Token: 0x040007E1 RID: 2017
		[241(0)]
		public Type type;

		// Token: 0x040007E2 RID: 2018
		[241(0)]
		public 143.147 nameMatcher;
	}

	// Token: 0x02000204 RID: 516
	public sealed class 144
	{
		// Token: 0x06001066 RID: 4198 RVA: 0x00038423 File Offset: 0x00036623
		[242(0)]
		internal bool MatchesDeclaringType(MemberInfo 1)
		{
			return 1.DeclaringType == this.targetMember.DeclaringType;
		}

		// Token: 0x040007E3 RID: 2019
		[241(0)]
		public MemberInfo targetMember;
	}

	// Token: 0x02000205 RID: 517
	public sealed class 146
	{
		// Token: 0x06001068 RID: 4200 RVA: 0x0003843B File Offset: 0x0003663B
		[242(0)]
		internal bool IsOverrideOfType(MethodInfo 1)
		{
			return 1.Name == this.text && 1.DeclaringType != this.type && 1.GetBaseDefinition().DeclaringType == this.type;
		}

		// Token: 0x040007E4 RID: 2020
		[241(0)]
		public string text;

		// Token: 0x040007E5 RID: 2021
		[241(0)]
		public Type type;
	}
}
