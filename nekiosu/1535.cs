using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

// Token: 0x02000A4A RID: 2634
public static class 1535
{
	// Token: 0x060048D5 RID: 18645 RVA: 0x001CDFA3 File Offset: 0x001CC1A3
	internal static bool 1()
	{
		return 1535.35;
	}

	// Token: 0x060048D6 RID: 18646 RVA: 0x001CDFAA File Offset: 0x001CC1AA
	internal static void 2(bool 1)
	{
		1535.35 = 1;
		if (!1535.35)
		{
			1535.39 = null;
			1535.71 = null;
		}
	}

	// Token: 0x060048D7 RID: 18647 RVA: 0x001CDFC8 File Offset: 0x001CC1C8
	public static bool 3()
	{
		1302 value = 1304.192.GetValue();
		bool result;
		if (value != 1302.Fullscreen)
		{
			result = (value == 1302.Always);
		}
		else
		{
			result = 1304.167.1();
		}
		return result;
	}

	// Token: 0x060048D8 RID: 18648 RVA: 0x001CDFFE File Offset: 0x001CC1FE
	public static bool 4()
	{
		return 1535.9;
	}

	// Token: 0x060048D9 RID: 18649 RVA: 0x001CE005 File Offset: 0x001CC205
	public static void 5(bool 1)
	{
		if (1535.9 != 1)
		{
			1535.9 = 1;
			1535.53.24(1);
		}
	}

	// Token: 0x060048DA RID: 18650 RVA: 0x001CE020 File Offset: 0x001CC220
	public static bool 6()
	{
		return 1535.59 is 1554 || 1535.59 is 1563;
	}

	// Token: 0x060048DB RID: 18651 RVA: 0x001CE040 File Offset: 0x001CC240
	public static List<208> 7()
	{
		if (1535.59 is 1554)
		{
			return new List<208>(((1554)1535.59).10.Values);
		}
		if (1555.20)
		{
			return new List<208>(new 208[]
			{
				1555.11 / 1662.70.3()
			});
		}
		return new List<208>();
	}

	// Token: 0x060048DC RID: 18652 RVA: 0x001CE0A6 File Offset: 0x001CC2A6
	private static 2011 8()
	{
		if (1662.78 != 1677.Play)
		{
			return 2263.4.7.41;
		}
		return 2486.7.39.41;
	}

	// Token: 0x060048DD RID: 18653 RVA: 0x001CE0D0 File Offset: 0x001CC2D0
	public static void 9(string 1, bool 2)
	{
		1535.1540 3 = new 1535.1540();
		3.1 = 2;
		3.2 = 1;
		if (3.2 == null)
		{
			3.2 = string.Empty;
		}
		1662.89.Schedule(new 1189(3.Apply), false);
	}

	// Token: 0x060048DE RID: 18654 RVA: 0x001CE11C File Offset: 0x001CC31C
	internal static void 10()
	{
		1189 <<EMPTY_NAME>>;
		if ((<<EMPTY_NAME>> = 1535.<>O.<0>__OnWindowSizeChanged) == null)
		{
			<<EMPTY_NAME>> = (1535.<>O.<0>__OnWindowSizeChanged = new 1189(1535.12));
		}
		1662.76(<<EMPTY_NAME>>);
		1535.37();
		1555.12();
		1535.15();
		1567.2();
		1535.28(new 1554());
		if (1304.87)
		{
			1535.28(new 1563());
		}
		1535.28(new 1546());
		1535.28(new 1558());
		1535.28(new 1561());
		1535.28(new 1557());
		1803 2 = 1662.11;
		EventHandler eventHandler;
		if ((eventHandler = 1535.<>O.<1>__OnWindowFocusChanged) == null)
		{
			eventHandler = (1535.<>O.<1>__OnWindowFocusChanged = new EventHandler(1535.13));
		}
		2.5(eventHandler);
		1803 3 = 1662.11;
		EventHandler eventHandler2;
		if ((eventHandler2 = 1535.<>O.<1>__OnWindowFocusChanged) == null)
		{
			eventHandler2 = (1535.<>O.<1>__OnWindowFocusChanged = new EventHandler(1535.13));
		}
		3.7(eventHandler2);
	}

	// Token: 0x060048DF RID: 18655 RVA: 0x001CE1F8 File Offset: 0x001CC3F8
	internal static void 11()
	{
		foreach (1083 <<EMPTY_NAME>> in 1535.2)
		{
			<<EMPTY_NAME>>.Dispose();
		}
		1189 2;
		if ((2 = 1535.<>O.<0>__OnWindowSizeChanged) == null)
		{
			2 = (1535.<>O.<0>__OnWindowSizeChanged = new 1189(1535.12));
		}
		1662.77(2);
	}

	// Token: 0x060048E0 RID: 18656 RVA: 0x001CE268 File Offset: 0x001CC468
	internal static void 12()
	{
		foreach (1083 <<EMPTY_NAME>> in 1535.2)
		{
			<<EMPTY_NAME>>.OnWindowSizeChanged();
		}
	}

	// Token: 0x060048E1 RID: 18657 RVA: 0x001CE2B8 File Offset: 0x001CC4B8
	private static void 13(object 1, EventArgs 2)
	{
		1535.14();
		if (1662.11.2())
		{
			1555.11 = 1535.6;
		}
	}

	// Token: 0x060048E2 RID: 18658 RVA: 0x001CE2D8 File Offset: 0x001CC4D8
	internal static void 14()
	{
		if (1662.47)
		{
			return;
		}
		bool flag = false;
		2486 <<EMPTY_NAME>> = 2486.7;
		if (<<EMPTY_NAME>> != null && <<EMPTY_NAME>>.58 != null)
		{
			flag = <<EMPTY_NAME>>.58.CapturesCursor();
		}
		bool flag2 = 2486.14 && flag && !1535.1();
		1558 2 = 1535.59 as 1558;
		bool flag3 = 2 != null && !2.6() && 1555.25(1555.17(), 1);
		if (1535.22 && 1662.11.2() && (flag2 || flag3 || (1535.3() && 1662.78 != 1677.Edit)))
		{
			if (Cursor.Clip != 1662.94 || !1535.58)
			{
				Cursor.Clip = 1662.94;
				1535.58 = true;
			}
			1535.57 = true;
			return;
		}
		if (1535.58 || (Cursor.Clip != 1535.1 && 1662.11.2()))
		{
			Cursor.Clip = 1535.1;
			1535.58 = false;
		}
		1535.57 = false;
	}

	// Token: 0x060048E3 RID: 18659 RVA: 0x001CE3DC File Offset: 0x001CC5DC
	private static void 15()
	{
		1535.53 = new 1404(12, new 208(10.5f, 465f), 640f, true, 0.98f);
		1535.53.1.54(false);
		1535.54 = 1535.53.15;
		1535.52 = 1535.54.11;
		1535.53.24(false);
		1535.30(1535.54);
	}

