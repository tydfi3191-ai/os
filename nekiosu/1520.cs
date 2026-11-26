using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

// Token: 0x02000A43 RID: 2627
[ComVisible(false)]
public static class 1520
{
	// Token: 0x060048CB RID: 18635 RVA: 0x001CDE17 File Offset: 0x001CC017
	public static 1514 1(string 1)
	{
		return 1520.2(1, false, false);
	}

	// Token: 0x060048CC RID: 18636 RVA: 0x001CDE24 File Offset: 0x001CC024
	public static 1514 2(string 1, bool 2, bool 3)
	{
		object obj = 1520.3;
		1514 result;
		lock (obj)
		{
			1520.1521 4 = new 1520.1521();
			4.1 = Path.GetFullPath(1);
			1514 5 = 1520.1.Find(new Predicate<1514>(4.1));
			if (5 != null && 5.20)
			{
				1520.3(5);
				5 = null;
			}
			if (5 == null)
			{
				try
				{
					5 = new 1514(4.1, null, 2, 3);
				}
				catch (Exception)
				{
					return null;
				}
				1520.1.Add(5);
			}
			result = 5;
		}
		return result;
	}

	// Token: 0x060048CD RID: 18637 RVA: 0x001CDED0 File Offset: 0x001CC0D0
	public static void 3(1514 1)
	{
		if (1 == null)
		{
			return;
		}
		object obj = 1520.3;
		lock (obj)
		{
			1.Close();
			1520.1.Remove(1);
		}
	}

	// Token: 0x040035B7 RID: 13751
	private static List<1514> 1 = new List<1514>();

	// Token: 0x040035B8 RID: 13752
	private static List<AutoResetEvent> 2 = new List<AutoResetEvent>();

	// Token: 0x040035B9 RID: 13753
	private static object 3 = new object();

	// Token: 0x02000A44 RID: 2628
	public sealed class 1521
	{
		// Token: 0x060048CF RID: 18639 RVA: 0x001CDF40 File Offset: 0x001CC140
		internal bool 1(1514 1)
		{
			return 1.24().Equals(this.1);
		}

		// Token: 0x040035BA RID: 13754
		public string 1;
	}
}
