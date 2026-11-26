using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

// Token: 0x02000037 RID: 55
[ComVisible(false)]
public static class 45
{
	// Token: 0x06000178 RID: 376 RVA: 0x000083B8 File Offset: 0x000065B8
	public static T FindFromIndex<T>(this List<T> 1, Predicate<T> 2, int 3)
	{
		if (!1.IsValidIndex(3))
		{
			return default(T);
		}
		int 4 = 1.FindIndex(3, 1.Count - 3 - 1, 2);
		return 1.GetAtIndexOrDefault(4);
	}

	// Token: 0x06000179 RID: 377 RVA: 0x000083F4 File Offset: 0x000065F4
	public static int Method11157<T>(this List<T> 1, T 2)
	{
		int num = 1.BinarySearch(2);
		if (num < 0)
		{
			num = ~num;
		}
		1.Insert(num, 2);
		return num;
	}

	// Token: 0x0600017A RID: 378 RVA: 0x0000841C File Offset: 0x0000661C
	public static int Method11157<T>(this List<T> 1, T 2, IComparer<T> 3)
	{
		int num = 1.BinarySearch(2, 3);
		if (num < 0)
		{
			num = ~num;
		}
		1.Insert(num, 2);
		return num;
	}

	// Token: 0x0600017B RID: 379 RVA: 0x00008442 File Offset: 0x00006642
	public static bool IsValidIndex<T>(this List<T> 1, int 2)
	{
		return 2 >= 0 && 2 < 1.Count;
	}

	// Token: 0x0600017C RID: 380 RVA: 0x00008454 File Offset: 0x00006654
	public static T GetAtIndexOrDefault<T>(this List<T> 1, int 2)
	{
		if (!1.IsValidIndex(2))
		{
			return default(T);
		}
		return 1[2];
	}

	// Token: 0x0600017D RID: 381 RVA: 0x0000847C File Offset: 0x0000667C
	public static bool ElementsEqual<T>(this List<T> 1, List<T> 2)
	{
		45.46<T> 3 = new 45.46<T>();
		3._list8791 = 2;
		return 1.Count == 3._list8791.Count && !1.Where(new Func<T, int, bool>(3.Method11155)).Any<T>();
	}

	// Token: 0x0600017E RID: 382 RVA: 0x000084C5 File Offset: 0x000066C5
	public static double GetElapsedMilliseconds(this Stopwatch 1)
	{
		return (double)1.ElapsedTicks / (double)Stopwatch.Frequency * 1000.0;
	}

	// Token: 0x0600017F RID: 383 RVA: 0x000084E0 File Offset: 0x000066E0
	public static string ToDimensionString(this Size 1)
	{
		return 1.Width.ToString() + "x" + 1.Height.ToString();
	}

	// Token: 0x06000180 RID: 384 RVA: 0x00008518 File Offset: 0x00006718
	public static void WriteLineUtf8(this Stream 1, string 2)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(2 + "\r\n");
		1.Write(bytes, 0, bytes.Length);
	}

	// Token: 0x06000181 RID: 385 RVA: 0x00008548 File Offset: 0x00006748
	public static string ToUnsecureString(this SecureString 1)
	{
		IntPtr ptr = Marshal.SecureStringToBSTR(1);
		string result;
		try
		{
			result = Marshal.PtrToStringBSTR(ptr);
		}
		finally
		{
			Marshal.FreeBSTR(ptr);
		}
		return result;
	}

	// Token: 0x02000038 RID: 56
	public sealed class 46<TItem>
	{
		// Token: 0x06000182 RID: 386 RVA: 0x00008580 File Offset: 0x00006780
		internal bool Method11155(TItem 1, int 2)
		{
			ref TItem ptr = ref 1;
			if (default(TItem) == null)
			{
				TItem titem = 1;
				ptr = ref titem;
			}
			return !ptr.Equals(this._list8791[2]);
		}

		// Token: 0x0400008E RID: 142
		public List<TItem> _list8791;
	}
}
