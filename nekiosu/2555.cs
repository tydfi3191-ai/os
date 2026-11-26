using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

// Token: 0x020004EE RID: 1262
[276]
public sealed class 2555 : 1474
{
	// Token: 0x0600269E RID: 9886 RVA: 0x000BE388 File Offset: 0x000BC588
	public 2555(2486 1) : base(1662.11)
	{
		this.17 = 1;
	}

	// Token: 0x0600269F RID: 9887 RVA: 0x000BE3E5 File Offset: 0x000BC5E5
	private bool 1()
	{
		return 1272.5().25 > 0 && 1662.21();
	}

	// Token: 0x060026A0 RID: 9888 RVA: 0x000BE3FC File Offset: 0x000BC5FC
	public override void Initialize()
	{
		this.3 = new 1436(true);
		this.3.10 = false;
		if (1535.1())
		{
			this.10();
			this.8();
			if (!1535.40)
			{
				this.33 = new 1436(true);
				this.33.10 = false;
				this.32 = new 2554(this.17, this.33);
			}
			if (this.1())
			{
				this.2();
			}
			base.Initialize();
		}
	}

	// Token: 0x060026A1 RID: 9889 RVA: 0x000BE480 File Offset: 0x000BC680
	private void 2()
	{
		if (1662.21())
		{
			this.8 = new 1433(1455.2("commentbox", (1416)1, null), (1376)8, 1065.TopRight, (1044)0, new 208(70f, this.6.17.Y - 24f), 0.95f, true, 198.TransparentWhite, "play");
			this.8.34 = 52;
			this.13.Add(this.8);
			this.3.12(this.8);
			this.9 = new 1433(1455.2("commentbox", (1416)1, null), (1376)8, 1065.TopRight, (1044)0, new 208(70f, this.6.17.Y - 24f), 0.95f, true, 198.TransparentWhite, "play");
			this.9.34 = 1;
			this.9.37 = 52;
			this.9.20 = new 208(1f, 0f);
			1433 <<EMPTY_NAME>> = this.9;
			<<EMPTY_NAME>>.17.Y = <<EMPTY_NAME>>.17.Y + 32.5f;
			this.13.Add(this.9);
			this.3.12(this.9);
			this.10 = new 1433(1455.2("commentbox", (1416)1, null), (1376)8, 1065.TopRight, (1044)0, new 208(70f, this.6.17.Y - 24f + 32.5f), 0.95f, true, 198.TransparentWhite, "play");
			this.10.34 = 49;
			this.10.37 = 53;
			this.13.Add(this.10);
			this.3.12(this.10);
			float num = (float)this.8.35 * 0.625f;
			this.4 = new 1448("Click to add a comment at the current time!", 12f, new 208(this.8.27().X - num + 6f, this.8.17.Y + 17f + 6f), num - 24f, 1f, false);
			this.4.15(new 198(51, 197, 234, 150));
			this.4.1.16 = 0f;
			this.4.1.72 = 0;
			this.4.5(new 1448.1449(this.12));
			this.4.25 = false;
			this.4.3(new 1448.1449(this.13));
			this.4.4 = 80;
			this.4.4(new 1448.1449(this.3));
			this.13.AddRange(this.4.2);
			this.3.14<1433>(this.4.2);
			this.19 = new 1364("Difficulty", 0.7f, new 208(this.8.27().X - 250f, this.8.27().Y + 5f), 1f, false, 0f);
			this.3.14<1433>(this.19.2);
			this.19.9(new 1183(this.5));
			this.19.Hide(true);
			this.19.6("Comment on this particular difficulty");
			this.13.AddRange(this.19.2);
			this.3.14<1433>(this.19.2);
			this.20 = new 1364("Song", 0.7f, new 208(this.8.27().X - 170f, this.8.27().Y + 5f), 1f, false, 0f);
			this.3.14<1433>(this.20.2);
			this.20.9(new 1183(this.5));
			this.20.6("Comment on this collection of beatmaps or the song");
			this.20.Hide(true);
			this.13.AddRange(this.20.2);
			this.3.14<1433>(this.20.2);
			this.21 = new 1364("Player", 0.7f, new 208(this.8.27().X - 90f, this.8.27().Y + 5f), 1f, false, 0f);
			this.3.14<1433>(this.21.2);
			this.21.6("Comment on the current replay (the specific person playing)");
			this.21.9(new 1183(this.5));
			this.21.Hide(true);
			if (1535.39.12)
			{
				this.13.AddRange(this.21.2);
				this.3.14<1433>(this.21.2);
			}
			this.34 = new 208(this.10.27().X - 250f, this.10.27().Y + 5f);
			this.31 = new 1364("Show Comments", 0.7f, this.34, 1f, 1304.115, 0f);
			this.3.14<1433>(this.31.2);
			this.31.9(new 1183(this.7));
			this.31.Hide(true);
			this.13.AddRange(this.31.2);
			this.3.14<1433>(this.31.2);
			this.11 = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, this.34 + new 208(124f, 1f), 0.96f, true, 198.TransparentWhite, null);
			this.11.16 = 0f;
			this.11.20 = new 208(20f, 20f);
			this.11.10 = true;
			this.11.3(new EventHandler(this.20));
			if (1308.1)
			{
				this.13.Add(this.11);
				this.3.12(this.11);
				1452 2 = new 1452("Colour", 10.5f, this.34 + new 208(94f, 2f), 0.96f, true, 198.TransparentWhite);
				this.13.Add(2);
				this.3.12(2);
			}
			if (1304.115)
			{
				this.6();
			}
		}
	}

	// Token: 0x060026A2 RID: 9890 RVA: 0x000BEBCA File Offset: 0x000BCDCA
	private void 3(1448 1, bool 2)
	{
		this.4();
	}

	// Token: 0x060026A3 RID: 9891 RVA: 0x000BEBD4 File Offset: 0x000BCDD4
	private void 4()
	{
		float num = this.4.1.GetTextSize().Y - 13.6f;
		this.9.20.Y = num * 1.6f;
		this.10.17.Y = this.10.7.Y + num;
	}

	// Token: 0x060026A4 RID: 9892 RVA: 0x000BEC38 File Offset: 0x000BCE38
	private void 5(object 1, bool 2)
	{
		if (1 == this.21)
		{
			if (!1535.39.12)
			{
				1763.5("This replay is not stored online.  You can't comment on local replays.", 198.Red, 4000, null);
			}
			else
			{
				this.15 = 2484.Replay;
			}
		}
		else if (1 == this.20)
		{
			this.15 = 2484.Song;
		}
		else if (1 == this.19)
		{
			this.15 = 2484.Map;
		}
		this.21.7(this.15 == 2484.Replay);
		this.20.7(this.15 == 2484.Song);
		this.19.7(this.15 == 2484.Map);
	}

	// Token: 0x060026A5 RID: 9893 RVA: 0x000BECD8 File Offset: 0x000BCED8
	private void 6()
	{
		if (!this.18)
		{
			this.18 = true;
			1621 <<EMPTY_NAME>> = new 1621(1296.6 + "/web/osu-comment.php", Array.Empty<object>());
			<<EMPTY_NAME>>.21("u", 1304.189);
			<<EMPTY_NAME>>.21("p", 1304.186.1(1643.Hashed).ToString());
			<<EMPTY_NAME>>.21("b", 1272.5().25.ToString());
			<<EMPTY_NAME>>.21("s", 1272.5().29.ToString());
			<<EMPTY_NAME>>.21("r", 1535.39.16.ToString(1662.18));
			string 2 = "m";
			int num = (int)1535.39.9;
			<<EMPTY_NAME>>.21(2, num.ToString(1662.18));
			<<EMPTY_NAME>>.21("a", "get");
			<<EMPTY_NAME>>.9(new 1621.1622(this.14));
			<<EMPTY_NAME>>.Start();
		}
	}

	// Token: 0x060026A6 RID: 9894 RVA: 0x000BEDE0 File Offset: 0x000BCFE0
	private void 7(object 1, bool 2)
	{
		2555.2556 3 = new 2555.2556();
		3.1 = 2;
		this.6();
		1304.115.2(3.1);
		this.14.ForEach(new Action<1433>(3.Apply));
	}

	// Token: 0x060026A7 RID: 9895 RVA: 0x000BEE28 File Offset: 0x000BD028
	private void 8()
	{
		1445 <<EMPTY_NAME>> = new 1445(198.White, new 198(byte.MaxValue, 247, 197), 0, 100);
		int num = 85;
		this.7 = new 1433(1455.2("overlay-collections", (1416)1, null), (1376)8, 1065.Centre, (1044)0, new 208(40f, (float)num), 1f, true, 198.White, "play");
		this.7.15(500);
		this.7.42 = <<EMPTY_NAME>>;
		this.7.10 = true;
		this.7.3(delegate(object 1, EventArgs 2)
		{
			1662.25(new 1684(null));
		});
		this.3.12(this.7);
		num += 20;
		if (this.1())
		{
			this.6 = new 1433(1455.2("overlay-discussion", (1416)1, null), (1376)8, 1065.Centre, (1044)0, new 208(40f, (float)num), 1f, true, 198.White, "play");
			this.6.15(500);
			this.6.42 = <<EMPTY_NAME>>;
			this.6.10 = true;
			this.6.3(new EventHandler(this.9));
			this.3.12(this.6);
			num += 20;
		}
		this.5 = new 1433(1455.2("overlay-endreplay", (1416)1, null), (1376)8, 1065.Centre, (1044)0, new 208(40f, (float)num), 1f, true, 198.White, "play");
		this.5.15(500);
		this.5.42 = <<EMPTY_NAME>>;
		this.5.10 = true;
		this.5.3(new EventHandler(this.11));
		this.3.12(this.5);
		num += 20;
	}

	// Token: 0x060026A8 RID: 9896 RVA: 0x000BF01C File Offset: 0x000BD21C
	private void 9(object 1, EventArgs 2)
	{
		this.12 = !this.12;
		if (this.12)
		{
			this.13.ForEach(delegate(1433 1)
			{
				1.FadeIn(100, (1046)0, 0);
			});
			this.6.SetTexture(1455.2("overlay-discussion2", (1416)1, null));
			return;
		}
		this.13.ForEach(new Action<1433>(2555.2558.replayOverlayCallbacks.3));
		this.6.SetTexture(1455.2("overlay-discussion", (1416)1, null));
	}

	// Token: 0x060026A9 RID: 9897 RVA: 0x000BF0B4 File Offset: 0x000BD2B4
	private void 10()
	{
		1452 <<EMPTY_NAME>> = new 1452("REPLAY MODE - Watching " + 1535.39.23 + " play " + 1272.5().49, 13f, new 208(320f, 460f), 208.Zero, 0.4f, true, 198.White, true);
		1445 2 = new 1445(1456.Fade, 0f, 1f, 1662.33, 1662.33 + 4000, (1046)0);
		<<EMPTY_NAME>>.3.Add(2);
		2 = new 1445(new 208((float)1662.70.1(), 60f), new 208(0f - <<EMPTY_NAME>>.GetTextSize().X, 60f), 1662.33, 1662.33 + (int)(<<EMPTY_NAME>>.GetTextSize().X * 52f), (1046)0);
		2.17 = true;
		<<EMPTY_NAME>>.3.Add(2);
		this.3.12(<<EMPTY_NAME>>);
	}

	// Token: 0x060026AA RID: 9898 RVA: 0x000BF1B0 File Offset: 0x000BD3B0
	private void 11(object 1, EventArgs 2)
	{
		2486.36();
		this.17.80 = (707)7;
	}

	// Token: 0x060026AB RID: 9899 RVA: 0x000BF1C3 File Offset: 0x000BD3C3
	private void 12(1448 1, bool 2)
	{
		if (1.GetText() == "Click to add a comment at the current time!")
		{
			1.SetText(string.Empty);
		}
		if (!2486.13)
		{
			2486.7.RequestPauseToggle();
			this.16 = 1226.16;
		}
	}

	// Token: 0x060026AC RID: 9900 RVA: 0x000BF200 File Offset: 0x000BD400
	private void 13(1448 1, bool 2)
	{
		if (this.15 == 2484.None && 7)
		{
			1763.2("Select a target for your comment first!", 1500, (1389)0);
			this.4.16();
			return;
		}
		if (7 && this.4.GetText().Length > 0)
		{
			1621 3 = new 1621(1296.6 + "/web/osu-comment.php", Array.Empty<object>());
			3.21("u", 1304.189);
			3.21("p", 1304.186.1(1643.Hashed).ToString());
			3.21("s", 1272.5().29.ToString());
			3.21("b", 1272.5().25.ToString(1662.18));
			string 4 = "m";
			int num = (int)1535.39.9;
			3.21(4, num.ToString(1662.18));
			3.21("r", 1535.39.16.ToString(1662.18));
			3.21("target", this.15.ToString().ToLower());
			if (this.11.6 != 198.White && this.11.6 != 198.TransparentWhite)
			{
				string 5 = 1045.6(this.11.6);
				3.21("f", 5);
			}
			3.21("a", "post");
			3.21("starttime", this.16.ToString());
			3.21("comment", this.4.GetText());
			3.9(delegate(1621 1, Exception 2)
			{
				1662.89.Schedule(new 1189(this.21), false);
			});
			3.Start();
			this.4.SetEnabled(false);
			this.4.SetText("Sending...");
		}
		if (this.4.GetText().Length == 0)
		{
			this.4.SetText("Click to add a comment at the current time!");
		}
		this.4();
		if (2486.13)
		{
			2486.7.RequestPauseToggle();
		}
	}

	// Token: 0x060026AD RID: 9901 RVA: 0x000BF430 File Offset: 0x000BD630
	private void 14(1621 1, Exception 2)
	{
		2555.2557 commentsResponse = new 2555.2557();
		commentsResponse.1 = this;
		commentsResponse.2 = 1;
		if (2 != null)
		{
			return;
		}
		1662.89.Schedule(delegate()
		{
			if (commentsResponse.1.30 < 0)
			{
				foreach (string text in commentsResponse.2.12().Split(new char[]
				{
					'\n'
				}))
				{
					if (text.Length != 0)
					{
						string[] array2 = text.Split(new char[]
						{
							'\t'
						});
						if (array2.Length >= 4)
						{
							int num;
							int.TryParse(array2[0], NumberStyles.Integer, 1662.18, out num);
							if (num != 0)
							{
								2484 3 = (2484)Enum.Parse(typeof(2484), array2[1], true);
								string text2 = array2[2];
								string text3 = array2[3];
								commentsResponse.1.29.Method11157(new 2553(num, 3, text2, text3));
							}
						}
					}
				}
				commentsResponse.1.30 = 0;
				1662.89.Schedule(new 1189(commentsResponse.1.15), true);
			}
		}, false);
	}

	// Token: 0x060026AE RID: 9902 RVA: 0x000BF484 File Offset: 0x000BD684
	private void 15()
	{
		if (this.29 == null || this.29.Count == 0)
		{
			return;
		}
		2553 <<EMPTY_NAME>> = this.29[this.30];
		int num = <<EMPTY_NAME>>.1();
		this.17(<<EMPTY_NAME>>.2);
		bool flag = <<EMPTY_NAME>>.2 != 2484.Replay;
		if (flag)
		{
			if (this.26 == 0 || this.26 < <<EMPTY_NAME>>.1 || this.25 > 300f)
			{
				this.25 = 80f;
				this.26 = <<EMPTY_NAME>>.1 + num;
			}
		}
		else if (this.28 == 0 || this.28 < <<EMPTY_NAME>>.1 || this.27 < 300f)
		{
			this.27 = 420f;
			this.28 = <<EMPTY_NAME>>.1 + num;
		}
		1452 2 = new 1452(<<EMPTY_NAME>>.4, 14f, new 208((float)(1662.70.1() / 2), 240f), 0.8f, false, 198.White);
		2.49 = 1065.TopCentre;
		2.54(true);
		2.63(true);
		bool flag2 = true;
		string[] array = <<EMPTY_NAME>>.3.Split(new char[]
		{
			'|'
		});
		string a = array[0];
		if (!(a == "player"))
		{
			if (!(a == "creator"))
			{
				if (!(a == "bat"))
				{
					if (a == "subscriber")
					{
						2.62(new 198(byte.MaxValue, 223, 46));
						2.66(17f);
					}
				}
				else
				{
					2.62(198.OrangeRed);
					2.66(20f);
				}
			}
			else
			{
				2.62(new 198(51, 224, byte.MaxValue));
				2.66(18f);
				flag2 = false;
				2.17 = new 208((float)(1662.70.1() / 2), 40f);
				num = Math.Min(5000, Math.Max(3000, num));
			}
		}
		else
		{
			2.62(new 198(33, 246, 22));
			flag2 = false;
			2.66(18f);
			2.17 = new 208((float)(1662.70.1() / 2), 440f);
			num = Math.Min(5000, Math.Max(3000, num));
		}
		if (array.Length > 1)
		{
			2.62(1045.7(array[1]));
		}
		208 textSize = 2.GetTextSize();
		2.1 = (1044)1;
		if (flag2)
		{
			208 3 = new 208((float)1662.70.1() + textSize.X / 2f, flag ? this.25 : this.27);
			new 208((float)(1662.70.1() / 2), flag ? this.25 : this.27);
			208 4 = new 208((0f - textSize.X) / 2f, flag ? this.25 : this.27);
			2.3.Add(new 1445(3, 4, <<EMPTY_NAME>>.1, <<EMPTY_NAME>>.1 + num, (1046)0));
			if (flag)
			{
				this.25 += textSize.Y;
			}
			else
			{
				this.27 -= textSize.Y;
			}
		}
		else
		{
			2.3.Add(new 1445(1456.Fade, 0f, 1f, <<EMPTY_NAME>>.1, <<EMPTY_NAME>>.1 + 200, (1046)0));
			2.3.Add(new 1445(1456.Scale, 1.8f, 1f, <<EMPTY_NAME>>.1, <<EMPTY_NAME>>.1 + 200, (1046)1));
			2.3.Add(new 1445(1456.Fade, 1f, 1f, <<EMPTY_NAME>>.1 + num, <<EMPTY_NAME>>.1 + num + 100, (1046)0));
		}
		this.14.Add(2);
		this.3.12(2);
		if (!1304.115)
		{
			2.9(true);
		}
		this.30++;
		if (this.30 == this.29.Count)
		{
			this.16();
			return;
		}
		1662.89.Schedule(new 1189(this.15), true);
	}

	// Token: 0x060026AF RID: 9903 RVA: 0x000BF8E8 File Offset: 0x000BDAE8
	private void 16()
	{
		this.19.3(string.Format("Difficulty ({0:#,0})", this.22));
		this.21.3(string.Format("Player ({0:#,0})", this.23));
		this.20.3(string.Format("Song ({0:#,0})", this.24));
	}

	// Token: 0x060026B0 RID: 9904 RVA: 0x000BF958 File Offset: 0x000BDB58
	private void 17(2484 1)
	{
		switch (1)
		{
		case 2484.Map:
			this.22++;
			return;
		case 2484.Song:
			this.24++;
			return;
		case 2484.Replay:
			this.23++;
			return;
		default:
			return;
		}
	}

	// Token: 0x060026B1 RID: 9905 RVA: 0x000BF9A6 File Offset: 0x000BDBA6
	protected override void Dispose(bool 1)
	{
		this.3.Dispose();
		1436 2 = this.33;
		if (2 != null)
		{
			2.Dispose();
		}
		if (this.4 != null)
		{
			this.4.Dispose();
		}
		base.Dispose(1);
	}

	// Token: 0x060026B2 RID: 9906 RVA: 0x000BF9DE File Offset: 0x000BDBDE
	public override void Draw()
	{
		if (!1662.47)
		{
			this.3.22();
			base.Draw();
		}
	}

	// Token: 0x060026B3 RID: 9907 RVA: 0x000BF9F9 File Offset: 0x000BDBF9
	internal void 18()
	{
		if (!1662.47)
		{
			1436 <<EMPTY_NAME>> = this.33;
			if (<<EMPTY_NAME>> == null)
			{
				return;
			}
			<<EMPTY_NAME>>.22();
		}
	}

	// Token: 0x060026B4 RID: 9908 RVA: 0x000BFA14 File Offset: 0x000BDC14
	public override void Update()
	{
		if (this.4 != null && !this.4.IsEnabled() && 1226.16 - this.16 > 5000)
		{
			this.4.SetText("Click to add a comment at the current time!");
			this.4.SetEnabled(true);
		}
		2554 <<EMPTY_NAME>> = this.32;
		if (<<EMPTY_NAME>> != null)
		{
			<<EMPTY_NAME>>.4();
		}
		base.Update();
	}

	// Token: 0x060026B5 RID: 9909 RVA: 0x000BFA7C File Offset: 0x000BDC7C
	internal void 19(int 1)
	{
		2555.2559 2 = new 2555.2559();
		2.1 = 55;
		if (this.5 != null)
		{
			this.5.22(new 208(0f, (float)2.1), 500, (1046)1);
		}
		if (this.6 != null)
		{
			this.6.22(new 208(0f, (float)2.1), 500, (1046)1);
		}
		if (this.7 != null)
		{
			this.7.22(new 208(0f, (float)2.1), 500, (1046)1);
		}
		this.13.ForEach(new Action<1433>(2.Move));
	}

	// Token: 0x060026B6 RID: 9910 RVA: 0x000BFB2C File Offset: 0x000BDD2C
	private void 20(object 1, EventArgs 2)
	{
		if (1662.118)
		{
			1763.5("Exit fullscreen mode to use the colour pick feature.", 198.Red, 2000, null);
			return;
		}
		ColorDialog colorDialog = new ColorDialog();
		if (colorDialog.ShowDialog(1662.13()) == DialogResult.OK)
		{
			this.11.6 = new 198(colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
		}
	}

	// Token: 0x060026B7 RID: 9911 RVA: 0x000BFBA4 File Offset: 0x000BDDA4
	private void 21()
	{
		this.17(this.15);
		this.16();
		this.4.SetText("Please wait before commenting again...");
		1763.5("Your comment has been submitted!", 198.Orange, 3000, null);
	}

	// Token: 0x04001BA7 RID: 7079
	private 1436 3;

	// Token: 0x04001BA8 RID: 7080
	private 1448 4;

	// Token: 0x04001BA9 RID: 7081
	private 1433 5;

	// Token: 0x04001BAA RID: 7082
	private 1433 6;

	// Token: 0x04001BAB RID: 7083
	private 1433 7;

	// Token: 0x04001BAC RID: 7084
	private 1433 8;

	// Token: 0x04001BAD RID: 7085
	private 1433 9;

	// Token: 0x04001BAE RID: 7086
	private 1433 10;

	// Token: 0x04001BAF RID: 7087
	private 1433 11;

	// Token: 0x04001BB0 RID: 7088
	private bool 12;

	// Token: 0x04001BB1 RID: 7089
	private List<1433> 13 = new List<1433>();

	// Token: 0x04001BB2 RID: 7090
	private List<1433> 14 = new List<1433>();

	// Token: 0x04001BB3 RID: 7091
	private 2484 15;

	// Token: 0x04001BB4 RID: 7092
	private int 16;

	// Token: 0x04001BB5 RID: 7093
	private 2486 17;

	// Token: 0x04001BB6 RID: 7094
	private bool 18;

	// Token: 0x04001BB7 RID: 7095
	private 1364 19;

	// Token: 0x04001BB8 RID: 7096
	private 1364 20;

	// Token: 0x04001BB9 RID: 7097
	private 1364 21;

	// Token: 0x04001BBA RID: 7098
	private int 22;

	// Token: 0x04001BBB RID: 7099
	private int 23;

	// Token: 0x04001BBC RID: 7100
	private int 24;

	// Token: 0x04001BBD RID: 7101
	private float 25 = 80f;

	// Token: 0x04001BBE RID: 7102
	private int 26;

	// Token: 0x04001BBF RID: 7103
	private float 27 = 420f;

	// Token: 0x04001BC0 RID: 7104
	private int 28;

	// Token: 0x04001BC1 RID: 7105
	private List<2553> 29 = new List<2553>();

	// Token: 0x04001BC2 RID: 7106
	private int 30 = -1;

	// Token: 0x04001BC3 RID: 7107
	private 1364 31;

	// Token: 0x04001BC4 RID: 7108
	private 2554 32;

	// Token: 0x04001BC5 RID: 7109
	private 1436 33;

	// Token: 0x04001BC6 RID: 7110
	private 208 34;

	// Token: 0x020004EF RID: 1263
	[276]
	[Serializable]
	public sealed class 2558
	{
		// Token: 0x060026B9 RID: 9913 RVA: 0x000BFBF7 File Offset: 0x000BDDF7
		internal void 1(1433 1)
		{
			1.16(100, (1046)0, 0);
		}

		// Token: 0x04001BC7 RID: 7111
		public static readonly 2555.2558 replayOverlayCallbacks = new 2555.2558();

		// Token: 0x04001BC8 RID: 7112
		public static EventHandler eventHandler;

		// Token: 0x04001BC9 RID: 7113
		public static Action<1433> action;

		// Token: 0x04001BCA RID: 7114
		public static Action<1433> action2;
	}

	// Token: 0x020004F0 RID: 1264
	[276]
	public sealed class 2557
	{
		// Token: 0x060026BC RID: 9916 RVA: 0x000BFC10 File Offset: 0x000BDE10
		internal void Apply()
		{
			if (this.1.30 >= 0)
			{
				return;
			}
			foreach (string text in this.2.12().Split(new char[]
			{
				'\n'
			}))
			{
				if (text.Length != 0)
				{
					string[] array2 = text.Split(new char[]
					{
						'\t'
					});
					if (array2.Length >= 4)
					{
						int num;
						int.TryParse(array2[0], NumberStyles.Integer, 1662.18, out num);
						if (num != 0)
						{
							2484 <<EMPTY_NAME>> = (2484)Enum.Parse(typeof(2484), array2[1], true);
							string 2 = array2[2];
							string 3 = array2[3];
							this.1.29.Method11157(new 2553(num, <<EMPTY_NAME>>, 2, 3));
						}
					}
				}
			}
			this.1.30 = 0;
			1662.89.Schedule(new 1189(this.1.15), true);
		}

		// Token: 0x04001BCB RID: 7115
		public 2555 1;

		// Token: 0x04001BCC RID: 7116
		public 1621 2;
	}

	// Token: 0x020004F1 RID: 1265
	[276]
	public sealed class 2556
	{
		// Token: 0x060026BE RID: 9918 RVA: 0x000BFCFD File Offset: 0x000BDEFD
		internal void Apply(1433 1)
		{
			1.9(!this.1);
		}

		// Token: 0x04001BCD RID: 7117
		public bool 1;
	}

	// Token: 0x020004F2 RID: 1266
	[276]
	public sealed class 2559
	{
		// Token: 0x060026C0 RID: 9920 RVA: 0x000BFD0E File Offset: 0x000BDF0E
		internal void Move(1433 1)
		{
			1.22(new 208(0f, (float)this.1), 500, (1046)1);
			1.7.Y = 1.7.Y + (float)this.1;
		}

		// Token: 0x04001BCE RID: 7118
		public int 1;
	}
}
