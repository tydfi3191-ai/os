using System;
using System.Collections.Generic;
using System.Globalization;

// Token: 0x0200051C RID: 1308
[276]
internal sealed class 2513 : IDisposable
{
	// Token: 0x1700025C RID: 604
	// (get) Token: 0x06002830 RID: 10288 RVA: 0x000CBEE4 File Offset: 0x000CA0E4
	internal static bool IsOpen
	{
		get
		{
			return 2513.3 != null && !2513.3.15 && 1662.78 == 1677.Play;
		}
	}

	// Token: 0x1700025D RID: 605
	// (get) Token: 0x06002831 RID: 10289 RVA: 0x000CBF03 File Offset: 0x000CA103
	internal static bool IsPending
	{
		get
		{
			return 2513.1 || 2513.IsOpen;
		}
	}

	// Token: 0x06002832 RID: 10290 RVA: 0x000CBF13 File Offset: 0x000CA113
	internal static void 1(bool 1)
	{
		2513.1 = true;
		2513.2 = 1;
		2630.17 = true;
	}

	// Token: 0x06002833 RID: 10291 RVA: 0x000CBF27 File Offset: 0x000CA127
	internal static bool 2()
	{
		bool result = 2513.1;
		2513.1 = false;
		return result;
	}

	// Token: 0x06002834 RID: 10292 RVA: 0x000CBF34 File Offset: 0x000CA134
	internal static void 3()
	{
		2630.17 = false;
	}

	// Token: 0x06002835 RID: 10293 RVA: 0x000CBF3C File Offset: 0x000CA13C
	internal 2513(2486 1, Action 2)
	{
		this.5 = 1;
		this.6 = 2;
		2513.3 = this;
		this.11();
		2528.2 = false;
		this.7 = new 1436(true);
		this.7.10 = false;
		1535.40((1082)1, new 1081(this.99), 1545.Dialog, (1559)0);
		1535.40((1082)0, new 1081(this.100), 1545.Dialog, (1559)0);
	}

	// Token: 0x06002836 RID: 10294 RVA: 0x000CC0B4 File Offset: 0x000CA2B4
	internal void 4()
	{
		if (this.15)
		{
			return;
		}
		if (this.12 == null)
		{
			this.12 = 2513.8();
		}
		this.6();
		this.8.RemoveAll((2528 1) => !1.11 || !2522.1.Contains(1));
		this.88();
		this.111();
		this.108();
		this.102();
		this.19();
		this.36();
		this.114();
		this.116();
		this.89();
	}

	// Token: 0x06002837 RID: 10295 RVA: 0x000CC144 File Offset: 0x000CA344
	internal void 5()
	{
		if (!this.15)
		{
			this.7.22();
		}
	}

	// Token: 0x06002838 RID: 10296 RVA: 0x000CC15C File Offset: 0x000CA35C
	private void 6()
	{
		if (this.5.CanControlReplay && this.5.ReplayEndTime > 0 && 1226.16 > this.5.ReplayEndTime - 1500)
		{
			this.5.137(0);
		}
	}

	// Token: 0x1700025E RID: 606
	// (get) Token: 0x06002839 RID: 10297 RVA: 0x000CC1A8 File Offset: 0x000CA3A8
	private static float WindowWidth
	{
		get
		{
			return 2528.WindowWidth;
		}
	}

	// Token: 0x1700025F RID: 607
	// (get) Token: 0x0600283A RID: 10298 RVA: 0x000CC1AF File Offset: 0x000CA3AF
	private 2511 Components
	{
		get
		{
			return 2511.Current;
		}
	}

	// Token: 0x0600283B RID: 10299 RVA: 0x000CC1B8 File Offset: 0x000CA3B8
	internal bool 7(200 1)
	{
		if (this.15)
		{
			return false;
		}
		if (this.122())
		{
			if (1 == 200.Escape || 1 == 200.Enter)
			{
				this.123();
			}
			return true;
		}
		bool flag = 1549.1;
		bool flag2 = 1549.3;
		if (1 <= 200.Down)
		{
			if (1 <= 200.Enter)
			{
				if (1 != 200.Back)
				{
					if (1 == 200.Tab)
					{
						this.17 = !this.17;
						return true;
					}
					if (1 != 200.Enter)
					{
						return true;
					}
					if (this.80 != null)
					{
						Action action = this.80.4;
						if (action != null)
						{
							action();
						}
						this.80 = null;
						return true;
					}
					return true;
				}
			}
			else
			{
				if (1 == 200.Escape)
				{
					if (this.80 != null)
					{
						this.80 = null;
					}
					else if (this.78.Count > 0)
					{
						this.78.Clear();
					}
					else if (flag2)
					{
						this.13();
					}
					else if (this.8.Count > 0)
					{
						this.8.Clear();
					}
					else
					{
						this.12();
					}
					return true;
				}
				if (1 == 200.Space)
				{
					return false;
				}
				if (1 - 200.Left > 3)
				{
					return true;
				}
				float num = flag2 ? 10f : 1f;
				this.74((1 == 200.Left) ? new 208(-num, 0f) : ((1 == 200.Right) ? new 208(num, 0f) : ((1 == 200.Up) ? new 208(0f, -num) : new 208(0f, num))));
				return true;
			}
		}
		else
		{
			if (1 > 200.Z)
			{
				if (1 != 200.Add)
				{
					if (1 != 200.Subtract)
					{
						switch (1)
						{
						case 200.OemPlus:
							goto IL_27A;
						case 200.OemComma:
							if (flag)
							{
								this.RotateBy(-90f);
								return true;
							}
							return true;
						case 200.OemMinus:
							break;
						case 200.OemPeriod:
							if (flag)
							{
								this.RotateBy(90f);
								return true;
							}
							return true;
						default:
							return true;
						}
					}
					this.73(0.952381f, "keys");
					return true;
				}
				IL_27A:
				this.73(1.05f, "keys");
				return true;
			}
			if (1 != 200.Delete)
			{
				switch (1)
				{
				case 200.A:
					if (flag)
					{
						this.76();
						return true;
					}
					return true;
				case 200.B:
				case 200.E:
				case 200.F:
				case 200.G:
					return true;
				case 200.C:
					if (flag)
					{
						this.Copy();
						return true;
					}
					return true;
				case 200.D:
					if (flag)
					{
						this.Clone();
						return true;
					}
					return true;
				case 200.H:
					if (flag)
					{
						this.72(true, true);
						return true;
					}
					return true;
				case 200.I:
					this.77();
					return true;
				case 200.J:
					if (flag)
					{
						this.72(false, true);
						return true;
					}
					return true;
				default:
					switch (1)
					{
					case 200.S:
						if (flag)
						{
							this.Save();
							return true;
						}
						return true;
					case 200.T:
					case 200.U:
					case 200.W:
						return true;
					case 200.V:
						if (flag)
						{
							this.Paste();
							return true;
						}
						return true;
					case 200.X:
						if (flag)
						{
							this.Cut();
							return true;
						}
						return true;
					case 200.Y:
						if (flag)
						{
							this.Redo();
							return true;
						}
						return true;
					case 200.Z:
						if (flag)
						{
							if (flag2)
							{
								this.Redo();
							}
							else
							{
								this.Undo();
							}
							return true;
						}
						return true;
					default:
						return true;
					}
					break;
				}
			}
		}
		this.75();
		return true;
	}

	// Token: 0x0600283C RID: 10300 RVA: 0x000CC4C4 File Offset: 0x000CA6C4
	private static Dictionary<string, 2513.2516> 8()
	{
		Dictionary<string, 2513.2516> dictionary = new Dictionary<string, 2513.2516>(StringComparer.OrdinalIgnoreCase);
		foreach (2528 <<EMPTY_NAME>> in 2522.1)
		{
			dictionary[<<EMPTY_NAME>>.3] = 2513.2516.1(<<EMPTY_NAME>>);
		}
		return dictionary;
	}

	// Token: 0x0600283D RID: 10301 RVA: 0x000CC530 File Offset: 0x000CA730
	private void 9(Dictionary<string, 2513.2516> 1)
	{
		2511 components = this.Components;
		foreach (2528 2 in 2522.1.ToArray())
		{
			if (!5.ContainsKey(2.3))
			{
				if (2.IsExtraInstance && components != null && components.7(2))
				{
					components.6(2);
					this.11.Add(2.3);
				}
				else
				{
					2.11 = false;
				}
			}
		}
		foreach (2513.2516 3 in 5.Values)
		{
			2528 4 = 2522.5(3.1);
			if (4 == null && components != null)
			{
				4 = components.5(3.1, 3.2);
				this.11.Remove(3.1);
			}
			if (4 != null)
			{
				4.17(3.16);
				3.2(4);
			}
		}
		2522.15();
		this.8.RemoveAll((2528 1) => !2522.1.Contains(1) || !1.11);
	}

	// Token: 0x0600283E RID: 10302 RVA: 0x000CC670 File Offset: 0x000CA870
	private void 10(string 1 = null)
	{
		if (1 != null && 1 == this.14 && 1662.33 - this.13 < 700)
		{
			this.13 = 1662.33;
			return;
		}
		this.14 = 1;
		this.13 = 1662.33;
		this.9.Add(2513.8());
		if (this.9.Count > 200)
		{
			this.9.RemoveAt(0);
		}
		this.10.Clear();
	}

	// Token: 0x0600283F RID: 10303 RVA: 0x000CC6F8 File Offset: 0x000CA8F8
	private void Undo()
	{
		if (this.9.Count == 0)
		{
			return;
		}
		this.14 = null;
		this.10.Add(2513.8());
		this.9(this.9[this.9.Count - 1]);
		this.9.RemoveAt(this.9.Count - 1);
	}

	// Token: 0x06002840 RID: 10304 RVA: 0x000CC760 File Offset: 0x000CA960
	private void Redo()
	{
		if (this.10.Count == 0)
		{
			return;
		}
		this.14 = null;
		this.9.Add(2513.8());
		this.9(this.10[this.10.Count - 1]);
		this.10.RemoveAt(this.10.Count - 1);
	}

	// Token: 0x17000260 RID: 608
	// (get) Token: 0x06002841 RID: 10305 RVA: 0x000CC7C8 File Offset: 0x000CA9C8
	private bool HasUnsavedChanges
	{
		get
		{
			if (this.12 == null)
			{
				return false;
			}
			Dictionary<string, 2513.2516> dictionary = 2513.8();
			if (dictionary.Count != this.12.Count)
			{
				return true;
			}
			foreach (KeyValuePair<string, 2513.2516> keyValuePair in dictionary)
			{
				2513.2516 <<EMPTY_NAME>>;
				if (!this.12.TryGetValue(keyValuePair.Key, out <<EMPTY_NAME>>) || !keyValuePair.Value.3(<<EMPTY_NAME>>))
				{
					return true;
				}
			}
			return false;
		}
	}

	// Token: 0x06002842 RID: 10306 RVA: 0x000CC864 File Offset: 0x000CAA64
	private void Copy()
	{
		if (this.8.Count == 0)
		{
			return;
		}
		2513.4.Clear();
		foreach (2528 <<EMPTY_NAME>> in this.8)
		{
			2513.4.Add(2513.2516.1(<<EMPTY_NAME>>));
		}
		this.115((this.8.Count == 1) ? ("Copied " + this.8[0].5) : ("Copied " + this.8.Count.ToString() + " elements"));
	}

	// Token: 0x06002843 RID: 10307 RVA: 0x000CC92C File Offset: 0x000CAB2C
	private void Cut()
	{
		if (this.8.Count == 0)
		{
			return;
		}
		this.Copy();
		this.75();
	}

	// Token: 0x06002844 RID: 10308 RVA: 0x000CC948 File Offset: 0x000CAB48
	private void Paste()
	{
		2511 components = this.Components;
		if (2513.4.Count == 0 || components == null)
		{
			return;
		}
		this.10(null);
		List<2528> list = new List<2528>();
		int num = 0;
		foreach (2513.2516 <<EMPTY_NAME>> in 2513.4)
		{
			if (components.2(<<EMPTY_NAME>>.2) == null)
			{
				num++;
			}
			else
			{
				2528 2 = components.4(<<EMPTY_NAME>>.2);
				if (2 != null)
				{
					2.17(<<EMPTY_NAME>>.16);
					<<EMPTY_NAME>>.2(2);
					2.11 = true;
					2.20 = 2513.79() + 1;
					list.Add(2);
					this.11.Remove(2.3);
				}
			}
		}
		2522.15();
		if (list.Count > 0)
		{
			this.8.Clear();
			this.8.AddRange(list);
		}
		if (num > 0)
		{
			this.115("osu!'s own elements can only be on screen once");
		}
	}

	// Token: 0x06002845 RID: 10309 RVA: 0x000CCA64 File Offset: 0x000CAC64
	private void Clone()
	{
		if (this.8.Count == 0)
		{
			return;
		}
		this.Copy();
		this.Paste();
	}

	// Token: 0x06002846 RID: 10310 RVA: 0x000CCA80 File Offset: 0x000CAC80
	private void Save()
	{
		foreach (string text in this.11)
		{
			2525.Remove(text);
		}
		this.11.Clear();
		foreach (2528 <<EMPTY_NAME>> in 2522.1)
		{
			2525.2(<<EMPTY_NAME>>);
		}
		2525.Save();
		this.12 = 2513.8();
		this.11();
		this.115("HUD layout saved");
	}

	// Token: 0x06002847 RID: 10311 RVA: 0x000CCB3C File Offset: 0x000CAD3C
	private void 11()
	{
		this.19 = 1304.166.GetValue();
		this.20 = 1304.3.GetValue();
	}

	// Token: 0x06002848 RID: 10312 RVA: 0x000CCB5E File Offset: 0x000CAD5E
	internal void 12()
	{
		if (this.HasUnsavedChanges || this.11.Count > 0)
		{
			this.Save();
		}
		this.Close();
	}

	// Token: 0x06002849 RID: 10313 RVA: 0x000CCB82 File Offset: 0x000CAD82
	internal void 13()
	{
		2525.5();
		1304.166.SetValue(this.19);
		1304.3.SetValue(this.20);
		this.Close();
	}

	// Token: 0x0600284A RID: 10314 RVA: 0x000CCBB0 File Offset: 0x000CADB0
	private void 14()
	{
		this.10(null);
		2511 components = this.Components;
		foreach (2528 <<EMPTY_NAME>> in 2522.1.ToArray())
		{
			if (<<EMPTY_NAME>>.IsExtraInstance && components != null && components.7(<<EMPTY_NAME>>))
			{
				components.6(<<EMPTY_NAME>>);
				this.11.Add(<<EMPTY_NAME>>.3);
			}
			else
			{
				<<EMPTY_NAME>>.7();
			}
		}
		2522.15();
		this.8.Clear();
	}

	// Token: 0x0600284B RID: 10315 RVA: 0x000CCC2D File Offset: 0x000CAE2D
	private void Close()
	{
		if (this.15)
		{
			return;
		}
		this.15 = true;
		this.123();
		2528.2 = false;
		2630.17 = false;
		this.15();
		this.6();
	}

	// Token: 0x0600284C RID: 10316 RVA: 0x000CCC62 File Offset: 0x000CAE62
	private void 15()
	{
		if (!this.16 && !2513.2)
		{
			2019.1 &= ~2023.Autoplay;
		}
		this.16 = true;
	}

	// Token: 0x0600284D RID: 10317 RVA: 0x000CCC8C File Offset: 0x000CAE8C
	public void Dispose()
	{
		2528.2 = false;
		2630.17 = false;
		this.15();
		this.124();
		1535.41((1082)1, new 1081(this.99), 1545.Dialog);
		1535.41((1082)0, new 1081(this.100), 1545.Dialog);
		this.7.Dispose();
		if (2513.3 == this)
		{
			2513.3 = null;
		}
	}

	// Token: 0x0600284E RID: 10318 RVA: 0x000CCCF0 File Offset: 0x000CAEF0
	internal static bool 16(string[] 1)
	{
		2513 2 = 2513.3;
		if (2 == null || 2.15 || !2513.IsOpen || 1 == null)
		{
			return false;
		}
		bool flag = false;
		foreach (string text in 1)
		{
			if (2533.6(text))
			{
				2.17(text);
				flag = true;
			}
		}
		if (!flag)
		{
			2.115("Only pictures can be added here");
		}
		return true;
	}

	// Token: 0x0600284F RID: 10319 RVA: 0x000CCD54 File Offset: 0x000CAF54
	private void 17(string 1)
	{
		2511 components = this.Components;
		if (components == null)
		{
			return;
		}
		string str;
		try
		{
			str = 2533.Import(1);
		}
		catch (Exception ex)
		{
			1338.4(ex, "importing a HUD image", 1341.Runtime);
			this.115("The picture could not be copied");
			return;
		}
		this.10(null);
		2528 2 = components.4("image");
		if (2 == null)
		{
			return;
		}
		2.15("image", str);
		2.11 = true;
		this.11.Remove(2.3);
		2513.70(2, this.82);
		this.8.Clear();
		this.8.Add(2);
		this.115("Added " + str);
	}

	// Token: 0x06002850 RID: 10320 RVA: 0x000CCE10 File Offset: 0x000CB010
	private 198 18(198 1)
	{
		if (this.30 < 1f)
		{
			return new 198(1.R, 1.G, 1.B, (byte)((float)1.A * this.30));
		}
		return 1;
	}

