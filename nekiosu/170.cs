using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

// Token: 0x020001E9 RID: 489
[241(0)]
[242(1)]
public static class 170
{
	// Token: 0x06000F8E RID: 3982 RVA: 0x0003542D File Offset: 0x0003362D
	[return: 241(2)]
	public static T GetAttribute<[241(0)] T>(object 1) where T : Attribute
	{
		return 811<T>.Method13842(1);
	}

	// Token: 0x06000F8F RID: 3983 RVA: 0x00035438 File Offset: 0x00033638
	public static bool CanTypeDescriptorConvertString(Type 1, out TypeConverter 2)
	{
		2 = TypeDescriptor.GetConverter(1);
		if (2 != null)
		{
			Type type = 2.GetType();
			if (!string.Equals(type.FullName, "System.ComponentModel.ComponentConverter", StringComparison.Ordinal) && !string.Equals(type.FullName, "System.ComponentModel.ReferenceConverter", StringComparison.Ordinal) && !string.Equals(type.FullName, "System.Windows.Forms.Design.DataSourceConverter", StringComparison.Ordinal) && type != typeof(TypeConverter))
			{
				return 2.CanConvertTo(typeof(string));
			}
		}
		return false;
	}

	// Token: 0x06000F90 RID: 3984 RVA: 0x000354B8 File Offset: 0x000336B8
	[return: 241(2)]
	public static DataContractAttribute GetDataContractAttribute(Type 1)
	{
		Type type = 1;
		while (type != null)
		{
			DataContractAttribute dataContractAttribute = 811<DataContractAttribute>.Method13842(type);
			if (dataContractAttribute != null)
			{
				return dataContractAttribute;
			}
			type = type.Method6707();
		}
		return null;
	}

	// Token: 0x06000F91 RID: 3985 RVA: 0x000354E8 File Offset: 0x000336E8
	[return: 241(2)]
	public static DataMemberAttribute GetDataMemberAttribute(MemberInfo 1)
	{
		if (1.Method6702() == MemberTypes.Field)
		{
			return 811<DataMemberAttribute>.Method13842(1);
		}
		PropertyInfo propertyInfo = (PropertyInfo)1;
		DataMemberAttribute dataMemberAttribute = 811<DataMemberAttribute>.Method13842(propertyInfo);
		if (dataMemberAttribute == null && propertyInfo.IsVirtualProperty())
		{
			Type type = propertyInfo.DeclaringType;
			while (dataMemberAttribute == null && type != null)
			{
				PropertyInfo propertyInfo2 = (PropertyInfo)143.GetMemberInfoFromType(type, propertyInfo);
				if (propertyInfo2 != null && propertyInfo2.IsVirtualProperty())
				{
					dataMemberAttribute = 811<DataMemberAttribute>.Method13842(propertyInfo2);
				}
				type = type.Method6707();
			}
		}
		return dataMemberAttribute;
	}

	// Token: 0x06000F92 RID: 3986 RVA: 0x00035560 File Offset: 0x00033760
	public static 698 GetObjectMemberSerialization(Type 1, bool 2)
	{
		524 attribute = 170.GetAttribute<524>(1);
		if (attribute != null)
		{
			return attribute.RecoveredType19324814;
		}
		if (170.GetDataContractAttribute(1) != null)
		{
			return (698)1;
		}
		if (!2 && 170.IsSerializable(1))
		{
			return (698)2;
		}
		return (698)0;
	}

	// Token: 0x06000F93 RID: 3987 RVA: 0x00035598 File Offset: 0x00033798
	[return: 241(2)]
	public static 214 GetJsonConverter(object 1)
	{
		132 attribute = 170.GetAttribute<132>(1);
		if (attribute != null)
		{
			Func<object[], object> func = 170.activatorCache.Method4701(attribute.GetConverterType());
			if (func != null)
			{
				return (214)func(attribute.ConverterParameters);
			}
		}
		return null;
	}

	// Token: 0x06000F94 RID: 3988 RVA: 0x000355D6 File Offset: 0x000337D6
	public static 214 CreateJsonConverterInstance(Type 1, [241(new byte[]
	{
		2,
		1
	})] object[] 2)
	{
		return (214)170.activatorCache.Method4701(1)(2);
	}

	// Token: 0x06000F95 RID: 3989 RVA: 0x000355EE File Offset: 0x000337EE
	public static 136 CreateNamingStrategyInstance(Type 1, [241(new byte[]
	{
		2,
		1
	})] object[] 2)
	{
		return (136)170.activatorCache.Method4701(1)(2);
	}

	// Token: 0x06000F96 RID: 3990 RVA: 0x00035606 File Offset: 0x00033806
	[return: 241(2)]
	public static 136 GetContainerNamingStrategy(129 1)
	{
		if (1.GetNamingStrategyInstance() == null)
		{
			if (1.NamingStrategyType == null)
			{
				return null;
			}
			1.SetNamingStrategyInstance(170.CreateNamingStrategyInstance(1.NamingStrategyType, 1.NamingStrategyParameters));
		}
		return 1.GetNamingStrategyInstance();
	}