	// Token: 0x060048E4 RID: 18660 RVA: 0x001CE454 File Offset: 0x001CC654
	internal static void 16(1189 1)
	{
		bool flag = 1535.22;
		1535.22 = (!1535.1() && (!2486.22 || 2486.13 || (2648.6 && (2486.7 == null || 2486.7.46))));
		1535.14();
		1555.28();
		1535.59 = 1555.31(1535.2);
		1555.32();
		if (1535.7 > 0)
		{
			1535.7 = (int)Math.Max(0.0, (double)1535.7 - 1662.82);
		}
		int num = 0;
		1535.73 = ((1535.22 && flag) ? (1535.74 - 1535.6) : 208.Zero);
		1535.74 = 1535.6;
		int num2 = 1226.16;
		int num3 = 1226.18;
		bool flag2 = false;
		do
		{
			1226.13();
			1535.56 = 1662.23;
			if (!1535.22)
			{
				flag2 = 1535.17();
				if (!1535.1() && 2486.22)
				{
					2486.21();
					1535.23();
				}
			}
			else if (!1662.12)
			{
				2486.21();
				1535.23();
				if (1535.6 != 1555.21())
				{
					if (1555.1() && 1662.11.2())
					{
						1535.68 = 1662.33;
					}
					1535.6 = 1555.21();
				}
				1535.5 = 1555.17();
				1535.34 = 1662.69.14(1535.6);
			}
			1535.60 = 1226.16 - 1535.62;
			1535.62 += 1535.60;
			if (!1662.14)
			{
				1535.51.17 = (1535.31 ? 1535.6 : 1555.21());
			}
			if (1535.32 && (1662.11.2() || 1535.1()))
			{
				1555.47();
				try
				{
					1535.11 = 1552.1();
				}
				catch (InvalidOperationException)
				{
				}
				1535.69.Clear();
				if (1662.11.2())
				{
					200[] array = 1535.11.3();
					if (array.Length != 0)
					{
						1535.69.AddRange(array);
					}
				}
				if (1304.135)
				{
					1567.5(1535.69);
				}
				1535.69.AddRange(1546.3);
				if (!1535.1())
				{
					1535.24();
				}
				1535.18(1535.69);
				1535.29 += 1662.82;
				if (1535.29 >= 100.0)
				{
					1535.29 -= 100.0;
					if (1535.14 == 199.Pressed && 1555.20 && 1662.76 != (932)0)
					{
						Queue<1189> queue = 1535.3;
						1189 item;
						if ((item = 1535.<>O.<2>__DispatchClickRepeat) == null)
						{
							item = (1535.<>O.<2>__DispatchClickRepeat = new 1189(1555.37));
						}
						queue.Enqueue(item);
					}
				}
				1535.21 = (1535.14 == 199.Pressed && ((!1535.24) ? (1535.19 != 1535.14) : (1535.16 || 1535.18)));
				1535.50 = (1535.43 == 199.Pressed && ((!1535.24) ? (1535.48 != 1535.43) : (1535.45 || 1535.47)));
				if ((1535.21 || 1535.50) && 2139.IsActive)
				{
					bool flag3 = false;
					if (1535.21 && !2139.2(true))
					{
						1535.21 = false;
						flag3 = true;
					}
					if (1535.50 && !2139.2(false))
					{
						1535.50 = false;
						flag3 = true;
					}
					if (flag3)
					{
						1555.15 = true;
					}
				}
				2139.1();
				1535.23 = (1555.6() == 199.Pressed && 1535.26 != 1555.6());
				object obj = 1662.11.2() && ((1555.2() == 199.Pressed && 1535.25 != 199.Pressed) || (1555.4() == 199.Pressed && 1535.27 != 199.Pressed) || 1535.23);
				bool flag4 = (1555.2() == 199.Released && 1535.25 != 199.Released) || (1555.4() == 199.Released && 1535.27 != 199.Released) || (1555.6() == 199.Released && 1535.26 > 199.Released);
				object obj2 = obj;
				1555.31 = ((obj2 | flag4) != null);
				1555.13 = false;
				if (1535.19 != 1535.14 || 1535.48 != 1535.43)
				{
					1555.17 = 1555.16;
					1555.16 = 1555.21;
					1555.21 = MouseButtons.None;
					if (1535.14 == 199.Pressed)
					{
						1555.21 |= MouseButtons.Left;
						1555.22 = MouseButtons.Left;
					}
					if (1535.43 == 199.Pressed)
					{
						1555.21 |= MouseButtons.Right;
						1555.22 = MouseButtons.Right;
					}
				}
				bool flag5 = false;
				if (obj2 != null)
				{
					1555.11 = 1555.21();
					1555.12 = 1662.33;
					1535.68 = 1662.33;
					if (1662.76 != (932)0)
					{
						if (1535.7 > 0)
						{
							1555.13 = true;
							Queue<1189> queue2 = 1535.3;
							1189 item2;
							if ((item2 = 1535.<>O.<3>__DispatchDoubleClick) == null)
							{
								item2 = (1535.<>O.<3>__DispatchDoubleClick = new 1189(1555.39));
							}
							queue2.Enqueue(item2);
							1535.7 = 0;
						}
						else
						{
							Queue<1189> queue3 = 1535.3;
							1189 item3;
							if ((item3 = 1535.<>O.<4>__DispatchClick) == null)
							{
								item3 = (1535.<>O.<4>__DispatchClick = new 1189(1555.36));
							}
							queue3.Enqueue(item3);
							flag5 = true;
							1535.29 = 0.0;
							1535.7 = 250;
						}
					}
				}
				1555.14 = false;
				if (1535.21 || 1535.50)
				{
					if (1535.67 && (!1535.1() || 1535.31))
					{
						1535.72 = true;
						1535.51.3.RemoveAll(new Predicate<1445>(1535.1538.Instance.1));
						1445 2 = new 1445(1456.Scale, 1f, 1.3f, 1662.33, 1662.33 + 100, (1046)0);
						2.15 = (1046)1;
						1535.51.3.Add(2);
					}
					1555.15 = true;
					1555.12 = 1662.33;
					1555.14 = true;
					if (1662.76 != (932)0)
					{
						if (1535.21)
						{
							Queue<1189> queue4 = 1535.3;
							1189 item4;
							if ((item4 = 1535.<>O.<5>__DispatchGameplayPress) == null)
							{
								item4 = (1535.<>O.<5>__DispatchGameplayPress = new 1189(1555.35));
							}
							queue4.Enqueue(item4);
						}
						if (1535.50)
						{
							Queue<1189> queue5 = 1535.3;
							1189 item5;
							if ((item5 = 1535.<>O.<5>__DispatchGameplayPress) == null)
							{
								item5 = (1535.<>O.<5>__DispatchGameplayPress = new 1189(1555.35));
							}
							queue5.Enqueue(item5);
						}
						if (!1535.1() && !flag5)
						{
							Queue<1189> queue6 = 1535.3;
							1189 item6;
							if ((item6 = 1535.<>O.<4>__DispatchClick) == null)
							{
								item6 = (1535.<>O.<4>__DispatchClick = new 1189(1555.36));
							}
							queue6.Enqueue(item6);
						}
					}
				}
				bool flag6 = 1535.14 == 199.Released && 1535.43 == 199.Released && 1555.15;
				if (flag4 || flag6)
				{
					if (1436.1 != null)
					{
						if (1436.1.11 && 208.Distance(1555.11, 1555.21()) * 1662.70.8() < 10f)
						{
							1436.1.1(true);
						}
						1436.1 = null;
					}
					1535.70 = false;
					if (!1535.1() || flag4)
					{
						Queue<1189> queue7 = 1535.3;
						1189 item7;
						if ((item7 = 1535.<>O.<6>__DispatchRelease) == null)
						{
							item7 = (1535.<>O.<6>__DispatchRelease = new 1189(1555.38));
						}
						queue7.Enqueue(item7);
					}
				}
				if (flag6)
				{
					1535.72 = false;
					if (1535.67)
					{
						1535.51.3.RemoveAll((1445 1) => 1.14 == 1456.Scale);
						1445 3 = new 1445(1456.Scale, 1535.51.15, 1f, 1662.33, 1662.33 + 100, (1046)0);
						3.15 = (1046)1;
						1535.51.3.Add(3);
					}
					1555.15 = false;
				}
				if (1555.2() == 199.Pressed && 1662.76 != (932)0)
				{
					1555.20 = true;
					if (1555.21() != 1555.11)
					{
						1535.3.Enqueue(delegate
						{
							1535.39((1082)3);
							1535.10 = true;
						});
					}
				}
				else
				{
					1555.20 = false;
					if (1535.10)
					{
						Queue<1189> queue8 = 1535.3;
						1189 item8;
						if ((item8 = 1535.<>O.<7>__DispatchDragEnd) == null)
						{
							item8 = (1535.<>O.<7>__DispatchDragEnd = new 1189(1555.40));
						}
						queue8.Enqueue(item8);
					}
				}
			}
			else
			{
				1535.14 = 199.Released;
				1535.43 = 199.Released;
				1549.1 = false;
				1549.2 = false;
				1549.3 = false;
			}
			1535.55 = 1662.11.2();
			int num4 = 1226.16;
			int num5 = 1226.18;
			while (1535.3.Count > 0)
			{
				1535.3.Dequeue()();
			}
			4();
			1535.19 = 1535.14;
			1535.48 = 1535.43;
			1535.20 = (1535.14 == 199.Pressed);
			1535.49 = (1535.43 == 199.Pressed);
			1535.25 = 1555.2();
			1535.27 = 1555.4();
			1535.26 = 1555.6();
			1535.12 = 1535.11;
			if (1535.56)
			{
				1535.61 = 1226.16;
			}
		}
		while ((1555.46() || ((1535.1() || !1535.22) && flag2)) && num++ < (2486.189 ? 1000000 : 30));
		1535.26();
	}

