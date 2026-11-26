using System;
using System.Collections.Generic;

// Token: 0x0200047B RID: 1147
public sealed class 2570 : 2462
{
	// Token: 0x060022E2 RID: 8930 RVA: 0x000975F4 File Offset: 0x000957F4
	public 2570(1803 1) : base(4)
	{
		if (1226.32 == (1042)1)
		{
			this.17 = true;
			1226.107();
		}
		this.13 = new 1436(true);
		this.10 = new 1417(new 207(0, 82, 1662.70.1() - 4 - 120, 350), 208.Zero, true, 0f, 1545.Default);
		this.14 = new 1436(true);
		this.11 = new 1452(1568.1(2679.SongSelection_TypeToBegin), 11f, new 208(20f, 40f), 1f, true, 198.YellowGreen);
		this.11.54(true);
		this.13.12(this.11);
		this.9 = new 1452(string.Empty, 16f, new 208(20f, 80f), 1f, true, 198.White);
		this.13.12(this.9);
		this.12 = new 1404(18, new 208(20f, 20f), 300f, false, 1.1f);
		this.12.4(delegate(1448 1, bool 2)
		{
			this.19 = 1662.33 + 600;
		});
		this.14.14<1433>(this.12.2);
		this.8 = new 1433(1455.2("searching", (1416)1, null), new 208(320f, 240f), 1f, true, 198.TransparentWhite);
		this.8.49 = 1065.Centre;
		this.8.UpdateOriginOffset();
		1662.25.12(this.8);
		this.18 = new 1354(new EventHandler(2570.2571.instance.4), true, false);
		this.14.14<1433>(this.18.1);
		int num = 330;
		1361 5 = new 1361(1568.1(2679.OnlineSelection_New), new 208((float)num, 20f), new 208(100f, 20f), 1f, 198.Orange, new EventHandler(this.9), true, false, null, true);
		this.13.14<1433>(5.1);
		num += 105;
		5 = new 1361(1568.1(2679.OnlineSelection_TopRated), new 208((float)num, 20f), new 208(100f, 20f), 1f, 198.OrangeRed, new EventHandler(this.10), true, false, null, true);
		this.13.14<1433>(5.1);
		num += 105;
		5 = new 1361(1568.1(2679.OnlineSelection_MostPlayed), new 208((float)num, 20f), new 208(100f, 20f), 1f, 198.SkyBlue, new EventHandler(this.11), true, false, null, true);
		this.13.14<1433>(5.1);
		1452 3 = new 1452(1568.1(2679.OnlineSelection_Status), 11f, new 208(5f, 55f), 1f, true, 198.White);
		3.54(true);
		this.13.12(3);
		this.5 = new 1364(1568.1(2679.OnlineSelection_ShowAlreadyDownloadedMaps), 0.88f, new 208(320f, 54f), 1f, false, 0f);
		this.13.14<1433>(this.5.2);
		this.5.9(new 1183(this.4));
		this.6 = new 1373(this.14, string.Empty, new 208(50f, 54f));
		this.6.10(1568.1(2679.MapStatus_All), 4);
		this.6.10(1568.1(2679.MapStatus_Ranked), 0);
		this.6.10(1568.1(2679.MapStatus_RankedPlayed), 7);
		this.6.10(1568.1(2679.MapStatus_Loved), 8);
		this.6.10(1568.1(2679.MapStatus_Qualified), 3);
		this.6.10(1568.1(2679.MapStatus_Pending), 2);
		this.6.10(1568.1(2679.MapStatus_Graveyard), 5);
		this.6.18(4, true);
		this.6.1(new EventHandler(this.5));
		3 = new 1452(1568.1(2679.OnlineSelection_Mode), 11f, new 208(180f, 55f), 1f, true, 198.White);
		3.54(true);
		this.13.12(3);
		this.7 = new 1373(this.14, string.Empty, new 208(220f, 54f), 85f, 1f);
		this.7.10("All", -1);
		this.7.10("osu!", 0);
		this.7.10("osu!taiko", 1);
		this.7.10("osu!catch", 2);
		this.7.10("osu!mania", 3);
		this.7.18(-1, true);
		this.7.1(new EventHandler(this.3));
		1549.5(new 1549.1551(this.4));
	}

