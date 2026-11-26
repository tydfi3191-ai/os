using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;

// Token: 0x02000AE9 RID: 2793
public sealed class 1459 : 1474
{
	// Token: 0x06004DE8 RID: 19944 RVA: 0x001ED3BC File Offset: 0x001EB5BC
	public 1459() : base(1662.11)
	{
		this.Initialize();
		1662.72(delegate
		{
			this.6((456)1, null);
			this.8 = 0.6f;
			this.5 = true;
			if (1459.7 != null)
			{
				1459.7.17 = 208.Zero;
			}
		});
		1662.76(new 1189(this.2));
		1226.95(new 1189(this.11));
	}

	// Token: 0x06004DE9 RID: 19945 RVA: 0x001ED459 File Offset: 0x001EB659
	internal int 1()
	{
		if (1459.7 == null)
		{
			return 0;
		}
		return 1459.7.28();
	}

	// Token: 0x06004DEA RID: 19946 RVA: 0x001ED46E File Offset: 0x001EB66E
	private void 2()
	{
		if (1459.7 != null && 1459.7.GetTexture() != null)
		{
			1459.7.SetTexture(null);
		}
	}

	// Token: 0x06004DEB RID: 19947 RVA: 0x001ED48E File Offset: 0x001EB68E
	protected override void Dispose(bool 1)
	{
		this.3.Dispose();
		this.4.Dispose();
		base.Dispose(1);
	}

	// Token: 0x06004DEC RID: 19948 RVA: 0x001ED4AD File Offset: 0x001EB6AD
	public override void Initialize()
	{
		base.Initialize();
	}

	// Token: 0x06004DED RID: 19949 RVA: 0x001ED4B5 File Offset: 0x001EB6B5
	public override void Draw()
	{
		if ((double)this.4.7 < 0.99)
		{
			this.3.22();
			this.4.22();
		}
		base.Draw();
	}

	// Token: 0x06004DEE RID: 19950 RVA: 0x00005ADD File Offset: 0x00003CDD
	public void 3()
	{
	}

	// Token: 0x06004DEF RID: 19951 RVA: 0x001ED4EC File Offset: 0x001EB6EC
	public override void Update()
	{
		float num = 1f - this.8 - this.4.7;
		if (Math.Abs(num) > 0.001f)
		{
			this.4.7 += num * (float)Math.Min(1.0, 1662.10) * (2486.14 ? 0.1f : 0.04f);
		}
		else
		{
			this.4.7 = 1f - this.8;
		}
		if (1662.33 < 2470.53)
		{
			return;
		}
		if (this.5 && 1304.118 && !1662.47)
		{
			float <<EMPTY_NAME>> = 1535.6.X - (float)(1662.70.1 / 2);
			float 2 = 1535.6.Y - (float)(1662.70.2 / 2);
			this.4.29 = new 208(<<EMPTY_NAME>>, 2) / 1662.70.3() / 180f;
			if (1459.7 != null)
			{
				1459.7.20 = new 208(1.01f, 1.01f);
			}
		}
		else
		{
			this.4.29 = 208.Zero;
			if (1459.7 != null)
			{
				1459.7.20 = 208.One;
			}
		}
		this.3.7 = this.4.7;
		this.3.29 = this.4.29;
		base.Update();
	}

	// Token: 0x06004DF0 RID: 19952 RVA: 0x001ED67C File Offset: 0x001EB87C
	internal void 4(bool 1, bool 2)
	{
		if (2)
		{
			this.11 = false;
		}
		if (1459.7 != null)
		{
			1459.7.5 = false;
			1459.7.16(250, (1046)0, 0);
			1459.7 = null;
			if (1 && this.13 != null)
			{
				this.13();
			}
		}
	}

	// Token: 0x06004DF1 RID: 19953 RVA: 0x001ED6D2 File Offset: 0x001EB8D2
	internal void 5()
	{
		this.6(this.9, this.10);
	}

	// Token: 0x06004DF2 RID: 19954 RVA: 0x001ED6E6 File Offset: 0x001EB8E6
	internal void 6(456 1, 1459.1461 2)
	{
		if (1662.78 != 1677.Exit)
		{
			this.6 = null;
			this.11 = true;
			this.12++;
			this.Apply(1, 2, null, false);
		}
	}

	// Token: 0x06004DF3 RID: 19955 RVA: 0x001ED716 File Offset: 0x001EB916
	internal static string 7()
	{
		return Path.Combine(1345.4(), "Data", "bg");
	}

	// Token: 0x06004DF4 RID: 19956 RVA: 0x001ED72C File Offset: 0x001EB92C
	public static bool 8()
	{
		return !1459.17 && (1304.129.GetValue() == 1312.Always || 1304.129.GetValue() == 1312.Sometimes);
	}

