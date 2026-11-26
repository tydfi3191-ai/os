using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

// Token: 0x02000099 RID: 153
[242(1)]
[ComVisible(false)]
[241(0)]
public class 65 : 733
{
	// Token: 0x17000020 RID: 32
	// (get) Token: 0x06000349 RID: 841 RVA: 0x00009D24 File Offset: 0x00007F24
	// (set) Token: 0x0600034A RID: 842 RVA: 0x00009D2C File Offset: 0x00007F2C
	[241(2)]
	public 136 NamingStrategy
	{
		[242(2)]
		get
		{
			return this.namingStrategyValue;
		}
		[242(2)]
		set
		{
			this.namingStrategyValue = value;
		}
	}

	// Token: 0x0600034B RID: 843 RVA: 0x00009D35 File Offset: 0x00007F35
	public 65()
	{
		this.SetIgnoreSerializableAttribute(true);
		this.SetBindingFlags(BindingFlags.Instance | BindingFlags.Public);
		this.contractCache = new 482<Type, 902>(new Func<Type, 902>(this.CreateContract));
	}

	// Token: 0x0600034C RID: 844 RVA: 0x00009D6F File Offset: 0x00007F6F
	internal static 733 GetInstance()
	{
		return 65.instance;
	}

	// Token: 0x0600034D RID: 845 RVA: 0x00009D76 File Offset: 0x00007F76
	public bool UsesDynamicCodeGeneration()
	{
		return 170.UsesDynamicCodeGeneration();
	}

	// Token: 0x0600034E RID: 846 RVA: 0x00009D7D File Offset: 0x00007F7D
	public BindingFlags GetBindingFlags()
	{
		return this.bindingFlags2;
	}

	// Token: 0x0600034F RID: 847 RVA: 0x00009D85 File Offset: 0x00007F85
	public void SetBindingFlags(BindingFlags 1)
	{
		this.bindingFlags2 = 1;
	}

	// Token: 0x06000350 RID: 848 RVA: 0x00009D8E File Offset: 0x00007F8E
	public bool GetSerializeCompilerGeneratedMembers()
	{
		return this.serializeCompilerGeneratedMembers;
	}

	// Token: 0x06000351 RID: 849 RVA: 0x00009D96 File Offset: 0x00007F96
	public void SetSerializeCompilerGeneratedMembers(bool 1)
	{
		this.serializeCompilerGeneratedMembers = 1;
	}

	// Token: 0x06000352 RID: 850 RVA: 0x00009D9F File Offset: 0x00007F9F
	public bool GetIgnoreSerializableInterface()
	{
		return this.ignoreSerializableInterface;
	}

	// Token: 0x06000353 RID: 851 RVA: 0x00009DA7 File Offset: 0x00007FA7
	public void SetIgnoreSerializableInterface(bool 1)
	{
		this.ignoreSerializableInterface = 1;
	}

	// Token: 0x06000354 RID: 852 RVA: 0x00009DB0 File Offset: 0x00007FB0
	public bool GetIgnoreSerializableAttribute()
	{
		return this.ignoreSerializableAttribute;
	}

	// Token: 0x06000355 RID: 853 RVA: 0x00009DB8 File Offset: 0x00007FB8
	public void SetIgnoreSerializableAttribute(bool 1)
	{
		this.ignoreSerializableAttribute = 1;
	}

	// Token: 0x06000356 RID: 854 RVA: 0x00009DC1 File Offset: 0x00007FC1
	public bool GetIgnoreIsSpecifiedMembers()
	{
		return this.ignoreIsSpecifiedMembers;
	}

	// Token: 0x06000357 RID: 855 RVA: 0x00009DC9 File Offset: 0x00007FC9
	public void SetIgnoreIsSpecifiedMembers(bool 1)
	{
		this.ignoreIsSpecifiedMembers = 1;
	}

	// Token: 0x06000358 RID: 856 RVA: 0x00009DD2 File Offset: 0x00007FD2
	public bool GetIgnoreShouldSerializeMembers()
	{
		return this.ignoreShouldSerializeMembers;
	}

	// Token: 0x06000359 RID: 857 RVA: 0x00009DDA File Offset: 0x00007FDA
	public void SetIgnoreShouldSerializeMembers(bool 1)
	{
		this.ignoreShouldSerializeMembers = 1;
	}

	// Token: 0x0600035A RID: 858 RVA: 0x00009DE3 File Offset: 0x00007FE3
	public virtual 902 ResolveContract(Type 1)
	{
		756.Method12216(1, "type");
		return this.contractCache.Method4701(1);
	}

	// Token: 0x0600035B RID: 859 RVA: 0x00009DFC File Offset: 0x00007FFC
	private static bool Method13121(MemberInfo 1)
	{
		PropertyInfo propertyInfo = 1 as PropertyInfo;
		if (propertyInfo != null)
		{
			return !143.IsIndexedProperty(propertyInfo) && !143.IsByRefLikeType(propertyInfo.PropertyType);
		}
		FieldInfo fieldInfo = 1 as FieldInfo;
		return fieldInfo == null || !143.IsByRefLikeType(fieldInfo.FieldType);
	}

	// Token: 0x0600035C RID: 860 RVA: 0x00009E48 File Offset: 0x00008048
	protected virtual List<MemberInfo> GetSerializableMembers(Type 1)
	{
		bool 2 = this.GetIgnoreSerializableAttribute();
		698 objectMemberSerialization = 170.GetObjectMemberSerialization(1, 2);
		IEnumerable<MemberInfo> enumerable = 143.GetFieldsAndProperties(1, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).Where(new Func<MemberInfo, bool>(65.71.instance.IsNotIndexedProperty));
		List<MemberInfo> list = new List<MemberInfo>();
		if (objectMemberSerialization != (698)2)
		{
			DataContractAttribute dataContractAttribute = 170.GetDataContractAttribute(1);
			IEnumerable<MemberInfo> fieldsAndProperties = 143.GetFieldsAndProperties(1, this.GetBindingFlags());
			Func<MemberInfo, bool> predicate;
			if ((predicate = 65.<>O.<0>__Method13121) == null)
			{
				predicate = (65.<>O.<0>__Method13121 = new Func<MemberInfo, bool>(65.Method13121));
			}
			List<MemberInfo> list2 = fieldsAndProperties.Where(predicate).ToList<MemberInfo>();
			foreach (MemberInfo memberInfo in enumerable)
			{
				if (this.GetSerializeCompilerGeneratedMembers() || !memberInfo.IsDefined(typeof(CompilerGeneratedAttribute), true))
				{
					if (list2.Contains(memberInfo))
					{
						list.Add(memberInfo);
					}
					else if (170.Method4332<138>(memberInfo) != null)
					{
						list.Add(memberInfo);
					}
					else if (170.Method4332<149>(memberInfo) != null)
					{
						list.Add(memberInfo);
					}
					else if (dataContractAttribute != null && 170.Method4332<DataMemberAttribute>(memberInfo) != null)
					{
						list.Add(memberInfo);
					}
					else if (objectMemberSerialization == (698)2 && memberInfo.Method6702() == MemberTypes.Field)
					{
						list.Add(memberInfo);
					}
				}
			}
			Type type;
			if (1.Method6716("System.Data.Objects.DataClasses.EntityObject", false, out type))
			{
				list = list.Where(new Func<MemberInfo, bool>(this.ShouldSerializeEntityMember)).ToList<MemberInfo>();
			}
			if (typeof(Exception).IsAssignableFrom(1))
			{
				list = list.Where(new Func<MemberInfo, bool>(65.71.instance.IsNotTargetSite)).ToList<MemberInfo>();
			}
		}
		else
		{
			foreach (MemberInfo memberInfo2 in enumerable)
			{
				FieldInfo fieldInfo = memberInfo2 as FieldInfo;
				if (fieldInfo != null && !fieldInfo.IsStatic)
				{
					list.Add(memberInfo2);
				}
			}
		}
		return list;
	}

	// Token: 0x0600035D RID: 861 RVA: 0x0000A03C File Offset: 0x0000823C
	private bool ShouldSerializeEntityMember(MemberInfo 1)
	{
		PropertyInfo propertyInfo = 1 as PropertyInfo;
		return propertyInfo == null || !propertyInfo.PropertyType.Method6705() || !(propertyInfo.PropertyType.GetGenericTypeDefinition().FullName == "System.Data.Objects.DataClasses.EntityReference`1");
	}

