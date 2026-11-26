using System;
using System.Collections.Generic;
using OpenTK.Graphics;

// Token: 0x020002CE RID: 718
public sealed class 789
{
	// Token: 0x06001564 RID: 5476 RVA: 0x00049878 File Offset: 0x00047A78
	public GraphicsMode Method12900(ColorFormat 1, int 2, int 3, int 4, ColorFormat 5, int 6, bool 7, out IntPtr 8)
	{
		for (;;)
		{
			8 = this.Method12903(1, 2, 3, 4, 5, 6, 7);
			if (8 == IntPtr.Zero && !789.Method12901(ref 1, ref 2, ref 3, ref 4, ref 5, ref 6, ref 7))
			{
				break;
			}
			if (!(8 == IntPtr.Zero))
			{
				goto Block_2;
			}
		}
		throw new GraphicsModeException("Requested GraphicsMode not available, error: " + 614.aglGetError().ToString());
		Block_2:
		return this.Method12902(8);
	}

	// Token: 0x06001565 RID: 5477 RVA: 0x000498F8 File Offset: 0x00047AF8
	private static bool Method12901(ref ColorFormat 1, ref int 2, ref int 3, ref int 4, ref ColorFormat 5, ref int 6, ref bool 7)
	{
		if (5 != 0)
		{
			5 = 0;
			return true;
		}
		if (6 > 2)
		{
			6 = 2;
			return true;
		}
		if (4 > 0)
		{
			4 = Math.Max(4 - 1, 0);
			return true;
		}
		if (7)
		{
			7 = false;
			return true;
		}
		if (3 != 0)
		{
			3 = 0;
			return true;
		}
		if (2 != 0)
		{
			2 = 0;
			return true;
		}
		if (1 != 24)
		{
			1 = 24;
			return true;
		}
		if (6 != 0)
		{
			6 = 0;
			return true;
		}
		return false;
	}

	// Token: 0x06001566 RID: 5478 RVA: 0x00049994 File Offset: 0x00047B94
	private GraphicsMode Method12902(IntPtr 1)
	{
		int num;
		614.aglDescribePixelFormat(1, (614.619)8, out num);
		int num2;
		614.aglDescribePixelFormat(1, (614.619)9, out num2);
		int num3;
		614.aglDescribePixelFormat(1, (614.619)10, out num3);
		int num4;
		614.aglDescribePixelFormat(1, (614.619)11, out num4);
		int num5;
		614.aglDescribePixelFormat(1, (614.619)17, out num5);
		int num6;
		614.aglDescribePixelFormat(1, (614.619)14, out num6);
		int num7;
		614.aglDescribePixelFormat(1, (614.619)15, out num7);
		int num8;
		614.aglDescribePixelFormat(1, (614.619)16, out num8);
		int num9;
		614.aglDescribePixelFormat(1, (614.619)12, out num9);
		int num10;
		614.aglDescribePixelFormat(1, (614.619)13, out num10);
		int num11;
		614.aglDescribePixelFormat(1, (614.619)56, out num11);
		int num12;
		614.aglDescribePixelFormat(1, (614.619)5, out num12);
		int num13;
		614.aglDescribePixelFormat(1, (614.619)6, out num13);
		return new GraphicsMode(new ColorFormat(num, num2, num3, num4), num9, num10, num11, new ColorFormat(num6, num7, num8, num5), num12 + 1, num13 != 0);
	}

	// Token: 0x06001567 RID: 5479 RVA: 0x00049A58 File Offset: 0x00047C58
	private IntPtr Method12903(ColorFormat 1, int 2, int 3, int 4, ColorFormat 5, int 6, bool 7)
	{
		List<int> list = new List<int>();
		if (1.BitsPerPixel > 0)
		{
			if (!1.IsIndexed)
			{
				list.Add(4);
			}
			list.Add(8);
			list.Add(1.Red);
			list.Add(9);
			list.Add(1.Green);
			list.Add(10);
			list.Add(1.Blue);
			list.Add(11);
			list.Add(1.Alpha);
		}
		if (2 > 0)
		{
			list.Add(12);
			list.Add(2);
		}
		if (6 > 1)
		{
			list.Add(5);
		}
		if (3 > 0)
		{
			list.Add(13);
			list.Add(3);
		}
		if (5.BitsPerPixel > 0)
		{
			list.Add(17);
			list.Add(5.Alpha);
			list.Add(16);
			list.Add(5.Blue);
			list.Add(15);
			list.Add(5.Green);
			list.Add(14);
			list.Add(5.Red);
		}
		if (4 > 0)
		{
			list.Add(55);
			list.Add(1);
			list.Add(56);
			list.Add(4);
		}
		if (7)
		{
			list.Add(6);
		}
		list.Add(0);
		list.Add(0);
		return 614.aglChoosePixelFormat(IntPtr.Zero, 0, list.ToArray());
	}
}
