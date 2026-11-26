using System;
using System.Collections.Generic;
using System.Drawing;

// Token: 0x02000C70 RID: 3184
public sealed class 1052
{
	// Token: 0x060054FD RID: 21757 RVA: 0x00210F85 File Offset: 0x0020F185
	internal static List<208> 1(List<208> 1)
	{
		return new 1052.1053(1).4();
	}

	// Token: 0x060054FE RID: 21758 RVA: 0x00210F94 File Offset: 0x0020F194
	internal static List<208> 2(List<208> 1)
	{
		int count = 1.Count;
		208[] array = new 208[count];
		List<208> list = new List<208>();
		int num = 50 * count;
		for (int i = 0; i < num; i++)
		{
			for (int j = 0; j < count; j++)
			{
				array[j] = 1[j];
			}
			for (int k = 0; k < count; k++)
			{
				for (int l = 0; l < count - k - 1; l++)
				{
					208.Lerp(ref array[l], ref array[l + 1], (float)i / (float)num, out array[l]);
				}
			}
			list.Add(array[0]);
		}
		return list;
	}

	// Token: 0x060054FF RID: 21759 RVA: 0x00211045 File Offset: 0x0020F245
	internal static bool 3(208 1, 208 2, 208 3)
	{
		return (2.X - 1.X) * (3.Y - 1.Y) - (3.X - 1.X) * (2.Y - 1.Y) == 0f;
	}

	// Token: 0x06005500 RID: 21760 RVA: 0x00211085 File Offset: 0x0020F285
	internal static Color 4(198 1)
	{
		return Color.FromArgb((int)1.A, (int)1.R, (int)1.G, (int)1.B);
	}

	// Token: 0x06005501 RID: 21761 RVA: 0x002110A4 File Offset: 0x0020F2A4
	internal static void 5(208 1, 208 2, 208 3, out 208 4, out float 5, out double 6, out double 7)
	{
		float num = 2f * (1.X * (2.Y - 3.Y) + 2.X * (3.Y - 1.Y) + 3.X * (1.Y - 2.Y));
		float num2 = 1.LengthSquared();
		float num3 = 2.LengthSquared();
		float num4 = 3.LengthSquared();
		4 = new 208((num2 * (2.Y - 3.Y) + num3 * (3.Y - 1.Y) + num4 * (1.Y - 2.Y)) / num, (num2 * (3.X - 2.X) + num3 * (1.X - 3.X) + num4 * (2.X - 1.X)) / num);
		5 = 208.Distance(4, 1);
		6 = 1052.6(1, 4);
		double num5 = 1052.6(2, 4);
		7 = 1052.6(3, 4);
		while (num5 < 6)
		{
			num5 += 6.2831854820251465;
		}
		while (7 < 6)
		{
			7 += 6.2831854820251465;
		}
		if (num5 > 7)
		{
			7 -= 6.2831854820251465;
		}
	}

	// Token: 0x06005502 RID: 21762 RVA: 0x002111FE File Offset: 0x0020F3FE
	internal static double 6(208 1, 208 2)
	{
		return Math.Atan2((double)(1.Y - 2.Y), (double)(1.X - 2.X));
	}

	// Token: 0x06005503 RID: 21763 RVA: 0x00211221 File Offset: 0x0020F421
	internal static 208 7(208 1, float 2, double 3)
	{
		return new 208((float)(Math.Cos(3) * (double)2), (float)(Math.Sin(3) * (double)2)) + 1;
	}

	// Token: 0x06005504 RID: 21764 RVA: 0x00211242 File Offset: 0x0020F442
	internal static float 8(float 1, float 2, float 3, float 4)
	{
		return (float)1052.14((1046)4, (double)1, (double)2, (double)(3 - 2), (double)4);
	}

	// Token: 0x06005505 RID: 21765 RVA: 0x00211255 File Offset: 0x0020F455
	internal static float 9(float 1, float 2, float 3, float 4)
	{
		return (float)1052.14((1046)3, (double)1, (double)2, (double)(3 - 2), (double)4);
	}

