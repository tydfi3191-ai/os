using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

// Token: 0x02000BC3 RID: 3011
[ComVisible(false)]
public static class 1191
{
	// Token: 0x060052DA RID: 21210 RVA: 0x002092DC File Offset: 0x002074DC
	public static string 1(this Enum 1)
	{
		MemberInfo[] member = 1.GetType().GetMember(1.ToString());
		if (member != null && member.Length != 0)
		{
			object[] customAttributes = member[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
			if (customAttributes != null && customAttributes.Count<object>() > 0)
			{
				return ((DescriptionAttribute)customAttributes.ElementAt(0)).Description;
			}
		}
		return 1.ToString();
	}
}