	// Token: 0x06004DF5 RID: 19957 RVA: 0x001ED754 File Offset: 0x001EB954
	private void Apply(456 1, 1459.1461 2, 1381 3, bool 4)
	{
		1459.1467 5 = new 1459.1467();
		5.1 = this;
		5.2 = 1;
		5.3 = 2;
		if (!this.11 || 1662.78 == 1677.Exit)
		{
			return;
		}
		if (1459.7 != null && 1662.33 >= 2470.53)
		{
			1459.7.24(1f, 100, (1046)0);
		}
		if (3 == null || 3.5())
		{
			1662.17(new 1189(new 1459.1460
			{
				2 = 5,
				1 = this.12
			}.1));
			return;
		}
		this.6 = 3;
		if (1459.7 == null || this.6 != 1459.7.GetTexture() || this.10 != null || 5.3 != null || this.9 != 5.2)
		{
			this.4(false, false);
			1459.7 = this.9(5.2);
			1459.7.27 = 4;
			if (1662.33 >= 2470.53)
			{
				1459.7.15(50);
			}
			else
			{
				1459.7.16 = 0f;
			}
			this.10(1459.7, 5.2, 5.3);
			(((5.2 & (456)1) != (456)0) ? this.4 : this.3).12(1459.7);
			if (this.13 != null)
			{
				this.13();
			}
		}
	}

	// Token: 0x06004DF6 RID: 19958 RVA: 0x001ED8C4 File Offset: 0x001EBAC4
	private 1433 9(456 1)
	{
		if (this.6 == null || this.6.5())
		{
			this.6 = 1455.2("menu-background", (1416)1, null);
		}
		1376 2 = ((1 & (456)2) != (456)0) ? ((1376)4) : ((1376)10);
		return new 1433(this.6, 2, 1065.Centre, (1044)0, 208.Zero, 1436.32((float)1662.33), true, 198.White, null);
	}

	// Token: 0x06004DF7 RID: 19959 RVA: 0x001ED928 File Offset: 0x001EBB28
	private void 10(1433 1, 456 2, 1459.1461 3)
	{
		if (1 == null || this.6 == null)
		{
			return;
		}
		if ((2 & (456)2) != (456)0)
		{
			1.46((2 & (456)1) > (456)0, false);
		}
		else
		{
			1.15 = (float)1662.70.3 / (float)this.6.4();
			if ((float)1.39 * 1.15 * 1662.70.9() < (float)1662.70.1)
			{
				1.15 = (float)1662.70.1 / ((float)1.39 * 1662.70.9());
			}
		}
		if (3 != null)
		{
			3(1459.7);
		}
		this.9 = 2;
		this.10 = 3;
	}

	// Token: 0x06004DF8 RID: 19960 RVA: 0x001ED9D9 File Offset: 0x001EBBD9
	private void 11()
	{
		if (1662.78 == 1677.Menu && 1662.33 > 5000)
		{
			this.5();
		}
	}

	// Token: 0x04003A18 RID: 14872
	private 1436 3 = new 1436
	{
		24 = true
	};

	// Token: 0x04003A19 RID: 14873
	private 1436 4 = new 1436(true)
	{
		24 = true
	};

	// Token: 0x04003A1A RID: 14874
	internal bool 5 = true;

	// Token: 0x04003A1B RID: 14875
	internal 1381 6;

	// Token: 0x04003A1C RID: 14876
	internal static 1433 7;

	// Token: 0x04003A1D RID: 14877
	internal float 8 = 1f;

	// Token: 0x04003A1E RID: 14878
	private 456 9 = (456)1;

	// Token: 0x04003A1F RID: 14879
	private 1459.1461 10;

	// Token: 0x04003A20 RID: 14880
	private bool 11;

	// Token: 0x04003A21 RID: 14881
	private int 12;

	// Token: 0x04003A22 RID: 14882
	private 1189 13;

	// Token: 0x04003A23 RID: 14883
	private int 14 = -1;

	// Token: 0x04003A24 RID: 14884
	private int 15 = -1;

	// Token: 0x04003A25 RID: 14885
	private 1621 16;

	// Token: 0x04003A26 RID: 14886
	private static bool 17;

	// Token: 0x04003A27 RID: 14887
	private List<string> 18;

	// Token: 0x02000AEA RID: 2794
	public sealed class 1462
	{
		// Token: 0x04003A28 RID: 14888
		public 1381 1;

		// Token: 0x04003A29 RID: 14889
		public 1459.1466 2;
	}

