using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

// Token: 0x020004BF RID: 1215
public class 2568 : 2462
{
	// Token: 0x060024CF RID: 9423 RVA: 0x000A7924 File Offset: 0x000A5B24
	internal 2568(1803 1) : base(1)
	{
	}

	// Token: 0x060024D0 RID: 9424 RVA: 0x000A7950 File Offset: 0x000A5B50
	protected bool 1(object 1, 200 2)
	{
		if (2 == 200.Escape)
		{
			this.GoBack();
			return true;
		}
		if (2 == 200.F2)
		{
			if (this.16.12)
			{
				this.9(new 2152(this.2));
				return true;
			}
			if (this.16 != null)
			{
				2230.20((this.16.26 == null && 2486.88 != null) ? 2486.88 : this.16, true);
				return true;
			}
		}
		if (2 == 200.Space || 2 == 200.Enter)
		{
			this.11(false);
			return true;
		}
		return false;
	}

	// Token: 0x060024D1 RID: 9425 RVA: 0x000A79DC File Offset: 0x000A5BDC
	private void 2(object 1)
	{
		this.16.34(new 2152(this.2));
		2230.20(this.16, true);
		this.10 = false;
		this.18.38 = 0f;
		1763.3();
	}

	// Token: 0x060024D2 RID: 9426 RVA: 0x000A7A2C File Offset: 0x000A5C2C
	protected override void Dispose(bool 1)
	{
		if (this.6 != null)
		{
			1226.25(this.6);
		}
		1226.110();
		if (this.25 != null)
		{
			this.25.Dispose();
		}
		1549.2(new 1549.1550(this.1));
		if (1272.5() != null)
		{
			1272.5().70.Clear();
		}
		if (this.11 != null)
		{
			this.11.Close(false);
			this.11.9();
		}
		if (this.16 != null)
		{
			if (this.16.11 != null)
			{
				this.16.25();
			}
			if (this.10)
			{
				this.16.34(new 2152(this.10));
			}
			if (!1535.1())
			{
				this.16.26();
			}
		}
		1677 2 = 1662.77;
		if (2 != 1677.Rank && 2 != 1677.RankingVs && 2 - 1677.RankingTagCoop > 1)
		{
			2486.88 = null;
		}
		1662.25.Remove(this.15);
		if (this.18 != null)
		{
			this.18.Dispose();
		}
		if (this.19 != null)
		{
			this.19.Dispose();
		}
		if (this.17 != null)
		{
			this.17.Dispose();
		}
		base.Dispose(1);
	}

	// Token: 0x060024D3 RID: 9427 RVA: 0x000A7B68 File Offset: 0x000A5D68
	public override void Update()
	{
		if (this.25 == null)
		{
			return;
		}
		this.25.Update();
		if (this.27 != null)
		{
			if (this.25.20.Y > 20f)
			{
				this.27.Hide();
			}
			else
			{
				this.27.Show();
			}
		}
		int num = 1662.33 - this.21;
		int num2 = num / 500;
		if (this.14 != null)
		{
			string text = string.Empty;
			for (int i = 0; i < this.22.Length; i++)
			{
				text = ((i < num2) ? (text + this.22[i].ToString()) : (text + 1196.2(0, 9).ToString()[0].ToString()));
			}
			this.14.SetText(text);
		}
		if (num > 4400 && !this.12)
		{
			this.ShowRankingDialog();
		}
		base.Update();
	}

	// Token: 0x060024D4 RID: 9428 RVA: 0x000A7C69 File Offset: 0x000A5E69
	public override void Draw()
	{
		if (this.25 != null)
		{
			base.Draw();
			this.17.22();
			this.25.21();
			this.19.22();
		}
	}

	// Token: 0x060024D5 RID: 9429 RVA: 0x000A7C9C File Offset: 0x000A5E9C
	protected virtual int ScheduleStatEntries()
	{
		int num = 300 - (this.9 ? 7000 : 0);
		foreach (2566 <<EMPTY_NAME>> in this.5)
		{
			if (<<EMPTY_NAME>>.1 != null)
			{
				foreach (1445 2 in <<EMPTY_NAME>>.1.3)
				{
					2.9 += num;
					2.10 += num;
				}
				this.18.12(<<EMPTY_NAME>>.1);
				this.4.Add(<<EMPTY_NAME>>.1);
			}
			if (<<EMPTY_NAME>>.2 != null)
			{
				foreach (1445 3 in <<EMPTY_NAME>>.2.3)
				{
					3.9 += num;
					3.10 += num;
				}
				this.18.12(<<EMPTY_NAME>>.2);
				this.4.Add(<<EMPTY_NAME>>.2);
			}
			if (!<<EMPTY_NAME>>.3)
			{
				num += 300;
			}
		}
		return num;
	}

