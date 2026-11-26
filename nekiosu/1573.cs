using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;

// Token: 0x02000A1E RID: 2590
public sealed class 1573
{
	// Token: 0x060047D8 RID: 18392 RVA: 0x001C8B0C File Offset: 0x001C6D0C
	internal 1573(string 1, 1579 2, string 3)
	{
		string[] array = 1.Split(new char[]
		{
			'|'
		});
		int num = 0;
		this.13 = array[num++];
		this.1 = array[num++];
		this.9 = array[num++];
		this.2 = array[num++];
		string a = array[num++];
		if (!(a == "1"))
		{
			if (!(a == "2"))
			{
				if (!(a == "3"))
				{
					if (!(a == "4"))
					{
						this.6 = (1281)2;
					}
					else
					{
						this.6 = (1281)7;
					}
				}
				else
				{
					this.6 = (1281)6;
				}
			}
			else
			{
				this.6 = (1281)5;
			}
		}
		else
		{
			this.6 = (1281)4;
		}
		float.TryParse(array[num++], NumberStyles.Any, 1662.18, out this.4);
		try
		{
			this.3 = Convert.ToDateTime(array[num++]);
		}
		catch
		{
			this.3 = DateTime.Now;
		}
		this.5 = int.Parse(array[num++]);
		this.7 = int.Parse(array[num++]);
		this.14 = (array[num++] == "1");
		this.27 = (array[num++] == "1");
		this.26 = int.Parse(array[num++]);
		if (this.14 && array[num].Length > 0)
		{
			this.25 = int.Parse(array[num++]);
		}
		num = 13;
		if (num < array.Length)
		{
			this.29 = array[num++].Split(new char[]
			{
				','
			});
		}
		if (2 == 1579.Post)
		{
			this.8 = int.Parse(3);
		}
		this.12 = (1272.18(this.5) != null);
		1576 4 = 1731.4.Find(new Predicate<1576>(this.15));
		if (4 != null)
		{
			this.11 = true;
			this.20 = 4;
			1576 5 = this.20;
			5.14 = (1582)Delegate.Combine(5.14, new 1582(this.12));
			1576 6 = this.20;
			6.16 = (1580)Delegate.Combine(6.16, new 1580(this.10));
			1576 7 = this.20;
			7.15 = (1581)Delegate.Combine(7.15, new 1581(this.9));
		}
	}

	// Token: 0x060047D9 RID: 18393 RVA: 0x001C8D9C File Offset: 0x001C6F9C
	internal 1573(string 1) : this(1, 1579.Set, string.Empty)
	{
	}

	// Token: 0x060047DA RID: 18394 RVA: 0x001C8DAB File Offset: 0x001C6FAB
	private static int 1()
	{
		return 1662.70.1() - 120 - 30;
	}

	// Token: 0x060047DB RID: 18395 RVA: 0x001C8DC0 File Offset: 0x001C6FC0
	internal string 2()
	{
		if (this.13.Contains(".osz2"))
		{
			return 2672.2(string.Concat(new string[]
			{
				this.5.ToString(),
				" ",
				this.1,
				" - ",
				this.9,
				".osz2"
			}));
		}
		return 2672.2(string.Concat(new string[]
		{
			this.5.ToString(),
			" ",
			this.1,
			" - ",
			this.9,
			".osz"
		}));
	}

	// Token: 0x060047DC RID: 18396 RVA: 0x001C8E76 File Offset: 0x001C7076
	internal bool 3()
	{
		if (this.20 != null || string.IsNullOrEmpty(this.13))
		{
			return this.20 != null;
		}
		this.12 = false;
		this.Download(true);
		return this.20 != null;
	}

	// Token: 0x060047DD RID: 18397 RVA: 0x001C8EAE File Offset: 0x001C70AE
	internal bool 4()
	{
		return this.20 != null;
	}

	// Token: 0x060047DE RID: 18398 RVA: 0x001C8EB9 File Offset: 0x001C70B9
	public bool 5()
	{
		return this.5 >= 709149;
	}

	// Token: 0x060047DF RID: 18399 RVA: 0x001C8ECC File Offset: 0x001C70CC
	internal static void 6(1579 1, string 2, EventHandler 3)
	{
		1573.1575 4 = new 1573.1575();
		4.2 = 1;
		4.3 = 2;
		4.4 = 3;
		1637 5 = 1632.1().FirstOrDefault(new Func<1637, bool>(4.2));
		if (5 != null && !string.IsNullOrEmpty(4.3))
		{
			if (!1662.47)
			{
				1763.2("Looking up beatmap...", 1000, (1389)0);
			}
			4.Start(5);
		}
	}

