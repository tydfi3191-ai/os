using System;
using OpenTK.Graphics.ES20;

// Token: 0x02000B21 RID: 2849
public static class 1393
{
	// Token: 0x06004F05 RID: 20229 RVA: 0x001F35B4 File Offset: 0x001F17B4
	internal static void 1(int 1)
	{
		if (1 < 0 || 1 > 65536)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		if (1393.3 != 1379.BufferContextGeneration)
		{
			GL.GenBuffers(1, ref 1393.1);
			1393.3 = 1379.BufferContextGeneration;
			1393.2 = 0;
		}
		1379.32(34963, 1393.1);
		if (1 <= 1393.2)
		{
			return;
		}
		ushort[] array = new ushort[1];
		for (int i = 0; i < 1; i++)
		{
			array[i] = (ushort)i;
		}
		GL.BufferData<ushort>(34963, (IntPtr)(1 * 2), array, 35044);
		1393.2 = 1;
	}

	// Token: 0x04003AFB RID: 15099
	public static int 1;

	// Token: 0x04003AFC RID: 15100
	public static int 2;

	// Token: 0x04003AFD RID: 15101
	private static int 3 = -1;
}
