using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

// Token: 0x02000122 RID: 290
[241(0)]
[242(1)]
public static class 418
{
	// Token: 0x06000A68 RID: 2664 RVA: 0x00027EBA File Offset: 0x000260BA
	public static bool Method3165<[241(2)] T>(ICollection<T> 1)
	{
		return 1 == null || 1.Count == 0;
	}

	// Token: 0x06000A69 RID: 2665 RVA: 0x00027ECC File Offset: 0x000260CC
	public static void Method3166<[241(2)] T>(this IList<T> 1, IEnumerable<T> 2)
	{
		if (1 == null)
		{
			throw new ArgumentNullException("#=z_TdWuEA=");
		}
		if (2 == null)
		{
			return;
		}
		foreach (T item in 2)
		{
			1.Add(item);
		}
	}

	// Token: 0x06000A6A RID: 2666 RVA: 0x00027F28 File Offset: 0x00026128
	public static bool Method3167(Type 1)
	{
		756.Method12216(1, "type");
		return typeof(IDictionary).IsAssignableFrom(1) || 143.Method3895(1, typeof(IDictionary<, >));
	}

	// Token: 0x06000A6B RID: 2667 RVA: 0x00027F60 File Offset: 0x00026160
	[return: 241(2)]
	public static ConstructorInfo Method3168(Type 1, Type 2)
	{
		Type 3 = typeof(IList<>).MakeGenericType(new Type[]
		{
			2
		});
		return 418.Method3168(1, 2, 3);
	}

	// Token: 0x06000A6C RID: 2668 RVA: 0x00027F90 File Offset: 0x00026190
	[return: 241(2)]
	public static ConstructorInfo Method3168(Type 1, Type 2, Type 3)
	{
		Type left = typeof(IEnumerable<>).MakeGenericType(new Type[]
		{
			2
		});
		ConstructorInfo constructorInfo = null;
		foreach (ConstructorInfo constructorInfo2 in 1.GetConstructors(BindingFlags.Instance | BindingFlags.Public))
		{
			IList<ParameterInfo> parameters = constructorInfo2.GetParameters();
			if (parameters.Count == 1)
			{
				Type parameterType = parameters[0].ParameterType;
				if (left == parameterType)
				{
					constructorInfo = constructorInfo2;
					break;
				}
				if (constructorInfo == null && parameterType.IsAssignableFrom(3))
				{
					constructorInfo = constructorInfo2;
				}
			}
		}
		return constructorInfo;
	}

	// Token: 0x06000A6D RID: 2669 RVA: 0x0002801D File Offset: 0x0002621D
	public static bool Method3170<[241(2)] T>(this IList<T> 1, T 2)
	{
		return 1.Method3170(2, EqualityComparer<T>.Default);
	}

	// Token: 0x06000A6E RID: 2670 RVA: 0x0002802B File Offset: 0x0002622B
	public static bool Method3170<[241(2)] T>(this IList<T> 1, T 2, IEqualityComparer<T> 3)
	{
		if (1.Method3172(2, 3))
		{
			return false;
		}
		1.Add(2);
		return true;
	}

