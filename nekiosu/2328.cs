using System;
using System.Drawing;
using System.Windows.Forms;

// Token: 0x020005A0 RID: 1440
public static class 2328
{
	// Token: 0x06002C6D RID: 11373 RVA: 0x000F6244 File Offset: 0x000F4444
	internal static float 1(Control 1, bool 2)
	{
		if (!2 && 2328.1 > 0f)
		{
			return 2328.1;
		}
		float result;
		using (Graphics graphics = 1.CreateGraphics())
		{
			result = (2328.1 = graphics.DpiX);
		}
		return result;
	}

	// Token: 0x0400208B RID: 8331
	private static float 1;
}
