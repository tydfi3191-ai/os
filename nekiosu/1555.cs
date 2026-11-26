using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

// Token: 0x02000A61 RID: 2657
public static class 1555
{
	// Token: 0x06004976 RID: 18806 RVA: 0x001D2E35 File Offset: 0x001D1035
	internal static bool 1()
	{
		return 1662.74.Contains(1555.17());
	}

	// Token: 0x06004977 RID: 18807 RVA: 0x001D2E46 File Offset: 0x001D1046
	internal static 199 2()
	{
		return 1555.23;
	}

	// Token: 0x06004978 RID: 18808 RVA: 0x001D2E4D File Offset: 0x001D104D
	internal static void 3(199 1)
	{
		if (1 == 199.Pressed)
		{
			1555.23 = 1;
		}
		1555.7 = 1;
	}

	// Token: 0x06004979 RID: 18809 RVA: 0x001D2E5F File Offset: 0x001D105F
	internal static 199 4()
	{
		return 1555.24;
	}

	// Token: 0x0600497A RID: 18810 RVA: 0x001D2E66 File Offset: 0x001D1066
	internal static void 5(199 1)
	{
		if (1 == 199.Pressed)
		{
			1555.24 = 1;
		}
		1555.9 = 1;
	}

	// Token: 0x0600497B RID: 18811 RVA: 0x001D2E78 File Offset: 0x001D1078
	internal static 199 6()
	{
		return 1555.25;
	}

	// Token: 0x0600497C RID: 18812 RVA: 0x001D2E7F File Offset: 0x001D107F
	internal static void 7(199 1)
	{
		if (1 == 199.Pressed)
		{
			1555.25 = 1;
		}
		1555.8 = 1;
	}

	// Token: 0x0600497D RID: 18813 RVA: 0x001D2E91 File Offset: 0x001D1091
	internal static 199 8()
	{
		return 1555.26;
	}

	// Token: 0x0600497E RID: 18814 RVA: 0x001D2E98 File Offset: 0x001D1098
	internal static void 9(199 1)
	{
		if (1 == 199.Pressed)
		{
			1555.26 = 1;
		}
		1555.5 = 1;
	}

	// Token: 0x0600497F RID: 18815 RVA: 0x001D2EAA File Offset: 0x001D10AA
	internal static 199 10()
	{
		return 1555.27;
	}

	// Token: 0x06004980 RID: 18816 RVA: 0x001D2EB1 File Offset: 0x001D10B1
	internal static void 11(199 1)
	{
		if (1 == 199.Pressed)
		{
			1555.27 = 1;
		}
		1555.6 = 1;
	}

	// Token: 0x06004981 RID: 18817 RVA: 0x001D2EC4 File Offset: 0x001D10C4
	internal static void 12()
	{
		Form form = 1662.13();
		EventHandler value;
		if ((value = 1555.<>O.<0>__OnWindowDeactivated) == null)
		{
			value = (1555.<>O.<0>__OnWindowDeactivated = new EventHandler(1555.42));
		}
		form.Deactivate += value;
		Control control = 1662.13();
		MouseEventHandler value2;
		if ((value2 = 1555.<>O.<1>__OnMouseWheel) == null)
		{
			value2 = (1555.<>O.<1>__OnMouseWheel = new MouseEventHandler(1555.43));
		}
		control.MouseWheel += value2;
		Control control2 = 1662.13();
		MouseEventHandler value3;
		if ((value3 = 1555.<>O.<2>__OnMouseDown) == null)
		{
			value3 = (1555.<>O.<2>__OnMouseDown = new MouseEventHandler(1555.45));
		}
		control2.MouseDown += value3;
		Control control3 = 1662.13();
		MouseEventHandler value4;
		if ((value4 = 1555.<>O.<3>__OnMouseUp) == null)
		{
			value4 = (1555.<>O.<3>__OnMouseUp = new MouseEventHandler(1555.44));
		}
		control3.MouseUp += value4;
		Control control4 = 1662.13();
		MouseEventHandler value5;
		if ((value5 = 1555.<>O.<1>__OnMouseWheel) == null)
		{
			value5 = (1555.<>O.<1>__OnMouseWheel = new MouseEventHandler(1555.43));
		}
		control4.MouseWheel += value5;
	}