	// Token: 0x06000A6F RID: 2671 RVA: 0x00028044 File Offset: 0x00026244
	public static bool Method3172<[241(2)] TSource>(this IEnumerable<TSource> 1, TSource 2, IEqualityComparer<TSource> 3)
	{
		if (3 == null)
		{
			3 = EqualityComparer<TSource>.Default;
		}
		if (1 == null)
		{
			throw new ArgumentNullException("#=zUCAUQIw=");
		}
		foreach (TSource x in 1)
		{
			if (3.Equals(x, 2))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000A70 RID: 2672 RVA: 0x000280B0 File Offset: 0x000262B0
	public static bool Method3173<[241(2)] T>(this IList<T> 1, IEnumerable<T> 2, IEqualityComparer<T> 3)
	{
		bool result = true;
		foreach (T 4 in 2)
		{
			if (!1.Method3170(4, 3))
			{
				result = false;
			}
		}
		return result;
	}

	// Token: 0x06000A71 RID: 2673 RVA: 0x00028100 File Offset: 0x00026300
	public static int Method3174<[241(2)] T>(this IEnumerable<T> 1, Func<T, bool> 2)
	{
		int num = 0;
		foreach (T arg in 1)
		{
			if (2(arg))
			{
				return num;
			}
			num++;
		}
		return -1;
	}

	// Token: 0x06000A72 RID: 2674 RVA: 0x00028158 File Offset: 0x00026358
	public static bool Method3175<[241(2)] T>(this List<T> 1, T 2, IEqualityComparer 3)
	{
		for (int i = 0; i < 1.Count; i++)
		{
			if (3.Equals(2, 1[i]))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000A73 RID: 2675 RVA: 0x00028194 File Offset: 0x00026394
	public static int Method3176<[241(2)] T>(this List<T> 1, T 2)
	{
		for (int i = 0; i < 1.Count; i++)
		{
			if (2 == 1[i])
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x06000A74 RID: 2676 RVA: 0x000281CC File Offset: 0x000263CC
	public static void Method3177<[241(2)] T>(this List<T> 1)
	{
		int i = 0;
		int num = 1.Count - 1;
		while (i < num)
		{
			T value = 1[i];
			1[i] = 1[num];
			1[num] = value;
			i++;
			num--;
		}
	}

	// Token: 0x06000A75 RID: 2677 RVA: 0x00028210 File Offset: 0x00026410
	private static IList<int> Method3178(IList 1, int 2)
	{
		IList<int> list = new List<int>();
		IList list2 = 1;
		for (;;)
		{
			list.Add(list2.Count);
			if (list.Count == 2 || list2.Count == 0)
			{
				break;
			}
			IList list3 = list2[0] as IList;
			if (list3 == null)
			{
				break;
			}
			list2 = list3;
		}
		return list;
	}

	// Token: 0x06000A76 RID: 2678 RVA: 0x00028258 File Offset: 0x00026458
	private static void Method3179(IList 1, Array 2, int[] 3)
	{
		int num = 3.Length;
		if (num == 2.Rank)
		{
			2.SetValue(418.Method3180(1, 3), 3);
			return;
		}
		int length = 2.GetLength(num);
		if (((IList)418.Method3180(1, 3)).Count != length)
		{
			throw new Exception("Cannot deserialize non-cubical array as multidimensional array.");
		}
		int[] array = new int[num + 1];
		for (int i = 0; i < num; i++)
		{
			array[i] = 3[i];
		}
		for (int j = 0; j < 2.GetLength(num); j++)
		{
			array[num] = j;
			418.Method3179(1, 2, array);
		}
	}

	// Token: 0x06000A77 RID: 2679 RVA: 0x000282E8 File Offset: 0x000264E8
	private static object Method3180(IList 1, int[] 2)
	{
		IList list = 1;
		for (int i = 0; i < 2.Length; i++)
		{
			int index = 2[i];
			if (i == 2.Length - 1)
			{
				return list[index];
			}
			list = (IList)list[index];
		}
		return list;
	}

	// Token: 0x06000A78 RID: 2680 RVA: 0x00028328 File Offset: 0x00026528
	public static Array Method3181(IList 1, Type 2, int 3)
	{
		IList<int> list = 418.Method3178(1, 3);
		while (list.Count < 3)
		{
			list.Add(0);
		}
		Array array = Array.CreateInstance(2, list.ToArray<int>());
		418.Method3179(1, array, 418.GetItemArray2540_3182<int>());
		return array;
	}

	// Token: 0x06000A79 RID: 2681 RVA: 0x00028369 File Offset: 0x00026569
	public static T[] GetItemArray2540_3182<[241(2)] T>()
	{
		return 418.419<T>._itemArray2540;
	}

	// Token: 0x02000123 RID: 291
	[242(0)]
	public static class 419<[241(2)] TItem>
	{
		// Token: 0x04000521 RID: 1313
		[241(1)]
		public static readonly TItem[] _itemArray2540 = new TItem[0];
	}
}
