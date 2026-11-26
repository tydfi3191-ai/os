using System;
using System.Collections.Generic;
using System.IO;

// Token: 0x02000AC0 RID: 2752
internal static class 1428
{
	// Token: 0x06004C5C RID: 19548 RVA: 0x001E2544 File Offset: 0x001E0744
	internal static void Apply(1436 1, 1262 2)
	{
		if (1 == null)
		{
			return;
		}
		object obj = 1428.3;
		lock (obj)
		{
			if (1428.5 == null)
			{
				1428.5 = new 1453(2048, 2048);
			}
			List<1371> 3 = 1.28;
			List<1371> list;
			lock (3)
			{
				list = new List<1371>(1.28);
			}
			foreach (1371 4 in list)
			{
				1353 5 = 4 as 1353;
				if (5 == null)
				{
					1351 6 = 4 as 1351;
					if (6 == null)
					{
						if (!(4 is 1452))
						{
							1433 7 = 4 as 1433;
							if (7 != null)
							{
								1381 texture = 7.GetTexture();
								1381 8 = 1428.1(texture, 2);
								if (8 != texture)
								{
									int 9 = 7.36;
									int 10 = 7.37;
									int 11 = 7.35;
									int 12 = 7.34;
									7.SetTexture(8);
									7.36 = 9;
									7.37 = 10;
									7.35 = 11;
									7.34 = 12;
								}
							}
						}
					}
					else
					{
						1381[] array = 6.54();
						if (array != null && array.Length != 0)
						{
							1381[] array2 = new 1381[array.Length];
							for (int i = 0; i < array.Length; i++)
							{
								array2[i] = 1428.1(array[i], 2);
							}
							6.55(array2);
						}
					}
				}
				else
				{
					5.GetTextSize();
					for (int j = 0; j < 5.95.Count; j++)
					{
						5.95[j] = 1428.1(5.95[j], 2);
					}
				}
			}
		}
	}

	// Token: 0x06004C5D RID: 19549 RVA: 0x001E2774 File Offset: 0x001E0974
	private static 1381 1(1381 1, 1262 2)
	{
		if (1 == null || 1.5() || string.IsNullOrEmpty(1.1) || 1.1() > 1024 || 1.2() > 1024)
		{
			return 1;
		}
		1381 3;
		if (1428.4.TryGetValue(1, out 3) && 3 != null && !3.5())
		{
			return 3;
		}
		1381 4 = null;
		try
		{
			switch (1.6)
			{
			case (1416)1:
				4 = (File.Exists(1.1) ? 1381.13(1.1, 1428.5) : 1381.11(1.1, 1428.5));
				break;
			case (1416)2:
				4 = 1381.13(1.1, 1428.5);
				break;
			case (1416)4:
				using (Stream stream = (2 != null) ? 2.48(1.1) : null)
				{
					4 = 1381.14(stream, 1428.5);
				}
				break;
			}
		}
		catch
		{
			4 = null;
		}
		if (4 == null || 4.1() != 1.1() || 4.2() != 1.2())
		{
			1428.4[1] = 1;
			return 1;
		}
		4.resolutionScale = 1.resolutionScale;
		4.2 = 1.2;
		4.6 = 1.6;
		4.1 = 1.1;
		4.18();
		1428.4[1] = 4;
		return 4;
	}

	// Token: 0x040038D1 RID: 14545
	private const int 1 = 2048;

	// Token: 0x040038D2 RID: 14546
	private const int 2 = 1024;

	// Token: 0x040038D3 RID: 14547
	private static readonly object 3 = new object();

	// Token: 0x040038D4 RID: 14548
	private static readonly Dictionary<1381, 1381> 4 = new Dictionary<1381, 1381>();

	// Token: 0x040038D5 RID: 14549
	private static 1453 5;
}
