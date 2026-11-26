using System;
using OpenTK.Graphics.ES20;

// Token: 0x02000AE1 RID: 2785
public static class 1507
{
	// Token: 0x06004DA4 RID: 19876 RVA: 0x001EC434 File Offset: 0x001EA634
	public static void 1(int 1)
	{
		if (1507.2 != 1379.BufferContextGeneration)
		{
			1507.1 = 0;
			1507.2 = 1379.BufferContextGeneration;
		}
		if (1 == 1507.1)
		{
			return;
		}
		if (1 > 1507.1)
		{
			for (int i = 1507.1; i < 1; i++)
			{
				GL.EnableVertexAttribArray(i);
			}
		}
		else
		{
			for (int j = 1507.1 - 1; j >= 1; j--)
			{
				GL.DisableVertexAttribArray(j);
			}
		}
		1507.1 = 1;
	}

	// Token: 0x040039E6 RID: 14822
	private static int 1;

	// Token: 0x040039E7 RID: 14823
	private static int 2 = -1;
}