	// Token: 0x06005506 RID: 21766 RVA: 0x00211268 File Offset: 0x0020F468
	public static 198 10(198 1, 198 2, int 3, int 4, int 5, 1046 6)
	{
		if (1 == 2)
		{
			return 1;
		}
		int num = 3 - 4;
		int num2 = 5 - 4;
		if (num2 == 0 || num == 0)
		{
			return 1;
		}
		return new 198((byte)Math.Max(0.0, Math.Min(255.0, 1052.14(6, (double)num, (double)1.R, (double)(2.R - 1.R), (double)num2))), (byte)Math.Max(0.0, Math.Min(255.0, 1052.14(6, (double)num, (double)1.G, (double)(2.G - 1.G), (double)num2))), (byte)Math.Max(0.0, Math.Min(255.0, 1052.14(6, (double)num, (double)1.B, (double)(2.B - 1.B), (double)num2))), (byte)Math.Max(0.0, Math.Min(255.0, 1052.14(6, (double)num, (double)1.A, (double)(2.A - 1.A), (double)num2))));
	}

	// Token: 0x06005507 RID: 21767 RVA: 0x0021138C File Offset: 0x0020F58C
	public static float 11(float 1, float 2, int 3, int 4, int 5, 1046 6)
	{
		if (1 == 2)
		{
			return 1;
		}
		int num = 3 - 4;
		int num2 = 5 - 4;
		if (num == 0)
		{
			return 1;
		}
		if (num2 == 0)
		{
			return 2;
		}
		return (float)1052.14(6, (double)num, (double)1, (double)(2 - 1), (double)num2);
	}

	// Token: 0x06005508 RID: 21768 RVA: 0x002113C4 File Offset: 0x0020F5C4
	internal static 208 12(208 1, 208 2, double 3, double 4, float 5, 1046 6)
	{
		float num = (float)(3 - 4);
		float num2 = (float)((double)5 - 4);
		if (num2 == 0f || num == 0f)
		{
			return 1;
		}
		return new 208((float)1052.14(6, (double)num, (double)1.X, (double)(2.X - 1.X), (double)num2), (float)1052.14(6, (double)num, (double)1.Y, (double)(2.Y - 1.Y), (double)num2));
	}

	// Token: 0x06005509 RID: 21769 RVA: 0x00211438 File Offset: 0x0020F638
	internal static 1058 13(1058 1, 1058 2, double 3, double 4, float 5, 1046 6)
	{
		float num = (float)(3 - 4);
		float num2 = (float)((double)5 - 4);
		if (num2 == 0f || num == 0f)
		{
			return 1;
		}
		return new 1058((float)1052.14(6, (double)num, (double)1.X, (double)(2.X - 1.X), (double)num2), (float)1052.14(6, (double)num, (double)1.Y, (double)(2.Y - 1.Y), (double)num2), (float)1052.14(6, (double)num, (double)1.Width, (double)(2.Width - 1.Width), (double)num2), (float)1052.14(6, (double)num, (double)1.Height, (double)(2.Height - 1.Height), (double)num2));
	}