	// Token: 0x060048E5 RID: 18661 RVA: 0x001CED84 File Offset: 0x001CCF84
	private static bool 17()
	{
		bool flag = false;
		object obj = 1535.37;
		lock (obj)
		{
			if (1535.39 != null && 1535.39.26 != null)
			{
				int count = 1535.39.26.Count;
				1535.38 = false;
				1535.56 = false;
				2486 <<EMPTY_NAME>> = 2486.7;
				if (!1535.40 && 1535.33 == count - 1)
				{
					1535.42 = true;
				}
				if (1662.78 == 1677.Play && 2486.88 != null && <<EMPTY_NAME>> != null && <<EMPTY_NAME>>.80 != (707)0 && 2486.109 && count > 0 && 1535.33 < count - 1 && (1535.42 || !1662.47 || !1662.52) && (1535.42 || !1535.40 || 1535.39.26[count - 1].10 - 1226.16 > 1000))
				{
					1535.4 = false;
					if (1535.33 < count - 1 && 1535.39.26[1535.33 + 1].10 <= 1226.16 && !2486.13 && (!1226.10() || 2486.189))
					{
						1535.33++;
						1535.38 = true;
					}
					flag = (1226.16 - 1535.39.26[1535.33].10 > 16 && 1535.38);
					if (flag && 1535.39.CanSkipUnchangedReplayFrames() && !2486.189)
					{
						while (1535.33 < count - 1 && !1535.39.26[1535.33].3 && !1535.39.26[1535.33].4 && 1535.39.26[1535.33 + 1].10 <= 1226.16 && 1535.39.26[1535.33].3 == 1535.20 && 1535.39.26[1535.33].4 == 1535.49 && 1535.39.26[1535.33].9 == 1535.13 && !2486.9)
						{
							float num = 1226.30;
							float num2 = 1226.29;
							1535.33++;
						}
					}
					if (1535.24)
					{
						1535.16 = false;
						1535.18 = false;
						1535.45 = false;
						1535.47 = false;
						1535.14 = 199.Released;
						1535.43 = 199.Released;
					}
					1535.71 = 1535.39.26[1535.33];
					if (!1535.38 && 2486.189)
					{
						1226.16 = 1535.71.10;
					}
					208 2;
					if (1535.38)
					{
						1226.16 = 1535.71.10;
						1535.56 = true;
						1535.16 = ((!1535.24 || !1535.15) && 1535.71.5);
						1535.15 = 1535.71.5;
						1535.18 = ((!1535.24 || !1535.17) && 1535.71.7);
						1535.17 = 1535.71.7;
						1535.45 = ((!1535.24 || !1535.44) && 1535.71.6);
						1535.44 = 1535.71.6;
						1535.47 = ((!1535.24 || !1535.46) && 1535.71.8);
						1535.46 = 1535.71.8;
						1535.14 = ((1535.16 || 1535.18) ? 199.Pressed : 199.Released);
						1535.43 = ((1535.45 || 1535.47) ? 199.Pressed : 199.Released);
						2 = new 208(1535.71.1, 1535.71.2);
						if (2486.109 && 1535.39.9 == 2147.OsuMania)
						{
							int num3 = (int)1535.71.1;
							double num4 = (double)1535.71.2;
							1975 3 = (1975)2486.7.39;
							for (int i = 0; i < 1535.8().19.Count; i++)
							{
								bool flag3 = (num3 & 1535.8().19[i].20()) > 0;
								if (1535.8().42())
								{
									if (i == 0)
									{
										1535.8().19[1535.8().19.Count - 1].24(flag3);
									}
									else
									{
										1535.8().19[i - 1].24(flag3);
									}
								}
								else
								{
									1535.8().19[i].24(flag3);
								}
							}
							if (num4 > 0.0)
							{
								1984 4 = (1984)1;
								if (1535.39.34 >= 20141029 && 1535.39.34 < 20151010)
								{
									4 = (1984)0;
								}
								if (2009.2(num4, false, 4))
								{
									3.79(1535.71.10);
								}
							}
							2 = new 208(-500f, -500f);
						}
						1535.13 = 1535.71.9;
					}
					else if (1535.39.9 == 2147.OsuMania)
					{
						for (int j = 0; j < 1535.8().19.Count; j++)
						{
							1535.8().19[j].18 = 1535.8().19[j].23();
						}
						2 = new 208(-500f, -500f);
					}
					else if (1535.71.10 == 1535.39.26[1535.33 + 1].10)
					{
						2 = new 208(1535.71.1, 1535.71.2);
					}
					else if (1535.71.10 >= 1226.16)
					{
						int index = Math.Max(0, 1535.33 - 1);
						int index2 = 1535.33;
						2 = 208.Lerp(new 208(1535.39.26[index].1, 1535.39.26[index].2), new 208(1535.39.26[index2].1, 1535.39.26[index2].2), (1535.39.26[index2].10 == 1535.39.26[index].10) ? 0f : Math.Max(0f, 1f - (float)(1535.39.26[index2].10 - 1226.16) / (float)(1535.39.26[index2].10 - 1535.39.26[index].10)));
					}
					else
					{
						int index3 = 1535.33;
						int index4 = Math.Min(count - 1, 1535.33 + 1);
						2 = 208.Lerp(new 208(1535.39.26[index3].1, 1535.39.26[index3].2), new 208(1535.39.26[index4].1, 1535.39.26[index4].2), (1535.39.26[index4].10 == 1535.39.26[index3].10) ? 0f : 1052.19(1f - (float)(1535.39.26[index4].10 - 1226.16) / (float)(1535.39.26[index4].10 - 1535.39.26[index3].10), 0f, 1f));
					}
					2.X = 1052.19(2.X, -500f, 1000f);
					2.Y = 1052.19(2.Y, -500f, 1000f);
					1535.34 = 2;
					1535.6 = 1662.69.17(2);
					1535.5 = new 206((int)1535.6.X, (int)1535.6.Y);
					2486.14 = false;
				}
				else if (1535.40 || 1535.42)
				{
					2486.14 = false;
					if (1535.42)
					{
						1535.56 = true;
						if (2486.13 && !2486.4)
						{
							1535.4 = false;
						}
						if (2486.23 != null && 2486.4)
						{
							2486.23.SetText(1568.1(2679.InputManager_HostFailed));
						}
					}
					else
					{
						1535.4 = true;
						float num5 = (count != 0) ? 1052.19((float)(1535.39.26[count - 1].10 - 1226.16) / 10f, 0f, 100f) : 0f;
						if (2486.23 != null)
						{
							string text = null;
							if (text == null)
							{
								text = string.Format(1568.1(2679.InputManager_Buffering), num5);
							}
							2486.23.SetText(text);
						}
					}
				}
			}
		}
		return flag;
	}

