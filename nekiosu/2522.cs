using System;
using System.Collections.Generic;

// Token: 0x02000534 RID: 1332
[276]
internal static class 2522
{
	// Token: 0x06002918 RID: 10520 RVA: 0x000D531A File Offset: 0x000D351A
	internal static void 1()
	{
		2522.1.Clear();
		2522.2.Clear();
		2522.4.Clear();
	}

	// Token: 0x06002919 RID: 10521 RVA: 0x000D533C File Offset: 0x000D353C
	internal static void 2(string 1, string 2, string 3, Func<2528> 4)
	{
		2522.2.RemoveAll((2522.2523 1) => 1.1 == 5);
		2522.2.Add(new 2522.2523
		{
			1 = 5,
			2 = 2,
			3 = 3,
			4 = 4
		});
	}

	// Token: 0x0600291A RID: 10522 RVA: 0x000D53A0 File Offset: 0x000D35A0
	internal static 2528 3(2528 1)
	{
		if (2 != null)
		{
			2522.1.RemoveAll((2528 1) => 1.3 == 2.3);
			2522.1.Add(2);
		}
		return 2;
	}

	// Token: 0x0600291B RID: 10523 RVA: 0x000D53F0 File Offset: 0x000D35F0
	internal static void 4(2528 1)
	{
		2522.1.Remove(1);
		foreach (1371 key in 1.28)
		{
			2522.4.Remove(key);
		}
	}

	// Token: 0x0600291C RID: 10524 RVA: 0x000D5454 File Offset: 0x000D3654
	internal static 2528 5(string 1)
	{
		return 2522.1.Find((2528 1) => string.Equals(1.3, 2, StringComparison.OrdinalIgnoreCase));
	}

	// Token: 0x0600291D RID: 10525 RVA: 0x000D5484 File Offset: 0x000D3684
	internal static 2528 6(string 1, string 2, 2509 3, Action 4, 208? 5 = null)
	{
		2528 6 = 2528.18();
		using (6.21())
		{
			4();
		}
		List<1371> list = 6.28.FindAll(delegate(1371 1)
		{
			1433 16 = 1 as 1433;
			return 16 != null && 2522.9(16);
		});
		if (list.Count > 0)
		{
			6.28.RemoveAll(new Predicate<1371>(list.Contains));
			2528 8 = 2522.5("frame") ?? 2522.3(2522.10());
			foreach (1371 9 in list)
			{
				8.22(9);
			}
		}
		208? 10 = 5;
		208? 11 = (10 != null) ? 10 : 2522.8(6.28);
		if (11 == null)
		{
			foreach (1371 12 in 6.28)
			{
				12.18 = null;
			}
			return null;
		}
		2528 13 = 2528.5(15, 2, 3, 11.Value, true, null);
		foreach (1371 14 in 6.28)
		{
			13.22(14);
		}
		return 2522.3(13);
	}

	// Token: 0x0600291E RID: 10526 RVA: 0x000D5634 File Offset: 0x000D3834
	internal static void 7(2528 1, 2509 2, Action 3)
	{
		2528 4 = 2528.18();
		using (4.21())
		{
			3();
		}
		foreach (1371 key in 1.28)
		{
			2522.4.Remove(key);
		}
		1.28.Clear();
		foreach (1371 6 in 4.28)
		{
			1.22(6);
		}
		208? 7 = 2522.8(4.28);
		if (7 != null)
		{
			bool flag = 1.8 == 1.6 && 1.9 == 1.7;
			1.6 = 2;
			1.7 = 7.Value - 2528.26(2, 2528.WindowWidth, 480f);
			if (flag)
			{
				1.8 = 1.6;
				1.9 = 1.7;
			}
		}
		1.32();
	}

	// Token: 0x0600291F RID: 10527 RVA: 0x000D578C File Offset: 0x000D398C
	private static 208? 8(List<1371> 1)
	{
		foreach (1371 2 in 1)
		{
			1433 3 = 2 as 1433;
			if (3 != null && 2528.25(3.41))
			{
				return new 208?(2528.6(3));
			}
		}
		return null;
	}

	// Token: 0x06002920 RID: 10528 RVA: 0x000D5804 File Offset: 0x000D3A04
	private static bool 9(1433 1)
	{
		1381 texture = 1.GetTexture();
		return texture != null && (texture.4() > 300 || texture.3() > 1200);
	}