	// Token: 0x06004982 RID: 18818 RVA: 0x001D2F8C File Offset: 0x001D118C
	internal static void 13(1079 1)
	{
		1555.14(1.GetPosition());
		if (1.GetLeftButton() != null)
		{
			1555.3(1.GetLeftButton().Value);
		}
		if (1.GetRightButton() != null)
		{
			1555.5(1.GetRightButton().Value);
		}
		if (1.GetMiddleButton() != null)
		{
			1555.7(1.GetMiddleButton().Value);
		}
		if (1.GetBackButton() != null)
		{
			1555.9(1.GetBackButton().Value);
		}
		if (1.GetForwardButton() != null)
		{
			1555.11(1.GetForwardButton().Value);
		}
	}

	// Token: 0x06004983 RID: 18819 RVA: 0x001D3053 File Offset: 0x001D1253
	internal static void 14(208 1)
	{
		1555.22(1);
		1535.36(1);
	}

	// Token: 0x06004984 RID: 18820 RVA: 0x001D3064 File Offset: 0x001D1264
	internal static void 15(206 1, bool 2)
	{
		if (2 || 1662.11.2())
		{
			206 3 = 1662.48();
			Cursor.Position = 1662.13().PointToScreen(new Point(1.X + 3.X, 1.Y + 3.Y));
		}
	}

	// Token: 0x06004985 RID: 18821 RVA: 0x001D30B4 File Offset: 0x001D12B4
	internal static 206 16()
	{
		Point point = 1662.13().PointToClient(Cursor.Position);
		206 <<EMPTY_NAME>> = 1662.48();
		return new 206(point.X - <<EMPTY_NAME>>.X, point.Y - <<EMPTY_NAME>>.Y);
	}

	// Token: 0x06004986 RID: 18822 RVA: 0x001D30F8 File Offset: 0x001D12F8
	internal static 206 17()
	{
		return 1555.28;
	}

	// Token: 0x06004987 RID: 18823 RVA: 0x001D30FF File Offset: 0x001D12FF
	private static void 18(206 1)
	{
		1555.28 = 1;
	}

	// Token: 0x06004988 RID: 18824 RVA: 0x001D3107 File Offset: 0x001D1307
	internal static 208 19()
	{
		return 1555.29;
	}

	// Token: 0x06004989 RID: 18825 RVA: 0x001D310E File Offset: 0x001D130E
	private static void 20(208 1)
	{
		1555.29 = 1;
	}

	// Token: 0x0600498A RID: 18826 RVA: 0x001D3116 File Offset: 0x001D1316
	internal static 208 21()
	{
		return 1555.30;
	}

	// Token: 0x0600498B RID: 18827 RVA: 0x001D3120 File Offset: 0x001D1320
	private static void 22(208 1)
	{
		1555.30 = 1;
		1555.20((1555.30 + new 208(0f, (float)1662.31())) / 1662.70.3());
		1555.18(new 206((int)Math.Round((double)1.X), (int)Math.Round((double)1.Y)));
	}

	// Token: 0x0600498C RID: 18828 RVA: 0x001D3185 File Offset: 0x001D1385
	internal static void 23()
	{
		1555.14(1535.6);
	}

	// Token: 0x0600498D RID: 18829 RVA: 0x001D3191 File Offset: 0x001D1391
	internal static bool 24(208 1, int 2)
	{
		return 1555.25(new 206((int)Math.Round((double)1.X), (int)Math.Round((double)1.Y)), 2);
	}

	// Token: 0x0600498E RID: 18830 RVA: 0x001D31B8 File Offset: 0x001D13B8
	internal static bool 25(206 1, int 2)
	{
		return 1.X >= 2 && 1.X < 1662.70.1 - 2 && (1.Y >= 2 & 1.Y < 1662.70.2 - 2);
	}

	// Token: 0x0600498F RID: 18831 RVA: 0x001D3205 File Offset: 0x001D1405
	internal static void 26()
	{
		1555.27(Cursors.Arrow);
	}

