using System;
using System.Drawing;

// Token: 0x02000C57 RID: 3159
public static class 1045
{
	// Token: 0x060054B5 RID: 21685 RVA: 0x0020F9F8 File Offset: 0x0020DBF8
	internal static 198 1(198 1, float 2)
	{
		return new 198((byte)Math.Min(255f, (float)1.R * (1f + 2)), (byte)Math.Min(255f, (float)1.G * (1f + 2)), (byte)Math.Min(255f, (float)1.B * (1f + 2)), 1.A);
	}

	// Token: 0x060054B6 RID: 21686 RVA: 0x0020FA60 File Offset: 0x0020DC60
	internal static 198 2(198 1, float 2)
	{
		2 *= 0.5f;
		return new 198((byte)Math.Min(255f, (float)1.R * (1f + 0.5f * 2) + 255f * 2), (byte)Math.Min(255f, (float)1.G * (1f + 0.5f * 2) + 255f * 2), (byte)Math.Min(255f, (float)1.B * (1f + 0.5f * 2) + 255f * 2), 1.A);
	}

	// Token: 0x060054B7 RID: 21687 RVA: 0x0020FAFC File Offset: 0x0020DCFC
	internal static 198 3(198 1, float 2)
	{
		return new 198((byte)Math.Min(255f, (float)1.R / (1f + 2)), (byte)Math.Min(255f, (float)1.G / (1f + 2)), (byte)Math.Min(255f, (float)1.B / (1f + 2)), 1.A);
	}

	// Token: 0x060054B8 RID: 21688 RVA: 0x0020FB64 File Offset: 0x0020DD64
	internal static 198 4(198 1, 198 2, float 3)
	{
		return new 198((byte)1052.16((float)1.R, (float)2.R, 3), (byte)1052.16((float)1.G, (float)2.G, 3), (byte)1052.16((float)1.B, (float)2.B, 3), (byte)1052.16((float)1.A, (float)2.A, 3));
	}

	// Token: 0x060054B9 RID: 21689 RVA: 0x0020FBCC File Offset: 0x0020DDCC
	internal static Color 5(Color 1, Color 2, float 3)
	{
		return Color.FromArgb((int)((byte)1052.16((float)1.A, (float)2.A, 3)), (int)((byte)1052.16((float)1.R, (float)2.R, 3)), (int)((byte)1052.16((float)1.G, (float)2.G, 3)), (int)((byte)1052.16((float)1.B, (float)2.B, 3)));
	}

	// Token: 0x060054BA RID: 21690 RVA: 0x0020FC3A File Offset: 0x0020DE3A
	internal static string 6(198 1)
	{
		return string.Format("{0:X2}{1:X2}{2:X2}", 1.R, 1.G, 1.B);
	}

	// Token: 0x060054BB RID: 21691 RVA: 0x0020FC68 File Offset: 0x0020DE68
	internal static 198 7(string 1)
	{
		if (1.Length != 6)
		{
			return 198.White;
		}
		string value = 1.Substring(0, 2);
		string value2 = 1.Substring(2, 2);
		byte 2 = Convert.ToByte(1.Substring(4, 2), 16);
		return new 198(Convert.ToByte(value, 16), Convert.ToByte(value2, 16), 2);
	}

	// Token: 0x060054BC RID: 21692 RVA: 0x0020FCBA File Offset: 0x0020DEBA
	internal static 198 8(198 1, byte 2)
	{
		return new 198(1.R, 1.G, 1.B, 2);
	}
}