	// Token: 0x060022E3 RID: 8931 RVA: 0x00097BE2 File Offset: 0x00095DE2
	public override void Initialize()
	{
		this.6.18(0, false);
		base.Initialize();
	}

	// Token: 0x060022E4 RID: 8932 RVA: 0x00097BFD File Offset: 0x00095DFD
	private void 1(object 1, bool 2)
	{
		this.5(true);
	}

	// Token: 0x060022E5 RID: 8933 RVA: 0x00097C06 File Offset: 0x00095E06
	private void 2(object 1, EventArgs 2)
	{
		if (string.IsNullOrEmpty(this.15))
		{
			this.15 = "Newest";
		}
		this.5(true);
	}

	// Token: 0x060022E6 RID: 8934 RVA: 0x00097C06 File Offset: 0x00095E06
	private new void 3(object 1, EventArgs 2)
	{
		if (string.IsNullOrEmpty(this.15))
		{
			this.15 = "Newest";
		}
		this.5(true);
	}

	// Token: 0x060022E7 RID: 8935 RVA: 0x00097C28 File Offset: 0x00095E28
	protected override void Dispose(bool 1)
	{
		this.4.ForEach(new Action<1573>(2570.2571.instance.2));
		1549.6(new 1549.1551(this.4));
		this.13.Dispose();
		this.14.Dispose();
		this.10.Dispose();
		this.12.Dispose();
		1373 2 = this.6;
		if (2 != null)
		{
			2.17();
		}
		1373 3 = this.7;
		if (3 != null)
		{
			3.17();
		}
		1662.25.Remove(this.8);
		base.Dispose(1);
		if (this.17)
		{
			1226.107();
		}
	}

	// Token: 0x060022E8 RID: 8936 RVA: 0x00097CD4 File Offset: 0x00095ED4
	private bool 4(object 1, 200 2, bool 3)
	{
		if (!3)
		{
			return false;
		}
		if (2 == 200.Enter)
		{
			this.19 = 1662.33;
			return true;
		}
		if (2 == 200.Escape)
		{
			this.18.3();
			return true;
		}
		return false;
	}

	// Token: 0x060022E9 RID: 8937 RVA: 0x00097D00 File Offset: 0x00095F00
	private void 5(bool 1)
	{
		if (!this.20)
		{
			if (1)
			{
				this.23 = 0;
				this.24 = false;
			}
			this.20 = true;
			if (1 || this.25 == null)
			{
				this.25 = 1632.Current;
			}
			this.6();
			this.11.SetText(1568.1(1 ? 2679.General_Searching : 2679.General_Loading));
			if (1)
			{
				this.8.FadeIn(200, (1046)0, 0);
				this.4.ForEach(new Action<1573>(2570.2571.instance.3));
			}
		}
	}

	// Token: 0x060022EA RID: 8938 RVA: 0x00097D9C File Offset: 0x00095F9C
	private void 6()
	{
		1621 <<EMPTY_NAME>> = new 1621(this.25.GetSearchUrl((int)this.6.18, this.15, (int)this.7.18, this.23), Array.Empty<object>());
		<<EMPTY_NAME>>.9(new 1621.1622(this.8));
		<<EMPTY_NAME>>.Start();
	}

	// Token: 0x060022EB RID: 8939 RVA: 0x00097E04 File Offset: 0x00096004
	private string 7(1621 1, Exception 2)
	{
		if (2 != null)
		{
			return null;
		}
		string result;
		try
		{
			string text = this.25.ToDirectSearch(1.12() ?? string.Empty);
			int num = (text != null) ? text.IndexOf('\n') : -1;
			int num2;
			result = ((text != null && int.TryParse((num < 0) ? text.Trim() : text.Substring(0, num).Trim(), out num2)) ? text : null);
		}
		catch (Exception)
		{
			result = null;
		}
		return result;
	}

