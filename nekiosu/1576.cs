using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

// Token: 0x02000A22 RID: 2594
public sealed class 1576 : IComparer<1576>, IComparable<1576>
{
	// Token: 0x060047FE RID: 18430 RVA: 0x001C9E97 File Offset: 0x001C8097
	public 1576(1573 1, bool 2) : this(1.5, 1.2(), 1.9, 2, 2 ? 1.25 : 1.26)
	{
		this.13 = 1;
		this.21 = 1.34;
	}

	// Token: 0x060047FF RID: 18431 RVA: 0x001C9ED8 File Offset: 0x001C80D8
	public 1576(int 1, string 2, string 3 = null, bool 4 = false, int 5 = 0) : this()
	{
		this.6(2 = 1576.9(2));
		this.12 = 5;
		this.8(3);
		this.18 = 1;
		this.19 = 4;
		Directory.CreateDirectory(1576.4());
		this.11 = Path.GetFileName(2);
		string path = Path.Combine(1576.4(), this.11);
		try
		{
			File.Delete(path);
		}
		catch
		{
			return;
		}
		this.20 = path;
	}

	// Token: 0x06004800 RID: 18432 RVA: 0x001C9F64 File Offset: 0x001C8164
	private void 1(1637 1)
	{
		this.21 = 1;
		this.22.Add(1);
		this.2 = new 1620(this.20, this.21.GetDownloadUrl(this.18, this.19));
		this.2.10(new 1621.1624(this.14));
		this.2.9(new 1621.1622(this.13));
		this.2.8(new 1621.1623(this.11));
		this.2.Start();
	}

	// Token: 0x06004801 RID: 18433 RVA: 0x001CA000 File Offset: 0x001C8200
	private bool 2(1620 1, Exception 2)
	{
		if (2 != null || !File.Exists(1.filePath))
		{
			return false;
		}
		if (this.5().EndsWith(".osz2", StringComparison.OrdinalIgnoreCase))
		{
			return new FileInfo(1.filePath).Length > 100L;
		}
		bool result;
		using (FileStream fileStream = File.OpenRead(1.filePath))
		{
			result = (fileStream.Length > 100L && fileStream.ReadByte() == 80 && fileStream.ReadByte() == 75);
		}
		return result;
	}

	// Token: 0x06004802 RID: 18434 RVA: 0x001CA094 File Offset: 0x001C8294
	private static string 3(1620 1)
	{
		string result;
		try
		{
			if (1 == null || !File.Exists(1.filePath) || new FileInfo(1.filePath).Length > 4096L)
			{
				result = null;
			}
			else
			{
				Match match = Regex.Match(File.ReadAllText(1.filePath), "\"error\"\\s*:\\s*\"([^\"]{1,200})\"");
				result = (match.Success ? match.Groups[1].Value : null);
			}
		}
		catch (Exception)
		{
			result = null;
		}
		return result;
	}

	// Token: 0x06004803 RID: 18435 RVA: 0x001CA118 File Offset: 0x001C8318
	protected 1576()
	{
		this.16 = (1580)Delegate.Combine(this.16, new 1580(this.17));
	}

	// Token: 0x06004804 RID: 18436 RVA: 0x001CA1C3 File Offset: 0x001C83C3
	internal static string 4()
	{
		return Path.Combine(1345.4(), "Downloads");
	}

	// Token: 0x06004805 RID: 18437 RVA: 0x001CA1D4 File Offset: 0x001C83D4
	public string 5()
	{
		return this.1;
	}

	// Token: 0x06004806 RID: 18438 RVA: 0x001CA1DC File Offset: 0x001C83DC
	protected void 6(string 1)
	{
		this.1 = 1;
	}

	// Token: 0x06004807 RID: 18439 RVA: 0x001CA1E5 File Offset: 0x001C83E5
	public string 7()
	{
		return this.3;
	}

	// Token: 0x06004808 RID: 18440 RVA: 0x001CA1ED File Offset: 0x001C83ED
	protected void 8(string 1)
	{
		this.3 = 1;
	}

