using System;
using System.Collections.Generic;
using System.Reflection;

// Token: 0x0200037E RID: 894
[242(1)]
[241(0)]
public static class 532
{
	// Token: 0x06001A8D RID: 6797 RVA: 0x00064086 File Offset: 0x00062286
	public static MemberTypes Method6702(this MemberInfo 1)
	{
		return 1.MemberType;
	}

	// Token: 0x06001A8E RID: 6798 RVA: 0x0006408E File Offset: 0x0006228E
	public static bool Method6703(this Type 1)
	{
		return 1.ContainsGenericParameters;
	}

	// Token: 0x06001A8F RID: 6799 RVA: 0x00064096 File Offset: 0x00062296
	public static bool Method6704(this Type 1)
	{
		return 1.IsInterface;
	}

	// Token: 0x06001A90 RID: 6800 RVA: 0x0006409E File Offset: 0x0006229E
	public static bool Method6705(this Type 1)
	{
		return 1.IsGenericType;
	}

	// Token: 0x06001A91 RID: 6801 RVA: 0x000640A6 File Offset: 0x000622A6
	public static bool Method6706(this Type 1)
	{
		return 1.IsGenericTypeDefinition;
	}

	// Token: 0x06001A92 RID: 6802 RVA: 0x000640AE File Offset: 0x000622AE
	[return: 241(2)]
	public static Type Method6707(this Type 1)
	{
		return 1.BaseType;
	}

	// Token: 0x06001A93 RID: 6803 RVA: 0x000640B6 File Offset: 0x000622B6
	public static Assembly Method6708(this Type 1)
	{
		return 1.Assembly;
	}

	// Token: 0x06001A94 RID: 6804 RVA: 0x000640BE File Offset: 0x000622BE
	public static bool Method6709(this Type 1)
	{
		return 1.IsEnum;
	}

	// Token: 0x06001A95 RID: 6805 RVA: 0x000640C6 File Offset: 0x000622C6
	public static bool Method6710(this Type 1)
	{
		return 1.IsClass;
	}

	// Token: 0x06001A96 RID: 6806 RVA: 0x000640CE File Offset: 0x000622CE
	public static bool Method6711(this Type 1)
	{
		return 1.IsSealed;
	}

	// Token: 0x06001A97 RID: 6807 RVA: 0x000640D6 File Offset: 0x000622D6
	public static bool Method6712(this Type 1)
	{
		return 1.IsAbstract;
	}

	// Token: 0x06001A98 RID: 6808 RVA: 0x000640DE File Offset: 0x000622DE
	public static bool Method6713(this Type 1)
	{
		return 1.IsVisible;
	}

	// Token: 0x06001A99 RID: 6809 RVA: 0x000640E6 File Offset: 0x000622E6
	public static bool Method6714(this Type 1)
	{
		return 1.IsValueType;
	}

	// Token: 0x06001A9A RID: 6810 RVA: 0x000640EE File Offset: 0x000622EE
	public static bool Method6715(this Type 1)
	{
		return 1.IsPrimitive;
	}

	// Token: 0x06001A9B RID: 6811 RVA: 0x000640F8 File Offset: 0x000622F8
	public static bool Method6716(this Type 1, string 2, bool 3, [241(2)] [239(true)] out Type 4)
	{
		Type type = 1;
		while (type != null)
		{
			if (string.Equals(type.FullName, 2, StringComparison.Ordinal))
			{
				4 = type;
				return true;
			}
			type = type.Method6707();
		}
		if (3)
		{
			Type[] interfaces = 1.GetInterfaces();
			for (int i = 0; i < interfaces.Length; i++)
			{
				if (string.Equals(interfaces[i].Name, 2, StringComparison.Ordinal))
				{
					4 = 1;
					return true;
				}
			}
		}
		4 = null;
		return false;
	}

	// Token: 0x06001A9C RID: 6812 RVA: 0x00064160 File Offset: 0x00062360
	public static bool Method6716(this Type 1, string 2, bool 3)
	{
		Type type;
		return 1.Method6716(2, 3, out type);
	}

	// Token: 0x06001A9D RID: 6813 RVA: 0x00064178 File Offset: 0x00062378
	public static bool Method6718(this Type 1, Type 2)
	{
		Type type = 1;
		while (type != null)
		{
			foreach (Type type2 in ((IEnumerable<Type>)type.GetInterfaces()))
			{
				if (type2 == 2 || (type2 != null && type2.Method6718(2)))
				{
					return true;
				}
			}
			type = type.Method6707();
		}
		return false;
	}
}