	// Token: 0x060048E6 RID: 18662 RVA: 0x001CF784 File Offset: 0x001CD984
	private static void 18(List<200> 1)
	{
		if (1 == null)
		{
			1 = new List<200>();
		}
		List<200> list = new List<200>(1);
		1549.1 = (1535.11.2(200.LeftControl) || 1535.11.2(200.RightControl));
		1549.2 = (1535.11.2(200.LeftAlt) || 1535.11.2(200.RightAlt));
		1549.3 = (1535.11.2(200.LeftShift) || 1535.11.2(200.RightShift));
		if (1 == null || 1.Count == 0 || !1535.55)
		{
			1535.30 = -120.0;
		}
		if (!1549.1)
		{
			bool flag = 1549.2;
		}
		int num = 0;
		while (num != 1535.28.Count)
		{
			200 item = 1535.28[num];
			if (!1.Contains(item))
			{
				1535.28.RemoveAt(num);
				1535.68 = 1662.33;
				1549.8(item);
			}
			else
			{
				num++;
			}
		}
		1729 2 = 1535.33();
		if (2 != null && 2.3())
		{
			bool flag2 = false;
			if (1.Count >= 2 && 1.Contains(200.LeftControl) && 1.Contains(200.RightAlt))
			{
				flag2 = false;
			}
			else if (1.Count > 1 && (1.Contains(200.LeftAlt) || 1.Contains(200.LeftControl) || 1.Contains(200.RightAlt) || 1.Contains(200.RightControl)))
			{
				flag2 = true;
			}
			else if (1.Count == 1 && 1548.17(1[0], 1532.BossKey))
			{
				flag2 = true;
			}
			else
			{
				for (int i = 0; i < 1.Count; i++)
				{
					200 3 = 1[i];
					if (3 >= (200)300)
					{
						flag2 = true;
					}
					else
					{
						if (3 <= 200.Escape)
						{
							if (3 != 200.Tab && 3 != 200.Enter && 3 != 200.Escape)
							{
								goto IL_23C;
							}
						}
						else
						{
							switch (3)
							{
							case 200.PageUp:
							case 200.PageDown:
							case 200.Up:
							case 200.Down:
								break;
							case 200.End:
							case 200.Home:
								goto IL_23C;
							case 200.Left:
							case 200.Right:
								flag2 = 2.9;
								goto IL_280;
							default:
								if (3 != 200.Delete)
								{
									if (3 - 200.LeftControl > 3)
									{
										goto IL_23C;
									}
									flag2 = true;
									goto IL_280;
								}
								break;
							}
						}
						flag2 = true;
						goto IL_280;
						IL_23C:
						string text = 3.ToString();
						if (text[0] == 'F')
						{
							text = text.Substring(1);
							int num2;
							if (int.TryParse(text, out num2))
							{
								flag2 = true;
								goto IL_280;
							}
						}
						1.Remove(3);
						i--;
					}
					IL_280:;
				}
			}
			if (!flag2)
			{
				1535.30 = -120.0;
				1535.28 = list;
				return;
			}
		}
		for (int j = 0; j < 1.Count; j++)
		{
			200 4 = 1[j];
			bool flag3 = false;
			if (1535.28 != null)
			{
				for (int k = 0; k < 1535.28.Count; k++)
				{
					if (4 == 1535.28[k])
					{
						flag3 = true;
						break;
					}
				}
			}
			if (!flag3 && 4 == 200.Escape && 1662.78 == 1677.Play && 1535.1())
			{
				1689 5 = 1662.92;
				string[] array = new string[16];
				array[0] = "Escape pressed: screen transition ";
				int num3 = 1;
				int num2 = (int)1662.76;
				array[num3] = num2.ToString();
				array[2] = " at ";
				array[3] = 1662.75.ToString("0.#", CultureInfo.InvariantCulture);
				array[4] = ", input enabled ";
				array[5] = 1535.32.ToString();
				array[6] = ", window active ";
				array[7] = 1662.11.2().ToString();
				array[8] = ", text box ";
				array[9] = (1535.33() != null).ToString();
				array[10] = ", dialog ";
				array[11] = ((5 != null) ? ("\"" + 5.6 + "\"") : "none");
				array[12] = ", cursor forced ";
				array[13] = 1662.81().ToString();
				array[14] = ", ";
				int num4 = 15;
				2486 6 = 2486.7;
				array[num4] = (((6 != null) ? 6.18() : null) ?? "no play screen");
				1535.38(string.Concat(array));
			}
			if (1662.76 != (932)0)
			{
				if (!flag3)
				{
					1535.29 = -100.0;
					1535.30 = -120.0;
					string text2 = null;
					bool flag4 = 1662.83(null, 4);
					if (flag4)
					{
						text2 = "a global shortcut";
					}
					if (!flag4 && 2 != null && 2.8 != null)
					{
						flag4 = 2.8.HandleKey(null, 4, true);
						if (flag4)
						{
							string str = "a text box";
							1729 7 = 2.8.15;
							text2 = str + ((((7 != null) ? 7.11 : null) != null && 2.8.15.11.1) ? " (IME composition in progress)" : string.Empty);
						}
					}
					if (!flag4 && 1662.46 != null)
					{
						flag4 = 1662.46.12(null, 4, true);
						if (flag4)
						{
							text2 = "the volume control";
						}
					}
					if (!flag4 && 1662.92 != null)
					{
						text2 = "the dialog \"" + 1662.92.6 + "\"";
						flag4 = 1662.92.OnKeyDown(4);
						flag4 = true;
					}
					if (1662.81())
					{
						flag4 = true;
						text2 = "the forced cursor (a message box or setup)";
					}
					if (text2 != null && 1662.78 == 1677.Play && 1535.1())
					{
						1535.38("key " + 4.ToString() + " taken by " + text2);
					}
					if (!flag4 && 1662.104.22())
					{
						flag4 = 1662.104.20(null, 4, true);
					}
					if (!flag4)
					{
						1535.68 = 1662.33;
						1549.7(4);
					}
				}
				else
				{
					int num5 = 0;
					while (num5 < 1535.28.Count && 4 != 1535.28[num5])
					{
						num5++;
					}
				}
			}
		}
		int num6 = 0;
		for (int l = 0; l < 1535.28.Count; l++)
		{
			if (1535.28[l] - 200.LeftShift > 5)
			{
				num6++;
			}
		}
		if (num6 > 0)
		{
			if (1535.30 >= 100.0)
			{
				1535.30 -= 100.0;
				if (1535.28 != null)
				{
					foreach (200 8 in 1)
					{
						foreach (200 9 in 1535.28)
						{
							if (8 == 9)
							{
								break;
							}
						}
						if (8 != 200.Attn && 8 != 200.Zoom)
						{
							bool flag5 = false;
							if (!flag5 && 2 != null && 2.8 != null)
							{
								flag5 = 2.8.HandleKey(null, 8, false);
							}
							if (!flag5 && 1662.46 != null)
							{
								flag5 = 1662.46.12(null, 8, false);
							}
							if (!flag5 && 1662.104.22())
							{
								flag5 = 1662.104.20(null, 8, false);
							}
							if (!flag5 && 1662.92 != null)
							{
								flag5 = true;
							}
							if (!flag5)
							{
								1535.68 = 1662.33;
								1549.9(8, false);
							}
						}
					}
				}
			}
			1535.30 += 1662.82;
		}
		else
		{
			1535.30 = -120.0;
		}
		1535.28 = list;
	}