	// Token: 0x0600550A RID: 21770 RVA: 0x002114EC File Offset: 0x0020F6EC
	internal static double 14(1046 1, double 2, double 3, double 4, double 5)
	{
		if (4 == 0.0 || 2 == 0.0 || 5 == 0.0)
		{
			return 3;
		}
		if (2 == 5)
		{
			return 3 + 4;
		}
		switch (1)
		{
		case (1046)1:
		case (1046)4:
			return (0.0 - 4) * (2 /= 5) * (2 - 2.0) + 3;
		case (1046)2:
		case (1046)3:
			return 4 * (2 /= 5) * 2 + 3;
		case (1046)5:
			if ((2 /= 5 / 2.0) < 1.0)
			{
				return 4 / 2.0 * 2 * 2 + 3;
			}
			return (0.0 - 4) / 2.0 * ((2 -= 1.0) * (2 - 2.0) - 1.0) + 3;
		case (1046)6:
			return 4 * (2 /= 5) * 2 * 2 + 3;
		case (1046)7:
			return 4 * ((2 = 2 / 5 - 1.0) * 2 * 2 + 1.0) + 3;
		case (1046)8:
			if ((2 /= 5 / 2.0) < 1.0)
			{
				return 4 / 2.0 * 2 * 2 * 2 + 3;
			}
			return 4 / 2.0 * ((2 -= 2.0) * 2 * 2 + 2.0) + 3;
		case (1046)9:
			return 4 * (2 /= 5) * 2 * 2 * 2 + 3;
		case (1046)10:
			return (0.0 - 4) * ((2 = 2 / 5 - 1.0) * 2 * 2 * 2 - 1.0) + 3;
		case (1046)11:
			if ((2 /= 5 / 2.0) < 1.0)
			{
				return 4 / 2.0 * 2 * 2 * 2 * 2 + 3;
			}
			return (0.0 - 4) / 2.0 * ((2 -= 2.0) * 2 * 2 * 2 - 2.0) + 3;
		case (1046)12:
			return 4 * (2 /= 5) * 2 * 2 * 2 * 2 + 3;
		case (1046)13:
			return 4 * ((2 = 2 / 5 - 1.0) * 2 * 2 * 2 * 2 + 1.0) + 3;
		case (1046)14:
			if ((2 /= 5 / 2.0) < 1.0)
			{
				return 4 / 2.0 * 2 * 2 * 2 * 2 * 2 + 3;
			}
			return 4 / 2.0 * ((2 -= 2.0) * 2 * 2 * 2 * 2 + 2.0) + 3;
		case (1046)15:
			return (0.0 - 4) * Math.Cos(2 / 5 * 1.5707963705062866) + 4 + 3;
		case (1046)16:
			return 4 * Math.Sin(2 / 5 * 1.5707963705062866) + 3;
		case (1046)17:
			return (0.0 - 4) / 2.0 * (Math.Cos(3.1415927410125732 * 2 / 5) - 1.0) + 3;
		case (1046)18:
			return 4 * Math.Pow(2.0, 10.0 * (2 / 5 - 1.0)) + 3;
		case (1046)19:
			if (2 != 5)
			{
				return 4 * (0.0 - Math.Pow(2.0, -10.0 * 2 / 5) + 1.0) + 3;
			}
			return 3 + 4;
		case (1046)20:
			if ((2 /= 5 / 2.0) < 1.0)
			{
				return 4 / 2.0 * Math.Pow(2.0, 10.0 * (2 - 1.0)) + 3;
			}
			return 4 / 2.0 * (0.0 - Math.Pow(2.0, -10.0 * (2 -= 1.0)) + 2.0) + 3;
		case (1046)21:
			return (0.0 - 4) * (Math.Sqrt(1.0 - (2 /= 5) * 2) - 1.0) + 3;
		case (1046)22:
			return 4 * Math.Sqrt(1.0 - (2 = 2 / 5 - 1.0) * 2) + 3;
		case (1046)23:
			if ((2 /= 5 / 2.0) < 1.0)
			{
				return (0.0 - 4) / 2.0 * (Math.Sqrt(1.0 - 2 * 2) - 1.0) + 3;
			}
			return 4 / 2.0 * (Math.Sqrt(1.0 - (2 -= 2.0) * 2) + 1.0) + 3;
		case (1046)24:
		{
			if ((2 /= 5) == 1.0)
			{
				return 3 + 4;
			}
			double num = 5 * 0.3;
			double num2 = 4;
			double num3;
			if (num2 < Math.Abs(4))
			{
				num2 = 4;
				num3 = num / 4.0;
			}
			else
			{
				num3 = num / 6.2831854820251465 * Math.Asin(4 / num2);
			}
			return 0.0 - num2 * Math.Pow(2.0, 10.0 * (2 -= 1.0)) * Math.Sin((2 * 5 - num3) * 6.2831854820251465 / num) + 3;
		}
		case (1046)25:
		{
			if ((2 /= 5) == 1.0)
			{
				return 3 + 4;
			}
			double num4 = 5 * 0.3;
			double num5 = 4;
			double num6;
			if (num5 < Math.Abs(4))
			{
				num5 = 4;
				num6 = num4 / 4.0;
			}
			else
			{
				num6 = num4 / 6.2831854820251465 * Math.Asin(4 / num5);
			}
			return num5 * Math.Pow(2.0, -10.0 * 2) * Math.Sin((2 * 5 - num6) * 6.2831854820251465 / num4) + 4 + 3;
		}
		case (1046)26:
		{
			if ((2 /= 5) == 1.0)
			{
				return 3 + 4;
			}
			double num7 = 5 * 0.3;
			double num8 = 4;
			double num9;
			if (num8 < Math.Abs(4))
			{
				num8 = 4;
				num9 = num7 / 4.0;
			}
			else
			{
				num9 = num7 / 6.2831854820251465 * Math.Asin(4 / num8);
			}
			return num8 * Math.Pow(2.0, -10.0 * 2) * Math.Sin((0.5 * 2 * 5 - num9) * 6.2831854820251465 / num7) + 4 + 3;
		}
		case (1046)27:
		{
			if ((2 /= 5) == 1.0)
			{
				return 3 + 4;
			}
			double num10 = 5 * 0.3;
			double num11 = 4;
			double num12;
			if (num11 < Math.Abs(4))
			{
				num11 = 4;
				num12 = num10 / 4.0;
			}
			else
			{
				num12 = num10 / 6.2831854820251465 * Math.Asin(4 / num11);
			}
			return num11 * Math.Pow(2.0, -10.0 * 2) * Math.Sin((0.25 * 2 * 5 - num12) * 6.2831854820251465 / num10) + 4 + 3;
		}
		case (1046)28:
		{
			if ((2 /= 5 / 2.0) == 2.0)
			{
				return 3 + 4;
			}
			double num13 = 5 * 0.44999999999999996;
			double num14 = 4;
			double num15;
			if (num14 < Math.Abs(4))
			{
				num14 = 4;
				num15 = num13 / 4.0;
			}
			else
			{
				num15 = num13 / 6.2831854820251465 * Math.Asin(4 / num14);
			}
			if (2 < 1.0)
			{
				return -0.5 * (num14 * Math.Pow(2.0, 10.0 * (2 -= 1.0)) * Math.Sin((2 * 5 - num15) * 6.2831854820251465 / num13)) + 3;
			}
			return num14 * Math.Pow(2.0, -10.0 * (2 -= 1.0)) * Math.Sin((2 * 5 - num15) * 6.2831854820251465 / num13) * 0.5 + 4 + 3;
		}
		case (1046)29:
		{
			double num16 = 1.70158;
			return 4 * (2 /= 5) * 2 * ((num16 + 1.0) * 2 - num16) + 3;
		}
		case (1046)30:
		{
			double num17 = 1.70158;
			return 4 * ((2 = 2 / 5 - 1.0) * 2 * ((num17 + 1.0) * 2 + num17) + 1.0) + 3;
		}
		case (1046)31:
		{
			double num18 = 1.70158;
			if ((2 /= 5 / 2.0) < 1.0)
			{
				return 4 / 2.0 * (2 * 2 * (((num18 *= 1.525) + 1.0) * 2 - num18)) + 3;
			}
			return 4 / 2.0 * ((2 -= 2.0) * 2 * (((num18 *= 1.525) + 1.0) * 2 + num18) + 2.0) + 3;
		}
		case (1046)32:
			return 4 - 1052.14((1046)33, 5 - 2, 0.0, 4, 5) + 3;
		case (1046)33:
			if ((2 /= 5) < 0.36363636363636365)
			{
				return 4 * (7.5625 * 2 * 2) + 3;
			}
			if (2 < 0.7272727272727273)
			{
				return 4 * (7.5625 * (2 -= 0.5454545454545454) * 2 + 0.75) + 3;
			}
			if (2 < 0.9090909090909091)
			{
				return 4 * (7.5625 * (2 -= 0.8181818181818182) * 2 + 0.9375) + 3;
			}
			return 4 * (7.5625 * (2 -= 0.9545454545454546) * 2 + 0.984375) + 3;
		case (1046)34:
			if (2 < 5 / 2.0)
			{
				return 1052.14((1046)32, 2 * 2.0, 0.0, 4, 5) * 0.5 + 3;
			}
			return 1052.14((1046)33, 2 * 2.0 - 5, 0.0, 4, 5) * 0.5 + 4 * 0.5 + 3;
		default:
			return 4 * (2 / 5) + 3;
		}
	}

