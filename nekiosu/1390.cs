using System;
using System.Drawing;
using System.IO;

// Token: 0x02000A9F RID: 2719
public static class 1390
{
	// Token: 0x06004B7B RID: 19323 RVA: 0x001DDE94 File Offset: 0x001DC094
	public static Bitmap 1(string 1)
	{
		Stream manifestResourceStream = typeof(1390).Assembly.GetManifestResourceStream("nekiosu.Textures." + 1 + ".png");
		if (manifestResourceStream == null)
		{
			return null;
		}
		Bitmap result;
		using (manifestResourceStream)
		{
			using (Bitmap bitmap = new Bitmap(manifestResourceStream))
			{
				result = new Bitmap(bitmap);
			}
		}
		return result;
	}

	// Token: 0x0400383F RID: 14399
	private const string 1 = "nekiosu.Textures.";
}