	// Token: 0x0600035E RID: 862 RVA: 0x0000A080 File Offset: 0x00008280
	protected virtual 612 CreateObjectContract(Type 1)
	{
		612 2 = new 612(1);
		this.InitializeContract(2);
		bool 3 = this.GetIgnoreSerializableAttribute();
		2.SetRecoveredType19326946_8948(170.GetObjectMemberSerialization(2.nonNullableUnderlyingType, 3));
		2.RecoveredType17666960.Method3166(this.CreateProperties(2.nonNullableUnderlyingType, 2.GetRecoveredType19326946_8947()));
		Func<string, string> func = null;
		524 attribute = 170.GetAttribute<524>(2.nonNullableUnderlyingType);
		if (attribute != null)
		{
			2.SetNullable6948_8952(attribute.nullable2);
			2.SetNullable6949_8954(attribute.nullable3);
			2.SetNullable6947_8950(attribute.nullable);
			if (attribute.NamingStrategyType != null)
			{
				func = new Func<string, string>(new 65.72
				{
					namingStrategy = 170.GetContainerNamingStrategy(attribute)
				}.ResolveName);
			}
		}
		if (func == null)
		{
			func = new Func<string, string>(this.ResolveExtensionDataName);
		}
		2.Func6964 = func;
		if (2.isInstantiable)
		{
			ConstructorInfo attributeConstructor = this.GetAttributeConstructor(2.nonNullableUnderlyingType);
			if (attributeConstructor != null)
			{
				2.RecoveredType10456962 = 170.GetReflectionDelegateFactory().Method9974(attributeConstructor);
				2.RecoveredType17666961.Method3166(this.CreateConstructorParameters(attributeConstructor, 2.RecoveredType17666960));
			}
			else if (2.GetRecoveredType19326946_8947() == (698)2)
			{
				if (170.IsFullyTrusted())
				{
					2.DefaultCreator = new Func<object>(2.Method8962);
				}
			}
			else if (2.DefaultCreator == null || 2.GetFlag0798_1378())
			{
				ConstructorInfo implicitConstructor = this.GetImplicitConstructor(2.nonNullableUnderlyingType);
				if (implicitConstructor != null)
				{
					2.RecoveredType10456963 = 170.GetReflectionDelegateFactory().Method9974(implicitConstructor);
					2.RecoveredType17666961.Method3166(this.CreateConstructorParameters(implicitConstructor, 2.RecoveredType17666960));
				}
			}
			else if (2.nonNullableUnderlyingType.Method6714())
			{
				ConstructorInfo parameterizedConstructor = this.GetParameterizedConstructor(2.nonNullableUnderlyingType, 2.RecoveredType17666960);
				if (parameterizedConstructor != null)
				{
					2.RecoveredType10456962 = 170.GetReflectionDelegateFactory().Method9974(parameterizedConstructor);
					2.RecoveredType17666961.Method3166(this.CreateConstructorParameters(parameterizedConstructor, 2.RecoveredType17666960));
				}
			}
		}
		MemberInfo extensionDataMemberForType = this.GetExtensionDataMemberForType(2.nonNullableUnderlyingType);
		if (extensionDataMemberForType != null)
		{
			65.SetExtensionDataDelegates(2, extensionDataMemberForType);
		}
		if (Array.IndexOf<string>(65.textArray, 1.FullName) != -1)
		{
			ICollection<437> collection = 2.Method1376();
			437 item;
			if ((item = 65.<>O.<1>__ThrowUnableToSerialize) == null)
			{
				item = (65.<>O.<1>__ThrowUnableToSerialize = new 437(65.ThrowUnableToSerialize));
			}
			collection.Add(item);
		}
		return 2;
	}

	// Token: 0x0600035F RID: 863 RVA: 0x0000A2CE File Offset: 0x000084CE
	private static void ThrowUnableToSerialize(object 1, StreamingContext 2)
	{
		throw new 364("Unable to serialize instance of '{0}'.".Method6825(CultureInfo.InvariantCulture, 1.GetType()));
	}

	// Token: 0x06000360 RID: 864 RVA: 0x0000A2EC File Offset: 0x000084EC
	[return: 241(2)]
	private MemberInfo GetExtensionDataMemberForType(Type 1)
	{
		return this.GetClassHierarchy(2).SelectMany(new Func<Type, IEnumerable<MemberInfo>>(65.71.instance.GetDeclaredPropertiesAndFields)).LastOrDefault(delegate(MemberInfo 1)
		{
			MemberTypes memberTypes = 1.Method6702();
			if (memberTypes != MemberTypes.Property && memberTypes != MemberTypes.Field)
			{
				return false;
			}
			if (!1.IsDefined(typeof(215), false))
			{
				return false;
			}
			if (!143.CanReadMemberValue(1, true))
			{
				throw new 134("Invalid extension data attribute on '{0}'. Member '{1}' must have a getter.".Method6825(CultureInfo.InvariantCulture, 65.GetClrTypeFullName(1.DeclaringType), 1.Name));
			}
			Type type;
			if (143.Method3895(143.GetMemberUnderlyingType(1), typeof(IDictionary<, >), out type))
			{
				Type type2 = type.GetGenericArguments()[0];
				Type type3 = type.GetGenericArguments()[1];
				if (type2.IsAssignableFrom(typeof(string)) && type3.IsAssignableFrom(typeof(226)))
				{
					return true;
				}
			}
			throw new 134("Invalid extension data attribute on '{0}'. Member '{1}' type must implement IDictionary<string, JToken>.".Method6825(CultureInfo.InvariantCulture, 65.GetClrTypeFullName(1.DeclaringType), 1.Name));
		});
	}

	// Token: 0x06000361 RID: 865 RVA: 0x0000A33C File Offset: 0x0000853C
	private static void SetExtensionDataDelegates(612 1, MemberInfo 2)
	{
		65.69 3 = new 65.69();
		3.memberInfo = 2;
		215 4 = 143.Method3911<215>(3.memberInfo);
		if (4 == null)
		{
			return;
		}
		Type memberUnderlyingType = 143.GetMemberUnderlyingType(3.memberInfo);
		Type type;
		143.Method3895(memberUnderlyingType, typeof(IDictionary<, >), out type);
		Type type2 = type.GetGenericArguments()[0];
		Type type3 = type.GetGenericArguments()[1];
		Type 5 = (!143.IsGenericTypeOf(memberUnderlyingType, typeof(IDictionary<, >))) ? memberUnderlyingType : typeof(Dictionary<, >).MakeGenericType(new Type[]
		{
			type2,
			type3
		});
		3.func = 170.GetReflectionDelegateFactory().Method99792<object>(3.memberInfo);
		if (4.ReadData)
		{
			65.70 6 = new 65.70();
			6.extensionDataMember = 3;
			6.action = (143.CanSetMemberValue(6.extensionDataMember.memberInfo, true, false) ? 170.GetReflectionDelegateFactory().Method99832<object>(6.extensionDataMember.memberInfo) : null);
			6.func = 170.GetReflectionDelegateFactory().Method9977<object>(5);
			PropertyInfo property = memberUnderlyingType.GetProperty("Item", BindingFlags.Instance | BindingFlags.Public, null, type3, new Type[]
			{
				type2
			}, null);
			MethodInfo methodInfo = (property != null) ? property.GetSetMethod() : null;
			if (methodInfo == null)
			{
				PropertyInfo property2 = type.GetProperty("Item", BindingFlags.Instance | BindingFlags.Public, null, type3, new Type[]
				{
					type2
				}, null);
				methodInfo = ((property2 != null) ? property2.GetSetMethod() : null);
			}
			6.itemSetter = 170.GetReflectionDelegateFactory().Method9975<object>(methodInfo);
			545 recoveredType12256951_ = new 545(6.SetExtensionDataValue);
			1.SetRecoveredType12256951_8956(recoveredType12256951_);
		}
		if (4.WriteData)
		{
			65.68 7 = new 65.68();
			7.extensionDataMember = 3;
			ConstructorInfo 8 = typeof(65.73<, >).MakeGenericType(new Type[]
			{
				type2,
				type3
			}).GetConstructors().First<ConstructorInfo>();
			7.enumerableConstructor = 170.GetReflectionDelegateFactory().Method9974(8);
			531 recoveredType11756952_ = new 531(7.GetExtensionDataEnumerable);
			1.SetRecoveredType11756952_8958(recoveredType11756952_);
		}
		1.Method8960(type3);
	}

