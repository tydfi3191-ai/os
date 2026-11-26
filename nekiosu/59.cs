using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;

// Token: 0x0200024E RID: 590
[241(0)]
[242(1)]
public static class 59
{
	// Token: 0x06001206 RID: 4614 RVA: 0x00041AC1 File Offset: 0x0003FCC1
	public static IEnumerable<string> GetDynamicMemberNames(this IDynamicMetaObjectProvider 1)
	{
		return 1.GetMetaObject(Expression.Constant(1)).GetDynamicMemberNames();
	}

	// Token: 0x0200024F RID: 591
	[241(0)]
	public static class 60
	{
		// Token: 0x06001207 RID: 4615 RVA: 0x00041AD4 File Offset: 0x0003FCD4
		private static void EnsureInitialized()
		{
			if (!59.60.isInitialized)
			{
				if (Type.GetType("Microsoft.CSharp.RuntimeBinder.Binder, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", false) == null)
				{
					throw new InvalidOperationException("Could not resolve type '{0}'. You may need to add a reference to Microsoft.CSharp.dll to work with dynamic types.".Method6825(CultureInfo.InvariantCulture, "Microsoft.CSharp.RuntimeBinder.Binder, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"));
				}
				59.60.getMemberArgumentInfos = 59.60.CreateArgumentInfos(new int[1]);
				59.60.setMemberArgumentInfos = 59.60.CreateArgumentInfos(new int[]
				{
					0,
					3
				});
				59.60.LoadBinderFactories();
				59.60.isInitialized = true;
			}
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x00041B44 File Offset: 0x0003FD44
		private static object CreateArgumentInfos(int[] 1)
		{
			Type type = Type.GetType("Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", true);
			Type type2 = Type.GetType("Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", true);
			Array array = Array.CreateInstance(type, 1.Length);
			for (int i = 0; i < 1.Length; i++)
			{
				MethodBase method = type.GetMethod("Create", new Type[]
				{
					type2,
					typeof(string)
				});
				object obj = null;
				object[] array2 = new object[2];
				array2[0] = 0;
				object value = method.Invoke(obj, array2);
				array.SetValue(value, i);
			}
			return array;
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x00041BC4 File Offset: 0x0003FDC4
		private static void LoadBinderFactories()
		{
			Type type = Type.GetType("Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", true);
			Type type2 = Type.GetType("Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", true);
			Type type3 = Type.GetType("Microsoft.CSharp.RuntimeBinder.Binder, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", true);
			Type type4 = typeof(IEnumerable<>).MakeGenericType(new Type[]
			{
				type
			});
			MethodInfo method = type3.GetMethod("GetMember", new Type[]
			{
				type2,
				typeof(string),
				typeof(Type),
				type4
			});
			59.60.getMemberBinderFactory = 170.GetReflectionDelegateFactory().Method9975<object>(method);
			MethodInfo method2 = type3.GetMethod("SetMember", new Type[]
			{
				type2,
				typeof(string),
				typeof(Type),
				type4
			});
			59.60.setMemberBinderFactory = 170.GetReflectionDelegateFactory().Method9975<object>(method2);
		}

		// Token: 0x0600120A RID: 4618 RVA: 0x00041C9B File Offset: 0x0003FE9B
		public static CallSiteBinder CreateGetMemberBinder(string 1, Type 2)
		{
			59.60.EnsureInitialized();
			return (CallSiteBinder)59.60.getMemberBinderFactory(null, new object[]
			{
				0,
				1,
				2,
				59.60.getMemberArgumentInfos
			});
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x00041CD1 File Offset: 0x0003FED1
		public static CallSiteBinder CreateSetMemberBinder(string 1, Type 2)
		{
			59.60.EnsureInitialized();
			return (CallSiteBinder)59.60.setMemberBinderFactory(null, new object[]
			{
				0,
				1,
				2,
				59.60.setMemberArgumentInfos
			});
		}

		// Token: 0x040008D6 RID: 2262
		[241(2)]
		private static object getMemberArgumentInfos;

		// Token: 0x040008D7 RID: 2263
		[241(2)]
		private static object setMemberArgumentInfos;

		// Token: 0x040008D8 RID: 2264
		[241(2)]
		private static 431<object, object> getMemberBinderFactory;

		// Token: 0x040008D9 RID: 2265
		[241(2)]
		private static 431<object, object> setMemberBinderFactory;

		// Token: 0x040008DA RID: 2266
		private static bool isInitialized;
	}
}