	// Token: 0x06002921 RID: 10529 RVA: 0x000D583C File Offset: 0x000D3A3C
	private static 2528 10()
	{
		2528 frame = 2528.5("frame", "Playfield frame (skin)", 2509.Centre, new 208(2528.WindowWidth / 2f, 240f), true, null);
		frame.36 = delegate()
		{
			if (frame.28.Count != 0)
			{
				return null;
			}
			return new 1058?(new 1058(2f, 2f, 2528.WindowWidth - 4f, 476f));
		};
		return frame;
	}

	// Token: 0x06002922 RID: 10530 RVA: 0x000D589A File Offset: 0x000D3A9A
	internal static void 11()
	{
		if (2522.5("frame") == null)
		{
			2522.3(2522.10());
		}
	}

	// Token: 0x06002923 RID: 10531 RVA: 0x000D58B3 File Offset: 0x000D3AB3
	internal static bool 12(2528 1)
	{
		return 1.3 == "frame" && 1.28.Count == 0;
	}

	// Token: 0x06002924 RID: 10532 RVA: 0x000D58D7 File Offset: 0x000D3AD7
	internal static 2528 13(string 1, string 2, 2509 3, 1433 4, bool 5 = true)
	{
		if (4 == null)
		{
			return null;
		}
		2528 6 = 2528.4(1, 2, 4, 3, 5);
		6.22(4);
		return 2522.3(6);
	}

	// Token: 0x06002925 RID: 10533 RVA: 0x000D58F8 File Offset: 0x000D3AF8
	internal static 2528 14(string 1, string 2, 2509 3, 1436 4, 208 5)
	{
		if (4 == null)
		{
			return null;
		}
		2528 6 = 2528.5(1, 2, 3, 5, true, null);
		6.29 = 4;
		4.26 = 6;
		return 2522.3(6);
	}

	// Token: 0x06002926 RID: 10534 RVA: 0x000D592C File Offset: 0x000D3B2C
	internal static void 15()
	{
		bool flag = 2522.1.Exists((2528 1) => 1.20 != 0);
		List<2528> placements = 2522.1.FindAll((2528 1) => 1.29 == null && 1.28.Count > 0);
		List<int> list = new List<int>();
		for (int i = 0; i < placements.Count; i++)
		{
			list.Add(i);
		}
		list.Sort(delegate(int 1, int 2)
		{
			int num2 = placements[1].20.CompareTo(placements[2].20);
			if (num2 == 0)
			{
				return 1.CompareTo(2);
			}
			return num2;
		});
		for (int j = 0; j < list.Count; j++)
		{
			foreach (1371 <<EMPTY_NAME>> in placements[list[j]].28)
			{
				float num;
				if (!2522.4.TryGetValue(<<EMPTY_NAME>>, out num))
				{
					num = <<EMPTY_NAME>>.2;
					2522.4[<<EMPTY_NAME>>] = num;
				}
				<<EMPTY_NAME>>.2 = (flag ? (0.5f + (float)j * 0.02f + num * 0.01f) : num);
			}
		}
		foreach (1436 3 in 1436.3.ToArray())
		{
			if (3 != null && !3.42)
			{
				if (3.28.Exists((1371 1) => 1.18 != null))
				{
					3.13();
				}
			}
		}
	}

	// Token: 0x04001DB9 RID: 7609
	internal static readonly List<2528> 1 = new List<2528>();

	// Token: 0x04001DBA RID: 7610
	internal static readonly List<2522.2523> 2 = new List<2522.2523>();

	// Token: 0x04001DBB RID: 7611
	internal const string 3 = "frame";

	// Token: 0x04001DBC RID: 7612
	private static readonly Dictionary<1371, float> 4 = new Dictionary<1371, float>();

	// Token: 0x02000535 RID: 1333
	[276]
	internal sealed class 2523
	{
		// Token: 0x04001DBD RID: 7613
		public string 1;

		// Token: 0x04001DBE RID: 7614
		public string 2;

		// Token: 0x04001DBF RID: 7615
		public string 3;

		// Token: 0x04001DC0 RID: 7616
		public Func<2528> 4;
	}
}
