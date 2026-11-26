using System;
using System.Collections.Generic;
using OpenTK;

// Token: 0x02000A78 RID: 2680
public static class 1358
{
	// Token: 0x06004A41 RID: 19009 RVA: 0x001D73F8 File Offset: 0x001D55F8
	internal static bool 1()
	{
		if (!1304.65)
		{
			return true;
		}
		try
		{
			if (1358.2 != null)
			{
				1358.2.Dispose();
			}
			1358.2 = 1425.6(1510.Texture2D, 1049.BlurVertical, false);
			if (1358.3 != null)
			{
				1358.3.Dispose();
			}
			1358.3 = 1425.6(1510.Texture2D, 1049.BlurHorizontal, false);
		}
		catch
		{
			1304.65 = false;
			1763.4(1568.1(2679.BlurRenderer_InitializationFailed));
		}
		return true;
	}

	// Token: 0x06004A42 RID: 19010 RVA: 0x001D7480 File Offset: 0x001D5680
	internal static 1381 2(1381 1, int 2, 1060 3)
	{
		1358.1359 4 = new 1358.1359();
		4.1 = 2;
		4.2 = 3;
		if (!1304.65 || 4.1 == 0 || 1.gpuTexture.1)
		{
			return 1;
		}
		List<1357> list = null;
		if (!1358.1.TryGetValue(1, out list))
		{
			list = new List<1357>();
		}
		int num = list.FindIndex(new Predicate<1357>(4.1));
		if (num != -1)
		{
			return list[num].3;
		}
		if (1358.2 == null || 1358.3 == null)
		{
			1358.1();
		}
		2676 5 = 1358.2.1;
		string text = "texSize";
		object obj = 1358.3.1["texSize"] = new Vector2((float)1.1(), (float)1.2());
		5[text] = obj;
		1415 6 = new 1415(1.1(), 1.2(), null);
		1381 result;
		try
		{
			6.10();
			1.gpuTexture.Draw(208.Zero, 208.Zero, 198.White, new 208(1f, -1f), 0f, null, null);
			for (int i = 0; i < (int)4.2; i++)
			{
				1358.3.3();
				1358.3.1["radius"] = 4.1;
				6.5().Draw(208.Zero, 208.Zero, 198.White, new 208(1f, -1f), 0f, null, null);
				1358.3.4();
				1358.2.3();
				1358.2.1["radius"] = 4.1;
				6.5().Draw(208.Zero, 208.Zero, 198.White, new 208(1f, -1f), 0f, null, null);
				1358.2.4();
			}
			6.11();
			6.5().2 = 1.gpuTexture.2;
			1381 7 = new 1381(6.5(), null);
			list.Add(new 1357
			{
				2 = 4.2,
				1 = 4.1,
				3 = 7
			});
			1358.1[1] = list;
			result = 7;
		}
		finally
		{
			((IDisposable)6).Dispose();
		}
		return result;
	}

	// Token: 0x0400375B RID: 14171
	private static Dictionary<1381, List<1357>> 1 = new Dictionary<1381, List<1357>>();

	// Token: 0x0400375C RID: 14172
	private static 1426 2;

	// Token: 0x0400375D RID: 14173
	private static 1426 3;

	// Token: 0x02000A79 RID: 2681
	public sealed class 1359
	{
		// Token: 0x06004A44 RID: 19012 RVA: 0x001D7754 File Offset: 0x001D5954
		internal bool 1(1357 1)
		{
			return 1.1 == this.1 && 1.2 == this.2;
		}

		// Token: 0x0400375E RID: 14174
		public int 1;

		// Token: 0x0400375F RID: 14175
		public 1060 2;
	}
}
