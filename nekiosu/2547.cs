using System;
using System.Collections.Generic;

// Token: 0x020004E3 RID: 1251
[276]
public sealed class 2547 : 1474
{
	// Token: 0x17000250 RID: 592
	// (get) Token: 0x06002659 RID: 9817 RVA: 0x000BB70F File Offset: 0x000B990F
	internal 1436 Layer
	{
		get
		{
			return this.3;
		}
	}

	// Token: 0x0600265A RID: 9818 RVA: 0x000BB717 File Offset: 0x000B9917
	public 2547() : base(1662.11)
	{
		this.3 = new 1436(true);
		this.Initialize();
	}

	// Token: 0x0600265B RID: 9819 RVA: 0x000BB741 File Offset: 0x000B9941
	protected override void Dispose(bool 1)
	{
		this.3.Dispose();
		base.Dispose(1);
	}

	// Token: 0x0600265C RID: 9820 RVA: 0x000BB758 File Offset: 0x000B9958
	public override void Initialize()
	{
		int num = 1662.70.2() / 2 - 40;
		1433 <<EMPTY_NAME>> = new 1433(1455.2("inputoverlay-background", (1416)7, null), (1376)6, 1065.TopLeft, (1044)0, new 208((float)1662.70.1(), (float)num))
		{
			14 = 1.5707964f,
			20 = new 208(1.05f, 1f),
			5 = true,
			2 = 0.9f
		};
		this.3.12(<<EMPTY_NAME>>);
		float num2 = 0f;
		foreach (object obj in Enum.GetValues(typeof(2547.2549)))
		{
			2547.2549 2 = (2547.2549)obj;
			208 3 = new 208((float)(1662.70.1() - 15), (float)num + 19f + num2);
			2547.2550 4 = new 2547.2550(2, 3);
			this.4.Add(4);
			this.3.14<1433>(4.4);
			num2 += 29.5f;
		}
		base.Initialize();
	}

	// Token: 0x0600265D RID: 9821 RVA: 0x000BB888 File Offset: 0x000B9A88
	public override void Draw()
	{
		this.3.22();
		base.Draw();
	}

	// Token: 0x0600265E RID: 9822 RVA: 0x000BB89C File Offset: 0x000B9A9C
	public override void Update()
	{
		bool <<EMPTY_NAME>> = 1535.24;
		bool flag = 1535.1() || !1304.104;
		2147 2 = 2486.14();
		if (2 != 2147.Osu)
		{
			if (2 == 2147.CatchTheBeat)
			{
				1883 3 = 2486.7.58 as 1883;
				this.1(2547.2549.K1, 3.53);
				this.1(2547.2549.K2, 3.54);
				this.1(2547.2549.M1, 3.51);
			}
		}
		else
		{
			this.1(2547.2549.M1, flag && 1535.15 && !1535.17);
			this.1(2547.2549.M2, flag && 1535.44 && !1535.46);
			this.1(2547.2549.K1, 1535.15 && 1535.17);
			this.1(2547.2549.K2, 1535.44 && 1535.46);
		}
		base.Update();
	}

	// Token: 0x0600265F RID: 9823 RVA: 0x000BB97C File Offset: 0x000B9B7C
	private void 1(2547.2549 1, bool 2)
	{
		2547.2548 buttonFinder = new 2547.2548();
		buttonFinder.1 = 4;
		2547.2550 3 = this.4.Find((2547.2550 1) => 1.9 == buttonFinder.1);
		if (3 == null)
		{
			return;
		}
		3.2(2);
	}

	// Token: 0x04001B40 RID: 6976
	private 1436 3;

	// Token: 0x04001B41 RID: 6977
	private List<2547.2550> 4 = new List<2547.2550>();

	// Token: 0x020004E4 RID: 1252
	[276]
	public sealed class 2550
	{
		// Token: 0x06002660 RID: 9824 RVA: 0x000BB9C8 File Offset: 0x000B9BC8
		public 2550(2547.2549 1, 208 2)
		{
			this.9 = 1;
			this.5 = new 1433(1455.2("inputoverlay-key", (1416)7, null), (1376)6, 1065.Centre, (1044)0, 2)
			{
				5 = true,
				2 = 0.98f
			};
			this.4.Add(this.5);
			if (!1662.47)
			{
				if (string.IsNullOrEmpty(this.1()))
				{
					this.5.6 = 198.LightGray;
					this.5.16 = 0.5f;
					return;
				}
				1452 3 = new 1452(this.1(), 12f, 2, 1f, true, 2630.HudSkin.Colours["InputOverlayText"]);
				3.49 = 1065.Centre;
				3.62(198.White);
				this.6 = 3;
				this.4.Add(this.6);
				this.7 = new 1353(string.Empty, "scoreentry", 1f, (1376)6, 1065.Centre, (1044)0, 2, 1f, true, 2630.HudSkin.Colours["InputOverlayText"], true, (1416)7);
				this.7.16 = 0f;
				this.4.Add(this.7);
			}
		}