	// Token: 0x060022EC RID: 8940 RVA: 0x00097E84 File Offset: 0x00096084
	private void 8(1621 1, Exception 2)
	{
		string text = this.7(4, 5);
		if (text != null)
		{
			List<1573> obj = this.4;
			lock (obj)
			{
				if (this.23 == 0)
				{
					this.4.ForEach(delegate(1573 1)
					{
						1.13();
					});
					this.4.Clear();
					this.10.20(208.Zero, 0f);
				}
				try
				{
					string[] array = text.Split(new char[]
					{
						'\n'
					});
					int num = int.Parse(array[0]);
					this.21 = string.Empty;
					if (num < 0)
					{
						this.11.SetText("Error: " + array[1]);
					}
					else
					{
						for (int i = 1; i < array.Length; i++)
						{
							2570.2572 CS_0024_003C_003E8__locals10 = new 2570.2572();
							CS_0024_003C_003E8__locals10.2 = this;
							if (array[i].Length != 0)
							{
								CS_0024_003C_003E8__locals10.1 = new 1573(array[i]);
								CS_0024_003C_003E8__locals10.1.34 = this.25;
								CS_0024_003C_003E8__locals10.1.11(delegate(object 1, EventArgs 2)
								{
									List<1573> obj2 = CS_0024_003C_003E8__locals10.2.4;
									lock (obj2)
									{
										CS_0024_003C_003E8__locals10.2.4.Remove(CS_0024_003C_003E8__locals10.1);
									}
									CS_0024_003C_003E8__locals10.2.16 = true;
									CS_0024_003C_003E8__locals10.1.13();
								});
								if (this.5.4() || !CS_0024_003C_003E8__locals10.1.12)
								{
									this.4.Add(CS_0024_003C_003E8__locals10.1);
								}
							}
						}
						this.24 = (num > 100 && this.23 != 39);
						num = Math.Min(100, num);
						int num2 = this.23 * 100 + num;
						if (this.24)
						{
							this.11.SetText(string.Format(1568.1(2679.SongSelection_MatchesFound), num2.ToString() + "+"));
						}
						else
						{
							this.11.SetText(string.Format(1568.1((num2 != 1) ? 2679.SongSelection_MatchesFound : 2679.SongSelection_MatchFound), num2));
						}
					}
				}
				catch
				{
				}
			}
			this.16 = true;
			return;
		}
		1637 3 = 1632.Next(this.25, null);
		if (3 != null)
		{
			this.25 = 3;
			this.6();
			return;
		}
		this.11.SetText("Could not reach any beatmap mirror.");
		this.16 = true;
	}

	// Token: 0x060022ED RID: 8941 RVA: 0x00098130 File Offset: 0x00096330
	public override void Draw()
	{
		this.13.22();
		this.10.21();
		this.14.22();
		base.Draw();
	}

	// Token: 0x060022EE RID: 8942 RVA: 0x0009815C File Offset: 0x0009635C
	public override void Update()
	{
		this.12.24(true);
		bool flag;
		if (this.15 == null)
		{
			this.15 = "Newest";
			this.20 = false;
			this.5(true);
			flag = false;
		}
		else
		{
			flag = (this.19 >= 0 && this.19 <= 1662.33);
		}
		if (flag)
		{
			bool flag2 = this.12.GetText() != this.15;
			if (this.12.GetText().Length == 0)
			{
				if (flag2 && this.15 != "Newest" && this.15 != "Top Rated" && this.15 != "Most Played")
				{
					this.15 = "Newest";
					this.5(true);
				}
			}
			else if (!this.20 && flag2)
			{
				this.15 = this.12.GetText();
				this.5(true);
				this.19 = -1;
			}
		}
		this.10.Update();
		if (this.10.20.Y > this.10.17.Y - this.10.15.Height && this.24 && !this.20)
		{
			this.23++;
			this.5(false);
		}
		if (this.16)
		{
			this.8.16(200, (1046)0, 0);
			int num = 0;
			List<1573> obj = this.4;
			lock (obj)
			{
				foreach (1573 <<EMPTY_NAME>> in this.4)
				{
					if (<<EMPTY_NAME>>.7(new 208(10f, (float)num), !this.6.18.Equals(2) && !this.6.18.Equals(5) && !this.6.18.Equals(4)))
					{
						this.10.22.14<1433>(<<EMPTY_NAME>>.23);
					}
					num += 30;
				}
			}
			this.10.17(new 208(640f, (float)(num + 30)));
			this.20 = false;
			this.16 = false;
		}
		base.Update();
	}