	// Token: 0x060047E0 RID: 18400 RVA: 0x001C8F3C File Offset: 0x001C713C
	internal bool 7(208 1, bool 2)
	{
		bool flag = this.23 == null;
		if (flag)
		{
			this.23 = new List<1433>();
			this.10 = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, 9, 0.8f, true, this.12 ? new 198(134, 180, byte.MaxValue, 100) : new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 25), null);
			this.10.20 = new 208((float)1573.1(), 28f);
			this.10.15 = 1.6f;
			if (!this.12)
			{
				this.10.35(new EventHandler(this.16));
				this.10.37(new EventHandler(this.17));
			}
			this.10.10 = true;
			this.10.11 = true;
			this.10.3(new EventHandler(this.18));
			this.21 = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, 9, 0.801f, true, new 198(163, 236, 85, 200), null);
			this.21.20 = new 208(0f, 28f);
			this.21.15 = 1.6f;
			this.23.Add(this.21);
			this.22 = new 1505(1632.2(this.34, (1637 1) => 1.GetThumbnailUrl(this.5)), Path.Combine(1345.4(), "Data", "bt", this.5.ToString() + ".jpg"), 500, 9, 0.8f);
			this.22.78 = 80;
			this.22.79 = 60;
			this.22.15 = 0.65f;
			this.23.Add(this.22);
			this.22.56(new 1189(this.19));
			this.23.Add(this.10);
			string str;
			switch (this.6)
			{
			case (1281)4:
				str = "ranked";
				break;
			case (1281)5:
			case (1281)6:
				str = "approved";
				break;
			case (1281)7:
				str = "loved";
				break;
			default:
				str = "question";
				break;
			}
			this.24 = new 1433(1455.2("selection-" + str, (1416)1, null), (1376)6, 1065.Centre, (1044)0, 9 + new 208((float)(1573.1() - 12), 19f), 0.9f, true, 198.TransparentWhite, null);
			this.24.15 = 0.8f;
			this.23.Add(this.24);
			this.15 = new 1452((this.1.Length > 0) ? (this.1 + " - " + this.9) : this.9, 12f, 9 + new 208(32f, 0f), 0.9f, true, 198.White);
			this.15.54(true);
			this.23.Add(this.15);
			this.16 = new 1452(this.2, 12f, 9 + new 208((float)1573.1(), 0f), 0.9f, true, 198.White);
			this.16.49 = 1065.TopRight;
			this.16.54(true);
			this.23.Add(this.16);
			this.17 = new 1452((2 ? "Ranked: " : "Last Updated: ") + this.3.ToString(), 10f, 9 + new 208(32f, 11f), 0.9f, true, 198.White);
			this.23.Add(this.17);
			if (this.29 != null && this.29.Length != 0)
			{
				int num = 1573.1() - 60;
				string text = "mode-taiko-small";
				foreach (string text2 in this.29.Reverse<string>())
				{
					int num2 = text2.LastIndexOf('@');
					if (num2 > 0 && num2 < text2.Length - 1)
					{
						string a = text2.Substring(num2 + 1);
						text = ((a == "1") ? "mode-taiko-small" : ((a == "2") ? "mode-fruits-small" : ((!(a == "3")) ? "mode-osu-small" : "mode-mania-small")));
					}
					1433 3 = new 1433(1455.2(text, (1416)1, null), (1376)6, 1065.CentreLeft, (1044)0, 9 + new 208((float)num, 19f), 0.81f, true, 198.White, null);
					3.10 = true;
					3.52 = ((num2 >= 0) ? text2.Remove(num2) : text2);
					3.15 = 0.78f;
					3.42 = new 1445(198.White, 198.Orange, 0, 200);
					3.3(new EventHandler(this.20));
					this.23.Add(3);
					num -= 20;
					if (num < 1573.1() - 70 - 240)
					{
						break;
					}
				}
			}
			if (this.6 == (1281)4 || this.6 == (1281)5 || this.6 == (1281)7)
			{
				this.18 = new 1433(1455.2("levelbar", (1416)1, null), 9 + new 208(0f, 23f), 0.84f, true, 198.Black);
				this.18.45(true);
				this.18.35 = 180;
				this.23.Add(this.18);
				198 4 = (this.4 > 9f) ? new 198(250, 83, 38, byte.MaxValue) : ((this.4 > 8f) ? new 198(250, 218, 38, byte.MaxValue) : ((this.4 <= 7f) ? new 198(178, 207, 222, byte.MaxValue) : new 198(38, 123, 250, byte.MaxValue)));
				this.19 = new 1433(1455.2("levelbar", (1416)1, null), 9 + new 208(0f, 23f), 0.85f, true, 4);
				this.19.35 = (int)(180f * ((this.4 - 4f) / 6f));
				this.19.45(true);
				this.23.Add(this.19);
				this.19.3.Add(new 1445(1456.VectorScale, new 208(0f, 1f), new 208(1f, 1f), 1662.33, 1662.33 + (int)(this.4 * 100f), (1046)1));
			}
			using (List<1433>.Enumerator enumerator2 = this.23.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					1433 5 = enumerator2.Current;
					5.15(300);
				}
				return flag;
			}
		}
		208 6 = this.23[1].7;
		foreach (1433 7 in this.23)
		{
			208 8 = 9 + (7.7 - 6);
			7.19(8, 1573.1(), (1046)1);
		}
		return flag;
	}

	// Token: 0x060047E1 RID: 18401 RVA: 0x001C9794 File Offset: 0x001C7994
	internal void Download(bool 1)
	{
		if (1662.47 && this.14)
		{
			7 = true;
		}
		1338.5("Downloading " + this.9, 1341.Runtime, (1114)1);
		if (this.20 != null)
		{
			this.20.16(true);
			return;
		}
		if (string.IsNullOrEmpty(this.13))
		{
			1763.2("Can't download this file (please report this)", 2000, (1389)0);
			return;
		}
		if (this.12)
		{
			1689 8 = new 1689("You already have a copy of this beatmap!  Are you sure you want to download it again?", true);
			8.7("Yes, redownload this map!", 198.YellowGreen, delegate(object 1, EventArgs 2)
			{
				this.12 = false;
				this.Download(false);
				this.12 = true;
			}, true, false, true);
			8.7("No, forget it.", 198.OrangeRed, new EventHandler(1573.1574.directBeatmapSetCallbacks.7), true, false, true);
			1662.25(8);
			return;
		}
		if ((this.20 = 1731.10(this, 7)) != null)
		{
			1576 3 = this.20;
			3.14 = (1582)Delegate.Combine(3.14, new 1582(this.12));
			1576 4 = this.20;
			4.16 = (1580)Delegate.Combine(4.16, new 1580(this.10));
			1576 5 = this.20;
			5.15 = (1581)Delegate.Combine(5.15, new 1581(this.9));
			this.11 = true;
			if (this.23 != null)
			{
				this.10.39(198.YellowGreen, 1573.1(), false, (1046)0);
				1662.89.2(new 1189(this.21), 1573.1(), false);
				1452 6 = this.15;
				6.SetText(6.GetText() + " [Downloading]");
			}
		}
	}

	// Token: 0x060047E2 RID: 18402 RVA: 0x001C9944 File Offset: 0x001C7B44
	private void 8()
	{
		if (this.23 != null)
		{
			this.10.39(this.12 ? new 198(134, 180, byte.MaxValue, 100) : new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 25), 1573.1(), false, (1046)0);
			1371 <<EMPTY_NAME>> = this.21;
			1573.1();
			<<EMPTY_NAME>>.20 = new 208(0f, 28f);
			this.15.SetText(this.15.GetText().Replace(" [Downloading]", string.Empty));
		}
		this.11 = false;
		this.20 = null;
	}

	// Token: 0x060047E3 RID: 18403 RVA: 0x001C99F8 File Offset: 0x001C7BF8
	private void 9(double 1)
	{
		Action<double> action = this.32;
		if (action != null)
		{
			action(1);
		}
		float num = (float)1;
		if (this.23 != null)
		{
			this.21.20 = new 208(num * (float)1573.1(), 28f);
		}
	}

	// Token: 0x060047E4 RID: 18404 RVA: 0x001C9A40 File Offset: 0x001C7C40
	private void 10(bool 1)
	{
		Action<bool> action = this.33;
		if (action != null)
		{
			action(1);
		}
		if (1)
		{
			1763.5("Finished downloading " + this.9, 198.White, 3000, null);
			if (this.31 != null)
			{
				this.31(this, null);
				return;
			}
		}
		else
		{
			this.8();
		}
	}

	// Token: 0x060047E5 RID: 18405 RVA: 0x001C9AA0 File Offset: 0x001C7CA0
	internal void 11(EventHandler 1)
	{
		EventHandler eventHandler = this.31;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, 1);
			eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.31, value, eventHandler2);
		}
		while (eventHandler != eventHandler2);
	}

	// Token: 0x060047E6 RID: 18406 RVA: 0x001C9AD5 File Offset: 0x001C7CD5
	private void 12()
	{
		if (1662.78 != 1677.Play)
		{
			1763.2("Downloading " + this.9, 1000, (1389)0);
		}
	}

	// Token: 0x060047E7 RID: 18407 RVA: 0x001C9AFA File Offset: 0x001C7CFA
	internal void 13()
	{
		if (this.23 != null)
		{
			this.23.ForEach(new Action<1433>(1573.1574.directBeatmapSetCallbacks.2));
			this.22.Dispose();
		}
	}

	// Token: 0x060047E8 RID: 18408 RVA: 0x001C9B2A File Offset: 0x001C7D2A
	internal void 14()
	{
		if (this.23 != null)
		{
			this.22.Dispose();
			this.23.ForEach(delegate(1433 1)
			{
				1.16(1000, (1046)0, 0);
			});
		}
	}

	// Token: 0x060047E9 RID: 18409 RVA: 0x001C9B69 File Offset: 0x001C7D69
	private bool 15(1576 1)
	{
		return 1.5() == this.13;
	}

	// Token: 0x060047EA RID: 18410 RVA: 0x001C9B7C File Offset: 0x001C7D7C
	private void 16(object 1, EventArgs 2)
	{
		this.10.39(1045.8(this.10.6, 50), 100, false, (1046)0);
		1226.20(null, "click-short", 1f, false);
	}

	// Token: 0x060047EB RID: 18411 RVA: 0x001C9BC4 File Offset: 0x001C7DC4
	private void 17(object 1, EventArgs 2)
	{
		if (!this.11)
		{
			this.10.39(1045.8(this.10.6, 25), 100, false, (1046)0);
		}
	}

	// Token: 0x060047EC RID: 18412 RVA: 0x001C9BF0 File Offset: 0x001C7DF0
	private void 18(object 1, EventArgs 2)
	{
		1226.20(null, "click-short-confirm", 1f, false);
		if (1731.5 == this)
		{
			this.Download(false);
			return;
		}
		1731.15(this);
	}

	// Token: 0x060047ED RID: 18413 RVA: 0x001C9C2C File Offset: 0x001C7E2C
	private void 19()
	{
		this.22.15(400);
	}

	// Token: 0x060047EE RID: 18414 RVA: 0x001C9C3F File Offset: 0x001C7E3F
	private void 20(object 1, EventArgs 2)
	{
		this.10.1(true);
	}

	// Token: 0x060047EF RID: 18415 RVA: 0x001C9C4E File Offset: 0x001C7E4E
	private void 21()
	{
		this.10.39(1045.8(this.10.6, 25), 800, false, (1046)0);
	}

	// Token: 0x040034DE RID: 13534
	internal readonly string 1;

	// Token: 0x040034DF RID: 13535
	internal readonly string 2;

	// Token: 0x040034E0 RID: 13536
	private readonly DateTime 3;

	// Token: 0x040034E1 RID: 13537
	private readonly float 4;

	// Token: 0x040034E2 RID: 13538
	internal readonly int 5;

	// Token: 0x040034E3 RID: 13539
	private readonly 1281 6;

	// Token: 0x040034E4 RID: 13540
	internal readonly int 7;

	// Token: 0x040034E5 RID: 13541
	internal readonly int 8;

	// Token: 0x040034E6 RID: 13542
	internal readonly string 9;

	// Token: 0x040034E7 RID: 13543
	private 1433 10;

	// Token: 0x040034E8 RID: 13544
	private bool 11;

	// Token: 0x040034E9 RID: 13545
	internal bool 12;

	// Token: 0x040034EA RID: 13546
	internal string 13;

	// Token: 0x040034EB RID: 13547
	internal bool 14;

	// Token: 0x040034EC RID: 13548
	private 1452 15;

	// Token: 0x040034ED RID: 13549
	private 1452 16;

	// Token: 0x040034EE RID: 13550
	private 1452 17;

	// Token: 0x040034EF RID: 13551
	private 1433 18;

	// Token: 0x040034F0 RID: 13552
	private 1433 19;

	// Token: 0x040034F1 RID: 13553
	private 1576 20;

	// Token: 0x040034F2 RID: 13554
	private 1433 21;

	// Token: 0x040034F3 RID: 13555
	private 1505 22;

	// Token: 0x040034F4 RID: 13556
	internal List<1433> 23;

	// Token: 0x040034F5 RID: 13557
	private 1433 24;

	// Token: 0x040034F6 RID: 13558
	internal int 25;

	// Token: 0x040034F7 RID: 13559
	internal int 26;

	// Token: 0x040034F8 RID: 13560
	private bool 27;

	// Token: 0x040034F9 RID: 13561
	internal int 28;

	// Token: 0x040034FA RID: 13562
	internal string[] 29;

	// Token: 0x040034FB RID: 13563
	public bool 30;

	// Token: 0x040034FC RID: 13564
	private EventHandler 31;

	// Token: 0x040034FD RID: 13565
	internal Action<double> 32;

	// Token: 0x040034FE RID: 13566
	internal Action<bool> 33;

	// Token: 0x040034FF RID: 13567
	internal 1637 34 = 1632.Current;

	// Token: 0x02000A1F RID: 2591
	[Serializable]
	public sealed class 1574
	{
		// Token: 0x060047F2 RID: 18418 RVA: 0x00005ADD File Offset: 0x00003CDD
		internal void 1(object 1, EventArgs 2)
		{
		}

		// Token: 0x060047F3 RID: 18419 RVA: 0x001C9C9A File Offset: 0x001C7E9A
		internal void 2(1433 1)
		{
			1.10 = false;
			1.16(300, (1046)0, 0);
			1.22(new 208(50f, 0f), 300, (1046)0);
			1.5 = false;
		}

		// Token: 0x04003500 RID: 13568
		public static readonly 1573.1574 directBeatmapSetCallbacks = new 1573.1574();

		// Token: 0x04003501 RID: 13569
		public static EventHandler eventHandler;

		// Token: 0x04003502 RID: 13570
		public static Action<1433> action;

		// Token: 0x04003503 RID: 13571
		public static Action<1433> action2;
	}

	// Token: 0x02000A20 RID: 2592
	public sealed class 1575
	{
		// Token: 0x060047F6 RID: 18422 RVA: 0x001C9CDE File Offset: 0x001C7EDE
		internal char 1()
		{
			return this.2.ToString().ToLower()[0];
		}

		// Token: 0x060047F7 RID: 18423 RVA: 0x001C9CFC File Offset: 0x001C7EFC
		internal bool 2(1637 1)
		{
			return 1.SupportsLookup(this.1());
		}

		// Token: 0x060047F8 RID: 18424 RVA: 0x001C9D0C File Offset: 0x001C7F0C
		internal void Start(1637 1)
		{
			this.5 = 1;
			this.1 = new 1621(this.5.GetLookupUrl(this.1(), this.3), Array.Empty<object>());
			this.1.9(new 1621.1622(this.3));
			this.1.Start();
		}

		// Token: 0x060047F9 RID: 18425 RVA: 0x001C9D6C File Offset: 0x001C7F6C
		internal void 3(1621 1, Exception 2)
		{
			string text = string.Empty;
			try
			{
				text = ((2 == null) ? (this.5.ToDirectSet(this.1.12() ?? string.Empty) ?? string.Empty).Trim() : string.Empty);
			}
			catch (Exception)
			{
			}
			if (text.Length == 0)
			{
				1637 3 = 1632.Next(this.5, new Func<1637, bool>(this.2));
				if (3 != null)
				{
					this.Start(3);
					return;
				}
			}
			1573 4 = null;
			if (text.Length > 0)
			{
				try
				{
					4 = new 1573(text, this.2, this.3);
				}
				catch (Exception)
				{
				}
			}
			if (4 != null)
			{
				4.34 = this.5;
				if (this.2 == 1579.Beatmap)
				{
					try
					{
						4.28 = int.Parse(this.3);
					}
					catch
					{
					}
				}
				this.4(4, null);
				return;
			}
			this.4(null, null);
		}

		// Token: 0x04003504 RID: 13572
		public 1621 1;

		// Token: 0x04003505 RID: 13573
		public 1579 2;

		// Token: 0x04003506 RID: 13574
		public string 3;

		// Token: 0x04003507 RID: 13575
		public EventHandler 4;

		// Token: 0x04003508 RID: 13576
		public 1637 5;
	}
}
