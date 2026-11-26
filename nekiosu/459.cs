using System;
using System.Collections.Generic;
using System.Reflection;

// Token: 0x02000247 RID: 583
public static class 459
{
	// Token: 0x060011EF RID: 4591 RVA: 0x0004151C File Offset: 0x0003F71C
	internal static AssemblyName[] Method4364(Assembly 1)
	{
		AssemblyName[] referencedAssemblies = 1.GetReferencedAssemblies();
		if (1 != 459.assembly2)
		{
			return referencedAssemblies;
		}
		string[] array = "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089|System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089|System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089|OpenTK, Version=1.1.0.0, Culture=neutral, PublicKeyToken=bad199fe84eb3df4|System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a|System.Management, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a|System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089|System.Web, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a|Microsoft.Ink, Version=6.1.0.0, Culture=neutral, PublicKeyToken=null|System.Runtime.Remoting, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089|osu!gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null|osu!ui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null|osu!seasonal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null|System.Numerics, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089|System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089|System.Xml.Linq, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089|System.Runtime.Serialization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089|System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089".Split(new char[]
		{
			'|'
		});
		List<string> list = new List<string>(referencedAssemblies.Length + array.Length);
		foreach (string item in array)
		{
			list.Add(item);
		}
		AssemblyName[] array3 = referencedAssemblies;
		for (int i = 0; i < array3.Length; i++)
		{
			string fullName = array3[i].FullName;
			if (!list.Contains(fullName))
			{
				list.Add(fullName);
			}
		}
		int count = list.Count;
		AssemblyName[] array4 = new AssemblyName[count];
		for (int num = 0; num != count; num++)
		{
			array4[num] = new AssemblyName(list[num]);
		}
		return array4;
	}

	// Token: 0x040008C8 RID: 2248
	private static readonly Assembly assembly2 = typeof(459).Assembly;
}