	// Token: 0x060022EF RID: 8943 RVA: 0x000983FC File Offset: 0x000965FC
	private void 9(object 1, EventArgs 2)
	{
		this.15 = "Newest";
		this.12.27();
		this.6.18(0, false);
	}

	// Token: 0x060022F0 RID: 8944 RVA: 0x00098427 File Offset: 0x00096627
	private void 10(object 1, EventArgs 2)
	{
		this.15 = "Top Rated";
		this.12.27();
		this.6.18(0, false);
	}

	// Token: 0x060022F1 RID: 8945 RVA: 0x00098452 File Offset: 0x00096652
	private void 11(object 1, EventArgs 2)
	{
		this.15 = "Most Played";
		this.12.27();
		this.6.18(0, false);
	}

	// Token: 0x04001828 RID: 6184
	private readonly List<1573> 4 = new List<1573>();

	// Token: 0x04001829 RID: 6185
	private readonly 1364 5;

	// Token: 0x0400182A RID: 6186
	private readonly 1373 6;

	// Token: 0x0400182B RID: 6187
	private readonly 1373 7;

	// Token: 0x0400182C RID: 6188
	private readonly 1433 8;

	// Token: 0x0400182D RID: 6189
	private readonly 1452 9;

	// Token: 0x0400182E RID: 6190
	private readonly 1417 10;

	// Token: 0x0400182F RID: 6191
	private readonly 1452 11;

	// Token: 0x04001830 RID: 6192
	private readonly 1404 12;

	// Token: 0x04001831 RID: 6193
	private readonly 1436 13;

	// Token: 0x04001832 RID: 6194
	private readonly 1436 14;

	// Token: 0x04001833 RID: 6195
	private string 15;

	// Token: 0x04001834 RID: 6196
	private bool 16;

	// Token: 0x04001835 RID: 6197
	private readonly bool 17;

	// Token: 0x04001836 RID: 6198
	private 1354 18;

	// Token: 0x04001837 RID: 6199
	private int 19;

	// Token: 0x04001838 RID: 6200
	private bool 20;

	// Token: 0x04001839 RID: 6201
	private string 21;

	// Token: 0x0400183A RID: 6202
	private string 22;

	// Token: 0x0400183B RID: 6203
	private int 23;

	// Token: 0x0400183C RID: 6204
	private bool 24;

	// Token: 0x0400183D RID: 6205
	private 1637 25;

	// Token: 0x0200047C RID: 1148
	[Serializable]
	public sealed class 2571
	{
		// Token: 0x060022F3 RID: 8947 RVA: 0x00098490 File Offset: 0x00096690
		internal void 1(object 1, EventArgs 2)
		{
			1662.SetMode(1677.Menu, false);
		}

		// Token: 0x060022F4 RID: 8948 RVA: 0x00098499 File Offset: 0x00096699
		internal void 2(1573 1)
		{
			1.13();
		}

		// Token: 0x060022F5 RID: 8949 RVA: 0x000984A1 File Offset: 0x000966A1
		internal void 3(1573 1)
		{
			1.14();
		}

		// Token: 0x0400183E RID: 6206
		public static readonly 2570.2571 instance = new 2570.2571();

		// Token: 0x0400183F RID: 6207
		public static EventHandler eventHandler;

		// Token: 0x04001840 RID: 6208
		public static Action<1573> action;

		// Token: 0x04001841 RID: 6209
		public static Action<1573> action2;

		// Token: 0x04001842 RID: 6210
		public static Action<1573> action3;
	}

	// Token: 0x0200047D RID: 1149
	public sealed class 2572
	{
		// Token: 0x04001843 RID: 6211
		public 1573 1;

		// Token: 0x04001844 RID: 6212
		public 2570 2;
	}
}
