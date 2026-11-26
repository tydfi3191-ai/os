using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;

// Token: 0x020001E5 RID: 485
[241(0)]
[242(1)]
[ComVisible(false)]
public sealed class 61 : 569
{
	// Token: 0x06000F61 RID: 3937 RVA: 0x00034B0A File Offset: 0x00032D0A
	public 61(MemberInfo 1)
	{
		756.Method12216(1, "memberInfo");
		this.member = 1;
	}

	// Token: 0x06000F62 RID: 3938 RVA: 0x00034B24 File Offset: 0x00032D24
	public void Method8004(object 1, [241(2)] object 2)
	{
		try
		{
			143.SetMemberValue(this.member, 1, 2);
		}
		catch (Exception 3)
		{
			throw new 364("Error setting value to '{0}' on '{1}'.".Method6825(CultureInfo.InvariantCulture, this.member.Name, 1.GetType()), 3);
		}
	}

	// Token: 0x06000F63 RID: 3939 RVA: 0x00034B78 File Offset: 0x00032D78
	[return: 241(2)]
	public object Method8005(object 1)
	{
		object memberValue;
		try
		{
			PropertyInfo propertyInfo = this.member as PropertyInfo;
			if (propertyInfo != null && propertyInfo.PropertyType.IsByRef)
			{
				throw new InvalidOperationException("Could not create getter for {0}. ByRef return values are not supported.".Method6825(CultureInfo.InvariantCulture, propertyInfo));
			}
			memberValue = 143.GetMemberValue(this.member, 1);
		}
		catch (Exception 2)
		{
			throw new 364("Error getting value from '{0}' on '{1}'.".Method6825(CultureInfo.InvariantCulture, this.member.Name, 1.GetType()), 2);
		}
		return memberValue;
	}

	// Token: 0x04000772 RID: 1906
	private readonly MemberInfo member;
}