	// Token: 0x060048E7 RID: 18663 RVA: 0x001CFF3C File Offset: 0x001CE13C
	internal static void 19()
	{
		if (1535.10)
		{
			1555.20 = false;
			1555.11 = 1535.6;
			1535.10 = false;
			1555.40();
		}
	}

	// Token: 0x060048E8 RID: 18664 RVA: 0x001CFF60 File Offset: 0x001CE160
	internal static void 20()
	{
		1535.21();
		1535.19 = 199.Released;
		1535.48 = 199.Released;
		1535.20 = false;
		1535.49 = false;
		1535.21 = false;
		1535.50 = false;
		1555.15 = false;
		1555.14 = false;
		1555.21 = MouseButtons.None;
		1555.16 = MouseButtons.None;
		1555.17 = MouseButtons.None;
	}

	// Token: 0x060048E9 RID: 18665 RVA: 0x001CFFB4 File Offset: 0x001CE1B4
	internal static void 21()
	{
		1535.14 = 199.Released;
		1535.16 = false;
		1535.15 = false;
		1535.18 = false;
		1535.17 = false;
		1535.43 = 199.Released;
		1535.45 = false;
		1535.44 = false;
		1535.47 = false;
		1535.46 = false;
	}

	// Token: 0x060048EA RID: 18666 RVA: 0x001CFFF4 File Offset: 0x001CE1F4
	internal static int 22()
	{
		int num = 0;
		for (int i = 0; i < 1535.8().19.Count; i++)
		{
			if (1535.8().19[i].23())
			{
				num = ((!(2486.7.39 is 1975) || !1535.8().42()) ? (num + 1535.8().19[i].20()) : ((i != 1535.8().19.Count - 1) ? (num + 1535.8().19[i + 1].20()) : (num + 1535.8().19[0].20())));
			}
		}
		return num;
	}

	// Token: 0x060048EB RID: 18667 RVA: 0x001D00B8 File Offset: 0x001CE2B8
	internal static void 23()
	{
		1535.14 = 1555.2();
		1535.16 = (1535.14 == 199.Pressed && (!1535.24 || !1535.20));
		1535.15 = (1535.14 == 199.Pressed);
		1535.18 = false;
		1535.17 = false;
		1535.43 = 1555.4();
		1535.45 = (1535.43 == 199.Pressed && (!1535.24 || !1535.49));
		1535.44 = (1535.43 == 199.Pressed);
		1535.47 = false;
		1535.46 = false;
	}

	// Token: 0x060048EC RID: 18668 RVA: 0x001D0150 File Offset: 0x001CE350
	private static void 24()
	{
		if (1662.78 == 1677.Play)
		{
			200 <<EMPTY_NAME>>;
			if ((<<EMPTY_NAME>> = 1548.13((1533)0)) != 200.None)
			{
				bool flag;
				1535.15 |= (flag = (1535.11.2(<<EMPTY_NAME>>) || 1546.3(<<EMPTY_NAME>>)));
				1535.16 |= (flag && (!1535.24 || (!1535.12.2(<<EMPTY_NAME>>) && !1546.4(<<EMPTY_NAME>>))));
			}
			if ((<<EMPTY_NAME>> = 1548.13((1533)1)) != 200.None)
			{
				bool flag2;
				1535.17 |= (flag2 = (1535.11.2(<<EMPTY_NAME>>) || 1546.3(<<EMPTY_NAME>>)));
				1535.18 |= (flag2 && (!1535.24 || (!1535.12.2(<<EMPTY_NAME>>) && !1546.4(<<EMPTY_NAME>>))));
			}
			if ((<<EMPTY_NAME>> = 1548.13((1533)2)) != 200.None)
			{
				bool flag3;
				1535.44 |= (flag3 = (1535.11.2(<<EMPTY_NAME>>) || 1546.3(<<EMPTY_NAME>>)));
				1535.45 |= (flag3 && (!1535.24 || (!1535.12.2(<<EMPTY_NAME>>) && !1546.4(<<EMPTY_NAME>>))));
			}
			if (1548.13((1533)3) != 200.None)
			{
				<<EMPTY_NAME>> = 1548.13((1533)3);
				bool flag4;
				1535.46 |= (flag4 = (1535.11.2(<<EMPTY_NAME>>) || 1546.3(<<EMPTY_NAME>>)));
				1535.47 |= (flag4 && (!1535.24 || (!1535.12.2(<<EMPTY_NAME>>) && !1546.4(<<EMPTY_NAME>>))));
			}
			if ((1535.18 || 1535.16) && !1535.1())
			{
				1535.14 = 199.Pressed;
			}
			if ((1535.45 || 1535.47) && !1535.1())
			{
				1535.43 = 199.Pressed;
			}
		}
	}

