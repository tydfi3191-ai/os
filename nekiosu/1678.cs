using System;
using System.Security.Cryptography;

// Token: 0x0200089C RID: 2204
public sealed class 1678 : 2535
{
	// Token: 0x06003F1E RID: 16158 RVA: 0x001877E0 File Offset: 0x001859E0
	public 1678() : base(true)
	{
		this.Initialize();
		1535.40((1082)8, new 1081(this.OnClick), 1545.Highest, (1559)1);
	}

	// Token: 0x06003F1F RID: 16159 RVA: 0x00187872 File Offset: 0x00185A72
	internal new int 1()
	{
		return this.12;
	}

	// Token: 0x06003F20 RID: 16160 RVA: 0x0018787A File Offset: 0x00185A7A
	internal void 2(int 1)
	{
		if (this.12 != 1)
		{
			this.12 = 1;
			this.Show();
		}
	}

	// Token: 0x06003F21 RID: 16161 RVA: 0x00187894 File Offset: 0x00185A94
	private bool OnClick(object 1, EventArgs 2)
	{
		if (this.14 != null && this.14.16 == 1f)
		{
			if (this.14.IsHovered())
			{
				1436 3 = this.10;
				1433 4 = new 1433("coins-error", new 208(0f, 0f), (1416)7, 1065.Centre, (1376)10)
				{
					2 = 0.9f,
					15 = 1.4f
				};
				1433 5 = 4;
				3.12(4);
				5.5 = false;
				5.16(5000, (1046)18, 0);
				5.25(1f, 200, (1046)25);
				this.6();
			}
			else
			{
				this.14.16(100, (1046)0, 0);
			}
			this.14.5 = false;
			this.14 = null;
			return true;
		}
		return false;
	}

	// Token: 0x06003F22 RID: 16162 RVA: 0x00187968 File Offset: 0x00185B68
	internal override void Initialize()
	{
		base.Initialize();
		1436 <<EMPTY_NAME>> = this.1;
		1433 2 = new 1433("coins-buy", new 208(-35f, -10f), (1416)7, 1065.Centre, (1376)7)
		{
			2 = 0.88f
		};
		1433 3 = 2;
		this.7 = 2;
		<<EMPTY_NAME>>.12(3);
		1436 4 = this.1;
		1433 5 = new 1433("coins-bg", new 208(0f, -10f), (1416)7, 1065.Centre, (1376)7)
		{
			2 = 0.9f
		};
		3 = 5;
		this.4 = 5;
		4.12(3);
		1436 6 = this.1;
		1433 7 = new 1433("coins", new 208(0f, -15f), (1416)7, 1065.Centre, (1376)7)
		{
			2 = 0.98f,
			15 = 0.55f
		};
		3 = 7;
		this.5 = 7;
		6.12(3);
		this.7.3(new EventHandler(this.3));
		this.7.10 = true;
		this.7.42 = new 1445(198.White, 198.HotPink, 0, 100);
		1436 8 = this.1;
		1452 9 = new 1452(string.Empty, 16f, new 208(0f, 0f), 1f, true, 198.White);
		9.41 = (1376)7;
		9.49 = 1065.Centre;
		9.63(false);
		1452 10 = 9;
		this.6 = 9;
		8.12(10);
		this.1.28.ForEach(new Action<1371>(1678.1680.coinsOverlayCallbacks.1));
		1621 11 = new 1621(string.Format(1296.6 + "/web/coins.php?action=check&u={0}&h={1}&c={2}&cs={3}", new object[]
		{
			1304.189,
			1304.186.1(1643.Hashed),
			this.1(),
			this.8()
		}), Array.Empty<object>());
		11.9(new 1621.1622(this.5));
		11.Start();
	}

