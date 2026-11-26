using System;
using System.Collections.Generic;
using System.IO;

// Token: 0x02000B87 RID: 2951
internal static class 1287
{
	// Token: 0x0600511B RID: 20763 RVA: 0x0020157C File Offset: 0x001FF77C
	internal static void 1(1648 1)
	{
		1.Write("nekiosu-difficulty");
		1.Write(1287.1.Length);
		foreach (int value in 1287.1)
		{
			1.Write(value);
		}
	}

	// Token: 0x0600511C RID: 20764 RVA: 0x002015C0 File Offset: 0x001FF7C0
	internal static int[] 2(1647 1)
	{
		int[] array = new int[1287.1.Length];
		Stream baseStream = 1.BaseStream;
		if (!baseStream.CanSeek || baseStream.Length - baseStream.Position <= 0L || 1.ReadString() != "nekiosu-difficulty")
		{
			return array;
		}
		int num = 1.ReadInt32();
		for (int i = 0; i < num; i++)
		{
			int num2 = 1.ReadInt32();
			if (i < array.Length)
			{
				array[i] = num2;
			}
		}
		return array;
	}

	// Token: 0x0600511D RID: 20765 RVA: 0x00201638 File Offset: 0x001FF838
	internal static void 3(int[] 1, List<1262> 2)
	{
		for (int i = 0; i < 1287.1.Length; i++)
		{
			if (1[i] < 1287.1[i])
			{
				foreach (1262 3 in 2)
				{
					3.21((2147)i);
				}
			}
		}
	}

	// Token: 0x04003D9E RID: 15774
	private static readonly int[] 1 = new int[]
	{
		0,
		20261023,
		20261023,
		20261023
	};

	// Token: 0x04003D9F RID: 15775
	private const string 2 = "nekiosu-difficulty";
}
