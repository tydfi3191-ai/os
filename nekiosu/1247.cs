using System;
using System.Collections.Generic;
using System.IO;

// Token: 0x02000BB4 RID: 2996
public sealed class 1247 : 1350
{
	// Token: 0x0600527A RID: 21114 RVA: 0x00207140 File Offset: 0x00205340
	internal 1247(1803 1) : base(5)
	{
		1247.6.23();
		1247.6.47 = true;
		1445 6 = new 1445(1456.Scale, 1f, 1.2f, 0, 100, (1046)0)
		{
			15 = (1046)1
		};
		1445 3 = new 1445(1456.Scale, 1.1f, 1.2f, 0, 100, (1046)0)
		{
			15 = (1046)1
		};
		int num = 136;
		1386 4 = new 1386(1048.step_backward, 14f, new 208((float)num, 11f))
		{
			41 = (1376)8,
			8 = "b"
		};
		4.10 = true;
		4.52 = "Previous track";
		4.12 = 3;
		4.35(new EventHandler(this.1));
		4.42 = 6;
		4.3(delegate(object 1, EventArgs 2)
		{
			if (1247.2())
			{
				1226.20(null, "click-short-confirm", 1f, false);
				1763.2("<< Prev", 1000, (1389)0);
				if (1247.4.Count > 0 && 1272.5() != null)
				{
					1247.3.Push(1272.5().23);
					1272.SetCurrentBeatmap(1272.8(1247.4.Pop()));
				}
				1247.16(false, false);
				this.9 = false;
			}
		});
		1247.6.12(4);
		num -= 20;
		4 = new 1386(1048.play, 14f, new 208((float)num, 11f))
		{
			41 = (1376)8,
			8 = "b"
		};
		4.10 = true;
		4.52 = "Play";
		4.12 = 3;
		4.35(new EventHandler(this.5));
		4.42 = 6;
		4.3(new EventHandler(this.12));
		1247.6.12(4);
		num -= 20;
		4 = new 1386(1048.pause, 14f, new 208((float)num, 11f))
		{
			41 = (1376)8,
			8 = "b"
		};
		4.10 = true;
		4.52 = "Pause";
		4.12 = 3;
		4.35(new EventHandler(this.5));
		4.42 = 6;
		4.3(new EventHandler(this.11));
		1247.6.12(4);
		num -= 20;
		4 = new 1386(1048.stop, 14f, new 208((float)num, 11f))
		{
			41 = (1376)8,
			8 = "b"
		};
		4.10 = true;
		4.52 = "Stop the music!";
		4.12 = 3;
		4.35(new EventHandler(this.5));
		4.42 = 6;
		4.3(new EventHandler(this.9));
		1247.6.12(4);
		num -= 20;
		4 = new 1386(1048.step_forward, 14f, new 208((float)num, 11f))
		{
			41 = (1376)8,
			8 = "b"
		};
		4.10 = true;
		4.52 = "Next track";
		4.12 = 3;
		4.42 = 6;
		4.35(new EventHandler(this.5));
		4.3(new EventHandler(this.8));
		1247.6.12(4);
		num -= 20;
		4 = new 1386(1048.info, 14f, new 208((float)num, 11f))
		{
			41 = (1376)8,
			8 = "b"
		};
		4.10 = true;
		4.52 = "View song info";
		4.12 = 3;
		4.35(new EventHandler(this.5));
		4.42 = 6;
		4.3(new EventHandler(this.7));
		1247.6.12(4);
		num -= 20;
		4 = new 1386(1048.bars, 14f, new 208((float)num, 11f))
		{
			41 = (1376)8,
			8 = "b"
		};
		4.10 = true;
		4.52 = "Jump To window";
		4.12 = 3;
		4.35(new EventHandler(this.5));
		4.42 = 6;
		4.3(new EventHandler(this.10));
		1247.6.12(4);
		this.7 = new 1433(1662.34, (1376)8, 1065.TopLeft, (1044)0, new 208(143f, 20f), 0.96f, true, new 198(20, 20, 20, 128), "b");
		this.7.15 = 1.6f;
		this.7.20 = new 208(134f, 3f);
		this.7.42 = new 1445(new 198(20, 20, 20, 128), new 198(60, 60, 60, 128), 0, 100);
		this.7.10 = true;
		this.7.52 = "Click to seek to a specific point in the song.";
		this.7.3(new EventHandler(this.6));
		this.7.28 = true;
		1247.6.12(this.7);
		this.8 = new 1433(1662.34, (1376)8, 1065.TopLeft, (1044)0, new 208(143f, 20f), 0.97f, true, new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 128), "b");
		this.8.15 = 1.6f;
		this.8.20 = new 208(0f, 3f);
		this.8.28 = true;
		1247.6.12(this.8);
		1549.1(delegate(object 1, 200 2)
		{
			if (!1247.2() || 1549.3 || 1549.1 || 1549.2)
			{
				return false;
			}
			if (1662.78 == 1677.Menu)
			{
				if (2 <= 200.C)
				{
					if (2 != 200.Left)
					{
						if (2 == 200.Right)
						{
							goto IL_95;
						}
						if (2 != 200.C)
						{
							goto IL_9F;
						}
						this.11(null, null);
						return true;
					}
				}
				else
				{
					if (2 == 200.J)
					{
						this.10(null, null);
						return true;
					}
					if (2 == 200.R)
					{
						1247.16(true, false);
						return true;
					}
					switch (2)
					{
					case 200.V:
						goto IL_95;
					case 200.W:
					case 200.Y:
						goto IL_9F;
					case 200.X:
						this.12(null, null);
						return true;
					case 200.Z:
						break;
					default:
						goto IL_9F;
					}
				}
				this.13(null, null);
				return true;
				IL_95:
				this.8(null, null);
				return true;
			}
			IL_9F:
			switch (2)
			{
			case 200.F1:
				this.13(null, null);
				return true;
			case 200.F2:
				this.12(null, null);
				return true;
			case 200.F3:
				this.11(null, null);
				return true;
			case 200.F4:
				if (!1549.2)
				{
					this.9(null, null);
					return true;
				}
				break;
			case 200.F5:
				this.8(null, null);
				return true;
			case 200.F6:
				this.10(null, null);
				return true;
			}
			return false;
		});
	}

	// Token: 0x0600527B RID: 21115 RVA: 0x002076B8 File Offset: 0x002058B8
	private void 1(object 1, EventArgs 2)
	{
		1226.20(null, "click-short", 1f, false);
	}

	// Token: 0x0600527C RID: 21116 RVA: 0x002076DE File Offset: 0x002058DE
	internal static bool 2()
	{
		return 1247.6.5 > 0f;
	}

	// Token: 0x0600527D RID: 21117 RVA: 0x002076F4 File Offset: 0x002058F4
	internal static void 3(bool 1)
	{
		int num = (1 > false) ? 1 : 0;
		if ((float)num != 1247.6.5)
		{
			1247.6.5 = (float)num;
			1247.21(false);
		}
	}

	// Token: 0x0600527E RID: 21118 RVA: 0x00207726 File Offset: 0x00205926
	internal static void 4()
	{
		if (!1662.47)
		{
			1247.6.22();
		}
	}

	// Token: 0x0600527F RID: 21119 RVA: 0x0020773C File Offset: 0x0020593C
	public override void Update()
	{
		if (1247.2())
		{
			if (1226.32 == (1042)1)
			{
				this.9 = false;
			}
			if (!this.9)
			{
				1247.14();
			}
			if (1226.9() > 0)
			{
				this.8.20 = new 208(Math.Max(0f, (float)1226.16 / (float)1226.9()) * 134f, 3f);
			}
			base.Update();
		}
	}

	// Token: 0x06005280 RID: 21120 RVA: 0x002077AC File Offset: 0x002059AC
	internal bool 5(object 1, 200 2)
	{
		if (!1247.2() || 1549.3 || 1549.1 || 1549.2)
		{
			return false;
		}
		if (1662.78 == 1677.Menu)
		{
			if (2 <= 200.C)
			{
				if (2 != 200.Left)
				{
					if (2 == 200.Right)
					{
						goto IL_95;
					}
					if (2 != 200.C)
					{
						goto IL_9F;
					}
					this.11(null, null);
					return true;
				}
			}
			else
			{
				if (2 == 200.J)
				{
					this.10(null, null);
					return true;
				}
				if (2 == 200.R)
				{
					1247.16(true, false);
					return true;
				}
				switch (2)
				{
				case 200.V:
					goto IL_95;
				case 200.W:
				case 200.Y:
					goto IL_9F;
				case 200.X:
					this.12(null, null);
					return true;
				case 200.Z:
					break;
				default:
					goto IL_9F;
				}
			}
			this.13(null, null);
			return true;
			IL_95:
			this.8(null, null);
			return true;
		}
		IL_9F:
		switch (2)
		{
		case 200.F1:
			this.13(null, null);
			return true;
		case 200.F2:
			this.12(null, null);
			return true;
		case 200.F3:
			this.11(null, null);
			return true;
		case 200.F4:
			if (!1549.2)
			{
				this.9(null, null);
				return true;
			}
			break;
		case 200.F5:
			this.8(null, null);
			return true;
		case 200.F6:
			this.10(null, null);
			return true;
		}
		return false;
	}

	// Token: 0x06005281 RID: 21121 RVA: 0x002078C0 File Offset: 0x00205AC0
	private void 6(object 1, EventArgs 2)
	{
		if (1247.2())
		{
			1247.6.29();
			1226.4((int)(Math.Min(1f, (1535.6.X - this.7.31.X) / 1662.70.3() / 134f) * (float)1226.9()), false, false);
		}
	}

	// Token: 0x06005282 RID: 21122 RVA: 0x00207923 File Offset: 0x00205B23
	private void 7(object 1, EventArgs 2)
	{
		if (1247.2())
		{
			1247.21(true);
			1763.2("Song Info will be " + (1304.110 ? "permanently displayed." : "temporarily displayed."), 1000, (1389)0);
		}
	}

	// Token: 0x06005283 RID: 21123 RVA: 0x00207960 File Offset: 0x00205B60
	private void 8(object 1, EventArgs 2)
	{
		if (1247.2())
		{
			1226.20(null, "click-short-confirm", 1f, false);
			1763.2(">> Next", 1000, (1389)0);
			if (1247.3.Count > 0)
			{
				1247.4.Push(1272.5().23);
				1272.SetCurrentBeatmap(1272.8(1247.3.Pop()));
				1247.16(false, false);
			}
			else
			{
				1247.16(true, false);
			}
			this.9 = false;
		}
	}

	// Token: 0x06005284 RID: 21124 RVA: 0x002079EC File Offset: 0x00205BEC
	private void 9(object 1, EventArgs 2)
	{
		if (1247.2())
		{
			1763.2("Stop Playing", 1000, (1389)0);
			1226.20(null, "click-short-confirm", 1f, false);
			1226.5();
			this.9 = true;
		}
	}

	// Token: 0x06005285 RID: 21125 RVA: 0x00207A38 File Offset: 0x00205C38
	private void 10(object 1, EventArgs 2)
	{
		1247.1249 3 = new 1247.1249();
		3.2 = this;
		if (!1247.2())
		{
			return;
		}
		if (1662.92 is 1697)
		{
			1662.92.Close(false);
			return;
		}
		1226.20(null, "click-short-confirm", 1f, false);
		if (1662.104.22())
		{
			1662.104.23(false);
		}
		3.1 = new 1697();
		3.1.3(new EventHandler(3.1));
		1662.25(3.1);
	}

	// Token: 0x06005286 RID: 21126 RVA: 0x00207AD0 File Offset: 0x00205CD0
	private void 11(object 1, EventArgs 2)
	{
		if (1247.2())
		{
			1226.20(null, "click-short-confirm", 1f, false);
			1763.2(1226.10() ? "Unpause" : "Pause", 1000, (1389)0);
			this.9 = 1226.107();
		}
	}

	// Token: 0x06005287 RID: 21127 RVA: 0x00207B28 File Offset: 0x00205D28
	private void 12(object 1, EventArgs 2)
	{
		if (1247.2())
		{
			1226.20(null, "click-short-confirm", 1f, false);
			1763.2("Play", 1000, (1389)0);
			if (1226.10())
			{
				1226.107();
			}
			else
			{
				1226.Pause();
			}
			this.9 = false;
		}
	}

	// Token: 0x06005288 RID: 21128 RVA: 0x00207B80 File Offset: 0x00205D80
	private void 13(object 1, EventArgs 2)
	{
		if (1247.2())
		{
			1226.20(null, "click-short-confirm", 1f, false);
			1763.2("<< Prev", 1000, (1389)0);
			if (1247.4.Count > 0 && 1272.5() != null)
			{
				1247.3.Push(1272.5().23);
				1272.SetCurrentBeatmap(1272.8(1247.4.Pop()));
			}
			1247.16(false, false);
			this.9 = false;
		}
	}

	// Token: 0x06005289 RID: 21129 RVA: 0x00207C08 File Offset: 0x00205E08
	internal static void 14()
	{
		if (1226.32 == (1042)0 && (1226.31 == null || 1226.31.GetPosition() > 1226.31.4 * 0.95) && 1226.1 && 1272.3.Count > 0 && 1662.76 == (932)2)
		{
			1247.16(true, false);
		}
	}

	// Token: 0x0600528A RID: 21130 RVA: 0x00207C68 File Offset: 0x00205E68
	private static bool 15(1262 1)
	{
		bool result;
		using (Stream stream = 1.46())
		{
			result = (stream != null);
		}
		return result;
	}

	// Token: 0x0600528B RID: 21131 RVA: 0x00207CA0 File Offset: 0x00205EA0
	internal static void 16(bool 1, bool 2)
	{
		if (1272.3.Count > 0)
		{
			List<1262> list = (1247.5.Count == 0) ? 1272.3 : 1247.5;
			int 3 = (1247.5.Count == 0) ? (list.Count - 1) : list.Count;
			1262 4 = list[1196.2(0, 3)];
			int num = 0;
			while (num++ < 100 && ((1272.5() != null && 4.81 == 1272.5().81) || !4.42() || !1247.15(4)))
			{
				4 = list[1196.2(0, 3)];
			}
			1247.17(4, 1, 2);
		}
	}

	// Token: 0x0600528C RID: 21132 RVA: 0x00207D54 File Offset: 0x00205F54
	internal static void 17(1262 1, bool 2, bool 3)
	{
		if (1272.5() == null || 2)
		{
			if (1272.5() != null)
			{
				1247.4.Push(1272.5().23);
			}
			1272.SetCurrentBeatmap(1);
		}
		try
		{
			1226.106(1272.5(), true, 3 || (!1304.199 && (1226.31 == null || 1226.11() == null || string.IsNullOrEmpty(1226.11().37))), true);
		}
		catch (1043)
		{
		}
		1247.21(false);
	}

	// Token: 0x0600528D RID: 21133 RVA: 0x00207DEC File Offset: 0x00205FEC
	internal static void 18(1262 1)
	{
		1247.4.Push(1.23);
	}

	// Token: 0x0600528E RID: 21134 RVA: 0x00207DFE File Offset: 0x00205FFE
	internal static void 19(1262 1)
	{
		1247.5.Add(1);
	}

	// Token: 0x0600528F RID: 21135 RVA: 0x00207E0B File Offset: 0x0020600B
	internal static void 20()
	{
		1247.5.Clear();
	}

	// Token: 0x06005290 RID: 21136 RVA: 0x00207E18 File Offset: 0x00206018
	private static void 21(bool 1)
	{
		if (1272.5() == null)
		{
			return;
		}
		if (!1247.10)
		{
			1247.6.16("b").ForEach(delegate(1371 1)
			{
				1.19(1.7, 100, (1046)1);
			});
			1247.6.16("np").ForEach(delegate(1371 1)
			{
				1.16(60, (1046)0, 0);
			});
			return;
		}
		if (11)
		{
			1304.110.2(!1304.110);
		}
		1247.6.19("np");
		string text = 1272.5().11();
		if (text == null)
		{
			return;
		}
		1452 2 = new 1452(text, 14f, 208.Zero, 208.Zero, 0.999f, 1304.110, 198.White, false);
		2.41 = (1376)8;
		2.8 = "np";
		bool flag = false;
		float x;
		while ((x = 2.GetTextSize().X) > 350f)
		{
			2.SetText(2.GetText().Substring(0, 2.GetText().Length - 1));
			flag = true;
		}
		if (flag)
		{
			2.SetText(2.GetText() + "...");
		}
		1445 3 = new 1445(new 208(-80f + x, 0f), new 208(10f + x, 0f), 1662.33, 1662.33 + 1000, (1046)0);
		3.15 = (1046)1;
		1445 4 = new 1445(1456.Fade, 0f, 1f, 1662.33, 1662.33 + 1000, (1046)0);
		3.15 = (1046)1;
		1445 5 = 3.2();
		5.9 = 1662.33 + 6000;
		5.10 = 1662.33 + 8000;
		1445 6 = 4.2();
		6.9 = 1662.33 + 6000;
		6.10 = 1662.33 + 8000;
		2.3.Add(3);
		2.3.Add(4);
		if (!1304.110)
		{
			2.3.Add(5);
			2.3.Add(6);
		}
		2.48 = new 208(0f, -2f);
		1247.6.12(2);
		1433 7 = new 1433(1455.2("menu-np", (1416)1, null), (1376)8, 1065.TopLeft, (1044)0, new 208(620f, 0f), 0.998f, 1304.110, 198.White, "np");
		7.48 = new 208(100f, 0f);
		7.3.Add(3);
		7.3.Add(4);
		if (!1304.110)
		{
			7.3.Add(5);
			7.3.Add(6);
		}
		1247.6.12(7);
		208 8 = new 208(0f, 20f);
		foreach (1371 9 in 1247.6.16("b"))
		{
			1433 10 = (1433)9;
			10.3.Clear();
			3 = new 1445(10.17, 10.7 + 8, 1662.33, 1662.33 + 400, (1046)0);
			4 = 3.2();
			4.6 = 10.7;
			4.9 = 1662.33 + 7600;
			4.10 = 1662.33 + 8000;
			10.3.Add(3);
			if (!1304.110)
			{
				10.3.Add(4);
			}
		}
	}

	// Token: 0x04003ECD RID: 16077
	private static readonly Stack<string> 3 = new Stack<string>();

	// Token: 0x04003ECE RID: 16078
	private static readonly Stack<string> 4 = new Stack<string>();

	// Token: 0x04003ECF RID: 16079
	private static List<1262> 5 = new List<1262>();

	// Token: 0x04003ED0 RID: 16080
	internal static readonly 1436 6 = new 1436(true);

	// Token: 0x04003ED1 RID: 16081
	private readonly 1433 7;

	// Token: 0x04003ED2 RID: 16082
	private readonly 1433 8;

	// Token: 0x04003ED3 RID: 16083
	private bool 9;

	// Token: 0x04003ED4 RID: 16084
	private static bool 10 = true;

	// Token: 0x02000BB5 RID: 2997
	[Serializable]
	public sealed class 1248
	{
		// Token: 0x04003ED5 RID: 16085
		public static readonly 1247.1248 instance = new 1247.1248();

		// Token: 0x04003ED6 RID: 16086
		public static Action<1371> action;

		// Token: 0x04003ED7 RID: 16087
		public static Action<1371> action2;
	}

	// Token: 0x02000BB6 RID: 2998
	public sealed class 1249
	{
		// Token: 0x06005296 RID: 21142 RVA: 0x0020840B File Offset: 0x0020660B
		internal void 1(object 1, EventArgs 2)
		{
			if (this.1.28 != null)
			{
				this.2.9 = false;
			}
		}

		// Token: 0x04003ED8 RID: 16088
		public 1697 1;

		// Token: 0x04003ED9 RID: 16089
		public 1247 2;
	}
}
