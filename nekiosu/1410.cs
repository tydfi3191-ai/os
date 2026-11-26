using System;
using OpenTK.Graphics.ES20;

// Token: 0x02000AAC RID: 2732
public static class 1410
{
	// Token: 0x06004BCF RID: 19407 RVA: 0x001DFCB8 File Offset: 0x001DDEB8
	internal static void 1(int 1)
	{
		if (1 < 0 || 1 > 16384)
		{
			throw new ArgumentOutOfRangeException("quadCount");
		}
		int num = 1 * 6;
		if (1410.3 != 1379.BufferContextGeneration)
		{
			GL.GenBuffers(1, ref 1410.1);
			1410.3 = 1379.BufferContextGeneration;
			1410.2 = 0;
		}
		1379.32(34963, 1410.1);
		if (num <= 1410.2)
		{
			return;
		}
		ushort[] array = new ushort[num];
		int i = 0;
		int num2 = 0;
		while (i < num)
		{
			array[i] = (ushort)num2;
			array[i + 1] = (ushort)(num2 + 1);
			array[i + 2] = (ushort)(num2 + 3);
			array[i + 3] = (ushort)(num2 + 2);
			array[i + 4] = (ushort)(num2 + 3);
			array[i + 5] = (ushort)(num2 + 1);
			i += 6;
			num2 += 4;
		}
		GL.BufferData<ushort>(34963, (IntPtr)(num * 2), array, 35044);
		1410.2 = num;
	}

	// Token: 0x04003876 RID: 14454
	public static int 1;

	// Token: 0x04003877 RID: 14455
	public static int 2;

	// Token: 0x04003878 RID: 14456
	private static int 3 = -1;
}