	// Token: 0x06004809 RID: 18441 RVA: 0x001CA1F6 File Offset: 0x001C83F6
	public static string 9(string 1)
	{
		return string.Join("_", 1.Split(Path.GetInvalidFileNameChars()));
	}

	// Token: 0x0600480A RID: 18442 RVA: 0x001CA20D File Offset: 0x001C840D
	public int Compare(1576 1, 1576 2)
	{
		return 1.5().CompareTo(2.5());
	}

	// Token: 0x0600480B RID: 18443 RVA: 0x001CA220 File Offset: 0x001C8420
	internal bool 10(208 1)
	{
		if (this.9 == null)
		{
			this.9 = new List<1433>();
			this.4 = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, new 208(1.X, 1.Y), 0.79f, true, new 198(40, 40, 40, 150), null);
			this.4.15 = 1.6f;
			this.4.10 = true;
			this.4.42 = new 1445(this.4.6, new 198(60, 60, 60, 180), 0, 10);
			this.4.3(new EventHandler(this.18));
			this.4.20 = new 208(120f, 18f);
			this.6 = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, new 208(1.X + 5f, 1.Y + 10f), 0.8f, true, new 198(0, 0, 0, 150), null);
			this.6.15 = 1.6f;
			this.6.42 = new 1445(1456.Fade, 0.4f, 0.7f, 0, 600, (1046)0);
			this.6.20 = new 208(110f, 5f);
			this.5 = new 1433(1662.34, (1376)6, 1065.TopLeft, (1044)0, new 208(1.X + 5f, 1.Y + 10f), 0.81f, true, new 198(0, 78, 192, byte.MaxValue), null);
			this.5.15 = 1.6f;
			this.5.42 = new 1445(1456.Fade, 0.4f, 0.7f, 0, 600, (1046)0);
			this.5.20 = new 208(0f, 5f);
			this.7 = new 1452((this.10 == (1583)0) ? "waiting..." : "initialising", 9f, new 208(1.X + 5f, 1.Y + 8f), 0.82f, true, 198.White);
			this.8 = new 1452(this.7(), 9f, new 208(1.X + 5f, 1.Y), 0.81f, true, 198.White);
			this.9.Add(this.4);
			this.9.Add(this.6);
			this.9.Add(this.5);
			this.9.Add(this.7);
			this.9.Add(this.8);
			1731.8 = true;
			return true;
		}
		208 2 = this.9[0].7;
		foreach (1433 3 in this.9)
		{
			208 4 = 1 + (3.7 - 2);
			if (!(4 == 3.17) || 3.3.Count != 0)
			{
				3.19(4, 500, (1046)1);
				3.7 = 4;
			}
		}
		return false;
	}

	// Token: 0x0600480C RID: 18444 RVA: 0x001CA594 File Offset: 0x001C8794
	private void 11(object 1, long 2, long 3)
	{
		if (this.10 != (1583)3)
		{
			if (this.10 == (1583)1)
			{
				this.10 = (1583)2;
			}
			long num = Math.Max((long)this.12, 3);
			bool flag = num > 0L && 2 <= num;
			double num2 = flag ? ((double)2 / (double)num) : 0.0;
			this.7.SetText(flag ? string.Format("{0:0.0%} of {1}", num2, 1576.12(num)) : 1576.12(2));
			if (this.9 != null)
			{
				this.5.20.X = (float)num2 * 110f;
			}
			this.7.17 = new 208(this.5.7.X, this.5.17.Y - 2f);
			this.7.7 = this.7.17;
			this.15(num2);
		}
	}

	// Token: 0x0600480D RID: 18445 RVA: 0x001CA693 File Offset: 0x001C8893
	private static string 12(long 1)
	{
		return string.Format(1662.18, "{0:0.0} MB", (double)1 / 1048576.0);
	}

	// Token: 0x0600480E RID: 18446 RVA: 0x001CA6B8 File Offset: 0x001C88B8
	private void 13(1621 1, Exception 2)
	{
		1620 3 = 5 as 1620;
		if (this.23 || this.2(3, 2))
		{
			try
			{
				File.Delete(Path.Combine(1272.1, this.11));
			}
			catch
			{
				1763.4("osu!Direct download failed because the file already exists in your songs folder and is not writeable.");
			}
			bool flag = 2 == null;
			try
			{
				if (flag && File.Exists(3.filePath))
				{
					flag &= (new FileInfo(3.filePath).Length > 100L);
					if (!flag)
					{
						string text = File.ReadAllText(3.filePath);
						File.Delete(3.filePath);
						if (text.StartsWith("ERROR:"))
						{
							if (text.Replace("ERROR:", string.Empty).Trim() == "DOWNLOAD_NOT_AVAILABLE")
							{
								1763.5(1568.1(2679.OsuDirect_DownloadNotAvailable), 198.DarkRed, 4000, new 1189(this.19));
							}
							return;
						}
					}
					string text2 = Path.GetExtension(this.5()).ToLower();
					int num = Path.GetFullPath(1272.1).Length + this.5().Length - 248;
					if (num > 0)
					{
						if (num < this.5().Length - (text2.Length + 1) - 1)
						{
							this.6(this.5().Substring(0, this.5().Length - num - (text2.Length + 1)) + text2);
						}
						else
						{
							flag = false;
						}
					}
					if (flag)
					{
						if (!2486.14 || 1304.111.1())
						{
							1226.24("match-confirm", 100, (1416)3, false);
						}
						File.Move(3.filePath, Path.Combine(1272.1, this.11));
					}
					else
					{
						1763.4("osu!direct download failed. Please check your connection and try again!");
						File.Delete(3.filePath);
					}
				}
			}
			finally
			{
				this.16(flag);
			}
			return;
		}
		1637 4 = 1632.1().FirstOrDefault((1637 1) => !this.22.Contains(1));
		string text3 = 1576.3(3);
		try
		{
			File.Delete(3.filePath);
		}
		catch
		{
		}
		if (4 != null)
		{
			this.1(4);
			return;
		}
		string str = "osu!direct: ";
		string str2 = this.13.5.ToString();
		string str3 = " not downloaded: ";
		string str4;
		if ((str4 = text3) == null)
		{
			str4 = (((2 != null) ? 2.Message : null) ?? "not a beatmap archive");
		}
		1338.5(str + str2 + str3 + str4, 1341.Runtime, (1114)2);
		1763.5("The beatmap mirror could not give this beatmap" + ((text3 != null) ? (": " + text3) : ".") + "\nTry again later.", 198.OrangeRed, 6000, null);
		this.16(false);
	}

	// Token: 0x0600480F RID: 18447 RVA: 0x001CA9AC File Offset: 0x001C8BAC
	private void 14(1621 1)
	{
		this.14();
	}

	// Token: 0x06004810 RID: 18448 RVA: 0x001CA9B9 File Offset: 0x001C8BB9
	protected void 15()
	{
		this.10 = (1583)3;
		1731.8 = true;
	}

	// Token: 0x06004811 RID: 18449 RVA: 0x001CA9C8 File Offset: 0x001C8BC8
	protected void Cancel()
	{
		this.23 = true;
		1620 <<EMPTY_NAME>> = this.2;
		if (<<EMPTY_NAME>> != null)
		{
			<<EMPTY_NAME>>.18();
		}
		this.16(false);
	}

	// Token: 0x06004812 RID: 18450 RVA: 0x001CA9F0 File Offset: 0x001C8BF0
	internal void 16(bool 1)
	{
		if (1)
		{
			1689 2 = new 1689("Would you like to cancel the download?", true);
			2.7("Yes, cancel this download.", 198.OrangeRed, new EventHandler(this.20), true, false, true);
			2.7("No, keep downloading.", 198.YellowGreen, null, true, false, true);
			1662.25(2);
			return;
		}
		this.Cancel();
	}

	// Token: 0x06004813 RID: 18451 RVA: 0x001CAA4C File Offset: 0x001C8C4C
	public int CompareTo(1576 1)
	{
		return this.5().CompareTo(1.5());
	}

	// Token: 0x06004814 RID: 18452 RVA: 0x001CAA60 File Offset: 0x001C8C60
	internal void Start()
	{
		if (!this.17)
		{
			this.17 = true;
			this.10 = (1583)1;
			if (this.7 != null)
			{
				this.7.SetText("initialising");
			}
			if (this.20 != null && !this.23)
			{
				this.1(this.21);
			}
		}
	}

	// Token: 0x06004815 RID: 18453 RVA: 0x001CAAB7 File Offset: 0x001C8CB7
	private void 17(bool 1)
	{
		this.15();
	}

	// Token: 0x06004816 RID: 18454 RVA: 0x001CAABF File Offset: 0x001C8CBF
	private void 18(object 1, EventArgs 2)
	{
		this.16(true);
	}

	// Token: 0x06004817 RID: 18455 RVA: 0x001CAAC8 File Offset: 0x001C8CC8
	private void 19()
	{
		1662.69(string.Format(1661.8(), this.13.5));
	}

	// Token: 0x06004818 RID: 18456 RVA: 0x001CAAE9 File Offset: 0x001C8CE9
	private void 20(object 1, EventArgs 2)
	{
		this.16(false);
	}

	// Token: 0x0400350B RID: 13579
	private string 1;

	// Token: 0x0400350C RID: 13580
	protected 1620 2;

	// Token: 0x0400350D RID: 13581
	private string 3;

	// Token: 0x0400350E RID: 13582
	protected 1433 4;

	// Token: 0x0400350F RID: 13583
	protected 1433 5;

	// Token: 0x04003510 RID: 13584
	protected 1433 6;

	// Token: 0x04003511 RID: 13585
	protected 1452 7;

	// Token: 0x04003512 RID: 13586
	protected 1452 8;

	// Token: 0x04003513 RID: 13587
	internal List<1433> 9;

	// Token: 0x04003514 RID: 13588
	internal 1583 10;

	// Token: 0x04003515 RID: 13589
	protected string 11;

	// Token: 0x04003516 RID: 13590
	protected int 12;

	// Token: 0x04003517 RID: 13591
	internal 1573 13;

	// Token: 0x04003518 RID: 13592
	internal 1582 14 = delegate()
	{
	};

	// Token: 0x04003519 RID: 13593
	internal 1581 15 = delegate(double 1)
	{
	};

	// Token: 0x0400351A RID: 13594
	internal 1580 16 = new 1580(1576.1577.instance.1);

	// Token: 0x0400351B RID: 13595
	private bool 17;

	// Token: 0x0400351C RID: 13596
	private readonly int 18;

	// Token: 0x0400351D RID: 13597
	private readonly bool 19;

	// Token: 0x0400351E RID: 13598
	private string 20;

	// Token: 0x0400351F RID: 13599
	private 1637 21 = 1632.Current;

	// Token: 0x04003520 RID: 13600
	private readonly HashSet<1637> 22 = new HashSet<1637>();

	// Token: 0x04003521 RID: 13601
	private bool 23;

	// Token: 0x02000A23 RID: 2595
	[Serializable]
	public sealed class 1577
	{
		// Token: 0x0600481A RID: 18458 RVA: 0x00005ADD File Offset: 0x00003CDD
		internal void 1(bool 1)
		{
		}

		// Token: 0x04003522 RID: 13602
		public static readonly 1576.1577 instance = new 1576.1577();

		// Token: 0x04003523 RID: 13603
		public static 1582 downloadStartedHandler;

		// Token: 0x04003524 RID: 13604
		public static 1581 downloadProgressHandler;

		// Token: 0x04003525 RID: 13605
		public static 1580 downloadCompletedHandler;
	}
}
