using System;

// Token: 0x02000BC4 RID: 3012
public static class 1192
{
	// Token: 0x060052DB RID: 21211 RVA: 0x0020933C File Offset: 0x0020753C
	internal static bool 1<TEnum>(string 1, out TEnum 2)
	{
		if (1 == null)
		{
			throw new ArgumentNullException();
		}
		if (1.Length > 0)
		{
			foreach (object obj in Enum.GetValues(typeof(TEnum)))
			{
				if (1.StartsWith(obj.ToString()))
				{
					2 = (TEnum)((object)obj);
					return true;
				}
			}
		}
		2 = default(TEnum);
		return false;
	}
}