	// Token: 0x06003F23 RID: 16163 RVA: 0x00187B64 File Offset: 0x00185D64
	private void 3(object 1, EventArgs 2)
	{
		if (this.14 != null)
		{
			this.14.5 = false;
			this.14 = null;
		}
		1436 3 = this.10;
		1433 4 = new 1433("coins-dialog", new 208(0f, 0f), (1416)7, 1065.Centre, (1376)10);
		4.2 = 0.9f;
		1433 5 = 4;
		this.14 = 4;
		3.12(5);
		this.14.3(delegate(object 1, EventArgs 2)
		{
		});
		this.14.15(100);
		this.14.10 = true;
	}

	// Token: 0x06003F24 RID: 16164 RVA: 0x00187C0C File Offset: 0x00185E0C
	private void Show()
	{
		if (!1662.21())
		{
			return;
		}
		if (this.13 >= 0)
		{
			if (this.12 < 5)
			{
				this.7.FadeIn(300, (1046)0, 0);
			}
			this.13 = 1662.33;
			return;
		}
		1662.89.2(new 1189(this.9), 500, false);
	}

	// Token: 0x06003F25 RID: 16165 RVA: 0x00187C70 File Offset: 0x00185E70
	private void Hide()
	{
		if (this.13 >= 0)
		{
			this.13 = -1;
			this.1.28.ForEach(new Action<1371>(1678.1680.coinsOverlayCallbacks.3));
			this.5.16(300, (1046)0, 0);
			this.6.16(300, (1046)0, 0);
			this.7.16(300, (1046)0, 0);
			1662.89.2(delegate
			{
				this.4.16(300, (1046)0, 0);
			}, 200, false);
		}
	}

	// Token: 0x06003F26 RID: 16166 RVA: 0x00187D00 File Offset: 0x00185F00
	internal bool 4()
	{
		if (!1662.21())
		{
			return true;
		}
		int num = this.1();
		this.2(num - 1);
		1621 <<EMPTY_NAME>> = new 1621(string.Format(1296.6 + "/web/coins.php?action=use&u={0}&h={1}&c={2}&cs={3}", new object[]
		{
			1304.189,
			1304.186.1(1643.Hashed),
			this.1(),
			this.8()
		}), Array.Empty<object>());
		<<EMPTY_NAME>>.9(new 1621.1622(this.5));
		<<EMPTY_NAME>>.Start();
		return true;
	}

	// Token: 0x06003F27 RID: 16167 RVA: 0x00187D90 File Offset: 0x00185F90
	private void 5(1621 1, Exception 2)
	{
		1678.1679 coinCountResponse = new 1678.1679();
		coinCountResponse.1 = this;
		coinCountResponse.2 = 1;
		1662.89.2(delegate
		{
			coinCountResponse.1.2(int.Parse(coinCountResponse.2.12(), 1662.18));
		}, Math.Max(0, 2470.53 - 1662.33), false);
	}

	// Token: 0x06003F28 RID: 16168 RVA: 0x00187DF0 File Offset: 0x00185FF0
	internal bool 6()
	{
		if (!1662.21())
		{
			return true;
		}
		1621 <<EMPTY_NAME>> = new 1621(string.Format(1296.6 + "/web/coins.php?action=recharge&u={0}&h={1}&c={2}&cs={3}", new object[]
		{
			1304.189,
			1304.186.1(1643.Hashed),
			this.1(),
			this.8()
		}), Array.Empty<object>());
		<<EMPTY_NAME>>.9(new 1621.1622(this.5));
		<<EMPTY_NAME>>.9(new 1621.1622(1678.1680.coinsOverlayCallbacks.4));
		<<EMPTY_NAME>>.Start();
		return true;
	}