	// Token: 0x0600550B RID: 21771 RVA: 0x00212098 File Offset: 0x00210298
	public static float 15(float 1)
	{
		return 1 * 0.017453292f;
	}

	// Token: 0x0600550C RID: 21772 RVA: 0x002120A1 File Offset: 0x002102A1
	public static float Min(float 1, float 2)
	{
		return Math.Min(1, 2);
	}

	// Token: 0x0600550D RID: 21773 RVA: 0x002120AA File Offset: 0x002102AA
	public static float Max(float 1, float 2)
	{
		return Math.Max(1, 2);
	}

	// Token: 0x0600550E RID: 21774 RVA: 0x002120B3 File Offset: 0x002102B3
	public static float 16(float 1, float 2, float 3)
	{
		return 1 + (2 - 1) * 3;
	}

	// Token: 0x0600550F RID: 21775 RVA: 0x002120B3 File Offset: 0x002102B3
	public static double 17(double 1, double 2, double 3)
	{
		return 1 + (2 - 1) * 3;
	}

	// Token: 0x06005510 RID: 21776 RVA: 0x002120BC File Offset: 0x002102BC
	internal static int 18(int 1, int 2, int 3)
	{
		if (1 > 3)
		{
			return 3;
		}
		if (1 < 2)
		{
			return 2;
		}
		return 1;
	}

