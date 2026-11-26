using System;
using System.Collections.Generic;

// Token: 0x02000A6E RID: 2670
public static class 1567
{
	// Token: 0x06004A04 RID: 18948 RVA: 0x001D4E35 File Offset: 0x001D3035
	internal static bool 1()
	{
		return 1567.2 != null;
	}

	// Token: 0x06004A05 RID: 18949 RVA: 0x001D4E40 File Offset: 0x001D3040
	internal static bool 2()
	{
		if (!1304.135)
		{
			return false;
		}
		try
		{
			1567.2 = new 1110();
			1567.2.1();
		}
		catch
		{
			1763.5("Could not find Wiimote.  Please check connection then reenable in options.", 198.Red, 8000, null);
			1304.135.2(false);
			1567.Disconnect();
			return false;
		}
		1763.5("Found Wiimote!", 198.YellowGreen, 6000, null);
		1567.2.19(true, true, true, true);
		return true;
	}

	// Token: 0x06004A06 RID: 18950 RVA: 0x001D4ED4 File Offset: 0x001D30D4
	internal static void Disconnect()
	{
		if (1567.2 != null)
		{
			1567.2.19(false, false, false, false);
			1567.2.Disconnect();
			1567.2 = null;
		}
	}

	// Token: 0x06004A07 RID: 18951 RVA: 0x001D4EFC File Offset: 0x001D30FC
	internal static bool 3()
	{
		if (1567.2 == null)
		{
			return false;
		}
		1567.3 = 1567.2.29();
		if (1567.1 > 0 && 1567.1 <= 1662.33)
		{
			1567.1 = -1;
			1567.2.20(false);
		}
		return 1567.3 != null;
	}

	// Token: 0x06004A08 RID: 18952 RVA: 0x001D4F4E File Offset: 0x001D314E
	internal static void 4(int 1)
	{
		if (1567.1())
		{
			1567.2.20(true);
			1567.1 = 1662.33 + 1;
		}
	}

	// Token: 0x06004A09 RID: 18953 RVA: 0x001D4F70 File Offset: 0x001D3170
	internal static void 5(List<200> 1)
	{
		if (!1567.3())
		{
			return;
		}
		1567.7 = 1567.6;
		1567.6 = 1567.3.ButtonState;
		1567.5 = 1567.4;
		1567.4 = 1567.3.TaikoDrumState;
		if (1226.69)
		{
			1567.2.19((1226.67 & 3) == 0, 1226.67 % 4 == 1, 1226.67 % 4 == 2, 1226.67 % 4 == 3);
		}
		bool flag = (!1567.5.InnerLeft && 1567.4.InnerLeft) || (!1567.7.Down && 1567.6.Down);
		bool flag2 = (!1567.5.InnerRight && 1567.4.InnerRight) || (!1567.7.One && 1567.6.One);
		bool flag3 = (!1567.5.OuterLeft && 1567.4.OuterLeft) || (!1567.7.Up && 1567.6.Up);
		bool flag4 = (!1567.5.OuterRight && 1567.4.OuterRight) || (!1567.7.Two && 1567.6.Two);
		if (!1535.1())
		{
			1535.16 = (1535.16 || flag);
			1535.18 = (1535.18 || flag2);
			1535.45 = (1535.45 || flag3);
			1535.47 = (1535.47 || flag4);
			1535.15 |= (1567.4.InnerLeft || 1567.6.Down);
			1535.17 |= (1567.4.InnerRight || 1567.6.One);
			1535.44 |= (1567.4.OuterLeft || 1567.6.Up);
			1535.46 |= (1567.4.OuterRight || 1567.6.Two);
		}
		1677 2 = 1662.78;
		if (2 != 1677.Menu)
		{
			if (2 != 1677.Play)
			{
				if (2 == 1677.SelectPlay)
				{
					if (1567.4.InnerLeft || 1567.4.InnerRight || 1567.6.Two)
					{
						1.Add(200.Enter);
					}
					else if (1567.5.OuterLeft || 1567.6.Up || 1567.6.Right)
					{
						1.Add(200.Up);
					}
					else if (1567.5.OuterRight || 1567.6.Down || 1567.6.Left)
					{
						1.Add(200.Down);
					}
					if (1567.6.B || 1567.6.One)
					{
						1.Add(200.Escape);
					}
				}
			}
			else
			{
				if (1567.3.BalanceBoardState.CenterOfGravity.X < 0f || 1567.6.Left)
				{
					1.Add(1548.8(1532.FruitsLeft));
				}
				if (1567.3.BalanceBoardState.CenterOfGravity.X > 0f || 1567.6.Right)
				{
					1.Add(1548.8(1532.FruitsRight));
				}
				if (1567.6.A || 1567.6.B)
				{
					1.Add(1548.8(1532.FruitsDash));
				}
			}
		}
		else
		{
			if ((flag || flag2) && 1662.76 == (932)2)
			{
				2486.15(2147.Taiko);
				1662.SetMode(1677.SelectPlay, false);
				1226.28("menuhit", 1f, (1416)3);
			}
			if (1567.6.A && 1662.76 == (932)2)
			{
				2486.15(2147.Taiko);
				1662.SetMode(1677.SelectPlay, false);
				1226.28("menuhit", 1f, (1416)3);
			}
			if (1567.6.B)
			{
				1.Add(200.Escape);
			}
		}
		if (1567.6.Plus || (2486.13 && 1567.6.Up) || 1567.6.Right)
		{
			1.Add(200.Up);
		}
		if (1567.6.Minus || (2486.13 && 1567.6.Down) || 1567.6.Left)
		{
			1.Add(200.Down);
		}
		if (1567.6.Home)
		{
			1.Add(200.Escape);
		}
		if (1567.6.A)
		{
			if (2486.4 && !2486.13)
			{
				1.Add(200.Escape);
				return;
			}
			if (1662.78 == 1677.Play && !2486.13)
			{
				1.Add(1548.8(1532.Skip));
				return;
			}
			1.Add(200.Enter);
		}
	}

	// Token: 0x0400371A RID: 14106
	private static int 1;

	// Token: 0x0400371B RID: 14107
	internal static 1110 2;

	// Token: 0x0400371C RID: 14108
	private static 967 3;

	// Token: 0x0400371D RID: 14109
	private static 966 4;

	// Token: 0x0400371E RID: 14110
	private static 966 5;

	// Token: 0x0400371F RID: 14111
	private static 946 6;

	// Token: 0x04003720 RID: 14112
	private static 946 7;
}