	// Token: 0x06000F97 RID: 3991 RVA: 0x00035640 File Offset: 0x00033840
	[return: 241(new byte[]
	{
		1,
		2,
		1,
		1
	})]
	private static Func<object[], object> Method4329(Type 1)
	{
		170.172 2 = new 170.172();
		2.type = 1;
		2.func = (143.HasDefaultConstructor(2.type, false) ? 170.GetReflectionDelegateFactory().Method9977<object>(2.type) : null);
		return new Func<object[], object>(2.Method4319);
	}

	// Token: 0x06000F98 RID: 3992 RVA: 0x0003568D File Offset: 0x0003388D
	[return: 241(2)]
	private static Type GetAssociatedMetadataType(Type 1)
	{
		return 170.metadataTypeCache.Method4701(1);
	}

	// Token: 0x06000F99 RID: 3993 RVA: 0x0003569C File Offset: 0x0003389C
	[return: 241(2)]
	private static Type GetAssociatedMetadataTypeFromAttribute(Type 1)
	{
		foreach (Attribute attribute in 143.Method3913(1, null, true))
		{
			Type type = attribute.GetType();
			if (string.Equals(type.FullName, "System.ComponentModel.DataAnnotations.MetadataTypeAttribute", StringComparison.Ordinal))
			{
				if (170.metadataClassTypeAccessor == null)
				{
					170.metadataClassTypeAccessor = 580.Method7915(type, new string[]
					{
						"MetadataClassType"
					});
				}
				return (Type)170.metadataClassTypeAccessor.Method7912(attribute, "MetadataClassType");
			}
		}
		return null;
	}

	// Token: 0x06000F9A RID: 3994 RVA: 0x00035718 File Offset: 0x00033918
	[return: 241(2)]
	private static T Method4332<[241(0)] T>(Type 1) where T : Attribute
	{
		Type associatedMetadataType = 170.GetAssociatedMetadataType(1);
		T t;
		if (associatedMetadataType != null)
		{
			t = 143.Method3911<T>(associatedMetadataType, true);
			if (t != null)
			{
				return t;
			}
		}
		t = 143.Method3911<T>(1, true);
		if (t != null)
		{
			return t;
		}
		Type[] interfaces = 1.GetInterfaces();
		for (int i = 0; i < interfaces.Length; i++)
		{
			t = 143.Method3911<T>(interfaces[i], true);
			if (t != null)
			{
				return t;
			}
		}
		return default(T);
	}

	// Token: 0x06000F9B RID: 3995 RVA: 0x0003578C File Offset: 0x0003398C
	[return: 241(2)]
	private static T Method4332<[241(0)] T>(MemberInfo 1) where T : Attribute
	{
		Type associatedMetadataType = 170.GetAssociatedMetadataType(1.DeclaringType);
		T t;
		if (associatedMetadataType != null)
		{
			MemberInfo memberInfoFromType = 143.GetMemberInfoFromType(associatedMetadataType, 1);
			if (memberInfoFromType != null)
			{
				t = 143.Method3911<T>(memberInfoFromType, true);
				if (t != null)
				{
					return t;
				}
			}
		}
		t = 143.Method3911<T>(1, true);
		if (t != null)
		{
			return t;
		}
		if (1.DeclaringType != null)
		{
			Type[] interfaces = 1.DeclaringType.GetInterfaces();
			for (int i = 0; i < interfaces.Length; i++)
			{
				MemberInfo memberInfoFromType2 = 143.GetMemberInfoFromType(interfaces[i], 1);
				if (memberInfoFromType2 != null)
				{
					t = 143.Method3911<T>(memberInfoFromType2, true);
					if (t != null)
					{
						return t;
					}
				}
			}
		}
		return default(T);
	}

	// Token: 0x06000F9C RID: 3996 RVA: 0x00035842 File Offset: 0x00033A42
	public static bool IsNonSerializable(object 1)
	{
		return 143.Method3911<NonSerializedAttribute>(1, false) != null;
	}

	// Token: 0x06000F9D RID: 3997 RVA: 0x0003584E File Offset: 0x00033A4E
	public static bool IsSerializable(object 1)
	{
		return 143.Method3911<SerializableAttribute>(1, false) != null;
	}

	// Token: 0x06000F9E RID: 3998 RVA: 0x0003585C File Offset: 0x00033A5C
	[return: 241(2)]
	public static T Method4332<[241(0)] T>(object 1) where T : Attribute
	{
		Type type = 1 as Type;
		if (type != null)
		{
			return 170.Method4332<T>(type);
		}
		MemberInfo memberInfo = 1 as MemberInfo;
		if (memberInfo != null)
		{
			return 170.Method4332<T>(memberInfo);
		}
		return 143.Method3911<T>(1, true);
	}