	// Token: 0x06004990 RID: 18832 RVA: 0x001D3211 File Offset: 0x001D1411
	internal static void 27(Cursor 1)
	{
		if (1662.13().Cursor != 1)
		{
			1662.13().Cursor = 1;
		}
	}

	// Token: 0x06004991 RID: 18833 RVA: 0x001D3230 File Offset: 0x001D1430
	internal static void 28()
	{
		if (1662.47)
		{
			1555.34 = (1662.78 == 1677.Play && 1535.1());
			1555.33 = true;
			1555.32 = true;
		}
		else
		{
			1555.34 = (1535.32 && 1662.78 != 1677.Edit);
			bool flag = 1555.34;
			bool flag2;
			if (1662.78 == 1677.Play)
			{
				2486 <<EMPTY_NAME>> = 2486.7;
				flag2 = (<<EMPTY_NAME>> != null && !<<EMPTY_NAME>>.CanHideGameplayCursor());
			}
			else
			{
				flag2 = true;
			}
			1555.34 = (flag && flag2);
			bool flag3 = 1555.34;
			1662 2 = 1662.11;
			1555.34 = (flag3 & (2 == null || !2.2() || 1662.78 != 1677.Menu || 1662.87() < 5000));
			1555.34 &= (1662.78 != 1677.Exit);
			1555.33 = (1662.78 == 1677.Edit || (1662.78 == 1677.Play && 1535.1() && 1535.31) || 1662.77 == 1677.Exit || 1662.81());
			1555.32 = (1555.33 || (!1555.1() && !1555.25(1555.16(), 0)));
		}
		bool flag4 = 1304.216.1() && !1662.47 && 1555.33 && 1662.118 && 1662.78 == 1677.Play && 1535.1() && !1662.81() && 1662.11.2() && 1555.1();
		1555.29(flag4);
		bool flag5 = 1555.32 && (!flag4 || 1555.35 == null);
		if (flag5 != 1662.65)
		{
			1662.65 = flag5;
			if (flag5)
			{
				Cursor.Show();
			}
			else
			{
				Cursor.Hide();
			}
		}
		1433 3 = 1535.51;
		if (3 != null && (!1555.34 || 3.16 != 1f) && (1555.34 || 3.16 != 0f))
		{
			List<1445> list = 3.3;
			if (((list != null) ? list.Find(new Predicate<1445>(1555.1556.Instance.1)) : null) == null)
			{
				if (1555.34)
				{
					3.FadeIn(100, (1046)0, 0);
					return;
				}
				3.16(300, (1046)0, 0);
			}
		}
	}

	// Token: 0x06004992 RID: 18834 RVA: 0x001D344C File Offset: 0x001D164C
	private static void 29(bool 1)
	{
		if (1 && 1555.35 == null && 1662.26 != null)
		{
			1381 2 = 1555.30();
			if (2 != null)
			{
				1555.35 = new 1433(2, (1376)16, 1065.TopLeft, (1044)0, 208.Zero, 1f, true, 198.White, null)
				{
					16 = 0f
				};
				1662.26.12(1555.35);
			}
		}
		if (1555.35 != null)
		{
			1555.35.16 = (1 ? 1f : 0f);
			1555.35.17 = 1555.21();
		}
	}