	// Token: 0x060048ED RID: 18669 RVA: 0x001D032D File Offset: 0x001CE52D
	internal static bool 25()
	{
		return (1535.1() && 1535.31) || 2486.22;
	}

	// Token: 0x060048EE RID: 18670 RVA: 0x001D0344 File Offset: 0x001CE544
	private static void 26()
	{
		if (1535.51 == null || 1535.64 == null)
		{
			return;
		}
		1535.64.17 = 1535.51.17;
		1535.64.16 = 1535.51.16;
		if (!1535.51.19)
		{
			return;
		}
		1381 <<EMPTY_NAME>> = 2630.12;
		if (<<EMPTY_NAME>> == null || <<EMPTY_NAME>>.5() || <<EMPTY_NAME>>.3() < 5 || !1304.58.1())
		{
			1535.63 = -208.One;
			return;
		}
		if (1535.63 == -208.One || (1535.25() && (!1555.24(1535.63, -100) || !1555.24(1535.51.17, -100))))
		{
			1535.63 = 1535.51.17;
		}
		2137 2 = 2630.5();
		if (2 == null)
		{
			return;
		}
		if (1535.64.GetTexture() != null)
		{
			float num = (float)<<EMPTY_NAME>>.3() * 0.625f * 1662.70.3() * 1535.51.15 / 2.5f;
			if (208.Distance(1535.63, 1535.51.17) < num)
			{
				return;
			}
			List<208> list = (1535.25() || 1535.59 == null) ? new List<208>() : 1535.59.GetPositionHistory();
			list.Add(1535.51.17);
			foreach (208 3 in list)
			{
				float num2 = 208.Distance(1535.63, 3) / num;
				for (int i = 0; i < (int)num2; i++)
				{
					1662.27.1(208.Lerp(1535.63, 3, (float)i / num2));
				}
				if (num2 > 0f)
				{
					1535.63 = 208.Lerp(1535.63, 3, (float)((int)num2) / num2);
				}
			}
			list.RemoveAt(list.Count - 1);
		}
		else
		{
			if (!1662.23 && (double)(1662.33 - 1535.65) < 16.666666666666668)
			{
				return;
			}
			1433 4 = new 1433(<<EMPTY_NAME>>, (1376)16, 2.CursorCentre ? 1065.Centre : 1065.TopLeft, (1044)0, 1535.51.17, 1535.51.2 - 0.001f, false, 1535.51.30, null)
			{
				15 = 1535.51.15,
				20 = 1535.51.20,
				14 = (2.CursorTrailRotate ? 1535.51.14 : 0f)
			};
			if (1662.26 != null)
			{
				1662.26.12(4);
			}
			4.16(150, (1046)0, 0);
		}
		1535.65 = 1662.33;
	}

	// Token: 0x060048EF RID: 18671 RVA: 0x001D0618 File Offset: 0x001CE818
	public static 1083 27(Type 1)
	{
		1535.1537 2 = new 1535.1537();
		2.1 = 1;
		return 1535.2.Find(new Predicate<1083>(2.1));
	}