	// Token: 0x06000F9F RID: 3999 RVA: 0x00035894 File Offset: 0x00033A94
	[SecuritySafeCritical]
	public static bool UsesDynamicCodeGeneration()
	{
		if (170.nullable == null)
		{
			try
			{
				new ReflectionPermission(ReflectionPermissionFlag.MemberAccess).Demand();
				new ReflectionPermission(ReflectionPermissionFlag.RestrictedMemberAccess).Demand();
				new SecurityPermission(SecurityPermissionFlag.SkipVerification).Demand();
				new SecurityPermission(SecurityPermissionFlag.UnmanagedCode).Demand();
				new SecurityPermission(PermissionState.Unrestricted).Demand();
				170.nullable = new bool?(true);
			}
			catch (Exception)
			{
				170.nullable = new bool?(false);
			}
		}
		return 170.nullable.GetValueOrDefault();
	}

	// Token: 0x06000FA0 RID: 4000 RVA: 0x0003591C File Offset: 0x00033B1C
	public static bool IsFullyTrusted()
	{
		if (170.fullyTrusted == null)
		{
			AppDomain currentDomain = AppDomain.CurrentDomain;
			170.fullyTrusted = new bool?(currentDomain.IsHomogenous && currentDomain.IsFullyTrusted);
		}
		return 170.fullyTrusted.GetValueOrDefault();
	}

	// Token: 0x06000FA1 RID: 4001 RVA: 0x00035960 File Offset: 0x00033B60
	public static 533 GetReflectionDelegateFactory()
	{
		if (170.UsesDynamicCodeGeneration())
		{
			return 667.GetRecoveredType17897850_9972();
		}
		return 460.GetRecoveredType07673403_4375();
	}

	// Token: 0x04000789 RID: 1929
	private static bool? nullable;

	// Token: 0x0400078A RID: 1930
	private static bool? fullyTrusted;

	// Token: 0x0400078B RID: 1931
	[241(new byte[]
	{
		1,
		1,
		1,
		2,
		1,
		1
	})]
	private static readonly 482<Type, Func<object[], object>> activatorCache = new 482<Type, Func<object[], object>>(delegate(Type 1)
	{
		170.172 2 = new 170.172();
		2.type = 1;
		2.func = (143.HasDefaultConstructor(2.type, false) ? 170.GetReflectionDelegateFactory().Method9977<object>(2.type) : null);
		return new Func<object[], object>(2.Method4319);
	});

	// Token: 0x0400078C RID: 1932
	[241(new byte[]
	{
		1,
		1,
		2
	})]
	private static readonly 482<Type, Type> metadataTypeCache = new 482<Type, Type>(new Func<Type, Type>(170.GetAssociatedMetadataTypeFromAttribute));

	// Token: 0x0400078D RID: 1933
	[241(2)]
	private static 580 metadataClassTypeAccessor;

	// Token: 0x020001EA RID: 490
	[Serializable]
	public sealed class 171
	{
		// Token: 0x06000FA3 RID: 4003 RVA: 0x000359A6 File Offset: 0x00033BA6
		[242(0)]
		internal Type Method4318(object 1)
		{
			if (1 == null)
			{
				throw new InvalidOperationException("Cannot pass a null parameter to the constructor.");
			}
			return 1.GetType();
		}

		// Token: 0x0400078E RID: 1934
		[241(0)]
		public static readonly 170.171 instance = new 170.171();

		// Token: 0x0400078F RID: 1935
		[241(0)]
		public static Func<object, Type> func;
	}

	// Token: 0x020001EB RID: 491
	public sealed class 172
	{
		// Token: 0x06000FA6 RID: 4006 RVA: 0x000359C8 File Offset: 0x00033BC8
		internal object Method4319([241(new byte[]
		{
			2,
			1
		})] object[] 1)
		{
			object result;
			try
			{
				if (3 != null)
				{
					Type[] types = 3.Select(delegate(object 1)
					{
						if (1 == null)
						{
							throw new InvalidOperationException("Cannot pass a null parameter to the constructor.");
						}
						return 1.GetType();
					}).ToArray<Type>();
					ConstructorInfo constructor = this.type.GetConstructor(types);
					if (!(constructor != null))
					{
						throw new 134("No matching parameterized constructor found for '{0}'.".Method6825(CultureInfo.InvariantCulture, this.type));
					}
					result = 170.GetReflectionDelegateFactory().Method9974(constructor)(3);
				}
				else
				{
					if (this.func == null)
					{
						throw new 134("No parameterless constructor defined for '{0}'.".Method6825(CultureInfo.InvariantCulture, this.type));
					}
					result = this.func();
				}
			}
			catch (Exception 2)
			{
				throw new 134("Error creating '{0}'.".Method6825(CultureInfo.InvariantCulture, this.type), 2);
			}
			return result;
		}

		// Token: 0x04000790 RID: 1936
		[241(0)]
		public Type type;

		// Token: 0x04000791 RID: 1937
		[241(new byte[]
		{
			0,
			1
		})]
		public Func<object> func;
	}
}