	// Token: 0x02000AEB RID: 2795
	public sealed class 1464
	{
		// Token: 0x06004DFB RID: 19963 RVA: 0x001EDA28 File Offset: 0x001EBC28
		internal void 1()
		{
			if (this.2.1 == this.2.2.1.12)
			{
				this.2.2.1.Apply(this.2.2.2, this.2.2.3, this.1, false);
			}
		}

		// Token: 0x04003A2A RID: 14890
		public 1381 1;

		// Token: 0x04003A2B RID: 14891
		public 1459.1460 2;
	}

	// Token: 0x02000AEC RID: 2796
	public sealed class 1465
	{
		// Token: 0x06004DFD RID: 19965 RVA: 0x001EDA94 File Offset: 0x001EBC94
		internal void 1(1621 1, Exception 2)
		{
			if (2 != null)
			{
				1459.17 = true;
			}
			else
			{
				this.2.2.2.1.18 = this.1.27();
			}
			this.2.2.2.1.16 = null;
			this.2.2.2.1();
		}

		// Token: 0x04003A2C RID: 14892
		public 1625<List<string>> 1;

		// Token: 0x04003A2D RID: 14893
		public 1459.1464 2;
	}

	// Token: 0x02000AED RID: 2797
	public sealed class 1463
	{
		// Token: 0x06004DFF RID: 19967 RVA: 0x001EDB04 File Offset: 0x001EBD04
		internal void 1()
		{
			this.2.2.1.16 = null;
			this.2.2.1.Apply(this.2.2.2, this.2.2.3, this.1, true);
		}

		// Token: 0x04003A2E RID: 14894
		public 1381 1;

		// Token: 0x04003A2F RID: 14895
		public 1459.1466 2;
	}

	// Token: 0x02000AEE RID: 2798
	// (Invoke) Token: 0x06004E02 RID: 19970
	public delegate void 1461(1433 1);

	// Token: 0x02000AEF RID: 2799
	public sealed class 1466
	{
		// Token: 0x06004E05 RID: 19973 RVA: 0x001EDB64 File Offset: 0x001EBD64
		internal void 1(1621 1, Exception 2)
		{
			1459.1463 3 = new 1459.1463();
			3.2 = this;
			3.1 = this.2();
			1662.89.Schedule(new 1189(3.1), false);
		}

		// Token: 0x06004E06 RID: 19974 RVA: 0x001EDBA4 File Offset: 0x001EBDA4
		internal 1381 2()
		{
			1381 <<EMPTY_NAME>> = 1381.13(this.1, null);
			if (<<EMPTY_NAME>> != null)
			{
				<<EMPTY_NAME>>.11 = true;
				<<EMPTY_NAME>>.18();
			}
			else
			{
				try
				{
					File.Delete(this.1);
				}
				catch
				{
				}
			}
			return <<EMPTY_NAME>>;
		}

		// Token: 0x04003A30 RID: 14896
		public string 1;

		// Token: 0x04003A31 RID: 14897
		public 1459.1467 2;
	}

	// Token: 0x02000AF0 RID: 2800
	public sealed class 1467
	{
		// Token: 0x06004E08 RID: 19976 RVA: 0x001EDBF4 File Offset: 0x001EBDF4
		internal bool 1()
		{
			1459.1466 <<EMPTY_NAME>> = new 1459.1466();
			<<EMPTY_NAME>>.2 = this;
			if (this.1.18 == null)
			{
				return false;
			}
			if (this.1.16 == null)
			{
				if (1459.7 != null && 1459.7.16 <= 0f)
				{
					1381 texture = 1459.7.GetTexture();
					if (texture != null && texture.1.Contains("online_background_"))
					{
						goto IL_1C4;
					}
				}
				if (this.1.14 < 0)
				{
					this.1.14 = 1196.2(0, this.1.18.Count);
				}
				else
				{
					this.1.14 = Math.Max(0, (this.1.14 + 1) % this.1.18.Count);
				}
			}
			IL_1C4:
			string text = this.1.18[this.1.14];
			string text2 = 1459.7();
			string text3 = "online_background_";
			string s = text;
			byte[] array = 1209.2.GetBytes(s);
			string str = text3;
			string path = text2;
			1459.1466 2 = <<EMPTY_NAME>>;
			MD5 obj = 1209.1;
			string text4;
			lock (obj)
			{
				try
				{
					array = 1209.1.ComputeHash(array);
				}
				catch (Exception)
				{
					text4 = "fail";
					goto IL_28E;
				}
			}
			goto IL_23C;
			IL_D2:
			string text5;
			string str2 = text5;
			2.1 = Path.Combine(path, str + str2 + ".jpg");
			if (this.1.16 == null)
			{
				if (File.Exists(<<EMPTY_NAME>>.1))
				{
					1459.1462 loadNextClosure = new 1459.1462();
					loadNextClosure.2 = <<EMPTY_NAME>>;
					loadNextClosure.1 = loadNextClosure.2.2();
					if (loadNextClosure.1 == null)
					{
						return false;
					}
					1662.89.Schedule(delegate()
					{
						loadNextClosure.2.2.1.Apply(loadNextClosure.2.2.2, loadNextClosure.2.2.3, loadNextClosure.1, true);
					}, false);
					return true;
				}
				else
				{
					Directory.CreateDirectory(1459.7());
					this.1.16 = new 1620(<<EMPTY_NAME>>.1, text);
					this.1.16.9(new 1621.1622(<<EMPTY_NAME>>.1));
					this.1.16.Start();
				}
			}
			return true;
			IL_23C:
			char[] array2 = new char[array.Length * 2];
			for (int i = 0; i < array.Length; i++)
			{
				array[i].ToString("x2", 1209.3).CopyTo(0, array2, i * 2, 2);
			}
			text5 = new string(array2);
			goto IL_D2;
			IL_28E:
			text5 = text4;
			goto IL_D2;
		}