	// Token: 0x060048F0 RID: 18672 RVA: 0x001D0648 File Offset: 0x001CE848
	public static bool 28(1083 1)
	{
		try
		{
			if (1.Initialize())
			{
				int num = 1535.2.BinarySearch(1, new 1084());
				if (num < 0)
				{
					num = ~num;
				}
				1535.2.Insert(num, 1);
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	// Token: 0x060048F1 RID: 18673 RVA: 0x001D06A0 File Offset: 0x001CE8A0
	internal static void 29()
	{
		2023 <<EMPTY_NAME>> = (2486.88 != null) ? 2486.88.8.1() : 2019.1;
		float num = 1f;
		if (1662.78 == 1677.Play && 1304.133.1() && 2486.14() == 2147.Osu)
		{
			num = 1f - 0.7f * (float)(2039.22((double)1926.5(1928.CircleSize, 1272.5().2), 1.3, <<EMPTY_NAME>>) - 4.0) / 5f;
		}
		if (1535.51 != null)
		{
			1535.51.20 = num * 208.One * (float)1304.132.GetValue();
		}
		if (1535.64 != null)
		{
			1535.64.20 = 1535.51.20;
		}
	}

	// Token: 0x060048F2 RID: 18674 RVA: 0x001D0771 File Offset: 0x001CE971
	internal static void 30(1729 1)
	{
		if (!1535.66.Remove(1))
		{
			1662.13().Controls.Add(1);
		}
		1535.66.Add(1);
		1.SendToBack();
		1535.32(true);
	}

	// Token: 0x060048F3 RID: 18675 RVA: 0x001D07A8 File Offset: 0x001CE9A8
	internal static void 31(1729 1)
	{
		if (1 != 1535.54)
		{
			1662.13().Controls.Remove(1);
			1535.66.Remove(1);
			1535.32(true);
		}
	}

	// Token: 0x060048F4 RID: 18676 RVA: 0x001D07D8 File Offset: 0x001CE9D8
	internal static 1729 32(bool 1)
	{
		1729 2 = 1535.33();
		if (2 == null)
		{
			return null;
		}
		if (!1662.81() && 1662.11.2() && (!2.Focused || 1))
		{
			2.Focus();
		}
		return 2;
	}

	// Token: 0x060048F5 RID: 18677 RVA: 0x001D0818 File Offset: 0x001CEA18
	internal static 1729 33()
	{
		if (1535.66.Count == 0)
		{
			return null;
		}
		for (int i = 1535.66.Count - 1; i >= 0; i--)
		{
			1729 <<EMPTY_NAME>> = 1535.66[i];
			if (<<EMPTY_NAME>>.3())
			{
				return <<EMPTY_NAME>>;
			}
		}
		return null;
	}

	// Token: 0x060048F6 RID: 18678 RVA: 0x001D0864 File Offset: 0x001CEA64
	internal static bool 34()
	{
		if (1304.139 != 1.0 && !1304.191 && 1662.55())
		{
			1304.191.2(true);
			1763.5(1568.1(2679.Options_Input_RawInputRequired), 198.OrangeRed, 10000, null);
			return true;
		}
		return false;
	}

	// Token: 0x060048F7 RID: 18679 RVA: 0x001D08C4 File Offset: 0x001CEAC4
	internal static void 35(208 1)
	{
		1555.15(new 206((int)Math.Round((double)1.X), (int)Math.Round((double)1.Y)), false);
		1535.6 = 1;
		1535.74 = 1535.6;
		1535.59 = null;
		1555.23();
	}

	// Token: 0x060048F8 RID: 18680 RVA: 0x001D0914 File Offset: 0x001CEB14
	internal static void 36(208 1)
	{
		foreach (1083 2 in 1535.2)
		{
			if (2 != 1535.59 && 2 is 1079)
			{
				((1079)2).SetPosition(1);
			}
		}
	}

	// Token: 0x060048F9 RID: 18681 RVA: 0x001D097C File Offset: 0x001CEB7C
	private static void 37()
	{
		1662.72(new 1189(1535.1538.Instance.2));
		List<1545> list = new List<1545>((1545[])Enum.GetValues(typeof(1545)));
		list.Reverse();
		foreach (1545 <<EMPTY_NAME>> in list)
		{
			1535.75.Add(new 1542(<<EMPTY_NAME>>, true));
		}
	}

	// Token: 0x060048FA RID: 18682 RVA: 0x001D0A08 File Offset: 0x001CEC08
	internal static void 38(string 1)
	{
		if (1662.33 - 1535.77 < 1000)
		{
			return;
		}
		1535.77 = 1662.33;
		1338.5("Replay input: " + 1, 1341.Runtime, (1114)2);
	}

	// Token: 0x060048FB RID: 18683 RVA: 0x001D0A3C File Offset: 0x001CEC3C
	internal static void 39(1082 1)
	{
		using (List<1542>.Enumerator enumerator = 1535.75.GetEnumerator())
		{
			while (enumerator.MoveNext() && !enumerator.Current.3(1))
			{
			}
		}
	}

	// Token: 0x060048FC RID: 18684 RVA: 0x001D0A8C File Offset: 0x001CEC8C
	internal static void 40(1082 1, 1081 2, 1545 3, 1559 4)
	{
		1535.1539 subscription = new 1535.1539();
		subscription.1 = 3;
		subscription.2 = 6;
		subscription.3 = 2;
		subscription.4 = 1535.75.Find((1542 1) => 1.1 == subscription.1);
		1535.1536 5 = new 1535.1536();
		5.2 = subscription;
		if (4 != (1559)0)
		{
			if (4 == (1559)3)
			{
				5.1 = null;
				5.1 = new 1081(5.6);
				5.2.4.1(5.2.2, 5.1);
			}
		}
		else
		{
			1535.76.Enqueue(new 1189(5.2.6));
		}
		subscription.4.1(subscription.2, subscription.3);
	}

	// Token: 0x060048FD RID: 18685 RVA: 0x001D0B88 File Offset: 0x001CED88
	internal static void 41(1082 1, 1081 2, 1545 3)
	{
		1535.1541 4 = new 1535.1541();
		4.1 = 3;
		1535.75.Find(new Predicate<1542>(4.1)).2(1, 2);
	}

	// Token: 0x04003620 RID: 13856
	internal static readonly Rectangle 1 = Cursor.Clip;

	// Token: 0x04003621 RID: 13857
	private static readonly List<1083> 2 = new List<1083>();

	// Token: 0x04003622 RID: 13858
	private static readonly Queue<1189> 3 = new Queue<1189>();

	// Token: 0x04003623 RID: 13859
	internal static bool 4;

	// Token: 0x04003624 RID: 13860
	internal static 206 5;

	// Token: 0x04003625 RID: 13861
	internal static 208 6;

	// Token: 0x04003626 RID: 13862
	internal static int 7;

	// Token: 0x04003627 RID: 13863
	internal static string 8;

	// Token: 0x04003628 RID: 13864
	private static bool 9;

	// Token: 0x04003629 RID: 13865
	internal static bool 10;

	// Token: 0x0400362A RID: 13866
	internal static 1087 11;

	// Token: 0x0400362B RID: 13867
	private static 1087 12;

	// Token: 0x0400362C RID: 13868
	internal static 1572 13;

	// Token: 0x0400362D RID: 13869
	internal static 199 14;

	// Token: 0x0400362E RID: 13870
	internal static bool 15;

	// Token: 0x0400362F RID: 13871
	internal static bool 16;

	// Token: 0x04003630 RID: 13872
	internal static bool 17;

	// Token: 0x04003631 RID: 13873
	internal static bool 18;

	// Token: 0x04003632 RID: 13874
	internal static 199 19;

	// Token: 0x04003633 RID: 13875
	internal static bool 20;

	// Token: 0x04003634 RID: 13876
	internal static bool 21;

	// Token: 0x04003635 RID: 13877
	internal static bool 22 = true;

	// Token: 0x04003636 RID: 13878
	private static bool 23;

	// Token: 0x04003637 RID: 13879
	internal static bool 24;

	// Token: 0x04003638 RID: 13880
	private static 199 25;

	// Token: 0x04003639 RID: 13881
	private static 199 26;

	// Token: 0x0400363A RID: 13882
	private static 199 27;

	// Token: 0x0400363B RID: 13883
	internal static List<200> 28 = new List<200>();

	// Token: 0x0400363C RID: 13884
	private static double 29;

	// Token: 0x0400363D RID: 13885
	private static double 30;

	// Token: 0x0400363E RID: 13886
	internal static bool 31 = true;

	// Token: 0x0400363F RID: 13887
	internal static bool 32 = true;

	// Token: 0x04003640 RID: 13888
	internal static int 33;

	// Token: 0x04003641 RID: 13889
	internal static 208 34;

	// Token: 0x04003642 RID: 13890
	private static bool 35;

	// Token: 0x04003643 RID: 13891
	internal static 2560 36;

	// Token: 0x04003644 RID: 13892
	internal static readonly object 37 = new object();

	// Token: 0x04003645 RID: 13893
	internal static bool 38;

	// Token: 0x04003646 RID: 13894
	internal static 2241 39;

	// Token: 0x04003647 RID: 13895
	internal static bool 40;

	// Token: 0x04003648 RID: 13896
	internal static int 41;

	// Token: 0x04003649 RID: 13897
	internal static bool 42;

	// Token: 0x0400364A RID: 13898
	internal static 199 43;

	// Token: 0x0400364B RID: 13899
	internal static bool 44;

	// Token: 0x0400364C RID: 13900
	internal static bool 45;

	// Token: 0x0400364D RID: 13901
	internal static bool 46;

	// Token: 0x0400364E RID: 13902
	internal static bool 47;

	// Token: 0x0400364F RID: 13903
	internal static 199 48;

	// Token: 0x04003650 RID: 13904
	internal static bool 49;

	// Token: 0x04003651 RID: 13905
	internal static bool 50;

	// Token: 0x04003652 RID: 13906
	internal static 1433 51;

	// Token: 0x04003653 RID: 13907
	internal static 1695 52;

	// Token: 0x04003654 RID: 13908
	internal static 1404 53;

	// Token: 0x04003655 RID: 13909
	internal static 1729 54;

	// Token: 0x04003656 RID: 13910
	private static bool 55;

	// Token: 0x04003657 RID: 13911
	internal static bool 56;

	// Token: 0x04003658 RID: 13912
	internal static bool 57 = false;

	// Token: 0x04003659 RID: 13913
	private static bool 58 = false;

	// Token: 0x0400365A RID: 13914
	internal static 1079 59;

	// Token: 0x0400365B RID: 13915
	internal static int 60 = 0;

	// Token: 0x0400365C RID: 13916
	internal static int 61;

	// Token: 0x0400365D RID: 13917
	private static int 62 = 0;

	// Token: 0x0400365E RID: 13918
	private static 208 63 = -208.One;

	// Token: 0x0400365F RID: 13919
	internal static 1433 64;

	// Token: 0x04003660 RID: 13920
	private static int 65 = 0;

	// Token: 0x04003661 RID: 13921
	internal static List<1729> 66 = new List<1729>();

	// Token: 0x04003662 RID: 13922
	public static bool 67;

	// Token: 0x04003663 RID: 13923
	public static int 68;

	// Token: 0x04003664 RID: 13924
	private static List<200> 69 = new List<200>();

	// Token: 0x04003665 RID: 13925
	public static bool 70;

	// Token: 0x04003666 RID: 13926
	internal static 1840 71;

	// Token: 0x04003667 RID: 13927
	private static bool 72;

	// Token: 0x04003668 RID: 13928
	internal static 208 73;

	// Token: 0x04003669 RID: 13929
	internal static 208 74;

	// Token: 0x0400366A RID: 13930
	private static List<1542> 75 = new List<1542>();

	// Token: 0x0400366B RID: 13931
	private static Queue<1189> 76 = new Queue<1189>();

	// Token: 0x0400366C RID: 13932
	private static int 77 = -10000;

	// Token: 0x02000A4B RID: 2635
	[Serializable]
	public sealed class 1538
	{
		// Token: 0x060048FF RID: 18687 RVA: 0x000AAB47 File Offset: 0x000A8D47
		internal bool 1(1445 1)
		{
			return 1.14 == 1456.Scale;
		}

		// Token: 0x06004900 RID: 18688 RVA: 0x001D0C70 File Offset: 0x001CEE70
		internal void 2()
		{
			while (1535.76.Count != 0)
			{
				1535.76.Dequeue()();
			}
		}

		// Token: 0x0400366D RID: 13933
		public static readonly 1535.1538 Instance = new 1535.1538();

		// Token: 0x0400366E RID: 13934
		public static Predicate<1445> predicate;

		// Token: 0x0400366F RID: 13935
		public static Predicate<1445> predicate2;

		// Token: 0x04003670 RID: 13936
		public static 1189 voidDelegate;
	}

	// Token: 0x02000A4C RID: 2636
	public sealed class 1540
	{
		// Token: 0x06004903 RID: 18691 RVA: 0x001D0C9C File Offset: 0x001CEE9C
		internal void Apply()
		{
			bool flag = !1535.54.3();
			if (this.1 && flag)
			{
				1535.54.4(true);
			}
			1535.54.11.Text = this.2;
			1535.54.11.Select(Math.Max(0, this.2.Length), 0);
			if (flag)
			{
				1535.54.4(false);
			}
		}

		// Token: 0x04003671 RID: 13937
		public bool 1;

		// Token: 0x04003672 RID: 13938
		public string 2;
	}

	// Token: 0x02000A4D RID: 2637
	public sealed class 1537
	{
		// Token: 0x06004905 RID: 18693 RVA: 0x001D0D10 File Offset: 0x001CEF10
		internal bool 1(1083 1)
		{
			return 1.GetType() == this.1;
		}

		// Token: 0x04003673 RID: 13939
		public Type 1;
	}

	// Token: 0x02000A4E RID: 2638
	public sealed class 1539
	{
		// Token: 0x06004907 RID: 18695 RVA: 0x001D0D23 File Offset: 0x001CEF23
		internal void 1()
		{
			1535.75.Find(new Predicate<1542>(this.2)).2(this.2, this.3);
		}

		// Token: 0x06004908 RID: 18696 RVA: 0x001D0D4C File Offset: 0x001CEF4C
		internal bool 2(1542 1)
		{
			return 1.1 == this.1;
		}

		// Token: 0x04003674 RID: 13940
		public 1545 1;

		// Token: 0x04003675 RID: 13941
		public 1082 2;

		// Token: 0x04003676 RID: 13942
		public 1081 3;

		// Token: 0x04003677 RID: 13943
		public 1542 4;
	}

	// Token: 0x02000A4F RID: 2639
	public sealed class 1536
	{
		// Token: 0x0600490A RID: 18698 RVA: 0x001D0D5C File Offset: 0x001CEF5C
		internal bool 1(object 1, EventArgs 2)
		{
			1662.89.Schedule(new 1189(this.2), true);
			return false;
		}

		// Token: 0x0600490B RID: 18699 RVA: 0x001D0D78 File Offset: 0x001CEF78
		internal void 2()
		{
			this.2.4.2(this.2.2, this.2.3);
			this.2.4.2(this.2.2, this.1);
		}

		// Token: 0x04003678 RID: 13944
		public 1081 1;

		// Token: 0x04003679 RID: 13945
		public 1535.1539 2;
	}

	// Token: 0x02000A50 RID: 2640
	public sealed class 1541
	{
		// Token: 0x0600490D RID: 18701 RVA: 0x001D0DCC File Offset: 0x001CEFCC
		internal bool 1(1542 1)
		{
			return 1.1 == this.1;
		}

		// Token: 0x0400367A RID: 13946
		public 1545 1;
	}

	// Token: 0x02000A51 RID: 2641
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0400367B RID: 13947
		public static 1189 <0>__OnWindowSizeChanged;

		// Token: 0x0400367C RID: 13948
		public static EventHandler <1>__OnWindowFocusChanged;

		// Token: 0x0400367D RID: 13949
		public static 1189 <2>__DispatchClickRepeat;

		// Token: 0x0400367E RID: 13950
		public static 1189 <3>__DispatchDoubleClick;

		// Token: 0x0400367F RID: 13951
		public static 1189 <4>__DispatchClick;

		// Token: 0x04003680 RID: 13952
		public static 1189 <5>__DispatchGameplayPress;

		// Token: 0x04003681 RID: 13953
		public static 1189 <6>__DispatchRelease;

		// Token: 0x04003682 RID: 13954
		public static 1189 <7>__DispatchDragEnd;
	}
}
