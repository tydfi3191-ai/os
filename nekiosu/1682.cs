using System;
using System.Diagnostics;

// Token: 0x020008A2 RID: 2210
public sealed class 1682 : 2535
{
	// Token: 0x06003F3F RID: 16191 RVA: 0x00188412 File Offset: 0x00186612
	internal 1682() : base(true)
	{
		this.2(true);
		this.6 = new 1328();
		Debug.Listeners.Remove("Default");
		Debug.Listeners.Add(this.6);
	}

	// Token: 0x06003F40 RID: 16192 RVA: 0x0018844D File Offset: 0x0018664D
	internal new bool 1()
	{
		return this.7;
	}

	// Token: 0x06003F41 RID: 16193 RVA: 0x00188455 File Offset: 0x00186655
	internal void 2(bool 1)
	{
		this.7 = 1;
	}

	// Token: 0x06003F42 RID: 16194 RVA: 0x0018845E File Offset: 0x0018665E
	internal void 3()
	{
		this.2(!this.1());
		1763.4("Debug messages are now " + (this.1() ? "visible" : "hidden") + ". Press F11 to toggle.");
	}

	// Token: 0x06003F43 RID: 16195 RVA: 0x00188498 File Offset: 0x00186698
	internal override void Update()
	{
		base.Update();
		if (this.1 != null)
		{
			this.1.5 = (this.1() > false);
		}
		foreach (string text in this.6.1())
		{
			1682.1683 <<EMPTY_NAME>> = new 1682.1683();
			if (text != null && text.Length != 0)
			{
				1338.5(text, 1341.Debug, (1114)0);
				1452 2 = new 1452(text, 9f, 1682.3, 1f, true, 198.White);
				2.41 = (1376)12;
				2.49 = 1065.BottomLeft;
				2.85 = false;
				2.58(1682.5);
				2.74 = false;
				2.63(true);
				<<EMPTY_NAME>>.1 = 2;
				this.1.28.ForEach(new Action<1371>(<<EMPTY_NAME>>.1));
				if (this.1.28.Count > 0 && this.1.28[0].17.Y > 480f)
				{
					this.1.Remove(this.1.28[0]);
				}
				this.1.12(<<EMPTY_NAME>>.1);
				1662.89.2(new 1189(<<EMPTY_NAME>>.2), <<EMPTY_NAME>>.1.GetText().Length * 100, false);
				1662.89.2(new 1189(<<EMPTY_NAME>>.3), 320, false);
			}
		}
	}

	// Token: 0x04002E42 RID: 11842
	private static 208 3 = new 208(0f, 0f);

	// Token: 0x04002E43 RID: 11843
	private static 198 4 = new 198(0, 0, 0, 180);

	// Token: 0x04002E44 RID: 11844
	private static 198 5 = new 198(50, 176, byte.MaxValue, 180);

	// Token: 0x04002E45 RID: 11845
	private 1328 6;

	// Token: 0x04002E46 RID: 11846
	private bool 7;

	// Token: 0x020008A3 RID: 2211
	public sealed class 1683
	{
		// Token: 0x06003F45 RID: 16197 RVA: 0x0018869E File Offset: 0x0018689E
		internal void 1(1371 1)
		{
			1.17.Y = 1.17.Y + (1682.3.Y + this.1.GetTextSize().Y / 0.625f / 1662.70.3());
		}

		// Token: 0x06003F46 RID: 16198 RVA: 0x001886DC File Offset: 0x001868DC
		internal void 2()
		{
			this.1.5 = false;
			this.1.16(200, (1046)18, 0);
			this.1.20(0f - this.1.GetTextSize().X, 200, (1046)18);
		}

		// Token: 0x06003F47 RID: 16199 RVA: 0x00188730 File Offset: 0x00186930
		internal void 3()
		{
			this.1.58(1682.4);
		}

		// Token: 0x04002E47 RID: 11847
		public 1452 1;
	}
}