	// Token: 0x06003F29 RID: 16169 RVA: 0x00187E88 File Offset: 0x00186088
	internal bool 7()
	{
		1678.1681 <<EMPTY_NAME>> = new 1678.1681();
		if (!1662.21())
		{
			return true;
		}
		<<EMPTY_NAME>>.2 = this.9.Clone();
		<<EMPTY_NAME>>.2.17 = 1535.6 / 1662.70.3();
		<<EMPTY_NAME>>.2.2 = 0.99f;
		<<EMPTY_NAME>>.2.16(1500, (1046)0, 0);
		this.10.12(<<EMPTY_NAME>>.2);
		this.8.2(<<EMPTY_NAME>>.2, new 208?(new 208((float)1196.3() * 100f, (float)1196.3() * -100f)), false);
		<<EMPTY_NAME>>.1 = this.9.Clone();
		<<EMPTY_NAME>>.1.28 = true;
		<<EMPTY_NAME>>.1.29(new 1189(<<EMPTY_NAME>>.1));
		<<EMPTY_NAME>>.1.16(500, (1046)0, 0);
		this.10.12(<<EMPTY_NAME>>.1);
		1226.24("coins-earn", 80, (1416)3, false);
		int num = this.1();
		this.2(num + 1);
		1621 2 = new 1621(string.Format(1296.6 + "/web/coins.php?action=earn&u={0}&h={1}&c={2}&cs={3}", new object[]
		{
			1304.189,
			1304.186.1(1643.Hashed),
			this.1(),
			this.8()
		}), Array.Empty<object>());
		2.9(new 1621.1622(this.5));
		2.Start();
		return true;
	}

	// Token: 0x06003F2A RID: 16170 RVA: 0x0018801B File Offset: 0x0018621B
	internal override void Draw()
	{
		base.Draw();
		this.10.22();
	}

	// Token: 0x06003F2B RID: 16171 RVA: 0x00188030 File Offset: 0x00186230
	internal override void Update()
	{
		if (this.13 >= 0 && 1662.33 > this.13 + this.3)
		{
			this.Hide();
		}
		if (this.7.IsHovered())
		{
			this.Show();
		}
		if (this.6.16 == 1f && this.12 != this.11)
		{
			if (this.12 > this.11)
			{
				this.11++;
			}
			else
			{
				1226.24("coins-use", 100, (1416)3, false);
				1433 <<EMPTY_NAME>> = this.9.Clone();
				<<EMPTY_NAME>>.17 = new 208((float)(1662.70.1() / 2), 35f);
				<<EMPTY_NAME>>.15 = 0.5f;
				<<EMPTY_NAME>>.2 = 0.5f;
				<<EMPTY_NAME>>.16(1000, (1046)0, 0);
				this.1.12(<<EMPTY_NAME>>);
				this.8.2(<<EMPTY_NAME>>, null, false);
				this.11--;
			}
			this.6.SetText(this.11.ToString(1662.18));
			this.6.62((this.11 > 0) ? 198.Gray : 198.Red);
			this.Show();
		}
		base.Update();
		this.8.3();
	}

	// Token: 0x06003F2C RID: 16172 RVA: 0x00188198 File Offset: 0x00186398
	private string 8()
	{
		string s = 1304.189 + this.12.ToString() + "osuycoins";
		byte[] array = 1209.2.GetBytes(s);
		MD5 <<EMPTY_NAME>> = 1209.1;
		string result;
		lock (<<EMPTY_NAME>>)
		{
			try
			{
				array = 1209.1.ComputeHash(array);
			}
			catch (Exception)
			{
				result = "fail";
				goto IL_AD;
			}
		}
		char[] array2 = new char[array.Length * 2];
		for (int i = 0; i < array.Length; i++)
		{
			array[i].ToString("x2", 1209.3).CopyTo(0, array2, i * 2, 2);
		}
		return new string(array2);
		IL_AD:
		return result;
	}

	// Token: 0x06003F2D RID: 16173 RVA: 0x00188274 File Offset: 0x00186474
	private void 9()
	{
		this.13 = 1662.33;
		this.1.28.ForEach(new Action<1371>(1678.1680.coinsOverlayCallbacks.2));
		this.4.FadeIn(300, (1046)0, 0);
		1662.89.2(new 1189(this.10), 300, false);
	}