	// Token: 0x06004993 RID: 18835 RVA: 0x001D34DC File Offset: 0x001D16DC
	private static 1381 30()
	{
		1381 result;
		try
		{
			int num = Math.Max(32, SystemInformation.CursorSize.Width);
			float num2 = (float)num / 32f;
			PointF[] array = new PointF[]
			{
				new PointF(0.5f, 0.5f),
				new PointF(0.5f, 17.5f),
				new PointF(4.5f, 13.5f),
				new PointF(7.5f, 20.5f),
				new PointF(10f, 19.5f),
				new PointF(7f, 12.5f),
				new PointF(12.5f, 12.5f)
			};
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = new PointF(array[i].X * num2, array[i].Y * num2);
			}
			using (Bitmap bitmap = new Bitmap(num, num, PixelFormat.Format32bppArgb))
			{
				using (Graphics graphics = Graphics.FromImage(bitmap))
				{
					using (Pen pen = new Pen(Color.Black, num2)
					{
						LineJoin = LineJoin.Miter
					})
					{
						graphics.SmoothingMode = SmoothingMode.AntiAlias;
						graphics.Clear(Color.Transparent);
						graphics.FillPolygon(Brushes.White, array);
						graphics.DrawPolygon(pen, array);
					}
				}
				result = 1381.15(bitmap, null);
			}
		}
		catch (Exception)
		{
			result = null;
		}
		return result;
	}

	// Token: 0x06004994 RID: 18836 RVA: 0x001D36D8 File Offset: 0x001D18D8
	internal static 1079 31(List<1083> 1)
	{
		1079 2 = null;
		foreach (1083 3 in 1)
		{
			if (2 == null && 3.IsActive() && 3 is 1079)
			{
				2 = (1079)3;
			}
			if (3 is 1561)
			{
				1079 4 = (1079)3;
			}
			if (3 is 1558)
			{
				1079 5 = (1079)3;
			}
			3.Update(2 == 3);
		}
		if (2 != null)
		{
			1555.13(2);
		}
		return 2;
	}

	// Token: 0x06004995 RID: 18837 RVA: 0x001D3770 File Offset: 0x001D1970
	internal static void 32()
	{
		if (2486.14 && 1304.104)
		{
			1555.48();
			return;
		}
		if (1662.11.2() && 1662.78 != 1677.Edit && 1662.78 != 1677.Menu)
		{
			if (1555.8() == 199.Pressed && 1555.19 != 1555.8())
			{
				1549.7(200.Escape);
			}
			1555.19 = 1555.8();
			if (1555.10() == 199.Pressed && 1555.18 != 1555.10())
			{
				1549.7(1548.8(1532.Skip));
			}
			1555.18 = 1555.10();
		}
	}

	// Token: 0x06004996 RID: 18838 RVA: 0x001D3802 File Offset: 0x001D1A02
	internal static void 33()
	{
		1535.68 = 1662.33;
		1535.39((1082)1);
	}

	// Token: 0x06004997 RID: 18839 RVA: 0x001D3814 File Offset: 0x001D1A14
	internal static void 34()
	{
		1535.68 = 1662.33;
		1535.39((1082)0);
	}

	// Token: 0x06004998 RID: 18840 RVA: 0x001D3828 File Offset: 0x001D1A28
	internal static void 35()
	{
		if (1304.86)
		{
			if (1662.78 == 1677.Play)
			{
				2023 <<EMPTY_NAME>> = 2023.Cinema;
				2023 2 = 2019.1;
				2023 3 = <<EMPTY_NAME>>;
				if ((2 & 3) > 2023.None)
				{
					goto IL_D0;
				}
			}
			if (2486.7 == null || !2486.7.CanHideGameplayCursor())
			{
				1381 4 = 1455.2("cursor-ripple", (1416)7, null);
				if (4 == null)
				{
					4 = 1455.2("menu-osu-shockwave", (1416)1, null);
				}
				1433 5 = new 1433(4, (1376)5, 1065.Centre, (1044)0, 1535.6, 0.2f, false, 198.White, null);
				5.28 = true;
				5.16 = 0.2f;
				5.16(700, (1046)0, 0);
				5.3.Add(new 1445(1456.Scale, 0.05f, 0.5f, 1662.33, 1662.33 + 700, (1046)1));
				1662.28.12(5);
			}
		}
		IL_D0:
		1535.39((1082)7);
	}

	// Token: 0x06004999 RID: 18841 RVA: 0x001D390B File Offset: 0x001D1B0B
	internal static void 36()
	{
		if (1555.31)
		{
			1436.1 = null;
		}
		1436.43(false);
		1535.39((1082)8);
	}

	// Token: 0x0600499A RID: 18842 RVA: 0x001D3926 File Offset: 0x001D1B26
	internal static void 37()
	{
		1436.43(true);
	}

	// Token: 0x0600499B RID: 18843 RVA: 0x001D392E File Offset: 0x001D1B2E
	internal static void 38()
	{
		1535.39((1082)6);
		1436.42();
	}

	// Token: 0x0600499C RID: 18844 RVA: 0x001D393B File Offset: 0x001D1B3B
	internal static void 39()
	{
		1535.39((1082)5);
		1535.7 = 0;
	}

	// Token: 0x0600499D RID: 18845 RVA: 0x001D3949 File Offset: 0x001D1B49
	internal static void 40()
	{
		1535.39((1082)2);
		1535.10 = false;
	}

	// Token: 0x0600499E RID: 18846 RVA: 0x001D3958 File Offset: 0x001D1B58
	public static 1572 41(bool 1, bool 2, bool 3, bool 4, bool 5)
	{
		1572 6 = 1572.None;
		if (1)
		{
			6 |= 1572.Left1;
		}
		if (2)
		{
			6 |= 1572.Left2;
		}
		if (3)
		{
			6 |= 1572.Right1;
		}
		if (4)
		{
			6 |= 1572.Right2;
		}
		if (5)
		{
			6 |= 1572.Smoke;
		}
		return 6;
	}

	// Token: 0x0600499F RID: 18847 RVA: 0x001D398D File Offset: 0x001D1B8D
	private static void 42(object 1, EventArgs 2)
	{
		1555.3(199.Released);
		1555.5(199.Released);
		1555.7(199.Released);
		1555.9(199.Released);
		1555.11(199.Released);
	}

	// Token: 0x060049A0 RID: 18848 RVA: 0x001D39AD File Offset: 0x001D1BAD
	private static void 43(object 1, MouseEventArgs 2)
	{
		1555.10 += 2.Delta;
	}

	// Token: 0x060049A1 RID: 18849 RVA: 0x001D39C0 File Offset: 0x001D1BC0
	private static void 44(object 1, MouseEventArgs 2)
	{
		MouseButtons button = 2.Button;
		if (button <= MouseButtons.Right)
		{
			if (button == MouseButtons.Left)
			{
				1555.3(199.Released);
				return;
			}
			if (button != MouseButtons.Right)
			{
				return;
			}
			1555.5(199.Released);
			return;
		}
		else
		{
			if (button == MouseButtons.Middle)
			{
				1555.7(199.Released);
				return;
			}
			if (button == MouseButtons.XButton1)
			{
				1555.9(199.Released);
				return;
			}
			if (button != MouseButtons.XButton2)
			{
				return;
			}
			1555.11(199.Released);
			return;
		}
	}

	// Token: 0x060049A2 RID: 18850 RVA: 0x001D3A28 File Offset: 0x001D1C28
	private static void 45(object 1, MouseEventArgs 2)
	{
		MouseButtons button = 2.Button;
		if (button <= MouseButtons.Right)
		{
			if (button == MouseButtons.Left)
			{
				1555.3(199.Pressed);
				return;
			}
			if (button != MouseButtons.Right)
			{
				return;
			}
			1555.5(199.Pressed);
			return;
		}
		else
		{
			if (button == MouseButtons.Middle)
			{
				1555.7(199.Pressed);
				return;
			}
			if (button == MouseButtons.XButton1)
			{
				1555.9(199.Pressed);
				return;
			}
			if (button != MouseButtons.XButton2)
			{
				return;
			}
			1555.11(199.Pressed);
			return;
		}
	}

	// Token: 0x060049A3 RID: 18851 RVA: 0x001D3A90 File Offset: 0x001D1C90
	internal static bool 46()
	{
		if (1555.23 != 1555.7 || 1555.24 != 1555.9 || 1555.25 != 1555.8 || 1555.26 != 1555.5 || 1555.27 != 1555.6)
		{
			1555.23 = 1555.7;
			1555.24 = 1555.9;
			1555.25 = 1555.8;
			1555.26 = 1555.5;
			1555.27 = 1555.6;
			return true;
		}
		return false;
	}

	// Token: 0x060049A4 RID: 18852 RVA: 0x001D3B0E File Offset: 0x001D1D0E
	internal static void 47()
	{
		if (1555.10 != 0)
		{
			if (1555.10 > 0)
			{
				1555.33();
			}
			else
			{
				1555.34();
			}
			1555.10 = 0;
		}
	}

	// Token: 0x060049A5 RID: 18853 RVA: 0x001D3B31 File Offset: 0x001D1D31
	internal static void 48()
	{
		1555.23 = 199.Released;
		1555.7 = 199.Released;
		1555.24 = 199.Released;
		1555.9 = 199.Released;
		1555.25 = 199.Released;
		1555.8 = 199.Released;
	}

	// Token: 0x040036C9 RID: 14025
	internal static long 1;

	// Token: 0x040036CA RID: 14026
	internal static int 2;

	// Token: 0x040036CB RID: 14027
	internal static int 3;

	// Token: 0x040036CC RID: 14028
	internal static float 4;

	// Token: 0x040036CD RID: 14029
	private static 199 5;

	// Token: 0x040036CE RID: 14030
	private static 199 6;

	// Token: 0x040036CF RID: 14031
	private static 199 7;

	// Token: 0x040036D0 RID: 14032
	private static 199 8;

	// Token: 0x040036D1 RID: 14033
	private static 199 9;

	// Token: 0x040036D2 RID: 14034
	private static int 10;

	// Token: 0x040036D3 RID: 14035
	internal static 208 11;

	// Token: 0x040036D4 RID: 14036
	internal static int 12;

	// Token: 0x040036D5 RID: 14037
	public static bool 13;

	// Token: 0x040036D6 RID: 14038
	public static bool 14;

	// Token: 0x040036D7 RID: 14039
	internal static bool 15;

	// Token: 0x040036D8 RID: 14040
	public static MouseButtons 16;

	// Token: 0x040036D9 RID: 14041
	public static MouseButtons 17;

	// Token: 0x040036DA RID: 14042
	internal static 199 18;

	// Token: 0x040036DB RID: 14043
	internal static 199 19;

	// Token: 0x040036DC RID: 14044
	internal static bool 20;

	// Token: 0x040036DD RID: 14045
	internal static MouseButtons 21;

	// Token: 0x040036DE RID: 14046
	internal static MouseButtons 22;

	// Token: 0x040036DF RID: 14047
	private static 199 23;

	// Token: 0x040036E0 RID: 14048
	private static 199 24;

	// Token: 0x040036E1 RID: 14049
	private static 199 25;

	// Token: 0x040036E2 RID: 14050
	private static 199 26;

	// Token: 0x040036E3 RID: 14051
	private static 199 27;

	// Token: 0x040036E4 RID: 14052
	private static 206 28;

	// Token: 0x040036E5 RID: 14053
	private static 208 29;

	// Token: 0x040036E6 RID: 14054
	private static 208 30;

	// Token: 0x040036E7 RID: 14055
	internal static bool 31;

	// Token: 0x040036E8 RID: 14056
	internal static bool 32;

	// Token: 0x040036E9 RID: 14057
	internal static bool 33;

	// Token: 0x040036EA RID: 14058
	internal static bool 34;

	// Token: 0x040036EB RID: 14059
	private static 1433 35;

	// Token: 0x02000A62 RID: 2658
	[Serializable]
	public sealed class 1556
	{
		// Token: 0x060049A6 RID: 18854 RVA: 0x000CAAF9 File Offset: 0x000C8CF9
		internal bool 1(1445 1)
		{
			return 1.14 == 1456.Fade;
		}

		// Token: 0x040036EC RID: 14060
		public static readonly 1555.1556 Instance = new 1555.1556();

		// Token: 0x040036ED RID: 14061
		public static Predicate<1445> predicate;
	}

	// Token: 0x02000A63 RID: 2659
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x040036EE RID: 14062
		public static EventHandler <0>__OnWindowDeactivated;

		// Token: 0x040036EF RID: 14063
		public static MouseEventHandler <1>__OnMouseWheel;

		// Token: 0x040036F0 RID: 14064
		public static MouseEventHandler <2>__OnMouseDown;

		// Token: 0x040036F1 RID: 14065
		public static MouseEventHandler <3>__OnMouseUp;
	}
}
