using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

// Token: 0x0200001C RID: 28
[StructLayout(LayoutKind.Auto, CharSet = CharSet.Auto)]
public static class 44
{
	// Token: 0x060000A2 RID: 162 RVA: 0x000055B4 File Offset: 0x000037B4
	internal static bool ListHasItems<T>(List<T> 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException();
		}
		return 1.Count != 0;
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x000055C8 File Offset: 0x000037C8
	internal static T ListFirstOrDefault<T>(List<T> 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException();
		}
		if (1.Count > 0)
		{
			return 1[0];
		}
		return default(T);
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x000055F8 File Offset: 0x000037F8
	internal static T ArrayFirstOrDefault<T>(T[] 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException();
		}
		if (1.Length != 0)
		{
			return 1[0];
		}
		return default(T);
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x00005623 File Offset: 0x00003823
	internal static bool ArrayHasItems<T>(T[] 1)
	{
		if (1 == null)
		{
			throw new ArgumentNullException();
		}
		return 1.Length != 0;
	}
}
