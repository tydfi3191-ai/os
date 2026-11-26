using System;
using System.Globalization;
using System.Reflection;

// Token: 0x02000151 RID: 337
[241(0)]
[242(1)]
public abstract class 533
{
	// Token: 0x06000BB2 RID: 2994 RVA: 0x0002AA20 File Offset: 0x00028C20
	[return: 241(new byte[]
	{
		1,
		1,
		2
	})]
	public Func<T, object> Method99792<[241(2)] T>(MemberInfo 1)
	{
		PropertyInfo propertyInfo = 1 as PropertyInfo;
		if (propertyInfo != null)
		{
			if (propertyInfo.PropertyType.IsByRef)
			{
				throw new InvalidOperationException("Could not create getter for {0}. ByRef return values are not supported.".Method6825(CultureInfo.InvariantCulture, propertyInfo));
			}
			return this.Method99792<T>(propertyInfo);
		}
		else
		{
			FieldInfo fieldInfo = 1 as FieldInfo;
			if (fieldInfo != null)
			{
				return this.Method99792<T>(fieldInfo);
			}
			throw new Exception("Could not create getter for {0}.".Method6825(CultureInfo.InvariantCulture, 1));
		}
	}

	// Token: 0x06000BB3 RID: 2995 RVA: 0x0002AA8C File Offset: 0x00028C8C
	[return: 241(new byte[]
	{
		1,
		1,
		2
	})]
	public Action<T, object> Method99832<[241(2)] T>(MemberInfo 1)
	{
		PropertyInfo propertyInfo = 1 as PropertyInfo;
		if (propertyInfo != null)
		{
			return this.Method99832<T>(propertyInfo);
		}
		FieldInfo fieldInfo = 1 as FieldInfo;
		if (fieldInfo != null)
		{
			return this.Method99832<T>(fieldInfo);
		}
		throw new Exception("Could not create setter for {0}.".Method6825(CultureInfo.InvariantCulture, 1));
	}

	// Token: 0x06000BB4 RID: 2996
	[return: 241(new byte[]
	{
		1,
		1,
		2
	})]
	public abstract 431<T, object> Method9975<[241(2)] T>(MethodBase 1);

	// Token: 0x06000BB5 RID: 2997
	public abstract 516<object> Method9974(MethodBase 1);

	// Token: 0x06000BB6 RID: 2998
	public abstract Func<T> Method9977<[241(2)] T>(Type 1);

	// Token: 0x06000BB7 RID: 2999
	[return: 241(new byte[]
	{
		1,
		1,
		2
	})]
	public abstract Func<T, object> Method99792<[241(2)] T>(PropertyInfo 1);

	// Token: 0x06000BB8 RID: 3000
	[return: 241(new byte[]
	{
		1,
		1,
		2
	})]
	public abstract Func<T, object> Method99792<[241(2)] T>(FieldInfo 1);

	// Token: 0x06000BB9 RID: 3001
	[return: 241(new byte[]
	{
		1,
		1,
		2
	})]
	public abstract Action<T, object> Method99832<[241(2)] T>(FieldInfo 1);

	// Token: 0x06000BBA RID: 3002
	[return: 241(new byte[]
	{
		1,
		1,
		2
	})]
	public abstract Action<T, object> Method99832<[241(2)] T>(PropertyInfo 1);
}
