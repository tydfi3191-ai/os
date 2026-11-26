using System;
using System.Collections;
using System.Collections.Generic;

// Token: 0x0200001D RID: 29
public static class 177
{
	// Token: 0x060000A6 RID: 166 RVA: 0x00005634 File Offset: 0x00003834
	public static void ClearLists(List<IList> 1)
	{
		if (1 == null)
		{
			return;
		}
		foreach (IList list in 1)
		{
			if (list != null)
			{
				list.Clear();
			}
		}
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x0000568C File Offset: 0x0000388C
	public static T[] StableSortedCopy<T>(IList<T> 1) where T : IComparable<!!0>
	{
		KeyValuePair<int, T>[] array = new KeyValuePair<int, T>[1.Count];
		T[] array2 = new T[1.Count];
		1.CopyTo(array2, 0);
		for (int i = 0; i < 1.Count; i++)
		{
			array[i] = new KeyValuePair<int, T>(i, 1[i]);
		}
		Array.Sort<KeyValuePair<int, T>, T>(array, array2, new 177.178<T>());
		return array2;
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x000056EC File Offset: 0x000038EC
	public static void Method12592<T>(List<T> 1, int 2, ref T 3)
	{
		T t = 1[2];
		1[2] = 3;
		3 = t;
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x00005718 File Offset: 0x00003918
	public static void Method12592<T>(List<T> 1, List<T> 2)
	{
		int i = 0;
		bool flag = i < 1.Count && i < 2.Count;
		while (flag)
		{
			T value = 1[i];
			1[i] = 2[i];
			2[i] = value;
			i++;
			flag = (i < 1.Count && i < 2.Count);
		}
		if (i < 1.Count)
		{
			while (i < 1.Count)
			{
				2.Add(1[i]);
				1.RemoveAt(i);
			}
			return;
		}
		if (i < 2.Count)
		{
			while (i < 2.Count)
			{
				1.Add(2[i]);
				2.RemoveAt(i);
			}
		}
	}

	// Token: 0x060000AA RID: 170 RVA: 0x000057CB File Offset: 0x000039CB
	public static void MoveAllTo<T>(List<T> 1, List<T> 2)
	{
		2.AddRange(1);
		1.Clear();
	}

	// Token: 0x060000AB RID: 171 RVA: 0x000057DC File Offset: 0x000039DC
	public static void RemoveCommonItems<T>(List<T> 1, List<T> 2)
	{
		int num = 2.Count;
		int num2 = 0;
		while (num2 < 1.Count && num > 0)
		{
			if (2.Remove(1[num2]))
			{
				num--;
				1.RemoveAt(num2);
				num2--;
			}
			num2++;
		}
	}

	// Token: 0x060000AC RID: 172 RVA: 0x00005824 File Offset: 0x00003A24
	public static bool IsSorted<T>(IList<T> 1, bool 2) where T : IComparable<!!0>
	{
		int i = 1;
		int count = 1.Count;
		while (i < count)
		{
			T t = 1[i - 1];
			int num = t.CompareTo(1[i]);
			if ((2 && num > 0) || (!2 && num < 0))
			{
				return false;
			}
			i++;
		}
		return true;
	}

	// Token: 0x0200001E RID: 30
	public sealed class 178<TItem> : IComparer<KeyValuePair<int, !0>> where TItem : IComparable<!0>
	{
		// Token: 0x060000AD RID: 173 RVA: 0x00005874 File Offset: 0x00003A74
		public int Compare(KeyValuePair<int, TItem> 1, KeyValuePair<int, TItem> 2)
		{
			TItem value = 1.Value;
			int num = value.CompareTo(2.Value);
			if (num == 0)
			{
				return 1.Key.CompareTo(2.Key);
			}
			return num;
		}
	}
}