	// Token: 0x06002851 RID: 10321 RVA: 0x000CCE48 File Offset: 0x000CB048
	private void 19()
	{
		this.30 = ((this.38 == 2513.2520.Move || this.38 == 2513.2520.Scale || this.38 == 2513.2520.Resize || this.38 == 2513.2520.Rotate || this.38 == 2513.2520.Place) ? 0.25f : 1f);
		this.25 = new 1058(0f, 0f, 0f, 0f);
		this.26 = new 1058(0f, 0f, 0f, 0f);
		if (!this.17)
		{
			return;
		}
		bool flag = false;
		if (this.8.Count > 0)
		{
			1058 <<EMPTY_NAME>> = this.42();
			flag = (<<EMPTY_NAME>>.X + <<EMPTY_NAME>>.Width / 2f > 2513.WindowWidth / 2f);
		}
		float num = 16f;
		if (this.8.Count <= 0 || !flag)
		{
			this.25 = new 1058(0f, num, 160f, 480f - num);
			this.22();
		}
		if (this.8.Count > 0)
		{
			this.26 = (flag ? new 1058(0f, num, 178f, 480f - num) : new 1058(2513.WindowWidth - 178f, 0f, 178f, 480f));
			this.25();
		}
	}

	// Token: 0x06002852 RID: 10322 RVA: 0x000CCFAC File Offset: 0x000CB1AC
	private List<2513.2514> 20()
	{
		List<2513.2514> list = new List<2513.2514>();
		2511 components = this.Components;
		foreach (2528 <<EMPTY_NAME>> in 2522.1)
		{
			if (components == null || !components.7(<<EMPTY_NAME>>))
			{
				2528 captured = <<EMPTY_NAME>>;
				list.Add(new 2513.2514
				{
					1 = <<EMPTY_NAME>>.3,
					2 = <<EMPTY_NAME>>.5,
					3 = 2513.21(<<EMPTY_NAME>>.3),
					4 = (<<EMPTY_NAME>>.11 ? "on screen" : "hidden"),
					5 = this.8.Contains(<<EMPTY_NAME>>),
					6 = !<<EMPTY_NAME>>.IsDefault,
					8 = delegate()
					{
						if (!captured.11)
						{
							this.10(null);
							captured.11 = true;
						}
						return captured;
					}
				});
			}
		}
		foreach (2522.2523 2 in 2522.2)
		{
			if (2522.5(2.1) == null)
			{
				2522.2523 captured = 2;
				list.Add(new 2513.2514
				{
					1 = 2.1,
					2 = 2.2,
					3 = 2.3,
					4 = "off in the options",
					8 = delegate()
					{
						this.10(null);
						2528 6 = captured.4();
						if (6 != null)
						{
							6.11 = true;
						}
						return 6;
					}
				});
			}
		}
		if (components == null)
		{
			return list;
		}
		foreach (2511.2512 3 in components.3)
		{
			int num = 0;
			bool flag = false;
			bool flag2 = false;
			2528 4 = null;
			foreach (2528 5 in 2522.1)
			{
				if (string.Equals(5.4, 3.1, StringComparison.OrdinalIgnoreCase) && components.7(5) && 5.11)
				{
					num++;
					flag |= this.8.Contains(5);
					flag2 |= !5.IsDefault;
					4 = (4 ?? 5);
				}
			}
			if (!3.7 || num != 0 || 2486.14() == 2147.Osu)
			{
				2511.2512 captured = 3;
				list.Add(new 2513.2514
				{
					1 = "kind:" + 3.1,
					2 = 3.2 + ((num > 1) ? (" x" + num.ToString()) : string.Empty),
					3 = 3.3 + ((num > 0) ? " (drag onto the screen, or Ctrl+D, for another)" : string.Empty),
					4 = ((num == 0) ? "hidden" : "on screen"),
					5 = flag,
					6 = flag2,
					7 = 4,
					8 = delegate()
					{
						this.10(null);
						2528 6 = 2522.5(captured.1);
						bool flag3 = 6 != null && 6.11;
						2528 7 = components.4(captured.1);
						if (7 == null)
						{
							return null;
						}
						7.11 = true;
						this.11.Remove(7.3);
						if (flag3)
						{
							7.20 = 2513.79() + 1;
							2522.15();
							2513.70(7, new 208(2513.WindowWidth / 2f, 240f));
							if (!7.13)
							{
								2513.71(7);
							}
						}
						return 7;
					}
				});
			}
		}
		return list;
	}

	// Token: 0x06002853 RID: 10323 RVA: 0x000CD3A4 File Offset: 0x000CB5A4
	private static string 21(string 1)
	{
		if (1 != null)
		{
			switch (1.Length)
			{
			case 4:
			{
				char c = 1[0];
				if (c != 'k')
				{
					if (c == 'm')
					{
						if (1 == "mods")
						{
							return "Icons of the mods in use";
						}
					}
				}
				else if (1 == "keys")
				{
					return "Key overlay";
				}
				break;
			}
			case 5:
			{
				char c = 1[0];
				if (c != 'c')
				{
					if (c != 'f')
					{
						if (c == 's')
						{
							if (1 == "score")
							{
								return "Total score";
							}
						}
					}
					else if (1 == "frame")
					{
						return "The skin's frame around the playfield";
					}
				}
				else if (1 == "combo")
				{
					return "Current combo";
				}
				break;
			}
			case 6:
				if (1 == "health")
				{
					return "Health bar";
				}
				break;
			case 8:
			{
				char c = 1[0];
				if (c != 'a')
				{
					if (c != 'h')
					{
						if (c == 'p')
						{
							if (1 == "progress")
							{
								return "Song progress: a pie or a bar";
							}
						}
					}
					else if (1 == "hiterror")
					{
						return "Hit timings on a bar, or in colours";
					}
				}
				else if (1 == "accuracy")
				{
					return "Accuracy (so far, best or worst)";
				}
				break;
			}
			}
		}
		return string.Empty;
	}

	// Token: 0x06002854 RID: 10324 RVA: 0x000CD510 File Offset: 0x000CB710
	private void 22()
	{
		1058 <<EMPTY_NAME>> = this.25;
		this.Box("components.back", new 208(<<EMPTY_NAME>>.X, <<EMPTY_NAME>>.Y), 2513.117(<<EMPTY_NAME>>), this.18(2513.63), 0.88f, 1065.TopLeft, 0f, null);
		this.93(<<EMPTY_NAME>>, 1);
		1058 2 = new 1058(<<EMPTY_NAME>>.X, <<EMPTY_NAME>>.Y + 2f, <<EMPTY_NAME>>.Width, <<EMPTY_NAME>>.Height - 2f);
		if (this.94 != 0 && 2513.92(2, this.82))
		{
			this.27 -= (float)this.94 * 13f * 3f;
			this.94 = 0;
		}
		float num = 2.Y + 8f - this.27;
		float num2 = num;
		1058 3 = new 1058(<<EMPTY_NAME>>.X, num - 6f, <<EMPTY_NAME>>.Width, 12f);
		this.Text("components.title", (this.31 ? "+ " : "- ") + "Elements", 10f, new 208(<<EMPTY_NAME>>.X + 6f, num), this.18(2513.69), 0.884f, 1065.CentreLeft, new 1058?(2), false, 0f);
		if (this.97("components.header", 3, 1) && 2513.92(2, this.82))
		{
			this.31 = !this.31;
		}
		num += 13f;
		if (!this.31)
		{
			foreach (2513.2514 4 in this.20())
			{
				num = this.24(4, <<EMPTY_NAME>>, 2, num, 0.88f);
			}
			num += 4f;
			string text = "Click to select or show, drag onto the screen for another. Right-click the screen for more. Tab hides the panels.";
			1452 5 = this.Text("components.hint", text, 8f, new 208(<<EMPTY_NAME>>.X + 6f, num), this.18(2513.70), 0.884f, 1065.TopLeft, new 1058?(2), false, <<EMPTY_NAME>>.Width - 12f);
			num += 5.GetTextSize().Y + 4f;
		}
		float num3 = num - num2 + 8f;
		this.27 = Math.Max(0f, Math.Min(this.27, Math.Max(0f, num3 - 2.Height)));
	}

	// Token: 0x06002855 RID: 10325 RVA: 0x000CD7A4 File Offset: 0x000CB9A4
	private void 23(2528 1)
	{
		1058 2 = 1.41();
		bool flag = 2.X < this.25.X + this.25.Width && 2.X + 2.Width > this.25.X && 2.Y < this.25.Y + this.25.Height && 2.Y + 2.Height > this.25.Y;
		2511 components = this.Components;
		if (!flag && (components == null || !components.7(1)))
		{
			return;
		}
		2513.70(1, new 208(2513.WindowWidth / 2f, 240f));
		if (!1.13)
		{
			2513.71(1);
		}
	}

	// Token: 0x06002856 RID: 10326 RVA: 0x000CD86C File Offset: 0x000CBA6C
	private float 24(2513.2514 1, 1058 2, 1058 3, float 4, float 5)
	{
		1058 6 = new 1058(2.X, 4 - 6.5f, 2.Width, 13f);
		string b = "component:" + 1.1;
		if (4 + 13f > 3.Y && 4 - 13f < 3.Y + 3.Height)
		{
			bool flag = this.96(6, 1) && 2513.92(3, this.82);
			bool flag2 = 1.4 == "on screen";
			198 7 = 1.5 ? 2513.68 : ((flag || flag2) ? 198.White : 2513.70);
			string text = (1.5 ? "> " : "   ") + 1.2 + (flag2 ? string.Empty : ("  (" + 1.4 + ")")) + (1.6 ? "  *" : string.Empty);
			this.Text("components.row." + 1.1, text, 10.5f, new 208(2.X + 6f, 4), this.18(7), 5 + 0.002f, 1065.CentreLeft, new 1058?(3), false, 0f);
			if (flag)
			{
				this.113(1.3);
			}
			if (flag && this.84 && !this.91)
			{
				this.91 = true;
				this.92 = b;
				this.32 = 1.1;
				this.43 = this.82;
			}
		}
		if (this.92 == b)
		{
			if (this.83 && !2513.92(2, this.82) && 208.Distance(this.82, this.43) > 4f)
			{
				this.92 = null;
				2528 8 = 1.8();
				if (8 != null)
				{
					this.68(8);
				}
			}
			else if (this.85 && 2513.92(6, this.82))
			{
				2528 9 = 1.7 ?? 1.8();
				if (9 != null)
				{
					if (1.7 == null)
					{
						this.23(9);
					}
					this.8.Clear();
					this.8.Add(9);
				}
			}
		}
		return 4 + 13f;
	}

