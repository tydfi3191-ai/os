using System;
using System.Collections.Generic;

// Token: 0x020008EE RID: 2286
public sealed class 1751
{
	// Token: 0x0600412C RID: 16684 RVA: 0x0019483C File Offset: 0x00192A3C
	public 1751(208 1, params 2023[] 2)
	{
		this.4 = new List<2023>(2);
		foreach (2023 3 in 2)
		{
			1433 4 = new 1433(1455.2("selection-mod-" + 3.ToString().ToLower(), (1416)7, null), (1376)6, 1065.Centre, (1044)0, 1, 0.94f, true, 198.TransparentWhite, null);
			4.9 = (int)3;
			4.35(new EventHandler(1751.1752.instance.1));
			4.3(new EventHandler(this.OnClick));
			4.10 = true;
			if (2486.14() != 2147.Osu)
			{
				try
				{
					4.52 = 1568.1((2679)Enum.Parse(typeof(2679), "ModSelection_Mod_" + 3.ToString() + "_" + 2486.14().ToString()));
				}
				catch
				{
				}
			}
			if (4.52 == null)
			{
				try
				{
					4.52 = 1568.1((2679)Enum.Parse(typeof(2679), "ModSelection_Mod_" + 3.ToString()));
				}
				catch
				{
				}
			}
			this.1.Add(4);
		}
		this.2 = new 1433(1455.2("lighting", (1416)1, null), 1065.Centre, 1, 0.99f, true, 198.SkyBlue);
		this.2.16 = 0f;
		this.2.28 = true;
		this.1.Add(this.2);
	}

	// Token: 0x0600412D RID: 16685 RVA: 0x00194A04 File Offset: 0x00192C04
	internal void 1(bool 1, 2023 2, bool 3)
	{
		1751.1753 4 = new 1751.1753();
		4.1 = 2;
		this.1.ForEach(new Action<1433>(1751.1752.instance.2));
		2023 5 = this.3;
		if (!1)
		{
			this.3 = 2023.None;
			this.1[0].FadeIn(100, (1046)0, 0);
		}
		else
		{
			1433 6 = this.1.Find(new Predicate<1433>(4.1));
			if (6 == null || 4.1 == 2023.None)
			{
				6 = this.1[0];
			}
			this.3 = (2023)6.9;
			6.FadeIn(100, (1046)0, 0);
			6.25(1.2f, 400, (1046)25);
			6.26(0.1f, 400, (1046)25);
		}
		this.2.24((this.3 == 2023.None) ? 0f : 0.2f, 100, (1046)0);
		if (5 != this.3 && 3)
		{
			1226.20(null, (this.3 != 2023.None) ? "check-on" : "check-off", 1f, false);
		}
		if (this.5 != null)
		{
			this.5(this, null);
		}
	}

	// Token: 0x0600412E RID: 16686 RVA: 0x00194B3C File Offset: 0x00192D3C
	internal void 2(bool 1)
	{
		if (this.3 == 2023.None)
		{
			this.1(true, this.4[1 ? (this.4.Count - 1) : 0], true);
			return;
		}
		if (this.4[(!1) ? (this.4.Count - 1) : 0] == this.3)
		{
			this.1(false, 2023.None, true);
			return;
		}
		this.1(true, this.4[this.4.FindIndex(new Predicate<2023>(this.3)) + ((!1) ? 1 : -1)], true);
	}

	// Token: 0x0600412F RID: 16687 RVA: 0x00194BDA File Offset: 0x00192DDA
	private void OnClick(object 1, EventArgs 2)
	{
		if (this.6 != null && 1555.4() == 199.Pressed)
		{
			this.6();
			return;
		}
		this.2(1555.4() == 199.Pressed);
	}

	// Token: 0x06004130 RID: 16688 RVA: 0x00194C06 File Offset: 0x00192E06
	private bool 3(2023 1)
	{
		return 1 == this.3;
	}

	// Token: 0x04002FA6 RID: 12198
	internal List<1433> 1 = new List<1433>();

	// Token: 0x04002FA7 RID: 12199
	private 1433 2;

	// Token: 0x04002FA8 RID: 12200
	public 2023 3;

	// Token: 0x04002FA9 RID: 12201
	internal List<2023> 4;

	// Token: 0x04002FAA RID: 12202
	internal EventHandler 5;

	// Token: 0x04002FAB RID: 12203
	internal Action 6;

	// Token: 0x020008EF RID: 2287
	[Serializable]
	public sealed class 1752
	{
		// Token: 0x06004131 RID: 16689 RVA: 0x00194C14 File Offset: 0x00192E14
		internal void 1(object 1, EventArgs 2)
		{
			1226.20(null, "click-short", 1f, false);
		}

		// Token: 0x06004132 RID: 16690 RVA: 0x00194C3A File Offset: 0x00192E3A
		internal void 2(1433 1)
		{
			1.16(100, (1046)0, 0);
			1.25(1f, 400, (1046)25);
			1.26(0f, 400, (1046)25);
		}

		// Token: 0x04002FAC RID: 12204
		public static readonly 1751.1752 instance = new 1751.1752();

		// Token: 0x04002FAD RID: 12205
		public static EventHandler eventHandler;

		// Token: 0x04002FAE RID: 12206
		public static Action<1433> action;
	}

	// Token: 0x020008F0 RID: 2288
	public sealed class 1753
	{
		// Token: 0x06004135 RID: 16693 RVA: 0x00194C77 File Offset: 0x00192E77
		internal bool 1(1433 1)
		{
			return 1.9 == (int)this.1;
		}

		// Token: 0x04002FAF RID: 12207
		public 2023 1;
	}
}
