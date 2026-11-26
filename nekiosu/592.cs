using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;

// Token: 0x0200016E RID: 366
[ComVisible(false)]
[242(1)]
[241(0)]
public sealed class 592 : 569
{
	// Token: 0x06000C42 RID: 3138 RVA: 0x0002C553 File Offset: 0x0002A753
	public 592(MemberInfo 1)
	{
		756.Method12216(1, "memberInfo");
		this.memberInfo2 = 1;
	}

	// Token: 0x06000C43 RID: 3139 RVA: 0x0002C570 File Offset: 0x0002A770
	public void Method8004(object 1, [241(2)] object 2)
	{
		try
		{
			if (this.action == null)
			{
				this.action = 667.GetRecoveredType17897850_9972().Method99832<object>(this.memberInfo2);
			}
			this.action(1, 2);
		}
		catch (Exception 3)
		{
			throw new 364("Error setting value to '{0}' on '{1}'.".Method6825(CultureInfo.InvariantCulture, this.memberInfo2.Name, 1.GetType()), 3);
		}
	}

	// Token: 0x06000C44 RID: 3140 RVA: 0x0002C5E4 File Offset: 0x0002A7E4
	[return: 241(2)]
	public object Method8005(object 1)
	{
		object result;
		try
		{
			if (this.func == null)
			{
				this.func = 667.GetRecoveredType17897850_9972().Method99792<object>(this.memberInfo2);
			}
			result = this.func(1);
		}
		catch (Exception 2)
		{
			throw new 364("Error getting value from '{0}' on '{1}'.".Method6825(CultureInfo.InvariantCulture, this.memberInfo2.Name, 1.GetType()), 2);
		}
		return result;
	}

	// Token: 0x04000604 RID: 1540
	private readonly MemberInfo memberInfo2;

	// Token: 0x04000605 RID: 1541
	[241(new byte[]
	{
		2,
		1,
		2
	})]
	private Func<object, object> func;

	// Token: 0x04000606 RID: 1542
	[241(new byte[]
	{
		2,
		1,
		2
	})]
	private Action<object, object> action;
}