	// Token: 0x06005511 RID: 21777 RVA: 0x002120CB File Offset: 0x002102CB
	internal static float 19(float 1, float 2, float 3)
	{
		if (float.IsNaN(2) || float.IsNaN(3))
		{
			return float.NaN;
		}
		if (1 > 3)
		{
			return 3;
		}
		if (1 < 2)
		{
			return 2;
		}
		return 1;
	}

	// Token: 0x06005512 RID: 21778 RVA: 0x002120F0 File Offset: 0x002102F0
	internal static double 20(double 1, double 2, double 3)
	{
		if (double.IsNaN(2) || double.IsNaN(3))
		{
			return double.NaN;
		}
		if (1 > 3)
		{
			return 3;
		}
		if (1 < 2)
		{
			return 2;
		}
		return 1;
	}

	// Token: 0x06005513 RID: 21779 RVA: 0x0021211C File Offset: 0x0021031C
	internal static double 21(double 1, uint 2)
	{
		double num = Math.Pow(10.0, 2);
		return Math.Floor(1 * num) / num;
	}

	// Token: 0x06005514 RID: 21780 RVA: 0x00212145 File Offset: 0x00210345
	internal static 208 22(208 1, float 2)
	{
		return new 208(1.X, 2 - 1.Y);
	}

	// Token: 0x06005515 RID: 21781 RVA: 0x0021215A File Offset: 0x0021035A
	internal static 208 23(208 1, float 2)
	{
		return new 208(2 - 1.X, 1.Y);
	}

	// Token: 0x06005516 RID: 21782 RVA: 0x0021216F File Offset: 0x0021036F
	internal static 208 24(208 1, 208 2)
	{
		return new 208(0f - (1.Y - 2.Y) + 2.X, 1.X - 2.X + 2.Y);
	}