	// Token: 0x06002857 RID: 10327 RVA: 0x000CDAD4 File Offset: 0x000CBCD4
	private void 25()
	{
		1058 <<EMPTY_NAME>> = this.26;
		this.Box("settings.back", new 208(<<EMPTY_NAME>>.X, <<EMPTY_NAME>>.Y), 2513.117(<<EMPTY_NAME>>), this.18(2513.63), 0.89f, 1065.TopLeft, 0f, null);
		this.93(<<EMPTY_NAME>>, 1);
		1058 2 = new 1058(<<EMPTY_NAME>>.X, <<EMPTY_NAME>>.Y + 4f, <<EMPTY_NAME>>.Width, <<EMPTY_NAME>>.Height - 8f);
		if (this.94 != 0 && 2513.92(<<EMPTY_NAME>>, this.82))
		{
			this.28 -= (float)this.94 * 30f;
			this.94 = 0;
		}
		this.28 = Math.Max(0f, Math.Min(this.28, Math.Max(0f, this.29 - 2.Height)));
		float num = 2.Y - this.28;
		float num2 = <<EMPTY_NAME>>.X + 8f;
		float num3 = <<EMPTY_NAME>>.Width - 16f;
		foreach (2528 3 in this.8.ToArray())
		{
			num = this.26(3, num2, num, num3, 2);
			num += 8f;
		}
		this.29 = num + this.28 - 2.Y;
		if (this.29 > 2.Height)
		{
			float num4 = 2.Height * 2.Height / this.29;
			float num5 = 2.Y + (2.Height - num4) * this.28 / Math.Max(1f, this.29 - 2.Height);
			this.Box("settings.scrollbar", new 208(<<EMPTY_NAME>>.X + <<EMPTY_NAME>>.Width - 3f, num5), new 208(2f, num4), this.18(new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 60)), 0.894f, 1065.TopLeft, 0f, null);
		}
	}

	// Token: 0x06002858 RID: 10328 RVA: 0x000CDD00 File Offset: 0x000CBF00
	private float 26(2528 1, float 2, float 3, float 4, 1058 5)
	{
		string str = "settings." + 1.3 + ".";
		this.Text(str + "title", 1.5, 10.5f, new 208(2 - 2f, 3 + 7f), this.18(2513.68), 0.9f, 1065.CentreLeft, new 1058?(5), false, 0f);
		3 += 16f;
		foreach (2530 6 in 2513.27(1))
		{
			3 += this.31(1, 6, str, 2, 3, 4, 5);
		}
		bool flag = false;
		foreach (2530 7 in 1.25)
		{
			if (7.16 == null || 7.16())
			{
				if (!flag)
				{
					3 += 6f;
					flag = true;
				}
				3 += this.31(1, 7, str, 2, 3, 4, 5);
			}
		}
		return 3;
	}

	// Token: 0x06002859 RID: 10329 RVA: 0x000CDE44 File Offset: 0x000CC044
	private static List<2530> 27(2528 1)
	{
		List<2530> list = new List<2530>();
		string[] array = new string[]
		{
			"closest",
			"TopLeft",
			"TopCentre",
			"TopRight",
			"CentreLeft",
			"Centre",
			"CentreRight",
			"BottomLeft",
			"BottomCentre",
			"BottomRight"
		};
		string[] array2 = new string[10];
		array2[0] = "Closest";
		Array.Copy(2513.37, 0, array2, 1, 9);
		2530 2 = 2530.3("@anchor", "Anchor", "The point of the window the element is placed from. Closest: the nearest one, as it is moved.", "closest", array, array2);
		2.17 = delegate()
		{
			if (!9.13)
			{
				return "closest";
			}
			return 9.8.ToString();
		};
		2.18 = delegate(string 1)
		{
			if (1 == "closest")
			{
				9.13 = false;
				2513.71(9);
				return;
			}
			2509 10;
			if (Enum.TryParse<2509>(1, out 10))
			{
				9.13 = true;
				9.43(10);
			}
		};
		list.Add(2);
		string[] array3 = new string[]
		{
			"Default",
			"TopLeft",
			"TopCentre",
			"TopRight",
			"CentreLeft",
			"Centre",
			"CentreRight",
			"BottomLeft",
			"BottomCentre",
			"BottomRight"
		};
		string[] array4 = new string[10];
		array4[0] = "osu!'s own point";
		Array.Copy(2513.37, 0, array4, 1, 9);
		2530 3 = 2530.3("@origin", "Origin", "The point of the element placed at its position, that it turns and scales around and grows away from.", "Default", array3, array4);
		3.17 = (() => 9.14.ToString());
		3.18 = delegate(string 1)
		{
			2527 10;
			if (Enum.TryParse<2527>(1, out 10))
			{
				9.42(10);
			}
		};
		list.Add(3);
		2530 4 = 2530.2("@scale", "Scale", "How big the element is.", 1f, 0.1f, 4f, 0.01f, "0.00");
		4.17 = (() => 2530.8(9.10));
		4.18 = delegate(string 1)
		{
			9.10 = 2513.67(2513.28(1, 1f));
		};
		list.Add(4);
		2530 5 = 2530.2("@rotation", "Rotation", "Degrees, clockwise.", 0f, -180f, 180f, 1f, "0");
		5.17 = (() => 2530.8(9.15));
		5.18 = delegate(string 1)
		{
			9.15 = 2528.44(2513.28(1, 0f));
		};
		list.Add(5);
		2530 6 = 2530.2("@opacity", "Opacity", "How visible the element is.", 1f, 0f, 1f, 0.01f, "0.##");
		6.10 = true;
		6.17 = (() => 2530.8(9.18));
		6.18 = delegate(string 1)
		{
			9.18 = Math.Max(0f, Math.Min(1f, 2513.28(1, 1f)));
		};
		list.Add(6);
		2530 7 = 2530.Colour("@colour", "Colour", "A colour the element is tinted with (white keeps its own).", 198.White);
		7.17 = (() => 2530.9(9.19));
		7.18 = delegate(string 1)
		{
			198 10;
			if (2530.10(1, out 10))
			{
				9.19 = 10;
			}
		};
		list.Add(7);
		2530 8 = 2530.3("@interface", "Without the interface", "What the element does when the in-game interface is turned off (Shift+Tab).", "Follow", new string[]
		{
			"Follow",
			"Show",
			"Hide"
		}, new string[]
		{
			"As osu! does it",
			"Always shown",
			"Hidden with it"
		});
		8.17 = (() => 9.12.ToString());
		8.18 = delegate(string 1)
		{
			2524 10;
			if (Enum.TryParse<2524>(1, out 10))
			{
				9.12 = 10;
			}
		};
		list.Add(8);
		return list;
	}

	// Token: 0x0600285A RID: 10330 RVA: 0x000CE1E0 File Offset: 0x000CC3E0
	private static float 28(string 1, float 2)
	{
		float result;
		if (!float.TryParse(1, NumberStyles.Float, CultureInfo.InvariantCulture, out result))
		{
			return 2;
		}
		return result;
	}

	// Token: 0x0600285B RID: 10331 RVA: 0x000CE204 File Offset: 0x000CC404
	private string 29(2528 1, 2530 2)
	{
		if (1.9(2.1) != 2)
		{
			return 2.17();
		}
		return 1.10(2.1);
	}

	// Token: 0x0600285C RID: 10332 RVA: 0x000CE230 File Offset: 0x000CC430
	private void 30(2528 1, 2530 2, string 3, string 4)
	{
		if (this.29(1, 2) == 2.7(3))
		{
			return;
		}
		this.10(4);
		if (1.9(2.1) == 2)
		{
			1.15(2.1, 3);
			return;
		}
		2.18(2.7(3));
	}

	// Token: 0x0600285D RID: 10333 RVA: 0x000CE28C File Offset: 0x000CC48C
	private float 31(2528 1, 2530 2, string 3, float 4, float 5, float 6, 1058 7)
	{
		string key = 3 + 2.1;
		string a = this.29(10, 2);
		bool flag = 2.7(a) != 2.5;
		float num;
		switch (2.4)
		{
		case 2531.Toggle:
			num = 15f;
			goto IL_A6;
		case 2531.Number:
			num = 25f;
			goto IL_A6;
		case 2531.Colour:
			num = 40f;
			goto IL_A6;
		}
		num = 28f;
		IL_A6:
		1058 8 = new 1058(4 - 2f, 5, 6 + 4f, num);
		bool flag2 = 5 + num > 7.Y && 5 < 7.Y + 7.Height;
		if (flag2 && this.96(8, 1) && 2513.92(7, this.82))
		{
			this.113(2.3);
		}
		float num2 = 4;
		if (flag)
		{
			1058 9 = new 1058(4 - 1f, 5 + 1f, 9f, 10f);
			bool flag3 = 2513.92(9, this.82);
			this.90(key + ".revert", 1048.undo, 6f, new 208(4 + 3.5f, 5 + 6f), this.18(flag3 ? 198.White : 2513.67), 0.90199995f, new 1058?(7));
			if (flag2 && this.97(key + ".revert", 9, 1) && 2513.92(7, this.82))
			{
				this.30(10, 2, 2.5, null);
				return num;
			}
			num2 += 10f;
		}
		this.Text(key + ".label", 2.2, 9.5f, new 208(num2, 5 + 6f), this.18(2513.69), 0.90199995f, 1065.CentreLeft, new 1058?(7), false, 0f);
		if (!flag2)
		{
			return num;
		}
		switch (2.4)
		{
		case 2531.Toggle:
			this.32(10, 2, key, a == "1", 4, 5, 6, 7, 8);
			break;
		case 2531.Number:
			this.33(10, 2, key, 2513.28(a, 0f), 4, 5, 6, 7);
			break;
		case 2531.Choice:
			this.34(10, 2, key, a, 4, 5, 6, 7);
			break;
		case 2531.Colour:
			this.35(10, 2, key, a, 4, 5, 6, 7);
			break;
		default:
			this.119(key + ".text", a, new 208(4, 5 + 13f), 6, new 1058?(7), delegate(string 1)
			{
				this.30(10, 2, 1, key);
			}, 2.19);
			break;
		}
		return num;
	}

	// Token: 0x0600285E RID: 10334 RVA: 0x000CE60C File Offset: 0x000CC80C
	private void 32(2528 1, 2530 2, string 3, bool 4, float 5, float 6, float 7, 1058 8, 1058 9)
	{
		208 10 = new 208(5 + 7 - 10f, 6 + 1.5f);
		this.Box(3 + ".box", 10, new 208(10f, 10f), this.18(4 ? 2513.67 : 2513.65), 0.902f, 1065.TopLeft, 0f, new 1058?(8));
		if (4)
		{
			this.90(3 + ".tick", 1048.check, 6.5f, 10 + new 208(5f, 5f), this.18(new 198(20, 20, 20)), 0.903f, new 1058?(8));
		}
		if (this.97(3 + ".toggle", 9, 1) && 2513.92(8, this.82))
		{
			this.30(1, 2, 4 ? "0" : "1", null);
		}
	}

	// Token: 0x0600285F RID: 10335 RVA: 0x000CE710 File Offset: 0x000CC910
	private void 33(2528 1, 2530 2, string 3, float 4, float 5, float 6, float 7, 1058 8)
	{
		string text = 2.Display(4) + ((2.1 == "@scale") ? "x" : ((2.1 == "@rotation") ? "°" : string.Empty));
		this.Text(3 + ".value", text, 8f, new 208(5 + 7, 6 + 6f), this.18(2513.67), 0.902f, 1065.CentreRight, new 1058?(8), false, 0f);
		1058 9 = new 1058(5, 6 + 14f, 7, 8f);
		float num = Math.Max(0.0001f, 2.7 - 2.6);
		float num2 = Math.Max(0f, Math.Min(1f, (4 - 2.6) / num));
		this.Box(3 + ".track", new 208(5, 6 + 17f), new 208(7, 2f), this.18(2513.65), 0.902f, 1065.TopLeft, 0f, new 1058?(8));
		this.Box(3 + ".fill", new 208(5, 6 + 17f), new 208(7 * num2, 2f), this.18(2513.67), 0.903f, 1065.TopLeft, 0f, new 1058?(8));
		bool flag = this.98(3 + ".slider");
		this.Box(3 + ".knob", new 208(5 + 7 * num2, 6 + 18f), new 208(flag ? 5f : 4f, 8f), this.18((flag || 2513.92(9, this.82)) ? 198.White : 2513.67), 0.904f, 1065.Centre, 0f, new 1058?(8));
		this.97(3 + ".slider", 9, 1);
		if (this.98(3 + ".slider"))
		{
			float num3 = 2.6 + Math.Max(0f, Math.Min(1f, (this.82.X - 5) / 7)) * num;
			this.30(1, 2, 2530.8(num3), 3);
		}
	}

	// Token: 0x06002860 RID: 10336 RVA: 0x000CE980 File Offset: 0x000CCB80
	private void 34(2528 1, 2530 2, string 3, string 4, float 5, float 6, float 7, 1058 8)
	{
		1058 9 = new 1058(5, 6 + 13f, 7, 12f);
		string b = "choice:" + 3;
		bool flag = this.78.Count > 0 && this.78[0].1 == b;
		bool flag2 = 2513.92(9, this.82) && !this.94(this.82, 1);
		this.Box(3 + ".choice", new 208(9.X, 9.Y), 2513.117(9), this.18((flag || flag2) ? 2513.66 : 2513.65), 0.902f, 1065.TopLeft, 0f, new 1058?(8));
		this.Text(3 + ".current", 2.6(4), 8f, new 208(9.X + 4f, 9.Y + 6f), this.18(198.White), 0.903f, 1065.CentreLeft, new 1058?(8), false, 0f);
		this.90(3 + ".caret", 1048.caret_down, 7f, new 208(9.X + 9.Width - 6f, 9.Y + 6f), this.18(2513.70), 0.903f, new 1058?(8));
		if (this.97(3 + ".open", 9, 1) && 2513.92(8, this.82))
		{
			if (flag)
			{
				this.78.Clear();
				return;
			}
			this.107(b, new 208(9.X, 9.Y + 9.Height + 1f), delegate
			{
				List<2513.2517> list = new List<2513.2517>();
				string[] array = 2.4();
				string[] array2 = 2.5();
				string b2 = this.29(1, 2);
				if (array.Length == 0)
				{
					list.Add(new 2513.2517
					{
						1 = ((2.1 == "image") ? "No pictures yet: drop one on the window" : "Nothing to choose"),
						4 = false
					});
				}
				for (int i = 0; i < array.Length; i++)
				{
					string chosen = array[i];
					list.Add(new 2513.2517
					{
						1 = ((i < array2.Length) ? array2[i] : chosen),
						5 = ((string.Equals(chosen, b2, StringComparison.OrdinalIgnoreCase) > false) ? 1 : 0),
						3 = delegate()
						{
							this.30(1, 2, chosen, null);
						}
					});
				}
				return list;
			}, 9.Width);
		}
	}

	// Token: 0x06002861 RID: 10337 RVA: 0x000CEB8C File Offset: 0x000CCD8C
	private void 35(2528 1, 2530 2, string 3, string 4, float 5, float 6, float 7, 1058 8)
	{
		198 9;
		2530.10(4, out 9);
		this.Box(3 + ".preview", new 208(5 + 7 - 10f, 6 + 1.5f), new 208(10f, 10f), this.18(9), 0.902f, 1065.TopLeft, 0f, new 1058?(8));
		for (int i = 0; i < 2513.24.Length; i++)
		{
			208 10 = new 208(5 + (float)(i % 8) * 11f, 6 + 14f + (float)(i / 8) * 11f);
			1058 11 = new 1058(10.X, 10.Y, 9f, 9f);
			if (2513.24[i] == 9)
			{
				this.Box(3 + ".chosen", 10 - new 208(1f, 1f), new 208(11f, 11f), this.18(2513.67), 0.902f, 1065.TopLeft, 0f, new 1058?(8));
			}
			this.Box(3 + ".swatch" + i.ToString(), 10, new 208(9f, 9f), this.18(2513.24[i]), 0.903f, 1065.TopLeft, 0f, new 1058?(8));
			if (this.97(3 + ".swatch" + i.ToString(), 11, 1) && 2513.92(8, this.82))
			{
				this.30(12, 2, 2530.9(2513.24[i]), null);
			}
		}
		float num = 5 + 88f + 4f;
		this.119(3 + ".hex", 4, new 208(num, 6 + 16f), Math.Max(30f, 5 + 7 - num), new 1058?(8), delegate(string 1)
		{
			198 13;
			if (2530.10(1, out 13))
			{
				this.30(12, 2, 2530.9(13), 3);
			}
		}, 7);
	}

	// Token: 0x06002862 RID: 10338 RVA: 0x000CEDE8 File Offset: 0x000CCFE8
	private void 36()
	{
		bool flag = !this.94(this.82, 0);
		this.39 = ((this.38 == 2513.2520.None && flag && this.80 == null) ? this.40(this.82, null) : null);
		this.44();
		bool flag2 = this.8.Count > 0;
		1058 <<EMPTY_NAME>> = flag2 ? this.42() : new 1058(0f, 0f, 0f, 0f);
		bool flag3 = flag2 && (this.38 == 2513.2520.None || this.38 == 2513.2520.Pending || this.38 == 2513.2520.Scale || this.38 == 2513.2520.Resize || this.38 == 2513.2520.Rotate);
		if (flag2)
		{
			this.45(<<EMPTY_NAME>>, flag3);
			this.49();
		}
		switch (this.38)
		{
		case 2513.2520.None:
			if (flag && this.80 == null)
			{
				this.51(<<EMPTY_NAME>>, flag3);
			}
			break;
		case 2513.2520.Pending:
			if (!this.83)
			{
				this.52();
			}
			else if (208.Distance(this.82, this.43) > 3f)
			{
				this.55();
			}
			break;
		case 2513.2520.Move:
			this.56();
			break;
		case 2513.2520.Box:
			this.59();
			break;
		case 2513.2520.Scale:
			this.62();
			break;
		case 2513.2520.Resize:
			this.63();
			break;
		case 2513.2520.Rotate:
			this.64();
			break;
		case 2513.2520.Place:
			this.69();
			break;
		}
		this.50();
	}

	// Token: 0x06002863 RID: 10339 RVA: 0x000CEF58 File Offset: 0x000CD158
	private static bool 37(2528 1)
	{
		return 1.11;
	}

	// Token: 0x06002864 RID: 10340 RVA: 0x000CEF60 File Offset: 0x000CD160
	private static bool 38(2528 1, 208 2, out float 3)
	{
		1058 naturalBounds = 1.NaturalBounds;
		float num = Math.Max(0.01f, 1.10);
		3 = naturalBounds.Width * naturalBounds.Height * num * num;
		208 4 = 2513.39(1, 2);
		float num2 = 2f / num;
		if (4.X < naturalBounds.X - num2 || 4.X > naturalBounds.X + naturalBounds.Width + num2 || 4.Y < naturalBounds.Y - num2 || 4.Y > naturalBounds.Y + naturalBounds.Height + num2)
		{
			return false;
		}
		if (1.3 == "frame")
		{
			float num3 = 10f / num;
			return 4.X <= naturalBounds.X + num3 || 4.X >= naturalBounds.X + naturalBounds.Width - num3 || 4.Y <= naturalBounds.Y + num3 || 4.Y >= naturalBounds.Y + naturalBounds.Height - num3;
		}
		return true;
	}

	// Token: 0x06002865 RID: 10341 RVA: 0x000CF06C File Offset: 0x000CD26C
	private static 208 39(2528 1, 208 2)
	{
		float windowWidth = 2513.WindowWidth;
		208 3 = 2 - 1.36(windowWidth, 480f);
		if (1.15 != 0f)
		{
			double num = (double)(-(double)1.15) * 3.141592653589793 / 180.0;
			float num2 = (float)Math.Cos(num);
			float num3 = (float)Math.Sin(num);
			3 = new 208(3.X * num2 - 3.Y * num3, 3.X * num3 + 3.Y * num2);
		}
		float num4 = Math.Max(0.01f, 1.10);
		3.X /= (1.16 ? (-num4) : num4);
		3.Y /= (1.17 ? (-num4) : num4);
		return 1.35(windowWidth, 480f) + 3;
	}

	// Token: 0x06002866 RID: 10342 RVA: 0x000CF14C File Offset: 0x000CD34C
	private 2528 40(208 1, 2528 2 = null)
	{
		List<KeyValuePair<2528, float>> list = 2513.41(3);
		if (list.Count == 0)
		{
			return null;
		}
		if (2 != null)
		{
			int num = list.FindIndex((KeyValuePair<2528, float> 1) => 1.Key == 2);
			return list[(num + 1) % list.Count].Key;
		}
		foreach (KeyValuePair<2528, float> keyValuePair in list)
		{
			if (this.8.Contains(keyValuePair.Key))
			{
				return keyValuePair.Key;
			}
		}
		return list[0].Key;
	}

	// Token: 0x06002867 RID: 10343 RVA: 0x000CF218 File Offset: 0x000CD418
	private static List<KeyValuePair<2528, float>> 41(208 1)
	{
		List<KeyValuePair<2528, float>> list = new List<KeyValuePair<2528, float>>();
		foreach (2528 key in 2522.1)
		{
			float value;
			if (2513.37(key) && 2513.38(key, 3, out value))
			{
				list.Add(new KeyValuePair<2528, float>(key, value));
			}
		}
		list.Sort((KeyValuePair<2528, float> 1, KeyValuePair<2528, float> 2) => 1.Value.CompareTo(2.Value));
		return list;
	}

	// Token: 0x06002868 RID: 10344 RVA: 0x000CF2B0 File Offset: 0x000CD4B0
	private 1058 42()
	{
		return 2513.43(this.8);
	}

	// Token: 0x06002869 RID: 10345 RVA: 0x000CF2C0 File Offset: 0x000CD4C0
	private static 1058 43(List<2528> 1)
	{
		bool flag = false;
		float num = 0f;
		float num2 = 0f;
		float num3 = 0f;
		float num4 = 0f;
		foreach (2528 2 in 1)
		{
			1058 3 = 2.41();
			num = (flag ? Math.Min(num, 3.X) : 3.X);
			num2 = (flag ? Math.Min(num2, 3.Y) : 3.Y);
			num3 = (flag ? Math.Max(num3, 3.X + 3.Width) : (3.X + 3.Width));
			num4 = (flag ? Math.Max(num4, 3.Y + 3.Height) : (3.Y + 3.Height));
			flag = true;
		}
		return new 1058(num, num2, num3 - num, num4 - num2);
	}

	// Token: 0x0600286A RID: 10346 RVA: 0x000CF3CC File Offset: 0x000CD5CC
	private static 208 Centre(1058 1)
	{
		return new 208(1.X + 1.Width / 2f, 1.Y + 1.Height / 2f);
	}

	// Token: 0x0600286B RID: 10347 RVA: 0x000CF3FC File Offset: 0x000CD5FC
	private void 44()
	{
		int num = 0;
		foreach (2528 <<EMPTY_NAME>> in 2522.1)
		{
			if (2513.37(<<EMPTY_NAME>>))
			{
				bool flag = this.8.Contains(<<EMPTY_NAME>>);
				bool flag2 = <<EMPTY_NAME>> == this.39;
				208[] array = <<EMPTY_NAME>>.40();
				198 2 = flag ? 2513.67 : (flag2 ? 198.White : new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 110));
				float num2 = flag ? 1.2f : 0.7f;
				string str = "outline." + <<EMPTY_NAME>>.3 + ".";
				for (int i = 0; i < 4; i++)
				{
					this.Line(str + i.ToString(), array[i], array[(i + 1) % 4], num2, 2, 0.8f);
				}
				if (flag || flag2)
				{
					208 3 = (array[0] + array[2]) / 2f;
					208 4 = array[1] - array[0];
					208 5 = array[3] - array[0];
					this.Box(str + "fill", 3, new 208(4.Length(), 5.Length()), flag ? new 198(byte.MaxValue, 204, 51, 40) : new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, flag2 ? 36 : 14), 0.795f, 1065.Centre, (float)Math.Atan2((double)4.Y, (double)4.X), null);
					1058 6 = <<EMPTY_NAME>>.41();
					string text = <<EMPTY_NAME>>.5 + (2522.12(<<EMPTY_NAME>>) ? " - placeholder, applies to skins that draw one" : string.Empty);
					this.Text(str + "label", text, 9f, new 208(6.X, Math.Max(10f, 6.Y - 1f)), 198.White, 0.811f, 1065.BottomLeft, null, false, 0f);
				}
				num++;
			}
		}
	}

	// Token: 0x0600286C RID: 10348 RVA: 0x000CF680 File Offset: 0x000CD880
	private void 45(1058 1, bool 2)
	{
		1058 3 = new 1058(9.X - 3f, 9.Y - 3f, 9.Width + 6f, 9.Height + 6f);
		208[] array = new 208[]
		{
			new 208(3.X, 3.Y),
			new 208(3.X + 3.Width, 3.Y),
			new 208(3.X + 3.Width, 3.Y + 3.Height),
			new 208(3.X, 3.Y + 3.Height)
		};
		for (int i = 0; i < 4; i++)
		{
			this.Line("selection.edge" + i.ToString(), array[i], array[(i + 1) % 4], 1.5f, 2513.67, 0.82f);
		}
		string text = this.8.Count.ToString(1662.18);
		208 4 = this.91(text, 7.5f, false) + new 208(4f, 1f);
		this.Box("selection.count", new 208(3.X, 3.Y - 4.Y), 4, 2513.67, 0.821f, 1065.TopLeft, 0f, null);
		this.Text("selection.countText", text, 7.5f, new 208(3.X + 2f, 3.Y - 4.Y / 2f), new 198(20, 20, 20), 0.822f, 1065.CentreLeft, null, false, 0f);
		if (!2)
		{
			return;
		}
		bool flag = this.8.TrueForAll((2528 1) => 1.21);
		bool flag2 = this.8.TrueForAll((2528 1) => 1.22);
		for (int j = 0; j < 8; j++)
		{
			bool flag3 = j % 2 == 0;
			bool flag4 = j == 1 || j == 5;
			if (flag3 || !(flag4 ? (!flag2) : (!flag)))
			{
				208 5 = 2513.46(3, j);
				bool flag5 = 208.Distance(5, this.82) <= 5f;
				this.Box("handle" + j.ToString(), 5, new 208(5f, 5f), flag5 ? 198.White : 2513.67, 0.83f, 1065.Centre, 0f, null);
				if (flag3)
				{
					208 6 = 2513.47(3, j);
					bool flag6 = 208.Distance(6, this.82) <= 5f;
					this.90("rotate" + j.ToString(), 1048.repeat, 6f, 6, flag6 ? 198.White : 2513.67, 0.83f, null);
				}
			}
		}
		208 7 = 2513.48(3);
		1048[] array2 = new 1048[]
		{
			1048.undo,
			1048.repeat,
			1048.arrows_h,
			1048.arrows_v
		};
		string[] array3 = new string[]
		{
			"Turn 90 degrees anticlockwise (Ctrl+,)",
			"Turn 90 degrees clockwise (Ctrl+.)",
			"Flip horizontally (Ctrl+H flips across the screen)",
			"Flip vertically (Ctrl+J flips across the screen)"
		};
		for (int k = 0; k < 4; k++)
		{
			1058 8 = new 1058(7.X + (float)k * 14f, 7.Y, 12f, 12f);
			bool flag7 = 2513.92(8, this.82) && !this.94(this.82, 0);
			this.Box("button" + k.ToString(), new 208(8.X, 8.Y), new 208(12f, 12f), flag7 ? 2513.118(2513.67) : 2513.67, 0.83f, 1065.TopLeft, 0f, null);
			this.90("buttonIcon" + k.ToString(), array2[k], 6.5f, new 208(8.X + 6f, 8.Y + 6f), new 198(20, 20, 20), 0.831f, null);
			if (flag7)
			{
				this.113(array3[k]);
			}
		}
	}

	// Token: 0x0600286D RID: 10349 RVA: 0x000CFB58 File Offset: 0x000CDD58
	private static 208 46(1058 1, int 2)
	{
		float[] array = new float[]
		{
			0f,
			0.5f,
			1f,
			1f,
			1f,
			0.5f,
			0f,
			0f
		};
		float[] array2 = new float[]
		{
			0f,
			0f,
			0f,
			0.5f,
			1f,
			1f,
			1f,
			0.5f
		};
		return new 208(1.X + array[2] * 1.Width, 1.Y + array2[2] * 1.Height);
	}

	// Token: 0x0600286E RID: 10350 RVA: 0x000CFBB0 File Offset: 0x000CDDB0
	private static 208 47(1058 1, int 2)
	{
		208 3 = 2513.46(1, 2);
		208 4 = 3 - 2513.Centre(1);
		4 = new 208((float)Math.Sign(4.X), (float)Math.Sign(4.Y));
		return 3 + 4 * 7f;
	}

	// Token: 0x0600286F RID: 10351 RVA: 0x000CFC00 File Offset: 0x000CDE00
	private static 208 48(1058 1)
	{
		float num = 1.Y - 26f;
		if (num < 16f)
		{
			num = 1.Y + 1.Height + 12f;
		}
		if (num > 466f)
		{
			num = Math.Max(16f, 1.Y + 2f);
		}
		return new 208(Math.Max(2f, Math.Min(2513.WindowWidth - 58f, 1.X + 1.Width / 2f - 27f)), num);
	}

	// Token: 0x06002870 RID: 10352 RVA: 0x000CFC90 File Offset: 0x000CDE90
	private void 49()
	{
		float windowWidth = 2513.WindowWidth;
		for (int i = 0; i < this.8.Count; i++)
		{
			2528 <<EMPTY_NAME>> = this.8[i];
			208 2 = 2528.26(<<EMPTY_NAME>>.8, windowWidth, 480f);
			2 = new 208(Math.Max(3f, Math.Min(windowWidth - 3f, 2.X)), Math.Max(3f, Math.Min(477f, 2.Y)));
			208 3 = <<EMPTY_NAME>>.36(windowWidth, 480f);
			this.Line("anchor.line" + i.ToString(), 2, 3, 1f, new 198(238, 90, 90, 150), 0.84f);
			this.Box("anchor.dot" + i.ToString(), 2, new 208(5f, 5f), new 198(238, 68, 68), 0.841f, 1065.Centre, 0.7853982f, null);
			this.Box("anchor.origin" + i.ToString(), 3, new 208(3.5f, 3.5f), new 198(byte.MaxValue, 150, 150), 0.842f, 1065.Centre, 0.7853982f, null);
		}
	}

	// Token: 0x06002871 RID: 10353 RVA: 0x000CFDF8 File Offset: 0x000CDFF8
	private void 50()
	{
		for (int i = 0; i < this.52.Count; i++)
		{
			this.Box("guide.x" + i.ToString(), new 208(this.52[i], 0f), new 208(0.8f, 480f), new 198(byte.MaxValue, 204, 51, 160), 0.815f, 1065.TopCentre, 0f, null);
		}
		for (int j = 0; j < this.53.Count; j++)
		{
			this.Box("guide.y" + j.ToString(), new 208(0f, this.53[j]), new 208(2513.WindowWidth, 0.8f), new 198(byte.MaxValue, 204, 51, 160), 0.815f, 1065.CentreLeft, 0f, null);
		}
	}

	// Token: 0x06002872 RID: 10354 RVA: 0x000CFF00 File Offset: 0x000CE100
	private void 51(1058 1, bool 2)
	{
		if (this.94 != 0 && (this.39 != null || this.8.Count > 0))
		{
			if (this.39 != null && !this.8.Contains(this.39))
			{
				this.8.Clear();
				this.8.Add(this.39);
			}
			this.73((this.94 > 0) ? 1.05f : 0.952381f, "wheel");
			this.94 = 0;
		}
		if (this.87 && this.39 != null)
		{
			this.54(this.39);
			return;
		}
		if (this.86)
		{
			this.53();
			return;
		}
		if (!this.84 || this.91)
		{
			return;
		}
		if (2)
		{
			1058 3 = new 1058(5.X - 3f, 5.Y - 3f, 5.Width + 6f, 5.Height + 6f);
			208 4 = 2513.48(3);
			int i = 0;
			while (i < 4)
			{
				if (2513.92(new 1058(4.X + (float)i * 14f, 4.Y, 12f, 12f), this.82))
				{
					this.91 = true;
					switch (i)
					{
					case 0:
						this.RotateBy(-90f);
						return;
					case 1:
						this.RotateBy(90f);
						return;
					case 2:
						this.72(true, false);
						return;
					default:
						this.72(false, false);
						return;
					}
				}
				else
				{
					i++;
				}
			}
			bool flag = this.8.TrueForAll((2528 1) => 1.21);
			bool flag2 = this.8.TrueForAll((2528 1) => 1.22);
			for (int j = 0; j < 8; j += 2)
			{
				if (208.Distance(2513.47(3, j), this.82) <= 5f && 208.Distance(2513.46(3, j), this.82) > 5f)
				{
					this.91 = true;
					this.60(2513.2520.Rotate, j, 3);
					return;
				}
			}
			for (int k = 0; k < 8; k++)
			{
				bool flag3 = k % 2 == 0;
				bool flag4 = k == 1 || k == 5;
				if ((flag3 || !(flag4 ? (!flag2) : (!flag))) && 208.Distance(2513.46(3, k), this.82) <= 5f)
				{
					this.91 = true;
					this.60(flag3 ? 2513.2520.Scale : 2513.2520.Resize, k, 3);
					return;
				}
			}
		}
		this.91 = true;
		this.43 = this.82;
		this.40 = this.39;
		this.42 = 1549.1;
		if (this.40 == null)
		{
			this.38 = 2513.2520.Box;
			this.51.Clear();
			if (this.42)
			{
				this.51.AddRange(this.8);
			}
			return;
		}
		this.41 = this.8.Contains(this.40);
		if (this.42)
		{
			if (!this.41)
			{
				this.8.Add(this.40);
			}
		}
		else if (!this.41)
		{
			this.8.Clear();
			this.8.Add(this.40);
		}
		this.38 = 2513.2520.Pending;
	}

	// Token: 0x06002873 RID: 10355 RVA: 0x000D0274 File Offset: 0x000CE474
	private void 52()
	{
		this.38 = 2513.2520.None;
		if (this.40 == null)
		{
			return;
		}
		if (this.42)
		{
			if (this.41)
			{
				this.8.Remove(this.40);
			}
		}
		else if (this.41 && this.8.Count == 1)
		{
			2528 <<EMPTY_NAME>> = this.40(this.82, this.40);
			if (<<EMPTY_NAME>> != null && <<EMPTY_NAME>> != this.40)
			{
				this.8.Clear();
				this.8.Add(<<EMPTY_NAME>>);
			}
		}
		this.40 = null;
	}

	// Token: 0x06002874 RID: 10356 RVA: 0x000D0308 File Offset: 0x000CE508
	private void 53()
	{
		2528 <<EMPTY_NAME>> = this.39;
		if (<<EMPTY_NAME>> == null)
		{
			this.78.Clear();
			return;
		}
		if (1549.3)
		{
			this.54(<<EMPTY_NAME>>);
			return;
		}
		if (!this.8.Contains(<<EMPTY_NAME>>))
		{
			this.8.Clear();
			this.8.Add(<<EMPTY_NAME>>);
		}
		this.107("context", this.82, new Func<List<2513.2517>>(this.83), 0f);
	}

	// Token: 0x06002875 RID: 10357 RVA: 0x000D0381 File Offset: 0x000CE581
	private void 54(2528 1)
	{
		if (!this.8.Contains(1))
		{
			this.8.Clear();
			this.8.Add(1);
		}
		this.75();
	}

	// Token: 0x06002876 RID: 10358 RVA: 0x000D03B0 File Offset: 0x000CE5B0
	private void 55()
	{
		this.10(null);
		this.38 = 2513.2520.Move;
		this.44 = this.42();
		this.46.Clear();
		foreach (2528 <<EMPTY_NAME>> in this.8)
		{
			this.46[<<EMPTY_NAME>>] = <<EMPTY_NAME>>.36(2513.WindowWidth, 480f);
		}
	}

	// Token: 0x06002877 RID: 10359 RVA: 0x000D0440 File Offset: 0x000CE640
	private void 56()
	{
		208 <<EMPTY_NAME>> = this.82 - this.43;
		this.52.Clear();
		this.53.Clear();
		if (this.18 && !1549.2)
		{
			<<EMPTY_NAME>> = this.57(this.44, <<EMPTY_NAME>>);
		}
		float windowWidth = 2513.WindowWidth;
		foreach (KeyValuePair<2528, 208> keyValuePair in this.46)
		{
			keyValuePair.Key.9 = keyValuePair.Value + <<EMPTY_NAME>> - 2528.26(keyValuePair.Key.8, windowWidth, 480f);
		}
		if (!this.83)
		{
			this.38 = 2513.2520.None;
			this.52.Clear();
			this.53.Clear();
			foreach (2528 2 in this.8)
			{
				if (!2.13)
				{
					2513.71(2);
				}
			}
		}
	}

	// Token: 0x06002878 RID: 10360 RVA: 0x000D0580 File Offset: 0x000CE780
	private 208 57(1058 1, 208 2)
	{
		List<float> list = new List<float>
		{
			0f,
			2513.WindowWidth / 2f,
			2513.WindowWidth
		};
		List<float> list2 = new List<float>
		{
			0f,
			240f,
			480f
		};
		foreach (2528 3 in 2522.1)
		{
			if (2513.37(3) && !this.8.Contains(3) && !(3.3 == "frame"))
			{
				1058 4 = 3.41();
				list.Add(4.X);
				list.Add(4.X + 4.Width / 2f);
				list.Add(4.X + 4.Width);
				list2.Add(4.Y);
				list2.Add(4.Y + 4.Height / 2f);
				list2.Add(4.Y + 4.Height);
			}
		}
		float[] array = new float[]
		{
			1.X + 2.X,
			1.X + 1.Width / 2f + 2.X,
			1.X + 1.Width + 2.X
		};
		float[] array2 = new float[]
		{
			1.Y + 2.Y,
			1.Y + 1.Height / 2f + 2.Y,
			1.Y + 1.Height + 2.Y
		};
		float item;
		float? num = 2513.58(array, list, out item);
		float item2;
		float? num2 = 2513.58(array2, list2, out item2);
		if (num != null)
		{
			2.X += num.Value;
			this.52.Add(item);
		}
		if (num2 != null)
		{
			2.Y += num2.Value;
			this.53.Add(item2);
		}
		return 2;
	}

	// Token: 0x06002879 RID: 10361 RVA: 0x000D07D8 File Offset: 0x000CE9D8
	private static float? 58(float[] 1, List<float> 2, out float 3)
	{
		float? result = null;
		3 = 0f;
		foreach (float num in 1)
		{
			foreach (float num2 in 2)
			{
				float value = num2 - num;
				if (Math.Abs(value) <= 5f && (result == null || Math.Abs(value) < Math.Abs(result.Value)))
				{
					result = new float?(value);
					3 = num2;
				}
			}
		}
		return result;
	}

	// Token: 0x0600287A RID: 10362 RVA: 0x000D0884 File Offset: 0x000CEA84
	private void 59()
	{
		1058 <<EMPTY_NAME>> = new 1058(Math.Min(this.43.X, this.82.X), Math.Min(this.43.Y, this.82.Y), Math.Abs(this.82.X - this.43.X), Math.Abs(this.82.Y - this.43.Y));
		if (<<EMPTY_NAME>>.Width > 2f || <<EMPTY_NAME>>.Height > 2f)
		{
			this.Box("dragbox.fill", new 208(<<EMPTY_NAME>>.X, <<EMPTY_NAME>>.Y), 2513.117(<<EMPTY_NAME>>), new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 20), 0.85f, 1065.TopLeft, 0f, null);
			208[] array = new 208[]
			{
				new 208(<<EMPTY_NAME>>.X, <<EMPTY_NAME>>.Y),
				new 208(<<EMPTY_NAME>>.X + <<EMPTY_NAME>>.Width, <<EMPTY_NAME>>.Y),
				new 208(<<EMPTY_NAME>>.X + <<EMPTY_NAME>>.Width, <<EMPTY_NAME>>.Y + <<EMPTY_NAME>>.Height),
				new 208(<<EMPTY_NAME>>.X, <<EMPTY_NAME>>.Y + <<EMPTY_NAME>>.Height)
			};
			for (int i = 0; i < 4; i++)
			{
				this.Line("dragbox.edge" + i.ToString(), array[i], array[(i + 1) % 4], 1f, 198.White, 0.851f);
			}
			this.8.Clear();
			this.8.AddRange(this.51);
			foreach (2528 2 in 2522.1)
			{
				if (2513.37(2) && !this.8.Contains(2) && 2513.92(<<EMPTY_NAME>>, 2513.Centre(2.41())))
				{
					this.8.Add(2);
				}
			}
		}
		if (!this.83)
		{
			this.38 = 2513.2520.None;
			if (<<EMPTY_NAME>>.Width <= 2f && <<EMPTY_NAME>>.Height <= 2f && !this.42)
			{
				this.8.Clear();
			}
		}
	}

	// Token: 0x0600287B RID: 10363 RVA: 0x000D0B08 File Offset: 0x000CED08
	private void 60(2513.2520 1, int 2, 1058 3)
	{
		this.10(null);
		this.38 = 1;
		this.45 = 2;
		this.43 = this.82;
		this.44 = this.42();
		this.55 = 0f;
		this.46.Clear();
		this.47.Clear();
		this.48.Clear();
		this.49.Clear();
		this.50.Clear();
		float windowWidth = 2513.WindowWidth;
		foreach (2528 4 in this.8)
		{
			this.46[4] = 4.36(windowWidth, 480f);
			this.47[4] = 4.10;
			this.48[4] = 4.15;
			if (1 == 2513.2520.Resize)
			{
				this.49[4] = new 208(4.12("width"), 4.12("height"));
				this.50[4] = 4.38(2528.27(2513.61(2), 4.NaturalBounds), windowWidth, 480f);
			}
		}
	}

	// Token: 0x0600287C RID: 10364 RVA: 0x000D0C60 File Offset: 0x000CEE60
	private static int 61(int 1)
	{
		switch (1)
		{
		case 1:
			return 13;
		case 3:
			return 9;
		case 5:
			return 7;
		}
		return 11;
	}

	// Token: 0x0600287D RID: 10365 RVA: 0x000D0C8C File Offset: 0x000CEE8C
	private void 62()
	{
		208 <<EMPTY_NAME>> = this.82 - this.43;
		int[] array = new int[]
		{
			-1,
			0,
			1,
			1,
			1,
			0,
			-1,
			-1
		};
		int[] array2 = new int[]
		{
			-1,
			-1,
			-1,
			0,
			1,
			1,
			1,
			0
		};
		float num = 1f + (float)array[this.45] * <<EMPTY_NAME>>.X / Math.Max(1f, this.44.Width);
		float num2 = 1f + (float)array2[this.45] * <<EMPTY_NAME>>.Y / Math.Max(1f, this.44.Height);
		float num3 = Math.Max(0.02f, (num + num2) / 2f);
		208 2 = 1549.2 ? 2513.Centre(this.44) : 2513.46(this.44, (this.45 + 4) % 8);
		float windowWidth = 2513.WindowWidth;
		foreach (2528 3 in this.8)
		{
			if (this.46.ContainsKey(3))
			{
				float num4 = 2513.67(this.47[3] * num3);
				float num5 = num4 / this.47[3];
				208 4 = 2 + (this.46[3] - 2) * num5;
				3.10 = num4;
				3.9 = 4 - 2528.26(3.8, windowWidth, 480f);
			}
		}
		if (!this.83)
		{
			this.38 = 2513.2520.None;
		}
	}

	// Token: 0x0600287E RID: 10366 RVA: 0x000D0E50 File Offset: 0x000CF050
	private void 63()
	{
		208 <<EMPTY_NAME>> = this.82 - this.43;
		bool flag = this.45 == 3 || this.45 == 7;
		float num = (this.45 == 3 || this.45 == 5) ? 1f : -1f;
		float windowWidth = 2513.WindowWidth;
		foreach (2528 2 in this.8)
		{
			if (this.49.ContainsKey(2))
			{
				float num2 = Math.Max(0.01f, 2.10);
				208 3 = this.49[2];
				if (flag)
				{
					2.15("width", 2530.8((float)Math.Round((double)Math.Max(1f, 3.X + num * <<EMPTY_NAME>>.X / num2))));
				}
				else
				{
					2.15("height", 2530.8((float)Math.Round((double)Math.Max(1f, 3.Y + num * <<EMPTY_NAME>>.Y / num2))));
				}
				2.32();
				208 4 = 2.38(2528.27(2513.61(this.45), 2.NaturalBounds), windowWidth, 480f);
				2.9 += this.50[2] - 4;
			}
		}
		if (!this.83)
		{
			this.38 = 2513.2520.None;
		}
	}

	// Token: 0x0600287F RID: 10367 RVA: 0x000D1004 File Offset: 0x000CF204
	private void 64()
	{
		208 <<EMPTY_NAME>> = 2513.Centre(this.44);
		double num = Math.Atan2((double)(this.43.Y - <<EMPTY_NAME>>.Y), (double)(this.43.X - <<EMPTY_NAME>>.X));
		float num2 = (float)((Math.Atan2((double)(this.82.Y - <<EMPTY_NAME>>.Y), (double)(this.82.X - <<EMPTY_NAME>>.X)) - num) * 180.0 / 3.141592653589793);
		num2 = 2528.44(num2);
		num2 = (1549.3 ? ((float)Math.Round((double)(num2 / 15f)) * 15f) : ((float)Math.Round((double)num2)));
		this.55 = num2;
		this.65(num2, <<EMPTY_NAME>>);
		string text = num2.ToString("0", 1662.18) + "°" + (1549.3 ? " (snapped)" : string.Empty);
		208 2 = this.91(text, 8f, false);
		this.Box("rotation.back", this.82 + new 208(10f, 10f), 2 + new 208(6f, 3f), new 198(12, 13, 18, 230), 0.86f, 1065.TopLeft, 0f, null);
		this.Text("rotation.text", text, 8f, this.82 + new 208(13f, 11.5f + 2.Y / 2f), 198.White, 0.861f, 1065.CentreLeft, null, false, 0f);
		if (!this.83)
		{
			this.38 = 2513.2520.None;
		}
	}

	// Token: 0x06002880 RID: 10368 RVA: 0x000D11CC File Offset: 0x000CF3CC
	private void 65(float 1, 208 2)
	{
		float windowWidth = 2513.WindowWidth;
		bool flag = this.8.Count == 1;
		foreach (2528 3 in this.8)
		{
			if (this.48.ContainsKey(3))
			{
				3.15 = 2528.44(this.48[3] + 1);
				if (!flag)
				{
					208 4 = 2 + 2513.66(this.46[3] - 2, 1);
					3.9 = 4 - 2528.26(3.8, windowWidth, 480f);
				}
			}
		}
	}

	// Token: 0x06002881 RID: 10369 RVA: 0x000D1298 File Offset: 0x000CF498
	private static 208 66(208 1, float 2)
	{
		double num = (double)2 * 3.141592653589793 / 180.0;
		float num2 = (float)Math.Cos(num);
		float num3 = (float)Math.Sin(num);
		return new 208(1.X * num2 - 1.Y * num3, 1.X * num3 + 1.Y * num2);
	}

	// Token: 0x06002882 RID: 10370 RVA: 0x000D12F1 File Offset: 0x000CF4F1
	private static float 67(float 1)
	{
		return Math.Max(0.05f, Math.Min(10f, (float)Math.Round((double)1, 3)));
	}

	// Token: 0x06002883 RID: 10371 RVA: 0x000D1310 File Offset: 0x000CF510
	private void 68(2528 1)
	{
		this.54 = 1;
		this.38 = 2513.2520.Place;
		this.8.Clear();
		this.8.Add(1);
	}

	// Token: 0x06002884 RID: 10372 RVA: 0x000D1338 File Offset: 0x000CF538
	private void 69()
	{
		if (this.54 == null)
		{
			this.38 = 2513.2520.None;
			return;
		}
		2513.70(this.54, this.82);
		if (this.83)
		{
			return;
		}
		this.38 = 2513.2520.None;
		if (2513.92(this.25, this.82) && this.17)
		{
			this.Undo();
			this.10.Clear();
			this.8.Clear();
		}
		else if (!this.54.13)
		{
			2513.71(this.54);
		}
		this.54 = null;
	}

	// Token: 0x06002885 RID: 10373 RVA: 0x000D13CE File Offset: 0x000CF5CE
	private static void 70(2528 1, 208 2)
	{
		1.14 = 2527.Centre;
		1.9 = 2 - 2528.26(1.8, 2513.WindowWidth, 480f);
	}

	// Token: 0x06002886 RID: 10374 RVA: 0x000D13FC File Offset: 0x000CF5FC
	private static void 71(2528 1)
	{
		float windowWidth = 2513.WindowWidth;
		208 2 = 1.36(windowWidth, 480f);
		int num = (2.X < windowWidth / 3f) ? 0 : ((2.X < windowWidth * 2f / 3f) ? 1 : 2);
		int num2 = (2.Y < 160f) ? 0 : ((2.Y < 320f) ? 1 : 2);
		int num3 = 6 + num2 * 3 + num;
		1.43((2509)num3);
		208 3 = 2528.27(num3, 1.41());
		1058 naturalBounds = 1.NaturalBounds;
		int num4 = num3;
		float num5 = float.MaxValue;
		for (int i = 6; i <= 14; i++)
		{
			float num6 = 208.Distance(1.38(2528.27(i, naturalBounds), windowWidth, 480f), 3);
			if (num6 < num5 - 0.01f)
			{
				num5 = num6;
				num4 = i;
			}
		}
		1.42((2527)num4);
	}

	// Token: 0x06002887 RID: 10375 RVA: 0x000D14E8 File Offset: 0x000CF6E8
	private void RotateBy(float 1)
	{
		if (this.8.Count == 0)
		{
			return;
		}
		this.10(null);
		1058 2 = this.42();
		this.48.Clear();
		this.46.Clear();
		foreach (2528 3 in this.8)
		{
			this.48[3] = 3.15;
			this.46[3] = 3.36(2513.WindowWidth, 480f);
		}
		this.65(1, 2513.Centre(2));
	}

	// Token: 0x06002888 RID: 10376 RVA: 0x000D15A4 File Offset: 0x000CF7A4
	private void 72(bool 1, bool 2)
	{
		if (this.8.Count == 0)
		{
			return;
		}
		this.10(null);
		float windowWidth = 2513.WindowWidth;
		208 3 = 2 ? new 208(windowWidth / 2f, 240f) : 2513.Centre(this.42());
		foreach (2528 4 in this.8)
		{
			208 5 = 4.36(windowWidth, 480f);
			5 = (1 ? new 208(2f * 3.X - 5.X, 5.Y) : new 208(5.X, 2f * 3.Y - 5.Y));
			if (1)
			{
				4.16 = !4.16;
			}
			else
			{
				4.17 = !4.17;
			}
			4.15 = 2528.44(-4.15);
			4.9 = 5 - 2528.26(4.8, windowWidth, 480f);
			if (2 && !4.13)
			{
				2513.71(4);
			}
		}
	}

	// Token: 0x06002889 RID: 10377 RVA: 0x000D16EC File Offset: 0x000CF8EC
	private void 73(float 1, string 2)
	{
		if (this.8.Count == 0)
		{
			return;
		}
		this.10(2);
		float windowWidth = 2513.WindowWidth;
		208 3 = 2513.Centre(this.42());
		bool flag = this.8.Count == 1;
		foreach (2528 4 in this.8)
		{
			float num = 2513.67(4.10 * 1);
			float num2 = num / 4.10;
			4.10 = num;
			if (!flag)
			{
				208 5 = 3 + (4.36(windowWidth, 480f) - 3) * num2;
				4.9 = 5 - 2528.26(4.8, windowWidth, 480f);
			}
		}
	}

	// Token: 0x0600288A RID: 10378 RVA: 0x000D17DC File Offset: 0x000CF9DC
	private void 74(208 1)
	{
		if (this.8.Count == 0)
		{
			return;
		}
		this.10("nudge");
		foreach (2528 2 in this.8)
		{
			2.9 += 1;
		}
	}

	// Token: 0x0600288B RID: 10379 RVA: 0x000D1854 File Offset: 0x000CFA54
	private void 75()
	{
		if (this.8.Count == 0)
		{
			return;
		}
		this.10(null);
		2511 components = this.Components;
		foreach (2528 <<EMPTY_NAME>> in this.8.ToArray())
		{
			if (<<EMPTY_NAME>>.IsExtraInstance && components != null && components.7(<<EMPTY_NAME>>))
			{
				components.6(<<EMPTY_NAME>>);
				this.11.Add(<<EMPTY_NAME>>.3);
			}
			else
			{
				<<EMPTY_NAME>>.11 = false;
			}
		}
		this.8.Clear();
	}

	// Token: 0x0600288C RID: 10380 RVA: 0x000D18DC File Offset: 0x000CFADC
	private void 76()
	{
		this.8.Clear();
		foreach (2528 item in 2522.1)
		{
			if (2513.37(item) && !2522.12(item))
			{
				this.8.Add(item);
			}
		}
	}

	// Token: 0x0600288D RID: 10381 RVA: 0x000D1950 File Offset: 0x000CFB50
	private void 77()
	{
		if (this.8.Count == 0)
		{
			return;
		}
		this.10(null);
		2524 <<EMPTY_NAME>> = (this.8[0].12 + 1) % (2524)3;
		foreach (2528 2 in this.8)
		{
			2.12 = <<EMPTY_NAME>>;
		}
		this.115("Without the interface: " + 2513.78(<<EMPTY_NAME>>));
	}

	// Token: 0x0600288E RID: 10382 RVA: 0x000D19E4 File Offset: 0x000CFBE4
	private static string 78(2524 1)
	{
		if (1 == 2524.Show)
		{
			return "always shown";
		}
		if (1 != 2524.Hide)
		{
			return "as osu! does";
		}
		return "hidden with it";
	}

	// Token: 0x0600288F RID: 10383 RVA: 0x000D1A00 File Offset: 0x000CFC00
	private static int 79()
	{
		int num = 0;
		foreach (2528 <<EMPTY_NAME>> in 2522.1)
		{
			num = Math.Max(num, <<EMPTY_NAME>>.20);
		}
		return num;
	}

	// Token: 0x06002890 RID: 10384 RVA: 0x000D1A5C File Offset: 0x000CFC5C
	private static int 80()
	{
		int num = 0;
		foreach (2528 <<EMPTY_NAME>> in 2522.1)
		{
			num = Math.Min(num, <<EMPTY_NAME>>.20);
		}
		return num;
	}

	// Token: 0x06002891 RID: 10385 RVA: 0x000D1AB8 File Offset: 0x000CFCB8
	private void 81(bool 1)
	{
		if (this.8.Count == 0)
		{
			return;
		}
		this.10(null);
		List<2528> list = new List<2528>(this.8);
		list.Sort(delegate(2528 1, 2528 2)
		{
			if (1.20 == 2.20)
			{
				return 2522.1.IndexOf(1).CompareTo(2522.1.IndexOf(2));
			}
			return 1.20.CompareTo(2.20);
		});
		int num = 3 ? (2513.79() + 1) : (2513.80() - list.Count);
		for (int i = 0; i < list.Count; i++)
		{
			list[i].20 = num + i;
		}
		2522.15();
	}

	// Token: 0x06002892 RID: 10386 RVA: 0x000D1B4C File Offset: 0x000CFD4C
	private int 82(Predicate<2528> 1)
	{
		int count = this.8.FindAll(1).Count;
		if (count == 0)
		{
			return 0;
		}
		if (count != this.8.Count)
		{
			return 2;
		}
		return 1;
	}

	// Token: 0x06002893 RID: 10387 RVA: 0x000D1B84 File Offset: 0x000CFD84
	private List<2513.2517> 83()
	{
		bool flag = this.8.Count > 0;
		List<2513.2517> list = new List<2513.2517>();
		list.Add(new 2513.2517
		{
			1 = "Anchor",
			6 = new Func<List<2513.2517>>(this.85),
			4 = flag
		});
		2513.2517 <<EMPTY_NAME>> = new 2513.2517();
		<<EMPTY_NAME>>.1 = "Origin";
		<<EMPTY_NAME>>.6 = new Func<List<2513.2517>>(this.86);
		bool flag2;
		if (flag)
		{
			flag2 = (this.82((2528 1) => !1.13) != 1);
		}
		else
		{
			flag2 = false;
		}
		<<EMPTY_NAME>>.4 = flag2;
		list.Add(<<EMPTY_NAME>>);
		list.Add(2513.2517.Separator);
		list.Add(new 2513.2517
		{
			1 = "Reset position",
			4 = flag,
			3 = delegate()
			{
				this.84(delegate(2528 1)
				{
					1.9 = 208.Zero;
				});
			}
		});
		list.Add(new 2513.2517
		{
			1 = "Reset rotation",
			4 = flag,
			3 = delegate()
			{
				this.84(delegate(2528 1)
				{
					1.15 = 0f;
				});
			}
		});
		list.Add(new 2513.2517
		{
			1 = "Reset scale",
			4 = flag,
			3 = delegate()
			{
				this.84(delegate(2528 1)
				{
					1.10 = 1f;
					1.16 = false;
					1.17 = false;
				});
			}
		});
		list.Add(new 2513.2517
		{
			1 = "Reset to osu!'s place and look",
			4 = flag,
			3 = delegate()
			{
				this.84(delegate(2528 1)
				{
					bool flag3 = 1.11;
					1.7();
					1.11 = flag3;
				});
				2522.15();
			}
		});
		list.Add(2513.2517.Separator);
		list.Add(new 2513.2517
		{
			1 = "Bring to front",
			4 = flag,
			3 = delegate()
			{
				this.81(true);
			}
		});
		list.Add(new 2513.2517
		{
			1 = "Send to back",
			4 = flag,
			3 = delegate()
			{
				this.81(false);
			}
		});
		list.Add(2513.2517.Separator);
		list.Add(new 2513.2517
		{
			1 = "Without the interface",
			2 = "I",
			6 = new Func<List<2513.2517>>(this.87),
			4 = flag
		});
		list.Add(2513.2517.Separator);
		list.Add(new 2513.2517
		{
			1 = "Cut",
			2 = "Ctrl+X",
			3 = new Action(this.Cut),
			4 = flag
		});
		list.Add(new 2513.2517
		{
			1 = "Copy",
			2 = "Ctrl+C",
			3 = new Action(this.Copy),
			4 = flag
		});
		list.Add(new 2513.2517
		{
			1 = "Paste",
			2 = "Ctrl+V",
			3 = new Action(this.Paste),
			4 = (2513.4.Count > 0)
		});
		list.Add(new 2513.2517
		{
			1 = "Clone",
			2 = "Ctrl+D",
			3 = new Action(this.Clone),
			4 = flag
		});
		list.Add(2513.2517.Separator);
		list.Add(new 2513.2517
		{
			1 = "Delete",
			2 = "Del",
			3 = new Action(this.75),
			4 = flag,
			7 = true
		});
		return list;
	}

	// Token: 0x06002894 RID: 10388 RVA: 0x000D1EF4 File Offset: 0x000D00F4
	private void 84(Action<2528> 1)
	{
		this.10(null);
		foreach (2528 obj in this.8)
		{
			1(obj);
		}
	}

	// Token: 0x06002895 RID: 10389 RVA: 0x000D1F50 File Offset: 0x000D0150
	private List<2513.2517> 85()
	{
		List<2513.2517> list = new List<2513.2517>();
		2513.2517 <<EMPTY_NAME>> = new 2513.2517();
		<<EMPTY_NAME>>.1 = "Closest";
		<<EMPTY_NAME>>.5 = this.82((2528 1) => !1.13);
		<<EMPTY_NAME>>.3 = delegate()
		{
			this.84(delegate(2528 1)
			{
				1.13 = false;
				2513.71(1);
			});
		};
		list.Add(<<EMPTY_NAME>>);
		list.Add(2513.2517.Separator);
		List<2513.2517> list2 = list;
		for (int i = 0; i < 9; i++)
		{
			2509 anchor = 2509.TopLeft + i;
			list2.Add(new 2513.2517
			{
				1 = 2513.37[i],
				5 = this.82((2528 1) => 1.13 && 1.8 == anchor),
				3 = delegate()
				{
					this.84(delegate(2528 1)
					{
						1.13 = true;
						1.43(anchor);
					});
				}
			});
		}
		return list2;
	}

	// Token: 0x06002896 RID: 10390 RVA: 0x000D2028 File Offset: 0x000D0228
	private List<2513.2517> 86()
	{
		List<2513.2517> list = new List<2513.2517>();
		2513.2517 <<EMPTY_NAME>> = new 2513.2517();
		<<EMPTY_NAME>>.1 = "osu!'s own point";
		<<EMPTY_NAME>>.5 = this.82((2528 1) => 1.14 == 2527.Default);
		<<EMPTY_NAME>>.3 = delegate()
		{
			this.84(delegate(2528 1)
			{
				1.42(2527.Default);
			});
		};
		list.Add(<<EMPTY_NAME>>);
		list.Add(2513.2517.Separator);
		List<2513.2517> list2 = list;
		for (int i = 0; i < 9; i++)
		{
			2527 origin = 2527.TopLeft + i;
			list2.Add(new 2513.2517
			{
				1 = 2513.37[i],
				5 = this.82((2528 1) => 1.14 == origin),
				3 = delegate()
				{
					this.84(delegate(2528 1)
					{
						1.42(origin);
					});
				}
			});
		}
		return list2;
	}

	// Token: 0x06002897 RID: 10391 RVA: 0x000D2100 File Offset: 0x000D0300
	private List<2513.2517> 87()
	{
		List<2513.2517> list = new List<2513.2517>();
		string[] array = new string[]
		{
			"As osu! does it",
			"Always shown",
			"Hidden with it"
		};
		for (int i = 0; i < 3; i++)
		{
			2524 mode = (2524)i;
			list.Add(new 2513.2517
			{
				1 = array[i],
				5 = this.82((2528 1) => 1.12 == mode),
				3 = delegate()
				{
					this.84(delegate(2528 1)
					{
						1.12 = mode;
					});
				}
			});
		}
		return list;
	}

	// Token: 0x06002898 RID: 10392 RVA: 0x000D2194 File Offset: 0x000D0394
	private void 88()
	{
		this.82 = 1555.21() * 1662.70.8();
		this.83 = (1555.2() == 199.Pressed);
		bool flag = 1555.4() == 199.Pressed;
		bool flag2 = 1555.6() == 199.Pressed;
		this.84 = (this.83 && !this.88);
		this.85 = (!this.83 && this.88);
		this.86 = (flag && !this.89);
		this.87 = (flag2 && !this.90);
		this.88 = this.83;
		this.89 = flag;
		this.90 = flag2;
		this.94 = this.93;
		this.93 = 0;
		this.91 = false;
		this.96 = null;
		this.76 = new List<2513.2519>();
	}

	// Token: 0x06002899 RID: 10393 RVA: 0x000D227C File Offset: 0x000D047C
	private void 89()
	{
		foreach (1433 <<EMPTY_NAME>> in this.72.Values)
		{
			if (!this.74.Contains(<<EMPTY_NAME>>))
			{
				<<EMPTY_NAME>>.16 = 0f;
			}
		}
		foreach (1452 2 in this.73.Values)
		{
			if (!this.74.Contains(2))
			{
				2.16 = 0f;
			}
		}
		this.74.Clear();
		this.120();
		if (this.81)
		{
			this.7.13();
			this.81 = false;
		}
		if (this.85)
		{
			this.92 = null;
		}
		this.95 = (this.95(this.82) || this.39 != null);
		this.77 = this.76;
	}

	// Token: 0x0600289A RID: 10394 RVA: 0x000D23A8 File Offset: 0x000D05A8
	private 1433 Box(string 1, 208 2, 208 3, 198 4, float 5, 1065 6 = 1065.TopLeft, float 7 = 0f, 1058? 8 = null)
	{
		1433 9;
		if (!this.72.TryGetValue(1, out 9))
		{
			9 = new 1433(1662.34, (1376)6, 6, (1044)0, 2, 5, true, 198.White, null);
			9.15 = 1.6f;
			this.7.12(9);
			this.72[1] = 9;
		}
		if (9.49 != 6)
		{
			9.49 = 6;
			9.UpdateOriginOffset();
		}
		if (9.2 != 5)
		{
			9.2 = 5;
			this.81 = true;
		}
		9.17 = 2;
		9.20 = 3;
		9.14 = 7;
		9.6 = new 198(4.R, 4.G, 4.B);
		9.16 = (float)4.A / 255f;
		9.6(8);
		this.74.Add(9);
		return 9;
	}

	// Token: 0x0600289B RID: 10395 RVA: 0x000D2494 File Offset: 0x000D0694
	private void Line(string 1, 208 2, 208 3, float 4, 198 5, float 6)
	{
		208 7 = 3 - 2;
		float num = 7.Length();
		this.Box(1, (2 + 3) / 2f, new 208(num, 4), 5, 6, 1065.Centre, (float)Math.Atan2((double)7.Y, (double)7.X), null);
	}

	// Token: 0x0600289C RID: 10396 RVA: 0x000D24F4 File Offset: 0x000D06F4
	private 1452 Text(string 1, string 2, float 3, 208 4, 198 5, float 6, 1065 7 = 1065.CentreLeft, 1058? 8 = null, bool 9 = false, float 10 = 0f)
	{
		1452 11;
		if (!this.73.TryGetValue(1, out 11))
		{
			11 = ((10 > 0f) ? new 1452(2, 3, 4, new 208(10, 0f), 6, true, 198.White, true) : new 1452(2, 3, 4, 6, true, 198.White));
			11.49 = 7;
			this.7.12(11);
			this.73[1] = 11;
		}
		11.SetText(string.IsNullOrEmpty(2) ? " " : 2);
		11.66(3);
		11.54(9);
		if (11.49 != 7)
		{
			11.49 = 7;
			11.UpdateOriginOffset();
		}
		if (11.2 != 6)
		{
			11.2 = 6;
			this.81 = true;
		}
		11.17 = 4;
		11.6 = new 198(5.R, 5.G, 5.B);
		11.16 = (float)5.A / 255f;
		11.6(8);
		this.74.Add(11);
		return 11;
	}

	// Token: 0x0600289D RID: 10397 RVA: 0x000D2618 File Offset: 0x000D0818
	private 1452 90(string 1, 1048 2, float 3, 208 4, 198 5, float 6, 1058? 7 = null)
	{
		1452 8 = this.Text(1, ((char)2).ToString(), 3, 4, 5, 6, 1065.Centre, 7, false, 0f);
		8.67((1068)3);
		return 8;
	}

	// Token: 0x0600289E RID: 10398 RVA: 0x000D2650 File Offset: 0x000D0850
	private 208 91(string 1, float 2, bool 3 = false)
	{
		string key = string.Concat(new string[]
		{
			2.ToString(),
			"|",
			3.ToString(),
			"|",
			1
		});
		208 textSize;
		if (this.75.TryGetValue(key, out textSize))
		{
			return textSize;
		}
		if (this.79 == null)
		{
			this.79 = new 1452(string.Empty, 2, 208.Zero, 0f, false, 198.White);
			this.79.63(false);
		}
		this.79.66(2);
		this.79.54(3);
		this.79.SetText(string.IsNullOrEmpty(1) ? " " : 1);
		textSize = this.79.GetTextSize();
		this.75[key] = textSize;
		return textSize;
	}

	// Token: 0x0600289F RID: 10399 RVA: 0x000D2728 File Offset: 0x000D0928
	private static bool 92(1058 1, 208 2)
	{
		return 2.X >= 1.X && 2.X <= 1.X + 1.Width && 2.Y >= 1.Y && 2.Y <= 1.Y + 1.Height;
	}

	// Token: 0x060028A0 RID: 10400 RVA: 0x000D2780 File Offset: 0x000D0980
	private void 93(1058 1, int 2)
	{
		this.76.Add(new 2513.2519
		{
			1 = 1,
			2 = 2
		});
	}

	// Token: 0x060028A1 RID: 10401 RVA: 0x000D27A0 File Offset: 0x000D09A0
	private bool 94(208 1, int 2)
	{
		foreach (2513.2519 3 in this.77)
		{
			if (3.2 > 2 && 2513.92(3.1, 1))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060028A2 RID: 10402 RVA: 0x000D280C File Offset: 0x000D0A0C
	private bool 95(208 1)
	{
		using (List<2513.2519>.Enumerator enumerator = this.76.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (2513.92(enumerator.Current.1, 1))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060028A3 RID: 10403 RVA: 0x000D286C File Offset: 0x000D0A6C
	private bool 96(1058 1, int 2)
	{
		return 2513.92(1, this.82) && !this.94(this.82, 2) && (this.92 == null || !this.83);
	}

	// Token: 0x060028A4 RID: 10404 RVA: 0x000D28A0 File Offset: 0x000D0AA0
	private bool 97(string 1, 1058 2, int 3)
	{
		bool flag = 2513.92(2, this.82) && !this.94(this.82, 3);
		if (flag && this.84 && !this.91)
		{
			this.92 = 1;
			this.91 = true;
		}
		return this.92 == 1 && this.85 && flag;
	}

	// Token: 0x060028A5 RID: 10405 RVA: 0x000D2909 File Offset: 0x000D0B09
	private bool 98(string 1)
	{
		return this.92 == 1 && this.83;
	}

	// Token: 0x060028A6 RID: 10406 RVA: 0x000D2921 File Offset: 0x000D0B21
	private bool 99(object 1, EventArgs 2)
	{
		return this.101(1);
	}

	// Token: 0x060028A7 RID: 10407 RVA: 0x000D292A File Offset: 0x000D0B2A
	private bool 100(object 1, EventArgs 2)
	{
		return this.101(-1);
	}

	// Token: 0x060028A8 RID: 10408 RVA: 0x000D2933 File Offset: 0x000D0B33
	private bool 101(int 1)
	{
		if (this.15 || !this.95)
		{
			return false;
		}
		this.93 += 1;
		return true;
	}

	// Token: 0x060028A9 RID: 10409 RVA: 0x000D2958 File Offset: 0x000D0B58
	private void 102()
	{
		string[] array = new string[]
		{
			"File",
			"Edit",
			"View"
		};
		Func<List<2513.2517>>[] array2 = new Func<List<2513.2517>>[]
		{
			new Func<List<2513.2517>>(this.103),
			new Func<List<2513.2517>>(this.104),
			new Func<List<2513.2517>>(this.105)
		};
		float num = 0f;
		float num2 = 0f;
		foreach (string text in array)
		{
			num2 += this.91(text, 9f, false).X + 14f;
		}
		string text2 = "HUD layout editor" + (this.HasUnsavedChanges ? "  • unsaved" : string.Empty);
		num2 += this.91(text2, 8f, false).X + 16f;
		1058 <<EMPTY_NAME>> = new 1058(0f, 0f, num2, 14f);
		this.Box("menubar", 208.Zero, new 208(num2, 14f), 2513.64, 0.93f, 1065.TopLeft, 0f, null);
		this.93(<<EMPTY_NAME>>, 2);
		bool flag = this.78.Count > 0 && this.78[0].1.StartsWith("bar:", StringComparison.Ordinal);
		for (int j = 0; j < array.Length; j++)
		{
			float num3 = this.91(array[j], 9f, false).X + 14f;
			1058 2 = new 1058(num, 0f, num3, 14f);
			string b = "bar:" + array[j];
			bool flag2 = this.78.Count > 0 && this.78[0].1 == b;
			bool flag3 = this.96(2, 2);
			if (flag2 || flag3)
			{
				this.Box("menubar.item" + j.ToString(), new 208(num, 0f), new 208(num3, 14f), flag2 ? 2513.66 : 2513.65, 0.931f, 1065.TopLeft, 0f, null);
			}
			this.Text("menubar.label" + j.ToString(), array[j], 9f, new 208(num + num3 / 2f, 7f), 198.White, 0.932f, 1065.Centre, null, false, 0f);
			if (this.97(b, 2, 2))
			{
				if (flag2)
				{
					this.78.Clear();
				}
				else
				{
					this.107(b, new 208(num, 14f), array2[j], 0f);
				}
			}
			else if (flag3 && flag && !flag2)
			{
				this.107(b, new 208(num, 14f), array2[j], 0f);
			}
			num += num3;
		}
		this.Text("menubar.title", text2, 8f, new 208(num + 8f, 7f), this.HasUnsavedChanges ? 2513.67 : 2513.70, 0.932f, 1065.CentreLeft, null, false, 0f);
	}

	// Token: 0x060028AA RID: 10410 RVA: 0x000D2CB0 File Offset: 0x000D0EB0
	private List<2513.2517> 103()
	{
		return new List<2513.2517>
		{
			new 2513.2517
			{
				1 = "Save",
				2 = "Ctrl+S",
				3 = new Action(this.Save)
			},
			new 2513.2517
			{
				1 = "Save and exit",
				2 = "Esc",
				3 = new Action(this.12)
			},
			2513.2517.Separator,
			new 2513.2517
			{
				1 = "Revert to default...",
				7 = true,
				3 = delegate()
				{
					this.110("Revert to default?", "Every element goes back to where osu! puts it, with its settings, and the extra copies are deleted. Undo can bring them back until you leave.", "Revert", new Action(this.14), true);
				}
			},
			2513.2517.Separator,
			new 2513.2517
			{
				1 = "Exit without saving",
				2 = "Shift+Esc",
				3 = new Action(this.13)
			}
		};
	}

	// Token: 0x060028AB RID: 10411 RVA: 0x000D2DA0 File Offset: 0x000D0FA0
	private List<2513.2517> 104()
	{
		bool flag = this.8.Count > 0;
		return new List<2513.2517>
		{
			new 2513.2517
			{
				1 = "Undo",
				2 = "Ctrl+Z",
				3 = new Action(this.Undo),
				4 = (this.9.Count > 0)
			},
			new 2513.2517
			{
				1 = "Redo",
				2 = "Ctrl+Y",
				3 = new Action(this.Redo),
				4 = (this.10.Count > 0)
			},
			2513.2517.Separator,
			new 2513.2517
			{
				1 = "Cut",
				2 = "Ctrl+X",
				3 = new Action(this.Cut),
				4 = flag
			},
			new 2513.2517
			{
				1 = "Copy",
				2 = "Ctrl+C",
				3 = new Action(this.Copy),
				4 = flag
			},
			new 2513.2517
			{
				1 = "Paste",
				2 = "Ctrl+V",
				3 = new Action(this.Paste),
				4 = (2513.4.Count > 0)
			},
			new 2513.2517
			{
				1 = "Clone",
				2 = "Ctrl+D",
				3 = new Action(this.Clone),
				4 = flag
			},
			2513.2517.Separator,
			new 2513.2517
			{
				1 = "Select all",
				2 = "Ctrl+A",
				3 = new Action(this.76)
			},
			new 2513.2517
			{
				1 = "Delete",
				2 = "Del",
				3 = new Action(this.75),
				4 = flag,
				7 = true
			}
		};
	}

	// Token: 0x060028AC RID: 10412 RVA: 0x000D2FD0 File Offset: 0x000D11D0
	private List<2513.2517> 105()
	{
		return new List<2513.2517>
		{
			new 2513.2517
			{
				1 = "Show sidebars",
				2 = "Tab",
				5 = ((this.17 > false) ? 1 : 0),
				3 = delegate()
				{
					this.17 = !this.17;
				}
			},
			new 2513.2517
			{
				1 = "Snap to the screen and elements",
				2 = "Alt: off",
				5 = ((this.18 > false) ? 1 : 0),
				3 = delegate()
				{
					this.18 = !this.18;
				}
			},
			2513.2517.Separator,
			new 2513.2517
			{
				1 = "Keyboard shortcuts...",
				3 = new Action(this.106)
			}
		};
	}

	// Token: 0x060028AD RID: 10413 RVA: 0x000D3099 File Offset: 0x000D1299
	private void 106()
	{
		this.110("Keyboard shortcuts", "Click: select (Ctrl: add or take away). Drag: move, or select with a box. Click a selected element again: the one under it. Ctrl+A: select all. Arrows: move (Shift: by 10). +/- or the wheel: scale. Ctrl+, and Ctrl+.: turn a quarter. Ctrl+H, Ctrl+J: flip across the screen. Del: delete. Right click: anchor, origin and more. I: what happens without the interface. Ctrl+Z/Y: undo/redo. Ctrl+X/C/V/D: cut, copy, paste, clone. Ctrl+S: save. Esc: save and exit (Shift+Esc: without saving). Tab: hide the sidebars. Space: pause the map.", null, null, false);
	}

	// Token: 0x060028AE RID: 10414 RVA: 0x000D30AE File Offset: 0x000D12AE
	private void 107(string 1, 208 2, Func<List<2513.2517>> 3, float 4 = 0f)
	{
		this.78.Clear();
		this.78.Add(new 2513.2518
		{
			1 = 1,
			2 = 2,
			3 = 3,
			4 = 4
		});
	}

	// Token: 0x060028AF RID: 10415 RVA: 0x000D30E8 File Offset: 0x000D12E8
	private void 108()
	{
		if (this.78.Count == 0)
		{
			return;
		}
		bool flag = false;
		for (int i = 0; i < this.78.Count; i++)
		{
			2513.2518 <<EMPTY_NAME>> = this.78[i];
			List<2513.2517> list = <<EMPTY_NAME>>.3();
			float num = 0f;
			float num2 = 0f;
			float num3 = 4f;
			foreach (2513.2517 2 in list)
			{
				if (2.8)
				{
					num3 += 5f;
				}
				else
				{
					num = Math.Max(num, this.91(2.1, 8.5f, false).X);
					if (2.2 != null)
					{
						num2 = Math.Max(num2, this.91(2.2, 7.5f, false).X);
					}
					num3 += 13f;
				}
			}
			float num4 = Math.Max(<<EMPTY_NAME>>.4, num + ((num2 > 0f) ? (num2 + 16f) : 0f) + 34f);
			float num5 = Math.Min(num3, 472f);
			208 3 = <<EMPTY_NAME>>.2;
			3.X = Math.Max(2f, Math.Min(2513.WindowWidth - num4 - 2f, 3.X));
			3.Y = Math.Max(2f, Math.Min(480f - num5 - 2f, 3.Y));
			1058 value = new 1058(3.X, 3.Y, num4, num5);
			<<EMPTY_NAME>>.6 = value;
			if (2513.92(value, this.82) && this.94 != 0 && num3 > num5)
			{
				<<EMPTY_NAME>>.5 = Math.Max(0f, Math.Min(num3 - num5, <<EMPTY_NAME>>.5 - (float)this.94 * 13f * 2f));
				this.94 = 0;
			}
			float num6 = 0.95f + (float)i * 0.005f;
			string str = "popup" + i.ToString() + ".";
			this.Box(str + "back", 3, 2513.117(value), 2513.63, num6, 1065.TopLeft, 0f, null);
			this.Box(str + "edge", 3, new 208(num4, 1f), new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 30), num6 + 0.0001f, 1065.TopLeft, 0f, null);
			this.93(value, 3);
			if (2513.92(value, this.82))
			{
				flag = true;
			}
			float num7 = 3.Y + 2f - <<EMPTY_NAME>>.5;
			for (int j = 0; j < list.Count; j++)
			{
				2513.2517 4 = list[j];
				if (4.8)
				{
					this.Box(str + "sep" + j.ToString(), new 208(3.X + 6f, num7 + 2f), new 208(num4 - 12f, 1f), new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 25), num6 + 0.0002f, 1065.TopLeft, 0f, new 1058?(value));
					num7 += 5f;
				}
				else
				{
					object obj = 2513.92(new 1058(3.X, num7, num4, 13f), this.82) && 2513.92(value, this.82);
					bool flag2 = 4.6 != null && this.78.Count > i + 1 && this.78[i + 1].1 == <<EMPTY_NAME>>.1 + "/" + j.ToString();
					object obj2 = obj;
					if ((obj2 | flag2) != null && 4.4)
					{
						this.Box(str + "hover" + j.ToString(), new 208(3.X + 1f, num7), new 208(num4 - 2f, 13f), 2513.66, num6 + 0.0002f, 1065.TopLeft, 0f, new 1058?(value));
					}
					198 5 = (!4.4) ? new 198(110, 112, 125) : (4.7 ? 2513.71 : 198.White);
					if (4.5 != 0)
					{
						this.90(str + "state" + j.ToString(), (4.5 == 1) ? 1048.check : 1048.minus, 7f, new 208(3.X + 9f, num7 + 6.5f), 2513.67, num6 + 0.0003f, new 1058?(value));
					}
					this.Text(str + "label" + j.ToString(), 4.1, 8.5f, new 208(3.X + 17f, num7 + 6.5f), 5, num6 + 0.0003f, 1065.CentreLeft, new 1058?(value), false, 0f);
					if (4.2 != null)
					{
						this.Text(str + "shortcut" + j.ToString(), 4.2, 7.5f, new 208(3.X + num4 - 8f, num7 + 6.5f), 2513.70, num6 + 0.0003f, 1065.CentreRight, new 1058?(value), false, 0f);
					}
					if (4.6 != null)
					{
						this.90(str + "arrow" + j.ToString(), 1048.chevron_right, 6f, new 208(3.X + num4 - 8f, num7 + 6.5f), 5, num6 + 0.0003f, new 1058?(value));
					}
					if (obj2 != null && 4.4)
					{
						if (this.78.Count > i + 1 && this.78[i + 1].1 != <<EMPTY_NAME>>.1 + "/" + j.ToString())
						{
							this.78.RemoveRange(i + 1, this.78.Count - i - 1);
						}
						if (4.6 != null && this.78.Count == i + 1)
						{
							this.78.Add(new 2513.2518
							{
								1 = <<EMPTY_NAME>>.1 + "/" + j.ToString(),
								2 = new 208(3.X + num4 - 2f, num7 - 2f),
								3 = 4.6
							});
						}
					}
					if (obj2 != null && 4.4 && 4.6 == null && this.84 && !this.91)
					{
						this.91 = true;
						this.92 = str + j.ToString();
					}
					if (obj2 != null && 4.4 && 4.6 == null && this.85 && this.92 == str + j.ToString())
					{
						this.78.Clear();
						Action action = 4.3;
						if (action == null)
						{
							return;
						}
						action();
						return;
					}
					else
					{
						num7 += 13f;
					}
				}
			}
		}
		if ((this.84 || this.86) && !flag && !this.94(this.82, 3) && (!2513.92(new 1058(0f, 0f, 2513.WindowWidth, 14f), this.82) || !this.109(this.82, 2)))
		{
			this.78.Clear();
			if (this.84)
			{
				this.91 = true;
			}
		}
	}

	// Token: 0x060028B0 RID: 10416 RVA: 0x000D3928 File Offset: 0x000D1B28
	private bool 109(208 1, int 2)
	{
		foreach (2513.2519 3 in this.77)
		{
			if (3.2 == 2 && 2513.92(3.1, 1))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060028B1 RID: 10417 RVA: 0x000D3994 File Offset: 0x000D1B94
	private void 110(string 1, string 2, string 3, Action 4, bool 5 = false)
	{
		this.78.Clear();
		this.80 = new 2513.2515
		{
			1 = 1,
			2 = 2,
			3 = 3,
			4 = 4,
			5 = 5
		};
	}

	// Token: 0x060028B2 RID: 10418 RVA: 0x000D39D4 File Offset: 0x000D1BD4
	private void 111()
	{
		if (this.80 == null)
		{
			return;
		}
		1058 <<EMPTY_NAME>> = new 1058(0f, 0f, 2513.WindowWidth, 480f);
		this.Box("dialog.dim", 208.Zero, new 208(2513.WindowWidth, 480f), new 198(0, 0, 0, 120), 0.98f, 1065.TopLeft, 0f, null);
		this.93(<<EMPTY_NAME>>, 4);
		1452 2 = this.Text("dialog.body", this.80.2, 8.5f, 208.Zero, 2513.70, 0.98300004f, 1065.TopLeft, null, false, 256f);
		float y = 2.GetTextSize().Y;
		float num = 52f + y;
		208 3 = new 208((2513.WindowWidth - 280f) / 2f, (480f - num) / 2f);
		this.Box("dialog.back", 3, new 208(280f, num), 2513.63, 0.981f, 1065.TopLeft, 0f, null);
		this.Box("dialog.edge", 3, new 208(280f, 2f), this.80.5 ? 2513.71 : 2513.67, 0.982f, 1065.TopLeft, 0f, null);
		this.Text("dialog.title", this.80.1, 11f, 3 + new 208(12f, 13f), 198.White, 0.98300004f, 1065.CentreLeft, null, true, 0f);
		2.17 = 3 + new 208(12f, 24f);
		float num2 = 3.Y + num - 20f;
		if (this.80.3 == null || !this.112("dialog.confirm", this.80.3, new 1058(3.X + 280f - 152f, num2, 70f, 14f), this.80.5 ? 2513.71 : new 198(80, 140, 60)))
		{
			if (this.112("dialog.cancel", (this.80.3 != null) ? "Cancel" : "OK", new 1058(3.X + 280f - 78f, num2, 66f, 14f), 2513.65))
			{
				this.80 = null;
			}
			return;
		}
		Action action = this.80.4;
		this.80 = null;
		if (action == null)
		{
			return;
		}
		action();
	}

	// Token: 0x060028B3 RID: 10419 RVA: 0x000D3C90 File Offset: 0x000D1E90
	private bool 112(string 1, string 2, 1058 3, 198 4)
	{
		bool flag = 2513.92(3, this.82);
		this.Box(1, new 208(3.X, 3.Y), 2513.117(3), flag ? 2513.118(4) : 4, 0.984f, 1065.TopLeft, 0f, null);
		this.Text(1 + ".label", 2, 8.5f, new 208(3.X + 3.Width / 2f, 3.Y + 3.Height / 2f), 198.White, 0.985f, 1065.Centre, null, false, 0f);
		if (flag && this.84 && !this.91)
		{
			this.91 = true;
			this.92 = 1;
		}
		return flag && this.85 && this.92 == 1;
	}

	// Token: 0x060028B4 RID: 10420 RVA: 0x000D3D82 File Offset: 0x000D1F82
	private void 113(string 1)
	{
		if (!string.IsNullOrEmpty(1) && !this.83)
		{
			this.96 = 1;
		}
	}

	// Token: 0x060028B5 RID: 10421 RVA: 0x000D3D9C File Offset: 0x000D1F9C
	private void 114()
	{
		if (this.96 == null || this.80 != null)
		{
			return;
		}
		1452 <<EMPTY_NAME>> = this.Text("tooltip.text", this.96, 8f, 208.Zero, 198.White, 0.976f, 1065.TopLeft, null, false, 180f);
		208 textSize = <<EMPTY_NAME>>.GetTextSize();
		208 2 = this.82 + new 208(12f, 14f);
		2.X = Math.Min(2.X, 2513.WindowWidth - textSize.X - 10f);
		2.Y = Math.Min(2.Y, 480f - textSize.Y - 8f);
		<<EMPTY_NAME>>.17 = 2 + new 208(4f, 3f);
		this.Box("tooltip.back", 2, textSize + new 208(8f, 6f), new 198(12, 13, 18, 240), 0.975f, 1065.TopLeft, 0f, null);
	}

	// Token: 0x060028B6 RID: 10422 RVA: 0x000D3EB9 File Offset: 0x000D20B9
	private void 115(string 1)
	{
		this.97 = 1;
		this.98 = 1662.33;
	}

	// Token: 0x060028B7 RID: 10423 RVA: 0x000D3ED0 File Offset: 0x000D20D0
	private void 116()
	{
		if (this.97 == null)
		{
			return;
		}
		int num = 1662.33 - this.98;
		if (num > 2000)
		{
			this.97 = null;
			return;
		}
		float num2 = (num < 1600) ? 1f : (1f - (float)(num - 1600) / 400f);
		208 <<EMPTY_NAME>> = this.91(this.97, 9f, false) + new 208(20f, 10f);
		208 2 = new 208((2513.WindowWidth - <<EMPTY_NAME>>.X) / 2f, 420f);
		this.Box("toast.back", 2, <<EMPTY_NAME>>, new 198(24, 26, 36, (byte)(230f * num2)), 0.995f, 1065.TopLeft, 0f, null);
		this.Box("toast.edge", 2, new 208(<<EMPTY_NAME>>.X, 1.5f), new 198(2513.67.R, 2513.67.G, 2513.67.B, (byte)(255f * num2)), 0.996f, 1065.TopLeft, 0f, null);
		this.Text("toast.text", this.97, 9f, 2 + <<EMPTY_NAME>> / 2f, new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, (byte)(255f * num2)), 0.997f, 1065.Centre, null, false, 0f);
	}

	// Token: 0x060028B8 RID: 10424 RVA: 0x000D4059 File Offset: 0x000D2259
	private static 208 117(1058 1)
	{
		return new 208(1.Width, 1.Height);
	}

	// Token: 0x060028B9 RID: 10425 RVA: 0x000D406C File Offset: 0x000D226C
	private static 198 118(198 1)
	{
		return new 198((byte)Math.Min(255, (int)(1.R + 28)), (byte)Math.Min(255, (int)(1.G + 28)), (byte)Math.Min(255, (int)(1.B + 28)), 1.A);
	}

	// Token: 0x060028BA RID: 10426 RVA: 0x000D40C0 File Offset: 0x000D22C0
	private void 119(string 1, string 2, 208 3, float 4, 1058? 5, Action<string> 6, int 7)
	{
		2513.2521 8;
		if (!this.99.TryGetValue(12, out 8))
		{
			8 = new 2513.2521
			{
				1 = new 1448(13 ?? string.Empty, 8.5f, 3, 4, 0.915f, false),
				2 = 3,
				5 = (13 ?? string.Empty)
			};
			8.1.4 = 7;
			8.1.25 = true;
			2513.2521 captured = 8;
			8.1.4(delegate(1448 1, bool 2)
			{
				string text = 1.GetText() ?? string.Empty;
				if (text != captured.5)
				{
					captured.5 = text;
					Action<string> action = captured.3;
					if (action == null)
					{
						return;
					}
					action(text);
				}
			});
			this.7.14<1433>(8.1.2);
			this.99[12] = 8;
		}
		8.3 = 6;
		8.4 = true;
		if (3 != 8.2)
		{
			208 9 = 3 - 8.2;
			foreach (1433 10 in 8.1.2)
			{
				10.17 += 9;
			}
			8.2 = 3;
		}
		foreach (1433 11 in 8.1.2)
		{
			11.6(5);
		}
		if (!8.1.1() && (13 ?? string.Empty) != (8.1.GetText() ?? string.Empty))
		{
			8.5 = (13 ?? string.Empty);
			8.1.SetText(8.5);
		}
	}

	// Token: 0x060028BB RID: 10427 RVA: 0x000D42A0 File Offset: 0x000D24A0
	private void 120()
	{
		List<string> list = null;
		foreach (KeyValuePair<string, 2513.2521> keyValuePair in this.99)
		{
			if (!keyValuePair.Value.4)
			{
				(list = (list ?? new List<string>())).Add(keyValuePair.Key);
			}
			keyValuePair.Value.4 = false;
		}
		if (list == null)
		{
			return;
		}
		foreach (string text in list)
		{
			this.121(text);
		}
	}

	// Token: 0x060028BC RID: 10428 RVA: 0x000D4364 File Offset: 0x000D2564
	private void 121(string 1)
	{
		2513.2521 2 = this.99[1];
		this.99.Remove(1);
		if (2.1.1())
		{
			2.1.18(true);
		}
		foreach (1433 3 in 2.1.2)
		{
			this.7.Remove(3);
		}
		2.1.Dispose();
	}

	// Token: 0x060028BD RID: 10429 RVA: 0x000D4400 File Offset: 0x000D2600
	private bool 122()
	{
		using (Dictionary<string, 2513.2521>.ValueCollection.Enumerator enumerator = this.99.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.1.1())
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x060028BE RID: 10430 RVA: 0x000D4464 File Offset: 0x000D2664
	private void 123()
	{
		foreach (2513.2521 <<EMPTY_NAME>> in this.99.Values)
		{
			if (<<EMPTY_NAME>>.1.1())
			{
				<<EMPTY_NAME>>.1.18(true);
			}
		}
	}

	// Token: 0x060028BF RID: 10431 RVA: 0x000D44D0 File Offset: 0x000D26D0
	private void 124()
	{
		foreach (string text in new List<string>(this.99.Keys))
		{
			this.121(text);
		}
	}

	// Token: 0x04001CEB RID: 7403
	private static bool 1;

	// Token: 0x04001CEC RID: 7404
	private static bool 2;

	// Token: 0x04001CED RID: 7405
	private static 2513 3;

	// Token: 0x04001CEE RID: 7406
	private static readonly List<2513.2516> 4 = new List<2513.2516>();

	// Token: 0x04001CEF RID: 7407
	private readonly 2486 5;

	// Token: 0x04001CF0 RID: 7408
	private readonly Action 6;

	// Token: 0x04001CF1 RID: 7409
	private readonly 1436 7;

	// Token: 0x04001CF2 RID: 7410
	private readonly List<2528> 8 = new List<2528>();

	// Token: 0x04001CF3 RID: 7411
	private readonly List<Dictionary<string, 2513.2516>> 9 = new List<Dictionary<string, 2513.2516>>();

	// Token: 0x04001CF4 RID: 7412
	private readonly List<Dictionary<string, 2513.2516>> 10 = new List<Dictionary<string, 2513.2516>>();

	// Token: 0x04001CF5 RID: 7413
	private readonly HashSet<string> 11 = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

	// Token: 0x04001CF6 RID: 7414
	private Dictionary<string, 2513.2516> 12;

	// Token: 0x04001CF7 RID: 7415
	private int 13 = int.MinValue;

	// Token: 0x04001CF8 RID: 7416
	private string 14;

	// Token: 0x04001CF9 RID: 7417
	private bool 15;

	// Token: 0x04001CFA RID: 7418
	private bool 16;

	// Token: 0x04001CFB RID: 7419
	private bool 17 = true;

	// Token: 0x04001CFC RID: 7420
	private bool 18 = true;

	// Token: 0x04001CFD RID: 7421
	private 2151 19;

	// Token: 0x04001CFE RID: 7422
	private 1409 20;

	// Token: 0x04001CFF RID: 7423
	private const float 21 = 160f;

	// Token: 0x04001D00 RID: 7424
	private const float 22 = 178f;

	// Token: 0x04001D01 RID: 7425
	private const float 23 = 13f;

	// Token: 0x04001D02 RID: 7426
	private static readonly 198[] 24 = new 198[]
	{
		new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue),
		new 198(200, 200, 200),
		new 198(128, 128, 128),
		new 198(32, 32, 32),
		new 198(byte.MaxValue, 68, 68),
		new 198(byte.MaxValue, 136, 51),
		new 198(byte.MaxValue, 204, 51),
		new 198(170, 238, 68),
		new 198(68, 204, 102),
		new 198(51, 204, 170),
		new 198(68, 221, byte.MaxValue),
		new 198(102, 170, byte.MaxValue),
		new 198(51, 102, byte.MaxValue),
		new 198(153, 102, byte.MaxValue),
		new 198(byte.MaxValue, 102, 170),
		new 198(238, 68, 221)
	};

	// Token: 0x04001D03 RID: 7427
	private 1058 25;

	// Token: 0x04001D04 RID: 7428
	private 1058 26;

	// Token: 0x04001D05 RID: 7429
	private float 27;

	// Token: 0x04001D06 RID: 7430
	private float 28;

	// Token: 0x04001D07 RID: 7431
	private float 29;

	// Token: 0x04001D08 RID: 7432
	private float 30 = 1f;

	// Token: 0x04001D09 RID: 7433
	private bool 31;

	// Token: 0x04001D0A RID: 7434
	private string 32;

	// Token: 0x04001D0B RID: 7435
	private const float 33 = 5f;

	// Token: 0x04001D0C RID: 7436
	private const float 34 = 5f;

	// Token: 0x04001D0D RID: 7437
	private const float 35 = 0.05f;

	// Token: 0x04001D0E RID: 7438
	private const float 36 = 10f;

	// Token: 0x04001D0F RID: 7439
	private static readonly string[] 37 = new string[]
	{
		"Top left",
		"Top centre",
		"Top right",
		"Centre left",
		"Centre",
		"Centre right",
		"Bottom left",
		"Bottom centre",
		"Bottom right"
	};

	// Token: 0x04001D10 RID: 7440
	private 2513.2520 38;

	// Token: 0x04001D11 RID: 7441
	private 2528 39;

	// Token: 0x04001D12 RID: 7442
	private 2528 40;

	// Token: 0x04001D13 RID: 7443
	private bool 41;

	// Token: 0x04001D14 RID: 7444
	private bool 42;

	// Token: 0x04001D15 RID: 7445
	private 208 43;

	// Token: 0x04001D16 RID: 7446
	private 1058 44;

	// Token: 0x04001D17 RID: 7447
	private int 45;

	// Token: 0x04001D18 RID: 7448
	private readonly Dictionary<2528, 208> 46 = new Dictionary<2528, 208>();

	// Token: 0x04001D19 RID: 7449
	private readonly Dictionary<2528, float> 47 = new Dictionary<2528, float>();

	// Token: 0x04001D1A RID: 7450
	private readonly Dictionary<2528, float> 48 = new Dictionary<2528, float>();

	// Token: 0x04001D1B RID: 7451
	private readonly Dictionary<2528, 208> 49 = new Dictionary<2528, 208>();

	// Token: 0x04001D1C RID: 7452
	private readonly Dictionary<2528, 208> 50 = new Dictionary<2528, 208>();

	// Token: 0x04001D1D RID: 7453
	private readonly List<2528> 51 = new List<2528>();

	// Token: 0x04001D1E RID: 7454
	private readonly List<float> 52 = new List<float>();

	// Token: 0x04001D1F RID: 7455
	private readonly List<float> 53 = new List<float>();

	// Token: 0x04001D20 RID: 7456
	private 2528 54;

	// Token: 0x04001D21 RID: 7457
	private float 55;

	// Token: 0x04001D22 RID: 7458
	private const int 56 = 0;

	// Token: 0x04001D23 RID: 7459
	private const int 57 = 1;

	// Token: 0x04001D24 RID: 7460
	private const int 58 = 2;

	// Token: 0x04001D25 RID: 7461
	private const int 59 = 3;

	// Token: 0x04001D26 RID: 7462
	private const int 60 = 4;

	// Token: 0x04001D27 RID: 7463
	private const float 61 = 14f;

	// Token: 0x04001D28 RID: 7464
	private const float 62 = 13f;

	// Token: 0x04001D29 RID: 7465
	private static readonly 198 63 = new 198(14, 14, 20, 225);

	// Token: 0x04001D2A RID: 7466
	private static readonly 198 64 = new 198(58, 62, 84, 240);

	// Token: 0x04001D2B RID: 7467
	private static readonly 198 65 = new 198(40, 42, 56);

	// Token: 0x04001D2C RID: 7468
	private static readonly 198 66 = new 198(58, 62, 84);

	// Token: 0x04001D2D RID: 7469
	private static readonly 198 67 = new 198(byte.MaxValue, 204, 51);

	// Token: 0x04001D2E RID: 7470
	private static readonly 198 68 = new 198(byte.MaxValue, 214, 102);

	// Token: 0x04001D2F RID: 7471
	private static readonly 198 69 = new 198(190, 190, 205);

	// Token: 0x04001D30 RID: 7472
	private static readonly 198 70 = new 198(150, 150, 160);

	// Token: 0x04001D31 RID: 7473
	private static readonly 198 71 = new 198(235, 90, 90);

	// Token: 0x04001D32 RID: 7474
	private readonly Dictionary<string, 1433> 72 = new Dictionary<string, 1433>();

	// Token: 0x04001D33 RID: 7475
	private readonly Dictionary<string, 1452> 73 = new Dictionary<string, 1452>();

	// Token: 0x04001D34 RID: 7476
	private readonly HashSet<1371> 74 = new HashSet<1371>();

	// Token: 0x04001D35 RID: 7477
	private readonly Dictionary<string, 208> 75 = new Dictionary<string, 208>();

	// Token: 0x04001D36 RID: 7478
	private List<2513.2519> 76 = new List<2513.2519>();

	// Token: 0x04001D37 RID: 7479
	private List<2513.2519> 77 = new List<2513.2519>();

	// Token: 0x04001D38 RID: 7480
	private readonly List<2513.2518> 78 = new List<2513.2518>();

	// Token: 0x04001D39 RID: 7481
	private 1452 79;

	// Token: 0x04001D3A RID: 7482
	private 2513.2515 80;

	// Token: 0x04001D3B RID: 7483
	private bool 81;

	// Token: 0x04001D3C RID: 7484
	private 208 82;

	// Token: 0x04001D3D RID: 7485
	private bool 83;

	// Token: 0x04001D3E RID: 7486
	private bool 84;

	// Token: 0x04001D3F RID: 7487
	private bool 85;

	// Token: 0x04001D40 RID: 7488
	private bool 86;

	// Token: 0x04001D41 RID: 7489
	private bool 87;

	// Token: 0x04001D42 RID: 7490
	private bool 88;

	// Token: 0x04001D43 RID: 7491
	private bool 89;

	// Token: 0x04001D44 RID: 7492
	private bool 90;

	// Token: 0x04001D45 RID: 7493
	private bool 91;

	// Token: 0x04001D46 RID: 7494
	private string 92;

	// Token: 0x04001D47 RID: 7495
	private int 93;

	// Token: 0x04001D48 RID: 7496
	private int 94;

	// Token: 0x04001D49 RID: 7497
	private bool 95;

	// Token: 0x04001D4A RID: 7498
	private string 96;

	// Token: 0x04001D4B RID: 7499
	private string 97;

	// Token: 0x04001D4C RID: 7500
	private int 98;

	// Token: 0x04001D4D RID: 7501
	private readonly Dictionary<string, 2513.2521> 99 = new Dictionary<string, 2513.2521>();

	// Token: 0x0200051D RID: 1309
	[276]
	private sealed class 2516
	{
		// Token: 0x060028CC RID: 10444 RVA: 0x000D492C File Offset: 0x000D2B2C
		public static 2513.2516 1(2528 1)
		{
			return new 2513.2516
			{
				1 = 1.3,
				2 = 1.4,
				3 = 1.8,
				4 = 1.9,
				5 = 1.10,
				6 = 1.11,
				7 = 1.12,
				8 = 1.13,
				9 = 1.14,
				10 = 1.15,
				11 = 1.16,
				12 = 1.17,
				13 = 1.18,
				14 = 1.19,
				15 = 1.20,
				16 = 1.16()
			};
		}

		// Token: 0x060028CD RID: 10445 RVA: 0x000D4A00 File Offset: 0x000D2C00
		public void 2(2528 1)
		{
			1.8 = this.3;
			1.9 = this.4;
			1.10 = this.5;
			1.11 = this.6;
			1.12 = this.7;
			1.13 = this.8;
			1.14 = this.9;
			1.15 = this.10;
			1.16 = this.11;
			1.17 = this.12;
			1.18 = this.13;
			1.19 = this.14;
			1.20 = this.15;
		}

		// Token: 0x060028CE RID: 10446 RVA: 0x000D4AAC File Offset: 0x000D2CAC
		public bool 3(2513.2516 1)
		{
			if (1 == null || this.3 != 1.3 || this.4 != 1.4 || this.5 != 1.5 || this.6 != 1.6 || this.7 != 1.7 || this.8 != 1.8 || this.9 != 1.9 || this.10 != 1.10 || this.11 != 1.11 || this.12 != 1.12 || this.13 != 1.13 || this.14 != 1.14 || this.15 != 1.15 || this.16.Count != 1.16.Count)
			{
				return false;
			}
			foreach (KeyValuePair<string, string> keyValuePair in this.16)
			{
				string a;
				if (!1.16.TryGetValue(keyValuePair.Key, out a) || a != keyValuePair.Value)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x04001D4E RID: 7502
		public string 1;

		// Token: 0x04001D4F RID: 7503
		public string 2;

		// Token: 0x04001D50 RID: 7504
		public 2509 3;

		// Token: 0x04001D51 RID: 7505
		public 208 4;

		// Token: 0x04001D52 RID: 7506
		public float 5;

		// Token: 0x04001D53 RID: 7507
		public bool 6;

		// Token: 0x04001D54 RID: 7508
		public 2524 7;

		// Token: 0x04001D55 RID: 7509
		public bool 8;

		// Token: 0x04001D56 RID: 7510
		public 2527 9;

		// Token: 0x04001D57 RID: 7511
		public float 10;

		// Token: 0x04001D58 RID: 7512
		public bool 11;

		// Token: 0x04001D59 RID: 7513
		public bool 12;

		// Token: 0x04001D5A RID: 7514
		public float 13;

		// Token: 0x04001D5B RID: 7515
		public 198 14;

		// Token: 0x04001D5C RID: 7516
		public int 15;

		// Token: 0x04001D5D RID: 7517
		public Dictionary<string, string> 16;
	}

	// Token: 0x0200051E RID: 1310
	[276]
	private sealed class 2514
	{
		// Token: 0x04001D5E RID: 7518
		public string 1;

		// Token: 0x04001D5F RID: 7519
		public string 2;

		// Token: 0x04001D60 RID: 7520
		public string 3;

		// Token: 0x04001D61 RID: 7521
		public string 4;

		// Token: 0x04001D62 RID: 7522
		public bool 5;

		// Token: 0x04001D63 RID: 7523
		public bool 6;

		// Token: 0x04001D64 RID: 7524
		public 2528 7;

		// Token: 0x04001D65 RID: 7525
		public Func<2528> 8;
	}

	// Token: 0x0200051F RID: 1311
	[276]
	private enum 2520
	{
		// Token: 0x04001D67 RID: 7527
		None,
		// Token: 0x04001D68 RID: 7528
		Pending,
		// Token: 0x04001D69 RID: 7529
		Move,
		// Token: 0x04001D6A RID: 7530
		Box,
		// Token: 0x04001D6B RID: 7531
		Scale,
		// Token: 0x04001D6C RID: 7532
		Resize,
		// Token: 0x04001D6D RID: 7533
		Rotate,
		// Token: 0x04001D6E RID: 7534
		Place
	}

	// Token: 0x02000520 RID: 1312
	[276]
	private sealed class 2519
	{
		// Token: 0x04001D6F RID: 7535
		public 1058 1;

		// Token: 0x04001D70 RID: 7536
		public int 2;
	}

	// Token: 0x02000521 RID: 1313
	[276]
	private sealed class 2517
	{
		// Token: 0x17000261 RID: 609
		// (get) Token: 0x060028D2 RID: 10450 RVA: 0x000D4C14 File Offset: 0x000D2E14
		public static 2513.2517 Separator
		{
			get
			{
				return new 2513.2517
				{
					8 = true,
					4 = false
				};
			}
		}

		// Token: 0x04001D71 RID: 7537
		public string 1;

		// Token: 0x04001D72 RID: 7538
		public string 2;

		// Token: 0x04001D73 RID: 7539
		public Action 3;

		// Token: 0x04001D74 RID: 7540
		public bool 4 = true;

		// Token: 0x04001D75 RID: 7541
		public int 5;

		// Token: 0x04001D76 RID: 7542
		public Func<List<2513.2517>> 6;

		// Token: 0x04001D77 RID: 7543
		public bool 7;

		// Token: 0x04001D78 RID: 7544
		public bool 8;
	}

	// Token: 0x02000522 RID: 1314
	[276]
	private sealed class 2518
	{
		// Token: 0x04001D79 RID: 7545
		public string 1;

		// Token: 0x04001D7A RID: 7546
		public 208 2;

		// Token: 0x04001D7B RID: 7547
		public Func<List<2513.2517>> 3;

		// Token: 0x04001D7C RID: 7548
		public float 4;

		// Token: 0x04001D7D RID: 7549
		public float 5;

		// Token: 0x04001D7E RID: 7550
		public 1058 6;
	}

	// Token: 0x02000523 RID: 1315
	[276]
	private sealed class 2515
	{
		// Token: 0x04001D7F RID: 7551
		public string 1;

		// Token: 0x04001D80 RID: 7552
		public string 2;

		// Token: 0x04001D81 RID: 7553
		public string 3;

		// Token: 0x04001D82 RID: 7554
		public Action 4;

		// Token: 0x04001D83 RID: 7555
		public bool 5;
	}

	// Token: 0x02000524 RID: 1316
	[276]
	private sealed class 2521
	{
		// Token: 0x04001D84 RID: 7556
		public 1448 1;

		// Token: 0x04001D85 RID: 7557
		public 208 2;

		// Token: 0x04001D86 RID: 7558
		public Action<string> 3;

		// Token: 0x04001D87 RID: 7559
		public bool 4;

		// Token: 0x04001D88 RID: 7560
		public string 5;
	}
}