	// Token: 0x060024D6 RID: 9430 RVA: 0x000A7E44 File Offset: 0x000A6044
	protected virtual void ShowScore(2241 1, int? 2)
	{
		if (1 == null)
		{
			return;
		}
		2 = new int?(2 ?? 1.GetScore());
		foreach (1433 3 in this.4)
		{
			3.16(100, (1046)0, 0);
			3.5 = false;
		}
		this.4.Clear();
		this.5.Clear();
		this.16 = 1;
		if (1.39 != null || 1.9 == 2147.OsuMania)
		{
			this.22 = string.Format("{0:0000000}", 2);
		}
		else
		{
			this.22 = string.Format("{0:00000000}", 2);
		}
		this.14 = new 1353(string.Empty, 2630.5.FontScore, (float)2630.5.FontScoreOverlap, (1376)6, 1065.Centre, (1044)0, new 208(220f, 94f), 0.8f, true, 198.White, true, (1416)7);
		this.14.15 = (2630.21() ? 1.3f : 1.05f);
		if (2630.21())
		{
			this.14.100 = -2f;
		}
		this.14.96 = true;
		this.18.12(this.14);
		this.4.Add(this.14);
		2566 4;
		switch (1.9)
		{
		case 2147.Osu:
			this.5.Add(new 2566("hit300", new 208(40f, 160f), string.Format("{0}x", 1.2), false, 0, 1065.Centre));
			this.5.Add(new 2566("hit100", new 208(40f, 220f), string.Format("{0}x", 1.1), false, 0, 1065.Centre));
			this.5.Add(new 2566("hit50", new 208(40f, 280f), string.Format("{0}x", 1.3), false, 0, 1065.Centre));
			this.5.Add(new 2566("hit300g", new 208(240f, 160f), string.Format("{0}x", 1.4), false, 0, 1065.Centre));
			this.5.Add(new 2566("hit100k", new 208(240f, 220f), string.Format("{0}x", 1.5), false, 0, 1065.Centre));
			this.5.Add(new 2566("hit0", new 208(240f, 280f), string.Format("{0}x", 1.6), false, 0, 1065.Centre));
			break;
		case 2147.Taiko:
			this.5.Add(new 2566("taiko-hit300", new 208(40f, 160f), string.Format("{0}x", (int)(1.2 - 1.4)), false, 0, 1065.Centre));
			this.5.Add(new 2566("taiko-hit100", new 208(40f, 220f), string.Format("{0}x", (int)(1.1 - 1.5)), false, 0, 1065.Centre));
			this.5.Add(new 2566("taiko-hit0", new 208(40f, 280f), string.Format("{0}x", 1.6), false, 0, 1065.Centre));
			this.5.Add(new 2566("taiko-hit300g", new 208(240f, 160f), string.Format("{0}x", 1.4), false, 0, 1065.Centre));
			this.5.Add(new 2566("taiko-hit100k", new 208(240f, 220f), string.Format("{0}x", 1.5), false, 0, 1065.Centre));
			break;
		case 2147.CatchTheBeat:
			this.5.Add(new 2566("fruit-orange-overlay", new 208(40f, 160f), null, true, 0, 1065.Centre));
			4 = new 2566("fruit-orange", new 208(40f, 160f), string.Format("{0}x", 1.2), false, 0, 1065.Centre);
			4.1.6 = 198.Orange;
			this.5.Add(4);
			4 = new 2566("fruit-drop", new 208(40f, 220f), string.Format("{0}x", 1.1), false, 0, 1065.Centre);
			4.3(1f, 0.6f);
			4.1.6 = 198.YellowGreen;
			this.5.Add(4);
			4 = new 2566("fruit-drop", new 208(40f, 280f), string.Format("{0}x", 1.3), false, 0, 1065.Centre);
			4.3(1f, 0.4f);
			4.2(4f);
			4.1.6 = 198.LightBlue;
			this.5.Add(4);
			4 = new 2566("fruit-orange-overlay", new 208(240f, 160f), null, true, 0, 1065.Centre);
			4.3(1f, 0.4f);
			4.2(0.8f);
			this.5.Add(4);
			4 = new 2566("hit0", new 208(240f, 160f) - new 208(20f, 20f), null, true, 0, 1065.Centre);
			4.3(0.7f, 0.2f);
			this.5.Add(4);
			4 = new 2566("fruit-orange", new 208(240f, 160f), string.Format("{0}x", 1.6), false, 0, 1065.Centre);
			4.3(1f, 0.4f);
			4.2(0.8f);
			4.1.6 = 198.LightGray;
			this.5.Add(4);
			break;
		case 2147.OsuMania:
			this.5.Add(new 2566("mania-hit300", new 208(40f, 160f), string.Format("{0}x", 1.2), false, 0, 1065.Centre));
			this.5.Add(new 2566("mania-hit200", new 208(40f, 220f), string.Format("{0}x", 1.5), false, 0, 1065.Centre));
			this.5.Add(new 2566("mania-hit50", new 208(40f, 280f), string.Format("{0}x", 1.3), false, 0, 1065.Centre));
			this.5.Add(new 2566("mania-hit300g", new 208(240f, 160f), string.Format("{0}x", 1.4), false, 0, 1065.Centre));
			this.5.Add(new 2566("mania-hit100", new 208(240f, 220f), string.Format("{0}x", 1.1), false, 0, 1065.Centre));
			this.5.Add(new 2566("mania-hit0", new 208(240f, 280f), string.Format("{0}x", 1.6), false, 0, 1065.Centre));
			break;
		}
		int num = 2630.21() ? 20 : 8;
		4 = new 2566("ranking-maxcombo", new 208(5f, (float)(320 - num)), null, false, 0, 1065.TopLeft);
		4.3(1f, 1f);
		4.1.2 = 0.81f;
		4.1(string.Format("{0}x", 1.13), new 208(15f, 330f));
		4.2.2 = 0.8f;
		this.5.Add(4);
		4 = new 2566("ranking-accuracy", new 208(182f, (float)(320 - num)), null, false, 0, 1065.TopLeft);
		4.3(1f, 1f);
		4.1.2 = 0.81f;
		4.1(string.Format("{0:0.00}%", 1.CalculateAccuracy() * 100f), new 208(194f, 330f));
		4.2.2 = 0.8f;
		this.5.Add(4);
		string text = string.Empty;
		if (1.27 != null && 1.27.Count != 0)
		{
			List<double> list = this.3(1.27);
			if (list != null)
			{
				text = string.Format("Accuracy:\nError: {0:0.00}ms - {1:0.00}ms avg\nUnstable Rate: {2:0.00}\n", new object[]
				{
					list[0],
					list[1],
					list[4] * 10.0,
					list[6],
					list[5]
				});
				double num2 = 1939.17(1.8, 1.44);
				if (Math.Abs(num2 - 1.0) > 0.0001)
				{
					text += string.Format(1662.18, "Converted Unstable Rate: {0:0.00} ({1:0.##}x)\n", list[4] * 10.0 / num2, num2);
				}
			}
		}
		if (1.28 != null && 1.28.Count != 0)
		{
			List<double> list2 = this.3(1.28);
			if (list2 != null)
			{
				text += string.Format("Spin:\nSpeed: {0:000}(Max:{1:000}rpm)\nUnstable Rate: {2:0.00}\n", list2[2], list2[5], list2[4] * 2.0);
			}
		}
		if (text != string.Empty)
		{
			this.28.10 = true;
			this.28.52 = text;
		}
		if (1.22)
		{
			4 = new 2566("ranking-perfect", new 208((float)(2630.21() ? 260 : 200), 430f), null, false, 300, 1065.Centre);
			4.3(1.1f, 1f);
			4.1.2 = 0.99f;
			this.5.Add(4);
		}
		int num3 = this.ScheduleStatEntries();
		this.ShowGrade(num3);
		if (this.13 != null)
		{
			this.18.Remove(this.13);
			this.13.Dispose();
		}
		float 5 = this.28.7.X + (float)(2630.21() ? 5 : 10);
		float 6 = this.28.7.Y + (float)(2630.21() ? 5 : 10);
		this.13 = new 2565(this.21, 4000, 1, new 1058(5, 6, 186f, 86f));
		this.18.12(this.13);
		this.ShowMods();
		this.15 = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, 208.Zero, 1f, false, 198.TransparentWhite, null);
		this.15.66 = false;
		this.15.28 = true;
		this.15.20 = new 208((float)1662.70.1, (float)1662.70.2);
		1445 item = new 1445(1456.Fade, 0.5f, 0f, this.21 + num3 + 1000, this.21 + num3 + 2400, (1046)0);
		this.15.3.Add(item);
		this.19.12(this.15);
		this.4.Add(this.15);
	}

	// Token: 0x060024D7 RID: 9431 RVA: 0x000A8AD8 File Offset: 0x000A6CD8
	internal new List<double> 3(List<int> 1)
	{
		if (1 == null || 1.Count == 0)
		{
			return null;
		}
		List<double> list = new List<double>(4);
		double num = 0.0;
		double num2 = 0.0;
		double num3 = 0.0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int num7 = int.MaxValue;
		for (int i = 0; i < 1.Count; i++)
		{
			if (1[i] > num6)
			{
				num6 = 1[i];
			}
			if (1[i] < num7)
			{
				num7 = 1[i];
			}
			num3 += (double)1[i];
			if (1[i] >= 0)
			{
				num += (double)1[i];
				num4++;
			}
			else
			{
				num2 += (double)1[i];
				num5++;
			}
		}
		double num8 = num3 / (double)1.Count;
		double num9 = 0.0;
		for (int j = 0; j < 1.Count; j++)
		{
			num9 += Math.Pow((double)1[j] - num8, 2.0);
		}
		num9 /= (double)1.Count;
		list.Add((num5 == 0) ? 0.0 : (num2 / (double)num5));
		list.Add((num4 == 0) ? 0.0 : (num / (double)num4));
		list.Add(num8);
		list.Add(num9);
		list.Add(Math.Sqrt(num9));
		list.Add((double)num6);
		list.Add((double)num7);
		return list;
	}

	// Token: 0x060024D8 RID: 9432 RVA: 0x000A8C60 File Offset: 0x000A6E60
	protected virtual void ShowMods()
	{
		int num = 0;
		float num2 = 0f;
		int num3 = 40;
		int num4 = -1;
		foreach (object obj in Enum.GetValues(typeof(2023)))
		{
			2023 <<EMPTY_NAME>> = (2023)obj;
			2023 2 = this.16.8;
			2023 3 = <<EMPTY_NAME>>;
			if ((2 & 3) > 2023.None)
			{
				if (<<EMPTY_NAME>> == 2023.DoubleTime)
				{
					2023 4 = this.16.8;
					3 = 2023.Nightcore;
					if ((4 & 3) > 2023.None)
					{
						continue;
					}
				}
				if (<<EMPTY_NAME>> == 2023.SuddenDeath)
				{
					2023 5 = this.16.8;
					3 = 2023.Perfect;
					if ((5 & 3) > 2023.None)
					{
						continue;
					}
				}
				1445 6 = new 1445(1456.Scale, 2f, 1f, 1662.33 + num, 1662.33 + num + 400, (1046)0);
				1445 7 = new 1445(1456.Fade, 0f, 1f, 1662.33 + num, 1662.33 + num + 400, (1046)0);
				6.15 = (1046)1;
				7.15 = (1046)1;
				1433 8 = new 1433(1455.2("selection-mod-" + <<EMPTY_NAME>>.ToString().ToLower(), (1416)7, null), (1376)8, 1065.Centre, (1044)0, new 208((float)num3, 260f), 0.92f + num2, true, 198.TransparentWhite, null);
				8.3.Add(6);
				8.3.Add(7);
				if (<<EMPTY_NAME>> == 2023.DoubleTime || <<EMPTY_NAME>> == 2023.Nightcore || <<EMPTY_NAME>> == 2023.HalfTime)
				{
					num4 = num3;
					8.10 = true;
					8.52 = 2019.14(<<EMPTY_NAME>>, false) + ": " + 1939.22(1939.17(this.16.8, this.16.44));
				}
				if (<<EMPTY_NAME>> == 2023.Hidden && this.16.46)
				{
					8.10 = true;
					8.52 = "Hidden: approach circles only";
				}
				this.18.12(8);
				num += 500;
				num2 += 1E-05f;
				num3 += 20;
			}
		}
		if (this.16.43 != null)
		{
			1433 9 = new 1433(1455.2("selection-mod-difficultyadjust", (1416)7, null), (1376)8, 1065.Centre, (1044)0, new 208((float)num3, 260f), 0.92f + num2, true, 198.TransparentWhite, null);
			9.3.Add(new 1445(1456.Scale, 2f, 1f, 1662.33 + num, 1662.33 + num + 400, (1046)0)
			{
				15 = (1046)1
			});
			9.3.Add(new 1445(1456.Fade, 0f, 1f, 1662.33 + num, 1662.33 + num + 400, (1046)0)
			{
				15 = (1046)1
			});
			9.10 = true;
			9.52 = (this.16.43.IsEmpty ? "Difficulty Adjust" : ("Difficulty Adjust: " + this.16.43.1()));
			this.18.12(9);
			num += 500;
			num2 += 1E-05f;
			num3 += 20;
		}
		if (this.16.45)
		{
			1433 10 = new 1433(1455.2("selection-mod-nonotelock", (1416)7, null), (1376)8, 1065.Centre, (1044)0, new 208((float)num3, 260f), 0.92f + num2, true, 198.TransparentWhite, null);
			10.3.Add(new 1445(1456.Scale, 2f, 1f, 1662.33 + num, 1662.33 + num + 400, (1046)0)
			{
				15 = (1046)1
			});
			10.3.Add(new 1445(1456.Fade, 0f, 1f, 1662.33 + num, 1662.33 + num + 400, (1046)0)
			{
				15 = (1046)1
			});
			10.10 = true;
			10.52 = "No Notelock: played with osu!lazer's note lock";
			this.18.12(10);
			num += 500;
			num2 += 1E-05f;
			num3 += 20;
		}
		if (this.16.47)
		{
			1433 11 = new 1433(1455.2("selection-mod-practice", (1416)7, null), (1376)8, 1065.Centre, (1044)0, new 208((float)num3, 260f), 0.92f + num2, true, 198.TransparentWhite, null);
			11.3.Add(new 1445(1456.Scale, 2f, 1f, 1662.33 + num, 1662.33 + num + 400, (1046)0)
			{
				15 = (1046)1
			});
			11.3.Add(new 1445(1456.Fade, 0f, 1f, 1662.33 + num, 1662.33 + num + 400, (1046)0)
			{
				15 = (1046)1
			});
			11.10 = true;
			11.52 = ((this.16.49 != null && this.16.48 != null) ? ("Practice: the segment " + 2552.18(this.16.48.Value) + " - " + 2552.18(this.16.49.Value)) : "Practice: scored from the last jump");
			this.18.12(11);
			num += 500;
			num2 += 1E-05f;
			num3 += 20;
		}
		if (this.16.52 != null)
		{
			List<string[]> list = new List<string[]>();
			if (this.16.52.5 != null)
			{
				list.Add(new string[]
				{
					"selection-mod-mirror",
					"Mirror: objects flipped (" + 1925.3(this.16.52.5.Value) + ")"
				});
			}
			if (this.16.52.7 != null)
			{
				list.Add(new string[]
				{
					"selection-mod-random",
					"Random: seed " + this.16.52.7.4.ToString() + ", angle sharpness " + this.16.52.7.5.ToString("0.0", 1662.18)
				});
			}
			if (this.16.52.6 == 1930.Alternate)
			{
				list.Add(new string[]
				{
					"selection-mod-alternate",
					"Alternate: the same button cannot be used twice in a row"
				});
			}
			else if (this.16.52.6 == 1930.SingleTap)
			{
				list.Add(new string[]
				{
					"selection-mod-singletap",
					"Single Tap: only one button can be used"
				});
			}
			foreach (string[] array in list)
			{
				1433 12 = new 1433(1455.2(array[0], (1416)7, null), (1376)8, 1065.Centre, (1044)0, new 208((float)num3, 260f), 0.92f + num2, true, 198.TransparentWhite, null);
				12.3.Add(new 1445(1456.Scale, 2f, 1f, 1662.33 + num, 1662.33 + num + 400, (1046)0)
				{
					15 = (1046)1
				});
				12.3.Add(new 1445(1456.Fade, 0f, 1f, 1662.33 + num, 1662.33 + num + 400, (1046)0)
				{
					15 = (1046)1
				});
				12.10 = true;
				12.52 = array[1];
				this.18.12(12);
				num += 500;
				num2 += 1E-05f;
				num3 += 20;
			}
		}
		float num5 = 281f;
		if (this.16.44 != null && num4 >= 0)
		{
			this.4(1939.22(1939.17(this.16.8, this.16.44)), (float)num4, num5, 60f, num);
			num5 += 14f;
		}
		if (this.16.43 != null && !this.16.43.IsEmpty)
		{
			this.4(this.16.43.1(), (40f + (float)(num3 - 20)) / 2f, num5, 300f, num);
		}
	}

	// Token: 0x060024D9 RID: 9433 RVA: 0x000A9508 File Offset: 0x000A7708
	private void 4(string 1, float 2, float 3, float 4, int 5)
	{
		1452 6 = new 1452(1, 14f, new 208(2 + 4 / 2f, 3), new 208(4, 0f), 0.93f, true, 198.White, true);
		6.41 = (1376)8;
		6.75 = (1066)2;
		6.54(true);
		6.16 = 0f;
		6.3.Add(new 1445(1456.Fade, 0f, 1f, 1662.33 + 5, 1662.33 + 5 + 400, (1046)0)
		{
			15 = (1046)1
		});
		this.18.12(6);
	}

	// Token: 0x060024DA RID: 9434 RVA: 0x000A95B0 File Offset: 0x000A77B0
	protected virtual void ShowGrade(int 1)
	{
		this.24 = new 1433(1455.2("ranking-" + this.16.CalculateGrade().ToString(), (1416)7, null), (1376)8, 1065.Centre, (1044)0, new 208(120f, (float)(2630.21() ? 200 : 170)), 0.9f, true, 198.TransparentWhite, null);
		1445 2 = new 1445(1456.Scale, 2f, 1f, this.21 + 1, this.21 + 1 + 1000, (1046)0);
		2.15 = (1046)2;
		this.24.3.Add(2);
		2 = new 1445(1456.Fade, 0f, 1f, this.21 + 1, this.21 + 1 + 1000, (1046)0);
		2.15 = (1046)2;
		this.24.3.Add(2);
		this.18.12(this.24);
		if (this.16.CalculateGrade() < 2236.C)
		{
			1433 3 = new 1433(1455.2("ranking-" + this.16.CalculateGrade().ToString(), (1416)7, null), (1376)8, 1065.Centre, (1044)0, new 208(120f, (float)(2630.21() ? 200 : 170)), 0.91f, true, 198.TransparentWhite, null);
			3.28 = true;
			2 = new 1445(1456.Scale, 1f, 1.05f, this.21 + 1 + 1000, this.21 + 1 + 3400, (1046)0);
			2.15 = (1046)1;
			3.3.Add(2);
			2 = new 1445(1456.Fade, 1f, 0f, this.21 + 1 + 1000, this.21 + 1 + 3400, (1046)0);
			2.15 = (1046)1;
			3.3.Add(2);
			this.18.12(3);
		}
	}

	// Token: 0x060024DB RID: 9435 RVA: 0x000A97B4 File Offset: 0x000A79B4
	public override void Initialize()
	{
		if (2486.88 == null && 1535.39 == null)
		{
			1662.89(1677.Menu, true, 0);
			return;
		}
		this.17 = new 1436(true);
		this.SelectScore();
		if (this.16 == null)
		{
			1662.89(1677.Menu, true, 0);
			return;
		}
		if (1272.5() == null || (!string.IsNullOrEmpty(this.16.10) && 1272.5().23 != this.16.10))
		{
			1262 <<EMPTY_NAME>> = 1272.8(this.16.10);
			if (<<EMPTY_NAME>> != null)
			{
				1272.SetCurrentBeatmap(<<EMPTY_NAME>>);
			}
		}
		if (1272.5() == null)
		{
			1662.89(1677.Menu, true, 0);
			return;
		}
		this.25 = new 1417(new 207(0, 0, 1662.70.1(), 1662.70.2()), new 208((float)1662.70.1(), (float)1662.70.2() * ((this.11 != null) ? 1.875f : 1f) - 60f - ((this.11 != null) ? 121.875f : 0f)), true, 60f, 1545.Default);
		this.18 = this.25.22;
		this.19 = new 1436(true);
		1354 7 = new 1354(delegate(object 1, EventArgs 2)
		{
			this.GoBack();
		}, true, false);
		this.19.14<1433>(7.1);
		bool 3 = 1535.40;
		object 4 = 1535.37;
		lock (4)
		{
			1535.2(false);
			1535.40 = false;
			1535.41 = 0;
		}
		this.21 = 1662.33 + 300;
		1549.1(new 1549.1550(this.1));
		1535.40((1082)8, new 1081(this.OnPointerPressed), 1545.Default, (1559)0);
		this.23 = new 1433(1455.2("ranking-background-overlay", (1416)1, null), (1376)8, 1065.Centre, (1044)0, new 208(180f, (float)(2630.21() ? 200 : 170)), 0.05f, true, 198.White, null);
		this.23.28 = true;
		this.23.3.Add(new 1445(1456.Rotation, 0f, 6.2831855f, 1662.33, 1662.33 + 20000, (1046)0));
		this.23.3[0].17 = true;
		this.17.12(this.23);
		1433 5 = new 1433(1455.2("ranking-title", (1416)7, null), (1376)8, 1065.TopRight, (1044)0, new 208(20f, 0f), 0.991f, true, 198.White, null);
		5.54 = 2630.21();
		this.18.12(5);
		this.CreateGraphPanel();
		this.22 = string.Format("{0:00000000}", this.16.GetScore());
		1433 6 = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, new 208(0f, 0f), 0.99f, true, 198.Black, null);
		6.16 = 0.8f;
		6.20 = new 208((float)1662.70.1() * 1.6f, 96f);
		6.54 = true;
		this.18.12(6);
		this.CreateInfoAndButtons();
		this.ShowScore(this.16, null);
		base.Initialize();
		if (!this.12 || this.11 != null)
		{
			this.ShowRankingDialog();
		}
		if (this.12 && !3)
		{
			this.11(false);
			return;
		}
		if (this.16.29.FindAll(new Predicate<bool>(2568.2569.instance.1)).Count > this.16.29.FindAll(new Predicate<bool>(2568.2569.instance.7)).Count)
		{
			this.6 = 1226.24("applause", 100, (1416)7, false);
		}
	}

	// Token: 0x060024DC RID: 9436 RVA: 0x000A9BC4 File Offset: 0x000A7DC4
	protected virtual void CreateGraphPanel()
	{
		this.28 = new 1433(1455.2("ranking-graph", (1416)7, null), (1376)6, 1065.TopLeft, (1044)0, new 208(160f, (float)(2630.21() ? 380 : 360)), 0.8f, true, 198.White, null);
		this.18.12(this.28);
		1433 <<EMPTY_NAME>> = new 1433(1455.2("ranking-panel", (1416)7, null), (1376)6, 1065.TopLeft, (1044)0, new 208(0f, (float)(2630.21() ? 64 : 46)), 0.2f, true, 198.White, null);
		this.18.12(<<EMPTY_NAME>>);
	}

	// Token: 0x060024DD RID: 9437 RVA: 0x000A9C6C File Offset: 0x000A7E6C
	protected virtual void SelectScore()
	{
		this.12 = 1535.1();
		if (this.12)
		{
			if (1535.40 && 2486.88 != null)
			{
				this.16 = 2486.88;
				return;
			}
			this.16 = 1535.39;
			if (2486.88 != null && 2486.88.27 != null)
			{
				this.16.27 = new List<int>();
				this.16.27.AddRange(2486.88.27);
			}
			if (this.16.12)
			{
				List<2241> list = 2230.3(this.16.10, this.16.9);
				if (list != null)
				{
					2241 <<EMPTY_NAME>> = list.Find(new Predicate<2241>(this.12));
					if (<<EMPTY_NAME>> != null && <<EMPTY_NAME>>.8())
					{
						this.16 = <<EMPTY_NAME>>;
					}
				}
			}
			this.16.27();
			if (this.16.24 != null)
			{
				this.16.24(this.16.24);
			}
			if (this.16.18 && 2237.2(this.16, 1272.5()))
			{
				this.11 = new 1711(this, true);
				return;
			}
		}
		else
		{
			this.5(true);
		}
	}

	// Token: 0x060024DE RID: 9438 RVA: 0x000A9DA4 File Offset: 0x000A7FA4
	protected void 5(bool 1)
	{
		this.16 = 2486.88;
		if (!this.16.18 || this.12)
		{
			return;
		}
		2023 2 = 2486.88.8;
		2023 3 = 2023.Relax;
		if ((2 & 3) > 2023.None && !1304.31.1())
		{
			return;
		}
		2023 4 = 2486.88.8;
		3 = 2023.Relax2;
		if ((4 & 3) > 2023.None)
		{
			return;
		}
		if (1272.5().68 != null)
		{
			if (this.16.GetScore() > 1272.5().68.GetScore())
			{
				1272.5().73(this.16.CalculateGrade());
			}
		}
		else if (1272.5().72() == 2236.N)
		{
			1272.5().73(this.16.CalculateGrade());
		}
		else
		{
			List<2241> list = 2230.3(1272.5().23, this.16.9);
			if (list == null || list.Count == 0)
			{
				if (this.16.CalculateGrade() < 1272.5().72())
				{
					1272.5().73(this.16.CalculateGrade());
				}
			}
			else if (list.FindAll((2241 1) => 1.GetScore() >= this.16.GetScore()).Count == 0)
			{
				1272.5().73(this.16.CalculateGrade());
			}
		}
		if (5)
		{
			this.11 = new 1711(this, false);
			return;
		}
		2230.5(this.16, false, true);
	}

	// Token: 0x060024DF RID: 9439 RVA: 0x000A9F24 File Offset: 0x000A8124
	protected virtual void CreateInfoAndButtons()
	{
		1452 <<EMPTY_NAME>> = new 1452(1272.5().49, 22f, new 208(0f, 0f), 208.Zero, 0.991f, true, 198.White, false);
		<<EMPTY_NAME>>.54 = true;
		this.18.12(<<EMPTY_NAME>>);
		<<EMPTY_NAME>> = new 1452("Beatmap by " + 1272.5().43, 16f, new 208(1f, 20f), 208.Zero, 0.991f, true, 198.White, false);
		<<EMPTY_NAME>>.54 = true;
		this.18.12(<<EMPTY_NAME>>);
		<<EMPTY_NAME>> = new 1452(string.Format("Played by {0} on {1}.", this.16.23, this.16.7.ToLocalTime()), 16f, new 208(1f, 34f), 208.Zero, 0.991f, true, 198.White, false);
		<<EMPTY_NAME>>.54 = true;
		this.18.12(<<EMPTY_NAME>>);
		float num = 360f;
		if (!this.12)
		{
			1381 4 = null;
			if (!2630.21())
			{
				4 = 1455.2("ranking-retry", (1416)7, null);
			}
			if (4 == null)
			{
				4 = (1455.2("ranking-retry", (1416)2, null) ?? 1455.2("pause-retry", (1416)7, null));
			}
			this.8 = new 1433(4, (1376)8, 1065.CentreRight, (1044)0, new 208(0f, num), 0.94f, true, new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 178), null);
			this.8.10 = true;
			this.8.42 = new 1445(1456.Fade, 0.7f, 1f, 0, 200, (1046)0);
			this.8.3(delegate(object 1, EventArgs 2)
			{
				this.11(false);
				if (!this.10)
				{
					1226.28("menuhit", 1f, (1416)3);
					1662.SetMode(1677.Play, false);
				}
			});
			this.18.12(this.8);
			num += 60f;
		}
		bool flag = !this.16.12 && this.16.16 > 0L && !261.FullyOffline;
		if (((this.16.26 != null && this.16.26.Count > 0) || this.16.25 != null || this.16.8() || this.16.11() || flag) && !1662.47)
		{
			1381 3 = null;
			if (!2630.21())
			{
				3 = 1455.2("ranking-replay", (1416)7, null);
			}
			if (3 == null)
			{
				3 = 1455.2("pause-replay", (1416)7, null);
			}
			this.7 = new 1433(3, (1376)8, 1065.CentreRight, (1044)0, new 208(0f, num), 0.94f, true, new 198(byte.MaxValue, byte.MaxValue, byte.MaxValue, 178), null);
			this.7.10 = true;
			this.7.42 = new 1445(1456.Fade, 0.7f, 1f, 0, 200, (1046)0);
			this.7.3(new EventHandler(this.6));
			this.18.12(this.7);
			num += 60f;
		}
		if (this.11 != null)
		{
			this.27 = new 1361("▼ Online Ranking ▼", new 208((float)(1662.70.1() / 2 - 100), (float)(1662.70.2() - 26)), new 208(200f, 30f), 0.95f, 198.BlueViolet, new EventHandler(this.13), true, false, null, false);
			this.19.14<1433>(this.27.1);
		}
	}

	// Token: 0x060024E0 RID: 9440 RVA: 0x000AA2D9 File Offset: 0x000A84D9
	protected void 6(object 1, EventArgs 2)
	{
		if (!this.10 && this.11(false))
		{
			this.7();
		}
	}

	// Token: 0x060024E1 RID: 9441 RVA: 0x000AA2F4 File Offset: 0x000A84F4
	protected void 7()
	{
		if (this.16.12)
		{
			this.9(new 2152(this.10));
			return;
		}
		if (this.16.26 == null || this.16.26.Count == 0)
		{
			if (this.16.25 == null)
			{
				this.16.27();
			}
			this.16.22();
		}
		if (this.16.26 != null && this.16.26.Count > 0)
		{
			this.8(this.16.8() ? ("replay file " + Path.GetFileName(this.16.7())) : "kept in memory");
			1226.28("menuhit", 1f, (1416)3);
			1535.2(true);
			1535.39 = this.16;
			2486.20 = this.16.38;
			1662.SetMode(1677.Play, false);
			return;
		}
		if (this.16.16 > 0L && !261.FullyOffline)
		{
			this.9(new 2152(this.10));
			return;
		}
		1763.5("This score has no replay data saved!", 198.Red, 5000, null);
	}

	// Token: 0x060024E2 RID: 9442 RVA: 0x000AA434 File Offset: 0x000A8634
	private void 8(string 1)
	{
		1262 2 = 1272.5();
		IFormatProvider invariantCulture = CultureInfo.InvariantCulture;
		string format = "Replay: {0} on {1} (play's beatmap {2}, playing {3}), mods {4}, {5} frames, replay version {6}, set {7:u}, from {8}";
		object[] array = new object[9];
		array[0] = this.16.23;
		array[1] = (((2 != null) ? 2.49 : null) ?? "?");
		array[2] = this.16.10;
		array[3] = (((2 != null) ? 2.23 : null) ?? "?");
		array[4] = this.16.8;
		int num = 5;
		List<1840> list = this.16.26;
		array[num] = ((list != null) ? list.Count : 0);
		array[6] = this.16.34;
		array[7] = this.16.7;
		array[8] = 1;
		1338.5(string.Format(invariantCulture, format, array), 1341.Runtime, (1114)2);
	}

	// Token: 0x060024E3 RID: 9443 RVA: 0x000AA507 File Offset: 0x000A8707
	private void 9(2152 1)
	{
		1763.2("Downloading replay data...", 10000, (1389)0);
		this.18.38 = 0.5f;
		this.10 = true;
		this.16.33(1);
		this.16.21();
	}

	// Token: 0x060024E4 RID: 9444 RVA: 0x000AA548 File Offset: 0x000A8748
	protected void 10(object 1)
	{
		this.16.34(new 2152(this.10));
		this.10 = false;
		if (this.16.26 != null && this.16.26.Count > 0)
		{
			this.8("downloaded (online id " + this.16.16.ToString() + ")");
			1763.3();
			1226.28("menuhit", 1f, (1416)3);
			1535.2(true);
			1535.39 = this.16;
			2486.20 = this.16.38;
			1662.SetMode(1677.Play, false);
			return;
		}
		1763.2("Replay data is not available for this play!", 2000, (1389)0);
		this.18.38 = 0f;
		this.7.16(100, (1046)0, 0);
		this.7.10 = false;
	}

	// Token: 0x060024E5 RID: 9445 RVA: 0x000AA632 File Offset: 0x000A8832
	protected virtual bool OnPointerPressed(object 1, EventArgs 2)
	{
		this.11(false);
		return false;
	}

	// Token: 0x060024E6 RID: 9446 RVA: 0x000AA640 File Offset: 0x000A8840
	protected bool 11(bool 1)
	{
		if (1662.33 - this.21 < 5000 && !this.9)
		{
			this.9 = true;
			this.21 = 1662.33 - 7000;
			List<1371> obj = this.18.28;
			lock (obj)
			{
				foreach (1371 2 in this.18.28)
				{
					foreach (1445 3 in 2.3)
					{
						if (!3.17)
						{
							3.9 = this.21 - 200;
							3.10 = this.21 - 100;
						}
					}
				}
			}
			this.19.Remove(this.15);
			return false;
		}
		if (1)
		{
			this.GoBack();
		}
		return true;
	}

	// Token: 0x060024E7 RID: 9447 RVA: 0x000AA77C File Offset: 0x000A897C
	protected virtual void GoBack()
	{
		1226.28("menuback", 1f, (1416)3);
		1662.SetMode(1677.SelectPlay, false);
	}

	// Token: 0x060024E8 RID: 9448 RVA: 0x000AA796 File Offset: 0x000A8996
	protected virtual void CloseRankingDialog()
	{
		if (this.11 != null)
		{
			this.11.Close(false);
		}
	}

	// Token: 0x060024E9 RID: 9449 RVA: 0x000AA7AC File Offset: 0x000A89AC
	protected virtual void ShowRankingDialog()
	{
		if (this.11 != null && !this.11.4)
		{
			this.11.Show();
			this.11.OnShown();
			this.11.7.33 = new 208(0f, (float)1662.70.2());
			this.25.32(this.11.7);
			this.11.34.33 = this.11.7.33;
			this.25.33(this.11.34);
		}
	}

	// Token: 0x060024EA RID: 9450 RVA: 0x000AA85B File Offset: 0x000A8A5B
	private bool 12(2241 1)
	{
		return 1.16 == this.16.16;
	}

	// Token: 0x060024EB RID: 9451 RVA: 0x000AA870 File Offset: 0x000A8A70
	private void 13(object 1, EventArgs 2)
	{
		this.25.25((float)1662.70.2() * 0.875f, -0.99f);
	}

	// Token: 0x040019D3 RID: 6611
	protected readonly List<1433> 4 = new List<1433>();

	// Token: 0x040019D4 RID: 6612
	protected List<2566> 5 = new List<2566>();

	// Token: 0x040019D5 RID: 6613
	private 1256 6;

	// Token: 0x040019D6 RID: 6614
	protected 1433 7;

	// Token: 0x040019D7 RID: 6615
	protected 1433 8;

	// Token: 0x040019D8 RID: 6616
	protected bool 9;

	// Token: 0x040019D9 RID: 6617
	protected bool 10;

	// Token: 0x040019DA RID: 6618
	private 1711 11;

	// Token: 0x040019DB RID: 6619
	protected bool 12;

	// Token: 0x040019DC RID: 6620
	protected 2565 13;

	// Token: 0x040019DD RID: 6621
	protected 1353 14;

	// Token: 0x040019DE RID: 6622
	protected 1433 15;

	// Token: 0x040019DF RID: 6623
	protected internal 2241 16;

	// Token: 0x040019E0 RID: 6624
	protected 1436 17;

	// Token: 0x040019E1 RID: 6625
	protected 1436 18;

	// Token: 0x040019E2 RID: 6626
	protected 1436 19;

	// Token: 0x040019E3 RID: 6627
	protected 1433[] 20 = new 1433[10];

	// Token: 0x040019E4 RID: 6628
	protected int 21;

	// Token: 0x040019E5 RID: 6629
	protected string 22;

	// Token: 0x040019E6 RID: 6630
	private 1433 23;

	// Token: 0x040019E7 RID: 6631
	private 1433 24;

	// Token: 0x040019E8 RID: 6632
	private 1417 25;

	// Token: 0x040019E9 RID: 6633
	private const float 26 = 121.875f;

	// Token: 0x040019EA RID: 6634
	private 1361 27;

	// Token: 0x040019EB RID: 6635
	private 1433 28;

	// Token: 0x020004C0 RID: 1216
	[Serializable]
	public sealed class 2569
	{
		// Token: 0x060024EF RID: 9455 RVA: 0x00022391 File Offset: 0x00020591
		internal bool 1(bool 1)
		{
			return 1;
		}

		// Token: 0x060024F0 RID: 9456 RVA: 0x00034933 File Offset: 0x00032B33
		internal bool 2(bool 1)
		{
			return !1;
		}

		// Token: 0x040019EC RID: 6636
		public static readonly 2568.2569 instance = new 2568.2569();

		// Token: 0x040019ED RID: 6637
		public static Predicate<bool> predicate;

		// Token: 0x040019EE RID: 6638
		public static Predicate<bool> predicate2;
	}
}