	// Token: 0x06005517 RID: 21783 RVA: 0x002121A4 File Offset: 0x002103A4
	internal static 208 25(208 1, 208 2)
	{
		return new 208(1.Y - 2.Y + 2.X, 0f - (1.X - 2.X) + 2.Y);
	}

	// Token: 0x06005518 RID: 21784 RVA: 0x002121DC File Offset: 0x002103DC
	internal static 208 26(208 1, 208 2, int 3)
	{
		3 = -3;
		1.X -= 2.X;
		1.Y -= 2.Y;
		208 result = default(208);
		result.X = (float)((double)1.X * Math.Cos((double)((float)3 / 180f) * 3.141592653589793) + (double)1.Y * Math.Sin((double)((float)3 / 180f) * 3.141592653589793));
		result.Y = (float)((double)1.X * (0.0 - Math.Sin((double)((float)3 / 180f) * 3.141592653589793)) + (double)1.Y * Math.Cos((double)((float)3 / 180f) * 3.141592653589793));
		result.X += 2.X;
		result.Y += 2.Y;
		return result;
	}

	// Token: 0x06005519 RID: 21785 RVA: 0x002122D6 File Offset: 0x002104D6
	internal static 208 27(208 1, 208 2, float 3)
	{
		return 3 * 1 + (1f - 3) * 2;
	}

	// Token: 0x0600551A RID: 21786 RVA: 0x002122F4 File Offset: 0x002104F4
	internal static 208 28(208 1, 208 2, 208 3)
	{
		return new 208(3.X * 1.X + (1f - 3.X) * 2.X, 3.Y * 1.Y + (1f - 3.Y) * 2.Y);
	}

	// Token: 0x0600551B RID: 21787 RVA: 0x00212348 File Offset: 0x00210548
	internal static double 29(double 1, int 2)
	{
		if (2 == 0)
		{
			return 0.0;
		}
		return 1 / (2.0 * Math.Sin(3.141592653589793 / (double)2));
	}

	// Token: 0x0600551C RID: 21788 RVA: 0x00212374 File Offset: 0x00210574
	internal static double 30(double 1, int 2)
	{
		if (2 == 0)
		{
			return 0.0;
		}
		return 1 / (1.0 / (2.0 * Math.Sin(3.141592653589793 / (double)2)));
	}

	// Token: 0x0600551D RID: 21789 RVA: 0x002123AC File Offset: 0x002105AC
	internal static 208 31(double 1, int 2, 208 3, double 4, int 5)
	{
		return new 208((float)(1 * Math.Cos((double)(6.2831855f / (float)2 * (float)5) + 4)) + 3.X, (float)(1 * Math.Sin((double)(6.2831855f / (float)2 * (float)5) + 4)) + 3.Y);
	}

	// Token: 0x0600551E RID: 21790 RVA: 0x002123FC File Offset: 0x002105FC
	internal static 208 32(1051 1, 1051 2)
	{
		float num = 1.2.Y - 1.1.Y;
		float num2 = 1.1.X - 1.2.X;
		float num3 = num * 1.1.X + num2 * 1.1.Y;
		float num4 = 2.2.Y - 2.1.Y;
		float num5 = 2.1.X - 2.2.X;
		float num6 = num4 * 2.1.X + num5 * 2.1.Y;
		float num7 = num * num5 - num4 * num2;
		if (num7 == 0f)
		{
			throw new ArgumentException("Lines are parallel");
		}
		float num8 = (num5 * num3 - num2 * num6) / num7;
		float 3 = (num * num6 - num4 * num3) / num7;
		return new 208(num8, 3);
	}