		// Token: 0x06002661 RID: 9825 RVA: 0x000BBB4C File Offset: 0x000B9D4C
		private string 1()
		{
			if (2486.14() != 2147.CatchTheBeat)
			{
				return this.9.ToString();
			}
			string result;
			switch (this.9)
			{
			case 2547.2549.K1:
				result = "L";
				break;
			case 2547.2549.K2:
				result = "R";
				break;
			case 2547.2549.M1:
				result = "D";
				break;
			default:
				result = string.Empty;
				break;
			}
			return result;
		}

		// Token: 0x06002662 RID: 9826 RVA: 0x000BBBB0 File Offset: 0x000B9DB0
		internal void 2(bool 1)
		{
			if (this.10 == 3)
			{
				return;
			}
			this.10 = 3;
			if (this.10)
			{
				if (!1662.47)
				{
					this.6.16(100, (1046)0, 0);
					this.7.FadeIn(100, (1046)0, 0);
				}
				if (!2648.6 && !2486.13 && !2486.83)
				{
					this.8++;
				}
				if (!1662.47)
				{
					this.7.SetText(this.8.ToString());
				}
				2547.2549 2 = this.9;
				if (2 > 2547.2549.K2)
				{
					if (2 - 2547.2549.M1 <= 1)
					{
						this.5.39(this.3, 0, false, (1046)0);
					}
				}
				else
				{
					this.5.39(this.2, 0, false, (1046)0);
				}
				this.4.ForEach(new Action<1433>(2547.2550.2551.inputKeyCallbacks.1));
				return;
			}
			this.5.39(this.1, 100, false, (1046)0);
			this.4.ForEach(delegate(1433 1)
			{
				1.3.Add(new 1445(1456.Scale, this.5.15, 1f, 1662.33, 1662.33 + 160, (1046)1));
			});
		}

		// Token: 0x04001B42 RID: 6978
		private 198 1 = 198.White;

		// Token: 0x04001B43 RID: 6979
		private 198 2 = new 198(byte.MaxValue, 222, 0);

		// Token: 0x04001B44 RID: 6980
		private 198 3 = new 198(248, 0, 158);

		// Token: 0x04001B45 RID: 6981
		internal List<1433> 4 = new List<1433>();

		// Token: 0x04001B46 RID: 6982
		internal 1433 5;

		// Token: 0x04001B47 RID: 6983
		internal 1433 6;

		// Token: 0x04001B48 RID: 6984
		internal 1353 7;

		// Token: 0x04001B49 RID: 6985
		internal int 8;

		// Token: 0x04001B4A RID: 6986
		internal 2547.2549 9;

		// Token: 0x04001B4B RID: 6987
		private bool 10;

		// Token: 0x020004E5 RID: 1253
		[276]
		[Serializable]
		public sealed class 2551
		{
			// Token: 0x06002664 RID: 9828 RVA: 0x000BBCFC File Offset: 0x000B9EFC
			internal void 1(1433 1)
			{
				1.3.RemoveAll(new Predicate<1445>(2547.2550.2551.inputKeyCallbacks.2));
				1.3.Add(new 1445(1456.Scale, 1f, 0.8f, 1662.33, 1662.33 + 160, (1046)1));
			}

			// Token: 0x06002665 RID: 9829 RVA: 0x000AAB47 File Offset: 0x000A8D47
			internal bool 2(1445 1)
			{
				return 1.14 == 1456.Scale;
			}

			// Token: 0x04001B4C RID: 6988
			public static readonly 2547.2550.2551 inputKeyCallbacks = new 2547.2550.2551();

			// Token: 0x04001B4D RID: 6989
			public static Predicate<1445> predicate;

			// Token: 0x04001B4E RID: 6990
			public static Action<1433> action;
		}
	}

	// Token: 0x020004E6 RID: 1254
	[276]
	public sealed class 2548
	{
		// Token: 0x04001B4F RID: 6991
		public 2547.2549 1;
	}

	// Token: 0x020004E7 RID: 1255
	[276]
	public enum 2549
	{
		// Token: 0x04001B51 RID: 6993
		K1,
		// Token: 0x04001B52 RID: 6994
		K2,
		// Token: 0x04001B53 RID: 6995
		M1,
		// Token: 0x04001B54 RID: 6996
		M2
	}
}
