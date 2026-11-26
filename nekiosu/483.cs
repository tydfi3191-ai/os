using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;

// Token: 0x02000148 RID: 328
[241(0)]
[242(1)]
[ComVisible(false)]
public sealed class 483 : 569
{
	// Token: 0x06000B43 RID: 2883 RVA: 0x0002A27C File Offset: 0x0002847C
	public 483(MemberInfo 1)
	{
		756.Method12216(1, "memberInfo");
		this.memberInfo2 = 1;
	}

	// Token: 0x06000B44 RID: 2884 RVA: 0x0002A298 File Offset: 0x00028498
	public void Method8004(object 1, [241(2)] object 2)
	{
		try
		{
			if (this.action == null)
			{
				this.action = 397.GetRecoveredType04551976_2510().Method99832<object>(this.memberInfo2);
			}
			this.action(1, 2);
		}
		catch (Exception 3)
		{
			throw new 364("Error setting value to '{0}' on '{1}'.".Method6825(CultureInfo.InvariantCulture, this.memberInfo2.Name, 1.GetType()), 3);
		}
	}

	// Token: 0x06000B45 RID: 2885 RVA: 0x0002A30C File Offset: 0x0002850C
	[return: 241(2)]
	public object Method8005(object 1)
	{
		object result;
		try
		{
			if (this.func == null)
			{
				this.func = 397.GetRecoveredType04551976_2510().Method99792<object>(this.memberInfo2);
			}
			result = this.func(1);
		}
		catch (Exception 2)
		{
			throw new 364("Error getting value from '{0}' on '{1}'.".Method6825(CultureInfo.InvariantCulture, this.memberInfo2.Name, 1.GetType()), 2);
		}
		return result;
	}

	// Token: 0x0400058F RID: 1423
	private readonly MemberInfo memberInfo2;

	// Token: 0x04000590 RID: 1424
	[241(new byte[]
	{
		2,
		1,
		2
	})]
	private Func<object, object> func;

	// Token: 0x04000591 RID: 1425
	[241(new byte[]
	{
		2,
		1,
		2
	})]
	private Action<object, object> action;
}