	// Token: 0x04004333 RID: 17203
	private static readonly double[] 1 = new double[]
	{
		1.0,
		1.0,
		2.0,
		6.0,
		24.0,
		120.0,
		720.0,
		5040.0,
		40320.0,
		362880.0,
		3628800.0,
		39916800.0,
		479001600.0,
		6227020800.0,
		87178291200.0,
		1307674368000.0,
		20922789888000.0,
		355687428096000.0,
		6402373705728000.0,
		1.21645100408832E+17,
		2.43290200817664E+18,
		5.109094217170944E+19,
		1.1240007277776077E+21,
		2.585201673888498E+22,
		6.204484017332394E+23,
		1.5511210043330986E+25,
		4.0329146112660565E+26,
		1.0888869450418352E+28,
		3.0488834461171387E+29,
		8.841761993739702E+30,
		2.6525285981219107E+32,
		8.222838654177922E+33,
		2.631308369336935E+35
	};

	// Token: 0x02000C71 RID: 3185
	public sealed class 1053
	{
		// Token: 0x06005521 RID: 21793 RVA: 0x002124FC File Offset: 0x002106FC
		public 1053(List<208> 1)
		{
			this.2 = 1;
			this.1 = 1.Count;
			this.3 = new 208[this.1];
			this.4 = new 208[this.1 * 2 - 1];
		}

		// Token: 0x06005522 RID: 21794 RVA: 0x00212548 File Offset: 0x00210748
		private static bool 1(208[] 1)
		{
			for (int i = 1; i < 1.Length - 1; i++)
			{
				if ((1[i - 1] - 2f * 1[i] + 1[i + 1]).LengthSquared() > 0.25f)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06005523 RID: 21795 RVA: 0x002125A4 File Offset: 0x002107A4
		private void 2(208[] 1, 208[] 2, 208[] 3)
		{
			208[] array = this.3;
			for (int i = 0; i < this.1; i++)
			{
				array[i] = 1[i];
			}
			for (int j = 0; j < this.1; j++)
			{
				2[j] = array[0];
				3[this.1 - j - 1] = array[this.1 - j - 1];
				for (int k = 0; k < this.1 - j - 1; k++)
				{
					array[k] = (array[k] + array[k + 1]) / 2f;
				}
			}
		}

		// Token: 0x06005524 RID: 21796 RVA: 0x00212654 File Offset: 0x00210854
		private void 3(208[] 1, List<208> 2)
		{
			208[] array = this.4;
			208[] array2 = this.3;
			this.2(1, array, array2);
			for (int i = 0; i < this.1 - 1; i++)
			{
				array[this.1 + i] = array2[i + 1];
			}
			2.Add(1[0]);
			for (int j = 1; j < this.1 - 1; j++)
			{
				int num = 2 * j;
				208 item = 0.25f * (array[num - 1] + 2f * array[num] + array[num + 1]);
				2.Add(item);
			}
		}

		// Token: 0x06005525 RID: 21797 RVA: 0x0021270C File Offset: 0x0021090C
		public List<208> 4()
		{
			List<208> list = new List<208>();
			if (this.1 == 0)
			{
				return list;
			}
			Stack<208[]> stack = new Stack<208[]>();
			Stack<208[]> stack2 = new Stack<208[]>();
			stack.Push(this.2.ToArray());
			208[] array = this.4;
			while (stack.Count > 0)
			{
				208[] array2 = stack.Pop();
				if (1052.1053.1(array2))
				{
					this.3(array2, list);
					stack2.Push(array2);
				}
				else
				{
					208[] item = (stack2.Count > 0) ? stack2.Pop() : new 208[this.1];
					this.2(array2, array, item);
					for (int i = 0; i < this.1; i++)
					{
						array2[i] = array[i];
					}
					stack.Push(item);
					stack.Push(array2);
				}
			}
			list.Add(this.2[this.1 - 1]);
			return list;
		}

		// Token: 0x04004334 RID: 17204
		private int 1;

		// Token: 0x04004335 RID: 17205
		private List<208> 2;

		// Token: 0x04004336 RID: 17206
		private 208[] 3;

		// Token: 0x04004337 RID: 17207
		private 208[] 4;
	}
}