	// Token: 0x06003F2E RID: 16174 RVA: 0x001882DC File Offset: 0x001864DC
	private void 10()
	{
		this.5.FadeIn(300, (1046)0, 0);
		this.6.FadeIn(300, (1046)0, 0);
		if (this.12 < 5)
		{
			this.7.FadeIn(300, (1046)0, 0);
		}
	}

	// Token: 0x04002E29 RID: 11817
	private int 3 = 3000;

	// Token: 0x04002E2A RID: 11818
	private 1433 4;

	// Token: 0x04002E2B RID: 11819
	private 1433 5;

	// Token: 0x04002E2C RID: 11820
	private 1452 6;

	// Token: 0x04002E2D RID: 11821
	private 1433 7;

	// Token: 0x04002E2E RID: 11822
	private 1400 8 = new 1400();

	// Token: 0x04002E2F RID: 11823
	private 1433 9 = new 1433("coin", new 208(0f, 0f), (1416)7, 1065.Centre, (1376)6)
	{
		15 = 0.8f
	};

	// Token: 0x04002E30 RID: 11824
	private 1436 10 = new 1436(true)
	{
		47 = true
	};

	// Token: 0x04002E31 RID: 11825
	private int 11;

	// Token: 0x04002E32 RID: 11826
	private int 12 = -1;

	// Token: 0x04002E33 RID: 11827
	private int 13 = -1;

	// Token: 0x04002E34 RID: 11828
	private 1433 14;

	// Token: 0x0200089D RID: 2205
	public sealed class 1681
	{
		// Token: 0x06003F30 RID: 16176 RVA: 0x0018833C File Offset: 0x0018653C
		internal void 1()
		{
			this.1.17 = this.2.17;
		}

		// Token: 0x04002E35 RID: 11829
		public 1433 1;

		// Token: 0x04002E36 RID: 11830
		public 1433 2;
	}

	// Token: 0x0200089E RID: 2206
	[Serializable]
	public sealed class 1680
	{
		// Token: 0x06003F32 RID: 16178 RVA: 0x00188354 File Offset: 0x00186554
		internal void 1(1371 1)
		{
			1.16 = 0f;
		}

		// Token: 0x06003F33 RID: 16179 RVA: 0x00188361 File Offset: 0x00186561
		internal void 2(1371 1)
		{
			1.22(new 208(0f, 35f), 500, (1046)1);
		}

		// Token: 0x06003F34 RID: 16180 RVA: 0x0018837E File Offset: 0x0018657E
		internal void 3(1371 1)
		{
			1.22(new 208(0f, -35f), 500, (1046)2);
		}

		// Token: 0x06003F35 RID: 16181 RVA: 0x0018839B File Offset: 0x0018659B
		internal void 4(1621 1, Exception 2)
		{
			1226.24("coins-recharge", 100, (1416)3, false);
		}

		// Token: 0x04002E37 RID: 11831
		public static readonly 1678.1680 coinsOverlayCallbacks = new 1678.1680();

		// Token: 0x04002E38 RID: 11832
		public static Action<1371> action;

		// Token: 0x04002E39 RID: 11833
		public static EventHandler eventHandler;

		// Token: 0x04002E3A RID: 11834
		public static Action<1371> action2;

		// Token: 0x04002E3B RID: 11835
		public static Action<1371> action3;

		// Token: 0x04002E3C RID: 11836
		public static 1621.1622 requestCompletedHandler;
	}

	// Token: 0x0200089F RID: 2207
	public sealed class 1679
	{
		// Token: 0x06003F38 RID: 16184 RVA: 0x001883B8 File Offset: 0x001865B8
		internal void Apply()
		{
			this.1.2(int.Parse(this.2.12(), 1662.18));
		}

		// Token: 0x04002E3D RID: 11837
		public 1678 1;

		// Token: 0x04002E3E RID: 11838
		public 1621 2;
	}
}