		// Token: 0x04003A32 RID: 14898
		public 1459 1;

		// Token: 0x04003A33 RID: 14899
		public 456 2;

		// Token: 0x04003A34 RID: 14900
		public 1459.1461 3;
	}

	// Token: 0x02000AF2 RID: 2802
	public sealed class 1460
	{
		// Token: 0x06004E0C RID: 19980 RVA: 0x001EDF14 File Offset: 0x001EC114
		internal void 1()
		{
			1459.1464 <<EMPTY_NAME>> = new 1459.1464();
			<<EMPTY_NAME>>.2 = this;
			if (this.1 != this.2.1.12)
			{
				return;
			}
			<<EMPTY_NAME>>.1 = null;
			if (1272.5() != null && !string.IsNullOrEmpty(1272.5().22))
			{
				1677 2 = 1662.78;
				switch (2)
				{
				case 1677.Edit:
				case 1677.Play:
				case 1677.SelectEdit:
				case 1677.SelectPlay:
				case 1677.Rank:
					break;
				case 1677.Exit:
				case 1677.SelectDrawings:
					goto IL_A8;
				default:
					if (2 - 1677.SelectMulti > 1 && 2 - 1677.RankingTagCoop > 1)
					{
						goto IL_A8;
					}
					break;
				}
				<<EMPTY_NAME>>.1 = 1455.2(1272.5().22, (1416)4, null);
				if (<<EMPTY_NAME>>.1 != null)
				{
					<<EMPTY_NAME>>.1.11 = true;
				}
			}
			IL_A8:
			if (<<EMPTY_NAME>>.1 == null && 1459.8())
			{
				if (this.2.1.18 == null)
				{
					if (this.2.1.16 == null)
					{
						1459.1465 3 = new 1459.1465();
						3.2 = <<EMPTY_NAME>>;
						3.1 = new 1625<List<string>>(1296.6 + "/web/osu-getseasonal.php", Array.Empty<object>());
						this.2.1.16 = 3.1;
						3.1.9(new 1621.1622(3.1));
						this.2.1.16.Start();
					}
				}
				else if (this.2.1() && 1459.7 != null)
				{
					return;
				}
			}
			if (<<EMPTY_NAME>>.1 == null && 1308.1 && !2630.20())
			{
				<<EMPTY_NAME>>.1 = 1455.2("menu-background.jpg", (1416)2, null);
			}
			if (<<EMPTY_NAME>>.1 == null)
			{
				if (this.2.1.15 < 0)
				{
					this.2.1.15 = 1196.2(1, 8);
				}
				else if (1662.78 == 1677.Menu && (double)1662.33 > (double)2470.53 * 1.2)
				{
					this.2.1.15 = Math.Max(1, (this.2.1.15 + 1) % 8);
				}
				<<EMPTY_NAME>>.1 = 1455.2("menu-background-" + this.2.1.15.ToString(), (1416)1, null);
			}
			if (<<EMPTY_NAME>>.1 == null)
			{
				<<EMPTY_NAME>>.1 = 1455.2("menu-background", (1416)1, null);
			}
			if (<<EMPTY_NAME>>.1 != null)
			{
				1662.89.Schedule(new 1189(<<EMPTY_NAME>>.1), false);
			}
		}

		// Token: 0x04003A36 RID: 14902
		public int 1;

		// Token: 0x04003A37 RID: 14903
		public 1459.1467 2;
	}
}