	// Token: 0x06000362 RID: 866 RVA: 0x0000A544 File Offset: 0x00008744
	[return: 241(2)]
	private ConstructorInfo GetAttributeConstructor(Type 1)
	{
		IEnumerator<ConstructorInfo> enumerator = 1.GetConstructors(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).Where(new Func<ConstructorInfo, bool>(65.71.instance.HasJsonConstructorAttribute)).GetEnumerator();
		if (enumerator.MoveNext())
		{
			ConstructorInfo result = enumerator.Current;
			if (enumerator.MoveNext())
			{
				throw new 134("Multiple constructors with the JsonConstructorAttribute.");
			}
			return result;
		}
		else
		{
			if (1 == typeof(Version))
			{
				return 1.GetConstructor(new Type[]
				{
					typeof(int),
					typeof(int),
					typeof(int),
					typeof(int)
				});
			}
			return null;
		}
	}

	// Token: 0x06000363 RID: 867 RVA: 0x0000A5EC File Offset: 0x000087EC
	[return: 241(2)]
	private ConstructorInfo GetParameterizedConstructor(Type 1, 663 2)
	{
		IEnumerator<ConstructorInfo> enumerator = ((IEnumerable<ConstructorInfo>)1.GetConstructors()).GetEnumerator();
		if (enumerator.MoveNext())
		{
			ConstructorInfo constructorInfo = enumerator.Current;
			if (!enumerator.MoveNext())
			{
				ParameterInfo[] parameters = constructorInfo.GetParameters();
				if (parameters.Length != 0)
				{
					foreach (ParameterInfo parameterInfo in parameters)
					{
						666 matchingProperty = this.GetMatchingProperty(2, parameterInfo.Name, parameterInfo.ParameterType);
						if (matchingProperty == null || matchingProperty.GetFlag7772_9901())
						{
							return null;
						}
					}
					return constructorInfo;
				}
			}
		}
		return null;
	}

	// Token: 0x06000364 RID: 868 RVA: 0x0000A66C File Offset: 0x0000886C
	[return: 241(2)]
	private ConstructorInfo GetImplicitConstructor(Type 1)
	{
		ConstructorInfo[] constructors = 1.GetConstructors(BindingFlags.Instance | BindingFlags.Public);
		if (constructors.Length == 1)
		{
			return constructors[0];
		}
		return null;
	}

	// Token: 0x06000365 RID: 869 RVA: 0x0000A690 File Offset: 0x00008890
	protected virtual IList<666> CreateConstructorParameters(ConstructorInfo 1, 663 2)
	{
		ParameterInfo[] parameters = 1.GetParameters();
		663 3 = new 663(1.DeclaringType);
		foreach (ParameterInfo parameterInfo in parameters)
		{
			if (parameterInfo.Name != null)
			{
				666 matchingProperty = this.GetMatchingProperty(2, parameterInfo.Name, parameterInfo.ParameterType);
				if (matchingProperty != null || parameterInfo.Name != null)
				{
					666 4 = this.CreatePropertyFromConstructorParameter(matchingProperty, parameterInfo);
					if (4 != null)
					{
						3.Method9818(4);
					}
				}
			}
		}
		return 3;
	}

	// Token: 0x06000366 RID: 870 RVA: 0x0000A704 File Offset: 0x00008904
	[return: 241(2)]
	private 666 GetMatchingProperty(663 1, string 2, Type 3)
	{
		if (2 == null)
		{
			return null;
		}
		666 4 = 1.Method9819(2);
		if (4 == null || 4.GetType7762_9891() != 3)
		{
			return null;
		}
		return 4;
	}

	// Token: 0x06000367 RID: 871 RVA: 0x0000A734 File Offset: 0x00008934
	protected virtual 666 CreatePropertyFromConstructorParameter([241(2)] 666 1, ParameterInfo 2)
	{
		666 3 = new 666();
		3.Method9892(2.ParameterType);
		3.SetRecoveredType13917768_9890(new 662(2));
		bool flag;
		this.SetPropertySettingsFromAttributes(3, 2, 2.Name, 2.Member.DeclaringType, (698)0, out flag);
		3.SetFlag7771_9900(false);
		3.SetFlag7772_9902(true);
		if (1 != null)
		{
			3.Method9880((3.GetText7760_9879() != 2.Name) ? 3.GetText7760_9879() : 1.GetText7760_9879());
			3.SetJsonConverter7769_9894(3.GetJsonConverter7769_9893() ?? 1.GetJsonConverter7769_9893());
			if (!3.flag2 && 1.flag2)
			{
				3.Method9906(1.Method9905());
			}
			666 4 = 3;
			896? nullable = 3.nullable2;
			4.nullable2 = ((nullable != null) ? nullable : 1.nullable2);
			666 5 = 3;
			bool? nullable7774_ = 3.GetNullable7774_9911();
			5.SetNullable7774_9912((nullable7774_ != null) ? nullable7774_ : 1.GetNullable7774_9911());
			666 6 = 3;
			240? nullable7775_ = 3.GetNullable7775_9913();
			6.SetNullable7775_9914((nullable7775_ != null) ? nullable7775_ : 1.GetNullable7775_9913());
			666 7 = 3;
			50? nullable7776_ = 3.GetNullable7776_9915();
			7.SetNullable7776_9916((nullable7776_ != null) ? nullable7776_ : 1.GetNullable7776_9915());
			666 8 = 3;
			894? nullable7777_ = 3.GetNullable7777_9917();
			8.SetNullable7777_9918((nullable7777_ != null) ? nullable7777_ : 1.GetNullable7777_9917());
			666 9 = 3;
			243? nullable7778_ = 3.GetNullable7778_9919();
			9.SetNullable7778_9920((nullable7778_ != null) ? nullable7778_ : 1.GetNullable7778_9919());
			666 10 = 3;
			933? nullable7779_ = 3.GetNullable7779_9921();
			10.SetNullable7779_9922((nullable7779_ != null) ? nullable7779_ : 1.GetNullable7779_9921());
		}
		return 3;
	}

	// Token: 0x06000368 RID: 872 RVA: 0x0000A8CC File Offset: 0x00008ACC
	[return: 241(2)]
	protected virtual 214 ResolveContractConverter(Type 1)
	{
		return 170.GetJsonConverter(1);
	}

	// Token: 0x06000369 RID: 873 RVA: 0x0000A8D4 File Offset: 0x00008AD4
	private Func<object> GetDefaultCreator(Type 1)
	{
		return 170.GetReflectionDelegateFactory().Method9977<object>(1);
	}

	// Token: 0x0600036A RID: 874 RVA: 0x0000A8E4 File Offset: 0x00008AE4
	private void InitializeContract(902 1)
	{
		129 attribute = 170.GetAttribute<129>(1.nonNullableUnderlyingType);
		if (attribute != null)
		{
			1.SetIsReference(attribute.isReference);
		}
		else
		{
			DataContractAttribute dataContractAttribute = 170.GetDataContractAttribute(1.nonNullableUnderlyingType);
			if (dataContractAttribute != null && dataContractAttribute.IsReference)
			{
				1.SetIsReference(new bool?(true));
			}
		}
		1.Converter = this.ResolveContractConverter(1.nonNullableUnderlyingType);
		1.InternalConverter = 158.Method3855(65.jsonConverterArray, 1.nonNullableUnderlyingType);
		if (1.isInstantiable && (143.HasDefaultConstructor(1.GetCreatedType(), true) || 1.GetCreatedType().Method6714()))
		{
			1.DefaultCreator = this.GetDefaultCreator(1.GetCreatedType());
			1.SetFlag0798_1379(!1.GetCreatedType().Method6714() && 143.Method3888(1.GetCreatedType()) == null);
		}
		this.ResolveCallbackMethods(1, 1.nonNullableUnderlyingType);
	}

	// Token: 0x0600036B RID: 875 RVA: 0x0000A9C4 File Offset: 0x00008BC4
	private void ResolveCallbackMethods(902 1, Type 2)
	{
		List<437> list;
		List<437> list2;
		List<437> list3;
		List<437> list4;
		List<791> list5;
		this.GetCallbackMethodsForType(2, out list, out list2, out list3, out list4, out list5);
		if (list != null)
		{
			1.Method1376().Method3166(list);
		}
		if (list2 != null)
		{
			1.Method1375().Method3166(list2);
		}
		if (list3 != null)
		{
			1.Method1374().Method3166(list3);
		}
		if (list4 != null)
		{
			1.Method1373().Method3166(list4);
		}
		if (list5 != null)
		{
			1.GetOnErrorCallbacks().Method3166(list5);
		}
	}

	// Token: 0x0600036C RID: 876 RVA: 0x0000AA30 File Offset: 0x00008C30
	private void GetCallbackMethodsForType(Type 1, [241(new byte[]
	{
		2,
		1
	})] out List<437> 2, [241(new byte[]
	{
		2,
		1
	})] out List<437> 3, [241(new byte[]
	{
		2,
		1
	})] out List<437> 4, [241(new byte[]
	{
		2,
		1
	})] out List<437> 5, [241(new byte[]
	{
		2,
		1
	})] out List<791> 6)
	{
		2 = null;
		3 = null;
		4 = null;
		5 = null;
		6 = null;
		foreach (Type type in this.GetClassHierarchy(1))
		{
			MethodInfo 7 = null;
			MethodInfo 8 = null;
			MethodInfo 9 = null;
			MethodInfo 10 = null;
			MethodInfo 11 = null;
			bool flag = 65.IsSerializingCallbackIgnored(type);
			bool flag2 = 65.IsDeserializedCallbackIgnored(type);
			foreach (MethodInfo methodInfo in type.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
			{
				if (!methodInfo.ContainsGenericParameters)
				{
					Type type2 = null;
					ParameterInfo[] parameters = methodInfo.GetParameters();
					if (!flag && 65.IsValidCallback(methodInfo, parameters, typeof(OnSerializingAttribute), 7, ref type2))
					{
						2 = (2 ?? new List<437>());
						2.Add(902.CreateSerializationCallback(methodInfo));
						7 = methodInfo;
					}
					if (65.IsValidCallback(methodInfo, parameters, typeof(OnSerializedAttribute), 8, ref type2))
					{
						3 = (3 ?? new List<437>());
						3.Add(902.CreateSerializationCallback(methodInfo));
						8 = methodInfo;
					}
					if (65.IsValidCallback(methodInfo, parameters, typeof(OnDeserializingAttribute), 9, ref type2))
					{
						4 = (4 ?? new List<437>());
						4.Add(902.CreateSerializationCallback(methodInfo));
						9 = methodInfo;
					}
					if (!flag2 && 65.IsValidCallback(methodInfo, parameters, typeof(OnDeserializedAttribute), 10, ref type2))
					{
						5 = (5 ?? new List<437>());
						5.Add(902.CreateSerializationCallback(methodInfo));
						10 = methodInfo;
					}
					if (65.IsValidCallback(methodInfo, parameters, typeof(237), 11, ref type2))
					{
						6 = (6 ?? new List<791>());
						6.Add(902.CreateErrorCallback(methodInfo));
						11 = methodInfo;
					}
				}
			}
		}
	}

	// Token: 0x0600036D RID: 877 RVA: 0x0000AC20 File Offset: 0x00008E20
	private static bool IsConcurrentOrObservableCollection(Type 1)
	{
		if (1.Method6705())
		{
			string fullName = 1.GetGenericTypeDefinition().FullName;
			if (fullName == "System.Collections.Concurrent.ConcurrentQueue`1" || fullName == "System.Collections.Concurrent.ConcurrentStack`1" || fullName == "System.Collections.Concurrent.ConcurrentBag`1" || fullName == "System.Collections.Concurrent.ConcurrentDictionary`2" || fullName == "System.Collections.ObjectModel.ObservableCollection`1")
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600036E RID: 878 RVA: 0x0000AC85 File Offset: 0x00008E85
	private static bool IsDeserializedCallbackIgnored(Type 1)
	{
		return 65.IsConcurrentOrObservableCollection(1) || (1.Name == "FSharpSet`1" || 1.Name == "FSharpMap`2");
	}

	// Token: 0x0600036F RID: 879 RVA: 0x0000AC85 File Offset: 0x00008E85
	private static bool IsSerializingCallbackIgnored(Type 1)
	{
		return 65.IsConcurrentOrObservableCollection(1) || (1.Name == "FSharpSet`1" || 1.Name == "FSharpMap`2");
	}

	// Token: 0x06000370 RID: 880 RVA: 0x0000ACB8 File Offset: 0x00008EB8
	private List<Type> GetClassHierarchy(Type 1)
	{
		List<Type> list = new List<Type>();
		Type type = 1;
		while (type != null && type != typeof(object))
		{
			list.Add(type);
			type = type.Method6707();
		}
		list.Reverse();
		return list;
	}

	// Token: 0x06000371 RID: 881 RVA: 0x0000AD00 File Offset: 0x00008F00
	protected virtual 493 CreateDictionaryContract(Type 1)
	{
		493 2 = new 493(1);
		this.InitializeContract(2);
		129 3 = 170.Method4332<129>(1);
		if (((3 != null) ? 3.NamingStrategyType : null) != null)
		{
			2.Func4189 = new Func<string, string>(new 65.66
			{
				namingStrategy = 170.GetContainerNamingStrategy(3)
			}.ResolveName);
		}
		else
		{
			2.Func4189 = new Func<string, string>(this.ResolveDictionaryKey);
		}
		ConstructorInfo attributeConstructor = this.GetAttributeConstructor(2.nonNullableUnderlyingType);
		if (attributeConstructor != null)
		{
			ParameterInfo[] parameters = attributeConstructor.GetParameters();
			Type type = (2.GetType4177_5365() != null && 2.GetType4178_5366() != null) ? typeof(IEnumerable<>).MakeGenericType(new Type[]
			{
				typeof(KeyValuePair<, >).MakeGenericType(new Type[]
				{
					2.GetType4177_5365(),
					2.GetType4178_5366()
				})
			}) : typeof(IDictionary);
			if (parameters.Length == 0)
			{
				2.SetFlag4188_5371(false);
			}
			else
			{
				if (parameters.Length != 1 || !type.IsAssignableFrom(parameters[0].ParameterType))
				{
					throw new 134("Constructor for '{0}' must have no parameters or a single parameter that implements '{1}'.".Method6825(CultureInfo.InvariantCulture, 2.GetUnderlyingType(), type));
				}
				2.SetFlag4188_5371(true);
			}
			2.RecoveredType10454191 = 170.GetReflectionDelegateFactory().Method9974(attributeConstructor);
		}
		return 2;
	}

	// Token: 0x06000372 RID: 882 RVA: 0x0000AE58 File Offset: 0x00009058
	protected virtual 126 CreateArrayContract(Type 1)
	{
		126 2 = new 126(1);
		this.InitializeContract(2);
		ConstructorInfo attributeConstructor = this.GetAttributeConstructor(2.nonNullableUnderlyingType);
		if (attributeConstructor != null)
		{
			ParameterInfo[] parameters = attributeConstructor.GetParameters();
			Type type = (2.GetCollectionItemType() != null) ? typeof(IEnumerable<>).MakeGenericType(new Type[]
			{
				2.GetCollectionItemType()
			}) : typeof(IEnumerable);
			if (parameters.Length == 0)
			{
				2.SetFlag4651_5835(false);
			}
			else
			{
				if (parameters.Length != 1 || !type.IsAssignableFrom(parameters[0].ParameterType))
				{
					throw new 134("Constructor for '{0}' must have no parameters or a single parameter that implements '{1}'.".Method6825(CultureInfo.InvariantCulture, 2.GetUnderlyingType(), type));
				}
				2.SetFlag4651_5835(true);
			}
			2.RecoveredType10454653 = 170.GetReflectionDelegateFactory().Method9974(attributeConstructor);
		}
		return 2;
	}

	// Token: 0x06000373 RID: 883 RVA: 0x0000AF24 File Offset: 0x00009124
	protected virtual 806 CreatePrimitiveContract(Type 1)
	{
		806 2 = new 806(1);
		this.InitializeContract(2);
		return 2;
	}

	// Token: 0x06000374 RID: 884 RVA: 0x0000AF40 File Offset: 0x00009140
	protected virtual 731 CreateLinqContract(Type 1)
	{
		731 2 = new 731(1);
		this.InitializeContract(2);
		return 2;
	}

	// Token: 0x06000375 RID: 885 RVA: 0x0000AF5C File Offset: 0x0000915C
	protected virtual 515 CreateISerializableContract(Type 1)
	{
		515 2 = new 515(1);
		this.InitializeContract(2);
		if (2.isInstantiable)
		{
			ConstructorInfo constructor = 2.nonNullableUnderlyingType.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
			{
				typeof(SerializationInfo),
				typeof(StreamingContext)
			}, null);
			if (constructor != null)
			{
				516<object> recoveredType = 170.GetReflectionDelegateFactory().Method9974(constructor);
				2.RecoveredType10454622 = recoveredType;
			}
		}
		return 2;
	}

	// Token: 0x06000376 RID: 886 RVA: 0x0000AFCC File Offset: 0x000091CC
	protected virtual 390 CreateDynamicContract(Type 1)
	{
		390 2 = new 390(4);
		this.InitializeContract(2);
		129 3 = 170.Method4332<129>(4);
		if (((3 != null) ? 3.NamingStrategyType : null) != null)
		{
			65.67 dynamicNameResolver = new 65.67();
			dynamicNameResolver.namingStrategy = 170.GetContainerNamingStrategy(3);
			2.Func1574 = ((string 1) => dynamicNameResolver.namingStrategy.GetDictionaryKey(1));
		}
		else
		{
			2.Func1574 = new Func<string, string>(this.ResolveDictionaryKey);
		}
		2.GetRecoveredType17661570_2298().Method3166(this.CreateProperties(4, (698)0));
		return 2;
	}

	// Token: 0x06000377 RID: 887 RVA: 0x0000B060 File Offset: 0x00009260
	protected virtual 809 CreateStringContract(Type 1)
	{
		809 2 = new 809(1);
		this.InitializeContract(2);
		return 2;
	}

	// Token: 0x06000378 RID: 888 RVA: 0x0000B07C File Offset: 0x0000927C
	protected virtual 902 CreateContract(Type 1)
	{
		Type type = 143.GetNonByRefType(1);
		if (65.IsJsonPrimitiveType(type))
		{
			return this.CreatePrimitiveContract(1);
		}
		type = 143.GetNonNullableType(type);
		129 attribute = 170.GetAttribute<129>(type);
		if (attribute is 524)
		{
			return this.CreateObjectContract(1);
		}
		if (attribute is 702)
		{
			return this.CreateArrayContract(1);
		}
		if (attribute is 680)
		{
			return this.CreateDictionaryContract(1);
		}
		if (type == typeof(226) || type.IsSubclassOf(typeof(226)))
		{
			return this.CreateLinqContract(1);
		}
		if (418.Method3167(type))
		{
			return this.CreateDictionaryContract(1);
		}
		if (typeof(IEnumerable).IsAssignableFrom(type))
		{
			return this.CreateArrayContract(1);
		}
		if (65.CanConvertToString(type))
		{
			return this.CreateStringContract(1);
		}
		if (!this.GetIgnoreSerializableInterface() && typeof(ISerializable).IsAssignableFrom(type) && 170.IsSerializable(type))
		{
			return this.CreateISerializableContract(1);
		}
		if (typeof(IDynamicMetaObjectProvider).IsAssignableFrom(type))
		{
			return this.CreateDynamicContract(1);
		}
		if (65.IsIConvertible(type))
		{
			return this.CreatePrimitiveContract(type);
		}
		return this.CreateObjectContract(1);
	}

	// Token: 0x06000379 RID: 889 RVA: 0x0000B1A0 File Offset: 0x000093A0
	internal static bool IsJsonPrimitiveType(Type 1)
	{
		723 2 = 358.Method1490(1);
		return 2 != 723.Empty && 2 != 723.Object;
	}

	// Token: 0x0600037A RID: 890 RVA: 0x0000B1C0 File Offset: 0x000093C0
	internal static bool IsIConvertible(Type 1)
	{
		return (typeof(IConvertible).IsAssignableFrom(1) || (143.IsNullableType(1) && typeof(IConvertible).IsAssignableFrom(Nullable.GetUnderlyingType(1)))) && !typeof(226).IsAssignableFrom(1);
	}

	// Token: 0x0600037B RID: 891 RVA: 0x0000B214 File Offset: 0x00009414
	internal static bool CanConvertToString(Type 1)
	{
		TypeConverter typeConverter;
		return 170.CanTypeDescriptorConvertString(1, out typeConverter) || (1 == typeof(Type) || 1.IsSubclassOf(typeof(Type)));
	}

	// Token: 0x0600037C RID: 892 RVA: 0x0000B254 File Offset: 0x00009454
	private static bool IsValidCallback(MethodInfo 1, ParameterInfo[] 2, Type 3, [241(2)] MethodInfo 4, [241(2)] ref Type 5)
	{
		if (!1.IsDefined(3, false))
		{
			return false;
		}
		if (4 != null)
		{
			throw new 134("Invalid attribute. Both '{0}' and '{1}' in type '{2}' have '{3}'.".Method6825(CultureInfo.InvariantCulture, 1, 4, 65.GetClrTypeFullName(1.DeclaringType), 3));
		}
		if (5 != null)
		{
			throw new 134("Invalid Callback. Method '{3}' in type '{2}' has both '{0}' and '{1}'.".Method6825(CultureInfo.InvariantCulture, 5, 3, 65.GetClrTypeFullName(1.DeclaringType), 1));
		}
		if (1.IsVirtual)
		{
			throw new 134("Virtual Method '{0}' of type '{1}' cannot be marked with '{2}' attribute.".Method6825(CultureInfo.InvariantCulture, 1, 65.GetClrTypeFullName(1.DeclaringType), 3));
		}
		if (1.ReturnType != typeof(void))
		{
			throw new 134("Serialization Callback '{1}' in type '{0}' must return void.".Method6825(CultureInfo.InvariantCulture, 65.GetClrTypeFullName(1.DeclaringType), 1));
		}
		if (3 == typeof(237))
		{
			if (2 == null || 2.Length != 2 || 2[0].ParameterType != typeof(StreamingContext) || 2[1].ParameterType != typeof(236))
			{
				throw new 134("Serialization Error Callback '{1}' in type '{0}' must have two parameters of type '{2}' and '{3}'.".Method6825(CultureInfo.InvariantCulture, 65.GetClrTypeFullName(1.DeclaringType), 1, typeof(StreamingContext), typeof(236)));
			}
		}
		else if (2 == null || 2.Length != 1 || 2[0].ParameterType != typeof(StreamingContext))
		{
			throw new 134("Serialization Callback '{1}' in type '{0}' must have a single parameter of type '{2}'.".Method6825(CultureInfo.InvariantCulture, 65.GetClrTypeFullName(1.DeclaringType), 1, typeof(StreamingContext)));
		}
		5 = 3;
		return true;
	}

	// Token: 0x0600037D RID: 893 RVA: 0x0000B402 File Offset: 0x00009602
	internal static string GetClrTypeFullName(Type 1)
	{
		if (1.Method6706() || !1.Method6703())
		{
			return 1.FullName;
		}
		return "{0}.{1}".Method6825(CultureInfo.InvariantCulture, 1.Namespace, 1.Name);
	}

	// Token: 0x0600037E RID: 894 RVA: 0x0000B438 File Offset: 0x00009638
	protected virtual IList<666> CreateProperties(Type 1, 698 2)
	{
		List<MemberInfo> serializableMembers = this.GetSerializableMembers(1);
		if (serializableMembers == null)
		{
			throw new 364("Null collection of serializable members returned.");
		}
		587 3 = this.GetNameTable();
		663 4 = new 663(1);
		foreach (MemberInfo 5 in serializableMembers)
		{
			666 6 = this.CreateProperty(5, 2);
			if (6 != null)
			{
				587 obj = 3;
				lock (obj)
				{
					6.Method9880(3.Method7975(6.GetText7760_9879()));
				}
				4.Method9818(6);
			}
		}
		return 4.OrderBy(new Func<666, int>(65.71.instance.GetPropertyOrder)).ToList<666>();
	}

	// Token: 0x0600037F RID: 895 RVA: 0x0000B510 File Offset: 0x00009710
	internal virtual 587 GetNameTable()
	{
		return this.nameTable;
	}

	// Token: 0x06000380 RID: 896 RVA: 0x0000B518 File Offset: 0x00009718
	protected virtual 569 CreateMemberValueProvider(MemberInfo 1)
	{
		if (this.UsesDynamicCodeGeneration())
		{
			return new 592(1);
		}
		return new 61(1);
	}

	// Token: 0x06000381 RID: 897 RVA: 0x0000B530 File Offset: 0x00009730
	protected virtual 666 CreateProperty(MemberInfo 1, 698 2)
	{
		666 3 = new 666();
		3.Method9892(143.GetMemberUnderlyingType(1));
		3.SetType7764_9882(1.DeclaringType);
		3.SetRecoveredType13467767_9888(this.CreateMemberValueProvider(1));
		3.SetRecoveredType13917768_9890(new 662(1));
		bool flag;
		this.SetPropertySettingsFromAttributes(3, 1, 1.Name, 1.DeclaringType, 2, out flag);
		if (2 != (698)2)
		{
			3.SetFlag7771_9900(143.CanReadMemberValue(1, flag));
			3.SetFlag7772_9902(143.CanSetMemberValue(1, flag, 3.GetFlag7773_9903()));
		}
		else
		{
			3.SetFlag7771_9900(true);
			3.SetFlag7772_9902(true);
		}
		if (!this.GetIgnoreShouldSerializeMembers())
		{
			3.Predicate7788 = this.CreateShouldSerializeTest(1);
		}
		if (!this.GetIgnoreIsSpecifiedMembers())
		{
			this.SetPropertyIsSpecifiedActions(3, 1, flag);
		}
		return 3;
	}

	// Token: 0x06000382 RID: 898 RVA: 0x0000B5E8 File Offset: 0x000097E8
	private void SetPropertySettingsFromAttributes(666 1, object 2, string 3, Type 4, 698 5, out bool 6)
	{
		bool dataContractAttribute = 170.GetDataContractAttribute(4) != null;
		MemberInfo memberInfo = 2 as MemberInfo;
		DataMemberAttribute dataMemberAttribute = (!dataContractAttribute || !(memberInfo != null)) ? null : 170.GetDataMemberAttribute(memberInfo);
		138 7 = 170.Method4332<138>(2);
		bool flag = 170.Method4332<149>(2) != null;
		string 8;
		bool 9;
		if (7 != null && 7.PropertyName != null)
		{
			8 = 7.PropertyName;
			9 = true;
		}
		else if (dataMemberAttribute != null && dataMemberAttribute.Name != null)
		{
			8 = dataMemberAttribute.Name;
			9 = true;
		}
		else
		{
			8 = 3;
			9 = false;
		}
		129 10 = 170.Method4332<129>(4);
		136 11 = (((7 != null) ? 7.NamingStrategyType : null) != null) ? 170.CreateNamingStrategyInstance(7.NamingStrategyType, 7.NamingStrategyParameters) : ((!(((10 != null) ? 10.NamingStrategyType : null) != null)) ? this.NamingStrategy : 170.GetContainerNamingStrategy(10));
		if (11 != null)
		{
			1.Method9880(11.GetPropertyName(8, 9));
		}
		else
		{
			1.Method9880(this.ResolvePropertyName(8));
		}
		1.SetText7766_9886(3);
		bool flag2 = false;
		if (7 != null)
		{
			1.nullable2 = 7.required;
			1.SetNullable7765_9884(7.order);
			1.SetNullable7776_9916(7.defaultValueHandling);
			flag2 = true;
			1.SetNullable7775_9914(7.nullValueHandling);
			1.SetNullable7777_9918(7.referenceLoopHandling);
			1.SetNullable7778_9920(7.objectCreationHandling);
			1.SetNullable7779_9922(7.typeNameHandling);
			1.SetNullable7774_9912(7.isReference);
			1.SetNullable7785_9926(7.itemIsReference);
			1.SetJsonConverter7784_9924((7.ItemConverterType != null) ? 170.CreateJsonConverterInstance(7.ItemConverterType, 7.ItemConverterParameters) : null);
			1.SetNullable7787_9930(7.itemReferenceLoopHandling);
			1.SetNullable7786_9928(7.itemTypeNameHandling);
		}
		else
		{
			1.SetNullable7775_9914(null);
			1.SetNullable7777_9918(null);
			1.SetNullable7778_9920(null);
			1.SetNullable7779_9922(null);
			1.SetNullable7774_9912(null);
			1.SetNullable7785_9926(null);
			1.SetJsonConverter7784_9924(null);
			1.SetNullable7787_9930(null);
			1.SetNullable7786_9928(null);
			if (dataMemberAttribute != null)
			{
				1.nullable2 = new 896?(dataMemberAttribute.IsRequired ? ((896)1) : ((896)0));
				1.SetNullable7765_9884((dataMemberAttribute.Order != -1) ? new int?(dataMemberAttribute.Order) : null);
				1.SetNullable7776_9916((!dataMemberAttribute.EmitDefaultValue) ? new 50?((50)1) : null);
				flag2 = true;
			}
		}
		if (flag)
		{
			1.nullable2 = new 896?((896)2);
			flag2 = true;
		}
		1.SetFlag7773_9904(flag2);
		bool flag3 = 170.Method4332<135>(2) != null || 170.Method4332<215>(2) != null || 170.IsNonSerializable(2);
		if (5 != (698)1)
		{
			bool flag4 = 170.Method4332<IgnoreDataMemberAttribute>(2) != null;
			1.SetFlag7770_9898(flag3 || flag4);
		}
		else
		{
			1.SetFlag7770_9898(flag3 || !flag2);
		}
		1.SetJsonConverter7769_9894(170.GetJsonConverter(2));
		DefaultValueAttribute defaultValueAttribute = 170.Method4332<DefaultValueAttribute>(2);
		if (defaultValueAttribute != null)
		{
			1.Method9906(defaultValueAttribute.Value);
		}
		6 = false;
		if ((this.GetBindingFlags() & BindingFlags.NonPublic) == BindingFlags.NonPublic)
		{
			6 = true;
		}
		if (flag2)
		{
			6 = true;
		}
		if (5 == (698)2)
		{
			6 = true;
		}
	}

	// Token: 0x06000383 RID: 899 RVA: 0x0000B934 File Offset: 0x00009B34
	[return: 241(new byte[]
	{
		2,
		1
	})]
	private Predicate<object> CreateShouldSerializeTest(MemberInfo 1)
	{
		65.75 2 = new 65.75();
		MethodInfo method = 1.DeclaringType.GetMethod("ShouldSerialize" + 1.Name, 143.typeArray);
		if (method == null || method.ReturnType != typeof(bool))
		{
			return null;
		}
		2.shouldSerializeMethod = 170.GetReflectionDelegateFactory().Method9975<object>(method);
		return new Predicate<object>(2.ShouldSerialize);
	}

	// Token: 0x06000384 RID: 900 RVA: 0x0000B9A8 File Offset: 0x00009BA8
	private void SetPropertyIsSpecifiedActions(666 1, MemberInfo 2, bool 3)
	{
		65.76 4 = new 65.76();
		MemberInfo memberInfo = 2.DeclaringType.GetProperty(2.Name + "Specified", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		if (memberInfo == null)
		{
			memberInfo = 2.DeclaringType.GetField(2.Name + "Specified", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		}
		if (!(memberInfo == null) && !(143.GetMemberUnderlyingType(memberInfo) != typeof(bool)))
		{
			4.func = 170.GetReflectionDelegateFactory().Method99792<object>(memberInfo);
			1.Predicate7790 = new Predicate<object>(4.IsSpecified);
			if (143.CanSetMemberValue(memberInfo, 3, false))
			{
				1.Action7791 = 170.GetReflectionDelegateFactory().Method99832<object>(memberInfo);
			}
		}
	}

	// Token: 0x06000385 RID: 901 RVA: 0x0000BA5E File Offset: 0x00009C5E
	protected virtual string ResolvePropertyName(string 1)
	{
		if (this.NamingStrategy != null)
		{
			return this.NamingStrategy.GetPropertyName(1, false);
		}
		return 1;
	}

	// Token: 0x06000386 RID: 902 RVA: 0x0000BA77 File Offset: 0x00009C77
	protected virtual string ResolveExtensionDataName(string 1)
	{
		if (this.NamingStrategy != null)
		{
			return this.NamingStrategy.GetExtensionDataName(1);
		}
		return 1;
	}

	// Token: 0x06000387 RID: 903 RVA: 0x0000BA8F File Offset: 0x00009C8F
	protected virtual string ResolveDictionaryKey(string 1)
	{
		if (this.NamingStrategy != null)
		{
			return this.NamingStrategy.GetDictionaryKey(1);
		}
		return this.ResolvePropertyName(1);
	}

	// Token: 0x06000388 RID: 904 RVA: 0x0000BAAD File Offset: 0x00009CAD
	public string GetResolvedPropertyName(string 1)
	{
		return this.ResolvePropertyName(1);
	}

	// Token: 0x04000365 RID: 869
	private static readonly 733 instance = new 65();

	// Token: 0x04000366 RID: 870
	private static readonly string[] textArray = new string[]
	{
		"System.IO.DriveInfo",
		"System.IO.FileInfo",
		"System.IO.DirectoryInfo"
	};

	// Token: 0x04000367 RID: 871
	private static readonly 214[] jsonConverterArray = new 214[]
	{
		new 82(),
		new 86(),
		new 986(),
		new 36(),
		new 605(),
		new 396(),
		new 52(),
		new 176(),
		new 807(),
		new 895()
	};

	// Token: 0x04000368 RID: 872
	private readonly 587 nameTable = new 587();

	// Token: 0x04000369 RID: 873
	private readonly 482<Type, 902> contractCache;

	// Token: 0x0400036A RID: 874
	private BindingFlags bindingFlags2;

	// Token: 0x0400036B RID: 875
	private bool serializeCompilerGeneratedMembers;

	// Token: 0x0400036C RID: 876
	private bool ignoreSerializableInterface;

	// Token: 0x0400036D RID: 877
	private bool ignoreSerializableAttribute;

	// Token: 0x0400036E RID: 878
	private bool ignoreIsSpecifiedMembers;

	// Token: 0x0400036F RID: 879
	private bool ignoreShouldSerializeMembers;

	// Token: 0x04000370 RID: 880
	[241(2)]
	private 136 namingStrategyValue;

	// Token: 0x0200009A RID: 154
	public sealed class 75
	{
		// Token: 0x0600038A RID: 906 RVA: 0x0000BB4F File Offset: 0x00009D4F
		internal bool ShouldSerialize(object 1)
		{
			return (bool)this.shouldSerializeMethod(1, Array.Empty<object>());
		}

		// Token: 0x04000371 RID: 881
		[241(new byte[]
		{
			0,
			1,
			2
		})]
		public 431<object, object> shouldSerializeMethod;
	}

	// Token: 0x0200009B RID: 155
	[242(0)]
	public sealed class 73<[241(2)] TItem, [241(2)] TItem2> : IEnumerable<KeyValuePair<object, object>>, IEnumerable
	{
		// Token: 0x0600038C RID: 908 RVA: 0x0000BB67 File Offset: 0x00009D67
		public 73([241(new byte[]
		{
			1,
			0,
			1,
			1
		})] IEnumerable<KeyValuePair<TItem, TItem2>> 1)
		{
			756.Method12216(1, "e");
			this._iEnumerable10192 = 1;
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0000BB81 File Offset: 0x00009D81
		[return: 241(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		public IEnumerator<KeyValuePair<object, object>> GetEnumerator()
		{
			return new 65.73<TItem, TItem2>.74(0)
			{
				_recoveredType239810190 = this
			};
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0000BB90 File Offset: 0x00009D90
		[242(1)]
		private IEnumerator Method13093()
		{
			return this.GetEnumerator();
		}

		// Token: 0x0600038F RID: 911 RVA: 0x0000BB98 File Offset: 0x00009D98
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.Method13093();
		}

		// Token: 0x04000372 RID: 882
		[241(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		private readonly IEnumerable<KeyValuePair<TItem, TItem2>> _iEnumerable10192;

		// Token: 0x0200009C RID: 156
		public sealed class 74 : IEnumerator<KeyValuePair<object, object>>, IDisposable, IEnumerator
		{
			// Token: 0x06000390 RID: 912 RVA: 0x0000BBA0 File Offset: 0x00009DA0
			[DebuggerHidden]
			public 74(int 1)
			{
				this._number10188 = 1;
			}

			// Token: 0x06000391 RID: 913 RVA: 0x0000BBB0 File Offset: 0x00009DB0
			[DebuggerHidden]
			private void Method13088()
			{
				int number = this._number10188;
				if (number == -3 || number == 1)
				{
					try
					{
					}
					finally
					{
						this.Method13089();
					}
				}
			}

			// Token: 0x06000392 RID: 914 RVA: 0x0000BBE8 File Offset: 0x00009DE8
			void IDisposable.Dispose()
			{
				this.Method13088();
			}

			// Token: 0x06000393 RID: 915 RVA: 0x0000BBF0 File Offset: 0x00009DF0
			private bool MoveNext()
			{
				bool result;
				try
				{
					int number = this._number10188;
					65.73<TItem, TItem2> recoveredType = this._recoveredType239810190;
					if (number != 0)
					{
						if (number != 1)
						{
							return false;
						}
						this._number10188 = -3;
					}
					else
					{
						this._number10188 = -1;
						this._iEnumerator10191 = recoveredType._iEnumerable10192.GetEnumerator();
						this._number10188 = -3;
					}
					if (this._iEnumerator10191.MoveNext())
					{
						KeyValuePair<TItem, TItem2> keyValuePair = this._iEnumerator10191.Current;
						this._keyValuePair10189 = new KeyValuePair<object, object>(keyValuePair.Key, keyValuePair.Value);
						this._number10188 = 1;
						result = true;
					}
					else
					{
						this.Method13089();
						this._iEnumerator10191 = null;
						result = false;
					}
				}
				catch
				{
					this.Method13088();
					throw;
				}
				return result;
			}

			// Token: 0x06000394 RID: 916 RVA: 0x0000BCB8 File Offset: 0x00009EB8
			bool IEnumerator.MoveNext()
			{
				return this.MoveNext();
			}

			// Token: 0x06000395 RID: 917 RVA: 0x0000BCC0 File Offset: 0x00009EC0
			private void Method13089()
			{
				this._number10188 = -1;
				if (this._iEnumerator10191 != null)
				{
					this._iEnumerator10191.Dispose();
				}
			}

			// Token: 0x06000396 RID: 918 RVA: 0x0000BCDC File Offset: 0x00009EDC
			[DebuggerHidden]
			[return: 241(new byte[]
			{
				0,
				1,
				1
			})]
			private KeyValuePair<object, object> GetKeyValuePair10189_13090()
			{
				return this._keyValuePair10189;
			}

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x06000397 RID: 919 RVA: 0x0000BCE4 File Offset: 0x00009EE4
			KeyValuePair<object, object> IEnumerator<KeyValuePair<object, object>>.Current
			{
				get
				{
					return this.GetKeyValuePair10189_13090();
				}
			}

			// Token: 0x06000398 RID: 920 RVA: 0x00005BE8 File Offset: 0x00003DE8
			[DebuggerHidden]
			private void Method13091()
			{
				throw new NotSupportedException();
			}

			// Token: 0x06000399 RID: 921 RVA: 0x0000BCEC File Offset: 0x00009EEC
			void IEnumerator.Reset()
			{
				this.Method13091();
			}

			// Token: 0x0600039A RID: 922 RVA: 0x0000BCF4 File Offset: 0x00009EF4
			[DebuggerHidden]
			private object GetKeyValuePair10189_13092()
			{
				return this._keyValuePair10189;
			}

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x0600039B RID: 923 RVA: 0x0000BD01 File Offset: 0x00009F01
			object IEnumerator.Current
			{
				get
				{
					return this.GetKeyValuePair10189_13092();
				}
			}

			// Token: 0x04000373 RID: 883
			private int _number10188;

			// Token: 0x04000374 RID: 884
			[241(new byte[]
			{
				0,
				1,
				1
			})]
			private KeyValuePair<object, object> _keyValuePair10189;

			// Token: 0x04000375 RID: 885
			public 65.73<TItem, TItem2> _recoveredType239810190;

			// Token: 0x04000376 RID: 886
			[241(new byte[]
			{
				0,
				0,
				1,
				1
			})]
			private IEnumerator<KeyValuePair<TItem, TItem2>> _iEnumerator10191;
		}
	}

	// Token: 0x0200009D RID: 157
	public sealed class 66
	{
		// Token: 0x0600039C RID: 924 RVA: 0x0000BD09 File Offset: 0x00009F09
		internal string ResolveName(string 1)
		{
			return this.namingStrategy.GetDictionaryKey(1);
		}

		// Token: 0x04000377 RID: 887
		[241(0)]
		public 136 namingStrategy;
	}

	// Token: 0x0200009E RID: 158
	[Serializable]
	public sealed class 71
	{
		// Token: 0x0600039E RID: 926 RVA: 0x0000BD18 File Offset: 0x00009F18
		[242(0)]
		internal bool IsNotIndexedProperty(MemberInfo 1)
		{
			PropertyInfo propertyInfo = 1 as PropertyInfo;
			return propertyInfo == null || !143.IsIndexedProperty(propertyInfo);
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0000BD3A File Offset: 0x00009F3A
		[242(0)]
		internal bool IsNotTargetSite(MemberInfo 1)
		{
			return !string.Equals(1.Name, "TargetSite", StringComparison.Ordinal);
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0000BD50 File Offset: 0x00009F50
		[242(0)]
		internal IEnumerable<MemberInfo> GetDeclaredPropertiesAndFields(Type 1)
		{
			List<MemberInfo> list = new List<MemberInfo>();
			list.Method3166(1.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			list.Method3166(1.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			return list;
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0000BD74 File Offset: 0x00009F74
		[242(0)]
		internal bool IsExtensionDataMember(MemberInfo 1)
		{
			MemberTypes memberTypes = 1.Method6702();
			if (memberTypes != MemberTypes.Property && memberTypes != MemberTypes.Field)
			{
				return false;
			}
			if (!1.IsDefined(typeof(215), false))
			{
				return false;
			}
			if (!143.CanReadMemberValue(1, true))
			{
				throw new 134("Invalid extension data attribute on '{0}'. Member '{1}' must have a getter.".Method6825(CultureInfo.InvariantCulture, 65.GetClrTypeFullName(1.DeclaringType), 1.Name));
			}
			Type type;
			if (143.Method3895(143.GetMemberUnderlyingType(1), typeof(IDictionary<, >), out type))
			{
				Type type2 = type.GetGenericArguments()[0];
				Type type3 = type.GetGenericArguments()[1];
				if (type2.IsAssignableFrom(typeof(string)) && type3.IsAssignableFrom(typeof(226)))
				{
					return true;
				}
			}
			throw new 134("Invalid extension data attribute on '{0}'. Member '{1}' type must implement IDictionary<string, JToken>.".Method6825(CultureInfo.InvariantCulture, 65.GetClrTypeFullName(1.DeclaringType), 1.Name));
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0000BE4B File Offset: 0x0000A04B
		[242(0)]
		internal bool HasJsonConstructorAttribute(ConstructorInfo 1)
		{
			return 1.IsDefined(typeof(213), true);
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0000BE60 File Offset: 0x0000A060
		[242(0)]
		internal int GetPropertyOrder(666 1)
		{
			return 1.GetNullable7765_9883().GetValueOrDefault(-1);
		}

		// Token: 0x04000378 RID: 888
		[241(0)]
		public static readonly 65.71 instance = new 65.71();

		// Token: 0x04000379 RID: 889
		[241(0)]
		public static Func<MemberInfo, bool> func;

		// Token: 0x0400037A RID: 890
		[241(0)]
		public static Func<MemberInfo, bool> func2;

		// Token: 0x0400037B RID: 891
		[241(0)]
		public static Func<Type, IEnumerable<MemberInfo>> func3;

		// Token: 0x0400037C RID: 892
		[241(0)]
		public static Func<MemberInfo, bool> func4;

		// Token: 0x0400037D RID: 893
		[241(0)]
		public static Func<ConstructorInfo, bool> func5;

		// Token: 0x0400037E RID: 894
		[241(0)]
		public static Func<666, int> func6;
	}

	// Token: 0x0200009F RID: 159
	public sealed class 70
	{
		// Token: 0x060003A6 RID: 934 RVA: 0x0000BE88 File Offset: 0x0000A088
		internal void SetExtensionDataValue(object 1, string 2, [241(2)] object 3)
		{
			object obj = this.extensionDataMember.func(1);
			if (obj == null)
			{
				if (this.action == null)
				{
					throw new 364("Cannot set value onto extension data member '{0}'. The extension data collection is null and it cannot be set.".Method6825(CultureInfo.InvariantCulture, this.extensionDataMember.memberInfo.Name));
				}
				obj = this.func();
				this.action(1, obj);
			}
			this.itemSetter(obj, new object[]
			{
				2,
				3
			});
		}

		// Token: 0x0400037F RID: 895
		[241(new byte[]
		{
			0,
			1,
			2
		})]
		public Action<object, object> action;

		// Token: 0x04000380 RID: 896
		[241(new byte[]
		{
			0,
			1
		})]
		public Func<object> func;

		// Token: 0x04000381 RID: 897
		[241(new byte[]
		{
			0,
			1,
			2
		})]
		public 431<object, object> itemSetter;

		// Token: 0x04000382 RID: 898
		[241(0)]
		public 65.69 extensionDataMember;
	}

	// Token: 0x020000A0 RID: 160
	public sealed class 68
	{
		// Token: 0x060003A8 RID: 936 RVA: 0x0000BF0C File Offset: 0x0000A10C
		[return: 241(new byte[]
		{
			2,
			0,
			1,
			1
		})]
		internal IEnumerable<KeyValuePair<object, object>> GetExtensionDataEnumerable(object 1)
		{
			object obj = this.extensionDataMember.func(1);
			if (obj == null)
			{
				return null;
			}
			return (IEnumerable<KeyValuePair<object, object>>)this.enumerableConstructor(new object[]
			{
				obj
			});
		}

		// Token: 0x04000383 RID: 899
		[241(new byte[]
		{
			0,
			1
		})]
		public 516<object> enumerableConstructor;

		// Token: 0x04000384 RID: 900
		[241(0)]
		public 65.69 extensionDataMember;
	}

	// Token: 0x020000A1 RID: 161
	public sealed class 76
	{
		// Token: 0x060003AA RID: 938 RVA: 0x0000BF4A File Offset: 0x0000A14A
		internal bool IsSpecified(object 1)
		{
			return (bool)this.func(1);
		}

		// Token: 0x04000385 RID: 901
		[241(new byte[]
		{
			0,
			1,
			1
		})]
		public Func<object, object> func;
	}

	// Token: 0x020000A2 RID: 162
	public sealed class 69
	{
		// Token: 0x04000386 RID: 902
		[241(new byte[]
		{
			0,
			1,
			2
		})]
		public Func<object, object> func;

		// Token: 0x04000387 RID: 903
		[241(0)]
		public MemberInfo memberInfo;
	}

	// Token: 0x020000A3 RID: 163
	public sealed class 72
	{
		// Token: 0x060003AD RID: 941 RVA: 0x0000BF5D File Offset: 0x0000A15D
		internal string ResolveName(string 1)
		{
			return this.namingStrategy.GetDictionaryKey(1);
		}

		// Token: 0x04000388 RID: 904
		[241(0)]
		public 136 namingStrategy;
	}

	// Token: 0x020000A4 RID: 164
	public sealed class 67
	{
		// Token: 0x060003AF RID: 943 RVA: 0x0000BF6B File Offset: 0x0000A16B
		internal string ResolveName(string 1)
		{
			return this.namingStrategy.GetDictionaryKey(1);
		}

		// Token: 0x04000389 RID: 905
		[241(0)]
		public 136 namingStrategy;
	}

	// Token: 0x020000A5 RID: 165
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0400038A RID: 906
		public static Func<MemberInfo, bool> <0>__Method13121;

		// Token: 0x0400038B RID: 907
		public static 437 <1>__ThrowUnableToSerialize;
	}
}
